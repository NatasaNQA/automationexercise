using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExcersiseFramework.Pages
{
    class PDetailsP
    {
        readonly IWebDriver _driver;
        public By pdetail = By.XPath("//*[@class='row']//*[@class='col-sm-9 padding-right']");

        public By addToCart = By.XPath("//*[@class='btn btn-default cart']//*[@class='fa fa-shopping-cart']");
        //public By viewCart = By.XPath("//*[@class='text-center']//*[contains(text(),'View Cart')]"); - radi i ovaj način, ali izbegavamo XPath
        public By viewCart = By.CssSelector(".text-center [href='/view_cart']");
        public By prodName = By.XPath("//*[@class='product-information']//h2");
        public PDetailsP(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(pdetail));
        }
    }
}
