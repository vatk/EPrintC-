using ePrintConsole.PropColleactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    class AddNewRegularUser
    {
        string xmlPath = @"C:\Users\administrator.EE\Desktop\Final\ePrintConsole\ePrintConsole\ePintValues.xml";
        public AddNewRegularUser()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        
        [FindsBy(How = How.LinkText, Using = "View and Manage Users")]
        public IWebElement lnkVMUsers { get; set; }             

        [FindsBy(How = How.LinkText, Using = "Provision Settings")]
        public IWebElement lnkPSettings { get; set; }


        //Regular and Guest
        [FindsBy(How = How.LinkText, Using = "Add New User")]
        public IWebElement lnkAnUsers { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_BESEmailAccountTextBox")]
        public IWebElement txtREmail { get; set; }        

        [FindsBy(How = How.XPath, Using = "//option[@value='2']")]
        public IWebElement ddlrGroup { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='3']")]
        public IWebElement ddlgGroup { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='4']")]
        public IWebElement ddlwifiGroup { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_PINTextBox")]
        public IWebElement txtRPin { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_InsertButton")]
        public IWebElement btnRInsert { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_AutoSuspendCheckBox")]
        public IWebElement chkSuspend { get; set; }

        //Import User
        [FindsBy(How = How.LinkText, Using = "Import Users")]
        public IWebElement lnkIUsers { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UsersImportMessagePanel_ctl00_UserImportFile")]
        public IWebElement btnimportUser { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UsersImportMessagePanel_ctl00_UserImportButton")]
        public IWebElement btnimportUserProcess { get; set; }
      
        //LDAP
        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_BESEmailAccountTextBox")]
        public IWebElement txtLDAPEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='1']")]
        public IWebElement ddlaGroup { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_PINTextBox")]
        public IWebElement txtLDAPPin { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_PasswordTextBox")]
        public IWebElement txtLDAPPassword { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_ConfirmPasswordTextBox")]
        public IWebElement txtLDAPcPassword { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_PasswordTipTextBox")]
        public IWebElement txtLDAPTips { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_InsertButton")]
        public IWebElement btnLDAPInsert { get; set; }

        //Delete User
        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserListPanel_ctl00_UserList_UserListGrid")]
        public IWebElement grddeleteUser { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_EditButton")]
        public IWebElement btnDeleteUser { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_UpdateButton")]
        public IWebElement btnUpdateUser { get; set; }

        [FindsBy(How = How.Id, Using = "ImageButton2")]
        public IWebElement btnCalender2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_CalendarExtender2_today']")]
        public IWebElement todaydate { get; set; }

        [FindsBy(How = How.Id, Using = "ImageButton1")]
        public IWebElement btnCalender1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_CalendarExtender1_today']")]
        
        public IWebElement nextDay { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ctl00_BodyContentPlaceHolder_UserListPanel_ctl00_UserList_UserListGrid_ctl04_ImageButton")]
        public IWebElement permantDeleteUser { get; set; }


        public void regularUserAdd()
        {
            XDocument testXML = XDocument.Load(xmlPath);
            try
            {
                var regularUser = from print in testXML.Descendants("Regular")
                               select new
                               {
                                   email = print.Element("emailAccount").Value,
                                   pin = print.Element("pin").Value
                               };
                foreach (var rUser in regularUser)
                {
                    lnkVMUsers.Clicks(); Thread.Sleep(500);
                    lnkAnUsers.Clicks(); Thread.Sleep(500);
                    txtREmail.EnterText(rUser.email); Thread.Sleep(500);
                    ddlrGroup.Clicks(); Thread.Sleep(500);
                    txtRPin.EnterText(rUser.pin); Thread.Sleep(500);
                    btnRInsert.Clicks(); Thread.Sleep(500);
                    lnkVMUsers.Clicks(); Thread.Sleep(500);
                }
            }
            catch (Exception err)
            {
            }           
        }

        public void guestUserAdd()
        {
            XDocument testXML = XDocument.Load(xmlPath);
            try
            {
                var guestUser = from print in testXML.Descendants("Guest")
                                  select new
                                  {
                                      email = print.Element("emailAccount").Value,
                                      pin = print.Element("pin").Value
                                  };
                foreach (var gUser in guestUser)
                {
                    lnkAnUsers.Clicks(); Thread.Sleep(500);
                    txtREmail.EnterText(gUser.email); Thread.Sleep(500);
                    ddlgGroup.Clicks(); Thread.Sleep(500);
                    txtRPin.EnterText(gUser.pin); Thread.Sleep(500);
                    btnRInsert.Clicks(); Thread.Sleep(500);
                    lnkVMUsers.Clicks(); Thread.Sleep(500);
                }
            }
            catch (Exception err)
            {
            }            
        }

        public void adminUserAdd()
        {
            XDocument testXML = XDocument.Load(xmlPath);
            try
            {
                var adminUser = from print in testXML.Descendants("Admin")
                                select new
                                {
                                    email = print.Element("EmailAccount").Value,
                                    pin = print.Element("Pin").Value,
                                    password = print.Element("Password").Value,
                                    cPassword = print.Element("ConfirmPassword").Value,
                                    pTips = print.Element("PassworTips").Value
                                };
                foreach (var aUser in adminUser)
                {
                    lnkAnUsers.Clicks(); Thread.Sleep(500);
                    txtLDAPEmail.EnterText(aUser.email); Thread.Sleep(500);
                    ddlaGroup.Clicks(); Thread.Sleep(500);
                    txtLDAPPin.EnterText(aUser.pin); Thread.Sleep(500);
                    txtLDAPPassword.EnterText(aUser.password); Thread.Sleep(500);
                    txtLDAPcPassword.EnterText(aUser.cPassword); Thread.Sleep(500);
                    txtLDAPTips.EnterText(aUser.pTips); Thread.Sleep(500);
                    CheckBoxSelection(); Thread.Sleep(500);
                    btnLDAPInsert.Clicks(); Thread.Sleep(500);
                    lnkAnUsers.Clicks(); Thread.Sleep(2000);
                }
            }
            catch (Exception err)
            {
            }            
        }

        public void wifiUserAdd()
        {
            XDocument testXML = XDocument.Load(xmlPath);
            try
            {
                var wifiUser = from print in testXML.Descendants("Wifi")
                                select new
                                {
                                    email = print.Element("emailAccount").Value,
                                    pin = print.Element("pin").Value
                                };
                foreach (var wUser in wifiUser)
                {
                    lnkVMUsers.Clicks(); Thread.Sleep(500);
                    lnkAnUsers.Clicks(); Thread.Sleep(500);
                    txtREmail.EnterText(wUser.email); Thread.Sleep(500);
                    ddlwifiGroup.Clicks(); Thread.Sleep(500);
                    txtRPin.EnterText(wUser.pin); Thread.Sleep(500);
                    chkSuspend.Click();
                    btnRInsert.Clicks(); Thread.Sleep(500);
                    lnkVMUsers.Clicks(); Thread.Sleep(500);
                }
            }
            catch (Exception err)
            {
            }            
        }
        
        public void importUsers()
        {
            lnkIUsers.Clicks(); Thread.Sleep(500);            
            btnimportUser.SendKeys("C:\\Data\\EE-5_Users.csv"); Thread.Sleep(2000);
            btnimportUserProcess.Clicks(); Thread.Sleep(5000);
            for(int i =0; i<=10;i++)
            {
                lnkVMUsers.Clicks(); Thread.Sleep(5000);
            }            
        }        

        public void detleteUser()
        {
            lnkVMUsers.Clicks(); Thread.Sleep(500);
            grddeleteUser.Clicks(); Thread.Sleep(500);

            string dGuest = "//td[contains(text(),'Guest')]";
            var allGuest = PropertiesCollection.driver.FindElements(By.XPath(dGuest));
            foreach (IWebElement deleteGuest in allGuest)
            {
                try
                {
                    ((IJavaScriptExecutor)PropertiesCollection.driver).ExecuteScript(
                            "arguments[0].scrollIntoView(true);", deleteGuest);
                    if (!deleteGuest.Selected)
                    {
                        deleteGuest.Click(); Thread.Sleep(500);
                        btnDeleteUser.Clicks(); Thread.Sleep(500);
                        btnCalender2.Clicks(); Thread.Sleep(500);
                        todaydate.Clicks(); Thread.Sleep(2000);
                        btnCalender1.Clicks(); Thread.Sleep(500);
                        nextDay.Clicks(); Thread.Sleep(2000);
                        CheckBoxSelection(); Thread.Sleep(500);
                        btnUpdateUser.Clicks(); Thread.Sleep(1000);                        
                        deleteUser();
                        PropertiesCollection.driver.SwitchTo().Alert().Accept(); Thread.Sleep(1000);
                        Thread.Sleep(3000);
                    }
                }
                catch
                {
                }
            }
        }

        public void proSettings()
        {
            lnkPSettings.Clicks(); Thread.Sleep(3000);
        }
        
        public void CheckBoxSelection()
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

        public void deleteUser()
        {
            string delImageXPath = "//input[contains(@type, 'image')]";
            var delete = PropertiesCollection.driver.FindElements(By.XPath(delImageXPath));
            foreach (IWebElement gDelete in delete)
            {
                try
                {
                    ((IJavaScriptExecutor)PropertiesCollection.driver).ExecuteScript(
                            "arguments[0].scrollIntoView(true);", gDelete);                    
                    if (!gDelete.Selected)
                    {
                        gDelete.Click();
                        Thread.Sleep(100);
                    }
                    else
                    {
                        gDelete.Click();
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
