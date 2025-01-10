using MyMenuItem = AntdUI_HamburgerMenuTabs.Uc.HamburgerMenuTabs.MyMenuItem;

namespace AntdUI_HamburgerMenuTabs
{
    public partial class FrmMain : AntdUI.Window
    {
        private Uc.HamburgerMenuTabs hmt = new();

        public FrmMain()
        {
            InitializeComponent();

            Size = new(1024, 576);
            StartPosition = FormStartPosition.CenterScreen;
            //TopMost = true;

            Helpers.Antd.SetTheme(this, btnTheme);

            winBar.Text = $"汉堡包菜单 + 多标签页面";
            winBar.SubText = "演示";

            tipB.SetTip(btnFullScreen, "全屏显示 (F11)");
            btnFullScreen.Click += (s, e) =>
            {
                ShowFullScreen();
            };

            tipB.SetTip(btnTheme, "切换主题");
            btnTheme.Click += (s, e) =>
            {
                Helpers.Antd.SetTheme(this, btnTheme, !AntdUI.Config.IsDark, Properties.Settings.Default.ThemeColor);
            };

            hmt.Dock = DockStyle.Fill;
            panelMain.Controls.Add(hmt);
            InitHamburgerMenuTabs();

            #region Panel 背景色测试
            // Panel 背景色为 Transparent 时，调整窗口尺寸时会非常卡！而默认背景色为 Control 时没有这个问题，但是线条很丑！
            AntdUI.Button btnPanelBackColorSwitch = new()
            {
                Text = $"切换 Panel 背景色（当前 BackColor = Control - {panelMain.BackColor}）",
                AutoSize = true,
                AutoSizeMode = AntdUI.TAutoSize.Width,
                Dock = DockStyle.Right,
                Type = AntdUI.TTypeMini.Primary,
                IconSvg = "BugFilled",
            };
            btnPanelBackColorSwitch.Click += (s, e) =>
            {
                if (panelMain.BackColor == Color.Transparent)
                {
                    panelMain.BackColor = default;
                    btnPanelBackColorSwitch.Text = $"切换 Panel 背景色（当前 BackColor = Control - {panelMain.BackColor}）";
                }
                else
                {
                    panelMain.BackColor = Color.Transparent;
                    btnPanelBackColorSwitch.Text = "切换 Panel 背景色（当前 BackColor = Transparent）";
                }
                AntdUI.Message.open(new AntdUI.Message.Config(this, $"Panel 背景色：{panelMain.BackColor}", AntdUI.TType.Warn)
                {
                    Font = new(Font.FontFamily, 15),
                    Align = AntdUI.TAlignFrom.Bottom,
                    Padding = new(15, 15),
                });
            };
            winBar.Controls.Add(btnPanelBackColorSwitch);
            btnPanelBackColorSwitch.BringToFront();
            #endregion
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
                    ShowFullScreen();
                    break;
            }
            return false;
        }

        /// <summary>
        /// 初始化汉堡包菜单
        /// </summary>
        private void InitHamburgerMenuTabs()
        {
            List<MyMenuItem> menus = [
                new MyMenuItem("home", "主页", "HomeFilled")
                {
                    PageType = typeof(Pages.Home),
                    Closeable = false,
                },
                new MyMenuItem("menu.1", "菜单 1", "ProductFilled")
                {
                    PageType = typeof(Pages.TestWithArgs),
                },
                new MyMenuItem("menu.2", "菜单 2", "ProductFilled")
                {
                    Sub = [
                        new MyMenuItem("menu.2.1", "菜单 2.1", null)
                        {
                            PageType = typeof(Pages.TestWithArgs),
                        },
                        new MyMenuItem("menu.2.2", "菜单 2.2", null)
                        {
                            PageType = typeof(Pages.TestWithArgs),
                        },
                    ],
                },
                new MyMenuItem("menu.3", "菜单 3", "ProductFilled")
                {
                    Sub = [
                        new MyMenuItem("menu.3.1", "菜单 3.1", null)
                        {
                            PageType = typeof(Pages.TestWithArgs),
                        },
                        new MyMenuItem("menu.3.2", "菜单 3.2", null)
                        {
                            Sub = [
                                new MyMenuItem("menu.3.2.1", "菜单 3.2.1", null)
                                {
                                    PageType = typeof(Pages.TestWithArgs),
                                },
                                new MyMenuItem("menu.3.2.2", "菜单 3.2.2", null)
                                {

                                },
                            ],
                        },
                        new MyMenuItem("menu.3.3", "菜单 3.3", null)
                        {
                            Sub = [
                                new MyMenuItem("menu.3.3.1", "菜单 3.3.1", null)
                                {
                                    Sub = [
                                        new MyMenuItem("menu.3.3.1.1", "菜单 3.3.1.1", null)
                                        {
                                            PageType = typeof(Pages.TestWithArgs),
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                },
            ];

            hmt.SetMenu(menus);

            hmt.MenuSelectDefault();
        }

        private void ShowFullScreen()
        {
            var page = hmt.GetSelectedTab();

            if (page != null)
            {
                // 定义全屏显示窗口
                var frm = new Forms.FullScreen()
                {
                    BackColor = BackColor,
                    ForeColor = ForeColor,
                };

                if (page.Controls.Count > 0)
                {
                    // 从页面上获取子控件
                    var c = page.Controls[0];

                    frm.SuspendLayout();

                    // 把子控件添加到全屏显示窗口
                    frm.Controls.Add(c);

                    frm.FormClosing += (s, e) =>
                    {
                        // 把从页面上获取的子控件还给页面
                        page.Controls.Add(c);
                    };
                }

                frm.Show(this);

                frm.ResumeLayout();
            }
        }
    }
}