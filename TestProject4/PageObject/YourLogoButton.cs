using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4.PageObject
{
    public class YourLogoButton: Header
    {
        
        public YourLogoButton(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
