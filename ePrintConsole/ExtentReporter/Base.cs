using System;
using System.Net;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using ePrintConsole.PropColleactions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Collections.Generic;

namespace ePrintConsole.ExtentReporter
{
    [SetUpFixture]
    public abstract class Base
    {
        protected ExtentReports _extent;
        protected ExtentTest _Test;
        protected ExtentTest _Parent;
        protected ExtentTest _Child;

        [OneTimeSetUp]
        protected void Setup()
        {
            var dir = TestContext.CurrentContext.TestDirectory + "\\";
            var fileName = this.GetType().ToString() + ".html";
            var htmlReporter = new ExtentHtmlReporter(dir + fileName);
            string hostname = Dns.GetHostName();
            OperatingSystem os = Environment.OSVersion;
            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);

        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            _extent.Flush();
        }

        public static IEnumerable<string> BrowserToRunWith()
        {
            string[] browsers = AutomationSettings.browserToRunWith.Split(',');
            foreach (string b in browsers)
            {
                yield return b;
            }
        }

        public void BeforeTest(string browserName)
        {
            _Parent = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
            if (browserName.Equals("ie"))
            {                
                PropertiesCollection.driver = new InternetExplorerDriver();
                PropertiesCollection.driver.Navigate().GoToUrl("https://localhost/cloudprintadmin/Login.aspx?ReturnUrl=%2fcloudprintadmin%2fprinters%2fInsert.aspx");
                PropertiesCollection.driver.Navigate().GoToUrl("javascript: document.getElementById('overridelink').click()");
                PropertiesCollection.driver.Manage().Window.Maximize();
            }
            else if (browserName.Equals("firefox"))
            {
                var ffOptions = new FirefoxOptions
                {
                    AcceptInsecureCertificates = true
                };
                
                ffOptions.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                //PropertiesCollection.driver = new FirefoxDriver(ffOptions);
                FirefoxProfile profile = new FirefoxProfile();
                profile.AcceptUntrustedCertificates = true;
                profile.AssumeUntrustedCertificateIssuer = false;
                ffOptions.Profile = profile;
                PropertiesCollection.driver = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(), ffOptions, TimeSpan.FromSeconds(20));
                PropertiesCollection.driver.Navigate().GoToUrl("https://localhost/cloudprintadmin/Login.aspx?ReturnUrl=%2fcloudprintadmin%2fprinters%2fInsert.aspx");                
                PropertiesCollection.driver.Manage().Window.Maximize();
            }
            else
            {
               
                PropertiesCollection.driver = new ChromeDriver();
                PropertiesCollection.driver.Navigate().GoToUrl("https://localhost/cloudprintadmin/Login.aspx?ReturnUrl=%2fcloudprintadmin%2fprinters%2fInsert.aspx");                
                PropertiesCollection.driver.Manage().Window.Maximize();
            }            
        }     


        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                    ? ""
                    : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            _Parent.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            _extent.Flush();
            PropertiesCollection.driver.Quit();
        }
    }
}
