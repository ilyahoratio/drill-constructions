using DesktopAppTestAutomation.Configuration;
using DesktopAppTestAutomation.Interfaces;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;

namespace DesktopAppTestAutomation.Driver
{
    public class WinAppDriver
    {
        readonly IConfig config = new AppConfigReader();
        private static Process appiumLocalHostConsole;

        public WindowsDriver<WindowsElement> GetWinAppDriver()
        {
            AppiumOptions appiumOptions = new OpenQA.Selenium.Appium.AppiumOptions();
            appiumOptions.AddAdditionalCapability("app", config.GetApplicationExeLocation());
            appiumOptions.AddAdditionalCapability("appWorkingDir", config.GetApplicationWorkingDirLocation());
            var drillConstructionsSession = new WindowsDriver<WindowsElement>(new Uri(config.GetAppiumLocalHostUri()), appiumOptions);
            return drillConstructionsSession;
        }

        public void LaunchWinAppDriverProcess()
        {
            appiumLocalHostConsole = Process.Start(config.GetWinAppDriverLocation());
        }

        public void CloseAppiumProcesses()
        {
            appiumLocalHostConsole.CloseMainWindow();
            appiumLocalHostConsole.Close();
        }
    }
}
