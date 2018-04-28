using System;
using System.Threading.Tasks;
using Crm.Dtos;
using Crm.Entities.Interfaces;

namespace Crm.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<ICustomer[]> GetAllCutomer();
        Task<ICustomer> GetCutomerById(int id);

        Task AddOrUpdateCutomer(CustomerDto customer);
    }
}
