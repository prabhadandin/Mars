using NUnit.Framework;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;


namespace SpecflowTests.Utils

{
    [TestFixture]
    public class Start : Driver
    {
       
        [SetUp]
        public void Login()
        {
            //Launch the browser
            Driver.Initialize();
            Thread.Sleep(1500);

            //Call the Login Class            
            SpecflowPages.Utils.LoginPage.LoginStep();

        }
        
        [Test]
        public void FeatureLanguage1()
        {

            //call the profile page language class
            SpecflowPages.Utils.ProfileLangPage.AddLang();
            SpecflowPages.Utils.ProfileLangPage.ValidateAddLang();
            SpecflowPages.Utils.ProfileLangPage.UpdateLang();
            SpecflowPages.Utils.ProfileLangPage.ValidateUpdatedLang();
            SpecflowPages.Utils.ProfileLangPage.DeleteLang();
            SpecflowPages.Utils.ProfileLangPage.ValidateDeletedLang();


        }
       
        [TearDown]
                 
        public void TearDown()
        {
            Thread.Sleep(500);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            // end test. (Reports)
            CommonMethods.extent.EndTest(CommonMethods.test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.extent.Flush();

            //Close the browser
            Driver.driver.Quit();
        }

    }
}
