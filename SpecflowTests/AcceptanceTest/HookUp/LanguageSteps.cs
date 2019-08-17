using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.HookUp
{
    [Binding]
    public class LanguageSteps : Utils.Start
    {
        
        [Given(@"I clicked on the profile tab under Profile page")]
        public void GivenIClickedOnTheProfileTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);
            //SpecflowPages.Utils.ProfileLangPage.CheckProfilePageClicked();
            // Click on Profile tab
             driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

            // IWebElement tbprofile = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            //tbprofile.Click();
            //Assert.AreEqual("Profile", tbprofile.Text);

        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {

            // call the profile page language class
            SpecflowPages.Utils.ProfileLangPage.AddLang();

        }
        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            // call the profile page language class
            SpecflowPages.Utils.ProfileLangPage.ValidateAddLang();

        }
        [When(@"I  update Language")]
        public void WhenIUpdateLanguage()
        {
            // call the profile page language class
            SpecflowPages.Utils.ProfileLangPage.UpdateLang();

        }
        [Then(@"that updated language should be displayed on my listings")]
        public void ThenThatUpdatedLanguageShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Utils.ProfileLangPage.ValidateUpdatedLang();

        }
        [When(@"I delete language")]
        public void WhenIDeleteLanguage()
        {
            SpecflowPages.Utils.ProfileLangPage.DeleteLang();
        }
        [Then(@"that language should not be displayed on my listings")]
        public void ThenThatLanguageShouldNotBeDisplayedOnMyListings()
        {
            SpecflowPages.Utils.ProfileLangPage.ValidateDeletedLang();
        }

    }
}
