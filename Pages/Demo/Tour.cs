namespace AntdUI_HamburgerMenuTabs.Pages.Demo
{
    public partial class Tour : UserControl
    {
        private AntdUI.TourForm? frmTour;

        public Tour()
        {
            InitializeComponent();

            btnTour.Click += (s, e) =>
            {
                frmTour = null;
                OpenTour();
            };
        }

        private void OpenTour()
        {
            if (frmTour == null)
            {
                Form? frmPopover = null;

                frmTour = AntdUI.Tour.open(new AntdUI.Tour.Config(ParentForm!, result =>
                {
                    switch (result.Index)
                    {
                        case 0:
                            result.Set(btn1);
                            break;
                        case 1:
                            result.Set(btn2);
                            break;
                        case 2:
                            result.Set(slider1);
                            break;
                        case 3:
                            result.Set(calendar1);
                            break;
                        default:
                            result.Close();
                            frmTour = null;
                            break;
                    }
                }, popover =>
                {
                    frmPopover?.Close();
                    frmPopover = null;

                    if (popover.Rect.HasValue)
                    {
                        var uc = new Uc.TourPopover(popover, "引导", "", popover.Index + 1, 4) { Size = new(450, 320) };

                        switch (popover.Index)
                        {
                            case 0:
                                uc.SetContent("这是一个按钮");
                                break;
                            case 1:
                                uc.SetContent("这是另一个按钮");
                                break;
                            case 2:
                                uc.SetContent("这是一个滑块");
                                break;
                            case 3:
                                uc.SetContent("这是一个日历");
                                break;
                        }

                        frmPopover = AntdUI.Popover.open(new AntdUI.Popover.Config(popover.Form, uc)
                        {
                            Offset = popover.Rect.Value,
                            Focus = false,
                        });
                    }
                }));
            }
            else
            {
                frmTour.Next();
            }
        }
    }
}