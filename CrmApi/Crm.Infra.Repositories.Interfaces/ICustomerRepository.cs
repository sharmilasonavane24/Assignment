using System.Threading.Tasks;
using Crm.Dtos;

namespace Crm.Infra.Repositories.Interfaces
{
    public interface ICustomerRepository<T> where T : class
    {
        Task<T[]> GetAllCutomer();
        Task<T> GetCutomerById(int id);
        Task AddOrUpdateCutomer(CustomerDto customer);
    }
}
