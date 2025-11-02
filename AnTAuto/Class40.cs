using System.Diagnostics;
using System.Threading;

internal class Class40
{
	public static int[] int_0 = null;

	public static int[] int_1 = null;

	public static bool bool_0 = false;

	public static int int_2 = 0;

	public static bool bool_1 = false;

	private static int int_3 = 0;

	private static void smethod_0()
	{
		Process[] processesByName = Process.GetProcessesByName("WerFault");
		if (processesByName != null && processesByName.Length > 0)
		{
			for (int i = 0; i < processesByName.Length; i++)
			{
				Class20.smethod_53(processesByName[i]);
			}
		}
	}

	private static void smethod_1()
	{
		string text = Class55.smethod_6(Class47.string_1, 0);
		if (text == null || text == string.Empty)
		{
			return;
		}
		Class55.smethod_10(Class47.string_0, Class47.string_1, "", "", 0);
		string[] array = text.Split('|');
		bool flag = false;
		for (int i = 0; i < array.Length; i++)
		{
			int num = Class11.smethod_12(array[i]);
			if (num > 0)
			{
				flag = true;
				Class11.smethod_32(ref ThemXoaDanhsach.int_0, num);
			}
		}
		if (flag)
		{
			FormMain.string_19 = null;
			FormMain.int_116 = 0;
			FormMain.bool_8 = true;
		}
	}

	public static void smethod_2()
	{
		while (!Class47.bool_1)
		{
			if (!Class11.bool_0)
			{
				Thread.Sleep(100);
				continue;
			}
			return;
		}
		Class18.smethod_2();
		Class18.smethod_3();
		while (true)
		{
			try
			{
				smethod_3();
				return;
			}
			catch
			{
			}
		}
	}

