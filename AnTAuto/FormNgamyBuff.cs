using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormNgamyBuff : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private CheckBox checkBoxnttk;

	private ComboBox comboBoxNgaMyBuff;

	private Label labelPhimKethop;

	private Button buttonPhim;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static int int_4 = 0;

	public static string[] string_0 = new string[3]
	{
		"Ưu tiên buff cho ac chính",
		"Buff ac chính và ac phụ",
		"Chỉ buff cho bản thân"
	};

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormNgamyBuff));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonClose = new System.Windows.Forms.Button();
		checkBoxnttk = new System.Windows.Forms.CheckBox();
		comboBoxNgaMyBuff = new System.Windows.Forms.ComboBox();
		labelPhimKethop = new System.Windows.Forms.Label();
		buttonPhim = new System.Windows.Forms.Button();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonClose.Location = new System.Drawing.Point(156, 140);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(100, 27);
		buttonClose.TabIndex = 14;
		buttonClose.Text = "OK";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		checkBoxnttk.AutoSize = true;
		checkBoxnttk.BackColor = System.Drawing.SystemColors.Control;
		checkBoxnttk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		checkBoxnttk.ForeColor = System.Drawing.Color.Black;
		checkBoxnttk.Location = new System.Drawing.Point(12, 39);
		checkBoxnttk.Name = "checkBoxnttk";
		checkBoxnttk.Size = new System.Drawing.Size(180, 17);
		checkBoxnttk.TabIndex = 335;
		checkBoxnttk.Text = "Buff chiêu Ngọc Tuyền Tâm Kinh";
		checkBoxnttk.UseVisualStyleBackColor = false;
		checkBoxnttk.CheckedChanged += new System.EventHandler(checkBoxnttk_CheckedChanged);
		comboBoxNgaMyBuff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxNgaMyBuff.DropDownWidth = 120;
		comboBoxNgaMyBuff.ForeColor = System.Drawing.Color.Black;
		comboBoxNgaMyBuff.FormattingEnabled = true;
		comboBoxNgaMyBuff.Location = new System.Drawing.Point(12, 12);
		comboBoxNgaMyBuff.Name = "comboBoxNgaMyBuff";
		comboBoxNgaMyBuff.Size = new System.Drawing.Size(260, 21);
		comboBoxNgaMyBuff.TabIndex = 339;
		comboBoxNgaMyBuff.SelectedIndexChanged += new System.EventHandler(comboBoxNgaMyBuff_SelectedIndexChanged);
		labelPhimKethop.Enabled = false;
		labelPhimKethop.ForeColor = System.Drawing.Color.MediumBlue;
		labelPhimKethop.Location = new System.Drawing.Point(12, 65);
		labelPhimKethop.Name = "labelPhimKethop";
		labelPhimKethop.Size = new System.Drawing.Size(260, 72);
		labelPhimKethop.TabIndex = 340;
		labelPhimKethop.Text = "Lưu ý: Game phải ở chế độ Phím Kết Hợp thì mới sử dụng được chiêu Ngọc Tuyền Tâm Kinh.\r\n\r\nCách thiết lập phím kết hợp trong game:\r\nBấm Esc -> Tùy chọn hệ thống -> Phím kết hợp";
		buttonPhim.Location = new System.Drawing.Point(12, 140);
		buttonPhim.Name = "buttonPhim";
		buttonPhim.Size = new System.Drawing.Size(128, 27);
		buttonPhim.TabIndex = 341;
		buttonPhim.Text = "Phim Hướng dẫn";
		buttonPhim.UseVisualStyleBackColor = true;
		buttonPhim.Click += new System.EventHandler(buttonPhim_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(281, 179);
		base.Controls.Add(buttonPhim);
		base.Controls.Add(labelPhimKethop);
		base.Controls.Add(comboBoxNgaMyBuff);
		base.Controls.Add(checkBoxnttk);
		base.Controls.Add(buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormNgamyBuff";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "NGA MY BUFF";
		base.Load += new System.EventHandler(FormNgamyBuff_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormNgamyBuff()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormNgamyBuff_Load(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			Close();
			return;
		}
		GStruct42 gStruct = FormMain.gstruct42_0[num];
		if (int_0 > 0 && int_1 > 0)
		{
			int num2 = int_0 - base.Width - 10;
			int num3 = int_1 - base.Height - 10;
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			SetBounds(num2, num3, base.Width, base.Height);
		}
		for (int i = 0; i < string_0.Length; i++)
		{
			comboBoxNgaMyBuff.Items.Add(string_0[i]);
		}
		comboBoxNgaMyBuff.Text = string_0[gStruct.int_97[2]];
		checkBoxnttk.Checked = (gStruct.int_97[6] > 0);
		labelPhimKethop.Enabled = (gStruct.int_97[6] > 0);
		Thread.Sleep(100);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Class11.bool_0 || !bool_0)
		{
			Close();
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	private void checkBoxnttk_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num >= 0)
		{
			GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
			int num2 = 0;
			int num3 = 0;
			labelPhimKethop.Enabled = checkBoxnttk.Checked;
			if (checkBoxnttk.Checked)
			{
				num2 = 1114 * Convert.ToByte(Class67.smethod_15(gstruct42_, 1114u) > 0);
				num3 = 470;
			}
			if (num2 == 0)
			{
				num2 = 93 * Convert.ToByte(Class67.smethod_15(gstruct42_, 93u) > 0);
				num3 = 400;
			}
			FormMain.gstruct42_0[num].int_97[6] = Convert.ToByte(checkBoxnttk.Checked);
			FormMain.gstruct42_0[num].int_97[1] = num2;
			FormMain.gstruct42_0[num].int_97[5] = num3;
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
		else
		{
			Close();
		}
	}

	private void comboBoxNgaMyBuff_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_4);
		if (num < 0)
		{
			Close();
			return;
		}
		string text = comboBoxNgaMyBuff.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (text == string_0[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		FormMain.gstruct42_0[num].int_97[2] = num2;
		Class47.smethod_11(FormMain.gstruct42_0[num]);
	}

	private void buttonPhim_Click(object sender, EventArgs e)
	{
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(string_))
		{
			string_ = Class55.smethod_0();
		}
		Class20.smethod_40(string_, "", "https://youtu.be/ngCGdG4dYAI", 0);
	}
}
