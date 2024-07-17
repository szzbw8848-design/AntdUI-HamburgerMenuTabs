namespace AntdUI_HamburgerMenuTabs.Uc
{
    /// <summary>
    /// 汉堡包菜单 + 多标签页面
    /// 在主窗体置顶的前提下，因 AntdUI v1.4.5 存在 BUG，会导致菜单横向收缩后，一级菜单（无子菜单）的提示信息无法显示（应该是被主窗体遮挡了）。另外，Tabs 的工具提示也无法显示。
    /// </summary>
    public partial class HamburgerMenuTabs : UserControl
    {
        public HamburgerMenuTabs()
        {
            InitializeComponent();

            InitMenu();
        }

        public class Svgs
        {
            /// <summary>
            /// 汉堡包菜单
            /// </summary>
            public const string Menu = @"<svg t=""1720747755087"" class=""icon"" viewBox=""0 0 1024 1024"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" p-id=""18489"" width=""200"" height=""200""><path d=""M362.474498 627.133204M73.591065 278.392498c-29.520337 0-53.537334-24.016996-53.537334-53.53631 0-29.520337 24.016996-53.537334 53.537334-53.537334l876.816846 0c29.521361 0 53.537334 24.016996 53.537334 53.537334 0 29.519314-24.015973 53.53631-53.537334 53.53631L73.591065 278.392498zM73.591065 592.350003c-29.520337 0-53.537334-24.01802-53.537334-53.541427 0-29.520337 24.016996-53.537334 53.537334-53.537334l876.816846 0c29.521361 0 53.537334 24.016996 53.537334 53.537334 0 29.523407-24.015973 53.541427-53.537334 53.541427L73.591065 592.350003zM73.591065 903.797337c-29.520337 0-53.537334-24.015973-53.537334-53.537334 0-29.521361 24.016996-53.537334 53.537334-53.537334l876.816846 0c29.521361 0 53.537334 24.015973 53.537334 53.537334 0 29.521361-24.015973 53.537334-53.537334 53.537334L73.591065 903.797337z"" p-id=""18490""></path></svg>";

            /// <summary>
            /// 菜单折叠
            /// </summary>
            public const string Collapse = @"<svg t=""1720765301270"" class=""icon"" viewBox=""0 0 1024 1024"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" p-id=""5777"" width=""200"" height=""200""><path d=""M384 620.032c0 5.376-1.984 10.048-5.952 14.08C374.08 638.08 369.344 640 364.032 640L83.968 640c-5.376 0-10.112-1.92-14.08-5.952C65.92 630.08 64 625.344 64 620.032s1.92-10.048 5.952-14.08L209.92 465.984C213.888 462.016 218.624 460.032 224 460.032s10.048 1.984 14.08 6.016l140.032 139.968C382.016 609.92 384 614.656 384 620.032zM960 352C960 369.664 945.664 384 928 384l-448 0C462.336 384 448 369.664 448 352l0 0C448 334.336 462.336 320 480 320l448 0C945.664 320 960 334.336 960 352L960 352zM960 480C960 497.664 945.664 512 928 512l-448 0C462.336 512 448 497.664 448 480l0 0C448 462.336 462.336 448 480 448l448 0C945.664 448 960 462.336 960 480L960 480zM960 608c0 17.6-14.336 32-32 32l-448 0C462.336 640 448 625.6 448 608l0 0C448 590.272 462.336 576 480 576l448 0C945.664 576 960 590.272 960 608L960 608zM960 736c0 17.6-14.336 32-32 32l-448 0C462.336 768 448 753.6 448 736l0 0C448 718.272 462.336 704 480 704l448 0C945.664 704 960 718.272 960 736L960 736z"" p-id=""5778""></path></svg>";

            /// <summary>
            /// 菜单展开
            /// </summary>
            public const string Expand = @"<svg t=""1720765188677"" class=""icon"" viewBox=""0 0 1024 1024"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" p-id=""5630"" width=""200"" height=""200""><path d=""M384 467.968c0-5.376-1.984-10.048-5.952-14.08C374.08 449.92 369.344 448 364.032 448L83.968 448c-5.376 0-10.112 1.92-14.08 5.952C65.92 457.92 64 462.656 64 467.968s1.92 10.048 5.952 14.08L209.92 622.016C213.888 625.984 218.624 627.968 224 627.968s10.048-1.984 14.08-6.016l140.032-139.968C382.016 478.08 384 473.344 384 467.968zM960 352C960 369.664 945.664 384 928 384l-448 0C462.336 384 448 369.664 448 352l0 0C448 334.336 462.336 320 480 320l448 0C945.664 320 960 334.336 960 352L960 352zM960 480C960 497.664 945.664 512 928 512l-448 0C462.336 512 448 497.664 448 480l0 0C448 462.336 462.336 448 480 448l448 0C945.664 448 960 462.336 960 480L960 480zM960 608c0 17.6-14.336 32-32 32l-448 0C462.336 640 448 625.6 448 608l0 0C448 590.272 462.336 576 480 576l448 0C945.664 576 960 590.272 960 608L960 608zM960 736c0 17.6-14.336 32-32 32l-448 0C462.336 768 448 753.6 448 736l0 0C448 718.272 462.336 704 480 704l448 0C945.664 704 960 718.272 960 736L960 736z"" p-id=""5631""></path></svg>";

            /// <summary>
            /// 搜索
            /// </summary>
            public const string Search = @"<svg t=""1720748083841"" class=""icon"" viewBox=""0 0 1024 1024"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" p-id=""12013"" width=""200"" height=""200""><path d=""M406.016 598.016q80 0 136.021333-56.021333t56.021333-136.021333-56.021333-136.021333-136.021333-56.021333-136.021333 56.021333-56.021333 136.021333 56.021333 136.021333 136.021333 56.021333zM662.016 598.016l212.010667 212.010667-64 64-212.010667-212.010667 0-34.005333-11.989333-11.989333q-75.989333 66.005333-180.010667 66.005333-116.010667 0-196.992-80t-80.981333-196.010667 80.981333-196.992 196.992-80.981333 196.010667 80.981333 80 196.992q0 104.021333-66.005333 180.010667l11.989333 11.989333 34.005333 0z"" p-id=""12014""></path></svg>";

            /// <summary>
            /// 清除
            /// </summary>
            public const string Clear = @"<svg t=""1720748141598"" class=""icon"" viewBox=""0 0 1024 1024"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" p-id=""12160"" width=""200"" height=""200""><path d=""M809.984 274.005333l-237.994667 237.994667 237.994667 237.994667-59.989333 59.989333-237.994667-237.994667-237.994667 237.994667-59.989333-59.989333 237.994667-237.994667-237.994667-237.994667 59.989333-59.989333 237.994667 237.994667 237.994667-237.994667z"" p-id=""12161""></path></svg>";
        }

        /// <summary>
        /// 自定义 MenuItem 模型
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="iconSvg"></param>
        public class MyMenuItem(string code, string name, string? iconSvg)
        {
            /// <summary>
            /// 菜单项唯一编码
            /// </summary>
            public string Code { get; set; } = code;

            /// <summary>
            /// 菜单项显示名称
            /// </summary>
            public string Name { get; set; } = name;

            /// <summary>
            /// Svg 图标
            /// </summary>
            public string? IconSvg { get; set; } = iconSvg;

            /// <summary>
            /// 菜单项绑定的用户控件 typeof(UserControl)
            /// </summary>
            public Type? PageType { get; set; }

            /// <summary>
            /// 是否允许关闭页面
            /// </summary>
            public bool Closeable { get; set; } = true;

            /// <summary>
            /// 子菜单集合
            /// </summary>
            public List<MyMenuItem> Sub { get; set; } = [];
        }

        /// <summary>
        /// 主菜单
        /// </summary>
        private List<MyMenuItem> _menus = [];

        private readonly HashSet<string> menuCodes = [];

        /// <summary>
        /// 创建菜单
        /// </summary>
        /// <param name="parent1"></param>
        /// <param name="parent2"></param>
        private void CreateMenu(MyMenuItem? parent1, AntdUI.MenuItem? parent2)
        {
            List<MyMenuItem> _menus;

            if (parent1 == null)
            {
                _menus = this._menus;
            }
            else
            {
                _menus = parent1.Sub;
            }

            foreach (MyMenuItem _item in _menus)
            {
                if (menuCodes.Contains(_item.Code))
                {
                    throw new Exception($"菜单唯一编码（{_item.Code}）重复！");
                }
                else
                {
                    menuCodes.Add(_item.Code);
                }

                AntdUI.MenuItem item = new(_item.Name)
                {
                    IconSvg = _item.IconSvg,
                    Tag = new MenuItemTag(_item.Code) { PageType = _item.PageType, Closeable = _item.Closeable, },
                };

                if (parent2 == null)
                {
                    menu1.Items.Add(item);
                }
                else
                {
                    parent2.Sub.Add(item);
                }

                if (_item.Sub.Count > 0) CreateMenu(_item, item);
            }
        }

        /// <summary>
        /// 设置菜单项
        /// </summary>
        /// <param name="menus"></param>
        public void SetMenu(List<MyMenuItem>? menus)
        {
            if (menus != null) _menus = menus;
            menu1.Items.Clear();
            menuCodes.Clear();
            CreateMenu(null, null);
            MenuCollapsedAll(null);
            SetMenuItemParent(null);
            SetMenuItemPath(null);
        }

        /// <summary>
        /// 初始化菜单
        /// </summary>
        private void InitMenu()
        {
            SetMenu(null);

            #region 菜单收缩/展开

            btnMenuCollapsed.Click += (s, e) =>
            {
                if (!menu1.Collapsed)
                {
                    MenuCollapsedAll(null);
                    inputMenuSearch.Visible = false;
                    menu1.Collapsed = true;
                    panelMenu.Width = 70;
                }
                else
                {
                    inputMenuSearch.Visible = true;
                    menu1.Collapsed = false;
                    panelMenu.Width = 260;
                }
            };

            #endregion

            #region 菜单搜索输入框

            // 默认不显示清除图标
            inputMenuSearch.SuffixSvg = "";

            // 鼠标移入输入框且文本不为空时则显示清除图标
            inputMenuSearch.MouseEnter += (s, e) =>
            {
                if (inputMenuSearch.Text != "")
                {
                    inputMenuSearch.SuffixSvg = Svgs.Clear;
                }
            };

            // 鼠标移出输入框后不显示清除图标
            inputMenuSearch.MouseLeave += (s, e) =>
            {
                inputMenuSearch.SuffixSvg = "";
            };

            // 清除输入框文本
            inputMenuSearch.SuffixClick += (s, e) =>
            {
                inputMenuSearch.Clear();
            };

            DateTime searchTextChangedTime = DateTime.Now;
            bool searchFinished = true;
            int searchDelayMs = 500;    // 延时搜索（毫秒）

            System.Windows.Forms.Timer timerMenuSearch = new() { Interval = 10 };

            timerMenuSearch.Tick += (s, e) =>
            {
                if ((DateTime.Now - searchTextChangedTime).TotalMilliseconds > searchDelayMs && !searchFinished)
                {
                    MenuSearch(null);
                    if (inputMenuSearch.Text == "") MenuCollapsedAll(null);
                    searchFinished = true;
                    timerMenuSearch.Stop();
                }
            };

            timerMenuSearch.Start();

            // 输入框文本变更时触发菜单搜索
            inputMenuSearch.TextChanged += (s, e) =>
            {
                searchTextChangedTime = DateTime.Now;
                searchFinished = false;
                timerMenuSearch.Start();
            };

            #endregion

            #region 右键菜单

            AntdUI.IContextMenuStripItem[] cMenu1 = [
                new AntdUI.ContextMenuStripItem("全部折叠", "")
                {
                    IconSvg = Svgs.Collapse,
                },
                new AntdUI.ContextMenuStripItem("全部展开", "")
                {
                    IconSvg = Svgs.Expand,
                },
            ];

            menu1.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    AntdUI.ContextMenuStrip.open(this, it =>
                    {
                        switch (it.Text)
                        {
                            case "全部折叠":
                                MenuCollapsedAll(null);
                                break;
                            case "全部展开":
                                MenuExpandAll(null);
                                break;
                        }
                    }, cMenu1);
                }
            };

            #endregion

            menu1.SelectChanged += (s, e) =>
            {
                if (menuSelectMode == 0)
                {
                    string menuCode = "";
                    string menuText = e.Text!;
                    string menuPath = "";
                    string menuPath2 = "";
                    bool closeable = true;
                    Type? pageType = null;
                    if (e.Tag is MenuItemTag tag)
                    {
                        if (tag.Code != null) menuCode = tag.Code;
                        if (tag.Path != null) menuPath = tag.Path;
                        if (tag.Path2 != null) menuPath2 = tag.Path2;
                        if (tag.PageType != null) pageType = tag.PageType;
                        closeable = tag.Closeable;
                    }

                    LoadTabPage(menuText, menuPath, menuPath2, pageType, closeable);
                }
            };

            tabs1.TabPages.Clear();

            // 双击选项卡关闭页面
            tabs1.MouseDoubleClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    TabPage? page = tabs1.SelectedTab;
                    if (page != null)
                    {
                        if (page.Tag is TabPageTag tag)
                        {
                            bool closeable = tag.Closeable;
                            if (closeable)
                            {
                                page.Dispose();
                                if (tabs1.SelectedTab == null)
                                {
                                    UnSelectMenuAll(null);
                                    menu1.Refresh();
                                    MenuCollapsedAll(null);
                                }
                            }
                        }
                    }
                }
            };

            // 手动切换页面后定位菜单项
            tabs1.SelectedIndexChanged += (s, e) =>
            {
                if (tabPageSelectMode == 0)
                {
                    MenuLocateAfterTabPageSelected();
                }
            };

            tabs1.MouseMove += (s, e) =>
            {
                // 注：此事件无法触发！
                var mPos = e.Location;
                System.Diagnostics.Debug.Print($"[{DateTime.Now:HH:mm:ss.fff}] {mPos}");
            };
        }

        /// <summary>
        /// 收缩所有菜单项
        /// </summary>
        /// <param name="parent"></param>
        private void MenuCollapsedAll(AntdUI.MenuItem? parent)
        {
            AntdUI.MenuItemCollection items;
            if (parent == null) items = menu1.Items;
            else items = parent.Sub;
            foreach (AntdUI.MenuItem item in items)
            {
                if (item.Expand) item.Expand = false;
                if (item.Sub != null) MenuCollapsedAll(item);
            }
        }

        /// <summary>
        /// 展开所有菜单项
        /// </summary>
        /// <param name="parent"></param>
        private void MenuExpandAll(AntdUI.MenuItem? parent)
        {
            AntdUI.MenuItemCollection items;
            if (parent == null) items = menu1.Items;
            else items = parent.Sub;
            foreach (AntdUI.MenuItem item in items)
            {
                if (item.CanExpand && !item.Expand) item.Expand = true;
                if (item.Sub != null) MenuExpandAll(item);
            }
        }

        /// <summary>
        /// 展开指定菜单项的所有上级菜单
        /// </summary>
        /// <param name="item"></param>
        private static void MenuExpandAllParent(AntdUI.MenuItem item)
        {
            if (item.Tag is MenuItemTag tag)
            {
                if (tag.Parent != null)
                {
                    if (tag.Parent.CanExpand && !tag.Parent.Expand)
                    {
                        tag.Parent.Expand = true;
                        // 选中上级菜单，当 Menu.Collapsed = true 时可以看到效果
                        tag.Parent.Select = true;
                    }
                    MenuExpandAllParent(tag.Parent);
                }
            }
        }

        /// <summary>
        /// MenuItem 选择模式：0=默认；1=自定义程序控制；
        /// </summary>
        int menuSelectMode = 0;

        /// <summary>
        /// 选中指定菜单项
        /// </summary>
        /// <param name="path"></param>
        /// <param name="parent"></param>
        private void SelectMenu(string path, AntdUI.MenuItem? parent)
        {
            AntdUI.MenuItemCollection items;
            if (parent == null) items = menu1.Items;
            else items = parent.Sub;
            foreach (AntdUI.MenuItem item in items)
            {
                if (item.Tag is MenuItemTag tag)
                {
                    if (tag.Path != null)
                    {
                        if (string.Equals(tag.Path, path, StringComparison.OrdinalIgnoreCase))
                        {
                            item.Select = true;
                            MenuExpandAllParent(item);
                        }
                        else
                        {
                            item.Select = false;
                        }
                    }
                }
                if (item.Sub != null) SelectMenu(path, item);
            }
        }

        /// <summary>
        /// 取消所有菜单项的选中状态
        /// </summary>
        /// <param name="parent"></param>
        private void UnSelectMenuAll(AntdUI.MenuItem? parent)
        {
            AntdUI.MenuItemCollection items;
            if (parent == null) items = menu1.Items;
            else items = parent.Sub;
            foreach (AntdUI.MenuItem item in items)
            {
                if (item.Select)
                {
                    item.Select = false;
                }
                if (item.Sub != null) UnSelectMenuAll(item);
            }
        }

        /// <summary>
        /// 搜索菜单
        /// </summary>
        /// <param name="parent"></param>
        private void MenuSearch(AntdUI.MenuItem? parent)
        {
            string text = inputMenuSearch.Text;
            AntdUI.MenuItemCollection items;
            if (parent == null) items = menu1.Items;
            else items = parent.Sub;
            foreach (AntdUI.MenuItem item in items)
            {
                if (text == "" && !item.Visible)
                {
                    item.Visible = true;
                }
                else
                {
                    if (item.Text!.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1)
                    {
                        item.Visible = true;
                        if (!item.Expand) item.Expand = true;
                        MenuParentVisiable(item);
                    }
                    else
                    {
                        item.Visible = false;
                    }
                }
                if (item.Sub != null) MenuSearch(item);
            }
        }

        /// <summary>
        /// 把菜单项的所有父级菜单设置为可见
        /// </summary>
        /// <param name="item"></param>
        private static void MenuParentVisiable(AntdUI.MenuItem item)
        {
            if (item.Tag is MenuItemTag tag)
            {
                if (tag.Parent != null)
                {
                    if (!tag.Parent.Visible) tag.Parent.Visible = true;
                    if (!tag.Parent.Expand) tag.Parent.Expand = true;
                    MenuParentVisiable(tag.Parent);
                }
            }
        }

        /// <summary>
        /// 设置所有菜单项的父级
        /// </summary>
        /// <param name="parent"></param>
        private void SetMenuItemParent(AntdUI.MenuItem? parent)
        {
            AntdUI.MenuItemCollection items;
            if (parent == null) items = menu1.Items;
            else items = parent.Sub;
            foreach (AntdUI.MenuItem item in items)
            {
                if (item.Tag is MenuItemTag tag)
                {
                    tag.Parent = parent;
                }
                if (item.Sub != null) SetMenuItemParent(item);
            }
        }

        /// <summary>
        /// 设置所有菜单项的路径
        /// </summary>
        /// <param name="parent"></param>
        private void SetMenuItemPath(AntdUI.MenuItem? parent)
        {
            AntdUI.MenuItemCollection items;
            if (parent == null) items = menu1.Items;
            else items = parent.Sub;
            foreach (AntdUI.MenuItem item in items)
            {
                if (item.Tag is MenuItemTag tag)
                {
                    if (parent == null)
                    {
                        if (tag.Path == null)
                        {
                            tag.Path = $"/{tag.Code}";
                            tag.Path2 = $"/{item.Text}";
                        }
                        else
                        {
                            tag.Path = $"/{tag.Code}";
                            tag.Path2 = $"/{tag.Path2}";
                        }
                    }
                    else
                    {
                        if (parent.Tag is MenuItemTag tag2)
                        {
                            if (tag.Path == null)
                            {
                                tag.Path = $"{tag2.Path}/{tag.Code}";
                                tag.Path2 = $"{tag2.Path2}/{item.Text}";
                            }
                            else
                            {
                                tag.Path = $"{tag2.Path}/{tag.Path}";
                                tag.Path = $"{tag2.Path2}/{tag.Path2}";
                            }
                        }
                    }
                }
                if (item.Sub != null) SetMenuItemPath(item);
            }
        }

        /// <summary>
        /// MenuItem 自定义数据模型
        /// </summary>
        /// <param name="code"></param>
        class MenuItemTag(string code)
        {
            public string Code { get; set; } = code;
            public string? Path { get; set; }
            public string? Path2 { get; set; }
            public AntdUI.MenuItem? Parent { get; set; }
            public Type? PageType { get; set; }

            /// <summary>
            /// 是否允许关闭页面
            /// </summary>
            public bool Closeable { get; set; } = true;
        }

        /// <summary>
        /// TabPage 自定义数据模型
        /// </summary>
        /// <param name="menuPath"></param>
        class TabPageTag(string? menuPath)
        {
            /// <summary>
            /// 关联菜单路径
            /// </summary>
            public string? MenuPath { get; set; } = menuPath;

            /// <summary>
            /// 是否允许关闭页面
            /// </summary>
            public bool Closeable { get; set; } = true;
        }

        /// <summary>
        /// TabPage 选择模式：0=默认；1=自定义程序控制；
        /// </summary>
        int tabPageSelectMode = 0;

        /// <summary>
        /// 加载页面
        /// </summary>
        /// <param name="title"></param>
        /// <param name="path"></param>
        /// <param name="path2"></param>
        /// <param name="pageType"></param>
        private void LoadTabPage(string title, string path, string path2, Type? pageType, bool closeable)
        {
            tabPageSelectMode = 1;

            bool findInstance = false;

            foreach (TabPage _page in tabs1.TabPages)
            {
                if (_page.Tag is TabPageTag tag)
                {
                    if (string.Equals(tag.MenuPath, path, StringComparison.OrdinalIgnoreCase))
                    {
                        tabs1.SelectedTab = _page;
                        findInstance = true;
                        break;
                    }
                }
            }

            if (!findInstance)
            {
                TabPage page = new()
                {
                    Text = title,
                    ToolTipText = path2,
                    Tag = new TabPageTag(path) { Closeable = closeable },
                    Padding = new(0),
                };

                AntdUI.Panel panel = new()
                {
                    Dock = DockStyle.Fill,
                    Radius = 0,
                    Padding = new(2),
                };
                page.Controls.Add(panel);

                if (pageType != null)
                {
                    object[] args = [title, path, path2];
                    UserControl pageContent;
                    try
                    {
                        pageContent = (UserControl)Activator.CreateInstance(pageType, args)!;
                    }
                    catch
                    {
                        pageContent = (UserControl)Activator.CreateInstance(pageType)!;
                    }
                    pageContent.Dock = DockStyle.Fill;
                    panel.Controls.Add(pageContent);
                }
                else
                {
                    var alert = new AntdUI.Alert()
                    {
                        TextTitle = "警告",
                        Text = "菜单未配置关联页面！",
                        Icon = AntdUI.TType.Warn,
                        Height = 100,
                        Dock = DockStyle.Top,
                    };
                    panel.Padding = new(10);
                    panel.Controls.Add(alert);
                }

                tabs1.TabPages.Add(page);
                tabs1.SelectedTab = page;
            }

            tabPageSelectMode = 0;
        }

        /// <summary>
        /// 手动切换页面后定位菜单项
        /// </summary>
        private void MenuLocateAfterTabPageSelected()
        {
            TabPage? page = tabs1.SelectedTab;

            if (page != null)
            {
                string? path = null;
                if (page.Tag is TabPageTag tag)
                {
                    path = tag.MenuPath;
                }
                if (path != null)
                {
                    MenuCollapsedAll(null);
                    menuSelectMode = 1;
                    SelectMenu(path, null);
                    menuSelectMode = 0;
                    menu1.Refresh();
                }
            }
        }
    }
}