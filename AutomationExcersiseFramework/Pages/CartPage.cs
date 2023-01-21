
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
        //public By proceedToCheckout = By.CssSelector(".col-sm-6 [class='btn btn-default check_out']"); //radi
        public By proceedToCheckout = By.CssSelector("[class='btn btn-default check_out']");

        public CartPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(cartPage));
        }

    }
}
