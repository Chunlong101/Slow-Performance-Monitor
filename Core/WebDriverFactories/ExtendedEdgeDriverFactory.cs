using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.WebDriver;

namespace Core.WebDriverFactories
{
    class ExtendedEdgeDriverFactory : IWebDriverFactory
    {
        public IExtendedWebDriver GetWebDriver()
        {
            return new ExtendedEdgeDriver();
        }
    }
}
