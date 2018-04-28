using System.Net.Mail;

namespace StockMarketAlertApp.Helpers
{
    public interface ISmtpClientFactory
    {
        SmtpClient Create(string host, int port, string userName, string password);
    }
}