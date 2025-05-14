namespace AntdUI_HamburgerMenuTabs.Pages.Demo
{
    public partial class GridPanel : UserControl
    {
        public GridPanel()
        {
            InitializeComponent();

            SetSpan();

            btnLoad.Click += (s, e) => DoLoad();
            btnAdd.Click += (s, e) => DoAdd();
            btnMinus.Click += (s, e) => DoMinus();
            btnClear.Click += (s, e) => DoClear();
        }

        private readonly int rMax = 10, cMax = 10;

        private void SetSpan()
        {
            string cSpan = "";

            for (int c = 1; c <= cMax; c++)
            {
                int cPercent = 100 / cMax;
                if (c == cMax) cPercent = 100 - (100 / cMax * (cMax - 1));
                cSpan += $"{cPercent}% ";
                if (c == cMax)
                {
                    cSpan = $"{cSpan.Trim()};";
                }
            }

            string span = string.Concat(Enumerable.Repeat(cSpan, rMax));

            gridPanel1.Span = span;
        }

        private void DoLoad()
        {
            gridPanel1.SuspendLayout();

            gridPanel1.Controls.Clear();

            SetSpan();

            int total = rMax * cMax;

            for (int i = 1; i <= total; i++)
            {
                AntdUI.Button btn = new()
                {
                    Name = $"btn{i}",
                    Text = $"{i:000}",
                    Type = AntdUI.TTypeMini.Default,
                    ToggleType = AntdUI.TTypeMini.Primary,
                    WaveSize = 0,
                };
                btn.Click += (s, e) => btn.Toggle = !btn.Toggle;
                gridPanel1.Controls.Add(btn);
                btn.BringToFront();
            }

            gridPanel1.ResumeLayout();

            AntdUI.Message.success(ParentForm!, $"完成", default, 2);
        }

        private void DoAdd()
        {
            int total = gridPanel1.Controls.Count;
            if (total == rMax * cMax)
            {
                Helpers.Antd.Msgbox.ShowWarn(ParentForm!, "GridPanel 已满！");
                return;
            }
            int id = total + 1;
            AntdUI.Button btn = new()
            {
                Name = $"btn{id}",
                Text = $"{id:000}",
                Type = AntdUI.TTypeMini.Default,
                ToggleType = AntdUI.TTypeMini.Primary,
                WaveSize = 0,
            };
            btn.Click += (s, e) => btn.Toggle = !btn.Toggle;
            gridPanel1.SuspendLayout();
            gridPanel1.Controls.Add(btn);
            btn.BringToFront();
            gridPanel1.ResumeLayout();
        }

        private void DoMinus()
        {
            int total = gridPanel1.Controls.Count;
            if (total == 0)
            {
                Helpers.Antd.Msgbox.ShowWarn(ParentForm!, "GridPanel 是空的！");
                return;
            }
            Control c = gridPanel1.Controls[0];
            gridPanel1.Controls.Remove(c);
            c.Dispose();
        }

        private void DoClear()
        {
            gridPanel1.SuspendLayout();
            gridPanel1.Controls.Clear();
            gridPanel1.ResumeLayout();
        }
    }
}