using System.ComponentModel;
using System.Data;

namespace AntdUI_HamburgerMenuTabs.Pages.Demo
{
    public partial class Table : UserControl
    {
        private readonly BindingList<DataModel> data = new BindingList<DataModel>();
        private bool isTableEventsInited = false;

        public Table()
        {
            InitializeComponent();

            btnGetData.Click += (s, e) => GetData();

            btnAdd.Click += (s, e) => AddRow();

            btnMinus.Click += (s, e) => DeleteRows();

            inputSearch.TextChanged += (s, e) => Search();

            btnRebinding.Click += (s, e) => Rebinding();
        }

        private class DataModel : AntdUI.NotifyProperty
        {
            public DataModel(int id, string? name, int age, string? notes)
            {
                Id = id;

                Random rnd = new Random();

                _enable = rnd.Next(2) == 1;

                if (id % 5 == 0)
                {
                    _status = new(AntdUI.TState.Primary, "Primary");
                }
                else if (id % 5 == 1)
                {
                    _status = new(AntdUI.TState.Success, "Success");
                }
                else if (id % 5 == 2)
                {
                    _status = new(AntdUI.TState.Warn, "Warn");
                }
                else if (id % 5 == 3)
                {
                    _status = new(AntdUI.TState.Error, "Error");
                }
                else if (id % 5 == 4)
                {
                    _status = new(AntdUI.TState.Processing, "Processing");
                }
                else
                {
                    _status = new(AntdUI.TState.Default, "Default");
                }

                _name = name;

                _age = age;

                _progress = new((float)(rnd.NextDouble()));

                if (id == 1)
                {
                    _images = [
                        new AntdUI.CellImage(Properties.Resources.CellImage) { Radius = 1 },
                        new AntdUI.CellImage(Properties.Resources.AntdUI_Button) { Radius = 1 },
                        ];
                }
                else
                {
                    _images = [
                        new AntdUI.CellImage("BankFilled"),
                        new AntdUI.CellImage("GiftFilled"),
                        ];
                }

                if (rnd.Next(5) == 1)
                {
                    _tags = [
                        new AntdUI.CellTag("Tag1", AntdUI.TTypeMini.Default),
                        new AntdUI.CellTag("Tag2", AntdUI.TTypeMini.Success),
                        ];
                }

                _notes = notes;

                if (id == 1)
                {
                    _options = [
                        new AntdUI.CellButton("edit", "编辑", AntdUI.TTypeMini.Primary),
                        new AntdUI.CellButton("delete", "删除", AntdUI.TTypeMini.Warn),
                        ];
                }
                else if (id == 2)
                {
                    _options = [
                        new AntdUI.CellButton("edit", "编辑", AntdUI.TTypeMini.Primary) { Enabled = false },
                        new AntdUI.CellButton("delete", "删除", AntdUI.TTypeMini.Warn) { Enabled = false },
                        ];
                }
                else if (id == 3)
                {
                    _options = [
                        new AntdUI.CellButton("edit", "编辑", AntdUI.TTypeMini.Primary) { Ghost = true },
                        new AntdUI.CellButton("delete", "删除", AntdUI.TTypeMini.Warn) { Ghost = true },
                        ];
                }
                else if (id == 4)
                {
                    _options = [
                        new AntdUI.CellLink("edit", "编辑"),
                        new AntdUI.CellLink("delete", "删除"),
                        ];
                }
                else
                {
                    _options = [
                        new AntdUI.CellButton("edit") { Type = AntdUI.TTypeMini.Primary, IconSvg = "EditFilled", Tooltip = "编辑" },
                        new AntdUI.CellButton("delete") { Type = AntdUI.TTypeMini.Warn, IconSvg = "DeleteFilled", Tooltip = "删除" },
                        ];
                }

                if (id == 2)
                {
                    List<DataModel> subLst = new List<DataModel>();
                    for (int i = 1; i <= 5; i++)
                    {
                        var row = new DataModel(200 + i, $"SubName-{(char)('A' + rnd.Next(0, 26))}", rnd.Next(10, 100), Guid.NewGuid().ToString())
                        {
                            Pid = 2,
                        };
                        subLst.Add(row);
                        Common.LogUtils.VsPrint($"{id} {_pid} {row.Id} {row.Pid}");
                    }
                    _sub = [.. subLst];
                }
            }

