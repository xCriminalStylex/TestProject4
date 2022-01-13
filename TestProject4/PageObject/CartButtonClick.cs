using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4.PageObject
{
    public class CartButtonClick: Header
    {
        public CartButtonClick(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
