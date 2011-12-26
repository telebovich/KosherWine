using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;

namespace KosherWine.Configuration
{
    public class WebConfigApplicationSettings: IApplicationSettings 
    {
        public string LoggerName
        {
            get
            {
                return ConfigurationManager.AppSettings["LoggerName"];
            }
        }
    }
}