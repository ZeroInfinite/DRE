using System.Collections.Generic;
using System.ServiceModel;
using System.Xml;
using DRE.Common.Contracts;

namespace DRE.Service.Routing
{
    [ServiceContract]
    public interface IRoutingManagerService
	{
        [OperationContract]
        IEnumerable<IUrlRoute> GetASPXRoutes();

	    [OperationContract]
	    XmlElement GetIISURLRewriteRules();
	}
}