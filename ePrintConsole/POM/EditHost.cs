using ePrintConsole.PropColleactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ePrintConsole.POM
{
    class EditHost
    {
        string xmlPath = @"C:\Users\administrator.EE\Desktop\Final\ePrintConsole\ePrintConsole\ePintValues.xml";
        public EditHost()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "View and Manage Hosts")]
        public IWebElement lnkVMHost { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'auto.ee.in')]")]
        public IWebElement eHost { get; set; }

        [FindsBy(How = How.LinkText, Using = "Add New Host")]
        public IWebElement lnkANHost { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormPanel_ctl00_HostForm_HostFormView_VersionTextBox")]
        public IWebElement txtVersion { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormPanel_ctl00_HostForm_HostFormView_UpdateButton")]
        public IWebElement btnUpdate { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormMessagePanel_ctl00_HostFormControl_HostFormView_NameTextBox")]
        public IWebElement txtHostName { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormMessagePanel_ctl00_HostFormControl_HostFormView_PortTextBox")]
        public IWebElement txtPortNumber { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormMessagePanel_ctl00_HostFormControl_HostFormView_SmtpAccountTextBox")]
        public IWebElement txtSMTP { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormMessagePanel_ctl00_HostFormControl_HostFormView_VersionTextBox")]
        public IWebElement txtAddNewVersion{ get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormMessagePanel_ctl00_HostFormControl_HostFormView_NotesTextBox")]
        public IWebElement txtNotes { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormMessagePanel_ctl00_HostFormControl_HostFormView_InsertButton")]
        public IWebElement btnInsert { get; set; }        

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormPanel_ctl00_HostForm_HostFormView_EditButton")]
        public IWebElement btnEdit { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_HostFormPanel_ctl00_HostForm_HostFormView_VersionTextBox")]
        public IWebElement txtClear { get; set; }

        public void UpdateHost()
        {
            XDocument testXML = XDocument.Load(xmlPath);            
                try
                {
                    var printers = from print in testXML.Descendants("EditHost")
                                   select new
                                   {
                                       version = print.Element("Version").Value                                       
                                   };
                    foreach (var v in printers)
                    {
                        lnkVMHost.Clicks(); Thread.Sleep(500);
                        eHost.Clicks(); Thread.Sleep(500);
                        btnEdit.Clicks(); Thread.Sleep(500);
                        txtClear.Clear(); Thread.Sleep(500);
                        txtVersion.EnterText(v.version); Thread.Sleep(500);
                        btnUpdate.Clicks(); Thread.Sleep(2000);
                        lnkANHost.Clicks(); Thread.Sleep(2000);
                    }
                }
                catch (Exception err)
                {
                }               
        }

        public void AddHost()
        {
            XDocument testXML = XDocument.Load(xmlPath);
            try
            {
                var printers = from print in testXML.Descendants("EditHost")
                               select new
                               {
                                   hostName = print.Element("HostName").Value,
                                   portNumber = print.Element("PortNumber").Value,
                                   smtp = print.Element("Smtp").Value,
                                   version = print.Element("Version").Value,
                                   notes = print.Element("Notes").Value
                               };
                foreach (var newHost in printers)
                {
                    lnkANHost.Clicks();
                    txtHostName.EnterText(newHost.hostName); Thread.Sleep(500);
                    txtPortNumber.EnterText(newHost.portNumber); Thread.Sleep(500);
                    txtSMTP.EnterText(newHost.smtp); Thread.Sleep(500);
                    txtAddNewVersion.EnterText(newHost.version); Thread.Sleep(500);
                    txtNotes.EnterText(newHost.notes); Thread.Sleep(500);
                    btnInsert.Clicks();
                    lnkVMHost.Clicks();
                }
            }
            catch (Exception err)
            {
            }




            
            
            
        }
    }
}
