using System;
using System.Threading;

internal class Class17
{
	private static uint[,] uint_0 = new uint[8, 2]
	{
		{
			49215u,
			101034u
		},
		{
			50458u,
			98768u
		},
		{
			48514u,
			95934u
		},
		{
			46589u,
			94046u
		},
		{
			44444u,
			96018u
		},
		{
			42811u,
			98112u
		},
		{
			44459u,
			99942u
		},
		{
			46317u,
			98066u
		}
	};

	public static int smethod_0(GStruct42 gstruct42_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		while (true)
		{
			Thread.Sleep(300);
			if (Class11.bool_0)
			{
				break;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
			uint num4 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_13.uint_0, array, 4, ref int_);
			uint num5 = BitConverter.ToUInt32(array, 0);
			uint num6 = num5 * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array, 0);
			uint num8 = num7 + num6;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_55.uint_0, array, 4, ref int_);
			int num9 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
			int num10 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_);
			int num11 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
			BitConverter.ToInt32(array, 0);
			int num12 = Class73.smethod_40(gstruct42_0);
			if (num10 != 0 && num9 != 0 && num11 != 0 && num12 > 1)
			{
				num = 0;
				if (num11 != FormMain.int_26)
				{
					return 1;
				}
				uint[] uint_ = new uint[2]
				{
					Class20.smethod_30(num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				int num13 = Class53.smethod_20(uint_0, uint_);
				if (num13 < 0)
				{
					return 0;
				}
				uint[] array2 = new uint[2]
				{
					uint_0[num13, 0],
					uint_0[num13, 1]
				};
				long num14 = Class53.smethod_18(uint_, array2);
				if (num14 > 300000L)
				{
					if (Class11.smethod_23(num3) <= 6000L)
					{
						continue;
					}
					if (num3 <= 0L)
					{
						if (gstruct42_0.bool_64)
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_44.uint_0, array, 4, ref int_);
							if (array[0] <= 0)
							{
								Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
							}
						}
						Class12.smethod_1(gstruct42_0, array2);
						num3 = Class11.smethod_22();
						continue;
					}
					return 2;
				}
				Class12.smethod_3(gstruct42_0, bool_0: false);
				if (num14 <= 22500L)
				{
					if (num14 > 7500L)
					{
						Class60.smethod_61(gstruct42_0, array2);
						Thread.Sleep(450);
					}
					int num15 = Class86.smethod_12(gstruct42_0, "truyÒn tèng", 3);
					if (num15 <= 0)
					{
						return -1;
					}
					bool flag = false;
					while (true)
					{
						int int_2 = 0;
						byte[] bytes = BitConverter.GetBytes(num15);
						Class20.WriteProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_72.uint_0, bytes, 4, ref int_2);
						Thread.Sleep(300);
						for (int i = 0; i < 10; i++)
						{
							Thread.Sleep(150);
							if (Class76.smethod_0(gstruct42_0) && Class76.smethod_2(gstruct42_0) > 0)
							{
								Class60.smethod_57(gstruct42_0, 0, 0);
								return 1;
							}
						}
						if (flag)
						{
							break;
						}
						flag = true;
					}
					return -2;
				}
				if (num2 >= 10)
				{
					return 3;
				}
				num2++;
				Class60.smethod_61(gstruct42_0, array2);
			}
			else
			{
				num++;
				if (num >= 6)
				{
					return 0;
				}
			}
		}
		return 0;
	}

	public static void smethod_1(int int_0)
	{
		GStruct42 gStruct = default(GStruct42);
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		bool bool_ = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		long long_4 = 0L;
		new Random();
		uint[] array = null;
		uint num4 = 0u;
		uint uint_ = 0u;
		int num5 = 0;
		int num6 = 0;
		int int_ = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int int_2 = 0;
		long num10 = 0L;
		long num11 = 0L;
		long long_5 = 0L;
		int int_3 = 0;
		int int_4 = 0;
		bool flag5 = false;
		uint[] array2 = null;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		int num15 = 0;
		int num16 = 0;
		int int_5 = -1;
		int[] array3 = new int[4];
		int int_6 = 0;
		byte[] byte_ = new byte[4];
		byte[] array4 = new byte[4];
		bool flag6 = false;
		bool flag7 = false;
		while (true)
		{
			Thread.Sleep(200);
			num12 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (Class11.bool_0 || num12 < 0 || FormMain.int_20 != 2 || FormMain.int_24 != 2)
			{
				break;
			}
			gStruct = FormMain.gstruct42_0[num12];
			if (!gStruct.bool_36 || gStruct.bool_60 || gStruct.int_26 > 0 || gStruct.int_126[0] > 0 || gStruct.int_21[0] > 0)
			{
				break;
			}
			if (gStruct.bool_27)
			{
				FormMain.gstruct42_0[num12].bool_27 = false;
				flag3 = false;
			}
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array4, 4, ref int_6);
			uint num17 = BitConverter.ToUInt32(array4, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_13.uint_0, array4, 4, ref int_6);
			uint num18 = BitConverter.ToUInt32(array4, 0);
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array4, 4, ref int_6);
			uint num19 = BitConverter.ToUInt32(array4, 0);
			uint num20 = num18 * Class47.gstruct43_15.uint_0;
			uint num21 = num19 + num20;
			Class20.ReadProcessMemory(gStruct.int_130, num21, array4, 4, ref int_6);
			num4 = BitConverter.ToUInt32(array4, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_55.uint_0, array4, 4, ref int_6);
			int num22 = BitConverter.ToInt32(array4, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_50.uint_0, array4, 4, ref int_6);
			int num23 = BitConverter.ToInt32(array4, 0);
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array4, 4, ref int_6);
			int num24 = BitConverter.ToInt32(array4, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_43.uint_0, array4, 4, ref int_6);
			int num25 = BitConverter.ToInt32(array4, 0);
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
						Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
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
				array3[0] = 0;
				array3[1] = 0;
				array3[2] = 0;
				array3[3] = 0;
			}
			num15 = 0;
			num16 = 0;
			int num27 = Class73.smethod_40(gStruct);
			uint[] array6;
			int num30;
			int num32;
			int num33;
			bool flag8;
			bool flag11;
			bool flag9;
			long num36;
			uint[] array5;
			int num31;
			bool flag10;
			if (num23 != 0 && num22 != 0 && num24 != 0 && num22 != 10 && num22 != 21 && num27 > 1)
			{
				if (!flag6)
				{
					array5 = new uint[2]
					{
						Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
						Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
					};
					if (array5[0] == 0 || array5[1] == 0)
					{
						continue;
					}
					array6 = new uint[2];
					if (num2 != num24)
					{
						flag3 = false;
						bool_ = false;
						array = null;
						int_ = 0;
						int num28 = 0;
						while (num2 != num24)
						{
							int num29 = Class73.smethod_40(gStruct);
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array4, 4, ref int_6);
							num17 = BitConverter.ToUInt32(array4, 0);
							Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_13.uint_0, array4, 4, ref int_6);
							num18 = BitConverter.ToUInt32(array4, 0);
							num20 = num18 * Class47.gstruct43_15.uint_0;
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array4, 4, ref int_6);
							num19 = BitConverter.ToUInt32(array4, 0);
							num21 = num19 + num20;
							Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_50.uint_0, array4, 4, ref int_6);
							num23 = BitConverter.ToInt32(array4, 0);
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array4, 4, ref int_6);
							num24 = BitConverter.ToInt32(array4, 0);
							Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_43.uint_0, array4, 4, ref int_6);
							num25 = BitConverter.ToInt32(array4, 0);
							Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
							num14 = 0;
							if (num25 > 0 || num28 > 8 || (num29 != 0 && num29 != 1 && num23 > 0 && num24 > 0))
							{
								break;
							}
							num28++;
							Thread.Sleep(100);
						}
						num2 = num24;
						continue;
					}
					if (num3 == num25)
					{
						num30 = 600;
						if (gStruct.int_94 > 0)
						{
							num30 = gStruct.int_95;
						}
						num31 = gStruct.int_128;
						if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
						{
							num31 = gStruct.int_93;
						}
						if (num31 <= 0)
						{
							num31 = 500;
						}
						num13 = FormMain.int_23;
						if (gStruct.int_129 != Class38.gstruct29_0.int_0)
						{
							if (num31 <= 180 && num13 < FormMain.int_51)
							{
								num13 = FormMain.int_51;
							}
							if (gStruct.int_123[0] > 0 && FormMain.int_27 > 0 && num13 > 180)
							{
								num13 = 180;
							}
						}
						array2 = array5;
						flag5 = false;
						num32 = 0;
						num33 = 0;
						flag8 = false;
						flag9 = false;
						if (num24 != FormMain.int_26)
						{
							if (FormMain.int_106 > 0 && Class38.gstruct29_0.int_0 == gStruct.int_129)
							{
								if (Class11.smethod_23(long_5) > 30000L)
								{
									Class60.smethod_50(gStruct, "<color=yellow>Dang o che do ac chinh nguoi dung Tu dieu khien...");
									long_5 = Class11.smethod_22();
								}
								continue;
							}
							int[] array7 = Class53.smethod_7(num24);
							if (array7 == null)
							{
								flag3 = false;
								if (Class50.smethod_1(num24) != null)
								{
									Class44.smethod_5(gStruct, 11);
									flag7 = true;
									continue;
								}
								if (Class50.smethod_0(num24) != null || 0 <= Class50.smethod_2(num24))
								{
									continue;
								}
								if (gStruct.bool_63 && num5 < 6)
								{
									Class31.smethod_61(gStruct, 11, "®«ng|§«ng");
									num5++;
									continue;
								}
								if (num25 > 0 && num6 < 6)
								{
									Class53.smethod_13(gStruct);
									num6++;
									if (num6 > 3)
									{
										num5 = 0;
									}
									continue;
								}
							}
							if (array7 != null && array7[1] == 0)
							{
								int num34 = Class69.smethod_2(gStruct);
								if (flag3 && num >= 0 && num == num34)
								{
									if (flag7 && num25 == 0)
									{
										flag7 = (Class81.smethod_0(gStruct, bool_0: true) < 0);
									}
									else
									{
										Class44.smethod_2(gStruct, "Tam M«n §µi");
									}
									continue;
								}
								if (!FormMain.bool_3)
								{
									if (Class35.smethod_0(gStruct) == 0)
									{
										Thread.Sleep(300);
										continue;
									}
									int num35 = Class30.smethod_1(gStruct, FormMain.int_92 <= 0);
									if (num35 == 0 || (num35 < 0 && !flag4))
									{
										Thread.Sleep(300);
										flag4 = (num35 < 0);
										continue;
									}
								}
								flag3 = true;
								flag4 = false;
								num = Class69.smethod_2(gStruct);
								if (gStruct.int_66 > 0)
								{
									Class53.smethod_1(gStruct, ref bool_);
								}
							}
							else
							{
								Class44.smethod_5(gStruct, 11);
								flag7 = true;
							}
							continue;
						}
						flag3 = false;
						flag3 = false;
						flag10 = false;
						if (Class20.smethod_30(num21 + Class47.gstruct43_43.uint_0, gStruct.int_130) == 0)
						{
							continue;
						}
						flag11 = ((FormMain.int_6 > 0 || FormMain.int_7 > 0) && FormMain.int_21 > 0 && (Class38.gstruct29_1.int_3 > 0 || FormMain.int_22 > 0) && Class38.gstruct29_1.int_4 > 0 && Class11.smethod_57(Class38.gstruct29_1.uint_4) && (gStruct.int_129 == Class38.gstruct29_0.int_0 || Class38.gstruct29_0.int_0 <= 0));
						flag = (FormMain.int_21 > 0 && Class38.gstruct29_0.int_0 > 0 && Class38.gstruct29_0.int_0 != gStruct.int_129 && Class38.gstruct29_0.int_6 > 0 && Class38.gstruct29_0.int_4 == num24 && Class11.smethod_57(Class38.gstruct29_0.uint_4) && Class38.gstruct29_0.int_3 > 0);
						flag9 = (!gStruct.bool_33 && (FormMain.int_31 > 0 || FormMain.int_30 > 0));
						array5 = new uint[2]
						{
							Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
							Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
						};
						if (flag && gStruct.int_129 != Class38.gstruct29_0.int_0)
						{
							array5 = new uint[2]
							{
								Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
								Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
							};
							num36 = Class53.smethod_18(array5, Class38.gstruct29_0.uint_4);
							if (flag2 || num36 > num13 * num13)
							{
								goto IL_0d76;
							}
							Class12.smethod_3(gStruct, bool_0: false);
							int num37 = num7;
							num7 = 0;
							int_ = 0;
							if (num25 > 0 && !gStruct.bool_33 && gStruct.bool_64 && gStruct.int_90 == 1 && FormMain.int_96 > 0 && (FormMain.int_31 > 0 || FormMain.int_30 > 0 || FormMain.int_32 > 0) && Class20.smethod_30(num21 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0 && Class20.smethod_30(num21 + Class47.gstruct43_43.uint_0, gStruct.int_130) != 0 && Class11.smethod_23(long_3) > 600L)
							{
								Class60.smethod_55(gStruct, "Switch([[horse]])");
								long_3 = Class11.smethod_22();
							}
							if (num11 <= 0L || Class11.smethod_23(num11) >= 1500L)
							{
								uint[] array8 = new uint[2]
								{
									array5[0],
									array5[1]
								};
								if (Class38.smethod_4(num4, ref array5, ref uint_) > 0)
								{
									long num38 = Class53.smethod_18(array8, Class38.gstruct29_0.uint_4);
									long num39 = Class53.smethod_18(array5, Class38.gstruct29_0.uint_4);
									if (num39 <= num13 * num13)
									{
										num11 = Class11.smethod_22();
										if (num14 > 0)
										{
											Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
										}
										num14 = 0;
										Class38.smethod_5(gStruct, array5, Class38.gstruct29_0.uint_4, num38 <= 5625L);
										goto IL_2722;
									}
									if (num37 > 0)
									{
										uint[] uint_2 = Class53.smethod_3(array5, Class38.gstruct29_0.uint_4, -100);
										Class60.smethod_61(gStruct, uint_2);
										Thread.Sleep(120);
									}
									goto IL_0d76;
								}
								num11 = 0L;
								if (num14 == 0 && Class53.smethod_18(array8, Class38.gstruct29_0.uint_4) > FormMain.int_23 * FormMain.int_23)
								{
									num8++;
									if (num8 > 3)
									{
										Class60.smethod_61(gStruct, Class38.gstruct29_0.uint_4);
										Thread.Sleep(150);
										num8 = 0;
									}
								}
								if (FormMain.int_27 > 0 && num25 > 0 && gStruct.int_123[0] > 0 && Class60.smethod_3(gStruct, Class60.uint_13) == 0)
								{
									Class60.smethod_2(gStruct, Class60.uint_13, 1, 4);
								}
							}
							int_ = 0;
							array = null;
							array2 = Class38.gstruct29_0.uint_4;
							flag5 = true;
						}
						else
						{
							if (gStruct.int_68 != null && gStruct.int_68[0] > 0 && !FormMayphu.bool_3)
							{
								uint[] array9 = null;
								if (num10 <= 0L || Class11.smethod_23(num10) >= 1000L)
								{
									array9 = Class53.smethod_26(gStruct, ref int_2);
									if (array9 != null)
									{
										num10 = 0L;
										long num40 = Class53.smethod_18(array5, array9);
										if (num40 < 8000L)
										{
											goto IL_11ce;
										}
										if (num40 >= 15000L && num40 >= gStruct.int_68[1] * gStruct.int_68[1])
										{
											if (num40 < 360000L)
											{
												Class12.smethod_3(gStruct, bool_0: false);
												if (num14 > 0)
												{
													Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
												}
												num14 = 0;
												Class60.smethod_61(gStruct, array9);
												Thread.Sleep(150);
												continue;
											}
											if (num40 < 1200000L)
											{
												if (Class11.smethod_23(long_) > 3000L)
												{
													Class12.smethod_1(gStruct, array9);
													long_ = Class11.smethod_22();
												}
												continue;
											}
										}
										else
										{
											if (num22 <= 3 && num40 > 7500L)
											{
												if (num14 > 0)
												{
													Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
												}
												num14 = 0;
												Class60.smethod_61(gStruct, array9);
												Thread.Sleep(150);
												goto IL_2722;
											}
											num40 = 4L;
										}
									}
									else
									{
										num10 = Class11.smethod_22();
									}
								}
							}
							if (flag11)
							{
								int num35 = FormMayphu.smethod_7(gStruct, ref long_, ref int_, ref array);
								if (num35 <= 0)
								{
									Thread.Sleep(100);
									continue;
								}
								num22 = (int)Class20.smethod_30(num21 + Class47.gstruct43_55.uint_0, gStruct.int_130);
								if (num22 < 3)
								{
									array5 = new uint[2]
									{
										Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
										Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
									};
									if (Class53.smethod_18(array5, Class38.gstruct29_1.uint_4) > 5625L)
									{
										if (num14 > 0)
										{
											Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
										}
										num14 = 0;
										Class60.smethod_61(gStruct, Class38.gstruct29_1.uint_4);
										Thread.Sleep(150);
									}
								}
							}
						}
						goto IL_11ce;
					}
					array = null;
					int_ = 0;
					int num41 = 0;
					while (num25 == 0 && num41 < 30 && num25 != num3)
					{
						Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array4, 4, ref int_6);
						num17 = BitConverter.ToUInt32(array4, 0);
						Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_13.uint_0, array4, 4, ref int_6);
						num18 = BitConverter.ToUInt32(array4, 0);
						num20 = num18 * Class47.gstruct43_15.uint_0;
						Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array4, 4, ref int_6);
						num19 = BitConverter.ToUInt32(array4, 0);
						num21 = num19 + num20;
						Class20.ReadProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_43.uint_0, array4, 4, ref int_6);
						num25 = BitConverter.ToInt32(array4, 0);
						Thread.Sleep(10);
						num41++;
					}
					num3 = num25;
					Thread.Sleep(100);
					Class76.smethod_9(gStruct);
					continue;
				}
				flag6 = false;
				Thread.Sleep(300);
				continue;
			}
			if (num27 <= 1)
			{
				bool_ = false;
			}
			flag6 = (num22 == 10 || num22 == 21);
			Thread.Sleep(60);
			continue;
			IL_11ce:
			if (gStruct.int_97[0] > 0 && gStruct.int_97[1] > 0 && gStruct.string_21 == "NGAMY")
			{
				long num42 = Class11.smethod_23(long_2);
				if (num42 < 300L)
				{
					continue;
				}
				if (num42 > gStruct.int_97[4] && Class7.smethod_3(gStruct))
				{
					Thread.Sleep(80);
					long_2 = Class11.smethod_22();
					continue;
				}
			}
			int num43;
			if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
			{
				if (gStruct.bool_33)
				{
					if (gStruct.int_129 != Class38.gstruct29_0.int_0)
					{
						Class6.smethod_2(gStruct, num21, ref long_3, bool_0: true);
					}
				}
				else
				{
					bool flag12 = gStruct.int_122[0] > 0 && gStruct.int_122[1] > 0 && gStruct.int_122[2] > 0;
					bool flag13 = gStruct.int_122[0] > 0 && gStruct.int_122[3] > 0 && gStruct.int_122[4] > 0;
					bool flag14 = gStruct.int_122[0] > 0 && gStruct.int_122[5] > 0 && gStruct.int_122[6] > 0;
					flag8 = ((flag12 || flag13 || flag14) && gStruct.string_21 == "DUONGMON");
					if (FormDame.int_6 <= 0 || flag8)
					{
						goto IL_1780;
					}
					if (flag9 || FormDame.int_7 > 0)
					{
						num43 = 0;
						if (FormDame.int_5 == 0)
						{
							goto IL_1421;
						}
						bool flag15 = Class38.gstruct29_0.int_8 == 1 || (flag11 && Class38.gstruct29_1.int_8 == 1);
						if (FormDame.int_5 != 1)
						{
							if (FormDame.int_5 != 2 || flag15)
							{
								goto IL_1419;
							}
							if (num14 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
							}
							num14 = 0;
						}
						else
						{
							if (flag15)
							{
								goto IL_1421;
							}
							if (FormDame.int_8 > 0)
							{
								goto IL_1419;
							}
							if (num14 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
							}
							num14 = 0;
						}
					}
				}
			}
			goto IL_2722;
			IL_1421:
			uint num44 = 0u;
			uint[] array10 = null;
			uint[] array11 = null;
			if (!flag11)
			{
				if (gStruct.int_129 != Class38.gstruct29_0.int_0 && gStruct.int_129 != Class66.gstruct42_0.int_129 && Class38.gstruct29_0.uint_5 != 0)
				{
					uint num45 = Class38.gstruct29_0.uint_5 >> 16;
					uint int_7 = Class38.gstruct29_0.uint_5 - (num45 << 16);
					array10 = Class73.smethod_11(Class38.gstruct29_0.uint_4, (int)int_7, (int)num45);
					uint[] array12 = Class73.smethod_10(array5, array10);
					num44 = (array12[1] << 16) + array12[0];
					array11 = Class38.gstruct29_0.uint_4;
					Class73.smethod_7(gStruct, num44);
				}
			}
			else
			{
				uint num45 = Class38.gstruct29_1.uint_5 >> 16;
				uint int_7 = Class38.gstruct29_1.uint_5 - (num45 << 16);
				array10 = Class73.smethod_11(Class38.gstruct29_1.uint_4, (int)int_7, (int)num45);
				uint[] array12 = Class73.smethod_10(array5, array10);
				num44 = (array12[1] << 16) + array12[0];
				array11 = Class38.gstruct29_1.uint_4;
				Class73.smethod_7(gStruct, num44);
			}
			flag10 = (Class20.smethod_30(num21 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
			Class53.smethod_30(gStruct, flag10, ref long_3);
			if (gStruct.int_121[0] > 0)
			{
				bool flag16 = gStruct.int_121[1] > 0 && gStruct.int_121[2] > 0;
				bool flag17 = gStruct.int_121[3] > 0 && gStruct.int_121[4] > 0;
				if (flag16 && !flag17)
				{
					num43 = gStruct.int_121[2];
				}
				else if (flag17 && !flag16)
				{
					num43 = gStruct.int_121[4];
				}
				else if (flag16 && flag17)
				{
					num43 = ((0 > num9 || num9 > 25) ? gStruct.int_121[4] : gStruct.int_121[2]);
					if (num9 > 35)
					{
						num9 = 0;
					}
					num9++;
				}
			}
			if (num43 <= 0)
			{
				num43 = Class32.smethod_32(gStruct);
			}
			if (gStruct.int_129 != Class38.gstruct29_0.int_0 || FormMain.int_6 > 0 || FormMain.int_7 > 0)
			{
				Class67.smethod_7(gStruct);
			}
			Class67.smethod_3(gStruct, num43, 6, 1);
			for (int i = 0; i < 3; i++)
			{
				Class20.smethod_75(gStruct.uint_4, 117);
				if (i < 2)
				{
					Thread.Sleep(60);
				}
			}
			if (num44 != 0 && gStruct.int_129 != Class66.gstruct42_0.int_129)
			{
				if (gStruct.int_92 <= 0)
				{
					Class20.smethod_30(num21 + Class47.gstruct43_31.uint_0, gStruct.int_130);
					int num46 = Class32.smethod_32(gStruct);
					if (num46 == 53 || num46 <= 1)
					{
						goto IL_2722;
					}
					if (num46 <= 100)
					{
						num46 = 400;
					}
				}
				string string_ = Class73.smethod_20(gStruct);
				if (Class11.smethod_3(string_, "iÓm qu\u00b8 x"))
				{
					uint[] array13 = Class53.smethod_3(array11, array10, -1 * (FormMain.int_23 - 50));
					long num47 = Class53.smethod_18(array5, array13);
					if (num47 > 7000L)
					{
						Class60.smethod_61(gStruct, array13);
						Thread.Sleep(150);
						Class73.smethod_21(gStruct, "0K..");
					}
				}
			}
			goto IL_2722;
			IL_2722:
			if (!flag9 && gStruct.int_129 != Class38.gstruct29_0.int_0 && Class32.smethod_59(gStruct, new int[2]
			{
				0,
				1
			}) != 0)
			{
				if (num14 > 0)
				{
					Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
				}
				num14 = 0;
			}
			if (flag8 && num33 <= 0)
			{
				FormDuongMon.smethod_0(gStruct, ref int_3, array2, ref int_4, flag5);
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
					if (Class11.smethod_23(long_4) > gStruct.long_7)
					{
						Class32.smethod_56(gStruct);
						long_4 = Class11.smethod_22();
					}
				}
			}
			else if (num33 > 0 && num32 > 0 && Class11.smethod_23(long_4) > gStruct.long_7)
			{
				Class32.smethod_55(gStruct, array6, bool_0: false);
				Class32.smethod_56(gStruct);
				long_4 = Class11.smethod_22();
			}
			continue;
			IL_0d76:
			flag2 = (num36 > 40000L);
			Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
			num14 = 0;
			if (array == null)
			{
				array = new uint[2]
				{
					array5[0],
					array5[1]
				};
				int_ = 0;
			}
			if (int_ > 6)
			{
				long num48 = Class53.smethod_18(array, array5);
				array = null;
				if (num48 < 180000L)
				{
					Class12.smethod_3(gStruct, bool_0: false);
					Class53.smethod_0(gStruct, array5, Class38.gstruct29_0.uint_4, 600);
					goto IL_2722;
				}
				int_ = 0;
			}
			if (num36 > FormMain.int_95 * FormMain.int_95)
			{
				Class6.smethod_2(gStruct, num21, ref long_3, bool_0: true);
			}
			if (num36 < 900000L && num7 < 6)
			{
				num7++;
				Class12.smethod_3(gStruct, bool_0: false);
				Class60.smethod_61(gStruct, Class38.gstruct29_0.uint_4);
				Thread.Sleep(150);
				goto IL_2722;
			}
			if (Class38.gstruct29_0.uint_4 != null && (!Class12.smethod_4(gStruct) || Class11.smethod_23(long_) > 4000L))
			{
				Class12.smethod_1(gStruct, Class38.gstruct29_0.uint_4);
				Thread.Sleep(300);
				long_ = Class11.smethod_22();
				int_++;
				num7 = 0;
			}
			continue;
			IL_1419:
			num43 = 0;
			goto IL_1780;
			IL_1780:
			if (flag9)
			{
				if (!Class38.smethod_6(gStruct, ref int_5) && Class73.smethod_12(gStruct) != 1)
				{
					num24 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
					array5 = new uint[2]
					{
						Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
						Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
					};
					uint[] uint_3 = array5;
					if (flag && Class38.gstruct29_0.int_4 == num24 && Class38.gstruct29_0.int_3 > 0 && Class38.gstruct29_0.uint_4 != null)
					{
						uint_3 = Class38.gstruct29_0.uint_4;
						num30 += num13;
					}
					uint num49 = 0u;
					if (FormMain.int_33 > 0 && (flag11 || flag))
					{
						if (flag11)
						{
							if (Class38.gstruct29_1.int_4 == num24 && Class38.gstruct29_1.uint_3 != num4)
							{
								num49 = Class38.gstruct29_1.uint_3;
							}
						}
						else if (flag && Class38.gstruct29_0.int_4 == num24 && Class38.gstruct29_0.uint_3 != num4)
						{
							num49 = Class38.gstruct29_0.uint_3;
						}
						if (num49 == 0 && FormMain.int_34 <= 0)
						{
							goto IL_2722;
						}
					}
					int[,] array14 = null;
					if (gStruct.int_116 > 0 && gStruct.int_3 != null)
					{
						array14 = ((gStruct.int_5 > 0) ? Class7.smethod_5(gStruct, num49, num30, uint_3, null, bool_2: false, FormMain.int_90 > 0, bool_4: true) : Class7.smethod_6(gStruct, num49, num30, uint_3, null, bool_2: false, FormMain.int_90 > 0, bool_4: true));
						if (array14 != null && array14[0, 0] >= 0)
						{
							int num50 = -1;
							int int_8 = Class38.gstruct29_0.int_4;
							num14 = 0;
							bool flag18 = false;
							bool flag19 = false;
							while (true)
							{
								int num51 = 0;
								int num52 = 400;
								uint num53 = 0u;
								while (num51 <= 0)
								{
									num50++;
									if (gStruct.int_3 != null && gStruct.int_3.Length > num50)
									{
										num51 = gStruct.int_3[num50];
										if (num51 > 0)
										{
											num52 = Class67.smethod_21(num51);
											break;
										}
										continue;
									}
									goto IL_1e06;
								}
								num22 = (int)Class20.smethod_30(num21 + Class47.gstruct43_55.uint_0, gStruct.int_130);
								num23 = (int)Class20.smethod_30(num21 + Class47.gstruct43_50.uint_0, gStruct.int_130);
								num25 = (int)Class20.smethod_30(num21 + Class47.gstruct43_43.uint_0, gStruct.int_130);
								int num54 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
								if (num25 > 0 && num24 == num54 && num22 != 11 && num22 != 22 && num23 != 0)
								{
									for (int j = 0; j < array14.GetLength(0); j++)
									{
										int num58;
										if (!Class38.smethod_6(gStruct, ref int_5) && Class73.smethod_12(gStruct) != 1)
										{
											num32 = array14[j, 0];
											num33 = array14[j, 1];
											if (num33 <= 0)
											{
												continue;
											}
											num53 = (uint)((int)num19 + num33 * (int)Class47.gstruct43_15.uint_0);
											Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_50.uint_0, array4, 4, ref int_6);
											if (BitConverter.ToInt32(array4, 0) <= 0)
											{
												continue;
											}
											if (num32 > 0)
											{
												Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_43.uint_0, array4, 4, ref int_6);
												if (BitConverter.ToInt32(array4, 0) <= 0)
												{
													continue;
												}
											}
											flag18 = true;
											if (!flag19 || num32 > 0)
											{
												if (num32 > 0)
												{
													flag19 = true;
												}
												if (Class86.smethod_30(gStruct, num33, num51) != 0)
												{
													continue;
												}
												num31 = num52;
												Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array4, 4, ref int_6);
												array6[0] = BitConverter.ToUInt32(array4, 0);
												Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array4, 4, ref int_6);
												array6[1] = BitConverter.ToUInt32(array4, 0);
												array5 = new uint[2]
												{
													Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
													Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
												};
												if (flag)
												{
													array5 = new uint[2]
													{
														Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
														Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
													};
													long num55 = Class53.smethod_18(array5, Class38.gstruct29_0.uint_4);
													if (int_8 != Class38.gstruct29_0.int_4 || num55 > num13 * num13)
													{
														goto IL_21cd;
													}
													int num56 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array6));
													int num57 = (int)Math.Sqrt(Class53.smethod_18(array5, array6));
													num58 = num56 - num13 + 10;
													int num59;
													if (num56 > num13 && num31 < num58)
													{
														if (num57 <= num56)
														{
															if (num57 < num56 && num31 < num57)
															{
																goto IL_1d31;
															}
															goto IL_1d35;
														}
														num59 = 0;
													}
													else
													{
														num59 = 1;
													}
													if (num59 == 0)
													{
														goto IL_1d31;
													}
												}
												goto IL_1d35;
											}
											goto IL_1e06;
										}
										goto IL_21f1;
										IL_1d35:
										if (Class53.smethod_18(array5, array6) <= num31 * num31 || gStruct.int_92 > 0)
										{
											if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
											{
												Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(num51), 4, ref int_6);
												Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num31), 4, ref int_6);
												Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num33), 4, ref int_6);
												Thread.Sleep(10);
											}
											num14 = 1;
										}
										continue;
										IL_1d31:
										num31 = num58;
										goto IL_1d35;
									}
									continue;
								}
								if (num14 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
								}
								num14 = 0;
								break;
								IL_21f1:
								Thread.Sleep(120);
								num14 = 0;
								break;
								IL_1e06:
								if (num14 <= 0 && gStruct.int_6 <= 0 && flag18)
								{
									long num60 = 0L;
									array5 = new uint[2]
									{
										Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
										Class20.smethod_30(num21 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
									};
									num32 = -1;
									num33 = -1;
									flag19 = false;
									num31 = gStruct.int_128;
									if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
									{
										num31 = gStruct.int_93;
									}
									if (num31 <= 0)
									{
										num31 = 500;
									}
									for (int j = 0; j < array14.GetLength(0); j++)
									{
										int num61 = array14[j, 0];
										int num62 = array14[j, 1];
										int num63 = num31;
										if (num62 <= 0)
										{
											continue;
										}
										num53 = (uint)((int)num19 + num62 * (int)Class47.gstruct43_15.uint_0);
										Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_50.uint_0, array4, 4, ref int_6);
										if (BitConverter.ToInt32(array4, 0) <= 0)
										{
											continue;
										}
										if (num61 > 0)
										{
											Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_43.uint_0, array4, 4, ref int_6);
											if (BitConverter.ToInt32(array4, 0) <= 0)
											{
												continue;
											}
										}
										if (flag19 && num61 <= 0 && num33 > 0)
										{
											break;
										}
										Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array4, 4, ref int_6);
										array6[0] = BitConverter.ToUInt32(array4, 0);
										Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array4, 4, ref int_6);
										array6[1] = BitConverter.ToUInt32(array4, 0);
										long num64 = Class53.smethod_18(array5, array6);
										if (num33 > 0 && num60 < num64)
										{
											continue;
										}
										int num58;
										if (flag)
										{
											int num56 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array6));
											int num57 = (int)Math.Sqrt(Class53.smethod_18(array5, array6));
											num58 = num56 - num13 + 10;
											int num65;
											if (num56 > num13 && num63 < num58)
											{
												if (num57 <= num56)
												{
													if (num57 < num56 && num63 < num57)
													{
														goto IL_207b;
													}
													goto IL_207f;
												}
												num65 = 0;
											}
											else
											{
												num65 = 1;
											}
											if (num65 == 0)
											{
												goto IL_207b;
											}
										}
										goto IL_207f;
										IL_207b:
										num63 = num58;
										goto IL_207f;
										IL_207f:
										if (num64 <= num63 * num63 || gStruct.int_92 > 0)
										{
											if (num61 > 0)
											{
												flag19 = true;
											}
											num33 = num62;
											num32 = num61;
											num60 = num64;
											num31 = num63;
										}
									}
									if (num33 > 0)
									{
										flag10 = (Class20.smethod_30(num21 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
										Class53.smethod_29(gStruct, flag10, ref long_3);
										if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
										{
											Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(Class32.smethod_32(gStruct)), 4, ref int_6);
											Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num31), 4, ref int_6);
											Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num33), 4, ref int_6);
										}
									}
								}
								else if (flag18 && num14 <= 0 && gStruct.int_6 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
								}
								break;
								IL_21cd:
								Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
								break;
							}
						}
					}
					else if (!(flag9 = (!gStruct.bool_33 && (FormMain.int_31 > 0 || FormMain.int_30 > 0))))
					{
						flag9 = false;
					}
					else
					{
						array14 = Class7.smethod_5(gStruct, num49, num30, uint_3, null, bool_2: false, FormMain.int_90 > 0, bool_4: true);
						if (array14 != null)
						{
							if (array14[0, 0] == -100)
							{
								continue;
							}
							int num66 = 0;
							while (true)
							{
								if (array14[num66, 1] > 0)
								{
									array6 = new uint[2]
									{
										(uint)array14[num66, 4],
										(uint)array14[num66, 5]
									};
									if (flag)
									{
										int num57 = (int)Math.Sqrt(Class53.smethod_18(array5, array6));
										int num56 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array6));
										if (num57 - num31 > 0)
										{
											if (num56 > num57)
											{
												int num67 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array5));
												if (num67 + (num57 - num31) <= num13 + 10)
												{
													goto IL_2425;
												}
											}
											if (gStruct.int_86 == 1 && num66 == 0)
											{
												num66 = 1;
												continue;
											}
											if (num13 + num31 <= num56)
											{
												if (num14 > 0)
												{
													Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
												}
												num14 = 0;
												break;
											}
										}
									}
									else if (Class53.smethod_18(array5, array6) > num31 * num31 && gStruct.int_92 <= 0)
									{
										if (gStruct.int_86 != 1 || num66 != 0)
										{
											break;
										}
										num66 = 1;
										continue;
									}
									goto IL_2425;
								}
								if (num14 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_6);
								}
								num14 = 0;
								break;
								IL_2425:
								num32 = array14[num66, 0];
								num33 = array14[num66, 1];
								if (FormMain.int_50 > 0 && (num32 <= 0 || num32 == array3[0]) && array3[1] > 0 && array3[2] == num24 && array3[3] > 0)
								{
									int num68 = array3[0];
									int num69 = array3[1];
									uint num53 = (uint)((int)num19 + num69 * (int)Class47.gstruct43_15.uint_0);
									Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_50.uint_0, array4, 4, ref int_6);
									if (BitConverter.ToInt32(array4, 0) > 0)
									{
										Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_45.uint_0, array4, 4, ref int_6);
										long num70 = BitConverter.ToInt32(array4, 0);
										if (num70 != 0L)
										{
											Class20.ReadProcessMemory(gStruct.int_130, num53 + Class47.gstruct43_43.uint_0, array4, 4, ref int_6);
											if (num68 <= 0 || BitConverter.ToInt32(array4, 0) > 0)
											{
												array6 = new uint[2]
												{
													Class20.smethod_30(num53 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
													Class20.smethod_30(num53 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
												};
												long num71 = Class53.smethod_18(array5, array6);
												if (!flag)
												{
													if (num71 <= num31 * num31)
													{
														num32 = num68;
														num33 = num69;
													}
												}
												else
												{
													int num72 = (int)Math.Sqrt(num71);
													int num73 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array6));
													if (num72 - num31 > 0)
													{
														if (num73 > num72)
														{
															int num67 = (int)Math.Sqrt(Class53.smethod_18(Class38.gstruct29_0.uint_4, array5));
															if (num67 + (num72 - num31) <= num13 + 10)
															{
																num32 = num68;
																num33 = num69;
															}
														}
													}
													else
													{
														num32 = num68;
														num33 = num69;
													}
												}
											}
										}
									}
								}
								array3[0] = num32;
								array3[1] = num33;
								array3[2] = num24;
								array3[3] = 0;
								if (num33 > 0)
								{
									array3[3] = 1;
									num14 = 1;
									num15 = 1;
									flag10 = (Class20.smethod_30(num21 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
									Class53.smethod_29(gStruct, flag10, ref long_3);
									if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
									{
										int value = Class32.smethod_32(gStruct);
										Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(value), 4, ref int_6);
										Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num31), 4, ref int_6);
										Class20.WriteProcessMemory(gStruct.int_130, num21 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num33), 4, ref int_6);
									}
								}
								break;
							}
						}
						else
						{
							flag9 = false;
						}
					}
				}
				else
				{
					Thread.Sleep(80);
					num14 = 0;
				}
			}
			goto IL_2722;
		}
	}
}
