using System.Collections.Generic;
using System.Linq;
using Crm.Common.Interfaces;

namespace Crm.Common
{
    public abstract class Mapper<TIn, TOut> :
        IMapper<TIn, TOut>
    {
        public IEnumerable<TOut> Map(IEnumerable<TIn> list)
        {
            return list?.Select(Map);
        }

        public TOut[] Map(TIn[] list)
        {
            return list?.Select(Map).ToArray();
        }

        public TOut Map(TIn item)
        {
            return item == null ? default(TOut) : MapInternal(item);
        }

        protected abstract TOut MapInternal(TIn item);
    }
}