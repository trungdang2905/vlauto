using System;
using System.Threading;

internal class Class39
{
	private static int int_0 = 0;

	public static int int_1 = 0;

	public static long[] long_0;

	public static int int_2;

	public static int[] int_3;

	public static int[] smethod_0(uint uint_0 = 3u)
	{
		int[,] array = new int[11, 3]
		{
			{
				1,
				1,
				1
			},
			{
				3,
				6,
				10
			},
			{
				4,
				6,
				10
			},
			{
				5,
				8,
				4
			},
			{
				7,
				9,
				1
			},
			{
				9,
				6,
				10
			},
			{
				10,
				6,
				10
			},
			{
				11,
				6,
				10
			},
			{
				12,
				6,
				4
			},
			{
				23,
				6,
				10
			},
			{
				2,
				6,
				6
			}
		};
		for (int i = 0; i < array.GetLength(0); i++)
		{
			if (uint_0 == array[i, 0])
			{
				return new int[2]
				{
					array[i, 1],
					array[i, 2]
				};
			}
		}
		return new int[2]
		{
			6,
			10
		};
	}

	public static bool smethod_1(uint uint_0)
	{
		int[] array = new int[6]
		{
			3,
			4,
			9,
			10,
			11,
			23
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (uint_0 == array[i])
			{
				return true;
			}
		}
		return false;
	}

	private static uint smethod_2(uint uint_0)
	{
		switch (uint_0)
		{
		case 2u:
			return 1u;
		case 3u:
			return 7u;
		case 4u:
			return 6u;
		case 5u:
			return 4u;
		case 6u:
			return 2u;
		case 8u:
			return 5u;
		case 10u:
			return 10u;
		default:
			return 11u;
		case 9u:
			return 9u;
		case 7u:
			return 0u;
		case 0u:
		case 1u:
			return 3u;
		}
	}

