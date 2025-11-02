using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormLocdoTest : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private TextBox textBoxMin;

	private Button buttonSua;

	private TextBox textBoxName;

	private CheckBox checkBoxThoahet;

	private CheckBox checkBox1;

	private TextBox textBox1;

	private TextBox textBox2;

	private CheckBox checkBox2;

	private TextBox textBox3;

	private CheckBox checkBox3;

	private TextBox textBox4;

	private CheckBox checkBox4;

	private TextBox textBox5;

	private CheckBox checkBox5;

	private TextBox textBox6;

	private CheckBox checkBox6;

	private Button buttonApdungAll;

	private CheckBox checkBoxBanVpHoagkimTest;

	private ColumnHeader columnHeader_3;

	private TextBox textBoxDong;

	private Label label1;

	private ListView listView2;

	private ColumnHeader columnHeader_4;

	private ColumnHeader columnHeader_5;

	private CheckBox checkBoxCoNopVP;

	private ComboBox comboBoxNopVP;

	private TextBox textBoxSoluongNop;

	private Button buttonXoa;

	private Button buttonThem;

	private ColumnHeader columnHeader_6;

	private LinkLabel linkLabelLuuy;

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static string string_0 = Class11.smethod_16(Class55.smethod_6("TenVatPhamNhanTrangbiTest", 0));

	public static int int_2 = Class55.smethod_3("NhapSoluongTest", 0, "10");

	public static int int_3 = Class55.smethod_3("fCoNhapSLTest", 0, "0");

	public static int int_4 = Class55.smethod_3("DayLaNPC", 0, "0");

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static GStruct50[] gstruct50_0 = null;

	public static int int_5 = Class55.smethod_3("fLocNopVP", 0, "0");

	public static int[] int_6 = new int[2]
	{
		Class55.smethod_3("TrangbiDong1_0", 0, "0"),
		Class55.smethod_3("TrangbiDong1_1", 0, "0")
	};

	public static int[] int_7 = new int[2]
	{
		Class55.smethod_3("TrangbiDong2_0", 0, "0"),
		Class55.smethod_3("TrangbiDong2_1", 0, "0")
	};

	public static int[] int_8 = new int[2]
	{
		Class55.smethod_3("TrangbiDong3_0", 0, "0"),
		Class55.smethod_3("TrangbiDong3_1", 0, "0")
	};

	public static int[] int_9 = new int[2]
	{
		Class55.smethod_3("TrangbiDong4_0", 0, "0"),
		Class55.smethod_3("TrangbiDong4_1", 0, "0")
	};

	public static int[] int_10 = new int[2]
	{
		Class55.smethod_3("TrangbiDong5_0", 0, "0"),
		Class55.smethod_3("TrangbiDong5_1", 0, "0")
	};

	public static int[] int_11 = new int[2]
	{
		Class55.smethod_3("TrangbiDong6_0", 0, "0"),
		Class55.smethod_3("TrangbiDong6_1", 0, "0")
	};

	public static int[] int_12 = null;

	public int int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public static bool bool_2 = false;

	private Color color_0 = Color.DarkGreen;

	private static long long_0 = 0L;

	private static bool bool_3 = false;

	private static string[] string_1 = null;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormLocdoTest));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonClose = new System.Windows.Forms.Button();
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		textBoxMin = new System.Windows.Forms.TextBox();
		buttonSua = new System.Windows.Forms.Button();
		textBoxName = new System.Windows.Forms.TextBox();
		checkBoxThoahet = new System.Windows.Forms.CheckBox();
		checkBox1 = new System.Windows.Forms.CheckBox();
		textBox1 = new System.Windows.Forms.TextBox();
		textBox2 = new System.Windows.Forms.TextBox();
		checkBox2 = new System.Windows.Forms.CheckBox();
		textBox3 = new System.Windows.Forms.TextBox();
		checkBox3 = new System.Windows.Forms.CheckBox();
		textBox4 = new System.Windows.Forms.TextBox();
		checkBox4 = new System.Windows.Forms.CheckBox();
		textBox5 = new System.Windows.Forms.TextBox();
		checkBox5 = new System.Windows.Forms.CheckBox();
		textBox6 = new System.Windows.Forms.TextBox();
		checkBox6 = new System.Windows.Forms.CheckBox();
		buttonApdungAll = new System.Windows.Forms.Button();
		checkBoxBanVpHoagkimTest = new System.Windows.Forms.CheckBox();
		textBoxDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		listView2 = new System.Windows.Forms.ListView();
		columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		columnHeader_5 = new System.Windows.Forms.ColumnHeader();
		columnHeader_6 = new System.Windows.Forms.ColumnHeader();
		checkBoxCoNopVP = new System.Windows.Forms.CheckBox();
		comboBoxNopVP = new System.Windows.Forms.ComboBox();
		textBoxSoluongNop = new System.Windows.Forms.TextBox();
		buttonXoa = new System.Windows.Forms.Button();
		buttonThem = new System.Windows.Forms.Button();
		linkLabelLuuy = new System.Windows.Forms.LinkLabel();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonClose.Location = new System.Drawing.Point(234, 503);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(101, 26);
		buttonClose.TabIndex = 8;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		listView1.CheckBoxes = true;
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4]
		{
			columnHeader_0,
			columnHeader_1,
			columnHeader_2,
			columnHeader_3
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(12, 239);
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(361, 197);
		listView1.TabIndex = 34;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		columnHeader_0.Text = "No";
		columnHeader_0.Width = 45;
		columnHeader_1.Text = "Thuộc tính";
		columnHeader_1.Width = 220;
		columnHeader_2.Text = "Min";
		columnHeader_2.Width = 33;
		columnHeader_3.Text = "Dòng";
		columnHeader_3.Width = 40;
		textBoxMin.Location = new System.Drawing.Point(267, 441);
		textBoxMin.Name = "textBoxMin";
		textBoxMin.Size = new System.Drawing.Size(33, 20);
		textBoxMin.TabIndex = 38;
		buttonSua.Location = new System.Drawing.Point(328, 441);
		buttonSua.Name = "buttonSua";
		buttonSua.Size = new System.Drawing.Size(45, 21);
		buttonSua.TabIndex = 39;
		buttonSua.Text = "Sửa";
		buttonSua.UseVisualStyleBackColor = true;
		buttonSua.Click += new System.EventHandler(buttonSua_Click);
		textBoxName.ForeColor = System.Drawing.Color.Blue;
		textBoxName.Location = new System.Drawing.Point(12, 441);
		textBoxName.Name = "textBoxName";
		textBoxName.ReadOnly = true;
		textBoxName.Size = new System.Drawing.Size(249, 20);
		textBoxName.TabIndex = 40;
		checkBoxThoahet.AutoSize = true;
		checkBoxThoahet.ForeColor = System.Drawing.Color.Purple;
		checkBoxThoahet.Location = new System.Drawing.Point(12, 218);
		checkBoxThoahet.Name = "checkBoxThoahet";
		checkBoxThoahet.Size = new System.Drawing.Size(283, 17);
		checkBoxThoahet.TabIndex = 43;
		checkBoxThoahet.Text = "Lọc đúng hết điều kiện thuộc tính dưới đây thì mới giữ";
		checkBoxThoahet.UseVisualStyleBackColor = true;
		checkBoxThoahet.CheckedChanged += new System.EventHandler(checkBoxThoahet_CheckedChanged);
		checkBox1.AutoSize = true;
		checkBox1.ForeColor = System.Drawing.Color.DarkRed;
		checkBox1.Location = new System.Drawing.Point(12, 145);
		checkBox1.Name = "checkBox1";
		checkBox1.Size = new System.Drawing.Size(61, 17);
		checkBox1.TabIndex = 44;
		checkBox1.Text = "Dòng 1";
		checkBox1.UseVisualStyleBackColor = true;
		checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		textBox1.ForeColor = System.Drawing.Color.Black;
		textBox1.Location = new System.Drawing.Point(88, 145);
		textBox1.Name = "textBox1";
		textBox1.Size = new System.Drawing.Size(33, 20);
		textBox1.TabIndex = 45;
		textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		textBox2.ForeColor = System.Drawing.Color.Black;
		textBox2.Location = new System.Drawing.Point(88, 168);
		textBox2.Name = "textBox2";
		textBox2.Size = new System.Drawing.Size(33, 20);
		textBox2.TabIndex = 47;
		textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
		checkBox2.AutoSize = true;
		checkBox2.ForeColor = System.Drawing.Color.DarkRed;
		checkBox2.Location = new System.Drawing.Point(12, 170);
		checkBox2.Name = "checkBox2";
		checkBox2.Size = new System.Drawing.Size(61, 17);
		checkBox2.TabIndex = 46;
		checkBox2.Text = "Dòng 2";
		checkBox2.UseVisualStyleBackColor = true;
		checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		textBox3.ForeColor = System.Drawing.Color.Black;
		textBox3.Location = new System.Drawing.Point(217, 145);
		textBox3.Name = "textBox3";
		textBox3.Size = new System.Drawing.Size(33, 20);
		textBox3.TabIndex = 51;
		textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged);
		checkBox3.AutoSize = true;
		checkBox3.ForeColor = System.Drawing.Color.DarkRed;
		checkBox3.Location = new System.Drawing.Point(150, 145);
		checkBox3.Name = "checkBox3";
		checkBox3.Size = new System.Drawing.Size(61, 17);
		checkBox3.TabIndex = 50;
		checkBox3.Text = "Dòng 3";
		checkBox3.UseVisualStyleBackColor = true;
		checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		textBox4.ForeColor = System.Drawing.Color.Black;
		textBox4.Location = new System.Drawing.Point(217, 168);
		textBox4.Name = "textBox4";
		textBox4.Size = new System.Drawing.Size(33, 20);
		textBox4.TabIndex = 49;
		textBox4.TextChanged += new System.EventHandler(textBox4_TextChanged);
		checkBox4.AutoSize = true;
		checkBox4.ForeColor = System.Drawing.Color.DarkRed;
		checkBox4.Location = new System.Drawing.Point(150, 170);
		checkBox4.Name = "checkBox4";
		checkBox4.Size = new System.Drawing.Size(61, 17);
		checkBox4.TabIndex = 48;
		checkBox4.Text = "Dòng 4";
		checkBox4.UseVisualStyleBackColor = true;
		checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		textBox5.ForeColor = System.Drawing.Color.Black;
		textBox5.Location = new System.Drawing.Point(340, 145);
		textBox5.Name = "textBox5";
		textBox5.Size = new System.Drawing.Size(33, 20);
		textBox5.TabIndex = 55;
		textBox5.TextChanged += new System.EventHandler(textBox5_TextChanged);
		checkBox5.AutoSize = true;
		checkBox5.ForeColor = System.Drawing.Color.DarkRed;
		checkBox5.Location = new System.Drawing.Point(273, 145);
		checkBox5.Name = "checkBox5";
		checkBox5.Size = new System.Drawing.Size(61, 17);
		checkBox5.TabIndex = 54;
		checkBox5.Text = "Dòng 5";
		checkBox5.UseVisualStyleBackColor = true;
		checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		textBox6.ForeColor = System.Drawing.Color.Black;
		textBox6.Location = new System.Drawing.Point(340, 168);
		textBox6.Name = "textBox6";
		textBox6.Size = new System.Drawing.Size(33, 20);
		textBox6.TabIndex = 53;
		textBox6.TextChanged += new System.EventHandler(textBox6_TextChanged);
		checkBox6.AutoSize = true;
		checkBox6.ForeColor = System.Drawing.Color.DarkRed;
		checkBox6.Location = new System.Drawing.Point(273, 170);
		checkBox6.Name = "checkBox6";
		checkBox6.Size = new System.Drawing.Size(61, 17);
		checkBox6.TabIndex = 52;
		checkBox6.Text = "Dòng 6";
		checkBox6.UseVisualStyleBackColor = true;
		checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		buttonApdungAll.ForeColor = System.Drawing.Color.DarkRed;
		buttonApdungAll.Location = new System.Drawing.Point(42, 503);
		buttonApdungAll.Name = "buttonApdungAll";
		buttonApdungAll.Size = new System.Drawing.Size(173, 26);
		buttonApdungAll.TabIndex = 56;
		buttonApdungAll.Text = "Áp dụng cho tất cả ac";
		buttonApdungAll.UseVisualStyleBackColor = true;
		buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		checkBoxBanVpHoagkimTest.AutoSize = true;
		checkBoxBanVpHoagkimTest.ForeColor = System.Drawing.Color.Red;
		checkBoxBanVpHoagkimTest.Location = new System.Drawing.Point(12, 195);
		checkBoxBanVpHoagkimTest.Name = "checkBoxBanVpHoagkimTest";
		checkBoxBanVpHoagkimTest.Size = new System.Drawing.Size(215, 17);
		checkBoxBanVpHoagkimTest.TabIndex = 190;
		checkBoxBanVpHoagkimTest.Text = "Bán luôn trang bị hoàng kim (cẩn thận !)";
		checkBoxBanVpHoagkimTest.UseVisualStyleBackColor = true;
		checkBoxBanVpHoagkimTest.CheckedChanged += new System.EventHandler(checkBoxBanVpHoagkimTest_CheckedChanged);
		textBoxDong.Location = new System.Drawing.Point(305, 441);
		textBoxDong.Name = "textBoxDong";
		textBoxDong.Size = new System.Drawing.Size(20, 20);
		textBoxDong.TabIndex = 191;
		label1.Location = new System.Drawing.Point(12, 470);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(361, 31);
		label1.TabIndex = 192;
		label1.Text = "Giá trị của Dòng (kế bên Min): Ghi 0 nếu không xét điều kiện dòng, tức là dòng nào cũng được";
		listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3]
		{
			columnHeader_4,
			columnHeader_5,
			columnHeader_6
		});
		listView2.ForeColor = System.Drawing.Color.Black;
		listView2.FullRowSelect = true;
		listView2.GridLines = true;
		listView2.HideSelection = false;
		listView2.Location = new System.Drawing.Point(12, 29);
		listView2.MultiSelect = false;
		listView2.Name = "listView2";
		listView2.Size = new System.Drawing.Size(361, 71);
		listView2.TabIndex = 194;
		listView2.UseCompatibleStateImageBehavior = false;
		listView2.View = System.Windows.Forms.View.Details;
		columnHeader_4.Text = "No";
		columnHeader_4.Width = 45;
		columnHeader_5.Text = "Tên vật phẩm cần nộp";
		columnHeader_5.Width = 200;
		columnHeader_6.Text = "Số lượng mỗi lần nộp";
		columnHeader_6.Width = 90;
		checkBoxCoNopVP.AutoSize = true;
		checkBoxCoNopVP.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxCoNopVP.Location = new System.Drawing.Point(12, 4);
		checkBoxCoNopVP.Name = "checkBoxCoNopVP";
		checkBoxCoNopVP.Size = new System.Drawing.Size(168, 17);
		checkBoxCoNopVP.TabIndex = 195;
		checkBoxCoNopVP.Text = "Có nộp vật phẩm trước khi lọc";
		checkBoxCoNopVP.UseVisualStyleBackColor = true;
		checkBoxCoNopVP.CheckedChanged += new System.EventHandler(checkBoxCoNopVP_CheckedChanged);
		comboBoxNopVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxNopVP.FormattingEnabled = true;
		comboBoxNopVP.Location = new System.Drawing.Point(124, 105);
		comboBoxNopVP.Name = "comboBoxNopVP";
		comboBoxNopVP.Size = new System.Drawing.Size(203, 21);
		comboBoxNopVP.TabIndex = 203;
		comboBoxNopVP.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxNopVP_MouseDown);
		textBoxSoluongNop.ForeColor = System.Drawing.Color.Black;
		textBoxSoluongNop.Location = new System.Drawing.Point(331, 106);
		textBoxSoluongNop.Name = "textBoxSoluongNop";
		textBoxSoluongNop.Size = new System.Drawing.Size(42, 20);
		textBoxSoluongNop.TabIndex = 204;
		textBoxSoluongNop.Text = "1";
		buttonXoa.Location = new System.Drawing.Point(12, 105);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(45, 21);
		buttonXoa.TabIndex = 205;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		buttonThem.Location = new System.Drawing.Point(63, 105);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(58, 21);
		buttonThem.TabIndex = 206;
		buttonThem.Text = "Thêm";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		linkLabelLuuy.AutoSize = true;
		linkLabelLuuy.Location = new System.Drawing.Point(183, 7);
		linkLabelLuuy.Name = "linkLabelLuuy";
		linkLabelLuuy.Size = new System.Drawing.Size(190, 13);
		linkLabelLuuy.TabIndex = 207;
		linkLabelLuuy.TabStop = true;
		linkLabelLuuy.Text = "==> click ở đây để xem ngay lưu ý <==";
		linkLabelLuuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelLuuy_LinkClicked);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(378, 535);
		base.Controls.Add(linkLabelLuuy);
		base.Controls.Add(buttonThem);
		base.Controls.Add(buttonXoa);
		base.Controls.Add(textBoxSoluongNop);
		base.Controls.Add(comboBoxNopVP);
		base.Controls.Add(checkBoxCoNopVP);
		base.Controls.Add(listView2);
		base.Controls.Add(label1);
		base.Controls.Add(textBoxDong);
		base.Controls.Add(checkBoxBanVpHoagkimTest);
		base.Controls.Add(buttonApdungAll);
		base.Controls.Add(textBox5);
		base.Controls.Add(checkBox5);
		base.Controls.Add(textBox6);
		base.Controls.Add(checkBox6);
		base.Controls.Add(textBox3);
		base.Controls.Add(checkBox3);
		base.Controls.Add(textBox4);
		base.Controls.Add(checkBox4);
		base.Controls.Add(textBox2);
		base.Controls.Add(checkBox2);
		base.Controls.Add(textBox1);
		base.Controls.Add(checkBox1);
		base.Controls.Add(checkBoxThoahet);
		base.Controls.Add(listView1);
		base.Controls.Add(textBoxName);
		base.Controls.Add(buttonClose);
		base.Controls.Add(textBoxMin);
		base.Controls.Add(buttonSua);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormLocdoTest";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "LOC TRANG BI TEST";
		base.Load += new System.EventHandler(FormLocdoTest_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public static GStruct50[] smethod_0()
	{
		string text = Class11.smethod_16(Class11.smethod_28(Class47.string_5 + "\\LocNop.txt", 0, 0, 1));
		if (text != null && !(text == string.Empty))
		{
			string[] array = text.Split('|');
			GStruct50[] array2 = new GStruct50[array.Length];
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && !(array[i] == string.Empty))
				{
					string[] array3 = array[i].Split(';');
					if (array3.Length == 2)
					{
						array2[num].string_0 = array3[0];
						array2[num].int_0 = Class11.smethod_12(array3[1]);
						num++;
					}
				}
			}
			if (num != 0)
			{
				if (num < array2.Length)
				{
					Array.Resize(ref array2, num);
				}
				return array2;
			}
			return null;
		}
		return null;
	}

	public static void smethod_1(GStruct50[] gstruct50_1)
	{
		string text = string.Empty;
		if (gstruct50_1 != null)
		{
			for (int i = 0; i < gstruct50_1.Length; i++)
			{
				if (text != string.Empty)
				{
					text += "|";
				}
				object obj = text;
				text = obj + gstruct50_1[i].string_0 + ";" + gstruct50_1[i].int_0;
			}
			text = Class11.smethod_17(text);
		}
		Class11.smethod_29(Class47.string_5 + "\\LocNop.txt", text, 1);
	}

	public FormLocdoTest()
	{
		bool_2 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		smethod_1(gstruct50_0);
		int_13 = 0;
		int_14 = 0;
		bool_2 = false;
	}

	private void FormLocdoTest_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		if (int_13 >= 0 && int_14 >= 0)
		{
			int num = int_13 - base.Width;
			int num2 = int_14 + int_16 - base.Height;
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
		base.TopMost = true;
		gstruct50_0 = smethod_0();
		if (gstruct50_0 != null)
		{
			for (int i = 0; i < gstruct50_0.Length; i++)
			{
				method_0(gstruct50_0[i]);
			}
		}
		checkBoxCoNopVP.Checked = (int_5 > 0);
		checkBox1.Checked = (int_6[0] > 0);
		textBox1.Text = int_6[1].ToString();
		checkBox2.Checked = (int_7[0] > 0);
		textBox2.Text = int_7[1].ToString();
		checkBox3.Checked = (int_8[0] > 0);
		textBox3.Text = int_8[1].ToString();
		checkBox4.Checked = (int_9[0] > 0);
		textBox4.Text = int_9[1].ToString();
		checkBox5.Checked = (int_10[0] > 0);
		textBox5.Text = int_10[1].ToString();
		checkBox6.Checked = (int_11[0] > 0);
		textBox6.Text = int_11[1].ToString();
		checkBoxBanVpHoagkimTest.Checked = bool_1;
		checkBoxThoahet.Checked = bool_0;
		int num3 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (0 > num3)
		{
			GStruct33 gStruct = default(GStruct33);
			gStruct.string_0 = "Chưa chọn ac, bấm Lọc sau khi chọn 1 ac nhé.";
			GStruct33 gstruct33_ = gStruct;
			method_1(gstruct33_);
			base.Text = "Loc do * Chua chon ac nao";
		}
		else
		{
			GStruct42 gStruct2 = FormMain.gstruct42_0[num3];
			if (gStruct2.gstruct33_0 != null)
			{
				for (int i = 0; i < gStruct2.gstruct33_0.Length; i++)
				{
					method_1(gStruct2.gstruct33_0[i]);
				}
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_2)
		{
			if (long_0 > 0L && Class11.smethod_23(long_0) > 300L)
			{
				buttonApdungAll.Enabled = true;
				long_0 = 0L;
			}
		}
		else
		{
			Close();
		}
	}

	private void method_0(GStruct50 gstruct50_1)
	{
		if (gstruct50_1.string_0 == null || gstruct50_1.string_0 == string.Empty)
		{
			return;
		}
		int num = 0;
		try
		{
			if (listView2.Items != null)
			{
				num = listView2.Items.Count;
			}
		}
		catch
		{
		}
		string[] array = new string[3]
		{
			num.ToString(),
			Class10.smethod_1(gstruct50_1.string_0, 1),
			gstruct50_1.int_0.ToString()
		};
		ListViewItem listViewItem = new ListViewItem(array[0]);
		if (array.Length > 1)
		{
			for (int i = 1; i < array.Length; i++)
			{
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
				listViewItem.SubItems.Add(item);
			}
		}
		listView2.Items.Add(listViewItem);
	}

	private void method_1(GStruct33 gstruct33_0)
	{
		int num = 0;
		try
		{
			if (listView1.Items != null)
			{
				num = listView1.Items.Count;
			}
		}
		catch
		{
		}
		string[] array = new string[4]
		{
			num.ToString(),
			gstruct33_0.string_0,
			gstruct33_0.int_2.ToString(),
			gstruct33_0.int_3.ToString()
		};
		ListViewItem listViewItem = new ListViewItem(array[0]);
		if (array.Length > 1)
		{
			for (int i = 1; i < array.Length; i++)
			{
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
				listViewItem.SubItems.Add(item);
			}
		}
		listView1.Items.Add(listViewItem);
		num = listView1.Items.Count;
		if (gstruct33_0.int_0 > 0)
		{
			listView1.Items[num - 1].Checked = true;
			listView1.Items[num - 1].ForeColor = color_0;
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.Items == null || listView1.Items.Count == 0)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			if (num < listView1.Items.Count)
			{
				if (listView1.Items[num].Selected)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		textBoxName.Text = num + ". " + listView1.Items[num].SubItems[1].Text;
		textBoxMin.Text = listView1.Items[num].SubItems[2].Text;
		textBoxDong.Text = listView1.Items[num].SubItems[3].Text;
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			int num2 = Convert.ToByte(e.NewValue);
			FormMain.gstruct42_0[num].gstruct33_0[e.Index].int_0 = num2;
			if (num2 > 0)
			{
				listView1.Items[e.Index].ForeColor = color_0;
			}
			else
			{
				listView1.Items[e.Index].ForeColor = Color.Black;
			}
		}
	}

	private void buttonSua_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < listView1.Items.Count)
			{
				if (listView1.Items[num2].Selected)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		FormMain.gstruct42_0[num].gstruct33_0[num2].int_2 = Class11.smethod_12(textBoxMin.Text);
		FormMain.gstruct42_0[num].gstruct33_0[num2].int_3 = Class11.smethod_12(textBoxDong.Text);
		Class47.smethod_11(FormMain.gstruct42_0[num]);
		listView1.Items[num2].SubItems[2].Text = Class11.smethod_12(textBoxMin.Text).ToString();
		listView1.Items[num2].SubItems[3].Text = Class11.smethod_12(textBoxDong.Text).ToString();
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (FormMain.gstruct42_0 == null || num < 0)
		{
			return;
		}
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			if (num != i)
			{
				if (FormMain.gstruct42_0[i].gstruct33_0 == null)
				{
					FormMain.gstruct42_0[i].gstruct33_0 = Class47.smethod_1();
				}
				for (int j = 0; j < FormMain.gstruct42_0[i].gstruct33_0.Length; j++)
				{
					FormMain.gstruct42_0[i].gstruct33_0[j].int_0 = FormMain.gstruct42_0[num].gstruct33_0[j].int_0;
					FormMain.gstruct42_0[i].gstruct33_0[j].int_2 = FormMain.gstruct42_0[num].gstruct33_0[j].int_2;
					FormMain.gstruct42_0[i].gstruct33_0[j].int_3 = FormMain.gstruct42_0[num].gstruct33_0[j].int_3;
					Class47.smethod_11(FormMain.gstruct42_0[i]);
				}
			}
		}
		textBoxName.Text = "Đã áp dụng cho tất cả ac đang online.";
		long_0 = Class11.smethod_22();
	}

	private void checkBoxBanVpHoagkimTest_CheckedChanged(object sender, EventArgs e)
	{
		bool_1 = checkBoxBanVpHoagkimTest.Checked;
	}

	private void checkBoxThoahet_CheckedChanged(object sender, EventArgs e)
	{
		bool_0 = checkBoxThoahet.Checked;
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_6[0] = Convert.ToByte(checkBox1.Checked);
			Class55.smethod_10(Class47.string_0, "TrangbiDong1_0", int_6[0], "", 0);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_6[1] = Class11.smethod_12(textBox1.Text);
			Class55.smethod_10(Class47.string_0, "TrangbiDong1_1", int_6[1], "", 0);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_7[0] = Convert.ToByte(checkBox2.Checked);
			Class55.smethod_10(Class47.string_0, "TrangbiDong2_0", int_7[0], "", 0);
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_7[1] = Class11.smethod_12(textBox2.Text);
			Class55.smethod_10(Class47.string_0, "TrangbiDong2_1", int_7[1], "", 0);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_8[0] = Convert.ToByte(checkBox3.Checked);
			Class55.smethod_10(Class47.string_0, "TrangbiDong3_0", int_8[0], "", 0);
		}
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_8[1] = Class11.smethod_12(textBox3.Text);
			Class55.smethod_10(Class47.string_0, "TrangbiDong3_1", int_8[1], "", 0);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_9[0] = Convert.ToByte(checkBox4.Checked);
			Class55.smethod_10(Class47.string_0, "TrangbiDong4_0", int_9[0], "", 0);
		}
	}

	private void textBox4_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_9[1] = Class11.smethod_12(textBox4.Text);
			Class55.smethod_10(Class47.string_0, "TrangbiDong4_1", int_9[1], "", 0);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_10[0] = Convert.ToByte(checkBox5.Checked);
			Class55.smethod_10(Class47.string_0, "TrangbiDong5_0", int_10[0], "", 0);
		}
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_10[1] = Class11.smethod_12(textBox5.Text);
			Class55.smethod_10(Class47.string_0, "TrangbiDong5_1", int_10[1], "", 0);
		}
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_11[0] = Convert.ToByte(checkBox6.Checked);
			Class55.smethod_10(Class47.string_0, "TrangbiDong6_0", int_11[0], "", 0);
		}
	}

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_11[1] = Class11.smethod_12(textBox6.Text);
			Class55.smethod_10(Class47.string_0, "TrangbiDong6_1", int_11[1], "", 0);
		}
	}

	private void checkBoxCoNopVP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_5 = Convert.ToByte(checkBoxCoNopVP.Checked);
			Class55.smethod_10(Class47.string_0, "fLocNopVP", int_5, "", 0);
		}
	}

	private void comboBoxNopVP_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || FormMain.gstruct42_0 == null)
		{
			return;
		}
		string_1 = null;
		if (gstruct50_0 != null)
		{
			string_1 = new string[gstruct50_0.Length];
			for (int i = 0; i < gstruct50_0.Length; i++)
			{
				string_1[i] = gstruct50_0[i].string_0;
			}
		}
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			Class69.smethod_30(FormMain.gstruct42_0[i], ref string_1);
		}
		if (string_1 == null)
		{
			return;
		}
		string text = comboBoxNopVP.Text;
		string text2 = null;
		Array.Sort(string_1);
		bool_3 = true;
		comboBoxNopVP.Items.Clear();
		for (int i = 0; i < string_1.Length; i++)
		{
			string text3 = Class10.smethod_1(string_1[i], 1);
			if (text3 == text)
			{
				text2 = text;
			}
			comboBoxNopVP.Items.Add(text3);
		}
		if (text2 == null)
		{
			text2 = comboBoxNopVP.Items[0].ToString();
		}
		comboBoxNopVP.Text = text2;
		bool_3 = false;
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || bool_3 || FormMain.gstruct42_0 == null || string_1 == null)
		{
			return;
		}
		int num = Class11.smethod_12(textBoxSoluongNop.Text);
		string text = comboBoxNopVP.Text;
		string text2 = null;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (text != null && text != string.Empty && Class10.smethod_1(string_1[i], 1) == text)
			{
				text2 = string_1[i];
				break;
			}
		}
		if (text2 == null)
		{
			return;
		}
		GStruct50 gStruct = default(GStruct50);
		gStruct.string_0 = text2;
		gStruct.int_0 = num;
		GStruct50 gStruct2 = gStruct;
		if (gstruct50_0 != null)
		{
			for (int j = 0; j < gstruct50_0.Length; j++)
			{
				if (text2 == gstruct50_0[j].string_0)
				{
					return;
				}
			}
			method_0(gStruct2);
			Array.Resize(ref gstruct50_0, gstruct50_0.Length + 1);
			gstruct50_0[gstruct50_0.Length - 1] = gStruct2;
		}
		else
		{
			gstruct50_0 = new GStruct50[1]
			{
				gStruct2
			};
			listView2.Items.Clear();
			method_0(gStruct2);
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		string text = null;
		for (int i = 0; i < listView2.Items.Count; i++)
		{
			if (listView2.Items[i].Selected)
			{
				text = listView2.Items[i].SubItems[1].Text;
				listView2.Items.RemoveAt(i);
				break;
			}
		}
		if (text == null || text == string.Empty || gstruct50_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		GStruct50[] array = new GStruct50[gstruct50_0.Length];
		for (int i = 0; i < gstruct50_0.Length; i++)
		{
			string a = Class10.smethod_1(gstruct50_0[i].string_0, 1);
			if (num2 == 0 && a == text)
			{
				num2 = 1;
				continue;
			}
			array[num].string_0 = gstruct50_0[i].string_0;
			array[num].int_0 = gstruct50_0[i].int_0;
			num++;
		}
		if (num2 == 0)
		{
			return;
		}
		if (num == 0)
		{
			gstruct50_0 = null;
			listView2.Items.Clear();
			return;
		}
		gstruct50_0 = new GStruct50[num];
		for (int i = 0; i < num; i++)
		{
			gstruct50_0[i].string_0 = array[i].string_0;
			gstruct50_0[i].int_0 = array[i].int_0;
		}
	}

	public static void smethod_2()
	{
		int int_ = int_1;
		int_1 = 0;
		while (true)
		{
			try
			{
				smethod_3(int_);
				return;
			}
			catch
			{
			}
		}
	}

	public static void smethod_3(int int_17)
	{
		GStruct42 gstruct42_ = default(GStruct42);
		int num = 0;
		int num2 = 0;
		int[] array = null;
		uint[] uint_ = null;
		bool flag = false;
		gstruct50_0 = smethod_0();
		while (true)
		{
			num2--;
			Thread.Sleep(180);
			if (num2 <= 0)
			{
				num = Class71.smethod_3(FormMain.gstruct42_0, int_17);
				if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || !FormMain.gstruct42_0[num].bool_5 || string_0 == null || string_0 == string.Empty)
				{
					break;
				}
				gstruct42_ = FormMain.gstruct42_0[num];
				if (!flag)
				{
					flag = true;
					Class60.smethod_50(gstruct42_, Class10.smethod_2("<color=yellow>Bắt đầu mở lọc trang bị vật phẩm Test..."));
				}
				if (int_4 > 0)
				{
					array = new int[1]
					{
						Class86.smethod_13(gstruct42_, string_0, ref uint_, 3)
					};
				}
				else
				{
					array = Class69.smethod_26(gstruct42_, new string[1]
					{
						string_0
					});
					if (array == null)
					{
						Class60.smethod_50(gstruct42_, Class10.smethod_2("<color=yellow>Không tìm thấy vật phẩm XXX trong hành trang. Kết thúc !").Replace("XXX", string_0));
						break;
					}
				}
				num2 = 3;
			}
			gstruct42_ = FormMain.gstruct42_0[num];
			uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
			uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gstruct42_.int_130);
			uint num5 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
			uint num6 = num5 + num4 * Class47.gstruct43_15.uint_0;
			Class20.smethod_30(num6 + Class47.gstruct43_43.uint_0, gstruct42_.int_130);
			int num7 = 0;
			if (int_4 <= 0)
			{
				Class76.smethod_9(gstruct42_);
				Class60.smethod_41(gstruct42_, (uint)array[0], array[2], array[3]);
			}
			else
			{
				if (gstruct42_.int_26 > 0)
				{
					int i = 0;
					int int_18 = 0;
					byte[] array2 = Class11.smethod_41("§ang Train kh«ng thÓ läc ®å " + string_0);
					for (; i < 10; i++)
					{
						Class20.WriteProcessMemory(gstruct42_.int_130, num6 + Class47.gstruct43_253.uint_0, array2, array2.Length, ref int_18);
						Thread.Sleep(100);
					}
					continue;
				}
				if (array[0] <= 0 || uint_ == null)
				{
					int i = 0;
					int int_18 = 0;
					byte[] array2 = Class11.smethod_41("Khong tim thay NPC " + string_0);
					for (; i < 10; i++)
					{
						Class20.WriteProcessMemory(gstruct42_.int_130, num6 + Class47.gstruct43_253.uint_0, array2, array2.Length, ref int_18);
						Thread.Sleep(100);
					}
					continue;
				}
				uint[] uint_2 = new uint[2]
				{
					Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
					Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
				};
				if (Class53.smethod_18(uint_2, uint_) > 22500L)
				{
					Class60.smethod_61(gstruct42_, uint_);
					continue;
				}
				Class76.smethod_9(gstruct42_);
				Class32.smethod_9(gstruct42_, (uint)array[0]);
			}
			while (true)
			{
				Thread.Sleep(300);
				int j;
				for (j = 0; j < 10; j++)
				{
					if (!Class76.smethod_0(gstruct42_))
					{
						if (num7 > 0 && j > 0)
						{
							break;
						}
						Thread.Sleep(100);
						continue;
					}
					j = -1;
					break;
				}
				int num8 = Class76.smethod_1(gstruct42_);
				int num9 = Class76.smethod_2(gstruct42_, num8);
				if (j == -1 && num9 > 0)
				{
					if (int_12 == null)
					{
						Class76.smethod_6(gstruct42_, num9 - 1);
						Thread.Sleep(300);
					}
					else
					{
						for (int k = 0; k < int_12.Length; k++)
						{
							if (int_12[k] > 0)
							{
								Class76.smethod_6(gstruct42_, int_12[k] - 1);
								Thread.Sleep(500);
							}
						}
					}
					if (Class76.Class79.smethod_4(gstruct42_))
					{
						Class20.smethod_4(gstruct42_.uint_4, 32u);
					}
				}
				if (num7 > 0)
				{
					break;
				}
				num7 = 1;
			}
			if (int_3 > 0)
			{
				int num10 = int_2;
				if (num10 <= 0)
				{
					num10 = 1;
				}
				int num11 = 0;
				while (num11 < 150)
				{
					if (Class20.smethod_30(gstruct42_.uint_6 + Class47.gstruct43_168.uint_0, gstruct42_.int_130) == 0)
					{
						num11++;
						Thread.Sleep(10);
						continue;
					}
					Class39.smethod_5(gstruct42_, num10.ToString(), bool_0: true);
					Thread.Sleep(300);
					break;
				}
			}
			if (int_5 > 0 && gstruct50_0 != null)
			{
				try
				{
					for (int k = 0; k < gstruct50_0.Length; k++)
					{
						smethod_4(gstruct42_, gstruct50_0[k].string_0, gstruct50_0[k].int_0);
					}
				}
				catch
				{
				}
				int num12 = Class69.smethod_2(gstruct42_);
				Thread.Sleep(300);
				Class39.smethod_14(gstruct42_, bool_0: true);
				int l;
				for (l = 0; l < 10; l++)
				{
					if (!Class39.smethod_9(gstruct42_))
					{
						break;
					}
					Thread.Sleep(100);
				}
				Thread.Sleep(100);
				l = 0;
				while (l < 6 && Class69.smethod_2(gstruct42_) == num12)
				{
					if (Class76.Class79.smethod_4(gstruct42_))
					{
						Class20.smethod_4(gstruct42_.uint_4, 32u);
					}
					else if (Class76.smethod_0(gstruct42_))
					{
						Class76.smethod_6(gstruct42_, 0);
					}
					l++;
					Thread.Sleep(100);
				}
			}
			smethod_5(gstruct42_);
		}
		num = Class71.smethod_3(FormMain.gstruct42_0, int_17);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].bool_5 = false;
			Class60.smethod_50(gstruct42_, "<color=yellow>Ket thuc mo loc trang bi test!");
		}
	}

	private static void smethod_4(GStruct42 gstruct42_0, string string_2, int int_17)
	{
		if (string_2 == null || string_2 == string.Empty)
		{
			return;
		}
		int num = 0;
		while (!Class39.smethod_9(gstruct42_0))
		{
			Thread.Sleep(10);
			num++;
			if (num > 150)
			{
				return;
			}
		}
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		int int_18 = 0;
		byte[] array = new byte[string_2.Length + 3];
		byte[] array2 = new byte[1];
		byte[] array3 = new byte[4];
		int num4 = Class69.smethod_2(gstruct42_0);
		int num5 = 0;
		uint num6 = 12u;
		for (uint num7 = 1u; num7 < Class47.int_1 && (0 >= num4 || num4 > num5); num7++)
		{
			uint num8 = num2 + num7 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_103.uint_0 - 4, array3, 4, ref int_18);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			uint uint_ = num8 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array2, 1, ref int_18);
			if (array2[0] == 0)
			{
				continue;
			}
			uint num9 = Class69.smethod_0(gstruct42_0, num7);
			if (num9 == 0)
			{
				continue;
			}
			num5++;
			if (array2[0] != string_2[0])
			{
				continue;
			}
			uint num10 = Class20.smethod_30(num3 + num9 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if (num10 != 3 && num10 != 1)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_18);
			string a = Class10.smethod_3(array);
			if (a != string_2)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_116.uint_0, array3, 4, ref int_18);
			int num11 = BitConverter.ToInt32(array3, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_105.uint_0, array3, 4, ref int_18);
			int num12 = BitConverter.ToInt32(array3, 0);
			if (num12 == 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_116.uint_0 + 4, array3, 4, ref int_18);
				int num13 = BitConverter.ToInt32(array3, 0);
				if (num11 == 0 && num13 > 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_107.uint_0, array3, 4, ref int_18);
				int num14 = BitConverter.ToInt32(array3, 0);
				if (num14 <= 9)
				{
					int[] array4 = null;
					for (uint num15 = 0u; num15 < 6; num15++)
					{
						switch (num15)
						{
						case 0u:
							array4 = int_6;
							break;
						case 2u:
							array4 = int_8;
							break;
						case 3u:
							array4 = int_9;
							break;
						case 5u:
							array4 = int_11;
							break;
						case 4u:
							array4 = int_10;
							break;
						case 1u:
							array4 = int_7;
							break;
						}
						if (array4[0] <= 0)
						{
							continue;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_115.uint_0 + num15 * 16 + 4, array3, 4, ref int_18);
						int num16 = BitConverter.ToInt32(array3, 0);
						if (num16 >= array4[1])
						{
							continue;
						}
						goto IL_056b;
					}
					if (!bool_0)
					{
						continue;
					}
					int num17 = 0;
					int num18 = 0;
					bool flag = false;
					for (int i = 0; i < gstruct42_0.gstruct33_0.Length; i++)
					{
						if (gstruct42_0.gstruct33_0[i].int_0 <= 0)
						{
							continue;
						}
						num18++;
						flag = false;
						for (uint num15 = 0u; num15 < 6; num15++)
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_115.uint_0 + num15 * 16, array3, 4, ref int_18);
							int num19 = BitConverter.ToInt32(array3, 0);
							if (gstruct42_0.gstruct33_0[i].int_1 == num19)
							{
								Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_115.uint_0 + num15 * 16 + 4, array3, 4, ref int_18);
								int num20 = BitConverter.ToInt32(array3, 0);
								Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_115.uint_0 + num15 * 16 + 12, array3, 4, ref int_18);
								int num21 = BitConverter.ToInt32(array3, 0);
								bool flag2 = gstruct42_0.gstruct33_0[i].int_2 <= num20 && num20 > 0;
								bool flag3 = gstruct42_0.gstruct33_0[i].int_2 <= num21 && num21 > 0;
								bool flag4 = gstruct42_0.gstruct33_0[i].int_2 <= 0;
								if ((gstruct42_0.gstruct33_0[i].int_3 == 0 || gstruct42_0.gstruct33_0[i].int_3 == num15 + 1) && (flag2 || flag3 || flag4))
								{
									num17++;
									flag = true;
									break;
								}
							}
						}
						if (flag || !bool_0)
						{
							continue;
						}
						goto IL_056b;
					}
					if (num18 == 0 || (bool_0 && num18 <= num17) || (!bool_0 && num17 > 0))
					{
						continue;
					}
				}
			}
			goto IL_056b;
			IL_056b:
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_108.uint_0, array3, 4, ref int_18);
			uint uint_2 = BitConverter.ToUInt32(array3, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_109.uint_0, array3, 4, ref int_18);
			uint uint_3 = BitConverter.ToUInt32(array3, 0);
			uint[] array5 = Class69.smethod_22(gstruct42_0, num6, uint_2, uint_3);
			if (array5 == null)
			{
				break;
			}
			uint num22 = num3 + num9 * 20;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_97.uint_0 - 4, array3, 4, ref int_18);
			uint num23 = BitConverter.ToUInt32(array3, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_97.uint_0, array3, 4, ref int_18);
			uint num24 = BitConverter.ToUInt32(array3, 0);
			int num25 = 0;
			if (num11 > 0 && num12 > 1 && int_17 > 0 && num11 > int_17)
			{
				while (!Class11.bool_0 && Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) == 0)
				{
					if (num25 % 80 == 0)
					{
						Class60.smethod_71(gstruct42_0, num7, (uint)int_17, 89);
					}
					Thread.Sleep(100);
					num25++;
					if (num25 > 200)
					{
						break;
					}
				}
				num11 = int_17;
			}
			else
			{
				while ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) <= 0)
				{
					if (num25 % 80 == 0)
					{
						Class60.smethod_44(gstruct42_0, num23, num24, num10, num23, num24, num10);
					}
					Thread.Sleep(10);
					num25++;
					if (num25 > 200)
					{
						break;
					}
				}
				if (num11 <= 0)
				{
					num11 = 1;
				}
			}
			if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) != 0)
			{
				for (num25 = 0; num25 < 200; num25++)
				{
					if (num25 % 80 == 0)
					{
						Class60.smethod_44(gstruct42_0, array5[0], array5[1], num6, array5[0], array5[1], num6);
					}
					if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) != 0)
					{
						Thread.Sleep(100);
						continue;
					}
					int_17 -= num11;
					break;
				}
			}
			if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) != 0)
			{
				num25 = 0;
				if (num10 == 1)
				{
					array5 = Class69.smethod_22(gstruct42_0, 3u, uint_2, uint_3);
					if (array5 != null)
					{
						num10 = 3u;
						num23 = array5[0];
						num24 = array5[1];
					}
				}
				for (; num25 < 200; num25++)
				{
					if (num25 % 80 == 0)
					{
						Class60.smethod_44(gstruct42_0, num23, num24, num10, num23, num24, num10);
					}
					if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) == 0)
					{
						break;
					}
					Thread.Sleep(100);
				}
			}
			if (int_17 <= 0)
			{
				break;
			}
		}
	}

	public static uint[] smethod_5(GStruct42 gstruct42_0)
	{
		int int_ = 0;
		byte[] array = new byte[80];
		byte[] array2 = new byte[4];
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num5 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num6 = num5 + num4 * Class47.gstruct43_15.uint_0;
		byte[] array3 = new byte[4];
		int int_2 = 0;
		int num7 = Class69.smethod_2(gstruct42_0);
		int num8 = 0;
		uint[] array4 = null;
		for (uint num9 = 1u; num9 < Class47.int_1; num9++)
		{
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_43.uint_0, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) <= 0)
			{
				if (0 < num7 && num7 <= num8)
				{
					break;
				}
				uint num10 = num2 + num9 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_103.uint_0 - 4, array3, 4, ref int_2);
				if (BitConverter.ToInt32(array3, 0) != 0)
				{
					continue;
				}
				uint uint_ = num10 + Class47.gstruct43_104.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array3, 1, ref int_2);
				if (array3[0] == 0)
				{
					continue;
				}
				uint num11 = Class69.smethod_0(gstruct42_0, num9);
				if (num11 == 0)
				{
					continue;
				}
				num8++;
				uint num12 = Class20.smethod_30(num + num11 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
				if (num12 != 3)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_105.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
				if (array4 == null)
				{
					array4 = new uint[1];
				}
				else
				{
					Array.Resize(ref array4, array4.Length + 1);
				}
				array4[array4.Length - 1] = num9;
				if (!bool_1)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_106.uint_0, array2, 4, ref int_);
					int num13 = BitConverter.ToInt32(array2, 0);
					if (num13 == 1 || num13 == 4)
					{
						continue;
					}
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_117.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_116.uint_0, array2, 4, ref int_);
				int num14 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_116.uint_0 + 4, array2, 4, ref int_);
				int num15 = BitConverter.ToInt32(array2, 0);
				if (num14 == 0 && num15 > 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_107.uint_0, array2, 4, ref int_);
				int num16 = BitConverter.ToInt32(array2, 0);
				if (num16 > 9)
				{
					continue;
				}
				int[] array5 = null;
				uint num17 = 0u;
				while (true)
				{
					if (num17 < 6)
					{
						switch (num17)
						{
						case 0u:
							array5 = int_6;
							break;
						case 2u:
							array5 = int_8;
							break;
						case 5u:
							array5 = int_11;
							break;
						case 4u:
							array5 = int_10;
							break;
						case 3u:
							array5 = int_9;
							break;
						case 1u:
							array5 = int_7;
							break;
						}
						if (array5[0] <= 0)
						{
							goto IL_03f1;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_115.uint_0 + num17 * 16 + 4, array2, 4, ref int_);
						int num18 = BitConverter.ToInt32(array2, 0);
						if (num18 >= array5[1])
						{
							goto IL_03f1;
						}
					}
					else
					{
						if (!bool_0)
						{
							break;
						}
						int num19 = 0;
						int num20 = 0;
						bool flag = false;
						for (int i = 0; i < gstruct42_0.gstruct33_0.Length; i++)
						{
							if (gstruct42_0.gstruct33_0[i].int_0 <= 0)
							{
								continue;
							}
							num20++;
							flag = false;
							for (num17 = 0u; num17 < 6; num17++)
							{
								Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_115.uint_0 + num17 * 16, array2, 4, ref int_);
								int num21 = BitConverter.ToInt32(array2, 0);
								if (gstruct42_0.gstruct33_0[i].int_1 == num21)
								{
									Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_115.uint_0 + num17 * 16 + 4, array2, 4, ref int_);
									int num22 = BitConverter.ToInt32(array2, 0);
									Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_115.uint_0 + num17 * 16 + 12, array2, 4, ref int_);
									int num23 = BitConverter.ToInt32(array2, 0);
									bool flag2 = gstruct42_0.gstruct33_0[i].int_2 <= num22 && num22 > 0;
									bool flag3 = gstruct42_0.gstruct33_0[i].int_2 <= num23 && num23 > 0;
									bool flag4 = gstruct42_0.gstruct33_0[i].int_2 <= 0;
									if ((gstruct42_0.gstruct33_0[i].int_3 == 0 || gstruct42_0.gstruct33_0[i].int_3 == num17 + 1) && (flag2 || flag3 || flag4))
									{
										num19++;
										flag = true;
										break;
									}
								}
							}
							if (flag || !bool_0)
							{
								continue;
							}
							goto IL_05fd;
						}
						if (flag = (num20 == 0 || (bool_0 && num20 <= num19) || (!bool_0 && num19 > 0)))
						{
							break;
						}
					}
					goto IL_05fd;
					IL_05fd:
					int num24 = 0;
					while (!Class11.bool_0 && num24 < 100)
					{
						if (num24 % 30 == 0)
						{
							Class60.smethod_33(gstruct42_0, (int)num9);
						}
						Thread.Sleep(10);
						if (num24 % 15 == 0)
						{
							string string_ = Class73.smethod_22(gstruct42_0);
							if (Class11.smethod_2(string_, "hÊt b¹i") > 0)
							{
								Class73.smethod_23(gstruct42_0, "0K..");
								break;
							}
						}
						if (Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_) && array[0] != 0)
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_43.uint_0, array2, 4, ref int_);
							if (BitConverter.ToInt32(array2, 0) <= 0)
							{
								num24++;
								continue;
							}
							num24 = 0;
							break;
						}
						num24 = 0;
						break;
					}
					break;
					IL_03f1:
					num17++;
				}
				continue;
			}
			return array4;
		}
		return array4;
	}

	private void linkLabelLuuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = "Nếu trùng luyện các vật phẩm Hoàng Kim thì không được check vào mục []Bán luôn trang bị Hoàng Kim.||Đối với các vật phẩm đem nộp là trang bị (như Vũ khí, áo, mão ... ) nếu thỏa điều kiện của thuộc tính bên dưới thì nó sẽ giữ lại không nộp. Do vậy, sẽ có thể xảy ra trường hợp có vật phẩm nhưng auto không nộp.||Ví dụ trùng luyện vật phẩm Vũ khí Kim Ô, cần: 1 Vũ khí Kim Ô, 4 Kim Ô trùng luyện ngọc.||Nhưng có thể xảy ra trường hợp auto chỉ nộp 4 Kim Ô trùng luyện ngọc, mà không nộp vũ khí Kim Ô.||Nguyên nhân: Có thể bạn check vào dòng giữ lại [v] Tốc độ đánh = 40, mà vũ khí Kim Ô thì có tốc độ đánh 126, đã thỏa điều kiện nên nó không nộp.||Giải quyết: Check luôn dòng [v] Lọc đúng hết điều kiện thuộc tính dưới đây thì mới giữ.||Lúc này nếu auto giữ lại không nộp vũ khí, thì vũ khí đó đã đạt yêu cầu, bạn có thể tắt auto và đem vũ khí cất đi cho an toàn.";
		FormTip.smethod_0("LOC TRANG BỊ", string_, 60000000, 420, 340);
	}
}
