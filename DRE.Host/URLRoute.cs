using System.Collections.Generic;
using System.Runtime.Serialization;
using DRE.Common.Contracts;

namespace DRE.Host
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
