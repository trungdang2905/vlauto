using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormRaovat : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static string[,] string_0 = new string[5, 2]
	{
		{
			"Thế giới",
			"CH_WORLD"
		},
		{
			"Thành thị",
			"CH_CITY"
		},
		{
			"Bang hội",
			"CH_TONG"
		},
		{
			"Phòng tán",
			"CH_CHATROOM"
		},
		{
			"Phụ cận",
			"CH_NEARBY"
		}
	};

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private ComboBox comboBoxRaoVat;

	private TextBox textBoxTimeRaoVat;

	private TextBox textBoxTextRaoVat;

	private CheckBox checkBoxRaoVat;

	private Label label1;

	private Label label2;

	private CheckBox checkBoxBomNoiluc;

	private CheckBox checkBoxRaoHinhanh;

	private GroupBox groupBoxRaovat;

	public static void smethod_0()
	{
		int int_ = int_1;
		int_1 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class71.smethod_3(FormMain.gstruct42_0, int_);
				if (Class11.bool_0 || num < 0 || FormMain.gstruct42_0[num].int_69[0] <= 0)
				{
					if (0 <= num)
					{
						FormMain.gstruct42_0[num].bool_55 = false;
					}
					return;
				}
				if (!flag)
				{
					if (FormMain.gstruct42_0[num].bool_55)
					{
						return;
					}
					FormMain.gstruct42_0[num].bool_55 = true;
					flag = true;
				}
				smethod_1(int_);
			}
			catch
			{
			}
			Thread.Sleep(600);
		}
	}

	private static void smethod_1(int int_2)
	{
		int num = 0;
		int int_3 = 0;
		byte[] array = new byte[4];
		GStruct42 gStruct = default(GStruct42);
		int[] array2 = new int[string_0.GetLength(0)];
		array2[0] = 80;
		array2[1] = 20;
		array2[2] = 10;
		long long_ = 0L;
		string text = null;
		uint uint_ = 38u;
		uint uint_2 = 13u;
		while (true)
		{
			Thread.Sleep(800);
			num--;
			if (num <= 0)
			{
				int num2 = Class71.smethod_3(FormMain.gstruct42_0, int_2);
				if (Class11.bool_0 || num2 < 0 || FormMain.gstruct42_0[num2].int_69[0] <= 0)
				{
					break;
				}
				gStruct = FormMain.gstruct42_0[num2];
				text = null;
				num = 3;
			}
			if (gStruct.string_8 == null || gStruct.string_8 == string.Empty)
			{
				continue;
			}
			long num3 = Class11.smethod_23(long_);
			if (num3 < 1200L || num3 < gStruct.int_69[2])
			{
				continue;
			}
			if (gStruct.int_69[4] > 0)
			{
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_11.uint_0, array, 4, ref int_3);
				uint num4 = BitConverter.ToUInt32(array, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num4 + Class47.gstruct43_13.uint_0, array, 4, ref int_3);
				uint num5 = BitConverter.ToUInt32(array, 0) * Class47.gstruct43_15.uint_0;
				Class20.ReadProcessMemory(gStruct.int_130, Class47.gstruct43_14.uint_0, array, 4, ref int_3);
				uint num6 = BitConverter.ToUInt32(array, 0);
				uint num7 = num6 + num5;
				Class20.ReadProcessMemory(gStruct.int_130, num7 + Class47.gstruct43_46.uint_0, array, 4, ref int_3);
				int num8 = BitConverter.ToInt32(array, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num7 + Class47.gstruct43_48.uint_0, array, 4, ref int_3);
				int num9 = BitConverter.ToInt32(array, 0);
				Class20.ReadProcessMemory(gStruct.int_130, num7 + Class47.gstruct43_48.uint_0 + 4, array, 4, ref int_3);
				int num10 = BitConverter.ToInt32(array, 0);
				if (num10 > num9 && num10 < 5000000)
				{
					num9 = num10;
				}
				int num11 = array2[gStruct.int_69[1]] * num9;
				if (num8 * 100 < num11 && Class29.smethod_8(gStruct, 1))
				{
					int i = 0;
					int num12 = num8;
					for (; i < 7; i++)
					{
						if (Class11.bool_0)
						{
							break;
						}
						Thread.Sleep(800);
						Class20.ReadProcessMemory(gStruct.int_130, num7 + Class47.gstruct43_46.uint_0, array, 4, ref int_3);
						num8 = BitConverter.ToInt32(array, 0);
						if (num11 <= num8 * 100 || num8 <= num12)
						{
							break;
						}
						num12 = num8;
					}
				}
			}
			if (gStruct.int_69[3] <= 0)
			{
				if (text == null || text == string.Empty)
				{
					text = gStruct.string_8.Replace("\n", string.Empty);
				}
				Class60.smethod_55(gStruct, "Chat('" + string_0[gStruct.int_69[1], 1] + "', '" + text + "')");
			}
			else
			{
				Class60.smethod_55(gStruct, "Focus([[commandline]])");
				Thread.Sleep(300);
				Class20.smethod_4(gStruct.uint_4, uint_);
				Thread.Sleep(100);
				Class20.smethod_4(gStruct.uint_4, uint_2);
			}
			long_ = Class11.smethod_22();
		}
	}

	public FormRaovat()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void FormRaovat_Load(object sender, EventArgs e)
	{
		for (int i = 0; i < string_0.GetLength(0); i++)
		{
			comboBoxRaoVat.Items.Add(string_0[i, 0]);
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (0 > num)
		{
			groupBoxRaovat.Enabled = false;
			textBoxTextRaoVat.Text = "Hãy chọn 1 ac trước rồi bấm nút Rao vặt để vào đây thiết lập";
		}
		else
		{
			GStruct42 gStruct = FormMain.gstruct42_0[num];
			textBoxTextRaoVat.Text = gStruct.string_8;
			checkBoxRaoVat.Checked = (gStruct.int_69[0] > 0);
			comboBoxRaoVat.Text = string_0[gStruct.int_69[1], 0];
			textBoxTimeRaoVat.Text = gStruct.int_69[2].ToString();
			checkBoxRaoHinhanh.Checked = (gStruct.int_69[3] > 0);
			checkBoxBomNoiluc.Checked = (gStruct.int_69[4] > 0);
			textBoxTextRaoVat.Enabled = (gStruct.int_69[3] <= 0);
			comboBoxRaoVat.Enabled = (gStruct.int_69[3] <= 0);
			groupBoxRaovat.Text = Class10.smethod_1(gStruct.string_20, 1);
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		bool_0 = false;
		int_0 = 0;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxRaoVat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_69[0] = Convert.ToByte(checkBoxRaoVat.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void comboBoxRaoVat_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxRaoVat.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (text == string_0[num2, 0])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		FormMain.gstruct42_0[num].int_69[1] = num2;
		Class47.smethod_11(FormMain.gstruct42_0[num]);
	}

	private void textBoxTimeRaoVat_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_69[2] = Class11.smethod_12(textBoxTimeRaoVat.Text);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void textBoxTextRaoVat_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].string_8 = textBoxTextRaoVat.Text;
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxRaoHinhanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_69[3] = Convert.ToByte(checkBoxRaoHinhanh.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
				textBoxTextRaoVat.Enabled = (FormMain.gstruct42_0[num].int_69[3] <= 0);
				comboBoxRaoVat.Enabled = (FormMain.gstruct42_0[num].int_69[3] <= 0);
			}
		}
	}

	private void checkBoxBomNoiluc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_69[4] = Convert.ToByte(checkBoxBomNoiluc.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormRaovat));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		buttonClose = new System.Windows.Forms.Button();
		comboBoxRaoVat = new System.Windows.Forms.ComboBox();
		textBoxTimeRaoVat = new System.Windows.Forms.TextBox();
		textBoxTextRaoVat = new System.Windows.Forms.TextBox();
		checkBoxRaoVat = new System.Windows.Forms.CheckBox();
		label1 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		checkBoxBomNoiluc = new System.Windows.Forms.CheckBox();
		checkBoxRaoHinhanh = new System.Windows.Forms.CheckBox();
		groupBoxRaovat = new System.Windows.Forms.GroupBox();
		groupBoxRaovat.SuspendLayout();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		buttonClose.BackColor = System.Drawing.SystemColors.Control;
		buttonClose.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		buttonClose.ForeColor = System.Drawing.Color.Black;
		buttonClose.Location = new System.Drawing.Point(193, 224);
		buttonClose.Name = "buttonClose";
		buttonClose.Size = new System.Drawing.Size(77, 26);
		buttonClose.TabIndex = 139;
		buttonClose.Text = "Đóng";
		buttonClose.UseVisualStyleBackColor = false;
		buttonClose.Click += new System.EventHandler(buttonClose_Click);
		comboBoxRaoVat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		comboBoxRaoVat.DropDownWidth = 80;
		comboBoxRaoVat.FormattingEnabled = true;
		comboBoxRaoVat.Location = new System.Drawing.Point(182, 95);
		comboBoxRaoVat.Name = "comboBoxRaoVat";
		comboBoxRaoVat.Size = new System.Drawing.Size(76, 21);
		comboBoxRaoVat.TabIndex = 212;
		comboBoxRaoVat.SelectedIndexChanged += new System.EventHandler(comboBoxRaoVat_SelectedIndexChanged);
		textBoxTimeRaoVat.Location = new System.Drawing.Point(182, 122);
		textBoxTimeRaoVat.Name = "textBoxTimeRaoVat";
		textBoxTimeRaoVat.Size = new System.Drawing.Size(76, 21);
		textBoxTimeRaoVat.TabIndex = 210;
		textBoxTimeRaoVat.Text = "30000";
		textBoxTimeRaoVat.TextChanged += new System.EventHandler(textBoxTimeRaoVat_TextChanged);
		textBoxTextRaoVat.BackColor = System.Drawing.Color.White;
		textBoxTextRaoVat.Location = new System.Drawing.Point(9, 25);
		textBoxTextRaoVat.Multiline = true;
		textBoxTextRaoVat.Name = "textBoxTextRaoVat";
		textBoxTextRaoVat.Size = new System.Drawing.Size(250, 64);
		textBoxTextRaoVat.TabIndex = 211;
		textBoxTextRaoVat.Text = ":@TËp trung MCQ nhanh";
		textBoxTextRaoVat.TextChanged += new System.EventHandler(textBoxTextRaoVat_TextChanged);
		checkBoxRaoVat.AutoSize = true;
		checkBoxRaoVat.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxRaoVat.Location = new System.Drawing.Point(78, 230);
		checkBoxRaoVat.Name = "checkBoxRaoVat";
		checkBoxRaoVat.Size = new System.Drawing.Size(101, 17);
		checkBoxRaoVat.TabIndex = 209;
		checkBoxRaoVat.Text = "Bắt đầu rao vặt";
		checkBoxRaoVat.UseVisualStyleBackColor = true;
		checkBoxRaoVat.CheckedChanged += new System.EventHandler(checkBoxRaoVat_CheckedChanged);
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(8, 125);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(167, 13);
		label1.TabIndex = 213;
		label1.Text = "Thời gian giữa 2 lần rao (mili giây)";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(8, 100);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(90, 13);
		label2.TabIndex = 214;
		label2.Text = "Chọn tầng số rao";
		checkBoxBomNoiluc.AutoSize = true;
		checkBoxBomNoiluc.Location = new System.Drawing.Point(11, 150);
		checkBoxBomNoiluc.Name = "checkBoxBomNoiluc";
		checkBoxBomNoiluc.Size = new System.Drawing.Size(96, 17);
		checkBoxBomNoiluc.TabIndex = 215;
		checkBoxBomNoiluc.Text = "Có bơm nội lực";
		checkBoxBomNoiluc.UseVisualStyleBackColor = true;
		checkBoxBomNoiluc.CheckedChanged += new System.EventHandler(checkBoxBomNoiluc_CheckedChanged);
		checkBoxRaoHinhanh.ForeColor = System.Drawing.Color.MediumBlue;
		checkBoxRaoHinhanh.Location = new System.Drawing.Point(11, 170);
		checkBoxRaoHinhanh.Name = "checkBoxRaoHinhanh";
		checkBoxRaoHinhanh.Size = new System.Drawing.Size(247, 34);
		checkBoxRaoHinhanh.TabIndex = 216;
		checkBoxRaoHinhanh.Text = "Rao vặt có hình ảnh (bạn phải rao trước trong game 1 lần, auto gửi phím enter để rao)";
		checkBoxRaoHinhanh.UseVisualStyleBackColor = true;
		checkBoxRaoHinhanh.CheckedChanged += new System.EventHandler(checkBoxRaoHinhanh_CheckedChanged);
		groupBoxRaovat.Controls.Add(checkBoxRaoHinhanh);
		groupBoxRaovat.Controls.Add(checkBoxBomNoiluc);
		groupBoxRaovat.Controls.Add(label2);
		groupBoxRaovat.Controls.Add(label1);
		groupBoxRaovat.Controls.Add(comboBoxRaoVat);
		groupBoxRaovat.Controls.Add(textBoxTimeRaoVat);
		groupBoxRaovat.Controls.Add(textBoxTextRaoVat);
		groupBoxRaovat.Location = new System.Drawing.Point(4, 2);
		groupBoxRaovat.Name = "groupBoxRaovat";
		groupBoxRaovat.Size = new System.Drawing.Size(266, 216);
		groupBoxRaovat.TabIndex = 217;
		groupBoxRaovat.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(282, 255);
		base.Controls.Add(groupBoxRaovat);
		base.Controls.Add(buttonClose);
		base.Controls.Add(checkBoxRaoVat);
		Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormRaovat";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "RAO VAT";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormRaovat_Load);
		groupBoxRaovat.ResumeLayout(performLayout: false);
		groupBoxRaovat.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
