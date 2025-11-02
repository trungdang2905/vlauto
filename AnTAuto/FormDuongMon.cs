using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormDuongMon : Form
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static int int_4 = 0;

	public static int int_5 = Class55.smethod_3("SolanNhoiBoom", 0, "3");

	public static int int_6 = Class55.smethod_3("flagDatXungquanhAcChinh", 0, "1");

	public static int int_7 = Class55.smethod_3("KhoangCachDatBoom", 0, "200");

	private bool bool_1 = false;

	private IContainer icontainer_0 = null;

	private CheckBox checkBoxPhim1;

	private CheckBox checkBoxPhim2;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private CheckBox checkBoxPhim3;

	private CheckBox checkBoxDatXungQuanh;

	private TextBox textBoxKhoangCach;

	private ComboBox comboBoxBoom2;

	private ComboBox comboBoxBoom1;

	private ComboBox comboBoxBoom3;

	private RichTextBox richTextBox1;

	private ComboBox comboBoxTenAc;

	private Label label1;

	private GroupBox groupBox1;

	private ComboBox comboBoxSolanNhoiboom;

	private Label label2;

	public static void smethod_0(GStruct42 gstruct42_0, ref int int_8, uint[] uint_0, ref int int_9, bool bool_2)
	{
		int num = 0;
		int num2 = 0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num5 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num6 = num5 + num4 * Class47.gstruct43_15.uint_0;
		int num7 = (int)Class20.smethod_30(num6 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130);
		if (num7 > 0)
		{
			Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
			Thread.Sleep(150);
		}
		if (bool_2 && int_6 > 0)
		{
			int[] array = new int[18]
			{
				10,
				90,
				170,
				250,
				330,
				70,
				150,
				230,
				310,
				350,
				50,
				130,
				210,
				290,
				30,
				110,
				190,
				270
			};
			if (int_9 < 0 || array.Length <= int_9)
			{
				int_9 = 0;
			}
			int num8 = int_7;
			if (num8 > 50)
			{
				Random random = new Random();
				num8 = random.Next(50, num8);
			}
			double num9 = (double)Math.Abs(array[int_9]) * 3.14 / 180.0;
			uint[] array2 = new uint[2]
			{
				(uint)((double)uint_0[0] + (double)num8 * Math.Cos(num9)),
				(uint)((double)uint_0[1] - (double)num8 * Math.Sin(num9))
			};
			num = 0;
			num2 = 0;
			for (; num < 40; num++)
			{
				int num10 = (int)Class20.smethod_30(num6 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
				num2 = ((num10 <= 1) ? (num2 + 1) : 0);
				if (num2 > 10)
				{
					break;
				}
				Thread.Sleep(10);
			}
			if (num > 39)
			{
				Class60.smethod_55(gstruct42_0, "Switch([[sit]])");
				Thread.Sleep(150);
			}
			int int_10 = 0;
			Class20.WriteProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_72.uint_0, new byte[4], 4, ref int_10);
			for (num = 0; num < 8; num++)
			{
				uint[] uint_ = new uint[2]
				{
					Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				long num11 = Class53.smethod_18(uint_, array2);
				if (num11 < 7800L)
				{
					break;
				}
				Class60.smethod_61(gstruct42_0, array2);
				Thread.Sleep(200);
			}
			int_9++;
		}
		int[,] array3 = new int[3, 2]
		{
			{
				gstruct42_0.int_122[1],
				gstruct42_0.int_122[2]
			},
			{
				gstruct42_0.int_122[3],
				gstruct42_0.int_122[4]
			},
			{
				gstruct42_0.int_122[5],
				gstruct42_0.int_122[6]
			}
		};
		int num12 = 0;
		do
		{
			int length = array3.GetLength(0);
			if (int_8 < 0 || length <= int_8)
			{
				int_8 = 0;
			}
			int num13 = int_8;
			while (array3[int_8, 0] <= 0 || array3[int_8, 1] <= 0)
			{
				int_8++;
				if (length <= int_8)
				{
					int_8 = 0;
				}
				if (num13 == int_8)
				{
					return;
				}
			}
			if (gstruct42_0.int_129 != Class38.gstruct29_0.int_0 || FormMain.int_6 > 0 || FormMain.int_7 > 0)
			{
				Class67.smethod_7(gstruct42_0);
			}
			Class67.smethod_3(gstruct42_0, array3[int_8, 1], 6, 1);
			int i = 0;
			int num14 = 0;
			for (; i < 15; i++)
			{
				int num10 = (int)Class20.smethod_30(num6 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
				num14 = ((num10 < 3) ? (num14 + 1) : 0);
				if (num14 > 6)
				{
					break;
				}
				Thread.Sleep(10);
			}
			i = 0;
			num14 = 0;
			for (; i < 60; i++)
			{
				if (i % 15 == 0)
				{
					Class20.smethod_75(gstruct42_0.uint_4, 117);
				}
				int num10 = (int)Class20.smethod_30(num6 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
				num14 = ((num10 < 4) ? (num14 + 1) : 0);
				if (num14 > 6)
				{
					break;
				}
				Thread.Sleep(10);
			}
			int_8++;
			num12++;
		}
		while (num12 < int_5);
	}

	public FormDuongMon()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int_0 = 0;
		int_1 = 0;
		int_4 = 0;
		bool_0 = false;
	}

	private void FormDuongMon_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		bool_1 = false;
		if (int_0 > 0 && int_1 > 0)
		{
			int num = int_0 - base.Width - 10;
			int num2 = int_1 - base.Height - 10;
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
		GStruct42 gStruct = default(GStruct42);
		gStruct.int_129 = 0;
		GStruct42 gstruct42_ = gStruct;
		int num3 = -1;
		int num4 = -1;
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				string a = Class67.smethod_18(FormMain.gstruct42_0[i]);
				if (a == "DUONGMON")
				{
					comboBoxTenAc.Items.Add(Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1));
					if (num3 <= 0)
					{
						num3 = FormMain.gstruct42_0[i].int_129;
						gstruct42_ = FormMain.gstruct42_0[i];
					}
				}
			}
		}
		if (int_4 > 0)
		{
			int num5 = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (0 <= num5)
			{
				string a = Class67.smethod_18(FormMain.gstruct42_0[num5]);
				if (a == "DUONGMON")
				{
					num4 = FormMain.gstruct42_0[num5].int_129;
					gstruct42_ = FormMain.gstruct42_0[num5];
				}
			}
		}
		if (num4 <= 0 && num3 > 0)
		{
			num4 = num3;
		}
		int_4 = 0;
		groupBox1.Enabled = (num4 > 0);
		if (num4 > 0)
		{
			int_4 = num4;
			comboBoxTenAc.Text = Class10.smethod_1(gstruct42_.string_20, 1);
			GStruct36[] gstruct36_ = Class67.smethod_16(gstruct42_);
			method_1(comboBoxBoom1, gstruct36_);
			method_1(comboBoxBoom2, gstruct36_);
			method_1(comboBoxBoom3, gstruct36_);
			checkBoxPhim1.Checked = (gstruct42_.int_122[1] > 0);
			checkBoxPhim2.Checked = (gstruct42_.int_122[3] > 0);
			checkBoxPhim3.Checked = (gstruct42_.int_122[5] > 0);
			comboBoxBoom1.Text = method_2(gstruct36_, gstruct42_.int_122[2]);
			comboBoxBoom2.Text = method_2(gstruct36_, gstruct42_.int_122[4]);
			comboBoxBoom3.Text = method_2(gstruct36_, gstruct42_.int_122[6]);
		}
		for (int i = 1; i < 5; i++)
		{
			comboBoxSolanNhoiboom.Items.Add(i);
		}
		checkBoxDatXungQuanh.Checked = (int_6 > 0);
		textBoxKhoangCach.Text = int_7.ToString();
		comboBoxSolanNhoiboom.Text = int_5.ToString();
		Thread.Sleep(100);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void checkBoxPhim1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_122[1] = Convert.ToByte(checkBoxPhim1.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxPhim2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_122[3] = Convert.ToByte(checkBoxPhim2.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxPhim3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_122[5] = Convert.ToByte(checkBoxPhim3.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxDatXungQuanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_6 = Convert.ToByte(checkBoxDatXungQuanh.Checked);
			Class55.smethod_10(Class47.string_0, "flagDatXungquanhAcChinh", int_6, "", 0);
		}
	}

	private void textBoxKhoangCach_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_7 = Class11.smethod_12(textBoxKhoangCach.Text);
			if (int_7 < 0)
			{
				int_7 = 0;
			}
			Class55.smethod_10(Class47.string_0, "KhoangCachDatBoom", int_7, "", 0);
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		string text = "https://youtu.be/NPL9IJdsf3g";
		Class11.smethod_24(ref Class11.string_14, "Xem video hướng dẫn tại: " + text);
		Class20.smethod_40(Class55.smethod_0(), "", text, 0);
	}

	private bool method_1(ComboBox comboBox_0, GStruct36[] gstruct36_0)
	{
		comboBox_0.Items.Clear();
		if (gstruct36_0 == null)
		{
			return false;
		}
		for (int i = 0; i < gstruct36_0.Length; i++)
		{
			comboBox_0.Items.Add(gstruct36_0[i].string_0);
		}
		return true;
	}

	private string method_2(GStruct36[] gstruct36_0, int int_8)
	{
		if (int_8 > 0 && gstruct36_0 != null)
		{
			for (int i = 0; i < gstruct36_0.Length; i++)
			{
				if (gstruct36_0[i].int_1 == int_8)
				{
					return gstruct36_0[i].string_0;
				}
			}
		}
		return string.Empty;
	}

	private void comboBoxTenAc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int_4 = -1;
		string text = comboBoxTenAc.Text;
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				if (text == Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1))
				{
					int_4 = FormMain.gstruct42_0[i].int_129;
					break;
				}
			}
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num >= 0)
		{
			GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
			bool_1 = false;
			GStruct36[] gstruct36_ = Class67.smethod_16(gstruct42_);
			method_1(comboBoxBoom1, gstruct36_);
			method_1(comboBoxBoom2, gstruct36_);
			method_1(comboBoxBoom3, gstruct36_);
			checkBoxPhim1.Checked = (gstruct42_.int_122[1] > 0);
			checkBoxPhim2.Checked = (gstruct42_.int_122[3] > 0);
			checkBoxPhim3.Checked = (gstruct42_.int_122[5] > 0);
			comboBoxBoom1.Text = method_2(gstruct36_, gstruct42_.int_122[2]);
			comboBoxBoom2.Text = method_2(gstruct36_, gstruct42_.int_122[4]);
			comboBoxBoom3.Text = method_2(gstruct36_, gstruct42_.int_122[5]);
			Thread.Sleep(60);
			bool_1 = true;
		}
	}

	private void comboBoxBoom1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
		GStruct36[] array = Class67.smethod_16(gstruct42_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxBoom1.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].int_122[2] = num2;
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
	}

	private void comboBoxBoom2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
		GStruct36[] array = Class67.smethod_16(gstruct42_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxBoom2.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].int_122[4] = num2;
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
	}

	private void comboBoxBoom3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
		GStruct36[] array = Class67.smethod_16(gstruct42_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxBoom3.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].int_122[6] = num2;
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
	}

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormDuongMon));
		checkBoxPhim1 = new System.Windows.Forms.CheckBox();
		checkBoxPhim2 = new System.Windows.Forms.CheckBox();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonClose = new System.Windows.Forms.Button();
		checkBoxPhim3 = new System.Windows.Forms.CheckBox();
		checkBoxDatXungQuanh = new System.Windows.Forms.CheckBox();
		textBoxKhoangCach = new System.Windows.Forms.TextBox();
		comboBoxBoom2 = new System.Windows.Forms.ComboBox();
		comboBoxBoom1 = new System.Windows.Forms.ComboBox();
		comboBoxBoom3 = new System.Windows.Forms.ComboBox();
		richTextBox1 = new System.Windows.Forms.RichTextBox();
		comboBoxTenAc = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		groupBox1 = new System.Windows.Forms.GroupBox();
		comboBoxSolanNhoiboom = new System.Windows.Forms.ComboBox();
		label2 = new System.Windows.Forms.Label();
		groupBox1.SuspendLayout();
		SuspendLayout();
		checkBoxPhim1.AutoSize = true;
		checkBoxPhim1.ForeColor = System.Drawing.Color.Black;
		checkBoxPhim1.Location = new System.Drawing.Point(14, 18);
		checkBoxPhim1.Name = "checkBoxPhim1";
		checkBoxPhim1.Size = new System.Drawing.Size(62, 17);
		checkBoxPhim1.TabIndex = 0;
		checkBoxPhim1.Text = "Boom 1";
		checkBoxPhim1.UseVisualStyleBackColor = true;
		checkBoxPhim1.CheckedChanged += new System.EventHandler(checkBoxPhim1_CheckedChanged);
		checkBoxPhim2.AutoSize = true;
		checkBoxPhim2.ForeColor = System.Drawing.Color.Black;
		checkBoxPhim2.Location = new System.Drawing.Point(14, 43);
		checkBoxPhim2.Name = "checkBoxPhim2";
		checkBoxPhim2.Size = new System.Drawing.Size(62, 17);
		checkBoxPhim2.TabIndex = 1;
		checkBoxPhim2.Text = "Boom 2";
		checkBoxPhim2.UseVisualStyleBackColor = true;
		checkBoxPhim2.CheckedChanged += new System.EventHandler(checkBoxPhim2_CheckedChanged);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonClose.Location = new System.Drawing.Point(94, 293);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(100, 26);
		buttonClose.TabIndex = 8;
		buttonClose.Text = "OK";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		checkBoxPhim3.AutoSize = true;
		checkBoxPhim3.ForeColor = System.Drawing.Color.Black;
		checkBoxPhim3.Location = new System.Drawing.Point(14, 70);
		checkBoxPhim3.Name = "checkBoxPhim3";
		checkBoxPhim3.Size = new System.Drawing.Size(62, 17);
		checkBoxPhim3.TabIndex = 332;
		checkBoxPhim3.Text = "Boom 3";
		checkBoxPhim3.UseVisualStyleBackColor = true;
		checkBoxPhim3.CheckedChanged += new System.EventHandler(checkBoxPhim3_CheckedChanged);
		checkBoxDatXungQuanh.AutoSize = true;
		checkBoxDatXungQuanh.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxDatXungQuanh.Location = new System.Drawing.Point(17, 263);
		checkBoxDatXungQuanh.Name = "checkBoxDatXungQuanh";
		checkBoxDatXungQuanh.Size = new System.Drawing.Size(177, 17);
		checkBoxDatXungQuanh.TabIndex = 334;
		checkBoxDatXungQuanh.Text = "Đặt boom xung quanh ac chính";
		checkBoxDatXungQuanh.UseVisualStyleBackColor = true;
		checkBoxDatXungQuanh.CheckedChanged += new System.EventHandler(checkBoxDatXungQuanh_CheckedChanged);
		textBoxKhoangCach.Location = new System.Drawing.Point(207, 261);
		textBoxKhoangCach.Name = "textBoxKhoangCach";
		textBoxKhoangCach.Size = new System.Drawing.Size(50, 20);
		textBoxKhoangCach.TabIndex = 335;
		textBoxKhoangCach.TextChanged += new System.EventHandler(textBoxKhoangCach_TextChanged);
		comboBoxBoom2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxBoom2.ForeColor = System.Drawing.Color.Black;
		comboBoxBoom2.FormattingEnabled = true;
		comboBoxBoom2.Location = new System.Drawing.Point(95, 42);
		comboBoxBoom2.Name = "comboBoxBoom2";
		comboBoxBoom2.Size = new System.Drawing.Size(140, 21);
		comboBoxBoom2.TabIndex = 353;
		comboBoxBoom2.SelectedIndexChanged += new System.EventHandler(comboBoxBoom2_SelectedIndexChanged);
		comboBoxBoom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxBoom1.ForeColor = System.Drawing.Color.Black;
		comboBoxBoom1.FormattingEnabled = true;
		comboBoxBoom1.Location = new System.Drawing.Point(95, 18);
		comboBoxBoom1.Name = "comboBoxBoom1";
		comboBoxBoom1.Size = new System.Drawing.Size(140, 21);
		comboBoxBoom1.TabIndex = 352;
		comboBoxBoom1.SelectedIndexChanged += new System.EventHandler(comboBoxBoom1_SelectedIndexChanged);
		comboBoxBoom3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxBoom3.ForeColor = System.Drawing.Color.Black;
		comboBoxBoom3.FormattingEnabled = true;
		comboBoxBoom3.Location = new System.Drawing.Point(95, 66);
		comboBoxBoom3.Name = "comboBoxBoom3";
		comboBoxBoom3.Size = new System.Drawing.Size(140, 21);
		comboBoxBoom3.TabIndex = 354;
		comboBoxBoom3.SelectedIndexChanged += new System.EventHandler(comboBoxBoom3_SelectedIndexChanged);
		richTextBox1.Location = new System.Drawing.Point(3, 3);
		richTextBox1.Name = "richTextBox1";
		richTextBox1.Size = new System.Drawing.Size(254, 91);
		richTextBox1.TabIndex = 355;
		//richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
		comboBoxTenAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxTenAc.ForeColor = System.Drawing.Color.Black;
		comboBoxTenAc.FormattingEnabled = true;
		comboBoxTenAc.Location = new System.Drawing.Point(98, 100);
		comboBoxTenAc.Name = "comboBoxTenAc";
		comboBoxTenAc.Size = new System.Drawing.Size(159, 21);
		comboBoxTenAc.TabIndex = 356;
		comboBoxTenAc.SelectedIndexChanged += new System.EventHandler(comboBoxTenAc_SelectedIndexChanged);
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(1, 104);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(91, 13);
		label1.TabIndex = 357;
		label1.Text = "Chọn Đường Môn";
		groupBox1.Controls.Add(comboBoxBoom3);
		groupBox1.Controls.Add(comboBoxBoom2);
		groupBox1.Controls.Add(comboBoxBoom1);
		groupBox1.Controls.Add(checkBoxPhim3);
		groupBox1.Controls.Add(checkBoxPhim1);
		groupBox1.Controls.Add(checkBoxPhim2);
		groupBox1.Location = new System.Drawing.Point(3, 128);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(254, 100);
		groupBox1.TabIndex = 358;
		groupBox1.TabStop = false;
		comboBoxSolanNhoiboom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxSolanNhoiboom.ForeColor = System.Drawing.Color.Black;
		comboBoxSolanNhoiboom.FormattingEnabled = true;
		comboBoxSolanNhoiboom.Location = new System.Drawing.Point(207, 234);
		comboBoxSolanNhoiboom.Name = "comboBoxSolanNhoiboom";
		comboBoxSolanNhoiboom.Size = new System.Drawing.Size(50, 21);
		comboBoxSolanNhoiboom.TabIndex = 355;
		label2.AutoSize = true;
		label2.ForeColor = System.Drawing.Color.DarkRed;
		label2.Location = new System.Drawing.Point(52, 238);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(133, 13);
		label2.TabIndex = 359;
		label2.Text = "Số lần nhồi boom tại 1 chỗ";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(264, 328);
		base.Controls.Add(label2);
		base.Controls.Add(comboBoxSolanNhoiboom);
		base.Controls.Add(groupBox1);
		base.Controls.Add(label1);
		base.Controls.Add(comboBoxTenAc);
		base.Controls.Add(richTextBox1);
		base.Controls.Add(textBoxKhoangCach);
		base.Controls.Add(checkBoxDatXungQuanh);
		base.Controls.Add(buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormDuongMon";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "DUONG MON BOOM";
		base.Load += new System.EventHandler(FormDuongMon_Load);
		groupBox1.ResumeLayout(performLayout: false);
		groupBox1.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
