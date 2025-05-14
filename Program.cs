namespace AntdUI_HamburgerMenuTabs
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AntdUI.Config.ShowInWindowByMessage = true;
            AntdUI.Config.TextRenderingHighQuality = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(new FrmMain());
        }
    }
}