using System.Net;
using System.Threading;

internal class Class14
{
	private struct Struct8
	{
		public string string_0;

		public long long_0;
	}

	public static string string_0 = Class47.string_4 + "\\Ram";

	private static Struct8[] struct8_0 = new Struct8[7]
	{
		new Struct8
		{
			string_0 = "fr.bpl",
			long_0 = 135680L
		},
		new Struct8
		{
			string_0 = "madbasic_.bpl",
			long_0 = 92672L
		},
		new Struct8
		{
			string_0 = "maddisAsm_.bpl",
			long_0 = 29184L
		},
		new Struct8
		{
			string_0 = "madexcept_.bpl",
			long_0 = 159744L
		},
		new Struct8
		{
			string_0 = "rtl120.bpl",
			long_0 = 607232L
		},
		new Struct8
		{
			string_0 = "vcl120.bpl",
			long_0 = 1000960L
		},
		new Struct8
		{
			string_0 = "fr.exe",
			long_0 = 1000000L
		}
	};

	public static bool bool_0 = false;

	public void method_0()
	{
		if (FormMain.int_62 != 0)
		{
			int num = 0;
			while (!bool_0 && num < 300)
			{
				if (!Class11.bool_0)
				{
					if (FormMain.int_62 != 0)
					{
						num++;
						Thread.Sleep(600);
						continue;
					}
					smethod_0();
					return;
				}
				return;
			}
			bool_0 = false;
			if (!Class11.smethod_18(string_0 + "\\fr.exe"))
			{
				if (Class11.smethod_18(string_0 + "\\fr.bpl"))
				{
					Class20.smethod_40(string_0 + "\\fr.bpl", string_0, "", 0);
				}
			}
			else
			{
				Class20.smethod_40(string_0 + "\\fr.exe", string_0, "", 0);
			}
		}
		else
		{
			smethod_0();
		}
	}

	public static void smethod_0()
	{
		try
		{
			int int_ = Class20.smethod_54("fr.bpl");
			string text = Class20.smethod_25(int_, "FREE RAM");
			if (text != "")
			{
				string[] array = text.Split(';');
				for (int i = 0; i < array.Length; i++)
				{
					Class20.PostMessageA_1(Class11.smethod_13(array[i]), Class20.int_17, 0u, 0u);
				}
			}
		}
		catch
		{
		}
	}

	public static bool smethod_1(string string_1)
	{
		bool result = false;
		try
		{
			HttpWebResponse httpWebResponse = null;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
			httpWebRequest.Method = "HEAD";
			httpWebRequest.Timeout = 5000;
			httpWebRequest.AllowAutoRedirect = false;
			httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			result = (httpWebResponse.StatusCode == HttpStatusCode.OK);
			return result;
		}
		catch
		{
			return result;
		}
	}
}
