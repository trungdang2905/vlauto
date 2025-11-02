using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormTuychon : Form
{
	private IContainer icontainer_0 = null;

	private TextBox textBoxGiaiBua;

	private CheckBox checkBoxDinhbangsat;

	private Timer timer_0;

	private CheckBox checkBoxTheoBua;

	private CheckBox checkBoxTheoThoigian;

	private TextBox textBoxThoigianGiaibua;

	private Button buttonApdungAll;

	private CheckBox checkBoxApdungAllThoigian;

	private GroupBox groupBox1;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Label label2;

	private ComboBox comboBoxPhim;

	private CheckBox checkBoxBamphim;

	private TabPage tabPage3;

	private CheckBox checkBoxTutimMuctieu;

	private TabPage tabPage4;

	private RichTextBox richTextBox1;

	private Button buttonApdung;

	private CheckBox checkBoxBossTruocNguoiSau;

	private CheckBox checkBoxChetNamImAll;

	private TabPage tabPage6;

	private GroupBox groupBox2;

	private CheckBox checkBoxBosPhongTan;

	private CheckBox checkBoxBosKenhBang;

	private CheckBox checkBoxBosKenhKhac;

	private RichTextBox richTextBox2;

	private TextBox textBoxBosGiay;

	private Label label4;

	private TabPage tabPage5;

	private TabPage tabPage7;

	private CheckBox checkBoxMuaNoiChiendau;

	private RichTextBox richTextBoxLuuY;

	private ComboBox comboBox3;

	private Label label5;

	private ComboBox comboBox2;

	private Label label3;

	private ComboBox comboBox1;

	private Label label1;

	private CheckBox checkBoxChiTiet;

	private TabPage tabPage8;

	private Label label8;

	private Label label7;

	private Label label6;

	private CheckBox checkBoxQuangThuoc;

	private CheckBox checkBoxTDP;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static int int_2 = 0;

	private Struct25[] struct25_0 = null;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormTuychon));
		textBoxGiaiBua = new System.Windows.Forms.TextBox();
		checkBoxDinhbangsat = new System.Windows.Forms.CheckBox();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		checkBoxTheoBua = new System.Windows.Forms.CheckBox();
		checkBoxTheoThoigian = new System.Windows.Forms.CheckBox();
		textBoxThoigianGiaibua = new System.Windows.Forms.TextBox();
		buttonApdungAll = new System.Windows.Forms.Button();
		checkBoxApdungAllThoigian = new System.Windows.Forms.CheckBox();
		groupBox1 = new System.Windows.Forms.GroupBox();
		tabControl1 = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		tabPage2 = new System.Windows.Forms.TabPage();
		richTextBox2 = new System.Windows.Forms.RichTextBox();
		label2 = new System.Windows.Forms.Label();
		comboBoxPhim = new System.Windows.Forms.ComboBox();
		checkBoxBamphim = new System.Windows.Forms.CheckBox();
		tabPage3 = new System.Windows.Forms.TabPage();
		checkBoxChetNamImAll = new System.Windows.Forms.CheckBox();
		checkBoxBossTruocNguoiSau = new System.Windows.Forms.CheckBox();
		checkBoxTutimMuctieu = new System.Windows.Forms.CheckBox();
		tabPage4 = new System.Windows.Forms.TabPage();
		buttonApdung = new System.Windows.Forms.Button();
		richTextBox1 = new System.Windows.Forms.RichTextBox();
		tabPage5 = new System.Windows.Forms.TabPage();
		tabPage6 = new System.Windows.Forms.TabPage();
		checkBoxChiTiet = new System.Windows.Forms.CheckBox();
		textBoxBosGiay = new System.Windows.Forms.TextBox();
		label4 = new System.Windows.Forms.Label();
		groupBox2 = new System.Windows.Forms.GroupBox();
		checkBoxBosPhongTan = new System.Windows.Forms.CheckBox();
		checkBoxBosKenhBang = new System.Windows.Forms.CheckBox();
		checkBoxBosKenhKhac = new System.Windows.Forms.CheckBox();
		tabPage7 = new System.Windows.Forms.TabPage();
		comboBox3 = new System.Windows.Forms.ComboBox();
		label5 = new System.Windows.Forms.Label();
		comboBox2 = new System.Windows.Forms.ComboBox();
		label3 = new System.Windows.Forms.Label();
		comboBox1 = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		richTextBoxLuuY = new System.Windows.Forms.RichTextBox();
		checkBoxMuaNoiChiendau = new System.Windows.Forms.CheckBox();
		tabPage8 = new System.Windows.Forms.TabPage();
		label8 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		checkBoxQuangThuoc = new System.Windows.Forms.CheckBox();
		checkBoxTDP = new System.Windows.Forms.CheckBox();
		groupBox1.SuspendLayout();
		tabControl1.SuspendLayout();
		tabPage1.SuspendLayout();
		tabPage2.SuspendLayout();
		tabPage3.SuspendLayout();
		tabPage4.SuspendLayout();
		tabPage6.SuspendLayout();
		groupBox2.SuspendLayout();
		tabPage7.SuspendLayout();
		tabPage8.SuspendLayout();
		SuspendLayout();
		textBoxGiaiBua.Location = new System.Drawing.Point(257, 7);
		textBoxGiaiBua.Name = "textBoxGiaiBua";
		textBoxGiaiBua.Size = new System.Drawing.Size(50, 20);
		textBoxGiaiBua.TabIndex = 169;
		textBoxGiaiBua.TextChanged += new System.EventHandler(textBoxGiaiBua_TextChanged);
		checkBoxDinhbangsat.AutoSize = true;
		checkBoxDinhbangsat.Location = new System.Drawing.Point(6, 58);
		checkBoxDinhbangsat.Name = "checkBoxDinhbangsat";
		checkBoxDinhbangsat.Size = new System.Drawing.Size(278, 17);
		checkBoxDinhbangsat.TabIndex = 2;
		checkBoxDinhbangsat.Text = "Tự xuất 120 khi bị đứng hình do dính băng sát, bẫy...";
		checkBoxDinhbangsat.UseVisualStyleBackColor = true;
		checkBoxDinhbangsat.CheckedChanged += new System.EventHandler(checkBoxDinhbangsat_CheckedChanged);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		checkBoxTheoBua.AutoSize = true;
		checkBoxTheoBua.Location = new System.Drawing.Point(6, 9);
		checkBoxTheoBua.Name = "checkBoxTheoBua";
		checkBoxTheoBua.Size = new System.Drawing.Size(251, 17);
		checkBoxTheoBua.TabIndex = 3;
		checkBoxTheoBua.Text = "Tự xuất skill 120 khi bị bùa, độc... sau (mili giây)";
		checkBoxTheoBua.UseVisualStyleBackColor = true;
		checkBoxTheoBua.CheckedChanged += new System.EventHandler(checkBoxTheoBua_CheckedChanged);
		checkBoxTheoThoigian.AutoSize = true;
		checkBoxTheoThoigian.Location = new System.Drawing.Point(6, 34);
		checkBoxTheoThoigian.Name = "checkBoxTheoThoigian";
		checkBoxTheoThoigian.Size = new System.Drawing.Size(228, 17);
		checkBoxTheoThoigian.TabIndex = 170;
		checkBoxTheoThoigian.Text = "Hoặc xuất skill 120 theo thời gian (mili giây)";
		checkBoxTheoThoigian.UseVisualStyleBackColor = true;
		checkBoxTheoThoigian.CheckedChanged += new System.EventHandler(checkBoxTheoThoigian_CheckedChanged);
		textBoxThoigianGiaibua.Location = new System.Drawing.Point(257, 31);
		textBoxThoigianGiaibua.Name = "textBoxThoigianGiaibua";
		textBoxThoigianGiaibua.Size = new System.Drawing.Size(50, 20);
		textBoxThoigianGiaibua.TabIndex = 171;
		textBoxThoigianGiaibua.TextChanged += new System.EventHandler(textBoxThoigianGiaibua_TextChanged);
		buttonApdungAll.Location = new System.Drawing.Point(184, 14);
		buttonApdungAll.Name = "buttonApdungAll";
		buttonApdungAll.Size = new System.Drawing.Size(111, 40);
		buttonApdungAll.TabIndex = 172;
		buttonApdungAll.Text = "Áp dụng cho tất cả ac Võ đang";
		buttonApdungAll.UseVisualStyleBackColor = true;
		buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		checkBoxApdungAllThoigian.Checked = true;
		checkBoxApdungAllThoigian.CheckState = System.Windows.Forms.CheckState.Checked;
		checkBoxApdungAllThoigian.Location = new System.Drawing.Point(6, 19);
		checkBoxApdungAllThoigian.Name = "checkBoxApdungAllThoigian";
		checkBoxApdungAllThoigian.Size = new System.Drawing.Size(174, 33);
		checkBoxApdungAllThoigian.TabIndex = 173;
		checkBoxApdungAllThoigian.Text = "Không áp dụng cho tất cả ac phần thời gian (mili giây)";
		checkBoxApdungAllThoigian.UseVisualStyleBackColor = true;
		groupBox1.Controls.Add(buttonApdungAll);
		groupBox1.Controls.Add(checkBoxApdungAllThoigian);
		groupBox1.Location = new System.Drawing.Point(3, 84);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(306, 63);
		groupBox1.TabIndex = 174;
		groupBox1.TabStop = false;
		groupBox1.Text = "Áp dụng tất cả Võ đang";
		tabControl1.Controls.Add(tabPage1);
		tabControl1.Controls.Add(tabPage2);
		tabControl1.Controls.Add(tabPage3);
		tabControl1.Controls.Add(tabPage4);
		tabControl1.Controls.Add(tabPage5);
		tabControl1.Controls.Add(tabPage6);
		tabControl1.Controls.Add(tabPage7);
		tabControl1.Controls.Add(tabPage8);
		tabControl1.Location = new System.Drawing.Point(1, 1);
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size(321, 177);
		tabControl1.TabIndex = 175;
		tabPage1.Controls.Add(checkBoxTheoThoigian);
		tabPage1.Controls.Add(groupBox1);
		tabPage1.Controls.Add(checkBoxDinhbangsat);
		tabPage1.Controls.Add(textBoxThoigianGiaibua);
		tabPage1.Controls.Add(checkBoxTheoBua);
		tabPage1.Controls.Add(textBoxGiaiBua);
		tabPage1.Location = new System.Drawing.Point(4, 22);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding(3);
		tabPage1.Size = new System.Drawing.Size(313, 151);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "VĐ";
		tabPage1.UseVisualStyleBackColor = true;
		tabPage2.Controls.Add(richTextBox2);
		tabPage2.Controls.Add(label2);
		tabPage2.Controls.Add(comboBoxPhim);
		tabPage2.Controls.Add(checkBoxBamphim);
		tabPage2.Location = new System.Drawing.Point(4, 22);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding(3);
		tabPage2.Size = new System.Drawing.Size(313, 151);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "TN";
		tabPage2.UseVisualStyleBackColor = true;
		richTextBox2.Location = new System.Drawing.Point(3, 3);
		richTextBox2.Name = "richTextBox2";
		richTextBox2.Size = new System.Drawing.Size(307, 96);
		richTextBox2.TabIndex = 23;
		//richTextBox2.Text = componentResourceManager.GetString("richTextBox2.Text");
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(224, 109);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(83, 13);
		label2.TabIndex = 22;
		label2.Text = "phím xuất chiêu";
		comboBoxPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxPhim.FormattingEnabled = true;
		comboBoxPhim.Location = new System.Drawing.Point(241, 125);
		comboBoxPhim.Name = "comboBoxPhim";
		comboBoxPhim.Size = new System.Drawing.Size(52, 21);
		comboBoxPhim.TabIndex = 20;
		comboBoxPhim.SelectedIndexChanged += new System.EventHandler(comboBoxPhim_SelectedIndexChanged);
		checkBoxBamphim.Location = new System.Drawing.Point(3, 107);
		checkBoxBamphim.Name = "checkBoxBamphim";
		checkBoxBamphim.Size = new System.Drawing.Size(193, 41);
		checkBoxBamphim.TabIndex = 19;
		checkBoxBamphim.Text = "Bấm phím để TN xuất chiêu theo vị trí chuột của ac chính";
		checkBoxBamphim.UseVisualStyleBackColor = true;
		checkBoxBamphim.CheckedChanged += new System.EventHandler(checkBoxBamphim_CheckedChanged);
		tabPage3.Controls.Add(checkBoxChetNamImAll);
		tabPage3.Controls.Add(checkBoxBossTruocNguoiSau);
		tabPage3.Controls.Add(checkBoxTutimMuctieu);
		tabPage3.Location = new System.Drawing.Point(4, 22);
		tabPage3.Name = "tabPage3";
		tabPage3.Padding = new System.Windows.Forms.Padding(3);
		tabPage3.Size = new System.Drawing.Size(313, 151);
		tabPage3.TabIndex = 2;
		tabPage3.Text = "Kiểu";
		tabPage3.UseVisualStyleBackColor = true;
		checkBoxChetNamImAll.AutoSize = true;
		checkBoxChetNamImAll.BackColor = System.Drawing.SystemColors.Control;
		checkBoxChetNamImAll.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		checkBoxChetNamImAll.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxChetNamImAll.Location = new System.Drawing.Point(6, 97);
		checkBoxChetNamImAll.Name = "checkBoxChetNamImAll";
		checkBoxChetNamImAll.Size = new System.Drawing.Size(175, 17);
		checkBoxChetNamImAll.TabIndex = 349;
		checkBoxChetNamImAll.Text = "Áp dụng toàn cục cho tất cả ac";
		checkBoxChetNamImAll.UseVisualStyleBackColor = false;
		checkBoxChetNamImAll.CheckedChanged += new System.EventHandler(checkBoxChetNamImAll_CheckedChanged);
		checkBoxBossTruocNguoiSau.BackColor = System.Drawing.SystemColors.Control;
		checkBoxBossTruocNguoiSau.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxBossTruocNguoiSau.Location = new System.Drawing.Point(6, 3);
		checkBoxBossTruocNguoiSau.Name = "checkBoxBossTruocNguoiSau";
		checkBoxBossTruocNguoiSau.Size = new System.Drawing.Size(217, 37);
		checkBoxBossTruocNguoiSau.TabIndex = 348;
		checkBoxBossTruocNguoiSau.Text = "Ưu tiên đánh boss trước, đánh người sau";
		checkBoxBossTruocNguoiSau.UseVisualStyleBackColor = false;
		checkBoxBossTruocNguoiSau.CheckedChanged += new System.EventHandler(checkBoxBossTruocNguoiSau_CheckedChanged);
		checkBoxTutimMuctieu.BackColor = System.Drawing.SystemColors.Control;
		checkBoxTutimMuctieu.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxTutimMuctieu.Location = new System.Drawing.Point(7, 49);
		checkBoxTutimMuctieu.Name = "checkBoxTutimMuctieu";
		checkBoxTutimMuctieu.Size = new System.Drawing.Size(216, 33);
		checkBoxTutimMuctieu.TabIndex = 336;
		checkBoxTutimMuctieu.Text = "Nếu ac chính không có mục tiêu thì ac phụ tự tìm mục tiêu để đánh";
		checkBoxTutimMuctieu.UseVisualStyleBackColor = false;
		checkBoxTutimMuctieu.CheckedChanged += new System.EventHandler(checkBoxTutimMuctieu_CheckedChanged);
		tabPage4.Controls.Add(buttonApdung);
		tabPage4.Controls.Add(richTextBox1);
		tabPage4.Location = new System.Drawing.Point(4, 22);
		tabPage4.Name = "tabPage4";
		tabPage4.Padding = new System.Windows.Forms.Padding(3);
		tabPage4.Size = new System.Drawing.Size(313, 151);
		tabPage4.TabIndex = 3;
		tabPage4.Text = "KhCách";
		tabPage4.UseVisualStyleBackColor = true;
		buttonApdung.ForeColor = System.Drawing.Color.DarkRed;
		buttonApdung.Location = new System.Drawing.Point(30, 127);
		buttonApdung.Name = "buttonApdung";
		buttonApdung.Size = new System.Drawing.Size(257, 23);
		buttonApdung.TabIndex = 6;
		buttonApdung.Text = "Áp dụng kiểu đánh khoảng cách tất cả ac";
		buttonApdung.UseVisualStyleBackColor = true;
		buttonApdung.Click += new System.EventHandler(buttonApdung_Click);
		richTextBox1.Location = new System.Drawing.Point(3, 0);
		richTextBox1.Name = "richTextBox1";
		richTextBox1.Size = new System.Drawing.Size(310, 123);
		richTextBox1.TabIndex = 5;
		//richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
		tabPage5.Location = new System.Drawing.Point(4, 22);
		tabPage5.Name = "tabPage5";
		tabPage5.Padding = new System.Windows.Forms.Padding(3);
		tabPage5.Size = new System.Drawing.Size(313, 151);
		tabPage5.TabIndex = 4;
		tabPage5.Text = "Sửa đồ";
		tabPage5.UseVisualStyleBackColor = true;
		tabPage6.Controls.Add(checkBoxChiTiet);
		tabPage6.Controls.Add(textBoxBosGiay);
		tabPage6.Controls.Add(label4);
		tabPage6.Controls.Add(groupBox2);
		tabPage6.Location = new System.Drawing.Point(4, 22);
		tabPage6.Name = "tabPage6";
		tabPage6.Padding = new System.Windows.Forms.Padding(3);
		tabPage6.Size = new System.Drawing.Size(313, 151);
		tabPage6.TabIndex = 5;
		tabPage6.Text = "Báo";
		tabPage6.UseVisualStyleBackColor = true;
		checkBoxChiTiet.AutoSize = true;
		checkBoxChiTiet.Location = new System.Drawing.Point(7, 127);
		checkBoxChiTiet.Name = "checkBoxChiTiet";
		checkBoxChiTiet.Size = new System.Drawing.Size(138, 17);
		checkBoxChiTiet.TabIndex = 217;
		checkBoxChiTiet.Text = "Báo chi tiết hướng chạy";
		checkBoxChiTiet.UseVisualStyleBackColor = true;
		checkBoxChiTiet.CheckedChanged += new System.EventHandler(checkBoxChiTiet_CheckedChanged);
		textBoxBosGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxBosGiay.ForeColor = System.Drawing.Color.Black;
		textBoxBosGiay.Location = new System.Drawing.Point(118, 104);
		textBoxBosGiay.Name = "textBoxBosGiay";
		textBoxBosGiay.Size = new System.Drawing.Size(39, 20);
		textBoxBosGiay.TabIndex = 221;
		textBoxBosGiay.TextChanged += new System.EventHandler(textBoxBosGiay_TextChanged);
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(4, 107);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(100, 13);
		label4.TabIndex = 222;
		label4.Text = "Thời gian báo (giây)";
		groupBox2.Controls.Add(checkBoxBosPhongTan);
		groupBox2.Controls.Add(checkBoxBosKenhBang);
		groupBox2.Controls.Add(checkBoxBosKenhKhac);
		groupBox2.Location = new System.Drawing.Point(3, 3);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(154, 96);
		groupBox2.TabIndex = 220;
		groupBox2.TabStop = false;
		groupBox2.Text = "Thiết lập chung";
		checkBoxBosPhongTan.AutoSize = true;
		checkBoxBosPhongTan.Location = new System.Drawing.Point(18, 47);
		checkBoxBosPhongTan.Name = "checkBoxBosPhongTan";
		checkBoxBosPhongTan.Size = new System.Drawing.Size(97, 17);
		checkBoxBosPhongTan.TabIndex = 216;
		checkBoxBosPhongTan.Text = "Báo Phòng tán";
		checkBoxBosPhongTan.UseVisualStyleBackColor = true;
		checkBoxBosPhongTan.CheckedChanged += new System.EventHandler(checkBoxBosPhongTan_CheckedChanged);
		checkBoxBosKenhBang.AutoSize = true;
		checkBoxBosKenhBang.Location = new System.Drawing.Point(18, 70);
		checkBoxBosKenhBang.Name = "checkBoxBosKenhBang";
		checkBoxBosKenhBang.Size = new System.Drawing.Size(99, 17);
		checkBoxBosKenhBang.TabIndex = 215;
		checkBoxBosKenhBang.Text = "Báo kênh bang";
		checkBoxBosKenhBang.UseVisualStyleBackColor = true;
		checkBoxBosKenhBang.CheckedChanged += new System.EventHandler(checkBoxBosKenhBang_CheckedChanged);
		checkBoxBosKenhKhac.AutoSize = true;
		checkBoxBosKenhKhac.ForeColor = System.Drawing.Color.DarkBlue;
		checkBoxBosKenhKhac.Location = new System.Drawing.Point(18, 22);
		checkBoxBosKenhKhac.Name = "checkBoxBosKenhKhac";
		checkBoxBosKenhKhac.Size = new System.Drawing.Size(99, 17);
		checkBoxBosKenhKhac.TabIndex = 214;
		checkBoxBosKenhKhac.Text = "Báo kênh khác";
		checkBoxBosKenhKhac.UseVisualStyleBackColor = true;
		checkBoxBosKenhKhac.CheckedChanged += new System.EventHandler(checkBoxBosKenhKhac_CheckedChanged);
		tabPage7.Controls.Add(comboBox3);
		tabPage7.Controls.Add(label5);
		tabPage7.Controls.Add(comboBox2);
		tabPage7.Controls.Add(label3);
		tabPage7.Controls.Add(comboBox1);
		tabPage7.Controls.Add(label1);
		tabPage7.Controls.Add(richTextBoxLuuY);
		tabPage7.Controls.Add(checkBoxMuaNoiChiendau);
		tabPage7.Location = new System.Drawing.Point(4, 22);
		tabPage7.Name = "tabPage7";
		tabPage7.Padding = new System.Windows.Forms.Padding(3);
		tabPage7.Size = new System.Drawing.Size(313, 151);
		tabPage7.TabIndex = 6;
		tabPage7.Text = "KTC";
		tabPage7.UseVisualStyleBackColor = true;
		comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBox3.ForeColor = System.Drawing.Color.DarkRed;
		comboBox3.FormattingEnabled = true;
		comboBox3.Location = new System.Drawing.Point(187, 48);
		comboBox3.Name = "comboBox3";
		comboBox3.Size = new System.Drawing.Size(110, 21);
		comboBox3.TabIndex = 359;
		comboBox3.SelectedIndexChanged += new System.EventHandler(comboBox3_SelectedIndexChanged);
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(4, 53);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(166, 13);
		label5.TabIndex = 358;
		label5.Text = "[ Mua 3 ] trong Bảo vật nằm ở tab";
		comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBox2.ForeColor = System.Drawing.Color.DarkRed;
		comboBox2.FormattingEnabled = true;
		comboBox2.Location = new System.Drawing.Point(187, 25);
		comboBox2.Name = "comboBox2";
		comboBox2.Size = new System.Drawing.Size(110, 21);
		comboBox2.TabIndex = 357;
		comboBox2.SelectedIndexChanged += new System.EventHandler(comboBox2_SelectedIndexChanged);
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(4, 29);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(166, 13);
		label3.TabIndex = 356;
		label3.Text = "[ Mua 2 ] trong Bảo vật nằm ở tab";
		comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBox1.ForeColor = System.Drawing.Color.DarkRed;
		comboBox1.FormattingEnabled = true;
		comboBox1.Location = new System.Drawing.Point(187, 1);
		comboBox1.Name = "comboBox1";
		comboBox1.Size = new System.Drawing.Size(110, 21);
		comboBox1.TabIndex = 355;
		comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(4, 5);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(166, 13);
		label1.TabIndex = 352;
		label1.Text = "[ Mua 1 ] trong Bảo vật nằm ở tab";
		richTextBoxLuuY.BackColor = System.Drawing.SystemColors.Control;
		richTextBoxLuuY.BorderStyle = System.Windows.Forms.BorderStyle.None;
		richTextBoxLuuY.Location = new System.Drawing.Point(7, 111);
		richTextBoxLuuY.Name = "richTextBoxLuuY";
		richTextBoxLuuY.Size = new System.Drawing.Size(300, 33);
		richTextBoxLuuY.TabIndex = 351;
		richTextBoxLuuY.Text = "Lưu ý: các server không mua được ở nơi chiến đấu thì đừng check vào mục tự mua này";
		checkBoxMuaNoiChiendau.BackColor = System.Drawing.SystemColors.Control;
		checkBoxMuaNoiChiendau.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxMuaNoiChiendau.Location = new System.Drawing.Point(5, 76);
		checkBoxMuaNoiChiendau.Name = "checkBoxMuaNoiChiendau";
		checkBoxMuaNoiChiendau.Size = new System.Drawing.Size(302, 30);
		checkBoxMuaNoiChiendau.TabIndex = 349;
		checkBoxMuaNoiChiendau.Text = "Tự mua ở nơi chiến đấu\r\n( khi nút <Tự mở túi thuốc hỗ trợ> đã mở hết túi thuốc)";
		checkBoxMuaNoiChiendau.UseVisualStyleBackColor = false;
		checkBoxMuaNoiChiendau.CheckedChanged += new System.EventHandler(checkBoxMuaNoiChiendau_CheckedChanged);
		tabPage8.Controls.Add(checkBoxTDP);
		tabPage8.Controls.Add(label8);
		tabPage8.Controls.Add(label7);
		tabPage8.Controls.Add(label6);
		tabPage8.Controls.Add(checkBoxQuangThuoc);
		tabPage8.Location = new System.Drawing.Point(4, 22);
		tabPage8.Name = "tabPage8";
		tabPage8.Padding = new System.Windows.Forms.Padding(3);
		tabPage8.Size = new System.Drawing.Size(313, 151);
		tabPage8.TabIndex = 7;
		tabPage8.Text = "Quăng thuốc";
		tabPage8.UseVisualStyleBackColor = true;
		label8.Location = new System.Drawing.Point(99, 4);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(212, 100);
		label8.TabIndex = 215;
		//label8.Text = componentResourceManager.GetString("label8.Text");
		label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		label7.Location = new System.Drawing.Point(11, 27);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(79, 21);
		label7.TabIndex = 214;
		label7.Text = "  CTRL + F1  ";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.ForeColor = System.Drawing.Color.DarkRed;
		label6.Location = new System.Drawing.Point(5, 4);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(80, 13);
		label6.TabIndex = 213;
		label6.Text = "Phím tắt quăng";
		checkBoxQuangThuoc.AutoSize = true;
		checkBoxQuangThuoc.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxQuangThuoc.Location = new System.Drawing.Point(4, 104);
		checkBoxQuangThuoc.Name = "checkBoxQuangThuoc";
		checkBoxQuangThuoc.Size = new System.Drawing.Size(209, 17);
		checkBoxQuangThuoc.TabIndex = 212;
		checkBoxQuangThuoc.Text = "Gặp ac chính thì tự động quăng thuốc";
		checkBoxQuangThuoc.UseVisualStyleBackColor = true;
		checkBoxQuangThuoc.CheckedChanged += new System.EventHandler(checkBoxQuangThuoc_CheckedChanged);
		checkBoxTDP.AutoSize = true;
		checkBoxTDP.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxTDP.Location = new System.Drawing.Point(4, 127);
		checkBoxTDP.Name = "checkBoxTDP";
		checkBoxTDP.Size = new System.Drawing.Size(210, 17);
		checkBoxTDP.TabIndex = 216;
		checkBoxTDP.Text = "Thổ địa phù sau khi quăng thuốc xong";
		checkBoxTDP.UseVisualStyleBackColor = true;
		checkBoxTDP.CheckedChanged += new System.EventHandler(checkBoxTDP_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(324, 179);
		base.Controls.Add(tabControl1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormTuychon";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "TUY CHON";
		base.Load += new System.EventHandler(FormTuychon_Load);
		groupBox1.ResumeLayout(performLayout: false);
		tabControl1.ResumeLayout(performLayout: false);
		tabPage1.ResumeLayout(performLayout: false);
		tabPage1.PerformLayout();
		tabPage2.ResumeLayout(performLayout: false);
		tabPage2.PerformLayout();
		tabPage3.ResumeLayout(performLayout: false);
		tabPage3.PerformLayout();
		tabPage4.ResumeLayout(performLayout: false);
		tabPage6.ResumeLayout(performLayout: false);
		tabPage6.PerformLayout();
		groupBox2.ResumeLayout(performLayout: false);
		groupBox2.PerformLayout();
		tabPage7.ResumeLayout(performLayout: false);
		tabPage7.PerformLayout();
		tabPage8.ResumeLayout(performLayout: false);
		tabPage8.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public FormTuychon()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		if (int_1 <= 0)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (0 <= num)
			{
				FormMain.gstruct42_0[num].int_80 = Convert.ToByte(checkBoxTheoThoigian.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
		if (int_2 > 0)
		{
			int_2 = 2;
		}
		int_0 = 0;
		bool_0 = false;
	}

	private void FormTuychon_Load(object sender, EventArgs e)
	{
		int num = int_1 / 100;
		int num2 = int_1 % 100;
		if (num > 0)
		{
			int_1 = num;
		}
		int_2 = 0;
		tabControl1.SelectedIndex = int_1;
		if (int_1 <= 0)
		{
			int num3 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (0 <= num3)
			{
				GStruct42 gstruct42_ = FormMain.gstruct42_0[num3];
				textBoxGiaiBua.Text = gstruct42_.int_83.ToString();
				checkBoxDinhbangsat.Checked = (gstruct42_.int_79 > 0);
				checkBoxTheoBua.Checked = (gstruct42_.int_80 <= 0);
				checkBoxTheoThoigian.Checked = (gstruct42_.int_80 > 0);
				textBoxThoigianGiaibua.Text = gstruct42_.int_85.ToString();
				checkBoxApdungAllThoigian.Checked = true;
				struct25_0 = Class73.smethod_1(gstruct42_);
			}
			tabControl1.Controls.Remove(tabPage2);
			tabControl1.Controls.Remove(tabPage3);
			tabControl1.Controls.Remove(tabPage4);
			tabControl1.Controls.Remove(tabPage5);
			tabControl1.Controls.Remove(tabPage6);
			tabControl1.Controls.Remove(tabPage7);
			tabControl1.Controls.Remove(tabPage8);
			tabPage1.Text = "Skill 120 Võ Đang";
		}
		else if (int_1 != 1)
		{
			if (int_1 == 2)
			{
				tabControl1.Controls.Remove(tabPage1);
				tabControl1.Controls.Remove(tabPage2);
				tabControl1.Controls.Remove(tabPage4);
				tabControl1.Controls.Remove(tabPage5);
				tabControl1.Controls.Remove(tabPage6);
				tabControl1.Controls.Remove(tabPage7);
				tabControl1.Controls.Remove(tabPage8);
				checkBoxTutimMuctieu.Checked = (FormMain.int_34 > 0);
				checkBoxBossTruocNguoiSau.Checked = (FormMain.int_36 > 0);
				checkBoxChetNamImAll.Checked = (FormMain.int_38 > 0);
				switch (num2)
				{
				case 1:
					tabPage3.Text = "Ưu tiên đánh boss";
					checkBoxBossTruocNguoiSau.Location = new Point(6, 6);
					checkBoxTutimMuctieu.Visible = false;
					checkBoxChetNamImAll.Visible = false;
					break;
				case 3:
					tabPage3.Text = "Chết nằm im";
					checkBoxChetNamImAll.Location = new Point(6, 6);
					checkBoxTutimMuctieu.Visible = false;
					checkBoxBossTruocNguoiSau.Visible = false;
					int_2 = 1;
					break;
				case 2:
					tabPage3.Text = "Mục tiêu";
					checkBoxTutimMuctieu.Location = new Point(6, 6);
					checkBoxBossTruocNguoiSau.Visible = false;
					checkBoxChetNamImAll.Visible = false;
					break;
				}
				tabControl1.Size = new Size(230, 75);
				base.ClientSize = new Size(235, 80);
			}
			else if (int_1 == 3)
			{
				tabControl1.Controls.Remove(tabPage1);
				tabControl1.Controls.Remove(tabPage2);
				tabControl1.Controls.Remove(tabPage3);
				tabControl1.Controls.Remove(tabPage5);
				tabControl1.Controls.Remove(tabPage6);
				tabControl1.Controls.Remove(tabPage7);
				tabControl1.Controls.Remove(tabPage8);
				tabPage4.Text = "Đánh khoảng cách";
			}
			else if (int_1 == 4)
			{
				tabControl1.Controls.Remove(tabPage1);
				tabControl1.Controls.Remove(tabPage2);
				tabControl1.Controls.Remove(tabPage3);
				tabControl1.Controls.Remove(tabPage4);
				tabControl1.Controls.Remove(tabPage6);
				tabControl1.Controls.Remove(tabPage7);
				tabControl1.Controls.Remove(tabPage8);
				tabPage5.Text = "Sửa đồ";
			}
			else if (int_1 != 5)
			{
				if (int_1 == 6)
				{
					tabControl1.Controls.Remove(tabPage1);
					tabControl1.Controls.Remove(tabPage2);
					tabControl1.Controls.Remove(tabPage3);
					tabControl1.Controls.Remove(tabPage4);
					tabControl1.Controls.Remove(tabPage5);
					tabControl1.Controls.Remove(tabPage6);
					tabControl1.Controls.Remove(tabPage8);
					tabPage7.Text = "Kiểu mua thuốc ở Bảo vật (toàn cục)";
					checkBoxMuaNoiChiendau.Checked = (FormMain.int_29 > 0);
					richTextBoxLuuY.Enabled = (FormMain.int_29 > 0);
					if (struct25_0 == null && FormMain.gstruct42_0 != null)
					{
						for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
						{
							struct25_0 = Class73.smethod_1(FormMain.gstruct42_0[i]);
							if (struct25_0 != null)
							{
								break;
							}
						}
					}
					if (Class15.string_0 == null)
					{
						Class15.string_0 = new string[3];
					}
					if (struct25_0 == null)
					{
						if (Class15.string_0[0] != null && Class15.string_0[0] != string.Empty)
						{
							string text = Class10.smethod_1(Class15.string_0[0], 1);
							comboBox1.Items.Add(text);
							comboBox1.Text = text;
						}
						if (Class15.string_0[1] != null && Class15.string_0[1] != string.Empty)
						{
							string text = Class10.smethod_1(Class15.string_0[1], 1);
							comboBox2.Items.Add(text);
							comboBox2.Text = text;
						}
						if (Class15.string_0[2] != null && Class15.string_0[2] != string.Empty)
						{
							string text = Class10.smethod_1(Class15.string_0[2], 1);
							comboBox3.Items.Add(text);
							comboBox3.Text = text;
						}
					}
					else
					{
						bool flag = false;
						bool flag2 = false;
						bool flag3 = false;
						for (int i = 0; i < struct25_0.Length; i++)
						{
							string text = Class10.smethod_1(struct25_0[i].string_0, 1);
							comboBox1.Items.Add(text);
							comboBox2.Items.Add(text);
							comboBox3.Items.Add(text);
							if (struct25_0[i].string_0 == Class15.string_0[0])
							{
								comboBox1.Text = text;
								flag = true;
							}
							if (struct25_0[i].string_0 == Class15.string_0[1])
							{
								comboBox2.Text = text;
								flag2 = true;
							}
							if (struct25_0[i].string_0 == Class15.string_0[2])
							{
								comboBox3.Text = text;
								flag3 = true;
							}
						}
						if (!flag)
						{
							comboBox1.Text = comboBox1.Items[0].ToString();
							Class15.string_0[0] = struct25_0[0].string_0;
							Class55.smethod_10(Class47.string_0, "KTCTabName0", Class11.smethod_17(struct25_0[0].string_0), "", 0);
						}
						if (!flag2)
						{
							comboBox2.Text = comboBox2.Items[0].ToString();
							Class15.string_0[1] = struct25_0[0].string_0;
							Class55.smethod_10(Class47.string_0, "KTCTabName1", Class11.smethod_17(struct25_0[0].string_0), "", 0);
						}
						if (!flag3)
						{
							comboBox3.Text = comboBox3.Items[0].ToString();
							Class15.string_0[2] = struct25_0[0].string_0;
							Class55.smethod_10(Class47.string_0, "KTCTabName2", Class11.smethod_17(struct25_0[0].string_0), "", 0);
						}
					}
				}
				else if (int_1 == 7)
				{
					tabControl1.Controls.Remove(tabPage1);
					tabControl1.Controls.Remove(tabPage2);
					tabControl1.Controls.Remove(tabPage3);
					tabControl1.Controls.Remove(tabPage4);
					tabControl1.Controls.Remove(tabPage5);
					tabControl1.Controls.Remove(tabPage6);
					tabControl1.Controls.Remove(tabPage7);
					tabPage8.Text = "Quăng tiếp thuốc";
					checkBoxQuangThuoc.Checked = (FormMain.int_27 > 0);
					checkBoxTDP.Checked = (FormMain.int_28 > 0);
				}
			}
			else
			{
				tabControl1.Controls.Remove(tabPage1);
				tabControl1.Controls.Remove(tabPage2);
				tabControl1.Controls.Remove(tabPage3);
				tabControl1.Controls.Remove(tabPage4);
				tabControl1.Controls.Remove(tabPage5);
				tabControl1.Controls.Remove(tabPage7);
				tabControl1.Controls.Remove(tabPage8);
				tabPage6.Text = "Báo Boss";
				tabControl1.Size = new Size(170, 175);
				base.ClientSize = new Size(175, 178);
				checkBoxBosKenhKhac.Checked = (Class80.int_0[0] > 0);
				checkBoxBosKenhBang.Checked = (Class80.int_0[2] > 0);
				checkBoxBosPhongTan.Checked = (Class80.int_0[1] > 0);
				textBoxBosGiay.Text = Class80.int_0[3].ToString();
				checkBoxChiTiet.Checked = (Class80.int_1 > 0);
			}
		}
		else
		{
			for (int i = 0; i < Class24.gstruct38_0.Length; i++)
			{
				comboBoxPhim.Items.Add(Class24.gstruct38_0[i].string_0);
			}
			comboBoxPhim.Text = Class24.gstruct38_0[FormMain.int_94].string_0;
			checkBoxBamphim.Checked = (FormMain.int_93 > 0);
			tabControl1.Controls.Remove(tabPage1);
			tabControl1.Controls.Remove(tabPage3);
			tabControl1.Controls.Remove(tabPage4);
			tabControl1.Controls.Remove(tabPage5);
			tabControl1.Controls.Remove(tabPage6);
			tabControl1.Controls.Remove(tabPage7);
			tabControl1.Controls.Remove(tabPage8);
			tabPage2.Text = "Skill 120 Thiên Nhẫn";
		}
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
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

	private void checkBoxDinhbangsat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			buttonApdungAll.Enabled = true;
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_79 = Convert.ToByte(checkBoxDinhbangsat.Checked);
			}
		}
	}

	private void textBoxGiaiBua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			buttonApdungAll.Enabled = true;
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_83 = Class11.smethod_12(textBoxGiaiBua.Text);
			}
		}
	}

	private void checkBoxTheoBua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			checkBoxTheoThoigian.Checked = !checkBoxTheoBua.Checked;
			buttonApdungAll.Enabled = true;
		}
	}

	private void checkBoxTheoThoigian_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			checkBoxTheoBua.Checked = !checkBoxTheoThoigian.Checked;
			buttonApdungAll.Enabled = true;
		}
	}

	private void textBoxThoigianGiaibua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			buttonApdungAll.Enabled = true;
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_85 = Class11.smethod_12(textBoxThoigianGiaibua.Text);
			}
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		if (FormMain.gstruct42_0 == null)
		{
			return;
		}
		int int_ = Class11.smethod_12(textBoxGiaiBua.Text);
		int int_2 = Convert.ToByte(checkBoxTheoThoigian.Checked);
		int int_3 = Class11.smethod_12(textBoxThoigianGiaibua.Text);
		int int_4 = Convert.ToByte(checkBoxDinhbangsat.Checked);
		bool @checked = checkBoxApdungAllThoigian.Checked;
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			string a = Class67.smethod_18(FormMain.gstruct42_0[i]);
			if (a != "VODANG")
			{
				continue;
			}
			int num = Class67.smethod_15(FormMain.gstruct42_0[i], 716u);
			if (num > 0)
			{
				FormMain.gstruct42_0[i].int_80 = int_2;
				FormMain.gstruct42_0[i].int_79 = int_4;
				if (@checked)
				{
					FormMain.gstruct42_0[i].int_83 = int_;
					FormMain.gstruct42_0[i].int_85 = int_3;
				}
			}
		}
		buttonApdungAll.Enabled = false;
	}

	private void checkBoxBamphim_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			FormMain.int_93 = Convert.ToByte(checkBoxBamphim.Checked);
			Class55.smethod_10(Class47.string_0, "flagTNBamPhim", FormMain.int_93, "", 0);
			if (FormMain.int_93 > 0 && FormMain.int_61 <= 0)
			{
				FormMain.int_61 = 1;
				GClass0.smethod_1();
				GClass0.smethod_0();
			}
		}
	}

	private void comboBoxPhim_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = comboBoxPhim.Text;
		int num = 0;
		while (true)
		{
			if (num < Class24.gstruct38_0.Length)
			{
				if (text == Class24.gstruct38_0[num].string_0)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		if (FormMain.int_94 != num)
		{
			FormMain.int_94 = num;
			Class55.smethod_10(Class47.string_0, "TNIdexPhim", FormMain.int_94, "", 0);
		}
	}

	private void checkBoxTutimMuctieu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			FormMain.int_34 = Convert.ToByte(checkBoxTutimMuctieu.Checked);
			Class55.smethod_10(Class47.string_0, "flagTutimMuctieu", FormMain.int_34, "", 0);
		}
	}

	private void buttonApdung_Click(object sender, EventArgs e)
	{
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				FormMain.gstruct42_0[i].int_86 = 0;
				Class47.smethod_11(FormMain.gstruct42_0[i]);
			}
		}
		bool_0 = false;
		Close();
	}

	private void checkBoxBossTruocNguoiSau_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			FormMain.int_36 = Convert.ToByte(checkBoxBossTruocNguoiSau.Checked);
			Class55.smethod_10(Class47.string_0, "BossTruocNguoiSau", FormMain.int_36, "", 0);
		}
	}

	private void checkBoxChetNamImAll_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			FormMain.int_38 = Convert.ToByte(checkBoxChetNamImAll.Checked);
			Class55.smethod_10(Class47.string_0, "fNamImONOFF", FormMain.int_38, "", 0);
		}
	}

	private void checkBoxBosKenhKhac_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class80.int_0[0] = Convert.ToByte(checkBoxBosKenhKhac.Checked);
			Class55.smethod_10(Class47.string_0, "KenhKhac", Class80.int_0[0], "", 0);
		}
	}

	private void checkBoxBosPhongTan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class80.int_0[1] = Convert.ToByte(checkBoxBosPhongTan.Checked);
			Class55.smethod_10(Class47.string_0, "PhongTan", Class80.int_0[1], "", 0);
		}
	}

	private void checkBoxBosKenhBang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class80.int_0[2] = Convert.ToByte(checkBoxBosKenhBang.Checked);
			Class55.smethod_10(Class47.string_0, "KenhBang", Class80.int_0[2], "", 0);
		}
	}

	private void textBoxBosGiay_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class80.int_0[3] = Class11.smethod_12(textBoxBosGiay.Text);
			Class55.smethod_10(Class47.string_0, "BaoTime", Class80.int_0[3], "", 0);
		}
	}

	private void checkBoxMuaNoiChiendau_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			FormMain.int_29 = Convert.ToByte(checkBoxMuaNoiChiendau.Checked);
			Class55.smethod_10(Class47.string_0, "fMuaNoiChiendau", FormMain.int_29, "", 0);
			richTextBoxLuuY.Enabled = (FormMain.int_29 > 0);
		}
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || struct25_0 == null)
		{
			return;
		}
		string text = comboBox1.Text;
		int num = 0;
		while (true)
		{
			if (num < struct25_0.Length)
			{
				string a = Class10.smethod_1(struct25_0[num].string_0, 1);
				if (a == text)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Class15.string_0[0] = struct25_0[num].string_0;
		Class55.smethod_10(Class47.string_0, "KTCTabName0", Class11.smethod_17(struct25_0[num].string_0), "", 0);
	}

	private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || struct25_0 == null)
		{
			return;
		}
		string text = comboBox2.Text;
		int num = 0;
		while (true)
		{
			if (num < struct25_0.Length)
			{
				string a = Class10.smethod_1(struct25_0[num].string_0, 1);
				if (a == text)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Class15.string_0[1] = struct25_0[num].string_0;
		Class55.smethod_10(Class47.string_0, "KTCTabName1", Class11.smethod_17(struct25_0[num].string_0), "", 0);
	}

	private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || struct25_0 == null)
		{
			return;
		}
		string text = comboBox3.Text;
		int num = 0;
		while (true)
		{
			if (num < struct25_0.Length)
			{
				string a = Class10.smethod_1(struct25_0[num].string_0, 1);
				if (a == text)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Class15.string_0[2] = struct25_0[num].string_0;
		Class55.smethod_10(Class47.string_0, "KTCTabName2", Class11.smethod_17(struct25_0[num].string_0), "", 0);
	}

	private void checkBoxChiTiet_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class80.int_1 = Convert.ToByte(checkBoxChiTiet.Checked);
			Class55.smethod_10(Class47.string_0, "Chitiet", Class80.int_1, "", 0);
		}
	}

	private void checkBoxQuangThuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			FormMain.int_27 = Convert.ToByte(checkBoxQuangThuoc.Checked);
			Class55.smethod_10(Class47.string_0, "fQuangThuocAchinh", FormMain.int_27, "", 0);
		}
	}

	private void checkBoxTDP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			FormMain.int_28 = Convert.ToByte(checkBoxTDP.Checked);
			Class55.smethod_10(Class47.string_0, "fQuangThuocTDP", FormMain.int_28, "", 0);
		}
	}
}
