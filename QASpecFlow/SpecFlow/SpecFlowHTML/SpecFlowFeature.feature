Feature: SpecFlowFeature
	
Scenario: Order product

	Given Clean order configuration

	When I enter product Chai
	And I enter regoin Boston
	And I enter Dealer Leka Trading
	And I enter Checkout

	Then result should contains Chai, Boston, Leka Trading

Scenario: Order products with table
	Given Clean order configuration

	Then execution uses that table
	| Product     | Region    | Dealer          | Result                                 |
	| Chai        | Boston    | Leka Trading    | Chai, Boston, Leka Trading             |
	| Filo Mix    | Austin    | Tokyo Traders   | Filo Mix, Austin, Tokyo Traders        |
	| Gravad lax  | Cambridge | Ma Maison       | Gravad lax, Cambridge,  Ma Maison      |
	
Scenario Outline: Order products

	Given Clean order configuration

	When I enter product <Product>
	And I enter regoin <Region>
	And I enter Dealer <Dealer>
	And I enter Checkout

	Then result should be like this <Result>

	Examples:
	| Product     | Region    | Dealer          | Result                                 |
	| Chai        | Boston    | Leka Trading    | Chai, Boston, Leka Trading             |
	| Filo Mix    | Austin    | Tokyo Traders   | Filo Mix, Austin, Tokyo Traders        |
	| Gravad lax  | Cambridge | Ma Maison       | Gravad lax, Cambridge,  Ma Maison      | 
