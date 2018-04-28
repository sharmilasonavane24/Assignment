using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketAlertApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService notification = new NotificationService();
            StockObserver observer = new StockObserver(notification);


            Console.WriteLine("Press ESC to stop");
            Console.WriteLine("Enter Current Stock Price: ");

            do
            {


                if (double.TryParse(Console.ReadLine(), out double currentPrice))
                {

                    notification.SetStockMarketPrice(currentPrice);
                }
                else
                {
                    Console.WriteLine("Invalid Stock Price");
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


            
            
        }
    }
}
