using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;


public class StockService : IStockService
{
    private const string NYSE_URL = "http://www.wsj.com/mdc/public/page/2_3024-NYSE.html";
    private string filename_;
    private const int MAX_TRIES = 5;

    /// <summary>
    /// builds the stock file data base on the given url
    /// </summary>
    /// <param name="URL"></param>
    /// <returns></returns>
    public string StockBuild(string URL)
    {
        int retries_ = 0;
        List<string> symbols = new List<string>();
        List<string> open = new List<string>();
        List<string> high = new List<string>();
        List<string> low = new List<string>();
        List<string> close = new List<string>();
        List<string>[] data = { symbols, open, high, low, close };

        //re-execute code block if no data was gathered. Try up to 5 times.
        //this block of code sometimes executes with 0 results so retry
        while (data[0].Count == 0 && retries_ <= MAX_TRIES)
        {
            //make request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(NYSE_URL);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader sr = new StreamReader(stream))
            {
                string line;
                //read html data and look for stock information using regex
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("symbol="))
                    {
                        line = Regex.Match(line, @"symbol=\w+").Value;
                        string symbol = line.Substring(7, line.Length - 7);
                        symbols.Add(symbol);
                        //go to next line
                        line = sr.ReadLine();
                        open.Add(Regex.Match(line, @"\d{1,2}\.\d{1,2}").Value);
                        line = sr.ReadLine();
                        high.Add(Regex.Match(line, @"\d{1,2}\.\d{1,2}").Value);
                        line = sr.ReadLine();
                        low.Add(Regex.Match(line, @"\d{1,2}\.\d{1,2}").Value);
                        line = sr.ReadLine();
                        close.Add(Regex.Match(line, @"\d{1,2}\.\d{1,2}").Value);
                    }
                }
            }
            retries_++;
        }
        retries_ = 0;
        if(data[0].Count != 0)
        {
            //write the stock data out to xml
            filename_ = writeXML(data);
            return filename_;
        }
        else
        {
            return "FAIL";
        }
    }

    /// <summary>
    /// get the stock quote information from the xml file
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public string StockQuote(string symbol)
    {
        string stats = null;
        XmlTextReader reader = null;
        string filename = "Stocks.xml";
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

        try
        {
            reader = new XmlTextReader(path);
            reader.WhitespaceHandling = WhitespaceHandling.None;
            while (reader.Read())
            {
                if(reader.Value == symbol)
                {
                    reader.Read();
                    reader.Read();
                    stats = reader.GetAttribute("open");
                    stats = stats + "," + reader.GetAttribute("high");
                    stats = stats + "," + reader.GetAttribute("low");
                    stats = stats + "," + reader.GetAttribute("close");
                    return stats;
                }
            }
        }
        finally
        {
            if(reader != null)
            {
                reader.Close();
            }
        }
        return null;
    }

    /// <summary>
    /// helper method to write the data out to XML
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    private string writeXML(List<string>[] data)
    {
        string filename = "Stocks.xml";
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
        XmlTextWriter writer = null;
        try
        {
            writer = new XmlTextWriter(path, Encoding.Unicode);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("Stocks");
            for (int i = 0; i < data[0].Count; i++)
            {
                writer.WriteElementString("Stock_number", (i + 1).ToString());
                writer.WriteElementString("Symbol", data[0][i]);
                writer.WriteStartElement("Stats");
                writer.WriteAttributeString("open", data[1][i]);
                writer.WriteAttributeString("high", data[2][i]);
                writer.WriteAttributeString("low", data[3][i]);
                writer.WriteAttributeString("close", data[4][i]);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
        }
        finally 
        {

            if(writer != null)
            {
                writer.Close();
            }
        }
        return filename;
    }
}
