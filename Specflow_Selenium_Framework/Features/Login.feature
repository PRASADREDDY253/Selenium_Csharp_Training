Feature: Login
  In order to access my account
  As a user
  I want to be able to log in
  @regression
  @DataSource:../TestData/LoginUsers.json
  Scenario: Successful login
    Given I am on the login page
    When I enter my <username> and <password>
    And I click on the login button
    Then I should be logged in