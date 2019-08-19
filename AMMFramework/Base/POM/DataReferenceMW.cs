using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMMFramework.Base.POM
{
    public class DataReferenceMW : BasePage
    {
        public DataReferenceMW(IWebDriver _driver) : base(_driver)
        {
        }
        public IWebElement txtTitle
        {
            get { return this.driver.FindElement(By.Name("Title")); }
        }

        public IWebElement txtDetail
        {
            get { return this.driver.FindElement(By.Name("Detail")); }
        }

        public IWebElement btnSave
        {
            get { return this.driver.FindElement(By.Name("Save")); }
        }
    }
}
