using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium.Support.UI;

namespace ShoeTestsWithxUnit.StepDefinitions
{
    [Binding]
    public class ShoeTestsSteps : BaseSteps
    {

        [Then(@"Choose a brand lable should be displayed")]
        public void ThenChooseABrandLableShouldBeDisplayed()
        {
            string chooseABrandlabel = driver.FindElement(By.XPath("//label[@class='col-md-4 control-label']")).Text;
            chooseABrandlabel.Should().Be("Choose a brand");
        }

        [When(@"Shoe Store is loaded")]
        public void WhenShoeStoreIsLoaded()
        {
            wait.Until((driver) => { return driver.Title.Contains("Shoe Store"); });
        }

        [Then(@"Choose a brand dropdown should be displayed and the dropdown items should be morethan one")]
        public void ThenChooseABrandDropdownShouldBeDisplayedAndTheDropdownItemsShouldBeMorethanOne()
        {
            IWebElement element = driver.FindElement(By.Id("brand"));
            SelectElement oSelect = new SelectElement(element);
            oSelect.Options.Count.Should().BeGreaterThan(1);
        }


        [Then(@"Choose a brand Search button should be displayed")]
        public void ThenChooseABrandSearchButtonShouldBeDisplayed()
        {
            driver.FindElement(By.Id("search_button")).Click();
            wait.Until((driver) => { return driver.FindElement(By.XPath("//div[@id='flash']/div")).Text.Equals("Please Select a Brand"); });
        }

        [When(@"Click on ""(.*)"" menu link")]
        public void WhenClickOnMenuLink(string monthName)
        {
            driver.FindElement(By.LinkText(monthName)).Click();
        }


        [Then(@"Verify Page Title Should Contains the ""(.*)"" name")]
        public void ThenVerifyPageTitleShouldContainsTheName(string monthName)
        {
            string title = driver.Title;
            title.Should().Contain(monthName);
        }


        [Then(@"""(.*)"" page is loaded")]
        public void ThenPageIsLoaded(string monthOrBrandName)
        {

            string monthOrBrandNameHeaderText = driver.FindElement(By.TagName("h2")).Text;

            if (monthOrBrandNameHeaderText == "All Shoes")
                monthOrBrandNameHeaderText.Should().Be(monthOrBrandName);
            else
                monthOrBrandNameHeaderText.Should().Be(monthOrBrandName + "'s Shoes");
        }


        [Then(@"Click on Brand ""(.*)"" Name in All Shoes page")]
        public void ThenClickOnBrandNameInAllShoesPage(string shoeBrandOrMonthName)
        {
            driver.FindElement(By.LinkText(shoeBrandOrMonthName)).Click();
        }

        [When(@"Click on Remind me of new shoes Submit button")]
        public void WhenClickOnRemindMeOfNewShoesSubmitButton()
        {
            driver.FindElement(By.Id("remind_email_submit")).Click();
        }


        [When(@"Enter an email address ""(.*)""")]
        public void WhenEnterAnEmailAddress(string remindMeEmailAddress)
        {
            driver.FindElement(By.Id("remind_email_input")).SendKeys(remindMeEmailAddress);
        }

        [Then(@"We should receive a message with ""(.*)""")]
        public void ThenWeShouldReceiveAMessageWith(string flashMessage)
        {
            string flashMessageErrorOrSuccess = driver.FindElement(By.XPath("//div[@id='flash']/div")).Text;
            flashMessageErrorOrSuccess.Should().Be(flashMessage);
        }


        [When(@"Enter a notification email address ""(.*)""")]
        public void WhenEnterANotificationEmailAddress(string notificationEmailAddress)
        {
            driver.FindElement(By.XPath("//input[@class='notification_email_input']")).SendKeys(notificationEmailAddress);
        }


        [When(@"Click on Notification Email Submit button")]
        public void WhenClickOnNotificationEmailSubmitButton()
        {
            driver.FindElement(By.XPath("//input[@class='notification_email_submit']")).Click();
        }


        [Given(@"Select some value from the dropdown ""(.*)""")]
        public void GivenSelectSomeValueFromTheDropdown(string brandName)
        {
            IWebElement element = driver.FindElement(By.Id("brand"));
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByText(brandName);
        }


        [When(@"Click on Choose a brand Search button")]
        public void WhenClickOnChooseABrandSearchButton()
        {
            driver.FindElement(By.Id("search_button")).Click();
        }
       

        [Then(@"Validate Brand Details in Monthly pages ""(.*)""")]
        public void ThenValidateBrandDetailsInMonthlyPages(string monthName)
        {
            string shoeBrandValue = driver.FindElement(By.XPath("//td[@class='shoe_result_value shoe_brand']/a")).Text;
            shoeBrandValue.Should().NotBeNullOrEmpty();

            string shoeNameValue = driver.FindElement(By.XPath("//td[@class='shoe_result_value shoe_name']")).Text;
            shoeNameValue.Should().NotBeNullOrEmpty();

            string shoePriceValue = driver.FindElement(By.XPath("//td[@class='shoe_result_value shoe_price']")).Text;
            shoePriceValue.Should().NotBeNullOrEmpty();

            string shoeDescriptionValue = driver.FindElement(By.XPath("//td[@class='shoe_result_value shoe_description']")).Text;
            shoeDescriptionValue.Should().NotBeNullOrEmpty();

            string shoeReleaseMonthValue = driver.FindElement(By.XPath("//td[@class='shoe_result_value shoe_release_month']/a")).Text;
            shoeReleaseMonthValue.Should().Be(monthName);
        }


    }
}
