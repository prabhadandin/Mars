using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
  public class LoginPage
    {
        public static void LoginStep()
        {

            //driver.NavigateUrl();
            Thread.Sleep(1000);

            Driver.driver.FindElement(By.XPath("//a[contains(.,'Sign In')]")).Click();
            //Enter Username
            Driver.driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("prabhavathi6@gmail.com");
            //Enter password
            Driver.driver.FindElement(By.XPath("//input[contains(@name,'password')]")).SendKeys("prabha@ic");
            Thread.Sleep(1000);
            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//button[contains(.,'Login')]")).Click();
            //button[contains(.,'Sign Out')]
            //Validate if user logged in or not
           IWebElement loggedin = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
           Assert.AreEqual(loggedin.Text,"Hi prabhavathi");
        }
        
    }
}
