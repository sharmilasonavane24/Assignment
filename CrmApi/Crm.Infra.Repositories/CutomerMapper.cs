using Crm.Common;
using Crm.Infra.Models;
using Crm.Infra.Repositories.Interfaces;
using Crm.Entities.Interfaces;

namespace Crm.Infra.Repositories
{
    public class CutomerMapper:Mapper<Customer, ICustomer>, ICustomerMapper<ICustomer>
    {
        protected override ICustomer MapInternal(Customer item)
        {
            return new Entities.Customer
            {
                id = item.id,
                Name = item.Name
            };
        }
    }
}

