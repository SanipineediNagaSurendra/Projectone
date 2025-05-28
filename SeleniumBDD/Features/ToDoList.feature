Feature: ToDoList

search for To-DO-List

@tag1
Scenario: Validating To-Do-List
	Given user navigate to the webdriver University url
	When user click on the To-Do-List
	
	When user delete  the "Go to potion class"
	Then deleted option should not be visible "Go to potion class"
