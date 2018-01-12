using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Internal.Builders;

namespace CryptoExchangeStats.Tests
{
    [TestFixture]
    public class ExchangeTests
    {
        [Test]
        public static void ShouldCreateInterfaceImpl()
        {
            IExchange exchange = null;

            IEnumerable<ITraidingPair> pairs =  exchange.GetPairs();

            foreach (var pair in pairs)
            {
                ICurrency b = pair.Base;
                ICurrency t = pair.Trading;
            }
        }
    }
}