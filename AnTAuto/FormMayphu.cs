using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormMayphu : Form
{
	public static int int_0 = 0;

	public static bool bool_0 = false;

	public static string[] string_0 = null;

	public static bool bool_1 = false;

	public static int[] int_1 = null;

	public static string string_1 = null;

	public static bool bool_2 = false;

	public static bool bool_3 = false;

	public static string string_2 = Class55.smethod_6("SMayphu", 0, "|");

	public int int_2 = 0;

	public int int_3 = 0;

	public int int_4;

	public int int_5;

	private string[] string_3 = null;

	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ComboBox comboBoxThemAcc;

	private Button buttonThemAcc;

	private Button buttonXoaAcc;

	private System.Windows.Forms.Timer timer_0;

	private Label label1;

	private Button buttonClose;

	public static void smethod_0()
	{
		int int_ = int_0;
		int_0 = 0;
		while (true)
		{
			try
			{
				smethod_1(int_);
				return;
			}
			catch
			{
				Thread.Sleep(100);
			}
		}
	}

	public static void smethod_1(int int_6)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = -1000;
		long long_ = 0L;
		GStruct42 gstruct42_ = default(GStruct42);
		while (true)
		{
			num--;
			Thread.Sleep(100);
			if (Class11.bool_0)
			{
				break;
			}
			if (num <= 0)
			{
				num3 = Class71.smethod_3(FormMain.gstruct42_0, int_6);
				if (num3 < 0)
				{
					break;
				}
				num = 30;
				Class58.smethod_0(gstruct42_, FormMain.int_9 > 0);
			}
			gstruct42_ = FormMain.gstruct42_0[num3];
			if (num4 == -1000)
			{
				num4 = GClass1.smethod_5(gstruct42_);
			}
			if (gstruct42_.int_2 > 0 && num4 > 0)
			{
				uint num5 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
				uint num6 = Class20.smethod_30(num5 + Class47.gstruct43_13.uint_0, gstruct42_.int_130);
				uint num7 = num6 * Class47.gstruct43_15.uint_0;
				uint num8 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
				uint num9 = num8 + num7;
				int num10 = (int)Class20.smethod_30(num9 + Class47.gstruct43_55.uint_0, gstruct42_.int_130);
				int num11 = (int)Class20.smethod_30(num9 + Class47.gstruct43_50.uint_0, gstruct42_.int_130);
				int num12 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_.int_130);
				int num13 = Class73.smethod_40(gstruct42_);
				if (num11 == 0 || num10 == 0 || num12 == 0 || num13 <= 1)
				{
					continue;
				}
				uint num14 = 0u;
				uint num15 = 0u;
				int num16 = Class38.gstruct29_0.int_4;
				if (Class38.gstruct29_0.uint_4 != null)
				{
					num14 = Class38.gstruct29_0.uint_4[0];
					num15 = Class38.gstruct29_0.uint_4[1];
				}
				if (num14 == 0 || num15 == 0 || num16 <= 0)
				{
					continue;
				}
				int num17 = 0;
				if (FormMain.int_48 > 0)
				{
					num17 = FormMain.int_49;
				}
				string str = string_2 + num16 + string_2 + Class38.gstruct29_0.int_3 + string_2 + num14 + string_2 + num15 + string_2 + Class38.gstruct29_0.int_6 + string_2 + Class38.gstruct29_0.uint_3 + string_2 + FormMain.int_108 + string_2 + FormMain.int_20 + string_2 + FormMain.int_100 + string_2 + FormMain.int_102 + string_2 + Class16.int_0 + string_2 + FormMain.int_22 + string_2 + FormMain.int_30 + string_2 + FormMain.int_31 + string_2 + FormMain.int_32 + string_2 + FormMain.int_25 + string_2 + Class38.gstruct29_0.int_2 + string_2 + FormMain.int_24 + string_2 + FormMain.int_83 + string_2 + FormMain.int_84 + string_2 + FormDame.int_6 + string_2 + FormDame.int_5 + string_2 + FormDame.int_8 + string_2 + Class38.gstruct29_0.uint_5 + string_2 + Class38.gstruct29_0.int_7 + string_2 + Class38.gstruct29_0.uint_3 + string_2 + FormMain.int_33 + string_2 + FormMain.int_34 + string_2 + FormMain.int_21 + string_2 + Class38.gstruct29_0.int_9 + string_2 + Class38.gstruct29_0.uint_2 + string_2 + FormMain.int_85 + string_2 + Class38.gstruct29_0.int_8 + string_2 + num17 + string_2 + FormMain.int_44[0] + string_2 + FormMain.int_44[1] + string_2 + FormMain.int_0 + string_2 + Class31.int_1 + string_2 + FormMain.int_99 + string_2 + FormMain.int_103 + string_2 + FormMain.int_79 + string_2 + FormMain.int_70 + string_2 + FormMain.int_107;
				Class38.gstruct29_0.int_9 = 0;
				if (string_0 != null)
				{
					int num18 = string_0.Length;
					if (num2 < 0 || num18 <= num2)
					{
						num2 = 0;
					}
					int num19 = num2;
					string text = null;
					while (text == null || text == string.Empty || text == gstruct42_.string_20)
					{
						try
						{
							text = string_0[num2];
						}
						catch
						{
							break;
						}
						num2++;
						if (num2 < 0 || num18 <= num2)
						{
							num2 = 0;
						}
						if (num19 == num2 || string_0 == null || string_0.Length <= num19)
						{
							break;
						}
					}
					if (text != null && text != string.Empty && gstruct42_.string_20 != text)
					{
						Class60.smethod_48(gstruct42_, text, str);
						Thread.Sleep(60 + 200 / num18);
					}
				}
				if (FormMain.int_8 > 0 && Class11.smethod_23(long_) >= 2500L)
				{
					Class60.smethod_55(gstruct42_, "Chat('CH_CHATROOM', '" + str + "')");
					long_ = Class11.smethod_22();
				}
				continue;
			}
			FormMain.gstruct42_0[num3].int_2 = 0;
			break;
		}
		Class58.smethod_0(gstruct42_, bool_0: false);
	}

	public static void smethod_2(GStruct42 gstruct42_0)
	{
		if (FormMain.int_7 <= 0)
		{
			return;
		}
		if (GClass1.long_1 != 0L && !bool_1)
		{
			string text = Class73.smethod_22(gstruct42_0);
			if (text != null && !(text == string.Empty))
			{
				if (string_2 == null || string_2 == string.Empty)
				{
					string_2 = "|";
				}
				string[] array = text.Split(string_2[0]);
				int num = array.Length;
				if (num >= 43)
				{
					try
					{
						if (FormMain.int_48 <= 0)
						{
							goto IL_00ce;
						}
						int num2 = Class11.smethod_12(smethod_5(array, 34, num));
						if (num2 == FormMain.int_49)
						{
							goto IL_00ce;
						}
						goto end_IL_00a3;
						IL_00ce:
						if (Class38.gstruct29_1.uint_4 == null)
						{
							Class38.gstruct29_1.uint_4 = new uint[2];
						}
						FormMain.int_106 = 0;
						Class38.gstruct29_1.int_4 = Class11.smethod_12(smethod_5(array, 1, num));
						Class38.gstruct29_1.int_3 = Class11.smethod_12(smethod_5(array, 2, num));
						Class38.gstruct29_1.uint_4[0] = Class11.smethod_13(smethod_5(array, 3, num));
						Class38.gstruct29_1.uint_4[1] = Class11.smethod_13(smethod_5(array, 4, num));
						Class38.gstruct29_1.int_6 = Class11.smethod_12(smethod_5(array, 5, num));
						Class38.gstruct29_1.uint_3 = Class11.smethod_13(smethod_5(array, 6, num));
						FormMain.int_108 = Class11.smethod_12(smethod_5(array, 7, num));
						FormMain.int_20 = Class11.smethod_12(smethod_5(array, 8, num));
						FormMain.int_100 = Class11.smethod_12(smethod_5(array, 9, num));
						FormMain.int_102 = Class11.smethod_12(smethod_5(array, 10, num));
						Class16.int_0 = Class11.smethod_12(smethod_5(array, 11, num));
						FormMain.int_22 = Class11.smethod_12(smethod_5(array, 12, num));
						FormMain.int_30 = Class11.smethod_12(smethod_5(array, 13, num));
						FormMain.int_31 = Class11.smethod_12(smethod_5(array, 14, num));
						FormMain.int_32 = Class11.smethod_12(smethod_5(array, 15, num));
						Class38.gstruct29_1.int_10 = Class11.smethod_12(smethod_5(array, 16, num));
						Class38.gstruct29_1.int_2 = Class11.smethod_12(smethod_5(array, 17, num));
						FormMain.int_24 = Class11.smethod_12(smethod_5(array, 18, num));
						FormMain.int_83 = 1;
						FormMain.int_84 = Class11.smethod_12(smethod_5(array, 20, num));
						FormDame.int_6 = Class11.smethod_12(smethod_5(array, 21, num));
						FormDame.int_5 = Class11.smethod_12(smethod_5(array, 22, num));
						FormDame.int_8 = Class11.smethod_12(smethod_5(array, 23, num));
						Class38.gstruct29_1.uint_5 = Class11.smethod_13(smethod_5(array, 24, num));
						Class38.gstruct29_1.int_7 = Class11.smethod_12(smethod_5(array, 25, num));
						Class38.gstruct29_1.uint_3 = Class11.smethod_13(smethod_5(array, 26, num));
						FormMain.int_33 = Class11.smethod_12(smethod_5(array, 27, num));
						FormMain.int_34 = Class11.smethod_12(smethod_5(array, 28, num));
						FormMain.int_21 = Class11.smethod_12(smethod_5(array, 29, num));
						Class38.gstruct29_1.int_9 = Class11.smethod_12(smethod_5(array, 30, num));
						Class38.gstruct29_1.uint_2 = Class11.smethod_13(smethod_5(array, 31, num));
						FormMain.int_85 = Class11.smethod_12(smethod_5(array, 32, num));
						Class38.gstruct29_1.int_8 = Class11.smethod_12(smethod_5(array, 33, num));
						Class38.gstruct29_0.int_8 = Class38.gstruct29_1.int_8;
						FormMain.int_44[0] = Class11.smethod_12(smethod_5(array, 35, num));
						FormMain.int_44[1] = Class11.smethod_12(smethod_5(array, 36, num));
						FormMain.int_0 = Class11.smethod_12(smethod_5(array, 37, num));
						Class31.int_1 = Class11.smethod_12(smethod_5(array, 38, num));
						FormMain.int_99 = Class11.smethod_12(smethod_5(array, 39, num));
						FormMain.int_103 = Class11.smethod_12(smethod_5(array, 40, num));
						FormMain.int_79 = Class11.smethod_12(smethod_5(array, 41, num));
						FormMain.int_70 = Class11.smethod_12(smethod_5(array, 42, num));
						FormMain.int_107 = Class11.smethod_12(smethod_5(array, 43, num));
						goto IL_0466;
						end_IL_00a3:;
					}
					catch
					{
						goto IL_0466;
					}
				}
			}
			if (Class11.smethod_23(Class38.gstruct29_1.long_1) > 6000L)
			{
				Class58.smethod_0(gstruct42_0, bool_0: false);
				if (Class11.smethod_3(text, "g­êi nµy"))
				{
					Class73.smethod_23(gstruct42_0, "0K..");
					Class60.smethod_55(gstruct42_0, "Switch([[trade]])");
					Thread.Sleep(50);
				}
				Class38.gstruct29_1.int_4 = 0;
				Class38.gstruct29_1.long_1 = Class11.smethod_22();
			}
		}
		else
		{
			Class38.gstruct29_1.int_4 = 0;
			Class38.gstruct29_1.int_0 = 0;
			Class38.gstruct29_1.int_6 = 0;
		}
		return;
		IL_0466:
		Class38.gstruct29_1.long_1 = Class11.smethod_22();
	}

	public FormMayphu()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void FormMayphu_Load(object sender, EventArgs e)
	{
		if (int_2 >= 0 && int_3 >= 0)
		{
			int num = int_2 - base.Width - 10;
			int num2 = int_3 - base.Height - 10;
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
		listView1.Items.Clear();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (string_0[i] != null && string_0[i] != string.Empty)
				{
					smethod_3(ref listView1, Class10.smethod_1(string_0[i], 1));
				}
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	public static void smethod_3(ref ListView listView_0, string string_4)
	{
		if (string_4 != null)
		{
			ListViewItem listViewItem = new ListViewItem((listView_0.Items.Count + 1).ToString());
			ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, string_4);
			listViewItem.SubItems.Add(item);
			listView_0.Items.Add(listViewItem);
		}
	}

	private int method_0(ListView listView_0)
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

	private void comboBoxThemAcc_DropDown(object sender, EventArgs e)
	{
		string_3 = null;
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				Class86.smethod_24(FormMain.gstruct42_0[i], ref string_3, 1);
			}
		}
		comboBoxThemAcc.Items.Clear();
		if (string_3 != null)
		{
			Array.Sort(string_3);
			for (int i = 0; i < string_3.Length; i++)
			{
				comboBoxThemAcc.Items.Add(Class10.smethod_1(string_3[i], 1));
			}
		}
		comboBoxThemAcc.Items.Add(string.Empty);
	}

	private void buttonThemAcc_Click(object sender, EventArgs e)
	{
		string text = comboBoxThemAcc.Text;
		if (listView1.Items.Count > 0)
		{
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				if (text == listView1.Items[i].SubItems[1].Text)
				{
					comboBoxThemAcc.Items.Clear();
					comboBoxThemAcc.Text = "";
					return;
				}
			}
		}
		if (string_3 != null)
		{
			for (int i = 0; i < string_3.Length; i++)
			{
				if (text == Class10.smethod_1(string_3[i], 1))
				{
					text = string_3[i];
					break;
				}
			}
		}
		Class11.smethod_24(ref string_0, text);
		smethod_3(ref listView1, text);
		comboBoxThemAcc.Items.Clear();
		comboBoxThemAcc.Text = "";
		smethod_4();
	}

	private void buttonXoaAcc_Click(object sender, EventArgs e)
	{
		int num = method_0(listView1);
		if (num < 0 || num > listView1.Items.Count - 1)
		{
			return;
		}
		string text = listView1.Items[num].SubItems[1].Text;
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (text == Class10.smethod_1(string_0[i], 1))
				{
					Class11.smethod_25(ref string_0, string_0[i]);
					break;
				}
			}
		}
		listView1.Items.RemoveAt(num);
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
		}
		smethod_4();
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	private static void smethod_4()
	{
		string text = string.Empty;
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (text != string.Empty)
				{
					text += "|";
				}
				text += string_0[i];
			}
			text = Class11.smethod_17(text);
		}
		Class11.smethod_29(Class47.string_11, text, 1);
	}

	private static string smethod_5(string[] string_4, int int_6, int int_7 = 0)
	{
		if ((int_7 <= 0 || int_7 > int_6) && string_4 != null && string_4.Length > int_6)
		{
			return string_4[int_6];
		}
		return string.Empty;
	}

	public static int smethod_6(GStruct42 gstruct42_0, ref long long_0, ref int int_6, ref uint[] uint_0)
	{
		FormMain.int_106 = 0;
		if (!Class11.smethod_57(Class38.gstruct29_1.uint_4))
		{
			return 1;
		}
		int num = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
		if (Class89.smethod_0(num))
		{
			uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
			uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num5 = num4 + num3 * Class47.gstruct43_15.uint_0;
			int num6 = (int)Class20.smethod_30(num5 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			int num7 = (int)Class20.smethod_30(num5 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
			int num8 = Class73.smethod_40(gstruct42_0);
			if (num6 != 10 && num6 != 21 && num7 != 0 && num8 > 1)
			{
				uint[] array = new uint[2]
				{
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				Class20.smethod_30(num5 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
				if (num == Class38.gstruct29_1.int_4)
				{
					long num9 = Class53.smethod_18(array, Class38.gstruct29_1.uint_4);
					if (num9 > FormMain.int_23 * FormMain.int_23)
					{
						int int_7 = 0;
						int int_8 = gstruct42_0.int_130;
						uint uint_ = num5 + Class47.gstruct43_72.uint_0;
						byte[] byte_ = new byte[4];
						Class20.WriteProcessMemory(int_8, uint_, byte_, 4, ref int_7);
						if (num9 > FormMain.int_95 * FormMain.int_95)
						{
							bool flag = Class20.smethod_30(num5 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) != 0;
							if (gstruct42_0.bool_64 && !flag)
							{
								Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
								Thread.Sleep(300);
							}
						}
						if (int_6 > 6)
						{
							bool flag2 = uint_0 != null && Class53.smethod_18(uint_0, array) < 180000L;
							uint_0 = null;
							int_6 = 0;
							if (flag2)
							{
								int int_9 = 0;
								int int_10 = gstruct42_0.int_130;
								uint uint_2 = num5 + Class47.gstruct43_72.uint_0;
								byte_ = new byte[4];
								Class20.WriteProcessMemory(int_10, uint_2, byte_, 4, ref int_9);
								Class53.smethod_0(gstruct42_0, array, Class38.gstruct29_1.uint_4, 600);
								return -1;
							}
						}
						if (num9 < 810000L)
						{
							Class12.smethod_3(gstruct42_0, bool_0: false);
							Class60.smethod_61(gstruct42_0, Class38.gstruct29_1.uint_4);
							Thread.Sleep(100);
							return -1;
						}
						if (!Class12.smethod_4(gstruct42_0) || Class11.smethod_23(long_0) > 3000L)
						{
							int_6++;
							Class12.smethod_1(gstruct42_0, Class38.gstruct29_1.uint_4);
							long_0 = Class11.smethod_22();
						}
						return -1;
					}
					Class12.smethod_3(gstruct42_0, bool_0: false);
					if (num9 > 20000L)
					{
						Class60.smethod_61(gstruct42_0, Class38.gstruct29_1.uint_4);
						Thread.Sleep(100);
					}
					int_6 = 0;
					uint_0 = null;
					return 3;
				}
				if (!Class89.smethod_0(Class38.gstruct29_1.int_4))
				{
					return 1;
				}
				array = new uint[2]
				{
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				uint[] array2 = Class89.smethod_1(num, array, Class38.gstruct29_1.int_4, Class38.gstruct29_1.uint_4);
				if (array2 != null)
				{
					int int_9 = 0;
					int int_11 = gstruct42_0.int_130;
					uint uint_3 = num5 + Class47.gstruct43_72.uint_0;
					byte[] byte_ = new byte[4];
					Class20.WriteProcessMemory(int_11, uint_3, byte_, 4, ref int_9);
					uint[] array3 = new uint[2]
					{
						array2[0],
						array2[1]
					};
					int num10 = (int)array2[2];
					long num11 = Class53.smethod_18(array, array3);
					if (num11 >= 90000L)
					{
						bool flag = Class20.smethod_30(num5 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) != 0;
						if (gstruct42_0.bool_64 && !flag)
						{
							Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
							Thread.Sleep(300);
						}
						if (uint_0 == null)
						{
							uint_0 = new uint[2]
							{
								array[0],
								array[1]
							};
							int_6 = 0;
						}
						if (int_6 > 6)
						{
							bool flag2 = uint_0 != null && Class53.smethod_18(uint_0, array) < 180000L;
							uint_0 = null;
							int_6 = 0;
							if (flag2)
							{
								Class53.smethod_0(gstruct42_0, array, Class38.gstruct29_1.uint_4, 600);
								return -1;
							}
						}
						if (!Class12.smethod_4(gstruct42_0) || Class11.smethod_23(long_0) > 3000L)
						{
							int_6++;
							Class12.smethod_1(gstruct42_0, array3);
							long_0 = Class11.smethod_22();
						}
						return -1;
					}
					int_6 = 0;
					uint_0 = null;
					for (int i = 0; i < 10; i++)
					{
						array = new uint[2]
						{
							Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						long num9 = Class53.smethod_18(array, array3);
						if (num9 < 11500L || Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130) != num)
						{
							break;
						}
						Class60.smethod_61(gstruct42_0, array3);
						Thread.Sleep(300);
					}
					for (int j = 0; j < 5; j++)
					{
						Class53.smethod_25(gstruct42_0, num10);
						Thread.Sleep(300);
						uint num12 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
						if (num12 != num)
						{
							break;
						}
					}
				}
				return -1;
			}
			return 1;
		}
		return 1;
	}

	public static int smethod_7(GStruct42 gstruct42_0, ref long long_0, ref int int_6, ref uint[] uint_0)
	{
		if (!Class11.smethod_57(Class38.gstruct29_1.uint_4))
		{
			return 1;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		int num5 = (int)Class20.smethod_30(num4 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
		int num6 = (int)Class20.smethod_30(num4 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
		int num7 = Class73.smethod_40(gstruct42_0);
		if (num5 != 10 && num5 != 21 && num6 != 0 && num7 > 1)
		{
			int num8 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
			if (num8 != Class38.gstruct29_1.int_4)
			{
				return 1;
			}
			int num9 = (int)Class20.smethod_30(num4 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
			if (num9 > 0 && (num9 <= 0 || Class38.gstruct29_1.int_3 > 0))
			{
				uint[] array = new uint[2]
				{
					Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				long num10 = Class53.smethod_18(array, Class38.gstruct29_1.uint_4);
				if (num10 <= FormMain.int_23 * FormMain.int_23)
				{
					Class12.smethod_3(gstruct42_0, bool_0: false);
					if (num10 > 20000L)
					{
						Class60.smethod_61(gstruct42_0, Class38.gstruct29_1.uint_4);
						Thread.Sleep(110);
					}
					int_6 = 0;
					uint_0 = null;
					return 3;
				}
				int int_7 = 0;
				int int_8 = gstruct42_0.int_130;
				uint uint_ = num4 + Class47.gstruct43_72.uint_0;
				byte[] byte_ = new byte[4];
				Class20.WriteProcessMemory(int_8, uint_, byte_, 4, ref int_7);
				if (num10 > FormMain.int_95 * FormMain.int_95)
				{
					bool flag = Class20.smethod_30(num4 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) != 0;
					if (gstruct42_0.bool_64 && !flag)
					{
						Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
						Thread.Sleep(300);
					}
				}
				if (uint_0 == null)
				{
					uint_0 = new uint[2]
					{
						array[0],
						array[1]
					};
					int_6 = 0;
				}
				if (int_6 > 6)
				{
					bool flag2 = uint_0 != null && Class53.smethod_18(uint_0, array) < 180000L;
					uint_0 = null;
					int_6 = 0;
					if (flag2)
					{
						Class53.smethod_0(gstruct42_0, array, Class38.gstruct29_1.uint_4, 600);
						return -1;
					}
				}
				if (num10 < 810000L)
				{
					Class12.smethod_3(gstruct42_0, bool_0: false);
					Class60.smethod_61(gstruct42_0, Class38.gstruct29_1.uint_4);
					Thread.Sleep(100);
					return -1;
				}
				if (!Class12.smethod_4(gstruct42_0) || Class11.smethod_23(long_0) > 3000L)
				{
					int_6++;
					Class12.smethod_1(gstruct42_0, Class38.gstruct29_1.uint_4);
					long_0 = Class11.smethod_22();
				}
				return -1;
			}
			return 1;
		}
		return 1;
	}

	public static int smethod_8(GStruct42 gstruct42_0, ref bool bool_4, ref long long_0, ref int int_6, ref uint[] uint_0)
	{
		uint num4;
		int num20;
		uint[] uint_4;
		uint[] uint_5;
		GStruct22 gStruct;
		int num8;
		byte[] byte_;
		uint[] array;
		if (Class11.smethod_57(Class38.gstruct29_1.uint_4))
		{
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
			int num5 = (int)Class20.smethod_30(num4 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			int num6 = (int)Class20.smethod_30(num4 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
			int num7 = Class73.smethod_40(gstruct42_0);
			if (num5 != 10 && num5 != 21 && num6 != 0 && num7 > 1)
			{
				array = new uint[2]
				{
					Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				num8 = (int)Class20.smethod_30(num4 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
				int num9 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
				if (num9 == Class38.gstruct29_1.int_4)
				{
					bool flag = Class50.smethod_0(num9) != null || Class50.smethod_2(num9) > 0;
					if (num8 > 0 && flag && Class38.gstruct29_1.int_3 <= 0)
					{
						return 3;
					}
					long num10 = Class53.smethod_18(array, Class38.gstruct29_1.uint_4);
					if (num10 <= FormMain.int_23 * FormMain.int_23)
					{
						Class12.smethod_3(gstruct42_0, bool_0: false);
						if (num10 > 20000L)
						{
							Class60.smethod_61(gstruct42_0, Class38.gstruct29_1.uint_4);
							Thread.Sleep(100);
						}
						int_6 = 0;
						uint_0 = null;
						return 4;
					}
					if (num9 == 336)
					{
						int num11 = 0;
						int num12 = 0;
						long num13 = Class53.smethod_21(Class36.uint_0, array);
						long num14 = Class53.smethod_21(Class36.uint_1, array);
						if (num13 < num14)
						{
							num11 = 1;
						}
						num13 = Class53.smethod_21(Class36.uint_0, Class38.gstruct29_1.uint_4);
						num14 = Class53.smethod_21(Class36.uint_1, Class38.gstruct29_1.uint_4);
						if (num13 < num14)
						{
							num12 = 1;
						}
						if (num11 != num12)
						{
							return 5;
						}
					}
					int int_7 = 0;
					int int_8 = gstruct42_0.int_130;
					uint uint_ = num4 + Class47.gstruct43_72.uint_0;
					byte_ = new byte[4];
					Class20.WriteProcessMemory(int_8, uint_, byte_, 4, ref int_7);
					if (uint_0 == null)
					{
						uint_0 = new uint[2]
						{
							array[0],
							array[1]
						};
						int_6 = 0;
					}
					if (int_6 > 6)
					{
						bool flag2 = uint_0 != null && Class53.smethod_18(uint_0, array) < 180000L;
						uint_0 = null;
						int_6 = 0;
						if (flag2)
						{
							Class53.smethod_0(gstruct42_0, array, Class38.gstruct29_1.uint_4, 600);
							return -1;
						}
					}
					if (num10 > FormMain.int_95 * FormMain.int_95)
					{
						bool flag3 = Class20.smethod_30(num4 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) != 0;
						if (gstruct42_0.bool_64 && !flag3)
						{
							Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
							Thread.Sleep(300);
						}
					}
					if (num10 < 22500L)
					{
						Class12.smethod_3(gstruct42_0, bool_0: false);
						return 4;
					}
					if (num10 >= 810000L)
					{
						int[] array2 = Class53.smethod_7(num9);
						if (array2 != null && num8 > 0 && Class38.gstruct29_1.int_3 <= 0)
						{
							if (gstruct42_0.bool_63 && Class31.smethod_61(gstruct42_0, Class38.gstruct29_1.int_4, null, Class38.gstruct29_1.uint_4))
							{
								return -2;
							}
							if (Class53.smethod_13(gstruct42_0))
							{
								return -2;
							}
						}
						if (bool_4 && !flag && num8 > 0 && array2 != null && array2[1] == 0 && Class38.gstruct29_1.int_3 > 0)
						{
							bool_4 = false;
							uint[] uint_2 = null;
							if (Class38.gstruct29_1.int_4 == num9)
							{
								uint_2 = Class38.gstruct29_1.uint_4;
							}
							if (Class44.smethod_2(gstruct42_0, "®iÓm cò", uint_2) > 0)
							{
								Class53.smethod_9(gstruct42_0);
								return -2;
							}
						}
						int num15 = -1;
						long num16 = 0L;
						uint[,] array3 = null;
						uint[] array4 = null;
						if (Class38.gstruct29_1.int_3 > 0)
						{
							uint[] array5 = Class37.smethod_9(Class38.gstruct29_1.uint_4, num9, "NGOAITHANH");
							if (array5 != null)
							{
								long num17 = Class53.smethod_18(Class38.gstruct29_1.uint_4, array5);
								if (num17 <= 100000000L)
								{
									array3 = Class44.smethod_1(num9, array, array5);
									if (array3 != null)
									{
										num15 = Class53.smethod_20(array3, array5);
										if (num15 >= 0)
										{
											array4 = new uint[2]
											{
												array3[num15, 0],
												array3[num15, 1]
											};
											num16 = Class53.smethod_18(array, array4);
											if (num16 > 500000L)
											{
												Class12.smethod_3(gstruct42_0, bool_0: false);
												Class53.smethod_22(gstruct42_0, array3, array, array5, num9, bool_0: true, 8000);
												num8 = (int)Class20.smethod_30(num4 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
												if (num8 <= 0)
												{
													return -1;
												}
											}
										}
									}
								}
							}
						}
						else
						{
							array3 = Class44.smethod_1(num9, array, Class38.gstruct29_1.uint_4);
							if (array3 != null)
							{
								num15 = Class53.smethod_20(array3, Class38.gstruct29_1.uint_4);
								if (num15 >= 0)
								{
									array4 = new uint[2]
									{
										array3[num15, 0],
										array3[num15, 1]
									};
									num16 = Class53.smethod_18(array, array4);
									num8 = (int)Class20.smethod_30(num4 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
									if (num16 >= 90000L && num8 <= 0)
									{
										Class12.smethod_3(gstruct42_0, bool_0: false);
										Class53.smethod_22(gstruct42_0, array3, array, Class38.gstruct29_1.uint_4, num9, bool_0: true, 8000);
										return -1;
									}
								}
							}
						}
						if (num9 == 53 && Class38.gstruct29_1.int_4 == 53 && num8 <= 0)
						{
							uint[] array6 = Class38.gstruct29_1.uint_4;
							if (Class74.gstruct17_0 == null)
							{
								Class74.gstruct17_0 = Class74.smethod_1();
							}
							if (Class38.gstruct29_1.int_3 > 0)
							{
								array6 = Class74.smethod_0(array6);
							}
							uint[,] uint_3 = Class37.smethod_8(Class74.gstruct17_0, array, array6);
							uint[] array7 = array;
							int num18 = Class53.smethod_22(gstruct42_0, uint_3, array, array6, 53, bool_0: true, 8000);
							array = new uint[2]
							{
								Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
								Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
							};
							if (array7 != null && num18 > 0 && (array7[0] != array[0] || array7[1] != array[1]))
							{
								return -3;
							}
						}
						if (!Class12.smethod_4(gstruct42_0) || Class11.smethod_23(long_0) > 4000L)
						{
							int_6++;
							Class12.smethod_1(gstruct42_0, Class38.gstruct29_1.uint_4);
							Thread.Sleep(600);
							long_0 = Class11.smethod_22();
						}
						return -3;
					}
					Class12.smethod_3(gstruct42_0, bool_0: false);
					Class60.smethod_61(gstruct42_0, Class38.gstruct29_1.uint_4);
					Thread.Sleep(100);
					return 2;
				}
				if (Class38.gstruct29_1.int_4 != 959 && Class38.gstruct29_1.int_4 != 990)
				{
					if (num9 == 221 && Class17.smethod_0(gstruct42_0) > 0)
					{
						return -5;
					}
					num9 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
					if (num9 != 959 && num9 != 990)
					{
						array = new uint[2]
						{
							Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						gStruct = default(GStruct22);
						int num19 = 0;
						num20 = 0;
						uint_4 = null;
						uint_5 = null;
						if (num9 != 336 && Class38.gstruct29_1.int_4 == 341)
						{
							long num13 = Class53.smethod_21(Class36.uint_0, array);
							long num14 = Class53.smethod_21(Class36.uint_1, array);
							if (num13 > num14)
							{
								return 6;
							}
							gStruct = Class37.smethod_3(num9, Class38.gstruct29_1.int_4);
						}
						else
						{
							if (num9 == 175 || num9 == 195)
							{
								string text = "Tèng Kim Chiªu th|Phong V©n Chiªu­ th";
								if (Class60.smethod_42(gstruct42_0, text))
								{
									Thread.Sleep(300);
									Class76.smethod_6(gstruct42_0, 0);
									return -6;
								}
							}
							if (num9 == 175)
							{
								gStruct = Class37.smethod_3(num9, 195);
							}
							else
							{
								if (Class38.gstruct29_1.int_4 == 977)
								{
									Thread.Sleep(300);
									if (num8 > 0)
									{
										if (Class53.smethod_13(gstruct42_0))
										{
											return -6;
										}
										if (Class31.smethod_61(gstruct42_0, 11, "®«ng|§«ng"))
										{
											Class31.smethod_61(gstruct42_0, 11, "®«ng|§«ng", null, bool_1: true);
											return -6;
										}
									}
									int[] array8 = Class53.smethod_7(num9);
									if (array8 != null)
									{
										int num21 = Class53.smethod_20(Class37.uint_0, Class38.gstruct29_1.uint_4) + 1;
										Class44.smethod_2(gstruct42_0, "B¶n ®å Ho¹t|KÝch sè " + num21);
										return -6;
									}
									if (Class50.smethod_1(num9) != null)
									{
										Class44.smethod_5(gstruct42_0, 11);
										Thread.Sleep(600);
										int int_9 = 0;
										byte[] array9 = new byte[4];
										Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_27.uint_0, array9, 4, ref int_9);
										int num22 = BitConverter.ToInt32(array9, 0);
										if (num22 != num9)
										{
											int num23 = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
											if (0 <= num23)
											{
												FormMain.gstruct42_0[num23].bool_29 = true;
											}
										}
									}
									return -6;
								}
								if (Class37.smethod_0(num9) && !Class37.smethod_0(Class38.gstruct29_1.int_4))
								{
									int num24 = 11;
									int[] array10 = Class53.smethod_7(Class38.gstruct29_1.int_4);
									if (array10 != null)
									{
										num24 = Class53.int_0[array10[0], 0];
									}
									Class44.smethod_5(gstruct42_0, num24);
									return -9;
								}
								if (FormMain.int_22 <= 0 && Class38.gstruct29_1.int_3 <= 0)
								{
									return 7;
								}
								if (num8 > 0 && Class38.gstruct29_1.int_3 <= 0)
								{
									gStruct = Class37.smethod_3(num9, Class38.gstruct29_1.int_4);
									if (gStruct.int_0 != num9 || gStruct.int_1 != Class38.gstruct29_1.int_4)
									{
										if (Class11.smethod_2(Class38.gstruct29_1.string_1, "Õn thuyÒ") <= 0)
										{
											if (FormMain.int_80 > 0 && num9 != 195)
											{
												if (gstruct42_0.bool_63 && Class31.smethod_61(gstruct42_0, Class38.gstruct29_1.int_4, null, Class38.gstruct29_1.uint_4))
												{
													return -7;
												}
												if (Class53.smethod_13(gstruct42_0))
												{
													return -8;
												}
											}
											if (gstruct42_0.bool_63 && Class31.smethod_61(gstruct42_0, Class38.gstruct29_1.int_4, null, Class38.gstruct29_1.uint_4))
											{
												if (num9 == 195 || num9 == 195)
												{
													try
													{
														int num23 = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
														if (0 <= num23)
														{
															FormMain.gstruct42_0[num23].bool_29 = true;
														}
													}
													catch
													{
													}
												}
												return -7;
											}
											if (num9 != 195)
											{
												if (Class53.smethod_13(gstruct42_0))
												{
													Thread.Sleep(300);
													Class53.smethod_9(gstruct42_0);
													Thread.Sleep(600);
													int num22 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
													if (num22 != num9)
													{
														return -9;
													}
												}
												string text = "Tèng Kim Chiªu th|Phong V©n Chiªu­ th";
												if (Class60.smethod_42(gstruct42_0, text))
												{
													Thread.Sleep(300);
													Class76.smethod_6(gstruct42_0, 0);
													return -6;
												}
												return -8;
											}
											return 9;
										}
										return 8;
									}
								}
								else
								{
									if (num8 <= 0 && Class38.gstruct29_1.int_3 <= 0)
									{
										if (gstruct42_0.bool_63 && Class31.smethod_61(gstruct42_0, Class38.gstruct29_1.int_4, null, Class38.gstruct29_1.uint_4))
										{
											return -7;
										}
										Class44.smethod_5(gstruct42_0, Class38.gstruct29_1.int_4);
										return -9;
									}
									if (num8 == 0 && Class38.gstruct29_1.int_3 > 0)
									{
										gStruct = Class37.smethod_3(num9, Class38.gstruct29_1.int_4);
										if (gStruct.int_0 != num9 || gStruct.int_1 != Class38.gstruct29_1.int_4)
										{
											if (FormMain.int_80 > 0 || !gstruct42_0.bool_63)
											{
												if (bool_4)
												{
													bool_4 = false;
													uint[] uint_2 = null;
													if (FormMain.int_21 > 0 && Class38.gstruct29_1.int_0 > 0 && Class38.gstruct29_1.int_4 == num9)
													{
														uint_2 = Class38.gstruct29_1.uint_4;
													}
													if (Class44.smethod_2(gstruct42_0, "®iÓm cò", uint_2) > 0)
													{
														Class53.smethod_9(gstruct42_0);
														goto IL_11fb;
													}
												}
												if (Class44.smethod_4(gstruct42_0, Class38.gstruct29_1.int_4) > 0)
												{
													Thread.Sleep(300);
													Class53.smethod_9(gstruct42_0);
													Thread.Sleep(600);
													int num22 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
													if (num22 != num9)
													{
														goto IL_11fb;
													}
												}
											}
											bool flag4 = Class38.gstruct29_1.int_4 == 181;
											if (gstruct42_0.bool_63 && !flag4)
											{
												int num24 = Class38.gstruct29_1.int_4;
												int num25 = Class31.smethod_58(num24);
												if (num25 < 0 && Class38.gstruct29_1.int_4 == 76)
												{
													num24 = 75;
													num25 = Class31.smethod_58(75);
												}
												if (0 <= num25 && Class31.smethod_61(gstruct42_0, num24))
												{
													Thread.Sleep(300);
													Class53.smethod_9(gstruct42_0);
													Thread.Sleep(600);
													int num22 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
													if (num22 != num9)
													{
														goto IL_11fb;
													}
												}
												else if (num9 != 103 && num9 != 114 && num9 != 110 && (Class38.gstruct29_1.int_4 == 110 || Class38.gstruct29_1.int_4 == 114) && Class31.smethod_61(gstruct42_0, 103))
												{
													Thread.Sleep(300);
													Class53.smethod_9(gstruct42_0);
													Thread.Sleep(600);
													int num22 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
													if (num22 != num9)
													{
														goto IL_11fb;
													}
												}
											}
											int[] array8 = Class53.smethod_7(num9);
											if (array8 == null && Class38.gstruct29_1.int_4 > 0 && Class50.smethod_1(num9) != null && Class50.smethod_0(Class38.gstruct29_1.int_4) == null)
											{
												Class44.smethod_5(gstruct42_0, 11);
												Thread.Sleep(600);
												int num22 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
												if (num22 != num9)
												{
													int num23 = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
													if (0 <= num23)
													{
														FormMain.gstruct42_0[num23].bool_29 = true;
													}
													goto IL_11fb;
												}
											}
											bool flag5 = false;
											if (Class38.gstruct29_1.int_4 != 959 && Class38.gstruct29_1.int_4 != 990)
											{
												if (Class38.gstruct29_1.int_4 != 181)
												{
													if (Class38.gstruct29_1.int_4 == 224)
													{
														Class44.smethod_2(gstruct42_0, "h÷ng n¬i ®· ®i q|Sa M¹c");
														flag5 = true;
													}
													else if (Class38.gstruct29_1.int_4 == 993)
													{
														Class44.smethod_2(gstruct42_0, "NguyÖt Ca");
														flag5 = true;
													}
													else
													{
														Class44.smethod_4(gstruct42_0, Class38.gstruct29_1.int_4);
														flag5 = true;
													}
												}
												else
												{
													Class44.smethod_2(gstruct42_0, "h÷ng n¬i ®· ®i q|L­ìng Thñy|" + Class38.gstruct29_1.string_1);
													flag5 = true;
												}
											}
											else
											{
												Class44.smethod_2(gstruct42_0, "ChiÕn Long|H\u00b8i Qu¶ H|L­ìng Thñy ");
												flag5 = true;
											}
											if (flag5)
											{
												Thread.Sleep(150);
												Class53.smethod_9(gstruct42_0);
												int num18 = 0;
												while (num18 < 8)
												{
													int num22 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
													if (num22 == num9)
													{
														num18++;
														Thread.Sleep(100);
														continue;
													}
													goto IL_11fb;
												}
											}
											int num26 = -1;
											if (FormMain.int_19 > 0)
											{
												num26 = Class37.smethod_2(Class38.gstruct29_1.int_4);
											}
											if (num26 < 0)
											{
												num19 = Class53.smethod_5(num9, Class38.gstruct29_1.int_4, ref gStruct);
												if (num19 == 0)
												{
													goto IL_1390;
												}
												if (num19 > 0)
												{
													Class44.smethod_5(gstruct42_0, num19);
													goto IL_11fb;
												}
											}
											return -9;
										}
									}
									else
									{
										if (gstruct42_0.bool_63 && Class31.smethod_61(gstruct42_0, Class38.gstruct29_1.int_4))
										{
											Thread.Sleep(300);
											Class53.smethod_9(gstruct42_0);
											Thread.Sleep(600);
											int num22 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
											if (num22 != num9)
											{
												return -7;
											}
										}
										gStruct = Class37.smethod_3(num9, Class38.gstruct29_1.int_4);
										if (gStruct.int_0 != num9 || gStruct.int_1 != Class38.gstruct29_1.int_4)
										{
											num19 = Class53.smethod_5(num9, Class38.gstruct29_1.int_4, ref gStruct);
											if (num19 != 0)
											{
												bool_4 = false;
												if (num19 > 0)
												{
													if (num9 == 336)
													{
														long num13 = Class53.smethod_21(Class36.uint_0, array);
														long num14 = Class53.smethod_21(Class36.uint_1, array);
														if (num13 > num14)
														{
															gStruct = Class37.smethod_3(num9, 121);
															goto IL_1390;
														}
													}
													if (Class53.smethod_13(gstruct42_0))
													{
														Thread.Sleep(300);
														Class53.smethod_9(gstruct42_0);
														Thread.Sleep(600);
														int num22 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
														if (num22 != num9)
														{
															return -8;
														}
													}
												}
												return 1;
											}
										}
									}
								}
							}
						}
						goto IL_1390;
					}
					if (gstruct42_0.bool_63 && Class31.smethod_61(gstruct42_0, Class38.gstruct29_1.int_4, null, Class38.gstruct29_1.uint_4))
					{
						int num27 = 0;
						while (num27 < 10)
						{
							if (Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130) == num9)
							{
								num27++;
								Thread.Sleep(100);
								continue;
							}
							return -5;
						}
					}
					uint[] array11 = Class16.smethod_1(gstruct42_0);
					if (array11 != null)
					{
						int int_9 = 0;
						int int_10 = gstruct42_0.int_130;
						uint uint_6 = num4 + Class47.gstruct43_72.uint_0;
						byte_ = new byte[4];
						Class20.WriteProcessMemory(int_10, uint_6, byte_, 4, ref int_9);
						if (!Class12.smethod_4(gstruct42_0) || Class11.smethod_23(long_0) > 3000L)
						{
							Class12.smethod_1(gstruct42_0, array11);
							long_0 = Class11.smethod_22();
						}
					}
					return -5;
				}
				Class16.smethod_0(gstruct42_0, bool_0: true, bool_1: true);
				return -4;
			}
			return 1;
		}
		return 1;
		IL_1390:
		num8 = (int)Class20.smethod_30(num4 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
		if (num8 > 0)
		{
			bool_4 = true;
		}
		if (gStruct.uint_0 == null)
		{
			if (0 > Class76.Class77.smethod_1(gstruct42_0))
			{
				if (0 <= Class76.Class78.smethod_1(gstruct42_0))
				{
					Class60.smethod_57(gstruct42_0, 0, 1);
				}
			}
			else
			{
				Class60.smethod_57(gstruct42_0, 0, 0);
			}
			return 12;
		}
		int int_11 = 0;
		int int_12 = gstruct42_0.int_130;
		uint uint_7 = num4 + Class47.gstruct43_72.uint_0;
		byte_ = new byte[4];
		Class20.WriteProcessMemory(int_12, uint_7, byte_, 4, ref int_11);
		array = new uint[2]
		{
			Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
			Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
		};
		int num28 = 0;
		if (gStruct.uint_0.GetLength(0) > 1)
		{
			num28 = Class53.smethod_20(gStruct.uint_0, array);
		}
		Class53.smethod_6(gStruct.uint_0, num28, ref uint_4, ref uint_5, ref num20);
		long num29 = Class53.smethod_18(array, uint_4);
		if (num29 > 90000L)
		{
			if (uint_0 == null)
			{
				uint_0 = new uint[2]
				{
					array[0],
					array[1]
				};
				int_6 = 0;
			}
			if (int_6 > 6)
			{
				bool flag2 = uint_0 != null && Class53.smethod_18(uint_0, array) < 180000L;
				uint_0 = null;
				int_6 = 0;
				if (flag2)
				{
					Class53.smethod_0(gstruct42_0, array, uint_4, 600);
					return -1;
				}
			}
			bool flag3;
			if (!(flag3 = (Class20.smethod_30(num4 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) != 0)) && gstruct42_0.bool_64)
			{
				Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
				Thread.Sleep(300);
			}
			if (!Class12.smethod_4(gstruct42_0) || Class11.smethod_23(long_0) > 3000L)
			{
				int_6++;
				Class12.smethod_1(gstruct42_0, uint_4);
				long_0 = Class11.smethod_22();
			}
			return -4;
		}
		int_6 = 0;
		uint_0 = null;
		Class53.smethod_23(gstruct42_0, uint_4, num20, uint_5, gStruct.int_1);
		return -4;
		IL_11fb:
		Class76.smethod_9(gstruct42_0);
		return -9;
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormMayphu));
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		comboBoxThemAcc = new System.Windows.Forms.ComboBox();
		buttonThemAcc = new System.Windows.Forms.Button();
		buttonXoaAcc = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		label1 = new System.Windows.Forms.Label();
		buttonClose = new System.Windows.Forms.Button();
		SuspendLayout();
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
		{
			columnHeader_0,
			columnHeader_1
		});
		listView1.ForeColor = System.Drawing.Color.Black;
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(9, 48);
		listView1.MultiSelect = false;
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(265, 243);
		listView1.TabIndex = 2;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "No";
		columnHeader_0.Width = 40;
		columnHeader_1.Text = "Tên nhân vật";
		columnHeader_1.Width = 200;
		comboBoxThemAcc.DropDownWidth = 120;
		comboBoxThemAcc.ForeColor = System.Drawing.Color.Black;
		comboBoxThemAcc.FormattingEnabled = true;
		comboBoxThemAcc.Location = new System.Drawing.Point(9, 299);
		comboBoxThemAcc.Name = "comboBoxThemAcc";
		comboBoxThemAcc.Size = new System.Drawing.Size(178, 21);
		comboBoxThemAcc.TabIndex = 63;
		comboBoxThemAcc.DropDown += new System.EventHandler(comboBoxThemAcc_DropDown);
		buttonThemAcc.ForeColor = System.Drawing.Color.Black;
		buttonThemAcc.Location = new System.Drawing.Point(9, 326);
		buttonThemAcc.Name = "buttonThemAcc";
		buttonThemAcc.Size = new System.Drawing.Size(178, 26);
		buttonThemAcc.TabIndex = 64;
		buttonThemAcc.Text = "Thêm tên ac vào danh sách";
		buttonThemAcc.UseVisualStyleBackColor = true;
		buttonThemAcc.Click += new System.EventHandler(buttonThemAcc_Click);
		buttonXoaAcc.ForeColor = System.Drawing.Color.Black;
		buttonXoaAcc.Location = new System.Drawing.Point(193, 297);
		buttonXoaAcc.Name = "buttonXoaAcc";
		buttonXoaAcc.Size = new System.Drawing.Size(79, 23);
		buttonXoaAcc.TabIndex = 65;
		buttonXoaAcc.Text = "Xóa";
		buttonXoaAcc.UseVisualStyleBackColor = true;
		buttonXoaAcc.Click += new System.EventHandler(buttonXoaAcc_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		label1.Location = new System.Drawing.Point(6, 5);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(268, 40);
		label1.TabIndex = 69;
		label1.Text = "Danh sách ac máy phụ cần thông báo, danh sách nếu càng ít thì tốc độ thông báo càng nhanh, do đó ac nào trong danh sách không online thì xóa đi nhé.";
		buttonClose.ForeColor = System.Drawing.Color.Black;
		buttonClose.Location = new System.Drawing.Point(193, 326);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(79, 26);
		buttonClose.TabIndex = 70;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(284, 359);
		base.Controls.Add(buttonClose);
		base.Controls.Add(label1);
		base.Controls.Add(listView1);
		base.Controls.Add(comboBoxThemAcc);
		base.Controls.Add(buttonThemAcc);
		base.Controls.Add(buttonXoaAcc);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormMayphu";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "DANH SACH AC MAY PHU";
		base.Load += new System.EventHandler(FormMayphu_Load);
		ResumeLayout(performLayout: false);
	}
}
