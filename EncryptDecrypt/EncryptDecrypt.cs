using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace EncryptDecrypt
{
    public class EncryptDecypt
    {
        public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }

        /// <summary>
        /// write the username and password to xml file.  
        /// </summary>
        /// <param name="username">usename of member</param>
        /// <param name="encryptedPass"> password of member</param>
        public static void writeXml(string[] memberData, bool staff)
        {
            string root = "Members";
            string filename = "Member.xml";

            if (staff)
                filename = "Staff.xml";

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            if (File.Exists(path))
            {
                
                var doc = XDocument.Load(path);
                XElement newMember = new XElement("Member");
                newMember.SetAttributeValue("username", memberData[0]);
                newMember.SetAttributeValue("password", memberData[1]);
                //this probably should be in a different location than right next to the password
                newMember.SetAttributeValue("key", memberData[2]);
                newMember.SetAttributeValue("iv", memberData[3]);
                if (staff)
                    root = "StaffMembers";
                doc.Element(root).Add(newMember);
                doc.Save(path);
            }
            else
            {
                XmlTextWriter writer = null;
                try
                {
                    writer = new XmlTextWriter(path, Encoding.Unicode);
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartDocument();
                    if (staff)
                        root = "StaffMembers";
                    writer.WriteStartElement(root);
                    writer.WriteStartElement("Member");
                    writer.WriteAttributeString("username", memberData[0]);
                    writer.WriteAttributeString("password", memberData[1]);
                    //this probably should be in a different location than right next to the password
                    writer.WriteAttributeString("key", memberData[2]);
                    writer.WriteAttributeString("iv", memberData[3]);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
            }
        }

        public static string[] readXml(string username, bool staff)
        {
            string[] memberData = new string[3];
            string filename = "Member.xml";
            if (staff)
                filename = "Staff.xml";

            XmlTextReader reader = null;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

            if (File.Exists(path))
            {
                try
                {
                    reader = new XmlTextReader(path);
                    reader.WhitespaceHandling = WhitespaceHandling.None;
                    while (reader.Read())
                    {
                        if (reader.HasAttributes)
                        {
                            if (reader.GetAttribute(0).Equals(username))
                            {
                                memberData[0] = reader.GetAttribute(1);
                                memberData[1] = reader.GetAttribute(2);
                                memberData[2] = reader.GetAttribute(3);
                                return memberData;
                            }
                        }
                    }
                    return null;
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
            else
            {
                memberData[0] = "FILE NOT FOUND";
                return memberData;
            }
        }
    }
}