            bool _check = false;
            public bool Check
            {
                get => _check;
                set
                {
                    if (_check == value) return;
                    _check = value;
                    OnPropertyChanged();
                }
            }

            public int Id { get; set; }

            int _pid;
            public int Pid
            {
                get => _pid;
                set
                {
                    _pid = value;
                    OnPropertyChanged();
                }
            }

            bool _check2 = false;
            public bool Check2
            {
                get => _check2;
                set
                {
                    _check2 = value;
                    OnPropertyChanged();
                }
            }

            bool _radio = false;
            public bool Radio
            {
                get => _radio;
                set
                {
                    _radio = value;
                    OnPropertyChanged();
                }
            }

            bool _enable = false;
            public bool Enable
            {
                get => _enable;
                set
                {
                    _enable = value;
                    OnPropertyChanged();
                }
            }

            AntdUI.CellBadge _status;
            public AntdUI.CellBadge Status
            {
                get => _status;
                set
                {
                    _status = value;
                    OnPropertyChanged();
                }
            }

            string? _name;
            public string? Name
            {
                get => _name;
                set
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }

            int _age;
            public int Age
            {
                get => _age;
                set
                {
                    _age = value;
                    OnPropertyChanged();
                }
            }

            AntdUI.CellProgress? _progress;
            public AntdUI.CellProgress? Progress
            {
                get => _progress;
                set
                {
                    _progress = value;
                    OnPropertyChanged();
                }
            }

            AntdUI.CellImage[]? _images;
            public AntdUI.CellImage[]? Images
            {
                get => _images;
                set
                {
                    _images = value;
                    OnPropertyChanged();
                }
            }

            AntdUI.CellTag[]? _tags;
            public AntdUI.CellTag[]? Tags
            {
                get => _tags;
                set
                {
                    _tags = value;
                    OnPropertyChanged();
                }
            }

            string? _notes;
            public string? Notes
            {
                get => _notes;
                set
                {
                    _notes = value;
                    OnPropertyChanged();
                }
            }

            DateTime _addTime = DateTime.Now;
            public DateTime AddTime
            {
                get => _addTime;
                set
                {
                    _addTime = value;
                    OnPropertyChanged();
                }
            }

            DateTime _editTime;
            public DateTime EditTime
            {
                get => _editTime;
                set
                {
                    _editTime = value;
                    OnPropertyChanged();
                }
            }

            AntdUI.CellLink[]? _options;
            public AntdUI.CellLink[]? Options
            {
                get => _options;
                set
                {
                    _options = value;
                    OnPropertyChanged();
                }
            }

            DataModel[]? _sub;
            public DataModel[]? Sub
            {
                get => _sub;
                set
                {
                    _sub = value;
                    OnPropertyChanged();
                }
            }
        }

        private class DataSummaryModel(string id, string age)
        {
            public string Id { get; set; } = id;
            public string Age { get; set; } = age;
        }

