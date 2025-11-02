using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormHuyenTinh : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private LinkLabel linkLabelPhimCheTaoHT;

	private LinkLabel linkLabelHDHT;

	private Button buttonDungChetao;

	private CheckBox checkBoxC8;

	private CheckBox checkBoxC7;

	private Button buttonChetaoHuyentinh;

	private CheckBox checkBoxC1;

	private Button buttonStopNangcapHT;

	private CheckBox checkBoxNguyenlieuBH;

	private CheckBox checkBoxC3;

	private CheckBox checkBoxC9;

	private CheckBox checkBoxC6;

	private Button buttonBatdauNangcap;

	private CheckBox checkBoxC4;

	private CheckBox checkBoxC2;

	private CheckBox checkBoxC5;

	private TextBox textBoxHT;

	private GroupBox groupBoxNangCap;

	public static int int_0 = 0;

	public static bool bool_0 = false;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormHuyenTinh));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonClose = new System.Windows.Forms.Button();
		linkLabelPhimCheTaoHT = new System.Windows.Forms.LinkLabel();
		linkLabelHDHT = new System.Windows.Forms.LinkLabel();
		buttonDungChetao = new System.Windows.Forms.Button();
		checkBoxC8 = new System.Windows.Forms.CheckBox();
		checkBoxC7 = new System.Windows.Forms.CheckBox();
		buttonChetaoHuyentinh = new System.Windows.Forms.Button();
		checkBoxC1 = new System.Windows.Forms.CheckBox();
		buttonStopNangcapHT = new System.Windows.Forms.Button();
		checkBoxNguyenlieuBH = new System.Windows.Forms.CheckBox();
		checkBoxC3 = new System.Windows.Forms.CheckBox();
		checkBoxC9 = new System.Windows.Forms.CheckBox();
		checkBoxC6 = new System.Windows.Forms.CheckBox();
		buttonBatdauNangcap = new System.Windows.Forms.Button();
		checkBoxC4 = new System.Windows.Forms.CheckBox();
		checkBoxC2 = new System.Windows.Forms.CheckBox();
		checkBoxC5 = new System.Windows.Forms.CheckBox();
		textBoxHT = new System.Windows.Forms.TextBox();
		groupBoxNangCap = new System.Windows.Forms.GroupBox();
		groupBoxNangCap.SuspendLayout();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonClose.BackColor = System.Drawing.SystemColors.Control;
		buttonClose.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		buttonClose.ForeColor = System.Drawing.Color.Black;
		buttonClose.Location = new System.Drawing.Point(240, 232);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(76, 36);
		buttonClose.TabIndex = 139;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = false;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		linkLabelPhimCheTaoHT.AutoSize = true;
		linkLabelPhimCheTaoHT.Location = new System.Drawing.Point(3, 213);
		linkLabelPhimCheTaoHT.Name = "linkLabelPhimCheTaoHT";
		linkLabelPhimCheTaoHT.Size = new System.Drawing.Size(61, 13);
		linkLabelPhimCheTaoHT.TabIndex = 164;
		linkLabelPhimCheTaoHT.TabStop = true;
		linkLabelPhimCheTaoHT.Text = "Phim H.dẫn";
		linkLabelPhimCheTaoHT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelPhimCheTaoHT_LinkClicked);
		linkLabelHDHT.AutoSize = true;
		linkLabelHDHT.Location = new System.Drawing.Point(3, 190);
		linkLabelHDHT.Name = "linkLabelHDHT";
		linkLabelHDHT.Size = new System.Drawing.Size(60, 13);
		linkLabelHDHT.TabIndex = 163;
		linkLabelHDHT.TabStop = true;
		linkLabelHDHT.Text = "Hướng dẫn";
		linkLabelHDHT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelHDHT_LinkClicked);
		buttonDungChetao.BackColor = System.Drawing.Color.LightSteelBlue;
		buttonDungChetao.ForeColor = System.Drawing.Color.MediumBlue;
		buttonDungChetao.Location = new System.Drawing.Point(154, 232);
		buttonDungChetao.Name = "buttonDungChetao";
		buttonDungChetao.Size = new System.Drawing.Size(80, 36);
		buttonDungChetao.TabIndex = 12;
		buttonDungChetao.Text = "Dừng chế tạo";
		buttonDungChetao.UseVisualStyleBackColor = false;
		buttonDungChetao.Click += new System.EventHandler(buttonDungChetao_Click);
		checkBoxC8.AutoSize = true;
		checkBoxC8.Location = new System.Drawing.Point(202, 53);
		checkBoxC8.Name = "checkBoxC8";
		checkBoxC8.Size = new System.Drawing.Size(78, 17);
		checkBoxC8.TabIndex = 8;
		checkBoxC8.Text = "Cấp 8 -> 9";
		checkBoxC8.UseVisualStyleBackColor = true;
		checkBoxC8.CheckedChanged += new System.EventHandler(checkBoxC8_CheckedChanged);
		checkBoxC7.AutoSize = true;
		checkBoxC7.Location = new System.Drawing.Point(202, 30);
		checkBoxC7.Name = "checkBoxC7";
		checkBoxC7.Size = new System.Drawing.Size(78, 17);
		checkBoxC7.TabIndex = 7;
		checkBoxC7.Text = "Cấp 7 -> 8";
		checkBoxC7.UseVisualStyleBackColor = true;
		checkBoxC7.CheckedChanged += new System.EventHandler(checkBoxC7_CheckedChanged);
		buttonChetaoHuyentinh.BackColor = System.Drawing.Color.LightSteelBlue;
		buttonChetaoHuyentinh.ForeColor = System.Drawing.Color.MediumBlue;
		buttonChetaoHuyentinh.Location = new System.Drawing.Point(68, 232);
		buttonChetaoHuyentinh.Name = "buttonChetaoHuyentinh";
		buttonChetaoHuyentinh.Size = new System.Drawing.Size(80, 36);
		buttonChetaoHuyentinh.TabIndex = 11;
		buttonChetaoHuyentinh.Text = "Bắt đầu chế tạo";
		buttonChetaoHuyentinh.UseVisualStyleBackColor = false;
		buttonChetaoHuyentinh.Click += new System.EventHandler(buttonChetaoHuyentinh_Click);
		checkBoxC1.AutoSize = true;
		checkBoxC1.Location = new System.Drawing.Point(12, 30);
		checkBoxC1.Name = "checkBoxC1";
		checkBoxC1.Size = new System.Drawing.Size(78, 17);
		checkBoxC1.TabIndex = 1;
		checkBoxC1.Text = "Cấp 1 -> 2";
		checkBoxC1.UseVisualStyleBackColor = true;
		checkBoxC1.CheckedChanged += new System.EventHandler(checkBoxC1_CheckedChanged);
		buttonStopNangcapHT.Location = new System.Drawing.Point(154, 190);
		buttonStopNangcapHT.Name = "buttonStopNangcapHT";
		buttonStopNangcapHT.Size = new System.Drawing.Size(80, 36);
		buttonStopNangcapHT.TabIndex = 11;
		buttonStopNangcapHT.Text = "Dừng nâng cấp";
		buttonStopNangcapHT.UseVisualStyleBackColor = true;
		buttonStopNangcapHT.Click += new System.EventHandler(buttonStopNangcapHT_Click);
		checkBoxNguyenlieuBH.AutoSize = true;
		checkBoxNguyenlieuBH.ForeColor = System.Drawing.Color.Black;
		checkBoxNguyenlieuBH.Location = new System.Drawing.Point(12, 108);
		checkBoxNguyenlieuBH.Name = "checkBoxNguyenlieuBH";
		checkBoxNguyenlieuBH.Size = new System.Drawing.Size(281, 17);
		checkBoxNguyenlieuBH.TabIndex = 13;
		checkBoxNguyenlieuBH.Text = "Có lấy nguyên liệu trong rương bang hội đem chế tạo";
		checkBoxNguyenlieuBH.UseVisualStyleBackColor = true;
		checkBoxNguyenlieuBH.CheckedChanged += new System.EventHandler(checkBoxNguyenlieuBH_CheckedChanged);
		checkBoxC3.AutoSize = true;
		checkBoxC3.Location = new System.Drawing.Point(12, 76);
		checkBoxC3.Name = "checkBoxC3";
		checkBoxC3.Size = new System.Drawing.Size(78, 17);
		checkBoxC3.TabIndex = 3;
		checkBoxC3.Text = "Cấp 3 -> 4";
		checkBoxC3.UseVisualStyleBackColor = true;
		checkBoxC3.CheckedChanged += new System.EventHandler(checkBoxC3_CheckedChanged);
		checkBoxC9.AutoSize = true;
		checkBoxC9.Location = new System.Drawing.Point(202, 76);
		checkBoxC9.Name = "checkBoxC9";
		checkBoxC9.Size = new System.Drawing.Size(84, 17);
		checkBoxC9.TabIndex = 9;
		checkBoxC9.Text = "Cấp 9 -> 10";
		checkBoxC9.UseVisualStyleBackColor = true;
		checkBoxC9.CheckedChanged += new System.EventHandler(checkBoxC9_CheckedChanged);
		checkBoxC6.AutoSize = true;
		checkBoxC6.Location = new System.Drawing.Point(104, 76);
		checkBoxC6.Name = "checkBoxC6";
		checkBoxC6.Size = new System.Drawing.Size(78, 17);
		checkBoxC6.TabIndex = 6;
		checkBoxC6.Text = "Cấp 6 -> 7";
		checkBoxC6.UseVisualStyleBackColor = true;
		checkBoxC6.CheckedChanged += new System.EventHandler(checkBoxC6_CheckedChanged);
		buttonBatdauNangcap.Location = new System.Drawing.Point(68, 190);
		buttonBatdauNangcap.Name = "buttonBatdauNangcap";
		buttonBatdauNangcap.Size = new System.Drawing.Size(80, 36);
		buttonBatdauNangcap.TabIndex = 10;
		buttonBatdauNangcap.Text = "Bắt đầu nâng cấp";
		buttonBatdauNangcap.UseVisualStyleBackColor = true;
		buttonBatdauNangcap.Click += new System.EventHandler(buttonBatdauNangcap_Click);
		checkBoxC4.AutoSize = true;
		checkBoxC4.Location = new System.Drawing.Point(104, 30);
		checkBoxC4.Name = "checkBoxC4";
		checkBoxC4.Size = new System.Drawing.Size(78, 17);
		checkBoxC4.TabIndex = 4;
		checkBoxC4.Text = "Cấp 4 -> 5";
		checkBoxC4.UseVisualStyleBackColor = true;
		checkBoxC4.CheckedChanged += new System.EventHandler(checkBoxC4_CheckedChanged);
		checkBoxC2.AutoSize = true;
		checkBoxC2.Location = new System.Drawing.Point(12, 53);
		checkBoxC2.Name = "checkBoxC2";
		checkBoxC2.Size = new System.Drawing.Size(78, 17);
		checkBoxC2.TabIndex = 2;
		checkBoxC2.Text = "Cấp 2 -> 3";
		checkBoxC2.UseVisualStyleBackColor = true;
		checkBoxC2.CheckedChanged += new System.EventHandler(checkBoxC2_CheckedChanged);
		checkBoxC5.AutoSize = true;
		checkBoxC5.Location = new System.Drawing.Point(104, 53);
		checkBoxC5.Name = "checkBoxC5";
		checkBoxC5.Size = new System.Drawing.Size(78, 17);
		checkBoxC5.TabIndex = 5;
		checkBoxC5.Text = "Cấp 5 -> 6";
		checkBoxC5.UseVisualStyleBackColor = true;
		checkBoxC5.CheckedChanged += new System.EventHandler(checkBoxC5_CheckedChanged);
		textBoxHT.BackColor = System.Drawing.SystemColors.Control;
		textBoxHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
		textBoxHT.Location = new System.Drawing.Point(6, 161);
		textBoxHT.Name = "textBoxHT";
		textBoxHT.Size = new System.Drawing.Size(310, 14);
		textBoxHT.TabIndex = 13;
		textBoxHT.Text = "Thông tin: ...";
		groupBoxNangCap.Controls.Add(checkBoxC8);
		groupBoxNangCap.Controls.Add(checkBoxC7);
		groupBoxNangCap.Controls.Add(checkBoxC1);
		groupBoxNangCap.Controls.Add(checkBoxNguyenlieuBH);
		groupBoxNangCap.Controls.Add(checkBoxC5);
		groupBoxNangCap.Controls.Add(checkBoxC3);
		groupBoxNangCap.Controls.Add(checkBoxC2);
		groupBoxNangCap.Controls.Add(checkBoxC9);
		groupBoxNangCap.Controls.Add(checkBoxC4);
		groupBoxNangCap.Controls.Add(checkBoxC6);
		groupBoxNangCap.Location = new System.Drawing.Point(6, 12);
		groupBoxNangCap.Name = "groupBoxNangCap";
		groupBoxNangCap.Size = new System.Drawing.Size(310, 143);
		groupBoxNangCap.TabIndex = 166;
		groupBoxNangCap.TabStop = false;
		groupBoxNangCap.Text = "CHẾ TẠO VÀ NÂNG CẤP HUYỀN TINH";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(324, 275);
		base.Controls.Add(groupBoxNangCap);
		base.Controls.Add(buttonDungChetao);
		base.Controls.Add(linkLabelHDHT);
		base.Controls.Add(linkLabelPhimCheTaoHT);
		base.Controls.Add(buttonChetaoHuyentinh);
		base.Controls.Add(buttonClose);
		base.Controls.Add(textBoxHT);
		base.Controls.Add(buttonStopNangcapHT);
		base.Controls.Add(buttonBatdauNangcap);
		Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormHuyenTinh";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "HUYEN TINH";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormHuyenTinh_Load);
		groupBoxNangCap.ResumeLayout(performLayout: false);
		groupBoxNangCap.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormHuyenTinh()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void FormHuyenTinh_Load(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (0 <= num)
		{
			GStruct42 gStruct = FormMain.gstruct42_0[num];
			if (gStruct.byte_0[0] > 0)
			{
				textBoxHT.Text = "Đang tiến hành nâng cấp huyền tinh...";
			}
			else if (gStruct.bool_10)
			{
				textBoxHT.Text = "Đang tiến hành chế tạo huyền tinh...";
			}
			checkBoxNguyenlieuBH.Checked = (Class21.int_1 > 0);
			method_0(gStruct.byte_0);
		}
		else
		{
			groupBoxNangCap.Enabled = false;
			buttonBatdauNangcap.Enabled = false;
			buttonChetaoHuyentinh.Enabled = false;
			textBoxHT.Text = "Chưa chọn ac nào, hãy chọn 1 ac rồi vào đây thiết lập";
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
	}

	private void method_0(byte[] byte_0)
	{
		buttonBatdauNangcap.Enabled = (byte_0[0] == 0);
		checkBoxC1.Checked = (byte_0[1] > 0);
		checkBoxC2.Checked = (byte_0[2] > 0);
		checkBoxC3.Checked = (byte_0[3] > 0);
		checkBoxC4.Checked = (byte_0[4] > 0);
		checkBoxC5.Checked = (byte_0[5] > 0);
		checkBoxC6.Checked = (byte_0[6] > 0);
		checkBoxC7.Checked = (byte_0[7] > 0);
		checkBoxC8.Checked = (byte_0[8] > 0);
		checkBoxC9.Checked = (byte_0[9] > 0);
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int_0 = 0;
		bool_0 = false;
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

	private void buttonStopNangcapHT_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			FormMain.gstruct42_0[num].byte_0[0] = 0;
			buttonBatdauNangcap.Enabled = true;
			textBoxHT.Text = "Kết thúc nâng cấp!";
		}
	}

	private void buttonBatdauNangcap_Click(object sender, EventArgs e)
	{
		if (Class21.int_0 <= 0)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				buttonBatdauNangcap.Enabled = false;
				FormMain.gstruct42_0[num].byte_0[0] = 1;
				Class21.int_0 = FormMain.gstruct42_0[num].int_129;
				textBoxHT.Text = "Đang tiến hành nâng cấp huyền tinh...";
				new Thread(new Class21().method_0).Start();
			}
		}
	}

	private void buttonChetaoHuyentinh_Click(object sender, EventArgs e)
	{
		if (Class21.int_0 <= 0)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				textBoxHT.Text = "Đang tiến hành chế tạo huyền tinh...";
				Class21.int_0 = FormMain.gstruct42_0[num].int_129;
				new Thread(new Class21().method_1).Start();
			}
		}
	}

	private void buttonDungChetao_Click(object sender, EventArgs e)
	{
		if (Class21.int_0 <= 0)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].bool_10 = false;
				textBoxHT.Text = "Kết thúc chế tạo.";
			}
		}
	}

	private void checkBoxNguyenlieuBH_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class21.int_1 = Convert.ToByte(checkBoxNguyenlieuBH.Checked);
			Class55.smethod_10(Class47.string_0, "flagNguyenlieuBH", Class21.int_1, "", 0);
		}
	}

	private void checkBoxC1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].byte_0[1] = Convert.ToByte(checkBoxC1.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxC2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].byte_0[2] = Convert.ToByte(checkBoxC2.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxC3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].byte_0[3] = Convert.ToByte(checkBoxC3.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxC4_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].byte_0[4] = Convert.ToByte(checkBoxC4.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxC5_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].byte_0[5] = Convert.ToByte(checkBoxC5.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxC6_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].byte_0[6] = Convert.ToByte(checkBoxC6.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxC7_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].byte_0[7] = Convert.ToByte(checkBoxC7.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxC8_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].byte_0[8] = Convert.ToByte(checkBoxC8.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxC9_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].byte_0[9] = Convert.ToByte(checkBoxC9.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void linkLabelPhimCheTaoHT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://youtu.be/LLMBuNwXzLw";
		Class11.string_14 = new string[1]
		{
			"Xem video hướng dẫn tại: " + text
		};
		Class20.smethod_40(Class55.smethod_0(), "", text, 0);
	}

	private void linkLabelHDHT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = "=========================================|CHẾ TẠO HUYỀN TINH KHÔNG CẦN VỀ THÀNH|=========================================||Yêu cầu: Phải có đủ ngân lượng và nguyên liệu (nhẫn, dây chuyền, ngọc bội) được đặt ở Hành trang hoặc rương bang hội.||Chức năng tự chế tạo Huyền tinh ở mục train được thực hiện khi thỏa điều kiện:||- Đang check vào mục train.|- Đang ở nơi chiến đấu hoặc là đang ở chế độ lượm rác|Sau mỗi 60 giây auto sẽ kiểm tra và thực hiện chế tạo 1 lần.||=========================================|NÂNG CẤP HUYỀN TINH|=========================================|Yêu cầu: Mở sẵn bảng chế tạo tại thợ rèn (sau đó tắt đi cũng được). Nếu không mở thì game sẽ báo lỗi phi pháp.|";
		FormTip.smethod_0(FormMain.string_1, string_, 600000, 420, 340, bool_5: false, base.Left, base.Top);
	}
}
