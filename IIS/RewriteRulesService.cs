using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using DRE.Common.Host.Contracts;


namespace IIS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RewriteRulesService : IGetURLRewriteRules
    {
        public XmlElement GetRewriteRules()
        {
            throw new NotImplementedException();
        }
    }
}