	private static void smethod_3()
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		Process process = null;
		uint num4 = 0u;
		uint num5 = 0u;
		int num6 = 0;
		int num7 = 0;
		string string_ = string.Empty;
		int num8 = 200;
		long long_ = 0L;
		long long_2 = 0L;
		while (true)
		{
			Thread.Sleep(450);
			if (Class11.bool_0)
			{
				break;
			}
			if (Class11.smethod_23(long_) > 35000L)
			{
				smethod_0();
				long_ = Class11.smethod_22();
			}
			if (Class11.smethod_23(long_2) > 6000L)
			{
				smethod_1();
				long_2 = Class11.smethod_22();
			}
			int_2 = -1;
			if (bool_0)
			{
				if (int_0 != null)
				{
					Class85.smethod_0("Login dừng lại bởi người dùng.");
					int_0 = null;
				}
				process = null;
				bool_0 = false;
				int_2 = 0;
				num = -1;
			}
			if (0 <= num)
			{
				goto IL_038c;
			}
			if (bool_1 || int_0 == null || int_0.Length == 0)
			{
				continue;
			}
			if (!FormMain.bool_1 && (FormMain.bool_0 || GClass1.bool_1 || GClass1.string_2 == null || GClass1.string_2 == string.Empty || FormMain.int_3 > FormMain.int_2))
			{
				int_0 = null;
				continue;
			}
			num = int_0[0];
			int num13;
			if (num >= 0 && FormLogin.gstruct0_0.Length > num)
			{
				GStruct0 gstruct0_ = FormLogin.gstruct0_0[num];
				if (gstruct0_.int_1 > 0 && !Class20.smethod_52(gstruct0_.process_0))
				{
					uint num9 = Class20.smethod_30(Class9.uint_0, gstruct0_.int_2);
					uint num10 = Class20.smethod_30(num9 + Class9.uint_2, gstruct0_.int_2) * Class9.uint_4;
					uint num11 = Class20.smethod_30(Class9.uint_3, gstruct0_.int_2);
					uint num12 = num11 + num10;
					num3 = Class43.smethod_31(gstruct0_);
					if (num3 > 1)
					{
						string text = Class20.smethod_28(num12 + Class9.uint_5, gstruct0_.int_2);
						if (text != null && text.Length > 5)
						{
							goto IL_0b6a;
						}
					}
					Class20.smethod_48(gstruct0_.int_1);
				}
				string text2 = Class11.smethod_16(FormLogin.gstruct0_0[num].string_1);
				if (text2 != null && !(text2 == string.Empty) && text2[0] <= text2.Length - 1)
				{
					string_ = text2.Substring(1, text2[0]);
					num2 = 0;
					num6 = -1;
					num7 = -1;
					string string_2 = FormLogin.gstruct0_0[num].string_2;
					string string_3 = FormLogin.gstruct0_0[num].string_3;
					string text3 = Class10.smethod_1(FormLogin.gstruct0_0[num].string_4, 1);
					if (text3 == string.Empty)
					{
						text3 = FormLogin.gstruct0_0[num].string_0;
					}
					Class85.smethod_0("Đang đăng nhập <" + text3 + "> đợi chút xíu...");
					for (int i = 0; i < FormLogin.string_4.Length; i++)
					{
						string[] array = FormLogin.string_4[i].Split('|');
						if (array[0] != string_2)
						{
							continue;
						}
						num7 = i;
						num13 = 1;
						while (num13 < array.Length)
						{
							if (!(array[num13] == string_3))
							{
								num13++;
								continue;
							}
							goto IL_0386;
						}
					}
					Class85.smethod_0("Lỗi dữ liệu không đúng Phân đà và Server, không thể login.");
				}
			}
			goto IL_0b6a;
			IL_0abd:
			int num14;
			while (!Class11.bool_0 && int_3 > 0 && num14 < 15)
			{
				num14++;
				Thread.Sleep(100);
			}
			int id;
			int_3 = id;
			new Thread(smethod_4).Start();
			goto IL_0b6a;
			IL_0b08:
			int_2 = 0;
			num2++;
			if (num2 < 3)
			{
				continue;
			}
			Class85.smethod_0("Không thể login !");
			goto IL_0b28;
			IL_038c:
			FormLogin.gstruct0_0[num].int_1 = 0;
			FormLogin.gstruct0_0[num].int_2 = 0;
			FormLogin.gstruct0_0[num].uint_0 = 0u;
			FormLogin.gstruct0_0[num].uint_1 = 0u;
			FormLogin.gstruct0_0[num].uint_2 = 0u;
			FormLogin.gstruct0_0[num].uint_3 = 0u;
			FormLogin.gstruct0_0[num].int_0 = 0;
			num4 = 0u;
			num5 = 0u;
			Process process2 = null;
			try
			{
				process2 = ((FormLogin.int_9 > 0) ? Class85.smethod_3() : Class85.smethod_6());
			}
			catch
			{
			}
			if (!Class20.smethod_52(process))
			{
				Class20.smethod_53(process);
				Thread.Sleep(100);
			}
			process = process2;
			string text5;
			if (process != null)
			{
				int num15 = 0;
				int num16 = 0;
				while (true)
				{
					bool flag = false;
					GStruct7[] array2;
					if (num15 == 0)
					{
						array2 = Class20.smethod_62(process.Id, "WIN_CLASS:#32770|CTR_CLASS:Button");
						if (array2 != null && array2.Length > 0 && array2[0].gstruct6_0 != null)
						{
							for (int j = 0; j < array2[0].gstruct6_0.Length; j++)
							{
								if (array2[0].gstruct6_0[j].int_0 == 1)
								{
									Class20.smethod_4(array2[0].gstruct6_0[j].uint_0, 32u);
									Thread.Sleep(300);
									flag = true;
									break;
								}
							}
						}
						num15 = 1;
						if (flag)
						{
							smethod_0();
							continue;
						}
					}
					if (num16 != 0)
					{
						break;
					}
					array2 = Class20.smethod_62(process.Id, "CTR_INSTANCE:1");
					if (array2 != null && array2.Length > 0)
					{
						for (num13 = 0; num13 < array2.Length; num13++)
						{
							if (array2[num13].gstruct6_0 == null)
							{
								continue;
							}
							for (int j = 0; j < array2[num13].gstruct6_0.Length; j++)
							{
								if (array2[num13].gstruct6_0[j].int_0 == 1)
								{
									Class20.smethod_4(array2[num13].gstruct6_0[j].uint_0, 32u);
									Thread.Sleep(300);
									flag = true;
								}
							}
						}
					}
					num16 = 1;
					if (!flag)
					{
						break;
					}
					smethod_0();
				}
				num14 = 0;
				id = process.Id;
				while (num4 == 0)
				{
					try
					{
						num4 = (uint)(int)process.MainModule.BaseAddress;
					}
					catch
					{
					}
					num14++;
					if (num14 <= 10)
					{
						Thread.Sleep(300);
						continue;
					}
					goto IL_0b08;
				}
				num5 = 0u;
				GStruct7[] array3 = Class20.smethod_62(id, "WIN_CLASS:" + Class47.string_17);
				if (array3 != null && array3.Length > 0)
				{
					num5 = array3[0].uint_0;
				}
				FormLogin.gstruct0_0[num].int_1 = id;
				FormLogin.gstruct0_0[num].int_2 = Class20.OpenProcess(2035711, bool_0: false, id);
				FormLogin.gstruct0_0[num].process_0 = process;
				FormLogin.gstruct0_0[num].uint_0 = num5;
				FormLogin.gstruct0_0[num].uint_1 = num4;
				if (Class43.smethod_2(ref FormLogin.gstruct0_0[num]) >= 0)
				{
					GStruct0 gstruct0_2 = FormLogin.gstruct0_0[num];
					if (Class43.smethod_15(gstruct0_2))
					{
						Thread.Sleep(100 + num8);
						if (Class43.smethod_16(gstruct0_2))
						{
							Thread.Sleep(100 + num8);
							if (Class43.smethod_17(gstruct0_2, num7))
							{
								Thread.Sleep(200 + num8);
								if (Class43.smethod_18(gstruct0_2, num6))
								{
									Thread.Sleep(200 + num8);
									if (Class43.smethod_19(gstruct0_2))
									{
										Thread.Sleep(200 + num8);
										if (Class43.smethod_20(gstruct0_2, gstruct0_2.string_0))
										{
											Thread.Sleep(100);
											if (Class43.smethod_21(gstruct0_2, string_))
											{
												Thread.Sleep(100);
												if (Class43.smethod_22(gstruct0_2))
												{
													Thread.Sleep(600 + num8);
													if (Class43.smethod_23(gstruct0_2, gstruct0_2.int_4 - 1))
													{
														Thread.Sleep(200 + num8);
														string text4 = string.Empty;
														bool flag2 = false;
														num14 = 0;
														long long_3 = Class11.smethod_22();
														while (true)
														{
															if (Class11.bool_0)
															{
																goto IL_09fd;
															}
															if (bool_0)
															{
																break;
															}
															if (num14 % 60 != 0 || Class43.smethod_24(gstruct0_2) || num14 != 0)
															{
																Thread.Sleep(100);
																text5 = Class43.smethod_25(gstruct0_2);
																if (0 > text5.IndexOf("Xin nhËp vµo Tµi") && 0 > text5.IndexOf("KÕt nèi m\u00b8y chñ th") && 0 > text5.IndexOf("HÖ thèng ®ang bËn"))
																{
																	if (0 <= text5.IndexOf("Xin h·y n¹p tµi kho¶n") || 0 <= text5.IndexOf("Tµi kho¶n nµy ®· bÞ khãa") || 0 <= text5.IndexOf("Tµi kho¶n nµy hiÖn ®ang") || 0 <= text5.IndexOf("Tµi kho¶n hoÆc MËt khÈu"))
																	{
																		goto IL_09d7;
																	}
																	num3 = Class43.smethod_31(gstruct0_2);
																	if (num3 > 1)
																	{
																		uint num9 = Class20.smethod_30(Class9.uint_0, gstruct0_2.int_2);
																		uint num10 = Class20.smethod_30(num9 + Class9.uint_2, gstruct0_2.int_2) * Class9.uint_4;
																		uint num11 = Class20.smethod_30(Class9.uint_3, gstruct0_2.int_2);
																		uint num12 = num11 + num10;
																		text4 = Class20.smethod_28(num12 + Class9.uint_5, gstruct0_2.int_2);
																		if (text4 != null && text4 != string.Empty && text4.Length > 5)
																		{
																			flag2 = true;
																			goto IL_09fd;
																		}
																	}
																	long num17 = Class11.smethod_23(long_3);
																	if (num17 <= FormLogin.int_6)
																	{
																		int_2 = (int)(FormLogin.int_6 - num17);
																		num14++;
																		continue;
																	}
																	Class85.smethod_0("Không thể đăng nhập, đang thử lại...");
																}
																else
																{
																	Class85.smethod_0(Class10.smethod_1(text5, 1));
																}
															}
															goto IL_0b08;
															IL_09fd:
															string string_4 = "[" + Class10.smethod_1(text4, 1) + "] Đã đăng nhập...";
															Class11.smethod_24(ref Class11.string_14, string_4);
															if (FormLogin.bool_0)
															{
																Class11.smethod_24(ref FormLogin.string_0, string_4);
															}
															FormLogin.gstruct0_0[num].string_4 = text4;
															FormLogin.gstruct0_0[num].int_0 = 1;
															if (flag2 && text4 != FormLogin.gstruct0_0[num].string_4)
															{
																Class18.smethod_1();
															}
															if (FormLogin.int_7 > 0)
															{
																Class20.ShowWindow(num5, Class20.int_20);
															}
															num14 = 0;
															goto IL_0abd;
														}
														continue;
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
				else
				{
					FormLogin.gstruct0_0[num].int_1 = 0;
					FormLogin.gstruct0_0[num].process_0 = null;
				}
			}
			goto IL_0b08;
			IL_0386:
			num6 = num13 - 1;
			goto IL_038c;
			IL_0b6a:
			Class11.smethod_33(ref int_0, num);
			if (FormLogin.bool_0)
			{
				Class11.smethod_32(ref int_1, num);
			}
			process = null;
			num = -1;
			continue;
			IL_0b28:
			Class20.smethod_53(process);
			if (FormLogin.gstruct0_0 != null && 0 <= num && num < FormLogin.gstruct0_0.Length)
			{
				FormLogin.gstruct0_0[num].int_1 = 0;
				FormLogin.gstruct0_0[num].process_0 = null;
			}
			goto IL_0b6a;
			IL_09d7:
			Class85.smethod_0(Class10.smethod_1(text5, 1));
			goto IL_0b28;
		}
	}

	private static void smethod_4()
	{
		int num = 0;
		while (!Class11.bool_0 && int_3 > 0 && num < 20)
		{
			Thread.Sleep(100);
			num++;
		}
		if (int_3 > 0)
		{
			FormMain.string_19 = null;
			Class11.smethod_32(ref ThemXoaDanhsach.int_0, int_3);
		}
		int_3 = 0;
		FormMain.int_116 = 0;
		FormMain.bool_8 = true;
	}

	public static string smethod_5()
	{
		int num = 0;
		int[] array = Class20.smethod_24(Class47.string_17);
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					GStruct7[] array2 = Class20.smethod_62(array[i], "WIN_CLASS:Sword3 Class");
					if (array2 == null || array2.Length == 0)
					{
						Class20.smethod_48(array[i]);
						Thread.Sleep(100);
						num++;
					}
				}
				catch
				{
				}
			}
		}
		if (!(Class47.string_15 == string.Empty) && Class47.string_15 != null)
		{
			string processName = Class47.string_15;
			if (Class11.smethod_2(Class47.string_15.ToUpper(), ".EXE") > 0)
			{
				string[] array3 = Class11.smethod_15(Class47.string_15, '.');
				processName = array3[0];
			}
			Process[] processesByName = Process.GetProcessesByName(processName);
			if (processesByName == null || processesByName.Length == 0)
			{
				processesByName = Process.GetProcessesByName(Class47.string_15 + '\u00a0');
				if (processesByName == null || processesByName.Length == 0)
				{
					goto IL_0144;
				}
			}
			for (int i = 0; i < processesByName.Length; i++)
			{
				try
				{
					GStruct7[] array2 = Class20.smethod_62(processesByName[i].Id, "WIN_CLASS:Sword3 Class");
					if (array2 == null || array2.Length == 0)
					{
						Class20.smethod_48(processesByName[i].Id);
						num++;
					}
				}
				catch
				{
				}
			}
		}
		goto IL_0144;
		IL_0144:
		string empty = string.Empty;
		if (num != 0)
		{
			return "Đã thoát " + num + " game hư đang chạy ngầm.";
		}
		return "Không tìm thấy game hư chạy ngầm nào.";
	}
}
