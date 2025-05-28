Feature: Cart

A short summary of the feature

@tag1
Scenario: Selecting the items to the cart
	Given Selecting the random elements from the page
	When the cart button is clicked
	Then verify the items in the cart
