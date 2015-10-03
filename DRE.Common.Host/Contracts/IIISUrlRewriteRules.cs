using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel;

namespace DRE.Common.Host.Contracts
{
    [ServiceContract]
    public interface IIISUrlRewriteRules
    {
        [OperationContract]
        XmlElement GetRewriteRules();
    }
}
