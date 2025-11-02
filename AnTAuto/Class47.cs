using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

internal class Class47
{
	public static string string_0 = "SOFTWARE\\KYKeoxe";

	public static string string_1 = "OFFLINE";

	public static string[] string_2 = Class11.smethod_16(Class55.smethod_6("DanhSachLoaitru", 0)).Split('|');

	public static char[] char_0 = new char[6]
	{
		'ᓦ',
		'ᓘ',
		'ᓝ',
		'ᓓ',
		'ᓘ',
		'ᓡ'
	};

	public static string string_3 = '\r'.ToString() + '\n'.ToString();

	public static string string_4 = Directory.GetCurrentDirectory().ToString();

	public static string string_5 = string_4 + "\\Config";

	public static string string_6 = string_5 + "\\AllUser";

	public static string string_7 = string_5 + "\\Combo";

	public static string string_8 = string_5 + "\\Skill";

	public static string string_9 = string_5 + "\\OfflineName.txt";

	public static string string_10 = string_5 + "\\Medicin.txt";

	public static string string_11 = string_5 + "\\tbMayphu.txt";

	public static string string_12 = string_4 + "\\Map";

	public static string string_13 = "GameData.dat";

	public static string string_14 = string.Empty;

	public static string string_15 = string.Empty;

	public static string string_16 = "GameSum";

	public static string string_17 = "Sword3 Class";

	public static int int_0 = 0;

	public static int int_1 = 600;

	public static long long_0 = 637264777700000000L;

	public static int[] int_2 = new int[]
    {
        7,
        8,
        9,
        10,
        11,
        12,
        22,
        26,
        27,
        28,
        54,
        58,
        59,
        60,
        63,
        64,
        65,
        66
    };

    public static int[] int_3 = new int[]
    {
        35300,
        33300,
        32300,
        31300,
        30300,
        28300,
        27300,
        26300,
        25300,
        24300,
        22300,
        21300,
        20300,
        19300,
        18300,
        17300,
        16300,
        16300,
        15300,
        15300
    };


    public static int[] int_4 = new int[]
    {
        45300,
        43300,
        42300,
        40300,
        39300,
        37300,
        36300,
        35300,
        33300,
        32300,
        30300,
        29300,
        27300,
        26300,
        25300,
        24300,
        23300,
        22300,
        21300,
        20300
    };

    private static int[,] int_5 = new int[12, 2]
	{
		{
			400,
			55
		},
		{
			621,
			83
		},
		{
			685,
			174
		},
		{
			714,
			289
		},
		{
			660,
			376
		},
		{
			578,
			463
		},
		{
			400,
			496
		},
		{
			204,
			480
		},
		{
			75,
			356
		},
		{
			65,
			285
		},
		{
			90,
			142
		},
		{
			222,
			30
		}
	};

	public static string[] string_18 = new string[22]
	{
		"None",
		"Đứng im",
		"Đi bộ",
		"Chạy",
		"Nhảy",
		"Buff",
		"Đánh phép thuật",
		"Đánh",
		"Ngồi",
		"Bị đánh",
		"Chết",
		"Phòng thủ",
		"Nghỉ ngơi",
		"SpecialSkill",
		"Special1",
		"Special2",
		"Special3",
		"Special4",
		"Chạy tấn công",
		"Đánh liên tiếp",
		"Nhảy tấn công",
		"Về dưỡng sức"
	};

	public static string[,] string_19 = new string[5, 3]
	{
		{
			"Ngò Hoa Ngäc Lé Hoµn",
			"Thõa Tiªn MËt",
			null
		},
		{
			"Cöu ChuyÓn Hoµn Hån ®an",
			"Håi Thiªn ®an",
			"Kim S\u00b8ng D­îc"
		},
		{
			"¤ ®Çu Hoµn thÇn ®an",
			"§¹i Bæ t\u00b8n",
			"Ng­ng ThÇn ®an"
		},
		{
			"Ng©n KiÒu Khø ®éc ®an",
			"Ho¾c H­¬ng ChÝnh khÝ hoµn",
			null
		},
		{
			"Tam Hoa T\u00b8n",
			null,
			null
		}
	};

	public static GStruct41[] gstruct41_0 = new GStruct41[3]
	{
        new GStruct41
            {
                byte_0 = new byte[]
                {
                    144,
                    236,
                    100,
                    80
                }
            },
            new GStruct41
            {
                byte_0 = new byte[]
                {
                    182,
                    204,
                    93,
                    138
                }
            },
            new GStruct41
            {
                byte_0 = new byte[]
                {
                    132,
                    11,
                    31,
                    92
                }
            }
    };

	public static uint uint_0 = 1021173855u;

	public static uint uint_1 = 70432u;

	public static uint uint_2 = 70436u;

	public static uint uint_3 = 70440u;

	public static uint uint_4 = 4368u;

	public static uint uint_5 = 4372u;

	public static uint uint_6 = 4412u;

	public static uint[] uint_7 = new uint[2]
	{
		1648u,
		1660u
	};

	public static GStruct43 gstruct43_0 = new GStruct43
	{
		string_0 = "KEY_PRESS_COUNT",
		string_1 = "83 ?? ?? ?? ?? ?? ?? ?? C7 ?? ?? ?? ?? ?? ?? 6A 11",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 4,
		byte_4 = 1
	};

	private static string string_20 = "8D ?? ?? ?? ?? ?? 3B ?? 75 ?? C7 ?? ?? ?? ?? ?? ?? ?? 83 ?? ?? 81 ?? ?? ?? ?? ?? 83";

