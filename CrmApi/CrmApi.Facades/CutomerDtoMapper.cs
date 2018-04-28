using System;
using Crm.Common;
using Crm.Dtos;
using Crm.Entities.Interfaces;
using CrmApi.Facades.Interfaces;

namespace CrmApi.Facades
{
    public class CutomerDtoMapper: Mapper<ICustomer,CustomerDto>, ICutomerDtoMapper
    {
        protected override CustomerDto MapInternal(ICustomer item)
        {
            return new CustomerDto()
            {
                id=item.id,Name = item.Name
            };
        }
    }
}
