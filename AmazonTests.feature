Feature: AmazonTests
		to find ipad on amazon

@mytag
Scenario: Assert first price of ipad
	Given I have entered ipad in the search bar
	When I press search
	Then the first result returned should be equal

Scenario: Assert Not equal to last price
	Given I have entered ipad in the search bar
	When I press search
	Then count the total results returned 
	And print it to output window
	And assert the last price of ipad is not equal

