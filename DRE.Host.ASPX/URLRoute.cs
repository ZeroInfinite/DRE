using System.Collections.Generic;
using DRE.Common.Contracts;
using System.Runtime.Serialization;

namespace DRE.Host.ASPX
{
    [DataContract]
    public class UrlRoute : IUrlRoute
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public string Fragment { get; set; }

        [DataMember]
        public IDictionary<string, string> PropertiesDictionary { get; set; }
    }
}
