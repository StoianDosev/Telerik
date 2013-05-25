using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
    AllowMultiple = false)]
    public class VersionAttribute : System.Attribute
    {
        public string Version { get; set; }

        public VersionAttribute(string version)
        {
            Version = version;
        }
    }
}
