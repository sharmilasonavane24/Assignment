using System;
using System.Globalization;
using StockMarketAlertApp.Services;

namespace StockMarketAlertApp
{
    public class StockObserver : IStockObserver
    {
        private double _currrentStockMarketPrice;
        private readonly IEmailAlertService _emailAlertService;
        public StockObserver(INotificationService notificationService, IEmailAlertService emailAlertService)
        {
            if (notificationService == null) throw new ArgumentNullException(nameof(notificationService));
            _emailAlertService = emailAlertService;
            notificationService.Register(this);
        }
        public void Update(double stockMarketPrice)
        {
           
           if (!_currrentStockMarketPrice.Equals(stockMarketPrice))
            {
                _currrentStockMarketPrice = stockMarketPrice;
                _emailAlertService.SendEmail(_currrentStockMarketPrice.ToString(CultureInfo.InvariantCulture));
                Console.WriteLine($"Current Stock Price: {_currrentStockMarketPrice}");
                Console.WriteLine("Enter New Stock Price: ");

            }
        }
    }
}