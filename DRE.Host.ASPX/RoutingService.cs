using System.Collections.Generic;
using DRE.Common.Host.Contracts;
using DRE.Common.Contracts;

namespace DRE.Host.ASPX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RoutingService : IASPXRoutingRules
    {
        public IList<IUrlRoute> GetRoutes()
        {
            //var temp = new Dictionary<string, object>()
            //{
            //    {"{controller}/{action}", new {controller = "Test", action = "Index"}}
            //};

            var routeCollection = new List<UrlRoute>
            {
                new UrlRoute()
                {
                    Name = "Default",
                    Url = "{controller}/{action}",
                    Fragment = "Test/Index",
                    PropertiesDictionary = new Dictionary<string, string>
                    {
                        {"controller", "Test"},
                        {"action", "Index"}
                    }
                },
                new UrlRoute()
                {
                    Name = "Register",
                    Url = "{controller}/{action}",
                    Fragment = "Account/Register",
                    PropertiesDictionary = new Dictionary<string, string>
                    {
                        {"controller", "Account"},
                        {"action", "Register"}
                    }
                },
                new UrlRoute()
                {
                    Name = "Login",
                    Url = "{controller}/{action}",
                    Fragment = "Account/Login",
                    PropertiesDictionary = new Dictionary<string, string>
                    {
                        {"controller", "Account"},
                        {"action", "Login"}
                    }
                },
                new UrlRoute()
                {
                    Name = "Home",
                    Url = "{controller}/{action}",
                    Fragment = "Home/Index",
                    PropertiesDictionary = new Dictionary<string, string>
                    {
                        {"controller", "Home"},
                        {"action", "Index"}
                    }
                }
            };

            
            return routeCollection as IList<IUrlRoute>;
        }
    }
}
