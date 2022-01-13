using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace TestProject4
{
    public class BaseTest:IDisposable
    {
        private IWebDriver _driver;
        public IWebDriver StartDriverOnPage(string url)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl(url);
            return _driver;

        }
        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
