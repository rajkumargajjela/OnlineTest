using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support.UI;

namespace ShoeTestsWithxUnit.StepDefinitions
{
    public class BaseSteps
    {
        public TestConfiguration _testConfiguration;
        public static IWebDriver driver;
        public static WebDriverWait wait;

        public BaseSteps()
        {
            _testConfiguration = new TestConfiguration();
            _testConfiguration.CreateConfig();

            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Driver");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
        }


        [Given(@"Navigate to Shoe Store site")]
        public void GivenNavigateToShoeStoreSite()
        {            
            driver.Navigate().GoToUrl(_testConfiguration.GetConfigValue("BaseUrl"));
            wait.Until((driver) => { return driver.Title.Contains("Shoe Store"); });
        }

        [Given(@"Click on ""(.*)"" menu link")]
        public void GivenClickOnMonthlyMenuLink(string monthName)
        {
            driver.FindElement(By.LinkText(monthName)).Click();
            wait.Until((driver) => { return driver.Title.Contains(monthName); });
        }      


        [When(@"""(.*)"" page is loaded")]
        public void WhenPageIsLoaded(string monthName)
        {
            wait.Until((driver) => { return driver.FindElement(By.TagName("h2")).Text.Equals(monthName + "'s Shoes"); });
        }


        [Then(@"Click on HOME button on top left and verify HOME page")]
        public void ThenClickOnHOMEButtonOnTopLeftAndVerifyHOMEPage()
        {
            driver.FindElement(By.LinkText("HOME")).Click();
            wait.Until((driver) => { return driver.FindElement(By.TagName("h2")).Text.Equals("Welcome to Shoe Store!"); });
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver?.Close();
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
