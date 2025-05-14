using MyMenuItem = AntdUI_HamburgerMenuTabs.Uc.HamburgerMenuTabs.MyMenuItem;

namespace AntdUI_HamburgerMenuTabs
{
    public partial class FrmMain : AntdUI.Window
    {
        private Uc.HamburgerMenuTabs hmt = new();

        public FrmMain()
        {
            InitializeComponent();

            Text = Common.App.AppName;
            Size = new(1024, 576);
            StartPosition = FormStartPosition.CenterScreen;

            Helpers.Antd.ReadTheme(this, btnTheme, colorTheme);

            winBar.Text = Common.App.AppName;
            winBar.SubText = $"{Common.App.AppAuthor} | V{Common.App.AppVersion}";

            tipB.SetTip(btnFullScreen, "全屏显示 (F11)");
            btnFullScreen.Click += (s, e) =>
            {
                ShowFullScreen();
            };

            tipB.SetTip(btnTheme, "切换主题");
            btnTheme.Click += (s, e) =>
            {
                Helpers.Antd.SwitchTheme(this, btnTheme);
            };

            colorTheme.ValueChanged += (s, e) =>
            {
                Helpers.Antd.SetThemeColorAndSave(this, colorTheme.Value);
            };
            tipB.SetTip(colorTheme, "主题色");

            hmt.Dock = DockStyle.Fill;
            panelMain.Controls.Add(hmt);
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
                new MyMenuItem("Home", "主页", "HomeFilled")
                {
                    PageType = typeof(Pages.Home),
                    Closeable = false,
                },
                new MyMenuItem("Tools", "工具", "ToolFilled")
                {
                    Sub = [
                        new MyMenuItem("ToolsPerformanceMonitor", "性能监视器", null)
                        {
                            PageType = typeof(Pages.Tools.PerformanceMonitor),
                        },
                        new MyMenuItem("ToolsRandomCode", "随机编码生成器", null)
                        {
                            PageType = typeof(Pages.Tools.RandomCode),
                        },
                    ],
                },
                new MyMenuItem("Demo", "演示", "GithubFilled")
                {
                    Sub = [
                        new MyMenuItem("DemoGridPanel", "GridPanel 格栅布局", null)
                        {
                            PageType = typeof(Pages.Demo.GridPanel),
                        },
                        new MyMenuItem("DemoTable", "Table 表格", null)
                        {
                            PageType = typeof(Pages.Demo.Table),
                        },
                        new MyMenuItem("DemoTour", "Tour 引导", null)
                        {
                            PageType = typeof(Pages.Demo.Tour),
                        },
                        new MyMenuItem("DemoTree", "Tree 树形控件", null)
                        {
                            PageType = typeof(Pages.Demo.Tree),
                        },
                    ],
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