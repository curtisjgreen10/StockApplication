using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{

    private const string urlPart1 = "https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency=";
    private const string urlPart2 = "&to_currency=";   
    private const string urlPart3 = "&apikey=HG4T6C763RQWYO1S";

    // url format:
    // ur1Part1 + <currency from symbol> + urlPart2 + <currency to symbol> + urlPart3

    /// <summary>
    /// Query exchange rate of currency using REST API. Digital and physical currencies accepted.
    /// </summary>
    /// <param name="currencyFromSymbol"></param>
    /// <param name="currencyToSymbol"></param>
    /// <returns></returns>
    public double queryRate(string currencyFromSymbol, string currencyToSymbol)
    {
        string url = urlPart1 + currencyFromSymbol + urlPart2 + currencyToSymbol + urlPart3;
        string jsonTxt = "";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            //get back json as string
            jsonTxt = reader.ReadToEnd();
        }

        //parse queried json
        JObject dataOut = JObject.Parse(jsonTxt);
        JObject Realtime_Currency_Exchange_Rate = (JObject)dataOut["Realtime Currency Exchange Rate"];
        double exchangeRate = (double)Realtime_Currency_Exchange_Rate["5. Exchange Rate"];
        return exchangeRate;
    }
}
