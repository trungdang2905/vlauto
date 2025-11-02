using System;

internal class Class58
{
	public static GStruct43 gstruct43_0 = new GStruct43
	{
		string_0 = "LUALIBDLL_CASH_1",
		string_1 = "3C 3D 56 57 75",
		byte_0 = Class11.smethod_10("53 8B 5C 24 0C"),
		int_2 = 0,
		byte_2 = 1,
		int_0 = -7
	};

	public static GStruct43 gstruct43_1 = new GStruct43
	{
		string_0 = "LUALIBDLL_CASH_2",
		string_1 = "83 F9 06 77 ?? ?? FF",
		byte_0 = Class11.smethod_10("57 8B F9 8B 08"),
		int_2 = 0,
		byte_2 = 1,
		int_0 = -5
	};

	public static GStruct43 gstruct43_2 = new GStruct43
	{
		string_0 = "LUALIBDLL_CASH_3",
		string_1 = "89 ?? ?? 8B ?? ?? 89 ?? ?? C7",
		byte_0 = Class11.smethod_10("8B 51 44 83 C2 14"),
		int_2 = 0,
		byte_2 = 1,
		int_0 = -6
	};

	public static GStruct43 gstruct43_3 = new GStruct43
	{
		string_0 = "LUALIBDLL_CASH_4",
		string_1 = "5E 5F 5D 5B 81 C4 ?? ?? ?? ?? C3",
		byte_0 = Class11.smethod_10("8B 44 94 10 8B 04 83"),
		int_2 = 0,
		byte_2 = 1,
		int_0 = -7
	};

	public static GStruct43 gstruct43_4 = new GStruct43
	{
		string_0 = "LUALIBDLL_CASH_5",
		string_1 = "66 ?? ?? ?? 00 75 ?? 8B ?? ?? E8",
		byte_0 = Class11.smethod_10("39 76 08 75 1B"),
		int_2 = 0,
		byte_2 = 1,
		int_0 = -5
	};

	public static GStruct43 gstruct43_5 = new GStruct43
	{
		string_0 = "LUALIBDLL_CASH_6",
		string_1 = "39 ?? ?? 74 ?? 8B ?? ?? 85 ?? 75",
		byte_0 = Class11.smethod_10("83 38 03 75 05"),
		int_2 = 0,
		byte_2 = 1,
		int_0 = -5
	};

	public static GStruct43 gstruct43_6 = new GStruct43
	{
		string_0 = "LUALIBDLL_CASH_7",
		string_1 = "66 ?? ?? ?? 00 75 ?? B8 01",
		byte_0 = Class11.smethod_10("8B 40 08 8B 08"),
		int_2 = 0,
		byte_2 = 1,
		int_0 = -5
	};

