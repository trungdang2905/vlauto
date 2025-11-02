using System;
using System.Threading;

internal class Class69
{
	public static bool bool_0 = false;

	public static uint uint_0 = 48u;

	public static uint smethod_0(GStruct42 gstruct42_0, uint uint_1)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		uint num = 0u;
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		if (num2 != 0 && Class47.gstruct43_94.uint_0 != 0)
		{
			uint num3 = num2 + Class47.gstruct43_94.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_14 + uint_1 * 4, array, 4, ref int_);
			num = BitConverter.ToUInt32(array, 0);
			if (num != 0)
			{
				uint num4 = num * 5 + Class47.gstruct43_96.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num3 + num4 * 4, array, 4, ref int_);
				int num5 = BitConverter.ToInt32(array, 0);
				if (num5 == uint_1)
				{
					return num;
				}
			}
			uint num6 = num3 + Class47.gstruct43_95.uint_0;
			uint num7 = 0u;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + 8, array, 4, ref int_);
			uint num8 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6, array, 4, ref int_);
			uint num9 = BitConverter.ToUInt32(array, 0);
			num = 0u;
			while (num7 < num8 && num9 != 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num9 + num7 * 8 + 4, array, 4, ref int_);
				num7 = BitConverter.ToUInt32(array, 0);
				if (num7 == 0)
				{
					break;
				}
				uint num4 = num7 * 5 + Class47.gstruct43_96.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num3 + num4 * 4, array, 4, ref int_);
				uint num10 = BitConverter.ToUInt32(array, 0);
				if (num10 == uint_1)
				{
					num = num7;
					break;
				}
			}
		}
		array = BitConverter.GetBytes(num);
		Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_14 + uint_1 * 4, array, 4, ref int_);
		return num;
	}

	public static bool smethod_1(GStruct42 gstruct42_0, uint uint_1)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (num != 0)
		{
			uint num2 = num + uint_1 * Class47.gstruct43_103.uint_0;
			uint uint_2 = num2 + Class47.gstruct43_103.uint_0 - 4;
			uint num3 = Class20.smethod_30(uint_2, gstruct42_0.int_130);
			return num3 == 0;
		}
		return false;
	}

	public static int smethod_2(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = num + Class47.gstruct43_95.uint_0;
		return (int)Class20.smethod_30(num2 + 4, gstruct42_0.int_130);
	}

	public static uint smethod_3(GStruct42 gstruct42_0, uint uint_1)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		if (num == 0)
		{
			return 0u;
		}
		num += Class47.gstruct43_94.uint_0 + uint_1 * 20;
		return Class20.smethod_30(num + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
	}

	public static uint smethod_4(GStruct42 gstruct42_0, uint uint_1)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		if (num != 0)
		{
			num += Class47.gstruct43_94.uint_0 + uint_1 * 20;
			return Class20.smethod_30(num + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
		}
		return 0u;
	}

	public static uint smethod_5(GStruct42 gstruct42_0, uint uint_1)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		if (num == 0)
		{
			return 0u;
		}
		num += Class47.gstruct43_94.uint_0 + uint_1 * 20;
		return Class20.smethod_30(num + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
	}

	public static string smethod_6(GStruct42 gstruct42_0, uint uint_1, uint uint_2 = 0u, bool bool_1 = false)
	{
		uint_2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (uint_2 != 0)
		{
			uint_2 += uint_1 * Class47.gstruct43_103.uint_0;
			string text = Class20.smethod_28(uint_2 + Class47.gstruct43_104.uint_0, gstruct42_0.int_130, 48);
			if (bool_1)
			{
				text = Class10.smethod_1(text, 1);
			}
			return text;
		}
		return string.Empty;
	}

	public static int smethod_7(GStruct42 gstruct42_0, uint uint_1)
	{
		if (Class47.gstruct43_105.uint_0 == 0)
		{
			return 0;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (num == 0)
		{
			return 0;
		}
		num += uint_1 * Class47.gstruct43_103.uint_0;
		return (int)Class20.smethod_30(num + Class47.gstruct43_105.uint_0, gstruct42_0.int_130);
	}

	public static int smethod_8(GStruct42 gstruct42_0, int int_0)
	{
		if (Class47.gstruct43_106.uint_0 != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			if (num != 0)
			{
				num = (uint)((int)num + int_0 * (int)Class47.gstruct43_103.uint_0);
				return (int)Class20.smethod_30(num + Class47.gstruct43_106.uint_0, gstruct42_0.int_130);
			}
			return 0;
		}
		return 0;
	}

	public static int smethod_9(GStruct42 gstruct42_0, int int_0)
	{
		if (Class47.gstruct43_107.uint_0 != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			if (num == 0)
			{
				return -1;
			}
			num = (uint)((int)num + int_0 * (int)Class47.gstruct43_103.uint_0);
			return (int)Class20.smethod_30(num + Class47.gstruct43_107.uint_0, gstruct42_0.int_130);
		}
		return -1;
	}

	public static uint smethod_10(GStruct42 gstruct42_0, uint uint_1)
	{
		if (Class47.gstruct43_108.uint_0 == 0)
		{
			return 0u;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (num != 0)
		{
			num += uint_1 * Class47.gstruct43_103.uint_0;
			return Class20.smethod_30(num + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
		}
		return 0u;
	}

	public static uint smethod_11(GStruct42 gstruct42_0, uint uint_1)
	{
		if (Class47.gstruct43_109.uint_0 == 0)
		{
			return 0u;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (num != 0)
		{
			num += uint_1 * Class47.gstruct43_103.uint_0;
			return Class20.smethod_30(num + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
		}
		return 0u;
	}

	public static int smethod_12(GStruct42 gstruct42_0, int int_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (num != 0)
		{
			num = (uint)((int)num + int_0 * (int)Class47.gstruct43_103.uint_0);
			return (int)Class20.smethod_30(num + Class47.gstruct43_110.uint_0, gstruct42_0.int_130);
		}
		return 0;
	}

	public static int smethod_13(GStruct42 gstruct42_0, int int_0)
	{
		if (Class47.gstruct43_111.uint_0 == 0)
		{
			return 0;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (num != 0)
		{
			num = (uint)((int)num + int_0 * (int)Class47.gstruct43_103.uint_0);
			return (int)Class20.smethod_30(num + Class47.gstruct43_111.uint_0, gstruct42_0.int_130);
		}
		return 0;
	}

	public static int smethod_14(GStruct42 gstruct42_0, int int_0)
	{
		if (Class47.gstruct43_112.uint_0 == 0)
		{
			return 0;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (num == 0)
		{
			return 0;
		}
		num = (uint)((int)num + int_0 * (int)Class47.gstruct43_103.uint_0);
		return (int)Class20.smethod_30(num + Class47.gstruct43_112.uint_0, gstruct42_0.int_130);
	}

	public static string smethod_15(GStruct42 gstruct42_0, int int_0)
	{
		if (Class47.gstruct43_113.uint_0 != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			if (num != 0)
			{
				num = (uint)((int)num + int_0 * (int)Class47.gstruct43_103.uint_0);
				return Class20.smethod_28(num + Class47.gstruct43_113.uint_0, gstruct42_0.int_130, 255);
			}
			return string.Empty;
		}
		return string.Empty;
	}

	public static uint[] smethod_16(GStruct42 gstruct42_0, int int_0, int int_1 = 0)
	{
		uint[] array = new uint[4];
		uint[] array2 = array;
		if (Class47.gstruct43_115.uint_0 == 0)
		{
			return array2;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (num == 0)
		{
			return array2;
		}
		num = (uint)((int)num + int_0 * (int)Class47.gstruct43_103.uint_0);
		array2[0] = Class20.smethod_30((uint)(num + Class47.gstruct43_115.uint_0 + int_1 * 16), gstruct42_0.int_130);
		array2[1] = Class20.smethod_30((uint)(num + Class47.gstruct43_115.uint_0 + int_1 * 16 + 4L), gstruct42_0.int_130);
		array2[2] = Class20.smethod_30((uint)(num + Class47.gstruct43_115.uint_0 + int_1 * 16 + 8L), gstruct42_0.int_130);
		array2[3] = Class20.smethod_30((uint)(num + Class47.gstruct43_115.uint_0 + int_1 * 16 + 12L), gstruct42_0.int_130);
		return array2;
	}

	public static int[] smethod_17(GStruct42 gstruct42_0, int int_0, int int_1 = 0)
	{
		int[] array = new int[4];
		int[] array2 = array;
		if (Class47.gstruct43_114.uint_0 != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			if (num == 0)
			{
				return array2;
			}
			num = (uint)((int)num + int_0 * (int)Class47.gstruct43_103.uint_0);
			array2[0] = (int)Class20.smethod_30((uint)(num + Class47.gstruct43_114.uint_0 + int_1 * 16), gstruct42_0.int_130);
			array2[1] = (int)Class20.smethod_30((uint)(num + Class47.gstruct43_114.uint_0 + int_1 * 16 + 4L), gstruct42_0.int_130);
			array2[2] = (int)Class20.smethod_30((uint)(num + Class47.gstruct43_114.uint_0 + int_1 * 16 + 8L), gstruct42_0.int_130);
			array2[3] = (int)Class20.smethod_30((uint)(num + Class47.gstruct43_114.uint_0 + int_1 * 16 + 12L), gstruct42_0.int_130);
			return array2;
		}
		return array2;
	}

	public static int[] smethod_18(GStruct42 gstruct42_0, uint uint_1)
	{
		int[] array = new int[2];
		int[] array2 = array;
		if (Class47.gstruct43_116.uint_0 != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			uint num2 = num + uint_1 * Class47.gstruct43_103.uint_0;
			array2[0] = (int)Class20.smethod_30(num2 + Class47.gstruct43_116.uint_0, gstruct42_0.int_130);
			array2[1] = (int)Class20.smethod_30(num2 + Class47.gstruct43_116.uint_0 + 4, gstruct42_0.int_130);
			return array2;
		}
		return array2;
	}

	public static int smethod_19(GStruct42 gstruct42_0, uint uint_1)
	{
		if (Class47.gstruct43_117.uint_0 == 0)
		{
			return 0;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		num += uint_1 * Class47.gstruct43_103.uint_0;
		return (int)Class20.smethod_30(num + Class47.gstruct43_117.uint_0, gstruct42_0.int_130);
	}

	public static bool smethod_20(GStruct42 gstruct42_0)
	{
		int num = (int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130);
		return num > 0;
	}

	public static int smethod_21(GStruct42 gstruct42_0, uint uint_1 = 3u)
	{
		int[] array = Class39.smethod_0(uint_1);
		int num = array[0] * array[1];
		uint num11 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int int_ = 0;
		byte[] array2 = new byte[1];
		byte[] array3 = new byte[4];
		int num3 = smethod_2(gstruct42_0);
		int num4 = 0;
		for (uint num5 = 0u; num5 < Class47.int_1; num5++)
		{
			if (0 < num3 && num3 <= num4)
			{
				break;
			}
			uint num6 = num2 + num5 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array3, 4, ref int_);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array3, 1, ref int_);
			if (array3[0] == 0)
			{
				continue;
			}
			uint num7 = smethod_0(gstruct42_0, num5);
			if (num7 == 0)
			{
				continue;
			}
			num4++;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num2 + num5 * Class47.gstruct43_103.uint_0 + Class47.gstruct43_104.uint_0, array2, 1, ref int_);
			if (array2[0] != 0)
			{
				uint num8 = smethod_3(gstruct42_0, num7);
				if (num8 == uint_1)
				{
					uint num9 = smethod_10(gstruct42_0, num5);
					uint num10 = smethod_11(gstruct42_0, num5);
					num -= (int)(num9 * num10);
				}
			}
		}
		return num;
	}

	public static uint[] smethod_22(GStruct42 gstruct42_0, uint uint_1, uint uint_2 = 1u, uint uint_3 = 1u)
	{
		int[] array = Class39.smethod_0(uint_1);
		int[,] array2 = new int[array[0], array[1]];
		int num = 0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int num4 = smethod_2(gstruct42_0);
		int num5 = 0;
		int int_ = 0;
		byte[] array3 = new byte[4];
		for (uint num6 = 1u; num6 < Class47.int_1; num6++)
		{
			if (0 < num4 && num4 <= num5)
			{
				break;
			}
			uint num7 = num3 + num6 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_103.uint_0 - 4, array3, 4, ref int_);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_104.uint_0, array3, 1, ref int_);
			if (array3[0] == 0)
			{
				continue;
			}
			uint num8 = smethod_0(gstruct42_0, num6);
			if ((int)num8 <= 0)
			{
				continue;
			}
			num5++;
			uint num9 = num2 + num8 * 20;
			uint num10 = Class20.smethod_30(num9 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if (num10 != uint_1)
			{
				continue;
			}
			int num11 = (int)Class20.smethod_30(num9 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
			int num12 = (int)Class20.smethod_30(num9 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
			int num13 = (int)Class20.smethod_30(num7 + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
			int num14 = (int)Class20.smethod_30(num7 + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
			if (num11 < 0 || num12 < 0 || num13 <= 0 || num14 <= 0)
			{
				continue;
			}
			num += num13 * num14;
			for (int i = 0; i < num13; i++)
			{
				for (int j = 0; j < num14; j++)
				{
					if (num11 + i < array[0] && num12 + j < array[1])
					{
						array2[num11 + i, num12 + j] = 1;
					}
				}
			}
		}
		if (array[0] * array[1] - num >= uint_2 * uint_3)
		{
			for (int k = 0; k < array[1]; k++)
			{
				for (int l = 0; l < array[0]; l++)
				{
					bool flag = true;
					for (int i = 0; i < uint_2; i++)
					{
						for (int j = 0; j < uint_3; j++)
						{
							if (l + i >= array[0] || k + j >= array[1] || array2[l + i, k + j] != 0)
							{
								flag = false;
								break;
							}
						}
						if (!flag)
						{
							break;
						}
					}
					if (flag)
					{
						return new uint[2]
						{
							(uint)l,
							(uint)k
						};
					}
				}
			}
		}
		return null;
	}

	public static int[,] smethod_23(GStruct42 gstruct42_0)
	{
		int[] array = Class39.smethod_0();
		int[,] array2 = new int[array[0], array[1]];
		int num = 0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int[,] array3 = new int[7, 3]
		{
			{
				-1,
				2,
				1
			},
			{
				-1,
				1,
				4
			},
			{
				-1,
				2,
				3
			},
			{
				-1,
				2,
				2
			},
			{
				-1,
				1,
				3
			},
			{
				-1,
				1,
				2
			},
			{
				-1,
				1,
				1
			}
		};
		byte[] array4 = new byte[4];
		int int_ = 0;
		int num4 = smethod_2(gstruct42_0);
		int num5 = 0;
		for (uint num6 = 1u; num6 < Class47.int_1; num6++)
		{
			if (num6 % 30u == 0)
			{
				Thread.Sleep(3);
			}
			if (0 < num4 && num4 <= num5)
			{
				break;
			}
			uint num7 = num3 + num6 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_103.uint_0 - 4, array4, 4, ref int_);
			if (BitConverter.ToInt32(array4, 0) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_104.uint_0, array4, 1, ref int_);
			if (array4[0] == 0)
			{
				continue;
			}
			uint num8 = smethod_0(gstruct42_0, num6);
			if ((int)num8 <= 0)
			{
				continue;
			}
			num5++;
			uint num9 = num2 + num8 * 20;
			uint num10 = Class20.smethod_30(num9 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if (num10 != 3)
			{
				continue;
			}
			int num11 = (int)Class20.smethod_30(num9 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
			int num12 = (int)Class20.smethod_30(num9 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
			int num13 = (int)Class20.smethod_30(num7 + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
			int num14 = (int)Class20.smethod_30(num7 + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
			if (num11 < 0 || num12 < 0 || num13 <= 0 || num14 <= 0)
			{
				continue;
			}
			num += num13 * num14;
			for (int i = 0; i < num13; i++)
			{
				for (int j = 0; j < num14; j++)
				{
					if (num11 + i < array[0] && num12 + j < array[1])
					{
						array2[num11 + i, num12 + j] = 1;
					}
				}
			}
		}
		int num15 = 0;
		int length = array3.GetLength(0);
		for (int k = 0; k < length; k++)
		{
			if (array3[k, 0] > 0)
			{
				continue;
			}
			int num16 = array3[k, 1];
			int num17 = array3[k, 2];
			if (array[0] * array[1] - num < num16 * num17)
			{
				continue;
			}
			for (int l = 0; l < array[1]; l++)
			{
				int num18 = 0;
				while (num18 < array[0])
				{
					bool flag = true;
					for (int i = 0; i < num16; i++)
					{
						for (int j = 0; j < num17; j++)
						{
							num15++;
							if (num15 > 50)
							{
								Thread.Sleep(10);
								num15 = 0;
							}
							if (num18 + i >= array[0] || l + j >= array[1] || array2[num18 + i, l + j] != 0)
							{
								flag = false;
								break;
							}
						}
						if (!flag)
						{
							break;
						}
					}
					if (!flag)
					{
						num18++;
						continue;
					}
					goto IL_035e;
				}
				continue;
				IL_035e:
				array3[k, 0] = 1;
				break;
			}
		}
		return array3;
	}

	public static uint smethod_24(GStruct42 gstruct42_0, uint uint_1)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num2 = uint_1 * Class47.gstruct43_103.uint_0;
		uint uint_2 = num + num2 + Class47.gstruct43_100.uint_0;
		return Class20.smethod_30(uint_2, gstruct42_0.int_130);
	}

	public static uint[] smethod_25(GStruct42 gstruct42_0, string string_0, bool bool_1 = false, uint uint_1 = 3u, bool bool_2 = false)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int int_ = 0;
		int int_2 = 80;
		byte[] byte_ = new byte[80];
		byte[] array = new byte[4];
		int num3 = smethod_2(gstruct42_0);
		int num4 = 0;
		uint num5 = 1u;
		uint num7;
		uint num8;
		while (true)
		{
			if (num5 < Class47.int_1 && (0 >= num3 || num3 > num4))
			{
				uint num6 = num2 + num5 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) == 0)
				{
					uint uint_2 = num6 + Class47.gstruct43_104.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, 1, ref int_);
					if (array[0] != 0)
					{
						num7 = smethod_0(gstruct42_0, num5);
						if ((int)num7 > 0)
						{
							num4++;
							if (!bool_2 || Class47.gstruct43_117.uint_0 == 0 || Class20.smethod_30(num6 + Class47.gstruct43_117.uint_0, gstruct42_0.int_130) == 0)
							{
								num8 = Class20.smethod_30(num + num7 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
								if (num8 == uint_1)
								{
									Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, byte_, int_2, ref int_);
									string text = Class10.smethod_3(byte_);
									if (text == string_0 || (!bool_1 && Class11.smethod_2(text, string_0) == 0))
									{
										break;
									}
								}
							}
						}
					}
				}
				num5++;
				continue;
			}
			return null;
		}
		uint num9 = Class20.smethod_30(num + num7 * 20 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
		uint num10 = Class20.smethod_30(num + num7 * 20 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
		return new uint[5]
		{
			num5,
			num9,
			num10,
			num8,
			num7
		};
	}

	public static int[] smethod_26(GStruct42 gstruct42_0, string[] string_0, int int_0 = 3)
	{
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				string_0[i] = string_0[i].ToLower();
			}
			int int_ = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			byte[] array3 = new byte[60];
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_102.uint_0, array2, 4, ref int_);
			uint num = BitConverter.ToUInt32(array2, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array2, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array2, 0) + Class47.gstruct43_94.uint_0;
			int num3 = smethod_2(gstruct42_0);
			int num4 = 0;
			for (uint num5 = 1u; num5 < Class47.int_1; num5++)
			{
				if (0 < num3 && num3 <= num4)
				{
					break;
				}
				uint num6 = num + num5 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array, 1, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				int num7 = (int)smethod_0(gstruct42_0, num5);
				if (num7 <= 0)
				{
					continue;
				}
				num4++;
				uint num8 = (uint)((int)num2 + num7 * 20);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_97.uint_0 - 8, array2, 4, ref int_);
				int num9 = BitConverter.ToInt32(array2, 0);
				if (int_0 > 0 && num9 != int_0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array, 1, ref int_);
				if (array[0] <= 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array3, array3.Length, ref int_);
				string text = Class10.smethod_3(array3).ToLower();
				char[] array4 = text.ToCharArray();
				int num10 = array4.Length;
				bool flag = true;
				for (int j = 0; j < string_0.Length; j++)
				{
					flag = true;
					char[] array5 = string_0[j].ToCharArray();
					for (int k = 0; k < array5.Length; k++)
					{
						if (num10 > k)
						{
							if (array5[k] != '?' && array4[k] != array5[k])
							{
								flag = false;
								break;
							}
							continue;
						}
						flag = false;
						break;
					}
					if (flag)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_105.uint_0, array2, 4, ref int_);
						int num11 = BitConverter.ToInt32(array2, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_107.uint_0, array2, 4, ref int_);
						int num12 = BitConverter.ToInt32(array2, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_97.uint_0 - 4, array2, 4, ref int_);
						int num13 = BitConverter.ToInt32(array2, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_97.uint_0, array2, 4, ref int_);
						int num14 = BitConverter.ToInt32(array2, 0);
						return new int[7]
						{
							(int)num5,
							num7,
							num13,
							num14,
							num9,
							num11,
							num12
						};
					}
				}
			}
			return null;
		}
		return null;
	}

	public static uint smethod_27(GStruct42 gstruct42_0, string string_0, bool bool_1 = false, uint uint_1 = 3u, bool bool_2 = false)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int int_ = 0;
		int int_2 = 80;
		byte[] byte_ = new byte[80];
		byte[] array = new byte[4];
		int num3 = smethod_2(gstruct42_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class47.int_1; num5++)
		{
			if (0 < num3 && num3 <= num4)
			{
				break;
			}
			uint num6 = num2 + num5 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
			if (BitConverter.ToInt32(array, 0) != 0)
			{
				continue;
			}
			uint uint_2 = num6 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			uint num7 = smethod_0(gstruct42_0, num5);
			if ((int)num7 <= 0)
			{
				continue;
			}
			num4++;
			if (bool_2 && Class47.gstruct43_117.uint_0 != 0 && Class20.smethod_30(num6 + Class47.gstruct43_117.uint_0, gstruct42_0.int_130) != 0)
			{
				continue;
			}
			uint num8 = Class20.smethod_30(num + num7 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if (num8 == uint_1)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, byte_, int_2, ref int_);
				string text = Class10.smethod_3(byte_);
				if (text == string_0 || (!bool_1 && Class11.smethod_2(text, string_0) == 0))
				{
					return num5;
				}
			}
		}
		return 0u;
	}

	public static int smethod_28(GStruct42 gstruct42_0, string string_0, int int_0 = 3, bool bool_1 = false)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		if (num != 0 && string_0 != null && !(string_0 == string.Empty))
		{
			string object_ = Class10.smethod_1(string_0.Trim(), 1).ToUpper();
			int num2 = 0;
			int int_ = 0;
			int int_2 = 80;
			byte[] byte_ = new byte[80];
			byte[] array = new byte[4];
			int num3 = smethod_2(gstruct42_0);
			int num4 = 0;
			for (uint num5 = 1u; num5 < Class47.int_1 && num3 > num4; num5++)
			{
				uint num6 = num + num5 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) != 0)
				{
					continue;
				}
				num4++;
				uint uint_ = num6 + Class47.gstruct43_104.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				uint num7 = smethod_0(gstruct42_0, num5);
				if ((int)num7 <= 0)
				{
					num4--;
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, byte_, int_2, ref int_);
				string text = Class10.smethod_3(byte_).Trim();
				if (text == string.Empty)
				{
					continue;
				}
				if (string_0 != string.Empty)
				{
					string string_ = Class10.smethod_1(text, 1).ToUpper();
					if (Class11.smethod_2(text, string_0) < 0 && Class11.smethod_2(string_, object_) < 0)
					{
						continue;
					}
				}
				uint num8 = smethod_3(gstruct42_0, num7);
				if (int_0 >= 0 && num8 != int_0)
				{
					continue;
				}
				if (bool_1)
				{
					if (smethod_7(gstruct42_0, num5) != 0)
					{
						int[] array2 = smethod_18(gstruct42_0, num5);
						num2 = ((array2[1] > 1) ? (num2 + array2[0]) : (num2 + 1));
					}
					else
					{
						num2++;
					}
				}
				else
				{
					num2++;
				}
			}
			return num2;
		}
		return 0;
	}

	public static string[] smethod_29(GStruct42 gstruct42_0, string[] string_0 = null, int int_0 = 3)
	{
		int int_ = 0;
		byte[] array = new byte[80];
		uint num8 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		string[] string_ = null;
		byte[] array2 = new byte[4];
		int int_2 = 0;
		int num2 = smethod_2(gstruct42_0);
		int num3 = 0;
		for (uint num4 = 1u; num4 < Class47.int_1 && (0 >= num2 || num2 > num3); num4++)
		{
			uint num5 = num + num4 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_2);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			uint uint_ = num5 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_104.uint_0, array2, 1, ref int_2);
			if (array2[0] == 0)
			{
				continue;
			}
			uint num6 = smethod_0(gstruct42_0, num4);
			if ((int)num6 <= 0)
			{
				continue;
			}
			num3++;
			if (int_0 > 0)
			{
				uint num7 = smethod_3(gstruct42_0, num6);
				if (num7 != int_0)
				{
					continue;
				}
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_);
			string text = Class10.smethod_3(array);
			bool flag = false;
			if (string_0 != null)
			{
				for (int i = 0; i < string_0.Length; i++)
				{
					if (text == string_0[i])
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				Class11.smethod_24(ref string_, text);
			}
		}
		return string_;
	}

	public static void smethod_30(GStruct42 gstruct42_0, ref string[] string_0, int int_0 = 3, int[] int_1 = null)
	{
		int int_2 = 0;
		byte[] array = new byte[80];
		uint num9 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		byte[] array2 = new byte[4];
		int int_3 = 0;
		int num2 = smethod_2(gstruct42_0);
		int num3 = 0;
		for (uint num4 = 1u; num4 < Class47.int_1 && (0 >= num2 || num2 > num3); num4++)
		{
			uint num5 = num + num4 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_3);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			uint uint_ = num5 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_104.uint_0, array2, 1, ref int_3);
			if (array2[0] == 0)
			{
				continue;
			}
			uint num6 = smethod_0(gstruct42_0, num4);
			if ((int)num6 <= 0)
			{
				continue;
			}
			num3++;
			if (int_0 > 0)
			{
				uint num7 = smethod_3(gstruct42_0, num6);
				if (num7 != int_0)
				{
					continue;
				}
			}
			bool flag = false;
			if (int_1 != null)
			{
				int num8 = (int)Class20.smethod_30(num5 + Class47.gstruct43_105.uint_0, gstruct42_0.int_130);
				for (int i = 0; i < int_1.Length; i++)
				{
					if (num8 == int_1[i])
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, array.Length, ref int_2);
			string text = Class10.smethod_3(array);
			if (string_0 == null)
			{
				string_0 = new string[1]
				{
					text
				};
				continue;
			}
			flag = false;
			if (string_0 != null)
			{
				for (int i = 0; i < string_0.Length; i++)
				{
					if (text == string_0[i])
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				Array.Resize(ref string_0, string_0.Length + 1);
				string_0[string_0.Length - 1] = text;
			}
		}
	}

	public static int smethod_31(GStruct42 gstruct42_0, string string_0, bool bool_1 = false, uint uint_1 = 3u)
	{
		if (string_0 == null)
		{
			return 0;
		}
		string[] string_ = string_0.Split('|');
		string[] array = Class10.smethod_5(ref string_, bool_0: true);
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int int_ = 0;
		int int_2 = 80;
		byte[] byte_ = new byte[80];
		int num3 = 0;
		byte[] array2 = new byte[4];
		int int_3 = 0;
		int num4 = smethod_2(gstruct42_0);
		int num5 = 0;
		for (uint num6 = 1u; num6 < Class47.int_1; num6++)
		{
			if (0 < num4 && num4 <= num5)
			{
				break;
			}
			uint num7 = num2 + num6 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_3);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			uint uint_2 = num7 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array2, 1, ref int_3);
			if (array2[0] == 0)
			{
				continue;
			}
			uint num8 = smethod_0(gstruct42_0, num6);
			if ((int)num8 <= 0)
			{
				continue;
			}
			num5++;
			uint num9 = Class20.smethod_30(num + num8 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if (num9 != uint_1)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, byte_, int_2, ref int_);
			string text = Class10.smethod_3(byte_).Trim();
			bool flag = false;
			if (bool_1 && string_ != null)
			{
				for (int i = 0; i < string_.Length; i++)
				{
					if (text == string_[i])
					{
						flag = true;
						break;
					}
				}
			}
			else if (!bool_1 && array != null)
			{
				string string_2 = Class10.smethod_1(text, 1).ToUpper();
				for (int i = 0; i < array.Length; i++)
				{
					if (0 <= Class11.smethod_2(string_2, array[i]))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				continue;
			}
			if (Class20.smethod_30(num7 + Class47.gstruct43_105.uint_0, gstruct42_0.int_130) != 0)
			{
				int num10 = (int)Class20.smethod_30(num7 + Class47.gstruct43_116.uint_0 + 4, gstruct42_0.int_130);
				if (num10 > 0)
				{
					int num11 = (int)Class20.smethod_30(num7 + Class47.gstruct43_116.uint_0, gstruct42_0.int_130);
					num3 += num11;
				}
				else
				{
					num3++;
				}
			}
			else
			{
				num3++;
			}
		}
		return num3;
	}

	public static int smethod_32(GStruct42 gstruct42_0, int int_0 = 2)
	{
		if (Class47.gstruct43_102.uint_0 != 0 && Class47.gstruct43_103.uint_0 != 0 && Class47.gstruct43_107.uint_0 != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			byte[] array = new byte[4];
			int int_ = 0;
			int num3 = smethod_2(gstruct42_0);
			int num4 = 0;
			for (uint num5 = 1u; num5 < Class47.int_1; num5++)
			{
				if (0 < num3 && num3 <= num4)
				{
					break;
				}
				uint num6 = num2 + num5 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) != 0)
				{
					continue;
				}
				uint uint_ = num6 + Class47.gstruct43_104.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				uint num7 = smethod_0(gstruct42_0, num5);
				if ((int)num7 <= 0)
				{
					continue;
				}
				num4++;
				uint num8 = Class20.smethod_30(num6 + Class47.gstruct43_107.uint_0, gstruct42_0.int_130);
				if (num8 == 10)
				{
					uint num9 = num + Class47.gstruct43_94.uint_0 + num7 * 20;
					if (int_0 < 0)
					{
						return (int)num5;
					}
					uint num10 = Class20.smethod_30(num9 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
					if (num10 == int_0)
					{
						return (int)num5;
					}
				}
			}
			return 0;
		}
		return -1;
	}

	public static bool smethod_33(GStruct42 gstruct42_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, uint uint_6, uint uint_7)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num2 = num + uint_1 * 20;
		uint num3 = 0u;
		long long_ = Class11.smethod_22();
		bool result = false;
		while (true)
		{
			num3 = Class20.smethod_30(num2 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if (num3 != 1)
			{
				if (Class11.smethod_23(long_) > 1000L)
				{
					break;
				}
				Class60.smethod_44(gstruct42_0, uint_3, uint_4, uint_2, uint_3, uint_4, uint_2);
				Thread.Sleep(100);
				continue;
			}
			long_ = Class11.smethod_22();
			while (true)
			{
				num3 = Class20.smethod_30(num2 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
				if (num3 != uint_5)
				{
					if (Class11.smethod_23(long_) <= 1500L)
					{
						Class60.smethod_44(gstruct42_0, uint_6, uint_7, uint_5, uint_6, uint_7, uint_5);
						Thread.Sleep(100);
						continue;
					}
					Class60.smethod_44(gstruct42_0, uint_3, uint_4, uint_2, uint_3, uint_4, uint_2);
					break;
				}
				result = true;
				break;
			}
			break;
		}
		return result;
	}

	public static bool smethod_34(GStruct42 gstruct42_0, uint[] uint_1, uint[] uint_2)
	{
		if (!smethod_20(gstruct42_0))
		{
			return true;
		}
		if (uint_1 == null)
		{
			uint_1 = new uint[2]
			{
				3u,
				4u
			};
		}
		uint num = 0u;
		uint[] array = null;
		int num2 = 0;
		while (true)
		{
			if (num2 < uint_2.Length)
			{
				num = uint_2[num2];
				array = smethod_22(gstruct42_0, num, uint_1[0], uint_1[1]);
				if (array == null)
				{
					break;
				}
				num2++;
				continue;
			}
			bool result = false;
			for (int i = 0; i < 5; i++)
			{
				Class60.smethod_44(gstruct42_0, array[0], array[1], num, array[0], array[1], num);
				Thread.Sleep(300);
				if (!smethod_20(gstruct42_0))
				{
					result = true;
					break;
				}
			}
			return result;
		}
		return false;
	}

	public static void smethod_35(GStruct42 gstruct42_0, int int_0, uint uint_1 = 0u, uint uint_2 = 0u)
	{
		if (uint_2 == 0)
		{
			uint_2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		}
		Class20.smethod_31((uint)(uint_2 + int_0 * 20 + Class47.gstruct43_98.uint_0), gstruct42_0.int_130, uint_1);
	}

	public static int smethod_36(GStruct42 gstruct42_0, uint uint_1)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int num3 = 0;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		uint num7 = 0u;
		byte[] array = new byte[4];
		int int_ = 0;
		int num8 = smethod_2(gstruct42_0);
		int num9 = 0;
		uint num10 = 1u;
		uint num11;
		while (true)
		{
			if (num10 < Class47.int_1)
			{
				if (num10 % 30u == 0)
				{
					Thread.Sleep(10);
				}
				if (0 >= num8 || num8 > num9)
				{
					num11 = num2 + num10 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num11 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) == 0)
					{
						uint uint_2 = num11 + Class47.gstruct43_104.uint_0;
						Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, 1, ref int_);
						if (array[0] != 0)
						{
							num4 = smethod_0(gstruct42_0, num10);
							if ((int)num4 > 0)
							{
								num9++;
								num5 = Class20.smethod_30(num + num4 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
								if (num5 == 1 || num5 == 2)
								{
									uint num12 = Class20.smethod_30(num11 + Class47.gstruct43_107.uint_0, gstruct42_0.int_130);
									if (num12 == uint_1)
									{
										break;
									}
								}
							}
						}
					}
					num10++;
					continue;
				}
			}
			return 0;
		}
		num6 = Class20.smethod_30(num + num4 * 20 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
		num7 = Class20.smethod_30(num + num4 * 20 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
		uint uint_3 = Class20.smethod_30(num11 + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
		uint uint_4 = Class20.smethod_30(num11 + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
		num3 = 0;
		uint[] array2 = smethod_22(gstruct42_0, 3u, uint_3, uint_4);
		smethod_33(gstruct42_0, num4, num5, num6, num7, 3u, array2[0], array2[1]);
		Thread.Sleep(350);
		do
		{
			if (smethod_20(gstruct42_0))
			{
				Class60.smethod_44(gstruct42_0, num6, num7, 3u, num6, num7, 3u);
				Thread.Sleep(600);
				num3++;
				continue;
			}
			return (int)num10;
		}
		while (num3 <= 3);
		return -1;
	}

	public static string smethod_37(GStruct42 gstruct42_0, uint uint_1, bool bool_1 = false)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int int_ = 0;
		byte[] array = new byte[1];
		uint num3 = 0u;
		uint num4 = 0u;
		byte[] array2 = new byte[4];
		int int_2 = 0;
		int num5 = smethod_2(gstruct42_0);
		int num6 = 0;
		for (uint num7 = 1u; num7 < Class47.int_1; num7++)
		{
			if (num7 % 30u == 0)
			{
				Thread.Sleep(10);
			}
			if (0 < num5 && num5 <= num6)
			{
				break;
			}
			uint num8 = num2 + num7 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_2);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			uint uint_2 = num8 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array2, 1, ref int_2);
			if (array2[0] == 0)
			{
				continue;
			}
			num3 = smethod_0(gstruct42_0, num7);
			if ((int)num3 <= 0)
			{
				continue;
			}
			num6++;
			num4 = Class20.smethod_30(num + num3 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if (num4 != 3)
			{
				continue;
			}
			uint num9 = Class20.smethod_30(num8 + Class47.gstruct43_107.uint_0, gstruct42_0.int_130);
			if (num9 != uint_1)
			{
				continue;
			}
			array = new byte[80];
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, array.Length, ref int_);
			string text = Class10.smethod_3(array);
			if (uint_1 == 3)
			{
				bool flag = Class11.smethod_2(text, "Th­îng") > 0;
				if ((bool_1 && !flag) || (!bool_1 && flag))
				{
					continue;
				}
			}
			return text;
		}
		return string.Empty;
	}

	public static GStruct46[] smethod_38(GStruct42 gstruct42_0, ref int int_0, ref int int_1)
	{
		int int_2 = 0;
		byte[] array = new byte[4];
		int num = smethod_2(gstruct42_0);
		int num2 = 0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num4 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int_1 = 0;
		int_0 = 0;
		string text = "ThÇn Hµnh Phï";
		string a = text.Replace(" ", string.Empty).ToLower();
		byte[] array2 = new byte[text.Length];
		byte[] array3 = new byte[60];
		int num5 = 0;
		int num6 = 7;
		GStruct46[] array4 = new GStruct46[7];
		for (uint num7 = 1u; num7 < Class47.int_1; num7++)
		{
			if (num <= num2)
			{
				break;
			}
			if (num6 <= num5 && int_1 > 0 && int_0 > 0)
			{
				break;
			}
			uint num8 = num4 + num7 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_2);
			if (BitConverter.ToInt32(array, 0) != 0)
			{
				continue;
			}
			uint uint_ = num8 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_2);
			if (array[0] == 0)
			{
				continue;
			}
			uint num9 = smethod_0(gstruct42_0, num7);
			if ((int)num9 <= 0)
			{
				continue;
			}
			num2++;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_105.uint_0, array, 4, ref int_2);
			int num10 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num3 + num9 * 20 + Class47.gstruct43_97.uint_0 - 8, array, 4, ref int_2);
			int num11 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_107.uint_0, array, 4, ref int_2);
			int num12 = BitConverter.ToInt32(array, 0);
			if (num10 == 0 && num11 == 2 && num12 == 10)
			{
				int_0 = (int)num7;
			}
			else if (num10 == 6 && num11 == 3 && int_1 <= 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array2, array2.Length, ref int_2);
				string b = Class10.smethod_3(array2).Replace(" ", string.Empty).ToLower();
				if (a == b)
				{
					int_1 = (int)num7;
				}
			}
			else if (num11 == 2 && num6 > num5 && (num12 < 3 || (4 < num12 && num12 < 9)))
			{
				array4[num5].int_0 = (int)num7;
				array4[num5].int_1 = num12;
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array3, array3.Length, ref int_2);
				array4[num5].string_0 = Class10.smethod_3(array3);
				num5++;
			}
		}
		return array4;
	}

	public static GStruct28[] smethod_39(GStruct42 gstruct42_0, GStruct46[] gstruct46_0, int int_0, int int_1)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int int_2 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		int num3 = 0;
		if (gstruct46_0 != null)
		{
			GStruct28[] array3 = new GStruct28[gstruct46_0.Length];
			int num4 = 0;
			while (true)
			{
				if (num4 < array3.Length)
				{
					uint int_3 = (uint)gstruct46_0[num4].int_0;
					if (int_3 != 0)
					{
						uint num5 = int_3 * Class47.gstruct43_103.uint_0 + num2;
						Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_2);
						if (BitConverter.ToInt32(array, 0) != 0)
						{
							break;
						}
						uint uint_ = num5 + Class47.gstruct43_104.uint_0;
						Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_2);
						if (array[0] == 0)
						{
							break;
						}
						int num6 = (int)smethod_0(gstruct42_0, int_3);
						if (num6 <= 0)
						{
							break;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_105.uint_0, array, 4, ref int_2);
						if (BitConverter.ToInt32(array, 0) != 0)
						{
							break;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_107.uint_0, array, 4, ref int_2);
						int num7 = BitConverter.ToInt32(array, 0);
						if (num7 != gstruct46_0[num4].int_1)
						{
							break;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, (uint)((int)num + num6 * 20 + (int)Class47.gstruct43_97.uint_0 - 8), array, 4, ref int_2);
						int num8 = BitConverter.ToInt32(array, 0);
						if (num8 != 2)
						{
							break;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array2, array2.Length, ref int_2);
						string text = Class10.smethod_3(array2);
						if (text != gstruct46_0[num4].string_0)
						{
							break;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_106.uint_0, array, 4, ref int_2);
						int int_4 = BitConverter.ToInt32(array, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_116.uint_0 + uint_0, array, 4, ref int_2);
						int int_5 = BitConverter.ToInt32(array, 0);
						int num9 = (int)Class20.smethod_30(num5 + Class47.gstruct43_116.uint_0, gstruct42_0.int_130);
						if (num9 > 0)
						{
							int num10 = (int)Class20.smethod_30(num5 + Class47.gstruct43_116.uint_0 + 4, gstruct42_0.int_130);
							if (num10 > 0 && num10 > num9)
							{
								if (int_1 <= 0 || num9 > int_1)
								{
									double num11 = num9 * 100 / num10;
									if ((int_0 <= 0 || !(num11 <= (double)int_0)) && (int_1 > 0 || int_0 > 0))
									{
										goto IL_033b;
									}
								}
								array3[num3].string_0 = text;
								array3[num3].int_4 = int_4;
								array3[num3].int_1 = num6;
								array3[num3].int_0 = (int)int_3;
								array3[num3].int_5 = int_5;
								array3[num3].int_2 = num9;
								array3[num3].int_3 = num10;
								num3++;
							}
						}
					}
					goto IL_033b;
				}
				if (num3 > 0)
				{
					Array.Resize(ref array3, num3);
					return array3;
				}
				return null;
				IL_033b:
				num4++;
			}
		}
		int num12 = 0;
		int num13 = smethod_2(gstruct42_0);
		int num14 = 0;
		byte[] array4 = new byte[29];
		GStruct28[] array5 = new GStruct28[num13];
		for (int i = 1; i < Class47.int_1 && (0 >= num13 || num13 > num14); i++)
		{
			uint num5 = (uint)(i * (int)Class47.gstruct43_103.uint_0 + (int)num2);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_2);
			if (BitConverter.ToInt32(array, 0) != 0)
			{
				continue;
			}
			uint uint_ = num5 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_2);
			if (array[0] == 0)
			{
				continue;
			}
			int num6 = (int)smethod_0(gstruct42_0, (uint)i);
			if (num6 <= 0)
			{
				continue;
			}
			num14++;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_105.uint_0, array, 4, ref int_2);
			if (BitConverter.ToInt32(array, 0) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_107.uint_0, array, 4, ref int_2);
			int num7 = BitConverter.ToInt32(array, 0);
			if (num7 == 3 || num7 == 4 || num7 > 8)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_106.uint_0, array, 4, ref int_2);
			int int_4 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_116.uint_0 + uint_0, array, 4, ref int_2);
			int int_5 = BitConverter.ToInt32(array, 0);
			int num9 = (int)Class20.smethod_30(num5 + Class47.gstruct43_116.uint_0, gstruct42_0.int_130);
			if (num9 <= 0)
			{
				continue;
			}
			int num10 = (int)Class20.smethod_30(num5 + Class47.gstruct43_116.uint_0 + 4, gstruct42_0.int_130);
			if (num10 <= 0 || num10 <= num9)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, (uint)((int)num + num6 * 20 + (int)Class47.gstruct43_97.uint_0 - 8), array, 4, ref int_2);
			int num8 = BitConverter.ToInt32(array, 0);
			if (num8 != 2)
			{
				continue;
			}
			if (int_1 <= 0 || num9 > int_1)
			{
				double num11 = num9 * 100 / num10;
				if ((int_0 <= 0 || !(num11 <= (double)int_0)) && (int_1 > 0 || int_0 > 0))
				{
					continue;
				}
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array4, array4.Length, ref int_2);
			array5[num12].string_0 = Class10.smethod_3(array4);
			array5[num12].int_4 = int_4;
			array5[num12].int_1 = num6;
			array5[num12].int_0 = i;
			array5[num12].int_5 = int_5;
			array5[num12].int_2 = num9;
			array5[num12].int_3 = num10;
			num12++;
		}
		if (num12 <= 0)
		{
			return null;
		}
		Array.Resize(ref array5, num12);
		return array5;
	}

	public static int[] smethod_40(GStruct42 gstruct42_0)
	{
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[25];
		string[] array4 = new string[3]
		{
			"th????a?ph",
			"h?i?th?nh?ph",
			"ÍÁµØ·û"
		};
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_102.uint_0, array2, 4, ref int_);
		uint num = BitConverter.ToUInt32(array2, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_11.uint_0, array2, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array2, 0) + Class47.gstruct43_94.uint_0;
		int num3 = smethod_2(gstruct42_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class47.int_1 && (0 >= num3 || num3 > num4); num5++)
		{
			uint num6 = num + num5 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			int num7 = (int)smethod_0(gstruct42_0, num5);
			if (num7 <= 0)
			{
				continue;
			}
			num4++;
			uint num8 = (uint)((int)num2 + num7 * 20);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_97.uint_0 - 8, array2, 4, ref int_);
			int num9 = BitConverter.ToInt32(array2, 0);
			if (num9 != 3)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_105.uint_0, array2, 4, ref int_);
			int num10 = BitConverter.ToInt32(array2, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_107.uint_0, array2, 4, ref int_);
			int num11 = BitConverter.ToInt32(array2, 0);
			if (num10 != 5 || num11 != 0)
			{
				if (num10 != 6 || num11 != 1)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array3, array3.Length, ref int_);
				bool flag = true;
				for (int i = 0; i < array4.Length; i++)
				{
					flag = true;
					char[] array5 = array4[i].ToCharArray();
					for (int j = 0; j < array5.Length; j++)
					{
						byte b = array3[j];
						char c = array5[j];
						if (c != '?' && b != c && (b < 65 || 90 < b || b + 32 != c))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_97.uint_0 - 4, array2, 4, ref int_);
			int num12 = BitConverter.ToInt32(array2, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_97.uint_0, array2, 4, ref int_);
			int num13 = BitConverter.ToInt32(array2, 0);
			return new int[4]
			{
				(int)num5,
				num7,
				num12,
				num13
			};
		}
		return null;
	}
}
