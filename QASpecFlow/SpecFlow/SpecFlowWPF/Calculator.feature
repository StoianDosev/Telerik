Feature: WPF Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to have calculator that works correctly

Scenario: Sum of 1 and 1

	Given clean calculator
	When I enter 1 
	And I press plus
	And I enter 1
	And I press equal
	Then result should be 2

Scenario: Sum of 2 and 2

	Given clean calculator
	When I enter 2 
	And I press plus
	And I enter 2
	And I press equal
	Then result should be 4

Scenario:  Sum of two digits

	Given clean calculator
	
	Then sum of two digits works like this:
	| Digit1 | Digit2 | Result |
	| 1      | 0      | 1      |
	| 1      | 1      | 2      |
	| 2      | 3      | 5      |	

# Scenario oulines
Scenario Outline: Sum

	Given clean calculator
	When I enter <digit1>
	And I press plus
	And I enter <digit2>
	And I press equal
	Then result should be <result>

	Examples:
	| digit1 | digit2 | result |
	| 1      | 0      | 1      |
	| 1      | 1      | 2      |
	| 2      | 3      | 5      |