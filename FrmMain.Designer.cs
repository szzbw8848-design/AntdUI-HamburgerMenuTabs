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
            winBar = new AntdUI.PageHeader();
            colorTheme = new AntdUI.ColorPicker();
            btnTheme = new AntdUI.Button();
            btnFullScreen = new AntdUI.Button();
            panelMain = new AntdUI.Panel();
            tipB = new AntdUI.TooltipComponent();
            winBar.SuspendLayout();
            SuspendLayout();
            // 
            // winBar
            // 
            winBar.Controls.Add(colorTheme);
            winBar.Controls.Add(btnTheme);
            winBar.Controls.Add(btnFullScreen);
            winBar.Dock = DockStyle.Top;
            winBar.Location = new Point(0, 0);
            winBar.Name = "winBar";
            winBar.ShowButton = true;
            winBar.ShowIcon = true;
            winBar.Size = new Size(800, 40);
            winBar.TabIndex = 0;
            // 
            // colorTheme
            // 
            colorTheme.Dock = DockStyle.Right;
            colorTheme.Location = new Point(488, 0);
            colorTheme.Name = "colorTheme";
            colorTheme.Padding = new Padding(8);
            colorTheme.Round = true;
            colorTheme.ShowClose = true;
            colorTheme.Size = new Size(40, 40);
            colorTheme.TabIndex = 5;
            colorTheme.Value = Color.FromArgb(22, 119, 255);
            colorTheme.WaveSize = 0;
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
            panelMain.Radius = 0;
            panelMain.Size = new Size(800, 410);
            panelMain.TabIndex = 1;
            // 
            // tipB
            // 
            tipB.ArrowAlign = AntdUI.TAlign.Bottom;
            tipB.CustomWidth = 300;
            tipB.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // FrmMain
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(winBar);
            Font = new Font("微软雅黑", 9F);
            Name = "FrmMain";
            Text = "Form1";
            winBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader winBar;
        private AntdUI.Panel panelMain;
        private AntdUI.Button btnFullScreen;
        private AntdUI.TooltipComponent tipB;
        private AntdUI.Button btnTheme;
        private AntdUI.ColorPicker colorTheme;
    }
}
