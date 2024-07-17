using static AntdUI_HamburgerMenuTabs.Uc.HamburgerMenuTabs;

namespace AntdUI_HamburgerMenuTabs
{
    public partial class Form1 : AntdUI.Window
    {
        public Form1()
        {
            InitializeComponent();

            AntdUI.Config.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            AntdUI.Config.IsDark = true;
            BackColor = Color.Black;
            ForeColor = Color.White;
            StartPosition = FormStartPosition.CenterScreen;
            //TopMost = true;

            windowBar1.Text = $"汉堡包菜单 + 多标签页面";
            windowBar1.SubText = "演示";

            InitHamburgerMenuTabs();
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
        }
    }
}