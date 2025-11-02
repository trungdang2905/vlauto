using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Loaitru : Form
{
	public static bool bool_0 = false;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	private int int_4 = -1;

	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ComboBox comboBoxAcc;

	private Button buttonThem;

	private Button buttonXoa;

	private Label label1;

	private Timer timer_0;

	private Button buttonThoat;

	public Loaitru()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		string text = "";
		if (Class47.string_2 != null)
		{
			for (int i = 0; i < Class47.string_2.Length; i++)
			{
				if (!(Class47.string_2[i] != ""))
				{
					continue;
				}
				if (text != "")
				{
					text += "|";
				}
				text += Class47.string_2[i];
				if (FormMain.gstruct42_0 == null)
				{
					continue;
				}
				for (int j = 0; j < FormMain.gstruct42_0.Length; j++)
				{
					if (Class47.string_2[i] == FormMain.gstruct42_0[j].string_20)
					{
						FormMain.gstruct42_0[j].bool_33 = true;
						break;
					}
				}
			}
		}
		Class55.smethod_10(Class47.string_0, "DanhSachLoaitru", Class11.smethod_17(text), "", 0);
		int_0 = 0;
		int_1 = 0;
		bool_0 = false;
	}

	private void Loaitru_Load(object sender, EventArgs e)
	{
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
		if (Class47.string_2 != null && Class47.string_2.Length > 0)
		{
			for (int i = 0; i < Class47.string_2.Length; i++)
			{
				if (Class47.string_2[i] != "")
				{
					method_0(listView1, Class10.smethod_1(Class47.string_2[i], 1));
				}
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		this.method_1("Danh sach loai tru");
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void method_0(ListView listView_0, string string_0)
	{
		ListViewItem value = new ListViewItem(string_0);
		listView_0.Items.Add(value);
	}

	private void comboBoxAcc_DropDown(object sender, EventArgs e)
	{
		comboBoxAcc.Items.Clear();
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				bool flag = false;
				if (Class47.string_2 != null)
				{
					for (int j = 0; j < Class47.string_2.Length; j++)
					{
						if (Class47.string_2[j] == FormMain.gstruct42_0[i].string_20)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					string item = Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1);
					comboBoxAcc.Items.Add(item);
				}
			}
		}
		comboBoxAcc.Text = "";
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (FormMain.gstruct42_0 == null || FormMain.gstruct42_0.Length == 0)
		{
			return;
		}
		string text = comboBoxAcc.Text;
		for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
		{
			if (!(Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1) == text))
			{
				continue;
			}
			bool flag = false;
			if (Class47.string_2 != null)
			{
				for (int j = 0; j < Class47.string_2.Length; j++)
				{
					if (Class47.string_2[j] == FormMain.gstruct42_0[i].string_20)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				Class11.smethod_24(ref Class47.string_2, FormMain.gstruct42_0[i].string_20);
				FormMain.gstruct42_0[i].bool_33 = true;
				method_0(listView1, Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1));
			}
			break;
		}
		comboBoxAcc.Items.Clear();
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		string text = comboBoxAcc.Text;
		if (FormMain.gstruct42_0 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[i].string_20, 1) == text)
				{
					FormMain.gstruct42_0[i].bool_33 = false;
					break;
				}
			}
		}
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].SubItems[0].Text == text)
			{
				listView1.Items.RemoveAt(i);
				break;
			}
		}
		if (Class47.string_2 != null)
		{
			for (int i = 0; i < Class47.string_2.Length; i++)
			{
				if (Class10.smethod_1(Class47.string_2[i], 1) == text)
				{
					Class11.smethod_25(ref Class47.string_2, Class47.string_2[i]);
					break;
				}
			}
		}
		comboBoxAcc.Items.Clear();
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Loaitru));
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		comboBoxAcc = new System.Windows.Forms.ComboBox();
		buttonThem = new System.Windows.Forms.Button();
		buttonXoa = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonThoat = new System.Windows.Forms.Button();
		SuspendLayout();
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			columnHeader_0
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(0, 46);
		listView1.MultiSelect = false;
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(274, 158);
		listView1.TabIndex = 1;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(listView1_MouseClick);
		columnHeader_0.Text = "Nhân vật";
		columnHeader_0.Width = 245;
		comboBoxAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxAcc.FormattingEnabled = true;
		comboBoxAcc.Location = new System.Drawing.Point(45, 215);
		comboBoxAcc.Name = "comboBoxAcc";
		comboBoxAcc.Size = new System.Drawing.Size(115, 21);
		comboBoxAcc.TabIndex = 2;
		comboBoxAcc.DropDown += new System.EventHandler(comboBoxAcc_DropDown);
		buttonThem.Location = new System.Drawing.Point(163, 214);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(55, 23);
		buttonThem.TabIndex = 3;
		buttonThem.Text = "Thêm";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		buttonXoa.Location = new System.Drawing.Point(1, 214);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(42, 23);
		buttonXoa.TabIndex = 4;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		label1.Location = new System.Drawing.Point(0, 0);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(273, 41);
		label1.TabIndex = 5;
		label1.Text = "Những ac nằm trong danh sách này luôn ở chế độ KHÔNG tự vệ (không đánh), ví dụ ac nga my buff... chỉ dùng theo sau để buff hỗ trợ.";
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonThoat.Location = new System.Drawing.Point(220, 214);
		buttonThoat.Name = "buttonThoat";
		buttonThoat.Size = new System.Drawing.Size(55, 23);
		buttonThoat.TabIndex = 6;
		buttonThoat.Text = "Đóng";
		buttonThoat.UseVisualStyleBackColor = true;
		buttonThoat.Click += new System.EventHandler(buttonThoat_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(281, 244);
		base.Controls.Add(buttonThoat);
		base.Controls.Add(label1);
		base.Controls.Add(buttonXoa);
		base.Controls.Add(buttonThem);
		base.Controls.Add(comboBoxAcc);
		base.Controls.Add(listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Loaitru";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "Danh sach loai tru";
		base.Load += new System.EventHandler(Loaitru_Load);
		ResumeLayout(performLayout: false);
	}

	void method_1(string string_0)
	{
		base.Text = string_0;
	}
}
