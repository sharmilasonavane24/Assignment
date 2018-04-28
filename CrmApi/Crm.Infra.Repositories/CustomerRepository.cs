using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using Crm.Dtos;
using Crm.Infra.Models;
using Crm.Infra.Repositories.Interfaces;

namespace Crm.Infra.Repositories
{
    public class CustomerRepository<T> : ICustomerRepository<T> where T : class 
    {
         private ICustomerMapper<T> _mapper;
        private List<Customer> customers;
        public CustomerRepository(  ICustomerMapper<T> mapper)
        {
             if (mapper == null) throw new ArgumentNullException(nameof(mapper));
             _mapper = mapper;
            customers = new List<Customer>()
            {
                new Customer(){id=1,Name = "Sharmila"},
                new Customer(){id=2,Name = "Amit"},
                new Customer(){id=3,Name = "Ashley"}
            };
        }

       
        public async  Task<T[]> GetAllCutomer()
        {
            await Task.Delay(1);

            //var customers =await _context.Customer.ToArrayAsync();
             

            return _mapper.Map(customers.ToArray());

        }

        public async Task<T> GetCutomerById(int id)
        {
            await Task.Delay(1);

            //var customers =await _context.Customer.ToArrayAsync();
            var result = customers.FirstOrDefault(s => s.id == id);

            return _mapper.Map(result);

        }

        public async Task AddOrUpdateCutomer(CustomerDto customer)
        {
            await Task.Delay(1);

            //var customers =await _context.Customer.ToArrayAsync();
            var result = customers.FirstOrDefault(s => s.id == customer.id);
            if (result == null)
            {
                customers.Add(new Customer()
                {
                    id=customer.id,
                    Name = customer.Name
                });
            }
            else
            {
                var updateCustomer = customers.FirstOrDefault(d => d.id == customer.id);
                if (updateCustomer != null) { updateCustomer.Name =customer.Name; }
            }


        }
    }
}
