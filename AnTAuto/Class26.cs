using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class Class26
{
	[StructLayout(LayoutKind.Sequential)]
	private class Class27
	{
		private int int_0 = 528;

		private byte byte_0 = 0;

		private byte byte_1 = 1;

		private byte byte_2 = 1;

		private byte byte_3 = 0;

		private byte byte_4 = 0;

		private byte byte_5 = 160;

		private byte byte_6 = 236;

		private byte byte_7 = 0;

		private byte byte_8 = 0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		private byte[] byte_9 = new byte[16];
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Class28
	{
		private int int_0;

		private int int_1;

		private int int_2;
	}

	private const int int_0 = 64;

	public static long long_0;

	public static bool bool_0 = false;

	public static string[] string_0 = null;

	public static string string_1 = string.Empty;

	public static string string_2 = string.Empty;

	public static uint uint_0 = 0u;

	public static int int_1 = Class55.smethod_3("fMultiHd", 0, "0");

	private static char[] char_0 = new char[20]
	{
		'ᓙ',
		'ᓙ',
		'ᒫ',
		'ᓙ',
		'ᓍ',
		'ᓥ',
		'ᓶ',
		'ᓰ',
		'ᓦ',
		'ᓠ',
		'ᓞ',
		'ᓩ',
		'ᓁ',
		'ᓯ',
		'ᓦ',
		'ᓳ',
		'ᓢ',
		'ᓸ',
		'ᒭ',
		'ᓺ'
	};

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateFile(string string_3, uint uint_1, uint uint_2, IntPtr intptr_0, uint uint_3, uint uint_4, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	private static extern int DeviceIoControl(IntPtr intptr_0, uint uint_1, IntPtr intptr_1, uint uint_2, ref Struct10 struct10_0, uint uint_3, ref uint uint_4, [Out] IntPtr intptr_2);

	[DllImport("kernel32.dll", EntryPoint = "DeviceIoControl")]
	private static extern int DeviceIoControl_1(IntPtr intptr_0, uint uint_1, ref Struct11 struct11_0, uint uint_2, ref Struct14 struct14_0, uint uint_3, ref uint uint_4, [Out] IntPtr intptr_1);

	[DllImport("Iphlpapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern int GetAdaptersInfo(IntPtr intptr_0, ref uint uint_1);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeviceIoControl_2([In] IntPtr intptr_0, [In] uint uint_1, [Optional] [In] IntPtr intptr_1, [In] uint uint_2, [Optional] [Out] IntPtr intptr_2, [In] uint uint_3, out uint uint_4, [Optional] [In] [Out] IntPtr intptr_3);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "CreateFile", SetLastError = true)]
	internal static extern IntPtr CreateFile_1([In] string string_3, [In] GEnum5 genum5_0, [In] GEnum6 genum6_0, [Optional] [In] IntPtr intptr_0, [In] GEnum4 genum4_0, [In] uint uint_1, [Optional] [In] IntPtr intptr_1);

	[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr CallWindowProcW([In] byte[] byte_0, IntPtr intptr_0, int int_2, [In] [Out] byte[] byte_1, IntPtr intptr_1);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool VirtualProtect([In] byte[] byte_0, IntPtr intptr_0, int int_2, out int int_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern bool GetVolumeInformation(string string_3, StringBuilder stringBuilder_0, uint uint_1, out uint uint_2, out uint uint_3, out uint uint_4, StringBuilder stringBuilder_1, uint uint_5);

	public static void smethod_0()
	{
		int int_ = 0;
		string[] array = new string[3]
		{
            "zDriver",
            "VLAuto",
            "System"
        };
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				if (Class20.smethod_0(Class11.smethod_16(array[i]), ref int_) && int_ == 1)
				{
					return;
				}
			}
			catch
			{
			}
		}
		string_0 = smethod_6(0);
		int num = smethod_5(string_0);
		if (num > 0 && int_1 > 0 && !bool_0)
		{
			byte b = 1;
			while (b < 16)
			{
				string[] array2 = smethod_6(b);
				int num2 = smethod_5(array2);
				if (num2 <= 0 || !bool_0)
				{
					b = (byte)(b + 1);
					continue;
				}
				for (int j = 0; j < string_0.Length; j++)
				{
					if (string_2 != null && string_2 != string.Empty)
					{
						string_2 += "-";
					}
					string_2 += string_0[j];
					string_0[j] = array2[j];
				}
				break;
			}
		}
        string_1 = string.Empty;
		for (int j = 0; j < string_0.Length; j++)
		{
			if (string_1 != null && string_1 != string.Empty)
			{
				string_1 += "-";
			}
			string_1 += string_0[j];
			if (j == string_0.Length - 2)
			{
				uint_0 = Class11.smethod_7(string_0[j]);
			}
		}
    }

	private static GStruct15 smethod_1(byte byte_0)
	{
		char[] char_ = new char[12]
		{
			'ᓑ',
			'ᓑ',
			'ᒣ',
			'ᓑ',
			'ᓈ',
			'ᓢ',
			'ᓖ',
			'ᓧ',
			'ᓩ',
			'ᓫ',
			'ᓨ',
			'ᓙ'
		};
		GStruct15 gStruct = default(GStruct15);
		gStruct.md = "";
		gStruct.sr = "";
		gStruct.fr = "";
		gStruct.cap = 0u;
		GStruct15 result = gStruct;
		try
		{
			Struct10 struct10_ = default(Struct10);
			Struct11 struct11_ = default(Struct11);
			Struct14 struct14_ = default(Struct14);
			IntPtr intPtr = CreateFile(Class11.smethod_1(char_), 0u, 0u, IntPtr.Zero, 1u, 0u, IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				return result;
			}
			uint uint_ = 0u;
			if (DeviceIoControl(intPtr, 475264u, IntPtr.Zero, 0u, ref struct10_, (uint)Marshal.SizeOf((object)struct10_), ref uint_, IntPtr.Zero) != 0 && (struct10_.uint_0 & 1) != 0)
			{
				struct11_.struct12_0.byte_5 = 160;
				if ((byte_0 & 1) != 0)
				{
					struct11_.struct12_0.byte_5 = 176;
				}
				if ((struct10_.uint_0 & (16 >> (int)byte_0)) == 0L)
				{
					struct11_.struct12_0.byte_6 = 236;
					struct11_.byte_0 = byte_0;
					struct11_.struct12_0.byte_1 = 1;
					struct11_.struct12_0.byte_2 = 1;
					struct11_.uint_0 = 512u;
					if (DeviceIoControl_1(intPtr, 508040u, ref struct11_, (uint)Marshal.SizeOf((object)struct11_), ref struct14_, (uint)Marshal.SizeOf((object)struct14_), ref uint_, IntPtr.Zero) != 0)
					{
						result = smethod_3(struct14_.struct15_0);
					}
				}
			}
			CloseHandle(intPtr);
		}
		catch
		{
		}
		return result;
	}

	private static GStruct15 smethod_2(byte byte_0)
	{
		GStruct15 gStruct = default(GStruct15);
		gStruct.md = string.Empty;
		gStruct.sr = string.Empty;
		gStruct.fr = string.Empty;
		gStruct.cap = 0u;
		GStruct15 result = gStruct;
		try
		{
			Struct10 struct10_ = default(Struct10);
			Struct11 struct11_ = default(Struct11);
			Struct14 struct14_ = default(Struct14);
			string format = Class11.smethod_1(char_0);
			string string_ = string.Format(format, byte_0);
			IntPtr intPtr = CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				return result;
			}
			uint uint_ = 0u;
			if (DeviceIoControl(intPtr, 475264u, IntPtr.Zero, 0u, ref struct10_, (uint)Marshal.SizeOf((object)struct10_), ref uint_, IntPtr.Zero) != 0 && (struct10_.uint_0 & 1) != 0)
			{
				struct11_.struct12_0.byte_5 = 160;
				if ((byte_0 & 1) != 0)
				{
					struct11_.struct12_0.byte_5 = 176;
				}
				if ((struct10_.uint_0 & (16 >> (int)byte_0)) == 0L)
				{
					struct11_.struct12_0.byte_6 = 236;
					struct11_.byte_0 = byte_0;
					struct11_.struct12_0.byte_1 = 1;
					struct11_.struct12_0.byte_2 = 1;
					struct11_.uint_0 = 512u;
					if (DeviceIoControl_1(intPtr, 508040u, ref struct11_, (uint)Marshal.SizeOf((object)struct11_), ref struct14_, (uint)Marshal.SizeOf((object)struct14_), ref uint_, IntPtr.Zero) != 0)
					{
						result = smethod_3(struct14_.struct15_0);
					}
				}
			}
			CloseHandle(intPtr);
		}
		catch
		{
		}
		return result;
	}

	private static GStruct15 smethod_3(Struct15 struct15_0)
	{
		GStruct15 gStruct = default(GStruct15);
		gStruct.md = "";
		gStruct.sr = "";
		gStruct.fr = "";
		gStruct.cap = 0u;
		GStruct15 result = gStruct;
		try
		{
			smethod_4(struct15_0.byte_2);
			result.md = Encoding.ASCII.GetString(struct15_0.byte_2).Trim().Replace(" ", "")
				.ToUpper();
			smethod_4(struct15_0.byte_1);
			result.fr = Encoding.ASCII.GetString(struct15_0.byte_1).Trim().Replace(" ", "")
				.ToUpper();
			smethod_4(struct15_0.byte_0);
			result.sr = Encoding.ASCII.GetString(struct15_0.byte_0).Trim().Replace(" ", "")
				.ToUpper();
			result.cap = struct15_0.uint_1 / 2u / 1024u;
		}
		catch
		{
		}
		return result;
	}

	private static void smethod_4(byte[] byte_0)
	{
		int num = 0;
		sbyte b = 0;
		byte b2 = 0;
		while (true)
		{
			b = 0;
			if (num < byte_0.Length)
			{
				b = 1;
			}
			if (b != 0)
			{
				b2 = byte_0[num];
				byte_0[num] = byte_0[num + 1];
				byte_0[num + 1] = b2;
				num += 2;
				continue;
			}
			break;
		}
	}

	private static int smethod_5(string[] string_3)
	{
		int result = 0;
		long num = 0L;
		if (string_3 == null || string_3.Length < 2)
		{
			string_3 = new string[2]
			{
				Class11.smethod_1(Class11.char_5),
				Class11.smethod_1(Class11.char_5)
			};
		}
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_1(Class47.char_0));
		string[] array = new string[2]
		{
			Class47.string_5 + "\\" + Class11.smethod_1(Class11.char_33),
			environmentVariable + "\\" + Class11.smethod_1(Class11.char_33)
		};
		string text = null;
		int int_ = 0;
		int int_2 = Class20.OpenProcess(2035711, bool_0: false, Process.GetCurrentProcess().Id);
		byte[] array2 = new byte[4];
		byte[] array3 = null;
		byte[] array4 = new byte[8];
		string text2 = null;
		uint num2 = 6u;
		Class20.ReadProcessMemory(int_2, Class11.uint_0 + 1536, array2, 4, ref int_);
		int num3 = BitConverter.ToInt32(array2, 0);
		if (num3 > 0)
		{
			array3 = new byte[num3];
			Class20.ReadProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 4, array3, num3, ref int_);
			string text3 = Class10.smethod_4(array3);
			string text4 = string.Empty;
			int length = text3.Length;
			for (int i = 0; i < text3.Length; i++)
			{
				char c = text3[i];
				if (c > 'ᎅ')
				{
					c = (char)(c - (5225 + length));
				}
				text4 += c;
			}
			array4 = Encoding.ASCII.GetBytes(text4);
		}
/*
		for (int i = 0; i < array.Length; i++)
		{
			string string_4 = array[i];
			string text5 = Class11.smethod_28(string_4, 1, 1, 1);
			if (text5 != null && text5 != string.Empty)
			{
                text = Class11.smethod_30(text5, string_3[0], array4);
				if (text != null && text != string.Empty)
				{
					string string_5 = array[array.Length - 1 - i];
					Class11.smethod_29(string_5, text5, 1);
					break;
				}
			}
		}
*/
        num = DateTime.Now.AddDays(10).Ticks;
        result = 1;

        bool_0 = true;
        long_0 = new DateTime(2020,1,1).Ticks;

        int num4 = 1000;
/*
        text = "Tran|Minh|Sang|Tran|Minh|Sang|Tran|Minh|Sang";
        if (text != null && !(text == string.Empty))
		{
			string[] array5 = text.Split('|');
			int num5 = array5.Length;
			if (num5 == 9)
			{
				int num6 = num5 - 2;
				string text6 = Class11.smethod_16(array5[num6]);
				if (text6 != string.Empty)
				{
					int length2 = array5[num5 - 1].Length;
					num4 = Class11.smethod_12(text6);
					num4 = num4 - (text.Length - array5[num5 - 2].Length - length2) + 1;
				}
				string[] array6 = new string[num5 - 1];
				array6[0] = Class11.smethod_30(array5[0], string_3[0], array4);
				for (int i = 0; i < array6.Length; i++)
				{
					if (i < array6.Length - 1)
					{
						array6[i + 1] = Class11.smethod_30(array5[i + 1], array6[i], array4);
					}
					if (array6[i] != null && array6[i] != string.Empty)
					{
						if (text2 != null && text2 != string.Empty)
						{
							text2 += '\u0001';
						}
						text2 += array6[i];
					}
					if (i < string_3.Length)
					{
						if (i == 0)
						{
							bool_0 = (array6[i] == string_3[i]);
						}
						bool_0 = (bool_0 && array6[i] == string_3[i]);
					}
				}
				num = Class11.smethod_31(array6[6]);
				long_0 = Class11.smethod_31(array5[num5 - 1]);
				result = 1;
			}
			else
			{
				bool_0 = false;
			}
		}
		else
		{
			bool_0 = false;
			result = 0;
		}
*/
		if (array4 != null)
		{
			for (int i = 0; i < array4.Length; i++)
			{
				array4[i] = 0;
			}
		}
		num2 = 10u;
		array2 = BitConverter.GetBytes(Convert.ToInt32(Convert.ToByte(bool_0 && num4 > 0) * num4 + Convert.ToByte(!bool_0 || num4 <= 0) * 10));
		Class20.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256, array2, array2.Length, ref int_);
		array2 = BitConverter.GetBytes(Convert.ToInt32(Convert.ToByte(bool_0 && num4 > 0) * int.MaxValue + Convert.ToByte(!bool_0 || num4 <= 0) * 2));
		Class20.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 4, array2, array2.Length, ref int_);
		string text7 = num.ToString();
		array2 = BitConverter.GetBytes(text7.Length);
		Class20.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 8, array2, array2.Length, ref int_);
		array3 = Encoding.ASCII.GetBytes(text7);
		Class20.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 12, array3, array3.Length, ref int_);
		text2 = Class11.smethod_17(text2);
		if (text2 != null && text2 != string.Empty)
		{
			array2 = BitConverter.GetBytes(text2.Length);
			Class20.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 32, array2, array2.Length, ref int_);
			array3 = Encoding.ASCII.GetBytes(text2);
			Class20.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 36, array3, array3.Length, ref int_);
		}
		Class20.smethod_32(int_2);
		return result;
	}

	private static string[] smethod_6(byte byte_0)
	{
		string[] array = new string[6]
		{
			Class11.smethod_1(Class11.char_5),
			Class11.smethod_1(Class11.char_6),
			Class11.smethod_1(Class11.char_7),
			Class11.smethod_1(Class11.char_7),
			Class11.smethod_1(Class11.char_7),
			Class11.smethod_1(Class11.char_7)
		};
		GStruct15 gStruct = default(GStruct15);
		if (Environment.OSVersion.Platform != PlatformID.Win32Windows)
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				gStruct = smethod_2(byte_0);
			}
		}
		else
		{
			gStruct = smethod_1(byte_0);
		}
		if (gStruct.sr == null || gStruct.sr == string.Empty)
		{
			gStruct.sr = smethod_12();
		}
		if (gStruct.md != null && gStruct.md != string.Empty)
		{
			string text = gStruct.md.Replace(" ", string.Empty).ToUpper();
			if (text.Length > 6)
			{
				text = text.Substring(0, 6);
			}
			while (text.Length < 6)
			{
				text += "0";
			}
			array[1] = string.Empty;
			foreach (char c in text)
			{
				if (('0' <= c && c <= '9') || ('A' <= c && c <= 'Z'))
				{
					string[] array2;
					(array2 = array)[1] = array2[1] + c;
				}
				else
				{
					string[] array2;
					(array2 = array)[1] = array2[1] + ((byte)c).ToString();
				}
			}
		}
		string text2 = smethod_9();
		string string_ = (gStruct.fr + gStruct.cap + gStruct.sr + text2).ToUpper();
		string text3 = smethod_8(string_);
		if (text3 != null && text3 != string.Empty)
		{
			int num = 1;
			int num2 = -1;
			for (int i = 0; i < text3.Length; i++)
			{
				if (num2 < 0 || num2 > 10)
				{
					num2 = 0;
					num++;
					if (array.Length <= num)
					{
						break;
					}
					array[num] = string.Empty;
				}
				string[] array2;
				string[] array3 = array2 = array;
				int num3 = num;
				IntPtr intPtr = (IntPtr)num3;
				array3[num3] = array2[(long)intPtr] + text3[i];
				num2++;
			}
		}
		array[5] = smethod_7();
		return array;
	}

	private static string smethod_7(string string_3 = null)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		StringBuilder stringBuilder2 = new StringBuilder(256);
		char[] char_ = new char[9]
		{
			'ᒺ',
			'ᓁ',
			'ᒿ',
			'ᒷ',
			'ᒶ',
			'ᓄ',
			'ᒻ',
			'ᓈ',
			'ᒷ'
		};
		if (string_3 == null)
		{
			string_3 = Environment.GetEnvironmentVariable(Class11.smethod_1(char_));
			if (string_3 == string.Empty || string_3 == null)
			{
				return string.Empty;
			}
			string_3 = string_3[0] + ":\\";
		}
		GetVolumeInformation(string_3, stringBuilder, (uint)(stringBuilder.Capacity - 1), out uint uint_, out uint _, out uint _, stringBuilder2, (uint)(stringBuilder2.Capacity - 1));
		return uint_.ToString();
	}

	private static string smethod_8(string string_3)
	{
		string text = string.Empty;
		if (string_3 != null && string_3 != string.Empty)
		{
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_3));
				if (array != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						text += array[i].ToString("X2");
					}
				}
			}
		}
		while (text.Length < 33)
		{
			text += '0';
		}
		return text;
	}

	public static string smethod_9()
	{
		byte[] byte_ = new byte[8];
		if (smethod_10(ref byte_))
		{
			return string.Format("{0}{1}", BitConverter.ToUInt32(byte_, 4).ToString("X8"), BitConverter.ToUInt32(byte_, 0).ToString("X8"));
		}
		return string.Empty;
	}

	private static bool smethod_10(ref byte[] byte_0)
	{
		byte[] array = new byte[26]
		{
			85,
			137,
			229,
			87,
			139,
			125,
			16,
			106,
			1,
			88,
			83,
			15,
			162,
			137,
			7,
			137,
			87,
			4,
			91,
			95,
			137,
			236,
			93,
			194,
			16,
			0
		};
		byte[] array2 = new byte[19]
		{
			83,
			72,
			199,
			192,
			1,
			0,
			0,
			0,
			15,
			162,
			65,
			137,
			0,
			65,
			137,
			80,
			4,
			91,
			195
		};
		byte[] array3 = (IntPtr.Size == 8) ? array2 : array;
		IntPtr intptr_ = new IntPtr(array3.Length);
		if (!VirtualProtect(array3, intptr_, 64, out int _))
		{
			Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
		}
		intptr_ = new IntPtr(byte_0.Length);
		try
		{
			return CallWindowProcW(array3, IntPtr.Zero, 0, byte_0, intptr_) != IntPtr.Zero;
		}
		catch
		{
		}
		return false;
	}

	private static bool smethod_11(string string_3)
	{
		try
		{
			IntPtr zero = IntPtr.Zero;
			string format = Class11.smethod_1(char_0);
			for (int i = 0; i < 16; i++)
			{
				string string_4 = string.Format(format, i);
				zero = CreateFile_1(string_4, GEnum5.GenericWrite | GEnum5.GenericRead, GEnum6.Read | GEnum6.Write, IntPtr.Zero, GEnum4.OpenExisting, 0u, IntPtr.Zero);
				if ((int)zero > 0)
				{
					string text = smethod_13(zero);
					if (text == null || text.Length == 0)
					{
						text = smethod_14(zero);
					}
					CloseHandle(zero);
					if (string_3 == text)
					{
						return true;
					}
				}
			}
		}
		catch
		{
		}
		return false;
	}

	private static string smethod_12()
	{
		string text = string.Empty;
		try
		{
			IntPtr zero = IntPtr.Zero;
			string format = Class11.smethod_1(char_0);
			for (int i = 0; i < 16; i++)
			{
				string string_ = string.Format(format, i);
				zero = CreateFile_1(string_, GEnum5.GenericWrite | GEnum5.GenericRead, GEnum6.Read | GEnum6.Write, IntPtr.Zero, GEnum4.OpenExisting, 0u, IntPtr.Zero);
				if ((int)zero > 0)
				{
					text = smethod_13(zero);
					if (text == null || text.Length == 0)
					{
						text = smethod_14(zero);
					}
					CloseHandle(zero);
					if (text != null && text.Length > 0)
					{
						break;
					}
				}
			}
		}
		catch
		{
		}
		return text;
	}

	private static string smethod_13(IntPtr intptr_0)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(32);
		IntPtr intPtr2 = Marshal.AllocHGlobal(24);
		string result = string.Empty;
		uint uint_ = 0u;
		try
		{
			if (DeviceIoControl_2(intptr_0, 475264u, IntPtr.Zero, 0u, intPtr2, 24u, out uint_, IntPtr.Zero) && (Marshal.ReadInt32(intPtr2, 4) & 4) > 0)
			{
				Class27 structure = new Class27();
				intPtr2 = Marshal.ReAllocHGlobal(intPtr2, (IntPtr)528);
				Marshal.StructureToPtr((object)structure, intPtr, fDeleteOld: true);
				if (DeviceIoControl_2(intptr_0, 508040u, intPtr, 32u, intPtr2, 528u, out uint_, IntPtr.Zero))
				{
					string text = Marshal.PtrToStringAnsi((IntPtr)(intPtr2.ToInt32() + 36), 20);
					if (text.Length != 0)
					{
						char[] array = text.ToCharArray();
						for (int i = 0; i <= array.Length - 2; i += 2)
						{
							char c = array[i];
							array[i] = array[i + 1];
							array[i + 1] = c;
						}
						result = new string(array).Trim();
					}
				}
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
			Marshal.FreeHGlobal(intPtr2);
		}
		return result;
	}

	private static string smethod_14(IntPtr intptr_0)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(12);
		IntPtr intPtr2 = Marshal.AllocHGlobal(1024);
		Class28 structure = new Class28();
		string result = string.Empty;
		uint uint_ = 0u;
		try
		{
			Marshal.StructureToPtr((object)structure, intPtr, fDeleteOld: true);
			if (DeviceIoControl_2(intptr_0, 2954240u, intPtr, 12u, intPtr2, 1024u, out uint_, IntPtr.Zero))
			{
				int num = intPtr2.ToInt32();
				int num2 = Marshal.ReadInt32(intPtr2, 24);
				if (num2 != 0)
				{
					string text = Marshal.PtrToStringAnsi((IntPtr)(num + num2));
					if (text.Length != 0)
					{
						StringBuilder stringBuilder = new StringBuilder();
						for (int i = 0; i < text.Length; i += 4)
						{
							for (int num3 = 1; num3 >= 0; num3--)
							{
								int num4 = 0;
								for (int j = 0; j < 2; j++)
								{
									num4 *= 16;
									switch (text[i + num3 * 2 + j])
									{
									case '0':
										num4 = num4;
										break;
									case '1':
										num4++;
										break;
									case '2':
										num4 += 2;
										break;
									case '3':
										num4 += 3;
										break;
									case '4':
										num4 += 4;
										break;
									case '5':
										num4 += 5;
										break;
									case '6':
										num4 += 6;
										break;
									case '7':
										num4 += 7;
										break;
									case '8':
										num4 += 8;
										break;
									case '9':
										num4 += 9;
										break;
									}
								}
								if (num4 > 0)
								{
									stringBuilder.Append((char)num4);
								}
							}
						}
						result = stringBuilder.ToString().Trim();
					}
				}
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
			Marshal.FreeHGlobal(intPtr2);
		}
		return result;
	}
}
