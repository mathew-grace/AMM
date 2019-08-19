using AMMFramework.Base.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestAMM
{
    [Binding]
    public class CL02_Item3Steps
    {
        private IWebDriver driver;
        private ConfirminatorDocumentationPage confirminatorDocumentationPage;
        public CL02_Item3Steps(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        [Given(@"User selects File Upload tab")]
        public void GivenUserSelectsFileUploadTab()
        {
            confirminatorDocumentationPage = new ConfirminatorDocumentationPage(driver);
            confirminatorDocumentationPage.tabFileUpload.Click();
        }

        [Then(@"User sees entries Overview, Static Data and Process")]
        public void ThenUserSeesEntriesOverviewStaticDataAndProcess()
        {
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.txtOverview));
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.txtStaticData));
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.txtProcess));
        }

        [Then(@"User can changed values of these entries")]
        public void ThenUserCanChangedValuesOfTheseEntries(Table table)
        {
            dynamic instance = table.CreateDynamicInstance();

            // Overview 
            Assert.IsTrue(confirminatorDocumentationPage.ifCanSetValue(
                confirminatorDocumentationPage.txtOverview,confirminatorDocumentationPage.btnSave, 
                (string)instance.Overview));
            // Static Data 
            Assert.IsTrue(confirminatorDocumentationPage.ifCanSetValue(
                confirminatorDocumentationPage.txtStaticData, confirminatorDocumentationPage.btnSave, 
                (string)instance.StaticData));
            // Process
            Assert.IsTrue(confirminatorDocumentationPage.ifCanSetValue(
                confirminatorDocumentationPage.txtProcess, confirminatorDocumentationPage.btnSave, 
                (string)instance.Process));
        }
        

    }
}
