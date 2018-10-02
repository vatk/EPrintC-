using ePrintConsole.PropColleactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Xml.Linq;
using System.Threading;
using System.Linq;
using NUnit.Framework;
using ePrintConsole.ExtentReporter;

namespace ePrintConsole.POM
{
    class Login : Base
    {
        public Login()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        string xmlPath = @"C:\Users\Administrator\Desktop\Final\ePrintConsole\ePrintConsole\ePintValues.xml";
        string title = "HP ePrint Enterprise Administration";
        string newTitle;


        [FindsBy(How = How.Id, Using = "UserTextBox")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "PasswordTextBox")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "Button1")]
        public IWebElement btnLogin { get; set; }

        public string Logins()
        {
            XDocument testXML = XDocument.Load(xmlPath);
            var admin = from logins in testXML.Descendants("crendential")
                        select new
                        {
                            uname = logins.Element("username").Value,
                            upwd = logins.Element("password").Value
                        };
            foreach (var user in admin)
            {
                if(newTitle != "HP ePrint Enterprise Administration")
                {
                    txtUserName.Clear(); Thread.Sleep(500);
                    txtUserName.EnterText(user.uname); Thread.Sleep(1000);
                    txtPassword.EnterText(user.upwd); Thread.Sleep(1000);
                    btnLogin.ClickSubmit(); Thread.Sleep(25000);
                    newTitle = PropertiesCollection.driver.Title;

                    GetLoginDetails(newTitle);

                    if (newTitle == "HP ePrint Enterprise Administration - Login")
                    {
                        newTitle = null;
                    }
                }                
            }            
            return newTitle;
        }

        public void GetLoginDetails(string gettitle)
        {
            if (gettitle == title)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsFalse(false);
            }
        }
    }
}
