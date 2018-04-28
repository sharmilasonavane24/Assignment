using System.Net.Mail;

namespace StockMarketAlertApp.Helpers
{
    public interface IMailMessageFactory
    {
        MailMessage Create(string from, string to, string subject,string body);
    }
}