	public static void smethod_0(GStruct42 gstruct42_0, bool bool_0)
	{
		if (gstruct42_0.uint_6 == 0)
		{
			return;
		}
		int int_ = 0;
		uint uint_ = 24976 + gstruct42_0.uint_6;
		byte[] array = new byte[3];
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 3, ref int_);
		byte[] array2 = null;
		byte[] array3 = null;
		if (!bool_0)
		{
			array2 = new byte[3]
			{
				194,
				24,
				0
			};
			array3 = new byte[3]
			{
				85,
				139,
				236
			};
		}
		else
		{
			array2 = new byte[3]
			{
				85,
				139,
				236
			};
			array3 = new byte[3]
			{
				194,
				24,
				0
			};
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != array2[i])
			{
				return;
			}
		}
		Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, array3, 3, ref int_);
	}

	public static int smethod_1(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_15 == 0)
		{
			return 0;
		}
		uint num = gstruct42_0.uint_7;
		if (num == 0)
		{
			num = Class20.smethod_37(gstruct42_0.int_129, "engine.dll");
			if (num == 0)
			{
				return 0;
			}
		}
		uint num2 = gstruct42_0.uint_8;
		if (num2 == 0)
		{
			num2 = Class20.smethod_37(gstruct42_0.int_129, "lualibdll.dll");
			if (num2 == 0)
			{
				return 0;
			}
		}
		if (gstruct42_0.uint_6 == 0)
		{
			gstruct42_0.uint_6 = 4194304u;
		}
		uint num3 = 0u;
		uint num4 = num + Class47.gstruct43_4.uint_0;
		uint num5 = gstruct42_0.uint_15 + gstruct42_0.uint_16;
		if (smethod_3(gstruct42_0, Class47.gstruct43_4, num4))
		{
			num3 = num4 - (num5 + 18) + 9;
			string string_ = "85 C0 75 04 33 C0 59 C3 80 38 00 74 F7E9" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true);
			smethod_2(gstruct42_0, num5, string_, num4, num5 - num4 - 5, 0);
		}
		gstruct42_0.uint_16 += 48u;
		uint num6 = num2 + gstruct43_0.uint_0;
		num5 = gstruct42_0.uint_15 + gstruct42_0.uint_16;
		if (smethod_3(gstruct42_0, gstruct43_0, num6))
		{
			num3 = num6 - (num5 + 18) + 5;
			string string_ = "83 7C 24 08 00 75 01 C3 53 8B 5C 24 0CE9" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true);
			smethod_2(gstruct42_0, num5, string_, num6, num5 - num6 - 5, 0);
		}
		gstruct42_0.uint_16 += 48u;
		num6 = num2 + gstruct43_1.uint_0;
		num5 = gstruct42_0.uint_15 + gstruct42_0.uint_16;
		if (smethod_3(gstruct42_0, gstruct43_1, num6))
		{
			num3 = num6 - (num5 + 23) + 5;
			string string_ = "85 C0 74 0B 57 8B F9 8B 48 08 85 C9 75 02 5F C3 8B 08E9" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true);
			smethod_2(gstruct42_0, num5, string_, num6, num5 - num6 - 5, 0);
		}
		gstruct42_0.uint_16 += 48u;
		num6 = num2 + gstruct43_2.uint_0;
		num5 = gstruct42_0.uint_15 + gstruct42_0.uint_16;
		if (smethod_3(gstruct42_0, gstruct43_2, num6))
		{
			num3 = num6 - (num5 + 16) + 6;
			string string_ = "85 C9 75 01 C3 8B 51 44 83 C2 14E9" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true);
			smethod_2(gstruct42_0, num5, string_, num6, num5 - num6 - 5, 1);
		}
		gstruct42_0.uint_16 += 48u;
		num6 = num2 + gstruct43_3.uint_0;
		num5 = gstruct42_0.uint_15 + gstruct42_0.uint_16;
		if (smethod_3(gstruct42_0, gstruct43_3, num6))
		{
			num3 = num6 - (num5 + 20) + 7;
			string string_ = "85 DB 75 04 33 C0 EB 07 8B 44 94 10 8B 04 83E9" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true);
			smethod_2(gstruct42_0, num5, string_, num6, num5 - num6 - 5, 2);
		}
		gstruct42_0.uint_16 += 48u;
		num6 = num2 + gstruct43_4.uint_0;
		num5 = gstruct42_0.uint_15 + gstruct42_0.uint_16;
		if (smethod_3(gstruct42_0, gstruct43_4, num6))
		{
			num3 = num6 - (num5 + 15) + 5;
			string string_ = "85 F6 75 01 C3 39 76 08 75 FAE9" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true);
			smethod_2(gstruct42_0, num5, string_, num6, num5 - num6 - 5, 0);
		}
		gstruct42_0.uint_16 += 48u;
		num6 = num2 + gstruct43_5.uint_0;
		num5 = gstruct42_0.uint_15 + gstruct42_0.uint_16;
		if (smethod_3(gstruct42_0, gstruct43_5, num6))
		{
			num3 = num6 - (num5 + 23) + 5;
			uint num7 = num6 - (num5 + 9) + 17;
			uint num8 = num6 - (num5 + 18) + 10;
			string string_ = "85 C0 75 05E9" + Class11.smethod_40(num7, 8, bool_1: false, bool_2: true) + "83 38 030F 85" + Class11.smethod_40(num8, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true);
			smethod_2(gstruct42_0, num5, string_, num6, num5 - num6 - 5, 0);
		}
		gstruct42_0.uint_16 += 48u;
		num6 = num2 + gstruct43_6.uint_0;
		num5 = gstruct42_0.uint_15 + gstruct42_0.uint_16;
		if (smethod_3(gstruct42_0, gstruct43_6, num6))
		{
			num3 = num6 - (num5 + 25) + 5;
			string string_ = "85 C0 75 03 33 C0 C3 8B 40 08 85 C0 74 F6 8B 08 85 C9 74 F0E9" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true);
			smethod_2(gstruct42_0, num5, string_, num6, num5 - num6 - 5, 0);
			return 1;
		}
		return 1;
	}

	private static int smethod_2(GStruct42 gstruct42_0, uint uint_0, string string_0, uint uint_1, uint uint_2, byte byte_0 = 0)
	{
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_0, bool_1: false);
		Class20.WriteProcessMemory(gstruct42_0.int_130, uint_0, array, array.Length, ref int_);
		Class20.smethod_43(gstruct42_0.process_0);
		Class20.WriteProcessMemory(gstruct42_0.int_130, uint_1, new byte[1]
		{
			233
		}, 1, ref int_);
		array = BitConverter.GetBytes(uint_2);
		Class20.WriteProcessMemory(gstruct42_0.int_130, uint_1 + 1, array, array.Length, ref int_);
		if (byte_0 > 0)
		{
			array = new byte[byte_0];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = 144;
			}
			Class20.WriteProcessMemory(gstruct42_0.int_130, uint_1 + 5, array, array.Length, ref int_);
		}
		Class20.smethod_45(gstruct42_0.process_0);
		return 1;
	}

	private static bool smethod_3(GStruct42 gstruct42_0, GStruct43 gstruct43_7, uint uint_0)
	{
		if (gstruct43_7.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_0, array, array.Length, ref int_);
			byte[] array2 = gstruct43_7.byte_0;
			if (array2 == null)
			{
				array2 = Class11.smethod_10(gstruct43_7.string_1);
			}
			for (int i = 0; i < array.Length && array2.Length > i; i++)
			{
				if (array2[i] != 63 && array2[i] != array[i])
				{
					if (array[0] == 233)
					{
						break;
					}
					return false;
				}
			}
			return true;
		}
		return false;
	}
}
