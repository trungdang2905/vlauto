using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormTip : Form
{
	private IContainer icontainer_0 = null;

	private CheckBox checkBoxKhongHienthi;

	private Button buttonDong;

	private Timer timer_0;

	private RichTextBox richTextBoxStatus;

	private Button buttonCopy;

	public static bool bool_0 = false;

	public bool bool_1 = false;

	public string string_0 = null;

	public string string_1 = null;

	public string string_2 = null;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4 = 0;

	public bool bool_2 = false;

	public bool bool_3 = false;

	public int int_5 = 0;

	public int int_6 = 0;

	public bool bool_4 = false;

	private string string_3 = null;

	private static long long_0 = 0L;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormTip));
		checkBoxKhongHienthi = new System.Windows.Forms.CheckBox();
		buttonDong = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		richTextBoxStatus = new System.Windows.Forms.RichTextBox();
		buttonCopy = new System.Windows.Forms.Button();
		SuspendLayout();
		checkBoxKhongHienthi.AutoSize = true;
		checkBoxKhongHienthi.BackColor = System.Drawing.Color.LightSteelBlue;
		checkBoxKhongHienthi.Location = new System.Drawing.Point(3, 253);
		checkBoxKhongHienthi.Name = "checkBoxKhongHienthi";
		checkBoxKhongHienthi.Size = new System.Drawing.Size(199, 17);
		checkBoxKhongHienthi.TabIndex = 1;
		checkBoxKhongHienthi.Text = "Không hiện bảng thông báo này nữa";
		checkBoxKhongHienthi.UseVisualStyleBackColor = false;
		checkBoxKhongHienthi.CheckedChanged += new System.EventHandler(checkBoxKhongHienthi_CheckedChanged);
		buttonDong.Location = new System.Drawing.Point(366, 250);
		buttonDong.Name = "buttonDong";
		buttonDong.Size = new System.Drawing.Size(77, 21);
		buttonDong.TabIndex = 2;
		buttonDong.Text = "Đóng";
		buttonDong.UseVisualStyleBackColor = true;
		buttonDong.Click += new System.EventHandler(buttonDong_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		richTextBoxStatus.BackColor = System.Drawing.Color.White;
		richTextBoxStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		richTextBoxStatus.ForeColor = System.Drawing.SystemColors.WindowText;
		richTextBoxStatus.Location = new System.Drawing.Point(0, 0);
		richTextBoxStatus.Name = "richTextBoxStatus";
		richTextBoxStatus.Size = new System.Drawing.Size(443, 248);
		richTextBoxStatus.TabIndex = 3;
		richTextBoxStatus.Text = "Hướng dẫn sử dụng";
		buttonCopy.Location = new System.Drawing.Point(283, 250);
		buttonCopy.Name = "buttonCopy";
		buttonCopy.Size = new System.Drawing.Size(77, 21);
		buttonCopy.TabIndex = 4;
		buttonCopy.Text = "Copy";
		buttonCopy.UseVisualStyleBackColor = true;
		buttonCopy.Click += new System.EventHandler(buttonCopy_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(444, 273);
		base.Controls.Add(buttonCopy);
		base.Controls.Add(checkBoxKhongHienthi);
		base.Controls.Add(richTextBoxStatus);
		base.Controls.Add(buttonDong);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormTip";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "HUONG DAN";
		base.Load += new System.EventHandler(FormTip_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormTip()
	{
		bool_0 = !bool_0;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
		string_0 = null;
		string_2 = null;
		int_4 = -1;
		string_1 = null;
		int_5 = 0;
		int_6 = 0;
		bool_4 = false;
	}

	private void FormTip_Load(object sender, EventArgs e)
	{
		Hide();
		buttonCopy.Visible = bool_4;
		if (!bool_3)
		{
			base.StartPosition = FormStartPosition.CenterScreen;
		}
		else
		{
			buttonDong.Visible = false;
			if (int_5 <= 0)
			{
				int_5 = 281;
			}
			if (int_6 <= 0)
			{
				int_6 = 130;
			}
			richTextBoxStatus.Width = int_5 - 7;
			richTextBoxStatus.Height = int_6 - 27;
			richTextBoxStatus.Top = 0;
			richTextBoxStatus.Left = 0;
			richTextBoxStatus.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Width = int_5;
			if (bool_4)
			{
				base.Height = int_6 + 30;
				buttonCopy.Top = richTextBoxStatus.Top + richTextBoxStatus.Height + 5;
				buttonCopy.Left = (base.Width - buttonCopy.Width) / 2;
			}
			else
			{
				base.Height = int_6 + 2;
			}
		}
		if (int_0 > 0 && int_1 > 0)
		{
			checkBoxKhongHienthi.Visible = false;
			int num = int_0 - base.Width - 5;
			int num2 = int_1 - base.Height - 5;
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
		if (string_0 != null)
		{
			string text = string_0.Replace("|", Class47.string_3).Replace("\\n", Class47.string_3).Replace("\\t", '\t'.ToString());
			richTextBoxStatus.Text = text;
		}
		checkBoxKhongHienthi.Enabled = !bool_1;
		richTextBoxStatus.WordWrap = !bool_2;
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		long_0 = Class11.smethod_22();
		if (string_1 != null)
		{
			Text = string_1;
		}
		string_3 = Text;
		base.TopMost = true;
		Show();
	}

	private void buttonDong_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxKhongHienthi_CheckedChanged(object sender, EventArgs e)
	{
		if (FormMain.string_6 == null)
		{
			FormMain.string_6 = string.Empty;
		}
		string str = "Không hiện bảng thông báo này nữa";
		string str2 = string.Empty;
		if (checkBoxKhongHienthi.Checked)
		{
			if (string_2 != null && string_2 != string.Empty)
			{
				Class55.smethod_10(Class47.string_0, string_2, string_0, "", 0);
			}
			else
			{
				Class55.smethod_10(Class47.string_0, "UpdateNew", string_0.Length, "", 0);
			}
			str2 = " (có thể xem lại ở Phụ trợ - Phim)";
		}
		else if (string_2 != null && string_2 != string.Empty)
		{
			Class55.smethod_10(Class47.string_0, string_2, string.Empty, "", 0);
		}
		else
		{
			Class55.smethod_10(Class47.string_0, "UpdateNew", 0, "", 0);
		}
		checkBoxKhongHienthi.Text = str + str2;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (int_4 > 0)
			{
				long num = int_4 - Class11.smethod_23(long_0);
				Text = string_3 + " (" + num / 1000L + "s)";
				if (num < 0L)
				{
					Close();
				}
			}
		}
		else
		{
			Close();
		}
	}

	public static void smethod_0(string string_4, string string_5, int int_7 = 60000, int int_8 = 345, int int_9 = 200, bool bool_5 = false, int int_10 = -1, int int_11 = -1, bool bool_6 = false)
	{
		if (int_8 < 0)
		{
			int_8 = 345;
		}
		if (int_9 < 0)
		{
			int_9 = 200;
		}
		if (int_7 < 0)
		{
			int_7 = 60000;
		}
		FormTip formTip = new FormTip();
		formTip.string_0 = string_5;
		if (int_10 >= 0 && int_11 >= 0)
		{
			formTip.int_0 = int_10 + 5;
			formTip.int_1 = int_11 + int_9 + 5;
		}
		else
		{
			formTip.int_0 = Cursor.Position.X;
			formTip.int_1 = Cursor.Position.Y;
		}
		formTip.bool_4 = bool_6;
		formTip.int_2 = FormMain.int_46[0];
		formTip.int_3 = FormMain.int_46[1];
		formTip.bool_3 = true;
		formTip.bool_2 = bool_5;
		formTip.int_5 = int_8;
		formTip.int_6 = int_9;
		formTip.int_4 = int_7;
		formTip.string_1 = string_4;
		formTip.Show();
	}

	private void buttonCopy_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText(richTextBoxStatus.Text);
		}
		catch
		{
		}
	}
}
