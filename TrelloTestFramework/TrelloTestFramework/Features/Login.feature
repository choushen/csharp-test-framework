Feature: Login

Scenario: Login to Trello
    Given I navigate to the Trello login page
    When I enter the username and password
    And I click the login button
    Then I should be logged in