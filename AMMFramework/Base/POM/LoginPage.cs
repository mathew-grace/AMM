using OpenQA.Selenium;

namespace AMMFramework.Base.POM
{
    public class LoginPage : BasePage
    {
        
        public LoginPage(IWebDriver _driver) : base(_driver)
        {
        }

        public IWebElement txtUserName
        {
            get { return this.driver.FindElement(By.Name("UserName")); }            
        }

        public IWebElement txtPassword
        {
            get { return this.driver.FindElement(By.Name("Password")); }
        }

        private IWebElement btnLogin
        {
            get { return this.driver.FindElement(By.CssSelector(".button")); }
        }

        public void Login(string userName, string passWord)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(passWord);
            btnLogin.Submit();
        }
               
    }
}
