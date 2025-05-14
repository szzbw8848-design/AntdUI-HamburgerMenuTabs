namespace AntdUI_HamburgerMenuTabs.Pages.Demo
{
    partial class Tour
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
            gridPanel1 = new AntdUI.GridPanel();
            this.btn2 = new AntdUI.Button();
            this.btn1 = new AntdUI.Button();
            btnTour = new AntdUI.Button();
            slider1 = new AntdUI.Slider();
            calendar1 = new AntdUI.Calendar();
            gridPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(calendar1);
            gridPanel1.Controls.Add(slider1);
            gridPanel1.Controls.Add(this.btn2);
            gridPanel1.Controls.Add(this.btn1);
            gridPanel1.Controls.Add(btnTour);
            gridPanel1.Dock = DockStyle.Fill;
            gridPanel1.Gap = 5;
            gridPanel1.Location = new Point(0, 0);
            gridPanel1.Margin = new Padding(4, 4, 4, 4);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(890, 528);
            gridPanel1.Span = "100%;50% 50%;100%;100%;-70 70 50 100%";
            gridPanel1.TabIndex = 0;
            gridPanel1.Text = "gridPanel1";
            // 
            // btn2
            // 
            this.btn2.Location = new Point(454, 79);
            this.btn2.Margin = new Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new Size(427, 52);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "步骤 2";
            // 
            // btn1
            // 
            this.btn1.Location = new Point(9, 79);
            this.btn1.Margin = new Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new Size(427, 52);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "步骤 1";
            // 
            // btnTour
            // 
            btnTour.IconSvg = "BookFilled";
            btnTour.Location = new Point(9, 9);
            btnTour.Margin = new Padding(4, 4, 4, 4);
            btnTour.Name = "btnTour";
            btnTour.Size = new Size(872, 52);
            btnTour.TabIndex = 3;
            btnTour.Text = "引导";
            // 
            // slider1
            // 
            slider1.Location = new Point(9, 149);
            slider1.Margin = new Padding(4, 4, 4, 4);
            slider1.Name = "slider1";
            slider1.Size = new Size(872, 32);
            slider1.TabIndex = 4;
            slider1.Text = "slider1";
            // 
            // calendar1
            // 
            calendar1.Location = new Point(9, 199);
            calendar1.Margin = new Padding(4, 4, 4, 4);
            calendar1.Name = "calendar1";
            calendar1.Size = new Size(872, 320);
            calendar1.TabIndex = 5;
            calendar1.Text = "calendar1";
            calendar1.Value = new DateTime(2025, 2, 14, 13, 41, 59, 516);
            // 
            // Tour
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridPanel1);
            Font = new Font("微软雅黑", 11F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Tour";
            Size = new Size(890, 528);
            gridPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Button btn1;
        private AntdUI.Button btn2;
        private AntdUI.Chat.ChatList chatList1;
        private AntdUI.Slider slider1;
        private AntdUI.Button btnTour;
        private AntdUI.Calendar calendar1;
    }
}
