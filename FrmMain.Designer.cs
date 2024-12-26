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
            btnTheme = new AntdUI.Button();
            btnFullScreen = new AntdUI.Button();
            panelMain = new AntdUI.Panel();
            tipB = new AntdUI.TooltipComponent();
            windowBar1.SuspendLayout();
            SuspendLayout();
            // 
            // windowBar1
            // 
            windowBar1.Controls.Add(btnTheme);
            windowBar1.Controls.Add(btnFullScreen);
            windowBar1.Dock = DockStyle.Top;
            windowBar1.Location = new Point(0, 0);
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new Size(800, 40);
            windowBar1.TabIndex = 0;
            windowBar1.Text = "windowBar1";
            // 
            // btnTheme
            // 
            btnTheme.Dock = DockStyle.Right;
            btnTheme.Ghost = true;
            btnTheme.IconSvg = "MoonOutlined";
            btnTheme.Location = new Point(576, 0);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(40, 40);
            btnTheme.TabIndex = 1;
            // 
            // btnFullScreen
            // 
            btnFullScreen.Dock = DockStyle.Right;
            btnFullScreen.Ghost = true;
            btnFullScreen.IconSvg = "ExpandOutlined";
            btnFullScreen.Location = new Point(616, 0);
            btnFullScreen.Name = "btnFullScreen";
            btnFullScreen.Size = new Size(40, 40);
            btnFullScreen.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 40);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 410);
            panelMain.TabIndex = 1;
            panelMain.Text = "panel1";
            // 
            // tipB
            // 
            tipB.ArrowAlign = AntdUI.TAlign.Bottom;
            tipB.CustomWidth = 300;
            tipB.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
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
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private AntdUI.Panel panelMain;
        private AntdUI.Button btnFullScreen;
        private AntdUI.TooltipComponent tipB;
        private AntdUI.Button btnTheme;
    }
}
