using AMMFramework.Base.POM;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Configuration;
using TechTalk.SpecFlow;


namespace TestAMM.Steps
{
    [Binding]
    class Hooks
    {
        private readonly IObjectContainer objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario(Order = 1)]
        public void InitializeWebDriver()
        {
            var webDriver = new ChromeDriver();
            objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            objectContainer.Resolve<IWebDriver>().Quit();
        }

        [BeforeScenario("ConfirminatorDocumentation")]
        public void LoginThenMoveToConfirminator()
        {
            IWebDriver driver = objectContainer.Resolve<IWebDriver>();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["amm_url"]);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(ConfigurationManager.AppSettings["test_username"], ConfigurationManager.AppSettings["test_password"]);

            AMMDirectAccountsPage aMMDirectAccountsPage = new AMMDirectAccountsPage(driver);
            Actions actions = new Actions(driver);
            actions.Build();
            actions.MoveToElement(aMMDirectAccountsPage.menuItemConfirminator);
            actions.Click().Perform();
            aMMDirectAccountsPage.menuItemDocumentation.Click();
        }
    }
}
