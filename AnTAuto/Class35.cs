using System;
using System.Threading;

internal class Class35
{
	private static uint[,] uint_0 = new uint[10, 2]
	{
		{
			102434u,
			166512u
		},
		{
			102105u,
			166166u
		},
		{
			101820u,
			165792u
		},
		{
			101284u,
			165306u
		},
		{
			100870u,
			164899u
		},
		{
			100440u,
			164450u
		},
		{
			100177u,
			164226u
		},
		{
			99809u,
			163818u
		},
		{
			99392u,
			164230u
		},
		{
			99009u,
			164394u
		}
	};

	private static uint[,] uint_1 = new uint[14, 2]
	{
		{
			98041u,
			161492u
		},
		{
			97670u,
			161829u
		},
		{
			97350u,
			162228u
		},
		{
			96966u,
			162624u
		},
		{
			96623u,
			162998u
		},
		{
			96063u,
			163516u
		},
		{
			96465u,
			163915u
		},
		{
			96849u,
			164311u
		},
		{
			97282u,
			164755u
		},
		{
			97715u,
			165200u
		},
		{
			98101u,
			165598u
		},
		{
			98441u,
			165142u
		},
		{
			98834u,
			164880u
		},
		{
			99036u,
			164398u
		}
	};

	private static uint[,] uint_2 = new uint[18, 2]
	{
		{
			96532u,
			158574u
		},
		{
			96955u,
			158990u
		},
		{
			97390u,
			159432u
		},
		{
			97868u,
			159909u
		},
		{
			98173u,
			160215u
		},
		{
			98498u,
			160539u
		},
		{
			98841u,
			160883u
		},
		{
			99166u,
			161208u
		},
		{
			99490u,
			161532u
		},
		{
			99834u,
			161876u
		},
		{
			100158u,
			162200u
		},
		{
			100464u,
			162506u
		},
		{
			100717u,
			162848u
		},
		{
			100356u,
			163213u
		},
		{
			99987u,
			163619u
		},
		{
			99601u,
			164093u
		},
		{
			99291u,
			164360u
		},
		{
			99028u,
			164398u
		}
	};

	private static uint[,] uint_3 = new uint[16, 2]
	{
		{
			105002u,
			159790u
		},
		{
			104509u,
			160228u
		},
		{
			103960u,
			160740u
		},
		{
			103679u,
			161065u
		},
		{
			103260u,
			161558u
		},
		{
			102765u,
			161927u
		},
		{
			102381u,
			162334u
		},
		{
			101969u,
			162732u
		},
		{
			101649u,
			163060u
		},
		{
			101354u,
			163444u
		},
		{
			101016u,
			163157u
		},
		{
			100650u,
			162774u
		},
		{
			100217u,
			163252u
		},
		{
			99767u,
			163746u
		},
		{
			99331u,
			164169u
		},
		{
			99036u,
			164370u
		}
	};

	private static GStruct17[] gstruct17_0 = new GStruct17[4]
	{
		new GStruct17
		{
			uint_0 = uint_0
		},
		new GStruct17
		{
			uint_0 = uint_1
		},
		new GStruct17
		{
			uint_0 = uint_2
		},
		new GStruct17
		{
			uint_0 = uint_3
		}
	};

	private static uint[,] uint_4 = new uint[8, 2]
	{
		{
			54702u,
			103108u
		},
		{
			54320u,
			103470u
		},
		{
			53945u,
			103842u
		},
		{
			53628u,
			104154u
		},
		{
			53124u,
			104674u
		},
		{
			52611u,
			105148u
		},
		{
			52433u,
			104924u
		},
		{
			52141u,
			104390u
		}
	};

	private static uint[,] uint_5 = new uint[14, 2]
	{
		{
			51164u,
			108356u
		},
		{
			50770u,
			108015u
		},
		{
			50282u,
			107480u
		},
		{
			50669u,
			107013u
		},
		{
			51104u,
			106607u
		},
		{
			51538u,
			106102u
		},
		{
			51133u,
			105683u
		},
		{
			50701u,
			105256u
		},
		{
			50197u,
			104708u
		},
		{
			50570u,
			104227u
		},
		{
			50628u,
			103742u
		},
		{
			50980u,
			103588u
		},
		{
			51526u,
			103998u
		},
		{
			52080u,
			104378u
		}
	};

	private static uint[,] uint_6 = new uint[14, 2]
	{
		{
			46033u,
			103128u
		},
		{
			46534u,
			102494u
		},
		{
			46991u,
			102050u
		},
		{
			47623u,
			101317u
		},
		{
			48053u,
			100913u
		},
		{
			48358u,
			100588u
		},
		{
			48799u,
			101005u
		},
		{
			49373u,
			101619u
		},
		{
			49825u,
			102107u
		},
		{
			50196u,
			102514u
		},
		{
			50605u,
			102964u
		},
		{
			51055u,
			103454u
		},
		{
			51510u,
			103941u
		},
		{
			52128u,
			104428u
		}
	};

	private static uint[,] uint_7 = new uint[15, 2]
	{
		{
			45981u,
			103074u
		},
		{
			46400u,
			103513u
		},
		{
			46873u,
			104022u
		},
		{
			47222u,
			104371u
		},
		{
			47570u,
			104719u
		},
		{
			48042u,
			105191u
		},
		{
			48399u,
			105566u
		},
		{
			48771u,
			105161u
		},
		{
			49101u,
			104796u
		},
		{
			49457u,
			104415u
		},
		{
			49914u,
			103930u
		},
		{
			50357u,
			103395u
		},
		{
			50846u,
			103465u
		},
		{
			51485u,
			103936u
		},
		{
			52089u,
			104384u
		}
	};

	private static uint[,] uint_8 = new uint[12, 2]
	{
		{
			46966u,
			101348u
		},
		{
			47295u,
			101713u
		},
		{
			47781u,
			102168u
		},
		{
			48200u,
			102593u
		},
		{
			48516u,
			102932u
		},
		{
			49011u,
			103460u
		},
		{
			49372u,
			103837u
		},
		{
			49833u,
			103530u
		},
		{
			50402u,
			103231u
		},
		{
			51037u,
			103727u
		},
		{
			51448u,
			103942u
		},
		{
			52064u,
			104398u
		}
	};

	private static GStruct17[] gstruct17_1 = new GStruct17[5]
	{
		new GStruct17
		{
			uint_0 = uint_4
		},
		new GStruct17
		{
			uint_0 = uint_5
		},
		new GStruct17
		{
			uint_0 = uint_6
		},
		new GStruct17
		{
			uint_0 = uint_7
		},
		new GStruct17
		{
			uint_0 = uint_8
		}
	};

	private static uint[,] uint_9 = new uint[6, 2]
	{
		{
			48700u,
			103456u
		},
		{
			48921u,
			103860u
		},
		{
			49153u,
			103612u
		},
		{
			49427u,
			103328u
		},
		{
			49823u,
			102956u
		},
		{
			49920u,
			102626u
		}
	};

	private static uint[,] uint_10 = new uint[15, 2]
	{
		{
			52298u,
			106029u
		},
		{
			51889u,
			106365u
		},
		{
			51544u,
			106239u
		},
		{
			51144u,
			106174u
		},
		{
			50807u,
			105777u
		},
		{
			50820u,
			105396u
		},
		{
			50833u,
			105012u
		},
		{
			50556u,
			104770u
		},
		{
			50200u,
			104411u
		},
		{
			49813u,
			104017u
		},
		{
			49537u,
			103741u
		},
		{
			49317u,
			103406u
		},
		{
			49612u,
			103104u
		},
		{
			49912u,
			102816u
		},
		{
			49928u,
			102564u
		}
	};

	private static uint[,] uint_11 = new uint[14, 2]
	{
		{
			53573u,
			102700u
		},
		{
			53324u,
			103085u
		},
		{
			52896u,
			102971u
		},
		{
			52628u,
			103254u
		},
		{
			52285u,
			103625u
		},
		{
			52032u,
			103888u
		},
		{
			51789u,
			104126u
		},
		{
			51509u,
			103791u
		},
		{
			51161u,
			103395u
		},
		{
			51011u,
			102899u
		},
		{
			50793u,
			102488u
		},
		{
			50577u,
			102200u
		},
		{
			50148u,
			102606u
		},
		{
			49896u,
			102618u
		}
	};

	private static uint[,] uint_12 = new uint[8, 2]
	{
		{
			50383u,
			103936u
		},
		{
			50730u,
			103570u
		},
		{
			51070u,
			103212u
		},
		{
			51185u,
			103076u
		},
		{
			50879u,
			102703u
		},
		{
			50525u,
			102272u
		},
		{
			50133u,
			102634u
		},
		{
			49905u,
			102631u
		}
	};

	private static uint[,] uint_13 = new uint[11, 2]
	{
		{
			49832u,
			100490u
		},
		{
			49478u,
			100850u
		},
		{
			49088u,
			101206u
		},
		{
			48606u,
			101665u
		},
		{
			48255u,
			102029u
		},
		{
			48373u,
			102278u
		},
		{
			48703u,
			102578u
		},
		{
			48992u,
			102810u
		},
		{
			49449u,
			103288u
		},
		{
			49749u,
			102972u
		},
		{
			49930u,
			102622u
		}
	};

