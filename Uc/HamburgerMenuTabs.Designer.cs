namespace AntdUI_HamburgerMenuTabs.Uc
{
    partial class HamburgerMenuTabs
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleCard styleCard1 = new AntdUI.Tabs.StyleCard();
            tabs1 = new AntdUI.Tabs();
            panelMenu = new AntdUI.Panel();
            menu1 = new AntdUI.Menu();
            divider1 = new AntdUI.Divider();
            panelMenuHeader = new AntdUI.Panel();
            inputMenuSearch = new AntdUI.Input();
            btnMenuCollapsed = new AntdUI.Button();
            tipB = new AntdUI.TooltipComponent();
            panelMenu.SuspendLayout();
            panelMenuHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tabs1
            // 
            tabs1.Dock = DockStyle.Fill;
            tabs1.Gap = 12;
            tabs1.Location = new Point(215, 5);
            tabs1.Name = "tabs1";
            tabs1.Size = new Size(548, 462);
            styleCard1.Closable = true;
            tabs1.Style = styleCard1;
            tabs1.TabIndex = 0;
            tabs1.Type = AntdUI.TabType.Card;
            // 
            // panelMenu
            // 
            panelMenu.BorderWidth = 1F;
            panelMenu.Controls.Add(menu1);
            panelMenu.Controls.Add(divider1);
            panelMenu.Controls.Add(panelMenuHeader);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(5, 5);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(5);
            panelMenu.Size = new Size(210, 462);
            panelMenu.TabIndex = 0;
            // 
            // menu1
            // 
            menu1.AutoCollapse = true;
            menu1.Dock = DockStyle.Fill;
            menu1.Indent = true;
            menu1.Location = new Point(6, 56);
            menu1.Name = "menu1";
            menu1.ShowSubBack = true;
            menu1.Size = new Size(198, 400);
            menu1.TabIndex = 1;
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(6, 46);
            divider1.Name = "divider1";
            divider1.Size = new Size(198, 10);
            divider1.TabIndex = 0;
            // 
            // panelMenuHeader
            // 
            panelMenuHeader.Controls.Add(inputMenuSearch);
            panelMenuHeader.Controls.Add(btnMenuCollapsed);
            panelMenuHeader.Dock = DockStyle.Top;
            panelMenuHeader.Location = new Point(6, 6);
            panelMenuHeader.Name = "panelMenuHeader";
            panelMenuHeader.Radius = 0;
            panelMenuHeader.Size = new Size(198, 40);
            panelMenuHeader.TabIndex = 1;
            // 
            // inputMenuSearch
            // 
            inputMenuSearch.AllowClear = true;
            inputMenuSearch.Dock = DockStyle.Fill;
            inputMenuSearch.IconRatio = 1F;
            inputMenuSearch.Location = new Point(40, 0);
            inputMenuSearch.Name = "inputMenuSearch";
            inputMenuSearch.PlaceholderText = "搜索菜单";
            inputMenuSearch.PrefixSvg = "SearchOutlined";
            inputMenuSearch.Size = new Size(158, 40);
            inputMenuSearch.SuffixSvg = "";
            inputMenuSearch.TabIndex = 1;
            // 
            // btnMenuCollapsed
            // 
            btnMenuCollapsed.Dock = DockStyle.Left;
            btnMenuCollapsed.IconRatio = 1F;
            btnMenuCollapsed.IconSvg = "MenuOutlined";
            btnMenuCollapsed.Location = new Point(0, 0);
            btnMenuCollapsed.Name = "btnMenuCollapsed";
            btnMenuCollapsed.Size = new Size(40, 40);
            btnMenuCollapsed.TabIndex = 0;
            // 
            // tipB
            // 
            tipB.ArrowAlign = AntdUI.TAlign.Bottom;
            // 
            // HamburgerMenuTabs
            // 
            Controls.Add(tabs1);
            Controls.Add(panelMenu);
            Font = new Font("微软雅黑", 9F);
            Name = "HamburgerMenuTabs";
            Padding = new Padding(5);
            Size = new Size(768, 472);
            panelMenu.ResumeLayout(false);
            panelMenuHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Tabs tabs1;
        private AntdUI.Panel panelMenu;
        private AntdUI.Menu menu1;
        private AntdUI.Panel panelMenuHeader;
        private AntdUI.Input inputMenuSearch;
        private AntdUI.Button btnMenuCollapsed;
        private AntdUI.TooltipComponent tipB;
        private AntdUI.Divider divider1;
    }
}