﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4.PageObject
{
    public class DressesButtonClick: Header
    {
     
        public DressesButtonClick(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
