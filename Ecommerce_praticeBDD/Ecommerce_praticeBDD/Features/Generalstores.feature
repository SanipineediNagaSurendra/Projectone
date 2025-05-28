Feature: Generalstores

A short summary of the general stores feature

@tag1
Scenario: validating GeneralStores app
	Given user enter the name in YourName Textbox "Naga Surendra"
	When user select the country "India"
	And user check the Gender radio button "Female"
	And Finally click the "Let's Shop" button
	Then user can leave any feild in homepage identify the toast message
