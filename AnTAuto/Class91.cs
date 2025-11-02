using System;
using System.Diagnostics;
using System.Threading;

internal class Class91
{
	public static int smethod_0(string string_0, string string_1, ref byte[] byte_0, ref uint[] uint_0, ref uint uint_1, string string_2, ref byte[] byte_1, ref uint[] uint_2, ref uint uint_3, string string_3, ref byte[] byte_2, ref uint[] uint_4, ref uint uint_5, string string_4)
	{
		uint_0 = null;
		uint_2 = null;
		uint_4 = null;
		byte_0 = null;
		byte_1 = null;
		byte_2 = null;
		if (string_2 == null || string_2 == string.Empty)
		{
			string_2 = ".text";
		}
		if (string_3 == null || string_3 == string.Empty)
		{
			string_3 = ".text";
		}
		if (string_4 == null || string_4 == string.Empty)
		{
			string_4 = ".text";
		}
		int[] array = Class20.smethod_24(string_0, string_1);
		if (array == null)
		{
			return -1;
		}
		Process process = null;
		int num = 0;
		long num2 = 0L;
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				Process processById = Process.GetProcessById(array[i]);
				if (num2 < processById.StartTime.Ticks)
				{
					process = processById;
					num = array[i];
					num2 = processById.StartTime.Ticks;
				}
			}
			catch
			{
			}
		}
		int num5;
		if (process != null && !Class20.smethod_52(process))
		{
			long num3 = 0L;
			uint num4 = 0u;
			num5 = Class20.OpenProcess(2035711, bool_0: false, num);
			int int_ = 0;
			while (!Class11.bool_0)
			{
				try
				{
					num4 = (uint)(int)process.MainModule.EntryPointAddress;
					uint_3 = Class20.smethod_37(num, "engine.dll");
					uint_5 = Class20.smethod_37(num, "lualibdll.dll");
					uint_1 = (uint)(int)process.MainModule.BaseAddress;
					if (uint_1 != 0 && num4 != 0 && uint_3 != 0 && uint_5 != 0)
					{
						break;
					}
				}
				catch
				{
				}
				num3++;
				if (num3 <= 3000L)
				{
					Class20.smethod_45(process);
					Thread.Sleep(1);
					Class20.smethod_43(process);
					continue;
				}
				return -2;
			}
			uint_0 = Class20.smethod_65(num5, uint_1, string_2);
			if (uint_0 == null || uint_0[0] == 0 || uint_0[1] == 0)
			{
				uint[] array2 = Class20.smethod_64(num5, uint_1);
				if (array2 == null || array2[0] == 0 || array2[1] == 0)
				{
					goto IL_05e7;
				}
				uint_0 = new uint[2]
				{
					array2[1],
					4096u
				};
			}
			uint_2 = Class20.smethod_65(num5, uint_3, string_3);
			if (uint_2 == null)
			{
				uint[] array2 = Class20.smethod_64(num5, uint_3);
				if (array2 == null || array2[0] == 0 || array2[1] == 0)
				{
					goto IL_05e7;
				}
				uint_2 = new uint[2]
				{
					array2[1],
					4096u
				};
			}
			uint_4 = Class20.smethod_65(num5, uint_5, string_4);
			if (uint_2 == null)
			{
				uint[] array2 = Class20.smethod_64(num5, uint_5);
				if (array2 == null || array2[0] == 0 || array2[1] == 0)
				{
					goto IL_05e7;
				}
				uint_4 = new uint[2]
				{
					array2[1],
					4096u
				};
			}
			byte_0 = new byte[uint_0[0]];
			bool flag;
			if (uint_0[0] >= int.MaxValue)
			{
				num3 = 0L;
				while (num3 < uint_0[0])
				{
					int num6 = int.MaxValue;
					if (num3 + 2147483647L > uint_0[0])
					{
						num6 = (int)(uint_0[1] - num3);
					}
					byte[] array3 = new byte[num6];
					flag = Class20.ReadProcessMemory(num5, (uint)(uint_1 + uint_0[1] + num3), array3, num6, ref int_);
					for (int j = 0; j < num6; j++)
					{
						byte_0[j + num3] = array3[j];
					}
					num3 += num6;
					if (flag)
					{
						continue;
					}
					goto IL_03bf;
				}
			}
			else if (!(flag = Class20.ReadProcessMemory(num5, uint_1 + uint_0[1], byte_0, byte_0.Length, ref int_)))
			{
				byte_0 = null;
				goto IL_05e7;
			}
			byte_1 = new byte[uint_2[0]];
			if (uint_2[0] >= int.MaxValue)
			{
				num3 = 0L;
				while (num3 < uint_2[0])
				{
					int num6 = int.MaxValue;
					if (num3 + 2147483647L > uint_2[0])
					{
						num6 = (int)(uint_2[1] - num3);
					}
					byte[] array3 = new byte[num6];
					int int_2 = 0;
					flag = Class20.ReadProcessMemory(num5, (uint)(uint_3 + uint_2[1] + num3), array3, num6, ref int_2);
					for (int j = 0; j < num6; j++)
					{
						byte_1[j + num3] = array3[j];
					}
					num3 += num6;
					if (flag)
					{
						continue;
					}
					goto IL_04ad;
				}
			}
			else
			{
				int int_2 = 0;
				if (!(flag = Class20.ReadProcessMemory(num5, uint_3 + uint_2[1], byte_1, byte_1.Length, ref int_2)))
				{
					uint_2 = null;
					byte_1 = null;
				}
			}
			byte_2 = new byte[uint_4[0]];
			if (uint_4[0] < int.MaxValue)
			{
				int int_2 = 0;
				if (!(flag = Class20.ReadProcessMemory(num5, uint_5 + uint_4[1], byte_2, byte_2.Length, ref int_2)))
				{
					uint_4 = null;
					byte_2 = null;
				}
			}
			else
			{
				num3 = 0L;
				while (num3 < uint_4[0])
				{
					int num6 = int.MaxValue;
					if (num3 + 2147483647L > uint_4[0])
					{
						num6 = (int)(uint_4[1] - num3);
					}
					byte[] array3 = new byte[num6];
					int int_2 = 0;
					flag = Class20.ReadProcessMemory(num5, (uint)(uint_3 + uint_4[1] + num3), array3, num6, ref int_2);
					for (int j = 0; j < num6; j++)
					{
						byte_2[j + num3] = array3[j];
					}
					num3 += num6;
					if (!flag)
					{
						uint_4 = null;
						byte_2 = null;
						break;
					}
				}
			}
			goto IL_05e7;
		}
		return -1;
		IL_05e7:
		bool value = byte_0 != null && byte_1 != null && uint_0 != null && uint_2 != null && uint_0[1] != 0 && uint_2[1] != 0;
		return num5 * Convert.ToByte(value);
		IL_04ad:
		uint_2 = null;
		byte_1 = null;
		goto IL_05e7;
		IL_03bf:
		byte_0 = null;
		goto IL_05e7;
	}

	public static bool smethod_1(ref GStruct43 gstruct43_0, string[,] string_0)
	{
		string b = Class11.smethod_7(gstruct43_0.string_0).ToString();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.GetLength(0); i++)
			{
				if (string_0[i, 0] == b)
				{
					gstruct43_0.uint_0 = Class11.smethod_13(string_0[i, 1]);
					return true;
				}
			}
		}
		return false;
	}

	private static string smethod_2(string[] string_0, string string_1, string string_2 = "", bool bool_0 = true)
	{
		string_1 = "[" + string_1 + "]";
		for (int i = 0; i < string_0.Length; i++)
		{
			if (Class11.smethod_2(string_0[i], string_1) >= 0)
			{
				string_2 = string_0[i].Replace(string_1, "").Trim();
				if (bool_0)
				{
					string_2.Replace(" ", "");
				}
				return string_2;
			}
		}
		return string_2;
	}

	public static long smethod_3(uint uint_0, byte[] byte_0, ref GStruct43 gstruct43_0, long long_0 = 0L, uint uint_1 = 0u, int int_0 = 0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		long result = 0L;
		byte[] array = null;
		gstruct43_0.uint_0 = 0u;
		while (true)
		{
			if (long_0 < 0L)
			{
				long_0 = 0L;
			}
			long num5 = long_0;
			if (num != 0)
			{
				array = Class11.smethod_10(gstruct43_0.string_2);
				num2 = gstruct43_0.byte_3;
				num3 = gstruct43_0.int_1;
				num4 = gstruct43_0.int_3;
			}
			else
			{
				array = Class11.smethod_10(gstruct43_0.string_1);
				num2 = gstruct43_0.byte_2;
				num3 = gstruct43_0.int_0;
				num4 = gstruct43_0.int_2;
			}
			gstruct43_0.uint_0 = 0u;
			gstruct43_0.byte_6 = null;
			gstruct43_0.uint_2 = uint_0;
			if (byte_0 == null || array == null)
			{
				break;
			}
			int num6 = array.Length;
			long num7 = byte_0.Length;
			int num8 = 0;
			if (gstruct43_0.byte_4 > 0 && uint_1 == 0)
			{
				uint_1 = 4194304u;
			}
			while (true)
			{
				int num9 = 0;
				while (num9 < num6)
				{
					byte b = byte_0[num5 + num9];
					if (array[num9] == 63 || array[num9] == b)
					{
						num9++;
						continue;
					}
					goto IL_0103;
				}
				num8++;
				if (num8 >= num2)
				{
					break;
				}
				goto IL_0103;
				IL_0103:
				num5++;
				if (num5 + num6 < num7)
				{
					continue;
				}
				goto IL_0125;
			}
			if (num4 > 0)
			{
				byte[] array2 = new byte[num4];
				for (int num9 = 0; num9 < num4; num9++)
				{
					array2[num9] = byte_0[num3 + num5 + num9];
				}
				if (array2.Length < 4)
				{
					byte[] array3 = new byte[4];
					for (int num9 = 0; num9 < array2.Length; num9++)
					{
						array3[num9] = array2[num9];
					}
					array2 = array3;
				}
				gstruct43_0.uint_0 = BitConverter.ToUInt32(array2, 0);
				if (gstruct43_0.byte_4 > 0)
				{
					if (gstruct43_0.int_4 > 0 && int_0 > 0)
					{
						gstruct43_0.uint_0 = Class20.smethod_30(gstruct43_0.uint_0, int_0);
					}
					gstruct43_0.uint_0 -= uint_1;
				}
				if (gstruct43_0.byte_5 > 0)
				{
					uint num10 = (uint)(num5 + num3 + gstruct43_0.uint_2);
					gstruct43_0.uint_0 += num10 + 4;
				}
			}
			else
			{
				gstruct43_0.uint_0 = (uint)(num3 + num5 + gstruct43_0.uint_2);
				if (gstruct43_0.byte_4 > 0 && uint_1 < gstruct43_0.uint_0)
				{
					gstruct43_0.uint_0 -= uint_1;
				}
			}
			if (gstruct43_0.int_8 > 0)
			{
				gstruct43_0.byte_6 = new byte[gstruct43_0.int_8];
				for (int i = 0; i < gstruct43_0.int_8; i++)
				{
					gstruct43_0.byte_6[i] = byte_0[num5 + i + num3 + gstruct43_0.int_7];
				}
			}
			if (gstruct43_0.byte_1 != null && gstruct43_0.byte_1[0] == 0)
			{
				byte b2 = 1;
				for (int i = 0; i < gstruct43_0.byte_1.Length - 1; i++)
				{
					byte b3 = byte_0[num5 + i + num3 + gstruct43_0.int_7];
					if (gstruct43_0.byte_1[i + 1] != 63)
					{
						if (gstruct43_0.byte_1[i + 1] != b3)
						{
							b2 = 0;
							break;
						}
					}
					else
					{
						gstruct43_0.byte_1[i + 1] = b3;
					}
				}
				gstruct43_0.byte_1[0] = b2;
			}
			result = num5;
			break;
			IL_0125:
			if (num != 0)
			{
				break;
			}
			num++;
		}
		return result;
	}

	private static string smethod_4(string string_0, int int_0, int int_1, int int_2)
	{
		if (string_0 == "")
		{
			return "";
		}
		char[] array = string_0.ToCharArray();
		string_0 = "";
		for (int i = 0; i < array.Length; i++)
		{
			int num = i % int_2 + int_1;
			string_0 += (char)((byte)array[i] + int_0 * num);
		}
		return string_0;
	}
}
