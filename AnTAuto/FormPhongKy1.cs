using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormPhongKy1 : Form
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static int int_4 = 0;

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	public static bool bool_3 = false;

	public static bool bool_4 = false;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Button buttonXoaPk2;

	private Button buttonXoaPk;

	private Label label23;

	private Button buttonStopWritePathPk2;

	private Button buttonWritePathPk2;

	private Button buttonSavePathPk2;

	private Button buttonOpenPathPk2;

	private ListView listViewPk2;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private Button buttonStopWritePathPk;

	private Label label22;

	private Button buttonWritePathPk;

	private ListView listViewPk1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private Button buttonSavePathPk;

	private Button buttonOpenPathPk;

	private Button buttonXoahet1;

	private Button buttonXoahet2;

	public FormPhongKy1()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		if (bool_2 || bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
			if (0 <= num)
			{
				if (FormMain.gstruct42_0[num].string_2 != null)
				{
					Class32.smethod_51(FormMain.gstruct42_0[num], FormMain.gstruct42_0[num].string_2);
				}
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		bool_4 = false;
		bool_0 = false;
	}

	private void FormPhongKy1_Load(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (Class11.bool_0 || num < 0)
		{
			return;
		}
		GStruct42 gStruct = FormMain.gstruct42_0[num];
		if (int_0 >= 0 && int_1 >= 0)
		{
			int num2 = int_0 - base.Width;
			int num3 = int_1 + int_3 - base.Height;
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
		listViewPk1.Items.Clear();
		if (gStruct.uint_2 != null)
		{
			for (int i = 0; i < gStruct.uint_2.GetLength(0); i++)
			{
				method_0(listViewPk1, new uint[2]
				{
					gStruct.uint_2[i, 0],
					gStruct.uint_2[i, 1]
				});
			}
		}
		listViewPk2.Items.Clear();
		if (gStruct.uint_3 != null)
		{
			for (int i = 0; i < gStruct.uint_3.GetLength(0); i++)
			{
				method_0(listViewPk2, new uint[2]
				{
					gStruct.uint_3[i, 0],
					gStruct.uint_3[i, 1]
				});
			}
		}
		buttonStopWritePathPk.Enabled = false;
		buttonStopWritePathPk2.Enabled = false;
		timer_0.Interval = 100;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void method_0(ListView listView_0, uint[] uint_0)
	{
		int num = 0;
		if (listView_0.Items != null)
		{
			num = listView_0.Items.Count;
		}
		string[] array = new string[2]
		{
			num.ToString(),
			uint_0[0].ToString() + "," + uint_0[1].ToString()
		};
		ListViewItem listViewItem = new ListViewItem(array[0]);
		ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[1]);
		listViewItem.SubItems.Add(item);
		listView_0.Items.Add(listViewItem);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (bool_3)
			{
				bool_3 = false;
				if (bool_1)
				{
					method_1();
				}
			}
			if (bool_4)
			{
				bool_4 = false;
				if (bool_2)
				{
					method_2();
				}
			}
		}
		else
		{
			Close();
		}
	}

	private void method_1()
	{
		if (bool_2 || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
		int num2 = Class33.smethod_0(gstruct42_);
		if (num2 != gstruct42_.int_36 && gstruct42_.int_36 > 0)
		{
			listViewPk1.Items.Clear();
			FormMain.gstruct42_0[num].uint_2 = null;
		}
		FormMain.gstruct42_0[num].int_36 = num2;
		uint[] array = Class32.smethod_29(gstruct42_);
		if (gstruct42_.uint_2 != null)
		{
			for (int i = 0; i < gstruct42_.uint_2.GetLength(0); i++)
			{
				if (gstruct42_.uint_2[i, 0] == array[0] && gstruct42_.uint_2[i, 1] == array[1])
				{
					return;
				}
			}
		}
		Class11.smethod_49(ref FormMain.gstruct42_0[num].uint_2, array);
		method_0(listViewPk1, array);
		method_3(listViewPk1, listViewPk1.Items.Count - 1);
		Class47.smethod_11(FormMain.gstruct42_0[num]);
		string string_ = "#" + (FormMain.gstruct42_0[num].uint_2.GetLength(0) - 1) + " (" + array[0] + "," + array[1] + ")";
		Class32.smethod_51(gstruct42_, string_);
	}

	private void method_2()
	{
		if (!bool_2 || bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			return;
		}
		GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
		int num2 = Class33.smethod_0(gstruct42_);
		if (num2 != gstruct42_.int_37 && gstruct42_.int_37 > 0)
		{
			listViewPk2.Items.Clear();
			FormMain.gstruct42_0[num].uint_3 = null;
		}
		FormMain.gstruct42_0[num].int_37 = num2;
		gstruct42_ = FormMain.gstruct42_0[num];
		uint[] array = Class32.smethod_29(gstruct42_);
		if (gstruct42_.uint_3 != null)
		{
			for (int i = 0; i < gstruct42_.uint_3.GetLength(0); i++)
			{
				if (gstruct42_.uint_3[i, 0] == array[0] && gstruct42_.uint_3[i, 1] == array[1])
				{
					return;
				}
			}
		}
		Class11.smethod_49(ref FormMain.gstruct42_0[num].uint_3, array);
		method_0(listViewPk2, array);
		method_3(listViewPk2, listViewPk2.Items.Count - 1);
		Class47.smethod_11(FormMain.gstruct42_0[num]);
		string string_ = "##" + (FormMain.gstruct42_0[num].uint_3.GetLength(0) - 1) + " (" + array[0] + "," + array[1] + ")";
		Class32.smethod_51(gstruct42_, string_);
	}

	private void buttonOpenPathPk_Click(object sender, EventArgs e)
	{
		string text = Class47.string_4 + "\\Toado";
		Class11.smethod_8(text);
		string text2 = Class47.smethod_24(text, "", "*.pxy");
		if (text2 == string.Empty)
		{
			return;
		}
		int num = num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			Close();
			return;
		}
		listViewPk1.Items.Clear();
		string text3 = Class11.smethod_16(Class11.smethod_28(text2, 0, 0, 1));
		if (!(text3 == string.Empty))
		{
			string[] array = text3.Split('|');
			if (array.Length == 2)
			{
				int num2 = Class11.smethod_12(array[0]);
				if (num2 != 0)
				{
					if (num2 < 387 || num2 > 389)
					{
						Class11.smethod_24(ref Class11.string_14, "FORM:Thông báo: Tệp Tọa độ này không phải của map Phong kỳ.");
					}
					FormMain.gstruct42_0[num].int_36 = num2;
					FormMain.gstruct42_0[num].uint_2 = null;
					string[] array2 = array[1].Split(':');
					if (array2 != null && array2.Length > 0)
					{
						FormMain.gstruct42_0[num].uint_2 = new uint[array2.Length, 2];
						for (int i = 0; i < array2.Length; i++)
						{
							string[] array3 = array2[i].Split(';');
							if (array3.Length == 2)
							{
								for (int j = 0; j < 2; j++)
								{
									FormMain.gstruct42_0[num].uint_2[i, j] = Class11.smethod_13(array3[j]);
								}
							}
							method_0(listViewPk1, new uint[2]
							{
								FormMain.gstruct42_0[num].uint_2[i, 0],
								FormMain.gstruct42_0[num].uint_2[i, 1]
							});
						}
					}
					Class57.int_0 = FormMain.gstruct42_0[num].int_129;
					return;
				}
			}
		}
		FormMain.gstruct42_0[num].int_36 = 0;
		FormMain.gstruct42_0[num].uint_2 = null;
		Class57.int_0 = FormMain.gstruct42_0[num].int_129;
	}

	private void buttonOpenPathPk2_Click(object sender, EventArgs e)
	{
		string text = Class47.string_4 + "\\Toado";
		Class11.smethod_8(text);
		string text2 = Class47.smethod_24(text, "", "*.txy");
		if (text2 == string.Empty)
		{
			return;
		}
		int num = num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num >= 0)
		{
			listViewPk2.Items.Clear();
			string text3 = Class11.smethod_16(Class11.smethod_28(text2, 0, 0, 1));
			if (!(text3 == string.Empty))
			{
				string[] array = text3.Split('|');
				if (array.Length == 2)
				{
					int num2 = Class11.smethod_12(array[0]);
					if (num2 != 0)
					{
						if (num2 < 387 || num2 > 389)
						{
							Class11.smethod_24(ref Class11.string_14, "FORM:Thông báo: Tệp Tọa độ này không phải của map Phong kỳ.");
						}
						FormMain.gstruct42_0[num].int_37 = num2;
						FormMain.gstruct42_0[num].uint_3 = null;
						string[] array2 = array[1].Split(':');
						if (array2 != null && array2.Length > 0)
						{
							FormMain.gstruct42_0[num].uint_3 = new uint[array2.Length, 2];
							for (int i = 0; i < array2.Length; i++)
							{
								string[] array3 = array2[i].Split(';');
								if (array3.Length == 2)
								{
									for (int j = 0; j < 2; j++)
									{
										FormMain.gstruct42_0[num].uint_3[i, j] = Class11.smethod_13(array3[j]);
									}
								}
								method_0(listViewPk2, new uint[2]
								{
									FormMain.gstruct42_0[num].uint_3[i, 0],
									FormMain.gstruct42_0[num].uint_3[i, 1]
								});
							}
						}
						Class57.int_0 = FormMain.gstruct42_0[num].int_129;
						return;
					}
				}
			}
			FormMain.gstruct42_0[num].int_37 = 0;
			FormMain.gstruct42_0[num].uint_3 = null;
			Class57.int_0 = FormMain.gstruct42_0[num].int_129;
		}
		else
		{
			Close();
		}
	}

	private void buttonSavePathPk_Click(object sender, EventArgs e)
	{
		int num = num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num >= 0)
		{
			GStruct42 gStruct = FormMain.gstruct42_0[num];
			string text = Class47.string_4 + "\\Toado";
			Class11.smethod_8(text);
			string text2 = Class47.smethod_25(text, Class10.smethod_1(gStruct.string_20, 1) + ".pxy");
			if (text2 == string.Empty)
			{
				return;
			}
			string text3 = string.Empty;
			if (gStruct.uint_2 != null)
			{
				for (int i = 0; i < gStruct.uint_2.GetLength(0); i++)
				{
					if (text3 != string.Empty)
					{
						text3 += ":";
					}
					object obj = text3;
					text3 = string.Concat(obj, gStruct.uint_2[i, 0], ";", gStruct.uint_2[i, 1]);
				}
			}
			string string_ = gStruct.int_36.ToString() + "|" + text3;
			Class11.smethod_29(text2, Class11.smethod_17(string_), 2);
		}
		else
		{
			Close();
		}
	}

	private void buttonSavePathPk2_Click(object sender, EventArgs e)
	{
		int num = num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			Close();
			return;
		}
		GStruct42 gStruct = FormMain.gstruct42_0[num];
		string text = Class47.string_4 + "\\Toado";
		Class11.smethod_8(text);
		string text2 = Class47.smethod_25(text, Class10.smethod_1(gStruct.string_20, 1) + ".txy");
		if (text2 == string.Empty)
		{
			return;
		}
		string text3 = string.Empty;
		if (gStruct.uint_3 != null)
		{
			for (int i = 0; i < gStruct.uint_3.GetLength(0); i++)
			{
				if (text3 != string.Empty)
				{
					text3 += ":";
				}
				object obj = text3;
				text3 = string.Concat(obj, gStruct.uint_3[i, 0], ";", gStruct.uint_3[i, 1]);
			}
		}
		string string_ = gStruct.int_37.ToString() + "|" + text3;
		Class11.smethod_29(text2, Class11.smethod_17(string_), 2);
	}

	private void buttonWritePathPk_Click(object sender, EventArgs e)
	{
		int num = num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			Close();
		}
		else if (!bool_2 && !bool_1)
		{
			bool_1 = true;
			buttonWritePathPk.Enabled = false;
			buttonStopWritePathPk.Enabled = true;
			FormMain.gstruct42_0[num].string_2 = Class32.smethod_50(FormMain.gstruct42_0[num]);
			Class32.smethod_51(FormMain.gstruct42_0[num], "BÊm Space ®Ó ghi ®­êng dÉn");
			GClass0.smethod_1();
			GClass0.smethod_0();
		}
	}

	private void buttonWritePathPk2_Click(object sender, EventArgs e)
	{
		int num = num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num >= 0)
		{
			if (!bool_1 && !bool_2)
			{
				bool_2 = true;
				buttonWritePathPk2.Enabled = false;
				buttonStopWritePathPk2.Enabled = true;
				FormMain.gstruct42_0[num].string_2 = Class32.smethod_50(FormMain.gstruct42_0[num]);
				Class32.smethod_51(FormMain.gstruct42_0[num], "BÊm Space ®Ó ghi to¹ ®é");
				GClass0.smethod_1();
				GClass0.smethod_0();
			}
		}
		else
		{
			Close();
		}
	}

	private void buttonStopWritePathPk_Click(object sender, EventArgs e)
	{
		int num = num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			Close();
			return;
		}
		buttonWritePathPk.Enabled = true;
		buttonStopWritePathPk.Enabled = false;
		if (bool_1 && FormMain.gstruct42_0[num].string_2 != null)
		{
			Class32.smethod_51(FormMain.gstruct42_0[num], FormMain.gstruct42_0[num].string_2);
		}
		bool_1 = false;
	}

	private void buttonStopWritePathPk2_Click(object sender, EventArgs e)
	{
		int num = num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num >= 0)
		{
			buttonWritePathPk2.Enabled = true;
			buttonStopWritePathPk2.Enabled = false;
			if (bool_2 && FormMain.gstruct42_0[num].string_2 != null)
			{
				Class32.smethod_51(FormMain.gstruct42_0[num], FormMain.gstruct42_0[num].string_2);
			}
			bool_2 = false;
		}
		else
		{
			Close();
		}
	}

	private void method_3(ListView listView_0, int int_5 = 0)
	{
		if (listView_0.Items == null)
		{
			return;
		}
		int count = listView_0.Items.Count;
		if (count != 0)
		{
			if (int_5 >= count)
			{
				int_5 = count - 1;
			}
			listView_0.TopItem = listView_0.Items[int_5];
			listView_0.Items[int_5].Focused = true;
			listView_0.Items[int_5].Selected = true;
		}
	}

	private void buttonXoaPk_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			Close();
			return;
		}
		GStruct42 gStruct = FormMain.gstruct42_0[num];
		if (listViewPk1.Items != null && listViewPk1.Items.Count > 0 && gStruct.uint_2 != null && gStruct.uint_2.GetLength(0) != 0)
		{
			int num2 = -1;
			for (int i = 0; i < listViewPk1.Items.Count; i++)
			{
				if (listViewPk1.Items[i].Selected)
				{
					num2 = i;
					break;
				}
			}
			if (num2 < 0)
			{
				return;
			}
			string[] array = listViewPk1.Items[num2].SubItems[1].Text.Split(',');
			if (array.Length < 2)
			{
				return;
			}
			uint num3 = Class11.smethod_13(array[0]);
			uint num4 = Class11.smethod_13(array[1]);
			int num5 = 0;
			uint[,] array2 = new uint[gStruct.uint_2.GetLength(0), 2];
			for (int i = 0; i < gStruct.uint_2.GetLength(0); i++)
			{
				if (gStruct.uint_2[i, 0] != num3 && gStruct.uint_2[i, 1] != num4)
				{
					array2[num5, 0] = gStruct.uint_2[i, 0];
					array2[num5, 1] = gStruct.uint_2[i, 1];
					num5++;
				}
			}
			if (num5 == 0)
			{
				FormMain.gstruct42_0[num].uint_2 = null;
				listViewPk1.Items.Clear();
			}
			else
			{
				if (num5 == gStruct.uint_2.GetLength(0))
				{
					return;
				}
				try
				{
					Class57.int_0 = FormMain.gstruct42_0[num].int_129;
					FormMain.gstruct42_0[num].uint_2 = new uint[num5, 2];
					for (int i = 0; i < num5; i++)
					{
						FormMain.gstruct42_0[num].uint_2[i, 0] = array2[i, 0];
						FormMain.gstruct42_0[num].uint_2[i, 1] = array2[i, 1];
					}
				}
				catch
				{
					num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
					if (num < 0)
					{
						Close();
						return;
					}
				}
				listViewPk1.Items.RemoveAt(num2);
				for (int i = 0; i < listViewPk1.Items.Count; i++)
				{
					listViewPk1.Items[i].SubItems[0].Text = i.ToString();
				}
				if (listViewPk1.Items.Count <= num2)
				{
					if (num2 == 0)
					{
						FormMain.gstruct42_0[num].uint_2 = null;
						listViewPk1.Items.Clear();
						return;
					}
					num2 = listViewPk1.Items.Count - 1;
				}
				method_3(listViewPk1, num2);
			}
		}
		else
		{
			FormMain.gstruct42_0[num].uint_2 = null;
			listViewPk1.Items.Clear();
		}
	}

	private void buttonXoaPk2_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num >= 0)
		{
			GStruct42 gStruct = FormMain.gstruct42_0[num];
			if (listViewPk2.Items != null && listViewPk2.Items.Count > 0 && gStruct.uint_3 != null && gStruct.uint_3.GetLength(0) != 0)
			{
				int num2 = -1;
				for (int i = 0; i < listViewPk2.Items.Count; i++)
				{
					if (listViewPk2.Items[i].Selected)
					{
						num2 = i;
						break;
					}
				}
				if (num2 < 0)
				{
					return;
				}
				string[] array = listViewPk2.Items[num2].SubItems[1].Text.Split(',');
				if (array.Length < 2)
				{
					return;
				}
				uint num3 = Class11.smethod_13(array[0]);
				uint num4 = Class11.smethod_13(array[1]);
				int num5 = 0;
				uint[,] array2 = new uint[gStruct.uint_3.GetLength(0), 2];
				for (int i = 0; i < gStruct.uint_3.GetLength(0); i++)
				{
					if (gStruct.uint_3[i, 0] != num3 && gStruct.uint_3[i, 1] != num4)
					{
						array2[num5, 0] = gStruct.uint_3[i, 0];
						array2[num5, 1] = gStruct.uint_3[i, 1];
						num5++;
					}
				}
				if (num5 != 0)
				{
					if (num5 == gStruct.uint_3.GetLength(0))
					{
						return;
					}
					try
					{
						Class57.int_0 = FormMain.gstruct42_0[num].int_129;
						FormMain.gstruct42_0[num].uint_3 = new uint[num5, 2];
						for (int i = 0; i < num5; i++)
						{
							FormMain.gstruct42_0[num].uint_3[i, 0] = array2[i, 0];
							FormMain.gstruct42_0[num].uint_3[i, 1] = array2[i, 1];
						}
					}
					catch
					{
						num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
						if (num < 0)
						{
							Close();
							return;
						}
					}
					listViewPk2.Items.RemoveAt(num2);
					for (int i = 0; i < listViewPk2.Items.Count; i++)
					{
						listViewPk2.Items[i].SubItems[0].Text = i.ToString();
					}
					if (listViewPk2.Items.Count <= num2)
					{
						if (num2 == 0)
						{
							FormMain.gstruct42_0[num].uint_3 = null;
							listViewPk2.Items.Clear();
							return;
						}
						num2 = listViewPk2.Items.Count - 1;
					}
					method_3(listViewPk2, num2);
				}
				else
				{
					FormMain.gstruct42_0[num].uint_3 = null;
					listViewPk2.Items.Clear();
				}
			}
			else
			{
				FormMain.gstruct42_0[num].uint_3 = null;
				listViewPk2.Items.Clear();
			}
		}
		else
		{
			Close();
		}
	}

	private void buttonXoahet1_Click(object sender, EventArgs e)
	{
		listViewPk1.Items.Clear();
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num >= 0)
		{
			FormMain.gstruct42_0[num].uint_2 = null;
		}
		else
		{
			Close();
		}
	}

	private void buttonXoahet2_Click(object sender, EventArgs e)
	{
		listViewPk2.Items.Clear();
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			Close();
		}
		else
		{
			FormMain.gstruct42_0[num].uint_3 = null;
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormPhongKy1));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonXoaPk2 = new System.Windows.Forms.Button();
		buttonXoaPk = new System.Windows.Forms.Button();
		label23 = new System.Windows.Forms.Label();
		listViewPk2 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		label22 = new System.Windows.Forms.Label();
		listViewPk1 = new System.Windows.Forms.ListView();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		buttonStopWritePathPk2 = new System.Windows.Forms.Button();
		buttonWritePathPk2 = new System.Windows.Forms.Button();
		buttonSavePathPk2 = new System.Windows.Forms.Button();
		buttonOpenPathPk2 = new System.Windows.Forms.Button();
		buttonStopWritePathPk = new System.Windows.Forms.Button();
		buttonWritePathPk = new System.Windows.Forms.Button();
		buttonSavePathPk = new System.Windows.Forms.Button();
		buttonOpenPathPk = new System.Windows.Forms.Button();
		buttonXoahet1 = new System.Windows.Forms.Button();
		buttonXoahet2 = new System.Windows.Forms.Button();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonXoaPk2.Location = new System.Drawing.Point(246, 286);
		buttonXoaPk2.Name = "buttonXoaPk2";
		buttonXoaPk2.Size = new System.Drawing.Size(83, 23);
		buttonXoaPk2.TabIndex = 254;
		buttonXoaPk2.Text = "Xóa";
		buttonXoaPk2.UseVisualStyleBackColor = true;
		buttonXoaPk2.Click += new System.EventHandler(buttonXoaPk2_Click);
		buttonXoaPk.Location = new System.Drawing.Point(82, 286);
		buttonXoaPk.Name = "buttonXoaPk";
		buttonXoaPk.Size = new System.Drawing.Size(85, 23);
		buttonXoaPk.TabIndex = 253;
		buttonXoaPk.Text = "Xóa";
		buttonXoaPk.UseVisualStyleBackColor = true;
		buttonXoaPk.Click += new System.EventHandler(buttonXoaPk_Click);
		label23.AutoSize = true;
		label23.Location = new System.Drawing.Point(8, 9);
		label23.Name = "label23";
		label23.Size = new System.Drawing.Size(113, 13);
		label23.TabIndex = 249;
		label23.Text = "#Đường dẫn ra tọa độ";
		listViewPk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		listViewPk2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
		{
			columnHeader_0,
			columnHeader_1
		});
		listViewPk2.FullRowSelect = true;
		listViewPk2.GridLines = true;
		listViewPk2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		listViewPk2.HideSelection = false;
		listViewPk2.Location = new System.Drawing.Point(175, 55);
		listViewPk2.MultiSelect = false;
		listViewPk2.Name = "listViewPk2";
		listViewPk2.Size = new System.Drawing.Size(155, 228);
		listViewPk2.TabIndex = 246;
		listViewPk2.UseCompatibleStateImageBehavior = false;
		listViewPk2.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "N";
		columnHeader_0.Width = 35;
		columnHeader_1.Text = "Tọa độ";
		columnHeader_1.Width = 95;
		label22.AutoSize = true;
		label22.Location = new System.Drawing.Point(174, 9);
		label22.Name = "label22";
		label22.Size = new System.Drawing.Size(122, 13);
		label22.TabIndex = 247;
		label22.Text = "##Tọa độ điểm trinh sát";
		listViewPk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		listViewPk1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
		{
			columnHeader_2,
			columnHeader_3
		});
		listViewPk1.FullRowSelect = true;
		listViewPk1.GridLines = true;
		listViewPk1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		listViewPk1.HideSelection = false;
		listViewPk1.Location = new System.Drawing.Point(12, 55);
		listViewPk1.MultiSelect = false;
		listViewPk1.Name = "listViewPk1";
		listViewPk1.Size = new System.Drawing.Size(155, 227);
		listViewPk1.TabIndex = 248;
		listViewPk1.UseCompatibleStateImageBehavior = false;
		listViewPk1.View = System.Windows.Forms.View.Details;
		columnHeader_2.Text = "N";
		columnHeader_2.Width = 35;
		columnHeader_3.Text = "Tọa độ";
		columnHeader_3.Width = 95;
		buttonStopWritePathPk2.Image = Class13.Bitmap_3;
		buttonStopWritePathPk2.Location = new System.Drawing.Point(299, 28);
		buttonStopWritePathPk2.Name = "buttonStopWritePathPk2";
		buttonStopWritePathPk2.Size = new System.Drawing.Size(30, 23);
		buttonStopWritePathPk2.TabIndex = 259;
		buttonStopWritePathPk2.UseVisualStyleBackColor = true;
		buttonStopWritePathPk2.Click += new System.EventHandler(buttonStopWritePathPk2_Click);
		buttonWritePathPk2.Image = Class13.Bitmap_2;
		buttonWritePathPk2.Location = new System.Drawing.Point(264, 28);
		buttonWritePathPk2.Name = "buttonWritePathPk2";
		buttonWritePathPk2.Size = new System.Drawing.Size(30, 23);
		buttonWritePathPk2.TabIndex = 258;
		buttonWritePathPk2.UseVisualStyleBackColor = true;
		buttonWritePathPk2.Click += new System.EventHandler(buttonWritePathPk2_Click);
		buttonSavePathPk2.Image = Class13.Bitmap_1;
		buttonSavePathPk2.Location = new System.Drawing.Point(210, 28);
		buttonSavePathPk2.Name = "buttonSavePathPk2";
		buttonSavePathPk2.Size = new System.Drawing.Size(30, 23);
		buttonSavePathPk2.TabIndex = 257;
		buttonSavePathPk2.UseVisualStyleBackColor = true;
		buttonSavePathPk2.Click += new System.EventHandler(buttonSavePathPk2_Click);
		buttonOpenPathPk2.Image = Class13.Bitmap_0;
		buttonOpenPathPk2.Location = new System.Drawing.Point(176, 28);
		buttonOpenPathPk2.Name = "buttonOpenPathPk2";
		buttonOpenPathPk2.Size = new System.Drawing.Size(30, 23);
		buttonOpenPathPk2.TabIndex = 256;
		buttonOpenPathPk2.UseVisualStyleBackColor = true;
		buttonOpenPathPk2.Click += new System.EventHandler(buttonOpenPathPk2_Click);
		//buttonStopWritePathPk.Image = (System.Drawing.Image)componentResourceManager.GetObject("buttonStopWritePathPk.Image");
		buttonStopWritePathPk.Location = new System.Drawing.Point(124, 28);
		buttonStopWritePathPk.Name = "buttonStopWritePathPk";
		buttonStopWritePathPk.Size = new System.Drawing.Size(30, 23);
		buttonStopWritePathPk.TabIndex = 255;
		buttonStopWritePathPk.UseVisualStyleBackColor = true;
		buttonStopWritePathPk.Click += new System.EventHandler(buttonStopWritePathPk_Click);
		//buttonWritePathPk.Image = (System.Drawing.Image)componentResourceManager.GetObject("buttonWritePathPk.Image");
		buttonWritePathPk.Location = new System.Drawing.Point(91, 28);
		buttonWritePathPk.Name = "buttonWritePathPk";
		buttonWritePathPk.Size = new System.Drawing.Size(30, 23);
		buttonWritePathPk.TabIndex = 252;
		buttonWritePathPk.UseVisualStyleBackColor = true;
		buttonWritePathPk.Click += new System.EventHandler(buttonWritePathPk_Click);
		//buttonSavePathPk.Image = (System.Drawing.Image)componentResourceManager.GetObject("buttonSavePathPk.Image");
		buttonSavePathPk.Location = new System.Drawing.Point(46, 28);
		buttonSavePathPk.Name = "buttonSavePathPk";
		buttonSavePathPk.Size = new System.Drawing.Size(30, 23);
		buttonSavePathPk.TabIndex = 251;
		buttonSavePathPk.UseVisualStyleBackColor = true;
		buttonSavePathPk.Click += new System.EventHandler(buttonSavePathPk_Click);
		//buttonOpenPathPk.Image = (System.Drawing.Image)componentResourceManager.GetObject("buttonOpenPathPk.Image");
		buttonOpenPathPk.Location = new System.Drawing.Point(12, 28);
		buttonOpenPathPk.Name = "buttonOpenPathPk";
		buttonOpenPathPk.Size = new System.Drawing.Size(30, 23);
		buttonOpenPathPk.TabIndex = 250;
		buttonOpenPathPk.UseVisualStyleBackColor = true;
		buttonOpenPathPk.Click += new System.EventHandler(buttonOpenPathPk_Click);
		buttonXoahet1.Location = new System.Drawing.Point(12, 286);
		buttonXoahet1.Name = "buttonXoahet1";
		buttonXoahet1.Size = new System.Drawing.Size(64, 23);
		buttonXoahet1.TabIndex = 260;
		buttonXoahet1.Text = "Xóa hết";
		buttonXoahet1.UseVisualStyleBackColor = true;
		buttonXoahet1.Click += new System.EventHandler(buttonXoahet1_Click);
		buttonXoahet2.Location = new System.Drawing.Point(175, 286);
		buttonXoahet2.Name = "buttonXoahet2";
		buttonXoahet2.Size = new System.Drawing.Size(65, 23);
		buttonXoahet2.TabIndex = 261;
		buttonXoahet2.Text = "Xóa hết";
		buttonXoahet2.UseVisualStyleBackColor = true;
		buttonXoahet2.Click += new System.EventHandler(buttonXoahet2_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(334, 315);
		base.Controls.Add(buttonXoahet2);
		base.Controls.Add(buttonXoahet1);
		base.Controls.Add(buttonXoaPk2);
		base.Controls.Add(buttonXoaPk);
		base.Controls.Add(label23);
		base.Controls.Add(buttonStopWritePathPk2);
		base.Controls.Add(buttonWritePathPk2);
		base.Controls.Add(buttonSavePathPk2);
		base.Controls.Add(buttonOpenPathPk2);
		base.Controls.Add(listViewPk2);
		base.Controls.Add(buttonStopWritePathPk);
		base.Controls.Add(label22);
		base.Controls.Add(buttonWritePathPk);
		base.Controls.Add(listViewPk1);
		base.Controls.Add(buttonSavePathPk);
		base.Controls.Add(buttonOpenPathPk);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormPhongKy1";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "TOA DO PHONG KY";
		base.Load += new System.EventHandler(FormPhongKy1_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
