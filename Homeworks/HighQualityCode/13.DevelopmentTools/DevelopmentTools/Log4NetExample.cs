using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentTools
{
    class Log4NetExample
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Log4NetExample));
        static void Main()
        {
            BasicConfigurator.Configure();
            log.Debug("Debug msg");
            log.Error("Error msg");
        }
    }

}
