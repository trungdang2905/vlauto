using System;
using System.Threading;

internal class Class65
{
	public static int int_0 = 0;

	public static int[] int_1 = null;

	private static int int_2 = 0;

	private static int int_3 = 0;

	private static int int_4 = 0;

	public static void smethod_0()
	{
		while (!Class11.bool_0)
		{
			Thread.Sleep(300);
			if (int_1 != null && FormMain.bool_2 && !FormMain.bool_0 && FormMain.int_3 <= FormMain.int_2)
			{
				if (int_2 <= 0 && int_3 <= 0 && Class83.int_0 <= 0 && Class45.int_0 <= 0 && Class52.int_0 <= 0 && Class51.int_1 <= 0 && Class92.int_0 <= 0 && Class29.int_7 <= 0 && Class29.int_2 <= 0 && Class29.int_3 <= 0 && Class29.int_8 <= 0 && Class80.int_2 <= 0)
				{
					try
					{
						int num = int_1[0];
						Class11.smethod_33(ref int_1, num);
						int_2 = num;
						int_3 = num;
						Class52.int_0 = num;
						Class51.int_1 = num;
						Class92.int_0 = num;
						Class83.int_0 = num;
						Class29.int_3 = num;
						Class29.int_2 = num;
						Class29.int_7 = num;
						Class29.int_8 = num;
						Class45.int_0 = num;
						Class80.int_2 = num;
						new Thread(smethod_2).Start();
						new Thread(smethod_1).Start();
						new Thread(Class83.smethod_0).Start();
						new Thread(Class45.smethod_0).Start();
						new Thread(Class52.smethod_0).Start();
						new Thread(Class51.smethod_1).Start();
						new Thread(Class92.smethod_0).Start();
						new Thread(Class29.smethod_19).Start();
						new Thread(Class29.smethod_5).Start();
						new Thread(Class29.smethod_3).Start();
						new Thread(Class29.smethod_21).Start();
						new Thread(Class80.smethod_2).Start();
					}
					catch
					{
					}
				}
			}
			else
			{
				Thread.Sleep(300);
			}
		}
	}

