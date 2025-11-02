using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormAchinh : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private ComboBox comboBoxAc;

	private CheckBox checkBoxBamPhim;

	private Label label1;

	private Label label2;

	private Label label3;

	public static string string_0 = Class11.smethod_16(Class55.smethod_6("AccChinh2", 0));

	public static int int_0 = Class55.smethod_3("flagPhim2", 0, "0");

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public static bool bool_0 = false;

	private bool bool_1 = false;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormAchinh));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonClose = new System.Windows.Forms.Button();
		comboBoxAc = new System.Windows.Forms.ComboBox();
		checkBoxBamPhim = new System.Windows.Forms.CheckBox();
		label1 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonClose.Location = new System.Drawing.Point(109, 121);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(117, 27);
		buttonClose.TabIndex = 14;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		comboBoxAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxAc.FormattingEnabled = true;
		comboBoxAc.Location = new System.Drawing.Point(109, 6);
		comboBoxAc.Name = "comboBoxAc";
		comboBoxAc.Size = new System.Drawing.Size(117, 21);
		comboBoxAc.TabIndex = 20;
		comboBoxAc.SelectedIndexChanged += new System.EventHandler(comboBoxAc_SelectedIndexChanged);
		comboBoxAc.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxAc_MouseDown);
		checkBoxBamPhim.AutoSize = true;
		checkBoxBamPhim.Location = new System.Drawing.Point(7, 38);
		checkBoxBamPhim.Name = "checkBoxBamPhim";
		checkBoxBamPhim.Size = new System.Drawing.Size(155, 17);
		checkBoxBamPhim.TabIndex = 23;
		checkBoxBamPhim.Text = "Đổi ac chính khi bấm phím";
		checkBoxBamPhim.UseVisualStyleBackColor = true;
		checkBoxBamPhim.CheckedChanged += new System.EventHandler(checkBoxBamPhim_CheckedChanged);
		label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(168, 35);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(58, 20);
		label1.TabIndex = 24;
		label1.Text = "F2";
		label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(3, 9);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(99, 13);
		label2.TabIndex = 25;
		label2.Text = "Ac chính dự phòng";
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(3, 68);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(218, 13);
		label3.TabIndex = 26;
		label3.Text = "Lưu ý: check vào sử dụng phím tắt ở phụ trợ";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(234, 160);
		base.Controls.Add(label3);
		base.Controls.Add(label2);
		base.Controls.Add(label1);
		base.Controls.Add(checkBoxBamPhim);
		base.Controls.Add(comboBoxAc);
		base.Controls.Add(buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormAchinh";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "AC_CHINH_DU_PHONG";
		base.Load += new System.EventHandler(FormAchinh_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormAchinh()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormAchinh_Load(object sender, EventArgs e)
	{
		if (int_1 > 0 && int_2 > 0)
		{
			int num = int_1 - base.Width;
			int num2 = int_2;
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
		checkBoxBamPhim.Checked = (int_0 > 0);
		if (string_0 != null && string_0 != string.Empty)
		{
			comboBoxAc.Items.Add(string_0);
			comboBoxAc.Text = string_0;
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
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

	private void comboBoxAc_MouseDown(object sender, MouseEventArgs e)
	{
		if (FormMain.gstruct42_0 == null)
		{
			return;
		}
		bool_1 = false;
		Thread.Sleep(100);
		string text = comboBoxAc.Text;
		string text2 = null;
		string text3 = string.Empty;
		comboBoxAc.Items.Clear();
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			text3 = Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1);
			comboBoxAc.Items.Add(text3);
			if (text == text3)
			{
				text2 = text3;
			}
		}
		if (text2 == null)
		{
			if (text != string.Empty && text != null)
			{
				comboBoxAc.Items.Add(text);
				text2 = text;
			}
			else
			{
				text2 = text3;
			}
		}
		comboBoxAc.Items.Add("");
		comboBoxAc.Text = text2;
		bool_1 = true;
	}

	private void comboBoxAc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_1 && timer_0.Enabled)
		{
			string_0 = comboBoxAc.Text;
			Class55.smethod_10(Class47.string_0, "AccChinh2", Class11.smethod_17(string_0), "", 0);
		}
	}

	private void checkBoxBamPhim_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_1 && timer_0.Enabled)
		{
			int_0 = Convert.ToByte(checkBoxBamPhim.Checked);
			Class55.smethod_10(Class47.string_0, "flagPhim2", int_0, "", 0);
		}
	}
}
