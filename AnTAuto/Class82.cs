using System;
using System.Threading;

internal class Class82
{
	public struct Struct28
	{
		public int int_0;

		public int int_1;

		public uint uint_0;
	}

	public static bool smethod_0(GStruct42 gstruct42_0, uint uint_0)
	{
		Struct28 @struct = default(Struct28);
		@struct.int_0 = gstruct42_0.int_129;
		@struct.int_1 = Class20.OpenProcess(2035711, bool_0: false, gstruct42_0.int_129);
		@struct.uint_0 = Class20.smethod_1(gstruct42_0.int_130);
		Struct28 struct2 = @struct;
		if (struct2.int_0 > 0 && struct2.int_1 != 0 && struct2.uint_0 != 0)
		{
			uint num = gstruct42_0.uint_6 + Class47.gstruct43_188.uint_0 - (struct2.uint_0 + 49);
			string string_ = "60 B9 " + Class11.smethod_40(struct2.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "51 B8 " + Class11.smethod_40(uint_0.ToString(), 8, bool_1: false, bool_2: true) + "B9" + Class11.smethod_40((gstruct42_0.uint_6 + Class47.gstruct43_187.uint_0).ToString(), 8, bool_1: false, bool_2: true) + "8B 1D" + Class11.smethod_40(Class47.gstruct43_11.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "81 C3" + Class11.smethod_40(Class47.gstruct43_185.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "8B 5B" + Class11.smethod_40(Class47.gstruct43_186.uint_0.ToString(), 2, bool_1: false, bool_2: true) + "6A 00 6A 00 50 53 6A 00E8" + Class11.smethod_40(num.ToString(), 8, bool_1: false, bool_2: true) + "83 C4 04 59 C6 01 0161 C3";
			bool result = false;
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			if (Class20.WriteProcessMemory(gstruct42_0.int_130, struct2.uint_0 + 4, array, array.Length, ref int_))
			{
				byte[] array2 = new byte[1];
				array = array2;
				Class20.WriteProcessMemory(struct2.int_1, struct2.uint_0, array, 1, ref int_);
				smethod_4(struct2.int_1, struct2.uint_0 + 4);
				long long_ = Class11.smethod_22();
				while (Class11.smethod_23(long_) < 10000L)
				{
					Thread.Sleep(150);
					Class20.ReadProcessMemory(struct2.int_1, struct2.uint_0, array, 1, ref int_);
					if (array[0] > 0)
					{
						break;
					}
				}
				Thread.Sleep(300);
				result = true;
			}
			Class20.smethod_2(struct2.int_1, struct2.uint_0);
			Class20.smethod_32(struct2.int_1);
			return result;
		}
		return false;
	}

	private static bool smethod_1(GStruct42 gstruct42_0, uint uint_0)
	{
		return smethod_3(gstruct42_0, uint_0, 0);
	}

	private static bool smethod_2(GStruct42 gstruct42_0, uint uint_0)
	{
		return smethod_3(gstruct42_0, uint_0, 1);
	}

	private static bool smethod_3(GStruct42 gstruct42_0, uint uint_0, int int_0)
	{
		Struct28 @struct = default(Struct28);
		@struct.int_0 = gstruct42_0.int_129;
		@struct.int_1 = Class20.OpenProcess(2035711, bool_0: false, gstruct42_0.int_129);
		@struct.uint_0 = Class20.smethod_1(gstruct42_0.int_130);
		Struct28 struct2 = @struct;
		if (struct2.int_0 > 0 && struct2.int_1 != 0 && struct2.uint_0 != 0)
		{
			uint num = gstruct42_0.uint_6 + Class47.gstruct43_220.uint_0 - (struct2.uint_0 + 38);
			string string_ = "60 8B EC 50 51B9 " + Class11.smethod_40(struct2.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "51 B8 " + Class11.smethod_40(uint_0.ToString(), 8, bool_1: false, bool_2: true) + "50 B8 " + Class11.smethod_40(int_0.ToString(), 8, bool_1: false, bool_2: true) + "50 B8 05 00 00 0050 E8 " + Class11.smethod_40(num.ToString(), 8, bool_1: false, bool_2: true) + "59 C6 01 0159 58 61 C3";
			bool result = false;
			int int_ = 0;
			byte[] array = Class11.smethod_10(string_, bool_1: false);
			if (Class20.WriteProcessMemory(gstruct42_0.int_130, struct2.uint_0 + 4, array, array.Length, ref int_))
			{
				byte[] array2 = new byte[1];
				array = array2;
				Class20.WriteProcessMemory(struct2.int_1, struct2.uint_0, array, 1, ref int_);
				smethod_4(struct2.int_1, struct2.uint_0 + 4);
				long long_ = Class11.smethod_22();
				while (Class11.smethod_23(long_) < 10000L)
				{
					Thread.Sleep(150);
					Class20.ReadProcessMemory(struct2.int_1, struct2.uint_0, array, 1, ref int_);
					if (array[0] > 0)
					{
						break;
					}
				}
				Thread.Sleep(300);
				result = true;
			}
			Class20.smethod_2(struct2.int_1, struct2.uint_0);
			Class20.smethod_32(struct2.int_1);
			return result;
		}
		return false;
	}

	private static void smethod_4(int int_0, uint uint_0)
	{
		uint uint_ = 0u;
		uint num = Class20.CreateRemoteThread(int_0, IntPtr.Zero, 0u, uint_0, 0u, 0u, out uint_);
		Class20.WaitForSingleObject((IntPtr)(long)num, 1000u);
		Class20.smethod_32((int)num);
	}
}