	private static uint[,] uint_14 = new uint[12, 2]
	{
		{
			49337u,
			99172u
		},
		{
			49646u,
			99481u
		},
		{
			49869u,
			99677u
		},
		{
			50214u,
			100070u
		},
		{
			50482u,
			100319u
		},
		{
			50782u,
			100603u
		},
		{
			51059u,
			100879u
		},
		{
			51407u,
			101284u
		},
		{
			51022u,
			101672u
		},
		{
			50627u,
			102058u
		},
		{
			50265u,
			102410u
		},
		{
			49925u,
			102608u
		}
	};

	private static uint[,] uint_15 = new uint[11, 2]
	{
		{
			53044u,
			105386u
		},
		{
			52611u,
			104911u
		},
		{
			52359u,
			104635u
		},
		{
			51965u,
			104292u
		},
		{
			51682u,
			103982u
		},
		{
			51357u,
			103597u
		},
		{
			51052u,
			103178u
		},
		{
			51109u,
			102628u
		},
		{
			50669u,
			102138u
		},
		{
			50265u,
			102474u
		},
		{
			49924u,
			102618u
		}
	};

	private static uint[,] uint_16 = new uint[11, 2]
	{
		{
			53472u,
			100810u
		},
		{
			53111u,
			101194u
		},
		{
			52742u,
			101508u
		},
		{
			52353u,
			101877u
		},
		{
			52074u,
			102187u
		},
		{
			51795u,
			102459u
		},
		{
			51566u,
			102710u
		},
		{
			51136u,
			102262u
		},
		{
			50590u,
			102168u
		},
		{
			50149u,
			102590u
		},
		{
			49931u,
			102588u
		}
	};

	private static GStruct17[] gstruct17_2 = new GStruct17[8]
	{
		new GStruct17
		{
			uint_0 = uint_9
		},
		new GStruct17
		{
			uint_0 = uint_10
		},
		new GStruct17
		{
			uint_0 = uint_11
		},
		new GStruct17
		{
			uint_0 = uint_12
		},
		new GStruct17
		{
			uint_0 = uint_13
		},
		new GStruct17
		{
			uint_0 = uint_14
		},
		new GStruct17
		{
			uint_0 = uint_15
		},
		new GStruct17
		{
			uint_0 = uint_16
		}
	};

	private static uint[,] uint_17 = new uint[11, 2]
	{
		{
			53802u,
			99838u
		},
		{
			53081u,
			100549u
		},
		{
			52604u,
			101037u
		},
		{
			52289u,
			101286u
		},
		{
			51820u,
			101880u
		},
		{
			51169u,
			101184u
		},
		{
			50790u,
			100800u
		},
		{
			50338u,
			101298u
		},
		{
			49850u,
			101794u
		},
		{
			49389u,
			102275u
		},
		{
			49189u,
			102482u
		}
	};

	private static uint[,] uint_18 = new uint[4, 2]
	{
		{
			47922u,
			102790u
		},
		{
			48454u,
			103346u
		},
		{
			48830u,
			102994u
		},
		{
			49173u,
			102490u
		}
	};

	private static uint[,] uint_19 = new uint[7, 2]
	{
		{
			46736u,
			105208u
		},
		{
			47253u,
			104672u
		},
		{
			47718u,
			104169u
		},
		{
			48169u,
			103661u
		},
		{
			48526u,
			103306u
		},
		{
			48885u,
			102916u
		},
		{
			49149u,
			102474u
		}
	};

	private static uint[,] uint_20 = new uint[11, 2]
	{
		{
			51083u,
			103754u
		},
		{
			51654u,
			104348u
		},
		{
			51171u,
			104758u
		},
		{
			50604u,
			105346u
		},
		{
			50242u,
			105000u
		},
		{
			49898u,
			104648u
		},
		{
			49439u,
			104165u
		},
		{
			48962u,
			103659u
		},
		{
			48560u,
			103210u
		},
		{
			48932u,
			102814u
		},
		{
			49176u,
			102448u
		}
	};

	private static uint[,] uint_21 = new uint[15, 2]
	{
		{
			54596u,
			105372u
		},
		{
			54096u,
			104893u
		},
		{
			53661u,
			104542u
		},
		{
			53132u,
			103993u
		},
		{
			52809u,
			103622u
		},
		{
			52376u,
			103116u
		},
		{
			51872u,
			102640u
		},
		{
			51640u,
			102380u
		},
		{
			51316u,
			102713u
		},
		{
			50842u,
			103182u
		},
		{
			50674u,
			103366u
		},
		{
			50225u,
			102957u
		},
		{
			49860u,
			102584u
		},
		{
			49522u,
			102214u
		},
		{
			49169u,
			102452u
		}
	};

	private static GStruct17[] gstruct17_3 = new GStruct17[5]
	{
		new GStruct17
		{
			uint_0 = uint_17
		},
		new GStruct17
		{
			uint_0 = uint_18
		},
		new GStruct17
		{
			uint_0 = uint_19
		},
		new GStruct17
		{
			uint_0 = uint_20
		},
		new GStruct17
		{
			uint_0 = uint_21
		}
	};

	private static uint[,] uint_22 = new uint[15, 2]
	{
		{
			59899u,
			96774u
		},
		{
			59324u,
			97301u
		},
		{
			58911u,
			97731u
		},
		{
			58468u,
			98194u
		},
		{
			58187u,
			98488u
		},
		{
			57736u,
			98037u
		},
		{
			57162u,
			97463u
		},
		{
			56836u,
			97130u
		},
		{
			56367u,
			96657u
		},
		{
			56099u,
			96440u
		},
		{
			55611u,
			96936u
		},
		{
			55282u,
			97301u
		},
		{
			55023u,
			97496u
		},
		{
			54641u,
			97141u
		},
		{
			54442u,
			96730u
		}
	};

	private static uint[,] uint_23 = new uint[8, 2]
	{
		{
			52241u,
			98024u
		},
		{
			52722u,
			97460u
		},
		{
			53128u,
			96902u
		},
		{
			52882u,
			96109u
		},
		{
			53217u,
			95656u
		},
		{
			53718u,
			96129u
		},
		{
			54164u,
			96624u
		},
		{
			54462u,
			96720u
		}
	};

	private static uint[,] uint_24 = new uint[8, 2]
	{
		{
			55721u,
			95926u
		},
		{
			55234u,
			95406u
		},
		{
			54940u,
			95180u
		},
		{
			54554u,
			95613u
		},
		{
			54120u,
			96066u
		},
		{
			53889u,
			96360u
		},
		{
			54274u,
			96770u
		},
		{
			54460u,
			96706u
		}
	};

	private static uint[,] uint_25 = new uint[20, 2]
	{
		{
			51106u,
			102662u
		},
		{
			51890u,
			101772u
		},
		{
			52376u,
			102242u
		},
		{
			52786u,
			101793u
		},
		{
			53222u,
			101329u
		},
		{
			53632u,
			100905u
		},
		{
			54120u,
			100423u
		},
		{
			54571u,
			99972u
		},
		{
			55026u,
			99486u
		},
		{
			55380u,
			99103u
		},
		{
			55818u,
			98641u
		},
		{
			56167u,
			98292u
		},
		{
			56328u,
			98166u
		},
		{
			56807u,
			97678u
		},
		{
			56283u,
			97102u
		},
		{
			55897u,
			96712u
		},
		{
			55593u,
			96982u
		},
		{
			55058u,
			97502u
		},
		{
			54762u,
			97176u
		},
		{
			54448u,
			96728u
		}
	};

	private static uint[,] uint_26 = new uint[20, 2]
	{
		{
			54034u,
			103140u
		},
		{
			54574u,
			103722u
		},
		{
			54957u,
			103306u
		},
		{
			55348u,
			102858u
		},
		{
			54910u,
			102414u
		},
		{
			54326u,
			101850u
		},
		{
			54086u,
			101594u
		},
		{
			53603u,
			101066u
		},
		{
			54092u,
			100564u
		},
		{
			54599u,
			99976u
		},
		{
			54898u,
			99658u
		},
		{
			54571u,
			99212u
		},
		{
			54274u,
			98940u
		},
		{
			53957u,
			98636u
		},
		{
			54383u,
			98206u
		},
		{
			54871u,
			97755u
		},
		{
			55080u,
			97490u
		},
		{
			54608u,
			97062u
		},
		{
			54582u,
			97038u
		},
		{
			54432u,
			96684u
		}
	};

	private static uint[,] uint_27 = new uint[15, 2]
	{
		{
			55218u,
			101522u
		},
		{
			55701u,
			101026u
		},
		{
			56345u,
			100308u
		},
		{
			56875u,
			99734u
		},
		{
			57366u,
			99150u
		},
		{
			56887u,
			98775u
		},
		{
			56647u,
			98516u
		},
		{
			56330u,
			98132u
		},
		{
			56860u,
			97596u
		},
		{
			56403u,
			97196u
		},
		{
			55911u,
			96634u
		},
		{
			55597u,
			96958u
		},
		{
			55020u,
			97552u
		},
		{
			54674u,
			97115u
		},
		{
			54456u,
			96718u
		}
	};

