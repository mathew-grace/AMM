using OpenQA.Selenium;

namespace AMMFramework.Base.POM
{
    public class ConfirminatorDocumentationPage : BasePage
    {
        
        public ConfirminatorDocumentationPage(IWebDriver _driver) : base(_driver)
        {
        }

        // Assume these controls will be TabItem. 
        // Currently these elements does not have any name or id, using LinkText 
        // PageFactory is obsolete, use By
        public IWebElement tabFileUpload
        {
            get { return this.driver.FindElement(By.LinkText("File Upload")); }
        }
        public IWebElement tabImport
        {
            get { return this.driver.FindElement(By.LinkText("Import")); }
        }
        public IWebElement tabEnrichment
        {
            get { return this.driver.FindElement(By.LinkText("Enrichment")); }
        }
        public IWebElement tabFailedEnrichment
        {
            get { return this.driver.FindElement(By.LinkText("Failed Enrichment")); }
        }
        public IWebElement tabValidation
        {
            get { return this.driver.FindElement(By.LinkText("Validation")); }
        }
        public IWebElement tabFailedValidation
        {
            get { return this.driver.FindElement(By.LinkText("Failed Validation")); }
        }

        // This element even does not have link text, assume it does
        public IWebElement tabConfirminator
        {
            get { return this.driver.FindElement(By.LinkText("Confirminator")); }
        }
        public IWebElement tabFailedMatching
        {
            get { return this.driver.FindElement(By.LinkText("Failed Matching")); }
        }

        // The mockup displays Correction instead of Upload Documents as spec, follow spec
        public IWebElement tabUploadDocuments
        {
            get { return this.driver.FindElement(By.LinkText("Upload Documents")); }
        }

        public IWebElement lblDetail
        {
            get { return this.driver.FindElement(By.LinkText("Details")); }
        }

        public IWebElement lblSettings
        {
            get { return this.driver.FindElement(By.LinkText("Settings")); }
        }
        public IWebElement txtOverview
        {
            get { return this.driver.FindElement(By.Name("Overview")); }
        }

        public IWebElement txtStaticData
        {
            get { return this.driver.FindElement(By.Name("Static Data")); }
        }

        public IWebElement txtProcess
        {
            get { return this.driver.FindElement(By.Name("Process")); }
        }

        public IWebElement btnSave
        {
            get { return this.driver.FindElement(By.Name("Save")); }
        }

        public IWebElement txtDRTitle
        {
            get { return this.driver.FindElement(By.Name("Title")); }
        }

        public IWebElement txtDRDetail
        {
            get { return this.driver.FindElement(By.Name("Detail")); }
        }
        public IWebElement btnAddAnotherRecord
        {
            get { return this.driver.FindElement(By.Name("Add Another Record")); }
        }
    }
}
