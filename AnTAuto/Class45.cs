using System;
using System.Threading;

internal class Class45
{
	public static int int_0 = 0;

	public static void smethod_0()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_41 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_41)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_41 = true;
					flag = true;
				}
				smethod_1(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_1(int int_1)
	{
		int int_2 = 0;
		byte[] array = new byte[1];
		GStruct42 gStruct = default(GStruct42);
		int num = 0;
		long num2 = 0L;
		long long_ = 0L;
		byte[] array2 = new byte[4];
		byte[] byte_ = array2;
		byte[] array3 = null;
		byte[] byte_2 = new byte[4];
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
		int num3 = 0;
		while (true)
		{
			num--;
			Thread.Sleep(300);
			if (num < 0)
			{
				num3 = Class71.smethod_3(FormMain.gstruct42_0, int_1);
				if (Class11.bool_0 || num3 < 0 || !FormMain.gstruct42_0[num3].bool_36)
				{
					break;
				}
				num = 10;
			}
			gStruct = FormMain.gstruct42_0[num3];
			if (gStruct.int_78 <= 0 || !gStruct.bool_65 || gStruct.int_125[0] > 0 || Class60.smethod_3(gStruct, Class60.uint_6) > 0)
			{
				continue;
			}
			uint num4 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
			uint num5 = Class20.smethod_30(num4 + Class47.gstruct43_13.uint_0, gStruct.int_130);
			uint num6 = num5 * Class47.gstruct43_15.uint_0;
			uint num7 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
			uint num8 = num7 + num6;
			int num9 = (int)Class20.smethod_30(num8 + Class47.gstruct43_55.uint_0, gStruct.int_130);
			int num10 = (int)Class20.smethod_30(num8 + Class47.gstruct43_50.uint_0, gStruct.int_130);
			int num11 = (int)Class20.smethod_30(num8 + Class47.gstruct43_43.uint_0, gStruct.int_130);
			if (num11 <= 0 || num10 == 0)
			{
				continue;
			}
			switch (num9)
			{
			case 10:
			case 21:
				long_ = 0L;
				num2 = 0L;
				continue;
			case 0:
				continue;
			}
			array3 = null;
			if (gStruct.int_80 > 0)
			{
				if (Class11.smethod_23(long_) < gStruct.int_85)
				{
					continue;
				}
			}
			else
			{
				if (Class11.smethod_23(long_) < gStruct.long_7)
				{
					continue;
				}
				if (gStruct.int_79 > 0 && num9 == 9)
				{
					Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_38.uint_0 + 4, array, 1, ref int_2);
					if (array[0] == 0)
					{
						goto IL_0260;
					}
				}
				if (num2 == 0L)
				{
					for (int i = 0; i < Class47.int_2.Length; i++)
					{
						for (uint num12 = 0u; num12 < 6; num12++)
						{
							uint num13 = Class20.smethod_30(num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0 + Class47.gstruct43_2.uint_0 * num12, gStruct.int_130);
							if (num13 == Class47.int_2[i])
							{
								num2 = Class11.smethod_22();
								break;
							}
						}
					}
					continue;
				}
				if (Class11.smethod_23(num2) <= gStruct.int_83)
				{
					continue;
				}
			}
			goto IL_0260;
			IL_0260:
			int num14 = 0;
			Class60.smethod_2(gStruct, Class60.uint_6, 1, 4);
			byte[] array4 = new byte[4];
			if (array3 == null)
			{
				array3 = new byte[4];
				Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_31.uint_0, array3, 4, ref int_2);
				Class20.ReadProcessMemory(gStruct.int_130, num4 + Class47.gstruct43_12.uint_0 + Class47.gstruct43_68.uint_0, byte_2, 4, ref int_2);
			}
			while (true)
			{
				int j = 0;
				int num15 = -1;
				for (; j < 300; j++)
				{
					Class20.WriteProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_2);
					Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_55.uint_0, array4, 1, ref int_2);
					if (array4[0] < 4 && (num15 == -1 || num15 > 80))
					{
						break;
					}
					num15 = ((array4[0] <= 3) ? (num15 + 1) : 0);
					Thread.Sleep(1);
				}
				Class20.WriteProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_31.uint_0, byte_, 4, ref int_2);
				Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, byte_4, 4, ref int_2);
				Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, byte_5, 4, ref int_2);
				Class20.WriteProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_37.uint_0, byte_4, 4, ref int_2);
				Class20.WriteProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_38.uint_0, byte_5, 4, ref int_2);
				Class20.WriteProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_36.uint_0, bytes, bytes.Length, ref int_2);
				Class20.WriteProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_35.uint_0, byte_3, 4, ref int_2);
				for (j = 0; j < 60; j++)
				{
					for (uint num12 = 0u; num12 < 6; num12++)
					{
						Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0 + Class47.gstruct43_2.uint_0 * num12, array4, 4, ref int_2);
						if (BitConverter.ToInt32(array4, 0) == 122)
						{
							goto end_IL_04d5;
						}
					}
					Thread.Sleep(10);
				}
				if (num14 > 0)
				{
					break;
				}
				num14++;
				continue;
				end_IL_04d5:
				break;
			}
			if (array3 != null)
			{
				Class20.WriteProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_31.uint_0, array3, 4, ref int_2);
				Class20.WriteProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_157.uint_0 - 8, byte_2, 4, ref int_2);
				Class20.WriteProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_35.uint_0, byte_, 4, ref int_2);
				array3 = null;
			}
			Class60.smethod_2(gStruct, Class60.uint_6, 0, 4);
			num2 = 0L;
			long_ = Class11.smethod_22();
		}
	}
}
