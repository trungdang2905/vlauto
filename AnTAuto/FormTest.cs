using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

public class FormTest : Form
{
	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static GStruct42 gstruct42_0 = default(GStruct42);

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	private static string string_0 = Class55.smethod_6("fCryptss", 0);

	private static string string_1 = Class11.smethod_16(Class55.smethod_6("FindString", 0));

	private static string string_2 = Class55.smethod_6("Folder", 0, Class47.string_4);

	private static string string_3 = null;

	private static string string_4 = null;

	private static byte byte_0 = 0;

	private static string string_5 = Class55.smethod_6("FindResult", 0);

	private static string string_6 = string.Empty;

	public static int int_4 = 0;

	private static uint[,] uint_0 = new uint[19, 2]
	{
		{
			54446u,
			96424u
		},
		{
			54681u,
			96661u
		},
		{
			55085u,
			96887u
		},
		{
			55103u,
			97310u
		},
		{
			55005u,
			97661u
		},
		{
			54841u,
			97972u
		},
		{
			54676u,
			98317u
		},
		{
			54556u,
			98648u
		},
		{
			54416u,
			98988u
		},
		{
			54311u,
			99221u
		},
		{
			54098u,
			99539u
		},
		{
			53798u,
			99835u
		},
		{
			53613u,
			100034u
		},
		{
			53441u,
			100244u
		},
		{
			53162u,
			100483u
		},
		{
			52967u,
			100671u
		},
		{
			52780u,
			100846u
		},
		{
			52545u,
			101011u
		},
		{
			52280u,
			101108u
		}
	};

	private static int int_5 = 0;

	private static string string_7 = null;

	private static string string_8 = null;

	private static string string_9 = null;

	private static string string_10 = null;

	private IContainer icontainer_0 = null;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private CheckBox checkBoxPhimTat;

	private Button buttonLayToado;

	private TextBox textBoxNPCObjectInfo;

	private TabPage tabPage2;

	private System.Windows.Forms.Timer timer_0;

	private GroupBox groupBox1;

	private Button buttonCopy;

	private Label label4;

	private Label label1;

	private Label label3;

	private TextBox textBoxTdy;

	private Label label2;

	private TextBox textBoxTdx;

	private TextBox textBoxID;

	private TextBox textBoxTextSelect;

	private TextBox textBoxIndex;

	private Button buttonClear;

	private Button buttonTdSingle;

	private Button buttonCopyDefine;

	private Button buttonCopyNPCObjGannhat;

	private Button buttonLamMap;

	private Button buttonTenNPCgannhat;

	private Button buttonNPCObjectGannhat;

	private Button buttonGetIndexInfo;

	private Button buttonGetAllNPCObject;

	private Button buttonRunPath;

	private Button buttonFlagStick;

	private Button buttonXemMaloiVAuto;

	private Button buttonXemMaloi;

	private Button buttonDialogGetText;

	private Button buttonTitleMenu;

	private Button buttonGetChanelAllTop;

	private GroupBox groupBox2;

	private Button buttonMoThumuc;

	private Button buttonMaHoa;

	private Button buttonFileMahoa;

	private TextBox textBoxMaHoa2;

	private TextBox textBoxFileMahoa;

	private Label label5;

	private GroupBox groupBox3;

	private TextBox textBoxSum1;

	private Button buttonSum2;

	private Button buttonSum1;

	private TextBox textBoxSum2;

	private Label labelKetQuaSum;

	private TextBox textBoxKetQuaSum2;

	private TextBox textBoxKetQuaSum1;

	private TabPage tabPage3;

	private Label label10;

	private Label label9;

	private Label label8;

	private ComboBox comboBoxFind;

	private Button buttonXoaNhatky;

	private Button buttonStopFind;

	private TextBox textBoxTep;

	private Button buttonBatdau;

	private RichTextBox richTextBoxResult;

	private Button buttonDelete;

	private Button buttonPaste;

	private Button buttonBrowss;

	private Label label7;

	private TextBox textBoxFolder;

	private Label label6;

	private TabPage tabPage4;

	private Button buttonBatdautaoPHLT;

	private Label label12;

	private TextBox textBoxPHLT;

	private Label label11;

	private Button buttonCreateTK;

	private TextBox textBoxCountStart;

	private Button buttonOpenFile;

	private TextBox textBoxFile;

	private Button buttonPaste2;

	private TextBox textBoxThoigianGiancach;

	private Label label13;

	private TextBox textBoxTk;

	private Label label14;

	private Button buttonTenTabKTC;

	private Button buttonSortcutSkill;

	public FormTest()
	{
		bool_0 = true;
		InitializeComponent();
	}