	private static uint[,] uint_28 = new uint[11, 2]
	{
		{
			51420u,
			101312u
		},
		{
			52001u,
			100707u
		},
		{
			52554u,
			100082u
		},
		{
			53050u,
			99651u
		},
		{
			53426u,
			99302u
		},
		{
			53869u,
			98842u
		},
		{
			54221u,
			98458u
		},
		{
			54587u,
			98056u
		},
		{
			55044u,
			97538u
		},
		{
			54788u,
			97236u
		},
		{
			54461u,
			96732u
		}
	};

	private static GStruct17[] gstruct17_4 = new GStruct17[7]
	{
		new GStruct17
		{
			uint_0 = uint_22
		},
		new GStruct17
		{
			uint_0 = uint_23
		},
		new GStruct17
		{
			uint_0 = uint_24
		},
		new GStruct17
		{
			uint_0 = uint_25
		},
		new GStruct17
		{
			uint_0 = uint_26
		},
		new GStruct17
		{
			uint_0 = uint_27
		},
		new GStruct17
		{
			uint_0 = uint_28
		}
	};

	private static uint[,] uint_29 = new uint[20, 2]
	{
		{
			60289u,
			93226u
		},
		{
			59871u,
			93584u
		},
		{
			59634u,
			93880u
		},
		{
			59129u,
			94382u
		},
		{
			58813u,
			94784u
		},
		{
			58543u,
			94522u
		},
		{
			58047u,
			94084u
		},
		{
			57633u,
			94492u
		},
		{
			57165u,
			94949u
		},
		{
			56796u,
			95318u
		},
		{
			56324u,
			95789u
		},
		{
			55975u,
			96138u
		},
		{
			55524u,
			96589u
		},
		{
			55053u,
			97060u
		},
		{
			54895u,
			97260u
		},
		{
			55255u,
			97596u
		},
		{
			55622u,
			97967u
		},
		{
			56064u,
			98452u
		},
		{
			56719u,
			99016u
		},
		{
			57130u,
			99322u
		}
	};

	private static uint[,] uint_30 = new uint[14, 2]
	{
		{
			59392u,
			94912u
		},
		{
			59333u,
			95322u
		},
		{
			59655u,
			95596u
		},
		{
			60084u,
			96028u
		},
		{
			60440u,
			96390u
		},
		{
			60330u,
			96834u
		},
		{
			59797u,
			97315u
		},
		{
			59334u,
			97790u
		},
		{
			58856u,
			98192u
		},
		{
			58439u,
			98669u
		},
		{
			58119u,
			99041u
		},
		{
			57681u,
			99479u
		},
		{
			57405u,
			99744u
		},
		{
			57125u,
			99342u
		}
	};

	private static uint[,] uint_31 = new uint[18, 2]
	{
		{
			50834u,
			95948u
		},
		{
			51162u,
			96254u
		},
		{
			51588u,
			96688u
		},
		{
			51863u,
			96927u
		},
		{
			52315u,
			97408u
		},
		{
			52495u,
			97578u
		},
		{
			52897u,
			97164u
		},
		{
			53300u,
			96709u
		},
		{
			53603u,
			96373u
		},
		{
			53893u,
			96170u
		},
		{
			54267u,
			96509u
		},
		{
			54707u,
			96965u
		},
		{
			55172u,
			97442u
		},
		{
			55605u,
			97873u
		},
		{
			56189u,
			98477u
		},
		{
			56536u,
			98827u
		},
		{
			56757u,
			99057u
		},
		{
			57159u,
			99332u
		}
	};

	private static uint[,] uint_32 = new uint[16, 2]
	{
		{
			54666u,
			103430u
		},
		{
			54247u,
			102974u
		},
		{
			54656u,
			102508u
		},
		{
			55103u,
			102036u
		},
		{
			54775u,
			101708u
		},
		{
			54324u,
			101257u
		},
		{
			53801u,
			100678u
		},
		{
			54310u,
			100205u
		},
		{
			54881u,
			99590u
		},
		{
			55209u,
			99262u
		},
		{
			55422u,
			99042u
		},
		{
			55830u,
			98590u
		},
		{
			56001u,
			98366u
		},
		{
			56409u,
			98686u
		},
		{
			56724u,
			99008u
		},
		{
			57138u,
			99316u
		}
	};

	private static uint[,] uint_33 = new uint[17, 2]
	{
		{
			53869u,
			103290u
		},
		{
			53503u,
			103630u
		},
		{
			53036u,
			103094u
		},
		{
			53352u,
			102724u
		},
		{
			52974u,
			102366u
		},
		{
			52486u,
			101880u
		},
		{
			52949u,
			101402u
		},
		{
			53433u,
			100946u
		},
		{
			53896u,
			100510u
		},
		{
			54323u,
			100119u
		},
		{
			54811u,
			99623u
		},
		{
			55255u,
			99186u
		},
		{
			55563u,
			98878u
		},
		{
			56013u,
			98388u
		},
		{
			56348u,
			98526u
		},
		{
			56732u,
			99034u
		},
		{
			57148u,
			99312u
		}
	};

	private static uint[,] uint_34 = new uint[8, 2]
	{
		{
			56430u,
			96284u
		},
		{
			56697u,
			96620u
		},
		{
			56826u,
			97038u
		},
		{
			56702u,
			97574u
		},
		{
			56706u,
			98258u
		},
		{
			56311u,
			98654u
		},
		{
			56730u,
			99042u
		},
		{
			57114u,
			99328u
		}
	};

	private static uint[,] uint_35 = new uint[19, 2]
	{
		{
			52067u,
			98030u
		},
		{
			51625u,
			98448u
		},
		{
			51052u,
			98995u
		},
		{
			50841u,
			99236u
		},
		{
			51199u,
			99573u
		},
		{
			51691u,
			100065u
		},
		{
			52129u,
			100510u
		},
		{
			52601u,
			100981u
		},
		{
			52937u,
			101318u
		},
		{
			53234u,
			101380u
		},
		{
			53691u,
			100859u
		},
		{
			54265u,
			100245u
		},
		{
			54846u,
			99680u
		},
		{
			55287u,
			99218u
		},
		{
			55626u,
			98822u
		},
		{
			56089u,
			98402u
		},
		{
			56408u,
			98688u
		},
		{
			56736u,
			99056u
		},
		{
			57108u,
			99312u
		}
	};

	private static uint[,] uint_36 = new uint[12, 2]
	{
		{
			52745u,
			97892u
		},
		{
			53118u,
			98257u
		},
		{
			53581u,
			98736u
		},
		{
			53916u,
			99096u
		},
		{
			54384u,
			99571u
		},
		{
			54672u,
			99860u
		},
		{
			55032u,
			99484u
		},
		{
			55575u,
			98881u
		},
		{
			56115u,
			98410u
		},
		{
			56395u,
			98660u
		},
		{
			56716u,
			99030u
		},
		{
			57122u,
			99338u
		}
	};

	private static uint[,] uint_37 = new uint[11, 2]
	{
		{
			55524u,
			101682u
		},
		{
			55959u,
			101184u
		},
		{
			55550u,
			100678u
		},
		{
			54963u,
			100119u
		},
		{
			54685u,
			99866u
		},
		{
			55200u,
			99279u
		},
		{
			55603u,
			98788u
		},
		{
			56023u,
			98358u
		},
		{
			56428u,
			98686u
		},
		{
			56724u,
			99006u
		},
		{
			57106u,
			99348u
		}
	};

	private static uint[,] uint_38 = new uint[7, 2]
	{
		{
			55152u,
			98744u
		},
		{
			55412u,
			98472u
		},
		{
			55706u,
			98746u
		},
		{
			56076u,
			98382u
		},
		{
			56456u,
			98738u
		},
		{
			56736u,
			99036u
		},
		{
			57142u,
			99340u
		}
	};

	private static GStruct17[] gstruct17_5 = new GStruct17[10]
	{
		new GStruct17
		{
			uint_0 = uint_29
		},
		new GStruct17
		{
			uint_0 = uint_30
		},
		new GStruct17
		{
			uint_0 = uint_31
		},
		new GStruct17
		{
			uint_0 = uint_32
		},
		new GStruct17
		{
			uint_0 = uint_33
		},
		new GStruct17
		{
			uint_0 = uint_34
		},
		new GStruct17
		{
			uint_0 = uint_35
		},
		new GStruct17
		{
			uint_0 = uint_36
		},
		new GStruct17
		{
			uint_0 = uint_37
		},
		new GStruct17
		{
			uint_0 = uint_38
		}
	};

	private static GStruct17[] gstruct17_6 = new GStruct17[10]
	{
		new GStruct17
		{
			uint_0 = uint_29
		},
		new GStruct17
		{
			uint_0 = uint_30
		},
		new GStruct17
		{
			uint_0 = uint_31
		},
		new GStruct17
		{
			uint_0 = uint_32
		},
		new GStruct17
		{
			uint_0 = uint_33
		},
		new GStruct17
		{
			uint_0 = uint_34
		},
		new GStruct17
		{
			uint_0 = uint_35
		},
		new GStruct17
		{
			uint_0 = uint_36
		},
		new GStruct17
		{
			uint_0 = uint_37
		},
		new GStruct17
		{
			uint_0 = uint_38
		}
	};

