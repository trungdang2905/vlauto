using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class FormLuomrac : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public static int int_5 = Class55.smethod_3("ThoigiantrePCD", 0, "100");

	private bool bool_1 = false;

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Label label1;

	private CheckBox checkBoxAccept;

	private Button buttonDong;

	private Button buttonPhichiendau;

	private CheckBox checkBoxBanTheoThuoctinh;

	private Label label2;

	private TextBox textBoxThoigianTre;

	public FormLuomrac()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		int_0 = 0;
		bool_0 = false;
	}

	private void FormLuomrac_Load(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num < 0)
		{
			Close();
			return;
		}
		FormMain.gstruct42_0[num].int_57 = 0;
		GStruct42 gStruct = FormMain.gstruct42_0[num];
		if (int_1 >= 0 && int_2 >= 0)
		{
			int num2 = int_1 - base.Width - 10;
			int num3 = int_2 - base.Height - 10;
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
		checkBoxAccept.Checked = (gStruct.int_57 > 0);
		checkBoxBanTheoThuoctinh.Checked = (gStruct.int_58 > 0);
		textBoxThoigianTre.Text = int_5.ToString();
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void checkBoxBanTheoThuoctinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_58 = Convert.ToByte(checkBoxBanTheoThuoctinh.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void checkBoxAccept_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
			if (num >= 0)
			{
				FormMain.gstruct42_0[num].int_57 = Convert.ToByte(checkBoxAccept.Checked);
				Class47.smethod_11(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void buttonPhichiendau_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class71.smethod_3(FormMain.gstruct42_0, int_0);
		if (num >= 0)
		{
			string text = Class10.smethod_1(FormMain.gstruct42_0[num].string_20, 1) + ": " + Class47.string_3 + "Khi làm phi chiến đấu, ac phải lưu rương khác map. " + Class47.string_3 + "Ví dụ làm ở Mạc Cao Quật thì không được lưu rương Thành đô, ở Sa mạc 1, 2, 3 thì không được lưu rương Lâm an..." + Class47.string_3 + "Sau khi làm phi chiến đấu, ac sẽ tự thoát game và bạn phải log lại. Bạn chắc chắn muốn làm phi chiến đấu cho ac ?";
			if (MessageBox.Show(text, FormMain.string_1, MessageBoxButtons.YesNo) != DialogResult.No)
			{
				Class53.smethod_28(FormMain.gstruct42_0[num]);
			}
		}
	}

	private void buttonDong_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void textBoxThoigianTre_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int_5 = Class11.smethod_12(textBoxThoigianTre.Text);
			Class55.smethod_10(Class47.string_0, "ThoigiantrePCD", int_5, "", 0);
		}
	}

	public static void smethod_0(int int_6)
	{
		try
		{
			smethod_1(int_6);
		}
		catch
		{
		}
	}

	private static void smethod_1(int int_6)
	{
		GStruct42 gStruct = default(GStruct42);
		int num = -1;
		int num2 = 0;
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		int num3 = -1;
		int num4 = 0;
		uint[] uint_ = null;
		string[] string_ = null;
		bool flag = false;
		long long_4 = 0L;
		long long_5 = 0L;
		uint[] array = null;
		uint[] array2 = null;
		int num5 = -1;
		long num6 = 0L;
		while (true)
		{
			Thread.Sleep(300);
			int num7 = Class71.smethod_3(FormMain.gstruct42_0, int_6);
			if (Class11.bool_0 || num7 < 0 || !FormMain.gstruct42_0[num7].bool_36 || FormMain.gstruct42_0[num7].int_26 <= 0 || FormMain.gstruct42_0[num7].int_56 <= 0 || FormMain.gstruct42_0[num7].int_57 <= 0 || FormMain.gstruct42_0[num7].int_33 <= 0)
			{
				break;
			}
			gStruct = FormMain.gstruct42_0[num7];
			if (!flag)
			{
				Class60.smethod_50(gStruct, "<color=yellow>Chay Rac: " + Class33.smethod_1(gStruct.int_33));
				flag = true;
			}
			if (gStruct.bool_21 || gStruct.int_125[0] > 0 || Class73.smethod_12(gStruct) > 0)
			{
				continue;
			}
			uint num8 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gStruct.int_130);
			uint num9 = Class20.smethod_30(num8 + Class47.gstruct43_13.uint_0, gStruct.int_130);
			uint num10 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gStruct.int_130);
			uint num11 = num10 + num9 * Class47.gstruct43_15.uint_0;
			int num12 = (int)Class20.smethod_30(num11 + Class47.gstruct43_55.uint_0, gStruct.int_130);
			int num13 = (int)Class20.smethod_30(num11 + Class47.gstruct43_50.uint_0, gStruct.int_130);
			int num14 = (int)Class20.smethod_30(Class47.gstruct43_27.uint_0, gStruct.int_130);
			uint[] array3 = new uint[2]
			{
				Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_58.uint_0, gStruct.int_130),
				Class20.smethod_30(num11 + Class47.gstruct43_57.uint_0 + Class47.gstruct43_59.uint_0, gStruct.int_130)
			};
			int num15 = Class73.smethod_40(gStruct);
			if (num13 == 0 || num12 == 0 || num14 == 0 || num12 == 10 || num12 == 21 || num15 <= 1)
			{
				continue;
			}
			if (Class20.smethod_30(num11 + Class47.gstruct43_44.uint_0, gStruct.int_130) == 0 && gStruct.bool_64 && Class11.smethod_23(long_) > 300L)
			{
				Class60.smethod_55(gStruct, "Switch([[horse]])");
				long_ = Class11.smethod_22();
			}
			if (Class11.smethod_23(long_3) > 300000L)
			{
				uint_ = null;
				string_ = new string[3]
				{
					"ThÇn Hµnh Phï",
					"Thæ ®Þa phï",
					"Håi thµnh phï"
				};
				long_3 = Class11.smethod_22();
			}
			if (gStruct.int_27 > 0 && !gStruct.bool_10 && Class11.smethod_23(long_4) > 15000L)
			{
				Class21.int_0 = int_6;
				new Thread(new Class21().method_1).Start();
				long_4 = Class11.smethod_22();
			}
			uint uint_2;
			int num19;
			long long_6;
			if (num14 == gStruct.int_33)
			{
				if (gStruct.int_38 > 0)
				{
					if (array != null)
					{
						uint num16 = Class20.smethod_30(Class47.gstruct43_123.uint_0, gStruct.int_130);
						uint num17 = num16 + array[0] * Class47.gstruct43_124.uint_0;
						int int_7 = 0;
						byte[] array4 = new byte[1];
						byte[] array5 = new byte[4];
						Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_135.uint_0, array4, 1, ref int_7);
						Class20.ReadProcessMemory(gStruct.int_130, num17 + Class47.gstruct43_134.uint_0, array5, 4, ref int_7);
						if (array4[0] == 0 || BitConverter.ToInt32(array5, 0) <= 0)
						{
							array = null;
						}
					}
					if (array == null)
					{
						array = Class51.smethod_0(gStruct, array3, bool_2: true, bool_3: false);
					}
					if (array != null)
					{
						uint[] array6 = new uint[2]
						{
							array[2],
							array[3]
						};
						long num18 = Class53.smethod_18(array3, array6);
						if (num18 <= gStruct.int_54 * gStruct.int_54)
						{
							if (num5 == array[0] && array2 != null && array2[0] == array[2] && array2[1] == array[3])
							{
								uint_2 = array[0];
								num19 = (int)array[4];
								long_6 = 0L;
								if (Class11.smethod_23(long_5) > 12000L)
								{
									goto IL_058f;
								}
								if (Class11.smethod_23(long_5) > 3000L)
								{
									string string_2 = Class73.smethod_20(gStruct);
									if (0 < Class11.smethod_2(string_2, "qu\u00b8 xa") || 0 < Class11.smethod_2(string_2, "o¶ng trèn"))
									{
										long_6 = Class11.smethod_22() - Class51.int_0 + 6000L;
										Class73.smethod_21(gStruct, "0K..");
										if (Class20.smethod_30(num11 + Class47.gstruct43_44.uint_0, gStruct.int_130) == 0)
										{
											Class60.smethod_55(gStruct, "Switch([[sit]])");
										}
										goto IL_058f;
									}
								}
							}
							else
							{
								num5 = (int)array[0];
								array2 = new uint[2]
								{
									array[2],
									array[3]
								};
								long_5 = Class11.smethod_22();
							}
							if (num18 > 40000L && gStruct.int_56 <= 0)
							{
								Class60.smethod_61(gStruct, array6);
								Thread.Sleep(150);
							}
							Class60.smethod_46(gStruct, array[0]);
							Thread.Sleep(150);
						}
					}
				}
				goto IL_0618;
			}
			Class53.smethod_8(gStruct, "Sai map (toa do chay khong phai cua map nay) !");
			goto IL_08c4;
			IL_071c:
			uint[] array7;
			if (gStruct.uint_0 != null)
			{
				int length = gStruct.uint_0.GetLength(0);
				if (num < 0 || num2 == 0)
				{
					num = 0;
					if (length > 1)
					{
						num = Class53.smethod_20(gStruct.uint_0, array3);
						if (num < 0)
						{
							num = 0;
						}
					}
					num2 = 1;
				}
				array7 = new uint[2]
				{
					gStruct.uint_0[num, 0],
					gStruct.uint_0[num, 1]
				};
				long num20 = Class53.smethod_18(array3, array7);
				if (num20 > 600000L)
				{
					if (!Class12.smethod_4(gStruct) || Class11.smethod_23(long_2) > 10000L)
					{
						Class12.smethod_1(gStruct, array7);
						long_2 = Class11.smethod_22();
					}
					continue;
				}
				if (num20 > 16000L)
				{
					Class60.smethod_61(gStruct, array7);
					Thread.Sleep(100);
					continue;
				}
				if (length > 1)
				{
					num += num2;
					if (gStruct.int_30 > 0)
					{
						if (num < 0 || length <= num)
						{
							num = 0;
						}
						num2 = 1;
					}
					else if (num < 0)
					{
						num = 0;
						num2 = 1;
						if (length > 1)
						{
							num++;
						}
					}
					else if (length <= num)
					{
						num = length - 1;
						num2 = -1;
						if (length > 1)
						{
							num--;
						}
					}
				}
			}
			goto IL_08c4;
			IL_058f:
			Class51.smethod_4(ref gStruct.gstruct34_0, uint_2, num19, long_6);
			num5 = -1;
			array = null;
			long_5 = Class11.smethod_22();
			goto IL_0618;
			IL_08c4:
			int num21 = (int)Class20.smethod_30(num11 + Class47.gstruct43_43.uint_0, gStruct.int_130);
			if (num21 > 0)
			{
				continue;
			}
			int num22 = Class69.smethod_2(gStruct);
			if (num3 != num22)
			{
				if (gStruct.int_58 <= 0)
				{
					smethod_2(gStruct, ref uint_, ref string_);
				}
				else
				{
					Class6.smethod_4(gStruct);
				}
				num3 = Class69.smethod_2(gStruct);
			}
			continue;
			IL_0618:
			if (num6 > 0L && Class11.smethod_23(num6) < 1000L)
			{
				goto IL_071c;
			}
			uint[] array8 = null;
			long num23 = 0L;
			array7 = null;
			array8 = Class53.smethod_26(gStruct, ref num4);
			if (array8 != null)
			{
				num6 = 0L;
				array7 = array8;
				num23 = Class53.smethod_18(array3, array8);
				if (num23 >= 8000L)
				{
					if (num23 >= 22500L && num23 >= gStruct.int_68[1] * gStruct.int_68[1])
					{
						if (num23 >= 360000L)
						{
							if (num23 >= 1200000L)
							{
								goto IL_071c;
							}
							if (Class11.smethod_23(long_2) > 3000L)
							{
								Class12.smethod_1(gStruct, array8);
								long_2 = Class11.smethod_22();
							}
						}
						else
						{
							Class12.smethod_3(gStruct, bool_0: false);
							Class60.smethod_61(gStruct, array8);
							Thread.Sleep(100);
						}
					}
					else
					{
						Class60.smethod_61(gStruct, array8);
						Thread.Sleep(100);
					}
				}
			}
			else
			{
				num6 = Class11.smethod_22();
			}
			goto IL_08c4;
		}
	}

	private static void smethod_2(GStruct42 gstruct42_0, ref uint[] uint_0, ref string[] string_0)
	{
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[80];
		uint num = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130) + Class47.gstruct43_94.uint_0;
		uint num2 = Class20.smethod_30(Class47.gstruct43_102.uint_0, gstruct42_0.int_130);
		byte[] array4 = new byte[4];
		int int_2 = 0;
		int num3 = Class69.smethod_2(gstruct42_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class47.int_1 && (0 >= num3 || num3 > num4); num5++)
		{
			uint num6 = num2 + num5 * Class47.gstruct43_103.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_103.uint_0 - 4, array4, 4, ref int_2);
			if (BitConverter.ToInt32(array4, 0) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array4, 1, ref int_2);
			if (array4[0] == 0)
			{
				continue;
			}
			uint num7 = Class69.smethod_0(gstruct42_0, num5);
			if (num7 == 0)
			{
				continue;
			}
			num4++;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_117.uint_0, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_105.uint_0, array2, 4, ref int_);
			int num8 = BitConverter.ToInt32(array2, 0);
			if (num8 > 3)
			{
				continue;
			}
			Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_106.uint_0, array2, 4, ref int_);
			int num9 = BitConverter.ToInt32(array2, 0);
			if (num9 == 1 || num9 == 4)
			{
				continue;
			}
			if (uint_0 != null)
			{
				bool flag = false;
				for (int i = 0; i < uint_0.Length; i++)
				{
					if (num5 == uint_0[i])
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
			}
			if (string_0 != null)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array3, array3.Length, ref int_);
				string string_ = Class10.smethod_3(array3).ToLower();
				bool flag = false;
				for (int i = 0; i < string_0.Length; i++)
				{
					if (Class11.smethod_2(string_, string_0[i].ToLower()) == 0)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
			}
			uint num10 = Class20.smethod_30(num + num7 * 20 + Class47.gstruct43_97.uint_0 - 8, gstruct42_0.int_130);
			if ((int)num7 <= 0 || num10 != 3)
			{
				continue;
			}
			uint num11 = Class20.smethod_30(Class47.gstruct43_11.uint_0, gstruct42_0.int_130);
			uint num12 = Class20.smethod_30(num11 + Class47.gstruct43_13.uint_0, gstruct42_0.int_130);
			uint num13 = Class20.smethod_30(Class47.gstruct43_14.uint_0, gstruct42_0.int_130);
			uint num14 = num13 + num12 * Class47.gstruct43_15.uint_0;
			Class60.smethod_33(gstruct42_0, (int)num5);
			int num15 = 0;
			while (!Class11.bool_0 && Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array, 1, ref int_) && array[0] != 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num14 + Class47.gstruct43_43.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) > 0)
				{
					break;
				}
				num15++;
				Thread.Sleep(100);
				if (num15 > 15)
				{
					string string_2 = Class73.smethod_22(gstruct42_0);
					if (Class11.smethod_2(string_2, "hÊt b¹i") > 0)
					{
						Class20.ReadProcessMemory(gstruct42_0.int_130, num6 + Class47.gstruct43_104.uint_0, array3, array3.Length, ref int_);
						string string_ = Class10.smethod_3(array3);
						Class11.smethod_24(ref string_0, string_);
						Class11.smethod_35(ref uint_0, num5);
						Class73.smethod_23(gstruct42_0, "0K..");
						break;
					}
				}
			}
		}
		Thread.Sleep(100);
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormLuomrac));
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		label1 = new System.Windows.Forms.Label();
		checkBoxAccept = new System.Windows.Forms.CheckBox();
		buttonDong = new System.Windows.Forms.Button();
		buttonPhichiendau = new System.Windows.Forms.Button();
		checkBoxBanTheoThuoctinh = new System.Windows.Forms.CheckBox();
		label2 = new System.Windows.Forms.Label();
		textBoxThoigianTre = new System.Windows.Forms.TextBox();
		SuspendLayout();
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		label1.Location = new System.Drawing.Point(12, 32);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(337, 204);
		label1.TabIndex = 0;
		label1.Text = componentResourceManager.GetString("label1.Text");
		checkBoxAccept.AutoSize = true;
		checkBoxAccept.ForeColor = System.Drawing.Color.DarkRed;
		checkBoxAccept.Location = new System.Drawing.Point(15, 248);
		checkBoxAccept.Name = "checkBoxAccept";
		checkBoxAccept.Size = new System.Drawing.Size(92, 17);
		checkBoxAccept.TabIndex = 1;
		checkBoxAccept.Text = "Tôi đã hiểu rõ";
		checkBoxAccept.UseVisualStyleBackColor = true;
		checkBoxAccept.CheckedChanged += new System.EventHandler(checkBoxAccept_CheckedChanged);
		buttonDong.Location = new System.Drawing.Point(259, 242);
		buttonDong.Name = "buttonDong";
		buttonDong.Size = new System.Drawing.Size(90, 26);
		buttonDong.TabIndex = 2;
		buttonDong.Text = "Đóng";
		buttonDong.UseVisualStyleBackColor = true;
		buttonDong.Click += new System.EventHandler(buttonDong_Click);
		buttonPhichiendau.Location = new System.Drawing.Point(79, 77);
		buttonPhichiendau.Name = "buttonPhichiendau";
		buttonPhichiendau.Size = new System.Drawing.Size(118, 23);
		buttonPhichiendau.TabIndex = 3;
		buttonPhichiendau.Text = "Làm phi chiến đấu";
		buttonPhichiendau.UseVisualStyleBackColor = true;
		buttonPhichiendau.Click += new System.EventHandler(buttonPhichiendau_Click);
		checkBoxBanTheoThuoctinh.AutoSize = true;
		checkBoxBanTheoThuoctinh.Location = new System.Drawing.Point(15, 9);
		checkBoxBanTheoThuoctinh.Name = "checkBoxBanTheoThuoctinh";
		checkBoxBanTheoThuoctinh.Size = new System.Drawing.Size(234, 17);
		checkBoxBanTheoThuoctinh.TabIndex = 4;
		checkBoxBanTheoThuoctinh.Text = "Bán rác theo bảng thuộc tính Lọc vật phẩm";
		checkBoxBanTheoThuoctinh.UseVisualStyleBackColor = true;
		checkBoxBanTheoThuoctinh.CheckedChanged += new System.EventHandler(checkBoxBanTheoThuoctinh_CheckedChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(203, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(91, 13);
		label2.TabIndex = 5;
		label2.Text = "Thời gian trễ (ms):";
		textBoxThoigianTre.Location = new System.Drawing.Point(292, 79);
		textBoxThoigianTre.Name = "textBoxThoigianTre";
		textBoxThoigianTre.Size = new System.Drawing.Size(46, 20);
		textBoxThoigianTre.TabIndex = 6;
		textBoxThoigianTre.TextChanged += new System.EventHandler(textBoxThoigianTre_TextChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(361, 279);
		base.Controls.Add(textBoxThoigianTre);
		base.Controls.Add(label2);
		base.Controls.Add(checkBoxBanTheoThuoctinh);
		base.Controls.Add(buttonPhichiendau);
		base.Controls.Add(buttonDong);
		base.Controls.Add(checkBoxAccept);
		base.Controls.Add(label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormLuomrac";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		Text = "LUOM RAC PHI SHOP";
		base.Load += new System.EventHandler(FormLuomrac_Load);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
