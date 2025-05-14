namespace AntdUI_HamburgerMenuTabs.Pages.Tools
{
    partial class RandomCode
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
            inputRes = new AntdUI.Input();
            btnGenerate = new AntdUI.Button();
            inputCnt = new AntdUI.InputNumber();
            lbCnt = new AntdUI.Label();
            inputLen = new AntdUI.InputNumber();
            lbLen = new AntdUI.Label();
            panelPool = new AntdUI.Panel();
            checkSpecial = new AntdUI.Checkbox();
            checkNum = new AntdUI.Checkbox();
            checkLower = new AntdUI.Checkbox();
            checkUpper = new AntdUI.Checkbox();
            lbPool = new AntdUI.Label();
            gridPanelMain.SuspendLayout();
            panelPool.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanelMain
            // 
            gridPanelMain.Controls.Add(inputRes);
            gridPanelMain.Controls.Add(btnGenerate);
            gridPanelMain.Controls.Add(inputCnt);
            gridPanelMain.Controls.Add(lbCnt);
            gridPanelMain.Controls.Add(inputLen);
            gridPanelMain.Controls.Add(lbLen);
            gridPanelMain.Controls.Add(panelPool);
            gridPanelMain.Controls.Add(lbPool);
            gridPanelMain.Dock = DockStyle.Fill;
            gridPanelMain.Gap = 2;
            gridPanelMain.Location = new Point(0, 0);
            gridPanelMain.Name = "gridPanelMain";
            gridPanelMain.Size = new Size(703, 472);
            gridPanelMain.Span = "80 100%;80 100%;80 100%;100%;100%;-50 50 50 50 100%";
            gridPanelMain.TabIndex = 0;
            gridPanelMain.Text = "gridPanel1";
            // 
            // inputRes
            // 
            inputRes.AllowClear = true;
            inputRes.AutoScroll = true;
            inputRes.Location = new Point(2, 202);
            inputRes.Margin = new Padding(0);
            inputRes.Multiline = true;
            inputRes.Name = "inputRes";
            inputRes.Size = new Size(699, 268);
            inputRes.TabIndex = 7;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            btnGenerate.IconRatio = 1F;
            btnGenerate.IconSvg = "SlackSquareFilled";
            btnGenerate.Location = new Point(5, 155);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(693, 40);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "生成";
            btnGenerate.Type = AntdUI.TTypeMini.Primary;
            btnGenerate.WaveSize = 0;
            // 
            // inputCnt
            // 
            inputCnt.IconGap = 0.5F;
            inputCnt.Location = new Point(82, 102);
            inputCnt.Margin = new Padding(0);
            inputCnt.MaximumSize = new Size(150, 0);
            inputCnt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputCnt.Name = "inputCnt";
            inputCnt.PrefixSvg = "ReloadOutlined";
            inputCnt.Size = new Size(150, 46);
            inputCnt.TabIndex = 5;
            inputCnt.Text = "1";
            inputCnt.ThousandsSeparator = true;
            inputCnt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbCnt
            // 
            lbCnt.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            lbCnt.Location = new Point(5, 105);
            lbCnt.Name = "lbCnt";
            lbCnt.Size = new Size(70, 40);
            lbCnt.TabIndex = 4;
            lbCnt.Text = "编码个数";
            // 
            // inputLen
            // 
            inputLen.IconGap = 0.5F;
            inputLen.Location = new Point(82, 52);
            inputLen.Margin = new Padding(0);
            inputLen.MaximumSize = new Size(150, 0);
            inputLen.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputLen.Name = "inputLen";
            inputLen.PrefixSvg = "ReloadOutlined";
            inputLen.Size = new Size(150, 46);
            inputLen.TabIndex = 3;
            inputLen.Text = "8";
            inputLen.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // lbLen
            // 
            lbLen.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            lbLen.Location = new Point(5, 55);
            lbLen.Name = "lbLen";
            lbLen.Size = new Size(70, 40);
            lbLen.TabIndex = 2;
            lbLen.Text = "编码长度";
            // 
            // panelPool
            // 
            panelPool.Controls.Add(checkSpecial);
            panelPool.Controls.Add(checkNum);
            panelPool.Controls.Add(checkLower);
            panelPool.Controls.Add(checkUpper);
            panelPool.Location = new Point(85, 5);
            panelPool.Name = "panelPool";
            panelPool.Padding = new Padding(3);
            panelPool.Size = new Size(613, 40);
            panelPool.TabIndex = 1;
            panelPool.Text = "panel1";
            // 
            // checkSpecial
            // 
            checkSpecial.AutoSizeMode = AntdUI.TAutoSize.Width;
            checkSpecial.Dock = DockStyle.Left;
            checkSpecial.Location = new Point(254, 3);
            checkSpecial.Name = "checkSpecial";
            checkSpecial.Size = new Size(92, 34);
            checkSpecial.TabIndex = 3;
            checkSpecial.Text = "特殊字符";
            // 
            // checkNum
            // 
            checkNum.AutoSizeMode = AntdUI.TAutoSize.Width;
            checkNum.Dock = DockStyle.Left;
            checkNum.Location = new Point(187, 3);
            checkNum.Name = "checkNum";
            checkNum.Size = new Size(67, 34);
            checkNum.TabIndex = 2;
            checkNum.Text = "数字";
            // 
            // checkLower
            // 
            checkLower.AutoSizeMode = AntdUI.TAutoSize.Width;
            checkLower.Dock = DockStyle.Left;
            checkLower.Location = new Point(95, 3);
            checkLower.Name = "checkLower";
            checkLower.Size = new Size(92, 34);
            checkLower.TabIndex = 1;
            checkLower.Text = "小写字母";
            // 
            // checkUpper
            // 
            checkUpper.AutoSizeMode = AntdUI.TAutoSize.Width;
            checkUpper.Dock = DockStyle.Left;
            checkUpper.Location = new Point(3, 3);
            checkUpper.Name = "checkUpper";
            checkUpper.Size = new Size(92, 34);
            checkUpper.TabIndex = 0;
            checkUpper.Text = "大写字母";
            // 
            // lbPool
            // 
            lbPool.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            lbPool.Location = new Point(5, 5);
            lbPool.Name = "lbPool";
            lbPool.Size = new Size(70, 40);
            lbPool.TabIndex = 0;
            lbPool.Text = "编码池";
            // 
            // RandomCode
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridPanelMain);
            Font = new Font("微软雅黑", 9F);
            Name = "RandomCode";
            Size = new Size(703, 472);
            gridPanelMain.ResumeLayout(false);
            panelPool.ResumeLayout(false);
            panelPool.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel gridPanelMain;
        private AntdUI.Label lbPool;
        private AntdUI.InputNumber inputLen;
        private AntdUI.Label lbLen;
        private AntdUI.Panel panelPool;
        private AntdUI.Checkbox checkSpecial;
        private AntdUI.Checkbox checkNum;
        private AntdUI.Checkbox checkLower;
        private AntdUI.Checkbox checkUpper;
        private AntdUI.InputNumber inputCnt;
        private AntdUI.Label lbCnt;
        private AntdUI.Button btnGenerate;
        private AntdUI.Input inputRes;
    }
}
