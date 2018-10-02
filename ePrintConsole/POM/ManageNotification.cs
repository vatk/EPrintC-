using ePrintConsole.PropColleactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ePrintConsole.POM
{
    class ManageNotification
    {
        public ManageNotification()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "View and Manage Notifications")]
        public IWebElement lnkVMNotification { get; set; }

        [FindsBy(How = How.LinkText, Using = "Enable and Disable Notifications")]
        public IWebElement lnkEDNotification { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UpdateButton")]
        public IWebElement btnUpdate { get; set; }

        public void manageNitification()
        {
            lnkVMNotification.Clicks(); Thread.Sleep(500);
            lnkEDNotification.Clicks(); Thread.Sleep(500);
            enableNdisableCheckBoxSelection(); Thread.Sleep(500);
            btnUpdate.Clicks(); Thread.Sleep(2000);
            lnkEDNotification.Clicks(); Thread.Sleep(3000);
        }

        public void enableNdisableCheckBoxSelection()
        {
            string checkboxXPath = "//input[contains(@type, 'checkbox')]";
            var allCheckboxes = PropertiesCollection.driver.FindElements(By.XPath(checkboxXPath));
            foreach (IWebElement checkbox in allCheckboxes)
            {
                try
                {
                    ((IJavaScriptExecutor)PropertiesCollection.driver).ExecuteScript(
                            "arguments[0].scrollIntoView(true);", checkbox);
                    //Thread.Sleep(1000);
                    if (!checkbox.Selected)
                    {
                        checkbox.Click();
                        Thread.Sleep(100);
                    }
                    else
                    {
                        checkbox.Click();
                        Thread.Sleep(100);
                    }
                    Thread.Sleep(500);
                }
                catch (Exception e)
                {
                }
            }
        }

    }
}
