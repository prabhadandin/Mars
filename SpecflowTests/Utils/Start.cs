﻿
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;


namespace SpecflowTests.Utils

{
    [Binding]
    public class Start : Driver
    {
       
        [BeforeScenario]
        public void SetUp()
        {
            //Launch the browser
            Driver.Initialize();
            Thread.Sleep(5000);

            //Call the Login Class            
            SpecflowPages.Utils.LoginPage.LoginStep();

        }
       
        [AfterScenario]                
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
            driver.Quit();
        }

    }
}
