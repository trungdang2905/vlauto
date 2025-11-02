using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormRauria : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Label label8;

	private CheckBox checkBoxAcChihuy;

	private CheckBox checkBoxAcChinhNghelenh;

	private Button buttonHelp;

	private CheckBox checkBoxSuado;

	private CheckBox checkBoxDoiPKTheoAccChinh;

	private CheckBox checkBoxChayNhay;

	private CheckBox checkBoxTroLaiDiemcu;

	private Label label15;

	private TextBox textBoxKhoangCachlenNgua;

	private NumericUpDown numericUpDownKhongdanhCapnho;

	private CheckBox checkBoxKhongdanhCapnho;

	private Label labelBoqua;

	private CheckBox checkBoxBaoCuusat;

	private CheckBox checkBoxKhongChaybo;

	private CheckBox checkBoxKhongDanhAccCungbang;

	private Button buttonThietlapSuado;

	private CheckBox checkBoxTHP_Smdb;

	private Label labelLienthongGiaithich;

	private CheckBox checkBoxBaoCuusatPhucan;

	private Button buttonCacChucNangDkTuxa;

	private CheckBox checkBoxXuongngua;

	private Button buttonDanhsachMayphu;

	private Label label3;

	private CheckBox checkBoxRoom;

	private CheckBox checkBoxKhoaChatmat;

	private NumericUpDown numericUpDownPassword;

	private CheckBox checkBoxPassword;

	private CheckBox checkBoxKhongdanhBang;

	private CheckBox checkBoxLuonDanhbang;

	private ListView listViewKhongDanh;

	private ColumnHeader columnHeader_0;

	private ListView listViewLuonDanh;

	private ColumnHeader columnHeader_1;

	private CheckBox checkBoxKhongdanhAc;

	private ListView listViewKhongdanhAc;

	private ColumnHeader columnHeader_2;

	private Label labelThemPTAcKhongdanh;

	private Label labelXoaAcKhongdanh;

	private Label labelThemAcKhongdanh;

	private Label labelXoaKhongdanh;

	private Label labelThemKhongdanh;

	private Label labelXoaLuondanh;

	private Label labelThemLuondanh;

	private ComboBox comboBoxKhongdanhAc;

	private ComboBox comboBoxKhongDanh;

	private ComboBox comboBoxLuonDanh;

	private CheckBox checkBoxDanhDenchet;

	private TextBox textBoxTiepCan;

	private Label label2;

	private Label labelTiepcan;

	private TextBox textBoxTen;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private GroupBox groupBox1;

	private TabPage tabPageLienMay;

	private ProgressBar progressBar1;

	private Button buttonHuongdan;

	private RichTextBox richTextBoxVitri;

	private RichTextBox richTextBoxStatus;

	private ComboBox comboBoxConnect;

	private GroupBox groupBoxConnect;

	private TextBox textBoxConnectPass;

	private Label label4;

	private Label label6;

	private TextBox textBoxIPConnect;

	private GroupBox groupBoxHientai;

	private Label label1;

	private Label label5;

	private Button buttonRandom;

	private TextBox textBoxPassServer;

	private Button buttonBatdau;

	private Button buttonXoa;

	private Button buttonKetthuc;

	private TabControl tabControlKeoLienmay;

	private TabPage tabPage4;

	private TabPage tabPage5;

	private Button buttonTatFireWall;

	private Label label10;

	private CheckBox checkBoxTHP;

	private Label label11;

	private TextBox textBoxKytuLenh;

	private Label labelThongbao2;

	private Label labelThongbao1;

	private Button buttonCopy;

	private ComboBox comboBoxTabAddr;

	private CheckBox checkBoxThongbaoTHP;

	private Label label7;

	private CheckBox checkBoxBaoCsKenhbang;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static string string_0 = null;

	private static int int_1 = 0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private int int_6 = -1;

	private GStruct42 gstruct42_0 = default(GStruct42);

	private static string[] string_1 = new string[2]
	{
		"Đây là máy chính",
		"Đây là máy phụ"
	};

	private static string string_2 = null;

	private bool bool_1 = false;

	private static int int_7 = -1;

	private static int int_8 = 0;

	private static long long_0 = -1L;

	private static string string_3 = string.Empty;

	private static int int_9 = 5000;

	private static int int_10 = 65000;

	private static int int_11 = 0;

	private static string[] string_4 = null;

	private static string[] string_5 = null;

	private static string[] string_6 = null;

	private static Random random_0 = new Random();

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormRauria));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		label8 = new System.Windows.Forms.Label();
		checkBoxAcChihuy = new System.Windows.Forms.CheckBox();
		checkBoxAcChinhNghelenh = new System.Windows.Forms.CheckBox();
		buttonHelp = new System.Windows.Forms.Button();
		checkBoxSuado = new System.Windows.Forms.CheckBox();
		checkBoxDoiPKTheoAccChinh = new System.Windows.Forms.CheckBox();
		checkBoxChayNhay = new System.Windows.Forms.CheckBox();
		checkBoxTroLaiDiemcu = new System.Windows.Forms.CheckBox();
		label15 = new System.Windows.Forms.Label();
		textBoxKhoangCachlenNgua = new System.Windows.Forms.TextBox();
		numericUpDownKhongdanhCapnho = new System.Windows.Forms.NumericUpDown();
		checkBoxKhongdanhCapnho = new System.Windows.Forms.CheckBox();
		labelBoqua = new System.Windows.Forms.Label();
		checkBoxBaoCuusat = new System.Windows.Forms.CheckBox();
		checkBoxKhongChaybo = new System.Windows.Forms.CheckBox();
		checkBoxKhongDanhAccCungbang = new System.Windows.Forms.CheckBox();
		buttonThietlapSuado = new System.Windows.Forms.Button();
		labelTiepcan = new System.Windows.Forms.Label();
		textBoxTiepCan = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		checkBoxDanhDenchet = new System.Windows.Forms.CheckBox();
		labelThemPTAcKhongdanh = new System.Windows.Forms.Label();
		labelXoaAcKhongdanh = new System.Windows.Forms.Label();
		labelThemAcKhongdanh = new System.Windows.Forms.Label();
		labelXoaKhongdanh = new System.Windows.Forms.Label();
		labelThemKhongdanh = new System.Windows.Forms.Label();
		labelXoaLuondanh = new System.Windows.Forms.Label();
		labelThemLuondanh = new System.Windows.Forms.Label();
		comboBoxKhongdanhAc = new System.Windows.Forms.ComboBox();
		comboBoxKhongDanh = new System.Windows.Forms.ComboBox();
		comboBoxLuonDanh = new System.Windows.Forms.ComboBox();
		checkBoxXuongngua = new System.Windows.Forms.CheckBox();
		checkBoxBaoCuusatPhucan = new System.Windows.Forms.CheckBox();
		checkBoxLuonDanhbang = new System.Windows.Forms.CheckBox();
		checkBoxKhongdanhAc = new System.Windows.Forms.CheckBox();
		labelLienthongGiaithich = new System.Windows.Forms.Label();
		listViewKhongdanhAc = new System.Windows.Forms.ListView();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		checkBoxTHP_Smdb = new System.Windows.Forms.CheckBox();
		checkBoxKhongdanhBang = new System.Windows.Forms.CheckBox();
		listViewKhongDanh = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		listViewLuonDanh = new System.Windows.Forms.ListView();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		textBoxTen = new System.Windows.Forms.TextBox();
		numericUpDownPassword = new System.Windows.Forms.NumericUpDown();
		checkBoxKhoaChatmat = new System.Windows.Forms.CheckBox();
		checkBoxRoom = new System.Windows.Forms.CheckBox();
		checkBoxPassword = new System.Windows.Forms.CheckBox();
		label3 = new System.Windows.Forms.Label();
		buttonDanhsachMayphu = new System.Windows.Forms.Button();
		buttonCacChucNangDkTuxa = new System.Windows.Forms.Button();
		tabControl1 = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		groupBox1 = new System.Windows.Forms.GroupBox();
		checkBoxBaoCsKenhbang = new System.Windows.Forms.CheckBox();
		checkBoxThongbaoTHP = new System.Windows.Forms.CheckBox();
		checkBoxTHP = new System.Windows.Forms.CheckBox();
		tabPageLienMay = new System.Windows.Forms.TabPage();
		tabControlKeoLienmay = new System.Windows.Forms.TabControl();
		tabPage4 = new System.Windows.Forms.TabPage();
		label7 = new System.Windows.Forms.Label();
		buttonTatFireWall = new System.Windows.Forms.Button();
		progressBar1 = new System.Windows.Forms.ProgressBar();
		buttonHuongdan = new System.Windows.Forms.Button();
		richTextBoxVitri = new System.Windows.Forms.RichTextBox();
		buttonKetthuc = new System.Windows.Forms.Button();
		buttonXoa = new System.Windows.Forms.Button();
		buttonBatdau = new System.Windows.Forms.Button();
		groupBoxHientai = new System.Windows.Forms.GroupBox();
		buttonCopy = new System.Windows.Forms.Button();
		comboBoxTabAddr = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		buttonRandom = new System.Windows.Forms.Button();
		textBoxPassServer = new System.Windows.Forms.TextBox();
		groupBoxConnect = new System.Windows.Forms.GroupBox();
		textBoxConnectPass = new System.Windows.Forms.TextBox();
		label4 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		textBoxIPConnect = new System.Windows.Forms.TextBox();
		richTextBoxStatus = new System.Windows.Forms.RichTextBox();
		comboBoxConnect = new System.Windows.Forms.ComboBox();
		tabPage5 = new System.Windows.Forms.TabPage();
		label11 = new System.Windows.Forms.Label();
		textBoxKytuLenh = new System.Windows.Forms.TextBox();
		label10 = new System.Windows.Forms.Label();
		labelThongbao2 = new System.Windows.Forms.Label();
		labelThongbao1 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)numericUpDownKhongdanhCapnho).BeginInit();
		((System.ComponentModel.ISupportInitialize)numericUpDownPassword).BeginInit();
		tabControl1.SuspendLayout();
		tabPage1.SuspendLayout();
		groupBox1.SuspendLayout();
		tabPageLienMay.SuspendLayout();
		tabControlKeoLienmay.SuspendLayout();
		tabPage4.SuspendLayout();
		groupBoxHientai.SuspendLayout();
		groupBoxConnect.SuspendLayout();
		tabPage5.SuspendLayout();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		label8.ForeColor = System.Drawing.Color.Black;
		label8.Location = new System.Drawing.Point(135, 5);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(310, 30);
		label8.TabIndex = 267;
		label8.Text = "Tất cả ac ở máy phụ đều sẽ tìm theo ac chính ở máy chính. \r\nAc chính máy phụ nên cho theo sau ac chính máy chính";
		checkBoxAcChihuy.AutoSize = true;
		checkBoxAcChihuy.ForeColor = System.Drawing.Color.DarkGreen;
		checkBoxAcChihuy.Location = new System.Drawing.Point(4, 40);
		checkBoxAcChihuy.Name = "checkBoxAcChihuy";
		checkBoxAcChihuy.Size = new System.Drawing.Size(343, 17);
		checkBoxAcChihuy.TabIndex = 264;
		checkBoxAcChihuy.Text = "Đây là ac báo vị trí của máy chính (máy này bạn đang điều khiển).";
		checkBoxAcChihuy.UseVisualStyleBackColor = true;
		checkBoxAcChihuy.CheckedChanged += new System.EventHandler(checkBoxAcChihuy_CheckedChanged);
		checkBoxAcChinhNghelenh.AutoSize = true;
		checkBoxAcChinhNghelenh.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxAcChinhNghelenh.Location = new System.Drawing.Point(4, 5);
		checkBoxAcChinhNghelenh.Name = "checkBoxAcChinhNghelenh";
		checkBoxAcChinhNghelenh.Size = new System.Drawing.Size(99, 17);
		checkBoxAcChinhNghelenh.TabIndex = 265;
		checkBoxAcChinhNghelenh.Text = "Đây là máy phụ";
		checkBoxAcChinhNghelenh.UseVisualStyleBackColor = true;
		checkBoxAcChinhNghelenh.CheckedChanged += new System.EventHandler(checkBoxAcChinhNghelenh_CheckedChanged);
		buttonHelp.ForeColor = System.Drawing.Color.MediumBlue;
		buttonHelp.Location = new System.Drawing.Point(352, 267);
		buttonHelp.Name = "buttonHelp";
		buttonHelp.Size = new System.Drawing.Size(100, 43);
		buttonHelp.TabIndex = 289;
		buttonHelp.Text = "Phim hướng dẫn kiểu 2";
		buttonHelp.UseVisualStyleBackColor = true;
		buttonHelp.Click += new System.EventHandler(buttonHelp_Click);
		checkBoxSuado.AutoSize = true;
		checkBoxSuado.ForeColor = System.Drawing.Color.Black;
		checkBoxSuado.Location = new System.Drawing.Point(7, 222);
		checkBoxSuado.Name = "checkBoxSuado";
		checkBoxSuado.Size = new System.Drawing.Size(110, 17);
		checkBoxSuado.TabIndex = 290;
		checkBoxSuado.Text = "Tự sửa đồ tại chỗ";
		checkBoxSuado.UseVisualStyleBackColor = true;
		checkBoxSuado.CheckedChanged += new System.EventHandler(checkBoxSuado_CheckedChanged);
		checkBoxDoiPKTheoAccChinh.AutoSize = true;
		checkBoxDoiPKTheoAccChinh.ForeColor = System.Drawing.Color.Black;
		checkBoxDoiPKTheoAccChinh.Location = new System.Drawing.Point(7, 26);
		checkBoxDoiPKTheoAccChinh.Name = "checkBoxDoiPKTheoAccChinh";
		checkBoxDoiPKTheoAccChinh.Size = new System.Drawing.Size(127, 17);
		checkBoxDoiPKTheoAccChinh.TabIndex = 294;
		checkBoxDoiPKTheoAccChinh.Text = "Đổi pk theo ac chính";
		checkBoxDoiPKTheoAccChinh.UseVisualStyleBackColor = true;
		checkBoxDoiPKTheoAccChinh.CheckedChanged += new System.EventHandler(checkBoxDoiPKTheoAccChinh_CheckedChanged);
		checkBoxChayNhay.AutoSize = true;
		checkBoxChayNhay.BackColor = System.Drawing.SystemColors.Control;
		checkBoxChayNhay.ForeColor = System.Drawing.Color.Black;
		checkBoxChayNhay.Location = new System.Drawing.Point(7, 124);
		checkBoxChayNhay.Name = "checkBoxChayNhay";
		checkBoxChayNhay.Size = new System.Drawing.Size(161, 17);
		checkBoxChayNhay.TabIndex = 293;
		checkBoxChayNhay.Text = "Đánh người đang chạy nhảy";
		checkBoxChayNhay.UseVisualStyleBackColor = false;
		checkBoxChayNhay.CheckedChanged += new System.EventHandler(checkBoxChayNhay_CheckedChanged);
		checkBoxTroLaiDiemcu.ForeColor = System.Drawing.Color.Black;
		checkBoxTroLaiDiemcu.Location = new System.Drawing.Point(200, 121);
		checkBoxTroLaiDiemcu.Name = "checkBoxTroLaiDiemcu";
		checkBoxTroLaiDiemcu.Size = new System.Drawing.Size(266, 32);
		checkBoxTroLaiDiemcu.TabIndex = 295;
		checkBoxTroLaiDiemcu.Text = "Ưu tiên đi Xa phu trở lại điểm cũ trước (sẽ đi THP sau khi đi xa phu không được)";
		checkBoxTroLaiDiemcu.UseVisualStyleBackColor = true;
		checkBoxTroLaiDiemcu.CheckedChanged += new System.EventHandler(checkBoxTroLaiDiemcu_CheckedChanged);
		label15.AutoSize = true;
		label15.ForeColor = System.Drawing.Color.Black;
		label15.Location = new System.Drawing.Point(239, 52);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(177, 13);
		label15.TabIndex = 297;
		label15.Text = "Khoảng cách lên ngựa tìm ac chính";
		textBoxKhoangCachlenNgua.ForeColor = System.Drawing.Color.Black;
		textBoxKhoangCachlenNgua.Location = new System.Drawing.Point(430, 49);
		textBoxKhoangCachlenNgua.Name = "textBoxKhoangCachlenNgua";
		textBoxKhoangCachlenNgua.Size = new System.Drawing.Size(35, 20);
		textBoxKhoangCachlenNgua.TabIndex = 296;
		textBoxKhoangCachlenNgua.TextChanged += new System.EventHandler(textBoxKhoangCachlenNgua_TextChanged);
		numericUpDownKhongdanhCapnho.ForeColor = System.Drawing.Color.Black;
		numericUpDownKhongdanhCapnho.Location = new System.Drawing.Point(151, 148);
		numericUpDownKhongdanhCapnho.Minimum = new decimal(new int[4]
		{
			1,
			0,
			0,
			0
		});
		numericUpDownKhongdanhCapnho.Name = "numericUpDownKhongdanhCapnho";
		numericUpDownKhongdanhCapnho.Size = new System.Drawing.Size(40, 20);
		numericUpDownKhongdanhCapnho.TabIndex = 299;
		numericUpDownKhongdanhCapnho.Value = new decimal(new int[4]
		{
			1,
			0,
			0,
			0
		});
		numericUpDownKhongdanhCapnho.ValueChanged += new System.EventHandler(numericUpDownKhongdanhCapnho_ValueChanged);
		numericUpDownKhongdanhCapnho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(numericUpDownKhongdanhCapnho_KeyPress);
		checkBoxKhongdanhCapnho.AutoSize = true;
		checkBoxKhongdanhCapnho.BackColor = System.Drawing.SystemColors.Control;
		checkBoxKhongdanhCapnho.ForeColor = System.Drawing.Color.Black;
		checkBoxKhongdanhCapnho.Location = new System.Drawing.Point(7, 149);
		checkBoxKhongdanhCapnho.Name = "checkBoxKhongdanhCapnho";
		checkBoxKhongdanhCapnho.Size = new System.Drawing.Size(142, 17);
		checkBoxKhongdanhCapnho.TabIndex = 298;
		checkBoxKhongdanhCapnho.Text = "Không đánh ac cấp nhỏ";
		checkBoxKhongdanhCapnho.UseVisualStyleBackColor = false;
		checkBoxKhongdanhCapnho.CheckedChanged += new System.EventHandler(checkBoxKhongdanhCapnho_CheckedChanged);
		labelBoqua.AutoSize = true;
		labelBoqua.Cursor = System.Windows.Forms.Cursors.Hand;
		labelBoqua.ForeColor = System.Drawing.Color.Green;
		labelBoqua.Location = new System.Drawing.Point(409, 101);
		labelBoqua.Name = "labelBoqua";
		labelBoqua.Size = new System.Drawing.Size(57, 13);
		labelBoqua.TabIndex = 302;
		labelBoqua.Text = "giải thích..";
		labelBoqua.Click += new System.EventHandler(labelBoqua_Click);
		checkBoxBaoCuusat.AutoSize = true;
		checkBoxBaoCuusat.ForeColor = System.Drawing.Color.Black;
		checkBoxBaoCuusat.Location = new System.Drawing.Point(7, 75);
		checkBoxBaoCuusat.Name = "checkBoxBaoCuusat";
		checkBoxBaoCuusat.Size = new System.Drawing.Size(103, 17);
		checkBoxBaoCuusat.TabIndex = 303;
		checkBoxBaoCuusat.Text = "Báo cừu sát mật";
		checkBoxBaoCuusat.UseVisualStyleBackColor = true;
		checkBoxBaoCuusat.CheckedChanged += new System.EventHandler(checkBoxBaoCuusat_CheckedChanged);
		checkBoxKhongChaybo.AutoSize = true;
		checkBoxKhongChaybo.BackColor = System.Drawing.SystemColors.Control;
		checkBoxKhongChaybo.ForeColor = System.Drawing.Color.Black;
		checkBoxKhongChaybo.Location = new System.Drawing.Point(200, 98);
		checkBoxKhongChaybo.Name = "checkBoxKhongChaybo";
		checkBoxKhongChaybo.Size = new System.Drawing.Size(199, 17);
		checkBoxKhongChaybo.TabIndex = 301;
		checkBoxKhongChaybo.Text = "Không chạy bộ đến các map quá xa";
		checkBoxKhongChaybo.UseVisualStyleBackColor = false;
		checkBoxKhongChaybo.CheckedChanged += new System.EventHandler(checkBoxKhongChaybo_CheckedChanged);
		checkBoxKhongDanhAccCungbang.AutoSize = true;
		checkBoxKhongDanhAccCungbang.BackColor = System.Drawing.SystemColors.Control;
		checkBoxKhongDanhAccCungbang.ForeColor = System.Drawing.Color.Black;
		checkBoxKhongDanhAccCungbang.Location = new System.Drawing.Point(7, 173);
		checkBoxKhongDanhAccCungbang.Name = "checkBoxKhongDanhAccCungbang";
		checkBoxKhongDanhAccCungbang.Size = new System.Drawing.Size(139, 17);
		checkBoxKhongDanhAccCungbang.TabIndex = 300;
		checkBoxKhongDanhAccCungbang.Text = "Không đánh cùng bang";
		checkBoxKhongDanhAccCungbang.UseVisualStyleBackColor = false;
		checkBoxKhongDanhAccCungbang.CheckedChanged += new System.EventHandler(checkBoxKhongDanhAccCungbang_CheckedChanged);
		buttonThietlapSuado.BackColor = System.Drawing.SystemColors.Control;
		buttonThietlapSuado.ForeColor = System.Drawing.Color.Black;
		buttonThietlapSuado.Location = new System.Drawing.Point(122, 218);
		buttonThietlapSuado.Name = "buttonThietlapSuado";
		buttonThietlapSuado.Size = new System.Drawing.Size(66, 23);
		buttonThietlapSuado.TabIndex = 304;
		buttonThietlapSuado.Text = "Thiết lập";
		buttonThietlapSuado.UseVisualStyleBackColor = false;
		buttonThietlapSuado.Click += new System.EventHandler(buttonThietlapSuado_Click);
		labelTiepcan.AutoSize = true;
		labelTiepcan.Cursor = System.Windows.Forms.Cursors.Hand;
		labelTiepcan.ForeColor = System.Drawing.Color.Green;
		labelTiepcan.Location = new System.Drawing.Point(358, 31);
		labelTiepcan.Name = "labelTiepcan";
		labelTiepcan.Size = new System.Drawing.Size(57, 13);
		labelTiepcan.TabIndex = 444;
		labelTiepcan.Text = "giải thích..";
		labelTiepcan.Click += new System.EventHandler(labelTiepcan_Click);
		textBoxTiepCan.ForeColor = System.Drawing.Color.Maroon;
		textBoxTiepCan.Location = new System.Drawing.Point(430, 18);
		textBoxTiepCan.Name = "textBoxTiepCan";
		textBoxTiepCan.Size = new System.Drawing.Size(35, 20);
		textBoxTiepCan.TabIndex = 442;
		textBoxTiepCan.TextChanged += new System.EventHandler(textBoxTiepCan_TextChanged);
		label2.ForeColor = System.Drawing.Color.Maroon;
		label2.Location = new System.Drawing.Point(202, 12);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(233, 26);
		label2.TabIndex = 443;
		label2.Text = "Khoảng cách tìm ac chính dùng riêng cho các ac đánh tiếp cận <= 180";
		checkBoxDanhDenchet.AutoSize = true;
		checkBoxDanhDenchet.BackColor = System.Drawing.SystemColors.Control;
		checkBoxDanhDenchet.ForeColor = System.Drawing.Color.Black;
		checkBoxDanhDenchet.Location = new System.Drawing.Point(7, 196);
		checkBoxDanhDenchet.Name = "checkBoxDanhDenchet";
		checkBoxDanhDenchet.Size = new System.Drawing.Size(98, 17);
		checkBoxDanhDenchet.TabIndex = 441;
		checkBoxDanhDenchet.Text = "Đánh đến chết";
		checkBoxDanhDenchet.UseVisualStyleBackColor = false;
		checkBoxDanhDenchet.CheckedChanged += new System.EventHandler(checkBoxDanhDenchet_CheckedChanged);
		labelThemPTAcKhongdanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		labelThemPTAcKhongdanh.Cursor = System.Windows.Forms.Cursors.Hand;
		labelThemPTAcKhongdanh.Location = new System.Drawing.Point(354, 112);
		labelThemPTAcKhongdanh.Name = "labelThemPTAcKhongdanh";
		labelThemPTAcKhongdanh.Size = new System.Drawing.Size(63, 19);
		labelThemPTAcKhongdanh.TabIndex = 440;
		labelThemPTAcKhongdanh.Text = "TrongPT";
		labelThemPTAcKhongdanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		labelThemPTAcKhongdanh.Click += new System.EventHandler(labelThemPTAcKhongdanh_Click);
		labelXoaAcKhongdanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		labelXoaAcKhongdanh.Cursor = System.Windows.Forms.Cursors.Hand;
		labelXoaAcKhongdanh.Location = new System.Drawing.Point(420, 112);
		labelXoaAcKhongdanh.Name = "labelXoaAcKhongdanh";
		labelXoaAcKhongdanh.Size = new System.Drawing.Size(46, 19);
		labelXoaAcKhongdanh.TabIndex = 439;
		labelXoaAcKhongdanh.Text = "Xóa";
		labelXoaAcKhongdanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		labelXoaAcKhongdanh.Click += new System.EventHandler(labelXoaAcKhongdanh_Click);
		labelThemAcKhongdanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		labelThemAcKhongdanh.Cursor = System.Windows.Forms.Cursors.Hand;
		labelThemAcKhongdanh.Location = new System.Drawing.Point(301, 112);
		labelThemAcKhongdanh.Name = "labelThemAcKhongdanh";
		labelThemAcKhongdanh.Size = new System.Drawing.Size(50, 19);
		labelThemAcKhongdanh.TabIndex = 438;
		labelThemAcKhongdanh.Text = "Thêm";
		labelThemAcKhongdanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		labelThemAcKhongdanh.Click += new System.EventHandler(labelThemAcKhongdanh_Click);
		labelXoaKhongdanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		labelXoaKhongdanh.Cursor = System.Windows.Forms.Cursors.Hand;
		labelXoaKhongdanh.Location = new System.Drawing.Point(216, 112);
		labelXoaKhongdanh.Name = "labelXoaKhongdanh";
		labelXoaKhongdanh.Size = new System.Drawing.Size(50, 19);
		labelXoaKhongdanh.TabIndex = 437;
		labelXoaKhongdanh.Text = "Xóa";
		labelXoaKhongdanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		labelXoaKhongdanh.Click += new System.EventHandler(labelXoaKhongdanh_Click);
		labelThemKhongdanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		labelThemKhongdanh.Cursor = System.Windows.Forms.Cursors.Hand;
		labelThemKhongdanh.Location = new System.Drawing.Point(163, 112);
		labelThemKhongdanh.Name = "labelThemKhongdanh";
		labelThemKhongdanh.Size = new System.Drawing.Size(50, 19);
		labelThemKhongdanh.TabIndex = 436;
		labelThemKhongdanh.Text = "Thêm";
		labelThemKhongdanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		labelThemKhongdanh.Click += new System.EventHandler(labelThemKhongdanh_Click);
		labelXoaLuondanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		labelXoaLuondanh.Cursor = System.Windows.Forms.Cursors.Hand;
		labelXoaLuondanh.Location = new System.Drawing.Point(58, 112);
		labelXoaLuondanh.Name = "labelXoaLuondanh";
		labelXoaLuondanh.Size = new System.Drawing.Size(50, 19);
		labelXoaLuondanh.TabIndex = 435;
		labelXoaLuondanh.Text = "Xóa";
		labelXoaLuondanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		labelXoaLuondanh.Click += new System.EventHandler(labelXoaLuondanh_Click);
		labelThemLuondanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		labelThemLuondanh.Cursor = System.Windows.Forms.Cursors.Hand;
		labelThemLuondanh.Location = new System.Drawing.Point(4, 112);
		labelThemLuondanh.Name = "labelThemLuondanh";
		labelThemLuondanh.Size = new System.Drawing.Size(50, 19);
		labelThemLuondanh.TabIndex = 434;
		labelThemLuondanh.Text = "Thêm";
		labelThemLuondanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		labelThemLuondanh.Click += new System.EventHandler(labelThemLuondanh_Click);
		comboBoxKhongdanhAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxKhongdanhAc.FormattingEnabled = true;
		comboBoxKhongdanhAc.Location = new System.Drawing.Point(304, 88);
		comboBoxKhongdanhAc.Name = "comboBoxKhongdanhAc";
		comboBoxKhongdanhAc.Size = new System.Drawing.Size(162, 21);
		comboBoxKhongdanhAc.TabIndex = 433;
		comboBoxKhongdanhAc.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxKhongdanhAc_MouseDown);
		comboBoxKhongDanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxKhongDanh.FormattingEnabled = true;
		comboBoxKhongDanh.Location = new System.Drawing.Point(163, 88);
		comboBoxKhongDanh.Name = "comboBoxKhongDanh";
		comboBoxKhongDanh.Size = new System.Drawing.Size(135, 21);
		comboBoxKhongDanh.TabIndex = 430;
		comboBoxKhongDanh.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxKhongDanh_MouseDown);
		comboBoxLuonDanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxLuonDanh.FormattingEnabled = true;
		comboBoxLuonDanh.Location = new System.Drawing.Point(3, 88);
		comboBoxLuonDanh.Name = "comboBoxLuonDanh";
		comboBoxLuonDanh.Size = new System.Drawing.Size(154, 21);
		comboBoxLuonDanh.TabIndex = 427;
		comboBoxLuonDanh.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxLuonDanh_MouseDown);
		checkBoxXuongngua.AutoSize = true;
		checkBoxXuongngua.BackColor = System.Drawing.SystemColors.Control;
		checkBoxXuongngua.ForeColor = System.Drawing.Color.Black;
		checkBoxXuongngua.Location = new System.Drawing.Point(7, 51);
		checkBoxXuongngua.Name = "checkBoxXuongngua";
		checkBoxXuongngua.Size = new System.Drawing.Size(168, 17);
		checkBoxXuongngua.TabIndex = 331;
		checkBoxXuongngua.Text = "Xuống ngựa khi gặp ac chính";
		checkBoxXuongngua.UseVisualStyleBackColor = false;
		checkBoxXuongngua.CheckedChanged += new System.EventHandler(checkBoxXuongngua_CheckedChanged);
		checkBoxBaoCuusatPhucan.AutoSize = true;
		checkBoxBaoCuusatPhucan.ForeColor = System.Drawing.Color.Black;
		checkBoxBaoCuusatPhucan.Location = new System.Drawing.Point(122, 75);
		checkBoxBaoCuusatPhucan.Name = "checkBoxBaoCuusatPhucan";
		checkBoxBaoCuusatPhucan.Size = new System.Drawing.Size(66, 17);
		checkBoxBaoCuusatPhucan.TabIndex = 330;
		checkBoxBaoCuusatPhucan.Text = "Phụ cận";
		checkBoxBaoCuusatPhucan.UseVisualStyleBackColor = true;
		checkBoxBaoCuusatPhucan.CheckedChanged += new System.EventHandler(checkBoxBaoCuusatPhucan_CheckedChanged);
		checkBoxLuonDanhbang.AutoSize = true;
		checkBoxLuonDanhbang.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxLuonDanhbang.Location = new System.Drawing.Point(3, 5);
		checkBoxLuonDanhbang.Name = "checkBoxLuonDanhbang";
		checkBoxLuonDanhbang.Size = new System.Drawing.Size(145, 17);
		checkBoxLuonDanhbang.TabIndex = 412;
		checkBoxLuonDanhbang.Text = "Luôn đánh bang hội dưới";
		checkBoxLuonDanhbang.UseVisualStyleBackColor = true;
		checkBoxLuonDanhbang.CheckedChanged += new System.EventHandler(checkBoxLuonDanhbang_CheckedChanged);
		checkBoxKhongdanhAc.AutoSize = true;
		checkBoxKhongdanhAc.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxKhongdanhAc.Location = new System.Drawing.Point(304, 5);
		checkBoxKhongdanhAc.Name = "checkBoxKhongdanhAc";
		checkBoxKhongdanhAc.Size = new System.Drawing.Size(100, 17);
		checkBoxKhongdanhAc.TabIndex = 426;
		checkBoxKhongdanhAc.Text = "Không đánh ac";
		checkBoxKhongdanhAc.UseVisualStyleBackColor = true;
		checkBoxKhongdanhAc.CheckedChanged += new System.EventHandler(checkBoxKhongdanhAc_CheckedChanged);
		labelLienthongGiaithich.AutoSize = true;
		labelLienthongGiaithich.Cursor = System.Windows.Forms.Cursors.Hand;
		labelLienthongGiaithich.ForeColor = System.Drawing.Color.Green;
		labelLienthongGiaithich.Location = new System.Drawing.Point(409, 78);
		labelLienthongGiaithich.Name = "labelLienthongGiaithich";
		labelLienthongGiaithich.Size = new System.Drawing.Size(57, 13);
		labelLienthongGiaithich.TabIndex = 329;
		labelLienthongGiaithich.Text = "giải thích..";
		labelLienthongGiaithich.Click += new System.EventHandler(labelLienthongGiaithich_Click);
		listViewKhongdanhAc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			columnHeader_2
		});
		listViewKhongdanhAc.FullRowSelect = true;
		listViewKhongdanhAc.GridLines = true;
		listViewKhongdanhAc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		listViewKhongdanhAc.HideSelection = false;
		listViewKhongdanhAc.Location = new System.Drawing.Point(304, 26);
		listViewKhongdanhAc.MultiSelect = false;
		listViewKhongdanhAc.Name = "listViewKhongdanhAc";
		listViewKhongdanhAc.Size = new System.Drawing.Size(162, 57);
		listViewKhongdanhAc.TabIndex = 422;
		listViewKhongdanhAc.UseCompatibleStateImageBehavior = false;
		listViewKhongdanhAc.View = System.Windows.Forms.View.Details;
		columnHeader_2.Text = "Không đánh ac";
		columnHeader_2.Width = 120;
		checkBoxTHP_Smdb.AutoSize = true;
		checkBoxTHP_Smdb.ForeColor = System.Drawing.Color.Black;
		checkBoxTHP_Smdb.Location = new System.Drawing.Point(200, 75);
		checkBoxTHP_Smdb.Name = "checkBoxTHP_Smdb";
		checkBoxTHP_Smdb.Size = new System.Drawing.Size(167, 17);
		checkBoxTHP_Smdb.TabIndex = 328;
		checkBoxTHP_Smdb.Text = "Chạy bộ ở các map liên thông";
		checkBoxTHP_Smdb.UseVisualStyleBackColor = true;
		checkBoxTHP_Smdb.CheckedChanged += new System.EventHandler(checkBoxTHP_Smdb_CheckedChanged);
		checkBoxKhongdanhBang.AutoSize = true;
		checkBoxKhongdanhBang.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxKhongdanhBang.Location = new System.Drawing.Point(163, 6);
		checkBoxKhongdanhBang.Name = "checkBoxKhongdanhBang";
		checkBoxKhongdanhBang.Size = new System.Drawing.Size(129, 17);
		checkBoxKhongdanhBang.TabIndex = 421;
		checkBoxKhongdanhBang.Text = "Không đánh bang hội";
		checkBoxKhongdanhBang.UseVisualStyleBackColor = true;
		checkBoxKhongdanhBang.CheckedChanged += new System.EventHandler(checkBoxKhongdanhBang_CheckedChanged);
		listViewKhongDanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			columnHeader_0
		});
		listViewKhongDanh.FullRowSelect = true;
		listViewKhongDanh.GridLines = true;
		listViewKhongDanh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		listViewKhongDanh.HideSelection = false;
		listViewKhongDanh.Location = new System.Drawing.Point(163, 26);
		listViewKhongDanh.MultiSelect = false;
		listViewKhongDanh.Name = "listViewKhongDanh";
		listViewKhongDanh.Size = new System.Drawing.Size(135, 57);
		listViewKhongDanh.TabIndex = 417;
		listViewKhongDanh.UseCompatibleStateImageBehavior = false;
		listViewKhongDanh.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "Không đánh bang";
		columnHeader_0.Width = 115;
		listViewLuonDanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			columnHeader_1
		});
		listViewLuonDanh.FullRowSelect = true;
		listViewLuonDanh.GridLines = true;
		listViewLuonDanh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		listViewLuonDanh.HideSelection = false;
		listViewLuonDanh.Location = new System.Drawing.Point(3, 26);
		listViewLuonDanh.MultiSelect = false;
		listViewLuonDanh.Name = "listViewLuonDanh";
		listViewLuonDanh.Size = new System.Drawing.Size(154, 57);
		listViewLuonDanh.TabIndex = 413;
		listViewLuonDanh.UseCompatibleStateImageBehavior = false;
		listViewLuonDanh.View = System.Windows.Forms.View.Details;
		columnHeader_1.Text = "Đánh người bang hội";
		columnHeader_1.Width = 115;
		textBoxTen.BackColor = System.Drawing.Color.Gainsboro;
		textBoxTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
		textBoxTen.ForeColor = System.Drawing.Color.MidnightBlue;
		textBoxTen.Location = new System.Drawing.Point(345, 42);
		textBoxTen.Name = "textBoxTen";
		textBoxTen.Size = new System.Drawing.Size(107, 13);
		textBoxTen.TabIndex = 339;
		numericUpDownPassword.ForeColor = System.Drawing.Color.Black;
		numericUpDownPassword.Location = new System.Drawing.Point(399, 123);
		numericUpDownPassword.Maximum = new decimal(new int[4]
		{
			9999,
			0,
			0,
			0
		});
		numericUpDownPassword.Name = "numericUpDownPassword";
		numericUpDownPassword.Size = new System.Drawing.Size(53, 20);
		numericUpDownPassword.TabIndex = 333;
		numericUpDownPassword.Value = new decimal(new int[4]
		{
			1,
			0,
			0,
			0
		});
		numericUpDownPassword.ValueChanged += new System.EventHandler(numericUpDownPassword_ValueChanged);
		numericUpDownPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(numericUpDownPassword_KeyPress);
		checkBoxKhoaChatmat.AutoSize = true;
		checkBoxKhoaChatmat.ForeColor = System.Drawing.Color.Black;
		checkBoxKhoaChatmat.Location = new System.Drawing.Point(4, 151);
		checkBoxKhoaChatmat.Name = "checkBoxKhoaChatmat";
		checkBoxKhoaChatmat.Size = new System.Drawing.Size(124, 17);
		checkBoxKhoaChatmat.TabIndex = 334;
		checkBoxKhoaChatmat.Text = "Tắt tầng số chat mật";
		checkBoxKhoaChatmat.UseVisualStyleBackColor = true;
		checkBoxKhoaChatmat.CheckedChanged += new System.EventHandler(checkBoxKhoaChatmat_CheckedChanged);
		checkBoxRoom.AutoSize = true;
		checkBoxRoom.ForeColor = System.Drawing.Color.Black;
		checkBoxRoom.Location = new System.Drawing.Point(4, 174);
		checkBoxRoom.Name = "checkBoxRoom";
		checkBoxRoom.Size = new System.Drawing.Size(138, 17);
		checkBoxRoom.TabIndex = 333;
		checkBoxRoom.Text = "Có báo trong phòng tán";
		checkBoxRoom.UseVisualStyleBackColor = true;
		checkBoxRoom.CheckedChanged += new System.EventHandler(checkBoxRoom_CheckedChanged);
		checkBoxPassword.AutoSize = true;
		checkBoxPassword.ForeColor = System.Drawing.Color.Black;
		checkBoxPassword.Location = new System.Drawing.Point(4, 126);
		checkBoxPassword.Name = "checkBoxPassword";
		checkBoxPassword.Size = new System.Drawing.Size(384, 17);
		checkBoxPassword.TabIndex = 335;
		checkBoxPassword.Text = "Có sử dụng pass để tránh bị phá rối (máy chính và máy phụ ghi giống nhau)";
		checkBoxPassword.UseVisualStyleBackColor = true;
		checkBoxPassword.CheckedChanged += new System.EventHandler(checkBoxPassword_CheckedChanged);
		label3.ForeColor = System.Drawing.Color.Black;
		label3.Location = new System.Drawing.Point(135, 63);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(315, 43);
		label3.TabIndex = 332;
		label3.Text = "Ép tên ac chính (hoặc tất cả tên ac) ở máy phụ vào nút <danh sách ac máy phụ>, sau đó check vào nút [v] Đây là máy chính... (không nên đem ac chính làm ac thông báo nhé).";
		buttonDanhsachMayphu.BackColor = System.Drawing.SystemColors.Control;
		buttonDanhsachMayphu.ForeColor = System.Drawing.Color.Black;
		buttonDanhsachMayphu.Location = new System.Drawing.Point(20, 63);
		buttonDanhsachMayphu.Name = "buttonDanhsachMayphu";
		buttonDanhsachMayphu.Size = new System.Drawing.Size(98, 36);
		buttonDanhsachMayphu.TabIndex = 321;
		buttonDanhsachMayphu.Text = "Danh sách ac máy phụ";
		buttonDanhsachMayphu.UseVisualStyleBackColor = false;
		buttonDanhsachMayphu.Click += new System.EventHandler(buttonDanhsachMayphu_Click);
		buttonCacChucNangDkTuxa.ForeColor = System.Drawing.Color.Black;
		buttonCacChucNangDkTuxa.Location = new System.Drawing.Point(9, 360);
		buttonCacChucNangDkTuxa.Name = "buttonCacChucNangDkTuxa";
		buttonCacChucNangDkTuxa.Size = new System.Drawing.Size(200, 29);
		buttonCacChucNangDkTuxa.TabIndex = 290;
		buttonCacChucNangDkTuxa.Text = "Các chức năng điều khiển từ xa";
		buttonCacChucNangDkTuxa.UseVisualStyleBackColor = true;
		buttonCacChucNangDkTuxa.Click += new System.EventHandler(buttonCacChucNangDkTuxa_Click);
		tabControl1.Controls.Add(tabPage1);
		tabControl1.Controls.Add(tabPageLienMay);
		tabControl1.Location = new System.Drawing.Point(1, 1);
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size(485, 422);
		tabControl1.TabIndex = 326;
		tabPage1.Controls.Add(groupBox1);
		tabPage1.Controls.Add(listViewLuonDanh);
		tabPage1.Controls.Add(listViewKhongDanh);
		tabPage1.Controls.Add(labelThemPTAcKhongdanh);
		tabPage1.Controls.Add(labelXoaAcKhongdanh);
		tabPage1.Controls.Add(labelThemAcKhongdanh);
		tabPage1.Controls.Add(labelXoaKhongdanh);
		tabPage1.Controls.Add(labelThemKhongdanh);
		tabPage1.Controls.Add(checkBoxKhongdanhBang);
		tabPage1.Controls.Add(labelXoaLuondanh);
		tabPage1.Controls.Add(labelThemLuondanh);
		tabPage1.Controls.Add(comboBoxKhongdanhAc);
		tabPage1.Controls.Add(listViewKhongdanhAc);
		tabPage1.Controls.Add(comboBoxKhongDanh);
		tabPage1.Controls.Add(comboBoxLuonDanh);
		tabPage1.Controls.Add(checkBoxKhongdanhAc);
		tabPage1.Controls.Add(checkBoxLuonDanhbang);
		tabPage1.Location = new System.Drawing.Point(4, 22);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding(3);
		tabPage1.Size = new System.Drawing.Size(477, 396);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "Thiết lập chung";
		tabPage1.UseVisualStyleBackColor = true;
		groupBox1.Controls.Add(checkBoxBaoCsKenhbang);
		groupBox1.Controls.Add(checkBoxThongbaoTHP);
		groupBox1.Controls.Add(checkBoxTHP);
		groupBox1.Controls.Add(textBoxTiepCan);
		groupBox1.Controls.Add(textBoxKhoangCachlenNgua);
		groupBox1.Controls.Add(labelTiepcan);
		groupBox1.Controls.Add(label2);
		groupBox1.Controls.Add(checkBoxBaoCuusatPhucan);
		groupBox1.Controls.Add(checkBoxKhongdanhCapnho);
		groupBox1.Controls.Add(checkBoxSuado);
		groupBox1.Controls.Add(checkBoxDanhDenchet);
		groupBox1.Controls.Add(buttonThietlapSuado);
		groupBox1.Controls.Add(checkBoxTHP_Smdb);
		groupBox1.Controls.Add(checkBoxXuongngua);
		groupBox1.Controls.Add(checkBoxDoiPKTheoAccChinh);
		groupBox1.Controls.Add(labelBoqua);
		groupBox1.Controls.Add(labelLienthongGiaithich);
		groupBox1.Controls.Add(numericUpDownKhongdanhCapnho);
		groupBox1.Controls.Add(checkBoxKhongDanhAccCungbang);
		groupBox1.Controls.Add(label15);
		groupBox1.Controls.Add(checkBoxChayNhay);
		groupBox1.Controls.Add(checkBoxTroLaiDiemcu);
		groupBox1.Controls.Add(checkBoxKhongChaybo);
		groupBox1.Controls.Add(checkBoxBaoCuusat);
		groupBox1.Location = new System.Drawing.Point(1, 142);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(475, 252);
		groupBox1.TabIndex = 441;
		groupBox1.TabStop = false;
		groupBox1.Text = "Thiết lập dùng chung cho tất cả ac";
		checkBoxBaoCsKenhbang.AutoSize = true;
		checkBoxBaoCsKenhbang.ForeColor = System.Drawing.Color.Black;
		checkBoxBaoCsKenhbang.Location = new System.Drawing.Point(22, 97);
		checkBoxBaoCsKenhbang.Name = "checkBoxBaoCsKenhbang";
		checkBoxBaoCsKenhbang.Size = new System.Drawing.Size(120, 17);
		checkBoxBaoCsKenhbang.TabIndex = 462;
		checkBoxBaoCsKenhbang.Text = "Báo cừu kênh bang";
		checkBoxBaoCsKenhbang.UseVisualStyleBackColor = true;
		checkBoxBaoCsKenhbang.CheckedChanged += new System.EventHandler(checkBoxBaoCsKenhbang_CheckedChanged);
		checkBoxThongbaoTHP.AutoSize = true;
		checkBoxThongbaoTHP.ForeColor = System.Drawing.Color.Black;
		checkBoxThongbaoTHP.Location = new System.Drawing.Point(200, 193);
		checkBoxThongbaoTHP.Name = "checkBoxThongbaoTHP";
		checkBoxThongbaoTHP.Size = new System.Drawing.Size(247, 17);
		checkBoxThongbaoTHP.TabIndex = 461;
		checkBoxThongbaoTHP.Text = "Tắt thông báo không đi được THP trong game";
		checkBoxThongbaoTHP.UseVisualStyleBackColor = true;
		checkBoxThongbaoTHP.CheckedChanged += new System.EventHandler(checkBoxThongbaoTHP_CheckedChanged);
		checkBoxTHP.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxTHP.Location = new System.Drawing.Point(200, 156);
		checkBoxTHP.Name = "checkBoxTHP";
		checkBoxTHP.Size = new System.Drawing.Size(273, 32);
		checkBoxTHP.TabIndex = 460;
		checkBoxTHP.Text = "Sử dụng TĐ phù và TH phù theo kiểu ac này xong thì mới tới ac kia (mục đích làm giảm lag)";
		checkBoxTHP.UseVisualStyleBackColor = true;
		checkBoxTHP.CheckedChanged += new System.EventHandler(checkBoxTHP_CheckedChanged);
		tabPageLienMay.Controls.Add(tabControlKeoLienmay);
		tabPageLienMay.Controls.Add(buttonCacChucNangDkTuxa);
		tabPageLienMay.Controls.Add(labelThongbao2);
		tabPageLienMay.Controls.Add(labelThongbao1);
		tabPageLienMay.Location = new System.Drawing.Point(4, 22);
		tabPageLienMay.Name = "tabPageLienMay";
		tabPageLienMay.Padding = new System.Windows.Forms.Padding(3);
		tabPageLienMay.Size = new System.Drawing.Size(477, 396);
		tabPageLienMay.TabIndex = 1;
		tabPageLienMay.Text = "Kéo nhiều máy";
		tabPageLienMay.UseVisualStyleBackColor = true;
		tabControlKeoLienmay.Controls.Add(tabPage4);
		tabControlKeoLienmay.Controls.Add(tabPage5);
		tabControlKeoLienmay.Location = new System.Drawing.Point(3, 5);
		tabControlKeoLienmay.Name = "tabControlKeoLienmay";
		tabControlKeoLienmay.SelectedIndex = 0;
		tabControlKeoLienmay.Size = new System.Drawing.Size(471, 342);
		tabControlKeoLienmay.TabIndex = 0;
		tabPage4.Controls.Add(label7);
		tabPage4.Controls.Add(buttonTatFireWall);
		tabPage4.Controls.Add(progressBar1);
		tabPage4.Controls.Add(buttonHuongdan);
		tabPage4.Controls.Add(richTextBoxVitri);
		tabPage4.Controls.Add(buttonKetthuc);
		tabPage4.Controls.Add(buttonXoa);
		tabPage4.Controls.Add(buttonBatdau);
		tabPage4.Controls.Add(groupBoxHientai);
		tabPage4.Controls.Add(groupBoxConnect);
		tabPage4.Controls.Add(richTextBoxStatus);
		tabPage4.Controls.Add(comboBoxConnect);
		tabPage4.Location = new System.Drawing.Point(4, 22);
		tabPage4.Name = "tabPage4";
		tabPage4.Padding = new System.Windows.Forms.Padding(3);
		tabPage4.Size = new System.Drawing.Size(463, 316);
		tabPage4.TabIndex = 0;
		tabPage4.Text = "Mạng LAN ( kiểu 1)";
		tabPage4.UseVisualStyleBackColor = true;
		label7.AutoSize = true;
		label7.ForeColor = System.Drawing.Color.Black;
		label7.Location = new System.Drawing.Point(6, 275);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(249, 26);
		label7.TabIndex = 482;
		label7.Text = "Đọc lưu ý và tắt firewall, \r\nghi dòng (1) của phần lưu ý trên khi inbox hỏi hỗ trợ";
		buttonTatFireWall.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		buttonTatFireWall.ForeColor = System.Drawing.Color.Crimson;
		buttonTatFireWall.Location = new System.Drawing.Point(261, 275);
		buttonTatFireWall.Name = "buttonTatFireWall";
		buttonTatFireWall.Size = new System.Drawing.Size(107, 38);
		buttonTatFireWall.TabIndex = 479;
		buttonTatFireWall.Text = "Tắt Firewall";
		buttonTatFireWall.UseVisualStyleBackColor = true;
		buttonTatFireWall.Click += new System.EventHandler(buttonTatFireWall_Click);
		progressBar1.Location = new System.Drawing.Point(208, 243);
		progressBar1.Name = "progressBar1";
		progressBar1.Size = new System.Drawing.Size(160, 16);
		progressBar1.TabIndex = 479;
		buttonHuongdan.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		buttonHuongdan.ForeColor = System.Drawing.Color.MediumBlue;
		buttonHuongdan.Location = new System.Drawing.Point(374, 275);
		buttonHuongdan.Name = "buttonHuongdan";
		buttonHuongdan.Size = new System.Drawing.Size(88, 38);
		buttonHuongdan.TabIndex = 478;
		buttonHuongdan.Text = "Phim hướng dẫn kiểu 1";
		buttonHuongdan.UseVisualStyleBackColor = true;
		buttonHuongdan.Click += new System.EventHandler(buttonHuongdan_Click);
		richTextBoxVitri.Location = new System.Drawing.Point(208, 205);
		richTextBoxVitri.Name = "richTextBoxVitri";
		richTextBoxVitri.Size = new System.Drawing.Size(254, 32);
		richTextBoxVitri.TabIndex = 477;
		richTextBoxVitri.Text = "";
		buttonKetthuc.Location = new System.Drawing.Point(96, 208);
		buttonKetthuc.Name = "buttonKetthuc";
		buttonKetthuc.Size = new System.Drawing.Size(106, 26);
		buttonKetthuc.TabIndex = 471;
		buttonKetthuc.Text = "Kết thúc";
		buttonKetthuc.UseVisualStyleBackColor = true;
		buttonKetthuc.Click += new System.EventHandler(buttonKetthuc_Click);
		buttonXoa.Location = new System.Drawing.Point(374, 243);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(88, 26);
		buttonXoa.TabIndex = 473;
		buttonXoa.Text = "Xóa nhật ký";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		buttonBatdau.Location = new System.Drawing.Point(2, 208);
		buttonBatdau.Name = "buttonBatdau";
		buttonBatdau.Size = new System.Drawing.Size(88, 26);
		buttonBatdau.TabIndex = 470;
		buttonBatdau.Text = "Bắt đầu";
		buttonBatdau.UseVisualStyleBackColor = true;
		buttonBatdau.Click += new System.EventHandler(buttonBatdau_Click);
		groupBoxHientai.Controls.Add(buttonCopy);
		groupBoxHientai.Controls.Add(comboBoxTabAddr);
		groupBoxHientai.Controls.Add(label1);
		groupBoxHientai.Controls.Add(label5);
		groupBoxHientai.Controls.Add(buttonRandom);
		groupBoxHientai.Controls.Add(textBoxPassServer);
		groupBoxHientai.Location = new System.Drawing.Point(1, 2);
		groupBoxHientai.Name = "groupBoxHientai";
		groupBoxHientai.Size = new System.Drawing.Size(201, 84);
		groupBoxHientai.TabIndex = 474;
		groupBoxHientai.TabStop = false;
		groupBoxHientai.Text = "Thông tin máy đang chạy";
		buttonCopy.BackColor = System.Drawing.SystemColors.Control;
		buttonCopy.ForeColor = System.Drawing.Color.Black;
		buttonCopy.Location = new System.Drawing.Point(153, 26);
		buttonCopy.Name = "buttonCopy";
		buttonCopy.Size = new System.Drawing.Size(40, 21);
		buttonCopy.TabIndex = 482;
		buttonCopy.Text = "Copy";
		buttonCopy.UseVisualStyleBackColor = false;
		buttonCopy.Click += new System.EventHandler(buttonCopy_Click);
		comboBoxTabAddr.FormattingEnabled = true;
		comboBoxTabAddr.Location = new System.Drawing.Point(43, 26);
		comboBoxTabAddr.Name = "comboBoxTabAddr";
		comboBoxTabAddr.Size = new System.Drawing.Size(107, 21);
		comboBoxTabAddr.TabIndex = 458;
		comboBoxTabAddr.SelectedIndexChanged += new System.EventHandler(comboBoxTabAddr_SelectedIndexChanged);
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(8, 29);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(32, 13);
		label1.TabIndex = 5;
		label1.Text = "IP (1)";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(8, 54);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(30, 13);
		label5.TabIndex = 6;
		label5.Text = "Pass";
		buttonRandom.BackColor = System.Drawing.SystemColors.Control;
		buttonRandom.ForeColor = System.Drawing.Color.Black;
		buttonRandom.Location = new System.Drawing.Point(154, 51);
		buttonRandom.Name = "buttonRandom";
		buttonRandom.Size = new System.Drawing.Size(40, 21);
		buttonRandom.TabIndex = 457;
		buttonRandom.Text = "Đổi";
		buttonRandom.UseVisualStyleBackColor = false;
		buttonRandom.Click += new System.EventHandler(buttonRandom_Click);
		textBoxPassServer.Location = new System.Drawing.Point(43, 51);
		textBoxPassServer.Name = "textBoxPassServer";
		textBoxPassServer.Size = new System.Drawing.Size(107, 20);
		textBoxPassServer.TabIndex = 7;
		textBoxPassServer.Leave += new System.EventHandler(textBoxPassServer_Leave);
		groupBoxConnect.Controls.Add(textBoxConnectPass);
		groupBoxConnect.Controls.Add(label4);
		groupBoxConnect.Controls.Add(label6);
		groupBoxConnect.Controls.Add(textBoxIPConnect);
		groupBoxConnect.Location = new System.Drawing.Point(1, 92);
		groupBoxConnect.Name = "groupBoxConnect";
		groupBoxConnect.Size = new System.Drawing.Size(201, 78);
		groupBoxConnect.TabIndex = 475;
		groupBoxConnect.TabStop = false;
		groupBoxConnect.Text = "Máy chính cần kết nối đến";
		textBoxConnectPass.Location = new System.Drawing.Point(44, 47);
		textBoxConnectPass.Name = "textBoxConnectPass";
		textBoxConnectPass.Size = new System.Drawing.Size(149, 20);
		textBoxConnectPass.TabIndex = 460;
		textBoxConnectPass.TextChanged += new System.EventHandler(textBoxConnectPass_TextChanged);
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(8, 26);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(32, 13);
		label4.TabIndex = 458;
		label4.Text = "IP (2)";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(8, 51);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 13);
		label6.TabIndex = 459;
		label6.Text = "Pass";
		textBoxIPConnect.Location = new System.Drawing.Point(44, 24);
		textBoxIPConnect.Name = "textBoxIPConnect";
		textBoxIPConnect.Size = new System.Drawing.Size(149, 20);
		textBoxIPConnect.TabIndex = 7;
		textBoxIPConnect.TextChanged += new System.EventHandler(textBoxIPConnect_TextChanged);
		richTextBoxStatus.Location = new System.Drawing.Point(208, 6);
		richTextBoxStatus.Name = "richTextBoxStatus";
		richTextBoxStatus.Size = new System.Drawing.Size(254, 195);
		richTextBoxStatus.TabIndex = 476;
		//richTextBoxStatus.Text = componentResourceManager.GetString("richTextBoxStatus.Text");
		comboBoxConnect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxConnect.FormattingEnabled = true;
		comboBoxConnect.Location = new System.Drawing.Point(2, 181);
		comboBoxConnect.Name = "comboBoxConnect";
		comboBoxConnect.Size = new System.Drawing.Size(200, 21);
		comboBoxConnect.TabIndex = 469;
		comboBoxConnect.SelectedIndexChanged += new System.EventHandler(comboBoxConnect_SelectedIndexChanged);
		tabPage5.Controls.Add(label11);
		tabPage5.Controls.Add(textBoxKytuLenh);
		tabPage5.Controls.Add(buttonHelp);
		tabPage5.Controls.Add(label10);
		tabPage5.Controls.Add(numericUpDownPassword);
		tabPage5.Controls.Add(textBoxTen);
		tabPage5.Controls.Add(label3);
		tabPage5.Controls.Add(checkBoxPassword);
		tabPage5.Controls.Add(checkBoxAcChihuy);
		tabPage5.Controls.Add(label8);
		tabPage5.Controls.Add(checkBoxAcChinhNghelenh);
		tabPage5.Controls.Add(buttonDanhsachMayphu);
		tabPage5.Controls.Add(checkBoxRoom);
		tabPage5.Controls.Add(checkBoxKhoaChatmat);
		tabPage5.Location = new System.Drawing.Point(4, 22);
		tabPage5.Name = "tabPage5";
		tabPage5.Padding = new System.Windows.Forms.Padding(3);
		tabPage5.Size = new System.Drawing.Size(463, 316);
		tabPage5.TabIndex = 1;
		tabPage5.Text = "PM mật ( kiểu 2)";
		tabPage5.UseVisualStyleBackColor = true;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(259, 155);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(129, 13);
		label11.TabIndex = 342;
		label11.Text = "Ký tự ngăn cách câu lệnh";
		textBoxKytuLenh.Location = new System.Drawing.Point(399, 151);
		textBoxKytuLenh.Name = "textBoxKytuLenh";
		textBoxKytuLenh.Size = new System.Drawing.Size(19, 20);
		textBoxKytuLenh.TabIndex = 341;
		textBoxKytuLenh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		textBoxKytuLenh.TextChanged += new System.EventHandler(textBoxKytuLenh_TextChanged);
		label10.ForeColor = System.Drawing.Color.MediumBlue;
		label10.Location = new System.Drawing.Point(38, 231);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(350, 36);
		label10.TabIndex = 340;
		label10.Text = "Lưu ý: Phần <Máy phụ luôn đến tọa độ bên> ở bảng 2 máy chính thì không áp dụng được cho kéo nhiều máy kiểu 2 này";
		labelThongbao2.AutoSize = true;
		labelThongbao2.Location = new System.Drawing.Point(187, 92);
		labelThongbao2.Name = "labelThongbao2";
		labelThongbao2.Size = new System.Drawing.Size(65, 13);
		labelThongbao2.TabIndex = 480;
		labelThongbao2.Text = "01/01/2019";
		labelThongbao2.Visible = false;
		labelThongbao1.Location = new System.Drawing.Point(9, 72);
		labelThongbao1.Name = "labelThongbao1";
		labelThongbao1.Size = new System.Drawing.Size(462, 13);
		labelThongbao1.TabIndex = 479;
		labelThongbao1.Text = "Chức năng kéo nhiều máy đã bị ad game khóa đến:";
		labelThongbao1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		labelThongbao1.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(484, 422);
		base.Controls.Add(tabControl1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormRauria";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "MO RONG";
		base.Load += new System.EventHandler(FormRauria_Load);
		((System.ComponentModel.ISupportInitialize)numericUpDownKhongdanhCapnho).EndInit();
		((System.ComponentModel.ISupportInitialize)numericUpDownPassword).EndInit();
		tabControl1.ResumeLayout(performLayout: false);
		tabPage1.ResumeLayout(performLayout: false);
		tabPage1.PerformLayout();
		groupBox1.ResumeLayout(performLayout: false);
		groupBox1.PerformLayout();
		tabPageLienMay.ResumeLayout(performLayout: false);
		tabPageLienMay.PerformLayout();
		tabControlKeoLienmay.ResumeLayout(performLayout: false);
		tabPage4.ResumeLayout(performLayout: false);
		tabPage4.PerformLayout();
		groupBoxHientai.ResumeLayout(performLayout: false);
		groupBoxHientai.PerformLayout();
		groupBoxConnect.ResumeLayout(performLayout: false);
		groupBoxConnect.PerformLayout();
		tabPage5.ResumeLayout(performLayout: false);
		tabPage5.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public FormRauria()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
		Class55.smethod_10(Class47.string_0, "tabRRControl1", tabControl1.SelectedIndex, "", 0);
		Class55.smethod_10(Class47.string_0, "tabRRControl2", tabControlKeoLienmay.SelectedIndex, "", 0);
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
	}

	private void FormRauria_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		if (string_2 == null)
		{
			string_2 = richTextBoxStatus.Text;
		}
		if (int_2 >= 0 && int_3 >= 0)
		{
			int num = int_2 - base.Width;
			int num2 = int_3 + int_5 - base.Height;
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
		if (Class11.struct7_0.Length <= GClass1.int_0 && GClass1.long_0 == 0L)
		{
			labelThongbao1.Visible = true;
			labelThongbao1.Text = "Đang kích hoạt server...";
			tabPageLienMay.Controls.Remove(tabControlKeoLienmay);
		}
		bool flag = false;
		if (!FormMayphu.bool_1 && FormMain.gstruct42_0 == null)
		{
			int num3 = -1;
			if (GClass1.gstruct13_0.bool_0 && GClass1.gstruct13_0.uint_1 != null && GClass1.gstruct14_0 != null)
			{
				for (int i = 0; i < GClass1.gstruct14_0.Length; i++)
				{
					if (GClass1.gstruct14_0[i].long_0 <= GClass1.long_1)
					{
						continue;
					}
					int num4 = 0;
					while (num4 < GClass1.gstruct13_0.uint_1.Length)
					{
						if (GClass1.gstruct14_0[i].uint_0 != GClass1.gstruct13_0.uint_1[num4])
						{
							num4++;
							continue;
						}
						goto IL_019e;
					}
					continue;
					IL_019e:
					num3 = i;
					break;
				}
			}
			if (0 <= num3)
			{
				DateTime dateTime = new DateTime(GClass1.gstruct14_0[num3].long_0);
				FormMayphu.int_1 = new int[3]
				{
					dateTime.Day,
					dateTime.Month,
					dateTime.Year
				};
				FormMayphu.string_1 = GClass1.gstruct14_0[num3].string_1;
				FormMayphu.bool_2 = (GClass1.gstruct14_0[num3].int_0 == 1);
				flag = true;
			}
		}
		if (FormMayphu.bool_1 || flag)
		{
			tabPageLienMay.Controls.Remove(tabControlKeoLienmay);
			labelThongbao1.Visible = true;
			labelThongbao2.Visible = true;
			if (FormMayphu.int_1 != null)
			{
				labelThongbao2.Text = "Ngày " + FormMayphu.int_1[0] + " Tháng " + FormMayphu.int_1[1] + ", " + FormMayphu.int_1[2];
			}
			if (FormMayphu.string_1 != null && FormMayphu.string_1 != string.Empty)
			{
				labelThongbao1.Text = "Chức năng kéo nhiều máy đã bị ad game " + FormMayphu.string_1 + " khóa đến:";
			}
		}
		tabControl1.SelectedIndex = Class55.smethod_3("tabRRControl1", 0, "0");
		tabControlKeoLienmay.SelectedIndex = Class55.smethod_3("tabRRControl2", 0, "0");
		checkBoxBaoCuusat.Checked = (FormMain.int_14 > 0);
		checkBoxBaoCuusatPhucan.Checked = (FormMain.int_16 > 0);
		checkBoxBaoCsKenhbang.Checked = (FormMain.int_15 > 0);
		checkBoxChayNhay.Checked = (FormMain.int_35 > 0);
		textBoxKhoangCachlenNgua.Text = FormMain.int_95.ToString();
		checkBoxKhongDanhAccCungbang.Checked = (FormMain.int_97 > 0);
		checkBoxSuado.Checked = (FormMain.int_55 > 0);
		checkBoxDoiPKTheoAccChinh.Checked = (FormMain.int_79 > 0);
		checkBoxTroLaiDiemcu.Checked = (FormMain.int_80 > 0);
		checkBoxKhongdanhCapnho.Checked = (FormMain.int_81 > 0);
		numericUpDownKhongdanhCapnho.Value = FormMain.int_82;
		checkBoxKhongChaybo.Checked = (FormMain.int_19 > 0);
		checkBoxAcChinhNghelenh.Checked = (FormMain.int_7 > 0);
		checkBoxTHP_Smdb.Checked = (FormMain.int_11 > 0);
		checkBoxXuongngua.Checked = (FormMain.int_96 > 0);
		checkBoxRoom.Checked = (FormMain.int_8 > 0);
		checkBoxKhoaChatmat.Checked = (FormMain.int_9 > 0);
		checkBoxPassword.Checked = (FormMain.int_48 > 0);
		numericUpDownPassword.Value = FormMain.int_49;
		checkBoxDanhDenchet.Checked = (FormMain.int_50 > 0);
		checkBoxTHP.Checked = (Class31.int_0 > 0);
		if (FormMayphu.string_2 == null || FormMayphu.string_2 == string.Empty)
		{
			FormMayphu.string_2 = "|";
		}
		textBoxKytuLenh.Text = FormMayphu.string_2[0].ToString();
		checkBoxThongbaoTHP.Checked = (FormMain.int_111 > 0);
		checkBoxLuonDanhbang.Checked = (Class7.int_1 > 0);
		checkBoxKhongdanhBang.Checked = (Class7.int_2 > 0);
		checkBoxKhongdanhAc.Checked = (Class7.int_3 > 0);
		textBoxTiepCan.Text = FormMain.int_51.ToString();
		if (Class7.string_4 != null)
		{
			for (int j = 0; j < Class7.string_4.Length; j++)
			{
				if (Class7.string_4[j] != null)
				{
					method_0(listViewLuonDanh, Class10.smethod_1(Class7.string_4[j], 1));
				}
			}
		}
		if (Class7.string_3 != null)
		{
			for (int j = 0; j < Class7.string_3.Length; j++)
			{
				if (Class7.string_3[j] != null)
				{
					method_0(listViewKhongDanh, Class10.smethod_1(Class7.string_3[j], 1));
				}
			}
		}
		if (Class7.string_5 != null)
		{
			for (int j = 0; j < Class7.string_5.Length; j++)
			{
				if (Class7.string_5[j] != null)
				{
					method_0(listViewKhongdanhAc, Class10.smethod_1(Class7.string_5[j], 1));
				}
			}
		}
		string text = null;
		string[] array = Class62.smethod_0();
		if (array != null)
		{
			if (Class62.string_2 == null || Class62.string_2 == string.Empty)
			{
				Class62.string_2 = array[0];
			}
			for (int j = 0; j < array.Length; j++)
			{
				comboBoxTabAddr.Items.Add(array[j]);
				if (Class62.string_2 == array[j])
				{
					text = Class62.string_2;
				}
			}
		}
		if (text == null && Class62.string_2 != null && Class62.string_2 != string.Empty)
		{
			comboBoxTabAddr.Items.Add(Class62.string_2);
			text = Class62.string_2;
		}
		if (text != null)
		{
			comboBoxTabAddr.Text = text;
		}
		if (Class62.int_2 <= 0)
		{
			Class62.int_2 = random_0.Next(int_9, int_10);
			Class55.smethod_10(Class47.string_0, "PortServer", Class62.int_2, "", 0);
		}
		textBoxPassServer.Text = Class62.int_2.ToString();
		textBoxIPConnect.Text = Class62.string_3;
		textBoxConnectPass.Text = Class62.int_3.ToString();
		for (int j = 0; j < string_1.Length; j++)
		{
			comboBoxConnect.Items.Add(string_1[j]);
		}
		comboBoxConnect.Text = string_1[Class62.int_1];
		groupBoxHientai.Enabled = (Class62.int_1 == 0);
		groupBoxConnect.Enabled = (Class62.int_1 > 0);
		if (Class62.string_0 != null)
		{
			for (int j = 0; j < Class62.string_0.Length; j++)
			{
				if (Class62.string_0[j] != null && !(Class62.string_0[j] == string.Empty) && Class62.string_0[j].IndexOf("\t") >= 0)
				{
					if (Class62.string_1 != null && Class62.string_1.Length != 0)
					{
						Array.Resize(ref Class62.string_1, Class62.string_1.Length + 1);
						Class62.string_1[Class62.string_1.Length - 1] = Class62.string_0[j];
					}
					else
					{
						Class62.string_1 = new string[1]
						{
							Class62.string_0[j]
						};
					}
				}
			}
			Class62.string_0 = null;
		}
		string text2 = string_2.Replace("|", Class47.string_3);
		if (Class62.string_1 != null)
		{
			for (int j = 0; j < Class62.string_1.Length; j++)
			{
				if (Class62.string_1[j] != null && Class62.string_1[j] != string.Empty)
				{
					text2 = text2 + Class62.string_1[j] + Class47.string_3;
				}
			}
		}
		richTextBoxStatus.Text = text2;
		int_7 = -1;
		long_0 = Class62.long_0;
		progressBar1.Style = ProgressBarStyle.Continuous;
		timer_0.Interval = 100;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
	}

	private void method_0(ListView listView_0, string string_7)
	{
		string[] array = new string[1]
		{
			string_7
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
		listView_0.Items.Add(listViewItem);
	}

	public static void smethod_0(RichTextBox richTextBox_0, string string_7, bool bool_2 = false)
	{
		if (string_7 != null && !(string_7 == string.Empty))
		{
			if (richTextBox_0.Text != string.Empty)
			{
				string_7 = Class47.string_3 + string_7;
			}
			int num = Class20.GetScrollPos(richTextBox_0.Handle, 1);
			richTextBox_0.AppendText(string_7);
			if (!bool_2)
			{
				Class20.GetScrollRange(richTextBox_0.Handle, 1, out int _, out int int_2);
				int num2 = (richTextBox_0.ClientSize.Height - SystemInformation.HorizontalScrollBarHeight) / richTextBox_0.Font.Height;
				num = int_2 - num2;
			}
			Class20.SetScrollPos(richTextBox_0.Handle, 1, num, bool_0: true);
			Class20.PostMessageA(richTextBox_0.Handle, 277, 4 + 65536 * num, 0);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (int_11 > 0)
		{
			int_11 = FormCompatibility.smethod_5();
			if (int_11 != 0)
			{
				if (int_11 > 0)
				{
					richTextBoxStatus.Text = "Đã tắt firewall.";
				}
			}
			else
			{
				richTextBoxStatus.Text = "Tắt firewall: Có lỗi xảy ra";
			}
			int_11 = 0;
		}
		if (bool_0)
		{
			if (int_1 > 0)
			{
				int_1++;
				if (int_1 > 12)
				{
					checkBoxAcChihuy.Enabled = true;
					int_1 = 0;
				}
			}
			bool flag = Class62.int_0 > 0;
			if (int_7 != Class62.int_0)
			{
				buttonBatdau.Enabled = !flag;
				buttonKetthuc.Enabled = flag;
				comboBoxConnect.Enabled = !flag;
				buttonRandom.Enabled = !flag;
				comboBoxTabAddr.Enabled = !flag;
				int_7 = Class62.int_0;
				textBoxIPConnect.ReadOnly = (Class62.int_0 > 0);
				textBoxConnectPass.ReadOnly = (Class62.int_0 > 0);
				textBoxPassServer.ReadOnly = (Class62.int_0 > 0);
			}
			int_8++;
			if (long_0 == Class62.long_0)
			{
				if (int_8 > 10)
				{
					progressBar1.Style = ProgressBarStyle.Continuous;
					progressBar1.MarqueeAnimationSpeed = 0;
				}
			}
			else
			{
				long_0 = Class62.long_0;
				if (progressBar1.MarqueeAnimationSpeed != 300)
				{
					progressBar1.Style = ProgressBarStyle.Marquee;
					progressBar1.MarqueeAnimationSpeed = 300;
				}
				int_8 = 0;
			}
			if (Class62.string_0 != null)
			{
				for (int i = 0; i < Class62.string_0.Length; i++)
				{
					if (Class62.string_0[i] == null || !(Class62.string_0[i] != string.Empty))
					{
						continue;
					}
					string text = Class62.string_0[i];
					if (text.IndexOf("\t") < 0)
					{
						if (string_3 != text)
						{
							richTextBoxVitri.Text = text;
							string_3 = text;
						}
						continue;
					}
					smethod_0(richTextBoxStatus, text);
					if (Class62.string_1 != null && Class62.string_1.Length != 0)
					{
						Array.Resize(ref Class62.string_1, Class62.string_1.Length + 1);
						Class62.string_1[Class62.string_1.Length - 1] = text;
					}
					else
					{
						Class62.string_1 = new string[1]
						{
							text
						};
					}
				}
				Class62.string_0 = null;
			}
			if (int_6 == int_0)
			{
				return;
			}
			bool_1 = false;
			if (int_6 > 0)
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_6);
				if (0 <= num)
				{
					Class47.smethod_11(FormMain.gstruct42_0[num]);
				}
			}
			int_6 = int_0;
			int num2 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			flag = (0 <= num2);
			string text2 = "[chưa chọn ac]";
			if (flag)
			{
				gstruct42_0 = FormMain.gstruct42_0[num2];
				text2 = "[" + Class10.smethod_1(gstruct42_0.string_20, 1) + "]";
				checkBoxAcChihuy.Checked = (gstruct42_0.int_2 > 0);
			}
			textBoxTen.Text = text2;
			checkBoxAcChihuy.Enabled = flag;
			Thread.Sleep(100);
			bool_1 = true;
		}
		else
		{
			Close();
		}
	}

	private void checkBoxChayNhay_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_35 = Convert.ToByte(checkBoxChayNhay.Checked);
			Class55.smethod_10(Class47.string_0, "flagDanhNguoiChayNhay", FormMain.int_35, "", 0);
		}
	}

	private void checkBoxKhongdanhCapnho_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_81 = Convert.ToByte(checkBoxKhongdanhCapnho.Checked);
			Class55.smethod_10(Class47.string_0, "flagKhongDanhCapnho", FormMain.int_81, "", 0);
		}
	}

	private void numericUpDownKhongdanhCapnho_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_82 = (int)numericUpDownKhongdanhCapnho.Value;
			Class55.smethod_10(Class47.string_0, "ValueCapBoqua", FormMain.int_82, "", 0);
		}
	}

	private void numericUpDownKhongdanhCapnho_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_82 = (int)numericUpDownKhongdanhCapnho.Value;
			Class55.smethod_10(Class47.string_0, "ValueCapBoqua", FormMain.int_82, "", 0);
		}
	}

	private void textBoxKhoangCachlenNgua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_95 = Class11.smethod_12(textBoxKhoangCachlenNgua.Text);
			Class55.smethod_10(Class47.string_0, "KhoangCachLenNguaEx", FormMain.int_95, "", 0);
		}
	}

	private void checkBoxDoiPKTheoAccChinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_79 = Convert.ToByte(checkBoxDoiPKTheoAccChinh.Checked);
			Class55.smethod_10(Class47.string_0, "flagDoiPKTheoAccChinh", FormMain.int_79, "", 0);
		}
	}

	private void checkBoxKhongDanhAccCungbang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_97 = Convert.ToByte(checkBoxKhongDanhAccCungbang.Checked);
			Class55.smethod_10(Class47.string_0, "KhongdanhCungBang", FormMain.int_97, "", 0);
		}
	}

	private void checkBoxBaoCuusat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_14 = Convert.ToByte(checkBoxBaoCuusat.Checked);
			Class55.smethod_10(Class47.string_0, "flagBaoCuusatMat", FormMain.int_14, "", 0);
		}
	}

	private void checkBoxSuado_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_55 = Convert.ToByte(checkBoxSuado.Checked);
			Class55.smethod_10(Class47.string_0, "flagSuadoTaichoEx", FormMain.int_55, "", 0);
		}
	}

	private void buttonThietlapSuado_Click(object sender, EventArgs e)
	{
		if (FormSuado.int_0 > 0)
		{
			FormSuado.int_0 = 0;
		}
		else
		{
			try
			{
				FormSuado formSuado = new FormSuado();
				formSuado.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxTroLaiDiemcu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_80 = Convert.ToByte(checkBoxTroLaiDiemcu.Checked);
			Class55.smethod_10(Class47.string_0, "flagTrolaiDiemcu", FormMain.int_80, "", 0);
		}
	}

	private void checkBoxKhongChaybo_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_19 = Convert.ToByte(checkBoxKhongChaybo.Checked);
			Class55.smethod_10(Class47.string_0, "flagKhongChaybo", FormMain.int_19, "", 0);
		}
	}

	private void labelBoqua_Click(object sender, EventArgs e)
	{
		string text = "Các bản đồ bỏ qua không chạy bộ:|";
		if (Class37.int_0 != null)
		{
			for (int i = 0; i < Class37.int_0.Length; i++)
			{
				string text2 = text;
				text = text2 + (i + 1).ToString() + ". " + Class10.smethod_1(Class33.smethod_1(Class37.int_0[i]), 1) + "|";
			}
		}
		FormTip.smethod_0(FormMain.string_1, text, 600000, 280, 280);
	}

	private void checkBoxAcChinhNghelenh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_7 = Convert.ToByte(checkBoxAcChinhNghelenh.Checked);
			Class55.smethod_10(Class47.string_0, "flagKeo2", FormMain.int_7, "", 0);
		}
	}

	private void checkBoxAcChihuy_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			int num2 = Convert.ToByte(checkBoxAcChihuy.Checked);
			FormMain.gstruct42_0[num].int_2 = num2;
			if (num2 > 0)
			{
				FormMain.int_7 = 0;
				checkBoxAcChinhNghelenh.Checked = false;
				FormMayphu.int_0 = FormMain.gstruct42_0[num].int_129;
				new Thread(FormMayphu.smethod_0).Start();
			}
			else
			{
				int_1 = 1;
				checkBoxAcChihuy.Enabled = false;
			}
		}
	}

	private void buttonHelp_Click(object sender, EventArgs e)
	{
		string str = "https://www.youtube.com/watch?v=5UU-GeLlKZI";
		string text = "HUONG DAN DIEU KEO XE MAY KHAC||Phim hướng dẫn tại đây: " + str + "|(copy dán vào trình duyệt nếu không mở được).||Giả sử có 2 máy, máy bạn điều khiển gọi là máy 1, máy kia là máy 2.||* Máy 1:|- Bạn cho ac phụ nào đó đăng nhập vào phòng tán để nó thông báo vị trí ac chính. Không nên dùng phòng tán công cộng, nên lập phòng tán riêng để tránh bị quấy rối.|- Check vào mục <Ac này sẽ báo vị trí ac chính...>|- Nên cho 2, 3 ac phụ cùng đăng nhập phòng tán và cùng thông báo vị trí để không bị ngắt quãng.||* Máy 2:|- Ac chính máy 2 đăng nhập cùng phòng tán máy 1.|- Check vào mục <Ac chính tìm theo vị trí trong room...>|- Thiết lập theo sau: cho ac chính máy 2 theo sau ac chính máy 1 để khi tìm được thì nó chuyển qua theo sau cho đỡ giật.||Sau đó bạn chỉ việc ngồi ở máy 1 để điều khiển. Ac chính máy 1 đi đâu thì ac chính máy 2 đi theo đó.|Ngoài ra, nếu bạn chuyển chế độ WAR, CTC, CLĐ, đánh quái, đánh người, ưu tiên boss, nhặt đồ, pk... từ máy 1 thì ở máy 2 cũng tự động chuyển theo.|";
		FormTip.smethod_0(FormMain.string_1, text, 600000, 440, 300);
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(string_))
		{
			string_ = Class55.smethod_0();
		}
		Class20.smethod_40(string_, "", str, 0);
	}

	private void checkBoxTHP_Smdb_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_11 = Convert.ToByte(checkBoxTHP_Smdb.Checked);
			Class55.smethod_10(Class47.string_0, "flagLienthongMapAB", FormMain.int_11, "", 0);
		}
	}

	private void labelLienthongGiaithich_Click(object sender, EventArgs e)
	{
		string text = "CHẠY BỘ Ở CÁC MAP LIÊN THÔNG:||Map liên thông là 2 bản đồ kề nhau, chỉ cần đi qua 1 cổng là tới liền. Ví dụ map liên thông:||* Sa mạc 1, 2, 3 -> liên thông Sa mạc địa biểu|* La tiêu sơn -> Lưỡng thủy động.|* v.v..||Tại sao phải chạy bộ?||Bởi nếu sử dụng Thần hành phù thì có thể nó lên đầu cổng, khoảng cách đến ac chính có khi lại xa hơn khi chạy bộ qua cổng.||Đó là chưa kể sẽ bị lag (ví dụ cầu thang ở smđb) hoặc bị sai vị trí (ví dụ lưỡng thủy động có 2 động, cần đến động 1 nhưng thần hành phù lại đến động 2)....||Khi không có map liên thông, hoặc chạy bộ không thành công thì auto sẽ xét đến Thần hành phù.|";
		FormTip.smethod_0(FormMain.string_1, text, 600000, 380, 320);
	}

	private void checkBoxBaoCuusatPhucan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_16 = Convert.ToByte(checkBoxBaoCuusatPhucan.Checked);
			Class55.smethod_10(Class47.string_0, "flagBaoCuusatPhucan", FormMain.int_16, "", 0);
		}
	}

	private void buttonCacChucNangDkTuxa_Click(object sender, EventArgs e)
	{
		string text = "CÁC MỤC MÁY CHÍNH ĐIỀU KHIỂN ĐƯỢC MÁY PHỤ:||1. Tìm ac chính, tìm trong thành|2. Đánh người, quái, ưu tiên boss.|3. Đổi Pk theo ac chính, dame mặc định|4. Đánh Chiến long động: Chọn cổng lên|5. Chiến trường CTC: Thất thành và tam trụ.|6. Đánh Tống Kim: Báo danh, ac chính ac phụ ra khỏi hậu doanh.||7. Phần chuyển thuốc từ hành rương Bang Hội sang Hành trang:|- Máy phụ bạn phải chọn trước tên túi thuốc cần chuyển.|- Máy phụ luôn mặc định là chuyển 5 túi / lần.||8. Web của game (mục cài game): luôn lấy theo máy chính.|9. CTC: mục dùng THP luôn lấy theo máy chính.|10. Đến tọa độ canh boss";
		FormTip.smethod_0(FormMain.string_1, text, 600000, 420, 230);
	}

	private void checkBoxXuongngua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_96 = Convert.ToByte(checkBoxXuongngua.Checked);
			Class55.smethod_10(Class47.string_0, "flagXuongNguaSansang", FormMain.int_96, "", 0);
		}
	}

	private void buttonDanhsachMayphu_Click(object sender, EventArgs e)
	{
		if (FormMayphu.bool_0)
		{
			FormMayphu.bool_0 = false;
		}
		else
		{
			try
			{
				FormMayphu formMayphu = new FormMayphu();
				formMayphu.int_2 = Cursor.Position.X;
				formMayphu.int_3 = Cursor.Position.Y;
				formMayphu.int_4 = base.Width;
				formMayphu.int_5 = base.Height;
				formMayphu.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxRoom_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_8 = Convert.ToByte(checkBoxRoom.Checked);
			Class55.smethod_10(Class47.string_0, "flagBaoroom", FormMain.int_8, "", 0);
		}
	}

	private void checkBoxKhoaChatmat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_9 = Convert.ToByte(checkBoxKhoaChatmat.Checked);
			Class55.smethod_10(Class47.string_0, "flagKhoaChatmat", FormMain.int_9, "", 0);
		}
	}

	private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_48 = Convert.ToByte(checkBoxPassword.Checked);
			Class55.smethod_10(Class47.string_0, "flagPassKeoNhieumay", FormMain.int_48, "", 0);
		}
	}

	private void numericUpDownPassword_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_49 = (int)numericUpDownPassword.Value;
			Class55.smethod_10(Class47.string_0, "PassKeoNhieumay", FormMain.int_49, "", 0);
		}
	}

	private void numericUpDownPassword_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_49 = (int)numericUpDownPassword.Value;
			Class55.smethod_10(Class47.string_0, "PassKeoNhieumay", FormMain.int_49, "", 0);
		}
	}

	private void method_1(ListView listView_0, ref string[] string_7)
	{
		if (string_7 != null && string_7.Length != 0)
		{
			string text = string.Empty;
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				if (listView_0.Items[i].Selected)
				{
					text = listView_0.Items[i].SubItems[0].Text;
					listView_0.Items.RemoveAt(i);
					break;
				}
			}
			if (text == null || text == string.Empty)
			{
				return;
			}
			string[] array = new string[string_7.Length];
			int num = 0;
			for (int i = 0; i < string_7.Length; i++)
			{
				if (text != Class10.smethod_1(string_7[i], 1))
				{
					array[num] = string_7[i];
					num++;
				}
			}
			if (num == 0)
			{
				listView_0.Items.Clear();
				string_7 = null;
				return;
			}
			string_7 = new string[num];
			for (int i = 0; i < num; i++)
			{
				string_7[i] = array[i];
			}
		}
		else
		{
			listView_0.Items.Clear();
			string_7 = null;
		}
	}

	private void method_2(ListView listView_0, string string_7, string[] string_8, ref string[] string_9)
	{
		if (string_7 == null || string_7 == string.Empty || string_8 == null)
		{
			return;
		}
		if (string_9 != null)
		{
			for (int i = 0; i < string_9.Length; i++)
			{
				if (string_7 == Class10.smethod_1(string_9[i], 1))
				{
					return;
				}
			}
		}
		for (int i = 0; i < string_8.Length; i++)
		{
			if (string_7 == Class10.smethod_1(string_8[i], 1))
			{
				string_7 = string_8[i];
				break;
			}
		}
		if (string_9 == null)
		{
			string_9 = new string[1]
			{
				string_7
			};
		}
		else
		{
			string[] array = new string[string_9.Length + 1];
			for (int i = 0; i < string_9.Length; i++)
			{
				array[i] = string_9[i];
			}
			string_9 = new string[array.Length];
			for (int i = 0; i < string_9.Length; i++)
			{
				string_9[i] = array[i];
			}
			string_9[string_9.Length - 1] = string_7;
		}
		method_0(listView_0, Class10.smethod_1(string_7, 1));
	}

	private void comboBoxLuonDanh_MouseDown(object sender, MouseEventArgs e)
	{
		string_4 = null;
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				Class86.smethod_23(FormMain.gstruct42_0[i], ref string_4);
			}
		}
		comboBoxLuonDanh.Items.Clear();
		if (string_4 != null)
		{
			Array.Sort(string_4);
			for (int i = 0; i < string_4.Length; i++)
			{
				comboBoxLuonDanh.Items.Add(Class10.smethod_1(string_4[i], 1));
			}
		}
	}

	private void labelThemLuondanh_Click(object sender, EventArgs e)
	{
		method_2(listViewLuonDanh, comboBoxLuonDanh.Text, string_4, ref Class7.string_4);
		Class7.smethod_1(Class7.string_4, Class7.string_0);
		Class7.uint_1 = Class7.smethod_2(Class7.string_4);
	}

	private void labelXoaLuondanh_Click(object sender, EventArgs e)
	{
		method_1(listViewLuonDanh, ref Class7.string_4);
		Class7.smethod_1(Class7.string_4, Class7.string_0);
		Class7.uint_1 = Class7.smethod_2(Class7.string_4);
	}

	private void comboBoxKhongDanh_MouseDown(object sender, MouseEventArgs e)
	{
		string_5 = null;
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				Class86.smethod_23(FormMain.gstruct42_0[i], ref string_5);
			}
		}
		comboBoxKhongDanh.Items.Clear();
		if (string_5 != null)
		{
			Array.Sort(string_5);
			for (int i = 0; i < string_5.Length; i++)
			{
				comboBoxKhongDanh.Items.Add(Class10.smethod_1(string_5[i], 1));
			}
		}
	}

	private void labelThemKhongdanh_Click(object sender, EventArgs e)
	{
		method_2(listViewKhongDanh, comboBoxKhongDanh.Text, string_5, ref Class7.string_3);
		Class7.smethod_1(Class7.string_3, Class7.string_1);
		Class7.uint_0 = Class7.smethod_2(Class7.string_3);
	}

	private void labelXoaKhongdanh_Click(object sender, EventArgs e)
	{
		method_1(listViewKhongDanh, ref Class7.string_3);
		Class7.smethod_1(Class7.string_3, Class7.string_1);
		Class7.uint_0 = Class7.smethod_2(Class7.string_3);
	}

	private void comboBoxKhongdanhAc_MouseDown(object sender, MouseEventArgs e)
	{
		string_6 = null;
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				Class86.smethod_24(FormMain.gstruct42_0[i], ref string_6, 1);
			}
		}
		comboBoxKhongdanhAc.Items.Clear();
		if (string_6 != null)
		{
			Array.Sort(string_6);
			for (int i = 0; i < string_6.Length; i++)
			{
				comboBoxKhongdanhAc.Items.Add(Class10.smethod_1(string_6[i], 1));
			}
		}
	}

	private void labelThemAcKhongdanh_Click(object sender, EventArgs e)
	{
		method_2(listViewKhongdanhAc, comboBoxKhongdanhAc.Text, string_6, ref Class7.string_5);
		Class7.smethod_1(Class7.string_5, Class7.string_2);
	}

	private void labelThemPTAcKhongdanh_Click(object sender, EventArgs e)
	{
		if (FormMain.gstruct42_0 == null)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			GStruct48 gStruct = Class72.smethod_5(FormMain.gstruct42_0[i]);
			if (gStruct.int_0 <= 0)
			{
				continue;
			}
			for (int j = 0; j < gStruct.int_0; j++)
			{
				bool flag = false;
				if (Class7.string_5 != null)
				{
					for (int k = 0; k < Class7.string_5.Length; k++)
					{
						if (Class7.string_5[k] == gStruct.gstruct47_0[j].string_0)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					if (num == 0)
					{
						Class7.string_5 = new string[0];
						num = 1;
					}
					Array.Resize(ref Class7.string_5, Class7.string_5.Length + 1);
					Class7.string_5[Class7.string_5.Length - 1] = gStruct.gstruct47_0[j].string_0;
				}
			}
		}
		if (num > 0)
		{
			listViewKhongdanhAc.Items.Clear();
			for (int i = 0; i < Class7.string_5.Length; i++)
			{
				method_0(listViewKhongdanhAc, Class10.smethod_1(Class7.string_5[i], 1));
			}
			Class7.smethod_1(Class7.string_5, Class7.string_2);
		}
	}

	private void labelXoaAcKhongdanh_Click(object sender, EventArgs e)
	{
		method_1(listViewKhongdanhAc, ref Class7.string_5);
		Class7.smethod_1(Class7.string_5, Class7.string_2);
	}

	private void checkBoxLuonDanhbang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class7.int_1 = Convert.ToByte(checkBoxLuonDanhbang.Checked);
			Class55.smethod_10(Class47.string_0, "flagLuonDanhBHO", Class7.int_1, "", 0);
		}
	}

	private void checkBoxKhongdanhBang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class7.int_2 = Convert.ToByte(checkBoxKhongdanhBang.Checked);
			Class55.smethod_10(Class47.string_0, "flagKhongDanhBHO", Class7.int_2, "", 0);
		}
	}

	private void checkBoxKhongdanhAc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class7.int_3 = Convert.ToByte(checkBoxKhongdanhAc.Checked);
			Class55.smethod_10(Class47.string_0, "flagKhongdanhAc", Class7.int_3, "", 0);
		}
	}

	private void checkBoxDanhDenchet_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_50 = Convert.ToByte(checkBoxDanhDenchet.Checked);
			Class55.smethod_10(Class47.string_0, "flagDanhDenchet", FormMain.int_50, "", 0);
		}
	}

	private void textBoxTiepCan_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_51 = Class11.smethod_12(textBoxTiepCan.Text);
			Class55.smethod_10(Class47.string_0, "KCAcdanhTiepcan", FormMain.int_51, "", 0);
		}
	}

	private void labelTiepcan_Click(object sender, EventArgs e)
	{
		string text = "KHOẢNG CÁCH TÌM AC CHÍNH CỦA AC ĐÁNH TIẾP CẬN||- Ac đánh tiếp cận ở đây là ac sử dụng chiêu đánh có phạm vi hiệu quả <= 180.|- Yêu cầu: Có check vào mục tiếp cận ở Bảng 1 của auto, và ô giá trị tiếp cận ghi 180 trở xuống.|";
		FormTip.smethod_0(FormMain.string_1, text, 600000, 380, 140);
	}

	private void buttonRandom_Click(object sender, EventArgs e)
	{
		bool_1 = false;
		Class62.int_2 = random_0.Next(int_9, int_10);
		textBoxPassServer.Text = Class62.int_2.ToString();
		Class55.smethod_10(Class47.string_0, "PortServer", Class62.int_2, "", 0);
		bool_1 = true;
		MessageBox.Show("Lưu ý ở máy phụ phải ghi đúng passowrd là " + Class62.int_2 + " thì mới kết nối được.", FormMain.string_1, MessageBoxButtons.OK);
	}

	private void textBoxIPConnect_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class62.string_3 = textBoxIPConnect.Text.Trim();
			Class55.smethod_10(Class47.string_0, "ConnectIP", Class62.string_3, "", 0);
		}
	}

	private void textBoxConnectPass_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class62.int_3 = Class11.smethod_12(textBoxConnectPass.Text.Trim());
			Class55.smethod_10(Class47.string_0, "nPort", Class62.int_3, "", 0);
		}
	}

	private void comboBoxConnect_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		for (int i = 0; i < string_1.Length; i++)
		{
			if (comboBoxConnect.Text == string_1[i])
			{
				Class62.int_1 = i;
				break;
			}
		}
		groupBoxHientai.Enabled = (Class62.int_1 == 0);
		groupBoxConnect.Enabled = (Class62.int_1 > 0);
		Class55.smethod_10(Class47.string_0, "KieuConnect", Class62.int_1, "", 0);
	}

	private void buttonBatdau_Click(object sender, EventArgs e)
	{
		if (Class62.int_1 > 0)
		{
			if (Class62.int_3 < int_9 || Class62.int_3 > int_10)
			{
				MessageBox.Show("Pasword không hợp lệ, nó phải giống như password ở máy chính.", FormMain.string_1, MessageBoxButtons.OK);
				return;
			}
			Class62.int_0 = 1;
			Class62.class64_0 = new Class64();
			new Thread(Class62.class64_0.method_1).Start();
		}
		else
		{
			if (Class62.string_3 == null || Class62.string_3 == string.Empty)
			{
				Class62.string_3 = comboBoxTabAddr.Text;
			}
			if (Class62.int_2 < int_9 || Class62.int_2 > int_10)
			{
				Class62.int_2 = random_0.Next(int_9, int_10);
				Class55.smethod_10(Class47.string_0, "PortServer", Class62.int_2, "", 0);
				textBoxPassServer.Text = Class62.int_2.ToString();
				MessageBox.Show("Password phải là số từ " + int_9 + " -> " + int_10 + ", auto tự động lấy lại password khác là " + Class62.int_2, FormMain.string_1, MessageBoxButtons.OK);
			}
			Class62.int_0 = 1;
			Class62.class63_0 = new Class63();
			new Thread(Class62.class63_0.method_1).Start();
		}
		int_7 = -1;
	}

	private void buttonKetthuc_Click(object sender, EventArgs e)
	{
		FormMain.int_6 = 0;
		checkBoxAcChinhNghelenh.Checked = false;
		Class62.int_0 = 0;
		try
		{
			if (Class62.int_1 <= 0)
			{
				Class62.class63_0.method_2();
			}
			else
			{
				Class62.class64_0.method_2();
			}
		}
		catch
		{
		}
		int_7 = -1;
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		richTextBoxStatus.Text = string.Empty;
	}

	private void textBoxPassServer_Leave(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class11.smethod_12(textBoxPassServer.Text);
			if (num < int_9 || num > int_10)
			{
				num = random_0.Next(int_9, int_10);
				textBoxPassServer.Text = num.ToString();
				MessageBox.Show("Password phải là số từ " + int_9 + " -> " + int_10 + ", auto tự động lấy lại password khác là " + num, FormMain.string_1, MessageBoxButtons.OK);
			}
			Class62.int_2 = num;
			Class55.smethod_10(Class47.string_0, "PortServer", Class62.int_2, "", 0);
		}
	}

	private void buttonHuongdan_Click(object sender, EventArgs e)
	{
		string str = "https://youtu.be/i3Z-5BdmXF0";
		string text = "Phim hướng dẫn tại đây: " + str + "||(copy dán vào trình duyệt nếu không mở được)";
		FormTip.smethod_0(FormMain.string_1, text, 600000, 440, 100);
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(string_))
		{
			string_ = Class55.smethod_0();
		}
		Class20.smethod_40(string_, "", str, 0);
	}

	private void checkBoxTHP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class31.int_0 = Convert.ToByte(checkBoxTHP.Checked);
			Class55.smethod_10(Class47.string_0, "KieuSudungTHP", Class31.int_0, "", 0);
		}
	}

	private void textBoxKytuLenh_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			string text = textBoxKytuLenh.Text;
			if (text == string.Empty)
			{
				text = "|";
			}
			FormMayphu.string_2 = text[0].ToString();
			Class55.smethod_10(Class47.string_0, "SMayphu", FormMayphu.string_2, "", 0);
		}
	}

	private void comboBoxTabAddr_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class62.string_2 = comboBoxTabAddr.Text;
		}
	}

	private void buttonCopy_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText(comboBoxTabAddr.Text);
		}
		catch
		{
		}
	}

	private void checkBoxThongbaoTHP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_111 = Convert.ToByte(checkBoxThongbaoTHP.Checked);
			Class55.smethod_10(Class47.string_0, "fThongbaoTHP", FormMain.int_111, "", 0);
		}
	}

	private void checkBoxBaoCsKenhbang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_15 = Convert.ToByte(checkBoxBaoCsKenhbang.Checked);
			Class55.smethod_10(Class47.string_0, "flagBaoCuusatBang", FormMain.int_15, "", 0);
		}
	}

	private void buttonTatFireWall_Click(object sender, EventArgs e)
	{
		int_11 = 1;
	}
}
