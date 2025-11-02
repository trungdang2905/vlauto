using System;
using System.Threading;

internal class Class73
{
	private static uint uint_0 = 19u;

	private static uint uint_1 = 11u;

	private static string string_0 = null;

	private static uint uint_2 = 4u;

	private static long long_0 = 0L;

	public static uint smethod_0(GStruct42 gstruct42_0, string string_1 = "\\settings\\shop\\type.txt")
	{
		uint num = Class20.smethod_1(gstruct42_0.int_130, 86016u);
		if (num == 0)
		{
			return 0u;
		}
		uint num2 = num + 128;
		uint num3 = num2 - 128;
		uint num4 = num2 + 32;
		int int_ = 0;
		byte[] array = new byte[6];
		Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_6 + Class47.gstruct43_3.uint_0 + 11, array, array.Length, ref int_);
		byte[] array2 = Class11.smethod_41(string_1);
		Class20.WriteProcessMemory(gstruct42_0.int_130, num + 4, array2, array2.Length, ref int_);
		string string_2 = "6068" + Class11.smethod_40(num3 + 4, 8, bool_1: false, bool_2: true) + "B9" + Class11.smethod_40(num4, 8, bool_1: false, bool_2: true) + "FF 15 00 00 00 0061C6 05" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true) + "01" + Class60.smethod_10(gstruct42_0.uint_91);
		array2 = Class11.smethod_10(string_2);
		Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array2, array2.Length, ref int_);
		Class20.WriteProcessMemory(gstruct42_0.int_130, num2 + 11, array, array.Length, ref int_);
		smethod_35(gstruct42_0.int_130, num2);
		int num5 = 0;
		byte[] array3 = new byte[4];
		uint result = 0u;
		bool flag = false;
		while (num5 < 10)
		{
			Class20.ReadProcessMemory(gstruct42_0.int_130, num3, array3, 1, ref int_);
			if (array3[0] <= 0)
			{
				num5++;
				Thread.Sleep(100);
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + 12, array3, 4, ref int_);
			result = BitConverter.ToUInt32(array3, 0);
			flag = true;
			break;
		}
		if (flag)
		{
			Class20.smethod_2(gstruct42_0.int_130, num);
		}
		return result;
	}

	public static Struct25[] smethod_1(GStruct42 gstruct42_0)
	{
		uint num = smethod_0(gstruct42_0);
		if (num != 0)
		{
			int int_ = 0;
			byte[] array = new byte[250];
			Class20.ReadProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
			string text = Class10.smethod_3(array).Replace("\r", "\n").Replace("\n\n", "\n");
			string[] array2 = text.Split('\n');
			if (array2.Length > 1 && Class11.smethod_2(array2[0].ToUpper(), "TYPENAME") >= 0)
			{
				int num2 = 0;
				Struct25[] array3 = null;
				for (int i = 1; i < array2.Length && array2[i] != null && !(array2[i] == string.Empty); i++)
				{
					string[] array4 = array2[i].Split('\t');
					if (array4.Length == 2)
					{
						int int_2 = Class11.smethod_12(array4[1]);
						num2++;
						if (num2 != 1)
						{
							Array.Resize(ref array3, num2);
							array3[num2 - 1] = new Struct25
							{
								int_0 = int_2,
								string_0 = array4[0]
							};
						}
						else
						{
							array3 = new Struct25[1]
							{
								new Struct25
								{
									int_0 = int_2,
									string_0 = array4[0]
								}
							};
						}
					}
				}
				return array3;
			}
			return null;
		}
		return null;
	}

	public static string smethod_2(GStruct42 gstruct42_0)
	{
		uint num = smethod_0(gstruct42_0);
		if (num == 0)
		{
			return string.Empty;
		}
		int int_ = 0;
		byte[] array = new byte[80];
		Class20.ReadProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		string text = Class10.smethod_3(array).Replace("\r", "\n").Replace("\n\n", "\n");
		string[] array2 = text.Split('\n');
		text = string.Empty;
		if (array2.Length > 1 && Class11.smethod_2(array2[0].ToUpper(), "TYPENAME") == 0)
		{
			array2 = array2[1].Split('\t');
			text = array2[0];
		}
		return text;
	}

	public static int smethod_3(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_6 != 0 && Class47.gstruct43_0.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			if (!Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_6 + Class47.gstruct43_0.uint_0, array, 4, ref int_))
			{
				return -1;
			}
			return BitConverter.ToInt32(array, 0);
		}
		return -1;
	}

	public static bool smethod_4(GStruct42 gstruct42_0)
	{
		if (string_0 == string.Empty || string_0 == null || Class11.smethod_23(long_0) > 600000L)
		{
			string_0 = smethod_2(gstruct42_0);
			if ((string_0 == null || string_0 == string.Empty) && FormMain.string_4 != null && 0 <= FormMain.int_0 && FormMain.int_0 < FormMain.string_4.GetLength(0))
			{
				string_0 = FormMain.string_4[FormMain.int_0, 1];
			}
			long_0 = Class11.smethod_22();
		}
		return Class60.smethod_25(gstruct42_0, string_0);
	}

	public static uint smethod_5(GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_5.uint_0 == 0)
		{
			return 0u;
		}
		if (gstruct42_0.uint_7 == 0)
		{
			gstruct42_0.uint_7 = Class20.smethod_37(gstruct42_0.int_129, "engine.dll");
			if (gstruct42_0.uint_7 == 0)
			{
				return 0u;
			}
			int num = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
			if (0 <= num)
			{
				FormMain.gstruct42_0[num].uint_7 = gstruct42_0.uint_7;
			}
		}
		int int_ = 0;
		byte[] array = new byte[4];
		Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_7 + Class47.gstruct43_5.uint_0, array, 4, ref int_);
		return BitConverter.ToUInt32(array, 0);
	}

	public static uint smethod_6(GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_5.uint_0 == 0)
		{
			return 0u;
		}
		int int_ = 0;
		byte[] array = new byte[4];
		uint result = 0u;
		Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_7 + Class47.gstruct43_5.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		if (num != 0)
		{
			Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_6.uint_0, array, 4, ref int_);
			result = BitConverter.ToUInt32(array, 0);
		}
		return result;
	}

	public static bool smethod_7(GStruct42 gstruct42_0, uint uint_3)
	{
		if (Class47.gstruct43_6.uint_0 == 0)
		{
			return false;
		}
		uint num = smethod_5(gstruct42_0);
		if (num != 0)
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(uint_3);
			uint uint_4 = num + Class47.gstruct43_6.uint_0;
			return Class20.WriteProcessMemory(gstruct42_0.int_130, uint_4, bytes, bytes.Length, ref int_);
		}
		return false;
	}

	public static bool smethod_8(GStruct42 gstruct42_0, int[] int_0)
	{
		if (Class47.gstruct43_6.uint_0 == 0)
		{
			return false;
		}
		uint num = smethod_5(gstruct42_0);
		if (num != 0)
		{
			uint value = (uint)((int_0[1] << 16) + int_0[0]);
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(value);
			uint uint_ = num + Class47.gstruct43_6.uint_0;
			return Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, bytes, bytes.Length, ref int_);
		}
		return false;
	}

	public static bool smethod_9(GStruct42 gstruct42_0, int int_0, int int_1)
	{
		if (Class47.gstruct43_6.uint_0 == 0)
		{
			return false;
		}
		uint num = smethod_5(gstruct42_0);
		if (num == 0)
		{
			return false;
		}
		uint value = (uint)((int_1 << 16) + int_0);
		int int_2 = 0;
		byte[] bytes = BitConverter.GetBytes(value);
		uint uint_ = num + Class47.gstruct43_6.uint_0;
		return Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, bytes, bytes.Length, ref int_2);
	}

	public static uint[] smethod_10(uint[] uint_3, uint[] uint_4)
	{
		uint[] array = new uint[2];
		int num = (int)(400 - (uint_3[0] - uint_4[0]));
		int num2 = 300 - (int)(uint_3[1] - uint_4[1]) / 2;
		return new uint[2]
		{
			(uint)num,
			(uint)num2
		};
	}

	public static uint[] smethod_11(uint[] uint_3, int int_0, int int_1)
	{
		uint[] array = new uint[2];
		int num = (int)uint_3[0] - (400 - int_0);
		int num2 = (int)uint_3[1] - (300 - int_1) * 2;
		return new uint[2]
		{
			(uint)num,
			(uint)num2
		};
	}

	public static int smethod_12(GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_5.uint_0 == 0)
		{
			return 0;
		}
		int int_ = 0;
		int result = 0;
		byte[] array = new byte[4];
		Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_7 + Class47.gstruct43_5.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		if (num != 0)
		{
			uint uint_ = num + Class47.gstruct43_6.uint_0 + uint_2;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
			result = BitConverter.ToInt32(array, 0);
		}
		return result;
	}

	public static int smethod_13(GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_6.uint_0 != 0)
		{
			uint num = smethod_5(gstruct42_0);
			if (num == 0)
			{
				return 0;
			}
			int int_ = 0;
			byte[] array = new byte[4];
			uint uint_ = num + Class47.gstruct43_6.uint_0 + uint_2;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
			return BitConverter.ToInt32(array, 0);
		}
		return -1;
	}

	public static void smethod_14(GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_6.uint_0 != 0)
		{
			uint num = smethod_5(gstruct42_0);
			if (num != 0)
			{
				int int_ = 0;
				byte[] byte_ = new byte[4];
				uint uint_ = num + Class47.gstruct43_6.uint_0 + uint_2;
				Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, byte_, 4, ref int_);
			}
		}
	}

	public static void smethod_15(uint uint_3, uint uint_4)
	{
		Class20.SendMessage(uint_3, Class20.int_30, Class20.int_33, uint_4);
		Class20.SendMessage(uint_3, Class20.int_31, Class20.int_33, uint_4);
	}

	public static string smethod_16(GStruct42 gstruct42_0)
	{
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_91.uint_0 + Class47.gstruct43_92.uint_0;
		return Class20.smethod_28(uint_, gstruct42_0.int_130);
	}

	public static bool smethod_17(GStruct42 gstruct42_0)
	{
		return Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_93.uint_0, gstruct42_0.int_130) != 0;
	}

	public static uint smethod_18(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_203.uint_0;
		return Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
	}

	public static uint smethod_19(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_202.uint_0;
		return Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
	}

	public static string smethod_20(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_203.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
		if (num3 != 0)
		{
			uint num4 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
			uint num5 = Class20.smethod_30(num4 + (num3 - 1) * 4, gstruct42_0.int_130);
			int num6 = (int)Class20.smethod_30(num5 + 24, gstruct42_0.int_130);
			num6 -= (int)uint_1;
			if (num6 > 0)
			{
				uint uint_ = num5 + Class47.gstruct43_208.uint_0 + uint_1;
				string text = Class20.smethod_29(uint_, gstruct42_0.int_130, num6);
				if (text.IndexOf('\0') > 0)
				{
					uint uint_2 = Class20.smethod_30(Class47.gstruct43_209.uint_0, gstruct42_0.int_130) + 28;
					string str = Class20.smethod_28(uint_2, gstruct42_0.int_130, num6);
					text = text.Replace('\0'.ToString(), "<" + str + ">");
				}
				return smethod_33(text, null, " ");
			}
			return null;
		}
		return null;
	}

	public static void smethod_21(GStruct42 gstruct42_0, string string_1)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_203.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
		if (num3 == 0)
		{
			return;
		}
		uint num4 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		uint num5 = Class20.smethod_30(num4 + (num3 - 1) * 4, gstruct42_0.int_130);
		int num6 = (int)Class20.smethod_30(num5 + 24, gstruct42_0.int_130);
		num6 -= (int)uint_1;
		if (num6 > 0)
		{
			uint uint_ = num5 + Class47.gstruct43_208.uint_0 + uint_1;
			if (string_1 == null || string_1 == string.Empty)
			{
				string_1 = "0K...";
			}
			if (string_1.Length > num6)
			{
				string_1 = string_1.Substring(0, num6);
			}
			int int_ = 0;
			byte[] array = Class11.smethod_41(string_1);
			num6 = array.Length + (int)uint_1;
			Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_);
			array = BitConverter.GetBytes(num6);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num5 + 24, array, array.Length, ref int_);
		}
	}

	public static string smethod_22(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_202.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
		if (num3 == 0)
		{
			return null;
		}
		uint num4 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		uint num5 = Class20.smethod_30(num4 + (num3 - 1) * 4, gstruct42_0.int_130);
		int num6 = (int)Class20.smethod_30(num5 + 24, gstruct42_0.int_130);
		num6 -= (int)uint_0;
		if (num6 <= 0)
		{
			return null;
		}
		uint uint_ = num5 + Class47.gstruct43_208.uint_0 + uint_0;
		string text = Class20.smethod_29(uint_, gstruct42_0.int_130, num6);
		if (Class11.smethod_2(text, '\0') > 0)
		{
			uint uint_2 = Class20.smethod_30(Class47.gstruct43_209.uint_0, gstruct42_0.int_130) + 28;
			string str = Class20.smethod_28(uint_2, gstruct42_0.int_130, num6);
			text = text.Replace('\0'.ToString(), "<" + str + ">");
		}
		return smethod_33(text, null, " ");
	}

	public static void smethod_23(GStruct42 gstruct42_0, string string_1)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_202.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
		if (num3 == 0)
		{
			return;
		}
		uint num4 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		uint num5 = Class20.smethod_30(num4 + (num3 - 1) * 4, gstruct42_0.int_130);
		int num6 = (int)Class20.smethod_30(num5 + 24, gstruct42_0.int_130);
		num6 -= (int)uint_0;
		if (num6 > 0)
		{
			uint uint_ = num5 + Class47.gstruct43_208.uint_0 + uint_0;
			if (string_1 == null || string_1 == string.Empty)
			{
				string_1 = "0K..";
			}
			if (string_1.Length > num6)
			{
				string_1 = string_1.Substring(0, num6);
			}
			int int_ = 0;
			byte[] array = Class11.smethod_41(string_1);
			num6 = array.Length + (int)uint_0;
			Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_);
			array = BitConverter.GetBytes(num6);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num5 + 24, array, array.Length, ref int_);
		}
	}

	public static string smethod_24(GStruct42 gstruct42_0, uint uint_3)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_203.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(num3 + uint_3 * 4, gstruct42_0.int_130);
		int num5 = (int)Class20.smethod_30(num4 + 24, gstruct42_0.int_130);
		num5 -= 11;
		if (num5 <= 0)
		{
			return null;
		}
		uint uint_4 = num4 + Class47.gstruct43_208.uint_0 + uint_1;
		string text = Class20.smethod_29(uint_4, gstruct42_0.int_130, num5);
		if (text.IndexOf('\0') > 0)
		{
			uint num6 = Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
			if (uint_3 == num6 - 1)
			{
				uint uint_5 = Class20.smethod_30(Class47.gstruct43_209.uint_0, gstruct42_0.int_130) + 28;
				string str = Class20.smethod_28(uint_5, gstruct42_0.int_130, num5);
				text = text.Replace('\0'.ToString(), "<" + str + ">");
			}
		}
		return smethod_33(text, null, " ");
	}

	public static string smethod_25(GStruct42 gstruct42_0, uint uint_3)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_202.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(num3 + uint_3 * 4, gstruct42_0.int_130);
		int num5 = (int)Class20.smethod_30(num4 + 24, gstruct42_0.int_130);
		num5 -= 19;
		if (num5 <= 0)
		{
			return null;
		}
		uint uint_4 = num4 + Class47.gstruct43_208.uint_0 + uint_0;
		string text = Class20.smethod_29(uint_4, gstruct42_0.int_130, num5);
		if (Class11.smethod_2(text, '\0') > 0)
		{
			uint num6 = Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
			if (uint_3 == num6 - 1)
			{
				uint uint_5 = Class20.smethod_30(Class47.gstruct43_209.uint_0, gstruct42_0.int_130) + 28;
				string str = Class20.smethod_28(uint_5, gstruct42_0.int_130, num5);
				text = text.Replace('\0'.ToString(), "<" + str + ">");
			}
		}
		return smethod_33(text, null, " ");
	}

	public static string[] smethod_26(GStruct42 gstruct42_0, uint uint_3)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_202.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		if (num3 <= uint_3)
		{
			uint_3 = num3;
		}
		uint num5 = num3 - uint_3;
		int num6 = 0;
		string[] array = new string[uint_3];
		for (uint num7 = num5; num7 < num3; num7++)
		{
			uint num8 = num5 + (num3 - num7) - 1;
			uint num9 = Class20.smethod_30(num4 + num8 * 4, gstruct42_0.int_130);
			int num10 = (int)Class20.smethod_30(num9 + 24, gstruct42_0.int_130);
			num10 -= 19;
			if (num10 > 0)
			{
				uint uint_4 = num9 + Class47.gstruct43_208.uint_0 + uint_0;
				string text = Class20.smethod_29(uint_4, gstruct42_0.int_130, num10);
				if (!(text == string.Empty))
				{
					array[num6] = smethod_33(text, null, " ");
					num6++;
				}
			}
		}
		return array;
	}

	public static string smethod_27(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_203.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		string text = null;
		for (uint num5 = 0u; num5 < num3; num5++)
		{
			uint num6 = Class20.smethod_30(num4 + num5 * 4, gstruct42_0.int_130);
			int num7 = (int)Class20.smethod_30(num6 + 24, gstruct42_0.int_130);
			num7 -= 11;
			if (num7 > 0)
			{
				uint uint_ = num6 + Class47.gstruct43_208.uint_0 + uint_1;
				string text2 = Class20.smethod_29(uint_, gstruct42_0.int_130, num7);
				if (!(text2 == ""))
				{
					object obj = text;
					text = obj + "(" + num5 + ")" + smethod_33(text2, null, " ") + Class47.string_3;
				}
			}
		}
		return text;
	}

	public static string smethod_28(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_202.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_206.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		string text = string.Empty;
		for (uint num5 = 0u; num5 < num3; num5++)
		{
			uint num6 = Class20.smethod_30(num4 + num5 * 4, gstruct42_0.int_130);
			int num7 = (int)Class20.smethod_30(num6 + 24, gstruct42_0.int_130);
			num7 -= 19;
			if (num7 > 0)
			{
				uint uint_ = num6 + Class47.gstruct43_208.uint_0 + uint_0;
				string text2 = Class20.smethod_29(uint_, gstruct42_0.int_130, num7);
				if (!(text2 == ""))
				{
					object obj = text;
					text = obj + "(" + num5 + ")" + smethod_33(text2, null, " ") + Class47.string_3;
				}
			}
		}
		return text;
	}

	public static string smethod_29(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_203.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		string text = null;
		for (uint num4 = 0u; num4 < 256; num4++)
		{
			uint num5 = Class20.smethod_30(num3 + num4 * 4, gstruct42_0.int_130);
			int num6 = (int)Class20.smethod_30(num5 + 24, gstruct42_0.int_130);
			num6 -= 11;
			if (num6 > 0)
			{
				uint uint_ = num5 + Class47.gstruct43_208.uint_0 + uint_1;
				string text2 = Class20.smethod_29(uint_, gstruct42_0.int_130, num6);
				if (!(text2 == ""))
				{
					object obj = text;
					text = obj + "(" + num4 + ")" + smethod_33(text2, null, " ") + Class47.string_3;
				}
			}
		}
		return text;
	}

	public static string smethod_30(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_204.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_202.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_207.uint_0, gstruct42_0.int_130);
		string text = null;
		for (uint num4 = 0u; num4 < 256; num4++)
		{
			uint num5 = Class20.smethod_30(num3 + num4 * 4, gstruct42_0.int_130);
			int num6 = (int)Class20.smethod_30(num5 + 24, gstruct42_0.int_130);
			num6 -= 19;
			if (num6 > 0)
			{
				uint uint_ = num5 + Class47.gstruct43_208.uint_0 + uint_0;
				string text2 = Class20.smethod_29(uint_, gstruct42_0.int_130, num6);
				if (!(text2 == ""))
				{
					object obj = text;
					text = obj + "(" + num4 + ")" + smethod_33(text2, null, " ") + Class47.string_3;
				}
			}
		}
		return text;
	}

	public static void smethod_31(GStruct42 gstruct42_0, object object_0, bool bool_0 = true, uint uint_3 = 3u)
	{
		if (object_0 != null && gstruct42_0.uint_12 != 0 && gstruct42_0.uint_79 != 0 && Class47.gstruct43_205.uint_0 != 0)
		{
			uint uint_4 = Class47.gstruct43_202.uint_0;
			if (bool_0)
			{
				uint_3 = 3u;
				uint_4 = Class47.gstruct43_203.uint_0;
			}
			string[] array = new string[2]
			{
				"Cong bo",
				"Abc"
			};
			string string_ = object_0.GetType().ToString().ToUpper();
			if (Class11.smethod_2(string_, "[]") > 0)
			{
				array = (string[])object_0;
			}
			else
			{
				array[1] = object_0.ToString();
			}
			Class20.smethod_31(gstruct42_0.uint_79 + 2, gstruct42_0.int_130, uint_3);
			Class20.smethod_31(gstruct42_0.uint_79 + 7, gstruct42_0.int_130, (uint)array[1].Length);
			Class20.smethod_31(gstruct42_0.uint_79 + 19, gstruct42_0.int_130, uint_4);
			int int_ = 0;
			byte[] array2 = Class11.smethod_41(array[0]);
			uint num = gstruct42_0.uint_79 - Class60.uint_1;
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array2, array2.Length, ref int_);
			array2 = Class11.smethod_41(array[1]);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, num + 80, array2, array2.Length, ref int_);
			if (flag && flag2)
			{
				Class60.smethod_12(gstruct42_0.int_130, gstruct42_0.uint_79);
			}
		}
	}

	public static void smethod_32(GStruct42 gstruct42_0, uint uint_3)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_80 != 0)
		{
			Class20.smethod_31(gstruct42_0.uint_80 + 2, gstruct42_0.int_130, uint_3);
			Class60.smethod_12(gstruct42_0.int_130, gstruct42_0.uint_80);
		}
	}

	private static string smethod_33(string string_1, byte[] byte_0, string string_2 = "")
	{
		if (string_1 != null && string_1 != "")
		{
			if (byte_0 == null)
			{
				byte_0 = new byte[30];
				for (byte b = 0; b < byte_0.Length; b = (byte)(b + 1))
				{
					byte_0[b] = b;
				}
			}
			for (int i = 0; i < byte_0.Length; i++)
			{
				string text = string_1;
				char c = (char)byte_0[i];
				string_1 = text.Replace(c.ToString(), string_2);
			}
		}
		return string_1;
	}

	public static bool smethod_34(GStruct42 gstruct42_0, int int_0 = -1)
	{
		if (gstruct42_0.uint_6 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			if (int_0 < 0)
			{
				array = new byte[2]
				{
					1,
					116
				};
				return Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_6 + Class47.gstruct43_252.uint_0 + 6, array, 2, ref int_);
			}
			if (int_0 == 0)
			{
				array = new byte[1]
				{
					2
				};
				return Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_6 + Class47.gstruct43_252.uint_0 + 6, array, 1, ref int_);
			}
			if (int_0 > 0)
			{
				array = new byte[1]
				{
					235
				};
				uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_252.uint_0 + 7;
				return Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_);
			}
			return false;
		}
		return false;
	}

	private static bool smethod_35(int int_0, uint uint_3)
	{
		uint uint_4 = 0u;
		uint num = Class20.CreateRemoteThread(int_0, IntPtr.Zero, 0u, uint_3, 0u, 0u, out uint_4);
		Class20.WaitForSingleObject((IntPtr)(long)num, 1000u);
		Class20.smethod_32((int)num);
		return uint_4 != 0;
	}

	public static int smethod_36(GStruct42 gstruct42_0, bool bool_0 = false)
	{
		if (gstruct42_0.uint_6 != 0 && Class47.gstruct43_254.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			uint num = gstruct42_0.uint_6 + Class47.gstruct43_254.uint_0;
			if (bool_0)
			{
				num -= 4;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num, array, 4, ref int_);
			return BitConverter.ToInt32(array, 0);
		}
		return 0;
	}

	public static int smethod_37(GStruct42 gstruct42_0, bool bool_0 = false)
	{
		if (gstruct42_0.uint_6 != 0 && Class47.gstruct43_255.uint_0 != 0 && Class47.gstruct43_256.uint_0 != 0 && Class47.gstruct43_257.uint_0 != 0)
		{
			int num = 0;
			int int_ = 0;
			byte[] array = new byte[4];
			uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_255.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
			int num2 = BitConverter.ToInt32(array, 0);
			uint uint_2 = gstruct42_0.uint_6 + Class47.gstruct43_257.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, 4, ref int_);
			int num3 = BitConverter.ToInt32(array, 0);
			int num4 = num2 - num3;
			uint uint_3 = gstruct42_0.uint_6 + Class47.gstruct43_256.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_3, array, 4, ref int_);
			int num5 = BitConverter.ToInt32(array, 0);
			if (num4 <= num5 * 1000)
			{
				int num6 = num4 / 1000;
				int num7 = num5 - num6;
				if (bool_0)
				{
					num7 /= 60;
				}
				num = num7 + 1;
			}
			else
			{
				int num7 = num4 / 1000;
				if (bool_0)
				{
					num7 /= 60;
				}
				num = num7 + 1;
			}
			return num;
		}
		return 0;
	}

	public static int smethod_38(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_6 != 0 && Class47.gstruct43_259.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			int result = 0;
			uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_259.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			if (num != 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num + 4, array, 4, ref int_);
				result = BitConverter.ToInt32(array, 0);
			}
			return result;
		}
		return 0;
	}

	public static int smethod_39(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_6 != 0 && Class47.gstruct43_258.uint_0 != 0 && Class47.gstruct43_260.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_258.uint_0 + Class47.gstruct43_260.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
			return BitConverter.ToInt32(array, 0);
		}
		return 0;
	}

	public static int smethod_40(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.int_129 > 0 && Class47.gstruct43_261.uint_0 != 0 && Class47.gstruct43_262.uint_0 != 0)
		{
			uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_261.uint_0 + Class47.gstruct43_262.uint_0;
			int int_ = 0;
			byte[] array = new byte[2];
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 2, ref int_);
			return array[0] + array[1] * 256;
		}
		return 999;
	}
}
