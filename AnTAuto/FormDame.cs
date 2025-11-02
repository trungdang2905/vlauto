using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormDame : Form
{
	private IContainer icontainer_0 = null;

	private CheckBox checkBoxSkill1;

	private CheckBox checkBoxSkill2;

	private System.Windows.Forms.Timer timer_0;

	private ComboBox comboBoxKieudanh;

	private Label label1;

	private Button buttonClose;

	private CheckBox checkBoxTuDanhbinhthuong;

	private ComboBox comboBoxSkill1;

	private ComboBox comboBoxSkill2;

	private Label label4;

	private CheckBox checkBoxSudungChieu12;

	private ComboBox comboBoxTenAc;

	private GroupBox groupBox1;

	private Label label3;

	private CheckBox checkBoxAllwayAttack;

	private Label label2;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static int int_4 = 0;

	public static int int_5 = Class55.smethod_3("IdexKieudanh", 0, "1");

	public static int int_6 = Class55.smethod_3("flagDameMacdinh", 0, "0");

	public static int int_7 = Class55.smethod_3("AllwayAttack", 0, "0");

	public static int int_8 = Class55.smethod_3("SwicthDame", 0, "1");

	private static string[] string_0 = new string[3]
	{
		"1. Tự động đánh vào vị trí chuột",
		"2. Bấm và giữ phím tắt - Đánh vào vị trí chuột",
		"3. Bấm và giữ phím tắt - Tự động quét tìm đánh đối thủ"
	};

	private static int int_9 = 0;

	private static bool bool_1 = false;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormDame));
		checkBoxSkill1 = new System.Windows.Forms.CheckBox();
		checkBoxSkill2 = new System.Windows.Forms.CheckBox();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		comboBoxKieudanh = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		buttonClose = new System.Windows.Forms.Button();
		checkBoxTuDanhbinhthuong = new System.Windows.Forms.CheckBox();
		comboBoxSkill1 = new System.Windows.Forms.ComboBox();
		comboBoxSkill2 = new System.Windows.Forms.ComboBox();
		label4 = new System.Windows.Forms.Label();
		checkBoxSudungChieu12 = new System.Windows.Forms.CheckBox();
		comboBoxTenAc = new System.Windows.Forms.ComboBox();
		groupBox1 = new System.Windows.Forms.GroupBox();
		label3 = new System.Windows.Forms.Label();
		checkBoxAllwayAttack = new System.Windows.Forms.CheckBox();
		label2 = new System.Windows.Forms.Label();
		groupBox1.SuspendLayout();
		SuspendLayout();
		checkBoxSkill1.AutoSize = true;
		checkBoxSkill1.Location = new System.Drawing.Point(154, 24);
		checkBoxSkill1.Name = "checkBoxSkill1";
		checkBoxSkill1.Size = new System.Drawing.Size(68, 17);
		checkBoxSkill1.TabIndex = 0;
		checkBoxSkill1.Text = "Chiêu (1)";
		checkBoxSkill1.UseVisualStyleBackColor = true;
		checkBoxSkill1.CheckedChanged += new System.EventHandler(checkBoxSkill1_CheckedChanged);
		checkBoxSkill2.AutoSize = true;
		checkBoxSkill2.Location = new System.Drawing.Point(154, 46);
		checkBoxSkill2.Name = "checkBoxSkill2";
		checkBoxSkill2.Size = new System.Drawing.Size(68, 17);
		checkBoxSkill2.TabIndex = 1;
		checkBoxSkill2.Text = "Chiêu (2)";
		checkBoxSkill2.UseVisualStyleBackColor = true;
		checkBoxSkill2.CheckedChanged += new System.EventHandler(checkBoxSkill2_CheckedChanged);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		comboBoxKieudanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxKieudanh.FormattingEnabled = true;
		comboBoxKieudanh.Location = new System.Drawing.Point(10, 239);
		comboBoxKieudanh.Name = "comboBoxKieudanh";
		comboBoxKieudanh.Size = new System.Drawing.Size(291, 21);
		comboBoxKieudanh.TabIndex = 325;
		comboBoxKieudanh.SelectedIndexChanged += new System.EventHandler(comboBoxKieudanh_SelectedIndexChanged);
		label1.AutoSize = true;
		label1.ForeColor = System.Drawing.Color.Black;
		label1.Location = new System.Drawing.Point(317, 223);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(47, 13);
		label1.TabIndex = 326;
		label1.Text = "Phím tắt";
		buttonClose.Location = new System.Drawing.Point(320, 301);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(75, 23);
		buttonClose.TabIndex = 8;
		buttonClose.Text = "OK";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		checkBoxTuDanhbinhthuong.AutoSize = true;
		checkBoxTuDanhbinhthuong.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxTuDanhbinhthuong.Location = new System.Drawing.Point(10, 266);
		checkBoxTuDanhbinhthuong.Name = "checkBoxTuDanhbinhthuong";
		checkBoxTuDanhbinhthuong.Size = new System.Drawing.Size(318, 17);
		checkBoxTuDanhbinhthuong.TabIndex = 329;
		checkBoxTuDanhbinhthuong.Text = "Tự động chuyển sang đánh bình thường khi không bấm phím";
		checkBoxTuDanhbinhthuong.UseVisualStyleBackColor = true;
		checkBoxTuDanhbinhthuong.CheckedChanged += new System.EventHandler(checkBoxTuDanhbinhthuong_CheckedChanged);
		comboBoxSkill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxSkill1.ForeColor = System.Drawing.Color.Black;
		comboBoxSkill1.FormattingEnabled = true;
		comboBoxSkill1.Location = new System.Drawing.Point(224, 21);
		comboBoxSkill1.Name = "comboBoxSkill1";
		comboBoxSkill1.Size = new System.Drawing.Size(146, 21);
		comboBoxSkill1.TabIndex = 350;
		comboBoxSkill1.SelectedIndexChanged += new System.EventHandler(comboBoxSkill1_SelectedIndexChanged);
		comboBoxSkill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxSkill2.ForeColor = System.Drawing.Color.Black;
		comboBoxSkill2.FormattingEnabled = true;
		comboBoxSkill2.Location = new System.Drawing.Point(224, 45);
		comboBoxSkill2.Name = "comboBoxSkill2";
		comboBoxSkill2.Size = new System.Drawing.Size(146, 21);
		comboBoxSkill2.TabIndex = 351;
		comboBoxSkill2.SelectedIndexChanged += new System.EventHandler(comboBoxSkill2_SelectedIndexChanged);
		label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		label4.Location = new System.Drawing.Point(8, 2);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(388, 107);
		label4.TabIndex = 0;
		//label4.Text = componentResourceManager.GetString("label4.Text");
		label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		checkBoxSudungChieu12.AutoSize = true;
		checkBoxSudungChieu12.ForeColor = System.Drawing.Color.DarkBlue;
		checkBoxSudungChieu12.Location = new System.Drawing.Point(15, 25);
		checkBoxSudungChieu12.Name = "checkBoxSudungChieu12";
		checkBoxSudungChieu12.Size = new System.Drawing.Size(128, 17);
		checkBoxSudungChieu12.TabIndex = 352;
		checkBoxSudungChieu12.Text = "Sử dụng chiêu 1 và 2";
		checkBoxSudungChieu12.UseVisualStyleBackColor = true;
		checkBoxSudungChieu12.CheckedChanged += new System.EventHandler(checkBoxSudungChieu12_CheckedChanged);
		comboBoxTenAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxTenAc.ForeColor = System.Drawing.Color.Black;
		comboBoxTenAc.FormattingEnabled = true;
		comboBoxTenAc.Location = new System.Drawing.Point(15, 48);
		comboBoxTenAc.Name = "comboBoxTenAc";
		comboBoxTenAc.Size = new System.Drawing.Size(117, 21);
		comboBoxTenAc.TabIndex = 353;
		comboBoxTenAc.SelectedIndexChanged += new System.EventHandler(comboBoxTenAc_SelectedIndexChanged);
		groupBox1.Controls.Add(comboBoxTenAc);
		groupBox1.Controls.Add(checkBoxSudungChieu12);
		groupBox1.Controls.Add(comboBoxSkill2);
		groupBox1.Controls.Add(comboBoxSkill1);
		groupBox1.Controls.Add(checkBoxSkill2);
		groupBox1.Controls.Add(checkBoxSkill1);
		groupBox1.Location = new System.Drawing.Point(8, 120);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(388, 86);
		groupBox1.TabIndex = 355;
		groupBox1.TabStop = false;
		groupBox1.Text = "Tùy chọn chiêu đánh";
		label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		label3.Location = new System.Drawing.Point(320, 241);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(75, 18);
		label3.TabIndex = 356;
		label3.Text = "SPACE";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		checkBoxAllwayAttack.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxAllwayAttack.Location = new System.Drawing.Point(10, 289);
		checkBoxAllwayAttack.Name = "checkBoxAllwayAttack";
		checkBoxAllwayAttack.Size = new System.Drawing.Size(304, 35);
		checkBoxAllwayAttack.TabIndex = 357;
		checkBoxAllwayAttack.Text = "Không stick vào đánh người, đánh quái và đánh boss nhưng vẫn dame được";
		checkBoxAllwayAttack.UseVisualStyleBackColor = true;
		checkBoxAllwayAttack.CheckedChanged += new System.EventHandler(checkBoxAllwayAttack_CheckedChanged);
		label2.AutoSize = true;
		label2.ForeColor = System.Drawing.Color.Black;
		label2.Location = new System.Drawing.Point(8, 223);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(56, 13);
		label2.TabIndex = 358;
		label2.Text = "Kiểu đánh";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(403, 333);
		base.Controls.Add(label2);
		base.Controls.Add(checkBoxAllwayAttack);
		base.Controls.Add(label3);
		base.Controls.Add(groupBox1);
		base.Controls.Add(label4);
		base.Controls.Add(buttonClose);
		base.Controls.Add(label1);
		base.Controls.Add(comboBoxKieudanh);
		base.Controls.Add(checkBoxTuDanhbinhthuong);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormDame";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Dame ket hop";
		base.Load += new System.EventHandler(FormDame_Load);
		groupBox1.ResumeLayout(performLayout: false);
		groupBox1.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormDame()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int_0 = 0;
		int_1 = 0;
		bool_0 = false;
	}

	private bool method_0(GStruct36[] gstruct36_0)
	{
		comboBoxSkill1.Items.Clear();
		comboBoxSkill2.Items.Clear();
		if (gstruct36_0 == null)
		{
			return false;
		}
		for (int i = 0; i < gstruct36_0.Length; i++)
		{
			comboBoxSkill1.Items.Add(gstruct36_0[i].string_0);
			comboBoxSkill2.Items.Add(gstruct36_0[i].string_0);
		}
		return true;
	}

	private string method_1(GStruct36[] gstruct36_0, int int_10)
	{
		if (int_10 > 0 && gstruct36_0 != null)
		{
			for (int i = 0; i < gstruct36_0.Length; i++)
			{
				if (gstruct36_0[i].int_1 == int_10)
				{
					return gstruct36_0[i].string_0;
				}
			}
		}
		return string.Empty;
	}

	private void FormDame_Load(object sender, EventArgs e)
	{
		int_9 = int_4;
		bool_1 = false;
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
		comboBoxTenAc.Items.Clear();
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				comboBoxTenAc.Items.Add(Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1));
			}
		}
		bool enabled = false;
		int num3 = Class71.smethod_3(FormMain.gstruct42_0, int_9);
		if (0 <= num3)
		{
			GStruct42 gstruct42_ = FormMain.gstruct42_0[num3];
			comboBoxTenAc.Text = Class10.smethod_1(FormMain.gstruct42_0[num3].string_20, 1);
			GStruct36[] gstruct36_ = Class67.smethod_16(gstruct42_);
			method_0(gstruct36_);
			checkBoxSudungChieu12.Checked = (gstruct42_.int_121[0] > 0);
			checkBoxSkill1.Checked = (gstruct42_.int_121[1] > 0);
			comboBoxSkill1.Text = method_1(gstruct36_, gstruct42_.int_121[2]);
			checkBoxSkill2.Checked = (gstruct42_.int_121[3] > 0);
			comboBoxSkill2.Text = method_1(gstruct36_, gstruct42_.int_121[4]);
			enabled = (gstruct42_.int_121[0] > 0);
		}
		checkBoxSkill1.Enabled = enabled;
		checkBoxSkill2.Enabled = enabled;
		comboBoxSkill1.Enabled = enabled;
		comboBoxSkill2.Enabled = enabled;
		for (int i = 0; i < string_0.Length; i++)
		{
			comboBoxKieudanh.Items.Add(string_0[i]);
		}
		comboBoxKieudanh.Text = string_0[int_5];
		checkBoxTuDanhbinhthuong.Checked = (int_8 > 0);
		checkBoxTuDanhbinhthuong.Enabled = (int_5 == 1);
		checkBoxAllwayAttack.Checked = (int_7 > 0);
		base.TopMost = true;
		Thread.Sleep(60);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void comboBoxKieudanh_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = comboBoxKieudanh.Text;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (text == string_0[i])
			{
				int_5 = i;
				break;
			}
		}
		Class55.smethod_10(Class47.string_0, "IdexKieudanh", int_5, "", 0);
		checkBoxTuDanhbinhthuong.Enabled = (int_5 == 1);
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxTuDanhbinhthuong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_8 = Convert.ToByte(checkBoxTuDanhbinhthuong.Checked);
			Class55.smethod_10(Class47.string_0, "SwicthDame", int_8, "", 0);
		}
	}

	private void comboBoxTenAc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int_9 = -1;
		string text = comboBoxTenAc.Text;
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				if (text == Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1))
				{
					int_9 = FormMain.gstruct42_0[i].int_129;
					break;
				}
			}
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_9);
		if (num >= 0)
		{
			GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
			bool_1 = false;
			GStruct36[] gstruct36_ = Class67.smethod_16(gstruct42_);
			method_0(gstruct36_);
			checkBoxSudungChieu12.Checked = (gstruct42_.int_121[0] > 0);
			checkBoxSkill1.Checked = (gstruct42_.int_121[1] > 0);
			comboBoxSkill1.Text = method_1(gstruct36_, gstruct42_.int_121[2]);
			checkBoxSkill2.Checked = (gstruct42_.int_121[3] > 0);
			comboBoxSkill2.Text = method_1(gstruct36_, gstruct42_.int_121[4]);
			checkBoxSkill1.Enabled = (gstruct42_.int_121[0] > 0);
			checkBoxSkill2.Enabled = (gstruct42_.int_121[0] > 0);
			comboBoxSkill1.Enabled = (gstruct42_.int_121[0] > 0);
			comboBoxSkill2.Enabled = (gstruct42_.int_121[0] > 0);
			Thread.Sleep(60);
			bool_1 = true;
		}
	}

	private void checkBoxSudungChieu12_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_9);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_121[0] = Convert.ToByte(checkBoxSudungChieu12.Checked);
				GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
				Class47.smethod_11(gstruct42_);
				checkBoxSkill1.Enabled = (gstruct42_.int_121[0] > 0);
				checkBoxSkill2.Enabled = (gstruct42_.int_121[0] > 0);
				comboBoxSkill1.Enabled = (gstruct42_.int_121[0] > 0);
				comboBoxSkill2.Enabled = (gstruct42_.int_121[0] > 0);
			}
		}
	}

	private void checkBoxSkill1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_9);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_121[1] = Convert.ToByte(checkBoxSkill1.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxSkill2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_9);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_121[3] = Convert.ToByte(checkBoxSkill2.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void comboBoxSkill1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_9);
		if (num < 0)
		{
			return;
		}
		GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
		GStruct36[] array = Class67.smethod_16(gstruct42_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxSkill1.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class71.smethod_3(FormMain.gstruct42_0, int_9);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].int_121[2] = num2;
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
	}

	private void comboBoxSkill2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_9);
		if (num < 0)
		{
			return;
		}
		GStruct42 gstruct42_ = FormMain.gstruct42_0[num];
		GStruct36[] array = Class67.smethod_16(gstruct42_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxSkill2.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class71.smethod_3(FormMain.gstruct42_0, int_9);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].int_121[4] = num2;
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
	}

	private void checkBoxAllwayAttack_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_7 = Convert.ToByte(checkBoxAllwayAttack.Checked);
			Class55.smethod_10(Class47.string_0, "AllwayAttack", int_7, "", 0);
		}
	}
}
