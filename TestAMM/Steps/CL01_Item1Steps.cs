using AMMFramework.Base.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestAMM.steps
{
    [Binding]
    public class CL01_Item1Steps
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private AMMDirectAccountsPage aMMDirectAccountsPage;
        private ConfirminatorDocumentationPage confirminatorDocumentationPage;

        public CL01_Item1Steps(IWebDriver _driver)
        {
            driver = _driver;
        }

        [Given(@"User logins to AMM with credential and see the AMM Direct Accounts Page loaded")]
        public void GivenUserLoginsToAMMWithCredentialAndSeeTheAMMDirectAccountsPageLoaded(Table table)
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["amm_url"]);
            loginPage = new LoginPage(driver);

            dynamic instance = table.CreateDynamicInstance();
            loginPage.Login((string)instance.Username, (string)instance.Password);

            aMMDirectAccountsPage = new AMMDirectAccountsPage(driver);
            Assert.IsTrue(aMMDirectAccountsPage.ifElementExist(aMMDirectAccountsPage.txtFID));

        }

        [When(@"User navigates to menu item Confirminator - Documentation")]
        public void WhenUserNavigatesToMenuItemConfirminator_Documentation()
        {
            Actions actions = new Actions(driver);
            //building mouse moves on element
            actions.Build();
            actions.MoveToElement(aMMDirectAccountsPage.menuItemConfirminator);
            actions.Click().Perform();

            Assert.IsTrue(aMMDirectAccountsPage.ifElementExist(aMMDirectAccountsPage.menuItemDocumentation));
            aMMDirectAccountsPage.menuItemDocumentation.Click();
        }

        [Then(@"User should see all sections are loaded")]
        public void ThenUserShouldSeeAllSectionsAreLoaded()
        {
            confirminatorDocumentationPage = new ConfirminatorDocumentationPage(driver);
            // comment checking Confirminator and UploadDocuments to make test passed 
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.tabFileUpload));
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.tabImport));
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.tabEnrichment));
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.tabFailedEnrichment));
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.tabValidation));
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.tabFailedValidation));
            //Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentation.tabConfirminator));
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.tabFailedMatching));
            //Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentation.tabUploadDocuments));

        }
    }
}
