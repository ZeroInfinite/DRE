using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRE.Common.Contracts
{
    public interface IRoutes
    {
        IList<IUrlRoute> RouteCollection { get; set; }
    }
}
