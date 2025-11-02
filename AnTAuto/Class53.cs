using System;
using System.Threading;

internal class Class53
{
	public static string[,] string_0 = new string[8, 3]
	{
		{
			"T­¬ng D­¬ng",
			"Ba L\u00a8ng huyÖn",
			"Nam Nh¹c trÊn"
		},
		{
			"D­¬ng Ch©u",
			"§¹o H­¬ng th«n",
			null
		},
		{
			"Ph­îng T­êng",
			"Long M«n trÊn",
			null
		},
		{
			"Ph­îng T­êng",
			"VÜnh L¹c trÊn",
			null
		},
		{
			"§¹i L",
			"Th¹ch Cæ trÊn",
			null
		},
		{
			"Thµnh §«",
			"Giang T©n Th«n",
			null
		},
		{
			"L©m An",
			"Long TuyÒn th«n",
			null
		},
		{
			"BiÖn Kinh",
			"Chu Tiªn trÊn",
			null
		}
	};

	public static int[,] int_0 = new int[8, 3]
	{
		{
			78,
			53,
			54
		},
		{
			80,
			101,
			0
		},
		{
			1,
			121,
			0
		},
		{
			1,
			99,
			0
		},
		{
			162,
			153,
			0
		},
		{
			11,
			20,
			0
		},
		{
			176,
			174,
			0
		},
		{
			37,
			100,
			0
		}
	};

