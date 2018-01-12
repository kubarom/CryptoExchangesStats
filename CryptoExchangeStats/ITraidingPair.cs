namespace CryptoExchangeStats
{
    public interface ITraidingPair
    {
        ICurrency Base { get; }
        ICurrency Trading { get; }
    }
}