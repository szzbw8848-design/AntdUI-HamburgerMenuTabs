namespace AntdUI_HamburgerMenuTabs.Pages
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();

            lbTime.Text = $"{DateTime.Now:yyyy 年 M 月 d 日 HH:mm:ss}";

            System.Windows.Forms.Timer timer = new() { Interval = 100 };

            timer.Tick += (s, e) =>
            {
                lbTime.Text = $"{DateTime.Now:yyyy 年 M 月 d 日 HH:mm:ss}";
            };
            timer.Start();

            Helpers.Antd.SetBreathingLight(lbInfo, Color.FromArgb(105, 70, 255), Color.FromArgb(255, 137, 4), 1);
            Helpers.Antd.SetBreathingLight(lbTime, Color.FromArgb(105, 70, 255), Color.FromArgb(255, 137, 4), 1);
        }
    }
}