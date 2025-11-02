using System;
using System.Threading;

internal class Class87
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
				if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || FormMain.gstruct42_0[num].int_125[0] <= 0)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_52 = false;
						FormMain.gstruct42_0[num].int_125[0] = 0;
						Class60.smethod_50(FormMain.gstruct42_0[num], "<color=green>KÕt thóc nhÆt qu¶ !");
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_52)
					{
						return;
					}
					flag = true;
					FormMain.gstruct42_0[num].bool_52 = true;
					Class60.smethod_50(FormMain.gstruct42_0[num], "<color=green>NhÆt qu¶ Hoµng Kim...");
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
		GStruct42 gStruct = default(GStruct42);
		bool flag = false;
		int num = 0;
		int int_2 = 0;
		byte[] array = new byte[4];
		byte[] array2 = null;
		string text = "Qu¶ H".ToLower();
		int num2 = 0;
		while (true)
		{
			num2--;
			Thread.Sleep(100);
			if (num2 <= 0)
			{
				num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
				if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || FormMain.gstruct42_0[num].int_125[0] <= 0)
				{
					break;
				}
			}
			gStruct = FormMain.gstruct42_0[num];
			DateTime now = DateTime.Now;
			int hour = now.Hour;
			int minute = now.Minute;
			int second = now.Second;
			long ticks = new TimeSpan(hour, minute, second).Ticks;
			long ticks2 = new TimeSpan(gStruct.int_125[2], gStruct.int_125[3], gStruct.int_125[4]).Ticks;
			uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
			uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gStruct.int_130);
			uint num5 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
			uint num6 = num5 + num4 * Class47.gstruct43_15.uint_0;
			long num7 = ticks2 - ticks;
			array2 = Class11.smethod_41(hour + "." + minute + "." + second + "(" + num7 / 10000000L + ")");
			Class20.WriteProcessMemory(gStruct.int_130, num6 + Class47.gstruct43_86.uint_0, array2, array2.Length, ref int_2);
			if (gStruct.int_125[1] > 0 && num7 > 0L)
			{
				continue;
			}
			uint uint_ = gStruct.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
			Class20.ReadProcessMemory(gStruct.int_130, uint_, array, 4, ref int_2);
			int num8 = BitConverter.ToInt32(array, 0);
			if (num8 <= 1)
			{
				continue;
			}
			uint[] uint_2 = new uint[2];
			uint[] uint_3 = new uint[2]
			{
				Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
				Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
			};
			array2 = new byte[20];
			int num9 = 0;
			int num10 = 0;
			long num11 = 0L;
			for (int i = 1; i < 256; i++)
			{
				if (num8 <= num9)
				{
					break;
				}
				uint num12 = (uint)((int)num5 + i * (int)Class47.gstruct43_15.uint_0);
				Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_16.uint_0, array, 4, ref int_2);
				if (array[0] == 0)
				{
					continue;
				}
				num9++;
				Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_52.uint_0, array, 4, ref int_2);
				uint num13 = BitConverter.ToUInt32(array, 0);
				if (num13 != 3)
				{
					continue;
				}
				Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_2);
				uint_2[0] = BitConverter.ToUInt32(array, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array, 4, ref int_2);
				uint_2[1] = BitConverter.ToUInt32(array, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num12 + Class47.gstruct43_16.uint_0, array2, array2.Length, ref int_2);
				string string_ = Class10.smethod_3(array2).ToLower();
				if (Class11.smethod_2(string_, text) >= 0)
				{
					num11 = Class53.smethod_18(uint_3, uint_2);
					if (num11 <= gStruct.int_125[5] * gStruct.int_125[5])
					{
						num10 = i;
						break;
					}
				}
			}
			if (num10 <= 0)
			{
				continue;
			}
			int j;
			for (j = 0; j < 5; j++)
			{
				uint_3 = new uint[2]
				{
					Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
					Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
				};
				long num14 = Class53.smethod_18(uint_3, uint_2);
				if (num14 <= 7500L)
				{
					break;
				}
				Class60.smethod_61(gStruct, uint_2);
				Thread.Sleep(150);
			}
			Class39.smethod_11(gStruct);
			Class20.WriteProcessMemory(gStruct.int_130, num6 + Class47.gstruct43_72.uint_0, BitConverter.GetBytes(num10), 4, ref int_2);
			flag = false;
			j = 0;
			while (j < 300)
			{
				int num15 = Class39.smethod_10(gStruct);
				array2 = Class11.smethod_41(num15.ToString());
				Class20.WriteProcessMemory(gStruct.int_130, num6 + Class47.gstruct43_86.uint_0, array2, array2.Length, ref int_2);
				if (num15 <= 0)
				{
					j++;
					Thread.Sleep(1);
					continue;
				}
				flag = true;
				break;
			}
			j = 0;
			while (flag && j < 12000)
			{
				text = Class86.smethod_15(gStruct, num10, ref uint_2);
				if (text != null && !(text == string.Empty))
				{
					int num15 = Class39.smethod_10(gStruct);
					flag = (0 < num15 && num15 < 89);
					array2 = Class11.smethod_41((num15 + 11).ToString());
					Class20.WriteProcessMemory(gStruct.int_130, num6 + Class47.gstruct43_86.uint_0, array2, array2.Length, ref int_2);
					j++;
					Thread.Sleep(1);
					continue;
				}
				num10 = 0;
				break;
			}
		}
	}
}
