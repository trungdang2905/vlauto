using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

internal class Class11
{
	public static string char_0 = "9.99";

	public static char[] char_1 = new char[14]
	{
		'ᒦ',
		'ᓂ',
		'ᓐ',
		'ᓂ',
		'ᓜ',
		'ᓦ',
		'ᓯ',
		'ᓜ',
		'ᓇ',
		'ᓙ',
		'ᒥ',
		'ᓫ',
		'ᓯ',
		'ᓫ'
	};

	public static char[] char_2 = new char[25]
	{
		'ᒱ',
		'ᒳ',
		'ᓳ',
		'ᓷ',
		'ᓣ',
		'ᓰ',
		'ᓩ',
		'ᓥ',
		'ᓣ',
		'ᓱ',
		'ᒱ',
		'ᓍ',
		'ᓛ',
		'ᓓ',
		'ᓷ',
		'ᓣ',
		'ᓰ',
		'ᓩ',
		'ᓥ',
		'ᓣ',
		'ᓱ',
		'ᒰ',
		'ᓶ',
		'ᓺ',
		'ᓶ'
	};

	public static char[] char_3 = new char[22]
	{
		'ᒰ',
		'ᓰ',
		'ᓴ',
		'ᓠ',
		'ᓭ',
		'ᓦ',
		'ᓢ',
		'ᓠ',
		'ᓮ',
		'ᒮ',
		'ᓊ',
		'ᓘ',
		'ᓌ',
		'ᓠ',
		'ᓸ',
		'ᓯ',
		'ᓧ',
		'ᓴ',
		'ᒭ',
		'ᓳ',
		'ᓷ',
		'ᓳ'
	};

	public static int int_0 = 0;

	public static char[] char_4 = new char[7]
	{
		'ᓓ',
		'ᓝ',
		'ᓔ',
		'ᒞ',
		'ᓕ',
		'ᓨ',
		'ᓕ'
	};

	public static char[] char_5 = new char[7]
	{
		'ᒻ',
		'ᓉ',
		'ᒻ',
		'ᒵ',
		'ᒿ',
		'ᓈ',
		'ᒵ'
	};

	public static char[] char_6 = new char[8]
	{
		'ᒳ',
		'ᓀ',
		'ᓀ',
		'ᓅ',
		'ᓃ',
		'ᓀ',
		'ᓀ',
		'ᒾ'
	};

	public static char[] char_7 = new char[8]
	{
		'ᒡ',
		'ᒡ',
		'ᒡ',
		'ᒡ',
		'ᒡ',
		'ᒡ',
		'ᒡ',
		'ᒡ'
	};

	public static char[] char_8 = new char[88]
	{
		'ᔛ',
		'ᓹ',
		'ᔎ',
		'ᔅ',
		'ᔥ',
		'ᔲ',
		'ᔖ',
		'ᔇ',
		'ᔫ',
		'ᔬ',
		'ᔪ',
		'ᔑ',
		'ᔄ',
		'ᓶ',
		'ᔋ',
		'ᔦ',
		'ᔍ',
		'ᔣ',
		'ᔺ',
		'ᔙ',
		'ᔏ',
		'ᔑ',
		'ᔲ',
		'ᓳ',
		'ᓱ',
		'ᔹ',
		'ᔘ',
		'ᔇ',
		'ᓲ',
		'ᔉ',
		'ᔻ',
		'ᔌ',
		'ᔮ',
		'ᔈ',
		'ᔬ',
		'ᔓ',
		'ᔲ',
		'ᔖ',
		'ᔵ',
		'ᔴ',
		'ᔗ',
		'ᔄ',
		'ᔷ',
		'ᓱ',
		'ᔄ',
		'ᔌ',
		'ᔎ',
		'ᓺ',
		'ᔆ',
		'ᔓ',
		'ᔦ',
		'ᔗ',
		'ᔊ',
		'ᔤ',
		'ᔨ',
		'ᔥ',
		'ᔑ',
		'ᔉ',
		'ᔎ',
		'ᓺ',
		'ᔘ',
		'ᔈ',
		'ᔋ',
		'ᓰ',
		'ᔤ',
		'ᔑ',
		'ᔥ',
		'ᓰ',
		'ᔴ',
		'ᓴ',
		'ᔊ',
		'ᔖ',
		'ᔰ',
		'ᔬ',
		'ᔣ',
		'ᔳ',
		'ᔔ',
		'ᓷ',
		'ᔻ',
		'ᔶ',
		'ᔌ',
		'ᔹ',
		'ᔚ',
		'ᔏ',
		'ᔆ',
		'ᔒ',
		'ᓾ',
		'ᓾ'
	};

	public static char[] char_9 = new char[88]
	{
		'ᔑ',
		'ᔘ',
		'ᔗ',
		'ᔲ',
		'ᓶ',
		'ᓴ',
		'ᓳ',
		'ᔏ',
		'ᔑ',
		'ᓲ',
		'ᔲ',
		'ᔪ',
		'ᔐ',
		'ᔘ',
		'ᓷ',
		'ᔘ',
		'ᔐ',
		'ᔌ',
		'ᓳ',
		'ᓬ',
		'ᔳ',
		'ᔳ',
		'ᔹ',
		'ᓱ',
		'ᔫ',
		'ᔭ',
		'ᔃ',
		'ᔋ',
		'ᔦ',
		'ᔸ',
		'ᓸ',
		'ᔬ',
		'ᔍ',
		'ᔄ',
		'ᔣ',
		'ᔐ',
		'ᔙ',
		'ᔪ',
		'ᔉ',
		'ᓳ',
		'ᔌ',
		'ᔬ',
		'ᔖ',
		'ᔗ',
		'ᔪ',
		'ᓹ',
		'ᓹ',
		'ᔊ',
		'ᔳ',
		'ᔕ',
		'ᔺ',
		'ᔦ',
		'ᔳ',
		'ᔰ',
		'ᔨ',
		'ᔈ',
		'ᔲ',
		'ᓱ',
		'ᔭ',
		'ᔪ',
		'ᔬ',
		'ᔚ',
		'ᔨ',
		'ᔲ',
		'ᔰ',
		'ᓺ',
		'ᓳ',
		'ᔂ',
		'ᔈ',
		'ᓵ',
		'ᔑ',
		'ᔧ',
		'ᔈ',
		'ᔑ',
		'ᔰ',
		'ᓳ',
		'ᔦ',
		'ᔊ',
		'ᔙ',
		'ᔥ',
		'ᔺ',
		'ᔧ',
		'ᔂ',
		'ᓱ',
		'ᔹ',
		'ᔨ',
		'ᓾ',
		'ᓾ'
	};

	public static char[] char_10 = new char[14]
	{
		'ᒨ',
		'ᒧ',
		'ᒧ',
		'ᒨ',
		'ᒧ',
		'ᒧ',
		'ᒨ',
		'ᒧ',
		'ᒧ',
		'ᒨ',
		'ᒧ',
		'ᒧ',
		'ᒨ',
		'ᒧ'
	};

