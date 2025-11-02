using System;
using System.Threading;

internal class Class7
{
	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static int[] int_0 = null;

	public static GStruct20[] gstruct20_0 = null;

	public static string string_0 = "BhoAttack.txt";

	public static string string_1 = "BhoNoAttack.txt";

	public static string string_2 = "PlrNoAttack.txt";

	public static int int_1 = 0;

	public static int int_2 = 0;

	public static int int_3 = 0;

	public static string[] string_3 = null;

	public static string[] string_4 = null;

	public static uint[] uint_0 = null;

	public static uint[] uint_1 = null;

	public static string[] string_5 = null;

	public static string[] smethod_0(string string_6)
	{
		string string_7 = Class47.string_6 + "\\" + string_6;
		string text = Class11.smethod_28(string_7, 0, 0, 1);
		if (text != null && !(text == string.Empty))
		{
			string text2 = Class11.smethod_16(text);
			if (text2 != null && !(text2 == string.Empty))
			{
				return text2.Split('|');
			}
			return null;
		}
		return null;
	}

	public static void smethod_1(string[] string_6, string string_7)
	{
		string text = string.Empty;
		if (string_6 != null)
		{
			for (int i = 0; i < string_6.Length; i++)
			{
				if (string_6[i] != null && !(string_6[i] == string.Empty))
				{
					if (text != null && text != string.Empty)
					{
						text += "|";
					}
					text += string_6[i];
				}
			}
		}
		if (text != string.Empty)
		{
			text = Class11.smethod_17(text);
		}
		Class11.smethod_8(Class47.string_6);
		Class11.smethod_29(Class47.string_6 + "\\" + string_7, text, 1);
	}

	public static uint[] smethod_2(string[] string_6)
	{
		if (string_6 != null)
		{
			uint[] array = new uint[string_6.Length];
			for (int i = 0; i < string_6.Length; i++)
			{
				array[i] = Class11.smethod_7(string_6[i]);
			}
			return array;
		}
		return null;
	}

