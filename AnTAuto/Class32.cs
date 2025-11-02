using System;
using System.Threading;

internal class Class32
{
	public static string string_0 = "<no name>";

	public static string[] string_1 = new string[2]
	{
		"tiÕn hµnh",
		"®ang"
	};

	public static string[] string_2 = new string[4]
	{
		"Chat('CH_NEARBY', '<color=green>XXX<color=white> YYY <color=red>cõu s\u00b8t<color=white> víi b¹n.')",
		"<color=white>* <color=green>XXX<color=yellow> YYY <color=red>cõu s\u00b8t<color=yellow> víi b¹n.",
		"------------------------------------------",
		"<color=white>* <color=green>KÕt thóc cõu s\u00b8t"
	};

	public static string string_3 = "Chat('CH_TONG', '<color=green>XXX<color=white> YYY <color=red>cõu s\u00b8t<color=white> víi b¹n.')";

	public static uint smethod_0(uint[] uint_0, uint[] uint_1)
	{
		if (uint_0 != null && uint_1 != null && uint_0[0] != 0 && uint_0[1] != 0 && uint_1[0] != 0 && uint_1[1] != 0)
		{
			long num = (int)(uint_0[0] - uint_1[0]);
			long num2 = (int)(uint_0[1] - uint_1[1]);
			long num3 = num * num + num2 * num2;
			if (num3 == 0L)
			{
				num3 = 1L;
			}
			return (uint)num3;
		}
		return 2147483647u;
	}

	public static uint smethod_1(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		return num3 + num2;
	}

	private static void smethod_2(GStruct42 gstruct42_0, uint uint_0, int int_0)
	{
		uint num = smethod_1(gstruct42_0);
		Class20.smethod_31(num + uint_0, gstruct42_0.int_130, (uint)int_0);
	}

	private static uint smethod_3(GStruct42 gstruct42_0, uint uint_0)
	{
		uint num = smethod_1(gstruct42_0);
		return Class20.smethod_30(num + uint_0, gstruct42_0.int_130);
	}

	public static string smethod_4(GStruct42 gstruct42_0)
	{
		string result = string_0;
		if (gstruct42_0.int_130 > 0)
		{
			uint num = smethod_1(gstruct42_0);
			string text = Class20.smethod_28(num + Class47.gstruct43_16.uint_0, gstruct42_0.int_130);
			if (text != "")
			{
				result = text;
			}
		}
		return result;
	}

