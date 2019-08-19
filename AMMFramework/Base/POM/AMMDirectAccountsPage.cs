using OpenQA.Selenium;

namespace AMMFramework.Base.POM
{
    public class AMMDirectAccountsPage : BasePage
    {
        
        public AMMDirectAccountsPage(IWebDriver _driver) : base(_driver)
        {         
           
        }

        public IWebElement txtFID
        {
            get { return this.driver.FindElement(By.Id("inputFID")); }
        }
    
    }
}
