using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Crm.Dtos;
using Crm.Infra.Models;

namespace Crm.Infra.Repositories.Interfaces
{
    public interface ICustomerRepository<T> where T : class
    {
        Task<T[]> GetAllCutomer();
        Task<T> GetCutomerById(int id);
        Task AddOrUpdateCutomer(CustomerDto customer);
    }
}
