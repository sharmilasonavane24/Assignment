using System.Threading.Tasks;
using StockMarketAlertApp.Helpers;

namespace StockMarketAlertApp.Services
{
    public class EmailAlertService : IEmailAlertService
    {
        private readonly IMailMessageFactory _mailMessageFactory;
        private readonly ISmtpClientFactory _smtpClientFactory;

        public EmailAlertService(IMailMessageFactory mailMessageFactory, ISmtpClientFactory smtpClientFactory)
        {
            _mailMessageFactory = mailMessageFactory ?? throw new System.ArgumentNullException(nameof(mailMessageFactory));
            _smtpClientFactory = smtpClientFactory ?? throw new System.ArgumentNullException(nameof(smtpClientFactory));
        }
        public async Task SendEmail(string body)
        {
            var client = _smtpClientFactory.Create(Constants.Host, Constants.Port, Constants.UserName, Constants.Password);
            var mailMessage = _mailMessageFactory.Create(Constants.From, Constants.To, Constants.Subject,
               $"{Constants.Body}{body}");
            await client.SendMailAsync(mailMessage);

        }
    }
}