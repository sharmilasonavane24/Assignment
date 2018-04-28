namespace StockMarketAlertApp
{
    public interface INotificationService
    {
        void Register(IStockObserver observer);

        void UnRegister(IStockObserver observer);

        void NotifyObserver();
        void SetStockMarketPrice(double newStockMarketPrice);
    }
}