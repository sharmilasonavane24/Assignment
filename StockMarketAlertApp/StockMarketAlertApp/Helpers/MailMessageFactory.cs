using System.Net.Mail;

namespace StockMarketAlertApp.Helpers
{
    public class MailMessageFactory: IMailMessageFactory
    {
        public MailMessage Create(string from, string to, string subject, string body)
        {
           var mailMessage=new MailMessage();
            mailMessage.To.Add(new MailAddress(to));
            mailMessage.From = new MailAddress(from);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            return mailMessage;
        }
    }
}