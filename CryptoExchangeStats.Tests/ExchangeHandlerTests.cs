using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CryptoExchangeStats.Tests
{
    [TestFixture]
    public class ExchangeHandlerTests
    {
        public static async Task CreateImpl()
        {
            using (var client = new HttpClient())
            {
                var contractAddress = "0xe3818504c1B32bF1557b16C238B2E01Fd3149C17";

                IExchangeHandler handler = new EtherDeltaHandler(contractAddress);

                IEnumerable<OrderRow> orders =  await handler.FetchOrders(client);
            }
        }
    }
}
