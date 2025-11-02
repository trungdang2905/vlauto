using System;
using System.Threading;

internal class Class51
{
	public static int int_0 = 180000;

	public static GStruct34[] gstruct34_0 = null;

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static int int_1 = 0;

	public static uint[] smethod_0(GStruct42 gstruct42_0, uint[] uint_0, bool bool_2, bool bool_3)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_121.uint_0 + Class47.gstruct43_122.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
		int num = BitConverter.ToInt32(array, 0);
		if (num <= 0)
		{
			return null;
		}
		byte[] array2 = new byte[60];
		int num2 = 40000;
		uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num5 = num4 * Class47.gstruct43_15.uint_0;
		uint num6 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num7 = num6 + num5;
		uint num8 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		int num9 = gstruct42_0.int_54 * gstruct42_0.int_54;
		uint[] array3 = null;
		GStruct34[] array4 = null;
		int num10 = 0;
		int num11 = 0;
		for (uint num12 = 0u; num12 < 256; num12++)
		{
			uint num13;
			int num14;
			uint num15;
			uint num16;
			int num18;
			if (!Class11.bool_0 && (num > num10 || num11 <= 5))
			{
				num13 = num8 + num12 * Class47.gstruct43_124.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13, array, 4, ref int_);
				num14 = BitConverter.ToInt32(array, 0);
				if (num14 > 0)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_135.uint_0, array2, 1, ref int_);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_134.uint_0, array, 4, ref int_);
					if (array2[0] != 0 && BitConverter.ToInt32(array, 0) > 0)
					{
						num11 = 0;
						num10++;
						Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_130.uint_0, array, 4, ref int_);
						num15 = BitConverter.ToUInt32(array, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_131.uint_0, array, 4, ref int_);
						num16 = BitConverter.ToUInt32(array, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_125.uint_0, array, 4, ref int_);
						int num17 = BitConverter.ToInt32(array, 0);
						num18 = -1;
						if (num17 != 4)
						{
							if (num17 != 3)
							{
								continue;
							}
							array4 = ((!bool_3) ? gstruct42_0.gstruct34_0 : gstruct34_0);
							if (array4 != null)
							{
								try
								{
									bool flag = false;
									for (int i = 0; i < array4.Length; i++)
									{
										if (i > 0 && i % 50 == 0)
										{
											Thread.Sleep(15);
										}
										if (num14 == array4[i].int_0 && Class11.smethod_23(array4[i].long_0) < int_0)
										{
											flag = true;
											break;
										}
									}
									if (!flag)
									{
										goto IL_074b;
									}
								}
								catch
								{
									goto IL_074b;
								}
								continue;
							}
							goto IL_074b;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_129.uint_0, array, 4, ref int_);
						num18 = BitConverter.ToInt32(array, 0);
						goto IL_0520;
					}
					num11++;
					continue;
				}
				num11++;
				continue;
			}
			return null;
			IL_0520:
			if (Class20.smethod_30(num13 + Class47.gstruct43_137.uint_0, gstruct42_0.int_130) == 0)
			{
				Class60.smethod_46(gstruct42_0, num12);
				Thread.Sleep(10 + FormLocdo.int_5);
				continue;
			}
			uint[] uint_2 = new uint[2]
			{
				Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
			uint[] array5 = new uint[2]
			{
				num15,
				num16
			};
			long num19 = Class53.smethod_18(uint_2, array5);
			if (num19 > num2)
			{
				if (gstruct42_0.int_56 <= 0 || num19 > 200000L)
				{
					if (num18 > 1)
					{
						if (uint_0 != null && uint_0[0] != 0)
						{
							num19 = Class53.smethod_18(uint_0, array5);
						}
						if ((array3 == null || num19 < array3[1]) && gstruct42_0.int_53 > 0 && num19 <= num9)
						{
							array3 = new uint[5]
							{
								num12,
								(uint)num19,
								num15,
								num16,
								(uint)num14
							};
						}
					}
					continue;
				}
				for (int j = 0; j < 10; j++)
				{
					uint_2 = new uint[2]
					{
						Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
						Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
					};
					num19 = Class53.smethod_18(uint_2, array5);
					if (num19 <= num2)
					{
						break;
					}
					Class60.smethod_61(gstruct42_0, array5);
					Thread.Sleep(150);
				}
			}
			Class60.smethod_46(gstruct42_0, num12);
			Thread.Sleep(10 + FormLocdo.int_5);
			continue;
			IL_074b:
			if (gstruct42_0.string_3 != null)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_135.uint_0, array2, array2.Length, ref int_);
				string string_ = Class10.smethod_3(array2);
				bool flag = false;
				for (int k = 0; k < gstruct42_0.string_3.Length; k++)
				{
					if (Class11.smethod_3(string_, gstruct42_0.string_3[k]))
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
			Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_126.uint_0, array, 4, ref int_);
			int num20 = BitConverter.ToInt32(array, 0);
			if (num20 != 1 && num20 != 2 && num20 <= 4)
			{
				if (gstruct42_0.int_63 <= 0 || (num20 == 4 && gstruct42_0.int_44 > 0))
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_127.uint_0, array, 4, ref int_);
				int num21 = BitConverter.ToInt32(array, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_128.uint_0, array, 4, ref int_);
				int num22 = BitConverter.ToInt32(array, 0);
				if (gstruct42_0.int_63 != 10 && (gstruct42_0.int_63 != 9 || num20 <= 0) && (gstruct42_0.int_63 != 1 || num21 * num22 > 1) && (gstruct42_0.int_63 != 2 || num21 * num22 > 1 || num20 <= 0) && (gstruct42_0.int_63 != 3 || num21 * num22 > 2) && (gstruct42_0.int_63 != 4 || num21 * num22 > 2 || num20 <= 0) && (gstruct42_0.int_63 != 5 || num21 * num22 > 3) && (gstruct42_0.int_63 != 6 || num21 * num22 > 3 || num20 <= 0) && (gstruct42_0.int_63 != 7 || num21 * num22 > 4) && (gstruct42_0.int_63 != 8 || num21 * num22 > 4 || num20 <= 0))
				{
					continue;
				}
			}
			goto IL_0520;
		}
		return array3;
	}

	public static void smethod_1()
	{
		int int_ = int_1;
		int_1 = 0;
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
						FormMain.gstruct42_0[num].bool_43 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_43)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_43 = true;
					flag = true;
				}
				smethod_2(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_2(int int_2)
	{
		GStruct42 gStruct = default(GStruct42);
		int num = 0;
		int num2 = -1;
		long num3 = 0L;
		long long_ = 0L;
		while (true)
		{
			Thread.Sleep(600);
			int num4 = Class71.smethod_3(FormMain.gstruct42_0, int_2);
			if (Class11.bool_0 || num4 < 0 || !FormMain.gstruct42_0[num4].bool_36)
			{
				break;
			}
			FormMain.gstruct42_0[num4].bool_15 = false;
			gStruct = FormMain.gstruct42_0[num4];
			if (Class11.smethod_23(long_) > 3000L)
			{
				int num5 = 0;
				uint num6 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gStruct.int_130);
				int int_3 = 0;
				int num7 = -1;
				byte[] byte_ = new byte[1];
				byte[] array = new byte[4];
				while (gStruct.gstruct34_0 != null && num5 < 60)
				{
					num7 = -1;
					for (int i = 0; i < gStruct.gstruct34_0.Length; i++)
					{
						if (i > 0 && i % 30 == 0)
						{
							Thread.Sleep(15);
						}
						uint num8 = num6 + gStruct.gstruct34_0[i].uint_0 * Class47.gstruct43_124.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_135.uint_0, byte_, 1, ref int_3);
						Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_134.uint_0, array, 4, ref int_3);
						long num9 = Class11.smethod_23(gStruct.gstruct34_0[i].long_0);
						if ((array[0] == 0 || BitConverter.ToInt32(array, 0) <= 0) && num9 > 3000L)
						{
							gStruct.gstruct34_0[i].long_0 = Class11.smethod_22() - int_0 + 3000L;
							num5++;
						}
						if (Class11.smethod_23(gStruct.gstruct34_0[i].long_0) > int_0)
						{
							num7 = i;
							break;
						}
					}
					if (num7 < 0)
					{
						break;
					}
					smethod_5(ref gStruct.gstruct34_0, gStruct.gstruct34_0[num7].uint_0, gStruct.gstruct34_0[num7].int_0);
					num5++;
				}
				if (num5 > 0)
				{
					if (gStruct.gstruct34_0 != null && gStruct.gstruct34_0.Length != 0)
					{
						FormMain.gstruct42_0[num4].gstruct34_0 = new GStruct34[gStruct.gstruct34_0.Length];
						for (int i = 0; i < gStruct.gstruct34_0.Length; i++)
						{
							FormMain.gstruct42_0[num4].gstruct34_0[i].int_0 = gStruct.gstruct34_0[i].int_0;
							FormMain.gstruct42_0[num4].gstruct34_0[i].long_0 = gStruct.gstruct34_0[i].long_0;
							FormMain.gstruct42_0[num4].gstruct34_0[i].uint_0 = gStruct.gstruct34_0[i].uint_0;
						}
					}
					else
					{
						FormMain.gstruct42_0[num4].gstruct34_0 = null;
					}
				}
				if (!bool_0)
				{
					bool_0 = true;
					while (gstruct34_0 != null && num5 <= 255)
					{
						num7 = -1;
						for (int i = 0; i < gstruct34_0.Length; i++)
						{
							if (i > 0 && i % 30 == 0)
							{
								Thread.Sleep(15);
							}
							uint num8 = num6 + gstruct34_0[i].uint_0 * Class47.gstruct43_124.uint_0;
							Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_135.uint_0, byte_, 1, ref int_3);
							Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_134.uint_0, array, 4, ref int_3);
							long num9 = Class11.smethod_23(gstruct34_0[i].long_0);
							if ((array[0] == 0 || BitConverter.ToInt32(array, 0) <= 0) && num9 > 3000L)
							{
								gstruct34_0[i].long_0 = Class11.smethod_22() - int_0 + 3000L;
							}
							if (Class11.smethod_23(gstruct34_0[i].long_0) > int_0)
							{
								num7 = i;
								break;
							}
						}
						if (0 > num7)
						{
							break;
						}
						num5++;
						smethod_5(ref gstruct34_0, gstruct34_0[num7].uint_0, gstruct34_0[num7].int_0);
					}
					bool_0 = false;
				}
				long_ = Class11.smethod_22();
			}
			uint num10 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
			uint num11 = Class20.smethod_30(num10 + Class47.gstruct43_13.uint_0, gStruct.int_130);
			uint num12 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
			uint num13 = num12 + num11 * Class47.gstruct43_15.uint_0;
			int num14 = (int)Class20.smethod_30(num13 + Class47.gstruct43_43.uint_0, gStruct.int_130);
			if (gStruct.int_38 <= 0 || gStruct.int_26 <= 0 || num14 <= 0 || gStruct.int_63 <= 0 || gStruct.int_42 <= 0)
			{
				continue;
			}
			int num15 = Class69.smethod_2(gStruct);
			if (num15 <= num2 && num == 0)
			{
				num2 = num15;
				continue;
			}
			num++;
			if (num3 == 0L)
			{
				num3 = Class11.smethod_22();
			}
			if (!gStruct.bool_12 && !gStruct.bool_13 && Class11.smethod_23(num3) >= 3000L)
			{
				try
				{
					smethod_3(gStruct);
					num = 0;
					num3 = 0L;
					num2 = Class69.smethod_2(gStruct);
				}
				catch
				{
				}
			}
			else
			{
				num2 = num15;
			}
		}
	}

	public static bool smethod_3(GStruct42 gstruct42_0)
	{
		int num = -1;
		int int_ = 0;
		byte[] array = new byte[80];
		byte[] array2 = new byte[4];
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		bool flag = false;
		int num4 = Class69.smethod_2(gstruct42_0);
		int num5 = 0;
		int int_2 = 0;
		byte[] array3 = new byte[4];
		for (uint num6 = 1u; num6 < Class47.int_1 && (0 >= num4 || num4 > num5); num6++)
		{
			int num7 = 0;
			while ((gstruct42_0.bool_12 || gstruct42_0.bool_13) && num7 < 1000)
			{
				Thread.Sleep(10);
				num7++;
			}
			if (num6 % 10u == 0)
			{
				Thread.Sleep(15);
			}
			uint num8 = num3 + num6 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_103.uint_0 - 4, array3, 4, ref int_2);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			uint uint_ = num8 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array3, 1, ref int_2);
			if (array3[0] == 0)
			{
				continue;
			}
			uint num9 = Class69.smethod_0(gstruct42_0, num6);
			if (num9 == 0)
			{
				continue;
			}
			num5++;
			if (!Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_) || array[0] == 0)
			{
				continue;
			}
			uint num10 = Class20.smethod_30(num2 + num9 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if ((int)num9 <= 0 || (num10 != 3 && num10 != 1))
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_105.uint_0, array2, 4, ref int_);
			int num11 = BitConverter.ToInt32(array2, 0);
			if (num11 > 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_106.uint_0, array2, 4, ref int_);
			int num12 = BitConverter.ToInt32(array2, 0);
			if (num12 == 1 || num12 == 2 || num12 == 4)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_117.uint_0, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_116.uint_0, array2, 4, ref int_);
			int num13 = BitConverter.ToInt32(array2, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_116.uint_0 + 4, array2, 4, ref int_);
			int num14 = BitConverter.ToInt32(array2, 0);
			if (num13 == 0 && num14 > 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_);
			string text = Class10.smethod_3(array).Trim();
			if (text == null || text == string.Empty)
			{
				continue;
			}
			if (gstruct42_0.string_3 != null)
			{
				int num15 = 0;
				while (num15 < gstruct42_0.string_3.Length)
				{
					if (0 > Class11.smethod_2(text, gstruct42_0.string_3[num15]))
					{
						num15++;
						continue;
					}
					goto IL_0719;
				}
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_107.uint_0, array2, 4, ref int_);
			int num16 = BitConverter.ToInt32(array2, 0);
			if (num16 > 9)
			{
				continue;
			}
			if (gstruct42_0.int_45[0] > 0 && num16 == 3)
			{
				if (gstruct42_0.int_45[1] <= 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, (uint)((int)(num8 + Class47.gstruct43_115.uint_0) + (gstruct42_0.int_45[1] - 1) * 16), array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
			}
			else if (gstruct42_0.int_46[0] > 0 && num16 == 4)
			{
				if (gstruct42_0.int_46[1] <= 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, (uint)((int)(num8 + Class47.gstruct43_115.uint_0) + (gstruct42_0.int_46[1] - 1) * 16), array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
			}
			else if (gstruct42_0.int_47[0] > 0 && num16 == 9)
			{
				if (gstruct42_0.int_47[1] <= 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, (uint)((int)(num8 + Class47.gstruct43_115.uint_0) + (gstruct42_0.int_47[1] - 1) * 16), array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
			}
			if (gstruct42_0.int_49[0] > 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_111.uint_0, array2, 4, ref int_);
				if (gstruct42_0.int_49[1] <= BitConverter.ToInt32(array2, 0))
				{
					continue;
				}
			}
			if (gstruct42_0.int_50[0] > 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_112.uint_0, array2, 4, ref int_);
				if (gstruct42_0.int_50[1] == BitConverter.ToInt32(array2, 0))
				{
					continue;
				}
			}
			if (gstruct42_0.int_52 > 0)
			{
				int num17 = 0;
				int num18 = 0;
				bool flag2 = false;
				for (int i = 0; i < gstruct42_0.gstruct33_0.Length; i++)
				{
					if (gstruct42_0.gstruct33_0[i].int_0 <= 0)
					{
						continue;
					}
					num18++;
					flag2 = false;
					for (uint num19 = 0u; num19 < 6; num19++)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_115.uint_0 + num19 * 16, array2, 4, ref int_);
						int num20 = BitConverter.ToInt32(array2, 0);
						if (gstruct42_0.gstruct33_0[i].int_1 == num20)
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_115.uint_0 + num19 * 16 + 4, array2, 4, ref int_);
							int num21 = BitConverter.ToInt32(array2, 0);
							Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_115.uint_0 + num19 * 16 + 12, array2, 4, ref int_);
							int num22 = BitConverter.ToInt32(array2, 0);
							bool flag3 = gstruct42_0.gstruct33_0[i].int_2 <= num21 && num21 > 0;
							bool flag4 = gstruct42_0.gstruct33_0[i].int_2 <= num22 && num22 > 0;
							bool flag5 = gstruct42_0.gstruct33_0[i].int_2 <= 0;
							if (flag3 || flag4 || flag5)
							{
								num17++;
								flag2 = true;
								break;
							}
						}
					}
					if (flag2 || gstruct42_0.int_43 <= 0)
					{
						continue;
					}
					goto IL_0719;
				}
				if (flag2 = (num18 == 0 || (gstruct42_0.int_43 > 0 && num18 <= num17) || (gstruct42_0.int_43 <= 0 && num17 > 0)))
				{
					continue;
				}
			}
			goto IL_0719;
			IL_0719:
			if (!flag)
			{
				num = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
				if (0 <= num)
				{
					FormMain.gstruct42_0[num].bool_15 = true;
				}
				flag = true;
				bool_1 = true;
				Thread.Sleep(300);
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num2 + num9 * 20 + Class47.gstruct43_97.uint_0 - 4, array2, 4, ref int_);
			uint num23 = BitConverter.ToUInt32(array2, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num2 + num9 * 20 + Class47.gstruct43_97.uint_0, array2, 4, ref int_);
			uint num24 = BitConverter.ToUInt32(array2, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_120.uint_0, array2, 4, ref int_);
			int num25 = BitConverter.ToInt32(array2, 0);
			if (num25 > 0)
			{
				Class60.smethod_118(gstruct42_0);
				Thread.Sleep(300);
			}
			int num26 = 0;
			num25 = 0;
			while (num26 < 150)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_120.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) <= 0)
				{
					if (num26 % 40 == 0)
					{
						Class60.smethod_44(gstruct42_0, num23, num24, 3u, num23, num24, 1u);
					}
					num26++;
					Thread.Sleep(10);
					continue;
				}
				num25 = 1;
				break;
			}
			if (num25 <= 0)
			{
				continue;
			}
			uint[] uint_2 = null;
			uint num27 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
			for (uint num28 = 1u; num28 < 256; num28++)
			{
				if (num28 % 10u == 0)
				{
					Thread.Sleep(15);
				}
				uint num29 = num27 + num28 * Class47.gstruct43_124.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num29 + Class47.gstruct43_135.uint_0, array, 1, ref int_);
				if (array[0] != 0)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, num29 + Class47.gstruct43_134.uint_0, array2, 4, ref int_);
					if (BitConverter.ToInt32(array2, 0) > 0)
					{
						Class11.smethod_35(ref uint_2, num28);
					}
				}
			}
			Class60.smethod_118(gstruct42_0);
			Thread.Sleep(300);
			for (uint num28 = 1u; num28 < 256; num28++)
			{
				if (num28 % 10u == 0)
				{
					Thread.Sleep(15);
				}
				uint num29 = num27 + num28 * Class47.gstruct43_124.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num29 + Class47.gstruct43_135.uint_0, array, 1, ref int_);
				byte b = (byte)text[0];
				if (array[0] != b)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num29 + Class47.gstruct43_134.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) <= 0)
				{
					continue;
				}
				if (uint_2 != null)
				{
					bool flag6 = false;
					for (int j = 0; j < uint_2.Length; j++)
					{
						if (uint_2[j] == num28)
						{
							flag6 = true;
							break;
						}
					}
					if (flag6)
					{
						continue;
					}
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num29, array2, 4, ref int_);
				int int_3 = BitConverter.ToInt32(array2, 0);
				smethod_4(ref gstruct42_0.gstruct34_0, num28, int_3);
				smethod_4(ref gstruct34_0, num28, int_3);
			}
		}
		if (!flag)
		{
			return false;
		}
		bool_1 = false;
		num = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
		if (num >= 0)
		{
			if (gstruct42_0.gstruct34_0 != null && gstruct42_0.gstruct34_0.Length != 0)
			{
				FormMain.gstruct42_0[num].gstruct34_0 = new GStruct34[gstruct42_0.gstruct34_0.Length];
				for (int k = 0; k < gstruct42_0.gstruct34_0.Length; k++)
				{
					FormMain.gstruct42_0[num].gstruct34_0[k].uint_0 = gstruct42_0.gstruct34_0[k].uint_0;
					FormMain.gstruct42_0[num].gstruct34_0[k].long_0 = gstruct42_0.gstruct34_0[k].long_0;
					FormMain.gstruct42_0[num].gstruct34_0[k].int_0 = gstruct42_0.gstruct34_0[k].int_0;
				}
			}
			else
			{
				FormMain.gstruct42_0[num].gstruct34_0 = null;
			}
			Thread.Sleep(600);
			FormMain.gstruct42_0[num].bool_15 = false;
			return true;
		}
		return false;
	}

	public static void smethod_4(ref GStruct34[] gstruct34_1, uint uint_0, int int_2, long long_0 = 0L)
	{
		try
		{
			if (long_0 == 0L)
			{
				long_0 = Class11.smethod_22();
			}
			if (gstruct34_1 != null && gstruct34_1.Length != 0)
			{
				int num = gstruct34_1.Length;
				GStruct34[] array = new GStruct34[num + 1];
				int num2 = 0;
				while (true)
				{
					if (num2 >= num)
					{
						array[num] = new GStruct34
						{
							uint_0 = uint_0,
							int_0 = int_2,
							long_0 = long_0
						};
						gstruct34_1 = new GStruct34[num + 1];
						for (num2 = 0; num2 <= num; num2++)
						{
							gstruct34_1[num2].int_0 = array[num2].int_0;
							gstruct34_1[num2].uint_0 = array[num2].uint_0;
							gstruct34_1[num2].long_0 = array[num2].long_0;
						}
						return;
					}
					if (gstruct34_1[num2].uint_0 == uint_0 && gstruct34_1[num2].int_0 == int_2)
					{
						break;
					}
					array[num2].int_0 = gstruct34_1[num2].int_0;
					array[num2].uint_0 = gstruct34_1[num2].uint_0;
					array[num2].long_0 = gstruct34_1[num2].long_0;
					num2++;
				}
				gstruct34_1[num2].long_0 = long_0;
			}
			else
			{
				gstruct34_1 = new GStruct34[1]
				{
					new GStruct34
					{
						uint_0 = uint_0,
						int_0 = int_2,
						long_0 = long_0
					}
				};
			}
		}
		catch
		{
		}
	}

	public static void smethod_5(ref GStruct34[] gstruct34_1, uint uint_0, int int_2)
	{
		try
		{
			if (gstruct34_1 != null && gstruct34_1.GetLength(0) != 0)
			{
				int num = gstruct34_1.Length;
				int num2 = 0;
				GStruct34[] array = new GStruct34[num];
				for (int i = 0; i < num; i++)
				{
					if (gstruct34_1[i].uint_0 != uint_0 || gstruct34_1[i].int_0 != int_2)
					{
						array[num2].uint_0 = gstruct34_1[i].uint_0;
						array[num2].int_0 = gstruct34_1[i].int_0;
						array[num2].long_0 = gstruct34_1[i].long_0;
						num2++;
					}
				}
				if (num2 == 0)
				{
					gstruct34_1 = null;
				}
				else if (num2 < num)
				{
					gstruct34_1 = new GStruct34[num2];
					for (int i = 0; i < num2; i++)
					{
						gstruct34_1[i].uint_0 = array[i].uint_0;
						gstruct34_1[i].int_0 = array[i].int_0;
						gstruct34_1[i].long_0 = array[i].long_0;
					}
				}
			}
			else
			{
				gstruct34_1 = null;
			}
		}
		catch
		{
		}
	}

	public static GStruct27 smethod_6(GStruct42 gstruct42_0)
	{
		GStruct27 result = default(GStruct27);
		if ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) <= 0)
		{
			return result;
		}
		int int_ = 0;
		byte[] array = new byte[80];
		byte[] array2 = new byte[4];
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		byte[] array3 = new byte[4];
		int int_2 = 0;
		int num3 = Class69.smethod_2(gstruct42_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class47.int_1; num5++)
		{
			if (0 < num3 && num3 <= num4)
			{
				break;
			}
			uint num6 = num2 + num5 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array3, 4, ref int_2);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			uint uint_ = num6 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array3, 1, ref int_2);
			if (array3[0] == 0)
			{
				continue;
			}
			uint num7 = Class69.smethod_0(gstruct42_0, num5);
			if ((int)num7 > 0)
			{
				num4++;
				uint num8 = Class20.smethod_30(num + num7 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
				if ((int)num7 > 0 && num8 == 1)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_);
					result.string_0 = Class10.smethod_3(array);
					result.uint_2 = num5;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_108.uint_0, array2, 4, ref int_);
					result.uint_0 = BitConverter.ToUInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_109.uint_0, array2, 4, ref int_);
					result.uint_1 = BitConverter.ToUInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_106.uint_0, array2, 4, ref int_);
					result.int_0 = BitConverter.ToInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_107.uint_0, array2, 4, ref int_);
					result.int_1 = BitConverter.ToInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_105.uint_0, array2, 4, ref int_);
					result.int_2 = BitConverter.ToInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_117.uint_0, array2, 4, ref int_);
					result.int_3 = BitConverter.ToInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num6, array2, 4, ref int_);
					result.uint_3 = BitConverter.ToUInt32(array2, 0);
					break;
				}
			}
		}
		return result;
	}
}
