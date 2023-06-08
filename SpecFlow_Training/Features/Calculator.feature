
Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlow_Training/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Add two Strings
	Given the first string is "Sai"
	And the second string is "krishna"
	When the two strings are added
	Then the result should be "Saikrishna"

Scenario: Working with multiple data with tables
	Given Fill below deatisl in form and submit
	| Name | Age | Phone     | Email         |
	| Sai  | 26  | 901091111 | xyz@gmail.com |
	| Krishna  | 28  | 569841111 | abc@gmail.com |
	Given Fill below details in form and submit without objects
	| Name | Age | Phone     | Email         |
	| Sai  | 26  | 901091111 | xyz@gmail.com |
	| Krishna  | 28  | 569841111 | abc@gmail.com |

Scenario Outline:Data driven testing
	Given Fill below details in form and submit <Name> <Age> <Phone> and <Email>
	Examples: 
	| Name | Age | Phone | Email |
	| Sai  | 26  | 901091111 | xyz@gmail.com |
	| Krishna  | 28  | 569841111 | abc@gmail.com |

@smoketest @regression
Scenario: Scenario context example
This scenario explains the functionality of scenario context
	Given This is my first step
	Then I wnat to know the details of this scenario