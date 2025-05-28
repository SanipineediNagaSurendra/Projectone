Feature: filltheform

A short summary of the feature

@tag1
Scenario: validating filltheform
	Given user click on name textbox
	When user click on gender "Female"  radiobutton
	And user click on country "India" textbox
	And user click on "Let's  Shop" button
	Then user identify the toast message
	When  user click on Add the cart item
	And  user click on button cart
	 
