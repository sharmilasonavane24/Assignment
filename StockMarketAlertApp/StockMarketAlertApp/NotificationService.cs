using System.Collections.Generic;

namespace StockMarketAlertApp
{
    public class NotificationService : INotificationService
    {
        private readonly List<IStockObserver> _observers;
        private double _stockMarketPrice;
        public NotificationService()
        {
            _observers = new List<IStockObserver>();
        }
        public void Register(IStockObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnRegister(IStockObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_stockMarketPrice);
            }
        }

        public void SetStockMarketPrice(double newStockMarketPrice)
        {
            _stockMarketPrice = newStockMarketPrice;
            NotifyObserver();
        }
    }
}