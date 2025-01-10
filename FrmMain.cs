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

            winBar.Text = $"�������˵� + ���ǩҳ��";
            winBar.SubText = "��ʾ";

            tipB.SetTip(btnFullScreen, "ȫ����ʾ (F11)");
            btnFullScreen.Click += (s, e) =>
            {
                ShowFullScreen();
            };

            tipB.SetTip(btnTheme, "�л�����");
            btnTheme.Click += (s, e) =>
            {
                Helpers.Antd.SetTheme(this, btnTheme, !AntdUI.Config.IsDark, Properties.Settings.Default.ThemeColor);
            };

            hmt.Dock = DockStyle.Fill;
            panelMain.Controls.Add(hmt);
            InitHamburgerMenuTabs();

            #region Panel ����ɫ����
            // Panel ����ɫΪ Transparent ʱ���������ڳߴ�ʱ��ǳ�������Ĭ�ϱ���ɫΪ Control ʱû��������⣬���������ܳ�
            AntdUI.Button btnPanelBackColorSwitch = new()
            {
                Text = $"�л� Panel ����ɫ����ǰ BackColor = Control - {panelMain.BackColor}��",
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
                    btnPanelBackColorSwitch.Text = $"�л� Panel ����ɫ����ǰ BackColor = Control - {panelMain.BackColor}��";
                }
                else
                {
                    panelMain.BackColor = Color.Transparent;
                    btnPanelBackColorSwitch.Text = "�л� Panel ����ɫ����ǰ BackColor = Transparent��";
                }
                AntdUI.Message.open(new AntdUI.Message.Config(this, $"Panel ����ɫ��{panelMain.BackColor}", AntdUI.TType.Warn)
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
                new MyMenuItem("home", "��ҳ", "HomeFilled")
                {
                    PageType = typeof(Pages.Home),
                    Closeable = false,
                },
                new MyMenuItem("menu.1", "�˵� 1", "ProductFilled")
                {
                    PageType = typeof(Pages.TestWithArgs),
                },
                new MyMenuItem("menu.2", "�˵� 2", "ProductFilled")
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
                new MyMenuItem("menu.3", "�˵� 3", "ProductFilled")
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

                    frm.SuspendLayout();

                    // ���ӿؼ���ӵ�ȫ����ʾ����
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