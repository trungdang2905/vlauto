using System.Windows.Forms;

internal class Class71
{
	public static int smethod_0(ref GStruct42[] gstruct42_0, GStruct42 gstruct42_1)
	{
		if (gstruct42_0 != null && gstruct42_0.Length != 0)
		{
			GStruct42[] array = new GStruct42[gstruct42_0.Length + 1];
			int num = 0;
			while (true)
			{
				if (num < gstruct42_0.Length)
				{
					if (gstruct42_1.int_129 == gstruct42_0[num].int_129)
					{
						break;
					}
					array[num] = gstruct42_0[num];
					num++;
					continue;
				}
				int num2 = array.Length - 1;
				array[num2] = gstruct42_1;
				gstruct42_0 = array;
				return num2;
			}
			gstruct42_0[num] = gstruct42_1;
			return num;
		}
		gstruct42_0 = new GStruct42[1]
		{
			gstruct42_1
		};
		return 0;
	}

	public static bool smethod_1(ref GStruct42[] gstruct42_0, GStruct42 gstruct42_1)
	{
		if (gstruct42_0 != null && gstruct42_0.Length != 0)
		{
			GStruct42[] array = new GStruct42[gstruct42_0.Length];
			int num = 0;
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				if (gstruct42_1.int_129 != gstruct42_0[i].int_129)
				{
					array[num] = gstruct42_0[i];
					num++;
				}
			}
			if (num == 0)
			{
				gstruct42_0 = null;
				return true;
			}
			if (num == gstruct42_0.Length)
			{
				return false;
			}
			GStruct42[] array2 = new GStruct42[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = array[i];
			}
			gstruct42_0 = array2;
			return true;
		}
		gstruct42_0 = null;
		return true;
	}

	public static int smethod_2(ListView listView_0, int int_0, GStruct42[] gstruct42_0)
	{
		if (int_0 >= 0 && listView_0.Items.Count > int_0)
		{
			int num = Class11.smethod_12(listView_0.Items[int_0].SubItems[listView_0.Items[int_0].SubItems.Count - 1].Text);
			if (num > 0 && gstruct42_0 != null && gstruct42_0.Length > 0)
			{
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					if (gstruct42_0[i].int_129 == num)
					{
						return i;
					}
				}
			}
		}
		return -1;
	}

	public static int smethod_3(GStruct42[] gstruct42_0, int int_0)
	{
		if (int_0 > 0 && gstruct42_0 != null && gstruct42_0.Length > 0)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				if (gstruct42_0[i].int_129 == int_0)
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static int smethod_4(ListView listView_0, MouseEventArgs mouseEventArgs_0, int int_0 = 0)
	{
		try
		{
			ListViewItem itemAt = listView_0.GetItemAt(mouseEventArgs_0.X, mouseEventArgs_0.Y);
			if (itemAt != null)
			{
				string text = itemAt.SubItems[int_0].Text;
				for (int i = 0; i < listView_0.Items.Count; i++)
				{
					string text2 = listView_0.Items[i].SubItems[int_0].Text;
					if (text == text2)
					{
						return i;
					}
				}
			}
		}
		catch
		{
		}
		return -1;
	}

	public static void smethod_5(ListView listView_0, GStruct42 gstruct42_0)
	{
		string text = Class10.smethod_1(gstruct42_0.string_20, 1) + "|...|...|...|" + gstruct42_0.int_129;
		string[] array = text.Split('|');
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

	public static int smethod_6(ListView listView_0, GStruct42[] gstruct42_0, int int_0)
	{
		if (int_0 >= 0 && gstruct42_0 != null && int_0 < gstruct42_0.Length)
		{
			string b = gstruct42_0[int_0].int_129.ToString();
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				if (listView_0.Items[i].SubItems[listView_0.Items[i].SubItems.Count - 1].Text == b)
				{
					return i;
				}
			}
			return -1;
		}
		return -1;
	}

	public static int smethod_7(ListView listView_0, GStruct42 gstruct42_0)
	{
		string b = gstruct42_0.int_129.ToString();
		for (int i = 0; i < listView_0.Items.Count; i++)
		{
			if (listView_0.Items[i].SubItems[listView_0.Items[i].SubItems.Count - 1].Text == b)
			{
				return i;
			}
		}
		return -1;
	}

	public static GStruct42 smethod_8(ListView listView_0, int int_0, GStruct42[] gstruct42_0)
	{
		if (gstruct42_0 != null)
		{
			int num = Class11.smethod_12(listView_0.Items[int_0].SubItems[listView_0.Items[int_0].SubItems.Count - 1].Text);
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				if (gstruct42_0[i].int_129 == num)
				{
					return gstruct42_0[i];
				}
			}
		}
		GStruct42 result = default(GStruct42);
		result.int_129 = 0;
		result.string_20 = null;
		return result;
	}

	public static int smethod_9(ListView listView_0, int int_0)
	{
		int index = listView_0.Items[int_0].SubItems.Count - 1;
		return Class11.smethod_12(listView_0.Items[int_0].SubItems[index].Text);
	}

	public static int smethod_10(ListView listView_0, int int_0)
	{
		string b = int_0.ToString();
		int num = 0;
		while (true)
		{
			if (num < listView_0.Items.Count)
			{
				if (listView_0.Items[num].SubItems[listView_0.Items[num].SubItems.Count - 1].Text == b)
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
}
