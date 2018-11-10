using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IStockService
{
    [OperationContract]
    string StockBuild(string URL);

    [OperationContract]
    string StockQuote(string symbol);
}
