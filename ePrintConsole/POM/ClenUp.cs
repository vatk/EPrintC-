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
    class ClenUp
    {
        public ClenUp()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Usage Data Cleanup")]
        public IWebElement lnkUDCleanup { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_CleanTrackingCheckBox")]
        public IWebElement chkTInfo { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_CleanJobsCheckBox")]
        public IWebElement chkJInfo { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_TimeFrameOption_0")]
        public IWebElement rdoEvery { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_CleanupButton")]
        public IWebElement btnClenup { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_ConfirmButton")]
        public IWebElement btnConfirm { get; set; }

        public void userDataCleanUp()
        {
            Overview oPage = new Overview();
            lnkUDCleanup.Clicks(); Thread.Sleep(500);
            userDataCleanCheckBoxSelection(); Thread.Sleep(500);
            rdoEvery.Click();
            DTimePicker("ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_OlderThanCalendar"); Thread.Sleep(500);
            btnClenup.Clicks(); Thread.Sleep(500);
            btnConfirm.Clicks(); Thread.Sleep(1000);
            oPage.lnkOScreen.Clicks(); Thread.Sleep(3000);
        }

        public static void DTimePicker(string element)
        {
            IWebElement table = PropertiesCollection.driver.FindElement(By.Id("ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_OlderThanCalendar"));
            table.Click();
            DateTime now = DateTime.Now;
            PropertiesCollection.driver.FindElement(By.LinkText(now.Day.ToString())).Click();
        }

        public void userDataCleanCheckBoxSelection()
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
