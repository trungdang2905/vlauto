using System;

internal class Class68
{
	public static int smethod_0(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_6 != 0 && Class47.gstruct43_121.uint_0 != 0 && Class47.gstruct43_122.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_121.uint_0 + Class47.gstruct43_122.uint_0 + 4;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
			return BitConverter.ToInt32(array, 0);
		}
		return -1;
	}

	public static int smethod_1(GStruct42 gstruct42_0, string string_0, bool bool_0 = false, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		int num = 1;
		while (true)
		{
			if (num < 256)
			{
				uint num2 = (uint)((int)uint_0 + num * (int)Class47.gstruct43_124.uint_0);
				string text = Class20.smethod_28(num2 + Class47.gstruct43_135.uint_0, gstruct42_0.int_130);
				if (string_0 == text || (!bool_0 && Class11.smethod_2(text, string_0) >= 0))
				{
					break;
				}
				num++;
				continue;
			}
			return 0;
		}
		return num;
	}

	public static uint smethod_2(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		return Class20.smethod_30(uint_0, gstruct42_0.int_130);
	}

	public static uint[] smethod_3(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		uint[] result = null;
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		uint num = Class20.smethod_30(uint_0 + Class47.gstruct43_130.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(uint_0 + Class47.gstruct43_131.uint_0, gstruct42_0.int_130);
		if (num != 0 && num2 != 0)
		{
			result = new uint[2]
			{
				num,
				num2
			};
		}
		return result;
	}

	public static int[] smethod_4(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		int num = (int)Class20.smethod_30(uint_0 + Class47.gstruct43_127.uint_0, gstruct42_0.int_130);
		int num2 = (int)Class20.smethod_30(uint_0 + Class47.gstruct43_128.uint_0, gstruct42_0.int_130);
		return new int[2]
		{
			num,
			num2
		};
	}

	public static string smethod_5(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u, bool bool_0 = false)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		string text = Class20.smethod_28(uint_0 + Class47.gstruct43_135.uint_0, gstruct42_0.int_130, 32);
		if (bool_0)
		{
			text = Class10.smethod_1(text, 1);
		}
		return text;
	}

	public static int smethod_6(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		return (int)Class20.smethod_30(uint_0 + Class47.gstruct43_125.uint_0, gstruct42_0.int_130);
	}

	public static bool smethod_7(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		uint num = Class20.smethod_30(uint_0 + Class47.gstruct43_138.uint_0, gstruct42_0.int_130);
		return num == 0;
	}

	public static uint smethod_8(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		return Class20.smethod_30(uint_0 + Class47.gstruct43_137.uint_0, gstruct42_0.int_130);
	}

	public static uint smethod_9(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		return Class20.smethod_30(uint_0 + Class47.gstruct43_126.uint_0, gstruct42_0.int_130);
	}

	public static uint smethod_10(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		return Class20.smethod_30(uint_0 + Class47.gstruct43_136.uint_0, gstruct42_0.int_130);
	}

	public static uint smethod_11(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		return Class20.smethod_30(uint_0 + Class47.gstruct43_133.uint_0, gstruct42_0.int_130);
	}

	public static uint smethod_12(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		return Class20.smethod_30(uint_0 + Class47.gstruct43_134.uint_0, gstruct42_0.int_130);
	}

	public static uint smethod_13(GStruct42 gstruct42_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		}
		uint_0 = (uint)((int)uint_0 + int_0 * (int)Class47.gstruct43_124.uint_0);
		return Class20.smethod_30(uint_0 + Class47.gstruct43_129.uint_0, gstruct42_0.int_130);
	}
}
