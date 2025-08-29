namespace AntdUI_HamburgerMenuTabs.Helpers
{
    /// <summary>
    /// AntdUI 帮助类
    /// 版本：2025.04.21.01
    /// </summary>
    public class Antd
    {
        readonly static HashSet<AntdUI.Window> subWindows = new HashSet<AntdUI.Window>();

        /// <summary>
        /// 设置主题（读取用户配置）
        /// </summary>
        /// <param name="window"></param>
        /// <param name="btnSwitch"></param>
        public static void ReadTheme(AntdUI.Window window, AntdUI.Button? btnSwitch, AntdUI.ColorPicker? colorTheme)
        {
            bool dark = Properties.Settings.Default.ThemeDark;
            SetTheme(window, btnSwitch, dark);
            Color primary = Properties.Settings.Default.ThemeColor;
            AntdUI.Style.SetPrimary(primary);
            if (colorTheme != null) colorTheme.Value = primary;
            window.Refresh();
        }

        /// <summary>
        /// 设置主题和主题色，并保存用户配置
        /// </summary>
        /// <param name="dark"></param>
        public static void SetThemeAndSave(AntdUI.Window window, AntdUI.Button? btnSwitch, bool dark, Color primary)
        {
            SetTheme(window, btnSwitch, dark);
            AntdUI.Style.SetPrimary(primary);
            window.Refresh();
            BroadcastThemeToSubWindows();
            Properties.Settings.Default.ThemeDark = dark;
            Properties.Settings.Default.ThemeColor = primary;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 设置主题
        /// </summary>
        /// <param name="window"></param>
        /// <param name="btnSwitch"></param>
        /// <param name="dark"></param>
        public static void SetTheme(AntdUI.Window window, AntdUI.Button? btnSwitch, bool dark)
        {
            AntdUI.Config.IsDark = dark;
            if (dark)
            {
                if (btnSwitch != null) btnSwitch.IconSvg = "MoonFilled";
                window.BackColor = Color.FromArgb(20, 20, 20);
                window.ForeColor = Color.FromArgb(241, 241, 241);
            }
            else
            {
                if (btnSwitch != null) btnSwitch.IconSvg = "SunOutlined";
                window.BackColor = Color.White;
                window.ForeColor = Color.FromArgb(20, 20, 20);
            }
        }

        /// <summary>
        /// 设置主题色，并保存用户配置
        /// </summary>
        /// <param name="primary"></param>
        public static void SetThemeColorAndSave(AntdUI.Window window, Color primary)
        {
            AntdUI.Style.SetPrimary(primary);
            window.Refresh();
            BroadcastThemeToSubWindows();
            Properties.Settings.Default.ThemeColor = primary;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 切换明暗主题
        /// </summary>
        /// <param name="window"></param>
        /// <param name="btnSwitch"></param>
        public static void SwitchTheme(AntdUI.Window window, AntdUI.Button? btnSwitch)
        {
            bool dark = !AntdUI.Config.IsDark;
            SetTheme(window, btnSwitch, dark);
            Color primary = Properties.Settings.Default.ThemeColor;
            AntdUI.Style.SetPrimary(primary);
            window.Refresh();
            BroadcastThemeToSubWindows();
            Properties.Settings.Default.ThemeDark = dark;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 继承主窗体的主题
        /// </summary>
        public static void InheritTheme(AntdUI.Window window)
        {
            bool themeChanged = false;
            bool dark = AntdUI.Config.IsDark;
            if (dark)
            {
                if (window.BackColor != Color.Black)
                {
                    window.BackColor = Color.Black;
                    window.ForeColor = Color.White;
                    themeChanged = true;
                }
            }
            else
            {
                if (window.BackColor != Color.White)
                {
                    window.BackColor = Color.White;
                    window.ForeColor = Color.Black;
                    themeChanged = true;
                }
            }
            if (themeChanged) window.Refresh();
            subWindows.Add(window);
        }

        /// <summary>
        /// 把主题应用到所有子窗体
        /// </summary>
        private static void BroadcastThemeToSubWindows()
        {
            foreach (AntdUI.Window subWin in subWindows)
            {
                if (subWin != null && !subWin.IsDisposed && subWin.Visible)
                {
                    InheritTheme(subWin);
                    subWin.Refresh();
                }
            }
        }

        /// <summary>
        /// 消息提示窗
        /// </summary>
        public class Msgbox
        {
            /// <summary>
            /// 消息提示窗
            /// </summary>
            /// <param name="parent">父窗体</param>
            /// <param name="msg"></param>
            /// <param name="maskClosable">点击蒙层是否允许关闭</param>
            /// <returns></returns>
            public static DialogResult ShowInfo(Form parent, string msg, bool maskClosable = true)
            {
                Form frm = parent;
                DialogResult res = AntdUI.Modal.open(new AntdUI.Modal.Config(frm, "提示", msg, AntdUI.TType.Info)
                {
                    Font = frm.Font,
                    MaskClosable = maskClosable,
                    CancelText = null,
                });
                return res;
            }

            /// <summary>
            /// 成功提示窗
            /// </summary>
            /// <param name="parent">父窗体</param>
            /// <param name="msg"></param>
            /// <param name="maskClosable">点击蒙层是否允许关闭</param>
            /// <returns></returns>
            public static DialogResult ShowSuccess(Form parent, string msg, bool maskClosable = true)
            {
                Form frm = parent;
                DialogResult res = AntdUI.Modal.open(new AntdUI.Modal.Config(frm, "成功", msg, AntdUI.TType.Success)
                {
                    Font = frm.Font,
                    MaskClosable = maskClosable,
                    CancelText = null,
                });
                return res;
            }

            /// <summary>
            /// 警告提示窗
            /// </summary>
            /// <param name="parent">父窗体</param>
            /// <param name="msg"></param>
            /// <param name="maskClosable">点击蒙层是否允许关闭</param>
            /// <returns></returns>
            public static DialogResult ShowWarn(Form parent, string msg, bool maskClosable = false)
            {
                Form frm = parent;
                DialogResult res = AntdUI.Modal.open(new AntdUI.Modal.Config(frm, "警告", msg, AntdUI.TType.Warn)
                {
                    Font = frm.Font,
                    MaskClosable = maskClosable,
                    CancelText = null,
                });
                return res;
            }

            /// <summary>
            /// 错误提示窗
            /// </summary>
            /// <param name="parent">父窗体</param>
            /// <param name="msg"></param>
            /// <param name="maskClosable">点击蒙层是否允许关闭</param>
            /// <returns></returns>
            public static DialogResult ShowError(Form parent, string msg, bool maskClosable = false)
            {
                Form frm = parent;
                DialogResult res = AntdUI.Modal.open(new AntdUI.Modal.Config(frm, "错误", msg, AntdUI.TType.Error)
                {
                    Font = frm.Font,
                    MaskClosable = maskClosable,
                    CancelText = null,
                });
                return res;
            }

            /// <summary>
            /// 选择提示窗
            /// </summary>
            /// <param name="parent">父窗体</param>
            /// <param name="msg"></param>
            /// <returns></returns>
            public static DialogResult ShowAsk(Form parent, string msg)
            {
                Form frm = parent;
                DialogResult res = AntdUI.Modal.open(new AntdUI.Modal.Config(frm, "提示", msg, AntdUI.TType.Warn)
                {
                    Font = frm.Font,
                    MaskClosable = false,
                });
                return res;
            }
        }

        /// <summary>
        /// 设置呼吸灯动效
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="color1"></param>
        /// <param name="color2"></param>
        /// <param name="animationType"></param>
        public static void SetBreathingLight(Control ctl, Color color1, Color color2, int animationType = 1)
        {
            AntdUI.Button? btn = null;

            if (ctl is AntdUI.Button _btn)
            {
                btn = _btn;
                if (btn.Type == AntdUI.TTypeMini.Default) return;
            }

            AntdUI.Label? lb = null;

            if (ctl is AntdUI.Label _lb)
            {
                lb = _lb;
            }

            AntdUI.PageHeader? ph = null;

            if (ctl is AntdUI.PageHeader _ph)
            {
                ph = _ph;
            }

            if (btn == null && lb == null && ph == null) throw new Exception("控件类型不支持！");

            Random rnd = new();
            int angle = 90;
            if (color1 == Color.Empty) color1 = Color.FromArgb(rnd.Next(100, 200), rnd.Next(100, 200), rnd.Next(100, 200));
            if (color2 == Color.Empty) color2 = Color.FromArgb(rnd.Next(100, 200), rnd.Next(100, 200), rnd.Next(100, 200));

            if (btn != null)
            {
                btn.BackExtend = $"{angle},{ColorTranslator.ToHtml(color1)},{ColorTranslator.ToHtml(color2)}";
            }
            else if (lb != null)
            {
                lb.ColorExtend = $"{angle},{ColorTranslator.ToHtml(color1)},{ColorTranslator.ToHtml(color2)}";
            }
            if (ph != null)
            {
                ph.BackExtend = $"{angle},{ColorTranslator.ToHtml(color1)},{ColorTranslator.ToHtml(color2)}";
            }

            int i = 0;
            int ii = 1;

            System.Windows.Forms.Timer timer = new() { Interval = 10 };

            timer.Tick += (s, e) =>
            {
                i += ii;

                if (i == 50) ii = -1;
                if (i == -50) ii = 1;

                Color color3 = color1;
                Color color4 = color2;

                int r, g, b;

                if (animationType == 1)
                {
                    r = color1.R + i;
                    if (r > 255) r = 255; else if (r < 0) r = 0;
                    g = color1.G + i;
                    if (g > 255) g = 255; else if (g < 0) g = 0;
                    b = color1.B + i;
                    if (b > 255) b = 255; else if (b < 0) b = 0;

                    color3 = Color.FromArgb(r, g, b);

                    r = color2.R + i;
                    if (r > 255) r = 255; else if (r < 0) r = 0;
                    g = color2.G + i;
                    if (g > 255) g = 255; else if (g < 0) g = 0;
                    b = color2.B + i;
                    if (b > 255) b = 255; else if (b < 0) b = 0;

                    color4 = Color.FromArgb(r, g, b);
                }
                else if (animationType == 2)
                {
                    r = color1.R + i;
                    if (r > 255) r = 255; else if (r < 0) r = 0;
                    g = color1.G;
                    b = color2.B;

                    color3 = Color.FromArgb(color1.R + i, color1.G, color1.B);

                    r = color1.R;
                    g = color1.G + i;
                    if (g > 255) g = 255; else if (g < 0) g = 0;
                    b = color2.B;

                    color4 = Color.FromArgb(color2.R, color2.G + i, color2.B);
                }

                if (btn != null)
                {
                    btn.BackExtend = $"{angle},{ColorTranslator.ToHtml(color3)},{ColorTranslator.ToHtml(color4)}";
                }
                else if (lb != null)
                {
                    lb.ColorExtend = $"{angle},{ColorTranslator.ToHtml(color3)},{ColorTranslator.ToHtml(color4)}";
                }
                else if (ph != null)
                {
                    ph.BackExtend = $"{angle},{ColorTranslator.ToHtml(color3)},{ColorTranslator.ToHtml(color4)}";
                }
            };
            timer.Start();
        }
    }
}