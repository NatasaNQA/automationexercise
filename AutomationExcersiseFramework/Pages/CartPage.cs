using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExcersiseFramework.Pages
{
    class CartPage
    {
        readonly IWebDriver _driver;
        public By cartPage = By.Id("cart_items");

        public CartPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(cartPage));
        }

    }
}
