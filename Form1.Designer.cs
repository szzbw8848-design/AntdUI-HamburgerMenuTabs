namespace AntdUI_HamburgerMenuTabs
{
    partial class Form1
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
            panelMain = new AntdUI.Panel();
            hmt = new Uc.HamburgerMenuTabs();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // windowBar1
            // 
            windowBar1.Dock = DockStyle.Top;
            windowBar1.Location = new Point(0, 0);
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new Size(800, 30);
            windowBar1.TabIndex = 0;
            windowBar1.Text = "windowBar1";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(windowBar1);
            Font = new Font("微软雅黑", 9F);
            Name = "Form1";
            Text = "Form1";
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private AntdUI.Panel panelMain;
        private Uc.HamburgerMenuTabs hmt;
    }
}
