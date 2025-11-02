using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormThuocTocdoDanh : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static int int_1 = -1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private int int_6 = -1;

	private static bool bool_1 = false;

	private static GStruct42 gstruct42_0 = default(GStruct42);

	private static string[] string_0 = null;

	private IContainer icontainer_0 = null;

	private ComboBox comboBoxTenTuiMauHotro;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private Button buttonThem;

	private Button buttonXoa;

	private Button buttonClose;

	private Timer timer_0;

	private Button buttonAppAll;

	private Label label1;

	private TextBox textBoxGiay;

	private Label label2;

	public FormThuocTocdoDanh()
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
		int_2 = 0;
		int_3 = 0;
		int_1 = -1;
		int_0 = 0;
		bool_0 = false;
	}

	private void FormThuocTocdoDanh_Load(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			gstruct42_0 = FormMain.gstruct42_0[num];
			if (int_2 > 0 && int_3 > 0)
			{
				int num2 = int_2 - base.Width - 10;
				int num3 = int_3 - base.Height - 10;
				if (num2 < 0)
				{
					num2 = 0;
				}
				if (num3 < 0)
				{
					num3 = 0;
				}
				SetBounds(num2, num3, base.Width, base.Height);
			}
			timer_0.Interval = 300;
			timer_0.Enabled = true;
			bool_1 = true;
			base.TopMost = true;
		}
		else
		{
			Close();
		}
	}

	private void method_0(string[] string_1)
	{
		listView1.Items.Clear();
		if (string_1 != null && string_1.Length > 0)
		{
			for (int i = 0; i < string_1.Length; i++)
			{
				method_1(listView1, Class10.smethod_1(string_1[i], 1));
			}
		}
		textBoxGiay.Text = gstruct42_0.int_65[2].ToString();
		int_6 = -1;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
		else if (int_1 != int_0)
		{
			int_1 = int_0;
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
			if (num < 0)
			{
				buttonThem.Enabled = false;
				listView1.Enabled = false;
			}
			else
			{
				buttonThem.Enabled = true;
				listView1.Enabled = true;
				method_0(FormMain.gstruct42_0[num].string_6);
			}
		}
	}

	private void method_1(ListView listView_0, string string_1)
	{
		string[] array = new string[1]
		{
			string_1
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

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		int_6 = -1;
		if (listView1.Items == null || listView1.Items.Count == 0)
		{
			return;
		}
		string text = null;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				int_6 = i;
				text = listView1.Items[i].SubItems[0].Text;
				break;
			}
		}
		if (int_6 >= 0 && text != null && text != comboBoxTenTuiMauHotro.Text)
		{
			comboBoxTenTuiMauHotro.Items.Clear();
			comboBoxTenTuiMauHotro.Items.Add(text);
			comboBoxTenTuiMauHotro.Text = text;
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
	{
		string_0 = Class69.smethod_29(gstruct42_0);
		comboBoxTenTuiMauHotro.Items.Clear();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxTenTuiMauHotro.Items.Add(Class10.smethod_1(string_0[i], 1));
			}
		}
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_0 == null)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = null;
		string text2 = comboBoxTenTuiMauHotro.Text;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (text2 == Class10.smethod_1(string_0[i], 1))
			{
				text = string_0[i];
				break;
			}
		}
		if (text == null)
		{
			return;
		}
		if (FormMain.gstruct42_0[num].string_6 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0[num].string_6.Length; i++)
			{
				if (FormMain.gstruct42_0[num].string_6[i] == text)
				{
					return;
				}
			}
		}
		method_1(listView1, Class10.smethod_1(text, 1));
		Class11.smethod_24(ref FormMain.gstruct42_0[num].string_6, text);
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		int i;
		if (FormMain.gstruct42_0[num].string_6 != null)
		{
			for (i = 0; i < FormMain.gstruct42_0[num].string_6.Length; i++)
			{
				if (Class10.smethod_1(FormMain.gstruct42_0[num].string_6[i], 1) == text)
				{
					Class11.smethod_25(ref FormMain.gstruct42_0[num].string_6, FormMain.gstruct42_0[num].string_6[i]);
					break;
				}
			}
		}
		i = 0;
		while (true)
		{
			if (i < listView1.Items.Count)
			{
				if (text == listView1.Items[i].SubItems[0].Text)
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		listView1.Items.RemoveAt(i);
	}

	private void buttonAppAll_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num >= 0 && FormMain.gstruct42_0 != null)
		{
			try
			{
				for (int i = 0; i < FormMain.gstruct42_0.Length; i++)
				{
					if (i != num)
					{
						if (FormMain.gstruct42_0[num].string_6 == null)
						{
							FormMain.gstruct42_0[i].string_6 = null;
						}
						else
						{
							FormMain.gstruct42_0[i].string_6 = new string[FormMain.gstruct42_0[num].string_6.Length];
							for (int j = 0; j < FormMain.gstruct42_0[num].string_6.Length; j++)
							{
								FormMain.gstruct42_0[i].string_6[j] = FormMain.gstruct42_0[num].string_6[j];
							}
						}
						if (FormMain.gstruct42_0[num].int_65 != null)
						{
							if (FormMain.gstruct42_0[i].int_65 == null)
							{
								FormMain.gstruct42_0[i].int_65 = new int[FormMain.gstruct42_0[num].int_65.Length];
							}
							for (int j = 0; j < FormMain.gstruct42_0[num].int_65.Length; j++)
							{
								if (j != 1)
								{
									FormMain.gstruct42_0[i].int_65[j] = FormMain.gstruct42_0[num].int_65[j];
								}
							}
						}
						Class47.smethod_11(FormMain.gstruct42_0[i]);
					}
				}
			}
			catch
			{
			}
		}
	}

	private void textBoxGiay_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_12(textBoxGiay.Text);
			if (num2 < 3)
			{
				num2 = 3;
			}
			FormMain.gstruct42_0[num].int_65[2] = num2;
		}
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormThuocTocdoDanh));
		comboBoxTenTuiMauHotro = new System.Windows.Forms.ComboBox();
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		buttonThem = new System.Windows.Forms.Button();
		buttonXoa = new System.Windows.Forms.Button();
		buttonClose = new System.Windows.Forms.Button();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonAppAll = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		textBoxGiay = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		SuspendLayout();
		comboBoxTenTuiMauHotro.DropDownWidth = 250;
		comboBoxTenTuiMauHotro.FormattingEnabled = true;
		comboBoxTenTuiMauHotro.Location = new System.Drawing.Point(4, 180);
		comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
		comboBoxTenTuiMauHotro.Size = new System.Drawing.Size(214, 21);
		comboBoxTenTuiMauHotro.TabIndex = 217;
		comboBoxTenTuiMauHotro.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenTuiMauHotro_MouseDown);
		listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			columnHeader_0
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(4, 4);
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(294, 123);
		listView1.TabIndex = 218;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		columnHeader_0.Text = "Tên thuốc";
		columnHeader_0.Width = 250;
		buttonThem.Location = new System.Drawing.Point(223, 178);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(75, 23);
		buttonThem.TabIndex = 219;
		buttonThem.Text = "Thêm";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		buttonXoa.Location = new System.Drawing.Point(223, 207);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(75, 23);
		buttonXoa.TabIndex = 220;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		buttonClose.Location = new System.Drawing.Point(223, 263);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(75, 26);
		buttonClose.TabIndex = 222;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonAppAll.ForeColor = System.Drawing.Color.DarkRed;
		buttonAppAll.Location = new System.Drawing.Point(4, 263);
		buttonAppAll.Name = "buttonAppAll";
		buttonAppAll.Size = new System.Drawing.Size(213, 26);
		buttonAppAll.TabIndex = 231;
		buttonAppAll.Text = "Áp dụng tên thuốc cho tất cả ac";
		buttonAppAll.UseVisualStyleBackColor = true;
		buttonAppAll.Click += new System.EventHandler(buttonAppAll_Click);
		label1.Location = new System.Drawing.Point(8, 212);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(210, 46);
		label1.TabIndex = 232;
		label1.Text = "Ăn thuốc khi bấm phím thì thiết lập trong phần <Nhồi thuốc> của bảng 1, ở đây không làm thêm phần đó.";
		textBoxGiay.Location = new System.Drawing.Point(255, 130);
		textBoxGiay.Name = "textBoxGiay";
		textBoxGiay.Size = new System.Drawing.Size(42, 20);
		textBoxGiay.TabIndex = 236;
		textBoxGiay.TextChanged += new System.EventHandler(textBoxGiay_TextChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(4, 135);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(257, 26);
		label2.TabIndex = 237;
		label2.Text = "Thời gian kiểm tra giữa 2 lần ăn thuốc (giây)\r\nNếu bị miss thì sẽ ăn lại, thường để khoảng 3 - 5 giây";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(302, 294);
		base.Controls.Add(textBoxGiay);
		base.Controls.Add(label2);
		base.Controls.Add(label1);
		base.Controls.Add(buttonAppAll);
		base.Controls.Add(buttonClose);
		base.Controls.Add(buttonXoa);
		base.Controls.Add(buttonThem);
		base.Controls.Add(listView1);
		base.Controls.Add(comboBoxTenTuiMauHotro);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormThuocTocdoDanh";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "THUOC HO TRO TOC DO DANH";
		base.Load += new System.EventHandler(FormThuocTocdoDanh_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
