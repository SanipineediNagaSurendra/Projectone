Feature: ApiDemosApp

A short summary of the apidemos feature

@tag1
Scenario: validating ApiDemos app views menu 
    Given user click on "Views" 
	When user click on "Expandable Lists"
	And user clicks on "Custom Adapter"
	And user longpress on "People Names"
	Then user should see the popup "Sample menu"
	

@tag2
Scenario: validating ApiDemos app gallery menu 
	Given user click on "Views" 
	When user click on "Gallery" 
	And user clicks on "Photos"
	And user swiping the image 

@tag3
Scenario: validating ApiDemos app Tabs menu 
	Given user click on "Views" 
	When user scroll and click on "Tabs"
	And user clicks on "Content By Id"
	And user select on "TAB2"

@tag4
Scenario: validating ApiDemos app preference menu 
	Given user click on "Preference" 
	When user click on "Preference dependencies"
	And user click  on Wifi checkbox
	And user click on  "WiFi settings"
	And user enter the name "Surendra" in textbox
	And user click on the "OK" button

@tag5
Scenario: validating ApiDemos app content menu 
	Given user click on "Content" 
	When user click on "Assets"
	And user click on "Read Asset"
	Then user should validate the text

@tag6
Scenario: validating ApiDemos app Datewidget menu 
	Given user click on "Views" 
	When user click on "Date Widgets"
	And user click on "Dialog"
	And user click on the  "CHANGE THE DATE"
	And user select the date "2050 May 21"
	Then should display the given date 



	
