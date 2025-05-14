using System.Diagnostics;

namespace AntdUI_HamburgerMenuTabs.Pages.Tools
{
    public partial class PerformanceMonitor : UserControl
    {
        private readonly System.Windows.Forms.Timer timer = new();

        public PerformanceMonitor()
        {
            InitializeComponent();

            checkAutoRefresh.CheckedChanged += (s, e) =>
            {
                if (e.Value) timer.Start();
                else timer.Stop();
            };

            inputInterval.ValueChanged += (s, e) =>
            {
                if (timer.Enabled) timer.Interval = (int)inputInterval.Value * 1000;
            };

            timer.Interval = (int)inputInterval.Value * 1000;

            timer.Tick += (s, e) => GetMem();

            btnRefresh.Click += (s, e) => GetInfo();

            btnMemClear.Click += (s, e) => ClearMem();
        }

        private void GetInfo()
        {
            gridPanelMain.Spin((config) =>
            {
                GetMem();
            }, () =>
            {
                AntdUI.Message.info(ParentForm!, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] 数据已更新。", default, 3);
            });
        }

        private void GetMem()
        {
            try
            {
                input1.Clear();

                long mem, size;
#pragma warning disable IDE0018 // 内联变量声明
                string unit;
#pragma warning restore IDE0018 // 内联变量声明

                //mem = GC.GetTotalMemory(false);
                //size = Common.Common.SizeFormat(mem, out unit);
                //input1.Text += $"GC.GetTotalMemory() - {size} {unit}";

                Process process = Process.GetCurrentProcess();
                mem = process.WorkingSet64;
                size = Common.Common.SizeFormat(mem, out unit);
                //input1.Text += $"\r\n\r\nProcess.GetCurrentProcess() - WorkingSet64 - {size} {unit}";

                //PerformanceCounter pc = new("Process", "Working Set", Process.GetCurrentProcess().ProcessName);
                //mem = (long)pc.NextValue();
                //size = Common.Common.SizeFormat(mem, out unit);
                //input1.Text += $"\r\n\r\nPerformanceCounter - Working Set - {size} {unit}";

                inputMem.Value = size;
                inputMem.SuffixText = unit;

                lbMem2.Text = $"更新时间：{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
            catch (Exception)
            {
                
            }
        }

        private void ClearMem()
        {
            btnMemClear.Spin((config) =>
            {
                try
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GetMem();
                }
                catch (Exception)
                {

                }
            });
        }
    }
}