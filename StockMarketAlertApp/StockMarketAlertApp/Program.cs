using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using StockMarketAlertApp.Configuration;
using StockMarketAlertApp.Helpers;
using StockMarketAlertApp.Services;
using Unity;

namespace StockMarketAlertApp
{
    class Program
    {
        static void Main(string[] args)
        {

           var start =new StartUp();

            start.Run();

        }

      
    }
}
