using Core.WebDriver;

namespace Core.WebDriverFactories
{
    public class ExtendedIeDriverFactory : IWebDriverFactory
    {
        public IExtendedWebDriver GetWebDriver()
        {
            return new ExtendedIeDriver();
        }
    }
}
