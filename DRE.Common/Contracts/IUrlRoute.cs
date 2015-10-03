using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRE.Common.Contracts
{
    public interface IUrlRoute
    {
        string Name { get; set; }

        string Url { get; set; }

        string Fragment { get; set; }

        IDictionary<string, string> PropertiesDictionary { get; set; }
    }
}
