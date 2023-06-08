Feature: UsersTest

A short summary of the feature

@DataSource:../TestData/Users.json
Scenario: Get users form Json
	Given I got user <Login>, <FirstName>, <LastName>
	Then user should match to snapshoot

@DataSource:../TestData/Users.json
@DataSet:users
Scenario: Get users form Json with DataSet
	Given I got user <Login>, <FirstName>, <LastName>
	Then user should match to snapshoot
