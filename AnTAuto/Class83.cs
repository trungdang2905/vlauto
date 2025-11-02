using System;
using System.Threading;

internal class Class83
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
						FormMain.gstruct42_0[num].bool_45 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_45)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_45 = true;
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
		GStruct42 gStruct = default(GStruct42);
		int num = 0;
		int int_2 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[48];
		while (true)
		{
			Thread.Sleep(800);
			int num2 = Class71.smethod_3(FormMain.gstruct42_0, int_1);
			if (Class11.bool_0 || num2 < 0 || !FormMain.gstruct42_0[num2].bool_36)
			{
				break;
			}
			num++;
			if (num < 10 || FormMain.gstruct42_0[num2].int_118[0] == 0)
			{
				continue;
			}
			try
			{
				gStruct = FormMain.gstruct42_0[num2];
			}
			catch
			{
				continue;
			}
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_2);
			uint num3 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num3 + Class47.gstruct43_13.uint_0, array, 4, ref int_2);
			uint num4 = BitConverter.ToUInt32(array, 0);
			uint num5 = num4 * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_2);
			uint num6 = BitConverter.ToUInt32(array, 0);
			uint num7 = num6 + num5;
			Class20.ReadProcessMemory(gStruct.int_130, num7 + Class47.gstruct43_55.uint_0, array, 4, ref int_2);
			int num8 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num7 + Class47.gstruct43_50.uint_0, array, 4, ref int_2);
			int num9 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_2);
			int num10 = BitConverter.ToInt32(array, 0);
			int num11 = Class73.smethod_40(gStruct);
			if (num9 <= 0 || num10 <= 0 || num8 <= 0 || num11 <= 1)
			{
				continue;
			}
			num = 0;
			if (num10 == 962 || num10 == 963 || (849 <= num10 && num10 <= 862) || (464 <= num10 && num10 <= 471) || (480 <= num10 && num10 <= 495))
			{
				continue;
			}
			int[] array3 = Class50.smethod_0(num10);
			if (array3 != null && Class50.smethod_2(num10) < 0)
			{
				Thread.Sleep(800);
				continue;
			}
			string text = Class23.smethod_3(gStruct);
			GStruct48 gStruct2 = Class72.smethod_5(gStruct);
			if (gStruct.int_118[4] > 0)
			{
				byte[] array4 = new byte[1];
				if (gStruct2.int_0 <= 0)
				{
					if (text != string.Empty)
					{
						array4 = Class11.smethod_41(text);
					}
				}
				else
				{
					array4 = Class11.smethod_41("PT(" + gStruct2.int_0 + ")-" + gStruct2.string_0);
				}
				Class20.WriteProcessMemory(gStruct.int_130, num7 + Class47.gstruct43_86.uint_0, array4, array4.Length, ref int_2);
			}
			if (gStruct.int_118[1] != 0)
			{
				if ((463 < num10 && num10 < 472) || (479 < num10 && num10 < 496))
				{
					Thread.Sleep(800);
					continue;
				}
				if (gStruct2.int_0 == 0)
				{
					Class72.smethod_1(gStruct);
				}
				else if (gStruct2.string_0 != gStruct.string_20)
				{
					Class72.smethod_2(gStruct);
					Thread.Sleep(600);
					Class72.smethod_1(gStruct);
				}
				else
				{
					int num12 = (int)Class20.smethod_30(num3 + Class47.gstruct43_23.uint_0, gStruct.int_130);
					if ((4 <= gStruct2.int_0 && num12 < 6) || (5 <= gStruct2.int_0 && num12 < 12) || (6 <= gStruct2.int_0 && num12 < 19) || (7 <= gStruct2.int_0 && num12 < 19) || 8 <= gStruct2.int_0)
					{
						continue;
					}
				}
				uint uint_ = gStruct.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
				Class20.ReadProcessMemory(gStruct.int_130, uint_, array, 4, ref int_2);
				int num13 = BitConverter.ToInt32(array, 0);
				if (num13 <= 1)
				{
					continue;
				}
				int num14 = 0;
				string[] string_ = null;
				for (uint num15 = 1u; num15 < 256; num15++)
				{
					if (num15 % 60u == 0)
					{
						Thread.Sleep(100);
					}
					if (num13 <= num14)
					{
						break;
					}
					string text2;
					if (num15 != num4)
					{
						uint num16 = num6 + num15 * Class47.gstruct43_15.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, num16 + Class47.gstruct43_16.uint_0, array, 4, ref int_2);
						if (array[0] == 0)
						{
							continue;
						}
						num14++;
						Class20.ReadProcessMemory(gStruct.int_130, num16 + Class47.gstruct43_50.uint_0, array, 4, ref int_2);
						if (BitConverter.ToInt32(array, 0) <= 0 || Class20.smethod_30(num16 + Class47.gstruct43_52.uint_0, gStruct.int_130) != 1)
						{
							continue;
						}
						Class20.ReadProcessMemory(gStruct.int_130, num16 + Class47.gstruct43_16.uint_0, array2, array2.Length, ref int_2);
						text2 = Class10.smethod_3(array2);
						if (text2.Length < 5)
						{
							continue;
						}
						if (gStruct2.gstruct47_0 != null)
						{
							bool flag = false;
							for (int i = 1; i < gStruct2.gstruct47_0.Length; i++)
							{
								if (text2 == gStruct2.gstruct47_0[i].string_0)
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
						if (gStruct.int_118[2] > 0 && gStruct.string_17 != null)
						{
							int i = 0;
							while (i < gStruct.string_17.Length)
							{
								if (!(text2 == gStruct.string_17[i]))
								{
									i++;
									continue;
								}
								goto IL_05e8;
							}
						}
						if (gStruct.int_118[3] > 0 && text != string.Empty)
						{
							Class20.ReadProcessMemory(gStruct.int_130, num16 + Class47.gstruct43_86.uint_0, array2, array2.Length, ref int_2);
							string string_2 = Class10.smethod_3(array2);
							if (0 <= Class11.smethod_2(string_2, text))
							{
								goto IL_074c;
							}
						}
						if (gStruct.int_118[2] > 0 || gStruct.int_118[3] > 0)
						{
							continue;
						}
						uint[] uint_2 = new uint[2]
						{
							Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
							Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
						};
						uint[] uint_3 = new uint[2]
						{
							Class20.smethod_30(num16 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
							Class20.smethod_30(num16 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
						};
						long num17 = Class53.smethod_18(uint_2, uint_3);
						if (num17 > 500000L)
						{
							continue;
						}
						goto IL_074c;
					}
					num14++;
					continue;
					IL_074c:
					Class60.smethod_55(gStruct, "InviteTeam('" + text2 + "')");
					Thread.Sleep(300);
					continue;
					IL_05e8:
					Class11.smethod_24(ref string_, text2);
					goto IL_074c;
				}
				if (string_ != null)
				{
					for (int j = 0; j < string_.Length; j++)
					{
						Class60.smethod_55(gStruct, "InviteTeam('" + string_[j] + "')");
						Thread.Sleep(600);
					}
				}
				continue;
			}
			string text3 = Class46.smethod_2(gStruct, bool_0: true);
			if (text3 == string.Empty)
			{
				continue;
			}
			if (gStruct2.int_0 != 0)
			{
				if (gStruct2.int_0 > 1)
				{
					if (gStruct.int_118[2] > 0 && gStruct.string_17 != null)
					{
						int i = 0;
						while (i < gStruct.string_17.Length)
						{
							if (!(gStruct2.string_0 == gStruct.string_17[i]))
							{
								i++;
								continue;
							}
							goto IL_09ff;
						}
					}
				}
				else
				{
					Class72.smethod_2(gStruct);
					Thread.Sleep(600);
				}
			}
			if (Class11.smethod_2(text3, "mêi tæ") > 0)
			{
				string[] array5 = text3.Split('|');
				string text4 = null;
				int i = 0;
				while (i < array5.Length)
				{
					if (Class11.smethod_2(array5[i], "mêi tæ") <= 0)
					{
						i++;
						continue;
					}
					if (gStruct.int_118[2] > 0 && gStruct.string_17 != null)
					{
						int num18 = 0;
						while (num18 < gStruct.string_17.Length)
						{
							if (Class11.smethod_2(array5[i], gStruct.string_17[num18]) <= 0)
							{
								num18++;
								continue;
							}
							goto IL_091f;
						}
						break;
					}
					text4 = array5[i];
					goto IL_092f;
					IL_092f:
					if (text4 == null)
					{
						break;
					}
					string[] array6 = text4.Split(';');
					if (array6.Length != 2 || (gStruct2.string_0 != null && Class11.smethod_2(array6[1], gStruct2.string_0 + " ") == 0))
					{
						break;
					}
					uint num19 = Class11.smethod_13(array6[0]);
					if (num19 != 0)
					{
						Class20.smethod_31(gStruct.uint_50 + 2, gStruct.int_130, num19);
						Class20.smethod_31(gStruct.uint_50 + 7, gStruct.int_130, 1u, 1);
						for (int num18 = 0; num18 < 3; num18++)
						{
							Class60.smethod_12(gStruct.int_130, gStruct.uint_50);
							Thread.Sleep(999);
						}
					}
					break;
					IL_091f:
					text4 = array5[i];
					goto IL_092f;
				}
			}
			goto IL_09ff;
			IL_09ff:
			if (text3 == null || Class11.smethod_2(text3, "giao dÞch") >= 0)
			{
				continue;
			}
			uint num20 = Class20.smethod_30(Class47.gstruct43_161.uint_0, gStruct.int_130);
			uint num21 = Class20.smethod_30(num20 + Class47.gstruct43_163.uint_0, gStruct.int_130);
			if (num21 == 0)
			{
				continue;
			}
			uint num22 = Class20.smethod_30(num21, gStruct.int_130);
			if (num22 != 0)
			{
				string text5 = Class20.smethod_28(num22, gStruct.int_130, 78);
				if (text5 != null && !(text5 == string.Empty))
				{
					Class60.smethod_12(gStruct.int_130, gStruct.uint_51);
				}
			}
		}
	}
}
