using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class ThemXoaDanhsach : Form
{
	public static bool bool_0 = false;

	public static int[] int_0 = null;

	public static int[] int_1 = null;

	private GStruct23[] gstruct23_0 = null;

	private GStruct23[] gstruct23_1 = null;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private int int_6 = -1;

	private int int_7 = -1;

	private bool bool_1 = false;

	private IContainer icontainer_0 = null;

	private Button buttonAddAll;

	private Button buttonTrave;

	private Button buttonDemqua;

	private ListView listView2;

	private ColumnHeader columnHeader_0;

	private ListView listView1;

	private ColumnHeader columnHeader_1;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonXoatatca;

	private Button buttonClose;

	private Label labelThongtin;

	private Button buttonStickAll;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private ListView listViewOff;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private Button buttonXoahet;

	private Button buttonXoa;

	private Label label1;

	public ThemXoaDanhsach()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void ThemXoaDanhsach_Load(object sender, EventArgs e)
	{
		if (int_2 >= 0 && int_3 >= 0)
		{
			int num = int_2 - base.Width;
			int num2 = int_3;
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
		bool_1 = false;
		if (Class47.bool_1)
		{
			new Thread(method_0).Start();
		}
		if (FormMain.string_19 != null && FormMain.string_19.Length > 0)
		{
			for (int i = 0; i < FormMain.string_19.Length; i++)
			{
				method_1(listViewOff, FormMain.string_19[i]);
			}
			listViewOff.Items[0].Selected = true;
			listViewOff.Items[0].Focused = true;
		}
		buttonStickAll.Enabled = (Class20.smethod_30(Class11.uint_1, Class11.int_1) != 0);
		timer_0.Interval = 1;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		if (gstruct23_0 != null)
		{
			for (int i = 0; i < gstruct23_0.Length; i++)
			{
				Class20.smethod_32(gstruct23_0[i].int_1);
			}
		}
		if (gstruct23_1 != null)
		{
			for (int i = 0; i < gstruct23_1.Length; i++)
			{
				Class20.smethod_32(gstruct23_1[i].int_1);
			}
		}
		bool_0 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
			return;
		}
		if (bool_1)
		{
			bool_1 = false;
			listView1.Items.Clear();
			listView2.Items.Clear();
			if (gstruct23_0 != null)
			{
				for (int i = 0; i < gstruct23_0.Length; i++)
				{
					method_2(listView1, gstruct23_0[i]);
				}
			}
			if (gstruct23_1 != null)
			{
				for (int i = 0; i < gstruct23_1.Length; i++)
				{
					method_2(listView2, gstruct23_1[i]);
				}
			}
			timer_0.Interval = 300;
		}
		int num = 0;
		int num2 = 0;
		if (gstruct23_0 != null)
		{
			num = gstruct23_0.Length;
		}
		if (gstruct23_1 != null)
		{
			num2 = gstruct23_1.Length;
		}
		string text = "Tổng có " + (num + num2) + " nhân vật (trái: " + num + "; phải: " + num2 + ")";
		if (labelThongtin.Text != text)
		{
			labelThongtin.Text = text;
		}
	}

	private void method_0()
	{
		gstruct23_1 = null;
		if (FormMain.gstruct42_0 != null && FormMain.gstruct42_0.Length > 0)
		{
			gstruct23_1 = new GStruct23[FormMain.gstruct42_0.Length];
			for (int i = 0; i < gstruct23_1.Length; i++)
			{
				gstruct23_1[i].int_0 = FormMain.gstruct42_0[i].int_129;
				gstruct23_1[i].int_1 = Class20.OpenProcess(2035711, bool_0: false, gstruct23_1[i].int_0);
				gstruct23_1[i].string_0 = FormMain.gstruct42_0[i].string_20;
			}
		}
		int[] array = Class20.smethod_24(Class47.string_17);
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					int num = array[i];
					if (gstruct23_1 != null)
					{
						for (int j = 0; j < gstruct23_1.Length; j++)
						{
							if (num == gstruct23_1[j].int_0)
							{
								num = 0;
								break;
							}
						}
					}
					if (num != 0)
					{
						int num2 = Class20.OpenProcess(2035711, bool_0: false, num);
						uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, num2);
						uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, num2) * Class47.gstruct43_15.uint_0;
						uint num5 = num4 + Class20.smethod_30(Class47.gstruct43_14.uint_0, num2);
						string text = Class20.smethod_28(num5 + Class47.gstruct43_16.uint_0, num2, 32);
						if (!(text == string.Empty) && text.Length >= 6)
						{
							smethod_0(ref gstruct23_0, num, num2, text);
						}
					}
				}
				catch
				{
				}
			}
			bool_1 = true;
		}
		else
		{
			bool_1 = true;
		}
	}

	private static void smethod_0(ref GStruct23[] gstruct23_2, int int_8, int int_9, string string_0)
	{
		GStruct23 gStruct = default(GStruct23);
		gStruct.int_0 = int_8;
		gStruct.int_1 = int_9;
		gStruct.string_0 = string_0;
		GStruct23 gStruct2 = gStruct;
		if (gstruct23_2 != null && gstruct23_2.Length != 0)
		{
			GStruct23[] array = new GStruct23[gstruct23_2.Length + 1];
			int num = 0;
			while (true)
			{
				if (num < gstruct23_2.Length)
				{
					array[num] = gstruct23_2[num];
					if (array[num].int_0 == int_8)
					{
						break;
					}
					num++;
					continue;
				}
				array[array.Length - 1] = gStruct2;
				gstruct23_2 = array;
				return;
			}
			gstruct23_2[num] = gStruct2;
		}
		else
		{
			gstruct23_2 = new GStruct23[1]
			{
				gStruct2
			};
		}
	}

	private static void smethod_1(ref GStruct23[] gstruct23_2, int int_8)
	{
		if (gstruct23_2 != null && gstruct23_2.Length != 0)
		{
			int num = 0;
			GStruct23[] array = new GStruct23[gstruct23_2.Length];
			for (int i = 0; i < gstruct23_2.Length; i++)
			{
				if (gstruct23_2[i].int_0 != int_8)
				{
					array[num] = gstruct23_2[i];
					num++;
				}
			}
			if (num != 0)
			{
				GStruct23[] array2 = new GStruct23[num];
				for (int i = 0; i < num; i++)
				{
					array2[i] = array[i];
				}
				gstruct23_2 = array2;
			}
			else
			{
				gstruct23_2 = null;
			}
		}
		else
		{
			gstruct23_2 = null;
		}
	}

	private static int smethod_2(GStruct23[] gstruct23_2, int int_8)
	{
		if (gstruct23_2 != null && gstruct23_2.Length != 0 && int_8 != 0)
		{
			int num = 0;
			while (true)
			{
				if (num < gstruct23_2.Length)
				{
					if (gstruct23_2[num].int_0 == int_8)
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}
		return -1;
	}

	private static int smethod_3(GStruct23[] gstruct23_2, ListView listView_0, int int_8)
	{
		if (gstruct23_2 != null && listView_0.Items != null && int_8 >= 0 && int_8 < listView_0.Items.Count)
		{
			int num = Class11.smethod_12(listView_0.Items[int_8].SubItems[listView_0.Items[int_8].SubItems.Count - 1].Text);
			for (int i = 0; i < gstruct23_2.Length; i++)
			{
				if (num == gstruct23_2[i].int_0)
				{
					return i;
				}
			}
			return -1;
		}
		return -1;
	}

	private static int smethod_4(ListView listView_0, int int_8)
	{
		if (listView_0.Items != null && listView_0.Items.Count != 0)
		{
			int index = listView_0.Items[0].SubItems.Count - 1;
			int num = 0;
			while (true)
			{
				if (num < listView_0.Items.Count)
				{
					if (int_8 == Class11.smethod_12(listView_0.Items[num].SubItems[index].Text))
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}
		return -1;
	}

	private void method_1(ListView listView_0, string string_0)
	{
		string text = "1";
		if (listView_0.Items != null && listView_0.Items.Count > 0)
		{
			text = (listView_0.Items.Count + 1).ToString();
		}
		string[] array = new string[2]
		{
			text,
			Class10.smethod_1(string_0, 1)
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

	private void method_2(ListView listView_0, GStruct23 gstruct23_2)
	{
		string[] array = new string[2]
		{
			Class10.smethod_1(gstruct23_2.string_0, 1),
			gstruct23_2.int_0.ToString()
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
		if (FormMain.int_52 == gstruct23_2.int_0 || FormMain.string_14 == gstruct23_2.string_0 || FormMain.string_14 == Class10.smethod_1(gstruct23_2.string_0, 1))
		{
			listView_0.Items[listView_0.Items.Count - 1].ForeColor = Color.Blue;
		}
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.Items != null)
		{
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				if (listView1.Items[i].Selected)
				{
					int_6 = i;
					return;
				}
			}
		}
		int_6 = -1;
	}

	private void listView2_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView2.Items != null)
		{
			for (int i = 0; i < listView2.Items.Count; i++)
			{
				if (listView2.Items[i].Selected)
				{
					int_7 = i;
					return;
				}
			}
		}
		int_6 = -1;
	}

	private void buttonDemqua_Click(object sender, EventArgs e)
	{
		if (int_6 < 0)
		{
			return;
		}
		int num = smethod_3(gstruct23_0, listView1, int_6);
		if (num >= 0)
		{
			labelThongtin.Text = "Thông tin:...";
			if (Class20.smethod_51(gstruct23_0[num].int_0))
			{
				smethod_0(ref gstruct23_1, gstruct23_0[num].int_0, gstruct23_0[num].int_1, gstruct23_0[num].string_0);
			}
			Class11.smethod_32(ref int_0, gstruct23_0[num].int_0);
			int num2 = smethod_2(gstruct23_1, gstruct23_0[num].int_0);
			smethod_1(ref gstruct23_0, gstruct23_0[num].int_0);
			listView1.Items.RemoveAt(int_6);
			if (num2 >= 0)
			{
				method_2(listView2, gstruct23_1[num2]);
			}
		}
	}

	private void buttonTrave_Click(object sender, EventArgs e)
	{
		if (int_7 < 0)
		{
			return;
		}
		int num = smethod_3(gstruct23_1, listView2, int_7);
		if (num >= 0)
		{
			if (Class20.smethod_51(gstruct23_1[num].int_0))
			{
				smethod_0(ref gstruct23_0, gstruct23_1[num].int_0, gstruct23_1[num].int_1, gstruct23_1[num].string_0);
			}
			Class11.smethod_32(ref int_1, gstruct23_1[num].int_0);
			int num2 = smethod_2(gstruct23_0, gstruct23_1[num].int_0);
			smethod_1(ref gstruct23_1, gstruct23_1[num].int_0);
			listView2.Items.RemoveAt(int_7);
			if (num2 >= 0)
			{
				method_2(listView1, gstruct23_0[num2]);
			}
		}
	}

	private void buttonAddAll_Click(object sender, EventArgs e)
	{
		int[] array = null;
		labelThongtin.Text = "Thông tin: ...";
		while (gstruct23_0 != null && gstruct23_0.Length > 0)
		{
			int num = smethod_4(listView1, gstruct23_0[0].int_0);
			if (0 <= num)
			{
				listView1.Items.RemoveAt(num);
			}
			if (Class20.smethod_51(gstruct23_0[0].int_0))
			{
				smethod_0(ref gstruct23_1, gstruct23_0[0].int_0, gstruct23_0[0].int_1, gstruct23_0[0].string_0);
			}
			Class11.smethod_32(ref array, gstruct23_0[0].int_0);
			int num2 = smethod_2(gstruct23_1, gstruct23_0[0].int_0);
			smethod_1(ref gstruct23_0, gstruct23_0[0].int_0);
			if (num2 >= 0)
			{
				method_2(listView2, gstruct23_1[num2]);
			}
		}
		int_0 = array;
	}

	private void buttonXoatatca_Click(object sender, EventArgs e)
	{
		int[] array = null;
		listView2.Items.Clear();
		while (gstruct23_1 != null && gstruct23_1.Length > 0)
		{
			if (Class20.smethod_51(gstruct23_1[0].int_0))
			{
				smethod_0(ref gstruct23_0, gstruct23_1[0].int_0, gstruct23_1[0].int_1, gstruct23_1[0].string_0);
			}
			Class11.smethod_32(ref array, gstruct23_1[0].int_0);
			int num = smethod_2(gstruct23_0, gstruct23_1[0].int_0);
			smethod_1(ref gstruct23_1, gstruct23_1[0].int_0);
			if (num >= 0)
			{
				method_2(listView1, gstruct23_0[num]);
			}
		}
		int_1 = array;
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	private void buttonStickAll_Click(object sender, EventArgs e)
	{
		FormMain.int_116 = 0;
		FormMain.bool_8 = true;
		bool_0 = false;
		Close();
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		if (listViewOff.Items.Count <= 0)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < listViewOff.Items.Count; i++)
		{
			if (listViewOff.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		string text = listViewOff.Items[num].SubItems[1].Text;
		listViewOff.Items.RemoveAt(num);
		if (FormMain.string_19 != null && FormMain.string_19.Length > 0)
		{
			for (int i = 0; i < FormMain.string_19.Length; i++)
			{
				if (Class10.smethod_1(FormMain.string_19[i], 1) == text)
				{
					text = FormMain.string_19[i];
					Class11.smethod_25(ref FormMain.string_19, text);
					break;
				}
			}
		}
		string text2 = string.Empty;
		if (FormMain.string_19 != null && FormMain.string_19.Length > 0)
		{
			for (int i = 0; i < FormMain.string_19.Length; i++)
			{
				text2 = ((text2 != string.Empty) ? (text2 + "|" + FormMain.string_19[i]) : FormMain.string_19[i]);
			}
			text2 = Class11.smethod_17(text2);
		}
		Class11.smethod_29(Class47.string_9, text2, 1);
		if (listViewOff.Items != null && listViewOff.Items.Count > 0)
		{
			for (int i = 0; i < listViewOff.Items.Count; i++)
			{
				listViewOff.Items[i].SubItems[0].Text = (i + 1).ToString();
			}
			if (listViewOff.Items.Count <= num)
			{
				num--;
			}
			listViewOff.Items[num].Focused = true;
			listViewOff.Items[num].Selected = true;
		}
	}

	private void buttonXoahet_Click(object sender, EventArgs e)
	{
		if (listViewOff.Items != null && listViewOff.Items.Count > 0)
		{
			listViewOff.Items.Clear();
		}
		FormMain.string_19 = null;
		Class11.smethod_20(Class47.string_9);
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(ThemXoaDanhsach));
		buttonAddAll = new System.Windows.Forms.Button();
		buttonTrave = new System.Windows.Forms.Button();
		buttonDemqua = new System.Windows.Forms.Button();
		listView2 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonXoatatca = new System.Windows.Forms.Button();
		buttonClose = new System.Windows.Forms.Button();
		labelThongtin = new System.Windows.Forms.Label();
		buttonStickAll = new System.Windows.Forms.Button();
		tabControl1 = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		tabPage2 = new System.Windows.Forms.TabPage();
		label1 = new System.Windows.Forms.Label();
		buttonXoahet = new System.Windows.Forms.Button();
		listViewOff = new System.Windows.Forms.ListView();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		buttonXoa = new System.Windows.Forms.Button();
		tabControl1.SuspendLayout();
		tabPage1.SuspendLayout();
		tabPage2.SuspendLayout();
		SuspendLayout();
		buttonAddAll.BackColor = System.Drawing.SystemColors.Control;
		buttonAddAll.ForeColor = System.Drawing.Color.Red;
		buttonAddAll.Location = new System.Drawing.Point(4, 283);
		buttonAddAll.Name = "buttonAddAll";
		buttonAddAll.Size = new System.Drawing.Size(79, 26);
		buttonAddAll.TabIndex = 16;
		buttonAddAll.Text = "Thêm tất cả";
		buttonAddAll.UseVisualStyleBackColor = false;
		buttonAddAll.Click += new System.EventHandler(buttonAddAll_Click);
		buttonTrave.BackColor = System.Drawing.SystemColors.Control;
		buttonTrave.ForeColor = System.Drawing.SystemColors.WindowText;
		buttonTrave.Location = new System.Drawing.Point(117, 254);
		buttonTrave.Name = "buttonTrave";
		buttonTrave.Size = new System.Drawing.Size(55, 26);
		buttonTrave.TabIndex = 13;
		buttonTrave.Text = "Xóa 1";
		buttonTrave.UseVisualStyleBackColor = false;
		buttonTrave.Click += new System.EventHandler(buttonTrave_Click);
		buttonDemqua.BackColor = System.Drawing.SystemColors.Control;
		buttonDemqua.ForeColor = System.Drawing.SystemColors.WindowText;
		buttonDemqua.Location = new System.Drawing.Point(4, 254);
		buttonDemqua.Name = "buttonDemqua";
		buttonDemqua.Size = new System.Drawing.Size(107, 26);
		buttonDemqua.TabIndex = 12;
		buttonDemqua.Text = "Thêm 1 ac";
		buttonDemqua.UseVisualStyleBackColor = false;
		buttonDemqua.Click += new System.EventHandler(buttonDemqua_Click);
		listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			columnHeader_0
		});
		listView2.FullRowSelect = true;
		listView2.GridLines = true;
		listView2.HideSelection = false;
		listView2.Location = new System.Drawing.Point(116, 22);
		listView2.MultiSelect = false;
		listView2.Name = "listView2";
		listView2.Size = new System.Drawing.Size(113, 226);
		listView2.TabIndex = 10;
		listView2.UseCompatibleStateImageBehavior = false;
		listView2.View = System.Windows.Forms.View.Details;
		listView2.MouseUp += new System.Windows.Forms.MouseEventHandler(listView2_MouseUp);
		columnHeader_0.Text = "Nhân vật";
		columnHeader_0.Width = 105;
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			columnHeader_1
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(2, 22);
		listView1.MultiSelect = false;
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(112, 226);
		listView1.TabIndex = 9;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		columnHeader_1.Text = "Nhân vật";
		columnHeader_1.Width = 105;
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonXoatatca.BackColor = System.Drawing.SystemColors.Control;
		buttonXoatatca.ForeColor = System.Drawing.SystemColors.WindowText;
		buttonXoatatca.Location = new System.Drawing.Point(174, 254);
		buttonXoatatca.Name = "buttonXoatatca";
		buttonXoatatca.Size = new System.Drawing.Size(56, 26);
		buttonXoatatca.TabIndex = 17;
		buttonXoatatca.Text = "Xóa hết";
		buttonXoatatca.UseVisualStyleBackColor = false;
		buttonXoatatca.Click += new System.EventHandler(buttonXoatatca_Click);
		buttonClose.BackColor = System.Drawing.SystemColors.Control;
		buttonClose.ForeColor = System.Drawing.SystemColors.WindowText;
		buttonClose.Location = new System.Drawing.Point(174, 283);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(56, 26);
		buttonClose.TabIndex = 18;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = false;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		labelThongtin.AutoSize = true;
		labelThongtin.ForeColor = System.Drawing.Color.Black;
		labelThongtin.Location = new System.Drawing.Point(4, 4);
		labelThongtin.Name = "labelThongtin";
		labelThongtin.Size = new System.Drawing.Size(52, 13);
		labelThongtin.TabIndex = 19;
		labelThongtin.Text = "Thông tin";
		buttonStickAll.BackColor = System.Drawing.SystemColors.Control;
		buttonStickAll.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		buttonStickAll.ForeColor = System.Drawing.Color.DarkRed;
		buttonStickAll.Location = new System.Drawing.Point(89, 283);
		buttonStickAll.Name = "buttonStickAll";
		buttonStickAll.Size = new System.Drawing.Size(83, 26);
		buttonStickAll.TabIndex = 158;
		buttonStickAll.Text = "Stick tất cả";
		buttonStickAll.UseVisualStyleBackColor = false;
		buttonStickAll.Click += new System.EventHandler(buttonStickAll_Click);
		tabControl1.Controls.Add(tabPage1);
		tabControl1.Controls.Add(tabPage2);
		tabControl1.Location = new System.Drawing.Point(1, 0);
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size(239, 337);
		tabControl1.TabIndex = 159;
		tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
		tabPage1.Controls.Add(buttonStickAll);
		tabPage1.Controls.Add(buttonClose);
		tabPage1.Controls.Add(buttonAddAll);
		tabPage1.Controls.Add(labelThongtin);
		tabPage1.Controls.Add(buttonDemqua);
		tabPage1.Controls.Add(buttonTrave);
		tabPage1.Controls.Add(buttonXoatatca);
		tabPage1.Controls.Add(listView1);
		tabPage1.Controls.Add(listView2);
		tabPage1.Location = new System.Drawing.Point(4, 22);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding(3);
		tabPage1.Size = new System.Drawing.Size(231, 311);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "Ac đang online";
		tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
		tabPage2.Controls.Add(label1);
		tabPage2.Controls.Add(buttonXoahet);
		tabPage2.Controls.Add(listViewOff);
		tabPage2.Controls.Add(buttonXoa);
		tabPage2.Location = new System.Drawing.Point(4, 22);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding(3);
		tabPage2.Size = new System.Drawing.Size(231, 311);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "Ac offline hoặc bị diss";
		label1.AutoSize = true;
		label1.ForeColor = System.Drawing.Color.Black;
		label1.Location = new System.Drawing.Point(4, 4);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(202, 13);
		label1.TabIndex = 160;
		label1.Text = "Các ac bị diss hoặc thoát được lưu ở đây";
		buttonXoahet.BackColor = System.Drawing.SystemColors.Control;
		buttonXoahet.Location = new System.Drawing.Point(124, 279);
		buttonXoahet.Name = "buttonXoahet";
		buttonXoahet.Size = new System.Drawing.Size(106, 26);
		buttonXoahet.TabIndex = 161;
		buttonXoahet.Text = "Xóa hết";
		buttonXoahet.UseVisualStyleBackColor = false;
		buttonXoahet.Click += new System.EventHandler(buttonXoahet_Click);
		listViewOff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
		{
			columnHeader_2,
			columnHeader_3
		});
		listViewOff.FullRowSelect = true;
		listViewOff.GridLines = true;
		listViewOff.HideSelection = false;
		listViewOff.Location = new System.Drawing.Point(2, 25);
		listViewOff.MultiSelect = false;
		listViewOff.Name = "listViewOff";
		listViewOff.Size = new System.Drawing.Size(228, 246);
		listViewOff.TabIndex = 160;
		listViewOff.UseCompatibleStateImageBehavior = false;
		listViewOff.View = System.Windows.Forms.View.Details;
		columnHeader_2.Text = "STT";
		columnHeader_2.Width = 40;
		columnHeader_3.Text = "Nhân vật";
		columnHeader_3.Width = 165;
		buttonXoa.BackColor = System.Drawing.SystemColors.Control;
		buttonXoa.Location = new System.Drawing.Point(6, 279);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(112, 26);
		buttonXoa.TabIndex = 160;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = false;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(237, 335);
		base.Controls.Add(tabControl1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "ThemXoaDanhsach";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "DANH SACH";
		base.Load += new System.EventHandler(ThemXoaDanhsach_Load);
		tabControl1.ResumeLayout(performLayout: false);
		tabPage1.ResumeLayout(performLayout: false);
		tabPage1.PerformLayout();
		tabPage2.ResumeLayout(performLayout: false);
		tabPage2.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
