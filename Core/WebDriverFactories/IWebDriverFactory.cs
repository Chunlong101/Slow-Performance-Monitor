using Core.WebDriver;
using OpenQA.Selenium;

namespace Core.WebDriverFactories
{
    public interface IWebDriverFactory
    {
        IExtendedWebDriver GetWebDriver(); 
    }
}
