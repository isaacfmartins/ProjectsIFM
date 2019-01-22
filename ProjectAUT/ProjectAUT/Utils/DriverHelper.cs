using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjectAUT.Utils
{
    class DriverHelper
    {
        public static void OpenBrowser()
        {
            IWebDriver driver = null;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("disable-web-security", "disable-popup-blocking", "AcceptInsecureCertificates", "auth-server-whitelist=*", "no-sandbox", "disable-notifications", "disable-single-click-autofill");
            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com");
        }
    }
}
