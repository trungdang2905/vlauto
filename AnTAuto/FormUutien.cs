using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormUutien : Form
{
	private struct Struct19
	{
		public string string_0;

		public byte byte_0;
	}

	public static int int_0 = 0;

	public static string string_0 = null;

	private static int int_1 = 0;

	private static GStruct42 gstruct42_0 = default(GStruct42);

	private Struct19[] struct19_0 = new Struct19[5]
	{
		new Struct19
		{
			byte_0 = 0,
			string_0 = "Kim"
		},
		new Struct19
		{
			byte_0 = 1,
			string_0 = "Mộc"
		},
		new Struct19
		{
			byte_0 = 2,
			string_0 = "Thủy"
		},
		new Struct19
		{
			byte_0 = 3,
			string_0 = "Hỏa"
		},
		new Struct19
		{
			byte_0 = 4,
			string_0 = "Thổ"
		}
	};

	private Struct19[] struct19_1 = new Struct19[10]
	{
		new Struct19
		{
			byte_0 = 0,
			string_0 = "Thiếu Lâm"
		},
		new Struct19
		{
			byte_0 = 1,
			string_0 = "Thiên Vương"
		},
		new Struct19
		{
			byte_0 = 2,
			string_0 = "Đường Môn"
		},
		new Struct19
		{
			byte_0 = 3,
			string_0 = "Ngũ Độc"
		},
		new Struct19
		{
			byte_0 = 4,
			string_0 = "Nga My"
		},
		new Struct19
		{
			byte_0 = 5,
			string_0 = "Thúy Yên"
		},
		new Struct19
		{
			byte_0 = 6,
			string_0 = "Cái Bang"
		},
		new Struct19
		{
			byte_0 = 7,
			string_0 = "Thiên Nhẫn"
		},
		new Struct19
		{
			byte_0 = 8,
			string_0 = "Võ Đang"
		},
		new Struct19
		{
			byte_0 = 9,
			string_0 = "Côn Lôn"
		}
	};

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private Button buttonLen1;

	private Button buttonXuong1;

	private ColumnHeader columnHeader_1;

	private Button buttonUuTienMacdinh;

	private Button buttonClose;

	public FormUutien()
	{
		InitializeComponent();
	}

	private void FormUutien_Load(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			int_1 = int_0;
			gstruct42_0 = FormMain.gstruct42_0[num];
			for (int i = 0; i < gstruct42_0.int_88.Length; i++)
			{
				method_1(struct19_0[gstruct42_0.int_88[i]].string_0);
			}
			timer_0.Interval = 300;
			timer_0.Enabled = true;
			base.TopMost = true;
			base.Top = Cursor.Position.Y - base.Height - 10;
			base.Left = Cursor.Position.X - base.Width - 10;
			base.Text = "(" + struct19_0[Class32.smethod_28(gstruct42_0)].string_0 + ") " + Class10.smethod_1(gstruct42_0.string_20, 1);
		}
		else
		{
			int_0 = 0;
			Close();
		}
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int_0 = 0;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			Close();
		}
	}

	private void buttonLen1_Click(object sender, EventArgs e)
	{
		int num = method_0(listView1);
		if (num > 0)
		{
			int num2 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num2 >= 0)
			{
				int num3 = FormMain.gstruct42_0[num2].int_88[num];
				FormMain.gstruct42_0[num2].int_88[num] = FormMain.gstruct42_0[num2].int_88[num - 1];
				FormMain.gstruct42_0[num2].int_88[num - 1] = num3;
				Class47.smethod_11(FormMain.gstruct42_0[num2]);
				string text = listView1.Items[num].SubItems[1].Text;
				listView1.Items[num].SubItems[1].Text = listView1.Items[num - 1].SubItems[1].Text;
				listView1.Items[num - 1].SubItems[1].Text = text;
				listView1.Items[num - 1].Selected = true;
				listView1.Items[num - 1].Focused = true;
			}
			else
			{
				int_0 = 0;
				Close();
			}
		}
	}

	private void buttonXuong1_Click(object sender, EventArgs e)
	{
		int num = method_0(listView1);
		if (num >= 0 && num < listView1.Items.Count - 1)
		{
			int num2 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num2 >= 0)
			{
				int num3 = FormMain.gstruct42_0[num2].int_88[num];
				FormMain.gstruct42_0[num2].int_88[num] = FormMain.gstruct42_0[num2].int_88[num + 1];
				FormMain.gstruct42_0[num2].int_88[num + 1] = num3;
				Class47.smethod_11(FormMain.gstruct42_0[num2]);
				string text = listView1.Items[num].SubItems[1].Text;
				listView1.Items[num].SubItems[1].Text = listView1.Items[num + 1].SubItems[1].Text;
				listView1.Items[num + 1].SubItems[1].Text = text;
				listView1.Items[num + 1].Selected = true;
				listView1.Items[num + 1].Focused = true;
			}
			else
			{
				int_0 = 0;
				Close();
			}
		}
	}

	private int method_0(ListView listView_0)
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

	private void method_1(string string_1)
	{
		ListViewItem listViewItem = new ListViewItem((listView1.Items.Count + 1).ToString());
		listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, string_1));
		listView1.Items.Add(listViewItem);
	}

	private void buttonUuTienMacdinh_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			int_0 = 0;
			Close();
			return;
		}
		int int_ = Class32.smethod_28(FormMain.gstruct42_0[num]);
		FormMain.gstruct42_0[num].int_88 = Class47.smethod_12(int_);
		Class47.smethod_11(FormMain.gstruct42_0[num]);
		GStruct42 gStruct = FormMain.gstruct42_0[num];
		listView1.Items.Clear();
		for (int i = 0; i < gStruct.int_88.Length; i++)
		{
			method_1(struct19_0[gStruct.int_88[i]].string_0);
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormUutien));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		buttonLen1 = new System.Windows.Forms.Button();
		buttonXuong1 = new System.Windows.Forms.Button();
		buttonUuTienMacdinh = new System.Windows.Forms.Button();
		buttonClose = new System.Windows.Forms.Button();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
		{
			columnHeader_0,
			columnHeader_1
		});
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(2, 2);
		listView1.MultiSelect = false;
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(105, 110);
		listView1.TabIndex = 10;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "STT";
		columnHeader_0.Width = 30;
		columnHeader_1.Text = "Ngũ hành";
		buttonLen1.BackColor = System.Drawing.SystemColors.Control;
		buttonLen1.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		buttonLen1.ForeColor = System.Drawing.Color.Black;
		buttonLen1.Location = new System.Drawing.Point(113, 7);
		buttonLen1.Name = "buttonLen1";
		buttonLen1.Size = new System.Drawing.Size(59, 23);
		buttonLen1.TabIndex = 134;
		buttonLen1.Text = "Lên";
		buttonLen1.UseVisualStyleBackColor = false;
		buttonLen1.Click += new System.EventHandler(buttonLen1_Click);
		buttonXuong1.BackColor = System.Drawing.SystemColors.Control;
		buttonXuong1.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		buttonXuong1.ForeColor = System.Drawing.Color.Black;
		buttonXuong1.Location = new System.Drawing.Point(113, 34);
		buttonXuong1.Name = "buttonXuong1";
		buttonXuong1.Size = new System.Drawing.Size(59, 23);
		buttonXuong1.TabIndex = 135;
		buttonXuong1.Text = "Xuống";
		buttonXuong1.UseVisualStyleBackColor = false;
		buttonXuong1.Click += new System.EventHandler(buttonXuong1_Click);
		buttonUuTienMacdinh.BackColor = System.Drawing.SystemColors.Control;
		buttonUuTienMacdinh.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		buttonUuTienMacdinh.ForeColor = System.Drawing.Color.Black;
		buttonUuTienMacdinh.Location = new System.Drawing.Point(113, 66);
		buttonUuTienMacdinh.Name = "buttonUuTienMacdinh";
		buttonUuTienMacdinh.Size = new System.Drawing.Size(59, 23);
		buttonUuTienMacdinh.TabIndex = 138;
		buttonUuTienMacdinh.Text = "Mặc định";
		buttonUuTienMacdinh.UseVisualStyleBackColor = false;
		buttonUuTienMacdinh.Click += new System.EventHandler(buttonUuTienMacdinh_Click);
		buttonClose.BackColor = System.Drawing.SystemColors.Control;
		buttonClose.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		buttonClose.ForeColor = System.Drawing.Color.Black;
		buttonClose.Location = new System.Drawing.Point(113, 92);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(59, 23);
		buttonClose.TabIndex = 139;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = false;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(178, 124);
		base.Controls.Add(buttonClose);
		base.Controls.Add(buttonUuTienMacdinh);
		base.Controls.Add(buttonXuong1);
		base.Controls.Add(buttonLen1);
		base.Controls.Add(listView1);
		Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormUutien";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "UU TIEN";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormUutien_Load);
		ResumeLayout(performLayout: false);
	}
}
