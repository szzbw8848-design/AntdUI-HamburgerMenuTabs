namespace AntdUI_HamburgerMenuTabs.Forms
{
    public partial class FullScreen : AntdUI.Window
    {
        public FullScreen()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Maximized;

            Shown += FullScreen_Shown;
        }

        private void FullScreen_Shown(object sender, EventArgs e)
        {
            // 在全屏显示窗口中提供悬浮按钮，以便能够操作退出全屏显示
            AntdUI.FloatButton.ConfigBtn[] btns =
            [
                new AntdUI.FloatButton.ConfigBtn("btnClose", "CompressOutlined", true){
                    Tooltip = "退出全屏 (F11)",
                    Type = AntdUI.TTypeMini.Primary,
                },
            ];

            var fb = AntdUI.FloatButton.open(new AntdUI.FloatButton.Config(this, btns, btn =>
            {
                if (btn.Name == "btnClose")
                {
                    Close();
                }
            })
            {
                TopMost = true,
            });

            fb!.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F11 || e.KeyCode == Keys.Escape)
                {
                    Close();
                }
            };
        }

        /// <summary>
        /// 全局快捷键
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F11:
                    Close();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
            return false;
        }
    }
}