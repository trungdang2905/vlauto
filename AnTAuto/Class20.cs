using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;

internal class Class20
{
	public struct Struct9
	{
		public string string_0;

		public uint uint_0;
	}

	public const int int_0 = 1;

	public const int int_1 = 277;

	public const int int_2 = 4;

	private const int int_3 = 4096;

	private const int int_4 = 4100;

	private const int int_5 = 4101;

	private const int int_6 = 4102;

	private const int int_7 = 4139;

	private const int int_8 = 4140;

	private const int int_9 = 4146;

	private const int int_10 = 4171;

	private const uint uint_0 = 1u;

	private const uint uint_1 = 1u;

	private const uint uint_2 = 2u;

	private const uint uint_3 = 8u;

	private const uint uint_4 = 4096u;

	private const uint uint_5 = 8192u;

	private const uint uint_6 = 61440u;

	private const uint uint_7 = 2035711u;

	private const uint uint_8 = 4096u;

	private const uint uint_9 = 32768u;

	private const uint uint_10 = 4u;

	private const int int_11 = 4116;

	private const int int_12 = 16;

	private const int int_13 = 1;

	private const int int_14 = 4;

	private const int int_15 = 2;

	private const int int_16 = 23;

	public static int int_17 = 16;

	public static int int_18 = 0;

	public static int int_19 = 5;

	public static int int_20 = 6;

	public static int int_21 = 9;

	public static int int_22 = 256;

	public static int int_23 = 257;

	public static int int_24 = 39;

	public static int int_25 = 512;

	public static int int_26 = 516;

	public static int int_27 = 517;

	public static int int_28 = 518;

	public static int int_29 = 2;

	public static int int_30 = 513;

	public static int int_31 = 514;

	public static int int_32 = 515;

	public static int int_33 = 1;

