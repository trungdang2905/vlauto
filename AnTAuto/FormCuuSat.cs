using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FormCuuSat : Form
{
	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ComboBox comboBoxThemAcc;

	private Button buttonThemAcc;

	private Button buttonXoaAcc;

	private CheckBox checkBoxCuusatTheoDs;

	private Timer timer_0;

	private GroupBox groupBox1;

	private Label label3;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public int int_1 = 0;

	public int int_2 = 0;

	public int int_3;

	public int int_4;

	private bool bool_1 = false;

	private static GStruct42 gstruct42_0 = default(GStruct42);

	private string[] string_0 = null;

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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormCuuSat));
		listView1 = new System.Windows.Forms.ListView();
		columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		comboBoxThemAcc = new System.Windows.Forms.ComboBox();
		buttonThemAcc = new System.Windows.Forms.Button();
		buttonXoaAcc = new System.Windows.Forms.Button();
		checkBoxCuusatTheoDs = new System.Windows.Forms.CheckBox();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		groupBox1 = new System.Windows.Forms.GroupBox();
		label3 = new System.Windows.Forms.Label();
		groupBox1.SuspendLayout();
		SuspendLayout();
		listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
		{
			columnHeader_0,
			columnHeader_1
		});
		listView1.ForeColor = System.Drawing.Color.DarkBlue;
		listView1.FullRowSelect = true;
		listView1.GridLines = true;
		listView1.HideSelection = false;
		listView1.Location = new System.Drawing.Point(8, 19);
		listView1.MultiSelect = false;
		listView1.Name = "listView1";
		listView1.Size = new System.Drawing.Size(224, 173);
		listView1.TabIndex = 2;
		listView1.UseCompatibleStateImageBehavior = false;
		listView1.View = System.Windows.Forms.View.Details;
		columnHeader_0.Text = "No";
		columnHeader_0.Width = 40;
		columnHeader_1.Text = "Tên nhân vật";
		columnHeader_1.Width = 160;
		comboBoxThemAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxThemAcc.DropDownWidth = 120;
		comboBoxThemAcc.ForeColor = System.Drawing.Color.DarkBlue;
		comboBoxThemAcc.FormattingEnabled = true;
		comboBoxThemAcc.Location = new System.Drawing.Point(6, 197);
		comboBoxThemAcc.Name = "comboBoxThemAcc";
		comboBoxThemAcc.Size = new System.Drawing.Size(126, 21);
		comboBoxThemAcc.TabIndex = 63;
		comboBoxThemAcc.DropDown += new System.EventHandler(comboBoxThemAcc_DropDown);
		buttonThemAcc.ForeColor = System.Drawing.Color.DarkBlue;
		buttonThemAcc.Location = new System.Drawing.Point(138, 196);
		buttonThemAcc.Name = "buttonThemAcc";
		buttonThemAcc.Size = new System.Drawing.Size(50, 23);
		buttonThemAcc.TabIndex = 64;
		buttonThemAcc.Text = "Thêm";
		buttonThemAcc.UseVisualStyleBackColor = true;
		buttonThemAcc.Click += new System.EventHandler(buttonThemAcc_Click);
		buttonXoaAcc.ForeColor = System.Drawing.Color.DarkBlue;
		buttonXoaAcc.Location = new System.Drawing.Point(190, 196);
		buttonXoaAcc.Name = "buttonXoaAcc";
		buttonXoaAcc.Size = new System.Drawing.Size(42, 23);
		buttonXoaAcc.TabIndex = 65;
		buttonXoaAcc.Text = "Xóa";
		buttonXoaAcc.UseVisualStyleBackColor = true;
		buttonXoaAcc.Click += new System.EventHandler(buttonXoaAcc_Click);
		checkBoxCuusatTheoDs.AutoSize = true;
		checkBoxCuusatTheoDs.BackColor = System.Drawing.SystemColors.Control;
		checkBoxCuusatTheoDs.ForeColor = System.Drawing.Color.Red;
		checkBoxCuusatTheoDs.Location = new System.Drawing.Point(2, 283);
		checkBoxCuusatTheoDs.Name = "checkBoxCuusatTheoDs";
		checkBoxCuusatTheoDs.Size = new System.Drawing.Size(228, 17);
		checkBoxCuusatTheoDs.TabIndex = 68;
		checkBoxCuusatTheoDs.Text = "Cừu sát theo danh sách ở trên (gặp là bụp)";
		checkBoxCuusatTheoDs.UseVisualStyleBackColor = false;
		checkBoxCuusatTheoDs.CheckedChanged += new System.EventHandler(checkBoxCuusatTheoDs_CheckedChanged);
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		groupBox1.Controls.Add(listView1);
		groupBox1.Controls.Add(comboBoxThemAcc);
		groupBox1.Controls.Add(buttonThemAcc);
		groupBox1.Controls.Add(buttonXoaAcc);
		groupBox1.Location = new System.Drawing.Point(2, 52);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(246, 227);
		groupBox1.TabIndex = 73;
		groupBox1.TabStop = false;
		groupBox1.Text = "Danh sách cừu sát";
		label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		label3.ForeColor = System.Drawing.Color.DarkRed;
		label3.Location = new System.Drawing.Point(2, 1);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(246, 45);
		label3.TabIndex = 77;
		label3.Text = "Lưu ý:  Danh sách cừu sát chỉ nên có trên dưới 5 ac thôi vì nếu càng nhiều thì sẽ làm % cpu tăng cao, dẫn đến lag và diss game.";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(252, 304);
		base.Controls.Add(label3);
		base.Controls.Add(checkBoxCuusatTheoDs);
		base.Controls.Add(groupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormCuuSat";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "CUU SAT";
		base.Load += new System.EventHandler(FormCuuSat_Load);
		groupBox1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public FormCuuSat()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void FormCuuSat_Load(object sender, EventArgs e)
	{
		try
		{
			if (int_1 > 0 && int_2 > 0)
			{
				int num = int_1 - base.Width - 2;
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
			int num3 = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num3 >= 0)
			{
				gstruct42_0 = FormMain.gstruct42_0[num3];
				checkBoxCuusatTheoDs.Checked = (gstruct42_0.int_117 > 0);
				listView1.Items.Clear();
				if (gstruct42_0.string_16 != null)
				{
					for (int i = 0; i < gstruct42_0.string_16.Length; i++)
					{
						if (gstruct42_0.string_16[i] != null && gstruct42_0.string_16[i] != string.Empty)
						{
							smethod_0(ref listView1, Class10.smethod_1(gstruct42_0.string_16[i], 1));
						}
					}
				}
				string str = Class10.smethod_1(gstruct42_0.string_20, 1);
				Text = "DS CUU SAT CUA [ " + str + " ]";
				groupBox1.Text = "Danh sách cừu sát của (" + str + ")";
				bool_1 = true;
				timer_0.Interval = 300;
				timer_0.Enabled = true;
				base.TopMost = true;
			}
			else
			{
				bool_0 = false;
			}
		}
		catch
		{
		}
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
		catch
		{
		}
		bool_0 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	public static void smethod_0(ref ListView listView_0, string string_1)
	{
		if (string_1 != null)
		{
			ListViewItem listViewItem = new ListViewItem((listView_0.Items.Count + 1).ToString());
			ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, string_1);
			listViewItem.SubItems.Add(item);
			listView_0.Items.Add(listViewItem);
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

	private void comboBoxThemAcc_DropDown(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			bool_0 = false;
			return;
		}
		bool_1 = false;
		gstruct42_0 = FormMain.gstruct42_0[num];
		comboBoxThemAcc.Items.Clear();
		for (int i = 1; i < 256; i++)
		{
			string text = Class86.smethod_21(gstruct42_0, i, 1);
			if (text == string.Empty)
			{
				continue;
			}
			bool flag = true;
			if (comboBoxThemAcc.Items.Count > 0)
			{
				for (int j = 0; j < comboBoxThemAcc.Items.Count; j++)
				{
					if (comboBoxThemAcc.Items[j].ToString() == text)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				comboBoxThemAcc.Items.Add(Class10.smethod_1(text, 1));
				Class11.smethod_24(ref string_0, text);
			}
		}
		comboBoxThemAcc.Items.Add(string.Empty);
		bool_1 = true;
	}

	private void buttonThemAcc_Click(object sender, EventArgs e)
	{
		if (!bool_1 || string_0 == null || comboBoxThemAcc.Text == "" || FormMain.gstruct42_0 == null || FormMain.gstruct42_0.Length == 0)
		{
			return;
		}
		if (listView1.Items.Count > 9)
		{
			FormTip.smethod_0("DANH SACH CHO PHEP", "Nhằm để tránh CPU quá cao gây lag, diss... nên danh sách cừu sát sẽ bị hạn chế ở mức tối đa là 10 acc.||Danh sách đề nghị tốt nhất chỉ nên chứa 1 - 3 acc.", 12000, 280, 110);
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			string text = comboBoxThemAcc.Text;
			if (listView1.Items.Count > 0)
			{
				for (int i = 0; i < listView1.Items.Count; i++)
				{
					if (text == listView1.Items[i].SubItems[1].Text)
					{
						comboBoxThemAcc.Items.Clear();
						comboBoxThemAcc.Text = "";
						return;
					}
				}
			}
			for (int i = 0; i < string_0.Length; i++)
			{
				if (text == Class10.smethod_1(string_0[i], 1))
				{
					Class11.smethod_24(ref FormMain.gstruct42_0[num].string_16, string_0[i]);
					smethod_0(ref listView1, text);
					comboBoxThemAcc.Items.Clear();
					comboBoxThemAcc.Text = "";
					break;
				}
			}
			if (listView1.Items.Count > 3)
			{
				buttonThemAcc.Enabled = false;
				comboBoxThemAcc.Enabled = false;
			}
		}
		else
		{
			bool_0 = false;
		}
	}

	private void buttonXoaAcc_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			int num2 = method_0(listView1);
			if (num2 < 0 || num2 > listView1.Items.Count - 1)
			{
				return;
			}
			string text = listView1.Items[num2].SubItems[1].Text;
			if (FormMain.gstruct42_0[num].string_16 != null)
			{
				for (int i = 0; i < FormMain.gstruct42_0[num].string_16.Length; i++)
				{
					if (text == Class10.smethod_1(FormMain.gstruct42_0[num].string_16[i], 1))
					{
						Class11.smethod_25(ref FormMain.gstruct42_0[num].string_16, FormMain.gstruct42_0[num].string_16[i]);
						break;
					}
				}
			}
			listView1.Items.RemoveAt(num2);
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
			}
			bool enabled = listView1.Items.Count < 4;
			buttonThemAcc.Enabled = enabled;
			comboBoxThemAcc.Enabled = enabled;
		}
		else
		{
			bool_0 = false;
		}
	}

	private void checkBoxCuusatTheoDs_CheckedChanged(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			FormMain.gstruct42_0[num].int_117 = Convert.ToByte(checkBoxCuusatTheoDs.Checked);
		}
		else
		{
			bool_0 = false;
		}
	}
}
