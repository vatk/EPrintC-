using ePrintConsole.PropColleactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePrintConsole
{
    public static class ePrintSetMethods
    {        
        /// <summary>
        /// Extended method for entering text in the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        /// <summary>
        /// Clic into a button, CheckBox, Radio Button, option etc
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element)
        {
            element.Click();
            
        }

         public static void ClickSubmit(this IWebElement element)
        {
            element.Click();
        }

        /// <summary>
        /// Selecting a Drop down control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value)
        {            
                new SelectElement(element).SelectByText(value);            
        }

        //public static void SelectCheckBox(IWebElement element, string value)
        //{
        //    ePrintPropertiesCollection.driver.FindElement(By.Id(value)).Click();

        //    //IWebElement ddl = ePrintPropertiesCollection.driver.FindElement(By.Id(value));
        //    //ddl.Click();
        //}
    }
}

