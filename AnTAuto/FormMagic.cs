using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormMagic : Form
{
	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private CheckBox checkBoxBuaXongRoidanh;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ComboBox comboBoxChieuthuc;

	private Button buttonThem;

	private Button buttonXoa;

	private ColumnHeader columnHeader_1;

	private Label label1;

	private Button buttonClose;

	private CheckBox checkBoxChiBuff;

	private Label label2;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static string string_0 = null;

	private static GStruct42 gstruct42_0 = default(GStruct42);

	private static GStruct32[] gstruct32_0 = new GStruct32[7]
	{
		new GStruct32
		{
			uint_0 = 73u,
			string_0 = "Vạn Độc Thực Tâm (Thời gian trúng độc)"
		},
		new GStruct32
		{
			uint_0 = 390u,
			string_0 = "Đoạn Cân Hủ Cốt (Âm Kháng tất cả)"
		},
		new GStruct32
		{
			uint_0 = 356u,
			string_0 = "Xuyên Y Phá Giáp (Âm Phòng thủ)"
		},
		new GStruct32
		{
			uint_0 = 72u,
			string_0 = "Xuyên Tâm Độc Thích (Âm Kháng độc)"
		},
		new GStruct32
		{
			uint_0 = 64u,
			string_0 = "Băng Lam Huyền Tinh (Âm Kháng băng)"
		},
		new GStruct32
		{
			uint_0 = 70u,
			string_0 = "Xích Diệm Thực Thiên (Âm Kháng hỏa)"
		},
		new GStruct32
		{
			uint_0 = 67u,
			string_0 = "Cửu Thiên Cuồng Lôi (Âm Kháng lôi)"
		}
	};

	private static GStruct32[] gstruct32_1 = new GStruct32[6]
	{
		new GStruct32
		{
			uint_0 = 391u,
			string_0 = "Tâm pháp Nhiếp Hồn Loạn Tâm (Chiến đấu)"
		},
		new GStruct32
		{
			uint_0 = 136u,
			string_0 = "Hỏa Liên Phần Hoa (Phản đòn)"
		},
		new GStruct32
		{
			uint_0 = 137u,
			string_0 = "Ảo Ảnh Phi Hồ (Tỉ lệ công kích chính xác)"
		},
		new GStruct32
		{
			uint_0 = 140u,
			string_0 = "Phi Hồng Vô Tích (Né tránh)"
		},
		new GStruct32
		{
			uint_0 = 364u,
			string_0 = "Bi Tô Thanh Phong (Thời gian phục hồi)"
		},
		new GStruct32
		{
			uint_0 = 143u,
			string_0 = "Lịch Ma Đoạt Hồn (Sát thương Vật lý ngoại công)"
		}
	};

	private static GStruct32[] gstruct32_2 = new GStruct32[6]
	{
		new GStruct32
		{
			uint_0 = 394u,
			string_0 = "Túy Tiên Tá Cốt (Phản đòn, làm chậm, choáng)"
		},
		new GStruct32
		{
			uint_0 = 392u,
			string_0 = "Thúc Phược Chú (Âm phản đòn tầm xa)"
		},
		new GStruct32
		{
			uint_0 = 174u,
			string_0 = "Kỷ Bán phù (Âm tốc độ di chuyển)"
		},
		new GStruct32
		{
			uint_0 = 393u,
			string_0 = "Bắc Minh Đáo Hải (Âm phục hồi Sinh lực, Nội lực)"
		},
		new GStruct32
		{
			uint_0 = 175u,
			string_0 = "Khi Hàn Ngạo Tuyết (Âm tốc độ đánh)"
		},
		new GStruct32
		{
			uint_0 = 90u,
			string_0 = "Mê Tung ảo ảnh (Thời gian làm chậm, choáng)"
		}
	};

	private static GStruct32[] gstruct32_3 = null;

	private static int int_1 = 0;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormMagic));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		checkBoxBuaXongRoidanh = new System.Windows.Forms.CheckBox();
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		comboBoxChieuthuc = new System.Windows.Forms.ComboBox();
		buttonThem = new System.Windows.Forms.Button();
		buttonXoa = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		buttonClose = new System.Windows.Forms.Button();
		checkBoxChiBuff = new System.Windows.Forms.CheckBox();
		label2 = new System.Windows.Forms.Label();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		checkBoxBuaXongRoidanh.AutoSize = true;
		checkBoxBuaXongRoidanh.Location = new System.Drawing.Point(7, 152);
		checkBoxBuaXongRoidanh.Name = "checkBoxBuaXongRoidanh";
		checkBoxBuaXongRoidanh.Size = new System.Drawing.Size(359, 17);
		checkBoxBuaXongRoidanh.TabIndex = 7;
		checkBoxBuaXongRoidanh.Text = "Chỉ buff bùa và đánh vào 1 đối tượng gần nhất, không buff diện rộng";
		checkBoxBuaXongRoidanh.UseVisualStyleBackColor = true;
		checkBoxBuaXongRoidanh.CheckedChanged += new System.EventHandler(checkBoxBuaXongRoidanh_CheckedChanged);
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
		{
			columnHeader_0,
			columnHeader_1
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(7, 12);
		listView1.MultiSelect = false;
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(365, 110);
		listView1.TabIndex = 10;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "Tên chiêu thức";
		columnHeader_0.Width = 270;
		columnHeader_1.Text = "Cấp";
		columnHeader_1.Width = 40;
		comboBoxChieuthuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxChieuthuc.DropDownWidth = 250;
		comboBoxChieuthuc.FormattingEnabled = true;
		comboBoxChieuthuc.Location = new System.Drawing.Point(7, 127);
		comboBoxChieuthuc.Name = "comboBoxChieuthuc";
		comboBoxChieuthuc.Size = new System.Drawing.Size(218, 21);
		comboBoxChieuthuc.TabIndex = 11;
		buttonThem.Location = new System.Drawing.Point(231, 126);
		buttonThem.Name = "buttonThem";
		buttonThem.Size = new System.Drawing.Size(76, 23);
		buttonThem.TabIndex = 12;
		buttonThem.Text = "Thêm";
		buttonThem.UseVisualStyleBackColor = true;
		buttonThem.Click += new System.EventHandler(buttonThem_Click);
		buttonXoa.Location = new System.Drawing.Point(313, 126);
		buttonXoa.Name = "buttonXoa";
		buttonXoa.Size = new System.Drawing.Size(59, 23);
		buttonXoa.TabIndex = 13;
		buttonXoa.Text = "Xóa";
		buttonXoa.UseVisualStyleBackColor = true;
		buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		label1.ForeColor = System.Drawing.Color.DarkRed;
		label1.Location = new System.Drawing.Point(27, 226);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(230, 27);
		label1.TabIndex = 14;
		label1.Text = "Lưu ý: Ac buff bùa các bạn không đưa vào danh sách loại trừ nhé";
		buttonClose.Location = new System.Drawing.Point(263, 221);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(109, 32);
		buttonClose.TabIndex = 15;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = true;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		checkBoxChiBuff.AutoSize = true;
		checkBoxChiBuff.Location = new System.Drawing.Point(7, 206);
		checkBoxChiBuff.Name = "checkBoxChiBuff";
		checkBoxChiBuff.Size = new System.Drawing.Size(165, 17);
		checkBoxChiBuff.TabIndex = 16;
		checkBoxChiBuff.Text = "Chỉ buff bùa chứ không đánh";
		checkBoxChiBuff.UseVisualStyleBackColor = true;
		checkBoxChiBuff.CheckedChanged += new System.EventHandler(checkBoxChiBuff_CheckedChanged);
		label2.ForeColor = System.Drawing.Color.DarkGreen;
		label2.Location = new System.Drawing.Point(27, 172);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(345, 27);
		label2.TabIndex = 17;
		label2.Text = "Buff và đánh vào 1 đối tượng gần nhất chứ không buff đánh vào nhiều đối thủ cùng lúc, do đó tốc độ buff đủ bùa sẽ nhanh hơn.";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(384, 260);
		base.Controls.Add(label2);
		base.Controls.Add(checkBoxChiBuff);
		base.Controls.Add(buttonClose);
		base.Controls.Add(label1);
		base.Controls.Add(buttonXoa);
		base.Controls.Add(buttonThem);
		base.Controls.Add(comboBoxChieuthuc);
		base.Controls.Add(listView1);
		base.Controls.Add(checkBoxBuaXongRoidanh);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormMagic";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Magic";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormMagic_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormMagic()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void FormMagic_Load(object sender, EventArgs e)
	{
		int_1 = int_0;
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0)
		{
			int_0 = 0;
			Close();
			return;
		}
		gstruct42_0 = FormMain.gstruct42_0[num];
		checkBoxBuaXongRoidanh.Checked = (gstruct42_0.int_5 > 0);
		checkBoxChiBuff.Checked = (gstruct42_0.int_6 > 0);
		if (string_0 == "NGUDOC")
		{
			gstruct32_3 = gstruct32_0;
		}
		else if (!(string_0 == "THIENNHAN"))
		{
			if (string_0 == "CONLON")
			{
				gstruct32_3 = gstruct32_2;
			}
		}
		else
		{
			gstruct32_3 = gstruct32_1;
		}
		if (gstruct32_3 != null)
		{
			string text = string.Empty;
			for (int i = 0; i < gstruct32_3.Length; i++)
			{
				gstruct32_3[i].int_0 = Class67.smethod_15(gstruct42_0, gstruct32_3[i].uint_0);
				if (gstruct32_3[i].int_0 > 0)
				{
					string text2 = gstruct32_3[i].string_0 + " (" + gstruct32_3[i].int_0 + ")";
					comboBoxChieuthuc.Items.Add(text2);
					if (text == string.Empty)
					{
						text = text2;
					}
				}
			}
			comboBoxChieuthuc.Text = text;
			if (gstruct42_0.int_3 != null)
			{
				int num2 = 0;
				for (int i = 0; i < gstruct42_0.int_3.GetLength(0); i++)
				{
					for (int j = 0; j < gstruct32_3.Length; j++)
					{
						if (gstruct42_0.int_3[i] == gstruct32_3[j].uint_0 && gstruct32_3[j].int_0 > 0)
						{
							method_0(gstruct32_3[j]);
							num2++;
							break;
						}
					}
					if (num2 > 3)
					{
						break;
					}
				}
				buttonThem.Enabled = (num2 < 4);
				buttonXoa.Enabled = (num2 > 0);
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
		base.Text = string_0 + " [" + Class10.smethod_1(gstruct42_0.string_20, 1) + "]";
	}

	private void method_0(GStruct32 gstruct32_4)
	{
		string[] array = new string[2]
		{
			gstruct32_4.string_0,
			gstruct32_4.int_0.ToString()
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
		listView1.Items.Add(listViewItem);
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num >= 0)
		{
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void checkBoxBuaXongRoidanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num < 0)
			{
				int_0 = 0;
				return;
			}
			FormMain.gstruct42_0[num].int_5 = Convert.ToByte(checkBoxBuaXongRoidanh.Checked);
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num < 0 || (FormMain.gstruct42_0[num].int_3 != null && FormMain.gstruct42_0[num].int_3.Length > 3))
		{
			return;
		}
		string text = comboBoxChieuthuc.Text;
		int num2 = -1;
		for (int i = 0; i < gstruct32_3.Length; i++)
		{
			if (Class11.smethod_2(text, gstruct32_3[i].string_0) == 0)
			{
				num2 = i;
				break;
			}
		}
		if (num2 < 0 || gstruct32_3[num2].int_0 <= 0)
		{
			return;
		}
		if (FormMain.gstruct42_0[num].int_3 != null)
		{
			for (int i = 0; i < FormMain.gstruct42_0[num].int_3.Length; i++)
			{
				if (FormMain.gstruct42_0[num].int_3[i] == gstruct32_3[num2].uint_0)
				{
					return;
				}
			}
		}
		Class11.smethod_32(ref FormMain.gstruct42_0[num].int_3, (int)gstruct32_3[num2].uint_0);
		method_0(gstruct32_3[num2]);
		Class47.smethod_11(FormMain.gstruct42_0[num]);
		buttonThem.Enabled = (FormMain.gstruct42_0[num].int_3 == null || FormMain.gstruct42_0[num].int_3.Length < 4);
		buttonXoa.Enabled = (FormMain.gstruct42_0[num].int_3 != null && FormMain.gstruct42_0[num].int_3.Length > 0);
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		int num = -1;
		string text = null;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				text = listView1.Items[i].SubItems[0].Text;
				num = i;
				break;
			}
		}
		if (num < 0 || text == null)
		{
			return;
		}
		listView1.Items.RemoveAt(num);
		if (listView1.Items.Count > 0)
		{
			int num2 = num;
			if (listView1.Items.Count <= num2)
			{
				num2 = listView1.Items.Count - 1;
			}
			listView1.Items[num2].Focused = true;
			listView1.Items[num2].Selected = true;
		}
		int num3 = Class71.smethod_3(FormMain.gstruct42_0, int_1);
		if (num3 < 0)
		{
			return;
		}
		if (FormMain.gstruct42_0[num3].int_3 != null)
		{
			for (int i = 0; i < gstruct32_3.Length; i++)
			{
				if (Class11.smethod_2(text, gstruct32_3[i].string_0) == 0)
				{
					Class11.smethod_33(ref FormMain.gstruct42_0[num3].int_3, (int)gstruct32_3[i].uint_0);
					break;
				}
			}
		}
		Class47.smethod_11(FormMain.gstruct42_0[num3]);
		buttonXoa.Enabled = (FormMain.gstruct42_0[num3].int_3 != null && FormMain.gstruct42_0[num3].int_3.Length > 0);
		buttonThem.Enabled = (FormMain.gstruct42_0[num3].int_3 == null || FormMain.gstruct42_0[num3].int_3.Length < 4);
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxChiBuff_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num < 0)
			{
				int_0 = 0;
				return;
			}
			FormMain.gstruct42_0[num].int_6 = Convert.ToByte(checkBoxChiBuff.Checked);
			Class47.smethod_11(FormMain.gstruct42_0[num]);
		}
	}
}
