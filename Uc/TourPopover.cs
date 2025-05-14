namespace AntdUI_HamburgerMenuTabs.Uc
{
    public partial class TourPopover : UserControl
    {
        private readonly AntdUI.Tour.Popover? popover;

        public TourPopover(AntdUI.Tour.Popover _popover, string title, string content, int step, int max)
        {
            InitializeComponent();

            popover = _popover;

            lbTitle.Text = title;
            lbContent.Text = content;
            lbStep.Text = $"步骤：{step} / {max}";

            if (step == max)
            {
                btnNext.Text = "结束";
                btnClose.Visible = false;
            }

            btnNext.Click += (s, e) =>
            {
                popover.Tour.Next();
            };

            if (step > 1)
            {
                btnPrevious.Enabled = true;
                btnPrevious.Text = "上一步";
            }
            else
            {
                btnPrevious.Enabled = false;
                btnPrevious.Text = "";
            }

            if (btnPrevious.Visible)
            {
                int w1 = (int)(lbTitle.PSize.Width / AntdUI.Config.Dpi), w = (int)((lbStep.PSize.Width + btnPrevious.PSize.Width + btnNext.PSize.Width) / AntdUI.Config.Dpi);
                Width = w1 > w ? w1 : w;
            }

            btnPrevious.Click += (s, e) =>
            {
                popover.Tour.Previous();
            };

            btnClose.Click += (s, e) =>
            {
                popover.Tour.Close();
            };
        }

        public void SetContent(string content)
        {
            lbContent.Text = content;
        }
    }
}