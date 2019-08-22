using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.WebDriver;

namespace Core.WebDriverFactories
{
    class ExtendedFireFoxDriverFactory : IWebDriverFactory
    {
        public IExtendedWebDriver GetWebDriver()
        {
            return new ExtendedFireFoxDriver(); 
        }
    }
}
