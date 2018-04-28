using System;
using System.Linq;
using System.Threading.Tasks;
using Crm.Dtos;
using Crm.Entities.Interfaces;
using Crm.Infra.Repositories.Interfaces;
using Crm.Services.Interfaces;

namespace Crm.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository<ICustomer> _customerRepository;
        public CustomerService(ICustomerRepository<ICustomer> customerRepository)
        {
            if (customerRepository == null) throw new ArgumentNullException(nameof(customerRepository));
            _customerRepository = customerRepository;
        }

        public async Task<ICustomer[]> GetAllCutomer()
        {

            return await _customerRepository.GetAllCutomer();
        }

        public async Task<ICustomer> GetCutomerById(int id)
        {
            return await _customerRepository.GetCutomerById(id);
        }

        public async Task AddOrUpdateCutomer(CustomerDto customer)
        {
            await _customerRepository.AddOrUpdateCutomer(customer);
        }
    }
}
