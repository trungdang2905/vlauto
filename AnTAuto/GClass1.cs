using System;
using System.IO;
using System.Security;
using System.Text;
using System.Threading;

public class GClass1
{
	public struct GStruct13
	{
		public string string_0;

		public string string_1;

		public uint uint_0;

		public long long_0;

		public long long_1;

		public int int_0;

		public bool bool_0;

		public uint[] uint_1;

		public string string_2;
	}

	public struct GStruct14
	{
		public long long_0;

		public int int_0;

		public int int_1;

		public string string_0;

		public string string_1;

		public uint uint_0;
	}

	public static string[] string_0 = null;

	public static long long_0 = -1L;

	public static int int_0 = 0;

	public static GStruct14[] gstruct14_0 = null;

	public static int int_1 = 0;

	public static bool bool_0 = false;

	public static long long_1 = 0L;

	public static bool bool_1 = false;

	public static string string_1 = null;

	public static string string_2 = null;

	public static string string_3 = null;

	public static long long_2 = 0L;

	public static long long_3 = 0L;

	public static int int_2 = 0;

	public static string[] string_4 = null;

	public static GStruct13 gstruct13_0 = default(GStruct13);

	public static int int_3 = 0;

	public static void smethod_0()
	{
		byte[] array = null;
		SecureString secureString_ = null;
		string text = null;
		int int_ = 0;
		byte[] array2 = new byte[4];
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		Class8[] array3 = null;
		Class59[] array4 = null;
		Class59[] array5 = null;
		Class59[] array6 = null;
		Class59[] array7 = null;
		Class59[] array8 = null;
		Class59[] array9 = null;
		long num10 = 0L;
		long num11 = 0L;
		while (true)
		{
			GStruct13 gStruct = default(GStruct13);
			gStruct.string_0 = null;
			gStruct.string_1 = null;
			gStruct.bool_0 = false;
			gStruct.long_1 = 0L;
			gStruct.long_0 = 0L;
			gStruct.int_0 = 0;
			gStruct.uint_0 = 0u;
			gstruct13_0 = gStruct;
			int_3 = 0;
			num6 = 0;
			num7 = 0;
			num8 = 0;
			long_2 = 0L;
			int_1 = 0;
			while (true)
			{
				Thread.Sleep(1300);
				if (Class11.bool_0)
				{
					return;
				}
				if (int_1 == 2)
				{
					break;
				}
				num--;
				if (num <= 0)
				{
					bool_1 = (bool_1 || smethod_2());
					num = 1800;
				}
				if (!FormMain.bool_2 || Class11.uint_0 == 0)
				{
					continue;
				}
				if (bool_1)
				{
					FormMain.gstruct42_0 = null;
					continue;
				}
				int num12 = Class11.int_1;
				uint uint_ = Class11.uint_0;
				if (string_4 == null || array == null)
				{
					array = new byte[8];
					array3 = new Class8[Class11.string_0.Length];
					int num13 = Class11.struct7_0.Length;
					string_4 = new string[num13];
					array4 = new Class59[num13];
					array5 = new Class59[num13];
					array6 = new Class59[num13];
					array7 = new Class59[num13];
					array8 = new Class59[num13];
					array9 = new Class59[num13];
					Class26.smethod_0();
					long_3 = 0L;
					string string_ = smethod_1(num12, uint_ + 256);
					Class11.smethod_0(Class11.smethod_48(string_), ref secureString_);
					text = smethod_1(num12, uint_ + 512);
					string_4[0] = smethod_1(num12, uint_ + 768);
					string_4[1] = smethod_1(num12, uint_ + 1024);
					string_4[2] = smethod_1(num12, uint_ + 1280);
					for (int i = 0; i < string_4.Length; i++)
					{
						if ((string_4[i] == null || string_4[i] == string.Empty) && Class11.struct7_0[i].char_0 != null)
						{
							string_4[i] = string.Concat(Class11.struct7_0[i].char_0);
						}
					}
					string_ = Class11.smethod_48(smethod_1(num12, uint_ + 1536));
					if (string_ != string.Empty)
					{
						array = Encoding.ASCII.GetBytes(string_);
					}
					uint num14 = uint_ + 2560 + 8;
					Class20.ReadProcessMemory(num12, num14, array2, 4, ref int_);
					int num15 = BitConverter.ToInt32(array2, 0);
					if (num15 > 0)
					{
						string_ = smethod_1(num12, num14, bool_2: true);
						Class11.long_0 = Class11.smethod_31(string_);
					}
				}
				num2--;
				if (num2 <= 0)
				{
					for (int j = 0; j < array3.Length; j++)
					{
						array3[j] = new Class8
						{
							string_0 = Class11.string_0[j]
						};
						new Thread(array3[j].method_0).Start();
						Thread.Sleep(150);
					}
					num2 = 1800;
					if (gstruct13_0.bool_0)
					{
						gstruct13_0.bool_0 = (gstruct13_0.long_1 > 0L && gstruct13_0.uint_0 != 0 && gstruct13_0.long_0 > long_1 && long_1 > 636758336219996160L);
						int_1 = 1;
					}
				}
				if (num3 == 0)
				{
					num3 = 1;
					if (num8 == 0)
					{
						Class11.string_14 = new string[1]
						{
							"Đang kiểm tra phiên bản, xin chờ chút xíu..."
						};
					}
					else
					{
						Class11.string_14 = new string[1]
						{
							"Đang thử kiểm tra phiên bản lần thứ " + (num3 + 1)
						};
					}
					for (int j = 0; j < array4.Length; j++)
					{
						array4[j] = new Class59
						{
							object_0 = Class11.char_1,
							string_1 = string_4[j],
							string_0 = text,
							secureString_0 = secureString_,
							bool_0 = false,
							int_0 = j + 1
						};
						new Thread(array4[j].method_6).Start();
					}
					Thread.Sleep(800);
				}
				if (num3 == 1 || num3 == -1)
				{
					if (string_2 == null || string_2 == string.Empty)
					{
						if (num3 != -1)
						{
							int num16 = array4.Length;
							for (int j = 0; j < array4.Length; j++)
							{
								if (array4[j].bool_0)
								{
									num16--;
								}
							}
							if (num16 <= 0)
							{
								num3 = -1;
							}
						}
						else if (num8 < 3)
						{
							num8++;
							num3 = 0;
						}
						else
						{
							if (!bool_0)
							{
								Class11.string_14 = new string[1]
								{
									"Không thể kiểm tra phiên bản."
								};
								return;
							}
							num3 = 2;
						}
						continue;
					}
					num3 = 2;
				}
				if (long_1 <= 0L)
				{
					if (num2 > 100)
					{
						num2 = 100;
					}
					continue;
				}
				switch (num3)
				{
				case 3:
					if (Class11.smethod_23(num10) > 43200000L)
					{
						num3 = 0;
						num10 = 0L;
					}
					break;
				case 2:
					Class11.smethod_24(ref Class11.string_14, Class11.smethod_1(Class11.char_22));
					int_1 = 1;
					bool_0 = true;
					num3 = 3;
					num8 = 0;
					num10 = Class11.smethod_22();
					break;
				}
				if (num5 == 0 && Class26.long_0 > 0L && Class26.bool_0)
				{
					num5 = 1;
					string object_ = Class26.string_1 + Class11.smethod_48(Class11.string_5) + Class26.long_0.ToString() + Class11.smethod_48(string.Concat(Class11.char_12));
					for (int j = 0; j < array5.Length; j++)
					{
						array5[j] = new Class59
						{
							object_0 = object_,
							string_1 = string_4[j],
							string_0 = text,
							secureString_0 = secureString_,
							bool_0 = false,
							int_0 = j + 1
						};
						new Thread(array5[j].method_3).Start();
					}
					Thread.Sleep(800);
				}
				if (int_3 == 0 && gstruct13_0.long_1 <= 0L && array != null && array.Length > 0)
				{
					int_3 = 1;
					string object_ = FormMain.string_9 + Class11.string_4 + FormMain.string_9 + Class11.smethod_48(string.Concat(Class11.char_12));
					if (FormMain.string_9.IndexOf(FormMain.string_8) != 0)
					{
						for (int j = 0; j < array6.Length; j++)
						{
							array6[j] = new Class59
							{
								object_0 = object_,
								string_1 = string_4[j],
								string_0 = text,
								secureString_0 = secureString_,
								bool_0 = false,
								int_0 = j + 1,
								byte_0 = array
							};
							new Thread(array6[j].method_5).Start();
						}
					}
					Thread.Sleep(800);
				}
				if (int_3 == 1)
				{
					bool flag = false;
					for (int k = 0; k < array6.Length; k++)
					{
						if (array6[k] != null && !array6[k].bool_0)
						{
							flag = true;
							break;
						}
					}
					if (!flag || gstruct13_0.uint_0 != 0)
					{
						int_3 = 2;
						int_1 = 1;
					}
				}
				if (num6 == 0 && long_2 <= 0L && array != null && gstruct13_0.long_1 > 0L && gstruct13_0.bool_0)
				{
					num6 = 1;
					string object_ = FormMain.string_9 + Class11.string_4 + FormMain.string_9 + Class11.smethod_48(Class11.string_6) + gstruct13_0.long_1 + Class11.smethod_48(string.Concat(Class11.char_12));
					for (int j = 0; j < array7.Length; j++)
					{
						array7[j] = new Class59
						{
							object_0 = object_,
							string_1 = string_4[j],
							string_0 = text,
							secureString_0 = secureString_,
							bool_0 = false,
							int_0 = j + 1
						};
						new Thread(array7[j].method_4).Start();
					}
					Thread.Sleep(1500);
				}
				if (num9 >= 30)
				{
					if (num7 == 0 && gstruct14_0 == null)
					{
						num7 = 1;
						for (int j = 0; j < array9.Length; j++)
						{
							array9[j] = new Class59
							{
								object_0 = Class11.char_3,
								string_1 = string_4[j],
								string_0 = text,
								secureString_0 = secureString_,
								bool_0 = false,
								int_0 = j + 1
							};
							new Thread(array9[j].method_0).Start();
							if (FormMain.bool_1)
							{
								break;
							}
						}
						Thread.Sleep(1500);
						num11 = Class11.smethod_22();
					}
					else if (num7 > 0 && Class11.smethod_23(num11) > 21600000L)
					{
						num7 = 0;
						gstruct14_0 = null;
					}
					if (num4 <= 0)
					{
						num4 = 600;
						for (int j = 0; j < array8.Length; j++)
						{
							array8[j] = new Class59
							{
								object_0 = Class11.char_2,
								string_1 = string_4[j],
								string_0 = text,
								secureString_0 = secureString_,
								bool_0 = false,
								int_0 = j + 1
							};
							new Thread(array8[j].method_2).Start();
							Thread.Sleep(800);
						}
					}
					num4--;
				}
				else
				{
					num9++;
				}
			}
		}
	}

