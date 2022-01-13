using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4.PageObject
{
    public class SearchHeader: Header
    {
        
        public SearchHeader(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
