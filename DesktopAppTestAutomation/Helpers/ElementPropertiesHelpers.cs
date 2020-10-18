﻿using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTestAutomation.Helpers
{
    public static class ElementPropertiesHelpers
    {
        //ToDo : add waiter helpers 
        public static WindowsElement GetElementPropertiesByAccessID(this WindowsDriver<WindowsElement> driver, string elementAccessID)
        {
            return driver.FindElementByAccessibilityId(elementAccessID);
        }

        public static WindowsElement GetElementPropertiesByName(this WindowsDriver<WindowsElement> driver, string elementAccessID)
        {
            return driver.FindElementByName(elementAccessID);
        }

        public static bool IsElementEmpty(this WindowsDriver<WindowsElement> driver, string elementAccessID)
        {
            return driver.FindElementByAccessibilityId(elementAccessID).Text == string.Empty;
        }

        public static bool IsElementVisible(this WindowsDriver<WindowsElement> driver, string elementAccessID)
        {
            return driver.FindElementByAccessibilityId(elementAccessID).Displayed;
        }

        public static bool IsElementEnabled(this WindowsDriver<WindowsElement> driver, string elementAccessID)
        {
            return driver.FindElementByAccessibilityId(elementAccessID).Enabled;
        }
    }
}
