using DesktopAppTestAutomation.Interfaces;
using DesktopAppTestAutomation.Settings;
using System.Configuration;

namespace DesktopAppTestAutomation.Configuration
{
    public class AppConfigReader : IConfig
    {
        public string GetDefaultStorageName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.DefaultStorageName);
        }

        public string GetAppiumLocalHostUri()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.AppiumLocalHostUri);
        }

        public string GetWinAppDriverLocation()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.WinAppDriverLocation);
        }

        public string GetApplicationExeLocation()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.ApplicationExeLocation);
        }

        public string GetApplicationWorkingDirLocation()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.ApplicationWorkingDirLocation);
        }
    }
}
