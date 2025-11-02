using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class FormAntivirus : Form
{
	private struct Struct22
	{
		public Process process_0;

		public string string_0;

		public string string_1;
	}

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	private static string string_0 = Environment.GetEnvironmentVariable(Class11.smethod_1(Class47.char_0));

	private static string[,] string_1 = new string[4, 2]
	{
		{
			"dllhostex",
			null
		},
		{
			"ClearRam",
			null
		},
		{
			"TasksHostServices",
			string_0 + "\\System32"
		},
		{
			"spoolsv",
			string_0 + "\\SpeechsTracing"
		}
	};

	private static string[] string_2 = new string[4]
	{
		"SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce",
		"SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"
	};

	private static string[,] string_3 = new string[3, 3]
	{
		{
			"explorer",
			string_0,
			"explorer"
		},
		{
			"svchost",
			string_0 + "\\System32",
			"svchost"
		},
		{
			"spoolsv",
			string_0 + "\\System32",
			"spoolsv"
		}
	};

	private static Struct22[] struct22_0 = null;

	private bool bool_3 = false;

	private static int int_0 = 0;

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private Label label1;

	private Button buttonTieudiet;

	private Button buttonClose;

	private Label label2;

	private LinkLabel linkLabelTaiBKAV;

	private TextBox textBox1;

	private ColumnHeader columnHeader_2;

	private Button buttonMothumuc;

	private RichTextBox richTextBox1;

	private CheckBox checkBoxKhongHienCanhbao;

	public static void smethod_0()
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		do
		{
			if (Class11.bool_0)
			{
				return;
			}
			num2 = DateTime.Now.Ticks;
			if (num == 0L)
			{
				num = num2;
			}
			else
			{
				num3 = num2 - num;
				num = num2;
				if (num4 < num3)
				{
					num4 = num3;
				}
			}
			Thread.Sleep(10);
		}
		while (!GClass1.bool_0 || num4 == 0L || Class11.uint_1 == 0 || Class11.int_1 <= 0);
		int int_ = 0;
		byte[] byte_ = new byte[1]
		{
			Convert.ToByte(num2 > 0L && num > 0L && num4 > 0L && num4 < 10500000L)
		};
		Class20.WriteProcessMemory(Class11.int_1, Class11.uint_1, byte_, 1, ref int_);
	}

	public static void smethod_1()
	{
		for (int i = 0; string_1.GetLength(0) > i; i++)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName(string_1[i, 0]);
				if (processesByName != null && processesByName.Length > 0)
				{
					if (string_1[i, 1] != null && !(string_1[i, 1] == string.Empty))
					{
						string b = string_1[i, 1].ToLower();
						for (int j = 0; j < processesByName.Length; j++)
						{
							string text = string.Empty;
							try
							{
								uint uint_ = 256u;
								StringBuilder stringBuilder = new StringBuilder(256);
								text = ((Class20.QueryFullProcessImageName(processesByName[j].Handle, 0u, stringBuilder, out uint_) != 0) ? stringBuilder.ToString() : processesByName[j].MainModule.FileName);
							}
							catch
							{
							}
							if (text != null && !(text == string.Empty))
							{
								string[] array = Class11.smethod_15(text);
								if (array[0].ToLower() == b)
								{
									Class20.smethod_43(processesByName[j]);
								}
							}
						}
					}
					else
					{
						for (int j = 0; j < processesByName.Length; j++)
						{
							Class20.smethod_43(processesByName[j]);
						}
					}
				}
			}
			catch
			{
			}
		}
	}

	public static void smethod_2()
	{
		int num = 60000;
		long long_ = Class11.smethod_22();
		int num2 = 0;
		while (!Class11.bool_0)
		{
			Thread.Sleep(800);
			if (FormMain.int_65 <= 0)
			{
				continue;
			}
			if (num2 > 2)
			{
				num2 = 0;
				smethod_1();
			}
			if (Class11.smethod_23(long_) < num)
			{
				continue;
			}
			num2++;
			long_ = Class11.smethod_22();
			for (int i = 0; string_3.GetLength(0) > i; i++)
			{
				Thread.Sleep(300);
				Process[] processesByName = Process.GetProcessesByName(string_3[i, 0]);
				if (processesByName == null || processesByName.Length <= 0)
				{
					continue;
				}
				string b = string_3[i, 1].ToLower();
				for (int j = 0; j < processesByName.Length; j++)
				{
					string text = string.Empty;
					try
					{
						uint uint_ = 256u;
						StringBuilder stringBuilder = new StringBuilder(256);
						text = ((Class20.QueryFullProcessImageName(processesByName[j].Handle, 0u, stringBuilder, out uint_) == 0) ? processesByName[j].MainModule.FileName : stringBuilder.ToString());
					}
					catch
					{
					}
					if (text == null || text == string.Empty)
					{
						continue;
					}
					string[] array = Class11.smethod_15(text);
					if (!(array[0].ToLower() != b))
					{
						continue;
					}
					if (struct22_0 == null)
					{
						struct22_0 = new Struct22[1]
						{
							new Struct22
							{
								process_0 = processesByName[j],
								string_0 = text,
								string_1 = string_3[i, 2]
							}
						};
						continue;
					}
					bool flag = false;
					for (int k = 0; k < struct22_0.Length; k++)
					{
						if (struct22_0[k].process_0.Id == processesByName[j].Id)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						Array.Resize(ref struct22_0, struct22_0.Length + 1);
						struct22_0[struct22_0.Length - 1].process_0 = processesByName[j];
						struct22_0[struct22_0.Length - 1].string_0 = text;
						struct22_0[struct22_0.Length - 1].string_1 = string_3[i, 2];
					}
				}
			}
			if (struct22_0 == null || struct22_0.Length <= 0)
			{
				continue;
			}
			for (int k = 0; k < 2; k++)
			{
				for (int l = 0; l < struct22_0.Length; l++)
				{
					try
					{
						Class20.smethod_43(struct22_0[l].process_0);
					}
					catch
					{
					}
				}
				Thread.Sleep(100);
			}
			bool_2 = !bool_1;
		}
	}

	public FormAntivirus()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void FormAntivirus_Load(object sender, EventArgs e)
	{
		if (struct22_0 != null)
		{
			for (int i = 0; i < struct22_0.Length; i++)
			{
				try
				{
					method_0(struct22_0[i].process_0.Id, struct22_0[i].string_0);
				}
				catch
				{
				}
			}
			bool_3 = true;
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
		bool_2 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
			return;
		}
		if (int_0 > 1)
		{
			buttonTieudiet.Enabled = true;
			int_0 = 0;
			bool_3 = true;
		}
		if (!bool_3 || listView1.Items == null)
		{
			return;
		}
		bool_3 = false;
		for (int num = 0; num < listView1.Items.Count; num++)
		{
			string text = "Hoạt động";
			string text2 = text;
			if (struct22_0 != null && struct22_0.Length > 0)
			{
				int num2 = Class11.smethod_12(listView1.Items[num].SubItems[0].Text);
				for (int i = 0; i < struct22_0.Length; i++)
				{
					try
					{
						if (num2 == struct22_0[i].process_0.Id)
						{
							struct22_0[i].process_0 = Process.GetProcessById(struct22_0[i].process_0.Id);
							if (!Class20.smethod_52(struct22_0[i].process_0))
							{
								if (struct22_0[i].process_0.Threads[0].WaitReason == ThreadWaitReason.Suspended)
								{
									text2 = "Tạm ngưng";
								}
							}
							else
							{
								text2 = "Đã thoát";
							}
							goto IL_0181;
						}
					}
					catch
					{
						text2 = "Đã thoát";
					}
				}
			}
			goto IL_0181;
			IL_0181:
			listView1.Items[num].SubItems[2].Text = text2;
			if (text2 != text)
			{
				listView1.Items[num].ForeColor = Color.DarkGray;
			}
		}
	}

	private void method_0(int int_1, string string_4)
	{
		string[] array = new string[3]
		{
			int_1.ToString(),
			string_4,
			"Hoạt động"
		};
		ListViewItem listViewItem = new ListViewItem(array[0]);
		if (array.Length > 1)
		{
			for (int i = 1; i < array.Length; i++)
			{
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
				listViewItem.SubItems.Add(item);
			}
		}
		listView1.Items.Add(listViewItem);
	}

	private void linkLabelTaiBKAV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "http://www.bkav.com.vn/download";
		Class20.smethod_40(Class55.smethod_0(), "", text, 0);
	}

	private void buttonTieudiet_Click(object sender, EventArgs e)
	{
		if (int_0 <= 0)
		{
			buttonTieudiet.Enabled = false;
			new Thread(method_1).Start();
		}
	}

	private void method_1()
	{
		if (struct22_0 != null && struct22_0.Length > 0)
		{
			int_0 = 1;
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < struct22_0.Length; j++)
				{
					try
					{
						Class20.smethod_43(struct22_0[j].process_0);
					}
					catch
					{
					}
				}
			}
			Random random = new Random();
			for (int i = 0; i < struct22_0.Length; i++)
			{
				try
				{
					int num = 0;
					string text = struct22_0[i].string_0;
					string str = random.Next(10000, 1000000).ToString();
					while (Class11.smethod_18(text) && num <= 20)
					{
						if (num % 10 == 0)
						{
							Class11.smethod_19(text, text + "." + str);
						}
						num++;
						Thread.Sleep(300);
					}
				}
				catch
				{
				}
			}
			for (int i = 0; i < struct22_0.Length; i++)
			{
				try
				{
					Class20.smethod_53(struct22_0[i].process_0);
				}
				catch
				{
				}
			}
			for (int i = 0; i < struct22_0.Length; i++)
			{
				try
				{
					if (struct22_0[i].string_1 != null && struct22_0[i].string_1 != string.Empty)
					{
						for (int j = 0; j < string_2.GetLength(0); j++)
						{
							Class55.smethod_12(string_2[j], struct22_0[i].string_1, 0);
							Class55.smethod_12(string_2[j], struct22_0[i].string_1, 1);
						}
					}
				}
				catch
				{
				}
			}
			int_0 = 2;
		}
		else
		{
			int_0 = 0;
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void buttonMothumuc_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				string[] array = Class11.smethod_15(listView1.Items[i].SubItems[1].Text);
				Class20.smethod_40(string_0 + "\\explorer.exe", array[0], array[0], 0);
				return;
			}
		}
		if (struct22_0 != null && struct22_0.Length > 0)
		{
			for (int i = 0; i < struct22_0.Length; i++)
			{
				try
				{
					string[] array = Class11.smethod_15(struct22_0[i].string_0);
					Class20.smethod_40(string_0 + "\\explorer.exe", array[0], array[0], 0);
				}
				catch
				{
				}
			}
		}
	}

	private void checkBoxKhongHienCanhbao_CheckedChanged(object sender, EventArgs e)
	{
		bool_1 = checkBoxKhongHienCanhbao.Checked;
	}

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormAntivirus));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		label1 = new System.Windows.Forms.Label();
		buttonTieudiet = new System.Windows.Forms.Button();
		buttonClose = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		linkLabelTaiBKAV = new System.Windows.Forms.LinkLabel();
		textBox1 = new System.Windows.Forms.TextBox();
		buttonMothumuc = new System.Windows.Forms.Button();
		richTextBox1 = new System.Windows.Forms.RichTextBox();
		checkBoxKhongHienCanhbao = new System.Windows.Forms.CheckBox();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3]
		{
			columnHeader_0,
			columnHeader_1,
			columnHeader_2
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(4, 35);
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(435, 113);
		listView1.TabIndex = 0;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "PID";
		columnHeader_1.Text = "Tệp";
		columnHeader_1.Width = 275;
		columnHeader_2.Text = "Tình trạng";
		columnHeader_2.Width = 80;
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(3, 11);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(394, 13);
		label1.TabIndex = 1;
		label1.Text = "Cảnh báo: Danh sách dưới đây là các file có thể đã bị nhiễm keylog";
		buttonTieudiet.ForeColor = System.Drawing.Color.DarkRed;
		buttonTieudiet.Location = new System.Drawing.Point(339, 150);
		buttonTieudiet.Name = "buttonTieudiet";
		buttonTieudiet.Size = new System.Drawing.Size(100, 36);
		buttonTieudiet.TabIndex = 2;
		buttonTieudiet.Text = "Tiêu diệt";
		buttonTieudiet.UseVisualStyleBackColor = true;
		buttonTieudiet.Click += new System.EventHandler(buttonTieudiet_Click);
		buttonClose.Location = new System.Drawing.Point(339, 273);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(100, 30);
		buttonClose.TabIndex = 3;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(4, 188);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(70, 13);
		label2.TabIndex = 4;
		label2.Text = "Cách xử lý:";
		linkLabelTaiBKAV.AutoSize = true;
		linkLabelTaiBKAV.Location = new System.Drawing.Point(4, 290);
		linkLabelTaiBKAV.Name = "linkLabelTaiBKAV";
		linkLabelTaiBKAV.Size = new System.Drawing.Size(119, 13);
		linkLabelTaiBKAV.TabIndex = 5;
		linkLabelTaiBKAV.TabStop = true;
		linkLabelTaiBKAV.Text = "Tải BKAV Home tại đây";
		linkLabelTaiBKAV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelTaiBKAV_LinkClicked);
		textBox1.Location = new System.Drawing.Point(6, 258);
		textBox1.Name = "textBox1";
		textBox1.ReadOnly = true;
		textBox1.Size = new System.Drawing.Size(195, 20);
		textBox1.TabIndex = 6;
		textBox1.Text = "http://www.bkav.com.vn/download";
		buttonMothumuc.Location = new System.Drawing.Point(233, 150);
		buttonMothumuc.Name = "buttonMothumuc";
		buttonMothumuc.Size = new System.Drawing.Size(100, 36);
		buttonMothumuc.TabIndex = 7;
		buttonMothumuc.Text = "Mở thư mục có keylog";
		buttonMothumuc.UseVisualStyleBackColor = true;
		buttonMothumuc.Click += new System.EventHandler(buttonMothumuc_Click);
		richTextBox1.Location = new System.Drawing.Point(6, 212);
		richTextBox1.Name = "richTextBox1";
		richTextBox1.ReadOnly = true;
		richTextBox1.Size = new System.Drawing.Size(433, 37);
		richTextBox1.TabIndex = 8;
		richTextBox1.Text = "1. Bấm nút Tiêu diệt để tạm thời làm keylog ngưng hoạt động (chưa xóa hết keylog)\n2. Tải trình quét virus BKAV Home bên dưới về cài đặt và quét keylog.";
		checkBoxKhongHienCanhbao.AutoSize = true;
		checkBoxKhongHienCanhbao.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxKhongHienCanhbao.Location = new System.Drawing.Point(4, 160);
		checkBoxKhongHienCanhbao.Name = "checkBoxKhongHienCanhbao";
		checkBoxKhongHienCanhbao.Size = new System.Drawing.Size(196, 17);
		checkBoxKhongHienCanhbao.TabIndex = 10;
		checkBoxKhongHienCanhbao.Text = "Không hiện bảng cảnh báo này nữa";
		checkBoxKhongHienCanhbao.UseVisualStyleBackColor = true;
		checkBoxKhongHienCanhbao.CheckedChanged += new System.EventHandler(checkBoxKhongHienCanhbao_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(443, 310);
		base.Controls.Add(checkBoxKhongHienCanhbao);
		base.Controls.Add(richTextBox1);
		base.Controls.Add(buttonMothumuc);
		base.Controls.Add(textBox1);
		base.Controls.Add(linkLabelTaiBKAV);
		base.Controls.Add(label2);
		base.Controls.Add(buttonClose);
		base.Controls.Add(buttonTieudiet);
		base.Controls.Add(label1);
		base.Controls.Add(listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormAntivirus";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "KYKEOXE PHAT HIEN CO VIRUS - KEYLOG";
		base.Load += new System.EventHandler(FormAntivirus_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
