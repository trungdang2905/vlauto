using Microsoft.Win32;
using System;

internal class Class55
{
	private static RegistryKey registryKey_0 = null;

	private static RegistryKey registryKey_1 = null;

	public static string smethod_0()
	{
		try
		{
			string name = "HTTP\\shell\\open\\command";
			using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(name, writable: false))
			{
				return ((string)registryKey.GetValue(null, null)).Split('"')[1];
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	public static string smethod_1(string string_0, string string_1, byte byte_0 = 0, string string_2 = "")
	{
		string text = string.Empty;
		try
		{
			RegistryKey registryKey = (byte_0 == 0) ? Registry.LocalMachine.OpenSubKey(string_0) : Registry.CurrentUser.OpenSubKey(string_0);
			string_1 = string_1.ToUpper();
			string[] valueNames = registryKey.GetValueNames();
			string[] array = valueNames;
			foreach (string text2 in array)
			{
				if (text2.ToUpper() == string_1)
				{
					text = registryKey.GetValue(text2).ToString();
					break;
				}
			}
			if (text == string.Empty)
			{
				text = string_2;
			}
			registryKey.Close();
		}
		catch
		{
			text = string_2;
			smethod_11(string_0, byte_0);
		}
		return text;
	}

	public static string smethod_2(string string_0, byte byte_0 = 0, string string_1 = "")
	{
		string text = string.Empty;
		try
		{
			RegistryKey registryKey;
			if (byte_0 == 0)
			{
				if (registryKey_0 == null)
				{
					registryKey_0 = Registry.LocalMachine.OpenSubKey(Class47.string_0);
				}
				registryKey = registryKey_0;
			}
			else
			{
				if (registryKey_1 == null)
				{
					registryKey_1 = Registry.CurrentUser.OpenSubKey(Class47.string_0);
				}
				registryKey = registryKey_1;
			}
			string_0 = string_0.ToUpper();
			string[] valueNames = registryKey.GetValueNames();
			string[] array = valueNames;
			foreach (string text2 in array)
			{
				if (text2.ToUpper() == string_0)
				{
					text = registryKey.GetValue(text2).ToString();
					break;
				}
			}
			if (text == string.Empty)
			{
				text = string_1;
			}
		}
		catch
		{
			text = string_1;
			smethod_11(Class47.string_0, byte_0);
			registryKey_0 = null;
			registryKey_1 = null;
		}
		return text;
	}

	public static int smethod_3(string string_0, byte byte_0 = 0, string string_1 = "")
	{
		int result = 0;
		string text = smethod_2(string_0, byte_0, string_1);
		if (text != null && text != string.Empty)
		{
			try
			{
				result = Convert.ToInt32(text);
			}
			catch
			{
				result = 0;
			}
		}
		return result;
	}

	public static uint smethod_4(string string_0, byte byte_0 = 0, string string_1 = "")
	{
		uint result = 0u;
		string text = smethod_2(string_0, byte_0, string_1);
		if (text != null && text != string.Empty)
		{
			try
			{
				result = Convert.ToUInt32(text);
			}
			catch
			{
				result = 0u;
			}
		}
		return result;
	}

	public static long smethod_5(string string_0, byte byte_0 = 0, string string_1 = "")
	{
		long result = 0L;
		string text = smethod_2(string_0, byte_0, string_1);
		if (text != null && text != string.Empty)
		{
			try
			{
				result = Convert.ToInt64(text);
			}
			catch
			{
				result = 0L;
			}
		}
		return result;
	}

	public static string smethod_6(string string_0, byte byte_0 = 0, string string_1 = "")
	{
		return smethod_2(string_0, byte_0, string_1);
	}

	public static string smethod_7(string string_0, string string_1, byte byte_0 = 0, string string_2 = "")
	{
		string text = "";
		try
		{
			string_1 = string_1.ToUpper();
			RegistryKey registryKey = (byte_0 != 0) ? Registry.CurrentUser.OpenSubKey(string_0) : Registry.LocalMachine.OpenSubKey(string_0);
			string[] valueNames = registryKey.GetValueNames();
			string[] array = valueNames;
			foreach (string text2 in array)
			{
				if (text2.ToUpper() == string_1)
				{
					object value = registryKey.GetValue(text2);
					if (Class11.smethod_2(value.ToString().ToUpper(), "STRING[]") > 0)
					{
						string[] array2 = (string[])value;
						text = array2[0];
					}
					else
					{
						text = value.ToString();
					}
					break;
				}
			}
			if (text == "")
			{
				text = string_2;
			}
			registryKey.Close();
		}
		catch
		{
			text = string_2;
			smethod_11(string_0, byte_0);
		}
		return text;
	}

	public static string[] smethod_8(string string_0, bool bool_0 = false)
	{
		try
		{
			RegistryKey registryKey = bool_0 ? Registry.CurrentUser.OpenSubKey(string_0, writable: true) : Registry.LocalMachine.OpenSubKey(string_0, writable: true);
			string[] subKeyNames = registryKey.GetSubKeyNames();
			registryKey.Close();
			return subKeyNames;
		}
		catch
		{
		}
		return null;
	}

	public static string[] smethod_9(string string_0, bool bool_0 = false)
	{
		try
		{
			RegistryKey registryKey = (!bool_0) ? Registry.LocalMachine.OpenSubKey(string_0, writable: true) : Registry.CurrentUser.OpenSubKey(string_0, writable: true);
			string[] valueNames = registryKey.GetValueNames();
			registryKey.Close();
			return valueNames;
		}
		catch
		{
		}
		return null;
	}

	public static bool smethod_10(string string_0, string string_1, object object_0, string string_2 = "", byte byte_0 = 0)
	{
		try
		{
			RegistryKey registryKey = (byte_0 != 0) ? Registry.CurrentUser.CreateSubKey(string_0) : Registry.LocalMachine.CreateSubKey(string_0);
			registryKey.SetValue(string_1, object_0, smethod_13(string_2));
			registryKey.Close();
			return true;
		}
		catch
		{
		}
		return false;
	}

	private static void smethod_11(string string_0, byte byte_0 = 0)
	{
		try
		{
			if (byte_0 == 0)
			{
				Registry.LocalMachine.CreateSubKey(string_0);
			}
			else
			{
				Registry.CurrentUser.CreateSubKey(string_0);
			}
		}
		catch
		{
		}
	}

	public static void smethod_12(string string_0, string string_1, byte byte_0 = 0)
	{
		try
		{
			RegistryKey registryKey = (byte_0 != 0) ? Registry.CurrentUser.OpenSubKey(string_0, writable: true) : Registry.LocalMachine.OpenSubKey(string_0, writable: true);
			registryKey.DeleteValue(string_1);
			registryKey.Close();
		}
		catch
		{
		}
	}

	private static RegistryValueKind smethod_13(string string_0 = "")
	{
		RegistryValueKind result = RegistryValueKind.String;
		string_0 = string_0.ToUpper();
		if (string_0 == "DWORD")
		{
			result = RegistryValueKind.DWord;
		}
		else if (string_0 == "BINARY")
		{
			result = RegistryValueKind.Binary;
		}
		return result;
	}
}
