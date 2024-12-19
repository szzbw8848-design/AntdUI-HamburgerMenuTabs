namespace AntdUI_HamburgerMenuTabs
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            windowBar1 = new AntdUI.WindowBar();
            btnFullScreen = new AntdUI.Button();
            panelMain = new AntdUI.Panel();
            hmt = new Uc.HamburgerMenuTabs();
            tip1 = new AntdUI.TooltipComponent();
            btnTheme = new AntdUI.Button();
            windowBar1.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // windowBar1
            // 
            windowBar1.Controls.Add(btnTheme);
            windowBar1.Controls.Add(btnFullScreen);
            windowBar1.Dock = DockStyle.Top;
            windowBar1.Location = new Point(0, 0);
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new Size(800, 30);
            windowBar1.TabIndex = 0;
            windowBar1.Text = "windowBar1";
            // 
            // btnFullScreen
            // 
            btnFullScreen.Dock = DockStyle.Right;
            btnFullScreen.Ghost = true;
            btnFullScreen.IconSvg = "ExpandOutlined";
            btnFullScreen.Location = new Point(626, 0);
            btnFullScreen.Name = "btnFullScreen";
            btnFullScreen.Size = new Size(30, 30);
            btnFullScreen.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(hmt);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 420);
            panelMain.TabIndex = 1;
            panelMain.Text = "panel1";
            // 
            // hmt
            // 
            hmt.Dock = DockStyle.Fill;
            hmt.Location = new Point(0, 0);
            hmt.Name = "hmt";
            hmt.Size = new Size(800, 420);
            hmt.TabIndex = 0;
            // 
            // tip1
            // 
            tip1.ArrowAlign = AntdUI.TAlign.Bottom;
            tip1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btnTheme
            // 
            btnTheme.Dock = DockStyle.Right;
            btnTheme.Ghost = true;
            btnTheme.IconSvg = "MoonOutlined";
            btnTheme.Location = new Point(596, 0);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(30, 30);
            btnTheme.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(windowBar1);
            Font = new Font("微软雅黑", 9F);
            Name = "FrmMain";
            Text = "Form1";
            windowBar1.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private AntdUI.Panel panelMain;
        private Uc.HamburgerMenuTabs hmt;
        private AntdUI.Button btnFullScreen;
        private AntdUI.TooltipComponent tip1;
        private AntdUI.Button btnTheme;
    }
}
