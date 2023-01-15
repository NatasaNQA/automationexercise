Feature: PDP
	As a user
	I want to be able to add the products to cart
	So I can complete the purchase

@mytag
Scenario: User can add product to cart
	Given user opens products page
		And searches for 'Winter Top' term
		And opens first search result
	When user clicks on Add to cart button
		And proceeds to cart
	Then shopping cart will be displeyed with expected product inside

Scenario: User can check out their order
	Given user opens sign in page
		And enters correct credentials
		And user submits login form
		And user will be logged in
		And adds product 'Winter top' to cart
		And click on Proceed to checkout button
	When user adds comment in the field bellow with desired message
		And clicks on Place Order button
		And user submits payment form
		And click on Pay and Confirm Order button
	Then user will get 'Order Placed!' message 