using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class GClass0
{
	private delegate IntPtr Delegate0(int nCode, IntPtr wParam, IntPtr lParam);

	private const int int_0 = 13;

	public static int int_1 = 0;

	public static int int_2 = 0;

	public static int int_3 = 121;

	public static IntPtr intptr_0 = IntPtr.Zero;

	private static int int_4 = 0;

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	private static bool bool_2 = false;

	private static Delegate0 delegate0_0 = smethod_3;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_5, Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_5, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);

	public static void smethod_0()
	{
		intptr_0 = smethod_2(delegate0_0);
	}

	public static void smethod_1()
	{
		UnhookWindowsHookEx(intptr_0);
		bool_0 = false;
		bool_1 = false;
		int_4 = 0;
	}

	private static IntPtr smethod_2(Delegate0 delegate0_1)
	{
		using (Process process = Process.GetCurrentProcess())
		{
			using (ProcessModule processModule = process.MainModule)
			{
				return SetWindowsHookEx(13, delegate0_1, GetModuleHandle(processModule.ModuleName), 0u);
			}
		}
	}

	private static IntPtr smethod_3(int int_5, IntPtr intptr_1, IntPtr intptr_2)
	{
		try
		{
			return smethod_4(int_5, intptr_1, intptr_2);
		}
		catch
		{
		}
		return IntPtr.Zero;
	}

	private static IntPtr smethod_4(int int_5, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (int_5 < 0)
		{
			int_4 = 0;
		}
		else
		{
			int_4 = Marshal.ReadInt32(intptr_2);
			if (Class20.int_22 == (int)intptr_1)
			{
				int_1 = int_4;
				if (int_4 == 32)
				{
					Class38.gstruct29_0.int_8 = 1;
					bool_1 = true;
				}
				else if (48 < int_4 && int_4 < 58)
				{
					Class11.smethod_32(ref Class29.int_4, int_4);
				}
				if (int_4 != Class24.int_6 && int_4 != Class24.int_7)
				{
					if (int_4 == Class24.int_8 || int_4 == Class24.int_9)
					{
						Class38.gstruct29_0.int_9 = 2;
						Class66.int_2 = 2;
					}
				}
				else
				{
					Class38.gstruct29_0.int_9 = 1;
					Class66.int_2 = 1;
				}
				if (int_4 != 162 && int_4 != 163)
				{
					if (int_4 == 164 || int_4 == 165)
					{
						bool_2 = true;
					}
				}
				else
				{
					bool_0 = true;
				}
			}
			else if (Class20.int_23 == (int)intptr_1)
			{
				if (int_4 == 32)
				{
					Class38.gstruct29_0.int_8 = 0;
				}
				if (int_4 != 162 && int_4 != 163)
				{
					if (int_4 == 164 || int_4 == 165)
					{
						bool_2 = false;
					}
				}
				else
				{
					bool_0 = false;
				}
				if (int_4 <= 48 || 58 <= int_4)
				{
					bool_1 = false;
				}
				int_4 = 0;
			}
			if (Class66.gstruct42_0.int_129 > 0)
			{
				if (bool_0)
				{
					if (int_4 == Class24.int_10)
					{
						Class66.int_1 = 1;
					}
					else if (int_4 == Class24.int_11)
					{
						Class66.int_1 = 2;
					}
					else if (int_4 != Class24.int_12)
					{
						if (int_4 == Class24.int_13)
						{
							Class66.int_1 = 4;
						}
						else if (int_4 != Class24.int_14)
						{
							if (int_4 == Class24.int_15)
							{
								Class66.int_1 = 6;
							}
							else if (int_4 != Class24.int_16)
							{
								if (int_4 == Class24.int_0)
								{
									Class66.int_1 = 7;
								}
								else if (bool_2)
								{
									FormMain.int_128 = 1;
								}
							}
							else
							{
								Class39.int_3[0] = Class66.gstruct42_0.int_129;
							}
						}
						else
						{
							Class66.int_1 = 5;
						}
					}
					else
					{
						Class66.int_1 = 3;
					}
					if (bool_1)
					{
						FormTest.int_4 = 32;
					}
				}
				if (bool_1)
				{
					Class39.long_0[0] = 0L;
					Class39.int_3[1] = Class66.gstruct42_0.int_129;
					if (!FormPhongKy1.bool_1)
					{
						if (FormPhongKy1.bool_2)
						{
							FormPhongKy1.bool_4 = true;
						}
					}
					else
					{
						FormPhongKy1.bool_3 = true;
					}
				}
			}
		}
		int_2 = Class66.int_3;
		Class38.gstruct29_0.int_7 = int_4;
		return CallNextHookEx(intptr_0, int_5, intptr_1, intptr_2);
	}
}
