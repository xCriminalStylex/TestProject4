using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4.PageObject
{
    public class DressesSummer:Header
    {
        public DressesSummer(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
