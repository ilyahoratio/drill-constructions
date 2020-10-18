using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
