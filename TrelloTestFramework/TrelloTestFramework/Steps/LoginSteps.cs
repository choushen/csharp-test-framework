using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace TrelloTestFramework.TrelloTestFramework.Steps
{

    [Binding]
    public class LoginSteps
    {
        
    [Given(@"I navigate to the Trello login page")]
    public void NavigatedToTrelloLoginPage()
    {
    
    } // end

    // This step definition uses Cucumber Expressions. See https://github.com/gasparnagy/CucumberExpressions.SpecFlow
    [Then("I should be logged in")]
    public void ThenIShouldBeLoggedIn()
    {
        // Write code here that turns the phrase above into concrete actions
    }

    // This step definition uses Cucumber Expressions. See https://github.com/gasparnagy/CucumberExpressions.SpecFlow
    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        // Write code here that turns the phrase above into concrete actions
    }

    // This step definition uses Cucumber Expressions. See https://github.com/gasparnagy/CucumberExpressions.SpecFlow
    [When("I enter the username and password")]
    public void WhenIEnterTheUsernameAndPassword()
    {
        // Write code here that turns the phrase above into concrete actions
    }
    

    } // end
} // end