	public static bool smethod_3(GStruct42 gstruct42_0)
	{
		if (Class38.uint_0 == null)
		{
			return false;
		}
		int num = 1114;
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num3 = Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num5 = num4 + num3 * Class47.gstruct43_15.uint_0;
		int num6 = (int)Class20.smethod_30(num5 + Class47.gstruct43_54.uint_0, gstruct42_0.int_130);
		uint[] array;
		int int_;
		byte[] array2;
		uint num10;
		uint[] array3;
		uint num11;
		int num19;
		uint[] array4;
		uint[] array5;
		int num20;
		int num21;
		if (num6 > 0)
		{
			int num7 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
			array = new uint[2]
			{
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
			int_ = 0;
			array2 = new byte[4];
			uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
			Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array2, 4, ref int_);
			int num8 = BitConverter.ToInt32(array2, 0);
			int num9 = 0;
			num10 = 0u;
			array3 = null;
			num11 = Class20.smethod_30(Class11.uint_1, Class11.int_1);
			for (uint num12 = 1u; num12 < 256; num12++)
			{
				if (num8 <= num9)
				{
					break;
				}
				uint num13 = num4 + num12 * Class47.gstruct43_15.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_16.uint_0, array2, 4, ref int_);
				if (array2[0] == 0)
				{
					continue;
				}
				num9++;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_50.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) <= 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_52.uint_0, array2, 4, ref int_);
				int num14 = BitConverter.ToInt32(array2, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_43.uint_0, array2, 4, ref int_);
				int num15 = BitConverter.ToInt32(array2, 0);
				if (num14 != 1 || num15 <= 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_55.uint_0, array2, 4, ref int_);
				int num16 = BitConverter.ToInt32(array2, 0);
				if (num16 != 10 && num16 != 21)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, num13, array2, 4, ref int_);
					int num17 = BitConverter.ToInt32(array2, 0);
					if (num17 != -1 && num17 != 0)
					{
						try
						{
							if (Class38.uint_0 == null)
							{
								return false;
							}
							for (int i = 0; i < Class38.uint_0.Length; i++)
							{
								if (num17 == Class38.uint_0[i])
								{
									if (num17 == Class38.gstruct29_0.uint_2)
									{
										num10 = num12;
									}
									if (array3 != null)
									{
										int num18 = array3.Length;
										Array.Resize(ref array3, num18 + 1);
										array3[num18] = num12;
									}
									else
									{
										array3 = new uint[1]
										{
											num12
										};
									}
									break;
								}
							}
						}
						catch
						{
							return false;
						}
					}
				}
			}
			if (array3 != null)
			{
				num19 = -1;
				array4 = new uint[2];
				array5 = new uint[2];
				num20 = (int)Class20.smethod_30(num2 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
				num21 = 400;
				if (gstruct42_0.int_97[1] == num)
				{
					num21 = 470;
				}
				if (gstruct42_0.int_97[2] != 0 || num10 == 0 || Class38.gstruct29_0.int_3 <= 0 || Class38.gstruct29_0.int_4 != num7)
				{
					goto IL_06d5;
				}
				if (num20 != num10 && num11 != 0 && Class38.int_0 == 0)
				{
					int int_2 = Class38.gstruct29_0.int_1;
					uint num22 = Class20.smethod_30(Class47.gstruct43_27.uint_0, int_2);
					if (num22 == num7)
					{
						uint num23 = Class20.smethod_30(Class47.gstruct43_11.uint_0, int_2);
						uint num24 = Class20.smethod_30(num23 + Class47.gstruct43_13.uint_0, int_2) * Class47.gstruct43_15.uint_0;
						uint num25 = Class20.smethod_30(Class47.gstruct43_14.uint_0, int_2);
						uint num26 = num25 + num24;
						int num27 = (int)Class20.smethod_30(num26 + Class47.gstruct43_43.uint_0, int_2);
						int num28 = (int)Class20.smethod_30(num26 + Class47.gstruct43_54.uint_0, int_2);
						if (num27 > 0 && num28 == num6)
						{
							int num29 = 0;
							while (num29 < 10)
							{
								array4[0] = Class20.smethod_30(num26 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, int_2);
								array4[1] = Class20.smethod_30(num26 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, int_2);
								array[0] = Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130);
								array[1] = Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130);
								long num30 = Class53.smethod_18(array, array4);
								if (num30 <= 1000000L)
								{
									if ((num29 == 0 && num30 <= num21 * num21) || num30 < 22500L)
									{
										break;
									}
									int int_3 = gstruct42_0.int_130;
									uint uint_2 = num5 + Class47.gstruct43_72.uint_0;
									byte[] byte_ = new byte[4];
									Class20.WriteProcessMemory(int_3, uint_2, byte_, 4, ref int_);
									Class60.smethod_61(gstruct42_0, array4);
									Thread.Sleep(150);
									num29++;
									continue;
								}
								goto IL_06d2;
							}
							long num31 = Class20.smethod_30(num26 + Class47.gstruct43_45.uint_0, int_2);
							long num32 = Class20.smethod_30(num26 + Class47.gstruct43_47.uint_0, int_2);
							long num33 = Class20.smethod_30(num26 + Class47.gstruct43_47.uint_0 + 4, int_2);
							if (num33 > num32 && num33 < 300000L)
							{
								num32 = num33;
							}
							if (num32 > 100L)
							{
								long num34 = 100L * num31 / num32;
								if (num34 <= gstruct42_0.int_97[3] || gstruct42_0.int_97[3] > 99)
								{
									num19 = (int)num10;
									array5[0] = array4[0];
									array5[1] = array4[1];
									goto IL_0a41;
								}
							}
						}
					}
					goto IL_06d2;
				}
				goto IL_0944;
			}
			return false;
		}
		return false;
		IL_0944:
		Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_43.uint_0, array2, 4, ref int_);
		if (BitConverter.ToInt32(array2, 0) > 0)
		{
			array5[0] = array[0];
			array5[1] = array[1];
			if (gstruct42_0.int_97[3] > 99)
			{
				num19 = num20;
			}
			else
			{
				long num31 = Class20.smethod_30(num5 + Class47.gstruct43_45.uint_0, gstruct42_0.int_130);
				long num32 = Class20.smethod_30(num5 + Class47.gstruct43_47.uint_0, gstruct42_0.int_130);
				long num33 = Class20.smethod_30(num5 + Class47.gstruct43_47.uint_0 + 4, gstruct42_0.int_130);
				if (num33 > num32 && num33 < 300000L)
				{
					num32 = num33;
				}
				if (num32 <= 100L || 100L * num31 / num32 <= gstruct42_0.int_97[3])
				{
					num19 = num20;
				}
			}
		}
		goto IL_0a41;
		IL_06d2:
		num10 = 0u;
		goto IL_06d5;
		IL_06d5:
		if (num11 != 0 && Class38.int_0 == 0 && (gstruct42_0.int_97[2] == 1 || num10 == 0))
		{
			uint num35 = 0u;
			long num36 = -1L;
			long num37 = -1L;
			for (int j = 0; j < array3.Length; j++)
			{
				if (num20 == array3[j])
				{
					continue;
				}
				uint num13 = num4 + array3[j] * Class47.gstruct43_15.uint_0;
				int num28 = (int)Class20.smethod_30(num13 + Class47.gstruct43_54.uint_0, gstruct42_0.int_130);
				if (num6 != num28)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array2, 4, ref int_);
				array4[0] = BitConverter.ToUInt32(array2, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num13 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array2, 4, ref int_);
				array4[1] = BitConverter.ToUInt32(array2, 0);
				long num30 = Class53.smethod_18(array, array4);
				if (num30 > num21 * num21)
				{
					continue;
				}
				if (gstruct42_0.int_97[3] > 99)
				{
					if (num35 == 0 || num30 < num37)
					{
						num35 = array3[j];
						num37 = num30;
						array5[0] = array4[0];
						array5[1] = array4[1];
					}
					continue;
				}
				long num31 = Class20.smethod_30(num13 + Class47.gstruct43_45.uint_0, gstruct42_0.int_130);
				long num32 = Class20.smethod_30(num13 + Class47.gstruct43_47.uint_0, gstruct42_0.int_130);
				long num33 = Class20.smethod_30(num13 + Class47.gstruct43_47.uint_0 + 4, gstruct42_0.int_130);
				if (num33 > num32 && num33 < 300000L)
				{
					num32 = num33;
				}
				long num34 = num31;
				if (num32 > 100L)
				{
					num34 = 100L * num31 / num32;
				}
				if (num34 <= gstruct42_0.int_97[3] && (num35 == 0 || num34 < num36 || (num34 == num36 && num30 < num37)))
				{
					num35 = array3[j];
					num37 = num30;
					num36 = num34;
					array5[0] = array4[0];
					array5[1] = array4[1];
				}
			}
			if (num35 != 0)
			{
				num19 = (int)num35;
				goto IL_0a41;
			}
		}
		goto IL_0944;
		IL_0a41:
		if (num19 <= 0)
		{
			return false;
		}
		for (int k = 0; k < 10; k++)
		{
			int int_4 = gstruct42_0.int_130;
			uint uint_3 = num5 + Class47.gstruct43_72.uint_0;
			byte[] byte_ = new byte[4];
			Class20.WriteProcessMemory(int_4, uint_3, byte_, 4, ref int_);
			int num38 = (int)Class20.smethod_30(num5 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
			if (num38 <= 3)
			{
				break;
			}
			Thread.Sleep(60);
		}
		if (gstruct42_0.int_97[1] != num)
		{
			uint value = uint.MaxValue;
			uint value2 = (uint)num19;
			if (num19 == num20)
			{
				value = array[0];
				value2 = array[1];
			}
			byte[] bytes = BitConverter.GetBytes(value);
			byte[] bytes2 = BitConverter.GetBytes(value2);
			byte[] byte_2 = new byte[4]
			{
				5,
				0,
				0,
				0
			};
			byte[] bytes3 = BitConverter.GetBytes(gstruct42_0.int_97[1]);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_37.uint_0, bytes, 4, ref int_);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_38.uint_0, bytes2, 4, ref int_);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_36.uint_0, bytes3, 4, ref int_);
			Class20.WriteProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_35.uint_0, byte_2, 4, ref int_);
		}
		else
		{
			uint[] array6 = Class73.smethod_10(array, array5);
			uint uint_4 = (array6[1] << 16) + array6[0];
			Class73.smethod_7(gstruct42_0, uint_4);
			Class67.smethod_7(gstruct42_0);
			Class67.smethod_3(gstruct42_0, num, 6, 1);
			Class20.smethod_75(gstruct42_0.uint_4, 117);
		}
		Thread.Sleep(30);
		return true;
	}

	public static int smethod_4(int int_4, int int_5, uint[] uint_2)
	{
		try
		{
			int int_6 = 0;
			byte[] array = new byte[1];
			if (gstruct20_0 != null)
			{
				for (int i = 0; i < gstruct20_0.Length; i++)
				{
					if (gstruct20_0[i].int_0 != 0 && int_5 == gstruct20_0[i].int_1)
					{
						Class20.ReadProcessMemory(int_4, gstruct20_0[i].uint_0, array, 1, ref int_6);
						if (array[0] != 0)
						{
							long num = Class53.smethod_18(uint_2, gstruct20_0[i].uint_1);
							if (num < 360000L)
							{
								return 1;
							}
						}
						else
						{
							gstruct20_0[i].int_0 = 0;
							gstruct20_0[i].int_1 = 0;
						}
					}
				}
			}
			return 0;
		}
		catch
		{
		}
		return -1;
	}

	public static int[,] smethod_5(GStruct42 gstruct42_0, uint uint_2, int int_4 = 600, uint[] uint_3 = null, int[] int_5 = null, bool bool_2 = false, bool bool_3 = false, bool bool_4 = false)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_30.uint_0;
		uint num3 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
		uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num5 = num4 + num3;
		uint num6 = num + Class47.gstruct43_30.uint_0;
		uint num7 = Class20.smethod_30(num5 + Class47.gstruct43_85.uint_0, gstruct42_0.int_130);
		uint num8 = Class20.smethod_30(Class11.uint_1, Class11.int_1);
		long num9 = int_4 * int_4;
		int num10 = (int)Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		int num11 = (int)Class20.smethod_30(num5 + Class47.gstruct43_54.uint_0, gstruct42_0.int_130);
		int num12 = (int)Class20.smethod_30(num5 + Class47.gstruct43_56.uint_0, gstruct42_0.int_130);
		if (uint_3 == null || uint_3.Length != 2 || uint_3[0] == 0 || uint_3[1] == 0)
		{
			uint_3 = new uint[2]
			{
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
		}
		int num13 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
		bool flag = !bool_4 && ((926 <= num13 && num13 <= 932) || num13 == Class34.int_0);
		bool flag2 = (463 < num13 && num13 < 472) || (479 < num13 && num13 < 496);
		byte[] array = new byte[1];
		byte[] array2 = new byte[16];
		byte[] array3 = new byte[60];
		long[,,] array4 = new long[2, 5, 9];
		int[,] array5 = new int[2, 10];
		int[] array6 = new int[2];
		int int_6 = 0;
		byte[] array7 = new byte[4];
		byte[] array8 = new byte[4];
		Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 8, array7, 4, ref int_6);
		uint num14 = BitConverter.ToUInt32(array7, 0) / 2u;
		uint uint_4 = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_4, array7, 4, ref int_6);
		byte[] array9 = new byte[1];
		Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 4, array9, 1, ref int_6);
		int num15 = BitConverter.ToInt32(array7, 0);
		if (num15 <= 1)
		{
			return null;
		}
		uint[] array10 = new uint[2];
		int num16 = 0;
		int num17 = 0;
		uint num18 = 0u;
		num18 = 1u;
		while (true)
		{
			uint num20;
			uint num21;
			bool flag3;
			int num22;
			int num23;
			if (num18 < 256)
			{
				if (!bool_2 && num18 % 2u == 0)
				{
					int num19 = Class73.smethod_12(gstruct42_0);
					if (num19 == 1)
					{
						array5[0, 0] = -100;
						array5[1, 1] = -100;
						goto IL_11aa;
					}
				}
				if (num15 > num17 && num14 == Class47.uint_0)
				{
					if (num18 != num10)
					{
						num20 = num4 + num18 * Class47.gstruct43_15.uint_0;
						num21 = num20 + Class47.gstruct43_16.uint_0;
						Class20.ReadProcessMemory(gstruct42_0.int_130, num21, array7, 4, ref int_6);
						if (array7[0] == 0)
						{
							goto IL_0e4f;
						}
						flag3 = (array7[0] == 84 && array7[2] == 211);
						num17++;
						Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_50.uint_0, array7, 4, ref int_6);
						if (BitConverter.ToInt32(array7, 0) <= 0)
						{
							goto IL_0e4f;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_52.uint_0, array7, 4, ref int_6);
						num22 = BitConverter.ToInt32(array7, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_43.uint_0, array7, 4, ref int_6);
						num23 = BitConverter.ToInt32(array7, 0);
						int num24;
						if (num22 >= 0 && num22 <= 1)
						{
							if (num22 == 1)
							{
								if (num23 <= 0 || array9[0] > 0 || bool_0)
								{
									goto IL_0e4f;
								}
								goto IL_044c;
							}
							num24 = 1;
						}
						else
						{
							num24 = 0;
						}
						if (num24 == 0)
						{
							goto IL_0e4f;
						}
						goto IL_044c;
					}
					num17++;
					goto IL_0e4f;
				}
			}
			if (num16 == 0)
			{
				break;
			}
			int num25 = 2;
			while (true)
			{
				num25--;
				if (num25 < 0)
				{
					break;
				}
				if (array6[num25] == 0)
				{
					continue;
				}
				if (gstruct42_0.int_86 <= 0)
				{
					int num26 = -1;
					long num27 = -1L;
					for (int i = 0; i < 5; i++)
					{
						if (array4[num25, i, 0] > 0L && (num27 < 0L || num27 > array4[num25, i, 2]))
						{
							num26 = i;
							num27 = array4[num25, i, 2];
						}
					}
					if (0 > num26)
					{
						continue;
					}
					array5[0, 0] = num25;
					array5[0, 1] = (int)array4[num25, num26, 0];
					array5[0, 2] = (int)array4[num25, num26, 1];
					array5[0, 3] = (int)array4[num25, num26, 2];
					array5[0, 4] = (int)array4[num25, num26, 3];
					array5[0, 5] = (int)array4[num25, num26, 4];
					array5[0, 6] = (int)array4[num25, num26, 5];
					array5[0, 7] = (int)array4[num25, num26, 6];
					array5[0, 8] = (int)array4[num25, num26, 7];
					array5[0, 9] = (int)array4[num25, num26, 8];
					break;
				}
				int num28 = 0;
				int num29;
				while (num28 < gstruct42_0.int_88.Length)
				{
					num29 = gstruct42_0.int_88[num28];
					if (array4[num25, num29, 0] <= 0L)
					{
						num28++;
						continue;
					}
					goto IL_10d8;
				}
				continue;
				IL_10d8:
				array5[0, 0] = num25;
				array5[0, 1] = (int)array4[num25, num29, 0];
				array5[0, 2] = (int)array4[num25, num29, 1];
				array5[0, 3] = (int)array4[num25, num29, 2];
				array5[0, 4] = (int)array4[num25, num29, 3];
				array5[0, 5] = (int)array4[num25, num29, 4];
				array5[0, 6] = (int)array4[num25, num29, 5];
				array5[0, 7] = (int)array4[num25, num29, 6];
				array5[0, 8] = (int)array4[num25, num29, 7];
				array5[0, 9] = (int)array4[num25, num29, 8];
				break;
			}
			goto IL_11aa;
			IL_0e4f:
			num18++;
			continue;
			IL_11aa:
			if (gstruct42_0.int_86 > 0 && array5[1, 1] != -1 && array5[0, 1] > 0)
			{
				int num30 = -1;
				int num31 = -1;
				long num27 = -1L;
				for (int j = 0; j <= 1; j++)
				{
					for (int i = 0; i < 5; i++)
					{
						if (array4[j, i, 0] > 0L && array5[0, 1] != array4[j, i, 0] && (num27 < 0L || num27 > array4[j, i, 2]))
						{
							num30 = j;
							num31 = i;
							num27 = array4[j, i, 2];
						}
					}
				}
				if (0 <= num30 && 0 <= num31)
				{
					array5[1, 0] = num30;
					array5[1, 1] = (int)array4[num30, num31, 0];
					array5[1, 2] = (int)array4[num30, num31, 1];
					array5[1, 3] = (int)array4[num30, num31, 2];
					array5[1, 4] = (int)array4[num30, num31, 3];
					array5[1, 5] = (int)array4[num30, num31, 4];
					array5[1, 6] = (int)array4[num30, num31, 5];
					array5[1, 7] = (int)array4[num30, num31, 6];
					array5[1, 8] = (int)array4[num30, num31, 7];
					array5[1, 9] = (int)array4[num30, num31, 8];
				}
			}
			return array5;
			IL_044c:
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_55.uint_0, array7, 4, ref int_6);
			int num32 = BitConverter.ToInt32(array7, 0);
			if (num32 == 10 || num32 == 21)
			{
				goto IL_0e4f;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20, array8, 4, ref int_6);
			int num33 = BitConverter.ToInt32(array8, 0);
			if (num33 == -1 || num33 == 0)
			{
				goto IL_0e4f;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_54.uint_0, array7, 4, ref int_6);
			int num34 = BitConverter.ToInt32(array7, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_45.uint_0, array7, 4, ref int_6);
			long num35 = BitConverter.ToInt32(array7, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_26.uint_0 + 8, array7, 4, ref int_6);
			int num36 = BitConverter.ToInt32(array7, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_26.uint_0 + 12, array7, 4, ref int_6);
			int num37 = BitConverter.ToInt32(array7, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_51.uint_0, array7, 4, ref int_6);
			int num38 = BitConverter.ToInt32(array7, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array7, 4, ref int_6);
			array10[0] = BitConverter.ToUInt32(array7, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array7, 4, ref int_6);
			array10[1] = BitConverter.ToUInt32(array7, 0);
			bool flag4 = false;
			if (flag2 && FormMain.int_109 > 0 && num22 <= 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_9 + num18 * 8, array7, 4, ref int_6);
				if (BitConverter.ToUInt32(array7, 0) == num33)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_9 + num18 * 8 + 4, array, 1, ref int_6);
					if (array[0] > 0)
					{
						goto IL_0e4f;
					}
				}
				else
				{
					array[0] = 0;
					if (flag3)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num21 + 5, array7, 4, ref int_6);
						if (BitConverter.ToUInt32(array7, 0) == 3580454990u)
						{
							array[0] = 1;
						}
					}
					if (array[0] <= 0)
					{
						uint num39 = num4 + num18 * Class47.gstruct43_15.uint_0 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0;
						for (uint num40 = 0u; num40 < 6; num40++)
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, num39 + Class47.gstruct43_2.uint_0 * num40, array7, 4, ref int_6);
							if (BitConverter.ToInt32(array7, 0) == 45)
							{
								array[0] = 1;
								break;
							}
						}
					}
					Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_9 + num18 * 8, array8, 4, ref int_6);
					Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_9 + num18 * 8 + 4, array, 1, ref int_6);
					if (array[0] > 0)
					{
						int num41 = 0;
						while (bool_1 && num41 < 15)
						{
							Thread.Sleep(10);
							num41++;
						}
						bool_1 = true;
						int num42 = 1;
						if (gstruct20_0 != null)
						{
							num42 = gstruct20_0.Length + 1;
							Array.Resize(ref gstruct20_0, num42);
						}
						else
						{
							gstruct20_0 = new GStruct20[1];
						}
						gstruct20_0[num42 - 1].int_0 = num33;
						gstruct20_0[num42 - 1].int_1 = num13;
						gstruct20_0[num42 - 1].uint_0 = num21;
						gstruct20_0[num42 - 1].int_2 = 1;
						gstruct20_0[num42 - 1].uint_1 = new uint[2]
						{
							array10[0],
							array10[1]
						};
						bool_1 = false;
						goto IL_0e4f;
					}
				}
				if (smethod_4(gstruct42_0.int_130, num13, array10) > 0)
				{
					goto IL_0e4f;
				}
			}
			while (!flag4 && (uint_2 == 0 || num33 != uint_2))
			{
				long num43 = Class53.smethod_18(uint_3, array10);
				if (num43 > num9)
				{
					goto IL_0e4f;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_53.uint_0, array7, 4, ref int_6);
				int num44 = BitConverter.ToInt32(array7, 0);
				if (num44 < 0 || num44 > 4)
				{
					goto IL_0e4f;
				}
				if (num22 <= 0)
				{
					if (FormMain.int_31 <= 0 || (num11 > 0 && num34 == num11 && num34 != 4))
					{
						goto IL_0e4f;
					}
					if (flag)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_16.uint_0, array3, array3.Length, ref int_6);
						string text = Class10.smethod_3(array3);
						if (!(text == string.Empty) && Class11.smethod_2(text, "[" + gstruct42_0.string_18 + "]") > 0)
						{
							goto IL_0e4f;
						}
						if (FormMain.int_32 > 0 && FormMain.int_36 > 0)
						{
							flag4 = true;
							continue;
						}
					}
					else
					{
						bool flag5 = false;
						if (int_5 != null)
						{
							for (int k = 0; k < int_5.Length; k++)
							{
								if (num33 == int_5[k])
								{
									flag5 = true;
									break;
								}
							}
						}
						if (flag5)
						{
							goto IL_0e4f;
						}
						bool flag6 = num36 > 0 && num37 > 15 && num38 > 0;
						if (FormMain.int_32 > 0 || num35 <= 0L)
						{
							if (flag6)
							{
								if (FormMain.int_36 > 0)
								{
									flag4 = true;
									continue;
								}
							}
							else if (!bool_3 || num38 <= 95 || num35 <= 0L)
							{
								goto IL_0e4f;
							}
						}
					}
				}
				else
				{
					if (FormMain.int_30 <= 0 || num23 <= 0 || num34 == 0 || num11 == 0 || num8 == 0 || (FormMain.int_35 <= 0 && (num32 == 3 || num32 == 4)))
					{
						goto IL_0e4f;
					}
					if (FormMain.int_81 > 0)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_51.uint_0, array7, 4, ref int_6);
						int num45 = BitConverter.ToInt32(array7, 0);
						if (num45 < FormMain.int_82)
						{
							goto IL_0e4f;
						}
					}
					if (int_3 > 0 && string_5 != null)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_16.uint_0, array2, array2.Length, ref int_6);
						string a = Class10.smethod_3(array2);
						bool flag5 = false;
						for (int l = 0; l < string_5.Length; l++)
						{
							if (a == string_5[l])
							{
								flag5 = true;
								break;
							}
						}
						if (flag5)
						{
							goto IL_0e4f;
						}
					}
					if (Class38.int_0 != 0)
					{
						goto IL_0e4f;
					}
					Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_85.uint_0, array7, 4, ref int_6);
					uint num46 = BitConverter.ToUInt32(array7, 0);
					if (num46 != 0)
					{
						if (FormMain.int_97 > 0 && num46 == num7)
						{
							goto IL_0e4f;
						}
						if (int_2 > 0 && uint_0 != null)
						{
							bool flag5 = false;
							for (int l = 0; l < uint_0.Length; l++)
							{
								if (num46 == uint_0[l])
								{
									flag5 = true;
									break;
								}
							}
							if (flag5)
							{
								goto IL_0e4f;
							}
						}
						if (int_1 > 0 && uint_1 != null)
						{
							int l = 0;
							while (l < uint_1.Length)
							{
								if (num46 != uint_1[l])
								{
									l++;
									continue;
								}
								goto IL_0d67;
							}
						}
					}
					if (!flag || (num7 == num46 && num7 != 0 && num46 != 0))
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num2 + Class47.gstruct43_61.uint_0, array7, 4, ref int_6);
						uint num47 = BitConverter.ToUInt32(array7, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num20, array7, 4, ref int_6);
						uint num48 = BitConverter.ToUInt32(array7, 0);
						if (num47 == num48)
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_62.uint_0, array7, 4, ref int_6);
							gstruct42_0.gstruct40_0.uint_2 = BitConverter.ToUInt32(array7, 0);
							if (gstruct42_0.gstruct40_0.uint_2 == 2)
							{
								goto IL_0d67;
							}
						}
						if (num34 == num11 && num34 != 4)
						{
							goto IL_0e4f;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_56.uint_0, array7, 4, ref int_6);
						int num49 = BitConverter.ToInt32(array7, 0);
						if (num12 + num49 <= 1)
						{
							goto IL_0e4f;
						}
					}
				}
				goto IL_0d67;
				IL_0d67:
				try
				{
					if (num22 > 1)
					{
						num22 = 1;
					}
					long num50 = array4[num22, num44, 2];
					if (num50 <= 0L || num50 >= num43)
					{
						array6[num22]++;
						array4[num22, num44, 0] = num18;
						array4[num22, num44, 1] = num33;
						array4[num22, num44, 2] = num43;
						array4[num22, num44, 3] = array10[0];
						array4[num22, num44, 4] = array10[1];
						array4[num22, num44, 5] = num36;
						array4[num22, num44, 6] = num37;
						array4[num22, num44, 7] = num38;
						array4[num22, num44, 8] = num35;
						num16++;
					}
				}
				catch
				{
				}
				goto IL_0e4f;
			}
			array5[0, 0] = num22;
			array5[0, 1] = (int)num18;
			array5[0, 2] = num33;
			array5[0, 3] = (int)Class53.smethod_18(uint_3, array10);
			array5[0, 4] = (int)array10[0];
			array5[0, 5] = (int)array10[1];
			array5[0, 6] = num36;
			array5[0, 7] = num37;
			array5[0, 8] = num38;
			array5[0, 9] = (int)num35;
			array5[1, 1] = -1;
			goto IL_11aa;
		}
		return null;
	}

	public static int[,] smethod_6(GStruct42 gstruct42_0, uint uint_2, int int_4 = 600, uint[] uint_3 = null, int[] int_5 = null, bool bool_2 = false, bool bool_3 = false, bool bool_4 = false)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_30.uint_0;
		uint num3 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
		uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num5 = num4 + num3;
		uint num6 = num + Class47.gstruct43_30.uint_0;
		uint num7 = Class20.smethod_30(num5 + Class47.gstruct43_85.uint_0, gstruct42_0.int_130);
		long num8 = int_4 * int_4;
		int num9 = (int)Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		int num10 = (int)Class20.smethod_30(num5 + Class47.gstruct43_54.uint_0, gstruct42_0.int_130);
		int num11 = (int)Class20.smethod_30(num5 + Class47.gstruct43_56.uint_0, gstruct42_0.int_130);
		uint num12 = Class20.smethod_30(Class11.uint_1, Class11.int_1);
		if (uint_3 == null || uint_3.Length != 2 || uint_3[0] == 0 || uint_3[1] == 0)
		{
			uint_3 = new uint[2]
			{
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
		}
		int num13 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
		bool flag = !bool_4 && ((926 <= num13 && num13 <= 932) || num13 == Class34.int_0);
		bool flag2 = (463 < num13 && num13 < 472) || (479 < num13 && num13 < 496);
		byte[] array = new byte[1];
		byte[] array2 = new byte[16];
		byte[] array3 = new byte[60];
		int num14 = 11;
		int[,] array4 = new int[2, 11];
		long[,] long_ = null;
		long[,] long_2 = null;
		int num15 = 0;
		int num16 = 0;
		int int_6 = 0;
		byte[] array5 = new byte[4];
		byte[] array6 = new byte[4];
		Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 8, array5, 4, ref int_6);
		uint num17 = BitConverter.ToUInt32(array5, 0) / 2u;
		uint uint_4 = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_4, array5, 4, ref int_6);
		int num18 = BitConverter.ToInt32(array5, 0);
		if (num18 > 1)
		{
			uint[] array7 = new uint[2];
			int num19 = 0;
			int num20 = 0;
			byte[] array8 = new byte[1];
			Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 4, array8, 1, ref int_6);
			uint num21 = 0u;
			for (num21 = 1u; num21 < 256; num21++)
			{
				uint num22;
				uint num23;
				bool flag3;
				int num24;
				int num25;
				if (bool_2 || num21 % 2u != 0 || Class73.smethod_12(gstruct42_0) != 1)
				{
					if (num18 <= num20 || num17 != Class47.uint_0)
					{
						break;
					}
					if (num21 != num9)
					{
						num22 = num4 + num21 * Class47.gstruct43_15.uint_0;
						num23 = num22 + Class47.gstruct43_16.uint_0;
						Class20.ReadProcessMemory(gstruct42_0.int_130, num23, array5, 4, ref int_6);
						if (array5[0] == 0)
						{
							continue;
						}
						flag3 = (array5[0] == 84 && array5[2] == 211);
						num20++;
						Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_50.uint_0, array5, 4, ref int_6);
						if (BitConverter.ToInt32(array5, 0) <= 0)
						{
							continue;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_52.uint_0, array5, 4, ref int_6);
						num24 = BitConverter.ToInt32(array5, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_43.uint_0, array5, 4, ref int_6);
						num25 = BitConverter.ToInt32(array5, 0);
						int num26;
						if (num24 >= 0)
						{
							if (num24 > 0)
							{
								if (num25 <= 0 || array8[0] > 0 || bool_0)
								{
									continue;
								}
								goto IL_0435;
							}
							num26 = 1;
						}
						else
						{
							num26 = 0;
						}
						if (num26 == 0)
						{
							continue;
						}
						goto IL_0435;
					}
					num20++;
					continue;
				}
				array4[0, 0] = -100;
				array4[1, 0] = -100;
				return array4;
				IL_0435:
				Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_55.uint_0, array5, 4, ref int_6);
				int num27 = BitConverter.ToInt32(array5, 0);
				if (num27 == 10 || num27 == 21)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num22, array6, 4, ref int_6);
				int num28 = BitConverter.ToInt32(array6, 0);
				if (num28 == -1 || num28 == 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_54.uint_0, array5, 4, ref int_6);
				int num29 = BitConverter.ToInt32(array5, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_45.uint_0, array5, 4, ref int_6);
				long num30 = BitConverter.ToInt32(array5, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_26.uint_0 + 8, array5, 4, ref int_6);
				int num31 = BitConverter.ToInt32(array5, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_26.uint_0 + 12, array5, 4, ref int_6);
				int num32 = BitConverter.ToInt32(array5, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_51.uint_0, array5, 4, ref int_6);
				int num33 = BitConverter.ToInt32(array5, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array5, 4, ref int_6);
				array7[0] = BitConverter.ToUInt32(array5, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array5, 4, ref int_6);
				array7[1] = BitConverter.ToUInt32(array5, 0);
				int num34 = 0;
				bool flag4 = false;
				if (flag2 && FormMain.int_109 > 0 && num24 <= 0)
				{
					Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_9 + num21 * 8, array5, 4, ref int_6);
					if (BitConverter.ToUInt32(array5, 0) != num28)
					{
						array[0] = 0;
						if (flag3)
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, num23 + 5, array5, 4, ref int_6);
							if (BitConverter.ToUInt32(array5, 0) == 3580454990u)
							{
								array[0] = 1;
							}
						}
						if (array[0] <= 0)
						{
							uint num35 = num4 + num21 * Class47.gstruct43_15.uint_0 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_1.uint_0;
							for (uint num36 = 0u; num36 < 6; num36++)
							{
								Class20.ReadProcessMemory(gstruct42_0.int_130, num35 + Class47.gstruct43_2.uint_0 * num36, array5, 4, ref int_6);
								if (BitConverter.ToInt32(array5, 0) == 45)
								{
									array[0] = 1;
									break;
								}
							}
						}
						Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_9 + num21 * 8, array6, 4, ref int_6);
						Class20.WriteProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_9 + num21 * 8 + 4, array, 1, ref int_6);
						if (array[0] > 0)
						{
							num34 = 1;
							int num37 = 0;
							while (bool_1 && num37 < 15)
							{
								Thread.Sleep(10);
								num37++;
							}
							bool_1 = true;
							int num38 = 1;
							if (gstruct20_0 != null)
							{
								num38 = gstruct20_0.Length + 1;
								Array.Resize(ref gstruct20_0, num38);
							}
							else
							{
								gstruct20_0 = new GStruct20[1];
							}
							gstruct20_0[num38 - 1].int_0 = num28;
							gstruct20_0[num38 - 1].int_1 = num13;
							gstruct20_0[num38 - 1].int_2 = 1;
							gstruct20_0[num38 - 1].uint_1 = new uint[2]
							{
								array7[0],
								array7[1]
							};
							bool_1 = false;
						}
					}
					else
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_9 + num21 * 8 + 4, array, 1, ref int_6);
						if (array[0] == 0 && smethod_4(gstruct42_0.int_130, num13, array7) != 0)
						{
							array[0] = 1;
						}
						num34 = array[0];
					}
				}
				while (true)
				{
					long num39;
					if (!flag4 && (uint_2 == 0 || num28 != uint_2))
					{
						num39 = Class53.smethod_18(uint_3, array7);
						if (num39 > num8)
						{
							break;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_53.uint_0, array5, 4, ref int_6);
						int num40 = BitConverter.ToInt32(array5, 0);
						if (num40 < 0 || num40 > 4)
						{
							break;
						}
						if (num24 <= 0)
						{
							if (FormMain.int_31 <= 0 || (num10 > 0 && num29 == num10 && num29 != 4))
							{
								break;
							}
							if (flag)
							{
								Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_16.uint_0, array3, array3.Length, ref int_6);
								string text = Class10.smethod_3(array3);
								if (!(text == string.Empty) && Class11.smethod_2(text, "[" + gstruct42_0.string_18 + "]") > 0)
								{
									break;
								}
								if (FormMain.int_32 > 0 && FormMain.int_36 > 0)
								{
									flag4 = true;
									continue;
								}
							}
							else
							{
								bool flag5 = false;
								if (int_5 != null)
								{
									for (int i = 0; i < int_5.Length; i++)
									{
										if (num21 == int_5[i])
										{
											flag5 = true;
											break;
										}
									}
								}
								if (flag5)
								{
									break;
								}
								bool flag6 = num31 > 0 && num32 > 15 && num33 > 0;
								if (FormMain.int_32 > 0 || num30 <= 0L)
								{
									if (flag6)
									{
										if (FormMain.int_36 > 0)
										{
											flag4 = true;
											continue;
										}
									}
									else if (!bool_3 || num33 <= 95 || num30 <= 0L)
									{
										break;
									}
								}
							}
						}
						else
						{
							if (FormMain.int_30 <= 0 || num25 <= 0 || num29 == 0 || num10 == 0 || num12 == 0 || (FormMain.int_35 <= 0 && (num27 == 3 || num27 == 4)))
							{
								break;
							}
							if (FormMain.int_81 > 0)
							{
								Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_51.uint_0, array5, 4, ref int_6);
								int num41 = BitConverter.ToInt32(array5, 0);
								if (num41 < FormMain.int_82)
								{
									break;
								}
							}
							if (int_3 > 0 && string_5 != null)
							{
								Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_16.uint_0, array2, array2.Length, ref int_6);
								string a = Class10.smethod_3(array2);
								bool flag5 = false;
								for (int j = 0; j < string_5.Length; j++)
								{
									if (a == string_5[j])
									{
										flag5 = true;
										break;
									}
								}
								if (flag5)
								{
									break;
								}
							}
							if (Class38.int_0 != 0)
							{
								break;
							}
							Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_85.uint_0, array5, 4, ref int_6);
							uint num42 = BitConverter.ToUInt32(array5, 0);
							if (num42 != 0)
							{
								if (FormMain.int_97 > 0 && num42 == num7)
								{
									break;
								}
								if (int_2 > 0 && uint_0 != null)
								{
									bool flag5 = false;
									for (int j = 0; j < uint_0.Length; j++)
									{
										if (num42 == uint_0[j])
										{
											flag5 = true;
											break;
										}
									}
									if (flag5)
									{
										break;
									}
								}
								if (int_1 > 0 && uint_1 != null)
								{
									int j = 0;
									while (j < uint_1.Length)
									{
										if (num42 != uint_1[j])
										{
											j++;
											continue;
										}
										goto IL_0d3a;
									}
								}
							}
							if (!flag || (num7 == num42 && num7 != 0 && num42 != 0))
							{
								Class20.ReadProcessMemory(gstruct42_0.int_130, num2 + Class47.gstruct43_61.uint_0, array5, 4, ref int_6);
								uint num43 = BitConverter.ToUInt32(array5, 0);
								Class20.ReadProcessMemory(gstruct42_0.int_130, num22, array5, 4, ref int_6);
								uint num44 = BitConverter.ToUInt32(array5, 0);
								if (num43 == num44)
								{
									Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_62.uint_0, array5, 4, ref int_6);
									gstruct42_0.gstruct40_0.uint_2 = BitConverter.ToUInt32(array5, 0);
									if (gstruct42_0.gstruct40_0.uint_2 == 2)
									{
										goto IL_0d3a;
									}
								}
								if (num29 == num10 && num29 != 4)
								{
									break;
								}
								Class20.ReadProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_56.uint_0, array5, 4, ref int_6);
								int num45 = BitConverter.ToInt32(array5, 0);
								if (num11 + num45 <= 1)
								{
									break;
								}
							}
						}
						goto IL_0d3a;
					}
					array4[0, 0] = num24;
					array4[0, 1] = (int)num21;
					array4[0, 2] = num28;
					array4[0, 3] = (int)Class53.smethod_18(uint_3, array7);
					array4[0, 4] = (int)array7[0];
					array4[0, 5] = (int)array7[1];
					array4[0, 6] = num31;
					array4[0, 7] = num32;
					array4[0, 8] = num33;
					array4[0, 9] = (int)num30;
					array4[0, 10] = num34;
					array4[1, 1] = -1;
					return array4;
					IL_0d3a:
					try
					{
						if (num14 < 11)
						{
							num14 = 11;
						}
						if (num24 == 0)
						{
							num15 = Class11.smethod_34(ref long_, 1, num14);
							long_[num15 - 1, 0] = num24;
							long_[num15 - 1, 1] = num21;
							long_[num15 - 1, 2] = num28;
							long_[num15 - 1, 3] = num39;
							long_[num15 - 1, 4] = array7[0];
							long_[num15 - 1, 5] = array7[1];
							long_[num15 - 1, 6] = num31;
							long_[num15 - 1, 7] = num32;
							long_[num15 - 1, 8] = num33;
							long_[num15 - 1, 9] = num30;
							long_[num15 - 1, 10] = num34;
						}
						else
						{
							num16 = Class11.smethod_34(ref long_2, 1, num14);
							long_2[num16 - 1, 0] = num24;
							long_2[num16 - 1, 1] = num21;
							long_2[num16 - 1, 2] = num28;
							long_2[num16 - 1, 3] = num39;
							long_2[num16 - 1, 4] = array7[0];
							long_2[num16 - 1, 5] = array7[1];
							long_2[num16 - 1, 6] = num31;
							long_2[num16 - 1, 7] = num32;
							long_2[num16 - 1, 8] = num33;
							long_2[num16 - 1, 9] = num30;
						}
						num19++;
					}
					catch
					{
					}
					break;
				}
			}
			if (num19 != 0)
			{
				array4 = new int[num15 + num16, num14];
				long num46 = 0L;
				if (num16 > 0)
				{
					while (true)
					{
						int k;
						int num47;
						for (k = 0; k < num16 - 1; k++)
						{
							num47 = k;
							while (num47 < num16)
							{
								if (long_2[num47, 3] >= long_2[k, 3])
								{
									num47++;
									continue;
								}
								goto IL_102d;
							}
							for (int l = 0; l < num14; l++)
							{
								array4[k, l] = (int)long_2[k, l];
							}
						}
						break;
						IL_102d:
						for (int l = 0; l < num14; l++)
						{
							num46 = long_2[k, l];
							long_2[k, l] = long_2[num47, l];
							long_2[num47, l] = num46;
						}
					}
					for (int l = 0; l < num14; l++)
					{
						array4[num16 - 1, l] = (int)long_2[num16 - 1, l];
					}
				}
				if (num15 > 0)
				{
					while (true)
					{
						int k;
						int num47;
						for (k = 0; k < num15 - 1; k++)
						{
							num47 = k;
							while (num47 < num15)
							{
								if (long_[num47, 3] >= long_[k, 3])
								{
									num47++;
									continue;
								}
								goto IL_1123;
							}
							for (int l = 0; l < num14; l++)
							{
								array4[num16 + k, l] = (int)long_[k, l];
							}
						}
						break;
						IL_1123:
						for (int l = 0; l < num14; l++)
						{
							num46 = long_[k, l];
							long_[k, l] = long_[num47, l];
							long_[num47, l] = num46;
						}
					}
					for (int l = 0; l < num14; l++)
					{
						array4[num16 + num15 - 1, l] = (int)long_[num15 - 1, l];
					}
				}
				return array4;
			}
			return null;
		}
		return null;
	}

	public static string smethod_7(GStruct42 gstruct42_0, uint[] uint_2 = null)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_3 = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_3, array, 4, ref int_);
		int num = BitConverter.ToInt32(array, 0);
		if (num <= 1)
		{
			return null;
		}
		string text = null;
		long num2 = 0L;
		uint num3 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		if (uint_2 == null)
		{
			uint_2 = Class32.smethod_29(gstruct42_0);
		}
		uint num4 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		int num5 = (int)Class20.smethod_30(num4 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		int num6 = 0;
		byte[] array2 = new byte[1];
		Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 4, array2, 1, ref int_);
		for (int i = 1; i < 256; i++)
		{
			if (text == null || i <= 40)
			{
				if (num <= num6)
				{
					break;
				}
				if (i != num5)
				{
					uint num7 = (uint)((int)num3 + i * (int)Class47.gstruct43_15.uint_0);
					Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
					if (array[0] == 0)
					{
						continue;
					}
					num6++;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num7 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) <= 0 || (int)Class20.smethod_30(num7 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130) <= 0)
					{
						continue;
					}
					int num8 = (int)Class20.smethod_30(num7 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
					if (num8 == 10 || num8 == 21)
					{
						continue;
					}
					int num9 = (int)Class20.smethod_30(num7 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130);
					if (num9 != 1 || array2[0] > 0 || bool_0)
					{
						continue;
					}
					uint[] array3 = new uint[2]
					{
						Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
						Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
					};
					long num10 = Class53.smethod_18(uint_2, array3);
					if (num10 == 0L || (text != null && num10 > 1690000L) || (text != null && num2 <= num10))
					{
						continue;
					}
					string text2 = Class20.smethod_28(num7 + Class47.gstruct43_16.uint_0, gstruct42_0.int_130, 32);
					for (int j = 0; j < gstruct42_0.string_16.Length; j++)
					{
						if (text2 == gstruct42_0.string_16[j])
						{
							text = text2;
							num2 = num10;
							break;
						}
					}
				}
				else
				{
					num6++;
				}
				continue;
			}
			return text;
		}
		return text;
	}

	public static uint[] smethod_8(GStruct42 gstruct42_0, uint uint_2)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_3 = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_3, array, 4, ref int_);
		byte[] array2 = new byte[1];
		Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 4, array2, 1, ref int_);
		int num2 = BitConverter.ToInt32(array, 0);
		if (num2 > 1 && array2[0] <= 0 && !bool_0)
		{
			uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			int num4 = (int)Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
			uint num5 = Class20.smethod_30(Class11.uint_1, Class11.int_1);
			int num6 = 0;
			for (uint num7 = 1u; num7 < 256; num7++)
			{
				if (num2 <= num6)
				{
					break;
				}
				if (num7 != num4)
				{
					uint num8 = num + num7 * Class47.gstruct43_15.uint_0;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
					if (array[0] == 0)
					{
						continue;
					}
					num6++;
					Class20.ReadProcessMemory(gstruct42_0.int_130, num8 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) <= 0)
					{
						continue;
					}
					uint num9 = Class20.smethod_30(num8, gstruct42_0.int_130);
					if (uint_2 == num9)
					{
						uint num10 = Class20.smethod_30(num8 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130);
						if (num10 == 0 || (num5 != 0 && Class38.int_0 == 0))
						{
							uint num11 = Class20.smethod_30(num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130);
							uint num12 = Class20.smethod_30(num8 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130);
							return new uint[5]
							{
								num7,
								num10,
								0u,
								num11,
								num12
							};
						}
					}
				}
				else
				{
					num6++;
				}
			}
			return null;
		}
		return null;
	}

	public static int[,] smethod_9(GStruct42 gstruct42_0, uint uint_2, int int_4 = 600, uint[] uint_3 = null, int[] int_5 = null, bool bool_2 = false)
	{
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
		uint num2 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_30.uint_0;
		uint num3 = Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
		uint num4 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		uint num5 = num4 + num3;
		uint num6 = num + Class47.gstruct43_30.uint_0;
		Class20.smethod_30(num5 + Class47.gstruct43_85.uint_0, gstruct42_0.int_130);
		long num7 = int_4 * int_4;
		int num8 = (int)Class20.smethod_30(num + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
		int num9 = (int)Class20.smethod_30(num5 + Class47.gstruct43_54.uint_0, gstruct42_0.int_130);
		int num10 = (int)Class20.smethod_30(num5 + Class47.gstruct43_56.uint_0, gstruct42_0.int_130);
		uint num11 = Class20.smethod_30(Class11.uint_1, Class11.int_1);
		if (uint_3 == null || uint_3.Length != 2 || uint_3[0] == 0 || uint_3[1] == 0)
		{
			uint_3 = new uint[2]
			{
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
				Class20.smethod_30(num5 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
			};
		}
		int num12 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
		bool flag = (926 <= num12 && num12 <= 932) || num12 == Class34.int_0;
		byte[] array = new byte[60];
		int num13 = 10;
		int[,] array2 = new int[2, 10];
		long[,] long_ = null;
		long[,] long_2 = null;
		int num14 = 0;
		int num15 = 0;
		int int_6 = 0;
		byte[] array3 = new byte[4];
		uint uint_4 = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_4, array3, 4, ref int_6);
		int num16 = BitConverter.ToInt32(array3, 0);
		if (num16 <= 1)
		{
			return null;
		}
		uint[] array4 = new uint[2];
		int num17 = 0;
		int num18 = 0;
		byte[] array5 = new byte[1];
		Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 4, array5, 1, ref int_6);
		uint num19 = 0u;
		for (num19 = 1u; num19 < 256; num19++)
		{
			uint num20;
			int num21;
			int num22;
			if (bool_2 || num19 % 2u != 0 || Class73.smethod_12(gstruct42_0) != 1)
			{
				if (num16 <= num18)
				{
					break;
				}
				if (num19 == num8)
				{
					num18++;
					continue;
				}
				num20 = num4 + num19 * Class47.gstruct43_15.uint_0;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_16.uint_0, array3, 4, ref int_6);
				if (array3[0] == 0)
				{
					continue;
				}
				num18++;
				Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_50.uint_0, array3, 4, ref int_6);
				if (BitConverter.ToInt32(array3, 0) <= 0)
				{
					continue;
				}
				Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_52.uint_0, array3, 4, ref int_6);
				num21 = BitConverter.ToInt32(array3, 0);
				Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_43.uint_0, array3, 4, ref int_6);
				num22 = BitConverter.ToInt32(array3, 0);
				int num23;
				if (num21 >= 0)
				{
					if (num21 > 0)
					{
						if (num22 <= 0 || array5[0] > 0 || bool_0)
						{
							continue;
						}
						goto IL_03aa;
					}
					num23 = 1;
				}
				else
				{
					num23 = 0;
				}
				if (num23 == 0)
				{
					continue;
				}
				goto IL_03aa;
			}
			array2[0, 0] = -100;
			array2[1, 0] = -100;
			return array2;
			IL_03aa:
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_55.uint_0, array3, 4, ref int_6);
			int num24 = BitConverter.ToInt32(array3, 0);
			if (num24 == 10 || num24 == 21)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20, array3, 4, ref int_6);
			int num25 = BitConverter.ToInt32(array3, 0);
			if (num25 == -1 || num25 == 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_54.uint_0, array3, 4, ref int_6);
			int num26 = BitConverter.ToInt32(array3, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_45.uint_0, array3, 4, ref int_6);
			long num27 = BitConverter.ToInt32(array3, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_26.uint_0 + 8, array3, 4, ref int_6);
			int num28 = BitConverter.ToInt32(array3, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_26.uint_0 + 12, array3, 4, ref int_6);
			int num29 = BitConverter.ToInt32(array3, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_51.uint_0, array3, 4, ref int_6);
			int num30 = BitConverter.ToInt32(array3, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array3, 4, ref int_6);
			array4[0] = BitConverter.ToUInt32(array3, 0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array3, 4, ref int_6);
			array4[1] = BitConverter.ToUInt32(array3, 0);
			bool flag2 = false;
			while (true)
			{
				long num31;
				if (!flag2 && (uint_2 == 0 || num25 != uint_2))
				{
					num31 = Class53.smethod_18(uint_3, array4);
					if (num31 > num7)
					{
						break;
					}
					Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_53.uint_0, array3, 4, ref int_6);
					int num32 = BitConverter.ToInt32(array3, 0);
					if (num32 < 0 || num32 > 4)
					{
						break;
					}
					if (num21 <= 0)
					{
						if (gstruct42_0.int_28 <= 0 || (num9 > 0 && num26 == num9 && num26 != 4))
						{
							break;
						}
						if (!flag)
						{
							bool flag3 = false;
							if (int_5 != null)
							{
								for (int i = 0; i < int_5.Length; i++)
								{
									if (num19 == int_5[i])
									{
										flag3 = true;
										break;
									}
								}
							}
							if (flag3)
							{
								break;
							}
							if (FormMain.int_32 > 0 || num27 <= 0L)
							{
								if (num28 <= 0 || num29 <= 15 || num30 <= 0)
								{
									break;
								}
								if (FormMain.int_36 > 0)
								{
									flag2 = true;
									continue;
								}
							}
						}
						else
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_16.uint_0, array, array.Length, ref int_6);
							string text = Class10.smethod_3(array);
							if (!(text == string.Empty) && Class11.smethod_2(text, "[" + gstruct42_0.string_18 + "]") > 0)
							{
								break;
							}
						}
					}
					else
					{
						if (num22 <= 0 || num26 == 0 || num9 == 0 || num11 == 0 || Class38.int_0 != 0)
						{
							break;
						}
						if (num26 != num9 || num26 == 4)
						{
							Class20.ReadProcessMemory(gstruct42_0.int_130, num20 + Class47.gstruct43_56.uint_0, array3, 4, ref int_6);
							int num33 = BitConverter.ToInt32(array3, 0);
							if (num10 + num33 > 1)
							{
								goto IL_0818;
							}
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num2 + Class47.gstruct43_61.uint_0, array3, 4, ref int_6);
						uint num34 = BitConverter.ToUInt32(array3, 0);
						Class20.ReadProcessMemory(gstruct42_0.int_130, num20, array3, 4, ref int_6);
						uint num35 = BitConverter.ToUInt32(array3, 0);
						if (num34 != num35)
						{
							break;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_62.uint_0, array3, 4, ref int_6);
						gstruct42_0.gstruct40_0.uint_2 = BitConverter.ToUInt32(array3, 0);
						if (gstruct42_0.gstruct40_0.uint_2 != 2)
						{
							break;
						}
					}
					goto IL_0818;
				}
				array2[0, 0] = num21;
				array2[0, 1] = (int)num19;
				array2[0, 2] = num25;
				array2[0, 3] = (int)Class53.smethod_18(uint_3, array4);
				array2[0, 4] = (int)array4[0];
				array2[0, 5] = (int)array4[1];
				array2[0, 6] = num28;
				array2[0, 7] = num29;
				array2[0, 8] = num30;
				array2[0, 9] = (int)num27;
				array2[1, 1] = -1;
				return array2;
				IL_0818:
				try
				{
					if (num13 < 10)
					{
						num13 = 10;
					}
					if (num21 != 0)
					{
						num15 = Class11.smethod_34(ref long_2, 1, num13);
						long_2[num15 - 1, 0] = num21;
						long_2[num15 - 1, 1] = num19;
						long_2[num15 - 1, 2] = num25;
						long_2[num15 - 1, 3] = num31;
						long_2[num15 - 1, 4] = array4[0];
						long_2[num15 - 1, 5] = array4[1];
						long_2[num15 - 1, 6] = num28;
						long_2[num15 - 1, 7] = num29;
						long_2[num15 - 1, 8] = num30;
						long_2[num15 - 1, 9] = num27;
					}
					else
					{
						num14 = Class11.smethod_34(ref long_, 1, num13);
						long_[num14 - 1, 0] = num21;
						long_[num14 - 1, 1] = num19;
						long_[num14 - 1, 2] = num25;
						long_[num14 - 1, 3] = num31;
						long_[num14 - 1, 4] = array4[0];
						long_[num14 - 1, 5] = array4[1];
						long_[num14 - 1, 6] = num28;
						long_[num14 - 1, 7] = num29;
						long_[num14 - 1, 8] = num30;
						long_[num14 - 1, 9] = num27;
					}
					num17++;
				}
				catch
				{
				}
				break;
			}
		}
		if (num17 == 0)
		{
			return null;
		}
		array2 = new int[num14 + num15, num13];
		long num36 = 0L;
		if (num15 > 0)
		{
			while (true)
			{
				int j;
				int num37;
				for (j = 0; j < num15 - 1; j++)
				{
					num37 = j;
					while (num37 < num15)
					{
						if (long_2[num37, 3] >= long_2[j, 3])
						{
							num37++;
							continue;
						}
						goto IL_0aee;
					}
					for (int k = 0; k < num13; k++)
					{
						array2[j, k] = (int)long_2[j, k];
					}
				}
				break;
				IL_0aee:
				for (int k = 0; k < num13; k++)
				{
					num36 = long_2[j, k];
					long_2[j, k] = long_2[num37, k];
					long_2[num37, k] = num36;
				}
			}
			for (int k = 0; k < num13; k++)
			{
				array2[num15 - 1, k] = (int)long_2[num15 - 1, k];
			}
		}
		if (num14 > 0)
		{
			while (true)
			{
				int j;
				int num37;
				for (j = 0; j < num14 - 1; j++)
				{
					num37 = j;
					while (num37 < num14)
					{
						if (long_[num37, 3] >= long_[j, 3])
						{
							num37++;
							continue;
						}
						goto IL_0be4;
					}
					for (int k = 0; k < num13; k++)
					{
						array2[num15 + j, k] = (int)long_[j, k];
					}
				}
				break;
				IL_0be4:
				for (int k = 0; k < num13; k++)
				{
					num36 = long_[j, k];
					long_[j, k] = long_[num37, k];
					long_[num37, k] = num36;
				}
			}
			for (int k = 0; k < num13; k++)
			{
				array2[num15 + num14 - 1, k] = (int)long_[num14 - 1, k];
			}
		}
		return array2;
	}
}
