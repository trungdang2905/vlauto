using System;
using System.Threading;

internal class Class12
{
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

	public static int smethod_1(GStruct42 gstruct42_0, uint[] uint_0)
	{
		if (uint_0 != null && gstruct42_0.uint_82 != 0 && uint_0[0] != 0 && uint_0[1] != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
			uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num4 = num3 + num2;
			int num5 = (int)Class20.smethod_30(num4 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			int num6 = (int)Class20.smethod_30(num4 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
			int num7 = Class73.smethod_40(gstruct42_0);
			int num8 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
			if (num6 != 0 && num5 != 0 && num5 != 10 && num5 != 21 && num8 != 0 && num7 > 1)
			{
				if (Class60.smethod_63(gstruct42_0, uint_0))
				{
					int num9 = 0;
					int int_ = 0;
					int num10 = 0;
					byte[] array = new byte[1];
					while (!Class11.bool_0 && num9 < 60)
					{
						if (num10 == 0)
						{
							if (smethod_4(gstruct42_0))
							{
								num10 = 1;
							}
						}
						else
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_82 - 4, array, 1, ref int_);
							if (array[0] <= 0 && Class20.smethod_30(num4 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130) == 3)
							{
								return 1;
							}
						}
						num9++;
						Thread.Sleep(10);
					}
					return -1;
				}
				return -1;
			}
			return 0;
		}
		return 0;
	}

	public static long smethod_2(GStruct42 gstruct42_0, uint[] uint_0, long long_0 = 300000L)
	{
		if (uint_0 != null && uint_0[0] != 0 && uint_0[1] != 0)
		{
			int int_ = gstruct42_0.int_129;
			long result = 0L;
			bool flag = false;
			long long_ = 0L;
			uint num = 0u;
			uint num2 = 0u;
			uint[] array = null;
			bool flag2 = Class32.smethod_17(gstruct42_0);
			long long_2 = 0L;
			long num3 = Class11.smethod_22();
			int num4 = 0;
			int num5 = 0;
			while (true)
			{
				Thread.Sleep(300);
				int num6 = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || num6 < 0 || Class20.smethod_52(FormMain.gstruct42_0[num6].process_0) || !FormMain.gstruct42_0[num6].bool_36)
				{
					break;
				}
				gstruct42_0 = FormMain.gstruct42_0[num6];
				uint num7 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
				uint num8 = Class20.smethod_30(num7 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
				uint num9 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
				num2 = num9 + num8;
				int num10 = (int)Class20.smethod_30(num2 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
				int num11 = (int)Class20.smethod_30(num2 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
				uint num12 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
				Class20.smethod_31(num2 + Class47.gstruct43_72.uint_0, gstruct42_0.int_130, 0u);
				if (gstruct42_0.long_8 > num3)
				{
					break;
				}
				if (num11 != 0 && num12 != 0)
				{
					if (num10 == 0 || num10 == 10 || num10 == 21)
					{
						result = -2L;
						break;
					}
					if (num == 0)
					{
						num = num12;
					}
					uint[] array2 = new uint[2]
					{
						Class20.smethod_30(num2 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
						Class20.smethod_30(num2 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
					};
					if (array == null)
					{
						array = new uint[2]
						{
							array2[0],
							array2[1]
						};
						long_ = Class11.smethod_22();
					}
					uint num13 = smethod_0(array2, uint_0);
					if (num13 < long_0 || num12 != num)
					{
						result = num13;
						break;
					}
					if (Class11.smethod_23(long_) > 8000L)
					{
						uint num14 = smethod_0(array2, array);
						if (num14 < 240000)
						{
							Class20.smethod_31(gstruct42_0.uint_6 + Class47.gstruct43_174.uint_0, gstruct42_0.int_130, 0u);
							int num15 = (int)Class20.smethod_30(num2 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130);
							if (num15 > 0)
							{
								flag = true;
								Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
								Thread.Sleep(600);
							}
							Class60.smethod_55(gstruct42_0, "Switch([[sit]])");
							Thread.Sleep(800);
						}
						array = new uint[2]
						{
							array2[0],
							array2[1]
						};
						long_ = Class11.smethod_22();
						num5++;
						if (num5 > 3)
						{
							result = -3L;
							break;
						}
						continue;
					}
					if (flag2 && Class11.smethod_23(long_2) > 6000L)
					{
						if (Class20.smethod_30(num2 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) == 0)
						{
							Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
							Thread.Sleep(600);
						}
						long_2 = Class11.smethod_22();
					}
					if (!smethod_4(gstruct42_0))
					{
						int num16 = 0;
						while (Class76.Class79.smethod_4(gstruct42_0) && num16 < 30)
						{
							Class20.smethod_4(gstruct42_0.uint_4, 32u);
							Thread.Sleep(100);
							num16++;
						}
						if (!Class60.smethod_100(gstruct42_0, uint_0))
						{
							result = -1L;
							break;
						}
						Thread.Sleep(150);
						Class20.smethod_4(gstruct42_0.uint_4, 13u);
					}
				}
				else
				{
					num4++;
					if (num4 >= 10)
					{
						break;
					}
				}
			}
			smethod_3(gstruct42_0, bool_0: false);
			if (flag && Class20.smethod_30(num2 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) == 0)
			{
				Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
				Thread.Sleep(300);
			}
			return result;
		}
		return 0L;
	}

	public static bool smethod_3(GStruct42 gstruct42_0, bool bool_0)
	{
		return Class20.smethod_31(gstruct42_0.uint_6 + Class47.gstruct43_174.uint_0, gstruct42_0.int_130, Convert.ToUInt32(bool_0));
	}

	public static bool smethod_4(GStruct42 gstruct42_0)
	{
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_174.uint_0;
		int num = (int)Class20.smethod_30(uint_, gstruct42_0.int_130);
		return num > 0;
	}
}
