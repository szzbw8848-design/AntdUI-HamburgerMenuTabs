namespace AntdUI_HamburgerMenuTabs.Pages.Demo
{
    partial class Tree
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
            panelMain = new AntdUI.Panel();
            splitter1 = new AntdUI.Splitter();
            tree1 = new AntdUI.Tree();
            propertyGrid1 = new PropertyGrid();
            inputDir = new AntdUI.Input();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitter1).BeginInit();
            splitter1.Panel1.SuspendLayout();
            splitter1.Panel2.SuspendLayout();
            splitter1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(splitter1);
            panelMain.Controls.Add(inputDir);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(5);
            panelMain.Size = new Size(685, 423);
            panelMain.TabIndex = 0;
            panelMain.Text = "panel1";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Fill;
            splitter1.FixedPanel = FixedPanel.Panel2;
            splitter1.Location = new Point(5, 47);
            splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            splitter1.Panel1.Controls.Add(tree1);
            splitter1.Panel1.Padding = new Padding(5);
            // 
            // splitter1.Panel2
            // 
            splitter1.Panel2.Controls.Add(propertyGrid1);
            splitter1.Panel2.Padding = new Padding(5);
            splitter1.Size = new Size(675, 371);
            splitter1.SplitterDistance = 350;
            splitter1.TabIndex = 3;
            // 
            // tree1
            // 
            tree1.Dock = DockStyle.Fill;
            tree1.Location = new Point(5, 5);
            tree1.Name = "tree1";
            tree1.Size = new Size(340, 361);
            tree1.TabIndex = 1;
            tree1.Text = "tree1";
            // 
            // propertyGrid1
            // 
            propertyGrid1.BackColor = SystemColors.Control;
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(5, 5);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.SelectedObject = tree1;
            propertyGrid1.Size = new Size(311, 361);
            propertyGrid1.TabIndex = 2;
            // 
            // inputDir
            // 
            inputDir.Dock = DockStyle.Top;
            inputDir.IconRatio = 1F;
            inputDir.Location = new Point(5, 5);
            inputDir.Name = "inputDir";
            inputDir.PlaceholderText = "文件夹路径";
            inputDir.PrefixSvg = "FolderOpenFilled";
            inputDir.Size = new Size(675, 42);
            inputDir.SuffixSvg = "ReloadOutlined";
            inputDir.TabIndex = 0;
            // 
            // Tree
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Font = new Font("微软雅黑", 9F);
            Name = "Tree";
            Size = new Size(685, 423);
            panelMain.ResumeLayout(false);
            splitter1.Panel1.ResumeLayout(false);
            splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitter1).EndInit();
            splitter1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panelMain;
        private PropertyGrid propertyGrid1;
        private AntdUI.Tree tree1;
        private AntdUI.Input inputDir;
        private AntdUI.Splitter splitter1;
    }
}
