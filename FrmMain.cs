using static AntdUI_HamburgerMenuTabs.Uc.HamburgerMenuTabs;

namespace AntdUI_HamburgerMenuTabs
{
    public partial class FrmMain : AntdUI.Window
    {
        public FrmMain()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            //TopMost = true;

            Helpers.Antd.SetTheme(this, btnTheme, true, Properties.Settings.Default.ThemeColor);

            windowBar1.Text = $"汉堡包菜单 + 多标签页面";
            windowBar1.SubText = "演示";

            tip1.SetTip(btnFullScreen, "全屏显示 (F11)");
            btnFullScreen.Click += (s, e) =>
            {
                ShowFullScreen();
            };

            tip1.SetTip(btnTheme, "切换主题");
            btnTheme.Click += (s, e) =>
            {
                Helpers.Antd.SetTheme(this, btnTheme, !AntdUI.Config.IsDark, Properties.Settings.Default.ThemeColor);
            };

            InitHamburgerMenuTabs();
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
                new MyMenuItem("home", "主页", SvgIcons.Home)
                {
                    PageType = typeof(Pages.Home),
                    Closeable = false,
                },
                new MyMenuItem("menu.1", "菜单 1", SvgIcons.MenuItem)
                {
                    PageType = typeof(Pages.TestWithArgs),
                },
                new MyMenuItem("menu.2", "菜单 2", SvgIcons.MenuItem)
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
                new MyMenuItem("menu.3", "菜单 3", SvgIcons.MenuItem)
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

                    // 把子控件添加到全屏显示窗口
                    frm.Controls.Add(c);

                    frm.FormClosing += (s, e) =>
                    {
                        // 把从页面上获取的子控件还给页面
                        page.Controls.Add(c);
                    };
                }

                frm.Show(this);
            }
        }
    }
}