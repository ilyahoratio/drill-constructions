using OpenQA.Selenium.Appium.Windows;

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
