using System;

internal class Class43
{
	public static bool smethod_0(int int_0, uint uint_0)
	{
		uint uint_ = 0u;
		uint num = Class20.CreateRemoteThread(int_0, IntPtr.Zero, 0u, uint_0, 0u, 0u, out uint_);
		Class20.WaitForSingleObject((IntPtr)(long)num, 1000u);
		Class20.smethod_32((int)num);
		return num != 0;
	}

	private static uint smethod_1(ref GStruct0 gstruct0_0, uint uint_0, string string_0, string string_1 = "")
	{
		if (gstruct0_0.uint_2 == 0)
		{
			return 0u;
		}
		byte[] array = Class11.smethod_10("60" + string_0 + "E8 00 00 00 00" + string_1 + "61 C3");
		int int_ = 0;
		uint num = gstruct0_0.uint_2 + gstruct0_0.uint_3;
		Class20.WriteProcessMemory(gstruct0_0.int_2, num, array, array.Length, ref int_);
		int num2 = string_1.Replace(" ", "").Length / 2;
		uint uint_ = (uint)(gstruct0_0.uint_1 + uint_0 - (num + array.Length - 2L - num2));
		Class20.smethod_31((uint)(num + array.Length - 6L - num2), gstruct0_0.int_2, uint_);
		gstruct0_0.uint_3 += (uint)(array.Length + 4);
		return num;
	}

	public static int smethod_2(ref GStruct0 gstruct0_0)
	{
		int int_ = gstruct0_0.int_1;
		gstruct0_0.int_1 = 0;
		if (Class20.smethod_52(gstruct0_0.process_0))
		{
			return -2;
		}
		gstruct0_0.uint_3 = 0u;
		gstruct0_0.uint_2 = Class20.smethod_1(gstruct0_0.int_2);
		if (gstruct0_0.uint_2 != 0)
		{
			gstruct0_0.int_1 = int_;
			gstruct0_0.uint_4 = smethod_13(ref gstruct0_0);
			gstruct0_0.uint_5 = smethod_12(ref gstruct0_0);
			gstruct0_0.uint_6 = smethod_10(ref gstruct0_0);
			gstruct0_0.uint_7 = smethod_11(ref gstruct0_0);
			gstruct0_0.uint_8 = smethod_9(ref gstruct0_0);
			gstruct0_0.uint_9 = smethod_8(ref gstruct0_0);
			gstruct0_0.uint_10 = smethod_7(ref gstruct0_0);
			gstruct0_0.uint_11 = smethod_6(ref gstruct0_0);
			gstruct0_0.uint_12 = smethod_5(ref gstruct0_0);
			gstruct0_0.uint_13 = smethod_4(ref gstruct0_0);
			gstruct0_0.uint_14 = smethod_3(ref gstruct0_0);
			if (gstruct0_0.uint_8 != 0 && gstruct0_0.uint_9 != 0 && gstruct0_0.uint_11 != 0 && gstruct0_0.uint_12 != 0 && gstruct0_0.uint_10 != 0)
			{
				return gstruct0_0.int_1;
			}
			gstruct0_0.int_1 = 0;
			Class20.smethod_32(gstruct0_0.int_2);
			return -5;
		}
		Class20.smethod_32(gstruct0_0.int_2);
		return -4;
	}

	private static uint smethod_3(ref GStruct0 gstruct0_0)
	{
		string str = Class11.smethod_40((gstruct0_0.uint_2 + gstruct0_0.uint_3).ToString(), 8, bool_1: false, bool_2: true);
		gstruct0_0.uint_3 += 128u;
		string string_ = "68" + str;
		return smethod_1(ref gstruct0_0, Class9.uint_65, string_, "83 C4 04");
	}

