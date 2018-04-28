namespace StockMarketAlertApp
{
    public interface IStockObserver
    {
        void Update(double stockMarketPrice);
    }
}