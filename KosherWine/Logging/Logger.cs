using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using log4net;

namespace KosherWine.Logging
{
    public class Logger
    {
        private static ILog _log = LogManager.GetLogger(typeof(Logger));

        public static ILog Log
        {
            get
            {
                return _log;
            }
        }
    }
}