	private static uint smethod_4(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 != 0)
		{
			string string_ = "60B8 000000008B0D" + Class11.smethod_40(Class9.uint_53, 8, bool_1: false, bool_2: true) + "85 C9 74 2B69C0" + Class11.smethod_40(Class9.uint_54, 8, bool_1: false, bool_2: true) + "05" + Class11.smethod_40(Class9.uint_55, 8, bool_1: false, bool_2: true) + "03 C8 6A 00 51 68 65 05 00 00 8B 51 60 8B 12 8B 49 60 8B 42 10 85 C0 74 04 FF D0 EB 03 58 58 58 61 C3";
			byte[] array = Class11.smethod_10(string_);
			int int_ = 0;
			uint num = gstruct0_0.uint_2 + gstruct0_0.uint_3;
			byte b = Convert.ToByte(Class20.WriteProcessMemory(gstruct0_0.int_2, num, array, array.Length, ref int_));
			uint num2 = (uint)(b * (array.Length + 4));
			gstruct0_0.uint_3 += num2;
			return num * b;
		}
		return 0u;
	}

	public static uint smethod_5(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 != 0)
		{
			uint num = gstruct0_0.uint_1 + Class9.uint_38;
			uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
			string string_ = "60B9" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "8B 09 85 C9 74 17 8B F181 C6" + Class11.smethod_40(Class9.uint_30, 8, bool_1: false, bool_2: true) + "8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3";
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			gstruct0_0.uint_3 += (uint)(array.Length + 4);
			return Convert.ToByte(value) * num2;
		}
		return 0u;
	}

	public static uint smethod_6(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 != 0)
		{
			uint num = gstruct0_0.uint_1 + Class9.uint_31;
			uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
			string string_ = "60B9" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "8B 09 85 C9 74 17 8B F181 C6" + Class11.smethod_40(Class9.uint_29, 8, bool_1: false, bool_2: true) + "8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3";
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			gstruct0_0.uint_3 += (uint)(array.Length + 4);
			return Convert.ToByte(value) * num2;
		}
		return 0u;
	}

	public static uint smethod_7(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 != 0)
		{
			uint num = gstruct0_0.uint_1 + Class9.uint_31;
			uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
			string string_ = "60BA 00 00 00 00B9" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "8B 09 85 C9 74 1F 8B F181 C6" + Class11.smethod_40(Class9.uint_32, 8, bool_1: false, bool_2: true) + "69 D2" + Class11.smethod_40(Class9.uint_33, 8, bool_1: false, bool_2: true) + "03 F2 8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3";
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			gstruct0_0.uint_3 += (uint)(array.Length + 4);
			return Convert.ToByte(value) * num2;
		}
		return 0u;
	}

	public static uint smethod_8(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 != 0)
		{
			uint num = gstruct0_0.uint_1 + Class9.uint_34;
			uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
			string string_ = "60B9" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "8B 09 85 C9 74 17 8B F181 C6" + Class11.smethod_40(Class9.uint_28, 8, bool_1: false, bool_2: true) + "8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3";
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			gstruct0_0.uint_3 += (uint)(array.Length + 4);
			return Convert.ToByte(value) * num2;
		}
		return 0u;
	}

	public static uint smethod_9(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 != 0)
		{
			uint num = gstruct0_0.uint_1 + Class9.uint_23;
			uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
			string string_ = "608B 0D" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "8B F181 C6" + Class11.smethod_40(Class9.uint_27, 8, bool_1: false, bool_2: true) + "8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3";
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			gstruct0_0.uint_3 += (uint)(array.Length + 4);
			return Convert.ToByte(value) * num2;
		}
		return 0u;
	}

	public static uint smethod_10(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 != 0)
		{
			uint num = gstruct0_0.uint_1 + Class9.uint_23;
			uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3 + 2;
			string string_ = "60 B8 02 00 00 008B 0D" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "8B F181 C6" + Class11.smethod_40(Class9.uint_25, 8, bool_1: false, bool_2: true) + "89 86" + Class11.smethod_40(Class9.uint_24, 8, bool_1: false, bool_2: true) + "8B 11 8B 52 10 50 56 68 91 06 00 00 FF D2 61 C3";
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			gstruct0_0.uint_3 += (uint)(array.Length + 6);
			return Convert.ToByte(value) * num2;
		}
		return 0u;
	}

	public static uint smethod_11(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 != 0)
		{
			uint num = gstruct0_0.uint_1 + Class9.uint_23;
			uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3 + 2;
			string string_ = "60 B8 02 00 00 008B 0D" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "8B F181 C6" + Class11.smethod_40(Class9.uint_26, 8, bool_1: false, bool_2: true) + "89 86" + Class11.smethod_40(Class9.uint_24, 8, bool_1: false, bool_2: true) + "6A 00 56 68 02 02 00 00 8B 11 8B 52 10 FF D2 61 C3";
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			gstruct0_0.uint_3 += (uint)(array.Length + 6);
			return Convert.ToByte(value) * num2;
		}
		return 0u;
	}

	public static uint smethod_12(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 > 0 && gstruct0_0.uint_2 != 0)
		{
			uint num = gstruct0_0.uint_1 + Class9.uint_21;
			uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3 + 6;
			string string_ = "60B9" + Class11.smethod_40(num2 - 6, 8, bool_1: false, bool_2: true) + "6A 00 51 68 65 05 00 00 81 E9" + Class11.smethod_40(Class9.uint_22, 8, bool_1: false, bool_2: true) + "E8" + Class11.smethod_40(num - (num2 + 25), 8, bool_1: false, bool_2: true) + "61 C3";
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			gstruct0_0.uint_3 += (uint)(array.Length + 10);
			return Convert.ToByte(value) * num2;
		}
		return 0u;
	}

	public static uint smethod_13(ref GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 > 0 && gstruct0_0.uint_2 != 0)
		{
			uint num = gstruct0_0.uint_1 + Class9.uint_19;
			uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3 + 6;
			string string_ = "60B9" + Class11.smethod_40(num2 - 6, 8, bool_1: false, bool_2: true) + "5181 E9" + Class11.smethod_40(Class9.uint_20, 8, bool_1: false, bool_2: true) + "E8" + Class11.smethod_40(num - (num2 + 18), 8, bool_1: false, bool_2: true) + "61 C3";
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			gstruct0_0.uint_3 += (uint)(array.Length + 10);
			return Convert.ToByte(value) * num2;
		}
		return 0u;
	}

	public static uint smethod_14(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && Class9.uint_38 != 0)
		{
			uint uint_ = gstruct0_0.uint_1 + Class9.uint_38;
			uint num = Class20.smethod_30(uint_, gstruct0_0.int_2);
			if (num != 0)
			{
				return num + Class9.uint_39;
			}
			return 0u;
		}
		return 0u;
	}

	public static bool smethod_15(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_4 != 0)
		{
			smethod_0(gstruct0_0.int_2, gstruct0_0.uint_4);
			return true;
		}
		return false;
	}

	public static bool smethod_16(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_5 != 0)
		{
			smethod_0(gstruct0_0.int_2, gstruct0_0.uint_5);
			return true;
		}
		return false;
	}

	public static bool smethod_17(GStruct0 gstruct0_0, int int_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_6 != 0)
		{
			if (!Class20.smethod_31(gstruct0_0.uint_6 + 2, gstruct0_0.int_2, (uint)int_0))
			{
				return false;
			}
			smethod_0(gstruct0_0.int_2, gstruct0_0.uint_6);
			return true;
		}
		return false;
	}

	public static bool smethod_18(GStruct0 gstruct0_0, int int_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_7 != 0)
		{
			if (Class20.smethod_31(gstruct0_0.uint_7 + 2, gstruct0_0.int_2, (uint)int_0))
			{
				smethod_0(gstruct0_0.int_2, gstruct0_0.uint_7);
				return true;
			}
			return false;
		}
		return false;
	}

	public static bool smethod_19(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_8 != 0)
		{
			smethod_0(gstruct0_0.int_2, gstruct0_0.uint_8);
			return true;
		}
		return false;
	}

	public static bool smethod_20(GStruct0 gstruct0_0, string string_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_1 != 0)
		{
			uint num = Class20.smethod_30(gstruct0_0.uint_1 + Class9.uint_34, gstruct0_0.int_2);
			if (num != 0)
			{
				uint uint_ = num + Class9.uint_36 + Class9.uint_35;
				uint num2 = Class20.smethod_30(uint_, gstruct0_0.int_2);
				if (num2 == 0)
				{
					return false;
				}
				int int_ = 0;
				byte[] array = Class11.smethod_41(string_0);
				bool flag = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
				bool flag2 = Class20.smethod_31(num2 - 32, gstruct0_0.int_2, (uint)string_0.Length);
				bool flag3 = Class20.smethod_31(num2 - 56 + 4, gstruct0_0.int_2, (uint)string_0.Length);
				return flag && flag2 && flag3;
			}
			return false;
		}
		return false;
	}

	public static bool smethod_21(GStruct0 gstruct0_0, string string_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_1 != 0)
		{
			uint num = Class20.smethod_30(gstruct0_0.uint_1 + Class9.uint_34, gstruct0_0.int_2);
			if (num == 0)
			{
				return false;
			}
			uint uint_ = num + Class9.uint_37 + Class9.uint_35;
			uint num2 = Class20.smethod_30(uint_, gstruct0_0.int_2);
			if (num2 == 0)
			{
				return false;
			}
			int int_ = 0;
			byte[] array = Class11.smethod_41(string_0);
			bool flag = Class20.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref int_);
			bool flag2 = Class20.smethod_31(num2 - 32, gstruct0_0.int_2, (uint)string_0.Length);
			bool flag3 = Class20.smethod_31(num2 - 56 + 4, gstruct0_0.int_2, (uint)string_0.Length);
			return flag && flag2 && flag3;
		}
		return false;
	}

	public static bool smethod_22(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_9 != 0)
		{
			smethod_0(gstruct0_0.int_2, gstruct0_0.uint_9);
			return true;
		}
		return false;
	}

	public static bool smethod_23(GStruct0 gstruct0_0, int int_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_10 != 0)
		{
			bool result;
			if (result = Class20.smethod_31(gstruct0_0.uint_10 + 2, gstruct0_0.int_2, (uint)int_0))
			{
				smethod_0(gstruct0_0.int_2, gstruct0_0.uint_10);
			}
			return result;
		}
		return false;
	}

	public static bool smethod_24(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_11 != 0)
		{
			smethod_0(gstruct0_0.int_2, gstruct0_0.uint_11);
			return true;
		}
		return false;
	}

	public static string smethod_25(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 == 0)
		{
			return string.Empty;
		}
		uint num = smethod_14(gstruct0_0);
		if (num != 0)
		{
			return Class20.smethod_28(num, gstruct0_0.int_2, 80);
		}
		return string.Empty;
	}

	public static bool smethod_26(GStruct0 gstruct0_0, string string_0)
	{
		if (gstruct0_0.int_1 != 0)
		{
			uint num = smethod_14(gstruct0_0);
			if (num != 0)
			{
				int int_ = 0;
				byte[] array = Class11.smethod_41(string_0);
				return Class20.WriteProcessMemory(gstruct0_0.int_2, num, array, array.Length, ref int_);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_27(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && gstruct0_0.uint_12 != 0)
		{
			smethod_0(gstruct0_0.int_2, gstruct0_0.uint_12);
			return true;
		}
		return false;
	}

	public static void smethod_28(GStruct0 gstruct0_0, string string_0)
	{
		if (string_0.Length >= 127)
		{
			string_0 = string_0.Substring(0, 127);
		}
		if (128 <= string_0.Length)
		{
			string_0 = string_0.Substring(0, 127);
		}
		byte[] array = Class11.smethod_41(string_0);
		int int_ = 0;
		uint uint_ = gstruct0_0.uint_14 - 128;
		Class20.WriteProcessMemory(gstruct0_0.int_2, uint_, array, array.Length, ref int_);
		smethod_0(gstruct0_0.int_2, gstruct0_0.uint_14);
	}

	public static string smethod_29(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && Class9.uint_34 != 0)
		{
			uint num = Class20.smethod_30(gstruct0_0.uint_1 + Class9.uint_34, gstruct0_0.int_2);
			if (num == 0)
			{
				return string.Empty;
			}
			uint uint_ = num + Class9.uint_36 + Class9.uint_35;
			uint num2 = Class20.smethod_30(uint_, gstruct0_0.int_2);
			if (num2 == 0)
			{
				return string.Empty;
			}
			return Class20.smethod_28(num2, gstruct0_0.int_2, 50);
		}
		return string.Empty;
	}

	public static string smethod_30(GStruct0 gstruct0_0)
	{
		if (gstruct0_0.int_1 != 0 && Class9.uint_34 != 0)
		{
			uint num = Class20.smethod_30(gstruct0_0.uint_1 + Class9.uint_34, gstruct0_0.int_2);
			if (num != 0)
			{
				uint uint_ = num + Class9.uint_37 + Class9.uint_35;
				uint num2 = Class20.smethod_30(uint_, gstruct0_0.int_2);
				if (num2 == 0)
				{
					return string.Empty;
				}
				return Class20.smethod_28(num2, gstruct0_0.int_2, 50);
			}
			return string.Empty;
		}
		return string.Empty;
	}

	public static int smethod_31(GStruct0 gstruct0_0)
	{
		uint uint_ = gstruct0_0.uint_1 + Class9.uint_66 + Class9.uint_67;
		int int_ = 0;
		byte[] array = new byte[2];
		Class20.ReadProcessMemory(gstruct0_0.int_2, uint_, array, 2, ref int_);
		return array[0] + array[1] * 256;
	}
}
