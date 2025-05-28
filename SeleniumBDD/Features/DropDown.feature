Feature: DropDown,Checkboxes
search for the dropdown menu

@tag1
Scenario: Validating dropdown menu
	Given user click on dropdownLink
	When  user select the language in dropdown "SQL"
	Then  selected value "SQL" should be displayed the language
	When user select the framework "TestNG"
	Then selected value "Maven" should be displayed on framework
	When user select the script "CSS"
	Then selected value "CSS" should be displayed on scripting

Scenario: validating checkbox menu
    Given user click on checkboxLink
    When user select "Option 1" checkbox
    Then selected "Option 1" checkbox should be displayed

Scenario: working with table checkbox menu
    Given user click on dropdownbuttonLink
    When user select all the checkboxes
        | checkboxes |
        | Option 1   |
        | Option 2   |
        | Option 3   |
        | Option 4   |
    Then selected table should be checked
        | checkboxes |
        | Option 1   |
        | Option 2   |
        | Option 3   |
        | Option 4   |

 