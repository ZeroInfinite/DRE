using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Microsoft.Practices.Unity;

namespace DRE.Common.Host
{
    public class UnityServiceBehaviour
    {
         public UnityInstanceProvider InstanceProvider
            { get; set; }

            //private ServiceHost _serviceHost = null;

            public UnityServiceBehaviour()
            {
                InstanceProvider = new UnityInstanceProvider();
            }

            public UnityServiceBehaviour(UnityContainer unity)
            {
	            InstanceProvider = new UnityInstanceProvider {Container = unity};
            }

            public void ApplyDispatchBehaviour(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
            {
	            IEnumerable<EndpointDispatcher> endPoints = serviceHostBase.ChannelDispatchers.OfType<ChannelDispatcher>().SelectMany(cd => cd.Endpoints);

	            foreach (EndpointDispatcher ed in endPoints)
	            {
		            InstanceProvider.ServiceType = serviceDescription.ServiceType;
		            ed.DispatchRuntime.InstanceProvider = InstanceProvider as IInstanceProvider;
	            }
            }


	    public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase) { }


            public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters) { }

        }

    }
