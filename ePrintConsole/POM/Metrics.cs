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
    class Metrics
    {
        public Metrics()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Metrics")]
        public IWebElement lnkMetrics { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='-1']")]
        public IWebElement ddlRType { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='CSV']")]
        public IWebElement ddlCSV { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='WEB']")]
        public IWebElement ddlWebReport { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='TXT']")]
        public IWebElement ddlTxt { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel1_ctl00_GenerateButton")]
        public IWebElement btnGReport { get; set; }

        public void metrics()
        {
            lnkMetrics.Clicks(); Thread.Sleep(500);
            ddlRType.Clicks(); Thread.Sleep(500);
            ePrintDateTimePicker.DatePickerMetrics("ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate"); Thread.Sleep(500);
            ePrintDateTimePicker.DatePickerMetrics("ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate"); Thread.Sleep(500);

            //CSV
            ddlCSV.Clicks(); Thread.Sleep(500);
            btnGReport.Clicks(); Thread.Sleep(3000);

            //Web Report
            ddlWebReport.Clicks(); Thread.Sleep(500);
            btnGReport.Clicks(); Thread.Sleep(3000);

            //text Report
            ddlTxt.Clicks(); Thread.Sleep(500);
            btnGReport.Clicks(); Thread.Sleep(3000);    
        }
    }
}
