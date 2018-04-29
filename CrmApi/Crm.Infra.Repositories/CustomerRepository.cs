using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using Crm.Dtos;
using Crm.Infra.Database;
using Crm.Infra.Models;
using Crm.Infra.Repositories.Interfaces;

namespace Crm.Infra.Repositories
{
    public class CustomerRepository<T> : ICustomerRepository<T> where T : class 
    {
         private ICustomerMapper<T> _mapper;
       
        public CustomerRepository(  ICustomerMapper<T> mapper)
        {
             if (mapper == null) throw new ArgumentNullException(nameof(mapper));
             _mapper = mapper;
           
        }

       
        public async  Task<T[]> GetAllCutomer()
        {
            await Task.Delay(1);

            //var customers =await _context.Customer.ToArrayAsync();
             

            return _mapper.Map(CutomerData.CustomerList.ToArray());

        }

        public async Task<T> GetCutomerById(int id)
        {
            await Task.Delay(1);

            //var customers =await _context.Customer.ToArrayAsync();
            var result = CutomerData.CustomerList.FirstOrDefault(s => s.id == id);

            return _mapper.Map(result);

        }

        public async Task AddOrUpdateCutomer(CustomerDto customer)
        {
            await Task.Delay(1);

            //var customers =await _context.Customer.ToArrayAsync();
            var result = CutomerData.CustomerList.FirstOrDefault(s => s.id == customer.id);
            if (result == null)
            {
                CutomerData.CustomerList.Add(new Customer()
                {
                    id=customer.id,
                    Name = customer.Name
                });
            }
            else
            {
                var updateCustomer = CutomerData.CustomerList.FirstOrDefault(d => d.id == customer.id);
                if (updateCustomer != null) { updateCustomer.Name =customer.Name; }
                
            }


        }
    }
}
