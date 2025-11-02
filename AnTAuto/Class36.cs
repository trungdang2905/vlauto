using System;
using System.Threading;

internal class Class36
{
	public static int[] int_0 = null;

	public static bool bool_0 = false;

	private static int int_1 = 0;

	public static uint[,] uint_0 = new uint[22, 2]
	{
		{
			50936u,
			81240u
		},
		{
			50487u,
			82325u
		},
		{
			50265u,
			84034u
		},
		{
			50133u,
			85628u
		},
		{
			49268u,
			86860u
		},
		{
			48331u,
			87895u
		},
		{
			47609u,
			89245u
		},
		{
			46688u,
			90068u
		},
		{
			45766u,
			90360u
		},
		{
			45130u,
			90895u
		},
		{
			44392u,
			91284u
		},
		{
			43512u,
			91326u
		},
		{
			42803u,
			91600u
		},
		{
			41689u,
			91479u
		},
		{
			40485u,
			91663u
		},
		{
			39102u,
			91984u
		},
		{
			38340u,
			92876u
		},
		{
			37711u,
			94086u
		},
		{
			36809u,
			94767u
		},
		{
			36310u,
			95318u
		},
		{
			35572u,
			96095u
		},
		{
			35205u,
			97606u
		}
	};

	public static uint[,] uint_1 = new uint[26, 2]
	{
		{
			35165u,
			99118u
		},
		{
			35729u,
			99158u
		},
		{
			36532u,
			98496u
		},
		{
			36931u,
			97516u
		},
		{
			37373u,
			97205u
		},
		{
			38135u,
			96969u
		},
		{
			38817u,
			96506u
		},
		{
			39393u,
			95819u
		},
		{
			39792u,
			94828u
		},
		{
			40404u,
			94182u
		},
		{
			41074u,
			93989u
		},
		{
			41754u,
			93934u
		},
		{
			42579u,
			94277u
		},
		{
			43365u,
			94046u
		},
		{
			44075u,
			93564u
		},
		{
			44742u,
			93434u
		},
		{
			45483u,
			93099u
		},
		{
			45698u,
			92888u
		},
		{
			46561u,
			92359u
		},
		{
			47426u,
			92088u
		},
		{
			48585u,
			91703u
		},
		{
			49141u,
			91078u
		},
		{
			49694u,
			90702u
		},
		{
			49909u,
			90444u
		},
		{
			50475u,
			90932u
		},
		{
			51170u,
			91301u
		}
	};

	public static void smethod_0()
	{
		bool_0 = true;
		long long_ = Class11.smethod_22();
		while (!Class11.bool_0 && int_0 != null)
		{
			if (int_0 != null && (int_1 == 0 || Class11.smethod_23(long_) > 3000L))
			{
				int_1 = int_0[0];
				Class11.smethod_33(ref int_0, int_1);
				new Thread(smethod_1).Start();
				Thread.Sleep(150);
				long_ = Class11.smethod_22();
			}
			Thread.Sleep(300);
		}
		bool_0 = false;
	}

	public static void smethod_1()
	{
		int int_ = int_1;
		int_1 = 0;
		while (true)
		{
			try
			{
				smethod_2(int_);
				return;
			}
			catch
			{
			}
		}
	}

