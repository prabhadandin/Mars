using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPages.Utils
{
   
    class HomePage
    {
        
        IWebElement tbprofile => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
        IWebElement tblanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]"));

        public void NavigateProfileTabs()
        {
            //Click on profile tab
            tbprofile.Click();
            //Click on language tab
            tblanguage.Click();
        }
            
                 


    }
}
