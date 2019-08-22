using System;
using OpenQA.Selenium;
using System.Reflection;
using Core.WebDriver;

namespace Core.WebDriverFactories
{
    public static class WebDriverFactoryManager
    {
        /// <summary>
        /// Generate webdriver factory that can create concreate webdriver such as ChromeDriver or ExtendedChromeDriver. 
        /// </summary>
        /// <param name="FullClassName">Examples: Core.WebDriverFactories.ChromeDriverFactory</param>
        /// <returns>concreate webdriver such as ChromeDriver or ExtendedChromeDriver</returns>
        public static IExtendedWebDriver GetWebDriverByDriverType(int DriverType)
        {
            string FullClassName = Core.Properties.Settings.Default.IeFactory;

            if (DriverType == 1)
            {
                FullClassName = Core.Properties.Settings.Default.IeFactory;
            }
            else if (DriverType == 2)
            {
                FullClassName = Core.Properties.Settings.Default.ChromeFactory;
            }
            else if (DriverType == 3)
            {
                FullClassName = Core.Properties.Settings.Default.FireFoxFactory;
            }
            else if (DriverType == 4)
            {
                FullClassName = Core.Properties.Settings.Default.EdgeFactory;
            }

            Assembly assembly = System.Reflection.Assembly.Load(FullClassName.Split('.')[0]);
            object instance = assembly.CreateInstance(FullClassName);
            return ((IWebDriverFactory)instance).GetWebDriver();
        }
    }
}
