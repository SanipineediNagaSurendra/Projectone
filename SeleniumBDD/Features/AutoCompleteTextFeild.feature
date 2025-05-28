Feature: AutoCompleteTextFeild

search for the fooditem

@tag1
Scenario: Validating AutoTextFeild
	Given user click on AutoTextFeild link
	When user search on "gr" named fooditems
	Then should dispaly the "gr" named fooditems
	            