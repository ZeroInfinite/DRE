using DRE.Common.Contracts;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IIS
{
    [DataContract]
    public class Routes : IRoutes
    {
        [DataMember]
        public IList<IUrlRoute> RouteCollection { get; set; }
    }
}
