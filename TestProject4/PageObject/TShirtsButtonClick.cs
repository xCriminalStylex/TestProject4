using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4.PageObject
{
    public class TShirtsButtonClick: Header
    {
       
        public TShirtsButtonClick(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
