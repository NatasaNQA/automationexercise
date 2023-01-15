using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExcersiseFramework.Pages
{
    class PaymentPage
    {
        readonly IWebDriver _driver;
        public By paymentPage = By.ClassName("payment-information");
        public By fieldNameOnCard = By.Name("name_on_card");
        public By fieldCardNnumber = By.Name("card_number");
        public By fieldCVC = By.ClassName("card-cvc");
        public By fieldExpiration1 = By.Name("expiry_month");
        public By fieldExpiration2 = By.Name("expiry_year");
        public By buttonPayOrder = By.Id("submit");

        public PaymentPage(IWebDriver driver)
        {
           this._driver = driver;
           var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
           wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(paymentPage));
         
        }

    }
}
