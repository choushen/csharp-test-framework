using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TrelloTestFramework.TrelloTestFramework.Driver
{

    public class DriverFactory
    {
        private IWebDriver _driver;
        
        public IWebDriver InitDriver() 
        {
            string browser = "chrome";

            switch(browser)
            {
                case "edge":
                    _driver = new EdgeDriver();
                    break;
                case "firefox":
                    _driver = new FirefoxDriver();
                    break;
                default:
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    _driver = new ChromeDriver(options);
                    break;
            }

            return _driver;
        }

        public void Dispose(IWebDriver driver)
        {
            driver.Quit();
        }

    }


}