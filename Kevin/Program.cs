using System;
using Core.WebDriverFactories;
using Core.WebDriver;
using Core.PageLoadPerformance;
using System.Collections.Generic;
using Core.EmailNotification;
using System.Configuration;

namespace Kevin
{
    public class Program
    {
        private static NLog.Logger log = Core.Logging.Logger.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            try
            {
                string version = ConfigurationManager.AppSettings["Version"];
                log.Info("Version: {0}", version);
                int monitorDays = Convert.ToInt32(ConfigurationManager.AppSettings["MonitorDays"]);
                DateTime today = DateTime.Now;
                DateTime endDateTime = today.AddDays(monitorDays);
                log.Info("Today is: {0}, how many days we're gonna monitor: {1} days, End date is: {2}", today, monitorDays, endDateTime);
                int broswerType = Convert.ToInt32(ConfigurationManager.AppSettings["BroswerType"]);
                log.Info("Initializing webdriver with broswer type: {0}", broswerType);
                using (IExtendedWebDriver driver = WebDriverFactoryManager.GetWebDriverByDriverType(broswerType))
                {
                    int pageLoadTimeout = Convert.ToInt32(ConfigurationManager.AppSettings["PageLoadTimeoutInSeconds"]);
                    log.Info("Setting page load timeout to: {0} seconds, this represents maximum page load time, exceeding ths maximum will cause an error", pageLoadTimeout);
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadTimeout);

                    string urlsConfig = ConfigurationManager.AppSettings["Url"];
                    string[] urls = urlsConfig.Split(';');
                    log.Info("URLs have been loaded from config file: {0}", urlsConfig);

                    driver.Url = urls[0];
                    log.Info("Navigating to: {0} with browser type: {1}", urls[0], broswerType);
                    driver.Navigate();

                    bool isSignInRequired = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSignInRequired"]);
                    log.Info("Checking if the manual sign in action is required: {0}", isSignInRequired);
                    if (isSignInRequired)
                    {
                        int manuallySignInTimeInSeconds = Convert.ToInt32(ConfigurationManager.AppSettings["ManuallySignInTimeInSeconds"]);
                        log.Info("Sleeping for: {0} seconds so now you can input the credential and manually sign in", manuallySignInTimeInSeconds);
                        System.Threading.Thread.Sleep(manuallySignInTimeInSeconds * 1000);
                    }

                    int timeSpanToSleep = Convert.ToInt32(ConfigurationManager.AppSettings["TimeSpanToSleepInSeconds"]);
                    log.Info("TimeSpanToSleep was loaded from config file: {0}, this represents how many seconds the broswer gonna sleep after every page load", timeSpanToSleep);
                    int slowPerformancePageLoadThreshold = Convert.ToInt32(ConfigurationManager.AppSettings["SlowPerformancePageLoadThreshold"]);
                    log.Info("SlowPerformanceThreshold was loaded from config file: {0}, this represents how many seconds of a page load will be considered as slow performance", slowPerformancePageLoadThreshold);
                    int slowPerformanceReoccurrenceThreshold = Convert.ToInt32(ConfigurationManager.AppSettings["SlowPerformanceReoccurrenceThreshold"]);
                    log.Info("SlowPerformanceReoccurrenceThreshold was loaded from config file: {0}, this represents how many reoccurrences of slow page load will be considered as slow performance, for example, 3 reoccurrences of slow page load (page load time > 10s) will be considered as slow performance", slowPerformanceReoccurrenceThreshold);

                    //
                    // Starting to browse URLs repeatedly and detect the slow performance 
                    //
                    while (DateTime.Now < endDateTime)
                    {
                        foreach (var url in urls)
                        {
                            log.Info("Navigating to: {0}", url);
                            var t1 = System.DateTime.Now;
                            driver.Navigate().GoToUrl(url);
                            var t2 = System.DateTime.Now;
                            TimeSpan dif = t2 - t1;
                            log.Info("Page was loaded and consumed: {0}, URL: {1}", dif, url);

                            PageLoadMetrics metrics = new PageLoadMetrics(t1, driver.Url, dif);
                            int fb = metrics.SaveToCsv();
                            if (fb == -1)
                            {
                                log.Warn("Failed to save page load performance metrics to csv file");
                            }
                            else
                            {
                                log.Info("Saved page load performance metrics to csv file, TimeStamp: {0}, Url: {1}, PageLoadTime: {2}", metrics.TimeStamp, metrics.Url, metrics.PageLoadTime);
                            }

                            if (dif.TotalSeconds > slowPerformancePageLoadThreshold)
                            {
                                log.Warn("Slow performance was detected, page load time is more than: {0} seconds. URL: {1}", slowPerformancePageLoadThreshold, url);

                                List<PageLoadMetrics> list = PageLoadMetrics.GetMetricsCsvLast(slowPerformanceReoccurrenceThreshold);
                                if (list == null || list.Count != slowPerformanceReoccurrenceThreshold)
                                {
                                    log.Error("Failed to get performance metrics from csv file, pls check the logs and csv file");
                                    continue;
                                }

                                bool isSlow = true;
                                foreach (var i in list)
                                {
                                    if (i.PageLoadTime.TotalSeconds < slowPerformancePageLoadThreshold)
                                    {
                                        isSlow = false;
                                        break;
                                    }
                                }

                                if (isSlow)
                                {
                                    log.Warn("Slow performance was detected continuously, how many times: {0}, how slow is it: more than '{1}' seconds, pls check performance metrics csv file for more details", slowPerformanceReoccurrenceThreshold, slowPerformancePageLoadThreshold);

                                    var emailFromName = ConfigurationManager.AppSettings["EmailFromName"];
                                    var emailFromEmailAddress = ConfigurationManager.AppSettings["EmailFromEmailAddress"];
                                    var emailToName = ConfigurationManager.AppSettings["EmailToName"];
                                    var emailToEmailAddress = ConfigurationManager.AppSettings["EmailToEmailAddress"];
                                    var emailCcName = ConfigurationManager.AppSettings["EmailCcName"];
                                    var emailCcEmailAddress = ConfigurationManager.AppSettings["EmailCcEmailAddress"];
                                    var emailSubject = ConfigurationManager.AppSettings["EmailSubject"];
                                    var emailBody = ConfigurationManager.AppSettings["EmailBody"];
                                    var emailSmtpAddress = ConfigurationManager.AppSettings["EmailSmtpAddress"];
                                    var emailSmtpPort = Convert.ToInt32(ConfigurationManager.AppSettings["EmailSmtpPort"]);
                                    var emailSenderLoginName = ConfigurationManager.AppSettings["EmailSenderLoginName"];
                                    var emailSenderLoginPasswords = ConfigurationManager.AppSettings["EmailSenderLoginPasswords"];
                                    var emailISenderLoginPasswordsEncrypted = Convert.ToBoolean(ConfigurationManager.AppSettings["EmailIsSenderLoginPasswordsEncrypted"]);

                                    Email.SendEmail(emailFromName, emailFromEmailAddress, emailToName, emailToEmailAddress, emailCcName, emailCcEmailAddress, emailSubject, emailBody, emailSmtpAddress, emailSmtpPort, emailSenderLoginName, emailSenderLoginPasswords, emailISenderLoginPasswordsEncrypted);
                                }
                            }
                            log.Info("Sleeping for: {0} seconds", timeSpanToSleep);
                            System.Threading.Thread.Sleep(timeSpanToSleep * 1000);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Fatal(ex, "Something went wrong, pls check the log file");
                Console.ReadLine();
            }
        }
    }
}
