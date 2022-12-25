using AutomationExcersiseFramework.Helpers;
using AutomationExcersiseFramework.Pages;
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
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user clicks on Add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"proceeds to cart")]
        public void WhenProceedsToCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"shopping cart will be displeyed with desired '(.*)' product inside")]
        public void ThenShoppingCartWillBeDispleyedWithDesiredProductInside(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
