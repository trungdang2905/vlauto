using System;
using System.Threading;

internal class Class56
{
	public static void smethod_0(int int_0)
	{
		int num = 0;
		int int_ = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int int_2 = -1;
		byte[] array = new byte[4];
		byte[] byte_ = new byte[4];
		int[] array2 = new int[5];
		GStruct42 gStruct = default(GStruct42);
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		bool flag = false;
		while (true)
		{
			Thread.Sleep(100);
			num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (Class11.bool_0 || num < 0 || FormMain.int_20 != 3)
			{
				break;
			}
			gStruct = FormMain.gstruct42_0[num];
			if (!gStruct.bool_36 || gStruct.int_21[0] > 0 || gStruct.int_126[0] > 0 || gStruct.bool_60 || gStruct.int_26 > 0 || gStruct.bool_61)
			{
				break;
			}
			if (gStruct.bool_21 || gStruct.bool_14 || gStruct.bool_6)
			{
				continue;
			}
			if (gStruct.int_125[0] > 0 && !gStruct.bool_52 && Class87.int_0 <= 0)
			{
				Class87.int_0 = int_0;
				new Thread(Class87.smethod_0).Start();
				Thread.Sleep(300);
			}
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
			uint num8 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_13.uint_0, array, 4, ref int_);
			uint num9 = BitConverter.ToUInt32(array, 0);
			uint num10 = num9 * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
			uint num11 = BitConverter.ToUInt32(array, 0);
			uint num12 = num11 + num10;
			Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_55.uint_0, array, 4, ref int_);
			int num13 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
			int num14 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_);
			int num15 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
			int num16 = BitConverter.ToInt32(array, 0);
			int num17 = Class73.smethod_12(gStruct);
			if (gStruct.int_129 == Class66.gstruct42_0.int_129)
			{
				switch (num17)
				{
				case 2:
					Thread.Sleep(100);
					continue;
				case 1:
					if (num2 > 0 || (num3 > 1 && num16 > 0))
					{
						Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
						num2 = 0;
					}
					if (num3 > 3)
					{
						num4 = 0;
					}
					num3++;
					continue;
				}
			}
			if (num4 <= 0)
			{
				array2[0] = 0;
				array2[1] = 0;
				array2[2] = 0;
				array2[3] = 0;
				array2[4] = 0;
			}
			num4 = 0;
			num3 = 0;
			uint[] array3 = new uint[2]
			{
				Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
				Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
			};
			int num18 = Class73.smethod_40(gStruct);
			uint[] array4;
			int num22;
			int int_3;
			int num24;
			bool flag2;
			int num25;
			bool flag3;
			if (num14 != 0 && num13 != 0 && num15 != 0 && num18 > 1 && num13 != 10 && num13 != 21 && array3[0] != 0 && array3[1] != 0)
			{
				if (num5 == num15)
				{
					if (num6 != num16)
					{
						int num19 = 0;
						while (num16 == 0 && num19 < 30 && num16 != num6)
						{
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
							num8 = BitConverter.ToUInt32(array, 0);
							Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_13.uint_0, array, 4, ref int_);
							num9 = BitConverter.ToUInt32(array, 0);
							num10 = num9 * Class47.gstruct43_15.uint_0;
							Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
							num11 = BitConverter.ToUInt32(array, 0);
							num12 = num11 + num10;
							Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
							num16 = BitConverter.ToInt32(array, 0);
							Thread.Sleep(10);
							num19++;
						}
						num6 = num16;
						if (num16 <= 0)
						{
							continue;
						}
					}
					if (gStruct.int_97[0] > 0 && gStruct.int_97[1] > 0 && gStruct.string_21 == "NGAMY")
					{
						long num20 = Class11.smethod_23(long_);
						if (num20 < 300L)
						{
							continue;
						}
						if (num20 > gStruct.int_97[4] && Class7.smethod_3(gStruct))
						{
							Thread.Sleep(80);
							long_ = Class11.smethod_22();
							continue;
						}
					}
					if (Class60.smethod_3(gStruct, Class60.uint_6) > 0)
					{
						continue;
					}
					array4 = new uint[2];
					int num21 = 0;
					num22 = 0;
					int num23 = 0;
					int_3 = 600;
					if (gStruct.int_94 > 0)
					{
						int_3 = gStruct.int_95;
					}
					num24 = gStruct.int_128;
					if (gStruct.int_92 > 0 && gStruct.int_93 > 0)
					{
						num24 = gStruct.int_93;
					}
					if (num24 <= 0)
					{
						num24 = 500;
					}
					flag2 = ((463 < num15 && num15 < 472) || (479 < num15 && num15 < 496));
					flag3 = (!gStruct.bool_33 && (FormMain.int_31 > 0 || FormMain.int_30 > 0));
					if (FormDame.int_6 <= 0)
					{
						goto IL_0835;
					}
					if (flag3 || FormDame.int_7 > 0)
					{
						num25 = 0;
						if (FormDame.int_5 == 0)
						{
							goto IL_06f6;
						}
						bool flag4 = Class38.gstruct29_0.int_8 == 1;
						if (FormDame.int_5 != 1)
						{
							if (FormDame.int_5 != 2 || flag4)
							{
								goto IL_06ee;
							}
							if (num2 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
							}
							num2 = 0;
						}
						else
						{
							if (flag4)
							{
								goto IL_06f6;
							}
							if (FormDame.int_8 > 0)
							{
								goto IL_06ee;
							}
							if (num2 > 0)
							{
								Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
							}
							num2 = 0;
						}
					}
					goto IL_150f;
				}
				int num26 = 0;
				while (num5 != num15)
				{
					int num27 = Class73.smethod_40(gStruct);
					Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
					num2 = 0;
					Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
					num8 = BitConverter.ToUInt32(array, 0);
					Class20.ReadProcessMemory(gStruct.int_130, num8 + Class47.gstruct43_13.uint_0, array, 4, ref int_);
					num9 = BitConverter.ToUInt32(array, 0);
					num10 = num9 * Class47.gstruct43_15.uint_0;
					Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
					num11 = BitConverter.ToUInt32(array, 0);
					num12 = num11 + num10;
					Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
					num14 = BitConverter.ToInt32(array, 0);
					Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_);
					num15 = BitConverter.ToInt32(array, 0);
					Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
					num16 = BitConverter.ToInt32(array, 0);
					if (num16 > 0 || num26 > 10 || (num27 != 0 && num27 != 1 && num14 > 0 && num15 > 0))
					{
						break;
					}
					num26++;
					Thread.Sleep(100);
				}
				num5 = num15;
				continue;
			}
			Thread.Sleep(60);
			continue;
			IL_06ee:
			num25 = 0;
			goto IL_0835;
			IL_06f6:
			flag = (Class20.smethod_30(num12 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
			Class53.smethod_30(gStruct, flag, ref long_2);
			if (gStruct.int_121[0] > 0)
			{
				bool flag5 = gStruct.int_121[1] > 0 && gStruct.int_121[2] > 0;
				bool flag6 = gStruct.int_121[3] > 0 && gStruct.int_121[4] > 0;
				if (flag5 && !flag6)
				{
					num25 = gStruct.int_121[2];
				}
				else if (flag6 && !flag5)
				{
					num25 = gStruct.int_121[4];
				}
				else if (flag5 && flag6)
				{
					num25 = ((0 > num7 || num7 > 25) ? gStruct.int_121[4] : gStruct.int_121[2]);
					if (num7 > 35)
					{
						num7 = 0;
					}
					num7++;
				}
			}
			if (num25 <= 0)
			{
				num25 = Class32.smethod_32(gStruct);
			}
			Class67.smethod_7(gStruct);
			Class67.smethod_3(gStruct, num25, 6, 1);
			for (int i = 0; i < 3; i++)
			{
				Class20.smethod_75(gStruct.uint_4, 117);
				if (i < 2)
				{
					Thread.Sleep(60);
				}
			}
			goto IL_150f;
			IL_0835:
			if (flag3)
			{
				if (!Class38.smethod_6(gStruct, ref int_2) && Class73.smethod_12(gStruct) != 1)
				{
					num15 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
					array3 = new uint[2]
					{
						Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
						Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
					};
					int[,] array5 = null;
					if (gStruct.int_116 > 0 && gStruct.int_3 != null)
					{
						array5 = Class7.smethod_6(gStruct, 0u, int_3, array3);
						if (array5 != null && array5[0, 0] >= 0)
						{
							int num28 = -1;
							bool flag7 = false;
							bool flag8 = false;
							num2 = 0;
							while (true)
							{
								int num29 = 0;
								int num30 = 400;
								uint num31 = 0u;
								while (num29 <= 0)
								{
									num28++;
									if (gStruct.int_3 != null && gStruct.int_3.Length > num28)
									{
										num29 = gStruct.int_3[num28];
										if (num29 > 0)
										{
											num30 = Class67.smethod_21(num29);
											break;
										}
										continue;
									}
									goto IL_0ce1;
								}
								Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_55.uint_0, array, 4, ref int_);
								num13 = BitConverter.ToInt32(array, 0);
								Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
								num14 = BitConverter.ToInt32(array, 0);
								Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
								num16 = BitConverter.ToInt32(array, 0);
								Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_27.uint_0, array, 4, ref int_);
								int num32 = BitConverter.ToInt32(array, 0);
								if (num16 > 0 && num15 == num32 && num13 != 11 && num13 != 22 && num14 != 0)
								{
									for (int j = 0; j < array5.GetLength(0); j++)
									{
										if (!Class38.smethod_6(gStruct, ref int_2) && Class73.smethod_12(gStruct) != 1)
										{
											int num21 = array5[j, 0];
											num22 = array5[j, 1];
											if (num22 <= 0)
											{
												continue;
											}
											num31 = (uint)((int)num11 + num22 * (int)Class47.gstruct43_15.uint_0);
											Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
											if (BitConverter.ToInt32(array, 0) <= 0)
											{
												continue;
											}
											if (num21 > 0)
											{
												Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
												if (BitConverter.ToInt32(array, 0) <= 0)
												{
													continue;
												}
											}
											flag7 = true;
											if (!flag8 || num21 > 0)
											{
												if (num21 > 0)
												{
													flag8 = true;
												}
												if (Class86.smethod_30(gStruct, num22, num29) != 0)
												{
													continue;
												}
												Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_);
												array4[0] = BitConverter.ToUInt32(array, 0);
												Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array, 4, ref int_);
												array4[1] = BitConverter.ToUInt32(array, 0);
												array3 = new uint[2]
												{
													Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
													Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
												};
												if (Class53.smethod_18(array3, array4) <= num30 * num30 || gStruct.int_92 > 0)
												{
													if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
													{
														Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(num29), 4, ref int_);
														Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num30), 4, ref int_);
														Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num22), 4, ref int_);
														Thread.Sleep(10);
													}
													num2 = 1;
												}
												continue;
											}
											goto IL_0ce1;
										}
										goto IL_1172;
									}
									continue;
								}
								if (num2 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
								}
								num2 = 0;
								break;
								IL_0ce1:
								if (num2 <= 0 && gStruct.int_6 <= 0 && flag7)
								{
									long num33 = 0L;
									array3 = new uint[2]
									{
										Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
										Class20.smethod_30(num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
									};
									int num21 = -1;
									num22 = -1;
									flag8 = false;
									int num34 = 0;
									int length = array5.GetLength(1);
									for (int j = 0; j < array5.GetLength(0); j++)
									{
										int num35 = array5[j, 0];
										int num36 = array5[j, 1];
										int num37 = array5[j, 2];
										int num38 = 0;
										if (length > 10)
										{
											num38 = array5[j, 10];
										}
										if (num36 <= 0)
										{
											continue;
										}
										num31 = (uint)((int)num11 + num36 * (int)Class47.gstruct43_15.uint_0);
										Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
										if (BitConverter.ToInt32(array, 0) <= 0)
										{
											continue;
										}
										if (num35 > 0)
										{
											Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
											if (BitConverter.ToInt32(array, 0) <= 0)
											{
												continue;
											}
										}
										if (flag8 && num35 <= 0 && num22 > 0)
										{
											break;
										}
										Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_);
										array4[0] = BitConverter.ToUInt32(array, 0);
										Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array, 4, ref int_);
										array4[1] = BitConverter.ToUInt32(array, 0);
										long num39 = Class53.smethod_18(array3, array4);
										if ((num22 <= 0 || num33 >= num39) && (num39 <= num24 * num24 || gStruct.int_92 > 0))
										{
											if (num35 > 0)
											{
												flag8 = true;
											}
											num22 = num36;
											num21 = num35;
											int num23 = num37;
											num34 = num38;
											num33 = num39;
										}
									}
									if (num22 <= 0)
									{
										break;
									}
									if (FormMain.int_109 > 0 && flag2)
									{
										if (num34 <= 0)
										{
											num31 = (uint)((int)num11 + num22 * (int)Class47.gstruct43_15.uint_0);
											Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_);
											array4[0] = BitConverter.ToUInt32(array, 0);
											Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array, 4, ref int_);
											array4[1] = BitConverter.ToUInt32(array, 0);
											if (Class7.smethod_4(gStruct.int_130, num15, array4) == 0)
											{
												uint num40 = (uint)((int)num11 + num22 * (int)Class47.gstruct43_15.uint_0 + (int)Class47.gstruct43_57.uint_0 + (int)Class47.gstruct43_1.uint_0);
												for (uint num41 = 0u; num41 < 6; num41++)
												{
													Class20.ReadProcessMemory(gStruct.int_130, num40 + Class47.gstruct43_2.uint_0 * num41, array, 4, ref int_);
													if (BitConverter.ToInt32(array, 0) == 45)
													{
														num34 = 1;
														break;
													}
												}
											}
											else
											{
												num34 = 1;
											}
										}
										if (num34 > 0)
										{
											num22 = 0;
											int num23 = 0;
											num2 = 0;
											break;
										}
									}
									flag = (Class20.smethod_30(num12 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
									Class53.smethod_29(gStruct, flag, ref long_2);
									if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
									{
										Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(Class32.smethod_32(gStruct)), 4, ref int_);
										Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num24), 4, ref int_);
										Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num22), 4, ref int_);
									}
								}
								else if (flag7 && num2 <= 0 && gStruct.int_6 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
								}
								break;
								IL_1172:
								num2 = 0;
								break;
							}
						}
					}
					else
					{
						array5 = Class7.smethod_5(gStruct, 0u, int_3, array3, Class7.int_0);
						if (array5 == null)
						{
							flag3 = false;
						}
						else
						{
							if (array5[0, 0] == -100)
							{
								continue;
							}
							int num42 = 0;
							while (true)
							{
								if (array5[num42, 1] > 0)
								{
									array4 = new uint[2]
									{
										(uint)array5[num42, 4],
										(uint)array5[num42, 5]
									};
									if (Class53.smethod_18(array3, array4) > num24 * num24 && gStruct.int_92 <= 0)
									{
										if (gStruct.int_86 != 1 || num42 != 0)
										{
											break;
										}
										num42 = 1;
										continue;
									}
									int num21 = array5[num42, 0];
									num22 = array5[num42, 1];
									int num23 = array5[num42, 2];
									if (FormMain.int_50 > 0 && (num21 <= 0 || num21 == array2[0]) && array2[1] > 0 && array2[2] == num15 && array2[3] > 0)
									{
										int num43 = array2[0];
										int num44 = array2[1];
										int num45 = array2[4];
										uint num31 = (uint)((int)num11 + num44 * (int)Class47.gstruct43_15.uint_0);
										Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
										if (BitConverter.ToInt32(array, 0) > 0)
										{
											Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_45.uint_0, array, 4, ref int_);
											long num46 = BitConverter.ToInt32(array, 0);
											if (num46 != 0L)
											{
												Class20.ReadProcessMemory(gStruct.int_130, num31 + Class47.gstruct43_43.uint_0, array, 4, ref int_);
												if (num43 <= 0 || BitConverter.ToInt32(array, 0) > 0)
												{
													array4 = new uint[2]
													{
														Class20.smethod_30(num31 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
														Class20.smethod_30(num31 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
													};
													long num47 = Class53.smethod_18(array3, array4);
													if (num47 <= num24 * num24)
													{
														num21 = num43;
														num22 = num44;
														num23 = num45;
													}
												}
											}
										}
									}
									array2[0] = num21;
									array2[1] = num22;
									array2[2] = num15;
									array2[3] = 0;
									array2[4] = num23;
									if (num22 > 0)
									{
										array2[3] = 1;
										num2 = 1;
										num4 = 1;
										flag = (Class20.smethod_30(num12 + Class47.gstruct43_44.uint_0, gStruct.int_130) != 0);
										Class53.smethod_29(gStruct, flag, ref long_2);
										if (Class60.smethod_3(gStruct, Class60.uint_6) <= 0)
										{
											Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_157.uint_0 - 8, BitConverter.GetBytes(Class32.smethod_32(gStruct)), 4, ref int_);
											Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_31.uint_0, BitConverter.GetBytes(num24), 4, ref int_);
											Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num22), 4, ref int_);
										}
									}
									break;
								}
								if (num2 > 0)
								{
									Class20.WriteProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
								}
								num2 = 0;
								break;
							}
						}
					}
				}
				else
				{
					Thread.Sleep(120);
					num2 = 0;
				}
			}
			goto IL_150f;
			IL_150f:
			if (!gStruct.bool_66 || gStruct.int_81 <= 0)
			{
				continue;
			}
			if (FormMain.int_93 == 0)
			{
				if (num22 > 0 && Class11.smethod_23(long_3) > gStruct.long_7)
				{
					Class32.smethod_55(gStruct, array4, bool_0: false);
					Class32.smethod_56(gStruct);
					long_3 = Class11.smethod_22();
				}
			}
			else if (Class38.gstruct29_0.int_7 == Class24.gstruct38_0[FormMain.int_94].int_0)
			{
				Class32.smethod_55(gStruct, null, bool_0: true);
				if (Class11.smethod_23(long_3) > gStruct.long_7)
				{
					Class32.smethod_56(gStruct);
					long_3 = Class11.smethod_22();
				}
			}
		}
	}
}
