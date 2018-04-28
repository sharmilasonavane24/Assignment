

using Crm.Common.Interfaces;
using Crm.Dtos;
using Crm.Entities.Interfaces;

namespace CrmApi.Facades.Interfaces
{
    public interface ICutomerDtoMapper : IMapper<ICustomer, CustomerDto>
    {
    }
}
