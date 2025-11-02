using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormBanEvent : Form
{
	private IContainer icontainer_0 = null;

	private Button buttonXoa;

	private Button buttonThem;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ComboBox comboBoxTenTuiMauHotro;

	private Button buttonClose;

	private System.Windows.Forms.Timer timer_0;

	public static int int_0 = 0;

	private static bool bool_0 = false;

	public static string[] string_0 = null;

	public static bool bool_1 = false;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormBanEvent));
		buttonXoa = new System.Windows.Forms.Button();
		buttonThem = new System.Windows.Forms.Button();
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		comboBoxTenTuiMauHotro = new System.Windows.Forms.ComboBox();
		buttonClose = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		SuspendLayout();
		buttonXoa.Location = new System.Drawing.Point(3, 178);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(53, 23);
		buttonXoa.TabIndex = 235;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		buttonThem.Location = new System.Drawing.Point(62, 178);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(80, 23);
		buttonThem.TabIndex = 234;
		buttonThem.Text = "Thêm";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			columnHeader_0
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(3, 3);
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(200, 142);
		listView1.TabIndex = 233;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "Tên";
		columnHeader_0.Width = 180;
		comboBoxTenTuiMauHotro.DropDownWidth = 252;
		comboBoxTenTuiMauHotro.FormattingEnabled = true;
		comboBoxTenTuiMauHotro.Location = new System.Drawing.Point(3, 151);
		comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
		comboBoxTenTuiMauHotro.Size = new System.Drawing.Size(200, 21);
		comboBoxTenTuiMauHotro.TabIndex = 232;
		comboBoxTenTuiMauHotro.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenTuiMauHotro_MouseDown);
		buttonClose.Location = new System.Drawing.Point(150, 178);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(53, 23);
		buttonClose.TabIndex = 236;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(207, 205);
		base.Controls.Add(buttonClose);
		base.Controls.Add(buttonXoa);
		base.Controls.Add(buttonThem);
		base.Controls.Add(listView1);
		base.Controls.Add(comboBoxTenTuiMauHotro);
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "FormBanEvent";
		Text = "VAT PHAM RAC";
		base.Load += new System.EventHandler(FormBanEvent_Load);
		ResumeLayout(performLayout: false);
	}

	private static string[] smethod_0()
	{
		string text = Class11.smethod_28(Class47.string_5 + "\\VatphamRac.txt", 0, 0, 1);
		if (text != null && !(text == string.Empty))
		{
			string text2 = Class11.smethod_16(text);
			if (text2 != null && !(text2 == string.Empty))
			{
				string[] array = text2.Split('|');
				int num = array.Length;
				int num2 = 0;
				string[] array2 = new string[num];
				for (int i = 0; i < num; i++)
				{
					if (array[i] != null && array[i] != string.Empty)
					{
						array2[num2] = array[i];
						num2++;
					}
				}
				if (num2 != 0)
				{
					if (num2 < num)
					{
						Array.Resize(ref array2, num2);
					}
				}
				else
				{
					array2 = null;
				}
				return array2;
			}
			return null;
		}
		return null;
	}

	private static void smethod_1(string[] string_2)
	{
		string text = string.Empty;
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.Length; i++)
			{
				if (string_2[i] != null && string_2[i] != string.Empty)
				{
					if (text != string.Empty)
					{
						text += "|";
					}
					text += string_2[i];
				}
			}
		}
		Class11.smethod_29(Class47.string_5 + "\\VatphamRac.txt", Class11.smethod_17(text), 1);
	}

	public static void smethod_2()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		if (string_0 == null && !bool_0)
		{
			string_0 = smethod_0();
			bool_0 = true;
		}
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || FormMain.gstruct42_0[num].int_11 <= 0)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_7 = false;
						Class60.smethod_50(FormMain.gstruct42_0[num], "<color=green>KÕt thóc b\u00b8n vËt phÈm trong danh s\u00b8ch !");
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_7)
					{
						return;
					}
					flag = true;
					FormMain.gstruct42_0[num].bool_7 = true;
					Class60.smethod_50(FormMain.gstruct42_0[num], "<color=green>§ang ch¹y b\u00b8n vËt phÈm trong danh s\u00b8ch (tab event - b\u00b8n)...");
				}
				smethod_4(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	public static void smethod_3()
	{
		try
		{
			int int_ = int_0;
			int_0 = 0;
			smethod_4(int_, bool_2: true);
		}
		catch
		{
		}
	}

	private static void smethod_4(int int_5, bool bool_2 = false)
	{
		GStruct42 gStruct = default(GStruct42);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int int_6 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[1];
		byte[] array3 = new byte[60];
		do
		{
			Thread.Sleep(600);
			num = Class71.smethod_3(FormMain.gstruct42_0, int_5);
			if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36)
			{
				break;
			}
			if (string_0 == null || string_0.Length <= 0)
			{
				continue;
			}
			num3++;
			gStruct = FormMain.gstruct42_0[num];
			int num4 = Class69.smethod_2(gStruct);
			if (!bool_2)
			{
				if (gStruct.int_11 <= 0)
				{
					break;
				}
				if (num2 == num4 && num3 < 10)
				{
					continue;
				}
			}
			num3 = 0;
			num2 = num4;
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_6);
			uint num5 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num5 + Class47.gstruct43_13.uint_0, array, 4, ref int_6);
			uint num6 = BitConverter.ToUInt32(array, 0) * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_6);
			uint num7 = BitConverter.ToUInt32(array, 0);
			uint num8 = num7 + num6;
			Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_50.uint_0, array, 4, ref int_6);
			int num9 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_55.uint_0, array, 4, ref int_6);
			int num10 = BitConverter.ToInt32(array, 0);
			int num11 = Class73.smethod_40(gStruct);
			Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_43.uint_0, array, 4, ref int_6);
			int num12 = BitConverter.ToInt32(array, 0);
			if (num9 == 0 || num11 <= 1 || num10 == 0 || num10 == 10 || num10 == 21 || num12 > 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_102.uint_0, array, 4, ref int_6);
			uint num13 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_6);
			uint num14 = BitConverter.ToUInt32(array, 0) + Class47.gstruct43_94.uint_0;
			int num15 = 0;
			uint num16 = 1u;
			while (true)
			{
				if (num16 < Class47.int_1)
				{
					if (num16 % 30u == 0)
					{
						Thread.Sleep(80);
					}
					if (0 >= num4 || num4 > num15)
					{
						uint num17 = num13 + num16 * Class47.gstruct43_103.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_6);
						if (BitConverter.ToInt32(array, 0) == 0)
						{
							Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_104.uint_0, array2, 1, ref int_6);
							if (array2[0] != 0)
							{
								uint num18 = Class69.smethod_0(gStruct, num16);
								if (num18 != 0)
								{
									num15++;
									uint num19 = num14 + num18 * 20;
									Class20.ReadProcessMemory(gStruct.int_130, num19 + Class47.gstruct43_97.uint_0 - 8, array, 4, ref int_6);
									int num20 = BitConverter.ToInt32(array, 0);
									if (num20 == 3)
									{
										Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_104.uint_0, array3, array3.Length, ref int_6);
										string a = Class10.smethod_3(array3);
										if (string_0 == null || string_0.Length == 0)
										{
											break;
										}
										uint num21 = 0u;
										for (int i = 0; i < string_0.Length; i++)
										{
											if (a == string_0[i])
											{
												num21 = num16;
												break;
											}
										}
										int num22 = 0;
										while (0 < num21 && num22 < 25 && !Class11.bool_0)
										{
											if (num22 % 8 == 0)
											{
												Class60.smethod_33(gStruct, (int)num16);
											}
											Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_104.uint_0, array2, 1, ref int_6);
											if (array2[0] == 0)
											{
												break;
											}
											Thread.Sleep(80);
											num22++;
										}
									}
								}
							}
						}
						num16++;
						continue;
					}
				}
				num2 = Class69.smethod_2(gStruct);
				break;
			}
		}
		while (!bool_2);
	}

	public FormBanEvent()
	{
		bool_1 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		smethod_1(string_0);
		bool_1 = false;
	}

	private void FormBanEvent_Load(object sender, EventArgs e)
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
		string_0 = smethod_0();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				method_0(listView1, Class10.smethod_1(string_0[i], 1));
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Close();
		}
	}

	private void method_0(ListView listView_0, string string_2)
	{
		string[] array = new string[1]
		{
			string_2
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

	private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
	{
		if (FormMain.gstruct42_0 == null)
		{
			return;
		}
		string_1 = null;
		int num = 0;
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			if (num > 10 && string_1 != null)
			{
				break;
			}
			Class69.smethod_30(FormMain.gstruct42_0[i], ref string_1);
		}
		comboBoxTenTuiMauHotro.Items.Clear();
		if (string_1 != null)
		{
			Array.Sort(string_1);
			for (int i = 0; i < string_1.Length; i++)
			{
				comboBoxTenTuiMauHotro.Items.Add(Class10.smethod_1(string_1[i], 1));
			}
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices.Count <= 0 || string_0 == null)
		{
			return;
		}
		int index = listView1.SelectedIndices[0];
		int num = string_0.Length;
		string text = listView1.Items[index].SubItems[0].Text;
		int num2 = -1;
		for (int i = 0; i < num; i++)
		{
			if (Class10.smethod_1(string_0[i], 1) == text)
			{
				num2 = i;
				break;
			}
		}
		if (num2 < 0)
		{
			return;
		}
		listView1.Items.RemoveAt(index);
		int num3 = 0;
		for (int i = 0; i < num; i++)
		{
			if (i != num2)
			{
				string_0[num3] = string_0[i];
				num3++;
			}
		}
		if (num3 == 0)
		{
			string_0 = null;
		}
		else
		{
			Array.Resize(ref string_0, num3);
		}
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (string_1 == null)
		{
			return;
		}
		string text = null;
		string text2 = comboBoxTenTuiMauHotro.Text;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (text2 == Class10.smethod_1(string_1[i], 1))
			{
				text = string_1[i];
				break;
			}
		}
		if (text == null)
		{
			return;
		}
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (string_0[i] == text)
				{
					return;
				}
			}
			Array.Resize(ref string_0, string_0.Length + 1);
			string_0[string_0.Length - 1] = text;
		}
		else
		{
			string_0 = new string[1]
			{
				text
			};
		}
		method_0(listView1, Class10.smethod_1(text, 1));
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_1 = false;
		Close();
	}
}
