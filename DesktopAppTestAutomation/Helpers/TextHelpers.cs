using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTestAutomation.Helpers
{
    public static class TextHelpers
    {
        public static void PopulateTextField(this WindowsDriver<WindowsElement> driver, string elementAccessID, string textInput)
        {
            driver.FindElementByAccessibilityId(elementAccessID).SendKeys(textInput);
        }
    }
}
