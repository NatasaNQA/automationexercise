using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExcersiseFramework.Pages
{
    class HeaderPage
    {
        readonly IWebDriver _driver; //pravimo konstruktor klase
        public By header = By.Id("header"); //nastavljamo na 15. da pišemo konstruktore za PageKlase
        public By loginLink = By.ClassName("fa-lock");
        public By deleteAcc = By.ClassName("fa-trash-o");
        public By contactLink = By.ClassName("fa-envelope");
        public By product = By.ClassName("material-icons");
       
        public HeaderPage(IWebDriver driver) //u zagradama se prosledjuju ulazni parametar
        {
            this._driver = driver; //na 11 korak 
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(header)); //na13.

        }


    }
}
