using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormChayBoss : Form
{
	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private CheckBox checkBoxTuLuuRuong;

	private ComboBox comboBoxTenTat;

	private TextBox textBoxToado;

	private Label label1;

	private Button buttonThem;

	private Button buttonXoa;

	private Button buttonSua;

	private Label label2;

	private Button buttonLen;

	private Button buttonXuong;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonMacdinh;

	private ColumnHeader columnHeader_2;

	private Button buttonApdungAll;

	private GroupBox groupBox1;

	private Label label3;

	private Label label4;

	private CheckBox checkBoxTrolaiDiemcu;

	private Button buttonLuu;

	private Button buttonXem;

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static string string_0 = null;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	private static bool bool_2 = false;

	private static bool bool_3 = false;

	public static int int_4 = Class55.smethod_3("flagLuuRuongChayBoss", 0, "1");

	public static int int_5 = Class55.smethod_3("flagDiemcuChayBoss", 0, "1");

	public static string[,] string_1 = new string[105, 5]
	{
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"PDĐ.1 213.182",
			"213.182",
			"11",
			"11|20|202",
			"Phù Dung động"
		},
		{
			"PDĐ.2 192.188",
			"192.188",
			"11",
			"11|20|202",
			"Phù Dung động"
		},
		{
			"PDĐ.3 200.195",
			"200.195",
			"11",
			"11|20|202",
			"Phù Dung động"
		},
		{
			"PDĐ.4 193.177",
			"193.177",
			"11",
			"11|20|202",
			"Phù Dung động"
		},
		{
			"PDĐ.5 185.176",
			"185.176",
			"11",
			"11|20|202",
			"Phù Dung động"
		},
		{
			"PDĐ.6 191.166",
			"191.166",
			"11",
			"11|20|202",
			"Phù Dung động"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"PTĐ.1 205.202",
			"205.202",
			"37",
			"37|100|204",
			"Phi Thiên động"
		},
		{
			"PTĐ.2 219.220",
			"219.220",
			"37",
			"37|100|204",
			"Phi Thiên động"
		},
		{
			"PTĐ.3 182.225",
			"182.225",
			"37",
			"37|100|204",
			"Phi Thiên động"
		},
		{
			"PTĐ.4 175.212",
			"175.212",
			"37",
			"37|100|204",
			"Phi Thiên động"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"TKĐ.1 211.188",
			"211.188",
			"162",
			"176|174|198",
			"Thanh Khê động"
		},
		{
			"TKĐ.2 192.176",
			"192.176",
			"162",
			"176|174|198",
			"Thanh Khê động"
		},
		{
			"TKĐ.3 202.199",
			"202.199",
			"162",
			"176|174|198",
			"Thanh Khê động"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"VLĐ.1 225.187",
			"225.187",
			"78",
			"78|53|199",
			"Vũ Lăng động"
		},
		{
			"VLĐ.2 209.200",
			"209.200",
			"78",
			"78|53|199",
			"Vũ Lăng động"
		},
		{
			"VLĐ.3 181.185",
			"181.185",
			"78",
			"78|53|199",
			"Vũ Lăng động"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"LTĐ.1 0.0",
			"0.0",
			"162",
			"176|174|179|181",
			"Lưỡng Thủy động"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"DTĐ.1 0.0",
			"0.0",
			"80",
			"80|101|205",
			"Dương Trung động"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"NTĐ.1 0.0",
			"0.0",
			"11",
			"11|9|10",
			"Nhạn Thạch động"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"SBĐ.1 0.0",
			"0.0",
			"1",
			"78|53|74|76",
			"Sơn Bảo động"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"KLĐ.1 0.0",
			"0.0",
			"1",
			"78|53|74|76|75",
			"Khỏa Lang động"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"TBN.1 164.149",
			"164.149",
			"1",
			"37|319|320|321",
			"Trường Bạch Sơn Nam"
		},
		{
			"TBN.2 183.148",
			"183.148",
			"1",
			"37|319|320|321",
			"Trường Bạch Sơn Nam"
		},
		{
			"TBN.3 148.175",
			"148.175",
			"1",
			"37|319|320|321",
			"Trường Bạch Sơn Nam"
		},
		{
			"TBN.4 124.180",
			"124.180",
			"1",
			"37|319|320|321",
			"Trường Bạch Sơn Nam"
		},
		{
			"TBN.5 127.186",
			"127.186",
			"1",
			"37|319|320|321",
			"Trường Bạch Sơn Nam"
		},
		{
			"TBN.6 172.193",
			"172.193",
			"1",
			"37|319|320|321",
			"Trường Bạch Sơn Nam"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"TBB.1 222.202",
			"222.202",
			"37",
			"37|319|320|322",
			"Trường Bạch Sơn Bắc"
		},
		{
			"TBB.2 248.202",
			"248.202",
			"37",
			"37|319|320|322",
			"Trường Bạch Sơn Bắc"
		},
		{
			"TBB.3 237.202",
			"237.202",
			"37",
			"37|319|320|322",
			"Trường Bạch Sơn Bắc"
		},
		{
			"TBB.4 211.218",
			"211.218",
			"37",
			"37|319|320|322",
			"Trường Bạch Sơn Bắc"
		},
		{
			"TBB.5 203.221",
			"203.221",
			"37",
			"37|319|320|322",
			"Trường Bạch Sơn Bắc"
		},
		{
			"TBB.6 226.230",
			"226.230",
			"37",
			"37|319|320|322",
			"Trường Bạch Sơn Bắc"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"MCQ.1 167.183",
			"167.183",
			"11",
			"1|121|340",
			"Mạc Cao Quật"
		},
		{
			"MCQ.2 175.201",
			"175.201",
			"11",
			"1|121|340",
			"Mạc Cao Quật"
		},
		{
			"MCQ.3 206.205",
			"206.205",
			"11",
			"1|121|340",
			"Mạc Cao Quật"
		},
		{
			"MCQ.4 231.177",
			"231.177",
			"11",
			"1|121|340",
			"Mạc Cao Quật"
		},
		{
			"MCQ.5 219.205",
			"219.205",
			"11",
			"1|121|340",
			"Mạc Cao Quật"
		},
		{
			"MCQ.6 225.194",
			"225.194",
			"11",
			"1|121|340",
			"Mạc Cao Quật"
		},
		{
			"MCQ.7 185.205",
			"185.205",
			"11",
			"1|121|340",
			"Mạc Cao Quật"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"SMĐB.1 215.178",
			"215.178",
			"176",
			"1|121|131|136|224",
			"Sa Mạc địa biểu"
		},
		{
			"SMĐB.2 230.185",
			"230.185",
			"176",
			"1|121|131|136|224",
			"Sa Mạc địa biểu"
		},
		{
			"SMĐB.3 188.190",
			"188.190",
			"176",
			"1|121|131|136|224",
			"Sa Mạc địa biểu"
		},
		{
			"SMĐB.4 210.192",
			"210.192",
			"176",
			"1|121|131|136|224",
			"Sa Mạc địa biểu"
		},
		{
			"SMĐB.5 211.200",
			"211.200",
			"176",
			"1|121|131|136|224",
			"Sa Mạc địa biểu"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"SM1.1 194.205",
			"194.205",
			"176",
			"1|121|131|136|224|225",
			"Sa Mạc 1"
		},
		{
			"SM1.2 180.210",
			"180.210",
			"176",
			"1|121|131|136|224|225",
			"Sa Mạc 1"
		},
		{
			"SM1.3 176.216",
			"176.216",
			"176",
			"1|121|131|136|224|225",
			"Sa Mạc 1"
		},
		{
			"SM1.4 160.203",
			"160.203",
			"176",
			"1|121|131|136|224|225",
			"Sa Mạc 1"
		},
		{
			"SM1.5 176.194",
			"176.194",
			"176",
			"1|121|131|136|224|225",
			"Sa Mạc 1"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"SM2.1 215.201",
			"215.201",
			"176",
			"1|121|131|136|224|226",
			"Sa Mạc 2"
		},
		{
			"SM2.2 0.0",
			"0.0",
			"176",
			"1|121|131|136|224|226",
			"Sa Mạc 2"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"SM3.1 0.0",
			"0.0",
			"176",
			"1|121|131|136|224|227",
			"Sa Mạc 3"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"PLĐ.1 0.0",
			"0.0",
			"78",
			"1|121|336",
			"Phong Lăng độ"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"LA.1 154.209",
			"154.209",
			"176",
			"176",
			"Lâm An"
		},
		{
			"LA.2 150.192",
			"150.192",
			"176",
			"176",
			"Lâm An"
		},
		{
			"LA.3 140.168",
			"140.168",
			"176",
			"176",
			"Lâm An"
		},
		{
			"LA.4 0.0",
			"0.0",
			"176",
			"176",
			"Lâm An"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"BK.1 200.176",
			"200.176",
			"37",
			"37",
			"Biện Kinh"
		},
		{
			"BK.2 252.175",
			"252.175",
			"37",
			"37",
			"Biện Kinh"
		},
		{
			"BK.3 222.212",
			"222.212",
			"37",
			"37",
			"Biện Kinh"
		},
		{
			"BK.4 0.0",
			"0.0",
			"37",
			"37",
			"Biện Kinh"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"PhTuong.1 177.204",
			"177.204",
			"1",
			"1",
			"Phượng Tường"
		},
		{
			"PhTuong.2 225.191",
			"225.191",
			"1",
			"1",
			"Phượng Tường"
		},
		{
			"PhTuong.3 229.213",
			"229.213",
			"1",
			"1",
			"Phượng Tường"
		},
		{
			"PhTuong.4 0.0",
			"0.0",
			"1",
			"1",
			"Phượng Tường"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"DC.1 202.180",
			"202.180",
			"80",
			"80",
			"Dương Châu"
		},
		{
			"DC.2 193.210",
			"193.210",
			"80",
			"80",
			"Dương Châu"
		},
		{
			"DC.3 0.0",
			"0.0",
			"80",
			"80",
			"Dương Châu"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"ĐL.1 225.207",
			"225.207",
			"162",
			"162",
			"Đại Lý"
		},
		{
			"ĐL.2 223.186",
			"223.186",
			"162",
			"162",
			"Đại Lý"
		},
		{
			"ĐL.3 165.196",
			"165.196",
			"162",
			"162",
			"Đại Lý"
		},
		{
			"ĐL.4 0.0",
			"0.0",
			"162",
			"162",
			"Đại Lý"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"TD.1 174.190",
			"174.190",
			"78",
			"78",
			"Tương Dương"
		},
		{
			"TD.2 212.209",
			"212.209",
			"78",
			"78",
			"Tương Dương"
		},
		{
			"TD.3 210.221",
			"210.221",
			"78",
			"78",
			"Tương Dương"
		},
		{
			"TD.4 0.0",
			"0.0",
			"78",
			"78",
			"Tương Dương"
		},
		{
			"...",
			"0.0",
			"0",
			"0|0|0|0",
			""
		},
		{
			"TĐô.1 374.302",
			"374.302",
			"11",
			"11",
			"Thành Đô"
		},
		{
			"TĐô.2 419.320",
			"419.320",
			"11",
			"11",
			"Thành Đô"
		},
		{
			"TĐô.3 375.328",
			"375.328",
			"11",
			"11",
			"Thành Đô"
		},
		{
			"TĐô.4 0.0",
			"0.0",
			"11",
			"11",
			"Thành Đô"
		}
	};

	private static uint[,] uint_0 = new uint[16, 2]
	{
		{
			50623u,
			103604u
		},
		{
			51068u,
			103064u
		},
		{
			51342u,
			102634u
		},
		{
			51791u,
			102826u
		},
		{
			52274u,
			103089u
		},
		{
			52747u,
			103373u
		},
		{
			53154u,
			103872u
		},
		{
			53811u,
			104488u
		},
		{
			54303u,
			104980u
		},
		{
			54894u,
			105541u
		},
		{
			55437u,
			106016u
		},
		{
			55687u,
			106294u
		},
		{
			56139u,
			107021u
		},
		{
			56468u,
			107432u
		},
		{
			56827u,
			108330u
		},
		{
			57112u,
			108848u
		}
	};

	public static string[,] string_2 = smethod_0();

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormChayBoss));
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		checkBoxTuLuuRuong = new System.Windows.Forms.CheckBox();
		comboBoxTenTat = new System.Windows.Forms.ComboBox();
		textBoxToado = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		buttonThem = new System.Windows.Forms.Button();
		buttonXoa = new System.Windows.Forms.Button();
		buttonSua = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		buttonLen = new System.Windows.Forms.Button();
		buttonXuong = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonMacdinh = new System.Windows.Forms.Button();
		buttonApdungAll = new System.Windows.Forms.Button();
		groupBox1 = new System.Windows.Forms.GroupBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		checkBoxTrolaiDiemcu = new System.Windows.Forms.CheckBox();
		buttonLuu = new System.Windows.Forms.Button();
		buttonXem = new System.Windows.Forms.Button();
		groupBox1.SuspendLayout();
		SuspendLayout();
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3]
		{
			columnHeader_0,
			columnHeader_1,
			columnHeader_2
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(3, 84);
		listView1.MultiSelect = false;
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(348, 277);
		listView1.TabIndex = 0;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		columnHeader_0.Text = "Tên tắt";
		columnHeader_0.Width = 110;
		columnHeader_1.Text = "Tọa độ";
		columnHeader_1.Width = 80;
		columnHeader_2.Text = "Tên đầy đủ";
		columnHeader_2.Width = 130;
		checkBoxTuLuuRuong.AutoSize = true;
		checkBoxTuLuuRuong.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxTuLuuRuong.Location = new System.Drawing.Point(3, 488);
		checkBoxTuLuuRuong.Name = "checkBoxTuLuuRuong";
		checkBoxTuLuuRuong.Size = new System.Drawing.Size(225, 17);
		checkBoxTuLuuRuong.TabIndex = 162;
		checkBoxTuLuuRuong.Text = "Lưu rương trước khi chạy đến tọa độ boss";
		checkBoxTuLuuRuong.UseVisualStyleBackColor = true;
		checkBoxTuLuuRuong.CheckedChanged += new System.EventHandler(checkBoxTuLuuRuong_CheckedChanged);
		comboBoxTenTat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxTenTat.FormattingEnabled = true;
		comboBoxTenTat.Location = new System.Drawing.Point(57, 56);
		comboBoxTenTat.Name = "comboBoxTenTat";
		comboBoxTenTat.Size = new System.Drawing.Size(79, 21);
		comboBoxTenTat.TabIndex = 163;
		textBoxToado.Location = new System.Drawing.Point(57, 82);
		textBoxToado.Name = "textBoxToado";
		textBoxToado.Size = new System.Drawing.Size(79, 20);
		textBoxToado.TabIndex = 164;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(12, 82);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(42, 13);
		label1.TabIndex = 165;
		label1.Text = "Tọa độ";
		buttonThem.Location = new System.Drawing.Point(142, 80);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(72, 23);
		buttonThem.TabIndex = 166;
		buttonThem.Text = "Thêm mới";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		buttonXoa.Location = new System.Drawing.Point(221, 54);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(45, 23);
		buttonXoa.TabIndex = 167;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		buttonSua.Location = new System.Drawing.Point(142, 54);
		buttonSua.Name = "buttonSua";
		buttonSua.Size = new System.Drawing.Size(72, 23);
		buttonSua.TabIndex = 168;
		buttonSua.Text = "Sửa";
		buttonSua.UseVisualStyleBackColor = true;
		buttonSua.Click += new System.EventHandler(buttonSua_Click);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(12, 61);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(26, 13);
		label2.TabIndex = 169;
		label2.Text = "Tên";
		buttonLen.ForeColor = System.Drawing.Color.DarkGreen;
		buttonLen.Location = new System.Drawing.Point(273, 54);
		buttonLen.Name = "buttonLen";
		buttonLen.Size = new System.Drawing.Size(60, 23);
		buttonLen.TabIndex = 170;
		buttonLen.Text = "Lên";
		buttonLen.UseVisualStyleBackColor = true;
		buttonLen.Click += new System.EventHandler(buttonLen_Click);
		buttonXuong.ForeColor = System.Drawing.Color.DarkGreen;
		buttonXuong.Location = new System.Drawing.Point(273, 80);
		buttonXuong.Name = "buttonXuong";
		buttonXuong.Size = new System.Drawing.Size(60, 23);
		buttonXuong.TabIndex = 171;
		buttonXuong.Text = "Xuống";
		buttonXuong.UseVisualStyleBackColor = true;
		buttonXuong.Click += new System.EventHandler(buttonXuong_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonMacdinh.ForeColor = System.Drawing.Color.Black;
		buttonMacdinh.Location = new System.Drawing.Point(145, 529);
		buttonMacdinh.Name = "buttonMacdinh";
		buttonMacdinh.Size = new System.Drawing.Size(92, 38);
		buttonMacdinh.TabIndex = 172;
		buttonMacdinh.Text = "Xóa tọa độ về mặc định";
		buttonMacdinh.UseVisualStyleBackColor = true;
		buttonMacdinh.Click += new System.EventHandler(buttonMacdinh_Click);
		buttonApdungAll.ForeColor = System.Drawing.Color.Black;
		buttonApdungAll.Location = new System.Drawing.Point(256, 529);
		buttonApdungAll.Name = "buttonApdungAll";
		buttonApdungAll.Size = new System.Drawing.Size(94, 38);
		buttonApdungAll.TabIndex = 173;
		buttonApdungAll.Text = "Lưu thay đổi và đóng";
		buttonApdungAll.UseVisualStyleBackColor = true;
		buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		groupBox1.Controls.Add(label3);
		groupBox1.Controls.Add(buttonXuong);
		groupBox1.Controls.Add(buttonLen);
		groupBox1.Controls.Add(label2);
		groupBox1.Controls.Add(buttonSua);
		groupBox1.Controls.Add(buttonXoa);
		groupBox1.Controls.Add(buttonThem);
		groupBox1.Controls.Add(label1);
		groupBox1.Controls.Add(textBoxToado);
		groupBox1.Controls.Add(comboBoxTenTat);
		groupBox1.Location = new System.Drawing.Point(3, 367);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(347, 116);
		groupBox1.TabIndex = 175;
		groupBox1.TabStop = false;
		groupBox1.Text = "Thêm bớt - Chỉnh sửa tọa độ";
		label3.Location = new System.Drawing.Point(12, 20);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(318, 28);
		label3.TabIndex = 172;
		label3.Text = "Cột tọa độ ghi 0.0 là chưa có tọa độ boss, người dùng phải tự sửa hoặc thêm vào (hoặc để 0.0 nếu muốn ac chạy lên đầu cổng)";
		label4.Location = new System.Drawing.Point(3, 3);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(344, 71);
		label4.TabIndex = 173;
		//label4.Text = componentResourceManager.GetString("label4.Text");
		checkBoxTrolaiDiemcu.AutoSize = true;
		checkBoxTrolaiDiemcu.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxTrolaiDiemcu.Location = new System.Drawing.Point(237, 488);
		checkBoxTrolaiDiemcu.Name = "checkBoxTrolaiDiemcu";
		checkBoxTrolaiDiemcu.Size = new System.Drawing.Size(96, 17);
		checkBoxTrolaiDiemcu.TabIndex = 177;
		checkBoxTrolaiDiemcu.Text = "Trở lại điểm cũ";
		checkBoxTrolaiDiemcu.UseVisualStyleBackColor = true;
		checkBoxTrolaiDiemcu.CheckedChanged += new System.EventHandler(checkBoxTrolaiDiemcu_CheckedChanged);
		buttonLuu.ForeColor = System.Drawing.Color.Purple;
		buttonLuu.Location = new System.Drawing.Point(3, 529);
		buttonLuu.Name = "buttonLuu";
		buttonLuu.Size = new System.Drawing.Size(65, 38);
		buttonLuu.TabIndex = 178;
		buttonLuu.Text = "Lưu vào tệp";
		buttonLuu.UseVisualStyleBackColor = true;
		buttonLuu.Click += new System.EventHandler(buttonLuu_Click);
		buttonXem.ForeColor = System.Drawing.Color.Purple;
		buttonXem.Location = new System.Drawing.Point(74, 529);
		buttonXem.Name = "buttonXem";
		buttonXem.Size = new System.Drawing.Size(65, 38);
		buttonXem.TabIndex = 179;
		buttonXem.Text = "Xem lại tệp";
		buttonXem.UseVisualStyleBackColor = true;
		buttonXem.Click += new System.EventHandler(buttonXem_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(357, 572);
		base.Controls.Add(buttonXem);
		base.Controls.Add(buttonLuu);
		base.Controls.Add(checkBoxTrolaiDiemcu);
		base.Controls.Add(label4);
		base.Controls.Add(groupBox1);
		base.Controls.Add(buttonApdungAll);
		base.Controls.Add(buttonMacdinh);
		base.Controls.Add(checkBoxTuLuuRuong);
		base.Controls.Add(listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormChayBoss";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "BOSS";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormChayBoss_Load);
		groupBox1.ResumeLayout(performLayout: false);
		groupBox1.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private static string[,] smethod_0()
	{
		string text = Class11.smethod_28(Class47.string_5 + "\\ToadoBoss.txt", 0, 0, 1);
		if (text != null && !(text == string.Empty))
		{
			string[] array = text.Split('\r', '\n');
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			string[,] array2 = new string[array.Length, 5];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null || array[i] == string.Empty)
				{
					continue;
				}
				string[] array3 = array[i].Split('ÿ');
				if (array3.Length == 5 && smethod_1(array3[0]))
				{
					if (Class11.smethod_3(array3[0], "PhTuong"))
					{
						flag = true;
					}
					if (Class11.smethod_3(array3[0], "SBĐ"))
					{
						flag2 = true;
					}
					for (int j = 0; j < 5; j++)
					{
						array2[num, j] = array3[j];
					}
					num++;
				}
			}
			if (!flag || !flag2)
			{
				bool_3 = true;
			}
			if (num == array2.GetLength(0))
			{
				return array2;
			}
			string[,] array4 = new string[num, 5];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					array4[i, j] = array2[i, j];
				}
			}
			return array4;
		}
		return string_1;
	}

	private static bool smethod_1(string string_3)
	{
		if (string_3 != null && !(string_3 == string.Empty))
		{
			int num = Class11.smethod_2(string_3, ".");
			if (num > 0)
			{
				string_3 = string_3.Substring(0, num);
			}
			for (int i = 0; i < string_1.GetLength(0); i++)
			{
				if (Class11.smethod_2(string_1[i, 0], string_3) == 0)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	public static int smethod_2(GStruct42 gstruct42_0)
	{
		int num = 0;
		int int_ = gstruct42_0.int_129;
		int num2 = 0;
		int num3 = gstruct42_0.int_0;
		long long_ = 0L;
		uint[] array = null;
		if (num3 >= 0 && string_2.GetLength(0) > num3)
		{
			string text = string_2[num3, 0];
			if (text != null && !(text == string.Empty) && !(text == "...") && text[0] != '.')
			{
				string[] array2 = string_2[num3, 1].Split('/', '.', ',');
				if (array2.Length < 2)
				{
					num = 1;
				}
				else
				{
					int num4 = Class11.smethod_12(string_2[num3, 2]);
					if (num4 > 0)
					{
						uint[] array3 = new uint[2]
						{
							Class11.smethod_13(array2[0]) * 256,
							Class11.smethod_13(array2[1]) * 512
						};
						string[] array4 = string_2[num3, 3].Split('|');
						int[] array5 = new int[array4.Length];
						for (int i = 0; i < array5.Length; i++)
						{
							array5[i] = Class11.smethod_12(array4[i]);
						}
						int num5 = array5[array5.Length - 1];
						if (num5 > 0)
						{
							bool flag = int_4 <= 0;
							bool flag2 = false;
							int num6 = 0;
							int num7 = 0;
							int num8 = 0;
							int num9 = 0;
							int num10 = 0;
							int num11 = 0;
							int num12 = -1;
							int num13 = 0;
							long long_2 = 0L;
							uint[,] array6 = new uint[5, 2]
							{
								{
									51861u,
									103030u
								},
								{
									51702u,
									102708u
								},
								{
									51492u,
									102482u
								},
								{
									51707u,
									102044u
								},
								{
									51565u,
									101624u
								}
							};
							GStruct22 gStruct = default(GStruct22);
							int num14 = 0;
							int num15 = -1;
							int num16 = 0;
							int num17 = -1;
							int int_2 = 0;
							byte[] byte_ = new byte[4];
							while (true)
							{
								Thread.Sleep(180);
								int num18 = Class71.smethod_3(FormMain.gstruct42_0, int_);
								uint num22;
								bool flag3;
								int num31;
								bool flag5;
								uint[] array7;
								int num25;
								int i;
								if (!Class11.bool_0 && num18 >= 0 && FormMain.gstruct42_0[num18].bool_36)
								{
									gstruct42_0 = FormMain.gstruct42_0[num18];
									if (num14 == 0)
									{
										if (Class38.gstruct29_0.int_0 == gstruct42_0.int_129)
										{
											Class38.gstruct29_0.bool_1 = true;
										}
										Class60.smethod_50(gstruct42_0, Class10.smethod_2("<color=yellow>Bắt đầu chạy điểm boss..."));
										num14 = 1;
									}
									if (num3 == gstruct42_0.int_0 && gstruct42_0.bool_1)
									{
										uint num19 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
										uint num20 = Class20.smethod_30(num19 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
										uint num21 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
										num22 = num21 + num20 * Class47.gstruct43_15.uint_0;
										int num23 = (int)Class20.smethod_30(num22 + Class47.gstruct43_55.uint_0, gstruct42_0.int_130);
										int num24 = (int)Class20.smethod_30(num22 + Class47.gstruct43_50.uint_0, gstruct42_0.int_130);
										num25 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
										int num26 = (int)Class20.smethod_30(num22 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
										int num27 = Class73.smethod_40(gstruct42_0);
										if (num24 > 0 && num25 > 0 && num23 != 10 && num23 != 21 && num27 > 1)
										{
											if (num17 != num25)
											{
												num16 = 0;
												num17 = num25;
											}
											if (num15 >= 0 && num15 == num26)
											{
												array7 = new uint[2]
												{
													Class20.smethod_30(num22 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
													Class20.smethod_30(num22 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
												};
												flag3 = (array3 == null || array3[0] == 0 || array3[1] == 0);
												if (num25 == num5 && (flag || int_4 <= 0 || num26 > 0))
												{
													flag = true;
													num16 = 0;
													if (!flag3)
													{
														if (0 > num12 || num12 == num26)
														{
															long num28 = Class53.smethod_18(array7, array3);
															if (num28 >= 100000L)
															{
																if (array == null)
																{
																	array = new uint[2]
																	{
																		array7[0],
																		array7[1]
																	};
																	num2 = 0;
																}
																if (num2 > 2)
																{
																	bool flag4 = array != null && Class53.smethod_18(array, array7) < 180000L;
																	array = null;
																	if (flag4)
																	{
																		Class20.WriteProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_2);
																		Class53.smethod_0(gstruct42_0, array7, array3, 600);
																		goto IL_1175;
																	}
																}
																if (Class20.smethod_30(num22 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) == 0 && gstruct42_0.bool_64 && Class11.smethod_23(long_2) > 600L)
																{
																	Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
																	long_2 = Class11.smethod_22();
																}
																if (num25 == 224)
																{
																	num28 = Class53.smethod_21(array6, array7);
																	if (num28 < 200000L)
																	{
																		int length = array6.GetLength(0);
																		uint[] uint_ = new uint[2]
																		{
																			array6[0, 0],
																			array6[0, 1]
																		};
																		uint[] array8 = new uint[2]
																		{
																			array6[length - 1, 0],
																			array6[length - 1, 1]
																		};
																		long num29 = Class53.smethod_18(array7, uint_);
																		long num30 = Class53.smethod_18(array7, array8);
																		if (num29 < num30)
																		{
																			Class53.smethod_22(gstruct42_0, array6, array7, array8, num25);
																		}
																	}
																}
																if (!Class12.smethod_4(gstruct42_0) || Class11.smethod_23(long_) > 5000L)
																{
																	num2++;
																	num12 = num26;
																	Class12.smethod_1(gstruct42_0, array3);
																	long_ = Class11.smethod_22();
																}
																goto IL_1175;
															}
															num = 1;
															break;
														}
														num = -1;
														break;
													}
													num = 1;
													break;
												}
												if (FormMain.int_11 > 0 && num26 > 0)
												{
													gStruct = Class37.smethod_3(num25, num5);
													if (gStruct.int_0 == num25 && gStruct.int_1 == num5 && gStruct.uint_0 != null)
													{
														goto IL_0d08;
													}
												}
												uint[] array9 = null;
												num31 = array5.Length;
												flag5 = false;
												if (!flag2)
												{
													if (num13 <= 0)
													{
														num13 = ((num25 == num4) ? 1 : 0);
													}
													if (num31 > 1)
													{
														i = 0;
														while (i < array5.Length)
														{
															if (array5[i] != num25)
															{
																i++;
																continue;
															}
															goto IL_06cf;
														}
													}
												}
												if (!flag && int_4 > 0)
												{
													if (num31 == 1 && !flag3)
													{
														array9 = Class37.smethod_9(array3, num4, "R­¬ng chøa ®å");
													}
													if (gstruct42_0.bool_63 && num9 < 2)
													{
														flag = Class31.smethod_61(gstruct42_0, num4, null, array9, bool_1: true);
														num9++;
														goto IL_1175;
													}
													num26 = (int)Class20.smethod_30(num22 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
													if (num26 <= 0)
													{
														num25 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
														if (num25 == num4)
														{
															flag = (int_4 <= 0 || Class81.smethod_0(gstruct42_0, bool_0: true, array9) > 0);
														}
														else
														{
															num13 = 2;
															if (flag2 = (Class44.smethod_5(gstruct42_0, num4) > 0))
															{
																Thread.Sleep(300);
																Class53.smethod_9(gstruct42_0);
															}
														}
														goto IL_1175;
													}
													int[] array10 = new int[4]
													{
														224,
														225,
														226,
														227
													};
													bool flag6 = false;
													bool flag7 = false;
													for (i = 0; i < array10.Length; i++)
													{
														if (num5 == array10[i])
														{
															flag6 = true;
														}
														if (num25 == array10[i])
														{
															flag7 = true;
														}
													}
													if (flag6 && flag7)
													{
														gStruct = Class37.smethod_3(num25, num5);
														goto IL_0d08;
													}
													if (!Class53.smethod_13(gstruct42_0))
													{
														Thread.Sleep(100);
														num = 1;
													}
													else
													{
														Thread.Sleep(300);
														Class53.smethod_9(gstruct42_0);
														num = -1;
													}
													break;
												}
												num10++;
												flag2 = false;
												goto IL_085f;
											}
											for (int j = 0; j < 8; j++)
											{
												if (num26 == num15)
												{
													break;
												}
												if (num15 <= 0)
												{
													break;
												}
												num26 = (int)Class20.smethod_30(num22 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
												Thread.Sleep(100);
											}
											num15 = num26;
											num16 = 0;
											goto IL_1175;
										}
										num = -2;
										break;
									}
									num = -1;
									Class12.smethod_3(gstruct42_0, bool_0: false);
									break;
								}
								num = -1;
								break;
								IL_1175:
								Thread.Sleep(150);
								continue;
								IL_0fc0:
								if (num25 == 224)
								{
									long num28 = Class53.smethod_21(array6, array7);
									if (num28 < 200000L)
									{
										int length = array6.GetLength(0);
										uint[] uint_ = new uint[2]
										{
											array6[0, 0],
											array6[0, 1]
										};
										uint[] array8 = new uint[2]
										{
											array6[length - 1, 0],
											array6[length - 1, 1]
										};
										long num29 = Class53.smethod_18(array7, uint_);
										long num30 = Class53.smethod_18(array7, array8);
										if (num29 < num30)
										{
											Class53.smethod_22(gstruct42_0, array6, array7, array8, num25, bool_0: true);
										}
									}
								}
								goto IL_107f;
								IL_0bd1:
								num25 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
								int num32 = -1;
								for (i = 0; i < array5.Length; i++)
								{
									if (num25 == array5[i])
									{
										num32 = i;
										break;
									}
								}
								if (num32 >= 0 && array5.Length - 1 > num32)
								{
									gStruct = Class37.smethod_3(num25, array5[num32 + 1]);
									if (gStruct.uint_0 == null)
									{
										num = 1;
										break;
									}
									goto IL_0d08;
								}
								num25 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
								if (num25 == num5 && num11 <= 3)
								{
									num11++;
									if (!flag)
									{
										flag = (num11 > 2);
									}
									goto IL_1175;
								}
								num = 1;
								break;
								IL_085f:
								if (gstruct42_0.bool_63 && num6 < 2 && Class31.smethod_61(gstruct42_0, num5))
								{
									Thread.Sleep(300);
									Class53.smethod_9(gstruct42_0);
									num6++;
									goto IL_1175;
								}
								num6 = 2;
								if (num10 == 1)
								{
									int num26 = (int)Class20.smethod_30(num22 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
									if (num26 > 0)
									{
										if (flag5)
										{
											goto IL_0af0;
										}
										if (num13 < 2)
										{
											num13 = 2;
											if (Class53.smethod_13(gstruct42_0))
											{
												Thread.Sleep(300);
												Class53.smethod_9(gstruct42_0);
												goto IL_1175;
											}
										}
									}
									if (int_5 > 0 && num13 == 1 && Class44.smethod_2(gstruct42_0, "®iÓm cò") > 0)
									{
										num10 = 0;
										num13 = 2;
										Thread.Sleep(300);
										Class53.smethod_9(gstruct42_0);
										Thread.Sleep(300);
										int num33 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
										if (num33 == num5)
										{
											goto IL_1175;
										}
										if (num33 != num25)
										{
											if (num31 > 1)
											{
												i = 0;
												while (i < array5.Length)
												{
													if (array5[i] != num25)
													{
														i++;
														continue;
													}
													goto IL_1175;
												}
											}
											if (Class53.smethod_13(gstruct42_0))
											{
												Thread.Sleep(300);
												Class53.smethod_9(gstruct42_0);
												goto IL_1175;
											}
											num = -1;
											break;
										}
									}
									num13 = 2;
									num10 = 2;
									if (Class44.smethod_4(gstruct42_0, array5[num31 - 1]) > 0)
									{
										Thread.Sleep(300);
										Class53.smethod_9(gstruct42_0);
										goto IL_1175;
									}
									num25 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
									if (num25 != array5[0])
									{
										if (gstruct42_0.bool_63 && num7 < 2)
										{
											uint[] array9 = null;
											if (num31 == 1 && !flag3)
											{
												array9 = Class37.smethod_9(array3, array5[0], "NGOAITHANH");
											}
											num7++;
											if (Class31.smethod_61(gstruct42_0, array5[0], null, array9))
											{
												Thread.Sleep(300);
												Class53.smethod_9(gstruct42_0);
												goto IL_1175;
											}
										}
										if (Class44.smethod_5(gstruct42_0, array5[0]) > 0)
										{
											Thread.Sleep(300);
											Class53.smethod_9(gstruct42_0);
										}
										goto IL_1175;
									}
								}
								goto IL_0af0;
								IL_06cf:
								flag5 = true;
								if (i <= 0)
								{
									num10++;
									goto IL_085f;
								}
								goto IL_0bd1;
								IL_0d08:
								Class20.WriteProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_2);
								array7 = new uint[2]
								{
									Class20.smethod_30(num22 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_0.int_130),
									Class20.smethod_30(num22 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_0.int_130)
								};
								int num34 = 0;
								if (gStruct.uint_0.GetLength(0) > 1)
								{
									num34 = Class53.smethod_20(gStruct.uint_0, array7);
								}
								uint[] uint_2 = null;
								uint[] uint_3 = null;
								int num35 = 0;
								Class53.smethod_6(gStruct.uint_0, num34, ref uint_2, ref uint_3, ref num35);
								long num36 = Class53.smethod_18(array7, uint_2);
								if (num36 > 240000L)
								{
									if (array == null)
									{
										array = new uint[2]
										{
											array7[0],
											array7[1]
										};
										num2 = 0;
									}
									if (num2 > 12)
									{
										long num37 = Class53.smethod_18(array, array7);
										if (num37 < 180000L)
										{
											Class20.WriteProcessMemory(gstruct42_0.int_130, num22 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_2);
											Class53.smethod_0(gstruct42_0, array7, uint_2, 600);
										}
										array = null;
									}
									if (num25 == 53 && num5 == 199)
									{
										Class53.smethod_22(gstruct42_0, uint_0, array7, null, num25, bool_0: false, 8000);
										goto IL_1175;
									}
									int num26 = (int)Class20.smethod_30(num22 + Class47.gstruct43_43.uint_0, gstruct42_0.int_130);
									if (num26 <= 0)
									{
										int[] array11 = Class53.smethod_7(num25);
										if (array11 == null || array11[1] != 0)
										{
											goto IL_0fc0;
										}
										uint[] array12 = Class37.smethod_9(uint_2, num25, "NGOAITHANH");
										if (array12 != null)
										{
											long num38 = Class53.smethod_18(uint_2, array12);
											if (num38 <= 400000000L)
											{
												uint[,] array13 = Class44.smethod_1(num25, array7, array12);
												if (array13 != null)
												{
													int num39 = Class53.smethod_20(array13, array12);
													if (num39 >= 0)
													{
														uint[] uint_4 = new uint[2]
														{
															array13[num39, 0],
															array13[num39, 1]
														};
														long num40 = Class53.smethod_18(array7, uint_4);
														if (num40 > 90000L)
														{
															Class12.smethod_3(gstruct42_0, bool_0: false);
															Class53.smethod_22(gstruct42_0, array13, array7, array12, num25, bool_0: true, 6000);
															goto IL_1175;
														}
														goto IL_0fc0;
													}
												}
											}
										}
									}
									goto IL_107f;
								}
								Class53.smethod_23(gstruct42_0, uint_2, num35, uint_3, gStruct.int_1);
								goto IL_1175;
								IL_107f:
								if (!Class12.smethod_4(gstruct42_0) || Class11.smethod_23(long_) > 5000L)
								{
									num2 += 3;
									Class12.smethod_1(gstruct42_0, uint_2);
									long_ = Class11.smethod_22();
									Thread.Sleep(300);
								}
								if (Class20.smethod_30(num22 + Class47.gstruct43_44.uint_0, gstruct42_0.int_130) == 0 && gstruct42_0.bool_64 && Class11.smethod_23(long_2) > 600L)
								{
									Class60.smethod_55(gstruct42_0, "Switch([[horse]])");
									long_2 = Class11.smethod_22();
								}
								goto IL_1175;
								IL_0af0:
								int num41 = -1;
								if (gstruct42_0.bool_63 && num8 < 2)
								{
									for (i = 0; i < num31; i++)
									{
										int num42 = array5[num31 - i - 1];
										if (0 <= Class31.smethod_58(num42))
										{
											num41 = num42;
											break;
										}
									}
									if (num41 > 0 && Class31.smethod_61(gstruct42_0, num41))
									{
										Thread.Sleep(300);
										Class53.smethod_9(gstruct42_0);
										num8++;
										goto IL_1175;
									}
									num8 = 2;
								}
								num41 = -1;
								for (i = 0; i < num31 && Class53.smethod_7(array5[i]) != null; i++)
								{
									num41 = array5[i];
								}
								num25 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_0.int_130);
								if (num25 == num41)
								{
									goto IL_0bd1;
								}
								if (num41 > 0 && Class44.smethod_5(gstruct42_0, num41) > 0)
								{
									Thread.Sleep(300);
									Class53.smethod_9(gstruct42_0);
								}
								num16++;
								if (num16 <= 3)
								{
									goto IL_1175;
								}
								gStruct = Class37.smethod_3(num25, num5);
								if (gStruct.int_0 != num25 || gStruct.int_1 != num5 || gStruct.uint_0 == null)
								{
									num16 = 0;
									goto IL_1175;
								}
								goto IL_0d08;
							}
						}
						else
						{
							num = 1;
						}
					}
					else
					{
						num = 1;
					}
				}
			}
			else
			{
				num = 1;
			}
		}
		else
		{
			num = 1;
		}
		if (num > 0 && Class38.gstruct29_0.int_0 == gstruct42_0.int_129)
		{
			Class38.gstruct29_0.bool_1 = false;
		}
		Class12.smethod_3(gstruct42_0, bool_0: false);
		Class60.smethod_50(gstruct42_0, Class10.smethod_2("<color=yellow>Kết thúc chạy điểm boss !"));
		return num;
	}

	public FormChayBoss()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		string text = string.Empty;
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				string text2 = string.Empty;
				for (int j = 0; j < string_2.GetLength(1); j++)
				{
					if (text2 != string.Empty)
					{
						text2 += 'ÿ';
					}
					text2 += string_2[i, j];
				}
				if (text != string.Empty)
				{
					text += '\r';
				}
				text += text2;
			}
		}
		Class11.smethod_29(Class47.string_5 + "\\ToadoBoss.txt", text, 1);
		bool_0 = false;
	}

	private void FormChayBoss_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		if (0 <= int_0 && 0 <= int_1)
		{
			int num = int_0 - base.Width;
			int num2 = int_1 + int_3 - base.Height;
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
		checkBoxTuLuuRuong.Checked = (int_4 > 0);
		checkBoxTrolaiDiemcu.Checked = (int_5 > 0);
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				method_0(listView1, string_2[i, 0], string_2[i, 1], string_2[i, 4]);
			}
		}
		string text = string.Empty;
		for (int i = 0; i < string_1.GetLength(0); i++)
		{
			string text2 = string_1[i, 0];
			int num3 = Class11.smethod_2(text2, ".");
			if (num3 > 0)
			{
				text2 = text2.Substring(0, num3);
			}
			if (!(text == string.Empty))
			{
				if (!smethod_3(text, text2))
				{
					text = text + "|" + text2;
				}
			}
			else
			{
				text = text2;
			}
			if (i == 70)
			{
				Thread.Sleep(10);
			}
		}
		string[] array = text.Split('|');
		for (int i = 0; i < array.Length; i++)
		{
			comboBoxTenTat.Items.Add(array[i]);
		}
		comboBoxTenTat.Text = array[0];
		Thread.Sleep(150);
		if (bool_3)
		{
			string string_ = "Chưa được cập nhật Phượng Tường và Sơn Bảo động, bấm nút sau để cập nhật lại phần này:||1. Bấm nút <Lưu vào tệp> để đề phòng cần xem lại tọa độ.||2. Bấm nút <Xóa tọa độ về mặc định> để hiển thị phần Phượng Tường.||";
			FormTip.smethod_0("DIEM BOSS", string_, 600000, 300, 180, bool_5: false, base.Left, base.Top);
		}
		timer_0.Interval = 100;
		timer_0.Enabled = true;
		bool_2 = true;
		base.TopMost = true;
	}

	private static bool smethod_3(string string_3, string string_4)
	{
		return Class11.smethod_2(string_3, string_4) >= 0;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void method_0(ListView listView_0, string string_3, string string_4, string string_5)
	{
		string[] array = new string[3]
		{
			string_3,
			string_4,
			string_5
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

	private int method_1(ListView listView_0)
	{
		if (listView_0.Items != null)
		{
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				if (listView_0.Items[i].Selected)
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void checkBoxTuLuuRuong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int_4 = Convert.ToByte(checkBoxTuLuuRuong.Checked);
			Class55.smethod_10(Class47.string_0, "flagLuuRuongChayBoss", int_4, "", 0);
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_2)
		{
			return;
		}
		int num = method_1(listView1);
		if (num >= 0)
		{
			string text = string_0 = listView1.Items[num].SubItems[0].Text;
			int num2 = Class11.smethod_2(text, ".");
			if (num2 > 0)
			{
				text = text.Substring(0, num2);
			}
			comboBoxTenTat.Text = text;
			textBoxToado.Text = listView1.Items[num].SubItems[1].Text;
		}
	}

	private void buttonSua_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_2)
		{
			return;
		}
		string text = textBoxToado.Text.Trim().Replace(" ", "").Replace("/", ".")
			.Replace(",", ".");
		if (Class11.smethod_2(text, ".") <= 0)
		{
			return;
		}
		int num = method_1(listView1);
		if (num >= 0 && string_2.GetLength(0) > num)
		{
			string text2 = listView1.Items[num].SubItems[0].Text;
			string text3 = listView1.Items[num].SubItems[1].Text;
			listView1.Items[num].SubItems[0].Text = text2.Replace(text3, text);
			listView1.Items[num].SubItems[1].Text = text;
			int num2 = Class11.smethod_2(string_2[num, 0], " ");
			if (num2 > 0)
			{
				string_2[num, 0] = string_2[num, 0].Substring(0, num2) + " " + text;
			}
			string_2[num, 1] = text;
			bool_1 = true;
		}
	}

	private void buttonMacdinh_Click(object sender, EventArgs e)
	{
		string text = "Huong dan: Bấm <Lưu vào tệp> đề phòng muốn xem lại tọa độ cũ." + Class47.string_3 + Class47.string_3 + "Bạn chắc chắn muốn xóa dữ liệu tọa độ boss hiện tại để đưa về mặc định của auto ?";
		if (MessageBox.Show(text, FormMain.string_1, MessageBoxButtons.YesNo) != DialogResult.No)
		{
			string_2 = string_1;
			listView1.Items.Clear();
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				method_0(listView1, string_2[i, 0], string_2[i, 1], string_2[i, 4]);
			}
			bool_1 = true;
			bool_3 = false;
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		int num = method_1(listView1);
		if (num < 0 || string_2.GetLength(0) <= num)
		{
			return;
		}
		listView1.Items.RemoveAt(num);
		int num2 = num;
		int count = listView1.Items.Count;
		if (count > 0)
		{
			if (count <= num)
			{
				num = count - 1;
			}
			listView1.TopItem = listView1.Items[num];
			listView1.Items[num].Focused = true;
			listView1.Items[num].Selected = true;
		}
		if (string_2 == null)
		{
			return;
		}
		string[,] array = new string[string_2.GetLength(0) - 1, string_2.GetLength(1)];
		int num3 = 0;
		for (int i = 0; i < string_2.GetLength(0); i++)
		{
			if (i != num2)
			{
				for (int j = 0; j < string_2.GetLength(1); j++)
				{
					array[num3, j] = string_2[i, j];
				}
				num3++;
			}
		}
		string_2 = array;
		bool_1 = true;
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (string_2 == null)
		{
			string_2 = string_1;
			listView1.Items.Clear();
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				method_0(listView1, string_2[i, 0], string_2[i, 1], string_2[i, 4]);
			}
			bool_1 = true;
			return;
		}
		int num = -1;
		int num2 = 1;
		string text = "...";
		string text2 = "0.0";
		string text3 = comboBoxTenTat.Text;
		if (!(text3 == "..."))
		{
			text2 = textBoxToado.Text.Replace(",", ".").Replace("/", ".");
			if (Class11.smethod_2(text2, ".") <= 0)
			{
				string string_ = "Tọa độ sai qui cách, phải là dạng XXX.YYY (ví dụ: 123.456)";
				FormTip.smethod_0(FormMain.string_1, string_, 600000, 250, 80);
				return;
			}
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				if (Class11.smethod_2(string_2[i, 0], text3) == 0)
				{
					num2++;
				}
			}
			for (int i = 0; i < string_1.GetLength(0); i++)
			{
				if (Class11.smethod_2(string_1[i, 0], text3) == 0)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				string string_ = "Tên tắt Không có trong danh sách, bạn bấm nút Xóa đưa về tọa độ mặc định để lấy tên tắt.|";
				FormTip.smethod_0(FormMain.string_1, string_, 600000, 280, 100);
				return;
			}
			text = text3 + "." + num2 + " " + text2;
		}
		string[,] array = new string[string_2.GetLength(0) + 1, string_2.GetLength(1)];
		for (int i = 0; i < string_2.GetLength(0); i++)
		{
			for (int j = 0; j < string_2.GetLength(1); j++)
			{
				array[i, j] = string_2[i, j];
			}
		}
		int length = string_2.GetLength(0);
		string text4 = string.Empty;
		array[length, 0] = text;
		array[length, 1] = text2;
		array[length, 2] = "0";
		array[length, 3] = "0|0|0|0";
		array[length, 4] = text4;
		if (text != "...")
		{
			for (int j = 2; j < string_2.GetLength(1); j++)
			{
				array[length, j] = string_1[num, j];
			}
			text4 = string_1[num, 4];
		}
		string_2 = array;
		method_0(listView1, text, text2, text4);
		length = listView1.Items.Count;
		listView1.TopItem = listView1.Items[length - 1];
		listView1.Items[length - 1].Focused = true;
		listView1.Items[length - 1].Selected = true;
		bool_1 = true;
	}

	private void buttonLen_Click(object sender, EventArgs e)
	{
		int num = method_1(listView1);
		if (num <= 0 || string_2 == null)
		{
			return;
		}
		int count = listView1.Items[num].SubItems.Count;
		for (int i = 0; i < count; i++)
		{
			string text = listView1.Items[num].SubItems[i].Text;
			listView1.Items[num].SubItems[i].Text = listView1.Items[num - 1].SubItems[i].Text;
			listView1.Items[num - 1].SubItems[i].Text = text;
		}
		if (num == listView1.TopItem.Index)
		{
			listView1.TopItem = listView1.Items[num - 1];
		}
		listView1.Items[num - 1].Focused = true;
		listView1.Items[num - 1].Selected = true;
		if (string_2.GetLength(0) > 1)
		{
			for (int i = 0; i < string_2.GetLength(1); i++)
			{
				string text = string_2[num, i];
				string_2[num, i] = string_2[num - 1, i];
				string_2[num - 1, i] = text;
			}
		}
		bool_1 = true;
	}

	private void buttonXuong_Click(object sender, EventArgs e)
	{
		int num = method_1(listView1);
		if (num <= 0 || string_2.GetLength(0) - 1 <= num || string_2 == null)
		{
			return;
		}
		int count = listView1.Items[num].SubItems.Count;
		for (int i = 0; i < count; i++)
		{
			string text = listView1.Items[num].SubItems[i].Text;
			listView1.Items[num].SubItems[i].Text = listView1.Items[num + 1].SubItems[i].Text;
			listView1.Items[num + 1].SubItems[i].Text = text;
		}
		if (num - listView1.TopItem.Index > 12)
		{
			listView1.TopItem = listView1.Items[num + 1];
		}
		listView1.Items[num + 1].Focused = true;
		listView1.Items[num + 1].Selected = true;
		if (string_2.GetLength(0) > 1)
		{
			for (int i = 0; i < string_2.GetLength(1); i++)
			{
				string text = string_2[num, i];
				string_2[num, i] = string_2[num + 1, i];
				string_2[num + 1, i] = text;
			}
		}
		bool_1 = true;
	}

	private void checkBoxTrolaiDiemcu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int_5 = Convert.ToByte(checkBoxTrolaiDiemcu.Checked);
			Class55.smethod_10(Class47.string_0, "flagDiemcuChayBoss", int_5, "", 0);
		}
	}

	private void buttonLuu_Click(object sender, EventArgs e)
	{
		string text = Class47.string_5 + "\\ToadoBossLuu.txt";
		if (Class11.smethod_18(text))
		{
			string text2 = "Lệnh lưu vào tệp sẽ ghi đè tọa độ boss hiện có vào tệp ToadoBossLuu.txt cũ, nên những tọa độ cũ trong tệp sẽ mất hết và thay thế vào đó là tọa độ boss hiện tại." + Class47.string_3 + Class47.string_3 + "Bạn có chắc chắn muốn lưu vào tệp không ?";
			if (MessageBox.Show(text2, "TOA_DO_BOSS", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
		}
		string text3 = string.Empty;
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				if (string_2.GetLength(1) >= 2)
				{
					object obj = text3;
					text3 = string.Concat(obj, i, ". ", string_2[i, 0], "\t : ", string_2[i, 1], Class47.string_3);
				}
			}
		}
		Class11.smethod_29(text, text3, 1);
		MessageBox.Show("Đã lưu tọa độ boss vào tệp: " + Class47.string_3 + text, "TOA DO BOSS", MessageBoxButtons.OK);
	}

	private void buttonXem_Click(object sender, EventArgs e)
	{
		string string_ = Class11.smethod_28(Class47.string_5 + "\\ToadoBossLuu.txt", 0, 0, 1);
		FormTip.smethod_0("TOA DO BOSS (LUU)", string_, 900000, 260, 400);
	}
}
