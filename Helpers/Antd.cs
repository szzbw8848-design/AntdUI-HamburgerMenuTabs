namespace AntdUI_HamburgerMenuTabs.Helpers
{
    public class Antd
    {
        readonly static HashSet<AntdUI.Window> subWindows = [];

        /// <summary>
        /// 设置主题
        /// </summary>
        /// <param name="dark"></param>
        public static void SetTheme(AntdUI.Window window, AntdUI.Button btnSwitch, bool dark, Color primary)
        {
            AntdUI.Config.IsDark = dark;
            if (dark)
            {
                btnSwitch.IconSvg = "MoonFilled";
                window.BackColor = Color.Black;
                window.ForeColor = Color.White;
            }
            else
            {
                btnSwitch.IconSvg = "SunOutlined";
                window.BackColor = Color.White;
                window.ForeColor = Color.Black;
            }
            AntdUI.Style.SetPrimary(primary);
            window.Refresh();
            BroadcastThemeToSubWindows();
            Properties.Settings.Default.ThemeDark = dark;
            Properties.Settings.Default.ThemeColor = primary;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 设置主题色
        /// </summary>
        /// <param name="primary"></param>
        public static void SetThemeColor(AntdUI.Window window, Color primary)
        {
            AntdUI.Style.SetPrimary(primary);
            window.Refresh();
            BroadcastThemeToSubWindows();
            Properties.Settings.Default.ThemeColor = primary;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 继承主窗体的主题
        /// </summary>
        public static void InheritTheme(AntdUI.Window window)
        {
            bool themeChanged = false;
            bool dark = AntdUI.Config.IsDark;
            if (dark)
            {
                if (window.BackColor != Color.Black)
                {
                    window.BackColor = Color.Black;
                    window.ForeColor = Color.White;
                    themeChanged = true;
                }
            }
            else
            {
                if (window.BackColor != Color.White)
                {
                    window.BackColor = Color.White;
                    window.ForeColor = Color.Black;
                    themeChanged = true;
                }
            }
            if (themeChanged) window.Refresh();
            subWindows.Add(window);
        }

        /// <summary>
        /// 把主题应用到所有子窗体
        /// </summary>
        private static void BroadcastThemeToSubWindows()
        {
            foreach (AntdUI.Window subWin in subWindows)
            {
                if (subWin != null && !subWin.IsDisposed && subWin.Visible)
                {
                    InheritTheme(subWin);
                    subWin.Refresh();
                }
            }
        }
    }
}