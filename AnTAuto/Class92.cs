using System.Threading;

internal class Class92
{
	public static int int_0 = 0;

	public static void smethod_0()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_47 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_47)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_47 = true;
					flag = true;
				}
				smethod_1(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_1(int int_1)
	{
		GStruct42 gstruct42_ = default(GStruct42);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 3;
		long[,] array = new long[3, 4];
		long[,] array2 = new long[3, 4];
		int num5 = -1;
		int num6 = -1;
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			num--;
			Thread.Sleep(100);
			if (num <= num2)
			{
				num3 = Class71.smethod_3(FormMain.gstruct42_0, int_1);
				if (Class11.bool_0 || num3 < 0 || !FormMain.gstruct42_0[num3].bool_36)
				{
					break;
				}
				gstruct42_ = FormMain.gstruct42_0[num3];
				for (int i = 0; i < 3; i++)
				{
					array[0, i] = gstruct42_.int_133[i];
					array[1, i] = gstruct42_.int_134[i];
					array[2, i] = gstruct42_.int_135[i];
					array2[0, i] = gstruct42_.int_136[i];
					array2[1, i] = gstruct42_.int_137[i];
					array2[2, i] = gstruct42_.int_138[i];
				}
				flag2 = ((array[0, 0] > 0L && array[0, 1] > 0L) || (array[1, 0] > 0L && array[1, 1] > 0L) || (array[2, 0] > 0L && array[2, 1] > 0L) || (array2[0, 0] > 0L && array2[0, 1] > 0L) || (array2[1, 0] > 0L && array2[1, 1] > 0L) || (array2[2, 0] > 0L && array2[2, 1] > 0L));
				num = 10;
				num2 = 0;
			}
			if (!flag2)
			{
				num2 = 6;
				Thread.Sleep(300);
				continue;
			}
			uint num7 = 0u;
			if (!(flag = !flag))
			{
				if (num6 >= 0)
				{
					if (Class11.smethod_23(array2[num6, 3]) > array2[num6, 2])
					{
						int num8 = num6;
						while (true)
						{
							num6++;
							if (num4 <= num6)
							{
								num6 = 0;
							}
							if (array2[num6, 0] <= 0L || array2[num6, 1] <= 0L)
							{
								if (num8 != num6)
								{
									continue;
								}
								num6 = -1;
								break;
							}
							num7 = (uint)array2[num6, 1];
							break;
						}
					}
				}
				else
				{
					for (int i = 0; i < 3; i++)
					{
						if (array2[i, 0] > 0L && array2[i, 1] > 0L)
						{
							num6 = i;
							num7 = (uint)array2[i, 1];
							break;
						}
					}
				}
				if (num7 != 0)
				{
					Class60.smethod_30(gstruct42_, num7);
					Class67.smethod_14(gstruct42_, num7, bool_1: true);
					array2[num6, 3] = Class11.smethod_22();
					continue;
				}
			}
			if (num5 >= 0)
			{
				if (Class11.smethod_23(array[num5, 3]) > array[num5, 2])
				{
					int num8 = num5;
					while (true)
					{
						num5++;
						if (num4 <= num5)
						{
							num5 = 0;
						}
						if (array[num5, 0] <= 0L || array[num5, 1] <= 0L)
						{
							if (num8 != num5)
							{
								continue;
							}
							num5 = -1;
							break;
						}
						num7 = (uint)array[num5, 1];
						break;
					}
				}
			}
			else
			{
				for (int i = 0; i < 3; i++)
				{
					if (array[i, 0] > 0L && array[i, 1] > 0L)
					{
						num5 = i;
						num7 = (uint)array[i, 1];
						break;
					}
				}
			}
			if (num7 != 0)
			{
				Class60.smethod_29(gstruct42_, num7);
				Class67.smethod_14(gstruct42_, num7);
				array[num5, 3] = Class11.smethod_22();
			}
		}
	}
}
