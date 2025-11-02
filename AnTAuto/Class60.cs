using System;
using System.Threading;

internal class Class60
{
	public static uint uint_0 = 32768u;

	public static uint uint_1 = 512u;

	private static uint uint_2 = 256u;

	private static uint uint_3 = 256u;

	private static uint uint_4 = 256u;

	public static uint uint_5 = 1u;

	public static uint uint_6 = 2u;

	public static uint uint_7 = 16u;

	public static uint uint_8 = 17u;

	public static uint uint_9 = 32u;

	public static uint uint_10 = 33u;

	public static uint uint_11 = 34u;

	public static uint uint_12 = 35u;

	public static uint uint_13 = 36u;

	public static uint uint_14 = 37u;

	public static uint uint_15 = 48u;

	public static uint uint_16 = 256u;

	public static uint uint_17 = 0u;

	public static void smethod_0(GStruct42 gstruct42_0, uint uint_18)
	{
		DateTime now = DateTime.Now;
		int int_ = now.Second + now.Minute * 60 + now.Hour * 60 * 60;
		smethod_2(gstruct42_0, uint_18, int_, 4);
	}

	public static int smethod_1(GStruct42 gstruct42_0, uint uint_18)
	{
		DateTime now = DateTime.Now;
		int num = now.Second + now.Minute * 60 + now.Hour * 60 * 60;
		int num2 = smethod_3(gstruct42_0, uint_18);
		return Math.Abs(num2 - num);
	}

