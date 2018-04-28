using System.Threading.Tasks;
using Crm.Dtos;

namespace CrmApi.Facades.Interfaces
{
    public interface ICustomerFacade
    {
        Task<CustomerDto[]> GetAllCustomer();
        Task<CustomerDto> GetCustomer(int id);
        Task AddOrUpdateCutomer(CustomerDto customer);
    }
}