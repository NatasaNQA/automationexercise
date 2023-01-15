using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExcersiseFramework.Pages
{
    class CheckoutPage
    {
        readonly IWebDriver _driver;
        public By checkout = By.Id("cart_items");
        public By commentField = By.ClassName("form-control");
        public By placeOrderButton = By.XPath("//*[@class='btn btn-default check_out']");
        public CheckoutPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(checkout));
        }
    }
}
