namespace AntdUI_HamburgerMenuTabs.Pages.Tools
{
    partial class PerformanceMonitor
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
            gridPanelMain = new AntdUI.GridPanel();
            input1 = new AntdUI.Input();
            btnMemClear = new AntdUI.Button();
            inputMem = new AntdUI.InputNumber();
            lbMem = new AntdUI.Label();
            lbInfo = new AntdUI.Label();
            inputInterval = new AntdUI.InputNumber();
            checkAutoRefresh = new AntdUI.Checkbox();
            btnRefresh = new AntdUI.Button();
            tipB = new AntdUI.TooltipComponent();
            lbMem2 = new AntdUI.Label();
            gridPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanelMain
            // 
            gridPanelMain.Controls.Add(input1);
            gridPanelMain.Controls.Add(lbMem2);
            gridPanelMain.Controls.Add(btnMemClear);
            gridPanelMain.Controls.Add(inputMem);
            gridPanelMain.Controls.Add(lbMem);
            gridPanelMain.Controls.Add(lbInfo);
            gridPanelMain.Controls.Add(inputInterval);
            gridPanelMain.Controls.Add(checkAutoRefresh);
            gridPanelMain.Controls.Add(btnRefresh);
            gridPanelMain.Dock = DockStyle.Fill;
            gridPanelMain.Gap = 2;
            gridPanelMain.Location = new Point(0, 0);
            gridPanelMain.Name = "gridPanelMain";
            gridPanelMain.Size = new Size(627, 397);
            gridPanelMain.Span = "50 100 120 100%;80 150 40 100%;100%;-50 50 100%";
            gridPanelMain.TabIndex = 0;
            gridPanelMain.Text = "gridPanel1";
            // 
            // input1
            // 
            input1.Location = new Point(5, 105);
            input1.Multiline = true;
            input1.Name = "input1";
            input1.ReadOnly = true;
            input1.Size = new Size(617, 287);
            input1.TabIndex = 15;
            // 
            // btnMemClear
            // 
            btnMemClear.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            btnMemClear.Ghost = true;
            btnMemClear.IconRatio = 1F;
            btnMemClear.IconSvg = "DeleteFilled";
            btnMemClear.Location = new Point(235, 55);
            btnMemClear.Name = "btnMemClear";
            btnMemClear.Size = new Size(30, 40);
            btnMemClear.TabIndex = 14;
            tipB.SetTip(btnMemClear, "清理内存");
            btnMemClear.WaveSize = 0;
            // 
            // inputMem
            // 
            inputMem.Location = new Point(82, 52);
            inputMem.Margin = new Padding(0);
            inputMem.Name = "inputMem";
            inputMem.ReadOnly = true;
            inputMem.Size = new Size(146, 46);
            inputMem.SuffixText = "B";
            inputMem.TabIndex = 13;
            inputMem.Text = "0";
            // 
            // lbMem
            // 
            lbMem.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            lbMem.Location = new Point(5, 55);
            lbMem.Name = "lbMem";
            lbMem.Size = new Size(70, 40);
            lbMem.TabIndex = 12;
            lbMem.Text = "内存";
            // 
            // lbInfo
            // 
            lbInfo.Location = new Point(275, 5);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(347, 40);
            lbInfo.TabIndex = 11;
            // 
            // inputInterval
            // 
            inputInterval.Location = new Point(152, 2);
            inputInterval.Margin = new Padding(0);
            inputInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputInterval.Name = "inputInterval";
            inputInterval.PrefixText = "间隔";
            inputInterval.Size = new Size(116, 46);
            inputInterval.SuffixText = "秒";
            inputInterval.TabIndex = 10;
            inputInterval.Text = "3";
            inputInterval.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // checkAutoRefresh
            // 
            checkAutoRefresh.Location = new Point(55, 5);
            checkAutoRefresh.Name = "checkAutoRefresh";
            checkAutoRefresh.Size = new Size(90, 40);
            checkAutoRefresh.TabIndex = 8;
            checkAutoRefresh.Text = "自动刷新";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            btnRefresh.Ghost = true;
            btnRefresh.IconRatio = 1F;
            btnRefresh.IconSvg = "ReloadOutlined";
            btnRefresh.Location = new Point(5, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 40);
            btnRefresh.TabIndex = 7;
            btnRefresh.Type = AntdUI.TTypeMini.Primary;
            btnRefresh.WaveSize = 0;
            // 
            // tipB
            // 
            tipB.ArrowAlign = AntdUI.TAlign.Bottom;
            // 
            // lbMem2
            // 
            lbMem2.AutoEllipsis = true;
            lbMem2.Location = new Point(275, 55);
            lbMem2.Name = "lbMem2";
            lbMem2.Size = new Size(347, 40);
            lbMem2.TabIndex = 16;
            // 
            // PerformanceMonitor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridPanelMain);
            Font = new Font("微软雅黑", 9F);
            Name = "PerformanceMonitor";
            Size = new Size(627, 397);
            gridPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel gridPanelMain;
        private AntdUI.Button btnRefresh;
        private AntdUI.Checkbox checkAutoRefresh;
        private AntdUI.Label lbInfo;
        private AntdUI.InputNumber inputInterval;
        private AntdUI.InputNumber inputMem;
        private AntdUI.Label lbMem;
        private AntdUI.Button btnMemClear;
        private AntdUI.TooltipComponent tipB;
        private AntdUI.Input input1;
        private AntdUI.Label lbMem2;
    }
}
