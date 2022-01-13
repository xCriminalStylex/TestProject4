using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using Xunit;
using TestProject4.PageObject;

namespace TestProject4
{
    public class UnitTest1:BaseTest
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.ContactUseClick();
        }
        [Fact]
        public void Test2()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.SignInClick();
        }
        [Fact]
        public void Test3()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.Sale70ImgClick();
        }
        [Fact]
        public void Test4()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.WomenButtonClick();
        }
        [Fact]
        public void Test5()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.DressesButtonClick();
        }
        [Fact]
        public void Test6()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.TShirtsButtonClick();
        }
        [Fact]
        public void Test7()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.YourLogoButton();
        }
        [Fact]
        public void Test8()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.SearchHeader();
        }
        [Fact]
        public void Test9()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.CartButtonClick();
        }
        [Fact]
        public void Test10()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.WomenDropDownBlouses();
        }
        [Fact]
        public void Test11()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.DressesSummer();
        }
    }
}
