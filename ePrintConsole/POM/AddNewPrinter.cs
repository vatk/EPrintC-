using ePrintConsole.PropColleactions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ePrintConsole.POM
{
    
    public class AddNewPrinter
    {
       
        public AddNewPrinter()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        string xmlPath = @"C:\Users\administrator.EE\Desktop\Final\ePrintConsole\ePrintConsole\ePintValues.xml";

        [FindsBy(How = How.LinkText, Using = "View and Manage Printers")]
        public IWebElement lnkVMPrinter { get; set; }

        [FindsBy(How = How.LinkText, Using = "Add New Printer")]
        public IWebElement lnkNewPrinter { get; set; }

        [FindsBy(How = How.LinkText, Using = "Import Printers")]
        public IWebElement lnkImportPrinter { get; set; }

        [FindsBy(How = How.LinkText, Using = "Export Printers")]
        public IWebElement lnkExportPrinter { get; set; }

        [FindsBy(How = How.LinkText, Using = "Manage Printer Properties")]
        public IWebElement lnkMppPrinter { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_NameTextBox")]
        public IWebElement txtPrinterName { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_ModelNameTextBox")]
        public IWebElement txtModleName { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_NetworkAddressTextBox")]
        public IWebElement txtNetworkAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'PCL5 / PCL6')]")]
        public IWebElement ddlPersonality { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_LatitudeTextBox")]        
        public IWebElement txtLatitude { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_LongitudeTextBox")]
        public IWebElement txtLongitude { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_Locations_LocationDataList_ctl00_LocationText")]
        public IWebElement txtDescription { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_Locations_LocationDataList_ctl01_LocationText")]
        public IWebElement txtRoom { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_Locations_LocationDataList_ctl02_LocationText")]
        public IWebElement txtFloor { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_Locations_LocationDataList_ctl03_LocationText")]
        public IWebElement txtBuilding { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_Locations_LocationDataList_ctl04_LocationText")]
        public IWebElement txtAddress { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_Locations_LocationDataList_ctl05_LocationText")]
        public IWebElement txtCity { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_Locations_LocationDataList_ctl06_LocationText")]
        public IWebElement txtState { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_Locations_LocationDataList_ctl07_LocationText")]
        public IWebElement txtCountry { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterFormMessagePanel_ctl00_PrinterFormControl_PrinterFormView_InsertButton")]
        public IWebElement btnInsert { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterExportMessagePanel_ctl00_cbMailSend")]
        public IWebElement chkReceive { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterExportMessagePanel_ctl00_ExportButton")]
        public IWebElement btnExportDownload { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$BodyContentPlaceHolder$PrinterExportMessagePanel$ctl00$FieldSelectorControl$ctl00")]
        public IWebElement btnMove { get; set; }


        //import printer
        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterImportMessagePanel_ctl00_ImportFile")]
        public IWebElement btnBrowserPrinter { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterImportMessagePanel_ctl00_ImportButton")]
        public IWebElement btnPrinterProcessed { get; set; }

        //Delete Printers
        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterListMessagePanel_ctl00_PrinterListControl_PrinterListGrid_ctl01_SelectAll")]
        public IWebElement chkPrinterDelete { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_PrinterListMessagePanel_ctl00_PrinterListControl_Button1")]
        public IWebElement btnPrinterDelete { get; set; }

        //Printer Properties
        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_CapabilitiesPanel_ctl00_CapabilityTextBox")]
        public IWebElement txtColor { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_CapabilitiesPanel_ctl00_ChangeCapabilityButton")]
        public IWebElement btnChange { get; set; }

        public void FillNewPrinter(string elements)
        {            
            XDocument testXML = XDocument.Load(xmlPath);

            if (elements == "1")
            {
                try
                {                    
                    var printers = from print in testXML.Descendants("NewPrinter")
                                   select new
                                   {                                       
                                       PrinterName = print.Element("PrinterName").Value,
                                       ModelName = print.Element("ModelName").Value,
                                       PrinterAddress = print.Element("PrinterAddress").Value,
                                       Latitude = print.Element("Latitude").Value,
                                       Longitude = print.Element("Longitude").Value,
                                       Description = print.Element("Description").Value,
                                       Room = print.Element("Room").Value,
                                       Floor = print.Element("Floor").Value,
                                       Building = print.Element("Building").Value,
                                       Address = print.Element("Address").Value,
                                       City = print.Element("City").Value,
                                       State = print.Element("State").Value,
                                       Country = print.Element("Country").Value
                                   };
                    foreach (var print in printers)
                    {
                        lnkVMPrinter.Clicks(); Thread.Sleep(500);
                        lnkNewPrinter.Clicks(); Thread.Sleep(500);
                        txtPrinterName.EnterText(print.PrinterName); Thread.Sleep(500);
                        txtModleName.EnterText(print.ModelName); Thread.Sleep(500);
                        txtNetworkAddress.EnterText(print.PrinterAddress); Thread.Sleep(500);
                        ddlPersonality.Clicks(); Thread.Sleep(500);
                        PrinterCheckBoxSelection(); Thread.Sleep(500);
                        txtLatitude.EnterText(print.Latitude); Thread.Sleep(500);
                        txtLongitude.EnterText(print.Longitude); Thread.Sleep(500);
                        txtDescription.EnterText(print.Description); Thread.Sleep(500);
                        txtRoom.EnterText(print.Room); Thread.Sleep(500);
                        txtFloor.EnterText(print.Floor); Thread.Sleep(500);
                        txtBuilding.EnterText(print.Building); Thread.Sleep(500);
                        txtAddress.EnterText(print.Address); Thread.Sleep(500);
                        txtCity.EnterText(print.City); Thread.Sleep(500);
                        txtState.EnterText(print.State); Thread.Sleep(500);
                        txtCountry.EnterText(print.Country); Thread.Sleep(500);
                        btnInsert.Clicks(); Thread.Sleep(2000);
                        ping(); Thread.Sleep(2000);
                    }
                }
                catch (Exception err)
                {                    
                }                
            }
            else
            {
                try
                {
                    var students = from print in testXML.Descendants("AfterDelete")
                                   select new
                                   {
                                       PrinterName = print.Element("PrinterName").Value,
                                       ModelName = print.Element("ModelName").Value,
                                       PrinterAddress = print.Element("PrinterAddress").Value,
                                       Latitude = print.Element("Latitude").Value,
                                       Longitude = print.Element("Longitude").Value,
                                       Description = print.Element("Description").Value,
                                       Room = print.Element("Room").Value,
                                       Floor = print.Element("Floor").Value,
                                       Building = print.Element("Building").Value,
                                       Address = print.Element("Address").Value,
                                       City = print.Element("City").Value,
                                       State = print.Element("State").Value,
                                       Country = print.Element("Country").Value
                                   };
                    foreach (var print in students)
                    {
                        lnkVMPrinter.Clicks(); Thread.Sleep(500);
                        lnkNewPrinter.Clicks(); Thread.Sleep(500);
                        txtPrinterName.EnterText(print.PrinterName); Thread.Sleep(500);
                        txtModleName.EnterText(print.ModelName); Thread.Sleep(500);
                        txtNetworkAddress.EnterText(print.PrinterAddress); Thread.Sleep(500);
                        ddlPersonality.Clicks(); Thread.Sleep(500);
                        PrinterCheckBoxSelection(); Thread.Sleep(500);
                        txtLatitude.EnterText(print.Latitude); Thread.Sleep(500);
                        txtLongitude.EnterText(print.Longitude); Thread.Sleep(500);
                        txtDescription.EnterText(print.Description); Thread.Sleep(500);
                        txtRoom.EnterText(print.Room); Thread.Sleep(500);
                        txtFloor.EnterText(print.Floor); Thread.Sleep(500);
                        txtBuilding.EnterText(print.Building); Thread.Sleep(500);
                        txtAddress.EnterText(print.Address); Thread.Sleep(500);
                        txtCity.EnterText(print.City); Thread.Sleep(500);
                        txtState.EnterText(print.State); Thread.Sleep(500);
                        txtCountry.EnterText(print.Country); Thread.Sleep(500);
                        btnInsert.Clicks(); Thread.Sleep(2000);
                        ping(); Thread.Sleep(2000);
                    }
                }
                catch (Exception err)
                {
                }
            }            
        }
                
        public void importPrinter()
        {
            lnkImportPrinter.Clicks();
            btnBrowserPrinter.SendKeys("C:\\Data\\EE-5_printers.csv");Thread.Sleep(2000);
            btnPrinterProcessed.Clicks(); Thread.Sleep(1000);
            ping(); Thread.Sleep(2000);
            lnkVMPrinter.Clicks(); Thread.Sleep(2000);
        }

        public void exportPrinter()
        {            
            lnkExportPrinter.Clicks(); Thread.Sleep(2000);
            IWebElement eProp = PropertiesCollection.driver.FindElement(By.XPath("//select[@id='ctl00_BodyContentPlaceHolder_PrinterExportMessagePanel_ctl00_FieldSelectorControl_availableFields']"));
            SelectElement printerPropSelect = new SelectElement(eProp); Thread.Sleep(500);
            printerPropSelect.SelectByText("HP ePrint Host"); Thread.Sleep(500);
            btnMove.Clicks(); Thread.Sleep(500);
            chkReceive.Clicks();
            btnExportDownload.Clicks();Thread.Sleep(2000);
        }

        public void deletePrinters()
        {
            chkPrinterDelete.Clicks(); Thread.Sleep(1000);
            btnPrinterDelete.Clicks(); Thread.Sleep(1000);
            PropertiesCollection.driver.SwitchTo().Alert().Accept(); Thread.Sleep(1000);
        }

        public void printerProp()
        {            
            lnkMppPrinter.Clicks();
            IWebElement pProp = PropertiesCollection.driver.FindElement(By.Id("ctl00_BodyContentPlaceHolder_CapabilitiesPanel_ctl00_CapabilityListBox"));
            SelectElement propSelect = new SelectElement(pProp); Thread.Sleep(500);
            propSelect.SelectByIndex(1); Thread.Sleep(500);
            txtColor.Clear(); Thread.Sleep(500);
            txtColor.EnterText("Color1"); Thread.Sleep(500);
            btnChange.Clicks(); Thread.Sleep(1000);
            PropertiesCollection.driver.SwitchTo().Alert().Accept(); Thread.Sleep(1000);

        }

        public void PrinterCheckBoxSelection()
        {
            string checkboxXPath = "//input[contains(@type, 'checkbox')]";
            var allCheckboxes = PropertiesCollection.driver.FindElements(By.XPath(checkboxXPath));
            foreach (IWebElement checkbox in allCheckboxes)
            {
                try
                {
                    ((IJavaScriptExecutor)PropertiesCollection.driver).ExecuteScript(
                            "arguments[0].scrollIntoView(true);", checkbox);                    
                    if (!checkbox.Selected)
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

        public void ping()
        {
            string checkboxXPath = "//input[contains(@value, 'Ping')]";
            var allCheckboxes = PropertiesCollection.driver.FindElements(By.XPath(checkboxXPath));
            foreach (IWebElement checkbox in allCheckboxes)
            {
                try
                {
                    ((IJavaScriptExecutor)PropertiesCollection.driver).ExecuteScript(
                            "arguments[0].scrollIntoView(true);", checkbox);
                    if (!checkbox.Selected)
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
            Thread.Sleep(3000);
        }



    }
}