	public static void smethod_0(GStruct42 gstruct42_0, uint[] uint_0, uint[] uint_1, int int_1 = 1000)
	{
		if (!Class11.smethod_57(uint_0) || !Class11.smethod_57(uint_1))
		{
			return;
		}
		int num = 90;
		num = ((uint_1[0] >= uint_0[0]) ? 45 : 210);
		double num2 = (double)Math.Abs(num) * 3.14 / 180.0;
		uint[] uint_2 = new uint[2]
		{
			(uint)((double)uint_0[0] + 400.0 * Math.Cos(num2)),
			(uint)((double)uint_0[1] - 400.0 * Math.Sin(num2))
		};
		uint[] uint_3 = smethod_3(uint_0, uint_2, 150);
		int num3 = new Random().Next(100, 200);
		uint_1[0] += (uint)num3;
		uint_1[1] += (uint)num3;
		uint_3 = smethod_3(uint_1, uint_3, int_1);
		uint num4 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num5 = Class20.smethod_30(num4 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num6 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num7 = num6 + num5 * Class47.gstruct43_15.uint_0;
		int int_2 = 0;
		int int_3 = gstruct42_0.int_130;
		uint uint_4 = num7 + Class47.gstruct43_72.uint_0;
		byte[] byte_ = new byte[4];
		Class20.WriteProcessMemory(int_3, uint_4, byte_, 4, ref int_2);
		Class12.smethod_1(gstruct42_0, uint_3);
		int num8 = 0;
		int num9 = 0;
		while (num8 < 3 && num9 < 50)
		{
			int num10 = Class73.smethod_40(gstruct42_0);
			int num11 = (int)Class20.smethod_30(num7 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			if (num11 == 1 || num10 <= 1)
			{
				num8++;
			}
			Thread.Sleep(100);
			num9++;
		}
	}

	public static void smethod_1(GStruct42 gstruct42_0, ref bool bool_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = num + Class47.gstruct43_12.uint_0 + Class47.gstruct43_75.uint_0;
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_73.uint_0, gstruct42_0.int_130);
		if (num3 >= gstruct42_0.int_67)
		{
			if (gstruct42_0.int_67 < num3)
			{
				Class60.smethod_36(gstruct42_0, (uint)((int)num3 - gstruct42_0.int_67));
			}
			return;
		}
		if (!bool_0 && gstruct42_0.string_13 != null && gstruct42_0.string_13 != string.Empty)
		{
			uint num4 = Class11.smethod_13(gstruct42_0.string_13);
			if (num4 != 0)
			{
				Class60.smethod_113(gstruct42_0, num4);
				bool_0 = true;
				Thread.Sleep(300);
			}
		}
		uint num5 = (uint)(gstruct42_0.int_67 - (int)num3);
		uint num6 = Class20.smethod_30(num2 + Class47.gstruct43_74.uint_0, gstruct42_0.int_130);
		if (num6 != 0)
		{
			if (num6 < num5)
			{
				num5 = num6;
			}
			Class60.smethod_35(gstruct42_0, num5);
		}
	}

	public static void smethod_2(GStruct42 gstruct42_0, uint uint_0, int int_1 = 180)
	{
		int num = 0;
		int num2 = 0;
		while (num < int_1)
		{
			num++;
			Thread.Sleep(1);
			uint num3 = Class20.smethod_30(uint_0 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			if (num3 == 3)
			{
				num2 = 1;
			}
			else if (num2 > 0 || num > 50)
			{
				break;
			}
		}
	}

	public static uint[] smethod_3(uint[] uint_0, uint[] uint_1, int int_1 = 350)
	{
		if (uint_0 != null && uint_1 != null)
		{
			long num = uint_0[0];
			long num2 = uint_0[1];
			long num3 = uint_1[0];
			long num4 = uint_1[1];
			if (num3 == num)
			{
				if (num3 == 0L)
				{
					return null;
				}
				num3++;
			}
			long num5 = num3 - num;
			long num6 = num4 - num2;
			short num7 = (short)((num3 - num) / Math.Abs(num3 - num));
			double num8 = 0.0;
			double num9 = 0.0;
			if (0 > int_1)
			{
				num8 = (double)num7 * Math.Sqrt(int_1 * int_1 / (1L + num6 / num5 * (num6 / num5))) + (double)num;
				num9 = (double)num2 + (double)(num6 / num5) * (num8 - (double)num);
			}
			else
			{
				num8 = (double)num7 * Math.Sqrt(int_1 * int_1 / (1L + num6 / num5 * (num6 / num5))) + (double)num3;
				num9 = (double)num4 + (double)(num6 / num5) * (num8 - (double)num3);
			}
			return new uint[2]
			{
				(uint)num8,
				(uint)num9
			};
		}
		return null;
	}

	public static uint[] smethod_4(uint[] uint_0, uint[] uint_1, int int_1)
	{
		long num = Class32.smethod_0(uint_0, uint_1);
		if (int_1 > 0 && num > int_1 * int_1)
		{
			int num2 = (int)(Math.Sqrt(num) - (double)int_1);
			return smethod_3(uint_0, uint_1, -num2);
		}
		return null;
	}

	public static int smethod_5(int int_1, int int_2, ref GStruct22 gstruct22_0)
	{
		int[] int_3 = null;
		int[] int_4 = null;
		while (true)
		{
			Class11.smethod_32(ref int_4, int_2);
			for (int i = 0; i < Class37.gstruct22_0.Length; i++)
			{
				if (Class37.gstruct22_0[i].int_1 != int_2)
				{
					continue;
				}
				if (Class37.gstruct22_0[i].int_0 != int_1)
				{
					if (smethod_7(Class37.gstruct22_0[i].int_0) == null)
					{
						bool flag = false;
						if (int_4 != null)
						{
							for (int j = 0; j < int_4.Length; j++)
							{
								if (int_4[j] == Class37.gstruct22_0[i].int_0)
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							Class11.smethod_32(ref int_3, Class37.gstruct22_0[i].int_0);
						}
						continue;
					}
					return Class37.gstruct22_0[i].int_0;
				}
				gstruct22_0 = Class37.smethod_3(int_1, int_2);
				return 0;
			}
			if (int_3 == null || int_3.Length <= 0)
			{
				break;
			}
			int_2 = int_3[0];
			Class11.smethod_33(ref int_3, int_2);
		}
		return -1;
	}

	public static void smethod_6(uint[,] uint_0, int int_1, ref uint[] uint_1, ref uint[] uint_2, ref int int_2)
	{
		uint_1 = null;
		uint_2 = null;
		int_2 = -1;
		if (uint_0 != null && int_1 < uint_0.GetLength(0) && uint_0.GetLength(1) > 2)
		{
			uint_1 = new uint[2]
			{
				uint_0[int_1, 0],
				uint_0[int_1, 1]
			};
			int_2 = (int)uint_0[int_1, 2];
			if (uint_0.GetLength(1) > 4)
			{
				uint_2 = new uint[2]
				{
					uint_0[int_1, 3],
					uint_0[int_1, 4]
				};
			}
		}
	}

	public static int[] smethod_7(object object_0)
	{
		if (object_0 != null)
		{
			string text = object_0.ToString();
			if (!(text == string.Empty))
			{
				if (Class11.smethod_2(object_0.GetType().ToString().ToUpper(), "STRING") < 0)
				{
					int num = Class11.smethod_12(text);
					if (num > 0)
					{
						for (int i = 0; i < int_0.GetLength(0); i++)
						{
							for (int j = 0; j < int_0.GetLength(1); j++)
							{
								if (num == int_0[i, j])
								{
									return new int[2]
									{
										i,
										j
									};
								}
							}
						}
					}
					return null;
				}
				int length = string_0.GetLength(0);
				int length2 = string_0.GetLength(1);
				for (int i = 0; i < length; i++)
				{
					for (int j = 0; j < length2; j++)
					{
						string text2 = string_0[i, j];
						if (text2 != null && !(text2 == string.Empty))
						{
							if (Class11.smethod_2(text2, text) == 0 || Class11.smethod_2(text, text2) == 0)
							{
								return new int[2]
								{
									i,
									j
								};
							}
							string text3 = Class10.smethod_1(text, 1);
							string text4 = Class10.smethod_1(text2, 1);
							if (Class11.smethod_2(text3, text4) == 0 || Class11.smethod_2(text4, text3) == 0)
							{
								return new int[2]
								{
									i,
									j
								};
							}
						}
					}
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public static int smethod_8(GStruct42 gstruct42_0, string string_1)
	{
		if (Class60.smethod_1(gstruct42_0, Class60.uint_11) >= 15)
		{
			Class60.smethod_0(gstruct42_0, Class60.uint_11);
			Class60.smethod_50(gstruct42_0, string_1);
			return 1;
		}
		return 0;
	}

	public static int smethod_9(GStruct42 gstruct42_0, int int_1 = 15000)
	{
		long long_ = Class11.smethod_22();
		while (!Class11.bool_0 && Class11.smethod_23(long_) < int_1)
		{
			Thread.Sleep(100);
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
			uint num3 = num2 * Class47.gstruct43_15.uint_0;
			uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num5 = num4 + num3;
			uint num6 = Class20.smethod_30(num5 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
			uint num7 = Class20.smethod_30(num5 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			uint num8 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
			int num9 = Class73.smethod_40(gstruct42_0);
			if (num6 != 0 && num9 > 1 && num8 != 0 && num7 != 0)
			{
				return 1;
			}
		}
		return 0;
	}

	public static int smethod_10(GStruct42 gstruct42_0, bool bool_0 = true)
	{
		if (Class60.smethod_1(gstruct42_0, Class60.uint_9) >= 5 && Class60.smethod_7(gstruct42_0))
		{
			Class60.smethod_0(gstruct42_0, Class60.uint_9);
			if (Class39.smethod_9(gstruct42_0))
			{
				Class39.smethod_12(gstruct42_0);
			}
			if (Class76.Class79.smethod_4(gstruct42_0))
			{
				Class76.Class79.smethod_5(gstruct42_0);
			}
			if (Class76.smethod_0(gstruct42_0))
			{
				Class76.smethod_9(gstruct42_0);
			}
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
			uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num4 = num3 + num2;
			int int_ = 0;
			byte[] array = new byte[4];
			byte[] byte_ = array;
			Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
			int num5 = (int)Class20.smethod_30(num4 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130);
			if (bool_0 && num5 > 0)
			{
				Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
				Thread.Sleep(600);
			}
			if (num5 == 0)
			{
				Class60.smethod_55(gstruct42_0, "Switch([[sit]])");
				Thread.Sleep(600);
			}
			uint[] array2 = new uint[2]
			{
				Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
			if (Class60.smethod_3(gstruct42_0, Class60.uint_10) <= 0)
			{
				array2[0] += 100u;
				array2[1] += 100u;
				Class60.smethod_2(gstruct42_0, Class60.uint_10, 1, 4);
			}
			else
			{
				array2[0] -= 100u;
				array2[1] -= 100u;
				Class60.smethod_2(gstruct42_0, Class60.uint_10, 0, 4);
			}
			Class60.smethod_61(gstruct42_0, array2);
			Thread.Sleep(500);
			uint[] array3 = new uint[2]
			{
				Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
			long num6 = smethod_18(array2, array3);
			if ((array2[0] == array3[0] && array2[1] == array3[1]) || num6 < 11500L)
			{
				smethod_11(gstruct42_0);
			}
			return (int)(1 + Class20.smethod_30(num4 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130));
		}
		return 0;
	}

	public static void smethod_11(GStruct42 gstruct42_0)
	{
		uint num = 0u;
		if (Class60.smethod_3(gstruct42_0, Class60.uint_10) <= 0)
		{
			num = 24904160u;
			Class60.smethod_2(gstruct42_0, Class60.uint_10, 1, 4);
		}
		else
		{
			num = 13107500u;
			Class60.smethod_2(gstruct42_0, Class60.uint_10, 0, 4);
		}
		Class73.smethod_15(gstruct42_0.uint_4, num);
		Thread.Sleep(800);
		num = 19661200u;
		Class73.smethod_15(gstruct42_0.uint_4, 19661200u);
		Thread.Sleep(300);
		Class73.smethod_14(gstruct42_0);
	}

	public static GStruct28[] smethod_12(GStruct42 gstruct42_0, GStruct46[] gstruct46_0, int int_1, int int_2, bool bool_0 = true)
	{
		GStruct28[] array = Class69.smethod_39(gstruct42_0, gstruct46_0, int_1, int_2);
		if (array == null)
		{
			return null;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		int int_3 = 0;
		byte[] array2 = new byte[4];
		bool flag = false;
		Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_43.uint_0, array2, 4, ref int_3);
		int num5 = BitConverter.ToInt32(array2, 0);
		if (bool_0 || num5 > 0)
		{
			Class73.smethod_4(gstruct42_0);
			Thread.Sleep(600);
			Class60.smethod_26(gstruct42_0);
		}
		string text = string.Empty;
		string text2 = string.Empty;
		uint num6 = 0u;
		int num7 = -1;
		int num8 = 0;
		int num9 = 0;
		int int_4 = 7;
		while (true)
		{
			IL_068e:
			num7++;
			bool flag2 = false;
			if (array.Length > num7)
			{
				if (array[num7].int_4 != 1 && array[num7].int_4 != 4)
				{
					num9 = Class60.smethod_21(gstruct42_0, array[num7].int_0);
					if (num9 > 0)
					{
						num6 = Class32.smethod_42(gstruct42_0);
						if (num8 == 0)
						{
							object obj = text;
							text = string.Concat(obj, '\r', Class11.smethod_55(array[num7].int_2 + "/" + array[num7].int_3, int_4), "|", Class11.smethod_55(num9, int_4), "|", array[num7].string_0);
						}
						if (num9 > num6 && !(flag2 = (num5 > 0 || flag)))
						{
							uint num10 = Class32.smethod_42(gstruct42_0, bool_0: true);
							flag2 = (num10 < num9 - (int)num6);
							if (num10 != 0)
							{
								Class60.smethod_35(gstruct42_0, num10);
								Thread.Sleep(300);
								flag = true;
							}
						}
						Class60.smethod_19(gstruct42_0, array[num7].int_0);
						Thread.Sleep(150);
						if (!flag2)
						{
							continue;
						}
						goto IL_073b;
					}
				}
				if (array[num7].int_4 == 4 && (FormMain.int_58 <= 0 || array[num7].int_5 > 5))
				{
					if (num8 == 0)
					{
						object obj = text;
						text = string.Concat(obj, '\r', Class11.smethod_55(array[num7].int_2 + "/" + array[num7].int_3, int_4), "|", Class11.smethod_55("Bá qua", int_4), "|", array[num7].string_0);
					}
					continue;
				}
				if (Class76.Class79.smethod_4(gstruct42_0))
				{
					Class76.Class79.smethod_5(gstruct42_0);
				}
				Class76.smethod_9(gstruct42_0);
				Class60.smethod_19(gstruct42_0, array[num7].int_0);
				Thread.Sleep(100);
				int num11 = 0;
				int num12 = 0;
				int num13 = 0;
				while (num13 <= 0)
				{
					if (Class76.smethod_0(gstruct42_0))
					{
						num12 = Class76.smethod_1(gstruct42_0);
						num13 = Class76.smethod_2(gstruct42_0, num12);
					}
					num11++;
					Thread.Sleep(10);
					if (num11 <= 80)
					{
						continue;
					}
					goto IL_068e;
				}
				int num14 = -1;
				string text3 = null;
				for (int i = 0; i < num13; i++)
				{
					string text4 = Class76.smethod_3(gstruct42_0, i, num12);
					string string_ = text4.ToLower();
					if (Class11.smethod_2(string_, "Söa".ToLower()) >= 0)
					{
						num14 = i;
						text3 = text4;
						if (0 <= Class11.smethod_2(string_, "kü".ToLower()))
						{
							break;
						}
					}
				}
				if (num14 < 0)
				{
					continue;
				}
				string text5 = null;
				string text6 = null;
				int num15 = 0;
				int num16 = 0;
				for (int j = 0; j < text3.Length; j++)
				{
					bool flag3 = '0' <= text3[j] && text3[j] <= '9';
					if (num15 == 0 && flag3)
					{
						num15 = 1;
					}
					else if (num15 == 1 && !flag3)
					{
						num15 = 2;
					}
					if (num15 == 1)
					{
						text5 += text3[j];
					}
					if (num15 == 2)
					{
						if (num16 == 0 && flag3)
						{
							num16 = 1;
						}
						else if (num16 == 1 && !flag3)
						{
							break;
						}
						if (num16 == 1)
						{
							text6 += text3[j];
						}
					}
				}
				num9 = Class11.smethod_12(text5) * 10000 + Class11.smethod_12(text6);
				num6 = Class32.smethod_42(gstruct42_0);
				if (num8 == 0)
				{
					object obj = text;
					text = string.Concat(obj, '\r', Class11.smethod_55(array[num7].int_2 + "/" + array[num7].int_3, int_4), "|", Class11.smethod_55(text5 + "," + text6, int_4), "|", array[num7].string_0);
				}
				if (num9 > num6 && !(flag2 = (num5 > 0 || flag)))
				{
					uint num10 = Class32.smethod_42(gstruct42_0, bool_0: true);
					flag2 = (num10 < num9 - (int)num6);
					if (num10 != 0)
					{
						Class60.smethod_35(gstruct42_0, num10);
						Thread.Sleep(300);
						flag = true;
					}
				}
				Thread.Sleep(100);
				Class76.smethod_6(gstruct42_0, num14);
				for (int k = 0; k < 8; k++)
				{
					Thread.Sleep(80);
					if (!Class76.Class79.smethod_4(gstruct42_0))
					{
						if (!Class76.smethod_0(gstruct42_0))
						{
							break;
						}
						continue;
					}
					Class76.Class79.smethod_5(gstruct42_0);
					break;
				}
				if (!flag2)
				{
					continue;
				}
				goto IL_073b;
			}
			if (num8 != 0)
			{
				break;
			}
			num8++;
			Thread.Sleep(300);
			continue;
			IL_073b:
			while (true)
			{
				num7++;
				if (array.Length <= num7)
				{
					break;
				}
				object obj = text;
				text = string.Concat(obj, '\r', Class11.smethod_55(array[num7].int_2 + "/" + array[num7].int_3, int_4), "|", Class11.smethod_55("...", int_4), "|", array[num7].string_0);
			}
			text2 = " (thiÕu tiÒn söa)";
			break;
		}
		Thread.Sleep(100);
		if (Class76.Class79.smethod_4(gstruct42_0))
		{
			Class76.Class79.smethod_5(gstruct42_0);
		}
		if (Class76.smethod_0(gstruct42_0))
		{
			Class76.smethod_9(gstruct42_0);
		}
		if (text != string.Empty)
		{
			Class60.smethod_50(gstruct42_0, "<bclr=yellow>Söa §å T¹i Chç" + text2 + "<bclr><color=green>" + '\r' + Class11.smethod_55("§é bÒn", int_4) + "|" + Class11.smethod_55("TiÒn", int_4) + "|Tªn trang bÞ<bclr=blue>" + text);
		}
		Thread.Sleep(300);
		if (Class76.Class79.smethod_4(gstruct42_0))
		{
			Class76.Class79.smethod_5(gstruct42_0);
		}
		if (Class76.smethod_0(gstruct42_0))
		{
			Class76.smethod_9(gstruct42_0);
		}
		if (flag)
		{
			Class60.smethod_36(gstruct42_0, Class32.smethod_42(gstruct42_0));
		}
		int num17 = 0;
		GStruct28[] array3 = new GStruct28[array.Length];
		uint num18 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		for (num7 = 0; num7 < array.Length; num7++)
		{
			uint num19 = (uint)(array[num7].int_0 * (int)Class47.gstruct43_103.uint_0 + (int)num18);
			int num20 = (int)Class20.smethod_30(num19 + Class47.gstruct43_116.uint_0, gstruct42_0.int_130);
			if (num20 <= FormMain.int_76 && num20 > 0)
			{
				array3[num17].string_0 = array[num7].string_0;
				array3[num17].int_1 = array[num7].int_1;
				array3[num17].int_0 = array[num7].int_0;
				array3[num17].int_4 = array[num7].int_4;
				array3[num17].int_5 = array[num7].int_5;
				array3[num17].int_3 = array[num7].int_3;
				array3[num17].int_2 = num20;
				num17++;
			}
		}
		if (num17 <= 0)
		{
			return null;
		}
		Array.Resize(ref array3, num17);
		return array3;
	}

	public static bool smethod_13(GStruct42 gstruct42_0, bool bool_0 = true)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_13.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		uint num3 = num2 * Class47.gstruct43_15.uint_0;
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
		uint num4 = BitConverter.ToUInt32(array, 0);
		uint num5 = num4 + num3;
		Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
		if (BitConverter.ToUInt32(array, 0) != 0)
		{
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_);
			int num6 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_);
			int num7 = BitConverter.ToInt32(array, 0);
			int num8 = 0;
			while (!bool_0 && Class31.int_0 > 0 && Class31.bool_0 && num8 < 150 && Class11.smethod_23(Class31.long_0) < 3000L)
			{
				Thread.Sleep(30);
				num8++;
			}
			Class31.bool_0 = true;
			Class31.long_0 = Class11.smethod_22();
			int[] array2 = Class69.smethod_40(gstruct42_0);
			Class31.bool_0 = false;
			if (array2 != null && Class60.smethod_41(gstruct42_0, (uint)array2[0], array2[2], array2[3]))
			{
				int num9 = 0;
				while (!bool_0 && num9 < 30)
				{
					num9++;
					Thread.Sleep(60);
					Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
					num = BitConverter.ToUInt32(array, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_13.uint_0, array, 4, ref int_);
					num2 = BitConverter.ToUInt32(array, 0);
					num3 = num2 * Class47.gstruct43_15.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
					num4 = BitConverter.ToUInt32(array, 0);
					num5 = num4 + num3;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
					if (BitConverter.ToUInt32(array, 0) != 0)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_);
						int num10 = BitConverter.ToInt32(array, 0);
						if (num10 > 0 && num10 != num7)
						{
							break;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
						int num11 = BitConverter.ToInt32(array, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_);
						int num12 = BitConverter.ToInt32(array, 0);
						if (num11 <= 0 && num12 > 0 && num12 != num6)
						{
							break;
						}
					}
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public static int smethod_14(GStruct42 gstruct42_0, string string_1, uint[] uint_0 = null, bool bool_0 = false, bool bool_1 = false, string string_2 = null)
	{
		string[] array = null;
		if (string_1 != string.Empty)
		{
			array = Class11.smethod_4(string_1.Split('|'), bool_1: true, bool_2: true);
		}
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		int int_ = 0;
		int int_2 = 80;
		byte[] array2 = new byte[80];
		int num3 = 0;
		while (true)
		{
			int num4 = 0;
			byte[] array3 = new byte[4];
			int int_3 = 0;
			int num5 = Class69.smethod_2(gstruct42_0);
			int num6 = 0;
			for (uint num7 = 1u; num7 < Class47.int_1 && (0 >= num5 || num5 > num6); num7++)
			{
				uint num8 = num + num7 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_103.uint_0 - 4, array3, 4, ref int_3);
				if (BitConverter.ToInt32(array3, 0) != 0)
				{
					continue;
				}
				uint uint_ = num8 + Class47.gstruct43_104.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array3, 1, ref int_3);
				if (array3[0] == 0)
				{
					continue;
				}
				uint num9 = Class69.smethod_0(gstruct42_0, num7);
				if ((int)num9 <= 0)
				{
					continue;
				}
				num6++;
				int num10 = (int)Class20.smethod_30(num2 + num9 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
				if (num10 != 3)
				{
					continue;
				}
				if (uint_0 != null)
				{
					uint num11 = Class20.smethod_30(num8 + Class47.gstruct43_105.uint_0, gstruct42_0.int_130);
					int num12 = 0;
					while (num12 < uint_0.Length)
					{
						if (uint_0[num12] != num11)
						{
							num12++;
							continue;
						}
						goto IL_0212;
					}
				}
				if (array == null)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array2, int_2, ref int_);
				string text = Class10.smethod_3(array2).Replace(" ", string.Empty).Replace("Ù", string.Empty)
					.ToLower();
				int num13 = 0;
				while (num13 < array.Length)
				{
					if (!(text == array[num13]) && (bool_0 || 0 > Class11.smethod_2(text, array[num13])))
					{
						num13++;
						continue;
					}
					goto IL_0212;
				}
				continue;
				IL_0212:
				int num14 = 0;
				while (true)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_41 - 4, array2, 1, ref int_);
					if (array2[0] == 0)
					{
						break;
					}
					num14++;
					if (num14 <= 100)
					{
						Thread.Sleep(10);
						continue;
					}
					return num3;
				}
				int num15 = (int)Class20.smethod_30(num2 + num9 * 20 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
				if (num15 < 0)
				{
					continue;
				}
				int num16 = (int)Class20.smethod_30(num2 + num9 * 20 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
				if (num16 < 0)
				{
					continue;
				}
				if (Class60.smethod_41(gstruct42_0, num7, num15, num16, num10))
				{
					num4++;
				}
				if (bool_1)
				{
					if (string_2 == null)
					{
						continue;
					}
					Thread.Sleep(650);
					Class76.Class79.smethod_1(gstruct42_0);
					Class76.smethod_7(gstruct42_0, string_2);
					Thread.Sleep(150);
					string text2 = Class76.Class79.smethod_0(gstruct42_0);
					if (text2 != string.Empty)
					{
						Class76.Class79.smethod_5(gstruct42_0);
						if (0 <= Class11.smethod_2(text2, "h·y chõa"))
						{
							return 1000;
						}
					}
					continue;
				}
				return num4;
			}
			Thread.Sleep(150);
			num3 += num4;
			if (!bool_1 || num4 <= 0)
			{
				break;
			}
			int num17 = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
			if (Class11.bool_0 || num17 < 0 || Class20.smethod_52(FormMain.gstruct42_0[num17].process_0) || !FormMain.gstruct42_0[num17].bool_36)
			{
				return -1;
			}
		}
		return num3;
	}

	public static void smethod_15(GStruct42 gstruct42_0, string[] string_1)
	{
		if (string_1 == null)
		{
			return;
		}
		string[] array = Class10.smethod_5(ref string_1, bool_0: true);
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		int int_ = 0;
		int int_2 = 80;
		byte[] array2 = new byte[80];
		byte[] array3 = new byte[4];
		int int_3 = 0;
		int num3 = Class69.smethod_2(gstruct42_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class47.int_1; num5++)
		{
			if (0 < num3 && num3 <= num4)
			{
				break;
			}
			uint num6 = num + num5 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array3, 4, ref int_3);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			uint uint_ = num6 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array3, 1, ref int_3);
			if (array3[0] == 0)
			{
				continue;
			}
			uint num7 = Class69.smethod_0(gstruct42_0, num5);
			if ((int)num7 <= 0)
			{
				continue;
			}
			num4++;
			int num8 = (int)Class20.smethod_30(num2 + num7 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if (num8 != 3)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array2, int_2, ref int_);
			string a = Class10.smethod_3(array2).Trim();
			int num9 = -1;
			for (int i = 0; i < string_1.Length; i++)
			{
				if (a == string_1[i] || Class10.smethod_1(a, 1).ToUpper() == array[i])
				{
					num9 = i;
					break;
				}
			}
			if (num9 < 0)
			{
				continue;
			}
			int num10 = 0;
			while (true)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_41 - 4, array2, 1, ref int_);
				if (array2[0] == 0)
				{
					break;
				}
				num10++;
				if (num10 <= 60)
				{
					Thread.Sleep(10);
					continue;
				}
				return;
			}
			int num11 = (int)Class20.smethod_30(num2 + num7 * 20 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
			if (num11 >= 0)
			{
				int num12 = (int)Class20.smethod_30(num2 + num7 * 20 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
				if (num12 >= 0)
				{
					Class60.smethod_41(gstruct42_0, num5, num11, num12, num8);
					Thread.Sleep(30);
				}
			}
		}
	}

	public static bool smethod_16(GStruct42 gstruct42_0, string[] string_1)
	{
		if (string_1 == null)
		{
			return true;
		}
		string[] array = new string[string_1.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = string_1[i].Replace(" ", string.Empty).ToLower();
		}
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		int int_ = 0;
		int int_2 = 60;
		int num3 = string_1.Length;
		byte[] array2 = new byte[60];
		byte[] array3 = new byte[num3];
		byte[] array4 = new byte[4];
		int int_3 = 0;
		int num4 = Class69.smethod_2(gstruct42_0);
		int num5 = 0;
		for (uint num6 = 1u; num6 < Class47.int_1; num6++)
		{
			if (num3 > 0)
			{
				if (num4 <= num5)
				{
					break;
				}
				uint num7 = num + num6 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_103.uint_0 - 4, array4, 4, ref int_3);
				if (BitConverter.ToInt32(array4, 0) != 0)
				{
					continue;
				}
				uint uint_ = num7 + Class47.gstruct43_104.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array4, 1, ref int_3);
				if (array4[0] == 0)
				{
					continue;
				}
				uint num8 = Class69.smethod_0(gstruct42_0, num6);
				if ((int)num8 <= 0)
				{
					continue;
				}
				num5++;
				int num9 = (int)Class20.smethod_30(num2 + num8 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
				if (num9 != 3)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array2, int_2, ref int_);
				string text = Class10.smethod_3(array2);
				string a = text.Replace(" ", string.Empty).ToLower();
				int num10 = -1;
				for (int i = 0; i < string_1.Length; i++)
				{
					if (array3[i] <= 0 && (text == string_1[i] || a == array[i]))
					{
						num10 = i;
						break;
					}
				}
				if (num10 < 0)
				{
					continue;
				}
				int num11 = 0;
				while (true)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_41 - 4, array2, 1, ref int_);
					if (array2[0] == 0)
					{
						break;
					}
					num11++;
					if (num11 <= 60)
					{
						Thread.Sleep(10);
						continue;
					}
					return false;
				}
				int num12 = (int)Class20.smethod_30(num2 + num8 * 20 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
				if (num12 < 0)
				{
					continue;
				}
				int num13 = (int)Class20.smethod_30(num2 + num8 * 20 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
				if (num13 < 0)
				{
					continue;
				}
				int num14 = Class69.smethod_2(gstruct42_0);
				Class60.smethod_41(gstruct42_0, num6, num12, num13, num9);
				Thread.Sleep(60);
				for (int j = 0; j < 30; j++)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_103.uint_0 - 4, array4, 4, ref int_3);
					if (BitConverter.ToInt32(array4, 0) != 0)
					{
						break;
					}
					Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array4, 1, ref int_3);
					if (array4[0] == 0 || Class69.smethod_2(gstruct42_0) != num14)
					{
						break;
					}
					Thread.Sleep(10);
				}
				array3[num10] = 1;
				num3--;
				continue;
			}
			return true;
		}
		return num3 != string_1.Length;
	}

	public static bool smethod_17(GStruct42 gstruct42_0, string string_1, bool bool_0 = true)
	{
		if (string_1 != null && !(string_1 == string.Empty))
		{
			string[] array = string_1.Split('|');
			string[] array2 = Class10.smethod_5(ref array, bool_0: true);
			uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
			int int_ = 0;
			int int_2 = 80;
			byte[] array3 = new byte[80];
			byte[] array4 = new byte[4];
			int int_3 = 0;
			int num3 = Class69.smethod_2(gstruct42_0);
			int num4 = 0;
			uint num5 = 1u;
			int num8;
			int num10;
			int num11;
			while (true)
			{
				if (num5 < Class47.int_1 && (0 >= num3 || num3 > num4))
				{
					uint num6 = num + num5 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array4, 4, ref int_3);
					if (BitConverter.ToInt32(array4, 0) == 0)
					{
						uint uint_ = num6 + Class47.gstruct43_104.uint_0;
						Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array4, 1, ref int_3);
						if (array4[0] != 0)
						{
							uint num7 = Class69.smethod_0(gstruct42_0, num5);
							if ((int)num7 > 0)
							{
								num4++;
								num8 = (int)Class20.smethod_30(num2 + num7 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
								if (num8 == 3)
								{
									Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array3, int_2, ref int_);
									string a = Class10.smethod_3(array3).Trim();
									bool flag = false;
									if (bool_0 && array != null)
									{
										for (int i = 0; i < array.Length; i++)
										{
											if (a == array[i])
											{
												flag = true;
												break;
											}
										}
									}
									else if (!bool_0 && array2 != null)
									{
										string string_2 = Class10.smethod_1(a, 1).ToUpper();
										for (int i = 0; i < array2.Length; i++)
										{
											if (0 <= Class11.smethod_2(string_2, array2[i]))
											{
												flag = true;
												break;
											}
										}
									}
									if (flag)
									{
										int num9 = 0;
										while (true)
										{
											Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_41 - 4, array3, 1, ref int_);
											if (array3[0] == 0)
											{
												break;
											}
											num9++;
											if (num9 <= 60)
											{
												Thread.Sleep(10);
												continue;
											}
											return false;
										}
										num10 = (int)Class20.smethod_30(num2 + num7 * 20 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
										if (num10 >= 0)
										{
											num11 = (int)Class20.smethod_30(num2 + num7 * 20 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
											if (num11 >= 0)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					num5++;
					continue;
				}
				return false;
			}
			return Class60.smethod_41(gstruct42_0, num5, num10, num11, num8);
		}
		return false;
	}

	public static long smethod_18(uint[] uint_0, uint[] uint_1)
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
		return 2147483647L;
	}

	public static long smethod_19(uint[] uint_0, uint uint_1, uint uint_2)
	{
		if (uint_0 != null && uint_0[0] != 0 && uint_0[1] != 0 && uint_1 != 0 && uint_2 != 0)
		{
			long num = (int)(uint_0[0] - uint_1);
			long num2 = (int)(uint_0[1] - uint_2);
			long num3 = num * num + num2 * num2;
			if (num3 == 0L)
			{
				num3 = 1L;
			}
			return (uint)num3;
		}
		return 2147483647L;
	}

	public static int smethod_20(uint[,] uint_0, uint[] uint_1)
	{
		if (uint_0 != null && uint_1 != null && uint_0.GetLength(1) >= 2 && uint_1.GetLength(0) >= 2)
		{
			int num = -1;
			long num2 = -1L;
			for (int i = 0; i < uint_0.GetLength(0); i++)
			{
				uint[] uint_2 = new uint[2]
				{
					uint_0[i, 0],
					uint_0[i, 1]
				};
				long num3 = smethod_18(uint_1, uint_2);
				if (num < 0 || num3 < num2)
				{
					num = i;
					num2 = num3;
				}
			}
			return num;
		}
		return -1;
	}

	public static long smethod_21(uint[,] uint_0, uint[] uint_1)
	{
		if (uint_0 != null && uint_1 != null)
		{
			long num = -1L;
			long num2 = -1L;
			for (int i = 0; i < uint_0.GetLength(0); i++)
			{
				uint[] uint_2 = new uint[2]
				{
					uint_0[i, 0],
					uint_0[i, 1]
				};
				long num3 = smethod_18(uint_1, uint_2);
				if (num < 0L || num3 < num2)
				{
					num = i;
					num2 = num3;
				}
			}
			return num2;
		}
		return -1L;
	}

	public static int smethod_22(GStruct42 gstruct42_0, uint[,] uint_0, uint[] uint_1 = null, uint[] uint_2 = null, int int_1 = -1, bool bool_0 = false, int int_2 = 0)
	{
		int int_3 = gstruct42_0.int_129;
		int result = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		bool flag = false;
		bool flag2 = false;
		long num4 = 0L;
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		long num5 = Class11.smethod_22();
		long long_5 = num5;
		uint num6 = 0u;
		uint[] array = null;
		bool flag3 = false;
		bool flag4 = false;
		int num7 = -1;
		int num8 = 0;
		int num9 = 0;
		int num10 = -1;
		int num11 = 0;
		int int_4 = 0;
		byte[] array2 = new byte[4];
		byte[] byte_ = array2;
		bool flag5 = false;
		while (true)
		{
			Thread.Sleep(100);
			int num12 = Class71.smethod_3(FormMain.gstruct42_0, int_3);
			if (Class11.bool_0 || num12 < 0 || Class20.smethod_52(FormMain.gstruct42_0[num12].process_0) || !FormMain.gstruct42_0[num12].bool_36 || Class38.bool_0)
			{
				break;
			}
			gstruct42_0 = FormMain.gstruct42_0[num12];
			int num13 = Class73.smethod_40(gstruct42_0);
			if (num13 <= 1)
			{
				num11++;
				if (num11 > 10)
				{
					result = -1;
					break;
				}
				continue;
			}
			num11 = 0;
			uint num14 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num15 = Class20.smethod_30(num14 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
			uint num16 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			num6 = num16 + num15;
			if (!flag5)
			{
				Class20.WriteProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
				flag5 = true;
			}
			int num17 = (int)Class20.smethod_30(num6 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			int num18 = (int)Class20.smethod_30(num6 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
			int num19 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
			if (int_1 <= 0 || num19 == int_1)
			{
				if (num18 != 0 && num17 != 0 && num17 != 10 && num17 != 21 && num19 != 0 && gstruct42_0.long_8 <= num5)
				{
					if (bool_0)
					{
						int num20 = (int)Class20.smethod_30(num6 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
						if (num20 > 0)
						{
							result = -1;
							break;
						}
					}
					if (int_2 <= 0 || Class11.smethod_23(long_5) <= int_2)
					{
						uint[] array3 = new uint[2]
						{
							Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						if (num10 < 0)
						{
							num10 = num19;
						}
						else if (num10 != num19)
						{
							result = 1;
							break;
						}
						if (!flag)
						{
							flag = true;
							if (uint_1 == null)
							{
								num = smethod_20(uint_0, array3);
								num7 = num;
								uint_1 = new uint[2]
								{
									uint_0[num, 0],
									uint_0[num, 1]
								};
							}
							else
							{
								num = smethod_20(uint_0, uint_1);
								num7 = num;
								flag3 = true;
							}
							if (uint_2 != null)
							{
								num2 = smethod_20(uint_0, uint_2);
							}
							else
							{
								num2 = uint_0.GetLength(0) - 1;
								uint_2 = new uint[2]
								{
									uint_0[num2, 0],
									uint_0[num2, 1]
								};
							}
							num3 = ((num <= num2) ? 1 : (-1));
						}
						if (flag2)
						{
							uint_1 = new uint[2]
							{
								uint_0[num, 0],
								uint_0[num, 1]
							};
							num4 = smethod_18(array3, uint_1);
							if (!flag3)
							{
								if (num4 > 22500L)
								{
									if (Class12.smethod_4(gstruct42_0))
									{
										Class12.smethod_3(gstruct42_0, bool_0: false);
									}
									if (array == null)
									{
										array = new uint[2]
										{
											Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
											Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
										};
										long_ = Class11.smethod_22();
									}
									Class60.smethod_61(gstruct42_0, uint_1);
									Thread.Sleep(200);
									if (Class11.smethod_23(long_) < 6000L)
									{
										continue;
									}
									array3 = new uint[2]
									{
										Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
										Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
									};
									num4 = smethod_18(array, array3);
									if (num4 >= 90000L)
									{
										array = new uint[2]
										{
											array3[0],
											array3[1]
										};
									}
									else
									{
										num8++;
										if (num8 % 6 == 0)
										{
											smethod_10(gstruct42_0);
											num9++;
											if (num9 > 3)
											{
												result = -1;
												break;
											}
										}
										Thread.Sleep(300);
										array3 = new uint[2]
										{
											Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
											Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
										};
										num = smethod_20(uint_0, array3);
										if (num3 > 0)
										{
											num--;
											if (num < 0)
											{
												num = 0;
											}
										}
										else
										{
											num++;
											if (num2 < num)
											{
												num = num2;
											}
										}
										num7 = num;
									}
									long_ = Class11.smethod_22();
									continue;
								}
								if (Class11.smethod_23(long_3) > 60000L)
								{
									flag4 = Class32.smethod_17(gstruct42_0);
									long_3 = Class11.smethod_22();
								}
								if (flag4 && Class20.smethod_30(num6 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) == 0 && Class11.smethod_23(long_4) > 3000L)
								{
									Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
									long_4 = Class11.smethod_22();
								}
								num = smethod_20(uint_0, uint_1);
								if ((num < num7 && num3 > 0) || (num > num7 && num3 < 0))
								{
									num8++;
									if (num8 % 6 == 0)
									{
										smethod_10(gstruct42_0);
										num9++;
										if (num9 > 3)
										{
											result = -1;
											break;
										}
									}
									if (num3 > 0)
									{
										num--;
										if (num < 0)
										{
											num = 0;
										}
									}
									else
									{
										num++;
										if (num2 < num)
										{
											num = num2;
										}
									}
									num7 = num;
								}
								else
								{
									num += num3;
									num7 = num;
									num8 = 0;
									num9 = 0;
									if ((num3 > 0 && num2 < num) || (num3 < 0 && num < num2))
									{
										result = 1;
										break;
									}
								}
							}
							else
							{
								flag3 = false;
								flag2 = false;
							}
							continue;
						}
						int i = 0;
						num4 = smethod_18(array3, uint_1);
						if (num4 <= 1000000L)
						{
							if (Class12.smethod_4(gstruct42_0))
							{
								Class12.smethod_3(gstruct42_0, bool_0: false);
							}
							for (; i < 5; i++)
							{
								array3 = new uint[2]
								{
									Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
									Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
								};
								num4 = smethod_18(array3, uint_1);
								if (num4 <= 22500L)
								{
									break;
								}
								Class60.smethod_61(gstruct42_0, uint_1);
								Thread.Sleep(300);
							}
							num19 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
							if (int_1 > 0 && num19 != int_1)
							{
								result = 1;
								break;
							}
							if (i > 4 && num4 > 22500L)
							{
								Class12.smethod_1(gstruct42_0, uint_1);
								Thread.Sleep(300);
							}
							flag2 = true;
						}
						else if (Class11.smethod_23(long_2) > 3000L)
						{
							Class12.smethod_1(gstruct42_0, uint_1);
							long_2 = Class11.smethod_22();
						}
						continue;
					}
					result = 101;
					break;
				}
				result = -1;
				break;
			}
			result = -1;
			break;
		}
		Class12.smethod_3(gstruct42_0, bool_0: false);
		return result;
	}

	public static int smethod_23(GStruct42 gstruct42_0, uint[] uint_0, int int_1, uint[] uint_1 = null, int int_2 = -1)
	{
		int int_3 = gstruct42_0.int_129;
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_3);
		if (!Class11.bool_0 && num >= 0 && !Class20.smethod_52(FormMain.gstruct42_0[num].process_0) && FormMain.gstruct42_0[num].bool_36)
		{
			uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
			uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num5 = num4 + num3;
			int num6 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
			if (num6 == int_2)
			{
				return 1;
			}
			uint[] array = new uint[2]
			{
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
			int num7 = 0;
			if (uint_1 != null)
			{
				for (num7 = 0; num7 < 10; num7++)
				{
					uint num8 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
					if (num8 == num6 && num8 != int_2)
					{
						array = new uint[2]
						{
							Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						if (smethod_18(array, uint_1) < 11500L)
						{
							break;
						}
						Class60.smethod_61(gstruct42_0, uint_1);
						Thread.Sleep(300);
						continue;
					}
					return 1;
				}
				for (num7 = 0; num7 < 10; num7++)
				{
					if (Class20.smethod_30(num5 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130) != 3)
					{
						break;
					}
					Thread.Sleep(100);
				}
			}
			num7 = 0;
			while (!Class11.bool_0)
			{
				uint num8 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
				if ((num8 == 0 || num8 == num6) && num8 != int_2)
				{
					array = new uint[2]
					{
						Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
						Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
					};
					if (smethod_18(array, uint_0) < 11500L)
					{
						break;
					}
					Class60.smethod_61(gstruct42_0, uint_0);
					Thread.Sleep(300);
					num7++;
					continue;
				}
				return 1;
			}
			for (num7 = 0; num7 < 10; num7++)
			{
				if (Class20.smethod_30(num5 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130) != 3)
				{
					break;
				}
				Thread.Sleep(100);
			}
			for (int i = 0; i < 5; i++)
			{
				uint num8 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
				if ((num8 == 0 || num8 == num6) && num8 != int_2)
				{
					if (Class60.smethod_7(gstruct42_0))
					{
						smethod_25(gstruct42_0, int_1);
					}
					Thread.Sleep(300);
					continue;
				}
				return 1;
			}
			return 0;
		}
		return 0;
	}

	public static int smethod_24(GStruct42 gstruct42_0, uint[] uint_0, int int_1, uint[] uint_1 = null, uint[,] uint_2 = null, int int_2 = -10)
	{
		int int_3 = gstruct42_0.int_129;
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_3);
		if (!Class11.bool_0 && num >= 0 && !Class20.smethod_52(FormMain.gstruct42_0[num].process_0) && FormMain.gstruct42_0[num].bool_36)
		{
			uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
			uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num5 = num4 + num3;
			int num6 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
			if (num6 == int_2)
			{
				return 1;
			}
			uint[] array = new uint[2]
			{
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
			if (uint_2 != null)
			{
				int num7 = smethod_20(uint_2, array);
				if (0 < num7)
				{
					uint_0 = new uint[2]
					{
						uint_2[num7, 0],
						uint_2[num7, 1]
					};
					if (uint_2.GetLength(1) > 2)
					{
						int_1 = (int)uint_2[num7, 2];
					}
					uint_1 = null;
				}
			}
			long num8 = smethod_18(array, uint_0);
			if (num8 > 90000L)
			{
				if (Class20.smethod_30(num5 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) == 0 && gstruct42_0.bool_64)
				{
					Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
				}
				Class12.smethod_1(gstruct42_0, uint_0);
				return -1;
			}
			long long_ = Class11.smethod_22();
			while (!Class11.bool_0)
			{
				array = new uint[2]
				{
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				num8 = smethod_18(array, uint_0);
				if (num8 < 11500L || Class11.smethod_23(long_) > 6000L)
				{
					break;
				}
				uint num9 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
				if ((num9 == 0 || num9 == num6) && num9 != int_2)
				{
					Class60.smethod_61(gstruct42_0, uint_0);
					Thread.Sleep(300);
					continue;
				}
				return 1;
			}
			long_ = Class11.smethod_22();
			while (!Class11.bool_0 && uint_1 != null)
			{
				array = new uint[2]
				{
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				num8 = smethod_18(array, uint_1);
				if (num8 < 11500L || Class11.smethod_23(long_) > 6000L)
				{
					break;
				}
				uint num9 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
				if ((num9 == 0 || num9 == num6) && num9 != int_2)
				{
					Class60.smethod_61(gstruct42_0, uint_1);
					Thread.Sleep(300);
					continue;
				}
				return 1;
			}
			long_ = Class11.smethod_22();
			while (Class20.smethod_30(num5 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130) > 1 && Class11.smethod_23(long_) < 1800L)
			{
				Thread.Sleep(300);
			}
			int num10 = 0;
			while (true)
			{
				if (num10 < 5)
				{
					if (Class60.smethod_7(gstruct42_0))
					{
						smethod_25(gstruct42_0, int_1);
					}
					Thread.Sleep(350);
					uint num9 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
					if ((num9 != 0 && num9 != num6) || num9 == int_2)
					{
						break;
					}
					num10++;
					continue;
				}
				return 0;
			}
			return 1;
		}
		return 0;
	}

	public static void smethod_25(GStruct42 gstruct42_0, int int_1)
	{
		uint[] array = Class32.smethod_29(gstruct42_0);
		if (array != null)
		{
			double num = (double)Math.Abs(int_1) * 3.14 / 180.0;
			uint[] uint_ = new uint[2]
			{
				(uint)((double)array[0] + 200.0 * Math.Cos(num)),
				(uint)((double)array[1] - 200.0 * Math.Sin(num))
			};
			Class60.smethod_61(gstruct42_0, uint_);
			Thread.Sleep(150);
		}
	}

	public static uint[] smethod_26(GStruct42 gstruct42_0, ref int int_1)
	{
		if (!FormMayphu.bool_3 && gstruct42_0.int_68 != null && gstruct42_0.int_68[0] > 0 && gstruct42_0.string_7 != null && !(gstruct42_0.string_7 == string.Empty) && !(gstruct42_0.string_7 == gstruct42_0.string_20))
		{
			bool flag = false;
			int int_2 = 0;
			byte[] array = new byte[gstruct42_0.string_7.Length + 1];
			string text = null;
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num4 = 0u;
			uint num5 = 0u;
			while (true)
			{
				if (int_1 > 0)
				{
					num4 = (uint)((int)num3 + int_1 * (int)Class47.gstruct43_15.uint_0);
					num5 = num4 + Class47.gstruct43_16.uint_0;
					if (Class20.ReadProcessMemory(gstruct42_0.int_130, num5, array, 1, ref int_2) && array[0] != 0 && Class20.smethod_30(num4 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130) == 1)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num5, array, array.Length, ref int_2);
						text = Class10.smethod_3(array);
						if (!(text == string.Empty) && Class11.smethod_3(text, gstruct42_0.string_7, bool_1: true) && (int)Class20.smethod_30(num4 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130) > 0)
						{
							return new uint[2]
							{
								Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
								Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
							};
						}
					}
				}
				if (flag)
				{
					break;
				}
				int int_3 = 0;
				byte[] array2 = new byte[4];
				uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array2, 4, ref int_3);
				int num6 = BitConverter.ToInt32(array2, 0);
				if (num6 > 1)
				{
					int num7 = 0;
					uint num8 = 1u;
					while (true)
					{
						if (num8 < 256 && num6 > num7)
						{
							if (num8 == num2)
							{
								num7++;
							}
							else
							{
								num4 = num3 + num8 * Class47.gstruct43_15.uint_0;
								Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_50.uint_0, array2, 4, ref int_3);
								if (BitConverter.ToInt32(array2, 0) > 0)
								{
									num7++;
									if (Class20.smethod_30(num4 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130) == 1)
									{
										num5 = num4 + Class47.gstruct43_16.uint_0;
										if (Class20.ReadProcessMemory(gstruct42_0.int_130, num5, array, 1, ref int_2) && array[0] != 0)
										{
											Class20.ReadProcessMemory(gstruct42_0.int_130, num5, array, array.Length, ref int_2);
											text = Class10.smethod_3(array);
											if (text != string.Empty && Class11.smethod_3(text, gstruct42_0.string_7, bool_1: true))
											{
												break;
											}
										}
									}
								}
							}
							num8++;
							continue;
						}
						return null;
					}
					int_1 = (int)num8;
					flag = true;
					continue;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public static int smethod_27(GStruct42 gstruct42_0, string string_1, int int_1 = -1, bool bool_0 = false)
	{
		int int_2 = 0;
		byte[] array = new byte[4];
		int num = 0;
		while (true)
		{
			if (!bool_0 && gstruct42_0.uint_13 != 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_13, array, 4, ref int_2);
				if (BitConverter.ToInt32(array, 0) > 0)
				{
					return 0;
				}
				array[0] = 1;
				Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_13, array, 1, ref int_2);
				if (!smethod_17(gstruct42_0, string_1))
				{
					num = -1;
					break;
				}
			}
			int i = 0;
			uint num2;
			for (num2 = 0u; num2 == 0; i++, Thread.Sleep(1))
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_6 + Class47.gstruct43_147.uint_0, array, 4, ref int_2);
				num2 = BitConverter.ToUInt32(array, 0);
				if (num2 != 0)
				{
					continue;
				}
				if (bool_0)
				{
					goto IL_0080;
				}
				if (i <= 300)
				{
					continue;
				}
				goto IL_0236;
			}
			string text = "STRINGINPUT";
			uint uint_ = num2 + Class47.gstruct43_244.uint_0;
			array = new byte[text.Length + 1];
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_2);
			string a = Class10.smethod_3(array).Trim().ToUpper();
			if (!(a != text))
			{
				int num3 = FormMain.int_12;
				if (int_1 >= 0 && num3 <= int_1)
				{
					num3 = int_1 + 1;
				}
				if (gstruct42_0.int_26 > 0 && gstruct42_0.int_62 != null && gstruct42_0.int_62[0] > 0)
				{
					int[] array2 = new int[5]
					{
						1,
						2,
						3,
						4,
						6
					};
					int num4 = array2[gstruct42_0.int_62[1]];
					int num5 = Class69.smethod_21(gstruct42_0);
					int num6 = num5 - num4;
					if (num6 < 0)
					{
						num6 = 0;
					}
					if (num3 > num6)
					{
						num3 = num6;
					}
				}
				char[] array3 = num3.ToString().ToCharArray();
				for (int j = 0; j < array3.Length; j++)
				{
					Class20.smethod_4(gstruct42_0.uint_4, array3[j]);
					Thread.Sleep(10);
				}
				Class20.smethod_4(gstruct42_0.uint_4, 13u);
				num = 2;
			}
			else
			{
				num = 1;
			}
			break;
			IL_0236:
			num = 1;
			break;
			IL_0080:
			bool_0 = false;
		}
		if (gstruct42_0.uint_13 != 0)
		{
			byte[] array4 = new byte[4];
			array = array4;
			Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_13, array, 4, ref int_2);
			Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_13 + 4, array, 4, ref int_2);
		}
		return num;
	}

	public static void smethod_28(GStruct42 gstruct42_0)
	{
		if (Class32.smethod_26(gstruct42_0) > 0 && smethod_13(gstruct42_0))
		{
			Thread.Sleep(1 + FormLuomrac.int_5);
			Class20.smethod_53(gstruct42_0.process_0);
		}
	}

	public static void smethod_29(GStruct42 gstruct42_0, bool bool_0, ref long long_0)
	{
		if (Class11.smethod_23(long_0) < 400L)
		{
			return;
		}
		if ((bool_0 && gstruct42_0.int_90 == 1) || (!bool_0 && gstruct42_0.bool_64 && gstruct42_0.int_90 == 0))
		{
			Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
		}
		else if (bool_0 && gstruct42_0.int_90 == 2)
		{
			string string_ = Class73.smethod_20(gstruct42_0);
			if (Class11.smethod_3(string_, "giê kh«ng th"))
			{
				Class73.smethod_21(gstruct42_0, "0K..");
				Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
			}
		}
		long_0 = Class11.smethod_22();
	}

	public static void smethod_30(GStruct42 gstruct42_0, bool bool_0, ref long long_0)
	{
		if (!bool_0 || gstruct42_0.int_90 <= 0 || gstruct42_0.int_90 > 2 || Class11.smethod_23(long_0) < 600L)
		{
			return;
		}
		if (gstruct42_0.int_90 != 1)
		{
			if (gstruct42_0.int_90 == 2)
			{
				string string_ = Class73.smethod_20(gstruct42_0);
				if (Class11.smethod_3(string_, "giê kh«ng th"))
				{
					Class73.smethod_21(gstruct42_0, "0K..");
					Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
				}
			}
		}
		else
		{
			Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
		}
		long_0 = Class11.smethod_22();
	}

	public static void smethod_31(GStruct42 gstruct42_0, bool bool_0, ref long long_0)
	{
		if (bool_0 && gstruct42_0.int_90 == 2 && Class11.smethod_23(long_0) >= 600L)
		{
			string string_ = Class73.smethod_20(gstruct42_0);
			if (Class11.smethod_3(string_, "giê kh«ng th"))
			{
				Class73.smethod_21(gstruct42_0, "0K..");
				Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
			}
			long_0 = Class11.smethod_22();
		}
	}
}
