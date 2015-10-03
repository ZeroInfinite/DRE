using DRE.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IIS
{
    [DataContract]
    public class Routes : IRoutes
    {
        [DataMember]
        public IList<IUrlRoute> RouteCollection { get; set; }
    }
}
