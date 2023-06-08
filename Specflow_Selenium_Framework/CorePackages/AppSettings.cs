using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Selenium_Framework.CorePackages
{
    public class AppSettings
    {
        public string BrowserType { get; set; }
        public string LogLevel { get; set; }
    }
}
