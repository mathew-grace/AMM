using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;

namespace AMMFramework.Base.POM
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        public IWebElement imgAMM
        {
            get { return this.driver.FindElement(By.CssSelector("img")); }
        }

        public IWebElement menuItemDashboard
        {
            get { return this.driver.FindElement(By.LinkText("Dashboard")); }
        }

        public IWebElement menuItemConfirminator
        {
            get { return this.driver.FindElement(By.LinkText("Confirminator")); }
        }

        public IWebElement menuItemDocumentation
        {
            get { return this.driver.FindElement(By.LinkText("Documentation")); }
        }

        public BasePage(IWebDriver _driver)
        {
            this.driver = _driver;

        }

        public Boolean ifElementExist(IWebElement _element)
        {
            return _element.Displayed;
        }

        public Boolean ifCanSetValue(IWebElement _element, IWebElement _btnSave, String value)
        {
            _element.Clear();
            _element.SendKeys(value);
            _btnSave.Submit();
            return _element.GetAttribute("value").Equals(value);
            
        }
       
    }
}
