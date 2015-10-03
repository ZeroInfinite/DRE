using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DRE.Common.Contracts;
using System.Runtime.Serialization;

namespace IIS
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
