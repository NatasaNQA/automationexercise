using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationExcersiseFramework.Helpers
{
    [Binding] //idemo na 15.liniju koda
   public class Base
    {
        public static IWebDriver Driver { get; set; }

        [BeforeScenario] //idemo na 24-liniju koda
        public static void BeforeScenario()
        {
            Driver = new ChromeDriver(); //hocemo da simuliramo da nam otvori novi browser. Driver je nova distanca ChromeDriver-a
            Driver.Manage().Window.Maximize(); //da maksimizira nas Google prozor
            var url = "https://automationexercise.com/"; //da odemo na nas URL koji nam treba
            Driver.Url = url; //da pozovemo taj url
        }

        [AfterScenario] //radimo kompajliranje
        public static void AfterScenario()
        {
            Driver.Quit(); //gasimo browser. Vracamo se na 10. liniju koda
        }

    }
}
