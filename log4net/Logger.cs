using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace log4net
{
    public class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));
        static Logger()
        {
            XmlConfigurator.Configure();
        }
        public static void LogError(string message, Exception ex)
        {
            Console.WriteLine("\n");
            log.Error(message, ex);
            log.Info(message, ex);
            log.Fatal(message, ex);
            log.Debug(message, ex);
            log.Warn(message, ex);
            

        }
    }
}
