using System;
using System.Threading;

internal class Class16
{
	private static string string_0 = "truyÒn tèng";

	public static string[] string_1 = new string[4]
	{
		"Bất kỳ",
		"La tiêu sơn",
		"Vũ di sơn",
		"Tường vân động"
	};

	public static int int_0 = Class55.smethod_3("IndexChienlongdong", 0, "0");

	public static int int_1 = -1;

	private static string[] string_2 = null;

	private static Random random_0 = new Random();

	private static uint[,] uint_0 = new uint[4, 2]
	{
		{
			48791u,
			98700u
		},
		{
			49498u,
			98042u
		},
		{
			49221u,
			96690u
		},
		{
			49701u,
			95724u
		}
	};

	private static uint[,] uint_1 = new uint[4, 2]
	{
		{
			45380u,
			97414u
		},
		{
			45164u,
			96804u
		},
		{
			45465u,
			96050u
		},
		{
			45752u,
			95944u
		}
	};

	private static uint[,] uint_2 = new uint[3, 2]
	{
		{
			54831u,
			100192u
		},
		{
			54564u,
			100732u
		},
		{
			54191u,
			101062u
		}
	};

	private static uint[,] uint_3 = new uint[3, 2]
	{
		{
			51413u,
			92596u
		},
		{
			50887u,
			92828u
		},
		{
			50888u,
			93562u
		}
	};

