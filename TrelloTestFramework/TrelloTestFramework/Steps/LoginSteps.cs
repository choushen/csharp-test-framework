using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TrelloTestFramework.TrelloTestFramework.Hooks;
using TrelloTestFramework.TrelloTestFramework.Pages;

namespace TrelloTestFramework.TrelloTestFramework.Steps
{

    [Binding]
    public class LoginSteps
    {

        private readonly LoginPage _loginPage = LoginPage.GetInstance();
        private readonly TestHooks _testHooks;


        public LoginSteps(TestHooks testHooks)
        {
            _testHooks = testHooks;
        }

        
        [Given(@"I navigate to the Trello login page")]
        public void NavigatedToTrelloLoginPage()
        {
            _loginPage.NavigateToLoginPage(_testHooks.Driver);
        } // end


        [When("I enter the username and password")]
        public void WhenIEnterTheUsernameAndPassword()
        {
            
            _loginPage.EnterUsername(_testHooks.Driver, "ruliotrio@gmail.com");
            _loginPage.ClickLoginSubmitButton(_testHooks.Driver);
            _loginPage.EnterPassword(_testHooks.Driver, "139Test391!");
        }


        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginSubmitButton(_testHooks.Driver);
        }


        [Then("I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {  
            Assert.That(_loginPage.IsLoggedIn(_testHooks.Driver));
        }
    
    } // end
} // end