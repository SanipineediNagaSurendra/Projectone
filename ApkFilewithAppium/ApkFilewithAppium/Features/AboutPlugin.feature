Feature: AboutPlugin

A short summary of the feature

@tag1
Scenario: Validating Aboutplugin Supportpage
	Given I Launch the PluginApp
	When I start 'AboutPlugin' flow
    Then verify Option to read 'Support' is 'displayed' on 'AboutPluginPage' 

@tag2
Scenario: Validating hearing aid compatibility Link
  Given I Launch the PluginApp
  When I start 'AboutPlugin' flow
  Then a link for accessing the 'https://www.resound.com/en/help/compatibility' webpage is shown

@tag3
Scenario: Validating UserGuide compatibility Link
  Given I Launch the PluginApp
  When I start 'AboutPlugin' flow
  Then a link for accessing the 'https://www.resound.com/en-us/help/apps/smart-3d' webpage is shown