	private static string smethod_1(int int_4, uint uint_0, bool bool_2 = false)
	{
		int int_5 = 0;
		byte[] array = new byte[4];
		string result = string.Empty;
		Class20.ReadProcessMemory(int_4, uint_0, array, 4, ref int_5);
		int num = BitConverter.ToInt32(array, 0);
		if (num > 0)
		{
			byte[] array2 = new byte[num];
			Class20.ReadProcessMemory(int_4, uint_0 + 4, array2, num, ref int_5);
			result = ((!bool_2) ? Class10.smethod_4(array2) : Class10.smethod_3(array2));
			if (array2[0] != 0)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = 0;
				}
				Class20.WriteProcessMemory(int_4, uint_0, array2, num, ref int_5);
			}
		}
		return result;
	}

	private static bool smethod_2()
	{
		bool flag = false;
		try
		{
			string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_1(Class47.char_0));
			string text = environmentVariable + Class11.smethod_1(Class11.char_25);
			if (!Class11.smethod_27(text))
			{
				return false;
			}
			string[] files = Directory.GetFiles(text, Class11.smethod_1(Class11.char_26));
			if (files != null)
			{
				files = Directory.GetFiles(text, Class11.smethod_1(Class11.char_27));
			}
			if (files != null)
			{
				foreach (string string_ in files)
				{
					string text2 = Class11.smethod_28(string_, 0, 0, 1);
					if (text2 != null && text2 != string.Empty && 0 <= Class11.smethod_2(text2, Class11.smethod_1(Class11.char_28)))
					{
						flag = true;
						Class55.smethod_10(Class47.string_0, Class11.smethod_1(Class11.char_29), Class11.smethod_22(), "", 0);
						Class11.smethod_20(string_);
						Class11.smethod_29(string_, string.Empty, 1);
					}
				}
			}
			if (!flag)
			{
				long num = Class55.smethod_5(Class11.smethod_1(Class11.char_29), 0, "0");
				long num2 = Class11.smethod_23(num);
				if (num2 < 295000L)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				Class55.smethod_10(Class47.string_0, Class11.smethod_1(Class11.char_29), 0, "", 0);
			}
		}
		catch
		{
		}
		return flag;
	}

	public static string[] smethod_3()
	{
		string text1 = "Thông tin đăng ký";

        if (!Class26.bool_0)
		{
			return new string[2]
			{
				text1,
                Class11.char_16
            };
		}

		DateTime dateTime = new DateTime(Class11.long_0);
		string text2 = Class11.char_17;// chua kiem tra
		if (long_1 > 0L)
		{
			text2 = ((int)new TimeSpan(Class11.long_0 - long_1).TotalDays).ToString();
		}
		string str = null;
		for (int i = 0; i < Class26.string_0.Length; i++)
		{
			if (i > 0)
			{
				str += Class11.string_7;
			}
			str += Class26.string_0[i];
		}
		uint num = Class11.smethod_7(str + Class11.string_7 + Class26.long_0.ToString());
		if (num != long_3 || Class11.long_0 <= 0L)
		{
			text1 = Class11.char_18;// lic kg hop le
		}
		string text3 = Class11.char_19 + dateTime.Day + Class11.string_4 + dateTime.Month + Class11.string_4 + dateTime.Year + ' ' + "(" + text2 + Class11.smethod_1(Class11.char_20) + ")";
		return new string[2]
		{
			text1,
			text3
		};
	}

	public static string smethod_4()
	{
		try
		{
			if (gstruct13_0.long_0 != 0L)
			{
				DateTime d = new DateTime(long_1);
				DateTime d2 = new DateTime(gstruct13_0.long_0);
				int num = (int)(d2 - d).TotalDays;
				return Class11.smethod_48(Class11.string_11) + Class10.smethod_1(gstruct13_0.string_1, 1) + Class11.smethod_48(Class11.string_12) + ' ' + num.ToString() + Class11.smethod_1(Class11.char_20) + Class47.string_3 + Class11.char_19 + d2.Day.ToString() + Class11.string_4 + d2.Month.ToString() + Class11.string_4 + d2.Year.ToString() + ' ' + d2.ToShortTimeString() + Class47.string_3 + Class11.smethod_1(Class11.char_21) + FormMain.string_9;
			}
			return Class11.char_16;
		}
		catch
		{
		}
		return string.Concat('\u0001');
	}

	public static int smethod_5(GStruct42 gstruct42_0)
	{
		try
		{
			return smethod_6(gstruct42_0);
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_6(GStruct42 gstruct42_0)
	{
		int result = 0;
		bool flag = Class26.bool_0;
		string[] array = Class26.string_0;
		int int_ = 0;
		byte[] array2 = new byte[4];
		uint num = 0u;
		int num2 = 0;
		try
		{
			string[] array3 = null;
			num = 10u;
			Class20.ReadProcessMemory(Class11.int_1, Class11.uint_0 + 2560, array2, array2.Length, ref int_);
			int num3 = BitConverter.ToInt32(array2, 0);
			Class20.ReadProcessMemory(Class11.int_1, Class11.uint_0 + 2560 + 4, array2, array2.Length, ref int_);
			BitConverter.ToInt32(array2, 0);
			Class20.ReadProcessMemory(Class11.int_1, Class11.uint_0 + 2560 + 32, array2, array2.Length, ref int_);
			num2 = BitConverter.ToInt32(array2, 0);
			if (num2 > 0 && num2 < 999)
			{
				byte[] array4 = new byte[num2];
				Class20.ReadProcessMemory(Class11.int_1, Class11.uint_0 + num * 256 + 36, array4, array4.Length, ref int_);
				string text = Class11.smethod_16(Class10.smethod_3(array4));
				array3 = text.Split('\u0001');
			}
			if (array != null && array.Length >= 6 && array3 != null && array3.Length >= array.Length)
			{
				string str = null;
				for (int i = 0; i < array.Length; i++)
				{
					flag = (flag && array[i] == array3[i]);
					str = str + array3[i] + Class11.string_7;
				}
				str += Class26.long_0.ToString();
				long num4 = Class11.smethod_31(array3[array3.Length - 1]);
				uint num5 = Class11.smethod_7(str);
				if (Class26.bool_0 && num5 == long_3 && long_1 > 637134962330000000L && Class11.long_0 > long_1 && Class11.long_0 == num4 && num3 > 14)
				{
					return 1;
				}
				result = -1;
			}
		}
		catch
		{
		}
		if (gstruct13_0.bool_0 && gstruct13_0.long_1 > 0L && gstruct13_0.uint_0 != 0 && gstruct13_0.string_1 != null && !(gstruct13_0.string_1 == string.Empty) && gstruct13_0.string_0 != null && !(gstruct13_0.string_0 == string.Empty))
		{
			int length = gstruct13_0.string_0.Length;
			if (long_2 > 0L && length > 0)
			{
				string text2 = Class73.smethod_16(gstruct42_0);
				string text3 = Class23.smethod_3(gstruct42_0);
				uint num6 = Class32.smethod_12(gstruct42_0);
				if (length < text2.Length)
				{
					text2 = text2.Substring(0, length);
				}
				string text4 = text2;
				if (gstruct13_0.string_2 != null && gstruct13_0.string_2 != string.Empty)
				{
					text4 = text4 + '\u0001' + Class11.smethod_16(gstruct13_0.string_2);
				}
				uint num7 = 2 * Class11.smethod_7(text3 + text4 + gstruct13_0.long_0 + gstruct13_0.long_1) / 2u;
				int num8 = Convert.ToByte(gstruct13_0.uint_0 != 0 && gstruct13_0.uint_0 == num6 && num7 == long_2 && text3 == gstruct13_0.string_1 && text2 == gstruct13_0.string_0);
				if (text4 != null)
				{
					length = text4.Length;
					text4 = string.Empty;
					for (int i = 0; i < length; i++)
					{
						text4 += '\0';
					}
				}
				return num8 * 2;
			}
			return -1;
		}
		return result;
	}
}