	public static GStruct43 gstruct43_1 = new GStruct43
	{
		string_0 = "INFECT_SIZE",
		string_1 = string_20,
		int_2 = 4,
		byte_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_2 = new GStruct43
	{
		string_0 = "INFECT_LENGTH",
		string_1 = string_20,
		int_2 = 4,
		byte_2 = 1,
		int_0 = 23
	};

	public static GStruct43 gstruct43_3 = new GStruct43
	{
		string_0 = "KTabFileLoad",
		string_1 = "C6 ?? ?? 01 68 ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? FF ?? ?? ?? ?? ?? 85 ?? 75",
		int_2 = 0,
		byte_2 = 1,
		int_0 = 4
	};

	public static GStruct43 gstruct43_4 = new GStruct43
	{
		string_0 = "ENGINE_DISABLE_CASH_1",
		string_1 = "8B ?? ?? ?? ?? ?? ?? ?? ?? 33 C0 59 C3 57 8B",
		byte_0 = Class11.smethod_10("80 38 00 75 04 33 C0 59 C3 57"),
		int_2 = 0,
		byte_2 = 1,
		int_0 = 4
	};

	public static GStruct43 gstruct43_5 = new GStruct43
	{
		string_0 = "ENGINE_HANDLE",
		string_1 = "8B 0D ?? ?? ?? ?? 8B 01 8B 40 ?? FF E0",
		int_2 = 4,
		byte_2 = 1,
		int_0 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_6 = new GStruct43
	{
		string_0 = "MOUSE_POS",
		string_1 = "8B ?? ?? 8B ?? ?? 8B ?? 8B ?? ?? ?? ?? 68 A1 02 00 00",
		int_2 = 1,
		byte_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_7 = new GStruct43
	{
		string_0 = "MSVCR80_invalid_parameter_noinfo",
		string_1 = "C1 ?? 03 3B ?? 72 ?? FF 15 ?? ?? ?? ?? 8B",
		int_2 = 4,
		byte_2 = 1,
		int_0 = 9,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_8 = new GStruct43
	{
		string_0 = "FUNC_BAO_DANH",
		string_1 = "8B ?? ?? 04 3D ?? ?? ?? ?? 74 ?? 89 ?? ?? ?? E9 ?? ?? ?? ?? 8B ?? ?? ?? 8D ?? ?? ?? ?? ?? 3B ?? 75 ?? 6A 00",
		int_2 = 0,
		byte_2 = 1,
		int_0 = 0
	};

	public static GStruct43 gstruct43_9 = new GStruct43
	{
		string_0 = "NPC_COUNT_BASE_ADDR",
		string_1 = "6A 4F ?? FF ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 88",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 13,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_10 = new GStruct43
	{
		string_0 = "NPC_COUNT_SIZE",
		string_1 = "0F 87 ?? ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? 6A ?? 89",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 9
	};

	private static string string_21 = "8B ?? ?? ?? ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? A1 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8D";

	public static GStruct43 gstruct43_11 = new GStruct43
	{
		string_0 = "KPLAYER_ADDR",
		string_1 = string_21,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_12 = new GStruct43
	{
		string_0 = "KPLAYER_SIZE",
		string_1 = string_21,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 10
	};

	public static GStruct43 gstruct43_13 = new GStruct43
	{
		string_0 = "PLAYER_INDEX_OFF",
		string_1 = string_21,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 31
	};

	public static GStruct43 gstruct43_14 = new GStruct43
	{
		string_0 = "NPC_BASE_ADD",
		string_1 = string_21,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 37
	};

	public static GStruct43 gstruct43_15 = new GStruct43
	{
		string_0 = "NPC_DATA_SIZE",
		string_1 = string_21,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 43
	};

	public static GStruct43 gstruct43_16 = new GStruct43
	{
		string_0 = "NPC_NAME_OFFSET",
		string_1 = string_21,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 50
	};

	public static GStruct43 gstruct43_17 = new GStruct43
	{
		string_0 = "NPC_SEX_OFFSET",
		string_1 = "69 ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 3B ?? ?? 74",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 9
	};

	private static string string_22 = "8B ?? ?? ?? ?? ?? 83 ?? FF 0F ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? EB ?? 8B ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? E8";

	public static GStruct43 gstruct43_18 = new GStruct43
	{
		string_0 = "KSHOP_SIZE",
		string_1 = string_22,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_19 = new GStruct43
	{
		string_0 = "KITEM_INFO_BASE_ADDR",
		string_1 = string_22,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 38,
		byte_4 = 1
	};

	private static string string_23 = "8B ?? ?? ?? ?? 0F ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? ?? ?? 75 ?? ?? ?? 69";

	private static string string_24 = "7D ?? 8B ?? ?? 85 ?? 74 ?? 8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8B";

	public static GStruct43 gstruct43_20 = new GStruct43
	{
		string_0 = "KITEM_INFO_KEY",
		string_1 = string_23,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 2,
		string_2 = string_24,
		byte_3 = 1,
		int_3 = 1,
		int_1 = 4
	};

	public static GStruct43 gstruct43_21 = new GStruct43
	{
		string_0 = "KINFO_SIZE",
		string_1 = string_23,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 20,
		string_2 = string_24,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 17
	};

	public static GStruct43 gstruct43_22 = new GStruct43
	{
		string_0 = "KINFO_TEXT",
		string_1 = string_23,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 33,
		string_2 = string_24,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 23
	};

	public static GStruct43 gstruct43_23 = new GStruct43
	{
		string_0 = "NPC_LEVEL_CAPTION",
		string_1 = "73 ?? 8B ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? FF 15 ?? ?? ?? ?? 6A 00 6A 00",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 4
	};

	public static GStruct43 gstruct43_24 = new GStruct43
	{
		string_0 = "NPC_EXP_1",
		string_1 = "8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 83 ?? ?? DF ?? ?? ?? ?? ?? ?? DD",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 18
	};

	public static GStruct43 gstruct43_25 = default(GStruct43);

	public static GStruct43 gstruct43_26 = new GStruct43
	{
		string_0 = "NPC_GOLD",
		string_1 = "8D ?? ?? E8 ?? ?? ?? ?? 8B ?? F7 ?? 1B ?? F7 ?? 83 ?? ?? E9",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_27 = new GStruct43
	{
		string_0 = "MAPID_BASE_ADDR",
		string_1 = "3B ?? ?? ?? ?? ?? 75 ?? 6A 00 6A 00 6A 05",
		int_2 = 4,
		byte_2 = 1,
		int_0 = -4
	};

	public static GStruct43 gstruct43_28 = new GStruct43
	{
		string_0 = "MAP_NAME_BASE_ADDR",
		string_1 = "8D ?? ?? ?? ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? F7",
		int_2 = 4,
		byte_2 = 1,
		int_0 = 6,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_29 = new GStruct43
	{
		string_0 = "MAP_NAME_SIZE",
		string_1 = "8B ?? ?? ?? 8D ?? ?? ?? ?? ?? 2B ?? 8D ?? ?? ?? ?? 88 ?? ?? 83 ?? 01",
		int_2 = 4,
		byte_2 = 1,
		int_0 = 6,
		byte_4 = 0
	};

	public static GStruct43 gstruct43_30 = new GStruct43
	{
		string_0 = "KNPC_BASE_SIZE",
		string_1 = "83 ?? ?? 8D ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 8B",
		int_2 = 4,
		byte_2 = 1,
		int_0 = 18,
		byte_4 = 0
	};

	public static GStruct43 gstruct43_31 = new GStruct43
	{
		string_0 = "ATTACK_RANGE",
		string_1 = "8B ?? ?? ?? ?? ?? ?? ?? 0F ?? ?? 3B ?? 7F",
		int_2 = 4,
		byte_2 = 1,
		int_0 = 2,
		byte_4 = 0
	};

	public static GStruct43 gstruct43_32 = new GStruct43
	{
		string_0 = "BUFF_BASE_ADDR",
		string_1 = "75 ?? 8B ?? ?? 8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8B ?? ?? 8B ?? ?? ?? 8B ?? ?? ?? E8",
		int_2 = 4,
		byte_2 = 1,
		int_0 = 7,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_33 = new GStruct43
	{
		string_0 = "BUFF_BASE_SIZE",
		string_1 = "75 ?? 8B ?? ?? 8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8B ?? ?? 8B ?? ?? ?? 8B ?? ?? ?? E8",
		int_2 = 4,
		byte_2 = 1,
		int_0 = 13,
		byte_4 = 0
	};

	public static GStruct43 gstruct43_34 = new GStruct43
	{
		string_0 = "BUFF_BASE_OFFSET",
		string_1 = "75 ?? 8B ?? ?? 8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8B ?? ?? 8B ?? ?? ?? 8B ?? ?? ?? E8",
		int_2 = 1,
		byte_2 = 1,
		int_0 = 19,
		byte_4 = 0
	};

	private static string string_25 = "75 ?? 8B ?? ?? ?? 89 ?? ?? ?? ?? ?? 8B ?? ?? ?? 89 ?? ?? ?? ?? ?? 8B ?? ?? ?? 89 ?? ?? ?? ?? ?? 89";

	public static GStruct43 gstruct43_35 = new GStruct43
	{
		string_0 = "BUFF_DOING_OFFSET",
		string_1 = string_25,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 8
	};

	public static GStruct43 gstruct43_36 = new GStruct43
	{
		string_0 = "BUFF_SKILL_ID_OFFSET",
		string_1 = string_25,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 18
	};

	public static GStruct43 gstruct43_37 = new GStruct43
	{
		string_0 = "BUFF_POS_X_OFFSET",
		string_1 = string_25,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 28
	};

	public static GStruct43 gstruct43_38 = new GStruct43
	{
		string_0 = "BUFF_POS_Y_OFFSET",
		string_1 = string_25,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 34
	};

	public static GStruct43 gstruct43_39 = new GStruct43
	{
		string_0 = "BUFF_COUNT_OFFSET",
		string_1 = "33 ?? 39 ?? ?? 7E ?? ?? 33 ?? 8B ?? 8B ?? ?? 03 ?? E8 ?? ?? ?? ?? 83 ?? 01 81 ?? ?? ?? ?? ?? 3B ?? ?? 7C",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 4
	};

	private static string string_26 = "8B ?? 8D ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 74 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 03";

	public static GStruct43 gstruct43_40 = new GStruct43
	{
		string_0 = "BUFF_COMPARE_SIZE",
		string_1 = string_26,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 4
	};

	public static GStruct43 gstruct43_41 = new GStruct43
	{
		string_0 = "BUFF_TIME_OFFSET",
		string_1 = string_26,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 39
	};

	public static GStruct43 gstruct43_42 = new GStruct43
	{
		string_0 = "BUFF_TIME_SIZE",
		string_1 = "8D ?? ?? ?? ?? ?? 8B ?? 89 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 0F",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_43 = new GStruct43
	{
		string_0 = "CHAR_FIGHT_OFFSET",
		string_1 = "69 ?? ?? ?? ?? ?? 03 ?? 83 ?? ?? ?? ?? ?? 01 0F 85",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 10
	};

	public static GStruct43 gstruct43_44 = new GStruct43
	{
		string_0 = "RIDE_HORSE_OFFSE",
		string_1 = "80 ?? ?? 02 39 ?? ?? ?? ?? ?? 74 ?? 80",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 6
	};

	private static string string_27 = "6A ?? 8B ?? ?? ?? ?? ?? 89 ?? 8B ?? ?? ?? ?? ?? 89 ?? ?? 8B ?? ?? ?? ?? ?? 89";

	public static GStruct43 gstruct43_45 = new GStruct43
	{
		string_0 = "HP1_OFFSET",
		string_1 = string_27,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 4
	};

	public static GStruct43 gstruct43_46 = new GStruct43
	{
		string_0 = "MP1_OFFSET",
		string_1 = string_27,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 12
	};

	public static GStruct43 gstruct43_47 = new GStruct43
	{
		string_0 = "HP2_OFFSET",
		string_1 = string_27,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 48
	};

	public static GStruct43 gstruct43_48 = new GStruct43
	{
		string_0 = "MP2_OFFSET",
		string_1 = string_27,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 66
	};

	public static GStruct43 gstruct43_49 = new GStruct43
	{
		string_0 = "NPC_INDEX_OFFSET",
		string_1 = "8B ?? 8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8B ?? ?? ?? 03 ?? 8B",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 17
	};

	public static GStruct43 gstruct43_50 = new GStruct43
	{
		string_0 = "NPC_EXISTS_OFFSET",
		string_1 = "77 ?? A1 ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 83 ?? ?? ?? ?? 7E",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 16
	};

	public static GStruct43 gstruct43_51 = new GStruct43
	{
		uint_0 = 0u
	};

	public static GStruct43 gstruct43_52 = new GStruct43
	{
		uint_0 = 0u
	};

	public static GStruct43 gstruct43_53 = new GStruct43
	{
		uint_0 = 0u
	};

	public static GStruct43 gstruct43_54 = new GStruct43
	{
		string_0 = "NPC_COLOR_OFFSET",
		string_1 = "80 ?? ?? ?? 8A ?? ?? ?? ?? ?? 88 ?? ?? 8B ?? ?? ?? ?? ?? 89",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 15
	};

	public static GStruct43 gstruct43_55 = new GStruct43
	{
		string_0 = "NPC_DOING_OFFSET",
		string_1 = "83 ?? ?? ?? ?? ?? ?? 75 ?? 80 ?? ?? ?? 39",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_56 = new GStruct43
	{
		string_0 = "KILLER_STATUS_OFFSET",
		string_1 = "8B ?? ?? ?? ?? ?? 0F ?? ?? ?? ???? ?? ?? 89 ?? ?? ?? ?? ?? 0F ?? ?? ?? A1 ?? ?? ?? ?? 83 ?? ?? 3B ?? ?? ?? ?? ?? ?? 74",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 35
	};

	public static GStruct43 gstruct43_57 = new GStruct43
	{
		string_0 = "POS_BASE_SIZE",
		string_1 = "8B ?? ?? ?? ?? ?? 6A ?? ?? 8B ?? ?? ?? ?? ?? 8D",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 17
	};

	private static string string_28 = "8B ?? 8B ?? ?? 8B ?? ?? 8B ?? ?? 89 ?? ?? ?? 8B ?? ?? ?? 33 ?? 33 ?? 85 ?? 89 ?? ?? ?? 89 ?? ?? ?? 89 ?? ?? ?? 0F";

	public static GStruct43 gstruct43_58 = new GStruct43
	{
		string_0 = "POS_X_SIZE",
		string_1 = string_28,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 4
	};

	public static GStruct43 gstruct43_59 = new GStruct43
	{
		string_0 = "POS_Y_SIZE",
		string_1 = string_28,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 7
	};

	public static GStruct43 gstruct43_60 = new GStruct43
	{
		string_0 = "KNPC_NAME_OFFSET",
		string_1 = "89 ?? ?? 89 ?? ?? C7 ?? ?? ?? ?? ?? ?? 83 ?? ?? 3B ?? 88 ?? 74",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 15
	};

	public static GStruct43 gstruct43_61 = default(GStruct43);

	public static GStruct43 gstruct43_62 = default(GStruct43);

	public static GStruct43 gstruct43_63 = default(GStruct43);

	public static GStruct43 gstruct43_64 = default(GStruct43);

	public static GStruct43 gstruct43_65 = default(GStruct43);

	public static GStruct43 gstruct43_66 = new GStruct43
	{
		string_0 = "NPC_PROFILE_STATUS_OFFSET",
		string_1 = "83 ?? ?? ?? ?? ?? 05 74 ?? 8B",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	private static string string_29 = "A1 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 83 ?? ?? ?? 8B ?? ?? ?? ?? 8B ?? 8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 6A 01 ?? 8D ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 85 ?? 7E ?? 6A ?? 6A ?? 8D ?? ?? ?? ?? 6A ?? 89 ?? ?? C7";

	private static string string_30 = "A1 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 83 ?? ?? ?? 8B ?? ?? ?? ?? 8B ?? 8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 6A ?? ?? 8D ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 85 ?? 7E ?? 8D ?? ?? 3D ?? ?? ?? ?? 89 ?? ?? 77";

	public static GStruct43 gstruct43_67 = new GStruct43
	{
		string_0 = "SCRIPT_LEFT_SKILL_BASE_ADDR",
		string_1 = string_29,
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_68 = new GStruct43
	{
		string_0 = "KPLAYER_LEFT_SKILL",
		string_1 = string_29,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 66
	};

	public static GStruct43 gstruct43_69 = new GStruct43
	{
		string_0 = "SCRIPT_RIGHT_SKILL_BASE_ADDR",
		string_1 = string_30,
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_70 = new GStruct43
	{
		string_0 = "KPLAYER_RIGHT_SKILL",
		string_1 = string_30,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 63
	};

	public static GStruct43 gstruct43_71 = new GStruct43
	{
		string_0 = "TOTAL_POIN_SKILL_OFFSET",
		string_1 = "8B ?? ?? ?? ?? ?? 6A 00 ?? 6A 00 6A 09",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_72 = new GStruct43
	{
		string_0 = "m_nPeopleIdx",
		string_1 = "8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 85 ?? 7E",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 15
	};

	private static string string_31 = "7C ?? 89 ?? ?? ?? ?? ?? 8B ?? ?? ?? 85 ?? 7C ?? 89";

	public static GStruct43 gstruct43_73 = new GStruct43
	{
		string_0 = "MONEY_1_OFFSET",
		string_1 = string_31,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 4
	};

	public static GStruct43 gstruct43_74 = new GStruct43
	{
		string_0 = "MONEY_2_OFFSET",
		string_1 = string_31,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 18
	};

	public static GStruct43 gstruct43_75 = new GStruct43
	{
		string_0 = "MONEY_SIZE",
		string_1 = "83 ?? ?? ?? 8B ?? ?? ?? 8B ?? ?? ?? 6A ?? 81",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 16
	};

	public static GStruct43 gstruct43_76 = new GStruct43
	{
		string_0 = "STATS_TOTAL_OFFSET",
		string_1 = "8B ?? ?? ?? ?? 8B ?? 8B ?? ?? 89 ?? ?? ?? ?? ?? 0F ?? ?? ?? 83 ?? 03 0F",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 12
	};

	public static GStruct43 gstruct43_77 = default(GStruct43);

	public static GStruct43 gstruct43_78 = default(GStruct43);

	public static GStruct43 gstruct43_79 = default(GStruct43);

	public static GStruct43 gstruct43_80 = default(GStruct43);

	public static GStruct43 gstruct43_81 = default(GStruct43);

	public static GStruct43 gstruct43_82 = default(GStruct43);

	public static GStruct43 gstruct43_83 = default(GStruct43);

	public static GStruct43 gstruct43_84 = default(GStruct43);

	public static GStruct43 gstruct43_85 = new GStruct43
	{
		string_0 = "TONG_NAME_2ID",
		string_1 = "69 ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 89 ?? ?? ?? E9 ?? ?? ?? ?? 85",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 9
	};

	public static GStruct43 gstruct43_86 = new GStruct43
	{
		string_0 = "TONG_NAME_OFFSET",
		string_1 = "80 ?? ?? ?? ?? ?? 00 8D ?? ?? ?? ?? ?? 0F 84 ?? ?? ?? ?? 8D",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = "80 ?? ?? ?? ?? ?? 00 8D ?? ?? ?? ?? ?? 89 ?? ?? 74 ?? 8D",
		byte_3 = 1,
		int_1 = 2,
		int_3 = 4
	};

	public static GStruct43 gstruct43_87 = new GStruct43
	{
		string_0 = "FUNC_SWITCH_KETHOP",
		string_1 = "6A 00 8B ?? ?? 8B ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 83 ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 13,
		byte_5 = 1
	};

	private static string string_32 = "69 ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? E8";

	public static GStruct43 gstruct43_88 = new GStruct43
	{
		string_0 = "SORTCUT_BASE_SIZE",
		string_1 = string_32,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_89 = new GStruct43
	{
		string_0 = "SORTCUT_BASE_ADDR",
		string_1 = string_32,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 8,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_90 = new GStruct43
	{
		string_0 = "SORTCUT_NAME_OFF",
		string_1 = string_32,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 15
	};

	public static GStruct43 gstruct43_91 = new GStruct43
	{
		string_0 = "SERVER_BASE_ADDR",
		string_1 = "81 ?? ?? ?? ?? ?? E8 03 00 00",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 18,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_92 = new GStruct43
	{
		string_0 = "SERVER_NAME_SIZE",
		string_1 = "74 ?? ?? ?? ?? ?? ?? 89 ?? ?? 8B ?? ?? ?? 8B ?? ?? 81",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 19,
		string_2 = "74 ?? A1 ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? ?? ?? FF 15",
		byte_3 = 1,
		int_1 = 10,
		int_3 = 4
	};

	public static GStruct43 gstruct43_93 = new GStruct43
	{
		string_0 = "CHECK_STATUS_BASE_ADDR",
		string_1 = "83 3D ?? ?? ?? ?? 00 74 ?? 6A 00 E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_94 = new GStruct43
	{
		string_0 = "KITEM_BASE_SIZE",
		string_1 = "8B ?? ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? 89 ?? ?? ?? E8 ?? ?? ?? ?? 83",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 8
	};

	public static GStruct43 gstruct43_95 = new GStruct43
	{
		string_0 = "KITEM_NEXT_SEARCH_SIZE",
		string_1 = "53 56 8B F1 57 8D BE ?? ?? ?? ?? 6A 00",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 7
	};

	public static GStruct43 gstruct43_96 = new GStruct43
	{
		string_0 = "KITEM_ID_SIZE",
		string_1 = "74 ?? 8B ?? ?? ?? 8D ?? ?? 8D ?? ?? ?? 39 ?? ?? 74",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 12,
		string_2 = "74 ?? 8B ?? ?? ?? 8D ?? ?? 8D ?? ?? 39 ?? ?? ?? ?? ?? ?? 74",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 15
	};

	public static GStruct43 gstruct43_97 = new GStruct43
	{
		string_0 = "KITEM_POS_SIZE",
		string_1 = "8B ?? ?? ?? ?? ?? ?? 89 ?? ?? ?? ?? 01 00 00 00 ?? C2 08 00 ?? ?? 33",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = "8B ?? ?? ?? 89 ?? ?? ?? ?? 01 00 00 00 ?? C2 08 00 ?? ?? 33",
		byte_3 = 1,
		int_3 = 1,
		int_1 = 2
	};

	public static GStruct43 gstruct43_98 = new GStruct43
	{
		string_0 = "KITEM_SET_PRICE",
		string_1 = "8B ?? ?? ?? ?? ?? ?? ?? C2 04 00 83 C8 FF ?? C2",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 3,
		string_2 = "8B ?? ?? ?? ?? C2 04 00 83 C8 FF ?? C2",
		byte_3 = 1,
		int_1 = 3,
		int_3 = 1
	};

	public static GStruct43 gstruct43_99 = new GStruct43
	{
		string_0 = "KPLAYER_MOVEITEM",
		string_1 = "81 ?? ?? ?? ?? ?? A1 ?? ?? ?? ?? 33 ?? 89 ?? ?? ?? ?? ?? ?? ?? ?? ?? 8B ?? 8B ?? ?? ?? ?? ?? ?? 33",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	private static string string_33 = "33 ?? E9 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 83";

	public static GStruct43 gstruct43_100 = new GStruct43
	{
		string_0 = "ITEM_IDKEY",
		string_1 = string_33,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 9
	};

	public static GStruct43 gstruct43_101 = new GStruct43
	{
		string_0 = "FUNC_SHOP_BUY",
		string_1 = string_33,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 15,
		byte_5 = 1
	};

	private static string string_34 = "8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8D ?? ?? ?? 8D ?? ?? ?? ?? ?? ?? 2B";

	public static GStruct43 gstruct43_102 = new GStruct43
	{
		string_0 = "ITEM_BASE_ADD",
		string_1 = string_34,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_103 = new GStruct43
	{
		string_0 = "ITEM_DATA_SIZE",
		string_1 = string_34,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 8
	};

	public static GStruct43 gstruct43_104 = new GStruct43
	{
		string_0 = "ITEM_NAME_SIZE",
		string_1 = string_34,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 15
	};

	private static string string_35 = "8B ?? ?? 85 ?? 0F 85 ?? ?? ?? ?? 8B ?? ?? 83 ?? 01";

	public static GStruct43 gstruct43_105 = new GStruct43
	{
		string_0 = "ITEM_KIND",
		string_1 = string_35,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_106 = new GStruct43
	{
		string_0 = "ITEM_COLOR",
		string_1 = string_35,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 13
	};

	public static GStruct43 gstruct43_107 = new GStruct43
	{
		string_0 = "ITEM_GENRE",
		string_1 = "83 ?? ?? ?? 0F 85 ?? ?? ?? ?? 83 ?? ?? ?? 0F 85 ?? ?? ?? ?? 8B",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 12
	};

	private static string string_36 = "A1 ?? ?? ?? ?? 8B ?? ?? ?? 8B ?? ?? ?? 6A";

	public static GStruct43 gstruct43_108 = new GStruct43
	{
		string_0 = "ITEM_WIDTH",
		string_1 = string_36,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 12
	};

	public static GStruct43 gstruct43_109 = new GStruct43
	{
		string_0 = "ITEM_HEIGHT",
		string_1 = string_36,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 8
	};

	public static GStruct43 gstruct43_110 = new GStruct43
	{
		string_0 = "ITEM_PRICE",
		string_1 = "8B ?? ?? 85 ?? 7E ?? 83 ?? ?? ?? 74",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_111 = new GStruct43
	{
		string_0 = "ITEM_LEVEL",
		string_1 = "89 ?? ?? ?? ?? ?? 8B ?? ?? 8B ?? ?? 83 ?? 04 0F",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 11
	};

	public static GStruct43 gstruct43_112 = new GStruct43
	{
		string_0 = "ITEM_SERIES",
		string_1 = "83 ?? ?? ?? 0F ?? ?? ?? ?? ?? 8B ?? ?? 83 ?? 04 0F ?? ?? ?? ?? ?? FF",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 12
	};

	public static GStruct43 gstruct43_113 = new GStruct43
	{
		string_0 = "ITEM_INTRO",
		string_1 = "75 ?? B8 ?? ?? ?? ?? C3 8D ?? ?? ?? ?? ?? C3",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 10
	};

	public static GStruct43 gstruct43_114 = new GStruct43
	{
		string_0 = "ITEM_REQUIRE_ATTRIB",
		string_1 = "8B ?? ?? ?? 83 ?? ?? 7C ?? 33 ?? C2 ?? ?? C1 ?? ?? 8D",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 20
	};

	public static GStruct43 gstruct43_115 = new GStruct43
	{
		string_0 = "ITEM_MAGIC_ATTRIB",
		string_1 = "0F 85 ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? 33 ?? 89 ?? ?? ?? 8D",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 20
	};

	public static GStruct43 gstruct43_116 = new GStruct43
	{
		string_0 = "ITEM_DURATION",
		string_1 = "8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 3B ?? 7D",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 15
	};

	public static GStruct43 gstruct43_117 = new GStruct43
	{
		string_0 = "ITEM_LOCK_OFFSET",
		string_1 = "66 ?? ?? 8B ?? ?? ?? ?? ?? 83 ?? FF 75",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 5
	};

	public static GStruct43 gstruct43_118 = new GStruct43
	{
		string_0 = "ITEM_USE_FUNC_ADD",
		string_1 = "83 EC ?? ?? 8B ?? E8 ?? ?? ?? ?? 85 ?? 74 ?? 33",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_119 = new GStruct43
	{
		string_0 = "ITEM_THROW_FUNC_ADD",
		string_1 = "51 E8 ?? ?? ?? ?? 85 ?? 74 ?? 33 ?? 59 C3",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_120 = new GStruct43
	{
		string_0 = "ITEM_HOLD_BASE_ADDR",
		string_1 = "81 ?? ?? 07 02 00 00 75 ?? 83 ?? ?? ?? ?? ?? 00 75",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 11,
		string_2 = "81 ?? 07 02 00 00 75 ?? 39 ?? ?? ?? ?? ?? 75",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 10
	};

	public static GStruct43 gstruct43_121 = new GStruct43
	{
		string_0 = "OBJECT_COUNT_BASE_ADDR",
		string_1 = "33 ?? 85 ?? 0F ?? ?? ?? ?? ?? ?? ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 9,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_122 = new GStruct43
	{
		string_0 = "OBJECT_COUNT_SIZE",
		string_1 = "7D ?? 33 ?? ?? C2 ?? ?? ?? 8D ?? ?? ?? ?? ?? 6A 00",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 11
	};

	private static string string_37 = "69 ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? ?? 8B ?? ?? ?? 89 ?? B8";

	public static GStruct43 gstruct43_123 = new GStruct43
	{
		string_0 = "OBJECT_BASE_ADDR",
		string_1 = string_37,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 8
	};

	public static GStruct43 gstruct43_124 = new GStruct43
	{
		string_0 = "OBJECT_BASE_SIZE",
		string_1 = string_37,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_125 = new GStruct43
	{
		string_0 = "OBJECT_KIND_SIZE",
		string_1 = string_37,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 15
	};

	private static string string_38 = "8B ?? ?? ?? ?? ?? 8B ?? ?? ?? 89 ?? ?? ?? ?? ?? ?? A1 ?? ?? ?? ?? 8B ?? ?? ?? 89 ?? ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? ?? 89 ?? ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? ?? 8B";

	public static GStruct43 gstruct43_126 = new GStruct43
	{
		string_0 = "OBJECT_COLOR_SIZE",
		string_1 = string_38,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 80
	};

	public static GStruct43 gstruct43_127 = new GStruct43
	{
		string_0 = "OBJECT_SIZE_X_SIZE",
		string_1 = string_38,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 46
	};

	public static GStruct43 gstruct43_128 = new GStruct43
	{
		string_0 = "OBJECT_SIZE_Y_SIZE",
		string_1 = string_38,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 67
	};

	public static GStruct43 gstruct43_129 = new GStruct43
	{
		string_0 = "OBJECT_STACKCOUNT_SIZE",
		string_1 = string_38,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 13
	};

	private static string string_39 = "89 ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? 89";

	public static GStruct43 gstruct43_130 = new GStruct43
	{
		string_0 = "OBJECT_POS_X",
		string_1 = string_39,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 8
	};

	public static GStruct43 gstruct43_131 = new GStruct43
	{
		string_0 = "OBJECT_POS_Y",
		string_1 = string_39,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_132 = new GStruct43
	{
		string_0 = "m_nObjectIdx",
		string_1 = "8B ?? ?? ?? ?? ?? C7 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? B8 ?? ?? ?? ?? C2",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 9
	};

	public static GStruct43 gstruct43_133 = new GStruct43
	{
		string_0 = "OBJECT_SERI_SIZE",
		string_1 = "89 ?? ?? ?? 8B ?? ?? ?? ?? ?? 89 ?? ?? ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 89 ?? ?? ?? 69",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 3
	};

	public static GStruct43 gstruct43_134 = new GStruct43
	{
		string_0 = "OBJECT_TIME_SIZE",
		string_1 = "83 ?? ?? FF 83 ?? ?? ?? 7F ?? 6A",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_135 = new GStruct43
	{
		string_0 = "OBJECT_NAME_SIZE",
		string_1 = "A1 ?? ?? ?? ?? 8D ?? ?? ?? 8D ?? ?? ?? 8D ?? ?? ?? ?? ?? ?? 8A ?? 88",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 12
	};

	public static GStruct43 gstruct43_136 = new GStruct43
	{
		string_0 = "OBJECT_TYPE_SIZE",
		string_1 = "83 ?? ?? ?? ?? ?? ?? 0F ?? ?? ?? ?? ?? 80 ?? ?? ?? ?? ?? ?? 0F",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_137 = new GStruct43
	{
		string_0 = "OBJ_EXIST",
		string_1 = "74 ?? C7 86 ?? ?? ?? ?? ?? ?? ?? ?? C7 86",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 14
	};

	public static GStruct43 gstruct43_138 = new GStruct43
	{
		string_0 = "OBJ_GROWN",
		string_1 = "7C ?? 8B ?? ?? 83 ?? ?? 89 ?? ?? 74",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 10
	};

	public static GStruct43 gstruct43_139 = new GStruct43
	{
		string_0 = "PICKUP_OBJECT_FUNC_ADDR",
		string_1 = "8B ?? ?? ?? ?? ?? ?? 8B ?? 8B ?? ?? ?? 8B ?? 69",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_140 = new GStruct43
	{
		string_0 = "FUNC_MENU_0_CLICK_INDEX",
		string_1 = "55 8B EC 51 89 ?? ?? 8B ?? ?? 50 6A 00 6A 09",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0,
		string_2 = "8B ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 6A 00 6A 09 E8",
		byte_3 = 1,
		int_3 = 0,
		int_1 = 0
	};

	public static GStruct43 gstruct43_141 = new GStruct43
	{
		string_0 = "FUNC_MENU_1_CLICK_INDEX",
		string_1 = "55 8B EC 51 89 4D FC 6A 00 E8 ?? ?? ?? ?? 83 ?? ?? 8B ?? ?? 81",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0,
		string_2 = "6A 00 8B ?? E8 ?? ?? ?? ?? 83 ?? ?? 8D ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 85 ?? 74",
		byte_3 = 1,
		int_3 = 0,
		int_1 = -1
	};

	public static GStruct43 gstruct43_142 = new GStruct43
	{
		string_0 = "MENU_SIZE",
		string_1 = "3B ?? ?? ?? ?? ?? 7D ?? 8B ?? ?? 89 ?? ?? EB ?? 8B",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = "8B ?? ?? ?? ?? ?? ?? 8B ?? ?? ?? 33 ?? 3B ?? 7D ?? 8B",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_143 = new GStruct43
	{
		string_0 = "MENU_0_COUNT_BASE_OFFSET",
		string_1 = "83 ?? ?? ?? ?? ?? 00 74 ?? ?? ?? ?? ?? ?? 8A ?? ?? ?? ?? ?? EB ?? 32",
		string_2 = "85 ?? 74 ?? 8A ?? ?? ?? ?? ?? C3 32 ?? C3",
		byte_2 = 1,
		byte_3 = 1,
		int_2 = 4,
		int_3 = 4,
		int_0 = 2,
		int_1 = -4,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_144 = new GStruct43
	{
		string_0 = "MENU_0_COUNT_SIZE",
		string_1 = "6A 00 6A 00 6A 00 6A FF 8B ?? ?? ?? ?? ?? ?? 8B ?? ?? 81 C1",
		string_2 = "6A 00 6A 00 6A 00 6A FF ?? 8D",
		byte_2 = 1,
		byte_3 = 1,
		int_2 = 4,
		int_3 = 4,
		int_0 = 20,
		int_1 = 11
	};

	public static GStruct43 gstruct43_145 = new GStruct43
	{
		string_0 = "MENU_1_COUNT_BASE_OFFSET",
		string_1 = "8B ?? ?? ?? ?? ?? C6 ?? ?? ?? ?? ?? 00 8B ?? ?? ?? ?? ?? ?? E8",
		string_2 = "85 ?? 74 ?? C6 ?? ?? ?? ?? ?? 00 ?? ?? ?? ?? ?? C6 ?? ?? ?? ?? ?? 00 8B",
		byte_2 = 1,
		byte_3 = 1,
		int_2 = 4,
		int_3 = 4,
		int_0 = 2,
		int_1 = -4,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_146 = new GStruct43
	{
		string_0 = "MENU_1_COUNT_SIZE",
		string_1 = "6A 00 6A 00 6A 00 6A FF 8B ?? ?? ?? ?? ?? ?? 8B ?? ?? 81 C1",
		byte_2 = 2,
		int_2 = 4,
		int_0 = 20,
		string_2 = "8D ?? ?? ?? ?? ?? 8B ?? 89 ?? ?? ?? E8 ?? ?? ?? ?? 8B ?? ?? ?? 85",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_147 = new GStruct43
	{
		string_0 = "MENU_1_VISABLE",
		string_1 = "83 3D ?? ?? ?? ?? 00 74 ?? 8B ?? ?? ?? ?? ?? 89 ?? ?? E9",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_148 = new GStruct43
	{
		string_0 = "DIALOG_FUNC_BASE_ADDR",
		string_1 = "6A 00 E8 ?? ?? ?? ?? 83 ?? ?? C6 ?? ?? ?? ?? ?? ?? ?? ?? 89",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 15,
		string_2 = "8B ?? ?? ?? ?? ?? 85 ?? 74 ?? 8B ?? 8B ?? ?? 6A 00 6A 00 68 07 05 00 00",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_149 = new GStruct43
	{
		string_0 = "DIALOG_BASE_ADDR",
		string_1 = "6A 01 E8 ?? ?? ?? ?? 83 ?? ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? ?? ?? ?? ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 21,
		byte_4 = 1
	};

	private static string string_40 = "8B ?? ?? ?? ?? ?? 3B ?? ?? ?? ?? ?? 0F ?? ?? ?? ?? ?? 8B ?? ?? 8B ?? ?? ?? ?? ?? 69";

	private static string string_41 = "8B ?? ?? ?? ?? ?? 83 ?? ?? 3B ?? ?? ?? ?? ?? 7D ?? 8B ?? ?? ?? ?? ?? 69";

	public static GStruct43 gstruct43_150 = new GStruct43
	{
		string_0 = "DIALOG_INDEX_SIZE",
		string_1 = string_40,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = string_41,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_151 = new GStruct43
	{
		string_0 = "DIALOG_COUNT_SIZE",
		string_1 = string_40,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 8,
		string_2 = string_41,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 11
	};

	public static GStruct43 gstruct43_152 = new GStruct43
	{
		string_0 = "DIALOG_TEXT_SIZE",
		string_1 = "83 ?? ?? 00 74 ?? 8B ?? ?? 8B ?? ?? 8B ?? ?? 8B ?? ?? 8B ?? 8B ?? ?? FF ?? 8B ?? ?? 83",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 2,
		string_2 = "83 ?? ?? ?? 74 ?? 8B ?? ?? 8B ?? 8B ?? ?? FF ?? 83",
		byte_3 = 1,
		int_3 = 1,
		int_1 = 2
	};

	public static GStruct43 gstruct43_153 = new GStruct43
	{
		string_0 = "DIALOG_TEXT_OFFSET",
		string_1 = "83 ?? ?? ?? ?? ?? 00 74 ?? 8B ?? ?? 8B ?? ?? ?? ?? ?? 0F ?? ?? 85 ?? 74",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = "83 ?? ?? ?? ?? ?? 00 74 ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 0F ?? ?? 85 ?? 74",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_154 = new GStruct43
	{
		string_0 = "BOX_THUTHAP_BASE_ADDR",
		string_1 = "89 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 89 ?? ?? ?? ?? ?? 8B ?? ?? ?? 8B",
		byte_2 = 1,
		int_2 = 4,
		int_0 = -4,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_155 = new GStruct43
	{
		string_0 = "BOX_THUTHAP_SHOW",
		string_1 = "89 ?? ?? ?? ?? ?? EB ?? 8B ?? ?? C7 ?? ?? ?? ?? ?? 00 00 00 00 8B ?? ?? C2 04",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_156 = new GStruct43
	{
		string_0 = "SKILL_DIRECT_SHORTCUT_BASE",
		string_1 = "C1 ?? ?? 83 ?? ?? ?? ?? ?? 00 74 ?? 8B ?? ?? 33",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 5,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_157 = new GStruct43
	{
		string_0 = "SKILL_OFFSET",
		string_1 = "69 ?? ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 16
	};

	private static string string_42 = "83 ?? ?? 39 ?? 74 ?? 83 ?? ?? 83 ?? ?? 83 ?? ?? 7C";

	public static GStruct43 gstruct43_158 = new GStruct43
	{
		string_0 = "SKILL_START_SIZE",
		string_1 = string_42,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_159 = new GStruct43
	{
		string_0 = "SKILL_SIZE",
		string_1 = string_42,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 12
	};

	public static GStruct43 gstruct43_160 = new GStruct43
	{
		string_0 = "SKILL_INC_LEVEL_FUNC_ADDR",
		string_1 = "E9 ?? ?? ?? ?? 8B 0D ?? ?? ?? ?? 6A 01 ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? E9",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 21,
		string_2 = "E9 ?? ?? ?? ?? 8B 0D ?? ?? ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? E9",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 20,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_161 = new GStruct43
	{
		string_0 = "SMS_BASE_ADDR",
		string_1 = "89 ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 83 ?? ?? ?? ?? ?? 01 75",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 8
	};

	public static GStruct43 gstruct43_162 = new GStruct43
	{
		string_0 = "SMS_BASE_SIZE",
		string_1 = "C7 ?? ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? B8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 15
	};

	public static GStruct43 gstruct43_163 = new GStruct43
	{
		string_0 = "SMS_TEXT_SIZE",
		string_1 = "89 ?? ?? 8B ?? ?? 6B ?? ?? 8B ?? ?? 8D ?? ?? ?? ?? ?? ?? 89",
		string_2 = "8D ?? ?? ?? 8D ?? ?? 0F ?? ?? ?? ?? ?? 3B ?? ?? 0F",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 15,
		byte_3 = 1,
		int_3 = 1,
		int_1 = 3
	};

	public static GStruct43 gstruct43_164 = new GStruct43
	{
		string_0 = "SMS_FLAG_SIZE",
		string_1 = "83 ?? ?? ?? ?? ?? ?? 00 0F ?? ?? ?? ?? ?? 8B ?? ?? 6B",
		string_2 = "8D ?? ?? 83 ?? ?? ?? ?? ?? ?? 00 89 ?? ?? ?? 0F ?? ?? ?? ?? ?? 8D",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 3,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 6
	};

	public static GStruct43 gstruct43_165 = new GStruct43
	{
		string_0 = "CLEAR_SMS_FUNC_ADDR",
		string_1 = "81 ?? ?? ?? ?? ?? ?? 75 ?? 6A 00 8B ?? ?? ?? 8B ?? ?? E8 ?? ?? ?? ?? EB",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 19,
		string_2 = "6A 00 ?? 8B ?? E8 ?? ?? ?? ?? C7 ?? ?? ?? ?? ?? 00 00 00 00",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 6,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_166 = new GStruct43
	{
		uint_0 = 1100u
	};

	public static GStruct43 gstruct43_167 = new GStruct43
	{
		string_0 = "BOX_TEXT_SIZE",
		string_1 = "8B ?? ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? 03 ?? ?? ?? ?? ?? ?? 8B ?? ?? 8B",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 5
	};

	private static string string_43 = "EB ?? 6A 00 8B ?? ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? EB ?? 8B";

	public static GStruct43 gstruct43_168 = new GStruct43
	{
		string_0 = "BOX_GLOBAL_ENTER_NUMBER",
		string_1 = string_43,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 6,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_169 = new GStruct43
	{
		string_0 = "BOX_GLOBAL_ENTER_SIZE",
		string_1 = string_43,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 12
	};

	private static string string_44 = "6A 00 6A 00 6A 08 6A 03 6A 01 8B ?? ?? ?? ?? ?? ?? 68 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? E8";

	private static string string_45 = "8B ?? ?? ?? ?? ?? 6A 00 6A 00 6A 08 6A 03 6A 01 ?? 68 ?? ?? ?? ?? ?? E8";

	public static GStruct43 gstruct43_170 = new GStruct43
	{
		string_0 = "FLAG_BASE_ADDR",
		string_1 = string_44,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 12,
		string_2 = string_45,
		byte_3 = 1,
		int_3 = 4,
		int_1 = -4,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_171 = new GStruct43
	{
		string_0 = "FLAG_BOX_TITLE",
		string_1 = string_44,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 23,
		string_2 = string_45,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_172 = new GStruct43
	{
		string_0 = "FLAG_BOXENTER_FUNC_ADDR",
		string_1 = string_44,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 29,
		string_2 = string_45,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 24,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_173 = new GStruct43
	{
		string_0 = "BOX_VANSUTHONG_BASE_ADDR",
		string_1 = "6A 00 6A 01 6A 20 6A 06 6A 01 68",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 11,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_174 = new GStruct43
	{
		string_0 = "FLAG_IS_STICK",
		string_1 = "6A FF 6A FF ?? ?? ?? ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 5,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_175 = new GStruct43
	{
		string_0 = "BOX_BASE_ADDR",
		string_1 = "68 00 00 01 00 ?? ?? ?? ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 6,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_176 = new GStruct43
	{
		string_0 = "BOX_BASE_SIZE",
		string_1 = "55 8B ?? 83 ?? ?? 89 ?? ?? 8B ?? ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 6A ?? 6A ?? 8B",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 14,
		string_2 = "56 57 8B ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? 8D ?? ?? ?? ?? ?? 51",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 15
	};

	public static GStruct43 gstruct43_177 = new GStruct43
	{
		string_0 = "BOX_OPEN_OFFSET",
		string_1 = "8B ?? ?? ?? ?? ?? 83 ?? 01 8B ?? ?? ?? ?? ?? 3B ?? ?? 77 ?? 68",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 17,
		string_2 = "8D ?? ?? ?? 64 ?? ?? ?? ?? ?? 8B ?? 81 ?? ?? ?? ?? ?? ?? 72 ?? 68",
		byte_3 = 1,
		int_3 = 1,
		int_1 = 14
	};

	public static GStruct43 gstruct43_178 = new GStruct43
	{
		string_0 = "OPEN_FUNC_SPEC",
		string_1 = "8B ?? ?? ?? ?? ?? 85 ?? 74 ?? 8B ?? ?? ?? 8B ?? 8B ?? ?? 8B",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_179 = new GStruct43
	{
		string_0 = "BOX_COUNT_ITEM_SIZE",
		string_1 = "3B ?? ?? ?? ?? ?? 0F 8D ?? ?? ?? ?? 8B ?? ?? 6B ?? ?? 8B ?? ?? ?? ?? ?? 03",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = "FF ?? ?? ?? 39 ?? ?? ?? ?? ?? 89 ?? ?? ?? 0F 8E ?? ?? ?? ?? 89 ?? ?? ?? EB",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 6
	};

	public static GStruct43 gstruct43_180 = new GStruct43
	{
		string_0 = "BOX_COUNT_BASE_ADDR",
		string_1 = "8B ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? E8 ?? ?? ?? ?? 85 ?? 75 ?? E8 ?? ?? ?? ?? EB",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_181 = new GStruct43
	{
		string_0 = "BOX_ACCEPT_FUNC",
		string_1 = "E8 ?? ?? ?? ?? E8 ?? ?? ?? ?? E8 ?? ?? ?? ?? 6A 00 E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 18,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_182 = new GStruct43
	{
		string_0 = "BOX_INC_POINT_FUNC_ADDR",
		string_1 = "6A 02 8B ?? ?? ?? 8B ?? ?? ?? 8B ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 14,
		string_2 = "6A 02 ?? ?? 8B ?? E8 ?? ?? ?? ?? E9",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 7,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_183 = new GStruct43
	{
		string_0 = "BOX_UNLOCK_BASE_ADDR",
		string_1 = "8B ?? ?? ?? ?? ?? 85 ?? 8B ?? ?? ?? C6 ?? ?? 84 C6",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_184 = new GStruct43
	{
		string_0 = "TONG_ENTER_BASE_ADDR",
		string_1 = "8B ?? ?? ?? ?? ?? 8B ?? 8B ?? ?? 6A 00 6A 04",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_185 = new GStruct43
	{
		string_0 = "TONG_BASE_SIZE",
		string_1 = "8B ?? ?? ?? ?? ?? 55 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 80",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 9
	};

	public static GStruct43 gstruct43_186 = new GStruct43
	{
		string_0 = "TONG_PUSH_MONEY_SIZE",
		string_1 = "83 ?? ?? 00 74 ?? 8B ?? ?? C3 33 ?? C3",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 8
	};

	private static string string_46 = "E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? 8B ?? ?? F7 ?? 99";

	public static GStruct43 gstruct43_187 = new GStruct43
	{
		string_0 = "TONG_PUSH_MONEY_BASE_ADDR",
		string_1 = string_46,
		byte_2 = 1,
		int_2 = 4,
		int_0 = -4,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_188 = new GStruct43
	{
		string_0 = "TONG_PUSH_MONEY_FUNC",
		string_1 = string_46,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 1,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_189 = new GStruct43
	{
		string_0 = "TONG_BASE_OFFSET",
		string_1 = "C7 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 89 ?? ?? 83 ?? ?? ?? 74 ?? 8B ?? ?? 83 ?? ?? 8B ?? ?? 2B",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 8,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_190 = new GStruct43
	{
		string_0 = "TONG_FUNC_GET_BASE_SIZE",
		string_1 = "6A 01 E8 ?? ?? ?? ?? 83 ?? ?? EB ?? E8 ?? ?? ?? ?? E9",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 13,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_191 = new GStruct43
	{
		string_0 = "TONG_FUNC_ACCEPT_CHANGE_COLOR",
		string_1 = "6A 01 6A 10 8D ?? ?? ?? 8B ?? ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 0F",
		byte_2 = 1,
		int_2 = 0,
		int_0 = -19
	};

	public static GStruct43 gstruct43_192 = new GStruct43
	{
		string_0 = "TONG_SPEC_FUNC",
		string_1 = "81 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 33 C4 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 57 81",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_193 = new GStruct43
	{
		uint_0 = 32u
	};

	public static GStruct43 gstruct43_194 = new GStruct43
	{
		uint_0 = 4u
	};

	public static GStruct43 gstruct43_195 = default(GStruct43);

	public static GStruct43 gstruct43_196 = new GStruct43
	{
		string_0 = "TEAM_CREATE",
		string_1 = "8B ?? ?? ?? ?? ?? 85 ?? 7E ?? 8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 83 ?? ?? ?? ?? ?? ?? ?? 74",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_197 = new GStruct43
	{
		string_0 = "TEAM_MEMBER",
		string_1 = "8D ?? ?? ?? ?? ?? 89 ?? ?? ?? C7 ?? 01 00 00 00",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_198 = new GStruct43
	{
		string_0 = "TEAM_LIST_NAME_ADDR",
		string_1 = "89 ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? BE ?? ?? ?? ?? 8B ?? 2B",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 13,
		byte_4 = 1
	};

	private static string string_47 = "83 ?? ?? ?? ?? ?? 00 74 ?? 8B ?? ?? 8B ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 89";

	public static GStruct43 gstruct43_199 = new GStruct43
	{
		string_0 = "TEAM_CAPTAIN_NAME_OFF",
		string_1 = string_47,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 14
	};

	public static GStruct43 gstruct43_200 = new GStruct43
	{
		string_0 = "TEAM_CAPTAIN_NAME_SIZE",
		string_1 = string_47,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 19
	};

	public static GStruct43 gstruct43_201 = new GStruct43
	{
		string_0 = "TEAM_LEAVE_FUNC_ADDR",
		string_1 = "83 ?? ?? 8B ?? ?? ?? ?? ?? 85 ?? C6 ?? ?? ?? 66 ?? ?? ?? ?? ?? ?? C6 ?? ?? ?? ?? C7 ?? ?? ?? ?? ?? ?? ?? 74",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	private static string string_48 = "E8 ?? ?? ?? ?? EB ?? 6A 00 6A 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 66";

	private static string string_49 = "8D ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 8B ?? E8 ?? ?? ?? ?? 85 ?? 74 ?? 8B";

	public static GStruct43 gstruct43_202 = new GStruct43
	{
		string_0 = "LASTCHANEL_TOP_SIZE",
		string_1 = "83 ?? ?? ?? 74 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 89 ?? ?? 6A 00 6A 00",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 12,
		string_2 = "8D ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 8B ?? E8 ?? ?? ?? ?? ?? ?? ?? C3",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_203 = new GStruct43
	{
		string_0 = "LASTCHANEL_BOTTOM_SIZE",
		string_1 = string_48,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 17,
		string_2 = string_49,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_204 = new GStruct43
	{
		string_0 = "LASTCHANEL_BASE_ADDR",
		string_1 = string_48,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 12,
		string_2 = string_49,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 24
	};

	public static GStruct43 gstruct43_205 = new GStruct43
	{
		string_0 = "LASTCHANEL_FUNC",
		string_1 = string_48,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 1,
		string_2 = string_49,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 14,
		byte_5 = 1
	};

	private static string string_50 = "8B ?? ?? ?? ?? ?? 8B ?? ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? 89 ?? ?? 8B ?? ?? 8B ?? ?? 89 ?? ?? 8B";

	private static string string_51 = "8B ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 8D ?? ?? ?? E8";

	public static GStruct43 gstruct43_206 = new GStruct43
	{
		string_0 = "LASTCHANEL_COUNT_SIZE",
		string_1 = string_50,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = string_51,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_207 = new GStruct43
	{
		string_0 = "LASTCHANEL_GETTEXT_OFFSET",
		string_1 = string_50,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 11,
		string_2 = string_51,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 8
	};

	public static GStruct43 gstruct43_208 = new GStruct43
	{
		string_0 = "LASTCHANEL_TEXT_SIZE",
		string_1 = string_50,
		byte_2 = 1,
		int_2 = 1,
		int_0 = 43,
		string_2 = string_51,
		byte_3 = 1,
		int_3 = 1,
		int_1 = 27
	};

	public static GStruct43 gstruct43_209 = new GStruct43
	{
		string_0 = "LASTCHANEL_ITEM_BASE_ADDR",
		string_1 = "8B ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 83 ?? ?? ?? ?? ?? 00 74 ?? 6A 01 6A",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = "8B ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 83 ?? ?? ?? ?? ?? 00 74",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	private static string string_52 = "69 ?? ?? ?? ?? ?? 8B ?? ?? 8D ?? ?? ?? ?? ?? ?? ?? 8B ?? ?? E8 ?? ?? ?? ?? 68";

	private static string string_53 = "69 ?? ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 8B";

	public static GStruct43 gstruct43_210 = new GStruct43
	{
		string_0 = "LASTCHANEL_TABBUTTON_SIZE",
		string_1 = string_52,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = string_53,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_211 = new GStruct43
	{
		string_0 = "LASTCHANEL_TABBUTTON_OFFSET",
		string_1 = string_52,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 12,
		string_2 = string_53,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 10
	};

	public static GStruct43 gstruct43_212 = new GStruct43
	{
		string_0 = "PLAYER_CHAT_FUNC_ADD",
		string_1 = "6A 01 8B ?? ?? ?? E8 ?? ?? ?? ?? 83 ?? ?? 8B ?? ?? ?? 8D ?? ?? ?? ?? ?? ?? 8B ?? ?? ?? E8",
		string_2 = "6A 01 ?? 8B ?? E8 ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 30,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 18,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_213 = new GStruct43
	{
		string_0 = "PLAYER_SAY_FUNC_ADDR",
		string_1 = "E8 ?? ?? ?? ?? 83 ?? ?? 8D ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 83 ?? ?? 89 ?? ?? ?? ?? ?? 83",
		string_2 = "E8 ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 8B ?? 83 ?? ?? 85",
		byte_2 = 1,
		byte_3 = 1,
		int_2 = 4,
		int_3 = 4,
		int_0 = 1,
		int_1 = 1,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_214 = new GStruct43
	{
		string_0 = "PLAYER_PRINT_FUNC_ADD",
		string_1 = "6A 00 8B ?? ?? ?? E8 ?? ?? ?? ?? 83 ?? ?? ?? 8B ?? ?? ?? E8",
		string_2 = "6A 00 83 ?? 01 ?? ?? E8",
		byte_2 = 1,
		byte_3 = 1,
		int_2 = 4,
		int_3 = 4,
		int_0 = 20,
		int_1 = 8,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_215 = new GStruct43
	{
		string_0 = "REPLY_INVITE_FUNC_ADDR",
		string_1 = "8B ?? ?? ?? 83 ?? ?? 85 ?? 7C ?? 8B ?? ?? ?? 83 ?? ?? 77",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_216 = new GStruct43
	{
		string_0 = "DOSCRIPT_FUNC_ADD",
		string_1 = "83 3D ?? ?? ?? ?? 00 74 ?? 68 ?? ?? ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 15,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_217 = new GStruct43
	{
		string_0 = "CLICKTO_FUNC_ADDR",
		string_1 = "56 8B ?? ?? ?? 83 ?? ?? 0F ?? ?? ?? ?? ?? B9",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_218 = new GStruct43
	{
		string_0 = "RUNTO_FUNC_ADDR",
		string_1 = "8B ?? ?? ?? 85 ?? ?? ?? 75 ?? A1 ?? ?? ?? ?? 83 ?? ?? ?? ?? ?? 00 75",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	private static string string_54 = "6A 02 8B ?? ?? 8B ?? ?? ?? ?? ?? ?? 6A ?? 8B ?? ?? ?? ?? ?? E8";

	public static GStruct43 gstruct43_219 = new GStruct43
	{
		string_0 = "FUNC_SPEC_BASE_ADDR",
		string_1 = string_54,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 16
	};

	public static GStruct43 gstruct43_220 = new GStruct43
	{
		string_0 = "FUNC_SPEC_ADDR",
		string_1 = string_54,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 21,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_221 = new GStruct43
	{
		string_0 = "TRADE_FUNC_ADDR",
		string_1 = "E8 ?? ?? ?? ?? 83 C4 08  E9 ?? ?? ?? ?? 85 ?? 0F 84 ?? ?? ?? ?? 39 ?? 0F",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 1,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_222 = new GStruct43
	{
		string_0 = "TRADE_ACCEPT_FUNC_ADDR",
		string_1 = "51 E8 ?? ?? ?? ?? 85 ?? 74 ?? 83 ?? ?? ?? ?? C6",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_223 = new GStruct43
	{
		string_0 = "TRADE_APPLY_FUNC_ADDR",
		string_1 = "51 E8 ?? ?? ?? ?? 85 ?? 74 ?? 8B ?? ?? ?? 83 ?? 01 C6",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_224 = new GStruct43
	{
		string_0 = "TRADE_PUT_MONEY_FUNC_ADDR",
		string_1 = "83 ?? ?? E8 ?? ?? ?? ?? 85 ?? 75 ?? 33 ?? 83",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0
	};

	public static GStruct43 gstruct43_225 = new GStruct43
	{
		string_0 = "TRADE_GET_MONEY_SIZE",
		string_1 = "8B ?? ?? ?? 83 ?? ?? 77 ?? 8B ?? ?? ?? 85 ?? 7C",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 19
	};

	public static GStruct43 gstruct43_226 = new GStruct43
	{
		string_0 = "TRADE_PUT_MONEY_SIZE",
		string_1 = "85 ?? 7C ?? ?? 8B ?? ?? ?? ?? ?? 81",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 7
	};

	public static GStruct43 gstruct43_227 = new GStruct43
	{
		string_0 = "KYTRANCAC_CLOSE_FUNC",
		string_1 = "75 0A E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? 8B ?? ?? 81 ?? ?? ?? ?? ?? 39 ?? ?? 75 ?? 6A",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 3,
		string_2 = "75 0A E8 ?? ?? ?? ?? ?? ?? C2 ?? ?? 8D ?? ?? ?? ?? ?? 3B ?? 75 ?? 6A",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 3,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_228 = new GStruct43
	{
		string_0 = "FOLLOW_INDEX_FUNC_ADDR",
		string_1 = "8B ?? 69 ?? ?? ?? ?? ?? 6A 00 53 03 ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 14,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_229 = new GStruct43
	{
		string_0 = "DANG_THUC_BASE_ADDR",
		string_1 = "6A 01 6A 01 E8 ?? ?? ?? ?? 83 ?? ?? B9 ?? ?? ?? ?? E8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 13,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_230 = new GStruct43
	{
		string_0 = "DANG_THUC_FLAG_OFFSET",
		string_1 = "83 ?? ?? ?? ?? ?? 00 75 ?? 8B ?? ?? C7 ?? ?? ?? ?? ?? 01 00 00 00 8B ?? ?? E8 ?? ?? ?? ?? 8B ?? ?? B8",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = "83 ?? ?? ?? ?? ?? 00 75 ?? C7 ?? ?? ?? ?? ?? 01 00 00 00 E8 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 2B",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	private static string string_55 = "55 ?? ?? ?? 89 ?? ?? 8B ?? ?? E8 ?? ?? ?? ?? 85 ?? 74 ?? 8B ?? ?? ?? ?? ?? ?? ?? 39";

	private static string string_56 = "E8 ?? ?? ?? ?? 85 ?? 74 ?? 8B ?? ?? ?? 8D ?? ?? ?? ?? ?? 3B ?? 75";

	public static GStruct43 gstruct43_231 = new GStruct43
	{
		string_0 = "DANG_THUC_FUNC_ADDR",
		string_1 = string_55,
		byte_2 = 1,
		int_2 = 0,
		int_0 = 0,
		string_2 = string_56,
		byte_3 = 1,
		int_3 = 0,
		int_1 = 0
	};

	public static GStruct43 gstruct43_232 = new GStruct43
	{
		string_0 = "DANG_THUC_NGUOI_CHOI_BASE_SIZE",
		string_1 = string_55,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 23,
		string_2 = string_56,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 15
	};

	public static GStruct43 gstruct43_233 = new GStruct43
	{
		string_0 = "DANG_THUC_HINH_ANH_BASE_SIZE",
		string_1 = string_55,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 47,
		string_2 = string_56,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 33
	};

	private static string string_57 = "8B ?? ?? ?? ?? ?? 89 ?? ?? 6A 01 6A 00 8B ?? ?? 8B";

	private static string string_58 = "8B ?? ?? ?? ?? ?? 6A 01 6A 00 ?? ?? 8B ?? ?? ?? ?? ?? ?? 6A 00";

	public static GStruct43 gstruct43_234 = new GStruct43
	{
		string_0 = "DANG_THUC_NGUOI_CHOI_OFFSET",
		string_1 = string_57,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = string_58,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_235 = new GStruct43
	{
		string_0 = "DANG_THUC_HINH_ANH_OFFSET",
		string_1 = string_57,
		byte_2 = 2,
		int_2 = 4,
		int_0 = 2,
		string_2 = string_58,
		byte_3 = 2,
		int_3 = 4,
		int_1 = 2
	};

	public static GStruct43 gstruct43_236 = new GStruct43
	{
		string_0 = "RETURNCITY_BASE_ADDR",
		string_1 = "55 8B ?? 6A ?? 8B ?? ?? ?? 8B ?? ?? ?? 8B ?? ?? ?? 8B ?? ?? ?? 8B ?? ?? ?? B9 ?? ?? ?? ?? E8 ?? ?? ?? ?? 5D C3",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 26,
		string_2 = "6A FF ?? 8B ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? C3",
		byte_3 = 1,
		int_1 = 16,
		int_3 = 4,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_237 = new GStruct43
	{
		string_0 = "RETURNCITY_SIZE",
		string_1 = "75 ?? E9 ?? ?? ?? ?? 68 ?? ?? ?? ?? 8B ?? ?? ?? 8B ?? ?? E8 ?? ?? ?? ?? 68 ?? ?? ?? ?? 8B 4D 08 ?? 8B ?? ?? 81 ?? ?? ?? ?? ?? 8B",
		byte_2 = 2,
		int_2 = 4,
		int_0 = 38,
		string_2 = "0F 84 ?? ?? ?? ?? ?? 68 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? 8B",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 29
	};

	private static string string_59 = "8B ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? EB ?? C6 ?? ?? ?? ?? ?? ?? 6A 3F";

	private static string string_60 = "8B ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 8B ?? ?? ?? ?? ?? ?? 33 ?? E8";

	public static GStruct43 gstruct43_238 = new GStruct43
	{
		string_0 = "KSHOP_BASE_ADDR",
		string_1 = string_59,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = string_60,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 7
	};

	public static GStruct43 gstruct43_239 = new GStruct43
	{
		string_0 = "REPAIR_FUNC",
		string_1 = string_59,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 7,
		string_2 = string_60,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 12,
		byte_5 = 1
	};

	public static GStruct43 gstruct43_240 = new GStruct43
	{
		string_0 = "REPAIR_MONEY_FUNC",
		string_1 = "E8 ?? ?? ?? ?? 81 ?? FF ?? 00 00 7C",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 1,
		byte_5 = 1
	};

	private static string string_61 = "8B ?? ?? FF ?? 8B ?? ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? C7 ?? ?? 00 00 00 00 8B";

	private static string string_62 = "FF ?? 8B ?? ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? ?? ?? ?? ?? ?? 8B";

	public static GStruct43 gstruct43_241 = new GStruct43
	{
		string_0 = "HELP_BASE_ADDR",
		string_1 = string_61,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 7,
		string_2 = string_62,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 4,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_242 = new GStruct43
	{
		string_0 = "HELP_BASE_SIZE",
		string_1 = string_61,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 13,
		string_2 = string_62,
		byte_3 = 1,
		int_3 = 4,
		int_1 = 10
	};

	public static GStruct43 gstruct43_243 = new GStruct43
	{
		string_0 = "HELP_COUNT_OFFSET",
		string_1 = "3B ?? ?? ?? ?? ?? 7D ?? 8B ?? ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? 8B ?? ?? 89",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = "39 ?? ?? ?? ?? ?? 7E ?? 8B ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? 8B",
		byte_3 = 1,
		int_3 = 4,
		int_1 = 2
	};

	private static string string_63 = "EB ?? 8B ?? ?? 81 ?? ?? ?? ?? ?? 8B ?? ?? 8B ?? ?? ?? ?? ?? 8B ?? ?? FF ?? 83 ?? ?? 00 0F ?? ?? ?? ?? ?? 6A FF";

	public static GStruct43 gstruct43_244 = new GStruct43
	{
		string_0 = "STRING_INPUT_SIZE",
		string_1 = string_63,
		int_2 = 4,
		byte_2 = 1,
		int_0 = 7
	};

	private static string string_64 = "8D ?? ?? ?? ?? ?? C7 ?? ?? ?? ?? ?? ?? ?? 8D ?? ?? ?? ?? ?? 8B ?? E8 ?? ?? ?? ?? 81 ?? ?? ?? ?? ?? 83";

	public static GStruct43 gstruct43_245 = new GStruct43
	{
		string_0 = "MAP_EXIST_SIZE",
		string_1 = string_64,
		int_2 = 4,
		byte_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_246 = new GStruct43
	{
		string_0 = "MAP_NEXT_SIZE",
		string_1 = string_64,
		int_2 = 4,
		byte_2 = 1,
		int_0 = 29
	};

	public static GStruct43 gstruct43_247 = new GStruct43
	{
		string_0 = "CPU_GIAM_MUC_1",
		string_1 = "74 ?? E8 ?? ?? ?? ?? 83 ?? ?? 83 ?? 01 ?? ?? 6A 01",
		int_2 = 0,
		byte_2 = 1,
		int_0 = 13
	};

	public static GStruct43 gstruct43_248 = new GStruct43
	{
		string_0 = "CPU_GIAM_MUC_2",
		string_1 = "80 ?? ?? 00 ?? ?? ?? ?? ?? ?? 80 ?? ?? ?? ?? ?? 00 0F",
		int_2 = 0,
		byte_2 = 1,
		int_0 = 4
	};

	public static GStruct43 gstruct43_249 = new GStruct43
	{
		string_0 = "CPU_SLEEP_1",
		string_1 = "75 08 6A ?? FF 15",
		int_2 = 0,
		byte_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_250 = new GStruct43
	{
		string_0 = "CPU_SLEEP_2",
		string_1 = "EB 08 6A ?? FF 15",
		int_2 = 0,
		byte_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_251 = new GStruct43
	{
		string_0 = "CPU_SLEEP_3",
		string_1 = "EB 08 6A ?? FF 15",
		int_2 = 0,
		byte_2 = 2,
		int_0 = 2
	};

	public static GStruct43 gstruct43_252 = new GStruct43
	{
		string_0 = "FLAG_SHOW_GAME",
		string_1 = "83 ?? ?? ?? ?? ?? 00 74 ?? 83 ?? ?? ?? ?? ?? 01 74 ?? 8B",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 9
	};

	public static GStruct43 gstruct43_253 = new GStruct43
	{
		string_0 = "DANHHIEU_STATUS_OFFSET",
		string_1 = "80 ?? ?? ?? ?? ?? 00 8D ?? ?? ?? ?? ?? 74 ?? 8D ?? ?? 8A ?? 83 ?? ?? 84 ?? 75",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2
	};

	public static GStruct43 gstruct43_254 = new GStruct43
	{
		string_0 = "TONGKIM_SOLUONG_NGUOI",
		string_1 = "8B ?? ?? ?? ?? ?? 51 8B ?? ?? ?? ?? ?? 52 ?? ?? ?? ?? ?? 50 8B ?? ?? ?? ?? ?? 51 8B",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_255 = new GStruct43
	{
		string_0 = "GET_TICK_COUNT",
		string_1 = "83 ?? 01 39 ?? 7D ?? 8B ?? ?? ?? ?? ?? 2B ?? 3B ?? 73",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 9,
		byte_4 = 1
	};

	private static string string_65 = "2B ?? ?? ?? ?? ?? 89 ?? ?? ?? ?? ?? ?? ?? 69 ?? E8 03 00 00 39 ?? ?? 7C ?? 33 ?? EB";

	public static GStruct43 gstruct43_256 = new GStruct43
	{
		string_0 = "TONGKIM_THOIGIAN_BATDAU",
		string_1 = string_65,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 10,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_257 = new GStruct43
	{
		string_0 = "TONGKIM_THOIGIAN_HIENTAI",
		string_1 = string_65,
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_258 = new GStruct43
	{
		string_0 = "TONGKIM_BASE_ADDR",
		string_1 = "E8 ?? ?? ?? ?? 6A 00 6A 00 6A 00 6A 51",
		byte_2 = 1,
		int_2 = 4,
		int_0 = -4,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_259 = new GStruct43
	{
		string_0 = "TONGKIM_PLAYER_BASE_ADDR",
		string_1 = "83 3D ?? ?? ?? ?? 00 75 ?? ?? ?? ?? ?? ?? ?? 6A 00 8B ?? ?? ?? ?? ?? ?? 6A 00",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_260 = new GStruct43
	{
		string_0 = "TONGKIM_POINT_MAX_OFFSET",
		string_1 = "8D ?? ?? 3B ?? 7D ?? 83 ?? 01 ?? ?? ?? ?? ?? 83 ?? 0A 7C",
		byte_2 = 1,
		int_2 = 1,
		int_0 = 2
	};

	public static GStruct43 gstruct43_261 = new GStruct43
	{
		string_0 = "GATEWAY_BASE_ADDR",
		string_1 = "8B ?? ?? ?? ?? ?? ?? ?? ?? E8 ?? ?? ?? ?? 89 ?? ?? C7 ?? ?? FF FF FF FF",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 5,
		byte_4 = 1
	};

	public static GStruct43 gstruct43_262 = new GStruct43
	{
		string_0 = "GATEWAY_CONNECT_OFFSET",
		string_1 = "C6 ?? ?? ?? ?? ?? 00 8B ?? ?? 8B ?? 8B ?? ?? 8B ?? 8B ?? 8B ?? ?? FF",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 2,
		string_2 = "83 ?? ?? ?? ?? ?? 00 75 ?? 8B ?? ?? C7 ?? ?? ?? ?? ?? 00 00 00 00",
		int_3 = 4,
		byte_3 = 1,
		int_1 = 2
	};

	public static GStruct43 gstruct43_263 = new GStruct43
	{
		string_0 = "BOX_SHORTCUT_SIZE",
		string_1 = "8B ?? ?? ?? ?? ?? 69 ?? ?? ?? ?? ?? 8B ?? ?? ?? 03 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 8D",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 29
	};

	public static GStruct43 gstruct43_264 = new GStruct43
	{
		string_0 = "BOX_CHETAO_BASE_ADDR",
		string_1 = "3B ?? ?? 7C ?? 8B ?? ?? 8A ?? ?? 8A",
		byte_2 = 1,
		int_2 = 4,
		int_0 = 13,
		byte_4 = 1
	};

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static string string_66 = null;

	public static string string_67 = null;

	private static string string_68 = "NDk5NTc4OTEwPTI2NTYwATQ5OTU3OTY5ND0xOTUzNgE0OTk1Nzk0NTQ9MTMzNjABNDk5NTgwMjM4PTE0MTk3ATQ5OTU3OTk5OD0xOTM5MgE0OTk1ODA3ODI9MzcwNDgBNDk5NTgwNTQyPTEyNTY5ATEyOTk4MjMzMTk9MzAwODUzNgE4MjIxOTUyMjQ9MTAzNgEzMDQzNTUwNzQ0PTI2ODQxOTYBMjA4MzM1MTIxOT0xMjEyNzkyATIyNzk0NzAzOTk9NTEzMDQ3NgE2MTA0MjY3MTA9MTIxMjY3NAE2MTA0MjYzNzk9MTE1MzU1OQE2MTA0MjMyMzI9MTIxMjkyNgEzMzQ5MTI2MjQ3PTE1OTQ0ODEBMzM0OTEyNjk4NT0xNTk0MzQ5ATE2MDY4MTQ5NjE9MTMyATIwOTY0NTg0OTU9NDE2OAExNDEyNDY1MjY0PTk5MgE2NjQ4NTM5Mjg9MTk5OTIBMzY4MDQ3NTcwNz02MjAyNDYBMTEyNjM4ODE4Nz01NTY0ATI5MzMzNTk0ODQ9MTU2ATE1OTMwNTQ5Mj05MgExODcxMDY0Nzc2PTM4MTI4NAEzMTk5MjcwNjUwPTIzMzU3MTYBMzkxMjgxNDE1ND01MzI4ATExMjk2MDYyMjM9MjcxNzIyNAEzMzgwOTc0MDY5PTMwMTg2MTYBMjg0Mzc1MDI3NT0yNzE3MjEyATEwNTE5NDgxOTM9MjcxNzIxNgEzODgxOTA5ODEzPTE4OTkxNTc2ATMwMjkyODA2NzY9MjcxNzA5NgEyMDU2ODIzMzk9NjgBMzg0MzgzNTg4MD05MzI0Nzg4ATM4NTUwNzA0MjI9MzU2MzIBMzU4MDk3MTA4Mj0zNTkwOAEyNDk0NTE2NDc5PTU1OTg0ATMyNzY3MTk2MDc9MTg4OTg3MjgBMjUxMzAyOTg0Mz0yNAExOTExMzIzNTQwPTU2MDA0ATE5MDk5Mjk5NzE9MTcyMAExMTkzMTM1NDE3PTE1NDg4NDA4ATI1Mzk5NjgzNjI9NzgyOAExMTE0Mzg2MzE3PTE5NjgyNjI0ATY2ODI3MzIxNz03MDU4NAE4NjE5ODM3Njc9NDg3NwEyMTM1OTI0OTYxPTQ5MTYBMzUxODM4NjkzPTU4Mzk2ATE5NjAyMzkwODg9NjABNDAyODQwNDk5Mj02OTA3NTk2ATYwMDAyNTAwND0xNTQ5OTQ3MgE4MTA1MTEyNDQ9MjA2MDMyATM5NTcwNjQxODg9NjA1MjABMzExNDg4NDgxMz00NDQwATIxNTI0OTM3ODM9NTEzMTUyMAEyMTY4NzkwMDM3PTExOTYBNjYyMjUwOTQ0PTQ0ATI3MTQ1OTQ3MzQ9NTkxMgExMTY3NzA5MDk2PTU5MTYBMTcxOTk2NTgxNT01OTIwATI2OTUxNTA5NDU9NTkyNAEzODg4NjYxNzc2PTU2ATIzMDYxNTc0MzE9OAExNzE2OTM3Mzg5PTE5NjgyNjI0ATI5ODEwMTM2NTA9MjUyATM4NTY4NzE0ODk9NTQ3NgEyNjcwMDQ4NTQ5PTYwMDgBMzQ0NDI1MjMyMD00MTY4ATM3Mjk0MzY3MjU9NDE4NAEyOTAwOTAzOTcxPTcwNDAwATMxMTk1MDg5MDQ9NzA0MDgBMzkyMzY5NDUxNT00ATMyMjQ3OTI4Mjc9MjgBMzQzOTU5NzgzNj0yMzIBNDI0ODcyMjc5Nj0yMzYBMTIyODIyMzQ0Mj01NTM2ATI3MTE3MDU2MTQ9NjA4OAEyNTgxMjE4NjAyPTEyATIxNjcxNDE5Njc9MTYBMzYwMDQ1MzMyNz0xNgExNDg1OTc5MTA1PTEzMjY0ATMyNTg2NzkyMDU9NTAyMAEzMjcwMjc1NDc5PTE5NTcyATMxNzgxODI4NTE9MTk2MDABMTgxMzE4MTQ1Nj0yODQBMTE1OTE0NTc5OT0xNTQ2MDk2ATI0NzM0MDU5NTc9MjI2ODgBOTg5MDcwNDI9NDEwNDE2ATI0MjkxOTMxNDc9MTY0ATI0ODIzNjgzNjU9MjY3NDY1MgE1NTMzMjU4Nz0zNgEzMDkwNjE3MjI2PTMwMDk1ODQBMzU0NTU5NDI1MD0xNzg4ATEyNjkzODAzMDY9MjY4NTM5MgEyNjU2MTU5MDkwPTI3MDMzMjgBMzUzNTY5NzIyMj0xMjE2ATI1NDEyMTg4NTU9MjY4NTQ4OAExMzA4ODY5MzQzPTEyNDg4ATE4MjIxMTY2MDg9NDAwODMyATI5NTU4MzMwNTU9NDQwATEwMDYxMTcxMDY9NjI5NgE4OTk2NDA5NzM9ODkyATE4NTk1OTU3MDQ9Njc0OAEzNTMwNjU5Mjg3PTM1OTE2ATIwMDI4MDEzODA9MTk0ODQBMzE5MTQ3NTU5PTQwATM4NjI2NTY2MjI9MTcyATMxNzQwMTc5ODA9MTc2ATEzMTk2OTE1MjU9MTQ3OTkzNgE0MDc2MzY3OTE3PTIwMTg5NTg0ATM1ODE0MTczNzM9MTQwNAExMDYxNjUyNDI0PTQ4ATI2OTU2NDUwMjk9NAEzMTIyMjM5MTAzPTgBMjQxMzkwMzcyNj0yOAEyNTQ2MzQxNjk2PTMyATMwODY5OTU2NjI9MTIBMzAxMzMyNDY3Nj0zNgEyOTcwMTE4NzI1PTQwATQxNTE2MTc5NDE9NDQBMzA3MjM1MzEzMz0yMDgBMzk0MTk5NzY0NT03NjABMjQ5NzY3NjIxNj02NjQBMzg3NzY5MzY4NT05NjABMzg0NTk3NjY3OT0xMDIwATQyNTkyMTQ0Mzc9MTQ3OTE2OAE4MjU5ODgxMTA9MTQ4MDU3NgEzNDk0NTcxNjIyPTY4NzkzOTIBMzA2MjU5ODY5ND05NTYBMTc1MjAwMDYyMD0xNjI3NTY4ATM4NjI4Nzg4Mjk9MTU5OTc5NzYBMTQ5OTc1MDA3Nj0xMzYBMzA3MDgzNTk3NT0xOTY4MjY5NgEzMDI1NjQ2NTAxPTk4MAEzMjIyMDY0NDIzPTgBMjA5NTcwNzI5MD0xMzIBMjIyMzg1NjQ4Mz0xNDABMzE0MzE4OTM2MD0xNDQBNDI0NjYxODA0OD0xNDgBNzcwMzMyNzE1PTY2MAE3NzAzMzM2OTU9NjY0ATEyMTk2NTg3Nzg9NTAzNgE4MDM3MTk4Nzk9MTIBMzM2NTQxMzk3Mj01MgE3ODMyMjg3ODA9OTYBMTI4MTQ5MTEzMT0zMTYBMjI1MTM4MTkwNj04MjABMjE2MTEwMzQwOD00OAExMjA3MjQ2NDIyPTE0ODkwMjQBNDE0MTI5OTg0OD0xMDg1ODI0ATE3MTg3NjQ4NTA9OTgwMDk2ATMwMDk4ODQ5NzA9MjY0ATEyMzYxOTY0OTU9MjcxNzA4MAEzMTE0MDIzODg2PTE4MDgBMjg5Njg4MTM3Mj0yNzMzNDAwATQ2Mzk4NzM4Nz03NDQBMjQyNzUyODQyMj0yNjg0OTgwATI4OTQ0NDA1OTg9MjcwNTI4MAEyMjkyNjA2MTU3PTE1ODQBMjgwOTAyMDk0OD0xNTg4ATM2NjAyNjAxPTI2ODQ5NzIBMTk2MjAwMTkyMT05MgEyOTIwMjY4OTM2PTQ1MgEyMzgzNDAwNDg9MzAwNjU5MgEzMjgyMDI1MDg0PTQ0MAExNzc1NjQ5ODc9MjY5OTc2MAEyMTU5NTExMjI5PTE0NzAxNzYBNzc3MjM0NTYxPTM2ATU2MTE3MDY4Mj0xNDgxMTY4ATM2ODUxNjUzNjQ9NDQBOTc1NzM5MjQwPTU4MzI0ATUzNTQ4NzMxNz0yNzIBMTUzNTE3NTE1ND00OAEzNTEwNTIzODAxPTU2ATEzNTQ4NzU0NTk9MTQ3ODk0NAEyNjQ4MTM3MDkxPTY5MDc1ODQBMjE5Njg4NTc3Nz01ODQzMgE0MTUxMDY0NDY4PTI1NgE5NjU1NjcyNDA9MjY0ATQxODU4MDYwND02ODI1MjgBMTk0NDI4NDM1MT0yNjc0ODMyATE4ODgzNDYxODk9NDcyATEzNTc5OTcwOT04ATIwMTcwNzI2NjE9MTI4MDMyMAEzNTEzMTk5MTU9MzAwATI4MzY5OTQ2MzQ9NjkxMDEwMAEyMzQ3MTEwODg5PTk0NTk4NAEzOTQzMDM1MzkyPTM0MDQ0OAEyMDMwMjY2Mzk4PTMwMjIyNDQBMTI0NDg3ODUyOT02MTk1MzYBMzIwMTA0NDIyOD03MjAxNTU2ATI3OTQ4NTU0ODU9MTI4Njk0NAEzNjM5ODMzODk3PTE2NDcxMDQBMjc3NjU0NjY4OD0yNjQBMjUwMzg0OTU0MD0yNzMzMzk2ATIxMDQ1ODY2ODQ9OTYwATI3MjIwMTg3Njg9MjcxMzI4OAE0MDQ0MDc1NTE3PTMwMTI2ODQBMjQ2OTA1OTE1NT0xMDgxNzkyATI0NDE2NDI4ODk9MjcxMjcxMgExNTY0MTQxNzQ0PTE1OTM5MzA4ATE2MjE5NTA2MzY9MTg5MDA4ODABMjMxMzM2NDc2Mz02MDIwATEyNjM2OTY4MTQ9NTgzNgEzODU1MTMzNjk4PTYwNjEyATE1Njc5MDY2NTI9NTYBNTMxMDU1OTc1PTE1OTk2NzM2ATE1NDU2OTEyNzU9MTI4ODE5MgEzNjMzMjgxMTI0PTEzMDUwNDABNjE3MzEwMTYyPTI3MTUyNDABMTU4NTg3NjgzOD04NTc1NjgBNDI3MDA3MzQ3Mj04NTk0ODgBMjMyNTIyNTM9MTQ2OTEwNAExNjcwOTQ4ODM4PTIyODAwATU2MDQxMTUwNz0xNTk5NDY4MAEyNjQ0OTYxNDU4PTcyMzYBMzg1MzIxNzgwNz0xMDMyATQwNDkyMzcxODE9MTQ2OTMxMgEzNTgxMzU1MTQ0PTE2Mjg1NzYBMjU1NTk5MjUxMz0xNzk0MjcyATIwMjMxMTc3MDg9MTQ4MTEwNAEzMDY2NjU1OTA0PTE0ODEwMjQBNzY1NTUwMzE9MTQ4MDg5NgE0OTAzODAzODY9MTk5MTIBMjk0OTg0MDQ4ND02OTkBMzkwOTM1MDczOD03NDc2ATMzODAzNTIyNzQ9NjgzNgE0MTAzODUzNjMwPTY5MDY4OTYBMjk5Njc5NzkxMj01ODIwNDgBMjY1NDgyNTY4NT0yNjQBMzIwNjY1MTc1Mj0yNjABMTg1OTY2MjMzND0yOAEzODcyODk0NzIyPTcyMDU4NTIBOTM5MjE5Njk2PTM1NgEyNzEzMDg5Nzc2PTM3NgExMTEyMTUxMDg4PTEyOTIxNDQBMTcyMzc1NTU3OD03MjAxNTU2ATMyOTYxNDc3MDE9ODI0OTYBNzEzMzMyODk2PTMxNjE0NAE0MDY4NzA5OTY3PTMxNjk5MgEyNjMyMDkzMzMyPTU4MTY4MAEyODAwMzE2NDgxPTEyODQyMjQBMjU3OTU0MjE4Nj0xNTQ1OTg0ATkwNzgzNjM2MD00MjkwNzcyNDM2ATkyNDEyNDQzOD0zODE2ATI0MjU5NTI4OTA9MjY0AQ==";

	public static int int_6 = 0;

	public static int int_7 = 0;

	private static int[,] int_8 = new int[5, 5]
	{
		{
			1,
			2,
			0,
			4,
			3
		},
		{
			4,
			2,
			1,
			3,
			0
		},
		{
			3,
			1,
			0,
			2,
			4
		},
		{
			0,
			1,
			3,
			4,
			2
		},
		{
			2,
			1,
			4,
			3,
			0
		}
	};

	private static int[,] int_9 = new int[5, 10]
	{
		{
			2,
			3,
			4,
			5,
			0,
			1,
			8,
			9,
			6,
			7
		},
		{
			8,
			9,
			4,
			5,
			2,
			3,
			6,
			7,
			0,
			1
		},
		{
			6,
			7,
			2,
			3,
			0,
			1,
			4,
			5,
			8,
			9
		},
		{
			0,
			1,
			2,
			3,
			6,
			7,
			8,
			9,
			4,
			5
		},
		{
			4,
			5,
			2,
			3,
			8,
			9,
			6,
			7,
			0,
			1
		}
	};

	public static GStruct43 gstruct43_265 = new GStruct43
	{
		string_0 = "represent2.dll",
		string_1 = "83 ?? ?? ?? ?? ?? ?? ?? ?? FF ?? ?? ?? ?? ?? ?? 85 ?? 75",
		byte_2 = 1,
		int_2 = 0,
		int_0 = 3,
		string_2 = "83 ?? 08 89 ?? ?? ?? ?? ?? ?? ?? ?? ?? FF 24 AD",
		byte_3 = 1,
		int_3 = 0,
		int_1 = 7
	};

	public static string string_69 = null;

	public static string smethod_0()
	{
		string text = string.Empty;
		int[] array = Class20.smethod_24(string_17);
		if (array != null && array.Length > 0)
		{
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					Process processById = Process.GetProcessById(array[i]);
					text = processById.MainModule.FileName;
					if (text != null && text != string.Empty)
					{
						return text;
					}
				}
				catch
				{
				}
			}
		}
		return text;
	}

	public static GStruct33[] smethod_1()
	{
		return new GStruct33[54]
		{
			new GStruct33
			{
				int_0 = 1,
				int_1 = 43,
				int_2 = 0,
				string_0 = "Không thể phá hủy"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 139,
				int_2 = 0,
				string_0 = "Kỹ năng  Võ công vốn có"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 58,
				int_2 = 1,
				string_0 = "Bỏ qua né tránh: (x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 117,
				int_2 = 15,
				string_0 = "Phản đòn cận chiến: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 134,
				int_2 = 8,
				string_0 = "Chuyển hóa sát thương thành nội lực: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 135,
				int_2 = 1,
				string_0 = "May mắn: +(x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 166,
				int_2 = 250,
				string_0 = "Tỉ lệ công kích chính xác: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 111,
				int_2 = 25,
				string_0 = "Tốc độ di chuyển: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 115,
				int_2 = 10,
				string_0 = "Tốc độ đánh - ngoại công: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 116,
				int_2 = 30,
				string_0 = "Tốc độ đánh - nội công: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 114,
				int_2 = 1,
				string_0 = "Kháng tất cả: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 136,
				int_2 = 1,
				string_0 = "Hút sinh lực: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 137,
				int_2 = 1,
				string_0 = "Hút nội lực: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 106,
				int_2 = 30,
				string_0 = "Thời gian làm chậm: -(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 110,
				int_2 = 30,
				string_0 = "Thời gian choáng: -(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 108,
				int_2 = 30,
				string_0 = "Thời gian trúng độc: -(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 113,
				int_2 = 30,
				string_0 = "Thời gian phục hồi: -(x)"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 104,
				int_2 = 15,
				string_0 = "Phòng thủ vật lý: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 101,
				int_2 = 25,
				string_0 = "Kháng độc: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 102,
				int_2 = 20,
				string_0 = "Kháng hỏa: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 103,
				int_2 = 20,
				string_0 = "Kháng lôi: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 105,
				int_2 = 20,
				string_0 = "Kháng băng: +(x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 121,
				int_2 = 50,
				string_0 = "Sát thương vật lý - ngoại công: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 126,
				int_2 = 80,
				string_0 = "Sát thương vật lý - ngoại công: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 168,
				int_2 = 100,
				string_0 = "Sát thương vật lý - nội công: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 244,
				int_2 = 80,
				string_0 = "Sát thương vật lý - nội công: +(x) %"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 123,
				int_2 = 50,
				string_0 = "Băng sát - ngoại công: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 169,
				int_2 = 80,
				string_0 = "Băng sát - nội công: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 122,
				int_2 = 50,
				string_0 = "Hỏa sát - ngoại công: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 170,
				int_2 = 80,
				string_0 = "Hỏa sát - nội công: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 124,
				int_2 = 50,
				string_0 = "Lôi sát - ngoại công: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 171,
				int_2 = 80,
				string_0 = "Lôi sát - nội công: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 125,
				int_2 = 15,
				string_0 = "Độc sát - ngoại công: +(x) điểm/lần"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 172,
				int_2 = 15,
				string_0 = "Độc sát - nội công: +(x) điểm/lần"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 85,
				int_2 = 100,
				string_0 = "Sinh lực tối đa: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 99,
				int_2 = 10,
				string_0 = "Sinh khí: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 89,
				int_2 = 100,
				string_0 = "Nội lực tối đa: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 100,
				int_2 = 10,
				string_0 = "Nội công: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 93,
				int_2 = 160,
				string_0 = "Thể lực tối đa: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 97,
				int_2 = 10,
				string_0 = "Sức mạnh: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 98,
				int_2 = 10,
				string_0 = "Thân pháp: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 88,
				int_2 = 3,
				string_0 = "Phục hồi sinh lực mỗi nửa giây: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 1,
				int_1 = 92,
				int_2 = 1,
				string_0 = "Phục hồi nội lực mỗi nửa giây: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 96,
				int_2 = 5,
				string_0 = "Phục hồi thể lực mỗi nửa giây: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 220,
				int_2 = 8,
				string_0 = "Tạo thành thời gian choáng: (x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 219,
				int_2 = 40,
				string_0 = "Tạo thành sát thương có thời gian hoạt động: +(x) điểm"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 221,
				int_2 = 15,
				string_0 = "Xem nhẹ độc phòng của đối phương: (x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 222,
				int_2 = 15,
				string_0 = "Xem nhẹ hỏa phòng của đối phương: (x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 223,
				int_2 = 15,
				string_0 = "Xem nhẹ lôi phòng của đối phương: (x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 224,
				int_2 = 15,
				string_0 = "Xem nhẹ phổ phòng của đối phương: (x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 225,
				int_2 = 15,
				string_0 = "Xem nhẹ băng phòng của đối phương: (x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 70,
				int_2 = 5,
				string_0 = "Tấn công chí mạng: (x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 226,
				int_2 = 10,
				string_0 = "Xác suất hóa giải sát thương: (x) %"
			},
			new GStruct33
			{
				int_0 = 0,
				int_1 = 227,
				int_2 = 8,
				string_0 = "Xác suất trọng kích: (x) %"
			}
		};
	}

	private static GStruct43[] smethod_2()
	{
		return new GStruct43[248]
		{
			Class58.gstruct43_0,
			Class58.gstruct43_1,
			Class58.gstruct43_2,
			Class58.gstruct43_3,
			Class58.gstruct43_4,
			Class58.gstruct43_5,
			Class58.gstruct43_6,
			gstruct43_261,
			gstruct43_262,
			gstruct43_0,
			gstruct43_252,
			gstruct43_264,
			gstruct43_249,
			gstruct43_250,
			gstruct43_251,
			gstruct43_247,
			gstruct43_248,
			gstruct43_245,
			gstruct43_246,
			gstruct43_244,
			gstruct43_263,
			gstruct43_3,
			gstruct43_1,
			gstruct43_2,
			gstruct43_6,
			gstruct43_5,
			gstruct43_7,
			gstruct43_253,
			gstruct43_254,
			gstruct43_255,
			gstruct43_256,
			gstruct43_257,
			gstruct43_258,
			gstruct43_259,
			gstruct43_260,
			gstruct43_11,
			gstruct43_12,
			gstruct43_13,
			gstruct43_18,
			gstruct43_19,
			gstruct43_20,
			gstruct43_21,
			gstruct43_22,
			gstruct43_9,
			gstruct43_10,
			gstruct43_14,
			gstruct43_15,
			gstruct43_16,
			gstruct43_17,
			gstruct43_23,
			gstruct43_26,
			gstruct43_27,
			gstruct43_28,
			gstruct43_29,
			gstruct43_30,
			gstruct43_31,
			gstruct43_32,
			gstruct43_33,
			gstruct43_34,
			gstruct43_35,
			gstruct43_36,
			gstruct43_37,
			gstruct43_38,
			gstruct43_39,
			gstruct43_40,
			gstruct43_41,
			gstruct43_42,
			gstruct43_43,
			gstruct43_44,
			gstruct43_45,
			gstruct43_46,
			gstruct43_47,
			gstruct43_48,
			gstruct43_49,
			gstruct43_50,
			gstruct43_54,
			gstruct43_55,
			gstruct43_56,
			gstruct43_57,
			gstruct43_58,
			gstruct43_59,
			gstruct43_60,
			gstruct43_66,
			gstruct43_72,
			gstruct43_73,
			gstruct43_74,
			gstruct43_75,
			gstruct43_228,
			gstruct43_76,
			gstruct43_87,
			gstruct43_88,
			gstruct43_89,
			gstruct43_90,
			gstruct43_91,
			gstruct43_92,
			gstruct43_93,
			gstruct43_236,
			gstruct43_237,
			gstruct43_229,
			gstruct43_230,
			gstruct43_231,
			gstruct43_232,
			gstruct43_233,
			gstruct43_234,
			gstruct43_235,
			gstruct43_94,
			gstruct43_95,
			gstruct43_96,
			gstruct43_97,
			gstruct43_98,
			gstruct43_99,
			gstruct43_102,
			gstruct43_103,
			gstruct43_104,
			gstruct43_105,
			gstruct43_106,
			gstruct43_108,
			gstruct43_109,
			gstruct43_107,
			gstruct43_110,
			gstruct43_111,
			gstruct43_112,
			gstruct43_113,
			gstruct43_115,
			gstruct43_114,
			gstruct43_116,
			gstruct43_117,
			gstruct43_118,
			gstruct43_119,
			gstruct43_120,
			gstruct43_100,
			gstruct43_101,
			gstruct43_121,
			gstruct43_122,
			gstruct43_123,
			gstruct43_124,
			gstruct43_125,
			gstruct43_126,
			gstruct43_127,
			gstruct43_128,
			gstruct43_129,
			gstruct43_130,
			gstruct43_131,
			gstruct43_132,
			gstruct43_133,
			gstruct43_134,
			gstruct43_135,
			gstruct43_136,
			gstruct43_137,
			gstruct43_138,
			gstruct43_139,
			gstruct43_141,
			gstruct43_140,
			gstruct43_142,
			gstruct43_143,
			gstruct43_144,
			gstruct43_145,
			gstruct43_146,
			gstruct43_147,
			gstruct43_149,
			gstruct43_151,
			gstruct43_150,
			gstruct43_148,
			gstruct43_152,
			gstruct43_153,
			gstruct43_154,
			gstruct43_155,
			gstruct43_156,
			gstruct43_67,
			gstruct43_68,
			gstruct43_69,
			gstruct43_70,
			gstruct43_71,
			gstruct43_157,
			gstruct43_159,
			gstruct43_158,
			gstruct43_160,
			gstruct43_161,
			gstruct43_162,
			gstruct43_163,
			gstruct43_164,
			gstruct43_165,
			gstruct43_175,
			gstruct43_176,
			gstruct43_177,
			gstruct43_178,
			gstruct43_179,
			gstruct43_180,
			gstruct43_181,
			gstruct43_182,
			gstruct43_183,
			gstruct43_227,
			gstruct43_238,
			gstruct43_239,
			gstruct43_240,
			gstruct43_167,
			gstruct43_168,
			gstruct43_169,
			gstruct43_170,
			gstruct43_171,
			gstruct43_172,
			gstruct43_173,
			gstruct43_174,
			gstruct43_184,
			gstruct43_86,
			gstruct43_85,
			gstruct43_185,
			gstruct43_186,
			gstruct43_187,
			gstruct43_188,
			gstruct43_192,
			gstruct43_189,
			gstruct43_190,
			gstruct43_191,
			gstruct43_196,
			gstruct43_197,
			gstruct43_198,
			gstruct43_199,
			gstruct43_200,
			gstruct43_201,
			gstruct43_215,
			gstruct43_221,
			gstruct43_222,
			gstruct43_223,
			gstruct43_224,
			gstruct43_226,
			gstruct43_225,
			gstruct43_202,
			gstruct43_203,
			gstruct43_204,
			gstruct43_205,
			gstruct43_206,
			gstruct43_207,
			gstruct43_208,
			gstruct43_209,
			gstruct43_210,
			gstruct43_211,
			gstruct43_220,
			gstruct43_219,
			gstruct43_216,
			gstruct43_212,
			gstruct43_213,
			gstruct43_214,
			gstruct43_217,
			gstruct43_218,
			gstruct43_241,
			gstruct43_242,
			gstruct43_243
		};
	}

	private static int smethod_3(GStruct43[] gstruct43_266, ref string string_70, ref string string_71)
	{
		int num = 0;
		for (int i = 0; i < gstruct43_266.Length; i++)
		{
			if (gstruct43_266[i].uint_0 == 0)
			{
				string_70 = string_70 + i.ToString() + "; ";
				num++;
			}
			if (FormMain.bool_1)
			{
				string[] array = gstruct43_266[i].string_0.Split('.');
				array[0] = array[array.Length - 1];
				string text = "\t";
				if (array[0].Length < 16)
				{
					text += text;
				}
				while (array[0].Length < 20)
				{
					string[] array2;
					(array2 = array)[0] = array2[0] + " ";
				}
				string str = i + ". " + array[0] + " " + text + "= " + Class11.smethod_40(gstruct43_266[i].uint_0, 8, bool_1: false);
				string_71 = string_71 + str + "|";
			}
		}
		return num;
	}

	public static bool smethod_4(string string_70, string string_71 = null)
	{
		bool_0 = false;
		bool_1 = false;
		Class11.smethod_24(ref Class11.string_14, "Đang cập nhật dữ liệu game, xin chờ chút xíu...");
		uint num = 0u;
		uint[] array = null;
		byte[] byte_ = null;
		uint num2 = 0u;
		uint[] array2 = null;
		byte[] byte_2 = null;
		uint num3 = 0u;
		uint[] array3 = null;
		byte[] byte_3 = null;
		int num4 = Class91.smethod_0(string_70, string_71, ref byte_3, ref array3, ref num3, ".text", ref byte_2, ref array2, ref num2, ".text", ref byte_, ref array, ref num, ".text");
		if (num4 > 0)
		{
			Class91.smethod_3(array[1], byte_, ref Class58.gstruct43_0);
			Class91.smethod_3(array[1], byte_, ref Class58.gstruct43_1);
			Class91.smethod_3(array[1], byte_, ref Class58.gstruct43_2);
			Class91.smethod_3(array[1], byte_, ref Class58.gstruct43_3);
			Class91.smethod_3(array[1], byte_, ref Class58.gstruct43_4);
			Class91.smethod_3(array[1], byte_, ref Class58.gstruct43_5);
			Class91.smethod_3(array[1], byte_, ref Class58.gstruct43_6);
			Class91.smethod_3(array2[1], byte_2, ref gstruct43_4);
			Class91.smethod_3(array2[1], byte_2, ref gstruct43_6);
			Class91.smethod_3(array2[1], byte_2, ref gstruct43_5, 0L, num2);
			long num5 = 0L;
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_245);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_246, num5 - 4L);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_248);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_247, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_249);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_250);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_251, num5 - 10L);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_244);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_0);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_252);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_261);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_262);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_264);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_263);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_3);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_7);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_1);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_2, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_253);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_254);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_255);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_256);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_257, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_258);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_259);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_260);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_11);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_12, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_13, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_9);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_10);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_14, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_15, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_16, num5);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_18);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_19, num5);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_20);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_21, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_22, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_49);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_17);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_23);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_24);
			if (gstruct43_24.uint_0 == 0)
			{
				gstruct43_24.uint_0 = 22744u;
			}
			gstruct43_25.uint_0 = gstruct43_24.uint_0 + 8;
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_26);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_27);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_28);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_29);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_30);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_31);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_32);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_33, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_34, num5);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_35);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_36, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_37, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_38, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_39);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_40);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_41, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_42);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_43);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_44);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_45);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_46, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_47, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_48, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_50);
			if (gstruct43_50.uint_0 != 0)
			{
				gstruct43_51.uint_0 = gstruct43_50.uint_0 + 4;
				gstruct43_52.uint_0 = gstruct43_50.uint_0 + 8;
				gstruct43_53.uint_0 = gstruct43_50.uint_0 + 12;
			}
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_54);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_55);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_56);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_57);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_58);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_59, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_60);
			if (gstruct43_60.uint_0 != 0)
			{
				gstruct43_61.uint_0 = gstruct43_60.uint_0 - 8;
				gstruct43_62.uint_0 = gstruct43_60.uint_0 - 12;
				gstruct43_63.uint_0 = 152u;
				gstruct43_64.uint_0 = 184u;
				gstruct43_65.uint_0 = 88u;
			}
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_66);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_72);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_73);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_74, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_75);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_228);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_76);
			if (gstruct43_76.uint_0 != 0)
			{
				gstruct43_77.uint_0 = gstruct43_76.uint_0 + 8;
				gstruct43_78.uint_0 = gstruct43_76.uint_0 + 32;
				gstruct43_79.uint_0 = gstruct43_76.uint_0 + 8 + 4;
				gstruct43_80.uint_0 = gstruct43_76.uint_0 + 32 + 4;
				gstruct43_81.uint_0 = gstruct43_76.uint_0 + 8 + 8;
				gstruct43_82.uint_0 = gstruct43_76.uint_0 + 32 + 8;
				gstruct43_83.uint_0 = gstruct43_76.uint_0 + 8 + 12;
				gstruct43_84.uint_0 = gstruct43_76.uint_0 + 32 + 12;
			}
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_87);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_88);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_89, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_90, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_91);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_92);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_93);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_236);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_237);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_229);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_230);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_231);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_232, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_233, num5);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_234);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_235, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_94);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_95);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_96, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_97);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_98);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_99);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_102);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_103, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_104);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_105);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_106, num5);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_108);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_109, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_107);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_110);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_111);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_112);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_113);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_115);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_114);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_116);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_117);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_118);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_119);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_120);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_100);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_101);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_121);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_122);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_123);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_124, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_125);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_126);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_127, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_128);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_129);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_130);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_131, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_132);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_133);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_134);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_135);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_136);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_137);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_138);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_139);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_141);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_140);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_142);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_143);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_144);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_145);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_146);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_147);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_149);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_151);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_150);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_148);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_152);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_153);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_154);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_155);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_156);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_67);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_68, num5);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_69);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_70, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_71);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_157);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_158);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_159, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_160);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_161);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_162);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_163);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_164);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_165);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_167);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_168);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_169, num5);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_170);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_171, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_172, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_174);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_175);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_176);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_177);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_178);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_179);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_180);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_181);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_182);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_183);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_173);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_227);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_238);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_239);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_240);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_184);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_86);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_185);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_85);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_186);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_187);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_188);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_192);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_189);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_190);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_191);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_196);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_197);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_198);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_199);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_200, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_201);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_215);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_221);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_222);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_223);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_224);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_226);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_225);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_202);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_203, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_204, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_205, num5);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_206);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_207, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_208, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_209, num5);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_210);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_211, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_220);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_219);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_216);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_212);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_213);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_214);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_217);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_218);
			num5 = Class91.smethod_3(array3[1], byte_3, ref gstruct43_241);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_242, num5);
			Class91.smethod_3(array3[1], byte_3, ref gstruct43_243);
			string_66 = null;
			string_67 = null;
			GStruct43[] gstruct43_ = smethod_2();
			bool_0 = (smethod_3(gstruct43_, ref string_66, ref string_67) == 0);
			if (string_66 == null)
			{
				Class11.smethod_24(ref Class11.string_14, "FORM:Cập nhật data game thành công, đã có thể sử dụng auto.");
			}
			else
			{
				Class11.smethod_24(ref Class11.string_14, "FORM:Cập nhật data game thất bại!||Hãy chọn đúng file game trong thư mục game, xong mở 1 cửa sổ game để đó rồi bấm lại nút cập nhật data game.||Các mã lỗi xảy ra là: " + string_66);
			}
			Class11.smethod_24(ref Class11.string_14, "Kết thúc cập nhật data game.");
			bool_1 = true;
			smethod_5(gstruct43_, string_5, string_13);
			return bool_0;
		}
		if (num4 == -1)
		{
			Class11.smethod_24(ref Class11.string_14, "Hãy mở 1 cửa sổ game lên trước khi bấm cập nhật.");
		}
		else
		{
			Class11.smethod_24(ref Class11.string_14, "Không lấy được data, hãy thoát hết game rồi làm lại.");
		}
		bool_1 = true;
		return false;
	}

	public static bool smethod_5(GStruct43[] gstruct43_266, string string_70, string string_71)
	{
		if (gstruct43_266 == null)
		{
			return false;
		}
		Class11.smethod_8(string_70);
		Class11.smethod_20(string_70 + "\\" + string_71);
		string text = string.Empty;
		int num = 0;
		while (true)
		{
			if (num < gstruct43_266.Length)
			{
				if (gstruct43_266[num].uint_0 == 0)
				{
					break;
				}
				object obj = text;
				text = string.Concat(obj, Class11.smethod_7(gstruct43_266[num].string_0), "=", gstruct43_266[num].uint_0, '\u0001');
				num++;
				continue;
			}
			Class11.smethod_29(string_70 + "\\" + string_71, Class11.smethod_17(text), 1);
			return true;
		}
		return false;
	}

	public static bool smethod_6()
	{
		string_66 = null;
		string_67 = null;
		bool_0 = false;
		bool_1 = false;
		string text = string.Empty;
		if (int_6 > 0)
		{
			text = Class11.smethod_28(string_5 + "\\" + string_13, 0, 0, 1);
		}
		if (text == null || text == string.Empty)
		{
			text = string_68;
		}
		text = Class11.smethod_16(text);
		if (text != null && !(text == string.Empty))
		{
			string[] array = text.Split('\u0001');
			string[,] array2 = new string[array.Length, 2];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && !(array[i] == string.Empty))
				{
					string[] array3 = array[i].Split('=');
					if (array3.Length > 1)
					{
						array2[i, 0] = array3[0];
						array2[i, 1] = array3[1];
					}
				}
			}
			Class91.smethod_1(ref Class58.gstruct43_0, array2);
			Class91.smethod_1(ref Class58.gstruct43_1, array2);
			Class91.smethod_1(ref Class58.gstruct43_2, array2);
			Class91.smethod_1(ref Class58.gstruct43_3, array2);
			Class91.smethod_1(ref Class58.gstruct43_4, array2);
			Class91.smethod_1(ref Class58.gstruct43_5, array2);
			Class91.smethod_1(ref Class58.gstruct43_6, array2);
			Class91.smethod_1(ref gstruct43_6, array2);
			Class91.smethod_1(ref gstruct43_5, array2);
			Class91.smethod_1(ref gstruct43_4, array2);
			Class91.smethod_1(ref gstruct43_7, array2);
			Class91.smethod_1(ref gstruct43_248, array2);
			Class91.smethod_1(ref gstruct43_247, array2);
			Class91.smethod_1(ref gstruct43_249, array2);
			Class91.smethod_1(ref gstruct43_250, array2);
			Class91.smethod_1(ref gstruct43_251, array2);
			Class91.smethod_1(ref gstruct43_245, array2);
			Class91.smethod_1(ref gstruct43_246, array2);
			Class91.smethod_1(ref gstruct43_0, array2);
			Class91.smethod_1(ref gstruct43_252, array2);
			Class91.smethod_1(ref gstruct43_264, array2);
			Class91.smethod_1(ref gstruct43_262, array2);
			Class91.smethod_1(ref gstruct43_261, array2);
			Class91.smethod_1(ref gstruct43_263, array2);
			Class91.smethod_1(ref gstruct43_244, array2);
			Class91.smethod_1(ref gstruct43_3, array2);
			Class91.smethod_1(ref gstruct43_1, array2);
			Class91.smethod_1(ref gstruct43_2, array2);
			Class91.smethod_1(ref gstruct43_253, array2);
			Class91.smethod_1(ref gstruct43_254, array2);
			Class91.smethod_1(ref gstruct43_255, array2);
			Class91.smethod_1(ref gstruct43_256, array2);
			Class91.smethod_1(ref gstruct43_257, array2);
			Class91.smethod_1(ref gstruct43_258, array2);
			Class91.smethod_1(ref gstruct43_260, array2);
			Class91.smethod_1(ref gstruct43_259, array2);
			Class91.smethod_1(ref gstruct43_11, array2);
			Class91.smethod_1(ref gstruct43_12, array2);
			Class91.smethod_1(ref gstruct43_13, array2);
			Class91.smethod_1(ref gstruct43_18, array2);
			Class91.smethod_1(ref gstruct43_19, array2);
			Class91.smethod_1(ref gstruct43_20, array2);
			Class91.smethod_1(ref gstruct43_21, array2);
			Class91.smethod_1(ref gstruct43_22, array2);
			Class91.smethod_1(ref gstruct43_9, array2);
			Class91.smethod_1(ref gstruct43_10, array2);
			Class91.smethod_1(ref gstruct43_14, array2);
			Class91.smethod_1(ref gstruct43_15, array2);
			Class91.smethod_1(ref gstruct43_16, array2);
			Class91.smethod_1(ref gstruct43_49, array2);
			Class91.smethod_1(ref gstruct43_17, array2);
			Class91.smethod_1(ref gstruct43_23, array2);
			Class91.smethod_1(ref gstruct43_24, array2);
			gstruct43_25.uint_0 = gstruct43_24.uint_0 + 8;
			Class91.smethod_1(ref gstruct43_26, array2);
			Class91.smethod_1(ref gstruct43_27, array2);
			Class91.smethod_1(ref gstruct43_28, array2);
			Class91.smethod_1(ref gstruct43_29, array2);
			Class91.smethod_1(ref gstruct43_30, array2);
			Class91.smethod_1(ref gstruct43_31, array2);
			Class91.smethod_1(ref gstruct43_32, array2);
			Class91.smethod_1(ref gstruct43_33, array2);
			Class91.smethod_1(ref gstruct43_34, array2);
			Class91.smethod_1(ref gstruct43_35, array2);
			Class91.smethod_1(ref gstruct43_36, array2);
			Class91.smethod_1(ref gstruct43_37, array2);
			Class91.smethod_1(ref gstruct43_38, array2);
			Class91.smethod_1(ref gstruct43_39, array2);
			Class91.smethod_1(ref gstruct43_40, array2);
			Class91.smethod_1(ref gstruct43_41, array2);
			Class91.smethod_1(ref gstruct43_42, array2);
			Class91.smethod_1(ref gstruct43_43, array2);
			Class91.smethod_1(ref gstruct43_44, array2);
			Class91.smethod_1(ref gstruct43_45, array2);
			Class91.smethod_1(ref gstruct43_46, array2);
			Class91.smethod_1(ref gstruct43_47, array2);
			Class91.smethod_1(ref gstruct43_48, array2);
			Class91.smethod_1(ref gstruct43_50, array2);
			if (gstruct43_50.uint_0 != 0)
			{
				gstruct43_51.uint_0 = gstruct43_50.uint_0 + 4;
				gstruct43_52.uint_0 = gstruct43_50.uint_0 + 8;
				gstruct43_53.uint_0 = gstruct43_50.uint_0 + 12;
			}
			Class91.smethod_1(ref gstruct43_54, array2);
			Class91.smethod_1(ref gstruct43_55, array2);
			Class91.smethod_1(ref gstruct43_56, array2);
			Class91.smethod_1(ref gstruct43_57, array2);
			Class91.smethod_1(ref gstruct43_58, array2);
			Class91.smethod_1(ref gstruct43_59, array2);
			Class91.smethod_1(ref gstruct43_60, array2);
			if (gstruct43_60.uint_0 != 0)
			{
				gstruct43_61.uint_0 = gstruct43_60.uint_0 - 8;
				gstruct43_62.uint_0 = gstruct43_60.uint_0 - 12;
				gstruct43_63.uint_0 = 152u;
				gstruct43_64.uint_0 = 184u;
				gstruct43_65.uint_0 = 88u;
			}
			Class91.smethod_1(ref gstruct43_66, array2);
			Class91.smethod_1(ref gstruct43_72, array2);
			Class91.smethod_1(ref gstruct43_73, array2);
			Class91.smethod_1(ref gstruct43_74, array2);
			Class91.smethod_1(ref gstruct43_75, array2);
			Class91.smethod_1(ref gstruct43_228, array2);
			Class91.smethod_1(ref gstruct43_76, array2);
			if (gstruct43_76.uint_0 != 0)
			{
				gstruct43_77.uint_0 = gstruct43_76.uint_0 + 8;
				gstruct43_78.uint_0 = gstruct43_76.uint_0 + 32;
				gstruct43_79.uint_0 = gstruct43_76.uint_0 + 8 + 4;
				gstruct43_80.uint_0 = gstruct43_76.uint_0 + 32 + 4;
				gstruct43_81.uint_0 = gstruct43_76.uint_0 + 8 + 8;
				gstruct43_82.uint_0 = gstruct43_76.uint_0 + 32 + 8;
				gstruct43_83.uint_0 = gstruct43_76.uint_0 + 8 + 12;
				gstruct43_84.uint_0 = gstruct43_76.uint_0 + 32 + 12;
			}
			Class91.smethod_1(ref gstruct43_87, array2);
			Class91.smethod_1(ref gstruct43_88, array2);
			Class91.smethod_1(ref gstruct43_89, array2);
			Class91.smethod_1(ref gstruct43_90, array2);
			Class91.smethod_1(ref gstruct43_91, array2);
			Class91.smethod_1(ref gstruct43_92, array2);
			Class91.smethod_1(ref gstruct43_93, array2);
			Class91.smethod_1(ref gstruct43_236, array2);
			Class91.smethod_1(ref gstruct43_237, array2);
			Class91.smethod_1(ref gstruct43_229, array2);
			Class91.smethod_1(ref gstruct43_230, array2);
			Class91.smethod_1(ref gstruct43_231, array2);
			Class91.smethod_1(ref gstruct43_232, array2);
			Class91.smethod_1(ref gstruct43_233, array2);
			Class91.smethod_1(ref gstruct43_234, array2);
			Class91.smethod_1(ref gstruct43_235, array2);
			Class91.smethod_1(ref gstruct43_94, array2);
			Class91.smethod_1(ref gstruct43_95, array2);
			Class91.smethod_1(ref gstruct43_96, array2);
			Class91.smethod_1(ref gstruct43_97, array2);
			Class91.smethod_1(ref gstruct43_98, array2);
			Class91.smethod_1(ref gstruct43_99, array2);
			Class91.smethod_1(ref gstruct43_102, array2);
			Class91.smethod_1(ref gstruct43_103, array2);
			Class91.smethod_1(ref gstruct43_104, array2);
			Class91.smethod_1(ref gstruct43_105, array2);
			Class91.smethod_1(ref gstruct43_106, array2);
			Class91.smethod_1(ref gstruct43_108, array2);
			Class91.smethod_1(ref gstruct43_109, array2);
			Class91.smethod_1(ref gstruct43_107, array2);
			Class91.smethod_1(ref gstruct43_110, array2);
			Class91.smethod_1(ref gstruct43_111, array2);
			Class91.smethod_1(ref gstruct43_112, array2);
			Class91.smethod_1(ref gstruct43_113, array2);
			Class91.smethod_1(ref gstruct43_115, array2);
			Class91.smethod_1(ref gstruct43_114, array2);
			Class91.smethod_1(ref gstruct43_116, array2);
			Class91.smethod_1(ref gstruct43_117, array2);
			Class91.smethod_1(ref gstruct43_118, array2);
			Class91.smethod_1(ref gstruct43_119, array2);
			Class91.smethod_1(ref gstruct43_120, array2);
			Class91.smethod_1(ref gstruct43_100, array2);
			Class91.smethod_1(ref gstruct43_101, array2);
			Class91.smethod_1(ref gstruct43_121, array2);
			Class91.smethod_1(ref gstruct43_122, array2);
			Class91.smethod_1(ref gstruct43_123, array2);
			Class91.smethod_1(ref gstruct43_124, array2);
			Class91.smethod_1(ref gstruct43_125, array2);
			Class91.smethod_1(ref gstruct43_126, array2);
			Class91.smethod_1(ref gstruct43_127, array2);
			Class91.smethod_1(ref gstruct43_128, array2);
			Class91.smethod_1(ref gstruct43_129, array2);
			Class91.smethod_1(ref gstruct43_130, array2);
			Class91.smethod_1(ref gstruct43_131, array2);
			Class91.smethod_1(ref gstruct43_132, array2);
			Class91.smethod_1(ref gstruct43_133, array2);
			Class91.smethod_1(ref gstruct43_134, array2);
			Class91.smethod_1(ref gstruct43_135, array2);
			Class91.smethod_1(ref gstruct43_136, array2);
			Class91.smethod_1(ref gstruct43_137, array2);
			Class91.smethod_1(ref gstruct43_138, array2);
			Class91.smethod_1(ref gstruct43_139, array2);
			Class91.smethod_1(ref gstruct43_141, array2);
			Class91.smethod_1(ref gstruct43_140, array2);
			Class91.smethod_1(ref gstruct43_142, array2);
			Class91.smethod_1(ref gstruct43_143, array2);
			Class91.smethod_1(ref gstruct43_144, array2);
			Class91.smethod_1(ref gstruct43_145, array2);
			Class91.smethod_1(ref gstruct43_146, array2);
			Class91.smethod_1(ref gstruct43_147, array2);
			Class91.smethod_1(ref gstruct43_149, array2);
			Class91.smethod_1(ref gstruct43_151, array2);
			Class91.smethod_1(ref gstruct43_150, array2);
			Class91.smethod_1(ref gstruct43_148, array2);
			Class91.smethod_1(ref gstruct43_152, array2);
			Class91.smethod_1(ref gstruct43_153, array2);
			Class91.smethod_1(ref gstruct43_154, array2);
			Class91.smethod_1(ref gstruct43_155, array2);
			Class91.smethod_1(ref gstruct43_156, array2);
			Class91.smethod_1(ref gstruct43_68, array2);
			Class91.smethod_1(ref gstruct43_71, array2);
			Class91.smethod_1(ref gstruct43_70, array2);
			Class91.smethod_1(ref gstruct43_67, array2);
			Class91.smethod_1(ref gstruct43_69, array2);
			Class91.smethod_1(ref gstruct43_157, array2);
			Class91.smethod_1(ref gstruct43_159, array2);
			Class91.smethod_1(ref gstruct43_158, array2);
			Class91.smethod_1(ref gstruct43_160, array2);
			Class91.smethod_1(ref gstruct43_161, array2);
			Class91.smethod_1(ref gstruct43_162, array2);
			Class91.smethod_1(ref gstruct43_163, array2);
			Class91.smethod_1(ref gstruct43_164, array2);
			Class91.smethod_1(ref gstruct43_165, array2);
			Class91.smethod_1(ref gstruct43_167, array2);
			Class91.smethod_1(ref gstruct43_168, array2);
			Class91.smethod_1(ref gstruct43_169, array2);
			Class91.smethod_1(ref gstruct43_170, array2);
			Class91.smethod_1(ref gstruct43_171, array2);
			Class91.smethod_1(ref gstruct43_172, array2);
			Class91.smethod_1(ref gstruct43_174, array2);
			Class91.smethod_1(ref gstruct43_175, array2);
			Class91.smethod_1(ref gstruct43_176, array2);
			Class91.smethod_1(ref gstruct43_177, array2);
			Class91.smethod_1(ref gstruct43_178, array2);
			Class91.smethod_1(ref gstruct43_179, array2);
			Class91.smethod_1(ref gstruct43_180, array2);
			Class91.smethod_1(ref gstruct43_181, array2);
			Class91.smethod_1(ref gstruct43_182, array2);
			Class91.smethod_1(ref gstruct43_183, array2);
			Class91.smethod_1(ref gstruct43_173, array2);
			Class91.smethod_1(ref gstruct43_227, array2);
			Class91.smethod_1(ref gstruct43_238, array2);
			Class91.smethod_1(ref gstruct43_239, array2);
			Class91.smethod_1(ref gstruct43_240, array2);
			Class91.smethod_1(ref gstruct43_184, array2);
			Class91.smethod_1(ref gstruct43_86, array2);
			Class91.smethod_1(ref gstruct43_185, array2);
			Class91.smethod_1(ref gstruct43_85, array2);
			Class91.smethod_1(ref gstruct43_186, array2);
			Class91.smethod_1(ref gstruct43_187, array2);
			Class91.smethod_1(ref gstruct43_188, array2);
			Class91.smethod_1(ref gstruct43_192, array2);
			Class91.smethod_1(ref gstruct43_189, array2);
			Class91.smethod_1(ref gstruct43_190, array2);
			Class91.smethod_1(ref gstruct43_191, array2);
			Class91.smethod_1(ref gstruct43_196, array2);
			Class91.smethod_1(ref gstruct43_197, array2);
			Class91.smethod_1(ref gstruct43_198, array2);
			Class91.smethod_1(ref gstruct43_199, array2);
			Class91.smethod_1(ref gstruct43_200, array2);
			Class91.smethod_1(ref gstruct43_201, array2);
			Class91.smethod_1(ref gstruct43_215, array2);
			Class91.smethod_1(ref gstruct43_221, array2);
			Class91.smethod_1(ref gstruct43_222, array2);
			Class91.smethod_1(ref gstruct43_223, array2);
			Class91.smethod_1(ref gstruct43_224, array2);
			Class91.smethod_1(ref gstruct43_226, array2);
			Class91.smethod_1(ref gstruct43_225, array2);
			Class91.smethod_1(ref gstruct43_202, array2);
			Class91.smethod_1(ref gstruct43_203, array2);
			Class91.smethod_1(ref gstruct43_204, array2);
			Class91.smethod_1(ref gstruct43_205, array2);
			Class91.smethod_1(ref gstruct43_206, array2);
			Class91.smethod_1(ref gstruct43_207, array2);
			Class91.smethod_1(ref gstruct43_208, array2);
			Class91.smethod_1(ref gstruct43_209, array2);
			Class91.smethod_1(ref gstruct43_210, array2);
			Class91.smethod_1(ref gstruct43_211, array2);
			Class91.smethod_1(ref gstruct43_220, array2);
			Class91.smethod_1(ref gstruct43_219, array2);
			Class91.smethod_1(ref gstruct43_216, array2);
			Class91.smethod_1(ref gstruct43_212, array2);
			Class91.smethod_1(ref gstruct43_213, array2);
			Class91.smethod_1(ref gstruct43_214, array2);
			Class91.smethod_1(ref gstruct43_217, array2);
			Class91.smethod_1(ref gstruct43_218, array2);
			Class91.smethod_1(ref gstruct43_241, array2);
			Class91.smethod_1(ref gstruct43_242, array2);
			Class91.smethod_1(ref gstruct43_243, array2);
			GStruct43[] gstruct43_ = smethod_2();
			bool_0 = (smethod_3(gstruct43_, ref string_66, ref string_67) == 0);
			bool_1 = true;
			return bool_0;
		}
		bool_0 = false;
		bool_1 = true;
		string_66 = "0";
		string_67 = "Chưa có dữ liệu data game.";
		return false;
	}

	public static GStruct42 smethod_7(int int_10)
	{
		GStruct42 gstruct42_ = default(GStruct42);
		gstruct42_.int_129 = 0;
		gstruct42_.uint_11 = 0u;
		gstruct42_.uint_12 = 0u;
		gstruct42_.gstruct39_0 = null;
		gstruct42_.bool_36 = false;
		if (bool_1 && bool_0)
		{
			try
			{
				gstruct42_.process_0 = Process.GetProcessById(int_10);
				gstruct42_.uint_6 = (uint)(int)gstruct42_.process_0.MainModule.BaseAddress;
				uint[] array = Class20.smethod_61(int_10, "engine.dll|lualibdll.dll");
				gstruct42_.uint_7 = array[0];
				gstruct42_.uint_8 = array[1];
			}
			catch
			{
				Class11.smethod_24(ref Class11.string_14, "Khởi tạo game thất bại.");
				return gstruct42_;
			}
			gstruct42_.int_130 = Class20.OpenProcess(2035711, bool_0: false, int_10);
			gstruct42_.string_20 = Class32.smethod_4(gstruct42_);
			gstruct42_.string_18 = Class23.smethod_3(gstruct42_);
			gstruct42_.string_19 = Class23.smethod_1(gstruct42_);
			gstruct42_.int_128 = 500;
			GStruct7[] array2 = Class20.smethod_62(int_10, "WIN_CLASS:" + string_17);
			if (array2 != null && array2.Length > 0)
			{
				gstruct42_.uint_4 = array2[0].uint_0;
			}
			gstruct42_.uint_12 = 0u;
			gstruct42_.uint_11 = Class20.smethod_1(gstruct42_.int_130, Class60.uint_0 + 12288);
			if (gstruct42_.uint_11 == 0)
			{
				return gstruct42_;
			}
			gstruct42_.uint_16 = 0u;
			gstruct42_.uint_15 = Class20.smethod_1(gstruct42_.int_130, 4096u);
			if (gstruct42_.uint_15 == 0)
			{
				return gstruct42_;
			}
			gstruct42_.uint_10 = Class20.smethod_1(gstruct42_.int_130, 768u);
			gstruct42_.uint_9 = Class20.smethod_1(gstruct42_.int_130);
			gstruct42_.uint_13 = Class20.smethod_1(gstruct42_.int_130, 256u);
			gstruct42_.int_129 = int_10 * Convert.ToByte(gstruct42_.uint_6 != 0 && gstruct42_.uint_11 != 0 && gstruct42_.uint_4 != 0);
			if (gstruct42_.int_129 == 0)
			{
				return gstruct42_;
			}
			gstruct42_.uint_14 = Class20.smethod_1(gstruct42_.int_130, 4096u);
			Class60.smethod_8(ref gstruct42_);
			smethod_8(ref gstruct42_);
			Class66.long_0 = 0L;
			return gstruct42_;
		}
		return gstruct42_;
	}

	public static void smethod_8(ref GStruct42 gstruct42_0, string string_70 = null)
	{
		if (string_70 == null || string_70 == string.Empty)
		{
			string_70 = string_6 + "\\" + Class11.smethod_39(gstruct42_0.string_20) + ".cfg";
		}
		string[] array = null;
		string text = Class11.smethod_28(string_70, 0, 0, 3);
		if (text != null && text != string.Empty)
		{
			array = text.Split('|');
		}
		gstruct42_0.bool_33 = false;
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.Length; i++)
			{
				if (gstruct42_0.string_20 == string_2[i])
				{
					gstruct42_0.bool_33 = true;
					break;
				}
			}
		}
		string[] array2 = smethod_19(array, "AscBomThuoc", null);
		if (array2 != null && array2.Length > 0)
		{
			array2[0] = Class11.smethod_16(array2[0]);
			if (array2[0] != string.Empty && array2[0] != null)
			{
				string[] array3 = array2[0].Split('|');
				gstruct42_0.gstruct39_0 = new GStruct39[array3.Length];
				for (int i = 0; i < array3.Length; i++)
				{
					string[] array4 = array3[i].Split(':');
					gstruct42_0.gstruct39_0[i].int_0 = Class11.smethod_12(array4[0]);
					string[] array5 = array4[1].Split('/');
					gstruct42_0.gstruct39_0[i].gstruct37_0 = new GStruct37[array5.Length];
					for (int j = 0; j < array5.Length; j++)
					{
						string[] array6 = array5[j].Split('=');
						gstruct42_0.gstruct39_0[i].gstruct37_0[j].int_0 = Class11.smethod_12(array6[0]);
						gstruct42_0.gstruct39_0[i].gstruct37_0[j].string_0 = array6[1];
					}
				}
			}
		}
		gstruct42_0.string_13 = string.Empty;
		string[] array7 = smethod_19(array, "PassRuong", null);
		if (array7 != null && array7.Length > 0)
		{
			gstruct42_0.string_13 = Class11.smethod_16(array7[0]);
		}
		string[] string_71 = array;
		int[] int_ = new int[1];
		gstruct42_0.int_38 = smethod_17(string_71, "flagNhatdos", int_)[0];
		string[] string_72 = array;
		int_ = new int[1];
		gstruct42_0.int_39 = smethod_17(string_72, "flagXepdo", int_)[0];
		gstruct42_0.int_40 = smethod_17(array, "TimerXepdo", new int[1]
		{
			15000
		})[0];
		string[] string_73 = array;
		int_ = new int[1];
		gstruct42_0.int_41 = smethod_17(string_73, "flagNhatTrongthanh", int_)[0];
		string[] string_74 = array;
		int_ = new int[1];
		gstruct42_0.int_42 = smethod_17(string_74, "flagNhatTheoThuoctinh", int_)[0];
		string[] string_75 = array;
		int_ = new int[1];
		gstruct42_0.int_43 = smethod_17(string_75, "flagThoahetThuoctinh", int_)[0];
		gstruct42_0.int_44 = smethod_17(array, "flagKhongNhatdoTim", new int[1]
		{
			1
		})[0];
		string[] string_76 = array;
		int_ = new int[2];
		gstruct42_0.int_45 = smethod_17(string_76, "GiuNhan", int_);
		string[] string_77 = array;
		int_ = new int[2];
		gstruct42_0.int_46 = smethod_17(string_77, "GiuDC", int_);
		string[] string_78 = array;
		int_ = new int[2];
		gstruct42_0.int_47 = smethod_17(string_78, "GiuNB", int_);
		gstruct42_0.int_53 = smethod_17(array, "flagPhamviNhatdo", new int[1]
		{
			1
		})[0];
		gstruct42_0.int_54 = smethod_17(array, "PhamviNhatdo", new int[1]
		{
			600
		})[0];
		gstruct42_0.int_55 = smethod_17(array, "RuongCatdo", new int[5]
		{
			1,
			0,
			0,
			0,
			0
		});
		gstruct42_0.string_4 = null;
		string[] array8 = smethod_19(array, "tbKeepItem", null);
		if (array8 != null && array8.Length > 0)
		{
			array8[0] = Class11.smethod_16(array8[0]);
			if (array8[0] != string.Empty && array8[0] != null)
			{
				gstruct42_0.string_4 = array8[0].Split('|');
			}
		}
		gstruct42_0.int_2 = 0;
		string[] string_79 = array;
		int_ = new int[1];
		gstruct42_0.int_56 = smethod_17(string_79, "Luomrac", int_)[0];
		string[] string_80 = array;
		int_ = new int[1];
		gstruct42_0.int_57 = smethod_17(string_80, "LuomracAccept", int_)[0];
		string[] string_81 = array;
		int_ = new int[1];
		gstruct42_0.int_58 = smethod_17(string_81, "LuomracThuoctinh", int_)[0];
		string[] string_82 = array;
		int_ = new int[2];
		gstruct42_0.int_48 = smethod_17(string_82, "flagVeBando", int_);
		gstruct42_0.int_49 = smethod_17(array, "GiudoTheoCap", new int[2]
		{
			0,
			9
		});
		string[] string_83 = array;
		int_ = new int[2];
		gstruct42_0.int_50 = smethod_17(string_83, "GiudoTheoHe", int_);
		string[] string_84 = array;
		int_ = new int[1];
		gstruct42_0.int_51 = smethod_17(string_84, "GiudoTim", int_)[0];
		string[] string_85 = array;
		int_ = new int[1];
		gstruct42_0.int_52 = smethod_17(string_85, "GiudoTheoThuoctinh", int_)[0];
		gstruct42_0.gstruct33_0 = smethod_1();
		int[] array9 = smethod_17(array, "tbFlagItemMagic", null);
		int[] array10 = smethod_17(array, "tbValueItemMagic", null);
		int[] array11 = smethod_17(array, "tbValueDong", null);
		if (array9 != null && array9.Length == gstruct42_0.gstruct33_0.Length && array10 != null && array10.Length == gstruct42_0.gstruct33_0.Length)
		{
			for (int i = 0; i < gstruct42_0.gstruct33_0.Length; i++)
			{
				gstruct42_0.gstruct33_0[i].int_0 = array9[i];
				gstruct42_0.gstruct33_0[i].int_2 = array10[i];
			}
		}
		if (array11 != null && array11.Length == gstruct42_0.gstruct33_0.Length)
		{
			for (int i = 0; i < gstruct42_0.gstruct33_0.Length; i++)
			{
				gstruct42_0.gstruct33_0[i].int_3 = array11[i];
			}
		}
		gstruct42_0.int_19 = smethod_17(array, "SinhlucThoat", new int[1]
		{
			200
		})[0];
		string[] string_86 = array;
		int_ = new int[1];
		gstruct42_0.int_20 = smethod_17(string_86, "flagSinhlucThoat", int_)[0];
		string[] string_87 = array;
		int_ = new int[2];
		gstruct42_0.int_62 = smethod_17(string_87, "TDPKhiHetruong", int_);
		gstruct42_0.int_59 = smethod_17(array, "flagTranhBossvang", new int[1]
		{
			1
		})[0];
		string[] string_88 = array;
		int_ = new int[1];
		gstruct42_0.int_60 = smethod_17(string_88, "AnTTL", int_)[0];
		gstruct42_0.int_61 = smethod_17(array, "TDPKhiSaiMap", new int[1]
		{
			1
		})[0];
		gstruct42_0.int_63 = smethod_17(array, "flagNhatdoIndex", new int[1]
		{
			1
		})[0];
		string[] string_89 = array;
		int_ = new int[1];
		gstruct42_0.int_64 = smethod_17(string_89, "flagCanThuocLag", int_)[0];
		gstruct42_0.int_65 = smethod_17(array, "fThuocTocdo", new int[3]
		{
			0,
			0,
			3
		});
		gstruct42_0.string_6 = null;
		string[] array12 = smethod_19(array, "ThuocTocdoDanh", null);
		if (array12 != null && array12.Length > 0)
		{
			array12[0] = Class11.smethod_16(array12[0]);
			if (array12[0] != string.Empty && array12[0] != null)
			{
				gstruct42_0.string_6 = array12[0].Split('|');
			}
		}
		gstruct42_0.string_5 = null;
		array12 = smethod_19(array, "tbThuocLag", null);
		if (array12 != null && array12.Length > 0)
		{
			array12[0] = Class11.smethod_16(array12[0]);
			if (array12[0] != string.Empty && array12[0] != null)
			{
				gstruct42_0.string_5 = array12[0].Split('|');
			}
		}
		if (gstruct42_0.string_5 == null)
		{
			string text2 = "L«i Phßng hoµn|Tr­êng MÖnh hoµn|Gia Bµo hoµn|Cao Trung hoµn|§éc Phßng hoµn|Cao ThiÓm hoµn|Háa Phßng hoµn|Gia Bµo hoµn|B\u00a8ng Phßng hoµn|Háa Phßng hoµn|B\u00b8ch Qu¶ Lé|Thiªn s¬n  B¶o Lé|Thiªn s¬n B¶o Lé";
			gstruct42_0.string_5 = text2.Split('|');
		}
		gstruct42_0.string_3 = null;
		array12 = smethod_19(array, "IBadlist", null);
		if (array12 != null && array12.Length > 0)
		{
			array12[0] = Class11.smethod_16(array12[0]);
			if (array12[0] != string.Empty && array12[0] != null)
			{
				gstruct42_0.string_3 = array12[0].Split('|');
			}
		}
		if (gstruct42_0.string_3 == null)
		{
			gstruct42_0.string_3 = new string[4]
			{
				"Th­ëng",
				"Ph¹t",
				"ThÇn bÝ ®å chÝ",
				"§Æc Th\u00b8m B¶o R­¬ng"
			};
		}
		gstruct42_0.int_66 = smethod_17(array, "flagTienMangtheo", new int[1]
		{
			1
		})[0];
		gstruct42_0.int_67 = smethod_17(array, "TienMangtheo", new int[1]
		{
			15000
		})[0];
		gstruct42_0.int_68 = smethod_17(array, "TheoSau", new int[3]
		{
			0,
			200,
			0
		});
		gstruct42_0.string_7 = string.Empty;
		array12 = smethod_19(array, "NameTheoSau", null);
		if (array12 != null && array12.Length > 0)
		{
			gstruct42_0.string_7 = Class11.smethod_16(array12[0]);
		}
		string[] string_90 = array;
		int_ = new int[2];
		gstruct42_0.int_131 = smethod_17(string_90, "GanChieuTrai", int_);
		string[] string_91 = array;
		int_ = new int[2];
		gstruct42_0.int_132 = smethod_17(string_91, "GanChieuPhai", int_);
		gstruct42_0.int_133 = smethod_17(array, "tbSwitchLeft1", new int[3]
		{
			0,
			0,
			600
		});
		gstruct42_0.int_134 = smethod_17(array, "tbSwitchLeft2", new int[3]
		{
			0,
			0,
			600
		});
		gstruct42_0.int_135 = smethod_17(array, "tbSwitchLeft3", new int[3]
		{
			0,
			0,
			600
		});
		gstruct42_0.int_136 = smethod_17(array, "tbSwitchRight1", new int[3]
		{
			0,
			0,
			600
		});
		gstruct42_0.int_137 = smethod_17(array, "tbSwitchRight2", new int[3]
		{
			0,
			0,
			600
		});
		gstruct42_0.int_138 = smethod_17(array, "tbSwitchRight3", new int[3]
		{
			0,
			0,
			600
		});
		gstruct42_0.int_139 = smethod_17(array, "Tran1Phai", new int[3]
		{
			0,
			10000,
			90000
		});
		gstruct42_0.int_140 = smethod_17(array, "Tran2Phai", new int[3]
		{
			0,
			10000,
			80000
		});
		gstruct42_0.int_141 = smethod_17(array, "Tran3Phai", new int[3]
		{
			0,
			10000,
			70000
		});
		if (gstruct42_0.int_139[1] == 10000 || gstruct42_0.int_140[1] == 10000 || gstruct42_0.int_141[1] == 10000)
		{
			gstruct42_0.int_139[1] = 0;
			gstruct42_0.int_140[1] = 0;
			gstruct42_0.int_141[1] = 0;
			int[] array13 = Class67.smethod_0(gstruct42_0);
			if (array13 != null)
			{
				if (array13.Length > 0)
				{
					gstruct42_0.int_139[0] = Convert.ToByte(Class67.smethod_15(gstruct42_0, (uint)array13[0]) > 0);
					gstruct42_0.int_139[1] = array13[0];
				}
				if (array13.Length > 1)
				{
					gstruct42_0.int_140[0] = Convert.ToByte(Class67.smethod_15(gstruct42_0, (uint)array13[1]) > 0);
					gstruct42_0.int_140[1] = array13[1];
				}
				if (array13.Length > 2)
				{
					gstruct42_0.int_141[0] = Convert.ToByte(Class67.smethod_15(gstruct42_0, (uint)array13[2]) > 0);
					gstruct42_0.int_141[1] = array13[2];
				}
			}
		}
		gstruct42_0.string_8 = "(gz)Tuyen nguoi vao bang tai Le Quan ba lang huyen !";
		string[] array14 = smethod_19(array, "tRaovat", null);
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_8 = array14[0];
			}
		}
		gstruct42_0.int_69 = smethod_17(array, "fRao", new int[5]
		{
			0,
			0,
			30000,
			0,
			1
		});
		gstruct42_0.int_125 = smethod_17(array, "Nhqua", new int[6]
		{
			0,
			1,
			12,
			5,
			0,
			200
		});
		gstruct42_0.int_126 = smethod_17(array, "BosST", new int[5]
		{
			0,
			0,
			80,
			0,
			0
		});
		string[] string_92 = array;
		int_ = new int[1];
		gstruct42_0.int_127 = smethod_17(string_92, "STHaucan", int_)[0];
		string[] string_93 = array;
		int_ = new int[5];
		gstruct42_0.int_121 = smethod_17(string_93, "DameChieu12", int_);
		string[] string_94 = array;
		int_ = new int[7];
		gstruct42_0.int_122 = smethod_17(string_94, "DMBoom", int_);
		string[] string_95 = array;
		int_ = new int[2];
		gstruct42_0.int_123 = smethod_17(string_95, "fQuangthuoc", int_);
		gstruct42_0.int_123[1] = 0;
		gstruct42_0.int_73 = smethod_17(array, "flagTuGiaidoc", new int[3]
		{
			0,
			4500,
			1
		});
		string[] string_96 = array;
		int_ = new int[1];
		gstruct42_0.int_77 = smethod_17(string_96, "RuongBH", int_)[0];
		gstruct42_0.int_75 = smethod_17(array, "ChThuoc", new int[5]
		{
			0,
			0,
			0,
			5,
			0
		});
		array14 = smethod_19(array, "fTenThuoc", null);
		gstruct42_0.string_12 = "Ngò Hoa Ngäc Lé Hoµn";
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_12 = array14[0];
			}
		}
		string[] string_97 = array;
		int_ = new int[1];
		gstruct42_0.int_76 = smethod_17(string_97, "MuaKTC", int_)[0];
		string[] string_98 = array;
		string[] string_99 = new string[3];
		array14 = smethod_19(string_98, "tbKTCTabName", string_99);
		gstruct42_0.int_70 = smethod_17(array, "flagMuaThuocHP", new int[3]
		{
			0,
			0,
			40
		});
		gstruct42_0.string_9 = "Ngò Hoa Ngäc Lé Hoµn";
		array14 = smethod_19(array, "TenHP", null);
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_9 = array14[0];
			}
		}
		gstruct42_0.int_71 = smethod_17(array, "flagMuaThuocMP", new int[3]
		{
			0,
			0,
			15
		});
		gstruct42_0.string_10 = "¤ ®Çu Hoµn thÇn ®an";
		array14 = smethod_19(array, "TenMP", null);
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_10 = array14[0];
			}
		}
		gstruct42_0.int_72 = smethod_17(array, "flagMuaGiaiDoc", new int[3]
		{
			0,
			0,
			10
		});
		gstruct42_0.string_11 = "Ng©n KiÒu Khø ®éc ®an";
		array14 = smethod_19(array, "TenGiaiDoc", null);
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_11 = array14[0];
			}
		}
		gstruct42_0.int_74 = smethod_17(array, "GanTenthuoc", new int[5]
		{
			0,
			2,
			0,
			0,
			0
		});
		gstruct42_0.int_89 = smethod_17(array, "flagDoiPk", new int[1]
		{
			1
		})[0];
		gstruct42_0.int_90 = smethod_17(array, "flagXuongngua", new int[1]
		{
			1
		})[0];
		string[] string_100 = array;
		int_ = new int[1];
		gstruct42_0.int_91 = smethod_17(string_100, "ChetNamIm", int_)[0];
		string[] string_101 = array;
		int_ = new int[1];
		gstruct42_0.int_96 = smethod_17(string_101, "flagDanhphim", int_)[0];
		string[] string_102 = array;
		int_ = new int[1];
		gstruct42_0.int_116 = smethod_17(string_102, "flagTuCastBua", int_)[0];
		string[] string_103 = array;
		int_ = new int[1];
		gstruct42_0.int_99 = smethod_17(string_103, "flagTuPT", int_)[0];
		gstruct42_0.int_92 = smethod_17(array, "flagTiepcanF", new int[1]
		{
			1
		})[0];
		gstruct42_0.int_93 = smethod_17(array, "ValueTiepcan", new int[1]
		{
			512
		})[0];
		gstruct42_0.int_94 = smethod_17(array, "flagTamQuet_", new int[1]
		{
			1
		})[0];
		gstruct42_0.int_95 = smethod_17(array, "ValueTamQuet_s", new int[1]
		{
			550
		})[0];
		gstruct42_0.int_100 = smethod_17(array, "TDPKhiPk", new int[2]
		{
			1,
			9
		});
		string[] string_104 = array;
		int_ = new int[1];
		gstruct42_0.int_101 = smethod_17(string_104, "flagTuChayMuaThuocHoaSon", int_)[0];
		string[] string_105 = array;
		int_ = new int[1];
		gstruct42_0.int_102 = smethod_17(string_105, "flagHoason500l", int_)[0];
		string[] string_106 = array;
		int_ = new int[1];
		gstruct42_0.int_11 = smethod_17(string_106, "flagBanEvent", int_)[0];
		int num = 0;
		array12 = smethod_19(array, "tbMoThuoc", null);
		if (array12 != null && array12.Length > 0)
		{
			string text3 = Class11.smethod_16(array12[0]);
			if (array12[0] != string.Empty && array12[0] != null)
			{
				string[] array15 = text3.Split('|');
				GStruct30[] array16 = new GStruct30[array15.Length];
				for (int i = 0; i < array16.Length; i++)
				{
					string text4 = array15[i];
					if (text4 == null || text4 == string.Empty)
					{
						continue;
					}
					string[] array17 = text4.Split('\u0001');
					if (array17.Length < 8)
					{
						continue;
					}
					array16[num].string_0 = array17[0];
					array16[num].int_6 = Class11.smethod_12(array17[1]);
					array16[num].int_0 = Class11.smethod_12(array17[2]);
					array16[num].int_5 = Class11.smethod_12(array17[3]);
					array16[num].int_8 = new int[2]
					{
						1,
						1
					};
					string[] array18 = array17[4].Split('_');
					if (array18 != null)
					{
						array16[num].int_8 = new int[array18.Length];
						for (int k = 0; k < array18.Length; k++)
						{
							array16[num].int_8[k] = Class11.smethod_12(array18[k]);
						}
					}
					array16[num].int_3 = Class11.smethod_12(array17[5]);
					array16[num].int_4 = Class11.smethod_12(array17[6]);
					array16[num].int_7 = Class11.smethod_12(array17[7]);
					if (array17.Length > 8)
					{
						array16[num].int_1 = Class11.smethod_12(array17[8]);
					}
					if (array17.Length > 9)
					{
						array16[num].int_2 = Class11.smethod_12(array17[9]);
					}
					num++;
				}
				if (num > 0)
				{
					gstruct42_0.gstruct30_0 = new GStruct30[num];
					for (int i = 0; i < num; i++)
					{
						gstruct42_0.gstruct30_0[i].string_0 = array16[i].string_0;
						gstruct42_0.gstruct30_0[i].int_6 = array16[i].int_6;
						gstruct42_0.gstruct30_0[i].int_0 = array16[i].int_0;
						gstruct42_0.gstruct30_0[i].int_5 = array16[i].int_5;
						gstruct42_0.gstruct30_0[i].int_8 = new int[2]
						{
							1,
							1
						};
						if (array16[i].int_8 != null)
						{
							gstruct42_0.gstruct30_0[i].int_8 = new int[array16[i].int_8.Length];
							for (int k = 0; k < array16[i].int_8.Length; k++)
							{
								gstruct42_0.gstruct30_0[i].int_8[k] = array16[i].int_8[k];
							}
						}
						gstruct42_0.gstruct30_0[i].int_3 = array16[i].int_3;
						gstruct42_0.gstruct30_0[i].int_4 = array16[i].int_4;
						gstruct42_0.gstruct30_0[i].int_7 = array16[i].int_7;
						gstruct42_0.gstruct30_0[i].int_1 = array16[i].int_1;
						gstruct42_0.gstruct30_0[i].int_2 = array16[i].int_2;
					}
				}
			}
		}
		if (num == 0)
		{
			gstruct42_0.gstruct30_0 = new GStruct30[1]
			{
				new GStruct30
				{
					string_0 = "Håi thiªn t\u00b8i t¹o lÔ bao",
					int_0 = 0,
					int_1 = 0,
					int_2 = 0,
					int_3 = 60000,
					int_4 = 0,
					int_5 = 5,
					int_6 = 0,
					int_7 = 0,
					int_8 = new int[2]
					{
						1,
						1
					}
				}
			};
		}
		gstruct42_0.int_97 = smethod_17(array, "fNgamyBuff", new int[8]
		{
			0,
			0,
			0,
			101,
			800,
			400,
			0,
			0
		});
		gstruct42_0.int_103 = smethod_17(array, "BomHPDiem", new int[4]
		{
			0,
			1000,
			1500,
			1
		});
		gstruct42_0.int_104 = smethod_17(array, "BomMPDiem", new int[4]
		{
			0,
			200,
			2500,
			1
		});
		gstruct42_0.int_106 = smethod_17(array, "BomHPRatio", new int[4]
		{
			1,
			85,
			1500,
			1
		});
		gstruct42_0.int_107 = smethod_17(array, "BomM2HPRatio", new int[4]
		{
			1,
			75,
			1500,
			1
		});
		gstruct42_0.int_108 = smethod_17(array, "BomMPRatio", new int[4]
		{
			1,
			25,
			2500,
			1
		});
		gstruct42_0.int_109 = smethod_17(array, "BomM2MPRatio", new int[4]
		{
			0,
			0,
			1500,
			1
		});
		string[] string_107 = array;
		int_ = new int[1];
		gstruct42_0.int_105 = smethod_17(string_107, "flagUuTienBomCuuChuyen", int_)[0];
		gstruct42_0.int_110 = smethod_17(array, "HPTdp", new int[2]
		{
			0,
			40
		});
		gstruct42_0.int_111 = smethod_17(array, "MPTdp", new int[2]
		{
			0,
			30
		});
		string[] string_108 = array;
		int_ = new int[1];
		gstruct42_0.int_112 = smethod_17(string_108, "flagTDPKhiSoluongMau", int_)[0];
		string[] string_109 = array;
		int_ = new int[1];
		gstruct42_0.int_113 = smethod_17(string_109, "TDPSoluongMauConlai", int_)[0];
		string[] string_110 = array;
		int_ = new int[1];
		gstruct42_0.int_114 = smethod_17(string_110, "flagTDPKhiSoluongMana", int_)[0];
		string[] string_111 = array;
		int_ = new int[1];
		gstruct42_0.int_115 = smethod_17(string_111, "TDPSoluongManaConlai", int_)[0];
		gstruct42_0.string_14 = "Ngò Hoa Ngäc Lé Hoµn";
		gstruct42_0.string_15 = "¤ ®Çu Hoµn thÇn ®an";
		array14 = smethod_19(array, "TenMauMuc2", null);
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_14 = array14[0];
			}
		}
		array14 = smethod_19(array, "TenManaMuc2", null);
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_15 = array14[0];
			}
		}
		gstruct42_0.string_16 = null;
		array12 = smethod_19(array, "DanhsachCuusat", null);
		if (array12 != null && array12.Length > 0)
		{
			array12[0] = Class11.smethod_16(array12[0]);
			if (array12[0] != string.Empty && array12[0] != null)
			{
				gstruct42_0.string_16 = array12[0].Split('|');
			}
		}
		string[] string_112 = array;
		int_ = new int[1];
		gstruct42_0.int_117 = smethod_17(string_112, "flagCuusatTheodanhsach", int_)[0];
		gstruct42_0.string_17 = null;
		array14 = smethod_19(array, "PTDanhsach", null);
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_17 = array14[0].Split('|');
			}
		}
		string[] string_113 = array;
		int_ = new int[5];
		gstruct42_0.int_120 = smethod_17(string_113, "fDenToado", int_);
		gstruct42_0.int_119 = new int[3]
		{
			gstruct42_0.int_120[2],
			gstruct42_0.int_120[3],
			gstruct42_0.int_120[4]
		};
		string[] string_114 = array;
		int_ = new int[5];
		gstruct42_0.int_118 = smethod_17(string_114, "PTflag", int_);
		gstruct42_0.int_87 = smethod_17(array, "GiamCpuLevel", new int[1]
		{
			1
		})[0];
		gstruct42_0.int_1 = smethod_17(array, "fBaoBoss", new int[1]
		{
			1
		})[0];
		int int_2 = Class32.smethod_28(gstruct42_0);
		string[] string_115 = array;
		int_ = new int[1];
		gstruct42_0.int_86 = smethod_17(string_115, "KieuDanh", int_)[0];
		gstruct42_0.int_88 = smethod_17(array, "tbNguhanh", smethod_12(int_2));
		gstruct42_0.string_21 = Class67.smethod_18(gstruct42_0);
		gstruct42_0.int_3 = null;
		gstruct42_0.int_4 = null;
		int[] array19 = smethod_17(array, "tbValueMagic", null);
		if (gstruct42_0.string_21 == "NGUDOC" || gstruct42_0.string_21 == "THIENNHAN" || gstruct42_0.string_21 == "CONLON")
		{
			gstruct42_0.int_4 = smethod_15(gstruct42_0.string_21);
			if (array19 != null)
			{
				int num2 = 0;
				int[] array20 = new int[array19.Length];
				for (int i = 0; i < array20.Length; i++)
				{
					if (array19[i] > 0 && Class67.smethod_15(gstruct42_0, (uint)array19[i]) > 0)
					{
						array20[num2] = array19[i];
						num2++;
					}
				}
				if (num2 > 0)
				{
					if (num2 > 4)
					{
						num2 = 4;
					}
					gstruct42_0.int_3 = new int[num2];
					for (int i = 0; i < num2; i++)
					{
						gstruct42_0.int_3[i] = array20[i];
					}
				}
			}
		}
		string[] string_116 = array;
		int_ = new int[1];
		gstruct42_0.int_5 = smethod_17(string_116, "flagBuffDoituong", int_)[0];
		string[] string_117 = array;
		int_ = new int[1];
		gstruct42_0.int_6 = smethod_17(string_117, "flagChiBuffKhongDanh", int_)[0];
		gstruct42_0.int_78 = Convert.ToByte(gstruct42_0.string_21 == "VODANG") * smethod_17(array, "flagTuGiaiBua", new int[1]
		{
			1
		})[0];
		gstruct42_0.int_79 = smethod_17(array, "flagGiaibuaBangsat", new int[1]
		{
			1
		})[0];
		string[] string_118 = array;
		int_ = new int[1];
		gstruct42_0.int_80 = smethod_17(string_118, "flagGiaibuaTheoThoigian", int_)[0];
		byte num3 = Convert.ToByte(gstruct42_0.string_21 == "THIENNHAN");
		string[] string_119 = array;
		int_ = new int[1];
		gstruct42_0.int_81 = num3 * smethod_17(string_119, "flagTNXuatChieu120", int_)[0];
		byte num4 = Convert.ToByte(gstruct42_0.string_21 == "CONLON");
		string[] string_120 = array;
		int_ = new int[1];
		gstruct42_0.int_82 = num4 * smethod_17(string_120, "flagConLon", int_)[0];
		gstruct42_0.int_83 = smethod_17(array, "TimerTuGiaibua", new int[1]
		{
			6500
		})[0];
		gstruct42_0.int_85 = smethod_17(array, "TimerTheoThoigian", new int[1]
		{
			28000
		})[0];
		gstruct42_0.int_84 = smethod_17(array, "TamBuffbua", new int[1]
		{
			440
		})[0];
		gstruct42_0.string_0 = "Tæng qu¶n ThÝ luyÖn ph­êng";
		array14 = smethod_19(array, "ClickNPCName", null);
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_0 = array14[0];
			}
		}
		gstruct42_0.int_7 = smethod_17(array, "ClickNPCSolan", new int[2]
		{
			0,
			3
		});
		gstruct42_0.int_9 = smethod_17(array, "ClickMenu", new int[4]
		{
			1,
			2,
			1,
			1
		});
		string[] string_121 = array;
		int_ = new int[1];
		gstruct42_0.int_8 = smethod_17(string_121, "flagClickMenu", int_)[0];
		gstruct42_0.int_10 = smethod_17(array, "ClickNPCTocdo", new int[1]
		{
			100
		})[0];
		string[] string_122 = array;
		int_ = new int[1];
		gstruct42_0.int_12 = smethod_17(string_122, "flagVatphamNpc", int_)[0];
		string[] string_123 = array;
		int_ = new int[1];
		gstruct42_0.int_14 = smethod_17(string_123, "flagClickNpcSau", int_)[0];
		gstruct42_0.int_13 = smethod_17(array, "MenuVatphamNpc", new int[2]
		{
			1,
			2
		});
		gstruct42_0.string_1 = "CÈm nang t©n thñ";
		array14 = smethod_19(array, "TenVatphamNpc", null);
		if (array14 != null && array14.Length > 0)
		{
			array14[0] = Class11.smethod_16(array14[0]);
			if (array14[0] != string.Empty && array14[0] != null)
			{
				gstruct42_0.string_1 = array14[0];
			}
		}
		string[] string_124 = array;
		int_ = new int[1];
		gstruct42_0.int_15 = smethod_17(string_124, "flagVatphamGiao1", int_)[0];
		string[] string_125 = array;
		int_ = new int[1];
		gstruct42_0.int_16 = smethod_17(string_125, "flagVatphamGiao2", int_)[0];
		string[] string_126 = array;
		int_ = new int[1];
		gstruct42_0.int_17 = smethod_17(string_126, "flagVatphamGiao3", int_)[0];
		string[] string_127 = array;
		int_ = new int[1];
		gstruct42_0.int_18 = smethod_17(string_127, "flagComuaVatphamNpc", int_)[0];
		string[] string_128 = array;
		int_ = new int[1];
		gstruct42_0.int_34 = smethod_17(string_128, "XulyDosat", int_)[0];
		string[] string_129 = array;
		int_ = new int[1];
		gstruct42_0.int_26 = smethod_17(string_129, "flagTrains", int_)[0];
		string[] string_130 = array;
		int_ = new int[1];
		gstruct42_0.int_27 = smethod_17(string_130, "flagTucheHT", int_)[0];
		gstruct42_0.int_28 = smethod_17(array, "DanhQuaiTrain", new int[1]
		{
			1
		})[0];
		string[] string_131 = array;
		int_ = new int[1];
		gstruct42_0.int_33 = smethod_17(string_131, "MapIDTrain", int_)[0];
		gstruct42_0.int_29 = smethod_17(array, "TDPHettien", new int[1]
		{
			1
		})[0];
		string[] string_132 = array;
		int_ = new int[1];
		gstruct42_0.int_30 = smethod_17(string_132, "ToadoVong", int_)[0];
		gstruct42_0.int_31 = smethod_17(array, "DanhTrenDuongdi", new int[1]
		{
			1
		})[0];
		string[] string_133 = array;
		int_ = new int[1];
		gstruct42_0.int_32 = smethod_17(string_133, "QuayQuai", int_)[0];
		array14 = smethod_19(array, "ToadoTrain", null);
		if (array14 != null && array14.Length > 0)
		{
			array14 = Class11.smethod_16(array14[0]).Split('|');
			int num2 = 0;
			uint[,] array21 = new uint[array14.Length, 2];
			for (int i = 0; i < array14.Length; i++)
			{
				string[] array22 = array14[i].Split(';');
				if (array22.Length > 1)
				{
					uint num5 = Class11.smethod_13(array22[0]);
					uint num6 = Class11.smethod_13(array22[1]);
					if (num5 != 0 && num6 != 0)
					{
						array21[num2, 0] = num5;
						array21[num2, 1] = num6;
						num2++;
					}
				}
			}
			if (num2 > 0)
			{
				gstruct42_0.uint_0 = new uint[num2, 2];
				for (int i = 0; i < num2; i++)
				{
					gstruct42_0.uint_0[i, 0] = array21[i, 0];
					gstruct42_0.uint_0[i, 1] = array21[i, 1];
				}
			}
		}
		string[] string_134 = array;
		int_ = new int[1];
		gstruct42_0.int_35 = smethod_17(string_134, "flagChayPkNguoidung", int_)[0];
		string[] string_135 = array;
		int_ = new int[2];
		gstruct42_0.int_21 = smethod_17(string_135, "fTinSu", int_);
		string[] string_136 = array;
		int_ = new int[1];
		gstruct42_0.int_36 = smethod_17(string_136, "MapIDPk1", int_)[0];
		string[] string_137 = array;
		int_ = new int[1];
		gstruct42_0.int_37 = smethod_17(string_137, "MapIDPk2", int_)[0];
		array14 = smethod_19(array, "ToadoPk1", null);
		if (array14 != null && array14.Length > 0)
		{
			array14 = Class11.smethod_16(array14[0]).Split('|');
			int num2 = 0;
			uint[,] array21 = new uint[array14.Length, 2];
			for (int i = 0; i < array14.Length; i++)
			{
				string[] array22 = array14[i].Split(';');
				if (array22.Length > 1)
				{
					uint num5 = Class11.smethod_13(array22[0]);
					uint num6 = Class11.smethod_13(array22[1]);
					if (num5 != 0 && num6 != 0)
					{
						array21[num2, 0] = num5;
						array21[num2, 1] = num6;
						num2++;
					}
				}
			}
			if (num2 > 0)
			{
				gstruct42_0.uint_2 = new uint[num2, 2];
				for (int i = 0; i < num2; i++)
				{
					gstruct42_0.uint_2[i, 0] = array21[i, 0];
					gstruct42_0.uint_2[i, 1] = array21[i, 1];
				}
			}
		}
		array14 = smethod_19(array, "ToadoPk2", null);
		if (array14 != null && array14.Length > 0)
		{
			array14 = Class11.smethod_16(array14[0]).Split('|');
			int num2 = 0;
			uint[,] array21 = new uint[array14.Length, 2];
			for (int i = 0; i < array14.Length; i++)
			{
				string[] array22 = array14[i].Split(';');
				if (array22.Length > 1)
				{
					uint num5 = Class11.smethod_13(array22[0]);
					uint num6 = Class11.smethod_13(array22[1]);
					if (num5 != 0 && num6 != 0)
					{
						array21[num2, 0] = num5;
						array21[num2, 1] = num6;
						num2++;
					}
				}
			}
			if (num2 > 0)
			{
				gstruct42_0.uint_3 = new uint[num2, 2];
				for (int i = 0; i < num2; i++)
				{
					gstruct42_0.uint_3[i, 0] = array21[i, 0];
					gstruct42_0.uint_3[i, 1] = array21[i, 1];
				}
			}
		}
		gstruct42_0.bool_9 = true;
		gstruct42_0.int_22 = 5;
		gstruct42_0.byte_0 = new byte[11];
	}

	public static void smethod_9(int int_10)
	{
		int num = 0;
		while (!Class11.bool_0 && int_7 > 0 && num < 10)
		{
			num++;
			Thread.Sleep(30);
		}
		try
		{
			int_7 = int_10;
			new Thread(smethod_10).Start();
		}
		catch
		{
		}
	}

	private static void smethod_10()
	{
		int num = int_7;
		int_7 = 0;
		int num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
		if (num2 >= 0)
		{
			FormMain.gstruct42_0[num2].bool_4 = true;
			GStruct42 gstruct42_ = FormMain.gstruct42_0[num2];
			string[] array = new string[15]
			{
				"-------------------------------------------",
				"<color=yellow>" + FormMain.string_1.ToUpper() + " - http://kimyen.net",
				"-------------------------------------------",
				"<color=green>+ PhÝm Ctrl + Z: Më r­¬ng",
				"<color=green>+ PhÝm Ctrl + X: Më t¹p ho\u00b8",
				"<color=green>+ PhÝm Ctrl + F: Qu\u00a8ng ®å",
				"<color=green>+ PhÝm Ctrl + G: Gép ®å",
				"<color=green>+ PhÝm Ctrl + K: Xãa SMS",
				"<color=green>+ PhÝm sè 1 ..9: Combo nhåi thuèc",
				"<color=yellow>+ PhÝm Ctrl + A: ChuyÓn ®å (theo size)",
				"<color=yellow>+ PhÝm Ctrl + S: ChuyÓn ®å (theo tªn)",
				"<color=green>+ PhÝm - vµ + : ChuyÒn thuèc r­¬ng Bang héi",
				"<color=green>+ PhÝm F7 - F8: BËt t¾t ®\u00b8nh qu\u00b8i - ng­êi",
				"<color=green>+ PhÝm F10: Gi¶m cÊu h×nh CPU (tab phô trî)",
				"<bclr=blue><color=green>Yªu cÇu: Stick sö dông phÝm t¾t (phô trî)"
			};
			for (int i = 0; i < array.Length; i++)
			{
				Class60.smethod_50(gstruct42_, array[i]);
				Thread.Sleep(80);
			}
			num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
			if (0 <= num2)
			{
				FormMain.gstruct42_0[num2].bool_4 = false;
				gstruct42_ = FormMain.gstruct42_0[num2];
				Class60.smethod_122(gstruct42_);
				Class58.smethod_1(gstruct42_);
				Class41.smethod_0(gstruct42_, gstruct42_.int_87);
				Class29.bool_0 = true;
			}
		}
	}

	public static void smethod_11(GStruct42 gstruct42_0, string string_70 = null)
	{
		string string_71 = null;
		smethod_16(ref string_71, "flagNhatdos", gstruct42_0.int_38);
		smethod_16(ref string_71, "flagXepdo", gstruct42_0.int_39);
		smethod_16(ref string_71, "TimerXepdo", gstruct42_0.int_40);
		smethod_16(ref string_71, "flagNhatTrongthanh", gstruct42_0.int_41);
		smethod_16(ref string_71, "flagNhatTheoThuoctinh", gstruct42_0.int_42);
		smethod_16(ref string_71, "flagThoahetThuoctinh", gstruct42_0.int_43);
		smethod_16(ref string_71, "flagKhongNhatdoTim", gstruct42_0.int_44);
		smethod_16(ref string_71, "GiuNhan", gstruct42_0.int_45);
		smethod_16(ref string_71, "GiuDC", gstruct42_0.int_46);
		smethod_16(ref string_71, "GiuNB", gstruct42_0.int_47);
		smethod_16(ref string_71, "flagPhamviNhatdo", gstruct42_0.int_53);
		smethod_16(ref string_71, "RuongCatdo", gstruct42_0.int_55);
		if (gstruct42_0.string_4 != null && gstruct42_0.string_4.Length > 0)
		{
			string text = null;
			for (int i = 0; i < gstruct42_0.string_4.Length; i++)
			{
				if (gstruct42_0.string_4[i] != null && gstruct42_0.string_4[i] != string.Empty)
				{
					if (text != null)
					{
						text += "|";
					}
					text += gstruct42_0.string_4[i];
				}
			}
			if (text != null)
			{
				string_71 = string_71 + "|tbKeepItem;" + Class11.smethod_17(text);
			}
		}
		smethod_16(ref string_71, "PhamviNhatdo", gstruct42_0.int_54);
		smethod_16(ref string_71, "flagVeBando", gstruct42_0.int_48);
		smethod_16(ref string_71, "GiudoTheoCap", gstruct42_0.int_49);
		smethod_16(ref string_71, "GiudoTheoHe", gstruct42_0.int_50);
		smethod_16(ref string_71, "GiudoTim", gstruct42_0.int_51);
		smethod_16(ref string_71, "GiudoTheoThuoctinh", gstruct42_0.int_52);
		smethod_16(ref string_71, "Luomrac", gstruct42_0.int_56);
		smethod_16(ref string_71, "LuomracAccept", gstruct42_0.int_57);
		smethod_16(ref string_71, "LuomracThuoctinh", gstruct42_0.int_58);
		smethod_16(ref string_71, "SinhlucThoat", gstruct42_0.int_19);
		smethod_16(ref string_71, "flagSinhlucThoat", gstruct42_0.int_20);
		smethod_16(ref string_71, "TDPKhiHetruong", gstruct42_0.int_62);
		smethod_16(ref string_71, "flagTranhBossvang", gstruct42_0.int_59);
		smethod_16(ref string_71, "AnTTL", gstruct42_0.int_60);
		smethod_16(ref string_71, "TDPKhiSaiMap", gstruct42_0.int_61);
		smethod_16(ref string_71, "GiamCpuLevel", gstruct42_0.int_87);
		smethod_16(ref string_71, "flagNhatdoIndex", gstruct42_0.int_63);
		smethod_16(ref string_71, "flagCanThuocLag", gstruct42_0.int_64);
		smethod_16(ref string_71, "fThuocTocdo", gstruct42_0.int_65);
		smethod_16(ref string_71, "flagBuffDoituong", gstruct42_0.int_5);
		smethod_16(ref string_71, "flagChiBuffKhongDanh", gstruct42_0.int_6);
		smethod_16(ref string_71, "flagTuGiaiBua", gstruct42_0.int_78);
		smethod_16(ref string_71, "flagGiaibuaBangsat", gstruct42_0.int_79);
		smethod_16(ref string_71, "flagGiaibuaTheoThoigian", gstruct42_0.int_80);
		smethod_16(ref string_71, "flagTNXuatChieu120", gstruct42_0.int_81);
		smethod_16(ref string_71, "flagConLon", gstruct42_0.int_82);
		smethod_16(ref string_71, "TimerTuGiaibua", gstruct42_0.int_83);
		smethod_16(ref string_71, "TimerTheoThoigian", gstruct42_0.int_85);
		smethod_16(ref string_71, "TamBuffbua", gstruct42_0.int_84);
		smethod_16(ref string_71, "flagTuGiaidoc", gstruct42_0.int_73);
		smethod_16(ref string_71, "TheoSau", gstruct42_0.int_68);
		string_71 = string_71 + "|NameTheoSau;" + Class11.smethod_17(gstruct42_0.string_7);
		smethod_16(ref string_71, "GanChieuTrai", gstruct42_0.int_131);
		smethod_16(ref string_71, "GanChieuPhai", gstruct42_0.int_132);
		smethod_16(ref string_71, "tbSwitchLeft1", gstruct42_0.int_133);
		smethod_16(ref string_71, "tbSwitchLeft2", gstruct42_0.int_134);
		smethod_16(ref string_71, "tbSwitchLeft3", gstruct42_0.int_135);
		smethod_16(ref string_71, "tbSwitchRight1", gstruct42_0.int_136);
		smethod_16(ref string_71, "tbSwitchRight2", gstruct42_0.int_137);
		smethod_16(ref string_71, "tbSwitchRight3", gstruct42_0.int_138);
		smethod_16(ref string_71, "Tran1Phai", gstruct42_0.int_139);
		smethod_16(ref string_71, "Tran2Phai", gstruct42_0.int_140);
		smethod_16(ref string_71, "Tran3Phai", gstruct42_0.int_141);
		smethod_16(ref string_71, "Nhqua", gstruct42_0.int_125);
		smethod_16(ref string_71, "BosST", gstruct42_0.int_126);
		smethod_16(ref string_71, "STHaucan", gstruct42_0.int_127);
		smethod_16(ref string_71, "DameChieu12", gstruct42_0.int_121);
		smethod_16(ref string_71, "DMBoom", gstruct42_0.int_122);
		smethod_16(ref string_71, "fQuangthuoc", gstruct42_0.int_123);
		smethod_16(ref string_71, "flagTienMangtheo", gstruct42_0.int_66);
		smethod_16(ref string_71, "TienMangtheo", gstruct42_0.int_67);
		smethod_16(ref string_71, "RuongBH", gstruct42_0.int_77);
		smethod_16(ref string_71, "fRao", gstruct42_0.int_69);
		string_71 = string_71 + "|tRaovat;" + Class11.smethod_17(gstruct42_0.string_8);
		smethod_16(ref string_71, "ChThuoc", gstruct42_0.int_75);
		string_71 = string_71 + "|fTenThuoc;" + Class11.smethod_17(gstruct42_0.string_12);
		smethod_16(ref string_71, "flagMuaThuocHP", gstruct42_0.int_70);
		string_71 = string_71 + "|TenHP;" + Class11.smethod_17(gstruct42_0.string_9);
		smethod_16(ref string_71, "flagMuaThuocMP", gstruct42_0.int_71);
		string_71 = string_71 + "|TenMP;" + Class11.smethod_17(gstruct42_0.string_10);
		smethod_16(ref string_71, "flagMuaGiaiDoc", gstruct42_0.int_72);
		string_71 = string_71 + "|TenGiaiDoc;" + Class11.smethod_17(gstruct42_0.string_11);
		smethod_16(ref string_71, "MuaKTC", gstruct42_0.int_76);
		smethod_16(ref string_71, "GanTenthuoc", gstruct42_0.int_74);
		smethod_16(ref string_71, "fNgamyBuff", gstruct42_0.int_97);
		smethod_16(ref string_71, "BomHPDiem", gstruct42_0.int_103);
		smethod_16(ref string_71, "BomMPDiem", gstruct42_0.int_104);
		smethod_16(ref string_71, "BomHPRatio", gstruct42_0.int_106);
		smethod_16(ref string_71, "BomM2HPRatio", gstruct42_0.int_107);
		smethod_16(ref string_71, "BomMPRatio", gstruct42_0.int_108);
		smethod_16(ref string_71, "BomM2MPRatio", gstruct42_0.int_109);
		smethod_16(ref string_71, "flagDoiPk", gstruct42_0.int_89);
		smethod_16(ref string_71, "flagXuongngua", gstruct42_0.int_90);
		smethod_16(ref string_71, "ChetNamIm", gstruct42_0.int_91);
		smethod_16(ref string_71, "fBaoBoss", gstruct42_0.int_1);
		smethod_16(ref string_71, "flagTuCastBua", gstruct42_0.int_116);
		smethod_16(ref string_71, "tbValueMagic", gstruct42_0.int_3);
		smethod_16(ref string_71, "flagDanhphim", gstruct42_0.int_96);
		smethod_16(ref string_71, "flagTuPT", gstruct42_0.int_99);
		smethod_16(ref string_71, "flagTiepcanF", gstruct42_0.int_92);
		smethod_16(ref string_71, "ValueTiepcan", gstruct42_0.int_93);
		smethod_16(ref string_71, "flagTamQuet_", gstruct42_0.int_94);
		smethod_16(ref string_71, "ValueTamQuet_s", gstruct42_0.int_95);
		smethod_16(ref string_71, "TDPKhiPk", gstruct42_0.int_100);
		smethod_16(ref string_71, "flagTuChayMuaThuocHoaSon", gstruct42_0.int_101);
		smethod_16(ref string_71, "flagHoason500l", gstruct42_0.int_102);
		smethod_16(ref string_71, "flagBanEvent", gstruct42_0.int_11);
		string text2 = string.Empty;
		if (gstruct42_0.gstruct30_0 != null)
		{
			for (int j = 0; j < gstruct42_0.gstruct30_0.Length; j++)
			{
				if (text2 != string.Empty)
				{
					text2 += "|";
				}
				if (gstruct42_0.gstruct30_0[j].int_8 == null)
				{
					gstruct42_0.gstruct30_0[j].int_8 = new int[2]
					{
						1,
						1
					};
				}
				string text3 = string.Empty;
				for (int k = 0; k < gstruct42_0.gstruct30_0[j].int_8.Length; k++)
				{
					if (text3 != string.Empty)
					{
						text3 += "_";
					}
					text3 += gstruct42_0.gstruct30_0[j].int_8[k].ToString();
				}
				object obj = text2;
				text2 = obj + gstruct42_0.gstruct30_0[j].string_0 + '\u0001' + gstruct42_0.gstruct30_0[j].int_6 + '\u0001' + gstruct42_0.gstruct30_0[j].int_0 + '\u0001' + gstruct42_0.gstruct30_0[j].int_5 + '\u0001' + text3 + '\u0001' + gstruct42_0.gstruct30_0[j].int_3 + '\u0001' + gstruct42_0.gstruct30_0[j].int_4 + '\u0001' + gstruct42_0.gstruct30_0[j].int_7 + '\u0001' + gstruct42_0.gstruct30_0[j].int_1 + '\u0001' + gstruct42_0.gstruct30_0[j].int_2;
			}
			text2 = Class11.smethod_17(text2);
		}
		string_71 = string_71 + "|tbMoThuoc;" + text2;
		smethod_16(ref string_71, "HPTdp", gstruct42_0.int_110);
		smethod_16(ref string_71, "MPTdp", gstruct42_0.int_111);
		smethod_16(ref string_71, "flagUuTienBomCuuChuyen", gstruct42_0.int_105);
		smethod_16(ref string_71, "flagTDPKhiSoluongMau", gstruct42_0.int_112);
		smethod_16(ref string_71, "TDPSoluongMauConlai", gstruct42_0.int_113);
		smethod_16(ref string_71, "flagTDPKhiSoluongMana", gstruct42_0.int_114);
		smethod_16(ref string_71, "TDPSoluongManaConlai", gstruct42_0.int_115);
		smethod_16(ref string_71, "KieuDanh", gstruct42_0.int_86);
		smethod_16(ref string_71, "tbNguhanh", gstruct42_0.int_88);
		smethod_16(ref string_71, "flagCuusatTheodanhsach", gstruct42_0.int_117);
		string_71 = string_71 + "|TenMauMuc2;" + Class11.smethod_17(gstruct42_0.string_14);
		string_71 = string_71 + "|TenManaMuc2;" + Class11.smethod_17(gstruct42_0.string_15);
		if (gstruct42_0.string_16 != null && gstruct42_0.string_16.Length > 0)
		{
			string text = null;
			for (int i = 0; i < gstruct42_0.string_16.Length; i++)
			{
				if (gstruct42_0.string_16[i] != null && gstruct42_0.string_16[i] != string.Empty)
				{
					if (text != null)
					{
						text += "|";
					}
					text += gstruct42_0.string_16[i];
				}
			}
			if (text != null)
			{
				string_71 = string_71 + "|DanhsachCuusat;" + Class11.smethod_17(text);
			}
		}
		string_71 = string_71 + "|PassRuong;" + Class11.smethod_17(gstruct42_0.string_13);
		if (gstruct42_0.string_17 != null && gstruct42_0.string_17.Length > 0)
		{
			string text = null;
			for (int i = 0; i < gstruct42_0.string_17.Length; i++)
			{
				if (gstruct42_0.string_17[i] != null && gstruct42_0.string_17[i] != string.Empty)
				{
					if (text != null)
					{
						text += "|";
					}
					text += gstruct42_0.string_17[i];
				}
			}
			if (text != null)
			{
				string_71 = string_71 + "|PTDanhsach;" + Class11.smethod_17(text);
			}
		}
		smethod_16(ref string_71, "PTflag", gstruct42_0.int_118);
		smethod_16(ref string_71, "fDenToado", gstruct42_0.int_120);
		smethod_16(ref string_71, "ClickNPCSolan", gstruct42_0.int_7);
		smethod_16(ref string_71, "ClickMenu", gstruct42_0.int_9);
		smethod_16(ref string_71, "flagClickMenu", gstruct42_0.int_8);
		string_71 = string_71 + "|ClickNPCName;" + Class11.smethod_17(gstruct42_0.string_0);
		smethod_16(ref string_71, "ClickNPCTocdo", gstruct42_0.int_10);
		string_71 = string_71 + "|TenVatphamNpc;" + Class11.smethod_17(gstruct42_0.string_1);
		smethod_16(ref string_71, "MenuVatphamNpc", gstruct42_0.int_13);
		smethod_16(ref string_71, "flagVatphamNpc", gstruct42_0.int_12);
		smethod_16(ref string_71, "flagClickNpcSau", gstruct42_0.int_14);
		smethod_16(ref string_71, "flagVatphamGiao1", gstruct42_0.int_15);
		smethod_16(ref string_71, "flagVatphamGiao2", gstruct42_0.int_16);
		smethod_16(ref string_71, "flagVatphamGiao3", gstruct42_0.int_17);
		smethod_16(ref string_71, "flagComuaVatphamNpc", gstruct42_0.int_18);
		smethod_16(ref string_71, "flagTrains", gstruct42_0.int_26);
		smethod_16(ref string_71, "flagTucheHT", gstruct42_0.int_27);
		smethod_16(ref string_71, "DanhQuaiTrain", gstruct42_0.int_28);
		smethod_16(ref string_71, "TDPHettien", gstruct42_0.int_29);
		smethod_16(ref string_71, "ToadoVong", gstruct42_0.int_30);
		smethod_16(ref string_71, "MapIDTrain", gstruct42_0.int_33);
		smethod_16(ref string_71, "XulyDosat", gstruct42_0.int_34);
		string text4 = null;
		if (gstruct42_0.uint_0 != null)
		{
			for (int j = 0; j < gstruct42_0.uint_0.GetLength(0); j++)
			{
				if (text4 != null)
				{
					text4 += "|";
				}
				object obj = text4;
				text4 = string.Concat(obj, gstruct42_0.uint_0[j, 0], ";", gstruct42_0.uint_0[j, 1]);
			}
			string_71 = string_71 + "|ToadoTrain;" + Class11.smethod_17(text4);
		}
		smethod_16(ref string_71, "SoDiemTrinhsat", gstruct42_0.int_22);
		smethod_16(ref string_71, "flagChayPkNguoidung", gstruct42_0.int_35);
		smethod_16(ref string_71, "fTinSu", gstruct42_0.int_21);
		smethod_16(ref string_71, "MapIDPk1", gstruct42_0.int_36);
		smethod_16(ref string_71, "MapIDPk2", gstruct42_0.int_37);
		text4 = null;
		if (gstruct42_0.uint_2 != null)
		{
			for (int j = 0; j < gstruct42_0.uint_2.GetLength(0); j++)
			{
				if (text4 != null)
				{
					text4 += "|";
				}
				object obj = text4;
				text4 = string.Concat(obj, gstruct42_0.uint_2[j, 0], ";", gstruct42_0.uint_2[j, 1]);
			}
			string_71 = string_71 + "|ToadoPk1;" + Class11.smethod_17(text4);
		}
		text4 = null;
		if (gstruct42_0.uint_3 != null)
		{
			for (int j = 0; j < gstruct42_0.uint_3.GetLength(0); j++)
			{
				if (text4 != null)
				{
					text4 += "|";
				}
				object obj = text4;
				text4 = string.Concat(obj, gstruct42_0.uint_3[j, 0], ";", gstruct42_0.uint_3[j, 1]);
			}
			string_71 = string_71 + "|ToadoPk2;" + Class11.smethod_17(text4);
		}
		if (gstruct42_0.gstruct33_0 != null)
		{
			int[] array = new int[gstruct42_0.gstruct33_0.Length];
			int[] array2 = new int[gstruct42_0.gstruct33_0.Length];
			int[] array3 = new int[gstruct42_0.gstruct33_0.Length];
			for (int j = 0; j < gstruct42_0.gstruct33_0.Length; j++)
			{
				array[j] = gstruct42_0.gstruct33_0[j].int_0;
				array2[j] = gstruct42_0.gstruct33_0[j].int_2;
				array3[j] = gstruct42_0.gstruct33_0[j].int_3;
			}
			smethod_16(ref string_71, "tbFlagItemMagic", array);
			smethod_16(ref string_71, "tbValueItemMagic", array2);
			smethod_16(ref string_71, "tbValueDong", array3);
		}
		if (gstruct42_0.string_6 != null && gstruct42_0.string_6.Length > 0)
		{
			string text = null;
			for (int i = 0; i < gstruct42_0.string_6.Length; i++)
			{
				if (gstruct42_0.string_6[i] != null && gstruct42_0.string_6[i] != string.Empty)
				{
					if (text != null)
					{
						text += "|";
					}
					text += gstruct42_0.string_6[i];
				}
			}
			if (text != null)
			{
				string_71 = string_71 + "|ThuocTocdoDanh;" + Class11.smethod_17(text);
			}
		}
		if (gstruct42_0.string_5 != null && gstruct42_0.string_5.Length > 0)
		{
			string text = null;
			for (int i = 0; i < gstruct42_0.string_5.Length; i++)
			{
				if (gstruct42_0.string_5[i] != null && gstruct42_0.string_5[i] != string.Empty)
				{
					if (text != null)
					{
						text += "|";
					}
					text += gstruct42_0.string_5[i];
				}
			}
			if (text != null)
			{
				string_71 = string_71 + "|tbThuocLag;" + Class11.smethod_17(text);
			}
		}
		if (gstruct42_0.string_3 != null && gstruct42_0.string_3.Length > 0)
		{
			string text = null;
			for (int i = 0; i < gstruct42_0.string_3.Length; i++)
			{
				if (gstruct42_0.string_3[i] != null && gstruct42_0.string_3[i] != string.Empty)
				{
					if (text != null)
					{
						text += "|";
					}
					text += gstruct42_0.string_3[i];
				}
			}
			if (text != null)
			{
				string_71 = string_71 + "|IBadlist;" + Class11.smethod_17(text);
			}
		}
		if (gstruct42_0.gstruct39_0 != null && gstruct42_0.gstruct39_0.Length > 0)
		{
			string text = null;
			for (int j = 0; j < gstruct42_0.gstruct39_0.Length; j++)
			{
				GStruct37[] gstruct37_ = gstruct42_0.gstruct39_0[j].gstruct37_0;
				if (gstruct37_ == null)
				{
					continue;
				}
				string text5 = null;
				for (int i = 0; i < gstruct37_.Length; i++)
				{
					if (text5 != null)
					{
						text5 += "/";
					}
					text5 = text5 + gstruct37_[i].int_0.ToString() + "=" + gstruct37_[i].string_0;
				}
				if (text != null)
				{
					text += "|";
				}
				text = text + gstruct42_0.gstruct39_0[j].int_0.ToString() + ":" + text5;
			}
			if (text != null)
			{
				string_71 = string_71 + "|AscBomThuoc;" + Class11.smethod_17(text);
			}
		}
		if (string_70 != null && !(string_70 == string.Empty))
		{
			string[] array4 = Class11.smethod_15(string_70);
			Class11.smethod_8(array4[0]);
			Class11.smethod_29(string_70, string_71, 3);
		}
		else
		{
			Class11.smethod_8(string_6);
			Class11.smethod_29(string_6 + "\\" + Class11.smethod_39(gstruct42_0.string_20) + ".cfg", string_71, 3);
		}
	}

	public static int[] smethod_12(int int_10)
	{
		int[] array = new int[5];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = int_8[int_10, i];
		}
		return array;
	}

	public static int[] smethod_13(int int_10)
	{
		int[] array = new int[10];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = int_9[int_10, i];
		}
		return array;
	}

	public static int[] smethod_14(GStruct42 gstruct42_0, string string_70 = null)
	{
		if (string_70 == null || string_70 == string.Empty)
		{
			string_70 = Class67.smethod_18(gstruct42_0);
		}
		int[] array = new int[7];
		if (string_70 == "CONLON")
		{
			if (Class67.smethod_15(gstruct42_0, 394u) > 0)
			{
				array[0] = 394;
			}
			if (Class67.smethod_15(gstruct42_0, 392u) > 0)
			{
				array[1] = 392;
			}
			if (Class67.smethod_15(gstruct42_0, 174u) > 0)
			{
				array[2] = 174;
			}
			if (Class67.smethod_15(gstruct42_0, 393u) > 0)
			{
				array[3] = 393;
			}
			if (Class67.smethod_15(gstruct42_0, 175u) > 0)
			{
				array[4] = 175;
			}
			if (Class67.smethod_15(gstruct42_0, 90u) > 0)
			{
				array[5] = 90;
			}
		}
		else if (!(string_70 == "THIENNHAN"))
		{
			if (string_70 == "NGUDOC")
			{
				if (Class67.smethod_15(gstruct42_0, 73u) > 0)
				{
					array[0] = 73;
				}
				if (Class67.smethod_15(gstruct42_0, 390u) > 0)
				{
					array[1] = 390;
				}
				if (Class67.smethod_15(gstruct42_0, 356u) > 0)
				{
					array[2] = 356;
				}
				if (Class67.smethod_15(gstruct42_0, 72u) > 0)
				{
					array[3] = 72;
				}
				if (Class67.smethod_15(gstruct42_0, 64u) > 0)
				{
					array[4] = 64;
				}
				if (Class67.smethod_15(gstruct42_0, 70u) > 0)
				{
					array[5] = 70;
				}
				if (Class67.smethod_15(gstruct42_0, 67u) > 0)
				{
					array[6] = 67;
				}
			}
		}
		else
		{
			if (Class67.smethod_15(gstruct42_0, 391u) > 0)
			{
				array[0] = 391;
			}
			if (Class67.smethod_15(gstruct42_0, 136u) > 0)
			{
				array[1] = 136;
			}
			if (Class67.smethod_15(gstruct42_0, 137u) > 0)
			{
				array[2] = 137;
			}
			if (Class67.smethod_15(gstruct42_0, 140u) > 0)
			{
				array[3] = 140;
			}
			if (Class67.smethod_15(gstruct42_0, 364u) > 0)
			{
				array[4] = 364;
			}
			if (Class67.smethod_15(gstruct42_0, 143u) > 0)
			{
				array[5] = 143;
			}
		}
		return array;
	}

	public static int[,] smethod_15(string string_70)
	{
		int[,] result = null;
		if (string_70 == "NGUDOC")
		{
			result = new int[7, 2]
			{
				{
					73,
					7
				},
				{
					390,
					12
				},
				{
					356,
					54
				},
				{
					72,
					11
				},
				{
					64,
					8
				},
				{
					70,
					10
				},
				{
					67,
					9
				}
			};
		}
		else if (string_70 == "THIENNHAN")
		{
			result = new int[6, 2]
			{
				{
					391,
					59
				},
				{
					136,
					22
				},
				{
					137,
					26
				},
				{
					140,
					27
				},
				{
					364,
					58
				},
				{
					143,
					28
				}
			};
		}
		else if (string_70 == "CONLON")
		{
			result = new int[6, 2]
			{
				{
					394,
					60
				},
				{
					392,
					63
				},
				{
					174,
					66
				},
				{
					393,
					65
				},
				{
					175,
					54
				},
				{
					90,
					64
				}
			};
		}
		return result;
	}

	private static void smethod_16(ref string string_70, string string_71, object object_0)
	{
		try
		{
			int[] array = null;
			if (object_0 == null)
			{
				object_0 = string.Empty;
			}
			string text = object_0.GetType().ToString().ToUpper();
			if (Class11.smethod_2(text, "INT") > 0)
			{
				array = ((Class11.smethod_2(text, "[]") <= 0) ? new int[1]
				{
					Class11.smethod_12(object_0.ToString())
				} : ((int[])object_0));
			}
			if (string_70 != null && string_70 != string.Empty)
			{
				string_70 += "|";
			}
			string_70 += string_71;
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					string_70 = string_70 + ";" + array[i].ToString();
				}
			}
		}
		catch
		{
		}
	}

	public static int[] smethod_17(string[] string_70, string string_71, int[] int_10)
	{
		string_71 = string_71.ToUpper();
		if (string_70 != null && string_70.Length > 0)
		{
			for (int i = 0; i < string_70.Length; i++)
			{
				if (string_70[i] == null || !(string_70[i] != ""))
				{
					continue;
				}
				string[] array = string_70[i].Split(';');
				if (!(array[0].Trim().ToUpper() == string_71))
				{
					continue;
				}
				int[] array2 = null;
				if (array.Length > 1)
				{
					array2 = new int[array.Length - 1];
					for (int j = 1; j < array.Length; j++)
					{
						array2[j - 1] = Class11.smethod_12(array[j].Trim());
					}
				}
				if (array2 == null)
				{
					break;
				}
				return array2;
			}
		}
		return int_10;
	}

	public static uint[,] smethod_18(string[] string_70, string string_71, uint[,] uint_8)
	{
		string_71 = string_71.ToUpper();
		if (string_70 != null && string_70.Length > 0)
		{
			for (int i = 0; i < string_70.Length; i++)
			{
				if (string_70[i] == null || !(string_70[i] != ""))
				{
					continue;
				}
				string[] array = string_70[i].Split(';');
				if (!(array[0].Trim().ToUpper() == string_71))
				{
					continue;
				}
				uint[,] array2 = null;
				if (array.Length > 1)
				{
					array2 = new uint[array.Length - 1, 2];
					int num = 0;
					for (int j = 1; j < array.Length; j++)
					{
						string text = array[j].Trim();
						if (!(text == ""))
						{
							string[] array3 = text.Split(',');
							if (array3.Length > 1)
							{
								array2[num, 0] = Class11.smethod_13(array3[0].Trim());
								array2[num, 1] = Class11.smethod_13(array3[1].Trim());
							}
							num++;
						}
					}
					if (num == 0)
					{
						array2 = null;
					}
					else if (num < array2.GetLength(0))
					{
						uint[,] array4 = new uint[num, 2];
						for (int j = 0; j < num; j++)
						{
							array4[j, 0] = array2[j, 0];
							array4[j, 1] = array2[j, 1];
						}
						array2 = array4;
					}
				}
				return array2;
			}
		}
		return uint_8;
	}

	public static string[] smethod_19(string[] string_70, string string_71, string[] string_72, bool bool_2 = false)
	{
		string_71 = string_71.ToUpper();
		if (string_70 != null && string_70.Length > 0)
		{
			for (int i = 0; i < string_70.Length; i++)
			{
				if (string_70[i] == null || !(string_70[i] != ""))
				{
					continue;
				}
				string[] array = string_70[i].Split(';');
				if (!(array[0].Trim().ToUpper() == string_71))
				{
					continue;
				}
				if (array.Length >= 2)
				{
					string[] array2 = new string[array.Length - 1];
					int num = 0;
					for (int j = 1; j < array.Length; j++)
					{
						string text = array[j].Trim();
						if (!bool_2 || !(text == ""))
						{
							array2[num] = text;
							num++;
						}
					}
					if (num != 0)
					{
						if (num != array2.Length)
						{
							string[] array3 = new string[num];
							for (int j = 0; j < num; j++)
							{
								array3[j] = array2[j];
							}
							return array3;
						}
						return array2;
					}
					return null;
				}
				return null;
			}
		}
		return string_72;
	}

	private static bool smethod_20(GStruct42 gstruct42_0)
	{
		uint num = Class20.smethod_35(gstruct42_0.int_129, gstruct43_265.string_0);
		uint[] array = Class20.smethod_63(gstruct42_0.int_130, num, ".text|slowfbeq|default");
		if (array != null && array[0] != 0)
		{
			int int_ = 0;
			byte[] array2 = new byte[array[0]];
			if (!Class20.ReadProcessMemory(gstruct42_0.int_130, num + array[1], array2, array2.Length, ref int_))
			{
				return false;
			}
			Class91.smethod_3(array[1], array2, ref gstruct43_265);
			return gstruct43_265.uint_0 != 0;
		}
		return false;
	}

	public static bool smethod_21(GStruct42 gstruct42_0, bool bool_2)
	{
		if (gstruct43_265.uint_0 == 0 && !smethod_20(FormMain.gstruct42_0[0]))
		{
			return false;
		}
		int int_ = 0;
		byte[] array = null;
		array = ((!bool_2) ? new byte[2]
		{
			15,
			135
		} : new byte[2]
		{
			144,
			233
		});
		uint num = Class20.smethod_35(gstruct42_0.int_129, gstruct43_265.string_0);
		if (num != 0)
		{
			return Class20.WriteProcessMemory(gstruct42_0.int_130, num + gstruct43_265.uint_0, array, array.Length, ref int_);
		}
		return false;
	}

	public static void smethod_22(bool bool_2)
	{
		string str = "SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters";
		string text = "ForwardBufferMemory";
		string text2 = "NumForwardPackets";
		string text3 = "DisableTaskOffload";
		string text4 = "SOFTWARE\\Microsoft\\MSMQ\\Parameters";
		string text5 = "TCPNoDelay";
		string str2 = str + "\\Interfaces";
		string text6 = "TcpAckFrequency";
		string[] array = Class55.smethod_8(str2);
		if (!bool_2)
		{
			Class55.smethod_12(str, text, 0);
			Class55.smethod_12(str, text2, 0);
			Class55.smethod_12(str, text3, 0);
			Class55.smethod_12(str, text5, 0);
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					Class55.smethod_12(str2 + "\\" + array[i], text6, 0);
				}
			}
			Class55.smethod_12(text4, text5, 0);
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 582;
		int num4 = 148992;
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			NetworkInterface[] array2 = allNetworkInterfaces;
			foreach (NetworkInterface networkInterface in array2)
			{
				if (networkInterface.Supports(NetworkInterfaceComponent.IPv4))
				{
					IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
					IPv4InterfaceProperties iPv4Properties = iPProperties.GetIPv4Properties();
					if (iPv4Properties != null)
					{
						num += iPv4Properties.Mtu;
						num2++;
					}
				}
			}
		}
		catch
		{
		}
		if (num2 > 0)
		{
			num /= num2;
			num3 = num * 100;
			num3 /= 256;
			num4 = num3 * 256;
		}
		Class55.smethod_10(str, text2, num3, "DWORD", 0);
		Class55.smethod_10(str, text, num4, "DWORD", 0);
		Class55.smethod_10(str, text3, 0, "DWORD", 0);
		Class55.smethod_10(str, text5, 1, "DWORD", 0);
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Class55.smethod_10(str2 + "\\" + array[i], text6, 1, "DWORD", 0);
			}
		}
		Class55.smethod_10(text4, text5, 1, "DWORD", 0);
	}

	public static void smethod_23(string string_70, string string_71, bool bool_2 = false, string string_72 = "", int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0)
	{
		try
		{
			Class11.smethod_29(string_70, string_71, 1);
			if (bool_2)
			{
				string text = "Software\\Microsoft\\Notepad";
				if (string_72 != "")
				{
					Class55.smethod_10(text, "lfFaceName", string_72, "", 1);
				}
				if (int_10 != 0)
				{
					Class55.smethod_10(text, "iPointSize", int_10 * 10, "DWORD", 1);
				}
				if (int_11 != 0)
				{
					Class55.smethod_10(text, "iWindowPosDX", int_11, "DWORD", 1);
				}
				if (int_12 != 0)
				{
					Class55.smethod_10(text, "iWindowPosDY", int_12, "DWORD", 1);
				}
				if (int_13 != 0)
				{
					Class55.smethod_10(text, "iWindowPosX", int_13, "DWORD", 1);
				}
				if (int_14 != 0)
				{
					Class55.smethod_10(text, "iWindowPosY", int_14, "DWORD", 1);
				}
				Class55.smethod_10(text, "fWrap", 0, "DWORD", 1);
				Class55.smethod_10(text, "lfItalic", 0, "DWORD", 1);
				Class20.smethod_40("Notepad.exe", "", string_70, 0);
			}
		}
		catch
		{
		}
	}

	public static string smethod_24(string string_70 = "", string string_71 = "", string string_72 = "", string string_73 = "")
	{
		string result = "";
		string initialDirectory = string_70;
		if (string_70 == "")
		{
			initialDirectory = string_4;
		}
		if (string_72 == "")
		{
			string_72 = "*.txt";
		}
		string text = "Request files (" + string_72 + ")|" + string_72 + "|All files (*.*)|*.*";
		if (string_73 != null && string_73 != "")
		{
			text = string_73 + "|" + text;
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = initialDirectory;
		openFileDialog.Filter = text;
		openFileDialog.FileName = string_71;
		openFileDialog.FilterIndex = 1;
		openFileDialog.RestoreDirectory = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			result = openFileDialog.FileName;
		}
		openFileDialog = null;
		return result;
	}

	public static string smethod_25(string string_70 = "", string string_71 = "")
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		string result = string.Empty;
		string text = string.Empty;
		if (string_71 != null)
		{
			string[] array = string_71.Split('.');
			text = array[array.Length - 1];
		}
		text = ((text == string.Empty) ? "xyz files (*.xyz)|*.xyz" : (text + " file (*." + text + ")|*." + text));
		saveFileDialog.Filter = text + "|All files (*.*)|*.*";
		saveFileDialog.FilterIndex = 1;
		saveFileDialog.RestoreDirectory = true;
		saveFileDialog.InitialDirectory = string_70;
		saveFileDialog.FileName = string_71;
		Stream stream;
		if (saveFileDialog.ShowDialog() == DialogResult.OK && (stream = saveFileDialog.OpenFile()) != null)
		{
			result = saveFileDialog.FileName;
			stream.Close();
		}
		return result;
	}

	public static string smethod_26(string string_70)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		folderBrowserDialog.SelectedPath = string_70;
		folderBrowserDialog.ShowNewFolderButton = true;
		FolderBrowserDialog folderBrowserDialog2 = folderBrowserDialog;
		DialogResult dialogResult = folderBrowserDialog2.ShowDialog();
		if (dialogResult == DialogResult.OK)
		{
			return folderBrowserDialog2.SelectedPath;
		}
		return null;
	}

	public static void smethod_27()
	{
		int num = 0;
		string empty = string.Empty;
		GStruct43[] array = smethod_2();
		GStruct43[] array2 = smethod_2();
		while (true)
		{
			empty = ((num > 0) ? Class11.smethod_16(string_68) : Class11.smethod_16(Class11.smethod_28(string_5 + "\\" + string_13, 0, 0, 1)));
			if (empty == string.Empty || empty == null)
			{
				break;
			}
			string[] array3 = empty.Split('\u0001');
			string[,] array4 = new string[array3.Length, 2];
			int num2 = 0;
			for (num2 = 0; num2 < array3.Length; num2++)
			{
				if (array3[num2] != null && !(array3[num2] == string.Empty))
				{
					string[] array5 = array3[num2].Split('=');
					if (array5.Length > 1)
					{
						array4[num2, 0] = array5[0];
						array4[num2, 1] = array5[1];
					}
				}
			}
			if (num != 0)
			{
				if (array2 != null)
				{
					for (num2 = 0; num2 < array2.Length; num2++)
					{
						Class91.smethod_1(ref array2[num2], array4);
					}
				}
			}
			else if (array != null)
			{
				for (num2 = 0; num2 < array.Length; num2++)
				{
					Class91.smethod_1(ref array[num2], array4);
				}
			}
			if (num <= 0)
			{
				num++;
				continue;
			}
			string text = string.Empty;
			string text2 = "GAME_DATA_BY_USER # GAME_DATA_DEFAULT" + string_3 + "=====================================" + string_3;
			int num3 = array.Length;
			int num4 = array2.Length;
			for (num2 = 0; num3 > num2 && num4 > num2; num2++)
			{
				object obj = text2;
				text2 = string.Concat(obj, num2, ". ", array[num2].string_0, "\t = ", Class11.smethod_40(array[num2].uint_0, 8, bool_1: false));
				if (array2[num2].uint_0 != array[num2].uint_0 || array2[num2].uint_0 == 0 || array[num2].uint_0 == 0)
				{
					text2 = text2 + " # " + Class11.smethod_40(array2[num2].uint_0, 8, bool_1: false);
					text = text + num2.ToString() + "; ";
				}
				text2 += string_3;
			}
			if (num3 < num4)
			{
				text = text + "MẢNG USER NGẮN HƠN MẢNG DEFAULT" + string_3;
			}
			else if (num4 < num3)
			{
				text = text + "MẢNG DEFAULT NGẮN HƠN MẢNG USER" + string_3;
			}
			if (text != string.Empty)
			{
				text2 = text + string_3 + "=====================================" + string_3 + text2;
			}
			string_69 = text2;
			return;
		}
		Class11.smethod_24(ref Class11.string_14, "Lỗi Idex = " + num + ": Bấm cập nhật data game để tạo dữ liệu, sau đó bấm lại so sánh.");
	}
}
