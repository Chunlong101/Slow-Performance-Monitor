using OpenQA.Selenium;

namespace Core.WebDriver
{
    public interface IExtendedWebDriver : IWebDriver
    {
        IWebElement WaitForElementToBeLoaded(IWebDriver Driver, By Selector, int TimeOutInSeconds);
    }
}
