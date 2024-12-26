namespace AntdUI_HamburgerMenuTabs.Pages
{
    public partial class TestWithArgs : UserControl
    {
        public TestWithArgs(string title, string path, string path2)
        {
            InitializeComponent();

            AntdUI.Panel panel = new()
            {
                Dock = DockStyle.Fill,
            };
            Controls.Add(panel);

            var btn1 = new AntdUI.Button()
            {
                Text = title,
                Dock = DockStyle.Top,
                Height = 50,
                Type = AntdUI.TTypeMini.Info,
            };
            Helpers.Antd.SetBreathingLight(btn1, Color.FromArgb(105, 70, 255), Color.FromArgb(255, 137, 4), 1);
            panel.Controls.Add(btn1);

            var btn2 = new AntdUI.Button()
            {
                Text = $"{path}",
                Dock = DockStyle.Bottom,
                Height = 50,
                Type = AntdUI.TTypeMini.Success,
            };
            Helpers.Antd.SetBreathingLight(btn2, Color.Empty, Color.Empty, 2);
            panel.Controls.Add(btn2);

            var btn3 = new AntdUI.Button()
            {
                Text = $"{path2}",
                Dock = DockStyle.Bottom,
                Height = 50,
                Type = AntdUI.TTypeMini.Error,
            };
            Helpers.Antd.SetBreathingLight(btn3, Color.Empty, Color.Empty, 2);
            panel.Controls.Add(btn3);

            var btn4 = new AntdUI.Button()
            {
                Text = $"{DateTime.Now:HH:mm:ss.fff}",
                Dock = DockStyle.Bottom,
                Height = 50,
                Type = AntdUI.TTypeMini.Warn,
            };
            Helpers.Antd.SetBreathingLight(btn4, Color.Empty, Color.Empty, 2);
            panel.Controls.Add(btn4);
        }
    }
}