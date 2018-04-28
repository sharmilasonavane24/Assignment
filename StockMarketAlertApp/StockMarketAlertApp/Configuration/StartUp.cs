using System;
using StockMarketAlertApp.Helpers;
using StockMarketAlertApp.Services;
using Unity;

namespace StockMarketAlertApp.Configuration
{
    public class StartUp
    {
        private readonly INotificationService _notificationService;
        private readonly IStockObserver _stockObserver;
        public StartUp()
        {
            IUnityContainer unitycontainer = new UnityContainer();

            unitycontainer.RegisterType<IMailMessageFactory, MailMessageFactory>();
            unitycontainer.RegisterType<ISmtpClientFactory, SmtpClientFactory>();
            unitycontainer.RegisterType<IEmailAlertService, EmailAlertService>();
            unitycontainer.RegisterType<INotificationService, NotificationService>();
            unitycontainer.RegisterType<IStockObserver, StockObserver>();

            _notificationService = unitycontainer.Resolve<NotificationService>();
            _stockObserver = unitycontainer.Resolve<StockObserver>();
        }

        public void Run()
        {
            _notificationService.Register(_stockObserver);
            Console.WriteLine("Press X to stop");
            Console.WriteLine("Enter Current Stock Price: ");

            do
            {
                var val = Console.ReadLine();
                if (val == "X" || val == "x")
                {
                    Environment.Exit(0);
                  
                }
                if (double.TryParse(val, out double currentPrice))
                {

                    _notificationService.SetStockMarketPrice(currentPrice);
                }
                else
                {
                    Console.WriteLine("Invalid Stock Price");
                }

            } while (true); //while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}