	public static Struct7[] struct7_0 = new Struct7[3]
	{
		new Struct7
		{
			char_0 = new char[152]
			{
				'ᕯ',
				'ᕈ',
				'ᕮ',
				'ᕵ',
				'ᕬ',
				'ᕭ',
				'ᕪ',
				'ᕊ',
				'ᔷ',
				'ᕓ',
				'ᕒ',
				'ᔰ',
				'ᕲ',
				'ᕳ',
				'ᕹ',
				'ᕐ',
				'ᕇ',
				'ᕓ',
				'ᕦ',
				'ᕃ',
				'ᕐ',
				'ᕮ',
				'ᕪ',
				'ᔲ',
				'ᕙ',
				'ᕵ',
				'ᕘ',
				'ᕖ',
				'ᔬ',
				'ᕮ',
				'ᕥ',
				'ᔷ',
				'ᔰ',
				'ᕃ',
				'ᔺ',
				'ᕺ',
				'ᕙ',
				'ᕘ',
				'ᔵ',
				'ᕔ',
				'ᕰ',
				'ᕑ',
				'ᕑ',
				'ᕎ',
				'ᕒ',
				'ᕤ',
				'ᕭ',
				'ᕅ',
				'ᕊ',
				'ᔬ',
				'ᕓ',
				'ᕄ',
				'ᔲ',
				'ᔸ',
				'ᕐ',
				'ᕹ',
				'ᕻ',
				'ᕈ',
				'ᔵ',
				'ᕹ',
				'ᕱ',
				'ᕪ',
				'ᕭ',
				'ᕥ',
				'ᕖ',
				'ᕪ',
				'ᕵ',
				'ᕓ',
				'ᔷ',
				'ᔵ',
				'ᕭ',
				'ᔬ',
				'ᕺ',
				'ᕏ',
				'ᕏ',
				'ᕪ',
				'ᕣ',
				'ᕉ',
				'ᔸ',
				'ᕖ',
				'ᔵ',
				'ᕂ',
				'ᕨ',
				'ᕑ',
				'ᕯ',
				'ᕓ',
				'ᕇ',
				'ᔬ',
				'ᔬ',
				'ᕆ',
				'ᕋ',
				'ᔵ',
				'ᔵ',
				'ᕩ',
				'ᕮ',
				'ᕈ',
				'ᕩ',
				'ᕔ',
				'ᕪ',
				'ᕅ',
				'ᕇ',
				'ᔸ',
				'ᕬ',
				'ᕆ',
				'ᕱ',
				'ᕥ',
				'ᕦ',
				'ᔲ',
				'ᕦ',
				'ᕦ',
				'ᔶ',
				'ᕷ',
				'ᔶ',
				'ᕌ',
				'ᔬ',
				'ᔸ',
				'ᕫ',
				'ᕸ',
				'ᕙ',
				'ᕅ',
				'ᕇ',
				'ᕫ',
				'ᕅ',
				'ᕂ',
				'ᕗ',
				'ᕬ',
				'ᕛ',
				'ᕴ',
				'ᔺ',
				'ᕘ',
				'ᕥ',
				'ᕋ',
				'ᕍ',
				'ᕴ',
				'ᕛ',
				'ᔳ',
				'ᔴ',
				'ᔳ',
				'ᕌ',
				'ᕇ',
				'ᕏ',
				'ᕫ',
				'ᕈ',
				'ᕂ',
				'ᕏ',
				'ᕣ',
				'ᔶ',
				'ᕦ',
				'ᕇ',
				'ᕒ',
				'ᔾ',
				'ᔾ'
			}
		},
		new Struct7
		{
			char_0 = new char[152]
			{
				'ᕗ',
				'ᕄ',
				'ᕆ',
				'ᕲ',
				'ᕮ',
				'ᕴ',
				'ᕖ',
				'ᕹ',
				'ᕰ',
				'ᕮ',
				'ᕍ',
				'ᕺ',
				'ᕢ',
				'ᔲ',
				'ᕭ',
				'ᕮ',
				'ᔰ',
				'ᕘ',
				'ᔷ',
				'ᕌ',
				'ᕺ',
				'ᕉ',
				'ᕴ',
				'ᕚ',
				'ᕱ',
				'ᕑ',
				'ᕒ',
				'ᕆ',
				'ᕺ',
				'ᕎ',
				'ᕹ',
				'ᕋ',
				'ᕥ',
				'ᕙ',
				'ᔷ',
				'ᔳ',
				'ᕙ',
				'ᕻ',
				'ᕸ',
				'ᕏ',
				'ᕧ',
				'ᕂ',
				'ᕃ',
				'ᕱ',
				'ᕉ',
				'ᕦ',
				'ᕰ',
				'ᔺ',
				'ᔴ',
				'ᕪ',
				'ᔬ',
				'ᔸ',
				'ᕖ',
				'ᕚ',
				'ᕙ',
				'ᕬ',
				'ᕅ',
				'ᕵ',
				'ᕲ',
				'ᕕ',
				'ᕵ',
				'ᔹ',
				'ᔲ',
				'ᕻ',
				'ᔶ',
				'ᕙ',
				'ᕚ',
				'ᕙ',
				'ᔳ',
				'ᔵ',
				'ᕖ',
				'ᔷ',
				'ᕺ',
				'ᕈ',
				'ᔱ',
				'ᕷ',
				'ᔲ',
				'ᕓ',
				'ᕴ',
				'ᕕ',
				'ᕷ',
				'ᕚ',
				'ᕆ',
				'ᕴ',
				'ᔱ',
				'ᔴ',
				'ᕊ',
				'ᕭ',
				'ᕂ',
				'ᕃ',
				'ᕙ',
				'ᔬ',
				'ᔴ',
				'ᕎ',
				'ᕈ',
				'ᔴ',
				'ᕒ',
				'ᔳ',
				'ᕭ',
				'ᕯ',
				'ᕒ',
				'ᕢ',
				'ᕈ',
				'ᔬ',
				'ᕑ',
				'ᕋ',
				'ᕣ',
				'ᕬ',
				'ᔴ',
				'ᕱ',
				'ᕂ',
				'ᕹ',
				'ᕎ',
				'ᕚ',
				'ᔺ',
				'ᕣ',
				'ᕱ',
				'ᕰ',
				'ᕕ',
				'ᕰ',
				'ᕓ',
				'ᕺ',
				'ᔳ',
				'ᕎ',
				'ᕷ',
				'ᕏ',
				'ᕂ',
				'ᕏ',
				'ᕈ',
				'ᕥ',
				'ᕋ',
				'ᕓ',
				'ᕔ',
				'ᔴ',
				'ᕏ',
				'ᕃ',
				'ᕫ',
				'ᕊ',
				'ᕺ',
				'ᕉ',
				'ᕍ',
				'ᔱ',
				'ᕸ',
				'ᔸ',
				'ᕐ',
				'ᕕ',
				'ᕊ',
				'ᕛ',
				'ᕪ',
				'ᕂ',
				'ᔾ',
				'ᔾ'
			}
		},
		new Struct7
		{
			char_0 = new char[152]
			{
				'ᕂ',
				'ᕚ',
				'ᕕ',
				'ᕪ',
				'ᕈ',
				'ᕖ',
				'ᕫ',
				'ᕤ',
				'ᕂ',
				'ᕷ',
				'ᔬ',
				'ᕆ',
				'ᔺ',
				'ᕱ',
				'ᕅ',
				'ᕍ',
				'ᕍ',
				'ᕯ',
				'ᕎ',
				'ᕫ',
				'ᕤ',
				'ᕵ',
				'ᕪ',
				'ᔱ',
				'ᔸ',
				'ᕃ',
				'ᔷ',
				'ᔰ',
				'ᕥ',
				'ᕲ',
				'ᔬ',
				'ᕵ',
				'ᕫ',
				'ᔱ',
				'ᕮ',
				'ᕍ',
				'ᕥ',
				'ᕨ',
				'ᔳ',
				'ᕹ',
				'ᕥ',
				'ᕱ',
				'ᕺ',
				'ᕙ',
				'ᔶ',
				'ᕄ',
				'ᕎ',
				'ᕖ',
				'ᕯ',
				'ᕚ',
				'ᕵ',
				'ᕃ',
				'ᔬ',
				'ᕵ',
				'ᕏ',
				'ᕆ',
				'ᕢ',
				'ᕛ',
				'ᕧ',
				'ᕭ',
				'ᔶ',
				'ᕗ',
				'ᕈ',
				'ᕪ',
				'ᕥ',
				'ᔬ',
				'ᕏ',
				'ᕄ',
				'ᕭ',
				'ᕏ',
				'ᕣ',
				'ᕨ',
				'ᕹ',
				'ᕨ',
				'ᕸ',
				'ᕋ',
				'ᕤ',
				'ᕧ',
				'ᕭ',
				'ᕭ',
				'ᕷ',
				'ᕐ',
				'ᕓ',
				'ᕷ',
				'ᕴ',
				'ᕤ',
				'ᕭ',
				'ᔹ',
				'ᔶ',
				'ᕄ',
				'ᕅ',
				'ᕛ',
				'ᕱ',
				'ᕅ',
				'ᕗ',
				'ᕰ',
				'ᕗ',
				'ᔶ',
				'ᕺ',
				'ᕤ',
				'ᔬ',
				'ᕯ',
				'ᔸ',
				'ᔶ',
				'ᕐ',
				'ᕮ',
				'ᕒ',
				'ᕛ',
				'ᕃ',
				'ᕔ',
				'ᔺ',
				'ᔰ',
				'ᕊ',
				'ᕉ',
				'ᔸ',
				'ᔺ',
				'ᕯ',
				'ᕤ',
				'ᔲ',
				'ᕬ',
				'ᕻ',
				'ᔳ',
				'ᕳ',
				'ᕃ',
				'ᕑ',
				'ᕌ',
				'ᕭ',
				'ᕕ',
				'ᕆ',
				'ᕍ',
				'ᕈ',
				'ᕇ',
				'ᔵ',
				'ᕫ',
				'ᕍ',
				'ᕤ',
				'ᕹ',
				'ᕯ',
				'ᕫ',
				'ᕨ',
				'ᕅ',
				'ᔹ',
				'ᔵ',
				'ᕉ',
				'ᕉ',
				'ᕃ',
				'ᔰ',
				'ᕈ',
				'ᕦ',
				'ᕂ',
				'ᔾ',
				'ᔾ'
			}
		}
	};

