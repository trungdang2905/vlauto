using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

internal class Class66
{
	public static char[] char_0 = new char[152]
	{
		'ᕖ',
		'ᕰ',
		'ᕊ',
		'ᕬ',
		'ᕲ',
		'ᔵ',
		'ᕍ',
		'ᕑ',
		'ᕋ',
		'ᕪ',
		'ᕚ',
		'ᕯ',
		'ᕐ',
		'ᔶ',
		'ᔱ',
		'ᕻ',
		'ᕱ',
		'ᕐ',
		'ᔲ',
		'ᕘ',
		'ᕒ',
		'ᕣ',
		'ᔰ',
		'ᕷ',
		'ᕭ',
		'ᕒ',
		'ᔬ',
		'ᔱ',
		'ᕵ',
		'ᕱ',
		'ᕇ',
		'ᕬ',
		'ᕃ',
		'ᕩ',
		'ᕣ',
		'ᕺ',
		'ᕌ',
		'ᕳ',
		'ᔰ',
		'ᔲ',
		'ᔬ',
		'ᕇ',
		'ᕻ',
		'ᕨ',
		'ᕲ',
		'ᕏ',
		'ᕰ',
		'ᕎ',
		'ᕸ',
		'ᔵ',
		'ᕚ',
		'ᕆ',
		'ᔴ',
		'ᔷ',
		'ᕩ',
		'ᕖ',
		'ᕫ',
		'ᕎ',
		'ᕐ',
		'ᕭ',
		'ᕃ',
		'ᕔ',
		'ᕪ',
		'ᕧ',
		'ᕲ',
		'ᕮ',
		'ᕗ',
		'ᕯ',
		'ᕘ',
		'ᕃ',
		'ᕢ',
		'ᕔ',
		'ᕷ',
		'ᕪ',
		'ᔺ',
		'ᕦ',
		'ᕐ',
		'ᕵ',
		'ᕷ',
		'ᕚ',
		'ᕳ',
		'ᔱ',
		'ᕬ',
		'ᕉ',
		'ᕩ',
		'ᕲ',
		'ᔹ',
		'ᕢ',
		'ᕎ',
		'ᕩ',
		'ᕴ',
		'ᕴ',
		'ᔴ',
		'ᕋ',
		'ᕖ',
		'ᕋ',
		'ᕭ',
		'ᕧ',
		'ᕷ',
		'ᕹ',
		'ᕱ',
		'ᔳ',
		'ᔴ',
		'ᕫ',
		'ᕵ',
		'ᕵ',
		'ᕇ',
		'ᕻ',
		'ᕱ',
		'ᕘ',
		'ᕘ',
		'ᕬ',
		'ᕉ',
		'ᕏ',
		'ᕑ',
		'ᕺ',
		'ᕉ',
		'ᕱ',
		'ᕃ',
		'ᕐ',
		'ᔱ',
		'ᕥ',
		'ᕨ',
		'ᕙ',
		'ᕫ',
		'ᕦ',
		'ᕋ',
		'ᕵ',
		'ᕖ',
		'ᕧ',
		'ᕺ',
		'ᕈ',
		'ᕕ',
		'ᕰ',
		'ᕲ',
		'ᕕ',
		'ᕂ',
		'ᔬ',
		'ᕆ',
		'ᕔ',
		'ᕩ',
		'ᔺ',
		'ᔸ',
		'ᔳ',
		'ᕙ',
		'ᕬ',
		'ᕲ',
		'ᕕ',
		'ᕕ',
		'ᕒ',
		'ᔾ',
		'ᔾ'
	};

