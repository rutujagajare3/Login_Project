Feature: CustomerLogin

A short summary of the feature

@tag1
Scenario: Successfull CustomerLogin
	Given I am on the login page
    When I enter valid username and password
    And I click on the login button
    Then I should be redirected to the dashboard
Scenario: Failed login
    Given I am on the login page
    When I enter invalid username and password
    And I click on the login button
    Then I should see an error message



