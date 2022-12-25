using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExcersiseFramework.Pages
{
    class ProductsPage
    {
        readonly IWebDriver _driver;
        public By productPage = By.Id("advertisement");

        /* traženje lokatora za Search */

        public By search = By.Id("search_product");
        public By searchLoop = By.ClassName("fa-search");


        public ProductsPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(productPage));
        }
    }
}