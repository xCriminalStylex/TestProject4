using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TestProject4.PageObject
{
    public class Header
    {
        protected IWebDriver _driver;
        private By _contactUseClick = By.Id("contact-link");
        private By _signInClick = By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a");
        private By _sale70Img = By.CssSelector("#header > div.banner > div > div > a > img");
        private By _womenButton = By.CssSelector("#block_top_menu > ul > li:nth-child(1) > a");
        private By _dressesButton = By.CssSelector("#block_top_menu > ul > li:nth-child(2) > a");
        private By _tShirtsButton = By.CssSelector("#block_top_menu > ul > li:nth-child(3) > a");
        private By _yourLogoButton = By.CssSelector("#header_logo > a > img");
        private By _seachHeader = By.CssSelector("#search_query_top");
        private By _sortDropDown = By.CssSelector("#selectProductSort");
        private By _sortDropDownChoise = By.CssSelector("#selectProductSort > option:nth-child(7)");
        private By _cartButton = By.CssSelector("#header > div:nth-child(3) > div > div > div:nth-child(3) > div > a");
        private By _womenDropDown = By.CssSelector("#block_top_menu > ul > li:nth-child(1)");
        private By _womenDropDownBlouses = By.CssSelector("#block_top_menu > ul > li:nth-child(1) > ul > li:nth-child(1) > ul > li.sfHoverForce > a");
        private By _dressDropDown = By.ClassName("sf-with-ul");
        private By _dressSummer = By.LinkText("Summer Dresses");
        public Header ContactUseClick()
        {
            _driver.FindElement(_contactUseClick).Click();
            return this;
        }
        public SignInClick SignInClick()
        {
            _driver.FindElement(_signInClick).Click();
            return new SignInClick(_driver);
        }
        public Sale70ImgClick Sale70ImgClick()
        {
            _driver.FindElement(_sale70Img).Click();
            return new Sale70ImgClick(_driver);
        }
        public WomenButtonClick WomenButtonClick()
        {
            _driver.FindElement(_womenButton).Click();
            return new WomenButtonClick(_driver);
        }
        public DressesButtonClick DressesButtonClick()
        {
            _driver.FindElement(_dressesButton).Click();
            return new DressesButtonClick(_driver);
        }
        public TShirtsButtonClick TShirtsButtonClick()
        {
            _driver.FindElement(_tShirtsButton).Click();
            return new TShirtsButtonClick(_driver);
        }
        public YourLogoButton YourLogoButton()
        {
            _driver.FindElement(_yourLogoButton).Click();
            return new YourLogoButton(_driver);
        }
        public SearchHeader SearchHeader()
        {
            
            _driver.FindElement(_seachHeader).Click();
            _driver.FindElement(_seachHeader).SendKeys("Short");
            _driver.FindElement(_seachHeader).SendKeys(Keys.Enter);
            _driver.FindElement(_sortDropDown).Click();
            _driver.FindElement(_sortDropDownChoise).Click();
            return new SearchHeader(_driver);
        }
        public CartButtonClick CartButtonClick()
        {
            _driver.FindElement(_cartButton).Click();
            return new CartButtonClick(_driver);
        }
        public WomenDropDownBlouses WomenDropDownBlouses()
        {
            Action action = new Action(_driver);
            //_driver.FindElement(_womenDropDown);
            //_driver.FindElement(_womenDropDownBlouses).Click();
            return new WomenDropDownBlouses(_driver);
        }
        public DressesSummer DressesSummer()
        {
            _driver.FindElement(_dressDropDown);
            _driver.FindElement(_dressSummer).Click();
            return new DressesSummer(_driver);
        }
    }
    
}
