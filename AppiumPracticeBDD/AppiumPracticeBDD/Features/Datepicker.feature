Feature: Datepicker

A short summary of the Datepicker feature

@tag1
Scenario: validating the Date
	Given user click on "Views" Button
	When user select on "Date Widgets" 
	And user select on "Dialog" button 
	And user select "CHANGE THE DATE"
	And user select the date "2026 May 31"
	Then verify that the selected date is displayed on the calender
