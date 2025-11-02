using System;
using System.Threading;

// Token: 0x020000C3 RID: 195
internal class Class70
{
	// Token: 0x06000972 RID: 2418 RVA: 0x00155B28 File Offset: 0x00153D28
	public static void smethod_0(int int_0)
	{
		GStruct42 gStruct = default(GStruct42);
		new Random();
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		int num4 = -1;
		int num5 = -1;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		int num6 = 0;
		int num7 = 0;
		bool flag5 = false;
		bool flag6 = false;
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		uint num8 = 0u;
		uint[] array = null;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		long num14 = 0L;
		long num15 = 0L;
		long long_5 = 0L;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		bool flag7 = false;
		bool flag8 = false;
		int num19 = 0;
		int num20 = 0;
		int num21 = 0;
		int num22 = -1;
		int[] array2 = new int[4];
		int num23 = 0;
		byte[] byte_ = new byte[4];
		byte[] array3 = new byte[4];
		string text = null;
		uint[,] array4 = new uint[,]
		{
			{
				11u,
				101952u,
				165824u
			},
			{
				78u,
				50624u,
				108160u
			},
			{
				1u,
				52544u,
				104640u
			},
			{
				162u,
				53760u,
				104832u
			},
			{
				37u,
				54144u,
				102784u
			},
			{
				80u,
				54144u,
				102976u
			},
			{
				176u,
				54048u,
				105248u
			}
		};
		int num24 = 0;
		bool flag9 = false;
		bool flag10 = false;
		while (true)
		{
			IL_3ED5:
			Thread.Sleep(200);
			int num25 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (Class11.bool_0 || num25 < 0 || FormMain.int_20 != 2)
			{
				break;
			}
			gStruct = FormMain.gstruct42_0[num25];
			if (!gStruct.bool_36 || gStruct.bool_60 || gStruct.int_26 > 0 || gStruct.int_126[0] > 0 || gStruct.int_21[0] > 0)
			{
				break;
			}
			if (!gStruct.bool_21 && !gStruct.bool_6)
			{
				if (gStruct.bool_27)
				{
					FormMain.gstruct42_0[num25].bool_27 = false;
					flag = false;
					gStruct = FormMain.gstruct42_0[num25];
				}
				if (FormMain.int_24 != 1)
				{
					if (FormMain.int_24 != 2)
					{
						Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array3, 4, ref num23);
						uint num26 = BitConverter.ToUInt32(array3, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num26 + Class47.gstruct43_13.uint_0, array3, 4, ref num23);
						uint num27 = BitConverter.ToUInt32(array3, 0);
						uint num28 = num27 * Class47.gstruct43_15.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array3, 4, ref num23);
						uint num29 = BitConverter.ToUInt32(array3, 0);
						uint num30 = num29 + num28;
						Class20.ReadProcessMemory(gStruct.int_130, num30, array3, 4, ref num23);
						uint num31 = BitConverter.ToUInt32(array3, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_55.uint_0, array3, 4, ref num23);
						int num32 = BitConverter.ToInt32(array3, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_50.uint_0, array3, 4, ref num23);
						int num33 = BitConverter.ToInt32(array3, 0);
						Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array3, 4, ref num23);
						int num34 = BitConverter.ToInt32(array3, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_43.uint_0, array3, 4, ref num23);
						int num35 = BitConverter.ToInt32(array3, 0);
						int num36 = Class73.smethod_12(gStruct);
						if (gStruct.int_129 != Class66.gstruct42_0.int_129)
						{
							if (gStruct.int_129 != Class38.gstruct29_0.int_0)
							{
								goto IL_3D1;
							}
						}
						if (num36 > 0)
						{
							if (num36 == 2)
							{
								Thread.Sleep(180);
								continue;
							}
							if (num36 == 1)
							{
								if (num19 > 0 || (num21 > 1 && num35 > 0))
								{
									Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
								}
								if (num21 > 3)
								{
									num20 = 0;
								}
								num21++;
								num19 = 0;
								continue;
							}
						}
						IL_3D1:
						if (num20 <= 0)
						{
							array2[0] = 0;
							array2[1] = 0;
							array2[2] = 0;
							array2[3] = 0;
						}
						num20 = 0;
						num21 = 0;
						int num37 = Class73.smethod_40(gStruct);
						if (num33 != 0 && num32 != 0 && num34 != 0 && num37 > 1 && num32 != 10 && num32 != 21)
						{
							if (!gStruct.bool_29 && !flag9)
							{
								uint[] array5 = new uint[]
								{
									Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
									Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
								};
								if (array5[0] > 0u && array5[1] > 0u)
								{
									if (flag10)
									{
										flag10 = false;
										Thread.Sleep(300);
									}
									else if (num == num34 && (num2 == Class38.gstruct29_0.int_4 || FormMain.int_21 <= 0))
									{
										if (num4 != FormMain.int_100)
										{
											flag5 = false;
											num7 = 0;
											num4 = FormMain.int_100;
										}
										bool flag11 = Class20.smethod_30(num30 + Class47.gstruct43_44.uint_0, gStruct.int_130) > 0u;
										int num38 = 600;
										if (gStruct.int_94 > 0)
										{
											num38 = gStruct.int_95;
										}
										int num39 = gStruct.int_128;
										if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
										{
											num39 = gStruct.int_93;
										}
										if (num39 <= 0)
										{
											num39 = 500;
										}
										int num40 = FormMain.int_23;
										if (gStruct.int_129 != Class38.gstruct29_0.int_0)
										{
											if (num39 <= 180 && num40 < FormMain.int_51)
											{
												num40 = FormMain.int_51;
											}
											if (gStruct.int_123[0] > 0 && FormMain.int_27 > 0 && num40 > 180)
											{
												num40 = 180;
											}
										}
										uint[] uint_ = array5;
										bool bool_ = false;
										int num41 = 0;
										bool flag12 = false;
										bool flag13 = false;
										if ((FormMain.int_45 > 0 && Class38.gstruct29_0.int_0 != gStruct.int_129 && Class38.gstruct29_0.int_0 > 0 && 926 <= Class38.gstruct29_0.int_4 && Class38.gstruct29_0.int_4 <= 932 && num24 != Class38.gstruct29_0.int_4) || num4 != FormMain.int_100)
										{
											flag5 = false;
											num7 = 0;
											num4 = FormMain.int_100;
											num16 = 0;
											num24 = Class38.gstruct29_0.int_4;
										}
										if (num3 != num35)
										{
											Thread.Sleep(100);
											array = null;
											num9 = 0;
											int i = 0;
											while (num35 == 0 && i < 30 && num35 != num3)
											{
												Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array3, 4, ref num23);
												num26 = BitConverter.ToUInt32(array3, 0);
												Class20.ReadProcessMemory(gStruct.int_130, num26 + Class47.gstruct43_13.uint_0, array3, 4, ref num23);
												num27 = BitConverter.ToUInt32(array3, 0);
												num28 = num27 * Class47.gstruct43_15.uint_0;
												Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array3, 4, ref num23);
												num29 = BitConverter.ToUInt32(array3, 0);
												num30 = num29 + num28;
												Class20.ReadProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_43.uint_0, array3, 4, ref num23);
												num35 = BitConverter.ToInt32(array3, 0);
												Thread.Sleep(10);
												i++;
											}
											num3 = num35;
											if (num35 <= 0)
											{
												Thread.Sleep(150);
												Class76.smethod_9(gStruct, false);
												continue;
											}
										}
										if (!Class89.smethod_0(num34))
										{
											if (num35 > 0)
											{
												flag = false;
												flag7 = true;
												if (num34 == 221 && Class17.smethod_0(gStruct) > 0)
												{
													continue;
												}
												int int_ = Class89.struct31_0[FormMain.int_100].int_0;
												if (gStruct.bool_63 && Class31.smethod_61(gStruct, int_, null, null, false))
												{
													Thread.Sleep(300);
													Class53.smethod_9(gStruct, 15000);
													if (Class20.smethod_30(num30 + Class47.gstruct43_43.uint_0, gStruct.int_130) == 0u)
													{
														continue;
													}
												}
												if (Class53.smethod_13(gStruct, true))
												{
													Thread.Sleep(300);
													Class53.smethod_9(gStruct, 15000);
													if (Class20.smethod_30(num30 + Class47.gstruct43_43.uint_0, gStruct.int_130) == 0u)
													{
														continue;
													}
												}
												uint[] array6 = Class37.smethod_9(array5, num34, "Xa phu", true);
												if (array6 != null)
												{
													if (Class11.smethod_23(long_) > 4000L)
													{
														Class12.smethod_1(gStruct, array6);
														long_ = Class11.smethod_22();
														continue;
													}
													continue;
												}
											}
											if (FormMain.int_106 > 0 && gStruct.int_129 == Class38.gstruct29_0.int_0 && ((FormMain.int_6 <= 0 && FormMain.int_7 <= 0) || Class38.gstruct29_1.int_4 <= 0))
											{
												Class53.smethod_8(gStruct, "CTC Ac chÝnh ng­êi dïng tù ®iÒu khiÓn..");
												Thread.Sleep(300);
											}
											else if (Class50.smethod_1(num34) != null)
											{
												Class44.smethod_5(gStruct, 11);
												flag6 = true;
											}
											else if (!flag6)
											{
												int num42 = Class69.smethod_2(gStruct);
												if (flag && num5 >= 0 && num5 == num42)
												{
													if (flag7)
													{
														long num43 = (long)((ulong)Class20.smethod_30(num30 + Class47.gstruct43_45.uint_0, gStruct.int_130));
														long num44 = (long)((ulong)(Class20.smethod_30(num30 + Class47.gstruct43_47.uint_0, gStruct.int_130) + 1u));
														long num45 = (long)((ulong)(Class20.smethod_30(num30 + Class47.gstruct43_47.uint_0 + 4u, gStruct.int_130) + 1u));
														long num46 = (long)((ulong)Class20.smethod_30(num30 + Class47.gstruct43_46.uint_0, gStruct.int_130));
														long num47 = (long)((ulong)(Class20.smethod_30(num30 + Class47.gstruct43_48.uint_0, gStruct.int_130) + 1u));
														long num48 = (long)((ulong)(Class20.smethod_30(num30 + Class47.gstruct43_48.uint_0 + 4u, gStruct.int_130) + 1u));
														if (num45 > num44 && num45 < 150000L)
														{
															num44 = num45;
														}
														if (num48 > num47 && num48 < 150000L)
														{
															num47 = num48;
														}
														double num49 = (double)(num43 * 100L / num44);
														double num50 = (double)(num46 * 100L / num47);
														if (((num44 > 100L && gStruct.int_103[0] > 0 && gStruct.int_103[1] > 0 && num43 <= (long)gStruct.int_103[1]) || (gStruct.int_106[0] > 0 && gStruct.int_106[1] > 0 && num49 <= (double)gStruct.int_106[1])) && Class29.smethod_8(gStruct, 0, 1, false))
														{
															Thread.Sleep(600);
														}
														if (((num47 > 50L && gStruct.int_104[0] > 0 && gStruct.int_104[1] > 0 && num46 <= (long)gStruct.int_104[1]) || (gStruct.int_108[0] > 0 && gStruct.int_108[1] > 0 && num50 <= (double)gStruct.int_108[1])) && Class29.smethod_8(gStruct, 1, 1, false))
														{
															Thread.Sleep(300);
														}
														Thread.Sleep(150);
														num5 = Class69.smethod_2(gStruct);
														flag7 = false;
													}
													int int_2 = Class89.struct31_0[FormMain.int_100].int_0;
													uint[] array7 = Class89.struct31_0[FormMain.int_100].uint_0;
													string text2 = Class89.struct31_0[FormMain.int_100].string_0;
													string string_ = Class89.struct31_0[FormMain.int_100].string_1;
													string string_2 = Class89.struct31_0[FormMain.int_102].string_1;
													if (FormMain.int_45 > 0 && Class38.gstruct29_0.int_0 != gStruct.int_129 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_6 > 0 && 926 <= Class38.gstruct29_0.int_4 && Class38.gstruct29_0.int_4 <= 932)
													{
														for (int j = 0; j < Class89.struct31_0.Length; j++)
														{
															if (Class38.gstruct29_0.int_4 == Class89.struct31_0[j].int_1)
															{
																text2 = Class89.struct31_0[j].string_0;
																string_ = Class89.struct31_0[j].string_1;
																int_2 = Class89.struct31_0[j].int_0;
																array7 = Class89.struct31_0[j].uint_0;
																break;
															}
														}
													}
													if (text != null && text != string.Empty)
													{
														text2 = text;
													}
													if (FormMain.int_99 > 0 && gStruct.bool_63)
													{
														Class76.smethod_9(gStruct, false);
														if (Class53.smethod_17(gStruct, "ThÇn Hµnh", false))
														{
															Thread.Sleep(300);
															string[] array8 = new string[]
															{
																"ThÊt Thµnh",
																"ThÊt-Thµnh",
																"¹i ChiÕn",
																"tr­êng ThÊt",
																"hiÕn tr­êng",
																"o b¶n ®å C«ng T",
																"Ok Ta"
															};
															string text3 = string.Empty;
															int num51 = 0;
															int num52;
															int num53;
															while (true)
															{
																num51++;
																Thread.Sleep(100);
																if (Class20.smethod_30(gStruct.uint_6 + Class47.gstruct43_168.uint_0, gStruct.int_130) > 0u)
																{
																	Class39.smethod_3(gStruct, null);
																}
																num52 = Class76.smethod_1(gStruct);
																if (0 <= num52)
																{
																	num53 = Class76.smethod_2(gStruct, num52);
																	for (int j = 0; j < num53; j++)
																	{
																		text3 += Class76.smethod_3(gStruct, j, num52);
																	}
																	if (text3 != string.Empty)
																	{
																		break;
																	}
																}
																if (num51 > 10)
																{
																	goto Block_106;
																}
															}
															if (num53 > 0)
															{
																for (int k = 0; k < num53; k++)
																{
																	string string_3 = Class76.smethod_3(gStruct, k, num52).ToLower();
																	for (int l = 0; l < array8.Length; l++)
																	{
																		if (array8[l] != "hiÕn tr­êng" && 0 <= Class11.smethod_2(string_3, array8[l].ToLower()))
																		{
																			goto IL_FBA;
																		}
																	}
																}
																goto IL_EC9;
															}
															goto IL_EC9;
															IL_FBA:
															string text4 = string_;
															int num54 = 0;
															num6++;
															if (num6 > 3)
															{
																if (FormMain.int_101 > 0)
																{
																	text4 = string_2;
																}
																if (num6 > 6)
																{
																	num6 = 0;
																}
															}
															text4 = text4.ToLower();
															while (true)
															{
																IL_11AE:
																if (Class20.smethod_30(gStruct.uint_6 + Class47.gstruct43_168.uint_0, gStruct.int_130) > 0u)
																{
																	Class39.smethod_3(gStruct, null);
																	Thread.Sleep(450);
																}
																string b = null;
																int num55 = Class76.smethod_1(gStruct);
																int num56 = Class76.smethod_2(gStruct, num55);
																int num57 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
																for (int m = 0; m < array8.Length; m++)
																{
																	string object_ = array8[m].ToLower();
																	int j = 0;
																	while (j < num56)
																	{
																		string text5 = Class76.smethod_3(gStruct, j, num55);
																		if (j == 0)
																		{
																			b = text5;
																		}
																		string string_3 = text5.ToLower();
																		if (Class11.smethod_2(string_3, object_) < 0)
																		{
																			j++;
																		}
																		else
																		{
																			Class76.smethod_6(gStruct, j);
																			for (int n = 0; n < 8; n++)
																			{
																				Thread.Sleep(100);
																				if (Class20.smethod_30(gStruct.uint_6 + Class47.gstruct43_168.uint_0, gStruct.int_130) > 0u)
																				{
																					Class39.smethod_3(gStruct, null);
																					Thread.Sleep(450);
																				}
																				int num58 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
																				if (num57 != num58)
																				{
																					goto IL_11FE;
																				}
																				int num59 = Class76.smethod_1(gStruct);
																				if (0 <= num59)
																				{
																					int num60 = Class76.smethod_2(gStruct, num59);
																					if (num55 != num59 || num60 != num56)
																					{
																						break;
																					}
																					string a = Class76.smethod_3(gStruct, 0, num59);
																					if (a != b)
																					{
																						break;
																					}
																				}
																			}
																			Thread.Sleep(300);
																			if (num54 != 0)
																			{
																				break;
																			}
																			array8 = new string[]
																			{
																				text4
																			};
																			Thread.Sleep(150);
																			num54 = 1;
																			goto IL_11AE;
																		}
																	}
																}
																break;
															}
															if (Class76.Class79.smethod_4(gStruct))
															{
																Class20.smethod_4(gStruct.uint_4, 32u);
															}
															Class76.smethod_9(gStruct, false);
															continue;
															IL_11FE:
															if (Class76.Class79.smethod_4(gStruct))
															{
																Class20.smethod_4(gStruct.uint_4, 32u);
																continue;
															}
															continue;
															IL_EC9:
															num51 = 0;
															if (FormMain.int_103 > 0)
															{
																Class76.smethod_6(gStruct, FormMain.int_103 - 1);
															}
															while (true)
															{
																num51++;
																Thread.Sleep(100);
																num52 = Class76.smethod_1(gStruct);
																if (0 <= num52)
																{
																	string text6 = string.Empty;
																	num53 = Class76.smethod_2(gStruct, num52);
																	for (int j = 0; j < num53; j++)
																	{
																		text6 += Class76.smethod_3(gStruct, j, num52);
																	}
																	if (text3 != text6 && text6 != string.Empty)
																	{
																		break;
																	}
																}
																if (Class20.smethod_30(gStruct.uint_6 + Class47.gstruct43_168.uint_0, gStruct.int_130) > 0u)
																{
																	Class39.smethod_3(gStruct, null);
																}
																if (num51 > 10)
																{
																	goto IL_122C;
																}
															}
															Thread.Sleep(300);
															if (num53 != 1)
															{
																goto IL_FBA;
															}
															Class76.smethod_6(gStruct, 0);
															continue;
															Block_106:;
														}
													}
													IL_122C:
													if (FormMain.int_101 <= 0 || num16 < FormMain.int_39 || (FormMain.int_40 <= 0 && num16 >= FormMain.int_39 * 2))
													{
														if (num16 >= FormMain.int_39 * 2)
														{
															num16 = 0;
														}
													}
													else
													{
														array7 = Class89.struct31_0[FormMain.int_102].uint_0;
														text2 = Class89.struct31_0[FormMain.int_102].string_0;
														string_ = Class89.struct31_0[FormMain.int_102].string_1;
														int_2 = Class89.struct31_0[FormMain.int_102].int_0;
														flag5 = true;
														if (text != null && text != string.Empty)
														{
															text2 = text;
														}
													}
													int[] array9 = Class53.smethod_7(num34);
													if (array9 == null || num35 > 0)
													{
														if (!flag2 && gStruct.bool_63)
														{
															flag2 = true;
															if (!Class31.smethod_61(gStruct, int_2, null, array7, false))
															{
																goto IL_195E;
															}
														}
														else
														{
															if (flag3 || Class29.smethod_0(num34))
															{
																goto IL_195E;
															}
															flag3 = true;
															if (!Class53.smethod_13(gStruct, true))
															{
																goto IL_195E;
															}
														}
														IL_1998:
														if (num34 == 2)
														{
															break;
														}
														continue;
														IL_195E:
														int int_3 = 1;
														array9 = Class53.smethod_7(string_);
														if (array9 != null)
														{
															int_3 = Class53.int_0[array9[0], array9[1]];
														}
														flag9 = (Class44.smethod_5(gStruct, int_3) > 0);
														flag3 = false;
														flag2 = false;
														goto IL_1998;
													}
													if (num34 == int_2)
													{
														if (array7 == null)
														{
															int m = 0;
															while (m < array4.GetLength(0))
															{
																if ((long)int_2 != (long)((ulong)array4[m, 0]))
																{
																	m++;
																}
																else
																{
																	array7 = new uint[]
																	{
																		array4[m, 1],
																		array4[m, 2]
																	};
																	if (array7 != null)
																	{
																		goto IL_13E1;
																	}
																	if (Class11.smethod_23(long_5) > 8000L)
																	{
																		string string_4 = Class89.struct31_0[FormMain.int_100].string_1;
																		string string_5 = "<bclr=blue><color=green>[ " + string_4 + "] ch­a cã täa ®é Xa phu C«ng thµnh chiÕn, vµo B¶ng 1 - CTC bÊm nót LÊy vÞ trÝ Xa phu ®Ó lÊy täa ®é";
																		string string_6 = "<bclr=blue><color=green>NÕu vµo ®­îc CTC b»ng ThÇn Hµnh phï, th× qua tab Cµi game cña auto chän l¹i cho ®óng WEB ®ang ch¬i.";
																		Class60.smethod_50(gStruct, string_5, 1);
																		Class60.smethod_50(gStruct, string_6, 1);
																		goto IL_3ED5;
																	}
																	goto IL_3ED5;
																}
															}
														}
														IL_13E1:
														if (!flag5 && num7 < 6)
														{
															uint[] uint_2 = Class37.smethod_9(array7, int_2, "R­¬ng chøa ®å", true);
															flag5 = (Class81.smethod_0(gStruct, true, uint_2) > 0);
															num7++;
														}
														else
														{
															long num61 = Class53.smethod_18(array5, array7);
															if (num61 <= 90000L)
															{
																array = null;
																uint[] array10 = null;
																int num62 = 0;
																if (text2 != null && text2 != string.Empty)
																{
																	num62 = Class70.smethod_1(gStruct, text2, ref array10);
																	if (num62 > 0)
																	{
																		string text7 = Class86.smethod_15(gStruct, num62, ref array10, 60).Trim();
																		if (text7 == string.Empty || text7 == "Xa phu" || text7.Length <= 7)
																		{
																			num62 = 0;
																		}
																	}
																}
																if (num62 <= 0)
																{
																	string text8 = Class70.smethod_2(gStruct);
																	if (text8 != null && text8 != string.Empty)
																	{
																		text = text8;
																	}
																	Class53.smethod_8(gStruct, "Khong tim thay Xa phu Cong thanh chien, auto tu dong thiet lap lai.");
																}
																else
																{
																	for (int num63 = 0; num63 < 10; num63++)
																	{
																		array5 = new uint[]
																		{
																			Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
																			Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
																		};
																		long num64 = Class53.smethod_18(array5, array10);
																		if (num64 <= 11500L)
																		{
																			break;
																		}
																		Class60.smethod_61(gStruct, array10);
																		Thread.Sleep(300);
																	}
																	Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num62), 4, ref num23);
																	Thread.Sleep(600);
																	int num65 = Class76.smethod_1(gStruct);
																	int num66 = Class76.smethod_2(gStruct, num65);
																	if (Class76.smethod_0(gStruct) && num66 > 0 && 0 <= num65)
																	{
																		int[] array11 = new int[2];
																		int[] array12 = array11;
																		string[] array13 = new string[]
																		{
																			"Ok Ta",
																			"Vµo",
																			"chiÕn tr­êng",
																			"ThÊt-Thµnh"
																		};
																		int num67 = -1;
																		int num57 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
																		for (int j = 0; j < array13.Length; j++)
																		{
																			string object_2 = array13[j].ToLower();
																			for (int num68 = 0; num68 < num66; num68++)
																			{
																				string string_7 = Class76.smethod_3(gStruct, num68, num65).ToLower();
																				if (0 <= Class11.smethod_2(string_7, object_2))
																				{
																					num67 = num68;
																					Class76.smethod_6(gStruct, num67);
																					int i = 0;
																					while (i < 15)
																					{
																						if (Class20.smethod_30(gStruct.uint_6 + Class47.gstruct43_168.uint_0, gStruct.int_130) > 0u)
																						{
																							Class39.smethod_3(gStruct, null);
																							Thread.Sleep(450);
																						}
																						int num58 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
																						if (num57 == num58)
																						{
																							Thread.Sleep(60);
																							i++;
																						}
																						else
																						{
																							if (Class76.Class79.smethod_4(gStruct))
																							{
																								Class20.smethod_4(gStruct.uint_4, 32u);
																								goto IL_3ED5;
																							}
																							goto IL_3ED5;
																						}
																					}
																					break;
																				}
																			}
																			num66 = Class76.smethod_2(gStruct, num65);
																		}
																		if (num67 < 0)
																		{
																			array11 = new int[3];
																			array11[0] = 3;
																			array12 = array11;
																		}
																		int num69 = array12.Length;
																		for (int j = 0; j < num69; j++)
																		{
																			Class76.smethod_6(gStruct, array12[j]);
																			int i = 0;
																			while (i < 15)
																			{
																				int num58 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
																				if (num57 == num58)
																				{
																					Thread.Sleep(60);
																					i++;
																				}
																				else
																				{
																					if (Class76.Class79.smethod_4(gStruct))
																					{
																						Class20.smethod_4(gStruct.uint_4, 32u);
																						goto IL_3ED5;
																					}
																					goto IL_3ED5;
																				}
																			}
																		}
																		if (FormMain.int_101 > 0)
																		{
																			num16++;
																		}
																	}
																	if (Class76.Class79.smethod_4(gStruct))
																	{
																		Class20.smethod_4(gStruct.uint_4, 32u);
																	}
																	Class76.smethod_9(gStruct, false);
																}
															}
															else
															{
																if (array == null)
																{
																	array = new uint[]
																	{
																		array5[0],
																		array5[1]
																	};
																	num9 = 0;
																}
																if (num9 > 6)
																{
																	bool flag14 = array != null && Class53.smethod_18(array, array5) < 180000L;
																	array = null;
																	if (flag14)
																	{
																		Class53.smethod_0(gStruct, array5, Class38.gstruct29_0.uint_4, 600);
																		continue;
																	}
																	num9 = 0;
																}
																if (!Class12.smethod_4(gStruct) || Class11.smethod_23(long_) > 4000L)
																{
																	num9++;
																	Class12.smethod_1(gStruct, array7);
																	long_ = Class11.smethod_22();
																}
															}
														}
													}
													else
													{
														if (!flag2 && gStruct.bool_63)
														{
															flag2 = true;
															flag9 = Class31.smethod_61(gStruct, int_2, null, array7, false);
														}
														if (!flag9)
														{
															flag9 = (Class44.smethod_5(gStruct, int_2) > 0);
														}
													}
												}
												else
												{
													if (!FormMain.bool_3)
													{
														int num70 = Class30.smethod_1(gStruct, FormMain.int_92 <= 0);
														if (num70 == 0)
														{
															Thread.Sleep(300);
															continue;
														}
													}
													flag = true;
													if (gStruct.int_66 > 0)
													{
														Class53.smethod_1(gStruct, ref flag4);
													}
													num5 = Class69.smethod_2(gStruct);
												}
											}
											else
											{
												flag6 = (Class81.smethod_0(gStruct, true, null) <= 0);
											}
										}
										else
										{
											flag2 = false;
											flag3 = false;
											flag = false;
											num7 = 0;
											num6 = 0;
											uint[] array14 = new uint[2];
											bool flag15 = (FormMain.int_6 > 0 || FormMain.int_7 > 0) && FormMain.int_21 > 0 && (Class38.gstruct29_1.int_3 > 0 || FormMain.int_22 > 0) && Class38.gstruct29_1.int_4 > 0 && Class11.smethod_57(Class38.gstruct29_1.uint_4) && (gStruct.int_129 == Class38.gstruct29_0.int_0 || Class38.gstruct29_0.int_0 <= 0);
											if (FormMain.int_21 <= 0 || (FormMain.int_22 <= 0 && Class38.gstruct29_0.int_3 <= 0) || Class38.gstruct29_0.int_0 == gStruct.int_129 || !Class11.smethod_57(Class38.gstruct29_0.uint_4) || Class38.gstruct29_0.int_0 <= 0 || Class38.gstruct29_0.int_6 <= 0)
											{
												if (gStruct.int_68 != null && gStruct.int_68[0] > 0 && !FormMayphu.bool_3 && (num14 <= 0L || Class11.smethod_23(num14) >= 1000L))
												{
													uint[] array15 = Class53.smethod_26(gStruct, ref num13);
													if (array15 == null)
													{
														num14 = Class11.smethod_22();
													}
													else
													{
														num14 = 0L;
														long num71 = Class53.smethod_18(array5, array15);
														if (num71 < 8000L)
														{
															goto IL_25BD;
														}
														if (num71 >= 15000L && num71 >= (long)(gStruct.int_68[1] * gStruct.int_68[1]))
														{
															if (num71 < 360000L)
															{
																if (num19 > 0)
																{
																	Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
																}
																num19 = 0;
																Class12.smethod_3(gStruct, false);
																Class60.smethod_61(gStruct, array15);
																Thread.Sleep(200);
																continue;
															}
															if (num71 < 1200000L)
															{
																if (Class11.smethod_23(long_) > 3000L)
																{
																	Class12.smethod_1(gStruct, array15);
																	long_ = Class11.smethod_22();
																	continue;
																}
																continue;
															}
														}
														else if (num32 <= 3 && num71 > 7500L)
														{
															if (num19 > 0)
															{
																Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
															}
															num19 = 0;
															Class60.smethod_61(gStruct, array15);
															Thread.Sleep(200);
															goto IL_3B7B;
														}
													}
												}
												if (flag15)
												{
													int num70 = FormMayphu.smethod_6(gStruct, ref long_, ref num9, ref array);
													if (num70 <= 0)
													{
														Thread.Sleep(100);
														continue;
													}
													num32 = (int)Class20.smethod_30(num30 + Class47.gstruct43_55.uint_0, gStruct.int_130);
													if (num32 < 3)
													{
														array5 = new uint[]
														{
															Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
															Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
														};
														if (Class53.smethod_18(array5, Class38.gstruct29_1.uint_4) > 5625L)
														{
															if (num19 > 0)
															{
																Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
															}
															num19 = 0;
															Class60.smethod_61(gStruct, Class38.gstruct29_1.uint_4);
															Thread.Sleep(150);
														}
													}
												}
											}
											else
											{
												num34 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
												array5 = new uint[]
												{
													Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
													Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
												};
												if (Class38.gstruct29_0.int_4 == num34 && Class89.smethod_0(num34))
												{
													long num64 = Class53.smethod_18(array5, Class38.gstruct29_0.uint_4);
													if (!flag8 && num64 <= (long)(num40 * num40))
													{
														Class12.smethod_3(gStruct, false);
														int num72 = num10;
														num10 = 0;
														array = null;
														num9 = 0;
														if (num35 > 0 && !gStruct.bool_33 && gStruct.bool_64 && gStruct.int_90 == 1 && FormMain.int_96 > 0 && (FormMain.int_31 > 0 || FormMain.int_30 > 0 || FormMain.int_32 > 0) && Class20.smethod_30(num30 + Class47.gstruct43_44.uint_0, gStruct.int_130) > 0u && Class20.smethod_30(num30 + Class47.gstruct43_43.uint_0, gStruct.int_130) > 0u && Class11.smethod_23(long_2) > 600L)
														{
															Class60.smethod_55(gStruct, "Switch([[horse]])");
															long_2 = Class11.smethod_22();
														}
														if (num15 <= 0L || Class11.smethod_23(num15) >= 1500L)
														{
															uint[] uint_3 = new uint[]
															{
																array5[0],
																array5[1]
															};
															if (Class38.smethod_4(num31, ref array5, ref num8) <= 0)
															{
																num15 = 0L;
																if (num19 == 0 && Class53.smethod_18(uint_3, Class38.gstruct29_0.uint_4) > (long)(FormMain.int_23 * FormMain.int_23))
																{
																	num11++;
																	if (num11 > 3)
																	{
																		Class60.smethod_61(gStruct, Class38.gstruct29_0.uint_4);
																		Thread.Sleep(150);
																		num11 = 0;
																	}
																}
																if (FormMain.int_27 > 0 && num35 > 0 && gStruct.int_123[0] > 0 && Class60.smethod_3(gStruct, Class60.uint_13) == 0)
																{
																	Class60.smethod_2(gStruct, Class60.uint_13, 1, 4);
																}
															}
															else
															{
																long num73 = Class53.smethod_18(uint_3, Class38.gstruct29_0.uint_4);
																long num74 = Class53.smethod_18(array5, Class38.gstruct29_0.uint_4);
																if (num74 <= (long)(num40 * num40))
																{
																	num15 = Class11.smethod_22();
																	if (num19 > 0)
																	{
																		Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
																	}
																	num19 = 0;
																	Class38.smethod_5(gStruct, array5, Class38.gstruct29_0.uint_4, num73 <= 5625L);
																	goto IL_3B7B;
																}
																if (num72 > 0)
																{
																	uint[] uint_4 = Class53.smethod_3(array5, Class38.gstruct29_0.uint_4, -100);
																	Class60.smethod_61(gStruct, uint_4);
																	Thread.Sleep(120);
																	goto IL_213D;
																}
																goto IL_213D;
															}
														}
														num9 = 0;
														array = null;
														uint_ = Class38.gstruct29_0.uint_4;
														bool_ = true;
														goto IL_25BD;
													}
													IL_213D:
													flag8 = (num64 > 40000L);
													Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
													num19 = 0;
													if (array == null)
													{
														array = new uint[]
														{
															array5[0],
															array5[1]
														};
														num9 = 0;
													}
													if (num9 > 6)
													{
														long num75 = Class53.smethod_18(array, array5);
														array = null;
														if (num75 < 180000L)
														{
															Class12.smethod_3(gStruct, false);
															Class53.smethod_0(gStruct, array5, Class38.gstruct29_0.uint_4, 600);
															goto IL_3B7B;
														}
														num9 = 0;
													}
													if (num64 > (long)(FormMain.int_95 * FormMain.int_95))
													{
														Class6.smethod_2(gStruct, num30, ref long_2, true);
													}
													if (num64 < 900000L && num10 < 6)
													{
														num10++;
														Class12.smethod_3(gStruct, false);
														Class60.smethod_61(gStruct, Class38.gstruct29_0.uint_4);
														Thread.Sleep(150);
														goto IL_3B7B;
													}
													if (Class38.gstruct29_0.uint_4 != null && (!Class12.smethod_4(gStruct) || Class11.smethod_23(long_) > 4000L))
													{
														Class12.smethod_1(gStruct, Class38.gstruct29_0.uint_4);
														long_ = Class11.smethod_22();
														num9++;
														num10 = 0;
														continue;
													}
													continue;
												}
												else if (Class89.smethod_0(Class38.gstruct29_0.int_4))
												{
													array5 = new uint[]
													{
														Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
														Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
													};
													uint[] array16 = Class89.smethod_1(num34, array5, Class38.gstruct29_0.int_4, Class38.gstruct29_0.uint_4);
													if (array16 != null)
													{
														uint[] array17 = new uint[]
														{
															array16[0],
															array16[1]
														};
														int int_4 = (int)array16[2];
														long num64 = (long)((ulong)Class32.smethod_0(array5, array17));
														if (num64 < 90000L)
														{
															num9 = 0;
															num9 = 0;
															array = null;
															Class12.smethod_3(gStruct, false);
															for (int n = 0; n < 10; n++)
															{
																array5 = new uint[]
																{
																	Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
																	Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
																};
																num64 = Class53.smethod_18(array5, array17);
																if (num64 < 11500L || (ulong)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130) != (ulong)((long)num34))
																{
																	break;
																}
																Class60.smethod_61(gStruct, array17);
																Thread.Sleep(300);
															}
															for (int num68 = 0; num68 < 5; num68++)
															{
																Class53.smethod_25(gStruct, int_4);
																Thread.Sleep(300);
																uint num76 = Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
																if ((ulong)num76 != (ulong)((long)num34))
																{
																	break;
																}
															}
															continue;
														}
														if (array == null)
														{
															array = new uint[]
															{
																array5[0],
																array5[1]
															};
															num9 = 0;
														}
														Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
														num19 = 0;
														flag11 = (Class20.smethod_30(num30 + Class47.gstruct43_44.uint_0, gStruct.int_130) > 0u);
														if (gStruct.bool_64 && !flag11 && Class11.smethod_23(long_2) > 300L)
														{
															Class60.smethod_55(gStruct, "Switch([[horse]])");
															long_2 = Class11.smethod_22();
														}
														if (num9 > 6)
														{
															long num75 = Class53.smethod_18(array, array5);
															array = null;
															if (num75 < 180000L)
															{
																Class53.smethod_0(gStruct, array5, array17, 600);
																continue;
															}
															num9 = 0;
														}
														if (!Class12.smethod_4(gStruct) || Class11.smethod_23(long_) > 6000L)
														{
															num9++;
															Class12.smethod_1(gStruct, array17);
															long_ = Class11.smethod_22();
															continue;
														}
														continue;
													}
												}
											}
											IL_25BD:
											num35 = (int)Class20.smethod_30(num30 + Class47.gstruct43_43.uint_0, gStruct.int_130);
											if (num35 <= 0)
											{
												continue;
											}
											bool flag16 = FormMain.int_21 > 0 && Class38.gstruct29_0.int_0 != gStruct.int_129 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_6 > 0 && Class38.gstruct29_0.int_4 == num34;
											flag13 = (!gStruct.bool_33 && (FormMain.int_31 > 0 || FormMain.int_30 > 0));
											if (gStruct.int_97[0] > 0 && gStruct.int_97[1] > 0 && gStruct.string_21 == "NGAMY")
											{
												long num77 = Class11.smethod_23(long_4);
												if (num77 < 300L)
												{
													continue;
												}
												if (num77 > (long)gStruct.int_97[4] && Class7.smethod_3(gStruct))
												{
													long_4 = Class11.smethod_22();
													continue;
												}
											}
											if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
											{
												if (!gStruct.bool_33)
												{
													bool flag17 = gStruct.int_122[0] > 0 && gStruct.int_122[1] > 0 && gStruct.int_122[2] > 0;
													bool flag18 = gStruct.int_122[0] > 0 && gStruct.int_122[3] > 0 && gStruct.int_122[4] > 0;
													bool flag19 = gStruct.int_122[0] > 0 && gStruct.int_122[5] > 0 && gStruct.int_122[6] > 0;
													flag12 = ((flag17 || flag18 || flag19) && gStruct.string_21 == "DUONGMON");
													if (FormDame.int_6 > 0 && !flag12)
													{
														if (!flag13 && FormDame.int_7 <= 0)
														{
															goto IL_3B7B;
														}
														int num78 = 0;
														if (FormDame.int_5 != 0)
														{
															bool flag20 = Class38.gstruct29_0.int_8 == 1 || (flag15 && Class38.gstruct29_1.int_8 == 1);
															if (FormDame.int_5 != 1)
															{
																if (FormDame.int_5 == 2 && !flag20)
																{
																	if (num19 > 0)
																	{
																		Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
																	}
																	num19 = 0;
																	goto IL_3B7B;
																}
															}
															else
															{
																if (flag20)
																{
																	goto IL_2876;
																}
																if (FormDame.int_8 <= 0)
																{
																	if (num19 > 0)
																	{
																		Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
																	}
																	num19 = 0;
																	goto IL_3B7B;
																}
															}
															goto IL_2BD5;
														}
														IL_2876:
														uint num79 = 0u;
														uint[] array18 = null;
														uint[] uint_5 = null;
														if (!flag15)
														{
															if (gStruct.int_129 != Class38.gstruct29_0.int_0 && gStruct.int_129 != Class66.gstruct42_0.int_129 && Class38.gstruct29_0.uint_5 > 0u)
															{
																uint num80 = Class38.gstruct29_0.uint_5 >> 16;
																uint int_5 = Class38.gstruct29_0.uint_5 - (num80 << 16);
																array18 = Class73.smethod_11(Class38.gstruct29_0.uint_4, (int)int_5, (int)num80);
																uint[] array19 = Class73.smethod_10(array5, array18);
																num79 = (array19[1] << 16) + array19[0];
																uint_5 = Class38.gstruct29_0.uint_4;
																Class73.smethod_7(gStruct, num79);
															}
														}
														else
														{
															uint num80 = Class38.gstruct29_1.uint_5 >> 16;
															uint int_5 = Class38.gstruct29_1.uint_5 - (num80 << 16);
															array18 = Class73.smethod_11(Class38.gstruct29_1.uint_4, (int)int_5, (int)num80);
															uint[] array19 = Class73.smethod_10(array5, array18);
															num79 = (array19[1] << 16) + array19[0];
															uint_5 = Class38.gstruct29_1.uint_4;
															Class73.smethod_7(gStruct, num79);
														}
														flag11 = (Class20.smethod_30(num30 + Class47.gstruct43_44.uint_0, gStruct.int_130) > 0u);
														Class53.smethod_30(gStruct, flag11, ref long_2);
														if (gStruct.int_121[0] > 0)
														{
															bool flag21 = gStruct.int_121[1] > 0 && gStruct.int_121[2] > 0;
															bool flag22 = gStruct.int_121[3] > 0 && gStruct.int_121[4] > 0;
															if (flag21 && !flag22)
															{
																num78 = gStruct.int_121[2];
															}
															else if (flag22 && !flag21)
															{
																num78 = gStruct.int_121[4];
															}
															else if (flag21 && flag22)
															{
																if (0 <= num12 && num12 <= 25)
																{
																	num78 = gStruct.int_121[2];
																}
																else
																{
																	num78 = gStruct.int_121[4];
																}
																if (num12 > 35)
																{
																	num12 = 0;
																}
																num12++;
															}
														}
														if (num78 <= 0)
														{
															num78 = Class32.smethod_32(gStruct);
														}
														if (gStruct.int_129 != Class38.gstruct29_0.int_0 || FormMain.int_6 > 0 || FormMain.int_7 > 0)
														{
															Class67.smethod_7(gStruct, null);
														}
														Class67.smethod_3(gStruct, num78, 6, 1);
														for (int num81 = 0; num81 < 3; num81++)
														{
															Class20.smethod_75(gStruct.uint_4, 117);
															if (num81 < 2)
															{
																Thread.Sleep(60);
															}
														}
														if (num79 == 0u || gStruct.int_129 == Class66.gstruct42_0.int_129)
														{
															goto IL_3B7B;
														}
														if (gStruct.int_92 <= 0)
														{
															Class20.smethod_30(num30 + Class47.gstruct43_31.uint_0, gStruct.int_130);
															int num82 = Class32.smethod_32(gStruct);
															if (num82 == 53 || num82 <= 1)
															{
																goto IL_3B7B;
															}
															if (num82 <= 100)
															{
															}
														}
														string string_8 = Class73.smethod_20(gStruct);
														if (!Class11.smethod_3(string_8, "iÓm qu¸ x", false))
														{
															goto IL_3B7B;
														}
														uint[] array20 = Class53.smethod_3(uint_5, array18, -1 * (FormMain.int_23 - 50));
														long num83 = Class53.smethod_18(array5, array20);
														if (num83 > 7000L)
														{
															Class60.smethod_61(gStruct, array20);
															Thread.Sleep(150);
															Class73.smethod_21(gStruct, "0K..");
															goto IL_3B7B;
														}
														goto IL_3B7B;
													}
													IL_2BD5:
													if (flag13)
													{
														if (!Class38.smethod_6(gStruct, ref num22) && Class73.smethod_12(gStruct) != 1)
														{
															num34 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
															array5 = new uint[]
															{
																Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
																Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
															};
															uint[] uint_6 = array5;
															if (flag16 && Class38.gstruct29_0.int_4 == num34 && Class38.gstruct29_0.int_3 > 0 && Class38.gstruct29_0.uint_4 != null)
															{
																uint_6 = Class38.gstruct29_0.uint_4;
																num38 += num40;
															}
															uint num84 = 0u;
															if (FormMain.int_33 > 0 && (flag15 || flag16))
															{
																if (!flag15)
																{
																	if (flag16 && Class38.gstruct29_0.int_4 == num34 && Class38.gstruct29_0.uint_3 != num31)
																	{
																		num84 = Class38.gstruct29_0.uint_3;
																	}
																}
																else if (Class38.gstruct29_1.int_4 == num34 && Class38.gstruct29_1.uint_3 != num31)
																{
																	num84 = Class38.gstruct29_1.uint_3;
																}
																if (num84 <= 0u && FormMain.int_34 <= 0)
																{
																	goto IL_3B7B;
																}
															}
															if (gStruct.int_116 > 0 && gStruct.int_3 != null)
															{
																int[,] array21;
																if (gStruct.int_5 > 0)
																{
																	array21 = Class7.smethod_5(gStruct, num84, num38, uint_6, null, false, false, false);
																}
																else
																{
																	array21 = Class7.smethod_6(gStruct, num84, num38, uint_6, null, false, false, false);
																}
																if (array21 != null && array21[0, 0] >= 0)
																{
																	int num85 = -1;
																	int int_6 = Class38.gstruct29_0.int_4;
																	num19 = 0;
																	bool flag23 = false;
																	bool flag24 = false;
																	while (true)
																	{
																		int num86 = 0;
																		int num87 = 400;
																		while (num86 <= 0)
																		{
																			num85++;
																			if (gStruct.int_3 == null || gStruct.int_3.Length <= num85)
																			{
																				goto IL_324D;
																			}
																			num86 = gStruct.int_3[num85];
																			if (num86 > 0)
																			{
																				num87 = Class67.smethod_21(num86);
																				break;
																			}
																		}
																		num32 = (int)Class20.smethod_30(num30 + Class47.gstruct43_55.uint_0, gStruct.int_130);
																		num33 = (int)Class20.smethod_30(num30 + Class47.gstruct43_50.uint_0, gStruct.int_130);
																		num35 = (int)Class20.smethod_30(num30 + Class47.gstruct43_43.uint_0, gStruct.int_130);
																		int num88 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
																		if (num35 <= 0 || num34 != num88 || num32 == 11 || num32 == 22 || num33 == 0)
																		{
																			break;
																		}
																		for (int num89 = 0; num89 < array21.GetLength(0); num89++)
																		{
																			if (Class38.smethod_6(gStruct, ref num22) || Class73.smethod_12(gStruct) == 1)
																			{
																				goto IL_3638;
																			}
																			int num90 = array21[num89, 0];
																			num41 = array21[num89, 1];
																			if (num41 > 0)
																			{
																				uint num91 = num29 + (uint)(num41 * (int)Class47.gstruct43_15.uint_0);
																				Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_50.uint_0, array3, 4, ref num23);
																				if (BitConverter.ToInt32(array3, 0) > 0)
																				{
																					if (num90 > 0)
																					{
																						Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_43.uint_0, array3, 4, ref num23);
																						if (BitConverter.ToInt32(array3, 0) <= 0)
																						{
																							goto IL_3224;
																						}
																					}
																					flag23 = true;
																					if (flag24 && num90 <= 0)
																					{
																						goto IL_324D;
																					}
																					if (num90 > 0)
																					{
																						flag24 = true;
																					}
																					int num92 = Class86.smethod_30(gStruct, num41, num86);
																					if (num92 == 0)
																					{
																						num39 = num87;
																						Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array3, 4, ref num23);
																						array14[0] = BitConverter.ToUInt32(array3, 0);
																						Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array3, 4, ref num23);
																						array14[1] = BitConverter.ToUInt32(array3, 0);
																						array5 = new uint[]
																						{
																							Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
																							Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
																						};
																						if (flag16)
																						{
																							array5 = new uint[]
																							{
																								Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
																								Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
																							};
																							long num93 = Class53.smethod_18(array5, Class38.gstruct29_0.uint_4);
																							if (int_6 != Class38.gstruct29_0.int_4 || num93 > (long)(num40 * num40))
																							{
																								goto IL_3614;
																							}
																							int num94 = (int)Math.Sqrt((double)Class53.smethod_18(Class38.gstruct29_0.uint_4, array14));
																							int num95 = (int)Math.Sqrt((double)Class53.smethod_18(array5, array14));
																							int num96 = num94 - num40 + 10;
																							bool arg_3176_0;
																							if (num94 <= num40 || num39 >= num96)
																							{
																								arg_3176_0 = true;
																								goto IL_3176;
																							}
																							if (num95 > num94)
																							{
																								arg_3176_0 = false;
																								goto IL_3176;
																							}
																							if (num95 >= num94 || num39 >= num95)
																							{
																								goto IL_317C;
																							}
																							IL_3178:
																							num39 = num96;
																							goto IL_317C;
																							IL_3176:
																							if (!arg_3176_0)
																							{
																								goto IL_3178;
																							}
																						}
																						IL_317C:
																						if (Class53.smethod_18(array5, array14) <= (long)(num39 * num39) || gStruct.int_92 > 0)
																						{
																							if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
																							{
																								Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_157.uint_0 - 8u, BitConverter.GetBytes(num86), 4, ref num23);
																								Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num39), 4, ref num23);
																								Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num41), 4, ref num23);
																								Thread.Sleep(10);
																							}
																							num19 = 1;
																						}
																					}
																				}
																			}
																			IL_3224:;
																		}
																	}
																	if (num19 > 0)
																	{
																		Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
																	}
																	num19 = 0;
																	goto IL_3B7B;
																	IL_3638:
																	Thread.Sleep(120);
																	num19 = 0;
																	goto IL_3B7B;
																	IL_3614:
																	Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
																	goto IL_3B7B;
																	IL_324D:
																	if (num19 <= 0 && gStruct.int_6 <= 0 && flag23)
																	{
																		long num97 = 0L;
																		array5 = new uint[]
																		{
																			Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
																			Class20.smethod_30(num30 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
																		};
																		num41 = -1;
																		flag24 = false;
																		num39 = gStruct.int_128;
																		if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
																		{
																			num39 = gStruct.int_93;
																		}
																		if (num39 <= 0)
																		{
																			num39 = 500;
																		}
																		for (int num89 = 0; num89 < array21.GetLength(0); num89++)
																		{
																			int num98 = array21[num89, 0];
																			int num99 = array21[num89, 1];
																			int num100 = num39;
																			if (num99 > 0)
																			{
																				uint num91 = num29 + (uint)(num99 * (int)Class47.gstruct43_15.uint_0);
																				Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_50.uint_0, array3, 4, ref num23);
																				if (BitConverter.ToInt32(array3, 0) > 0)
																				{
																					if (num98 > 0)
																					{
																						Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_43.uint_0, array3, 4, ref num23);
																						if (BitConverter.ToInt32(array3, 0) <= 0)
																						{
																							goto IL_34F9;
																						}
																					}
																					if (flag24 && num98 <= 0 && num41 > 0)
																					{
																						break;
																					}
																					Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array3, 4, ref num23);
																					array14[0] = BitConverter.ToUInt32(array3, 0);
																					Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array3, 4, ref num23);
																					array14[1] = BitConverter.ToUInt32(array3, 0);
																					long num101 = Class53.smethod_18(array5, array14);
																					if (num41 <= 0 || num97 >= num101)
																					{
																						if (flag16)
																						{
																							int num94 = (int)Math.Sqrt((double)Class53.smethod_18(Class38.gstruct29_0.uint_4, array14));
																							int num95 = (int)Math.Sqrt((double)Class53.smethod_18(array5, array14));
																							int num96 = num94 - num40 + 10;
																							bool arg_34C0_0;
																							if (num94 <= num40 || num100 >= num96)
																							{
																								arg_34C0_0 = true;
																								goto IL_34C0;
																							}
																							if (num95 > num94)
																							{
																								arg_34C0_0 = false;
																								goto IL_34C0;
																							}
																							if (num95 >= num94 || num100 >= num95)
																							{
																								goto IL_34C6;
																							}
																							IL_34C2:
																							num100 = num96;
																							goto IL_34C6;
																							IL_34C0:
																							if (!arg_34C0_0)
																							{
																								goto IL_34C2;
																							}
																						}
																						IL_34C6:
																						if (num101 <= (long)(num100 * num100) || gStruct.int_92 > 0)
																						{
																							if (num98 > 0)
																							{
																								flag24 = true;
																							}
																							num41 = num99;
																							num97 = num101;
																							num39 = num100;
																						}
																					}
																				}
																			}
																			IL_34F9:;
																		}
																		if (num41 > 0)
																		{
																			flag11 = (Class20.smethod_30(num30 + Class47.gstruct43_44.uint_0, gStruct.int_130) > 0u);
																			Class53.smethod_29(gStruct, flag11, ref long_2);
																			if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
																			{
																				Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_157.uint_0 - 8u, BitConverter.GetBytes(Class32.smethod_32(gStruct)), 4, ref num23);
																				Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num39), 4, ref num23);
																				Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num41), 4, ref num23);
																			}
																		}
																	}
																	else if (flag23 && num19 <= 0 && gStruct.int_6 > 0)
																	{
																		Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
																	}
																}
															}
															else if (!(flag13 = (!gStruct.bool_33 && (FormMain.int_31 > 0 || FormMain.int_30 > 0))))
															{
																flag13 = false;
															}
															else
															{
																int[,] array21 = Class7.smethod_5(gStruct, num84, num38, uint_6, null, false, false, false);
																if (array21 != null)
																{
																	if (array21[0, 0] == -100)
																	{
																		continue;
																	}
																	int num102 = 0;
																	while (array21[num102, 1] > 0)
																	{
																		array14 = new uint[]
																		{
																			(uint)array21[num102, 4],
																			(uint)array21[num102, 5]
																		};
																		if (!flag16)
																		{
																			if (Class53.smethod_18(array5, array14) > (long)(num39 * num39) && gStruct.int_92 <= 0)
																			{
																				if (gStruct.int_86 == 1 && num102 == 0)
																				{
																					num102 = 1;
																					continue;
																				}
																				goto IL_3B7B;
																			}
																		}
																		else
																		{
																			int num95 = (int)Math.Sqrt((double)Class53.smethod_18(array5, array14));
																			int num94 = (int)Math.Sqrt((double)Class53.smethod_18(Class38.gstruct29_0.uint_4, array14));
																			if (num95 - num39 > 0)
																			{
																				if (num94 > num95)
																				{
																					int num103 = (int)Math.Sqrt((double)Class53.smethod_18(Class38.gstruct29_0.uint_4, array5));
																					if (num103 + (num95 - num39) <= num40 + 10)
																					{
																						goto IL_385F;
																					}
																				}
																				if (gStruct.int_86 == 1 && num102 == 0)
																				{
																					num102 = 1;
																					continue;
																				}
																				if (num40 + num39 <= num94)
																				{
																					if (num19 > 0)
																					{
																						Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
																					}
																					num19 = 0;
																					goto IL_3B7B;
																				}
																			}
																		}
																		IL_385F:
																		int num90 = array21[num102, 0];
																		num41 = array21[num102, 1];
																		if (FormMain.int_50 > 0 && (num90 <= 0 || num90 == array2[0]) && array2[1] > 0 && array2[2] == num34 && array2[3] > 0)
																		{
																			int num104 = array2[0];
																			int num105 = array2[1];
																			uint num91 = num29 + (uint)(num105 * (int)Class47.gstruct43_15.uint_0);
																			Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_50.uint_0, array3, 4, ref num23);
																			if (BitConverter.ToInt32(array3, 0) > 0)
																			{
																				Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_45.uint_0, array3, 4, ref num23);
																				long num106 = (long)BitConverter.ToInt32(array3, 0);
																				if (num106 != 0L)
																				{
																					Class20.ReadProcessMemory(gStruct.int_130, num91 + Class47.gstruct43_43.uint_0, array3, 4, ref num23);
																					if (num104 <= 0 || BitConverter.ToInt32(array3, 0) > 0)
																					{
																						array14 = new uint[]
																						{
																							Class20.smethod_30(num91 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
																							Class20.smethod_30(num91 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
																						};
																						long num107 = Class53.smethod_18(array5, array14);
																						if (!flag16)
																						{
																							if (num107 <= (long)(num39 * num39))
																							{
																								num90 = num104;
																								num41 = num105;
																							}
																						}
																						else
																						{
																							int num108 = (int)Math.Sqrt((double)num107);
																							int num109 = (int)Math.Sqrt((double)Class53.smethod_18(Class38.gstruct29_0.uint_4, array14));
																							if (num108 - num39 > 0)
																							{
																								if (num109 > num108)
																								{
																									int num103 = (int)Math.Sqrt((double)Class53.smethod_18(Class38.gstruct29_0.uint_4, array5));
																									if (num103 + (num108 - num39) <= num40 + 10)
																									{
																										num90 = num104;
																										num41 = num105;
																									}
																								}
																							}
																							else
																							{
																								num90 = num104;
																								num41 = num105;
																							}
																						}
																					}
																				}
																			}
																		}
																		array2[0] = num90;
																		array2[1] = num41;
																		array2[2] = num34;
																		array2[3] = 0;
																		if (num41 <= 0)
																		{
																			goto IL_3B7B;
																		}
																		array2[3] = 1;
																		num19 = 1;
																		num20 = 1;
																		flag11 = (Class20.smethod_30(num30 + Class47.gstruct43_44.uint_0, gStruct.int_130) > 0u);
																		Class53.smethod_29(gStruct, flag11, ref long_2);
																		if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
																		{
																			Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_157.uint_0 - 8u, BitConverter.GetBytes(Class32.smethod_32(gStruct)), 4, ref num23);
																			Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num39), 4, ref num23);
																			Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num41), 4, ref num23);
																			goto IL_3B7B;
																		}
																		goto IL_3B7B;
																	}
																	if (num19 > 0)
																	{
																		Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
																	}
																	num19 = 0;
																}
																else
																{
																	flag13 = false;
																}
															}
														}
														else
														{
															Thread.Sleep(120);
															num19 = 0;
														}
													}
												}
												else if (gStruct.int_129 != Class38.gstruct29_0.int_0)
												{
													Class6.smethod_2(gStruct, num30, ref long_2, true);
												}
											}
											IL_3B7B:
											if (!flag13 && gStruct.int_129 != Class38.gstruct29_0.int_0 && Class32.smethod_59(gStruct, new int[]
											{
												0,
												1
											}) > 0u)
											{
												if (num19 > 0)
												{
													Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
												}
												num19 = 0;
											}
											if (flag12 && num41 <= 0)
											{
												FormDuongMon.smethod_0(gStruct, ref num17, uint_, ref num18, bool_);
											}
											if (gStruct.bool_66 && gStruct.int_81 > 0)
											{
												if (FormMain.int_93 == 0)
												{
													if (num41 > 0 && Class11.smethod_23(long_3) > gStruct.long_7)
													{
														Class32.smethod_55(gStruct, array14, false, 10);
														Class32.smethod_56(gStruct);
														long_3 = Class11.smethod_22();
													}
												}
												else if (Class38.gstruct29_0.int_7 == Class24.gstruct38_0[FormMain.int_94].int_0)
												{
													Class32.smethod_55(gStruct, null, true, 10);
													if (Class11.smethod_23(long_3) > gStruct.long_7)
													{
														Class32.smethod_56(gStruct);
														long_3 = Class11.smethod_22();
													}
												}
											}
										}
									}
									else
									{
										flag = false;
										flag2 = false;
										flag3 = false;
										flag4 = false;
										array = null;
										int num110 = 0;
										while (num != num34)
										{
											int num111 = Class73.smethod_40(gStruct);
											Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array3, 4, ref num23);
											num26 = BitConverter.ToUInt32(array3, 0);
											Class20.ReadProcessMemory(gStruct.int_130, num26 + Class47.gstruct43_13.uint_0, array3, 4, ref num23);
											num27 = BitConverter.ToUInt32(array3, 0);
											num28 = num27 * Class47.gstruct43_15.uint_0;
											Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array3, 4, ref num23);
											num29 = BitConverter.ToUInt32(array3, 0);
											num30 = num29 + num28;
											Class20.ReadProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_50.uint_0, array3, 4, ref num23);
											num33 = BitConverter.ToInt32(array3, 0);
											Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array3, 4, ref num23);
											num34 = BitConverter.ToInt32(array3, 0);
											Class20.ReadProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_43.uint_0, array3, 4, ref num23);
											num35 = BitConverter.ToInt32(array3, 0);
											Class20.WriteProcessMemory(gStruct.int_130, num30 + Class47.gstruct43_72.uint_0, byte_, 4, ref num23);
											num19 = 0;
											if (num35 > 0 || num110 > 8 || (num111 != 0 && num111 != 1 && num33 > 0 && num34 > 0))
											{
												break;
											}
											num110++;
											Thread.Sleep(100);
										}
										num = num34;
										num2 = Class38.gstruct29_0.int_4;
									}
								}
							}
							else
							{
								bool flag25 = false;
								if (num35 == 0)
								{
									flag25 = (flag9 = (Class81.smethod_0(gStruct, true, null) != 1));
								}
								num25 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
								if (0 <= num25)
								{
									FormMain.gstruct42_0[num25].bool_29 = flag25;
								}
								if (!flag25)
								{
									Class11.smethod_22();
								}
							}
						}
						else
						{
							if (num37 <= 1)
							{
								flag4 = false;
							}
							flag10 = (num32 == 10 || num32 == 21);
							Thread.Sleep(60);
						}
					}
					else
					{
						Class17.smethod_1(int_0);
					}
				}
				else
				{
					Class34.smethod_0(int_0);
				}
			}
			else
			{
				flag = false;
			}
		}
	}

    private static int smethod_1(GStruct42 gstruct42_0, string string_0, ref uint[] uint_0)
    {
        int int_ = 0;
        byte[] array = new byte[4];
        byte[] array2 = new byte[60];
        uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
        uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
        uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
        uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
        Class20.smethod_30(num4 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
        Class20.smethod_30(num4 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
        Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
        Class20.smethod_30(num4 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
        uint[] array3 = new uint[2]
        {
            Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
            Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
        };
        uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
        Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
        int num5 = BitConverter.ToInt32(array, 0);
        if (num5 > 1)
        {
            int num6 = 0;
            string b = string_0.Trim().ToLower();
            for (uint num7 = 1u; num7 < 256; num7++)
            {
                if (num5 <= num6)
                {
                    break;
                }
                uint num8 = num3 + num7 * Class47.gstruct43_15.uint_0;
                Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
                if (array[0] == 0)
                {
                    continue;
                }
                num6++;
                Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
                if (BitConverter.ToInt32(array, 0) <= 0)
                {
                    continue;
                }
                Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_52.uint_0, array, 4, ref int_);
                uint num9 = BitConverter.ToUInt32(array, 0);
                if (num9 == 3)
                {
                    Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_16.uint_0, array2, array2.Length, ref int_);
                    string a = Class10.smethod_3(array2).Trim().ToLower();
                    if (!(a != b))
                    {
                        uint_0 = new uint[2];
                        Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_);
                        uint_0[0] = BitConverter.ToUInt32(array, 0);
                        Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array, 4, ref int_);
                        uint_0[1] = BitConverter.ToUInt32(array, 0);
                        return (int)num7;
                    }
                }
            }
            return 0;
        }
        return 0;
    }

    private static string smethod_2(GStruct42 gstruct42_0)
    {
        string[] array = new string[4]
        {
            "Xa Phu C«ng Thµnh",
            "Çu C«ng Thµnh ChiÕn",
            "ThÊt thµnh",
            "tiÕp dÉn"
        };
        uint[,] array2 = new uint[7, 3]
        {
            {
                11u,
                101952u,
                165824u
            },
            {
                78u,
                50624u,
                108160u
            },
            {
                1u,
                52544u,
                104640u
            },
            {
                162u,
                53760u,
                104832u
            },
            {
                37u,
                54144u,
                102784u
            },
            {
                80u,
                54144u,
                102976u
            },
            {
                176u,
                54048u,
                105248u
            }
        };
        int int_ = 0;
        byte[] array3 = new byte[4];
        byte[] array4 = new byte[60];
        uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
        uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
        uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
        uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
        Class20.smethod_30(num4 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
        Class20.smethod_30(num4 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
        int num5 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
        Class20.smethod_30(num4 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
        uint[] array5 = new uint[2]
        {
            Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
            Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
        };
        int num6 = -1;
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            if (num5 == array2[i, 0])
            {
                num6 = i;
                break;
            }
        }
        if (num6 >= 0)
        {
            uint[] uint_ = new uint[2]
            {
                array2[num6, 1],
                array2[num6, 2]
            };
            uint uint_2 = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
            Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array3, 4, ref int_);
            int num7 = BitConverter.ToInt32(array3, 0);
            if (num7 <= 1)
            {
                return null;
            }
            int num8 = 0;
            long num9 = 0L;
            uint[] array6 = new uint[2];
            string text = null;
            for (uint num10 = 1u; num10 < 256; num10++)
            {
                if (num7 <= num8)
                {
                    break;
                }
                uint num11 = num3 + num10 * Class47.gstruct43_15.uint_0;
                Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_16.uint_0, array3, 4, ref int_);
                if (array3[0] == 0)
                {
                    continue;
                }
                num8++;
                Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_52.uint_0, array3, 4, ref int_);
                uint num12 = BitConverter.ToUInt32(array3, 0);
                if (num12 != 3)
                {
                    continue;
                }
                uint[] array7 = new uint[2];
                Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array3, 4, ref int_);
                array7[0] = BitConverter.ToUInt32(array3, 0);
                Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array3, 4, ref int_);
                array7[1] = BitConverter.ToUInt32(array3, 0);
                Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_16.uint_0, array4, array4.Length, ref int_);
                string text2 = Class10.smethod_3(array4);
                string string_ = text2.ToLower();
                bool flag = false;
                for (int j = 0; j < array.Length; j++)
                {
                    if (0 <= Class11.smethod_2(string_, array[j].ToLower()))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    string text3 = text2.Trim();
                    if (!(text3 == "Xa phu") && text3.Length > 7)
                    {
                        long num13 = Class53.smethod_18(uint_, array7);
                        if (num13 < 22500L && (text == null || num13 < num9))
                        {
                            num9 = num13;
                            array6[0] = array7[0];
                            array6[1] = array7[1];
                            text = text2;
                        }
                    }
                    continue;
                }
                array6[0] = array7[0];
                array6[1] = array7[1];
                text = text2;
                break;
            }
            return text;
        }
        return null;
    }
}
