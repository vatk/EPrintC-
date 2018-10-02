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
    class EventNTracking
    {
        public EventNTracking()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        
        [FindsBy(How = How.LinkText, Using = "Track Jobs")]
        public IWebElement lnkTJobs { get; set; }

        [FindsBy(How = How.LinkText, Using = "Track Messages")]
        public IWebElement lnkTMessage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Track Events")]
        public IWebElement lnkTEvents { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_UserName")]
        public IWebElement txtTrackJobUserPin { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel1_ctl00_UserName")]
        public IWebElement txtTrackMsgUserPin { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel1_ctl00_UserName")]
        public IWebElement txtTrackEventUserPin { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_SearchButton")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_ExportButton")]
        public IWebElement btnExport { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel2_ctl00_jblist_ButtonRefresh")]
        public IWebElement btnReferesh { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel2_ctl00_msglist_ButtonRefresh")]
        public IWebElement btnTMsgReferesh { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel1_ctl00_SearchButton")]
        public IWebElement btnTMSearch { get; set; }

        public void trackJobs()
        {
            lnkTJobs.Clicks(); Thread.Sleep(500);
            txtTrackJobUserPin.EnterText("admin@hp.com");
            ePrintDateTimePicker.DatePickerPreHandling("ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_StartDate"); Thread.Sleep(500);
            ePrintDateTimePicker.DatePickerPreHandling("ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_EndDate"); Thread.Sleep(1000);
            btnSearch.Clicks(); Thread.Sleep(3000);
            btnExport.Clicks(); Thread.Sleep(3000);
        }

        public void trackMessage()
        {
            lnkTMessage.Clicks(); Thread.Sleep(500);
            txtTrackMsgUserPin.EnterText("admin@hp.com");
            ePrintDateTimePicker.DatePickerTrackMessage("ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate"); Thread.Sleep(500);
            ePrintDateTimePicker.DatePickerTrackMessage("ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate"); Thread.Sleep(500);
            btnTMSearch.Clicks(); Thread.Sleep(3000);                  
        }

        public void trackEvents()
        {
            lnkTEvents.Clicks(); Thread.Sleep(500);
            txtTrackEventUserPin.EnterText("admin@hp.com");
            ePrintDateTimePicker.DatePickerTrackEvents("ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate"); Thread.Sleep(500);
            ePrintDateTimePicker.DatePickerTrackEvents("ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate"); Thread.Sleep(500);
            tNotifyCheckBoxSelection(); Thread.Sleep(500);
            btnTMSearch.Clicks(); Thread.Sleep(3000);
        }

        public void tNotifyCheckBoxSelection()
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