	public static int smethod_0(GStruct42 gstruct42_0, bool bool_0 = false, bool bool_1 = false)
	{
		int result = 0;
		int int_ = gstruct42_0.int_129;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		long long_ = 0L;
		string object_ = string_0.ToUpper();
		string str = "ChiÕn Long|H\u00b8i-Qu¶|H\u00b8i Qu¶ H|L­ìng Thñy |nhÆt H¹t-Hoµng|H\u00b8iQu¶";
		int num5 = 0;
		while (true)
		{
			Thread.Sleep(200);
			int num6 = Class71.smethod_3(FormMain.gstruct42_0, int_);
			uint num10;
			if (!Class11.bool_0 && num6 >= 0 && Class73.smethod_12(gstruct42_0) <= 0 && Class73.smethod_40(gstruct42_0) > 1)
			{
				if (bool_1 || FormMain.int_108 > 0)
				{
					gstruct42_0 = FormMain.gstruct42_0[num6];
					if (!gstruct42_0.bool_36 || gstruct42_0.int_21[0] > 0 || gstruct42_0.int_126[0] > 0 || gstruct42_0.bool_60 || gstruct42_0.int_26 > 0 || gstruct42_0.bool_21 || gstruct42_0.bool_6)
					{
						break;
					}
					if (bool_0 || FormMain.int_20 == 0)
					{
						uint num7 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
						uint num8 = Class20.smethod_30(num7 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
						uint num9 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
						num10 = num9 + num8 * Class47.gstruct43_15.uint_0;
						int num11 = (int)Class20.smethod_30(num10 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
						int num12 = (int)Class20.smethod_30(num10 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
						int num13 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
						int num14 = (int)Class20.smethod_30(num10 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
						if (num11 != 10 && num11 != 21 && num12 != 0 && num11 != 0 && num13 != 0)
						{
							num4 = 0;
							uint[] array = new uint[2]
							{
								Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
								Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
							};
							if (array[0] == 0 || array[1] == 0)
							{
								continue;
							}
							if (num5 > 0 && (num13 == 959 || num13 == 990))
							{
								num5 = 0;
							}
							if (num13 != 959 && num13 != 990 && num14 <= 0)
							{
								string text = null;
								if (int_0 != 1)
								{
									if (int_0 == 2)
									{
										text = "Vò Di|Cæng 2";
									}
									else if (int_0 == 3)
									{
										text = "T­êng V©n|Cæng 3";
									}
								}
								else
								{
									text = "La Tiªu|Cæng 1";
								}
								if (int_1 < 0)
								{
									int_1 = 0;
									string_2 = null;
									if (Class31.struct16_0 != null)
									{
										for (int i = 0; i < Class31.struct16_0.Length; i++)
										{
											if (Class31.struct16_0[i].int_0 != 959 && Class31.struct16_0[i].int_0 != 990)
											{
												continue;
											}
											int_1 = Class31.struct16_0[i].int_0;
											if (Class31.struct16_0[i].string_2 == null || !(Class31.struct16_0[i].string_2 != string.Empty))
											{
												break;
											}
											string[] array2 = Class31.struct16_0[i].string_2.Split('|');
											string_2 = new string[3];
											for (int j = 0; j < string_2.Length; j++)
											{
												if (j < array2.Length)
												{
													string_2[j] = array2[j];
												}
												else
												{
													string_2[j] = array2[array2.Length - 1];
												}
											}
											break;
										}
									}
								}
								if ((num5 >= 1 && FormMain.int_104 <= 0) || int_1 <= 0)
								{
									int[] array3 = Class53.smethod_7(num13);
									if (array3 == null || array3[1] == 0)
									{
										Class44.smethod_2(gstruct42_0, str + "|" + text);
										if (Class76.Class79.smethod_4(gstruct42_0))
										{
											Class76.Class79.smethod_5(gstruct42_0);
										}
										Class76.smethod_9(gstruct42_0);
										continue;
									}
									Class44.smethod_7(gstruct42_0);
									result = -2;
									break;
								}
								if (string_2 != null)
								{
									if (text != null)
									{
										text += "|";
									}
									text = ((int_0 <= 0) ? (text + string_2[random_0.Next(0, 2)]) : (text + string_2[int_0 - 1]));
								}
								bool flag = Class31.smethod_61(gstruct42_0, int_1, text);
								Class76.smethod_9(gstruct42_0);
								if (flag)
								{
									num5++;
									Thread.Sleep(100);
								}
								continue;
							}
							if ((num13 == 959 || num13 == 990) && int_0 != 0)
							{
								long num15 = Class53.smethod_21(uint_1, array);
								long num16 = Class53.smethod_21(uint_0, array);
								long num17 = Class53.smethod_21(uint_2, array);
								if ((int_0 != 1 || num17 > num15 || num17 > num16) && (int_0 != 2 || num15 > num17 || num15 > num16) && (int_0 != 3 || num16 > num17 || num16 > num15))
								{
									if (Class11.smethod_23(long_) > 3000L)
									{
										Class60.smethod_50(gstruct42_0, "§ang chän l¹i cæng lªn cl®...");
										long_ = Class11.smethod_22();
									}
									if (FormMain.int_104 > 0 && int_1 > 0)
									{
										string text = null;
										if (int_0 == 1)
										{
											text = "La Tiªu|Cæng 1";
										}
										else if (int_0 == 2)
										{
											text = "Vò Di|Cæng 2";
										}
										else if (int_0 == 3)
										{
											text = "T­êng V©n|Cæng 3";
										}
										if (string_2 != null)
										{
											if (text != null)
											{
												text += "|";
											}
											text = ((int_0 > 0) ? (text + string_2[int_0 - 1]) : (text + string_2[random_0.Next(0, 2)]));
										}
										if (Class31.smethod_61(gstruct42_0, int_1, text + string_2))
										{
											Class76.smethod_9(gstruct42_0);
											num5++;
										}
										continue;
									}
									uint[,] array4 = null;
									array4 = ((num17 <= num16 && num17 <= num15) ? uint_2 : ((num15 > num16 || num15 > num17) ? uint_0 : uint_1));
									int length = array4.GetLength(0);
									uint[] array5 = new uint[2]
									{
										array4[length - 1, 0],
										array4[length - 1, 1]
									};
									long num18 = Class53.smethod_18(array, array5);
									if (num18 > 90000L)
									{
										num++;
										if (num < 3)
										{
											Class50.smethod_10(gstruct42_0, array4, array5, bool_0: true, 10000);
											continue;
										}
									}
									for (num = 0; num < 10; num++)
									{
										array = new uint[2]
										{
											Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
											Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
										};
										if (Class53.smethod_18(array, array5) <= 11500L)
										{
											break;
										}
										Class60.smethod_61(gstruct42_0, array5);
										Thread.Sleep(300);
									}
									num = 0;
									if (num2 > 0)
									{
										string text2 = Class86.smethod_15(gstruct42_0, num2, ref array5, 32);
										if (text2 != null && 0 <= Class11.smethod_2(text2.ToUpper(), object_))
										{
											goto IL_0868;
										}
									}
									num2 = Class86.smethod_14(gstruct42_0, string_0, ref array5, 3, bool_0: false);
									if (num2 > 0)
									{
										goto IL_0868;
									}
									goto IL_08ce;
								}
								result = 1;
								break;
							}
							result = 1;
							break;
						}
						if (num12 == 0 || num11 == 0)
						{
							num4++;
							if (num4 < 10)
							{
								Thread.Sleep(100);
								continue;
							}
						}
						result = -1;
						break;
					}
					result = 1;
					break;
				}
				result = -1;
				break;
			}
			result = -1;
			break;
			IL_08ce:
			num3++;
			Thread.Sleep(100);
			if (num3 > 10)
			{
				int num19 = (int)Class20.smethod_30(num10 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130);
				if (num19 > 0)
				{
					Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
					Thread.Sleep(300);
				}
				Class60.smethod_55(gstruct42_0, "Switch([[sit]])");
				Thread.Sleep(300);
				num3 = 0;
			}
			continue;
			IL_0868:
			int int_2 = 0;
			byte[] bytes = BitConverter.GetBytes(num2);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_72.uint_0, bytes, 4, ref int_2);
			Thread.Sleep(100);
			num = 0;
			while (!Class76.smethod_0(gstruct42_0))
			{
				num++;
				Thread.Sleep(100);
				if (num <= 10)
				{
					continue;
				}
				goto IL_08ce;
			}
			num = 0;
			Class76.smethod_6(gstruct42_0, 0);
			num2 = 0;
		}
		return result;
	}

	public static uint[] smethod_1(GStruct42 gstruct42_0)
	{
		uint[,] array = new uint[4, 2]
		{
			{
				54176u,
				101024u
			},
			{
				45760u,
				95936u
			},
			{
				49760u,
				95712u
			},
			{
				51328u,
				92512u
			}
		};
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2;
		Class20.smethod_30(num4 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
		Class20.smethod_30(num4 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
		int num5 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
		if (num5 != 959 && num5 != 990)
		{
			return null;
		}
		uint[] array2 = new uint[2]
		{
			Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
			Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
		};
		int num6 = Class53.smethod_20(array, array2);
		if (num6 < 0)
		{
			return null;
		}
		uint[] array3 = new uint[2]
		{
			array[num6, 0],
			array[num6, 1]
		};
		long num7 = Class53.smethod_18(array2, array3);
		if (num7 > 90000L)
		{
			return array3;
		}
		Class76.smethod_9(gstruct42_0);
		long long_ = Class11.smethod_22();
		while (!Class11.bool_0)
		{
			array2 = new uint[2]
			{
				Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
			num7 = Class53.smethod_18(array2, array3);
			if (num7 < 22500L)
			{
				break;
			}
			if (Class11.smethod_23(long_) <= 6000L)
			{
				uint num8 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
				if (num8 == num5)
				{
					Class60.smethod_61(gstruct42_0, array3);
					Thread.Sleep(300);
					continue;
				}
				return null;
			}
			return null;
		}
		string text = "ruyÒn tèng";
		int num9 = Class86.smethod_12(gstruct42_0, text, 3);
		if (num9 <= 0)
		{
			return null;
		}
		bool flag = false;
		while (true)
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(num9);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_72.uint_0, bytes, 4, ref int_);
			Thread.Sleep(100);
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(150);
				if (Class76.smethod_0(gstruct42_0) && Class76.smethod_2(gstruct42_0) > 0)
				{
					Class60.smethod_57(gstruct42_0, 0, 0);
					return null;
				}
			}
			if (flag)
			{
				break;
			}
			flag = true;
		}
		return null;
	}
}
