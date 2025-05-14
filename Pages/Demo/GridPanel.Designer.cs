namespace AntdUI_HamburgerMenuTabs.Pages.Demo
{
    partial class GridPanel
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
            panelGp = new AntdUI.Panel();
            gridPanel1 = new AntdUI.GridPanel();
            panelOpt = new AntdUI.Panel();
            btnMinus = new AntdUI.Button();
            btnAdd = new AntdUI.Button();
            btnLoad = new AntdUI.Button();
            btnClear = new AntdUI.Button();
            panelMain.SuspendLayout();
            panelGp.SuspendLayout();
            panelOpt.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelGp);
            panelMain.Controls.Add(panelOpt);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Radius = 0;
            panelMain.Size = new Size(662, 435);
            panelMain.TabIndex = 0;
            panelMain.Text = "panel1";
            // 
            // panelGp
            // 
            panelGp.Controls.Add(gridPanel1);
            panelGp.Dock = DockStyle.Fill;
            panelGp.Location = new Point(0, 60);
            panelGp.Name = "panelGp";
            panelGp.Padding = new Padding(5);
            panelGp.Shadow = 10;
            panelGp.ShadowOpacity = 0.2F;
            panelGp.ShadowOpacityAnimation = true;
            panelGp.ShadowOpacityHover = 0.8F;
            panelGp.Size = new Size(662, 375);
            panelGp.TabIndex = 2;
            panelGp.Text = "panel1";
            // 
            // gridPanel1
            // 
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(15, 15);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(632, 345);
            gridPanel1.TabIndex = 0;
            gridPanel1.Text = "gridPanel1";
            // 
            // panelOpt
            // 
            panelOpt.Controls.Add(btnClear);
            panelOpt.Controls.Add(btnMinus);
            panelOpt.Controls.Add(btnAdd);
            panelOpt.Controls.Add(btnLoad);
            panelOpt.Dock = DockStyle.Top;
            panelOpt.Location = new Point(0, 0);
            panelOpt.Name = "panelOpt";
            panelOpt.Padding = new Padding(5);
            panelOpt.Shadow = 10;
            panelOpt.ShadowOpacity = 0.2F;
            panelOpt.ShadowOpacityAnimation = true;
            panelOpt.ShadowOpacityHover = 0.8F;
            panelOpt.Size = new Size(662, 60);
            panelOpt.TabIndex = 1;
            panelOpt.Text = "panel1";
            // 
            // btnMinus
            // 
            btnMinus.Dock = DockStyle.Left;
            btnMinus.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            btnMinus.Ghost = true;
            btnMinus.IconSvg = "MinusOutlined";
            btnMinus.Location = new Point(215, 15);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(100, 30);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "减一个";
            btnMinus.Type = AntdUI.TTypeMini.Primary;
            btnMinus.WaveSize = 0;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Left;
            btnAdd.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            btnAdd.Ghost = true;
            btnAdd.IconSvg = "PlusOutlined";
            btnAdd.Location = new Point(115, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "加一个";
            btnAdd.Type = AntdUI.TTypeMini.Primary;
            btnAdd.WaveSize = 0;
            // 
            // btnLoad
            // 
            btnLoad.Dock = DockStyle.Left;
            btnLoad.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            btnLoad.Ghost = true;
            btnLoad.IconSvg = "ReloadOutlined";
            btnLoad.Location = new Point(15, 15);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 30);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "填满";
            btnLoad.Type = AntdUI.TTypeMini.Primary;
            btnLoad.WaveSize = 0;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Left;
            btnClear.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            btnClear.Ghost = true;
            btnClear.IconSvg = "DeleteOutlined";
            btnClear.Location = new Point(315, 15);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 30);
            btnClear.TabIndex = 3;
            btnClear.Text = "清空";
            btnClear.Type = AntdUI.TTypeMini.Primary;
            btnClear.WaveSize = 0;
            // 
            // GridPanel
            // 
            Controls.Add(panelMain);
            Font = new Font("微软雅黑", 9F);
            Name = "GridPanel";
            Size = new Size(662, 435);
            panelMain.ResumeLayout(false);
            panelGp.ResumeLayout(false);
            panelOpt.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panelMain;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Panel panelOpt;
        private AntdUI.Button btnLoad;
        private AntdUI.Panel panelGp;
        private AntdUI.Button btnMinus;
        private AntdUI.Button btnAdd;
        private AntdUI.Button btnClear;
    }
}
