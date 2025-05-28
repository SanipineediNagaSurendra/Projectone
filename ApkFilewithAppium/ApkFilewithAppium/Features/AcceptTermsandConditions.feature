Feature: AcceptTermsandConditions

A short summary of the feature

Background: 
 Given I Launch the PluginApp

@tag1
Scenario: Validating TermsAndConditions Link 
    Given I have not previously accepted Terms and Conditions and Privacy Policy
    When Accept 'AcceptTermsAndConditionsPlugin' flow has been started
    Then verify Option to read 'Terms and Conditions' is 'displayed' on 'Terms and conditions PluginPage' 

@tag2
 Scenario: validating Privacy Policy Link
    Given I have not previously accepted Terms and Conditions and Privacy Policy
    When Accept 'AcceptTermsAndConditionsPlugin' flow has been started
    Then verify Option to read 'Privacy policy' is 'displayed' on 'Terms and conditions PluginPage'

@tag3
Scenario: Validating Termsandconditions checkbox
  Given I have not previously accepted Terms and Conditions and Privacy Policy
  When Accept 'AcceptTermsAndConditionsPlugin' flow has been started
  Then the option to accept 'Terms and Conditions’ and 'Privacy Policy' shall be presented.

@tag4
Scenario: validating to Accept checkbox
 Given I have not previously accepted Terms and Conditions and Privacy Policy
 When Accept 'AcceptTermsAndConditionsPlugin' flow has been started
 And  I have accepted the Terms and Conditions 'checkbox' and Privacy Policy
 And I have accepted the 'Continue' accept button
 Then verify Option to read 'AcceptTermsAndConditionsPlugin' is 'displayed' on 'TestMultiplePluginHomePage'

 @tag5
 Scenario: User cannot proceed without accepting Terms and Conditions
 When Accept 'AcceptTermsAndConditionsPlugin' flow has been started
 And I have not previously accepted 'Terms and Conditions' 
 And the Terms and conditions of 'checkbox' is not accepted,
 Then the user shall not be able to proceed with using the app.

 
 