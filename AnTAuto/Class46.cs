using System.Threading;

internal class Class46
{
	private static string[] string_0 = new string[2]
	{
		"mêi tæ ®éi",
		"giao dÞch"
	};

	public static void smethod_0(GStruct42 gstruct42_0)
	{
		Class60.smethod_50(gstruct42_0, "Xãa Sms...");
		for (int i = 0; i < 10; i++)
		{
			if (smethod_2(gstruct42_0) == string.Empty)
			{
				break;
			}
			Class60.smethod_12(gstruct42_0.int_130, gstruct42_0.uint_51);
			Thread.Sleep(150);
		}
	}

	public static bool smethod_1(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_161.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_164.uint_0, gstruct42_0.int_130);
		return num2 != 0;
	}

	public static string smethod_2(GStruct42 gstruct42_0, bool bool_0 = false)
	{
		string text = string.Empty;
		uint num = Class20.smethod_30(Class47.gstruct43_161.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_163.uint_0, gstruct42_0.int_130);
		if (num2 != 0)
		{
			for (uint num3 = 0u; num3 < 10; num3++)
			{
				uint num4 = Class20.smethod_30(num2 + num3 * 4, gstruct42_0.int_130);
				if (num4 == 0)
				{
					continue;
				}
				string text2 = Class20.smethod_28(num4, gstruct42_0.int_130, 78);
				if (text2 == null || text2 == string.Empty)
				{
					continue;
				}
				if (bool_0)
				{
					int num5 = (int)Class20.smethod_30(num4 + Class47.gstruct43_166.uint_0, gstruct42_0.int_130);
					if (num5 <= 0)
					{
						continue;
					}
					text2 = num5 + ";" + text2;
				}
				if (text != string.Empty)
				{
					text += "|";
				}
				text += text2;
			}
			return text;
		}
		return text;
	}
}
