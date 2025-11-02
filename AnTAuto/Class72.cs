using System;
using System.Threading;

internal class Class72
{
	public int int_0 = 0;

	public static void smethod_0(GStruct42 gstruct42_0)
	{
		Class60.smethod_12(gstruct42_0.int_130, gstruct42_0.uint_48);
	}

	public static void smethod_1(GStruct42 gstruct42_0)
	{
		Class60.smethod_55(gstruct42_0, "CreateTeam()");
	}

	public static void smethod_2(GStruct42 gstruct42_0)
	{
		Class60.smethod_12(gstruct42_0.int_130, gstruct42_0.uint_49);
	}

	public static void smethod_3(GStruct42 gstruct42_0, string string_0)
	{
		Class60.smethod_55(gstruct42_0, "InviteTeam('" + string_0 + "')");
	}

	public static bool smethod_4(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		return Class20.smethod_30(num + Class47.gstruct43_12.uint_0 + Class47.gstruct43_197.uint_0, gstruct42_0.int_130) != 0;
	}

	public static GStruct48 smethod_5(GStruct42 gstruct42_0)
	{
		GStruct47[] array = new GStruct47[8];
		int num = 0;
		string string_ = string.Empty;
		for (int i = 0; i < 8; i++)
		{
			string text = Class20.smethod_28((uint)((int)(Class47.gstruct43_198.uint_0 + gstruct42_0.uint_6) + i * (int)Class47.gstruct43_193.uint_0), gstruct42_0.int_130, 32);
			if (text != string.Empty)
			{
				num++;
				if (i == 0)
				{
					string_ = text;
				}
				array[i].string_0 = text;
				array[i].int_1 = i;
				array[i].int_0 = (int)Class20.smethod_30((uint)(Class47.gstruct43_195.uint_0 + gstruct42_0.uint_6 + i * Class47.gstruct43_194.uint_0), gstruct42_0.int_130);
			}
		}
		GStruct48 result = default(GStruct48);
		result.int_0 = num;
		result.string_0 = string_;
		result.gstruct47_0 = array;
		return result;
	}

	public static void smethod_6(GStruct42 gstruct42_0, string[] string_0 = null, bool bool_0 = true)
	{
		string text = Class46.smethod_2(gstruct42_0, bool_0: true);
		string[] array = text.Split(';');
		if (array.Length < 2)
		{
			return;
		}
		if (string_0 != null && string_0.Length > 0)
		{
			bool flag = false;
			array[1] = Class10.smethod_1(array[1], 1);
			for (int i = 0; i < string_0.Length; i++)
			{
				if (array[1] == string_0[i])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return;
			}
		}
		uint uint_ = Class11.smethod_13(array[0]);
		Class20.smethod_31(gstruct42_0.uint_50 + 2, gstruct42_0.int_130, uint_);
		Class20.smethod_31(gstruct42_0.uint_50 + 7, gstruct42_0.int_130, Convert.ToByte(bool_0), 1);
		Class60.smethod_12(gstruct42_0.int_130, gstruct42_0.uint_50);
	}

