internal class Class24
{
	public static int int_0 = 112;

	public static int int_1 = 113;

	public static int int_2 = 118;

	public static int int_3 = 119;

	public static int int_4 = 120;

	public static int int_5 = 121;

	public static int int_6 = 107;

	public static int int_7 = 187;

	public static int int_8 = 109;

	public static int int_9 = 189;

	public static int int_10 = 90;

	public static int int_11 = 88;

	public static int int_12 = 75;

	public static int int_13 = 65;

	public static int int_14 = 83;

	public static int int_15 = 70;

	public static int int_16 = 71;

	public static GStruct38[] gstruct38_0 = new GStruct38[10]
	{
		new GStruct38
		{
			string_0 = "A",
			int_0 = 65
		},
		new GStruct38
		{
			string_0 = "S",
			int_0 = 83
		},
		new GStruct38
		{
			string_0 = "Z",
			int_0 = 90
		},
		new GStruct38
		{
			string_0 = "X",
			int_0 = 88
		},
		new GStruct38
		{
			string_0 = "4",
			int_0 = 52
		},
		new GStruct38
		{
			string_0 = "5",
			int_0 = 53
		},
		new GStruct38
		{
			string_0 = "6",
			int_0 = 54
		},
		new GStruct38
		{
			string_0 = "7",
			int_0 = 55
		},
		new GStruct38
		{
			string_0 = "8",
			int_0 = 56
		},
		new GStruct38
		{
			string_0 = "9",
			int_0 = 57
		}
	};

	public static GStruct38[] gstruct38_1 = new GStruct38[9]
	{
		new GStruct38
		{
			string_0 = "1",
			int_0 = 49
		},
		new GStruct38
		{
			string_0 = "2",
			int_0 = 50
		},
		new GStruct38
		{
			string_0 = "3",
			int_0 = 51
		},
		new GStruct38
		{
			string_0 = "4",
			int_0 = 52
		},
		new GStruct38
		{
			string_0 = "5",
			int_0 = 53
		},
		new GStruct38
		{
			string_0 = "6",
			int_0 = 54
		},
		new GStruct38
		{
			string_0 = "7",
			int_0 = 55
		},
		new GStruct38
		{
			string_0 = "8",
			int_0 = 56
		},
		new GStruct38
		{
			string_0 = "9",
			int_0 = 57
		}
	};

	public static GStruct38[] gstruct38_2 = new GStruct38[2]
	{
		new GStruct38
		{
			string_0 = "F2",
			int_0 = 113
		},
		new GStruct38
		{
			string_0 = "A",
			int_0 = 65
		}
	};

	public static int smethod_0(GStruct38[] gstruct38_3, string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < gstruct38_3.GetLength(0))
			{
				if (string_0 == gstruct38_3[num].string_0)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return gstruct38_3[num].int_0;
	}

	public static string smethod_1(GStruct38[] gstruct38_3, int int_17)
	{
		int num = 0;
		while (true)
		{
			if (num < gstruct38_3.GetLength(0))
			{
				if (int_17 == gstruct38_3[num].int_0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return gstruct38_3[num].string_0;
	}
}
