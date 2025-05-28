Feature: LongclickGuesters

A short summary of the feature

@tag1
Scenario: validating longclick guesters
	Given User click on "Views" 
	When user click on "Expandable Lists" button
	And user clicks on "Custom Adapter" 
	And user longclick on "People Names"
	Then should dispaly "Sample menu"

	





