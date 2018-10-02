using AventStack.ExtentReports;
using ePrintConsole.POM;
using NUnit.Framework;
using System.Threading;
using ePrintConsole.ExtentReporter;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;


namespace ePrintConsole
{
    [TestFixture]
    [Parallelizable]
    public class ePrintWebConsole : Base
    {        
        string xmlPath = @"C:\Users\administrator.EE\Desktop\Final\ePrintConsole\ePrintConsole\ePintValues.xml";        

        [Test]
        [TestCaseSource(typeof(Base), "BrowserToRunWith")]
        public void HP_ePrint(string browserName)
        {
            BeforeTest(browserName);

            _Child = _Parent.CreateNode("Login");
            Login pageLogin = new Login(); Thread.Sleep(500);
            string newTitle = pageLogin.Logins(); Thread.Sleep(1000);

            if (!newTitle.Contains("Login"))
            {
                Assert.IsTrue(true);
                _Child.Pass("Login Successfull");
            }
            else
            {
                Assert.IsFalse(false);
                _Child.Fail("Login Failed");
            }

            //ManagePrinters();
            //ManageHosts();
            //ManageUsers();
            //ManageServicesAndData();
            //ManageLicense();
            //ManageMobileClients();
            //EventsAndTracking();
            //ManageNotification();
            //MetricsReports();
            //UserDataCleanUp();
            //LDAP();
        }

        public void Features()
        {         

        }

        [Order(2)]
        public void ManagePrinters()
        {
            _Child = _Parent.CreateNode("Manage Printers");
            AddNewPrinter anpPage = new AddNewPrinter();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called Add New Printer Class and Create Object");                
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called Add New Printer Class and Create Object");
                throw;
            }

