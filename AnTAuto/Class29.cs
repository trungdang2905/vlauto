using System;
using System.IO;
using System.Threading;

internal class Class29
{
	public static bool bool_0 = false;

	private static int int_0 = 0;

	private static int int_1 = 0;

	public static int int_2 = 0;

	public static int int_3 = 0;

	public static int[] int_4 = null;

	private static int int_5 = -1;

	private static int int_6 = -1;

	private static GStruct42 gstruct42_0;

	public static int int_7 = 0;

	public static int int_8 = 0;

	public static bool smethod_0(int int_9)
	{
		return int_9 == 336 || int_9 == 341 || int_9 == 342 || int_9 == 962 || int_9 == 963 || (337 <= int_9 && int_9 <= 339) || (387 <= int_9 && int_9 <= 395) || (209 <= int_9 && int_9 <= 211) || (849 <= int_9 && int_9 <= 862) || (464 <= int_9 && int_9 <= 471) || (480 <= int_9 && int_9 <= 495) || (926 <= int_9 && int_9 <= 932);
	}

	public static void smethod_1()
	{
		while (true)
		{
			try
			{
				if (Class11.bool_0)
				{
					return;
				}
				smethod_2();
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
	}

	public static void smethod_2()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int int_ = 0;
		byte[] array = new byte[1];
		int_0 = 0;
		int_1 = 0;
		while (true)
		{
			num--;
			num2--;
			Thread.Sleep(1000);
			if (Class11.bool_0)
			{
				break;
			}
			if (bool_0)
			{
				int_0 = 0;
				num3 = 0;
				num = 8;
				bool_0 = false;
			}
			if (num <= 0)
			{
				num = 60;
				if (GClass1.string_0 != null && GClass1.string_0.Length != 0)
				{
					num3 = 1 - num3;
					int num5 = 0;
					int num6 = GClass1.string_0.Length;
					for (int i = 0; i < num6; i++)
					{
						if (GClass1.string_0[i] != null && !(GClass1.string_0[i] == string.Empty))
						{
							int length = GClass1.string_0[i].Length;
							for (int j = 0; j < length; j++)
							{
								if (GClass1.string_0[i][j] != '.')
								{
									continue;
								}
								for (int k = 0; k < Class20.gstruct41_0.Length; k++)
								{
									int num7 = 0;
									while (num7 < Class20.gstruct41_0[k].byte_0.Length)
									{
										if (length > j + num7 + 1 && Class20.gstruct41_0[k].byte_0[num7] == GClass1.string_0[i][j + num7 + 1])
										{
											num7++;
											continue;
										}
										goto IL_0139;
									}
									goto IL_015f;
									IL_0139:;
								}
								continue;
								IL_015f:
								num5++;
								break;
							}
						}
						else
						{
							num5++;
						}
					}
					Class7.bool_0 = (Class7.bool_0 || num5 < num6 || int_0 == num3);
					if (Class11.int_1 > 0 && Class11.uint_1 != 0)
					{
						array[0] = Convert.ToByte(num6 < num5 || int_0 == num3);
						Class20.WriteProcessMemory(Class11.int_1, Class11.uint_1 + 4, array, 1, ref int_);
					}
					int_0 = num3;
				}
			}
			if (num2 > 0)
			{
				continue;
			}
			num2 = 60;
			bool flag = false;
			string string_ = string.Concat(Class11.char_44);
			string text = Class11.smethod_30(string_, "#", new byte[8]);
			uint value = Class11.smethod_7(text);
			Class20.WriteProcessMemory(Class11.int_1, Class11.uint_1 + 8, BitConverter.GetBytes(value), 4, ref int_);
			if (!Class11.smethod_27(text))
			{
				continue;
			}
			num4 = 1 - num4;
			string[] files = Directory.GetFiles(text, "h" + Class11.smethod_48(Class11.string_10));
			if (files != null)
			{
				for (int l = 0; l < files.Length; l++)
				{
					string text2 = Class11.smethod_28(files[l], 0, 0, 1);
					if (text2 != null && !(text2 == string.Empty) && 0 <= Class11.smethod_2(text2, Class11.smethod_1(Class11.char_24)))
					{
						flag = true;
						break;
					}
				}
			}
			Class7.bool_0 = (Class7.bool_0 || flag || int_1 == num4);
			if (Class11.int_1 > 0 && Class11.uint_1 != 0)
			{
				array[0] = Convert.ToByte(flag || int_1 == num4);
				Class20.WriteProcessMemory(Class11.int_1, Class11.uint_1 + 4, array, 1, ref int_);
			}
			int_1 = num4;
		}
	}

	public static void smethod_3()
	{
		int int_ = int_3;
		int_3 = 0;
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
						FormMain.gstruct42_0[num].bool_44 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_44)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_44 = true;
					flag = true;
				}
				smethod_4(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	public static void smethod_4(int int_9)
	{
		int num = 0;
		int num2 = -1;
		GStruct42 gStruct = default(GStruct42);
		long long_ = 0L;
		long long_2 = 0L;
		int num3 = 0;
		int num4 = -1;
		int int_10 = 0;
		byte[] array = new byte[4];
		while (true)
		{
			num--;
			Thread.Sleep(300);
			if (num <= 0)
			{
				num2 = Class71.smethod_3(FormMain.gstruct42_0, int_9);
				if (Class11.bool_0 || num2 < 0 || !FormMain.gstruct42_0[num2].bool_36)
				{
					break;
				}
				num = 3;
			}
			gStruct = FormMain.gstruct42_0[num2];
			if (FormMain.int_63 > 0 && gStruct.int_69[0] <= 0 && Class11.smethod_23(long_2) > 30000L)
			{
				string str = FormMain.string_17;
				if (gStruct.bool_6)
				{
					str = FormMain.string_1 + " click npc ghÐp nép vËt phÈm event - htt p:// kimyen . n e t";
				}
				else if (gStruct.bool_5)
				{
					str = FormMain.string_1 + " ®ang läc vËt phÈm theo ®iÒu kiÖn - htt p:// kimyen . n e t";
				}
				Class60.smethod_55(gStruct, "Chat('CH_NEARBY', '" + str + "')");
				long_2 = Class11.smethod_22();
			}
			if (gStruct.int_112 <= 0 && gStruct.int_114 <= 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_10);
			uint num5 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num5 + Class47.gstruct43_13.uint_0, array, 4, ref int_10);
			uint num6 = BitConverter.ToUInt32(array, 0) * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_10);
			uint num7 = BitConverter.ToUInt32(array, 0);
			uint num8 = num7 + num6;
			Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_50.uint_0, array, 4, ref int_10);
			int num9 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_55.uint_0, array, 4, ref int_10);
			int num10 = BitConverter.ToInt32(array, 0);
			int num11 = Class73.smethod_40(gStruct);
			if (num9 != 0 && num11 > 1 && num10 != 0 && num10 != 10 && num10 != 21 && (gStruct.int_125[0] <= 0 || gStruct.int_125[5] <= 0))
			{
				Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_43.uint_0, array, 4, ref int_10);
				BitConverter.ToInt32(array, 0);
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_10);
				int int_11 = BitConverter.ToInt32(array, 0);
				if (Class11.smethod_23(long_) < 1000L)
				{
					continue;
				}
				int num12 = Class69.smethod_2(gStruct);
				if (0 <= num4 && num4 <= num12)
				{
					num4 = num12;
					continue;
				}
				num4 = num12;
				bool flag = false;
				if (gStruct.int_112 > 0)
				{
					flag = (smethod_7(gStruct, 0)[0] <= gStruct.int_113);
				}
				if (!flag && gStruct.int_114 > 0)
				{
					flag = (smethod_7(gStruct, 1)[0] <= gStruct.int_115);
				}
				if (flag)
				{
					num3++;
					long_ = Class11.smethod_22();
					if (!smethod_0(int_11) && num3 < 4)
					{
						Class53.smethod_13(gStruct);
						Thread.Sleep(300);
					}
					else if (!gStruct.bool_18)
					{
						num2 = Class71.smethod_3(FormMain.gstruct42_0, int_9);
						if (0 <= num2)
						{
							FormMain.gstruct42_0[num2].bool_18 = true;
							gStruct = FormMain.gstruct42_0[num2];
						}
					}
					continue;
				}
				num3 = 0;
				if (gStruct.bool_18)
				{
					num2 = Class71.smethod_3(FormMain.gstruct42_0, int_9);
					if (0 <= num2)
					{
						FormMain.gstruct42_0[num2].bool_18 = false;
						gStruct = FormMain.gstruct42_0[num2];
					}
				}
			}
			else
			{
				Thread.Sleep(100);
			}
		}
	}

	public static void smethod_5()
	{
		int int_ = int_2;
		int_2 = 0;
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
						FormMain.gstruct42_0[num].bool_46 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_46)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_46 = true;
					flag = true;
				}
				smethod_6(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	public static void smethod_6(int int_9)
	{
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		long long_5 = 0L;
		long long_6 = 0L;
		long long_7 = 0L;
		long long_8 = 0L;
		long long_9 = 0L;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		GStruct42 gStruct = default(GStruct42);
		int[] array = new int[7]
		{
			7,
			8,
			9,
			10,
			11,
			12,
			54
		};
		long long_10 = 0L;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		bool flag9 = false;
		bool flag10 = false;
		bool flag11 = false;
		int num = 0;
		int num2 = 0;
		int num3 = -1;
		int num4 = -1;
		int num5 = -1;
		int num6 = 0;
		int int_10 = 0;
		byte[] array2 = new byte[4];
		bool flag12 = false;
		bool flag13 = false;
		while (!Class11.bool_0)
		{
			num6--;
			Thread.Sleep(100);
			if (num6 <= 0)
			{
				num5 = Class71.smethod_3(FormMain.gstruct42_0, int_9);
				if (Class11.bool_0 || num5 < 0 || !FormMain.gstruct42_0[num5].bool_36)
				{
					break;
				}
				num6 = 10;
			}
			gStruct = FormMain.gstruct42_0[num5];
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array2, 4, ref int_10);
			uint num7 = BitConverter.ToUInt32(array2, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num7 + Class47.gstruct43_13.uint_0, array2, 4, ref int_10);
			uint num8 = BitConverter.ToUInt32(array2, 0) * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array2, 4, ref int_10);
			uint num9 = BitConverter.ToUInt32(array2, 0);
			uint num10 = num9 + num8;
			Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_50.uint_0, array2, 4, ref int_10);
			int num11 = BitConverter.ToInt32(array2, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_55.uint_0, array2, 4, ref int_10);
			int num12 = BitConverter.ToInt32(array2, 0);
			int num13 = Class73.smethod_40(gStruct);
			int num15;
			long num17;
			long num20;
			double num23;
			double num24;
			int num25;
			if (num11 != 0 && num13 > 1 && num12 != 0 && num12 != 10 && num12 != 21)
			{
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array2, 4, ref int_10);
				int num14 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_43.uint_0, array2, 4, ref int_10);
				num15 = BitConverter.ToInt32(array2, 0);
				if (num3 != num15)
				{
					int num16 = 0;
					while (num15 == 0 && num16 < 30 && num15 != num3)
					{
						Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_43.uint_0, array2, 4, ref int_10);
						num15 = BitConverter.ToInt32(array2, 0);
						Thread.Sleep(10);
						num16++;
					}
					if (num3 != num15)
					{
						flag2 = true;
						flag3 = true;
						flag7 = false;
						flag8 = false;
						num3 = num15;
						continue;
					}
				}
				if ((flag12 = (num != num14)) && num14 > 0)
				{
					flag2 = true;
					flag3 = true;
					flag7 = false;
					flag8 = false;
					flag5 = false;
					flag9 = Class89.smethod_0(num14);
					flag10 = (Class50.smethod_0(num14) != null);
					flag11 = (0 <= Class50.smethod_2(num14));
					flag6 = smethod_0(num14);
				}
				num = num14;
				Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_45.uint_0, array2, 4, ref int_10);
				num17 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_47.uint_0, array2, 4, ref int_10);
				long num18 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_47.uint_0 + 4, array2, 4, ref int_10);
				long num19 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_46.uint_0, array2, 4, ref int_10);
				num20 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_48.uint_0, array2, 4, ref int_10);
				long num21 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_48.uint_0 + 4, array2, 4, ref int_10);
				long num22 = BitConverter.ToInt32(array2, 0);
				if (num19 > num18 && num19 < 5000000L)
				{
					num18 = num19;
				}
				if (num22 > num21 && num22 < 5000000L)
				{
					num21 = num22;
				}
				if (num15 != 0 && num18 > 0L && num21 > 0L)
				{
					if (!flag13)
					{
						byte[] array3 = new byte[1];
						Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 4, array3, 1, ref int_10);
						if (array3[0] > 0)
						{
							smethod_8(gStruct, 0, 60);
						}
						flag13 = true;
					}
					flag = true;
					num23 = num17 * 100L / num18;
					num24 = num20 * 100L / num21;
					if (!flag6 && !flag5 && !flag9)
					{
						if (gStruct.int_110[0] <= 0 || gStruct.int_110[1] <= 0 || !(num23 <= (double)gStruct.int_110[1]))
						{
							if (gStruct.int_111[0] <= 0 || gStruct.int_111[1] <= 0)
							{
								num25 = 0;
								goto IL_0585;
							}
							if (!(num24 <= (double)gStruct.int_111[1]))
							{
								goto IL_05eb;
							}
						}
						goto IL_0587;
					}
					num25 = 0;
					goto IL_0585;
				}
				if (flag && flag12 && num18 < 100L)
				{
					smethod_8(gStruct, 0);
				}
				flag = false;
				flag5 = false;
				flag13 = false;
				continue;
			}
			Thread.Sleep(100);
			continue;
			IL_0587:
			if (Class11.smethod_23(long_) > 300L)
			{
				Class53.smethod_13(gStruct, bool_0: false);
				num2++;
				if (num2 > 3)
				{
					string string_ = Class73.smethod_20(gStruct);
					if (Class11.smethod_2(string_, "ph\u00b8t huy t\u00b8c dông t¹i") > 0)
					{
						flag5 = true;
						Class73.smethod_21(gStruct, "0K..");
					}
					num2 = 0;
				}
				long_ = Class11.smethod_22();
			}
			goto IL_05eb;
			IL_09af:
			int num26;
			if (num26 == 0)
			{
				goto IL_09b1;
			}
			goto IL_0a12;
			IL_05eb:
			bool flag14 = false;
			bool flag15 = false;
			if (!flag7 && gStruct.int_107[0] > 0 && num23 <= (double)gStruct.int_107[1] && gStruct.string_14 != null && gStruct.string_14 != string.Empty && gStruct.int_107[2] <= Class11.smethod_23(long_7))
			{
				flag7 = !smethod_9(gStruct, gStruct.string_14, gStruct.int_107[3]);
				long_7 = Class11.smethod_22();
			}
			if (!flag8 && gStruct.int_109[0] > 0 && num24 <= (double)gStruct.int_109[1] && gStruct.string_15 != null && gStruct.string_15 != string.Empty && gStruct.int_109[2] <= Class11.smethod_23(long_8))
			{
				flag8 = !smethod_9(gStruct, gStruct.string_15, gStruct.int_109[3]);
				long_8 = Class11.smethod_22();
			}
			if (gStruct.int_103[0] > 0 && gStruct.int_103[1] > 0 && num17 <= gStruct.int_103[1] && gStruct.int_103[2] <= Class11.smethod_23(long_5))
			{
				bool flag16 = false;
				if (gStruct.int_105 > 0 && flag3)
				{
					flag16 = (flag3 = smethod_8(gStruct, 0, gStruct.int_103[3], bool_1: true));
				}
				if (!flag16)
				{
					flag14 = !smethod_8(gStruct, 0, gStruct.int_103[3]);
				}
				long_5 = Class11.smethod_22();
			}
			if (gStruct.int_106[0] > 0 && gStruct.int_106[1] > 0 && num23 <= (double)gStruct.int_106[1] && gStruct.int_106[2] <= Class11.smethod_23(long_3))
			{
				bool flag16 = false;
				if (gStruct.int_105 > 0 && flag3)
				{
					flag16 = (flag3 = smethod_8(gStruct, 0, gStruct.int_106[3], bool_1: true));
				}
				if (!flag16)
				{
					flag14 = !smethod_8(gStruct, 0, gStruct.int_106[3]);
				}
				long_3 = Class11.smethod_22();
			}
			if (gStruct.int_104[0] > 0 && gStruct.int_104[1] > 0 && num20 <= gStruct.int_104[1] && gStruct.int_104[2] <= Class11.smethod_23(long_6))
			{
				if (flag2)
				{
					flag2 = smethod_8(gStruct, 1, gStruct.int_104[3], bool_1: true);
				}
				if (!flag2)
				{
					flag15 = !smethod_8(gStruct, 1, gStruct.int_104[3]);
				}
				long_6 = Class11.smethod_22();
			}
			if (gStruct.int_108[0] > 0 && gStruct.int_108[1] > 0 && num24 <= (double)gStruct.int_108[1] && gStruct.int_108[2] <= Class11.smethod_23(long_4))
			{
				if (flag2)
				{
					flag2 = smethod_8(gStruct, 1, gStruct.int_108[3], bool_1: true);
				}
				if (!flag2)
				{
					flag15 = !smethod_8(gStruct, 1, gStruct.int_108[3]);
				}
				long_4 = Class11.smethod_22();
			}
			if (FormMain.int_20 == 0 && gStruct.int_26 > 0 && gStruct.int_20 > 0 && num17 <= gStruct.int_19)
			{
				if (Class38.gstruct29_0.int_0 > 0)
				{
					Class60.smethod_48(gStruct, Class38.gstruct29_0.string_0, Class10.smethod_2("Thoát game vì Sinh lực thấp, Thím có thể thiết lập lại trong mục Hậu cần - Phục hồi nhé."));
					Thread.Sleep(600);
				}
				Class60.smethod_55(gStruct, "ExitGame()");
				Thread.Sleep(100);
				Class20.smethod_53(gStruct.process_0);
			}
			int num27 = Class69.smethod_2(gStruct);
			if (num4 != num27)
			{
				num4 = num27;
				flag8 = false;
				flag7 = false;
				flag4 = false;
			}
			if (num15 > 0)
			{
				if (!flag14 || gStruct.int_112 <= 0)
				{
					if (!flag15)
					{
						num26 = 1;
						goto IL_09af;
					}
					if (gStruct.int_114 <= 0)
					{
						goto IL_0a12;
					}
				}
				goto IL_09b1;
			}
			num26 = 1;
			goto IL_09af;
			IL_0585:
			if (num25 != 0)
			{
				goto IL_0587;
			}
			goto IL_05eb;
			IL_0a12:
			if (gStruct.int_73[0] > 0 && Class11.smethod_23(long_10) > gStruct.int_73[1])
			{
				for (int i = 0; i < array.Length; i++)
				{
					for (uint num28 = 0u; num28 < 6; num28++)
					{
						Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0 + Class47.gstruct43_2.uint_0 * num28, array2, 4, ref int_10);
						int num29 = BitConverter.ToInt32(array2, 0);
						if (num29 == array[i])
						{
							smethod_8(gStruct, 3, gStruct.int_73[2], bool_1: true);
							long_10 = Class11.smethod_22();
							break;
						}
					}
				}
			}
			if (gStruct.int_60 <= 0 || num15 <= 0 || flag4 || Class11.smethod_23(long_9) <= 30000L)
			{
				continue;
			}
			int num30 = 0;
			for (uint num28 = 0u; num28 < 6; num28++)
			{
				uint num31 = Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0 + Class47.gstruct43_2.uint_0 * num28;
				int num32 = (int)Class20.smethod_30(num10 + num31 + 20, gStruct.int_130);
				if (num32 == 1)
				{
					num30++;
					Class20.ReadProcessMemory(gStruct.int_130, num10 + num31, array2, 4, ref int_10);
					int num29 = BitConverter.ToInt32(array2, 0);
					if (num29 == 67)
					{
						num30 = -1;
						break;
					}
				}
			}
			if (num30 != -1 && num30 < 6)
			{
				flag4 = !smethod_10(gStruct);
			}
			long_9 = Class11.smethod_22();
			continue;
			IL_09b1:
			if (!flag9 && !flag10 && !flag11 && Class11.smethod_23(long_2) > 800L)
			{
				if (!flag6 && !flag5)
				{
					Class53.smethod_13(gStruct, bool_0: false);
				}
				else
				{
					num5 = Class71.smethod_3(FormMain.gstruct42_0, int_9);
					if (0 <= num5)
					{
						FormMain.gstruct42_0[num5].bool_18 = true;
					}
				}
				long_2 = Class11.smethod_22();
			}
			goto IL_0a12;
		}
	}

	public static int[] smethod_7(GStruct42 gstruct42_1, int int_9, bool bool_1 = false)
	{
		int int_10 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_102.uint_0, array2, 4, ref int_10);
		uint num = BitConverter.ToUInt32(array2, 0);
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_11.uint_0, array2, 4, ref int_10);
		uint num2 = BitConverter.ToUInt32(array2, 0) + Class47.gstruct43_94.uint_0;
		int num3 = Class69.smethod_2(gstruct42_1);
		int num4 = 0;
		int[] array3 = new int[2];
		for (uint num5 = 1u; num5 < Class47.int_1; num5++)
		{
			if (num5 % 50u == 0)
			{
				Thread.Sleep(10);
			}
			if (0 < num3 && num3 <= num4)
			{
				break;
			}
			uint num6 = num + num5 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_10);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_104.uint_0, array, 1, ref int_10);
			if (array[0] == 0)
			{
				continue;
			}
			uint num7 = Class69.smethod_0(gstruct42_1, num5);
			if (num7 == 0)
			{
				continue;
			}
			num4++;
			uint num8 = num2 + num7 * 20;
			Class20.ReadProcessMemory(gstruct42_1.int_130, num8 + Class47.gstruct43_97.uint_0 - 8, array2, 4, ref int_10);
			int num9 = BitConverter.ToInt32(array2, 0);
			if (num9 != 3)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_108.uint_0, array2, 4, ref int_10);
			int num10 = BitConverter.ToInt32(array2, 0);
			Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_109.uint_0, array2, 4, ref int_10);
			int num11 = BitConverter.ToInt32(array2, 0);
			array3[1] += num11 * num10;
			if (num10 != 1 || num11 != 1)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_105.uint_0, array, 1, ref int_10);
			if (array[0] != 1)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_107.uint_0, array2, 4, ref int_10);
			int num12 = BitConverter.ToInt32(array2, 0);
			if (num12 == int_9 || (!bool_1 && num12 > 0 && (num12 % 2 == 0 || num12 == 9)))
			{
				Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_116.uint_0, array2, 4, ref int_10);
				int num13 = BitConverter.ToInt32(array2, 0);
				if (num13 <= 0)
				{
					num13 = 1;
				}
				array3[0] += num13;
			}
		}
		return array3;
	}

	public static bool smethod_8(GStruct42 gstruct42_1, int int_9, int int_10 = 1, bool bool_1 = false)
	{
		int num = 0;
		uint num2 = 1u;
		int int_11 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_102.uint_0, array2, 4, ref int_11);
		uint num3 = BitConverter.ToUInt32(array2, 0);
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_11.uint_0, array2, 4, ref int_11);
		uint num4 = BitConverter.ToUInt32(array2, 0) + Class47.gstruct43_94.uint_0;
		while (true)
		{
			int num5 = Class69.smethod_2(gstruct42_1);
			int num6 = 0;
			uint num7 = num2;
			int num17;
			while (true)
			{
				if (num7 < Class47.int_1)
				{
					if (num7 % 80u == 0)
					{
						Thread.Sleep(10);
					}
					if (0 >= num5 || num5 > num6)
					{
						uint num8 = num3 + num7 * Class47.gstruct43_103.uint_0;
						Class20.ReadProcessMemory(gstruct42_1.int_130, num8 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_11);
						if (BitConverter.ToInt32(array2, 0) != 0)
						{
							goto IL_02ad;
						}
						Class20.ReadProcessMemory(gstruct42_1.int_130, num8 + Class47.gstruct43_104.uint_0, array, 1, ref int_11);
						if (array[0] == 0)
						{
							goto IL_02ad;
						}
						uint num9 = Class69.smethod_0(gstruct42_1, num7);
						if (num9 == 0)
						{
							goto IL_02ad;
						}
						num6++;
						Class20.ReadProcessMemory(gstruct42_1.int_130, num8 + Class47.gstruct43_105.uint_0, array2, 4, ref int_11);
						if (BitConverter.ToInt32(array2, 0) != 1)
						{
							goto IL_02ad;
						}
						Class20.ReadProcessMemory(gstruct42_1.int_130, num8 + Class47.gstruct43_107.uint_0, array2, 4, ref int_11);
						int num10 = BitConverter.ToInt32(array2, 0);
						if (num10 != int_9 && (bool_1 || num10 <= 0 || (num10 % 2 != 0 && num10 != 9)))
						{
							goto IL_02ad;
						}
						uint num11 = num4 + num9 * 20;
						uint uint_ = num11 + Class47.gstruct43_97.uint_0 - 8;
						Class20.ReadProcessMemory(gstruct42_1.int_130, uint_, array2, 4, ref int_11);
						int num12 = BitConverter.ToInt32(array2, 0);
						if (num12 != 3)
						{
							goto IL_02ad;
						}
						Class20.ReadProcessMemory(gstruct42_1.int_130, num11 + Class47.gstruct43_97.uint_0 - 4, array2, 4, ref int_11);
						int num13 = BitConverter.ToInt32(array2, 0);
						if (num13 < 0)
						{
							goto IL_02ad;
						}
						Class20.ReadProcessMemory(gstruct42_1.int_130, num11 + Class47.gstruct43_97.uint_0, array2, 4, ref int_11);
						int num14 = BitConverter.ToInt32(array2, 0);
						if (num14 < 0)
						{
							goto IL_02ad;
						}
						Class20.ReadProcessMemory(gstruct42_1.int_130, num8 + Class47.gstruct43_108.uint_0, array2, 4, ref int_11);
						int num15 = BitConverter.ToInt32(array2, 0);
						if (num15 != 1)
						{
							goto IL_02ad;
						}
						Class20.ReadProcessMemory(gstruct42_1.int_130, num8 + Class47.gstruct43_109.uint_0, array2, 4, ref int_11);
						int num16 = BitConverter.ToInt32(array2, 0);
						if (num16 != 1)
						{
							goto IL_02ad;
						}
						Class20.ReadProcessMemory(gstruct42_1.int_130, num8 + Class47.gstruct43_116.uint_0, array2, 4, ref int_11);
						num17 = BitConverter.ToInt32(array2, 0);
						Class60.smethod_41(gstruct42_1, num7, num13, num14, num12);
						num++;
						if (num < int_10)
						{
							break;
						}
					}
				}
				return num > 0;
				IL_02ad:
				num7++;
			}
			num2 = num7 + Convert.ToByte(num17 <= 0);
		}
	}

	public static bool smethod_9(GStruct42 gstruct42_1, string string_0, int int_9 = 1, int int_10 = -1)
	{
		int num = 0;
		uint num2 = 1u;
		int int_11 = 0;
		byte[] array = new byte[4];
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_102.uint_0, array, 4, ref int_11);
		uint num3 = BitConverter.ToUInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_11);
		uint num4 = BitConverter.ToUInt32(array, 0) + Class47.gstruct43_94.uint_0;
		string b = string_0.Replace(" ", string.Empty).Replace("Ù", string.Empty).ToLower();
		int num5 = 1;
		if (1 < string_0.Length)
		{
			num5 = string_0.Length;
		}
		num5 += 3;
		byte[] array2 = new byte[num5];
		string_0 = string_0.Trim();
		while (true)
		{
			int num6 = Class69.smethod_2(gstruct42_1);
			int num7 = 0;
			uint num8 = num2;
			int num17;
			while (true)
			{
				if (num8 < Class47.int_1 && (0 >= num6 || num6 > num7))
				{
					uint num9 = num3 + num8 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_11);
					if (BitConverter.ToInt32(array, 0) != 0)
					{
						goto IL_02fd;
					}
					Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_104.uint_0, array, 1, ref int_11);
					if (array[0] == 0)
					{
						goto IL_02fd;
					}
					uint num10 = Class69.smethod_0(gstruct42_1, num8);
					if (num10 == 0)
					{
						goto IL_02fd;
					}
					num7++;
					if (0 <= int_10)
					{
						Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_105.uint_0, array, 4, ref int_11);
						if (BitConverter.ToInt32(array, 0) != int_10)
						{
							goto IL_02fd;
						}
					}
					Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_104.uint_0, array2, array2.Length, ref int_11);
					string text = Class10.smethod_3(array2).Trim();
					string a = text.Replace(" ", string.Empty).Replace("Ù", string.Empty).ToLower();
					if (text != string_0 && a != b)
					{
						goto IL_02fd;
					}
					uint num11 = num4 + num10 * 20;
					Class20.ReadProcessMemory(gstruct42_1.int_130, num11 + Class47.gstruct43_97.uint_0 - 8, array, 4, ref int_11);
					int num12 = BitConverter.ToInt32(array, 0);
					if (num12 != 3)
					{
						goto IL_02fd;
					}
					Class20.ReadProcessMemory(gstruct42_1.int_130, num11 + Class47.gstruct43_97.uint_0 - 4, array, 4, ref int_11);
					int num13 = BitConverter.ToInt32(array, 0);
					if (num13 < 0)
					{
						goto IL_02fd;
					}
					Class20.ReadProcessMemory(gstruct42_1.int_130, num11 + Class47.gstruct43_97.uint_0, array, 4, ref int_11);
					int num14 = BitConverter.ToInt32(array, 0);
					if (num14 < 0)
					{
						goto IL_02fd;
					}
					Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_108.uint_0, array, 4, ref int_11);
					int num15 = BitConverter.ToInt32(array, 0);
					if (num15 < 1)
					{
						goto IL_02fd;
					}
					Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_109.uint_0, array, 4, ref int_11);
					int num16 = BitConverter.ToInt32(array, 0);
					if (num16 < 1)
					{
						goto IL_02fd;
					}
					Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_116.uint_0, array, 4, ref int_11);
					num17 = BitConverter.ToInt32(array, 0);
					Class60.smethod_41(gstruct42_1, num8, num13, num14, num12);
					num++;
					if (num < int_9)
					{
						break;
					}
				}
				return num > 0;
				IL_02fd:
				num8++;
			}
			num2 = num8 + Convert.ToByte(num17 <= 0);
		}
	}

	public static bool smethod_10(GStruct42 gstruct42_1)
	{
		int num = 0;
		int int_ = 0;
		byte[] array = new byte[4];
		string text = "Tiªn Th¶o Lé".ToLower();
		byte[] array2 = new byte[text.Length + 3];
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_102.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
		uint num3 = BitConverter.ToUInt32(array, 0) + Class47.gstruct43_94.uint_0;
		int num4 = Class69.smethod_2(gstruct42_1);
		int num5 = 0;
		uint num6 = 1u;
		int num10;
		int num11;
		int num12;
		while (true)
		{
			if (num6 < Class47.int_1)
			{
				if (num6 % 50u == 0)
				{
					Thread.Sleep(30);
				}
				if (0 >= num4 || num4 > num5)
				{
					uint num7 = num2 + num6 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_1.int_130, num7 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) == 0)
					{
						Class20.ReadProcessMemory(gstruct42_1.int_130, num7 + Class47.gstruct43_104.uint_0, array, 1, ref int_);
						if (array[0] != 0)
						{
							uint num8 = Class69.smethod_0(gstruct42_1, num6);
							if (num8 != 0)
							{
								num5++;
								Class20.ReadProcessMemory(gstruct42_1.int_130, num7 + Class47.gstruct43_105.uint_0, array, 4, ref int_);
								if (BitConverter.ToInt32(array, 0) == 6)
								{
									Class20.ReadProcessMemory(gstruct42_1.int_130, num7 + Class47.gstruct43_104.uint_0, array2, array2.Length, ref int_);
									string string_ = Class10.smethod_3(array2).Replace("Ù", string.Empty).ToLower();
									if (Class11.smethod_2(string_, text) >= 0)
									{
										uint num9 = num3 + num8 * 20;
										Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_97.uint_0 - 8, array, 4, ref int_);
										num10 = BitConverter.ToInt32(array, 0);
										if (num10 == 3)
										{
											Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_97.uint_0 - 4, array, 4, ref int_);
											num11 = BitConverter.ToInt32(array, 0);
											if (num11 >= 0)
											{
												Class20.ReadProcessMemory(gstruct42_1.int_130, num9 + Class47.gstruct43_97.uint_0, array, 4, ref int_);
												num12 = BitConverter.ToInt32(array, 0);
												if (num12 >= 0)
												{
													break;
												}
											}
										}
									}
								}
							}
						}
					}
					num6++;
					continue;
				}
			}
			return false;
		}
		num = 0;
		while (num < 30)
		{
			Class20.ReadProcessMemory(gstruct42_1.int_130, gstruct42_1.uint_41 - 4, array, 1, ref int_);
			if (array[0] == 0)
			{
				break;
			}
			num++;
			Thread.Sleep(1);
		}
		Class60.smethod_41(gstruct42_1, num6, num11, num12, num10);
		return true;
	}

	public static void smethod_11(GStruct42 gstruct42_1)
	{
		try
		{
			smethod_12(gstruct42_1);
		}
		catch
		{
		}
	}

	private static void smethod_12(GStruct42 gstruct42_1)
	{
		int num = 0;
		string[] array = new string[3]
		{
			gstruct42_1.string_9,
			gstruct42_1.string_10,
			gstruct42_1.string_11
		};
		int int_ = 0;
		byte[] array2 = new byte[80];
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_1.int_130);
		uint num10 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_1.int_130) + Class47.gstruct43_94.uint_0;
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i];
			if (text == null || text == string.Empty)
			{
				continue;
			}
			text = array[i].Trim();
			string object_ = Class10.smethod_1(array[i], 1).ToUpper();
			if (gstruct42_1.int_74.Length <= i + 1)
			{
				continue;
			}
			uint num3 = (uint)gstruct42_1.int_74[i + 1];
			if (num3 == 0 || num3 > 9)
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < 9; j++)
			{
				uint num4 = Class39.smethod_8(gstruct42_1, j);
				if (num4 != 0)
				{
					uint num5 = num2 + num4 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_1.int_130, num5 + Class47.gstruct43_104.uint_0, array2, array2.Length, ref int_);
					string text2 = Class10.smethod_3(array2);
					string string_ = Class10.smethod_1(text2, 1);
					if (0 <= Class11.smethod_2(text2, text) || 0 <= Class11.smethod_2(string_, object_))
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				continue;
			}
			uint num6 = Class69.smethod_27(gstruct42_1, text);
			if (num6 != 0)
			{
				num = 300;
				uint uint_ = Class69.smethod_0(gstruct42_1, num6);
				uint num7 = Class69.smethod_4(gstruct42_1, uint_);
				uint num8 = Class69.smethod_5(gstruct42_1, uint_);
				bool flag2 = true;
				int num9 = 0;
				while (true)
				{
					if (!Class11.bool_0)
					{
						if ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_1.int_130) > 0)
						{
							break;
						}
						if (num9 % 30 == 0)
						{
							Class60.smethod_44(gstruct42_1, num7, num8, 3u, num7, num8, 3u);
						}
						Thread.Sleep(3);
						num9++;
						if (num9 > 300)
						{
							flag2 = false;
							break;
						}
						continue;
					}
					return;
				}
				if (!flag2)
				{
					continue;
				}
				num9 = 0;
				num3--;
				while (true)
				{
					if (!Class11.bool_0)
					{
						if ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_1.int_130) <= 0)
						{
							break;
						}
						if (num9 % 30 == 0)
						{
							Class60.smethod_44(gstruct42_1, num3, 0u, 7u, num3, 0u, 7u);
						}
						Thread.Sleep(3);
						num9++;
						if (num9 > 300)
						{
							flag2 = false;
							break;
						}
						continue;
					}
					return;
				}
				if (!flag2)
				{
					Class60.smethod_44(gstruct42_1, num7, num8, 3u, num7, num8, 3u);
				}
			}
			else if (num <= 0)
			{
				num = 60;
			}
		}
	}

	public static void smethod_13()
	{
		while (true)
		{
			try
			{
				if (Class11.bool_0)
				{
					return;
				}
				smethod_14();
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	public static void smethod_14()
	{
		int num = -1;
		int num2 = -1;
		GStruct42 gStruct = default(GStruct42);
		gStruct.int_129 = 0;
		GStruct42 gStruct2 = gStruct;
		while (!Class11.bool_0)
		{
			Thread.Sleep(80);
			if (num != Class66.gstruct42_0.int_129)
			{
				num = Class66.gstruct42_0.int_129;
				if (num <= 0)
				{
					gStruct2.int_129 = 0;
				}
				else
				{
					num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
					if (num2 >= 0)
					{
						gStruct2 = FormMain.gstruct42_0[num2];
					}
				}
			}
			while (gStruct2.int_129 != 0 && gStruct2.gstruct39_0 != null && int_4 != null && int_4.Length != 0)
			{
				int num3 = int_4[0];
				Class11.smethod_33(ref int_4, num3);
				for (int i = 0; i < gStruct2.gstruct39_0.Length; i++)
				{
					if (num3 != gStruct2.gstruct39_0[i].int_0)
					{
						continue;
					}
					int_5 = i;
					if (gStruct2.bool_36 && (Combo.int_6 > 0 || Class32.smethod_26(gStruct2) > 0))
					{
						gstruct42_0 = gStruct2;
						int_6 = 1;
						new Thread(smethod_15).Start();
					}
					if (Combo.int_5 == 0 || FormMain.gstruct42_0 == null || FormMain.gstruct42_0.Length == 0)
					{
						continue;
					}
					for (int j = 0; j < FormMain.gstruct42_0.Length; j++)
					{
						if (FormMain.gstruct42_0[j].bool_36 && FormMain.gstruct42_0[j].int_129 != gStruct2.int_129 && (Combo.int_6 > 0 || Class32.smethod_26(FormMain.gstruct42_0[j]) != 0))
						{
							int num4 = 0;
							while (0 <= int_5 && num4 < 3)
							{
								Thread.Sleep(50);
								num4++;
							}
							int_5 = i;
							int_6 = Combo.int_4;
							gstruct42_0 = FormMain.gstruct42_0[j];
							gstruct42_0.gstruct39_0 = gStruct2.gstruct39_0;
							new Thread(smethod_15).Start();
						}
					}
				}
			}
			int_4 = null;
			if (gStruct2.int_129 == 0)
			{
				Thread.Sleep(300);
			}
		}
	}

	public static void smethod_15()
	{
		int num = int_5;
		int num2 = int_6;
		GStruct42 gstruct42_ = gstruct42_0;
		int_5 = -1;
		if (num < 0 || gstruct42_.gstruct39_0 == null || num >= gstruct42_.gstruct39_0.Length || gstruct42_.gstruct39_0[num].gstruct37_0 == null)
		{
			return;
		}
		int num3 = gstruct42_.gstruct39_0[num].gstruct37_0.Length;
		for (int i = 0; i < num3; i++)
		{
			int num4 = gstruct42_.gstruct39_0[num].gstruct37_0[i].int_0 / num2;
			int num5 = gstruct42_.gstruct39_0[num].gstruct37_0[i].int_0 % num2;
			if (num5 > 0)
			{
				num5 = 1;
			}
			smethod_9(gstruct42_, gstruct42_.gstruct39_0[num].gstruct37_0[i].string_0, num4 + num5);
		}
	}

	public static void smethod_16(GStruct42 gstruct42_1)
	{
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		byte[] byte_ = new byte[60];
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_102.uint_0, array2, 4, ref int_);
		uint num = BitConverter.ToUInt32(array2, 0);
		Class20.ReadProcessMemory(gstruct42_1.int_130, Class47.gstruct43_11.uint_0, array2, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array2, 0) + Class47.gstruct43_94.uint_0;
		int num3 = Class69.smethod_2(gstruct42_1);
		int num4 = 0;
		string text = null;
		for (uint num5 = 1u; num5 < 600; num5++)
		{
			uint num6 = num + num5 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_104.uint_0, array, 1, ref int_);
			if (array[0] != 0)
			{
				Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_);
				int num7 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_105.uint_0, array2, 4, ref int_);
				int num8 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_107.uint_0, array2, 4, ref int_);
				int num9 = BitConverter.ToInt32(array2, 0);
				uint num10 = Class69.smethod_0(gstruct42_1, num5);
				if (num10 != 0)
				{
					num4++;
					uint num11 = num2 + num10 * 20;
					Class20.ReadProcessMemory(gstruct42_1.int_130, num11 + Class47.gstruct43_97.uint_0 - 8, array2, 4, ref int_);
					int num12 = BitConverter.ToInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_1.int_130, num11 + Class47.gstruct43_97.uint_0 - 4, array2, 4, ref int_);
					int num13 = BitConverter.ToInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_1.int_130, num11 + Class47.gstruct43_97.uint_0, array2, 4, ref int_);
					int num14 = BitConverter.ToInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_116.uint_0, array2, 4, ref int_);
					int num15 = BitConverter.ToInt32(array2, 0);
					Class20.ReadProcessMemory(gstruct42_1.int_130, num6 + Class47.gstruct43_104.uint_0, byte_, 60, ref int_);
					string text2 = Class10.smethod_3(byte_);
					string str = num4 + "| " + num5 + "|iExits:" + num7 + "|iKind:" + num8 + "|Genre:" + num9 + "|iBox:" + num12 + "|Col:" + num13 + "|Row:" + num14 + "|Dur:" + num15 + "|NameA:" + text2 + "| " + Class10.smethod_1(text2, 1);
					text = text + str + Class47.string_3;
				}
			}
		}
		Class47.smethod_23("testitem.txt", num3 + ":" + num4 + Class47.string_3 + text);
	}

	private static void smethod_17(GStruct42 gstruct42_1)
	{
		int num = 0;
		int int_ = 0;
		byte[] byte_ = new byte[4];
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_1.int_130);
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_1.int_130);
		uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_1.int_130);
		uint num5 = num4 + num3 * Class47.gstruct43_15.uint_0;
		int num6 = 0;
		while (num6 < 300 && num < 1000)
		{
			Class20.WriteProcessMemory(gstruct42_1.int_130, gstruct42_1.uint_6 + Class47.gstruct43_174.uint_0, byte_, 4, ref int_);
			Class20.WriteProcessMemory(gstruct42_1.int_130, num5 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
			num6 = ((Class20.smethod_30(num5 + Class47.gstruct43_55.uint_0, gstruct42_1.int_130) < 3) ? (num6 + 1) : 0);
			num++;
			Thread.Sleep(1);
		}
		Thread.Sleep(100);
	}

	private static void smethod_18(GStruct42 gstruct42_1, int int_9)
	{
		uint num = 0u;
		int num2 = 0;
		while (num == 0)
		{
			num = Class20.smethod_30(gstruct42_1.uint_6 + Class47.gstruct43_154.uint_0, gstruct42_1.int_130);
			Thread.Sleep(1);
			num2++;
			if (num2 > 300)
			{
				return;
			}
		}
		int num3 = -1;
		long long_ = Class11.smethod_22();
		while (Class11.smethod_23(long_) <= int_9)
		{
			Thread.Sleep(100);
			num = Class20.smethod_30(gstruct42_1.uint_6 + Class47.gstruct43_154.uint_0, gstruct42_1.int_130);
			int num4 = (int)Class20.smethod_30(num + Class47.gstruct43_155.uint_0, gstruct42_1.int_130);
			if (num4 <= 1)
			{
				num3++;
				if (num3 > 3)
				{
					break;
				}
			}
			else
			{
				if (num3 < 0 && num4 > 100)
				{
					break;
				}
				num3 = 0;
			}
		}
	}

	public static void smethod_19()
	{
		int int_ = int_7;
		int_7 = 0;
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
						FormMain.gstruct42_0[num].bool_40 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_40)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_40 = true;
					flag = true;
				}
				smethod_20(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_20(int int_9)
	{
		GStruct42 gStruct = default(GStruct42);
		long[] array = null;
		long[] array2 = null;
		long[] array3 = null;
		bool[] array4 = null;
		int[] array5 = null;
		int[] array6 = null;
		int[] array7 = null;
		int num = 0;
		int num2 = 300;
		int num3 = -1;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		long long_ = 0L;
		while (true)
		{
			IL_0a35:
			Thread.Sleep(160 + num2);
			num = Class71.smethod_3(FormMain.gstruct42_0, int_9);
			if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36)
			{
				break;
			}
			gStruct = FormMain.gstruct42_0[num];
			num2 = 300;
			if (num6 < 100 && Class60.smethod_3(gStruct, Class60.uint_5) > 0)
			{
				num6++;
				Thread.Sleep(100);
				continue;
			}
			num6 = 0;
			uint num9 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
			uint num10 = Class20.smethod_30(num9 + Class47.gstruct43_13.uint_0, gStruct.int_130);
			uint num11 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
			uint num12 = num11 + num10 * Class47.gstruct43_15.uint_0;
			int num13 = (int)Class20.smethod_30(num12 + Class47.gstruct43_43.uint_0, gStruct.int_130);
			int num14 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
			int num15 = (int)Class20.smethod_30(num12 + Class47.gstruct43_55.uint_0, gStruct.int_130);
			int num16 = (int)Class20.smethod_30(num12 + Class47.gstruct43_50.uint_0, gStruct.int_130);
			int num17 = Class73.smethod_40(gStruct);
			GStruct30 gStruct2;
			bool flag2;
			bool flag3;
			int num21;
			int num26;
			int num23;
			int num24;
			if (num16 != 0 && num15 != 0 && num17 > 1 && num14 != 0)
			{
				if (num13 <= 0 || num7 != num14)
				{
					num7 = num14;
					num8 = 0;
				}
				if (num13 > 0 && gStruct.int_123[0] > 0 && gStruct.int_129 != Class38.gstruct29_0.int_0 && Class60.smethod_3(gStruct, Class60.uint_13) == 1)
				{
					bool flag = false;
					int num18 = Class69.smethod_2(gStruct);
					for (int i = 0; i < Class47.string_19.GetLength(0); i++)
					{
						for (int j = 0; j < Class47.string_19.GetLength(1); j++)
						{
							if (Class47.string_19[i, j] != null)
							{
								uint num19 = Class69.smethod_27(gStruct, Class47.string_19[i, j], bool_1: false, 3u, bool_2: true);
								if (num19 != 0)
								{
									Class60.smethod_99(gStruct, num19);
									flag = true;
									Thread.Sleep(300);
									break;
								}
							}
						}
					}
					Class60.smethod_2(gStruct, Class60.uint_13, 2, 4);
					if (flag && FormMain.int_28 > 0 && num8 < 4 && (num14 == 336 || !smethod_0(num14)))
					{
						int num20 = 0;
						while (num20 < 8)
						{
							Thread.Sleep(150);
							if (Class69.smethod_2(gStruct) < num18)
							{
								break;
							}
							num15 = (int)Class20.smethod_30(num12 + Class47.gstruct43_55.uint_0, gStruct.int_130);
							num13 = (int)Class20.smethod_30(num12 + Class47.gstruct43_43.uint_0, gStruct.int_130);
							if (num15 != 10 && num15 != 21 && num13 != 0)
							{
								num20++;
								continue;
							}
							goto IL_0a35;
						}
						num8++;
						Class53.smethod_13(gStruct);
					}
				}
				if (num15 == 10 || num15 == 21)
				{
					continue;
				}
				if (num5 > 0)
				{
					num5--;
					if (Class20.smethod_30(gStruct.uint_6 + Class47.gstruct43_168.uint_0, gStruct.int_130) != 0)
					{
						Class20.smethod_4(gStruct.uint_4, 13u);
						num5 = 0;
					}
				}
				if (gStruct.gstruct30_0 == null || (FormMain.int_13 > 0 && num13 <= 0))
				{
					continue;
				}
				if (num3 != gStruct.gstruct30_0.Length)
				{
					num3 = gStruct.gstruct30_0.Length;
					if (num3 == 0)
					{
						continue;
					}
					array = new long[num3];
					array2 = new long[num3];
					array3 = new long[num3];
					array5 = new int[num3];
					array4 = new bool[num3];
					array6 = new int[num3];
					array7 = new int[num3];
				}
				for (int i = 0; i < num3; i++)
				{
					if (gStruct.gstruct30_0[i].int_4 > 0)
					{
						num2 = 0;
						break;
					}
				}
				if (num3 <= num4)
				{
					num4 = 0;
				}
				gStruct2 = gStruct.gstruct30_0[num4];
				flag2 = false;
				flag3 = (gStruct2.int_7 > 0 && gStruct2.int_8 != null);
				num21 = Class69.smethod_2(gStruct);
				int num22 = 0;
				num23 = 0;
				num24 = 0;
				int num25 = 0;
				num26 = 0;
				if (gStruct2.int_4 > 0 && ((!array4[num4] && array5[num4] != num21) || Class11.smethod_23(array[num4]) >= 1000L))
				{
					array[num4] = Class11.smethod_22();
					array4[num4] = false;
					int[] array8 = smethod_7(gStruct, 2);
					if (gStruct2.int_5 >= array8[0])
					{
						if (array8[1] > 59)
						{
							array5[num4] = num21;
							continue;
						}
						while (flag2 = Class53.smethod_17(gStruct, gStruct2.string_0))
						{
							num5 = 5;
							num22 = 0;
							while (num22 < 300 && Class20.smethod_30(gStruct.uint_6 + Class47.gstruct43_168.uint_0, gStruct.int_130) == 0)
							{
								if (!flag3 || !Class76.smethod_0(gStruct))
								{
									Thread.Sleep(1);
									num22++;
									continue;
								}
								goto IL_0615;
							}
							num23 = 0;
							if (Class39.smethod_5(gStruct, FormMain.int_12.ToString(), bool_0: true) <= 0)
							{
								int num27 = Class69.smethod_2(gStruct);
								if (num27 <= num21)
								{
									if (num25 == 0)
									{
										num25++;
										continue;
									}
									goto IL_05ec;
								}
								goto IL_060d;
							}
							goto IL_0615;
						}
						array4[num4] = (Class69.smethod_28(gStruct, gStruct2.string_0) <= 0);
						if (array4[num4] && FormMain.int_29 > 0 && Class11.smethod_23(long_) > 30000L)
						{
							Class30.smethod_2(gStruct);
							long_ = Class11.smethod_22();
						}
						goto IL_0a18;
					}
					array5[num4] = num21;
				}
				goto IL_06f3;
			}
			Thread.Sleep(100);
			continue;
			IL_06f3:
			if (array2[num4] == 0L)
			{
				array2[num4] = Class11.smethod_22();
			}
			if (gStruct2.int_0 <= 0)
			{
				array2[num4] = Class11.smethod_22();
			}
			else if (Class11.smethod_23(array2[num4]) >= gStruct2.int_3)
			{
				array2[num4] = Class11.smethod_22();
				while (flag2 = Class53.smethod_17(gStruct, gStruct2.string_0))
				{
					num5 = 5;
					for (int num22 = 0; num22 < 300; num22++)
					{
						if (Class20.smethod_30(gStruct.uint_6 + Class47.gstruct43_168.uint_0, gStruct.int_130) != 0)
						{
							break;
						}
						Thread.Sleep(1);
					}
					num23 = 0;
					if (Class39.smethod_5(gStruct, FormMain.int_12.ToString(), bool_0: true) <= 0)
					{
						int num27 = Class69.smethod_2(gStruct);
						if (num27 > num21)
						{
							goto IL_0810;
						}
						if (num26 == 0)
						{
							num26++;
							continue;
						}
						num23 = Class53.smethod_27(gStruct, gStruct2.string_0, FormMain.int_12, bool_0: true);
						if (num23 <= 0)
						{
							break;
						}
					}
					num24 = 0;
					goto IL_083a;
				}
				goto IL_0a18;
			}
			goto IL_0882;
			IL_05ec:
			num23 = Class53.smethod_27(gStruct, gStruct2.string_0, FormMain.int_12, bool_0: true);
			if (num23 > 0)
			{
				goto IL_0615;
			}
			goto IL_0a18;
			IL_0a18:
			if (flag2)
			{
				Class76.smethod_9(gStruct);
			}
			num4++;
			continue;
			IL_0882:
			if (gStruct2.int_1 > 0 && (array7[num4] != num14 || array6[num4] != num13))
			{
				if (Class11.smethod_23(array3[num4]) >= 800L)
				{
					array7[num4] = num14;
					array6[num4] = num13;
					array3[num4] = Class11.smethod_22();
					while (flag2 = Class53.smethod_17(gStruct, gStruct2.string_0))
					{
						num5 = 5;
						for (int num22 = 0; num22 < 300; num22++)
						{
							if (Class20.smethod_30(gStruct.uint_6 + Class47.gstruct43_168.uint_0, gStruct.int_130) != 0)
							{
								break;
							}
							Thread.Sleep(1);
						}
						num23 = 0;
						if (Class39.smethod_5(gStruct, FormMain.int_12.ToString(), bool_0: true) <= 0)
						{
							int num27 = Class69.smethod_2(gStruct);
							if (num27 > num21)
							{
								flag2 = false;
								break;
							}
							if (num26 == 0)
							{
								num26++;
								continue;
							}
							num23 = Class53.smethod_27(gStruct, gStruct2.string_0, FormMain.int_12, bool_0: true);
							if (num23 <= 0)
							{
								break;
							}
						}
						num24 = 0;
						while (flag3 && num24 < 10)
						{
							Thread.Sleep(100);
							if (!Class76.smethod_0(gStruct))
							{
								num24++;
								continue;
							}
							for (int k = 0; k < gStruct2.int_8.Length; k++)
							{
								int num28 = gStruct2.int_8[k] - 1;
								if (0 <= num28)
								{
									Class76.smethod_6(gStruct, num28);
									Thread.Sleep(300);
								}
							}
							break;
						}
						break;
					}
				}
			}
			else
			{
				array3[num4] = Class11.smethod_22();
			}
			goto IL_0a18;
			IL_0810:
			flag2 = false;
			goto IL_0882;
			IL_083a:
			while (flag3 && num24 < 10)
			{
				Thread.Sleep(100);
				if (!Class76.smethod_0(gStruct))
				{
					num24++;
					continue;
				}
				for (int k = 0; k < gStruct2.int_8.Length; k++)
				{
					int num28 = gStruct2.int_8[k] - 1;
					if (0 <= num28)
					{
						Class76.smethod_6(gStruct, num28);
						Thread.Sleep(300);
					}
				}
				break;
			}
			goto IL_0882;
			IL_0615:
			num24 = 0;
			while (flag3 && num24 < 10)
			{
				Thread.Sleep(100);
				if (!Class76.smethod_0(gStruct))
				{
					num24++;
					continue;
				}
				for (int k = 0; k < gStruct2.int_8.Length; k++)
				{
					int num28 = gStruct2.int_8[k] - 1;
					if (0 <= num28)
					{
						Class76.smethod_6(gStruct, num28);
						Thread.Sleep(300);
					}
				}
				break;
			}
			array5[num4] = Class69.smethod_2(gStruct);
			goto IL_06f3;
			IL_060d:
			flag2 = false;
			goto IL_06f3;
		}
	}

	public static void smethod_21()
	{
		int int_ = int_8;
		int_8 = 0;
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
						FormMain.gstruct42_0[num].bool_50 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_50)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_50 = true;
					flag = true;
				}
				smethod_22(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_22(int int_9)
	{
		byte[] array = new byte[60];
		byte[] array2 = new byte[4];
		int int_10 = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		long long_ = 0L;
		GStruct42 gStruct = default(GStruct42);
		while (true)
		{
			IL_07e4:
			num--;
			Thread.Sleep(200);
			if (Class11.bool_0)
			{
				break;
			}
			if (num <= 0)
			{
				num2 = Class71.smethod_3(FormMain.gstruct42_0, int_9);
				if (num2 < 0 || !FormMain.gstruct42_0[num2].bool_36)
				{
					break;
				}
				num = 6;
			}
			num4 = FormMain.gstruct42_0[num2].int_75[4];
			FormMain.gstruct42_0[num2].int_75[4] = 0;
			gStruct = FormMain.gstruct42_0[num2];
			if (gStruct.string_12 == null || gStruct.string_12 == string.Empty)
			{
				continue;
			}
			int num5 = Class69.smethod_2(gStruct);
			if (gStruct.int_75[1] > 0)
			{
				if (num4 <= 0)
				{
					continue;
				}
			}
			else
			{
				if (gStruct.int_75[0] <= 0)
				{
					Thread.Sleep(300);
					continue;
				}
				if (Class11.smethod_23(long_) < 600L || (num3 == num5 && Class11.smethod_23(long_) < 3000L))
				{
					continue;
				}
				num4 = 1;
			}
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array2, 4, ref int_10);
			uint num6 = BitConverter.ToUInt32(array2, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num6 + Class47.gstruct43_13.uint_0, array2, 4, ref int_10);
			uint num7 = BitConverter.ToUInt32(array2, 0) * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array2, 4, ref int_10);
			uint num8 = BitConverter.ToUInt32(array2, 0);
			uint num9 = num8 + num7;
			Class20.ReadProcessMemory(gStruct.int_130, num9 + Class47.gstruct43_43.uint_0, array2, 4, ref int_10);
			if (BitConverter.ToInt32(array2, 0) <= 0 && gStruct.int_75[0] > 0 && gStruct.int_75[1] <= 0)
			{
				continue;
			}
			int num10 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
			string string_ = gStruct.string_12;
			int num11 = gStruct.int_75[2];
			int num12 = gStruct.int_75[3];
			if (num12 <= 0)
			{
				num12 = 1;
			}
			if (gStruct.int_75[0] <= 0)
			{
				num11 = num12;
			}
			uint num13 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130) + Class47.gstruct43_94.uint_0;
			uint num14 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gStruct.int_130);
			uint[,] array3 = new uint[num5, 3];
			int num15 = 0;
			int num16 = 0;
			int num17 = 0;
			uint num18 = 1u;
			while (true)
			{
				if (num18 < Class47.int_1)
				{
					int num19 = (int)Class20.smethod_30(num9 + Class47.gstruct43_55.uint_0, gStruct.int_130);
					int num20 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
					int num21 = Class73.smethod_40(gStruct);
					if (num19 == 0 || num19 == 10 || num19 == 21 || num21 <= 1 || num20 != num10)
					{
						break;
					}
					if (num18 % 50u == 0)
					{
						Thread.Sleep(30);
					}
					if (num5 > num17)
					{
						uint num22 = num14 + num18 * Class47.gstruct43_103.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_10);
						if (BitConverter.ToInt32(array2, 0) != 0)
						{
							goto IL_04c8;
						}
						uint num23 = Class69.smethod_0(gStruct, num18);
						if ((int)num23 <= 0)
						{
							goto IL_04c8;
						}
						num17++;
						uint uint_ = num22 + Class47.gstruct43_104.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, uint_, array2, 1, ref int_10);
						if (array2[0] != string_[0] || (int)Class20.smethod_30(num22 + Class47.gstruct43_105.uint_0, gStruct.int_130) <= 0)
						{
							goto IL_04c8;
						}
						uint num24 = Class20.smethod_30(num13 + num23 * 20 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
						if (num24 != 23 && num24 != 3 && num24 != 1)
						{
							goto IL_04c8;
						}
						Class20.ReadProcessMemory(gStruct.int_130, uint_, array, array.Length, ref int_10);
						string a = Class10.smethod_3(array);
						if (a != string_)
						{
							goto IL_04c8;
						}
						if (num4 >= 2)
						{
							if (num24 != 23)
							{
								array3[num16, 0] = num24;
								array3[num16, 1] = num18;
								array3[num16, 2] = num23;
								num16++;
							}
							goto IL_04c8;
						}
						if (num24 == 3)
						{
							if (num11 > num15)
							{
								num15++;
								goto IL_04c8;
							}
							goto IL_07c8;
						}
						array3[num16, 0] = num24;
						array3[num16, 1] = num18;
						array3[num16, 2] = num23;
						num16++;
						goto IL_04c8;
					}
				}
				uint num25 = 23u;
				int num26 = num16;
				if (num4 < 2)
				{
					num25 = 3u;
					num26 = num12 - num15;
					if (num26 > num16)
					{
						num26 = num16;
					}
				}
				if (num26 > 0 && num16 > 0)
				{
					for (int i = 0; i < num16; i++)
					{
						int num19 = (int)Class20.smethod_30(num9 + Class47.gstruct43_55.uint_0, gStruct.int_130);
						int num20 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
						int num21 = Class73.smethod_40(gStruct);
						if (num19 == 0 || num19 == 10 || num19 == 21 || num21 <= 1 || num20 != num10)
						{
							goto IL_07e4;
						}
						if (num26 <= 0)
						{
							break;
						}
						uint num27 = array3[i, 1];
						uint num23 = array3[i, 2];
						uint num22 = num14 + num27 * Class47.gstruct43_103.uint_0;
						uint num28 = num13 + num23 * 20;
						Class20.ReadProcessMemory(gStruct.int_130, num28 + Class47.gstruct43_97.uint_0 - 4, array2, 4, ref int_10);
						uint uint_2 = BitConverter.ToUInt32(array2, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num28 + Class47.gstruct43_97.uint_0, array2, 4, ref int_10);
						uint uint_3 = BitConverter.ToUInt32(array2, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_108.uint_0, array2, 4, ref int_10);
						uint uint_4 = BitConverter.ToUInt32(array2, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num22 + Class47.gstruct43_109.uint_0, array2, 4, ref int_10);
						uint uint_5 = BitConverter.ToUInt32(array2, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num13 + num23 * 20 + Class47.gstruct43_97.uint_0 - 8, array2, 4, ref int_10);
						uint num24 = BitConverter.ToUInt32(array2, 0);
						if (num24 == num25)
						{
							num26--;
							continue;
						}
						uint[] array4 = Class69.smethod_22(gStruct, num25, uint_4, uint_5);
						if (array4 == null)
						{
							break;
						}
						uint num29 = num24;
						uint num30;
						for (int j = 0; j < 1000; j++)
						{
							if (num29 == 1)
							{
								num29 = num25;
								uint_2 = array4[0];
								uint_3 = array4[1];
							}
							if (j % 100 == 0)
							{
								Class20.ReadProcessMemory(gStruct.int_130, num13 + num23 * 20 + Class47.gstruct43_97.uint_0 - 8, array2, 4, ref int_10);
								num30 = BitConverter.ToUInt32(array2, 0);
								if (num30 != num29)
								{
									goto IL_07a6;
								}
								Class60.smethod_44(gStruct, uint_2, uint_3, num29, array4[0], array4[1], num25);
							}
							Class20.ReadProcessMemory(gStruct.int_130, num13 + num23 * 20 + Class47.gstruct43_97.uint_0 - 8, array2, 4, ref int_10);
							uint num31 = BitConverter.ToUInt32(array2, 0);
							if (num31 == num25 || num31 != num24)
							{
								break;
							}
							num29 = num31;
							Thread.Sleep(1);
						}
						goto IL_07b1;
						IL_07b1:
						num26--;
						continue;
						IL_07a6:
						if (num30 != num25)
						{
							break;
						}
						goto IL_07b1;
					}
				}
				goto IL_07c8;
				IL_04c8:
				num18++;
				continue;
				IL_07c8:
				long_ = Class11.smethod_22();
				num3 = Class69.smethod_2(gStruct);
				break;
			}
		}
	}
}