	public static bool smethod_3(GStruct42 gstruct42_0, string string_0 = null)
	{
		if (Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_168.uint_0, gstruct42_0.int_130) != 0)
		{
			string text = smethod_4(gstruct42_0);
			if (text != null && !(text == string.Empty))
			{
				string[] array = new string[2]
				{
					Class11.smethod_48("ᓥᓑᓟ"),
					Class11.smethod_48("ᓚᓖ")
				};
				string[] array2 = text.Split(' ', '"');
				int num = 0;
				while (true)
				{
					if (num < array2.Length)
					{
						int num2 = 0;
						while (num2 < array.Length)
						{
							if (!(array2[num].ToLower() == array[num2]))
							{
								num2++;
								continue;
							}
							goto IL_00c6;
						}
						num++;
						continue;
					}
					string[] array3 = new string[2]
					{
						"gâ",
						"nhËp"
					};
					for (int num2 = 0; num2 < array3.Length; num2++)
					{
						bool flag = false;
						for (num = 0; num < array2.Length; num++)
						{
							if (flag)
							{
								if (array2[num] == null || !(array2[num] != string.Empty))
								{
									continue;
								}
								goto IL_014f;
							}
							if (0 <= array2[num].ToLower().IndexOf(array3[num2]))
							{
								flag = true;
							}
						}
						continue;
						IL_014f:
						string_0 = array2[num];
						break;
					}
					break;
					IL_00c6:
					string_0 = array2[num];
					break;
				}
			}
			bool result;
			if (result = (string_0 != string.Empty && string_0 != null))
			{
				if (string_0[0] > '፻')
				{
					string_0 = Class11.smethod_48(string_0);
				}
				smethod_5(gstruct42_0, string_0, bool_0: true);
			}
			return result;
		}
		return false;
	}

	public static string smethod_4(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_6 != 0 && Class47.gstruct43_168.uint_0 != 0 && Class47.gstruct43_169.uint_0 != 0 && Class47.gstruct43_167.uint_0 != 0)
		{
			uint num = Class20.smethod_30(gstruct42_0.uint_6 + Class47.gstruct43_168.uint_0, gstruct42_0.int_130);
			if (num != 0)
			{
				uint num2 = num + Class47.gstruct43_169.uint_0 - 40;
				uint uint_ = num2 - 12;
				int int_ = 0;
				byte[] array = new byte[1];
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_);
				int num3 = array[0];
				if (num3 <= 0)
				{
					num3 = 1;
				}
				array = new byte[num3];
				Class20.ReadProcessMemory(gstruct42_0.int_130, num2, array, num3, ref int_);
				return Class10.smethod_3(array);
			}
			return string.Empty;
		}
		return string.Empty;
	}

	public static int smethod_5(GStruct42 gstruct42_0, string string_0, bool bool_0 = false)
	{
		if (gstruct42_0.uint_6 != 0 && Class47.gstruct43_168.uint_0 != 0 && Class47.gstruct43_169.uint_0 != 0 && Class47.gstruct43_167.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_6 + Class47.gstruct43_168.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			if (num == 0)
			{
				return 0;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_169.uint_0 + Class47.gstruct43_167.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			if (num2 == 0)
			{
				if (bool_0)
				{
					Class20.smethod_4(gstruct42_0.uint_4, 13u);
				}
				return 0;
			}
			byte[] array2 = Class11.smethod_41(string_0);
			byte[] array3 = new byte[1];
			byte[] byte_ = new byte[1]
			{
				(byte)string_0.Length
			};
			int num3 = 0;
			while (num3 <= 300 && array3[0] == 0)
			{
				num3++;
				Thread.Sleep(1);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num2, array3, 1, ref int_);
			}
			bool flag = Class20.WriteProcessMemory(gstruct42_0.int_130, num2 - 52, byte_, 1, ref int_);
			bool flag2 = Class20.WriteProcessMemory(gstruct42_0.int_130, num2, array2, array2.Length, ref int_);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num2 - 71, array3, 2, ref int_);
			if (array3[0] == 0)
			{
				array3[0] = 1;
				Class20.WriteProcessMemory(gstruct42_0.int_130, num2 - 71, array3, 1, ref int_);
			}
			if (bool_0)
			{
				Class20.smethod_4(gstruct42_0.uint_4, 13u);
			}
			return Convert.ToByte(flag2 && flag);
		}
		return -1;
	}

	public static string smethod_6(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.uint_6 != 0 && Class47.gstruct43_168.uint_0 != 0 && Class47.gstruct43_169.uint_0 != 0 && Class47.gstruct43_167.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_6 + Class47.gstruct43_168.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			if (num == 0)
			{
				return null;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num + Class47.gstruct43_169.uint_0 + Class47.gstruct43_167.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			if (num2 != 0)
			{
				int num3 = 0;
				byte[] array2 = new byte[1];
				while (num3 <= 300 && array2[0] == 0)
				{
					num3++;
					Thread.Sleep(1);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num2, array2, 1, ref int_);
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num2 - 52, array2, 1, ref int_);
				if (array2[0] == 0)
				{
					return string.Empty;
				}
				byte[] byte_ = new byte[array2[0]];
				Class20.ReadProcessMemory(gstruct42_0.int_130, num2, byte_, array2[0], ref int_);
				return Class10.smethod_3(byte_);
			}
			return null;
		}
		return null;
	}

	public static int smethod_7(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		int int_ = 0;
		byte[] array = new byte[1];
		int result = 256;
		int num3 = Class69.smethod_2(gstruct42_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < 600 && (0 >= num3 || num3 > num4); num5++)
		{
			uint num6 = num + num5 * Class47.gstruct43_103.uint_0;
			if (Class20.smethod_30(num6 + Class47.gstruct43_103.uint_0 - 4, gstruct42_0.int_130) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			uint num7 = Class69.smethod_0(gstruct42_0, num5);
			if (num7 != 0)
			{
				num4++;
				uint num8 = num2 + num7 * 20;
				switch (Class20.smethod_30(num8 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130))
				{
				case 10u:
					result = 311;
					continue;
				default:
					continue;
				case 11u:
					break;
				}
				result = 371;
				break;
			}
		}
		return result;
	}

	public static uint smethod_8(GStruct42 gstruct42_0, int int_4)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_12.uint_0;
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_263.uint_0, gstruct42_0.int_130);
		uint result = 0u;
		if (num2 != 0)
		{
			result = Class20.smethod_30((uint)((int)num2 + int_4 * 4), gstruct42_0.int_130);
		}
		return result;
	}

	public static bool smethod_9(GStruct42 gstruct42_0)
	{
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_175.uint_0 + Class47.gstruct43_176.uint_0 + Class47.gstruct43_177.uint_0;
		uint num = Class20.smethod_30(uint_, gstruct42_0.int_130);
		return num != 0;
	}

	public static int smethod_10(GStruct42 gstruct42_0)
	{
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_154.uint_0;
		uint num = Class20.smethod_30(uint_, gstruct42_0.int_130);
		if (num == 0)
		{
			return -1000;
		}
		uint uint_2 = num + Class47.gstruct43_155.uint_0;
		return (int)(Class20.smethod_30(uint_2, gstruct42_0.int_130) - 1);
	}

	public static void smethod_11(GStruct42 gstruct42_0)
	{
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_154.uint_0;
		uint num = Class20.smethod_30(uint_, gstruct42_0.int_130);
		if (num != 0)
		{
			uint uint_2 = num + Class47.gstruct43_155.uint_0;
			int int_ = 0;
			byte[] byte_ = new byte[4]
			{
				1,
				0,
				0,
				0
			};
			Class20.WriteProcessMemory(gstruct42_0.int_130, uint_2, byte_, 4, ref int_);
		}
	}

	public static bool smethod_12(GStruct42 gstruct42_0)
	{
		bool result;
		if (result = smethod_9(gstruct42_0))
		{
			Class20.smethod_4(gstruct42_0.uint_4, 27u);
			Thread.Sleep(999);
		}
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_147.uint_0;
		if ((int)Class20.smethod_30(uint_, gstruct42_0.int_130) > 0)
		{
			Class20.smethod_4(gstruct42_0.uint_4, 27u);
		}
		return result;
	}

	public static int smethod_13(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_180.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(num + Class47.gstruct43_152.uint_0, gstruct42_0.int_130);
		return (int)Class20.smethod_30(num2 + Class47.gstruct43_179.uint_0, gstruct42_0.int_130);
	}

	public static bool smethod_14(GStruct42 gstruct42_0, bool bool_0)
	{
		return Class60.smethod_106(gstruct42_0, bool_0);
	}

	public static uint[] smethod_15(GStruct42 gstruct42_0)
	{
		if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) != 0)
		{
			uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
			uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
			int num3 = Class69.smethod_2(gstruct42_0);
			int num4 = 0;
			int int_ = 0;
			byte[] array = new byte[4];
			uint num5 = 1u;
			uint num6;
			while (true)
			{
				if (num5 < Class47.int_1 && (0 >= num3 || num3 > num4))
				{
					num6 = num2 + num5 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) == 0)
					{
						uint num7 = Class69.smethod_0(gstruct42_0, num5);
						if ((int)num7 > 0)
						{
							num4++;
							uint num8 = num + num7 * 20;
							uint num9 = Class20.smethod_30(num8 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
							if (num9 == 1)
							{
								break;
							}
						}
					}
					num5++;
					continue;
				}
				return new uint[1];
			}
			uint num10 = Class20.smethod_30(num6 + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
			uint num11 = Class20.smethod_30(num6 + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
			return new uint[3]
			{
				num5,
				num10,
				num11
			};
		}
		return new uint[1];
	}

	private static int[] smethod_16(GStruct42 gstruct42_0, uint uint_0, uint uint_1, uint uint_2, int int_4, string string_0)
	{
		uint num = Class69.smethod_0(gstruct42_0, uint_2);
		uint num2 = Class69.smethod_3(gstruct42_0, num);
		if (num2 == int_4 && num != 0)
		{
			string string_ = Class69.smethod_6(gstruct42_0, uint_2, uint_1);
			if (!Class11.smethod_3(string_, string_0))
			{
				return null;
			}
			int[] array = Class69.smethod_18(gstruct42_0, uint_2);
			if (array[0] < array[1] && array[1] > 0)
			{
				int num3 = Class69.smethod_13(gstruct42_0, (int)uint_2);
				return new int[4]
				{
					(int)uint_2,
					(int)num,
					(int)num2,
					num3
				};
			}
			return null;
		}
		return null;
	}

	public static int smethod_17(GStruct42 gstruct42_0, uint uint_0, uint uint_1, string string_0, int int_4 = -1, bool bool_0 = false, bool bool_1 = false, bool bool_2 = false)
	{
		int result = 1;
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num3 = 0u;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		uint num9 = 0u;
		uint num10 = 0u;
		uint num11 = 0u;
		int int_5 = 0;
		byte[] array = new byte[80];
		uint[] array2 = null;
		string[] array3 = null;
		if (string_0 != null && string_0 != string.Empty)
		{
			array3 = string_0.Split('|');
		}
		byte[] array4 = new byte[4];
		int int_6 = 0;
		int num12 = Class69.smethod_2(gstruct42_0);
		int num13 = 0;
		smethod_22(gstruct42_0);
		num12 = Class69.smethod_2(gstruct42_0);
		num13 = 0;
		bool flag = smethod_1(uint_0) && smethod_1(uint_1) && uint_0 != uint_1;
		for (num3 = 1u; num3 < Class47.int_1 && (0 >= num12 || num12 > num13); num3++)
		{
			num4 = num2 + num3 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_103.uint_0 - 4, array4, 4, ref int_5);
			if (BitConverter.ToInt32(array4, 0) != 0)
			{
				continue;
			}
			uint uint_2 = num4 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array4, 1, ref int_6);
			if (array4[0] == 0)
			{
				continue;
			}
			num6 = Class69.smethod_0(gstruct42_0, num3);
			if ((int)num6 <= 0)
			{
				continue;
			}
			num13++;
			if (bool_1)
			{
				if (Class47.gstruct43_117.uint_0 == 0)
				{
					result = -5;
					break;
				}
				int num14 = (int)Class20.smethod_30(num4 + Class47.gstruct43_117.uint_0, gstruct42_0.int_130);
				if (num14 != -2)
				{
					continue;
				}
			}
			bool flag2;
			if (!(flag2 = (array3 == null)))
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, array.Length, ref int_5);
				string text = Class10.smethod_3(array);
				for (int i = 0; i < array3.Length; i++)
				{
					if (text == array3[i] || (!bool_0 && Class11.smethod_2(text, array3[i]) == 0))
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					continue;
				}
			}
			num5 = num + num6 * 20;
			num7 = Class20.smethod_30(num5 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if ((int)num7 <= 0 || num7 != uint_0)
			{
				continue;
			}
			num4 = num2 + num3 * Class47.gstruct43_103.uint_0;
			num8 = Class20.smethod_30(num5 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
			num9 = Class20.smethod_30(num5 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
			num10 = Class20.smethod_30(num4 + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
			num11 = Class20.smethod_30(num4 + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
			array2 = Class69.smethod_22(gstruct42_0, uint_1, num10, num11);
			if (array2 == null)
			{
				if (num10 <= 1 && num11 <= 1)
				{
					result = 0;
					break;
				}
				continue;
			}
			int j = 0;
			if (!flag)
			{
				if (bool_2)
				{
					int num15 = int_4;
					if (num15 <= 0)
					{
						num15 = 1;
					}
					int num16 = (int)Class20.smethod_30(num4 + Class47.gstruct43_116.uint_0, gstruct42_0.int_130);
					int num17 = (int)Class20.smethod_30(num4 + Class47.gstruct43_105.uint_0, gstruct42_0.int_130);
					int num18 = 0;
					while (!Class11.bool_0 && num16 > num15 && num17 > 1 && num18 <= 30 && Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) == 0)
					{
						if (num18 % 8 == 0)
						{
							Class60.smethod_71(gstruct42_0, num3, (uint)num15, 89);
						}
						Thread.Sleep(100);
						num18++;
					}
				}
				int num19 = 0;
				long long_ = 0L;
				for (; (int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) <= 0; Thread.Sleep(100))
				{
					if (Class11.smethod_23(long_) <= 1500L)
					{
						continue;
					}
					num19++;
					if (num19 <= 8)
					{
						Class60.smethod_44(gstruct42_0, num8, num9, num7, num8, num9, num7);
						long_ = Class11.smethod_22();
						continue;
					}
					goto IL_0611;
				}
				num19 = 0;
				long_ = 0L;
				while ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) > 0)
				{
					if (Class11.smethod_23(long_) > 3000L)
					{
						num19++;
						if (num19 > 5)
						{
							break;
						}
						Class60.smethod_44(gstruct42_0, array2[0], array2[1], uint_1, array2[0], array2[1], uint_1);
						long_ = Class11.smethod_22();
					}
					Thread.Sleep(100);
				}
				if ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) <= 0)
				{
					if (int_4 >= 0)
					{
						int_4--;
						if (int_4 <= 0)
						{
							result = 1;
							break;
						}
					}
					continue;
				}
				long_ = 0L;
				result = -3;
				while ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) > 0)
				{
					if (Class11.smethod_23(long_) > 3000L)
					{
						num19++;
						if (num19 > 5)
						{
							result = -4;
							break;
						}
						Class60.smethod_44(gstruct42_0, num8, num9, num7, num8, num9, num7);
						long_ = Class11.smethod_22();
					}
					Thread.Sleep(100);
				}
				break;
			}
			Class60.smethod_44(gstruct42_0, num8, num9, uint_0, array2[0], array2[1], uint_1);
			for (; j < 30; j++)
			{
				uint num20 = Class20.smethod_30(num5 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
				if (num7 != num20)
				{
					break;
				}
				Thread.Sleep(10);
			}
			if (int_4 >= 0)
			{
				int_4--;
				if (int_4 <= 0)
				{
					result = 1;
					break;
				}
			}
			continue;
			IL_0611:
			result = -2;
			break;
		}
		return result;
	}

	public static int smethod_18(GStruct42 gstruct42_0, uint uint_0 = 3u)
	{
		if ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) <= 0)
		{
			return 0;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = 0u;
		uint num3 = 0u;
		byte[] array = new byte[4];
		int int_ = 0;
		int num4 = Class69.smethod_2(gstruct42_0);
		int num5 = 0;
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_102.uint_0, array, 4, ref int_);
		uint num6 = BitConverter.ToUInt32(array, 0);
		uint num7 = 0u;
		for (uint num8 = 1u; num8 < Class47.int_1; num8++)
		{
			if (0 < num4 && num4 <= num5)
			{
				break;
			}
			num7 = num6 + num8 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
			if (BitConverter.ToInt32(array, 0) != 0)
			{
				continue;
			}
			uint uint_ = num7 + Class47.gstruct43_104.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			uint num9 = Class69.smethod_0(gstruct42_0, num8);
			if ((int)num9 > 0)
			{
				num5++;
				num3 = num + num9 * 20;
				uint num10 = Class20.smethod_30(num3 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
				if (num10 == 1)
				{
					num2 = num8;
					break;
				}
			}
		}
		if (num2 == 0)
		{
			return 0;
		}
		num7 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130) + num2 * Class47.gstruct43_103.uint_0;
		Class20.smethod_30(num3 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
		Class20.smethod_30(num3 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
		uint uint_2 = Class20.smethod_30(num7 + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
		uint uint_3 = Class20.smethod_30(num7 + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
		uint num11 = uint_0;
		uint[] array2 = Class69.smethod_22(gstruct42_0, num11, uint_2, uint_3);
		if (array2 == null)
		{
			num11 = 3u;
			array2 = Class69.smethod_22(gstruct42_0, 3u, uint_2, uint_3);
			if (array2 == null)
			{
				return -1;
			}
		}
		int num12 = 0;
		while ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) > 0)
		{
			if (num12 % 5 == 0)
			{
				Class60.smethod_44(gstruct42_0, array2[0], array2[1], num11, array2[0], array2[1], num11);
			}
			num12++;
			Thread.Sleep(100);
			if (num12 > 30)
			{
				break;
			}
		}
		return Convert.ToByte(Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) == 0);
	}

	public static int smethod_19(GStruct42 gstruct42_0, uint uint_0, uint uint_1, string string_0, int int_4 = -1, bool bool_0 = false, bool bool_1 = false)
	{
		int num = 1;
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num3 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		uint num9 = 0u;
		uint num10 = 0u;
		uint num11 = 0u;
		uint num12 = 0u;
		int int_5 = 0;
		byte[] array = new byte[80];
		uint[] array2 = null;
		long num13 = 0L;
		int num14 = 0;
		string[] array3 = null;
		if (string_0 != null && string_0 != string.Empty)
		{
			array3 = string_0.Split('|');
		}
		byte[] array4 = new byte[4];
		int int_6 = 0;
		int num15 = Class69.smethod_2(gstruct42_0);
		int num16 = 0;
		num4 = 1u;
		while (true)
		{
			if (num4 < Class47.int_1 && (0 >= num15 || num15 > num16))
			{
				num5 = num3 + num4 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_103.uint_0 - 4, array4, 4, ref int_6);
				if (BitConverter.ToInt32(array4, 0) == 0)
				{
					uint uint_2 = num5 + Class47.gstruct43_104.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array4, 1, ref int_6);
					if (array4[0] != 0)
					{
						num7 = Class69.smethod_0(gstruct42_0, num4);
						if ((int)num7 > 0)
						{
							num16++;
							if (bool_1 && Class47.gstruct43_117.uint_0 != 0)
							{
								int num17 = (int)Class20.smethod_30(num5 + Class47.gstruct43_117.uint_0, gstruct42_0.int_130);
								if (num17 != -2)
								{
									goto IL_051b;
								}
							}
							bool flag;
							if (!(flag = (array3 == null)))
							{
								Class20.ReadProcessMemory(gstruct42_0.int_130, uint_2, array, array.Length, ref int_5);
								string text = Class10.smethod_3(array);
								for (int i = 0; i < array3.Length; i++)
								{
									string text2 = array3[i];
									if (!(text2 == "*"))
									{
										bool flag2 = bool_0;
										int num18 = Class11.smethod_2(text2, "*");
										if (num18 > 0)
										{
											text2 = text2.Substring(0, num18);
											flag2 = false;
										}
										if (text == text2 || (!flag2 && Class11.smethod_2(text, text2) == 0))
										{
											flag = true;
											break;
										}
										continue;
									}
									flag = true;
									break;
								}
								if (!flag)
								{
									goto IL_051b;
								}
							}
							num6 = num2 + num7 * 20;
							num8 = Class20.smethod_30(num6 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
							if ((int)num8 > 0 && num8 == uint_0)
							{
								num5 = num3 + num4 * Class47.gstruct43_103.uint_0;
								num9 = Class20.smethod_30(num6 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
								num10 = Class20.smethod_30(num6 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
								num11 = Class20.smethod_30(num5 + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
								num12 = Class20.smethod_30(num5 + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
								array2 = Class69.smethod_22(gstruct42_0, uint_1, num11, num12);
								if (array2 == null)
								{
									if (num11 <= 1 && num12 <= 1)
									{
										num = 0;
										break;
									}
								}
								else
								{
									int num19 = 0;
									int num20 = (int)Class20.smethod_30(num5 + Class47.gstruct43_116.uint_0, gstruct42_0.int_130);
									int num21 = (int)Class20.smethod_30(num5 + Class47.gstruct43_105.uint_0, gstruct42_0.int_130);
									if (num20 > 0 && num21 > 1 && int_4 > 0 && num20 > int_4)
									{
										int num22 = 0;
										while (!Class11.bool_0 && Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) == 0)
										{
											if (num22 % 8 == 0)
											{
												Class60.smethod_71(gstruct42_0, num4, (uint)int_4, 89);
											}
											if (num22 <= 30)
											{
												Thread.Sleep(100);
												num22++;
												continue;
											}
											goto IL_053a;
										}
										num14 = int_4;
									}
									else
									{
										num13 = 0L;
										for (; (int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) <= 0; Thread.Sleep(100))
										{
											if (Class11.smethod_23(num13) <= 1500L)
											{
												continue;
											}
											num19++;
											if (num19 <= 8)
											{
												Class60.smethod_44(gstruct42_0, num9, num10, num8, num9, num10, num8);
												num13 = Class11.smethod_22();
												continue;
											}
											goto IL_05c2;
										}
										num14 = ((num20 <= 0 || num21 <= 1) ? (num14 + 1) : (num14 + num20));
									}
									num19 = 0;
									num13 = 0L;
									while ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) > 0)
									{
										if (Class11.smethod_23(num13) > 3000L)
										{
											num19++;
											if (num19 > 5)
											{
												break;
											}
											Class60.smethod_44(gstruct42_0, array2[0], array2[1], uint_1, array2[0], array2[1], uint_1);
											num13 = Class11.smethod_22();
										}
										Thread.Sleep(100);
									}
									if ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) > 0)
									{
										num13 = 0L;
										num = -3;
										while ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_0.int_130) > 0)
										{
											if (Class11.smethod_23(num13) > 3000L)
											{
												num19++;
												if (num19 > 5)
												{
													num = -4;
													break;
												}
												Class60.smethod_44(gstruct42_0, num9, num10, num8, num9, num10, num8);
												num13 = Class11.smethod_22();
											}
											Thread.Sleep(100);
										}
										break;
									}
									if (int_4 > 0 && num14 >= int_4)
									{
										num = 1;
										break;
									}
								}
							}
						}
					}
				}
				goto IL_051b;
			}
			num = ((num14 > 0) ? 1 : 2);
			break;
			IL_051b:
			num4++;
			continue;
			IL_05c2:
			num = -2;
			break;
			IL_053a:
			num = -5;
			break;
		}
		return num;
	}

	public static void smethod_20(int int_4)
	{
		if (int_0 <= 0)
		{
			int_0 = int_4;
			new Thread(smethod_21).Start();
		}
	}

	private static void smethod_21()
	{
		int num = 0;
		int num2 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		int_0 = 0;
		if (num2 < 0)
		{
			return;
		}
		FormMain.gstruct42_0[num2].bool_2 = !FormMain.gstruct42_0[num2].bool_2;
		if (FormMain.gstruct42_0[num2].bool_2)
		{
			num = FormMain.gstruct42_0[num2].int_129;
			GStruct42 gstruct42_ = FormMain.gstruct42_0[num2];
			Class60.smethod_50(gstruct42_, "Qu\u00a8ng ®å...");
			if ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_.int_130) > 0)
			{
				uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130) + Class47.gstruct43_94.uint_0;
				uint num4 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_.int_130);
				int int_ = 0;
				byte[] array = new byte[80];
				uint num5 = 0u;
				string text = null;
				byte[] array2 = new byte[4];
				int int_2 = 0;
				int num6 = Class69.smethod_2(gstruct42_);
				int num7 = 0;
				for (num5 = 1u; num5 < Class47.int_1; num5++)
				{
					if (0 < num6 && num6 <= num7)
					{
						break;
					}
					uint num8 = num4 + num5 * Class47.gstruct43_103.uint_0;
					Class20.ReadProcessMemory(gstruct42_.int_130, num8 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_2);
					if (BitConverter.ToInt32(array2, 0) != 0)
					{
						continue;
					}
					uint uint_ = num8 + Class47.gstruct43_104.uint_0;
					Class20.ReadProcessMemory(gstruct42_.int_130, uint_, array2, 1, ref int_2);
					if (array2[0] == 0)
					{
						continue;
					}
					uint num9 = Class69.smethod_0(gstruct42_, num5);
					if ((int)num9 > 0)
					{
						num7++;
						uint num10 = Class20.smethod_30(num3 + num9 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_.int_130);
						if (num10 == 1)
						{
							Class20.ReadProcessMemory(gstruct42_.int_130, uint_, array, array.Length, ref int_);
							text = Class10.smethod_3(array);
							break;
						}
					}
				}
				if (text == null)
				{
					Class60.smethod_50(gstruct42_, "<color=yellow>H·y cÇm 1 vËt phÈm, sau ®ã bÊm Ctrl + F ®Ó tiÕn hµnh vøt bá.");
				}
				else
				{
					num6 = Class69.smethod_2(gstruct42_);
					num7 = 0;
					num5 = 1u;
					while (true)
					{
						if (num5 < Class47.int_1)
						{
							num2 = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_.int_129);
							if (num2 < 0 || !FormMain.gstruct42_0[num2].bool_2)
							{
								Class60.smethod_50(gstruct42_, "KÕt thóc!");
								break;
							}
							gstruct42_ = FormMain.gstruct42_0[num2];
							int num11 = 0;
							while ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_.int_130) > 0)
							{
								if (num11 % 5 == 0)
								{
									Class60.smethod_118(gstruct42_);
								}
								Thread.Sleep(80);
								num11++;
								if (num11 <= 26)
								{
									continue;
								}
								goto IL_048c;
							}
							if (0 >= num6 || num6 > num7)
							{
								uint num8 = num4 + num5 * Class47.gstruct43_103.uint_0;
								Class20.ReadProcessMemory(gstruct42_.int_130, num8 + Class47.gstruct43_103.uint_0 - 4, array2, 4, ref int_2);
								if (BitConverter.ToInt32(array2, 0) == 0)
								{
									uint uint_ = num8 + Class47.gstruct43_104.uint_0;
									Class20.ReadProcessMemory(gstruct42_.int_130, uint_, array2, 1, ref int_2);
									if (array2[0] != 0)
									{
										uint num9 = Class69.smethod_0(gstruct42_, num5);
										if ((int)num9 > 0)
										{
											num7++;
											uint num10 = Class20.smethod_30(num3 + num9 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_.int_130);
											if (num10 == 3)
											{
												Class20.ReadProcessMemory(gstruct42_.int_130, uint_, array, array.Length, ref int_);
												string a = Class10.smethod_3(array);
												if (!(a != text))
												{
													uint num12 = Class20.smethod_30(num3 + num9 * 20 + Class47.gstruct43_97.uint_0 - 4, gstruct42_.int_130);
													uint num13 = Class20.smethod_30(num3 + num9 * 20 + Class47.gstruct43_97.uint_0, gstruct42_.int_130);
													num11 = 0;
													while ((int)Class20.smethod_30(Class47.gstruct43_120.uint_0, gstruct42_.int_130) <= 0)
													{
														if (num11 % 5 == 0)
														{
															Class60.smethod_44(gstruct42_, num12, num13, num10, num12, num13, num10);
														}
														Thread.Sleep(80);
														num11++;
														if (num11 <= 42)
														{
															continue;
														}
														goto IL_0472;
													}
												}
											}
										}
									}
								}
								num5++;
								continue;
							}
						}
						Class60.smethod_50(gstruct42_, "KÕt thóc!");
						break;
						IL_0472:
						Class60.smethod_50(gstruct42_, "<color=yellow>Kh«ng thÓ cÇm vËt phÈm " + text + ". KÕt thóc qu\u00a8ng ®å !");
						break;
						IL_048c:
						Class60.smethod_50(gstruct42_, "<color=yellow>Kh«ng thÓ qu\u00a8ng vËt phÈm " + text + ". KÕt thóc qu\u00a8ng ®å !");
						break;
					}
				}
			}
			else
			{
				Class60.smethod_50(gstruct42_, "<color=yellow>H·y cÇm 1 vËt phÈm, sau ®ã bÊm Ctrl + G ®Ó tiÕn hµnh vøt bá.");
			}
		}
		num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
		if (0 <= num2)
		{
			FormMain.gstruct42_0[num2].bool_2 = false;
		}
	}

	public static int smethod_22(GStruct42 gstruct42_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_120.uint_0, array, 4, ref int_);
		if (BitConverter.ToInt32(array, 0) <= 0)
		{
			return 0;
		}
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		int num3 = Class69.smethod_2(gstruct42_0);
		int num4 = 0;
		uint num5 = 1u;
		uint num8;
		while (true)
		{
			if (num5 < Class47.int_1 && (0 >= num3 || num3 > num4))
			{
				uint num6 = num2 + num5 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) == 0)
				{
					uint uint_ = num6 + Class47.gstruct43_104.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 1, ref int_);
					if (array[0] != 0)
					{
						uint num7 = Class69.smethod_0(gstruct42_0, num5);
						if ((int)num7 > 0)
						{
							num4++;
							num8 = num + num7 * 20;
							uint num9 = Class20.smethod_30(num8 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
							if (num9 == 1)
							{
								break;
							}
						}
					}
				}
				num5++;
				continue;
			}
			return 0;
		}
		uint num10 = num2 + num5 * Class47.gstruct43_103.uint_0;
		Class20.smethod_30(num8 + Class47.gstruct43_97.uint_0 - 4, gstruct42_0.int_130);
		Class20.smethod_30(num8 + Class47.gstruct43_97.uint_0, gstruct42_0.int_130);
		int uint_2 = (int)Class20.smethod_30(num10 + Class47.gstruct43_108.uint_0, gstruct42_0.int_130);
		int uint_3 = (int)Class20.smethod_30(num10 + Class47.gstruct43_109.uint_0, gstruct42_0.int_130);
		uint[] array2 = Class69.smethod_22(gstruct42_0, 3u, (uint)uint_2, (uint)uint_3);
		if (array2 == null)
		{
			return -1;
		}
		int num11 = 0;
		while (true)
		{
			if (num11 < 100)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, Class47.gstruct43_120.uint_0, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) <= 0)
				{
					break;
				}
				if (num11 % 30 == 0)
				{
					Class60.smethod_44(gstruct42_0, array2[0], array2[1], 3u, array2[0], array2[1], 3u);
				}
				num11++;
				Thread.Sleep(10);
				continue;
			}
			return -1;
		}
		return 1;
	}

	private static uint smethod_23(uint[,] uint_0, uint uint_1)
	{
		if (uint_0 != null)
		{
			for (int i = 0; i < uint_0.GetLength(0); i++)
			{
				if (uint_0[i, 0] == uint_1)
				{
					return uint_0[i, 1];
				}
			}
		}
		return 0u;
	}

	private static uint[,] smethod_24(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		byte[] array = new byte[4];
		int int_ = 0;
		int num3 = Class69.smethod_2(gstruct42_0);
		if (num3 > 0)
		{
			int num4 = 0;
			uint[,] array2 = new uint[num3, 2];
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
				if (array[0] != 0)
				{
					uint num7 = Class69.smethod_0(gstruct42_0, num5);
					if ((int)num7 > 0)
					{
						uint num8 = num + num7 * 20;
						uint num9 = Class20.smethod_30(num8 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
						array2[num4, 0] = num5;
						array2[num4, 1] = num9;
						num4++;
					}
				}
			}
			return array2;
		}
		return null;
	}

	public static void smethod_25()
	{
		int int_ = int_1;
		int_1 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || num < 0)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_48 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_48)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_48 = true;
					flag = true;
				}
				smethod_26(int_);
			}
			catch
			{
			}
		}
	}

	private static void smethod_26(int int_4)
	{
		GStruct42 gStruct = default(GStruct42);
		int i = 0;
		int num = 0;
		int int_5 = 0;
		int num2 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		bool flag = false;
		bool flag2 = false;
		uint[,] array3 = null;
		uint num3 = 0u;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		string text = null;
		string str = null;
		int num7 = -1;
		int num8 = -1;
		int num9 = -1;
		uint num10 = 0u;
		uint num11 = 1u;
		while (true)
		{
			i--;
			Thread.Sleep(10 + num2);
			if (i <= 0)
			{
				num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
				if (Class11.bool_0 || num < 0)
				{
					break;
				}
				i = 30;
			}
			gStruct = FormMain.gstruct42_0[num];
			uint num20;
			if (long_0 != null && long_0[0] == int_4 && gStruct.bool_36)
			{
				num2 = 0;
				uint num12 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
				uint num13 = Class20.smethod_30(num12 + Class47.gstruct43_13.uint_0, gStruct.int_130);
				uint num14 = num13 * Class47.gstruct43_15.uint_0;
				uint num15 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
				uint num16 = num15 + num14;
				int num17 = (int)Class20.smethod_30(num16 + Class47.gstruct43_50.uint_0, gStruct.int_130);
				int num18 = Class73.smethod_40(gStruct);
				if (num17 > 0 && num18 > 1)
				{
					int num19 = (int)Class20.smethod_30(num16 + Class47.gstruct43_55.uint_0, gStruct.int_130);
					if (num19 != 11 && num19 != 22)
					{
						num20 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130) + Class47.gstruct43_94.uint_0;
						num8 = int_4;
						if (Class11.smethod_23(long_0[2]) > 15000L)
						{
							Class60.smethod_50(gStruct, "<color=yellow>ChuyÓn ®å: <color=red>KÕt thóc !");
						}
						else
						{
							if (num7 != long_0[1])
							{
								str = ((long_0[1] <= 1L) ? "ChuyÓn ®å (size)" : "ChuyÓn ®å (tªn)");
								Class60.smethod_50(gStruct, "<color=yellow>" + str + ": <color=red>B¾t ®Çu chuyÓn vËt phÈm..");
								num7 = (int)long_0[1];
							}
							if (num3 != 0)
							{
								if (num4 != 0)
								{
									goto IL_02b1;
								}
								if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gStruct.int_130) != 0)
								{
									continue;
								}
								if (Class69.smethod_2(gStruct) != num9)
								{
									if (num8 == int_4)
									{
										long_0[2] = 0L;
									}
								}
								else
								{
									uint num21 = Class69.smethod_0(gStruct, num10);
									uint num22 = num20 + num21 * 20;
									num4 = Class20.smethod_30(num22 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
									if (num4 != num3)
									{
										goto IL_02b1;
									}
									long_0[2] = Class11.smethod_22();
								}
								goto IL_087a;
							}
							if (array3 != null)
							{
								if (!flag2 && num10 == 0)
								{
									Class60.smethod_50(gStruct, "<color=yellow>" + str + ": <color=red>H·y cÇm vËt phÈm mÉu.");
									flag2 = true;
								}
								if (num10 == 0 && Class20.smethod_30(Class47.gstruct43_120.uint_0, gStruct.int_130) != 0)
								{
									num10 = smethod_15(gStruct)[0];
								}
								if (num10 != 0)
								{
									num9 = Class69.smethod_2(gStruct);
									num3 = smethod_23(array3, num10);
									if (!flag)
									{
										Class60.smethod_50(gStruct, "<color=yellow>" + str + ": <color=red>H·y ®Æt vµo r­¬ng ®Ých.");
										flag = true;
									}
								}
								continue;
							}
							if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gStruct.int_130) != 0)
							{
								if (!flag)
								{
									Class60.smethod_50(gStruct, "<color=yellow>" + str + ": <color=red>H·y bá trªn tay xuèng råi lµm l¹i.");
									flag = true;
								}
								continue;
							}
							num10 = 0u;
							flag = false;
							array3 = smethod_24(gStruct);
							if (array3 != null)
							{
								continue;
							}
							num8 = int_4;
						}
					}
				}
				goto IL_0830;
			}
			num2 = 300;
			if (i > 2)
			{
				i = 2;
			}
			if (num8 == int_4)
			{
				num8 = -1;
				Class60.smethod_50(gStruct, "<color=yellow>ChuyÓn ®å: <color=red>KÕt thóc !");
			}
			goto IL_087a;
			IL_0526:
			uint num23;
			uint num24;
			uint[] array4 = Class69.smethod_22(gStruct, num4, num23, num24);
			uint num25;
			bool flag3;
			uint num29;
			uint num31;
			if (array4 != null)
			{
				uint num26 = Class20.smethod_30(num25 + Class47.gstruct43_97.uint_0 - 4, gStruct.int_130);
				uint num27 = Class20.smethod_30(num25 + Class47.gstruct43_97.uint_0, gStruct.int_130);
				i = 0;
				if (!flag3)
				{
					do
					{
						if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gStruct.int_130) == 0)
						{
							if (i % 80 == 0)
							{
								Class60.smethod_44(gStruct, num26, num27, num3, num26, num27, num3);
							}
							i++;
							Thread.Sleep(1);
							continue;
						}
						i = 0;
						while (Class20.smethod_30(Class47.gstruct43_120.uint_0, gStruct.int_130) != 0)
						{
							if (i % 80 == 0)
							{
								Class60.smethod_44(gStruct, array4[0], array4[1], num4, array4[0], array4[1], num4);
							}
							uint num28 = Class20.smethod_30(num25 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
							if (num28 == num4 || num28 != num3)
							{
								break;
							}
							i++;
							Thread.Sleep(1);
							if (i > 600)
							{
								Class60.smethod_44(gStruct, num26, num27, num3, num26, num27, num3);
								break;
							}
						}
						break;
					}
					while (i <= 300);
				}
				else
				{
					uint num30 = num29;
					for (; i < 1200; i++)
					{
						if (num30 == 1)
						{
							num30 = num4;
							num26 = array4[0];
							num27 = array4[1];
						}
						if (i % 100 == 0)
						{
							Class60.smethod_44(gStruct, num26, num27, num30, array4[0], array4[1], num4);
						}
						uint num28 = Class20.smethod_30(num25 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
						if (num28 == num4 || num28 != num3)
						{
							break;
						}
						num30 = num28;
						Thread.Sleep(1);
					}
				}
				num11 = num31 + 1;
				long_0[2] = Class11.smethod_22();
				continue;
			}
			goto IL_087a;
			IL_0830:
			if (num8 == int_4)
			{
				long_0[0] = 0L;
				num8 = -1;
			}
			goto IL_087a;
			IL_087a:
			num4 = 0u;
			num3 = 0u;
			num10 = 0u;
			num5 = 0u;
			num6 = 0u;
			text = null;
			array3 = null;
			flag = false;
			flag2 = false;
			num11 = 1u;
			Thread.Sleep(100);
			continue;
			IL_02b1:
			if (num10 == 0 || array3 == null)
			{
				goto IL_0830;
			}
			uint num32 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gStruct.int_130);
			if (text == null)
			{
				uint num33 = num32 + num10 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gStruct.int_130, num33 + Class47.gstruct43_108.uint_0, array, 4, ref int_5);
				num5 = BitConverter.ToUInt32(array, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num33 + Class47.gstruct43_109.uint_0, array, 4, ref int_5);
				num6 = BitConverter.ToUInt32(array, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num33 + Class47.gstruct43_104.uint_0, array2, array2.Length, ref int_5);
				text = Class10.smethod_3(array2);
			}
			flag3 = (smethod_1(num3) && smethod_1(num4) && num3 != num4);
			int num34 = Class69.smethod_2(gStruct);
			int num35 = 0;
			int num36 = 0;
			num31 = 0u;
			for (num31 = num11; num31 < Class47.int_1 && (0 >= num34 || (num34 > num35 && (num34 > num35 + num11 || num36 <= 50))); num31++)
			{
				uint num33 = num32 + num31 * Class47.gstruct43_103.uint_0;
				uint uint_ = num33 + Class47.gstruct43_103.uint_0 - 4;
				if (Class20.smethod_30(uint_, gStruct.int_130) == 0)
				{
					uint num37 = Class69.smethod_0(gStruct, num31);
					if ((int)num37 > 0)
					{
						num36 = 0;
						num35++;
						if (long_0[1] > 1L)
						{
							Class20.ReadProcessMemory(gStruct.int_130, num33 + Class47.gstruct43_104.uint_0, array2, array2.Length, ref int_5);
							if (Class10.smethod_3(array2) != text)
							{
								continue;
							}
						}
						num25 = num20 + num37 * 20;
						num29 = Class20.smethod_30(num25 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
						if (num29 != num3)
						{
							continue;
						}
						num23 = Class20.smethod_30(num33 + Class47.gstruct43_108.uint_0, gStruct.int_130);
						if (num23 != num5)
						{
							continue;
						}
						num24 = Class20.smethod_30(num33 + Class47.gstruct43_109.uint_0, gStruct.int_130);
						if (num24 != num6)
						{
							continue;
						}
						goto IL_0526;
					}
					num36++;
					continue;
				}
				num36++;
			}
			goto IL_087a;
		}
	}

	public static void smethod_27(int int_4, int int_5 = 0)
	{
		int num = 0;
		while (int_3[0] > 0 && num < 300)
		{
			num++;
			Thread.Sleep(10);
		}
		int_3[2] = int_5;
		int_3[1] = 0;
		int_3[0] = int_4;
		num = 0;
		int num2 = 0;
		int num3 = 0;
		while (!Class11.bool_0)
		{
			Thread.Sleep(30);
			num--;
			num3++;
			if (num <= 0)
			{
				num2 = Class71.smethod_3(FormMain.gstruct42_0, int_4);
				if (Class11.bool_0 || num2 < 0)
				{
					break;
				}
				num = 15;
			}
			if (!FormMain.gstruct42_0[num2].bool_3 || num3 > 100)
			{
				break;
			}
		}
	}

	public static void smethod_28()
	{
		int int_ = int_2;
		int_2 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || num < 0)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_49 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_49)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_49 = true;
					flag = true;
				}
				smethod_29(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_29(int int_4)
	{
		GStruct42 gStruct = default(GStruct42);
		int num = 0;
		int num2 = 0;
		int int_5 = 0;
		int num3 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			IL_0828:
			num--;
			Thread.Sleep(10 + num3);
			if (num <= 0)
			{
				num2 = Class71.smethod_3(FormMain.gstruct42_0, int_4);
				if (Class11.bool_0 || num2 < 0)
				{
					break;
				}
				num = 30;
			}
			gStruct = FormMain.gstruct42_0[num2];
			if (int_3[1] == int_4 || flag2)
			{
				if (flag && int_3[2] <= 0)
				{
					Class60.smethod_50(gStruct, "<color=yellow>Gop VP: <color=red>Ket thuc !");
				}
				int_3[1] = 0;
				flag = false;
				flag2 = false;
				FormMain.gstruct42_0[num2].bool_3 = false;
			}
			if (int_3[0] == int_4)
			{
				if (!flag && int_3[2] <= 0)
				{
					Class60.smethod_50(gStruct, "<color=yellow>Gop VP: <color=red>Bat dau...");
				}
				num3 = 0;
				int_3[0] = 0;
				flag = true;
				FormMain.gstruct42_0[num2].bool_3 = true;
			}
			if (!flag)
			{
				num3 = 300;
				continue;
			}
			uint num4 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
			uint num5 = Class20.smethod_30(num4 + Class47.gstruct43_13.uint_0, gStruct.int_130);
			uint num6 = num5 * Class47.gstruct43_15.uint_0;
			uint num7 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
			uint num8 = num7 + num6;
			int num9 = (int)Class20.smethod_30(num8 + Class47.gstruct43_50.uint_0, gStruct.int_130);
			int num10 = Class73.smethod_40(gStruct);
			if (num9 <= 0 || num10 <= 1)
			{
				continue;
			}
			int num11 = (int)Class20.smethod_30(num8 + Class47.gstruct43_55.uint_0, gStruct.int_130);
			if (num11 == 11 || num11 == 22)
			{
				continue;
			}
			uint num12 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130) + Class47.gstruct43_94.uint_0;
			int num13 = Class69.smethod_2(gStruct);
			int num14 = 0;
			int num15 = 0;
			uint[] uint_ = null;
			uint num16 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gStruct.int_130);
			for (uint num17 = 1u; num17 < Class47.int_1; num17++)
			{
				if (num13 > num14 && int_3[1] != int_4 && num15 <= 60)
				{
					uint num18 = num16 + num17 * Class47.gstruct43_103.uint_0;
					uint uint_2 = num18 + Class47.gstruct43_103.uint_0 - 4;
					if (Class20.smethod_30(uint_2, gStruct.int_130) == 0)
					{
						uint num19 = Class69.smethod_0(gStruct, num17);
						if ((int)num19 > 0)
						{
							num15 = 0;
							num14++;
							if ((int)Class20.smethod_30(num18 + Class47.gstruct43_105.uint_0, gStruct.int_130) <= 0)
							{
								continue;
							}
							int num20 = (int)Class20.smethod_30(num18 + Class47.gstruct43_116.uint_0, gStruct.int_130);
							int num21 = (int)Class20.smethod_30(num18 + Class47.gstruct43_116.uint_0 + 4, gStruct.int_130);
							if (num20 <= 0 || num21 <= 0 || num21 <= num20)
							{
								continue;
							}
							uint num22 = Class20.smethod_30(num12 + num19 * 20 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
							if (num22 != 3)
							{
								continue;
							}
							uint num23 = num12 + num19 * 20;
							uint num24 = Class20.smethod_30(num23 + Class47.gstruct43_97.uint_0 - 4, gStruct.int_130);
							uint num25 = Class20.smethod_30(num23 + Class47.gstruct43_97.uint_0, gStruct.int_130);
							uint num26 = Class20.smethod_30(num18 + Class47.gstruct43_108.uint_0, gStruct.int_130);
							uint num27 = Class20.smethod_30(num18 + Class47.gstruct43_109.uint_0, gStruct.int_130);
							if (num24 > 5 || num25 > 9 || num26 == 0 || num26 > 4 || num27 == 0 || num27 > 4)
							{
								continue;
							}
							Class20.ReadProcessMemory(gStruct.int_130, num18 + Class47.gstruct43_104.uint_0, array2, array2.Length, ref int_5);
							string text = Class10.smethod_3(array2);
							int num28 = 0;
							bool flag3 = false;
							int num29 = Class69.smethod_2(gStruct);
							int num30 = 0;
							for (uint num31 = 1u; num31 < Class47.int_1; num31++)
							{
								if (int_3[1] != int_4)
								{
									if (num21 <= num20 || num29 <= num30 || num28 > 60)
									{
										break;
									}
									uint num32 = num16 + num31 * Class47.gstruct43_103.uint_0;
									uint uint_3 = num32 + Class47.gstruct43_103.uint_0 - 4;
									if (Class20.smethod_30(uint_3, gStruct.int_130) != 0)
									{
										num28++;
										continue;
									}
									Class20.ReadProcessMemory(gStruct.int_130, num32 + Class47.gstruct43_104.uint_0, array, 1, ref int_5);
									if (array[0] != 0)
									{
										num30++;
										num28 = 0;
										if (num17 == num31 || array[0] != text[0] || (int)Class20.smethod_30(num32 + Class47.gstruct43_105.uint_0, gStruct.int_130) <= 0)
										{
											continue;
										}
										int num33 = (int)Class20.smethod_30(num32 + Class47.gstruct43_116.uint_0, gStruct.int_130);
										int num34 = (int)Class20.smethod_30(num32 + Class47.gstruct43_116.uint_0 + 4, gStruct.int_130);
										if (num33 <= 0 || num34 <= 0 || num34 <= num33)
										{
											continue;
										}
										if (uint_ != null)
										{
											bool flag4 = false;
											for (int i = 0; i < uint_.Length; i++)
											{
												if (uint_[i] == num31)
												{
													flag4 = true;
													break;
												}
											}
											if (flag4)
											{
												continue;
											}
										}
										uint num35 = Class20.smethod_30(num32 + Class47.gstruct43_108.uint_0, gStruct.int_130);
										uint num36 = Class20.smethod_30(num32 + Class47.gstruct43_109.uint_0, gStruct.int_130);
										if (num35 != num26 || num36 != num27)
										{
											continue;
										}
										uint num37 = Class69.smethod_0(gStruct, num31);
										uint num38 = Class20.smethod_30(num12 + num37 * 20 + Class47.gstruct43_97.uint_0 - 8, gStruct.int_130);
										if ((int)num37 <= 0 || num38 != 3)
										{
											continue;
										}
										uint num39 = num12 + num37 * 20;
										uint num40 = Class20.smethod_30(num39 + Class47.gstruct43_97.uint_0 - 4, gStruct.int_130);
										uint num41 = Class20.smethod_30(num39 + Class47.gstruct43_97.uint_0, gStruct.int_130);
										Class20.ReadProcessMemory(gStruct.int_130, num32 + Class47.gstruct43_104.uint_0, array2, text.Length + 3, ref int_5);
										string b = Class10.smethod_3(array2);
										if (text != b)
										{
											continue;
										}
										int num42 = 0;
										while (true)
										{
											if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gStruct.int_130) == 0)
											{
												if (num42 % 100 == 0)
												{
													Class60.smethod_44(gStruct, num40, num41, 3u, num40, num41, 3u);
												}
												num42++;
												Thread.Sleep(1);
												if (num42 > 300)
												{
													Class11.smethod_35(ref uint_, num31);
													break;
												}
												continue;
											}
											num42 = 0;
											while (true)
											{
												if (Class20.smethod_30(Class47.gstruct43_120.uint_0, gStruct.int_130) != 0)
												{
													if (num42 % 100 == 0)
													{
														Class60.smethod_44(gStruct, num24, num25, 3u, num24, num25, 3u);
													}
													num42++;
													Thread.Sleep(1);
													if (num42 > 400)
													{
														uint num43 = smethod_15(gStruct)[0];
														if (num43 == num17)
														{
															Class60.smethod_44(gStruct, num24, num25, 3u, num24, num25, 3u);
															Thread.Sleep(30);
														}
														Class60.smethod_44(gStruct, num40, num41, 3u, num40, num41, 3u);
														break;
													}
													continue;
												}
												num20 = (int)Class20.smethod_30(num18 + Class47.gstruct43_116.uint_0, gStruct.int_130);
												flag3 = true;
												break;
											}
											break;
										}
										Thread.Sleep(1);
									}
									else
									{
										num28++;
									}
									continue;
								}
								goto IL_0828;
							}
							if (flag3)
							{
								break;
							}
						}
						else
						{
							num15++;
						}
					}
					else
					{
						num15++;
					}
					continue;
				}
				flag2 = true;
				break;
			}
		}
	}

	static Class39()
	{
		long[] array = long_0 = new long[4];
		int_2 = 0;
		int_3 = new int[3];
	}
}
