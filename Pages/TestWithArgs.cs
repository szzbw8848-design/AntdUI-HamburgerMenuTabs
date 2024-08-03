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
                //BackExtend = "135,#f02fc2,#6094ea",
            };
            SetButtonBackExtendRandomly(btn1);
            panel.Controls.Add(btn1);

            var btn2 = new AntdUI.Button()
            {
                Text = $"{path}",
                Dock = DockStyle.Bottom,
                Height = 50,
                Type = AntdUI.TTypeMini.Success,
            };
            panel.Controls.Add(btn2);

            var btn3 = new AntdUI.Button()
            {
                Text = $"{path2}",
                Dock = DockStyle.Bottom,
                Height = 50,
                Type = AntdUI.TTypeMini.Error,
            };
            panel.Controls.Add(btn3);

            var btn4 = new AntdUI.Button()
            {
                Text = $"{DateTime.Now:HH:mm:ss.fff}",
                Dock = DockStyle.Bottom,
                Height = 50,
                Type = AntdUI.TTypeMini.Warn,
            };
            panel.Controls.Add(btn4);
        }

        private static void SetButtonBackExtendRandomly(AntdUI.Button btn)
        {
            Random rnd = new();
            Color color1 = Color.FromArgb(rnd.Next(50, 200), rnd.Next(50, 200), rnd.Next(50, 200));
            Color color2 = Color.FromArgb(rnd.Next(50, 200), rnd.Next(50, 200), rnd.Next(50, 200));
            btn.BackExtend = $"135,{ColorTranslator.ToHtml(color1)},{ColorTranslator.ToHtml(color2)}";
        }
    }
}