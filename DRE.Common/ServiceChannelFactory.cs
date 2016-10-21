using System.ServiceModel;

namespace DRE.Common
{

    public class ServiceChannelFactory
    {
        public static ChannelFactory<T> Create<T>(HttpBindingBase bindings, string address)
        {
            EndpointAddress endpointAddress = new EndpointAddress(address);
            return new ChannelFactory<T>(bindings, endpointAddress);
        }

        public static void Dispose<T>(ChannelFactory<T> channel, T channelInstance)
        {
            channel.Close();
            ((IClientChannel)channelInstance).Close();
        }

    }
}