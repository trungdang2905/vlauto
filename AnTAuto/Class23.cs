using System;
using System.Text;
using System.Threading;

internal class Class23
{
	public static int int_0 = 0;

	public static int int_1 = 1000;

	public static string string_0 = null;

	public static long long_0 = 0L;

	public static int int_2 = 0;

	public static void smethod_0()
	{
		int num = int_0;
		int num2 = int_1;
		string string_ = string_0;
		int_0 = 0;
		int num3 = Class71.smethod_3(FormMain.gstruct42_0, num);
		if (num3 < 0)
		{
			return;
		}
		GStruct42 gstruct42_ = FormMain.gstruct42_0[num3];
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] array2 = Class11.smethod_41(string_, bool_1: false);
		int num4 = Class60.smethod_3(gstruct42_, Class60.uint_16);
		if (num4 <= 0)
		{
			Class20.ReadProcessMemory(gstruct42_.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
			uint num5 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_.int_130, num5 + Class47.gstruct43_13.uint_0, array, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array, 0);
			uint num7 = num6 * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gstruct42_.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_);
			uint num8 = BitConverter.ToUInt32(array, 0);
			uint num9 = num8 + num7;
			Class60.smethod_2(gstruct42_, Class60.uint_16, 1, 4);
			long long_ = Class11.smethod_22();
			while (!Class11.bool_0 && Class11.smethod_23(long_) < num2)
			{
				num4 = Class60.smethod_3(gstruct42_, Class60.uint_16);
				if (num4 == 2)
				{
					Class60.smethod_2(gstruct42_, Class60.uint_16, 1, 4);
					int num10 = Class60.smethod_3(gstruct42_, Class60.uint_16 + 1);
					if (num10 <= 0)
					{
						break;
					}
					array2 = new byte[num10];
					Class20.ReadProcessMemory(gstruct42_.int_130, gstruct42_.uint_10 + Class60.uint_16 + 8, array2, array2.Length, ref int_);
					long_ = Class11.smethod_22();
				}
				Class20.WriteProcessMemory(gstruct42_.int_130, num9 + Class47.gstruct43_253.uint_0, array2, array2.Length, ref int_);
				Thread.Sleep(100);
			}
			Class60.smethod_2(gstruct42_, Class60.uint_16, 0, 4);
		}
		else
		{
			Class20.WriteProcessMemory(gstruct42_.int_130, gstruct42_.uint_10 + Class60.uint_16 + 8, array2, array2.Length, ref int_);
			Class60.smethod_2(gstruct42_, Class60.uint_16 + 1, (byte)array2.Length, 4);
			Class60.smethod_2(gstruct42_, Class60.uint_16, 2, 4);
		}
	}

	public static string smethod_1(GStruct42 gstruct42_0)
	{
		uint uint_ = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_185.uint_0;
		return Class20.smethod_28(uint_, gstruct42_0.int_130);
	}

	public static byte[] smethod_2(GStruct42 gstruct42_0, int int_3 = -1)
	{
		uint uint_ = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_185.uint_0;
		if (int_3 <= 0)
		{
			int_3 = 8;
		}
		int int_4 = 0;
		byte[] array = new byte[int_3];
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_4);
		return array;
	}

	public static string smethod_3(GStruct42 gstruct42_0)
	{
		uint uint_ = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_185.uint_0 + 60;
		return Class20.smethod_28(uint_, gstruct42_0.int_130);
	}

	public static bool smethod_4(GStruct42 gstruct42_0, uint uint_0)
	{
		if (gstruct42_0.uint_11 != 0 && Class47.gstruct43_192.uint_0 != 0 && gstruct42_0.uint_84 != 0)
		{
			if (Class20.smethod_31(gstruct42_0.uint_84 + 2, gstruct42_0.int_130, uint_0))
			{
				return Class60.smethod_12(gstruct42_0.int_130, gstruct42_0.uint_84);
			}
			return false;
		}
		return false;
	}

	public static void smethod_5(ref GStruct42 gstruct42_0, byte byte_0)
	{
		int int_ = 0;
		byte[] array = null;
		if (gstruct42_0.uint_28 != 0 && Class11.smethod_23(long_0) < 3000L)
		{
			goto IL_01ee;
		}
		goto IL_0250;
		IL_01ee:
		array = new byte[2];
		if (!Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_29, array, 2, ref int_))
		{
			gstruct42_0.uint_28 = 0u;
		}
		else
		{
			if (array[0] == 96 && array[1] == 198)
			{
				int num = 0;
				while (!Class11.bool_0)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_29 - 4, array, 1, ref int_);
					if (array[0] == 0)
					{
						break;
					}
					Thread.Sleep(100);
					num++;
					if (num > 10)
					{
						return;
					}
				}
				array = new byte[1]
				{
					byte_0
				};
				if (Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_29 + 30, array, 1, ref int_))
				{
					uint uint_ = 0u;
					uint num2 = Class20.CreateRemoteThread(gstruct42_0.int_130, IntPtr.Zero, 0u, gstruct42_0.uint_29, 0u, 0u, out uint_);
					Class20.WaitForSingleObject((IntPtr)(long)num2, 1000u);
					Class20.smethod_32((int)num2);
					long_0 = Class11.smethod_22();
				}
				else
				{
					Class11.smethod_24(ref Class11.string_14, "Lỗi: Không thể ghi Index màu.");
				}
				return;
			}
			if (array[0] + array[1] == 0)
			{
				Class20.smethod_2(gstruct42_0.int_130, gstruct42_0.uint_28);
			}
			gstruct42_0.uint_28 = 0u;
		}
		goto IL_0250;
		IL_0250:
		if (gstruct42_0.uint_28 != 0)
		{
			Class20.smethod_2(gstruct42_0.int_130, gstruct42_0.uint_28);
		}
		gstruct42_0.uint_28 = Class20.smethod_1(gstruct42_0.int_130, 1000u);
		if (gstruct42_0.uint_28 != 0)
		{
			gstruct42_0.uint_29 = gstruct42_0.uint_28 + 4;
			uint num3 = gstruct42_0.uint_6 + Class47.gstruct43_190.uint_0 - (gstruct42_0.uint_29 + 18);
			uint num4 = gstruct42_0.uint_6 + Class47.gstruct43_191.uint_0 + 45;
			uint num5 = gstruct42_0.uint_6 + Class47.gstruct43_191.uint_0 - (gstruct42_0.uint_29 + 58);
			string string_ = "60C605" + Class11.smethod_40(gstruct42_0.uint_28, 8, bool_1: false, bool_2: true) + "01B9" + Class11.smethod_40((gstruct42_0.uint_6 + Class47.gstruct43_189.uint_0).ToString(), 8, bool_1: false, bool_2: true) + "E8" + Class11.smethod_40(num3.ToString(), 8, bool_1: false, bool_2: true) + "8B C8 85C9 7E 2B C7 81 38 20 00 00 01 00 00 00 C7 81 3C 20 00 00 01 00 00 0066 C7 05" + Class11.smethod_40(num4.ToString(), 8, bool_1: false, bool_2: true) + "EB 13E8" + Class11.smethod_40(num5.ToString(), 8, bool_1: false, bool_2: true) + "66 C7 05" + Class11.smethod_40(num4.ToString(), 8, bool_1: false, bool_2: true) + "85 C9C605" + Class11.smethod_40(gstruct42_0.uint_28, 8, bool_1: false, bool_2: true) + "0061 C3";
			array = Class11.smethod_10(string_, bool_1: false);
			if (!Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_29, array, array.Length, ref int_))
			{
				Class11.smethod_24(ref Class11.string_14, "Lỗi: Không thể đổi màu.");
				return;
			}
			goto IL_01ee;
		}
	}

	public static bool smethod_6(GStruct42 gstruct42_0, string string_1 = null, uint uint_0 = 32769u, uint uint_1 = 4u, uint uint_2 = 0u)
	{
		if (gstruct42_0.uint_88 != 0 && Class47.gstruct43_187.uint_0 != 0)
		{
			if (string_1 != null && string_1 != string.Empty)
			{
				return Class60.smethod_73(gstruct42_0, string_1);
			}
			string_1 = smethod_3(gstruct42_0);
			if (string_1 != null && string_1 != string.Empty)
			{
				return Class60.smethod_73(gstruct42_0, string_1);
			}
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num5 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
			uint num2 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			int int_ = 0;
			uint num3 = 0u;
			byte[] array = new byte[15];
			while (true)
			{
				num3++;
				if (Class11.bool_0 || num3 > 255)
				{
					break;
				}
				uint num4 = num2 + num3 * Class47.gstruct43_15.uint_0;
				if (Class20.smethod_30(num4 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130) != 1)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_86.uint_0, array, 1, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_86.uint_0, array, array.Length, ref int_);
				string text = Class10.smethod_3(array);
				int_ = 3;
				int length = text.Length;
				while (int_ < length)
				{
					if (Class33.smethod_2(gstruct42_0).IndexOf("- l·nh") <= 0)
					{
						int_++;
						text = Encoding.UTF7.GetString(array, 0, int_);
						if (Class60.smethod_73(gstruct42_0, text, uint_0, uint_1, uint_2))
						{
							Thread.Sleep(300);
							string text2 = Class73.smethod_22(gstruct42_0);
							if (text2 != null && text2.IndexOf("kh«ng tån t¹i") <= 0)
							{
								Class73.smethod_23(gstruct42_0, "0K..");
								Thread.Sleep(300);
							}
							else
							{
								Class60.smethod_50(gstruct42_0, ".");
							}
							continue;
						}
						return false;
					}
					return true;
				}
			}
			return false;
		}
		return false;
	}

	public static void smethod_7()
	{
		int int_ = int_2;
		int_2 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_26)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_56 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_56)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_56 = true;
					flag = true;
				}
				smethod_8(int_);
			}
			catch
			{
			}
			Thread.Sleep(600);
		}
	}

	private static void smethod_8(int int_3)
	{
		GStruct42 gStruct = default(GStruct42);
		int num = 0;
		int int_4 = 0;
		byte[] array = new byte[4];
		long long_ = 0L;
		long long_2 = 0L;
		bool flag = false;
		while (true)
		{
			Thread.Sleep(400);
			num--;
			if (Class11.bool_0)
			{
				break;
			}
			if (num <= 0)
			{
				num = 3;
				int num2 = Class71.smethod_3(FormMain.gstruct42_0, int_3);
				if (num2 < 0 || !FormMain.gstruct42_0[num2].bool_26)
				{
					break;
				}
				gStruct = FormMain.gstruct42_0[num2];
				if (Class11.smethod_23(long_) > 45000L)
				{
					Class60.smethod_50(gStruct, "<bclr=blue><color=green>Tù ®éng cho phÐp vµo bang khi cã ac xin gia nhËp bang héi.");
					long_ = Class11.smethod_22();
				}
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_161.uint_0, array, 4, ref int_4);
				uint num3 = BitConverter.ToUInt32(array, 0);
				if (num3 == 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gStruct.int_130, num3 + Class47.gstruct43_163.uint_0, array, 4, ref int_4);
				uint num4 = BitConverter.ToUInt32(array, 0);
				if (num4 == 0)
				{
					continue;
				}
				string empty = string.Empty;
				for (uint num5 = 0u; num5 < 9; num5++)
				{
					Class20.ReadProcessMemory(gStruct.int_130, num4 + num5 * 4, array, 4, ref int_4);
					uint num6 = BitConverter.ToUInt32(array, 0);
					if (num6 == 0)
					{
						continue;
					}
					empty = Class20.smethod_28(num6, gStruct.int_130, 45);
					if (empty != null && !(empty == string.Empty))
					{
						string text = empty.ToLower();
						if (text.IndexOf("p gia nh") > 0 && text.IndexOf("p bang h") > 0)
						{
							Class60.smethod_50(gStruct, "<bclr=blue><color=yellow>" + empty);
							Thread.Sleep(300);
							Class60.smethod_17(gStruct, num6, 1);
							Thread.Sleep(1500);
							flag = true;
						}
					}
				}
				if (!flag && Class11.smethod_23(long_2) <= 45000L)
				{
					continue;
				}
				for (int i = 0; i < 10; i++)
				{
					if (Class46.smethod_2(gStruct) == string.Empty)
					{
						break;
					}
					Class60.smethod_12(gStruct.int_130, gStruct.uint_51);
					Thread.Sleep(150);
				}
				long_2 = Class11.smethod_22();
				flag = false;
			}
			else
			{
				Thread.Sleep(400);
			}
		}
	}
}