        private void InitTableDs21()
        {
            table1.Columns.Clear();

            table1.Columns = [
                new AntdUI.ColumnCheck("Check").SetColAlign().SetAlign().SetFixed(),
                new AntdUI.Column("Id", "ID")
                {
                    KeyTree = "Sub",
                }.SetColAlign().SetAlign(AntdUI.ColumnAlign.Left).SetFixed().SetWidth("100"),
                new AntdUI.Column("Pid", "PID").SetColAlign().SetAlign().SetFixed(),
                new AntdUI.ColumnCheck("Check2", "多选").SetColAlign().SetAlign(),
                new AntdUI.ColumnRadio("Radio", "单选").SetColAlign().SetAlign(),
                new AntdUI.ColumnSwitch("Enable", "启用")
                {
                    Call = (value, record, idRow, idCol) =>
                    {
                        Task.Delay(500).Wait();
                        Random rnd = new Random();
                        if (rnd.Next(2) == 1)
                        {
                            AntdUI.Message.success(ParentForm!, "成功", default, 2);
                        }
                        else
                        {
                            value = !value;
                            AntdUI.Message.error(ParentForm!, "失败", default, 2);
                        }
                        return value;
                    }
                }.SetColAlign().SetAlign(),
                new AntdUI.Column("Status", "状态").SetColAlign().SetAlign(),
                new AntdUI.Column("Name", "姓名").SetColAlign().SetAlign(),
                new AntdUI.Column("Age", "年龄").SetColAlign().SetAlign(),
                new AntdUI.Column("Progress", "进度").SetColAlign().SetAlign(),
                new AntdUI.Column("Images", "图片").SetColAlign().SetAlign(),
                new AntdUI.Column("Tags", "标签").SetColAlign().SetAlign().SetWidth("auto"),
                new AntdUI.Column("Notes", "说明").SetColAlign().SetAlign(),
                new AntdUI.Column("AddTime", "创建时间").SetColAlign().SetAlign(),
                new AntdUI.Column("EditTime", "编辑时间").SetColAlign().SetAlign(),
                new AntdUI.Column("Options", "操作").SetColAlign().SetAlign().SetFixed().SetWidth("auto"),
            ];
        }

