using System;
using System.Threading;

internal class Class52
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
						FormMain.gstruct42_0[num].bool_42 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_42)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_42 = true;
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
		int num = 0;
		int num2 = 52900;
		GStruct42 gStruct = default(GStruct42);
		int int_2 = 0;
		int num3 = 0;
		int num4 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		int num5 = -1;
		int num6 = 0;
		while (true)
		{
			num3--;
			Thread.Sleep(100);
			if (num3 <= num4)
			{
				num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
				if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36)
				{
					break;
				}
				num3 = 8;
				num4 = 0;
			}
			gStruct = FormMain.gstruct42_0[num];
			if (gStruct.int_38 <= 0 || gStruct.int_26 > 0 || gStruct.int_125[0] > 0)
			{
				Thread.Sleep(300);
				num4 = 5;
				continue;
			}
			uint num7 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
			uint num8 = Class20.smethod_30(num7 + Class47.gstruct43_13.uint_0, gStruct.int_130);
			uint num9 = num8 * Class47.gstruct43_15.uint_0;
			uint num10 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
			uint num11 = num10 + num9;
			int num12 = (int)Class20.smethod_30(num11 + Class47.gstruct43_50.uint_0, gStruct.int_130);
			int num13 = (int)Class20.smethod_30(num11 + Class47.gstruct43_43.uint_0, gStruct.int_130);
			Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
			int num14 = Class73.smethod_40(gStruct);
			int num15 = (int)Class20.smethod_30(num11 + Class47.gstruct43_55.uint_0, gStruct.int_130);
			if (num12 != 0 && num15 != 10 && num15 != 21 && num14 > 1 && (num13 > 0 || gStruct.int_41 > 0))
			{
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_120.uint_0, array, 4, ref int_2);
				if (BitConverter.ToInt32(array, 0) > 0)
				{
					int num16 = Class69.smethod_2(gStruct);
					if (num5 != num16)
					{
						num6 = Class69.smethod_21(gStruct);
						num5 = num16;
					}
					if (num6 <= 0)
					{
						continue;
					}
				}
				else
				{
					num5 = -1;
				}
				uint uint_ = gStruct.uint_6 + Class47.gstruct43_121.uint_0 + Class47.gstruct43_122.uint_0 + 4;
				Class20.ReadProcessMemory(gStruct.int_130, uint_, array, 4, ref int_2);
				int num17 = BitConverter.ToInt32(array, 0);
				if (num17 <= 0)
				{
					continue;
				}
				int num18 = 0;
				int num19 = 0;
				uint num20 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gStruct.int_130);
				for (uint num21 = 1u; num21 < 256; num21++)
				{
					if (num21 % 50u == 0)
					{
						Thread.Sleep(30);
						if (Class11.bool_0)
						{
							break;
						}
					}
					if (num17 <= num18 && num19 > 5)
					{
						break;
					}
					uint num22 = num20 + num21 * Class47.gstruct43_124.uint_0;
					Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_135.uint_0, array2, 1, ref int_2);
					Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_134.uint_0, array, 4, ref int_2);
					if (array2[0] != 0 && BitConverter.ToInt32(array, 0) > 0)
					{
						num19 = 0;
						num18++;
						Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_125.uint_0, array, 1, ref int_2);
						if (array[0] != 4)
						{
							if (gStruct.string_3 != null)
							{
								bool flag = false;
								Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_135.uint_0, array2, array2.Length, ref int_2);
								string string_ = Class10.smethod_3(array2);
								for (int i = 0; i < gStruct.string_3.Length; i++)
								{
									if (Class11.smethod_3(string_, gStruct.string_3[i]))
									{
										flag = true;
										break;
									}
								}
								if (flag)
								{
									continue;
								}
							}
							Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_126.uint_0, array, 4, ref int_2);
							int num23 = BitConverter.ToInt32(array, 0);
							if (num23 != 1 && num23 != 2 && num23 <= 4)
							{
								if (gStruct.int_63 <= 0 || (num23 == 4 && gStruct.int_44 > 0))
								{
									continue;
								}
								Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_127.uint_0, array, 4, ref int_2);
								int num24 = BitConverter.ToInt32(array, 0);
								Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_128.uint_0, array, 4, ref int_2);
								int num25 = BitConverter.ToInt32(array, 0);
								if (gStruct.int_63 != 10 && (gStruct.int_63 != 9 || num23 <= 0) && (gStruct.int_63 != 1 || num24 * num25 > 1) && (gStruct.int_63 != 2 || num24 * num25 > 1 || num23 <= 0) && (gStruct.int_63 != 3 || num24 * num25 > 2) && (gStruct.int_63 != 4 || num24 * num25 > 2 || num23 <= 0) && (gStruct.int_63 != 5 || num24 * num25 > 3) && (gStruct.int_63 != 6 || num24 * num25 > 3 || num23 <= 0) && (gStruct.int_63 != 7 || num24 * num25 > 4) && (gStruct.int_63 != 8 || num24 * num25 > 4 || num23 <= 0))
								{
									continue;
								}
							}
						}
						else
						{
							Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_129.uint_0, array, 4, ref int_2);
							if (BitConverter.ToUInt32(array, 0) <= 1)
							{
								continue;
							}
						}
						if (Class20.smethod_30(num22 + Class47.gstruct43_137.uint_0, gStruct.int_130) != 0)
						{
							Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_130.uint_0, array, 4, ref int_2);
							uint num26 = BitConverter.ToUInt32(array, 0);
							Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_131.uint_0, array, 4, ref int_2);
							uint num27 = BitConverter.ToUInt32(array, 0);
							uint[] uint_2 = new uint[2]
							{
								Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
								Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
							};
							uint[] uint_3 = new uint[2]
							{
								num26,
								num27
							};
							long num28 = Class53.smethod_18(uint_2, uint_3);
							if (num28 > num2)
							{
								continue;
							}
						}
						Class60.smethod_46(gStruct, num21);
						Thread.Sleep(10 + FormLocdo.int_5);
					}
					else
					{
						num19++;
					}
				}
			}
			else
			{
				Thread.Sleep(60);
			}
		}
	}
}
