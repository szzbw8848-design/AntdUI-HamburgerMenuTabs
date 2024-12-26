namespace AntdUI_HamburgerMenuTabs.Pages
{
    partial class Home
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
            gridPanel1 = new AntdUI.GridPanel();
            panelTime = new AntdUI.Panel();
            lbTime = new AntdUI.Label();
            panelInfo = new AntdUI.Panel();
            lbInfo = new AntdUI.Label();
            panelMain.SuspendLayout();
            gridPanel1.SuspendLayout();
            panelTime.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(gridPanel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(585, 333);
            panelMain.TabIndex = 0;
            panelMain.Text = "panel1";
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(panelTime);
            gridPanel1.Controls.Add(panelInfo);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(585, 333);
            gridPanel1.Span = "100%;100%";
            gridPanel1.TabIndex = 1;
            gridPanel1.Text = "gridPanel1";
            // 
            // panelTime
            // 
            panelTime.Controls.Add(lbTime);
            panelTime.Location = new Point(3, 169);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(579, 160);
            panelTime.TabIndex = 4;
            panelTime.Text = "panel1";
            // 
            // lbTime
            // 
            lbTime.Dock = DockStyle.Fill;
            lbTime.Font = new Font("方正姚体", 30F, FontStyle.Bold);
            lbTime.Location = new Point(0, 0);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(579, 160);
            lbTime.TabIndex = 0;
            lbTime.Text = "0000 年 0 月 0 日 00:00:00";
            lbTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(lbInfo);
            panelInfo.Location = new Point(3, 3);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(579, 160);
            panelInfo.TabIndex = 3;
            panelInfo.Text = "panel1";
            // 
            // lbInfo
            // 
            lbInfo.Dock = DockStyle.Fill;
            lbInfo.Font = new Font("方正姚体", 60F, FontStyle.Bold);
            lbInfo.Location = new Point(0, 0);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(579, 160);
            lbInfo.TabIndex = 2;
            lbInfo.Text = "主页";
            lbInfo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Font = new Font("微软雅黑", 9F);
            Name = "Home";
            Size = new Size(585, 333);
            panelMain.ResumeLayout(false);
            gridPanel1.ResumeLayout(false);
            panelTime.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panelMain;
        private AntdUI.Label lbTime;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Panel panelTime;
        private AntdUI.Panel panelInfo;
        private AntdUI.Label lbInfo;
    }
}