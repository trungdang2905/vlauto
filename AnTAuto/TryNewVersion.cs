using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

public class TryNewVersion : Form
{
	private IContainer icontainer_0 = null;

	private Button buttonDownload;

	private System.Windows.Forms.Timer timer_0;

	private TextBox textBoxStatus;

	private LinkLabel linkLabelLinkWeb;

	private LinkLabel linkLabelBlog;

	private Button buttonAutoTrain;

	private LinkLabel linkLabelTaiTructiep;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	private static string[] string_0 = null;

	//override void Form.Dispose(bool disposing)
	//{
	//	if (disposing && icontainer_0 != null)
	//	{
	//		icontainer_0.Dispose();
	//	}
	//	Dispose(disposing);
	//}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(TryNewVersion));
		buttonDownload = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		textBoxStatus = new System.Windows.Forms.TextBox();
		linkLabelLinkWeb = new System.Windows.Forms.LinkLabel();
		linkLabelBlog = new System.Windows.Forms.LinkLabel();
		buttonAutoTrain = new System.Windows.Forms.Button();
		linkLabelTaiTructiep = new System.Windows.Forms.LinkLabel();
		SuspendLayout();
		buttonDownload.BackColor = System.Drawing.SystemColors.Control;
		buttonDownload.ForeColor = System.Drawing.Color.DarkRed;
		buttonDownload.Location = new System.Drawing.Point(231, 102);
		buttonDownload.Name = "buttonDownload";
		buttonDownload.Size = new System.Drawing.Size(95, 36);
		buttonDownload.TabIndex = 1;
		buttonDownload.Text = "Tải KYKeoxe phiên bản mới";
		buttonDownload.UseVisualStyleBackColor = false;
		buttonDownload.Click += new System.EventHandler(buttonDownload_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		textBoxStatus.Location = new System.Drawing.Point(2, 1);
		textBoxStatus.Multiline = true;
		textBoxStatus.Name = "textBoxStatus";
		textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		textBoxStatus.Size = new System.Drawing.Size(320, 58);
		textBoxStatus.TabIndex = 9;
		textBoxStatus.Text = "Bạn vui lòng tắt Antivirus nếu có trước khi tải cập nhật. Bấm tải trực tiếp nếu không cập nhật được";
		linkLabelLinkWeb.AutoSize = true;
		linkLabelLinkWeb.Location = new System.Drawing.Point(7, 104);
		linkLabelLinkWeb.Name = "linkLabelLinkWeb";
		linkLabelLinkWeb.Size = new System.Drawing.Size(89, 13);
		linkLabelLinkWeb.TabIndex = 141;
		linkLabelLinkWeb.TabStop = true;
		linkLabelLinkWeb.Text = "http://kimyen.net";
		linkLabelLinkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelLinkWeb_LinkClicked);
		linkLabelBlog.AutoSize = true;
		linkLabelBlog.Location = new System.Drawing.Point(7, 121);
		linkLabelBlog.Name = "linkLabelBlog";
		linkLabelBlog.Size = new System.Drawing.Size(129, 13);
		linkLabelBlog.TabIndex = 142;
		linkLabelBlog.TabStop = true;
		linkLabelBlog.Text = "http://vltool.blogspot.com";
		linkLabelBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelBlog_LinkClicked);
		buttonAutoTrain.Location = new System.Drawing.Point(140, 102);
		buttonAutoTrain.Name = "buttonAutoTrain";
		buttonAutoTrain.Size = new System.Drawing.Size(85, 36);
		buttonAutoTrain.TabIndex = 143;
		buttonAutoTrain.Text = "Tải auto train (KYTrain)";
		buttonAutoTrain.UseVisualStyleBackColor = true;
		buttonAutoTrain.Click += new System.EventHandler(buttonAutoTrain_Click);
		linkLabelTaiTructiep.AutoSize = true;
		linkLabelTaiTructiep.Location = new System.Drawing.Point(7, 64);
		linkLabelTaiTructiep.Name = "linkLabelTaiTructiep";
		linkLabelTaiTructiep.Size = new System.Drawing.Size(285, 13);
		linkLabelTaiTructiep.TabIndex = 145;
		linkLabelTaiTructiep.TabStop = true;
		linkLabelTaiTructiep.Text = "==> Click vào đây để tải trực tiếp KYKeoxe_Pass12345.rar";
		linkLabelTaiTructiep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelTaiTructiep_LinkClicked);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(324, 142);
		base.Controls.Add(linkLabelTaiTructiep);
		base.Controls.Add(buttonAutoTrain);
		base.Controls.Add(textBoxStatus);
		base.Controls.Add(linkLabelBlog);
		base.Controls.Add(linkLabelLinkWeb);
		base.Controls.Add(buttonDownload);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "TryNewVersion";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "CAP NHAT AUTO";
		base.Load += new System.EventHandler(TryNewVersion_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public TryNewVersion()
	{
		bool_0 = true;
		InitializeComponent();
	}

	//private void OnFormClosing(object sender, FormClosingEventArgs e)
	//{
	//	bool_0 = false;
	//	int_1 = 0;
	//	int_2 = 0;
	//}

	private void TryNewVersion_Load(object sender, EventArgs e)
	{
		if (int_1 > 0 && int_2 > 0)
		{
			int num = int_1 - base.Width;
			int num2 = int_2 + int_4 - base.Height;
			if (num < 0)
			{
				num = 0;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			SetBounds(num, num2, base.Width, base.Height);
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		this.method_6("CAP NHAT AUTO");
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (string_0 != null && string_0.Length > 0)
			{
				textBoxStatus.Text = string_0[0];
				Class11.smethod_25(ref string_0, string_0[0]);
			}
			if (bool_1)
			{
				buttonDownload.Enabled = (int_0 == 0);
				bool_1 = false;
			}
		}
		else
		{
			Close();
		}
	}

	private bool method_0(string string_1, string string_2)
	{
		for (int i = 0; i < 20; i++)
		{
			if (!Class11.smethod_19(string_1, string_2))
			{
				Thread.Sleep(600);
				continue;
			}
			return true;
		}
		return false;
	}

	private int method_1(string string_1)
	{
		long long_ = Class11.smethod_22();
		while (Class11.smethod_18(string_1))
		{
			Class11.smethod_20(string_1);
			Thread.Sleep(1000);
			if (Class11.smethod_23(long_) > 30000L)
			{
				return 0;
			}
		}
		return 1;
	}

	public int method_2(string string_1, string string_2)
	{
		Class11.smethod_24(ref string_0, "Đang kiểm tra phiên bản auto mới..." + Class47.string_3 + "Bấm tải trực tiếp nếu không cập nhật được.");
		int num = 0;
		bool flag = false;
		while (true)
		{
			byte[] array = null;
			try
			{
				WebClient webClient = new WebClient();
				array = webClient.DownloadData(string_1);
				webClient.CancelAsync();
			}
			catch
			{
				if (num >= string_1.Length - 1)
				{
					if (flag)
					{
						Class11.smethod_24(ref string_0, "Không có phiên bản auto nào được cập nhật.");
						return 0;
					}
					Class11.smethod_24(ref string_0, "Có lỗi khi kiểm tra phiên bản.");
					return -1;
				}
				num++;
				continue;
			}
			int num2 = 10000;
			if (array == null || array.Length < num2)
			{
				flag = true;
				if (num >= string_1.Length - 1)
				{
					break;
				}
				num++;
				continue;
			}
			string text = string_2 + ".Tmp";
			byte[] bytes = Class11.smethod_47(array, bool_1: true);
			File.WriteAllBytes(text, bytes);
			string b = Class11.smethod_9(string_2);
			string a = Class11.smethod_9(text);
			FileInfo fileInfo = new FileInfo(text);
			if (!(a == "") && !(a == b) && fileInfo.Length >= num2)
			{
				Class11.smethod_24(ref string_0, "Đã tải xong auto, xin đợi tí xíu để cập nhật...");
				string text2 = string_2 + ".Bak";
				method_1(text2);
				method_0(string_2, text2);
				if (method_0(text, string_2))
				{
					Class11.smethod_24(ref string_0, "Có phiên bản mới (tắt auto rồi chạy lại).");
					int_0 = 1;
					return 1;
				}
				string text3 = Environment.GetEnvironmentVariable("homedrive") + "\\" + FormMain.string_2;
				if (!method_0(text, text3))
				{
					Class11.smethod_24(ref string_0, "Thất bại, không thể ghi tệp tải về.");
					return -2;
				}
				Class11.smethod_24(ref string_0, "Tệp tải về lưu tại: " + text3 + Class47.string_3 + "Copy tệp trên và chép đè nó vào tệp cũ rồi sử dụng.");
				return 2;
			}
			Class11.smethod_24(ref string_0, "Không có phiên bản mới hơn.");
			Class11.smethod_20(text);
			return 0;
		}
		Class11.smethod_24(ref string_0, "Không có phiên bản auto nào được cập nhật.");
		return 0;
	}

	public static bool smethod_0(string string_1, string string_2, int int_5 = 1000000)
	{
		byte[] array = null;
		try
		{
			if (Class11.smethod_18(string_2))
			{
				Class11.smethod_20(string_2);
				Thread.Sleep(600);
				if (Class11.smethod_18(string_2))
				{
					Random random = new Random();
					string str = random.Next(99999, 99999999).ToString();
					bool flag = false;
					for (int i = 0; i < 20; i++)
					{
						if (Class11.smethod_19(string_2, string_2 + "." + str))
						{
							flag = true;
							break;
						}
						Thread.Sleep(600);
					}
					if (!flag)
					{
						return false;
					}
				}
			}
			WebClient webClient = new WebClient();
			array = webClient.DownloadData(string_1);
			webClient.CancelAsync();
			byte[] bytes = Class11.smethod_47(array, bool_1: true);
			File.WriteAllBytes(string_2, bytes);
			Thread.Sleep(600);
			FileInfo fileInfo = new FileInfo(string_2);
			return fileInfo.Length > int_5;
		}
		catch
		{
		}
		return false;
	}

	public int method_3(string[] string_1, string string_2, int int_5 = 15000)
	{
		string[] array = Class11.smethod_15(string_2);
		Class11.smethod_24(ref string_0, "Bắt đầu tải cập nhật: " + array[1] + Class47.string_3 + "Xin đợi chút xíu ...");
		Class11.smethod_20(string_2 + ".Tmp");
		int num = 0;
		bool flag = false;
		while (true)
		{
			byte[] array2 = null;
			try
			{
				WebClient webClient = new WebClient();
				array2 = webClient.DownloadData(string_1[num]);
				webClient.CancelAsync();
			}
			catch
			{
				if (num >= string_1.Length - 1)
				{
					if (!flag)
					{
						Class11.smethod_24(ref string_0, "Có lỗi khi tải " + array[1]);
						return -1;
					}
					Class11.smethod_24(ref string_0, "Không có tệp " + array[1] + " nào được cập nhật.");
					return 0;
				}
				num++;
				continue;
			}
			if (array2 == null || array2.Length < int_5)
			{
				flag = true;
				if (num >= string_1.Length - 1)
				{
					break;
				}
				num++;
				continue;
			}
			string text = string_2 + ".Tmp";
			byte[] bytes = Class11.smethod_47(array2, bool_1: true);
			File.WriteAllBytes(text, bytes);
			string a = Class11.smethod_9(text);
			FileInfo fileInfo = new FileInfo(text);
			if (!(a == "") && fileInfo.Length >= int_5)
			{
				Class11.smethod_24(ref string_0, "Đã tải xong " + array[1] + ", xin đợi tí xíu để cập nhật...");
				method_1(string_2);
				if (!method_0(text, string_2))
				{
					Class11.smethod_24(ref string_0, "Thất bại, không thể tải về tệp: " + array[1]);
					return -1;
				}
				Class11.smethod_24(ref string_0, "Đã cập nhật xong tệp: " + array[1]);
				return 1;
			}
			Class11.smethod_20(text);
			Class11.smethod_24(ref string_0, "Không có tệp " + array[1] + " nào được cập nhật.");
			method_1(string_2);
			return -1;
		}
		Class11.smethod_24(ref string_0, "Không có tệp " + array[1] + " nào được cập nhật.");
		return 0;
	}

	private void buttonDownload_Click(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			new Thread(method_4).Start();
		}
	}

	public void method_4()
	{
		bool_1 = false;
		string string_ = "http://kimyen.net/upload/" + FormMain.string_2;
		string string_2 = Class20.smethod_74().Replace(FormMain.string_2.ToUpper(), FormMain.string_2);
		method_2(string_, string_2);
		bool_1 = true;
	}

	private void linkLabelLinkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(string_))
		{
			string_ = Class55.smethod_0();
		}
		Class20.smethod_40(string_, "", "http://kimyen.net", 0);
	}

	private void linkLabelBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(string_))
		{
			string_ = Class55.smethod_0();
		}
		Class20.smethod_40(string_, "", "http://vltool.blogspot.com", 0);
	}

	private static string smethod_1(string string_1, bool bool_3)
	{
		string[] array = new string[2]
		{
			"Thất bại.",
			"Thành công"
		};
		string_1 = "- Tải " + string_1 + " \t: " + array[Convert.ToByte(bool_3)];
		return string_1;
	}

	private static void smethod_2(string string_1)
	{
		if (!bool_0)
		{
			Class11.smethod_24(ref Class11.string_14, string_1);
		}
		else
		{
			Class11.smethod_24(ref string_0, string_1);
		}
	}

	private void buttonAutoTrain_Click(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			new Thread(method_5).Start();
		}
	}

	public void method_5()
	{
		string text = "KY TrainJx";
		string text2 = "KYTrain.exe";
		string text3 = Class47.string_4 + "\\KYTrain";
		Class11.smethod_8(text3);
		string text4 = text3 + "\\" + text2;
		string address = "http://kimyen.net/upload/" + text2;
		if (!Class11.smethod_20(text4))
		{
			string text5 = null;
			string[] array = Class11.smethod_15(text2, '.');
			try
			{
				Process[] processesByName = Process.GetProcessesByName(array[0]);
				if (processesByName != null && processesByName.Length > 0)
				{
					text5 = "Hãy thoát " + text2 + " rồi làm lại.";
				}
			}
			catch
			{
			}
			if (text5 == null)
			{
				text5 = "Hãy khởi động lại máy rồi tải lại.";
			}
			Class11.smethod_24(ref string_0, "Có lỗi xảy ra. " + text5);
		}
		else
		{
			bool_1 = true;
			Class11.smethod_24(ref string_0, "Đang tải auto KYTrain, xin chờ chút xíu...");
			byte[] array2 = null;
			try
			{
				WebClient webClient = new WebClient();
				array2 = webClient.DownloadData(address);
				webClient.CancelAsync();
			}
			catch
			{
				Class11.smethod_24(ref string_0, "Có lỗi xảy ra.");
				bool_1 = false;
				return;
			}
			byte[] bytes = Class11.smethod_47(array2, bool_1: true);
			File.WriteAllBytes(text4, bytes);
			Class11.smethod_24(ref string_0, "Đã tải xong auto !");
			Thread.Sleep(1500);
			Class20.smethod_72(text, text4, text3);
			Class20.smethod_70(text4);
			Class20.smethod_40(text4, text3, "", 0);
			bool_1 = false;
			bool_0 = false;
		}
	}

	private void linkLabelTaiTructiep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(string_))
		{
			string_ = Class55.smethod_0();
		}
		string text = "http://www.mediafire.com/file/tn93zb2loodlok2/KYKeoxe_Pass12345.rar";
		textBoxStatus.Text = text;
		Class20.smethod_40(string_, "", text, 0);
	}

	void method_6(string string_1)
	{
		base.Text = string_1;
	}
}
