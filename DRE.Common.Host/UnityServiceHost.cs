using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using Microsoft.Practices.Unity;

namespace DRE.Common.Host
{
    public class UnityServiceHost : ServiceHost
    {
        public UnityContainer Container { get; set; }

        public UnityServiceHost()
        {
            Container = new UnityContainer();
        }

        public UnityServiceHost(Type serviceType, params Uri[] baseAddresses) : base(serviceType, baseAddresses)
        {
            Container = new UnityContainer();
        }

        protected override void OnOpening()
        {
            if (Description.Behaviors.Find<UnityServiceBehaviour>() == null)
                Description.Behaviors.Add(new UnityServiceBehaviour(Container) as IServiceBehavior);

            base.OnOpening();
        }
    }

}

