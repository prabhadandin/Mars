using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
   public  class ProfileLangPage
    {

     
        //Add New Language
        public void AddLang()
        {

            //Click on Add New button@FindBy(xpath = "(//div[contains(.,'Add New')])[11]")
             Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
           
            //Enter the language
            Driver.driver.FindElement(By.XPath("//input[@name = 'name']")).SendKeys("Hindi");
            //Select the language level.
            SelectElement select = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name ='level']")));
            select.SelectByIndex(1);
             //Click on Add
             Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            

        }

        //Validate the language is added sucessfully
        public  void ValidateAddLang()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                //Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                String expectedValue = "Hindi";

                
                string actualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                    //Check if expected value is equal to actual value

                    if (expectedValue == actualValue)
                    {

                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                        Assert.IsTrue(true);

                    }

                    else
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

                }

            
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        //Update the given Language
        public void UpdateLang()
        {
            String expecteValue= "Chinese1";

            //Get the table list
            IList<IWebElement> Tablerows = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr"));
            //Get the row count in table
            var rowCount = Tablerows.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                
                //Get the xpath of ith row Language name
                String actualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //check if the editLanguage Parameter matches with ith row Language name
                if (actualValue.Equals(expecteValue))
                {

                    //CliCk on Edit icon

                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i")).Click();


                    //Send Language name to update
                    IWebElement editRowValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input[1]"));
                    //Clear Previous text 
                    editRowValue.Clear();
                    editRowValue.SendKeys("Japnese");

                    //Select Language Level to update
                    var langLevelList = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select"));
                    var selectElement = new SelectElement(langLevelList);
                    selectElement.SelectByIndex(2);

                    // Click on update button
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();

                }
            }

         

        }

        //Validate the updated language
        public  void ValidateUpdatedLang()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Updated a Language");

                String expectedValue = "Japnese";
                Thread.Sleep(1000);
                string actualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                //Check if expected value matched with actual value
                if (expectedValue == actualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Uddated a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageUpdated");
                    Assert.IsTrue(true);
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        //Delete a given language
        public  void DeleteLang()
        {
            String expectedValue = "Japnese";
            //Get the table row list
            IList<IWebElement> Tablerows = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr"));
            //Get the row count of table
            var rowCount = Tablerows.Count;
            
            for (int i = 1; i <= rowCount; i++)
            {
                //Get the xpath of ith row LanguageName
                String rowValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                Console.WriteLine("Beforeifdel" + rowValue);
                //check if the DeleteLanguage parameter matches with ith Row LanguageName
                if (rowValue.Equals(expectedValue))
                {
                    Console.WriteLine("afterifdel" + expectedValue);
                    // Click on delete button
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();

                }



            }

        }

        //Validate a deleted language
        public  void ValidateDeletedLang()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                //Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Deleted a Language");

                String expectedValue = "German";
                //Get the row text
                string actualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                //Thread.Sleep(500);
                //Check if the deletedlanguage parameter matches with ith rowtext
                if (expectedValue != actualValue)
                {
                    Assert.IsTrue(true);
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeleted");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
    }

   
   }
