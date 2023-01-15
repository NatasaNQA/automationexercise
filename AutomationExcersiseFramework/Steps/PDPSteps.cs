using AutomationExcersiseFramework.Helpers;
using AutomationExcersiseFramework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationExcersiseFramework.Steps
{
    [Binding]
    public class PDPSteps : Base
    {

        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        private readonly ProductData productData;

        public PDPSteps(ProductData productData)
        {
            this.productData = productData;
        }


        [Given(@"user opens products page")]
        public void GivenUserOpensProductsPage()
        {
            ut.ClickOnElement(hp.product);
        }

        [Given(@"searches for '(.*)' term")]
        public void GivenSearchesForTerm(string searchTerm)
        {
            ProductsPage pp = new ProductsPage(Driver);
            ut.EnterTextInElement(pp.search, searchTerm);
            ut.ClickOnElement(pp.searchLoop);
        }

        [Given(@"opens first search result")]
        public void GivenOpensFirstSearchResult()
        {
            ProductsPage pp = new ProductsPage(Driver);
            ut.ClickOnElement(pp.viewProduct);
        }

        [When(@"user clicks on Add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            PDetailsP pdp = new PDetailsP(Driver);
            productData.ProductName = ut.ReturnTextFromElement(pdp.prodName);
            ut.ClickOnElement(pdp.addToCart);
        }

        [When(@"proceeds to cart")]
        public void WhenProceedsToCart()
        {
            PDetailsP pdp = new PDetailsP(Driver);
            ut.ClickOnElement(pdp.viewCart);
        }

        [Then(@"shopping cart will be displeyed with expected product inside")]
        public void ThenShoppingCartWillBeDispleyedWithDesiredProductInside()
        {
            //CartPage cp = new CartPage(Driver);
            Assert.True(ut.TextPresentInElement(productData.ProductName), "Desired product is not in the cart!");
        }
        //-------------------------------------------------------
        

        [Given(@"adds product '(.*)' to cart")]
        public void GivenUserAddsProductToCart(string searchTerm)
        {
            GivenUserOpensProductsPage();
            GivenSearchesForTerm(searchTerm);
            GivenOpensFirstSearchResult();
            WhenUserClicksOnAddToCartButton();
            WhenProceedsToCart();
            ThenShoppingCartWillBeDispleyedWithDesiredProductInside();
        }

        [Given(@"click on Proceed to checkout button")]
        public void GivenClickOnProceedToCheckoutButton()
        {
            CartPage cp = new CartPage(Driver);
            ut.ClickOnElement(cp.proceedToCheckout);
        }

        [When(@"user adds comment in the field bellow with desired message")]
        public void WhenUserAddsCommentInTheFieldBellowWithDesiredMessage()
        {
            CheckoutPage chp = new CheckoutPage(Driver);
            ut.EnterTextInElement(chp.commentField, TestConstants.comment);
            
        }

        [When(@"clicks on Place Order button")]
        public void WhenClicksOnPlaceOrderButton()
        {
            CheckoutPage chp = new CheckoutPage(Driver);
            ut.ClickOnElement(chp.placeOrderButton);
        }

        [When(@"user submits payment form")]
        public void WhenUserSubmitsPaymentForm()
        {
            PaymentPage pp = new PaymentPage(Driver);
            ut.EnterTextInElement(pp.fieldNameOnCard, TestConstants.NameOnCard);
            ut.EnterTextInElement(pp.fieldCardNnumber, TestConstants.CardNumber);
            ut.EnterTextInElement(pp.fieldCVC, TestConstants.CVC);
            ut.EnterTextInElement(pp.fieldExpiration1, TestConstants.ExpirationMM);
            ut.EnterTextInElement(pp.fieldExpiration2, TestConstants.ExpirationYY);
        }

        [When(@"click on Pay and Confirm Order button")]
        public void WhenClickOnPayAndConfirmOrder()
        {
            PaymentPage pp = new PaymentPage(Driver);
            ut.ClickOnElement(pp.buttonPayOrder);
        }

        [Then(@"user will get '(.*)' message")]
        public void ThenUserWillGetSuccessMessage(string done)
        {
            PaymentDone pd = new PaymentDone(Driver);
            Assert.True(ut.TextPresentInElement(done), "User did NOT confirmed the order");
        }
        
    }
}
