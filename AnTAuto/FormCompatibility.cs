using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.ServiceProcess;
using System.Windows.Forms;

public class FormCompatibility : Form
{
	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Button buttonClose;

	private Label label1;

	private Button buttonFix;

	private TextBox textBoxPhienBan;

	private RichTextBox richTextBox1;

	private Label label2;

	private Button buttonDefender;

	private Label labelThongso;

	private TextBox textBoxThongso;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static string[] string_0 = null;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormCompatibility));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonClose = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		buttonFix = new System.Windows.Forms.Button();
		textBoxPhienBan = new System.Windows.Forms.TextBox();
		richTextBox1 = new System.Windows.Forms.RichTextBox();
		label2 = new System.Windows.Forms.Label();
		buttonDefender = new System.Windows.Forms.Button();
		labelThongso = new System.Windows.Forms.Label();
		textBoxThongso = new System.Windows.Forms.TextBox();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonClose.BackColor = System.Drawing.SystemColors.Control;
		buttonClose.Location = new System.Drawing.Point(176, 209);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(114, 36);
		buttonClose.TabIndex = 14;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = false;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		label1.AutoSize = true;
		label1.BackColor = System.Drawing.Color.LightSteelBlue;
		label1.Location = new System.Drawing.Point(8, 68);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(102, 13);
		label1.TabIndex = 16;
		label1.Text = "Phiên bản Windows";
		buttonFix.BackColor = System.Drawing.SystemColors.Control;
		buttonFix.Location = new System.Drawing.Point(11, 167);
		buttonFix.Name = "buttonFix";
		buttonFix.Size = new System.Drawing.Size(159, 36);
		buttonFix.TabIndex = 17;
		buttonFix.Text = "Chuyển game sang chế độ 16-bit Windows 8 và 10";
		buttonFix.UseVisualStyleBackColor = false;
		buttonFix.Click += new System.EventHandler(buttonFix_Click);
		textBoxPhienBan.BackColor = System.Drawing.SystemColors.Control;
		textBoxPhienBan.Location = new System.Drawing.Point(116, 66);
		textBoxPhienBan.Name = "textBoxPhienBan";
		textBoxPhienBan.ReadOnly = true;
		textBoxPhienBan.Size = new System.Drawing.Size(174, 20);
		textBoxPhienBan.TabIndex = 18;
		richTextBox1.Location = new System.Drawing.Point(11, 94);
		richTextBox1.Name = "richTextBox1";
		richTextBox1.Size = new System.Drawing.Size(279, 67);
		richTextBox1.TabIndex = 20;
		richTextBox1.Text = "";
		label2.BackColor = System.Drawing.Color.LightSteelBlue;
		label2.Location = new System.Drawing.Point(9, 5);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(281, 28);
		label2.TabIndex = 22;
		label2.Text = "Phần này chỉ được sử dụng khi xảy ra hiện tượng: mở auto lên thì game lại thoát";
		buttonDefender.BackColor = System.Drawing.SystemColors.Control;
		buttonDefender.Location = new System.Drawing.Point(176, 167);
		buttonDefender.Name = "buttonDefender";
		buttonDefender.Size = new System.Drawing.Size(114, 36);
		buttonDefender.TabIndex = 23;
		buttonDefender.Text = "Tắt Defender trên Windows 8 và 10";
		buttonDefender.UseVisualStyleBackColor = false;
		buttonDefender.Click += new System.EventHandler(buttonDefender_Click);
		labelThongso.AutoSize = true;
		labelThongso.BackColor = System.Drawing.Color.LightSteelBlue;
		labelThongso.Location = new System.Drawing.Point(9, 45);
		labelThongso.Name = "labelThongso";
		labelThongso.Size = new System.Drawing.Size(74, 13);
		labelThongso.TabIndex = 24;
		labelThongso.Text = "Thông số máy";
		textBoxThongso.BackColor = System.Drawing.SystemColors.Control;
		textBoxThongso.Location = new System.Drawing.Point(116, 43);
		textBoxThongso.Name = "textBoxThongso";
		textBoxThongso.ReadOnly = true;
		textBoxThongso.Size = new System.Drawing.Size(174, 20);
		textBoxThongso.TabIndex = 25;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(299, 254);
		base.Controls.Add(textBoxThongso);
		base.Controls.Add(labelThongso);
		base.Controls.Add(buttonDefender);
		base.Controls.Add(label2);
		base.Controls.Add(richTextBox1);
		base.Controls.Add(textBoxPhienBan);
		base.Controls.Add(buttonFix);
		base.Controls.Add(label1);
		base.Controls.Add(buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormCompatibility";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Compatibility Mode";
		base.Load += new System.EventHandler(FormCompatibility_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public static string[] smethod_0()
	{
		try
		{
			return smethod_1();
		}
		catch
		{
		}
		return null;
	}

	private static string[] smethod_1()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string[] array = new string[2]
		{
			string.Empty,
			string.Empty
		};
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 10:
				if (!(version.Revision.ToString() == "2222A"))
				{
					array[0] = "98";
				}
				else
				{
					array[0] = "98SE";
				}
				break;
			case 90:
				array[0] = "ME";
				break;
			case 0:
				array[0] = "95";
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				array[0] = "NT3.51";
				break;
			case 4:
				array[0] = "NT4.0";
				break;
			case 5:
				if (version.Minor == 0)
				{
					array[0] = "2000";
				}
				else
				{
					array[0] = "XP";
				}
				break;
			case 6:
				if (version.Minor != 0)
				{
					if (version.Minor != 1)
					{
						if (version.Minor == 2)
						{
							array[0] = "8";
						}
						else
						{
							array[0] = "8.1";
						}
					}
					else
					{
						array[0] = "7";
					}
				}
				else
				{
					array[0] = "VISTA";
				}
				break;
			case 10:
				array[0] = "10";
				break;
			}
		}
		if (array[0] != string.Empty)
		{
			array[1] = "Windows " + array[0];
			if (oSVersion.ServicePack != "")
			{
				string[] array2;
				(array2 = array)[1] = array2[1] + " " + oSVersion.ServicePack;
			}
		}
		return array;
	}

	public static bool smethod_2(string[] string_1)
	{
		return string_1 != null && string_1[0] != "10" && string_1[0] != "8.1" && string_1[0] != "8" && string_1[0] != "7" && string_1[0] != "VISTA";
	}

	public FormCompatibility()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormCompatibility_Load(object sender, EventArgs e)
	{
		if (int_0 > 0 && int_1 > 0)
		{
			int num = int_0 - base.Width - 10;
			int num2 = int_1 - base.Height - 10;
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
		try
		{
			string_0 = smethod_0();
		}
		catch
		{
		}
		if (string_0 != null && string_0[0] != string.Empty)
		{
			textBoxPhienBan.Text = string_0[1];
		}
		else
		{
			textBoxPhienBan.Text = "Không xác định";
		}
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 4, array, 1, ref int_);
		Class20.ReadProcessMemory(Class11.int_1, Class11.uint_1 + 8, array2, 4, ref int_);
		string text = "[" + Class20.smethod_30(Class11.uint_1, Class11.int_1) + "] [" + Convert.ToByte(Class7.bool_0) + "] [" + Class38.int_0 + "] [" + array[0] + "] [" + BitConverter.ToUInt32(array2, 0) + "]";
		textBoxThongso.Text = text;
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private static void smethod_3(string string_1, string string_2, bool bool_1 = true)
	{
		try
		{
			string text = "Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers";
			if (bool_1)
			{
				Class55.smethod_10(text, string_1, string_2, "", 0);
				Class55.smethod_10(text, string_1, string_2, "", 1);
			}
			else
			{
				Class55.smethod_12(text, string_1, 0);
				Class55.smethod_12(text, string_1, 1);
			}
		}
		catch
		{
		}
	}

	private void buttonFix_Click(object sender, EventArgs e)
	{
		string string_ = string.Empty;
		if (string_0 != null && string_0[0] != string.Empty && (string_0[0] == "10" || string_0[0] == "8.1" || string_0[0] == "8"))
		{
			string_ = "16BITCOLOR";
		}
		string text = null;
		int[] array = Class20.smethod_24(Class47.string_17);
		if (array != null && array.Length > 0)
		{
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					Process processById = Process.GetProcessById(array[i]);
					text = processById.MainModule.FileName;
					string a = Class55.smethod_6("PathGame", 0);
					if (text != null && text != string.Empty)
					{
						if (a != text)
						{
							Class55.smethod_10(Class47.string_0, "PathGame", text, "", 0);
							Class20.smethod_70(text, bool_0: false);
						}
						goto IL_0103;
					}
				}
				catch
				{
				}
			}
		}
		goto IL_0103;
		IL_0103:
		if (text == null || text == string.Empty)
		{
			text = Class55.smethod_6("PathGame", 0);
			if (text == null || text == string.Empty || !Class11.smethod_18(text))
			{
				richTextBox1.Text = "Hãy mở 1 cửa sổ game lên trước khi bấm nút Fix này.";
				return;
			}
		}
		smethod_3(text, string_);
		string[] array2 = Class11.smethod_15(text);
		string string_2 = array2[0] + "\\config.ini";
		if (Class11.smethod_18(string_2))
		{
			string text2 = Class11.smethod_28(string_2, 0, 0, 1);
			string[] array3 = text2.Split('\r', '\n');
			string text3 = string.Empty;
			for (int j = 0; j < array3.Length; j++)
			{
				if (array3[j].ToLower().IndexOf("epresent") > 0)
				{
					text3 = array3[j];
					break;
				}
			}
			text2 = ((text3 != string.Empty) ? text2.Replace(text3, "Represent=2") : Class11.smethod_16("W1NlcnZlcl0KR2FtZVNlcnZQb3J0PTU2MjIKRGVuaWFsUG9ydD01NjIzCgpbQ2xpZW50XQpDYW5PcGVuVXJsV2hlbkV4aXQ9MApGdWxsU2NyZWVuPTAKUmVwcmVzZW50PTIKRlBTPTAKRHluYW1pY0xpZ2h0PTAKQ2FwUGF0aD0="));
			Class11.smethod_29(string_2, text2, 1);
		}
		richTextBox1.Text = "Đã chuyển game sang chạy ở chế độ 16bit";
	}

	private void buttonDefender_Click(object sender, EventArgs e)
	{
		string str = "SOFTWARE\\Policies\\Microsoft\\Windows Defender";
		Class55.smethod_10(str, "DisableAntiSpyware", 1, "DWORD", 0);
		Class55.smethod_10(str, "DisableAntiSpyware", 1, "DWORD", 1);
		richTextBox1.Text = "Đã tắt Windows Denfender, khởi động lại máy tính mới có hiệu lực. Nếu muốn khôi phục thì xóa nhánh sau trong registry:" + Class47.string_3 + str;
	}

	private static int smethod_4(string string_1, int int_4)
	{
		ServiceController serviceController = new ServiceController(string_1);
		try
		{
			TimeSpan timeout = TimeSpan.FromMilliseconds(int_4);
			string text = serviceController.Status.ToString().ToUpper();
			if (text.IndexOf("STOP") < 0)
			{
				serviceController.Stop();
				serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
			}
			return 1;
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_5()
	{
		try
		{
			if (string_0 == null)
			{
				string_0 = smethod_0();
			}
		}
		catch
		{
		}
		if (string_0 != null && !(string_0[0] == string.Empty))
		{
			if (!(string_0[0] == "7") && !(string_0[0] == "VISTA"))
			{
				if (string_0[0] != "10" && string_0[0] != "8.1" && string_0[0] != "8")
				{
					return smethod_4("ShareAccess", 10000);
				}
				try
				{
					Process process = new Process();
					process.StartInfo.Arguments = "Firewall set opmode disable";
					process.StartInfo.FileName = "netsh.exe";
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.RedirectStandardOutput = true;
					process.StartInfo.CreateNoWindow = true;
					process.Start();
					process.WaitForExit();
					return 1;
				}
				catch
				{
				}
				return 0;
			}
			return smethod_4("MpsSvc", 10000);
		}
		smethod_4("MpsSvc", 10000);
		return smethod_4("ShareAccess", 10000);
	}
}
