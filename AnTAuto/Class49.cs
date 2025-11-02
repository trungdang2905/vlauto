using System.Threading;

internal class Class49
{
	public static int smethod_0(GStruct42 gstruct42_0, uint[] uint_0 = null)
	{
		int int_ = gstruct42_0.int_129;
		long long_ = 0L;
		while (true)
		{
			Thread.Sleep(300);
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
			if (Class11.bool_0 || num < 0 || Class20.smethod_52(FormMain.gstruct42_0[num].process_0) || !FormMain.gstruct42_0[num].bool_36)
			{
				break;
			}
			gstruct42_0 = FormMain.gstruct42_0[num];
			uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
			uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num5 = num4 + num3;
			int num6 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
			int num7 = (int)Class20.smethod_30(num5 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			int num8 = (int)Class20.smethod_30(num5 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
			int num9 = Class73.smethod_40(gstruct42_0);
			if (num8 != 0 && num7 != 0 && num7 != 10 && num7 != 21 && num6 != 0 && num9 > 1)
			{
				uint[] array = new uint[2]
				{
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
					Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
				};
				if (array[0] == 0 || array[1] == 0)
				{
					continue;
				}
				uint_0 = Class37.smethod_9(array, num6, "DÞch quan");
				if (uint_0 != null)
				{
					long num10 = Class53.smethod_18(array, uint_0);
					if (num10 >= 90000L)
					{
						uint[,] array2 = Class44.smethod_1(num6, array, uint_0);
						if (array2 != null)
						{
							Class53.smethod_22(gstruct42_0, array2, array, uint_0, num6);
						}
						else if (!Class12.smethod_4(gstruct42_0) || Class11.smethod_23(long_) > 6000L)
						{
							Class12.smethod_1(gstruct42_0, uint_0);
							long_ = Class11.smethod_22();
						}
						continue;
					}
					int num11 = 0;
					while (num10 > 11500L && num11 < 10)
					{
						array = new uint[2]
						{
							Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						if (Class53.smethod_18(array, uint_0) <= 11500L)
						{
							break;
						}
						Class60.smethod_61(gstruct42_0, uint_0);
						Thread.Sleep(300);
						num11++;
					}
					return 1;
				}
				return -2;
			}
			return -1;
		}
		return 0;
	}
}