        private void InitTableDs22()
        {
            table1.Binding(data);

            // 注：如果启用了树形列，且任意父行存在子集，则通过 Table[RowIndex][ColumnIndex] 获取的值是不正确的，因为 RowIndex 不一致！

            table1.CellClick += (s, e) =>
            {
                if (e.Record is DataModel record)
                {
                    if (e.RowIndex > 0)
                    {
                        if (table1.Columns[e.ColumnIndex].Key == "Notes")
                        {
                            AntdUI.Popover.open(new AntdUI.Popover.Config(table1, $"{table1[e.RowIndex - 1]![e.ColumnIndex]}") { Offset = e.Rect, AutoClose = 1 });
                        }
                        else if (table1.Columns[e.ColumnIndex].Key == "Images")
                        {
                            if (record.Images != null)
                            {
                                if (record.Images.Length > 0)
                                {
                                    List<Image> images = new List<Image>();
                                    foreach (var image in record.Images)
                                    {
                                        if (image.Image != null) images.Add(image.Image);
                                    }
                                    if (images.Count > 0)
                                    {
                                        AntdUI.Preview.open(new AntdUI.Preview.Config(ParentForm!, images)
                                        {
                                            Btns = [
                                                new AntdUI.Preview.Btn("download", "DownloadOutlined")
                                                ],
                                            OnBtns = (id, data) =>
                                            {
                                                switch (id)
                                                {
                                                    case "download":
                                                        AntdUI.Message.success(ParentForm!, "下载完毕。", default, 2);
                                                        break;
                                                }
                                            }
                                        });
                                    }
                                }
                            }
                        }
                        else if (table1.Columns[e.ColumnIndex].Key == "Tags")
                        {
                            if (record.Tags == null)
                            {
                                record.Tags = [
                                    new AntdUI.CellTag("Tag1", AntdUI.TTypeMini.Default),
                                    ];
                            }
                            else
                            {
                                if (record.Tags.Length == 1)
                                {
                                    record.Tags = [
                                        new AntdUI.CellTag("Tag1", AntdUI.TTypeMini.Default),
                                        new AntdUI.CellTag("Tag2", AntdUI.TTypeMini.Success),
                                        ];
                                }
                                else if (record.Tags.Length == 2)
                                {
                                    record.Tags = [
                                        new AntdUI.CellTag("Tag1", AntdUI.TTypeMini.Default),
                                        new AntdUI.CellTag("Tag2", AntdUI.TTypeMini.Success),
                                        new AntdUI.CellTag("Tag3", AntdUI.TTypeMini.Warn),
                                        ];
                                }
                                else
                                {
                                    record.Tags = [
                                        new AntdUI.CellTag("Tag1", AntdUI.TTypeMini.Default),
                                        ];
                                }
                            }
                        }
                    }
                }
            };

            table1.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex > 0)
                {
                    // 双击单元格复制数据

                    // 方法一，在树形列启用的情况下，通过 Table[RowIndex][ColumnIndex] 获取的值不正确。
                    // 子行的 e.RowIndex 是顺延父行的，而通过 Table[RowIndex][ColumnIndex] 来取单元格数据的话，
                    // 拿不到正确的行索引，子行的索引不会被计算在内，且只能取到父行的数据。
                    //string cellText = $"{table1[e.RowIndex - 1]![e.ColumnIndex]}";
                    //try
                    //{
                    //    Clipboard.SetText(cellText);
                    //    AntdUI.Message.success(ParentForm!, $"{cellText}\r\n已复制到剪贴板。", default, 1);
                    //}
                    //catch (Exception ex)
                    //{
                    //    AntdUI.Message.error(ParentForm!, $"{ex.Message}", default, 2);
                    //}

                    // 方法二，在树形列启用的情况下，单元格数据复制正常，但无法准确获取待复制单元格的数据（原因同方法一）。
                    if (table1.CopyData(e.RowIndex, e.ColumnIndex))
                    {
                        AntdUI.Message.success(ParentForm!, "已复制到剪贴板。", default, 1);
                    }
                    else
                    {
                        AntdUI.Message.error(ParentForm!, "复制失败！", default, 2);
                    }

                    // 方法三，无法直接通过列索引取出单元格数据，只好利用反射了，在树形列启用的情况下能正常取数。
                    //if (e.Record is DataModel record)
                    //{
                    //    Type type = record.GetType();
                    //    PropertyInfo? pi = type.GetProperty(table1.Columns[e.ColumnIndex].Key);
                    //    object? val = null;
                    //    if (pi != null) val = pi.GetValue(record);
                    //    string cellText = $"{val}";
                    //    try
                    //    {
                    //        Clipboard.SetText(cellText);
                    //        AntdUI.Message.success(ParentForm!, $"{cellText}\r\n已复制到剪贴板。", default, 1);
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        AntdUI.Message.error(ParentForm!, $"{ex.Message}", default, 2);
                    //    }
                    //}
                }
            };

