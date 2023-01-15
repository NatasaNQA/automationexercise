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