	private void FormTest_Load(object sender, EventArgs e)
	{
		this.method_4("TEST [" + Class10.smethod_1(gstruct42_0.string_20, 1) + "]");
		base.TopMost = true;
		if (int_0 > 0 && int_1 > 0)
		{
			int num = int_0 - base.Width;
			int num2 = int_1;
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
		string_3 = smethod_0(string_0);
		textBoxFileMahoa.Text = string_0;
		textBoxMaHoa2.Text = string_3;
		if (string_1 != null && string_1 != string.Empty)
		{
			string[] array = string_1.Split('|');
			for (int i = 0; i < array.Length; i++)
			{
				comboBoxFind.Items.Add(array[i]);
			}
			comboBoxFind.Text = array[0];
			string_1 = array[0];
		}
		textBoxFolder.Text = string_2;
		richTextBoxResult.Text = string_5;
		buttonStopFind.Enabled = false;
		checkBoxPhimTat.Checked = (FormMain.int_61 > 0);
		Thread.Sleep(100);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		string_1 = null;
		for (int i = 0; i < comboBoxFind.Items.Count; i++)
		{
			if (string_1 != null)
			{
				string_1 += "|";
			}
			string_1 += comboBoxFind.Items[i].ToString();
		}
		Class55.smethod_10(Class47.string_0, "FindString", Class11.smethod_17(string_1), "", 0);
		Class55.smethod_10(Class47.string_0, "Folder", string_2, "", 0);
		Class55.smethod_10(Class47.string_0, "FindResult", string_5, "", 0);
		bool_0 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (GClass0.int_1 == 3200)
		{
			GStruct12 gstruct12_ = default(GStruct12);
			if (!Class20.GetWindowRect(Class66.gstruct42_0.uint_4, ref gstruct12_))
			{
				return;
			}
			int num = Cursor.Position.X - gstruct12_.int_0;
			int num2 = Cursor.Position.Y - gstruct12_.int_1 - 22;
			method_0("(" + num + ", " + num2 + ")");
			GClass0.int_1 = 0;
		}
		if (int_4 == 32)
		{
			method_1();
			int_4 = 0;
		}
		if (bool_1)
		{
			base.Text = "TEST [" + Class10.smethod_1(gstruct42_0.string_20, 1) + "]";
			bool_1 = false;
		}
		if (int_5 > 1)
		{
			buttonMaHoa.Enabled = true;
			int_5 = 0;
		}
		if (string_4 != null)
		{
			textBoxTep.Text = string_4;
			string_4 = null;
		}
		if (string_6 != string_5)
		{
			string_6 = string_5;
			richTextBoxResult.Text = string_5;
		}
		if (byte_0 > 1)
		{
			timer_0.Interval = 300;
			buttonBatdau.Enabled = true;
			buttonStopFind.Enabled = false;
			textBoxFolder.Enabled = true;
			buttonBrowss.Enabled = true;
			byte_0 = 0;
		}
	}

	private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			if (checkBoxPhimTat.Checked)
			{
				GClass0.smethod_0();
			}
			else
			{
				GClass0.smethod_1();
			}
		}
	}

	private void method_0(string string_11, bool bool_2 = true, bool bool_3 = true)
	{
		string text = textBoxNPCObjectInfo.Text;
		if (bool_2 && !(text == "") && text.Length <= 10000000)
		{
			text = text.Remove(0, text.Length - 1);
			if (bool_3 && text != "\n")
			{
				string_11 = Class47.string_3 + string_11;
			}
			textBoxNPCObjectInfo.AppendText(string_11);
			textBoxNPCObjectInfo.ScrollToCaret();
		}
		else
		{
			textBoxNPCObjectInfo.Text = string_11;
		}
	}

	private void method_1()
	{
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			uint[] array = Class32.smethod_29(gstruct42_0);
			int num = Class11.smethod_12(textBoxIndex.Text);
			string text = ". {" + array[0].ToString() + "," + array[1].ToString() + "}";
			if (Class11.smethod_2(textBoxNPCObjectInfo.Text, text) < 0)
			{
				method_0(num.ToString() + text);
				textBoxIndex.Text = (num + 1).ToString();
			}
		}
	}

	private void buttonLayToado_Click(object sender, EventArgs e)
	{
		method_1();
	}

	private void buttonClear_Click(object sender, EventArgs e)
	{
		textBoxNPCObjectInfo.Text = "";
		textBoxIndex.Text = "0";
	}

	private void buttonCopyDefine_Click(object sender, EventArgs e)
	{
		string text = textBoxNPCObjectInfo.Text;
		if (text == "")
		{
			return;
		}
		text = text.Replace('\n', '\u0001').Replace('\r', '\u0001');
		string[] array = text.Split('\u0001');
		text = "";
		int num = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == "")
			{
				continue;
			}
			int num2 = Class11.smethod_2(array[i], "{");
			int num3 = Class11.smethod_2(array[i], "}");
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num3 <= num2)
			{
				num3 = array[i].Length;
			}
			try
			{
				array[i] = array[i].Substring(num2 + 1, num3 - num2 - 1).Replace(" ", "").Replace("\t", "");
			}
			catch
			{
				continue;
			}
			if (array[i] == "")
			{
				continue;
			}
			string[] array2 = array[i].Split(',');
			string text2 = "";
			for (int j = 0; j < array2.Length; j++)
			{
				if (text2 != "")
				{
					text2 += " , ";
				}
				text2 += array2[j];
			}
			if (text != "")
			{
				text += Class47.string_3;
			}
			string text3 = text;
			text = text3 + "\t\t\t{ " + text2 + " },\t //" + num.ToString();
			num++;
		}
		string text4 = "";
		string text5 = "";
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			int num4 = Class33.smethod_0(gstruct42_0);
			text4 = num4.ToString();
			text5 = "\t/* MapID " + text4 + ": " + Class33.smethod_1(num4) + " */";
		}
		text = "private static uint[,] tbMapID_" + text4 + " = new uint[,]" + text5 + Class47.string_3 + "\t\t{" + Class47.string_3 + text + Class47.string_3 + "\t\t};";
		Class47.smethod_23("object_npc_info.txt", text, bool_2: true, "Courier", 12, 870, 425, 200, 280);
		try
		{
			Clipboard.SetText(text);
		}
		catch
		{
		}
	}

	private void buttonTdSingle_Click(object sender, EventArgs e)
	{
		string text = textBoxNPCObjectInfo.Text;
		if (text != "")
		{
			Clipboard.SetText(text);
		}
	}

	private void buttonGetIndexInfo_Click(object sender, EventArgs e)
	{
		if (Class20.smethod_52(gstruct42_0.process_0))
		{
			return;
		}
		int num = 0;
		string text = null;
		int num2 = Class76.smethod_1(gstruct42_0);
		if (num2 < 0)
		{
			return;
		}
		if (num2 >= 1)
		{
			num = Class76.Class78.smethod_0(gstruct42_0);
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					if (text != null)
					{
						text += Class47.string_3;
					}
					text += Class76.smethod_3(gstruct42_0, i, 1);
				}
			}
		}
		num = Class76.Class77.smethod_0(gstruct42_0);
		if (num2 != 1 && num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				if (text != null)
				{
					text += Class47.string_3;
				}
				text += Class76.smethod_3(gstruct42_0, i, 0);
			}
		}
		if (text != null)
		{
			textBoxNPCObjectInfo.Text = text;
		}
	}

	private void buttonLamMap_Click(object sender, EventArgs e)
	{
		string text = textBoxNPCObjectInfo.Text;
		if (text == "")
		{
			return;
		}
		int num = 0;
		string text2 = "";
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			num = Class33.smethod_0(gstruct42_0);
			text2 = Class33.smethod_1(num, bool_0: true);
		}
		text = text.Replace('\n', '\u0001').Replace('\r', '\u0001');
		string[] array = text.Split('\u0001');
		int num2 = 0;
		int num3 = array.Length;
		text = "//" + num.ToString() + ": " + text2 + Class47.string_3;
		for (int i = 0; i < num3; i++)
		{
			if (!(array[i] == ""))
			{
				string[] array2 = array[i].Split('.');
				if (text != "")
				{
					text += Class47.string_3;
				}
				text += num2.ToString();
				if (num2 < num3 - 1)
				{
					text = text + ", " + (num2 + 1).ToString();
				}
				for (int j = 1; j < array2.Length; j++)
				{
					text = text + "|" + array2[j].Replace("{", "").Replace("}", "");
				}
				num2++;
			}
		}
		Class11.smethod_8(Class47.string_12);
		Class47.smethod_23(Class47.string_12 + "\\" + num.ToString() + "_tmp.txt", text, bool_2: true, "Courier", 12, 870, 425, 200, 280);
		try
		{
			Clipboard.SetText(text);
		}
		catch
		{
		}
	}

	private void buttonCopyNPCObjGannhat_Click(object sender, EventArgs e)
	{
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			string text = Class60.smethod_120(gstruct42_0, 2).Trim();
			if (text != "")
			{
				Clipboard.SetText(text);
			}
		}
	}

	private void buttonGetAllNPCObject_Click(object sender, EventArgs e)
	{
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			string str = Class60.smethod_119(gstruct42_0);
			method_0(". " + str, bool_2: true, bool_3: false);
		}
	}

	private void buttonNPCObjectGannhat_Click(object sender, EventArgs e)
	{
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			string text = Class60.smethod_120(gstruct42_0);
			string[] array = text.Split('|');
			if (array.Length >= 4)
			{
				string text2 = Class10.smethod_1(array[1].Replace(" ", ""), 1);
				text = "public static NPCTHON ID" + Class33.smethod_0(gstruct42_0) + "_NPC_" + text2 + " = new NPCTHON() { NpcName = \"" + array[1].Trim() + "\"," + Class47.string_3 + "\t\t\tMenuText = null," + Class47.string_3 + "\t\t\tItemName = null," + Class47.string_3 + "\t\t\tItemCount = 0," + Class47.string_3 + "\t\t\ttbPath = new uint[,] { {" + array[2].Replace("X = ", "").Replace("Y = ", "") + "}, }, //tbMapID_" + Class33.smethod_0(gstruct42_0).ToString() + "_" + text2 + Class47.string_3 + "        };";
				Clipboard.SetText(text);
				string[] array2 = array[2].Replace("X = ", "").Replace("Y = ", "").Split(',');
				int num = Class11.smethod_12(array2[0]) / 256;
				int num2 = Class11.smethod_12(array2[1]) / 512;
				text = "Index\t: " + array[0] + Class47.string_3 + "Name\t: " + array[1] + Class47.string_3 + "Pos\t: " + array2[0] + ", " + array2[1] + Class47.string_3 + "Pos Scr\t: " + num + ", " + num2 + Class47.string_3 + "Length\t: " + array[3] + Class47.string_3 + "--------------------------------------------" + Class47.string_3 + "Đã copy vào Clipboard";
				method_0(text);
			}
		}
	}

	private void buttonTenNPCgannhat_Click(object sender, EventArgs e)
	{
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			string text = Class60.smethod_120(gstruct42_0, 1).Trim();
			if (!(text == ""))
			{
				method_0(". " + text, bool_2: true, bool_3: false);
			}
		}
	}

	private void buttonRunPath_Click(object sender, EventArgs e)
	{
	}

	private void buttonFlagStick_Click(object sender, EventArgs e)
	{
		uint[] array = new uint[2]
		{
			Class11.smethod_13(textBoxTdx.Text),
			Class11.smethod_13(textBoxTdy.Text)
		};
		Class76.smethod_6(gstruct42_0, 1);
		Class76.Class79.smethod_5(gstruct42_0);
	}

	private void buttonXemMaloi_Click(object sender, EventArgs e)
	{
		string text = Class47.string_67;
		if (Class47.string_66 != null)
		{
			text = "CÁC LỖI SỐ: " + Class47.string_66 + Class47.string_3 + "=======================================" + Class47.string_3 + Class47.string_67;
		}
		FormTip.smethod_0("XEM MA LOI", text, 6000000, 500, 415, bool_5: true);
	}

	private void buttonXemMaloiVAuto_Click(object sender, EventArgs e)
	{
	}

	private void buttonDialogGetText_Click(object sender, EventArgs e)
	{
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			string text = Class76.Class79.smethod_0(gstruct42_0);
			textBoxNPCObjectInfo.Text = text;
		}
	}

	private void buttonTitleMenu_Click(object sender, EventArgs e)
	{
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			string text = Class76.Class78.smethod_2(gstruct42_0);
			textBoxNPCObjectInfo.Text = text;
		}
	}

	private void buttonGetChanelAllTop_Click(object sender, EventArgs e)
	{
		if (!Class20.smethod_52(gstruct42_0.process_0))
		{
			string text = Class73.smethod_28(gstruct42_0);
			textBoxNPCObjectInfo.Text = text;
		}
	}

	private static string smethod_0(string string_11)
	{
		if (!(string_11 == string.Empty) && string_11 != null)
		{
			if (string_11.IndexOf('.') > 0)
			{
				string[] array = Class11.smethod_15(string_11, '.');
				if (array.Length > 1)
				{
					string_11 = string_11 + ".XXX." + array[1];
					return string_11;
				}
			}
			return string_11 + ".XXX.Tmp";
		}
		return string.Empty;
	}

	private void buttonFileMahoa_Click(object sender, EventArgs e)
	{
		string[] array = new string[2]
		{
			Class47.string_4,
			string.Empty
		};
		if (string_0 != null && string_0 != string.Empty)
		{
			array = Class11.smethod_15(string_0);
		}
		string text = Class47.smethod_24(array[0], array[1], "*.exe", "AllFile|*.*");
		if (!(text == string.Empty))
		{
			string_0 = text;
			textBoxFileMahoa.Text = text;
			string_3 = smethod_0(string_0);
			textBoxMaHoa2.Text = string_3;
			Class55.smethod_10(Class47.string_0, "fCryptss", text, "", 0);
		}
	}

	private void buttonMoThumuc_Click(object sender, EventArgs e)
	{
		string text = Class47.string_4;
		if (string_0 != null && string_0 != string.Empty)
		{
			string[] array = Class11.smethod_15(string_0);
			text = array[0];
		}
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_1(Class47.char_0));
		Class20.smethod_40(environmentVariable + "\\explorer.exe", text, text, 0);
	}

	private void buttonMaHoa_Click(object sender, EventArgs e)
	{
		if (int_5 <= 0)
		{
			int_5 = 1;
			buttonMaHoa.Enabled = false;
			new Thread(method_2).Start();
		}
	}

	private void method_2()
	{
		if (string_0 != null && !(string_0 == string.Empty) && Class11.smethod_18(string_0))
		{
			byte[] array = null;
			try
			{
				array = File.ReadAllBytes(string_0);
			}
			catch
			{
			}
			if (array != null && array.Length >= 4)
			{
				int num = array.Length;
				for (long num2 = 0L; num2 < num - 4; num2++)
				{
					if (array[num2] >= 128)
					{
						array[num2] -= 128;
					}
					else
					{
						array[num2] += 128;
					}
				}
				string str = "DECRYPT";
				if (array[num - 2] == 254 && array[num - 1] == byte.MaxValue)
				{
					array[num - 2] = 0;
					array[num - 1] = 0;
				}
				else if (array[num - 2] == 0 && array[num - 1] == 0)
				{
					array[num - 2] = 254;
					array[num - 1] = byte.MaxValue;
					str = "ENCRYPT";
				}
				try
				{
					File.WriteAllBytes(string_3.Replace(".XXX.", "." + str + "."), array);
				}
				catch
				{
				}
				int_5 = 2;
			}
			else
			{
				int_5 = 2;
			}
		}
		else
		{
			int_5 = 2;
		}
	}

	private void buttonSum1_Click(object sender, EventArgs e)
	{
		if (string_7 == null)
		{
			string_7 = string_0;
		}
		string[] array = new string[2]
		{
			Class47.string_4,
			string.Empty
		};
		if (string_7 != null && string_7 != string.Empty)
		{
			array = Class11.smethod_15(string_7);
		}
		string a = Class47.smethod_24(array[0], array[1], "*.exe", "AllFile|*.*");
		if (!(a == string.Empty))
		{
			string_7 = a;
			string_9 = Class11.smethod_9(string_7).ToUpper();
			textBoxSum1.Text = string_7;
			textBoxKetQuaSum1.Text = string_9;
			if (string_9 != string_10 && string_10 != null && string_10 != string.Empty)
			{
				labelKetQuaSum.Text = "Kết quả: 2 tệp không giống nhau.";
			}
			else
			{
				labelKetQuaSum.Text = "Kết quả: 2 tệp giống nhau.";
			}
		}
	}

	private void buttonSum2_Click(object sender, EventArgs e)
	{
		if (string_8 == null)
		{
			if (string_7 != null)
			{
				string_8 = string_7;
			}
			else
			{
				string_8 = string_0;
			}
		}
		string[] array = new string[2]
		{
			Class47.string_4,
			string.Empty
		};
		if (string_8 != null && string_8 != string.Empty)
		{
			array = Class11.smethod_15(string_8);
		}
		string a = Class47.smethod_24(array[0], array[1], "*.exe", "AllFile|*.*");
		if (!(a == string.Empty))
		{
			string_8 = a;
			string_10 = Class11.smethod_9(string_8).ToUpper();
			textBoxSum2.Text = string_8;
			textBoxKetQuaSum2.Text = string_10;
			if (string_9 != string_10 && string_9 != null && string_9 != string.Empty)
			{
				labelKetQuaSum.Text = "Kết quả: 2 tệp không giống nhau.";
			}
			else
			{
				labelKetQuaSum.Text = "Kết quả: 2 tệp giống nhau.";
			}
		}
	}

	private void buttonPaste_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Clipboard.GetText();
			if (!(text == string.Empty) && text != null)
			{
				string_1 = text;
				int num = 0;
				while (true)
				{
					if (num >= comboBoxFind.Items.Count)
					{
						comboBoxFind.Items.Add(text);
						comboBoxFind.Text = text;
						return;
					}
					if (comboBoxFind.Items[num].ToString() == text)
					{
						break;
					}
					num++;
				}
				comboBoxFind.Text = text;
			}
		}
		catch
		{
		}
	}

	private void buttonDelete_Click(object sender, EventArgs e)
	{
		string text = comboBoxFind.Text;
		for (int i = 0; i < comboBoxFind.Items.Count; i++)
		{
			if (comboBoxFind.Items[i].ToString() == text)
			{
				comboBoxFind.Items.RemoveAt(i);
				break;
			}
		}
		comboBoxFind.Text = string.Empty;
	}

	private void buttonBrowss_Click(object sender, EventArgs e)
	{
		string text = Class47.smethod_26(string_2);
		if (text != null)
		{
			string_2 = text;
			textBoxFolder.Text = string_2;
			Class55.smethod_10(Class47.string_0, "Folder", string_2, "", 0);
		}
	}

	private void buttonBatdau_Click(object sender, EventArgs e)
	{
		string_1 = comboBoxFind.Text;
		bool flag = false;
		for (int i = 0; i < comboBoxFind.Items.Count; i++)
		{
			if (comboBoxFind.Items[i].ToString() == string_1)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			comboBoxFind.Items.Add(string_1);
		}
		timer_0.Interval = 60;
		buttonBatdau.Enabled = false;
		buttonStopFind.Enabled = true;
		textBoxFolder.Enabled = false;
		buttonBrowss.Enabled = false;
		byte_0 = 0;
		new Thread(method_3).Start();
	}

	private void buttonStopFind_Click(object sender, EventArgs e)
	{
		byte_0 = 1;
	}

	private void method_3()
	{
		string[] string_ = null;
		string oldValue = FormTest.string_2;
		if (FormTest.string_2 != null && FormTest.string_2 != string.Empty)
		{
			string_ = new string[1]
			{
				FormTest.string_2
			};
		}
		int num = 0;
		while (!Class11.bool_0 && bool_0 && byte_0 == 0 && string_1 != null && string_1 != string.Empty)
		{
			Thread.Sleep(1);
			if (string_ == null || string_.Length == 0)
			{
				break;
			}
			string text = string_[0];
			string_4 = "..\\" + text.Replace(oldValue, string.Empty);
			Class11.smethod_25(ref string_, text);
			if (text == "\\.." || text == ".." || text == ".")
			{
				continue;
			}
			if (Class11.smethod_27(text))
			{
				try
				{
					string[] files = Directory.GetFiles(text, "*.*");
					if (files != null)
					{
						for (int i = 0; i < files.Length; i++)
						{
							Class11.smethod_24(ref string_, files[i]);
						}
					}
					string[] directories = Directory.GetDirectories(text, "*.*");
					if (directories != null)
					{
						for (int i = 0; i < directories.Length; i++)
						{
							Class11.smethod_24(ref string_, directories[i]);
						}
					}
				}
				catch
				{
				}
				continue;
			}
			string string_2 = Class11.smethod_28(text, 0, 0, 3);
			if (0 <= Class11.smethod_2(string_2, string_1))
			{
				num++;
				object obj2 = string_5;
				string_5 = string.Concat(obj2, num, ". ", text, Class47.string_3);
			}
		}
		byte_0 = 2;
	}

	private void buttonXoaNhatky_Click(object sender, EventArgs e)
	{
		richTextBoxResult.Text = string.Empty;
		string_5 = string.Empty;
	}

	private void comboBoxFind_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			string_1 = comboBoxFind.Text;
		}
	}

	private void buttonCreateTK_Click(object sender, EventArgs e)
	{
		string text = Class47.string_4 + "\\TongKim";
		Class11.smethod_8(text);
		string text2 = Class11.smethod_16("ZnVuY3Rpb24gVGFza1NoZWR1bGUoKQoJVGFza05hbWUoICJUwq3CrG5nIETCrcKsbmcgKFTDqG5nIEtpbSkgWFhYWDpZWVlZIiApOwoJVGFza0ludGVydmFsKCAxNDQwICk7CglUYXNrVGltZSggWFhYWCwgWVlZWSApOwoJVGFza0NvdW50TGltaXQoIDAgKTsKCU91dHB1dE1zZyggIktob2kgZG9uZyBjaGllbiB0cnVvbmcgVG9uZyBLaW0gWlpaWjpXV1dXLi4uIiApOwplbmQKCmZ1bmN0aW9uIFRhc2tDb250ZW50KCkKCS0tQmF0dGxlX1N0YXJ0TmV3Um91bmQoIDEsIDEgKTsKCS0tQmF0dGxlX1N0YXJ0TmV3Um91bmQoIDEsIDIgKTsKCUJhdHRsZV9TdGFydE5ld1JvdW5kKCAxLCAzICk7CmVuZAoKZnVuY3Rpb24gR2FtZVN2ckNvbm5lY3RlZChkd0dhbWVTdnJJUCkKZW5kCmZ1bmN0aW9uIEdhbWVTdnJSZWFkeShkd0dhbWVTdnJJUCkKZW5kCg==");
		string text3 = null;
		int num = Class11.smethod_12(textBoxCountStart.Text);
		int num2 = Class11.smethod_12(textBoxThoigianGiancach.Text);
		string newValue = (Class11.smethod_12(textBoxTk.Text) * 24).ToString();
		int num3 = 0;
		for (int i = 0; i < 24; i++)
		{
			for (int j = 0; j < 60; j++)
			{
				if (j % num2 == 0)
				{
					string text4 = i.ToString();
					while (text4.Length < 2)
					{
						text4 = "0" + text4;
					}
					string text5 = j.ToString();
					while (text5.Length < 2)
					{
						text5 = "0" + text5;
					}
					string text6 = "battle_1_" + text4 + text5 + ".lua";
					string string_ = text2.Replace("XXXX", text4).Replace("YYYY", text5).Replace("ZZZZ", text4)
						.Replace("WWWW", text5)
						.Replace("1440", newValue);
					byte[] array = Class11.smethod_41(string_, bool_1: false);
					Class11.smethod_45(text + "\\" + text6, array);
					if (text3 != null)
					{
						text3 = text3 + Class47.string_3 + Class47.string_3;
					}
					object obj = text3;
					text3 = obj + "[Task_" + (num + num3) + "]" + Class47.string_3 + "TaskFile=" + text6;
					num3++;
				}
			}
		}
		Class11.smethod_29(text + "\\1.tasklist.ini", text3, 1);
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_1(Class47.char_0));
		Class20.smethod_40(environmentVariable + "\\explorer.exe", text, text, 0);
	}

	private void buttonBatdautaoPHLT_Click(object sender, EventArgs e)
	{
		string text = Class47.string_4 + "\\PhongHoaLienThanh";
		Class11.smethod_8(text);
		string text2 = Class11.smethod_16("ZnVuY3Rpb24gVGFza1NoZWR1bGUoKQoJVGFza05hbWUoIlBob25nIEjDoWEgTGnCqm4gVGjCtW5oIik7CQoJVGFza0ludGVydmFsKDE0NDApOwoJVGFza1RpbWUoWFhYWCwgWVlZWSk7CglPdXRwdXRNc2coICJLaG9pIGRvbmcgUEhMVCBYWFhYOllZWVkuLi4iICk7CglUYXNrQ291bnRMaW1pdCgwKTsKCmVuZAoKZnVuY3Rpb24gVGFza0NvbnRlbnQoKQoJbG9jYWwgd2Vla2RhdGUgPSBDbG91ZE9wZW5fRGVmZW5jZSgpCglpZiAod2Vla2RhdGUgPT0gbmlsKSB0aGVuCgkJT3V0cHV0TXNnKCJpdCBpcyBub3Qgc2F0dXJkYXkgb3Igc3VuZGF5LHNvIGNpdHlkZWZlbmNlIHdpbGwgbm90IG9wZW4iKQoJCXJldHVybgoJZW5kCglpZiAod2Vla2RhdGUgPT0gMCkgdGhlbgoJCU91dHB1dE1zZygiIFbDliBRdcOoYyBsacKqbiB0aMK1bmggS2ltIMKuwrcgYsK+dCDCrsOHdSBnaGkgZGFuaCIpOwoJCUdsb2JhbEV4ZWN1dGUoImR3IE5ld0NpdHlEZWZlbmNlX09wZW5NYWluKDIpIik7CgllbHNlCgkJT3V0cHV0TXNnKCIgVsOWIFF1w6hjIGxpwqpuIHRowrVuaCBUw6huZyDCrsK3IGLCvnQgwq7Dh3UgZ2hpIGRhbmguIik7CgkJR2xvYmFsRXhlY3V0ZSgiZHcgTmV3Q2l0eURlZmVuY2VfT3Blbk1haW4oMSkiKTsKCWVuZAplbmQKCmZ1bmN0aW9uIENsb3VkT3Blbl9EZWZlbmNlKCkKCWxvY2FsIHdlZWtkYXRlID0gdG9udW1iZXIoZGF0ZSgiJXciKSkKCS0taWYgKHdlZWtkYXRlIH49IDYpIHRoZW4KCS0tCXJldHVybiBuaWwKCS0tZW5kCglyZXR1cm4gd2Vla2RhdGUKZW5kCgpmdW5jdGlvbiBHYW1lU3ZyQ29ubmVjdGVkKGR3R2FtZVN2cklQKQplbmQKZnVuY3Rpb24gR2FtZVN2clJlYWR5KGR3R2FtZVN2cklQKQplbmQK");
		string text3 = null;
		int num = Class11.smethod_12(textBoxPHLT.Text);
		int num2 = Class11.smethod_12(textBoxThoigianGiancach.Text);
		int num3 = Class11.smethod_12(textBoxTk.Text);
		string newValue = (num3 * 24).ToString();
		int num4 = 0;
		for (int i = 0; i < 24; i++)
		{
			for (int j = 0; j < 60; j++)
			{
				if (j % num2 == 0)
				{
					string text4 = i.ToString();
					while (text4.Length < 2)
					{
						text4 = "0" + text4;
					}
					string text5 = (j + (num2 - num3)).ToString();
					while (text5.Length < 2)
					{
						text5 = "0" + text5;
					}
					string text6 = "PHLT_" + text4 + text5 + ".lua";
					string string_ = text2.Replace("XXXX", text4).Replace("YYYY", text5).Replace("1440", newValue);
					byte[] array = Class11.smethod_41(string_, bool_1: false);
					Class11.smethod_45(text + "\\" + text6, array);
					if (text3 != null)
					{
						text3 = text3 + Class47.string_3 + Class47.string_3;
					}
					object obj = text3;
					text3 = obj + "[Task_" + (num + num4) + "]" + Class47.string_3 + "TaskFile=" + text6;
					num4++;
				}
			}
		}
		Class11.smethod_29(text + "\\tasklist_phlt.ini", text3, 1);
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_1(Class47.char_0));
		Class20.smethod_40(environmentVariable + "\\explorer.exe", text, text, 0);
	}

	private void buttonOpenFile_Click(object sender, EventArgs e)
	{
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_1(Class47.char_0));
		string environmentVariable2 = Environment.GetEnvironmentVariable("programfiles");
		string[] array = new string[3]
		{
			environmentVariable2 + "\\Notepad++\\notepad++.exe",
			environmentVariable2 + "\\AutoIt3\\SciTE\\SciTE.exe",
			environmentVariable + "\\system32\\notepad.exe"
		};
		string text = textBoxFile.Text;
		string[] array2 = Class11.smethod_15(text);
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (Class11.smethod_18(array[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Class20.smethod_40(array[num], array2[0], text, 0);
	}

	private void textBoxFile_TextChanged(object sender, EventArgs e)
	{
	}

	private void buttonPaste2_Click(object sender, EventArgs e)
	{
		try
		{
			textBoxFile.Text = Clipboard.GetText();
		}
		catch
		{
		}
	}

	private void buttonTenTabKTC_Click(object sender, EventArgs e)
	{
		if (Class20.smethod_52(gstruct42_0.process_0))
		{
			return;
		}
		Struct25[] array = Class73.smethod_1(gstruct42_0);
		string text = string.Empty;
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (text != string.Empty)
				{
					text += Class47.string_3;
				}
				object obj = text;
				text = obj + "ID = " + array[i].int_0 + "; Name = \"" + array[i].string_0 + "\"";
			}
		}
		textBoxNPCObjectInfo.Text = text;
	}

	private void buttonSortcutSkill_Click(object sender, EventArgs e)
	{
		if (Class20.smethod_52(gstruct42_0.process_0))
		{
			return;
		}
		int int_ = 0;
		byte[] value = new byte[4];
		byte[] array = new byte[80];
		Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_6 + Class47.gstruct43_89.uint_0 + 16, value, 4, ref int_);
		int num = BitConverter.ToInt32(value, 0);
		Class20.ReadProcessMemory(gstruct42_0.int_130, gstruct42_0.uint_6 + Class47.gstruct43_89.uint_0, value, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(value, 0);
		uint num3 = 0u;
		string text = "STT |Địa chỉ  |SortcutID|SortcutName" + Class47.string_3;
		for (; num > num3; num3++)
		{
			uint num4 = num2 + num3 * Class47.gstruct43_88.uint_0;
			Class20.ReadProcessMemory(gstruct42_0.int_130, num4, value, 4, ref int_);
			uint num5 = BitConverter.ToUInt32(value, 0);
			string text2 = string.Empty;
			if (num5 != 0)
			{
				Class20.ReadProcessMemory(gstruct42_0.int_130, num4 + Class47.gstruct43_90.uint_0, array, array.Length, ref int_);
				text2 = Class10.smethod_3(array);
			}
			text += Class47.string_3;
			object obj = text;
			text = string.Concat(obj, num3, ".", Class11.smethod_40(num3, 2, bool_1: false), ". ", Class11.smethod_40(num4, 8, bool_1: false), "| ", Class11.smethod_40(num5, 2, bool_1: false), " \t= ", text2);
		}
		textBoxNPCObjectInfo.Text = text;
		string text3 = "Software\\Microsoft\\Notepad";
		string text4 = Class55.smethod_1(text3, "lfFaceName", 0);
		Class47.smethod_23("SortcutSkill.txt", text, bool_2: true, "Courier", 12, 870, 425, 200, 280);
		if (text4 != string.Empty)
		{
			Class55.smethod_10(text3, "lfFaceName", text4, string.Empty, 1);
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
		System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
		tabControl1 = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		buttonTenTabKTC = new System.Windows.Forms.Button();
		buttonGetChanelAllTop = new System.Windows.Forms.Button();
		buttonTitleMenu = new System.Windows.Forms.Button();
		buttonDialogGetText = new System.Windows.Forms.Button();
		buttonCopyNPCObjGannhat = new System.Windows.Forms.Button();
		buttonLamMap = new System.Windows.Forms.Button();
		buttonTenNPCgannhat = new System.Windows.Forms.Button();
		buttonNPCObjectGannhat = new System.Windows.Forms.Button();
		buttonGetIndexInfo = new System.Windows.Forms.Button();
		buttonGetAllNPCObject = new System.Windows.Forms.Button();
		buttonClear = new System.Windows.Forms.Button();
		buttonTdSingle = new System.Windows.Forms.Button();
		buttonCopyDefine = new System.Windows.Forms.Button();
		checkBoxPhimTat = new System.Windows.Forms.CheckBox();
		buttonLayToado = new System.Windows.Forms.Button();
		textBoxNPCObjectInfo = new System.Windows.Forms.TextBox();
		tabPage2 = new System.Windows.Forms.TabPage();
		groupBox3 = new System.Windows.Forms.GroupBox();
		textBoxKetQuaSum2 = new System.Windows.Forms.TextBox();
		textBoxKetQuaSum1 = new System.Windows.Forms.TextBox();
		labelKetQuaSum = new System.Windows.Forms.Label();
		textBoxSum1 = new System.Windows.Forms.TextBox();
		buttonSum2 = new System.Windows.Forms.Button();
		buttonSum1 = new System.Windows.Forms.Button();
		textBoxSum2 = new System.Windows.Forms.TextBox();
		groupBox2 = new System.Windows.Forms.GroupBox();
		buttonMoThumuc = new System.Windows.Forms.Button();
		buttonMaHoa = new System.Windows.Forms.Button();
		buttonFileMahoa = new System.Windows.Forms.Button();
		textBoxMaHoa2 = new System.Windows.Forms.TextBox();
		textBoxFileMahoa = new System.Windows.Forms.TextBox();
		label5 = new System.Windows.Forms.Label();
		buttonFlagStick = new System.Windows.Forms.Button();
		buttonRunPath = new System.Windows.Forms.Button();
		tabPage3 = new System.Windows.Forms.TabPage();
		buttonPaste2 = new System.Windows.Forms.Button();
		buttonOpenFile = new System.Windows.Forms.Button();
		textBoxFile = new System.Windows.Forms.TextBox();
		label10 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		comboBoxFind = new System.Windows.Forms.ComboBox();
		buttonXoaNhatky = new System.Windows.Forms.Button();
		buttonStopFind = new System.Windows.Forms.Button();
		textBoxTep = new System.Windows.Forms.TextBox();
		buttonBatdau = new System.Windows.Forms.Button();
		richTextBoxResult = new System.Windows.Forms.RichTextBox();
		buttonDelete = new System.Windows.Forms.Button();
		buttonPaste = new System.Windows.Forms.Button();
		buttonBrowss = new System.Windows.Forms.Button();
		label7 = new System.Windows.Forms.Label();
		textBoxFolder = new System.Windows.Forms.TextBox();
		label6 = new System.Windows.Forms.Label();
		tabPage4 = new System.Windows.Forms.TabPage();
		textBoxTk = new System.Windows.Forms.TextBox();
		label14 = new System.Windows.Forms.Label();
		textBoxThoigianGiancach = new System.Windows.Forms.TextBox();
		label13 = new System.Windows.Forms.Label();
		buttonBatdautaoPHLT = new System.Windows.Forms.Button();
		label12 = new System.Windows.Forms.Label();
		textBoxPHLT = new System.Windows.Forms.TextBox();
		label11 = new System.Windows.Forms.Label();
		buttonCreateTK = new System.Windows.Forms.Button();
		textBoxCountStart = new System.Windows.Forms.TextBox();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		groupBox1 = new System.Windows.Forms.GroupBox();
		buttonXemMaloiVAuto = new System.Windows.Forms.Button();
		buttonXemMaloi = new System.Windows.Forms.Button();
		buttonCopy = new System.Windows.Forms.Button();
		label4 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		textBoxTdy = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		textBoxTdx = new System.Windows.Forms.TextBox();
		textBoxID = new System.Windows.Forms.TextBox();
		textBoxTextSelect = new System.Windows.Forms.TextBox();
		textBoxIndex = new System.Windows.Forms.TextBox();
		buttonSortcutSkill = new System.Windows.Forms.Button();
		tabControl1.SuspendLayout();
		tabPage1.SuspendLayout();
		tabPage2.SuspendLayout();
		groupBox3.SuspendLayout();
		groupBox2.SuspendLayout();
		tabPage3.SuspendLayout();
		tabPage4.SuspendLayout();
		groupBox1.SuspendLayout();
		SuspendLayout();
		tabControl1.Controls.Add(tabPage1);
		tabControl1.Controls.Add(tabPage2);
		tabControl1.Controls.Add(tabPage3);
		tabControl1.Controls.Add(tabPage4);
		tabControl1.Location = new System.Drawing.Point(0, 74);
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size(328, 380);
		tabControl1.TabIndex = 0;
		tabPage1.Controls.Add(buttonSortcutSkill);
		tabPage1.Controls.Add(buttonTenTabKTC);
		tabPage1.Controls.Add(buttonGetChanelAllTop);
		tabPage1.Controls.Add(buttonTitleMenu);
		tabPage1.Controls.Add(buttonDialogGetText);
		tabPage1.Controls.Add(buttonCopyNPCObjGannhat);
		tabPage1.Controls.Add(buttonLamMap);
		tabPage1.Controls.Add(buttonTenNPCgannhat);
		tabPage1.Controls.Add(buttonNPCObjectGannhat);
		tabPage1.Controls.Add(buttonGetIndexInfo);
		tabPage1.Controls.Add(buttonGetAllNPCObject);
		tabPage1.Controls.Add(buttonClear);
		tabPage1.Controls.Add(buttonTdSingle);
		tabPage1.Controls.Add(buttonCopyDefine);
		tabPage1.Controls.Add(checkBoxPhimTat);
		tabPage1.Controls.Add(buttonLayToado);
		tabPage1.Controls.Add(textBoxNPCObjectInfo);
		tabPage1.Location = new System.Drawing.Point(4, 22);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding(3);
		tabPage1.Size = new System.Drawing.Size(320, 354);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "Bảng 1";
		tabPage1.UseVisualStyleBackColor = true;
		buttonTenTabKTC.Location = new System.Drawing.Point(0, 303);
		buttonTenTabKTC.Name = "buttonTenTabKTC";
		buttonTenTabKTC.Size = new System.Drawing.Size(90, 23);
		buttonTenTabKTC.TabIndex = 59;
		buttonTenTabKTC.Text = "Tên tab  KTC";
		buttonTenTabKTC.UseVisualStyleBackColor = true;
		buttonTenTabKTC.Click += new System.EventHandler(buttonTenTabKTC_Click);
		buttonGetChanelAllTop.Location = new System.Drawing.Point(205, 197);
		buttonGetChanelAllTop.Name = "buttonGetChanelAllTop";
		buttonGetChanelAllTop.Size = new System.Drawing.Size(115, 23);
		buttonGetChanelAllTop.TabIndex = 58;
		buttonGetChanelAllTop.Text = "Lấy text ChanelTop";
		buttonGetChanelAllTop.UseVisualStyleBackColor = true;
		buttonGetChanelAllTop.Click += new System.EventHandler(buttonGetChanelAllTop_Click);
		buttonTitleMenu.Location = new System.Drawing.Point(205, 118);
		buttonTitleMenu.Name = "buttonTitleMenu";
		buttonTitleMenu.Size = new System.Drawing.Size(115, 23);
		buttonTitleMenu.TabIndex = 57;
		buttonTitleMenu.Text = "Lấy Title Menu_1";
		buttonTitleMenu.UseVisualStyleBackColor = true;
		buttonTitleMenu.Click += new System.EventHandler(buttonTitleMenu_Click);
		buttonDialogGetText.Location = new System.Drawing.Point(205, 169);
		buttonDialogGetText.Name = "buttonDialogGetText";
		buttonDialogGetText.Size = new System.Drawing.Size(115, 23);
		buttonDialogGetText.TabIndex = 56;
		buttonDialogGetText.Text = "Lấy dòng text Dialog";
		buttonDialogGetText.UseVisualStyleBackColor = true;
		buttonDialogGetText.Click += new System.EventHandler(buttonDialogGetText_Click);
		buttonCopyNPCObjGannhat.Location = new System.Drawing.Point(205, 331);
		buttonCopyNPCObjGannhat.Name = "buttonCopyNPCObjGannhat";
		buttonCopyNPCObjGannhat.Size = new System.Drawing.Size(115, 23);
		buttonCopyNPCObjGannhat.TabIndex = 55;
		buttonCopyNPCObjGannhat.Text = "Copy NPC gần nhất";
		buttonCopyNPCObjGannhat.UseVisualStyleBackColor = true;
		buttonCopyNPCObjGannhat.Click += new System.EventHandler(buttonCopyNPCObjGannhat_Click);
		buttonLamMap.Location = new System.Drawing.Point(96, 331);
		buttonLamMap.Name = "buttonLamMap";
		buttonLamMap.Size = new System.Drawing.Size(106, 23);
		buttonLamMap.TabIndex = 54;
		buttonLamMap.Text = "Copy làm Map";
		buttonLamMap.UseVisualStyleBackColor = true;
		buttonLamMap.Click += new System.EventHandler(buttonLamMap_Click);
		buttonTenNPCgannhat.Location = new System.Drawing.Point(205, 306);
		buttonTenNPCgannhat.Name = "buttonTenNPCgannhat";
		buttonTenNPCgannhat.Size = new System.Drawing.Size(115, 23);
		buttonTenNPCgannhat.TabIndex = 53;
		buttonTenNPCgannhat.Text = "Tên NPC gần nhất";
		buttonTenNPCgannhat.UseVisualStyleBackColor = true;
		buttonTenNPCgannhat.Click += new System.EventHandler(buttonTenNPCgannhat_Click);
		buttonNPCObjectGannhat.Location = new System.Drawing.Point(205, 267);
		buttonNPCObjectGannhat.Name = "buttonNPCObjectGannhat";
		buttonNPCObjectGannhat.Size = new System.Drawing.Size(115, 34);
		buttonNPCObjectGannhat.TabIndex = 52;
		buttonNPCObjectGannhat.Text = "NPC, Object gần nhất";
		buttonNPCObjectGannhat.UseVisualStyleBackColor = true;
		buttonNPCObjectGannhat.Click += new System.EventHandler(buttonNPCObjectGannhat_Click);
		buttonGetIndexInfo.Location = new System.Drawing.Point(205, 144);
		buttonGetIndexInfo.Name = "buttonGetIndexInfo";
		buttonGetIndexInfo.Size = new System.Drawing.Size(115, 23);
		buttonGetIndexInfo.TabIndex = 51;
		buttonGetIndexInfo.Text = "Lấy dòng text Menu";
		buttonGetIndexInfo.UseVisualStyleBackColor = true;
		buttonGetIndexInfo.Click += new System.EventHandler(buttonGetIndexInfo_Click);
		buttonGetAllNPCObject.Location = new System.Drawing.Point(205, 229);
		buttonGetAllNPCObject.Name = "buttonGetAllNPCObject";
		buttonGetAllNPCObject.Size = new System.Drawing.Size(115, 36);
		buttonGetAllNPCObject.TabIndex = 50;
		buttonGetAllNPCObject.Text = "Thông tin NPC - Object xung quanh";
		buttonGetAllNPCObject.UseVisualStyleBackColor = true;
		buttonGetAllNPCObject.Click += new System.EventHandler(buttonGetAllNPCObject_Click);
		buttonClear.Location = new System.Drawing.Point(205, 88);
		buttonClear.Name = "buttonClear";
		buttonClear.Size = new System.Drawing.Size(62, 22);
		buttonClear.TabIndex = 49;
		buttonClear.Text = "<= Clear";
		buttonClear.UseVisualStyleBackColor = true;
		buttonClear.Click += new System.EventHandler(buttonClear_Click);
		buttonTdSingle.Location = new System.Drawing.Point(269, 88);
		buttonTdSingle.Name = "buttonTdSingle";
		buttonTdSingle.Size = new System.Drawing.Size(51, 22);
		buttonTdSingle.TabIndex = 48;
		buttonTdSingle.Text = "Copy";
		buttonTdSingle.UseVisualStyleBackColor = true;
		buttonTdSingle.Click += new System.EventHandler(buttonTdSingle_Click);
		buttonCopyDefine.Location = new System.Drawing.Point(0, 331);
		buttonCopyDefine.Name = "buttonCopyDefine";
		buttonCopyDefine.Size = new System.Drawing.Size(90, 23);
		buttonCopyDefine.TabIndex = 47;
		buttonCopyDefine.Text = "Copy làm Public";
		buttonCopyDefine.UseVisualStyleBackColor = true;
		buttonCopyDefine.Click += new System.EventHandler(buttonCopyDefine_Click);
		checkBoxPhimTat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
		checkBoxPhimTat.Location = new System.Drawing.Point(206, 36);
		checkBoxPhimTat.Name = "checkBoxPhimTat";
		checkBoxPhimTat.Size = new System.Drawing.Size(110, 46);
		checkBoxPhimTat.TabIndex = 46;
		checkBoxPhimTat.Text = "Phím tắt:\r\n1. ctrl + space\r\n2. shift + space";
		checkBoxPhimTat.UseVisualStyleBackColor = false;
		checkBoxPhimTat.CheckedChanged += new System.EventHandler(checkBoxPhimTat_CheckedChanged);
		buttonLayToado.Location = new System.Drawing.Point(205, 0);
		buttonLayToado.Name = "buttonLayToado";
		buttonLayToado.Size = new System.Drawing.Size(115, 34);
		buttonLayToado.TabIndex = 45;
		buttonLayToado.Text = "Lấy toạ độ (1)\r\nSử dụng phím tắt";
		buttonLayToado.UseVisualStyleBackColor = true;
		buttonLayToado.Click += new System.EventHandler(buttonLayToado_Click);
		textBoxNPCObjectInfo.Location = new System.Drawing.Point(0, 6);
		textBoxNPCObjectInfo.Multiline = true;
		textBoxNPCObjectInfo.Name = "textBoxNPCObjectInfo";
		textBoxNPCObjectInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		textBoxNPCObjectInfo.Size = new System.Drawing.Size(202, 293);
		textBoxNPCObjectInfo.TabIndex = 44;
		textBoxNPCObjectInfo.WordWrap = false;
		tabPage2.Controls.Add(groupBox3);
		tabPage2.Controls.Add(groupBox2);
		tabPage2.Controls.Add(buttonFlagStick);
		tabPage2.Controls.Add(buttonRunPath);
		tabPage2.Location = new System.Drawing.Point(4, 22);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding(3);
		tabPage2.Size = new System.Drawing.Size(320, 354);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "Bảng 2";
		tabPage2.UseVisualStyleBackColor = true;
		groupBox3.Controls.Add(textBoxKetQuaSum2);
		groupBox3.Controls.Add(textBoxKetQuaSum1);
		groupBox3.Controls.Add(labelKetQuaSum);
		groupBox3.Controls.Add(textBoxSum1);
		groupBox3.Controls.Add(buttonSum2);
		groupBox3.Controls.Add(buttonSum1);
		groupBox3.Controls.Add(textBoxSum2);
		groupBox3.Location = new System.Drawing.Point(3, 136);
		groupBox3.Name = "groupBox3";
		groupBox3.Size = new System.Drawing.Size(313, 150);
		groupBox3.TabIndex = 61;
		groupBox3.TabStop = false;
		groupBox3.Text = "Check sum";
		textBoxKetQuaSum2.Location = new System.Drawing.Point(6, 92);
		textBoxKetQuaSum2.Name = "textBoxKetQuaSum2";
		textBoxKetQuaSum2.ReadOnly = true;
		textBoxKetQuaSum2.Size = new System.Drawing.Size(224, 20);
		textBoxKetQuaSum2.TabIndex = 63;
		textBoxKetQuaSum1.Location = new System.Drawing.Point(6, 41);
		textBoxKetQuaSum1.Name = "textBoxKetQuaSum1";
		textBoxKetQuaSum1.ReadOnly = true;
		textBoxKetQuaSum1.Size = new System.Drawing.Size(224, 20);
		textBoxKetQuaSum1.TabIndex = 62;
		labelKetQuaSum.AutoSize = true;
		labelKetQuaSum.Location = new System.Drawing.Point(5, 117);
		labelKetQuaSum.Name = "labelKetQuaSum";
		labelKetQuaSum.Size = new System.Drawing.Size(59, 13);
		labelKetQuaSum.TabIndex = 61;
		labelKetQuaSum.Text = "Kết quả: ...";
		textBoxSum1.Location = new System.Drawing.Point(6, 19);
		textBoxSum1.Name = "textBoxSum1";
		textBoxSum1.ReadOnly = true;
		textBoxSum1.Size = new System.Drawing.Size(224, 20);
		textBoxSum1.TabIndex = 57;
		buttonSum2.Location = new System.Drawing.Point(236, 83);
		buttonSum2.Name = "buttonSum2";
		buttonSum2.Size = new System.Drawing.Size(71, 29);
		buttonSum2.TabIndex = 60;
		buttonSum2.Text = "File Sum2";
		buttonSum2.UseVisualStyleBackColor = true;
		buttonSum2.Click += new System.EventHandler(buttonSum2_Click);
		buttonSum1.Location = new System.Drawing.Point(237, 29);
		buttonSum1.Name = "buttonSum1";
		buttonSum1.Size = new System.Drawing.Size(71, 32);
		buttonSum1.TabIndex = 58;
		buttonSum1.Text = "File Sum1";
		buttonSum1.UseVisualStyleBackColor = true;
		buttonSum1.Click += new System.EventHandler(buttonSum1_Click);
		textBoxSum2.Location = new System.Drawing.Point(6, 70);
		textBoxSum2.Name = "textBoxSum2";
		textBoxSum2.ReadOnly = true;
		textBoxSum2.Size = new System.Drawing.Size(224, 20);
		textBoxSum2.TabIndex = 59;
		groupBox2.Controls.Add(buttonMoThumuc);
		groupBox2.Controls.Add(buttonMaHoa);
		groupBox2.Controls.Add(buttonFileMahoa);
		groupBox2.Controls.Add(textBoxMaHoa2);
		groupBox2.Controls.Add(textBoxFileMahoa);
		groupBox2.Controls.Add(label5);
		groupBox2.Location = new System.Drawing.Point(3, 3);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(313, 127);
		groupBox2.TabIndex = 50;
		groupBox2.TabStop = false;
		groupBox2.Text = "Mã hóa file";
		buttonMoThumuc.Location = new System.Drawing.Point(146, 93);
		buttonMoThumuc.Name = "buttonMoThumuc";
		buttonMoThumuc.Size = new System.Drawing.Size(84, 23);
		buttonMoThumuc.TabIndex = 56;
		buttonMoThumuc.Text = "Mở thư mục";
		buttonMoThumuc.UseVisualStyleBackColor = true;
		buttonMoThumuc.Click += new System.EventHandler(buttonMoThumuc_Click);
		buttonMaHoa.Location = new System.Drawing.Point(10, 93);
		buttonMaHoa.Name = "buttonMaHoa";
		buttonMaHoa.Size = new System.Drawing.Size(130, 23);
		buttonMaHoa.TabIndex = 55;
		buttonMaHoa.Text = "Mã hóa/Giải mã hóa";
		buttonMaHoa.UseVisualStyleBackColor = true;
		buttonMaHoa.Click += new System.EventHandler(buttonMaHoa_Click);
		buttonFileMahoa.Location = new System.Drawing.Point(236, 38);
		buttonFileMahoa.Name = "buttonFileMahoa";
		buttonFileMahoa.Size = new System.Drawing.Size(71, 45);
		buttonFileMahoa.TabIndex = 54;
		buttonFileMahoa.Text = "Tệp mã hóa";
		buttonFileMahoa.UseVisualStyleBackColor = true;
		buttonFileMahoa.Click += new System.EventHandler(buttonFileMahoa_Click);
		textBoxMaHoa2.Location = new System.Drawing.Point(10, 63);
		textBoxMaHoa2.Name = "textBoxMaHoa2";
		textBoxMaHoa2.ReadOnly = true;
		textBoxMaHoa2.Size = new System.Drawing.Size(220, 20);
		textBoxMaHoa2.TabIndex = 53;
		textBoxFileMahoa.Location = new System.Drawing.Point(10, 40);
		textBoxFileMahoa.Name = "textBoxFileMahoa";
		textBoxFileMahoa.ReadOnly = true;
		textBoxFileMahoa.Size = new System.Drawing.Size(220, 20);
		textBoxFileMahoa.TabIndex = 52;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(7, 16);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(285, 13);
		label5.TabIndex = 0;
		label5.Text = "Kiểu mã hóa: if (a < 128) => b = a + 128 else => b = a - 128\r\n";
		buttonFlagStick.Location = new System.Drawing.Point(183, 321);
		buttonFlagStick.Name = "buttonFlagStick";
		buttonFlagStick.Size = new System.Drawing.Size(90, 23);
		buttonFlagStick.TabIndex = 49;
		buttonFlagStick.Text = "FlagStick (3,4)";
		buttonFlagStick.UseVisualStyleBackColor = true;
		buttonFlagStick.Click += new System.EventHandler(buttonFlagStick_Click);
		buttonRunPath.Location = new System.Drawing.Point(183, 292);
		buttonRunPath.Name = "buttonRunPath";
		buttonRunPath.Size = new System.Drawing.Size(90, 23);
		buttonRunPath.TabIndex = 48;
		buttonRunPath.Text = "RunPath";
		buttonRunPath.UseVisualStyleBackColor = true;
		buttonRunPath.Click += new System.EventHandler(buttonRunPath_Click);
		tabPage3.Controls.Add(buttonPaste2);
		tabPage3.Controls.Add(buttonOpenFile);
		tabPage3.Controls.Add(textBoxFile);
		tabPage3.Controls.Add(label10);
		tabPage3.Controls.Add(label9);
		tabPage3.Controls.Add(label8);
		tabPage3.Controls.Add(comboBoxFind);
		tabPage3.Controls.Add(buttonXoaNhatky);
		tabPage3.Controls.Add(buttonStopFind);
		tabPage3.Controls.Add(textBoxTep);
		tabPage3.Controls.Add(buttonBatdau);
		tabPage3.Controls.Add(richTextBoxResult);
		tabPage3.Controls.Add(buttonDelete);
		tabPage3.Controls.Add(buttonPaste);
		tabPage3.Controls.Add(buttonBrowss);
		tabPage3.Controls.Add(label7);
		tabPage3.Controls.Add(textBoxFolder);
		tabPage3.Controls.Add(label6);
		tabPage3.Location = new System.Drawing.Point(4, 22);
		tabPage3.Name = "tabPage3";
		tabPage3.Padding = new System.Windows.Forms.Padding(3);
		tabPage3.Size = new System.Drawing.Size(320, 354);
		tabPage3.TabIndex = 2;
		tabPage3.Text = "Find";
		tabPage3.UseVisualStyleBackColor = true;
		buttonPaste2.ForeColor = System.Drawing.Color.Black;
		buttonPaste2.Location = new System.Drawing.Point(217, 279);
		buttonPaste2.Name = "buttonPaste2";
		buttonPaste2.Size = new System.Drawing.Size(53, 21);
		buttonPaste2.TabIndex = 50;
		buttonPaste2.Text = "Paste";
		buttonPaste2.UseVisualStyleBackColor = true;
		buttonPaste2.Click += new System.EventHandler(buttonPaste2_Click);
		buttonOpenFile.ForeColor = System.Drawing.Color.Black;
		buttonOpenFile.Location = new System.Drawing.Point(276, 280);
		buttonOpenFile.Name = "buttonOpenFile";
		buttonOpenFile.Size = new System.Drawing.Size(44, 21);
		buttonOpenFile.TabIndex = 49;
		buttonOpenFile.Text = "Mở";
		buttonOpenFile.UseVisualStyleBackColor = true;
		buttonOpenFile.Click += new System.EventHandler(buttonOpenFile_Click);
		textBoxFile.Location = new System.Drawing.Point(0, 280);
		textBoxFile.Name = "textBoxFile";
		textBoxFile.Size = new System.Drawing.Size(214, 20);
		textBoxFile.TabIndex = 48;
		textBoxFile.TextChanged += new System.EventHandler(textBoxFile_TextChanged);
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(4, 56);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(36, 13);
		label10.TabIndex = 47;
		label10.Text = "Folder";
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(2, 6);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(47, 13);
		label9.TabIndex = 46;
		label9.Text = "Find text";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(181, 329);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(0, 13);
		label8.TabIndex = 45;
		comboBoxFind.FormattingEnabled = true;
		comboBoxFind.Location = new System.Drawing.Point(57, 3);
		comboBoxFind.Name = "comboBoxFind";
		comboBoxFind.Size = new System.Drawing.Size(263, 21);
		comboBoxFind.TabIndex = 42;
		comboBoxFind.SelectedIndexChanged += new System.EventHandler(comboBoxFind_SelectedIndexChanged);
		buttonXoaNhatky.ForeColor = System.Drawing.Color.Black;
		buttonXoaNhatky.Location = new System.Drawing.Point(223, 327);
		buttonXoaNhatky.Name = "buttonXoaNhatky";
		buttonXoaNhatky.Size = new System.Drawing.Size(94, 25);
		buttonXoaNhatky.TabIndex = 41;
		buttonXoaNhatky.Text = "Xóa nhật ký";
		buttonXoaNhatky.UseVisualStyleBackColor = true;
		buttonXoaNhatky.Click += new System.EventHandler(buttonXoaNhatky_Click);
		buttonStopFind.ForeColor = System.Drawing.Color.Black;
		buttonStopFind.Location = new System.Drawing.Point(94, 327);
		buttonStopFind.Name = "buttonStopFind";
		buttonStopFind.Size = new System.Drawing.Size(81, 25);
		buttonStopFind.TabIndex = 40;
		buttonStopFind.Text = "Dừng";
		buttonStopFind.UseVisualStyleBackColor = true;
		buttonStopFind.Click += new System.EventHandler(buttonStopFind_Click);
		textBoxTep.BackColor = System.Drawing.Color.Silver;
		textBoxTep.BorderStyle = System.Windows.Forms.BorderStyle.None;
		textBoxTep.Location = new System.Drawing.Point(3, 307);
		textBoxTep.Name = "textBoxTep";
		textBoxTep.Size = new System.Drawing.Size(314, 13);
		textBoxTep.TabIndex = 39;
		textBoxTep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		buttonBatdau.ForeColor = System.Drawing.Color.Black;
		buttonBatdau.Location = new System.Drawing.Point(5, 327);
		buttonBatdau.Name = "buttonBatdau";
		buttonBatdau.Size = new System.Drawing.Size(83, 25);
		buttonBatdau.TabIndex = 37;
		buttonBatdau.Text = "Bắt đầu tìm";
		buttonBatdau.UseVisualStyleBackColor = true;
		buttonBatdau.Click += new System.EventHandler(buttonBatdau_Click);
		richTextBoxResult.Location = new System.Drawing.Point(0, 79);
		richTextBoxResult.Name = "richTextBoxResult";
		richTextBoxResult.Size = new System.Drawing.Size(320, 195);
		richTextBoxResult.TabIndex = 36;
		richTextBoxResult.Text = "";
		richTextBoxResult.WordWrap = false;
		buttonDelete.ForeColor = System.Drawing.Color.Black;
		buttonDelete.Location = new System.Drawing.Point(151, 28);
		buttonDelete.Name = "buttonDelete";
		buttonDelete.Size = new System.Drawing.Size(63, 21);
		buttonDelete.TabIndex = 35;
		buttonDelete.Text = "x";
		buttonDelete.UseVisualStyleBackColor = true;
		buttonDelete.Click += new System.EventHandler(buttonDelete_Click);
		buttonPaste.ForeColor = System.Drawing.Color.Black;
		buttonPaste.Location = new System.Drawing.Point(57, 28);
		buttonPaste.Name = "buttonPaste";
		buttonPaste.Size = new System.Drawing.Size(88, 21);
		buttonPaste.TabIndex = 34;
		buttonPaste.Text = "Paste";
		buttonPaste.UseVisualStyleBackColor = true;
		buttonPaste.Click += new System.EventHandler(buttonPaste_Click);
		buttonBrowss.ForeColor = System.Drawing.Color.Black;
		buttonBrowss.Location = new System.Drawing.Point(276, 52);
		buttonBrowss.Name = "buttonBrowss";
		buttonBrowss.Size = new System.Drawing.Size(44, 21);
		buttonBrowss.TabIndex = 33;
		buttonBrowss.Text = "***";
		buttonBrowss.UseVisualStyleBackColor = true;
		buttonBrowss.Click += new System.EventHandler(buttonBrowss_Click);
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(2, 56);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(0, 13);
		label7.TabIndex = 3;
		textBoxFolder.Location = new System.Drawing.Point(57, 53);
		textBoxFolder.Name = "textBoxFolder";
		textBoxFolder.Size = new System.Drawing.Size(213, 20);
		textBoxFolder.TabIndex = 2;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(2, 7);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(0, 13);
		label6.TabIndex = 0;
		tabPage4.Controls.Add(textBoxTk);
		tabPage4.Controls.Add(label14);
		tabPage4.Controls.Add(textBoxThoigianGiancach);
		tabPage4.Controls.Add(label13);
		tabPage4.Controls.Add(buttonBatdautaoPHLT);
		tabPage4.Controls.Add(label12);
		tabPage4.Controls.Add(textBoxPHLT);
		tabPage4.Controls.Add(label11);
		tabPage4.Controls.Add(buttonCreateTK);
		tabPage4.Controls.Add(textBoxCountStart);
		tabPage4.Location = new System.Drawing.Point(4, 22);
		tabPage4.Name = "tabPage4";
		tabPage4.Size = new System.Drawing.Size(320, 354);
		tabPage4.TabIndex = 0;
		tabPage4.Text = "LuaScript";
		tabPage4.UseVisualStyleBackColor = true;
		textBoxTk.Location = new System.Drawing.Point(89, 25);
		textBoxTk.Name = "textBoxTk";
		textBoxTk.Size = new System.Drawing.Size(31, 20);
		textBoxTk.TabIndex = 52;
		textBoxTk.Text = "15";
		label14.AutoSize = true;
		label14.Location = new System.Drawing.Point(4, 28);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(66, 13);
		label14.TabIndex = 51;
		label14.Text = "Thời gian (p)";
		textBoxThoigianGiancach.Location = new System.Drawing.Point(269, 25);
		textBoxThoigianGiancach.Name = "textBoxThoigianGiancach";
		textBoxThoigianGiancach.Size = new System.Drawing.Size(51, 20);
		textBoxThoigianGiancach.TabIndex = 50;
		textBoxThoigianGiancach.Text = "15";
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(126, 28);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(131, 13);
		label13.TabIndex = 49;
		label13.Text = "Thời gian giãn cách (phút)";
		buttonBatdautaoPHLT.ForeColor = System.Drawing.Color.Black;
		buttonBatdautaoPHLT.Location = new System.Drawing.Point(57, 129);
		buttonBatdautaoPHLT.Name = "buttonBatdautaoPHLT";
		buttonBatdautaoPHLT.Size = new System.Drawing.Size(170, 25);
		buttonBatdautaoPHLT.TabIndex = 48;
		buttonBatdautaoPHLT.Text = "Bắt đầu tạo";
		buttonBatdautaoPHLT.UseVisualStyleBackColor = true;
		buttonBatdautaoPHLT.Click += new System.EventHandler(buttonBatdautaoPHLT_Click);
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(3, 101);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(247, 26);
		label12.TabIndex = 47;
		label12.Text = "Tạo script chạy PHLT liên tục, bắt đầu từ số thứ tự\r\n(xen kẻ tống kim)";
		textBoxPHLT.Location = new System.Drawing.Point(268, 99);
		textBoxPHLT.Name = "textBoxPHLT";
		textBoxPHLT.Size = new System.Drawing.Size(51, 20);
		textBoxPHLT.TabIndex = 46;
		textBoxPHLT.Text = "225";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(4, 6);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(259, 13);
		label11.TabIndex = 45;
		label11.Text = "Tạo script chạy tống kim liên tục, bắt đầu từ số thứ tự";
		buttonCreateTK.ForeColor = System.Drawing.Color.Black;
		buttonCreateTK.Location = new System.Drawing.Point(57, 61);
		buttonCreateTK.Name = "buttonCreateTK";
		buttonCreateTK.Size = new System.Drawing.Size(170, 25);
		buttonCreateTK.TabIndex = 43;
		buttonCreateTK.Text = "Tạo script Task TongKim";
		buttonCreateTK.UseVisualStyleBackColor = true;
		buttonCreateTK.Click += new System.EventHandler(buttonCreateTK_Click);
		textBoxCountStart.Location = new System.Drawing.Point(269, 3);
		textBoxCountStart.Name = "textBoxCountStart";
		textBoxCountStart.Size = new System.Drawing.Size(51, 20);
		textBoxCountStart.TabIndex = 44;
		textBoxCountStart.Text = "104";
		timer_0.Tick += new System.EventHandler(timer_0_Tick);
		groupBox1.Controls.Add(buttonXemMaloiVAuto);
		groupBox1.Controls.Add(buttonXemMaloi);
		groupBox1.Controls.Add(buttonCopy);
		groupBox1.Controls.Add(label4);
		groupBox1.Controls.Add(label1);
		groupBox1.Controls.Add(label3);
		groupBox1.Controls.Add(textBoxTdy);
		groupBox1.Controls.Add(label2);
		groupBox1.Controls.Add(textBoxTdx);
		groupBox1.Controls.Add(textBoxID);
		groupBox1.Controls.Add(textBoxTextSelect);
		groupBox1.Controls.Add(textBoxIndex);
		groupBox1.Location = new System.Drawing.Point(1, 0);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(325, 70);
		groupBox1.TabIndex = 14;
		groupBox1.TabStop = false;
		groupBox1.Text = "Thiết lập";
		buttonXemMaloiVAuto.Location = new System.Drawing.Point(220, 40);
		buttonXemMaloiVAuto.Name = "buttonXemMaloiVAuto";
		buttonXemMaloiVAuto.Size = new System.Drawing.Size(100, 21);
		buttonXemMaloiVAuto.TabIndex = 51;
		buttonXemMaloiVAuto.Text = "Xem mã lỗi Vauto";
		buttonXemMaloiVAuto.UseVisualStyleBackColor = true;
		buttonXemMaloiVAuto.Click += new System.EventHandler(buttonXemMaloiVAuto_Click);
		buttonXemMaloi.Location = new System.Drawing.Point(220, 17);
		buttonXemMaloi.Name = "buttonXemMaloi";
		buttonXemMaloi.Size = new System.Drawing.Size(100, 21);
		buttonXemMaloi.TabIndex = 50;
		buttonXemMaloi.Text = "Xem mã lỗi game";
		buttonXemMaloi.UseVisualStyleBackColor = true;
		buttonXemMaloi.Click += new System.EventHandler(buttonXemMaloi_Click);
		buttonCopy.Location = new System.Drawing.Point(109, 42);
		buttonCopy.Name = "buttonCopy";
		buttonCopy.Size = new System.Drawing.Size(39, 21);
		buttonCopy.TabIndex = 38;
		buttonCopy.Text = "Copy";
		buttonCopy.UseVisualStyleBackColor = true;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(149, 44);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(13, 13);
		label4.TabIndex = 33;
		label4.Text = "4";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(5, 22);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(13, 13);
		label1.TabIndex = 22;
		label1.Text = "1";
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(149, 22);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(13, 13);
		label3.TabIndex = 32;
		label3.Text = "3";
		textBoxTdy.Location = new System.Drawing.Point(165, 42);
		textBoxTdy.Name = "textBoxTdy";
		textBoxTdy.Size = new System.Drawing.Size(51, 20);
		textBoxTdy.TabIndex = 27;
		textBoxTdy.Text = "101108";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(5, 45);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(13, 13);
		label2.TabIndex = 31;
		label2.Text = "2";
		textBoxTdx.Location = new System.Drawing.Point(165, 19);
		textBoxTdx.Name = "textBoxTdx";
		textBoxTdx.Size = new System.Drawing.Size(51, 20);
		textBoxTdx.TabIndex = 26;
		textBoxTdx.Text = "52280";
		textBoxID.Location = new System.Drawing.Point(60, 19);
		textBoxID.Name = "textBoxID";
		textBoxID.ReadOnly = true;
		textBoxID.Size = new System.Drawing.Size(88, 20);
		textBoxID.TabIndex = 1;
		textBoxTextSelect.Location = new System.Drawing.Point(21, 42);
		textBoxTextSelect.Name = "textBoxTextSelect";
		textBoxTextSelect.Size = new System.Drawing.Size(82, 20);
		textBoxTextSelect.TabIndex = 30;
		textBoxTextSelect.Text = "Text - CityName";
		textBoxIndex.Location = new System.Drawing.Point(21, 19);
		textBoxIndex.Name = "textBoxIndex";
		textBoxIndex.Size = new System.Drawing.Size(34, 20);
		textBoxIndex.TabIndex = 21;
		textBoxIndex.Text = "0";
		buttonSortcutSkill.Location = new System.Drawing.Point(96, 304);
		buttonSortcutSkill.Name = "buttonSortcutSkill";
		buttonSortcutSkill.Size = new System.Drawing.Size(106, 23);
		buttonSortcutSkill.TabIndex = 60;
		buttonSortcutSkill.Text = "Lấy Sortcut Skill";
		buttonSortcutSkill.UseVisualStyleBackColor = true;
		buttonSortcutSkill.Click += new System.EventHandler(buttonSortcutSkill_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(327, 453);
		base.Controls.Add(groupBox1);
		base.Controls.Add(tabControl1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormTest";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "TEST";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormTest_Load);
		tabControl1.ResumeLayout(performLayout: false);
		tabPage1.ResumeLayout(performLayout: false);
		tabPage1.PerformLayout();
		tabPage2.ResumeLayout(performLayout: false);
		groupBox3.ResumeLayout(performLayout: false);
		groupBox3.PerformLayout();
		groupBox2.ResumeLayout(performLayout: false);
		groupBox2.PerformLayout();
		tabPage3.ResumeLayout(performLayout: false);
		tabPage3.PerformLayout();
		tabPage4.ResumeLayout(performLayout: false);
		tabPage4.PerformLayout();
		groupBox1.ResumeLayout(performLayout: false);
		groupBox1.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	void method_4(string string_11)
	{
		base.Text = string_11;
	}
}