	public static int smethod_5(GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_11.uint_0 != 0 && Class47.gstruct43_23.uint_0 != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			return (int)Class20.smethod_30(num + Class47.gstruct43_23.uint_0, gstruct42_0.int_130);
		}
		return 0;
	}

	public static bool smethod_6(GStruct42 gstruct42_0, ref GStruct40 gstruct40_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_30.uint_0;
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_61.uint_0, gstruct42_0.int_130);
		if (num2 != 0)
		{
			if (gstruct40_0.uint_0 != num2)
			{
				gstruct40_0.uint_0 = num2;
				gstruct40_0.uint_1 = Class20.smethod_30(num + 12, gstruct42_0.int_130);
				gstruct40_0.uint_2 = Class20.smethod_30(num + Class47.gstruct43_62.uint_0, gstruct42_0.int_130);
				gstruct40_0.string_0 = Class20.smethod_28(num + Class47.gstruct43_60.uint_0, gstruct42_0.int_130, 32);
				gstruct40_0.bool_0 = false;
			}
		}
		else if (gstruct40_0.uint_0 != 0)
		{
			gstruct40_0.uint_0 = 0u;
			gstruct40_0.string_0 = null;
		}
		return num2 != 0;
	}

	public static int smethod_7(GStruct42 gstruct42_0, uint uint_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
		int num4 = BitConverter.ToInt32(array, 0);
		if (num4 <= 1)
		{
			return 0;
		}
		int num5 = 0;
		for (int i = 1; i < 256; i++)
		{
			if (num4 <= num5)
			{
				break;
			}
			if (i == num3)
			{
				num5++;
				continue;
			}
			uint num6 = (uint)((int)num + i * (int)Class47.gstruct43_15.uint_0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num5++;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
			if (BitConverter.ToInt32(array, 0) <= 0 || (int)Class20.smethod_30(num6 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130) <= 0)
			{
				continue;
			}
			int num7 = (int)Class20.smethod_30(num6 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			if (num7 != 10 && num7 != 21)
			{
				int num8 = (int)Class20.smethod_30(num6 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130);
				if (num8 == 1 && uint_0 == Class20.smethod_30(num6, gstruct42_0.int_130))
				{
					return i;
				}
			}
		}
		return 0;
	}

	public static int[] smethod_8(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_32.uint_0, gstruct42_0.int_130);
		if (num != 0)
		{
			uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
			uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num5 = num4 + num3;
			uint num6 = Class20.smethod_30(num5 + 4160, gstruct42_0.int_130);
			uint num7 = Class20.smethod_30(num + Class47.gstruct43_34.uint_0, gstruct42_0.int_130);
			uint num8 = Class20.smethod_30(num7 + num6 * Class47.gstruct43_33.uint_0 + Class47.gstruct43_40.uint_0, gstruct42_0.int_130);
			int[] int_ = null;
			while (num8 != 0)
			{
				uint num9 = Class20.smethod_30(num8 + 4, gstruct42_0.int_130);
				uint num10 = Class20.smethod_30(num8 + 16, gstruct42_0.int_130);
				uint num11 = Class20.smethod_30(Class47.gstruct43_41.uint_0, gstruct42_0.int_130);
				num8 = num9;
				if (num11 == 0)
				{
					continue;
				}
				uint uint_ = num10 * Class47.gstruct43_15.uint_0 + num11 + Class47.gstruct43_42.uint_0;
				uint num12 = Class20.smethod_30(uint_, gstruct42_0.int_130);
				while (num12 != 0)
				{
					uint num13 = Class20.smethod_30(num12 + 4, gstruct42_0.int_130);
					int num14 = (int)Class20.smethod_30(num12 + 24, gstruct42_0.int_130);
					num12 = num13;
					if (num14 > 0 && num14 < 6001)
					{
						Class11.smethod_32(ref int_, num14);
					}
				}
			}
			return int_;
		}
		return null;
	}

	public static bool smethod_9(GStruct42 gstruct42_0, uint uint_0)
	{
		if (gstruct42_0.bool_34)
		{
			return true;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint uint_ = num3 + num2 + Class47.gstruct43_72.uint_0;
		return Class20.smethod_31(uint_, gstruct42_0.int_130, uint_0);
	}

	public static void smethod_10(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		uint uint_ = 5u;
		uint uint_2 = uint.MaxValue;
		uint uint_3 = uint_0;
		uint num = smethod_1(gstruct42_0);
		if (uint_0 == 0)
		{
			uint_2 = Class20.smethod_30(num + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130);
			uint_3 = Class20.smethod_30(num + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130);
		}
		Class20.smethod_31(num + Class47.gstruct43_37.uint_0, gstruct42_0.int_130, uint_2);
		Class20.smethod_31(num + Class47.gstruct43_38.uint_0, gstruct42_0.int_130, uint_3);
		Class20.smethod_31(num + Class47.gstruct43_36.uint_0, gstruct42_0.int_130, (uint)int_0);
		Class20.smethod_31(num + Class47.gstruct43_35.uint_0, gstruct42_0.int_130, uint_);
	}

	public static string smethod_11(GStruct42 gstruct42_0)
	{
		uint num = smethod_1(gstruct42_0);
		string result = "";
		if (gstruct42_0.int_130 > 0 && num != 0)
		{
			result = Class20.smethod_28(num + Class47.gstruct43_86.uint_0, gstruct42_0.int_130, 32);
		}
		return result;
	}

	public static uint smethod_12(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		return Class20.smethod_30(num4 + Class47.gstruct43_85.uint_0, gstruct42_0.int_130);
	}

	public static int smethod_13(GStruct42 gstruct42_0, uint uint_0 = 0u, uint uint_1 = 0u)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = 0u;
		if (uint_1 == 0)
		{
			switch (uint_0)
			{
			case 1u:
				num2 = Class47.gstruct43_79.uint_0;
				break;
			default:
				num2 = Class47.gstruct43_83.uint_0;
				break;
			case 2u:
				num2 = Class47.gstruct43_81.uint_0;
				break;
			case 0u:
				num2 = Class47.gstruct43_77.uint_0;
				break;
			}
		}
		else
		{
			switch (uint_0)
			{
			case 0u:
				num2 = Class47.gstruct43_78.uint_0;
				break;
			case 1u:
				num2 = Class47.gstruct43_80.uint_0;
				break;
			default:
				num2 = Class47.gstruct43_84.uint_0;
				break;
			case 2u:
				num2 = Class47.gstruct43_82.uint_0;
				break;
			}
		}
		return (int)Class20.smethod_30(num + Class47.gstruct43_12.uint_0 + num2, gstruct42_0.int_130);
	}

	public static int smethod_14(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return (int)Class20.smethod_30(num + Class47.gstruct43_12.uint_0 + Class47.gstruct43_76.uint_0, gstruct42_0.int_130);
	}

	public static int smethod_15(GStruct42 gstruct42_0)
	{
		uint uint_ = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return (int)Class20.smethod_30(uint_, gstruct42_0.int_130);
	}

	public static int smethod_16(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return (int)Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
	}

	public static bool smethod_17(GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_102.uint_0 != 0 && Class47.gstruct43_103.uint_0 != 0 && Class47.gstruct43_107.uint_0 != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			int int_ = 0;
			byte[] array = new byte[4];
			int num3 = Class69.smethod_2(gstruct42_0);
			int num4 = 0;
			for (uint num5 = 1u; num5 < Class47.int_1; num5++)
			{
				if (0 < num3 && num3 <= num4)
				{
					break;
				}
				uint num6 = num2 + num5 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) != 0)
				{
					continue;
				}
				uint num7 = Class69.smethod_0(gstruct42_0, num5);
				if ((int)num7 <= 0)
				{
					continue;
				}
				num4++;
				uint num8 = Class20.smethod_30(num6 + Class47.gstruct43_107.uint_0, gstruct42_0.int_130);
				if (num8 == 10)
				{
					uint num9 = num + Class47.gstruct43_94.uint_0 + num7 * 20;
					uint num10 = Class20.smethod_30(num9 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
					if (num10 == 2)
					{
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	public static bool smethod_18(GStruct42 gstruct42_0)
	{
		int num = (int)smethod_3(gstruct42_0, Class47.gstruct43_44.uint_0);
		return num > 0;
	}

	public static long smethod_19(GStruct42 gstruct42_0)
	{
		return smethod_3(gstruct42_0, Class47.gstruct43_45.uint_0);
	}

	public static long smethod_20(GStruct42 gstruct42_0)
	{
		return smethod_3(gstruct42_0, Class47.gstruct43_47.uint_0);
	}

	public static long smethod_21(GStruct42 gstruct42_0)
	{
		return smethod_3(gstruct42_0, Class47.gstruct43_47.uint_0 + 4);
	}

	public static long smethod_22(GStruct42 gstruct42_0)
	{
		return smethod_3(gstruct42_0, Class47.gstruct43_46.uint_0);
	}

	public static long smethod_23(GStruct42 gstruct42_0)
	{
		return smethod_3(gstruct42_0, Class47.gstruct43_48.uint_0);
	}

	public static uint smethod_24(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_12.uint_0;
		return Class20.smethod_30(num2 + Class47.gstruct43_24.uint_0, gstruct42_0.int_130);
	}

	public static uint smethod_25(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_12.uint_0;
		return Class20.smethod_30(num2 + Class47.gstruct43_25.uint_0, gstruct42_0.int_130);
	}

	public static int smethod_26(GStruct42 gstruct42_0)
	{
		return (int)smethod_3(gstruct42_0, Class47.gstruct43_43.uint_0);
	}

	public static int smethod_27(GStruct42 gstruct42_0)
	{
		return (int)smethod_3(gstruct42_0, Class47.gstruct43_50.uint_0);
	}

	public static int smethod_28(GStruct42 gstruct42_0)
	{
		return (int)smethod_3(gstruct42_0, Class47.gstruct43_53.uint_0);
	}

	public static uint[] smethod_29(GStruct42 gstruct42_0)
	{
		uint num = smethod_3(gstruct42_0, Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0);
		uint num2 = smethod_3(gstruct42_0, Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0);
		if (num != 0 && num2 != 0)
		{
			return new uint[2]
			{
				num,
				num2
			};
		}
		return null;
	}

	public static int smethod_30(GStruct42 gstruct42_0)
	{
		return (int)smethod_3(gstruct42_0, Class47.gstruct43_55.uint_0);
	}

	public static int smethod_31(GStruct42 gstruct42_0)
	{
		return (int)smethod_3(gstruct42_0, Class47.gstruct43_66.uint_0);
	}

	public static int smethod_32(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return (int)Class20.smethod_30(num + Class47.gstruct43_12.uint_0 + Class47.gstruct43_68.uint_0, gstruct42_0.int_130);
	}

	public static int smethod_33(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return (int)Class20.smethod_30(num + Class47.gstruct43_12.uint_0 + Class47.gstruct43_70.uint_0, gstruct42_0.int_130);
	}

	public static int smethod_34(GStruct42 gstruct42_0)
	{
		int num = (int)smethod_3(gstruct42_0, Class47.gstruct43_54.uint_0);
		if (num > 4)
		{
			num = 5;
		}
		return num;
	}

	public static int smethod_35(GStruct42 gstruct42_0)
	{
		return (int)smethod_3(gstruct42_0, Class47.gstruct43_51.uint_0);
	}

	public static int smethod_36(GStruct42 gstruct42_0)
	{
		return (int)smethod_3(gstruct42_0, Class47.gstruct43_56.uint_0);
	}

	public static bool smethod_37(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_30.uint_0 + Class47.gstruct43_62.uint_0, gstruct42_0.int_130);
		return num2 == 2;
	}

	public static uint smethod_38(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return Class20.smethod_30(num + Class47.gstruct43_30.uint_0 + Class47.gstruct43_61.uint_0, gstruct42_0.int_130);
	}

	public static int smethod_39(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_30.uint_0 + Class47.gstruct43_61.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
		int num4 = BitConverter.ToInt32(array, 0);
		if (num4 <= 1)
		{
			return 0;
		}
		int num5 = (int)Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		int num6 = 0;
		for (uint num7 = 1u; num7 < 256; num7++)
		{
			if (num4 <= num6)
			{
				break;
			}
			if (num7 != num5)
			{
				uint num8 = num3 + num7 * Class47.gstruct43_15.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num6++;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) > 0)
				{
					uint num9 = Class20.smethod_30(num8, gstruct42_0.int_130);
					if (num9 == num2)
					{
						return (int)num7;
					}
				}
			}
			else
			{
				num6++;
			}
		}
		return 0;
	}

	public static int smethod_40(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint uint_ = num + Class47.gstruct43_30.uint_0 + Class47.gstruct43_65.uint_0;
		return (int)Class20.smethod_30(uint_, gstruct42_0.int_130);
	}

	public static string smethod_41(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return Class20.smethod_28(num + Class47.gstruct43_30.uint_0 + Class47.gstruct43_60.uint_0, gstruct42_0.int_130, 32);
	}

	public static uint smethod_42(GStruct42 gstruct42_0, bool bool_0 = false)
	{
		uint uint_ = Class47.gstruct43_73.uint_0;
		if (bool_0)
		{
			uint_ = Class47.gstruct43_74.uint_0;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_12.uint_0;
		uint uint_2 = num + Class47.gstruct43_75.uint_0 + uint_;
		return Class20.smethod_30(uint_2, gstruct42_0.int_130);
	}

	public static void smethod_43(GStruct42 gstruct42_0, uint uint_0, bool bool_0 = true)
	{
		uint uint_ = Class47.gstruct43_74.uint_0;
		if (bool_0)
		{
			uint_ = Class47.gstruct43_73.uint_0;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_12.uint_0;
		uint uint_2 = num + Class47.gstruct43_75.uint_0 + uint_;
		Class20.smethod_31(uint_2, gstruct42_0.int_130, uint_0);
	}

	public static int[] smethod_44(GStruct42 gstruct42_0, int int_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return new int[2]
		{
			(int)Class20.smethod_30((uint)((int)(num + Class47.gstruct43_12.uint_0 + Class47.gstruct43_76.uint_0) + int_0 * 4 + 8), gstruct42_0.int_130),
			(int)Class20.smethod_30((uint)((int)(num + Class47.gstruct43_12.uint_0 + Class47.gstruct43_76.uint_0) + int_0 * 4 + 32), gstruct42_0.int_130)
		};
	}

	public static int smethod_45(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return (int)Class20.smethod_30(num + Class47.gstruct43_12.uint_0 + Class47.gstruct43_76.uint_0, gstruct42_0.int_130);
	}

	public static bool smethod_46(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_93.uint_0, gstruct42_0.int_130);
		return num != 0;
	}

	public static int smethod_47(GStruct42 gstruct42_0, int int_0)
	{
		uint num = (uint)((int)(Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0) + (int)Class47.gstruct43_2.uint_0 * int_0);
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num5 = num4 + num3 * Class47.gstruct43_15.uint_0;
		return (int)Class20.smethod_30(num5 + num, gstruct42_0.int_130);
	}

	public static bool smethod_48(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		int num5 = 0;
		for (uint num6 = 0u; num6 < 6; num6++)
		{
			uint num7 = Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0 + Class47.gstruct43_2.uint_0 * num6;
			int num8 = (int)Class20.smethod_30(num4 + num7 + 20, gstruct42_0.int_130);
			if (num8 == 1)
			{
				num5++;
			}
		}
		return num5 > 5;
	}

	public static bool smethod_49(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		int int_ = 0;
		byte[] array = new byte[1];
		Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_38.uint_0 + 4, array, 1, ref int_);
		return array[0] > 0;
	}

	public static string smethod_50(GStruct42 gstruct42_0)
	{
		uint num = smethod_1(gstruct42_0);
		if (gstruct42_0.int_130 != 0 && num != 0)
		{
			byte[] array = new byte[80];
			int int_ = 0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_86.uint_0, array, array.Length, ref int_);
			return Class10.smethod_3(array);
		}
		return string.Empty;
	}

	public static void smethod_51(GStruct42 gstruct42_0, string string_4)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2;
		if (gstruct42_0.int_130 == 0 || num4 == 0)
		{
			return;
		}
		byte[] array = new byte[4];
		byte[] array2 = array;
		if (string_4 != "")
		{
			char[] array3 = string_4.ToCharArray();
			array2 = new byte[array3.Length + 1];
			for (int i = 0; i < array3.Length; i++)
			{
				array2[i] = (byte)array3[i];
			}
			array2[array2.Length - 1] = 0;
		}
		int int_ = 0;
		Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_86.uint_0, array2, array2.Length, ref int_);
	}

	public static void smethod_52(GStruct42 gstruct42_0, int int_0 = 75)
	{
		smethod_2(gstruct42_0, Class47.gstruct43_31.uint_0, int_0);
	}

	public static void smethod_53(GStruct42 gstruct42_0, int int_0)
	{
		smethod_2(gstruct42_0, Class47.gstruct43_43.uint_0, int_0);
	}

	public static void smethod_54(GStruct42 gstruct42_0, int int_0 = 0)
	{
		smethod_2(gstruct42_0, Class47.gstruct43_56.uint_0, int_0);
	}

	public static void smethod_55(GStruct42 gstruct42_0, uint[] uint_0, bool bool_0, int int_0 = 10)
	{
		if (!bool_0 && (uint_0 == null || uint_0[0] == 0 || uint_0[1] == 0))
		{
			return;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		int i = 0;
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] byte_ = array;
		for (; i < int_0; i++)
		{
			if (bool_0)
			{
				uint num5 = Class38.gstruct29_0.uint_5 >> 16;
				uint int_2 = Class38.gstruct29_0.uint_5 - (num5 << 16);
				uint_0 = Class73.smethod_11(Class38.gstruct29_0.uint_4, (int)int_2, (int)num5);
			}
			if (uint_0 != null && uint_0[0] != 0 && uint_0[1] != 0)
			{
				if (uint_0 != null)
				{
					Class60.smethod_61(gstruct42_0, uint_0);
					Thread.Sleep(200);
				}
				Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
				uint[] uint_ = new uint[2]
				{
					Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				if (smethod_0(uint_, uint_0) < 11250)
				{
					break;
				}
				continue;
			}
			break;
		}
	}

	public static void smethod_56(GStruct42 gstruct42_0)
	{
		for (int i = 0; i < 80; i++)
		{
			if (Class60.smethod_3(gstruct42_0, Class60.uint_6) <= 0)
			{
				break;
			}
			Thread.Sleep(10);
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] byte_ = array;
		array = new byte[4];
		byte[] byte_2 = array;
		Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_31.uint_0, byte_2, 4, ref int_);
		Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(75), 4, ref int_);
		uint uint_ = 5u;
		uint uint_2 = Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130);
		uint uint_3 = Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130);
		for (int j = 0; j < 3; j++)
		{
			Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
			Thread.Sleep(10);
			Class20.smethod_31(num4 + Class47.gstruct43_37.uint_0, gstruct42_0.int_130, uint_2);
			Class20.smethod_31(num4 + Class47.gstruct43_38.uint_0, gstruct42_0.int_130, uint_3);
			Class20.smethod_31(num4 + Class47.gstruct43_36.uint_0, gstruct42_0.int_130, 715u);
			Class20.smethod_31(num4 + Class47.gstruct43_35.uint_0, gstruct42_0.int_130, uint_);
			Thread.Sleep(210 - j * 100);
		}
		Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_31.uint_0, byte_2, 4, ref int_);
		Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_35.uint_0, byte_, 4, ref int_);
	}

	public static bool smethod_57(GStruct42 gstruct42_0)
	{
		for (int i = 0; i < 80; i++)
		{
			if (Class60.smethod_3(gstruct42_0, Class60.uint_6) <= 0)
			{
				break;
			}
			Thread.Sleep(10);
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		int int_ = 0;
		byte[] array = new byte[4];
		uint num5 = 0u;
		while (true)
		{
			if (num5 < 6)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0 + Class47.gstruct43_2.uint_0 * num5, array, 4, ref int_);
				int num6 = BitConverter.ToInt32(array, 0);
				if (num6 == 122)
				{
					break;
				}
				num5++;
				continue;
			}
			byte[] array2 = new byte[4];
			byte[] byte_ = array2;
			byte[] byte_2 = new byte[4];
			Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_31.uint_0, byte_2, 4, ref int_);
			int i = 0;
			int num7 = -1;
			for (; i < 150; i++)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_55.uint_0, array, 1, ref int_);
				if (array[0] < 4 && (num7 == -1 || num7 > 80))
				{
					break;
				}
				Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
				num7 = ((array[0] <= 3) ? (num7 + 1) : 0);
				Thread.Sleep(1);
			}
			Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_31.uint_0, byte_, 4, ref int_);
			byte[] byte_3 = new byte[4]
			{
				5,
				0,
				0,
				0
			};
			byte[] bytes = BitConverter.GetBytes(716);
			byte[] byte_4 = new byte[4];
			byte[] byte_5 = new byte[4];
			Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, byte_4, 4, ref int_);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, byte_5, 4, ref int_);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_37.uint_0, byte_4, 4, ref int_);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_38.uint_0, byte_5, 4, ref int_);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_36.uint_0, bytes, bytes.Length, ref int_);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_35.uint_0, byte_3, 4, ref int_);
			Thread.Sleep(100);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_31.uint_0, byte_2, 4, ref int_);
			return false;
		}
		return true;
	}

	public static void smethod_58(GStruct42 gstruct42_0, string string_4)
	{
		uint num = smethod_1(gstruct42_0);
		if (gstruct42_0.int_130 != 0 && num != 0 && Class47.gstruct43_253.uint_0 != 0)
		{
			byte[] array = Class11.smethod_41(string_4);
			int int_ = 0;
			Class20.WriteProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_253.uint_0, array, array.Length, ref int_);
		}
	}

	public static uint smethod_59(GStruct42 gstruct42_0, int[] int_0)
	{
		if (int_0 == null)
		{
			int_0 = new int[1]
			{
				1
			};
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		uint num5 = Class20.smethod_30(num4 + Class47.gstruct43_72.uint_0, gstruct42_0.int_130);
		if ((int)num5 > 0)
		{
			uint num6 = num3 + num5 * Class47.gstruct43_15.uint_0;
			if (Class20.smethod_30(num6 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130) != 0)
			{
				int num7 = (int)Class20.smethod_30(num6 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130);
				int num8 = 0;
				while (true)
				{
					if (num8 < int_0.Length)
					{
						if (num7 == int_0[num8])
						{
							break;
						}
						num8++;
						continue;
					}
					return 0u;
				}
				return num5;
			}
			return 0u;
		}
		return 0u;
	}
}