	public static string[] string_0 = new string[5]
	{
		string.Concat(new char[20]
		{
			'ᓲ',
			'ᓱ',
			'ᓠ',
			'ᓫ',
			'ᓦ',
			'ᓰ',
			'ᓱ',
			'ᒫ',
			'ᓠ',
			'ᓬ',
			'ᓩ',
			'ᓬ',
			'ᓯ',
			'ᓞ',
			'ᓡ',
			'ᓬ',
			'ᒫ',
			'ᓢ',
			'ᓡ',
			'ᓲ'
		}),
		string.Concat(new char[11]
		{
			'ᓨ',
			'ᓝ',
			'ᓡ',
			'ᓙ',
			'ᒢ',
			'ᓝ',
			'ᓙ',
			'ᓢ',
			'ᒢ',
			'ᓝ',
			'ᓨ'
		}),
		string.Concat(new char[13]
		{
			'ᓪ',
			'ᓟ',
			'ᓣ',
			'ᓛ',
			'ᒤ',
			'ᓤ',
			'ᓟ',
			'ᓩ',
			'ᓪ',
			'ᒤ',
			'ᓝ',
			'ᓥ',
			'ᓬ'
		}),
		string.Concat(new char[15]
		{
			'ᓨ',
			'ᓬ',
			'ᓚ',
			'ᓬ',
			'ᓡ',
			'ᓥ',
			'ᓝ',
			'ᒩ',
			'ᒦ',
			'ᓨ',
			'ᓬ',
			'ᓚ',
			'ᒦ',
			'ᓜ',
			'ᓝ'
		}),
		string.Concat(new char[62]
		{
			'ᓡ',
			'ᔍ',
			'ᔙ',
			'ᔌ',
			'ᔌ',
			'ᓕ',
			'ᔛ',
			'ᔐ',
			'ᔔ',
			'ᔌ',
			'ᔈ',
			'ᔕ',
			'ᔋ',
			'ᔋ',
			'ᔈ',
			'ᔛ',
			'ᔌ',
			'ᓕ',
			'ᔊ',
			'ᔖ',
			'ᔔ',
			'ᓖ',
			'ᔊ',
			'ᔓ',
			'ᔖ',
			'ᔊ',
			'ᔒ',
			'ᓖ',
			'ᔐ',
			'ᓚ',
			'ᔑ',
			'ᔓ',
			'ᓝ',
			'ᓟ',
			'ᔕ',
			'ᔔ',
			'ᓖ',
			'ᔕ',
			'ᓙ',
			'ᓛ',
			'ᓝ',
			'ᓖ',
			'ᔛ',
			'ᔓ',
			'ᔐ',
			'ᔙ',
			'ᓖ',
			'ᔛ',
			'ᔛ',
			'ᓗ',
			'ᓖ',
			'ᔛ',
			'ᔞ',
			'ᓗ',
			'ᓖ',
			'ᔛ',
			'ᔔ',
			'ᓚ',
			'ᓖ',
			'ᔛ',
			'ᔏ',
			'ᓘ'
		})
	};

	public static char[] char_11 = new char[33]
	{
		'ᓋ',
		'ᓮ',
		'ᓱ',
		'ᓫ',
		'ᓷ',
		'ᓯ',
		'ᒪ',
		'ᖛ',
		'ᕭ',
		'ᒪ',
		'ᓵ',
		'ᓲ',
		'ᕽ',
		'ᓫ',
		'ᒪ',
		'ᓭ',
		'ᓲ',
		'㍳',
		'ᓭ',
		'ᒪ',
		'ᓸ',
		'ᖍ',
		'ᓸ',
		'ᓱ',
		'ᒪ',
		'ᓾ',
		'ᓲ',
		'ᓯ',
		'ᓹ',
		'ᒪ',
		'ᓽ',
		'ᓫ',
		'ᓿ'
	};

	public static char[] char_12 = new char[4]
	{
		'ᒛ',
		'ᓡ',
		'ᓥ',
		'ᓡ'
	};

	public static char[] char_13 = new char[7]
	{
		'ᓘ',
		'ᓤ',
		'ᓤ',
		'ᓠ',
		'ᒪ',
		'ᒟ',
		'ᒟ'
	};

	public static char[] char_14 = new char[12]
	{
		'ᒱ',
		'ᓨ',
		'ᓥ',
		'ᓖ',
		'ᓣ',
		'ᒕ',
		'ᓞ',
		'ᓙ',
		'ᒲ',
		'ᓩ',
		'ᒦ',
		'ᒳ'
	};

	public static string char_16 = "Chưa đăng ký hoặc hết hạn sử dụng";

	public static string char_17 = "Chưa kiểm tra được";

	public static string char_18 = "Thông tin (lic không hợp lệ)";

	public static string char_19 = "HSD:";

	public static char[] char_20 = new char[5]
	{
		'ᒎ',
		'ᓜ',
		'ᓕ',
		'ᕎ',
		'ᓧ'
	};

	public static char[] char_21 = new char[4]
	{
		'ᒶ',
		'ᒱ',
		'ᒧ',
		'ᒍ'
	};

	public static char[] char_22 = new char[68]
	{
		'ᓯ',
		'㍒',
		'ᔚ',
		'ᓍ',
		'ᔛ',
		'ᖧ',
		'ᔡ',
		'ᓍ',
		'ᔈ',
		'ᓮ',
		'ᔊ',
		'ᓍ',
		'ᖾ',
		'㍰',
		'ᓍ',
		'ᖖ',
		'ᔝ',
		'ᓍ',
		'ᔡ',
		'ᖗ',
		'ᔛ',
		'ᓍ',
		'ᔎ',
		'ᔐ',
		'ᓍ',
		'ᔣ',
		'ᖍ',
		'ᔜ',
		'ᓍ',
		'ᔎ',
		'ᔢ',
		'ᔡ',
		'ᔜ',
		'ᓛ',
		'ᓍ',
		'ᓯ',
		'㍒',
		'ᔚ',
		'ᓍ',
		'ᔝ',
		'ᔕ',
		'㎒',
		'ᓍ',
		'ᔡ',
		'ᔟ',
		'㎐',
		'ᓍ',
		'ᖾ',
		'㍰',
		'ᓍ',
		'ᔥ',
		'ᔒ',
		'ᔚ',
		'ᓍ',
		'ᔝ',
		'ᔕ',
		'ᔖ',
		'ᔚ',
		'ᓍ',
		'ᔕ',
		'ᙝ',
		'㎈',
		'ᔛ',
		'ᔔ',
		'ᓍ',
		'ᔑ',
		'㍘',
		'ᔛ'
	};

	public static char[] char_23 = new char[108]
	{
		'ᔦ',
		'ᔊ',
		'ᔤ',
		'ᔗ',
		'ᕉ',
		'ᔍ',
		'ᔽ',
		'ᔗ',
		'ᔪ',
		'ᕌ',
		'ᔟ',
		'ᕊ',
		'ᔡ',
		'ᔿ',
		'ᕂ',
		'ᔧ',
		'ᕉ',
		'ᔬ',
		'ᕍ',
		'ᔻ',
		'ᕊ',
		'ᕇ',
		'ᔙ',
		'ᔋ',
		'ᕉ',
		'ᔋ',
		'ᔗ',
		'ᕄ',
		'ᔖ',
		'ᔡ',
		'ᔞ',
		'ᔤ',
		'ᔹ',
		'ᔈ',
		'ᔗ',
		'ᔹ',
		'ᕊ',
		'ᕄ',
		'ᕁ',
		'ᔛ',
		'ᔦ',
		'ᔅ',
		'ᕆ',
		'ᔞ',
		'ᔞ',
		'ᔎ',
		'ᔟ',
		'ᕏ',
		'ᔆ',
		'ᕇ',
		'ᔫ',
		'ᔄ',
		'ᔉ',
		'ᕅ',
		'ᔆ',
		'ᔟ',
		'ᔍ',
		'ᔻ',
		'ᕎ',
		'ᔎ',
		'ᔾ',
		'ᔾ',
		'ᔼ',
		'ᕇ',
		'ᔜ',
		'ᕂ',
		'ᔛ',
		'ᔞ',
		'ᕄ',
		'ᔨ',
		'ᔮ',
		'ᕁ',
		'ᔌ',
		'ᔷ',
		'ᕄ',
		'ᕅ',
		'ᔅ',
		'ᕊ',
		'ᔊ',
		'ᔯ',
		'ᔜ',
		'ᔄ',
		'ᔨ',
		'ᔭ',
		'ᔘ',
		'ᔠ',
		'ᔈ',
		'ᔝ',
		'ᔆ',
		'ᔙ',
		'ᔛ',
		'ᔣ',
		'ᔭ',
		'ᔫ',
		'ᔅ',
		'ᕎ',
		'ᔭ',
		'ᕌ',
		'ᔋ',
		'ᔿ',
		'ᕋ',
		'ᕌ',
		'ᔌ',
		'ᔻ',
		'ᔚ',
		'ᔺ',
		'ᔪ',
		'ᔒ'
	};

	public static string string_1 = "ᒘ";

	public static string string_2 = "ᒖ";

	public static string string_3 = "ᓦ";

	public static string string_4 = "/";

	public static string string_5 = "ᒗ";

	public static string string_6 = "ᓉ";

	public static string string_7 = ":";

	//public static string string_8 = "(";

	//public static string string_9 = ")";

	public static string string_10 = "ᒔ";

	public static string string_11 = "ᓅ";

	public static string string_12 = "ᓇ";

	public static string string_13 = "ᒚ";

	public static char[] char_24 = new char[4]
	{
		'ᓘ',
		'ᓖ',
		'ᓚ',
		'ᓦ'
	};

	public static char[] char_25 = new char[21]
	{
		'ᓚ',
		'ᓑ',
		'ᓷ',
		'ᓱ',
		'ᓲ',
		'ᓣ',
		'ᓫ',
		'ᒱ',
		'ᒰ',
		'ᓚ',
		'ᓢ',
		'ᓰ',
		'ᓧ',
		'ᓴ',
		'ᓣ',
		'ᓰ',
		'ᓱ',
		'ᓚ',
		'ᓣ',
		'ᓲ',
		'ᓡ'
	};

