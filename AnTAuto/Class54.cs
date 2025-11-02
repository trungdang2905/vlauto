using System;
using System.Threading;

internal class Class54
{
	private static int int_0 = 0;

	public static void smethod_0(int int_1)
	{
		GStruct42 gStruct = default(GStruct42);
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		int num = -1;
		int num2 = 0;
		int num3 = -1;
		int num4 = -1;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		long long_4 = 0L;
		new Random();
		uint num5 = 0u;
		uint uint_ = 0u;
		uint[] uint_2 = null;
		int int_2 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int int_3 = 0;
		long num9 = 0L;
		long num10 = 0L;
		long long_5 = 0L;
		bool flag6 = false;
		int num11 = -1;
		long long_6 = 0L;
		int int_4 = 0;
		int int_5 = 0;
		bool flag7 = false;
		uint[] array = null;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		int num15 = 0;
		int num16 = 0;
		int int_6 = -1;
		int[] array2 = new int[4];
		int int_7 = 0;
		byte[] byte_ = new byte[4];
		byte[] array3 = new byte[4];
		bool flag8 = false;
		while (true)
		{
			Thread.Sleep(200);
			num12 = Class71.smethod_3(FormMain.gstruct42_0, int_1);
			if (Class11.bool_0 || num12 < 0 || FormMain.int_20 != 1)
			{
				break;
			}
			gStruct = FormMain.gstruct42_0[num12];
			if (!gStruct.bool_36 || gStruct.bool_60 || gStruct.int_26 > 0 || gStruct.int_126[0] > 0 || gStruct.int_21[0] > 0)
			{
				break;
			}
			uint[] array5;
			int num28;
			int num30;
			int num31;
			bool flag9;
			bool flag14;
			bool flag10;
			long num43;
			uint num19;
			uint num21;
			uint[] array4;
			int num29;
			bool flag13;
			if (!gStruct.bool_21 && !gStruct.bool_6)
			{
				if (gStruct.bool_27)
				{
					FormMain.gstruct42_0[num12].bool_27 = false;
					flag5 = false;
				}
				if (FormMain.int_87 > 0 && !gStruct.bool_51 && int_0 <= 0)
				{
					int_0 = int_1;
					new Thread(smethod_1).Start();
					Thread.Sleep(300);
				}
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array3, 4, ref int_7);
				uint num17 = BitConverter.ToUInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_13.uint_0, array3, 4, ref int_7);
				uint num18 = BitConverter.ToUInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array3, 4, ref int_7);
				num19 = BitConverter.ToUInt32(array3, 0);
				uint num20 = num18 * Class47.gstruct43_15.uint_0;
				num21 = num19 + num20;
				Class20.ReadProcessMemory(gStruct.int_130, num21, array3, 4, ref int_7);
				num5 = BitConverter.ToUInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_55.uint_0, array3, 4, ref int_7);
				int num22 = BitConverter.ToInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_50.uint_0, array3, 4, ref int_7);
				int num23 = BitConverter.ToInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array3, 4, ref int_7);
				int num24 = BitConverter.ToInt32(array3, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_43.uint_0, array3, 4, ref int_7);
				int num25 = BitConverter.ToInt32(array3, 0);
				int num26 = Class73.smethod_12(gStruct);
				if (gStruct.int_129 == Class66.gstruct42_0.int_129 || gStruct.int_129 == Class38.gstruct29_0.int_0)
				{
					switch (num26)
					{
					case 2:
						Thread.Sleep(180);
						continue;
					case 1:
						if (num14 > 0 || (num16 > 1 && num25 > 0))
						{
							Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
						}
						if (num16 > 3)
						{
							num15 = 0;
						}
						num16++;
						num14 = 0;
						continue;
					}
				}
				if (num15 <= 0)
				{
					array2[0] = 0;
					array2[1] = 0;
					array2[2] = 0;
					array2[3] = 0;
				}
				num15 = 0;
				num16 = 0;
				int num27 = Class73.smethod_40(gStruct);
				if (num23 != 0 && num22 != 0 && num24 != 0 && num22 != 10 && num22 != 21 && num27 > 1)
				{
					array4 = new uint[2]
					{
						Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
						Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
					};
					array5 = new uint[2];
					if (array4[0] == 0 || array4[1] == 0)
					{
						continue;
					}
					if (!flag8)
					{
						if (num3 == num24)
						{
							if (num4 == num25)
							{
								num28 = 600;
								if (gStruct.int_94 > 0)
								{
									num28 = gStruct.int_95;
								}
								num29 = gStruct.int_128;
								if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
								{
									num29 = gStruct.int_93;
								}
								if (num29 <= 0)
								{
									num29 = 500;
								}
								num13 = FormMain.int_23;
								if (gStruct.int_129 != Class38.gstruct29_0.int_0)
								{
									if (num29 <= 180 && num13 < FormMain.int_51)
									{
										num13 = FormMain.int_51;
									}
									if (gStruct.int_123[0] > 0 && FormMain.int_27 > 0 && num13 > 180)
									{
										num13 = 180;
									}
								}
								array = array4;
								flag7 = false;
								num30 = 0;
								num31 = 0;
								flag9 = false;
								flag10 = false;
								int[] array6 = Class50.smethod_0(num24);
								int num32 = Class50.smethod_2(num24);
								if (array6 == null && 0 > num32 && (Class53.smethod_7(num24) != null || 0 > Class50.smethod_3(array4, num24)))
								{
									if (num24 == 221)
									{
										Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
										if (Class17.smethod_0(gStruct) > 0)
										{
											continue;
										}
									}
									if (Class11.smethod_23(long_5) > 30000L)
									{
										Class60.smethod_50(gStruct, "<color=yellow>[*] TONG KIM - PHLT...");
										long_5 = Class11.smethod_22();
									}
									if (FormMain.int_44[0] > 0)
									{
										Class50.smethod_8(int_1);
										continue;
									}
									if (num25 <= 0)
									{
										uint num33 = num17 + Class47.gstruct43_12.uint_0 + Class47.gstruct43_75.uint_0;
										uint num34 = Class20.smethod_30(num33 + Class47.gstruct43_73.uint_0, gStruct.int_130);
										int num35 = gStruct.int_67;
										if (num35 < 2500000)
										{
											num35 = 2500000;
										}
										if (flag4 && gStruct.bool_29)
										{
											bool flag11 = false;
											if (num25 == 0)
											{
												flag11 = (Class81.smethod_0(gStruct, bool_0: true) != 1);
											}
											num12 = Class71.smethod_3(FormMain.gstruct42_0, int_1);
											if (0 <= num12)
											{
												FormMain.gstruct42_0[num12].bool_29 = flag11;
											}
											if (!flag11)
											{
												Class11.smethod_22();
											}
										}
										else if (!flag4 && num34 != num35)
										{
											if (num34 <= num35)
											{
												uint num36 = Class20.smethod_30(num33 + Class47.gstruct43_74.uint_0, gStruct.int_130);
												if (num36 == 0)
												{
													continue;
												}
												int num37 = num35 - (int)num34;
												if (num37 > num36)
												{
													num37 = (int)num36;
												}
												if (!flag && gStruct.string_13 != null && gStruct.string_13 != string.Empty)
												{
													uint num38 = Class11.smethod_13(gStruct.string_13);
													if (num38 != 0)
													{
														Class60.smethod_113(gStruct, num38);
														flag = true;
														Thread.Sleep(300);
													}
												}
												Class60.smethod_35(gStruct, (uint)num37);
											}
											else
											{
												Class60.smethod_36(gStruct, (uint)((int)num34 - num35));
												flag4 = true;
											}
										}
										else
										{
											flag4 = true;
										}
										continue;
									}
									flag4 = false;
								}
								if (Class20.smethod_30(num21 + Class47.gstruct43_43.uint_0, gStruct.int_130) == 0)
								{
									if (gStruct.int_129 == Class38.gstruct29_0.int_0 && FormMain.int_83 <= 0 && ((FormMain.int_6 <= 0 && FormMain.int_7 <= 0) || Class38.gstruct29_1.int_4 <= 0))
									{
										Thread.Sleep(300);
									}
									else if (FormMain.int_86 <= 0 && (!flag5 || num < 0 || num != Class69.smethod_2(gStruct)))
									{
										if (!FormMain.bool_3)
										{
											num2++;
											int num39 = Class50.smethod_6(gStruct);
											if (num39 <= 0 && num2 < 6)
											{
												Class53.smethod_11(gStruct);
												Thread.Sleep(300);
												continue;
											}
										}
										num2 = 0;
										flag5 = true;
										num = Class69.smethod_2(gStruct);
										uint num40 = 1500000u;
										uint num33 = num17 + Class47.gstruct43_12.uint_0 + Class47.gstruct43_75.uint_0;
										uint num34 = Class20.smethod_30(num33 + Class47.gstruct43_73.uint_0, gStruct.int_130);
										uint num36 = Class20.smethod_30(num33 + Class47.gstruct43_74.uint_0, gStruct.int_130);
										if (num34 > 1500000)
										{
											Class60.smethod_36(gStruct, num34 - num40);
										}
										else
										{
											if (num36 == 0 || num34 >= num40 / 2u)
											{
												continue;
											}
											int num37 = (int)(num40 - num34);
											if (num37 > num36)
											{
												num37 = (int)num36;
											}
											if (!flag && gStruct.string_13 != null && gStruct.string_13 != string.Empty)
											{
												uint num38 = Class11.smethod_13(gStruct.string_13);
												if (num38 != 0)
												{
													Class60.smethod_113(gStruct, num38);
													flag = true;
													Thread.Sleep(300);
												}
											}
											Class60.smethod_35(gStruct, (uint)num37);
										}
									}
									else if (0 <= num32)
									{
										if ((gStruct.int_129 == Class38.gstruct29_0.int_0 && (FormMain.int_83 > 0 || ((FormMain.int_6 > 0 || FormMain.int_7 > 0) && Class38.gstruct29_1.int_4 > 0))) || (gStruct.int_129 != Class38.gstruct29_0.int_0 && (FormMain.int_84 <= 0 || Class38.gstruct29_0.int_3 > 0)))
										{
											Class53.smethod_22(gStruct, Class50.uint_1, null, null, num24);
										}
									}
									else
									{
										bool flag12 = false;
										if (FormMain.int_85 > 0)
										{
											flag12 = (Class50.smethod_4(gStruct) > 0);
										}
										if (!flag12)
										{
											Class50.smethod_5(gStruct);
										}
										if (Class76.smethod_0(gStruct))
										{
											Class76.smethod_6(gStruct, 0);
											Thread.Sleep(100);
										}
									}
									continue;
								}
								flag5 = false;
								flag13 = false;
								if (Class20.smethod_30(num21 + Class47.gstruct43_43.uint_0, gStruct.int_130) == 0)
								{
									continue;
								}
								if (gStruct.int_64 > 0 && (num < 0 || num != Class69.smethod_2(gStruct)))
								{
									Class53.smethod_15(gStruct, gStruct.string_5);
									num = Class69.smethod_2(gStruct);
								}
								if (gStruct.int_65[0] > 0 && Class11.smethod_23(long_6) > (1 + gStruct.int_65[2]) * 1000)
								{
									if (num11 < 0 || num11 != Class69.smethod_2(gStruct))
									{
										num11 = Class69.smethod_2(gStruct);
										flag6 = true;
									}
									if (flag6)
									{
										uint num41 = Class20.smethod_30(num21 + Class47.uint_1, gStruct.int_130);
										uint num42 = Class20.smethod_30(num21 + Class47.uint_2, gStruct.int_130);
										if (num41 < num42 && num42 < num41 * 3)
										{
											num41 = num42;
										}
										if (num41 <= gStruct.int_65[1])
										{
											flag6 = Class53.smethod_16(gStruct, gStruct.string_6);
											Thread.Sleep(300);
										}
										num11 = Class69.smethod_2(gStruct);
									}
									long_6 = Class11.smethod_22();
								}
								flag14 = ((FormMain.int_6 > 0 || FormMain.int_7 > 0) && FormMain.int_21 > 0 && (Class38.gstruct29_1.int_3 > 0 || FormMain.int_22 > 0) && Class38.gstruct29_1.int_4 > 0 && Class11.smethod_57(Class38.gstruct29_1.uint_4) && (gStruct.int_129 == Class38.gstruct29_0.int_0 || Class38.gstruct29_0.int_0 <= 0));
								flag2 = (FormMain.int_21 > 0 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_0 != gStruct.int_129 && Class38.gstruct29_0.int_6 > 0 && Class38.gstruct29_0.int_4 == num24 && Class11.smethod_57(Class38.gstruct29_0.uint_4) && Class38.gstruct29_0.int_3 > 0);
								flag10 = (!gStruct.bool_33 && (FormMain.int_31 > 0 || FormMain.int_30 > 0));
								array4 = new uint[2]
								{
									Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
									Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
								};
								if (flag2 && gStruct.int_129 != Class38.gstruct29_0.int_0)
								{
									array4 = new uint[2]
									{
										Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
										Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
									};
									num43 = Class53.smethod_18(array4, Class38.gstruct29_0.uint_4);
									if (flag3 || num43 > num13 * num13)
									{
										goto IL_105d;
									}
									Class12.smethod_3(gStruct, bool_0: false);
									int num44 = num6;
									num6 = 0;
									int_2 = 0;
									if (num25 > 0 && !gStruct.bool_33 && gStruct.bool_64 && gStruct.int_90 == 1 && FormMain.int_96 > 0 && (FormMain.int_31 > 0 || FormMain.int_30 > 0 || FormMain.int_32 > 0) && Class20.smethod_30(num21 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0 && Class20.smethod_30(num21 + Class47.gstruct43_43.uint_0, gStruct.int_130) != 0 && Class11.smethod_23(long_3) > 600L)
									{
										Class60.smethod_55(gStruct, "Switch([[horse]])");
										long_3 = Class11.smethod_22();
									}
									if (num10 <= 0L || Class11.smethod_23(num10) >= 1500L)
									{
										uint[] uint_3 = new uint[2]
										{
											array4[0],
											array4[1]
										};
										if (Class38.smethod_4(num5, ref array4, ref uint_) > 0)
										{
											long num45 = Class53.smethod_18(uint_3, Class38.gstruct29_0.uint_4);
											long num46 = Class53.smethod_18(array4, Class38.gstruct29_0.uint_4);
											if (num46 > num13 * num13)
											{
												if (num44 > 0)
												{
													uint[] uint_4 = Class53.smethod_3(array4, Class38.gstruct29_0.uint_4, -100);
													Class60.smethod_61(gStruct, uint_4);
													Thread.Sleep(120);
												}
												goto IL_105d;
											}
											num10 = Class11.smethod_22();
											if (num14 > 0)
											{
												Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
											}
											num14 = 0;
											Class38.smethod_5(gStruct, array4, Class38.gstruct29_0.uint_4, num45 <= 5625L);
											goto IL_29fc;
										}
										num10 = 0L;
										if (num14 == 0 && Class53.smethod_18(uint_3, Class38.gstruct29_0.uint_4) > FormMain.int_23 * FormMain.int_23)
										{
											num7++;
											if (num7 > 3)
											{
												Class60.smethod_61(gStruct, Class38.gstruct29_0.uint_4);
												Thread.Sleep(150);
												num7 = 0;
											}
										}
										if (FormMain.int_27 > 0 && num25 > 0 && gStruct.int_123[0] > 0 && Class60.smethod_3(gStruct, Class60.uint_13) == 0)
										{
											Class60.smethod_2(gStruct, Class60.uint_13, 1, 4);
										}
									}
									int_2 = 0;
									uint_2 = null;
									array = Class38.gstruct29_0.uint_4;
									flag7 = true;
								}
								else
								{
									if (gStruct.int_68 != null && gStruct.int_68[0] > 0 && !FormMayphu.bool_3)
									{
										uint[] array7 = null;
										if (num9 <= 0L || Class11.smethod_23(num9) >= 1000L)
										{
											array7 = Class53.smethod_26(gStruct, ref int_3);
											if (array7 == null)
											{
												num9 = Class11.smethod_22();
											}
											else
											{
												num9 = 0L;
												long num47 = Class53.smethod_18(array4, array7);
												if (num47 < 8000L)
												{
													goto IL_14b5;
												}
												if (num47 >= 15000L && num47 >= gStruct.int_68[1] * gStruct.int_68[1])
												{
													if (num47 < 360000L)
													{
														Class12.smethod_3(gStruct, bool_0: false);
														if (num14 > 0)
														{
															Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
														}
														num14 = 0;
														Class60.smethod_61(gStruct, array7);
														Thread.Sleep(150);
														continue;
													}
													if (num47 < 1200000L)
													{
														if (Class11.smethod_23(long_) > 3000L)
														{
															Class12.smethod_1(gStruct, array7);
															long_ = Class11.smethod_22();
														}
														continue;
													}
												}
												else
												{
													if (num22 <= 3 && num47 > 7500L)
													{
														if (num14 > 0)
														{
															Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
														}
														num14 = 0;
														Class60.smethod_61(gStruct, array7);
														Thread.Sleep(150);
														goto IL_29fc;
													}
													num47 = 4L;
												}
											}
										}
									}
									if (flag14)
									{
										int num48 = FormMayphu.smethod_7(gStruct, ref long_, ref int_2, ref uint_2);
										if (num48 <= 0)
										{
											Thread.Sleep(100);
											continue;
										}
										num22 = (int)Class20.smethod_30(num21 + Class47.gstruct43_55.uint_0, gStruct.int_130);
										if (num22 < 3)
										{
											array4 = new uint[2]
											{
												Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
												Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
											};
											if (Class53.smethod_18(array4, Class38.gstruct29_1.uint_4) > 5625L)
											{
												if (num14 > 0)
												{
													Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
												}
												num14 = 0;
												Class60.smethod_61(gStruct, Class38.gstruct29_1.uint_4);
												Thread.Sleep(150);
											}
										}
									}
								}
								goto IL_14b5;
							}
							uint_2 = null;
							int_2 = 0;
							int num49 = 0;
							while (num25 == 0 && num49 < 30 && num25 != num4)
							{
								Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array3, 4, ref int_7);
								num17 = BitConverter.ToUInt32(array3, 0);
								Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_13.uint_0, array3, 4, ref int_7);
								num18 = BitConverter.ToUInt32(array3, 0);
								num20 = num18 * Class47.gstruct43_15.uint_0;
								Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array3, 4, ref int_7);
								num19 = BitConverter.ToUInt32(array3, 0);
								num21 = num19 + num20;
								Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_43.uint_0, array3, 4, ref int_7);
								num25 = BitConverter.ToInt32(array3, 0);
								Thread.Sleep(10);
								num49++;
							}
							num4 = num25;
							Thread.Sleep(100);
							Class76.smethod_9(gStruct);
							continue;
						}
						flag5 = false;
						flag = false;
						uint_2 = null;
						int_2 = 0;
						int num50 = 0;
						while (num3 != num24)
						{
							int num51 = Class73.smethod_40(gStruct);
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array3, 4, ref int_7);
							num17 = BitConverter.ToUInt32(array3, 0);
							Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_13.uint_0, array3, 4, ref int_7);
							num18 = BitConverter.ToUInt32(array3, 0);
							num20 = num18 * Class47.gstruct43_15.uint_0;
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array3, 4, ref int_7);
							num19 = BitConverter.ToUInt32(array3, 0);
							num21 = num19 + num20;
							Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_50.uint_0, array3, 4, ref int_7);
							num23 = BitConverter.ToInt32(array3, 0);
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array3, 4, ref int_7);
							num24 = BitConverter.ToInt32(array3, 0);
							Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_43.uint_0, array3, 4, ref int_7);
							num25 = BitConverter.ToInt32(array3, 0);
							Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
							num14 = 0;
							if (num25 > 0 || num50 > 8 || (num51 != 0 && num51 != 1 && num23 > 0 && num24 > 0))
							{
								break;
							}
							num50++;
							Thread.Sleep(100);
						}
						num3 = num24;
						continue;
					}
					flag8 = false;
					Thread.Sleep(300);
					continue;
				}
				if (num27 <= 1)
				{
					flag = false;
				}
				flag8 = (num22 == 10 || num22 == 21);
				Thread.Sleep(60);
				continue;
			}
			flag5 = false;
			continue;
			IL_105d:
			flag3 = (num43 > 40000L);
			Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
			num14 = 0;
			if (uint_2 == null)
			{
				uint_2 = new uint[2]
				{
					array4[0],
					array4[1]
				};
				int_2 = 0;
			}
			if (int_2 > 6)
			{
				long num52 = Class53.smethod_18(uint_2, array4);
				uint_2 = null;
				if (num52 < 180000L)
				{
					Class12.smethod_3(gStruct, bool_0: false);
					Class53.smethod_0(gStruct, array4, Class38.gstruct29_0.uint_4, 600);
					goto IL_29fc;
				}
				int_2 = 0;
			}
			if (num43 > FormMain.int_95 * FormMain.int_95)
			{
				Class6.smethod_2(gStruct, num21, ref long_3, bool_0: true);
			}
			if (num43 < 900000L && num6 < 6)
			{
				num6++;
				Class12.smethod_3(gStruct, bool_0: false);
				Class60.smethod_61(gStruct, Class38.gstruct29_0.uint_4);
				Thread.Sleep(150);
				goto IL_29fc;
			}
			if (Class38.gstruct29_0.uint_4 != null && (!Class12.smethod_4(gStruct) || Class11.smethod_23(long_) > 4000L))
			{
				Class12.smethod_1(gStruct, Class38.gstruct29_0.uint_4);
				Thread.Sleep(300);
				long_ = Class11.smethod_22();
				int_2++;
				num6 = 0;
			}
			continue;
			IL_16a9:
			int num53 = 0;
			goto IL_1a41;
			IL_14b5:
			if (gStruct.int_97[0] > 0 && gStruct.int_97[1] > 0 && gStruct.string_21 == "NGAMY")
			{
				long num54 = Class11.smethod_23(long_2);
				if (num54 < 300L)
				{
					continue;
				}
				if (num54 > gStruct.int_97[4] && Class7.smethod_3(gStruct))
				{
					Thread.Sleep(80);
					long_2 = Class11.smethod_22();
					continue;
				}
			}
			if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
			{
				if (!gStruct.bool_33)
				{
					bool flag15 = gStruct.int_122[0] > 0 && gStruct.int_122[1] > 0 && gStruct.int_122[2] > 0;
					bool flag16 = gStruct.int_122[0] > 0 && gStruct.int_122[3] > 0 && gStruct.int_122[4] > 0;
					bool flag17 = gStruct.int_122[0] > 0 && gStruct.int_122[5] > 0 && gStruct.int_122[6] > 0;
					flag9 = ((flag15 || flag16 || flag17) && gStruct.string_21 == "DUONGMON");
					if (FormDame.int_6 <= 0 || flag9)
					{
						goto IL_1a41;
					}
					if (flag10 || FormDame.int_7 > 0)
					{
						num53 = 0;
						if (FormDame.int_5 == 0)
						{
							goto IL_16e2;
						}
						bool flag18 = Class38.gstruct29_0.int_8 == 1 || (flag14 && Class38.gstruct29_1.int_8 == 1);
						if (FormDame.int_5 != 1)
						{
							if (FormDame.int_5 != 2 || flag18)
							{
								goto IL_16a9;
							}
							if (num14 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
							}
							num14 = 0;
						}
						else
						{
							if (flag18)
							{
								goto IL_16e2;
							}
							if (FormDame.int_8 > 0)
							{
								goto IL_16a9;
							}
							if (num14 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
							}
							num14 = 0;
						}
					}
				}
				else if (gStruct.int_129 != Class38.gstruct29_0.int_0)
				{
					Class6.smethod_2(gStruct, num21, ref long_3, bool_0: true);
				}
			}
			goto IL_29fc;
			IL_1a41:
			if (flag10)
			{
				if (!Class38.smethod_6(gStruct, ref int_6) && Class73.smethod_12(gStruct) != 1)
				{
					int num24 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
					array4 = new uint[2]
					{
						Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
						Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
					};
					uint[] uint_5 = array4;
					if (flag2 && Class38.gstruct29_0.int_4 == num24 && Class38.gstruct29_0.int_3 > 0 && Class38.gstruct29_0.uint_4 != null)
					{
						uint_5 = Class38.gstruct29_0.uint_4;
						num28 += num13;
					}
					uint num55 = 0u;
					if (FormMain.int_33 > 0 && (flag14 || flag2))
					{
						if (flag14)
						{
							if (Class38.gstruct29_1.int_4 == num24 && Class38.gstruct29_1.uint_3 != num5)
							{
								num55 = Class38.gstruct29_1.uint_3;
							}
						}
						else if (flag2 && Class38.gstruct29_0.int_4 == num24 && Class38.gstruct29_0.uint_3 != num5)
						{
							num55 = Class38.gstruct29_0.uint_3;
						}
						if (num55 == 0 && FormMain.int_34 <= 0)
						{
							goto IL_29fc;
						}
					}
					int[,] array8 = null;
					if (gStruct.int_116 > 0 && gStruct.int_3 != null)
					{
						array8 = ((gStruct.int_5 > 0) ? Class7.smethod_5(gStruct, num55, num28, uint_5, null, bool_2: false, FormMain.int_90 > 0) : Class7.smethod_6(gStruct, num55, num28, uint_5, null, bool_2: false, FormMain.int_90 > 0));
						if (array8 != null && array8[0, 0] >= 0)
						{
							int num56 = -1;
							int int_8 = Class38.gstruct29_0.int_4;
							num14 = 0;
							bool flag19 = false;
							bool flag20 = false;
							while (true)
							{
								int num57 = 0;
								int num58 = 400;
								uint num59 = 0u;
								while (num57 <= 0)
								{
									num56++;
									if (gStruct.int_3 != null && gStruct.int_3.Length > num56)
									{
										num57 = gStruct.int_3[num56];
										if (num57 > 0)
										{
											num58 = Class67.smethod_21(num57);
											break;
										}
										continue;
									}
									goto IL_20c7;
								}
								int num22 = (int)Class20.smethod_30(num21 + Class47.gstruct43_55.uint_0, gStruct.int_130);
								int num23 = (int)Class20.smethod_30(num21 + Class47.gstruct43_50.uint_0, gStruct.int_130);
								int num25 = (int)Class20.smethod_30(num21 + Class47.gstruct43_43.uint_0, gStruct.int_130);
								int num60 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
								if (num25 > 0 && num24 == num60 && num22 != 11 && num22 != 22 && num23 != 0)
								{
									for (int i = 0; i < array8.GetLength(0); i++)
									{
										int num64;
										if (!Class38.smethod_6(gStruct, ref int_6) && Class73.smethod_12(gStruct) != 1)
										{
											num30 = array8[i, 0];
											num31 = array8[i, 1];
											if (num31 <= 0)
											{
												continue;
											}
											num59 = (uint)((int)num19 + num31 * (int)Class47.gstruct43_15.uint_0);
											Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_50.uint_0, array3, 4, ref int_7);
											if (BitConverter.ToInt32(array3, 0) <= 0)
											{
												continue;
											}
											if (num30 > 0)
											{
												Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_43.uint_0, array3, 4, ref int_7);
												if (BitConverter.ToInt32(array3, 0) <= 0)
												{
													continue;
												}
											}
											flag19 = true;
											if (!flag20 || num30 > 0)
											{
												if (num30 > 0)
												{
													flag20 = true;
												}
												if (Class86.smethod_30(gStruct, num31, num57) != 0)
												{
													continue;
												}
												num29 = num58;
												Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array3, 4, ref int_7);
												array5[0] = BitConverter.ToUInt32(array3, 0);
												Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array3, 4, ref int_7);
												array5[1] = BitConverter.ToUInt32(array3, 0);
												array4 = new uint[2]
												{
													Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
													Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
												};
												if (flag2)
												{
													array4 = new uint[2]
													{
														Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
														Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
													};
													long num61 = Class53.smethod_18(array4, Class38.gstruct29_0.uint_4);
													if (int_8 != Class38.gstruct29_0.int_4 || num61 > num13 * num13)
													{
														goto IL_248e;
													}
													int num62 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array5));
													int num63 = (int)Math.Sqrt(Class53.smethod_18(array4, array5));
													num64 = num62 - num13 + 10;
													int num65;
													if (num62 > num13 && num29 < num64)
													{
														if (num63 <= num62)
														{
															if (num63 < num62 && num29 < num63)
															{
																goto IL_1ff2;
															}
															goto IL_1ff6;
														}
														num65 = 0;
													}
													else
													{
														num65 = 1;
													}
													if (num65 == 0)
													{
														goto IL_1ff2;
													}
												}
												goto IL_1ff6;
											}
											goto IL_20c7;
										}
										goto IL_24b2;
										IL_1ff6:
										if (Class53.smethod_18(array4, array5) <= num29 * num29 || gStruct.int_92 > 0)
										{
											if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
											{
												Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(num57), 4, ref int_7);
												Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num29), 4, ref int_7);
												Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num31), 4, ref int_7);
												Thread.Sleep(10);
											}
											num14 = 1;
										}
										continue;
										IL_1ff2:
										num29 = num64;
										goto IL_1ff6;
									}
									continue;
								}
								if (num14 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
								}
								num14 = 0;
								break;
								IL_24b2:
								Thread.Sleep(120);
								num14 = 0;
								break;
								IL_20c7:
								if (num14 <= 0 && gStruct.int_6 <= 0 && flag19)
								{
									long num66 = 0L;
									array4 = new uint[2]
									{
										Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
										Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
									};
									num30 = -1;
									num31 = -1;
									flag20 = false;
									num29 = gStruct.int_128;
									if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
									{
										num29 = gStruct.int_93;
									}
									if (num29 <= 0)
									{
										num29 = 500;
									}
									for (int i = 0; i < array8.GetLength(0); i++)
									{
										int num67 = array8[i, 0];
										int num68 = array8[i, 1];
										int num69 = num29;
										if (num68 <= 0)
										{
											continue;
										}
										num59 = (uint)((int)num19 + num68 * (int)Class47.gstruct43_15.uint_0);
										Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_50.uint_0, array3, 4, ref int_7);
										if (BitConverter.ToInt32(array3, 0) <= 0)
										{
											continue;
										}
										if (num67 > 0)
										{
											Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_43.uint_0, array3, 4, ref int_7);
											if (BitConverter.ToInt32(array3, 0) <= 0)
											{
												continue;
											}
										}
										if (flag20 && num67 <= 0 && num31 > 0)
										{
											break;
										}
										Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array3, 4, ref int_7);
										array5[0] = BitConverter.ToUInt32(array3, 0);
										Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array3, 4, ref int_7);
										array5[1] = BitConverter.ToUInt32(array3, 0);
										long num70 = Class53.smethod_18(array4, array5);
										if (num31 > 0 && num66 < num70)
										{
											continue;
										}
										int num64;
										if (flag2)
										{
											int num62 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array5));
											int num63 = (int)Math.Sqrt(Class53.smethod_18(array4, array5));
											num64 = num62 - num13 + 10;
											int num71;
											if (num62 > num13 && num69 < num64)
											{
												if (num63 <= num62)
												{
													if (num63 < num62 && num69 < num63)
													{
														goto IL_233c;
													}
													goto IL_2340;
												}
												num71 = 0;
											}
											else
											{
												num71 = 1;
											}
											if (num71 == 0)
											{
												goto IL_233c;
											}
										}
										goto IL_2340;
										IL_233c:
										num69 = num64;
										goto IL_2340;
										IL_2340:
										if (num70 <= num69 * num69 || gStruct.int_92 > 0)
										{
											if (num67 > 0)
											{
												flag20 = true;
											}
											num31 = num68;
											num30 = num67;
											num66 = num70;
											num29 = num69;
										}
									}
									if (num31 > 0)
									{
										flag13 = (Class20.smethod_30(num21 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
										Class53.smethod_29(gStruct, flag13, ref long_3);
										if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
										{
											Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(Class32.smethod_32(gStruct)), 4, ref int_7);
											Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num29), 4, ref int_7);
											Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num31), 4, ref int_7);
										}
									}
								}
								else if (flag19 && num14 <= 0 && gStruct.int_6 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
								}
								break;
								IL_248e:
								Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
								break;
							}
						}
					}
					else if (!(flag10 = (!gStruct.bool_33 && (FormMain.int_31 > 0 || FormMain.int_30 > 0))))
					{
						flag10 = false;
					}
					else
					{
						array8 = Class7.smethod_5(gStruct, num55, num28, uint_5, null, bool_2: false, FormMain.int_90 > 0);
						if (array8 != null)
						{
							if (array8[0, 0] == -100)
							{
								continue;
							}
							int num72 = 0;
							while (true)
							{
								if (array8[num72, 1] > 0)
								{
									array5 = new uint[2]
									{
										(uint)array8[num72, 4],
										(uint)array8[num72, 5]
									};
									if (flag2)
									{
										int num63 = (int)Math.Sqrt(Class53.smethod_18(array4, array5));
										int num62 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array5));
										if (num63 - num29 > 0)
										{
											if (num62 > num63)
											{
												int num73 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array4));
												if (num73 + (num63 - num29) <= num13 + 10)
												{
													goto IL_26ae;
												}
											}
											if (gStruct.int_86 == 1 && num72 == 0)
											{
												num72 = 1;
												continue;
											}
											if (num13 + num29 <= num62)
											{
												if (num14 > 0)
												{
													Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
												}
												num14 = 0;
												break;
											}
										}
									}
									else if (Class53.smethod_18(array4, array5) > num29 * num29 && gStruct.int_92 <= 0)
									{
										if (gStruct.int_86 != 1 || num72 != 0)
										{
											break;
										}
										num72 = 1;
										continue;
									}
									goto IL_26ae;
								}
								if (num14 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
								}
								num14 = 0;
								break;
								IL_26ae:
								num30 = array8[num72, 0];
								num31 = array8[num72, 1];
								if (FormMain.int_50 > 0 && (num30 <= 0 || num30 == array2[0]) && array2[1] > 0 && array2[2] == num24 && array2[3] > 0)
								{
									int num74 = array2[0];
									int num75 = array2[1];
									uint num59 = (uint)((int)num19 + num75 * (int)Class47.gstruct43_15.uint_0);
									Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_50.uint_0, array3, 4, ref int_7);
									if (BitConverter.ToInt32(array3, 0) > 0)
									{
										Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_45.uint_0, array3, 4, ref int_7);
										long num76 = BitConverter.ToInt32(array3, 0);
										if (num76 != 0L)
										{
											Class20.ReadProcessMemory(gStruct.int_130, num59 + Class47.gstruct43_43.uint_0, array3, 4, ref int_7);
											if (num74 <= 0 || BitConverter.ToInt32(array3, 0) > 0)
											{
												array5 = new uint[2]
												{
													Class20.smethod_30(num59 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
													Class20.smethod_30(num59 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
												};
												long num77 = Class53.smethod_18(array4, array5);
												if (!flag2)
												{
													if (num77 <= num29 * num29)
													{
														num30 = num74;
														num31 = num75;
													}
												}
												else
												{
													int num78 = (int)Math.Sqrt(num77);
													int num79 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array5));
													if (num78 - num29 <= 0)
													{
														num30 = num74;
														num31 = num75;
													}
													else if (num79 > num78)
													{
														int num73 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array4));
														if (num73 + (num78 - num29) <= num13 + 10)
														{
															num30 = num74;
															num31 = num75;
														}
													}
												}
											}
										}
									}
								}
								array2[0] = num30;
								array2[1] = num31;
								array2[2] = num24;
								array2[3] = 0;
								if (num31 > 0)
								{
									array2[3] = 1;
									num14 = 1;
									num15 = 1;
									flag13 = (Class20.smethod_30(num21 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
									Class53.smethod_29(gStruct, flag13, ref long_3);
									if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
									{
										int value = Class32.smethod_32(gStruct);
										Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(value), 4, ref int_7);
										Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num29), 4, ref int_7);
										Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num31), 4, ref int_7);
									}
								}
								break;
							}
						}
						else
						{
							flag10 = false;
						}
					}
				}
				else
				{
					Thread.Sleep(80);
					num14 = 0;
				}
			}
			goto IL_29fc;
			IL_29fc:
			if (!flag10 && gStruct.int_129 != Class38.gstruct29_0.int_0 && Class32.smethod_59(gStruct, new int[2]
			{
				0,
				1
			}) != 0)
			{
				if (num14 > 0)
				{
					Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_7);
				}
				num14 = 0;
			}
			if (flag9 && num31 <= 0)
			{
				FormDuongMon.smethod_0(gStruct, ref int_4, array, ref int_5, flag7);
			}
			if (!gStruct.bool_66 || gStruct.int_81 <= 0)
			{
				continue;
			}
			if (FormMain.int_93 == 0)
			{
				if (num31 > 0 && num30 > 0 && Class11.smethod_23(long_4) > gStruct.long_7)
				{
					Class32.smethod_55(gStruct, array5, bool_0: false);
					Class32.smethod_56(gStruct);
					long_4 = Class11.smethod_22();
				}
			}
			else if (Class38.gstruct29_0.int_7 == Class24.gstruct38_0[FormMain.int_94].int_0)
			{
				Class32.smethod_55(gStruct, null, bool_0: true);
				if (Class11.smethod_23(long_4) > gStruct.long_7)
				{
					Class32.smethod_56(gStruct);
					long_4 = Class11.smethod_22();
				}
			}
			continue;
			IL_16e2:
			uint num80 = 0u;
			uint[] array9 = null;
			uint[] uint_6 = null;
			if (!flag14)
			{
				if (gStruct.int_129 != Class38.gstruct29_0.int_0 && gStruct.int_129 != Class66.gstruct42_0.int_129 && Class38.gstruct29_0.uint_5 != 0)
				{
					uint num81 = Class38.gstruct29_0.uint_5 >> 16;
					uint num82 = Class38.gstruct29_0.uint_5 - (num81 << 16);
					array9 = Class73.smethod_11(Class38.gstruct29_0.uint_4, (int)num82, (int)num81);
					uint[] array10 = Class73.smethod_10(array4, array9);
					num80 = (array10[1] << 16) + array10[0];
					uint_6 = Class38.gstruct29_0.uint_4;
					Class73.smethod_7(gStruct, num80);
				}
			}
			else
			{
				uint num81 = Class38.gstruct29_1.uint_5 >> 16;
				uint num82 = Class38.gstruct29_1.uint_5 - (num81 << 16);
				array9 = Class73.smethod_11(Class38.gstruct29_1.uint_4, (int)num82, (int)num81);
				uint[] array10 = Class73.smethod_10(array4, array9);
				num80 = (array10[1] << 16) + array10[0];
				uint_6 = Class38.gstruct29_1.uint_4;
				Class73.smethod_7(gStruct, num80);
			}
			flag13 = (Class20.smethod_30(num21 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
			Class53.smethod_30(gStruct, flag13, ref long_3);
			if (gStruct.int_121[0] > 0)
			{
				bool flag21 = gStruct.int_121[1] > 0 && gStruct.int_121[2] > 0;
				bool flag22 = gStruct.int_121[3] > 0 && gStruct.int_121[4] > 0;
				if (flag21 && !flag22)
				{
					num53 = gStruct.int_121[2];
				}
				else if (flag22 && !flag21)
				{
					num53 = gStruct.int_121[4];
				}
				else if (flag21 && flag22)
				{
					num53 = ((0 > num8 || num8 > 25) ? gStruct.int_121[4] : gStruct.int_121[2]);
					if (num8 > 35)
					{
						num8 = 0;
					}
					num8++;
				}
			}
			if (num53 <= 0)
			{
				num53 = Class32.smethod_32(gStruct);
			}
			if (gStruct.int_129 != Class38.gstruct29_0.int_0 || FormMain.int_6 > 0 || FormMain.int_7 > 0)
			{
				Class67.smethod_7(gStruct);
			}
			Class67.smethod_3(gStruct, num53, 6, 1);
			for (int j = 0; j < 3; j++)
			{
				Class20.smethod_75(gStruct.uint_4, 117);
				if (j < 2)
				{
					Thread.Sleep(60);
				}
			}
			if (num80 != 0 && gStruct.int_129 != Class66.gstruct42_0.int_129)
			{
				if (gStruct.int_92 <= 0)
				{
					Class20.smethod_30(num21 + Class47.gstruct43_31.uint_0, gStruct.int_130);
					int num83 = Class32.smethod_32(gStruct);
					if (num83 == 53 || num83 <= 1)
					{
						goto IL_29fc;
					}
					if (num83 <= 100)
					{
						num83 = 400;
					}
				}
				string string_ = Class73.smethod_20(gStruct);
				if (Class11.smethod_3(string_, "iÓm qu\u00b8 x"))
				{
					uint[] array11 = Class53.smethod_3(uint_6, array9, -1 * (FormMain.int_23 - 50));
					long num84 = Class53.smethod_18(array4, array11);
					if (num84 > 7000L)
					{
						Class60.smethod_61(gStruct, array11);
						Thread.Sleep(150);
						Class73.smethod_21(gStruct, "0K..");
					}
				}
			}
			goto IL_29fc;
		}
	}

	private static void smethod_1()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || (FormMain.int_20 != 1 && FormMain.int_20 != 3) || FormMain.int_87 <= 0)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_51 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_51)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_51 = true;
					flag = true;
				}
				smethod_2(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_2(int int_1)
	{
		int num = 0;
		int num2 = 0;
		int int_2 = 0;
		GStruct42 gstruct42_ = default(GStruct42);
		byte[] array = null;
		uint uint_ = 0u;
		while (true)
		{
			num2--;
			Thread.Sleep(300);
			if (Class11.bool_0 || (FormMain.int_20 != 1 && FormMain.int_20 != 3) || FormMain.int_87 <= 0)
			{
				break;
			}
			if (num2 <= 0)
			{
				num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
				if (num < 0 || !FormMain.gstruct42_0[num].bool_36)
				{
					break;
				}
				num2 = 3;
			}
			gstruct42_ = FormMain.gstruct42_0[num];
			uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
			uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gstruct42_.int_130);
			uint num5 = num4 * Class47.gstruct43_15.uint_0;
			uint num6 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
			uint num7 = num6 + num5;
			uint_ = num7 + Class47.gstruct43_86.uint_0;
			int num8 = Class73.smethod_37(gstruct42_);
			int num9 = num8 / 3600;
			int num10 = num8 / 60 - num9 * 60;
			int num11 = num8 % 60;
			int num12 = Class73.smethod_39(gstruct42_);
			int num13 = Class73.smethod_38(gstruct42_);
			string string_ = "K:" + Class73.smethod_36(gstruct42_) + " - T:" + Class73.smethod_36(gstruct42_, bool_0: true) + " (" + num10 + ":" + num11 + ") " + num13 + "/" + num12;
			array = Class11.smethod_41(string_);
			Class20.WriteProcessMemory(gstruct42_.int_130, uint_, array, array.Length, ref int_2);
		}
		string string_2 = Class23.smethod_3(gstruct42_);
		array = Class11.smethod_41(string_2);
		Class20.WriteProcessMemory(gstruct42_.int_130, uint_, array, array.Length, ref int_2);
	}
}
