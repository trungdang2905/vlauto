using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormXaphuCT : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	private static int int_1 = -1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private static string[] string_0 = null;

	private static int int_6 = 0;

	private IContainer icontainer_0 = null;

	private Label label19;

	private Button buttonXoaCongThanhQuan;

	private ComboBox comboBoxCongThanhQuan;

	private Button buttonLayCongThanhQuan;

	private ListView listViewXaphuCongthanh;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonTudongLayvitri;

	private Label label1;

	public FormXaphuCT()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int_0 = -2;
		bool_0 = false;
	}

	private void FormXaphuCT_Load(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			Close();
			return;
		}
		if (int_2 >= 0 && int_3 >= 0)
		{
			int num2 = int_2 - base.Width;
			int num3 = int_3 + int_5 - base.Height;
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			SetBounds(num2, num3, base.Width, base.Height);
		}
		for (int i = 0; i < Class89.struct31_0.Length; i++)
		{
			method_0(Class89.struct31_0[i]);
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
		if (0 <= int_1)
		{
			string text = Class89.struct31_0[int_1].string_0;
			uint[] array = new uint[2]
			{
				Class89.struct31_0[int_1].uint_0[0],
				Class89.struct31_0[int_1].uint_0[1]
			};
			listViewXaphuCongthanh.Items[int_1].SubItems[1].Text = Class10.smethod_1(text, 1);
			listViewXaphuCongthanh.Items[int_1].SubItems[2].Text = (array[0] / 256u).ToString() + "," + array[1] / 512u;
			int_1 = -1;
		}
	}

	private void method_0(Class89.Struct31 struct31_0)
	{
		string text = "...";
		string text2 = "...";
		if (struct31_0.uint_0 != null)
		{
			text = struct31_0.uint_0[0] / 256u + "," + struct31_0.uint_0[1] / 512u;
		}
		if (struct31_0.string_0 != null && struct31_0.string_0 != string.Empty)
		{
			text2 = Class10.smethod_1(struct31_0.string_0, 1);
		}
		string[] array = new string[4]
		{
			struct31_0.string_2,
			text2,
			text,
			struct31_0.int_0.ToString()
		};
		ListViewItem listViewItem = new ListViewItem(array[0]);
		for (int i = 1; i < array.Length; i++)
		{
			ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
			listViewItem.SubItems.Add(item);
		}
		listViewXaphuCongthanh.Items.Add(listViewItem);
	}

	private void comboBoxCongThanhQuan_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		timer_0.Enabled = false;
		comboBoxCongThanhQuan.Items.Clear();
		string_0 = null;
		Class86.smethod_24(FormMain.gstruct42_0[num], ref string_0, 3);
		int_6 = Class33.smethod_0(FormMain.gstruct42_0[num]);
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxCongThanhQuan.Items.Add(Class10.smethod_1(string_0[i], 1));
			}
		}
		timer_0.Enabled = true;
	}

	private void buttonLayCongThanhQuan_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		int num2 = Class33.smethod_0(FormMain.gstruct42_0[num]);
		if (string_0 != null && num2 == int_6)
		{
			string text = null;
			string text2 = comboBoxCongThanhQuan.Text;
			for (int i = 0; i < string_0.Length; i++)
			{
				if (text2 == Class10.smethod_1(string_0[i], 1))
				{
					text = string_0[i];
					break;
				}
			}
			if (text == null)
			{
				return;
			}
			uint[] uint_ = null;
			int num3 = Class86.smethod_14(FormMain.gstruct42_0[num], text, ref uint_);
			if (num3 <= 0)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < Class89.struct31_0.Length; i++)
			{
				if (num2 == Class89.struct31_0[i].int_0)
				{
					Class89.struct31_0[i].string_0 = text;
					Class89.struct31_0[i].uint_0 = new uint[2]
					{
						uint_[0],
						uint_[1]
					};
					listViewXaphuCongthanh.Items[i].SubItems[1].Text = Class10.smethod_1(text, 1);
					listViewXaphuCongthanh.Items[i].SubItems[2].Text = (uint_[0] / 256u).ToString() + "," + uint_[1] / 512u;
					flag = true;
					break;
				}
			}
			if (flag)
			{
				Class89.smethod_4();
			}
		}
		else
		{
			Class11.smethod_24(ref Class11.string_14, "Hãy chọn vị trí Xa phu công thành quan trước nhé.");
		}
	}

	private void buttonXoaCongThanhQuan_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewXaphuCongthanh.Items.Count; i++)
		{
			if (listViewXaphuCongthanh.Items[i].Selected)
			{
				listViewXaphuCongthanh.Items[i].SubItems[1].Text = "...";
				listViewXaphuCongthanh.Items[i].SubItems[2].Text = "...";
				Class89.struct31_0[i].string_0 = null;
				Class89.struct31_0[i].uint_0 = null;
				Class89.smethod_4();
			}
		}
	}

	private void buttonTudongLayvitri_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0 && !FormMain.gstruct42_0[num].bool_0)
		{
			FormMain.gstruct42_0[num].bool_0 = true;
			new Thread(smethod_0).Start();
		}
	}

	private static void smethod_0()
	{
		int int_ = int_0;
		try
		{
			smethod_1(int_);
		}
		catch
		{
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].bool_0 = false;
		}
	}

	private static void smethod_1(int int_7)
	{
		int num = 0;
		GStruct42 gStruct = default(GStruct42);
		string[] array = new string[4]
		{
			"Xa Phu C«ng Thµnh",
			"Çu C«ng Thµnh ChiÕn",
			"ThÊt thµnh",
			"tiÕp dÉn"
		};
		uint[,] array2 = new uint[7, 3]
		{
			{
				11u,
				101952u,
				165824u
			},
			{
				78u,
				50624u,
				108160u
			},
			{
				1u,
				52544u,
				104640u
			},
			{
				162u,
				53760u,
				104832u
			},
			{
				37u,
				54144u,
				102784u
			},
			{
				80u,
				54144u,
				102976u
			},
			{
				176u,
				54048u,
				105248u
			}
		};
		int num2 = 0;
		int int_8 = 0;
		int num3 = 0;
		uint[] array3 = new uint[2];
		int num4 = 0;
		long long_ = 0L;
		byte[] array4 = new byte[4];
		byte[] array5 = new byte[60];
		while (true)
		{
			Thread.Sleep(300);
			num = Class71.smethod_3(FormMain.gstruct42_0, int_7);
			if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || !FormMain.gstruct42_0[num].bool_0)
			{
				return;
			}
			gStruct = FormMain.gstruct42_0[num];
			if (array2.GetLength(0) <= num2)
			{
				break;
			}
			uint num5 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
			uint num6 = Class20.smethod_30(num5 + Class47.gstruct43_13.uint_0, gStruct.int_130);
			uint num7 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
			uint num8 = num7 + num6 * Class47.gstruct43_15.uint_0;
			int num9 = (int)Class20.smethod_30(num8 + Class47.gstruct43_55.uint_0, gStruct.int_130);
			int num10 = (int)Class20.smethod_30(num8 + Class47.gstruct43_50.uint_0, gStruct.int_130);
			int num11 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
			Class20.smethod_30(num8 + Class47.gstruct43_43.uint_0, gStruct.int_130);
			int num12 = Class73.smethod_40(gStruct);
			if (num10 == 0 || num9 == 0 || num11 == 0 || num12 <= 1)
			{
				continue;
			}
			uint[] uint_ = new uint[2]
			{
				Class20.smethod_30(num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
				Class20.smethod_30(num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
			};
			num4 = (int)array2[num2, 0];
			array3[0] = array2[num2, 1];
			array3[1] = array2[num2, 2];
			if (num11 != num4)
			{
				if (!Class31.smethod_61(gStruct, num4, null, array3))
				{
					Class44.smethod_5(gStruct, num4);
				}
				num3 = 0;
				continue;
			}
			long num13 = Class53.smethod_18(uint_, array3);
			if (num13 > 640000L)
			{
				if (Class11.smethod_23(long_) > 6000L)
				{
					Class12.smethod_1(gStruct, array3);
					long_ = Class11.smethod_22();
				}
				continue;
			}
			Class12.smethod_3(gStruct, bool_0: false);
			if (num13 > 160000L)
			{
				Class60.smethod_61(gStruct, array3);
				Thread.Sleep(150);
				continue;
			}
			uint uint_2 = gStruct.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
			Class20.ReadProcessMemory(gStruct.int_130, uint_2, array4, 4, ref int_8);
			int num14 = BitConverter.ToInt32(array4, 0);
			if (num14 <= 1)
			{
				num3++;
				if (num3 > 10)
				{
					Class53.smethod_10(gStruct);
					num3 = 0;
				}
				Thread.Sleep(300);
				continue;
			}
			string text = null;
			long num15 = 0L;
			uint[] array6 = new uint[2];
			int num16 = 0;
			for (uint num17 = 1u; num17 < 256; num17++)
			{
				if (num14 <= num16)
				{
					break;
				}
				if (num17 != num6)
				{
					uint num18 = num7 + num17 * Class47.gstruct43_15.uint_0;
					Class20.ReadProcessMemory(gStruct.int_130, num18 + Class47.gstruct43_16.uint_0, array4, 4, ref int_8);
					if (array4[0] == 0)
					{
						continue;
					}
					num16++;
					Class20.ReadProcessMemory(gStruct.int_130, num18 + Class47.gstruct43_50.uint_0, array4, 4, ref int_8);
					if (BitConverter.ToInt32(array4, 0) <= 0)
					{
						continue;
					}
					Class20.ReadProcessMemory(gStruct.int_130, num18 + Class47.gstruct43_52.uint_0, array4, 4, ref int_8);
					uint num19 = BitConverter.ToUInt32(array4, 0);
					if (num19 != 3)
					{
						continue;
					}
					uint[] array7 = new uint[2];
					Class20.ReadProcessMemory(gStruct.int_130, num18 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array4, 4, ref int_8);
					array7[0] = BitConverter.ToUInt32(array4, 0);
					Class20.ReadProcessMemory(gStruct.int_130, num18 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array4, 4, ref int_8);
					array7[1] = BitConverter.ToUInt32(array4, 0);
					Class20.ReadProcessMemory(gStruct.int_130, num18 + Class47.gstruct43_16.uint_0, array5, array5.Length, ref int_8);
					string text2 = Class10.smethod_3(array5);
					string string_ = text2.ToLower();
					bool flag = false;
					for (int i = 0; i < array.Length; i++)
					{
						if (0 <= Class11.smethod_2(string_, array[i].ToLower()))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						array6[0] = array7[0];
						array6[1] = array7[1];
						text = text2;
						break;
					}
					long num20 = Class53.smethod_18(array3, array7);
					if (num20 < 160000L && (text == null || num20 < num15))
					{
						num15 = num20;
						array6[0] = array7[0];
						array6[1] = array7[1];
						text = text2;
					}
				}
				else
				{
					num16++;
				}
			}
			if (text == null)
			{
				continue;
			}
			for (int i = 0; i < Class89.struct31_0.Length; i++)
			{
				if (num11 == Class89.struct31_0[i].int_0)
				{
					Class89.struct31_0[i].string_0 = text;
					Class89.struct31_0[i].uint_0 = new uint[2]
					{
						array6[0],
						array6[1]
					};
					Class89.smethod_4();
					int_1 = i;
					break;
				}
			}
			num2++;
			num3 = 0;
		}
		FormMain.gstruct42_0[num].bool_0 = false;
		Class60.smethod_50(gStruct, "<color=yellow>DA LAY XONG TAT CA VI TRI");
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormXaphuCT));
		label19 = new System.Windows.Forms.Label();
		buttonXoaCongThanhQuan = new System.Windows.Forms.Button();
		comboBoxCongThanhQuan = new System.Windows.Forms.ComboBox();
		buttonLayCongThanhQuan = new System.Windows.Forms.Button();
		listViewXaphuCongthanh = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonTudongLayvitri = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		SuspendLayout();
		label19.ForeColor = System.Drawing.Color.Black;
		label19.Location = new System.Drawing.Point(3, 254);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(416, 46);
		label19.TabIndex = 234;
		//label19.Text = componentResourceManager.GetString("label19.Text");
		buttonXoaCongThanhQuan.Location = new System.Drawing.Point(205, 209);
		buttonXoaCongThanhQuan.Name = "buttonXoaCongThanhQuan";
		buttonXoaCongThanhQuan.Size = new System.Drawing.Size(74, 36);
		buttonXoaCongThanhQuan.TabIndex = 238;
		buttonXoaCongThanhQuan.Text = "Xóa, bỏ qua";
		buttonXoaCongThanhQuan.UseVisualStyleBackColor = true;
		buttonXoaCongThanhQuan.Click += new System.EventHandler(buttonXoaCongThanhQuan_Click);
		comboBoxCongThanhQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxCongThanhQuan.FormattingEnabled = true;
		comboBoxCongThanhQuan.Location = new System.Drawing.Point(4, 190);
		comboBoxCongThanhQuan.Name = "comboBoxCongThanhQuan";
		comboBoxCongThanhQuan.Size = new System.Drawing.Size(195, 21);
		comboBoxCongThanhQuan.TabIndex = 236;
		comboBoxCongThanhQuan.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxCongThanhQuan_MouseDown);
		buttonLayCongThanhQuan.Location = new System.Drawing.Point(4, 217);
		buttonLayCongThanhQuan.Name = "buttonLayCongThanhQuan";
		buttonLayCongThanhQuan.Size = new System.Drawing.Size(195, 28);
		buttonLayCongThanhQuan.TabIndex = 237;
		buttonLayCongThanhQuan.Text = "Lấy";
		buttonLayCongThanhQuan.UseVisualStyleBackColor = true;
		buttonLayCongThanhQuan.Click += new System.EventHandler(buttonLayCongThanhQuan_Click);
		listViewXaphuCongthanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		listViewXaphuCongthanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4]
		{
			columnHeader_0,
			columnHeader_1,
			columnHeader_2,
			columnHeader_3
		});
		listViewXaphuCongthanh.FullRowSelect = true;
		listViewXaphuCongthanh.GridLines = true;
		listViewXaphuCongthanh.HideSelection = false;
		listViewXaphuCongthanh.Location = new System.Drawing.Point(4, 35);
		listViewXaphuCongthanh.Name = "listViewXaphuCongthanh";
		listViewXaphuCongthanh.Size = new System.Drawing.Size(415, 149);
		listViewXaphuCongthanh.TabIndex = 235;
		listViewXaphuCongthanh.UseCompatibleStateImageBehavior = false;
		listViewXaphuCongthanh.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "Thành";
		columnHeader_0.Width = 85;
		columnHeader_1.Text = "Xa phu CTQ";
		columnHeader_1.Width = 180;
		columnHeader_2.Text = "Vị trí";
		columnHeader_2.Width = 100;
		columnHeader_3.Text = "ID";
		columnHeader_3.Width = 30;
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonTudongLayvitri.ForeColor = System.Drawing.Color.DarkRed;
		buttonTudongLayvitri.Location = new System.Drawing.Point(285, 209);
		buttonTudongLayvitri.Name = "buttonTudongLayvitri";
		buttonTudongLayvitri.Size = new System.Drawing.Size(134, 36);
		buttonTudongLayvitri.TabIndex = 240;
		buttonTudongLayvitri.Text = "Tự động chạy lấy vị trí xa phu vào CTC";
		buttonTudongLayvitri.UseVisualStyleBackColor = true;
		buttonTudongLayvitri.Click += new System.EventHandler(buttonTudongLayvitri_Click);
		label1.ForeColor = System.Drawing.Color.Black;
		label1.Location = new System.Drawing.Point(3, 2);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(416, 28);
		label1.TabIndex = 241;
		label1.Text = "Bạn phải lấy hết vị trí xa phu vào CTC của 7 thành thì auto mới vào được chiến trường CTC bằng xa phu.";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(426, 304);
		base.Controls.Add(label1);
		base.Controls.Add(buttonLayCongThanhQuan);
		base.Controls.Add(comboBoxCongThanhQuan);
		base.Controls.Add(buttonTudongLayvitri);
		base.Controls.Add(label19);
		base.Controls.Add(buttonXoaCongThanhQuan);
		base.Controls.Add(listViewXaphuCongthanh);
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormXaphuCT";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "XA PHU CONG THANH QUAN";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormXaphuCT_Load);
		ResumeLayout(performLayout: false);
	}
}
