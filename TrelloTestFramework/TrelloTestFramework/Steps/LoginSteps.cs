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
        private readonly TestHooks _testHooks;

        public LoginSteps(TestHooks testHooks)
        {
            _testHooks = testHooks;
        }

        [Given(@"I navigate to the Trello login page")]
        public void NavigatedToTrelloLoginPage()
        {
            // Retrieve the singleton instance and use the current thread's WebDriver
            LoginPage.GetInstance().NavigateToLoginPage(_testHooks.Driver);
        }

        [When("I enter the username and password")]
        public void WhenIEnterTheUsernameAndPassword()
        {
            // Retrieve the singleton instance and use the current thread's WebDriver
            var loginPage = LoginPage.GetInstance();
            loginPage.EnterUsername(_testHooks.Driver, "ruliotrio@gmail.com");
            loginPage.ClickLoginSubmitButton(_testHooks.Driver);
            loginPage.EnterPassword(_testHooks.Driver, "139Test391!");
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            // Retrieve the singleton instance and use the current thread's WebDriver
            LoginPage.GetInstance().ClickLoginSubmitButton(_testHooks.Driver);
        }

        [Then("I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            // Retrieve the singleton instance and use the current thread's WebDriver
            bool isLoggedIn = LoginPage.GetInstance().IsLoggedIn(_testHooks.Driver);
            Assert.That(isLoggedIn, Is.True);
        }
    }
}
