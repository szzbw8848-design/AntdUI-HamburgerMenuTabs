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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HamburgerMenuTabs));
            panelMain = new AntdUI.Panel();
            panelTabs = new AntdUI.Panel();
            tabs1 = new AntdUI.Tabs();
            panelMenu = new AntdUI.Panel();
            tlpMenu = new TableLayoutPanel();
            menu1 = new AntdUI.Menu();
            panelMenuHeader = new AntdUI.Panel();
            inputMenuSearch = new AntdUI.Input();
            btnMenuCollapsed = new AntdUI.Button();
            divider1 = new AntdUI.Divider();
            tipB = new AntdUI.TooltipComponent();
            panelMain.SuspendLayout();
            panelTabs.SuspendLayout();
            panelMenu.SuspendLayout();
            tlpMenu.SuspendLayout();
            panelMenuHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Transparent;
            panelMain.Controls.Add(panelTabs);
            panelMain.Controls.Add(panelMenu);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Font = new Font("微软雅黑", 9F);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(5);
            panelMain.Size = new Size(768, 472);
            panelMain.TabIndex = 3;
            panelMain.Text = "panel1";
            // 
            // panelTabs
            // 
            panelTabs.Controls.Add(tabs1);
            panelTabs.Dock = DockStyle.Fill;
            panelTabs.Location = new Point(265, 5);
            panelTabs.Name = "panelTabs";
            panelTabs.Shadow = 2;
            panelTabs.Size = new Size(498, 462);
            panelTabs.TabIndex = 1;
            panelTabs.Text = "panel1";
            // 
            // tabs1
            // 
            tabs1.Dock = DockStyle.Fill;
            tabs1.Font = new Font("微软雅黑", 9F);
            tabs1.Gap = 12;
            tabs1.Location = new Point(2, 2);
            tabs1.Name = "tabs1";
            tabs1.Size = new Size(494, 458);
            styleCard1.Closable = true;
            tabs1.Style = styleCard1;
            tabs1.TabIndex = 0;
            tabs1.Type = AntdUI.TabType.Card;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(tlpMenu);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(5, 5);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(5);
            panelMenu.Shadow = 2;
            panelMenu.Size = new Size(260, 462);
            panelMenu.TabIndex = 0;
            panelMenu.Text = "panel1";
            // 
            // tlpMenu
            // 
            tlpMenu.ColumnCount = 1;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenu.Controls.Add(menu1, 0, 2);
            tlpMenu.Controls.Add(panelMenuHeader, 0, 0);
            tlpMenu.Controls.Add(divider1, 0, 1);
            tlpMenu.Dock = DockStyle.Fill;
            tlpMenu.Location = new Point(7, 7);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 3;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenu.Size = new Size(246, 448);
            tlpMenu.TabIndex = 2;
            // 
            // menu1
            // 
            menu1.AutoCollapse = true;
            menu1.Dock = DockStyle.Fill;
            menu1.Indent = true;
            menu1.Location = new Point(3, 73);
            menu1.Name = "menu1";
            menu1.ShowSubBack = true;
            menu1.Size = new Size(240, 372);
            menu1.TabIndex = 0;
            menu1.Text = "menu1";
            // 
            // panelMenuHeader
            // 
            panelMenuHeader.Controls.Add(inputMenuSearch);
            panelMenuHeader.Controls.Add(btnMenuCollapsed);
            panelMenuHeader.Dock = DockStyle.Fill;
            panelMenuHeader.Location = new Point(3, 3);
            panelMenuHeader.Name = "panelMenuHeader";
            panelMenuHeader.Size = new Size(240, 44);
            panelMenuHeader.TabIndex = 1;
            panelMenuHeader.Text = "panel1";
            // 
            // inputMenuSearch
            // 
            inputMenuSearch.Dock = DockStyle.Fill;
            inputMenuSearch.IconRatio = 1F;
            inputMenuSearch.Location = new Point(50, 0);
            inputMenuSearch.Name = "inputMenuSearch";
            inputMenuSearch.PlaceholderText = "搜索菜单";
            inputMenuSearch.PrefixSvg = resources.GetString("inputMenuSearch.PrefixSvg");
            inputMenuSearch.Size = new Size(190, 44);
            inputMenuSearch.SuffixSvg = resources.GetString("inputMenuSearch.SuffixSvg");
            inputMenuSearch.TabIndex = 1;
            // 
            // btnMenuCollapsed
            // 
            btnMenuCollapsed.Dock = DockStyle.Left;
            btnMenuCollapsed.IconRatio = 1F;
            btnMenuCollapsed.IconSvg = resources.GetString("btnMenuCollapsed.IconSvg");
            btnMenuCollapsed.Location = new Point(0, 0);
            btnMenuCollapsed.Name = "btnMenuCollapsed";
            btnMenuCollapsed.Size = new Size(50, 44);
            btnMenuCollapsed.TabIndex = 0;
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Fill;
            divider1.Location = new Point(3, 53);
            divider1.Name = "divider1";
            divider1.Size = new Size(240, 14);
            divider1.TabIndex = 2;
            // 
            // tipB
            // 
            tipB.ArrowAlign = AntdUI.TAlign.Bottom;
            // 
            // HamburgerMenuTabs
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Name = "HamburgerMenuTabs";
            Size = new Size(768, 472);
            panelMain.ResumeLayout(false);
            panelTabs.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            tlpMenu.ResumeLayout(false);
            panelMenuHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panelMain;
        private AntdUI.Panel panelTabs;
        private AntdUI.Tabs tabs1;
        private AntdUI.Panel panelMenu;
        private TableLayoutPanel tlpMenu;
        private AntdUI.Menu menu1;
        private AntdUI.Panel panelMenuHeader;
        private AntdUI.Input inputMenuSearch;
        private AntdUI.Button btnMenuCollapsed;
        private AntdUI.TooltipComponent tipB;
        private AntdUI.Divider divider1;
    }
}