using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormVideoHelp : Form
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	private string string_0 = null;

	public static string string_1 = "KYKeoxe (Kim Yến Kéo xe)||Sử dụng được cho hầu hết các game lậu hiện tại. Nếu có ý kiến đóng góp xin inbox liên hệ Kim Yến:||- Fb: https://www.facebook.com/auto.kimyen|- Web: http://kimyen.net||Mặc định khi mới sử dụng sẽ là giảm CPU mức 1 (màn hình game màu đen), các bạn bấm F10 để bỏ giảm nếu muốn||Lưu ý không nên dùng chung auto vlbs_pk, vì khi dùng chung rất dễ diss game.||==============================================||Khi cài đặt auto lần đầu tiên (hoặc vừa update game) thì bạn phải qua tab Cài game, chọn web đang chơi (nếu không có thì bấm dò web)||Các thiết lập phần chữ màu nâu đỏ sẽ được áp dụng chung cho tất cả acc, các thiết lập chữ đen hoặc màu khác nâu đỏ chỉ áp dụng riêng cho từng acc.||Khi bắt đầu sử dụng, bấm chọn map chiến đấu (WAR hoặc CTC). Bấm tiếp nút [A] để add ac vào, sau đó chọn ac chính, xong stick vào tên nhân vật để chạy. Nếu stick tìm ac chính thì ac chính đi đâu, ac phụ sẽ đi theo đó.||Để xem ac nào bị diss thì bấm nút [OF] để xem danh sách, sau đó log lại acc, hoặc cũng có thể dùng chức năng login của auto để tự động log lại nếu game bị diss.||Phim hướng dẫn cách sử dụng: Bấm tab Phụ trợ của auto, bấm tiếp Phim Hướng dẫn.|";

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Label label1;

	private TextBox textBoxTK;

	private Button buttonTongKim;

	private Button buttonTrain;

	private TextBox textBoxTrain;

	private Label label2;

	private Button buttonRuong24o;

	private TextBox textBoxRuong24o;

	private Label label3;

	private Button buttonLogin;

	private TextBox textBoxLogin;

	private Label label4;

	private Button buttonNhieuMay;

	private TextBox textBoxNhieuMay;

	private Label label6;

	private Button buttonCTC;

	private TextBox textBoxCTC;

	private Label label7;

	private Button buttonTamtru;

	private TextBox textBoxTamtru;

	private Label label8;

	private Button buttonChayNhim;

	private TextBox textBoxChayNhim;

	private Label label9;

	private Button buttonEvent;

	private TextBox textBoxEvent;

	private Label label10;

	private Button buttonTinhLuyen;

	private TextBox textBoxTinhLuyen;

	private Label label11;

	private CheckBox checkBoxKhongHienthi;

	private Button buttonClose;

	private Label Thongtin;

	private Label label5;

	private Button buttonHelp;

	private LinkLabel linkLabelLinkWeb;

	private Button buttonChuyenThuoc;

	private TextBox textBoxChuyenThuoc;

	private Label label12;

	public FormVideoHelp()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormVideoHelp_Load(object sender, EventArgs e)
	{
		if (int_0 >= 0 && int_1 >= 0)
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
		checkBoxKhongHienthi.Checked = (FormMain.int_10 > 0);
		string_0 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(string_0))
		{
			string_0 = Class55.smethod_0();
		}
		Thread.Sleep(100);
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

	private void buttonTongKim_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxTK.Text, 0);
	}

	private void buttonTrain_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxTrain.Text, 0);
	}

	private void buttonRuong24o_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxRuong24o.Text, 0);
	}

	private void buttonLogin_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxLogin.Text, 0);
	}

	private void buttonNhieuMay_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxNhieuMay.Text, 0);
	}

	private void buttonCTC_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxCTC.Text, 0);
	}

	private void buttonTamtru_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxTamtru.Text, 0);
	}

	private void buttonChayNhim_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxChayNhim.Text, 0);
	}

	private void buttonEvent_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxEvent.Text, 0);
	}

	private void buttonTinhLuyen_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxTinhLuyen.Text, 0);
	}

	private void checkBoxKhongHienthi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			FormMain.int_10 = Convert.ToByte(checkBoxKhongHienthi.Checked);
			Class55.smethod_10(Class47.string_0, "KhongHienThiVideoHelp", FormMain.int_10, "", 0);
			if (FormMain.int_10 > 0)
			{
				Thongtin.Text = "Bạn có thể bật lại bảng này ở Phụ trợ -> Hướng dẫn";
				linkLabelLinkWeb.Visible = false;
			}
			else
			{
				Thongtin.Text = string.Empty;
				linkLabelLinkWeb.Visible = true;
			}
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void buttonHelp_Click(object sender, EventArgs e)
	{
		string text = string_1;
		if (GClass1.string_3 != null && GClass1.string_3 != string.Empty)
		{
			text = text + "|==============================================|LƯU Ý:||" + GClass1.string_3;
		}
		if (FormMain.string_6 != null && FormMain.string_6 != string.Empty)
		{
			text = text + "|==============================================|PHIÊN BẢN MỚI:||" + FormMain.string_6;
		}
		FormTip.smethod_0(FormMain.string_1, text, 600000, 450, 540, bool_5: false, base.Left, base.Top);
	}

	private void linkLabelLinkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Class20.smethod_40(string_0, "", "http://kimyen.net", 0);
	}

	private void buttonChuyenThuoc_Click(object sender, EventArgs e)
	{
		Class20.smethod_40(string_0, "", textBoxChuyenThuoc.Text, 0);
	}

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormVideoHelp));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		label1 = new System.Windows.Forms.Label();
		textBoxTK = new System.Windows.Forms.TextBox();
		buttonTongKim = new System.Windows.Forms.Button();
		buttonTrain = new System.Windows.Forms.Button();
		textBoxTrain = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		buttonRuong24o = new System.Windows.Forms.Button();
		textBoxRuong24o = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		buttonLogin = new System.Windows.Forms.Button();
		textBoxLogin = new System.Windows.Forms.TextBox();
		label4 = new System.Windows.Forms.Label();
		buttonNhieuMay = new System.Windows.Forms.Button();
		textBoxNhieuMay = new System.Windows.Forms.TextBox();
		label6 = new System.Windows.Forms.Label();
		buttonCTC = new System.Windows.Forms.Button();
		textBoxCTC = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		buttonTamtru = new System.Windows.Forms.Button();
		textBoxTamtru = new System.Windows.Forms.TextBox();
		label8 = new System.Windows.Forms.Label();
		buttonChayNhim = new System.Windows.Forms.Button();
		textBoxChayNhim = new System.Windows.Forms.TextBox();
		label9 = new System.Windows.Forms.Label();
		buttonEvent = new System.Windows.Forms.Button();
		textBoxEvent = new System.Windows.Forms.TextBox();
		label10 = new System.Windows.Forms.Label();
		buttonTinhLuyen = new System.Windows.Forms.Button();
		textBoxTinhLuyen = new System.Windows.Forms.TextBox();
		label11 = new System.Windows.Forms.Label();
		checkBoxKhongHienthi = new System.Windows.Forms.CheckBox();
		buttonClose = new System.Windows.Forms.Button();
		Thongtin = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		buttonHelp = new System.Windows.Forms.Button();
		linkLabelLinkWeb = new System.Windows.Forms.LinkLabel();
		buttonChuyenThuoc = new System.Windows.Forms.Button();
		textBoxChuyenThuoc = new System.Windows.Forms.TextBox();
		label12 = new System.Windows.Forms.Label();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.ForeColor = System.Drawing.Color.DarkRed;
		label1.Location = new System.Drawing.Point(2, 33);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(207, 13);
		label1.TabIndex = 15;
		label1.Text = "* Hướng dẫn chung về cài đặt và sử dụng";
		textBoxTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxTK.Location = new System.Drawing.Point(15, 50);
		textBoxTK.Name = "textBoxTK";
		textBoxTK.ReadOnly = true;
		textBoxTK.Size = new System.Drawing.Size(251, 20);
		textBoxTK.TabIndex = 16;
		textBoxTK.Text = "https://youtu.be/5H9Ita4GE9k";
		buttonTongKim.Location = new System.Drawing.Point(273, 49);
		buttonTongKim.Name = "buttonTongKim";
		buttonTongKim.Size = new System.Drawing.Size(70, 21);
		buttonTongKim.TabIndex = 17;
		buttonTongKim.Text = "Xem phim";
		buttonTongKim.UseVisualStyleBackColor = true;
		buttonTongKim.Click += new System.EventHandler(buttonTongKim_Click);
		buttonTrain.Location = new System.Drawing.Point(273, 92);
		buttonTrain.Name = "buttonTrain";
		buttonTrain.Size = new System.Drawing.Size(70, 21);
		buttonTrain.TabIndex = 20;
		buttonTrain.Text = "Xem phim";
		buttonTrain.UseVisualStyleBackColor = true;
		buttonTrain.Click += new System.EventHandler(buttonTrain_Click);
		textBoxTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxTrain.Location = new System.Drawing.Point(15, 93);
		textBoxTrain.Name = "textBoxTrain";
		textBoxTrain.ReadOnly = true;
		textBoxTrain.Size = new System.Drawing.Size(251, 20);
		textBoxTrain.TabIndex = 19;
		textBoxTrain.Text = "http://kimyen.net/phuchoi.htm";
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(12, 76);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(205, 13);
		label2.TabIndex = 18;
		label2.Text = "Hướng dẫn bơm thuốc phục hồi (hậu cần)";
		buttonRuong24o.Location = new System.Drawing.Point(273, 136);
		buttonRuong24o.Name = "buttonRuong24o";
		buttonRuong24o.Size = new System.Drawing.Size(70, 21);
		buttonRuong24o.TabIndex = 23;
		buttonRuong24o.Text = "Xem phim";
		buttonRuong24o.UseVisualStyleBackColor = true;
		buttonRuong24o.Click += new System.EventHandler(buttonRuong24o_Click);
		textBoxRuong24o.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxRuong24o.Location = new System.Drawing.Point(15, 137);
		textBoxRuong24o.Name = "textBoxRuong24o";
		textBoxRuong24o.ReadOnly = true;
		textBoxRuong24o.Size = new System.Drawing.Size(251, 20);
		textBoxRuong24o.TabIndex = 22;
		textBoxRuong24o.Text = "https://youtu.be/1duqVxbJRKk";
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(12, 120);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(267, 13);
		label3.TabIndex = 21;
		label3.Text = "Hướng dẫn combo nhồi thuốc (nút nhồi thuốc - bảng 1)";
		buttonLogin.Location = new System.Drawing.Point(273, 445);
		buttonLogin.Name = "buttonLogin";
		buttonLogin.Size = new System.Drawing.Size(70, 21);
		buttonLogin.TabIndex = 26;
		buttonLogin.Text = "Xem phim";
		buttonLogin.UseVisualStyleBackColor = true;
		buttonLogin.Click += new System.EventHandler(buttonLogin_Click);
		textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxLogin.Location = new System.Drawing.Point(15, 446);
		textBoxLogin.Name = "textBoxLogin";
		textBoxLogin.ReadOnly = true;
		textBoxLogin.Size = new System.Drawing.Size(251, 20);
		textBoxLogin.TabIndex = 25;
		textBoxLogin.Text = "https://youtu.be/U8VlHTvbIyU";
		label4.AutoSize = true;
		label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label4.Location = new System.Drawing.Point(12, 429);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(223, 13);
		label4.TabIndex = 24;
		label4.Text = "Hướng dẫn sử dụng auto Login (phần phụ trợ)";
		buttonNhieuMay.Location = new System.Drawing.Point(273, 186);
		buttonNhieuMay.Name = "buttonNhieuMay";
		buttonNhieuMay.Size = new System.Drawing.Size(70, 21);
		buttonNhieuMay.TabIndex = 32;
		buttonNhieuMay.Text = "Xem phim";
		buttonNhieuMay.UseVisualStyleBackColor = true;
		buttonNhieuMay.Click += new System.EventHandler(buttonNhieuMay_Click);
		textBoxNhieuMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxNhieuMay.Location = new System.Drawing.Point(15, 187);
		textBoxNhieuMay.Name = "textBoxNhieuMay";
		textBoxNhieuMay.ReadOnly = true;
		textBoxNhieuMay.Size = new System.Drawing.Size(251, 20);
		textBoxNhieuMay.TabIndex = 31;
		textBoxNhieuMay.Text = "https://youtu.be/5UU-GeLlKZI";
		label6.AutoSize = true;
		label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label6.Location = new System.Drawing.Point(12, 170);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(254, 13);
		label6.TabIndex = 30;
		label6.Text = "Hướng dẫn Kéo xe nhiều máy (nút mở rộng - bảng 1)";
		buttonCTC.Location = new System.Drawing.Point(273, 229);
		buttonCTC.Name = "buttonCTC";
		buttonCTC.Size = new System.Drawing.Size(70, 21);
		buttonCTC.TabIndex = 35;
		buttonCTC.Text = "Xem phim";
		buttonCTC.UseVisualStyleBackColor = true;
		buttonCTC.Click += new System.EventHandler(buttonCTC_Click);
		textBoxCTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxCTC.Location = new System.Drawing.Point(15, 230);
		textBoxCTC.Name = "textBoxCTC";
		textBoxCTC.ReadOnly = true;
		textBoxCTC.Size = new System.Drawing.Size(251, 20);
		textBoxCTC.TabIndex = 34;
		textBoxCTC.Text = "https://youtu.be/5H9Ita4GE9k?t=473";
		label7.AutoSize = true;
		label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(12, 213);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(231, 13);
		label7.TabIndex = 33;
		label7.Text = "Hướng dẫn đánh chiến trường CTC (thất thành)";
		buttonTamtru.Location = new System.Drawing.Point(273, 270);
		buttonTamtru.Name = "buttonTamtru";
		buttonTamtru.Size = new System.Drawing.Size(70, 21);
		buttonTamtru.TabIndex = 38;
		buttonTamtru.Text = "Xem phim";
		buttonTamtru.UseVisualStyleBackColor = true;
		buttonTamtru.Click += new System.EventHandler(buttonTamtru_Click);
		textBoxTamtru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxTamtru.Location = new System.Drawing.Point(15, 271);
		textBoxTamtru.Name = "textBoxTamtru";
		textBoxTamtru.ReadOnly = true;
		textBoxTamtru.Size = new System.Drawing.Size(251, 20);
		textBoxTamtru.TabIndex = 37;
		textBoxTamtru.Text = "https://youtu.be/NHJWNV6zKJI";
		label8.AutoSize = true;
		label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label8.Location = new System.Drawing.Point(12, 254);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(215, 13);
		label8.TabIndex = 36;
		label8.Text = "Hướng dẫn đánh chiến trường CTC (tam trụ)";
		buttonChayNhim.Location = new System.Drawing.Point(273, 314);
		buttonChayNhim.Name = "buttonChayNhim";
		buttonChayNhim.Size = new System.Drawing.Size(70, 21);
		buttonChayNhim.TabIndex = 41;
		buttonChayNhim.Text = "Xem phim";
		buttonChayNhim.UseVisualStyleBackColor = true;
		buttonChayNhim.Click += new System.EventHandler(buttonChayNhim_Click);
		textBoxChayNhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxChayNhim.Location = new System.Drawing.Point(15, 315);
		textBoxChayNhim.Name = "textBoxChayNhim";
		textBoxChayNhim.ReadOnly = true;
		textBoxChayNhim.Size = new System.Drawing.Size(251, 20);
		textBoxChayNhim.TabIndex = 40;
		textBoxChayNhim.Text = "https://youtu.be/GP7cr4qJIHA";
		label9.AutoSize = true;
		label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label9.Location = new System.Drawing.Point(12, 298);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(174, 13);
		label9.TabIndex = 39;
		label9.Text = "Phim chạy nhím chế tạo huyền tinh";
		buttonEvent.Location = new System.Drawing.Point(273, 356);
		buttonEvent.Name = "buttonEvent";
		buttonEvent.Size = new System.Drawing.Size(70, 21);
		buttonEvent.TabIndex = 44;
		buttonEvent.Text = "Xem phim";
		buttonEvent.UseVisualStyleBackColor = true;
		buttonEvent.Click += new System.EventHandler(buttonEvent_Click);
		textBoxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxEvent.Location = new System.Drawing.Point(15, 357);
		textBoxEvent.Name = "textBoxEvent";
		textBoxEvent.ReadOnly = true;
		textBoxEvent.Size = new System.Drawing.Size(251, 20);
		textBoxEvent.TabIndex = 43;
		textBoxEvent.Text = "https://youtu.be/Dup5PcJOV5Y";
		label10.AutoSize = true;
		label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label10.Location = new System.Drawing.Point(12, 340);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(333, 13);
		label10.TabIndex = 42;
		label10.Text = "Hướng dẫn click NPC, lọc kiếm đồ HK + xanh ngon. ăn các Event ...";
		buttonTinhLuyen.Location = new System.Drawing.Point(273, 399);
		buttonTinhLuyen.Name = "buttonTinhLuyen";
		buttonTinhLuyen.Size = new System.Drawing.Size(70, 21);
		buttonTinhLuyen.TabIndex = 47;
		buttonTinhLuyen.Text = "Xem phim";
		buttonTinhLuyen.UseVisualStyleBackColor = true;
		buttonTinhLuyen.Click += new System.EventHandler(buttonTinhLuyen_Click);
		textBoxTinhLuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxTinhLuyen.Location = new System.Drawing.Point(15, 400);
		textBoxTinhLuyen.Name = "textBoxTinhLuyen";
		textBoxTinhLuyen.ReadOnly = true;
		textBoxTinhLuyen.Size = new System.Drawing.Size(251, 20);
		textBoxTinhLuyen.TabIndex = 46;
		textBoxTinhLuyen.Text = "https://youtu.be/LLMBuNwXzLw";
		label11.AutoSize = true;
		label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label11.Location = new System.Drawing.Point(12, 383);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(215, 13);
		label11.TabIndex = 45;
		label11.Text = "Hướng dẫn Tinh luyện, nâng cấp huyền tinh";
		checkBoxKhongHienthi.AutoSize = true;
		checkBoxKhongHienthi.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxKhongHienthi.Location = new System.Drawing.Point(15, 521);
		checkBoxKhongHienthi.Name = "checkBoxKhongHienthi";
		checkBoxKhongHienthi.Size = new System.Drawing.Size(216, 17);
		checkBoxKhongHienthi.TabIndex = 48;
		checkBoxKhongHienthi.Text = "Không hiển thị bảng hướng dẫn này nữa";
		checkBoxKhongHienthi.UseVisualStyleBackColor = true;
		checkBoxKhongHienthi.CheckedChanged += new System.EventHandler(checkBoxKhongHienthi_CheckedChanged);
		buttonClose.Location = new System.Drawing.Point(273, 531);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(70, 26);
		buttonClose.TabIndex = 49;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		Thongtin.AutoSize = true;
		Thongtin.ForeColor = System.Drawing.Color.Red;
		Thongtin.Location = new System.Drawing.Point(16, 541);
		Thongtin.Name = "Thongtin";
		Thongtin.Size = new System.Drawing.Size(16, 13);
		Thongtin.TabIndex = 50;
		Thongtin.Text = "...";
		label5.AutoSize = true;
		label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label5.ForeColor = System.Drawing.Color.DarkRed;
		label5.Location = new System.Drawing.Point(2, 9);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(209, 13);
		label5.TabIndex = 51;
		label5.Text = "* Các cập nhật mới trong phiên bản này =>";
		buttonHelp.Location = new System.Drawing.Point(273, 5);
		buttonHelp.Name = "buttonHelp";
		buttonHelp.Size = new System.Drawing.Size(70, 21);
		buttonHelp.TabIndex = 52;
		buttonHelp.Text = "Xem ở đây";
		buttonHelp.UseVisualStyleBackColor = true;
		buttonHelp.Click += new System.EventHandler(buttonHelp_Click);
		linkLabelLinkWeb.AutoSize = true;
		linkLabelLinkWeb.Location = new System.Drawing.Point(97, 544);
		linkLabelLinkWeb.Name = "linkLabelLinkWeb";
		linkLabelLinkWeb.Size = new System.Drawing.Size(89, 13);
		linkLabelLinkWeb.TabIndex = 143;
		linkLabelLinkWeb.TabStop = true;
		linkLabelLinkWeb.Text = "http://kimyen.net";
		linkLabelLinkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelLinkWeb_LinkClicked);
		buttonChuyenThuoc.Location = new System.Drawing.Point(273, 487);
		buttonChuyenThuoc.Name = "buttonChuyenThuoc";
		buttonChuyenThuoc.Size = new System.Drawing.Size(70, 21);
		buttonChuyenThuoc.TabIndex = 146;
		buttonChuyenThuoc.Text = "Xem phim";
		buttonChuyenThuoc.UseVisualStyleBackColor = true;
		buttonChuyenThuoc.Click += new System.EventHandler(buttonChuyenThuoc_Click);
		textBoxChuyenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		textBoxChuyenThuoc.Location = new System.Drawing.Point(15, 487);
		textBoxChuyenThuoc.Name = "textBoxChuyenThuoc";
		textBoxChuyenThuoc.ReadOnly = true;
		textBoxChuyenThuoc.Size = new System.Drawing.Size(251, 20);
		textBoxChuyenThuoc.TabIndex = 145;
		textBoxChuyenThuoc.Text = "https://youtu.be/XRljjxiuyk8";
		label12.AutoSize = true;
		label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label12.Location = new System.Drawing.Point(12, 471);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(280, 13);
		label12.TabIndex = 144;
		label12.Text = "Hướng dẫn chuyển thuốc từ rương bang hội ra hành trang";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(347, 569);
		base.Controls.Add(buttonChuyenThuoc);
		base.Controls.Add(textBoxChuyenThuoc);
		base.Controls.Add(label12);
		base.Controls.Add(linkLabelLinkWeb);
		base.Controls.Add(buttonHelp);
		base.Controls.Add(label5);
		base.Controls.Add(Thongtin);
		base.Controls.Add(buttonClose);
		base.Controls.Add(checkBoxKhongHienthi);
		base.Controls.Add(buttonTinhLuyen);
		base.Controls.Add(textBoxTinhLuyen);
		base.Controls.Add(label11);
		base.Controls.Add(buttonEvent);
		base.Controls.Add(textBoxEvent);
		base.Controls.Add(label10);
		base.Controls.Add(buttonChayNhim);
		base.Controls.Add(textBoxChayNhim);
		base.Controls.Add(label9);
		base.Controls.Add(buttonTamtru);
		base.Controls.Add(textBoxTamtru);
		base.Controls.Add(label8);
		base.Controls.Add(buttonCTC);
		base.Controls.Add(textBoxCTC);
		base.Controls.Add(label7);
		base.Controls.Add(buttonNhieuMay);
		base.Controls.Add(textBoxNhieuMay);
		base.Controls.Add(label6);
		base.Controls.Add(buttonLogin);
		base.Controls.Add(textBoxLogin);
		base.Controls.Add(label4);
		base.Controls.Add(buttonRuong24o);
		base.Controls.Add(textBoxRuong24o);
		base.Controls.Add(label3);
		base.Controls.Add(buttonTrain);
		base.Controls.Add(textBoxTrain);
		base.Controls.Add(label2);
		base.Controls.Add(buttonTongKim);
		base.Controls.Add(textBoxTK);
		base.Controls.Add(label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormVideoHelp";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "PHIM HUONG DAN";
		base.Load += new System.EventHandler(FormVideoHelp_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
