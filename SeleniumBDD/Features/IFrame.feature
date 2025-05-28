Feature: IFrame

searcch for the IFrame Text

@tag1
Scenario: Validating IFrame feature
	Given user click on IFrame Link
	When user redirect to the IFrame Page
	When user switch to frame with id "frame"
	When user can select "Who Are we?" text
	Then i should see the expected result
