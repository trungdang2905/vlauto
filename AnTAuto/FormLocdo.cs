using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormLocdo : Form
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static int int_4 = 0;

	private string[] string_0 = new string[5]
	{
		"Kim",
		"Mộc",
		"Thủy",
		"Hỏa",
		"Thổ"
	};

	private string[] string_1 = new string[2]
	{
		"Giữ đồ theo thuộc tính",
		"Bán tất cả"
	};

	public static int int_5 = Class55.smethod_3("TocdoNhatdoExx", 0, "80");

	private Color color_0 = Color.MidnightBlue;

	private static long long_0 = 0L;

	private static string[] string_2 = null;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Button buttonClose;

	private CheckBox checkBoxBando;

	private CheckBox checkBoxGiudoTheoCap;

	private ComboBox comboBoxCap;

	private CheckBox checkBoxGiudoTheoHe;

	private ComboBox comboBoxHe;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private CheckBox checkBoxGiudoTheoThuoctinh;

	private TextBox textBoxMin;

	private Button buttonSua;

	private TextBox textBoxName;

	private Button buttonApdungAll;

	private CheckBox checkBoxGiudoTim;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Button buttonXoa;

	private Button buttonThem;

	private ComboBox comboBoxTenVatpham;

	private ListView listView2;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	private Label labelVidu;

	private Button buttonAppdungAll2;

	private CheckBox checkBoxNhatTrongthanh;

	private ComboBox comboBoxBando;

	private CheckBox checkBoxNhatTheoThuoctinh;

	private TabPage tabPage3;

	private Label label1;

	private CheckBox checkBoxKhongNhatdoTim;

	private CheckBox checkBoxThoahet;

	private CheckBox checkBoxGiuTrangsuc;

	private CheckBox checkBoxNgocBoi;

	private CheckBox checkBoxDaychuyen;

	private Label label2;

	private TextBox textBoxTocdoNhat;

	private TextBox textBoxDongDC;

	private TextBox textBoxDongNB;

	private TextBox textBoxDongNhan;

	public FormLocdo()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool flag = false;
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
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
		Class55.smethod_10(Class47.string_0, "FormLocdo", tabControl1.SelectedIndex, "", 0);
		int_0 = 0;
		int_1 = 0;
		bool_0 = false;
	}

	private void FormLocdo_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		if (int_0 >= 0 && int_1 >= 0)
		{
			int num = int_0 - base.Width;
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
		tabControl1.SelectedIndex = Class55.smethod_3("FormLocdo", 0, "0");
		base.TopMost = true;
		for (int i = 0; i < string_0.Length; i++)
		{
			comboBoxHe.Items.Add(string_0[i]);
		}
		for (int i = 0; i <= 10; i++)
		{
			comboBoxCap.Items.Add(i.ToString());
		}
		for (int i = 0; i < string_1.Length; i++)
		{
			comboBoxBando.Items.Add(string_1[i]);
		}
		textBoxTocdoNhat.Text = int_5.ToString();
		int num3 = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (0 > num3)
		{
			GStruct33 gStruct = default(GStruct33);
			gStruct.string_0 = "Chưa chọn ac, bấm Lọc sau khi chọn 1 ac nhé.";
			GStruct33 gstruct33_ = gStruct;
			method_0(gstruct33_);
			tabControl1.Enabled = false;
			buttonApdungAll.Enabled = false;
			base.Text = "Loc do * Chua chon ac nao";
		}
		else
		{
			GStruct42 gStruct2 = FormMain.gstruct42_0[num3];
			checkBoxBando.Checked = (gStruct2.int_48[0] > 0);
			comboBoxBando.Text = string_1[gStruct2.int_48[1]];
			checkBoxGiudoTheoCap.Checked = (gStruct2.int_49[0] > 0);
			checkBoxGiudoTheoHe.Checked = (gStruct2.int_50[0] > 0);
			checkBoxGiudoTim.Checked = (gStruct2.int_51 > 0);
			checkBoxNhatTrongthanh.Checked = (gStruct2.int_41 > 0);
			checkBoxNhatTheoThuoctinh.Checked = (gStruct2.int_42 > 0);
			checkBoxGiudoTheoThuoctinh.Checked = (gStruct2.int_52 > 0);
			checkBoxThoahet.Checked = (gStruct2.int_43 > 0);
			checkBoxThoahet.Enabled = (gStruct2.int_52 > 0);
			checkBoxKhongNhatdoTim.Checked = (gStruct2.int_44 > 0);
			checkBoxGiuTrangsuc.Checked = (gStruct2.int_45[0] > 0);
			textBoxDongNhan.Text = gStruct2.int_45[1].ToString();
			checkBoxNgocBoi.Checked = (gStruct2.int_47[0] > 0);
			textBoxDongNB.Text = gStruct2.int_47[1].ToString();
			checkBoxDaychuyen.Checked = (gStruct2.int_46[0] > 0);
			textBoxDongDC.Text = gStruct2.int_46[1].ToString();
			comboBoxHe.Text = string_0[gStruct2.int_50[1]];
			comboBoxCap.Text = gStruct2.int_49[1].ToString();
			if (gStruct2.gstruct33_0 != null)
			{
				for (int i = 0; i < gStruct2.gstruct33_0.Length; i++)
				{
					method_0(gStruct2.gstruct33_0[i]);
				}
			}
			if (gStruct2.string_3 != null)
			{
				for (int i = 0; i < gStruct2.string_3.Length; i++)
				{
					method_1(Class10.smethod_1(gStruct2.string_3[i], 1));
				}
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (long_0 > 0L && Class11.smethod_23(long_0) > 300L)
			{
				buttonApdungAll.Enabled = true;
				buttonAppdungAll2.Enabled = true;
				long_0 = 0L;
			}
		}
		else
		{
			Close();
		}
	}

	private void method_0(GStruct33 gstruct33_0)
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
		string[] array = new string[3]
		{
			num.ToString(),
			gstruct33_0.string_0,
			gstruct33_0.int_2.ToString()
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

	private void method_1(string string_3)
	{
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
		string[] array = new string[2]
		{
			num.ToString(),
			string_3
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

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxBando_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_48[0] = Convert.ToByte(checkBoxBando.Checked);
			}
		}
	}

	private void comboBoxBando_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxBando.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_1.Length)
			{
				if (text == string_1[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		FormMain.gstruct42_0[num].int_48[1] = num2;
	}

	private void checkBoxGiudoTheoCap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_49[0] = Convert.ToByte(checkBoxGiudoTheoCap.Checked);
			}
		}
	}

	private void checkBoxGiudoTheoHe_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_50[0] = Convert.ToByte(checkBoxGiudoTheoHe.Checked);
			}
		}
	}

	private void checkBoxGiudoTheoThuoctinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_52 = Convert.ToByte(checkBoxGiudoTheoThuoctinh.Checked);
				checkBoxThoahet.Enabled = checkBoxGiudoTheoThuoctinh.Checked;
			}
		}
	}

	private void comboBoxCap_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_49[1] = Class11.smethod_12(comboBoxCap.Text);
			}
		}
	}

	private void comboBoxHe_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxHe.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (string_0[num2] == text)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		FormMain.gstruct42_0[num].int_50[1] = num2;
	}

	private void checkBoxNhatTrongthanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_41 = Convert.ToByte(checkBoxNhatTrongthanh.Checked);
			}
		}
	}

	private void checkBoxNhatTheoThuoctinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_42 = Convert.ToByte(checkBoxNhatTheoThuoctinh.Checked);
			}
		}
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
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
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
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
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
		listView1.Items[num2].SubItems[2].Text = textBoxMin.Text;
	}

	private void checkBoxGiudoTim_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_51 = Convert.ToByte(checkBoxGiudoTim.Checked);
			}
		}
	}

	private void checkBoxKhongNhatdoTim_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_44 = Convert.ToByte(checkBoxKhongNhatdoTim.Checked);
			}
		}
	}

	private void checkBoxThoahet_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_43 = Convert.ToByte(checkBoxThoahet.Checked);
			}
		}
	}

	private void checkBoxGiuTrangsuc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_45[0] = Convert.ToByte(checkBoxGiuTrangsuc.Checked);
			}
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		string text = null;
		int i;
		try
		{
			for (i = 0; i < listView2.Items.Count; i++)
			{
				if (listView2.Items[i].Selected)
				{
					text = listView2.Items[i].SubItems[1].Text;
					listView2.Items.RemoveAt(i);
					break;
				}
			}
		}
		catch
		{
		}
		if (text == null || FormMain.gstruct42_0[num].string_3 == null)
		{
			return;
		}
		i = 0;
		while (true)
		{
			if (i < FormMain.gstruct42_0[num].string_3.Length)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].string_3[i], 1) == text)
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		Class11.smethod_25(ref FormMain.gstruct42_0[num].string_3, FormMain.gstruct42_0[num].string_3[i]);
		FormMain.gstruct42_0[num].bool_16 = true;
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (string_2 == null || num < 0)
		{
			return;
		}
		string text = null;
		string text2 = comboBoxTenVatpham.Text;
		for (int i = 0; i < string_2.Length; i++)
		{
			if (text2 == Class10.smethod_1(string_2[i], 1))
			{
				text = string_2[i].Trim();
				break;
			}
		}
		if (text == null)
		{
			text = Class10.smethod_2(text2);
		}
		if (FormMain.gstruct42_0[num].string_3 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0[num].string_3.Length; i++)
			{
				if (FormMain.gstruct42_0[num].string_3[i] == text)
				{
					return;
				}
			}
		}
		method_1(Class10.smethod_1(text, 1));
		Class11.smethod_24(ref FormMain.gstruct42_0[num].string_3, text);
		FormMain.gstruct42_0[num].bool_16 = true;
	}

	private void listView2_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.Items != null && listView1.Items.Count != 0)
		{
			string text = null;
			try
			{
				for (int i = 0; i < listView2.Items.Count; i++)
				{
					if (listView2.Items[i].Selected)
					{
						text = listView2.Items[i].SubItems[1].Text;
						break;
					}
				}
			}
			catch
			{
			}
			if (text != null && text != comboBoxTenVatpham.Text)
			{
				comboBoxTenVatpham.Items.Clear();
				comboBoxTenVatpham.Items.Add(text);
				comboBoxTenVatpham.Text = text;
			}
		}
	}

	private void comboBoxTenVatpham_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		string_2 = Class69.smethod_29(FormMain.gstruct42_0[num]);
		comboBoxTenVatpham.Items.Clear();
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.Length; i++)
			{
				comboBoxTenVatpham.Items.Add(Class10.smethod_1(string_2[i], 1));
			}
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		if (FormMain.gstruct42_0 == null)
		{
			return;
		}
		buttonApdungAll.Enabled = false;
		int num = Class71.smethod_3(FormMain.gstruct42_0, FormLocdo.int_4);
		if (num < 0)
		{
			int int_ = Convert.ToByte(checkBoxKhongNhatdoTim.Checked);
			int int_2 = Convert.ToByte(checkBoxNhatTrongthanh.Checked);
			int int_3 = Convert.ToByte(checkBoxNhatTheoThuoctinh.Checked);
			int[] array = new int[2]
			{
				Convert.ToByte(checkBoxGiuTrangsuc.Checked),
				Class11.smethod_12(textBoxDongNhan.Text)
			};
			int[] array2 = new int[2]
			{
				Convert.ToByte(checkBoxDaychuyen.Checked),
				Class11.smethod_12(textBoxDongDC.Text)
			};
			int[] array3 = new int[2]
			{
				Convert.ToByte(checkBoxNgocBoi.Checked),
				Class11.smethod_12(textBoxDongNB.Text)
			};
			int num2 = Convert.ToByte(checkBoxBando.Checked);
			int num3 = 0;
			for (int i = 0; i < string_1.Length; i++)
			{
				if (string_1[i] == comboBoxBando.Text)
				{
					num3 = i;
					break;
				}
			}
			int num4 = Convert.ToByte(checkBoxGiudoTheoHe.Checked);
			int num5 = 0;
			for (int i = 0; i < string_0.Length; i++)
			{
				if (string_0[i] == comboBoxHe.Text)
				{
					num5 = i;
					break;
				}
			}
			int num6 = Convert.ToByte(checkBoxGiudoTheoCap.Checked);
			int num7 = Class11.smethod_12(comboBoxCap.Text);
			int int_4 = Convert.ToByte(checkBoxGiudoTim.Checked);
			int int_5 = Convert.ToByte(checkBoxGiudoTheoThuoctinh.Checked);
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				FormMain.gstruct42_0[i].int_49 = new int[2]
				{
					num6,
					num7
				};
				FormMain.gstruct42_0[i].int_50 = new int[2]
				{
					num4,
					num5
				};
				FormMain.gstruct42_0[i].int_51 = int_4;
				FormMain.gstruct42_0[i].int_52 = int_5;
				if (FormMain.gstruct42_0[i].gstruct33_0 == null)
				{
					FormMain.gstruct42_0[i].gstruct33_0 = Class47.smethod_1();
				}
				try
				{
					for (int j = 0; j < FormMain.gstruct42_0[i].gstruct33_0.Length; j++)
					{
						FormMain.gstruct42_0[i].gstruct33_0[j].int_0 = Convert.ToByte(listView1.Items[i].Checked);
						FormMain.gstruct42_0[i].gstruct33_0[j].int_2 = Class11.smethod_12(listView1.Items[i].SubItems[2].Text);
					}
				}
				catch
				{
				}
				FormMain.gstruct42_0[i].int_48 = new int[2]
				{
					num2,
					num3
				};
				FormMain.gstruct42_0[i].int_41 = int_2;
				FormMain.gstruct42_0[i].int_42 = int_3;
				FormMain.gstruct42_0[i].int_44 = int_;
				for (int k = 0; k < 2; k++)
				{
					FormMain.gstruct42_0[i].int_45[k] = array[k];
					FormMain.gstruct42_0[i].int_46[k] = array2[k];
					FormMain.gstruct42_0[i].int_47[k] = array3[k];
				}
			}
		}
		else
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				if (num != i)
				{
					FormMain.gstruct42_0[i].int_49 = new int[2]
					{
						FormMain.gstruct42_0[num].int_49[0],
						FormMain.gstruct42_0[num].int_49[1]
					};
					FormMain.gstruct42_0[i].int_50 = new int[2]
					{
						FormMain.gstruct42_0[num].int_50[0],
						FormMain.gstruct42_0[num].int_50[1]
					};
					FormMain.gstruct42_0[i].int_51 = FormMain.gstruct42_0[num].int_51;
					FormMain.gstruct42_0[i].int_52 = FormMain.gstruct42_0[num].int_52;
					if (FormMain.gstruct42_0[i].gstruct33_0 == null)
					{
						FormMain.gstruct42_0[i].gstruct33_0 = Class47.smethod_1();
					}
					for (int j = 0; j < FormMain.gstruct42_0[i].gstruct33_0.Length; j++)
					{
						FormMain.gstruct42_0[i].gstruct33_0[j].int_0 = FormMain.gstruct42_0[num].gstruct33_0[j].int_0;
						FormMain.gstruct42_0[i].gstruct33_0[j].int_2 = FormMain.gstruct42_0[num].gstruct33_0[j].int_2;
					}
					FormMain.gstruct42_0[i].int_41 = FormMain.gstruct42_0[num].int_41;
					FormMain.gstruct42_0[i].int_42 = FormMain.gstruct42_0[num].int_42;
					FormMain.gstruct42_0[i].int_48 = new int[2]
					{
						FormMain.gstruct42_0[num].int_48[0],
						FormMain.gstruct42_0[num].int_48[1]
					};
					FormMain.gstruct42_0[i].int_38 = FormMain.gstruct42_0[num].int_38;
					FormMain.gstruct42_0[i].int_63 = FormMain.gstruct42_0[num].int_63;
					FormMain.gstruct42_0[i].int_44 = FormMain.gstruct42_0[num].int_44;
					for (int k = 0; k < 2; k++)
					{
						FormMain.gstruct42_0[i].int_45[k] = FormMain.gstruct42_0[num].int_45[k];
						FormMain.gstruct42_0[i].int_46[k] = FormMain.gstruct42_0[num].int_46[k];
						FormMain.gstruct42_0[i].int_47[k] = FormMain.gstruct42_0[num].int_47[k];
					}
				}
			}
		}
		textBoxName.Text = "Đã áp dụng cho tất cả ac đang online.";
		long_0 = Class11.smethod_22();
	}

	private void buttonAppdungAll2_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		buttonAppdungAll2.Enabled = false;
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				if (num == i)
				{
					continue;
				}
				FormMain.gstruct42_0[i].string_3 = null;
				if (FormMain.gstruct42_0[num].string_3 != null)
				{
					FormMain.gstruct42_0[i].string_3 = new string[FormMain.gstruct42_0[num].string_3.Length];
					for (int j = 0; j < FormMain.gstruct42_0[num].string_3.Length; j++)
					{
						FormMain.gstruct42_0[i].string_3[j] = FormMain.gstruct42_0[num].string_3[j];
					}
				}
				FormMain.gstruct42_0[i].bool_16 = true;
			}
		}
		long_0 = Class11.smethod_22();
	}

	private void checkBoxNgocBoi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_47[0] = Convert.ToByte(checkBoxNgocBoi.Checked);
			}
		}
	}

	private void checkBoxDaychuyen_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_46[0] = Convert.ToByte(checkBoxDaychuyen.Checked);
			}
		}
	}

	private void textBoxTocdoNhat_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_5 = Class11.smethod_12(textBoxTocdoNhat.Text);
			if (int_5 < 0)
			{
				int_5 = 0;
			}
			Class55.smethod_10(Class47.string_0, "TocdoNhatdoExx", int_5, "", 0);
		}
	}

	private void textBoxDongNhan_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_45[1] = Class11.smethod_12(textBoxDongNhan.Text);
			}
		}
	}

	private void textBoxDongNB_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_47[1] = Class11.smethod_12(textBoxDongNB.Text);
			}
		}
	}

	private void textBoxDongDC_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_46[1] = Class11.smethod_12(textBoxDongDC.Text);
			}
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormLocdo));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonClose = new System.Windows.Forms.Button();
		checkBoxBando = new System.Windows.Forms.CheckBox();
		checkBoxGiudoTheoCap = new System.Windows.Forms.CheckBox();
		comboBoxCap = new System.Windows.Forms.ComboBox();
		checkBoxGiudoTheoHe = new System.Windows.Forms.CheckBox();
		comboBoxHe = new System.Windows.Forms.ComboBox();
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		checkBoxGiudoTheoThuoctinh = new System.Windows.Forms.CheckBox();
		textBoxMin = new System.Windows.Forms.TextBox();
		buttonSua = new System.Windows.Forms.Button();
		textBoxName = new System.Windows.Forms.TextBox();
		buttonApdungAll = new System.Windows.Forms.Button();
		checkBoxGiudoTim = new System.Windows.Forms.CheckBox();
		tabControl1 = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		textBoxDongDC = new System.Windows.Forms.TextBox();
		textBoxDongNB = new System.Windows.Forms.TextBox();
		checkBoxNgocBoi = new System.Windows.Forms.CheckBox();
		textBoxDongNhan = new System.Windows.Forms.TextBox();
		checkBoxDaychuyen = new System.Windows.Forms.CheckBox();
		checkBoxGiuTrangsuc = new System.Windows.Forms.CheckBox();
		checkBoxThoahet = new System.Windows.Forms.CheckBox();
		tabPage2 = new System.Windows.Forms.TabPage();
		buttonAppdungAll2 = new System.Windows.Forms.Button();
		listView2 = new System.Windows.Forms.ListView();
		columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		buttonThem = new System.Windows.Forms.Button();
		comboBoxTenVatpham = new System.Windows.Forms.ComboBox();
		buttonXoa = new System.Windows.Forms.Button();
		labelVidu = new System.Windows.Forms.Label();
		tabPage3 = new System.Windows.Forms.TabPage();
		label1 = new System.Windows.Forms.Label();
		checkBoxNhatTrongthanh = new System.Windows.Forms.CheckBox();
		comboBoxBando = new System.Windows.Forms.ComboBox();
		checkBoxNhatTheoThuoctinh = new System.Windows.Forms.CheckBox();
		checkBoxKhongNhatdoTim = new System.Windows.Forms.CheckBox();
		label2 = new System.Windows.Forms.Label();
		textBoxTocdoNhat = new System.Windows.Forms.TextBox();
		tabControl1.SuspendLayout();
		tabPage1.SuspendLayout();
		tabPage2.SuspendLayout();
		tabPage3.SuspendLayout();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonClose.Location = new System.Drawing.Point(280, 485);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(60, 22);
		buttonClose.TabIndex = 8;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		checkBoxBando.ForeColor = System.Drawing.Color.Black;
		checkBoxBando.Location = new System.Drawing.Point(152, 2);
		checkBoxBando.Name = "checkBoxBando";
		checkBoxBando.Size = new System.Drawing.Size(188, 32);
		checkBoxBando.TabIndex = 9;
		checkBoxBando.Text = "Bán đồ khi về thành (chỉ áp dụng khi check vào Train - bảng 1)";
		checkBoxBando.UseVisualStyleBackColor = true;
		checkBoxBando.CheckedChanged += new System.EventHandler(checkBoxBando_CheckedChanged);
		checkBoxGiudoTheoCap.AutoSize = true;
		checkBoxGiudoTheoCap.Location = new System.Drawing.Point(161, 28);
		checkBoxGiudoTheoCap.Name = "checkBoxGiudoTheoCap";
		checkBoxGiudoTheoCap.Size = new System.Drawing.Size(103, 17);
		checkBoxGiudoTheoCap.TabIndex = 32;
		checkBoxGiudoTheoCap.Text = "Giữ đồ theo cấp";
		checkBoxGiudoTheoCap.UseVisualStyleBackColor = true;
		checkBoxGiudoTheoCap.CheckedChanged += new System.EventHandler(checkBoxGiudoTheoCap_CheckedChanged);
		comboBoxCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxCap.FormattingEnabled = true;
		comboBoxCap.Location = new System.Drawing.Point(276, 26);
		comboBoxCap.Name = "comboBoxCap";
		comboBoxCap.Size = new System.Drawing.Size(51, 21);
		comboBoxCap.TabIndex = 30;
		comboBoxCap.SelectedIndexChanged += new System.EventHandler(comboBoxCap_SelectedIndexChanged);
		checkBoxGiudoTheoHe.AutoSize = true;
		checkBoxGiudoTheoHe.Location = new System.Drawing.Point(161, 51);
		checkBoxGiudoTheoHe.Name = "checkBoxGiudoTheoHe";
		checkBoxGiudoTheoHe.Size = new System.Drawing.Size(97, 17);
		checkBoxGiudoTheoHe.TabIndex = 33;
		checkBoxGiudoTheoHe.Text = "Giữ đồ theo hệ";
		checkBoxGiudoTheoHe.UseVisualStyleBackColor = true;
		checkBoxGiudoTheoHe.CheckedChanged += new System.EventHandler(checkBoxGiudoTheoHe_CheckedChanged);
		comboBoxHe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxHe.FormattingEnabled = true;
		comboBoxHe.Location = new System.Drawing.Point(276, 50);
		comboBoxHe.Name = "comboBoxHe";
		comboBoxHe.Size = new System.Drawing.Size(50, 21);
		comboBoxHe.TabIndex = 31;
		comboBoxHe.SelectedIndexChanged += new System.EventHandler(comboBoxHe_SelectedIndexChanged);
		listView1.CheckBoxes = true;
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3]
		{
			columnHeader_0,
			columnHeader_1,
			columnHeader_2
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(3, 118);
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(326, 239);
		listView1.TabIndex = 34;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		columnHeader_0.Text = "No";
		columnHeader_0.Width = 45;
		columnHeader_1.Text = "Thuộc tính";
		columnHeader_1.Width = 225;
		columnHeader_2.Text = "Min";
		columnHeader_2.Width = 35;
		checkBoxGiudoTheoThuoctinh.AutoSize = true;
		checkBoxGiudoTheoThuoctinh.ForeColor = System.Drawing.Color.DarkBlue;
		checkBoxGiudoTheoThuoctinh.Location = new System.Drawing.Point(3, 73);
		checkBoxGiudoTheoThuoctinh.Name = "checkBoxGiudoTheoThuoctinh";
		checkBoxGiudoTheoThuoctinh.Size = new System.Drawing.Size(157, 17);
		checkBoxGiudoTheoThuoctinh.TabIndex = 35;
		checkBoxGiudoTheoThuoctinh.Text = "Giữ đồ theo thuộc tính dưới";
		checkBoxGiudoTheoThuoctinh.UseVisualStyleBackColor = true;
		checkBoxGiudoTheoThuoctinh.CheckedChanged += new System.EventHandler(checkBoxGiudoTheoThuoctinh_CheckedChanged);
		textBoxMin.Location = new System.Drawing.Point(249, 361);
		textBoxMin.Name = "textBoxMin";
		textBoxMin.Size = new System.Drawing.Size(33, 20);
		textBoxMin.TabIndex = 38;
		buttonSua.Location = new System.Drawing.Point(284, 360);
		buttonSua.Name = "buttonSua";
		buttonSua.Size = new System.Drawing.Size(45, 21);
		buttonSua.TabIndex = 39;
		buttonSua.Text = "Sửa";
		buttonSua.UseVisualStyleBackColor = true;
		buttonSua.Click += new System.EventHandler(buttonSua_Click);
		textBoxName.ForeColor = System.Drawing.Color.Blue;
		textBoxName.Location = new System.Drawing.Point(6, 361);
		textBoxName.Name = "textBoxName";
		textBoxName.ReadOnly = true;
		textBoxName.Size = new System.Drawing.Size(240, 20);
		textBoxName.TabIndex = 40;
		buttonApdungAll.ForeColor = System.Drawing.Color.Black;
		buttonApdungAll.Location = new System.Drawing.Point(132, 485);
		buttonApdungAll.Name = "buttonApdungAll";
		buttonApdungAll.Size = new System.Drawing.Size(142, 22);
		buttonApdungAll.TabIndex = 41;
		buttonApdungAll.Text = "Áp dụng cho tất cả ac";
		buttonApdungAll.UseVisualStyleBackColor = true;
		buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		checkBoxGiudoTim.AutoSize = true;
		checkBoxGiudoTim.Location = new System.Drawing.Point(161, 3);
		checkBoxGiudoTim.Name = "checkBoxGiudoTim";
		checkBoxGiudoTim.Size = new System.Drawing.Size(76, 17);
		checkBoxGiudoTim.TabIndex = 42;
		checkBoxGiudoTim.Text = "Giữ đồ tím";
		checkBoxGiudoTim.UseVisualStyleBackColor = true;
		checkBoxGiudoTim.CheckedChanged += new System.EventHandler(checkBoxGiudoTim_CheckedChanged);
		tabControl1.Controls.Add(tabPage1);
		tabControl1.Controls.Add(tabPage2);
		tabControl1.Controls.Add(tabPage3);
		tabControl1.Location = new System.Drawing.Point(0, 71);
		tabControl1.Margin = new System.Windows.Forms.Padding(0);
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size(340, 410);
		tabControl1.TabIndex = 43;
		tabPage1.Controls.Add(textBoxDongDC);
		tabPage1.Controls.Add(textBoxDongNB);
		tabPage1.Controls.Add(checkBoxNgocBoi);
		tabPage1.Controls.Add(textBoxDongNhan);
		tabPage1.Controls.Add(checkBoxDaychuyen);
		tabPage1.Controls.Add(checkBoxGiuTrangsuc);
		tabPage1.Controls.Add(checkBoxThoahet);
		tabPage1.Controls.Add(textBoxName);
		tabPage1.Controls.Add(checkBoxGiudoTim);
		tabPage1.Controls.Add(checkBoxGiudoTheoThuoctinh);
		tabPage1.Controls.Add(checkBoxGiudoTheoCap);
		tabPage1.Controls.Add(comboBoxCap);
		tabPage1.Controls.Add(textBoxMin);
		tabPage1.Controls.Add(checkBoxGiudoTheoHe);
		tabPage1.Controls.Add(comboBoxHe);
		tabPage1.Controls.Add(buttonSua);
		tabPage1.Controls.Add(listView1);
		tabPage1.Location = new System.Drawing.Point(4, 22);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding(3);
		tabPage1.Size = new System.Drawing.Size(332, 384);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "Bảng thuộc tính ";
		tabPage1.UseVisualStyleBackColor = true;
		textBoxDongDC.Location = new System.Drawing.Point(120, 49);
		textBoxDongDC.Name = "textBoxDongDC";
		textBoxDongDC.Size = new System.Drawing.Size(27, 20);
		textBoxDongDC.TabIndex = 48;
		textBoxDongDC.TextChanged += new System.EventHandler(textBoxDongDC_TextChanged);
		textBoxDongNB.Location = new System.Drawing.Point(120, 26);
		textBoxDongNB.Name = "textBoxDongNB";
		textBoxDongNB.Size = new System.Drawing.Size(27, 20);
		textBoxDongNB.TabIndex = 47;
		textBoxDongNB.TextChanged += new System.EventHandler(textBoxDongNB_TextChanged);
		checkBoxNgocBoi.AutoSize = true;
		checkBoxNgocBoi.Location = new System.Drawing.Point(3, 26);
		checkBoxNgocBoi.Name = "checkBoxNgocBoi";
		checkBoxNgocBoi.Size = new System.Drawing.Size(104, 17);
		checkBoxNgocBoi.TabIndex = 46;
		checkBoxNgocBoi.Text = "Giữ ngọc bội, >=";
		checkBoxNgocBoi.UseVisualStyleBackColor = true;
		checkBoxNgocBoi.CheckedChanged += new System.EventHandler(checkBoxNgocBoi_CheckedChanged);
		textBoxDongNhan.Location = new System.Drawing.Point(120, 3);
		textBoxDongNhan.Name = "textBoxDongNhan";
		textBoxDongNhan.Size = new System.Drawing.Size(27, 20);
		textBoxDongNhan.TabIndex = 46;
		textBoxDongNhan.TextChanged += new System.EventHandler(textBoxDongNhan_TextChanged);
		checkBoxDaychuyen.AutoSize = true;
		checkBoxDaychuyen.Location = new System.Drawing.Point(4, 49);
		checkBoxDaychuyen.Name = "checkBoxDaychuyen";
		checkBoxDaychuyen.Size = new System.Drawing.Size(118, 17);
		checkBoxDaychuyen.TabIndex = 45;
		checkBoxDaychuyen.Text = "Giữ dây chuyền, >=";
		checkBoxDaychuyen.UseVisualStyleBackColor = true;
		checkBoxDaychuyen.CheckedChanged += new System.EventHandler(checkBoxDaychuyen_CheckedChanged);
		checkBoxGiuTrangsuc.AutoSize = true;
		checkBoxGiuTrangsuc.Location = new System.Drawing.Point(3, 3);
		checkBoxGiuTrangsuc.Name = "checkBoxGiuTrangsuc";
		checkBoxGiuTrangsuc.Size = new System.Drawing.Size(114, 17);
		checkBoxGiuTrangsuc.TabIndex = 44;
		checkBoxGiuTrangsuc.Text = "Giữ nhẫn, dòng >=";
		checkBoxGiuTrangsuc.UseVisualStyleBackColor = true;
		checkBoxGiuTrangsuc.CheckedChanged += new System.EventHandler(checkBoxGiuTrangsuc_CheckedChanged);
		checkBoxThoahet.AutoSize = true;
		checkBoxThoahet.ForeColor = System.Drawing.Color.DarkBlue;
		checkBoxThoahet.Location = new System.Drawing.Point(3, 96);
		checkBoxThoahet.Name = "checkBoxThoahet";
		checkBoxThoahet.Size = new System.Drawing.Size(269, 17);
		checkBoxThoahet.TabIndex = 43;
		checkBoxThoahet.Text = "Thỏa mãn đúng hết điều kiện thuộc tính thì mới giữ";
		checkBoxThoahet.UseVisualStyleBackColor = true;
		checkBoxThoahet.CheckedChanged += new System.EventHandler(checkBoxThoahet_CheckedChanged);
		tabPage2.Controls.Add(buttonAppdungAll2);
		tabPage2.Controls.Add(listView2);
		tabPage2.Controls.Add(buttonThem);
		tabPage2.Controls.Add(comboBoxTenVatpham);
		tabPage2.Controls.Add(buttonXoa);
		tabPage2.Controls.Add(labelVidu);
		tabPage2.Location = new System.Drawing.Point(4, 22);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding(3);
		tabPage2.Size = new System.Drawing.Size(332, 384);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "Vật phẩm không nhặt";
		tabPage2.UseVisualStyleBackColor = true;
		buttonAppdungAll2.ForeColor = System.Drawing.Color.Black;
		buttonAppdungAll2.Location = new System.Drawing.Point(91, 348);
		buttonAppdungAll2.Name = "buttonAppdungAll2";
		buttonAppdungAll2.Size = new System.Drawing.Size(140, 26);
		buttonAppdungAll2.TabIndex = 44;
		buttonAppdungAll2.Text = "Áp dụng cho tất cả ac";
		buttonAppdungAll2.UseVisualStyleBackColor = true;
		buttonAppdungAll2.Click += new System.EventHandler(buttonAppdungAll2_Click);
		listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
		{
			columnHeader_3,
			columnHeader_4
		});
		listView2.FullRowSelect = true;
		listView2.GridLines = true;
		listView2.HideSelection = false;
		listView2.Location = new System.Drawing.Point(1, 1);
		listView2.Name = "listView2";
		listView2.Size = new System.Drawing.Size(330, 261);
		listView2.TabIndex = 35;
		listView2.UseCompatibleStateImageBehavior = false;
		listView2.View = System.Windows.Forms.View.Details;
		listView2.MouseUp += new System.Windows.Forms.MouseEventHandler(listView2_MouseUp);
		columnHeader_3.Text = "No";
		columnHeader_3.Width = 45;
		columnHeader_4.Text = "Tên vật phẩm";
		columnHeader_4.Width = 260;
		buttonThem.Location = new System.Drawing.Point(220, 268);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(52, 21);
		buttonThem.TabIndex = 40;
		buttonThem.Text = "Thêm";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		comboBoxTenVatpham.FormattingEnabled = true;
		comboBoxTenVatpham.Location = new System.Drawing.Point(3, 268);
		comboBoxTenVatpham.Name = "comboBoxTenVatpham";
		comboBoxTenVatpham.Size = new System.Drawing.Size(211, 21);
		comboBoxTenVatpham.TabIndex = 36;
		comboBoxTenVatpham.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenVatpham_MouseDown);
		buttonXoa.Location = new System.Drawing.Point(274, 268);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(52, 21);
		buttonXoa.TabIndex = 41;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		labelVidu.AutoSize = true;
		labelVidu.Location = new System.Drawing.Point(3, 296);
		labelVidu.Name = "labelVidu";
		labelVidu.Size = new System.Drawing.Size(323, 39);
		labelVidu.TabIndex = 42;
		labelVidu.Text = "Tên vật phẩm không nhặt có thể ghi rút gọn.\r\nVí dụ ghi: Phúc Duyên\r\nThì sẽ không nhặt tất cả các loại Phúc Duyên (đại, trung và tiểu)...";
		tabPage3.Controls.Add(label1);
		tabPage3.Location = new System.Drawing.Point(4, 22);
		tabPage3.Name = "tabPage3";
		tabPage3.Padding = new System.Windows.Forms.Padding(3);
		tabPage3.Size = new System.Drawing.Size(332, 384);
		tabPage3.TabIndex = 2;
		tabPage3.Text = "Lưu ý chung";
		tabPage3.UseVisualStyleBackColor = true;
		label1.Location = new System.Drawing.Point(3, 3);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(326, 161);
		label1.TabIndex = 0;
		//label1.Text = componentResourceManager.GetString("label1.Text");
		checkBoxNhatTrongthanh.AutoSize = true;
		checkBoxNhatTrongthanh.ForeColor = System.Drawing.Color.Black;
		checkBoxNhatTrongthanh.Location = new System.Drawing.Point(3, 3);
		checkBoxNhatTrongthanh.Name = "checkBoxNhatTrongthanh";
		checkBoxNhatTrongthanh.Size = new System.Drawing.Size(106, 17);
		checkBoxNhatTrongthanh.TabIndex = 45;
		checkBoxNhatTrongthanh.Text = "Nhặt trong thành";
		checkBoxNhatTrongthanh.UseVisualStyleBackColor = true;
		checkBoxNhatTrongthanh.CheckedChanged += new System.EventHandler(checkBoxNhatTrongthanh_CheckedChanged);
		comboBoxBando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxBando.ForeColor = System.Drawing.Color.Black;
		comboBoxBando.FormattingEnabled = true;
		comboBoxBando.Location = new System.Drawing.Point(200, 37);
		comboBoxBando.Name = "comboBoxBando";
		comboBoxBando.Size = new System.Drawing.Size(140, 21);
		comboBoxBando.TabIndex = 46;
		comboBoxBando.SelectedIndexChanged += new System.EventHandler(comboBoxBando_SelectedIndexChanged);
		checkBoxNhatTheoThuoctinh.AutoSize = true;
		checkBoxNhatTheoThuoctinh.ForeColor = System.Drawing.Color.DarkBlue;
		checkBoxNhatTheoThuoctinh.Location = new System.Drawing.Point(3, 49);
		checkBoxNhatTheoThuoctinh.Name = "checkBoxNhatTheoThuoctinh";
		checkBoxNhatTheoThuoctinh.Size = new System.Drawing.Size(184, 17);
		checkBoxNhatTheoThuoctinh.TabIndex = 47;
		checkBoxNhatTheoThuoctinh.Text = "Nhặt theo bảng thuộc tính ở dưới";
		checkBoxNhatTheoThuoctinh.UseVisualStyleBackColor = true;
		checkBoxNhatTheoThuoctinh.CheckedChanged += new System.EventHandler(checkBoxNhatTheoThuoctinh_CheckedChanged);
		checkBoxKhongNhatdoTim.AutoSize = true;
		checkBoxKhongNhatdoTim.ForeColor = System.Drawing.Color.Black;
		checkBoxKhongNhatdoTim.Location = new System.Drawing.Point(3, 26);
		checkBoxKhongNhatdoTim.Name = "checkBoxKhongNhatdoTim";
		checkBoxKhongNhatdoTim.Size = new System.Drawing.Size(115, 17);
		checkBoxKhongNhatdoTim.TabIndex = 48;
		checkBoxKhongNhatdoTim.Text = "Không nhặt đồ tím";
		checkBoxKhongNhatdoTim.UseVisualStyleBackColor = true;
		checkBoxKhongNhatdoTim.CheckedChanged += new System.EventHandler(checkBoxKhongNhatdoTim_CheckedChanged);
		label2.AutoSize = true;
		label2.ForeColor = System.Drawing.Color.DarkRed;
		label2.Location = new System.Drawing.Point(3, 489);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(88, 13);
		label2.TabIndex = 50;
		label2.Text = "Tốc độ nhặt (ms)";
		textBoxTocdoNhat.ForeColor = System.Drawing.Color.Black;
		textBoxTocdoNhat.Location = new System.Drawing.Point(93, 486);
		textBoxTocdoNhat.Name = "textBoxTocdoNhat";
		textBoxTocdoNhat.Size = new System.Drawing.Size(33, 20);
		textBoxTocdoNhat.TabIndex = 47;
		textBoxTocdoNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		textBoxTocdoNhat.TextChanged += new System.EventHandler(textBoxTocdoNhat_TextChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(345, 511);
		base.Controls.Add(textBoxTocdoNhat);
		base.Controls.Add(checkBoxNhatTheoThuoctinh);
		base.Controls.Add(buttonApdungAll);
		base.Controls.Add(comboBoxBando);
		base.Controls.Add(label2);
		base.Controls.Add(checkBoxBando);
		base.Controls.Add(checkBoxKhongNhatdoTim);
		base.Controls.Add(checkBoxNhatTrongthanh);
		base.Controls.Add(tabControl1);
		base.Controls.Add(buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormLocdo";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "NHAT DO";
		base.Load += new System.EventHandler(FormLocdo_Load);
		tabControl1.ResumeLayout(performLayout: false);
		tabPage1.ResumeLayout(performLayout: false);
		tabPage1.PerformLayout();
		tabPage2.ResumeLayout(performLayout: false);
		tabPage2.PerformLayout();
		tabPage3.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
