using System;
using System.Threading;

internal class Class75
{
	public static void smethod_0(int int_0)
	{
		while (true)
		{
			try
			{
				smethod_1(int_0);
				return;
			}
			catch
			{
				Thread.Sleep(300);
			}
		}
	}

	public static void smethod_1(int int_0)
	{
		bool flag = false;
		bool flag2 = false;
		GStruct42 gStruct = default(GStruct42);
		int num = -1;
		string text = "MËt ®å thÇn bÝ";
		int num2 = -1;
		string text2 = "LÖnh bµi Vi S¬n";
		int num3 = 0;
		int num4 = -1;
		int int_ = 0;
		int num5 = 0;
		int int_2 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		int num6 = 0;
		int num7 = 0;
		bool flag3 = false;
		int num8;
		while (true)
		{
			Thread.Sleep(200);
			num8 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (Class11.bool_0 || num8 < 0)
			{
				return;
			}
			gStruct = FormMain.gstruct42_0[num8];
			if (!gStruct.bool_36 || !gStruct.bool_61 || flag)
			{
				break;
			}
			uint num29;
			int num13;
			uint num18;
			uint num27;
			uint num23;
			uint num25;
			uint num26;
			int num20;
			if (!flag2)
			{
				uint num9 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
				uint num10 = Class20.smethod_30(num9 + Class47.gstruct43_13.uint_0, gStruct.int_130);
				uint num11 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
				uint num12 = num11 + num10 * Class47.gstruct43_15.uint_0;
				num13 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
				int num14 = (int)Class20.smethod_30(num12 + Class47.gstruct43_43.uint_0, gStruct.int_130);
				int num15 = (int)Class20.smethod_30(num12 + Class47.gstruct43_55.uint_0, gStruct.int_130);
				int num16 = (int)Class20.smethod_30(num12 + Class47.gstruct43_50.uint_0, gStruct.int_130);
				int num17 = Class73.smethod_40(gStruct);
				if (num16 <= 0 || num13 <= 0 || num15 == 10 || num15 == 21 || num17 <= 1 || (gStruct.int_129 == Class66.gstruct42_0.int_129 && Class73.smethod_12(gStruct) == 1))
				{
					continue;
				}
				uint[] array3 = new uint[2]
				{
					Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
					Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
				};
				if (array3[0] == 0 || array3[1] == 0)
				{
					continue;
				}
				if (num13 == 342)
				{
					flag = true;
					continue;
				}
				if (Class50.smethod_1(num13) != null)
				{
					flag2 = (Class44.smethod_5(gStruct, 11) > 0);
					continue;
				}
				num18 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130) + Class47.gstruct43_94.uint_0;
				uint num19 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gStruct.int_130);
				num20 = 0;
				int num21 = Class69.smethod_2(gStruct);
				int num22 = 0;
				num23 = 0u;
				uint num24 = 0u;
				num25 = 0u;
				num26 = 0u;
				num27 = 0u;
				uint num28 = 0u;
				string text3 = null;
				if (num2 == -1)
				{
					num2 = 0;
					num = 0;
					for (num29 = 1u; num29 < Class47.int_1 && num21 > num22; num29++)
					{
						num24 = num19 + num29 * Class47.gstruct43_103.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, num24 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_2);
						if (BitConverter.ToInt32(array, 0) != 0)
						{
							continue;
						}
						num27 = Class69.smethod_0(gStruct, num29);
						if ((int)num27 <= 0)
						{
							continue;
						}
						num22++;
						num28 = num24 + Class47.gstruct43_104.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, num28, array, 1, ref int_2);
						if (array[0] == 0 || (int)Class20.smethod_30(num24 + Class47.gstruct43_105.uint_0, gStruct.int_130) <= 0)
						{
							continue;
						}
						uint num30 = Class20.smethod_30(num18 + num27 * 20 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
						if (num30 != 23 && num30 != 3 && num30 != 1)
						{
							continue;
						}
						Class20.ReadProcessMemory(gStruct.int_130, num28, array2, array2.Length, ref int_2);
						text3 = Class10.smethod_3(array2).ToLower();
						if (0 > text3.IndexOf(text2.ToLower()))
						{
							if (num > 0)
							{
								continue;
							}
							uint num31 = Class20.smethod_30(num24 + Class47.gstruct43_116.uint_0, gStruct.int_130);
							if (num31 != 100 || 0 > text3.IndexOf(text.ToLower()))
							{
								continue;
							}
							goto IL_044f;
						}
						goto IL_0454;
					}
				}
				num13 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
				switch (num13)
				{
				case 342:
					flag = true;
					break;
				case 175:
					if (num2 > 0 || num > 0)
					{
						if (num13 != 175)
						{
							break;
						}
						uint num33 = Class32.smethod_42(gStruct);
						if (num33 < 500)
						{
							Class60.smethod_35(gStruct, 500 - num33);
							Thread.Sleep(300);
						}
						long long_ = 0L;
						uint[] array4 = new uint[2]
						{
							54912u,
							99968u
						};
						while (!Class11.bool_0)
						{
							num8 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
							if (!Class11.bool_0 && num8 >= 0 && FormMain.gstruct42_0[num8].bool_36 && FormMain.gstruct42_0[num8].bool_61)
							{
								array3 = new uint[2]
								{
									Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
									Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
								};
								if (Class53.smethod_18(array3, array4) < 120000L)
								{
									break;
								}
								if (Class11.smethod_23(long_) > 6000L)
								{
									Class12.smethod_1(gStruct, array4);
									long_ = Class11.smethod_22();
								}
								Thread.Sleep(600);
								continue;
							}
							return;
						}
						for (num20 = 0; num20 < 10; num20++)
						{
							array3 = new uint[2]
							{
								Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
								Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
							};
							if (Class53.smethod_18(array3, array4) < 11500L)
							{
								break;
							}
							Class60.smethod_61(gStruct, array4);
							Thread.Sleep(300);
						}
						uint num34 = smethod_2(gStruct);
						if (num34 != 0)
						{
							Class76.Class79.smethod_5(gStruct);
							Class76.smethod_9(gStruct);
							Thread.Sleep(100);
							if (Class39.smethod_9(gStruct))
							{
								Class39.smethod_12(gStruct);
							}
							int num35 = 0;
							bool flag4 = false;
							while (true)
							{
								Class39.smethod_22(gStruct);
								int num36 = num2;
								if (num36 <= 0)
								{
									num36 = num;
								}
								num27 = Class69.smethod_0(gStruct, (uint)num36);
								if (num27 != 0)
								{
									num19 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gStruct.int_130);
									num24 = (uint)((int)num19 + num36 * (int)Class47.gstruct43_103.uint_0);
									num28 = num24 + Class47.gstruct43_104.uint_0;
									Class20.ReadProcessMemory(gStruct.int_130, num28, array2, array2.Length, ref int_2);
									text3 = Class10.smethod_3(array2).ToLower();
									uint num37 = Class20.smethod_30(num24 + Class47.gstruct43_116.uint_0, gStruct.int_130);
									if ((num37 == 0 || num37 >= 100) && (text3.IndexOf(text2.ToLower()) >= 0 || text3.IndexOf(text.ToLower()) >= 0))
									{
										Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num34), 4, ref int_2);
										while (!Class76.smethod_0(gStruct))
										{
											if (Class76.Class79.smethod_4(gStruct))
											{
												Class76.Class79.smethod_5(gStruct);
											}
											num20++;
											Thread.Sleep(100);
											if (num20 <= 10)
											{
												continue;
											}
											goto IL_0a84;
										}
										if (!(flag4 = !flag4))
										{
											Class76.smethod_6(gStruct, 0);
										}
										else
										{
											Class76.smethod_7(gStruct, "Ta");
										}
										for (num20 = 0; num20 < 10; num20++)
										{
											Thread.Sleep(100);
											if (Class39.smethod_9(gStruct))
											{
												num20 = -1;
												break;
											}
										}
										if (num20 != -1)
										{
											string text4 = Class76.smethod_4(gStruct);
											Class76.smethod_9(gStruct);
											if (text4 != string.Empty && 0 < Class11.smethod_2(text4, "cÊp 100 kh«ng"))
											{
												Class60.smethod_50(gStruct, text4);
												flag = true;
												break;
											}
											continue;
										}
										num18 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130) + Class47.gstruct43_94.uint_0;
										num23 = num18 + num27 * 20;
										num25 = Class20.smethod_30(num23 + Class47.gstruct43_97.uint_0 - 4, gStruct.int_130);
										num26 = Class20.smethod_30(num23 + Class47.gstruct43_97.uint_0, gStruct.int_130);
										uint num38 = Class20.smethod_30(num18 + num27 * 20 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
										num20 = 0;
										Class60.smethod_44(gStruct, num25, num26, num38, num25, num26, num38);
										while (true)
										{
											if ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gStruct.int_130) <= 0)
											{
												Thread.Sleep(150);
												num20++;
												if (num20 > 10)
												{
													if (Class39.smethod_9(gStruct))
													{
														Class39.smethod_12(gStruct);
													}
													break;
												}
												continue;
											}
											num20 = 0;
											Class60.smethod_44(gStruct, 0u, 0u, 12u, 0u, 0u, 12u);
											while (true)
											{
												if ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gStruct.int_130) > 0)
												{
													Thread.Sleep(150);
													num20++;
													if (num20 > 10)
													{
														if (Class39.smethod_9(gStruct))
														{
															Class39.smethod_12(gStruct);
														}
														break;
													}
													continue;
												}
												Class39.smethod_14(gStruct, bool_0: true);
												Thread.Sleep(300);
												for (num20 = 0; num20 < 10; num20++)
												{
													int num39 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
													int num40 = (int)Class20.smethod_30(num12 + Class47.gstruct43_43.uint_0, gStruct.int_130);
													if (num39 != num13 || num40 > 0)
													{
														break;
													}
													Thread.Sleep(100);
												}
												break;
											}
											break;
										}
										break;
									}
									num2 = -1;
									break;
								}
								num2 = -1;
								break;
								IL_0a84:
								num35++;
								if (num35 > 3)
								{
									Class53.smethod_10(gStruct);
									break;
								}
							}
						}
						else
						{
							Class53.smethod_10(gStruct);
						}
						break;
					}
					goto IL_1056;
				default:
					{
						num4 = -1;
						int_ = 0;
						array3 = new uint[2]
						{
							Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
							Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
						};
						if (num13 == 195)
						{
							GStruct22 gStruct2 = Class37.smethod_3(195, 175);
							if (gStruct2.uint_0 != null)
							{
								int int_3 = 0;
								int int_4 = 0;
								uint[] uint_ = null;
								uint[] uint_2 = null;
								if (gStruct2.uint_0.GetLength(0) > 1)
								{
									int_3 = Class53.smethod_20(gStruct2.uint_0, array3);
								}
								Class53.smethod_6(gStruct2.uint_0, int_3, ref uint_2, ref uint_, ref int_4);
								long num32 = Class53.smethod_18(array3, uint_2);
								if (num32 < 5000000L)
								{
									Class53.smethod_23(gStruct, uint_2, int_4, uint_, gStruct2.int_1);
									break;
								}
							}
						}
						if (!gStruct.bool_63)
						{
							if (!flag3)
							{
								if (num14 <= 0)
								{
									flag3 = true;
									goto IL_1056;
								}
								if (num7 < 3 && Class53.smethod_13(gStruct))
								{
									num7++;
									Thread.Sleep(300);
									break;
								}
							}
							Class60.smethod_50(gStruct, "Khong co Than Hanh phu, ket thuc !");
							flag = true;
						}
						else if (num6 > 3 && num13 == 336)
						{
							if (num7 < 3 && Class53.smethod_13(gStruct))
							{
								num7++;
								Thread.Sleep(300);
								break;
							}
							GStruct22 gStruct2 = Class37.smethod_3(num13, 121);
							if (gStruct2.uint_0 == null)
							{
								Class60.smethod_50(gStruct, "Khong the qua map Long Mon tran, ket thuc !");
								flag = true;
								break;
							}
							int int_3 = 0;
							int int_4 = 0;
							uint[] uint_ = null;
							uint[] uint_2 = null;
							if (gStruct2.uint_0.GetLength(0) > 1)
							{
								int_3 = Class53.smethod_20(gStruct2.uint_0, array3);
							}
							Class53.smethod_6(gStruct2.uint_0, int_3, ref uint_2, ref uint_, ref int_4);
							Class53.smethod_23(gStruct, uint_2, int_4, uint_, gStruct2.int_1);
						}
						else
						{
							Class31.smethod_61(gStruct, 175);
							Thread.Sleep(600);
							num6++;
							if (num6 > 6)
							{
								Class60.smethod_50(gStruct, "Khong the Than Hanh Phu len Tay Son thon, ket thuc!");
								flag = true;
							}
						}
						break;
					}
					IL_1056:
					while (true)
					{
						if (FormMain.int_98 > 3)
						{
							num8 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
							if (Class11.bool_0 || num8 < 0)
							{
								return;
							}
							gStruct = FormMain.gstruct42_0[num8];
							if (gStruct.bool_36 && gStruct.bool_61 && !flag)
							{
								int num41 = Class69.smethod_28(gStruct, text2);
								if (num41 <= 0)
								{
									if (num3 <= 3)
									{
										if (0 > num4)
										{
											Struct25[] array5 = Class73.smethod_1(gStruct);
											if (array5 == null)
											{
												flag = true;
												break;
											}
											int num42 = -1;
											string value = text2.ToLower();
											while (true)
											{
												num42++;
												if (array5.Length <= num42)
												{
													break;
												}
												Class60.smethod_25(gStruct, array5[num42].string_0);
												Thread.Sleep(300);
												Class60.smethod_26(gStruct);
												GStruct1[] array6 = Class15.smethod_1(gStruct);
												if (array6 == null || array6.Length == 0)
												{
													continue;
												}
												int num43 = 0;
												while (num43 < array6.Length)
												{
													text3 = array6[num43].string_0.ToLower().Trim();
													if (0 != text3.IndexOf(value))
													{
														num43++;
														continue;
													}
													goto IL_0fbd;
												}
												continue;
												IL_0fbd:
												num4 = num43;
												int_ = array5[num42].int_0 - array5[0].int_0;
												break;
											}
										}
										if (num4 >= 0)
										{
											Class46.smethod_0(gStruct);
											int num44 = Class69.smethod_2(gStruct);
											Class60.smethod_27(gStruct, num4, int_);
											int num45 = 0;
											while (num45 < 10)
											{
												num45++;
												Thread.Sleep(150);
												if (Class69.smethod_2(gStruct) != num44)
												{
													break;
												}
												string text5 = Class46.smethod_2(gStruct);
												if (text5.IndexOf("kh«ng ®ñ") > 0)
												{
													num3 = 4;
													break;
												}
											}
											num3++;
											continue;
										}
										flag = true;
										Class60.smethod_50(gStruct, "Khong tim thay Lenh bai Vi son dao trong Ky tran cac, ket thuc !");
										break;
									}
									flag = true;
									Class60.smethod_50(gStruct, "Khong mua duoc lenh bai vi son dao, ket thuc.");
									break;
								}
								num2 = -1;
								break;
							}
							FormMain.gstruct42_0[num8].bool_61 = false;
							return;
						}
						flag = true;
						Class60.smethod_50(gStruct, "Khong co mat do than bi hoac lenh bai vi son dao, ket thuc.");
						break;
					}
					break;
				}
			}
			else
			{
				flag2 = (Class81.smethod_0(gStruct, bool_0: true) <= 0);
			}
			continue;
			IL_0454:
			num2 = (int)num29;
			goto IL_0458;
			IL_044f:
			num = (int)num29;
			goto IL_0458;
			IL_0458:
			if (num2 <= 0)
			{
				continue;
			}
			num27 = Class69.smethod_0(gStruct, (uint)num2);
			num23 = num18 + num27 * 20;
			num25 = Class20.smethod_30(num23 + Class47.gstruct43_97.uint_0 - 4, gStruct.int_130);
			num26 = Class20.smethod_30(num23 + Class47.gstruct43_97.uint_0, gStruct.int_130);
			uint num46 = Class20.smethod_30(num18 + num27 * 20 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
			num20 = 0;
			if (num46 != 3)
			{
				uint[] array7 = Class69.smethod_22(gStruct, 3u);
				if (array7 != null)
				{
					Class60.smethod_44(gStruct, num25, num26, num46, array7[0], array7[1], 3u);
					for (num20 = 0; num20 < 150; num20++)
					{
						Class20.ReadProcessMemory(gStruct.int_130, num18 + num27 * 20 + Class47.gstruct43_97.uint_0 - 8, array, 4, ref int_2);
						if (BitConverter.ToUInt32(array, 0) == 3)
						{
							break;
						}
						Thread.Sleep(10);
					}
				}
				num5++;
			}
			num46 = Class20.smethod_30(num18 + num27 * 20 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
			if (num46 != 3)
			{
				if (num5 < 3)
				{
					Thread.Sleep(150);
					num2 = -1;
				}
				else
				{
					Class60.smethod_50(gStruct, "Khong the chuyen lenh bai vsd ra hanh trang, ket thuc!");
					flag = true;
				}
				continue;
			}
			num25 = Class20.smethod_30(num23 + Class47.gstruct43_97.uint_0 - 4, gStruct.int_130);
			num26 = Class20.smethod_30(num23 + Class47.gstruct43_97.uint_0, gStruct.int_130);
			num20 = 0;
			while (num20 < 50)
			{
				Class20.ReadProcessMemory(gStruct.int_130, gStruct.uint_41 - 4, array, 1, ref int_2);
				if (array[0] == 0)
				{
					break;
				}
				num20++;
				Thread.Sleep(10);
			}
			Class60.smethod_41(gStruct, (uint)num2, (int)num25, (int)num26);
			num20 = 0;
			while (true)
			{
				if (num20 < 150)
				{
					Class20.ReadProcessMemory(gStruct.int_130, num18 + num27 * 20 + Class47.gstruct43_97.uint_0 - 8, array, 4, ref int_2);
					if (BitConverter.ToUInt32(array, 0) != 3)
					{
						break;
					}
					int num47 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
					if (num47 != num13)
					{
						break;
					}
					Thread.Sleep(10);
					num20++;
					continue;
				}
				Thread.Sleep(300);
				break;
			}
		}
		FormMain.gstruct42_0[num8].bool_61 = false;
	}

	private static uint smethod_2(GStruct42 gstruct42_0)
	{
		string text = "T©y s¬n";
		uint[] uint_ = new uint[2]
		{
			54912u,
			99968u
		};
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num4 = num3 + num2 * Class47.gstruct43_15.uint_0;
		Class20.smethod_30(num4 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
		Class20.smethod_30(num4 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
		int num5 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
		if (num5 == 175)
		{
			Class20.smethod_30(num4 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
			uint[] array3 = new uint[2]
			{
				Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num4 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
			uint uint_2 = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, 4, ref int_);
			int num6 = BitConverter.ToInt32(array, 0);
			if (num6 <= 1)
			{
				return 0u;
			}
			int num7 = 0;
			long num8 = 0L;
			uint num9 = 0u;
			uint[] array4 = new uint[2];
			for (uint num10 = 1u; num10 < 256; num10++)
			{
				if (num6 <= num7)
				{
					break;
				}
				uint num11 = num3 + num10 * Class47.gstruct43_15.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num7++;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_52.uint_0, array, 4, ref int_);
				uint num12 = BitConverter.ToUInt32(array, 0);
				if (num12 == 3)
				{
					uint[] array5 = new uint[2];
					Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_);
					array5[0] = BitConverter.ToUInt32(array, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array, 4, ref int_);
					array5[1] = BitConverter.ToUInt32(array, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_16.uint_0, array2, array2.Length, ref int_);
					string text2 = Class10.smethod_3(array2);
					string string_ = text2.ToLower();
					if (0 <= Class11.smethod_2(string_, text.ToLower()))
					{
						return num10;
					}
					long num13 = Class53.smethod_18(uint_, array5);
					if (num13 < 40000L && (num9 == 0 || num13 < num8))
					{
						num8 = num13;
						array4[0] = array5[0];
						array4[1] = array5[1];
						num9 = num10;
					}
				}
			}
			return num9;
		}
		return 0u;
	}
}
