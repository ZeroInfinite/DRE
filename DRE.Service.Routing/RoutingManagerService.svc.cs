using System.Collections.Generic;
using System.Xml;
using DRE.Common.Contracts;
using DRE.Common.Host.Contracts;
using DRE.Host;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace DRE.Service.Routing
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RoutingManagerService : IRoutingManagerService
    {
	    private readonly IASPXRoutingRules _aspxRoutingRules;
	    private readonly IIISUrlRewriteRules _iisUrlRewriteRules;

	    public IEnumerable<IUrlRoute> GetASPXRoutes()
	    {
		    return _aspxRoutingRules.GetRoutes();
	    }

	    public XmlElement GetIISURLRewriteRules()
	    {
		    return _iisUrlRewriteRules.GetRewriteRules();
	    }

	    public RoutingManagerService()
	    {
            UnityServiceLocator locator = new UnityServiceLocator(CreateConfiguredUnityContainer());
            ServiceLocator.SetLocatorProvider(() => locator);
		    _aspxRoutingRules = locator.GetInstance(typeof (ASPXRoutingRules)) as IASPXRoutingRules;
            _iisUrlRewriteRules = locator.GetInstance(typeof(IISRewriteRules)) as IIISUrlRewriteRules;
	    }

        private static IUnityContainer CreateConfiguredUnityContainer()
        {
            IUnityContainer container = new UnityContainer();

            // (optional) provide default mappings programmatically
            //container.RegisterType<Common.Host.Contracts.IASPXRoutingRules, Host.ASPXRoutingRules>();

            // (optional) load static config from the *.xml file
            container.LoadConfiguration();

            return container;
        }

    }
}
