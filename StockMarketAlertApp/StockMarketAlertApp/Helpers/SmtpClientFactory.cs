using System.Net;
using System.Net.Mail;

namespace StockMarketAlertApp.Helpers
{
    public class SmtpClientFactory: ISmtpClientFactory
    {
        public SmtpClient Create(string host, int port, string userName, string password)
        {
            var client = new SmtpClient
            {
                Host = host,
                Port = port,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true,
                Credentials = new NetworkCredential(userName, password)
            };
            return client;
        }
    }
}