            table1.CellButtonClick += (s, e) =>
            {
                if (e.Record is DataModel record)
                {
                    if (e.Btn.Id == "edit")
                    {
                        UserControl uc = new UserControl()
                        {
                            Size = new System.Drawing.Size(400, 300),
                        };

                        AntdUI.StackPanel stackPanel = new AntdUI.StackPanel()
                        {
                            Dock = DockStyle.Fill,
                            Padding = new Padding(10),
                            Vertical = true,
                            AutoScroll = true,
                        };
                        uc.Controls.Add(stackPanel);

                        AntdUI.GridPanel gridPanelName = new AntdUI.GridPanel()
                        {
                            Height = 50,
                            Span = "100 100%",
                        };
                        AntdUI.Label lbName = new AntdUI.Label()
                        {
                            Text = "姓名：",
                        };
                        AntdUI.Input inputName = new AntdUI.Input()
                        {
                            Text = $"{record.Name}",
                        };
                        gridPanelName.Controls.Add(inputName);
                        gridPanelName.Controls.Add(lbName);
                        stackPanel.Controls.Add(gridPanelName);
                        gridPanelName.BringToFront();

                        AntdUI.GridPanel gridPanelAge = new AntdUI.GridPanel()
                        {
                            Height = 50,
                            Span = "100 100%",
                        };
                        AntdUI.Label lbAge = new AntdUI.Label()
                        {
                            Text = "年龄：",
                        };
                        AntdUI.InputNumber inputAge = new AntdUI.InputNumber()
                        {
                            Value = record.Age,
                        };
                        gridPanelAge.Controls.Add(inputAge);
                        gridPanelAge.Controls.Add(lbAge);
                        stackPanel.Controls.Add(gridPanelAge);
                        gridPanelAge.BringToFront();

                        AntdUI.GridPanel gridPanelNotes = new AntdUI.GridPanel()
                        {
                            Height = 150,
                            Span = "100 100%",
                        };
                        AntdUI.Label lbNotes = new AntdUI.Label()
                        {
                            Text = "说明：",
                        };
                        AntdUI.Input inputNotes = new AntdUI.Input()
                        {
                            Text = $"{record.Notes}",
                            Multiline = true,
                        };
                        gridPanelNotes.Controls.Add(inputNotes);
                        gridPanelNotes.Controls.Add(lbNotes);
                        stackPanel.Controls.Add(gridPanelNotes);
                        gridPanelNotes.BringToFront();

                        if (AntdUI.Modal.open(new AntdUI.Modal.Config(ParentForm!, "编辑", uc, AntdUI.TType.None)
                        {
                            OkType = AntdUI.TTypeMini.Primary,
                            OkText = "保存",
                            CancelText = "取消",
                        }) == DialogResult.OK)
                        {
                            table1.Spin("删除中，请稍候...", config =>
                            {
                                Task.Delay(500).Wait();
                                record.Name = inputName.Text;
                                record.Age = (int)inputAge.Value;
                                record.Notes = inputNotes.Text;
                                record.EditTime = DateTime.Now;
                            }, () =>
                            {
                                AntdUI.Message.success(ParentForm!, "保存完毕。", default, 2);
                            });
                        }
                    }
                    else if (e.Btn.Id == "delete")
                    {
                        if (AntdUI.Modal.open(new AntdUI.Modal.Config(ParentForm!, "警告", new AntdUI.Modal.TextLine[]
                        {
                            new("是否确认删除？", 6, AntdUI.Style.Db.Warning),
                            new($"ID: {record.Id}", 6, AntdUI.Style.Db.Primary),
                            new($"Name: {record.Name}", 6, AntdUI.Style.Db.Primary),
                        }, AntdUI.TType.Warn)
                        {
                            OkType = AntdUI.TTypeMini.Warn,
                            OkText = "确认",
                        }) == DialogResult.OK)
                        {
                            table1.Spin("删除中，请稍候...", config =>
                            {
                                Task.Delay(500).Wait();
                                data.Remove(record);
                            }, () =>
                            {
                                AntdUI.Message.success(ParentForm!, "删除完毕。", default, 2);
                            });
                        }
                    }
                }
            };

