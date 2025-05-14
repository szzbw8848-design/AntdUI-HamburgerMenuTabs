namespace AntdUI_HamburgerMenuTabs.Pages
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();

            ShowTime();

            System.Windows.Forms.Timer timer = new() { Interval = 100 };

            timer.Tick += (s, e) =>
            {
                ShowTime();
            };
            timer.Start();

            Helpers.Antd.SetBreathingLight(lbInfo, Color.FromArgb(105, 70, 255), Color.Empty, 1);
            Helpers.Antd.SetBreathingLight(lbTime, Color.FromArgb(105, 70, 255), Color.Empty, 1);
        }

        private void ShowTime()
        {
            lbTime.Text = $"{DateTime.Now:yyyy 年 M 月 d 日 H 时 m 分 s 秒}";
        }
    }
}