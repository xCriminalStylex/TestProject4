using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using TestProject4.PageObject;

namespace TestProject4.PageObject
{
    public class ContactUseClick
    {
        private IWebDriver _driver;
        public ContactUseClick(IWebDriver driver)
        {
            _driver = driver;
        }
              
    }
}
