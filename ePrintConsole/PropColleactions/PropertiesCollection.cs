using AventStack.ExtentReports;
using OpenQA.Selenium;
using System.Xml.Linq;

namespace ePrintConsole.PropColleactions
{
    enum PropertyType
    {
        ClassName,
        CssSelector,
        Id,
        LinkText,
        Name,
        PartialLinkText,
        TagName,
        XPath
    }

    class ExtentReportsProp
    {
        public static ExtentReports _extent { get; set; }
        public static ExtentTest _test { get; set; }
    }

    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }        
    }    
}
