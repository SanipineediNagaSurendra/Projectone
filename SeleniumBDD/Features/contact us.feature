Feature: contact us

search for contactfeature
@contactus
Scenario: validating  contactus form
	Given user navigate to the webdriver university Url
	When  user click on contactus link
	Then user should be redirect to contactus page
	When user fill the contact us form
	When user click on submit button
	Then  thankyou message should be displayed 