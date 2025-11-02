using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormPT : Form
{
	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ComboBox comboBoxAcc;

	private Button buttonThem;

	private Button buttonXoa;

	private Timer timer_0;

	private Button buttonThoat;

	private Label label1;

	private CheckBox checkBoxPTtheoBHO;

	private CheckBox checkBoxTheoDSnhom;

	private CheckBox checkBoxLuonLamDoitruong;

	private CheckBox checkBoxHienThiSonguoi;

	private Button buttonApdungAll;

	private Button buttonAllAc;

	public static bool bool_0 = false;

	public static GStruct42 gstruct42_0 = default(GStruct42);

	private static string[] string_0 = null;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	private int int_4 = -1;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormPT));
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		comboBoxAcc = new System.Windows.Forms.ComboBox();
		buttonThem = new System.Windows.Forms.Button();
		buttonXoa = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonThoat = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		checkBoxPTtheoBHO = new System.Windows.Forms.CheckBox();
		checkBoxTheoDSnhom = new System.Windows.Forms.CheckBox();
		checkBoxLuonLamDoitruong = new System.Windows.Forms.CheckBox();
		checkBoxHienThiSonguoi = new System.Windows.Forms.CheckBox();
		buttonApdungAll = new System.Windows.Forms.Button();
		buttonAllAc = new System.Windows.Forms.Button();
		SuspendLayout();
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			columnHeader_0
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(10, 27);
		listView1.MultiSelect = false;
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(245, 158);
		listView1.TabIndex = 1;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(listView1_MouseClick);
		columnHeader_0.Text = "Nhân vật";
		columnHeader_0.Width = 200;
		comboBoxAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxAcc.FormattingEnabled = true;
		comboBoxAcc.Location = new System.Drawing.Point(10, 191);
		comboBoxAcc.Name = "comboBoxAcc";
		comboBoxAcc.Size = new System.Drawing.Size(139, 21);
		comboBoxAcc.TabIndex = 2;
		comboBoxAcc.DropDown += new System.EventHandler(comboBoxAcc_DropDown);
		buttonThem.Location = new System.Drawing.Point(155, 189);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(55, 23);
		buttonThem.TabIndex = 3;
		buttonThem.Text = "Thêm";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		buttonXoa.Location = new System.Drawing.Point(212, 189);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(42, 23);
		buttonXoa.TabIndex = 4;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonThoat.Location = new System.Drawing.Point(155, 343);
		buttonThoat.Name = "buttonThoat";
		buttonThoat.Size = new System.Drawing.Size(99, 26);
		buttonThoat.TabIndex = 6;
		buttonThoat.Text = "Đóng";
		buttonThoat.UseVisualStyleBackColor = true;
		buttonThoat.Click += new System.EventHandler(buttonThoat_Click);
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(8, 7);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(88, 13);
		label1.TabIndex = 7;
		label1.Text = "Danh sách nhóm";
		checkBoxPTtheoBHO.AutoSize = true;
		checkBoxPTtheoBHO.Location = new System.Drawing.Point(30, 282);
		checkBoxPTtheoBHO.Name = "checkBoxPTtheoBHO";
		checkBoxPTtheoBHO.Size = new System.Drawing.Size(128, 17);
		checkBoxPTtheoBHO.TabIndex = 8;
		checkBoxPTtheoBHO.Text = "Mời PT theo bang hội";
		checkBoxPTtheoBHO.UseVisualStyleBackColor = true;
		checkBoxPTtheoBHO.CheckedChanged += new System.EventHandler(checkBoxPTtheoBHO_CheckedChanged);
		checkBoxTheoDSnhom.AutoSize = true;
		checkBoxTheoDSnhom.Location = new System.Drawing.Point(30, 256);
		checkBoxTheoDSnhom.Name = "checkBoxTheoDSnhom";
		checkBoxTheoDSnhom.Size = new System.Drawing.Size(191, 17);
		checkBoxTheoDSnhom.TabIndex = 9;
		checkBoxTheoDSnhom.Text = "Mời hoặc nhận PT theo danh sách";
		checkBoxTheoDSnhom.UseVisualStyleBackColor = true;
		checkBoxTheoDSnhom.CheckedChanged += new System.EventHandler(checkBoxTheoDSnhom_CheckedChanged);
		checkBoxLuonLamDoitruong.AutoSize = true;
		checkBoxLuonLamDoitruong.Location = new System.Drawing.Point(10, 230);
		checkBoxLuonLamDoitruong.Name = "checkBoxLuonLamDoitruong";
		checkBoxLuonLamDoitruong.Size = new System.Drawing.Size(120, 17);
		checkBoxLuonLamDoitruong.TabIndex = 10;
		checkBoxLuonLamDoitruong.Text = "Luôn làm đội trưởng";
		checkBoxLuonLamDoitruong.UseVisualStyleBackColor = true;
		checkBoxLuonLamDoitruong.CheckedChanged += new System.EventHandler(checkBoxLuonLamDoitruong_CheckedChanged);
		checkBoxHienThiSonguoi.AutoSize = true;
		checkBoxHienThiSonguoi.Location = new System.Drawing.Point(10, 308);
		checkBoxHienThiSonguoi.Name = "checkBoxHienThiSonguoi";
		checkBoxHienThiSonguoi.Size = new System.Drawing.Size(161, 17);
		checkBoxHienThiSonguoi.TabIndex = 11;
		checkBoxHienThiSonguoi.Text = "Hiển thị số người trong nhóm";
		checkBoxHienThiSonguoi.UseVisualStyleBackColor = true;
		checkBoxHienThiSonguoi.CheckedChanged += new System.EventHandler(checkBoxHienThiSonguoi_CheckedChanged);
		buttonApdungAll.Location = new System.Drawing.Point(10, 343);
		buttonApdungAll.Name = "buttonApdungAll";
		buttonApdungAll.Size = new System.Drawing.Size(139, 26);
		buttonApdungAll.TabIndex = 13;
		buttonApdungAll.Text = "Áp dụng cho tất cả ac";
		buttonApdungAll.UseVisualStyleBackColor = true;
		buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		buttonAllAc.Location = new System.Drawing.Point(155, 216);
		buttonAllAc.Name = "buttonAllAc";
		buttonAllAc.Size = new System.Drawing.Size(99, 36);
		buttonAllAc.TabIndex = 14;
		buttonAllAc.Text = "Thêm tất cả ac trên auto";
		buttonAllAc.UseVisualStyleBackColor = true;
		buttonAllAc.Click += new System.EventHandler(buttonAllAc_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(268, 378);
		base.Controls.Add(buttonAllAc);
		base.Controls.Add(buttonApdungAll);
		base.Controls.Add(checkBoxHienThiSonguoi);
		base.Controls.Add(checkBoxLuonLamDoitruong);
		base.Controls.Add(checkBoxTheoDSnhom);
		base.Controls.Add(checkBoxPTtheoBHO);
		base.Controls.Add(label1);
		base.Controls.Add(buttonThoat);
		base.Controls.Add(buttonXoa);
		base.Controls.Add(buttonThem);
		base.Controls.Add(comboBoxAcc);
		base.Controls.Add(listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormPT";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "PT";
		base.Load += new System.EventHandler(FormPT_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormPT()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, gstruct42_0.int_129);
		if (0 <= num)
		{
			FormMain.gstruct42_0[num].string_17 = gstruct42_0.string_17;
			FormMain.gstruct42_0[num].int_118 = gstruct42_0.int_118;
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
		gstruct42_0.int_129 = 0;
		int_0 = 0;
		int_1 = 0;
		bool_0 = false;
	}

	private void FormPT_Load(object sender, EventArgs e)
	{
		bool_1 = false;
		if (gstruct42_0.int_129 == 0)
		{
			Close();
			return;
		}
		if (int_0 > 0 && int_1 > 0)
		{
			int num = int_0 - base.Width - 10;
			int num2 = int_1 - base.Height - 10;
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
		if (gstruct42_0.string_17 != null && gstruct42_0.string_17.Length > 0)
		{
			for (int i = 0; i < gstruct42_0.string_17.Length; i++)
			{
				if (gstruct42_0.string_17[i] != null && gstruct42_0.string_17[i] != string.Empty)
				{
					method_0(listView1, Class10.smethod_1(gstruct42_0.string_17[i], 1));
				}
			}
		}
		if (gstruct42_0.int_118 == null || gstruct42_0.int_118.Length < 5)
		{
			gstruct42_0.int_118 = new int[5]
			{
				0,
				0,
				0,
				0,
				5
			};
		}
		checkBoxLuonLamDoitruong.Checked = (gstruct42_0.int_118[1] > 0);
		checkBoxTheoDSnhom.Checked = (gstruct42_0.int_118[2] > 0);
		checkBoxPTtheoBHO.Checked = (gstruct42_0.int_118[3] > 0);
		checkBoxPTtheoBHO.Enabled = (gstruct42_0.int_118[1] > 0);
		checkBoxHienThiSonguoi.Checked = (gstruct42_0.int_118[4] > 0);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		this.method_1("PT ( " + Class10.smethod_1(gstruct42_0.string_20, 1) + " )");
		bool_1 = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void method_0(ListView listView_0, string string_1)
	{
		ListViewItem value = new ListViewItem(string_1);
		listView_0.Items.Add(value);
	}

	private void comboBoxAcc_DropDown(object sender, EventArgs e)
	{
		comboBoxAcc.Items.Clear();
		string_0 = null;
		Class86.smethod_24(gstruct42_0, ref string_0, 1, gstruct42_0.string_17);
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxAcc.Items.Add(Class10.smethod_1(string_0[i], 1));
			}
		}
		comboBoxAcc.Text = string.Empty;
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		string text = comboBoxAcc.Text;
		comboBoxAcc.Items.Clear();
		if (string_0 == null || text == string.Empty)
		{
			return;
		}
		string text2 = null;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] == text || Class10.smethod_1(string_0[i], 1) == text)
			{
				text2 = string_0[i];
				break;
			}
		}
		if (text2 == null)
		{
			return;
		}
		if (gstruct42_0.string_17 != null && gstruct42_0.string_17.Length > 0)
		{
			for (int i = 0; i < gstruct42_0.string_17.Length; i++)
			{
				if (gstruct42_0.string_17[i] == text2)
				{
					return;
				}
			}
		}
		Class11.smethod_24(ref gstruct42_0.string_17, text2);
		method_0(listView1, Class10.smethod_1(text2, 1));
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		string text = comboBoxAcc.Text;
		comboBoxAcc.Items.Clear();
		if (gstruct42_0.string_17 == null || text == string.Empty)
		{
			return;
		}
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (text == listView1.Items[i].SubItems[0].Text)
			{
				listView1.Items.RemoveAt(i);
				break;
			}
		}
		if (gstruct42_0.string_17.Length == 1 && (gstruct42_0.string_17[0] == text || Class10.smethod_1(gstruct42_0.string_17[0], 1) == text))
		{
			gstruct42_0.string_17 = null;
			listView1.Items.Clear();
			return;
		}
		int num = 0;
		string[] array = new string[gstruct42_0.string_17.Length];
		for (int i = 0; i < gstruct42_0.string_17.Length; i++)
		{
			if (!(gstruct42_0.string_17[i] == text) && !(Class10.smethod_1(gstruct42_0.string_17[i], 1) == text))
			{
				array[num] = gstruct42_0.string_17[i];
				num++;
			}
		}
		if (num != 0)
		{
			gstruct42_0.string_17 = new string[num];
			for (int i = 0; i < num; i++)
			{
				gstruct42_0.string_17[i] = array[i];
			}
		}
		else
		{
			gstruct42_0.string_17 = null;
			listView1.Items.Clear();
		}
	}

	private void listView1_MouseClick(object sender, MouseEventArgs e)
	{
		int_4 = -1;
		if (listView1.Items == null)
		{
			return;
		}
		string text = comboBoxAcc.Text;
		int num = 0;
		while (true)
		{
			if (num < listView1.Items.Count)
			{
				if (listView1.Items[num].Selected)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		int_4 = num;
		string text2 = listView1.Items[num].SubItems[0].Text;
		if (text != text2)
		{
			comboBoxAcc.Items.Clear();
			comboBoxAcc.Items.Add(text2);
			comboBoxAcc.Text = text2;
		}
	}

	private void buttonThoat_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxLuonLamDoitruong_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_1)
		{
			gstruct42_0.int_118[1] = Convert.ToByte(checkBoxLuonLamDoitruong.Checked);
			checkBoxPTtheoBHO.Enabled = (gstruct42_0.int_118[1] > 0);
		}
	}

	private void checkBoxTheoDSnhom_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_1)
		{
			gstruct42_0.int_118[2] = Convert.ToByte(checkBoxTheoDSnhom.Checked);
		}
	}

	private void checkBoxPTtheoBHO_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_1)
		{
			gstruct42_0.int_118[3] = Convert.ToByte(checkBoxPTtheoBHO.Checked);
		}
	}

	private void checkBoxHienThiSonguoi_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_1)
		{
			gstruct42_0.int_118[4] = Convert.ToByte(checkBoxHienThiSonguoi.Checked);
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		if (FormMain.gstruct42_0 == null || FormMain.gstruct42_0.Length == 0)
		{
			return;
		}
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			if (FormMain.gstruct42_0[i].int_129 == gstruct42_0.int_129)
			{
				continue;
			}
			FormMain.gstruct42_0[i].string_17 = null;
			if (gstruct42_0.int_118 != null)
			{
				int num = 0;
				if (FormMain.gstruct42_0[i].int_118 != null)
				{
					num = FormMain.gstruct42_0[i].int_118[1];
				}
				else
				{
					FormMain.gstruct42_0[i].int_118 = new int[gstruct42_0.int_118.Length];
				}
				for (int j = 0; j < gstruct42_0.int_118.Length; j++)
				{
					FormMain.gstruct42_0[i].int_118[j] = gstruct42_0.int_118[j];
				}
				FormMain.gstruct42_0[i].int_118[1] = num;
			}
			if (gstruct42_0.string_17 != null)
			{
				FormMain.gstruct42_0[i].string_17 = new string[gstruct42_0.string_17.Length];
				for (int j = 0; j < gstruct42_0.string_17.Length; j++)
				{
					FormMain.gstruct42_0[i].string_17[j] = gstruct42_0.string_17[j];
				}
			}
			Class47.smethod_11(FormMain.gstruct42_0[i]);
		}
	}

	private void buttonAllAc_Click(object sender, EventArgs e)
	{
		if (FormMain.gstruct42_0 != null && FormMain.gstruct42_0.Length != 0)
		{
			listView1.Items.Clear();
			gstruct42_0.string_17 = new string[FormMain.gstruct42_0.Length];
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				gstruct42_0.string_17[i] = FormMain.gstruct42_0[i].string_20;
				method_0(listView1, Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1));
			}
		}
	}

	void method_1(string string_1)
	{
		base.Text = string_1;
	}
}
