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
    class ServicesAndData
    {
        public ServicesAndData()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Service Settings")]
        public IWebElement lnkSSettings { get; set; }

        [FindsBy(How = How.LinkText, Using = "Submission Test")]
        public IWebElement lnkSubmission { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='C:\\inetpub\\wwwroot\\CloudPrintAdmin\\services\\attachments\\HP ePrint Enterprise two pages.docx']")]
        public IWebElement docFile { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='C:\\inetpub\\wwwroot\\CloudPrintAdmin\\services\\attachments\\HP ePrint Enterprise.doc']")]
        public IWebElement docxFile { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='C:\\inetpub\\wwwroot\\CloudPrintAdmin\\services\\attachments\\HP ePrint Enterprise.pdf']")]
        public IWebElement pdfFile { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[@value='C:\\inetpub\\wwwroot\\CloudPrintAdmin\\services\\attachments\\HP ePrint Enterprise.pptx']")]
        public IWebElement pptFile { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyContentPlaceHolder_JobSubmitPanel_ctl00_SubmitButton")]
        public IWebElement btnSubmit { get; set; }

        public void submissionTest()
        {
            Overview oPage = new Overview();            
            lnkSSettings.Clicks(); Thread.Sleep(1000);
            lnkSubmission.Clicks(); Thread.Sleep(500);

            //DOCX
            docFile.Clicks(); Thread.Sleep(500);
            btnSubmit.Clicks(); Thread.Sleep(1000);
            oPage.lnkOScreen.Clicks(); Thread.Sleep(2000);

            //DOC
            lnkSubmission.Clicks(); Thread.Sleep(500);
            docxFile.Clicks(); Thread.Sleep(500);
            btnSubmit.Clicks(); Thread.Sleep(1000);
            oPage.lnkOScreen.Clicks(); Thread.Sleep(2000);

            //PDF
            lnkSubmission.Clicks(); Thread.Sleep(500);
            pdfFile.Clicks(); Thread.Sleep(500);
            btnSubmit.Clicks(); Thread.Sleep(1000);
            oPage.lnkOScreen.Clicks(); Thread.Sleep(2000);

            //PPT
            lnkSubmission.Clicks(); Thread.Sleep(500);
            pptFile.Clicks(); Thread.Sleep(500);
            btnSubmit.Clicks(); Thread.Sleep(1000);
            oPage.lnkOScreen.Clicks(); Thread.Sleep(10000);

            for(int i= 0; i <= 20;i++)
            { 
                oPage.btnbeingprocessed.Click(); Thread.Sleep(2000);
            }
        }
    }
}
