using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Dangky : Form
{
	private IContainer icontainer_0 = null;

	private Button dkcopy;

	private TextBox dkidcode;

	private Label label1;

	private RichTextBox dksr;

	private Label label2;

	private Button dkxoahet;

	private Button dkdanvao;

	private Button dkdangky;

	private Timer timer_0;

	private Button buttonCapnhatlic;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private CheckBox checkBoxOcungThu2;

	public static int int_0 = 0;

	public static char[] char_0 = new char[89]
	{
		'ᗒ',
		'ᖥ',
		'ᓢ',
		'ᗓ',
		'ᗅ',
		'ᔰ',
		'ᔩ',
		'ᓢ',
		'ᔭ',
		'ᖿ',
		'ᓢ',
		'ᔺ',
		'ᔱ',
		'ᔰ',
		'ᔩ',
		'ᓰ',
		'ᓌ',
		'ᔅ',
		'ᔪ',
		'㍣',
		'ᔻ',
		'ᓢ',
		'ᔮ',
		'㍣',
		'ᔫ',
		'ᓢ',
		'ᔚ',
		'ᔚ',
		'ᔚ',
		'ᓮ',
		'ᓢ',
		'ᔰ',
		'㎁',
		'ᔷ',
		'ᓢ',
		'ᔶ',
		'ᔪ',
		'㍧',
		'ᔻ',
		'ᓢ',
		'ᔶ',
		'ᔪ',
		'ᖶ',
		'ᔰ',
		'ᔩ',
		'ᓢ',
		'ᔤ',
		'ᖣ',
		'ᔱ',
		'ᓢ',
		'ᗓ',
		'ᖥ',
		'ᓢ',
		'ᗓ',
		'ᙲ',
		'㎥',
		'ᔥ',
		'ᓢ',
		'ᗓ',
		'ᗅ',
		'ᔰ',
		'ᔩ',
		'ᓢ',
		'ᔭ',
		'ᖿ',
		'ᓢ',
		'ᔵ',
		'㎯',
		'ᓢ',
		'ᔦ',
		'㎧',
		'ᔰ',
		'ᔩ',
		'ᓢ',
		'ᔶ',
		'ᔪ',
		'ᖮ',
		'ᓢ',
		'ᔶ',
		'ᔪ',
		'ᖢ',
		'ᔰ',
		'ᔪ',
		'ᓢ',
		'ᔥ',
		'ᖶ',
		'ᔰ',
		'ᔩ',
		'ᓣ'
	};

	private string[] string_0 = null;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Dangky));
		dkcopy = new System.Windows.Forms.Button();
		dkidcode = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		dksr = new System.Windows.Forms.RichTextBox();
		label2 = new System.Windows.Forms.Label();
		dkxoahet = new System.Windows.Forms.Button();
		dkdanvao = new System.Windows.Forms.Button();
		dkdangky = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonCapnhatlic = new System.Windows.Forms.Button();
		tabControl1 = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		tabPage2 = new System.Windows.Forms.TabPage();
		checkBoxOcungThu2 = new System.Windows.Forms.CheckBox();
		tabControl1.SuspendLayout();
		tabPage1.SuspendLayout();
		tabPage2.SuspendLayout();
		SuspendLayout();
		dkcopy.BackColor = System.Drawing.Color.LightSteelBlue;
		dkcopy.ForeColor = System.Drawing.Color.Black;
		dkcopy.Location = new System.Drawing.Point(377, 3);
		dkcopy.Name = "dkcopy";
		dkcopy.Size = new System.Drawing.Size(50, 21);
		dkcopy.TabIndex = 0;
		dkcopy.Text = "Copy";
		dkcopy.UseVisualStyleBackColor = false;
		dkcopy.Click += new System.EventHandler(dkcopy_Click);
		dkidcode.ForeColor = System.Drawing.Color.Black;
		dkidcode.Location = new System.Drawing.Point(53, 3);
		dkidcode.Name = "dkidcode";
		dkidcode.ReadOnly = true;
		dkidcode.Size = new System.Drawing.Size(318, 20);
		dkidcode.TabIndex = 1;
		label1.AutoSize = true;
		label1.ForeColor = System.Drawing.Color.Black;
		label1.Location = new System.Drawing.Point(3, 6);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(44, 13);
		label1.TabIndex = 2;
		label1.Text = "Mã máy";
		dksr.ForeColor = System.Drawing.Color.Black;
		dksr.Location = new System.Drawing.Point(6, 48);
		dksr.Name = "dksr";
		dksr.Size = new System.Drawing.Size(421, 74);
		dksr.TabIndex = 3;
		dksr.Text = "";
		label2.AutoSize = true;
		label2.ForeColor = System.Drawing.Color.Black;
		label2.Location = new System.Drawing.Point(3, 32);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(256, 13);
		label2.TabIndex = 4;
		label2.Text = "Bấm nút [Dán Serial] để điền serial vào box dưới đây";
		dkxoahet.BackColor = System.Drawing.SystemColors.Control;
		dkxoahet.ForeColor = System.Drawing.Color.Black;
		dkxoahet.Location = new System.Drawing.Point(219, 131);
		dkxoahet.Name = "dkxoahet";
		dkxoahet.Size = new System.Drawing.Size(76, 26);
		dkxoahet.TabIndex = 5;
		dkxoahet.Text = "Xoá hết";
		dkxoahet.UseVisualStyleBackColor = false;
		dkxoahet.Click += new System.EventHandler(dkxoahet_Click);
		dkdanvao.BackColor = System.Drawing.SystemColors.Control;
		dkdanvao.ForeColor = System.Drawing.Color.Black;
		dkdanvao.Location = new System.Drawing.Point(139, 131);
		dkdanvao.Name = "dkdanvao";
		dkdanvao.Size = new System.Drawing.Size(74, 26);
		dkdanvao.TabIndex = 6;
		dkdanvao.Text = "Dán Serial";
		dkdanvao.UseVisualStyleBackColor = false;
		dkdanvao.Click += new System.EventHandler(dkdanvao_Click);
		dkdangky.BackColor = System.Drawing.SystemColors.Control;
		dkdangky.ForeColor = System.Drawing.Color.MediumBlue;
		dkdangky.Location = new System.Drawing.Point(332, 131);
		dkdangky.Name = "dkdangky";
		dkdangky.Size = new System.Drawing.Size(95, 26);
		dkdangky.TabIndex = 7;
		dkdangky.Text = "Đăng ký";
		dkdangky.UseVisualStyleBackColor = false;
		dkdangky.Click += new System.EventHandler(dkdangky_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonCapnhatlic.BackColor = System.Drawing.SystemColors.Control;
		buttonCapnhatlic.ForeColor = System.Drawing.Color.MediumBlue;
		buttonCapnhatlic.Location = new System.Drawing.Point(6, 131);
		buttonCapnhatlic.Name = "buttonCapnhatlic";
		buttonCapnhatlic.Size = new System.Drawing.Size(110, 26);
		buttonCapnhatlic.TabIndex = 8;
		buttonCapnhatlic.Text = "Cập nhật LIC mới";
		buttonCapnhatlic.UseVisualStyleBackColor = false;
		buttonCapnhatlic.Click += new System.EventHandler(buttonCapnhatlic_Click);
		tabControl1.Controls.Add(tabPage1);
		tabControl1.Controls.Add(tabPage2);
		tabControl1.Location = new System.Drawing.Point(0, 1);
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size(448, 196);
		tabControl1.TabIndex = 9;
		tabPage1.Controls.Add(dksr);
		tabPage1.Controls.Add(buttonCapnhatlic);
		tabPage1.Controls.Add(dkcopy);
		tabPage1.Controls.Add(dkdangky);
		tabPage1.Controls.Add(dkidcode);
		tabPage1.Controls.Add(dkdanvao);
		tabPage1.Controls.Add(label1);
		tabPage1.Controls.Add(dkxoahet);
		tabPage1.Controls.Add(label2);
		tabPage1.Location = new System.Drawing.Point(4, 22);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding(3);
		tabPage1.Size = new System.Drawing.Size(440, 170);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "Đăng ký";
		tabPage1.UseVisualStyleBackColor = true;
		tabPage2.Controls.Add(checkBoxOcungThu2);
		tabPage2.Location = new System.Drawing.Point(4, 22);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding(3);
		tabPage2.Size = new System.Drawing.Size(440, 193);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "Thông tin khác";
		tabPage2.UseVisualStyleBackColor = true;
		checkBoxOcungThu2.AutoSize = true;
		checkBoxOcungThu2.Location = new System.Drawing.Point(6, 6);
		checkBoxOcungThu2.Name = "checkBoxOcungThu2";
		checkBoxOcungThu2.Size = new System.Drawing.Size(80, 17);
		checkBoxOcungThu2.TabIndex = 0;
		checkBoxOcungThu2.Text = "checkBox1";
		checkBoxOcungThu2.UseVisualStyleBackColor = true;
		checkBoxOcungThu2.CheckedChanged += new System.EventHandler(checkBoxOcungThu2_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(446, 195);
		base.Controls.Add(tabControl1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "Dangky";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "DANG KY SU DUNG";
		base.TopMost = true;
		base.Load += new System.EventHandler(Dangky_Load);
		tabControl1.ResumeLayout(performLayout: false);
		tabPage1.ResumeLayout(performLayout: false);
		tabPage1.PerformLayout();
		tabPage2.ResumeLayout(performLayout: false);
		tabPage2.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public Dangky()
	{
		int_0 = 1;
		string text = string.Empty;
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_1(Class47.char_0));
		string_0 = new string[2]
		{
			environmentVariable + "\\" + Class11.smethod_1(Class11.char_33),
			Class47.string_5 + "\\" + Class11.smethod_1(Class11.char_33)
		};
		InitializeComponent();
		base.TopMost = true;
		if (Class26.string_2 != null && Class26.string_2 != string.Empty)
		{
			dkidcode.Text = Class26.string_2;
		}
		else
		{
			dkidcode.Text = Class26.string_1;
		}
		bool flag = false;
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				string text2 = Class11.smethod_28(string_0[i], 1, 1, 1);
				if (text2 != null && text2 != string.Empty)
				{
					text = text2;
					flag = true;
					break;
				}
			}
		}
		dksr.Text = text;
		dksr.ReadOnly = flag;
		buttonCapnhatlic.Enabled = flag;
		dkdanvao.Enabled = !flag;
		dkxoahet.Enabled = !flag;
		dkdangky.Enabled = !flag;
		checkBoxOcungThu2.Checked = (Class26.int_1 > 0);
		Class11.smethod_8(Class47.string_5);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
	}

	private void dkcopy_Click(object sender, EventArgs e)
	{
		try
		{
			if (dkidcode.Text != null && dkidcode.Text != string.Empty)
			{
				Clipboard.SetText(dkidcode.Text);
			}
		}
		catch
		{
		}
	}

	private void dkxoahet_Click(object sender, EventArgs e)
	{
		dksr.Text = "";
	}

	private void dkdanvao_Click(object sender, EventArgs e)
	{
		try
		{
			dksr.Text = Clipboard.GetText();
		}
		catch
		{
		}
	}

	private void dkdangky_Click(object sender, EventArgs e)
	{
		string text = dksr.Text.Trim().Replace(":", "").Replace("\t", "")
			.Replace(" ", "");
		if (text != "" && Class11.smethod_2(text, " ") < 0 && Class11.smethod_2(text, "à") < 0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				Class11.smethod_29(string_0[i], text, 1);
			}
			char[] char_ = new char[175]
			{
				'ᕳ',
				'ᕤ',
				'ᕡ',
				'ᕛ',
				'ᔸ',
				'ᕙ',
				'ᖍ',
				'ᖌ',
				'ᖇ',
				'ᔸ',
				'ᕙ',
				'ᕙ',
				'ᕙ',
				'ᕙ',
				'ᕵ',
				'ᔸ',
				'ᔢ',
				'ᕥ',
				'ᕹ',
				'ᔸ',
				'ᖅ',
				'ᕹ',
				'ᖑ',
				'ᔡ',
				'ᕒ',
				'ᔸ',
				'ᕰ',
				'ᕰ',
				'ᕰ',
				'ᕰ',
				'ᔢ',
				'ᕫ',
				'ᕽ',
				'ᖊ',
				'ᖁ',
				'ᕹ',
				'ᖄ',
				'ᔡ',
				'ᕒ',
				'ᔸ',
				'ᕱ',
				'ᕱ',
				'ᕱ',
				'ᕱ',
				'ᔢ',
				'ᔢ',
				'ᕛ',
				'ᕹ',
				'ᕻ',
				'ᖀ',
				'ᔸ',
				'ᖄ',
				'ᕹ',
				'ᖅ',
				'ᕒ',
				'ᔸ',
				'ᕛ',
				'ᖇ',
				'ᖈ',
				'ᖑ',
				'ᔸ',
				'ᖈ',
				'ᖀ',
				'ᖁ',
				'ᕹ',
				'ᔸ',
				'ᖋ',
				'ᕹ',
				'ᖍ',
				'ᔸ',
				'ᕻ',
				'ᖀ',
				'ᖍ',
				'ᖇ',
				'ᖁ',
				'ᔸ',
				'ᕫ',
				'ᕽ',
				'ᖊ',
				'ᖁ',
				'ᕹ',
				'ᖄ',
				'ᔸ',
				'ᕻ',
				'ᖀ',
				'ᖇ',
				'ᔸ',
				'ᕼ',
				'ᕽ',
				'ᖆ',
				'ᔸ',
				'ᖀ',
				'ᕽ',
				'ᖌ',
				'ᔸ',
				'ᕀ',
				'ᖃ',
				'ᕽ',
				'ᔸ',
				'ᕻ',
				'ᕹ',
				'ᔸ',
				'ᕊ',
				'ᔸ',
				'ᕼ',
				'ᕹ',
				'ᖍ',
				'ᔸ',
				'ᕕ',
				'ᕕ',
				'ᔸ',
				'ᕻ',
				'ᖍ',
				'ᖇ',
				'ᖁ',
				'ᔸ',
				'ᕻ',
				'ᖍ',
				'ᖆ',
				'ᕿ',
				'ᔸ',
				'ᖆ',
				'ᕽ',
				'ᖍ',
				'ᔸ',
				'ᕻ',
				'ᖇ',
				'ᕁ',
				'ᔢ',
				'ᕫ',
				'ᕹ',
				'ᖍ',
				'ᔸ',
				'ᕼ',
				'ᖇ',
				'ᔸ',
				'ᕼ',
				'ᕹ',
				'ᖆ',
				'ᔸ',
				'ᖎ',
				'ᕹ',
				'ᖇ',
				'ᔸ',
				'ᕺ',
				'ᖇ',
				'ᖐ',
				'ᔸ',
				'ᖋ',
				'ᕽ',
				'ᖊ',
				'ᖁ',
				'ᕹ',
				'ᖄ',
				'ᔸ',
				'ᖎ',
				'ᕹ',
				'ᔸ',
				'ᖆ',
				'ᖀ',
				'ᕹ',
				'ᖆ',
				'ᔸ',
				'ᖆ',
				'ᖍ',
				'ᖌ',
				'ᔸ',
				'ᕼ',
				'ᕹ',
				'ᖆ',
				'ᕿ',
				'ᔸ',
				'ᖃ',
				'ᖑ',
				'ᕆ'
			};
			string text2 = Class11.smethod_1(char_);
			text2 = text2.Replace(Class11.smethod_1(new char[4]
			{
				'ᒮ',
				'ᒮ',
				'ᒮ',
				'ᒮ'
			}), FormMain.string_1);
			text2 = text2.Replace("\n", Class47.string_3);
			text2 = text2.Replace(Class11.smethod_1(new char[4]
			{
				'ᓅ',
				'ᓅ',
				'ᓅ',
				'ᓅ'
			}), Class26.string_1);
			text2 = text2.Replace(Class11.smethod_1(new char[4]
			{
				'ᓆ',
				'ᓆ',
				'ᓆ',
				'ᓆ'
			}), text);
			Class11.smethod_29(Class11.smethod_1(Class11.char_34), text2, 1);
			MessageBox.Show(Class11.smethod_1(char_0).Replace(Class11.smethod_1(new char[3]
			{
				'ᓄ',
				'ᓄ',
				'ᓄ'
			}), FormMain.string_1), FormMain.string_1);
			Close();
		}
	}

	private void Dangky_Load(object sender, EventArgs e)
	{
		int x = Cursor.Position.X;
		int y = Cursor.Position.Y;
		x -= base.Width;
		y -= base.Height;
		if (x <= 0)
		{
			x = 1;
		}
		if (y <= 0)
		{
			y = 1;
		}
		SetBounds(x, y, base.Width, base.Height);
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int_0 = 0;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			Close();
		}
	}

	private void buttonCapnhatlic_Click(object sender, EventArgs e)
	{
		dksr.ReadOnly = false;
		dksr.BackColor = Color.White;
		buttonCapnhatlic.Enabled = false;
		dkdanvao.Enabled = true;
		dkxoahet.Enabled = true;
		dkdangky.Enabled = true;
	}

	private void checkBoxOcungThu2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class26.int_1 = Convert.ToByte(checkBoxOcungThu2.Checked);
			Class55.smethod_10(Class47.string_0, "fMultiHd", Class26.int_1, "", 0);
		}
	}
}
