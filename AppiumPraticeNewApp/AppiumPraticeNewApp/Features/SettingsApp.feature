Feature: SettingsApp

A short summary of the feature

@tag1
Scenario: Validating Message Feature
	Given I launch the settings app
	Then user can verify 'Settings' header on Homepage
	When user click on the 'Messages'
	And user click on the Shortcut Buttons Enable button
	Then verify enable button is enabled
