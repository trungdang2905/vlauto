using System;
using System.Threading;

internal class Class38
{
	public static GStruct29 gstruct29_0;

	public static GStruct29 gstruct29_1;

	public static int int_0 = 0;

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static uint[] uint_0 = null;

	private static int int_1 = 0;

	public static void smethod_0()
	{
		while (true)
		{
			try
			{
				if (Class11.bool_0)
				{
					return;
				}
				smethod_1();
			}
			catch
			{
			}
		}
	}

	public static void smethod_1()
	{
		GStruct42 gstruct42_ = default(GStruct42);
		GStruct29 gStruct = default(GStruct29);
		uint[] array = gStruct.uint_4 = new uint[2];
		gstruct29_0 = gStruct;
		int num = -1;
		int num2 = -1;
		int num3 = 0;
		string[] array2 = new string[2]
		{
			"<color=yellow>Ac chÝnh: XXX bÞ mÊt kÕt nèi.",
			"<color=yellow>Ac chÝnh: XXX ®ang ho¹t ®éng."
		};
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		int num4 = 0;
		int num5 = 0;
		while (!Class11.bool_0)
		{
			Thread.Sleep(200);
			if (Class11.smethod_23(long_3) > 6000L)
			{
				uint_0 = smethod_2();
				long_3 = Class11.smethod_22();
			}
			if (Class11.gstruct41_0 != null && Class11.smethod_23(long_2) > 20000L)
			{
				int num6 = 0;
				int num7 = Class11.gstruct41_0.Length;
				for (int i = 0; i < num7; i++)
				{
					if (Class11.gstruct41_0[i].byte_0 != null && Class11.gstruct41_0[i].byte_0.Length != 0)
					{
						uint num8 = BitConverter.ToUInt32(Class11.gstruct41_0[i].byte_0, 0);
						for (int j = 0; j < Class47.gstruct41_0.Length; j++)
						{
							uint num9 = BitConverter.ToUInt32(Class47.gstruct41_0[j].byte_0, 0);
							if (num8 == num9)
							{
								num6++;
								break;
							}
						}
					}
					else
					{
						num6++;
					}
				}
				int_0 = num7 - num6;
				long_2 = Class11.smethod_22();
			}
			if (FormMain.int_52 == 0)
			{
				if (Class66.gstruct42_0.int_129 > 0)
				{
					gstruct29_0.uint_5 = Class73.smethod_6(Class66.gstruct42_0);
					uint[] array3 = Class32.smethod_29(Class66.gstruct42_0);
					if (array3 != null)
					{
						gstruct29_0.uint_4 = new uint[2]
						{
							array3[0],
							array3[1]
						};
					}
				}
				gstruct29_0.int_0 = 0;
				gstruct29_0.uint_2 = 0u;
				gstruct29_0.uint_3 = 0u;
				gstruct29_0.int_4 = 0;
				gstruct29_0.bool_0 = false;
				num = -1;
				continue;
			}
			if (FormMain.int_6 > 0 || FormMain.int_7 > 0)
			{
				if (FormMain.int_6 <= 0 && FormMain.int_7 > 0)
				{
					FormMayphu.smethod_2(gstruct42_);
				}
				if (gstruct29_1.int_9 > 0)
				{
					smethod_7(gstruct29_1.int_9);
				}
				if (Class11.smethod_23(long_) > 30000L)
				{
					Class73.smethod_32(gstruct42_, 0u);
					long_ = Class11.smethod_22();
				}
				gstruct29_1.int_9 = 0;
			}
			if (num != gstruct42_.int_129)
			{
				num = gstruct42_.int_129;
				smethod_3("<color=yellow>Ac chÝnh: " + gstruct42_.string_20);
				num3 = -100;
			}
			num3--;
			if (num3 <= 0)
			{
				int num10 = Class71.smethod_3(FormMain.gstruct42_0, FormMain.int_52);
				if (num10 < 0 || Class20.smethod_52(FormMain.gstruct42_0[num10].process_0))
				{
					FormMain.int_52 = 0;
					continue;
				}
				gstruct42_ = FormMain.gstruct42_0[num10];
				num3 = 10;
			}
			gstruct29_0.uint_1 = gstruct42_.uint_6;
			uint num11 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
			uint num12 = Class20.smethod_30(num11 + Class47.gstruct43_13.uint_0, gstruct42_.int_130) * Class47.gstruct43_15.uint_0;
			uint num13 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
			uint num14 = num13 + num12;
			gstruct29_0.int_6 = (int)Class20.smethod_30(num14 + Class47.gstruct43_50.uint_0, gstruct42_.int_130);
			int num15 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_.int_130);
			uint num16 = Class20.smethod_30(num14 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130);
			uint num17 = Class20.smethod_30(num14 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130);
			if (num15 > 0 && num16 != 0 && num17 != 0)
			{
				if (gstruct29_0.int_6 <= 0 && num4 <= 60)
				{
					num4++;
					Thread.Sleep(10);
					continue;
				}
				num4 = 0;
				if (num2 != gstruct29_0.int_6)
				{
					if (gstruct29_0.int_6 <= 0)
					{
						gstruct29_0.bool_0 = true;
						num5++;
						if (num5 < 3)
						{
							continue;
						}
					}
					num2 = gstruct29_0.int_6;
					smethod_3(array2[num2].Replace("XXX", gstruct42_.string_20));
				}
				num5 = 0;
				gstruct29_0.int_0 = gstruct42_.int_129;
				gstruct29_0.int_1 = gstruct42_.int_130;
				gstruct29_0.process_0 = gstruct42_.process_0;
				gstruct29_0.uint_0 = gstruct42_.uint_4;
				gstruct29_0.uint_2 = Class20.smethod_30(num14, gstruct42_.int_130);
				if (FormMain.int_6 <= 0 && FormMain.int_7 <= 0)
				{
					gstruct29_0.uint_5 = Class73.smethod_6(gstruct42_);
				}
				else
				{
					gstruct29_0.uint_5 = gstruct29_1.uint_5;
					gstruct29_0.int_7 = gstruct29_1.int_7;
				}
				gstruct29_0.int_3 = (int)Class20.smethod_30(num14 + Class47.gstruct43_43.uint_0, gstruct42_.int_130);
				if ((FormMain.int_6 <= 0 && FormMain.int_7 <= 0) || gstruct29_1.int_4 <= 0)
				{
					gstruct29_0.int_2 = (int)Class20.smethod_30(num14 + Class47.gstruct43_56.uint_0, gstruct42_.int_130);
				}
				else
				{
					gstruct29_0.int_2 = gstruct29_1.int_2;
				}
				gstruct29_0.long_0 = Class11.smethod_22();
				if (gstruct29_0.uint_4 == null)
				{
					gstruct29_0.uint_4 = new uint[2];
				}
				gstruct29_0.uint_4[0] = num16;
				gstruct29_0.uint_4[1] = num17;
				gstruct29_0.int_5 = (int)Class20.smethod_30(num14 + Class47.gstruct43_54.uint_0, gstruct42_.int_130);
				gstruct29_0.string_0 = Class20.smethod_28(num14 + Class47.gstruct43_16.uint_0, gstruct42_.int_130, 32);
				gstruct29_0.int_4 = num15;
				gstruct29_0.bool_0 = (num13 == 0 || gstruct29_0.int_6 == 0 || gstruct29_0.int_4 == 0 || gstruct29_0.string_0 == string.Empty || gstruct29_0.string_1 == string.Empty);
				if (gstruct29_0.int_4 != 162)
				{
					if (gstruct29_0.int_4 == 321)
					{
						gstruct29_0.string_1 = "Tr­êng B¹ch s¬n Nam";
					}
					else
					{
						gstruct29_0.string_1 = Class20.smethod_28(gstruct42_.uint_6 + Class47.gstruct43_28.uint_0 + Class47.gstruct43_29.uint_0, gstruct42_.int_130, 48);
					}
				}
				else
				{
					gstruct29_0.string_1 = "§¹i Lý";
				}
				uint uint_ = 0u;
				if (gstruct29_0.int_3 > 0)
				{
					uint num18 = Class20.smethod_30(num14 + Class47.gstruct43_72.uint_0, gstruct42_.int_130);
					if ((int)num18 > 0)
					{
						uint num19 = num13 + num18 * Class47.gstruct43_15.uint_0;
						if (Class20.smethod_30(num19 + Class47.gstruct43_50.uint_0, gstruct42_.int_130) != 0)
						{
							int num20 = (int)Class20.smethod_30(num19 + Class47.gstruct43_52.uint_0, gstruct42_.int_130);
							if (num20 <= 1)
							{
								uint_ = Class20.smethod_30(num19, gstruct42_.int_130);
							}
						}
					}
					num18 = 0u;
				}
				gstruct29_0.uint_3 = uint_;
			}
			else
			{
				Thread.Sleep(10);
			}
		}
	}

	private static uint[] smethod_2()
	{
		if (FormMain.gstruct42_0 != null && FormMain.gstruct42_0.Length != 0)
		{
			uint[] array = new uint[FormMain.gstruct42_0.Length];
			for (int i = 0; i < array.Length; i++)
			{
				GStruct42 gStruct = FormMain.gstruct42_0[i];
				uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
				uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gStruct.int_130);
				uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
				uint uint_ = num3 + num2 * Class47.gstruct43_15.uint_0;
				array[i] = Class20.smethod_30(uint_, gStruct.int_130);
			}
			return array;
		}
		return null;
	}

	private static void smethod_3(string string_0)
	{
		if (FormMain.gstruct42_0 != null)
		{
			try
			{
				for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
				{
					int num = 0;
					while (FormMain.gstruct42_0[i].bool_4 && num < 30)
					{
						Thread.Sleep(10);
						num++;
					}
					if (!FormMain.gstruct42_0[i].bool_4)
					{
						Class60.smethod_50(FormMain.gstruct42_0[i], string_0);
					}
				}
			}
			catch
			{
			}
		}
	}

	public static int smethod_4(uint uint_1, ref uint[] uint_2, ref uint uint_3)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct29_0.int_1);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct29_0.int_1) * Class47.gstruct43_15.uint_0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct29_0.int_1);
		uint num4 = num3 + num2;
		uint num5 = num3 + uint_3 * Class47.gstruct43_15.uint_0;
		uint num6 = Class20.smethod_30(num5, gstruct29_0.int_1);
		uint num7 = Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct29_0.int_1);
		uint num8 = Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct29_0.int_1);
		if (num7 != 0 && num8 != 0)
		{
			if (gstruct29_0.uint_4 == null)
			{
				gstruct29_0.uint_4 = new uint[2];
			}
			gstruct29_0.uint_4[0] = num7;
			gstruct29_0.uint_4[1] = num8;
			if (num6 != uint_1)
			{
				int int_ = 0;
				byte[] array = new byte[4];
				uint num9 = gstruct29_0.uint_1;
				if (num9 == 0)
				{
					num9 = 4194304u;
				}
				uint uint_4 = num9 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
				Class20.ReadProcessMemory(gstruct29_0.int_1, uint_4, array, 4, ref int_);
				int num10 = BitConverter.ToInt32(array, 0);
				if (num10 <= 1)
				{
					return 0;
				}
				int num11 = (int)Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct29_0.int_1);
				int num12 = 0;
				uint_3 = 0u;
				for (uint num13 = 1u; num13 < 256; num13++)
				{
					if (num13 % 50u == 0)
					{
						Thread.Sleep(10);
					}
					if (num10 <= num12)
					{
						break;
					}
					if (num13 != num11)
					{
						num5 = num3 + num13 * Class47.gstruct43_15.uint_0;
						Class20.ReadProcessMemory(gstruct29_0.int_1, num5 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
						if (array[0] == 0)
						{
							continue;
						}
						num12++;
						Class20.ReadProcessMemory(gstruct29_0.int_1, num5 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
						if (BitConverter.ToInt32(array, 0) > 0)
						{
							num6 = Class20.smethod_30(num5, gstruct29_0.int_1);
							if (uint_1 == num6)
							{
								uint_3 = num13;
								break;
							}
						}
					}
					else
					{
						num12++;
					}
				}
				if (uint_3 == 0)
				{
					return -1;
				}
			}
			long num14 = Class53.smethod_18(uint_2, gstruct29_0.uint_4);
			uint_2 = new uint[2]
			{
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct29_0.int_1),
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct29_0.int_1)
			};
			long num15 = Class53.smethod_18(uint_2, gstruct29_0.uint_4);
			int num16 = FormMain.int_23;
			if (num16 < 200)
			{
				num16 = 200;
			}
			if (num15 - num14 > 22500L && num16 * num16 <= num15 && num15 <= 1000000L)
			{
				return 1;
			}
			return 0;
		}
		return 0;
	}

	public static void smethod_5(GStruct42 gstruct42_0, uint[] uint_1, uint[] uint_2, bool bool_2 = false)
	{
		if (uint_2 != null && uint_2[0] != 0 && uint_2[1] != 0)
		{
			bool flag = uint_1 != null && uint_1[0] != 0 && uint_1[1] != 0;
			long num = Class53.smethod_18(uint_1, uint_2);
			if (flag && (bool_2 || num < 14400L))
			{
				uint[] uint_3 = Class53.smethod_3(uint_1, uint_2, -150);
				Class60.smethod_61(gstruct42_0, uint_3);
			}
			else
			{
				Class60.smethod_61(gstruct42_0, uint_2);
			}
			Thread.Sleep(60);
		}
	}

	public static bool smethod_6(GStruct42 gstruct42_0, ref int int_2)
	{
		if (Class66.gstruct42_0.int_129 == gstruct42_0.int_129)
		{
			if (FormMain.int_61 > 0)
			{
				return 48 < gstruct29_0.int_7 && gstruct29_0.int_7 < 58;
			}
			int num = Class73.smethod_3(gstruct42_0);
			bool result = int_2 != num;
			int_2 = num;
			return result;
		}
		return false;
	}

	public static void smethod_7(int int_2)
	{
		if (FormMain.gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; FormMain.gstruct42_0.Length > i; i++)
		{
			if (!FormMain.gstruct42_0[i].bool_36)
			{
				continue;
			}
			switch (int_2)
			{
			case 5:
				new Thread(FormClickNPC.smethod_1).Start();
				continue;
			case 3:
			case 4:
				FormMain.int_98 = int_2;
				FormMain.gstruct42_0[i].bool_61 = FormMain.gstruct42_0[i].bool_36;
				continue;
			case 1:
			case 2:
				FormMain.gstruct42_0[i].int_75[4] = int_2;
				continue;
			}
			if (100 <= int_2 && int_2 <= 102)
			{
				FormMain.int_98 = int_2 - 100;
				Class11.smethod_32(ref Class36.int_0, FormMain.gstruct42_0[i].int_129);
				if (!Class36.bool_0)
				{
					Class36.smethod_0();
				}
				continue;
			}
			switch (int_2)
			{
			case 103:
				FormMain.gstruct42_0[i].bool_29 = FormMain.gstruct42_0[i].bool_36;
				break;
			case 104:
				for (int j = 0; j < 100; j++)
				{
					if (int_1 <= 0)
					{
						break;
					}
					Thread.Sleep(1);
				}
				int_1 = FormMain.gstruct42_0[i].int_129;
				new Thread(smethod_8).Start();
				break;
			}
		}
	}

	private static void smethod_8()
	{
		int num = int_1;
		int_1 = 0;
		int num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
		if (0 <= num2)
		{
			Class53.smethod_13(FormMain.gstruct42_0[num2]);
		}
	}
}