	private static void smethod_2(int int_2)
	{
		uint[] array = null;
		uint[] array2 = null;
		uint[,] array3 = new uint[3, 4]
		{
			{
				36878u,
				96794u,
				37378u,
				97234u
			},
			{
				41005u,
				93092u,
				41697u,
				93718u
			},
			{
				49309u,
				90071u,
				49794u,
				90416u
			}
		};
		string string_ = "ThuyÒn phu";
		string text = "MËt ®å thÇn bÝ";
		bool flag = false;
		int num = 0;
		int num2 = 0;
		GStruct42 gstruct42_ = default(GStruct42);
		uint num3 = 0u;
		bool flag2 = false;
		long long_ = 0L;
		long long_2 = 0L;
		while (true)
		{
			Thread.Sleep(300);
			int num4 = Class71.smethod_3(FormMain.gstruct42_0, int_2);
			if (Class11.bool_0 || num4 < 0 || !FormMain.gstruct42_0[num4].bool_36)
			{
				break;
			}
			gstruct42_ = FormMain.gstruct42_0[num4];
			if (!flag2)
			{
				if (gstruct42_.bool_21)
				{
					break;
				}
				flag2 = true;
				FormMain.gstruct42_0[num4].bool_21 = true;
				Class60.smethod_50(gstruct42_, "<bclr=blue><color=green>Lªn thuyÒn PL§: Tù ®éng nép lÖnh bµi PL§, lÖnh bµi Thuû tÆc, hoÆc MËt ®å ThÇn bÝ.");
			}
			else if (!gstruct42_.bool_21)
			{
				break;
			}
			uint num5 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
			uint num6 = Class20.smethod_30(num5 + Class47.gstruct43_13.uint_0, gstruct42_.int_130) * Class47.gstruct43_15.uint_0;
			uint num7 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
			num3 = num7 + num6;
			int num8 = (int)Class20.smethod_30(num3 + Class47.gstruct43_55.uint_0, gstruct42_.int_130);
			int num9 = (int)Class20.smethod_30(num3 + Class47.gstruct43_50.uint_0, gstruct42_.int_130);
			int num10 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_.int_130);
			string string_2 = Class20.smethod_28(gstruct42_.uint_6 + Class47.gstruct43_28.uint_0 + Class47.gstruct43_29.uint_0, gstruct42_.int_130, 60);
			uint[] array4 = new uint[2]
			{
				Class20.smethod_30(num3 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
				Class20.smethod_30(num3 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
			};
			if (array4[0] == 0 || array4[1] == 0)
			{
				continue;
			}
			int num11 = Class73.smethod_40(gstruct42_);
			if (num9 != 0 && num8 != 0 && num8 != 10 && num8 != 21 && num10 != 0 && (int)array4[0] > 0 && (int)array4[1] > 0 && num11 > 1)
			{
				if (num10 == 337 || num10 == 338 || num10 == 339 || Class11.smethod_2(string_2, "BÕn thuyÒn") == 0)
				{
					break;
				}
				if (num10 == 336)
				{
					array = new uint[2]
					{
						array3[FormMain.int_98, 0],
						array3[FormMain.int_98, 1]
					};
					array2 = new uint[2]
					{
						array3[FormMain.int_98, 2],
						array3[FormMain.int_98, 3]
					};
					long num12 = Class53.smethod_18(array4, array);
					long num13 = Class53.smethod_18(array4, array2);
					uint num14 = 90000u;
					if (num12 > 90000L && num13 > num14)
					{
						if (!Class12.smethod_4(gstruct42_) || Class11.smethod_23(long_2) > 4000L)
						{
							Class12.smethod_1(gstruct42_, array2);
							long_2 = Class11.smethod_22();
						}
						continue;
					}
					Class12.smethod_3(gstruct42_, bool_0: false);
					if (num12 > num14)
					{
						Class60.smethod_61(gstruct42_, array);
						Thread.Sleep(300);
					}
					uint[] uint_ = null;
					if (num2 <= 0 || Class11.smethod_23(long_) > 3000L)
					{
						num2 = Class86.smethod_14(gstruct42_, string_, ref uint_, 3, bool_0: false);
						if (num2 <= 0)
						{
							goto IL_0787;
						}
					}
					array4 = new uint[2]
					{
						Class20.smethod_30(num3 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
						Class20.smethod_30(num3 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
					};
					num12 = Class53.smethod_18(array4, uint_);
					if (num12 > 10500L)
					{
						Class60.smethod_61(gstruct42_, uint_);
						Thread.Sleep(300);
					}
					Class76.Class79.smethod_5(gstruct42_);
					Class76.Class79.smethod_1(gstruct42_);
					Class76.smethod_9(gstruct42_);
					int int_3 = 0;
					byte[] bytes = BitConverter.GetBytes(num2);
					Class20.WriteProcessMemory(gstruct42_.int_130, num3 + Class47.gstruct43_72.uint_0, bytes, bytes.Length, ref int_3);
					Thread.Sleep(600);
					int num15 = Class76.smethod_2(gstruct42_);
					switch (num15)
					{
					default:
					{
						if (!flag)
						{
							if (!(flag = (Class76.smethod_7(gstruct42_, "tham gia ho¹t ®éng|bµi häc ®Ých ®\u00b8ng|KÕt thóc") > 0)))
							{
								bool flag3 = false;
								for (int i = 0; i < num15; i++)
								{
									string string_3 = Class76.smethod_3(gstruct42_, i);
									if (0 <= Class11.smethod_2(string_3, "tham gia ho¹t ®éng") || 0 <= Class11.smethod_2(string_3, "bµi häc ®Ých ®\u00b8ng"))
									{
										flag3 = true;
									}
								}
								if (flag3)
								{
									continue;
								}
							}
							flag = true;
						}
						string[] string_4 = new string[4]
						{
							"Lªn thuyÒn",
							"cã lÖnh bµi",
							"nép lÖnh bµi",
							"ng lÖnh bµi"
						};
						int num16 = Class69.smethod_28(gstruct42_, text, 3, bool_1: true);
						if (num16 > 199)
						{
							string_4 = new string[5]
							{
								"Lªn thuyÒn",
								"200",
								"cã lÖnh bµi",
								"nép lÖnh bµi",
								"ng lÖnh bµi"
							};
						}
						bool flag4 = false;
						bool flag5 = false;
						bool flag6 = false;
						do
						{
							int num17 = Class76.smethod_2(gstruct42_);
							if (num17 == 0 || string_4 == null || string_4.Length <= 0)
							{
								break;
							}
							int j;
							int num18;
							string string_5;
							for (j = 0; j < string_4.Length; j++)
							{
								num18 = 0;
								while (num18 < num17)
								{
									string_5 = Class76.smethod_3(gstruct42_, num18).ToLower();
									if (Class11.smethod_2(string_5, string_4[j].ToLower()) < 0)
									{
										num18++;
										continue;
									}
									goto IL_0638;
								}
							}
							break;
							IL_0638:
							if (!flag6)
							{
								flag6 = (string_4[j] == "200");
							}
							if (!flag5)
							{
								flag5 = (0 <= Class11.smethod_2(string_5, "Thñy TÆc".ToLower()));
							}
							Class76.smethod_6(gstruct42_, num18);
							Thread.Sleep(900);
							Class11.smethod_25(ref string_4, string_4[j]);
							flag4 = true;
						}
						while (!Class39.smethod_9(gstruct42_));
						while (true)
						{
							if (flag4)
							{
								Thread.Sleep(600);
								if (Class39.smethod_9(gstruct42_))
								{
									uint num19 = 3u;
									uint num20 = 12u;
									string string_6 = "LÖnh bµi Phong L\u00a8ng §é";
									if (!flag6)
									{
										if (flag5)
										{
											string_6 = "LÖnh Bµi Thñy TÆc";
										}
									}
									else
									{
										string_6 = text;
									}
									Class39.smethod_17(gstruct42_, num19, num20, string_6, 1, bool_0: false, bool_1: false, !flag6);
									Thread.Sleep(800);
									if (flag6)
									{
										num16 = Class69.smethod_28(gstruct42_, text, (int)num20, bool_1: true);
										if (num16 < 200)
										{
											continue;
										}
									}
									Class39.smethod_14(gstruct42_, bool_0: true);
								}
								Thread.Sleep(600);
							}
							else
							{
								Class76.smethod_9(gstruct42_);
								Thread.Sleep(1500);
								if (Class39.smethod_9(gstruct42_))
								{
									Class39.smethod_12(gstruct42_);
								}
							}
							break;
						}
						continue;
					}
					case 1:
						Class76.smethod_6(gstruct42_, 0);
						continue;
					case 0:
						break;
					}
					goto IL_0787;
				}
				if (!Class31.smethod_61(gstruct42_, 336))
				{
					break;
				}
				Thread.Sleep(300);
				continue;
			}
			Thread.Sleep(300);
			continue;
			IL_0787:
			Thread.Sleep(300);
			num++;
			if (num > 15)
			{
				Class53.smethod_10(gstruct42_);
			}
		}
		if (flag2)
		{
			Class76.smethod_9(gstruct42_);
			Class60.smethod_50(gstruct42_, "<bclr=blue><color=green>KÕt thóc lªn thuyÒn Phong L\u00a8ng ®é!");
			int num4 = Class71.smethod_3(FormMain.gstruct42_0, int_2);
			if (0 <= num4)
			{
				FormMain.gstruct42_0[num4].bool_21 = false;
			}
		}
	}
}
