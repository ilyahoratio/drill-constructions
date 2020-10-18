using OpenQA.Selenium.Appium.Windows;

namespace DesktopAppTestAutomation.Helpers
{
    public static class ClickerHelpers
    {
        //TODO : add waiter helpers 
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
