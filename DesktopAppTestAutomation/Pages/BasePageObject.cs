using OpenQA.Selenium.Appium.Windows;

namespace DesktopAppTestAutomation.Pages
{
    internal class BasePageObject
    {
        private WindowsDriver<WindowsElement> WinDriver { get; set; }

        public BasePageObject(WindowsDriver<WindowsElement> winDriver)
        {
            WinDriver = winDriver;
        }

        public static string tabNameAddCards = "Add Cards";
        public static string tabNameBrowseCards = "Browse Cards";
    }
}
