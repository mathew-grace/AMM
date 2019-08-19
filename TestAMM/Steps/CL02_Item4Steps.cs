using AMMFramework.Base.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestAMM
{
    [Binding]
    public class CL02_Item4Steps
    {
        private IWebDriver driver;
        private ConfirminatorDocumentationPage confirminatorDocumentationPage;
        private DataReferenceMW dataReferenceMW;
        private dynamic instance;
        public CL02_Item4Steps(IWebDriver _driver)
        {
            this.driver = _driver;
        }
        [Given(@"User selects File Upload")]
        public void GivenUserSelectsFileUpload()
        {
            confirminatorDocumentationPage = new ConfirminatorDocumentationPage(driver);
            confirminatorDocumentationPage.tabFileUpload.Click();
        }
        
        [Then(@"Data Reference has two fields for data entries Title and Detail")]
        public void ThenDataReferenceHasTwoFieldsForDataEntriesTitleAndDetail()
        {
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.txtDRTitle));
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.txtDRDetail));
        }
        
        [When(@"There is Add Another Record button\.")]
        public void WhenThereIsAddAnotherRecordButton_()
        {
            Assert.IsTrue(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.btnAddAnotherRecord));
        }
        
        [When(@"User clicks on the button to bring a modal window displaying Title and Detail fields")]
        public void WhenUserClicksOnTheButtonToBringAModalWindowDisplayingTitleAndDetailFields()
        {
            confirminatorDocumentationPage.btnAddAnotherRecord.Click();
            dataReferenceMW = new DataReferenceMW(driver);
            Assert.IsTrue(dataReferenceMW.ifElementExist(dataReferenceMW.txtTitle));
            Assert.IsTrue(dataReferenceMW.ifElementExist(dataReferenceMW.txtDetail));

        }
        
        [Then(@"User can changed values of these fields")]
        public void ThenUserCanChangedValuesOfTheseFields(Table table)
        {
            instance = table.CreateDynamicInstance();
            Assert.IsTrue(dataReferenceMW.ifCanSetValue(dataReferenceMW.txtTitle, dataReferenceMW.btnSave, (string)instance.Title));
            Assert.IsTrue(dataReferenceMW.ifCanSetValue(dataReferenceMW.txtDetail, dataReferenceMW.btnSave, (string)instance.Detail));
        }

        [When(@"There is NO Add Another Record button")]
        public void WhenThereIsNOAddAnotherRecordButton()
        {
            Assert.IsFalse(confirminatorDocumentationPage.ifElementExist(confirminatorDocumentationPage.btnAddAnotherRecord));
        }
        
        [Then(@"User still can changed values of these fields")]
        public void ThenUserStillCanChangedValuesOfTheseFields(Table table)
        {
            instance = table.CreateDynamicInstance();

            Assert.IsTrue(confirminatorDocumentationPage.ifCanSetValue(
                confirminatorDocumentationPage.txtDRTitle, confirminatorDocumentationPage.btnSave, 
                (string)instance.Title));

            Assert.IsTrue(confirminatorDocumentationPage.ifCanSetValue(
                confirminatorDocumentationPage.txtDRDetail, confirminatorDocumentationPage.btnSave, 
                (string)instance.Detail));
        }
    }
}

