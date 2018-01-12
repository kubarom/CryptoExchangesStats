using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoExchangeStats
{
    public class EtherDeltaHandler : IExchangeHandler
    {
        private Uri _baseUrl = new Uri("https://api.etherdelta.com");

        private readonly string _contractAddress;

        public EtherDeltaHandler(string contractAddress)
        {
            _contractAddress = contractAddress;
        }

        public async Task<IEnumerable<OrderRow>> FetchOrders(HttpClient client)
        {
            var uri = new Uri(_baseUrl, $"orders//{_contractAddress}//0");
            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = await client.SendAsync(request);
            await Task.CompletedTask;

            return null;
        }
    }
}