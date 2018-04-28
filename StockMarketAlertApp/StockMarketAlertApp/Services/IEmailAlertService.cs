using System.Threading.Tasks;

namespace StockMarketAlertApp.Services
{
    public interface IEmailAlertService
    {
        Task SendEmail(string body);
    }
}