Feature: LoginPortal

search for Loginform

@tag1
Scenario: Validating Login Portal page
	Given user is on Webdriver Home Page
	When user click on  Login Portal
	Then user should be redirect to the Login Page
	When  user fill the Login form
	When user click on Login Button 
	Then it should display popup window
	
