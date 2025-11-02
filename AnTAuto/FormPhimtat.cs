using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormPhimtat : Form
{
	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Button buttonClose;

	private Label label1;

	private Label label2;

	private ComboBox comboBoxKieuPhimtat;

	private Button buttonGanPhimALL;

	private CheckBox checkBoxLuonGanKetHop;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	private static string[] string_0 = new string[2]
	{
		"Mặc định",
		"Kết hợp"
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormPhimtat));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonClose = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		comboBoxKieuPhimtat = new System.Windows.Forms.ComboBox();
		buttonGanPhimALL = new System.Windows.Forms.Button();
		checkBoxLuonGanKetHop = new System.Windows.Forms.CheckBox();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonClose.Location = new System.Drawing.Point(353, 475);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(69, 23);
		buttonClose.TabIndex = 14;
		buttonClose.Text = "OK";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		label1.Location = new System.Drawing.Point(6, 3);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(416, 410);
		label1.TabIndex = 15;
		//label1.Text = componentResourceManager.GetString("label1.Text");
		label2.AutoSize = true;
		label2.ForeColor = System.Drawing.Color.Red;
		label2.Location = new System.Drawing.Point(5, 421);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(334, 13);
		label2.TabIndex = 16;
		label2.Text = "Yêu cầu chung: phải check vào mục [v] Sử dụng phím tắt (ở phụ trợ)";
		comboBoxKieuPhimtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxKieuPhimtat.DropDownWidth = 100;
		comboBoxKieuPhimtat.FormattingEnabled = true;
		comboBoxKieuPhimtat.Location = new System.Drawing.Point(27, 476);
		comboBoxKieuPhimtat.Name = "comboBoxKieuPhimtat";
		comboBoxKieuPhimtat.Size = new System.Drawing.Size(98, 21);
		comboBoxKieuPhimtat.TabIndex = 465;
		comboBoxKieuPhimtat.SelectedIndexChanged += new System.EventHandler(comboBoxKieuPhimtat_SelectedIndexChanged);
		buttonGanPhimALL.BackColor = System.Drawing.SystemColors.Control;
		buttonGanPhimALL.ForeColor = System.Drawing.Color.DarkRed;
		buttonGanPhimALL.Location = new System.Drawing.Point(131, 475);
		buttonGanPhimALL.Name = "buttonGanPhimALL";
		buttonGanPhimALL.Size = new System.Drawing.Size(139, 23);
		buttonGanPhimALL.TabIndex = 467;
		buttonGanPhimALL.Text = "Gán lại cho tất cả ac";
		buttonGanPhimALL.UseVisualStyleBackColor = false;
		buttonGanPhimALL.Click += new System.EventHandler(buttonGanPhimALL_Click);
		checkBoxLuonGanKetHop.AutoSize = true;
		checkBoxLuonGanKetHop.ForeColor = System.Drawing.Color.Black;
		checkBoxLuonGanKetHop.Location = new System.Drawing.Point(8, 452);
		checkBoxLuonGanKetHop.Name = "checkBoxLuonGanKetHop";
		checkBoxLuonGanKetHop.Size = new System.Drawing.Size(330, 17);
		checkBoxLuonGanKetHop.TabIndex = 466;
		checkBoxLuonGanKetHop.Text = "Luôn gán phím tắt (bấm esc -> tùy chọn hệ thống) trong game là";
		checkBoxLuonGanKetHop.UseVisualStyleBackColor = true;
		checkBoxLuonGanKetHop.CheckedChanged += new System.EventHandler(checkBoxLuonGanKetHop_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(430, 510);
		base.Controls.Add(comboBoxKieuPhimtat);
		base.Controls.Add(buttonGanPhimALL);
		base.Controls.Add(checkBoxLuonGanKetHop);
		base.Controls.Add(label2);
		base.Controls.Add(buttonClose);
		base.Controls.Add(label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormPhimtat";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "PHIM TAT";
		base.Load += new System.EventHandler(FormPhimtat_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormPhimtat()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormPhimtat_Load(object sender, EventArgs e)
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
		for (int i = 0; i < string_0.Length; i++)
		{
			comboBoxKieuPhimtat.Items.Add(string_0[i]);
		}
		comboBoxKieuPhimtat.Text = string_0[FormMain.int_18];
		checkBoxLuonGanKetHop.Checked = (FormMain.int_17 > 0);
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

	private void checkBoxLuonGanKetHop_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			FormMain.int_17 = Convert.ToByte(checkBoxLuonGanKetHop.Checked);
			Class55.smethod_10(Class47.string_0, "flagLuonGanPhimtat", FormMain.int_17, "", 0);
		}
	}

	private void comboBoxKieuPhimtat_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = comboBoxKieuPhimtat.Text;
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (text == string_0[num])
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		FormMain.int_18 = num;
		Class55.smethod_10(Class47.string_0, "flagKieuPhimTat", FormMain.int_18, "", 0);
	}

	private void buttonGanPhimALL_Click(object sender, EventArgs e)
	{
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				Class60.smethod_14(FormMain.gstruct42_0[i], FormMain.int_18 > 0);
			}
		}
	}
}