	public static GStruct41[] gstruct41_0 = new GStruct41[3]
	{
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
				50,
				54
			}
		}
	};

	public static int int_34 = Class55.smethod_3("RunAdmin", 0, "1");

	[DllImport("kernel32.dll")]
	public static extern int GetUserDefaultLCID();

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowRect(uint uint_11, ref GStruct12 gstruct12_0);

	[DllImport("User32.Dll")]
	public static extern bool ClientToScreen(uint uint_11, ref GStruct11 gstruct11_0);

	[DllImport("user32.dll")]
	public static extern uint SendInput(uint uint_11, [In] [MarshalAs(UnmanagedType.LPArray)] GStruct8[] gstruct8_0, int int_35);

	[DllImport("Kernel32.dll")]
	public static extern uint QueryFullProcessImageName(IntPtr intptr_0, uint uint_11, StringBuilder stringBuilder_0, out uint uint_12);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int GetScrollPos(IntPtr intptr_0, int int_35);

	[DllImport("user32.dll")]
	public static extern int SetScrollPos(IntPtr intptr_0, int int_35, int int_36, bool bool_0);

	[DllImport("user32.dll")]
	public static extern bool GetScrollRange(IntPtr intptr_0, int int_35, out int int_36, out int int_37);

	[DllImport("user32.dll")]
	public static extern bool PostMessageA(IntPtr intptr_0, int int_35, int int_36, int int_37);

	[DllImport("User32.Dll")]
	public static extern bool GetCursorPos(ref GStruct11 gstruct11_0);

	[DllImport("kernel32.dll")]
	private static extern uint SuspendThread(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern int ResumeThread(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(GEnum2 genum2_0, bool bool_0, uint uint_11);

	[DllImport("kernel32.dll")]
	private static extern bool TerminateThread(IntPtr intptr_0, uint uint_11);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtQueryInformationThread(IntPtr intptr_0, int int_35, IntPtr intptr_1, int int_36, IntPtr intptr_2);

	[DllImport("User32.Dll")]
	public static extern long SetCursorPos(int int_35, int int_36);

	[DllImport("kernel32.dll")]
	public static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, GEnum3 genum3_0, IntPtr intptr_2, string string_2, ref GStruct2 gstruct2_0, out GStruct3 gstruct3_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenSCManagerW(string string_0, string string_1, uint uint_11);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr OpenService(IntPtr intptr_0, string string_0, uint uint_11);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ControlService(IntPtr intptr_0, int int_35, ref GStruct5 gstruct5_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseServiceHandle(IntPtr intptr_0);

	public static bool smethod_0(string string_0, ref int int_35)
	{
		bool result = false;
		GStruct5 gstruct5_ = default(GStruct5);
		IntPtr intPtr = OpenSCManagerW("", null, 983103u);
		if (intPtr != IntPtr.Zero)
		{
			IntPtr intPtr2 = OpenService(intPtr, string_0, 983103u);
			if (intPtr2 != IntPtr.Zero)
			{
				result = ControlService(intPtr2, 1, ref gstruct5_);
				int_35 = gstruct5_.int_1;
				CloseServiceHandle(intPtr2);
			}
			CloseServiceHandle(intPtr);
		}
		return result;
	}

	[DllImport("User32.dll")]
	public static extern int FindWindow(string string_0, string string_1);

	[DllImport("User32.dll")]
	public static extern uint FindWindowEx(uint uint_11, uint uint_12, string string_0, string string_1);

	[DllImport("user32.dll")]
	public static extern uint GetWindowThreadProcessId(uint uint_11, out int int_35);

	[DllImport("user32.dll")]
	public static extern int GetWindowText(uint uint_11, StringBuilder stringBuilder_0, int int_35);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetClassName(uint uint_11, StringBuilder stringBuilder_0, int int_35);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
	public static extern uint GetWindowThreadProcessId_1(uint uint_11, out uint uint_12);

	[DllImport("kernel32.dll")]
	public static extern int OpenProcess(int int_35, bool bool_0, int int_36);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	public static extern uint VirtualAllocEx(int int_35, uint uint_11, uint uint_12, GEnum0 genum0_0, GEnum1 genum1_0);

	[DllImport("kernel32.dll")]
	public static extern bool VirtualFreeEx(int int_35, uint uint_11, uint uint_12, uint uint_13);

	[DllImport("kernel32.dll")]
	public static extern uint CreateRemoteThread(int int_35, IntPtr intptr_0, uint uint_11, uint uint_12, uint uint_13, uint uint_14, out uint uint_15);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint WaitForSingleObject(IntPtr intptr_0, uint uint_11);

	public static uint smethod_1(int int_35, uint uint_11 = 512u, GEnum1 genum1_0 = GEnum1.ExecuteReadWrite)
	{
		return VirtualAllocEx(int_35, 0u, uint_11, GEnum0.Commit | GEnum0.Reserve, genum1_0);
	}

	public static bool smethod_2(int int_35, uint uint_11)
	{
		return VirtualFreeEx(int_35, uint_11, 0u, 32768u);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern uint GetProcAddress(uint uint_11, string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint GetModuleHandle(string string_0);

	[DllImport("kernel32.dll")]
	public static extern bool ReadProcessMemory(int int_35, uint uint_11, byte[] byte_0, int int_36, ref int int_37);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(int int_35, uint uint_11, byte[] byte_0, int int_36, ref int int_37);

	[DllImport("kernel32", EntryPoint = "WriteProcessMemory")]
	public static extern bool WriteProcessMemory_1(int int_35, uint uint_11, ref GStruct4 gstruct4_0, int int_36, int int_37 = 0);

	[DllImport("user32.dll")]
	public static extern bool EnableWindow(uint uint_11, bool bool_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWindowEnabled(uint uint_11);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(uint uint_11, int int_35);

	[DllImport("user32.dll")]
	public static extern IntPtr SetForegroundWindow(uint uint_11);

	[DllImport("user32.dll")]
	public static extern uint GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern short VkKeyScan(int int_35);

	[DllImport("User32.Dll", EntryPoint = "PostMessageA")]
	public static extern bool PostMessageA_1(uint uint_11, int int_35, uint uint_12, uint uint_13);

	[DllImport("user32.dll")]
	public static extern int SendMessage(uint uint_11, int int_35, int int_36, uint uint_12);

	[DllImport("user32.dll")]
	public static extern int MapVirtualKey(uint uint_11, uint uint_12);

	public static void smethod_3(uint uint_11, uint uint_12)
	{
		PostMessageA_1(uint_11, int_22, uint_12, 0u);
		PostMessageA_1(uint_11, int_23, uint_12, 0u);
	}

	public static void smethod_4(uint uint_11, uint uint_12)
	{
		short uint_13 = VkKeyScan((int)uint_12);
		short num = (short)MapVirtualKey((uint)uint_13, 0u);
		uint num2 = (uint)((num << 16) | 1);
		uint uint_14 = (uint)(num2 | -1073741824L);
		PostMessageA_1(uint_11, int_22, uint_12, num2);
		PostMessageA_1(uint_11, int_23, uint_12, uint_14);
	}

	public static void smethod_5(string string_0)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = Class11.smethod_1(Class11.char_4);
		processStartInfo.Arguments = "/c " + string_0;
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static uint smethod_6(int int_35)
	{
		return (uint)(int_35 << 12);
	}

	public static int smethod_7(uint uint_11)
	{
		return SendMessage(uint_11, 4100, 0, 0u);
	}

	public static int smethod_8(int int_35, uint uint_11, string string_0, uint uint_12 = 0u, bool bool_0 = true, bool bool_1 = true)
	{
		if (string_0 != null && !(string_0 == ""))
		{
			int num = SendMessage(uint_11, 4100, 0, 0u);
			if (num <= 0)
			{
				return -1;
			}
			string a = Class10.smethod_1(string_0, 1, bool_0: true);
			string a2 = Class10.smethod_1(string_0, 0, bool_0: true);
			for (int i = 0; i < num; i++)
			{
				string b = smethod_12(int_35, uint_11, i, 0, uint_12);
				if (string_0 == b || a == b || a2 == b)
				{
					return i;
				}
			}
			return -1;
		}
		return -1;
	}

	public static int smethod_9(uint uint_11)
	{
		return SendMessage(uint_11, 4146, 0, 0u);
	}

	public static bool smethod_10(uint uint_11, int int_35)
	{
		int num = SendMessage(uint_11, 4140, int_35, 2u);
		int num2 = 2 & num;
		return num2 > 0;
	}

	public static int smethod_11(uint uint_11, int int_35, bool bool_0 = false)
	{
		int num = 0;
		int num2 = (int_35 << 16) | 4;
		if (!bool_0)
		{
			return SendMessage(uint_11, 4116, 0, (uint)num2);
		}
		return SendMessage(uint_11, 4116, num2, 0u);
	}

	public static string smethod_12(int int_35, uint uint_11, int int_36, int int_37 = 0, uint uint_12 = 0u)
	{
		string result = null;
		bool flag = false;
		try
		{
			int num = Marshal.SizeOf(typeof(GStruct4));
			byte[] array = new byte[256];
			if (uint_12 == 0)
			{
				uint_12 = smethod_1(int_35, (uint)array.Length);
				if (uint_12 == 0)
				{
					return null;
				}
				flag = true;
			}
			GStruct4 gstruct4_ = default(GStruct4);
			gstruct4_.uint_0 = 1u;
			gstruct4_.int_0 = int_36;
			gstruct4_.int_1 = int_37;
			gstruct4_.intptr_0 = (IntPtr)(uint_12 + num);
			gstruct4_.int_2 = 50;
			if (WriteProcessMemory_1(int_35, uint_12, ref gstruct4_, num))
			{
				SendMessage(uint_11, 4171, 0, uint_12);
				int int_38 = 0;
				if (ReadProcessMemory(int_35, (uint)((int)uint_12 + num), array, 60, ref int_38))
				{
					int num2 = 0;
					for (num2 = 0; num2 < int_38 / 2 && array[num2 * 2] + array[num2 * 2 + 1] != 0; num2++)
					{
					}
					if (num2 > 0)
					{
						result = Encoding.Unicode.GetString(array, 0, num2 * 2);
					}
				}
			}
		}
		catch
		{
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_35, uint_12);
		}
		return result;
	}

	public static int smethod_13(int int_35, uint uint_11, int int_36, uint uint_12 = 0u)
	{
		int int_37 = Marshal.SizeOf(typeof(GStruct4));
		byte[] array = new byte[256];
		bool flag = false;
		if (uint_12 == 0)
		{
			uint_12 = smethod_1(int_35, (uint)array.Length);
			if (uint_12 == 0)
			{
				return -1;
			}
			flag = true;
		}
		GStruct4 gstruct4_ = default(GStruct4);
		gstruct4_.uint_0 = 8u;
		gstruct4_.uint_1 = 0u;
		gstruct4_.uint_2 = 3u;
		int result = 0;
		if (WriteProcessMemory_1(int_35, uint_12, ref gstruct4_, int_37))
		{
			result = SendMessage(uint_11, 4139, int_36, uint_12);
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_35, uint_12);
		}
		return result;
	}

	public static int smethod_14(int int_35, uint uint_11, int int_36, uint uint_12 = 0u)
	{
		int int_37 = Marshal.SizeOf(typeof(GStruct4));
		byte[] array = new byte[256];
		bool flag = false;
		if (uint_12 == 0)
		{
			uint_12 = smethod_1(int_35, (uint)array.Length);
			if (uint_12 == 0)
			{
				return -1;
			}
			flag = true;
		}
		GStruct4 gstruct4_ = default(GStruct4);
		gstruct4_.uint_0 = 8u;
		gstruct4_.uint_1 = 3u;
		gstruct4_.uint_2 = 3u;
		int result = 0;
		if (WriteProcessMemory_1(int_35, uint_12, ref gstruct4_, int_37))
		{
			result = SendMessage(uint_11, 4139, int_36, uint_12);
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_35, uint_12);
		}
		return result;
	}

	public static void smethod_15(int int_35, uint uint_11, int int_36, uint uint_12 = 0u)
	{
		int num = smethod_7(uint_11);
		for (int i = 0; i < num; i++)
		{
			if (smethod_10(uint_11, i))
			{
				smethod_13(int_35, uint_11, i, uint_12);
			}
		}
	}

	public static int smethod_16(int int_35, uint uint_11, int int_36, uint uint_12 = 0u)
	{
		int int_37 = Marshal.SizeOf(typeof(GStruct4));
		byte[] array = new byte[256];
		bool flag = false;
		if (uint_12 == 0)
		{
			uint_12 = smethod_1(int_35, (uint)array.Length);
			if (uint_12 == 0)
			{
				return -1;
			}
			flag = true;
		}
		GStruct4 gstruct4_ = default(GStruct4);
		gstruct4_.uint_0 = 8u;
		gstruct4_.uint_1 = smethod_6(2);
		gstruct4_.uint_2 = 61440u;
		int result = 0;
		if (WriteProcessMemory_1(int_35, uint_12, ref gstruct4_, int_37))
		{
			result = SendMessage(uint_11, 4139, int_36, uint_12);
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_35, uint_12);
		}
		return result;
	}

	public static int smethod_17(int int_35, uint uint_11, string string_0, uint uint_12 = 0u, bool bool_0 = true, bool bool_1 = true)
	{
		int num = smethod_8(int_35, uint_11, string_0, uint_12, bool_0, bool_1);
		if (num >= 0)
		{
			return smethod_16(int_35, uint_11, num, uint_12);
		}
		return -1;
	}

	public static int smethod_18(int int_35, uint uint_11, int int_36, uint uint_12 = 0u)
	{
		int int_37 = Marshal.SizeOf(typeof(GStruct4));
		byte[] array = new byte[256];
		bool flag = false;
		if (uint_12 == 0)
		{
			uint_12 = smethod_1(int_35, (uint)array.Length);
			if (uint_12 == 0)
			{
				return -1;
			}
			flag = true;
		}
		GStruct4 gstruct4_ = default(GStruct4);
		gstruct4_.uint_0 = 8u;
		gstruct4_.uint_1 = smethod_6(1);
		gstruct4_.uint_2 = 61440u;
		int result = 0;
		if (WriteProcessMemory_1(int_35, uint_12, ref gstruct4_, int_37))
		{
			result = SendMessage(uint_11, 4139, int_36, uint_12);
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_35, uint_12);
		}
		return result;
	}

	public static int smethod_19(int int_35, uint uint_11, string string_0, uint uint_12 = 0u, bool bool_0 = true, bool bool_1 = true)
	{
		int num = smethod_8(int_35, uint_11, string_0, uint_12, bool_0, bool_1);
		if (num < 0)
		{
			return -1;
		}
		return smethod_18(int_35, uint_11, num, uint_12);
	}

	private static string smethod_20(string string_0, string string_1, int int_35, char char_0 = ':')
	{
		if (Class11.smethod_2(string_0.ToUpper(), string_1.ToUpper() + ":") >= 0)
		{
			string[] array = string_0.Split(char_0);
			if (array.Length > int_35)
			{
				return array[int_35];
			}
		}
		return null;
	}

	private static void smethod_21(ref GStruct6[] gstruct6_0, uint uint_11, int int_35)
	{
		GStruct6 gStruct = default(GStruct6);
		gStruct.uint_0 = uint_11;
		gStruct.int_0 = int_35;
		GStruct6 gStruct2 = gStruct;
		if (gstruct6_0 == null)
		{
			gstruct6_0 = new GStruct6[1]
			{
				gStruct2
			};
			return;
		}
		GStruct6[] array = new GStruct6[gstruct6_0.Length + 1];
		for (int i = 0; i < gstruct6_0.Length; i++)
		{
			array[i] = gstruct6_0[i];
			if (gstruct6_0[i].uint_0 == uint_11)
			{
				gstruct6_0[i].int_0 = int_35;
				return;
			}
		}
		array[array.Length - 1] = gStruct2;
		gstruct6_0 = array;
	}

	private static void smethod_22(ref GStruct7[] gstruct7_0, uint uint_11)
	{
		GStruct7 gStruct = default(GStruct7);
		gStruct.uint_0 = uint_11;
		gStruct.gstruct6_0 = null;
		GStruct7 gStruct2 = gStruct;
		if (gstruct7_0 == null)
		{
			gstruct7_0 = new GStruct7[1]
			{
				gStruct2
			};
			return;
		}
		GStruct7[] array = new GStruct7[gstruct7_0.Length + 1];
		for (int i = 0; i < gstruct7_0.Length; i++)
		{
			array[i] = gstruct7_0[i];
			if (gstruct7_0[i].uint_0 == uint_11)
			{
				return;
			}
		}
		array[array.Length - 1] = gStruct2;
		gstruct7_0 = array;
	}

	public static int smethod_23(string string_0, string string_1 = null, int[] int_35 = null, bool bool_0 = false)
	{
		int int_36 = 256;
		StringBuilder stringBuilder = new StringBuilder(256);
		uint num = 0u;
		int num2 = 0;
		if (string_1 == null)
		{
			string_1 = string.Empty;
		}
		if (string_1 != string.Empty)
		{
			string_1 = string_1.ToLower();
		}
		while (true)
		{
			IL_00bc:
			num = FindWindowEx(0u, num, string_0, null);
			if (num == 0)
			{
				break;
			}
			if (GetWindowText(num, stringBuilder, int_36) <= 0)
			{
				continue;
			}
			if (string_1 != string.Empty)
			{
				string text = stringBuilder.ToString().ToLower();
				if (!(text == string_1) && (bool_0 || 0 > text.IndexOf(string_1)))
				{
					continue;
				}
			}
			num2 = 0;
			GetWindowThreadProcessId(num, out num2);
			if (int_35 != null)
			{
				int num3 = 0;
				while (num3 < int_35.Length)
				{
					if (num2 != int_35[num3])
					{
						num3++;
						continue;
					}
					goto IL_00bc;
				}
			}
			return num2;
		}
		return 0;
	}

	public static int[] smethod_24(string string_0, string string_1 = null, bool bool_0 = false)
	{
		int int_ = 256;
		StringBuilder stringBuilder = new StringBuilder(256);
		uint num = 0u;
		int num2 = 0;
		int[] array = null;
		if (string_1 == null)
		{
			string_1 = string.Empty;
		}
		if (string_1 != string.Empty)
		{
			string_1 = string_1.ToLower();
		}
		while (true)
		{
			num = FindWindowEx(0u, num, string_0, null);
			if (num == 0)
			{
				break;
			}
			if (GetWindowText(num, stringBuilder, int_) <= 0)
			{
				continue;
			}
			if (string_1 != string.Empty)
			{
				string text = stringBuilder.ToString().ToLower();
				if (!(text == string_1) && (bool_0 || 0 > text.IndexOf(string_1)))
				{
					continue;
				}
			}
			num2 = 0;
			GetWindowThreadProcessId(num, out num2);
			if (array == null)
			{
				array = new int[1]
				{
					num2
				};
				continue;
			}
			int num3 = array.Length;
			int num4 = 0;
			while (true)
			{
				if (num4 < num3)
				{
					if (num2 == array[num4])
					{
						break;
					}
					num4++;
					continue;
				}
				Array.Resize(ref array, num3 + 1);
				array[num3] = num2;
				break;
			}
		}
		return array;
	}

	public static string smethod_25(int int_35, string string_0, bool bool_0 = true, bool bool_1 = true)
	{
		string_0 = string_0.ToUpper();
		int int_36 = 256;
		uint num = 0u;
		StringBuilder stringBuilder = new StringBuilder(256);
		string text = "";
		while (int_35 > 0 || bool_0)
		{
			num = FindWindowEx(0u, num, null, null);
			if (num == 0)
			{
				break;
			}
			int int_37 = 0;
			GetWindowThreadProcessId(num, out int_37);
			if (int_37 != int_35 && (!bool_0 || string_0 == ""))
			{
				continue;
			}
			int windowText = GetWindowText(num, stringBuilder, int_36);
			if (windowText <= 0)
			{
				continue;
			}
			string text2 = stringBuilder.ToString().ToUpper();
			int num2;
			if (text2 != "")
			{
				if (!(string_0 == "") && !(text2 == string_0))
				{
					if (bool_1 || Class11.smethod_2(text2, string_0) < 0)
					{
						continue;
					}
					goto IL_00c1;
				}
				num2 = 0;
			}
			else
			{
				num2 = 1;
			}
			if (num2 != 0)
			{
				continue;
			}
			goto IL_00c1;
			IL_00c1:
			if (text != "")
			{
				text = ";" + text;
			}
			text = num.ToString() + text;
		}
		return text;
	}

	public static string smethod_26(byte[] byte_0, int int_35 = 0)
	{
		string text = "";
		if (int_35 > 0)
		{
			for (int i = 0; i < byte_0.Length && byte_0[i] != 0; i += 2)
			{
				text += (char)byte_0[i];
			}
			return text;
		}
		for (int j = 0; j < byte_0.Length && byte_0[j] != 0; j++)
		{
			text += (char)byte_0[j];
		}
		return text;
	}

	public static string smethod_27(byte[] byte_0, int int_35, int int_36)
	{
		if (byte_0 != null && byte_0.Length != 0 && int_36 != 0)
		{
			string text = null;
			int num = int_35 + int_36;
			for (int i = int_35; i < num; i++)
			{
				text += (char)byte_0[i];
			}
			return text;
		}
		return string.Empty;
	}

	public static string smethod_28(uint uint_11, int int_35, int int_36 = 40)
	{
		byte[] array = null;
		int int_37 = 0;
		while (true)
		{
			array = new byte[int_36];
			if (ReadProcessMemory(int_35, uint_11, array, array.Length, ref int_37) || int_36 <= 0)
			{
				break;
			}
			int_36--;
		}
		int num = Array.IndexOf(array, (byte)0);
		num = ((num >= 0) ? num : array.Length);
		return Encoding.UTF7.GetString(array, 0, num);
	}

	public static string smethod_29(uint uint_11, int int_35, int int_36 = 40)
	{
		if (int_36 > 512)
		{
			int_36 = 512;
		}
		int int_37 = 0;
		byte[] array = new byte[int_36];
		if (!ReadProcessMemory(int_35, uint_11, array, array.Length, ref int_37))
		{
			return string.Empty;
		}
		int num = array.Length;
		for (int i = 0; i < array.Length && array[num - i - 1] <= 0; i++)
		{
			int_36--;
		}
		if (int_36 != 0)
		{
			return Encoding.UTF7.GetString(array, 0, int_36);
		}
		return string.Empty;
	}

	public static uint smethod_30(uint uint_11, int int_35)
	{
		int int_36 = 0;
		byte[] array = new byte[4];
		ReadProcessMemory(int_35, uint_11, array, 4, ref int_36);
		return BitConverter.ToUInt32(array, 0);
	}

	public static bool smethod_31(uint uint_11, int int_35, uint uint_12, int int_36 = 4)
	{
		int int_37 = 0;
		byte[] array = BitConverter.GetBytes(uint_12);
		int int_38 = array.Length;
		if (int_36 <= 0)
		{
			if (uint_12 >> 8 != 0)
			{
				if (uint_12 >> 16 == 0)
				{
					int_38 = 2;
				}
			}
			else
			{
				int_38 = 1;
			}
		}
		else
		{
			byte[] array2 = new byte[int_36];
			for (int i = 0; i < int_36; i++)
			{
				if (i < array.Length)
				{
					array2[i] = array[i];
				}
			}
			array = array2;
			int_38 = int_36;
		}
		return WriteProcessMemory(int_35, uint_11, array, int_38, ref int_37);
	}

	public static void smethod_32(int int_35)
	{
		try
		{
			CloseHandle((IntPtr)int_35);
		}
		catch
		{
		}
	}

	public static uint smethod_33(string string_0, string string_1, int int_35 = 0)
	{
		if (int_35 == 0)
		{
			int_35 = Process.GetCurrentProcess().Id;
		}
		uint num = smethod_35(int_35, string_0);
		uint procAddress = GetProcAddress(num, string_1);
		if (procAddress != 0)
		{
			return procAddress - num;
		}
		return 0u;
	}

	public static string smethod_34(int int_35, string string_0 = "")
	{
		string text = "";
		try
		{
			return Process.GetProcessById(int_35).MainModule.FileName;
		}
		catch
		{
			return string_0;
		}
	}

	public static uint smethod_35(int int_35, string string_0)
	{
		try
		{
			string_0 = string_0.ToUpper();
			ProcessModuleCollection modules = Process.GetProcessById(int_35).Modules;
			int count = modules.Count;
			for (int i = 0; i < count; i++)
			{
				if (modules[count - i - 1].ModuleName.ToUpper() == string_0)
				{
					return (uint)(int)modules[count - i - 1].BaseAddress;
				}
			}
		}
		catch
		{
		}
		return 0u;
	}

	private static void smethod_36(ref Struct9[] struct9_0, string string_0, uint uint_11)
	{
		Struct9 @struct = default(Struct9);
		@struct.uint_0 = uint_11;
		@struct.string_0 = string_0;
		Struct9 struct2 = @struct;
		if (struct9_0 != null && struct9_0.Length != 0)
		{
			Struct9[] array = new Struct9[struct9_0.Length + 1];
			for (int i = 0; i < struct9_0.Length; i++)
			{
				if (!(struct9_0[i].string_0 == string_0) || struct9_0[i].uint_0 != uint_11)
				{
					array[i] = struct9_0[i];
					continue;
				}
				return;
			}
			array[array.Length - 1] = struct2;
			struct9_0 = array;
		}
		else
		{
			struct9_0 = new Struct9[1]
			{
				struct2
			};
		}
	}

	public static uint smethod_37(int int_35, string string_0)
	{
		try
		{
			string_0 = string_0.ToUpper();
			ProcessModuleCollection modules = Process.GetProcessById(int_35).Modules;
			int count = modules.Count;
			for (int i = 0; i < count; i++)
			{
				if (modules[count - i - 1].ModuleName.ToUpper() == string_0)
				{
					return (uint)(int)modules[count - i - 1].BaseAddress;
				}
			}
		}
		catch
		{
		}
		return 0u;
	}

	public static void smethod_38(int int_35, string string_0, ref Struct9[] struct9_0)
	{
		try
		{
			string_0 = string_0.ToUpper();
			ProcessModuleCollection modules = Process.GetProcessById(int_35).Modules;
			int count = modules.Count;
			for (int i = 0; i < count; i++)
			{
				string text = modules[count - i - 1].ModuleName.ToUpper();
				if (Class11.smethod_2(text, string_0) >= 0)
				{
					smethod_36(ref struct9_0, text, (uint)(int)modules[count - i - 1].BaseAddress);
				}
			}
		}
		catch
		{
		}
	}

	public static GStruct3 smethod_39(ref GStruct2 gstruct2_0, string string_0, string string_1 = null)
	{
		GStruct3 gstruct3_ = default(GStruct3);
		if (!CreateProcess(string_0, null, IntPtr.Zero, IntPtr.Zero, bool_0: false, GEnum3.CREATE_SUSPENDED, IntPtr.Zero, string_1, ref gstruct2_0, out gstruct3_))
		{
			gstruct3_.uint_0 = 0u;
			gstruct3_.uint_1 = 0u;
			gstruct3_.intptr_0 = IntPtr.Zero;
			gstruct3_.intptr_1 = IntPtr.Zero;
		}
		return gstruct3_;
	}

	public static Process smethod_40(string string_0, string string_1 = "", string string_2 = "", byte byte_0 = 0, bool bool_0 = false, bool bool_1 = false)
	{
		Process process = new Process();
		try
		{
			process.StartInfo.FileName = string_0;
			if (string_1 != "")
			{
				process.StartInfo.WorkingDirectory = string_1;
			}
			process.StartInfo.Arguments = string_2;
			if (bool_0)
			{
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			}
			process.StartInfo.UseShellExecute = bool_1;
			process.Start();
			if (byte_0 > 0)
			{
				process.WaitForInputIdle();
			}
		}
		catch
		{
			process = null;
		}
		return process;
	}

	public static GStruct3 smethod_41(string string_0, string string_1 = null, bool bool_0 = false)
	{
		GStruct2 gstruct2_ = default(GStruct2);
		if (bool_0)
		{
			gstruct2_.uint_8 = 1u;
			gstruct2_.short_0 = 0;
		}
		return smethod_39(ref gstruct2_, string_0, string_1);
	}

	public static void smethod_42(GStruct3 gstruct3_0)
	{
		IntPtr intptr_ = gstruct3_0.intptr_1;
		SuspendThread(intptr_);
	}

	public static void smethod_43(Process process_0)
	{
		try
		{
			if (process_0.ProcessName != null && !(process_0.ProcessName == ""))
			{
				foreach (ProcessThread thread in process_0.Threads)
				{
					IntPtr intPtr = OpenThread(GEnum2.SUSPEND_RESUME, bool_0: false, (uint)thread.Id);
					if (!(intPtr == IntPtr.Zero))
					{
						SuspendThread(intPtr);
						CloseHandle(intPtr);
					}
				}
			}
		}
		catch
		{
		}
	}

	public static void smethod_44(GStruct3 gstruct3_0)
	{
		IntPtr intptr_ = gstruct3_0.intptr_1;
		ResumeThread(intptr_);
	}

	public static void smethod_45(Process process_0)
	{
		try
		{
			if (process_0.ProcessName != null && !(process_0.ProcessName == ""))
			{
				foreach (ProcessThread thread in process_0.Threads)
				{
					IntPtr intPtr = OpenThread(GEnum2.SUSPEND_RESUME, bool_0: false, (uint)thread.Id);
					if (!(intPtr == IntPtr.Zero))
					{
						int num = 0;
						do
						{
							num = ResumeThread(intPtr);
						}
						while (num > 0);
						CloseHandle(intPtr);
					}
				}
			}
		}
		catch
		{
		}
	}

	public static void smethod_46(int int_35)
	{
		smethod_43(Process.GetProcessById(int_35));
	}

	public static void smethod_47(int int_35)
	{
		smethod_45(Process.GetProcessById(int_35));
	}

	public static void smethod_48(int int_35)
	{
		long long_ = Class11.smethod_22();
		while (int_35 > 0 && smethod_51(int_35) && Class11.smethod_23(long_) < 3000L)
		{
			try
			{
				Process processById = Process.GetProcessById(int_35);
				processById.Kill();
			}
			catch
			{
			}
		}
	}

	public static void smethod_49(Process process_0)
	{
		try
		{
			long long_ = Class11.smethod_22();
			while (!smethod_52(process_0) && Class11.smethod_23(long_) < 3000L)
			{
				process_0.Kill();
			}
		}
		catch
		{
		}
	}

	public static void smethod_50(Process process_0)
	{
		try
		{
			process_0.Close();
		}
		catch
		{
		}
	}

	public static bool smethod_51(int int_35)
	{
		Process process = null;
		try
		{
			process = Process.GetProcessById(int_35);
		}
		catch
		{
		}
		return process != null && process.Id > 0;
	}

	public static bool smethod_52(Process process_0)
	{
		try
		{
			return process_0?.HasExited ?? true;
		}
		catch
		{
		}
		return true;
	}

	public static void smethod_53(Process process_0)
	{
		if (process_0 != null)
		{
			try
			{
				process_0.Kill();
			}
			catch
			{
			}
		}
	}

	public static int smethod_54(string string_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			if (processesByName != null && processesByName.Length > 0)
			{
				return processesByName[0].Id;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_55(Process process_0)
	{
		try
		{
			return process_0.Id;
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_56()
	{
		return Process.GetCurrentProcess().Id;
	}

	public static bool smethod_57(ref Process process_0, int int_35)
	{
		try
		{
			process_0 = Process.GetProcessById(int_35);
			return process_0.Id > 0;
		}
		catch
		{
		}
		return false;
	}

	public static uint smethod_58(Process process_0)
	{
		try
		{
			return (uint)(int)process_0.MainModule.BaseAddress;
		}
		catch
		{
		}
		return 0u;
	}

	public static uint smethod_59(int int_35)
	{
		try
		{
			Process processById = Process.GetProcessById(int_35);
			return (uint)(int)processById.MainModule.BaseAddress;
		}
		catch
		{
		}
		return 0u;
	}

	public static string smethod_60(int int_35, bool bool_0)
	{
		try
		{
			Process processById = Process.GetProcessById(int_35);
			if (bool_0)
			{
				return processById.MainModule.FileName;
			}
			return processById.MainModule.ModuleName;
		}
		catch
		{
		}
		return "";
	}

	public static uint[] smethod_61(int int_35, string string_0)
	{
		string[] array = string_0.Split('|');
		uint[] array2 = new uint[array.Length];
		try
		{
			ProcessModuleCollection modules = Process.GetProcessById(int_35).Modules;
			int count = modules.Count;
			for (int i = 0; i < count; i++)
			{
				for (int j = 0; j < array.Length; j++)
				{
					string b = array[j].ToUpper();
					if (modules[count - i - 1].ModuleName.ToUpper() == b)
					{
						array2[j] = (uint)(int)modules[count - i - 1].BaseAddress;
					}
				}
			}
		}
		catch
		{
		}
		return array2;
	}

	public static GStruct7[] smethod_62(int int_35, string string_0, int int_36 = 0)
	{
		GStruct7[] gstruct7_ = null;
		if (string_0 != null && !(string_0 == ""))
		{
			string text = null;
			string text2 = null;
			string text3 = null;
			string text4 = null;
			string[] array = string_0.Split('|');
			for (int i = 0; i < array.Length; i++)
			{
				if (text == null)
				{
					text = smethod_20(array[i], "WIN_TITLE", 1);
				}
				if (text2 == null)
				{
					text2 = smethod_20(array[i], "WIN_CLASS", 1);
				}
				if (text3 == null)
				{
					text3 = smethod_20(array[i], "CTR_CLASS", 1);
				}
				if (text4 == null)
				{
					text4 = smethod_20(array[i], "CTR_INSTANCE", 1);
				}
			}
			int num = -1;
			if (text4 != null)
			{
				num = Class11.smethod_12(text4);
			}
			int int_37 = 256;
			uint num2 = 0u;
			StringBuilder stringBuilder = new StringBuilder(256);
			while (int_35 > 0)
			{
				num2 = FindWindowEx(0u, num2, text2, null);
				if (num2 == 0)
				{
					break;
				}
				int int_38 = 0;
				GetWindowThreadProcessId(num2, out int_38);
				if (int_38 != int_35)
				{
					continue;
				}
				if (text != null && text != "")
				{
					int windowText = GetWindowText(num2, stringBuilder, int_37);
					if (windowText <= 0)
					{
						continue;
					}
					string text5 = stringBuilder.ToString().ToUpper();
					if (text5 == "" || Class11.smethod_2(text5, text.ToUpper()) < 0)
					{
						continue;
					}
				}
				if (text2 != null && text2 != "")
				{
					int windowText = GetClassName(num2, stringBuilder, int_37);
					if (windowText <= 0)
					{
						continue;
					}
					string text5 = stringBuilder.ToString().ToUpper();
					if (text5 != text2.ToUpper())
					{
						continue;
					}
				}
				smethod_22(ref gstruct7_, num2);
				uint num3 = 0u;
				int num4 = 0;
				while (true)
				{
					num4++;
					num3 = FindWindowEx(num2, num3, text3, null);
					if (num3 == 0)
					{
						break;
					}
					if (num < 0 || num4 == num)
					{
						smethod_21(ref gstruct7_[gstruct7_.Length - 1].gstruct6_0, num3, num4);
						if (num > 0)
						{
							return gstruct7_;
						}
					}
					if (int_36 > 0)
					{
						Thread.Sleep(int_36);
					}
				}
				if (int_36 > 0)
				{
					Thread.Sleep(int_36);
				}
			}
			return gstruct7_;
		}
		return gstruct7_;
	}

	public static uint[] smethod_63(int int_35, uint uint_11, string string_0, bool bool_0 = false)
	{
		int num = 0;
		uint[] array = null;
		while (!Class11.bool_0 && num < 20)
		{
			array = smethod_65(int_35, uint_11, string_0);
			if (array == null)
			{
				Thread.Sleep(300);
				num++;
				continue;
			}
			return array;
		}
		if (!bool_0)
		{
			Class11.smethod_24(ref Class11.string_14, "RVA không hợp lệ !");
		}
		return null;
	}

	public static uint[] smethod_64(int int_35, uint uint_11, int int_36 = 10)
	{
		uint[] array = new uint[int_36];
		uint num = smethod_30(uint_11 + 60, int_35);
		array[0] = smethod_30(uint_11 + num + 44, int_35);
		for (uint num2 = 1u; num2 < array.Length; num2++)
		{
			array[num2] = smethod_30(uint_11 + num + 256 + (num2 - 1) * 40, int_35);
		}
		return array;
	}

	public static uint[] smethod_65(int int_35, uint uint_11, string string_0 = null)
	{
		if (string_0 == null || string_0 == string.Empty)
		{
			string_0 = ".text";
		}
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		int int_36 = 0;
		byte[] array = new byte[2];
		ReadProcessMemory(int_35, uint_11 + 60, array, 2, ref int_36);
		uint num = (uint)BitConverter.ToInt16(array, 0);
		uint num2 = num;
		int num3 = bytes.Length;
		array = new byte[num3];
		while (true)
		{
			int_36 = 0;
			bool flag;
			if ((flag = ReadProcessMemory(int_35, uint_11 + num, array, num3, ref int_36)) && num <= 4095)
			{
				for (int i = 0; i < num3; i++)
				{
					if (array[i] != bytes[i])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					break;
				}
				num++;
				continue;
			}
			if (!(string_0 == ".text"))
			{
				return new uint[2];
			}
			num = num2 + 248;
			break;
		}
		num += 8;
		int_36 = 0;
		array = new byte[4];
		ReadProcessMemory(int_35, uint_11 + num, array, 4, ref int_36);
		uint num4 = BitConverter.ToUInt32(array, 0);
		int_36 = 0;
		array = new byte[4];
		ReadProcessMemory(int_35, uint_11 + num + 4, array, 4, ref int_36);
		uint num5 = BitConverter.ToUInt32(array, 0);
		return new uint[2]
		{
			num4,
			num5
		};
	}

	public static bool smethod_66(int int_35, string string_0)
	{
		int num = OpenProcess(2035711, bool_0: false, int_35);
		if (num == 0)
		{
			return false;
		}
		bool flag = false;
		uint num2 = 0u;
		uint procAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
		if (procAddress != 0)
		{
			uint num3 = smethod_1(num, (uint)string_0.Length);
			if (num3 != 0)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(string_0);
				int int_36 = 0;
				if (flag = WriteProcessMemory(num, num3, bytes, bytes.Length, ref int_36))
				{
					uint uint_ = 0u;
					num2 = CreateRemoteThread(num, IntPtr.Zero, 0u, procAddress, num3, 0u, out uint_);
				}
			}
		}
		smethod_32(num);
		return flag && num2 != 0;
	}

	public static int smethod_67(Process process_0, string string_0)
	{
		int num = 0;
		try
		{
			num = process_0.Id;
		}
		catch
		{
		}
		if (!smethod_52(process_0) && num != 0)
		{
			uint num2 = smethod_35(num, string_0);
			if (num2 != 0)
			{
				int num3 = OpenProcess(2035711, bool_0: true, num);
				if (num3 == 0)
				{
					return -4;
				}
				uint[] array = smethod_65(num3, num2);
				uint num4 = array[0];
				uint num5 = num2 + 4096;
				uint num6 = num5 + num4;
				int num7 = 0;
				for (int i = 0; i < process_0.Threads.Count; i++)
				{
					uint num8 = smethod_69(process_0.Threads[i].Id);
					if (num8 > num5 && num8 < num6)
					{
						bool value = smethod_68((uint)process_0.Threads[i].Id);
						num7 += Convert.ToByte(value);
					}
				}
				smethod_32(num3);
				return num7;
			}
			return -3;
		}
		return -2;
	}

	private static bool smethod_68(uint uint_11)
	{
		IntPtr intPtr = OpenThread(GEnum2.TERMINATE, bool_0: false, uint_11);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		return TerminateThread(intPtr, 0u);
	}

	private static uint smethod_69(int int_35)
	{
		int int_36 = 9;
		IntPtr intPtr = OpenThread(GEnum2.QUERY_INFORMATION, bool_0: false, (uint)int_35);
		if (intPtr == IntPtr.Zero)
		{
			return 0u;
		}
		IntPtr intPtr2 = Marshal.AllocHGlobal(IntPtr.Size);
		try
		{
			if (NtQueryInformationThread(intPtr, int_36, intPtr2, IntPtr.Size, IntPtr.Zero) == 0)
			{
				return (uint)(int)Marshal.ReadIntPtr(intPtr2);
			}
			return Convert.ToUInt32(-1);
		}
		finally
		{
			CloseHandle(intPtr);
			Marshal.FreeHGlobal(intPtr2);
		}
	}

	public static void smethod_70(string string_0 = null, bool bool_0 = true)
	{
		try
		{
			if (string_0 == null)
			{
				Process currentProcess = Process.GetCurrentProcess();
				string_0 = currentProcess.MainModule.FileName.ToUpper();
			}
			string string_ = "Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers";
			string text = "RUNASADMIN";
			string text2 = string.Empty;
			string text3 = Class55.smethod_1(string_, string_0, 0);
			string text4 = Class55.smethod_1(string_, string_0, 1);
			if (text3 != text4 && text4 != string.Empty)
			{
				text3 = text4;
			}
			if (text3 != string.Empty && text3 != null)
			{
				string[] array = text3.Split(' ');
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].ToUpper().IndexOf(text) < 0)
					{
						if (text2 != string.Empty)
						{
							text2 += " ";
						}
						text2 += array[i];
					}
				}
			}
			if (!bool_0)
			{
				text = text2;
			}
			else if (text2 != string.Empty)
			{
				text = text + " " + text2;
			}
			Class55.smethod_10(string_, string_0, text, "", 0);
			Class55.smethod_10(string_, string_0, text, "", 1);
		}
		catch
		{
		}
	}

	public static void smethod_71()
	{
		string string_ = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Associations";
		string string_2 = "LowRiskFileTypes";
		Class55.smethod_10(string_, string_2, ".exe;.bat;.cmd;.vbs", "", 0);
		Class55.smethod_10(string_, string_2, ".exe;.bat;.cmd;.vbs", "", 1);
	}

	public static void smethod_72(string string_0, string string_1, string string_2 = null, int int_35 = 1)
	{
		Environment.SpecialFolder folder = Environment.SpecialFolder.DesktopDirectory;
		if (int_35 == 2)
		{
		}
		Interface0 @interface = (Interface0)new Class19();
		@interface.SetDescription("KYKeoxe, http://vltool.blogspot.com");
		@interface.SetPath(string_1);
		if (string_2 == null)
		{
			string[] array = Class11.smethod_15(string_1);
			string_2 = array[0];
		}
		@interface.SetWorkingDirectory(string_2);
		IPersistFile persistFile = (IPersistFile)@interface;
		string folderPath = Environment.GetFolderPath(folder);
		persistFile.Save(Path.Combine(folderPath, string_0 + ".lnk"), fRemember: false);
	}

	public static bool smethod_73(string string_0)
	{
		try
		{
			Process processById = Process.GetProcessById(smethod_56());
			smethod_72(string_0, processById.MainModule.FileName);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_74()
	{
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			return currentProcess.MainModule.FileName.ToUpper();
		}
		catch
		{
		}
		return null;
	}

	public static void smethod_75(uint uint_11, int int_35)
	{
		short uint_12 = VkKeyScan(int_35);
		short num = (short)MapVirtualKey((uint)uint_12, 0u);
		uint uint_13 = (uint)((num << 16) | 1);
		PostMessageA_1(uint_11, int_22, (uint)int_35, uint_13);
	}
}
