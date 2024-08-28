using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace TrelloTestFramework.TrelloTestFramework.Pages
{

    public class LoginPage: BasePage
    {
            // Properties - Elements
        private static readonly By LoginButton = By.CssSelector("a[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']");
        private static readonly By UsernameInput = By.CssSelector("#username");
        private static readonly By PasswordInput = By.CssSelector("#password");
        private static readonly By LoginSubmitButton = By.CssSelector("#login-submit");
        private static readonly By DashboardBoardsList = By.CssSelector("ul.boards-page-board-section-list");

        // Constructor
        private LoginPage(){}

        // Methods - Actions
        private static class SingletonHelper 
        {
            public static readonly LoginPage Instance = new LoginPage();
        }

        public static LoginPage GetInstance()
        {
            return SingletonHelper.Instance;
        }   

        public void NavigateToLoginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://trello.com/login");
        }

        internal void EnterUsername(IWebDriver driver, string username)
        {
            IWebElement usernameInput = WaitForElementToBeVisible(driver, UsernameInput);
            usernameInput.SendKeys(username);
        }

        internal void EnterPassword(IWebDriver driver, string password)
        {
            try
            {
                IWebElement passwordInput = WaitForElementToBeVisible(driver, PasswordInput);
                passwordInput.SendKeys(password);
            }
            catch (ElementNotInteractableException)
            {
                // Add logging here later
                throw;
            }

        }

        internal void ClickLoginSubmitButton(IWebDriver driver)
        {
            driver.FindElement(LoginSubmitButton).Click();
        }
        
        internal bool IsLoggedIn(IWebDriver driver)
        {
            return driver.FindElement(DashboardBoardsList).Displayed;
        }

    } // end
} // end