using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace DRE.Common.Host
{
	public class UnityServiceHostFactory : ServiceHostFactory
	{
		protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
		{
			UnityServiceHost serviceHost = new UnityServiceHost(serviceType, baseAddresses);
			UnityContainer container = new UnityContainer();
			serviceHost.Container = container;

			//configure container
			UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
			//section.Containers.Default.Configure(serviceHost.Container); //obsolete
			section.Configure(serviceHost.Container);

			return serviceHost;
		}
	}

}
