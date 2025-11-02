using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

internal class Class63
{
	public TcpListener tcpListener_0 = null;

	private void method_0(object object_0)
	{
		TcpClient tcpClient = (TcpClient)object_0;
		NetworkStream stream = tcpClient.GetStream();
		byte[] array = new byte[80];
		string text = null;
		Class62.long_0 = 0L;
		try
		{
			bool flag = false;
			while (!Class11.bool_0 && Class62.int_0 > 0)
			{
				Class62.long_0++;
				Thread.Sleep(120);
				int num = stream.Read(array, 0, array.Length);
				if (num > 0)
				{
					if (array[0] == 1)
					{
						if (!flag)
						{
							string s = Class62.smethod_5();
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							stream.Write(bytes, 0, bytes.Length);
						}
						else
						{
							byte[] bytes = new byte[4]
							{
								46,
								46,
								46,
								0
							};
							stream.Write(bytes, 0, bytes.Length);
							Thread.Sleep(180);
						}
						flag = (Class38.gstruct29_0.int_0 <= 0);
					}
					else
					{
						string @string = Encoding.ASCII.GetString(array, 0, num);
						if (0 > @string.IndexOf("..."))
						{
							Class11.smethod_24(ref Class62.string_0, @string);
						}
						else
						{
							text = @string;
							Class11.smethod_24(ref Class62.string_0, Class62.smethod_2() + "\t" + text + "client connect.");
						}
					}
				}
			}
		}
		catch
		{
		}
		try
		{
			if (text != null)
			{
				Class11.smethod_24(ref Class62.string_0, Class62.smethod_2() + "\t" + text + "client exit.");
			}
			tcpClient.Close();
		}
		catch
		{
		}
	}

	public void method_1()
	{
		if (Class62.string_2 != null && !(Class62.string_2 == string.Empty))
		{
			if (Class62.int_2 <= 0)
			{
				Class62.int_2 = new Random().Next(5000, 20000);
			}
			Class62.string_0 = new string[1]
			{
				Class62.smethod_2() + "\tKhởi tạo server..."
			};
			try
			{
				IPAddress localaddr = IPAddress.Parse(Class62.string_2);
				tcpListener_0 = new TcpListener(localaddr, Class62.int_2);
				tcpListener_0.Start();
				Class11.smethod_24(ref Class62.string_0, Class62.smethod_2() + "\tThành công!");
				while (!Class11.bool_0 && Class62.int_0 > 0)
				{
					TcpClient state = tcpListener_0.AcceptTcpClient();
					ThreadPool.QueueUserWorkItem(method_0, state);
					Thread.Sleep(600);
				}
				Class11.smethod_24(ref Class62.string_0, Class62.smethod_2() + "\tKết thúc server.");
				method_2();
			}
			catch
			{
				method_2();
				if (Class62.int_0 > 0)
				{
					Class11.smethod_24(ref Class62.string_0, Class62.smethod_2() + "\tSever có lỗi, hãy thử đổi password khác...");
					Class62.int_0 = 0;
				}
			}
		}
		else
		{
			Class62.string_0 = new string[1]
			{
				"Chưa thiết lập IP máy chính."
			};
			method_2();
			Class62.int_0 = 0;
		}
	}

	public void method_2()
	{
		try
		{
			tcpListener_0.Stop();
		}
		catch
		{
		}
	}
}