	private static uint[,] uint_39 = new uint[27, 2]
	{
		{
			54389u,
			105766u
		},
		{
			53940u,
			105313u
		},
		{
			53614u,
			105118u
		},
		{
			53273u,
			104804u
		},
		{
			52804u,
			104322u
		},
		{
			52352u,
			103833u
		},
		{
			52104u,
			103624u
		},
		{
			51786u,
			104124u
		},
		{
			51253u,
			104698u
		},
		{
			50718u,
			105198u
		},
		{
			50114u,
			105781u
		},
		{
			49532u,
			106387u
		},
		{
			48966u,
			106964u
		},
		{
			48779u,
			107178u
		},
		{
			48384u,
			106679u
		},
		{
			47814u,
			106101u
		},
		{
			47343u,
			105629u
		},
		{
			46871u,
			105157u
		},
		{
			46297u,
			104583u
		},
		{
			45953u,
			104231u
		},
		{
			45360u,
			103634u
		},
		{
			44889u,
			103163u
		},
		{
			44438u,
			102712u
		},
		{
			43950u,
			102216u
		},
		{
			43501u,
			101763u
		},
		{
			43205u,
			101418u
		},
		{
			42832u,
			101312u
		}
	};

	private static uint[,] uint_40 = new uint[18, 2]
	{
		{
			47362u,
			110018u
		},
		{
			48244u,
			108934u
		},
		{
			47669u,
			108404u
		},
		{
			47077u,
			107807u
		},
		{
			46728u,
			107459u
		},
		{
			46154u,
			106884u
		},
		{
			45682u,
			106413u
		},
		{
			45334u,
			106064u
		},
		{
			44985u,
			105716u
		},
		{
			44534u,
			105265u
		},
		{
			44063u,
			104793u
		},
		{
			43570u,
			104301u
		},
		{
			43242u,
			103973u
		},
		{
			42773u,
			103499u
		},
		{
			42404u,
			103130u
		},
		{
			42415u,
			102240u
		},
		{
			42863u,
			101803u
		},
		{
			42883u,
			101282u
		}
	};

	private static uint[,] uint_41 = new uint[16, 2]
	{
		{
			45545u,
			93956u
		},
		{
			44901u,
			94563u
		},
		{
			44365u,
			95224u
		},
		{
			43899u,
			95822u
		},
		{
			43785u,
			96294u
		},
		{
			43439u,
			96604u
		},
		{
			42947u,
			97094u
		},
		{
			43474u,
			97611u
		},
		{
			44425u,
			98534u
		},
		{
			44816u,
			98919u
		},
		{
			45152u,
			99388u
		},
		{
			44693u,
			99854u
		},
		{
			44129u,
			100405u
		},
		{
			43717u,
			100908u
		},
		{
			43003u,
			101572u
		},
		{
			42857u,
			101366u
		}
	};

	private static uint[,] uint_42 = new uint[11, 2]
	{
		{
			42902u,
			98020u
		},
		{
			42469u,
			98481u
		},
		{
			41959u,
			98951u
		},
		{
			41673u,
			99308u
		},
		{
			41927u,
			99592u
		},
		{
			42377u,
			100082u
		},
		{
			42952u,
			100637u
		},
		{
			43234u,
			100927u
		},
		{
			43495u,
			101216u
		},
		{
			43048u,
			101612u
		},
		{
			42831u,
			101342u
		}
	};

	private static uint[,] uint_43 = new uint[38, 2]
	{
		{
			53939u,
			103370u
		},
		{
			53413u,
			102873u
		},
		{
			53208u,
			102618u
		},
		{
			53753u,
			102101u
		},
		{
			54187u,
			101635u
		},
		{
			54696u,
			101162u
		},
		{
			55151u,
			100678u
		},
		{
			55644u,
			100238u
		},
		{
			56086u,
			99788u
		},
		{
			55661u,
			99439u
		},
		{
			55122u,
			98956u
		},
		{
			54669u,
			98507u
		},
		{
			54179u,
			98013u
		},
		{
			53748u,
			97582u
		},
		{
			53256u,
			97090u
		},
		{
			52908u,
			96742u
		},
		{
			52588u,
			96406u
		},
		{
			52120u,
			95893u
		},
		{
			51671u,
			95440u
		},
		{
			51286u,
			95088u
		},
		{
			50790u,
			94644u
		},
		{
			50484u,
			94268u
		},
		{
			49844u,
			94622u
		},
		{
			49478u,
			95050u
		},
		{
			48746u,
			95693u
		},
		{
			48294u,
			96167u
		},
		{
			47836u,
			96606u
		},
		{
			47270u,
			97220u
		},
		{
			46919u,
			97555u
		},
		{
			46309u,
			98133u
		},
		{
			45980u,
			98449u
		},
		{
			45536u,
			98945u
		},
		{
			45001u,
			99516u
		},
		{
			44548u,
			99954u
		},
		{
			44087u,
			100386u
		},
		{
			43614u,
			100895u
		},
		{
			43055u,
			101446u
		},
		{
			42813u,
			101330u
		}
	};

