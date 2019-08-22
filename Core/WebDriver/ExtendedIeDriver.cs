using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;

namespace Core.WebDriver
{
    public class ExtendedIeDriver : InternetExplorerDriver, IExtendedWebDriver
    {

        public IWebElement WaitForElementToBeLoaded(IWebDriver Driver, By Selector, int TimeOutInSeconds)
        {
            try
            {
                if (TimeOutInSeconds > 0)
                {
                    var wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(TimeOutInSeconds));
                    return wait.Until(drv => drv.FindElement(Selector));
                }

                return Driver.FindElement(Selector);

            }
            catch (System.Exception)
            {
                throw new Exception("Not able to find element or more than one elements were found.");
            }
        }
    }
}
