using System;
using System.Threading;

internal class Class6
{
	public static int int_0 = 0;

	public static void smethod_0(int int_1)
	{
		try
		{
			smethod_1(int_1);
		}
		catch
		{
		}
	}

	public static int smethod_1(int int_1)
	{
		GStruct42 gStruct = default(GStruct42);
		Random random = new Random();
		GStruct22 gStruct2 = default(GStruct22);
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		int int_2 = 0;
		int num4 = -1;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		uint[,] array = new uint[3, 2]
		{
			{
				42063u,
				82080u
			},
			{
				41861u,
				78454u
			},
			{
				39873u,
				80876u
			}
		};
		bool bool_ = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		bool flag9 = false;
		bool flag10 = false;
		uint[] array2 = null;
		uint[] array3 = null;
		int[,] array4 = null;
		uint[] uint_ = null;
		uint[] uint_2 = null;
		uint[] uint_3 = null;
		uint[] array5 = null;
		int num9 = -1;
		uint[] array6 = null;
		long long_ = 0L;
		int[] int_3 = null;
		long long_2 = 0L;
		long num10 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		long long_5 = 0L;
		long long_6 = 0L;
		long long_7 = 0L;
		long long_8 = 0L;
		long long_9 = 0L;
		long long_10 = 0L;
		long long_11 = 0L;
		long num11 = 0L;
		long long_12 = 0L;
		long num12 = -1L;
		uint uint_4 = 0u;
		int num13 = -1;
		int num14 = 0;
		int int_4 = 0;
		int num15 = 0;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		int num19 = 0;
		byte[] byte_ = new byte[4];
		byte[] array7 = new byte[4];
		bool flag11 = false;
		while (true)
		{
			Thread.Sleep(200);
			int num20 = Class71.smethod_3(FormMain.gstruct42_0, int_1);
			if (Class11.bool_0 || num20 < 0 || !FormMain.gstruct42_0[num20].bool_36 || FormMain.gstruct42_0[num20].int_26 <= 0)
			{
				break;
			}
			gStruct = FormMain.gstruct42_0[num20];
			if (gStruct.int_33 > 0 && gStruct.int_56 > 0 && gStruct.int_57 > 0)
			{
				FormLuomrac.smethod_0(int_1);
				continue;
			}
			if (gStruct.bool_27 || flag9)
			{
				FormMain.gstruct42_0[num20].bool_27 = false;
				FormMain.gstruct42_0[num20].bool_18 = false;
				flag9 = false;
				gStruct = FormMain.gstruct42_0[num20];
			}
			uint num26;
			int num27;
			int num29;
			int num37;
			int num38;
			bool flag12;
			bool flag13;
			int num50;
			uint num52;
			uint uint_5;
			int int_6;
			long long_13;
			uint num24;
			uint num25;
			uint[] array8;
			if (!gStruct.bool_21)
			{
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array7, 4, ref int_4);
				uint num21 = BitConverter.ToUInt32(array7, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_13.uint_0, array7, 4, ref int_4);
				uint num22 = BitConverter.ToUInt32(array7, 0);
				uint num23 = num22 * Class47.gstruct43_15.uint_0;
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array7, 4, ref int_4);
				num24 = BitConverter.ToUInt32(array7, 0);
				num25 = num24 + num23;
				Class20.ReadProcessMemory(gStruct.int_130, num25, array7, 4, ref int_4);
				num26 = BitConverter.ToUInt32(array7, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_55.uint_0, array7, 4, ref int_4);
				num27 = BitConverter.ToInt32(array7, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_50.uint_0, array7, 4, ref int_4);
				int num28 = BitConverter.ToInt32(array7, 0);
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array7, 4, ref int_4);
				num29 = BitConverter.ToInt32(array7, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_43.uint_0, array7, 4, ref int_4);
				int num30 = BitConverter.ToInt32(array7, 0);
				int num31 = Class73.smethod_40(gStruct);
				if (num28 != 0 && num27 != 0 && num29 != 0 && num27 != 10 && num27 != 21 && num31 > 1)
				{
					int num32 = (int)Class20.smethod_30(num21 + Class47.gstruct43_30.uint_0 + Class47.gstruct43_65.uint_0, gStruct.int_130);
					array8 = new uint[2]
					{
						Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
						Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
					};
					if (array8[0] == 0 || array8[1] == 0)
					{
						continue;
					}
					if (flag11)
					{
						flag11 = false;
						flag5 = false;
						Thread.Sleep(300);
						continue;
					}
					int j;
					if (num2 == num30 && num == num29)
					{
						if (Class11.smethod_23(long_7) > 30000L)
						{
							int_3 = null;
							long_7 = Class11.smethod_22();
						}
						if (num30 > 0 && Class73.smethod_12(gStruct) > 0)
						{
							if (num19 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
							}
							num19 = 0;
							num17++;
							if (num17 > 5)
							{
								num4 = -1;
							}
							continue;
						}
						num17 = 0;
						int num33 = Class69.smethod_2(gStruct);
						if (num7 != num33 || Class11.smethod_23(long_10) > 60000L)
						{
							num15 += Convert.ToByte(!gStruct.bool_12 && num7 != num33 && gStruct.int_39 > 0 && int_0 <= 0 && num30 > 0);
							num16 += Convert.ToByte(num7 < num33 && gStruct.int_62 != null && gStruct.int_62[0] > 0 && num30 > 0);
							num7 = num33;
							long_10 = Class11.smethod_22();
						}
						if (num16 > 0)
						{
							if (num16 == 1)
							{
								int[,] array9 = Class69.smethod_23(gStruct);
								int length = array9.GetLength(0);
								int num34 = 0;
								for (int i = 0; i < length; i++)
								{
									if (array9[i, 0] > 0)
									{
										int num35 = array9[i, 1] * array9[i, 2];
										if (num34 < num35)
										{
											num34 = num35;
										}
									}
								}
								int[] array10 = new int[5]
								{
									1,
									2,
									3,
									4,
									6
								};
								int num36 = array10[gStruct.int_62[1]];
								if (num36 <= num34)
								{
									num16 = 0;
								}
							}
							if (num16 > 0 && Class11.smethod_23(long_6) > 1000L)
							{
								long_6 = Class11.smethod_22();
								num16 = 0;
								if (Class29.smethod_0(num29))
								{
									flag3 = true;
									continue;
								}
								if (!Class53.smethod_13(gStruct) && gStruct.bool_63)
								{
									Class31.smethod_61(gStruct, 1, "t©m");
								}
							}
						}
						if (num15 > 0)
						{
							if (num14 <= 0)
							{
								num14 = gStruct.int_40;
								if (num14 > 1000)
								{
									num14 = random.Next(num14 - 1000, num14 + 1000);
								}
							}
							if (Class11.smethod_23(long_9) > num14)
							{
								num15 = 0;
								int_0 = int_1;
								long_9 = Class11.smethod_22();
								num14 = 0;
								new Thread(smethod_5).Start();
							}
						}
						if (gStruct.int_100[0] > 0 && gStruct.int_100[1] <= num32)
						{
							if (num30 <= 0)
							{
								j = 0;
								byte[] array11 = Class11.smethod_41("Kh«ng thÓ tiÕp tôc v× PK qu\u00b8 cao (co the thay doi trong muc Hau can).");
								for (; j < 6; j++)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_253.uint_0, array11, array11.Length, ref int_4);
									Thread.Sleep(100);
								}
								continue;
							}
							if (Class29.smethod_0(num29))
							{
								if (Class38.gstruct29_0.int_0 > 0)
								{
									Class60.smethod_48(gStruct, Class38.gstruct29_0.string_0, Class10.smethod_2("Thoát game vì PK quá cao, Thím có thể thiết lập lại trong mục Hậu cần nhé."));
									Thread.Sleep(600);
								}
								Class20.smethod_53(gStruct.process_0);
							}
							else if (!Class53.smethod_13(gStruct) && gStruct.bool_63)
							{
								Class31.smethod_61(gStruct, 162, "b¾c");
							}
						}
						num37 = 0;
						if (gStruct.uint_0 != null)
						{
							num37 = gStruct.uint_0.GetLength(0);
						}
						num38 = 302500;
						if (gStruct.int_94 > 0 && gStruct.int_95 > 0)
						{
							num38 = gStruct.int_95 * gStruct.int_95;
						}
						flag12 = (gStruct.int_116 > 0 && gStruct.int_3 != null && gStruct.int_4 != null);
						flag13 = (FormMain.int_21 > 0 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_0 != gStruct.int_129 && Class38.gstruct29_0.int_4 == num29 && Class38.gstruct29_0.int_3 == num30 && Class38.gstruct29_0.int_3 > 0 && Class11.smethod_57(Class38.gstruct29_0.uint_4) && Class38.gstruct29_0.bool_2);
						if (num30 > 0)
						{
							if (!flag2 && (flag3 || (flag3 = (gStruct.bool_18 && (gStruct.int_112 > 0 || gStruct.int_114 > 0)))))
							{
								uint[] array12 = null;
								uint[] array13 = null;
								if (!flag7 && num29 == 341)
								{
									int num39 = Class53.smethod_20(array, array8);
									if (0 <= num39)
									{
										array13 = new uint[2]
										{
											array[num39, 0],
											array[num39, 1]
										};
									}
								}
								if (!flag7 && array13 != null)
								{
									if (Class53.smethod_18(array8, array13) >= 22500L)
									{
										array12 = new uint[2]
										{
											array13[0],
											array13[1]
										};
									}
									else
									{
										flag7 = true;
									}
								}
								if (array12 == null)
								{
									array12 = Class37.smethod_9(array8, num29, "HIEUTHUOC", bool_0: false);
								}
								if (array12 != null)
								{
									if (Class38.gstruct29_0.int_0 == gStruct.int_129)
									{
										Class38.gstruct29_0.bool_2 = false;
									}
									flag6 = false;
									flag10 = (gStruct.int_31 <= 0);
									if (num19 > 0)
									{
										Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
									}
									num19 = 0;
									smethod_2(gStruct, num25, ref long_3, bool_0: true);
									long num40 = Class53.smethod_18(array8, array12);
									if (num40 >= 250000L)
									{
										if (Class11.smethod_23(long_2) > 3000L)
										{
											Class12.smethod_1(gStruct, array12);
											long_2 = Class11.smethod_22();
										}
									}
									else
									{
										Class60.smethod_61(gStruct, array12);
										Thread.Sleep(100);
									}
									Thread.Sleep(150);
									flag3 = true;
									continue;
								}
								if (Class11.smethod_23(long_6) > 1000L && !Class29.smethod_0(num29))
								{
									if (!Class53.smethod_13(gStruct) && gStruct.bool_63)
									{
										Class31.smethod_61(gStruct, 1, "t©m");
									}
									long_6 = Class11.smethod_22();
								}
							}
							if (gStruct.int_27 > 0 && !gStruct.bool_10 && Class11.smethod_23(long_11) > 60000L)
							{
								Class21.int_0 = int_1;
								new Thread(new Class21().method_1).Start();
								long_11 = Class11.smethod_22();
							}
						}
						else
						{
							if (Class38.gstruct29_0.int_0 == gStruct.int_129)
							{
								Class38.gstruct29_0.bool_2 = false;
							}
							num10 = 0L;
							flag6 = false;
							flag7 = false;
							flag3 = false;
							int_3 = null;
							flag8 = false;
							flag10 = (gStruct.int_31 <= 0);
							num16 = 0;
							num15 = 0;
							if (!flag2)
							{
								smethod_2(gStruct, num25, ref long_3, bool_0: true);
								if (gStruct.int_48 != null && gStruct.int_48[0] > 0)
								{
									smethod_4(gStruct);
								}
								if (gStruct.int_55 != null && (gStruct.int_55[0] > 0 || gStruct.int_55[1] > 0 || gStruct.int_55[2] > 0 || gStruct.int_55[3] > 0 || gStruct.int_55[4] > 0))
								{
									smethod_3(gStruct);
								}
								if (Class35.smethod_0(gStruct) == 0 || Class30.smethod_1(gStruct, FormMain.int_92 <= 0) == 0)
								{
									continue;
								}
								flag2 = true;
								long num41 = Class20.smethod_30(num25 + Class47.gstruct43_45.uint_0, gStruct.int_130);
								long num42 = Class20.smethod_30(num25 + Class47.gstruct43_47.uint_0, gStruct.int_130) + 1;
								long num43 = Class20.smethod_30(num25 + Class47.gstruct43_47.uint_0 + 4, gStruct.int_130) + 1;
								long num44 = Class20.smethod_30(num25 + Class47.gstruct43_46.uint_0, gStruct.int_130);
								long num45 = Class20.smethod_30(num25 + Class47.gstruct43_48.uint_0, gStruct.int_130) + 1;
								long num46 = Class20.smethod_30(num25 + Class47.gstruct43_48.uint_0 + 4, gStruct.int_130) + 1;
								if (num43 > num42 && num43 < 150000L)
								{
									num42 = num43;
								}
								if (num46 > num45 && num46 < 150000L)
								{
									num45 = num46;
								}
								double num47 = num41 * 100L / num42;
								double num48 = num44 * 100L / num45;
								if (num42 > 100L && num47 <= 60.0)
								{
									Class29.smethod_8(gStruct, 0);
								}
								if (num45 > 50L && num48 <= 60.0)
								{
									Class29.smethod_8(gStruct, 1);
								}
								Thread.Sleep(600);
								num7 = Class69.smethod_2(gStruct);
								if (gStruct.int_66 > 0)
								{
									Class53.smethod_1(gStruct, ref bool_);
								}
								if (gStruct.int_26 > 0 && gStruct.int_27 > 0 && gStruct.int_29 > 0)
								{
									uint num49 = Class32.smethod_42(gStruct);
									if (num49 < 2000)
									{
										Class60.smethod_35(gStruct, 2000 - num49);
									}
								}
								flag9 = true;
								continue;
							}
						}
						if (num30 <= 0 && Class53.smethod_7(num29) != null)
						{
							if (flag5)
							{
								flag5 = false;
								Class44.smethod_2(gStruct, "®iÓm cò");
								Class53.smethod_9(gStruct);
								continue;
							}
							num4 = -1;
							if (!flag4 && num29 != gStruct.int_33)
							{
								flag4 = true;
								Class44.smethod_4(gStruct, gStruct.int_33);
								Class53.smethod_9(gStruct);
								continue;
							}
						}
						if (num29 == gStruct.int_33)
						{
							if (num30 <= 0)
							{
								num4 = -1;
							}
							if (num29 == gStruct.int_33)
							{
								if (gStruct.int_90 != 0)
								{
									if (gStruct.int_90 != 1)
									{
										if (Class20.smethod_30(num25 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0)
										{
											string string_ = Class73.smethod_20(gStruct);
											if (0 < Class11.smethod_2(string_, "giê kh«ng thÓ"))
											{
												Class73.smethod_21(gStruct, "0K..");
												smethod_2(gStruct, num25, ref long_3, bool_0: false);
											}
										}
									}
									else if (flag6)
									{
										smethod_2(gStruct, num25, ref long_3, bool_0: false);
									}
								}
								else
								{
									smethod_2(gStruct, num25, ref long_3, bool_0: true);
								}
								flag8 = false;
								if (num30 <= 0)
								{
									flag = true;
									goto IL_19ec;
								}
								flag2 = false;
								flag4 = false;
								flag5 = true;
								num50 = gStruct.int_93;
								int num51 = gStruct.int_54 * gStruct.int_54;
								num52 = (uint)Class32.smethod_32(gStruct);
								if (gStruct.int_92 <= 0)
								{
									num50 = (int)Class20.smethod_30(num25 + Class47.gstruct43_31.uint_0, gStruct.int_130);
									if (num52 != 53 && num52 > 1)
									{
										if (num50 <= 100)
										{
											num50 = 400;
										}
									}
									else
									{
										num50 = 75;
									}
								}
								if (gStruct.int_38 > 0 && !gStruct.bool_15 && (!flag13 || !Class51.bool_1))
								{
									if (!flag13 && array5 != null)
									{
										uint num53 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gStruct.int_130);
										uint num54 = num53 + array5[0] * Class47.gstruct43_124.uint_0;
										int int_5 = 0;
										byte[] array14 = new byte[1];
										Class20.ReadProcessMemory(gStruct.int_130, num54 + Class47.gstruct43_135.uint_0, array14, 1, ref int_5);
										Class20.ReadProcessMemory(gStruct.int_130, num54 + Class47.gstruct43_134.uint_0, array7, 4, ref int_5);
										if (array14[0] == 0 || BitConverter.ToInt32(array7, 0) <= 0)
										{
											array5 = null;
										}
									}
									if (flag13 || array5 == null)
									{
										array5 = Class51.smethod_0(gStruct, array2, !flag13, FormMain.int_21 > 0);
									}
									if (!flag13 && array5 != null)
									{
										uint[] array15 = new uint[2]
										{
											array5[2],
											array5[3]
										};
										long num55 = Class53.smethod_18(array8, array15);
										if (num55 <= num51)
										{
											num10 = 0L;
											if (num9 == array5[0] && array6 != null && array6[0] == array5[2] && array6[1] == array5[3])
											{
												uint_5 = array5[0];
												int_6 = (int)array5[4];
												long_13 = 0L;
												long num56 = Class11.smethod_23(long_);
												if (num56 > 6000L)
												{
													goto IL_124f;
												}
												if (num56 > 1500L)
												{
													if (gStruct.int_28 <= 0 || gStruct.int_95 <= 1)
													{
														flag8 = false;
														goto IL_12cd;
													}
													string string_2 = Class73.smethod_20(gStruct);
													if (0 < Class11.smethod_2(string_2, "qu\u00b8 xa") || 0 < Class11.smethod_2(string_2, "o¶ng trèn"))
													{
														long_13 = Class11.smethod_22() - Class51.int_0 + 6000L;
														Class73.smethod_21(gStruct, "0K..");
														if (Class20.smethod_30(num25 + Class47.gstruct43_44.uint_0, gStruct.int_130) == 0)
														{
															Class60.smethod_55(gStruct, "Switch([[sit]])");
														}
														goto IL_124f;
													}
												}
											}
											else
											{
												num9 = (int)array5[0];
												array6 = new uint[2]
												{
													array5[2],
													array5[3]
												};
												long_ = Class11.smethod_22();
											}
											flag8 = true;
											if (num55 > 40000L)
											{
												Class60.smethod_61(gStruct, array15);
												Thread.Sleep(150);
											}
											Class60.smethod_46(gStruct, array5[0]);
										}
									}
								}
								goto IL_12cd;
							}
						}
						else
						{
							num4 = -1;
							if (gStruct.bool_63)
							{
								int num57 = gStruct.int_33;
								int num58 = Class31.smethod_58(num57);
								if (num58 < 0 && gStruct.int_33 == 76)
								{
									num57 = 75;
									num58 = Class31.smethod_58(75);
								}
								if (0 <= num58 && Class31.smethod_61(gStruct, num57))
								{
									Thread.Sleep(300);
									Class53.smethod_9(gStruct);
									Thread.Sleep(600);
									int num59 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
									if (num59 != num29)
									{
										continue;
									}
								}
								else if (num29 != 103 && num29 != 114 && num29 != 110 && (gStruct.int_33 == 110 || gStruct.int_33 == 114) && Class31.smethod_61(gStruct, 103))
								{
									Thread.Sleep(300);
									Class53.smethod_9(gStruct);
									Thread.Sleep(600);
									int num59 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
									if (num59 != num29)
									{
										continue;
									}
								}
							}
							gStruct2 = Class37.smethod_3(num29, gStruct.int_33);
							if (gStruct2.int_0 != num29 || gStruct2.int_1 != gStruct.int_33)
							{
								int num60 = Class53.smethod_5(num29, gStruct.int_33, ref gStruct2);
								if (num60 != 0)
								{
									if (num60 > 0)
									{
										int[] array16 = Class53.smethod_7(num29);
										if (array16 != null)
										{
											if (gStruct.bool_63 && num8 < 3)
											{
												num8++;
												if (Class31.smethod_61(gStruct, num60))
												{
													continue;
												}
											}
											Class44.smethod_5(gStruct, num60);
											num8 = 0;
										}
										else if (gStruct.bool_63)
										{
											uint[] array13 = null;
											if (Class53.smethod_5(num60, gStruct.int_33, ref gStruct2) == 0 && gStruct2.uint_0 != null)
											{
												array13 = new uint[2]
												{
													gStruct2.uint_0[0, 0],
													gStruct2.uint_0[0, 1]
												};
											}
											if (!Class31.smethod_61(gStruct, num60, null, array13))
											{
												Class31.smethod_61(gStruct, 1, "t©m");
											}
											continue;
										}
									}
									if (gStruct2.int_0 != num29 || gStruct2.int_1 != gStruct.int_33)
									{
										num30 = (int)Class20.smethod_30(num25 + Class47.gstruct43_43.uint_0, gStruct.int_130);
										if (num30 > 0)
										{
											if (gStruct.int_61 > 0 && num29 > 0 && !Class29.smethod_0(num29))
											{
												Class53.smethod_13(gStruct);
											}
										}
										else if (Class11.smethod_23(long_12) > 30000L)
										{
											string text = "Kh«ng t×m ®­îc ®­êng lªn b·i train.";
											if (gStruct.bool_63)
											{
												text += " Xem l¹i tab Cµi game cña auto ®· thiÕt lËp ®óng trang web sö dông hay ch­a ?";
											}
											Class60.smethod_50(gStruct, text);
											long_12 = Class11.smethod_22();
										}
										goto IL_23ec;
									}
								}
							}
							if (gStruct2.uint_0 != null)
							{
								if (num19 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
								}
								num19 = 0;
								smethod_2(gStruct, num25, ref long_3, bool_0: true);
								array8 = new uint[2]
								{
									Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
									Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
								};
								int int_7 = 0;
								int int_8 = 0;
								if (gStruct2.uint_0.GetLength(0) > 1)
								{
									int_7 = Class53.smethod_20(gStruct2.uint_0, array8);
								}
								Class53.smethod_6(gStruct2.uint_0, int_7, ref uint_, ref uint_2, ref int_8);
								if (Class53.smethod_18(array8, uint_) <= 90000L)
								{
									Class53.smethod_23(gStruct, uint_, int_8, uint_2, gStruct2.int_1);
								}
								else if (Class11.smethod_23(long_2) > 3000L)
								{
									Class12.smethod_1(gStruct, uint_);
									Thread.Sleep(300);
									long_2 = Class11.smethod_22();
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
						}
						goto IL_23ec;
					}
					Class12.smethod_3(gStruct, bool_0: false);
					if (num19 > 0)
					{
						Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
					}
					num19 = 0;
					j = 0;
					while (num30 == 0 && j < 3 && num30 != num2)
					{
						Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array7, 4, ref int_4);
						num21 = BitConverter.ToUInt32(array7, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_13.uint_0, array7, 4, ref int_4);
						num22 = BitConverter.ToUInt32(array7, 0);
						num23 = num22 * Class47.gstruct43_15.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array7, 4, ref int_4);
						num24 = BitConverter.ToUInt32(array7, 0);
						num25 = num24 + num23;
						Class20.ReadProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_50.uint_0, array7, 4, ref int_4);
						num28 = BitConverter.ToInt32(array7, 0);
						Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array7, 4, ref int_4);
						num29 = BitConverter.ToInt32(array7, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_43.uint_0, array7, 4, ref int_4);
						num30 = BitConverter.ToInt32(array7, 0);
						Thread.Sleep(100);
						j++;
					}
					num = num29;
					num2 = num30;
					if (num30 <= 0)
					{
						Class76.smethod_9(gStruct);
					}
					continue;
				}
				flag11 = (num27 == 10 || num27 == 21);
				continue;
			}
			Thread.Sleep(100);
			continue;
			IL_23ec:
			if (Class73.smethod_12(gStruct) <= 0 && Class20.smethod_30(num25 + Class47.gstruct43_43.uint_0, gStruct.int_130) != 0 && gStruct.bool_66 && gStruct.int_81 > 0 && FormMain.int_93 > 0 && Class38.gstruct29_0.int_7 == Class24.gstruct38_0[FormMain.int_94].int_0)
			{
				Class32.smethod_55(gStruct, null, bool_0: true);
				if (Class11.smethod_23(long_4) > gStruct.long_7)
				{
					Class32.smethod_56(gStruct);
					long_4 = Class11.smethod_22();
				}
			}
			continue;
			IL_1c38:
			if (!flag13)
			{
				if (gStruct.uint_0 == null || num37 <= 0)
				{
					array2 = array8;
					flag6 = true;
					flag10 = false;
					goto IL_23ec;
				}
				if (array2 == null || num4 < 0 || num37 <= num4 || num5 == 0)
				{
					num4 = Class53.smethod_20(gStruct.uint_0, array8);
					if (num4 < 0 || num37 == 1)
					{
						num4 = 0;
					}
					array2 = new uint[2]
					{
						gStruct.uint_0[num4, 0],
						gStruct.uint_0[num4, 1]
					};
					num5 = 1;
				}
			}
			else
			{
				array2 = Class38.gstruct29_0.uint_4;
			}
			if (Class53.smethod_18(array8, array2) <= 8100L)
			{
				num18 = 0;
				num10 = 0L;
				flag6 = true;
				flag10 = false;
				if (flag13)
				{
					goto IL_2017;
				}
				num4 += num5;
				if (gStruct.int_30 <= 0)
				{
					if (num4 >= 0)
					{
						if (num37 <= num4)
						{
							num4 = ((num37 != 1) ? (num37 - 2) : 0);
							num5 = -1;
						}
					}
					else
					{
						num4 = ((num37 != 1) ? 1 : 0);
						num5 = 1;
					}
				}
				else
				{
					if (num4 < 0 || num37 <= num4)
					{
						num4 = 0;
					}
					num5 = 1;
				}
				array2 = new uint[2]
				{
					gStruct.uint_0[num4, 0],
					gStruct.uint_0[num4, 1]
				};
			}
			if (num19 > 0)
			{
				Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
			}
			num19 = 0;
			array8 = new uint[2]
			{
				Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
				Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
			};
			long num61 = Class53.smethod_18(array8, array2);
			if (num61 > 1500000L)
			{
				goto IL_1f73;
			}
			flag6 = true;
			flag10 = false;
			Class12.smethod_3(gStruct, bool_0: false);
			if (num10 == 0L)
			{
				num10 = Class11.smethod_22();
			}
			if (num18 > 6)
			{
				num4 = -1;
				num18 = 0;
				num10 = 0L;
				flag10 = (gStruct.int_31 <= 0);
				continue;
			}
			if (Class11.smethod_23(num10) > 6000L)
			{
				num18++;
				if (num18 > 2)
				{
					if (num18 == 3)
					{
						Class53.smethod_0(gStruct, array8, array2, 800);
					}
					num6 = 0;
					goto IL_1f73;
				}
				if (Class20.smethod_30(num25 + Class47.gstruct43_44.uint_0, gStruct.int_130) == 0)
				{
					Class60.smethod_55(gStruct, "Switch([[sit]])");
					Thread.Sleep(600);
					num10 = Class11.smethod_22();
				}
				else if (Class11.smethod_23(long_3) > 800L)
				{
					Class60.smethod_55(gStruct, "Switch([[horse]])");
					long_3 = Class11.smethod_22();
				}
			}
			Class60.smethod_61(gStruct, array2);
			Thread.Sleep(100);
			goto IL_23ec;
			IL_1f73:
			flag10 = (gStruct.int_31 <= 0);
			if (array3 == null || Class53.smethod_18(array8, array3) > 90000L)
			{
				array3 = new uint[2]
				{
					array8[0],
					array8[1]
				};
				num6 = 0;
			}
			if (num6 > 5)
			{
				Class53.smethod_0(gStruct, array8, array2, 800);
				array3 = null;
			}
			if (!flag6)
			{
				smethod_2(gStruct, num25, ref long_3, bool_0: true);
			}
			if (Class11.smethod_23(long_2) > 2500L)
			{
				Class12.smethod_1(gStruct, array2);
				long_2 = Class11.smethod_22();
				num6++;
			}
			goto IL_2017;
			IL_2017:
			if (flag13 && Class38.smethod_4(num26, ref array8, ref uint_4) > 0)
			{
				Class11.smethod_22();
				if (num19 > 0)
				{
					Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
				}
				num19 = 0;
				Class38.smethod_5(gStruct, array8, uint_3);
			}
			goto IL_23ec;
			IL_124f:
			Class51.smethod_4(ref gStruct.gstruct34_0, uint_5, int_6, long_13);
			num9 = -1;
			array5 = null;
			long_ = Class11.smethod_22();
			flag8 = false;
			goto IL_12cd;
			IL_1681:
			uint num62;
			int num63 = (int)Class20.smethod_30(num62 + Class47.gstruct43_26.uint_0 + 8, gStruct.int_130);
			int num64 = (int)Class20.smethod_30(num62 + Class47.gstruct43_26.uint_0 + 12, gStruct.int_130);
			int num65 = (int)Class20.smethod_30(num62 + Class47.gstruct43_51.uint_0, gStruct.int_130);
			int num66;
			if (gStruct.int_59 > 0 && num66 <= 0 && num63 > 0 && num64 > 15 && num65 > 0)
			{
				flag = true;
				goto IL_19ec;
			}
			int num67;
			if (num63 <= 0 || num64 <= 15 || num65 <= 0)
			{
				if (num3 != num67)
				{
					num3 = num67;
					num12 = Class20.smethod_30(num62 + Class47.gstruct43_45.uint_0, gStruct.int_130);
					long_8 = Class11.smethod_22();
				}
				else
				{
					long num68 = Class20.smethod_30(num62 + Class47.gstruct43_45.uint_0, gStruct.int_130);
					if (num68 >= num12)
					{
						long num69 = Class11.smethod_23(long_8);
						if (num69 >= 7000L)
						{
							if (num19 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
							}
							num19 = 0;
							Class11.smethod_32(ref int_3, num3);
							num4 = -1;
							num5 = 0;
							num3 = -1;
							if (Class20.smethod_30(num25 + Class47.gstruct43_44.uint_0, gStruct.int_130) == 0)
							{
								Class60.smethod_55(gStruct, "Switch([[sit]])");
								Thread.Sleep(600);
							}
							long_8 = Class11.smethod_22();
							long_7 = Class11.smethod_22();
						}
					}
					else
					{
						long_8 = Class11.smethod_22();
						num12 = num68;
					}
				}
			}
			goto IL_1823;
			IL_1823:
			uint[] array17;
			long num70 = Class53.smethod_18(array2, array17);
			long num71 = Class53.smethod_18(array8, array2);
			if (num70 <= num38 && (!flag13 || num71 <= FormMain.int_23 * FormMain.int_23))
			{
				if (flag12)
				{
					int num72 = -1;
					while (!Class11.bool_0)
					{
						num13++;
						if (num13 < 0 || gStruct.int_3.Length <= num13)
						{
							num13 = 0;
						}
						if (num72 >= 0)
						{
							if (num72 == num13)
							{
								num13 = -1;
								break;
							}
						}
						else
						{
							num72 = num13;
						}
						if (gStruct.int_3[num13] > 0)
						{
							int num73 = Class11.smethod_38(gStruct.int_4, gStruct.int_3[num13], 0);
							if (num73 >= 0 && Class86.smethod_30(gStruct, num67, gStruct.int_3[num13]) != 0)
							{
								num52 = (uint)gStruct.int_3[num13];
								break;
							}
						}
					}
				}
				if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
				{
					Class32.smethod_52(gStruct, num50);
					Class67.smethod_14(gStruct, num52);
					Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num67), 4, ref int_4);
				}
				if (gStruct.bool_66 && gStruct.int_81 > 0 && FormMain.int_93 == 0 && Class11.smethod_23(long_4) > gStruct.long_7)
				{
					Class32.smethod_55(gStruct, array17, bool_0: false);
					Class32.smethod_56(gStruct);
					long_4 = Class11.smethod_22();
				}
				num10 = 0L;
				num19 = 1;
				if (flag13)
				{
					goto IL_2017;
				}
				goto IL_23ec;
			}
			flag = true;
			if (num19 > 0)
			{
				Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
			}
			num19 = 0;
			goto IL_19ec;
			IL_13b8:
			array4 = null;
			if (!gStruct.bool_33 && gStruct.int_95 > 1 && (gStruct.int_28 > 0 || FormMain.int_30 > 0))
			{
				uint uint_6 = 0u;
				uint[] uint_7 = array8;
				if (flag13)
				{
					if (FormMain.int_33 > 0 && Class38.gstruct29_0.int_4 == num29 && Class38.gstruct29_0.uint_3 != 0 && Class38.gstruct29_0.uint_3 != num26)
					{
						uint_6 = Class38.gstruct29_0.uint_3;
					}
					uint_7 = array2;
				}
				int int_9 = 600;
				if (gStruct.int_94 > 0)
				{
					int_9 = gStruct.int_95;
				}
				int num74 = gStruct.int_128;
				if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
				{
					num74 = gStruct.int_93;
				}
				if (num74 <= 0)
				{
					num74 = 500;
				}
				array4 = Class7.smethod_9(gStruct, uint_6, int_9, uint_7, int_3, bool_2: true);
				if (array4 != null && array4[0, 0] >= 0)
				{
					num66 = array4[0, 0];
					num67 = array4[0, 1];
					array17 = new uint[2]
					{
						(uint)array4[0, 4],
						(uint)array4[0, 5]
					};
					num62 = (uint)((int)num24 + num67 * (int)Class47.gstruct43_15.uint_0);
					if (num66 <= 0)
					{
						goto IL_1681;
					}
					bool flag14 = false;
					if (gStruct.int_34 == 1)
					{
						if (!Class29.smethod_0(num29))
						{
							Class53.smethod_13(gStruct);
							Thread.Sleep(150);
						}
						flag14 = true;
					}
					if (gStruct.int_34 != 0 && !flag14)
					{
						if (gStruct.int_34 != 2)
						{
							if (gStruct.int_34 != 3)
							{
								goto IL_1681;
							}
							string string_2 = Class10.smethod_2("Thoát game vì bị đồ sát.");
							if (Class38.gstruct29_0.int_0 > 0 && gStruct.int_129 != Class38.gstruct29_0.int_0)
							{
								Class60.smethod_48(gStruct, Class38.gstruct29_0.string_0, string_2);
							}
							Class60.smethod_55(gStruct, "Chat('CH_TONG', '" + string_2 + "')");
							Thread.Sleep(150);
							Class20.smethod_53(gStruct.process_0);
						}
						goto IL_1823;
					}
					if (num19 > 0)
					{
						Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
					}
					num19 = 0;
					if (num37 <= 1)
					{
						uint[] array18 = null;
						Class60.smethod_61(uint_18: (num37 != 1 || array2 == null || Class53.smethod_18(array8, array2) <= 500000L) ? Class53.smethod_3(array17, array8, 600) : array2, gstruct42_0: gStruct);
						Thread.Sleep(100);
						goto IL_23ec;
					}
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			goto IL_19ec;
			IL_19ec:
			if ((flag || array4 == null || array4[0, 0] < 0 || array4[0, 1] <= 0) && !flag8)
			{
				flag = false;
				num3 = -1;
				array8 = new uint[2]
				{
					Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
					Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
				};
				if (Class38.gstruct29_0.int_0 == gStruct.int_129)
				{
					Class38.gstruct29_0.bool_2 = (flag6 || gStruct.uint_0 == null || num37 <= 0);
				}
				if (num11 <= 0L || Class11.smethod_23(num11) >= 1000L)
				{
					uint[] array19 = null;
					long num75 = 0L;
					array19 = Class53.smethod_26(gStruct, ref int_2);
					if (array19 != null)
					{
						num11 = 0L;
						array2 = array19;
						num75 = Class53.smethod_18(array8, array19);
						if (num75 >= 8000L)
						{
							if (num19 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_4);
							}
							num19 = 0;
							if (num75 >= 15000L && num75 >= gStruct.int_68[1] * gStruct.int_68[1])
							{
								if (num75 >= 360000L)
								{
									if (num75 >= 1200000L)
									{
										goto IL_1c38;
									}
									if (Class11.smethod_23(long_2) > 3000L)
									{
										Class12.smethod_1(gStruct, array19);
										long_2 = Class11.smethod_22();
									}
								}
								else
								{
									Class12.smethod_3(gStruct, bool_0: false);
									Class60.smethod_61(gStruct, array19);
									Thread.Sleep(100);
								}
							}
							else if (num27 <= 3 && num75 > 7500L)
							{
								Class60.smethod_61(gStruct, array19);
								Thread.Sleep(100);
							}
						}
						goto IL_23ec;
					}
					num11 = Class11.smethod_22();
				}
				goto IL_1c38;
			}
			goto IL_23ec;
			IL_12cd:
			array8 = new uint[2]
			{
				Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
				Class20.smethod_30(num25 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
			};
			if (flag10)
			{
				flag = true;
			}
			else
			{
				if (gStruct.int_97[0] <= 0 || gStruct.int_97[1] <= 0 || !(gStruct.string_21 == "NGAMY"))
				{
					goto IL_13b8;
				}
				long num76 = Class11.smethod_23(long_5);
				if (num76 < 300L)
				{
					flag = true;
				}
				else
				{
					if (num76 <= gStruct.int_97[4] || !Class7.smethod_3(gStruct))
					{
						goto IL_13b8;
					}
					Thread.Sleep(80);
					long_5 = Class11.smethod_22();
					flag = true;
				}
			}
			goto IL_19ec;
		}
		return -1;
	}

	public static bool smethod_2(GStruct42 gstruct42_0, uint uint_0, ref long long_0, bool bool_0)
	{
		if (gstruct42_0.bool_64 && Class11.smethod_23(long_0) >= 800L)
		{
			bool flag;
			if (((flag = (Class20.smethod_30(uint_0 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) != 0)) && !bool_0) || (!flag && bool_0))
			{
				Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
				long_0 = Class11.smethod_22();
				return false;
			}
			return true;
		}
		return true;
	}

	public static void smethod_3(GStruct42 gstruct42_0)
	{
		int num = 0;
		int int_ = gstruct42_0.int_129;
		int num2 = 0;
		string[] array = null;
		string[] array2 = new string[6]
		{
			"ThÇn Hµnh Phï",
			"Håi thµnh phï",
			"LÖnh Bµi ADMIN",
			"Tiªn Th¶o Lé",
			"TiÒn ®ång",
			"TiÒn §ång"
		};
		bool flag = false;
		while (true)
		{
			IL_0729:
			Thread.Sleep(300);
			num = Class71.smethod_3(FormMain.gstruct42_0, int_);
			if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || FormMain.gstruct42_0[num].int_55 == null)
			{
				break;
			}
			FormMain.gstruct42_0[num].bool_11 = true;
			gstruct42_0 = FormMain.gstruct42_0[num];
			array = gstruct42_0.string_4;
			if (gstruct42_0.int_55[0] <= 0 && gstruct42_0.int_55[1] <= 0 && gstruct42_0.int_55[2] <= 0 && gstruct42_0.int_55[3] <= 0 && gstruct42_0.int_55[4] <= 0)
			{
				break;
			}
			uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
			uint num5 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num6 = num5 + num4 * Class47.gstruct43_15.uint_0;
			Class20.smethod_30(num6, gstruct42_0.int_130);
			int num7 = (int)Class20.smethod_30(num6 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			int num8 = (int)Class20.smethod_30(num6 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
			if (num8 != 0 && num7 != 0 && num7 != 10 && num7 != 21)
			{
				int num9 = (int)Class20.smethod_30(num6 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
				if (num9 > 0)
				{
					break;
				}
				int int_2 = 0;
				byte[] array3 = new byte[80];
				byte[] array4 = new byte[4];
				uint num10 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
				uint num11 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
				byte[] array5 = new byte[4];
				int int_3 = 0;
				int num12 = Class69.smethod_2(gstruct42_0);
				int num13 = 0;
				for (uint num14 = 1u; num14 < Class47.int_1; num14++)
				{
					if (0 < num12 && num12 <= num13)
					{
						break;
					}
					uint num15 = num11 + num14 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num15 + Class47.gstruct43_103.uint_0 - 4, array5, 4, ref int_3);
					if (BitConverter.ToInt32(array5, 0) != 0)
					{
						continue;
					}
					uint uint_ = num15 + Class47.gstruct43_104.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array5, 1, ref int_3);
					if (array5[0] == 0)
					{
						continue;
					}
					uint num16 = Class69.smethod_0(gstruct42_0, num14);
					if ((int)num16 <= 0)
					{
						continue;
					}
					num13++;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num15 + Class47.gstruct43_105.uint_0, array4, 4, ref int_2);
					int num17 = BitConverter.ToInt32(array4, 0);
					if (num17 == 1 || num17 == 5)
					{
						continue;
					}
					uint num18 = num10 + num16 * 20;
					uint num19 = Class20.smethod_30(num18 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
					if (num19 != 3)
					{
						continue;
					}
					Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array3, array3.Length, ref int_2);
					string text = Class10.smethod_3(array3).Trim();
					if (text == null || text == string.Empty)
					{
						continue;
					}
					bool flag2 = false;
					if (array != null)
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (Class11.smethod_3(text, array[i].Trim()))
							{
								flag2 = true;
								break;
							}
						}
					}
					if (flag2)
					{
						continue;
					}
					if (array2 != null)
					{
						for (int i = 0; i < array2.Length; i++)
						{
							if (Class11.smethod_3(text, array2[i].Trim()))
							{
								flag2 = true;
								break;
							}
						}
					}
					if (flag2)
					{
						continue;
					}
					Class20.ReadProcessMemory(gstruct42_0.int_130, num15 + Class47.gstruct43_116.uint_0, array4, 4, ref int_2);
					int num20 = BitConverter.ToInt32(array4, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num15 + Class47.gstruct43_116.uint_0 + 4, array4, 4, ref int_2);
					int num21 = BitConverter.ToInt32(array4, 0);
					if (num17 == 6 && num20 < num21)
					{
						continue;
					}
					uint uint_2 = Class20.smethod_30(num18 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
					uint uint_3 = Class20.smethod_30(num18 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
					uint num22 = Class20.smethod_30(num15 + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
					uint num23 = Class20.smethod_30(num15 + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
					uint uint_4 = 4u;
					uint[] array6 = null;
					if (gstruct42_0.int_55[0] > 0)
					{
						uint_4 = 4u;
						array6 = Class69.smethod_22(gstruct42_0, 4u, num22, num23);
					}
					if (array6 == null && gstruct42_0.int_55[1] > 0)
					{
						uint_4 = 9u;
						array6 = Class69.smethod_22(gstruct42_0, 9u, num22, num23);
					}
					if (array6 == null && gstruct42_0.int_55[2] > 0)
					{
						uint_4 = 10u;
						array6 = Class69.smethod_22(gstruct42_0, 10u, num22, num23);
					}
					if (array6 == null && gstruct42_0.int_55[3] > 0)
					{
						uint_4 = 11u;
						array6 = Class69.smethod_22(gstruct42_0, 11u, num22, num23);
					}
					if (array6 == null && gstruct42_0.int_55[4] > 0)
					{
						uint_4 = 23u;
						array6 = Class69.smethod_22(gstruct42_0, 23u, num22, num23);
					}
					if (array6 == null)
					{
						if (num22 <= 1 && num23 <= 1)
						{
							break;
						}
						continue;
					}
					if (num2 <= 0)
					{
						num2 = Class81.smethod_0(gstruct42_0);
						if (num2 < 0)
						{
							Class53.smethod_10(gstruct42_0);
						}
					}
					if (!Class39.smethod_9(gstruct42_0))
					{
						goto IL_0729;
					}
					if (!flag && gstruct42_0.string_13 != null && gstruct42_0.string_13 != string.Empty)
					{
						uint num24 = Class11.smethod_13(gstruct42_0.string_13);
						if (num24 != 0)
						{
							Class60.smethod_113(gstruct42_0, num24);
							flag = true;
							Thread.Sleep(300);
						}
					}
					int j = 0;
					Class60.smethod_44(gstruct42_0, uint_2, uint_3, num19, array6[0], array6[1], uint_4);
					for (; j < 30; j++)
					{
						uint num25 = Class20.smethod_30(num18 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
						if (num25 != num19)
						{
							break;
						}
						Thread.Sleep(10);
					}
				}
				break;
			}
			int num26 = 0;
			while (num8 == 0 && num26 < 10)
			{
				num8 = (int)Class20.smethod_30(num6 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
				if (num8 != 0)
				{
					break;
				}
				Thread.Sleep(80);
				num26++;
			}
			num7 = (int)Class20.smethod_30(num6 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
		}
		num = Class71.smethod_3(FormMain.gstruct42_0, int_);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].bool_29 = false;
			FormMain.gstruct42_0[num].bool_11 = false;
		}
		if (Class39.smethod_9(gstruct42_0))
		{
			Class39.smethod_12(gstruct42_0);
		}
	}

	public static void smethod_4(GStruct42 gstruct42_0)
	{
		int int_ = gstruct42_0.int_129;
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
		if (num >= 0)
		{
			FormMain.gstruct42_0[num].bool_14 = true;
			gstruct42_0 = FormMain.gstruct42_0[num];
			string[] string_ = gstruct42_0.string_3;
			int int_2 = 0;
			byte[] array = new byte[80];
			byte[] array2 = new byte[4];
			uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
			uint num3 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			uint num4 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num5 = Class20.smethod_30(num4 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
			uint num6 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num7 = num6 + num5 * Class47.gstruct43_15.uint_0;
			for (uint num8 = 1u; num8 < 210; num8++)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_43.uint_0, array2, 4, ref int_2);
				if (BitConverter.ToInt32(array2, 0) > 0)
				{
					break;
				}
				if (num8 != 0 && num8 % 10u == 0)
				{
					Thread.Sleep(15);
				}
				if (!Class69.smethod_1(gstruct42_0, num8))
				{
					continue;
				}
				uint num9 = num3 + num8 * Class47.gstruct43_103.uint_0;
				uint uint_ = num9 + Class47.gstruct43_104.uint_0;
				if (!Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_2) || array[0] == 0)
				{
					continue;
				}
				uint num10 = Class69.smethod_0(gstruct42_0, num8);
				uint num11 = Class20.smethod_30(num2 + num10 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
				if ((int)num10 <= 0 || num11 != 3)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_105.uint_0, array2, 4, ref int_2);
				int num12 = BitConverter.ToInt32(array2, 0);
				if (num12 > 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_106.uint_0, array2, 4, ref int_2);
				int num13 = BitConverter.ToInt32(array2, 0);
				if (num13 == 1 || num13 == 4)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_117.uint_0, array2, 4, ref int_2);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_116.uint_0, array2, 4, ref int_2);
				int num14 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_116.uint_0 + 4, array2, 4, ref int_2);
				int num15 = BitConverter.ToInt32(array2, 0);
				if (num14 == 0 && num15 > 0)
				{
					continue;
				}
				if (gstruct42_0.int_48[1] <= 0)
				{
					string text = null;
					if (string_ != null)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_2);
						text = Class10.smethod_3(array).Trim();
						if (text == null || text == string.Empty)
						{
							continue;
						}
						int num16 = 0;
						while (num16 < string_.Length)
						{
							if (0 > Class11.smethod_2(text, string_[num16]))
							{
								num16++;
								continue;
							}
							goto IL_0777;
						}
					}
					Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_107.uint_0, array2, 4, ref int_2);
					int num17 = BitConverter.ToInt32(array2, 0);
					if (num17 > 9)
					{
						continue;
					}
					if (gstruct42_0.int_45[0] > 0 && num17 == 3)
					{
						if (gstruct42_0.int_45[1] <= 0)
						{
							continue;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, (uint)((int)(num9 + Class47.gstruct43_115.uint_0) + (gstruct42_0.int_45[1] - 1) * 16), array2, 4, ref int_2);
						if (BitConverter.ToInt32(array2, 0) != 0)
						{
							continue;
						}
					}
					else if (gstruct42_0.int_46[0] > 0 && num17 == 4)
					{
						if (gstruct42_0.int_46[1] <= 0)
						{
							continue;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, (uint)((int)(num9 + Class47.gstruct43_115.uint_0) + (gstruct42_0.int_46[1] - 1) * 16), array2, 4, ref int_2);
						if (BitConverter.ToInt32(array2, 0) != 0)
						{
							continue;
						}
					}
					else if (gstruct42_0.int_47[0] > 0 && num17 == 9)
					{
						if (gstruct42_0.int_47[1] <= 0)
						{
							continue;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, (uint)((int)(num9 + Class47.gstruct43_115.uint_0) + (gstruct42_0.int_47[1] - 1) * 16), array2, 4, ref int_2);
						if (BitConverter.ToInt32(array2, 0) != 0)
						{
							continue;
						}
					}
					if (gstruct42_0.int_51 > 0 && num13 == 2)
					{
						continue;
					}
					if (gstruct42_0.int_49[0] > 0)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_111.uint_0, array2, 4, ref int_2);
						if (gstruct42_0.int_49[1] <= BitConverter.ToInt32(array2, 0))
						{
							continue;
						}
					}
					if (gstruct42_0.int_50[0] > 0)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_112.uint_0, array2, 4, ref int_2);
						if (gstruct42_0.int_50[1] == BitConverter.ToInt32(array2, 0))
						{
							continue;
						}
					}
					if (gstruct42_0.int_52 > 0)
					{
						int num18 = 0;
						int num19 = 0;
						bool flag = false;
						for (int i = 0; i < gstruct42_0.gstruct33_0.Length; i++)
						{
							if (gstruct42_0.gstruct33_0[i].int_0 <= 0)
							{
								continue;
							}
							num19++;
							flag = false;
							for (uint num20 = 0u; num20 < 6; num20++)
							{
								Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_115.uint_0 + num20 * 16, array2, 4, ref int_2);
								int num21 = BitConverter.ToInt32(array2, 0);
								if (gstruct42_0.gstruct33_0[i].int_1 == num21)
								{
									Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_115.uint_0 + num20 * 16 + 4, array2, 4, ref int_2);
									int num22 = BitConverter.ToInt32(array2, 0);
									Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + Class47.gstruct43_115.uint_0 + num20 * 16 + 12, array2, 4, ref int_2);
									int num23 = BitConverter.ToInt32(array2, 0);
									bool flag2 = gstruct42_0.gstruct33_0[i].int_2 <= num22 && num22 > 0;
									bool flag3 = gstruct42_0.gstruct33_0[i].int_2 <= num23 && num23 > 0;
									bool flag4 = gstruct42_0.gstruct33_0[i].int_2 <= 0;
									if (flag2 || flag3 || flag4)
									{
										num18++;
										flag = true;
										break;
									}
								}
							}
							if (flag || gstruct42_0.int_43 <= 0)
							{
								continue;
							}
							goto IL_0777;
						}
						if (flag = (num19 == 0 || (gstruct42_0.int_43 > 0 && num19 <= num18) || (gstruct42_0.int_43 <= 0 && num18 > 0)))
						{
							continue;
						}
					}
				}
				goto IL_0777;
				IL_0777:
				int num24 = 0;
				while (!Class11.bool_0 && num24 < 150)
				{
					if (num24 % 30 == 0)
					{
						Class60.smethod_33(gstruct42_0, (int)num8);
					}
					Thread.Sleep(10);
					if (num24 % 10 == 0)
					{
						string string_2 = Class73.smethod_22(gstruct42_0);
						if (Class11.smethod_2(string_2, "hÊt b¹i") > 0)
						{
							Class73.smethod_23(gstruct42_0, "0K..");
							break;
						}
					}
					if (Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_2) && array[0] != 0)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_43.uint_0, array2, 4, ref int_2);
						if (BitConverter.ToInt32(array2, 0) <= 0)
						{
							num24++;
							continue;
						}
						num24 = 0;
						break;
					}
					num24 = 0;
					break;
				}
			}
		}
		num = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].bool_14 = false;
		}
	}

	public static void smethod_5()
	{
		int num = int_0;
		int_0 = 0;
		int num2 = 0;
		int num3 = 0;
		while (true)
		{
			IL_03da:
			Thread.Sleep(300);
			num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
			if (Class11.bool_0 || num2 < 0 || !FormMain.gstruct42_0[num2].bool_36 || FormMain.gstruct42_0[num2].int_39 <= 0)
			{
				break;
			}
			FormMain.gstruct42_0[num2].bool_12 = true;
			GStruct42 gstruct42_ = FormMain.gstruct42_0[num2];
			if (gstruct42_.bool_14 || gstruct42_.bool_11)
			{
				continue;
			}
			uint num4 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
			uint num5 = Class20.smethod_30(num4 + Class47.gstruct43_13.uint_0, gstruct42_.int_130);
			uint num6 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
			uint num7 = num6 + num5 * Class47.gstruct43_15.uint_0;
			Class20.smethod_30(num7, gstruct42_.int_130);
			if (Class20.smethod_30(num7 + Class47.gstruct43_50.uint_0, gstruct42_.int_130) == 0)
			{
				num3++;
				if (num3 > 3)
				{
					break;
				}
				continue;
			}
			if (Class39.smethod_22(gstruct42_) < 0)
			{
				break;
			}
			int int_ = 0;
			byte[] array = new byte[80];
			byte[] array2 = new byte[4];
			uint num8 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130) + Class47.gstruct43_94.uint_0;
			uint num9 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_.int_130);
			int num10 = Class69.smethod_2(gstruct42_);
			int num11 = 0;
			uint num12 = 1u;
			while (num12 < Class47.int_1)
			{
				if (!gstruct42_.bool_14 && !gstruct42_.bool_11)
				{
					if (num12 != 0 && num12 % 50u == 0)
					{
						Thread.Sleep(10);
					}
					if (0 < num10 && num10 <= num11)
					{
						break;
					}
					uint num13 = num9 + num12 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_.int_130, num13 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_);
					if (BitConverter.ToInt32(array2, 0) == 0)
					{
						uint uint_ = num13 + Class47.gstruct43_104.uint_0;
						Class20.ReadProcessMemory(gstruct42_.int_130, uint_, array2, 1, ref int_);
						if (array2[0] != 0)
						{
							uint num14 = Class69.smethod_0(gstruct42_, num12);
							if ((int)num14 > 0)
							{
								num11++;
								uint num15 = num8 + num14 * 20;
								uint num16 = Class20.smethod_30(num15 + Class47.gstruct43_97.uint_0 - 8, gstruct42_.int_130);
								if (num16 == 3)
								{
									uint num17 = Class20.smethod_30(num15 + Class47.gstruct43_97.uint_0 - 4, gstruct42_.int_130);
									uint num18 = Class20.smethod_30(num15 + Class47.gstruct43_97.uint_0, gstruct42_.int_130);
									uint uint_2 = Class20.smethod_30(num13 + Class47.gstruct43_108.uint_0, gstruct42_.int_130);
									uint uint_3 = Class20.smethod_30(num13 + Class47.gstruct43_109.uint_0, gstruct42_.int_130);
									Class20.ReadProcessMemory(gstruct42_.int_130, uint_, array, array.Length, ref int_);
									Class10.smethod_3(array).Trim();
									uint uint_4 = 3u;
									uint[] array3 = Class69.smethod_22(gstruct42_, 3u, uint_2, uint_3);
									if (array3 != null && array3[1] <= num18 && (array3[1] != num18 || num17 >= array3[0]))
									{
										Class60.smethod_44(gstruct42_, num17, num18, num16, array3[0], array3[1], uint_4);
										for (int i = 0; i < 30; i++)
										{
											uint num19 = Class20.smethod_30(num15 + Class47.gstruct43_97.uint_0 - 8, gstruct42_.int_130);
											if (num16 != num19)
											{
												break;
											}
											Thread.Sleep(10);
										}
									}
								}
							}
						}
					}
					num12++;
					continue;
				}
				goto IL_03da;
			}
			break;
		}
		num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
		if (0 <= num2)
		{
			FormMain.gstruct42_0[num2].bool_12 = false;
			Class39.smethod_22(FormMain.gstruct42_0[num2]);
		}
	}
}
