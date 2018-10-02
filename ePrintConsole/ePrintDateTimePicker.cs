using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using ePrintConsole.PropColleactions;

namespace ePrintConsole
{
    class ePrintDateTimePicker
    {
        //Track Jobs
        public static void DatePickerPreHandling(string element)
        {
            if (element == "ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_StartDate")
            {
                //Track Jobs
                IWebElement trackJobCalender = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_StartDate']"));
                trackJobCalender.Click();
                IWebElement preMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_StartDate']//tbody//tr//td[@colspan='7']//table[@cellspacing='0']//tbody//tr//td//a[@title='Go to the previous month'][contains(text(),'<')]"));
                preMonth.Click();

                IList<IWebElement> days = PropertiesCollection.driver.FindElements(By.XPath("//table[@width='100%'][@width='100%']//table[@width='100%']//td//td//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_StartDate']//tbody//tr[4]//td[4]"));

                var builder = new Actions(PropertiesCollection.driver);
                days = PropertiesCollection.driver.FindElements(By.XPath("//table[@width='100%'][@width='100%']//table[@width='100%']//td//td//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_StartDate']//tbody//tr[4]//td[4]"));
                for (int i = 0; i < days.Count(); i++)
                {
                    builder.Click(days[0]).Build().Perform();
                }
                Thread.Sleep(2000);
            }
            else
            {
                var preMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_EndDate']//tbody//tr//td[@colspan='7']//table[@cellspacing='0']//tbody//tr//td//a[@title='Go to the previous month'][contains(text(),'<')]"));
                preMonth.Click();
                var nextMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_EndDate']//a[@title='Go to the next month'][contains(text(),'>')]"));
                nextMonth.Click();
                IList<IWebElement> cDays = PropertiesCollection.driver.FindElements(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_EndDate']"));
                var nBuilder = new Actions(PropertiesCollection.driver);

                cDays = PropertiesCollection.driver.FindElements(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_EndDate']"));
                for (int i = 0; i < cDays.Count(); i++)
                {
                    var todaysDate = PropertiesCollection.driver.FindElements(By.LinkText(DateTime.Today.Day.ToString()));
                    //DateTime tdate = DateTime.Today;
                    string ndate = string.Format(todaysDate.ToString());
                    nBuilder.Click(todaysDate[1]).Build().Perform();
                }
                Thread.Sleep(2000);

            }
        }

        public static void DatePickerTrackMessage(string element)
        {
            if (element == "ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate")
            {
                //Track Messgaes 
                IWebElement trackJobCalender1 = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']"));
                trackJobCalender1.Click();
                IWebElement preMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']//tbody//tr//td[@colspan='7']//table[@cellspacing='0']//tbody//tr//td//a[@title='Go to the previous month'][contains(text(),'<')]"));
                preMonth.Click();

                IList<IWebElement> days = PropertiesCollection.driver.FindElements(By.XPath("//table[@width='100%'][@width='100%']//table[@width='100%']//td//td//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']//tbody//tr[4]//td[4]"));
                var builder = new Actions(PropertiesCollection.driver);

                days = PropertiesCollection.driver.FindElements(By.XPath("//table[@width='100%'][@width='100%']//table[@width='100%']//td//td//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']//tbody//tr[4]//td[4]"));
                for (int i = 0; i < days.Count(); i++)
                {
                    builder.Click(days[0]).Build().Perform();
                }
                Thread.Sleep(5000);
            }
            else
            {
                var preMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']//tbody//tr//td[@colspan='7']//table[@cellspacing='0']//tbody//tr//td//a[@title='Go to the previous month'][contains(text(),'<')]"));
                preMonth.Click();
                var nextMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']//a[@title='Go to the next month'][contains(text(),'>')]"));
                nextMonth.Click();
                IList<IWebElement> cDays = PropertiesCollection.driver.FindElements(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_jblListSel_EndDate']"));
                var nBuilder = new Actions(PropertiesCollection.driver);

                cDays = PropertiesCollection.driver.FindElements(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']"));
                for (int i = 0; i < cDays.Count(); i++)
                {
                    var todaysDate = PropertiesCollection.driver.FindElements(By.LinkText(DateTime.Today.Day.ToString()));
                    string ndate = string.Format(todaysDate.ToString());
                    nBuilder.Click(todaysDate[1]).Build().Perform();
                }
                Thread.Sleep(2000);
            }
        }
        
        public static void DatePickerTrackEvents(string element)
        {
            if (element == "ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate")
            {
                //Track Events
                IWebElement trackJobCalender1 = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']"));
                trackJobCalender1.Click();
                IWebElement preMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']//tbody//tr//td[@colspan='7']//table[@cellspacing='0']//tbody//tr//td//a[@title='Go to the previous month'][contains(text(),'<')]"));
                preMonth.Click();

                IList<IWebElement> days = PropertiesCollection.driver.FindElements(By.XPath("//table[@width='100%'][@width='100%']//table[@width='100%']//td//td//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']//tbody//tr[4]//td[4]"));
                var builder = new Actions(PropertiesCollection.driver);

                days = PropertiesCollection.driver.FindElements(By.XPath("//table[@width='100%'][@width='100%']//table[@width='100%']//td//td//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']//tbody//tr[4]//td[4]"));
                for (int i = 0; i < days.Count(); i++)
                {
                    builder.Click(days[0]).Build().Perform();
                }
                Thread.Sleep(5000);
            }
            else
            {
                var preMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']//tbody//tr//td[@colspan='7']//table[@cellspacing='0']//tbody//tr//td//a[@title='Go to the previous month'][contains(text(),'<')]"));
                preMonth.Click();
                var nextMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']//a[@title='Go to the next month'][contains(text(),'>')]"));
                nextMonth.Click();
                IList<IWebElement> cDays = PropertiesCollection.driver.FindElements(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']"));
                var nBuilder = new Actions(PropertiesCollection.driver);

                cDays = PropertiesCollection.driver.FindElements(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']"));
                for (int i = 0; i < cDays.Count(); i++)
                {
                    var todaysDate = PropertiesCollection.driver.FindElements(By.LinkText(DateTime.Today.Day.ToString()));
                    string ndate = string.Format(todaysDate.ToString());
                    nBuilder.Click(todaysDate[1]).Build().Perform();
                }
                Thread.Sleep(2000);
            }
        }

        public static void DatePickerMetrics(string element)
        {
            if (element == "ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate")
            {
                //Start Metrics
                IWebElement trackJobCalender1 = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']"));
                trackJobCalender1.Click();
                IWebElement preMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']//tbody//tr//td[@colspan='7']//table[@cellspacing='0']//tbody//tr//td//a[@title='Go to the previous month'][contains(text(),'<')]"));
                preMonth.Click();

                IList<IWebElement> days = PropertiesCollection.driver.FindElements(By.XPath("//table[@width='100%'][@width='100%']//table[@width='100%']//td//td//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']//tbody//tr[4]//td[4]"));
                var builder = new Actions(PropertiesCollection.driver);

                days = PropertiesCollection.driver.FindElements(By.XPath("//table[@width='100%'][@width='100%']//table[@width='100%']//td//td//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtStartDate']//tbody//tr[4]//td[4]"));
                for (int i = 0; i < days.Count(); i++)
                {
                    builder.Click(days[0]).Build().Perform();
                }
                Thread.Sleep(2000);
            }
            else
            {
                var preMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']//tbody//tr//td[@colspan='7']//table[@cellspacing='0']//tbody//tr//td//a[@title='Go to the previous month'][contains(text(),'<')]"));
                preMonth.Click();
                var nextMonth = PropertiesCollection.driver.FindElement(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']//a[@title='Go to the next month'][contains(text(),'>')]"));
                nextMonth.Click();
                IList<IWebElement> cDays = PropertiesCollection.driver.FindElements(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']"));
                var nBuilder = new Actions(PropertiesCollection.driver);

                cDays = PropertiesCollection.driver.FindElements(By.XPath("//table[@id='ctl00_BodyContentPlaceHolder_panel1_ctl00_txtEndDate']"));
                for (int i = 0; i < cDays.Count(); i++)
                {
                    var todaysDate = PropertiesCollection.driver.FindElements(By.LinkText(DateTime.Today.Day.ToString()));
                    string ndate = string.Format(todaysDate.ToString());
                    nBuilder.Click(todaysDate[1]).Build().Perform();
                }
                Thread.Sleep(2000);
            }
        }

        public static void deleteUser(string element)
        {
            if (element == "ImageButton2")
            {
                IWebElement deleteUserCalender2 = PropertiesCollection.driver.FindElement(By.XPath("//div[@id='ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_CalendarExtender2_popupDiv']"));
                deleteUserCalender2.Click();
                IList<IWebElement> dDays = PropertiesCollection.driver.FindElements(By.XPath("//div[@id='ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_CalendarExtender2_days']"));
                var dBuilder = new Actions(PropertiesCollection.driver);

                dDays = PropertiesCollection.driver.FindElements(By.XPath("//div[@id='ctl00_BodyContentPlaceHolder_UserFormPanel_ctl00_UserForm_UserFormView_CalendarExtender2_days']"));
                for (int i = 0; i < dDays.Count(); i++)
                {
                    var todaysDate = PropertiesCollection.driver.FindElements(By.LinkText(DateTime.Today.Day.ToString()));
                    string ndate = string.Format(todaysDate.ToString());
                    dBuilder.DoubleClick(todaysDate[1]).Build().Perform();
                }
                Thread.Sleep(2000);
            }
            else
            {

            }
        }
    }
}
        