	public static char[] char_1 = new char[280]
	{
		'ᗷ',
		'ᖶ',
		'ᗖ',
		'ᗺ',
		'ᗰ',
		'ᗌ',
		'ᖶ',
		'ᗤ',
		'ᖳ',
		'ᗰ',
		'ᖳ',
		'ᖬ',
		'ᖹ',
		'ᖬ',
		'ᗎ',
		'ᗑ',
		'ᗈ',
		'ᖰ',
		'ᗧ',
		'ᗢ',
		'ᖰ',
		'ᗘ',
		'ᗑ',
		'ᗄ',
		'ᗣ',
		'ᖵ',
		'ᗦ',
		'ᗰ',
		'ᗎ',
		'ᗉ',
		'ᗌ',
		'ᗋ',
		'ᗸ',
		'ᗐ',
		'ᗋ',
		'ᗕ',
		'ᗒ',
		'ᖱ',
		'ᗛ',
		'ᗢ',
		'ᗄ',
		'ᗅ',
		'ᗑ',
		'ᗲ',
		'ᖰ',
		'ᗩ',
		'ᖵ',
		'ᗳ',
		'ᖺ',
		'ᗙ',
		'ᖵ',
		'ᗙ',
		'ᗌ',
		'ᗋ',
		'ᖵ',
		'ᗳ',
		'ᗺ',
		'ᗢ',
		'ᗏ',
		'ᗑ',
		'ᗴ',
		'ᗇ',
		'ᗗ',
		'ᖱ',
		'ᗐ',
		'ᖶ',
		'ᗈ',
		'ᗵ',
		'ᗦ',
		'ᖴ',
		'ᗈ',
		'ᗎ',
		'ᗭ',
		'ᖷ',
		'ᖶ',
		'ᗣ',
		'ᗔ',
		'ᖸ',
		'ᗷ',
		'ᗌ',
		'ᗄ',
		'ᗎ',
		'ᗵ',
		'ᗗ',
		'ᗻ',
		'ᗰ',
		'ᗐ',
		'ᗣ',
		'ᗖ',
		'ᗨ',
		'ᗋ',
		'ᗐ',
		'ᗭ',
		'ᗘ',
		'ᗆ',
		'ᖳ',
		'ᗴ',
		'ᗵ',
		'ᗫ',
		'ᖰ',
		'ᖱ',
		'ᗖ',
		'ᗂ',
		'ᗵ',
		'ᖸ',
		'ᗸ',
		'ᗴ',
		'ᗹ',
		'ᗷ',
		'ᗐ',
		'ᗍ',
		'ᗹ',
		'ᗘ',
		'ᖱ',
		'ᗦ',
		'ᗳ',
		'ᗱ',
		'ᗃ',
		'ᗄ',
		'ᖺ',
		'ᗱ',
		'ᗋ',
		'ᗨ',
		'ᗱ',
		'ᗎ',
		'ᗅ',
		'ᗱ',
		'ᗯ',
		'ᗯ',
		'ᗇ',
		'ᗛ',
		'ᖱ',
		'ᗧ',
		'ᗺ',
		'ᗩ',
		'ᗂ',
		'ᗺ',
		'ᖴ',
		'ᗑ',
		'ᗎ',
		'ᗪ',
		'ᖵ',
		'ᖵ',
		'ᗨ',
		'ᗔ',
		'ᗳ',
		'ᗷ',
		'ᗂ',
		'ᗓ',
		'ᗨ',
		'ᗗ',
		'ᗹ',
		'ᗢ',
		'ᖴ',
		'ᗌ',
		'ᗥ',
		'ᗇ',
		'ᖷ',
		'ᗎ',
		'ᗈ',
		'ᗆ',
		'ᖷ',
		'ᗹ',
		'ᗇ',
		'ᗋ',
		'ᗫ',
		'ᗏ',
		'ᗦ',
		'ᗙ',
		'ᖬ',
		'ᗰ',
		'ᖴ',
		'ᖺ',
		'ᗻ',
		'ᖲ',
		'ᗚ',
		'ᗚ',
		'ᗲ',
		'ᗃ',
		'ᗥ',
		'ᗩ',
		'ᗥ',
		'ᗔ',
		'ᗑ',
		'ᗭ',
		'ᗪ',
		'ᖸ',
		'ᗇ',
		'ᗦ',
		'ᖹ',
		'ᗺ',
		'ᗚ',
		'ᗩ',
		'ᗸ',
		'ᗯ',
		'ᗐ',
		'ᖷ',
		'ᗫ',
		'ᗆ',
		'ᗹ',
		'ᖸ',
		'ᗇ',
		'ᗥ',
		'ᗇ',
		'ᗅ',
		'ᖱ',
		'ᗭ',
		'ᗄ',
		'ᗍ',
		'ᗲ',
		'ᗤ',
		'ᖷ',
		'ᗈ',
		'ᖳ',
		'ᗋ',
		'ᖸ',
		'ᖹ',
		'ᗥ',
		'ᗦ',
		'ᗃ',
		'ᖸ',
		'ᖵ',
		'ᗇ',
		'ᖵ',
		'ᗆ',
		'ᗍ',
		'ᖷ',
		'ᗸ',
		'ᗕ',
		'ᗮ',
		'ᗊ',
		'ᗍ',
		'ᗯ',
		'ᗩ',
		'ᗙ',
		'ᗳ',
		'ᗃ',
		'ᗂ',
		'ᖱ',
		'ᖲ',
		'ᗫ',
		'ᗌ',
		'ᗑ',
		'ᗷ',
		'ᗊ',
		'ᖵ',
		'ᗅ',
		'ᗔ',
		'ᗑ',
		'ᗬ',
		'ᗇ',
		'ᗄ',
		'ᗆ',
		'ᗒ',
		'ᗥ',
		'ᗣ',
		'ᗮ',
		'ᗷ',
		'ᗗ',
		'ᗂ',
		'ᗣ',
		'ᖴ',
		'ᗶ',
		'ᗺ',
		'ᗐ',
		'ᗨ',
		'ᗫ',
		'ᗉ',
		'ᗒ',
		'ᖴ',
		'ᖴ',
		'ᗑ',
		'ᗺ',
		'ᗃ',
		'ᗗ',
		'ᗅ',
		'ᗲ',
		'ᗒ',
		'ᖾ',
		'ᖾ'
	};

