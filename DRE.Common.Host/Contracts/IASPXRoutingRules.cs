using System.Collections.Generic;
using System.ServiceModel;
using DRE.Common.Contracts;

namespace DRE.Common.Host.Contracts
{
    [ServiceContract]
    public interface IASPXRoutingRules
    {
        [OperationContract]
        IList<IUrlRoute> GetRoutes();
    }
}
