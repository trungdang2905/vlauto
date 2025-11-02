using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormLogin : Form
{
	public static GStruct0[] gstruct0_0 = null;

	public static string[] string_0 = null;

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static int int_4 = Class55.smethod_3("flagTuDangNhap", 0, "0");

	public static int int_5 = Class55.smethod_3("TimerOpenGame", 0, "4000");

	public static int int_6 = Class55.smethod_3("TimeDangNhap", 0, "16000");

	public static int int_7 = Class55.smethod_3("flagThuNho", 0, "1");

	public static int int_8 = Class55.smethod_3("fLog1ac", 0, "0");

	public static int int_9 = Class55.smethod_3("flagFileKhac", 0, "0");

	public static string string_1 = Class55.smethod_6("PathFileKhac", 0);

	public static string string_2 = Class47.string_4 + "\\Login";

	public static string string_3 = string_2 + "\\Login.txt";

	public static string[] string_4 = new string[1]
	{
		"JX Tình Huynh Đệ|Huynh Đệ|Tương Phùng"
	};

	private static bool bool_3 = false;

	private static bool bool_4 = false;

	private int int_10 = 0;

	private static uint uint_0 = 0u;

	private bool bool_5 = false;

	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private System.Windows.Forms.Timer timer_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private Button buttonXoaTK;

	private Button buttonSuaTK;

	private Label label4;

	private TextBox textBoxTaiKhoan;

	private ComboBox comboBoxNhanVat;

	private Label labelTaiKhoan;

	private TextBox textBoxPassword;

	private Label labelPassword;

	private ComboBox comboBoxServer;

	private ComboBox comboBoxPhanda;

	private Button buttonLen;

	private Button buttonXuong;

	private TextBox textBoxStatus;

	private ColumnHeader columnHeader_4;

	private Button buttonLuuDanhsach;

	private Label labelThem;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private Label label1;

	private TextBox textBoxTimeOpenGame;

	private TextBox textBoxTimerDangNhap;

	private Label label2;

	private Button buttonThoatGameAll;

	private Button buttonPhimHuongdan;

	private GroupBox groupBox1;

	private Label labelStatus;

	private CheckBox checkBoxThuNho;

	private Button buttonLogin;

	private TabPage tabPage3;

	private CheckBox checkBoxTuDangNhap;

	private Button buttonMoGame;

	private TextBox textBoxTimer;

	private Button buttonStopLogin;

	private LinkLabel linkLabelCheckAll;

	private Button buttonGameHu;

	private TabPage tabPage4;

	private CheckBox checkBoxLog1ac;

	private CheckBox checkBoxFileKhac;

	private Button buttonBrowseGameKhac;

	private TextBox textBoxFile;

	public FormLogin()
	{
		bool_0 = true;
		string_0 = null;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		Hide();
		Class18.smethod_1();
		int_0 = 0;
		int_1 = 0;
		bool_0 = false;
	}

	private void FormLogin_Load(object sender, EventArgs e)
	{
		bool_3 = false;
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
		string text = string.Empty;
		string text2 = string.Empty;
		for (int i = 0; i < string_4.Length; i++)
		{
			string text3 = string_4[i];
			if (text3 == null || text3 == string.Empty)
			{
				continue;
			}
			string[] array = text3.Split('|');
			comboBoxPhanda.Items.Add(array[0]);
			if ((string_4.Length <= 1 || i != 0) && text2 == string.Empty && array.Length > 1)
			{
				text = array[0];
				text2 = array[1];
				for (int j = 1; j < array.Length; j++)
				{
					comboBoxServer.Items.Add(array[j]);
				}
			}
		}
		comboBoxPhanda.Text = text;
		comboBoxServer.Text = text2;
		for (int i = 0; i < 6; i++)
		{
			comboBoxNhanVat.Items.Add(i + 1);
		}
		comboBoxNhanVat.Text = "1";
		if (gstruct0_0 != null)
		{
			for (int i = 0; i < gstruct0_0.Length; i++)
			{
				bool bool_ = gstruct0_0[i].int_1 > 0 && !Class20.smethod_52(gstruct0_0[i].process_0);
				method_1(gstruct0_0[i], bool_);
			}
		}
		checkBoxThuNho.Checked = (int_7 > 0);
		textBoxTimeOpenGame.Text = int_5.ToString();
		textBoxTimerDangNhap.Text = int_6.ToString();
		checkBoxTuDangNhap.Checked = (int_4 > 0);
		checkBoxLog1ac.Checked = (int_8 > 0);
		checkBoxFileKhac.Checked = (int_9 > 0);
		textBoxFile.Text = string_1;
		Thread.Sleep(100);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		base.Text = "LOGIN: CAP NHAT DANH SACH";
		bool_3 = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (string_0 != null && string_0.Length > 0)
			{
				textBoxStatus.Text = string_0[0];
				Class11.smethod_25(ref string_0, string_0[0]);
			}
			if (int_10 != Class40.int_2)
			{
				textBoxTimer.Text = "Đang chờ: " + Class40.int_2;
				int_10 = Class40.int_2;
			}
			if (Class40.int_1 != null && Class40.int_1.Length > 0)
			{
				int num = Class40.int_1[0];
				Class11.smethod_33(ref Class40.int_1, num);
				if (0 <= num && num < listView1.Items.Count)
				{
					string text = gstruct0_0[num].string_0;
					string text2 = gstruct0_0[num].string_4;
					if (text2 != null && text2 != string.Empty)
					{
						text = Class10.smethod_1(text2, 1);
					}
					listView1.Items[num].SubItems[1].Text = text;
					if (!Class20.smethod_52(gstruct0_0[num].process_0))
					{
						listView1.Items[num].ForeColor = Color.Blue;
					}
					else
					{
						listView1.Items[num].ForeColor = Color.Black;
					}
					listView1.Items[num].Checked = false;
				}
			}
			if (gstruct0_0 == null)
			{
				return;
			}
			for (int i = 0; i < gstruct0_0.Length; i++)
			{
				if (Class20.smethod_52(gstruct0_0[i].process_0))
				{
					if (listView1.Items[i].ForeColor != Color.Black)
					{
						listView1.Items[i].ForeColor = Color.Black;
						gstruct0_0[i].int_1 = 0;
					}
				}
				else if (listView1.Items[i].ForeColor != Color.Blue)
				{
					listView1.Items[i].ForeColor = Color.Blue;
				}
			}
		}
		else
		{
			Close();
		}
	}

	public static string smethod_0(string string_5)
	{
		if (string_5 != null && !(string_5 == ""))
		{
			string text = "";
			char[] array = string_5.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				text += (char)(255 - array[i]);
			}
			return text;
		}
		return "";
	}

	private string method_0(string string_5)
	{
		if (string_5 == string.Empty)
		{
			return string.Empty;
		}
		string text = Class11.smethod_16(string_5);
		byte b = (byte)text.Length;
		if (b > 3 && text[b - 1] == '\u0003')
		{
			return string_5;
		}
		return Class11.smethod_17((char)string_5.Length + string_5 + '\u0003');
	}

	public static int smethod_1(ref GStruct0[] gstruct0_1, GStruct0 gstruct0_2)
	{
		if (gstruct0_1 != null && gstruct0_1.Length != 0)
		{
			GStruct0[] array = new GStruct0[gstruct0_1.Length + 1];
			for (int i = 0; i < gstruct0_1.Length; i++)
			{
				GStruct0 gStruct = gstruct0_1[i];
				if (!(gStruct.string_3 == gstruct0_2.string_3) || !(gStruct.string_2 == gstruct0_2.string_2) || !(gStruct.string_0 == gstruct0_2.string_0) || gStruct.int_4 != gstruct0_2.int_4)
				{
					array[i] = gstruct0_1[i];
					continue;
				}
				return -1;
			}
			int num = array.Length - 1;
			array[num] = gstruct0_2;
			gstruct0_1 = array;
			return num;
		}
		gstruct0_1 = new GStruct0[1]
		{
			gstruct0_2
		};
		return 0;
	}

	public static bool smethod_2(ref GStruct0[] gstruct0_1, GStruct0 gstruct0_2)
	{
		if (gstruct0_1 != null && gstruct0_1.Length != 0)
		{
			GStruct0[] array = new GStruct0[gstruct0_1.Length];
			int num = 0;
			for (int i = 0; i < gstruct0_1.Length; i++)
			{
				GStruct0 gStruct = gstruct0_1[i];
				if (!(gStruct.string_3 == gstruct0_2.string_3) || !(gStruct.string_2 == gstruct0_2.string_2) || !(gStruct.string_0 == gstruct0_2.string_0) || gStruct.int_4 != gstruct0_2.int_4)
				{
					array[num] = gstruct0_1[i];
					num++;
				}
			}
			if (num == 0)
			{
				gstruct0_1 = null;
				return true;
			}
			if (num != gstruct0_1.Length)
			{
				GStruct0[] array2 = new GStruct0[num];
				for (int i = 0; i < num; i++)
				{
					array2[i] = array[i];
				}
				gstruct0_1 = array2;
				return true;
			}
			return false;
		}
		gstruct0_1 = null;
		return true;
	}

	public static int smethod_3(GStruct0[] gstruct0_1, GStruct0 gstruct0_2)
	{
		if (gstruct0_1 != null && gstruct0_1.Length > 0)
		{
			for (int i = 0; i < gstruct0_1.Length; i++)
			{
				GStruct0 gStruct = gstruct0_1[i];
				if (gStruct.string_3 == gstruct0_2.string_3 && gStruct.string_2 == gstruct0_2.string_2 && gStruct.string_0 == gstruct0_2.string_0 && gStruct.int_4 == gstruct0_2.int_4)
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void method_1(GStruct0 gstruct0_1, bool bool_6 = false)
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
		string[] array = new string[6]
		{
			num.ToString(),
			Class10.smethod_1(gstruct0_1.string_4, 1),
			gstruct0_1.string_0,
			gstruct0_1.int_4.ToString(),
			gstruct0_1.string_3,
			gstruct0_1.string_2
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
		if (bool_6)
		{
			listView1.Items[listView1.Items.Count - 1].ForeColor = Color.Blue;
		}
	}

	private void method_2(ListView listView_0, int int_11 = 0)
	{
		if (listView_0.Items == null)
		{
			return;
		}
		int count = listView_0.Items.Count;
		if (count != 0)
		{
			if (int_11 >= count)
			{
				int_11 = count - 1;
			}
			listView_0.TopItem = listView_0.Items[int_11];
			listView_0.Items[int_11].Focused = true;
			listView_0.Items[int_11].Selected = true;
		}
	}

	private void buttonXoaTK_Click(object sender, EventArgs e)
	{
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		GStruct0 gStruct = default(GStruct0);
		gStruct.string_0 = listView1.Items[num].SubItems[2].Text;
		gStruct.int_4 = Class11.smethod_12(listView1.Items[num].SubItems[3].Text);
		gStruct.string_3 = listView1.Items[num].SubItems[4].Text;
		gStruct.string_2 = listView1.Items[num].SubItems[5].Text;
		GStruct0 gstruct0_ = gStruct;
		int num2 = smethod_3(gstruct0_0, gstruct0_);
		if (num2 < 0)
		{
			return;
		}
		smethod_2(ref gstruct0_0, gstruct0_);
		listView1.Items.RemoveAt(num);
		if (listView1.Items.Count != 0)
		{
			if (num > listView1.Items.Count - 1)
			{
				num = listView1.Items.Count - 1;
			}
			listView1.Items[num].Focused = true;
			listView1.Items[num].Selected = true;
			for (int i = num; i < listView1.Items.Count; i++)
			{
				listView1.Items[i].SubItems[0].Text = i.ToString();
			}
			textBoxStatus.Text = "Đã xóa tài khoản " + gstruct0_.string_0;
			bool_2 = true;
		}
		else
		{
			bool_2 = true;
		}
	}

	private void buttonSuaTK_Click(object sender, EventArgs e)
	{
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		GStruct0 gStruct = default(GStruct0);
		gStruct.string_0 = listView1.Items[num].SubItems[2].Text;
		gStruct.int_4 = Class11.smethod_12(listView1.Items[num].SubItems[3].Text);
		gStruct.string_3 = listView1.Items[num].SubItems[4].Text;
		gStruct.string_2 = listView1.Items[num].SubItems[5].Text;
		GStruct0 gstruct0_ = gStruct;
		int num2 = smethod_3(gstruct0_0, gstruct0_);
		if (num2 < 0)
		{
			return;
		}
		if (textBoxTaiKhoan.Text == "")
		{
			textBoxStatus.Text = "Chưa nhập ID tài khoản.";
			return;
		}
		string a = method_0(textBoxPassword.Text);
		if (a == "")
		{
			textBoxStatus.Text = "Chưa nhập PASSWORD tài khoản.";
			return;
		}
		gstruct0_0[num2].string_0 = textBoxTaiKhoan.Text;
		gstruct0_0[num2].string_1 = a;
		gstruct0_0[num2].int_4 = Class11.smethod_12(comboBoxNhanVat.Text);
		gstruct0_0[num2].string_2 = comboBoxPhanda.Text;
		gstruct0_0[num2].string_3 = comboBoxServer.Text;
		listView1.Items[num].SubItems[2].Text = textBoxTaiKhoan.Text;
		listView1.Items[num].SubItems[3].Text = comboBoxNhanVat.Text;
		listView1.Items[num].SubItems[4].Text = comboBoxServer.Text;
		listView1.Items[num].SubItems[5].Text = comboBoxPhanda.Text;
		textBoxStatus.Text = "Đã sửa tài khoản tại dòng " + num + ":" + num2;
		bool_2 = true;
	}

	private void buttonLuuDanhsach_Click(object sender, EventArgs e)
	{
		Class18.smethod_1();
		textBoxStatus.Text = "Đã lưu tệp danh sách: " + string_3;
	}

	private void listView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		GStruct0 gStruct = default(GStruct0);
		gStruct.string_0 = listView1.Items[num].SubItems[2].Text;
		gStruct.int_4 = Class11.smethod_12(listView1.Items[num].SubItems[3].Text);
		gStruct.string_3 = listView1.Items[num].SubItems[4].Text;
		gStruct.string_2 = listView1.Items[num].SubItems[5].Text;
		GStruct0 gstruct0_ = gStruct;
		int num2 = smethod_3(gstruct0_0, gstruct0_);
		if (num2 < 0)
		{
			return;
		}
		bool_3 = false;
		comboBoxServer.Items.Clear();
		for (int i = 0; i < string_4.Length; i++)
		{
			string text = string_4[i];
			if (text == null || text == string.Empty)
			{
				continue;
			}
			string[] array = text.Split('|');
			if (gstruct0_.string_2 == array[0])
			{
				for (int j = 1; j < array.Length; j++)
				{
					comboBoxServer.Items.Add(array[j]);
				}
			}
		}
		textBoxTaiKhoan.Text = gstruct0_.string_0;
		comboBoxNhanVat.Text = gstruct0_.int_4.ToString();
		comboBoxServer.Text = gstruct0_.string_3;
		comboBoxPhanda.Text = gstruct0_.string_2;
		textBoxPassword.Text = gstruct0_0[num2].string_1;
		Thread.Sleep(100);
		bool_3 = true;
	}

	private void labelThem_Click(object sender, EventArgs e)
	{
		if (textBoxTaiKhoan.Text == "")
		{
			textBoxStatus.Text = "Chưa nhập ID tài khoản.";
			return;
		}
		string a = method_0(textBoxPassword.Text);
		if (a == string.Empty)
		{
			textBoxStatus.Text = "Chưa nhập PASSWORD tài khoản.";
			return;
		}
		GStruct0 gStruct = default(GStruct0);
		gStruct.string_0 = textBoxTaiKhoan.Text;
		gStruct.string_1 = a;
		gStruct.int_4 = Class11.smethod_12(comboBoxNhanVat.Text);
		gStruct.string_2 = comboBoxPhanda.Text;
		gStruct.string_3 = comboBoxServer.Text;
		int num = smethod_1(ref gstruct0_0, gStruct);
		if (num < 0)
		{
			textBoxStatus.Text = "Tài khoản [" + gStruct.string_0 + "] đã tồn tại.";
			return;
		}
		method_1(gStruct);
		method_2(listView1, listView1.Items.Count - 1);
		textBoxStatus.Text = "Đã thêm tài khoản " + gStruct.string_0;
		bool_2 = true;
	}

	private void buttonLen_Click(object sender, EventArgs e)
	{
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num <= 0)
		{
			return;
		}
		GStruct0 gStruct = default(GStruct0);
		gStruct.string_0 = listView1.Items[num].SubItems[2].Text;
		gStruct.int_4 = Class11.smethod_12(listView1.Items[num].SubItems[3].Text);
		gStruct.string_3 = listView1.Items[num].SubItems[4].Text;
		gStruct.string_2 = listView1.Items[num].SubItems[5].Text;
		GStruct0 gstruct0_ = gStruct;
		int num2 = smethod_3(gstruct0_0, gstruct0_);
		if (num2 < 0)
		{
			return;
		}
		for (int i = 1; i < listView1.Items[num].SubItems.Count; i++)
		{
			string text = listView1.Items[num].SubItems[i].Text;
			listView1.Items[num].SubItems[i].Text = listView1.Items[num - 1].SubItems[i].Text;
			listView1.Items[num - 1].SubItems[i].Text = text;
		}
		Color backColor = listView1.Items[num].BackColor;
		Color foreColor = listView1.Items[num].ForeColor;
		listView1.Items[num].BackColor = listView1.Items[num - 1].BackColor;
		listView1.Items[num].ForeColor = listView1.Items[num - 1].ForeColor;
		listView1.Items[num - 1].BackColor = backColor;
		listView1.Items[num - 1].ForeColor = foreColor;
		listView1.Items[num - 1].Focused = true;
		listView1.Items[num - 1].Selected = true;
		num--;
		int index = listView1.TopItem.Index;
		if (num < index && index > 0)
		{
			if (index >= 10)
			{
				listView1.TopItem = listView1.Items[index - 10];
			}
			else
			{
				listView1.TopItem = listView1.Items[0];
			}
		}
		gstruct0_ = gstruct0_0[num2];
		gstruct0_0[num2] = gstruct0_0[num2 - 1];
		gstruct0_0[num2 - 1] = gstruct0_;
		bool_2 = true;
	}

	private void buttonXuong_Click(object sender, EventArgs e)
	{
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num < 0 || listView1.Items.Count - 1 <= num)
		{
			return;
		}
		GStruct0 gStruct = default(GStruct0);
		gStruct.string_0 = listView1.Items[num].SubItems[2].Text;
		gStruct.int_4 = Class11.smethod_12(listView1.Items[num].SubItems[3].Text);
		gStruct.string_3 = listView1.Items[num].SubItems[4].Text;
		gStruct.string_2 = listView1.Items[num].SubItems[5].Text;
		GStruct0 gstruct0_ = gStruct;
		int num2 = smethod_3(gstruct0_0, gstruct0_);
		if (num2 >= 0)
		{
			for (int i = 1; i < listView1.Items[num].SubItems.Count; i++)
			{
				string text = listView1.Items[num].SubItems[i].Text;
				listView1.Items[num].SubItems[i].Text = listView1.Items[num + 1].SubItems[i].Text;
				listView1.Items[num + 1].SubItems[i].Text = text;
			}
			Color backColor = listView1.Items[num].BackColor;
			Color foreColor = listView1.Items[num].ForeColor;
			listView1.Items[num].BackColor = listView1.Items[num + 1].BackColor;
			listView1.Items[num].ForeColor = listView1.Items[num + 1].ForeColor;
			listView1.Items[num + 1].BackColor = backColor;
			listView1.Items[num + 1].ForeColor = foreColor;
			listView1.Items[num + 1].Focused = true;
			listView1.Items[num + 1].Selected = true;
			num++;
			if (num > listView1.TopItem.Index + 8)
			{
				listView1.TopItem = listView1.Items[num];
			}
			gstruct0_ = gstruct0_0[num2];
			gstruct0_0[num2] = gstruct0_0[num2 + 1];
			gstruct0_0[num2 + 1] = gstruct0_;
			bool_2 = true;
		}
	}

	private void textBoxTimeOpenGame_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_5 = Class11.smethod_12(textBoxTimeOpenGame.Text);
			Class55.smethod_10(Class47.string_0, "TimerOpenGame", int_5, "", 0);
		}
	}

	private void textBoxTimerDangNhap_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_6 = Class11.smethod_12(textBoxTimerDangNhap.Text);
			Class55.smethod_10(Class47.string_0, "TimeDangNhap", int_6, "", 0);
		}
	}

	private void buttonThoatGameAll_Click(object sender, EventArgs e)
	{
		bool flag = false;
		int[] array = Class20.smethod_24(Class47.string_17);
		if (array != null)
		{
			if (!flag)
			{
				string text = "Bạn chắc chắn muốn thoát hết game ?";
				if (MessageBox.Show(text, FormMain.string_1, MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
				flag = true;
			}
			for (int i = 0; i < array.Length; i++)
			{
				Class20.smethod_48(array[i]);
				Thread.Sleep(60);
			}
		}
		if (Class47.string_15 == null || Class47.string_15 == string.Empty)
		{
			return;
		}
		string processName = Class47.string_15;
		if (Class11.smethod_2(Class47.string_15.ToUpper(), ".EXE") > 0)
		{
			string[] array2 = Class11.smethod_15(Class47.string_15, '.');
			processName = array2[0];
		}
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName(processName);
			if (processesByName == null || processesByName.Length == 0)
			{
				processesByName = Process.GetProcessesByName(Class47.string_15 + '\u00a0');
				if (processesByName == null || processesByName.Length == 0)
				{
					return;
				}
			}
			if (!flag)
			{
				string text = "Bạn chắc chắn muốn thoát hết game ?";
				if (MessageBox.Show(text, FormMain.string_1, MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
				flag = true;
			}
			try
			{
				for (int i = 0; i < processesByName.Length; i++)
				{
					Class20.smethod_53(processesByName[i]);
				}
			}
			catch
			{
				continue;
			}
			break;
		}
		textBoxStatus.Text = "Đã thoát hết game.";
	}

	private void buttonPhimHuongdan_Click(object sender, EventArgs e)
	{
		string str = "https://youtu.be/dleEtu8n5fY";
		textBoxStatus.Text = "Link phim Hướng dẫn: " + str;
		Class20.smethod_40(Class55.smethod_0(), "", str, 0);
	}

	private void method_3()
	{
		uint num = uint_0;
		if (num != 0)
		{
			Class20.ShowWindow(num, Class20.int_20);
			Thread.Sleep(150);
			Class20.ShowWindow(num, Class20.int_18);
		}
	}

	private void method_4()
	{
		uint num = uint_0;
		if (num != 0)
		{
			Class20.ShowWindow(num, Class20.int_21);
			Thread.Sleep(150);
			Class20.ShowWindow(num, Class20.int_19);
			Class20.SetForegroundWindow(num);
		}
	}

	private void method_5()
	{
		uint num = uint_0;
		if (num != 0)
		{
			Class20.ShowWindow(num, Class20.int_20);
		}
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (bool_4)
		{
			e.NewValue = e.CurrentValue;
		}
	}

	private void listView1_MouseDown(object sender, MouseEventArgs e)
	{
		bool_4 = true;
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		bool_4 = false;
		if (e.Button != MouseButtons.Right || gstruct0_0 == null || gstruct0_0.Length == 0)
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
		if (num < 0 || listView1.Items.Count <= num)
		{
			return;
		}
		GStruct0 gStruct = default(GStruct0);
		gStruct.string_0 = listView1.Items[num].SubItems[2].Text;
		gStruct.int_4 = Class11.smethod_12(listView1.Items[num].SubItems[3].Text);
		gStruct.string_3 = listView1.Items[num].SubItems[4].Text;
		gStruct.string_2 = listView1.Items[num].SubItems[5].Text;
		GStruct0 gstruct0_ = gStruct;
		int num2 = smethod_3(gstruct0_0, gstruct0_);
		if (num2 >= 0)
		{
			if (gstruct0_0[num2].int_1 != 0 && !Class20.smethod_52(gstruct0_0[num2].process_0))
			{
				uint_0 = gstruct0_0[num2].uint_0;
				new Thread(method_3).Start();
				return;
			}
			Class40.bool_1 = true;
			Thread.Sleep(100);
			Class11.smethod_32(ref Class40.int_0, num2);
			Class40.bool_1 = false;
		}
	}

	private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left || gstruct0_0 == null || gstruct0_0.Length == 0)
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
		if (num >= 0 && listView1.Items.Count > num)
		{
			GStruct0 gStruct = default(GStruct0);
			gStruct.string_0 = listView1.Items[num].SubItems[2].Text;
			gStruct.int_4 = Class11.smethod_12(listView1.Items[num].SubItems[3].Text);
			gStruct.string_3 = listView1.Items[num].SubItems[4].Text;
			gStruct.string_2 = listView1.Items[num].SubItems[5].Text;
			GStruct0 gstruct0_ = gStruct;
			int num2 = smethod_3(gstruct0_0, gstruct0_);
			if (num2 >= 0 && !Class20.smethod_52(gstruct0_0[num2].process_0))
			{
				uint_0 = gstruct0_0[num2].uint_0;
				new Thread(method_4).Start();
			}
		}
	}

	private void checkBoxThuNho_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_7 = Convert.ToByte(checkBoxThuNho.Checked);
			Class55.smethod_10(Class47.string_0, "flagThuNho", int_7, "", 0);
		}
	}

	private void comboBoxPhanda_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_3)
		{
			return;
		}
		comboBoxServer.Items.Clear();
		string text = comboBoxPhanda.Text;
		int num = 0;
		string[] array;
		while (true)
		{
			if (num >= string_4.Length)
			{
				return;
			}
			string text2 = string_4[num];
			if (text2 != null && !(text2 == string.Empty))
			{
				array = text2.Split('|');
				if (text == array[0])
				{
					break;
				}
			}
			num++;
		}
		if (array.Length > 1)
		{
			for (int i = 1; i < array.Length; i++)
			{
				comboBoxServer.Items.Add(array[i]);
			}
			comboBoxServer.Text = array[1];
		}
	}

	private void buttonLogin_Click(object sender, EventArgs e)
	{
		Class40.bool_1 = true;
		Thread.Sleep(100);
		bool flag = false;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Checked)
			{
				flag = true;
				Class11.smethod_32(ref Class40.int_0, i);
			}
		}
		if (!flag)
		{
			int num = -1;
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				if (listView1.Items[i].Selected)
				{
					num = i;
					break;
				}
			}
			if (0 <= num)
			{
				Class11.smethod_32(ref Class40.int_0, num);
			}
			Class40.bool_1 = false;
		}
		else
		{
			Class40.bool_1 = false;
		}
	}

	private void checkBoxTuDangNhap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_4 = Convert.ToByte(checkBoxTuDangNhap.Checked);
			Class55.smethod_10(Class47.string_0, "flagTuDangNhap", int_4, "", 0);
		}
	}

	private void buttonMoGame_Click(object sender, EventArgs e)
	{
		Class85.smethod_1();
	}

	private void buttonStopLogin_Click(object sender, EventArgs e)
	{
		Class40.bool_0 = true;
	}

	private void linkLabelCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		bool_5 = !bool_5;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			listView1.Items[i].Checked = bool_5;
		}
	}

	private void buttonGameHu_Click(object sender, EventArgs e)
	{
		new Thread(method_6).Start();
	}

	private void method_6()
	{
		string_0 = new string[1]
		{
			Class40.smethod_5()
		};
	}

	private void checkBoxLog1ac_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_8 = Convert.ToByte(checkBoxLog1ac.Checked);
			Class55.smethod_10(Class47.string_0, "fLog1ac", int_8, "", 0);
		}
	}

	private void checkBoxFileKhac_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_3)
		{
			int_9 = Convert.ToByte(checkBoxFileKhac.Checked);
			Class55.smethod_10(Class47.string_0, "flagFileKhac", int_9, "", 0);
		}
	}

	private void buttonBrowseGameKhac_Click(object sender, EventArgs e)
	{
		string string_ = Class47.string_14;
		if (string_ == string.Empty || string_ == null)
		{
			string_ = Class47.string_4;
		}
		string text = Class47.smethod_24(string_, string.Empty, "*.exe");
		textBoxFile.Text = text;
		string_1 = text;
		Class55.smethod_10(Class47.string_0, "PathFileKhac", string_1, "", 0);
		if (text != null && text != string.Empty)
		{
			Class20.smethod_70(text);
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonXoaTK = new System.Windows.Forms.Button();
		buttonSuaTK = new System.Windows.Forms.Button();
		label4 = new System.Windows.Forms.Label();
		textBoxTaiKhoan = new System.Windows.Forms.TextBox();
		comboBoxNhanVat = new System.Windows.Forms.ComboBox();
		labelTaiKhoan = new System.Windows.Forms.Label();
		textBoxPassword = new System.Windows.Forms.TextBox();
		labelPassword = new System.Windows.Forms.Label();
		comboBoxServer = new System.Windows.Forms.ComboBox();
		comboBoxPhanda = new System.Windows.Forms.ComboBox();
		buttonLen = new System.Windows.Forms.Button();
		buttonXuong = new System.Windows.Forms.Button();
		textBoxStatus = new System.Windows.Forms.TextBox();
		buttonLuuDanhsach = new System.Windows.Forms.Button();
		labelThem = new System.Windows.Forms.Label();
		tabControl1 = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		checkBoxTuDangNhap = new System.Windows.Forms.CheckBox();
		buttonThoatGameAll = new System.Windows.Forms.Button();
		checkBoxThuNho = new System.Windows.Forms.CheckBox();
		buttonStopLogin = new System.Windows.Forms.Button();
		buttonLogin = new System.Windows.Forms.Button();
		buttonMoGame = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		textBoxTimeOpenGame = new System.Windows.Forms.TextBox();
		textBoxTimerDangNhap = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		tabPage3 = new System.Windows.Forms.TabPage();
		groupBox1 = new System.Windows.Forms.GroupBox();
		tabPage4 = new System.Windows.Forms.TabPage();
		checkBoxLog1ac = new System.Windows.Forms.CheckBox();
		buttonGameHu = new System.Windows.Forms.Button();
		buttonPhimHuongdan = new System.Windows.Forms.Button();
		labelStatus = new System.Windows.Forms.Label();
		textBoxTimer = new System.Windows.Forms.TextBox();
		linkLabelCheckAll = new System.Windows.Forms.LinkLabel();
		checkBoxFileKhac = new System.Windows.Forms.CheckBox();
		textBoxFile = new System.Windows.Forms.TextBox();
		buttonBrowseGameKhac = new System.Windows.Forms.Button();
		tabControl1.SuspendLayout();
		tabPage1.SuspendLayout();
		tabPage3.SuspendLayout();
		groupBox1.SuspendLayout();
		tabPage4.SuspendLayout();
		SuspendLayout();
		listView1.CheckBoxes = true;
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
		listView1.Location = new System.Drawing.Point(1, 45);
		listView1.MultiSelect = false;
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(333, 176);
		listView1.TabIndex = 1;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		listView1.SelectedIndexChanged += new System.EventHandler(listView1_SelectedIndexChanged);
		listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(listView1_MouseDoubleClick);
		listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(listView1_MouseDown);
		listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		columnHeader_0.Text = "No";
		columnHeader_0.Width = 50;
		columnHeader_1.Text = "Nhân vật";
		columnHeader_1.Width = 110;
		columnHeader_2.Text = "ID";
		columnHeader_2.Width = 40;
		columnHeader_3.Text = "Idex";
		columnHeader_3.Width = 35;
		columnHeader_4.Text = "Server";
		columnHeader_4.Width = 75;
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonXoaTK.Location = new System.Drawing.Point(190, 60);
		buttonXoaTK.Name = "buttonXoaTK";
		buttonXoaTK.Size = new System.Drawing.Size(45, 23);
		buttonXoaTK.TabIndex = 171;
		buttonXoaTK.Text = "Xóa";
		buttonXoaTK.UseVisualStyleBackColor = true;
		buttonXoaTK.Click += new System.EventHandler(buttonXoaTK_Click);
		buttonSuaTK.Location = new System.Drawing.Point(147, 60);
		buttonSuaTK.Name = "buttonSuaTK";
		buttonSuaTK.Size = new System.Drawing.Size(40, 23);
		buttonSuaTK.TabIndex = 170;
		buttonSuaTK.Text = "Sửa";
		buttonSuaTK.UseVisualStyleBackColor = true;
		buttonSuaTK.Click += new System.EventHandler(buttonSuaTK_Click);
		label4.AutoSize = true;
		label4.BackColor = System.Drawing.SystemColors.Control;
		label4.ForeColor = System.Drawing.SystemColors.ControlText;
		label4.Location = new System.Drawing.Point(3, 66);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(51, 13);
		label4.TabIndex = 168;
		label4.Text = "Nhân vật";
		label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		textBoxTaiKhoan.Location = new System.Drawing.Point(61, 7);
		textBoxTaiKhoan.Name = "textBoxTaiKhoan";
		textBoxTaiKhoan.Size = new System.Drawing.Size(80, 20);
		textBoxTaiKhoan.TabIndex = 163;
		comboBoxNhanVat.BackColor = System.Drawing.SystemColors.Window;
		comboBoxNhanVat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxNhanVat.FormattingEnabled = true;
		comboBoxNhanVat.Location = new System.Drawing.Point(61, 61);
		comboBoxNhanVat.Name = "comboBoxNhanVat";
		comboBoxNhanVat.Size = new System.Drawing.Size(35, 21);
		comboBoxNhanVat.TabIndex = 165;
		labelTaiKhoan.AutoSize = true;
		labelTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
		labelTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
		labelTaiKhoan.Location = new System.Drawing.Point(3, 11);
		labelTaiKhoan.Name = "labelTaiKhoan";
		labelTaiKhoan.Size = new System.Drawing.Size(55, 13);
		labelTaiKhoan.TabIndex = 161;
		labelTaiKhoan.Text = "Tài khoản";
		labelTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		textBoxPassword.Location = new System.Drawing.Point(61, 32);
		textBoxPassword.Name = "textBoxPassword";
		textBoxPassword.PasswordChar = '*';
		textBoxPassword.Size = new System.Drawing.Size(80, 20);
		textBoxPassword.TabIndex = 164;
		labelPassword.AutoSize = true;
		labelPassword.BackColor = System.Drawing.SystemColors.Control;
		labelPassword.ForeColor = System.Drawing.SystemColors.ControlText;
		labelPassword.Location = new System.Drawing.Point(3, 34);
		labelPassword.Name = "labelPassword";
		labelPassword.Size = new System.Drawing.Size(53, 13);
		labelPassword.TabIndex = 162;
		labelPassword.Text = "Password";
		labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		comboBoxServer.BackColor = System.Drawing.SystemColors.Control;
		comboBoxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxServer.FormattingEnabled = true;
		comboBoxServer.Location = new System.Drawing.Point(146, 32);
		comboBoxServer.Name = "comboBoxServer";
		comboBoxServer.Size = new System.Drawing.Size(95, 21);
		comboBoxServer.TabIndex = 167;
		comboBoxPhanda.BackColor = System.Drawing.SystemColors.Control;
		comboBoxPhanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxPhanda.FormattingEnabled = true;
		comboBoxPhanda.Location = new System.Drawing.Point(146, 7);
		comboBoxPhanda.Name = "comboBoxPhanda";
		comboBoxPhanda.Size = new System.Drawing.Size(95, 21);
		comboBoxPhanda.TabIndex = 166;
		comboBoxPhanda.SelectedIndexChanged += new System.EventHandler(comboBoxPhanda_SelectedIndexChanged);
		buttonLen.BackColor = System.Drawing.SystemColors.Control;
		//buttonLen.Image = (System.Drawing.Image)componentResourceManager.GetObject("buttonLen.Image");
		buttonLen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
		buttonLen.Location = new System.Drawing.Point(10, 19);
		buttonLen.Name = "buttonLen";
		buttonLen.Size = new System.Drawing.Size(30, 25);
		buttonLen.TabIndex = 172;
		buttonLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		buttonLen.UseVisualStyleBackColor = false;
		buttonLen.Click += new System.EventHandler(buttonLen_Click);
		buttonXuong.BackColor = System.Drawing.SystemColors.Control;
		//buttonXuong.Image = (System.Drawing.Image)componentResourceManager.GetObject("buttonXuong.Image");
		buttonXuong.Location = new System.Drawing.Point(44, 19);
		buttonXuong.Name = "buttonXuong";
		buttonXuong.Size = new System.Drawing.Size(30, 25);
		buttonXuong.TabIndex = 173;
		buttonXuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		buttonXuong.UseVisualStyleBackColor = false;
		buttonXuong.Click += new System.EventHandler(buttonXuong_Click);
		textBoxStatus.Location = new System.Drawing.Point(1, 6);
		textBoxStatus.Name = "textBoxStatus";
		textBoxStatus.ReadOnly = true;
		textBoxStatus.Size = new System.Drawing.Size(234, 20);
		textBoxStatus.TabIndex = 174;
		buttonLuuDanhsach.ForeColor = System.Drawing.Color.DarkRed;
		buttonLuuDanhsach.Location = new System.Drawing.Point(237, 60);
		buttonLuuDanhsach.Name = "buttonLuuDanhsach";
		buttonLuuDanhsach.Size = new System.Drawing.Size(90, 23);
		buttonLuuDanhsach.TabIndex = 175;
		buttonLuuDanhsach.Text = "Lưu danh sách";
		buttonLuuDanhsach.UseVisualStyleBackColor = true;
		buttonLuuDanhsach.Click += new System.EventHandler(buttonLuuDanhsach_Click);
		labelThem.BackColor = System.Drawing.Color.LightSteelBlue;
		labelThem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		labelThem.Cursor = System.Windows.Forms.Cursors.Hand;
		labelThem.ForeColor = System.Drawing.Color.MediumBlue;
		labelThem.Location = new System.Drawing.Point(99, 61);
		labelThem.Name = "labelThem";
		labelThem.Size = new System.Drawing.Size(44, 21);
		labelThem.TabIndex = 176;
		labelThem.Text = "Thêm";
		labelThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		labelThem.Click += new System.EventHandler(labelThem_Click);
		tabControl1.Controls.Add(tabPage1);
		tabControl1.Controls.Add(tabPage3);
		tabControl1.Controls.Add(tabPage4);
		tabControl1.Location = new System.Drawing.Point(0, 224);
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size(347, 112);
		tabControl1.TabIndex = 180;
		tabPage1.BackColor = System.Drawing.SystemColors.Control;
		tabPage1.Controls.Add(checkBoxTuDangNhap);
		tabPage1.Controls.Add(buttonThoatGameAll);
		tabPage1.Controls.Add(checkBoxThuNho);
		tabPage1.Controls.Add(buttonStopLogin);
		tabPage1.Controls.Add(buttonLogin);
		tabPage1.Controls.Add(buttonPhimHuongdan);
		tabPage1.Controls.Add(label2);
		tabPage1.Controls.Add(textBoxTimeOpenGame);
		tabPage1.Controls.Add(textBoxTimerDangNhap);
		tabPage1.Controls.Add(label1);
		tabPage1.Location = new System.Drawing.Point(4, 22);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding(3);
		tabPage1.Size = new System.Drawing.Size(339, 86);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "Quản lý";
		checkBoxTuDangNhap.AutoSize = true;
		checkBoxTuDangNhap.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxTuDangNhap.Location = new System.Drawing.Point(3, 3);
		checkBoxTuDangNhap.Name = "checkBoxTuDangNhap";
		checkBoxTuDangNhap.Size = new System.Drawing.Size(131, 17);
		checkBoxTuDangNhap.TabIndex = 388;
		checkBoxTuDangNhap.Text = "Tự login khi diss game";
		checkBoxTuDangNhap.UseVisualStyleBackColor = true;
		checkBoxTuDangNhap.CheckedChanged += new System.EventHandler(checkBoxTuDangNhap_CheckedChanged);
		buttonThoatGameAll.Location = new System.Drawing.Point(260, 48);
		buttonThoatGameAll.Name = "buttonThoatGameAll";
		buttonThoatGameAll.Size = new System.Drawing.Size(78, 37);
		buttonThoatGameAll.TabIndex = 177;
		buttonThoatGameAll.Text = "Thoát hết game";
		buttonThoatGameAll.UseVisualStyleBackColor = true;
		buttonThoatGameAll.Click += new System.EventHandler(buttonThoatGameAll_Click);
		checkBoxThuNho.AutoSize = true;
		checkBoxThuNho.Location = new System.Drawing.Point(2, 26);
		checkBoxThuNho.Name = "checkBoxThuNho";
		checkBoxThuNho.Size = new System.Drawing.Size(108, 17);
		checkBoxThuNho.TabIndex = 184;
		checkBoxThuNho.Text = "Thu nhỏ khi login";
		checkBoxThuNho.UseVisualStyleBackColor = true;
		checkBoxThuNho.CheckedChanged += new System.EventHandler(checkBoxThuNho_CheckedChanged);
		buttonStopLogin.BackColor = System.Drawing.SystemColors.Control;
		buttonStopLogin.Location = new System.Drawing.Point(66, 57);
		buttonStopLogin.Name = "buttonStopLogin";
		buttonStopLogin.Size = new System.Drawing.Size(60, 26);
		buttonStopLogin.TabIndex = 390;
		buttonStopLogin.Text = "Dừng lại";
		buttonStopLogin.UseVisualStyleBackColor = false;
		buttonStopLogin.Click += new System.EventHandler(buttonStopLogin_Click);
		buttonLogin.BackColor = System.Drawing.Color.LightSteelBlue;
		buttonLogin.Location = new System.Drawing.Point(3, 57);
		buttonLogin.Name = "buttonLogin";
		buttonLogin.Size = new System.Drawing.Size(60, 26);
		buttonLogin.TabIndex = 185;
		buttonLogin.Text = "Login";
		buttonLogin.UseVisualStyleBackColor = false;
		buttonLogin.Click += new System.EventHandler(buttonLogin_Click);
		buttonMoGame.BackColor = System.Drawing.Color.LightSteelBlue;
		buttonMoGame.Location = new System.Drawing.Point(3, 48);
		buttonMoGame.Name = "buttonMoGame";
		buttonMoGame.Size = new System.Drawing.Size(80, 36);
		buttonMoGame.TabIndex = 389;
		buttonMoGame.Text = "Mở game";
		buttonMoGame.UseVisualStyleBackColor = false;
		buttonMoGame.Click += new System.EventHandler(buttonMoGame_Click);
		label2.AutoSize = true;
		label2.BackColor = System.Drawing.SystemColors.Control;
		label2.ForeColor = System.Drawing.SystemColors.ControlText;
		label2.Location = new System.Drawing.Point(135, 28);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(149, 13);
		label2.TabIndex = 166;
		label2.Text = "Thời gian chờ đăng nhập (ms)";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		textBoxTimeOpenGame.Location = new System.Drawing.Point(287, 3);
		textBoxTimeOpenGame.Name = "textBoxTimeOpenGame";
		textBoxTimeOpenGame.Size = new System.Drawing.Size(50, 20);
		textBoxTimeOpenGame.TabIndex = 165;
		textBoxTimeOpenGame.TextChanged += new System.EventHandler(textBoxTimeOpenGame_TextChanged);
		textBoxTimerDangNhap.Location = new System.Drawing.Point(287, 25);
		textBoxTimerDangNhap.Name = "textBoxTimerDangNhap";
		textBoxTimerDangNhap.Size = new System.Drawing.Size(50, 20);
		textBoxTimerDangNhap.TabIndex = 167;
		textBoxTimerDangNhap.TextChanged += new System.EventHandler(textBoxTimerDangNhap_TextChanged);
		label1.AutoSize = true;
		label1.BackColor = System.Drawing.SystemColors.Control;
		label1.ForeColor = System.Drawing.SystemColors.ControlText;
		label1.Location = new System.Drawing.Point(135, 7);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(140, 13);
		label1.TabIndex = 164;
		label1.Text = "Thời gian chờ mở game (ms)";
		label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		tabPage3.Controls.Add(comboBoxPhanda);
		tabPage3.Controls.Add(buttonLuuDanhsach);
		tabPage3.Controls.Add(comboBoxNhanVat);
		tabPage3.Controls.Add(labelPassword);
		tabPage3.Controls.Add(comboBoxServer);
		tabPage3.Controls.Add(textBoxTaiKhoan);
		tabPage3.Controls.Add(buttonSuaTK);
		tabPage3.Controls.Add(groupBox1);
		tabPage3.Controls.Add(labelThem);
		tabPage3.Controls.Add(labelTaiKhoan);
		tabPage3.Controls.Add(buttonXoaTK);
		tabPage3.Controls.Add(textBoxPassword);
		tabPage3.Controls.Add(label4);
		tabPage3.Location = new System.Drawing.Point(4, 22);
		tabPage3.Name = "tabPage3";
		tabPage3.Padding = new System.Windows.Forms.Padding(3);
		tabPage3.Size = new System.Drawing.Size(339, 86);
		tabPage3.TabIndex = 2;
		tabPage3.Text = "Nhập tài khoản";
		tabPage3.UseVisualStyleBackColor = true;
		groupBox1.Controls.Add(buttonXuong);
		groupBox1.Controls.Add(buttonLen);
		groupBox1.Location = new System.Drawing.Point(246, 2);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(81, 52);
		groupBox1.TabIndex = 177;
		groupBox1.TabStop = false;
		groupBox1.Text = "Sắp xếp";
		tabPage4.Controls.Add(textBoxFile);
		tabPage4.Controls.Add(buttonBrowseGameKhac);
		tabPage4.Controls.Add(checkBoxFileKhac);
		tabPage4.Controls.Add(checkBoxLog1ac);
		tabPage4.Controls.Add(buttonGameHu);
		tabPage4.Controls.Add(buttonMoGame);
		tabPage4.Location = new System.Drawing.Point(4, 22);
		tabPage4.Name = "tabPage4";
		tabPage4.Padding = new System.Windows.Forms.Padding(3);
		tabPage4.Size = new System.Drawing.Size(339, 86);
		tabPage4.TabIndex = 3;
		tabPage4.Text = "Mở game thông qua file khác";
		tabPage4.UseVisualStyleBackColor = true;
		checkBoxLog1ac.Location = new System.Drawing.Point(221, 50);
		checkBoxLog1ac.Name = "checkBoxLog1ac";
		checkBoxLog1ac.Size = new System.Drawing.Size(112, 33);
		checkBoxLog1ac.TabIndex = 390;
		checkBoxLog1ac.Text = "Fix User32 log 1 ac";
		checkBoxLog1ac.UseVisualStyleBackColor = true;
		checkBoxLog1ac.CheckedChanged += new System.EventHandler(checkBoxLog1ac_CheckedChanged);
		buttonGameHu.Location = new System.Drawing.Point(88, 48);
		buttonGameHu.Name = "buttonGameHu";
		buttonGameHu.Size = new System.Drawing.Size(127, 37);
		buttonGameHu.TabIndex = 178;
		buttonGameHu.Text = "Thoát hết game hư còn chạy ngầm";
		buttonGameHu.UseVisualStyleBackColor = true;
		buttonGameHu.Click += new System.EventHandler(buttonGameHu_Click);
		buttonPhimHuongdan.ForeColor = System.Drawing.Color.DarkBlue;
		buttonPhimHuongdan.Location = new System.Drawing.Point(201, 48);
		buttonPhimHuongdan.Name = "buttonPhimHuongdan";
		buttonPhimHuongdan.Size = new System.Drawing.Size(53, 35);
		buttonPhimHuongdan.TabIndex = 182;
		buttonPhimHuongdan.Text = "Phim hd login";
		buttonPhimHuongdan.UseVisualStyleBackColor = true;
		buttonPhimHuongdan.Click += new System.EventHandler(buttonPhimHuongdan_Click);
		labelStatus.AutoSize = true;
		labelStatus.ForeColor = System.Drawing.Color.DarkRed;
		labelStatus.Location = new System.Drawing.Point(169, 29);
		labelStatus.Name = "labelStatus";
		labelStatus.Size = new System.Drawing.Size(157, 13);
		labelStatus.TabIndex = 178;
		labelStatus.Text = "Click chuột phải để login nhanh";
		textBoxTimer.Location = new System.Drawing.Point(239, 6);
		textBoxTimer.Name = "textBoxTimer";
		textBoxTimer.ReadOnly = true;
		textBoxTimer.Size = new System.Drawing.Size(95, 20);
		textBoxTimer.TabIndex = 181;
		linkLabelCheckAll.AutoSize = true;
		linkLabelCheckAll.Location = new System.Drawing.Point(3, 29);
		linkLabelCheckAll.Name = "linkLabelCheckAll";
		linkLabelCheckAll.Size = new System.Drawing.Size(142, 13);
		linkLabelCheckAll.TabIndex = 182;
		linkLabelCheckAll.TabStop = true;
		linkLabelCheckAll.Text = "Check hoặc Uncheck tất cả";
		linkLabelCheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelCheckAll_LinkClicked);
		checkBoxFileKhac.AutoSize = true;
		checkBoxFileKhac.ForeColor = System.Drawing.Color.Black;
		checkBoxFileKhac.Location = new System.Drawing.Point(3, 1);
		checkBoxFileKhac.Name = "checkBoxFileKhac";
		checkBoxFileKhac.Size = new System.Drawing.Size(319, 17);
		checkBoxFileKhac.TabIndex = 393;
		checkBoxFileKhac.Text = "Nếu phải mở game thông qua một tệp khác, thì phải chọn tệp:";
		checkBoxFileKhac.UseVisualStyleBackColor = true;
		checkBoxFileKhac.CheckedChanged += new System.EventHandler(checkBoxFileKhac_CheckedChanged);
		textBoxFile.Location = new System.Drawing.Point(3, 23);
		textBoxFile.Name = "textBoxFile";
		textBoxFile.ReadOnly = true;
		textBoxFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		textBoxFile.Size = new System.Drawing.Size(275, 20);
		textBoxFile.TabIndex = 395;
		buttonBrowseGameKhac.ForeColor = System.Drawing.Color.Black;
		buttonBrowseGameKhac.Location = new System.Drawing.Point(284, 23);
		buttonBrowseGameKhac.Name = "buttonBrowseGameKhac";
		buttonBrowseGameKhac.Size = new System.Drawing.Size(46, 21);
		buttonBrowseGameKhac.TabIndex = 396;
		buttonBrowseGameKhac.Text = "***";
		buttonBrowseGameKhac.UseVisualStyleBackColor = true;
		buttonBrowseGameKhac.Click += new System.EventHandler(buttonBrowseGameKhac_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(344, 333);
		base.Controls.Add(linkLabelCheckAll);
		base.Controls.Add(textBoxTimer);
		base.Controls.Add(labelStatus);
		base.Controls.Add(tabControl1);
		base.Controls.Add(textBoxStatus);
		base.Controls.Add(listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormLogin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "LOGIN - CAP NHAT DANH SACH";
		base.Load += new System.EventHandler(FormLogin_Load);
		tabControl1.ResumeLayout(performLayout: false);
		tabPage1.ResumeLayout(performLayout: false);
		tabPage1.PerformLayout();
		tabPage3.ResumeLayout(performLayout: false);
		tabPage3.PerformLayout();
		groupBox1.ResumeLayout(performLayout: false);
		tabPage4.ResumeLayout(performLayout: false);
		tabPage4.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
