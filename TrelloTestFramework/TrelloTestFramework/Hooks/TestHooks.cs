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

        private static readonly DriverFactory _driverFactory = new DriverFactory();
        private static readonly ThreadLocal<IWebDriver> _driver = new ThreadLocal<IWebDriver>();

        public IWebDriver Driver
        {
            get { return _driver.Value; }
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Initialize WebDriver, etc...
            _driver.Value = _driverFactory.InitDriver();
        }
        
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario");
            
            // Get the feature and scenario titles
            var featureTitle = ScenarioContext.Current.ScenarioInfo.Title;
            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;

            // Start a new Allure test case            
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("AfterScenario");            // Finalize the Allure report
        }


        [AfterTestRun]
        public static void AfterTestRun()
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