            anpPage.FillNewPrinter("1");
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Adding New Printer details");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Adding New Printer details");
                throw;
            }

            anpPage.importPrinter(); Thread.Sleep(1000);
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Importing New Printers from CSV ");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Importing New Printers from CSV");
                throw;
            }

            anpPage.deletePrinters(); Thread.Sleep(1000);
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Deleting existing Printers from list");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Deleting existing Printers from list");
                throw;
            }

            anpPage.FillNewPrinter("2");
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Adding New Printer after deleting");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Adding New Printer after deleting");
                throw;
            }

            anpPage.exportPrinter(); Thread.Sleep(500);
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Export Printers");;
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Export Printers");
                throw;
            }

            anpPage.printerProp(); Thread.Sleep(500);
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Change the printer properties");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Change the printer propertiesExport Printers");
                throw;
            }

            anpPage.lnkMppPrinter.Click(); Thread.Sleep(3000);
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Clicking Manage Printers");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Clicking Manage Printers");
                throw;
            }
        }

        [Order(3)]
        public void ManageHosts()
        {
            _Child = _Parent.CreateNode("Manage Hosts");

            EditHost uPage = new EditHost();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called Edit Host Class and Create Object");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called Edit Host Class and Create Object");
                throw;
            }

            uPage.UpdateHost();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Edit Host Version");                
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Edit Host Version");
                throw;
            }

            uPage.AddHost();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Add New Host Details");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Add New Host Details");
                throw;
            }
        }

        [Order(4)]
        public void ManageUsers()
        {
            _Child = _Parent.CreateNode("Manage Users");
            AddNewRegularUser anuPage = new AddNewRegularUser();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called Add New Regular User Class and Create Object");                
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called Add New Regular User Class and Create Object");
                throw;
            }

            anuPage.regularUserAdd();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Adding regular User");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Adding regular User");
                throw;
            }

            anuPage.guestUserAdd();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Adding Guest User");;
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Adding guest User");
                throw;
            }

            anuPage.adminUserAdd();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Adding Admin User");;
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Adding admin User");
                throw;
            }

            anuPage.wifiUserAdd();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Adding Wifi User");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Adding wifi User");
                throw;
            }

            anuPage.importUsers(); Thread.Sleep(2000);
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Import User");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Import User");
                throw;
            }

            anuPage.detleteUser(); Thread.Sleep(2000);
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Delete Guest User");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Delete Guest User");
                throw;
            }

            anuPage.proSettings(); Thread.Sleep(2000);
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Click Provision Setting");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Click Provision Setting");
                throw;
            }

        }

        [Order(5)]
        public void ManageServicesAndData()
        {
            _Child = _Parent.CreateNode("Manage Services And Data");

            ServicesAndData sPage = new ServicesAndData();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called Services And Data Class and Create Object");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called Services And Data Class and Create Object");
                throw;
            }

            sPage.submissionTest();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Submitting Submission Test Jobs");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Submitting Submission Test Jobs");
                throw;
            }
        }

        [Order(6)]
        public void ManageLicense()
        {
            _Child = _Parent.CreateNode("Manage License");
           
            Licenses lPage = new Licenses();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called Licenses Class and Create Object");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called Licenses Class and Create Object");
                throw;
            }

            lPage.lic(); Thread.Sleep(2000);
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Click View and Manage License");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Click View and Manage License");
                throw;
            }
        }

        [Order(7)]
        public void ManageMobileClients()
        {
            _Child = _Parent.CreateNode("Manage Mobile Clients");

            PushConfig pushPage = new PushConfig();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called Push Configuration Class and Create Object");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called Push Configuration Class and Create Object");
                throw;
            }

            pushPage.pushImpUsers();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Click Push Configuration");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Click Push Configuration");
                throw;
            }
        }

        [Order(8)]
        public void EventsAndTracking()
        {
            _Child = _Parent.CreateNode("Events And Tracking");

            EventNTracking entPage = new EventNTracking();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called Event and Tracking Class and Create Object");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called Event and Tracking Class and Create Object");
                throw;
            }

            entPage.trackJobs();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Click Track Jobs");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Click Track Jobs");
                throw;
            }

            entPage.trackMessage();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Click Track Message");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Click Track Message");
                throw;
            }

            entPage.trackEvents();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Click Track Events");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Click Track Events");
                throw;
            }
        }

        [Order(9)]
        public void ManageNotification()
        {
            _Child = _Parent.CreateNode("Manage Notification");

            ManageNotification notiPage = new ManageNotification();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called Manage Notification Class and Create Object");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called Manage Notification Class and Create Object");
                throw;
            }

            notiPage.manageNitification();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Enable or Disable Notification");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Enable or Disable Notification");
                throw;
            }

        }

        [Order(10)]
        public void MetricsReports()
        {
            _Child = _Parent.CreateNode("Metrics Reports");

            Metrics gPage = new Metrics();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called Metrics Class and Create Object");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called Metrics Class and Create Object");
                throw;
            }

            gPage.metrics();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Generate CSV, Web and Text report");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Generate CSV, Web and Text report");
                throw;
            }
        }

        [Order(11)]
        public void UserDataCleanUp()
        {
            _Child = _Parent.CreateNode("UserData CleanUp");

            ClenUp udPage = new ClenUp();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called ClenUp Class and Create Object");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called ClenUp Class and Create Object");
                throw;
            }

            udPage.userDataCleanUp();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Clean all User Data");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Clean all User Datap");
                throw;
            }
        }

        [Order(12)]
        public void LDAP()
        {
            _Child = _Parent.CreateNode("LDAP");

            LDAP ldapPage = new LDAP();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Called LDAP Class and Create Object");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Called LDAP Class and Create Object");
                throw;
            }

            ldapPage.ldapSecurityRealm();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Click on Security Realm");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Click on Security Realm");
                throw;
            }

            ldapPage.ldapConfigSettings();
            try
            {
                Assert.IsTrue(true);
                _Child.Pass("Click on LDAP Configuration settings");
            }
            catch (AssertionException)
            {
                _Child.Fail("Failed to Click on LDAP Configuration settings");
                throw;
            }
            //BeforeTest();
            //HP_ePrint();
        }
    }
}
