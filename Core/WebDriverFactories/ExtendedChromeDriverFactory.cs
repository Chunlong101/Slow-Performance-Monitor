using Core.WebDriver;

namespace Core.WebDriverFactories
{
    public class ExtendedChromeDriverFactory : IWebDriverFactory
    {
        public IExtendedWebDriver GetWebDriver()
        {
            return new ExtendedChromeDriver();
        }
    }
}
