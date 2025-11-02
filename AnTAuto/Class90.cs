using System;
using System.IO;
using System.Net;
using System.Threading;

internal class Class90
{
	public static string[] string_0 = null;

	public static GStruct52[] gstruct52_0 = null;

	public static void smethod_0()
	{
		int num = 0;
		while (true)
		{
			try
			{
				smethod_1();
				return;
			}
			catch
			{
				Thread.Sleep(300);
				num++;
				if (num >= 3)
				{
					return;
				}
			}
		}
	}

	public static void smethod_1()
	{
		if (string_0 == null || string_0.Length <= 0)
		{
			return;
		}
		int num = 0;
		GStruct52[] array = new GStruct52[string_0.Length];
		for (int i = 0; i < string_0.Length; i++)
		{
			string text = string_0[i];
			if (text == null || text == string.Empty)
			{
				continue;
			}
			string[] array2 = text.Split('|');
			if (array2[0] == string.Empty || array2[0] == null)
			{
				continue;
			}
			array[num].string_1 = array2[0];
			array[num].string_2 = null;
			array[num].int_1 = 30000;
			if (array2.Length > 1)
			{
				array[num].string_2 = array2[1];
			}
			if (array2.Length > 2 && array2[2] != null && array2[2] != string.Empty)
			{
				string[] array3 = array2[2].Split('.', '/', '-');
				if (array3.Length == 3)
				{
					int num2 = Class11.smethod_12(array3[0]);
					int num3 = Class11.smethod_12(array3[1]);
					int num4 = Class11.smethod_12(array3[2]);
					if (0 < num2 && num2 <= 31 && 0 < num3 && num3 <= 12 && num4 > 0)
					{
						long ticks = new DateTime(num4, num3, num2, 12, 30, 0, 0).Ticks;
						array[num].long_0 = ticks;
						array[num].bool_0 = (GClass1.long_1 > ticks);
					}
					array[num].string_3 = array2[2];
				}
			}
			if (array2.Length > 3 && array2[3] != null && array2[3] != string.Empty)
			{
				int num5 = Class11.smethod_12(array2[3]);
				if (num5 > 0)
				{
					array[num].int_1 = num5;
				}
			}
			array[num].int_0 = Class11.smethod_12(array[num].string_2);
			if (array[num].int_0 <= 0)
			{
				array[num].string_0 = smethod_2(array[num].string_1);
				if (array[num].string_0 == null)
				{
					continue;
				}
			}
			num++;
		}
		if (num > 0)
		{
			gstruct52_0 = new GStruct52[num];
			for (int i = 0; i < num; i++)
			{
				gstruct52_0[i].string_0 = array[i].string_0;
				gstruct52_0[i].string_1 = array[i].string_1;
				gstruct52_0[i].string_2 = array[i].string_2;
				gstruct52_0[i].long_0 = array[i].long_0;
				gstruct52_0[i].int_0 = array[i].int_0;
				gstruct52_0[i].bool_0 = array[i].bool_0;
				gstruct52_0[i].string_3 = array[i].string_3;
				gstruct52_0[i].int_1 = array[i].int_1;
			}
		}
	}

	private static string smethod_2(string string_1)
	{
		try
		{
			WebClient webClient = new WebClient();
			byte[] array = webClient.DownloadData(string_1);
			if (array != null && array.Length > 0)
			{
				string text = Path.GetTempPath();
				if (text == null)
				{
					text = Class47.string_6;
				}
				while (text != null && text != string.Empty && (text[text.Length - 1] == '\\' || text[text.Length - 1] == '/'))
				{
					text = text.Substring(0, text.Length - 1);
				}
				string[] array2 = string_1.Split('/', '\\');
				string text2 = text + "\\" + array2[array2.Length - 1];
				Class11.smethod_45(text2, array);
				webClient.CancelAsync();
				return text2;
			}
			webClient.CancelAsync();
			return null;
		}
		catch
		{
		}
		return null;
	}
}
