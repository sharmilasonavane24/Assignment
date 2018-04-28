using System;
using System.Threading.Tasks;
using Crm.Dtos;
using Crm.Services.Interfaces;
using CrmApi.Facades.Interfaces;

namespace CrmApi.Facades
{
    public class CustomerFacade:ICustomerFacade
    {
        private ICustomerService _customerService;
        private ICutomerDtoMapper _mapper;
        public CustomerFacade(ICustomerService customerService, ICutomerDtoMapper mapper)
        {
            if (customerService == null) throw new ArgumentNullException(nameof(customerService));
            if (mapper == null) throw new ArgumentNullException(nameof(mapper));
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<CustomerDto[]> GetAllCustomer()
        {
            var customer =await _customerService.GetAllCutomer();
            
            return _mapper.Map(customer);
        }

        public async Task<CustomerDto> GetCustomer(int id)
        {
            var customer = await _customerService.GetCutomerById(id);

            return _mapper.Map(customer);
        }

        public async Task AddOrUpdateCutomer(CustomerDto customer)
        {
            await _customerService.AddOrUpdateCutomer(customer);
        }
    }
}