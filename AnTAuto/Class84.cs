using System;
using System.Threading;

internal class Class84
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
						FormMain.gstruct42_0[num].bool_28 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_28)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_28 = true;
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
		int num2 = 0;
		int int_2 = 0;
		int num3 = 0;
		long long_ = 0L;
		uint num4 = 0u;
		byte[] array = new byte[4];
		byte[] byte_ = new byte[4];
		byte[] byte_2 = new byte[4]
		{
			5,
			0,
			0,
			0
		};
		byte[] bytes = BitConverter.GetBytes(171);
		uint[] array2 = new uint[2];
		GStruct42 gstruct42_ = default(GStruct42);
		while (true)
		{
			num--;
			Thread.Sleep(600);
			if (num < 0)
			{
				num2 = Class71.smethod_3(FormMain.gstruct42_0, int_1);
				if (Class11.bool_0 || num2 < 0 || !FormMain.gstruct42_0[num2].bool_36)
				{
					break;
				}
				num = 5;
				gstruct42_ = FormMain.gstruct42_0[num2];
			}
			if (gstruct42_.int_82 <= 0 || Class38.gstruct29_0.int_0 <= 0 || gstruct42_.int_129 == Class38.gstruct29_0.int_0 || Class11.smethod_23(long_) < 1000L)
			{
				continue;
			}
			if (num3 <= 0)
			{
				num3 = Class67.smethod_15(gstruct42_, 171u);
				long_ = Class11.smethod_22();
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_2);
			uint num5 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_.int_130, num5 + Class47.gstruct43_13.uint_0, array, 4, ref int_2);
			uint num6 = BitConverter.ToUInt32(array, 0);
			uint num7 = num6 * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gstruct42_.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_2);
			uint num8 = BitConverter.ToUInt32(array, 0);
			uint num9 = num8 + num7;
			Class20.ReadProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_54.uint_0, array, 4, ref int_2);
			int num10 = BitConverter.ToInt32(array, 0);
			if (num10 <= 0 || num10 == 4)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_55.uint_0, array, 4, ref int_2);
			int num11 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_50.uint_0, array, 4, ref int_2);
			int num12 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_2);
			int num13 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_43.uint_0, array, 4, ref int_2);
			int num14 = BitConverter.ToInt32(array, 0);
			if (num14 <= 0 || num12 == 0 || num13 != Class38.gstruct29_0.int_4 || num11 == 0 || num11 == 10 || num11 == 21)
			{
				continue;
			}
			uint[] uint_ = new uint[2]
			{
				Class20.smethod_30(num9 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
				Class20.smethod_30(num9 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
			};
			if (Class53.smethod_18(uint_, Class38.gstruct29_0.uint_4) > 400000L)
			{
				continue;
			}
			int num15 = 0;
			uint num16 = 0u;
			if (num4 != 0)
			{
				num16 = num8 + num4 * Class47.gstruct43_15.uint_0;
				Class20.ReadProcessMemory(gstruct42_.int_130, num16, array, 4, ref int_2);
				int num17 = BitConverter.ToInt32(array, 0);
				if (num17 == Class38.gstruct29_0.uint_2)
				{
					goto IL_043d;
				}
			}
			num4 = 0u;
			uint uint_2 = gstruct42_.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
			Class20.ReadProcessMemory(gstruct42_.int_130, uint_2, array, 4, ref int_2);
			int num18 = BitConverter.ToInt32(array, 0);
			if (num18 <= 1)
			{
				continue;
			}
			int num19 = 0;
			uint num20;
			for (num20 = 1u; num20 < 256 && num18 > num19; num20++)
			{
				num16 = num8 + num20 * Class47.gstruct43_15.uint_0;
				uint uint_3 = num16 + Class47.gstruct43_16.uint_0;
				Class20.ReadProcessMemory(gstruct42_.int_130, uint_3, array, 4, ref int_2);
				if (array[0] == 0)
				{
					continue;
				}
				num19++;
				Class20.ReadProcessMemory(gstruct42_.int_130, num16, array, 4, ref int_2);
				int num17 = BitConverter.ToInt32(array, 0);
				if (num17 != Class38.gstruct29_0.uint_2)
				{
					continue;
				}
				goto IL_0439;
			}
			goto IL_073a;
			IL_043d:
			Class20.ReadProcessMemory(gstruct42_.int_130, num16 + Class47.gstruct43_43.uint_0, array, 4, ref int_2);
			if (BitConverter.ToInt32(array, 0) > 0)
			{
				Class20.ReadProcessMemory(gstruct42_.int_130, num16 + Class47.gstruct43_55.uint_0, array, 4, ref int_2);
				int num21 = BitConverter.ToInt32(array, 0);
				if (num21 != 10 && num21 != 21)
				{
					Class20.ReadProcessMemory(gstruct42_.int_130, num16 + Class47.gstruct43_54.uint_0, array, 4, ref int_2);
					int num22 = BitConverter.ToInt32(array, 0);
					if (num22 == num10)
					{
						while (num15 <= 1)
						{
							uint num23 = 0u;
							while (num23 < 6)
							{
								uint num24 = Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0 + Class47.gstruct43_2.uint_0 * num23;
								Class20.ReadProcessMemory(gstruct42_.int_130, num16 + num24, array, 4, ref int_2);
								int num25 = BitConverter.ToInt32(array, 0);
								if (num25 != 17)
								{
									num23++;
									continue;
								}
								goto IL_073a;
							}
							Class60.smethod_2(gstruct42_, Class60.uint_6, 1, 4);
							Class20.WriteProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_2);
							Thread.Sleep(100);
							for (int i = 0; i < 10; i++)
							{
								uint_ = new uint[2]
								{
									Class20.smethod_30(num9 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
									Class20.smethod_30(num9 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
								};
								Class20.ReadProcessMemory(gstruct42_.int_130, num16 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_2);
								array2[0] = BitConverter.ToUInt32(array, 0);
								Class20.ReadProcessMemory(gstruct42_.int_130, num16 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array, 4, ref int_2);
								array2[1] = BitConverter.ToUInt32(array, 0);
								if (Class53.smethod_18(uint_, array2) < 160000L)
								{
									break;
								}
								Class60.smethod_61(gstruct42_, array2);
								Thread.Sleep(180);
							}
							uint value = num4;
							byte[] bytes2 = BitConverter.GetBytes(uint.MaxValue);
							byte[] bytes3 = BitConverter.GetBytes(value);
							Class20.WriteProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_37.uint_0, bytes2, 4, ref int_2);
							Class20.WriteProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_38.uint_0, bytes3, 4, ref int_2);
							Class20.WriteProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_36.uint_0, bytes, 4, ref int_2);
							Class20.WriteProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_35.uint_0, byte_2, 4, ref int_2);
							num15++;
							Thread.Sleep(450);
						}
					}
				}
			}
			goto IL_073a;
			IL_0439:
			num4 = num20;
			goto IL_043d;
			IL_073a:
			if (num15 > 0)
			{
				Class60.smethod_2(gstruct42_, Class60.uint_6, 0, 4);
			}
			long_ = Class11.smethod_22();
		}
	}
}
