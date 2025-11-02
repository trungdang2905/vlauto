using System;
using System.Threading;

internal class Class61
{
	public static string[] string_0 = null;

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
			}
		}
	}

	public static void smethod_1(int int_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		string text = "V¹n Sù Th«ng";
		uint[] array = new uint[2]
		{
			49893u,
			99823u
		};
		uint[] uint_ = null;
		int int_ = 0;
		byte[] byte_ = new byte[4];
		bool flag = false;
		GStruct42 gstruct42_ = default(GStruct42);
		while (true)
		{
			Thread.Sleep(400);
			num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || !FormMain.gstruct42_0[num].bool_60)
			{
				break;
			}
			gstruct42_ = FormMain.gstruct42_0[num];
			if (flag)
			{
				long num4 = Class11.smethod_23(long_3);
				if (num4 < FormMain.int_43 * 1000)
				{
					long num5 = FormMain.int_43 - num4 / 1000L;
					if (Class11.smethod_23(long_4) > 1000L)
					{
						bool bool_ = num5 > 3L;
						Class73.smethod_31(gstruct42_, num3 + ". Tiep theo con: " + num5 + " giay...", bool_);
						long_4 = Class11.smethod_22();
					}
					continue;
				}
			}
			if (FormMain.string_7 != null && !(FormMain.string_7 == string.Empty))
			{
				uint num6 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
				uint num7 = Class20.smethod_30(num6 + Class47.gstruct43_13.uint_0, gstruct42_.int_130);
				uint num8 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
				uint num9 = num8 + num7 * Class47.gstruct43_15.uint_0;
				int num10 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_.int_130);
				int num11 = (int)Class20.smethod_30(num9 + Class47.gstruct43_43.uint_0, gstruct42_.int_130);
				int num12 = (int)Class20.smethod_30(num9 + Class47.gstruct43_55.uint_0, gstruct42_.int_130);
				int num13 = (int)Class20.smethod_30(num9 + Class47.gstruct43_50.uint_0, gstruct42_.int_130);
				int num14 = Class73.smethod_40(gstruct42_);
				if (num12 == 10 || num12 == 21 || num13 == 0 || num14 <= 1)
				{
					continue;
				}
				if (num10 != 54)
				{
					if (num10 == 53 || !Class31.smethod_61(gstruct42_, "Ba L\u00a8ng huyÖn"))
					{
						if (num11 <= 0)
						{
							Class44.smethod_2(gstruct42_, "Nam Nh¹c trÊn");
						}
						else
						{
							Class53.smethod_13(gstruct42_);
						}
					}
					continue;
				}
				uint[] uint_2 = new uint[2]
				{
					Class20.smethod_30(num9 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
					Class20.smethod_30(num9 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
				};
				long num15 = Class53.smethod_18(uint_2, array);
				if (num15 <= 90000L)
				{
					int num16 = 0;
					do
					{
						if (num15 > 22500L)
						{
							Class60.smethod_61(gstruct42_, array);
							Thread.Sleep(300);
							uint_2 = new uint[2]
							{
								Class20.smethod_30(num9 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
								Class20.smethod_30(num9 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
							};
							num15 = Class53.smethod_18(uint_2, array);
							num16++;
							continue;
						}
						if (num2 > 0)
						{
							string text2 = Class86.smethod_15(gstruct42_, num2, ref uint_, text.Length + 10);
							if (text2 == null || !Class11.smethod_3(text2, text))
							{
								num2 = 0;
								uint_ = null;
								Class20.WriteProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_);
							}
						}
						if (num2 <= 0)
						{
							num2 = Class86.smethod_14(gstruct42_, text, ref uint_);
							if (num2 <= 0)
							{
								Class53.smethod_10(gstruct42_);
								text = smethod_2(gstruct42_);
								break;
							}
						}
						num15 = Class53.smethod_18(uint_2, uint_);
						if (num15 > 22500L)
						{
							Class60.smethod_61(gstruct42_, uint_);
							Thread.Sleep(150);
						}
						Class76.Class79.smethod_5(gstruct42_);
						Class76.smethod_9(gstruct42_);
						Class76.Class79.smethod_1(gstruct42_);
						byte[] bytes = BitConverter.GetBytes(num2);
						Class20.WriteProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_72.uint_0, bytes, 4, ref int_);
						int num17 = 0;
						string empty = string.Empty;
						num16 = 0;
						while (true)
						{
							if (!Class11.bool_0)
							{
								Thread.Sleep(100);
								empty = Class76.Class79.smethod_0(gstruct42_);
								num17 = Class76.smethod_2(gstruct42_);
								if (num17 <= 0)
								{
									if (empty == null || !(empty != string.Empty))
									{
										if (num16 > 15)
										{
											Class53.smethod_10(gstruct42_);
											break;
										}
										continue;
									}
									Class20.smethod_4(gstruct42_.uint_4, 32u);
									Class60.smethod_35(gstruct42_, 20000u);
									Thread.Sleep(300);
									break;
								}
							}
							Class76.smethod_6(gstruct42_, 0);
							Thread.Sleep(600);
							empty = Class76.Class79.smethod_0(gstruct42_);
							if (Class11.smethod_3(empty, "chäc ghÑo ta"))
							{
								Class20.smethod_4(gstruct42_.uint_4, 32u);
								Class60.smethod_35(gstruct42_, 20000u);
								Thread.Sleep(300);
								break;
							}
							Class60.smethod_101(gstruct42_, FormMain.string_7);
							Class76.Class79.smethod_5(gstruct42_);
							Class76.Class79.smethod_1(gstruct42_);
							for (int i = 0; i < 2; i++)
							{
								Class20.smethod_4(gstruct42_.uint_4, 10u);
								Class20.smethod_4(gstruct42_.uint_4, 13u);
								Thread.Sleep(100);
							}
							num16 = 0;
							string text3 = null;
							while (true)
							{
								if (!Class11.bool_0)
								{
									empty = Class76.Class79.smethod_0(gstruct42_);
									text3 = Class76.Class78.smethod_2(gstruct42_);
									if (!(empty != string.Empty) && (!(text3 != string.Empty) || (byte)text3[0] == 0))
									{
										num16++;
										Thread.Sleep(100);
										if (num16 > 15)
										{
											Class53.smethod_10(gstruct42_);
											break;
										}
										continue;
									}
								}
								string text4 = null;
								string text5 = null;
								string text6 = "|" + FormMain.string_7 + "| kh«ng râ tung tÝch n¬i ®©u.";
								try
								{
									int num18 = Class11.smethod_2(text3, "\0");
									if (0 <= num18)
									{
										string text7 = text3.Substring(num18 + 2);
										int num19 = Class11.smethod_2(text7, "\u0003,");
										if (0 <= num19)
										{
											text4 = text7.Substring(0, num19).Trim();
											int num20 = Class11.smethod_2(text7, "(");
											int num21 = Class11.smethod_2(text7, ")");
											if (0 <= num20 && num20 < num21)
											{
												text5 = text7.Substring(num20 + 1, num21 - num20 - 1).Replace(" ", "");
												string_0 = new string[2]
												{
													text4,
													text5
												};
											}
										}
									}
								}
								catch
								{
								}
								if (text4 != null && text5 != null)
								{
									text6 = "|" + FormMain.string_7 + "| ë (" + text5 + ") " + text4;
								}
								if (FormMain.gstruct42_0 != null)
								{
									for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
									{
										if (gstruct42_.string_20 != FormMain.gstruct42_0[i].string_20)
										{
											Class60.smethod_48(gstruct42_, FormMain.gstruct42_0[i].string_20, text6);
										}
									}
								}
								if (FormMain.int_41 > 0)
								{
									Class60.smethod_55(gstruct42_, "Chat('CH_TONG', '<color=yellow>" + text6 + "')");
									Thread.Sleep(300);
								}
								if (FormMain.int_42 > 0)
								{
									Class60.smethod_55(gstruct42_, "Chat('CH_CHATROOM', '" + text6 + "')");
									Thread.Sleep(300);
								}
								num3++;
								long_3 = Class11.smethod_22();
								flag = true;
								break;
							}
							break;
						}
						break;
					}
					while (num16 <= 10);
				}
				else if (Class11.smethod_23(long_2) > 3000L)
				{
					Class12.smethod_1(gstruct42_, array);
					long_2 = Class11.smethod_22();
				}
			}
			else
			{
				if (Class11.smethod_23(long_) > 15000L)
				{
					Class60.smethod_50(gstruct42_, "<color=yellow>Chua co thiet lap ten ac can tim");
					long_ = Class11.smethod_22();
				}
				Thread.Sleep(150);
			}
		}
		Class60.smethod_50(gstruct42_, "<color=green>Ket thuc Van su thong !");
	}

	private static string smethod_2(GStruct42 gstruct42_0)
	{
		string text = "V¹n";
		uint[] uint_ = new uint[2]
		{
			49893u,
			99823u
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
		if (num5 == 54)
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
				return null;
			}
			int num7 = 0;
			long num8 = 0L;
			uint[] array4 = new uint[2];
			string text2 = null;
			for (uint num9 = 1u; num9 < 256; num9++)
			{
				if (num6 <= num7)
				{
					break;
				}
				uint num10 = num3 + num9 * Class47.gstruct43_15.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num7++;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_52.uint_0, array, 4, ref int_);
				uint num11 = BitConverter.ToUInt32(array, 0);
				if (num11 == 3)
				{
					uint[] array5 = new uint[2];
					Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_);
					array5[0] = BitConverter.ToUInt32(array, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array, 4, ref int_);
					array5[1] = BitConverter.ToUInt32(array, 0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + Class47.gstruct43_16.uint_0, array2, array2.Length, ref int_);
					string text3 = Class10.smethod_3(array2);
					string string_ = text3.ToLower();
					if (0 <= Class11.smethod_2(string_, text.ToLower()))
					{
						return text3;
					}
					long num12 = Class53.smethod_18(uint_, array5);
					if (num12 < 40000L && (text2 == null || num12 < num8))
					{
						num8 = num12;
						array4[0] = array5[0];
						array4[1] = array5[1];
						text2 = text3;
					}
				}
			}
			return text2;
		}
		return null;
	}
}
