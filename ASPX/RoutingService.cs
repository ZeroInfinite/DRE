using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DRE.Common.Host.Contracts;
using DRE.Common.Contracts;

namespace ASPX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RoutingService : IGetRoutingRules
    {
        public IList<IUrlRoute> GetRoutes()
        {
            throw new NotImplementedException();
        }
    }
}
