using System;
using System.Text;

internal class Class10
{
	public static char[] char_0;

	private static char[] char_1;

	private static char[] char_2;

	private static char[] char_3;

	static Class10()
	{
		char_0 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzàáảãạăằắẳẵặâầấẩẫậđèéẻẽẹêềếểễệìíỉĩịòóỏõọôồốổỗộơờớởỡợùúủũụưừứửữựỳýỷỹỵĂÂĐÊÔƠƯÙ".ToCharArray();
		char_2 = new char[75]
		{
			'µ',
			'\u00b8',
			'¶',
			'·',
			'¹',
			'\u00a8',
			'»',
			'¾',
			'¼',
			'½',
			'Æ',
			'©',
			'Ç',
			'Ê',
			'È',
			'É',
			'Ë',
			'®',
			'Ì',
			'Ð',
			'Î',
			'Ï',
			'Ñ',
			'ª',
			'Ò',
			'Õ',
			'Ó',
			'Ô',
			'Ö',
			'×',
			'Ý',
			'Ø',
			'Ü',
			'Þ',
			'ß',
			'ã',
			'á',
			'â',
			'ä',
			'«',
			'å',
			'è',
			'æ',
			'ç',
			'é',
			'¬',
			'ê',
			'í',
			'ë',
			'ì',
			'î',
			'ï',
			'ó',
			'ñ',
			'ò',
			'ô',
			'­',
			'õ',
			'ø',
			'ö',
			'÷',
			'ù',
			'ú',
			'ý',
			'û',
			'ü',
			'þ',
			'¡',
			'¢',
			'§',
			'£',
			'¤',
			'¥',
			'¦',
			'Ù'
		};
		char_3 = new char[75]
		{
			'à',
			'á',
			'ả',
			'ã',
			'ạ',
			'ă',
			'ằ',
			'ắ',
			'ẳ',
			'ẵ',
			'ặ',
			'â',
			'ầ',
			'ấ',
			'ẩ',
			'ẫ',
			'ậ',
			'đ',
			'è',
			'é',
			'ẻ',
			'ẽ',
			'ẹ',
			'ê',
			'ề',
			'ế',
			'ể',
			'ễ',
			'ệ',
			'ì',
			'í',
			'ỉ',
			'ĩ',
			'ị',
			'ò',
			'ó',
			'ỏ',
			'õ',
			'ọ',
			'ô',
			'ồ',
			'ố',
			'ổ',
			'ỗ',
			'ộ',
			'ơ',
			'ờ',
			'ớ',
			'ở',
			'ỡ',
			'ợ',
			'ù',
			'ú',
			'ủ',
			'ũ',
			'ụ',
			'ư',
			'ừ',
			'ứ',
			'ử',
			'ữ',
			'ự',
			'ỳ',
			'ý',
			'ỷ',
			'ỹ',
			'ỵ',
			'Ă',
			'Â',
			'Đ',
			'Ê',
			'Ô',
			'Ơ',
			'Ư',
			'Ù'
		};
		char_1 = new char[256];
		for (int i = 0; i < 256; i++)
		{
			char_1[i] = (char)i;
		}
		for (int i = 0; i < char_2.Length; i++)
		{
			char_1[char_2[i]] = char_3[i];
		}
	}

	public static bool smethod_0(char char_4)
	{
		int num = 0;
		while (true)
		{
			if (num < char_0.Length)
			{
				if (char_4 == char_0[num])
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static string smethod_1(string string_0, byte byte_0 = 1, bool bool_0 = false)
	{
		if (string_0 != null && !(string_0 == string.Empty))
		{
			if (byte_0 > 0)
			{
				char_1[217] = '\u00a0';
			}
			else
			{
				char_1[217] = 'Ù';
			}
			char[] array = string_0.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] >= 'Ā')
				{
					continue;
				}
				if (array[i] == char_1[array[i]])
				{
					if (bool_0 && (byte)array[i] > 127)
					{
						array[i] = ' ';
					}
				}
				else
				{
					array[i] = char_1[array[i]];
				}
			}
			return new string(array);
		}
		return string.Empty;
	}

	public static string smethod_2(string string_0)
	{
		char[] array = string_0.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] <= '\u007f')
			{
				continue;
			}
			for (int j = 0; j < char_3.Length; j++)
			{
				if (array[i] == char_3[j])
				{
					array[i] = char_2[j];
					break;
				}
			}
		}
		return new string(array);
	}

	public static string smethod_3(byte[] byte_0)
	{
		int num = Array.IndexOf(byte_0, (byte)0);
		num = ((num >= 0) ? num : byte_0.Length);
		string text = Encoding.UTF7.GetString(byte_0, 0, num);
		if (text == null)
		{
			text = string.Empty;
		}
		return text;
	}

	public static string smethod_4(byte[] byte_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = byte_0.Length;
			int i = 0;
			string text = string.Empty;
			for (; i < num; i += 2)
			{
				int num2 = byte_0[i] + byte_0[i + 1] * 256;
				if (num2 == 0)
				{
					break;
				}
				char c = (char)num2;
				text += c;
			}
			return text;
		}
		return string.Empty;
	}

	public static string[] smethod_5(ref string[] string_0, bool bool_0)
	{
		if (string_0 != null && string_0.Length != 0)
		{
			string[] array = new string[string_0.Length];
			for (int i = 0; i < string_0.Length; i++)
			{
				if (string_0[i] == null)
				{
					string_0[i] = string.Empty;
				}
				else
				{
					string_0[i] = string_0[i].Trim();
				}
				array[i] = smethod_1(string_0[i], 1);
				if (bool_0)
				{
					array[i] = array[i].ToUpper();
				}
			}
			return array;
		}
		return null;
	}
}
