using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTestAutomation.Helpers
{
    public static class ClickerHelpers
    {
        //ToDo : add waiter helpers 
        public static void ClickElementByAccessID(this WindowsDriver<WindowsElement> driver, string elementAccessID)
        {
            driver.FindElementByAccessibilityId(elementAccessID).Click();
        }

        public static void ClickElementByName(this WindowsDriver<WindowsElement> driver, string elementAccessID)
        {
            driver.FindElementByName(elementAccessID).Click();
        }
    }
}