	public static char[] char_26 = new char[2]
	{
		'ᓓ',
		'ᒕ'
	};

	public static char[] char_27 = new char[4]
	{
		'ᓕ',
		'ᒗ',
		'ᒛ',
		'ᒗ'
	};

	public static char[] char_28 = new char[3]
	{
		'ᓗ',
		'ᓕ',
		'ᓙ'
	};

	public static char[] char_29 = new char[5]
	{
		'ᒾ',
		'ᒶ',
		'ᒽ',
		'ᓂ',
		'ᒽ'
	};

	public static char[] char_30 = new char[9]
	{
		'ᓇ',
		'ᓆ',
		'ᒵ',
		'ᒚ',
		'ᓀ',
		'ᒻ',
		'ᓅ',
		'ᓆ',
		'ᒛ'
	};

	public static char[] char_31 = new char[17]
	{
		'ᓳ',
		'ᓳ',
		'ᒧ',
		'ᓇ',
		'ᓇ',
		'ᒧ',
		'ᓞ',
		'ᓞ',
		'ᒚ',
		'ᓂ',
		'ᓂ',
		'ᒴ',
		'ᓧ',
		'ᓧ',
		'ᒴ',
		'ᓭ',
		'ᓭ'
	};

	public static string char_32 = "Ngày giờ máy tính bị sai, hãy điều chỉnh để sử dụng auto !";

	public static char[] char_33 = new char[11]
	{
		'ᒿ',
		'ᓍ',
		'ᒿ',
		'ᓙ',
		'ᓣ',
		'ᓬ',
		'ᓙ',
		'ᒢ',
		'ᓨ',
		'ᓬ',
		'ᓨ'
	};

	public static char[] char_34 = new char[15]
	{
		'ᓄ',
		'ᓁ',
		'ᒻ',
		'ᓗ',
		'ᓃ',
		'ᓑ',
		'ᓃ',
		'ᓝ',
		'ᓧ',
		'ᓰ',
		'ᓝ',
		'ᒦ',
		'ᓬ',
		'ᓰ',
		'ᓬ'
	};

	public static char[] char_35 = new char[80]
	{
		'ᔟ',
		'ᔨ',
		'ᔫ',
		'ᓙ',
		'ᓞ',
		'ᔚ',
		'ᓙ',
		'ᔢ',
		'ᔧ',
		'ᓙ',
		'ᓡ',
		'ᔰ',
		'ᓥ',
		'ᔳ',
		'ᓥ',
		'ᔲ',
		'ᓥ',
		'ᔱ',
		'ᓥ',
		'ᔯ',
		'ᓥ',
		'ᔮ',
		'ᓥ',
		'ᔭ',
		'ᓥ',
		'ᔬ',
		'ᓥ',
		'ᔫ',
		'ᓥ',
		'ᔪ',
		'ᓥ',
		'ᔩ',
		'ᓥ',
		'ᔨ',
		'ᓥ',
		'ᔧ',
		'ᓥ',
		'ᔦ',
		'ᓥ',
		'ᔥ',
		'ᓥ',
		'ᔤ',
		'ᓥ',
		'ᔠ',
		'ᓥ',
		'ᔢ',
		'ᓥ',
		'ᔡ',
		'ᓥ',
		'ᔠ',
		'ᓥ',
		'ᔟ',
		'ᓥ',
		'ᔞ',
		'ᓥ',
		'ᔝ',
		'ᓥ',
		'ᔜ',
		'ᓢ',
		'ᓙ',
		'ᔝ',
		'ᔨ',
		'ᓙ',
		'ᔝ',
		'ᔞ',
		'ᔥ',
		'ᓙ',
		'ᓞ',
		'ᔚ',
		'ᓳ',
		'ᔕ',
		'ᓣ',
		'ᓧ',
		'ᓣ',
		'ᓨ',
		'ᔬ',
		'ᓨ',
		'ᔟ',
		'ᓨ',
		'ᔪ'
	};

	public static char[] char_36 = new char[58]
	{
		'ᓰ',
		'ᓨ',
		'ᓶ',
		'ᓶ',
		'ᓝ',
		'ᓥ',
		'㍄',
		'ᔑ',
		'ᓃ',
		'ᖴ',
		'ᔄ',
		'ᔑ',
		'ᔊ',
		'ᓃ',
		'ᔖ',
		'㎐',
		'ᓃ',
		'ᔇ',
		'㎈',
		'ᔑ',
		'ᔊ',
		'ᓃ',
		'ᔆ',
		'ᔕ',
		'ᔄ',
		'ᔆ',
		'ᔎ',
		'ᓃ',
		'ᔄ',
		'ᔘ',
		'ᔗ',
		'ᔒ',
		'ᓏ',
		'ᓃ',
		'ᔅ',
		'㍄',
		'ᔑ',
		'ᓃ',
		'ᔆ',
		'ᖃ',
		'ᔌ',
		'ᓃ',
		'ᔏ',
		'㍄',
		'ᔌ',
		'ᓃ',
		'ᓺ',
		'ᔌ',
		'ᔑ',
		'ᔇ',
		'ᔒ',
		'ᔚ',
		'ᔖ',
		'ᓃ',
		'ᔑ',
		'ᔋ',
		'ᖌ',
		'ᓑ'
	};

	public static char[] char_37 = new char[86]
	{
		'ᔋ',
		'㎖',
		'ᔨ',
		'ᓟ',
		'ᔪ',
		'ᔧ',
		'ᖳ',
		'ᔭ',
		'ᔦ',
		'ᓟ',
		'ᔷ',
		'ᖠ',
		'ᔢ',
		'ᓟ',
		'ᗐ',
		'㎊',
		'ᔭ',
		'ᔧ',
		'ᓟ',
		'ᗐ',
		'ᙯ',
		'㎢',
		'ᔢ',
		'ᓟ',
		'ᔯ',
		'ᔧ',
		'ᔨ',
		'ᖩ',
		'ᔭ',
		'ᓟ',
		'ᔡ',
		'㍢',
		'ᔭ',
		'ᓟ',
		'ᔠ',
		'ᔴ',
		'ᔳ',
		'ᔮ',
		'ᓟ',
		'ᗐ',
		'ᔠ',
		'ᔭ',
		'ᔦ',
		'ᓟ',
		'ᔲ',
		'㎬',
		'ᓟ',
		'ᔣ',
		'㎤',
		'ᔭ',
		'ᔦ',
		'ᓟ',
		'ᔧ',
		'ᔮ',
		'㍶',
		'ᔢ',
		'ᓟ',
		'ᔠ',
		'ᔴ',
		'ᔳ',
		'ᔮ',
		'ᓟ',
		'ᗐ',
		'ᖢ',
		'ᓟ',
		'ᔢ',
		'ᖲ',
		'ᓟ',
		'ᔯ',
		'ᔧ',
		'ᔨ',
		'ᖩ',
		'ᔭ',
		'ᓟ',
		'ᔡ',
		'㍢',
		'ᔭ',
		'ᓟ',
		'ᔬ',
		'㎚',
		'ᔨ',
		'ᓟ',
		'ᔧ',
		'ᙠ',
		'ᔭ',
		'ᓭ'
	};

	public static string char_38 = "Chưa đăng ký sử dụng, liên hệ Kim Yến !";

	public static string char_39 = "Đăng ký cần xác thực sử dụng, liên hệ Kim Yến !";

    public static char[] char_40 = new char[112]
	{
		'ᔕ',
		'ᔼ',
		'ᕈ',
		'ᕅ',
		'ᕈ',
		'ᕋ',
		'ᔖ',
		'ᕐ',
		'ᕁ',
		'ᕂ',
		'ᕍ',
		'ᔾ',
		'ᔗ',
		'ᔥ',
		'ᗀ',
		'ᕂ',
		'ᓹ',
		'ᕑ',
		'ᖑ',
		'ᔼ',
		'ᓹ',
		'ᕍ',
		'ᕁ',
		'ᗒ',
		'ᔼ',
		'ᔓ',
		'ᓹ',
		'ᔢ',
		'ᔩ',
		'ᓹ',
		'ᕀ',
		'ᔺ',
		'ᕆ',
		'ᔾ',
		'ᓹ',
		'ᕄ',
		'ᕁ',
		'ᖑ',
		'ᔼ',
		'ᓹ',
		'ᕏ',
		'ᗆ',
		'ᕂ',
		'ᓹ',
		'ᔢ',
		'ᔩ',
		'ᓹ',
		'ᖇ',
		'ᖐ',
		'ᓹ',
		'ᖇ',
		'ᖁ',
		'ᕇ',
		'ᕀ',
		'ᓹ',
		'ᕄ',
		'ᗖ',
		'ᓹ',
		'ᕍ',
		'ᕋ',
		'ᕈ',
		'ᕇ',
		'ᕀ',
		'ᓹ',
		'ᕅ',
		'ᕂ',
		'ᔼ',
		'ᓹ',
		'ᔻ',
		'ᔺ',
		'ᕇ',
		'ᕀ',
		'ᓹ',
		'ᕁ',
		'ᗂ',
		'ᕂ',
		'ᔅ',
		'ᓹ',
		'ᕁ',
		'ᖐ',
		'ᕒ',
		'ᓹ',
		'ᕅ',
		'ᕂ',
		'ᖃ',
		'ᕇ',
		'ᓹ',
		'ᕁ',
		'ᖯ',
		'ᓹ',
		'ᔤ',
		'ᕂ',
		'ᕆ',
		'ᓹ',
		'ᔲ',
		'ᖮ',
		'ᕇ',
		'ᓹ',
		'ᖇ',
		'ᖬ',
		'ᓹ',
		'ᖇ',
		'ᕂ',
		'ᖫ',
		'ᕎ',
		'ᓹ',
		'ᔼ',
		'ᕁ',
		'ᖱ',
		'ᕇ',
		'ᕁ',
		'ᔇ'
	};

