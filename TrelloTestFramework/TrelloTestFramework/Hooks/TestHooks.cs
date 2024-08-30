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

    [BeforeScenario]
    public void BeforeScenario()
    {
        Console.WriteLine("BeforeScenario");
        IWebDriver webDriver = _driverFactory.InitDriver();
        _driver.Value = webDriver;
    }

    [AfterScenario]
    public void AfterScenario()
    {
        if (_driver.Value != null)
        {
            _driverFactory.Dispose(_driver.Value);
            _driver.Value = null;
        }
    }

    [AfterTestRun]
    public static void AfterTestRun()
    {
        Console.WriteLine("AfterTestRun");
        _driver.Dispose();
    }
}



}