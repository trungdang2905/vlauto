using System;

internal class Class15
{
	public static string[] string_0 = new string[3]
	{
		Class11.smethod_16(Class55.smethod_6("KTCTabName0", 0)),
		Class11.smethod_16(Class55.smethod_6("KTCTabName1", 0)),
		Class11.smethod_16(Class55.smethod_6("KTCTabName2", 0))
	};

	public static GStruct1 smethod_0(GStruct42 gstruct42_0, int int_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		uint num = gstruct42_0.uint_6 + Class47.gstruct43_19.uint_0;
		Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_20.uint_0 - 4, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
		uint num3 = BitConverter.ToUInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, num3 + Class47.gstruct43_18.uint_0, array, 4, ref int_);
		uint num4 = BitConverter.ToUInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, num2 + num4 * 4, array, 4, ref int_);
		uint num5 = BitConverter.ToUInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, (uint)((int)num5 + int_0 * 4), array, 4, ref int_);
		uint num6 = BitConverter.ToUInt32(array, 0) * Class47.gstruct43_22.uint_0;
		Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_20.uint_0, array, 4, ref int_);
		uint num7 = BitConverter.ToUInt32(array, 0) + num6;
		Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + 12, array, 4, ref int_);
		int int_2 = BitConverter.ToInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + 36, array, 4, ref int_);
		uint uint_ = BitConverter.ToUInt32(array, 0);
		array = new byte[64];
		Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + 48, array, array.Length, ref int_);
		string text = Class10.smethod_3(array);
		GStruct1 result = default(GStruct1);
		result.string_0 = text;
		result.int_0 = int_0;
		result.int_1 = int_2;
		result.uint_0 = uint_;
		return result;
	}

	public static GStruct1[] smethod_1(GStruct42 gstruct42_0)
	{
		GStruct1[] array = null;
		int num = 0;
		int num2 = 0;
		string a = null;
		for (int i = 0; i < 256; i++)
		{
			GStruct1 gStruct = smethod_0(gstruct42_0, i);
			if (gStruct.string_0 == string.Empty)
			{
				break;
			}
			if (!(a == gStruct.string_0))
			{
				num2 = 0;
			}
			else
			{
				num2++;
				if (num2 > 10)
				{
					break;
				}
			}
			a = gStruct.string_0;
			num++;
			Array.Resize(ref array, num);
			array[num - 1] = gStruct;
		}
		return array;
	}
}
