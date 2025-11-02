using System;
using System.Net;
using System.Security;
using System.Text;
using System.Threading;

internal class Class59
{
	public bool bool_0;

	public string string_0;

	public SecureString secureString_0;

	public string string_1;

	public object object_0;

	public byte[] byte_0;

	public int int_0;

	private static long long_0 = 0L;

	private static long long_1 = 0L;

	private static long long_2 = 0L;

	private static long long_3 = 0L;

	private static long long_4 = 0L;

	private static bool bool_1 = false;

	private static Random random_0 = new Random();

	public void method_0()
	{
		if (GClass1.long_0 < 0L)
		{
			GClass1.long_0 = 0L;
		}
		try
		{
			method_1();
		}
		catch
		{
		}
		GClass1.int_0++;
	}

	public void method_1()
	{
		while (true)
		{
			if (!Class11.bool_0)
			{
				if (GClass1.gstruct14_0 != null)
				{
					break;
				}
				if (Class11.smethod_23(long_0) <= 1500L)
				{
					Thread.Sleep(150);
					continue;
				}
			}
			long_0 = Class11.smethod_22();
            string text = Class11.char_0;// method_7();
			if (text == null || text == string.Empty)
			{
				break;
			}
			string text2 = Class11.smethod_30(text, "10", Encoding.ASCII.GetBytes(Class11.smethod_1(Class11.char_10)));
			string[] array = text2.Split('\n', '\r');
			GClass1.gstruct14_0 = new GClass1.GStruct14[array.Length];
			int num = 0;
			foreach (string text3 in array)
			{
				if (text3 == null || text3 == string.Empty)
				{
					continue;
				}
				if (text3[0] != 'N')
				{
					string[] array2 = text3.Split('|');
					if (array2[0] == null || array2[0] == string.Empty)
					{
						continue;
					}
					string text4 = array2[0].Replace(" ", string.Empty);
					GClass1.gstruct14_0[num].uint_0 = Class11.smethod_7(text4);
					GClass1.gstruct14_0[num].long_0 = 0L;
					if (text4 != null && text4 != string.Empty)
					{
						int length = text4.Length;
						text4 = string.Empty;
						for (int j = 0; j < text4.Length; j++)
						{
							text4 += '\0';
						}
					}
					if (array2.Length > 1)
					{
						string[] array3 = array2[1].Split('.', '/', '-');
						if (array3.Length == 3)
						{
							int num2 = Class11.smethod_12(array3[0]);
							int num3 = Class11.smethod_12(array3[1]);
							int num4 = Class11.smethod_12(array3[2]);
							if (0 < num2 && num2 <= 31 && 0 < num3 && num3 <= 12 && num4 > 0)
							{
								GClass1.gstruct14_0[num].long_0 = new DateTime(num4, num3, num2, 12, 30, 0, 0).Ticks;
							}
						}
						if (array2.Length > 2)
						{
							string[] array4 = array2[2].Split(':');
							if (array4.Length > 1)
							{
								GClass1.gstruct14_0[num].string_0 = array4[0];
								GClass1.gstruct14_0[num].int_0 = Class11.smethod_12(array4[1]);
								if (array4.Length > 2)
								{
									GClass1.gstruct14_0[num].int_1 = Class11.smethod_12(array4[2]);
								}
							}
							if (array2.Length > 3)
							{
								GClass1.gstruct14_0[num].string_1 = array2[3];
							}
							num++;
						}
						else
						{
							num++;
						}
					}
					else
					{
						num++;
					}
				}
				else
				{
					GClass1.long_0 = Class11.smethod_31(text3.Substring(1));
				}
			}
			if (num != 0)
			{
				if (GClass1.gstruct14_0.Length > num)
				{
					Array.Resize(ref GClass1.gstruct14_0, num);
				}
			}
			else
			{
				GClass1.gstruct14_0 = null;
			}
			break;
		}
		bool_0 = true;
	}