	public static char[] char_41 = new char[30]
	{
		'ᓃ',
		'ᓪ',
		'ᓶ',
		'ᓳ',
		'ᓶ',
		'ᓹ',
		'ᓄ',
		'ᓾ',
		'ᓯ',
		'ᓰ',
		'ᓻ',
		'ᓬ',
		'ᓅ',
		'ᓈ',
		'ᓼ',
		'ᓻ',
		'ᓶ',
		'ᒧ',
		'ᔵ',
		'ᓨ',
		'ᓵ',
		'ᓮ',
		'ᒧ',
		'ᓪ',
		'ᓯ',
		'ᕀ',
		'ᔀ',
		'ᒵ',
		'ᒵ',
		'ᒵ'
	};

	public static char[] char_42 = new char[40]
	{
		'ᓷ',
		'ᔀ',
		'ᔃ',
		'ᒱ',
		'ᒶ',
		'ᓲ',
		'ᒱ',
		'ᓺ',
		'ᓿ',
		'ᒱ',
		'ᒹ',
		'ᓷ',
		'ᒽ',
		'ᓶ',
		'ᒽ',
		'ᓵ',
		'ᒽ',
		'ᓴ',
		'ᒺ',
		'ᒱ',
		'ᓵ',
		'ᔀ',
		'ᒱ',
		'ᓵ',
		'ᓶ',
		'ᓽ',
		'ᒱ',
		'ᒶ',
		'ᓲ',
		'ᓋ',
		'ᓭ',
		'ᒻ',
		'ᒿ',
		'ᒻ',
		'ᓀ',
		'ᔄ',
		'ᓀ',
		'ᓷ',
		'ᓀ',
		'ᔂ'
	};

	public static char[] char_43 = new char[152]
	{
		'ᔱ',
		'ᕆ',
		'ᕴ',
		'ᕸ',
		'ᕎ',
		'ᕭ',
		'ᕢ',
		'ᕱ',
		'ᕈ',
		'ᕅ',
		'ᕫ',
		'ᕰ',
		'ᕩ',
		'ᕉ',
		'ᔴ',
		'ᕔ',
		'ᕈ',
		'ᕻ',
		'ᕆ',
		'ᕊ',
		'ᕤ',
		'ᕗ',
		'ᕋ',
		'ᔳ',
		'ᕈ',
		'ᕌ',
		'ᕎ',
		'ᕤ',
		'ᕒ',
		'ᔲ',
		'ᕥ',
		'ᕪ',
		'ᕷ',
		'ᕪ',
		'ᕨ',
		'ᕫ',
		'ᕏ',
		'ᕕ',
		'ᔳ',
		'ᕄ',
		'ᕯ',
		'ᕶ',
		'ᔶ',
		'ᕱ',
		'ᕮ',
		'ᕆ',
		'ᕄ',
		'ᕅ',
		'ᕱ',
		'ᔸ',
		'ᕓ',
		'ᔵ',
		'ᕚ',
		'ᕘ',
		'ᕉ',
		'ᕔ',
		'ᕣ',
		'ᕬ',
		'ᕈ',
		'ᕤ',
		'ᕵ',
		'ᕪ',
		'ᕖ',
		'ᔰ',
		'ᕪ',
		'ᕈ',
		'ᕧ',
		'ᕬ',
		'ᕩ',
		'ᕏ',
		'ᕗ',
		'ᔶ',
		'ᕤ',
		'ᕦ',
		'ᔸ',
		'ᕫ',
		'ᕓ',
		'ᕘ',
		'ᕺ',
		'ᕛ',
		'ᕔ',
		'ᕈ',
		'ᔴ',
		'ᕊ',
		'ᕋ',
		'ᕘ',
		'ᕋ',
		'ᕋ',
		'ᕲ',
		'ᕛ',
		'ᔵ',
		'ᕺ',
		'ᕊ',
		'ᔱ',
		'ᕸ',
		'ᕖ',
		'ᕤ',
		'ᕻ',
		'ᕚ',
		'ᔶ',
		'ᕸ',
		'ᕂ',
		'ᕉ',
		'ᕹ',
		'ᕗ',
		'ᔷ',
		'ᕵ',
		'ᕳ',
		'ᕵ',
		'ᕳ',
		'ᕄ',
		'ᕴ',
		'ᕑ',
		'ᔹ',
		'ᔰ',
		'ᕉ',
		'ᕺ',
		'ᕒ',
		'ᕐ',
		'ᕚ',
		'ᕶ',
		'ᕅ',
		'ᕪ',
		'ᕮ',
		'ᔰ',
		'ᕹ',
		'ᕄ',
		'ᔶ',
		'ᕥ',
		'ᕘ',
		'ᕋ',
		'ᕗ',
		'ᕭ',
		'ᕴ',
		'ᕬ',
		'ᕋ',
		'ᕵ',
		'ᕤ',
		'ᕛ',
		'ᕒ',
		'ᕈ',
		'ᕰ',
		'ᕥ',
		'ᔲ',
		'ᔲ',
		'ᔴ',
		'ᔳ',
		'ᕐ',
		'ᕩ',
		'ᕸ',
		'ᔾ',
		'ᔾ'
	};

	public static char[] char_44 = new char[44]
	{
		't',
		'K',
		'V',
		'M',
		'+',
		'T',
		'o',
		'D',
		'j',
		'e',
		'X',
		'g',
		'q',
		'h',
		'H',
		'y',
		'i',
		'O',
		'U',
		'x',
		'a',
		'p',
		'H',
		'n',
		'7',
		'G',
		'6',
		'F',
		'j',
		'h',
		'J',
		's',
		'W',
		'C',
		'2',
		'd',
		'Q',
		'd',
		'X',
		'p',
		'D',
		'h',
		'g',
		'='
	};

	public static int int_1 = 0;

	public static uint uint_0 = 0u;

	public static uint uint_1 = 0u;

	public static long long_0 = 0L;

	public static string[] string_14 = null;

	public static bool bool_0 = false;

	public static GStruct41[] gstruct41_0 = null;

	[CompilerGenerated]
	private static Func<SecureString, char, SecureString> func_0;

	public static void smethod_0(string string_15, ref SecureString secureString_0)
	{
		secureString_0 = string_15.Aggregate(new SecureString(), smethod_58);
	}

	public static string smethod_1(char[] char_45)
	{
		if (char_45 == null)
		{
			return string.Empty;
		}
		string text = string.Concat(char_45);
		if (char_45[0] > 'ᎇ')
		{
			text = smethod_48(text);
		}
		return text;
	}

	public static int smethod_2(string string_15, object object_0)
	{
		if (string_15 != null && !(string_15 == string.Empty) && object_0 != null)
		{
			string text = object_0.ToString();
			if (!(text == string.Empty))
			{
				int num = string_15.IndexOf(text);
				if (0 <= num)
				{
					return num;
				}
				char[] array = string_15.ToCharArray();
				char[] array2 = text.ToCharArray();
				int num2 = array.Length;
				int num3 = array2.Length;
				int num4 = 0;
				while (true)
				{
					if (num4 < num2)
					{
						if (num2 - num4 < num3)
						{
							break;
						}
						if (array[num4] == array2[0])
						{
							if (num3 == 1)
							{
								return num4;
							}
							bool flag = true;
							for (int i = 1; i < num3; i++)
							{
								if (array2[i] != array[num4 + i])
								{
									flag = false;
									break;
								}
							}
							if (flag)
							{
								return num4;
							}
						}
						num4++;
						continue;
					}
					return -1;
				}
				return -1;
			}
			return -1;
		}
		return -1;
	}

	public static bool smethod_3(string string_15, string string_16, bool bool_1 = false)
	{
		if (string_15 != null && string_16 != null)
		{
			if (string_15 == string_16)
			{
				return true;
			}
			string text = Class10.smethod_1(string_15, 1).ToUpper();
			string text2 = Class10.smethod_1(string_16, 1).ToUpper();
			if (!(text == text2) && !(text == text2.Replace("*", "")))
			{
				if (bool_1)
				{
					return text == text2 || text == string_16 || string_15 == text2 || text == string_16.ToUpper() || string_15.ToUpper() == text2;
				}
				return 0 <= smethod_2(string_15, string_16.Replace("*", "")) || 0 <= smethod_2(text, text2.Replace("*", "")) || 0 <= smethod_2(string_15.ToUpper(), text2.Replace("*", "")) || 0 <= smethod_2(text, string_16.ToUpper()) || 0 <= smethod_2(string_15.ToUpper(), text2);
			}
			return true;
		}
		return false;
	}

