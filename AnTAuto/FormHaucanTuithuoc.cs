using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormHaucanTuithuoc : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static int int_1 = -1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private int int_6 = -1;

	private static bool bool_1 = false;

	private static GStruct42 gstruct42_0 = default(GStruct42);

	private static string[] string_0 = null;

	private string[] string_1 = new string[2]
	{
		"không",
		"có"
	};

	private IContainer icontainer_0 = null;

	private CheckBox checkBoxCoNhapSoluong;

	private ComboBox comboBoxTenTuiMauHotro;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private Button buttonThem;

	private Button buttonXoa;

	private Button buttonClose;

	private System.Windows.Forms.Timer timer_0;

	private CheckBox checkBoxClickMenu;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	private TextBox textBoxMothuocKhicon;

	private CheckBox checkBoxMoTheoThoigian;

	private CheckBox checkBoxMoTheoSoluong;

	private TextBox textBoxThoigian;

	private Button buttonAppAll;

	private CheckBox checkBoxTrangThai;

	private ColumnHeader columnHeader_5;

	private CheckBox checkBoxTamDung;

	private TextBox textBoxMenu;

	private Label label3;

	private TextBox textBoxSoluongMax;

	private Label label2;

	private CheckBox checkBoxKhongMo;

	public FormHaucanTuithuoc()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool flag = false;
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (0 <= num)
		{
			Class47.smethod_11(FormMain.gstruct42_0[num]);
			flag = true;
		}
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				if (!flag)
				{
					Class47.smethod_11(FormMain.gstruct42_0[i]);
				}
			}
		}
		int_2 = 0;
		int_3 = 0;
		int_1 = -1;
		int_0 = 0;
		bool_0 = false;
	}

	private void FormHaucanTuithuoc_Load(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			Close();
			return;
		}
		gstruct42_0 = FormMain.gstruct42_0[num];
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
		textBoxSoluongMax.Text = FormMain.int_12.ToString();
		checkBoxKhongMo.Checked = (FormMain.int_13 > 0);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
	}

	private void method_0(GStruct30[] gstruct30_0)
	{
		listView1.Items.Clear();
		int_6 = -1;
		if (gstruct30_0 != null && gstruct30_0.Length > 0)
		{
			for (int i = 0; i < gstruct30_0.Length; i++)
			{
				method_2(listView1, gstruct30_0[i]);
			}
			int_6 = 0;
			listView1.Items[int_6].Focused = true;
			listView1.Items[int_6].Selected = true;
		}
	}

	private void method_1(GStruct30 gstruct30_0)
	{
		bool_1 = false;
		comboBoxTenTuiMauHotro.Text = Class10.smethod_1(gstruct30_0.string_0, 1);
		checkBoxMoTheoThoigian.Checked = (gstruct30_0.int_0 > 0);
		textBoxThoigian.Text = gstruct30_0.int_3.ToString();
		checkBoxMoTheoSoluong.Checked = (gstruct30_0.int_4 > 0);
		textBoxMothuocKhicon.Text = gstruct30_0.int_5.ToString();
		checkBoxClickMenu.Checked = (gstruct30_0.int_7 > 0);
		string text = "1,1";
		if (gstruct30_0.int_8 != null)
		{
			text = null;
			for (int i = 0; i < gstruct30_0.int_8.Length; i++)
			{
				if (text != null)
				{
					text += ",";
				}
				text += gstruct30_0.int_8[i].ToString();
			}
		}
		textBoxMenu.Text = text;
		checkBoxCoNhapSoluong.Checked = (gstruct30_0.int_6 > 0);
		checkBoxTrangThai.Checked = (gstruct30_0.int_1 > 0);
		checkBoxTamDung.Checked = (gstruct30_0.int_2 > 0);
		checkBoxTamDung.Enabled = (gstruct30_0.int_1 > 0);
		Thread.Sleep(100);
		bool_1 = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
		else
		{
			if (int_1 == int_0)
			{
				return;
			}
			int_1 = int_0;
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
			if (num >= 0)
			{
				buttonThem.Enabled = true;
				listView1.Enabled = true;
				gstruct42_0 = FormMain.gstruct42_0[num];
				method_0(gstruct42_0.gstruct30_0);
				int_6 = -1;
				if (gstruct42_0.gstruct30_0 != null)
				{
					int_6 = 0;
					method_1(gstruct42_0.gstruct30_0[0]);
				}
			}
			else
			{
				buttonThem.Enabled = false;
				listView1.Enabled = false;
			}
		}
	}

	private void method_2(ListView listView_0, GStruct30 gstruct30_0)
	{
		string text = gstruct30_0.int_5.ToString();
		if (gstruct30_0.int_4 > 0)
		{
			text = "* " + text;
		}
		string text2 = gstruct30_0.int_3.ToString();
		if (gstruct30_0.int_0 > 0)
		{
			text2 = "* " + text2;
		}
		string text3 = "không";
		if (gstruct30_0.int_7 > 0)
		{
			text3 = "có";
		}
		string[] array = new string[6]
		{
			Class10.smethod_1(gstruct30_0.string_0, 1),
			text,
			text2,
			string_1[gstruct30_0.int_6],
			text3,
			gstruct30_0.int_1.ToString()
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

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		int_6 = -1;
		if (listView1.Items == null || listView1.Items.Count == 0)
		{
			return;
		}
		string text = null;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				int_6 = i;
				text = listView1.Items[i].SubItems[0].Text;
				break;
			}
		}
		if (int_6 < 0 || text == null)
		{
			return;
		}
		if (text != comboBoxTenTuiMauHotro.Text)
		{
			comboBoxTenTuiMauHotro.Items.Clear();
			comboBoxTenTuiMauHotro.Items.Add(text);
			comboBoxTenTuiMauHotro.Text = text;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0 || FormMain.gstruct42_0[num].gstruct30_0 == null)
		{
			return;
		}
		for (int i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
		{
			if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) == text)
			{
				method_1(FormMain.gstruct42_0[num].gstruct30_0[i]);
			}
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		string text = comboBoxTenTuiMauHotro.Text;
		comboBoxTenTuiMauHotro.Items.Clear();
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num >= 0 && FormMain.gstruct42_0[num].gstruct30_0 != null && FormMain.gstruct42_0[num].gstruct30_0.Length > 0)
		{
			if (FormMain.gstruct42_0[num].gstruct30_0.Length == 1)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[0].string_0, 1) == text)
				{
					FormMain.gstruct42_0[num].gstruct30_0 = null;
					int_6 = -1;
					listView1.Items.Clear();
				}
				return;
			}
			GStruct30[] array = new GStruct30[FormMain.gstruct42_0[num].gstruct30_0.Length];
			int num2 = 0;
			for (int i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (!(Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) != text))
				{
					continue;
				}
				array[num2].string_0 = FormMain.gstruct42_0[num].gstruct30_0[i].string_0;
				array[num2].int_4 = FormMain.gstruct42_0[num].gstruct30_0[i].int_4;
				array[num2].int_5 = FormMain.gstruct42_0[num].gstruct30_0[i].int_5;
				array[num2].int_0 = FormMain.gstruct42_0[num].gstruct30_0[i].int_0;
				array[num2].int_3 = FormMain.gstruct42_0[num].gstruct30_0[i].int_3;
				array[num2].int_6 = FormMain.gstruct42_0[num].gstruct30_0[i].int_6;
				array[num2].int_7 = FormMain.gstruct42_0[num].gstruct30_0[i].int_7;
				if (FormMain.gstruct42_0[num].gstruct30_0[i].int_8 != null)
				{
					array[num2].int_8 = new int[FormMain.gstruct42_0[num].gstruct30_0[i].int_8.Length];
					for (int j = 0; j < FormMain.gstruct42_0[num].gstruct30_0[i].int_8.Length; j++)
					{
						array[num2].int_8[j] = FormMain.gstruct42_0[num].gstruct30_0[i].int_8[j];
					}
				}
				num2++;
			}
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				if (listView1.Items[i].SubItems[0].Text == text)
				{
					listView1.Items.RemoveAt(i);
					break;
				}
			}
			if (num2 == FormMain.gstruct42_0[num].gstruct30_0.Length)
			{
				int_6 = 0;
				listView1.Items[int_6].Focused = true;
				listView1.Items[int_6].Selected = true;
				method_1(FormMain.gstruct42_0[num].gstruct30_0[int_6]);
				return;
			}
			FormMain.gstruct42_0[num].gstruct30_0 = new GStruct30[num2];
			for (int i = 0; i < num2; i++)
			{
				FormMain.gstruct42_0[num].gstruct30_0[i].string_0 = array[i].string_0;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_4 = array[i].int_4;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_5 = array[i].int_5;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_0 = array[i].int_0;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_3 = array[i].int_3;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_6 = array[i].int_6;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_7 = array[i].int_7;
				if (array[i].int_8 != null)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_8 = new int[array[i].int_8.Length];
					for (int j = 0; j < array[i].int_8.Length; j++)
					{
						FormMain.gstruct42_0[num].gstruct30_0[i].int_8[j] = array[i].int_8[j];
					}
				}
			}
			if (listView1.Items.Count <= int_6)
			{
				int_6--;
			}
			if (0 <= int_6)
			{
				listView1.Items[int_6].Focused = true;
				listView1.Items[int_6].Selected = true;
				method_1(FormMain.gstruct42_0[num].gstruct30_0[int_6]);
			}
		}
		else
		{
			if (listView1.Items.Count > 0)
			{
				listView1.Items.Clear();
			}
			int_6 = -1;
		}
	}

	private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
	{
		string_0 = Class69.smethod_29(gstruct42_0);
		comboBoxTenTuiMauHotro.Items.Clear();
		if (string_0 != null)
		{
			Array.Sort(string_0);
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxTenTuiMauHotro.Items.Add(Class10.smethod_1(string_0[i].Trim(), 1));
			}
		}
	}

	private void checkBoxMoTheoSoluong_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		int i;
		if (FormMain.gstruct42_0[num].gstruct30_0 != null)
		{
			for (i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) == text2)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_4 = Convert.ToByte(checkBoxMoTheoSoluong.Checked);
					text = FormMain.gstruct42_0[num].gstruct30_0[i].int_5.ToString();
					break;
				}
			}
		}
		if (checkBoxMoTheoSoluong.Checked)
		{
			text = "* " + text;
		}
		i = 0;
		while (true)
		{
			if (i < listView1.Items.Count)
			{
				if (listView1.Items[i].SubItems[0].Text == text2)
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		listView1.Items[i].SubItems[1].Text = text;
	}

	private void textBoxMothuocKhicon_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		int i;
		if (FormMain.gstruct42_0[num].gstruct30_0 != null)
		{
			for (i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) == text2)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_5 = Class11.smethod_12(textBoxMothuocKhicon.Text);
					text = FormMain.gstruct42_0[num].gstruct30_0[i].int_5.ToString();
					break;
				}
			}
		}
		if (checkBoxMoTheoSoluong.Checked)
		{
			text = "* " + text;
		}
		i = 0;
		while (true)
		{
			if (i < listView1.Items.Count)
			{
				if (listView1.Items[i].SubItems[0].Text == text2)
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		listView1.Items[i].SubItems[1].Text = text;
	}

	private void checkBoxMoTheoThoigian_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		int i;
		if (FormMain.gstruct42_0[num].gstruct30_0 != null)
		{
			for (i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) == text2)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_0 = Convert.ToByte(checkBoxMoTheoThoigian.Checked);
					text = FormMain.gstruct42_0[num].gstruct30_0[i].int_3.ToString();
					break;
				}
			}
		}
		if (checkBoxMoTheoThoigian.Checked)
		{
			text = "* " + text;
		}
		i = 0;
		while (true)
		{
			if (i < listView1.Items.Count)
			{
				if (listView1.Items[i].SubItems[0].Text == text2)
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		listView1.Items[i].SubItems[2].Text = text;
	}

	private void textBoxThoigian_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		int i;
		if (FormMain.gstruct42_0[num].gstruct30_0 != null)
		{
			for (i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) == text2)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_3 = Class11.smethod_12(textBoxThoigian.Text);
					text = FormMain.gstruct42_0[num].gstruct30_0[i].int_3.ToString();
					break;
				}
			}
		}
		if (checkBoxMoTheoThoigian.Checked)
		{
			text = "* " + text;
		}
		i = 0;
		while (true)
		{
			if (i < listView1.Items.Count)
			{
				if (listView1.Items[i].SubItems[0].Text == text2)
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		listView1.Items[i].SubItems[2].Text = text;
	}

	private void checkBoxClickMenu_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		int i;
		if (FormMain.gstruct42_0[num].gstruct30_0 != null)
		{
			for (i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) == text)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_7 = Convert.ToByte(checkBoxClickMenu.Checked);
					break;
				}
			}
		}
		string text2 = "không";
		if (checkBoxClickMenu.Checked)
		{
			text2 = "có";
		}
		i = 0;
		while (true)
		{
			if (i < listView1.Items.Count)
			{
				if (listView1.Items[i].SubItems[0].Text == text)
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		listView1.Items[i].SubItems[4].Text = text2;
	}

	private void checkBoxCoNhapSoluong_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		int i;
		if (FormMain.gstruct42_0[num].gstruct30_0 != null)
		{
			for (i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) == text)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_6 = Convert.ToByte(checkBoxCoNhapSoluong.Checked);
					break;
				}
			}
		}
		string text2 = string_1[Convert.ToByte(checkBoxCoNhapSoluong.Checked)];
		i = 0;
		while (true)
		{
			if (i < listView1.Items.Count)
			{
				if (listView1.Items[i].SubItems[0].Text == text)
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		listView1.Items[i].SubItems[3].Text = text2;
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_0 == null)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		GStruct30 gstruct30_ = default(GStruct30);
		string text = comboBoxTenTuiMauHotro.Text;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (Class10.smethod_1(string_0[i].Trim(), 1) == text)
			{
				gstruct30_.string_0 = string_0[i].Trim();
				gstruct30_.int_4 = Convert.ToByte(checkBoxMoTheoSoluong.Checked);
				gstruct30_.int_5 = Class11.smethod_12(textBoxMothuocKhicon.Text);
				gstruct30_.int_0 = Convert.ToByte(checkBoxMoTheoThoigian.Checked);
				gstruct30_.int_3 = Class11.smethod_12(textBoxThoigian.Text);
				gstruct30_.int_6 = Convert.ToByte(checkBoxCoNhapSoluong.Checked);
				gstruct30_.int_7 = Convert.ToByte(checkBoxClickMenu.Checked);
				gstruct30_.int_8 = FormMain.smethod_2(textBoxMenu.Text);
				gstruct30_.int_1 = Convert.ToByte(checkBoxTrangThai.Checked);
				gstruct30_.int_2 = Convert.ToByte(checkBoxTamDung.Checked);
				break;
			}
		}
		if (gstruct30_.int_8 == null)
		{
			gstruct30_.int_8 = new int[2]
			{
				1,
				1
			};
		}
		if (FormMain.gstruct42_0[num].gstruct30_0 != null && FormMain.gstruct42_0[num].gstruct30_0.Length != 0)
		{
			GStruct30[] array = new GStruct30[FormMain.gstruct42_0[num].gstruct30_0.Length + 1];
			for (int i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (!(gstruct30_.string_0 == FormMain.gstruct42_0[num].gstruct30_0[i].string_0))
				{
					array[i].string_0 = FormMain.gstruct42_0[num].gstruct30_0[i].string_0;
					array[i].int_4 = FormMain.gstruct42_0[num].gstruct30_0[i].int_4;
					array[i].int_5 = FormMain.gstruct42_0[num].gstruct30_0[i].int_5;
					array[i].int_0 = FormMain.gstruct42_0[num].gstruct30_0[i].int_0;
					array[i].int_3 = FormMain.gstruct42_0[num].gstruct30_0[i].int_3;
					array[i].int_6 = FormMain.gstruct42_0[num].gstruct30_0[i].int_6;
					array[i].int_7 = FormMain.gstruct42_0[num].gstruct30_0[i].int_7;
					if (FormMain.gstruct42_0[num].gstruct30_0[i].int_8 == null)
					{
						FormMain.gstruct42_0[num].gstruct30_0[i].int_8 = new int[2]
						{
							1,
							1
						};
					}
					array[i].int_8 = new int[FormMain.gstruct42_0[num].gstruct30_0[i].int_8.Length];
					for (int j = 0; j < array[i].int_8.Length; j++)
					{
						array[i].int_8[j] = FormMain.gstruct42_0[num].gstruct30_0[i].int_8[j];
					}
					array[i].int_1 = FormMain.gstruct42_0[num].gstruct30_0[i].int_1;
					array[i].int_2 = FormMain.gstruct42_0[num].gstruct30_0[i].int_2;
					continue;
				}
				return;
			}
			int num2 = array.Length - 1;
			array[num2].string_0 = gstruct30_.string_0;
			array[num2].int_4 = gstruct30_.int_4;
			array[num2].int_5 = gstruct30_.int_5;
			array[num2].int_0 = gstruct30_.int_0;
			array[num2].int_3 = gstruct30_.int_3;
			array[num2].int_6 = gstruct30_.int_6;
			array[num2].int_7 = gstruct30_.int_7;
			if (gstruct30_.int_8 == null)
			{
				gstruct30_.int_8 = new int[2]
				{
					1,
					1
				};
			}
			array[num2].int_8 = new int[gstruct30_.int_8.Length];
			for (int j = 0; j < gstruct30_.int_8.Length; j++)
			{
				array[num2].int_8[j] = gstruct30_.int_8[j];
			}
			array[num2].int_1 = gstruct30_.int_1;
			array[num2].int_2 = gstruct30_.int_2;
			FormMain.gstruct42_0[num].gstruct30_0 = new GStruct30[array.Length];
			for (int i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				FormMain.gstruct42_0[num].gstruct30_0[i].string_0 = array[i].string_0;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_4 = array[i].int_4;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_5 = array[i].int_5;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_0 = array[i].int_0;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_3 = array[i].int_3;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_6 = array[i].int_6;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_7 = array[i].int_7;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_8 = new int[array[i].int_8.Length];
				for (int j = 0; j < gstruct30_.int_8.Length; j++)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_8[j] = array[i].int_8[j];
				}
				FormMain.gstruct42_0[num].gstruct30_0[i].int_1 = array[i].int_1;
				FormMain.gstruct42_0[num].gstruct30_0[i].int_2 = array[i].int_2;
			}
		}
		else
		{
			FormMain.gstruct42_0[num].gstruct30_0 = new GStruct30[1];
			FormMain.gstruct42_0[num].gstruct30_0[0].string_0 = gstruct30_.string_0;
			FormMain.gstruct42_0[num].gstruct30_0[0].int_4 = gstruct30_.int_4;
			FormMain.gstruct42_0[num].gstruct30_0[0].int_5 = gstruct30_.int_5;
			FormMain.gstruct42_0[num].gstruct30_0[0].int_0 = gstruct30_.int_0;
			FormMain.gstruct42_0[num].gstruct30_0[0].int_3 = gstruct30_.int_3;
			FormMain.gstruct42_0[num].gstruct30_0[0].int_6 = gstruct30_.int_6;
			FormMain.gstruct42_0[num].gstruct30_0[0].int_7 = gstruct30_.int_7;
			FormMain.gstruct42_0[num].gstruct30_0[0].int_8 = new int[gstruct30_.int_8.Length];
			for (int k = 0; k < gstruct30_.int_8.Length; k++)
			{
				FormMain.gstruct42_0[num].gstruct30_0[0].int_8[k] = gstruct30_.int_8[k];
			}
			FormMain.gstruct42_0[num].gstruct30_0[0].int_1 = gstruct30_.int_1;
			FormMain.gstruct42_0[num].gstruct30_0[0].int_2 = gstruct30_.int_2;
			listView1.Items.Clear();
			int_6 = 0;
		}
		method_2(listView1, gstruct30_);
		if (0 <= int_6 && int_6 < listView1.Items.Count)
		{
			listView1.Items[int_6].Focused = true;
			listView1.Items[int_6].Selected = true;
		}
	}

	private void buttonAppAll_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0 || FormMain.gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			if (i == num)
			{
				continue;
			}
			FormMain.gstruct42_0[i].gstruct30_0 = null;
			if (FormMain.gstruct42_0[num].gstruct30_0 == null || FormMain.gstruct42_0[num].gstruct30_0.Length <= 0)
			{
				continue;
			}
			FormMain.gstruct42_0[i].gstruct30_0 = new GStruct30[FormMain.gstruct42_0[num].gstruct30_0.Length];
			for (int j = 0; j < FormMain.gstruct42_0[num].gstruct30_0.Length; j++)
			{
				FormMain.gstruct42_0[i].gstruct30_0[j].string_0 = FormMain.gstruct42_0[num].gstruct30_0[j].string_0;
				FormMain.gstruct42_0[i].gstruct30_0[j].int_4 = FormMain.gstruct42_0[num].gstruct30_0[j].int_4;
				FormMain.gstruct42_0[i].gstruct30_0[j].int_5 = FormMain.gstruct42_0[num].gstruct30_0[j].int_5;
				FormMain.gstruct42_0[i].gstruct30_0[j].int_0 = FormMain.gstruct42_0[num].gstruct30_0[j].int_0;
				FormMain.gstruct42_0[i].gstruct30_0[j].int_3 = FormMain.gstruct42_0[num].gstruct30_0[j].int_3;
				FormMain.gstruct42_0[i].gstruct30_0[j].int_7 = FormMain.gstruct42_0[num].gstruct30_0[j].int_7;
				if (FormMain.gstruct42_0[num].gstruct30_0[j].int_8 == null)
				{
					FormMain.gstruct42_0[num].gstruct30_0[j].int_8 = new int[2]
					{
						1,
						1
					};
				}
				FormMain.gstruct42_0[i].gstruct30_0[j].int_8 = new int[FormMain.gstruct42_0[num].gstruct30_0[j].int_8.Length];
				for (int k = 0; k < FormMain.gstruct42_0[num].gstruct30_0[j].int_8.Length; k++)
				{
					FormMain.gstruct42_0[i].gstruct30_0[j].int_8[k] = FormMain.gstruct42_0[num].gstruct30_0[j].int_8[k];
				}
				FormMain.gstruct42_0[i].gstruct30_0[j].int_6 = FormMain.gstruct42_0[num].gstruct30_0[j].int_6;
				FormMain.gstruct42_0[i].gstruct30_0[j].int_1 = FormMain.gstruct42_0[num].gstruct30_0[j].int_1;
				FormMain.gstruct42_0[i].gstruct30_0[j].int_2 = FormMain.gstruct42_0[num].gstruct30_0[j].int_2;
				Class47.smethod_11(FormMain.gstruct42_0[i]);
			}
		}
	}

	private void checkBoxTrangThai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		int num2 = Convert.ToByte(checkBoxTrangThai.Checked);
		if (FormMain.gstruct42_0[num].gstruct30_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) == text2)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_1 = num2;
					text = num2.ToString();
					break;
				}
			}
		}
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].SubItems[0].Text == text2)
			{
				listView1.Items[i].SubItems[5].Text = text;
				break;
			}
		}
		checkBoxTamDung.Enabled = (num2 > 0);
	}

	private void checkBoxTamDung_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		if (FormMain.gstruct42_0[num].gstruct30_0 == null)
		{
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < FormMain.gstruct42_0[num].gstruct30_0.Length)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[num2].string_0, 1) == text)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		FormMain.gstruct42_0[num].gstruct30_0[num2].int_2 = Convert.ToByte(checkBoxTamDung.Checked);
	}

	private void textBoxMenu_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		int i;
		if (FormMain.gstruct42_0[num].gstruct30_0 != null)
		{
			for (i = 0; i < FormMain.gstruct42_0[num].gstruct30_0.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].gstruct30_0[i].string_0, 1) == text)
				{
					FormMain.gstruct42_0[num].gstruct30_0[i].int_8 = FormMain.smethod_2(textBoxMenu.Text);
					break;
				}
			}
		}
		string text2 = "không";
		if (checkBoxClickMenu.Checked)
		{
			text2 = "có";
		}
		i = 0;
		while (true)
		{
			if (i < listView1.Items.Count)
			{
				if (listView1.Items[i].SubItems[0].Text == text)
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		listView1.Items[i].SubItems[4].Text = text2;
	}

	private void textBoxSoluongMax_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_12 = Class11.smethod_12(textBoxSoluongMax.Text);
			Class55.smethod_10(Class47.string_0, "SoluongThuocMoilanMo", FormMain.int_12, "", 0);
		}
	}

	private void checkBoxKhongMo_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_13 = Convert.ToByte(checkBoxKhongMo.Checked);
			Class55.smethod_10(Class47.string_0, "PCDKhongMoTui", FormMain.int_13, "", 0);
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormHaucanTuithuoc));
		checkBoxCoNhapSoluong = new System.Windows.Forms.CheckBox();
		comboBoxTenTuiMauHotro = new System.Windows.Forms.ComboBox();
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		columnHeader_5 = new System.Windows.Forms.ColumnHeader();
		buttonThem = new System.Windows.Forms.Button();
		buttonXoa = new System.Windows.Forms.Button();
		buttonClose = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		checkBoxClickMenu = new System.Windows.Forms.CheckBox();
		textBoxMothuocKhicon = new System.Windows.Forms.TextBox();
		checkBoxMoTheoThoigian = new System.Windows.Forms.CheckBox();
		checkBoxMoTheoSoluong = new System.Windows.Forms.CheckBox();
		textBoxThoigian = new System.Windows.Forms.TextBox();
		buttonAppAll = new System.Windows.Forms.Button();
		checkBoxTrangThai = new System.Windows.Forms.CheckBox();
		checkBoxTamDung = new System.Windows.Forms.CheckBox();
		textBoxMenu = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		textBoxSoluongMax = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		checkBoxKhongMo = new System.Windows.Forms.CheckBox();
		SuspendLayout();
		checkBoxCoNhapSoluong.AutoSize = true;
		checkBoxCoNhapSoluong.BackColor = System.Drawing.SystemColors.Control;
		checkBoxCoNhapSoluong.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxCoNhapSoluong.Enabled = false;
		checkBoxCoNhapSoluong.ForeColor = System.Drawing.Color.Black;
		checkBoxCoNhapSoluong.Location = new System.Drawing.Point(11, 319);
		checkBoxCoNhapSoluong.Name = "checkBoxCoNhapSoluong";
		checkBoxCoNhapSoluong.Size = new System.Drawing.Size(110, 17);
		checkBoxCoNhapSoluong.TabIndex = 210;
		checkBoxCoNhapSoluong.Text = "Có nhập số lượng";
		checkBoxCoNhapSoluong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxCoNhapSoluong.UseVisualStyleBackColor = false;
		checkBoxCoNhapSoluong.CheckedChanged += new System.EventHandler(checkBoxCoNhapSoluong_CheckedChanged);
		comboBoxTenTuiMauHotro.FormattingEnabled = true;
		comboBoxTenTuiMauHotro.Location = new System.Drawing.Point(11, 139);
		comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
		comboBoxTenTuiMauHotro.Size = new System.Drawing.Size(229, 21);
		comboBoxTenTuiMauHotro.TabIndex = 217;
		comboBoxTenTuiMauHotro.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenTuiMauHotro_MouseDown);
		listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[6]
		{
			columnHeader_0,
			columnHeader_1,
			columnHeader_2,
			columnHeader_3,
			columnHeader_4,
			columnHeader_5
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(11, 26);
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(453, 108);
		listView1.TabIndex = 218;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		columnHeader_0.Text = "Tên túi máu, vật phẩm";
		columnHeader_0.Width = 130;
		columnHeader_1.Text = "Theo SL";
		columnHeader_1.Width = 65;
		columnHeader_2.Text = "Theo time";
		columnHeader_2.Width = 65;
		columnHeader_3.Text = "Box nhập";
		columnHeader_3.Width = 65;
		columnHeader_4.Text = "Click menu";
		columnHeader_4.Width = 65;
		columnHeader_5.Text = "TT";
		columnHeader_5.Width = 40;
		buttonThem.ForeColor = System.Drawing.Color.DarkBlue;
		buttonThem.Location = new System.Drawing.Point(246, 139);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(148, 23);
		buttonThem.TabIndex = 219;
		buttonThem.Text = "Thêm vào danh sách";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		buttonXoa.Location = new System.Drawing.Point(400, 139);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(64, 23);
		buttonXoa.TabIndex = 220;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		buttonClose.Location = new System.Drawing.Point(368, 311);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(96, 27);
		buttonClose.TabIndex = 222;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		checkBoxClickMenu.AutoSize = true;
		checkBoxClickMenu.BackColor = System.Drawing.SystemColors.Control;
		checkBoxClickMenu.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxClickMenu.ForeColor = System.Drawing.Color.Black;
		checkBoxClickMenu.Location = new System.Drawing.Point(11, 293);
		checkBoxClickMenu.Name = "checkBoxClickMenu";
		checkBoxClickMenu.Size = new System.Drawing.Size(268, 17);
		checkBoxClickMenu.TabIndex = 223;
		checkBoxClickMenu.Text = "Có menu và cần click vào các dòng...(ví dụ: 4,2,1)";
		checkBoxClickMenu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxClickMenu.UseVisualStyleBackColor = false;
		checkBoxClickMenu.CheckedChanged += new System.EventHandler(checkBoxClickMenu_CheckedChanged);
		textBoxMothuocKhicon.ForeColor = System.Drawing.Color.Black;
		textBoxMothuocKhicon.Location = new System.Drawing.Point(259, 189);
		textBoxMothuocKhicon.Name = "textBoxMothuocKhicon";
		textBoxMothuocKhicon.Size = new System.Drawing.Size(48, 21);
		textBoxMothuocKhicon.TabIndex = 226;
		textBoxMothuocKhicon.TextChanged += new System.EventHandler(textBoxMothuocKhicon_TextChanged);
		checkBoxMoTheoThoigian.AutoSize = true;
		checkBoxMoTheoThoigian.BackColor = System.Drawing.SystemColors.Control;
		checkBoxMoTheoThoigian.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxMoTheoThoigian.ForeColor = System.Drawing.Color.Black;
		checkBoxMoTheoThoigian.Location = new System.Drawing.Point(11, 215);
		checkBoxMoTheoThoigian.Name = "checkBoxMoTheoThoigian";
		checkBoxMoTheoThoigian.Size = new System.Drawing.Size(247, 17);
		checkBoxMoTheoThoigian.TabIndex = 227;
		checkBoxMoTheoThoigian.Text = "Sử dụng theo thời gian (ms) (1giây = 1000ms)";
		checkBoxMoTheoThoigian.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxMoTheoThoigian.UseVisualStyleBackColor = false;
		checkBoxMoTheoThoigian.CheckedChanged += new System.EventHandler(checkBoxMoTheoThoigian_CheckedChanged);
		checkBoxMoTheoSoluong.AutoSize = true;
		checkBoxMoTheoSoluong.BackColor = System.Drawing.SystemColors.Control;
		checkBoxMoTheoSoluong.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxMoTheoSoluong.ForeColor = System.Drawing.Color.Black;
		checkBoxMoTheoSoluong.Location = new System.Drawing.Point(11, 190);
		checkBoxMoTheoSoluong.Name = "checkBoxMoTheoSoluong";
		checkBoxMoTheoSoluong.Size = new System.Drawing.Size(242, 17);
		checkBoxMoTheoSoluong.TabIndex = 228;
		checkBoxMoTheoSoluong.Text = "Sử dụng khi số lượng thuốc phục hồi máu còn";
		checkBoxMoTheoSoluong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxMoTheoSoluong.UseVisualStyleBackColor = false;
		checkBoxMoTheoSoluong.CheckedChanged += new System.EventHandler(checkBoxMoTheoSoluong_CheckedChanged);
		textBoxThoigian.ForeColor = System.Drawing.Color.Black;
		textBoxThoigian.Location = new System.Drawing.Point(259, 213);
		textBoxThoigian.Name = "textBoxThoigian";
		textBoxThoigian.Size = new System.Drawing.Size(48, 21);
		textBoxThoigian.TabIndex = 229;
		textBoxThoigian.TextChanged += new System.EventHandler(textBoxThoigian_TextChanged);
		buttonAppAll.ForeColor = System.Drawing.Color.DarkRed;
		buttonAppAll.Location = new System.Drawing.Point(368, 263);
		buttonAppAll.Name = "buttonAppAll";
		buttonAppAll.Size = new System.Drawing.Size(96, 42);
		buttonAppAll.TabIndex = 231;
		buttonAppAll.Text = "Áp dụng cho tất cả ac";
		buttonAppAll.UseVisualStyleBackColor = true;
		buttonAppAll.Click += new System.EventHandler(buttonAppAll_Click);
		checkBoxTrangThai.AutoSize = true;
		checkBoxTrangThai.BackColor = System.Drawing.SystemColors.Control;
		checkBoxTrangThai.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxTrangThai.ForeColor = System.Drawing.Color.Black;
		checkBoxTrangThai.Location = new System.Drawing.Point(11, 241);
		checkBoxTrangThai.Name = "checkBoxTrangThai";
		checkBoxTrangThai.Size = new System.Drawing.Size(327, 17);
		checkBoxTrangThai.TabIndex = 234;
		checkBoxTrangThai.Text = "Sử dụng khi thay đổi bản đồ hoặc thay đổi trạng thái chiến đấu";
		checkBoxTrangThai.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		checkBoxTrangThai.UseVisualStyleBackColor = false;
		checkBoxTrangThai.CheckedChanged += new System.EventHandler(checkBoxTrangThai_CheckedChanged);
		checkBoxTamDung.AutoSize = true;
		checkBoxTamDung.Location = new System.Drawing.Point(27, 263);
		checkBoxTamDung.Name = "checkBoxTamDung";
		checkBoxTamDung.Size = new System.Drawing.Size(203, 17);
		checkBoxTamDung.TabIndex = 237;
		checkBoxTamDung.Text = "Tạm dừng mọi hoạt động khi sử dụng";
		checkBoxTamDung.UseVisualStyleBackColor = true;
		checkBoxTamDung.CheckedChanged += new System.EventHandler(checkBoxTamDung_CheckedChanged);
		textBoxMenu.ForeColor = System.Drawing.Color.Black;
		textBoxMenu.Location = new System.Drawing.Point(285, 291);
		textBoxMenu.Name = "textBoxMenu";
		textBoxMenu.Size = new System.Drawing.Size(47, 21);
		textBoxMenu.TabIndex = 241;
		textBoxMenu.TextChanged += new System.EventHandler(textBoxMenu_TextChanged);
		label3.AutoSize = true;
		label3.ForeColor = System.Drawing.Color.DarkRed;
		label3.Location = new System.Drawing.Point(363, 192);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(108, 13);
		label3.TabIndex = 242;
		label3.Text = "(Số lượng mỗi lần mở)";
		textBoxSoluongMax.ForeColor = System.Drawing.Color.Black;
		textBoxSoluongMax.Location = new System.Drawing.Point(311, 189);
		textBoxSoluongMax.Name = "textBoxSoluongMax";
		textBoxSoluongMax.Size = new System.Drawing.Size(47, 21);
		textBoxSoluongMax.TabIndex = 243;
		textBoxSoluongMax.TextChanged += new System.EventHandler(textBoxSoluongMax_TextChanged);
		label2.AutoSize = true;
		label2.ForeColor = System.Drawing.Color.Red;
		label2.Location = new System.Drawing.Point(8, 166);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(351, 13);
		label2.TabIndex = 245;
		label2.Text = "Xem và kết hợp với phần nhồi thuốc (Điều khiển - Bảng 1) nha các bạn !";
		checkBoxKhongMo.AutoSize = true;
		checkBoxKhongMo.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxKhongMo.Location = new System.Drawing.Point(11, 3);
		checkBoxKhongMo.Name = "checkBoxKhongMo";
		checkBoxKhongMo.Size = new System.Drawing.Size(182, 17);
		checkBoxKhongMo.TabIndex = 246;
		checkBoxKhongMo.Text = "Không mở túi ở nơi phi chiến đấu";
		checkBoxKhongMo.UseVisualStyleBackColor = true;
		checkBoxKhongMo.CheckedChanged += new System.EventHandler(checkBoxKhongMo_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(471, 348);
		base.Controls.Add(checkBoxKhongMo);
		base.Controls.Add(label2);
		base.Controls.Add(textBoxSoluongMax);
		base.Controls.Add(label3);
		base.Controls.Add(textBoxMenu);
		base.Controls.Add(checkBoxClickMenu);
		base.Controls.Add(checkBoxTamDung);
		base.Controls.Add(checkBoxTrangThai);
		base.Controls.Add(buttonAppAll);
		base.Controls.Add(textBoxThoigian);
		base.Controls.Add(checkBoxMoTheoSoluong);
		base.Controls.Add(checkBoxMoTheoThoigian);
		base.Controls.Add(textBoxMothuocKhicon);
		base.Controls.Add(buttonClose);
		base.Controls.Add(buttonXoa);
		base.Controls.Add(buttonThem);
		base.Controls.Add(listView1);
		base.Controls.Add(comboBoxTenTuiMauHotro);
		base.Controls.Add(checkBoxCoNhapSoluong);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormHaucanTuithuoc";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "MO TUI VAT PHAM";
		base.Load += new System.EventHandler(FormHaucanTuithuoc_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
