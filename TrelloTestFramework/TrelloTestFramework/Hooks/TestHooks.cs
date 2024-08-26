using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TrelloTestFramework.TrelloTestFramework.Driver;

namespace TrelloTestFramework.TrelloTestFramework.Hooks
{

    [Binding]
    public class TestHooks
    {

        private DriverFactory _driverFactory = new DriverFactory();
        ThreadLocal<WebDriver> _driver = new ThreadLocal<WebDriver>();

        [BeforeTestRun]
        public void BeforeTestRun()
        {
            // Initialize WebDriver, etc...
            _driver.Value = _driverFactory.InitDriver();
        }
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("AfterScenario");
        }


        [AfterTestRun]
        public void AfterTestRun()
        {
            // Close WebDriver, close browser, etc...
            if(_driver.Value != null)
            {
                _driverFactory.Dispose(_driver.Value);
                _driver.Value = null;
                _driver.Dispose();
            }

            
        }

    }


}