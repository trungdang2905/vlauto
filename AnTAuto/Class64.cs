using System.Net.Sockets;
using System.Text;
using System.Threading;

internal class Class64
{
	public TcpClient tcpClient_0 = null;

	public NetworkStream networkStream_0 = null;

	private long long_0 = 0L;

	public void method_0(object object_0)
	{
		try
		{
			NetworkStream networkStream = (NetworkStream)object_0;
			byte[] buffer = new byte[1]
			{
				1
			};
			while (!Class11.bool_0 && Class62.int_0 > 0 && 0L <= long_0)
			{
				if (Class11.smethod_23(long_0) > 1000L)
				{
					networkStream.Write(buffer, 0, 1);
					long_0 = Class11.smethod_22();
				}
				Thread.Sleep(300);
			}
		}
		catch
		{
		}
	}

	public void method_1()
	{
		if (Class62.string_3 != null && !(Class62.string_3 == string.Empty))
		{
			if (Class62.string_2 == null || Class62.string_2 == string.Empty)
			{
				Class62.string_2 = "127.0.0.0";
			}
			byte[] buffer = new byte[1]
			{
				1
			};
			byte[] array = new byte[256];
			byte[] bytes = Encoding.ASCII.GetBytes(Class62.string_2 + "...");
			bool flag = false;
			while (true)
			{
				Thread.Sleep(600);
				if (Class11.bool_0 || Class62.int_0 <= 0)
				{
					break;
				}
				if (!flag)
				{
					Class11.smethod_24(ref Class62.string_0, Class62.smethod_2() + "\tChờ kết nối đến " + Class62.string_3 + "...");
					flag = true;
				}
				try
				{
					tcpClient_0 = new TcpClient(Class62.string_3, Class62.int_3);
					networkStream_0 = tcpClient_0.GetStream();
					networkStream_0.Write(bytes, 0, bytes.Length);
					Class11.smethod_24(ref Class62.string_0, Class62.smethod_2() + "\tKết nối thành công");
					flag = false;
					long_0 = 0L;
					ThreadPool.QueueUserWorkItem(method_0, networkStream_0);
					int num = 0;
					do
					{
						num++;
						Class62.long_0++;
						Thread.Sleep(150);
						if (Class11.bool_0 || Class62.int_0 <= 0)
						{
							networkStream_0.Close();
							return;
						}
						long_0 = Class11.smethod_22();
						int num2 = networkStream_0.Read(array, 0, array.Length);
						if (num2 > 0)
						{
							string @string = Encoding.ASCII.GetString(array, 0, num2);
							if (@string != string.Empty && @string != null)
							{
								Class62.smethod_4(@string);
								Class11.smethod_24(ref Class62.string_0, @string);
							}
							num = 0;
						}
						networkStream_0.Write(buffer, 0, 1);
					}
					while (num < 60);
				}
				catch
				{
				}
				if (!flag)
				{
					Class11.smethod_24(ref Class62.string_0, Class62.smethod_2() + "\tGián đoạn.");
				}
				method_2();
				Thread.Sleep(999);
			}
			Class11.smethod_24(ref Class62.string_0, Class62.smethod_2() + "\tKết thúc.");
			method_2();
		}
		else
		{
			Class11.smethod_24(ref Class62.string_0, "Chưa thiết lập IP máy phụ.");
			method_2();
		}
	}

	public void method_2()
	{
		try
		{
			networkStream_0.Close();
		}
		catch
		{
		}
		try
		{
			tcpClient_0.Close();
		}
		catch
		{
		}
	}
}
