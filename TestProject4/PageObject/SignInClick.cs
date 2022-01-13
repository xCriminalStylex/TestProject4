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
    public class SignInClick
    {
        private IWebDriver _driver;
        public SignInClick(IWebDriver driver)
        {
            _driver = driver;
        }
                
    }
}
