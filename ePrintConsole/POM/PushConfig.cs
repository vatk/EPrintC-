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
    class PushConfig
    {
        public PushConfig()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Push Configurations")]
        public IWebElement lnkPConfig { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserListPanel_ctl00_UserList_ExportUsers")]
        public IWebElement btnPush { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserListPanel_ctl00_UserList_UserListGrid_ctl01_SelectAll")]
        public IWebElement chkSelectAll { get; set; }

        public void pushImpUsers()
        {
            lnkPConfig.Clicks(); Thread.Sleep(500);
            chkSelectAll.Clicks(); Thread.Sleep(2000);
            btnPush.Clicks(); Thread.Sleep(2000);
        }
    }
}
