using System.Collections.Generic;

namespace Crm.Common.Interfaces
{
    public interface IMapper<in TIn, out TOut>
    {
        IEnumerable<TOut> Map(IEnumerable<TIn> list);

        TOut[] Map(TIn[] list);

        TOut Map(TIn item);
    }
}
