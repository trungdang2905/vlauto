using System;
using System.Threading;

internal class Class76
{
	public class Class77
	{
		public static int smethod_0(GStruct42 gstruct42_0)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_143.uint_0, gstruct42_0.int_130);
			uint uint_ = num + Class47.gstruct43_144.uint_0 + Class47.gstruct43_142.uint_0;
			return (int)Class20.smethod_30(uint_, gstruct42_0.int_130);
		}

		public static int smethod_1(GStruct42 gstruct42_0)
		{
			if (smethod_0(gstruct42_0) == 0)
			{
				return -1;
			}
			int num = 0;
			while (true)
			{
				if (num < 19)
				{
					uint uint_ = (uint)((int)(gstruct42_0.uint_6 + Class47.gstruct43_175.uint_0) + num * 4);
					if (Class20.smethod_30(uint_, gstruct42_0.int_130) != 0)
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

		public static string smethod_2(GStruct42 gstruct42_0, int int_0 = 96)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_143.uint_0, gstruct42_0.int_130);
			uint num2 = num + Class47.gstruct43_144.uint_0 + Class47.gstruct43_142.uint_0;
			uint num3 = num2 + 2712;
			return Class20.smethod_29(num3 + 4, gstruct42_0.int_130, int_0);
		}
	}

	public class Class78
	{
		public static int smethod_0(GStruct42 gstruct42_0)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_145.uint_0, gstruct42_0.int_130);
			uint uint_ = num + Class47.gstruct43_146.uint_0 + Class47.gstruct43_142.uint_0;
			return (int)Class20.smethod_30(uint_, gstruct42_0.int_130);
		}

		public static int smethod_1(GStruct42 gstruct42_0)
		{
			if (smethod_0(gstruct42_0) == 0)
			{
				return -1;
			}
			int num = (int)Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_147.uint_0, gstruct42_0.int_130);
			if (num == 0)
			{
				num = -1;
			}
			return num;
		}

		public static string smethod_2(GStruct42 gstruct42_0)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_145.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(num + Class47.gstruct43_152.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_152.uint_0 - 4, gstruct42_0.int_130);
			uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_153.uint_0, gstruct42_0.int_130);
			int num5 = (int)Class20.smethod_30(num4 - 12, gstruct42_0.int_130);
			if (num5 <= 10)
			{
				num5 = 512;
			}
			return Class20.smethod_29(num4, gstruct42_0.int_130, num5);
		}

		public static bool smethod_3(GStruct42 gstruct42_0, string string_0 = null)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_145.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(num + Class47.gstruct43_152.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_152.uint_0 - 4, gstruct42_0.int_130);
			uint uint_ = Class20.smethod_30(num3 + Class47.gstruct43_153.uint_0, gstruct42_0.int_130);
			int int_ = 0;
			byte[] array = Class11.smethod_41(string_0);
			return Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_);
		}
	}

	public class Class79
	{
		public static string smethod_0(GStruct42 gstruct42_0)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_149.uint_0 + Class47.gstruct43_152.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(num + Class47.gstruct43_153.uint_0, gstruct42_0.int_130);
			int num3 = (int)Class20.smethod_30(num2 - 12, gstruct42_0.int_130);
			if (num3 <= 0)
			{
				return Class20.smethod_28(num2, gstruct42_0.int_130, 512);
			}
			return Class20.smethod_29(num2, gstruct42_0.int_130, num3);
		}

		public static bool smethod_1(GStruct42 gstruct42_0, string string_0 = null)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_149.uint_0 + Class47.gstruct43_152.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(num + Class47.gstruct43_153.uint_0, gstruct42_0.int_130);
			int int_ = 0;
			byte[] array = Class11.smethod_41(string_0);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array, array.Length, ref int_);
			byte[] array2 = new byte[4];
			array = array2;
			return Class20.WriteProcessMemory(gstruct42_0.int_130, num2 - 12, array, array.Length, ref int_);
		}

		public static int smethod_2(GStruct42 gstruct42_0)
		{
			return (int)Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_149.uint_0 + Class47.gstruct43_151.uint_0, gstruct42_0.int_130);
		}

		public static int smethod_3(GStruct42 gstruct42_0)
		{
			return (int)Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_149.uint_0 + Class47.gstruct43_150.uint_0, gstruct42_0.int_130);
		}

		public static bool smethod_4(GStruct42 gstruct42_0)
		{
			int num = smethod_2(gstruct42_0);
			if (num > 0)
			{
				int num2 = smethod_3(gstruct42_0);
				if (num2 <= num)
				{
					return true;
				}
			}
			return false;
		}

		public static bool smethod_5(GStruct42 gstruct42_0)
		{
			bool flag = false;
			string text = smethod_0(gstruct42_0);
			string string_ = string.Empty;
			while (Class79.smethod_7(string_, text))
			{
				string_ = text;
				Class20.smethod_4(gstruct42_0.uint_4, 32u);
				Class79.smethod_6(180);
				text = smethod_0(gstruct42_0);
				flag = true;
			}
			if (flag)
			{
				Class20.smethod_4(gstruct42_0.uint_4, 32u);
			}
			return flag;
		}

		static void smethod_6(int int_0)
		{
			Thread.Sleep(int_0);
		}

		static bool smethod_7(string string_0, string string_1)
		{
			return string_0 != string_1;
		}
	}

	public static int int_0 = Class55.smethod_3("TimerMenus", 0, "300");

	public static bool smethod_0(GStruct42 gstruct42_0)
	{
		return 0 <= Class77.smethod_1(gstruct42_0) || 0 <= Class78.smethod_1(gstruct42_0);
	}

	public static int smethod_1(GStruct42 gstruct42_0)
	{
		int num = Class77.smethod_1(gstruct42_0);
		int num2 = Class78.smethod_1(gstruct42_0);
		if (num > 0 && num2 > 0)
		{
			return 2;
		}
		if (num <= 0)
		{
			if (num2 > 0)
			{
				return 1;
			}
			return -1;
		}
		return 0;
	}

	public static int smethod_2(GStruct42 gstruct42_0, int int_1 = -1)
	{
		switch (int_1)
		{
		case 0:
			return Class77.smethod_0(gstruct42_0);
		case 1:
			return Class78.smethod_0(gstruct42_0);
		default:
			if (0 > Class77.smethod_1(gstruct42_0))
			{
				if (0 < Class78.smethod_1(gstruct42_0))
				{
					return Class78.smethod_0(gstruct42_0);
				}
				return 0;
			}
			return Class77.smethod_0(gstruct42_0);
		}
	}

	public static string smethod_3(GStruct42 gstruct42_0, int int_1, int int_2 = -1)
	{
		if (int_2 != 0 && (int_2 >= 0 || 0 > Class77.smethod_1(gstruct42_0)))
		{
			if (int_2 <= 0 && (int_2 >= 0 || 0 >= Class78.smethod_1(gstruct42_0)))
			{
				return string.Empty;
			}
			return smethod_5(gstruct42_0, int_1, 1);
		}
		return smethod_5(gstruct42_0, int_1, 0);
	}

	public static string smethod_4(GStruct42 gstruct42_0, int int_1 = -1)
	{
		if (int_1 != 0 && (int_1 >= 0 || 0 > Class77.smethod_1(gstruct42_0)))
		{
			if (int_1 <= 0 && (int_1 >= 0 || 0 >= Class78.smethod_1(gstruct42_0)))
			{
				return string.Empty;
			}
			return Class78.smethod_2(gstruct42_0);
		}
		return Class77.smethod_2(gstruct42_0);
	}

	public static string smethod_5(GStruct42 gstruct42_0, int int_1, int int_2)
	{
		uint uint_ = Class47.gstruct43_143.uint_0;
		uint uint_2 = Class47.gstruct43_144.uint_0;
		if (int_2 > 0 || 0 < Class78.smethod_1(gstruct42_0))
		{
			uint_ = Class47.gstruct43_145.uint_0;
			uint_2 = Class47.gstruct43_146.uint_0;
		}
		if (gstruct42_0.uint_6 != 0 && uint_ != 0 && uint_2 != 0 && Class47.gstruct43_142.uint_0 != 0)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + uint_, gstruct42_0.int_130);
			if (num == 0)
			{
				return string.Empty;
			}
			uint uint_3 = num + uint_2 + (Class47.gstruct43_142.uint_0 - 4);
			uint num2 = Class20.smethod_30(uint_3, gstruct42_0.int_130);
			uint uint_4 = (uint)((int)num2 + int_1 * 4);
			uint num3 = Class20.smethod_30(uint_4, gstruct42_0.int_130);
			uint uint_5 = num3 + 28;
			int int_3 = 0;
			byte[] array = new byte[128];
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_5, array, array.Length, ref int_3);
			return Class10.smethod_3(array);
		}
		return string.Empty;
	}

	public static bool smethod_6(GStruct42 gstruct42_0, int int_1)
	{
		int num = -1;
		if (0 <= Class77.smethod_1(gstruct42_0))
		{
			num = 0;
		}
		else if (0 < Class78.smethod_1(gstruct42_0))
		{
			num = 1;
		}
		if (num < 0)
		{
			return false;
		}
		return Class60.smethod_57(gstruct42_0, int_1, Convert.ToByte(num == 1));
	}

	public static int smethod_7(GStruct42 gstruct42_0, string string_0, bool bool_0 = false, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
	{
		int result = 0;
		try
		{
			result = smethod_8(gstruct42_0, string_0, bool_0, bool_1, bool_2, bool_3);
		}
		catch
		{
		}
		return result;
	}

	private static int smethod_8(GStruct42 gstruct42_0, string string_0, bool bool_0 = false, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
	{
		string[] string_ = string_0.Split('|');
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		string text = null;
		int num5 = 0;
		if (Class11.gstruct41_0 != null)
		{
			int num6 = Class11.gstruct41_0.Length;
			for (int i = 0; i < num6; i++)
			{
				uint num7 = BitConverter.ToUInt32(Class11.gstruct41_0[i].byte_0, 0);
				for (int j = 0; j < Class47.gstruct41_0.Length; j++)
				{
					if (num7 == BitConverter.ToUInt32(Class47.gstruct41_0[j].byte_0, 0))
					{
						num5++;
						break;
					}
				}
			}
			num5 = num5 - num6 + 1;
		}
		while (true)
		{
			int num8 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
			if (num2 != 0)
			{
				if (num2 != num8)
				{
					break;
				}
			}
			else
			{
				num2 = num8;
			}
			num = -1;
			if (0 > Class77.smethod_1(gstruct42_0))
			{
				if (0 <= Class78.smethod_1(gstruct42_0))
				{
					num3 = Class78.smethod_0(gstruct42_0);
					num = 1;
				}
			}
			else
			{
				num = 0;
				num3 = Class77.smethod_0(gstruct42_0);
			}
			if (num < 0)
			{
				break;
			}
			int num9 = 0;
			string text2 = null;
			string[] array = new string[num3];
			int k;
			while (!Class11.bool_0)
			{
				for (k = 0; k < num3; k++)
				{
					array[k] = smethod_3(gstruct42_0, k, num);
					text2 += array[k];
				}
				if (text != null && !(text != text2))
				{
					Thread.Sleep(60);
					num9++;
					if (num9 <= 10)
					{
						text2 = null;
						continue;
					}
					goto IL_03b7;
				}
				text = text2;
				break;
			}
			int num10 = 0;
			string text3 = null;
			if (!bool_3)
			{
				while (array != null && array.Length > num10 && string_ != null)
				{
					if (array[num10] != null && !(array[num10] == string.Empty))
					{
						k = 0;
						while (k < string_.Length)
						{
							text3 = string_[k];
							if (text3 == null || text3 == string.Empty || !Class11.smethod_3(array[num10], text3))
							{
								k++;
								continue;
							}
							goto IL_0201;
						}
					}
					num10++;
				}
				break;
			}
			while (array != null && string_ != null && string_.Length > num10)
			{
				text3 = string_[num10];
				if (text3 != null && text3 != string.Empty)
				{
					k = 0;
					while (k < array.Length)
					{
						if (array[k] == null || array[k] == string.Empty || !Class11.smethod_3(array[k], text3))
						{
							k++;
							continue;
						}
						goto IL_0304;
					}
				}
				num10++;
			}
			break;
			IL_03b7:
			if (Class79.smethod_4(gstruct42_0))
			{
				Class79.smethod_5(gstruct42_0);
			}
			break;
			IL_0201:
			num4++;
			Class60.smethod_57(gstruct42_0, num10 + num5 - 1, num);
			if (!bool_2)
			{
				num9 = 0;
				while ((num == 0 && 0 <= Class77.smethod_1(gstruct42_0)) || (num == 1 && 0 <= Class78.smethod_1(gstruct42_0)))
				{
					num9++;
					Class78.smethod_0(gstruct42_0);
					Thread.Sleep(50);
					if (num9 > 10)
					{
						break;
					}
				}
				Thread.Sleep(350 + int_0);
				if (bool_1)
				{
					Class11.smethod_25(ref string_, text3, bool_1: true);
				}
				continue;
			}
			Thread.Sleep(300);
			break;
			IL_0304:
			num4++;
			Class60.smethod_57(gstruct42_0, k + num5 - 1, num);
			if (!bool_2)
			{
				num9 = 0;
				while ((num == 0 && 0 <= Class77.smethod_1(gstruct42_0)) || (num == 1 && 0 <= Class78.smethod_1(gstruct42_0)))
				{
					num9++;
					Class78.smethod_0(gstruct42_0);
					Thread.Sleep(50);
					if (num9 > 10)
					{
						break;
					}
				}
				Thread.Sleep(350 + int_0);
				if (bool_1)
				{
					Class11.smethod_25(ref string_, text3, bool_1: true);
				}
				continue;
			}
			Thread.Sleep(300);
			break;
		}
		return num4;
	}

	public static void smethod_9(GStruct42 gstruct42_0, bool bool_0 = false)
	{
		string[] array = new string[16]
		{
			"Anti H",
			"Vµo Game",
			"Õt thóc",
			"êi khái",
			"h«ng muèn",
			"h©n tiÖn",
			"Ta kh«ng",
			"Kh«ng ®",
			"Kh«ng",
			"kh«ng",
			"L\u00b8t n÷a",
			"nghÜ l¹i",
			"suy nghÜ k",
			"§­îc råi",
			"biÕt råi",
			"Mét L\u00b8t"
		};
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		while (true)
		{
			int num4 = 0;
			while (num3 > 10 || Class79.smethod_4(gstruct42_0))
			{
				if (num4 < 20)
				{
					Class20.smethod_4(gstruct42_0.uint_4, 32u);
					Thread.Sleep(150);
					num4++;
					continue;
				}
				if (bool_0)
				{
					Class20.smethod_4(gstruct42_0.uint_4, 27u);
				}
				break;
			}
			int num5 = smethod_1(gstruct42_0);
			if (num5 < 0 || num3 > 10)
			{
				break;
			}
			int num6;
			if (num5 > 0)
			{
				num5 = 1;
				num2 = Class78.smethod_0(gstruct42_0);
				if (num2 > 0)
				{
					num6 = 0;
					while (true)
					{
						if (num6 < num2)
						{
							string string_ = smethod_5(gstruct42_0, num6, num5).ToUpper();
							int num7 = 0;
							while (num7 < array.Length)
							{
								if (0 > Class11.smethod_2(string_, array[num7].ToUpper()))
								{
									num7++;
									continue;
								}
								goto IL_019c;
							}
							num6++;
							continue;
						}
						Class60.smethod_57(gstruct42_0, num2 - 1, num5);
						num3++;
						break;
						IL_019c:
						Class60.smethod_57(gstruct42_0, num6, num5);
						Thread.Sleep(300);
						num3++;
						break;
					}
					continue;
				}
			}
			num5 = 0;
			num2 = Class77.smethod_0(gstruct42_0);
			if (num2 <= 0)
			{
				num++;
				if (num < 3)
				{
					Thread.Sleep(150);
					continue;
				}
				break;
			}
			num6 = 0;
			while (true)
			{
				if (num6 < num2)
				{
					string string_ = smethod_5(gstruct42_0, num6, num5).ToUpper();
					int num7 = 0;
					while (num7 < array.Length)
					{
						if (0 > Class11.smethod_2(string_, array[num7].ToUpper()))
						{
							num7++;
							continue;
						}
						goto IL_0237;
					}
					num6++;
					continue;
				}
				Class60.smethod_57(gstruct42_0, num2 - 1, num5);
				num3++;
				break;
				IL_0237:
				Class60.smethod_57(gstruct42_0, num6, num5);
				Thread.Sleep(300);
				num3++;
				break;
			}
		}
	}
}
