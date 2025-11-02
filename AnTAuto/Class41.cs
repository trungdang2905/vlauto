using System;

internal class Class41
{
	public static void smethod_0(GStruct42 gstruct42_0, int int_0, int int_1 = -1)
	{
		int num = GClass1.smethod_5(gstruct42_0);
		if (num > 0)
		{
			Class85.bool_0 = true;
		}
		if (num <= 0 || gstruct42_0.uint_6 == 0 || Class47.gstruct43_247.uint_0 == 0 || Class47.gstruct43_248.uint_0 == 0)
		{
			return;
		}
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_247.uint_0;
		uint uint_2 = gstruct42_0.uint_6 + Class47.gstruct43_248.uint_0;
		int int_2 = 0;
		byte[] array = new byte[2];
		switch (int_0)
		{
		case 1:
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 2, ref int_2);
			if (array[0] == 117 && array[1] == 237)
			{
				array = new byte[2]
				{
					144,
					144
				};
				Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_2);
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, 2, ref int_2);
			if (array[0] == 144 && array[1] == 233)
			{
				array = new byte[2]
				{
					15,
					132
				};
				Class20.WriteProcessMemory(gstruct42_0.int_130, uint_2, array, array.Length, ref int_2);
			}
			smethod_1(gstruct42_0, 40);
			break;
		case 2:
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 2, ref int_2);
			if (array[0] == 144 && array[1] == 144)
			{
				array = new byte[2]
				{
					117,
					237
				};
				Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_2);
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, 2, ref int_2);
			if (array[0] == 15 && array[1] == 132)
			{
				array = new byte[2]
				{
					144,
					233
				};
				Class20.WriteProcessMemory(gstruct42_0.int_130, uint_2, array, array.Length, ref int_2);
			}
			smethod_1(gstruct42_0, 60);
			break;
		default:
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 2, ref int_2);
			if (array[0] == 144 && array[1] == 144)
			{
				array = new byte[2]
				{
					117,
					237
				};
				Class20.WriteProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_2);
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, 2, ref int_2);
			if (array[0] == 144 && array[1] == 233)
			{
				array = new byte[2]
				{
					15,
					132
				};
				Class20.WriteProcessMemory(gstruct42_0.int_130, uint_2, array, array.Length, ref int_2);
			}
			smethod_1(gstruct42_0, 20);
			break;
		}
		if (0 <= int_1)
		{
			int_0 = int_1;
		}
		int num2 = Convert.ToByte(int_0 > 0 && int_0 < 3) * int_0;
		Class60.smethod_50(gstruct42_0, "<bclr=blue><color=green>§ang Gi¶m CPU ®en mµn h×nh: Møc " + num2 + " (bÊm F10)");
	}

	public static void smethod_1(GStruct42 gstruct42_0, int int_0)
	{
		uint num = gstruct42_0.uint_6 + Class47.gstruct43_249.uint_0;
		uint num2 = gstruct42_0.uint_6 + Class47.gstruct43_250.uint_0;
		uint num3 = gstruct42_0.uint_6 + Class47.gstruct43_251.uint_0;
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] byte_ = new byte[1]
		{
			(byte)int_0
		};
		Class20.ReadProcessMemory(gstruct42_0.int_130, num, array, 1, ref int_);
		if (array[0] == 106)
		{
			Class20.WriteProcessMemory(gstruct42_0.int_130, num + 1, byte_, 1, ref int_);
		}
		Class20.ReadProcessMemory(gstruct42_0.int_130, num2, array, 1, ref int_);
		if (array[0] == 106)
		{
			Class20.WriteProcessMemory(gstruct42_0.int_130, num2 + 1, byte_, 1, ref int_);
		}
		Class20.ReadProcessMemory(gstruct42_0.int_130, num3, array, 1, ref int_);
		if (array[0] == 106)
		{
			Class20.WriteProcessMemory(gstruct42_0.int_130, num3 + 1, byte_, 1, ref int_);
		}
	}
}
