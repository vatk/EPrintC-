using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePrintConsole
{
    //This class will hold all get Operations for UI
    class ePrintGetMethods
    {

        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");           
        }

        public static string GetTextFromDDl(IWebElement elemente)
        {
            return new SelectElement(elemente).AllSelectedOptions.SingleOrDefault().Text;
           
        }
    }
}
