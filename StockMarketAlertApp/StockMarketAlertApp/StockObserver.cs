using System;

namespace StockMarketAlertApp
{
    public class StockObserver : IStockObserver
    {
        private double _currrentStockMarketPrice;
        private INotificationService _notificationService;
        public StockObserver(INotificationService notificationService)
        {
            if (notificationService == null) throw new ArgumentNullException(nameof(notificationService));
            _notificationService = notificationService;
            _notificationService.Register(this);
        }
        public void Update(double stockMarketPrice)
        {
           
           // if (Math.Abs(_currrentStockMarketPrice - stockMarketPrice) <=  Math.Abs(_currrentStockMarketPrice * .00001))
           if (!_currrentStockMarketPrice.Equals(stockMarketPrice))
            {
                _currrentStockMarketPrice = stockMarketPrice;
                Console.WriteLine($"Current Stock Price: {_currrentStockMarketPrice}");
                Console.WriteLine("Enter New Stock Price: ");

            }
        }
    }
}