using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4.PageObject
{
    public class WomenDropDownBlouses:Header
    {
        public WomenDropDownBlouses(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
