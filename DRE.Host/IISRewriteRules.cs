using System.IO;
using System.Web.Hosting;
using System.Xml;
using DRE.Common.Host.Contracts;

namespace DRE.Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class IISRewriteRules : IIISUrlRewriteRules
    {
        public XmlElement GetRewriteRules()
        {
            var appDataPath = HostingEnvironment.MapPath("~/App_Data");

            if (appDataPath == null) return null;

            var file = Path.Combine(appDataPath, "RewriteRules.xml");
            var doc = new XmlDocument();
            doc.Load(file);
            return doc.DocumentElement;
        }
    }
}