	private static void smethod_1()
	{
		int num = int_3;
		int_3 = 0;
		int num2 = 0;
		GStruct42 gStruct = default(GStruct42);
		bool flag = false;
		int num3 = 0;
		while (true)
		{
			try
			{
				num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
				if (Class11.bool_0 || num2 < 0 || !FormMain.gstruct42_0[num2].bool_36)
				{
					if (0 <= num2)
					{
						FormMain.gstruct42_0[num2].bool_39 = false;
					}
					return;
				}
				if (num3 > 0)
				{
					Class47.smethod_11(FormMain.gstruct42_0[num2]);
					num3 = 0;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num2].bool_39)
					{
						return;
					}
					FormMain.gstruct42_0[num2].bool_39 = true;
					flag = true;
				}
				FormMain.gstruct42_0[num2].bool_22 = false;
				FormMain.gstruct42_0[num2].int_125[0] = 0;
				FormMain.gstruct42_0[num2].bool_6 = false;
				gStruct = FormMain.gstruct42_0[num2];
				if (!gStruct.bool_4)
				{
					Class60.smethod_50(gStruct, "-------------------------------------------");
					Class60.smethod_50(gStruct, "<color=yellow>" + FormMain.string_1.ToUpper() + " FOR PRIVATE GAME");
					if (gStruct.int_21[0] > 0)
					{
						if (gStruct.int_21[1] > 0)
						{
							Class60.smethod_50(gStruct, "<bclr=blue><color=green>CHAY TIN SU PHONG KY");
							Class57.smethod_0(num);
						}
						else
						{
							Class60.smethod_50(gStruct, "<bclr=blue><color=green>CHAY TIN SU THIEN BAO KHO");
							Class57.smethod_7(num);
						}
						num3 = 1;
						Thread.Sleep(1000);
					}
					else if (gStruct.int_126[0] > 0)
					{
						Class60.smethod_50(gStruct, "<bclr=blue><color=green>SAN BOSS SAT THU");
						Class88.smethod_0(num);
						num3 = 1;
					}
					else if (gStruct.bool_60)
					{
						Class60.smethod_50(gStruct, "<bclr=blue><color=green>VAN SU THONG");
						Class61.smethod_0(num);
					}
					else if (!gStruct.bool_61)
					{
						if (gStruct.int_26 <= 0)
						{
							if (FormMain.int_20 == 0)
							{
								Class60.smethod_50(gStruct, "<bclr=blue><color=green>WAR (PK -SAN BOSS)");
								Class48.smethod_0(num);
							}
							else if (FormMain.int_20 == 1)
							{
								Class60.smethod_50(gStruct, "<bclr=blue><color=green>TONG KIM - PHONG HOA LIEN THANH");
								Class54.smethod_0(num);
							}
							else
							{
								if (FormMain.int_20 == 2)
								{
									Class60.smethod_50(gStruct, "<bclr=blue><color=green>CHIEN TRUONG CONG THANH CHIEN");
									Class70.smethod_0(num);
								}
								if (FormMain.int_20 == 3)
								{
									Class60.smethod_50(gStruct, "<bclr=blue><color=green>CHE DO DON DAU");
									Class60.smethod_50(gStruct, "<bclr=blue><color=green>ChÕ ®é nµy chØ ®\u00b8nh vµ b¬m m\u00b8u");
									Class56.smethod_0(num);
								}
							}
						}
						else
						{
							Class60.smethod_50(gStruct, "<bclr=blue><color=green>TRAIN (" + Class33.smethod_1(gStruct.int_33) + ")");
							Class6.smethod_0(num);
						}
					}
					else
					{
						Class60.smethod_50(gStruct, "<bclr=blue><color=green>LEN VI SON DAO");
						Class75.smethod_0(num);
					}
				}
				else
				{
					Thread.Sleep(100);
				}
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_2()
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
						FormMain.gstruct42_0[num].bool_38 = false;
						GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
						Class60.smethod_50(gstruct42_, "-------------------------------------------");
						Class60.smethod_50(gstruct42_, "<color=yellow>" + FormMain.string_1.ToUpper() + " FOR PRIVATE GAME");
						Class60.smethod_50(gstruct42_, "<color=green>§­îc viÕt bëi: Kim YÕn");
						Class60.smethod_50(gstruct42_, "<color=green>Webs: http://kimyen.net");
						Class60.smethod_50(gstruct42_, "<color=green>HoÆc: http://vltool.blogspot.com");
						Class60.smethod_50(gstruct42_, "-------------------------------------------");
						Class60.smethod_50(gstruct42_, "KET THUC AUTO.");
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_38)
					{
						return;
					}
					flag = true;
					FormMain.gstruct42_0[num].bool_38 = true;
					Class11.smethod_24(ref Class11.string_14, "[" + Class10.smethod_1(FormMain.gstruct42_0[num].string_20, 1) + "] đang chạy.");
				}
				smethod_3(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_3(int int_5)
	{
		GStruct42 gStruct = default(GStruct42);
		int int_6 = 0;
		byte[] byte_ = new byte[4];
		byte[] array = new byte[4];
		long num = -1L;
		long long_ = 0L;
		long num2 = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		long long_5 = 0L;
		long long_6 = 0L;
		long long_7 = 0L;
		long long_8 = 0L;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = true;
		int num3 = 0;
		int num4 = 0;
		int num5 = -1;
		int num6 = -1;
		int num7 = 0;
		int num8 = -1;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		long[] array2 = new long[3];
		long[] array3 = array2;
		GStruct46[] gstruct46_ = null;
		int num12;
		while (true)
		{
			Thread.Sleep(200);
			num12 = Class71.smethod_3(FormMain.gstruct42_0, int_5);
			if (Class11.bool_0 || num12 < 0 || !FormMain.gstruct42_0[num12].bool_36)
			{
				return;
			}
			if (flag2)
			{
				FormMain.gstruct42_0[num12].gstruct40_0 = gStruct.gstruct40_0;
				flag2 = false;
			}
			gStruct = FormMain.gstruct42_0[num12];
			uint num13 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
			uint num14 = Class20.smethod_30(num13 + Class47.gstruct43_13.uint_0, gStruct.int_130);
			uint num15 = num14 * Class47.gstruct43_15.uint_0;
			uint num16 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
			uint num17 = num16 + num15;
			int num18 = (int)Class20.smethod_30(num17 + Class47.gstruct43_55.uint_0, gStruct.int_130);
			int num19 = (int)Class20.smethod_30(num17 + Class47.gstruct43_50.uint_0, gStruct.int_130);
			if (num19 > 0 && num18 > 0 && Class11.smethod_23(long_2) > num3)
			{
				int num20;
				if (GClass1.string_2 != null && !(GClass1.string_2 == string.Empty))
				{
					if (!flag)
					{
						if (FormMain.bool_0 || FormMain.int_3 > FormMain.int_2)
						{
							break;
						}
						goto IL_021c;
					}
					num20 = 1;
				}
				else
				{
					num20 = 0;
				}
				if (num20 == 0)
				{
					break;
				}
				goto IL_021c;
			}
			goto IL_03a5;
        IL_021c:
            int num21 = 1;// GClass1.smethod_5(gStruct);
			if (num21 <= 0)
			{
				if ((flag || num4 <= 1) && num4 <= 3)
				{
					num4++;
					num3 = 3000;
					goto IL_039e;
				}
				num12 = Class71.smethod_3(FormMain.gstruct42_0, int_5);
				if (0 <= num12)
				{
					FormMain.gstruct42_0[num12].bool_36 = false;
				}
				if (num21 == -10)
				{
					Class60.smethod_50(gStruct, Class11.char_32);
				}
				else 
                if (num21 >= 0)
				{
					Class60.smethod_50(gStruct, Class11.char_38);
				}
				else
				{
					Class60.smethod_50(gStruct, Class11.char_39);
				}
				return;
			}
			if (!flag)
			{
				Class60.smethod_50(gStruct, Class11.smethod_1(Class11.char_41));
				if (FormMain.int_17 > 0 || FormMain.int_6 > 0 || FormMain.int_7 > 0)
				{
					Class60.smethod_14(gStruct, FormMain.int_18 > 0);
				}
			}
			num3 = 180000;
			if (num21 > 1 && GClass1.gstruct13_0.uint_1 != null)
			{
				GStruct24[] array4 = Class42.smethod_0(new int[1]
				{
					gStruct.int_129
				});
				if (array4 != null)
				{
					int num22 = 0;
					int num23 = 0;
					while (true)
					{
						if (num23 < array4.Length)
						{
							string string_ = array4[num23].string_2;
							if (string_ != null && !(string_ == string.Empty))
							{
								uint num24 = Class11.smethod_7(string_.Replace(" ", string.Empty));
								if (num24 != 0)
								{
									int num25 = 0;
									while (num25 < GClass1.gstruct13_0.uint_1.Length)
									{
										if (num24 != GClass1.gstruct13_0.uint_1[num25])
										{
											num25++;
											continue;
										}
										goto IL_0398;
									}
									num22++;
								}
							}
							num23++;
							continue;
						}
						if (num22 <= 0)
						{
							break;
						}
						num12 = Class71.smethod_3(FormMain.gstruct42_0, int_5);
						if (0 <= num12)
						{
							FormMain.gstruct42_0[num12].bool_36 = false;
						}
						Class60.smethod_50(gStruct, Class11.smethod_1(Class11.char_40));
						return;
					}
				}
				else
				{
					num3 = 3000;
				}
			}
			goto IL_0398;
			IL_039e:
			long_2 = Class11.smethod_22();
			goto IL_03a5;
			IL_03a5:
			if (flag && Class47.int_0 > 0 && !FormMain.bool_1 && (!Class26.bool_0 || Class11.long_0 < GClass1.long_1))
			{
				Class20.smethod_5(Class11.smethod_1(Class11.char_42));
			}
			int num26 = Class73.smethod_40(gStruct);
			uint num49;
			uint[] uint_2;
			uint num50;
			if (num19 != 0 && num18 != 0 && num18 != 10 && num18 != 21 && num26 > 1)
			{
				num7 = 0;
				num2 = 0L;
				if (!flag4)
				{
					int num27 = (int)Class20.smethod_30(num17 + Class47.gstruct43_43.uint_0, gStruct.int_130);
					int num28 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
					if (num6 != num27)
					{
						for (int num23 = 0; num23 < array3.Length; num23++)
						{
							array3[num23] = 0L;
						}
						if (Class53.smethod_7(num28) == null)
						{
							flag3 = true;
							long_6 = Class11.smethod_22();
						}
						num6 = num27;
						num = -1L;
						Class60.smethod_2(gStruct, Class60.uint_13, 0, 4);
					}
					if (num5 != num28)
					{
						for (int num23 = 0; num23 < array3.Length; num23++)
						{
							array3[num23] = 0L;
						}
						flag3 = true;
						flag6 = true;
						long_6 = Class11.smethod_22();
						long_8 = Class11.smethod_22();
						num5 = num28;
						num = -1L;
					}
					if ((flag6 && (flag7 || Class11.smethod_23(long_8) > 10000L)) || num9 > 4)
					{
						int num29 = 0;
						int num30 = 0;
						gstruct46_ = Class69.smethod_38(gStruct, ref num29, ref num30);
						FormMain.gstruct42_0[num12].bool_63 = (num30 > 0);
						FormMain.gstruct42_0[num12].bool_64 = (num29 > 0);
						Class60.smethod_2(gStruct, Class60.uint_7, (byte)num30, 4);
						num9 = 0;
						flag6 = false;
						flag7 = false;
					}
					if (gStruct.int_11 > 0 && !gStruct.bool_7 && FormBanEvent.int_0 <= 0)
					{
						FormBanEvent.int_0 = int_5;
						new Thread(FormBanEvent.smethod_2).Start();
						Thread.Sleep(300);
					}
					if ((FormMain.int_6 > 0 || FormMain.int_7 > 0) && (FormMain.int_52 <= 0 || Class38.gstruct29_0.int_0 <= 0))
					{
						if (FormMain.int_6 <= 0 && FormMain.int_7 > 0)
						{
							FormMayphu.smethod_2(gStruct);
						}
						if (Class38.gstruct29_1.int_9 > 0)
						{
							Class38.smethod_7(Class38.gstruct29_1.int_9);
							Class38.gstruct29_1.int_9 = 0;
						}
						if (Class11.smethod_23(long_3) > 30000L)
						{
							Class73.smethod_32(gStruct, 0u);
							long_3 = Class11.smethod_22();
						}
					}
					int num31 = Class69.smethod_2(gStruct);
					if (gStruct.int_74 != null && gStruct.int_74[0] > 0 && Class11.smethod_23(long_4) > 1000L)
					{
						if (num8 < num31)
						{
							Class29.smethod_11(gStruct);
							long_4 = Class11.smethod_22();
						}
						num8 = num31;
					}
					if (Class11.smethod_23(long_) > 90000L)
					{
						num9++;
						long_ = Class11.smethod_22();
						num12 = Class71.smethod_3(FormMain.gstruct42_0, int_5);
						if (num12 < 0)
						{
							return;
						}
						gStruct = FormMain.gstruct42_0[num12];
						Class60.smethod_2(gStruct, 0u, 0, 4);
						Class60.smethod_2(gStruct, Class60.uint_5, 0, 4);
						Class60.smethod_2(gStruct, Class60.uint_6, 0, 4);
						Class60.smethod_2(gStruct, Class60.uint_13, 0, 4);
						FormMain.gstruct42_0[num12].string_18 = Class23.smethod_3(gStruct);
						Class31.bool_0 = false;
						if (gStruct.string_21 == "NGAMY")
						{
							int num32 = 0;
							int num33 = 0;
							if (gStruct.int_97[6] > 0)
							{
								num32 = 1114 * Convert.ToByte(Class67.smethod_15(gStruct, 1114u) > 0);
								num33 = 470;
							}
							if (num32 == 0)
							{
								num32 = 93 * Convert.ToByte(Class67.smethod_15(gStruct, 93u) > 0);
								num33 = 400;
							}
							FormMain.gstruct42_0[num12].int_97[1] = num32;
							FormMain.gstruct42_0[num12].int_97[5] = num33;
						}
						if (!gStruct.bool_65 && gStruct.string_21 == "VODANG")
						{
							int num34 = Class67.smethod_15(gStruct, 716u);
							FormMain.gstruct42_0[num12].bool_65 = (num34 > 0);
							if (num34 < 1)
							{
								num34 = 1;
							}
							else if (Class47.int_3.Length < num34)
							{
								num34 = Class47.int_3.Length;
							}
							FormMain.gstruct42_0[num12].long_7 = Class47.int_3[num34 - 1];
						}
						if (!gStruct.bool_66 && gStruct.string_21 == "THIENNHAN")
						{
							int num34 = Class67.smethod_15(gStruct, 715u);
							FormMain.gstruct42_0[num12].bool_66 = (num34 > 0);
							if (num34 < 1)
							{
								num34 = 1;
							}
							else if (Class47.int_4.Length < num34)
							{
								num34 = Class47.int_4.Length;
							}
							FormMain.gstruct42_0[num12].long_7 = Class47.int_4[num34 - 1];
						}
						if (!(gStruct.string_21 == "THIENNHAN") && !(gStruct.string_21 == "NGUDOC") && !(gStruct.string_21 == "CONLON") && gStruct.int_116 > 0)
						{
							FormMain.gstruct42_0[num12].int_116 = 0;
						}
						if (gStruct.int_3 != null)
						{
							for (int num23 = 0; num23 < gStruct.int_3.Length; num23++)
							{
								if (Class67.smethod_15(gStruct, (uint)gStruct.int_3[num23]) <= 0)
								{
									FormMain.gstruct42_0[num12].int_3[num23] = 0;
								}
							}
							if (gStruct.int_4 == null)
							{
								gStruct.int_4 = Class47.smethod_15(gStruct.string_21);
							}
						}
						if (gStruct.int_82 > 0 && gStruct.string_21 == "CONLON" && !gStruct.bool_28 && Class84.int_0 <= 0)
						{
							Class84.int_0 = gStruct.int_129;
							new Thread(Class84.smethod_0).Start();
							Thread.Sleep(300);
						}
					}
					if (FormMain.int_20 == 0)
					{
						Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_56.uint_0, array, 4, ref int_6);
						int num35 = BitConverter.ToInt32(array, 0);
						int num36 = Class60.smethod_3(gStruct, Class60.uint_12);
						int num37;
						if (num36 <= 0)
						{
							if (num27 > 0 && !gStruct.bool_33)
							{
								if (FormMain.int_21 > 0 && FormMain.int_79 > 0)
								{
									uint[] uint_ = new uint[2]
									{
										Class20.smethod_30(num17 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
										Class20.smethod_30(num17 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
									};
									num37 = -1;
									bool flag8 = (FormMain.int_6 > 0 || FormMain.int_7 > 0) && Class38.gstruct29_1.int_4 == num28 && Class11.smethod_57(Class38.gstruct29_1.uint_4) && Class53.smethod_18(uint_, Class38.gstruct29_1.uint_4) < 1000000L;
									bool flag9 = FormMain.int_6 <= 0 && FormMain.int_7 <= 0 && Class38.gstruct29_0.int_4 == num28 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_0 != gStruct.int_129 && Class11.smethod_57(Class38.gstruct29_0.uint_4) && Class53.smethod_18(uint_, Class38.gstruct29_0.uint_4) < 1000000L;
									if (flag8 && num35 != Class38.gstruct29_1.int_2)
									{
										num37 = Class38.gstruct29_1.int_2;
									}
									else if (flag9 && num35 != Class38.gstruct29_0.int_2)
									{
										num37 = Class38.gstruct29_0.int_2;
									}
									else if (!flag8 && !flag9 && num35 > 0 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_0 != gStruct.int_129)
									{
										num37 = num35 - 1;
									}
									if (num37 > 0 || (num37 == 0 && Class11.smethod_23(long_5) > 3000L))
									{
										if (num37 < num35)
										{
											num37 = num35 - 1;
										}
										Class60.smethod_55(gStruct, "Switch([[pk]]," + num37 + ")");
										if (num35 == 1)
										{
											long_5 = Class11.smethod_22();
										}
									}
								}
							}
							else if (num35 > 0 && Class11.smethod_23(long_5) > 5000L)
							{
								Class60.smethod_55(gStruct, "Switch([[pk]]," + (num35 - 1) + ")");
								long_5 = Class11.smethod_22();
							}
						}
						else
						{
							Class60.smethod_2(gStruct, Class60.uint_12, 0, 4);
							if (num35 < 2)
							{
								Class60.smethod_55(gStruct, "Switch([[pk]],2)");
								long_5 = Class11.smethod_22();
							}
						}
						num37 = -1;
					}
					if (flag3 && Class11.smethod_23(long_6) > 3000L)
					{
						if (gStruct.int_131[0] > 0 && gStruct.int_131[1] > 0)
						{
							int num32 = Class32.smethod_32(gStruct);
							if (num32 != gStruct.int_131[1])
							{
								Class67.smethod_14(gStruct, (uint)gStruct.int_131[1]);
								Class60.smethod_29(gStruct, (uint)gStruct.int_131[1]);
								Thread.Sleep(300);
							}
						}
						if (gStruct.int_132[0] > 0 && gStruct.int_132[1] > 0)
						{
							int num32 = Class32.smethod_33(gStruct);
							if (num32 != gStruct.int_132[1])
							{
								Class67.smethod_14(gStruct, (uint)gStruct.int_132[1], bool_1: true);
								Class60.smethod_30(gStruct, (uint)gStruct.int_132[1]);
								Thread.Sleep(300);
							}
						}
						flag3 = false;
					}
					if (FormMain.int_55 > 0 && (FormMain.int_59 > 0 || num27 > 0))
					{
						if (num <= 0L)
						{
							num = DateTime.Now.Ticks - FormMain.int_78 * 1000 + 3000L;
						}
						if (Class11.smethod_23(num) >= FormMain.int_78 * 1000 && Class60.smethod_3(gStruct, Class60.uint_5) <= 0)
						{
							int num38 = 0;
							uint num39 = 0u;
							while (true)
							{
								Class60.smethod_2(gStruct, Class60.uint_5, 1, 4);
								GStruct28[] array5 = Class53.smethod_12(gStruct, gstruct46_, FormMain.int_60[0], FormMain.int_60[1]);
								if (num38 > 0)
								{
									long num40 = Class32.smethod_42(gStruct) - num39;
									if (num40 > 0L)
									{
										Class60.smethod_36(gStruct, (uint)num40);
										Thread.Sleep(100);
									}
								}
								Class60.smethod_2(gStruct, Class60.uint_5, 0, 4);
								Class60.smethod_2(gStruct, Class60.uint_14, 0, 4);
								num = Class11.smethod_22();
								if (array5 == null)
								{
									break;
								}
								Class60.smethod_50(gStruct, "<color=yellow>[ Trang bi do ben thap can sua chua ]");
								Class32.smethod_51(gStruct, "[ Trang bi do ben thap can sua chua ]");
								if (FormMain.int_77 > 0)
								{
									if ((!gStruct.bool_63 || !Class31.smethod_61(gStruct, "Ph­îng T­êng", "trung t©m")) && !Class53.smethod_13(gStruct) && FormMain.int_75 > 0)
									{
										Class11.smethod_24(ref Class11.string_14, "FORM:Nhân vật [" + Class10.smethod_1(gStruct.string_20, 1) + "] đã thoát do có trang bị độ bền <= " + FormMain.int_76 + ", hãy nhanh chóng sửa chữa.");
										Class20.smethod_53(gStruct.process_0);
									}
									int num41 = 0;
									while (!Class11.bool_0 && num41 < 10)
									{
										num41++;
										Thread.Sleep(150);
										num13 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
										num14 = Class20.smethod_30(num13 + Class47.gstruct43_13.uint_0, gStruct.int_130);
										num15 = num14 * Class47.gstruct43_15.uint_0;
										num16 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
										num17 = num16 + num15;
										num19 = (int)Class20.smethod_30(num17 + Class47.gstruct43_50.uint_0, gStruct.int_130);
										num27 = (int)Class20.smethod_30(num17 + Class47.gstruct43_43.uint_0, gStruct.int_130);
										Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_6);
										num28 = BitConverter.ToInt32(array, 0);
										if (num19 > 0 && num28 > 0 && num27 <= 0)
										{
											num41 = -1;
											break;
										}
									}
									if (num41 == -1)
									{
										if (num38 < 1)
										{
											Class60.smethod_2(gStruct, Class60.uint_14, 1, 4);
											Thread.Sleep(600);
											num38++;
											num39 = Class32.smethod_42(gStruct);
											uint num42 = Class32.smethod_42(gStruct, bool_0: true);
											if (num42 != 0)
											{
												Class60.smethod_35(gStruct, num42);
												Thread.Sleep(150);
											}
											continue;
										}
										num12 = Class71.smethod_3(FormMain.gstruct42_0, int_5);
										if (0 <= num12)
										{
											FormMain.gstruct42_0[num12].bool_36 = false;
										}
									}
								}
								num = DateTime.Now.Ticks - 50000L;
								break;
							}
						}
					}
					if (num27 > 0)
					{
						if (Class11.smethod_23(long_7) >= 600L)
						{
							num10++;
							num11 = 0;
							switch (num10)
							{
							case 2:
								if (gStruct.int_140[0] > 0 && gStruct.int_140[1] > 0 && Class11.smethod_23(array3[1]) > gStruct.int_140[2])
								{
									num11 = gStruct.int_140[1];
									array3[1] = Class11.smethod_22();
								}
								break;
							case 3:
								if (num10 == 3 && gStruct.int_141[0] > 0 && gStruct.int_141[1] > 0 && Class11.smethod_23(array3[2]) > gStruct.int_141[2])
								{
									num11 = gStruct.int_141[1];
									array3[2] = Class11.smethod_22();
								}
								break;
							default:
								if (gStruct.int_139[0] > 0 && gStruct.int_139[1] > 0 && Class11.smethod_23(array3[0]) > gStruct.int_139[2])
								{
									num11 = gStruct.int_139[1];
									array3[0] = Class11.smethod_22();
								}
								num10 = 1;
								break;
							}
							if (num11 > 0)
							{
								int num43 = 0;
								int num44 = 0;
								byte[] array6 = new byte[4];
								byte[] byte_2 = new byte[4];
								byte[] byte_3 = new byte[4];
								for (int i = 0; i < 80; i++)
								{
									if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
									{
										break;
									}
									Thread.Sleep(10);
								}
								Class60.smethod_2(gStruct, Class60.uint_6, 1, 4);
								Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_31.uint_0, byte_2, 4, ref int_6);
								Class20.ReadProcessMemory(gStruct.int_130, num13 + Class47.gstruct43_12.uint_0 + Class47.gstruct43_68.uint_0, byte_3, 4, ref int_6);
								Thread.Sleep(100);
								int num45 = 0;
								while (true)
								{
									if (num43 >= 200 || num44 >= 10)
									{
										Thread.Sleep(10);
										Class32.smethod_10(gStruct, num11);
										num43 = 0;
										while (num43 < 80 && num11 > 0)
										{
											num43++;
											Thread.Sleep(10);
											for (uint num46 = 0u; num46 < 6; num46++)
											{
												uint num47 = Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0 + Class47.gstruct43_2.uint_0 * num46;
												Class20.ReadProcessMemory(gStruct.int_130, num17 + num47, array6, 4, ref int_6);
												int num48 = BitConverter.ToInt32(array6, 0);
												if (num48 > 0 && Class67.smethod_1(num48) == num11)
												{
													num11 = 0;
													break;
												}
											}
										}
										if (num11 <= 0 || num45 != 0)
										{
											break;
										}
										num45 = 1;
									}
									else
									{
										num43++;
										Class20.WriteProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
										Thread.Sleep(1);
										Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_55.uint_0, array6, 1, ref int_6);
										num44 = ((array6[0] <= 4) ? (num44 + 1) : 0);
									}
								}
								Thread.Sleep(230);
								Class20.WriteProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_31.uint_0, byte_2, 4, ref int_6);
								Class20.WriteProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_157.uint_0 - 8, byte_3, 4, ref int_6);
								Class20.WriteProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_35.uint_0, byte_, 4, ref int_6);
								Class60.smethod_2(gStruct, Class60.uint_6, 0, 4);
								long_7 = Class11.smethod_22();
							}
						}
						num49 = num13 + Class47.gstruct43_30.uint_0;
						if (FormMain.int_14 > 0 || FormMain.int_16 > 0)
						{
							if (gStruct.gstruct40_0.uint_0 != 0 && gStruct.gstruct40_0.int_0 > 0)
							{
								num50 = 0u;
								int num51 = 0;
								uint_2 = new uint[2]
								{
									Class20.smethod_30(num17 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
									Class20.smethod_30(num17 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
								};
								if (gStruct.string_16 != null)
								{
									if (FormMayphu.bool_2)
									{
										int[] array7 = Class50.smethod_0(num28);
										if (array7 != null)
										{
											if (!flag5)
											{
												Class60.smethod_53(gStruct, "<color=green>ChÕ ®é cõu s\u00b8t trong Tèng Kim ®· bÞ t¾t bëi adgame.");
												flag5 = true;
											}
											goto IL_1794;
										}
										flag5 = false;
									}
									int num52 = 0;
									while (num52 < gStruct.string_16.Length)
									{
										if (gStruct.gstruct40_0.string_0 != gStruct.string_16[num52])
										{
											num52++;
											continue;
										}
										goto IL_1662;
									}
								}
							}
							goto IL_1794;
						}
						goto IL_19fb;
					}
					flag2 = (gStruct.gstruct40_0.uint_0 != 0 || gStruct.gstruct40_0.int_0 > 0);
					gStruct.gstruct40_0.uint_0 = 0u;
					gStruct.gstruct40_0.int_0 = 0;
					for (int num23 = 0; num23 < array3.Length; num23++)
					{
						array3[num23] = 0L;
					}
					Thread.Sleep(100);
					continue;
				}
				flag4 = false;
				Thread.Sleep(300);
				if (Class76.smethod_0(gStruct) || Class76.Class79.smethod_4(gStruct))
				{
					Class76.smethod_9(gStruct);
				}
				continue;
			}
			Class12.smethod_3(gStruct, bool_0: false);
			num7++;
			if (num7 < 4)
			{
				Thread.Sleep(100);
				continue;
			}
			flag4 = true;
			if (num26 > 1)
			{
				long num53 = Class11.smethod_23(num2);
				if (gStruct.int_91 <= 0 && (FormMain.int_38 <= 0 || FormMain.int_37 <= 0) && num53 > 10000L)
				{
					Class20.smethod_4(gStruct.uint_4, 32u);
					Thread.Sleep(300);
					if (num2 > 0L && num53 > 15000L)
					{
						Class60.smethod_104(gStruct);
					}
					if (Class76.smethod_0(gStruct))
					{
						Class76.smethod_9(gStruct);
					}
				}
				num6 = -1;
			}
			else
			{
				Thread.Sleep(300);
				num2 = Class11.smethod_22();
				long_8 = Class11.smethod_22();
				flag6 = true;
			}
			continue;
			IL_1794:
			uint num54 = Class20.smethod_30(num49 + Class47.gstruct43_61.uint_0, gStruct.int_130);
			if (num54 != gStruct.gstruct40_0.uint_0 || gStruct.gstruct40_0.int_0 <= 0)
			{
				if (gStruct.gstruct40_0.uint_0 != num54 && num54 == 0)
				{
					Class60.smethod_50(gStruct, "<color=yellow>KÕt thóc cõu s\u00b8t");
					gStruct.gstruct40_0.uint_0 = num54;
					num12 = Class71.smethod_3(FormMain.gstruct42_0, int_5);
					if (num12 < 0)
					{
						return;
					}
					FormMain.gstruct42_0[num12].gstruct40_0 = gStruct.gstruct40_0;
				}
				else
				{
					gStruct.gstruct40_0.uint_0 = num54;
					if (num54 != 0)
					{
						gStruct.gstruct40_0.int_0 = Class32.smethod_7(gStruct, num54);
						num50 = (uint)((int)num16 + gStruct.gstruct40_0.int_0 * (int)Class47.gstruct43_15.uint_0);
						if (Class20.smethod_30(num50 + Class47.gstruct43_50.uint_0, gStruct.int_130) != 0)
						{
							gStruct.gstruct40_0.uint_2 = Class20.smethod_30(num49 + Class47.gstruct43_62.uint_0, gStruct.int_130);
							gStruct.gstruct40_0.string_0 = Class20.smethod_28(num49 + Class47.gstruct43_60.uint_0, gStruct.int_130, 16);
							string text = Class32.string_1[Convert.ToByte(gStruct.gstruct40_0.uint_2 == 2)];
							if (FormMain.int_16 > 0)
							{
								Class60.smethod_55(gStruct, Class32.string_2[0].Replace("XXX", gStruct.gstruct40_0.string_0).Replace("YYY", text));
								Thread.Sleep(100);
							}
							if (FormMain.int_14 > 0)
							{
								Class60.smethod_50(gStruct, "<color=green>" + gStruct.gstruct40_0.string_0 + "<color=white> " + text + " <color=red>cõu s\u00b8t<color=white> víi b¹n.");
								Thread.Sleep(100);
							}
							if (FormMain.int_15 > 0)
							{
								Class60.smethod_55(gStruct, Class32.string_3.Replace("XXX", gStruct.gstruct40_0.string_0).Replace("YYY", text));
								Thread.Sleep(100);
							}
						}
					}
				}
			}
			flag2 = true;
			goto IL_19fb;
			IL_0398:
			num4 = 0;
			flag = true;
			goto IL_039e;
			IL_1662:
			long num55 = 0L;
			num50 = (uint)((int)num16 + gStruct.gstruct40_0.int_0 * (int)Class47.gstruct43_15.uint_0);
			if (Class20.smethod_30(num50 + Class47.gstruct43_50.uint_0, gStruct.int_130) == 0 || Class20.smethod_28(num49 + Class47.gstruct43_60.uint_0, gStruct.int_130, 18) != gStruct.gstruct40_0.string_0)
			{
				gStruct.gstruct40_0.int_0 = Class32.smethod_7(gStruct, gStruct.gstruct40_0.uint_0);
				if (gStruct.gstruct40_0.int_0 == 0)
				{
					goto IL_19fb;
				}
			}
			uint[] uint_3 = new uint[2]
			{
				Class20.smethod_30(num50 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
				Class20.smethod_30(num50 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
			};
			switch (Class53.smethod_18(uint_2, uint_3))
			{
			}
			goto IL_1794;
			IL_19fb:
			if (gStruct.int_117 > 0 && int_4 <= 0 && !gStruct.bool_35)
			{
				int_4 = int_5;
				new Thread(smethod_4).Start();
			}
		}
		num12 = Class71.smethod_3(FormMain.gstruct42_0, int_5);
		if (0 <= num12)
		{
			FormMain.gstruct42_0[num12].bool_36 = false;
		}
		Class60.smethod_50(gStruct, Class10.smethod_2(Class11.smethod_1(Class11.char_37)));
	}

	private static void smethod_4()
	{
		int num = int_4;
		long long_ = 0L;
		GStruct42 gstruct42_ = default(GStruct42);
		while (true)
		{
			try
			{
				Thread.Sleep(500);
				int num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
				if (num2 < 0)
				{
					return;
				}
				if (Class11.bool_0 || !FormMain.gstruct42_0[num2].bool_36 || FormMain.gstruct42_0[num2].int_117 <= 0)
				{
					FormMain.gstruct42_0[num2].bool_35 = false;
					Class60.smethod_50(gstruct42_, "<color=yellow>Cõu s\u00b8t theo danh s\u00b8ch: <color=green>T¾t");
					return;
				}
				gstruct42_ = FormMain.gstruct42_0[num2];
				if (!gstruct42_.bool_35 || int_4 > 0)
				{
					Class60.smethod_50(gstruct42_, "<color=yellow>Cõu s\u00b8t theo danh s\u00b8ch: <color=green>BËt");
					FormMain.gstruct42_0[num2].bool_35 = true;
					int_4 = 0;
				}
				if (gstruct42_.string_16 != null && gstruct42_.string_16.Length != 0)
				{
					uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
					uint num4 = num3 + Class47.gstruct43_30.uint_0;
					uint num5 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gstruct42_.int_130);
					uint num6 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
					uint num7 = num6 + num5 * Class47.gstruct43_15.uint_0;
					int num8 = (int)Class20.smethod_30(num7 + Class47.gstruct43_43.uint_0, gstruct42_.int_130);
					int num9 = (int)Class20.smethod_30(num7 + Class47.gstruct43_55.uint_0, gstruct42_.int_130);
					int num10 = (int)Class20.smethod_30(num7 + Class47.gstruct43_50.uint_0, gstruct42_.int_130);
					if (num8 > 0 && num10 != 0 && num9 != 0 && num9 != 10 && num9 != 21)
					{
						if (Class11.smethod_23(long_) > 1500L)
						{
							string text = Class7.smethod_7(gstruct42_);
							if (text != null)
							{
								gstruct42_.gstruct40_0.uint_2 = Class20.smethod_30(num4 + Class47.gstruct43_62.uint_0, gstruct42_.int_130);
								if (gstruct42_.gstruct40_0.uint_2 < 2)
								{
									Class60.smethod_55(gstruct42_, "Revenge('" + text + "')");
									Thread.Sleep(300);
									long_ = Class11.smethod_22();
								}
							}
						}
					}
					else
					{
						Thread.Sleep(600);
					}
				}
			}
			catch
			{
			}
		}
	}
}
