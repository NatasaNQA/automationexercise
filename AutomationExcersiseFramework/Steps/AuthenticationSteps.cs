using AutomationExcersiseFramework.Helpers;
using AutomationExcersiseFramework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationExcersiseFramework.Steps
{
    [Binding]
    public class AuthenticationSteps : Base //nasleđivanje nase klase Base
    {
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ut.ClickOnElement(hp.loginLink); 
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.loginEmail, TestConstants.Username); //vrlo važna linija koda koju treba da razumemo
            ut.EnterTextInElement(ap.loginPassword, TestConstants.Password);
        }
        
        [When(@"user submits login form")]
        public void WhenUserSubmitsLoginForm()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.loginBtn);
        }
        
        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Assert.True(ut.EelementIsDispleyed(hp.deleteAcc), "User is NOT logged in");
        }

        [Given(@"enters '(.*)' name and valid email address")]
        public void GivenEntersNameAndValidEmailAddress(string name)
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.name, name);
            ut.EnterTextInElement(ap.signupEmail, ut.GenerateRandomEmail());
        }


        [Given(@"user clicks on SignUp button")]
        public void GivenUserClicksOnSignUpButton()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signupBtn);
        }

        [StepDefinition(@"user fills in all required fields")]
        public void WhenUserFillsInAllRequiredFields()
        {
            SignupPage sp = new SignupPage(Driver);
            ut.EnterTextInElement(sp.password, TestConstants.Password);
            ut.EnterTextInElement(sp.firstName, TestConstants.FirstName);
            ut.EnterTextInElement(sp.lastName, TestConstants.LastName);
            ut.EnterTextInElement(sp.address, TestConstants.Adress);
            ut.EnterTextInElement(sp.country, TestConstants.Country);
            ut.EnterTextInElement(sp.state, TestConstants.State);
            ut.EnterTextInElement(sp.city, TestConstants.City);
            ut.EnterTextInElement(sp.zipCode, TestConstants.ZipCode);
            ut.EnterTextInElement(sp.mobileNumber, TestConstants.Phone);
        }

        [StepDefinition(@"submits the singup form")]
        public void WhenSubmitsTheSingupForm()
        {
            SignupPage sp = new SignupPage(Driver);
            //ut.ClickOnElement(sp.createAcc);
            Driver.FindElement(sp.form).Submit();
        }

        [Then(@"user will get '(.*)' success message")]
        public void ThenUserWillGetSuccesMessage(string message)
        {
            AccountCreatedPage acp = new AccountCreatedPage(Driver);
            Assert.True(ut.TextPresentInElement(message), "User did NOT get expected success message");
            ut.ClickOnElement(acp.countinueBtn);

        }

        [Given(@"user registers new account with '(.*)' name")]
        public void GivenUserRegistersNewAccountWithName(string name)
        {
            GivenUserOpensSignInPage();
            GivenEntersNameAndValidEmailAddress(name);
            GivenUserClicksOnSignUpButton();
            WhenUserFillsInAllRequiredFields();
            WhenSubmitsTheSingupForm();
            AccountCreatedPage acp = new AccountCreatedPage(Driver);
            ut.ClickOnElement(acp.countinueBtn);
        }

        [When(@"user selects option for deleting the account")]
        public void WhenUserSelectsOptionForDeletingTheAccount()
        {
            HeaderPage hp = new HeaderPage(Driver);
            ut.ClickOnElement(hp.deleteAcc);
        }

        [Then(@"account will be deleted with '(.*)' message")]
        public void ThenAccountWillBeDeletedWithMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
