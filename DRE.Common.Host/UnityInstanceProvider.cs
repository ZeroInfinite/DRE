using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Microsoft.Practices.Unity;

namespace DRE.Common.Host
{
	public class UnityInstanceProvider
	{
		public UnityContainer Container { set; get; }

		public Type ServiceType { set; get; }

		public UnityInstanceProvider()
			: this(null)
		{
		}

		public UnityInstanceProvider(Type type)
		{
			ServiceType = type;
			Container = new UnityContainer();
		}

		#region IInstanceProvider Members

		public object GetInstance(InstanceContext instanceContext, Message message)
		{
			return Container.Resolve(ServiceType);
		}

		public object GetInstance(InstanceContext instanceContext)
		{
			return GetInstance(instanceContext, null);
		}

		public void ReleaseInstance(InstanceContext instanceContext, object instance)
		{
		}

		#endregion
	}
}
