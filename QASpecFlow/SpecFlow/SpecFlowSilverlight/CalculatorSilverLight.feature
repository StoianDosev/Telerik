Feature: Calculator
	Scenario: Multiplication of 12 and 5
	Given clean calculator	
	When I enter 12
	And I press multiplication
	And I enter 5
	And I press equal
	Then the result should be 60

Scenario: Multiplication of two numbers
	Given clean calculator

	Then multiplication works like this
	| Number1 | Number2 | Result |
	| 20      | 6       | 120    |
	| 2       | 250     | 500    |
	| 14      | 5       | 70     |
	| 9       | 3       | 27     |


Scenario Outline: MultiplicationOutline
	Given clean calculator
	When I enter <digit1>
	And I press multiplication
	And I enter <digit2>
	And I press equal
	Then the result should be <result>

	Examples: 
	| digit1  | digit2  | result |
	| 15      | 4       | 60     |
	| 0       | 1       | 0      |
	| 9       | 2       | 18     |

