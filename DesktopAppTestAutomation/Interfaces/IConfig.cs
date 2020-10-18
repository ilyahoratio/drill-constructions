namespace DesktopAppTestAutomation.Interfaces
{
    public interface IConfig
    {
        string GetDefaultStorageName();
        string GetAppiumLocalHostUri();
        string GetWinAppDriverLocation();
        string GetApplicationExeLocation();
        string GetApplicationWorkingDirLocation();
    }
}
