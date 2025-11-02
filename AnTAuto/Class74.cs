internal class Class74
{
	public static GStruct17[] gstruct17_0 = null;

	public static GStruct17[] gstruct17_1 = null;

	public static uint[] smethod_0(uint[] uint_0)
	{
		if (gstruct17_1 == null)
		{
			gstruct17_1 = smethod_2();
		}
		int num = -1;
		long num2 = -1L;
		for (int i = 0; i < gstruct17_1.Length; i++)
		{
			long num3 = Class53.smethod_21(gstruct17_1[i].uint_0, uint_0);
			if (num < 0 || num3 < num2)
			{
				num = i;
				num2 = num3;
			}
		}
		switch (num)
		{
		case 2:
			return new uint[2]
			{
				49046u,
				99282u
			};
		default:
			return new uint[2]
			{
				52318u,
				98808u
			};
		case 1:
			return new uint[2]
			{
				49674u,
				104586u
			};
		case 0:
			return new uint[2]
			{
				52692u,
				103470u
			};
		}
	}

	public static GStruct17[] smethod_1()
	{
		uint[,] uint_ = new uint[12, 2]
		{
			{
				53118u,
				103962u
			},
			{
				52741u,
				103392u
			},
			{
				52101u,
				102992u
			},
			{
				51630u,
				102798u
			},
			{
				52032u,
				101696u
			},
			{
				51439u,
				101846u
			},
			{
				50751u,
				101556u
			},
			{
				50390u,
				100990u
			},
			{
				49926u,
				100850u
			},
			{
				49553u,
				100364u
			},
			{
				49413u,
				99762u
			},
			{
				49130u,
				99286u
			}
		};
		uint[,] uint_2 = new uint[10, 2]
		{
			{
				49052u,
				99122u
			},
			{
				49381u,
				99798u
			},
			{
				49944u,
				99656u
			},
			{
				50360u,
				98968u
			},
			{
				50818u,
				98448u
			},
			{
				51052u,
				98388u
			},
			{
				51426u,
				98833u
			},
			{
				51810u,
				99694u
			},
			{
				52057u,
				99388u
			},
			{
				52446u,
				98712u
			}
		};
		uint[,] uint_3 = new uint[15, 2]
		{
			{
				52443u,
				98564u
			},
			{
				52127u,
				99210u
			},
			{
				51821u,
				99642u
			},
			{
				51420u,
				100111u
			},
			{
				51044u,
				100420u
			},
			{
				50618u,
				100642u
			},
			{
				50268u,
				101036u
			},
			{
				50813u,
				101472u
			},
			{
				51186u,
				101802u
			},
			{
				51860u,
				101760u
			},
			{
				51866u,
				102540u
			},
			{
				51674u,
				102916u
			},
			{
				52237u,
				103074u
			},
			{
				52813u,
				103498u
			},
			{
				53151u,
				103968u
			}
		};
		uint[,] uint_4 = new uint[12, 2]
		{
			{
				53192u,
				104034u
			},
			{
				52772u,
				103400u
			},
			{
				53170u,
				102906u
			},
			{
				53358u,
				102308u
			},
			{
				52969u,
				102036u
			},
			{
				53588u,
				101748u
			},
			{
				53777u,
				101028u
			},
			{
				53387u,
				100557u
			},
			{
				52847u,
				100047u
			},
			{
				52474u,
				99950u
			},
			{
				51844u,
				99500u
			},
			{
				52384u,
				98790u
			}
		};
		uint[,] uint_5 = new uint[15, 2]
		{
			{
				52406u,
				98732u
			},
			{
				52126u,
				99254u
			},
			{
				51674u,
				99734u
			},
			{
				51277u,
				100166u
			},
			{
				50816u,
				100392u
			},
			{
				50442u,
				100852u
			},
			{
				50579u,
				101260u
			},
			{
				51014u,
				101652u
			},
			{
				51218u,
				102174u
			},
			{
				51458u,
				102694u
			},
			{
				51021u,
				103080u
			},
			{
				50773u,
				103500u
			},
			{
				50393u,
				103899u
			},
			{
				50074u,
				104034u
			},
			{
				49840u,
				104404u
			}
		};
		uint[,] uint_6 = new uint[9, 2]
		{
			{
				49788u,
				104464u
			},
			{
				50125u,
				103918u
			},
			{
				50574u,
				103672u
			},
			{
				51097u,
				104046u
			},
			{
				51610u,
				103849u
			},
			{
				52011u,
				104222u
			},
			{
				52458u,
				103760u
			},
			{
				52690u,
				103326u
			},
			{
				53068u,
				103880u
			}
		};
		uint[,] uint_7 = new uint[12, 2]
		{
			{
				49827u,
				104442u
			},
			{
				50149u,
				103932u
			},
			{
				50696u,
				103784u
			},
			{
				51034u,
				103229u
			},
			{
				51413u,
				102650u
			},
			{
				51577u,
				101939u
			},
			{
				51128u,
				101664u
			},
			{
				50517u,
				101246u
			},
			{
				50078u,
				101024u
			},
			{
				49616u,
				100524u
			},
			{
				49439u,
				99996u
			},
			{
				49050u,
				99178u
			}
		};
		return new GStruct17[7]
		{
			new GStruct17
			{
				uint_0 = uint_
			},
			new GStruct17
			{
				uint_0 = uint_2
			},
			new GStruct17
			{
				uint_0 = uint_3
			},
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
			}
		};
	}

	public static GStruct17[] smethod_2()
	{
		uint[,] uint_ = new uint[7, 2]
		{
			{
				55105u,
				101792u
			},
			{
				54917u,
				100482u
			},
			{
				54261u,
				99856u
			},
			{
				53536u,
				98792u
			},
			{
				52554u,
				98080u
			},
			{
				51647u,
				97343u
			},
			{
				50924u,
				96866u
			}
		};
		uint[,] uint_2 = new uint[7, 2]
		{
			{
				50447u,
				97378u
			},
			{
				49632u,
				97478u
			},
			{
				48780u,
				98450u
			},
			{
				47807u,
				99138u
			},
			{
				47507u,
				100446u
			},
			{
				46941u,
				101394u
			},
			{
				46739u,
				102120u
			}
		};
		uint[,] uint_3 = new uint[8, 2]
		{
			{
				46747u,
				103314u
			},
			{
				47776u,
				103405u
			},
			{
				48675u,
				104215u
			},
			{
				49473u,
				104877u
			},
			{
				49579u,
				105860u
			},
			{
				50457u,
				106219u
			},
			{
				51316u,
				106552u
			},
			{
				51908u,
				106804u
			}
		};
		uint[,] uint_4 = new uint[7, 2]
		{
			{
				52026u,
				106274u
			},
			{
				52699u,
				105849u
			},
			{
				53238u,
				104847u
			},
			{
				53652u,
				104071u
			},
			{
				53735u,
				103353u
			},
			{
				54489u,
				103052u
			},
			{
				55022u,
				102552u
			}
		};
		return new GStruct17[4]
		{
			new GStruct17
			{
				uint_0 = uint_4
			},
			new GStruct17
			{
				uint_0 = uint_3
			},
			new GStruct17
			{
				uint_0 = uint_2
			},
			new GStruct17
			{
				uint_0 = uint_
			}
		};
	}
}
