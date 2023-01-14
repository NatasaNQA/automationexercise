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
            ut.ClickOnElement(pdp.addToCart);
        }
        
        [When(@"proceeds to cart")]
        public void WhenProceedsToCart()
        {
            PDetailsP pdp = new PDetailsP(Driver);
            ut.ClickOnElement(pdp.viewCart);
        }
        
        [Then(@"shopping cart will be displeyed with desired '(.*)' product inside")]
        public void ThenShoppingCartWillBeDispleyedWithDesiredProductInside(string pageFound)
        {
            CartPage cp = new CartPage(Driver);
            Assert.True(ut.TextPresentInElement(pageFound), "Desired product is not in the cart!");
        }
    }
}
