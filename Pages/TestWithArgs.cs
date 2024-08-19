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
            SetButtonBackExtendRandomly(btn1, 1);
            panel.Controls.Add(btn1);

            var btn2 = new AntdUI.Button()
            {
                Text = $"{path}",
                Dock = DockStyle.Bottom,
                Height = 50,
                Type = AntdUI.TTypeMini.Success,
            };
            SetButtonBackExtendRandomly(btn2, 2);
            panel.Controls.Add(btn2);

            var btn3 = new AntdUI.Button()
            {
                Text = $"{path2}",
                Dock = DockStyle.Bottom,
                Height = 50,
                Type = AntdUI.TTypeMini.Error,
            };
            SetButtonBackExtendRandomly(btn3, 2);
            panel.Controls.Add(btn3);

            var btn4 = new AntdUI.Button()
            {
                Text = $"{DateTime.Now:HH:mm:ss.fff}",
                Dock = DockStyle.Bottom,
                Height = 50,
                Type = AntdUI.TTypeMini.Warn,
            };
            SetButtonBackExtendRandomly(btn4, 2);
            panel.Controls.Add(btn4);
        }

        private static void SetButtonBackExtendRandomly(AntdUI.Button btn, int animationType = 1)
        {
            if (btn.Type == AntdUI.TTypeMini.Default) return;

            Random rnd = new();
            int angle = 135;
            Color color1 = Color.FromArgb(rnd.Next(100, 200), rnd.Next(100, 200), rnd.Next(100, 200));
            Color color2 = Color.FromArgb(rnd.Next(100, 200), rnd.Next(100, 200), rnd.Next(100, 200));
            btn.BackExtend = $"{angle},{ColorTranslator.ToHtml(color1)},{ColorTranslator.ToHtml(color2)}";

            // 呼吸灯效果
            int i = 0;
            int ii = 1;
            System.Windows.Forms.Timer timer = new() { Interval = 30 };
            timer.Tick += (s, e) =>
            {
                i += ii;
                if (i == 50) ii = -1;
                if (i == -50) ii = 1;
                Color color3 = color1;
                Color color4 = color2;
                if (animationType == 1)
                {
                    color3 = Color.FromArgb(color1.R + i, color1.G + i, color1.B + i);
                    color4 = Color.FromArgb(color2.R + i, color2.G + i, color2.B + i);
                }
                else if (animationType == 2)
                {
                    color3 = Color.FromArgb(color1.R + i, color1.G, color1.B);
                    color4 = Color.FromArgb(color2.R, color2.G + i, color2.B);
                }
                btn.BackExtend = $"{angle},{ColorTranslator.ToHtml(color3)},{ColorTranslator.ToHtml(color4)}";
            };
            timer.Start();
        }
    }
}