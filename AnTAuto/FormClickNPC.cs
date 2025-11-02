using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormClickNPC : Form
{
	private IContainer icontainer_0 = null;

	private Label label20;

	private TextBox textBoxSoluongGiao2;

	private ComboBox comboBoxItemGiao2;

	private CheckBox checkBoxGiaoVatpham2;

	private TextBox textBoxSoluongGiao1;

	private ComboBox comboBoxItemGiao1;

	private CheckBox checkBoxGiaoVatpham1;

	private ComboBox comboBoxVatpham;

	private Label label1;

	private TextBox textBoxMenuVatpham;

	private CheckBox checkBoxCosudungVatpham;

	private CheckBox checkBoxDoithoaiTruoc;

	private ComboBox comboBoxItemGiao3;

	private TextBox textBoxSoluongGiao3;

	private CheckBox checkBoxGiaoVatpham3;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonApdungAll;

	private Button buttonDong;

	private Label labelTenac;

	private RichTextBox richTextBox1;

	private CheckBox checkBoxCoMuaVatpham;

	private ComboBox comboBoxMuaVP;

	private TextBox textBoxSoluongMua;

	private Label label3;

	private LinkLabel linkLabelMuaPhaohoa;

	private CheckBox checkBoxRuthettien;

	private CheckBox checkBoxChinhXacTen;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	private static bool bool_1 = false;

	public static int int_5 = Class55.smethod_3("NhapSoluongClickNPC", 0, "10");

	public static string[] string_0 = null;

	public static string[] string_1 = null;

	public static string[] string_2 = null;

	public static string[] string_3 = null;

	public static string[] string_4 = null;

	public static string string_5 = Class11.smethod_16(Class55.smethod_6("TenVatphamGiao1", 0));

	public static string string_6 = Class11.smethod_16(Class55.smethod_6("TenVatphamGiao2", 0));

	public static string string_7 = Class11.smethod_16(Class55.smethod_6("TenVatphamGiao3", 0));

	public static int int_6 = Class55.smethod_3("SoluongVatphamGiao1", 0, "1");

	public static int int_7 = Class55.smethod_3("SoluongVatphamGiao2", 0, "1");

	public static int int_8 = Class55.smethod_3("SoluongVatphamGiao3", 0, "1");

	public static int int_9 = Class55.smethod_3("SoluongVatphamMuaNpc", 0, "1");

	public static string string_8 = Class11.smethod_16(Class55.smethod_6("TenVatphamMua", 0));

	public static int int_10 = Class55.smethod_3("flagRutHetTienNPC", 0, "1");

	public static int int_11 = 0;

	public static int int_12 = 0;

	public static long long_0 = 0L;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormClickNPC));
		label20 = new System.Windows.Forms.Label();
		textBoxSoluongGiao2 = new System.Windows.Forms.TextBox();
		comboBoxItemGiao2 = new System.Windows.Forms.ComboBox();
		checkBoxGiaoVatpham2 = new System.Windows.Forms.CheckBox();
		textBoxSoluongGiao1 = new System.Windows.Forms.TextBox();
		comboBoxItemGiao1 = new System.Windows.Forms.ComboBox();
		checkBoxGiaoVatpham1 = new System.Windows.Forms.CheckBox();
		comboBoxVatpham = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		textBoxMenuVatpham = new System.Windows.Forms.TextBox();
		checkBoxCosudungVatpham = new System.Windows.Forms.CheckBox();
		checkBoxDoithoaiTruoc = new System.Windows.Forms.CheckBox();
		comboBoxItemGiao3 = new System.Windows.Forms.ComboBox();
		textBoxSoluongGiao3 = new System.Windows.Forms.TextBox();
		checkBoxGiaoVatpham3 = new System.Windows.Forms.CheckBox();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonApdungAll = new System.Windows.Forms.Button();
		buttonDong = new System.Windows.Forms.Button();
		labelTenac = new System.Windows.Forms.Label();
		richTextBox1 = new System.Windows.Forms.RichTextBox();
		checkBoxCoMuaVatpham = new System.Windows.Forms.CheckBox();
		comboBoxMuaVP = new System.Windows.Forms.ComboBox();
		textBoxSoluongMua = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		linkLabelMuaPhaohoa = new System.Windows.Forms.LinkLabel();
		checkBoxRuthettien = new System.Windows.Forms.CheckBox();
		checkBoxChinhXacTen = new System.Windows.Forms.CheckBox();
		SuspendLayout();
		label20.AutoSize = true;
		label20.ForeColor = System.Drawing.Color.DarkRed;
		label20.Location = new System.Drawing.Point(304, 55);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(49, 13);
		label20.TabIndex = 196;
		label20.Text = "Số lượng";
		textBoxSoluongGiao2.ForeColor = System.Drawing.Color.Black;
		textBoxSoluongGiao2.Location = new System.Drawing.Point(307, 102);
		textBoxSoluongGiao2.Name = "textBoxSoluongGiao2";
		textBoxSoluongGiao2.Size = new System.Drawing.Size(50, 20);
		textBoxSoluongGiao2.TabIndex = 194;
		textBoxSoluongGiao2.Text = "1";
		textBoxSoluongGiao2.TextChanged += new System.EventHandler(textBoxSoluongGiao2_TextChanged);
		comboBoxItemGiao2.DropDownWidth = 110;
		comboBoxItemGiao2.ForeColor = System.Drawing.Color.Black;
		comboBoxItemGiao2.FormattingEnabled = true;
		comboBoxItemGiao2.Location = new System.Drawing.Point(139, 102);
		comboBoxItemGiao2.Name = "comboBoxItemGiao2";
		comboBoxItemGiao2.Size = new System.Drawing.Size(162, 21);
		comboBoxItemGiao2.TabIndex = 193;
		comboBoxItemGiao2.SelectedIndexChanged += new System.EventHandler(comboBoxItemGiao2_SelectedIndexChanged);
		comboBoxItemGiao2.TextChanged += new System.EventHandler(comboBoxItemGiao2_TextChanged);
		comboBoxItemGiao2.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxItemGiao2_MouseDown);
		checkBoxGiaoVatpham2.AutoSize = true;
		checkBoxGiaoVatpham2.ForeColor = System.Drawing.Color.Black;
		checkBoxGiaoVatpham2.Location = new System.Drawing.Point(11, 104);
		checkBoxGiaoVatpham2.Name = "checkBoxGiaoVatpham2";
		checkBoxGiaoVatpham2.Size = new System.Drawing.Size(116, 17);
		checkBoxGiaoVatpham2.TabIndex = 192;
		checkBoxGiaoVatpham2.Text = "Có nộp vật phẩm 2";
		checkBoxGiaoVatpham2.UseVisualStyleBackColor = true;
		checkBoxGiaoVatpham2.CheckedChanged += new System.EventHandler(checkBoxGiaoVatpham2_CheckedChanged);
		textBoxSoluongGiao1.ForeColor = System.Drawing.Color.Black;
		textBoxSoluongGiao1.Location = new System.Drawing.Point(307, 75);
		textBoxSoluongGiao1.Name = "textBoxSoluongGiao1";
		textBoxSoluongGiao1.Size = new System.Drawing.Size(50, 20);
		textBoxSoluongGiao1.TabIndex = 191;
		textBoxSoluongGiao1.Text = "1";
		textBoxSoluongGiao1.TextChanged += new System.EventHandler(textBoxSoluongGiao1_TextChanged);
		comboBoxItemGiao1.DropDownWidth = 110;
		comboBoxItemGiao1.ForeColor = System.Drawing.Color.Black;
		comboBoxItemGiao1.FormattingEnabled = true;
		comboBoxItemGiao1.Location = new System.Drawing.Point(139, 75);
		comboBoxItemGiao1.Name = "comboBoxItemGiao1";
		comboBoxItemGiao1.Size = new System.Drawing.Size(162, 21);
		comboBoxItemGiao1.TabIndex = 190;
		comboBoxItemGiao1.SelectedIndexChanged += new System.EventHandler(comboBoxItemGiao1_SelectedIndexChanged);
		comboBoxItemGiao1.TextChanged += new System.EventHandler(comboBoxItemGiao1_TextChanged);
		comboBoxItemGiao1.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxItemGiao1_MouseDown);
		checkBoxGiaoVatpham1.AutoSize = true;
		checkBoxGiaoVatpham1.ForeColor = System.Drawing.Color.Black;
		checkBoxGiaoVatpham1.Location = new System.Drawing.Point(11, 78);
		checkBoxGiaoVatpham1.Name = "checkBoxGiaoVatpham1";
		checkBoxGiaoVatpham1.Size = new System.Drawing.Size(116, 17);
		checkBoxGiaoVatpham1.TabIndex = 189;
		checkBoxGiaoVatpham1.Text = "Có nộp vật phẩm 1";
		checkBoxGiaoVatpham1.UseVisualStyleBackColor = true;
		checkBoxGiaoVatpham1.CheckedChanged += new System.EventHandler(checkBoxGiaoVatpham1_CheckedChanged);
		comboBoxVatpham.DropDownWidth = 110;
		comboBoxVatpham.ForeColor = System.Drawing.Color.Black;
		comboBoxVatpham.FormattingEnabled = true;
		comboBoxVatpham.Location = new System.Drawing.Point(139, 24);
		comboBoxVatpham.Name = "comboBoxVatpham";
		comboBoxVatpham.Size = new System.Drawing.Size(162, 21);
		comboBoxVatpham.TabIndex = 199;
		comboBoxVatpham.SelectedIndexChanged += new System.EventHandler(comboBoxVatpham_SelectedIndexChanged);
		comboBoxVatpham.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxVatpham_MouseDown);
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(303, 5);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(59, 13);
		label1.TabIndex = 200;
		label1.Text = "Click menu";
		textBoxMenuVatpham.Location = new System.Drawing.Point(307, 25);
		textBoxMenuVatpham.Name = "textBoxMenuVatpham";
		textBoxMenuVatpham.Size = new System.Drawing.Size(50, 20);
		textBoxMenuVatpham.TabIndex = 201;
		textBoxMenuVatpham.TextChanged += new System.EventHandler(textBoxMenuVatpham_TextChanged);
		checkBoxCosudungVatpham.AutoSize = true;
		checkBoxCosudungVatpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		checkBoxCosudungVatpham.Location = new System.Drawing.Point(11, 26);
		checkBoxCosudungVatpham.Name = "checkBoxCosudungVatpham";
		checkBoxCosudungVatpham.Size = new System.Drawing.Size(127, 17);
		checkBoxCosudungVatpham.TabIndex = 202;
		checkBoxCosudungVatpham.Text = "Có sử dụng vật phẩm";
		checkBoxCosudungVatpham.UseVisualStyleBackColor = true;
		checkBoxCosudungVatpham.CheckedChanged += new System.EventHandler(checkBoxCosudungVatpham_CheckedChanged);
		checkBoxDoithoaiTruoc.AutoSize = true;
		checkBoxDoithoaiTruoc.Location = new System.Drawing.Point(30, 49);
		checkBoxDoithoaiTruoc.Name = "checkBoxDoithoaiTruoc";
		checkBoxDoithoaiTruoc.Size = new System.Drawing.Size(241, 17);
		checkBoxDoithoaiTruoc.TabIndex = 203;
		checkBoxDoithoaiTruoc.Text = "Đối thoại với Npc xong mới sử dụng vật phẩm";
		checkBoxDoithoaiTruoc.UseVisualStyleBackColor = true;
		checkBoxDoithoaiTruoc.CheckedChanged += new System.EventHandler(checkBoxDoithoaiTruoc_CheckedChanged);
		comboBoxItemGiao3.DropDownWidth = 110;
		comboBoxItemGiao3.ForeColor = System.Drawing.Color.Black;
		comboBoxItemGiao3.FormattingEnabled = true;
		comboBoxItemGiao3.Location = new System.Drawing.Point(139, 127);
		comboBoxItemGiao3.Name = "comboBoxItemGiao3";
		comboBoxItemGiao3.Size = new System.Drawing.Size(162, 21);
		comboBoxItemGiao3.TabIndex = 205;
		comboBoxItemGiao3.SelectedIndexChanged += new System.EventHandler(comboBoxItemGiao3_SelectedIndexChanged);
		comboBoxItemGiao3.TextChanged += new System.EventHandler(comboBoxItemGiao3_TextChanged);
		comboBoxItemGiao3.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxItemGiao3_MouseDown);
		textBoxSoluongGiao3.ForeColor = System.Drawing.Color.Black;
		textBoxSoluongGiao3.Location = new System.Drawing.Point(307, 127);
		textBoxSoluongGiao3.Name = "textBoxSoluongGiao3";
		textBoxSoluongGiao3.Size = new System.Drawing.Size(50, 20);
		textBoxSoluongGiao3.TabIndex = 206;
		textBoxSoluongGiao3.Text = "1";
		textBoxSoluongGiao3.TextChanged += new System.EventHandler(textBoxSoluongGiao3_TextChanged);
		checkBoxGiaoVatpham3.AutoSize = true;
		checkBoxGiaoVatpham3.ForeColor = System.Drawing.Color.Black;
		checkBoxGiaoVatpham3.Location = new System.Drawing.Point(11, 129);
		checkBoxGiaoVatpham3.Name = "checkBoxGiaoVatpham3";
		checkBoxGiaoVatpham3.Size = new System.Drawing.Size(116, 17);
		checkBoxGiaoVatpham3.TabIndex = 204;
		checkBoxGiaoVatpham3.Text = "Có nộp vật phẩm 3";
		checkBoxGiaoVatpham3.UseVisualStyleBackColor = true;
		checkBoxGiaoVatpham3.CheckedChanged += new System.EventHandler(checkBoxGiaoVatpham3_CheckedChanged);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonApdungAll.ForeColor = System.Drawing.Color.DarkRed;
		buttonApdungAll.Location = new System.Drawing.Point(39, 383);
		buttonApdungAll.Name = "buttonApdungAll";
		buttonApdungAll.Size = new System.Drawing.Size(141, 26);
		buttonApdungAll.TabIndex = 207;
		buttonApdungAll.Text = "Áp dụng cho tất cả ac";
		buttonApdungAll.UseVisualStyleBackColor = true;
		buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		buttonDong.Location = new System.Drawing.Point(186, 383);
		buttonDong.Name = "buttonDong";
		buttonDong.Size = new System.Drawing.Size(138, 26);
		buttonDong.TabIndex = 208;
		buttonDong.Text = "Đóng";
		buttonDong.UseVisualStyleBackColor = true;
		buttonDong.Click += new System.EventHandler(buttonDong_Click);
		labelTenac.AutoSize = true;
		labelTenac.BackColor = System.Drawing.SystemColors.Control;
		labelTenac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		labelTenac.ForeColor = System.Drawing.Color.Red;
		labelTenac.Location = new System.Drawing.Point(7, 4);
		labelTenac.Name = "labelTenac";
		labelTenac.Size = new System.Drawing.Size(51, 13);
		labelTenac.TabIndex = 210;
		labelTenac.Text = "Tên ac:";
		richTextBox1.BackColor = System.Drawing.Color.Gainsboro;
		richTextBox1.Location = new System.Drawing.Point(11, 253);
		richTextBox1.Name = "richTextBox1";
		richTextBox1.ReadOnly = true;
		richTextBox1.Size = new System.Drawing.Size(346, 124);
		richTextBox1.TabIndex = 211;
		//richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
		checkBoxCoMuaVatpham.AutoSize = true;
		checkBoxCoMuaVatpham.ForeColor = System.Drawing.Color.Black;
		checkBoxCoMuaVatpham.Location = new System.Drawing.Point(10, 187);
		checkBoxCoMuaVatpham.Name = "checkBoxCoMuaVatpham";
		checkBoxCoMuaVatpham.Size = new System.Drawing.Size(110, 17);
		checkBoxCoMuaVatpham.TabIndex = 212;
		checkBoxCoMuaVatpham.Text = "Có mua Vật phẩm";
		checkBoxCoMuaVatpham.UseVisualStyleBackColor = true;
		checkBoxCoMuaVatpham.CheckedChanged += new System.EventHandler(checkBoxCoMuaVatpham_CheckedChanged);
		comboBoxMuaVP.DropDownWidth = 110;
		comboBoxMuaVP.ForeColor = System.Drawing.Color.Black;
		comboBoxMuaVP.FormattingEnabled = true;
		comboBoxMuaVP.Location = new System.Drawing.Point(139, 184);
		comboBoxMuaVP.Name = "comboBoxMuaVP";
		comboBoxMuaVP.Size = new System.Drawing.Size(162, 21);
		comboBoxMuaVP.TabIndex = 213;
		comboBoxMuaVP.SelectedIndexChanged += new System.EventHandler(comboBoxMuaVP_SelectedIndexChanged);
		comboBoxMuaVP.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxMuaVP_MouseDown);
		textBoxSoluongMua.ForeColor = System.Drawing.Color.Black;
		textBoxSoluongMua.Location = new System.Drawing.Point(307, 184);
		textBoxSoluongMua.Name = "textBoxSoluongMua";
		textBoxSoluongMua.Size = new System.Drawing.Size(50, 20);
		textBoxSoluongMua.TabIndex = 214;
		textBoxSoluongMua.Text = "1";
		textBoxSoluongMua.TextChanged += new System.EventHandler(textBoxSoluongMua_TextChanged);
		label3.AutoSize = true;
		label3.ForeColor = System.Drawing.Color.Green;
		label3.Location = new System.Drawing.Point(27, 232);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(200, 13);
		label3.TabIndex = 215;
		label3.Text = "(ví dụ như mua lệnh bài phi tốc tống kim)";
		linkLabelMuaPhaohoa.AutoSize = true;
		linkLabelMuaPhaohoa.Location = new System.Drawing.Point(233, 232);
		linkLabelMuaPhaohoa.Name = "linkLabelMuaPhaohoa";
		linkLabelMuaPhaohoa.Size = new System.Drawing.Size(68, 13);
		linkLabelMuaPhaohoa.TabIndex = 217;
		linkLabelMuaPhaohoa.TabStop = true;
		linkLabelMuaPhaohoa.Text = "=> Xem phim";
		linkLabelMuaPhaohoa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelMuaPhaohoa_LinkClicked);
		checkBoxRuthettien.AutoSize = true;
		checkBoxRuthettien.Location = new System.Drawing.Point(30, 208);
		checkBoxRuthettien.Name = "checkBoxRuthettien";
		checkBoxRuthettien.Size = new System.Drawing.Size(121, 17);
		checkBoxRuthettien.TabIndex = 218;
		checkBoxRuthettien.Text = "Rút hết tiền khi mua";
		checkBoxRuthettien.UseVisualStyleBackColor = true;
		checkBoxRuthettien.CheckedChanged += new System.EventHandler(checkBoxRuthettien_CheckedChanged);
		checkBoxChinhXacTen.AutoSize = true;
		checkBoxChinhXacTen.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxChinhXacTen.Location = new System.Drawing.Point(30, 155);
		checkBoxChinhXacTen.Name = "checkBoxChinhXacTen";
		checkBoxChinhXacTen.Size = new System.Drawing.Size(195, 17);
		checkBoxChinhXacTen.TabIndex = 219;
		checkBoxChinhXacTen.Text = "Nộp chính xác tên vật phẩm 1, 2, 3";
		checkBoxChinhXacTen.UseVisualStyleBackColor = true;
		checkBoxChinhXacTen.CheckedChanged += new System.EventHandler(checkBoxChinhXacTen_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(366, 414);
		base.Controls.Add(checkBoxChinhXacTen);
		base.Controls.Add(checkBoxRuthettien);
		base.Controls.Add(linkLabelMuaPhaohoa);
		base.Controls.Add(label3);
		base.Controls.Add(comboBoxMuaVP);
		base.Controls.Add(textBoxSoluongMua);
		base.Controls.Add(checkBoxCoMuaVatpham);
		base.Controls.Add(richTextBox1);
		base.Controls.Add(labelTenac);
		base.Controls.Add(buttonDong);
		base.Controls.Add(buttonApdungAll);
		base.Controls.Add(comboBoxItemGiao3);
		base.Controls.Add(textBoxSoluongGiao3);
		base.Controls.Add(checkBoxGiaoVatpham3);
		base.Controls.Add(comboBoxVatpham);
		base.Controls.Add(comboBoxItemGiao2);
		base.Controls.Add(comboBoxItemGiao1);
		base.Controls.Add(checkBoxDoithoaiTruoc);
		base.Controls.Add(checkBoxCosudungVatpham);
		base.Controls.Add(textBoxMenuVatpham);
		base.Controls.Add(label1);
		base.Controls.Add(label20);
		base.Controls.Add(textBoxSoluongGiao2);
		base.Controls.Add(checkBoxGiaoVatpham2);
		base.Controls.Add(textBoxSoluongGiao1);
		base.Controls.Add(checkBoxGiaoVatpham1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormClickNPC";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "CLICK NPC";
		base.Load += new System.EventHandler(FormClickNPC_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormClickNPC()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (0 <= num)
		{
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
		int_1 = 0;
		int_2 = 0;
		bool_0 = false;
	}

	private void FormClickNPC_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		if (int_1 >= 0 && int_2 >= 0)
		{
			int num = int_1 - base.Width;
			int num2 = int_2 + int_4 - base.Height;
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
		base.TopMost = true;
		int num3 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num3 < 0)
		{
			checkBoxCosudungVatpham.Enabled = false;
			checkBoxGiaoVatpham1.Enabled = false;
			checkBoxGiaoVatpham2.Enabled = false;
			checkBoxGiaoVatpham3.Enabled = false;
			checkBoxDoithoaiTruoc.Enabled = false;
			comboBoxVatpham.Enabled = false;
			labelTenac.Text = "[Bạn chưa chọn ac nào cả ]";
		}
		else
		{
			GStruct42 gStruct = FormMain.gstruct42_0[num3];
			labelTenac.Text = "[ " + Class10.smethod_1(gStruct.string_20, 1) + "]";
			checkBoxCosudungVatpham.Checked = (gStruct.int_12 > 0);
			if (gStruct.string_1 != null && gStruct.string_1 != string.Empty)
			{
				string text = Class10.smethod_1(gStruct.string_1, 1);
				comboBoxVatpham.Items.Add(text);
				comboBoxVatpham.Text = text;
			}
			if (gStruct.int_13 != null)
			{
				string text = null;
				for (int i = 0; i < gStruct.int_13.Length; i++)
				{
					if (text != null)
					{
						text += ",";
					}
					text += gStruct.int_13[i];
				}
				textBoxMenuVatpham.Text = text;
			}
			checkBoxDoithoaiTruoc.Checked = (gStruct.int_14 > 0);
			checkBoxGiaoVatpham1.Checked = (gStruct.int_15 > 0);
			checkBoxGiaoVatpham2.Checked = (gStruct.int_16 > 0);
			checkBoxGiaoVatpham3.Checked = (gStruct.int_17 > 0);
			checkBoxCoMuaVatpham.Checked = (gStruct.int_18 > 0);
		}
		comboBoxItemGiao1.Items.Clear();
		comboBoxItemGiao2.Items.Clear();
		comboBoxItemGiao3.Items.Clear();
		comboBoxMuaVP.Items.Clear();
		if (string_5 != null && string_5 != string.Empty)
		{
			string text2 = Class10.smethod_1(string_5, 1);
			comboBoxItemGiao1.Items.Add(text2);
			comboBoxItemGiao1.Text = text2;
		}
		textBoxSoluongGiao1.Text = int_6.ToString();
		if (string_6 != null && string_6 != string.Empty)
		{
			string text2 = Class10.smethod_1(string_6, 1);
			comboBoxItemGiao2.Items.Add(text2);
			comboBoxItemGiao2.Text = text2;
		}
		textBoxSoluongGiao2.Text = int_7.ToString();
		if (string_7 != null && string_7 != string.Empty)
		{
			string text2 = Class10.smethod_1(string_7, 1);
			comboBoxItemGiao3.Items.Add(text2);
			comboBoxItemGiao3.Text = text2;
		}
		textBoxSoluongGiao3.Text = int_8.ToString();
		if (string_8 != null && string_8 != string.Empty)
		{
			string text2 = Class10.smethod_1(string_8, 1);
			comboBoxMuaVP.Items.Add(text2);
			comboBoxMuaVP.Text = text2;
		}
		textBoxSoluongMua.Text = int_9.ToString();
		checkBoxRuthettien.Checked = (int_10 > 0);
		checkBoxChinhXacTen.Checked = (FormMain.int_5 > 0);
		bool_1 = true;
		timer_0.Interval = 300;
		timer_0.Enabled = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
		else if (!buttonApdungAll.Enabled)
		{
			buttonApdungAll.Enabled = true;
		}
	}

	private static int[] smethod_0(string string_9)
	{
		if (!(string_9 == string.Empty) && string_9 != null)
		{
			string[] array = string_9.Split(',', '.', ':', '/', '|', '=', '-', '+', ';');
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = Class11.smethod_12(array[i]);
			}
			return array2;
		}
		return null;
	}

	private void checkBoxGiaoVatpham1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_15 = Convert.ToByte(checkBoxGiaoVatpham1.Checked);
			}
		}
	}

	private void checkBoxGiaoVatpham2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_16 = Convert.ToByte(checkBoxGiaoVatpham2.Checked);
			}
		}
	}

	private void textBoxSoluongGiao1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int_6 = Class11.smethod_12(textBoxSoluongGiao1.Text);
			Class55.smethod_10(Class47.string_0, "SoluongVatphamGiao1", int_6, "", 0);
		}
	}

	private void textBoxSoluongGiao2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int_7 = Class11.smethod_12(textBoxSoluongGiao2.Text);
			Class55.smethod_10(Class47.string_0, "SoluongVatphamGiao2", int_7, "", 0);
		}
	}

	private void checkBoxGiaoVatpham3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_17 = Convert.ToByte(checkBoxGiaoVatpham3.Checked);
			}
		}
	}

	private void textBoxSoluongGiao3_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int_8 = Class11.smethod_12(textBoxSoluongGiao2.Text);
			Class55.smethod_10(Class47.string_0, "SoluongVatphamGiao3", int_8, "", 0);
		}
	}

	private void comboBoxItemGiao1_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		bool_1 = false;
		string_1 = Class69.smethod_29(FormMain.gstruct42_0[num]);
		comboBoxItemGiao1.Items.Clear();
		if (string_1 != null)
		{
			for (int i = 0; i < string_1.Length; i++)
			{
				comboBoxItemGiao1.Items.Add(Class10.smethod_1(string_1[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_1 = true;
	}

	private void comboBoxItemGiao1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_1 == null)
		{
			return;
		}
		string text = comboBoxItemGiao1.Text;
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				if (text == Class10.smethod_1(string_1[num], 1))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		string_5 = string_1[num];
		Class55.smethod_10(Class47.string_0, "TenVatphamGiao1", Class11.smethod_17(string_5), "", 0);
	}

	private void comboBoxItemGiao1_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_1 == null)
		{
			return;
		}
		bool flag = true;
		string text = comboBoxItemGiao1.Text;
		if (!(text == "*") && !(text == "(*)"))
		{
			int num = Class11.smethod_2(text, "*");
			if (num > 0)
			{
				text = text.Substring(0, num);
				flag = false;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < string_1.Length)
				{
					string text2 = Class10.smethod_1(string_1[num2], 1);
					if (text == text2 || (!flag && Class11.smethod_2(text2, text) == 0))
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			string_5 = string_1[num2];
			if (!flag)
			{
				string_5 = string_5.Substring(0, num) + "*";
			}
			Class55.smethod_10(Class47.string_0, "TenVatphamGiao1", Class11.smethod_17(string_5), "", 0);
		}
		else
		{
			string_5 = "*";
			Class55.smethod_10(Class47.string_0, "TenVatphamGiao1", Class11.smethod_17(string_5), "", 0);
		}
	}

	private void comboBoxItemGiao2_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		bool_1 = false;
		string_2 = Class69.smethod_29(FormMain.gstruct42_0[num]);
		comboBoxItemGiao2.Items.Clear();
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.Length; i++)
			{
				comboBoxItemGiao2.Items.Add(Class10.smethod_1(string_2[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_1 = true;
	}

	private void comboBoxItemGiao2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_2 == null)
		{
			return;
		}
		string text = comboBoxItemGiao2.Text;
		int num = 0;
		while (true)
		{
			if (num < string_2.Length)
			{
				if (text == Class10.smethod_1(string_2[num], 1))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		string_6 = string_2[num];
		Class55.smethod_10(Class47.string_0, "TenVatphamGiao2", Class11.smethod_17(string_6), "", 0);
	}

	private void comboBoxItemGiao2_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_2 == null)
		{
			return;
		}
		bool flag = true;
		string text = comboBoxItemGiao2.Text;
		if (!(text == "*") && !(text == "(*)"))
		{
			int num = Class11.smethod_2(text, "*");
			if (num > 0)
			{
				text = text.Substring(0, num);
				flag = false;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < string_2.Length)
				{
					string text2 = Class10.smethod_1(string_2[num2], 1);
					if (text == text2 || (!flag && Class11.smethod_2(text2, text) == 0))
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			string_6 = string_2[num2];
			if (!flag)
			{
				string_6 = string_6.Substring(0, num) + "*";
			}
			Class55.smethod_10(Class47.string_0, "TenVatphamGiao2", Class11.smethod_17(string_6), "", 0);
		}
		else
		{
			string_6 = "*";
			Class55.smethod_10(Class47.string_0, "TenVatphamGiao2", Class11.smethod_17(string_6), "", 0);
		}
	}

	private void comboBoxItemGiao3_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		bool_1 = false;
		string_3 = Class69.smethod_29(FormMain.gstruct42_0[num]);
		comboBoxItemGiao3.Items.Clear();
		if (string_3 != null)
		{
			for (int i = 0; i < string_3.Length; i++)
			{
				comboBoxItemGiao3.Items.Add(Class10.smethod_1(string_3[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_1 = true;
	}

	private void comboBoxItemGiao3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_3 == null)
		{
			return;
		}
		string text = comboBoxItemGiao3.Text;
		int num = 0;
		while (true)
		{
			if (num < string_3.Length)
			{
				if (text == Class10.smethod_1(string_3[num], 1))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		string_7 = string_3[num];
		Class55.smethod_10(Class47.string_0, "TenVatphamGiao3", Class11.smethod_17(string_7), "", 0);
	}

	private void comboBoxItemGiao3_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_3 == null)
		{
			return;
		}
		bool flag = true;
		string text = comboBoxItemGiao3.Text;
		if (!(text == "*") && !(text == "(*)"))
		{
			int num = Class11.smethod_2(text, "*");
			if (num > 0)
			{
				text = text.Substring(0, num);
				flag = false;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < string_3.Length)
				{
					string text2 = Class10.smethod_1(string_3[num2], 1);
					if (text == text2 || (!flag && Class11.smethod_2(text2, text) == 0))
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			string_7 = string_3[num2];
			if (!flag)
			{
				string_7 = string_7.Substring(0, num) + "*";
			}
			Class55.smethod_10(Class47.string_0, "TenVatphamGiao3", Class11.smethod_17(string_7), "", 0);
		}
		else
		{
			string_7 = "*";
			Class55.smethod_10(Class47.string_0, "TenVatphamGiao3", Class11.smethod_17(string_7), "", 0);
		}
	}

	private void checkBoxCosudungVatpham_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_12 = Convert.ToByte(checkBoxCosudungVatpham.Checked);
			}
		}
	}

	private void textBoxMenuVatpham_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_13 = smethod_0(textBoxMenuVatpham.Text);
			}
		}
	}

	private void comboBoxVatpham_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		bool_1 = false;
		string_0 = Class69.smethod_29(FormMain.gstruct42_0[num]);
		comboBoxVatpham.Items.Clear();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxVatpham.Items.Add(Class10.smethod_1(string_0[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_1 = true;
	}

	private void comboBoxVatpham_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_0 == null)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxVatpham.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (text == Class10.smethod_1(string_0[num2], 1))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		FormMain.gstruct42_0[num].string_1 = string_0[num2];
	}

	private void checkBoxDoithoaiTruoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_14 = Convert.ToByte(checkBoxDoithoaiTruoc.Checked);
			}
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0 || FormMain.gstruct42_0 == null || num < 0)
		{
			return;
		}
		buttonApdungAll.Enabled = false;
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			if (i == num)
			{
				continue;
			}
			FormMain.gstruct42_0[i].int_12 = FormMain.gstruct42_0[num].int_12;
			FormMain.gstruct42_0[i].string_1 = FormMain.gstruct42_0[num].string_1;
			FormMain.gstruct42_0[i].int_13 = null;
			if (FormMain.gstruct42_0[num].int_13 != null)
			{
				FormMain.gstruct42_0[i].int_13 = new int[FormMain.gstruct42_0[num].int_13.Length];
				for (int j = 0; j < FormMain.gstruct42_0[num].int_13.Length; j++)
				{
					FormMain.gstruct42_0[i].int_13[j] = FormMain.gstruct42_0[num].int_13[j];
				}
			}
			FormMain.gstruct42_0[i].int_14 = FormMain.gstruct42_0[num].int_14;
			FormMain.gstruct42_0[i].int_15 = FormMain.gstruct42_0[num].int_15;
			FormMain.gstruct42_0[i].int_16 = FormMain.gstruct42_0[num].int_16;
			FormMain.gstruct42_0[i].int_17 = FormMain.gstruct42_0[num].int_17;
			FormMain.gstruct42_0[i].int_18 = FormMain.gstruct42_0[num].int_18;
		}
	}

	private void buttonDong_Click(object sender, EventArgs e)
	{
		Close();
	}

	public static void smethod_1()
	{
		if (FormMain.gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			if (!FormMain.gstruct42_0[i].bool_36)
			{
				continue;
			}
			for (int j = 0; j < 100; j++)
			{
				if (int_11 <= 0)
				{
					break;
				}
				Thread.Sleep(1);
			}
			int_11 = FormMain.gstruct42_0[i].int_129;
			new Thread(smethod_2).Start();
		}
	}

	public static void smethod_2()
	{
		int num = int_11;
		int_11 = 0;
		int num2 = Class71.smethod_3(FormMain.gstruct42_0, num);
		if (num2 < 0)
		{
			return;
		}
		GStruct42 gstruct42_ = FormMain.gstruct42_0[num2];
		int int_ = 0;
		byte[] array = new byte[4];
		uint num3 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
		uint num4 = Class20.smethod_30(num3 + Class47.gstruct43_13.uint_0, gstruct42_.int_130);
		uint num5 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
		uint num6 = num5 + num4 * Class47.gstruct43_15.uint_0;
		uint[] uint_ = new uint[2]
		{
			Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
			Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
		};
		uint uint_2 = gstruct42_.uint_6 + Class47.gstruct43_9.uint_0 + Class47.gstruct43_10.uint_0 + 4;
		Class20.ReadProcessMemory(gstruct42_.int_130, uint_2, array, 4, ref int_);
		int num7 = BitConverter.ToInt32(array, 0);
		if (num7 <= 1)
		{
			return;
		}
		int num8 = 0;
		uint num9 = 0u;
		long num10 = 0L;
		uint[] array2 = new uint[2];
		for (uint num11 = 1u; num11 < 256; num11++)
		{
			if (num7 <= num8)
			{
				break;
			}
			uint num12 = num5 + num11 * Class47.gstruct43_15.uint_0;
			Class20.ReadProcessMemory(gstruct42_.int_130, num12 + Class47.gstruct43_16.uint_0, array, 4, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num8++;
			Class20.ReadProcessMemory(gstruct42_.int_130, num12 + Class47.gstruct43_52.uint_0, array, 4, ref int_);
			uint num13 = BitConverter.ToUInt32(array, 0);
			if (num13 == 3)
			{
				uint[] array3 = new uint[2];
				Class20.ReadProcessMemory(gstruct42_.int_130, num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, array, 4, ref int_);
				array3[0] = BitConverter.ToUInt32(array, 0);
				Class20.ReadProcessMemory(gstruct42_.int_130, num12 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, array, 4, ref int_);
				array3[1] = BitConverter.ToUInt32(array, 0);
				long num14 = Class53.smethod_18(uint_, array3);
				if (num9 == 0 || num14 < num10)
				{
					num10 = num14;
					array2[0] = array3[0];
					array2[1] = array3[1];
					num9 = num11;
				}
			}
		}
		if (num9 == 0)
		{
			return;
		}
		for (int i = 0; i < 10; i++)
		{
			uint_ = new uint[2]
			{
				Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
				Class20.smethod_30(num6 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
			};
			long num15 = Class53.smethod_18(uint_, array2);
			if (num15 <= 11500L)
			{
				break;
			}
			Class60.smethod_61(gstruct42_, array2);
			Thread.Sleep(300);
		}
		array = BitConverter.GetBytes(num9);
		Class20.WriteProcessMemory(gstruct42_.int_130, num6 + Class47.gstruct43_72.uint_0, array, 4, ref int_);
	}

	public static void smethod_3()
	{
		int int_ = int_12;
		int_12 = 0;
		while (true)
		{
			try
			{
				smethod_4(int_);
				return;
			}
			catch
			{
			}
		}
	}

	public static void smethod_4(int int_13)
	{
		GStruct42 gstruct42_ = default(GStruct42);
		bool flag = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		uint[] uint_ = null;
		uint[] array = null;
		int num5 = -1;
		int num6 = -1;
		byte[] byte_ = new byte[4];
		uint num7 = 0u;
		int[] array2 = null;
		bool flag2 = true;
		int num8 = 0;
		int num9 = 0;
		int int_14 = 0;
		uint num10 = 0u;
		byte[] array3 = new byte[4];
		do
		{
			num2--;
			Thread.Sleep(10);
			if (num2 <= 0)
			{
				num = Class71.smethod_3(FormMain.gstruct42_0, int_13);
				num2 = 15;
			}
			if (Class11.bool_0 || num < 0 || !FormMain.gstruct42_0[num].bool_36 || !FormMain.gstruct42_0[num].bool_6)
			{
				break;
			}
			if (FormMain.gstruct42_0[num].int_9 == null)
			{
				FormMain.gstruct42_0[num].int_9 = new int[3]
				{
					2,
					1,
					1
				};
			}
			if (FormMain.gstruct42_0[num].int_7 == null)
			{
				FormMain.gstruct42_0[num].int_7 = new int[2]
				{
					0,
					3
				};
			}
			if (FormMain.gstruct42_0[num].int_10 < 0 || FormMain.gstruct42_0[num].int_10 > 15000)
			{
				FormMain.gstruct42_0[num].int_10 = 300;
			}
			gstruct42_ = FormMain.gstruct42_0[num];
			if (!flag)
			{
				flag = true;
				Class60.smethod_50(gstruct42_, "ClickNPC bat dau...");
			}
			int num11 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gstruct42_.int_130);
			if (num5 < 0)
			{
				num5 = num11;
			}
			else if (num5 != num11)
			{
				break;
			}
			uint num12 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130);
			uint num13 = Class20.smethod_30(num12 + Class47.gstruct43_13.uint_0, gstruct42_.int_130);
			uint num14 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_.int_130);
			num7 = num14 + num13 * Class47.gstruct43_15.uint_0;
			int num15 = (int)Class20.smethod_30(num7 + Class47.gstruct43_50.uint_0, gstruct42_.int_130);
			int num16 = Class73.smethod_40(gstruct42_);
            if (num15 != 0 && num16 > 1)
            {
                if (FormMain.int_4 > 0)
                {
                    if (num4 > 0 && num8 <= 0)
                    {
                        string text = Class86.smethod_15(gstruct42_, num4, ref uint_, gstruct42_.string_0.Length + 1);
                        if (text == null || text != gstruct42_.string_0)
                        {
                            num4 = 0;
                            uint_ = null;
                            int int_15 = 0;
                            Class20.WriteProcessMemory(gstruct42_.int_130, num7 + Class47.gstruct43_72.uint_0, byte_, 4, ref int_15);
                        }
                        num8 = 100;
                    }
                    if (num4 <= 0)
                    {
                        num4 = Class86.smethod_14(gstruct42_, gstruct42_.string_0, ref uint_);
                        if (num4 <= 0)
                        {
                            num2 = 0;
                            goto IL_036f;
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        array = new uint[2]
                        {
                        Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gstruct42_.int_130),
                        Class20.smethod_30(num7 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gstruct42_.int_130)
                        };
                        long num17 = Class53.smethod_18(array, uint_);
                        if (num17 <= 11500L)
                        {
                            break;
                        }
                        Class60.smethod_61(gstruct42_, uint_);
                        Thread.Sleep(300);
                    }
                }
                goto IL_036f;
                IL_06b0:
                bool flag3;
                bool flag4;
                if (!flag3 && FormMain.int_4 > 0)
                {
                    int int_15 = 0;
                    byte[] bytes = BitConverter.GetBytes(num4);
                    Class20.WriteProcessMemory(gstruct42_.int_130, num7 + Class47.gstruct43_72.uint_0, bytes, 4, ref int_15);
                    Thread.Sleep(5 + gstruct42_.int_10);
                    if (gstruct42_.int_8 > 0)
                    {
                        num9 = 0;
                        while (num9 < 800 && !Class76.smethod_0(gstruct42_))
                        {
                            num9++;
                            Thread.Sleep(1);
                            if (Class76.Class79.smethod_4(gstruct42_))
                            {
                                Class76.Class79.smethod_5(gstruct42_);
                            }
                        }
                        for (int j = 0; j < gstruct42_.int_9.Length; j++)
                        {
                            Class76.smethod_6(gstruct42_, gstruct42_.int_9[j] - 1);
                            Thread.Sleep(5 + gstruct42_.int_10);
                        }
                    }
                    if (Class76.Class79.smethod_4(gstruct42_))
                    {
                        Class20.smethod_4(gstruct42_.uint_4, 32u);
                    }
                    if (flag4 && array2 != null && gstruct42_.int_14 > 0)
                    {
                        flag3 = true;
                        goto IL_05de;
                    }
                }
                num9 = 0;
                array3 = new byte[4];
                while (true)
                {
                    if (num10 == 0)
                    {
                        Class20.ReadProcessMemory(gstruct42_.int_130, gstruct42_.uint_6 + Class47.gstruct43_147.uint_0, array3, 4, ref int_14);
                        num10 = BitConverter.ToUInt32(array3, 0);
                        if (num10 == 0 && num9 > 10)
                        {
                            break;
                        }
                        num9++;
                        Thread.Sleep(30);
                        continue;
                    }
                    string text2 = "STRINGINPUT";
                    uint uint_2 = num10 + Class47.gstruct43_244.uint_0;
                    array3 = new byte[text2.Length + 1];
                    Class20.ReadProcessMemory(gstruct42_.int_130, uint_2, array3, array3.Length, ref int_14);
                    string a = Class10.smethod_3(array3).Trim().ToUpper();
                    if (!(a != text2))
                    {
                        int num18 = int_5;
                        if (num18 <= 0)
                        {
                            num18 = 1;
                        }
                        char[] array4 = num18.ToString().ToCharArray();
                        for (int k = 0; k < array4.Length; k++)
                        {
                            Class20.smethod_4(gstruct42_.uint_4, array4[k]);
                            Thread.Sleep(80);
                        }
                        Class20.smethod_4(gstruct42_.uint_4, 13u);
                        Thread.Sleep(150);
                    }
                    break;
                }
                bool flag5;
                bool flag6;
                bool flag7;
                if (Class39.smethod_9(gstruct42_))
                {
                    uint uint_3 = 3u;
                    uint uint_4 = 12u;
                    if (flag5)
                    {
                        Class39.smethod_19(gstruct42_, uint_3, uint_4, string_5, int_6, FormMain.int_5 > 0);
                    }
                    if (flag6)
                    {
                        Class39.smethod_19(gstruct42_, uint_3, uint_4, string_6, int_7, FormMain.int_5 > 0);
                    }
                    if (flag7)
                    {
                        Class39.smethod_19(gstruct42_, uint_3, uint_4, string_7, int_8, FormMain.int_5 > 0);
                    }
                    Thread.Sleep(400);
                    Class39.smethod_14(gstruct42_, bool_0: true);
                    Thread.Sleep(100);
                    for (int l = 0; l < 10; l++)
                    {
                        if (!flag5 && !flag6 && !flag7)
                        {
                            break;
                        }
                        if (!Class39.smethod_9(gstruct42_))
                        {
                            break;
                        }
                        Thread.Sleep(100);
                    }
                }
                if (gstruct42_.int_18 > 0)
                {
                    for (num9 = 0; num9 < 100; num9++)
                    {
                        if (Class39.smethod_9(gstruct42_))
                        {
                            break;
                        }
                        Thread.Sleep(10);
                    }
                    if (int_10 > 0)
                    {
                        if (!flag2 && gstruct42_.string_13 != null && gstruct42_.string_13 != string.Empty)
                        {
                            uint num19 = Class11.smethod_13(gstruct42_.string_13);
                            if (num19 != 0)
                            {
                                Class60.smethod_113(gstruct42_, num19);
                                Thread.Sleep(100);
                                flag2 = true;
                            }
                        }
                        uint num20 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_.int_130) + Class47.gstruct43_12.uint_0 + Class47.gstruct43_75.uint_0;
                        long num21 = Class20.smethod_30(num20 + Class47.gstruct43_74.uint_0, gstruct42_.int_130);
                        if (num21 > 0L)
                        {
                            Class60.smethod_35(gstruct42_, (uint)num21);
                        }
                    }
                    smethod_5(gstruct42_, string_8, int_9);
                }
                if (Class39.smethod_9(gstruct42_))
                {
                    Class39.smethod_12(gstruct42_);
                    Thread.Sleep(100);
                }
                Class76.smethod_9(gstruct42_);
                num3++;
                continue;
                IL_05de:
                if (array2 != null)
                {
                    Class60.smethod_41(gstruct42_, (uint)array2[0], array2[2], array2[3]);
                }
                Thread.Sleep(300);
                if (gstruct42_.int_13 != null)
                {
                    int m;
                    for (m = 0; m < 10; m++)
                    {
                        if (!Class76.smethod_0(gstruct42_))
                        {
                            Thread.Sleep(100);
                            continue;
                        }
                        m = -1;
                        break;
                    }
                    int num22 = Class76.smethod_1(gstruct42_);
                    int num23 = Class76.smethod_2(gstruct42_, num22);
                    if (m == -1 && num23 > 0)
                    {
                        for (int j = 0; j < gstruct42_.int_13.Length; j++)
                        {
                            if (gstruct42_.int_13[j] > 0)
                            {
                                Class76.smethod_6(gstruct42_, gstruct42_.int_13[j] - 1);
                                Thread.Sleep(500);
                            }
                        }
                        Class76.smethod_9(gstruct42_);
                    }
                }
                goto IL_06b0;
                IL_036f:
                num8--;
                if (num4 > 0 || FormMain.int_4 <= 0)
                {

                    flag5 = (gstruct42_.int_15 > 0 && string_5 != null && string_5 != string.Empty);
                    flag6 = (gstruct42_.int_16 > 0 && string_6 != null && string_6 != string.Empty);
                    flag7 = (gstruct42_.int_17 > 0 && string_7 != null && string_7 != string.Empty);
                    flag4 = (gstruct42_.int_12 > 0 && gstruct42_.string_1 != null && gstruct42_.string_1 != string.Empty);
                    if (flag5 || flag6 || flag7)
                    {
                        Class76.smethod_9(gstruct42_);
                        Class39.smethod_18(gstruct42_);
                    }
                    flag3 = false;
                    if (flag4)
                    {
                        if (array2 != null)
                        {
                            string text3 = Class69.smethod_6(gstruct42_, (uint)array2[0]);
                            if (text3 != gstruct42_.string_1 && Class11.smethod_2(text3, gstruct42_.string_1) != 0)
                            {
                                array2 = null;
                                num6 = -1;
                            }
                        }
                        if (num6 != Class69.smethod_2(gstruct42_))
                        {
                            array2 = Class69.smethod_26(gstruct42_, new string[1]
                            {
                        gstruct42_.string_1
                            });
                            num6 = Class69.smethod_2(gstruct42_);
                        }
                        if (array2 != null && gstruct42_.int_14 <= 0)
                        {
                            goto IL_05de;
                        }
                    }
                    goto IL_06b0;
                }
            }
		}
		while (gstruct42_.int_7[0] <= 0 || gstruct42_.int_7[1] > num3);
		num = Class71.smethod_3(FormMain.gstruct42_0, int_13);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].bool_6 = false;
			FormMain.gstruct42_0[num].bool_27 = true;
		}
		Class60.smethod_50(gstruct42_, "ClickNPC ket thuc !");
	}

	public static void smethod_5(GStruct42 gstruct42_0, string string_9, int int_13)
	{
		int num = 0;
		int num2 = -1;
		GStruct1[] array = null;
		string a = string_9.Trim().ToUpper();
		int num3 = 0;
		bool flag = false;
		int num4;
		while (true)
		{
			num4 = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
			if (Class11.bool_0 || num4 < 0)
			{
				break;
			}
			gstruct42_0 = FormMain.gstruct42_0[num4];
			if (!flag)
			{
				FormMain.gstruct42_0[num4].bool_13 = true;
				flag = true;
			}
			else if (!gstruct42_0.bool_13)
			{
				break;
			}
			int num5 = int_13 - Class69.smethod_31(gstruct42_0, string_9);
			if (num5 <= 0)
			{
				break;
			}
			int num6 = Class69.smethod_21(gstruct42_0);
			if (num6 > 0)
			{
				num = 0;
				if (array == null)
				{
					array = Class15.smethod_1(gstruct42_0);
					if (array == null)
					{
						break;
					}
				}
				if (num2 <= 0)
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (a == array[i].string_0.Trim().ToUpper())
						{
							num2 = i;
							break;
						}
					}
					if (num2 < 0)
					{
						break;
					}
				}
				int int_14 = 0;
				string empty = string.Empty;
				uint num7 = Class20.smethod_30(Class47.gstruct43_161.uint_0, gstruct42_0.int_130);
				byte[] array2 = new byte[80];
				byte[] array3 = new byte[4];
				int num8 = Class69.smethod_2(gstruct42_0);
				if (num5 > 60)
				{
					num5 = 60;
				}
				for (int j = 0; j < num5; j++)
				{
					Class60.smethod_39(gstruct42_0, num2);
					Thread.Sleep(8 + FormMain.int_105);
					if ((j == 0 || j % 8 != 0) && j + 1 != num5)
					{
						continue;
					}
					int num9 = Class69.smethod_2(gstruct42_0);
					if (num9 != num8)
					{
						num8 = num9;
						num3 = 0;
					}
					else
					{
						num3++;
						if (num3 > 10)
						{
							goto end_IL_0018;
						}
					}
					try
					{
						num4 = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
						if (!Class11.bool_0 && num4 >= 0 && FormMain.gstruct42_0[num4].bool_36)
						{
							goto IL_02d5;
						}
					}
					catch
					{
						goto IL_02d5;
					}
					goto end_IL_0018;
					IL_0275:
					Class46.smethod_0(gstruct42_0);
					if (Class11.smethod_2(empty, "ho¶ng trèng") > 0)
					{
						break;
					}
					if (Class11.smethod_2(empty, "kh«ng ®") > 0)
					{
						Class39.smethod_27(gstruct42_0.int_129);
						goto end_IL_0018;
					}
					continue;
					IL_02d5:
					uint num10 = Class20.smethod_30(num7 + Class47.gstruct43_163.uint_0, gstruct42_0.int_130);
					if (num10 == 0)
					{
						continue;
					}
					for (uint num11 = 0u; num11 < 2; num11++)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num10 + num11 * 4, array3, 4, ref int_14);
						uint num12 = BitConverter.ToUInt32(array3, 0);
						if (num12 == 0)
						{
							continue;
						}
						Class20.ReadProcessMemory(gstruct42_0.int_130, num12, array2, array2.Length, ref int_14);
						empty = Class10.smethod_3(array2);
						if (!(empty != string.Empty))
						{
							continue;
						}
						goto IL_0275;
					}
				}
			}
			else
			{
				if (num > 0)
				{
					break;
				}
				Class39.smethod_27(gstruct42_0.int_129);
				Thread.Sleep(100);
				num = 1;
			}
			continue;
			end_IL_0018:
			break;
		}
		num4 = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
		if (0 <= num4)
		{
			FormMain.gstruct42_0[num4].bool_13 = false;
		}
	}

	private void checkBoxCoMuaVatpham_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_18 = Convert.ToByte(checkBoxCoMuaVatpham.Checked);
			}
		}
	}

	private void textBoxSoluongMua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int_9 = Class11.smethod_12(textBoxSoluongMua.Text);
			Class55.smethod_10(Class47.string_0, "SoluongVatphamMuaNpc", int_9, "", 0);
		}
	}

	private void comboBoxMuaVP_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		bool_1 = false;
		string_4 = Class69.smethod_29(FormMain.gstruct42_0[num]);
		comboBoxMuaVP.Items.Clear();
		if (string_4 != null)
		{
			for (int i = 0; i < string_4.Length; i++)
			{
				comboBoxMuaVP.Items.Add(Class10.smethod_1(string_4[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_1 = true;
	}

	private void comboBoxMuaVP_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_4 == null)
		{
			return;
		}
		string text = comboBoxMuaVP.Text;
		int num = 0;
		while (true)
		{
			if (num < string_4.Length)
			{
				if (text == Class10.smethod_1(string_4[num], 1))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		string_8 = string_4[num];
		Class55.smethod_10(Class47.string_0, "TenVatphamMua", Class11.smethod_17(string_8), "", 0);
	}

	private void linkLabelMuaPhaohoa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string str = "https://youtu.be/qdrw1B2yHFc";
		Class20.smethod_40(Class55.smethod_0(), "", str, 0);
		string text = "Xem video hướng dẫn tại: " + Class47.string_3 + str;
		FormTip.smethod_0(FormMain.string_1, text, 600000, 250, 80);
	}

	private void checkBoxRuthettien_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int_10 = Convert.ToByte(checkBoxRuthettien.Checked);
			Class55.smethod_10(Class47.string_0, "flagRutHetTienNPC", int_10, "", 0);
		}
	}

	private void checkBoxChinhXacTen_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			FormMain.int_5 = Convert.ToByte(checkBoxChinhXacTen.Checked);
			Class55.smethod_10(Class47.string_0, "flagChinhxacTenVatpham", FormMain.int_5, "", 0);
		}
	}
}
