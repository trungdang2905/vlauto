using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Combo : Form
{
    private IContainer icontainer_0 = null;

    private Timer timer_0;

    private NumericUpDown numericUpDown1;

    private ListView listView2;

    private ColumnHeader columnHeader_0;

    private ColumnHeader columnHeader_1;

    private NumericUpDown numericUpDown2;

    private ColumnHeader columnHeader_2;

    private ListView listView1;

    private ComboBox comboBoxPhim;

    private ComboBox comboBoxThuoc;

    private Button buttonApdung;

    private Label labelStatus;

    private Button buttonXoaFilecauhinh;

    private CheckBox checkBoxDungchung;

    private Label labelXoaThuoc;

    private Label labelThemThuoc;

    private Label labelXoaPhim;

    private Button buttonTaoPhim;

    private Button buttonPhimHuongdan;

    private Label label3;

    private Label labelTile;

    private Label label2;

    private Label label4;

    private CheckBox checkBoxPhiChiendau;

    public static bool bool_0 = false;

    public int int_0 = 0;

    public int int_1 = 0;

    public int int_2;

    public int int_3;

    public static int int_4 = Class55.smethod_3("flagTileBom", 0, "1");

    public static int int_5 = Class55.smethod_3("flagBomChungThuoc", 0, "0");

    public static int int_6 = Class55.smethod_3("flagPhiCD", 0, "0");

    public GStruct42 gstruct42_0 = default(GStruct42);

    private static int int_7 = -1;

    private static string[] string_0 = null;

    //override void Form.Dispose(bool disposing)
    //{
    //	if (disposing && icontainer_0 != null)
    //	{
    //		icontainer_0.Dispose();
    //	}
    //	Dispose(disposing);
    //}

    private void InitializeComponent()
    {
        icontainer_0 = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Combo));
        timer_0 = new System.Windows.Forms.Timer(icontainer_0);
        numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        listView2 = new System.Windows.Forms.ListView();
        columnHeader_0 = new System.Windows.Forms.ColumnHeader();
        columnHeader_1 = new System.Windows.Forms.ColumnHeader();
        numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        columnHeader_2 = new System.Windows.Forms.ColumnHeader();
        listView1 = new System.Windows.Forms.ListView();
        comboBoxPhim = new System.Windows.Forms.ComboBox();
        comboBoxThuoc = new System.Windows.Forms.ComboBox();
        buttonApdung = new System.Windows.Forms.Button();
        labelStatus = new System.Windows.Forms.Label();
        checkBoxDungchung = new System.Windows.Forms.CheckBox();
        labelXoaPhim = new System.Windows.Forms.Label();
        labelXoaThuoc = new System.Windows.Forms.Label();
        labelThemThuoc = new System.Windows.Forms.Label();
        buttonXoaFilecauhinh = new System.Windows.Forms.Button();
        buttonTaoPhim = new System.Windows.Forms.Button();
        buttonPhimHuongdan = new System.Windows.Forms.Button();
        labelTile = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        checkBoxPhiChiendau = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        SuspendLayout();
        timer_0.Tick += new System.EventHandler(timer_0_Tick);
        numericUpDown1.ForeColor = System.Drawing.Color.MediumBlue;
        numericUpDown1.Location = new System.Drawing.Point(344, 153);
        numericUpDown1.Maximum = new decimal(new int[4]
        {
            60,
            0,
            0,
            0
        });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(46, 20);
        numericUpDown1.TabIndex = 72;
        numericUpDown1.Value = new decimal(new int[4]
        {
            1,
            0,
            0,
            0
        });
        numericUpDown1.ValueChanged += new System.EventHandler(numericUpDown1_ValueChanged);
        numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(numericUpDown1_KeyUp);
        listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
        {
            columnHeader_0,
            columnHeader_1
        });
        listView2.ForeColor = System.Drawing.Color.DarkBlue;
        listView2.FullRowSelect = true;
        listView2.GridLines = true;
        listView2.HideSelection = false;
        listView2.Location = new System.Drawing.Point(120, 26);
        listView2.Name = "listView2";
        listView2.Size = new System.Drawing.Size(294, 123);
        listView2.TabIndex = 66;
        listView2.UseCompatibleStateImageBehavior = false;
        listView2.View = System.Windows.Forms.View.Details;
        listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(listView2_MouseClick);
        listView2.MouseDown += new System.Windows.Forms.MouseEventHandler(listView2_MouseDown);
        columnHeader_0.Text = "Tên thuốc";
        columnHeader_0.Width = 210;
        columnHeader_1.Text = "Số lượng";
        columnHeader_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        columnHeader_1.Width = 55;
        numericUpDown2.ForeColor = System.Drawing.SystemColors.WindowText;
        numericUpDown2.Location = new System.Drawing.Point(264, 207);
        numericUpDown2.Maximum = new decimal(new int[4]
        {
            10,
            0,
            0,
            0
        });
        numericUpDown2.Minimum = new decimal(new int[4]
        {
            1,
            0,
            0,
            0
        });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new System.Drawing.Size(52, 20);
        numericUpDown2.TabIndex = 76;
        numericUpDown2.Value = new decimal(new int[4]
        {
            1,
            0,
            0,
            0
        });
        numericUpDown2.ValueChanged += new System.EventHandler(numericUpDown2_ValueChanged);
        numericUpDown2.KeyUp += new System.Windows.Forms.KeyEventHandler(numericUpDown2_KeyUp);
        columnHeader_2.Text = "Phím bơm";
        columnHeader_2.Width = 85;
        listView1.BackColor = System.Drawing.SystemColors.Info;
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
        {
            columnHeader_2
        });
        listView1.FullRowSelect = true;
        listView1.GridLines = true;
        listView1.HideSelection = false;
        listView1.Location = new System.Drawing.Point(6, 26);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(108, 123);
        listView1.TabIndex = 65;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(listView1_MouseClick);
        listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(listView1_MouseDown);
        comboBoxPhim.BackColor = System.Drawing.Color.White;
        comboBoxPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboBoxPhim.ForeColor = System.Drawing.Color.DarkBlue;
        comboBoxPhim.FormattingEnabled = true;
        comboBoxPhim.Location = new System.Drawing.Point(78, 152);
        comboBoxPhim.Name = "comboBoxPhim";
        comboBoxPhim.Size = new System.Drawing.Size(36, 21);
        comboBoxPhim.TabIndex = 73;
        comboBoxThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboBoxThuoc.DropDownWidth = 200;
        comboBoxThuoc.ForeColor = System.Drawing.Color.MediumBlue;
        comboBoxThuoc.FormattingEnabled = true;
        comboBoxThuoc.Location = new System.Drawing.Point(121, 152);
        comboBoxThuoc.Name = "comboBoxThuoc";
        comboBoxThuoc.Size = new System.Drawing.Size(218, 21);
        comboBoxThuoc.TabIndex = 69;
        comboBoxThuoc.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxThuoc_MouseDown);
        buttonApdung.BackColor = System.Drawing.SystemColors.Control;
        buttonApdung.ForeColor = System.Drawing.Color.DarkRed;
        buttonApdung.Location = new System.Drawing.Point(304, 303);
        buttonApdung.Name = "buttonApdung";
        buttonApdung.Size = new System.Drawing.Size(110, 26);
        buttonApdung.TabIndex = 78;
        buttonApdung.Text = "OK";
        buttonApdung.UseVisualStyleBackColor = false;
        buttonApdung.Click += new System.EventHandler(buttonApdung_Click);
        labelStatus.AutoSize = true;
        labelStatus.BackColor = System.Drawing.SystemColors.Control;
        labelStatus.ForeColor = System.Drawing.Color.Black;
        labelStatus.Location = new System.Drawing.Point(3, 5);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new System.Drawing.Size(336, 13);
        labelStatus.TabIndex = 81;
        labelStatus.Text = "Bấm nút tạo phím, sau đó thêm tên thuốc và số lượng vào danh sách";
        labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        checkBoxDungchung.AutoSize = true;
        checkBoxDungchung.BackColor = System.Drawing.SystemColors.Control;
        checkBoxDungchung.ForeColor = System.Drawing.SystemColors.WindowText;
        checkBoxDungchung.Location = new System.Drawing.Point(6, 209);
        checkBoxDungchung.Name = "checkBoxDungchung";
        checkBoxDungchung.Size = new System.Drawing.Size(215, 17);
        checkBoxDungchung.TabIndex = 85;
        checkBoxDungchung.Text = "Các nhân vật còn lại đều bơm theo tỉ lệ:";
        checkBoxDungchung.UseVisualStyleBackColor = false;
        checkBoxDungchung.CheckedChanged += new System.EventHandler(checkBoxDungchung_CheckedChanged);
        labelXoaPhim.AutoSize = true;
        labelXoaPhim.Cursor = System.Windows.Forms.Cursors.Hand;
        labelXoaPhim.ForeColor = System.Drawing.Color.Blue;
        labelXoaPhim.Location = new System.Drawing.Point(10, 181);
        labelXoaPhim.Name = "labelXoaPhim";
        labelXoaPhim.Size = new System.Drawing.Size(65, 13);
        labelXoaPhim.TabIndex = 77;
        labelXoaPhim.Text = "[ Xóa phím ]";
        labelXoaPhim.Click += new System.EventHandler(labelXoaPhim_Click);
        labelXoaThuoc.AutoSize = true;
        labelXoaThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
        labelXoaThuoc.ForeColor = System.Drawing.Color.Blue;
        labelXoaThuoc.Location = new System.Drawing.Point(200, 181);
        labelXoaThuoc.Name = "labelXoaThuoc";
        labelXoaThuoc.Size = new System.Drawing.Size(68, 13);
        labelXoaThuoc.TabIndex = 75;
        labelXoaThuoc.Text = "[ Xóa thuốc ]";
        labelXoaThuoc.Click += new System.EventHandler(labelXoaThuoc_Click);
        labelThemThuoc.AutoSize = true;
        labelThemThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
        labelThemThuoc.ForeColor = System.Drawing.Color.Blue;
        labelThemThuoc.Location = new System.Drawing.Point(118, 181);
        labelThemThuoc.Name = "labelThemThuoc";
        labelThemThuoc.Size = new System.Drawing.Size(76, 13);
        labelThemThuoc.TabIndex = 74;
        labelThemThuoc.Text = "[ Thêm thuốc ]";
        labelThemThuoc.Click += new System.EventHandler(labelThemThuoc_Click);
        buttonXoaFilecauhinh.BackColor = System.Drawing.SystemColors.Control;
        buttonXoaFilecauhinh.ForeColor = System.Drawing.SystemColors.WindowText;
        buttonXoaFilecauhinh.Location = new System.Drawing.Point(6, 303);
        buttonXoaFilecauhinh.Name = "buttonXoaFilecauhinh";
        buttonXoaFilecauhinh.Size = new System.Drawing.Size(108, 26);
        buttonXoaFilecauhinh.TabIndex = 84;
        buttonXoaFilecauhinh.Text = "Xóa file cấu hình";
        buttonXoaFilecauhinh.UseVisualStyleBackColor = false;
        buttonXoaFilecauhinh.Click += new System.EventHandler(buttonXoaFilecauhinh_Click);
        buttonTaoPhim.ForeColor = System.Drawing.Color.DarkRed;
        buttonTaoPhim.Location = new System.Drawing.Point(6, 152);
        buttonTaoPhim.Name = "buttonTaoPhim";
        buttonTaoPhim.Size = new System.Drawing.Size(69, 21);
        buttonTaoPhim.TabIndex = 86;
        buttonTaoPhim.Text = "Tạo phím";
        buttonTaoPhim.UseVisualStyleBackColor = true;
        buttonTaoPhim.Click += new System.EventHandler(buttonTaoPhim_Click);
        buttonPhimHuongdan.BackColor = System.Drawing.SystemColors.Control;
        buttonPhimHuongdan.ForeColor = System.Drawing.SystemColors.WindowText;
        buttonPhimHuongdan.Location = new System.Drawing.Point(121, 303);
        buttonPhimHuongdan.Name = "buttonPhimHuongdan";
        buttonPhimHuongdan.Size = new System.Drawing.Size(100, 26);
        buttonPhimHuongdan.TabIndex = 87;
        buttonPhimHuongdan.Text = "Phim hướng dẫn";
        buttonPhimHuongdan.UseVisualStyleBackColor = false;
        buttonPhimHuongdan.Click += new System.EventHandler(buttonPhimHuongdan_Click);
        labelTile.AutoSize = true;
        labelTile.Cursor = System.Windows.Forms.Cursors.Hand;
        labelTile.ForeColor = System.Drawing.Color.Blue;
        labelTile.Location = new System.Drawing.Point(322, 211);
        labelTile.Name = "labelTile";
        labelTile.Size = new System.Drawing.Size(57, 13);
        labelTile.TabIndex = 89;
        labelTile.Text = "(giải thích)";
        labelTile.Click += new System.EventHandler(labelTile_Click);
        label3.AutoSize = true;
        label3.ForeColor = System.Drawing.SystemColors.WindowText;
        label3.Location = new System.Drawing.Point(340, 176);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(49, 13);
        label3.TabIndex = 86;
        label3.Text = "Số lượng";
        label2.ForeColor = System.Drawing.Color.Red;
        label2.Location = new System.Drawing.Point(117, 263);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(199, 30);
        label2.TabIndex = 246;
        label2.Text = "Xem và kết hợp với mở túi thuốc ở phần Hậu cần nha các bạn !";
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(238, 211);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(21, 13);
        label4.TabIndex = 247;
        label4.Text = "1 /";
        checkBoxPhiChiendau.AutoSize = true;
        checkBoxPhiChiendau.ForeColor = System.Drawing.Color.DarkRed;
        checkBoxPhiChiendau.Location = new System.Drawing.Point(6, 235);
        checkBoxPhiChiendau.Name = "checkBoxPhiChiendau";
        checkBoxPhiChiendau.Size = new System.Drawing.Size(283, 17);
        checkBoxPhiChiendau.TabIndex = 248;
        checkBoxPhiChiendau.Text = "Sử dụng được luôn ở trong thành và nơi phi chiến đấu";
        checkBoxPhiChiendau.UseVisualStyleBackColor = true;
        checkBoxPhiChiendau.CheckedChanged += new System.EventHandler(checkBoxPhiChiendau_CheckedChanged);
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        base.ClientSize = new System.Drawing.Size(423, 340);
        base.Controls.Add(checkBoxPhiChiendau);
        base.Controls.Add(label4);
        base.Controls.Add(label2);
        base.Controls.Add(labelTile);
        base.Controls.Add(numericUpDown2);
        base.Controls.Add(label3);
        base.Controls.Add(checkBoxDungchung);
        base.Controls.Add(buttonPhimHuongdan);
        base.Controls.Add(buttonXoaFilecauhinh);
        base.Controls.Add(buttonTaoPhim);
        base.Controls.Add(comboBoxPhim);
        base.Controls.Add(buttonApdung);
        base.Controls.Add(labelStatus);
        base.Controls.Add(labelXoaPhim);
        base.Controls.Add(labelXoaThuoc);
        base.Controls.Add(labelThemThuoc);
        base.Controls.Add(listView2);
        base.Controls.Add(numericUpDown1);
        base.Controls.Add(listView1);
        base.Controls.Add(comboBoxThuoc);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        //base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
        base.MaximizeBox = false;
        base.Name = "Combo";
        Text = "COMBO NHOI THUOC";
        base.Load += new System.EventHandler(Combo_Load); base.FormClosing += new FormClosingEventHandler(OnFormClosing);
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ResumeLayout(performLayout: false);
        PerformLayout();
    }

    public Combo()
    {
        bool_0 = true;
        InitializeComponent();
    }

    private void OnFormClosing(object sender, FormClosingEventArgs e)
    {
        method_0();
        GClass0.smethod_1();
        GClass0.smethod_0();
        bool_0 = false;
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
        if (!bool_0)
        {
            Close();
        }
    }

    private void Combo_Load(object sender, EventArgs e)
    {
        if (int_0 > 0 && int_1 > 0)
        {
            int num = int_0 - base.Width - 2;
            int num2 = int_1 + int_3 - base.Height;
            if (num < 0)
            {
                num = 0;
            }
            if (num2 < 0)
            {
                num2 = 0;
            }
            SetBounds(num, num2, base.Width, base.Height);
        }
        if (gstruct42_0.int_129 <= 0)
        {
            this.method_12("COMBO NHOI THUOC");
            buttonApdung.Enabled = false;
        }
        else
        {
            this.method_12("COMBO NHOI THUOC [ " + Class10.smethod_1(gstruct42_0.string_20, 1) + " ]");
            buttonApdung.Enabled = true;
        }
        numericUpDown2.Value = int_4;
        comboBoxThuoc.Items.Clear();
        method_3(gstruct42_0.gstruct39_0);
        method_1(gstruct42_0.gstruct39_0);
        method_2(Class24.gstruct38_1, gstruct42_0.gstruct39_0);
        checkBoxDungchung.Checked = (int_5 > 0);
        checkBoxPhiChiendau.Checked = (int_6 > 0);
        timer_0.Interval = 300;
        timer_0.Enabled = true;
        base.TopMost = true;
    }

    private bool method_0(bool bool_1 = false)
    {
        if (FormMain.gstruct42_0 != null)
        {
            if (bool_1)
            {
                for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
                {
                    FormMain.gstruct42_0[i].gstruct39_0 = gstruct42_0.gstruct39_0;
                    Class47.smethod_11(FormMain.gstruct42_0[i]);
                }
            }
            else
            {
                for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
                {
                    if (FormMain.gstruct42_0[i].int_129 == gstruct42_0.int_129)
                    {
                        FormMain.gstruct42_0[i].gstruct39_0 = gstruct42_0.gstruct39_0;
                        Class47.smethod_11(FormMain.gstruct42_0[i]);
                        break;
                    }
                }
            }
            return true;
        }
        return false;
    }

    private void method_1(GStruct39[] gstruct39_0)
    {
        if (gstruct39_0 != null && gstruct39_0[0].gstruct37_0 != null)
        {
            string_0 = null;
            for (int i = 0; i < gstruct39_0[0].gstruct37_0.Length; i++)
            {
                Class11.smethod_24(ref string_0, gstruct39_0[0].gstruct37_0[i].string_0);
                comboBoxThuoc.Items.Add(Class10.smethod_1(gstruct39_0[0].gstruct37_0[i].string_0, 1));
            }
            comboBoxThuoc.Text = Class10.smethod_1(gstruct39_0[0].gstruct37_0[0].string_0, 1);
        }
    }

    private void method_2(GStruct38[] gstruct38_0, GStruct39[] gstruct39_0)
    {
        if (gstruct38_0 == null)
        {
            return;
        }
        string text = null;
        for (int i = 0; i < gstruct38_0.GetLength(0); i++)
        {
            bool flag = true;
            if (gstruct39_0 != null)
            {
                for (int j = 0; j < gstruct39_0.Length; j++)
                {
                    if (gstruct38_0[i].int_0 == gstruct39_0[j].int_0)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag)
            {
                if (text == null)
                {
                    text = gstruct38_0[i].string_0;
                }
                comboBoxPhim.Items.Add(gstruct38_0[i].string_0);
            }
        }
        if (text != null)
        {
            comboBoxPhim.Text = text;
        }
    }

    private void method_3(GStruct39[] gstruct39_0)
    {
        int_7 = -1;
        if (gstruct39_0 == null)
        {
            return;
        }
        for (int i = 0; i < gstruct39_0.Length; i++)
        {
            string text = Class24.smethod_1(Class24.gstruct38_1, gstruct39_0[i].int_0);
            listView1.Items.Add(new ListViewItem(text));
        }
        int_7 = 0;
        GStruct37[] gstruct37_ = gstruct39_0[0].gstruct37_0;
        if (gstruct37_ != null)
        {
            for (int i = 0; i < gstruct37_.Length; i++)
            {
                method_4(Class10.smethod_1(gstruct37_[i].string_0, 1), gstruct37_[i].int_0);
            }
            listView1.Items[0].Focused = true;
            listView1.Items[0].Selected = true;
            listView2.Items[0].Focused = true;
            listView2.Items[0].Selected = true;
        }
    }

    private void method_4(string string_1, int int_8)
    {
        ListViewItem listViewItem = new ListViewItem(string_1);
        listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, int_8.ToString()));
        listView2.Items.Add(listViewItem);
    }

    private void method_5(bool bool_1 = true)
    {
        int num = method_6(listView1);
        labelThemThuoc.Enabled = (num >= 0);
        labelXoaPhim.Enabled = (num >= 0);
        if (num >= 0 && (!bool_1 || num != int_7))
        {
            int num2 = Class24.smethod_0(Class24.gstruct38_1, listView1.Items[num].SubItems[0].Text);
            if (num2 < 0)
            {
                return;
            }
            int num3 = smethod_1(gstruct42_0.gstruct39_0, num2);
            if (num3 < 0)
            {
                return;
            }
            int_7 = num;
            GStruct39 gStruct = gstruct42_0.gstruct39_0[num3];
            listView2.Items.Clear();
            if (gStruct.gstruct37_0 != null)
            {
                for (int i = 0; i < gStruct.gstruct37_0.Length; i++)
                {
                    method_4(Class10.smethod_1(gStruct.gstruct37_0[i].string_0, 1), gStruct.gstruct37_0[i].int_0);
                }
            }
        }
        else
        {
            int_7 = num;
        }
    }

    private int method_6(ListView listView_0)
    {
        if (listView_0.Items != null)
        {
            for (int i = 0; i < listView_0.Items.Count; i++)
            {
                if (listView_0.Items[i].Selected)
                {
                    return i;
                }
            }
        }
        return -1;
    }

    public static int smethod_0(ListView listView_0, MouseEventArgs mouseEventArgs_0, int int_8 = 0)
    {
        ListViewItem itemAt = listView_0.GetItemAt(mouseEventArgs_0.X, mouseEventArgs_0.Y);
        if (itemAt != null)
        {
            string text = itemAt.SubItems[int_8].Text;
            for (int i = 0; i < listView_0.Items.Count; i++)
            {
                string text2 = listView_0.Items[i].SubItems[int_8].Text;
                if (text == text2)
                {
                    return i;
                }
            }
        }
        return -1;
    }

    private static int smethod_1(GStruct39[] gstruct39_0, int int_8)
    {
        if (gstruct39_0 != null)
        {
            for (int i = 0; i < gstruct39_0.Length; i++)
            {
                if (int_8 == gstruct39_0[i].int_0)
                {
                    return i;
                }
            }
        }
        return -1;
    }

    private static int smethod_2(GStruct37[] gstruct37_0, string string_1)
    {
        if (gstruct37_0 != null)
        {
            for (int i = 0; i < gstruct37_0.Length; i++)
            {
                if (string_1 == gstruct37_0[i].string_0 || Class10.smethod_1(string_1, 1) == gstruct37_0[i].string_0 || string_1 == Class10.smethod_1(gstruct37_0[i].string_0, 1))
                {
                    return i;
                }
            }
        }
        return -1;
    }

    private void method_7(ref GStruct39[] gstruct39_0, string string_1)
    {
        int num = Class24.smethod_0(Class24.gstruct38_1, string_1);
        if (num < 0 || gstruct39_0 == null || gstruct39_0.Length == 0)
        {
            return;
        }
        int num2 = 0;
        GStruct39[] array = new GStruct39[gstruct39_0.Length];
        for (int i = 0; i < gstruct39_0.Length; i++)
        {
            if (gstruct39_0[i].int_0 != num)
            {
                array[num2] = gstruct39_0[i];
                num2++;
            }
        }
        if (num2 != 0)
        {
            GStruct39[] array2 = new GStruct39[num2];
            for (int i = 0; i < num2; i++)
            {
                array2[i] = array[i];
            }
            gstruct39_0 = array2;
        }
        else
        {
            gstruct39_0 = null;
        }
    }

    private void method_8(ref GStruct39[] gstruct39_0, string string_1)
    {
        GStruct39 gStruct = default(GStruct39);
        gStruct.int_0 = Class24.smethod_0(Class24.gstruct38_1, string_1);
        gStruct.gstruct37_0 = null;
        GStruct39 gStruct2 = gStruct;
        if (gstruct39_0 != null && gstruct39_0.Length != 0)
        {
            GStruct39[] array = new GStruct39[gstruct39_0.Length + 1];
            for (int i = 0; i < gstruct39_0.Length; i++)
            {
                array[i] = gstruct39_0[i];
                if (gstruct39_0[i].int_0 == gStruct2.int_0)
                {
                    return;
                }
            }
            array[array.Length - 1] = gStruct2;
            gstruct39_0 = array;
        }
        else
        {
            gstruct39_0 = new GStruct39[1]
            {
                gStruct2
            };
        }
    }

    private void method_9(ref GStruct37[] gstruct37_0, string string_1, int int_8)
    {
        string_1 = string_1.Trim();
        GStruct37 gStruct = default(GStruct37);
        gStruct.string_0 = string_1;
        gStruct.int_0 = int_8;
        GStruct37 gStruct2 = gStruct;
        if (gstruct37_0 != null && gstruct37_0.Length != 0)
        {
            GStruct37[] array = new GStruct37[gstruct37_0.Length + 1];
            for (int i = 0; i < gstruct37_0.Length; i++)
            {
                array[i] = gstruct37_0[i];
                if (gstruct37_0[i].string_0 == string_1 && string_1 != null)
                {
                    return;
                }
            }
            array[array.Length - 1] = gStruct2;
            gstruct37_0 = array;
        }
        else
        {
            gstruct37_0 = new GStruct37[1]
            {
                gStruct2
            };
        }
    }

    private void method_10(ref GStruct37[] gstruct37_0, string string_1)
    {
        if (string_1 == null || string_1 == "")
        {
            return;
        }
        int num = 0;
        GStruct37[] array = new GStruct37[gstruct37_0.Length];
        for (int i = 0; i < gstruct37_0.Length; i++)
        {
            if (!(gstruct37_0[i].string_0 == string_1) && !(Class10.smethod_1(gstruct37_0[i].string_0, 1) == string_1) && !(gstruct37_0[i].string_0 == Class10.smethod_1(string_1, 1)))
            {
                array[num] = gstruct37_0[i];
                num++;
            }
        }
        if (num != 0)
        {
            GStruct37[] array2 = new GStruct37[num];
            for (int i = 0; i < num; i++)
            {
                array2[i] = array[i];
            }
            gstruct37_0 = array2;
        }
        else
        {
            gstruct37_0 = null;
        }
    }

    private void comboBoxThuoc_MouseDown(object sender, MouseEventArgs e)
    {
        string text = comboBoxThuoc.Text;
        comboBoxThuoc.Items.Clear();
        if (gstruct42_0.int_129 != 0 && Class20.smethod_51(gstruct42_0.int_129))
        {
            string_0 = null;
            string text2 = null;
            string text3 = "";
            for (uint num = 0u; num < Class47.int_1; num++)
            {
                uint num2 = Class69.smethod_0(gstruct42_0, num);
                if (num2 == 0)
                {
                    continue;
                }
                int num3 = Class69.smethod_7(gstruct42_0, num);
                if (num3 == 0 || num3 == 4)
                {
                    continue;
                }
                uint num4 = Class69.smethod_3(gstruct42_0, num2);
                if (num4 != 1 && num4 != 3)
                {
                    continue;
                }
                string text4 = Class69.smethod_6(gstruct42_0, num).Trim();
                if (!(text4 == string.Empty) && Class11.smethod_2(text3, text4) < 0)
                {
                    Class11.smethod_24(ref string_0, text4);
                    comboBoxThuoc.Items.Add(Class10.smethod_1(text4, 1));
                    text3 = text3 + text4 + "|";
                    if (text2 == null || text4 == text)
                    {
                        text2 = text;
                    }
                }
            }
            if (text2 != null)
            {
                comboBoxThuoc.Text = text2;
            }
        }
        else if (gstruct42_0.int_129 > 0)
        {
            buttonApdung.Enabled = false;
            gstruct42_0.int_129 = 0;
        }
    }

    private void listView1_MouseDown(object sender, MouseEventArgs e)
    {
        int num = smethod_0(listView1, e);
        labelThemThuoc.Enabled = (num >= 0);
    }

    private void listView1_MouseClick(object sender, MouseEventArgs e)
    {
        method_5();
    }

    private void listView2_MouseDown(object sender, MouseEventArgs e)
    {
        int num = smethod_0(listView2, e);
        labelXoaThuoc.Enabled = (num >= 0);
    }

    private void listView2_MouseClick(object sender, MouseEventArgs e)
    {
        int num = method_6(listView2);
        labelXoaThuoc.Enabled = (num >= 0);
        if (num >= 0)
        {
            comboBoxThuoc.Text = listView2.Items[num].SubItems[0].Text;
            numericUpDown1.Value = Class11.smethod_12(listView2.Items[num].SubItems[1].Text);
        }
    }

    private void method_11()
    {
        int num = method_6(listView2);
        if (num < 0 || int_7 < 0 || int_7 >= listView1.Items.Count)
        {
            return;
        }
        int num2 = Class24.smethod_0(Class24.gstruct38_1, listView1.Items[int_7].SubItems[0].Text);
        if (num2 < 0)
        {
            return;
        }
        int num3 = smethod_1(gstruct42_0.gstruct39_0, num2);
        if (num3 >= 0)
        {
            int num4 = smethod_2(gstruct42_0.gstruct39_0[num3].gstruct37_0, listView2.Items[num].SubItems[0].Text);
            if (num4 >= 0)
            {
                listView2.Items[num].SubItems[1].Text = numericUpDown1.Value.ToString();
                gstruct42_0.gstruct39_0[num3].gstruct37_0[num4].int_0 = (int)numericUpDown1.Value;
            }
        }
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        method_11();
    }

    private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
    {
        method_11();
    }

    private void numericUpDown2_KeyUp(object sender, KeyEventArgs e)
    {
        if (timer_0.Enabled)
        {
            int_4 = (int)numericUpDown2.Value;
            Class55.smethod_10(Class47.string_0, "flagTileBom", int_4, "", 0);
        }
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
        if (timer_0.Enabled)
        {
            int_4 = (int)numericUpDown2.Value;
            Class55.smethod_10(Class47.string_0, "flagBomDelay", int_4, "", 0);
        }
    }

    private void buttonApdung_Click(object sender, EventArgs e)
    {
        string text = null;
        text = ((!method_0()) ? ("Lưu cấu hình thất bại (không tồn tại " + Class10.smethod_1(gstruct42_0.string_20, 1) + ").") : (Class10.smethod_1(gstruct42_0.string_20, 1) + ": đã lưu cấu hình combo."));
        GClass0.smethod_1();
        GClass0.smethod_0();
        Class11.smethod_24(ref Class11.string_14, text);
        Close();
    }

    private void buttonXoaFilecauhinh_Click(object sender, EventArgs e)
    {
        Class11.smethod_44(Class47.string_7);
        gstruct42_0.gstruct39_0 = null;
        if (FormMain.gstruct42_0 != null)
        {
            for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
            {
                FormMain.gstruct42_0[i].gstruct39_0 = null;
            }
        }
        comboBoxPhim.Items.Clear();
        if (Class24.gstruct38_1 != null)
        {
            for (int i = 0; i < Class24.gstruct38_1.Length; i++)
            {
                comboBoxPhim.Items.Add(Class24.gstruct38_1[i].string_0);
            }
            comboBoxPhim.Text = Class24.gstruct38_1[0].string_0;
        }
        listView1.Items.Clear();
        listView2.Items.Clear();
        labelStatus.Text = "Đã xóa cấu hình combo của tất cả nhân vật.";
    }

    private void checkBoxDungchung_CheckedChanged(object sender, EventArgs e)
    {
        if (timer_0.Enabled)
        {
            int_5 = Convert.ToByte(checkBoxDungchung.Checked);
            Class55.smethod_10(Class47.string_0, "flagBomChungThuoc", int_5, "", 0);
        }
    }

    private void labelThemThuoc_Click(object sender, EventArgs e)
    {
        if (string_0 == null)
        {
            return;
        }
        string text = comboBoxThuoc.Text;
        if (!(text == "") && int_7 >= 0 && int_7 < listView1.Items.Count)
        {
            int num = Class24.smethod_0(Class24.gstruct38_1, listView1.Items[int_7].SubItems[0].Text);
            if (num >= 0)
            {
                int num2 = smethod_1(gstruct42_0.gstruct39_0, num);
                if (num2 >= 0)
                {
                    if (listView2.Items.Count > 0)
                    {
                        for (int i = 0; i < listView2.Items.Count; i++)
                        {
                            if (text == listView2.Items[i].SubItems[0].Text)
                            {
                                return;
                            }
                        }
                    }
                    string text2 = null;
                    for (int i = 0; i < string_0.Length; i++)
                    {
                        if (text == Class10.smethod_1(string_0[i], 1))
                        {
                            text2 = string_0[i];
                            break;
                        }
                    }
                    if (text2 != null)
                    {
                        int int_ = (int)numericUpDown1.Value;
                        method_4(Class10.smethod_1(text2, 1), int_);
                        method_9(ref gstruct42_0.gstruct39_0[num2].gstruct37_0, text2, int_);
                    }
                }
                else
                {
                    labelStatus.Text = "Hãy chọn phím bơm và chọn tên thuốc rồi bấm nút thêm.";
                }
            }
            else
            {
                labelStatus.Text = "Hãy chọn phím bơm và chọn tên thuốc rồi bấm nút thêm.";
            }
        }
        else
        {
            labelStatus.Text = "Hãy chọn phím bơm và chọn tên thuốc rồi bấm nút thêm.";
        }
    }

    private void labelXoaThuoc_Click(object sender, EventArgs e)
    {
        int num = method_6(listView2);
        if (num < 0 || int_7 < 0 || int_7 >= listView1.Items.Count)
        {
            return;
        }
        int num2 = Class24.smethod_0(Class24.gstruct38_1, listView1.Items[int_7].SubItems[0].Text);
        if (num2 >= 0)
        {
            int num3 = smethod_1(gstruct42_0.gstruct39_0, num2);
            if (num3 >= 0)
            {
                method_10(ref gstruct42_0.gstruct39_0[num3].gstruct37_0, listView2.Items[num].SubItems[0].Text);
                listView2.Items.RemoveAt(num);
                labelXoaThuoc.Enabled = (listView2.Items.Count > 0);
            }
        }
    }

    private void labelXoaPhim_Click(object sender, EventArgs e)
    {
        int num = method_6(listView1);
        if (num < 0)
        {
            return;
        }
        string text = listView1.Items[num].SubItems[0].Text;
        listView1.Items.RemoveAt(num);
        method_7(ref gstruct42_0.gstruct39_0, text);
        if (num > listView1.Items.Count - 1)
        {
            num = listView1.Items.Count - 1;
        }
        labelXoaThuoc.Enabled = (num >= 0);
        if (num < 0)
        {
            listView2.Items.Clear();
        }
        else
        {
            listView1.Items[num].Selected = true;
            listView1.Items[num].Focused = true;
            method_5(bool_1: false);
        }
        int_7 = num;
        for (int i = 0; i < comboBoxPhim.Items.Count; i++)
        {
            if (text == comboBoxPhim.Items[i].ToString())
            {
                return;
            }
        }
        comboBoxPhim.Items.Add(text);
        comboBoxPhim.Sorted = true;
        if (comboBoxPhim.Text == "")
        {
            comboBoxPhim.Text = text;
        }
        labelXoaPhim.Enabled = (listView1.Items.Count > 0);
        labelThemThuoc.Enabled = (int_7 >= 0);
    }

    private void buttonTaoPhim_Click(object sender, EventArgs e)
    {
        string text = comboBoxPhim.Text;
        if (text == "")
        {
            return;
        }
        if (listView1.Items.Count > 0)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (text == listView1.Items[i].SubItems[0].Text)
                {
                    return;
                }
            }
        }
        listView1.Items.Add(new ListViewItem(text));
        method_8(ref gstruct42_0.gstruct39_0, text);
        for (int i = 0; i < comboBoxPhim.Items.Count; i++)
        {
            if (text == comboBoxPhim.Items[i].ToString())
            {
                comboBoxPhim.Items.RemoveAt(i);
                if (i >= comboBoxPhim.Items.Count)
                {
                    i = comboBoxPhim.Items.Count - 1;
                }
                if (i >= 0)
                {
                    comboBoxPhim.Text = comboBoxPhim.Items[i].ToString();
                }
                break;
            }
        }
        labelXoaPhim.Enabled = (listView1.Items.Count > 0);
    }

    private void buttonPhimHuongdan_Click(object sender, EventArgs e)
    {
        string string_ = "https://www.youtube.com/watch?v=1duqVxbJRKk";
        Class20.smethod_40(Class55.smethod_0(), "", string_, 0);
    }

    private void labelTile_Click(object sender, EventArgs e)
    {
        string string_ = "Tỉ lệ bơm thuốc:|Giả sử ac thao tác để bơm Ngũ Hoa 10 bình, Cửu chuyển 10 bình thì:||Ví dụ tỉ lệ 1/2 (1 chia 2 = 0,50 => Số dư 0):|- Ac thao tác bơm đúng 10 bình Ngũ Hoa và 10 bình Cửu chuyển.|- Các ac còn lại bơm theo tỉ lệ 1/2 (tức 0,5) nên sẽ bơm 5 bình Ngũ Hoa và 5 bình Cửu chuyển.||Ví dụ tỉ lệ 1/3 (1 chia 3 = 0,33 => Số dư 3 > 0):|- Ac thao tác bơm đúng 10 bình Ngũ Hoa và 10 bình Cửu chuyển.|- Do số dư > 0 nên ac thao tác sẽ bơm với số lượng + 1, tức sẽ bơm 4 bình ngũ hoa và 4 bình Cửu chuyển.||Lưu ý: ac thao tác là ac trên cửa sổ game mà bạn đang cầm chuột điều khiển, bất kể đó là ac chính hay ac phụ cũng được. Khi combo, ac đang ở trong thành thì sẽ không bơm thuốc.";
        FormTip.smethod_0("BOM THUOC", string_, 600000, 420, 250);
    }

    private void checkBoxPhiChiendau_CheckedChanged(object sender, EventArgs e)
    {
        if (timer_0.Enabled)
        {
            int_6 = Convert.ToByte(checkBoxPhiChiendau.Checked);
            Class55.smethod_10(Class47.string_0, "flagPhiCD", int_6, "", 0);
        }
    }

    void method_12(string string_1)
    {
        base.Text = string_1;
    }
}
