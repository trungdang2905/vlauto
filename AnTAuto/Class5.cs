using System;

internal class Class5
{
	private struct Struct6
	{
		public int int_0;

		public int int_1;

		public string string_0;
	}

	public GStruct42 gstruct42_0 = default(GStruct42);

	public string string_0 = null;

	private bool method_0(string string_1, ref string string_2)
	{
		if (!(string_1 == string_2))
		{
			string text = "";
			for (int i = 0; i < string_1.Length && string_2.Length > i && string_1[i] == string_2[i]; i++)
			{
				text += string_1[i];
			}
			if (text.Length > 4)
			{
				string_2 = text;
				return true;
			}
			return false;
		}
		return true;
	}

	private void method_1(int int_0, string string_1, ref Struct6[] struct6_0)
	{
		Struct6 @struct = default(Struct6);
		@struct.int_1 = int_0;
		@struct.int_0 = 1;
		@struct.string_0 = string_1;
		Struct6 struct2 = @struct;
		if (struct6_0 != null && struct6_0.Length != 0)
		{
			Struct6[] array = new Struct6[struct6_0.Length + 1];
			for (int i = 0; i < struct6_0.Length; i++)
			{
				if (int_0 != struct6_0[i].int_1 || !method_0(string_1, ref struct6_0[i].string_0))
				{
					array[i] = struct6_0[i];
					continue;
				}
				struct6_0[i].int_0++;
				return;
			}
			array[array.Length - 1] = struct2;
			struct6_0 = array;
		}
		else
		{
			struct6_0 = new Struct6[1]
			{
				struct2
			};
		}
	}

	public void method_2()
	{
		Class20.smethod_30(Class47.gstruct43_123.uint_0, gstruct42_0.int_130);
		uint num = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_ = gstruct42_0.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_0.int_130, uint_, array, 4, ref int_);
		int num2 = BitConverter.ToInt32(array, 0);
		Struct6[] struct6_ = null;
		int[] array2 = new int[6];
		int num3 = 0;
		int num4 = 0;
		for (int i = 1; i < 256; i++)
		{
			if (num2 <= num4)
			{
				break;
			}
			uint num5 = (uint)((int)num + i * (int)Class47.gstruct43_15.uint_0);
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_50.uint_0, array, 4, ref int_);
			if (BitConverter.ToInt32(array, 0) <= 0 || Class20.smethod_30(num5 + Class47.gstruct43_52.uint_0, gstruct42_0.int_130) != 1)
			{
				continue;
			}
			int num6 = (int)Class20.smethod_30(num5 + Class47.gstruct43_54.uint_0, gstruct42_0.int_130);
			if (num6 > 4)
			{
				num6 = 5;
			}
			num3++;
			array2[num6]++;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num5 + Class47.gstruct43_85.uint_0, array, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array, 0);
			string text = Class20.smethod_28(num5 + Class47.gstruct43_86.uint_0, gstruct42_0.int_130, 24);
			if (num7 != 0 && text != null && text != string.Empty)
			{
				string text2 = string.Empty;
				for (int j = 0; j < text.Length; j++)
				{
					text2 += text[j];
					if (Class11.smethod_7(text2) == num7)
					{
						text = text2;
						break;
					}
				}
			}
			method_1(num6, text, ref struct6_);
		}
		if (struct6_ == null)
		{
			return;
		}
		string text3 = "";
		uint[] array3 = Class32.smethod_29(gstruct42_0);
		if (array3 != null)
		{
			object obj = text3;
			text3 = obj + " (" + array3[0] / 256u + "," + array3[1] / 512u + ")";
		}
		string[] array4 = new string[6]
		{
			"Tr¾ng",
			"Vµng ",
			"TÝm  ",
			"Xanh ",
			"§á   ",
			"Kh\u00b8c "
		};
		string text4 = null;
		for (int i = 0; i < array2.Length; i++)
		{
			if (array2[i] > 0)
			{
				if (text4 != null)
				{
					text4 += ", ";
				}
				text4 = text4 + array4[i].Replace(" ", "") + ":" + array2[i].ToString();
			}
		}
		string[] array5 = new string[struct6_.Length];
		if (struct6_ != null)
		{
			for (int i = 0; i < struct6_.Length; i++)
			{
				array5[i] = array4[struct6_[i].int_1] + ": " + struct6_[i].int_0 + ", " + struct6_[i].string_0;
			}
		}
		if (string_0 == null || string_0 == "")
		{
			Class60.smethod_55(gstruct42_0, "ClearMessage()");
			Class60.smethod_50(gstruct42_0, "-------------------------------------------");
			for (int i = 0; i < array5.Length; i++)
			{
				if (array5[i] != null)
				{
					Class60.smethod_50(gstruct42_0, "<color=green>" + array5[i]);
				}
			}
			Class60.smethod_50(gstruct42_0, "-------------------------------------------");
			Class60.smethod_50(gstruct42_0, "<color=green>Map  : " + Class33.smethod_1(Class33.smethod_0(gstruct42_0)) + text3);
			Class60.smethod_50(gstruct42_0, "<color=yellow>Tæng : " + num3.ToString() + "<color=green> (" + text4 + ")");
			Class60.smethod_50(gstruct42_0, "-------------------------------------------");
		}
		string_0 += "|CH_CHATROOM";
		string[] array6 = string_0.Split('|');
		if (array6.Length <= 0)
		{
			return;
		}
		string text5 = "Tæng:" + num3.ToString() + " (" + text4 + "). B¶n ®å: " + Class33.smethod_1(Class33.smethod_0(gstruct42_0)) + text3;
		for (int i = 0; i < array6.Length; i++)
		{
			if (array6[i] != "")
			{
				string text6 = "Chat('" + array6[i] + "', '" + text5 + "')";
				Class60.smethod_55(gstruct42_0, text6);
			}
		}
	}

	private static string smethod_0(string string_1)
	{
		byte[,] array = new byte[7, 2]
		{
			{
				133,
				32
			},
			{
				148,
				32
			},
			{
				149,
				32
			},
			{
				153,
				32
			},
			{
				160,
				32
			},
			{
				217,
				32
			},
			{
				196,
				32
			}
		};
		for (int i = 0; i < array.GetLength(0); i++)
		{
			string_1 = string_1.Replace((char)array[i, 0], (char)array[i, 1]);
		}
		return string_1;
	}
}