            isTableEventsInited = true;
        }

        private void GetData()
        {
            // 清空汇总行
            table1.Summary = null;

            gridPanel1.Spin("数据加载中...", config =>
            {
                Random rnd = new Random();
                int rows = 0;

                data.Clear();

                if (radioDs1.Checked)
                {
                    rows = rnd.Next(10, 10000);

                    DataTable dt = new();
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Age", typeof(int));
                    dt.Columns.Add("Notes", typeof(string));

                    table1.DataSource = null;
                    table1.Columns.Clear();
                    table1.Columns = [
                        new AntdUI.Column("Id", "ID").SetColAlign().SetAlign(),
                        new AntdUI.Column("Name", "姓名").SetColAlign().SetAlign(),
                        new AntdUI.Column("Age", "年龄").SetColAlign().SetAlign(),
                        new AntdUI.Column("Notes", "说明").SetColAlign().SetAlign(),
                    ];

                    for (int i = 0; i < rows; i++)
                    {
                        dt.Rows.Add(i + 1, $"Name-{(char)('A' + rnd.Next(0, 26))}", rnd.Next(10, 100), Guid.NewGuid().ToString());
                    }

                    table1.DataSource = dt;

                    // 添加汇总行
                    var q = dt.AsEnumerable();
                    int avgAge = (int)q.Select(r => {
                        var obj = r["Age"];
                        return obj is int i ? i : 0;
                    }).Average();
                    table1.Summary = new DataSummaryModel($"总行数：{dt.Rows.Count}", $"平均值：{avgAge}");
                }
                else if (radioDs2.Checked)
                {
                    rows = rnd.Next(10, 100);

                    InitTableDs21();

                    if (!isTableEventsInited) InitTableDs22();

                    for (int i = 0; i < rows; i++)
                    {
                        config.Value = (i + 1F) / rows;
                        config.Text = $"数据加载中...[{i + 1} / {rows}]";
                        data.Add(new DataModel(i + 1, $"Name-{(char)('A' + rnd.Next(0, 26))}", rnd.Next(10, 100), Guid.NewGuid().ToString()));
                    }

                    // 如果启用了树形列，则需重新绑定数据源，否则子行不显示
                    table1.Binding(data);

                    // 添加汇总行
                    //table1.Summary = new DataModel(data.Count, "", (int)data.Average(item => item.Age), "");
                    table1.Summary = new DataSummaryModel($"总行数：{data.Count}", $"平均值：{(int)data.Average(item => item.Age)}");

                    // 设置行禁用
                    table1.SetRowEnable(rnd.Next(1, 10), false, true);
                }

                AntdUI.Message.info(ParentForm!, $"已加载 {rows} 行数据。", default, 2);
            });
        }

        private void Rebinding()
        {
            if (radioDs2.Checked)
            {
                table1.Binding(data);
            }
        }

        private void AddRow()
        {
            if (!radioDs2.Checked) return;
            Random rnd = new Random();
            int id = data.Max(x => x.Id);
            data.Add(new DataModel(id + 1, $"Name-{(char)('A' + rnd.Next(0, 26))}", rnd.Next(10, 100), Guid.NewGuid().ToString()));
            table1.Summary = new DataSummaryModel($"总行数：{data.Count}", $"平均值：{(int)data.Average(item => item.Age)}");
            table1.ScrollLine(data.Count, true);
        }

        private void DeleteRows()
        {
            if (!radioDs2.Checked) return;

            List<int> ids = new List<int>();

            var _data = data.Where(x => x.Check).ToList();

            foreach (var record in _data)
            {
                ids.Add(record.Id);
            }

            if (ids.Count > 0)
            {
                if (AntdUI.Modal.open(new AntdUI.Modal.Config(ParentForm!, "警告", new AntdUI.Modal.TextLine[]
                {
                    new("是否确认删除？", 6, AntdUI.Style.Db.Warning),
                    new($"IDs: {string.Join(",", ids.Select(i => i.ToString()))}", 6, AntdUI.Style.Db.Primary),
                }, AntdUI.TType.Warn)
                {
                    OkType = AntdUI.TTypeMini.Warn,
                    OkText = "确认",
                }) == DialogResult.OK)
                {
                    table1.Spin("删除中，请稍候...", config =>
                    {
                        Task.Delay(1000).Wait();
                        foreach (var record in _data)
                        {
                            data.Remove(record);
                        }
                        table1.Summary = new DataSummaryModel($"总行数：{data.Count}", $"平均值：{(int)data.Average(item => item.Age)}");
                    }, () =>
                    {
                        AntdUI.Message.success(ParentForm!, "删除完毕。", default, 2);
                    });
                };
            }
            else
            {
                AntdUI.Message.warn(ParentForm!, "未勾选任何行！", default, 2);
            }
        }

        private void Search()
        {
            string kw = inputSearch.Text.Trim();
            if (kw == "")
            {
                table1.Binding(data);
            }
            else
            {
                var data1 = data.Where(x => (!string.IsNullOrEmpty(x.Name) && x.Name.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0) || (!string.IsNullOrEmpty(x.Notes) && x.Notes.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
                var data2 = new AntdUI.AntList<DataModel>(data1);
                table1.Binding(data2);
        }
        }
    }
}