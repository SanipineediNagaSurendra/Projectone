Feature: Datepicker

A short summary of Datepicker
@tag1
Scenario: validating datepicker
	Given user click  on datepicker
	When  user select some date "01-02-2027"
	Then selected date should be displayed on datepicker
