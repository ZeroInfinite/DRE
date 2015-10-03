using System.Collections.Generic;
using System.Runtime.Serialization;
using DRE.Common.Contracts;

namespace DRE.Host
{
    [DataContract]
    public class Routes : IRoutes
    {
        [DataMember]
        public IList<IUrlRoute> RouteCollection { get; set; }
    }
}
