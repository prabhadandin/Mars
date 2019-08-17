using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using SpecflowPages.Utils;


namespace SpecflowTests.AcceptanceTest.HookUp
{
    [Binding]
    public class LanguageSteps : Utils.Start
    {
        ProfileLangPage languageObj;
        private ProfileLangPage langObj;


        [Given(@"I clicked on the profile tab under Profile page")]
        public void GivenIClickedOnTheProfileTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);
            // Click on Profile tab
             driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

           
        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            //Call AddLang Mehthod to add new Language
            languageObj = new ProfileLangPage();
            languageObj.AddLang();

        }
        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            //Call ValidateAddLang Mehthod to validate added language
            languageObj.ValidateAddLang();
			

        }
        [When(@"I  update Language")]
        public void WhenIUpdateLanguage()
        {
            //Call UpdateLang Mehthod to update the give language
            langObj = new ProfileLangPage();
            langObj.UpdateLang();
			

        }
        [Then(@"that updated language should be displayed on my listings")]
        public void ThenThatUpdatedLanguageShouldBeDisplayedOnMyListings()
        {
            //Call ValidateUpdatedLang Mehthod to Validate updated language
            langObj.ValidateUpdatedLang();

			

        }
        [When(@"I delete language")]
        public void WhenIDeleteLanguage()
        {
            //Call DeleLang Mehthod to delete a given langaguge
            
            langObj = new ProfileLangPage();
            langObj.DeleteLang();

			
        }
        [Then(@"that language should not be displayed on my listings")]
        public void ThenThatLanguageShouldNotBeDisplayedOnMyListings()
        {
            //Call ValidatedeletedLang to validate deleted langugae
            langObj = new ProfileLangPage();
            langObj.ValidateDeletedLang();

        }

    }
}
