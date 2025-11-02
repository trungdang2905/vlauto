using System;
using System.Net;
using System.Net.Sockets;

internal class Class62
{
	public static Class63 class63_0 = null;

	public static Class64 class64_0 = null;

	public static long long_0 = 0L;

	public static int int_0 = 0;

	public static int int_1 = Class55.smethod_3("KieuConnect", 0, "0");

	public static string[] string_0 = null;

	public static string[] string_1 = null;

	public static int int_2 = Class55.smethod_3("PortServer", 0, "0");

	public static string string_2 = string.Empty;

	public static int int_3 = Class55.smethod_3("nPort", 0, "0");

	public static string string_3 = Class55.smethod_6("ConnectIP", 0);

	public static string[] smethod_0()
	{
		string[] array = null;
		try
		{
			IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
			if (addressList != null)
			{
				for (int i = 0; i <= addressList.Length; i++)
				{
					if (addressList[i].AddressFamily == AddressFamily.InterNetwork && (!addressList[i].ToString().Contains(":") & !addressList.ToString().Contains("%")))
					{
						if (array != null)
						{
							Array.Resize(ref array, array.Length + 1);
							array[array.Length - 1] = addressList[i].ToString();
						}
						else
						{
							array = new string[1]
							{
								addressList[i].ToString()
							};
						}
					}
				}
			}
		}
		catch
		{
		}
		return array;
	}

	private static string smethod_1(string string_4, int int_4 = 2)
	{
		if (string_4 == null)
		{
			string_4 = string.Empty;
		}
		while (string_4.Length < int_4)
		{
			string_4 = "0" + string_4;
		}
		return string_4;
	}

	public static string smethod_2()
	{
		DateTime now = DateTime.Now;
		string text = smethod_1(now.Hour.ToString());
		string text2 = smethod_1(now.Minute.ToString());
		string text3 = smethod_1(now.Second.ToString());
		return text + ":" + text2 + ":" + text3;
	}

	private static string smethod_3(string[] string_4, int int_4, int int_5 = 0)
	{
		if ((int_5 <= 0 || int_5 > int_4) && string_4 != null && string_4.Length > int_4)
		{
			return string_4[int_4];
		}
		return string.Empty;
	}

	public static void smethod_4(string string_4)
	{
		FormMain.int_7 = 0;
		FormMain.int_6 = 1;
		if (GClass1.long_1 != 0L && !FormMayphu.bool_1)
		{
			if (string_4 != null && !(string_4 == string.Empty))
			{
				try
				{
					int num;
					int num2;
					while (true)
					{
						num = string_4.IndexOf('@');
						num2 = string_4.IndexOf('*');
						if (num2 >= num)
						{
							break;
						}
						string_4 = string_4.Substring(num);
					}
					if (num >= 0 && num2 >= 0)
					{
						string text = string_4.Substring(num, num2 + 1);
						string[] array = text.Split('|');
						int num3 = array.Length;
						if (num3 >= 49)
						{
							if (Class38.gstruct29_1.uint_4 == null)
							{
								Class38.gstruct29_1.uint_4 = new uint[2];
							}
							if (Class38.gstruct29_1.int_11 == null)
							{
								Class38.gstruct29_1.int_11 = new int[4];
							}
							FormMain.int_106 = 0;
							Class38.gstruct29_1.int_4 = Class11.smethod_12(smethod_3(array, 1, num3));
							Class38.gstruct29_1.int_3 = Class11.smethod_12(smethod_3(array, 2, num3));
							Class38.gstruct29_1.uint_4[0] = Class11.smethod_13(smethod_3(array, 3, num3));
							Class38.gstruct29_1.uint_4[1] = Class11.smethod_13(smethod_3(array, 4, num3));
							Class38.gstruct29_1.int_6 = Class11.smethod_12(smethod_3(array, 5, num3));
							Class38.gstruct29_1.uint_3 = Class11.smethod_13(smethod_3(array, 6, num3));
							FormMain.int_108 = Class11.smethod_12(smethod_3(array, 7, num3));
							FormMain.int_20 = Class11.smethod_12(smethod_3(array, 8, num3));
							FormMain.int_100 = Class11.smethod_12(smethod_3(array, 9, num3));
							FormMain.int_102 = Class11.smethod_12(smethod_3(array, 10, num3));
							Class16.int_0 = Class11.smethod_12(smethod_3(array, 11, num3));
							FormMain.int_22 = Class11.smethod_12(smethod_3(array, 12, num3));
							FormMain.int_30 = Class11.smethod_12(smethod_3(array, 13, num3));
							FormMain.int_31 = Class11.smethod_12(smethod_3(array, 14, num3));
							FormMain.int_32 = Class11.smethod_12(smethod_3(array, 15, num3));
							Class38.gstruct29_1.int_10 = Class11.smethod_12(smethod_3(array, 16, num3));
							Class38.gstruct29_1.int_2 = Class11.smethod_12(smethod_3(array, 17, num3));
							FormMain.int_24 = Class11.smethod_12(smethod_3(array, 18, num3));
							FormMain.int_83 = 1;
							FormMain.int_84 = Class11.smethod_12(smethod_3(array, 20, num3));
							FormDame.int_6 = Class11.smethod_12(smethod_3(array, 21, num3));
							FormDame.int_5 = Class11.smethod_12(smethod_3(array, 22, num3));
							FormDame.int_8 = Class11.smethod_12(smethod_3(array, 23, num3));
							Class38.gstruct29_1.uint_5 = Class11.smethod_13(smethod_3(array, 24, num3));
							Class38.gstruct29_1.int_7 = Class11.smethod_12(smethod_3(array, 25, num3));
							Class38.gstruct29_1.uint_3 = Class11.smethod_13(smethod_3(array, 26, num3));
							FormMain.int_33 = Class11.smethod_12(smethod_3(array, 27, num3));
							FormMain.int_34 = Class11.smethod_12(smethod_3(array, 28, num3));
							FormMain.int_21 = Class11.smethod_12(smethod_3(array, 29, num3));
							Class38.gstruct29_1.int_9 = Class11.smethod_12(smethod_3(array, 30, num3));
							Class38.gstruct29_1.uint_2 = Class11.smethod_13(smethod_3(array, 31, num3));
							FormMain.int_85 = Class11.smethod_12(smethod_3(array, 32, num3));
							Class38.gstruct29_1.int_8 = Class11.smethod_12(smethod_3(array, 33, num3));
							Class38.gstruct29_0.int_8 = Class11.smethod_12(smethod_3(array, 34, num3));
							FormMain.int_44[0] = Class11.smethod_12(smethod_3(array, 35, num3));
							FormMain.int_44[1] = Class11.smethod_12(smethod_3(array, 36, num3));
							FormMain.int_0 = Class11.smethod_12(smethod_3(array, 37, num3));
							Class31.int_1 = Class11.smethod_12(smethod_3(array, 38, num3));
							FormMain.int_99 = Class11.smethod_12(smethod_3(array, 39, num3));
							FormMain.int_103 = Class11.smethod_12(smethod_3(array, 40, num3));
							FormMain.int_79 = Class11.smethod_12(smethod_3(array, 41, num3));
							FormMain.int_70 = Class11.smethod_12(smethod_3(array, 42, num3));
							FormMain.int_107 = Class11.smethod_12(smethod_3(array, 43, num3));
							Class38.gstruct29_1.int_11[0] = Class11.smethod_12(smethod_3(array, 44, num3));
							Class38.gstruct29_1.int_11[1] = Class11.smethod_12(smethod_3(array, 45, num3));
							Class38.gstruct29_1.int_11[2] = Class11.smethod_12(smethod_3(array, 46, num3));
							Class38.gstruct29_1.int_11[3] = Class11.smethod_12(smethod_3(array, 47, num3));
						}
					}
				}
				catch
				{
				}
			}
		}
		else
		{
			Class38.gstruct29_1.int_4 = 0;
			Class38.gstruct29_1.int_0 = 0;
			Class38.gstruct29_1.int_6 = 0;
		}
	}

