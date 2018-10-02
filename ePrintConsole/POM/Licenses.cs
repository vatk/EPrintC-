using ePrintConsole.PropColleactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ePrintConsole.POM
{
    class Licenses
    {
        public Licenses()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "View and Manage Licenses")]
        public IWebElement lnkVMLic { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_LicenseForm_ctrlFeatureAdd_ctrlfileUpload")]
        public IWebElement btnBrowse { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_LicenseForm_ctrlFeatureAdd_btnAddFeature")]
        public IWebElement btnAddLic { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_LicenseForm_ImageDetail")]
        public IWebElement allLic { get; set; }

        public void lic()
        {
            Process p = new Process();
            lnkVMLic.Clicks(); Thread.Sleep(1000);
            btnBrowse.SendKeys("C:\\Data\\testpermenent.lic"); Thread.Sleep(2000);//Update the File Name here
            btnAddLic.Clicks(); Thread.Sleep(1000);

            ServicesBase servicesBase = new ServicesBase();
            servicesBase.CloudPrintLicenseService();

            //try
            //{
            //    string targetDir;
            //    targetDir = string.Format(@"C:\Users\administrator.EE\Desktop\Final\ePrintConsole\ePrintConsole\services");//batch script file path

            //    p.StartInfo.UseShellExecute = true;
            //    p.StartInfo.WorkingDirectory = targetDir;
            //    p.StartInfo.FileName = "HPCloudPrintLicenseService_Disable.bat"; Thread.Sleep(5000);                
            //    p.StartInfo.CreateNoWindow = false;
            //    p.Start();
            //    p.WaitForExit();

            //    p.StartInfo.UseShellExecute = true;
            //    p.StartInfo.WorkingDirectory = targetDir;
            //    p.StartInfo.FileName = "HPCloudPrintLicenseService_Auto.bat";
            //    p.StartInfo.CreateNoWindow = false;
            //    p.Start();
            //    p.WaitForExit();


            //    Thread.Sleep(5000);
            //}
            //catch(Exception e){}            
            for(int view=0; view <= 5; view++)
            {
                lnkVMLic.Clicks(); Thread.Sleep(5000);
                allLic.Clicks(); Thread.Sleep(5000);
            }            
            
        }
    }
}
