using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormTapKet : Form
{
	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private Button buttonThem;

	private Button buttonXoa;

	private Button buttonClose;

	private System.Windows.Forms.Timer timer_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private Label label1;

	private TextBox textBoxMenu;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	private Button buttonHelp;

	private ComboBox comboBoxChon;

	private RichTextBox richTextBox1;

	private Button buttonSua;

	private Label label2;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static bool bool_1 = false;

	public static GStruct51[] gstruct51_0 = null;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	private static GStruct19[] gstruct19_0 = null;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormTapKet));
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		buttonThem = new System.Windows.Forms.Button();
		buttonXoa = new System.Windows.Forms.Button();
		buttonClose = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		label1 = new System.Windows.Forms.Label();
		textBoxMenu = new System.Windows.Forms.TextBox();
		buttonHelp = new System.Windows.Forms.Button();
		comboBoxChon = new System.Windows.Forms.ComboBox();
		richTextBox1 = new System.Windows.Forms.RichTextBox();
		buttonSua = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		SuspendLayout();
		listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[5]
		{
			columnHeader_0,
			columnHeader_1,
			columnHeader_2,
			columnHeader_3,
			columnHeader_4
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(4, 96);
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(385, 125);
		listView1.TabIndex = 218;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "STT";
		columnHeader_0.Width = 35;
		columnHeader_1.Text = "Click vào NPC";
		columnHeader_1.Width = 110;
		columnHeader_2.Text = "Tọa độ";
		columnHeader_2.Width = 80;
		columnHeader_3.Text = "Click các dòng";
		columnHeader_3.Width = 90;
		columnHeader_4.Text = "Bản đồ";
		columnHeader_4.Width = 50;
		buttonThem.ForeColor = System.Drawing.Color.DarkRed;
		buttonThem.Location = new System.Drawing.Point(205, 225);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(96, 26);
		buttonThem.TabIndex = 219;
		buttonThem.Text = "Thêm";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		buttonXoa.Location = new System.Drawing.Point(309, 225);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(80, 26);
		buttonXoa.TabIndex = 220;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		buttonClose.Location = new System.Drawing.Point(309, 257);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(80, 26);
		buttonClose.TabIndex = 222;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(4, 261);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 13);
		label1.TabIndex = 223;
		label1.Text = "Click vào các dòng";
		textBoxMenu.Location = new System.Drawing.Point(108, 259);
		textBoxMenu.Name = "textBoxMenu";
		textBoxMenu.Size = new System.Drawing.Size(45, 20);
		textBoxMenu.TabIndex = 224;
		buttonHelp.ForeColor = System.Drawing.Color.MediumBlue;
		buttonHelp.Location = new System.Drawing.Point(205, 257);
		buttonHelp.Name = "buttonHelp";
		buttonHelp.Size = new System.Drawing.Size(96, 26);
		buttonHelp.TabIndex = 225;
		buttonHelp.Text = "Hướng dẫn";
		buttonHelp.UseVisualStyleBackColor = true;
		buttonHelp.Click += new System.EventHandler(buttonHelp_Click);
		comboBoxChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxChon.FormattingEnabled = true;
		comboBoxChon.Location = new System.Drawing.Point(32, 229);
		comboBoxChon.Name = "comboBoxChon";
		comboBoxChon.Size = new System.Drawing.Size(165, 21);
		comboBoxChon.TabIndex = 226;
		comboBoxChon.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxChon_MouseDown);
		richTextBox1.Location = new System.Drawing.Point(4, 3);
		richTextBox1.Name = "richTextBox1";
		richTextBox1.Size = new System.Drawing.Size(384, 87);
		richTextBox1.TabIndex = 227;
		//richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
		buttonSua.Location = new System.Drawing.Point(157, 256);
		buttonSua.Name = "buttonSua";
		buttonSua.Size = new System.Drawing.Size(40, 26);
		buttonSua.TabIndex = 228;
		buttonSua.Text = "Sửa";
		buttonSua.UseVisualStyleBackColor = true;
		buttonSua.Click += new System.EventHandler(buttonSua_Click);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(2, 233);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(29, 13);
		label2.TabIndex = 229;
		label2.Text = "NPC";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(394, 286);
		base.Controls.Add(label2);
		base.Controls.Add(textBoxMenu);
		base.Controls.Add(buttonSua);
		base.Controls.Add(richTextBox1);
		base.Controls.Add(comboBoxChon);
		base.Controls.Add(buttonHelp);
		base.Controls.Add(label1);
		base.Controls.Add(buttonClose);
		base.Controls.Add(buttonXoa);
		base.Controls.Add(buttonThem);
		base.Controls.Add(listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormTapKet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "DEN DIEM TAP KET";
		base.Load += new System.EventHandler(FormTapKet_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public static int smethod_0(int int_5)
	{
		try
		{
			return smethod_1(int_5);
		}
		catch
		{
		}
		return -1;
	}

	public static int smethod_1(int int_5)
	{
		int result = 0;
		int num = 0;
		GStruct42 gStruct = default(GStruct42);
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		string text = null;
		string text2 = null;
		uint[] array = null;
		uint[] array2 = null;
		long long_ = 0L;
		long long_2 = 0L;
		int num7 = 0;
		while (true)
		{
			Thread.Sleep(120);
			int num8 = Class71.smethod_3(FormMain.gstruct42_0, int_5);
			uint num12;
			int num15;
			string[] array5;
			int num18;
			if (!Class11.bool_0 && num8 >= 0 && FormMain.int_107 > 0 && FormMain.int_20 == 0 && gstruct51_0 != null && Class47.long_0 >= GClass1.long_1)
			{
				gStruct = FormMain.gstruct42_0[num8];
				if (!gStruct.bool_36 || gStruct.int_21[0] > 0 || gStruct.int_126[0] > 0 || gStruct.bool_60 || gStruct.int_26 > 0 || gStruct.bool_21 || gStruct.bool_6)
				{
					break;
				}
				uint num9 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
				uint num10 = Class20.smethod_30(num9 + Class47.gstruct43_13.uint_0, gStruct.int_130);
				uint num11 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
				num12 = num11 + num10 * Class47.gstruct43_15.uint_0;
				int num13 = (int)Class20.smethod_30(num12 + Class47.gstruct43_55.uint_0, gStruct.int_130);
				int num14 = (int)Class20.smethod_30(num12 + Class47.gstruct43_50.uint_0, gStruct.int_130);
				num15 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
				if (num13 != 10 && num13 != 21 && num14 != 0 && num13 != 0 && num15 != 0)
				{
					int num16 = (int)Class20.smethod_30(num12 + Class47.gstruct43_43.uint_0, gStruct.int_130);
					if (num16 <= 0)
					{
						num3 = 0;
						while (num3 < 255)
						{
							num3++;
							if (gstruct51_0.Length > num2)
							{
								if (gstruct51_0[num2].int_0 != num15)
								{
									num2++;
									continue;
								}
								text = gstruct51_0[num2].string_0;
								array = gstruct51_0[num2].uint_0;
								text2 = gstruct51_0[num2].string_1;
								num7 = 0;
								break;
							}
							goto IL_089f;
						}
						num = 0;
						uint[] array3 = new uint[2]
						{
							Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
							Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
						};
						long num17 = Class53.smethod_18(array3, array);
						if (num17 > 800000L)
						{
							if (Class20.smethod_30(num12 + Class47.gstruct43_44.uint_0, gStruct.int_130) == 0 && gStruct.bool_64 && Class11.smethod_23(long_) > 600L)
							{
								Class60.smethod_55(gStruct, "Switch([[horse]])");
								long_ = Class11.smethod_22();
							}
							if (num4 < 1 && (num15 == 37 || num15 == 80 || num15 == 1 || num15 == 78 || num15 == 162 || num15 == 176 || num15 == 11))
							{
								uint[,] uint_ = Class44.smethod_1(num15, array3, array);
								Class53.smethod_22(gStruct, uint_, array3, array, num15, bool_0: true, 100000);
								num4 = 1;
								continue;
							}
							if (num4 < 6 && num15 == 999)
							{
								uint[,] array4 = Class37.smethod_8(Class44.gstruct17_10, array3, array);
								if (array4 != null)
								{
									Class53.smethod_22(gStruct, array4, array3, array, num15, bool_0: true, 100000);
								}
								else
								{
									num4 = 6;
								}
								num4++;
								continue;
							}
							if (array2 == null)
							{
								array2 = new uint[2]
								{
									array3[0],
									array3[1]
								};
								num5 = 0;
							}
							if (num5 > 6)
							{
								bool flag = array2 != null && Class53.smethod_18(array2, array3) < 180000L;
								array2 = null;
								if (flag)
								{
									Class53.smethod_0(gStruct, array3, Class38.gstruct29_0.uint_4, 600);
									continue;
								}
								num5 = 0;
							}
							if (Class11.smethod_23(long_2) > 4500L)
							{
								if (Class12.smethod_1(gStruct, array) <= 0)
								{
									Class53.smethod_10(gStruct);
								}
								num5++;
								long_2 = Class11.smethod_22();
							}
						}
						num3 = 0;
						Class12.smethod_3(gStruct, bool_0: false);
						if (Class76.Class79.smethod_4(gStruct))
						{
							Class76.Class79.smethod_5(gStruct);
							Thread.Sleep(300);
						}
						if (Class76.smethod_0(gStruct))
						{
							Class76.smethod_9(gStruct);
							Thread.Sleep(300);
						}
						while (!Class11.bool_0)
						{
							array3 = new uint[2]
							{
								Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
								Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
							};
							if (Class53.smethod_18(array3, array) <= 22500L)
							{
								break;
							}
							if (num3 <= 15)
							{
								Class60.smethod_61(gStruct, array);
								num3++;
								Thread.Sleep(300);
								continue;
							}
							Class12.smethod_1(gStruct, array);
							Thread.Sleep(3000);
							break;
						}
						Class12.smethod_3(gStruct, bool_0: false);
						if (num7 <= 0)
						{
							Thread.Sleep(300);
							num7 = Class86.smethod_12(gStruct, text, 3, bool_0: true);
						}
						if (num7 <= 0)
						{
							Class53.smethod_8(gStruct, "Dang tim " + text + " !");
							num6++;
							if (num6 > 6)
							{
								Class53.smethod_10(gStruct);
								num6 = 0;
							}
							continue;
						}
						num6 = 0;
						num3 = 0;
						while (true)
						{
							if (!Class11.bool_0)
							{
								if (num3 % 10 == 0)
								{
									Class32.smethod_9(gStruct, (uint)num7);
									Thread.Sleep(300);
									num6++;
								}
								Thread.Sleep(100);
								if (!Class76.smethod_0(gStruct))
								{
									if (!Class76.Class79.smethod_4(gStruct))
									{
										num3++;
										if (num6 > 6)
										{
											break;
										}
										continue;
									}
									Class76.Class79.smethod_5(gStruct);
								}
							}
							Thread.Sleep(150);
							array5 = text2.Split(',', '.', '|', '/');
							num18 = 0;
							goto IL_07fb;
						}
						Class53.smethod_10(gStruct);
						num6 = 0;
						continue;
					}
					result = 1;
					break;
				}
				if (num14 == 0 || num13 == 0)
				{
					num++;
					if (num < 10)
					{
						Thread.Sleep(100);
						continue;
					}
				}
				result = -1;
				break;
			}
			result = 0;
			break;
			IL_089f:
			result = 1;
			break;
			IL_07fb:
			while (true)
			{
				if (num18 < array5.Length)
				{
					if (!Class76.smethod_0(gStruct))
					{
						break;
					}
					int num19 = Class11.smethod_12(array5[num18]) - 1;
					if (num19 < 0)
					{
						goto IL_07f5;
					}
					int num20 = Class76.smethod_1(gStruct);
					int num21 = Class76.smethod_2(gStruct, num20);
					string text3 = string.Empty;
					for (int i = 0; i < num21; i++)
					{
						text3 += Class76.smethod_3(gStruct, i, num20);
					}
					Class76.smethod_6(gStruct, num19);
					Thread.Sleep(300);
					for (num3 = 0; num3 < 10; num3++)
					{
						int num22 = Class76.smethod_1(gStruct);
						if (num22 != num20)
						{
							break;
						}
						int num23 = Class76.smethod_2(gStruct, num22);
						if (num23 != num21)
						{
							break;
						}
						string text4 = string.Empty;
						for (int i = 0; i < num23; i++)
						{
							text4 += Class76.smethod_3(gStruct, i, num22);
						}
						if (text3 != text4)
						{
							break;
						}
						Thread.Sleep(100);
					}
					Thread.Sleep(150);
					int num24 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
					int num25 = (int)Class20.smethod_30(num12 + Class47.gstruct43_43.uint_0, gStruct.int_130);
					if ((num24 == 0 || num24 == num15) && num25 <= 0)
					{
						goto IL_07f5;
					}
				}
				Class76.smethod_9(gStruct);
				break;
				IL_07f5:
				num18++;
			}
			int num26 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
			int num27 = (int)Class20.smethod_30(num12 + Class47.gstruct43_43.uint_0, gStruct.int_130);
			if ((num26 == 0 || num26 == num15) && num27 <= 0)
			{
				num2++;
				continue;
			}
			result = 1;
			break;
		}
		return result;
	}

	public static void smethod_2()
	{
		gstruct51_0 = null;
		string text = Class11.smethod_28(Class47.string_5 + "\\Tapket.txt", 0, 0, 1);
		if (text == null || text == string.Empty)
		{
			return;
		}
		string[] array = text.Split('\r', '\n');
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == null || array[i] == string.Empty)
			{
				continue;
			}
			string[] array2 = array[i].Split(';');
			if (array2.Length != 5)
			{
				continue;
			}
			string text2 = array2[0];
			uint num = Class11.smethod_13(array2[1]);
			uint num2 = Class11.smethod_13(array2[2]);
			string text3 = array2[3];
			int num3 = Class11.smethod_12(array2[4]);
			if (text2 != null && !(text2 == string.Empty) && num != 0 && num2 != 0 && text3 != null && !(text3 == string.Empty))
			{
				if (gstruct51_0 != null)
				{
					Array.Resize(ref gstruct51_0, gstruct51_0.Length + 1);
				}
				else
				{
					gstruct51_0 = new GStruct51[1];
				}
				gstruct51_0[gstruct51_0.Length - 1].string_0 = text2;
				gstruct51_0[gstruct51_0.Length - 1].uint_0 = new uint[2]
				{
					num,
					num2
				};
				gstruct51_0[gstruct51_0.Length - 1].string_1 = text3;
				gstruct51_0[gstruct51_0.Length - 1].int_0 = num3;
			}
		}
	}

	private static void smethod_3()
	{
		string text = string.Empty;
		if (gstruct51_0 != null)
		{
			for (int i = 0; i < gstruct51_0.Length; i++)
			{
				if (gstruct51_0[i].string_0 != null && !(gstruct51_0[i].string_0 == string.Empty) && gstruct51_0[i].uint_0 != null && gstruct51_0[i].uint_0[0] != 0 && gstruct51_0[i].uint_0[1] != 0 && gstruct51_0[i].string_1 != null && !(gstruct51_0[i].string_1 == string.Empty))
				{
					gstruct51_0[i].string_1 = gstruct51_0[i].string_1.Replace(";", ",");
					if (text != string.Empty)
					{
						text += Class47.string_3;
					}
					object obj = text;
					text = obj + gstruct51_0[i].string_0 + ";" + gstruct51_0[i].uint_0[0] + ";" + gstruct51_0[i].uint_0[1] + ";" + gstruct51_0[i].string_1 + ";" + gstruct51_0[i].int_0;
				}
			}
		}
		Class11.smethod_29(Class47.string_5 + "\\Tapket.txt", text, 1);
	}

	public FormTapKet()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		smethod_3();
		int_1 = 0;
		int_2 = 0;
		int_0 = 0;
		bool_0 = false;
	}

	private void FormTapKet_Load(object sender, EventArgs e)
	{
		if (int_1 > 0 && int_2 > 0)
		{
			int num = int_1 - base.Width - 10;
			int num2 = int_2 - base.Height - 10;
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
		if (!bool_1)
		{
			bool_1 = true;
			smethod_2();
		}
		if (gstruct51_0 != null)
		{
			for (int i = 0; i < gstruct51_0.Length; i++)
			{
				method_0(listView1, gstruct51_0[i].string_0, gstruct51_0[i].uint_0, gstruct51_0[i].string_1, gstruct51_0[i].int_0);
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void method_0(ListView listView_0, string string_0, uint[] uint_0, string string_1, int int_5)
	{
		string text = "1";
		if (listView_0.Items != null && listView_0.Items.Count > 0)
		{
			text = (listView_0.Items.Count + 1).ToString();
		}
		string[] array = new string[5]
		{
			text,
			Class10.smethod_1(string_0, 1),
			uint_0[0] + "," + uint_0[1],
			string_1,
			Class33.smethod_1(int_5, bool_0: true)
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
		listView_0.Items.Add(listViewItem);
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (gstruct19_0 == null || textBoxMenu.Text == string.Empty)
		{
			return;
		}
		string text = null;
		string string_ = textBoxMenu.Text.Replace(";", ",");
		uint[] array = null;
		int int_ = 0;
		string text2 = comboBoxChon.Text;
		for (int i = 0; i < gstruct19_0.Length; i++)
		{
			if (text2 == Class10.smethod_1(gstruct19_0[i].string_0, 1))
			{
				text = gstruct19_0[i].string_0;
				array = new uint[2]
				{
					gstruct19_0[i].uint_0[0],
					gstruct19_0[i].uint_0[1]
				};
				int_ = gstruct19_0[i].int_0;
				break;
			}
		}
		if (text != null)
		{
			if (gstruct51_0 == null)
			{
				gstruct51_0 = new GStruct51[1];
			}
			else
			{
				Array.Resize(ref gstruct51_0, gstruct51_0.Length + 1);
			}
			int num = gstruct51_0.Length;
			gstruct51_0[num - 1].string_0 = text;
			gstruct51_0[num - 1].uint_0 = new uint[2]
			{
				array[0],
				array[1]
			};
			gstruct51_0[num - 1].int_0 = int_;
			gstruct51_0[num - 1].string_1 = string_;
			method_0(listView1, text, array, string_, int_);
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		if (gstruct51_0 != null)
		{
			int num = -1;
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				if (listView1.Items[i].Selected)
				{
					num = i;
					listView1.Items.RemoveAt(num);
					break;
				}
			}
			if (num < 0)
			{
				return;
			}
			int num2 = 0;
			GStruct51[] array = new GStruct51[gstruct51_0.Length];
			for (int i = 0; i < gstruct51_0.Length; i++)
			{
				if (num != i)
				{
					array[num2] = gstruct51_0[i];
					num2++;
				}
			}
			if (num2 == 0)
			{
				listView1.Items.Clear();
				gstruct51_0 = null;
				return;
			}
			gstruct51_0 = new GStruct51[num2];
			for (int i = 0; i < num2; i++)
			{
				gstruct51_0[i] = array[i];
			}
		}
		else
		{
			listView1.Items.Clear();
		}
	}

	private void comboBoxChon_MouseDown(object sender, MouseEventArgs e)
	{
		gstruct19_0 = null;
		if (int_0 > 0)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (0 <= num)
			{
				Class86.smethod_25(FormMain.gstruct42_0[num], ref gstruct19_0, 3);
			}
		}
		if (gstruct19_0 == null && FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				Class86.smethod_25(FormMain.gstruct42_0[i], ref gstruct19_0, 3);
			}
		}
		string text = comboBoxChon.Text;
		string text2 = null;
		comboBoxChon.Items.Clear();
		if (gstruct19_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct19_0.Length; i++)
		{
			string text3 = Class10.smethod_1(gstruct19_0[i].string_0, 1);
			comboBoxChon.Items.Add(text3);
			if (i == 0 || text3 == text)
			{
				text2 = text3;
			}
		}
		comboBoxChon.Text = text2;
	}

	private void buttonSua_Click(object sender, EventArgs e)
	{
		string text = textBoxMenu.Text;
		if (text == null || text == string.Empty)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num >= 0)
		{
			if (gstruct51_0 != null && gstruct51_0.Length > num)
			{
				gstruct51_0[num].string_1 = text;
				listView1.Items[num].SubItems[3].Text = text;
			}
			else
			{
				listView1.Items.Clear();
				gstruct51_0 = null;
			}
		}
	}

	private void buttonHelp_Click(object sender, EventArgs e)
	{
		string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(text))
		{
			text = Class55.smethod_0();
		}
		Class20.smethod_40(text, "", "https://youtu.be/H7NtepyTDAY", 0);
	}
}