	public static string[] smethod_4(string[] string_15, bool bool_1, bool bool_2 = false)
	{
		if (string_15 != null && string_15.Length != 0)
		{
			for (int i = 0; i < string_15.Length; i++)
			{
				if (string_15[i] == null)
				{
					string_15[i] = string.Empty;
					continue;
				}
				if (bool_1)
				{
					string_15[i] = string_15[i].Replace(" ", string.Empty).Replace("Ù", string.Empty);
				}
				else
				{
					string_15[i] = string_15[i].Trim();
				}
				if (bool_2)
				{
					string_15[i] = string_15[i].ToLower();
				}
			}
			return string_15;
		}
		return null;
	}

	public static bool smethod_5(string string_15, byte[] byte_0)
	{
		try
		{
			FileStream fileStream = new FileStream(string_15, FileMode.Create, FileAccess.Write);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Close();
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static uint smethod_6(uint[] uint_2, uint[] uint_3)
	{
		if (uint_2 != null && uint_3 != null && uint_2[0] != 0 && uint_2[1] != 0 && uint_3[0] != 0 && uint_3[1] != 0)
		{
			long num = (int)(uint_2[0] - uint_3[0]);
			long num2 = (int)(uint_2[1] - uint_3[1]);
			long num3 = num * num + num2 * num2;
			if (num3 == 0L)
			{
				num3 = 1L;
			}
			return (uint)num3;
		}
		return 0u;
	}

	public static uint smethod_7(string string_15)
	{
		if (string_15 != null && !(string_15 == string.Empty))
		{
			uint num = 0u;
			char[] array = string_15.ToCharArray();
			for (uint num2 = 0u; num2 < array.Length; num2++)
			{
				uint num3 = (byte)array[num2];
				if (num3 > 127)
				{
					num3 = (uint)(-256 + (int)num3);
				}
				uint num4 = num2 + 1;
				num4 *= num3;
				num4 += num;
				num = 2147483659u;
				num3 = num4 % 2147483659u;
				num4 = num3;
				num4 = (uint)(Math.Abs(num4) * -1L);
				num4 <<= 4;
				num4 -= num3;
				num = num4;
			}
			return num ^ 0x12345678;
		}
		return 0u;
	}

	public static void smethod_8(string string_15)
	{
		if (!File.Exists(string_15))
		{
			try
			{
				Directory.CreateDirectory(string_15);
			}
			catch
			{
			}
		}
	}

	public static string smethod_9(string string_15)
	{
		try
		{
			using (MD5 mD = MD5.Create())
			{
				using (FileStream inputStream = File.OpenRead(string_15))
				{
					return BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", string.Empty).ToLower();
				}
			}
		}
		catch
		{
		}
		return "";
	}

	public static byte[] smethod_10(string string_15, bool bool_1 = true)
	{
		if (string_15 != null && !(string_15 == string.Empty))
		{
			string_15 = string_15.Replace(" ", "");
			if (string_15.Length % 2 == 0 && !(string_15 == ""))
			{
				int num = string_15.Length / 2;
				byte[] array = new byte[num];
				for (int i = 0; i < array.Length; i++)
				{
					string text = string_15.Substring(i * 2, 2);
					if (bool_1 && text == "??")
					{
						array[i] = 63;
					}
					else
					{
						array[i] = byte.Parse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
					}
				}
				return array;
			}
			return null;
		}
		return null;
	}

	public static int smethod_11(string string_15)
	{
		if (string_15 != null && !(string_15 == string.Empty))
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				if (num2 < string_15.Length)
				{
					if (string_15[num2] < '0' || string_15[num2] > '9')
					{
						break;
					}
					if (string_15[num2] != '0' || num > 0)
					{
						num++;
					}
					num2++;
					continue;
				}
				return num;
			}
			return -1;
		}
		return -1;
	}

	public static int smethod_12(string string_15)
	{
		int result = 0;
		if (string_15 != null && string_15 != "")
		{
			try
			{
				result = Convert.ToInt32(string_15);
			}
			catch
			{
				result = 0;
			}
		}
		return result;
	}

	public static uint smethod_13(string string_15)
	{
		uint result = 0u;
		if (string_15 != null && string_15 != "")
		{
			try
			{
				result = Convert.ToUInt32(string_15);
			}
			catch
			{
				result = 0u;
			}
		}
		return result;
	}

	public static void smethod_14(ref string string_15, string string_16, string string_17 = "")
	{
		if (string_17 == "")
		{
			string_17 = Class47.string_3;
		}
		if (string_15 != "")
		{
			string_15 += string_17;
		}
		string_15 += string_16;
	}

	public static string[] smethod_15(string string_15, char char_45 = '\\')
	{
		string[] array = new string[2]
		{
			string.Empty,
			string.Empty
		};
		if (string_15 != null && string_15 != string.Empty)
		{
			string[] array2 = string_15.Split(char_45);
			array[1] = array2[array2.Length - 1];
			for (int i = 0; i < array2.Length - 1; i++)
			{
				string[] array3;
				if (array[0] != string.Empty)
				{
					(array3 = array)[0] = array3[0] + char_45;
				}
				(array3 = array)[0] = array3[0] + array2[i];
			}
		}
		return array;
	}

