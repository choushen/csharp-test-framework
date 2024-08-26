using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TrelloTestFramework.TrelloTestFramework.Pages
{

    public class BasePage
    {
        
        protected IWebElement WaitForElementToBeVisible(WebDriver driver, By Locator, int timeout = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(Locator));
            return element;
        }
    }


}