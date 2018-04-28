using System;
using System.Threading.Tasks;
using System.Web.Http;
using Crm.Dtos;
using CrmApi.Facades.Interfaces;


namespace CrmApi.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerFacade _customerFacade;

        public CustomerController(ICustomerFacade customerFacade)
        {
            if (customerFacade == null) throw new ArgumentNullException(nameof(customerFacade));
            _customerFacade = customerFacade;
        }

        // GET: api/Customer
        public async Task<CustomerDto[]>Get()
        {
            return await _customerFacade.GetAllCustomer();
        }

        // GET: api/Customer/5
        public async Task<CustomerDto>Get(int id)
        {
            return await _customerFacade.GetCustomer(id);
        }

        

        // PUT: api/Customer/5?name="name"
        public void Put(int id, string name)
        {
            var cutomer=new CustomerDto()
            {
                id = id,Name = name
            };
            _customerFacade.AddOrUpdateCutomer(customer: cutomer);
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
