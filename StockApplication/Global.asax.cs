using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Threading;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Text;

namespace StockApplication
{
    public class Global : System.Web.HttpApplication
    {
        static int count = 0;
        static private object Lock = new object();

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Keep track of number of visitors in an xml file on the session start event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Session_Start(object sender, EventArgs e)
        {
            while (true)
            {
                if (Monitor.TryEnter(Lock))
                {
                    count++;
                    int currentCount = readCount();
                    // make sure the readCount function returned something reasonable 
                    if (currentCount > 0)
                    {
                        count += currentCount;
                        writeCount(count);
                    }
                    return;
                }
            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Helper method for handling the number of visitors to read current value from visitorCount.xml
        /// </summary>
        /// <returns>current visitor count stored in the xml</returns>
        private int readCount()
        {
            int count = 0;
            string filename = "visitorCount.xml";
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
                            if (reader.Name.Equals("VisitorCount"))
                            {
                                count = Convert.ToInt32(reader.GetAttribute(0));
                                //successfully returned count
                                return count;
                            }
                        }
                    }
                    //something went wrong in read
                    return -1;
                }
                finally
                {
                    //clean-up
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
            else
            {
                //something went wrong, probably file does not exist
                return -1;
            }
        }

        /// <summary>
        /// Write the visitor count to visitorCount.xml. Overwrite xml file everytime.
        /// Don't check if file exist.
        /// </summary>
        /// <param name="count"></param>
        private void writeCount(int count)
        {
            string root = "Visitors";
            string filename = "visitorCount.xml";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(path, Encoding.Unicode);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement(root);
                writer.WriteStartElement("VisitorCount");
                writer.WriteAttributeString("count", count.ToString());
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
}