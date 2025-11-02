using System;
using System.Threading;

internal class Class21
{
	public static int int_0 = 0;

	public static int int_1 = Class55.smethod_3("flagNguyenlieuBH", 0, "0");

	public void method_0()
	{
		int num = int_0;
		int_0 = 0;
		bool flag = false;
		bool flag2 = false;
		int int_ = 0;
		string text = "HuyÒn Tinh Kho\u00b8ng Th¹ch".ToLower();
		byte[] array = new byte[text.Length + 3];
		byte[] array2 = new byte[4];
		GStruct42 gstruct42_ = default(GStruct42);
		int num2 = 0;
		int num3;
		while (true)
		{
			Thread.Sleep(300);
			num3 = Class71.smethod_3(FormMain.gstruct42_0, num);
			if (Class11.bool_0 || num3 < 0 || !FormMain.gstruct42_0[num3].bool_36 || FormMain.gstruct42_0[num3].byte_0[0] == 0)
			{
				break;
			}
			gstruct42_ = FormMain.gstruct42_0[num3];
			uint num4 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
			uint num5 = Class20.smethod_30(num4 + Class47.gstruct43_13.uint_0, gstruct42_.int_130);
			uint num6 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
			uint num7 = num6 + num5 * Class47.gstruct43_15.uint_0;
			int num8 = (int)Class20.smethod_30(num7 + Class47.gstruct43_55.uint_0, gstruct42_.int_130);
			int num9 = (int)Class20.smethod_30(num7 + Class47.gstruct43_50.uint_0, gstruct42_.int_130);
			int num10 = Class73.smethod_40(gstruct42_);
			if (num8 == 10 || num8 == 21 || num9 == 0 || num10 <= 1)
			{
				continue;
			}
			uint num11 = num4 + Class47.gstruct43_12.uint_0 + Class47.gstruct43_75.uint_0;
			if (!flag)
			{
				num3 = Class71.smethod_3(FormMain.gstruct42_0, num);
				if (0 <= num3)
				{
					FormMain.gstruct42_0[num3].bool_21 = true;
				}
				if (gstruct42_.string_13 != null && gstruct42_.string_13 != string.Empty)
				{
					uint num12 = Class11.smethod_13(gstruct42_.string_13);
					if (num12 != 0)
					{
						Class60.smethod_113(gstruct42_, num12);
						Thread.Sleep(100);
					}
					Thread.Sleep(350);
				}
				long num13 = Class20.smethod_30(num11 + Class47.gstruct43_74.uint_0, gstruct42_.int_130);
				if (num13 > 0L)
				{
					Class60.smethod_35(gstruct42_, (uint)num13);
				}
				flag = true;
				Class60.smethod_50(gstruct42_, "<color=yellow>Bat dau nang cap Huyen tinh...");
			}
			uint num14 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_.int_130);
			int num15 = -1;
			for (int i = 1; i < 10; i++)
			{
				if (gstruct42_.byte_0[i] > 0)
				{
					num15 = i;
					break;
				}
			}
			if (num15 < 0)
			{
				break;
			}
			if (!flag2)
			{
				Class60.smethod_50(gstruct42_, Class10.smethod_2("<color=yellow>Nâng cấp huyền tinh " + num15 + " -> " + (num15 + 1)));
				flag2 = true;
			}
			int num16 = 0;
			uint[] array3 = new uint[3];
			uint[] array4 = array3;
			int num17 = Class69.smethod_2(gstruct42_);
			int num18 = 0;
			uint num19 = 1u;
			while (true)
			{
				if (num19 < Class47.int_1 && (0 >= num17 || num17 > num18))
				{
					if (num19 % 30u == 0)
					{
						Thread.Sleep(100);
					}
					uint num20 = num14 + num19 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_.int_130, num20 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_);
					if (BitConverter.ToInt32(array2, 0) == 0)
					{
						uint num21 = Class69.smethod_0(gstruct42_, num19);
						if (num21 != 0)
						{
							num18++;
							Class20.ReadProcessMemory(gstruct42_.int_130, num20 + Class47.gstruct43_105.uint_0, array, 1, ref int_);
							if (array[0] == 6)
							{
								Class20.ReadProcessMemory(gstruct42_.int_130, num20 + Class47.gstruct43_108.uint_0, array, 1, ref int_);
								int num22 = array[0];
								Class20.ReadProcessMemory(gstruct42_.int_130, num20 + Class47.gstruct43_109.uint_0, array, 1, ref int_);
								int num23 = array[0];
								if (num22 == 1 && num23 == 1)
								{
									int num24 = (int)Class20.smethod_30(num20 + Class47.gstruct43_116.uint_0, gstruct42_.int_130);
									if (num24 > 0)
									{
										Class20.ReadProcessMemory(gstruct42_.int_130, num20 + Class47.gstruct43_111.uint_0, array, 1, ref int_);
										if (array[0] == num15 && Class20.ReadProcessMemory(gstruct42_.int_130, num20 + Class47.gstruct43_104.uint_0, array, 1, ref int_) && array[0] != 0)
										{
											Class20.ReadProcessMemory(gstruct42_.int_130, num20 + Class47.gstruct43_104.uint_0, array, array.Length, ref int_);
											string string_ = Class10.smethod_3(array).ToLower();
											if (Class11.smethod_2(string_, text) >= 0)
											{
												uint num25 = Class69.smethod_3(gstruct42_, num21);
												if (num25 == 1 || num25 == 3)
												{
													if (num24 != 1)
													{
														uint[] array5 = Class69.smethod_22(gstruct42_, 3u);
														if (array5 != null)
														{
															if (num25 != 1)
															{
																int num26 = 0;
																while (!Class11.bool_0 && Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_.int_130) == 0)
																{
																	if (num26 % 20 == 0)
																	{
																		Class60.smethod_71(gstruct42_, num19, 1u, 89);
																	}
																	if (num26 > 1500)
																	{
																		Class60.smethod_50(gstruct42_, Class10.smethod_2("Không thể tách vật phẩm !"));
																		if (Class39.smethod_9(gstruct42_))
																		{
																			Class39.smethod_12(gstruct42_);
																		}
																		Thread.Sleep(300);
																		num26 = 0;
																	}
																	Thread.Sleep(10);
																	num26++;
																}
															}
															int num27 = 0;
															while (!Class11.bool_0 && (int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_.int_130) > 0)
															{
																if (num27 % 20 == 0)
																{
																	Class60.smethod_44(gstruct42_, array5[0], array5[1], 3u, array5[0], array5[1], 3u);
																}
																if (num27 > 1500)
																{
																	Class60.smethod_50(gstruct42_, Class10.smethod_2("Không thể đặt vật phẩm xuống !"));
																	if (Class39.smethod_9(gstruct42_))
																	{
																		Class39.smethod_12(gstruct42_);
																	}
																	Thread.Sleep(300);
																	num27 = 0;
																}
																Thread.Sleep(10);
																num27++;
															}
															break;
														}
													}
													else
													{
														bool flag3 = false;
														for (int j = 0; j < array4.Length; j++)
														{
															if (array4[j] == num19)
															{
																flag3 = true;
																break;
															}
														}
														if (!flag3)
														{
															array4[num16] = num19;
															num16++;
															if (num16 > 2)
															{
																num2++;
																Class60.smethod_69(gstruct42_, array4[0], array4[1], array4[2]);
																if (num2 < 5)
																{
																	break;
																}
																num2 = 0;
																string string_2 = Class73.smethod_20(gstruct42_);
																if (Class11.smethod_3(string_2, "phi ph"))
																{
																	Class73.smethod_21(gstruct42_, "_open");
																	if (Class60.smethod_64(gstruct42_))
																	{
																		Thread.Sleep(800);
																		Class39.smethod_12(gstruct42_);
																	}
																}
																break;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					num19++;
					continue;
				}
				num3 = Class71.smethod_3(FormMain.gstruct42_0, num);
				if (0 <= num3)
				{
					FormMain.gstruct42_0[num3].byte_0[num15] = 0;
					flag2 = false;
				}
				break;
			}
		}
		Class60.smethod_50(gstruct42_, "<color=yellow>Ket thuc nang cap Huyen tinh !");
		num3 = Class71.smethod_3(FormMain.gstruct42_0, num);
		if (0 <= num3)
		{
			if (Class39.smethod_9(gstruct42_))
			{
				Class39.smethod_12(gstruct42_);
			}
			FormMain.gstruct42_0[num3].byte_0 = new byte[11];
			FormMain.gstruct42_0[num3].byte_0[10] = 1;
			FormMain.gstruct42_0[num3].bool_21 = false;
		}
	}

	public void method_1()
	{
		int num = int_0;
		int_0 = 0;
		bool flag = false;
		bool flag2 = false;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = -1;
		int int_ = 0;
		long long_ = 0L;
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		GStruct42 gstruct42_ = default(GStruct42);
		while (true)
		{
			num2--;
			Thread.Sleep(200);
			if (num2 <= 0)
			{
				num3 = Class71.smethod_3(FormMain.gstruct42_0, num);
				if (Class11.bool_0 || num3 < 0)
				{
					break;
				}
				gstruct42_ = FormMain.gstruct42_0[num3];
				if (!gstruct42_.bool_36 || (num5 != -1 && num5 != gstruct42_.int_27))
				{
					break;
				}
				if (flag)
				{
					if (!gstruct42_.bool_10)
					{
						break;
					}
				}
				else
				{
					FormMain.gstruct42_0[num3].bool_10 = true;
					num5 = gstruct42_.int_27;
					Class60.smethod_50(gstruct42_, Class10.smethod_2("<color=yellow>Bắt đầu chế tạo Huyền tinh..."));
					flag = true;
				}
				int_ = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_.int_130);
				num2 = 10;
			}
			uint num9 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
			uint num10 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_.int_130);
			uint[] array = new uint[3];
			byte[] array2 = new byte[4];
			int int_2 = 0;
			int num11 = Class69.smethod_2(gstruct42_);
			int num12 = 0;
			uint num13 = 1u;
			while (num13 < Class47.int_1)
			{
				if (array[0] == 0 || array[1] == 0 || array[2] == 0)
				{
					if (0 < num11 && num11 <= num12)
					{
						break;
					}
					uint num14 = num10 + num13 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_.int_130, num14 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_2);
					if (BitConverter.ToInt32(array2, 0) == 0)
					{
						uint uint_ = num14 + Class47.gstruct43_104.uint_0;
						Class20.ReadProcessMemory(gstruct42_.int_130, uint_, array2, 1, ref int_2);
						if (array2[0] != 0)
						{
							uint num15 = Class69.smethod_0(gstruct42_, num13);
							if (num15 != 0)
							{
								num12++;
								if (Class20.smethod_30(num14 + Class47.gstruct43_105.uint_0, gstruct42_.int_130) == 0)
								{
									uint num16 = Class20.smethod_30(num14 + Class47.gstruct43_107.uint_0, gstruct42_.int_130);
									if ((array[0] == 0 && num16 == 3) || (array[1] == 0 && num16 == 9) || (array[2] == 0 && num16 == 4))
									{
										uint num17 = num9 + Class47.gstruct43_94.uint_0 + num15 * 20;
										uint num18 = Class20.smethod_30(num17 + Class47.gstruct43_97.uint_0 - 8, gstruct42_.int_130);
										if (num18 == 3 || (num18 == 23 && int_1 > 0))
										{
											switch (num16)
											{
											case 3u:
												array[0] = num13;
												break;
											case 4u:
												array[2] = num13;
												break;
											default:
												array[1] = num13;
												break;
											}
										}
									}
								}
							}
						}
					}
					num13++;
					continue;
				}
				goto IL_02fd;
			}
			break;
			IL_02fd:
			if (num6 == array[0] && num7 == array[1] && num8 == array[2])
			{
				num4++;
				string string_ = Class73.smethod_20(gstruct42_);
				if (Class11.smethod_3(string_, "phi ph"))
				{
					Class73.smethod_21(gstruct42_, "0K..");
					flag2 = Class60.smethod_64(gstruct42_);
					Thread.Sleep(300);
				}
				else if (!Class29.smethod_0(int_) && Class11.smethod_23(long_) > 600L)
				{
					bool flag3;
					if (flag3 = (Class11.smethod_3(string_, "kh«ng ") && (Class11.smethod_3(string_, "TiÒn") || Class11.smethod_3(string_, "l­îng"))))
					{
						Class73.smethod_21(gstruct42_, "0K..");
					}
					else
					{
						flag3 = (Class32.smethod_42(gstruct42_) < 1000);
					}
					if (flag3)
					{
						if (!Class53.smethod_13(gstruct42_) && gstruct42_.bool_63)
						{
							Class31.smethod_61(gstruct42_, 37, "®«ng|§«ng");
						}
						Thread.Sleep(300);
					}
					long_ = Class11.smethod_22();
				}
				if (num4 > 12)
				{
					Class73.smethod_31(gstruct42_, "Khong the che tao Huyen tinh");
					break;
				}
			}
			else
			{
				num6 = array[0];
				num7 = array[1];
				num8 = array[2];
				num4 = 0;
			}
			Class60.smethod_67(gstruct42_, array[0], array[1], array[2]);
		}
		num3 = Class71.smethod_3(FormMain.gstruct42_0, num);
		if (0 <= num3)
		{
			FormMain.gstruct42_0[num3].bool_10 = false;
			if (flag2)
			{
				Class39.smethod_12(gstruct42_);
			}
			Class60.smethod_50(gstruct42_, Class10.smethod_2("<color=yellow>Kết thúc chế tạo !"));
		}
	}
}
