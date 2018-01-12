using System.Collections.Generic;

namespace CryptoExchangeStats
{
    public interface IExchange
    {
        IEnumerable<ITraidingPair> GetPairs();
    }
}