	private static GStruct17[] gstruct17_7 = new GStruct17[5]
	{
		new GStruct17
		{
			uint_0 = uint_39
		},
		new GStruct17
		{
			uint_0 = uint_40
		},
		new GStruct17
		{
			uint_0 = uint_41
		},
		new GStruct17
		{
			uint_0 = uint_42
		},
		new GStruct17
		{
			uint_0 = uint_43
		}
	};

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static int smethod_0(GStruct42 gstruct42_0)
	{
		if (gstruct42_0.bool_24)
		{
			return 0;
		}
		int int_ = gstruct42_0.int_129;
		int num = -3;
		int num2 = 0;
		int num3 = -1;
		bool flag = false;
		bool flag2 = false;
		string string_ = "Thæ ®Þa phï|Håi thµnh phï|ÍÁµØ·û";
		string text = "Chñ tiÖm t¹p hãa|T¹p Hãa|t¹p hãa";
		string[] array = text.Split('|');
		int num4 = 0;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		int num5 = -1;
		GStruct1[] array2 = null;
		while (true)
		{
			Thread.Sleep(300);
			int num6 = Class71.smethod_3(FormMain.gstruct42_0, int_);
			uint num10;
			int num23;
			uint[] array5;
			uint[] array3;
			if (!Class11.bool_0 && num6 >= 0 && FormMain.gstruct42_0[num6].bool_36)
			{
				if (FormMain.int_53[0] != 0 && FormMain.int_53[1] != 0)
				{
					try
					{
						FormMain.gstruct42_0[num6].bool_24 = true;
						gstruct42_0 = FormMain.gstruct42_0[num6];
					}
					catch
					{
					}
					uint num7 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
					uint num8 = Class20.smethod_30(num7 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
					uint num9 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
					num10 = num9 + num8;
					int num11 = (int)Class20.smethod_30(num10 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
					int num12 = (int)Class20.smethod_30(num10 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
					int num13 = (int)Class20.smethod_30(num10 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
					int num14 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
					int num15 = Class73.smethod_40(gstruct42_0);
					if (num12 != 0 && num11 != 0 && num15 > 1)
					{
						array3 = new uint[2]
						{
							Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						if (array3[0] == 0 || array3[1] == 0)
						{
							continue;
						}
						int num16 = Class69.smethod_31(gstruct42_0, string_);
						if (num16 <= 0)
						{
							if (num11 != 10 && num11 != 21 && num13 <= 0)
							{
								int[] array4 = Class53.smethod_7(num14);
								if (array4 != null)
								{
									int num17 = Class69.smethod_21(gstruct42_0);
									if (num17 != 0)
									{
										int num18 = FormMain.int_53[1];
										if (!flag2)
										{
											Class39.smethod_12(gstruct42_0);
											flag2 = true;
										}
										if (num18 > num17)
										{
											num18 = num17;
										}
										if (num3 == num18 && 0 < num3)
										{
											Class39.smethod_12(gstruct42_0);
											num2 = 0;
											num3 = 0;
											flag = false;
											continue;
										}
										int num19 = (int)Class32.smethod_42(gstruct42_0);
										if (num19 < 2500)
										{
											uint num20 = Class32.smethod_42(gstruct42_0, bool_0: true);
											if (num20 > 20000)
											{
												num20 = 20000u;
											}
											if (num20 != 0)
											{
												Class60.smethod_35(gstruct42_0, num20);
												Thread.Sleep(300);
											}
										}
										int num22;
										if (flag)
										{
											if (!Class39.smethod_9(gstruct42_0))
											{
												flag = false;
												num2 = 0;
												continue;
											}
											flag4 = true;
											num3 = num18;
											if (!gstruct42_0.bool_22)
											{
												num6 = Class71.smethod_3(FormMain.gstruct42_0, int_);
												if (0 <= num6)
												{
													FormMain.gstruct42_0[num6].bool_22 = true;
												}
												gstruct42_0.bool_22 = true;
											}
											if (num5 < 0 && array2 == null)
											{
												array2 = Class15.smethod_1(gstruct42_0);
												if (array2 != null)
												{
													string text2 = "Thæ ®Þa phï".ToUpper();
													string text3 = "Thæ §Þa Phï".ToUpper();
													int num21 = -1;
													num22 = 0;
													while (true)
													{
														if (num22 < array2.Length)
														{
															string text4 = array2[num22].string_0.ToUpper().Trim();
															if (0 <= Class11.smethod_2(text4, text2) || 0 <= Class11.smethod_2(text4, text3))
															{
																num21 = num22;
															}
															if (!(text2 == text4) && !(text3 == text4))
															{
																num22++;
																continue;
															}
															num5 = num22;
															break;
														}
														if (num5 < 0)
														{
															num5 = num21;
															if (num5 < 0)
															{
																num5 = 0;
															}
														}
														break;
													}
												}
												else
												{
													num5 = 0;
												}
											}
											for (int i = 0; i < num18; i++)
											{
												Class60.smethod_39(gstruct42_0, num5);
												Thread.Sleep(300);
												if (i % 3 != 0)
												{
													continue;
												}
												string string_2 = Class46.smethod_2(gstruct42_0);
												if (Class11.smethod_2(string_2, "tói kh«ng ®ñ") > 0 && Class69.smethod_21(gstruct42_0) == 0)
												{
													goto IL_0bd6;
												}
												if (Class11.smethod_2(string_2, "µng kh«ng ®ñ") <= 0)
												{
													continue;
												}
												goto IL_0bda;
											}
											continue;
										}
										num23 = -1;
										array5 = null;
										num23 = Class86.smethod_12(gstruct42_0, text, 3);
										if (num23 > 0)
										{
											array5 = Class86.smethod_18(gstruct42_0, num23);
											Class86.smethod_21(gstruct42_0, num23, 3);
											goto IL_04d5;
										}
										string object_ = Class20.smethod_28(gstruct42_0.uint_6 + Class47.gstruct43_28.uint_0 + Class47.gstruct43_29.uint_0, gstruct42_0.int_130, 30);
										num22 = 0;
										while (num22 < array.Length)
										{
											array5 = Class37.smethod_9(array3, object_, array[num22], bool_0: false);
											if (array5 == null)
											{
												num22++;
												continue;
											}
											goto IL_04d5;
										}
										num = -3;
										break;
									}
									num = 3;
									break;
								}
								if (!flag5)
								{
									Class31.smethod_61(gstruct42_0, 1, "am");
									Thread.Sleep(300);
									flag5 = true;
									continue;
								}
								num = -2;
								break;
							}
							num = 0;
							break;
						}
						num = (flag4 ? 1 : 2);
						break;
					}
					num = 0;
					break;
				}
				num = 2;
				break;
			}
			num = 0;
			break;
			IL_0bda:
			num = 1;
			break;
			IL_0bde:
			num = 0;
			break;
			IL_0bd6:
			num = 1;
			break;
			IL_04d5:
			Class76.Class79.smethod_5(gstruct42_0);
			Class76.smethod_9(gstruct42_0);
			if (array5 != null)
			{
				long num24 = Class53.smethod_18(array3, array5);
				if (num24 > 22500L || num23 <= 0)
				{
					int num14 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
					array3 = new uint[2]
					{
						Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
						Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
					};
					if (!flag6 || Class11.smethod_23(long_) >= 8000L)
					{
						flag6 = false;
						uint[,] array6 = null;
						switch (num14)
						{
						case 78:
							array6 = Class37.smethod_8(gstruct17_1, array3, array5);
							break;
						case 1:
							array6 = Class37.smethod_8(gstruct17_2, array3, array5);
							break;
						case 162:
							array6 = Class37.smethod_8(gstruct17_3, array3, array5);
							break;
						case 80:
							array6 = Class37.smethod_8(gstruct17_4, array3, array5);
							break;
						case 176:
							array6 = Class37.smethod_8(gstruct17_7, array3, array5);
							break;
						case 999:
							array6 = Class37.smethod_8(gstruct17_6, array3, array5);
							break;
						case 37:
							array6 = Class37.smethod_8(gstruct17_5, array3, array5);
							break;
						case 11:
							array6 = Class37.smethod_8(gstruct17_0, array3, array5);
							break;
						}
						if (array6 != null)
						{
							if (Class20.smethod_30(num10 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) == 0 && gstruct42_0.bool_64 && Class11.smethod_23(long_3) > 600L)
							{
								Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
								long_3 = Class11.smethod_22();
							}
							num14 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
							int num22 = 0;
							while (num22 < 3)
							{
								array3 = new uint[2]
								{
									Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
									Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
								};
								if (Class53.smethod_22(gstruct42_0, array6, array3, array5, num14, bool_0: true) <= 0)
								{
									int num13 = (int)Class20.smethod_30(num10 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
									if (num13 <= 0)
									{
										Thread.Sleep(300);
										num22++;
										continue;
									}
									goto IL_0bde;
								}
								flag6 = true;
								long_ = Class11.smethod_22();
								break;
							}
						}
					}
					array3 = new uint[2]
					{
						Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
						Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
					};
					num24 = Class53.smethod_18(array3, array5);
					if (num24 > 90000L)
					{
						if (Class20.smethod_30(num10 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) == 0 && gstruct42_0.bool_64 && Class11.smethod_23(long_3) > 600L)
						{
							Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
							long_3 = Class11.smethod_22();
						}
						if (Class11.smethod_23(long_2) >= 3000L)
						{
							long_2 = Class11.smethod_22();
							if (Class12.smethod_1(gstruct42_0, array5) <= 0)
							{
								Class53.smethod_10(gstruct42_0);
							}
						}
						continue;
					}
				}
				for (int j = 0; j < 10; j++)
				{
					Class60.smethod_61(gstruct42_0, array5);
					Thread.Sleep(300);
					array3 = new uint[2]
					{
						Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
						Class20.smethod_30(num10 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
					};
					num24 = Class53.smethod_18(array3, array5);
					if (num24 < 11250L)
					{
						break;
					}
				}
				num2++;
				if (num2 <= 10)
				{
					if (Class76.Class79.smethod_4(gstruct42_0))
					{
						Class76.Class79.smethod_5(gstruct42_0);
						Thread.Sleep(300);
					}
					if (Class76.smethod_0(gstruct42_0))
					{
						Class76.smethod_9(gstruct42_0);
						Thread.Sleep(300);
					}
					if (num23 <= 0)
					{
						num23 = Class86.smethod_12(gstruct42_0, text, 3);
						if (num23 <= 0)
						{
							Class53.smethod_8(gstruct42_0, "Dang tim Chu tiem tap hoa !");
							continue;
						}
					}
					if (!flag3)
					{
						Class32.smethod_9(gstruct42_0, (uint)num23);
					}
					else
					{
						Class53.smethod_10(gstruct42_0);
						Class32.smethod_9(gstruct42_0, (uint)num23);
					}
					Thread.Sleep(800);
					if (Class76.Class79.smethod_4(gstruct42_0))
					{
						Class76.Class79.smethod_5(gstruct42_0);
					}
					if (Class76.smethod_0(gstruct42_0))
					{
						flag = (Class76.smethod_7(gstruct42_0, "Giao dÞch") > 0);
					}
					num4++;
					if (num4 > 3)
					{
						num4 = 0;
						flag3 = !flag3;
					}
					Thread.Sleep(300);
				}
				else
				{
					num2 = 0;
					Class53.smethod_10(gstruct42_0);
					Class53.smethod_8(gstruct42_0, "Dang tim Chu tiem tap hoa !");
				}
				continue;
			}
			num = -3;
			break;
		}
		if (flag2)
		{
			Class39.smethod_12(gstruct42_0);
			if (FormMain.int_55 > 0 || FormMain.int_57 > 0)
			{
				Class53.smethod_12(gstruct42_0, null, 0, 0, bool_0: false);
			}
		}
		if (gstruct42_0.int_129 > 0 && (gstruct42_0.bool_22 || gstruct42_0.bool_24))
		{
			int num6 = Class71.smethod_3(FormMain.gstruct42_0, int_);
			if (0 <= num6)
			{
				FormMain.gstruct42_0[num6].bool_22 = false;
				FormMain.gstruct42_0[num6].bool_24 = false;
			}
		}
		return num;
	}

	public static int smethod_1(GStruct42 gstruct42_0, int int_2 = 1)
	{
		if (!gstruct42_0.bool_24)
		{
			int int_3 = gstruct42_0.int_129;
			int num = 0;
			int num2 = 0;
			int num3 = -1;
			bool flag = false;
			bool flag2 = false;
			string string_ = "Tèng Kim Chiªu|Phong V©n Chiªu";
			string text = "Chñ tiÖm t¹p hãa|T¹p Hãa|t¹p hãa";
			string[] array = text.Split('|');
			int num4 = 0;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			long long_ = 0L;
			long long_2 = 0L;
			int num5 = 6000;
			int num6 = -1;
			GStruct1[] array2 = null;
			int num7;
			while (true)
			{
				Thread.Sleep(300);
				num7 = Class71.smethod_3(FormMain.gstruct42_0, int_3);
				uint num11;
				int num23;
				uint[] array5;
				uint[] array3;
				if (!Class11.bool_0 && num7 >= 0 && FormMain.gstruct42_0[num7].bool_36)
				{
					try
					{
						FormMain.gstruct42_0[num7].bool_24 = true;
						gstruct42_0 = FormMain.gstruct42_0[num7];
					}
					catch
					{
					}
					uint num8 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
					uint num9 = Class20.smethod_30(num8 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130) * Class47.gstruct43_15.uint_0;
					uint num10 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
					num11 = num10 + num9;
					int num12 = (int)Class20.smethod_30(num11 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
					int num13 = (int)Class20.smethod_30(num11 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
					int num14 = (int)Class20.smethod_30(num11 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
					int num15 = Class73.smethod_40(gstruct42_0);
					if (num13 != 0 && num12 != 0 && num15 > 1)
					{
						array3 = new uint[2]
						{
							Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						if (array3[0] == 0 || array3[1] == 0)
						{
							continue;
						}
						int num16 = Class69.smethod_31(gstruct42_0, string_);
						if (num16 <= 0)
						{
							if (num12 != 10 && num12 != 21 && num14 <= 0)
							{
								int num17 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
								int[] array4 = Class53.smethod_7(num17);
								if (array4 != null)
								{
									int num18 = Class69.smethod_21(gstruct42_0);
									if (num18 != 0)
									{
										if (array4[1] != 0)
										{
											int num19 = Class31.smethod_58(Class53.string_0[array4[0], 0]);
											if (0 <= num19)
											{
												string string_2 = Class31.struct16_0[num19].string_2;
												string string_3 = Class31.struct16_0[num19].string_0;
												if (!Class31.smethod_61(gstruct42_0, string_2, string_3))
												{
													Class44.smethod_7(gstruct42_0);
												}
											}
											Thread.Sleep(300);
											continue;
										}
										if (!flag2)
										{
											Class39.smethod_12(gstruct42_0);
											flag2 = true;
										}
										if (int_2 > num18)
										{
											int_2 = num18;
										}
										if (num3 == int_2 && 0 < num3)
										{
											Class39.smethod_12(gstruct42_0);
											num2 = 0;
											num3 = 0;
											flag = false;
											continue;
										}
										int num20 = (int)Class32.smethod_42(gstruct42_0);
										if (int_2 * num5 > num20)
										{
											int num21 = int_2 * num5 - num20;
											int num22 = (int)Class32.smethod_42(gstruct42_0, bool_0: true);
											if (num22 <= num21)
											{
												num21 = num22;
											}
											if (num21 + num20 < num5)
											{
												num = -1;
												break;
											}
											Class60.smethod_35(gstruct42_0, (uint)num21);
											Thread.Sleep(300);
										}
										if (!flag)
										{
											num23 = -1;
											array5 = null;
											num23 = Class86.smethod_12(gstruct42_0, text, 3);
											if (num23 <= 0)
											{
												int num24 = 0;
												while (num24 < array.Length)
												{
													array5 = Class37.smethod_9(array3, num17, array[num24], bool_0: false);
													if (array5 == null)
													{
														num24++;
														continue;
													}
													goto IL_0365;
												}
												num = -3;
												break;
											}
											array5 = Class86.smethod_18(gstruct42_0, num23);
											Class86.smethod_21(gstruct42_0, num23, 3);
											goto IL_0365;
										}
										if (Class39.smethod_9(gstruct42_0))
										{
											flag4 = true;
											num3 = int_2;
											if (!gstruct42_0.bool_22)
											{
												num7 = Class71.smethod_3(FormMain.gstruct42_0, int_3);
												if (0 <= num7)
												{
													FormMain.gstruct42_0[num7].bool_22 = true;
												}
											}
											if (num6 < 0 && array2 == null)
											{
												array2 = Class15.smethod_1(gstruct42_0);
												if (array2 == null)
												{
													num6 = 1;
												}
												else
												{
													string text2 = "Tèng Kim Chiªu th".ToUpper();
													string text3 = "Phong V©n Chiªu­ th".ToUpper();
													int num25 = -1;
													int num24 = 0;
													while (true)
													{
														if (num24 < array2.Length)
														{
															string text4 = array2[num24].string_0.ToUpper().Trim();
															if (0 <= Class11.smethod_2(text4, text2) || 0 <= Class11.smethod_2(text4, text3))
															{
																num25 = num24;
															}
															if (!(text2 == text4) && !(text3 == text4))
															{
																num24++;
																continue;
															}
															num6 = num24;
															break;
														}
														if (num6 < 0)
														{
															num6 = num25;
															if (num6 < 0)
															{
																num6 = 1;
															}
														}
														break;
													}
												}
											}
											for (int i = 0; i < int_2; i++)
											{
												Class60.smethod_39(gstruct42_0, num6);
												if (i % 3 != 0)
												{
													continue;
												}
												string string_4 = Class46.smethod_2(gstruct42_0);
												if (Class11.smethod_2(string_4, "tói kh«ng ®ñ") > 0 && Class69.smethod_21(gstruct42_0) == 0)
												{
													goto IL_0b6f;
												}
												if (Class11.smethod_2(string_4, "µng kh«ng ®ñ") <= 0)
												{
													continue;
												}
												goto IL_0b73;
											}
										}
										else
										{
											flag = false;
											num2 = 0;
										}
										continue;
									}
									num = 3;
									break;
								}
								if (Class31.struct16_0 != null && Class31.smethod_61(gstruct42_0, Class31.struct16_0[0].string_2, Class31.struct16_0[0].string_0))
								{
									Thread.Sleep(300);
									continue;
								}
								num = -2;
								break;
							}
							num = 0;
							break;
						}
						num = (flag4 ? 1 : 2);
						break;
					}
					num = 0;
					break;
				}
				num = 0;
				break;
				IL_0b6f:
				num = 1;
				break;
				IL_0b73:
				num = 1;
				break;
				IL_0365:
				Class76.Class79.smethod_5(gstruct42_0);
				Class76.smethod_9(gstruct42_0);
				if (array5 != null)
				{
					long num26 = Class53.smethod_18(array3, array5);
					if (num26 > 22500L || num23 <= 0)
					{
						int num17 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
						array3 = new uint[2]
						{
							Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						if (!flag5 || Class11.smethod_23(long_) >= 8000L)
						{
							flag5 = false;
							uint[,] array6 = null;
							switch (num17)
							{
							case 11:
								array6 = Class37.smethod_8(gstruct17_0, array3, array5);
								break;
							case 162:
								array6 = Class37.smethod_8(gstruct17_3, array3, array5);
								break;
							case 80:
								array6 = Class37.smethod_8(gstruct17_4, array3, array5);
								break;
							case 37:
								array6 = Class37.smethod_8(gstruct17_5, array3, array5);
								break;
							case 176:
								array6 = Class37.smethod_8(gstruct17_7, array3, array5);
								break;
							case 999:
								array6 = Class37.smethod_8(gstruct17_6, array3, array5);
								break;
							case 1:
								array6 = Class37.smethod_8(gstruct17_2, array3, array5);
								break;
							case 78:
								array6 = Class37.smethod_8(gstruct17_1, array3, array5);
								break;
							}
							if (array6 != null)
							{
								num17 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
								int num24 = 0;
								while (num24 < 3)
								{
									array3 = new uint[2]
									{
										Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
										Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
									};
									if (Class53.smethod_22(gstruct42_0, array6, array3, array5, num17, bool_0: true) <= 0)
									{
										int num14 = (int)Class20.smethod_30(num11 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
										if (num14 <= 0)
										{
											Thread.Sleep(300);
											num24++;
											continue;
										}
										goto IL_0b66;
									}
									flag5 = true;
									long_ = Class11.smethod_22();
									break;
								}
							}
						}
						array3 = new uint[2]
						{
							Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						num26 = Class53.smethod_18(array3, array5);
						if (num26 > 90000L)
						{
							if (Class11.smethod_23(long_2) >= 3000L)
							{
								long_2 = Class11.smethod_22();
								if (Class12.smethod_1(gstruct42_0, array5) <= 0)
								{
									Class53.smethod_10(gstruct42_0);
								}
							}
							continue;
						}
					}
					for (int j = 0; j < 10; j++)
					{
						Class60.smethod_61(gstruct42_0, array5);
						Thread.Sleep(300);
						array3 = new uint[2]
						{
							Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
							Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
						};
						num26 = Class53.smethod_18(array3, array5);
						if (num26 < 11250L)
						{
							break;
						}
					}
					num2++;
					if (num2 > 10)
					{
						num2 = 0;
						Class53.smethod_10(gstruct42_0);
						Class53.smethod_8(gstruct42_0, "Dang tim Chu tiem tap hoa !");
						continue;
					}
					if (Class76.Class79.smethod_4(gstruct42_0))
					{
						Class76.Class79.smethod_5(gstruct42_0);
						Thread.Sleep(300);
					}
					if (Class76.smethod_0(gstruct42_0))
					{
						Class76.smethod_9(gstruct42_0);
						Thread.Sleep(300);
					}
					if (num23 <= 0)
					{
						num23 = Class86.smethod_12(gstruct42_0, text, 3);
						if (num23 <= 0)
						{
							Class53.smethod_8(gstruct42_0, "Dang tim Chu tiem tap hoa !");
							continue;
						}
					}
					if (flag3)
					{
						Class53.smethod_10(gstruct42_0);
						Class32.smethod_9(gstruct42_0, (uint)num23);
					}
					else
					{
						Class32.smethod_9(gstruct42_0, (uint)num23);
					}
					Thread.Sleep(800);
					if (Class76.Class79.smethod_4(gstruct42_0))
					{
						Class76.Class79.smethod_5(gstruct42_0);
					}
					if (Class76.smethod_0(gstruct42_0))
					{
						flag = (Class76.smethod_7(gstruct42_0, "Giao dÞch") > 0);
					}
					Thread.Sleep(300);
					num4++;
					if (num4 > 3)
					{
						num4 = 0;
						flag3 = !flag3;
					}
					Thread.Sleep(300);
					continue;
				}
				num = -3;
				break;
				IL_0b66:
				num = 0;
				break;
			}
			num7 = Class71.smethod_3(FormMain.gstruct42_0, int_3);
			if (0 <= num7)
			{
				FormMain.gstruct42_0[num7].bool_22 = false;
				FormMain.gstruct42_0[num7].bool_24 = false;
			}
			if (flag2)
			{
				Class39.smethod_12(gstruct42_0);
			}
			return num;
		}
		return 0;
	}

	public static void smethod_2()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || flag2 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || !FormMain.gstruct42_0[num].bool_57)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_54 = false;
						FormMain.gstruct42_0[num].bool_57 = false;
						Class60.smethod_50(FormMain.gstruct42_0[num], "* MUA VAT PHAM KET THUC !");
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_54)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_54 = true;
					Class60.smethod_50(FormMain.gstruct42_0[num], "* BAT DAU MUA VAT PHAM");
					flag = true;
				}
				smethod_3(int_);
				flag2 = true;
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_3(int int_2)
	{
		int int_3 = 0;
		byte[] array = new byte[4];
		GStruct42 gStruct = default(GStruct42);
		Random random = new Random();
		int num = 0;
		int num2 = -1;
		int num3 = -1;
		int num4 = 0;
		int num5 = 0;
		string a = null;
		string empty = string.Empty;
		bool flag = false;
		long long_ = 0L;
		bool flag2 = false;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		while (true)
		{
			Thread.Sleep(300);
			int num9 = Class71.smethod_3(FormMain.gstruct42_0, int_2);
			if (Class11.bool_0 || num9 < 0 || !FormMain.gstruct42_0[num9].bool_36 || !FormMain.gstruct42_0[num9].bool_57)
			{
				break;
			}
			gStruct = FormMain.gstruct42_0[num9];
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_3);
			uint num10 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num10 + Class47.gstruct43_13.uint_0, array, 4, ref int_3);
			uint num11 = BitConverter.ToUInt32(array, 0) * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_3);
			uint num12 = BitConverter.ToUInt32(array, 0);
			uint num13 = num12 + num11;
			Class20.ReadProcessMemory(gStruct.int_130, num13 + Class47.gstruct43_50.uint_0, array, 4, ref int_3);
			int num14 = BitConverter.ToInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, num13 + Class47.gstruct43_55.uint_0, array, 4, ref int_3);
			int num15 = BitConverter.ToInt32(array, 0);
			int num16 = Class73.smethod_40(gStruct);
			if (num14 == 0 || num16 <= 1 || num15 == 0 || num15 == 10 || num15 == 21 || (gStruct.int_125[0] > 0 && gStruct.int_125[5] > 0))
			{
				continue;
			}
			uint[] array2 = new uint[2]
			{
				Class20.smethod_30(num13 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
				Class20.smethod_30(num13 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
			};
			if (array2[0] == 0 || array2[1] == 0)
			{
				continue;
			}
			if (FormMain.string_18 != null && !(FormMain.string_18 == string.Empty))
			{
				if (!(a != FormMain.string_18) && num3 == FormMain.int_66)
				{
					goto IL_0428;
				}
				Class39.smethod_22(gStruct);
				num2 = -1;
				num4 = 0;
				num5 = 0;
				num8 = 0;
				flag2 = (FormMain.int_68[0] > 0);
				num6 = FormMain.int_68[1];
				num7 = Class69.smethod_31(gStruct, FormMain.string_18, bool_1: true);
				string a2 = FormMain.string_18.ToLower().Trim();
				if (FormMain.int_66 <= 0)
				{
					GStruct1[] array3 = Class15.smethod_1(gStruct);
					if (array3 != null && array3.Length != 0)
					{
						for (int i = 0; i < array3.Length; i++)
						{
							string b = array3[i].string_0.ToLower().Trim();
							if (a2 == b)
							{
								num2 = i;
								a = FormMain.string_18;
								num3 = FormMain.int_66;
								break;
							}
						}
						goto IL_0428;
					}
					empty = "Ch­a më shop (t¹p hãa, ktc...)";
				}
				else
				{
					Struct25[] array4 = Class73.smethod_1(gStruct);
					if (array4 != null)
					{
						int num17 = -1;
						while (true)
						{
							num17++;
							if (array4.Length <= num17)
							{
								break;
							}
							Class60.smethod_25(gStruct, array4[num17].string_0);
							Thread.Sleep(300);
							Class60.smethod_26(gStruct);
							GStruct1[] array3 = Class15.smethod_1(gStruct);
							if (array3 == null || array3.Length == 0)
							{
								continue;
							}
							int i = 0;
							while (i < array3.Length)
							{
								string b = array3[i].string_0.ToLower().Trim();
								if (!(a2 == b))
								{
									i++;
									continue;
								}
								goto IL_03e5;
							}
							continue;
							IL_03e5:
							num2 = i;
							num4 = array3[i].int_1;
							a = FormMain.string_18;
							num3 = FormMain.int_66;
							num = array4[num17].int_0 - array4[0].int_0;
							break;
						}
						num17 = 0;
						goto IL_0428;
					}
					empty = "H·y më KTC lªn, n¬i cã b\u00b8n vËt phÈm.";
				}
			}
			else
			{
				empty = "Ch­a cã tªn vËt phÈm cÇn mua";
			}
			goto IL_0861;
			IL_0428:
			if (num2 >= 0)
			{
				if (FormMain.int_66 > 0 && num4 == 0 && !FormMain.bool_4)
				{
					if (num5 <= 0)
					{
						num5 = random.Next(100, 1000);
					}
					if (gStruct.int_124 != num5)
					{
						if (Class11.smethod_23(long_) > 15000L)
						{
							Class60.smethod_50(gStruct, "MUA <color=yellow>" + FormMain.string_18 + " <color>cÇn nhËp m· KTC lµ <color=yellow>" + num5 + "<color> vµo auto (phÝa trªn cña nót <color=green>Dõng<color>). L­u ý: ®iÒu nµy cã thÓ g©y diss game nªn ph¶i c©n nh¾c kü.");
							long_ = Class11.smethod_22();
						}
						empty = FormMain.string_18 + " cÇn nhËp m· KTC lµ " + num5 + ". Xem H­íng dÉn ë tÇng sè kh\u00b8c cña game.";
						goto IL_0861;
					}
				}
				Class39.smethod_22(gStruct);
				int j = 0;
				uint num18 = Class20.smethod_30(Class47.gstruct43_161.uint_0, gStruct.int_130);
				for (; j < 3; j++)
				{
					uint num19 = Class20.smethod_30(num18 + Class47.gstruct43_163.uint_0, gStruct.int_130);
					if (num19 != 0)
					{
						uint num20 = Class20.smethod_30((uint)((int)num19 + j * 4), gStruct.int_130);
						if (num20 != 0 && Class20.smethod_30(num20, gStruct.int_130) != 0)
						{
							Class60.smethod_12(gStruct.int_130, gStruct.uint_51);
							Thread.Sleep(100);
						}
					}
				}
				bool flag3 = false;
				int num21 = Class69.smethod_2(gStruct);
				for (int k = 1; k < 60; k++)
				{
					int num22 = Class69.smethod_2(gStruct);
					if (FormMain.int_66 > 0)
					{
						Class60.smethod_27(gStruct, num2, num);
					}
					else
					{
						Class60.smethod_39(gStruct, num2);
					}
					j = 0;
					int num23;
					for (num23 = 30; j < num23; j++)
					{
						if (Class69.smethod_2(gStruct) == num22)
						{
							Thread.Sleep(10);
							continue;
						}
						num6--;
						num8 = 0;
						break;
					}
					if (flag2 && num6 <= 0)
					{
						Class39.smethod_22(gStruct);
						int num24 = Class69.smethod_31(gStruct, FormMain.string_18, bool_1: true);
						int num25 = num24 - num7;
						num6 = FormMain.int_68[1] - num25;
						if (num6 <= 0)
						{
							flag3 = true;
							break;
						}
					}
					if (k % 7 != 0 && j < num23)
					{
						continue;
					}
					if (Class69.smethod_2(gStruct) == num21)
					{
						num8++;
						if (num8 > 3)
						{
							flag3 = true;
							break;
						}
					}
					num9 = Class71.smethod_3(FormMain.gstruct42_0, int_2);
					if (Class11.bool_0 || num9 < 0 || !FormMain.gstruct42_0[num9].bool_36 || !FormMain.gstruct42_0[num9].bool_57)
					{
						return;
					}
					uint num19 = Class20.smethod_30(num18 + Class47.gstruct43_163.uint_0, gStruct.int_130);
					if (num19 != 0)
					{
						uint num20 = Class20.smethod_30(num19, gStruct.int_130);
						if (num20 != 0 && Class20.smethod_30(num20, gStruct.int_130) != 0)
						{
							Class60.smethod_12(gStruct.int_130, gStruct.uint_51);
							break;
						}
					}
				}
				if (FormMain.int_67 > 0 && (!flag || Class69.smethod_2(gStruct) != num21))
				{
					j = 0;
					Class39.smethod_27(int_2, 1);
					while (!Class11.bool_0 && j < 1200)
					{
						if (j % 60 == 0)
						{
							num9 = Class71.smethod_3(FormMain.gstruct42_0, int_2);
							if (Class11.bool_0 || num9 < 0 || !FormMain.gstruct42_0[num9].bool_36 || !FormMain.gstruct42_0[num9].bool_57)
							{
								return;
							}
						}
						if (!FormMain.gstruct42_0[num9].bool_3)
						{
							break;
						}
						Thread.Sleep(10);
						j++;
					}
				}
				if (!flag3)
				{
					flag = true;
					continue;
				}
				break;
			}
			empty = "Kh«ng thÊy <" + FormMain.string_18 + "> trong shop";
			goto IL_0861;
			IL_0861:
			byte[] array5 = Class11.smethod_41(empty);
			for (int l = 0; l < 10; l++)
			{
				Class20.WriteProcessMemory(gStruct.int_130, num13 + Class47.gstruct43_253.uint_0, array5, array5.Length, ref int_3);
				Thread.Sleep(100);
			}
		}
	}

	public static void smethod_4()
	{
		int int_ = int_1;
		int_1 = 0;
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || flag2 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || !FormMain.gstruct42_0[num].bool_59)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_58 = false;
						FormMain.gstruct42_0[num].bool_59 = false;
						Class60.smethod_50(FormMain.gstruct42_0[num], "* SU DUNG KET THUC !");
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_58)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_58 = true;
					Class60.smethod_50(FormMain.gstruct42_0[num], "* SU DUNG ITEM");
					flag = true;
				}
				smethod_5(int_);
				flag2 = true;
			}
			catch
			{
			}
			Thread.Sleep(150);
		}
	}

	public static void smethod_5(int int_2)
	{
		int num = 0;
		uint num2 = 1u;
		int int_3 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[1];
		byte[] array3 = new byte[60];
		GStruct42 gStruct = default(GStruct42);
		int num3 = 0;
		int num4 = 0;
		int num5 = -1;
		int num6 = 0;
		while (true)
		{
			num3--;
			Thread.Sleep(40);
			if (num3 <= 0)
			{
				num4 = Class71.smethod_3(FormMain.gstruct42_0, int_2);
				if (Class11.bool_0 || num4 < 0)
				{
					break;
				}
				num3 = 8;
			}
			gStruct = FormMain.gstruct42_0[num4];
			if (!gStruct.bool_36 || !gStruct.bool_59)
			{
				break;
			}
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_102.uint_0, array, 4, ref int_3);
			uint num7 = BitConverter.ToUInt32(array, 0);
			Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_3);
			uint num8 = BitConverter.ToUInt32(array, 0) + Class47.gstruct43_94.uint_0;
			string b = FormMain.string_18.Trim().ToLower();
			int num9 = Class69.smethod_2(gStruct);
			if (num9 <= 0)
			{
				break;
			}
			if (FormMain.int_68[0] > 0 && num6 <= 0)
			{
				int num10 = Class69.smethod_31(gStruct, FormMain.string_18, bool_1: true);
				if (num5 < 0)
				{
					num5 = num10;
				}
				int num11 = num5 - num10;
				if (num11 > FormMain.int_68[1])
				{
					break;
				}
				num6 = FormMain.int_68[1] - num11;
				if (num6 <= 0)
				{
					break;
				}
			}
			int num12 = 0;
			uint num13 = num2;
			uint num14;
			int num17;
			int num18;
			int num19;
			while (true)
			{
				if (num13 >= Class47.int_1 || num9 <= num12)
				{
					return;
				}
				num14 = num7 + num13 * Class47.gstruct43_103.uint_0;
				Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_3);
				if (BitConverter.ToInt32(array, 0) == 0)
				{
					Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_104.uint_0, array, 1, ref int_3);
					if (array[0] != 0)
					{
						uint num15 = Class69.smethod_0(gStruct, num13);
						if (num15 != 0)
						{
							num12++;
							Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_105.uint_0, array, 4, ref int_3);
							if (BitConverter.ToInt32(array, 0) > 0)
							{
								uint num16 = num8 + num15 * 20;
								Class20.ReadProcessMemory(gStruct.int_130, num16 + Class47.gstruct43_97.uint_0 - 8, array, 4, ref int_3);
								num17 = BitConverter.ToInt32(array, 0);
								if (num17 == 3)
								{
									Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_104.uint_0, array3, array3.Length, ref int_3);
									string a = Class10.smethod_3(array3).Trim().ToLower();
									if (!(a != b))
									{
										Class20.ReadProcessMemory(gStruct.int_130, num16 + Class47.gstruct43_97.uint_0 - 4, array, 4, ref int_3);
										num18 = BitConverter.ToInt32(array, 0);
										if (num18 >= 0)
										{
											Class20.ReadProcessMemory(gStruct.int_130, num16 + Class47.gstruct43_97.uint_0, array, 4, ref int_3);
											num19 = BitConverter.ToInt32(array, 0);
											if (num19 >= 0)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
				}
				num13++;
			}
			num = 0;
			while (num < 30)
			{
				Class20.ReadProcessMemory(gStruct.int_130, gStruct.uint_41 - 4, array2, 1, ref int_3);
				if (array2[0] == 0)
				{
					break;
				}
				num++;
				Thread.Sleep(1);
			}
			Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_116.uint_0, array, 4, ref int_3);
			int num20 = BitConverter.ToInt32(array, 0);
			int num21 = Class69.smethod_2(gStruct);
			if (FormMain.int_69 > 0)
			{
				Class39.smethod_11(gStruct);
			}
			Class60.smethod_41(gStruct, num13, num18, num19, num17);
			for (num = 0; num < 8; num++)
			{
				if (num20 <= 0)
				{
					if (Class69.smethod_2(gStruct) != num21)
					{
						break;
					}
				}
				else
				{
					Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_116.uint_0, array, 4, ref int_3);
					if (BitConverter.ToInt32(array, 0) != num20)
					{
						break;
					}
				}
				Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_3);
				if (BitConverter.ToInt32(array, 0) != 0)
				{
					break;
				}
				Thread.Sleep(5);
			}
			if (FormMain.int_69 > 0)
			{
				Thread.Sleep(100);
				uint num22 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
				uint num23 = Class20.smethod_30(num22 + Class47.gstruct43_13.uint_0, gStruct.int_130);
				uint num24 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
				uint num25 = num24 + num23 * Class47.gstruct43_15.uint_0;
				byte[] array4 = null;
				bool flag = false;
				int num26 = 0;
				num = 0;
				while (num < 100)
				{
					num26 = Class39.smethod_10(gStruct);
					array4 = Class11.smethod_41(num26.ToString());
					Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_86.uint_0, array4, array4.Length, ref int_3);
					if (num26 <= 0)
					{
						num++;
						Thread.Sleep(10);
						continue;
					}
					flag = true;
					break;
				}
				num = 0;
				int num27 = -1;
				int num28 = 0;
				while (!Class11.bool_0 && flag && num < 1600)
				{
					Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_103.uint_0 - 4, array, 4, ref int_3);
					if (BitConverter.ToInt32(array, 0) != 0)
					{
						break;
					}
					Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_104.uint_0, array, 1, ref int_3);
					if (array[0] == 0)
					{
						break;
					}
					if (num20 > 0)
					{
						Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_116.uint_0, array, 4, ref int_3);
						if (BitConverter.ToInt32(array, 0) != num20)
						{
							break;
						}
					}
					num26 = Class39.smethod_10(gStruct);
					num28 = ((num27 == num26) ? (num28 + 1) : 0);
					num27 = num26;
					flag = (0 < num26 && num28 < 30);
					array4 = Class11.smethod_41((num26 + 11).ToString());
					Class20.WriteProcessMemory(gStruct.int_130, num25 + Class47.gstruct43_86.uint_0, array4, array4.Length, ref int_3);
					num++;
					Thread.Sleep(10);
				}
				Class20.ReadProcessMemory(gStruct.int_130, num14 + Class47.gstruct43_104.uint_0, array, 1, ref int_3);
				num20 = array[0];
			}
			num2 = num13 + Convert.ToByte(num20 <= 0);
			if (0 <= num6)
			{
				num6--;
			}
		}
	}
}
