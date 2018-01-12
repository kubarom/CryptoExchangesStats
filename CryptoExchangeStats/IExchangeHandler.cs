using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoExchangeStats
{
    public interface IExchangeHandler
    {
        Task<IEnumerable<OrderRow>> FetchOrders(HttpClient client);
    }
}