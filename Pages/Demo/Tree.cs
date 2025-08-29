namespace AntdUI_HamburgerMenuTabs.Pages.Demo
{
    public partial class Tree : UserControl
    {
        public Tree()
        {
            InitializeComponent();

            tree1.BlockNode = true;

            tree1.NodeMouseClick += (s, e) =>
            {
                var item = e.Item;
                if (item == null) return;
                if (item.Tag is TreeItemTag tag)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        AntdUI.Message.info(ParentForm!, $"Expand: {item.Expand}\r\n{item.Text}\r\n{tag.Path}\r\n{item.IconSvg}", default, 2);
                    }
                }
            };

            inputDir.PrefixClick += (s, e) =>
            {
                var dialog = new FolderBrowserDialog()
                {
                    SelectedPath = inputDir.Text
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    inputDir.Text = dialog.SelectedPath;
                    LoadTreeItems();
                }
            };

            inputDir.SuffixClick += (s, e) =>
            {
                LoadTreeItems();
            };
        }

        private void LoadTreeItems()
        {
            string dir = inputDir.Text;

            if (!Directory.Exists(dir)) return;

            tree1.SuspendLayout();
            tree1.Items.Clear();

            tree1.Spin(config =>
            {
                GetTreeItems(null);
            }, () =>
            {
                tree1.ResumeLayout();
                AntdUI.Message.success(ParentForm!, "加载完毕。", default, 2);
            });
        }

        private void GetTreeItems(AntdUI.TreeItem? parent = null)
        {
            string dir = "";

            if (parent == null)
            {
                dir = inputDir.Text;
            }
            else
            {
                if (parent.Tag is TreeItemTag _tag)
                {
                    dir = $"{_tag.Path}";
                }
            }

            if (!Directory.Exists(dir)) return;

            AntdUI.TreeItem item;
            TreeItemTag tag;
            var di = new DirectoryInfo(dir);

            foreach (var _di in di.GetDirectories())
            {
                tag = new(1, _di.FullName);
                item = new AntdUI.TreeItem(_di.Name) { IconSvg = "FolderOutlined", Tag = tag };
                if (parent == null) tree1.Items.Add(item); else parent.Sub.Add(item);
                GetTreeItems(item);
            }

            foreach (var _fi in di.GetFiles())
            {
                tag = new(2, _fi.FullName);
                item = new AntdUI.TreeItem(_fi.Name) { IconSvg = "FileOutlined", Tag = tag };
                if (parent == null) tree1.Items.Add(item); else parent.Sub.Add(item);
            }
        }

        public class TreeItemTag(int type, string? path)
        {
            public int Type { get; set; } = type;
            public string? Path { get; set; } = path;
        }
    }
}