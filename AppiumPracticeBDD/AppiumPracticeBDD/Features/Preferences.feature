Feature: Preferences

A short summary of the feature

Scenario: validating wifi setting feature
	Given User click on "Preference" button
	When user click on "Preference dependencies"
	And user checked on "wifi checkbox"
	And user click on wifi settings 
	
	Then wifi settings popup should be dispalyed