	public void method_2()
	{
		Random random = new Random();
		int num = random.Next(100, 400);
		while (true)
		{
			if (!Class11.bool_0 && long_1 > 0L)
			{
				if (Class90.gstruct52_0 != null)
				{
					break;
				}
				if (Class11.smethod_23(long_1) <= 150000L)
				{
					Thread.Sleep(150 + num);
					continue;
				}
			}
			long_1 = Class11.smethod_22();
            string text = Class11.char_0;// method_7();
			if (text == null || text == string.Empty)
			{
				break;
			}
			string[] array = null;
			string[] array2 = text.Split('\n', '\r');
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] != null && array2[i] != string.Empty)
				{
					string[] array3 = array2[i].Split('|');
					int num2 = array3.Length;
					if (num2 < 2 || !(array3[1] != "1"))
					{
					}
					if (array != null)
					{
						Array.Resize(ref array, array.Length + 1);
						array[array.Length - 1] = array2[i];
					}
					else
					{
						array = new string[1]
						{
							array2[i]
						};
					}
				}
			}
			if (array != null)
			{
				Class90.string_0 = new string[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					Class90.string_0[i] = array[i];
				}
				new Thread(Class90.smethod_0).Start();
			}
			break;
		}
		long_1 = 0L;
		bool_0 = true;
	}

	public void method_3()
	{
		while (true)
		{
			if (!Class11.bool_0 && long_2 > 0L)
			{
				if (GClass1.long_3 > 0L)
				{
					break;
				}
				if (Class11.smethod_23(long_2) <= 1500L)
				{
					Thread.Sleep(150);
					continue;
				}
			}
			long_2 = Class11.smethod_22();
            string text = Class11.char_0;// method_7();
            if (text != null && !(text == string.Empty))
			{
				long num = Class11.smethod_31(text);
				if (num > 0L)
				{
					GClass1.long_3 = num;
					GClass1.int_1 = 1;
				}
			}
			break;
		}
		bool_0 = true;
	}

	public void method_4()
	{
		while (true)
		{
			if (!Class11.bool_0 && long_3 > 0L)
			{
				if (GClass1.long_2 > 0L)
				{
					break;
				}
				if (Class11.smethod_23(long_3) <= 1500L)
				{
					Thread.Sleep(150);
					continue;
				}
			}
			long_3 = Class11.smethod_22();
			string text = Class11.char_0;//method_7();
			if (text != null && !(text == string.Empty))
			{
				long num = Class11.smethod_31(text) / 2L;
				if (num > 0L && GClass1.long_2 != num)
				{
					GClass1.long_2 = num;
					GClass1.int_1 = 1;
				}
			}
			break;
		}
		bool_0 = true;
	}

	public void method_5()
	{
		while (true)
		{
			if (!Class11.bool_0 && long_3 > 0L)
			{
				if (GClass1.gstruct13_0.bool_0)
				{
					break;
				}
				if (Class11.smethod_23(long_3) <= 1500L)
				{
					Thread.Sleep(150);
					continue;
				}
			}
			if (byte_0 == null || byte_0.Length == 0)
			{
				break;
			}
			long_3 = Class11.smethod_22();
			string text = Class11.char_0;//method_7();
			if (!GClass1.gstruct13_0.bool_0)
			{
				string[] array = text.Split(Class11.smethod_48(Class11.string_3)[0]);
				if (array.Length >= 2)
				{
					string text2 = Class11.smethod_30(array[1], text[0].ToString(), new byte[8]);
					if (text2 != null && !(text2 == string.Empty))
					{
						string[] array2 = text2.Split(Class11.smethod_48(Class11.string_3)[0]);
						if (array2.Length >= 2)
						{
							string text3 = array[0].Substring(1);
							int num = (byte)array[0][0] - 64;
							int num2 = Class11.smethod_12(text3.Substring(10, 4));
							string text4 = text3.Substring(0, 10) + text3.Substring(14);
							string string_ = text4.Substring(20, num2);
							string string_2 = Class11.smethod_16(string_);
							DateTime dateTime = new DateTime(Class11.smethod_31(string_2));
							string string_3 = text4.Substring(0, 20) + text4.Substring(20 + num2);
							byte_0[0] = (byte)(array2[0].Length + array2[1].Length + 1);
							string str = (Class11.smethod_7(string_2) + num).ToString();
							string string_4 = Class11.smethod_7(text2 + str).ToString();
							string string_5 = Class11.smethod_30(string_3, string_4, byte_0);
							string text5 = Class11.smethod_48(string_5);
							array2 = text5.Split(Class11.smethod_48(Class11.string_3)[0]);
							GClass1.gstruct13_0.string_2 = string.Empty;
							GClass1.gstruct13_0.uint_1 = null;
							string text6 = string.Empty;
							if (array.Length > 2)
							{
								text6 = array[2];
							}
							if (array2.Length > 2)
							{
								string[] array3 = array2[1].Split('\u0001');
								GClass1.gstruct13_0.string_0 = array3[0];
								if (array3.Length > 1)
								{
									text6 = array3[1];
									GClass1.gstruct13_0.string_2 = Class11.smethod_17(text6);
								}
								GClass1.gstruct13_0.string_1 = array2[0];
								GClass1.gstruct13_0.long_0 = Class11.smethod_31(array2[2]);
								GClass1.gstruct13_0.long_1 = Class11.smethod_31(string_2);
								GClass1.gstruct13_0.int_0 = num;
								GClass1.gstruct13_0.uint_0 = Class11.smethod_7(array2[0]);
							}
							if (text6 != null && text6 != string.Empty)
							{
								string[] array4 = text6.Replace(" ", string.Empty).Replace("-", string.Empty).Split(',', ';');
								GClass1.gstruct13_0.uint_1 = new uint[array4.Length];
								for (int i = 0; i < array4.Length; i++)
								{
									GClass1.gstruct13_0.uint_1[i] = Class11.smethod_7(array4[i]);
								}
								int length = text6.Length;
								text6 = string.Empty;
								for (int j = 0; j < length; j++)
								{
									text6 += '\0';
								}
								array4 = null;
							}
							GClass1.gstruct13_0.bool_0 = (GClass1.gstruct13_0.uint_0 != 0 && GClass1.gstruct13_0.long_0 > GClass1.long_1 && GClass1.long_1 > 636758336219996160L);
							GClass1.long_2 = 0L;
							GClass1.int_1 = 1;
						}
					}
				}
			}
			if (text != string.Empty && text != null)
			{
				int i = text.Length;
				text = string.Empty;
				for (int j = 0; j < i; j++)
				{
					text += '\0';
				}
			}
			break;
		}
		bool_0 = true;
		byte_0 = null;
	}

	public void method_6()
	{
		while (!Class11.bool_0 && long_4 > 0L && Class11.smethod_23(long_4) <= 1500L)
		{
			Thread.Sleep(150);
		}
		long_4 = Class11.smethod_22();
        string text = Class11.char_0;//method_7();
		string[] array;
		if (text != null && !(text == string.Empty))
		{
			array = text.Split('|');
			string text2 = array[0].Replace(".", "");
			if (Class11.smethod_12(text2) > 0)
			{
				if (GClass1.string_2 == null || !(GClass1.string_2 != string.Empty))
				{
					goto IL_0167;
				}
				string text3 = GClass1.string_2.Replace(".", "");
				while (text3.Length != text2.Length)
				{
					if (text3.Length < text2.Length)
					{
						text3 += "0";
					}
					else
					{
						text2 += "0";
					}
				}
				int num = Class11.smethod_12(text3);
				int num2 = Class11.smethod_12(text2);
				if (num2 >= num)
				{
					if (num2 != num)
					{
						goto IL_0167;
					}
					if (array.Length > 1 && array[1] != string.Empty && array[1] != null)
					{
						GClass1.string_3 = array[1];
					}
				}
			}
		}
		goto IL_019c;
		IL_0167:
		GClass1.string_2 = array[0];
		GClass1.string_1 = array[0];
		if (array.Length > 1 && array[1] != string.Empty && array[1] != null)
		{
			GClass1.string_3 = array[1];
		}
		goto IL_019c;
		IL_019c:
		bool_0 = true;
	}

	private string method_7()
	{
		string result = string.Empty;
		if (string_1 != null && !(string_1 == string.Empty))
		{
			try
			{
				if (string_1[0] > 'ÿ')
				{
					string_1 = Class11.smethod_48(string_1);
				}
				string text = object_0.ToString();
				string text2 = object_0.GetType().ToString().ToUpper();
				if (text2.IndexOf(Class11.smethod_48(Class11.string_12)) > 0)
				{
					text = string.Concat((char[])object_0);
				}
				if (text[0] > 'ÿ')
				{
					text = Class11.smethod_48(text);
				}
				if ((byte)text[0] != 47)
				{
					text = '/' + text;
				}
				Uri uri = new Uri(string_1 + text);
				if (uri.Host != null && !(uri.Host == string.Empty))
				{
					string text3 = uri.Host.ToLower();
					if (text3 != null && !(text3 == string.Empty))
					{
						int num = 0;
						while (bool_1 && num < 10)
						{
							Thread.Sleep(10 + random_0.Next(10, 120));
							num++;
						}
						bool_1 = true;
						if (GClass1.string_0 == null)
						{
							GClass1.string_0 = new string[1]
							{
								text3
							};
							Class11.gstruct41_0 = new GStruct41[1]
							{
								new GStruct41
								{
									byte_0 = BitConverter.GetBytes(Class11.smethod_7(text3))
								}
							};
						}
						else
						{
							bool flag = false;
							int num2 = GClass1.string_0.Length;
							for (int i = 0; i < num2; i++)
							{
								if (GClass1.string_0[i] == text3)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								Array.Resize(ref GClass1.string_0, num2 + 1);
								GClass1.string_0[num2] = text3;
								Array.Resize(ref Class11.gstruct41_0, num2 + 1);
								Class11.gstruct41_0[num2] = new GStruct41
								{
									byte_0 = BitConverter.GetBytes(Class11.smethod_7(text3))
								};
							}
						}
						bool_1 = false;
						if (text3[0] < '0' || text3[0] > '9')
						{
							int num3 = text3.IndexOf(".");
							if (num3 > 0)
							{
								text3 = text3.Substring(0, num3);
							}
						}
						char[] array = text3.ToCharArray();
						int num4 = 0;
						for (int i = 0; i < array.Length; i++)
						{
							num4 += (i + 1) * array[i];
						}
						if (num4 == 4632 || num4 == 2293)
						{
							WebClient webClient = new WebClient();
							byte[] array2 = null;
							if (string_1[0] != 'f' && string_1[0] != 'F')
							{
								array2 = webClient.DownloadData(uri);
							}
							else
							{
								if (string_0 != null && string_0 != string.Empty && string_0[0] > 'ÿ')
								{
									string_0 = Class11.smethod_48(string_0);
								}
								webClient.Credentials = new NetworkCredential(string_0, secureString_0);
								array2 = webClient.DownloadData(uri);
							}
							if (array2 != null)
							{
								result = Encoding.Default.GetString(array2, 0, array2.Length);
							}
							webClient.CancelAsync();
						}
					}
				}
			}
			catch
			{
			}
		}
		secureString_0 = null;
		object_0 = null;
		if (string_0 != string.Empty && string_0 != null)
		{
			int i = string_0.Length;
			string_0 = string.Empty;
			for (int j = 0; j < i; j++)
			{
				string_0 += '\0';
			}
		}
		if (string_1 != string.Empty && string_1 != null)
		{
			int i = string_1.Length;
			string_1 = string.Empty;
			for (int j = 0; j < i; j++)
			{
				string_1 += '\0';
			}
		}
		return result;
	}
}
