using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4.PageObject
{
    public class WomenButtonClick: Header
    {
       
        public WomenButtonClick(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
