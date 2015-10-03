using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using DRE.Common.Host.Contracts;
using System.IO;
using System.Web.Hosting;


namespace DRE.Host.IIS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RewriteRulesService : IIISUrlRewriteRules
    {
        public XmlElement GetRewriteRules()
        {
            string appDataPath = HostingEnvironment.MapPath("~/App_Data");
            string file = Path.Combine(appDataPath, "RewriteRules.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            return doc.DocumentElement;
        }
    }
}
