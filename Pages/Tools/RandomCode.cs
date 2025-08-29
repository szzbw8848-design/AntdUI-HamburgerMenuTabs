namespace AntdUI_HamburgerMenuTabs.Pages.Tools
{
    public partial class RandomCode : UserControl
    {
        private const string charsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string charsLower = "abcdefghijklmnopqrstuvwxyz";
        private const string charsNum = "0123456789";
        private const string charsSpecial = "!@#$%&";
        private string chars = "";

        public RandomCode()
        {
            InitializeComponent();

            checkUpper.Checked = true;
            checkNum.Checked = true;

            inputLen.PrefixClick += (s, e) =>
            {
                inputLen.Value = 8;
            };

            inputCnt.PrefixClick += (s, e) =>
            {
                inputCnt.Value = 1;
            };

            btnGenerate.Click += (s, e) => GenerateRandomCode();
        }

        private void GenerateRandomCode()
        {
            HashSet<string> res = new HashSet<string>();
            Random random = new Random();
            DateTime dtStart = DateTime.Now;
            int timesTotal = 0;
            int timesIgnore = 0;
            string msg = "";

            chars = "";
            if (checkUpper.Checked) chars += charsUpper;
            if (checkLower.Checked) chars += charsLower;
            if (checkNum.Checked) chars += charsNum;
            if (checkSpecial.Checked) chars += charsSpecial;
            if (chars.Length == 0) return;

            if (inputCnt.Value > (int)Math.Pow(chars.Length, chars.Length))
            {
                msg = $"编码池上限为 {(int)Math.Pow(chars.Length, chars.Length)} ，当前待生成编码个数已超出上限！";
                Helpers.Antd.Msgbox.ShowWarn(ParentForm!, msg, false);
                return;
            }

            inputRes.Clear();

            gridPanelMain.Spin((config) =>
            {
                while (res.Count < inputCnt.Value)
                {
                    string str = GenerateRandomString((int)inputLen.Value, random);
                    timesTotal++;
                    if (!res.Add(str))
                    {
                        timesIgnore++;
                        continue;
                    }
                }

                if (inputCnt.Value <= 100)
                {
                    inputRes.Text = string.Join(Environment.NewLine, res);
                }
                else
                {
                    inputRes.Text = "数据量太大，取消显示。";
                }

                res.Clear();
            }, () =>
            {
                GC.Collect();
                msg = $"生成完毕。\r\n耗时 {(int)(DateTime.Now - dtStart).TotalMilliseconds} 毫秒。\r\n合计尝试生成 {timesTotal} 次，共丢弃 {timesIgnore} 个重复编码，重复概率为 {Math.Round(timesIgnore * 1.0 / timesTotal, 8)}。";

                Helpers.Antd.Msgbox.ShowSuccess(ParentForm!, msg);
            });
        }

        private string GenerateRandomString(int length, Random random)
        {
            char[] buffer = new char[length];

            for (int i = 0; i < length; i++)
            {
                buffer[i] = chars[random.Next(chars.Length)];
            }
            return new string(buffer);
        }
    }
}