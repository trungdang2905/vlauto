using System;
using System.Threading;

internal class Class48
{
	public static void smethod_0(int int_0)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool bool_ = false;
		bool bool_2 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		int num4 = -1;
		int num5 = 0;
		int num6 = 0;
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		long long_5 = 0L;
		GStruct22 gstruct22_ = default(GStruct22);
		int int_ = -1;
		uint[] uint_ = null;
		uint[] uint_2 = null;
		new Random();
		GStruct42 gStruct = default(GStruct42);
		uint num7 = 0u;
		uint uint_3 = 0u;
		uint[] uint_4 = null;
		int int_2 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int int_3 = 0;
		long num12 = 0L;
		long num13 = 0L;
		long long_6 = 0L;
		long long_7 = 0L;
		int num14 = 0;
		int num15 = -1;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		int int_4 = 0;
		int int_5 = 0;
		bool flag7 = false;
		uint[] array = null;
		bool flag8 = false;
		bool flag9 = false;
		bool flag10 = false;
		bool flag11 = false;
		int num19 = 0;
		int num20 = 0;
		int num21 = 0;
		int num22 = 0;
		int num23 = 0;
		int[] array2 = new int[5];
		int int_6 = 0;
		byte[] byte_ = new byte[4];
		byte[] array3 = new byte[4];
		int int_7 = -1;
		int num24 = 0;
		while (true)
		{
			Thread.Sleep(200);
			num19 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (Class11.bool_0 || num19 < 0 || FormMain.int_20 != 0)
			{
				break;
			}
			gStruct = FormMain.gstruct42_0[num19];
			if (!gStruct.bool_36 || gStruct.int_21[0] > 0 || gStruct.int_126[0] > 0 || gStruct.bool_60 || gStruct.int_26 > 0 || gStruct.bool_61)
			{
				break;
			}
			uint num29;
			int num39;
			bool flag13;
			bool flag14;
			bool flag15;
			int num42;
			uint num55;
			uint[] uint_5;
			uint[] array8;
			bool flag16;
			bool flag17;
			int num32;
			bool flag20;
			bool flag21;
			bool flag24;
			uint num28;
			int[] array11;
			long num44;
			int[] array15;
			int num70;
			int num33;
			uint[] array4;
			int num40;
			if (!gStruct.bool_21 && !gStruct.bool_14 && !gStruct.bool_6)
			{
				if (gStruct.bool_0)
				{
					continue;
				}
				if (gStruct.bool_27)
				{
					FormMain.gstruct42_0[num19].bool_27 = false;
					flag3 = false;
				}
				if (Class38.bool_0 && gStruct.bool_37)
				{
					FormMain.gstruct42_0[num19].bool_37 = false;
					Class12.smethod_3(gStruct, bool_0: false);
				}
				if (gStruct.int_125[0] > 0 && !gStruct.bool_52 && Class87.int_0 <= 0)
				{
					Class87.int_0 = int_0;
					new Thread(Class87.smethod_0).Start();
					Thread.Sleep(300);
				}
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array3, 4, ref int_6);
				uint num25 = BitConverter.ToUInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_13.uint_0, array3, 4, ref int_6);
				uint num26 = BitConverter.ToUInt32(array3, 0);
				uint num27 = num26 * Class47.gstruct43_15.uint_0;
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array3, 4, ref int_6);
				num28 = BitConverter.ToUInt32(array3, 0);
				num29 = num28 + num27;
				Class20.ReadProcessMemory(gStruct.int_130, num29, array3, 4, ref int_6);
				num7 = BitConverter.ToUInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_55.uint_0, array3, 4, ref int_6);
				int num30 = BitConverter.ToInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_50.uint_0, array3, 4, ref int_6);
				int num31 = BitConverter.ToInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array3, 4, ref int_6);
				num32 = BitConverter.ToInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_43.uint_0, array3, 4, ref int_6);
				num33 = BitConverter.ToInt32(array3, 0);
				int num34 = Class73.smethod_12(gStruct);
				if (gStruct.int_129 == Class66.gstruct42_0.int_129 || gStruct.int_129 == Class38.gstruct29_0.int_0)
				{
					switch (num34)
					{
					case 2:
						Thread.Sleep(80);
						continue;
					case 1:
						if (num21 > 0 || (num23 > 1 && num33 > 0))
						{
							Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
							num21 = 0;
						}
						if (num23 > 3)
						{
							num22 = 0;
						}
						num23++;
						continue;
					}
				}
				if (num22 <= 0)
				{
					array2[0] = 0;
					array2[1] = 0;
					array2[2] = 0;
					array2[3] = 0;
					array2[4] = 0;
				}
				num22 = 0;
				num23 = 0;
				int num35 = Class73.smethod_40(gStruct);
				if (num31 != 0 && num30 != 0 && num32 != 0 && num35 > 1)
				{
					if (num30 != 10 && num30 != 21)
					{
						array4 = new uint[2]
						{
							Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
							Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
						};
						if (array4[0] == 0 || array4[1] == 0)
						{
							continue;
						}
						if (flag10)
						{
							Thread.Sleep(300);
							flag10 = false;
							bool_ = false;
							continue;
						}
						if (num == num32 && (num2 == Class38.gstruct29_0.int_4 || FormMain.int_21 <= 0))
						{
							if (num3 != num33)
							{
								num14 = 0;
								num16 = 0;
								int_2 = 0;
								uint_4 = null;
								int num36 = 0;
								while (num33 == 0 && num36 < 30 && num33 != num3)
								{
									Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array3, 4, ref int_6);
									num25 = BitConverter.ToUInt32(array3, 0);
									Class20.ReadProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_13.uint_0, array3, 4, ref int_6);
									num26 = BitConverter.ToUInt32(array3, 0);
									num27 = num26 * Class47.gstruct43_15.uint_0;
									Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array3, 4, ref int_6);
									num28 = BitConverter.ToUInt32(array3, 0);
									num29 = num28 + num27;
									Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_43.uint_0, array3, 4, ref int_6);
									num33 = BitConverter.ToInt32(array3, 0);
									Thread.Sleep(10);
									num36++;
								}
								num3 = num33;
								if (num33 <= 0)
								{
									Thread.Sleep(150);
									Class76.smethod_9(gStruct);
									continue;
								}
							}
							if (gStruct.bool_29)
							{
								bool flag12 = false;
								if (num33 == 0)
								{
									int num37 = Class81.smethod_0(gStruct, bool_0: true);
									flag12 = (num37 != 1);
								}
								num19 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
								if (0 <= num19)
								{
									FormMain.gstruct42_0[num19].bool_29 = flag12;
								}
								if (!flag12)
								{
									Class11.smethod_22();
								}
								continue;
							}
							int num38 = (int)Class20.smethod_30(num25 + Class47.gstruct43_30.uint_0 + Class47.gstruct43_65.uint_0, gStruct.int_130);
							num39 = 600;
							if (gStruct.int_94 > 0)
							{
								num39 = gStruct.int_95;
							}
							num40 = gStruct.int_128;
							if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
							{
								num40 = gStruct.int_93;
							}
							if (num40 <= 0)
							{
								num40 = 500;
							}
							num20 = FormMain.int_23;
							if (gStruct.int_129 != Class38.gstruct29_0.int_0)
							{
								if (num40 <= 180 && num20 < FormMain.int_51)
								{
									num20 = FormMain.int_51;
								}
								if (gStruct.int_123[0] > 0 && FormMain.int_27 > 0 && num20 > 180)
								{
									num20 = 180;
								}
							}
							flag13 = ((463 < num32 && num32 < 472) || (479 < num32 && num32 < 496));
							array = array4;
							flag7 = false;
							flag14 = false;
							flag15 = false;
							int num41 = 0;
							num42 = 0;
							int num43 = 0;
							if (gStruct.int_101 > 0 && num32 == 333 && Class11.smethod_23(long_7) > 6000L)
							{
								if (num14 <= 0)
								{
									int[] array5 = Class30.smethod_0(gStruct);
									num14 = ((array5 != null && (array5[0] <= 0 || array5[1] <= 0 || array5[2] <= 0)) ? 1 : 0);
								}
								if (num14 > 0)
								{
									num4 = -1;
									uint[] array6 = Class37.smethod_9(array4, num32, "HIEUTHUOC");
									if (array6 != null)
									{
										if (num21 > 0)
										{
											Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
										}
										num21 = 0;
										num44 = Class53.smethod_18(array4, array6);
										if (num44 > 90000L)
										{
											Class53.smethod_22(gStruct, Class30.uint_40, array4, null, num32, bool_0: false, 8000);
											continue;
										}
									}
								}
								num14 = 0;
								long_7 = Class11.smethod_22();
							}
							if (gStruct.bool_1 && (flag3 || num33 > 0) && num15 != gStruct.int_0)
							{
								if (FormChayBoss.smethod_2(gStruct) > 0)
								{
									num15 = gStruct.int_0;
									if (flag3)
									{
										flag3 = (num33 <= 0);
									}
									if (Class38.gstruct29_0.int_0 == gStruct.int_129)
									{
										Class38.gstruct29_0.bool_1 = false;
									}
								}
								num19 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
								if (0 <= num19)
								{
									FormMain.gstruct42_0[num19].bool_29 = false;
								}
								continue;
							}
							if (Class38.gstruct29_0.int_0 == gStruct.int_129)
							{
								Class38.gstruct29_0.bool_1 = false;
							}
							if (num33 <= 0)
							{
								if (gStruct.int_100[0] > 0 && gStruct.int_100[1] <= num38)
								{
									int num36 = 0;
									byte[] array7 = Class11.smethod_41("Kh«ng thÓ tiÕp tôc v× PK qu\u00b8 cao (vao Hau can -> phuc hoi, un-check pk cao).");
									for (; num36 < 6; num36++)
									{
										Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_253.uint_0, array7, array7.Length, ref int_6);
										Thread.Sleep(100);
									}
									continue;
								}
								if (Class60.smethod_3(gStruct, Class60.uint_14) > 0)
								{
									Thread.Sleep(100);
									continue;
								}
								int num45 = Class69.smethod_2(gStruct);
								if (gStruct.int_126[0] <= 0 && (!flag3 || num4 < 0 || num4 != num45))
								{
									if (!FormMain.bool_3)
									{
										if (Class35.smethod_0(gStruct) == 0)
										{
											Thread.Sleep(300);
											continue;
										}
										int num46 = Class30.smethod_1(gStruct, FormMain.int_92 <= 0);
										if (num46 == 0 || (num46 < 0 && !flag6))
										{
											Thread.Sleep(300);
											flag6 = (num46 < 0);
											continue;
										}
									}
									flag3 = true;
									flag6 = false;
									flag11 = false;
									if (gStruct.int_66 > 0)
									{
										Class53.smethod_1(gStruct, ref bool_2);
									}
									num4 = Class69.smethod_2(gStruct);
									continue;
								}
								if (flag8)
								{
									long num47 = Class20.smethod_30(num29 + Class47.gstruct43_45.uint_0, gStruct.int_130);
									long num48 = Class20.smethod_30(num29 + Class47.gstruct43_47.uint_0, gStruct.int_130) + 1;
									long num49 = Class20.smethod_30(num29 + Class47.gstruct43_47.uint_0 + 4, gStruct.int_130) + 1;
									long num50 = Class20.smethod_30(num29 + Class47.gstruct43_46.uint_0, gStruct.int_130);
									long num51 = Class20.smethod_30(num29 + Class47.gstruct43_48.uint_0, gStruct.int_130) + 1;
									long num52 = Class20.smethod_30(num29 + Class47.gstruct43_48.uint_0 + 4, gStruct.int_130) + 1;
									if (num49 > num48 && num49 < 150000L)
									{
										num48 = num49;
									}
									if (num52 > num51 && num52 < 150000L)
									{
										num51 = num52;
									}
									double num53 = num47 * 100L / num48;
									double num54 = num50 * 100L / num51;
									if (((num48 > 100L && gStruct.int_103[0] > 0 && gStruct.int_103[1] > 0 && num47 <= gStruct.int_103[1]) || (gStruct.int_106[0] > 0 && gStruct.int_106[1] > 0 && num53 <= (double)gStruct.int_106[1])) && Class29.smethod_8(gStruct, 0))
									{
										Thread.Sleep(300);
									}
									if (((num51 > 50L && gStruct.int_104[0] > 0 && gStruct.int_104[1] > 0 && num50 <= gStruct.int_104[1]) || (gStruct.int_108[0] > 0 && gStruct.int_108[1] > 0 && num54 <= (double)gStruct.int_108[1])) && Class29.smethod_8(gStruct, 1))
									{
										Thread.Sleep(300);
									}
									num4 = Class69.smethod_2(gStruct);
									flag8 = false;
								}
							}
							else
							{
								flag = false;
								flag3 = false;
								flag8 = true;
								if (((FormMain.int_108 > 0 && num32 != 959) || (gStruct.int_100[0] > 0 && gStruct.int_100[1] <= num38)) && !Class53.smethod_13(gStruct) && gStruct.bool_63)
								{
									Class31.smethod_61(gStruct, 162, "b¾c");
								}
							}
							num55 = 0u;
							uint_5 = null;
							array8 = new uint[2];
							flag16 = false;
							flag17 = false;
							num32 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
							num33 = (int)Class20.smethod_30(num29 + Class47.gstruct43_43.uint_0, gStruct.int_130);
							if (FormMain.int_107 > 0 && num33 <= 0 && FormTapKet.gstruct51_0 != null)
							{
								int num56 = 0;
								while (num56 < FormTapKet.gstruct51_0.Length)
								{
									if (num32 != FormTapKet.gstruct51_0[num56].int_0)
									{
										num56++;
										continue;
									}
									goto IL_0e5c;
								}
							}
							array4 = new uint[2]
							{
								Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
								Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
							};
							bool flag18 = gStruct.int_120 != null && gStruct.int_120.Length > 4 && (FormMain.int_70 > 0 || gStruct.int_120[0] > 0) && gStruct.int_120[2] > 0 && gStruct.int_120[3] > 0 && gStruct.int_120[4] > 0;
							bool flag19 = (FormMain.int_6 > 0 || FormMain.int_7 > 0) && (FormMain.int_70 > 0 || gStruct.int_120[0] > 0) && Class38.gstruct29_1.int_11 != null && Class38.gstruct29_1.int_11[0] > 0 && Class38.gstruct29_1.int_11[1] > 0 && Class38.gstruct29_1.int_11[2] > 0 && Class38.gstruct29_1.int_11[3] > 0;
							if ((flag20 = (flag18 || flag19)) && (!flag11 || FormMain.int_71 <= 0) && Class47.long_0 >= GClass1.long_1)
							{
								int num57 = gStruct.int_120[2];
								uint[] array9 = new uint[2]
								{
									(uint)gStruct.int_120[3],
									(uint)gStruct.int_120[4]
								};
								if (flag19)
								{
									num57 = Class38.gstruct29_1.int_11[1];
									array9[0] = (uint)Class38.gstruct29_1.int_11[2];
									array9[1] = (uint)Class38.gstruct29_1.int_11[3];
								}
								if (num32 != num57)
								{
									if (FormMain.int_80 > 0 || !gStruct.bool_63)
									{
										if (bool_)
										{
											bool_ = false;
											if (Class44.smethod_2(gStruct, "®iÓm cò", array9) > 0)
											{
												Class53.smethod_9(gStruct);
											}
											continue;
										}
										if (!flag2)
										{
											flag2 = true;
											Class44.smethod_4(gStruct, num57);
											continue;
										}
									}
									if (num33 == 0 && Class50.smethod_0(num32) != null)
									{
										Class50.smethod_5(gStruct);
										Class76.smethod_9(gStruct);
										continue;
									}
									if (gStruct.bool_63)
									{
										int num58 = num57;
										int num59 = Class31.smethod_58(num58);
										if (num59 < 0 && num57 == 76)
										{
											num58 = 75;
											num59 = Class31.smethod_58(75);
										}
										if (0 <= num59 && Class31.smethod_61(gStruct, num58))
										{
											Thread.Sleep(300);
											Class53.smethod_9(gStruct);
											Thread.Sleep(600);
											int num60 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
											if (num60 != num32)
											{
												continue;
											}
										}
										else if (num32 != 103 && num32 != 114 && num32 != 110 && (num57 == 110 || num57 == 114) && Class31.smethod_61(gStruct, 103))
										{
											Thread.Sleep(300);
											Class53.smethod_9(gStruct);
											Thread.Sleep(600);
											int num60 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
											if (num60 != num32)
											{
												continue;
											}
										}
										int num61 = Class53.smethod_5(num32, num57, ref gstruct22_);
										if (num61 == 0)
										{
											goto IL_3106;
										}
										if (flag2 && num61 > 0 && num17 < 5)
										{
											uint[] uint_6 = array9;
											if (Class53.smethod_5(num61, num57, ref gstruct22_) == 0 && gstruct22_.uint_0 != null)
											{
												uint_6 = new uint[2]
												{
													gstruct22_.uint_0[0, 0],
													gstruct22_.uint_0[0, 1]
												};
											}
											num17++;
											Class31.smethod_61(gStruct, num61, null, uint_6);
											continue;
										}
									}
									if (num18 < 3)
									{
										int[] array10 = Class53.smethod_7(num32);
										if (array10 != null && Class44.smethod_4(gStruct, num57) > 0)
										{
											num18++;
											continue;
										}
									}
									int num62 = Class53.smethod_5(num32, num57, ref gstruct22_);
									if (num62 != 0)
									{
										if (flag2 && num62 > 0 && num17 < 5)
										{
											uint[] uint_6 = array9;
											if (Class53.smethod_5(num62, num57, ref gstruct22_) == 0 && gstruct22_.uint_0 != null)
											{
												uint_6 = new uint[2]
												{
													gstruct22_.uint_0[0, 0],
													gstruct22_.uint_0[0, 1]
												};
											}
											num17++;
											Class31.smethod_61(gStruct, num62, null, uint_6);
										}
										else if (Class11.smethod_23(long_4) > 15000L)
										{
											Class60.smethod_50(gStruct, "<color=yellow>Khong the den toa do dinh san...");
											long_4 = Class11.smethod_22();
										}
										continue;
									}
									goto IL_3106;
								}
								bool_ = true;
								num18 = 0;
								num17 = 0;
								if (Class60.smethod_3(gStruct, Class60.uint_6) > 0)
								{
									continue;
								}
								long num63 = Class53.smethod_18(array4, array9);
								if (num63 < 48400L)
								{
									num8 = 0;
									flag11 = true;
									goto IL_38a8;
								}
								if (num21 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
								}
								num21 = 0;
								if (num63 < 900000L && num8 < 5)
								{
									Class12.smethod_3(gStruct, bool_0: false);
									Class60.smethod_61(gStruct, array9);
									Thread.Sleep(150);
									num8++;
									continue;
								}
								flag4 = (Class20.smethod_30(num29 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
								if (gStruct.bool_64 && !flag4 && Class11.smethod_23(long_) > 1800L)
								{
									Class60.smethod_55(gStruct, "Switch([[horse]])");
									long_ = Class11.smethod_22();
								}
								if (Class11.smethod_23(long_4) > 4000L)
								{
									Class12.smethod_1(gStruct, array9);
									long_4 = Class11.smethod_22();
								}
								continue;
							}
							if (FormMain.int_108 > 0 && num32 != 959 && num32 != 990)
							{
								array11 = Class53.smethod_7(num32);
								if (array11 != null && array11[1] == 0)
								{
									Class16.smethod_0(gStruct);
									continue;
								}
								if (num16 < 5 && gStruct.bool_63)
								{
									num16++;
									if (Class31.smethod_61(gStruct, 176, "b¾c"))
									{
										FormMain.gstruct42_0[num19].bool_29 = true;
										continue;
									}
								}
								if (num33 <= 0)
								{
									if (Class44.smethod_5(gStruct, 176) > 0)
									{
										FormMain.gstruct42_0[num19].bool_29 = true;
									}
								}
								else
								{
									Class53.smethod_13(gStruct);
								}
								continue;
							}
							flag21 = false;
							if ((flag16 = ((!gStruct.bool_1 || gStruct.int_0 < 0 || FormChayBoss.string_2.GetLength(0) <= gStruct.int_0 || FormChayBoss.string_2[gStruct.int_0, 0][0] == '.' || (Class38.gstruct29_0.int_4 == num32 && Class38.gstruct29_0.int_3 > 0 && !Class38.gstruct29_0.bool_1)) && FormMain.int_21 > 0 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_0 != gStruct.int_129 && Class38.gstruct29_0.int_6 > 0 && Class11.smethod_57(Class38.gstruct29_0.uint_4) && (FormMain.int_22 > 0 || Class38.gstruct29_0.int_3 > 0))) && gStruct.int_129 != Class38.gstruct29_0.int_0)
							{
								if (Class38.gstruct29_0.int_4 == num32)
								{
									if (num33 > 0)
									{
										bool_ = true;
										num24 = 0;
									}
									num5 = 0;
									if (FormMain.int_22 > 0 && Class38.gstruct29_0.int_3 <= 0 && num33 <= 0 && Class11.smethod_2(Class38.gstruct29_0.string_1, "m b\u00b8o d") > 0)
									{
										long num64 = 0L;
										long num65 = 0L;
										array4 = new uint[2]
										{
											Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
											Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
										};
										uint[] array12 = new uint[2]
										{
											49213u,
											101084u
										};
										uint[] array13 = new uint[2]
										{
											50192u,
											98662u
										};
										uint[] uint_7 = new uint[2]
										{
											49318u,
											101744u
										};
										uint[] uint_8 = new uint[2]
										{
											50579u,
											98932u
										};
										num64 = Class53.smethod_18(array4, uint_8);
										num65 = Class53.smethod_18(array4, uint_7);
										bool flag22 = num65 < num64;
										num64 = Class53.smethod_18(Class38.gstruct29_0.uint_4, uint_8);
										num65 = Class53.smethod_18(Class38.gstruct29_0.uint_4, uint_7);
										if (num65 < num64 != flag22)
										{
											uint[] array14 = array13;
											if (flag22)
											{
												array14 = array12;
											}
											long num66 = Class53.smethod_18(array4, array14);
											if (num66 <= 360000L)
											{
												for (int i = 0; i < 10; i++)
												{
													array4 = new uint[2]
													{
														Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
														Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
													};
													num66 = Class53.smethod_18(array4, array14);
													if (num66 < 22500L)
													{
														break;
													}
													Class60.smethod_61(gStruct, array14);
													Thread.Sleep(300);
												}
												Class44.smethod_2(gStruct, "m b\u00b8o danh|hi danh|(T)|(K)");
											}
											else if (Class11.smethod_23(long_4) > 3000L)
											{
												Class12.smethod_1(gStruct, array14);
												long_4 = Class11.smethod_22();
											}
											continue;
										}
									}
									num44 = Class53.smethod_18(array4, Class38.gstruct29_0.uint_4);
									if (flag9 || num44 > num20 * num20)
									{
										goto IL_1c32;
									}
									Class12.smethod_3(gStruct, bool_0: false);
									int num67 = num8;
									num8 = 0;
									num24 = 0;
									int_2 = 0;
									if (num33 > 0 && !gStruct.bool_33 && gStruct.bool_64 && gStruct.int_90 == 1 && FormMain.int_96 > 0 && (FormMain.int_31 > 0 || FormMain.int_30 > 0 || FormMain.int_32 > 0) && Class20.smethod_30(num29 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0 && Class20.smethod_30(num29 + Class47.gstruct43_43.uint_0, gStruct.int_130) != 0 && Class11.smethod_23(long_) > 600L)
									{
										Class60.smethod_55(gStruct, "Switch([[horse]])");
										long_ = Class11.smethod_22();
									}
									if (num13 <= 0L || Class11.smethod_23(num13) >= 1500L)
									{
										uint[] uint_9 = new uint[2]
										{
											array4[0],
											array4[1]
										};
										if (Class38.smethod_4(num7, ref array4, ref uint_3) > 0)
										{
											long num68 = Class53.smethod_18(uint_9, Class38.gstruct29_0.uint_4);
											long num69 = Class53.smethod_18(array4, Class38.gstruct29_0.uint_4);
											if (num69 > num20 * num20)
											{
												if (num67 > 0)
												{
													uint[] uint_10 = Class53.smethod_3(array4, Class38.gstruct29_0.uint_4, -100);
													Class60.smethod_61(gStruct, uint_10);
													Thread.Sleep(120);
												}
												goto IL_1c32;
											}
											num13 = Class11.smethod_22();
											if (num21 > 0)
											{
												Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
											}
											num21 = 0;
											Class38.smethod_5(gStruct, array4, Class38.gstruct29_0.uint_4, num68 <= 5625L);
											goto IL_503b;
										}
										num13 = 0L;
										if (num21 == 0 && Class53.smethod_18(uint_9, Class38.gstruct29_0.uint_4) > FormMain.int_23 * FormMain.int_23)
										{
											num11++;
											if (num11 > 3)
											{
												Class60.smethod_61(gStruct, Class38.gstruct29_0.uint_4);
												Thread.Sleep(150);
												num11 = 0;
											}
										}
										if (FormMain.int_27 > 0 && num33 > 0 && gStruct.int_123[0] > 0 && Class60.smethod_3(gStruct, Class60.uint_13) == 0)
										{
											Class60.smethod_2(gStruct, Class60.uint_13, 1, 4);
										}
									}
									goto IL_1cf6;
								}
								if (FormMain.int_108 <= 0)
								{
									if (num32 == 221)
									{
										Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
										if (Class17.smethod_0(gStruct) > 0)
										{
											continue;
										}
									}
									num70 = 0;
									if (num32 == 336 && Class38.gstruct29_0.int_4 == 341)
									{
										long num71 = Class53.smethod_21(Class36.uint_0, array4);
										long num72 = Class53.smethod_21(Class36.uint_1, array4);
										if (num71 > num72)
										{
											flag21 = true;
											flag16 = false;
											goto IL_3432;
										}
										gstruct22_ = Class37.smethod_3(num32, Class38.gstruct29_0.int_4);
									}
									else
									{
										if (num32 == 175 || num32 == 195)
										{
											string string_ = "Tèng Kim Chiªu th|Phong V©n Chiªu­ th";
											if (Class60.smethod_42(gStruct, string_))
											{
												Thread.Sleep(300);
												Class76.smethod_6(gStruct, 0);
												continue;
											}
										}
										if (num32 == 175)
										{
											gstruct22_ = Class37.smethod_3(num32, 195);
										}
										else
										{
											if (Class38.gstruct29_0.int_4 == 977)
											{
												Thread.Sleep(300);
												if (num33 > 0)
												{
													if (gStruct.bool_63 && num5 < 3 && Class31.smethod_61(gStruct, 11, "®«ng|§«ng"))
													{
														Class31.smethod_61(gStruct, 11, "®«ng|§«ng", null, bool_1: true);
														num5++;
														continue;
													}
													num5 = 0;
													if (Class53.smethod_13(gStruct))
													{
														continue;
													}
												}
												array15 = Class53.smethod_7(num32);
												if (array15 != null)
												{
													int num73 = Class53.smethod_20(Class37.uint_0, Class38.gstruct29_0.uint_4) + 1;
													Class44.smethod_2(gStruct, "B¶n ®å Ho¹t|KÝch sè " + num73);
												}
												else
												{
													if (Class50.smethod_1(num32) == null)
													{
														continue;
													}
													Class44.smethod_5(gStruct, 11);
													Thread.Sleep(600);
													Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array3, 4, ref int_6);
													int num60 = BitConverter.ToInt32(array3, 0);
													if (num60 != num32)
													{
														num19 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
														if (0 <= num19)
														{
															FormMain.gstruct42_0[num19].bool_29 = true;
														}
													}
												}
												continue;
											}
											if (Class37.smethod_0(num32) && !Class37.smethod_0(Class38.gstruct29_0.int_4))
											{
												int num58 = 11;
												int[] array16 = Class53.smethod_7(Class38.gstruct29_0.int_4);
												if (array16 != null)
												{
													num58 = Class53.int_0[array16[0], 0];
												}
												Class44.smethod_5(gStruct, num58);
												continue;
											}
											if (flag13 || (FormMain.int_22 <= 0 && Class38.gstruct29_0.int_3 <= 0))
											{
												flag21 = true;
												flag16 = false;
												goto IL_3432;
											}
											if (Class38.gstruct29_0.int_4 == 333 && FormMain.string_3 == "vltrungnguyen.com" && Class50.smethod_1(num32) == null)
											{
												num44 = -1L;
												int num74 = -1;
												for (int j = 0; j < Class37.gstruct19_0.Length; j++)
												{
													long num75 = Class53.smethod_18(Class38.gstruct29_0.uint_4, Class37.gstruct19_0[j].uint_0);
													if (num74 < 0 || num75 < num44)
													{
														num74 = j;
														num44 = num75;
													}
												}
												if (Class31.smethod_62(gStruct, "b¶n ®å|§Æc BiÖt|" + Class37.gstruct19_0[num74].string_0))
												{
													Thread.Sleep(180);
													continue;
												}
											}
											Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_43.uint_0, array3, 4, ref int_6);
											num33 = BitConverter.ToInt32(array3, 0);
											if (num33 > 0 && Class38.gstruct29_0.int_3 <= 0)
											{
												gstruct22_ = Class37.smethod_3(num32, Class38.gstruct29_0.int_4);
												if (gstruct22_.int_0 != num32 || gstruct22_.int_1 != Class38.gstruct29_0.int_4)
												{
													if (Class11.smethod_2(Class38.gstruct29_0.string_1, "Õn thuyÒ") <= 0)
													{
														if (FormMain.int_80 > 0 && num32 != 195)
														{
															if (!flag)
															{
																if (!Class38.gstruct29_0.bool_0 && Class38.gstruct29_0.int_3 <= 0)
																{
																	num9++;
																	if (num9 > 3)
																	{
																		flag = true;
																		num9 = 0;
																		if (Class53.smethod_13(gStruct))
																		{
																			continue;
																		}
																	}
																	Thread.Sleep(80);
																}
																if (!flag)
																{
																	num5 = 0;
																	goto IL_3432;
																}
															}
															if (gStruct.bool_63 && Class31.smethod_61(gStruct, Class38.gstruct29_0.int_4, null, Class38.gstruct29_0.uint_4))
															{
																continue;
															}
														}
														else
														{
															if (num5 < 3 && gStruct.bool_63 && Class31.smethod_61(gStruct, Class38.gstruct29_0.int_4, null, Class38.gstruct29_0.uint_4))
															{
																num5++;
																if (num32 == 195)
																{
																	try
																	{
																		num19 = Class71.smethod_3(FormMain.gstruct42_0, gStruct.int_129);
																		if (0 <= num19)
																		{
																			FormMain.gstruct42_0[num19].bool_29 = true;
																		}
																	}
																	catch
																	{
																	}
																}
																continue;
															}
															num5 = 0;
															if (!Class38.gstruct29_0.bool_0 && Class38.gstruct29_0.int_3 <= 0)
															{
																num9++;
																if (num9 > 3)
																{
																	num9 = 0;
																	if (Class53.smethod_13(gStruct))
																	{
																		continue;
																	}
																}
																Thread.Sleep(80);
															}
														}
														flag21 = true;
														flag16 = false;
													}
													goto IL_3432;
												}
												num9 = 0;
											}
											else
											{
												if (num33 == 0 && Class38.gstruct29_0.int_3 <= 0)
												{
													if (num16 < 5 && gStruct.bool_63)
													{
														num16++;
														if (Class31.smethod_61(gStruct, Class38.gstruct29_0.int_4, null, Class38.gstruct29_0.uint_4))
														{
															Thread.Sleep(180);
															continue;
														}
													}
													Class44.smethod_5(gStruct, Class38.gstruct29_0.int_4);
													continue;
												}
												if (num33 == 0 && Class38.gstruct29_0.int_3 > 0)
												{
													if (FormMain.int_80 > 0 || !gStruct.bool_63)
													{
														if (bool_)
														{
															bool_ = false;
															uint[] uint_11 = null;
															if (FormMain.int_21 > 0 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_4 == num32)
															{
																uint_11 = Class38.gstruct29_0.uint_4;
															}
															if (Class44.smethod_2(gStruct, "®iÓm cò", uint_11) > 0)
															{
																Class53.smethod_9(gStruct);
															}
															continue;
														}
														if (!flag2)
														{
															flag2 = true;
															Class44.smethod_4(gStruct, Class38.gstruct29_0.int_4);
															continue;
														}
													}
													bool flag23 = Class38.gstruct29_0.int_4 == 181;
													flag24 = false;
													if (!gStruct.bool_63 || flag23)
													{
														goto IL_2b26;
													}
													int num58 = Class38.gstruct29_0.int_4;
													int num59 = Class31.smethod_58(num58);
													if (num59 < 0 && Class38.gstruct29_0.int_4 == 76)
													{
														num58 = 75;
														num59 = Class31.smethod_58(75);
													}
													if (0 <= num59 && num16 < 6 && Class31.smethod_61(gStruct, num58))
													{
														num16++;
														Thread.Sleep(300);
														Class53.smethod_9(gStruct);
														Thread.Sleep(600);
														continue;
													}
													if (num32 != 103 && num32 != 114 && num32 != 110 && (Class38.gstruct29_0.int_4 == 110 || Class38.gstruct29_0.int_4 == 114) && Class31.smethod_61(gStruct, 103))
													{
														Thread.Sleep(300);
														Class53.smethod_9(gStruct);
														Thread.Sleep(600);
														int num60 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
														if (num60 != num32)
														{
															continue;
														}
													}
													num70 = Class53.smethod_5(num32, Class38.gstruct29_0.int_4, ref gstruct22_);
													if (num70 != 0)
													{
														gstruct22_ = Class37.smethod_3(num32, Class38.gstruct29_0.int_4);
														if (gstruct22_.int_0 != num32 || gstruct22_.int_1 != Class38.gstruct29_0.int_4)
														{
															if (flag2 && num70 > 0 && num16 < 7)
															{
																uint[] uint_6 = Class38.gstruct29_0.uint_4;
																if (Class53.smethod_5(num70, Class38.gstruct29_0.int_4, ref gstruct22_) == 0 && gstruct22_.uint_0 != null)
																{
																	uint_6 = new uint[2]
																	{
																		gstruct22_.uint_0[0, 0],
																		gstruct22_.uint_0[0, 1]
																	};
																}
																num16++;
																Class31.smethod_61(gStruct, num70, null, uint_6);
																continue;
															}
															flag24 = (num59 < 0);
															goto IL_2b26;
														}
														num9 = 0;
													}
												}
												else
												{
													if (FormMain.int_11 > 0)
													{
														gstruct22_ = Class37.smethod_3(num32, Class38.gstruct29_0.int_4);
														if (gstruct22_.int_0 == num32 && gstruct22_.int_1 == Class38.gstruct29_0.int_4)
														{
															goto IL_3106;
														}
													}
													if (num16 < 5 && gStruct.bool_63)
													{
														num16++;
														if (Class31.smethod_61(gStruct, Class38.gstruct29_0.int_4))
														{
															Thread.Sleep(180);
															continue;
														}
													}
													gstruct22_ = Class37.smethod_3(num32, Class38.gstruct29_0.int_4);
													if (gstruct22_.int_0 != num32 || gstruct22_.int_1 != Class38.gstruct29_0.int_4)
													{
														num70 = Class53.smethod_5(num32, Class38.gstruct29_0.int_4, ref gstruct22_);
														if (num70 != 0)
														{
															bool_ = false;
															if (num70 > 0)
															{
																flag = false;
																if (Class11.smethod_23(long_5) > 3000L)
																{
																	flag = true;
																	long_5 = Class11.smethod_22();
																	if (Class53.smethod_13(gStruct))
																	{
																		continue;
																	}
																}
																if (num32 == 336)
																{
																	long num71 = Class53.smethod_21(Class36.uint_0, array4);
																	long num72 = Class53.smethod_21(Class36.uint_1, array4);
																	if (num71 > num72)
																	{
																		gstruct22_ = Class37.smethod_3(num32, 121);
																		goto IL_3106;
																	}
																}
																flag21 = true;
																flag16 = false;
															}
															else
															{
																flag21 = true;
																flag16 = false;
																num10++;
																if (num10 > 2)
																{
																	num16 = 0;
																	if (num10 > 3)
																	{
																		Class53.smethod_8(gStruct, "Ch­a ®Þnh nghÜa ®­êng ®i, ®ang thö T§P ®Ó dß ®­êng !");
																		if (!Class53.smethod_13(gStruct) && gStruct.bool_63)
																		{
																			Class31.smethod_61(gStruct, 1, "t©m");
																		}
																		num10 = 0;
																	}
																	continue;
																}
															}
															goto IL_3432;
														}
													}
												}
											}
										}
									}
									goto IL_3106;
								}
							}
							else
							{
								flag21 = true;
								num24 = 0;
							}
							goto IL_3432;
						}
						num16 = 0;
						int_2 = 0;
						num24 = 0;
						uint_4 = null;
						flag3 = false;
						bool_2 = false;
						flag5 = false;
						flag = false;
						flag11 = false;
						if (flag2)
						{
							flag2 = (num3 == num33 && num3 <= 0);
						}
						int num76 = 0;
						while (num != num32)
						{
							int num77 = Class73.smethod_40(gStruct);
							Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
							num21 = 0;
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array3, 4, ref int_6);
							num25 = BitConverter.ToUInt32(array3, 0);
							Class20.ReadProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_13.uint_0, array3, 4, ref int_6);
							num26 = BitConverter.ToUInt32(array3, 0);
							num27 = num26 * Class47.gstruct43_15.uint_0;
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array3, 4, ref int_6);
							num28 = BitConverter.ToUInt32(array3, 0);
							num29 = num28 + num27;
							Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_50.uint_0, array3, 4, ref int_6);
							num31 = BitConverter.ToInt32(array3, 0);
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array3, 4, ref int_6);
							num32 = BitConverter.ToInt32(array3, 0);
							Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_43.uint_0, array3, 4, ref int_6);
							num33 = BitConverter.ToInt32(array3, 0);
							if (num33 > 0 || num76 > 8 || (num77 != 0 && num77 != 1 && num31 > 0 && num32 > 0))
							{
								break;
							}
							num76++;
							Thread.Sleep(100);
						}
						num = num32;
						num2 = Class38.gstruct29_0.int_4;
						continue;
					}
					if (gStruct.int_91 <= 0 && (FormMain.int_38 <= 0 || FormMain.int_37 <= 0))
					{
						num14 = 0;
					}
					flag10 = true;
					continue;
				}
				if (num35 <= 1)
				{
					bool_2 = false;
				}
				Thread.Sleep(60);
				continue;
			}
			flag3 = false;
			continue;
			IL_1c32:
			flag9 = (num44 > 40000L);
			Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
			num21 = 0;
			if (!flag5 && num32 == 336)
			{
				flag5 = true;
				int num78 = 0;
				int num79 = 0;
				long num71 = Class53.smethod_21(Class36.uint_0, array4);
				long num72 = Class53.smethod_21(Class36.uint_1, array4);
				if (num71 < num72)
				{
					num78 = 1;
				}
				num71 = Class53.smethod_21(Class36.uint_0, Class38.gstruct29_0.uint_4);
				num72 = Class53.smethod_21(Class36.uint_1, Class38.gstruct29_0.uint_4);
				if (num71 < num72)
				{
					num79 = 1;
				}
				if (num78 != num79)
				{
					flag21 = true;
					flag16 = false;
					goto IL_1cf6;
				}
			}
			if (uint_4 == null)
			{
				uint_4 = new uint[2]
				{
					array4[0],
					array4[1]
				};
				int_2 = 0;
			}
			if (int_2 > 6)
			{
				long num80 = Class53.smethod_18(uint_4, array4);
				uint_4 = null;
				if (num80 < 180000L)
				{
					Class12.smethod_3(gStruct, bool_0: false);
					Class53.smethod_0(gStruct, array4, Class38.gstruct29_0.uint_4, 600);
					goto IL_503b;
				}
				int_2 = 0;
			}
			if (num44 > FormMain.int_95 * FormMain.int_95)
			{
				Class6.smethod_2(gStruct, num29, ref long_, bool_0: true);
			}
			if (num44 < 900000L && num8 < 6)
			{
				num8++;
				Class12.smethod_3(gStruct, bool_0: false);
				Class60.smethod_61(gStruct, Class38.gstruct29_0.uint_4);
				Thread.Sleep(150);
				goto IL_503b;
			}
			array11 = Class53.smethod_7(num32);
			if (array11 != null && num33 > 0 && Class38.gstruct29_0.int_3 <= 0 && FormMain.int_22 > 0 && ((gStruct.bool_63 && Class31.smethod_61(gStruct, Class38.gstruct29_0.int_4, null, Class38.gstruct29_0.uint_4)) || Class53.smethod_13(gStruct)))
			{
				continue;
			}
			bool flag25 = num33 <= 0 && array11 != null && Class38.gstruct29_0.int_3 > 0;
			if (FormMain.int_80 > 0 && bool_ && flag25)
			{
				bool_ = false;
				array4 = new uint[2]
				{
					Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
					Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
				};
				num44 = Class53.smethod_18(array4, Class38.gstruct29_0.uint_4);
				if (num44 < 900000L)
				{
					Class12.smethod_3(gStruct, bool_0: false);
					Class60.smethod_61(gStruct, Class38.gstruct29_0.uint_4);
					Thread.Sleep(150);
					goto IL_503b;
				}
				uint[] uint_11 = null;
				if (FormMain.int_21 > 0 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_4 == num32)
				{
					uint_11 = Class38.gstruct29_0.uint_4;
				}
				if (Class44.smethod_2(gStruct, "®iÓm cò", uint_11) > 0)
				{
					Class53.smethod_9(gStruct);
					continue;
				}
			}
			if (num33 == 0 && Class38.gstruct29_0.int_3 > 0 && Class50.smethod_0(num32) != null)
			{
				Class50.smethod_5(gStruct);
				Class76.smethod_9(gStruct);
				continue;
			}
			if (num32 == 53 && num24 < 6 && num33 <= 0)
			{
				uint[] array17 = Class38.gstruct29_0.uint_4;
				if (Class74.gstruct17_0 == null)
				{
					Class74.gstruct17_0 = Class74.smethod_1();
				}
				if (Class38.gstruct29_0.int_3 > 0)
				{
					array17 = Class74.smethod_0(array17);
				}
				uint[,] uint_12 = Class37.smethod_8(Class74.gstruct17_0, array4, array17);
				uint[] array18 = array4;
				int num46 = Class53.smethod_22(gStruct, uint_12, array4, array17, 53, bool_0: true, 8000);
				array4 = new uint[2]
				{
					Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
					Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
				};
				if (array18 != null && num46 > 0 && (array18[0] != array4[0] || array18[1] != array4[1]))
				{
					num24++;
					continue;
				}
				num24 = 6;
			}
			if (Class38.gstruct29_0.uint_4 == null)
			{
				continue;
			}
			if (gStruct.bool_63 && num32 == 333 && num44 > 15354505L && FormMain.string_3 == "vltrungnguyen.com")
			{
				num44 = -1L;
				int num74 = -1;
				for (int j = 0; j < Class37.gstruct19_0.Length; j++)
				{
					long num75 = Class53.smethod_18(Class38.gstruct29_0.uint_4, Class37.gstruct19_0[j].uint_0);
					if (num74 < 0 || num75 < num44)
					{
						num74 = j;
						num44 = num75;
					}
				}
				if (Class31.smethod_62(gStruct, "b¶n ®å|§Æc BiÖt|" + Class37.gstruct19_0[num74].string_0))
				{
					Thread.Sleep(180);
					continue;
				}
			}
			if (!Class12.smethod_4(gStruct) || Class11.smethod_23(long_4) > 4000L)
			{
				Class12.smethod_1(gStruct, Class38.gstruct29_0.uint_4);
				long_4 = Class11.smethod_22();
				int_2++;
				num8 = 0;
			}
			continue;
			IL_3b2d:
			uint num81 = 0u;
			uint[] array19 = null;
			uint[] uint_13 = null;
			if (!flag17)
			{
				if (gStruct.int_129 != Class38.gstruct29_0.int_0 && gStruct.int_129 != Class66.gstruct42_0.int_129 && Class38.gstruct29_0.uint_5 != 0)
				{
					uint num82 = Class38.gstruct29_0.uint_5 >> 16;
					uint int_8 = Class38.gstruct29_0.uint_5 - (num82 << 16);
					array19 = Class73.smethod_11(Class38.gstruct29_0.uint_4, (int)int_8, (int)num82);
					uint[] array20 = Class73.smethod_10(array4, array19);
					num81 = (array20[1] << 16) + array20[0];
					uint_13 = Class38.gstruct29_0.uint_4;
					Class73.smethod_7(gStruct, num81);
				}
			}
			else
			{
				uint num82 = Class38.gstruct29_1.uint_5 >> 16;
				uint int_8 = Class38.gstruct29_1.uint_5 - (num82 << 16);
				array19 = Class73.smethod_11(Class38.gstruct29_1.uint_4, (int)int_8, (int)num82);
				uint[] array20 = Class73.smethod_10(array4, array19);
				num81 = (array20[1] << 16) + array20[0];
				uint_13 = Class38.gstruct29_1.uint_4;
				Class73.smethod_7(gStruct, num81);
			}
			flag4 = (Class20.smethod_30(num29 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
			Class53.smethod_30(gStruct, flag4, ref long_);
			int num83;
			if (gStruct.int_121[0] > 0)
			{
				bool flag26 = gStruct.int_121[1] > 0 && gStruct.int_121[2] > 0;
				bool flag27 = gStruct.int_121[3] > 0 && gStruct.int_121[4] > 0;
				if (flag26 && !flag27)
				{
					num83 = gStruct.int_121[2];
				}
				else if (flag27 && !flag26)
				{
					num83 = gStruct.int_121[4];
				}
				else if (flag26 && flag27)
				{
					num83 = ((0 > num6 || num6 > 25) ? gStruct.int_121[4] : gStruct.int_121[2]);
					if (num6 > 35)
					{
						num6 = 0;
					}
					num6++;
				}
			}
			if (num83 <= 0)
			{
				num83 = Class32.smethod_32(gStruct);
			}
			if (gStruct.int_129 != Class38.gstruct29_0.int_0 || FormMain.int_6 > 0 || FormMain.int_7 > 0)
			{
				Class67.smethod_7(gStruct);
			}
			Class67.smethod_3(gStruct, num83, 6, 1);
			for (int k = 0; k < 3; k++)
			{
				Class20.smethod_75(gStruct.uint_4, 117);
				if (k < 2)
				{
					Thread.Sleep(60);
				}
			}
			if (num81 != 0 && gStruct.int_129 != Class66.gstruct42_0.int_129)
			{
				if (gStruct.int_92 <= 0)
				{
					Class20.smethod_30(num29 + Class47.gstruct43_31.uint_0, gStruct.int_130);
					int num84 = Class32.smethod_32(gStruct);
					if (num84 == 53 || num84 <= 1)
					{
						goto IL_503b;
					}
					if (num84 <= 100)
					{
						num84 = 400;
					}
				}
				string string_2 = Class73.smethod_20(gStruct);
				if (Class11.smethod_3(string_2, "iÓm qu\u00b8 x"))
				{
					uint[] array21 = Class53.smethod_3(uint_13, array19, -1 * (FormMain.int_23 - 50));
					long num85 = Class53.smethod_18(array4, array21);
					if (num85 > 7000L)
					{
						Class60.smethod_61(gStruct, array21);
						Thread.Sleep(150);
						Class73.smethod_21(gStruct, "0K..");
					}
				}
			}
			goto IL_503b;
			IL_2d4c:
			Thread.Sleep(100);
			continue;
			IL_503b:
			if (!flag15 && gStruct.int_129 != Class38.gstruct29_0.int_0 && Class32.smethod_59(gStruct, new int[2]
			{
				0,
				1
			}) != 0)
			{
				if (num21 > 0)
				{
					Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
				}
				num21 = 0;
			}
			if (flag14 && num42 <= 0)
			{
				FormDuongMon.smethod_0(gStruct, ref int_4, array, ref int_5, flag7);
			}
			if (!gStruct.bool_66 || gStruct.int_81 <= 0)
			{
				continue;
			}
			if (FormMain.int_93 != 0)
			{
				if (Class38.gstruct29_0.int_7 == Class24.gstruct38_0[FormMain.int_94].int_0)
				{
					Class32.smethod_55(gStruct, null, bool_0: true);
					if (Class11.smethod_23(long_2) > gStruct.long_7)
					{
						Class32.smethod_56(gStruct);
						long_2 = Class11.smethod_22();
					}
				}
			}
			else if (num42 > 0 && Class11.smethod_23(long_2) > gStruct.long_7)
			{
				Class32.smethod_55(gStruct, array8, bool_0: false);
				Class32.smethod_56(gStruct);
				long_2 = Class11.smethod_22();
			}
			continue;
			IL_2b26:
			bool flag28 = false;
			array15 = Class53.smethod_7(num32);
			if (array15 == null && Class38.gstruct29_0.int_4 > 0 && Class50.smethod_1(num32) != null && Class50.smethod_0(Class38.gstruct29_0.int_4) == null)
			{
				Class44.smethod_5(gStruct, 11);
				Thread.Sleep(600);
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array3, 4, ref int_6);
				int num60 = BitConverter.ToInt32(array3, 0);
				if (num60 != num32)
				{
					num19 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
					if (0 <= num19)
					{
						FormMain.gstruct42_0[num19].bool_29 = true;
					}
					continue;
				}
			}
			if (Class38.gstruct29_0.int_4 != 959 && Class38.gstruct29_0.int_4 != 990)
			{
				if (Class38.gstruct29_0.int_4 != 181)
				{
					if (Class38.gstruct29_0.int_4 == 224)
					{
						Class44.smethod_2(gStruct, "h÷ng n¬i ®· ®i q|Sa M¹c");
						flag28 = true;
					}
					else if (Class38.gstruct29_0.int_4 != 993)
					{
						if (num33 <= 0 && !flag2 && Class38.gstruct29_0.int_4 != num32 && array15 != null)
						{
							Class44.smethod_4(gStruct, Class38.gstruct29_0.int_4);
							flag2 = true;
							flag28 = true;
						}
					}
					else
					{
						Class44.smethod_2(gStruct, "NguyÖt Ca");
						flag28 = true;
					}
				}
				else
				{
					Class44.smethod_2(gStruct, "h÷ng n¬i ®· ®i q|L­ìng Thñy|" + Class38.gstruct29_0.string_1);
					flag28 = true;
				}
			}
			else
			{
				Class44.smethod_2(gStruct, "ChiÕn Long|H\u00b8i Qu¶ H|L­ìng Thñy ");
				flag28 = true;
			}
			if (flag28)
			{
				Thread.Sleep(150);
				Class53.smethod_9(gStruct);
				int num46 = 0;
				while (num46 < 5)
				{
					int num60 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
					if (num60 == num32)
					{
						num46++;
						Thread.Sleep(100);
						continue;
					}
					goto IL_2d4c;
				}
			}
			Class76.smethod_9(gStruct);
			int num86 = -1;
			if (FormMain.int_19 > 0)
			{
				num86 = Class37.smethod_2(Class38.gstruct29_0.int_4);
			}
			if (0 <= num86)
			{
				continue;
			}
			num70 = Class53.smethod_5(num32, Class38.gstruct29_0.int_4, ref gstruct22_);
			if (num70 != 0)
			{
				if (num70 > 0)
				{
					if (array15 == null)
					{
						if (gStruct.bool_63)
						{
							uint[] uint_6 = Class38.gstruct29_0.uint_4;
							if (Class53.smethod_5(num70, Class38.gstruct29_0.int_4, ref gstruct22_) == 0 && gstruct22_.uint_0 != null)
							{
								uint_6 = new uint[2]
								{
									gstruct22_.uint_0[0, 0],
									gstruct22_.uint_0[0, 1]
								};
							}
							if (!Class31.smethod_61(gStruct, num70, null, uint_6))
							{
								Class31.smethod_61(gStruct, 1, "t©m");
							}
							continue;
						}
					}
					else
					{
						if (gStruct.bool_63 && num16 < 5)
						{
							num16++;
							if (Class31.smethod_61(gStruct, num70))
							{
								continue;
							}
						}
						Class44.smethod_5(gStruct, num70);
					}
				}
				if (flag24 && FormMain.int_111 <= 0)
				{
					Class31.smethod_63(gStruct, Class38.gstruct29_0.int_4);
				}
				continue;
			}
			goto IL_3106;
			IL_3432:
			flag14 = false;
			flag17 = ((FormMain.int_6 > 0 || FormMain.int_7 > 0) && FormMain.int_21 > 0 && (Class38.gstruct29_1.int_3 > 0 || FormMain.int_22 > 0) && Class38.gstruct29_1.int_4 > 0 && Class11.smethod_57(Class38.gstruct29_1.uint_4) && (gStruct.int_129 == Class38.gstruct29_0.int_0 || Class38.gstruct29_0.int_0 <= 0));
			array4 = new uint[2]
			{
				Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
				Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
			};
			if (flag21)
			{
				uint[] array22 = null;
				long num87 = 0L;
				if (num12 <= 0L || Class11.smethod_23(num12) >= 800L)
				{
					array22 = Class53.smethod_26(gStruct, ref int_3);
					if (array22 == null)
					{
						num12 = Class11.smethod_22();
					}
					else
					{
						num12 = 0L;
						num87 = Class53.smethod_18(array4, array22);
						if (num87 < 8000L)
						{
							num87 = 4L;
						}
						else if (num87 >= 15000L && num87 >= gStruct.int_68[1] * gStruct.int_68[1])
						{
							if (num87 < 360000L)
							{
								if (num21 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
								}
								num21 = 0;
								Class12.smethod_3(gStruct, bool_0: false);
								Class60.smethod_61(gStruct, array22);
								Thread.Sleep(200);
								continue;
							}
							if (num87 < 1200000L)
							{
								if (Class11.smethod_23(long_4) > 3000L)
								{
									Class12.smethod_1(gStruct, array22);
									long_4 = Class11.smethod_22();
								}
								continue;
							}
						}
						else
						{
							int num30 = (int)Class20.smethod_30(num29 + Class47.gstruct43_55.uint_0, gStruct.int_130);
							if (num30 < 3 && num87 > 7500L)
							{
								if (num21 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
								}
								num21 = 0;
								Class60.smethod_61(gStruct, array22);
								Thread.Sleep(200);
								goto IL_503b;
							}
							num87 = 4L;
						}
					}
				}
				if (flag17)
				{
					if (num87 != 4L)
					{
						num87 = FormMayphu.smethod_8(gStruct, ref bool_, ref long_4, ref int_2, ref uint_4);
					}
					int num30 = (int)Class20.smethod_30(num29 + Class47.gstruct43_55.uint_0, gStruct.int_130);
					if (num87 == 4L && num30 < 3)
					{
						array4 = new uint[2]
						{
							Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
							Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
						};
						if (Class53.smethod_18(array4, Class38.gstruct29_1.uint_4) > 5625L)
						{
							if (num21 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
							}
							num21 = 0;
							Class60.smethod_61(gStruct, Class38.gstruct29_1.uint_4);
							Thread.Sleep(200);
						}
					}
					Class20.smethod_30(num29 + Class47.gstruct43_56.uint_0, gStruct.int_130);
					if (num87 <= 0L)
					{
						continue;
					}
					if (num87 == 2L)
					{
						int_2++;
						if (int_2 < 3)
						{
							continue;
						}
					}
					if (num33 > 0 && num87 == 4L && FormMain.int_96 > 0 && gStruct.int_90 == 1)
					{
						Class6.smethod_2(gStruct, num29, ref long_, bool_0: false);
					}
				}
				uint_4 = null;
				int_2 = 0;
			}
			goto IL_38a8;
			IL_38a8:
			num33 = (int)Class20.smethod_30(num29 + Class47.gstruct43_43.uint_0, gStruct.int_130);
			if (num33 <= 0)
			{
				continue;
			}
			flag3 = false;
			flag2 = false;
			flag15 = (!gStruct.bool_33 && (FormMain.int_31 > 0 || FormMain.int_30 > 0));
			if (gStruct.int_97[0] > 0 && gStruct.int_97[1] > 0 && gStruct.string_21 == "NGAMY")
			{
				long num88 = Class11.smethod_23(long_3);
				if (num88 < 300L)
				{
					continue;
				}
				if (num88 > gStruct.int_97[4] && Class7.smethod_3(gStruct))
				{
					Thread.Sleep(80);
					long_3 = Class11.smethod_22();
					continue;
				}
			}
			if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
			{
				if (!gStruct.bool_33)
				{
					if (flag20)
					{
						goto IL_4019;
					}
					bool flag29 = gStruct.int_122[0] > 0 && gStruct.int_122[1] > 0 && gStruct.int_122[2] > 0;
					bool flag30 = gStruct.int_122[0] > 0 && gStruct.int_122[3] > 0 && gStruct.int_122[4] > 0;
					bool flag31 = gStruct.int_122[0] > 0 && gStruct.int_122[5] > 0 && gStruct.int_122[6] > 0;
					flag14 = ((flag29 || flag30 || flag31) && gStruct.string_21 == "DUONGMON");
					if (FormDame.int_6 <= 0 || flag14)
					{
						goto IL_3e96;
					}
					if (flag15 || FormDame.int_7 > 0)
					{
						num83 = 0;
						if (FormDame.int_5 == 0)
						{
							goto IL_3b2d;
						}
						bool flag32 = Class38.gstruct29_0.int_8 == 1 || (flag17 && Class38.gstruct29_1.int_8 == 1);
						if (FormDame.int_5 != 1)
						{
							if (FormDame.int_5 != 2 || flag32)
							{
								goto IL_3b25;
							}
							if (num21 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
							}
							num21 = 0;
						}
						else
						{
							if (flag32)
							{
								goto IL_3b2d;
							}
							if (FormDame.int_8 > 0)
							{
								goto IL_3b25;
							}
							if (num21 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
							}
							num21 = 0;
						}
					}
				}
				else if (gStruct.int_129 != Class38.gstruct29_0.int_0)
				{
					Class6.smethod_2(gStruct, num29, ref long_, bool_0: true);
				}
			}
			goto IL_503b;
			IL_3e96:
			if (flag15)
			{
				if (!Class38.smethod_6(gStruct, ref int_7) && Class73.smethod_12(gStruct) != 1)
				{
					num32 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
					array4 = new uint[2]
					{
						Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
						Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
					};
					uint_5 = array4;
					if (flag16 && Class38.gstruct29_0.int_4 == num32 && Class38.gstruct29_0.int_3 > 0 && Class38.gstruct29_0.uint_4 != null)
					{
						uint_5 = Class38.gstruct29_0.uint_4;
						num39 += num20;
					}
					num55 = 0u;
					if (FormMain.int_33 > 0 && (flag17 || flag16))
					{
						if (!flag17)
						{
							if (flag16 && Class38.gstruct29_0.int_4 == num32 && Class38.gstruct29_0.uint_3 != num7)
							{
								num55 = Class38.gstruct29_0.uint_3;
							}
						}
						else if (Class38.gstruct29_1.int_4 == num32 && Class38.gstruct29_1.uint_3 != num7)
						{
							num55 = Class38.gstruct29_1.uint_3;
						}
						if (num55 == 0 && FormMain.int_34 <= 0)
						{
							goto IL_503b;
						}
					}
					goto IL_4019;
				}
				Thread.Sleep(120);
				num21 = 0;
			}
			goto IL_503b;
			IL_3106:
			num33 = (int)Class20.smethod_30(num29 + Class47.gstruct43_43.uint_0, gStruct.int_130);
			num32 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
			if (num33 <= 0)
			{
				if (!flag2 && Class38.gstruct29_0.int_4 != num32 && Class53.smethod_7(num32) != null)
				{
					Class44.smethod_4(gStruct, Class38.gstruct29_0.int_4);
					flag2 = true;
					continue;
				}
			}
			else
			{
				bool_ = true;
			}
			if (gstruct22_.uint_0 != null)
			{
				array4 = new uint[2]
				{
					Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
					Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
				};
				int int_9 = 0;
				if (gstruct22_.uint_0.GetLength(0) > 1)
				{
					int_9 = Class53.smethod_20(gstruct22_.uint_0, array4);
				}
				if (num21 > 0)
				{
					Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
				}
				num21 = 0;
				Class53.smethod_6(gstruct22_.uint_0, int_9, ref uint_, ref uint_2, ref int_);
				long num89 = Class53.smethod_18(array4, uint_);
				if (num89 > 90000L)
				{
					if (uint_4 == null)
					{
						uint_4 = new uint[2]
						{
							array4[0],
							array4[1]
						};
						int_2 = 0;
					}
					if (int_2 > 6)
					{
						long num80 = Class53.smethod_18(uint_4, array4);
						uint_4 = null;
						if (num80 < 180000L)
						{
							Class53.smethod_0(gStruct, array4, uint_, 600);
							continue;
						}
					}
					if (!Class12.smethod_4(gStruct) || Class11.smethod_23(long_4) > 4000L)
					{
						int_2++;
						Class12.smethod_1(gStruct, uint_);
						Thread.Sleep(300);
						Class53.smethod_8(gStruct, "Acc chÝnh " + Class38.gstruct29_0.string_1 + " (" + Class38.gstruct29_0.int_4 + ")");
						long_4 = Class11.smethod_22();
					}
					if (!(flag4 = (Class20.smethod_30(num29 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0)) && gStruct.bool_64 && Class11.smethod_23(long_) > 300L)
					{
						Class60.smethod_55(gStruct, "Switch([[horse]])");
						long_ = Class11.smethod_22();
					}
				}
				else
				{
					Class53.smethod_23(gStruct, uint_, int_, uint_2, gstruct22_.int_1);
				}
				continue;
			}
			if (0 <= Class76.Class77.smethod_1(gStruct))
			{
				Class60.smethod_57(gStruct, 0, 0);
			}
			else if (0 <= Class76.Class78.smethod_1(gStruct))
			{
				Class60.smethod_57(gStruct, 0, 1);
			}
			flag16 = false;
			flag21 = true;
			goto IL_3432;
			IL_3b25:
			num83 = 0;
			goto IL_3e96;
			IL_4019:
			int[,] array23 = null;
			if (gStruct.int_116 > 0 && gStruct.int_3 != null)
			{
				array23 = ((gStruct.int_5 <= 0) ? Class7.smethod_6(gStruct, num55, num39, uint_5) : Class7.smethod_5(gStruct, num55, num39, uint_5, Class7.int_0));
				if (array23 != null && array23[0, 0] >= 0)
				{
					int num90 = -1;
					int int_10 = Class38.gstruct29_0.int_4;
					num21 = 0;
					bool flag33 = false;
					bool flag34 = false;
					while (true)
					{
						int num91 = 0;
						int num92 = 400;
						uint num93 = 0u;
						while (num91 <= 0)
						{
							num90++;
							if (gStruct.int_3 != null && gStruct.int_3.Length > num90)
							{
								num91 = gStruct.int_3[num90];
								if (num91 > 0)
								{
									num92 = Class67.smethod_21(num91);
									break;
								}
								continue;
							}
							goto IL_4566;
						}
						Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_55.uint_0, array3, 4, ref int_6);
						int num30 = BitConverter.ToInt32(array3, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_50.uint_0, array3, 4, ref int_6);
						int num31 = BitConverter.ToInt32(array3, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_43.uint_0, array3, 4, ref int_6);
						num33 = BitConverter.ToInt32(array3, 0);
						Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array3, 4, ref int_6);
						int num94 = BitConverter.ToInt32(array3, 0);
						if (num33 > 0 && num32 == num94 && num30 != 11 && num30 != 22 && num31 != 0)
						{
							for (int l = 0; l < array23.GetLength(0); l++)
							{
								int num98;
								if (!Class38.smethod_6(gStruct, ref int_7) && Class73.smethod_12(gStruct) != 1)
								{
									int num41 = array23[l, 0];
									num42 = array23[l, 1];
									if (num42 <= 0)
									{
										continue;
									}
									num93 = (uint)((int)num28 + num42 * (int)Class47.gstruct43_15.uint_0);
									Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_50.uint_0, array3, 4, ref int_6);
									if (BitConverter.ToInt32(array3, 0) <= 0)
									{
										continue;
									}
									if (num41 > 0)
									{
										Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_43.uint_0, array3, 4, ref int_6);
										if (BitConverter.ToInt32(array3, 0) <= 0)
										{
											continue;
										}
									}
									flag33 = true;
									if (!flag34 || num41 > 0)
									{
										if (num41 > 0)
										{
											flag34 = true;
										}
										if (Class86.smethod_30(gStruct, num42, num91) != 0)
										{
											continue;
										}
										num40 = num92;
										Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array3, 4, ref int_6);
										array8[0] = BitConverter.ToUInt32(array3, 0);
										Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array3, 4, ref int_6);
										array8[1] = BitConverter.ToUInt32(array3, 0);
										array4 = new uint[2]
										{
											Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
											Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
										};
										if (flag16)
										{
											array4 = new uint[2]
											{
												Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
												Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
											};
											long num95 = Class53.smethod_18(array4, Class38.gstruct29_0.uint_4);
											if (int_10 != Class38.gstruct29_0.int_4 || num95 > num20 * num20)
											{
												goto IL_4aad;
											}
											int num96 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array8));
											int num97 = (int)Math.Sqrt(Class53.smethod_18(array4, array8));
											num98 = num96 - num20 + 10;
											int num99;
											if (num96 > num20 && num40 < num98)
											{
												if (num97 <= num96)
												{
													if (num97 < num96 && num40 < num97)
													{
														goto IL_4490;
													}
													goto IL_4494;
												}
												num99 = 0;
											}
											else
											{
												num99 = 1;
											}
											if (num99 == 0)
											{
												goto IL_4490;
											}
										}
										goto IL_4494;
									}
									goto IL_4566;
								}
								goto IL_4ad1;
								IL_4494:
								if (Class53.smethod_18(array4, array8) <= num40 * num40 || gStruct.int_92 > 0)
								{
									if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
									{
										Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(num91), 4, ref int_6);
										Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num40), 4, ref int_6);
										Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num42), 4, ref int_6);
										Thread.Sleep(10);
									}
									num21 = 1;
								}
								continue;
								IL_4490:
								num40 = num98;
								goto IL_4494;
							}
							continue;
						}
						if (num21 > 0)
						{
							Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
						}
						num21 = 0;
						break;
						IL_4aad:
						Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
						break;
						IL_4566:
						if (num21 <= 0 && gStruct.int_6 <= 0 && flag33)
						{
							long num100 = 0L;
							array4 = new uint[2]
							{
								Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
								Class20.smethod_30(num29 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
							};
							int num41 = -1;
							num42 = -1;
							int num101 = 0;
							int length = array23.GetLength(1);
							flag34 = false;
							num40 = gStruct.int_128;
							if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
							{
								num40 = gStruct.int_93;
							}
							if (num40 <= 0)
							{
								num40 = 500;
							}
							for (int l = 0; l < array23.GetLength(0); l++)
							{
								int num102 = array23[l, 0];
								int num103 = array23[l, 1];
								int num104 = array23[l, 2];
								int num105 = num40;
								int num106 = 0;
								if (length > 10)
								{
									num106 = array23[l, 10];
								}
								if (num103 <= 0)
								{
									continue;
								}
								num93 = (uint)((int)num28 + num103 * (int)Class47.gstruct43_15.uint_0);
								Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_50.uint_0, array3, 4, ref int_6);
								if (BitConverter.ToInt32(array3, 0) <= 0)
								{
									continue;
								}
								if (num102 > 0)
								{
									Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_43.uint_0, array3, 4, ref int_6);
									if (BitConverter.ToInt32(array3, 0) <= 0)
									{
										continue;
									}
								}
								if (flag34 && num102 <= 0 && num42 > 0)
								{
									break;
								}
								Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array3, 4, ref int_6);
								array8[0] = BitConverter.ToUInt32(array3, 0);
								Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array3, 4, ref int_6);
								array8[1] = BitConverter.ToUInt32(array3, 0);
								long num75 = Class53.smethod_18(array4, array8);
								if (num42 > 0 && num100 < num75)
								{
									continue;
								}
								int num98;
								if (flag16)
								{
									int num96 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array8));
									int num97 = (int)Math.Sqrt(Class53.smethod_18(array4, array8));
									num98 = num96 - num20 + 10;
									int num107;
									if (num96 > num20 && num105 < num98)
									{
										if (num97 <= num96)
										{
											if (num97 < num96 && num105 < num97)
											{
												goto IL_480f;
											}
											goto IL_4813;
										}
										num107 = 0;
									}
									else
									{
										num107 = 1;
									}
									if (num107 == 0)
									{
										goto IL_480f;
									}
								}
								goto IL_4813;
								IL_480f:
								num105 = num98;
								goto IL_4813;
								IL_4813:
								if (num75 <= num105 * num105 || gStruct.int_92 > 0)
								{
									if (num102 > 0)
									{
										flag34 = true;
									}
									num42 = num103;
									num41 = num102;
									int num43 = num104;
									num101 = num106;
									num100 = num75;
									num40 = num105;
								}
							}
							if (num42 <= 0)
							{
								break;
							}
							if (FormMain.int_109 > 0 && flag13)
							{
								if (num101 <= 0)
								{
									num93 = (uint)((int)num28 + num42 * (int)Class47.gstruct43_15.uint_0);
									Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array3, 4, ref int_6);
									array8[0] = BitConverter.ToUInt32(array3, 0);
									Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array3, 4, ref int_6);
									array8[1] = BitConverter.ToUInt32(array3, 0);
									if (Class7.smethod_4(gStruct.int_130, num32, array8) != 0)
									{
										num101 = 1;
									}
									else
									{
										uint num108 = (uint)((int)num28 + num42 * (int)Class47.gstruct43_15.uint_0 + (int)Class47.gstruct43_57.uint_0 + (int)Class47.gstruct43_1.uint_0);
										for (uint num109 = 0u; num109 < 6; num109++)
										{
											Class20.ReadProcessMemory(gStruct.int_130, num108 + Class47.gstruct43_2.uint_0 * num109, array3, 4, ref int_6);
											if (BitConverter.ToInt32(array3, 0) == 45)
											{
												num101 = 1;
												break;
											}
										}
									}
								}
								if (num101 > 0)
								{
									num42 = 0;
									int num43 = 0;
									num21 = 0;
									flag14 = false;
									break;
								}
							}
							flag4 = (Class20.smethod_30(num29 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
							Class53.smethod_29(gStruct, flag4, ref long_);
							if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(Class32.smethod_32(gStruct)), 4, ref int_6);
								Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num40), 4, ref int_6);
								Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num42), 4, ref int_6);
							}
						}
						else if (flag33 && num21 <= 0 && gStruct.int_6 > 0)
						{
							Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
						}
						break;
						IL_4ad1:
						Thread.Sleep(120);
						num21 = 0;
						break;
					}
				}
			}
			else if (flag15 = (!gStruct.bool_33 && (FormMain.int_31 > 0 || FormMain.int_30 > 0)))
			{
				array23 = Class7.smethod_5(gStruct, num55, num39, uint_5, Class7.int_0);
				if (array23 != null)
				{
					if (array23[0, 0] == -100)
					{
						continue;
					}
					int num110 = 0;
					while (true)
					{
						if (array23[num110, 1] > 0)
						{
							array8 = new uint[2]
							{
								(uint)array23[num110, 4],
								(uint)array23[num110, 5]
							};
							if (flag16)
							{
								int num97 = (int)Math.Sqrt(Class53.smethod_18(array4, array8));
								int num96 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array8));
								if (num97 - num40 > 0)
								{
									if (num96 > num97)
									{
										int num111 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array4));
										if (num111 + (num97 - num40) <= num20 + 10)
										{
											goto IL_4cfe;
										}
									}
									if (gStruct.int_86 == 1 && num110 == 0)
									{
										num110 = 1;
										continue;
									}
									if (num20 + num40 <= num96)
									{
										if (num21 > 0)
										{
											Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
										}
										num21 = 0;
										break;
									}
								}
							}
							else if (Class53.smethod_18(array4, array8) > num40 * num40 && gStruct.int_92 <= 0)
							{
								if (gStruct.int_86 != 1 || num110 != 0)
								{
									break;
								}
								num110 = 1;
								continue;
							}
							goto IL_4cfe;
						}
						if (num21 > 0)
						{
							Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
						}
						num21 = 0;
						break;
						IL_4cfe:
						int num41 = array23[num110, 0];
						num42 = array23[num110, 1];
						int num43 = array23[num110, 2];
						if (FormMain.int_50 > 0 && (num41 <= 0 || num41 == array2[0]) && array2[1] > 0 && array2[2] == num32 && array2[3] > 0)
						{
							int num112 = array2[0];
							int num113 = array2[1];
							int num114 = array2[4];
							uint num93 = (uint)((int)num28 + num113 * (int)Class47.gstruct43_15.uint_0);
							Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_50.uint_0, array3, 4, ref int_6);
							if (BitConverter.ToInt32(array3, 0) > 0)
							{
								Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_45.uint_0, array3, 4, ref int_6);
								long num115 = BitConverter.ToInt32(array3, 0);
								if (num115 != 0L)
								{
									Class20.ReadProcessMemory(gStruct.int_130, num93 + Class47.gstruct43_43.uint_0, array3, 4, ref int_6);
									if (num112 <= 0 || BitConverter.ToInt32(array3, 0) > 0)
									{
										array8 = new uint[2]
										{
											Class20.smethod_30(num93 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
											Class20.smethod_30(num93 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
										};
										long num116 = Class53.smethod_18(array4, array8);
										if (flag16)
										{
											int num117 = (int)Math.Sqrt(num116);
											int num118 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array8));
											if (num117 - num40 > 0)
											{
												if (num118 > num117)
												{
													int num111 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array4));
													if (num111 + (num117 - num40) <= num20 + 10)
													{
														num41 = num112;
														num42 = num113;
														num43 = num114;
													}
												}
											}
											else
											{
												num41 = num112;
												num42 = num113;
												num43 = num114;
											}
										}
										else if (num116 <= num40 * num40)
										{
											num41 = num112;
											num42 = num113;
											num43 = num114;
										}
									}
								}
							}
						}
						array2[0] = num41;
						array2[1] = num42;
						array2[2] = num32;
						array2[3] = 0;
						array2[4] = num43;
						if (num42 > 0)
						{
							array2[3] = 1;
							num21 = 1;
							num22 = 1;
							flag4 = (Class20.smethod_30(num29 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
							Class53.smethod_29(gStruct, flag4, ref long_);
							if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(Class32.smethod_32(gStruct)), 4, ref int_6);
								Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num40), 4, ref int_6);
								Class20.WriteProcessMemory(gStruct.int_130, num29 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num42), 4, ref int_6);
							}
						}
						break;
					}
				}
				else
				{
					flag15 = false;
				}
			}
			else
			{
				flag15 = false;
			}
			goto IL_503b;
			IL_0e5c:
			if (gStruct.int_66 > 0)
			{
				Class53.smethod_1(gStruct, ref bool_2);
			}
			if (Class11.smethod_23(long_6) > 8000L)
			{
				Class60.smethod_50(gStruct, "Ra diem tap ket.");
				long_6 = Class11.smethod_22();
			}
			FormTapKet.smethod_0(gStruct.int_129);
			continue;
			IL_1cf6:
			int_2 = 0;
			uint_4 = null;
			array = Class38.gstruct29_0.uint_4;
			flag7 = true;
			goto IL_3432;
		}
	}
}