	private static char[] char_2 = new char[5]
	{
		'ᒜ',
		'ᓢ',
		'ᓓ',
		'ᓦ',
		'ᓢ'
	};

	public static GStruct42 gstruct42_0 = new GStruct42
	{
		int_129 = 0
	};

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static int int_2 = 0;

	public static int int_3 = 0;

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static long long_0 = 0L;

	private static string smethod_0(string string_0)
	{
		string text = string.Empty;
		int length = string_0.Length;
		for (int i = 0; i < string_0.Length; i++)
		{
			char c = string_0[i];
			if (c > 'ᎆ')
			{
				c = (char)(c - (5225 + length));
			}
			text += c;
		}
		return text;
	}

	public static string smethod_1(string string_0)
	{
		try
		{
			if (string_0 != null && string_0 != string.Empty)
			{
				byte[] array = Convert.FromBase64String(string_0);
				return Encoding.UTF8.GetString(array, 0, array.Length);
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	public static bool smethod_2(int int_4, uint uint_0)
	{
		int num = 0;
		byte[] array = new byte[8];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = 8;
		}
		while (true)
		{
			try
			{
				string text = "ᒘ";
				string text2 = "ᒖ";
				string text3 = string.Empty;
				string string_ = string.Empty;
				string string_2 = string.Empty;
				string[] array2 = new string[Class11.struct7_0.Length];
				string string_3 = string.Empty;
				string string_4 = string.Empty;
				int num2 = 0;
				string s = smethod_0(string.Concat(char_1));
				string string_5 = text;
				while (true)
				{
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(smethod_0(string_5), array);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(s)))
					{
						using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read))
						{
							using (StreamReader streamReader = new StreamReader(stream2))
							{
								text3 = streamReader.ReadToEnd();
							}
						}
					}
					if (text3 == string.Empty)
					{
						break;
					}
					num2++;
					switch (num2)
					{
					case 1:
						string_ = smethod_1(text3);
						s = smethod_0(string.Concat(char_0));
						string_5 = text;
						continue;
					case 2:
						string_2 = smethod_1(text3);
						s = string.Concat(Class11.struct7_0[0].char_0);
						s = smethod_0(s);
						string_5 = text;
						continue;
					case 3:
						array2[0] = smethod_1(text3);
						s = string.Concat(Class11.struct7_0[1].char_0);
						s = smethod_0(s);
						string_5 = text;
						continue;
					case 5:
						array2[2] = smethod_1(text3);
						s = string.Concat(Class11.char_8);
						s = smethod_0(s);
						string_5 = text;
						continue;
					case 6:
						string_3 = smethod_1(text3);
						s = string.Concat(Class11.char_9);
						s = smethod_0(s);
						string_5 = text;
						continue;
					case 4:
						array2[1] = smethod_1(text3);
						s = string.Concat(Class11.struct7_0[2].char_0);
						s = smethod_0(s);
						string_5 = text2;
						continue;
					case 7:
						string_4 = smethod_1(text3);
						break;
					}
					int int_5 = 0;
					byte[] array3 = new byte[2];
					byte[] array4 = null;
					array4 = Class11.smethod_42(string_, bool_1: false);
					array3 = BitConverter.GetBytes(array4.Length);
					bool flag = Class20.WriteProcessMemory(int_4, uint_0 + 256, array3, 4, ref int_5);
					bool flag2 = Class20.WriteProcessMemory(int_4, uint_0 + 256 + 4, array4, array4.Length, ref int_5);
					array4 = Class11.smethod_42(string_2, bool_1: false);
					array3 = BitConverter.GetBytes(array4.Length);
					bool flag3 = Class20.WriteProcessMemory(int_4, uint_0 + 512, array3, 4, ref int_5);
					bool flag4 = Class20.WriteProcessMemory(int_4, uint_0 + 512 + 4, array4, array4.Length, ref int_5);
					array4 = Class11.smethod_42(array2[0], bool_1: false);
					array3 = BitConverter.GetBytes(array4.Length);
					bool flag5 = Class20.WriteProcessMemory(int_4, uint_0 + 768, array3, 4, ref int_5);
					bool flag6 = Class20.WriteProcessMemory(int_4, uint_0 + 768 + 4, array4, array4.Length, ref int_5);
					array4 = Class11.smethod_42(array2[1], bool_1: false);
					array3 = BitConverter.GetBytes(array4.Length);
					bool flag7 = Class20.WriteProcessMemory(int_4, uint_0 + 1024, array3, 4, ref int_5);
					bool flag8 = Class20.WriteProcessMemory(int_4, uint_0 + 1024 + 4, array4, array4.Length, ref int_5);
					array4 = Class11.smethod_42(array2[2], bool_1: false);
					array3 = BitConverter.GetBytes(array4.Length);
					bool flag9 = Class20.WriteProcessMemory(int_4, uint_0 + 1280, array3, 4, ref int_5);
					bool flag10 = Class20.WriteProcessMemory(int_4, uint_0 + 1280 + 4, array4, array4.Length, ref int_5);
					array4 = Class11.smethod_42(string_3, bool_1: false);
					array3 = BitConverter.GetBytes(array4.Length);
					bool flag11 = Class20.WriteProcessMemory(int_4, uint_0 + 1536, array3, 4, ref int_5);
					bool flag12 = Class20.WriteProcessMemory(int_4, uint_0 + 1536 + 4, array4, array4.Length, ref int_5);
					array4 = Class11.smethod_42(string_4, bool_1: false);
					array3 = BitConverter.GetBytes(array4.Length);
					bool flag13 = Class20.WriteProcessMemory(int_4, uint_0 + 1792, array3, 4, ref int_5);
					bool flag14 = Class20.WriteProcessMemory(int_4, uint_0 + 1792 + 4, array4, array4.Length, ref int_5);
					array4 = Class11.smethod_42(string_4, bool_1: false);
					array3 = BitConverter.GetBytes(array4.Length);
					bool flag15 = Class20.WriteProcessMemory(int_4, uint_0 + 2048, array3, 4, ref int_5);
					bool flag16 = Class20.WriteProcessMemory(int_4, uint_0 + 2048 + 4, array4, array4.Length, ref int_5);
					return flag && flag2 && flag3 && flag4 && flag5 && flag6 && flag7 && flag8 && flag9 && flag10 && flag11 && flag12 && flag13 && flag14 && flag15 && flag16;
				}
				return false;
			}
			catch
			{
			}
			num++;
			if (num >= 3)
			{
				break;
			}
			Thread.Sleep(900);
		}
		return false;
	}

	private static GStruct42 smethod_3()
	{
		if (FormMain.gstruct42_0 != null)
		{
			int int_ = 0;
			uint foregroundWindow = Class20.GetForegroundWindow();
			Class20.GetWindowThreadProcessId(foregroundWindow, out int_);
			if (int_ > 0)
			{
				for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
				{
					if (int_ == FormMain.gstruct42_0[i].int_129)
					{
						return FormMain.gstruct42_0[i];
					}
				}
			}
		}
		GStruct42 result = default(GStruct42);
		result.int_129 = 0;
		return result;
	}

	public static void smethod_4()
	{
		Process currentProcess = Process.GetCurrentProcess();
		int num = Class20.OpenProcess(2035711, bool_0: false, currentProcess.Id);
		uint num2 = Class20.smethod_1(num, 1280u);
		Class55.smethod_10(Class47.string_0, (currentProcess.Id * 3).ToString(), num2, "DWORD", 1);
		Class20.smethod_31(num2, num, (uint)currentProcess.Id);
		num2 = Class20.smethod_1(num, 4096u);
		smethod_2(num, num2);
		Class11.int_1 = num;
		Class11.uint_0 = num2;
		Class11.uint_1 = Class20.smethod_1(num);
		while (true)
		{
			try
			{
				smethod_5();
				return;
			}
			catch
			{
				Thread.Sleep(300);
			}
		}
	}

	public static void smethod_5()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		GStruct41[] array = new GStruct41[6]
		{
			new GStruct41
			{
				byte_0 = new byte[3]
				{
					115,
					105,
					116
				}
			},
			new GStruct41
			{
				byte_0 = new byte[2]
				{
					105,
					110
				}
			},
			new GStruct41
			{
				byte_0 = new byte[2]
				{
					110,
					101
				}
			},
			new GStruct41
			{
				byte_0 = new byte[2]
				{
					116,
					111
				}
			},
			new GStruct41
			{
				byte_0 = new byte[2]
				{
					50,
					54
				}
			},
			new GStruct41
			{
				byte_0 = new byte[2]
				{
					99,
					108
				}
			}
		};
		while (true)
		{
			Thread.Sleep(80);
			if (Class11.bool_0)
			{
				break;
			}
			if (!GClass1.bool_0)
			{
				continue;
			}
			num--;
			int j;
			if (0 > num)
			{
				num = 10;
				num4++;
				if (FormMayphu.bool_1)
				{
					FormMain.int_6 = 0;
					FormMain.int_7 = 0;
				}
				gstruct42_0 = smethod_3();
				if (int_0 != gstruct42_0.int_129 && gstruct42_0.int_129 > 0)
				{
					int_0 = gstruct42_0.int_129;
				}
				if (num4 >= 100)
				{
					num4 = 0;
					bool flag = true;
					if (FormMain.gstruct42_0 != null && FormMain.int_109 > 0)
					{
						for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
						{
							int num5 = Class33.smethod_0(FormMain.gstruct42_0[i]);
							if ((463 < num5 && num5 < 472) || (479 < num5 && num5 < 496))
							{
								flag = false;
								break;
							}
						}
					}
					if (flag)
					{
						Class7.int_0 = null;
						Class7.gstruct20_0 = null;
					}
					if (GClass1.long_1 > 0L && GClass1.string_0 != null)
					{
						int num6 = 0;
						int num7 = GClass1.string_0.Length;
						for (int i = 0; i < num7; i++)
						{
							int length = GClass1.string_0[i].Length;
							for (j = 0; j < length; j++)
							{
								int k;
								if (GClass1.string_0[i] != null && !(GClass1.string_0[i] == string.Empty))
								{
									if (GClass1.string_0[i][j] != '.')
									{
										continue;
									}
									for (k = 0; k < array.Length; k++)
									{
										int num8 = 0;
										while (num8 < array[k].byte_0.Length)
										{
											if (length > j + num8 + 1 && array[k].byte_0[num8] == GClass1.string_0[i][j + num8 + 1])
											{
												num8++;
												continue;
											}
											goto IL_0339;
										}
										goto IL_0364;
										IL_0339:;
									}
								}
								else
								{
									num6++;
								}
								continue;
								IL_0364:
								if (k != 0)
								{
									num6++;
								}
								else
								{
									Class47.int_0++;
								}
								break;
							}
						}
						Class7.bool_0 = (Class7.bool_0 || num6 < num7 || Class47.int_0 > 0);
						if (Class47.int_0 > 0)
						{
							if (!FormMain.bool_1)
							{
								Class20.smethod_5(Class11.smethod_1(Class11.char_35));
							}
							Class11.smethod_24(ref Class11.string_14, Class11.smethod_16(Class11.smethod_30(smethod_0(string.Concat(Class11.char_43)), "!", new byte[8])));
						}
					}
				}
			}
			int num9;
			if (!FormMayphu.bool_1 && FormMain.gstruct42_0 != null && GClass1.gstruct14_0 != null && Class11.smethod_23(long_0) > 90000L)
			{
				int[] array2 = new int[FormMain.gstruct42_0.Length];
				for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
				{
					array2[i] = FormMain.gstruct42_0[i].int_129;
				}
				num9 = 0;
				GStruct24[] array3 = Class42.smethod_0(array2);
				if (array3 == null)
				{
					if (GClass1.gstruct13_0.bool_0 && GClass1.gstruct13_0.uint_1 != null && (!Class26.bool_0 || Class11.long_0 < GClass1.long_1))
					{
						for (j = 0; j < GClass1.gstruct14_0.Length; j++)
						{
							if (GClass1.gstruct14_0[j].long_0 <= GClass1.long_1)
							{
								continue;
							}
							int num10 = 0;
							while (num10 < GClass1.gstruct13_0.uint_1.Length)
							{
								if (GClass1.gstruct14_0[j].uint_0 != GClass1.gstruct13_0.uint_1[num10])
								{
									num10++;
									continue;
								}
								goto IL_0546;
							}
						}
					}
				}
				else
				{
					for (int i = 0; i < array3.Length; i++)
					{
						j = 0;
						while (j < GClass1.gstruct14_0.Length)
						{
							bool flag2 = GClass1.gstruct14_0[j].uint_0 == array3[i].uint_0;
							bool flag3 = GClass1.gstruct14_0[j].long_0 > GClass1.long_1;
							if ((!flag2 || !flag3) && (Class11.struct7_0.Length > GClass1.int_0 || GClass1.long_0 != 0L))
							{
								j++;
								continue;
							}
							goto IL_05ef;
						}
					}
				}
				goto IL_0695;
			}
			goto IL_069f;
			IL_05f3:
			FormMayphu.bool_1 = true;
			DateTime dateTime = new DateTime(GClass1.gstruct14_0[num9].long_0);
			FormMayphu.int_1 = new int[3]
			{
				dateTime.Day,
				dateTime.Month,
				dateTime.Year
			};
			FormMayphu.string_1 = GClass1.gstruct14_0[num9].string_1;
			FormMayphu.bool_2 = (GClass1.gstruct14_0[num9].int_0 == 1);
			FormMayphu.bool_3 = (GClass1.gstruct14_0[num9].int_1 > 0);
			FormMain.int_6 = 0;
			FormMain.int_7 = 0;
			goto IL_0695;
			IL_0695:
			long_0 = Class11.smethod_22();
			goto IL_069f;
			IL_05ef:
			num9 = j;
			goto IL_05f3;
			IL_0546:
			num9 = j;
			goto IL_05f3;
			IL_069f:
			if (gstruct42_0.int_129 > 0)
			{
				if (!bool_0)
				{
					num2--;
					if (FormMain.int_61 > 0 && num2 <= 0)
					{
						num2 = 3;
						int_3 = Class73.smethod_3(gstruct42_0);
						if (num3 != gstruct42_0.int_129)
						{
							num3 = gstruct42_0.int_129;
							GClass0.int_2 = int_3;
						}
						if (GClass0.intptr_0 == IntPtr.Zero || int_3 - GClass0.int_2 > 120)
						{
							GClass0.int_2 = int_3;
							bool_0 = true;
							num2 = 12;
						}
					}
				}
				if (int_2 > 0 && FormMain.gstruct42_0 != null)
				{
					for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
					{
						FormMain.gstruct42_0[i].int_75[4] = int_2;
					}
				}
				if (int_1 == 1)
				{
					Class60.smethod_102(gstruct42_0, 34u);
				}
				else if (int_1 != 2)
				{
					if (int_1 == 3)
					{
						Class46.smethod_0(gstruct42_0);
					}
					else if (int_1 != 4)
					{
						if (int_1 != 5)
						{
							if (int_1 != 6)
							{
								if (int_1 != 7)
								{
									if (int_1 == 8)
									{
										for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
										{
											if (FormMain.gstruct42_0[i].bool_36 && FormMain.gstruct42_0[i].int_123[0] > 0)
											{
												Class60.smethod_2(FormMain.gstruct42_0[i], Class60.uint_13, 1, 4);
											}
										}
									}
								}
								else
								{
									for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
									{
										if (FormMain.gstruct42_0[i].bool_36 && FormMain.gstruct42_0[i].int_123[0] > 0)
										{
											Class60.smethod_2(FormMain.gstruct42_0[i], Class60.uint_13, 1, 4);
										}
									}
								}
							}
							else
							{
								Class39.smethod_20(gstruct42_0.int_129);
							}
						}
						else
						{
							Class39.long_0[3] = 0L;
							Class39.long_0[2] = Class11.smethod_22();
							Class39.long_0[1] = 2L;
							Class39.long_0[0] = gstruct42_0.int_129;
						}
					}
					else
					{
						Class39.long_0[3] = 0L;
						Class39.long_0[2] = Class11.smethod_22();
						Class39.long_0[1] = 1L;
						Class39.long_0[0] = gstruct42_0.int_129;
					}
				}
				else
				{
					Class60.smethod_102(gstruct42_0, 18u);
				}
				if (GClass0.int_1 == Class24.int_4 || bool_1)
				{
					if (!bool_1)
					{
						GClass0.int_1 = 0;
					}
					for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
					{
						if (FormMain.gstruct42_0[i].bool_36)
						{
							Class60.smethod_2(FormMain.gstruct42_0[i], Class60.uint_12, 1, 4);
						}
					}
				}
			}
			int_1 = 0;
			int_2 = 0;
			bool_1 = false;
		}
	}
}
