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
    class LDAP
    {
        public LDAP()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Security Realm")]
        public IWebElement lnksRealm { get; set; }

        [FindsBy(How = How.LinkText, Using = "LDAP Configuration Settings")]
        public IWebElement lnkConfigSetting { get; set; }

        [FindsBy(How = How.LinkText, Using = "Verify connection")]
        public IWebElement lnkVerifyCon { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_UserNameTextbox")]
        public IWebElement txtChangeLdapUser { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_PasswordTextbox")]
        public IWebElement txtChangeLdapUserPassword { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_ValidateButton")]
        public IWebElement btnLDAPValidate { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_MessagePanel_ctl00_SaveButton")]
        public IWebElement btnLDAPSave { get; set; }

        public void ldapSecurityRealm()
        {
            lnksRealm.Clicks(); Thread.Sleep(500);
            allRadioButton();
            btnLDAPSave.Clicks(); Thread.Sleep(500);
            txtChangeLdapUser.EnterText("Vijay@ee.in");
            txtChangeLdapUserPassword.EnterText("Iso*help");
            btnLDAPValidate.Clicks(); Thread.Sleep(500);

            ServicesBase servicesBase = new ServicesBase();
            servicesBase.ControlService();
            servicesBase.ContentService();
            servicesBase.PrinterMonitor();
            servicesBase.StorageMaintenance();
            servicesBase.ServiceHost();            
            servicesBase.CloudPrintLicenseService();
            servicesBase.LicenseService();
            servicesBase.AccountManagement();            
                      
                      
        }

        public void ldapConfigSettings()
        {
            lnkConfigSetting.Clicks(); Thread.Sleep(5000);
            lnkVerifyCon.Clicks(); Thread.Sleep(5000);
        }

        public void allRadioButton()
        {
            string radioXPath = "//input[contains(@type, 'radio')]";
            var allRadiobox = PropertiesCollection.driver.FindElements(By.XPath(radioXPath));
            foreach (IWebElement radiobox in allRadiobox)
            {
                try
                {
                    ((IJavaScriptExecutor)PropertiesCollection.driver).ExecuteScript(
                            "arguments[0].scrollIntoView(true);", radiobox);                    
                    if (!radiobox.Selected)
                    {
                        radiobox.Click();
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
