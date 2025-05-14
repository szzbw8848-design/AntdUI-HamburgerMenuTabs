namespace AntdUI_HamburgerMenuTabs.Uc
{
    partial class TourPopover
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
            lbTitle = new AntdUI.Label();
            lbStep = new AntdUI.Label();
            lbContent = new AntdUI.Label();
            btnPrevious = new AntdUI.Button();
            btnNext = new AntdUI.Button();
            btnClose = new AntdUI.Button();
            gridPanelMain = new AntdUI.GridPanel();
            gridPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("微软雅黑", 16F, FontStyle.Bold);
            gridPanelMain.SetIndex(lbTitle, 1);
            lbTitle.Location = new Point(3, 3);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(400, 44);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "标题";
            // 
            // lbStep
            // 
            gridPanelMain.SetIndex(lbStep, 2);
            lbStep.Location = new Point(3, 211);
            lbStep.Name = "lbStep";
            lbStep.Size = new Size(250, 34);
            lbStep.TabIndex = 0;
            lbStep.Text = "步骤";
            // 
            // lbContent
            // 
            lbContent.Font = new Font("微软雅黑", 12F);
            gridPanelMain.SetIndex(lbContent, 1);
            lbContent.Location = new Point(3, 53);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(400, 152);
            lbContent.TabIndex = 0;
            lbContent.Text = "内容";
            // 
            // btnPrevious
            // 
            btnPrevious.AutoSizeMode = AntdUI.TAutoSize.Width;
            btnPrevious.Ghost = true;
            gridPanelMain.SetIndex(btnPrevious, 3);
            btnPrevious.LocalizationText = "Previous";
            btnPrevious.Location = new Point(259, 211);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(62, 34);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "上一步";
            btnPrevious.Type = AntdUI.TTypeMini.Primary;
            btnPrevious.WaveSize = 0;
            // 
            // btnNext
            // 
            btnNext.AutoSizeMode = AntdUI.TAutoSize.Width;
            btnNext.Ghost = true;
            gridPanelMain.SetIndex(btnNext, 4);
            btnNext.LocalizationText = "Next";
            btnNext.Location = new Point(309, 211);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(62, 34);
            btnNext.TabIndex = 1;
            btnNext.Text = "下一步";
            btnNext.Type = AntdUI.TTypeMini.Primary;
            btnNext.WaveSize = 0;
            // 
            // btnClose
            // 
            btnClose.AutoSizeMode = AntdUI.TAutoSize.Width;
            btnClose.Ghost = true;
            btnClose.IconSvg = "CloseOutlined";
            gridPanelMain.SetIndex(btnClose, 5);
            btnClose.Location = new Point(359, 211);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 34);
            btnClose.TabIndex = 3;
            btnClose.Type = AntdUI.TTypeMini.Error;
            btnClose.WaveSize = 0;
            // 
            // gridPanelMain
            // 
            gridPanelMain.Controls.Add(btnClose);
            gridPanelMain.Controls.Add(btnPrevious);
            gridPanelMain.Controls.Add(btnNext);
            gridPanelMain.Controls.Add(lbStep);
            gridPanelMain.Controls.Add(lbContent);
            gridPanelMain.Controls.Add(lbTitle);
            gridPanelMain.Dock = DockStyle.Fill;
            gridPanelMain.Location = new Point(0, 0);
            gridPanelMain.Name = "gridPanelMain";
            gridPanelMain.Size = new Size(406, 248);
            gridPanelMain.Span = "100%;100%;100% 50 50 50;-50 100% 40";
            gridPanelMain.TabIndex = 6;
            gridPanelMain.Text = "gridPanel2";
            // 
            // TourPopover
            // 
            Controls.Add(gridPanelMain);
            Font = new Font("微软雅黑", 9F);
            Name = "TourPopover";
            Size = new Size(406, 248);
            gridPanelMain.ResumeLayout(false);
            gridPanelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label lbTitle;
        private AntdUI.Label lbStep;
        private AntdUI.Label lbContent;
        private AntdUI.Button btnPrevious;
        private AntdUI.Button btnNext;
        private AntdUI.Button btnClose;
        private AntdUI.GridPanel gridPanelMain;
    }
}