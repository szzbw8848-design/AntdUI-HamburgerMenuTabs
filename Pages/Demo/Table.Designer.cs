namespace AntdUI_HamburgerMenuTabs.Pages.Demo
{
    partial class Table
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
            panelMain = new Panel();
            gridPanel1 = new AntdUI.GridPanel();
            splitter1 = new AntdUI.Splitter();
            table1 = new AntdUI.Table();
            propertyGrid1 = new PropertyGrid();
            gridPanel2 = new AntdUI.GridPanel();
            btnRebinding = new AntdUI.Button();
            gridPanelDataSource = new AntdUI.GridPanel();
            radioDs2 = new AntdUI.Radio();
            radioDs1 = new AntdUI.Radio();
            lbDs = new AntdUI.Label();
            inputSearch = new AntdUI.Input();
            btnMinus = new AntdUI.Button();
            btnAdd = new AntdUI.Button();
            btnGetData = new AntdUI.Button();
            panelMain.SuspendLayout();
            gridPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitter1).BeginInit();
            splitter1.Panel1.SuspendLayout();
            splitter1.Panel2.SuspendLayout();
            splitter1.SuspendLayout();
            gridPanel2.SuspendLayout();
            gridPanelDataSource.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(gridPanel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(5);
            panelMain.Size = new Size(847, 489);
            panelMain.TabIndex = 0;
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(splitter1);
            gridPanel1.Controls.Add(gridPanel2);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(5, 5);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(837, 479);
            gridPanel1.Span = "100%;100%;-50 100%";
            gridPanel1.TabIndex = 0;
            gridPanel1.Text = "gridPanel1";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Fill;
            splitter1.FixedPanel = FixedPanel.Panel2;
            splitter1.Location = new Point(3, 53);
            splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            splitter1.Panel1.Controls.Add(table1);
            splitter1.Panel1.Padding = new Padding(5);
            splitter1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitter1.Panel2
            // 
            splitter1.Panel2.Controls.Add(propertyGrid1);
            splitter1.Panel2.Padding = new Padding(5);
            splitter1.Panel2.RightToLeft = RightToLeft.No;
            splitter1.Panel2MinSize = 350;
            splitter1.Size = new Size(831, 423);
            splitter1.SplitterDistance = 462;
            splitter1.TabIndex = 1;
            // 
            // table1
            // 
            table1.Dock = DockStyle.Fill;
            table1.Location = new Point(5, 5);
            table1.Name = "table1";
            table1.Size = new Size(452, 413);
            table1.TabIndex = 0;
            table1.Text = "table1";
            // 
            // propertyGrid1
            // 
            propertyGrid1.BackColor = SystemColors.Control;
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(5, 5);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.PropertySort = PropertySort.Alphabetical;
            propertyGrid1.SelectedObject = table1;
            propertyGrid1.Size = new Size(355, 413);
            propertyGrid1.TabIndex = 0;
            // 
            // gridPanel2
            // 
            gridPanel2.Controls.Add(btnRebinding);
            gridPanel2.Controls.Add(gridPanelDataSource);
            gridPanel2.Controls.Add(lbDs);
            gridPanel2.Controls.Add(inputSearch);
            gridPanel2.Controls.Add(btnMinus);
            gridPanel2.Controls.Add(btnAdd);
            gridPanel2.Controls.Add(btnGetData);
            gridPanel2.Location = new Point(3, 3);
            gridPanel2.Name = "gridPanel2";
            gridPanel2.Size = new Size(831, 44);
            gridPanel2.Span = "45 45 45 200 60 230 100 100%";
            gridPanel2.TabIndex = 0;
            gridPanel2.Text = "gridPanel2";
            // 
            // btnRebinding
            // 
            btnRebinding.Location = new Point(628, 3);
            btnRebinding.Name = "btnRebinding";
            btnRebinding.Size = new Size(94, 38);
            btnRebinding.TabIndex = 6;
            btnRebinding.Text = "重绑数据源";
            btnRebinding.Type = AntdUI.TTypeMini.Primary;
            // 
            // gridPanelDataSource
            // 
            gridPanelDataSource.Controls.Add(radioDs2);
            gridPanelDataSource.Controls.Add(radioDs1);
            gridPanelDataSource.Location = new Point(398, 3);
            gridPanelDataSource.Name = "gridPanelDataSource";
            gridPanelDataSource.Size = new Size(224, 38);
            gridPanelDataSource.Span = "50% 50%";
            gridPanelDataSource.TabIndex = 5;
            gridPanelDataSource.Text = "gridPanel3";
            // 
            // radioDs2
            // 
            radioDs2.Checked = true;
            radioDs2.Location = new Point(115, 3);
            radioDs2.Name = "radioDs2";
            radioDs2.Size = new Size(106, 32);
            radioDs2.TabIndex = 1;
            radioDs2.Text = "BingdingList";
            // 
            // radioDs1
            // 
            radioDs1.Location = new Point(3, 3);
            radioDs1.Name = "radioDs1";
            radioDs1.Size = new Size(106, 32);
            radioDs1.TabIndex = 0;
            radioDs1.Text = "DataTable";
            // 
            // lbDs
            // 
            lbDs.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            lbDs.Location = new Point(338, 3);
            lbDs.Name = "lbDs";
            lbDs.Size = new Size(54, 38);
            lbDs.TabIndex = 4;
            lbDs.Text = "数据源：";
            lbDs.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputSearch
            // 
            inputSearch.AllowClear = true;
            inputSearch.IconRatio = 1F;
            inputSearch.Location = new Point(138, 3);
            inputSearch.Name = "inputSearch";
            inputSearch.PlaceholderText = "查找...";
            inputSearch.PrefixSvg = "SearchOutlined";
            inputSearch.Size = new Size(194, 38);
            inputSearch.TabIndex = 2;
            // 
            // btnMinus
            // 
            btnMinus.IconSvg = "MinusOutlined";
            btnMinus.Location = new Point(93, 3);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(39, 38);
            btnMinus.TabIndex = 3;
            btnMinus.Type = AntdUI.TTypeMini.Primary;
            // 
            // btnAdd
            // 
            btnAdd.IconSvg = "PlusOutlined";
            btnAdd.Location = new Point(48, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(39, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Type = AntdUI.TTypeMini.Primary;
            // 
            // btnGetData
            // 
            btnGetData.IconSvg = "RedoOutlined";
            btnGetData.Location = new Point(3, 3);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(39, 38);
            btnGetData.TabIndex = 0;
            btnGetData.Type = AntdUI.TTypeMini.Primary;
            // 
            // Table
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Font = new Font("微软雅黑", 9F);
            Name = "Table";
            Size = new Size(847, 489);
            panelMain.ResumeLayout(false);
            gridPanel1.ResumeLayout(false);
            splitter1.Panel1.ResumeLayout(false);
            splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter1).EndInit();
            splitter1.ResumeLayout(false);
            gridPanel2.ResumeLayout(false);
            gridPanelDataSource.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Splitter splitter1;
        private AntdUI.Table table1;
        private PropertyGrid propertyGrid1;
        private AntdUI.GridPanel gridPanel2;
        private AntdUI.Button btnGetData;
        private AntdUI.Button btnAdd;
        private AntdUI.Input inputSearch;
        private AntdUI.Button btnMinus;
        private AntdUI.Label lbDs;
        private AntdUI.GridPanel gridPanelDataSource;
        private AntdUI.Radio radioDs2;
        private AntdUI.Radio radioDs1;
        private AntdUI.Button btnRebinding;
    }
}
