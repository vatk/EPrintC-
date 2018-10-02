using ePrintConsole.PropColleactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePrintConsole.POM
{
    class Overview
    {
        public Overview()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Overview Screen")]
        public IWebElement lnkOScreen { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel1_ctl00_ServiceTool1_ButtonRefresh")]
        public IWebElement btnCoreServicesCondition { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panelcurrent_ctl00_jbl0_ButtonRefresh")]
        public IWebElement btnJobscurrently{ get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel2_ctl00_jbl_ButtonRefresh")]
        public IWebElement btnLasthoursfailed { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel3_ctl00_msglistProcessing_ButtonRefresh")]
        public IWebElement btnbeingprocessed { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_panel4_ctl00_msglistFailed_ButtonRefresh")]
        public IWebElement btnFailedmessages { get; set; }
    }
}