	public static string smethod_16(string string_15)
	{
		try
		{
			byte[] array = Convert.FromBase64String(string_15);
			return Encoding.UTF8.GetString(array, 0, array.Length);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static string smethod_17(string string_15)
	{
		if (string_15 == null)
		{
			return string.Empty;
		}
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_15);
			return Convert.ToBase64String(bytes);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static bool smethod_18(string string_15)
	{
		try
		{
			return File.Exists(string_15);
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_19(string string_15, string string_16)
	{
		try
		{
			File.Move(string_15, string_16);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_20(string string_15)
	{
		if (!File.Exists(string_15))
		{
			return true;
		}
		try
		{
			File.Delete(string_15);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static int smethod_21(string string_15, string string_16)
	{
		if (File.Exists(string_15))
		{
			if (File.Exists(string_16) && !smethod_20(string_16))
			{
				Random random = new Random();
				try
				{
					File.Move(string_16, string_16 + "." + random.Next(10000, int.MaxValue).ToString());
				}
				catch
				{
					return -2;
				}
			}
			try
			{
				File.Copy(string_15, string_16, overwrite: true);
				return 1;
			}
			catch
			{
			}
			return -3;
		}
		return -1;
	}

	public static long smethod_22()
	{
		return DateTime.Now.Ticks;
	}

	public static long smethod_23(long long_1)
	{
		return (long)new TimeSpan(DateTime.Now.Ticks - long_1).TotalMilliseconds;
	}

	public static void smethod_24(ref string[] string_15, string string_16)
	{
		if (string_15 == null)
		{
			string_15 = new string[1]
			{
				string_16
			};
		}
		else
		{
			try
			{
				string[] array = new string[string_15.Length + 1];
				for (int i = 0; i < string_15.Length; i++)
				{
					if (string_15[i] == string_16)
					{
						return;
					}
					array[i] = string_15[i];
				}
				array[array.Length - 1] = string_16;
				string_15 = array;
			}
			catch
			{
			}
		}
	}

	public static void smethod_25(ref string[] string_15, string string_16, bool bool_1 = false)
	{
		if (string_15 != null && string_15.Length != 0)
		{
			int num = 0;
			bool flag = false;
			for (int i = 0; i < string_15.Length; i++)
			{
				if (!(string_15[i] != string_16) && !flag)
				{
					if (bool_1)
					{
						flag = true;
					}
				}
				else
				{
					string_15[num] = string_15[i];
					num++;
				}
			}
			if (num != 0)
			{
				if (num < string_15.Length)
				{
					Array.Resize(ref string_15, num);
				}
			}
			else
			{
				string_15 = null;
			}
		}
		else
		{
			string_15 = null;
		}
	}

	public static int smethod_26(string[] string_15, string string_16, bool bool_1 = false)
	{
		if (string_15 != null)
		{
			for (int i = 0; i < string_15.Length; i++)
			{
				int num;
				if (!(string_16 == string_15[i]))
				{
					if (!bool_1)
					{
						if (0 > smethod_2(string_15[i], string_16) && 0 > smethod_2(string_16, string_15[i]))
						{
							continue;
						}
						goto IL_0048;
					}
					num = 1;
				}
				else
				{
					num = 0;
				}
				if (num != 0)
				{
					continue;
				}
				goto IL_0048;
				IL_0048:
				return i;
			}
		}
		return -1;
	}

	public static bool smethod_27(string string_15)
	{
		bool result = false;
		try
		{
			FileAttributes attributes = File.GetAttributes(string_15);
			result = ((attributes & FileAttributes.Directory) == FileAttributes.Directory);
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string smethod_28(string string_15, int int_2 = 0, int int_3 = 0, byte byte_0 = 1)
	{
		if (string_15 != null && !(string_15 == "") && File.Exists(string_15))
		{
			string text = "";
			try
			{
				switch (byte_0)
				{
				case 1:
					text = File.ReadAllText(string_15);
					break;
				case 2:
					text = File.ReadAllText(string_15, Encoding.ASCII);
					break;
				case 4:
					text = File.ReadAllText(string_15, Encoding.UTF8);
					break;
				case 5:
					text = File.ReadAllText(string_15, Encoding.UTF32);
					break;
				default:
					text = File.ReadAllText(string_15, Encoding.Default);
					break;
				case 6:
					text = File.ReadAllText(string_15, Encoding.Unicode);
					break;
				case 3:
					text = File.ReadAllText(string_15, Encoding.UTF7);
					break;
				}
				if (int_2 > 0)
				{
					text = text.Replace(" ", "");
				}
				if (int_3 > 0)
				{
					text = text.Replace("\n", "");
				}
			}
			catch
			{
				text = "";
			}
			return text;
		}
		return "";
	}

	public static void smethod_29(string string_15, string string_16, byte byte_0 = 1)
	{
		if (string_15 != null && !(string_15 == ""))
		{
			if (string_16 == null)
			{
				string_16 = "";
			}
			try
			{
				switch (byte_0)
				{
				case 1:
					File.WriteAllText(string_15, string_16);
					break;
				case 3:
					File.WriteAllText(string_15, string_16, Encoding.UTF7);
					break;
				case 4:
					File.WriteAllText(string_15, string_16, Encoding.UTF8);
					break;
				case 6:
					File.WriteAllText(string_15, string_16, Encoding.Unicode);
					break;
				default:
					File.WriteAllText(string_15, string_16, Encoding.Default);
					break;
				case 5:
					File.WriteAllText(string_15, string_16, Encoding.UTF32);
					break;
				case 2:
					File.WriteAllText(string_15, string_16, Encoding.ASCII);
					break;
				}
			}
			catch
			{
			}
		}
	}

	public static string smethod_30(string string_15, string string_16, byte[] byte_0 = null)
	{
		if (string_15 != null && !(string_15 == ""))
		{
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_16, byte_0);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(string_15)))
				{
					using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(stream2))
						{
							return streamReader.ReadToEnd();
						}
					}
				}
			}
			catch
			{
			}
			return string.Empty;
		}
		return string.Empty;
	}

	public static long smethod_31(string string_15)
	{
		long result = 0L;
		if (string_15 != null && string_15 != "")
		{
			try
			{
				result = Convert.ToInt64(string_15);
			}
			catch
			{
				result = 0L;
			}
		}
		return result;
	}

	public static void smethod_32(ref int[] int_2, int int_3)
	{
		if (int_2 != null && int_2.Length != 0)
		{
			int[] array = new int[int_2.Length + 1];
			for (int i = 0; i < int_2.Length; i++)
			{
				if (int_2[i] != int_3)
				{
					array[i] = int_2[i];
					continue;
				}
				return;
			}
			array[array.Length - 1] = int_3;
			int_2 = array;
		}
		else
		{
			int_2 = new int[1]
			{
				int_3
			};
		}
	}

	public static void smethod_33(ref int[] int_2, int int_3)
	{
		if (int_2 != null && int_2.Length != 0)
		{
			int num = 0;
			int[] array = new int[int_2.Length];
			for (int i = 0; i < int_2.Length; i++)
			{
				if (int_2[i] != int_3)
				{
					array[num] = int_2[i];
					num++;
				}
			}
			if (num == 0)
			{
				int_2 = null;
			}
			else if (num < int_2.Length)
			{
				int[] array2 = new int[num];
				for (int i = 0; i < num; i++)
				{
					array2[i] = array[i];
				}
				int_2 = array2;
			}
		}
		else
		{
			int_2 = null;
		}
	}

	public static int smethod_34(ref long[,] long_1, int int_2 = 1, int int_3 = 2)
	{
		if (int_2 < 1)
		{
			int_2 = 1;
		}
		if (long_1 == null)
		{
			if (int_3 > 0)
			{
				long_1 = new long[int_2, int_3];
			}
			return int_2;
		}
		int length = long_1.GetLength(0);
		int_3 = long_1.GetLength(1);
		long[,] array = new long[length + int_2, int_3];
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < int_3; j++)
			{
				array[i, j] = long_1[i, j];
			}
		}
		long_1 = array;
		return length + int_2;
	}

	public static void smethod_35(ref uint[] uint_2, uint uint_3)
	{
		if (uint_2 != null && uint_2.Length != 0)
		{
			uint[] array = new uint[uint_2.Length + 1];
			for (int i = 0; i < uint_2.Length; i++)
			{
				if (uint_2[i] != uint_3)
				{
					array[i] = uint_2[i];
					continue;
				}
				return;
			}
			array[array.Length - 1] = uint_3;
			uint_2 = array;
		}
		else
		{
			uint_2 = new uint[1]
			{
				uint_3
			};
		}
	}

	public static bool smethod_36(ref uint[] uint_2, uint uint_3)
	{
		if (uint_2 != null && uint_2.Length != 0)
		{
			int num = 0;
			uint[] array = new uint[uint_2.Length];
			for (int i = 0; i < uint_2.Length; i++)
			{
				if (uint_2[i] != uint_3)
				{
					array[num] = uint_2[i];
					num++;
				}
			}
			if (num == 0)
			{
				uint_2 = null;
				return true;
			}
			if (num >= uint_2.Length)
			{
				return false;
			}
			uint[] array2 = new uint[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = array[i];
			}
			uint_2 = array2;
			return true;
		}
		uint_2 = null;
		return false;
	}

	public static int smethod_37(int[] int_2, int int_3)
	{
		if (int_2 != null)
		{
			for (int i = 0; i < int_2.Length; i++)
			{
				if (int_2[i] == int_3)
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static int smethod_38(int[,] int_2, int int_3, int int_4)
	{
		if (int_2 != null)
		{
			for (int i = 0; i < int_2.GetLength(0); i++)
			{
				if (int_2[i, int_4] == int_3)
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static string smethod_39(string string_15)
	{
		string text = "";
		if (string_15 != null)
		{
			foreach (char c in string_15)
			{
				text = (((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c < '0' || c > '9')) ? (text + ((byte)c).ToString()) : (text + c));
			}
		}
		return text;
	}

	public static string smethod_40(object object_0, int int_2 = 8, bool bool_1 = true, bool bool_2 = false)
	{
		string text = string.Empty;
		if (object_0 == null || object_0.ToString() == "")
		{
			object_0 = "00";
		}
		try
		{
			long num = Convert.ToInt64(object_0);
			if (num < 0L)
			{
				int num2 = 4;
				byte[] bytes = BitConverter.GetBytes(num);
				if (bytes.Length == 8 && (bytes[4] != byte.MaxValue || bytes[5] != byte.MaxValue || bytes[6] != byte.MaxValue || bytes[7] != byte.MaxValue))
				{
					num2 = 8;
				}
				int num3 = bytes.Length;
				byte[] array = new byte[num2];
				for (int i = 0; i < num2; i++)
				{
					int num4 = num2 - i - 1;
					if (num3 <= num4)
					{
						break;
					}
					array[i] = bytes[num4];
				}
				text = BitConverter.ToString(array).Replace("-", string.Empty);
			}
			else
			{
				text = long.Parse(num.ToString()).ToString("x").ToUpper();
			}
		}
		catch
		{
		}
		while (text.Length < int_2)
		{
			text = "0" + text;
		}
		if (bool_2)
		{
			string text2 = "";
			if (text.Length % 2 != 0)
			{
				text = "0" + text;
			}
			while (text != string.Empty)
			{
				text2 += text.Substring(text.Length - 2, 2);
				text = text.Remove(text.Length - 2);
			}
			return text2;
		}
		if (bool_1)
		{
			text = "0x" + text;
		}
		return text;
	}

	public static byte[] smethod_41(string string_15, bool bool_1 = true)
	{
		if (string_15 != null && !(string_15 == ""))
		{
			int num = string_15.Length;
			if (bool_1)
			{
				num++;
			}
			byte[] array = new byte[num];
			char[] array2 = string_15.ToCharArray();
			for (int i = 0; i < array2.Length; i++)
			{
				array[i] = (byte)array2[i];
			}
			if (bool_1)
			{
				array[num - 1] = 0;
			}
			return array;
		}
		if (!bool_1)
		{
			return null;
		}
		return new byte[1];
	}

	public static byte[] smethod_42(string string_15, bool bool_1 = true)
	{
		if (string_15 != null && !(string_15 == ""))
		{
			int num = string_15.Length;
			if (bool_1)
			{
				num++;
			}
			byte[] array = new byte[num * 2];
			char[] array2 = string_15.ToCharArray();
			for (int i = 0; i < array2.Length; i++)
			{
				int num2 = array2[i];
				array[i * 2] = (byte)(num2 % 256);
				array[i * 2 + 1] = (byte)(num2 / 256);
			}
			return array;
		}
		if (!bool_1)
		{
			return null;
		}
		return new byte[2];
	}

	public static int smethod_43(string string_15, string string_16)
	{
		int num = 0;
		int startIndex = 0;
		while ((startIndex = string_15.IndexOf(string_16, startIndex)) != -1)
		{
			startIndex += string_16.Length;
			num++;
		}
		return num;
	}

	public static long[] smethod_44(string string_15, string string_16 = "*.*")
	{
		long num = 0L;
		long num2 = 0L;
		try
		{
			string[] files = Directory.GetFiles(string_15, string_16);
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(files[i]);
					num2++;
					num += fileInfo.Length;
					File.Delete(files[i]);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return new long[2]
		{
			num2,
			num
		};
	}

	public static bool smethod_45(string string_15, byte[] byte_0)
	{
		try
		{
			File.WriteAllBytes(string_15, byte_0);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static void smethod_46(string string_15, string string_16, bool bool_1)
	{
		if (string_15 == null || string_15 == string.Empty || !smethod_18(string_15))
		{
			return;
		}
		byte[] array = null;
		try
		{
			array = File.ReadAllBytes(string_15);
		}
		catch
		{
		}
		if (array == null || array.Length < 2)
		{
			return;
		}
		int num = array.Length;
		if (!bool_1)
		{
			if (array[num - 2] != 0 || array[num - 1] != 0)
			{
				return;
			}
		}
		else if (array[num - 2] != 254 || array[num - 1] != byte.MaxValue)
		{
			return;
		}
		for (long num2 = 0L; num2 < num - 2; num2++)
		{
			if (array[num2] < 128)
			{
				array[num2] += 128;
			}
			else
			{
				array[num2] -= 128;
			}
		}
		if (bool_1)
		{
			array[num - 2] = 0;
			array[num - 1] = 0;
		}
		else
		{
			array[num - 2] = 254;
			array[num - 1] = byte.MaxValue;
		}
		try
		{
			File.WriteAllBytes(string_16, array);
		}
		catch
		{
		}
	}

	public static byte[] smethod_47(byte[] byte_0, bool bool_1)
	{
		if (byte_0 != null && byte_0.Length >= 2)
		{
			int num = byte_0.Length;
			if (bool_1)
			{
				if (byte_0[num - 2] != 254 || byte_0[num - 1] != byte.MaxValue)
				{
					return byte_0;
				}
			}
			else if (byte_0[num - 2] != 0 || byte_0[num - 1] != 0)
			{
				return byte_0;
			}
			for (long num2 = 0L; num2 < num - 2; num2++)
			{
				if (byte_0[num2] < 128)
				{
					byte_0[num2] += 128;
				}
				else
				{
					byte_0[num2] -= 128;
				}
			}
			if (!bool_1)
			{
				byte_0[num - 2] = 254;
				byte_0[num - 1] = byte.MaxValue;
			}
			else
			{
				byte_0[num - 2] = 0;
				byte_0[num - 1] = 0;
			}
			return byte_0;
		}
		return byte_0;
	}

	public static string smethod_48(string string_15)
	{
		if (string_15 != null && !(string_15 == string.Empty))
		{
			string text = string.Empty;
			int length = string_15.Length;
			for (int i = 0; i < string_15.Length; i++)
			{
				char c = string_15[i];
				if (c > 'ᎇ')
				{
					c = (char)(c - (5225 + length));
				}
				text += c;
			}
			return text;
		}
		return string.Empty;
	}

	public static void smethod_49(ref uint[,] uint_2, uint[] uint_3)
	{
		if (uint_2 == null)
		{
			uint_2 = new uint[1, uint_3.Length];
			for (int i = 0; i < uint_3.Length; i++)
			{
				uint_2[0, i] = uint_3[i];
			}
			return;
		}
		int length = uint_2.GetLength(0);
		int length2 = uint_2.GetLength(1);
		if (uint_3 == null || uint_3.Length == 0 || length2 != uint_3.Length)
		{
			return;
		}
		uint[,] array = new uint[length + 1, length2];
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length2; j++)
			{
				array[i, j] = uint_2[i, j];
			}
		}
		for (int i = 0; i < length2; i++)
		{
			array[length, i] = uint_3[i];
		}
		length = array.GetLength(0);
		uint_2 = new uint[length, length2];
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length2; j++)
			{
				uint_2[i, j] = array[i, j];
			}
		}
	}

	public static void smethod_50(ref uint[,] uint_2, uint[] uint_3)
	{
		if (uint_2 != null && uint_2.GetLength(0) != 0)
		{
			if (uint_3 == null || uint_3.Length == 0 || uint_2.GetLength(1) != uint_3.Length)
			{
				return;
			}
			int length = uint_2.GetLength(0);
			int length2 = uint_2.GetLength(1);
			int num = 0;
			uint[,] array = new uint[length, length2];
			for (int i = 0; i < length; i++)
			{
				bool flag = true;
				for (int j = 0; j < length2; j++)
				{
					flag = (flag && uint_3[j] == uint_2[i, j]);
					array[num, j] = uint_2[i, j];
				}
				if (!flag)
				{
					num++;
				}
			}
			if (num == 0)
			{
				uint_2 = null;
			}
			else
			{
				if (num >= length)
				{
					return;
				}
				uint_2 = new uint[num, length2];
				for (int i = 0; i < num; i++)
				{
					for (int j = 0; j < length2; j++)
					{
						uint_2[i, j] = array[i, j];
					}
				}
			}
		}
		else
		{
			uint_2 = null;
		}
	}

	public static void smethod_51(ref long[,] long_1, long[] long_2)
	{
		try
		{
			if (long_1 != null)
			{
				int length = long_1.GetLength(0);
				int length2 = long_1.GetLength(1);
				if (long_2 != null && long_2.Length != 0 && length2 == long_2.Length)
				{
					long[,] array = new long[length + 1, length2];
					for (int i = 0; i < length; i++)
					{
						for (int j = 0; j < length2; j++)
						{
							array[i, j] = long_1[i, j];
						}
					}
					for (int i = 0; i < length2; i++)
					{
						array[length, i] = long_2[i];
					}
					length = array.GetLength(0);
					long_1 = new long[length, length2];
					for (int i = 0; i < length; i++)
					{
						for (int j = 0; j < length2; j++)
						{
							long_1[i, j] = array[i, j];
						}
					}
				}
			}
			else
			{
				long_1 = new long[1, long_2.Length];
				for (int i = 0; i < long_2.Length; i++)
				{
					long_1[0, i] = long_2[i];
				}
			}
		}
		catch
		{
		}
	}

	public static void smethod_52(ref long[,] long_1, long[] long_2)
	{
		try
		{
			if (long_1 != null && long_1.GetLength(0) != 0)
			{
				if (long_2 != null && long_2.Length != 0 && long_1.GetLength(1) == long_2.Length)
				{
					int length = long_1.GetLength(0);
					int length2 = long_1.GetLength(1);
					int num = 0;
					long[,] array = new long[length, length2];
					for (int i = 0; i < length; i++)
					{
						bool flag = true;
						for (int j = 0; j < length2; j++)
						{
							flag = (flag && long_2[j] == long_1[i, j]);
							array[num, j] = long_1[i, j];
						}
						if (!flag)
						{
							num++;
						}
					}
					if (num != 0)
					{
						if (num < length)
						{
							long_1 = new long[num, length2];
							for (int i = 0; i < num; i++)
							{
								for (int j = 0; j < length2; j++)
								{
									long_1[i, j] = array[i, j];
								}
							}
						}
					}
					else
					{
						long_1 = null;
					}
				}
			}
			else
			{
				long_1 = null;
			}
		}
		catch
		{
		}
	}

	public static int smethod_53(long[,] long_1, long long_2, int int_2 = 0)
	{
		if (long_1 != null)
		{
			for (int i = 0; i < long_1.GetLength(0); i++)
			{
				if (long_2 == long_1[i, int_2])
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static string smethod_54(string string_15)
	{
		if (string_15 != null)
		{
			string_15 = string_15.Replace(" ", string.Empty);
			if (string_15 != string.Empty)
			{
				byte[] array = new byte[string_15.Length / 2];
				try
				{
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = Convert.ToByte(string_15.Substring(i * 2, 2), 16);
					}
					return Encoding.ASCII.GetString(array);
				}
				catch
				{
				}
			}
		}
		return string.Empty;
	}

	public static string smethod_55(object object_0, int int_2, char char_45 = ' ')
	{
		string text = string.Empty;
		if (object_0 != null)
		{
			text = object_0.ToString();
		}
		while (text.Length < int_2)
		{
			text += char_45;
		}
		return text;
	}

	public static void smethod_56(RichTextBox richTextBox_0, string string_15, bool bool_1 = false)
	{
		if (string_15 != null && !(string_15 == string.Empty))
		{
			if (richTextBox_0.Text != string.Empty)
			{
				string_15 = Class47.string_3 + string_15;
			}
			int num = Class20.GetScrollPos(richTextBox_0.Handle, 1);
			richTextBox_0.AppendText(string_15);
			if (!bool_1)
			{
				Class20.GetScrollRange(richTextBox_0.Handle, 1, out int _, out int int_2);
				int num2 = (richTextBox_0.ClientSize.Height - SystemInformation.HorizontalScrollBarHeight) / richTextBox_0.Font.Height;
				num = int_2 - num2;
			}
			Class20.SetScrollPos(richTextBox_0.Handle, 1, num, bool_0: true);
			Class20.PostMessageA(richTextBox_0.Handle, 277, 4 + 65536 * num, 0);
		}
	}

	public static bool smethod_57(uint[] uint_2)
	{
		return uint_2 != null && uint_2.Length > 1 && uint_2[0] != 0 && uint_2[1] != 0;
	}

	[CompilerGenerated]
	private static SecureString smethod_58(SecureString secureString_0, char char_45)
	{
		secureString_0.AppendChar(char_45);
		return secureString_0;
	}
}
