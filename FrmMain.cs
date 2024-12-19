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

            windowBar1.Text = $"�������˵� + ���ǩҳ��";
            windowBar1.SubText = "��ʾ";

            tip1.SetTip(btnFullScreen, "ȫ����ʾ (F11)");
            btnFullScreen.Click += (s, e) =>
            {
                ShowFullScreen();
            };

            tip1.SetTip(btnTheme, "�л�����");
            btnTheme.Click += (s, e) =>
            {
                Helpers.Antd.SetTheme(this, btnTheme, !AntdUI.Config.IsDark, Properties.Settings.Default.ThemeColor);
            };

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
            List<MyMenuItem> menus = [
                new MyMenuItem("home", "��ҳ", SvgIcons.Home)
                {
                    PageType = typeof(Pages.Home),
                    Closeable = false,
                },
                new MyMenuItem("menu.1", "�˵� 1", SvgIcons.MenuItem)
                {
                    PageType = typeof(Pages.TestWithArgs),
                },
                new MyMenuItem("menu.2", "�˵� 2", SvgIcons.MenuItem)
                {
                    Sub = [
                        new MyMenuItem("menu.2.1", "�˵� 2.1", null)
                        {
                            PageType = typeof(Pages.TestWithArgs),
                        },
                        new MyMenuItem("menu.2.2", "�˵� 2.2", null)
                        {
                            PageType = typeof(Pages.TestWithArgs),
                        },
                    ],
                },
                new MyMenuItem("menu.3", "�˵� 3", SvgIcons.MenuItem)
                {
                    Sub = [
                        new MyMenuItem("menu.3.1", "�˵� 3.1", null)
                        {
                            PageType = typeof(Pages.TestWithArgs),
                        },
                        new MyMenuItem("menu.3.2", "�˵� 3.2", null)
                        {
                            Sub = [
                                new MyMenuItem("menu.3.2.1", "�˵� 3.2.1", null)
                                {
                                    PageType = typeof(Pages.TestWithArgs),
                                },
                                new MyMenuItem("menu.3.2.2", "�˵� 3.2.2", null)
                                {

                                },
                            ],
                        },
                        new MyMenuItem("menu.3.3", "�˵� 3.3", null)
                        {
                            Sub = [
                                new MyMenuItem("menu.3.3.1", "�˵� 3.3.1", null)
                                {
                                    Sub = [
                                        new MyMenuItem("menu.3.3.1.1", "�˵� 3.3.1.1", null)
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

                    // ���ӿؼ���ӵ�ȫ����ʾ����
                    frm.Controls.Add(c);

                    frm.FormClosing += (s, e) =>
                    {
                        // �Ѵ�ҳ���ϻ�ȡ���ӿؼ�����ҳ��
                        page.Controls.Add(c);
                    };
                }

                frm.Show(this);
            }
        }
    }
}