using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4.PageObject
{
    public class HomePage: Header

    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
