using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormSuado : Form
{
	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private CheckBox checkBoxOutGameKhidobenThap;

	private TextBox textBoxValueDobenThap;

	private CheckBox checkBoxThodiaphuDobenThap;

	private CheckBox checkBoxKhongSuaTK;

	private CheckBox checkBoxLuonSuaKhiMuathuoc;

	private CheckBox checkBoxBachKim;

	private Label label1;

	private TextBox textBoxPhanTram;

	private Label label2;

	private Label label3;

	private TextBox textBoxDiem;

	private Label label4;

	private Button buttonClose;

	private CheckBox checkBoxPhiChiendau;

	private TextBox textBox1;

	private Label label5;

	private Label label6;

	public static int int_0 = 0;

	private bool bool_0 = false;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormSuado));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		checkBoxOutGameKhidobenThap = new System.Windows.Forms.CheckBox();
		textBoxValueDobenThap = new System.Windows.Forms.TextBox();
		checkBoxThodiaphuDobenThap = new System.Windows.Forms.CheckBox();
		checkBoxKhongSuaTK = new System.Windows.Forms.CheckBox();
		checkBoxLuonSuaKhiMuathuoc = new System.Windows.Forms.CheckBox();
		checkBoxBachKim = new System.Windows.Forms.CheckBox();
		label1 = new System.Windows.Forms.Label();
		textBoxPhanTram = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		textBoxDiem = new System.Windows.Forms.TextBox();
		label4 = new System.Windows.Forms.Label();
		buttonClose = new System.Windows.Forms.Button();
		checkBoxPhiChiendau = new System.Windows.Forms.CheckBox();
		textBox1 = new System.Windows.Forms.TextBox();
		label5 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		checkBoxOutGameKhidobenThap.AutoSize = true;
		checkBoxOutGameKhidobenThap.ForeColor = System.Drawing.Color.Black;
		checkBoxOutGameKhidobenThap.Location = new System.Drawing.Point(5, 137);
		checkBoxOutGameKhidobenThap.Name = "checkBoxOutGameKhidobenThap";
		checkBoxOutGameKhidobenThap.Size = new System.Drawing.Size(208, 17);
		checkBoxOutGameKhidobenThap.TabIndex = 174;
		checkBoxOutGameKhidobenThap.Text = "Thoát game khi không thể thổ địa phù";
		checkBoxOutGameKhidobenThap.UseVisualStyleBackColor = true;
		checkBoxOutGameKhidobenThap.CheckedChanged += new System.EventHandler(checkBoxOutGameKhidobenThap_CheckedChanged);
		textBoxValueDobenThap.Location = new System.Drawing.Point(220, 112);
		textBoxValueDobenThap.Name = "textBoxValueDobenThap";
		textBoxValueDobenThap.Size = new System.Drawing.Size(36, 20);
		textBoxValueDobenThap.TabIndex = 146;
		textBoxValueDobenThap.TextChanged += new System.EventHandler(textBoxValueDobenThap_TextChanged);
		checkBoxThodiaphuDobenThap.AutoSize = true;
		checkBoxThodiaphuDobenThap.ForeColor = System.Drawing.Color.Black;
		checkBoxThodiaphuDobenThap.Location = new System.Drawing.Point(5, 112);
		checkBoxThodiaphuDobenThap.Name = "checkBoxThodiaphuDobenThap";
		checkBoxThodiaphuDobenThap.Size = new System.Drawing.Size(209, 17);
		checkBoxThodiaphuDobenThap.TabIndex = 173;
		checkBoxThodiaphuDobenThap.Text = "Thổ địa phù khi độ bền xuống thấp <=";
		checkBoxThodiaphuDobenThap.UseVisualStyleBackColor = true;
		checkBoxThodiaphuDobenThap.CheckedChanged += new System.EventHandler(checkBoxThodiaphuDobenThap_CheckedChanged);
		checkBoxKhongSuaTK.AutoSize = true;
		checkBoxKhongSuaTK.ForeColor = System.Drawing.Color.DarkGreen;
		checkBoxKhongSuaTK.Location = new System.Drawing.Point(5, 27);
		checkBoxKhongSuaTK.Name = "checkBoxKhongSuaTK";
		checkBoxKhongSuaTK.Size = new System.Drawing.Size(190, 17);
		checkBoxKhongSuaTK.TabIndex = 334;
		checkBoxKhongSuaTK.Text = "Không sửa khi mua thuốc tống kim";
		checkBoxKhongSuaTK.UseVisualStyleBackColor = true;
		checkBoxKhongSuaTK.CheckedChanged += new System.EventHandler(checkBoxKhongSuaTK_CheckedChanged);
		checkBoxLuonSuaKhiMuathuoc.AutoSize = true;
		checkBoxLuonSuaKhiMuathuoc.ForeColor = System.Drawing.Color.DarkGreen;
		checkBoxLuonSuaKhiMuathuoc.Location = new System.Drawing.Point(5, 4);
		checkBoxLuonSuaKhiMuathuoc.Name = "checkBoxLuonSuaKhiMuathuoc";
		checkBoxLuonSuaKhiMuathuoc.Size = new System.Drawing.Size(229, 17);
		checkBoxLuonSuaKhiMuathuoc.TabIndex = 335;
		checkBoxLuonSuaKhiMuathuoc.Text = "Luôn sửa trang bị khi mua thuốc, tạp hóa...";
		checkBoxLuonSuaKhiMuathuoc.UseVisualStyleBackColor = true;
		checkBoxLuonSuaKhiMuathuoc.CheckedChanged += new System.EventHandler(checkBoxLuonSuaKhiMuathuoc_CheckedChanged);
		checkBoxBachKim.AutoSize = true;
		checkBoxBachKim.ForeColor = System.Drawing.Color.Black;
		checkBoxBachKim.Location = new System.Drawing.Point(5, 87);
		checkBoxBachKim.Name = "checkBoxBachKim";
		checkBoxBachKim.Size = new System.Drawing.Size(232, 17);
		checkBoxBachKim.TabIndex = 337;
		checkBoxBachKim.Text = "Sửa đồ bạch kim (+6 trở đi auto không sửa)";
		checkBoxBachKim.UseVisualStyleBackColor = true;
		checkBoxBachKim.CheckedChanged += new System.EventHandler(checkBoxBachKim_CheckedChanged);
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(31, 173);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(148, 13);
		label1.TabIndex = 339;
		label1.Text = "Sửa khi độ bền xuống còn ....";
		textBoxPhanTram.Location = new System.Drawing.Point(186, 170);
		textBoxPhanTram.Name = "textBoxPhanTram";
		textBoxPhanTram.Size = new System.Drawing.Size(30, 20);
		textBoxPhanTram.TabIndex = 340;
		textBoxPhanTram.TextChanged += new System.EventHandler(textBoxPhanTram_TextChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(222, 173);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(24, 13);
		label2.TabIndex = 341;
		label2.Text = "( %)";
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(134, 196);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(46, 13);
		label3.TabIndex = 343;
		label3.Text = "hoặc <=";
		textBoxDiem.Location = new System.Drawing.Point(186, 193);
		textBoxDiem.Name = "textBoxDiem";
		textBoxDiem.Size = new System.Drawing.Size(30, 20);
		textBoxDiem.TabIndex = 342;
		textBoxDiem.TextChanged += new System.EventHandler(textBoxDiem_TextChanged);
		textBoxDiem.Leave += new System.EventHandler(textBoxDiem_Leave);
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(222, 196);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(39, 13);
		label4.TabIndex = 344;
		label4.Text = "( điểm)";
		buttonClose.Location = new System.Drawing.Point(93, 254);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(85, 26);
		buttonClose.TabIndex = 346;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		checkBoxPhiChiendau.AutoSize = true;
		checkBoxPhiChiendau.ForeColor = System.Drawing.Color.DarkGreen;
		checkBoxPhiChiendau.Location = new System.Drawing.Point(5, 49);
		checkBoxPhiChiendau.Name = "checkBoxPhiChiendau";
		checkBoxPhiChiendau.Size = new System.Drawing.Size(155, 17);
		checkBoxPhiChiendau.TabIndex = 347;
		checkBoxPhiChiendau.Text = "Sửa đồ ở nơi phi chiến đấu";
		checkBoxPhiChiendau.UseVisualStyleBackColor = true;
		checkBoxPhiChiendau.CheckedChanged += new System.EventHandler(checkBoxPhiChiendau_CheckedChanged);
		textBox1.Location = new System.Drawing.Point(186, 219);
		textBox1.Name = "textBox1";
		textBox1.Size = new System.Drawing.Size(30, 20);
		textBox1.TabIndex = 349;
		textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(3, 222);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(176, 13);
		label5.TabIndex = 348;
		label5.Text = "Thời gian giữa 2 lần kiểm tra sửa đồ";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(222, 223);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(35, 13);
		label6.TabIndex = 350;
		label6.Text = "( giây)";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(271, 292);
		base.Controls.Add(label6);
		base.Controls.Add(textBox1);
		base.Controls.Add(label5);
		base.Controls.Add(checkBoxPhiChiendau);
		base.Controls.Add(textBoxDiem);
		base.Controls.Add(buttonClose);
		base.Controls.Add(textBoxPhanTram);
		base.Controls.Add(label4);
		base.Controls.Add(checkBoxOutGameKhidobenThap);
		base.Controls.Add(label3);
		base.Controls.Add(checkBoxThodiaphuDobenThap);
		base.Controls.Add(label2);
		base.Controls.Add(label1);
		base.Controls.Add(checkBoxBachKim);
		base.Controls.Add(textBoxValueDobenThap);
		base.Controls.Add(checkBoxLuonSuaKhiMuathuoc);
		base.Controls.Add(checkBoxKhongSuaTK);
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormSuado";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "Sua do";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormSuado_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormSuado()
	{
		int_0 = 1;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int_0 = 0;
	}

	private void FormSuado_Load(object sender, EventArgs e)
	{
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
		textBoxValueDobenThap.Text = FormMain.int_76.ToString();
		checkBoxThodiaphuDobenThap.Checked = (FormMain.int_77 > 0);
		checkBoxOutGameKhidobenThap.Checked = (FormMain.int_75 > 0);
		checkBoxKhongSuaTK.Checked = (FormMain.int_56 > 0);
		checkBoxOutGameKhidobenThap.Enabled = (FormMain.int_77 > 0);
		checkBoxLuonSuaKhiMuathuoc.Checked = (FormMain.int_57 > 0);
		checkBoxBachKim.Checked = (FormMain.int_58 > 0);
		textBoxPhanTram.Text = FormMain.int_60[0].ToString();
		textBoxDiem.Text = FormMain.int_60[1].ToString();
		checkBoxPhiChiendau.Checked = (FormMain.int_59 > 0);
		textBox1.Text = FormMain.int_78.ToString();
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		bool_0 = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			Close();
		}
	}

	private void checkBoxThodiaphuDobenThap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_77 = Convert.ToByte(checkBoxThodiaphuDobenThap.Checked);
			Class55.smethod_10(Class47.string_0, "flagThodiaphuDobenThap", FormMain.int_77, "", 0);
			checkBoxOutGameKhidobenThap.Enabled = (FormMain.int_77 > 0);
		}
	}

	private void textBoxValueDobenThap_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_76 = Class11.smethod_12(textBoxValueDobenThap.Text);
			if (FormMain.int_76 < 3)
			{
				FormMain.int_76 = 3;
			}
			Class55.smethod_10(Class47.string_0, "nDobenThap", FormMain.int_76, "", 0);
		}
	}

	private void checkBoxOutGameKhidobenThap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_75 = Convert.ToByte(checkBoxOutGameKhidobenThap.Checked);
			Class55.smethod_10(Class47.string_0, "nDobenOut", FormMain.int_75, "", 0);
		}
	}

	private void checkBoxKhongSuaTK_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_56 = Convert.ToByte(checkBoxKhongSuaTK.Checked);
			Class55.smethod_10(Class47.string_0, "flagKhongSuaTK", FormMain.int_56, "", 0);
		}
	}

	private void checkBoxLuonSuaKhiMuathuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_57 = Convert.ToByte(checkBoxLuonSuaKhiMuathuoc.Checked);
			Class55.smethod_10(Class47.string_0, "flagLuonSuaMua", FormMain.int_57, "", 0);
		}
	}

	private void checkBoxBachKim_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_58 = Convert.ToByte(checkBoxBachKim.Checked);
			Class55.smethod_10(Class47.string_0, "flagSudoBachKim", FormMain.int_58, "", 0);
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		int_0 = 0;
		Close();
	}

	private void textBoxPhanTram_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_60[0] = Class11.smethod_12(textBoxPhanTram.Text);
			if (FormMain.int_60[0] <= 10)
			{
				FormMain.int_60[0] = 10;
			}
			Class55.smethod_10(Class47.string_0, "fSuado1_0", FormMain.int_60[0], "", 0);
		}
	}

	private void textBoxDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_60[1] = Class11.smethod_12(textBoxDiem.Text);
			if (FormMain.int_60[1] < 5)
			{
				FormMain.int_60[1] = 5;
			}
			Class55.smethod_10(Class47.string_0, "fSuado1_1", FormMain.int_60[1], "", 0);
		}
	}

	private void textBoxDiem_Leave(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_60[1] = Class11.smethod_12(textBoxDiem.Text);
			if (FormMain.int_60[1] < 5)
			{
				FormMain.int_60[1] = 5;
				textBoxDiem.Text = "5";
			}
		}
	}

	private void checkBoxPhiChiendau_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			FormMain.int_59 = Convert.ToByte(checkBoxPhiChiendau.Checked);
			Class55.smethod_10(Class47.string_0, "fSuaPhichiendau", FormMain.int_59, "", 0);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		FormMain.int_78 = Class11.smethod_12(textBox1.Text);
		if (FormMain.int_78 < 10)
		{
			FormMain.int_78 = 10;
		}
		else if (FormMain.int_78 > 180)
		{
			FormMain.int_78 = 180;
		}
		Class55.smethod_10(Class47.string_0, "ThoigianSua", FormMain.int_78, "", 0);
	}
}