	public static void smethod_2(GStruct42 gstruct42_0, uint uint_18, int int_0, byte byte_0 = 4)
	{
		if (gstruct42_0.uint_10 != 0)
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(int_0);
			Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_10 + uint_18 * 4, bytes, byte_0, ref int_);
		}
	}

	public static int smethod_3(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_10 == 0)
		{
			return 0;
		}
		int int_ = 0;
		byte[] array = new byte[4];
		Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_10 + uint_18 * 4, array, 4, ref int_);
		if (array[1] <= 0 && array[2] <= 0 && array[3] <= 0)
		{
			return array[0];
		}
		return BitConverter.ToInt32(array, 0);
	}

	public static uint smethod_4(uint uint_18, uint uint_19, uint uint_20, uint uint_21)
	{
		long num = (int)(uint_18 - uint_20);
		long num2 = (int)(uint_19 - uint_21);
		return (uint)(num * num + num2 * num2);
	}

	private static void smethod_5(int int_0, uint uint_18, byte[] byte_0)
	{
		int int_ = 0;
		Class20.WriteProcessMemory(int_0, uint_18, byte_0, byte_0.Length, ref int_);
	}

	private static void smethod_6(int int_0, uint uint_18, string string_0, bool bool_0 = true)
	{
		byte[] byte_ = Class11.smethod_41(string_0, bool_0);
		smethod_5(int_0, uint_18, byte_);
	}

	public static bool smethod_7(GStruct42 gstruct42_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_13.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		uint num3 = num2 * Class47.gstruct43_15.uint_0;
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
		uint num4 = BitConverter.ToUInt32(array, 0);
		uint num5 = num4 + num3;
		Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_55.uint_0, array, 4, ref int_);
		int num6 = BitConverter.ToInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
		int num7 = BitConverter.ToInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_);
		int num8 = BitConverter.ToInt32(array, 0);
		int num9 = Class73.smethod_40(gstruct42_0);
		return num7 > 0 && num8 > 0 && num6 > 0 && num9 > 1;
	}

	public static void smethod_8(ref GStruct42 gstruct42_0)
	{
		if (uint_17 == 0)
		{
			uint num = Class20.smethod_37(Class20.smethod_56(), "ntdll.dll");
			uint_17 = Class20.GetProcAddress(num, "RtlExitUserThread");
		}
		gstruct42_0.uint_12 = 4096u;
		gstruct42_0.uint_91 = smethod_9(ref gstruct42_0);
		gstruct42_0.uint_87 = smethod_58(ref gstruct42_0);
		gstruct42_0.uint_46 = smethod_60(ref gstruct42_0);
		gstruct42_0.uint_82 = smethod_62(ref gstruct42_0);
		gstruct42_0.uint_78 = smethod_54(ref gstruct42_0);
		gstruct42_0.uint_75 = smethod_51(ref gstruct42_0);
		gstruct42_0.uint_76 = smethod_49(ref gstruct42_0);
		gstruct42_0.uint_77 = smethod_47(ref gstruct42_0);
		gstruct42_0.uint_38 = smethod_45(ref gstruct42_0);
		gstruct42_0.uint_39 = smethod_43(ref gstruct42_0);
		gstruct42_0.uint_41 = smethod_40(ref gstruct42_0);
		gstruct42_0.uint_66 = smethod_38(ref gstruct42_0);
		gstruct42_0.uint_55 = smethod_83(ref gstruct42_0);
		gstruct42_0.uint_57 = smethod_34(ref gstruct42_0);
		gstruct42_0.uint_56 = smethod_32(ref gstruct42_0);
		gstruct42_0.uint_51 = smethod_31(ref gstruct42_0);
		gstruct42_0.uint_35 = smethod_28(ref gstruct42_0, bool_0: false);
		gstruct42_0.uint_36 = smethod_28(ref gstruct42_0, bool_0: true);
		gstruct42_0.uint_72 = smethod_22(ref gstruct42_0);
		gstruct42_0.uint_73 = smethod_23(ref gstruct42_0);
		gstruct42_0.uint_53 = smethod_18(ref gstruct42_0);
		gstruct42_0.uint_54 = smethod_20(ref gstruct42_0);
		gstruct42_0.uint_84 = smethod_97(ref gstruct42_0);
		gstruct42_0.uint_62 = smethod_87(ref gstruct42_0);
		gstruct42_0.uint_63 = smethod_88(ref gstruct42_0);
		gstruct42_0.uint_64 = smethod_89(ref gstruct42_0);
		gstruct42_0.uint_65 = smethod_90(ref gstruct42_0);
		gstruct42_0.uint_88 = smethod_72(ref gstruct42_0);
		gstruct42_0.uint_89 = smethod_16(ref gstruct42_0);
		gstruct42_0.uint_48 = smethod_78(ref gstruct42_0);
		gstruct42_0.uint_49 = smethod_79(ref gstruct42_0);
		gstruct42_0.uint_50 = smethod_76(ref gstruct42_0);
		gstruct42_0.uint_37 = smethod_77(ref gstruct42_0);
		gstruct42_0.uint_40 = smethod_80(ref gstruct42_0);
		gstruct42_0.uint_42 = smethod_70(ref gstruct42_0);
		gstruct42_0.uint_44 = smethod_68(ref gstruct42_0);
		gstruct42_0.uint_43 = smethod_66(ref gstruct42_0);
		gstruct42_0.uint_85 = smethod_65(ref gstruct42_0);
		gstruct42_0.uint_45 = smethod_81(ref gstruct42_0);
		gstruct42_0.uint_52 = smethod_94(ref gstruct42_0);
		gstruct42_0.uint_58 = smethod_82(ref gstruct42_0);
		gstruct42_0.uint_59 = smethod_85(ref gstruct42_0);
		gstruct42_0.uint_61 = smethod_84(ref gstruct42_0);
		gstruct42_0.uint_60 = smethod_86(ref gstruct42_0);
		gstruct42_0.uint_67 = smethod_91(ref gstruct42_0);
		gstruct42_0.uint_74 = smethod_93(ref gstruct42_0);
		gstruct42_0.uint_71 = smethod_24(ref gstruct42_0);
		gstruct42_0.uint_79 = smethod_74(ref gstruct42_0);
		gstruct42_0.uint_80 = smethod_75(ref gstruct42_0);
		gstruct42_0.uint_81 = smethod_95(ref gstruct42_0);
		gstruct42_0.uint_83 = smethod_96(ref gstruct42_0);
		gstruct42_0.uint_68 = smethod_92(ref gstruct42_0);
		gstruct42_0.uint_69 = smethod_56(ref gstruct42_0, 0);
		gstruct42_0.uint_70 = smethod_56(ref gstruct42_0, 1);
		gstruct42_0.uint_90 = smethod_13(ref gstruct42_0);
	}

	private static uint smethod_9(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = uint_17 - (num + 8);
		string string_ = "33 C0 50E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0);
	}

	public static string smethod_10(uint uint_18)
	{
		string result = "C3";
		if (uint_18 != 0 && uint_17 != 0)
		{
			result = "3EC70424" + Class11.smethod_40(uint_18, 8, bool_1: false, bool_2: true) + "C3";
		}
		return result;
	}

	public static uint smethod_11(ref GStruct42 gstruct42_0, uint uint_18, string string_0, string string_1 = "", uint uint_19 = 0u)
	{
		if (gstruct42_0.uint_11 != 0)
		{
			string text = smethod_10(gstruct42_0.uint_91);
			uint num = (uint)(text.Length / 2 - 1);
			byte[] array = Class11.smethod_10("60" + string_0 + "E8 00 00 00 00" + string_1 + "61" + text);
			int int_ = 204;
			uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12;
			Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array, array.Length, ref int_);
			int num3 = string_1.Replace(" ", "").Length / 2;
			uint num4 = gstruct42_0.uint_6;
			if (uint_19 != 0)
			{
				num4 = uint_19;
			}
			uint num5 = num4 + uint_18;
			uint num6 = (uint)((int)num2 + array.Length - num3 - 2 - (int)num);
			uint num7 = num5 - num6;
			uint num8 = (uint)((int)num2 + array.Length - num3 - 6 - (int)num);
			Class20.smethod_31(num8, gstruct42_0.int_130, num7);
			gstruct42_0.uint_12 += (uint)(array.Length + 4);
			return num2;
		}
		return 0u;
	}

	public static bool smethod_12(int int_0, uint uint_18)
	{
		uint num = 0u;
		uint num2 = Class20.CreateRemoteThread(int_0, IntPtr.Zero, 0u, uint_18, 0u, 0u, out num);
		Class20.WaitForSingleObject((IntPtr)(long)num2, 600u);
		Class20.smethod_32((int)num2);
		return num != 0;
	}

	private static uint smethod_13(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		string string_ = "6A 00 6A 01";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_87.uint_0, string_, "83 C4 08");
	}

	public static bool smethod_14(GStruct42 gstruct42_0, bool bool_0)
	{
		if (gstruct42_0.uint_90 == 0)
		{
			return false;
		}
		int int_ = 0;
		byte[] byte_ = new byte[1]
		{
			Convert.ToByte(bool_0)
		};
		if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_90 + 4, byte_, 1, ref int_))
		{
			return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_90);
		}
		return false;
	}

	private static uint smethod_15(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 84u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_192.uint_0 - (num + 52);
		string string_ = "60B9" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 33 C6 01 018B0D" + Class11.smethod_40(Class47.gstruct43_219.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 1F 33 C0 B0 00BF" + Class11.smethod_40(num - 80, 8, bool_1: false, bool_2: true) + "C7 47 44 01 00 00 00 55 8B EC 50 57 6A 05E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "8B E5 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_192.uint_0 != 0 && Class47.gstruct43_219.uint_0 != 0);
	}

	private static uint smethod_16(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_192.uint_0 - (num + 32);
		string string_ = "60BA C8283F1581C2" + Class11.smethod_40(Class47.gstruct43_200.uint_0, 8, bool_1: false, bool_2: true) + "B8 010000008B0D" + Class11.smethod_40(Class47.gstruct43_219.uint_0, 8, bool_1: false, bool_2: true) + "5052 6A 05E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "61" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_192.uint_0 != 0 && Class47.gstruct43_219.uint_0 != 0);
	}

	public static bool smethod_17(GStruct42 gstruct42_0, uint uint_18, byte byte_0 = 0)
	{
		if (gstruct42_0.uint_89 != 0)
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(uint_18);
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_89 + 2, bytes, bytes.Length, ref int_);
			if (byte_0 != 1)
			{
				byte_0 = 0;
			}
			bytes = new byte[1]
			{
				byte_0
			};
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_89 + 13, bytes, 1, ref int_);
			if (flag && flag2)
			{
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_89);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_18(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_239.uint_0 - (num + 38);
		string string_ = "60B8" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 25 C6 00 018B0D" + Class11.smethod_40(Class47.gstruct43_238.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 11 B8 00 00 00 00 55 89 E5 50E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_239.uint_0 != 0 && Class47.gstruct43_238.uint_0 != 0);
	}

	public static bool smethod_19(GStruct42 gstruct42_0, int int_0)
	{
		if (gstruct42_0.uint_53 != 0 && smethod_7(gstruct42_0))
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(int_0);
			if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_53 + 25, bytes, bytes.Length, ref int_))
			{
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_53);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_20(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 8u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_240.uint_0 - (num + 44);
		string string_ = "60B8" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 2F C6 00 01A1" + Class11.smethod_40(Class47.gstruct43_102.uint_0, 8, bool_1: false, bool_2: true) + "85 C0 74 18 B9 00 00 00 0069C9" + Class11.smethod_40(Class47.gstruct43_103.uint_0, 8, bool_1: false, bool_2: true) + "01 C1 55 89 E5E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DBF" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "C6 07 00 89 47 FC 61" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_240.uint_0 != 0 && Class47.gstruct43_102.uint_0 != 0 && Class47.gstruct43_103.uint_0 != 0);
	}

	public static int smethod_21(GStruct42 gstruct42_0, int int_0)
	{
		if (gstruct42_0.uint_54 == 0)
		{
			return -1;
		}
		int num = 0;
		int int_ = 0;
		byte[] array = new byte[1];
		while (num < 300)
		{
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_54 - 4, array, 1, ref int_);
			if (array[0] == 0)
			{
				break;
			}
			num++;
			Thread.Sleep(1);
		}
		array = BitConverter.GetBytes(int_0);
		if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_54 + 24, array, array.Length, ref int_))
		{
			array = new byte[4];
			if (!Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_54 - 8, array, array.Length, ref int_))
			{
				return -1;
			}
			if (smethod_12(gstruct42_0.int_130, gstruct42_0.uint_54))
			{
				num = 0;
				int num2 = 0;
				while (num < 30)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_54 - 8, array, 4, ref int_);
					num2 = BitConverter.ToInt32(array, 0);
					if (num2 > 0)
					{
						break;
					}
					num++;
					Thread.Sleep(10);
				}
				return num2;
			}
			return -1;
		}
		return -1;
	}

	private static uint smethod_22(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		gstruct42_0.uint_12 += 80u;
		uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num3 = gstruct42_0.uint_6 + Class47.gstruct43_220.uint_0 - (num2 + 46);
		string string_ = "60B8" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 2D C6 00 01 90 90 90 908B0D" + Class11.smethod_40(Class47.gstruct43_219.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 15B8" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "55 89 E5 6A 00 50 6A 70E8" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_220.uint_0 != 0 && Class47.gstruct43_219.uint_0 != 0);
	}

	private static uint smethod_23(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_227.uint_0 - (num + 9);
		string string_ = "60 55 89 E5E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5D61" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_227.uint_0 != 0);
	}

	private static uint smethod_24(ref GStruct42 gstruct42_0)
	{
		string string_ = "B8 " + Class11.smethod_40(gstruct42_0.uint_11 + gstruct42_0.uint_12, 8, bool_1: false, bool_2: true) + "89 45 08 C7 00 10 00 00 00 66 C7 40 04 00 00 66 C7 40 06 A0 08 6A 00 50 6A 188B 0D " + Class11.smethod_40(Class47.gstruct43_219.uint_0, 8, bool_1: false, bool_2: true);
		gstruct42_0.uint_12 += 16u;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_220.uint_0, string_);
	}

	public static bool smethod_25(GStruct42 gstruct42_0, string string_0)
	{
		if (gstruct42_0.uint_72 == 0)
		{
			return false;
		}
		int int_ = 0;
		byte[] array = Class11.smethod_41(string_0);
		if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_72 - 80, array, array.Length, ref int_))
		{
			return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_72);
		}
		return false;
	}

	public static bool smethod_26(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_73 != 0)
		{
			return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_73);
		}
		return false;
	}

	public static bool smethod_27(GStruct42 gstruct42_0, int int_0, int int_1 = 0)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_71 != 0)
		{
			int int_2 = 0;
			int value = int_1 * 16 + 2208;
			byte[] bytes = BitConverter.GetBytes(value);
			byte[] bytes2 = BitConverter.GetBytes(int_0);
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_71 + 19, bytes2, 2, ref int_2);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_71 + 25, bytes, 2, ref int_2);
			if (flag && flag2)
			{
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_71);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_28(ref GStruct42 gstruct42_0, bool bool_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = 0u;
		num = (bool_0 ? Class47.gstruct43_69.uint_0 : Class47.gstruct43_67.uint_0);
		uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num3 = gstruct42_0.uint_6 + num - (num2 + 44);
		string string_ = "60B8" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 2B C6 00 018B0D" + Class11.smethod_40(Class47.gstruct43_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 1781C1" + Class11.smethod_40(Class47.gstruct43_12.uint_0, 8, bool_1: false, bool_2: true) + "BB 53 00 00 00 55 89 E5 53E8" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && num != 0 && Class47.gstruct43_11.uint_0 != 0 && Class47.gstruct43_12.uint_0 != 0);
	}

	public static bool smethod_29(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_35 == 0)
		{
			return false;
		}
		int int_ = 0;
		byte[] array = new byte[1];
		int num = 0;
		while (!Class11.bool_0)
		{
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_35 - 4, array, 1, ref int_);
			if (array[0] == 0)
			{
				break;
			}
			num++;
			if (num <= 350)
			{
				Thread.Sleep(1);
				continue;
			}
			return false;
		}
		array = BitConverter.GetBytes(uint_18);
		if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_35 + 31, array, array.Length, ref int_))
		{
			return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_35);
		}
		return false;
	}

	public static bool smethod_30(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_36 == 0)
		{
			return false;
		}
		int int_ = 0;
		byte[] array = new byte[1];
		int num = 0;
		while (!Class11.bool_0)
		{
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_36 - 4, array, 1, ref int_);
			if (array[0] == 0)
			{
				break;
			}
			num++;
			if (num <= 350)
			{
				Thread.Sleep(1);
				continue;
			}
			return false;
		}
		array = BitConverter.GetBytes(uint_18);
		if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_36 + 31, array, array.Length, ref int_))
		{
			return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_36);
		}
		return false;
	}

	private static uint smethod_31(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_165.uint_0 - (num + 36);
		string string_ = "60B9" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 23 C6 01 018B0D" + Class11.smethod_40(Class47.gstruct43_161.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 0F 55 89 E5 6A 00 6A 00E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_165.uint_0 != 0 && Class47.gstruct43_161.uint_0 != 0);
	}

	private static uint smethod_32(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_101.uint_0 - (num + 51);
		string string_ = "60B8" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 32 C6 00 01A1" + Class11.smethod_40(Class47.gstruct43_102.uint_0, 8, bool_1: false, bool_2: true) + "85 C0 74 1F B9 00 00 00 0069C9" + Class11.smethod_40(Class47.gstruct43_103.uint_0, 8, bool_1: false, bool_2: true) + "01 C88B88" + Class11.smethod_40(Class47.gstruct43_100.uint_0, 8, bool_1: false, bool_2: true) + "55 89 E5 51E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_102.uint_0 != 0 && Class47.gstruct43_103.uint_0 != 0 && Class47.gstruct43_100.uint_0 != 0 && Class47.gstruct43_101.uint_0 != 0);
	}

	public static bool smethod_33(GStruct42 gstruct42_0, int int_0)
	{
		if (gstruct42_0.uint_56 != 0 && smethod_7(gstruct42_0))
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(int_0);
			if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_56 + 24, bytes, bytes.Length, ref int_))
			{
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_56);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_34(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_220.uint_0 - (num + 41);
		string string_ = "60B8" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 28 C6 00 018B0D" + Class11.smethod_40(Class47.gstruct43_219.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 14 55 89 E5 68 00 01 00 00 6A 00 6A 05E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_219.uint_0 != 0 && Class47.gstruct43_220.uint_0 != 0);
	}

	public static bool smethod_35(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_57 != 0 && smethod_7(gstruct42_0))
		{
			int int_ = 0;
			byte[] array = new byte[1];
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_57 - 4, array, 1, ref int_);
			if (array[0] > 0)
			{
				return false;
			}
			array[0] = 0;
			byte[] bytes = BitConverter.GetBytes(uint_18);
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_57 + 33, array, 1, ref int_);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_57 + 28, bytes, 4, ref int_);
			if (flag && flag2)
			{
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_57);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_36(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_57 != 0 && smethod_7(gstruct42_0))
		{
			int int_ = 0;
			byte[] array = new byte[1];
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_57 - 4, array, 1, ref int_);
			if (array[0] <= 0)
			{
				array[0] = 1;
				byte[] bytes = BitConverter.GetBytes(uint_18);
				bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_57 + 33, array, 1, ref int_);
				bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_57 + 28, bytes, 4, ref int_);
				if (flag && flag2)
				{
					return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_57);
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static uint smethod_37(GStruct42 gstruct42_0, int int_0 = 1)
	{
		uint num = Class47.gstruct43_74.uint_0;
		if (int_0 == 1 || int_0 == 3)
		{
			num = Class47.gstruct43_73.uint_0;
		}
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_12.uint_0;
		uint num3 = num2 + Class47.gstruct43_75.uint_0 + num;
		return Class20.smethod_30(num3, gstruct42_0.int_130);
	}

	private static uint smethod_38(ref GStruct42 gstruct42_0)
	{
		string string_ = "B8" + Class11.smethod_40(gstruct42_0.uint_11 + gstruct42_0.uint_12, 8, bool_1: false, bool_2: true) + "80 38 0075 3D8B 0D" + Class11.smethod_40(Class47.gstruct43_219.uint_0, 8, bool_1: false, bool_2: true) + "85 C974 33C6 00 01 83 C0 04 89 45 08C7 00 0B 00 00 00C7 40 04 01 00 00 006A 00 50 6A 18";
		string string_2 = "B8" + Class11.smethod_40(gstruct42_0.uint_11 + gstruct42_0.uint_12, 8, bool_1: false, bool_2: true) + "FE 48 0180 78 01 007F C866 C7 00 00 00";
		gstruct42_0.uint_12 += 256u;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_220.uint_0, string_, string_2);
	}

	public static uint smethod_39(GStruct42 gstruct42_0, int int_0)
	{
		if (gstruct42_0.uint_66 != 0 && smethod_7(gstruct42_0))
		{
			uint result = gstruct42_0.uint_66 - 256;
			int int_ = 0;
			byte[] array = new byte[1];
			Class20.ReadProcessMemory(gstruct42_0.int_130, result, array, 1, ref int_);
			if (array[0] == 0)
			{
				array = BitConverter.GetBytes(int_0);
				if (!Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_66 + 39, array, 4, ref int_))
				{
					return 0u;
				}
				if (!smethod_12(gstruct42_0.int_130, gstruct42_0.uint_66))
				{
					return 0u;
				}
			}
			return result;
		}
		return 0u;
	}

	private static uint smethod_40(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_118.uint_0 - (num + 51);
		string string_ = "60B8" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 32 C6 00 018B0D" + Class11.smethod_40(Class47.gstruct43_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 1E81C1" + Class11.smethod_40(Class47.gstruct43_12.uint_0, 8, bool_1: false, bool_2: true) + "55 89 E5 6A 00 6A 09 6A 05 6A 03 68 01 00 00 00E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_118.uint_0 != 0);
	}

	public static bool smethod_41(GStruct42 gstruct42_0, uint uint_18, int int_0, int int_1, int int_2 = 3)
	{
		if (gstruct42_0.uint_41 != 0)
		{
			int int_3 = 0;
			byte[] bytes = BitConverter.GetBytes(uint_18);
			byte[] byte_ = new byte[1]
			{
				(byte)int_2
			};
			byte[] byte_2 = new byte[1]
			{
				(byte)int_0
			};
			byte[] byte_3 = new byte[1]
			{
				(byte)int_1
			};
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_41 + 36, byte_3, 1, ref int_3);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_41 + 38, byte_2, 1, ref int_3);
			bool flag3 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_41 + 40, byte_, 1, ref int_3);
			bool flag4 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_41 + 42, bytes, 4, ref int_3);
			if (flag && flag2 && flag3 && flag4)
			{
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_41);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_42(GStruct42 gstruct42_0, string string_0, bool bool_0 = false, int int_0 = -1, int int_1 = 1)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_41 != 0 && Class47.gstruct43_118.uint_0 != 0 && Class47.gstruct43_11.uint_0 != 0 && Class47.gstruct43_12.uint_0 != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
			int num3 = 4;
			string[,] array = null;
			if (string_0 != null && string_0 != string.Empty)
			{
				string[] array2 = string_0.Split('|', ',', ';');
				array = new string[array2.Length, 2];
				for (int i = 0; i < array2.Length; i++)
				{
					if (!(array2[i] == string.Empty) && array2[i] != null)
					{
						array[i, 0] = array2[i].Trim();
						array[i, 1] = array2[i].Replace(" ", string.Empty).ToLower();
						if (num3 < array2[i].Length)
						{
							num3 = array2[i].Length;
						}
					}
				}
				num3 += 3;
			}
			int int_2 = 0;
			byte[] array3 = new byte[4];
			byte[] byte_ = new byte[num3];
			int num4 = Class69.smethod_2(gstruct42_0);
			int num5 = 0;
			bool flag = false;
			for (uint num6 = 1u; num6 < Class47.int_1; num6++)
			{
				if (int_1 > 0)
				{
					if (flag)
					{
						num6 = 1u;
						int_1 = 0;
						num5 = 0;
					}
					else
					{
						num6 = (uint)int_1;
						flag = true;
					}
				}
				if (0 < num4 && num4 <= num5)
				{
					break;
				}
				uint num7 = num + num6 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_103.uint_0 - 4, array3, 4, ref int_2);
				if (BitConverter.ToInt32(array3, 0) != 0)
				{
					continue;
				}
				uint num8 = num7 + Class47.gstruct43_104.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num8, array3, 1, ref int_2);
				if (array3[0] == 0)
				{
					continue;
				}
				uint num9 = Class69.smethod_0(gstruct42_0, num6);
				if ((int)num9 <= 0)
				{
					continue;
				}
				num5++;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num2 + num9 * 20 + Class47.gstruct43_97.uint_0 - 8, array3, 4, ref int_2);
				int num10 = BitConverter.ToInt32(array3, 0);
				if (num10 != 3)
				{
					continue;
				}
				if (0 <= int_0)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_105.uint_0, array3, 4, ref int_2);
					int num11 = BitConverter.ToInt32(array3, 0);
					if (num11 != int_0)
					{
						continue;
					}
				}
				if (array != null)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, num8, byte_, num3, ref int_2);
					string text = Class10.smethod_3(byte_).Trim();
					string string_ = text.Replace(" ", string.Empty).ToLower();
					bool flag2 = false;
					for (int j = 0; j < array.GetLength(0); j++)
					{
						if (text == array[j, 0] || (!bool_0 && 0 <= Class11.smethod_2(string_, array[j, 1])))
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						continue;
					}
				}
				int num12 = 0;
				while (true)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_41 - 4, array3, 1, ref int_2);
					if (array3[0] == 0)
					{
						break;
					}
					num12++;
					if (num12 <= 100)
					{
						Thread.Sleep(10);
						continue;
					}
					return false;
				}
				int num13 = (int)Class69.smethod_4(gstruct42_0, num9);
				if (num13 >= 0)
				{
					int num14 = (int)Class69.smethod_5(gstruct42_0, num9);
					if (num14 >= 0)
					{
						return smethod_41(gstruct42_0, num6, num13, num14, num10);
					}
				}
			}
			return false;
		}
		return false;
	}

	private static uint smethod_43(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_99.uint_0 - (num + 50);
		string string_ = "60B9" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 31 C6 01 018B0D" + Class11.smethod_40(Class47.gstruct43_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 1D81C1" + Class11.smethod_40(Class47.gstruct43_12.uint_0, 8, bool_1: false, bool_2: true) + "55 89 E5 6A 00 6A 00 6A 01 6A 02 6A 02 6A 03E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_99.uint_0 != 0);
	}

	public static void smethod_44(GStruct42 gstruct42_0, uint uint_18, uint uint_19, uint uint_20, uint uint_21, uint uint_22, uint uint_23)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_39 != 0 && smethod_7(gstruct42_0))
		{
			int int_ = 0;
			int num = 0;
			byte[] array = new byte[1];
			while (Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_39 - 4, array, 1, ref int_) && array[0] > 0 && num < 150)
			{
				Thread.Sleep(1);
				num++;
			}
			byte[] byte_ = new byte[1]
			{
				(byte)uint_21
			};
			byte[] byte_2 = new byte[1]
			{
				(byte)uint_22
			};
			byte[] byte_3 = new byte[1]
			{
				(byte)uint_23
			};
			byte[] byte_4 = new byte[1]
			{
				(byte)uint_18
			};
			byte[] byte_5 = new byte[1]
			{
				(byte)uint_19
			};
			byte[] byte_6 = new byte[1]
			{
				(byte)uint_20
			};
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_39 + 34, byte_2, 1, ref int_);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_39 + 36, byte_, 1, ref int_);
			bool flag3 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_39 + 38, byte_3, 1, ref int_);
			bool flag4 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_39 + 40, byte_5, 1, ref int_);
			bool flag5 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_39 + 42, byte_4, 1, ref int_);
			bool flag6 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_39 + 44, byte_6, 1, ref int_);
			if (flag && flag2 && flag3 && flag4 && flag5 && flag6)
			{
				smethod_12(gstruct42_0.int_130, gstruct42_0.uint_39);
			}
		}
	}

	private static uint smethod_45(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_139.uint_0 - (num + 44);
		string string_ = "60B8" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 2B C6 00 01 B8 00 00 00 008B0D" + Class11.smethod_40(Class47.gstruct43_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 1281C1" + Class11.smethod_40(Class47.gstruct43_12.uint_0, 8, bool_1: false, bool_2: true) + "55 89 E5 50E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_139.uint_0 != 0);
	}

	public static void smethod_46(GStruct42 gstruct42_0, uint uint_18 = 0u)
	{
		if (gstruct42_0.uint_38 != 0)
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(uint_18);
			if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_38 + 15, bytes, bytes.Length, ref int_))
			{
				smethod_12(gstruct42_0.int_130, gstruct42_0.uint_38);
			}
		}
	}

	private static uint smethod_47(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		gstruct42_0.uint_12 += uint_3;
		uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num3 = gstruct42_0.uint_6 + Class47.gstruct43_213.uint_0 - (num2 + 50);
		string string_ = "60B8" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 31 C6 00 01B8" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "BF" + Class11.smethod_40(num + 32, 8, bool_1: false, bool_2: true) + "8B D7 8A 1A 84 DB 74 03 42 EB F7 2B D7 7E 0E 55 89 E5 52 57 50E8" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_213.uint_0 != 0);
	}

	public static void smethod_48(GStruct42 gstruct42_0, string string_0, string string_1)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_77 != 0 && string_0 != null && !(string_0 == string.Empty) && string_1 != null && !(string_1 == string.Empty))
		{
			if (127 <= string_1.Length)
			{
				string_1 = string_1.Substring(0, 126);
			}
			if (uint_3 <= string_1.Length)
			{
				string_1 = string_1.Substring(0, (int)(uint_3 - 1));
			}
			int int_ = 0;
			byte[] array = Class11.smethod_41(string_1);
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_77 - uint_3 + 32, array, array.Length, ref int_);
			byte[] array2 = Class11.smethod_41(string_0);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_77 - uint_3, array2, array2.Length, ref int_);
			if (flag && flag2)
			{
				smethod_12(gstruct42_0.int_130, gstruct42_0.uint_77);
			}
		}
	}

	private static uint smethod_49(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		gstruct42_0.uint_12 += uint_1;
		uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num3 = gstruct42_0.uint_6 + Class47.gstruct43_214.uint_0 - (num2 + 40);
		string string_ = "60B8" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 27 C6 00 01 B8 00 00 00 00BA" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "B9 01 00 00 00 55 89 E5 51 50 52E8" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_214.uint_0 != 0);
	}

	public static void smethod_50(GStruct42 gstruct42_0, string string_0, int int_0 = 1)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_76 != 0 && string_0 != null)
		{
			if (uint_1 <= string_0.Length - 1)
			{
				string_0 = string_0.Substring(0, (int)(uint_1 - 1));
			}
			int int_ = 0;
			byte[] array = Class11.smethod_41(string_0);
			byte[] bytes = BitConverter.GetBytes(string_0.Length);
			byte[] bytes2 = BitConverter.GetBytes(int_0);
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_76 - uint_1, array, array.Length, ref int_);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_76 + 15, bytes, 4, ref int_);
			bool flag3 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_76 + 25, bytes2, 4, ref int_);
			if (flag && flag2 && flag3)
			{
				smethod_12(gstruct42_0.int_130, gstruct42_0.uint_76);
			}
		}
	}

	private static uint smethod_51(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		gstruct42_0.uint_12 += uint_2;
		uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num3 = gstruct42_0.uint_6 + Class47.gstruct43_212.uint_0 - (num2 + 31);
		string string_ = "60B8" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 1E C6 00 01 55 89 E5 6A 0068" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "6A 01E8" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_212.uint_0 != 0);
	}

	public static void smethod_52(GStruct42 gstruct42_0, string string_0, int int_0)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_75 != 0)
		{
			if (string_0.Length >= 127)
			{
				string_0 = string_0.Substring(0, 126);
			}
			if (string_0.Length >= uint_2)
			{
				string_0 = string_0.Substring(0, (int)(uint_2 - 1));
			}
			int int_ = 0;
			byte[] array = Class11.smethod_41(string_0);
			byte[] byte_ = new byte[1]
			{
				(byte)string_0.Length
			};
			byte[] byte_2 = new byte[1]
			{
				(byte)int_0
			};
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_75 - uint_2, array, array.Length, ref int_);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_75 + 18, byte_, 1, ref int_);
			bool flag3 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_75 + 25, byte_2, 1, ref int_);
			if (flag && flag2 && flag3)
			{
				smethod_12(gstruct42_0.int_130, gstruct42_0.uint_75);
			}
		}
	}

	public static void smethod_53(GStruct42 gstruct42_0, string string_0, object object_0 = null)
	{
		if (object_0 == null)
		{
			object_0 = 1;
		}
		if (!(object_0.GetType() != string.Empty.GetType()))
		{
			smethod_55(gstruct42_0, "Chat('" + object_0.ToString() + "', '" + string_0 + "')");
		}
		else
		{
			smethod_52(gstruct42_0, string_0, (int)object_0);
		}
	}

	private static uint smethod_54(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		gstruct42_0.uint_12 += uint_4;
		uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num3 = gstruct42_0.uint_6 + Class47.gstruct43_216.uint_0 - (num2 + 27);
		string string_ = "60B8" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 1A C6 00 01 55 89 E568" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "E8" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && gstruct42_0.uint_11 != 0 && Class47.gstruct43_216.uint_0 != 0);
	}

	public static void smethod_55(GStruct42 gstruct42_0, string string_0)
	{
		if (gstruct42_0.uint_78 == 0 || string_0 == null)
		{
			return;
		}
		if (string_0.Length > 126)
		{
			string_0 = string_0.Substring(0, 126);
		}
		if (uint_4 <= string_0.Length)
		{
			string_0 = string_0.Substring(0, (int)(uint_4 - 1));
		}
		int int_ = 0;
		int num = 0;
		byte[] array = new byte[1];
		while (!Class11.bool_0)
		{
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_78 - 4, array, 1, ref int_);
			if (array[0] == 0)
			{
				break;
			}
			num++;
			if (num <= 150)
			{
				Thread.Sleep(1);
				continue;
			}
			return;
		}
		array = Class11.smethod_41(string_0);
		if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_78 - uint_4, array, array.Length, ref int_))
		{
			smethod_12(gstruct42_0.int_130, gstruct42_0.uint_78);
		}
	}

	private static uint smethod_56(ref GStruct42 gstruct42_0, int int_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = 1024u;
		uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		string text = null;
		if (int_0 != 0)
		{
			uint num3 = gstruct42_0.uint_6 + Class47.gstruct43_141.uint_0 - (num2 + 43);
			text = "60B9" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 2A C6 01 018B0D" + Class11.smethod_40(Class47.gstruct43_238.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 16BA 00 00 00 00B9" + Class11.smethod_40(gstruct42_0.uint_11 + uint_0 - 2 * num, 8, bool_1: false, bool_2: true) + "55 89 E5 52E8" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		}
		else
		{
			uint num3 = gstruct42_0.uint_6 + Class47.gstruct43_140.uint_0 - (num2 + 43);
			text = "60B9" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 2A C6 01 018B0D" + Class11.smethod_40(Class47.gstruct43_238.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 16BA 00 00 00 00B9" + Class11.smethod_40(gstruct42_0.uint_11 + uint_0 - num, 8, bool_1: false, bool_2: true) + "55 89 E5 52E8" + Class11.smethod_40(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		}
		int int_ = 0;
		byte[] array = Class11.smethod_10(text, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && gstruct42_0.uint_11 != 0);
	}

	public static bool smethod_57(GStruct42 gstruct42_0, int int_0, int int_1)
	{
		uint num = 0u;
		if (int_1 <= 0)
		{
			if (Class47.gstruct43_140.uint_0 == 0)
			{
				return false;
			}
			num = gstruct42_0.uint_69;
		}
		else
		{
			if (Class47.gstruct43_141.uint_0 == 0)
			{
				return false;
			}
			num = gstruct42_0.uint_70;
		}
		if (num != 0)
		{
			if (Class47.long_0 < GClass1.long_1)
			{
				num++;
			}
			int int_2 = 0;
			byte[] bytes = BitConverter.GetBytes(int_0);
			if (!Class20.WriteProcessMemory(gstruct42_0.int_130, num + 25, bytes, 4, ref int_2))
			{
				return false;
			}
			return smethod_12(gstruct42_0.int_130, num);
		}
		return false;
	}

	private static uint smethod_58(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_231.uint_0 - (num + 60);
		string string_ = "60 55BA" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 3A 00 75 39 C6 02 01 BA 00 00 00 00B9" + Class11.smethod_40(gstruct42_0.uint_6 + Class47.gstruct43_229.uint_0, 8, bool_1: false, bool_2: true) + "83 39 00 74 208991" + Class11.smethod_40(Class47.gstruct43_235.uint_0, 8, bool_1: false, bool_2: true) + "C681" + Class11.smethod_40(Class47.gstruct43_230.uint_0, 8, bool_1: false, bool_2: true) + "0189 E5 52 8B D181C2" + Class11.smethod_40(Class47.gstruct43_233.uint_0, 8, bool_1: false, bool_2: true) + "52E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89ECC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "005D61" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0);
	}

	public static void smethod_59(GStruct42 gstruct42_0, bool bool_0 = false, int int_0 = 0)
	{
		if (gstruct42_0.uint_87 != 0)
		{
			uint num = Class47.gstruct43_234.uint_0;
			uint num2 = Class47.gstruct43_232.uint_0;
			if (bool_0)
			{
				num = Class47.gstruct43_235.uint_0;
				num2 = Class47.gstruct43_233.uint_0;
			}
			if (int_0 < 0 || int_0 > 3)
			{
				int_0 = 3;
			}
			Class20.smethod_31(gstruct42_0.uint_87 + 16, gstruct42_0.int_130, (uint)int_0);
			Class20.smethod_31(gstruct42_0.uint_87 + 32, gstruct42_0.int_130, num);
			Class20.smethod_31(gstruct42_0.uint_87 + 50, gstruct42_0.int_130, num2);
			smethod_12(gstruct42_0.int_130, gstruct42_0.uint_87);
		}
	}

	private static uint smethod_60(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_218.uint_0 - (num + 71);
		string string_ = "60B9" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 46 C6 01 018B0D" + Class11.smethod_40(Class47.gstruct43_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 328B89" + Class11.smethod_40(Class47.gstruct43_13.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 28A1" + Class11.smethod_40(Class47.gstruct43_14.uint_0, 8, bool_1: false, bool_2: true) + "85 C0 74 1F69C9" + Class11.smethod_40(Class47.gstruct43_15.uint_0, 8, bool_1: false, bool_2: true) + "01 C1 55 89 E5 6A 00 68 9E A3 01 00 68 4A A7 00 00E8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0);
	}

	public static void smethod_61(GStruct42 gstruct42_0, uint[] uint_18)
	{
		if (gstruct42_0.uint_46 != 0 && uint_18 != null && uint_18[0] != 0 && uint_18[1] != 0 && smethod_7(gstruct42_0))
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(uint_18[0]);
			byte[] bytes2 = BitConverter.GetBytes(uint_18[1]);
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_46 + 57, bytes2, 4, ref int_);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_46 + 62, bytes, 4, ref int_);
			if (Class47.long_0 < GClass1.long_1)
			{
				gstruct42_0.uint_46++;
			}
			if (flag && flag2)
			{
				smethod_12(gstruct42_0.int_130, gstruct42_0.uint_46);
			}
		}
	}

	private static uint smethod_62(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_220.uint_0 - (num + 47);
		string string_ = "60B9" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 2E C6 01 018B0D" + Class11.smethod_40(Class47.gstruct43_238.uint_0, 8, bool_1: false, bool_2: true) + "83 F9 00 74 19 B8 FF FF FF FF BB FF FF FF FF 55 89 E5 53 50 6A 7EE8" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_40(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && gstruct42_0.uint_11 != 0);
	}

	public static bool smethod_63(GStruct42 gstruct42_0, uint[] uint_18)
	{
		if (uint_18 != null && gstruct42_0.uint_82 != 0 && smethod_7(gstruct42_0))
		{
			int num = (int)Math.Round((decimal)uint_18[0] / 32m);
			int num2 = (int)Math.Round((decimal)uint_18[1] / 32m);
			if (num > 0 && num2 > 0)
			{
				int int_ = 0;
				byte[] bytes = BitConverter.GetBytes(num);
				byte[] bytes2 = BitConverter.GetBytes(num2);
				bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_82 + 26, bytes, 4, ref int_);
				bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_82 + 31, bytes2, 4, ref int_);
				if (flag && flag2)
				{
					return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_82);
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static bool smethod_64(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_178.uint_0 != 0 && Class47.gstruct43_264.uint_0 != 0 && gstruct42_0.uint_85 != 0)
		{
			return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_85);
		}
		return false;
	}

	private static uint smethod_65(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		string string_ = "33 C0 50 6A 01 50 6A 56 40A3" + Class11.smethod_40(gstruct42_0.uint_6 + Class47.gstruct43_264.uint_0, 8, bool_1: false, bool_2: true);
		string string_2 = "83 C4 10";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_178.uint_0, string_, string_2);
	}

	private static uint smethod_66(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		gstruct42_0.uint_12 += 48u;
		string string_ = "B9" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "8B 01 85 C0 75 23 40 89 01 83 C1 04 8B C18B 0D" + Class11.smethod_40(Class47.gstruct43_238.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 0A 6A 00 50 6A 65";
		string string_2 = "C6 05" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "00";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_220.uint_0, string_, string_2);
	}

	public static bool smethod_67(GStruct42 gstruct42_0, uint uint_18, uint uint_19, uint uint_20)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_220.uint_0 != 0 && Class47.gstruct43_238.uint_0 != 0 && gstruct42_0.uint_43 != 0)
		{
			uint num = gstruct42_0.uint_43 - 48;
			int int_ = 0;
			byte[] array = new byte[1];
			if (Class20.ReadProcessMemory(gstruct42_0.int_130, num, array, 1, ref int_) && array[0] <= 0)
			{
				array = new byte[8]
				{
					0,
					0,
					0,
					0,
					3,
					0,
					0,
					0
				};
				byte[] bytes = BitConverter.GetBytes(uint_18);
				byte[] bytes2 = BitConverter.GetBytes(uint_19);
				byte[] bytes3 = BitConverter.GetBytes(uint_20);
				if (!Class20.WriteProcessMemory(gstruct42_0.int_130, num + 4, array, 8, ref int_) || !Class20.WriteProcessMemory(gstruct42_0.int_130, num + 4 + 8, bytes, 4, ref int_) || !Class20.WriteProcessMemory(gstruct42_0.int_130, num + 4 + 12, bytes2, 4, ref int_) || !Class20.WriteProcessMemory(gstruct42_0.int_130, num + 4 + 16, bytes3, 4, ref int_))
				{
					return false;
				}
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_43);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_68(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		gstruct42_0.uint_12 += 48u;
		string string_ = "B8" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "80 38 0075 218B 0D" + Class11.smethod_40(Class47.gstruct43_238.uint_0, 8, bool_1: false, bool_2: true) + "85 C974 17C6 00 0183 C0 046A 0050 6A 65";
		string string_2 = "C6 05" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "00";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_220.uint_0, string_, string_2);
	}

	public static bool smethod_69(GStruct42 gstruct42_0, uint uint_18, uint uint_19, uint uint_20)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_220.uint_0 != 0 && Class47.gstruct43_238.uint_0 != 0 && gstruct42_0.uint_44 != 0)
		{
			uint num = gstruct42_0.uint_44 - 48;
			int int_ = 0;
			byte[] array = new byte[1];
			if (Class20.ReadProcessMemory(gstruct42_0.int_130, num, array, 1, ref int_) && array[0] <= 0)
			{
				array = new byte[8]
				{
					1,
					0,
					0,
					0,
					3,
					0,
					0,
					0
				};
				byte[] bytes = BitConverter.GetBytes(uint_18);
				byte[] bytes2 = BitConverter.GetBytes(uint_19);
				byte[] bytes3 = BitConverter.GetBytes(uint_20);
				if (!Class20.WriteProcessMemory(gstruct42_0.int_130, num + 4, array, array.Length, ref int_) || !Class20.WriteProcessMemory(gstruct42_0.int_130, num + 4 + 8, bytes, 4, ref int_) || !Class20.WriteProcessMemory(gstruct42_0.int_130, num + 4 + 8 + 4, bytes2, 4, ref int_) || !Class20.WriteProcessMemory(gstruct42_0.int_130, num + 4 + 8 + 4 + 4, bytes3, 4, ref int_))
				{
					return false;
				}
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_44);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_70(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		string string_ = "B8 00 00 00 00BA 00 00 00 008B 0D" + Class11.smethod_40(Class47.gstruct43_238.uint_0, 8, bool_1: false, bool_2: true) + "85 C974 17C6 05" + Class11.smethod_40(gstruct42_0.uint_11 + gstruct42_0.uint_12, 8, bool_1: false, bool_2: true) + "0150526A 59";
		string string_2 = "C6 05" + Class11.smethod_40(gstruct42_0.uint_11 + gstruct42_0.uint_12, 8, bool_1: false, bool_2: true) + "00";
		gstruct42_0.uint_12 += 4u;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_220.uint_0, string_, string_2);
	}

	public static bool smethod_71(GStruct42 gstruct42_0, uint uint_18, uint uint_19, byte byte_0 = 89)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_220.uint_0 != 0 && Class47.gstruct43_238.uint_0 != 0 && gstruct42_0.uint_42 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[1];
			if (Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_42 - 4, array, 1, ref int_) && array[0] <= 0)
			{
				array[0] = byte_0;
				if (!Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_42 + 31, array, 1, ref int_))
				{
					return false;
				}
				array = BitConverter.GetBytes(uint_19);
				if (!Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_42 + 2, array, 4, ref int_))
				{
					return false;
				}
				array = BitConverter.GetBytes(uint_18);
				if (!Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_42 + 7, array, 4, ref int_))
				{
					return false;
				}
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_42);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_72(ref GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_184.uint_0 != 0)
		{
			uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
			uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12 + 4;
			gstruct42_0.uint_12 += 8u;
			uint num3 = gstruct42_0.uint_11 + gstruct42_0.uint_12;
			string string_ = "60BA" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "C6 42 04 018B0D" + Class11.smethod_40(gstruct42_0.uint_6 + Class47.gstruct43_184.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 19 8B 01 85 C0 74 13 8B 40 1C 85 C0 74 0C 6A 00 6A 04 52 68 15 80 00 00 FF D0C6 05" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(gstruct42_0.uint_91);
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			bool value = Class20.WriteProcessMemory(gstruct42_0.int_130, num3, array, array.Length, ref int_);
			num3 *= Convert.ToByte(value);
			gstruct42_0.uint_12 += (uint)(array.Length + 4);
			return num3;
		}
		return 0u;
	}

	public static bool smethod_73(GStruct42 gstruct42_0, string string_0, uint uint_18 = 32769u, uint uint_19 = 4u, uint uint_20 = 0u)
	{
		if (gstruct42_0.uint_88 != 0 && Class47.gstruct43_187.uint_0 != 0)
		{
			uint num = Class11.smethod_7(string_0);
			if (Class20.smethod_31(gstruct42_0.uint_88 - 8, gstruct42_0.int_130, num))
			{
				Class20.smethod_31(gstruct42_0.uint_88 + 39, gstruct42_0.int_130, uint_18);
				Class20.smethod_31(gstruct42_0.uint_88 + 36, gstruct42_0.int_130, uint_19, 1);
				Class20.smethod_31(gstruct42_0.uint_88 + 34, gstruct42_0.int_130, uint_20, 1);
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_88);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_74(ref GStruct42 gstruct42_0)
	{
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		uint num2 = num + 80;
		gstruct42_0.uint_12 += uint_1;
		string string_ = "B8 03 00 00 00BA 3B 00 00 008B 35" + Class11.smethod_40(Class47.gstruct43_204.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "8D 8E" + Class11.smethod_40(Class47.gstruct43_203.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "6A 00 6A 00 51 5268" + Class11.smethod_40(num2.ToString(), 8, bool_1: false, bool_2: true) + "68" + Class11.smethod_40(num.ToString(), 8, bool_1: false, bool_2: true) + "50 8B CE";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_205.uint_0, string_);
	}

	private static uint smethod_75(ref GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_11 != 0)
		{
			string string_ = "60B8 000000008B0D" + Class11.smethod_40(Class47.gstruct43_204.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "85 C9 74 2B69C0" + Class11.smethod_40(Class47.gstruct43_210.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "05" + Class11.smethod_40(Class47.gstruct43_211.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "03 C8 6A 00 51 68 65 05 00 00 8B 51 60 8B 12 8B 49 60 8B 42 10 85 C0 74 04 FF D0 EB 03 58 58 58 61" + smethod_10(gstruct42_0.uint_91);
			byte[] array = Class11.smethod_10(string_);
			int int_ = 0;
			uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
			byte b = Convert.ToByte(Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_));
			uint num2 = (uint)(b * (array.Length + 4));
			gstruct42_0.uint_12 += num2;
			return num * b;
		}
		return 0u;
	}

	private static uint smethod_76(ref GStruct42 gstruct42_0)
	{
		string str = Class11.smethod_40(Class47.gstruct43_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string str2 = Class11.smethod_40(Class47.gstruct43_162.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "B9 00 00 00 00 6A 01 51 8B 0D " + str + "81 C1 " + str2;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_215.uint_0, string_);
	}

	private static uint smethod_77(ref GStruct42 gstruct42_0)
	{
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		gstruct42_0.uint_12 += 4u;
		string string_ = "BE 00 00 00 00 8B 0D" + Class11.smethod_40(Class47.gstruct43_11.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "81 C1" + Class11.smethod_40(Class47.gstruct43_12.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "B8" + Class11.smethod_40(num.ToString(), 8, bool_1: false, bool_2: true) + "C6 00 00 50 6A 0156";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_160.uint_0, string_, "58 C6 00 01");
	}

	private static uint smethod_78(ref GStruct42 gstruct42_0)
	{
		string str = Class11.smethod_40(Class47.gstruct43_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string str2 = Class11.smethod_40(Class47.gstruct43_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "8B 0D " + str + " 81 C1 " + str2;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_196.uint_0, string_);
	}

	private static uint smethod_79(ref GStruct42 gstruct42_0)
	{
		string str = Class11.smethod_40(Class47.gstruct43_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string str2 = Class11.smethod_40(Class47.gstruct43_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "8B 0D " + str + " 81 C1 " + str2;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_201.uint_0, string_);
	}

	private static uint smethod_80(ref GStruct42 gstruct42_0)
	{
		string str = Class11.smethod_40(Class47.gstruct43_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string str2 = Class11.smethod_40(Class47.gstruct43_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "8B 0D" + str + "81 C1" + str2;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_119.uint_0, string_);
	}

	private static uint smethod_81(ref GStruct42 gstruct42_0)
	{
		string string_ = "6A 00 B9 6D 01 00 00 BA 13 01 00 00 51 52";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_217.uint_0, string_);
	}

	private static uint smethod_82(ref GStruct42 gstruct42_0)
	{
		string string_ = "BA 00 00 00 008B 0D" + Class11.smethod_40(Class47.gstruct43_238.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "85 C9 74 0A 52 6A 05 6A 58";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_220.uint_0, string_);
	}

	private static uint smethod_83(ref GStruct42 gstruct42_0)
	{
		string string_ = "6A 00 6A 00 6A 47";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_220.uint_0, string_);
	}

	private static uint smethod_84(ref GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_11 == 0)
		{
			return 0u;
		}
		uint result = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		string string_ = "6068 00 00 00 0083 EC 108B 0D" + Class11.smethod_40(gstruct42_0.uint_6 + Class47.gstruct43_183.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 8B 44 24 10 C6 04 24 84 C6 44 24 01 04 89 44 24 02 C7 44 24 06 00 00 00 00 74 0E 8B 11 8B52 10 6A 0E 8D 44 24 04 50 FF D2 83 C4 14 61" + smethod_10(gstruct42_0.uint_91);
		gstruct42_0.uint_12 += 8u;
		byte[] array = Class11.smethod_10(string_);
		int int_ = 0;
		Class20.WriteProcessMemory(gstruct42_0.int_130, result, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return result;
	}

	private static uint smethod_85(ref GStruct42 gstruct42_0)
	{
		return smethod_11(ref gstruct42_0, Class47.gstruct43_181.uint_0, "6A 01", "83 C4 04");
	}

	private static uint smethod_86(ref GStruct42 gstruct42_0)
	{
		string string_ = "6A 00 68 A1 00 00 00 68 11 01 00 00 B9 74 93 68 11";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_182.uint_0, string_);
	}

	private static uint smethod_87(ref GStruct42 gstruct42_0)
	{
		string string_ = "6A 01 68 00 00 00 00";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_221.uint_0, string_, "83 C4 08");
	}

	private static uint smethod_88(ref GStruct42 gstruct42_0)
	{
		string str = Class11.smethod_40(Class47.gstruct43_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string str2 = Class11.smethod_40(Class47.gstruct43_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "6A 01A1" + str + "8D 88" + str2;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_222.uint_0, string_);
	}

	private static uint smethod_89(ref GStruct42 gstruct42_0)
	{
		string str = Class11.smethod_40(Class47.gstruct43_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string str2 = Class11.smethod_40(Class47.gstruct43_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "6A 01A1" + str + "8D 88" + str2;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_223.uint_0, string_);
	}

	private static uint smethod_90(ref GStruct42 gstruct42_0)
	{
		string str = Class11.smethod_40(Class47.gstruct43_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string str2 = Class11.smethod_40(Class47.gstruct43_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "B9 00 00 00 00 518B 0D" + str + "81 C1" + str2;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_224.uint_0, string_);
	}

	private static uint smethod_91(ref GStruct42 gstruct42_0)
	{
		string string_ = "BB 00000000B9" + Class11.smethod_40(gstruct42_0.uint_11 + gstruct42_0.uint_12, 8, bool_1: false, bool_2: true) + "C701 01000000 51 6A 00 538B0D" + Class11.smethod_40(Class47.gstruct43_11.uint_0, 8, bool_1: false, bool_2: true) + "85C9 7E 198B89" + Class11.smethod_40(Class47.gstruct43_13.uint_0, 8, bool_1: false, bool_2: true) + "69C9" + Class11.smethod_40(Class47.gstruct43_15.uint_0, 8, bool_1: false, bool_2: true) + "030D" + Class11.smethod_40(Class47.gstruct43_14.uint_0, 8, bool_1: false, bool_2: true);
		string string_2 = "EB 02 59 59 59 C701 00000000";
		gstruct42_0.uint_12 += 4u;
		return smethod_11(ref gstruct42_0, Class47.gstruct43_228.uint_0, string_, string_2);
	}

	private static uint smethod_92(ref GStruct42 gstruct42_0)
	{
		string string_ = "608B 0D" + Class11.smethod_40((gstruct42_0.uint_6 + Class47.gstruct43_148.uint_0).ToString(), 8, bool_1: false, bool_2: true) + "85 C9 74 1D8B 91" + Class11.smethod_40(Class47.gstruct43_150.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "3B 91" + Class11.smethod_40((Class47.gstruct43_150.uint_0 - 4).ToString(), 8, bool_1: false, bool_2: true) + "7C 0F 8B 11 85 D2 74 09 8B 42 24 85 C0 74 02 FF D0 61" + smethod_10(gstruct42_0.uint_91);
		byte[] array = Class11.smethod_10(string_);
		int int_ = 0;
		uint result = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		Class20.WriteProcessMemory(gstruct42_0.int_130, result, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return result;
	}

	private static uint smethod_93(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		string string_ = "60B9" + Class11.smethod_40((gstruct42_0.uint_11 + gstruct42_0.uint_12).ToString(), 8, bool_1: false, bool_2: true) + "C6 01 00 51B9" + Class11.smethod_40((gstruct42_0.uint_6 + Class47.gstruct43_236.uint_0).ToString(), 8, bool_1: false, bool_2: true) + "8B C105" + Class11.smethod_40(Class47.gstruct43_237.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "6A 00 50 68 65 05 00 00 89 48 60 8B 11 85 D2 74 09 8B 42 10 85 C0 74 02 FF D059 C6 01 0161" + smethod_10(gstruct42_0.uint_91);
		gstruct42_0.uint_12 += 4u;
		uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
		int int_ = 0;
		byte[] array = Class11.smethod_10(string_, bool_1: false);
		bool value = Class20.WriteProcessMemory(gstruct42_0.int_130, num, array, array.Length, ref int_);
		gstruct42_0.uint_12 += (uint)(array.Length + 4);
		return num * Convert.ToByte(value);
	}

	private static uint smethod_94(ref GStruct42 gstruct42_0)
	{
		gstruct42_0.uint_12 += 4u;
		string string_ = "B8 12 00 00 00 B9 01 00 00 00 BA 01 00 00 00 6A 00 51 52 50";
		string string_2 = "83 C4 10";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_178.uint_0, string_, string_2);
	}

	private static uint smethod_95(ref GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_170.uint_0 != 0 && Class47.gstruct43_172.uint_0 != 0 && Class47.gstruct43_171.uint_0 != 0)
		{
			uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
			gstruct42_0.uint_12 += 22u;
			uint num2 = gstruct42_0.uint_11 + gstruct42_0.uint_12 - 4;
			string string_ = "A1" + Class11.smethod_40(gstruct42_0.uint_6 + Class47.gstruct43_170.uint_0, 8, bool_1: false, bool_2: true) + "85 C0 74 3A8B 0D" + Class11.smethod_40(gstruct42_0.uint_6 + Class47.gstruct43_171.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 30803D" + Class11.smethod_40(gstruct42_0.uint_6 + Class47.gstruct43_172.uint_0, 8, bool_1: false, bool_2: true) + "0074 27C605" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "016A 00 6A 00 6A 08 6A 03 6A 01 5068" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "51";
			string string_2 = "83 C4 20C605" + Class11.smethod_40(num2, 8, bool_1: false, bool_2: true) + "00";
			return smethod_11(ref gstruct42_0, Class47.gstruct43_172.uint_0, string_, string_2);
		}
		return 0u;
	}

	private static uint smethod_96(ref GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_170.uint_0 != 0 && Class47.gstruct43_172.uint_0 != 0 && Class47.gstruct43_171.uint_0 != 0)
		{
			uint num = gstruct42_0.uint_11 + gstruct42_0.uint_12;
			gstruct42_0.uint_12 += 80u;
			string string_ = "B8" + Class11.smethod_40(gstruct42_0.uint_6 + Class47.gstruct43_173.uint_0, 8, bool_1: false, bool_2: true) + "B9" + Class11.smethod_40(num, 8, bool_1: false, bool_2: true) + "6A 00 6A 01 6A 20 6A 06 6A 01 50 51 51";
			string string_2 = "83 C4 20";
			return smethod_11(ref gstruct42_0, Class47.gstruct43_172.uint_0, string_, string_2);
		}
		return 0u;
	}

	private static uint smethod_97(ref GStruct42 gstruct42_0)
	{
		string string_ = "BA 01 00 00 00 6A 00 52 6A 26";
		return smethod_11(ref gstruct42_0, Class47.gstruct43_192.uint_0, string_);
	}

	public static bool smethod_98(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_192.uint_0 != 0 && gstruct42_0.uint_84 != 0 && smethod_7(gstruct42_0))
		{
			if (!Class20.smethod_31(gstruct42_0.uint_84 + 2, gstruct42_0.int_130, uint_18))
			{
				return false;
			}
			return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_84);
		}
		return false;
	}

	public static bool smethod_99(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_220.uint_0 != 0 && gstruct42_0.uint_58 != 0 && smethod_7(gstruct42_0))
		{
			if (Class20.smethod_31(gstruct42_0.uint_58 + 2, gstruct42_0.int_130, uint_18))
			{
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_58);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_100(GStruct42 gstruct42_0, object object_0 = null)
	{
		if (gstruct42_0.uint_81 != 0 && smethod_7(gstruct42_0))
		{
			int int_ = 0;
			byte[] array = new byte[1];
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_81 - 4, array, 1, ref int_);
			if (array[0] <= 0)
			{
				string string_ = "0/0";
				if (object_0 != null)
				{
					if (Class11.smethod_2(object_0.GetType().ToString(), "[]") > 0)
					{
						uint[] array2 = (uint[])object_0;
						decimal num = Math.Round((decimal)array2[0] / 256m);
						decimal num2 = Math.Round((decimal)array2[1] / 512m);
						string_ = num + "/" + num2;
					}
					else
					{
						string_ = object_0.ToString();
					}
				}
				array = Class11.smethod_41(string_);
				if (!Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_81 - 22, array, array.Length, ref int_))
				{
					return false;
				}
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_81);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_101(GStruct42 gstruct42_0, string string_0)
	{
		if (gstruct42_0.uint_83 != 0 && smethod_7(gstruct42_0))
		{
			int int_ = 0;
			byte[] array = Class11.smethod_41(string_0);
			if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_83 - 80, array, array.Length, ref int_))
			{
				return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_83);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_102(GStruct42 gstruct42_0, uint uint_18, uint uint_19 = 1u, uint uint_20 = 1u)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_178.uint_0 != 0 && gstruct42_0.uint_52 != 0)
		{
			bool flag = Class20.smethod_31(gstruct42_0.uint_52 + 2, gstruct42_0.int_130, uint_18);
			bool flag2 = Class20.smethod_31(gstruct42_0.uint_52 + 7, gstruct42_0.int_130, uint_19);
			bool flag3 = Class20.smethod_31(gstruct42_0.uint_52 + 12, gstruct42_0.int_130, uint_20);
			if (flag && flag2 && flag3)
			{
				smethod_12(gstruct42_0.int_130, gstruct42_0.uint_52);
				return true;
			}
		}
		return false;
	}

	public static bool smethod_103(GStruct42 gstruct42_0, object object_0, string string_0 = "CTC")
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_182.uint_0 != 0 && gstruct42_0.uint_60 != 0 && Class47.gstruct43_93.uint_0 != 0)
		{
			uint num = 640u;
			uint num2 = 297u;
			uint[] array = new uint[4]
			{
				151u,
				181u,
				166u,
				196u
			};
			if (Class11.smethod_2(string_0.ToUpper(), "CTC") < 0)
			{
				num = 508u;
				num2 = 273u;
				array = new uint[4]
				{
					161u,
					193u,
					177u,
					209u
				};
			}
			uint num3 = 0u;
			long long_ = Class11.smethod_22();
			while (true)
			{
				if ((num3 = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_93.uint_0, gstruct42_0.int_130)) == 0)
				{
					if (Class11.smethod_23(long_) > 3000L)
					{
						break;
					}
					smethod_55(gstruct42_0, "Open([[status]])");
					Thread.Sleep(600);
					continue;
				}
				uint num4 = 0u;
				if (Class11.smethod_2(object_0.GetType().ToString().ToUpper(), "STRING") < 0)
				{
					num4 = Class11.smethod_13(object_0.ToString());
					if (num4 > 3)
					{
						num4 = 3u;
					}
				}
				else
				{
					string a = object_0.ToString().ToUpper();
					if (!(a == "THANPHAP") && !(a == "TP"))
					{
						if (!(a == "SINHKHI") && !(a == "SK"))
						{
							if (a == "NOICONG" || a == "NC")
							{
								num4 = 3u;
							}
						}
						else
						{
							num4 = 2u;
						}
					}
					else
					{
						num4 = 1u;
					}
				}
				bool flag = Class20.smethod_31(gstruct42_0.uint_60 + 2, gstruct42_0.int_130, num4, 1);
				bool flag2 = Class20.smethod_31(gstruct42_0.uint_60 + 4, gstruct42_0.int_130, array[num4]);
				bool flag3 = Class20.smethod_31(gstruct42_0.uint_60 + 9, gstruct42_0.int_130, num2);
				bool flag4 = Class20.smethod_31(gstruct42_0.uint_60 + 14, gstruct42_0.int_130, num3 + num);
				if (flag && flag2 && flag3 && flag4)
				{
					bool result;
					if (result = smethod_12(gstruct42_0.int_130, gstruct42_0.uint_60))
					{
						Thread.Sleep(300);
					}
					return result;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static bool smethod_104(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_11 != 0 && gstruct42_0.uint_74 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_13.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
			uint num4 = BitConverter.ToUInt32(array, 0);
			uint num5 = num4 + num3;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_55.uint_0, array, 4, ref int_);
			int num6 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
			int num7 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_);
			int num8 = BitConverter.ToInt32(array, 0);
			int num9 = Class73.smethod_40(gstruct42_0);
			if (num7 != 0 && num8 != 0 && num6 != 0 && num9 > 1)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
				int num10 = BitConverter.ToInt32(array, 0);
				if (!smethod_12(gstruct42_0.int_130, gstruct42_0.uint_74))
				{
					return false;
				}
				int int_2 = 0;
				int i = 0;
				byte[] array2 = new byte[1];
				for (; i < 10; i++)
				{
					Thread.Sleep(100);
					Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_74 - 4, array2, 1, ref int_2);
					if (array2[0] > 0)
					{
						array2[0] = 0;
						Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_74 - 4, array2, 1, ref int_2);
						break;
					}
				}
				i = 0;
				while (!Class11.bool_0 && i < 50)
				{
					Thread.Sleep(300);
					Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
					num = BitConverter.ToUInt32(array, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_13.uint_0, array, 4, ref int_);
					num2 = BitConverter.ToUInt32(array, 0);
					num3 = num2 * Class47.gstruct43_15.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
					num4 = BitConverter.ToUInt32(array, 0);
					num5 = num4 + num3;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_55.uint_0, array, 4, ref int_);
					num6 = BitConverter.ToInt32(array, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
					num7 = BitConverter.ToInt32(array, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
					int num11 = BitConverter.ToInt32(array, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_);
					int num12 = BitConverter.ToInt32(array, 0);
					num9 = Class73.smethod_40(gstruct42_0);
					if (num7 > 0 && num12 > 0 && num6 > 0 && num9 > 1 && (num12 != num8 || num11 != num10))
					{
						break;
					}
					i++;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static void smethod_105(GStruct42 gstruct42_0, int int_0)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_67 != 0 && Class47.gstruct43_11.uint_0 != 0 && Class47.gstruct43_228.uint_0 != 0 && Class47.gstruct43_13.uint_0 != 0 && Class47.gstruct43_15.uint_0 != 0 && Class47.gstruct43_14.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[1];
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_67 - 4, array, 1, ref int_);
			if (array[0] <= 0)
			{
				Class20.smethod_31(gstruct42_0.uint_67 + 2, gstruct42_0.int_130, (uint)int_0);
				smethod_12(gstruct42_0.int_130, gstruct42_0.uint_67);
			}
		}
	}

	public static bool smethod_106(GStruct42 gstruct42_0, bool bool_0 = true)
	{
		if (gstruct42_0.uint_12 != 0 && Class47.gstruct43_181.uint_0 != 0)
		{
			uint num = Convert.ToUInt32(bool_0);
			Class20.smethod_31(gstruct42_0.uint_59 + 2, gstruct42_0.int_130, num, 1);
			return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_59);
		}
		return false;
	}

	public static void smethod_107(GStruct42 gstruct42_0, uint uint_18 = 1u)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_63 != 0)
		{
			if (uint_18 != 1)
			{
				uint_18 = 0u;
			}
			Class20.smethod_31(gstruct42_0.uint_63 + 2, gstruct42_0.int_130, uint_18, 1);
			smethod_12(gstruct42_0.int_130, gstruct42_0.uint_63);
		}
	}

	public static void smethod_108(GStruct42 gstruct42_0, uint uint_18 = 1u)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_64 != 0)
		{
			if (uint_18 != 1)
			{
				uint_18 = 0u;
				uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_12.uint_0;
				uint num2 = num + Class47.gstruct43_75.uint_0;
				uint num3 = (4 + Class47.gstruct43_225.uint_0) * 7;
				Class20.smethod_31(num2 + num3 * 4, gstruct42_0.int_130, 0u);
			}
			Class20.smethod_31(gstruct42_0.uint_64 + 2, gstruct42_0.int_130, uint_18, 1);
			smethod_12(gstruct42_0.int_130, gstruct42_0.uint_64);
		}
	}

	public static uint smethod_109(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_12.uint_0;
		uint num2 = num + Class47.gstruct43_75.uint_0;
		uint num3 = (4 + Class47.gstruct43_225.uint_0) * 7;
		return Class20.smethod_30(num2 + num3 * 4, gstruct42_0.int_130);
	}

	public static void smethod_110(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_65 != 0)
		{
			Class20.smethod_31(gstruct42_0.uint_65 + 2, gstruct42_0.int_130, uint_18);
			smethod_12(gstruct42_0.int_130, gstruct42_0.uint_65);
		}
	}

	public static void smethod_111(GStruct42 gstruct42_0, string[] string_0 = null)
	{
		if (gstruct42_0.uint_12 == 0 || gstruct42_0.uint_62 == 0)
		{
			return;
		}
		string text = Class46.smethod_2(gstruct42_0, bool_0: true);
		string[] array = text.Split(';');
		if (array.Length < 2)
		{
			return;
		}
		if (string_0 != null && string_0.Length > 0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (array[1] == string_0[i] || Class10.smethod_1(array[1], 1) == string_0[i])
				{
					Class46.smethod_0(gstruct42_0);
					return;
				}
			}
		}
		uint num = Class11.smethod_13(array[0]);
		Class20.smethod_31(gstruct42_0.uint_62 + 4, gstruct42_0.int_130, num);
		smethod_12(gstruct42_0.int_130, gstruct42_0.uint_62);
	}

	public static void smethod_112(GStruct42 gstruct42_0, uint uint_18, uint uint_19)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_45 != 0)
		{
			Class20.smethod_31(gstruct42_0.uint_45 + 4, gstruct42_0.int_130, uint_19);
			Class20.smethod_31(gstruct42_0.uint_45 + 9, gstruct42_0.int_130, uint_18);
			smethod_12(gstruct42_0.int_130, gstruct42_0.uint_45);
		}
	}

	public static bool smethod_113(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_183.uint_0 != 0 && gstruct42_0.uint_61 != 0)
		{
			if (!Class20.smethod_31(gstruct42_0.uint_61 + 2, gstruct42_0.int_130, uint_18))
			{
				return false;
			}
			return smethod_12(gstruct42_0.int_130, gstruct42_0.uint_61);
		}
		return false;
	}

	public static void smethod_114(GStruct42 gstruct42_0)
	{
		smethod_102(gstruct42_0, 34u);
	}

	public static void smethod_115(GStruct42 gstruct42_0)
	{
		smethod_102(gstruct42_0, 18u);
	}

	public static void smethod_116(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_55 != 0)
		{
			smethod_12(gstruct42_0.int_130, gstruct42_0.uint_55);
		}
	}

	public static void smethod_117(GStruct42 gstruct42_0, uint uint_18)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_37 != 0)
		{
			Class20.smethod_31(gstruct42_0.uint_37 + 2, gstruct42_0.int_130, uint_18);
			smethod_12(gstruct42_0.int_130, gstruct42_0.uint_37);
			int num = 0;
			int int_ = 0;
			byte[] array = new byte[1];
			while (Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_37 - 4, array, 1, ref int_) && array[0] == 0 && num < 30)
			{
				Thread.Sleep(10);
				num++;
			}
		}
	}

	public static void smethod_118(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_12 != 0 && gstruct42_0.uint_40 != 0)
		{
			smethod_12(gstruct42_0.int_130, gstruct42_0.uint_40);
		}
	}

	public static string smethod_119(GStruct42 gstruct42_0, bool bool_0 = true)
	{
		string text = "";
		string text2 = "";
		uint[] array = Class32.smethod_29(gstruct42_0);
		if (array != null)
		{
			uint num = array[0];
			uint num2 = array[1];
			uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num4 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
			int num5 = 25;
			for (int i = 0; i < 256; i++)
			{
				uint num6 = (uint)((int)num3 + i * (int)Class47.gstruct43_15.uint_0);
				int num7 = (int)Class20.smethod_30(num6 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
				if (num7 > 0)
				{
					int num8 = (int)Class20.smethod_30(num6 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130);
					uint num9 = Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130);
					uint num10 = Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130);
					long num11 = smethod_4(num, num2, num9, num10);
					string text3 = '"' + Class20.smethod_28(num6 + Class47.gstruct43_16.uint_0, gstruct42_0.int_130) + '"';
					while (text3.Length < num5)
					{
						text3 += " ";
					}
					string text4 = text;
					text = text4 + "-- " + i.ToString() + "\t" + num8.ToString() + "   \t" + text3 + " {" + num9.ToString() + "," + num10.ToString() + "}, ( " + (num9 / 256u).ToString() + "," + (num10 / 512u).ToString() + " )\t" + num11.ToString() + "\t" + Math.Round(Math.Sqrt(num11), 0).ToString() + Class47.string_3;
				}
				int num12 = (int)Class20.smethod_30((uint)((int)num4 + i * (int)Class47.gstruct43_124.uint_0), gstruct42_0.int_130);
				if (num12 > 0)
				{
					int num8 = Class68.smethod_6(gstruct42_0, i, num4);
					uint[] array2 = Class68.smethod_3(gstruct42_0, i, num4);
					if (array2 == null)
					{
						uint[] array3 = new uint[2];
						array2 = array3;
					}
					long num11 = smethod_4(num, num2, array2[0], array2[1]);
					string text5 = '"' + Class68.smethod_5(gstruct42_0, i, num4) + '"';
					while (text5.Length < num5)
					{
						text5 += " ";
					}
					string text4 = text2;
					text2 = text4 + "-- " + i.ToString() + "\t" + num8.ToString() + "   \t" + text5 + " {" + array2[0].ToString() + "," + array2[1].ToString() + "}, ( " + (array2[0] / 256u).ToString() + "," + (array2[1] / 512u).ToString() + " )\t" + num11.ToString() + "\t" + Math.Round(Math.Sqrt(num11), 0).ToString() + Class47.string_3;
				}
			}
			int num13 = Class33.smethod_0(gstruct42_0);
			string text6 = "-- MapID = " + num13.ToString() + Class47.string_3 + "-- MapName = \"" + Class33.smethod_2(gstruct42_0) + '"' + Class47.string_3 + "-- PlrName = \"" + Class32.smethod_4(gstruct42_0) + "\"\tPosX,PosY {" + num.ToString() + "," + num2 + "}" + Class47.string_3 + "=============================================================================================" + Class47.string_3 + "-- STT\tKind\tNPC name    \t\t  {posx, posy}\t   x/y screen\tLength\tSqrt(Length)" + Class47.string_3 + "[npc]" + Class47.string_3 + "=============================================================================================" + Class47.string_3 + "-- STT\tKind\tObject name  \t\t  {posx, posy}\t   x/y screen\tLength\tSqrt(Length)" + Class47.string_3 + "[object]" + Class47.string_3;
			text6 = text6.Replace("[npc]", text).Replace("[object]", text2) + Class47.string_3 + "=============================================================================================" + Class47.string_3 + "MapId1 = " + num13.ToString() + ", MapName1 = \"" + Class33.smethod_2(gstruct42_0) + "\", tbCong = new uint[,] { { " + num + "," + num2 + ", 0,}},";
			if (bool_0)
			{
				string string_ = "Software\\Microsoft\\Notepad";
				string text7 = Class55.smethod_1(string_, "lfFaceName", 0);
				Class47.smethod_23("object_npc_info.txt", text6, bool_2: true, "Courier", 12, 870, 425, 200, 280);
				if (text7 != "")
				{
					Class55.smethod_10(string_, "lfFaceName", text7, "", 1);
				}
			}
			return text6;
		}
		return "";
	}

	public static string smethod_120(GStruct42 gstruct42_0, int int_0 = 0)
	{
		uint[] array = Class32.smethod_29(gstruct42_0);
		if (array != null)
		{
			int num = Class32.smethod_16(gstruct42_0);
			uint uint_ = array[0];
			uint uint_2 = array[1];
			uint num2 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
			int num4 = -1;
			long num5 = 0L;
			long num6 = 0L;
			uint[] array2 = null;
			string text = "";
			int num7 = -1;
			long num8 = 0L;
			long num9 = 0L;
			uint[] array3 = null;
			string text2 = "";
			for (int i = 0; i < 256; i++)
			{
				uint num10 = (uint)((int)num2 + i * (int)Class47.gstruct43_15.uint_0);
				int num11 = (int)Class20.smethod_30(num10 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
				if (i != num && num11 > 0)
				{
					uint[] array4 = new uint[2]
					{
						Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
						Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
					};
					num6 = smethod_4(uint_, uint_2, array4[0], array4[1]);
					if (num4 < 0 || num6 < num5)
					{
						num4 = i;
						num5 = num6;
						array2 = array4;
						text = Class20.smethod_28(num10 + Class47.gstruct43_16.uint_0, gstruct42_0.int_130);
					}
				}
				int num12 = (int)Class20.smethod_30((uint)((int)num3 + i * (int)Class47.gstruct43_124.uint_0), gstruct42_0.int_130);
				if (num12 > 0)
				{
					uint[] array5 = Class68.smethod_3(gstruct42_0, i, num3);
					if (array5 == null)
					{
						uint[] array6 = new uint[2];
						array5 = array6;
					}
					num9 = smethod_4(uint_, uint_2, array5[0], array5[1]);
					if (num7 < 0 || num9 < num8)
					{
						num7 = i;
						num8 = num9;
						array3 = array5;
						text2 = Class68.smethod_5(gstruct42_0, i, num3);
					}
				}
			}
			if (num7 > 0 && (num4 < 0 || num8 < num5))
			{
				num4 = num7;
				num5 = num8;
				array2 = array3;
				text = text2;
			}
			string result = "";
			switch (int_0)
			{
			case 1:
				result = text;
				break;
			case 2:
				result = "{ X = " + array2[0].ToString() + ", Y = " + array2[1].ToString() + " }";
				break;
			default:
				if (num4 > 0 && array2 != null)
				{
					result = num4.ToString() + "|" + text + "|X = " + array2[0].ToString() + ", Y = " + array2[1].ToString() + "|" + num5.ToString();
				}
				break;
			}
			return result;
		}
		return "";
	}

	public static string smethod_121(GStruct42 gstruct42_0, int int_0)
	{
		uint[] array = Class32.smethod_29(gstruct42_0);
		if (array != null)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
			uint num2 = (uint)((int)num + int_0 * (int)Class47.gstruct43_15.uint_0);
			int num3 = (int)Class20.smethod_30(num2 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
			int num4 = (int)Class20.smethod_30(num2 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130);
			uint uint_ = Class20.smethod_30(num2 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130);
			uint uint_2 = Class20.smethod_30(num2 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130);
			long num5 = smethod_4(array[0], array[1], uint_, uint_2);
			string text = '"' + Class20.smethod_28(num2 + Class47.gstruct43_16.uint_0, gstruct42_0.int_130) + '"';
			int num6 = Class33.smethod_0(gstruct42_0);
			return "MapID = " + num6.ToString() + Class47.string_3 + Class33.smethod_2(gstruct42_0) + Class47.string_3 + "=============================" + Class47.string_3 + "- Exist\t: " + num3.ToString() + Class47.string_3 + "- Kind\t: " + num4.ToString() + Class47.string_3 + "- Name\t: " + text + Class47.string_3 + "- NOPos\t: {" + array[0].ToString() + "," + array[1] + "}" + Class47.string_3 + "- Length\t: " + num5.ToString() + Class47.string_3 + "- Sqrt(L)\t: " + ((int)Math.Sqrt(num5)).ToString();
		}
		return "";
	}

	public static bool smethod_122(GStruct42 gstruct42_0)
	{
		if (Class47.gstruct43_7.uint_0 != 0)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_7.uint_0, gstruct42_0.int_130);
			if (num == 0)
			{
				return false;
			}
			uint num2 = Class20.smethod_35(gstruct42_0.int_129, "MSVCR80.DLL");
			if (num2 == 0)
			{
				return false;
			}
			uint[] array = Class20.smethod_65(gstruct42_0.int_130, num2);
			if (array != null && num > num2 + array[0] + array[1])
			{
				return false;
			}
			return Class20.smethod_31(num, gstruct42_0.int_130, 2428747827u);
		}
		return false;
	}
}
