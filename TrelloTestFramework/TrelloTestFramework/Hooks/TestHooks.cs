using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace TrelloTestFramework.TrelloTestFramework.Hooks
{

    [Binding]
    public class TestHooks
    {

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Initialize WebDriver, set up a database connection, etc.
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
        public static void AfterTestRun()
        {
            // Close WebDriver, clean up resources, etc.
        }

    }


}