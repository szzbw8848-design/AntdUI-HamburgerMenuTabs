using System.Diagnostics;

namespace AntdUI_HamburgerMenuTabs.Common
{
    internal class LogUtils
    {
        public static void VsPrint(string log)
        {
            Debug.Print($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] {log}");
        }
    }
}