	private int method_0(GStruct42[] gstruct42_0, int int_1)
	{
		if (gstruct42_0 != null && gstruct42_0.Length > 0)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				if (int_1 == gstruct42_0[i].int_129)
				{
					return i;
				}
			}
		}
		return -1;
	}

	public void method_1()
	{
		int int_ = int_0;
		int num = 1;
		int num2 = 255;
		long long_ = 0L;
		string[] array = new string[2]
		{
			"chó",
			"thÝm"
		};
		GStruct49 gStruct = default(GStruct49);
		while (!Class11.bool_0)
		{
			Thread.Sleep(300);
			int num3 = method_0(FormMain.gstruct42_0, int_);
			if (num3 < 0)
			{
				break;
			}
			GStruct42 gstruct42_ = FormMain.gstruct42_0[num3];
			if (!gstruct42_.bool_36)
			{
				break;
			}
			if (gStruct.string_0 == null || gStruct.string_0 == "")
			{
				continue;
			}
			string[] array2 = gStruct.string_0.Split(',');
			if (array2 == null || array2.Length == 0)
			{
				continue;
			}
			int num4 = -1;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == gstruct42_.string_20 || array2[i] == Class10.smethod_1(gstruct42_.string_20, 1))
				{
					num4 = i;
					break;
				}
			}
			if (num4 < 0)
			{
				continue;
			}
			gStruct.int_0 = Convert.ToByte(num4 == 0) + 3 * Convert.ToByte(num4 != 0);
			uint num5 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
			uint num6 = Class20.smethod_30(Class47.gstruct43_161.uint_0, gstruct42_.int_130);
			uint uint_ = Class20.smethod_30(num6 + Class47.gstruct43_163.uint_0, gstruct42_.int_130);
			uint num7 = Class20.smethod_30(uint_, gstruct42_.int_130);
			string text = Class20.smethod_28(num7, gstruct42_.int_130, 60);
			GStruct48 gStruct2 = smethod_5(gstruct42_);
			bool flag = smethod_4(gstruct42_);
			if (gStruct.int_0 == 1 && (array2 == null || array2.Length == 0))
			{
				continue;
			}
			if (gStruct.int_0 <= 1)
			{
				if (!flag)
				{
					smethod_1(gstruct42_);
				}
				else if (!(gStruct2.string_0 != gstruct42_.string_20))
				{
					if (gStruct2.int_0 != 8)
					{
						if (num >= num2)
						{
							num = 1;
						}
						int num8 = 0;
						for (int i = num; i < num2; i++)
						{
							num8++;
							uint num9 = (uint)(i * (int)Class47.gstruct43_15.uint_0);
							uint num10 = Class20.smethod_30(num5 + num9 + Class47.gstruct43_52.uint_0, gstruct42_.int_130);
							if (num10 != 1 || Class20.smethod_30(num5 + num9 + Class47.gstruct43_50.uint_0, gstruct42_.int_130) == 0)
							{
								continue;
							}
							string text2 = Class20.smethod_28(num5 + num9 + Class47.gstruct43_16.uint_0, gstruct42_.int_130, 32);
							if (text2 == "" || text2 == gstruct42_.string_20)
							{
								continue;
							}
							if (Class11.bool_0)
							{
								return;
							}
							Thread.Sleep(200);
							bool flag2 = false;
							string a = Class10.smethod_1(text2, 1);
							if (gStruct2.int_0 > 0 && gStruct2.gstruct47_0 != null)
							{
								for (int j = 0; j < gStruct2.gstruct47_0.Length; j++)
								{
									if (gStruct2.gstruct47_0[j].string_0 != null && gStruct2.gstruct47_0[j].string_0 != "" && gStruct2.gstruct47_0[j].string_0 == text2)
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
							if (gStruct.int_0 == 1)
							{
								flag2 = true;
								if (array2 != null && array2.Length > 0)
								{
									for (int j = 0; j < array2.Length; j++)
									{
										if (text2 == array2[j] || a == array2[j])
										{
											flag2 = false;
											break;
										}
									}
								}
							}
							if (!flag2)
							{
								smethod_3(gstruct42_, text2);
								if (Class11.smethod_23(long_) > 3000L)
								{
									int num11 = Convert.ToByte(Class86.smethod_9(gstruct42_, i) > 0);
									string str = "<color=green>" + text2 + "<color=white> vµo pt ®i " + array[num11] + " :B";
									Class60.smethod_55(gstruct42_, "Chat('CH_NEARBY', '" + str + "')");
									long_ = Class11.smethod_22();
								}
								break;
							}
						}
						num = ((num8 != 0) ? (num + num8) : (num + 1));
					}
				}
				else
				{
					smethod_2(gstruct42_);
				}
			}
			else
			{
				if (text == string.Empty)
				{
					continue;
				}
				if (flag)
				{
					if (gStruct.int_0 == 2 || array2 == null || array2.Length == 0)
					{
						if (gStruct2.string_0 != gstruct42_.string_20)
						{
							goto IL_0741;
						}
						smethod_2(gstruct42_);
						flag = false;
						Thread.Sleep(450);
					}
					if (gStruct2.gstruct47_0 != null)
					{
						for (int k = 0; k < gStruct2.gstruct47_0.Length; k++)
						{
							Thread.Sleep(100);
							string text2 = gStruct2.gstruct47_0[k].string_0;
							if (text2 == null || text2 == "" || text2 == gstruct42_.string_20)
							{
								continue;
							}
							text2 = Class10.smethod_1(text2, 1);
							int i = 0;
							while (i < array2.Length)
							{
								if (!(text2 == array2[i]))
								{
									Thread.Sleep(100);
									i++;
									continue;
								}
								goto IL_0741;
							}
						}
					}
				}
				if (Class11.smethod_2(text, "mêi tæ ®éi") > 0)
				{
					string text3 = Class20.smethod_28(num7 + Class47.gstruct43_200.uint_0, gstruct42_.int_130, 25);
					if (!(text3 == string.Empty))
					{
						if (!flag || gStruct.int_0 <= 2 || array2 == null || array2.Length <= 0)
						{
							goto IL_069a;
						}
						text3 = Class10.smethod_1(text3, 1);
						int i = 0;
						while (i < array2.Length)
						{
							if (!(text3 == array2[i]))
							{
								i++;
								continue;
							}
							goto IL_069a;
						}
					}
				}
			}
			goto IL_0741;
			IL_069a:
			uint num12 = Class20.smethod_30(num7 + Class47.gstruct43_166.uint_0, gstruct42_.int_130);
			if (num12 != 0 && num12 < int.MaxValue)
			{
				Class20.smethod_31(gstruct42_.uint_50 + 2, gstruct42_.int_130, num12);
				Class20.smethod_31(gstruct42_.uint_50 + 7, gstruct42_.int_130, 1u, 1);
				Class60.smethod_12(gstruct42_.int_130, gstruct42_.uint_50);
				if (Class11.smethod_23(long_) > 2500L)
				{
					Class60.smethod_55(gstruct42_, "Chat('CH_NEARBY', 'C\u00b8m ¬n thÝm ®· mêi !:0')");
					long_ = Class11.smethod_22();
				}
				Thread.Sleep(500);
				continue;
			}
			goto IL_0741;
			IL_0741:
			if (text != string.Empty)
			{
				Class60.smethod_12(gstruct42_.int_130, gstruct42_.uint_51);
			}
			Thread.Sleep(300);
		}
	}
}
