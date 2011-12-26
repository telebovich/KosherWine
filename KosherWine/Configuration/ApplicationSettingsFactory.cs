using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KosherWine.Configuration
{
    public class ApplicationSettingsFactory
    {
        private static IApplicationSettings _applicationSettings;

        public static IApplicationSettings ApplicationSettings
        {
            get
            {
                return _applicationSettings;
            }
            set
            {
                _applicationSettings = value;
            }
        }
    }
}