using Crm.Common.Interfaces;
using Crm.Infra.Models;

namespace Crm.Infra.Repositories.Interfaces
{
    public interface ICustomerMapper<out T> : IMapper<Customer, T>
    {
    }
}
