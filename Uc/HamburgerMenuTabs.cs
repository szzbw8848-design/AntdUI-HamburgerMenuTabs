namespace AntdUI_HamburgerMenuTabs.Uc
{
    /// <summary>
    /// 汉堡包菜单 + 多标签页面
    /// </summary>
    public partial class HamburgerMenuTabs : UserControl
    {
        public HamburgerMenuTabs()
        {
            InitializeComponent();

            tabs1.TypExceed = AntdUI.TabTypExceed.Button;

            InitMenu();
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
                    IconSvg = "MenuFoldOutlined",
                },
                new AntdUI.ContextMenuStripItem("全部展开", "")
                {
                    IconSvg = "MenuUnfoldOutlined",
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
                    string title = e.Value.Text!;
                    string path = "";
                    string path2 = "";
                    string? svg = "";
                    bool closeable = true;
                    Type? pageType = null;
                    if (e.Value.Tag is MenuItemTag tag)
                    {
                        if (tag.Path != null) path = tag.Path;
                        if (tag.Path2 != null) path2 = tag.Path2;
                        if (tag.PageType != null) pageType = tag.PageType;
                        svg = e.Value.IconSvg;
                        closeable = tag.Closeable;
                    }

                    LoadTabPage(title, path, path2, pageType, svg, closeable);
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
        private void LoadTabPage(string title, string path, string path2, Type? pageType, string? svg, bool closeable)
        {
            tabPageSelectMode = 1;

            bool findInstance = false;

            foreach (AntdUI.TabPage _page in tabs1.Pages)
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
                AntdUI.TabPage page = new()
                {
                    Text = title,
                    IconSvg = svg,
                    Tag = new TabPageTag(path) { Closeable = closeable },
                };
                if (!closeable)
                {
                    page.ReadOnly = true;
                }
                page.Disposed += (s, e) =>
                {
                    if (ParentForm != null)
                    {
                        AntdUI.Message.info(ParentForm, $"页面【{page.Text}】已关闭。");
                    }
                };

                AntdUI.Panel panel = new()
                {
                    Dock = DockStyle.Fill,
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

                tabs1.Pages.Add(page);
                tabs1.SelectedTab = page;
            }

            tabPageSelectMode = 0;
        }

        /// <summary>
        /// 获取当前选中的 TabPage
        /// </summary>
        /// <returns></returns>
        public AntdUI.TabPage? GetSelectedTab()
        {
            return tabs1.SelectedTab;
        }

        /// <summary>
        /// 手动切换页面后定位菜单项
        /// </summary>
        private void MenuLocateAfterTabPageSelected()
        {
            AntdUI.TabPage? page = tabs1.SelectedTab;

            if (page != null)
            {
                string path = "";
                if (page.Tag is TabPageTag tag)
                {
                    path = tag.MenuPath!;
                }
                MenuCollapsedAll(null);
                menuSelectMode = 1;
                SelectMenu(path, null);
                menuSelectMode = 0;
                menu1.Refresh();
            }
        }

        /// <summary>
        /// 菜单默认选中项
        /// </summary>
        public void MenuSelectDefault()
        {
            var item = menu1.Items.FirstOrDefault();
            if (item != null)
            {
                string title = item.Text!;
                string path = "";
                string path2 = "";
                string? svg = "";
                bool closeable = true;
                Type? pageType = null;
                if (item.Tag is MenuItemTag tag)
                {
                    if (tag.Path != null) path = tag.Path;
                    if (tag.Path2 != null) path2 = tag.Path2;
                    if (tag.PageType != null) pageType = tag.PageType;
                    svg = item.IconSvg;
                    closeable = tag.Closeable;
                }

                LoadTabPage(title, path, path2, pageType, svg, closeable);
            }
        }
    }
}