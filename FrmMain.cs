using MyMenuItem = AntdUI_HamburgerMenuTabs.Uc.HamburgerMenuTabs.MyMenuItem;

namespace AntdUI_HamburgerMenuTabs
{
    public partial class FrmMain : AntdUI.Window
    {
        private Uc.HamburgerMenuTabs hmt = new Uc.HamburgerMenuTabs();

        public FrmMain()
        {
            InitializeComponent();

            Text = Common.App.AppName;
            Size = new System.Drawing.Size(1024, 576);
            StartPosition = FormStartPosition.CenterScreen;

            Helpers.Antd.ReadTheme(this, btnTheme, colorTheme);

            winBar.Text = Common.App.AppName;
            winBar.SubText = $"{Common.App.AppAuthor} | V{Common.App.AppVersion}";

            tipB.SetTip(btnFullScreen, "ȫ����ʾ (F11)");
            btnFullScreen.Click += (s, e) =>
            {
                ShowFullScreen();
            };

            tipB.SetTip(btnTheme, "�л�����");
            btnTheme.Click += (s, e) =>
            {
                Helpers.Antd.SwitchTheme(this, btnTheme);
            };

            colorTheme.ValueChanged += (s, e) =>
            {
                Helpers.Antd.SetThemeColorAndSave(this, colorTheme.Value);
            };
            tipB.SetTip(colorTheme, "����ɫ");

            hmt.Dock = DockStyle.Fill;
            panelMain.Controls.Add(hmt);
            InitHamburgerMenuTabs();
        }

        /// <summary>
        /// ȫ�ֿ�ݼ�
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
        /// ��ʼ���������˵�
        /// </summary>
        private void InitHamburgerMenuTabs()
        {
            List<MyMenuItem> menus = new List<MyMenuItem>{
                new MyMenuItem("Home", "��ҳ", "HomeFilled")
                {
                    PageType = typeof(Pages.Home),
                    Closeable = false,
                },
                new MyMenuItem("Tools", "����", "ToolFilled")
                {
                    Sub = new List<MyMenuItem>{
                        new MyMenuItem("ToolsPerformanceMonitor", "���ܼ�����", null)
                        {
                            PageType = typeof(Pages.Tools.PerformanceMonitor),
                        },
                        new MyMenuItem("ToolsRandomCode", "�������������", null)
                        {
                            PageType = typeof(Pages.Tools.RandomCode),
                        },
                    },
                },
                new MyMenuItem("Demo", "��ʾ", "GithubFilled")
                {
                    Sub = new List<MyMenuItem>{
                        new MyMenuItem("DemoGridPanel", "GridPanel ��դ����", null)
                        {
                            PageType = typeof(Pages.Demo.GridPanel),
                        },
                        new MyMenuItem("DemoTable", "Table ����", null)
                        {
                            PageType = typeof(Pages.Demo.Table),
                        },
                        new MyMenuItem("DemoTour", "Tour ����", null)
                        {
                            PageType = typeof(Pages.Demo.Tour),
                        },
                        new MyMenuItem("DemoTree", "Tree ���οؼ�", null)
                        {
                            PageType = typeof(Pages.Demo.Tree),
                        },
                    },
                },
                new MyMenuItem("menu.1", "�˵� 1", "ProductFilled")
                {
                    PageType = typeof(Pages.TestWithArgs),
                },
                new MyMenuItem("menu.2", "�˵� 2", "ProductFilled")
                {
                    Sub = new List<MyMenuItem>{
                        new MyMenuItem("menu.2.1", "�˵� 2.1", null)
                        {
                            PageType = typeof(Pages.TestWithArgs),
                        },
                        new MyMenuItem("menu.2.2", "�˵� 2.2", null)
                        {
                            PageType = typeof(Pages.TestWithArgs),
                        },
                    },
                },
                new MyMenuItem("menu.3", "�˵� 3", "ProductFilled")
                {
                    Sub = new List<MyMenuItem>{
                        new MyMenuItem("menu.3.1", "�˵� 3.1", null)
                        {
                            PageType = typeof(Pages.TestWithArgs),
                        },
                        new MyMenuItem("menu.3.2", "�˵� 3.2", null)
                        {
                            Sub = new List<MyMenuItem>{
                                new MyMenuItem("menu.3.2.1", "�˵� 3.2.1", null)
                                {
                                    PageType = typeof(Pages.TestWithArgs),
                                },
                                new MyMenuItem("menu.3.2.2", "�˵� 3.2.2", null)
                                {

                                },
                            },
                        },
                        new MyMenuItem("menu.3.3", "�˵� 3.3", null)
                        {
                            Sub = new List<MyMenuItem>{
                                new MyMenuItem("menu.3.3.1", "�˵� 3.3.1", null)
                                {
                                    Sub = new List<MyMenuItem>{
                                        new MyMenuItem("menu.3.3.1.1", "�˵� 3.3.1.1", null)
                                        {
                                            PageType = typeof(Pages.TestWithArgs),
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };

            hmt.SetMenu(menus);

            hmt.MenuSelectDefault();
        }

        private void ShowFullScreen()
        {
            var page = hmt.GetSelectedTab();

            if (page != null)
            {
                // ����ȫ����ʾ����
                var frm = new Forms.FullScreen()
                {
                    BackColor = BackColor,
                    ForeColor = ForeColor,
                };

                if (page.Controls.Count > 0)
                {
                    // ��ҳ���ϻ�ȡ�ӿؼ�
                    var c = page.Controls[0];

                    frm.SuspendLayout();

                    // ���ӿؼ����ӵ�ȫ����ʾ����
                    frm.Controls.Add(c);

                    frm.FormClosing += (s, e) =>
                    {
                        // �Ѵ�ҳ���ϻ�ȡ���ӿؼ�����ҳ��
                        page.Controls.Add(c);
                    };
                }

                frm.Show(this);

                frm.ResumeLayout();
            }
        }
    }
}