	public static string smethod_5()
	{
		FormMain.int_6 = 0;
		uint num = 0u;
		uint num2 = 0u;
		int int_ = Class38.gstruct29_0.int_4;
		if (Class38.gstruct29_0.uint_4 != null)
		{
			num = Class38.gstruct29_0.uint_4[0];
			num2 = Class38.gstruct29_0.uint_4[1];
		}
		if (num != 0 && num2 != 0 && int_ > 0)
		{
			string result = "@|" + int_ + "|" + Class38.gstruct29_0.int_3 + "|" + num + "|" + num2 + "|" + Class38.gstruct29_0.int_6 + "|" + Class38.gstruct29_0.uint_3 + "|" + FormMain.int_108 + "|" + FormMain.int_20 + "|" + FormMain.int_100 + "|" + FormMain.int_102 + "|" + Class16.int_0 + "|" + FormMain.int_22 + "|" + FormMain.int_30 + "|" + FormMain.int_31 + "|" + FormMain.int_32 + "|" + FormMain.int_25 + "|" + Class38.gstruct29_0.int_2 + "|" + FormMain.int_24 + "|" + FormMain.int_83 + "|" + FormMain.int_84 + "|" + FormDame.int_6 + "|" + FormDame.int_5 + "|" + FormDame.int_8 + "|" + Class38.gstruct29_0.uint_5 + "|" + Class38.gstruct29_0.int_7 + "|" + Class38.gstruct29_0.uint_3 + "|" + FormMain.int_33 + "|" + FormMain.int_34 + "|" + FormMain.int_21 + "|" + Class38.gstruct29_0.int_9 + "|" + Class38.gstruct29_0.uint_2 + "|" + FormMain.int_85 + "|" + Class38.gstruct29_0.int_8 + "|" + Class38.gstruct29_0.int_8 + "|" + FormMain.int_44[0] + "|" + FormMain.int_44[1] + "|" + FormMain.int_0 + "|" + Class31.int_1 + "|" + FormMain.int_99 + "|" + FormMain.int_103 + "|" + FormMain.int_79 + "|" + FormMain.int_70 + "|" + FormMain.int_107 + "|" + FormMain.int_72[0] + "|" + FormMain.int_72[1] + "|" + FormMain.int_72[2] + "|" + FormMain.int_72[3] + "|*";
			Class38.gstruct29_0.int_9 = 0;
			return result;
		}
		return string.Empty;
	}
}
