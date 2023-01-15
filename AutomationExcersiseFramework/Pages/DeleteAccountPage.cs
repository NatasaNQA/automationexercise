using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExcersiseFramework.Pages
{
    class DeleteAccountPage
    {
        readonly IWebDriver _driver;
        //public By deletePage = By.XPath("//*[@class='row']//*[@class='col-sm-9 col-sm-offset-1']");
        //public By deletePage = By.CssSelector(".title[data-qa='account-deleted']");
        public By deletePage = By.CssSelector(".row [data-qa='account-deleted']");
        //public By deletePage = By.ClassName("col-sm-9");
        //public By continueDel = By.ClassName("btn-primary");
        public By continueDel = By.CssSelector(".pull-right [data-qa='continue-button']");

        public DeleteAccountPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(deletePage));
        }
    }
}
