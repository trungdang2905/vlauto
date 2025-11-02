using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

public class FormMain : Form
{
	private IContainer icontainer_0 = null;

	private NotifyIcon notifyIcon_0;

	private System.Windows.Forms.Timer timer_0;

	private TextBox textBoxKhoangCachAccChinh;

	private CheckBox checkBoxTimTrongthanh;

	private ComboBox comboBoxAccChinh;

	private ComboBox comboBoxIndex;

	private CheckBox checkBoxTimAccchinh;

	private Button buttonOff;

	private Button buttonAdd;

	private RichTextBox richTextBoxStatus;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Button buttonThumucAuto;

	private Button buttonToShortcut;

	private Button buttonCapnhatData;

	private Label label1;

	private Button buttonBrowseGame;

	private TextBox textBoxThuMuc;

	private TextBox textBoxHPBom;

	private TextBox textBoxThoigianBomHP;

	private CheckBox checkBoxMPBom;

	private TextBox textBoxSoluongBomHP;

	private TextBox textBoxMPBom;

	private TextBox textBoxSoluongBomMP;

	private TextBox textBoxThoigianBomMP;

	private CheckBox checkBoxBomHP;

	private TextBox textBoxBomHPDiem;

	private TextBox textBoxThoiGianBomHPDiem;

	private CheckBox checkBoxBomMPDiem;

	private TextBox textBoxSoLuongBomHPDiem;

	private TextBox textBoxBomMPDiem;

	private TextBox textBoxSoLuongBomMPDiem;

	private TextBox textBoxThoiGianBomMPDiem;

	private CheckBox checkBoxBomHPDiem;

	private TextBox textBoxPass;

	private Label label4;

	private TextBox textBoxTienMangtheo;

	private TextBox textBoxSoluongTDP;

	private CheckBox checkBoxMangtheotien;

	private CheckBox checkBoxHPTdp;

	private TextBox textBoxMPTdp;

	private CheckBox checkBoxMPTdp;

	private TextBox textBoxHpTDP;

	private ComboBox comboBoxMua1;

	private CheckBox checkBoxMuaTDP;

	private TextBox textBoxSoluongThuocDimua;

	private TextBox textBoxSoluong2;

	private CheckBox checkBoxMua2;

	private ComboBox comboBoxMua2;

	private TextBox textBoxSoluong1;

	private CheckBox checkBoxMua1;

	private TextBox textBoxIDSudung;

	private Label label11;

	private Button buttonTrial;

	private Button buttonCapnhat;

	private Button buttonDangky;

	private Button buttonIDApdung;

	private TabControl tabControl3;

	private TabPage tabPageBang1;

	private ComboBox comboBoxAccDoiMau;

	private Button buttonLogin;

	private CheckBox checkBoxPhimTat;

	private Button buttonXemMaloi;

	private TextBox textBoxChatNham;

	private CheckBox checkBoxChatNham;

	private Button buttonFormTest;

	private Button buttonTest;

	private CheckBox checkBoxTamQuet;

	private TextBox textBoxKhoangCachTiepcan;

	private TextBox textBoxPhamvi;

	private CheckBox checkBoxTiepCan;

	private CheckBox checkBoxUutienDanhquai;

	private CheckBox checkBoxDanhquai;

	private CheckBox checkBoxTuve;

	private CheckBox checkBoxChetnamIm;

	private CheckBox checkBoxNgamyBuff;

	private TextBox textBoxTimerNgamyBuff;

	private TextBox textBoxNgamyBuff;

	private Button buttonNgaMybuff;

	private Button buttonCashBua;

	private CheckBox checkBoxTuCastBua;

	private Button buttonLoaitruAccBuff;

	private ComboBox comboBoxNhatdo;

	private CheckBox checkBoxNhatdo;

	private ComboBox comboBoxUuTien;

	private Button buttonTatcaTDP;

	private Button buttonTatcaLuuruong;

	private Button buttonBungThuoc;

	private Button buttonThongke;

	private Button buttonSuadoTaicho;

	private Button buttonComboNhoithuoc;

	private Button buttonVang;

	private Button buttonXanh;

	private Button buttonTim;

	private CheckBox checkBoxAccPhuHauDoanh;

	private CheckBox checkBoxAccChinhHauDoanh;

	private CheckBox checkBoxNguHoa500l;

	private ComboBox comboBoxVaodiemBaodanh;

	private ComboBox comboBoxBentau;

	private Button buttonNopLenhbaiAll;

	private Button buttonNopLenhbai;

	private Button buttonVaotraiStopAll;

	private Button buttonVaotraiStop;

	private CheckBox checkBoxTuGiaidoc;

	private Button buttonAppDungBomMauAll;

	private Button buttonApDungMuaThuocAll;

	private TextBox textBoxSoluongBomMagic;

	private TextBox textBoxTimerBomMagic;

	private ComboBox comboBoxMuaGiaiDoc;

	private TextBox textBoxSoluongMuaGiaiDoc;

	private CheckBox checkBoxMuaGiaiDoc;

	private CheckBox checkBoxGiamRamTudong;

	private ComboBox comboBoxGameOfWeb;

	private Label label6;

	private TabPage tabPage7;

	private ComboBox comboBoxGanChieuPhai;

	private ComboBox comboBoxGanChieuTrai;

	private CheckBox checkBoxGanChieuPhai;

	private CheckBox checkBoxGanChieuTrai;

	private TabPage tabPage9;

	private CheckBox checkBoxTrinhSat;

	private Button buttonGiaiThichHaucan;

	private GroupBox GrouptTest;

	private Label label14;

	private TextBox textBoxScrMouseXY;

	private TextBox textBoxRealMouseXY;

	private TextBox textBoxScrPosXY;

	private Label label13;

	private TextBox textBoxRealPosXY;

	private CheckBox checkBoxAnThuocLag;

	private ComboBox comboBoxTheoSau;

	private CheckBox checkBoxTheoSau;

	private TextBox textBoxKhoangCachTheoSau;

	private Label labelTheoSauAll;

	private ComboBox comboBoxClickNPC;

	private TextBox textBoxClickNPCMenu;

	private CheckBox checkBoxClickNPCmenu;

	private Button buttonHuongdanHLP;

	private TextBox textBoxClickNPCSolan;

	private CheckBox checkBoxClickNPCSolan;

	private TextBox textBoxClickNPCTocdo;

	private CheckBox checkBoxGioClick;

	private NumericUpDown numericUpDownSS;

	private NumericUpDown numericUpDownMM;

	private NumericUpDown numericUpDownHH;

	private TabControl tabControlHaucan;

	private TabPage tabPageMuathuoc;

	private TabPage tabPagePhuchoi;

	private TabPage tabPageBang2;

	private NumericUpDown numericUpDownCTC;

	private Label label17;

	private ComboBox comboBoxChienTruong;

	private ComboBox comboBoxChienTruongMapPhu;

	private CheckBox checkBoxTHPCTC;

	private CheckBox checkBoxMapPhu;

	private TabControl tabControlPhutro;

	private TabPage tabPage4;

	private TabPage tabPageTinsu;

	private CheckBox checkBoxAccChinhTudieukhienCTC;

	private CheckBox checkBoxChienLongdong;

	private ComboBox comboBoxCLD;

	private CheckBox checkBoxTrain;

	private TextBox textBoxMapName;

	private ListView listViewTrain;

	private ColumnHeader columnHeader_3;

	private TabPage tabPageTinhLuyen;

	private Button buttonLuutep;

	private Button buttonDoctep;

	private Button buttonXoaToadoTrain;

	private Button buttonLayToadoTrain;

	private ColumnHeader columnHeader_4;

	private CheckBox checkBoxNhatdoDichuyenGan;

	private Button buttonApdungAllTrain;

	private CheckBox checkBoxTranhBossVang;

	private CheckBox checkBoxTDPSaimap;

	private TabPage tabPageCTC;

	private TabPage tabPageTrain;

	private CheckBox checkBoxChaydanhvong;

	private CheckBox checkBoxMuathuocPK;

	private CheckBox checkBoxChayPKNguoidung;

	private Label label24;

	private ComboBox comboBoxDoSatcuuSat;

	private Button buttonXoaIDAcChinh;

	private Button buttonBaoToado;

	private Button buttonMoGame;

	private TabControl tabControl2;

	private TabPage tabPage14;

	private TabPage tabPage17;

	private Button buttonHDD;

	private TextBox textBoxHSD;

	private Label label25;

	private Button buttonMorong;

	private Button buttonUuTien;

	private CheckBox checkBoxOluonMapphu;

	private Button buttonBungTuimau;

	private CheckBox checkBoxVeThanhKhiPKlon;

	private Button buttonAnhet;

	private ComboBox comboBoxGiamCpu;

	private Button buttonGiamCPUAll;

	private CheckBox checkBoxDameMacdinh;

	private Button buttonDame;

	private Button buttonBossAll;

	private Button buttonSuaXoa;

	private ComboBox comboBoxNoiBoss;

	private CheckBox checkBoxTuChayBoss;

	private ColumnHeader columnHeader_5;

	private TextBox textBoxPhamviNhat;

	private CheckBox checkBoxLuomrac;

	private TextBox textBoxSLThoat;

	private CheckBox checkBoxSLThoat;

	private ComboBox comboBoxXuongNgua;

	private CheckBox checkBoxHoasonMuamau500l;

	private CheckBox checkBoxTuchayMuathuoc;

	private Label labelKieudame;

	private CheckBox checkBoxPheThu;

	private Label label2;

	private Button buttonThuocTDD;

	private TextBox textBoxTocdoDanh;

	private CheckBox checkBoxAnThuocTDD;

	private Button buttonThuocLag;

	private TabControl tabControlLoc;

	private ComboBox comboBoxBosSatthu;

	private Button buttonPhimHDCTC;

	private TabControl tabControlThatThanh;

	private TabPage tabPageThatthanh;

	private TabPage tabPageTamtru;

	private Button buttonLayvitriCongTamtru;

	private TextBox textBoxCongTamtru;

	private Label label30;

	private TextBox textBoxToadoHieuthuocTamtru;

	private Label label28;

	private ComboBox comboBoxTenHieuThuocTamtru;

	private Button buttonPhimHdTamtru;

	private TextBox textBoxTDP_SL_Mana;

	private TextBox textBoxTDP_SL_Mau;

	private CheckBox checkBoxTDP_SL_Mana;

	private CheckBox checkBoxTDP_SL_Mau;

	private CheckBox checkBoxKhongLuuruong;

	private CheckBox checkBoxMana2;

	private CheckBox checkBoxMau2;

	private ComboBox comboBoxTenMana2;

	private TextBox textBoxTimerMana2;

	private TextBox textBoxRatioMana2;

	private TextBox textBoxSoluongMana2;

	private ComboBox comboBoxTenMau2;

	private TextBox textBoxSoluongMau2;

	private TextBox textBoxTimerMau2;

	private TextBox textBoxRatioMau2;

	private Button buttonThietLapDuongMon;

	private CheckBox checkBoxDuongMonBoom;

	private CheckBox checkBoxUuTienBomCuuchuyen;

	private Label label29;

	private ComboBox comboBoxOtrong;

	private CheckBox checkBoxOtrong;

	private Button buttonThoatHetgame;

	private TabPage tabPage10;

	private TextBox textBoxMenuTest;

	private Label label33;

	private Label label32;

	private ComboBox comboBoxTrangbiTest;

	private Button buttonTatcaNhanTrangbiTest;

	private Button buttonDungTatcaTrangbiTest;

	private Button buttonNhanTrangbiTest;

	private Button buttonPhimHDLoc;

	private Button buttonLocTrangbi;

	private Button buttonThietlapClickNpc;

	private CheckBox checkBoxTongKimXemSoluong;

	private LinkLabel linkLabelTrangchu;

	private Button buttonHuongDan;

	private CheckBox checkBoxRuong3;

	private CheckBox checkBoxRuong1;

	private CheckBox checkBoxRuong2;

	private CheckBox checkBoxRuong0;

	private Button buttonKhongcat;

	private Label label18;

	private CheckBox checkBoxXepdo;

	private Button buttonTimTrongthanh;

	private Label labelChuadaydu;

	private Button buttonLayVitriXaphuCTQ;

	private Label label34;

	private Label label15;

	private TextBox textBoxTimeXepdo;

	private CheckBox checkBoxNPC;

	private TextBox textBoxOso1;

	private TextBox textBoxOso2;

	private TextBox textBoxOso3;

	private CheckBox checkBoxGanTenthuoc;

	private Button buttonDenDiemKetiep;

	private CheckBox checkBoxTudongPT;

	private CheckBox checkBoxTucheHT;

	private TabPage tabPageChieuthuc;

	private Button buttonSkill120vd;

	private CheckBox checkBoxTuGiaiBua;

	private Button buttonSkill120tn;

	private CheckBox checkBoxTNXuatChieu120;

	private Button buttonDanhsachCuusat;

	private Label labelThongtinDK;

	private CheckBox checkBoxDanhquaiTrain;

	private CheckBox checkBoxTDPHettien;

	private CheckBox checkBoxToadoVong;

	private LinkLabel linkLabelPhimChaynhim;

	private TabPage tabPage15;

	private Label label38;

	private TextBox textBoxTenacTimVST;

	private TextBox textBoxThoigianVST;

	private CheckBox checkBoxBaokenhbang;

	private Button buttonPasteVST;

	private Button buttonCopyVST;

	private TextBox textBoxToadoVST;

	private TextBox textBoxMapNameVST;

	private CheckBox checkBoxRoom;

	private Button buttonMuctieu;

	private CheckBox checkBoxCungMucTieu;

	private RichTextBox richTextBoxChedoMayphu;

	private TextBox textBoxNhapSLTest;

	private TextBox textBoxNhapSoluongClickNPC;

	private Label label41;

	private CheckBox checkBoxMuaThontran;

	private CheckBox checkBoxDanhQuaiTrenduongdi;

	private TabControl tabControl6;

	private TabPage tabPage16;

	private TabPage tabPage18;

	private Label label42;

	private CheckBox checkBoxQuayquai;

	private TabControl tabControlChuyenSkill;

	private TabPage tabPage19;

	private ComboBox comboBoxChuyenChieuTrai1;

	private ComboBox comboBoxChuyenChieuTrai2;

	private TextBox textBoxChuyenChieuTrai3;

	private ComboBox comboBoxChuyenChieuTrai3;

	private TextBox textBoxChuyenChieuTrai2;

	private TextBox textBoxChuyenChieuTrai1;

	private CheckBox checkBoxChuyenChieuTrai1;

	private CheckBox checkBoxChuyenChieuTrai2;

	private CheckBox checkBoxChuyenChieuTrai3;

	private TabPage tabPage20;

	private ComboBox comboBoxChuyenChieuPhai1;

	private ComboBox comboBoxChuyenChieuPhai2;

	private TextBox textBoxChuyenChieuPhai3;

	private ComboBox comboBoxChuyenChieuPhai3;

	private TextBox textBoxChuyenChieuPhai2;

	private TextBox textBoxChuyenChieuPhai1;

	private CheckBox checkBoxChuyenChieuPhai1;

	private CheckBox checkBoxChuyenChieuPhai2;

	private CheckBox checkBoxChuyenChieuPhai3;

	private Button buttonFixGameTuthoat;

	private CheckBox checkBoxGameHu;

	private GroupBox groupBox1;

	private ComboBox comboBoxTranphai1;

	private ComboBox comboBoxTranphai2;

	private TextBox textBoxTranphai2;

	private TextBox textBoxTranphai1;

	private CheckBox checkBoxTranphai1;

	private CheckBox checkBoxTranphai3;

	private ComboBox comboBoxTranphai3;

	private CheckBox checkBoxTranphai2;

	private TextBox textBoxTranphai3;

	private CheckBox checkBoxSudungDataNguoidung;

	private Button buttonSosanh;

	private ComboBox comboBoxChuyenThuoc;

	private TextBox textBoxSoluongChuyenthuoc;

	private CheckBox checkBoxTubaoDanh;

	private CheckBox checkBoxVaomapAchinh;

	private Button buttonTuTimWeb;

	private Button buttonLuuCauhinhAll;

	private CheckBox checkBoxTatMuamauTK;

	private Button buttonToadoPK;

	private CheckBox checkBoxChayTinsu;

	private CheckBox checkBoxBatdauVanSuthong;

	private Label label9;

	private Label label3;

	private ComboBox comboBoxTinSu;

	private Button buttonPhimTat;

	private CheckBox checkBoxNhatqua;

	private Label labelLocdo;

	private CheckBox checkBoxBossSatthu;

	private GroupBox groupBox6;

	private GroupBox groupBox4;

	private CheckBox checkBoxONha;

	private Button buttonSatthuAll;

	private Button buttonNhatquaAll;

	private Button buttonTinsuAll;

	private CheckBox checkBoxGhepSTG;

	private Button buttonGhepSTG;

	private GroupBox groupBox3;

	private CheckBox checkBoxBossSTtuhuy;

	private TabPage tabPage3;

	private CheckBox checkBoxMuaKytrancac;

	private CheckBox checkBoxGopVatpham;

	private Label label16;

	private ComboBox comboBoxMuaVatpham;

	private PictureBox pictureBoxQC;

	private TextBox textBoxIdMua;

	private Button buttonHelp;

	private ComboBox comboBoxPk;

	private TextBox textBox3;

	private TextBox textBox2;

	private TextBox textBox1;

	private GroupBox groupBox5;

	private TextBox textBoxMuadungSoLuong;

	private CheckBox checkBoxMuaDungSoluong;

	private CheckBox checkBoxBoquaMaKTC;

	private Button buttonHelpMua;

	private Button buttonStopNhatqua;

	private Label label12;

	private ComboBox comboBoxPhuong;

	private Button buttonTHP;

	private ComboBox comboBoxTHP;

	private Button buttonBaoBoss;

	private CheckBox checkBoxBosBaobos;

	private Button buttonBoss;

	private Button buttonNamIm;

	private Button buttonPT;

	private TextBox textBoxChuyenThuocMin;

	private Label label5;

	private CheckBox checkBoxTuChuyenThuoc;

	private CheckBox checkBoxRuongBH;

	private TabControl tabControl5;

	private TabPage tabPage6;

	private TabPage tabPage11;

	private Button buttonHDChuyenthuoc;

	private Label label8;

	private CheckBox checkBoxBamPhimCong;

	private CheckBox checkBoxTTL;

	private Button buttonDocCauhinh;

	private Button buttonAchinh;

	private Button buttonBien;

	private CheckBox checkBoxChayRunAdmin;

	private TextBox textBoxPhamviNhatqua;

	private Label label7;

	private TabPage tabPageTongKim;

	private Button buttonMayphuLayToado;

	private Button buttonMayphuXoaToado;

	private TextBox textBoxMayphuToado;

	private CheckBox checkBoxMayphuToado;

	private CheckBox checkBoxDenToadoUser;

	private Button buttonLayToado;

	private Button buttonXoaToado;

	private TextBox textBoxToadoDen;

	private CheckBox checkBoxDenToadoALL;

	private Button buttonHuongdanCanhbos;

	private GroupBox groupBox2;

	private CheckBox checkBoxLocTrangbiNPC;

	private CheckBox checkBoxLocTrangbiNhapSL;

	private CheckBox checkBoxTKThanhTruot;

	private Button buttonDoSat;

	private CheckBox checkBoxDanhHieuuy;

	private TextBox textBoxTruotTK;

	private CheckBox checkBoxThanhTruotSudung;

	private LinkLabel linkLabelPhimCauca;

	private CheckBox checkBoxMuaKTC;

	private Button buttonKyTranCac;

	private Button buttonMuathuocBaovat;

	private TabPage tabPage5;

	private RichTextBox richTextBox1;

	private Label label20;

	private Label label19;

	private Label label10;

	private TabPage tabPage8;

	private CheckBox checkBoxVuotAi;

	private Button buttonThoatGame;

	private CheckBox checkBoxDiemTapket;

	private Button buttonDiemTapket;

	private CheckBox checkBoxConLon;

	private CheckBox checkBoxBossSTKhongLamHaucan;

	private TabPage tabPageTest;

	private Button buttonHuyenTinh;

	private CheckBox checkBoxAceptBH;

	private Button buttonRaovat;

	private RichTextBox richTextBoxBHO;

	private CheckBox checkBoxChoPTdanhsach;

	private TextBox textBoxTimerPT;

	private LinkLabel linkLabelHelpTinsu;

	private Button buttonTatMua;

	private CheckBox checkBoxQuangThuoc;

	private Button buttonQuangThuoc;

	private GroupBox groupBox7;

	private Button buttonHelpClickNpc;

	private Label labelMuaGopStopAll;

	private Label labelMuaGopStop;

	private Label labelMuaSudung;

	private Label labelMuaGopStart;

	private Button buttonClickNpcStopAll;

	private Button buttonClickNpcAll;

	private Button buttonClickNpcSingle;

	private Button buttonMuaGopAll;

	private Button buttonMuaSudungAll;

	private TabPage tabPage12;

	private Label label21;

	private Button buttonDsBanVatpham;

	private CheckBox checkBoxBanVpham;

	private Button buttonBanVatphamRac;

	private Button buttonOpenAllWeb;

	private ComboBox comboBoxTrinhsat;

	private Label labelToadoTrinhsat;

	private CheckBox checkBoxBaoKeylog;

	private Label label22;

	private TextBox textBoxClickMenuTS;

	private CheckBox checkBoxDenToadoLeave;

	private CheckBox checkBoxTHPChienLong;

	private GroupBox groupBox8;

	private TabPage tabPageTamMondai;

	private Label label26;

	private ComboBox comboBoxCTC;

	private Label label27;

	private Button buttonLayMapTamMondai;

	private TextBox textBoxTamMonDaiMapId;

	private Button buttonMapTamMondaiMacdinh;

	private RichTextBox richTextBox2;

	private Label label23;

	private Button buttonResetAuto;

	private Button buttonTamMonDaiHD;

	public static string string_1 = "KY" + '\u0081' + "Keoxe " + Class11.char_0;

	public static string string_2 = "KYKeoxe.exe";

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static string string_3 = string.Empty;

	public static int int_0 = -1;

	public static int int_1 = 0;

	public static string[,] string_4 = new string[82, 6]
	{
		{
			"vlbisu.com",
			"VËt phÈm",
			"55",
			null,
			"vlbs.exe",
			null
		},
		{
			"hoiucvl.com",
			"VËt PhÈm",
			"0",
			null,
			"Game.exe",
			null
		},
		{
			"thiendiavolam.com",
			"MÆt n¹ di thuËt",
			"33",
			null,
			"vggame.exe",
			null
		},
		{
			"volammienphi.net",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamhkmp.com",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"JXVn.net",
			"B¶o vËt",
			"4",
			null,
			"vggame.exe",
			null
		},
		{
			"www.vlhoiuc.com",
			"VËt phÈm",
			"5",
			null,
			"Game.exe",
			null
		},
		{
			"khác",
			"VËt PhÈm",
			"0",
			null,
			"Game.exe",
			null
		},
		{
			"volamtuyetpham.com",
			"HOT",
			"7",
			"2",
			"VoLamTuyetPham.exe",
			"1"
		},
		{
			"hiephanhthienha.com",
			"Event",
			"9",
			"3",
			"Game.exe",
			"1"
		},
		{
			"jxtieungao.com",
			"T¹p Hãa",
			"31",
			null,
			"Game.exe",
			null
		},
		{
			"volampk.net",
			"VËt phÈm",
			"1",
			null,
			"vgGame.exe",
			null
		},
		{
			"volamxmen.com",
			"VËt phÈm",
			"34",
			null,
			"Game.exe",
			null
		},
		{
			"aevolam.com",
			"New Hot",
			"17",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamdevuong.com",
			"Hç trî",
			"40",
			"3",
			"Game.exe",
			"1"
		},
		{
			"jxhuyenthoai.com",
			"VËt phÈm",
			"2",
			null,
			"Game.exe",
			null
		},
		{
			"vl2017.com",
			"MÆt n¹",
			"3",
			"1",
			"vggame.exe",
			"1"
		},
		{
			"volamxaxu.com",
			"T¹p hãa",
			"28",
			"1",
			"game.exe",
			"1"
		},
		{
			"volamvietpk.net",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"vltruyenky.net",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"congdongvolam.com",
			"VÝp",
			"12",
			"1",
			"Game.exe",
			"1"
		},
		{
			"jxvinhvien.com - sonhaxatac.net",
			"Th­ TÞch",
			"29",
			null,
			"jxonline_y.exe",
			null
		},
		{
			"volamcongthanhchien.com",
			"Hç Trî",
			"30",
			null,
			"Game.exe",
			null
		},
		{
			"trungnguyentruyenky.com",
			"Hç Trî",
			"30",
			null,
			"Game.exe",
			null
		},
		{
			"Volamtk.net",
			"T¹p hãa",
			"28",
			"1",
			"Game.exe",
			"1"
		},
		{
			"vltrungnguyen.com",
			"B¶o vËt",
			"37",
			null,
			"VLTrungNguyen.exe",
			null
		},
		{
			"volamtd.net",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamcuulong.net",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamtestvinhvien.com",
			"HOT",
			"32",
			"0",
			"Game.exe",
			"1"
		},
		{
			"vlbv.net",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamngoaisu.com",
			"VËt phÈm",
			"1",
			"2",
			"vlbs.exe",
			"1"
		},
		{
			"volambachkim.com",
			"VÝp",
			"10",
			"1",
			"Game.exe",
			"1"
		},
		{
			"volamtestmienphi.net",
			"VËt phÈm",
			"31",
			null,
			"Game.exe",
			null
		},
		{
			"vocongtruyenky.com",
			"Hç Trî",
			"39",
			null,
			"Game.exe",
			null
		},
		{
			"haokietvolamvn.com",
			"T¹p hãa",
			"28",
			"1",
			"game.exe",
			"1"
		},
		{
			"jxcongthanh.net",
			"Hot",
			"43",
			null,
			"Game.exe",
			null
		},
		{
			"volamthienha.net",
			"T¹p hãa",
			"36",
			"1",
			"Game.exe",
			"1"
		},
		{
			"volamnguba.net",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"tuyetdinhpk.net",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"tuyetdinhvolam.net",
			"Tµng kinh c\u00b8c",
			"44",
			null,
			"Game.exe",
			null
		},
		{
			"volamtest.com",
			"T¹p Hãa",
			"31",
			null,
			"Game.exe",
			null
		},
		{
			"vltkctc.com",
			"T¹p Hãa",
			"31",
			null,
			"Game.exe",
			null
		},
		{
			"tuoithovolam.com",
			"T¹p Hãa",
			"45",
			null,
			"Game.exe",
			null
		},
		{
			"bisutruyenky.com - vlfree.com",
			"T¹p hãa",
			"46",
			null,
			"game.exe",
			null
		},
		{
			"volamkhtd.com",
			"Ho¹t §éng",
			"23",
			"1",
			"Game.exe",
			"1"
		},
		{
			"jxbisu.net",
			"Ho¹t §éng",
			"47",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamtinhnghia.com",
			"T¹p hãa",
			"45",
			null,
			"Game.exe",
			null
		},
		{
			"cucphamvolam.net",
			"T¹p hãa",
			"28",
			"1",
			"game.exe",
			"1"
		},
		{
			"volamhoangde.com",
			"T¹p hãa",
			"41",
			"3",
			"vggame.exe",
			"1"
		},
		{
			"phonghoalienthanh.net",
			"VËt PhÈm",
			"15",
			null,
			"Game.exe",
			null
		},
		{
			"volamhuynhde.net",
			"   Hot   ",
			"32",
			"0",
			"Game.exe",
			"1"
		},
		{
			"tieungaogiangho.net",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"bavuongtinh.net",
			"VËt phÈm",
			"1",
			null,
			"vgGame.exe",
			null
		},
		{
			"ctcfree.com",
			"T¹p hãa",
			"19",
			null,
			"Game.exe",
			null
		},
		{
			"vldevuong.com",
			"VËt PhÈm",
			"31",
			null,
			"Game.exe",
			null
		},
		{
			"volamhoason.com",
			"VËt PhÈm",
			"49",
			null,
			"Game.exe",
			null
		},
		{
			"volamtranhba.net",
			"T¹p hãa",
			"19",
			"3",
			"vggame.exe",
			"1"
		},
		{
			"volamtieungao.com",
			"HOT",
			"32",
			"0",
			"Game.exe",
			"1"
		},
		{
			"volamtruyenkytest.com",
			"T¹p Hãa",
			"56",
			null,
			"Game.exe",
			null
		},
		{
			"volamthienlong.com",
			"   Hot   ",
			"32",
			"0",
			"Game.exe",
			"1"
		},
		{
			"vlthieuhao.com",
			"BÝ kÝp",
			"50",
			"4",
			"Game.exe",
			"1"
		},
		{
			"volam1.net",
			"T¹p hãa",
			"19",
			null,
			"Game.exe",
			null
		},
		{
			"hoainiemvolam.com",
			"HOT",
			"52",
			null,
			"Game.exe",
			null
		},
		{
			"huyenthoaivolam.com",
			"  HOT  ",
			"53",
			"3",
			"Game.exe",
			"1"
		},
		{
			"vlthanthoai.com",
			"Ho¹t §éng",
			"54",
			"3",
			"Game.exe",
			"1"
		},
		{
			"vlsieunhan.top",
			"VËt phÈm",
			"28",
			"1",
			"Game.exe",
			"1"
		},
		{
			"gianghotruyenky.net",
			"MÆt n¹ di thuËt",
			"33",
			null,
			"vggame.exe",
			null
		},
		{
			"hoanhtaothienquan.info",
			"Ho¹t §éng",
			"35",
			"1",
			"Game.exe",
			"1"
		},
		{
			"volamsinhvien.com",
			"Tµng kinh c\u00b8c",
			"44",
			null,
			"Game.exe",
			null
		},
		{
			"thienhatranhhung.com",
			" TÝnh N\u00a8ng ",
			"48",
			"0",
			"Game.exe",
			"1"
		},
		{
			"volamhaingoai.com",
			"T¹p hãa",
			"36",
			"1",
			"Game.exe",
			"1"
		},
		{
			"sonhaxatac.com",
			"Hç Trî",
			"30",
			null,
			"vggame.exe",
			null
		},
		{
			"vipvolam.com",
			"VËt phÈm",
			"2",
			null,
			"Game.exe",
			null
		},
		{
			"cuunientrungphung.com",
			"Ho¹t §éng",
			"41",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volam.uk",
			"T¹p hãa",
			"57",
			"1",
			"Game.exe",
			"1"
		},
		{
			"volamhaingoai.com",
			"T¹p hãa",
			"36",
			"1",
			"Game.exe",
			"1"
		},
		{
			"volamtinhnghia.com",
			"T¹p Hãa",
			"45",
			null,
			"Game.exe",
			null
		},
		{
			"volamtruyenki.net",
			"BÝ kÝp",
			"31",
			null,
			"Game.exe",
			null
		},
		{
			"vlthiende.com",
			"VËt phÈm",
			"31",
			null,
			"Game.exe",
			null
		},
		{
			"volamhaohoa.com",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamnguyetlong.com",
			"T¹p Hãa",
			"45",
			null,
			"Game.exe",
			null
		},
		{
			"hoasonvolam.ddns.net",
			"HOT",
			"32",
			"0",
			"Game.exe",
			"1"
		}
	};

	private static string[,] string_5 = new string[11, 6]
	{
		{
			"volamhoingo.com",
			"Hç Trî",
			"30",
			null,
			"Game.exe",
			null
		},
		{
			"Kvolam.com",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"huyetchien.net",
			"Hot",
			"8",
			"2",
			"Game.exe",
			"1"
		},
		{
			"vocongthanky.com",
			"VËt phÈm",
			"31",
			null,
			"Game.exe",
			null
		},
		{
			"volamsieuthan.com",
			"Hç trî",
			"40",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamtieudieu.com",
			" TÝnh N\u00a8ng ",
			"48",
			"0",
			"Game.exe",
			"1"
		},
		{
			"volamnguhiep.online",
			"T¹p hãa",
			"19",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamhayghe.com",
			"VËt phÈm",
			"28",
			"1",
			"game.exe",
			"1"
		},
		{
			"volamhaohuu.com",
			"Ho¹t §éng",
			"35",
			"1",
			"Game.exe",
			"1"
		},
		{
			"volamtanphong.com",
			"  HOT  ",
			"51",
			"3",
			"Game.exe",
			"1"
		},
		{
			"volamtienty.com",
			"VËt phÈm",
			"28",
			"1",
			"Game.exe",
			"1"
		}
	};

	public static string string_6 = "Cập nhật " + string_1 + "||- Thêm map Tam Môn đài ở phần ctc, khi đánh bạn chọn WAR -> CTC và trong tab CTC bạn chọn Tam Môn đài nhé.||- Thêm web volamnguyetlong, volamhaohoa.com, vlthiende.com, volamtruyenki.net, cuunientrungphung.com, volam.uk, thienhatranhhung.com, volamhaingoai.com, sonhaxatac.com, vipvolam.com và volamtinhnghia.com||PHẦN TAB CÀI GAME CỦA AUTO:||- Hãy điều chỉnh lại Web của game nếu chưa đúng, ac sẽ không đi được THP nếu không đúng web.|- Hãy bấm nút Reset cấu hình auto nếu ac game thường xuyên bị lỗi nhé.||===========================||Tính năng đánh Vượt ải (bảng 2): Khi gặp quái phản dame (hoặc các quái xung quanh quái phản dame khoảng cách 300) sẽ bỏ qua, tránh bị đột tử.||Bổ sung chức năng thêm ac chính dự phòng, bấm phím F2 để chuyển đổi nhanh ac chính. Các bạn bấm vào nút < Ac chính > để thiết lập nhé.||===========================|Hướng dẫn lần đầu sử dụng:||Nếu xài Windows 7, 8 hoặc 10 thì bắt buộc phải bấm chuột phải vào tệp KYKeoxe, rồi chọn dòng Run as Administrators... để chạy auto. Windows XP thì bấm đúp vào auto chạy bình thường. Sau đó vào tab Cài game của auto rồi chọn:||1. Trang web của game:... (nếu không có thì chọn dòng <khác>)|2. Bấm nút [A] trên auto, nếu không thấy tên ac thì check vào mục [v] Sử dụng cập nhật data game, sau đó bấm nút Cập nhật data game, chờ hoàn thành thì sử dụng||Mặc định khi mới sử dụng sẽ là giảm CPU mức 1 (màn hình game màu đen), các bạn bấm F10 để bỏ giảm nếu muốn.||Các dòng chữ màu nâu đỏ là áp dụng cho toàn cục, còn màu đen hoặc xanh thì áp dụng cho từng ac.||Ví dụ: Bỏ check <đánh quái> (màu nâu đỏ) thì tất cả ac đều ngưng đánh quái. Còn nếu check vào <chết nằm im> thì chỉ ac riêng ac được chọn khi chết sẽ nằm im, các ac khác thì vẫn về thành bình thường.||Lưu ý không nên dùng chung auto vlbs_pk, vì khi dùng chung rất dễ diss game.||=============================================|CẬP NHẬT CŨ:|- Chức năng bán vật phẩm theo danh sách (phụ trợ - event - bán)|- Chức năng Rao vặt và chức năng tự cho phép ac gia nhập bang hội (mục Phụ trợ).|- Chức năng đánh đơn đấu: tối ưu đánh.|- Nhằm mục đích để các bạn mới làm quen auto dễ dàng sử dụng, nên kể từ phiên bản auto này trở đi sẽ không đòi hỏi phải cập nhật data mới sử dụng được (tức là bật auto lên là dùng được).|- Lưu ý các bạn thoát ac thì thoát luôn game, đừng thoát ac A rồi lại log ac B trên cùng 1 game, vì auto sẽ lưu config ac A vào ac B dẫn đến hiện tượng ac B không đánh được. Bạn nào dính trường hợp này thì tốt nhất xóa hết auto, sau đó lên web kimyen.net tải lại auto.||KYKeoxe (Kim Yến Kéo xe) dùng cho các game lậu hiện tại.|Mọi đóng góp ý kiến xin liên hệ:||- Web: http://kimyen.net|- Inbox fb: https://www.facebook.com/auto.kimyen|";

	public static int int_2 = 0;

	public static int int_3 = 1;

	public static bool bool_2 = false;

	public static bool bool_3 = false;

	public static int int_4 = Class55.smethod_3("flagCoClickVaoNPC", 0, "1");

	public static int int_5 = Class55.smethod_3("flagChinhxacTenVatpham", 0, "1");

	public static int int_6 = 0;

	public static int int_7 = 0;

	public static int int_8 = Class55.smethod_3("flagBaoroom", 0, "0");

	public static int int_9 = Class55.smethod_3("flagKhoaChatmat", 0, "1");

	public static int int_10 = Class55.smethod_3("KhongHienThiVideoHelp", 0, "0");

	public static int int_11 = Class55.smethod_3("flagLienthongMapAB", 0, "1");

	public static int int_12 = Class55.smethod_3("SoluongThuocMoilanMo", 0, "10");

	public static int int_13 = Class55.smethod_3("PCDKhongMoTui", 0, "1");

	public static int int_14 = Class55.smethod_3("flagBaoCuusatMat", 0, "1");

	public static int int_15 = Class55.smethod_3("flagBaoCuusatBang", 0, "1");

	public static int int_16 = Class55.smethod_3("flagBaoCuusatPhucan", 0, "0");

	public static int int_17 = Class55.smethod_3("flagLuonGanPhimtat", 0, "1");

	public static int int_18 = 1;

	public static int int_19 = Class55.smethod_3("flagKhongChaybo", 0, "1");

	public static int int_20 = Class55.smethod_3("IndexPK", 0, "0");

	public static int int_21 = Class55.smethod_3("flagTimAccchinh", 0, "1");

	public static int int_22 = Class55.smethod_3("flagTimtrongthanh", 0, "1");

	public static int int_23 = Class55.smethod_3("KhoangcachAccchinh", 0, "200");

	public static int int_24 = 0;

	public static int int_25 = 0;

	public static int int_26 = Class55.smethod_3("TamMonDaiMapID", 0, "221");

	public static int int_27 = Class55.smethod_3("fQuangThuocAchinh", 0, "1");

	public static int int_28 = Class55.smethod_3("fQuangThuocTDP", 0, "0");

	public static int int_29 = Class55.smethod_3("fMuaNoiChiendau", 0, "0");

	public static int int_30 = Class55.smethod_3("flagDanhnguoi", 0, "1");

	public static int int_31 = Class55.smethod_3("flagDanhquai", 0, "1");

	public static int int_32 = Class55.smethod_3("flagUutienBoss", 0, "0");

	public static int int_33 = Class55.smethod_3("flagCungMuctieu", 0, "1");

	public static int int_34 = Class55.smethod_3("flagTutimMuctieu", 0, "1");

	public static int int_35 = 1;

	public static int int_36 = Class55.smethod_3("BossTruocNguoiSau", 0, "0");

	public static int int_37 = Class55.smethod_3("ChetNamImAll", 0, "0");

	public static int int_38 = Class55.smethod_3("fNamImONOFF", 0, "0");

	public static int int_39 = 10;

	public static int int_40 = Class55.smethod_3("flagOLuonMapPhu", 0, "1");

	public static string string_7 = Class11.smethod_16(Class55.smethod_6("TenAcCantimVST", 0));

	public static int int_41 = Class55.smethod_3("flagBaoKenhBangVST", 0, "0");

	public static int int_42 = Class55.smethod_3("flagBaoKenhRoomVST", 0, "1");

	public static int int_43 = Class55.smethod_3("ThoigianVST", 0, "30");

	public static int[] int_44 = new int[2]
	{
		0,
		Class55.smethod_3("BaodanhTK", 0, "0")
	};

	public static int int_45 = Class55.smethod_3("flagVaoMapCTCCoAcchinh", 0, "1");

	public static GStruct42[] gstruct42_0 = null;

	public static int[] int_46 = null;

	public static string string_8 = "nhap_id_vao_day";

	public static string string_9 = Class55.smethod_6("textIDSudung", 0, string_8);

	public static int[] int_47 = new int[3]
	{
		Class55.smethod_3("IdexVitrithuoc1", 0, "0"),
		Class55.smethod_3("IdexVitrithuoc2", 0, "0"),
		Class55.smethod_3("IdexVitrithuoc3", 0, "0")
	};

	public static int int_48 = Class55.smethod_3("flagPassKeoNhieumay", 0, "1");

	public static int int_49 = Class55.smethod_3("PassKeoNhieumay", 0, "1234");

	public static int int_50 = Class55.smethod_3("flagDanhDenchet", 0, "0");

	public static int int_51 = Class55.smethod_3("KCAcdanhTiepcan", 0, "350");

	public static string[] string_10 = new string[4]
	{
		"WAR (PK -Boss)",
		"TK (Tống Kim - PHLT)",
		"CTC (Chiến trường CTC)",
		"ĐƠN ĐẤU"
	};

	public static string[] string_11 = new string[3]
	{
		"Đánh Thất thành",
		"Đánh Tam trụ",
		"Đánh Tam môn đài"
	};

	public static string[,] string_12 = new string[32, 2]
	{
		{
			"Lâm An",
			"176"
		},
		{
			"Biện Kinh",
			"37"
		},
		{
			"Dương Châu",
			"80"
		},
		{
			"Phượng Tường",
			"01"
		},
		{
			"DĐại Lý",
			"162"
		},
		{
			"Thành Đô",
			"11"
		},
		{
			"Tương Dương",
			"78"
		},
		{
			"...",
			""
		},
		{
			"Ba Lăng huyện",
			"53"
		},
		{
			"Giang Tân thôn",
			"20"
		},
		{
			"Đạo Hương thôn",
			"101"
		},
		{
			"Chu Tiên trấn",
			"100"
		},
		{
			"Long Tuyền thôn",
			"174"
		},
		{
			"Thạch Cổ trấn",
			"153"
		},
		{
			"Vĩnh Lạc trấn",
			"99"
		},
		{
			"Long Môn trấn",
			"121"
		},
		{
			"...",
			""
		},
		{
			"Bắc Trường Bạch",
			"322"
		},
		{
			"Nam Trường Bạch",
			"321"
		},
		{
			"Khỏa Lang động",
			"75"
		},
		{
			"Phong Lăng độ",
			"336"
		},
		{
			"Mạc Cao Quật",
			"340"
		},
		{
			"1 Sa mạc",
			"225"
		},
		{
			"2 Sa mạc",
			"226"
		},
		{
			"3 Sa mạc",
			"227"
		},
		{
			"Sa mạc địa biểu",
			"224"
		},
		{
			"...",
			""
		},
		{
			"Vận tiêu 1",
			"b¶n ®å kh|iÓm VËn Tiªu|Ën tiªu cæng 1"
		},
		{
			"Vận tiêu 2",
			"b¶n ®å kh|iÓm VËn Tiªu|Ën tiªu cæng 2"
		},
		{
			"Vận tiêu 3",
			"b¶n ®å kh|iÓm VËn Tiªu|Ën tiªu cæng 3"
		},
		{
			"...",
			""
		},
		{
			"Hướng dẫn",
			""
		}
	};

	public static string[,] string_13 = new string[5, 2]
	{
		{
			"Đông",
			"®«ng|§«ng"
		},
		{
			"Tây",
			"t©y"
		},
		{
			"Nam",
			"nam"
		},
		{
			"Bắc",
			"b¾c"
		},
		{
			"T.Tâm",
			"t©m"
		}
	};

	public static int int_52 = 0;

	public static string string_14 = Class11.smethod_16(Class55.smethod_6("AccChinhNameA", 0));

	private static GStruct42 gstruct42_1 = new GStruct42
	{
		int_129 = 0
	};

	private static string string_15 = Class11.smethod_16(Class55.smethod_6("TenAccdoiMau", 0));

	private static string[] string_16 = null;

	public static int[] int_53 = new int[2]
	{
		Class55.smethod_3("flagMuaTDP_0", 0, "1"),
		Class55.smethod_3("flagMuaTDP_1", 0, "4")
	};

	public static int int_54 = Class55.smethod_3("ValueThuocDimua", 0, "10");

	public static int int_55 = Class55.smethod_3("flagSuadoTaichoEx", 0, "1");

	public static int int_56 = Class55.smethod_3("flagKhongSuaTK", 0, "1");

	public static int int_57 = Class55.smethod_3("flagLuonSuaMua", 0, "1");

	public static int int_58 = Class55.smethod_3("flagSudoBachKim", 0, "1");

	public static int int_59 = Class55.smethod_3("fSuaPhichiendau", 0, "0");

	public static int[] int_60 = new int[2]
	{
		Class55.smethod_3("fSuado1_0", 0, "60"),
		Class55.smethod_3("fSuado1_1", 0, "10")
	};

	public static int int_61 = 1;

	public static int int_62 = Class55.smethod_3("flagGiamRamtudong", 0, "1");

	public static int int_63 = Class55.smethod_3("flagChatNhamEx", 0, "0");

	public static string string_17 = Class55.smethod_6("textChatNhams", 0, "(dz)" + string_1 + " - htt p:// kimyen . n e t");

	public static int int_64 = Class55.smethod_3("flagLoaiboGameHu", 0, "0");

	public static int int_65 = Class55.smethod_3("flagBaoKeylog", 0, "1");

	public static string string_18 = Class55.smethod_6("NameMuaGop", 0);

	public static int int_66 = Class55.smethod_3("flagMuaKTC", 0, "0");

	public static int int_67 = Class55.smethod_3("flagMuaGop", 0, "1");

	public static bool bool_4 = false;

	public static int[] int_68 = new int[2]
	{
		Class55.smethod_3("MDSL0", 0, "0"),
		Class55.smethod_3("MDSL1", 0, "1")
	};

	public static int int_69 = Class55.smethod_3("fThanhTruotSudung", 0, "0");

	public static int int_70 = Class55.smethod_3("fDenToado", 0, "0");

	public static int int_71 = Class55.smethod_3("fDenToadoLeave", 0, "1");

	public static int[] int_72 = new int[4]
	{
		Class55.smethod_3("fMayPhuDenToado_0", 0, "0"),
		Class55.smethod_3("fMayPhuDenToado_1", 0, "0"),
		Class55.smethod_3("fMayPhuDenToado_2", 0, "0"),
		Class55.smethod_3("fMayPhuDenToado_3", 0, "0")
	};

	public static bool bool_5 = false;

	public static string[] string_19 = null;

	private static string[] string_20 = null;

	public static int int_73 = -1;

	private bool bool_6 = false;

	public static string[] string_21 = new string[11]
	{
		"Tiền và HK-BK",
		"<= 1 ô",
		"<= 1 ô màu",
		"<= 2 ô",
		"<= 2 ô màu",
		"<= 3 ô",
		"<= 3 ô màu",
		"<= 4 ô",
		"<= 4 ô màu",
		"Đồ màu",
		"Tất cả"
	};

	public static string[] string_22 = new string[5]
	{
		"1 ô",
		"2 ô",
		"3 ô",
		"4 ô",
		"6 ô"
	};

	public static string[] string_23 = new string[2]
	{
		"Khoảng cách",
		"Ngũ hành"
	};

	public static string[] string_24 = new string[4]
	{
		"Trên ngựa",
		"Xuống ngựa",
		"Tự động",
		"Người dùng điều khiển"
	};

	public static int int_74 = 150;

	private string[] string_25 = new string[2]
	{
		"Bên Tống",
		"Bên Kim"
	};

	private static string[] string_26 = new string[2]
	{
		"Thiên Bảo khố",
		"Phong Kỳ"
	};

	public static int int_75 = Class55.smethod_3("nDobenOut", 0, "1");

	public static int int_76 = Class55.smethod_3("nDobenThap", 0, "5");

	public static int int_77 = Class55.smethod_3("flagThodiaphuDobenThap", 0, "1");

	public static int int_78 = Class55.smethod_3("ThoigianSua", 0, "60");

	public static int int_79 = Class55.smethod_3("flagDoiPKTheoAccChinh", 0, "1");

	public static int int_80 = Class55.smethod_3("flagTrolaiDiemcu", 0, "0");

	public static int int_81 = Class55.smethod_3("flagKhongDanhCapnho", 0, "1");

	public static int int_82 = Class55.smethod_3("ValueCapBoqua", 0, "10");

	public static int int_83 = Class55.smethod_3("flagAccChinhRoiHauDoanh", 0, "0");

	public static int int_84 = Class55.smethod_3("flagAccPhuChoAccChinh", 0, "1");

	public static int int_85 = Class55.smethod_3("flagRabangTrinhsat", 0, "0");

	public static int int_86 = 0;

	public static int int_87 = Class55.smethod_3("TongKimXemSoluong", 0, "1");

	public static int[] int_88 = new int[2]
	{
		Class55.smethod_3("TruotTK0", 0, "0"),
		Class55.smethod_3("TruotTK1", 0, "100")
	};

	public static int[] int_89 = null;

	public static int int_90 = Class55.smethod_3("fHieuUyTK", 0, "1");

	public static int int_91 = Class55.smethod_3("flagMuaNguHoa500l", 0, "0");

	public static int int_92 = Class55.smethod_3("flagMuaThonTran", 0, "0");

	public static int int_93 = Class55.smethod_3("flagTNBamPhim", 0, "0");

	public static int int_94 = Class55.smethod_3("TNIdexPhim", 0, "0");

	public static int int_95 = Class55.smethod_3("KhoangCachLenNguaEx", 0, "500");

	public static int int_96 = Class55.smethod_3("flagXuongNguaSansang", 0, "1");

	public static int int_97 = Class55.smethod_3("KhongdanhCungBang", 0, "0");

	public static int int_98 = Class55.smethod_3("flagIndexBentau", 0, "1");

	public static string[] string_27 = new string[7]
	{
		"1. Đi Bến 1 - Phong lăng độ",
		"2. Đi Bến 2 - Phong lăng độ",
		"3. Đi Bến 3 - Phong lăng độ",
		"4. Đi Vi Sơn đảo",
		"5. Đi Vi Sơn đảo - Tự mua LB ở KTC",
		"6. Click vào NPC gần nhất",
		"7. Lấy Menu Text trong game"
	};

	public static int int_99 = Class55.smethod_3("flagTHPCTC", 0, "0");

	public static int int_100 = Class55.smethod_3("IdexChientruongChinh", 0, "0");

	public static int int_101 = Class55.smethod_3("flagSudungMapphuEx", 0, "0");

	public static int int_102 = Class55.smethod_3("IdexChientruongPhu", 0, "1");

	public static int int_103 = Class55.smethod_3("IdexMenuTHPChientruong", 0, "3");

	public static int int_104 = Class55.smethod_3("flagThpCLD", 0, "0");

	public static int int_105 = 10;

	public static int int_106 = Class55.smethod_3("CTCAchinhTudieuKhien", 0, "0");

	public static int int_107 = 0;

	public static int int_108 = 0;

	public static int int_109 = Class55.smethod_3("flagPhandame", 0, "0");

	public static int int_110 = Class55.smethod_3("PhamviKhinhcong", 0, "300");

	public static int int_111 = Class55.smethod_3("fThongbaoTHP", 0, "0");

	private static string[] string_28 = new string[4]
	{
		"Tránh xa",
		"Thổ địa phù",
		"Đánh trả",
		"Thoát game"
	};

	public static string[] string_29 = new string[3]
	{
		"Giảm CPU mức 0 (khôi phục ban đầu)",
		"Giảm CPU mức 1 (khoảng 1/3 lần)",
		"Giảm CPU mức 2 (khoảng 1/2 lần)"
	};

	public static int[] int_112 = null;

	public static Point point_0;

	private static int[] int_113 = null;

	private static bool bool_7 = false;

	private static int int_114 = -1;

	private int int_115 = 0;

	public static bool bool_8 = false;

	public static int int_116 = -1;

	private bool bool_9 = false;

	private static int int_117 = 0;

	private static long long_0 = 0L;

	private static long long_1 = 0L;

	private int int_118 = -1;

	private int int_119 = -1;

	private static int int_120 = 0;

	private static int int_121 = 0;

	private static int int_122 = 0;

	private static long long_2 = 0L;

	private static long long_3 = 15000L;

	private static int int_123 = -1;

	private static int int_124 = -1;

	private static int int_125 = -1;

	private static int int_126 = -1;

	private static bool bool_10 = false;

	private bool bool_11 = false;

	private static int int_127 = 0;

	private static uint uint_0 = 0u;

	private static bool bool_12 = false;

	public static int int_128 = 0;

	private static bool bool_13 = false;

	private static string[] string_30 = null;

	private static string[] string_31 = null;

	public static string string_32 = string.Empty;

	private static int int_129 = -1;

	private static int int_130 = 0;

	private static int int_131 = -1;

	private static string[] string_33 = null;

	private static string[] string_34 = null;

	private static string[] string_35 = null;

	private static int int_132 = 0;

	private static int int_133 = 0;

	private static string string_36 = null;

	private static string string_37 = null;
    private IContainer components;
    private static string[] string_38 = null;

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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon_0 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.textBoxKhoangCachAccChinh = new System.Windows.Forms.TextBox();
            this.checkBoxTimTrongthanh = new System.Windows.Forms.CheckBox();
            this.comboBoxAccChinh = new System.Windows.Forms.ComboBox();
            this.comboBoxIndex = new System.Windows.Forms.ComboBox();
            this.checkBoxTimAccchinh = new System.Windows.Forms.CheckBox();
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonVang = new System.Windows.Forms.Button();
            this.comboBoxPhuong = new System.Windows.Forms.ComboBox();
            this.buttonTHP = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPageBang1 = new System.Windows.Forms.TabPage();
            this.buttonPT = new System.Windows.Forms.Button();
            this.buttonBoss = new System.Windows.Forms.Button();
            this.buttonNamIm = new System.Windows.Forms.Button();
            this.buttonBaoBoss = new System.Windows.Forms.Button();
            this.labelLocdo = new System.Windows.Forms.Label();
            this.checkBoxBosBaobos = new System.Windows.Forms.CheckBox();
            this.textBoxPhamvi = new System.Windows.Forms.TextBox();
            this.buttonMuctieu = new System.Windows.Forms.Button();
            this.buttonThietLapDuongMon = new System.Windows.Forms.Button();
            this.checkBoxCungMucTieu = new System.Windows.Forms.CheckBox();
            this.checkBoxTudongPT = new System.Windows.Forms.CheckBox();
            this.checkBoxDuongMonBoom = new System.Windows.Forms.CheckBox();
            this.labelKieudame = new System.Windows.Forms.Label();
            this.buttonThongke = new System.Windows.Forms.Button();
            this.comboBoxXuongNgua = new System.Windows.Forms.ComboBox();
            this.buttonSuadoTaicho = new System.Windows.Forms.Button();
            this.buttonTatcaLuuruong = new System.Windows.Forms.Button();
            this.checkBoxDameMacdinh = new System.Windows.Forms.CheckBox();
            this.buttonMorong = new System.Windows.Forms.Button();
            this.buttonNgaMybuff = new System.Windows.Forms.Button();
            this.textBoxKhoangCachTheoSau = new System.Windows.Forms.TextBox();
            this.buttonCashBua = new System.Windows.Forms.Button();
            this.checkBoxTuCastBua = new System.Windows.Forms.CheckBox();
            this.checkBoxTiepCan = new System.Windows.Forms.CheckBox();
            this.buttonDame = new System.Windows.Forms.Button();
            this.checkBoxDanhquai = new System.Windows.Forms.CheckBox();
            this.buttonUuTien = new System.Windows.Forms.Button();
            this.labelTheoSauAll = new System.Windows.Forms.Label();
            this.buttonLoaitruAccBuff = new System.Windows.Forms.Button();
            this.comboBoxNhatdo = new System.Windows.Forms.ComboBox();
            this.checkBoxNhatdo = new System.Windows.Forms.CheckBox();
            this.comboBoxTheoSau = new System.Windows.Forms.ComboBox();
            this.checkBoxChetnamIm = new System.Windows.Forms.CheckBox();
            this.checkBoxTheoSau = new System.Windows.Forms.CheckBox();
            this.textBoxTimerNgamyBuff = new System.Windows.Forms.TextBox();
            this.textBoxNgamyBuff = new System.Windows.Forms.TextBox();
            this.checkBoxNgamyBuff = new System.Windows.Forms.CheckBox();
            this.checkBoxTamQuet = new System.Windows.Forms.CheckBox();
            this.textBoxKhoangCachTiepcan = new System.Windows.Forms.TextBox();
            this.comboBoxUuTien = new System.Windows.Forms.ComboBox();
            this.checkBoxUutienDanhquai = new System.Windows.Forms.CheckBox();
            this.checkBoxTuve = new System.Windows.Forms.CheckBox();
            this.tabPageBang2 = new System.Windows.Forms.TabPage();
            this.comboBoxCLD = new System.Windows.Forms.ComboBox();
            this.checkBoxTHPChienLong = new System.Windows.Forms.CheckBox();
            this.checkBoxDenToadoLeave = new System.Windows.Forms.CheckBox();
            this.buttonMayphuLayToado = new System.Windows.Forms.Button();
            this.buttonQuangThuoc = new System.Windows.Forms.Button();
            this.checkBoxQuangThuoc = new System.Windows.Forms.CheckBox();
            this.buttonDiemTapket = new System.Windows.Forms.Button();
            this.checkBoxDiemTapket = new System.Windows.Forms.CheckBox();
            this.checkBoxVuotAi = new System.Windows.Forms.CheckBox();
            this.buttonMayphuXoaToado = new System.Windows.Forms.Button();
            this.checkBoxChienLongdong = new System.Windows.Forms.CheckBox();
            this.buttonBungThuoc = new System.Windows.Forms.Button();
            this.buttonLayToado = new System.Windows.Forms.Button();
            this.checkBoxDenToadoALL = new System.Windows.Forms.CheckBox();
            this.textBoxMayphuToado = new System.Windows.Forms.TextBox();
            this.textBoxToadoDen = new System.Windows.Forms.TextBox();
            this.checkBoxMayphuToado = new System.Windows.Forms.CheckBox();
            this.buttonXoaToado = new System.Windows.Forms.Button();
            this.checkBoxDenToadoUser = new System.Windows.Forms.CheckBox();
            this.tabPageTongKim = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxClickMenuTS = new System.Windows.Forms.TextBox();
            this.comboBoxTrinhsat = new System.Windows.Forms.ComboBox();
            this.labelToadoTrinhsat = new System.Windows.Forms.Label();
            this.textBoxTruotTK = new System.Windows.Forms.TextBox();
            this.checkBoxDanhHieuuy = new System.Windows.Forms.CheckBox();
            this.checkBoxTKThanhTruot = new System.Windows.Forms.CheckBox();
            this.checkBoxAccPhuHauDoanh = new System.Windows.Forms.CheckBox();
            this.checkBoxTatMuamauTK = new System.Windows.Forms.CheckBox();
            this.checkBoxTubaoDanh = new System.Windows.Forms.CheckBox();
            this.checkBoxAnThuocTDD = new System.Windows.Forms.CheckBox();
            this.checkBoxTrinhSat = new System.Windows.Forms.CheckBox();
            this.comboBoxVaodiemBaodanh = new System.Windows.Forms.ComboBox();
            this.checkBoxTongKimXemSoluong = new System.Windows.Forms.CheckBox();
            this.textBoxTocdoDanh = new System.Windows.Forms.TextBox();
            this.checkBoxAnThuocLag = new System.Windows.Forms.CheckBox();
            this.checkBoxAccChinhHauDoanh = new System.Windows.Forms.CheckBox();
            this.buttonThuocTDD = new System.Windows.Forms.Button();
            this.buttonThuocLag = new System.Windows.Forms.Button();
            this.tabPageCTC = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxCTC = new System.Windows.Forms.ComboBox();
            this.tabControlThatThanh = new System.Windows.Forms.TabControl();
            this.tabPageThatthanh = new System.Windows.Forms.TabPage();
            this.checkBoxVaomapAchinh = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxChienTruongMapPhu = new System.Windows.Forms.ComboBox();
            this.buttonLayVitriXaphuCTQ = new System.Windows.Forms.Button();
            this.buttonPhimHDCTC = new System.Windows.Forms.Button();
            this.checkBoxOluonMapphu = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.labelChuadaydu = new System.Windows.Forms.Label();
            this.numericUpDownCTC = new System.Windows.Forms.NumericUpDown();
            this.comboBoxChienTruong = new System.Windows.Forms.ComboBox();
            this.checkBoxMapPhu = new System.Windows.Forms.CheckBox();
            this.checkBoxTHPCTC = new System.Windows.Forms.CheckBox();
            this.tabPageTamtru = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonLayvitriCongTamtru = new System.Windows.Forms.Button();
            this.textBoxCongTamtru = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxToadoHieuthuocTamtru = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBoxTenHieuThuocTamtru = new System.Windows.Forms.ComboBox();
            this.checkBoxPheThu = new System.Windows.Forms.CheckBox();
            this.buttonPhimHdTamtru = new System.Windows.Forms.Button();
            this.tabPageTamMondai = new System.Windows.Forms.TabPage();
            this.buttonTamMonDaiHD = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.buttonMapTamMondaiMacdinh = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.buttonLayMapTamMondai = new System.Windows.Forms.Button();
            this.textBoxTamMonDaiMapId = new System.Windows.Forms.TextBox();
            this.checkBoxAccChinhTudieukhienCTC = new System.Windows.Forms.CheckBox();
            this.tabPageTrain = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.checkBoxQuayquai = new System.Windows.Forms.CheckBox();
            this.textBoxSLThoat = new System.Windows.Forms.TextBox();
            this.checkBoxToadoVong = new System.Windows.Forms.CheckBox();
            this.linkLabelPhimChaynhim = new System.Windows.Forms.LinkLabel();
            this.checkBoxDanhQuaiTrenduongdi = new System.Windows.Forms.CheckBox();
            this.textBoxMapName = new System.Windows.Forms.TextBox();
            this.checkBoxTrain = new System.Windows.Forms.CheckBox();
            this.checkBoxTDPHettien = new System.Windows.Forms.CheckBox();
            this.checkBoxDanhquaiTrain = new System.Windows.Forms.CheckBox();
            this.checkBoxTucheHT = new System.Windows.Forms.CheckBox();
            this.checkBoxTranhBossVang = new System.Windows.Forms.CheckBox();
            this.listViewTrain = new System.Windows.Forms.ListView();
            this.columnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxOtrong = new System.Windows.Forms.ComboBox();
            this.checkBoxOtrong = new System.Windows.Forms.CheckBox();
            this.buttonDoctep = new System.Windows.Forms.Button();
            this.buttonLayToadoTrain = new System.Windows.Forms.Button();
            this.buttonXoaToadoTrain = new System.Windows.Forms.Button();
            this.checkBoxTDPSaimap = new System.Windows.Forms.CheckBox();
            this.buttonLuutep = new System.Windows.Forms.Button();
            this.checkBoxLuomrac = new System.Windows.Forms.CheckBox();
            this.checkBoxSLThoat = new System.Windows.Forms.CheckBox();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.comboBoxDoSatcuuSat = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxPhamviNhat = new System.Windows.Forms.TextBox();
            this.checkBoxNhatdoDichuyenGan = new System.Windows.Forms.CheckBox();
            this.textBoxTimeXepdo = new System.Windows.Forms.TextBox();
            this.checkBoxXepdo = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonKhongcat = new System.Windows.Forms.Button();
            this.checkBoxRuong0 = new System.Windows.Forms.CheckBox();
            this.checkBoxRuong2 = new System.Windows.Forms.CheckBox();
            this.checkBoxRuong3 = new System.Windows.Forms.CheckBox();
            this.checkBoxRuong1 = new System.Windows.Forms.CheckBox();
            this.label42 = new System.Windows.Forms.Label();
            this.buttonApdungAllTrain = new System.Windows.Forms.Button();
            this.buttonHuongDan = new System.Windows.Forms.Button();
            this.comboBoxTHP = new System.Windows.Forms.ComboBox();
            this.buttonXanh = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlHaucan = new System.Windows.Forms.TabControl();
            this.tabPageMuathuoc = new System.Windows.Forms.TabPage();
            this.buttonTatMua = new System.Windows.Forms.Button();
            this.textBoxSoluongThuocDimua = new System.Windows.Forms.TextBox();
            this.buttonMuathuocBaovat = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxSoluong1 = new System.Windows.Forms.TextBox();
            this.textBoxSoluong2 = new System.Windows.Forms.TextBox();
            this.textBoxSoluongMuaGiaiDoc = new System.Windows.Forms.TextBox();
            this.buttonKyTranCac = new System.Windows.Forms.Button();
            this.checkBoxMuaKTC = new System.Windows.Forms.CheckBox();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.checkBoxNguHoa500l = new System.Windows.Forms.CheckBox();
            this.checkBoxMuaThontran = new System.Windows.Forms.CheckBox();
            this.checkBoxHoasonMuamau500l = new System.Windows.Forms.CheckBox();
            this.checkBoxTuchayMuathuoc = new System.Windows.Forms.CheckBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.checkBoxBamPhimCong = new System.Windows.Forms.CheckBox();
            this.checkBoxTuChuyenThuoc = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSoluongChuyenthuoc = new System.Windows.Forms.TextBox();
            this.comboBoxChuyenThuoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonHDChuyenthuoc = new System.Windows.Forms.Button();
            this.textBoxChuyenThuocMin = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxGanTenthuoc = new System.Windows.Forms.CheckBox();
            this.textBoxOso1 = new System.Windows.Forms.TextBox();
            this.textBoxOso2 = new System.Windows.Forms.TextBox();
            this.textBoxOso3 = new System.Windows.Forms.TextBox();
            this.checkBoxRuongBH = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSoluongTDP = new System.Windows.Forms.TextBox();
            this.comboBoxMua2 = new System.Windows.Forms.ComboBox();
            this.comboBoxMua1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMuaGiaiDoc = new System.Windows.Forms.ComboBox();
            this.buttonApDungMuaThuocAll = new System.Windows.Forms.Button();
            this.buttonBungTuimau = new System.Windows.Forms.Button();
            this.checkBoxMuaTDP = new System.Windows.Forms.CheckBox();
            this.textBoxTienMangtheo = new System.Windows.Forms.TextBox();
            this.buttonComboNhoithuoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxMangtheotien = new System.Windows.Forms.CheckBox();
            this.checkBoxMua1 = new System.Windows.Forms.CheckBox();
            this.checkBoxMuaGiaiDoc = new System.Windows.Forms.CheckBox();
            this.checkBoxMua2 = new System.Windows.Forms.CheckBox();
            this.tabPagePhuchoi = new System.Windows.Forms.TabPage();
            this.checkBoxTTL = new System.Windows.Forms.CheckBox();
            this.comboBoxPk = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxUuTienBomCuuchuyen = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxMPTdp = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxHpTDP = new System.Windows.Forms.TextBox();
            this.checkBoxMana2 = new System.Windows.Forms.CheckBox();
            this.checkBoxMau2 = new System.Windows.Forms.CheckBox();
            this.comboBoxTenMana2 = new System.Windows.Forms.ComboBox();
            this.textBoxTimerMana2 = new System.Windows.Forms.TextBox();
            this.textBoxRatioMana2 = new System.Windows.Forms.TextBox();
            this.textBoxSoluongMana2 = new System.Windows.Forms.TextBox();
            this.comboBoxTenMau2 = new System.Windows.Forms.ComboBox();
            this.textBoxSoluongMau2 = new System.Windows.Forms.TextBox();
            this.textBoxTimerMau2 = new System.Windows.Forms.TextBox();
            this.buttonAppDungBomMauAll = new System.Windows.Forms.Button();
            this.checkBoxVeThanhKhiPKlon = new System.Windows.Forms.CheckBox();
            this.textBoxRatioMau2 = new System.Windows.Forms.TextBox();
            this.checkBoxMPTdp = new System.Windows.Forms.CheckBox();
            this.textBoxTDP_SL_Mana = new System.Windows.Forms.TextBox();
            this.textBoxSoluongBomMagic = new System.Windows.Forms.TextBox();
            this.textBoxTimerBomMagic = new System.Windows.Forms.TextBox();
            this.checkBoxTuGiaidoc = new System.Windows.Forms.CheckBox();
            this.textBoxTDP_SL_Mau = new System.Windows.Forms.TextBox();
            this.buttonGiaiThichHaucan = new System.Windows.Forms.Button();
            this.checkBoxTDP_SL_Mana = new System.Windows.Forms.CheckBox();
            this.checkBoxTDP_SL_Mau = new System.Windows.Forms.CheckBox();
            this.checkBoxMPBom = new System.Windows.Forms.CheckBox();
            this.textBoxThoiGianBomHPDiem = new System.Windows.Forms.TextBox();
            this.textBoxSoluongBomHP = new System.Windows.Forms.TextBox();
            this.checkBoxHPTdp = new System.Windows.Forms.CheckBox();
            this.textBoxThoigianBomMP = new System.Windows.Forms.TextBox();
            this.textBoxThoigianBomHP = new System.Windows.Forms.TextBox();
            this.textBoxBomHPDiem = new System.Windows.Forms.TextBox();
            this.checkBoxBomHPDiem = new System.Windows.Forms.CheckBox();
            this.textBoxSoLuongBomHPDiem = new System.Windows.Forms.TextBox();
            this.checkBoxBomHP = new System.Windows.Forms.CheckBox();
            this.textBoxMPBom = new System.Windows.Forms.TextBox();
            this.textBoxBomMPDiem = new System.Windows.Forms.TextBox();
            this.textBoxSoLuongBomMPDiem = new System.Windows.Forms.TextBox();
            this.checkBoxBomMPDiem = new System.Windows.Forms.CheckBox();
            this.textBoxThoiGianBomMPDiem = new System.Windows.Forms.TextBox();
            this.textBoxHPBom = new System.Windows.Forms.TextBox();
            this.textBoxSoluongBomMP = new System.Windows.Forms.TextBox();
            this.tabPageChieuthuc = new System.Windows.Forms.TabPage();
            this.checkBoxConLon = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTranphai1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTranphai2 = new System.Windows.Forms.ComboBox();
            this.textBoxTranphai2 = new System.Windows.Forms.TextBox();
            this.textBoxTranphai1 = new System.Windows.Forms.TextBox();
            this.checkBoxTranphai1 = new System.Windows.Forms.CheckBox();
            this.checkBoxTranphai3 = new System.Windows.Forms.CheckBox();
            this.comboBoxTranphai3 = new System.Windows.Forms.ComboBox();
            this.checkBoxTranphai2 = new System.Windows.Forms.CheckBox();
            this.textBoxTranphai3 = new System.Windows.Forms.TextBox();
            this.tabControlChuyenSkill = new System.Windows.Forms.TabControl();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.comboBoxChuyenChieuTrai1 = new System.Windows.Forms.ComboBox();
            this.comboBoxChuyenChieuTrai2 = new System.Windows.Forms.ComboBox();
            this.textBoxChuyenChieuTrai3 = new System.Windows.Forms.TextBox();
            this.comboBoxChuyenChieuTrai3 = new System.Windows.Forms.ComboBox();
            this.textBoxChuyenChieuTrai2 = new System.Windows.Forms.TextBox();
            this.textBoxChuyenChieuTrai1 = new System.Windows.Forms.TextBox();
            this.checkBoxChuyenChieuTrai1 = new System.Windows.Forms.CheckBox();
            this.checkBoxChuyenChieuTrai2 = new System.Windows.Forms.CheckBox();
            this.checkBoxChuyenChieuTrai3 = new System.Windows.Forms.CheckBox();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.comboBoxChuyenChieuPhai1 = new System.Windows.Forms.ComboBox();
            this.comboBoxChuyenChieuPhai2 = new System.Windows.Forms.ComboBox();
            this.textBoxChuyenChieuPhai3 = new System.Windows.Forms.TextBox();
            this.comboBoxChuyenChieuPhai3 = new System.Windows.Forms.ComboBox();
            this.textBoxChuyenChieuPhai2 = new System.Windows.Forms.TextBox();
            this.textBoxChuyenChieuPhai1 = new System.Windows.Forms.TextBox();
            this.checkBoxChuyenChieuPhai1 = new System.Windows.Forms.CheckBox();
            this.checkBoxChuyenChieuPhai2 = new System.Windows.Forms.CheckBox();
            this.checkBoxChuyenChieuPhai3 = new System.Windows.Forms.CheckBox();
            this.comboBoxGanChieuPhai = new System.Windows.Forms.ComboBox();
            this.buttonSkill120vd = new System.Windows.Forms.Button();
            this.checkBoxGanChieuPhai = new System.Windows.Forms.CheckBox();
            this.checkBoxGanChieuTrai = new System.Windows.Forms.CheckBox();
            this.checkBoxTuGiaiBua = new System.Windows.Forms.CheckBox();
            this.comboBoxGanChieuTrai = new System.Windows.Forms.ComboBox();
            this.checkBoxTNXuatChieu120 = new System.Windows.Forms.CheckBox();
            this.buttonSkill120tn = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonResetAuto = new System.Windows.Forms.Button();
            this.checkBoxBaoKeylog = new System.Windows.Forms.CheckBox();
            this.linkLabelTrangchu = new System.Windows.Forms.LinkLabel();
            this.checkBoxChayRunAdmin = new System.Windows.Forms.CheckBox();
            this.buttonTuTimWeb = new System.Windows.Forms.Button();
            this.checkBoxGameHu = new System.Windows.Forms.CheckBox();
            this.checkBoxGiamRamTudong = new System.Windows.Forms.CheckBox();
            this.comboBoxGameOfWeb = new System.Windows.Forms.ComboBox();
            this.buttonFixGameTuthoat = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.richTextBoxBHO = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxIDSudung = new System.Windows.Forms.TextBox();
            this.buttonTrial = new System.Windows.Forms.Button();
            this.buttonIDApdung = new System.Windows.Forms.Button();
            this.buttonDangky = new System.Windows.Forms.Button();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.labelThongtinDK = new System.Windows.Forms.Label();
            this.textBoxHSD = new System.Windows.Forms.TextBox();
            this.buttonHDD = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxChatNham = new System.Windows.Forms.TextBox();
            this.textBoxThuMuc = new System.Windows.Forms.TextBox();
            this.checkBoxChatNham = new System.Windows.Forms.CheckBox();
            this.buttonBrowseGame = new System.Windows.Forms.Button();
            this.buttonThumucAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToShortcut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabControlPhutro = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonThoatGame = new System.Windows.Forms.Button();
            this.buttonDoSat = new System.Windows.Forms.Button();
            this.buttonVaotraiStopAll = new System.Windows.Forms.Button();
            this.buttonNopLenhbaiAll = new System.Windows.Forms.Button();
            this.buttonVaotraiStop = new System.Windows.Forms.Button();
            this.comboBoxBentau = new System.Windows.Forms.ComboBox();
            this.buttonBaoToado = new System.Windows.Forms.Button();
            this.buttonPhimTat = new System.Windows.Forms.Button();
            this.buttonNopLenhbai = new System.Windows.Forms.Button();
            this.buttonMoGame = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonDanhsachCuusat = new System.Windows.Forms.Button();
            this.buttonAnhet = new System.Windows.Forms.Button();
            this.comboBoxAccDoiMau = new System.Windows.Forms.ComboBox();
            this.buttonThoatHetgame = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBoxGiamCpu = new System.Windows.Forms.ComboBox();
            this.buttonGiamCPUAll = new System.Windows.Forms.Button();
            this.buttonHuongdanHLP = new System.Windows.Forms.Button();
            this.buttonCapnhat = new System.Windows.Forms.Button();
            this.buttonTatcaTDP = new System.Windows.Forms.Button();
            this.checkBoxPhimTat = new System.Windows.Forms.CheckBox();
            this.tabPageTinsu = new System.Windows.Forms.TabPage();
            this.buttonDocCauhinh = new System.Windows.Forms.Button();
            this.buttonHuyenTinh = new System.Windows.Forms.Button();
            this.buttonRaovat = new System.Windows.Forms.Button();
            this.checkBoxAceptBH = new System.Windows.Forms.CheckBox();
            this.buttonLuuCauhinhAll = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.linkLabelHelpTinsu = new System.Windows.Forms.LinkLabel();
            this.textBoxTimerPT = new System.Windows.Forms.TextBox();
            this.checkBoxChoPTdanhsach = new System.Windows.Forms.CheckBox();
            this.buttonToadoPK = new System.Windows.Forms.Button();
            this.checkBoxChayPKNguoidung = new System.Windows.Forms.CheckBox();
            this.checkBoxChaydanhvong = new System.Windows.Forms.CheckBox();
            this.buttonTinsuAll = new System.Windows.Forms.Button();
            this.checkBoxChayTinsu = new System.Windows.Forms.CheckBox();
            this.comboBoxTinSu = new System.Windows.Forms.ComboBox();
            this.checkBoxMuathuocPK = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhamviNhatqua = new System.Windows.Forms.TextBox();
            this.buttonStopNhatqua = new System.Windows.Forms.Button();
            this.numericUpDownHH = new System.Windows.Forms.NumericUpDown();
            this.buttonNhatquaAll = new System.Windows.Forms.Button();
            this.checkBoxNhatqua = new System.Windows.Forms.CheckBox();
            this.numericUpDownSS = new System.Windows.Forms.NumericUpDown();
            this.checkBoxGioClick = new System.Windows.Forms.CheckBox();
            this.numericUpDownMM = new System.Windows.Forms.NumericUpDown();
            this.tabPageTinhLuyen = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonClickNpcStopAll = new System.Windows.Forms.Button();
            this.textBoxNhapSoluongClickNPC = new System.Windows.Forms.TextBox();
            this.buttonClickNpcAll = new System.Windows.Forms.Button();
            this.textBoxClickNPCSolan = new System.Windows.Forms.TextBox();
            this.buttonClickNpcSingle = new System.Windows.Forms.Button();
            this.buttonHelpClickNpc = new System.Windows.Forms.Button();
            this.textBoxClickNPCMenu = new System.Windows.Forms.TextBox();
            this.comboBoxClickNPC = new System.Windows.Forms.ComboBox();
            this.textBoxClickNPCTocdo = new System.Windows.Forms.TextBox();
            this.checkBoxClickNPCmenu = new System.Windows.Forms.CheckBox();
            this.buttonThietlapClickNpc = new System.Windows.Forms.Button();
            this.checkBoxNPC = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.checkBoxClickNPCSolan = new System.Windows.Forms.CheckBox();
            this.tabControlLoc = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.buttonMuaSudungAll = new System.Windows.Forms.Button();
            this.buttonMuaGopAll = new System.Windows.Forms.Button();
            this.textBoxMuadungSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxIdMua = new System.Windows.Forms.TextBox();
            this.labelMuaGopStopAll = new System.Windows.Forms.Label();
            this.labelMuaGopStop = new System.Windows.Forms.Label();
            this.labelMuaSudung = new System.Windows.Forms.Label();
            this.labelMuaGopStart = new System.Windows.Forms.Label();
            this.linkLabelPhimCauca = new System.Windows.Forms.LinkLabel();
            this.checkBoxThanhTruotSudung = new System.Windows.Forms.CheckBox();
            this.buttonHelpMua = new System.Windows.Forms.Button();
            this.checkBoxBoquaMaKTC = new System.Windows.Forms.CheckBox();
            this.checkBoxMuaDungSoluong = new System.Windows.Forms.CheckBox();
            this.comboBoxMuaVatpham = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxGopVatpham = new System.Windows.Forms.CheckBox();
            this.checkBoxMuaKytrancac = new System.Windows.Forms.CheckBox();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.buttonBanVatphamRac = new System.Windows.Forms.Button();
            this.checkBoxBanVpham = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonDsBanVatpham = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxNhapSLTest = new System.Windows.Forms.TextBox();
            this.buttonPhimHDLoc = new System.Windows.Forms.Button();
            this.buttonLocTrangbi = new System.Windows.Forms.Button();
            this.buttonDungTatcaTrangbiTest = new System.Windows.Forms.Button();
            this.textBoxMenuTest = new System.Windows.Forms.TextBox();
            this.buttonTatcaNhanTrangbiTest = new System.Windows.Forms.Button();
            this.buttonNhanTrangbiTest = new System.Windows.Forms.Button();
            this.checkBoxLocTrangbiNhapSL = new System.Windows.Forms.CheckBox();
            this.comboBoxTrangbiTest = new System.Windows.Forms.ComboBox();
            this.checkBoxLocTrangbiNPC = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.textBoxTenacTimVST = new System.Windows.Forms.TextBox();
            this.textBoxThoigianVST = new System.Windows.Forms.TextBox();
            this.buttonCopyVST = new System.Windows.Forms.Button();
            this.checkBoxBaokenhbang = new System.Windows.Forms.CheckBox();
            this.checkBoxBatdauVanSuthong = new System.Windows.Forms.CheckBox();
            this.textBoxToadoVST = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxRoom = new System.Windows.Forms.CheckBox();
            this.textBoxMapNameVST = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPasteVST = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBoxBossSTKhongLamHaucan = new System.Windows.Forms.CheckBox();
            this.checkBoxGhepSTG = new System.Windows.Forms.CheckBox();
            this.checkBoxBossSTtuhuy = new System.Windows.Forms.CheckBox();
            this.checkBoxONha = new System.Windows.Forms.CheckBox();
            this.comboBoxBosSatthu = new System.Windows.Forms.ComboBox();
            this.buttonGhepSTG = new System.Windows.Forms.Button();
            this.checkBoxKhongLuuruong = new System.Windows.Forms.CheckBox();
            this.buttonSatthuAll = new System.Windows.Forms.Button();
            this.checkBoxBossSatthu = new System.Windows.Forms.CheckBox();
            this.buttonHuongdanCanhbos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxNoiBoss = new System.Windows.Forms.ComboBox();
            this.checkBoxTuChayBoss = new System.Windows.Forms.CheckBox();
            this.buttonDenDiemKetiep = new System.Windows.Forms.Button();
            this.buttonBossAll = new System.Windows.Forms.Button();
            this.buttonSuaXoa = new System.Windows.Forms.Button();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.buttonOpenAllWeb = new System.Windows.Forms.Button();
            this.GrouptTest = new System.Windows.Forms.GroupBox();
            this.buttonBien = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxScrMouseXY = new System.Windows.Forms.TextBox();
            this.textBoxRealMouseXY = new System.Windows.Forms.TextBox();
            this.textBoxScrPosXY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxRealPosXY = new System.Windows.Forms.TextBox();
            this.buttonXemMaloi = new System.Windows.Forms.Button();
            this.buttonFormTest = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.checkBoxSudungDataNguoidung = new System.Windows.Forms.CheckBox();
            this.buttonCapnhatData = new System.Windows.Forms.Button();
            this.buttonSosanh = new System.Windows.Forms.Button();
            this.buttonXoaIDAcChinh = new System.Windows.Forms.Button();
            this.buttonTimTrongthanh = new System.Windows.Forms.Button();
            this.richTextBoxChedoMayphu = new System.Windows.Forms.RichTextBox();
            this.pictureBoxQC = new System.Windows.Forms.PictureBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonAchinh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPageBang1.SuspendLayout();
            this.tabPageBang2.SuspendLayout();
            this.tabPageTongKim.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPageCTC.SuspendLayout();
            this.tabControlThatThanh.SuspendLayout();
            this.tabPageThatthanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCTC)).BeginInit();
            this.tabPageTamtru.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPageTamMondai.SuspendLayout();
            this.tabPageTrain.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage18.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControlHaucan.SuspendLayout();
            this.tabPageMuathuoc.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPagePhuchoi.SuspendLayout();
            this.tabPageChieuthuc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControlChuyenSkill.SuspendLayout();
            this.tabPage19.SuspendLayout();
            this.tabPage20.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabControlPhutro.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPageTinsu.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMM)).BeginInit();
            this.tabPageTinhLuyen.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabControlLoc.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.GrouptTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQC)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon_0
            // 
            this.notifyIcon_0.Text = "KYKeoxe";
            this.notifyIcon_0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_0_MouseClick);
            // 
            // timer_0
            // 
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // textBoxKhoangCachAccChinh
            // 
            this.textBoxKhoangCachAccChinh.ForeColor = System.Drawing.Color.Black;
            this.textBoxKhoangCachAccChinh.Location = new System.Drawing.Point(92, 68);
            this.textBoxKhoangCachAccChinh.Name = "textBoxKhoangCachAccChinh";
            this.textBoxKhoangCachAccChinh.Size = new System.Drawing.Size(35, 20);
            this.textBoxKhoangCachAccChinh.TabIndex = 135;
            this.textBoxKhoangCachAccChinh.TextChanged += new System.EventHandler(this.textBoxKhoangCachAccChinh_TextChanged);
            this.textBoxKhoangCachAccChinh.Leave += new System.EventHandler(this.textBoxKhoangCachAccChinh_Leave);
            // 
            // checkBoxTimTrongthanh
            // 
            this.checkBoxTimTrongthanh.AutoSize = true;
            this.checkBoxTimTrongthanh.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTimTrongthanh.ForeColor = System.Drawing.Color.Red;
            this.checkBoxTimTrongthanh.Location = new System.Drawing.Point(131, 70);
            this.checkBoxTimTrongthanh.Name = "checkBoxTimTrongthanh";
            this.checkBoxTimTrongthanh.Size = new System.Drawing.Size(100, 17);
            this.checkBoxTimTrongthanh.TabIndex = 134;
            this.checkBoxTimTrongthanh.Text = "Tìm trong thành";
            this.checkBoxTimTrongthanh.UseVisualStyleBackColor = false;
            this.checkBoxTimTrongthanh.CheckedChanged += new System.EventHandler(this.checkBoxTimTrongthanh_CheckedChanged);
            // 
            // comboBoxAccChinh
            // 
            this.comboBoxAccChinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccChinh.DropDownWidth = 125;
            this.comboBoxAccChinh.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAccChinh.FormattingEnabled = true;
            this.comboBoxAccChinh.Location = new System.Drawing.Point(131, 45);
            this.comboBoxAccChinh.Name = "comboBoxAccChinh";
            this.comboBoxAccChinh.Size = new System.Drawing.Size(109, 21);
            this.comboBoxAccChinh.TabIndex = 133;
            this.comboBoxAccChinh.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccChinh_SelectedIndexChanged);
            this.comboBoxAccChinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxAccChinh_MouseDown);
            // 
            // comboBoxIndex
            // 
            this.comboBoxIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIndex.DropDownWidth = 140;
            this.comboBoxIndex.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBoxIndex.FormattingEnabled = true;
            this.comboBoxIndex.Location = new System.Drawing.Point(1, 44);
            this.comboBoxIndex.Name = "comboBoxIndex";
            this.comboBoxIndex.Size = new System.Drawing.Size(60, 21);
            this.comboBoxIndex.TabIndex = 126;
            this.comboBoxIndex.SelectedIndexChanged += new System.EventHandler(this.comboBoxIndex_SelectedIndexChanged);
            // 
            // checkBoxTimAccchinh
            // 
            this.checkBoxTimAccchinh.AutoSize = true;
            this.checkBoxTimAccchinh.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTimAccchinh.ForeColor = System.Drawing.Color.Red;
            this.checkBoxTimAccchinh.Location = new System.Drawing.Point(2, 70);
            this.checkBoxTimAccchinh.Name = "checkBoxTimAccchinh";
            this.checkBoxTimAccchinh.Size = new System.Drawing.Size(89, 17);
            this.checkBoxTimAccchinh.TabIndex = 128;
            this.checkBoxTimAccchinh.Text = "Tìm ac chính";
            this.checkBoxTimAccchinh.UseVisualStyleBackColor = false;
            this.checkBoxTimAccchinh.CheckedChanged += new System.EventHandler(this.checkBoxTimAccchinh_CheckedChanged);
            // 
            // buttonOff
            // 
            this.buttonOff.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOff.ForeColor = System.Drawing.Color.Black;
            this.buttonOff.Location = new System.Drawing.Point(240, 0);
            this.buttonOff.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(24, 42);
            this.buttonOff.TabIndex = 132;
            this.buttonOff.Text = "Tài trợ";
            this.buttonOff.UseVisualStyleBackColor = false;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.ForeColor = System.Drawing.Color.Red;
            this.buttonAdd.Location = new System.Drawing.Point(196, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(23, 42);
            this.buttonAdd.TabIndex = 130;
            this.buttonAdd.Text = "A";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxStatus.Location = new System.Drawing.Point(1, 1);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(194, 40);
            this.richTextBoxStatus.TabIndex = 129;
            this.richTextBoxStatus.Text = "Đang kết nối server, xin vui lòng đợi chút xíu...";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 92);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(264, 140);
            this.listView1.TabIndex = 136;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // columnHeader_0
            // 
            this.columnHeader_0.Text = "Tên nhân vật";
            this.columnHeader_0.Width = 105;
            // 
            // columnHeader_1
            // 
            this.columnHeader_1.Text = "Doing";
            this.columnHeader_1.Width = 42;
            // 
            // columnHeader_2
            // 
            this.columnHeader_2.Text = "Bản đồ";
            this.columnHeader_2.Width = 58;
            // 
            // columnHeader_5
            // 
            this.columnHeader_5.Text = "***";
            this.columnHeader_5.Width = 37;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 232);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 383);
            this.tabControl1.TabIndex = 137;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonVang);
            this.tabPage1.Controls.Add(this.comboBoxPhuong);
            this.tabPage1.Controls.Add(this.buttonTHP);
            this.tabPage1.Controls.Add(this.tabControl3);
            this.tabPage1.Controls.Add(this.comboBoxTHP);
            this.tabPage1.Controls.Add(this.buttonXanh);
            this.tabPage1.Controls.Add(this.buttonTim);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(256, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Điều khiển";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonVang
            // 
            this.buttonVang.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonVang.ForeColor = System.Drawing.Color.Black;
            this.buttonVang.Location = new System.Drawing.Point(4, 332);
            this.buttonVang.Name = "buttonVang";
            this.buttonVang.Size = new System.Drawing.Size(32, 23);
            this.buttonVang.TabIndex = 178;
            this.buttonVang.Text = "V";
            this.buttonVang.UseVisualStyleBackColor = false;
            this.buttonVang.Click += new System.EventHandler(this.buttonVang_Click);
            // 
            // comboBoxPhuong
            // 
            this.comboBoxPhuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhuong.DropDownWidth = 40;
            this.comboBoxPhuong.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPhuong.FormattingEnabled = true;
            this.comboBoxPhuong.Location = new System.Drawing.Point(222, 334);
            this.comboBoxPhuong.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxPhuong.Name = "comboBoxPhuong";
            this.comboBoxPhuong.Size = new System.Drawing.Size(32, 21);
            this.comboBoxPhuong.TabIndex = 349;
            // 
            // buttonTHP
            // 
            this.buttonTHP.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTHP.ForeColor = System.Drawing.Color.Black;
            this.buttonTHP.Location = new System.Drawing.Point(109, 332);
            this.buttonTHP.Name = "buttonTHP";
            this.buttonTHP.Size = new System.Drawing.Size(40, 23);
            this.buttonTHP.TabIndex = 350;
            this.buttonTHP.Text = "THP";
            this.buttonTHP.UseVisualStyleBackColor = false;
            this.buttonTHP.Click += new System.EventHandler(this.buttonTHP_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPageBang1);
            this.tabControl3.Controls.Add(this.tabPageBang2);
            this.tabControl3.Controls.Add(this.tabPageTongKim);
            this.tabControl3.Controls.Add(this.tabPageCTC);
            this.tabControl3.Controls.Add(this.tabPageTrain);
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(259, 329);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPageBang1
            // 
            this.tabPageBang1.Controls.Add(this.buttonPT);
            this.tabPageBang1.Controls.Add(this.buttonBoss);
            this.tabPageBang1.Controls.Add(this.buttonNamIm);
            this.tabPageBang1.Controls.Add(this.buttonBaoBoss);
            this.tabPageBang1.Controls.Add(this.labelLocdo);
            this.tabPageBang1.Controls.Add(this.checkBoxBosBaobos);
            this.tabPageBang1.Controls.Add(this.textBoxPhamvi);
            this.tabPageBang1.Controls.Add(this.buttonMuctieu);
            this.tabPageBang1.Controls.Add(this.buttonThietLapDuongMon);
            this.tabPageBang1.Controls.Add(this.checkBoxCungMucTieu);
            this.tabPageBang1.Controls.Add(this.checkBoxTudongPT);
            this.tabPageBang1.Controls.Add(this.checkBoxDuongMonBoom);
            this.tabPageBang1.Controls.Add(this.labelKieudame);
            this.tabPageBang1.Controls.Add(this.buttonThongke);
            this.tabPageBang1.Controls.Add(this.comboBoxXuongNgua);
            this.tabPageBang1.Controls.Add(this.buttonSuadoTaicho);
            this.tabPageBang1.Controls.Add(this.buttonTatcaLuuruong);
            this.tabPageBang1.Controls.Add(this.checkBoxDameMacdinh);
            this.tabPageBang1.Controls.Add(this.buttonMorong);
            this.tabPageBang1.Controls.Add(this.buttonNgaMybuff);
            this.tabPageBang1.Controls.Add(this.textBoxKhoangCachTheoSau);
            this.tabPageBang1.Controls.Add(this.buttonCashBua);
            this.tabPageBang1.Controls.Add(this.checkBoxTuCastBua);
            this.tabPageBang1.Controls.Add(this.checkBoxTiepCan);
            this.tabPageBang1.Controls.Add(this.buttonDame);
            this.tabPageBang1.Controls.Add(this.checkBoxDanhquai);
            this.tabPageBang1.Controls.Add(this.buttonUuTien);
            this.tabPageBang1.Controls.Add(this.labelTheoSauAll);
            this.tabPageBang1.Controls.Add(this.buttonLoaitruAccBuff);
            this.tabPageBang1.Controls.Add(this.comboBoxNhatdo);
            this.tabPageBang1.Controls.Add(this.checkBoxNhatdo);
            this.tabPageBang1.Controls.Add(this.comboBoxTheoSau);
            this.tabPageBang1.Controls.Add(this.checkBoxChetnamIm);
            this.tabPageBang1.Controls.Add(this.checkBoxTheoSau);
            this.tabPageBang1.Controls.Add(this.textBoxTimerNgamyBuff);
            this.tabPageBang1.Controls.Add(this.textBoxNgamyBuff);
            this.tabPageBang1.Controls.Add(this.checkBoxNgamyBuff);
            this.tabPageBang1.Controls.Add(this.checkBoxTamQuet);
            this.tabPageBang1.Controls.Add(this.textBoxKhoangCachTiepcan);
            this.tabPageBang1.Controls.Add(this.comboBoxUuTien);
            this.tabPageBang1.Controls.Add(this.checkBoxUutienDanhquai);
            this.tabPageBang1.Controls.Add(this.checkBoxTuve);
            this.tabPageBang1.Location = new System.Drawing.Point(4, 22);
            this.tabPageBang1.Name = "tabPageBang1";
            this.tabPageBang1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBang1.Size = new System.Drawing.Size(251, 303);
            this.tabPageBang1.TabIndex = 0;
            this.tabPageBang1.Text = "Bảng 1";
            this.tabPageBang1.UseVisualStyleBackColor = true;
            // 
            // buttonPT
            // 
            this.buttonPT.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPT.ForeColor = System.Drawing.Color.Black;
            this.buttonPT.Location = new System.Drawing.Point(75, 204);
            this.buttonPT.Name = "buttonPT";
            this.buttonPT.Size = new System.Drawing.Size(25, 20);
            this.buttonPT.TabIndex = 451;
            this.buttonPT.Text = "...";
            this.buttonPT.UseVisualStyleBackColor = false;
            this.buttonPT.Click += new System.EventHandler(this.buttonPT_Click);
            // 
            // buttonBoss
            // 
            this.buttonBoss.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBoss.ForeColor = System.Drawing.Color.Black;
            this.buttonBoss.Location = new System.Drawing.Point(75, 49);
            this.buttonBoss.Name = "buttonBoss";
            this.buttonBoss.Size = new System.Drawing.Size(25, 21);
            this.buttonBoss.TabIndex = 450;
            this.buttonBoss.Text = "...";
            this.buttonBoss.UseVisualStyleBackColor = false;
            this.buttonBoss.Click += new System.EventHandler(this.buttonBoss_Click);
            // 
            // buttonNamIm
            // 
            this.buttonNamIm.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNamIm.ForeColor = System.Drawing.Color.Black;
            this.buttonNamIm.Location = new System.Drawing.Point(75, 74);
            this.buttonNamIm.Name = "buttonNamIm";
            this.buttonNamIm.Size = new System.Drawing.Size(25, 21);
            this.buttonNamIm.TabIndex = 449;
            this.buttonNamIm.Text = "im";
            this.buttonNamIm.UseVisualStyleBackColor = false;
            this.buttonNamIm.Click += new System.EventHandler(this.buttonNamIm_Click);
            // 
            // buttonBaoBoss
            // 
            this.buttonBaoBoss.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBaoBoss.ForeColor = System.Drawing.Color.Black;
            this.buttonBaoBoss.Location = new System.Drawing.Point(75, 180);
            this.buttonBaoBoss.Name = "buttonBaoBoss";
            this.buttonBaoBoss.Size = new System.Drawing.Size(25, 20);
            this.buttonBaoBoss.TabIndex = 448;
            this.buttonBaoBoss.Text = "...";
            this.buttonBaoBoss.UseVisualStyleBackColor = false;
            this.buttonBaoBoss.Click += new System.EventHandler(this.buttonBaoBoss_Click);
            // 
            // labelLocdo
            // 
            this.labelLocdo.BackColor = System.Drawing.SystemColors.Control;
            this.labelLocdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLocdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLocdo.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelLocdo.Location = new System.Drawing.Point(153, 231);
            this.labelLocdo.Name = "labelLocdo";
            this.labelLocdo.Size = new System.Drawing.Size(30, 19);
            this.labelLocdo.TabIndex = 337;
            this.labelLocdo.Text = "lọc";
            this.labelLocdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLocdo.Click += new System.EventHandler(this.labelLocdo_Click);
            // 
            // checkBoxBosBaobos
            // 
            this.checkBoxBosBaobos.AutoSize = true;
            this.checkBoxBosBaobos.ForeColor = System.Drawing.Color.Black;
            this.checkBoxBosBaobos.Location = new System.Drawing.Point(3, 181);
            this.checkBoxBosBaobos.Name = "checkBoxBosBaobos";
            this.checkBoxBosBaobos.Size = new System.Drawing.Size(70, 17);
            this.checkBoxBosBaobos.TabIndex = 447;
            this.checkBoxBosBaobos.Text = "Báo boss";
            this.checkBoxBosBaobos.UseVisualStyleBackColor = true;
            this.checkBoxBosBaobos.CheckedChanged += new System.EventHandler(this.checkBoxBosBaobos_CheckedChanged);
            // 
            // textBoxPhamvi
            // 
            this.textBoxPhamvi.ForeColor = System.Drawing.Color.Black;
            this.textBoxPhamvi.Location = new System.Drawing.Point(218, 52);
            this.textBoxPhamvi.Name = "textBoxPhamvi";
            this.textBoxPhamvi.Size = new System.Drawing.Size(30, 20);
            this.textBoxPhamvi.TabIndex = 158;
            this.textBoxPhamvi.TextChanged += new System.EventHandler(this.textBoxPhamvi_TextChanged);
            // 
            // buttonMuctieu
            // 
            this.buttonMuctieu.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMuctieu.ForeColor = System.Drawing.Color.Black;
            this.buttonMuctieu.Location = new System.Drawing.Point(186, 103);
            this.buttonMuctieu.Name = "buttonMuctieu";
            this.buttonMuctieu.Size = new System.Drawing.Size(62, 21);
            this.buttonMuctieu.TabIndex = 334;
            this.buttonMuctieu.Text = "Mục tiêu";
            this.buttonMuctieu.UseVisualStyleBackColor = false;
            this.buttonMuctieu.Click += new System.EventHandler(this.buttonMuctieu_Click);
            // 
            // buttonThietLapDuongMon
            // 
            this.buttonThietLapDuongMon.BackColor = System.Drawing.SystemColors.Control;
            this.buttonThietLapDuongMon.ForeColor = System.Drawing.Color.Black;
            this.buttonThietLapDuongMon.Location = new System.Drawing.Point(186, 178);
            this.buttonThietLapDuongMon.Name = "buttonThietLapDuongMon";
            this.buttonThietLapDuongMon.Size = new System.Drawing.Size(62, 21);
            this.buttonThietLapDuongMon.TabIndex = 328;
            this.buttonThietLapDuongMon.Text = "Thiết lập";
            this.buttonThietLapDuongMon.UseVisualStyleBackColor = false;
            this.buttonThietLapDuongMon.Click += new System.EventHandler(this.buttonThietLapDuongMon_Click);
            // 
            // checkBoxCungMucTieu
            // 
            this.checkBoxCungMucTieu.AutoSize = true;
            this.checkBoxCungMucTieu.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxCungMucTieu.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxCungMucTieu.Location = new System.Drawing.Point(3, 104);
            this.checkBoxCungMucTieu.Name = "checkBoxCungMucTieu";
            this.checkBoxCungMucTieu.Size = new System.Drawing.Size(168, 17);
            this.checkBoxCungMucTieu.TabIndex = 333;
            this.checkBoxCungMucTieu.Text = "Đánh cùng mục tiêu ac chính";
            this.checkBoxCungMucTieu.UseVisualStyleBackColor = false;
            this.checkBoxCungMucTieu.CheckedChanged += new System.EventHandler(this.checkBoxCungMucTieu_CheckedChanged);
            // 
            // checkBoxTudongPT
            // 
            this.checkBoxTudongPT.AutoSize = true;
            this.checkBoxTudongPT.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTudongPT.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTudongPT.Location = new System.Drawing.Point(3, 206);
            this.checkBoxTudongPT.Name = "checkBoxTudongPT";
            this.checkBoxTudongPT.Size = new System.Drawing.Size(49, 17);
            this.checkBoxTudongPT.TabIndex = 310;
            this.checkBoxTudongPT.Text = "PT...";
            this.checkBoxTudongPT.UseVisualStyleBackColor = false;
            this.checkBoxTudongPT.CheckedChanged += new System.EventHandler(this.checkBoxTudongPT_CheckedChanged);
            // 
            // checkBoxDuongMonBoom
            // 
            this.checkBoxDuongMonBoom.AutoSize = true;
            this.checkBoxDuongMonBoom.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDuongMonBoom.Location = new System.Drawing.Point(105, 181);
            this.checkBoxDuongMonBoom.Name = "checkBoxDuongMonBoom";
            this.checkBoxDuongMonBoom.Size = new System.Drawing.Size(85, 17);
            this.checkBoxDuongMonBoom.TabIndex = 327;
            this.checkBoxDuongMonBoom.Text = "ĐM đặt bom";
            this.checkBoxDuongMonBoom.UseVisualStyleBackColor = true;
            this.checkBoxDuongMonBoom.CheckedChanged += new System.EventHandler(this.checkBoxDuongMonBoom_CheckedChanged);
            // 
            // labelKieudame
            // 
            this.labelKieudame.AutoSize = true;
            this.labelKieudame.ForeColor = System.Drawing.Color.DarkRed;
            this.labelKieudame.Location = new System.Drawing.Point(105, 157);
            this.labelKieudame.Name = "labelKieudame";
            this.labelKieudame.Size = new System.Drawing.Size(16, 13);
            this.labelKieudame.TabIndex = 326;
            this.labelKieudame.Text = "...";
            // 
            // buttonThongke
            // 
            this.buttonThongke.BackColor = System.Drawing.SystemColors.Control;
            this.buttonThongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonThongke.ForeColor = System.Drawing.Color.Black;
            this.buttonThongke.Location = new System.Drawing.Point(3, 278);
            this.buttonThongke.Name = "buttonThongke";
            this.buttonThongke.Size = new System.Drawing.Size(45, 23);
            this.buttonThongke.TabIndex = 196;
            this.buttonThongke.Text = "T.Kê";
            this.buttonThongke.UseVisualStyleBackColor = false;
            this.buttonThongke.Click += new System.EventHandler(this.buttonThongke_Click);
            // 
            // comboBoxXuongNgua
            // 
            this.comboBoxXuongNgua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxXuongNgua.DropDownWidth = 120;
            this.comboBoxXuongNgua.ForeColor = System.Drawing.Color.Black;
            this.comboBoxXuongNgua.FormattingEnabled = true;
            this.comboBoxXuongNgua.Location = new System.Drawing.Point(105, 3);
            this.comboBoxXuongNgua.Name = "comboBoxXuongNgua";
            this.comboBoxXuongNgua.Size = new System.Drawing.Size(80, 21);
            this.comboBoxXuongNgua.TabIndex = 325;
            this.comboBoxXuongNgua.SelectedIndexChanged += new System.EventHandler(this.comboBoxXuongNgua_SelectedIndexChanged);
            // 
            // buttonSuadoTaicho
            // 
            this.buttonSuadoTaicho.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSuadoTaicho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSuadoTaicho.ForeColor = System.Drawing.Color.Black;
            this.buttonSuadoTaicho.Location = new System.Drawing.Point(48, 278);
            this.buttonSuadoTaicho.Name = "buttonSuadoTaicho";
            this.buttonSuadoTaicho.Size = new System.Drawing.Size(52, 23);
            this.buttonSuadoTaicho.TabIndex = 194;
            this.buttonSuadoTaicho.Text = "Sửa đồ";
            this.buttonSuadoTaicho.UseVisualStyleBackColor = false;
            this.buttonSuadoTaicho.Click += new System.EventHandler(this.buttonSuadoTaicho_Click);
            // 
            // buttonTatcaLuuruong
            // 
            this.buttonTatcaLuuruong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTatcaLuuruong.ForeColor = System.Drawing.Color.Black;
            this.buttonTatcaLuuruong.Location = new System.Drawing.Point(48, 238);
            this.buttonTatcaLuuruong.Name = "buttonTatcaLuuruong";
            this.buttonTatcaLuuruong.Size = new System.Drawing.Size(52, 38);
            this.buttonTatcaLuuruong.TabIndex = 190;
            this.buttonTatcaLuuruong.Text = "Lưu rương";
            this.buttonTatcaLuuruong.UseVisualStyleBackColor = true;
            this.buttonTatcaLuuruong.Click += new System.EventHandler(this.buttonTatcaLuuruong_Click);
            // 
            // checkBoxDameMacdinh
            // 
            this.checkBoxDameMacdinh.AutoSize = true;
            this.checkBoxDameMacdinh.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxDameMacdinh.Location = new System.Drawing.Point(3, 155);
            this.checkBoxDameMacdinh.Name = "checkBoxDameMacdinh";
            this.checkBoxDameMacdinh.Size = new System.Drawing.Size(93, 17);
            this.checkBoxDameMacdinh.TabIndex = 321;
            this.checkBoxDameMacdinh.Text = "Dame kết hợp";
            this.checkBoxDameMacdinh.UseVisualStyleBackColor = true;
            this.checkBoxDameMacdinh.CheckedChanged += new System.EventHandler(this.checkBoxDameMacdinh_CheckedChanged);
            // 
            // buttonMorong
            // 
            this.buttonMorong.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMorong.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonMorong.Location = new System.Drawing.Point(3, 238);
            this.buttonMorong.Name = "buttonMorong";
            this.buttonMorong.Size = new System.Drawing.Size(45, 38);
            this.buttonMorong.TabIndex = 208;
            this.buttonMorong.Text = "Mở rộng";
            this.buttonMorong.UseVisualStyleBackColor = false;
            this.buttonMorong.Click += new System.EventHandler(this.buttonMorong_Click);
            // 
            // buttonNgaMybuff
            // 
            this.buttonNgaMybuff.ForeColor = System.Drawing.Color.Black;
            this.buttonNgaMybuff.Location = new System.Drawing.Point(186, 128);
            this.buttonNgaMybuff.Name = "buttonNgaMybuff";
            this.buttonNgaMybuff.Size = new System.Drawing.Size(62, 21);
            this.buttonNgaMybuff.TabIndex = 168;
            this.buttonNgaMybuff.Text = "Kiểu buff";
            this.buttonNgaMybuff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNgaMybuff.UseVisualStyleBackColor = true;
            this.buttonNgaMybuff.Click += new System.EventHandler(this.buttonNgaMybuff_Click);
            // 
            // textBoxKhoangCachTheoSau
            // 
            this.textBoxKhoangCachTheoSau.ForeColor = System.Drawing.Color.Black;
            this.textBoxKhoangCachTheoSau.Location = new System.Drawing.Point(218, 280);
            this.textBoxKhoangCachTheoSau.Name = "textBoxKhoangCachTheoSau";
            this.textBoxKhoangCachTheoSau.Size = new System.Drawing.Size(30, 20);
            this.textBoxKhoangCachTheoSau.TabIndex = 218;
            this.textBoxKhoangCachTheoSau.TextChanged += new System.EventHandler(this.textBoxKhoangCachTheoSau_TextChanged);
            // 
            // buttonCashBua
            // 
            this.buttonCashBua.ForeColor = System.Drawing.Color.Black;
            this.buttonCashBua.Location = new System.Drawing.Point(186, 203);
            this.buttonCashBua.Name = "buttonCashBua";
            this.buttonCashBua.Size = new System.Drawing.Size(62, 21);
            this.buttonCashBua.TabIndex = 171;
            this.buttonCashBua.Text = "Loại bùa";
            this.buttonCashBua.UseVisualStyleBackColor = true;
            this.buttonCashBua.Click += new System.EventHandler(this.buttonCashBua_Click);
            // 
            // checkBoxTuCastBua
            // 
            this.checkBoxTuCastBua.AutoSize = true;
            this.checkBoxTuCastBua.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTuCastBua.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTuCastBua.Location = new System.Drawing.Point(105, 206);
            this.checkBoxTuCastBua.Name = "checkBoxTuCastBua";
            this.checkBoxTuCastBua.Size = new System.Drawing.Size(66, 17);
            this.checkBoxTuCastBua.TabIndex = 172;
            this.checkBoxTuCastBua.Text = "Buff bùa";
            this.checkBoxTuCastBua.UseVisualStyleBackColor = false;
            this.checkBoxTuCastBua.CheckedChanged += new System.EventHandler(this.checkBoxTuCastBua_CheckedChanged);
            // 
            // checkBoxTiepCan
            // 
            this.checkBoxTiepCan.AutoSize = true;
            this.checkBoxTiepCan.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTiepCan.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBoxTiepCan.Location = new System.Drawing.Point(106, 78);
            this.checkBoxTiepCan.Name = "checkBoxTiepCan";
            this.checkBoxTiepCan.Size = new System.Drawing.Size(96, 17);
            this.checkBoxTiepCan.TabIndex = 160;
            this.checkBoxTiepCan.Text = "Tiếp cận đánh";
            this.checkBoxTiepCan.UseVisualStyleBackColor = false;
            this.checkBoxTiepCan.CheckedChanged += new System.EventHandler(this.checkBoxTiepCan_CheckedChanged);
            // 
            // buttonDame
            // 
            this.buttonDame.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDame.ForeColor = System.Drawing.Color.Black;
            this.buttonDame.Location = new System.Drawing.Point(186, 153);
            this.buttonDame.Name = "buttonDame";
            this.buttonDame.Size = new System.Drawing.Size(62, 21);
            this.buttonDame.TabIndex = 324;
            this.buttonDame.Text = "Thiết lập";
            this.buttonDame.UseVisualStyleBackColor = false;
            this.buttonDame.Click += new System.EventHandler(this.buttonDame_Click);
            // 
            // checkBoxDanhquai
            // 
            this.checkBoxDanhquai.AutoSize = true;
            this.checkBoxDanhquai.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxDanhquai.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxDanhquai.Location = new System.Drawing.Point(3, 26);
            this.checkBoxDanhquai.Name = "checkBoxDanhquai";
            this.checkBoxDanhquai.Size = new System.Drawing.Size(75, 17);
            this.checkBoxDanhquai.TabIndex = 109;
            this.checkBoxDanhquai.Text = "Đánh quái";
            this.checkBoxDanhquai.UseVisualStyleBackColor = false;
            this.checkBoxDanhquai.CheckedChanged += new System.EventHandler(this.checkBoxDanhquai_CheckedChanged);
            // 
            // buttonUuTien
            // 
            this.buttonUuTien.ForeColor = System.Drawing.Color.Black;
            this.buttonUuTien.Location = new System.Drawing.Point(186, 27);
            this.buttonUuTien.Name = "buttonUuTien";
            this.buttonUuTien.Size = new System.Drawing.Size(62, 21);
            this.buttonUuTien.TabIndex = 209;
            this.buttonUuTien.Text = "Áp dụng";
            this.buttonUuTien.UseVisualStyleBackColor = true;
            this.buttonUuTien.Click += new System.EventHandler(this.buttonUuTien_Click);
            // 
            // labelTheoSauAll
            // 
            this.labelTheoSauAll.AutoSize = true;
            this.labelTheoSauAll.BackColor = System.Drawing.SystemColors.Control;
            this.labelTheoSauAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTheoSauAll.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTheoSauAll.Location = new System.Drawing.Point(172, 260);
            this.labelTheoSauAll.Name = "labelTheoSauAll";
            this.labelTheoSauAll.Size = new System.Drawing.Size(76, 13);
            this.labelTheoSauAll.TabIndex = 219;
            this.labelTheoSauAll.Text = "áp dụng tất cả";
            this.labelTheoSauAll.Click += new System.EventHandler(this.labelTheoSauAll_Click);
            // 
            // buttonLoaitruAccBuff
            // 
            this.buttonLoaitruAccBuff.ForeColor = System.Drawing.Color.Black;
            this.buttonLoaitruAccBuff.Location = new System.Drawing.Point(186, 3);
            this.buttonLoaitruAccBuff.Name = "buttonLoaitruAccBuff";
            this.buttonLoaitruAccBuff.Size = new System.Drawing.Size(62, 21);
            this.buttonLoaitruAccBuff.TabIndex = 175;
            this.buttonLoaitruAccBuff.Text = "Loại trừ";
            this.buttonLoaitruAccBuff.UseVisualStyleBackColor = true;
            this.buttonLoaitruAccBuff.Click += new System.EventHandler(this.buttonLoaitruAccBuff_Click);
            // 
            // comboBoxNhatdo
            // 
            this.comboBoxNhatdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNhatdo.DropDownWidth = 80;
            this.comboBoxNhatdo.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNhatdo.FormattingEnabled = true;
            this.comboBoxNhatdo.Location = new System.Drawing.Point(186, 230);
            this.comboBoxNhatdo.Name = "comboBoxNhatdo";
            this.comboBoxNhatdo.Size = new System.Drawing.Size(62, 21);
            this.comboBoxNhatdo.TabIndex = 173;
            this.comboBoxNhatdo.SelectedIndexChanged += new System.EventHandler(this.comboBoxNhatdo_SelectedIndexChanged);
            // 
            // checkBoxNhatdo
            // 
            this.checkBoxNhatdo.AutoSize = true;
            this.checkBoxNhatdo.ForeColor = System.Drawing.Color.Black;
            this.checkBoxNhatdo.Location = new System.Drawing.Point(105, 232);
            this.checkBoxNhatdo.Name = "checkBoxNhatdo";
            this.checkBoxNhatdo.Size = new System.Drawing.Size(49, 17);
            this.checkBoxNhatdo.TabIndex = 174;
            this.checkBoxNhatdo.Text = "Nhặt";
            this.checkBoxNhatdo.UseVisualStyleBackColor = true;
            this.checkBoxNhatdo.CheckedChanged += new System.EventHandler(this.checkBoxNhatdo_CheckedChanged);
            // 
            // comboBoxTheoSau
            // 
            this.comboBoxTheoSau.DropDownWidth = 110;
            this.comboBoxTheoSau.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTheoSau.FormattingEnabled = true;
            this.comboBoxTheoSau.Location = new System.Drawing.Point(105, 279);
            this.comboBoxTheoSau.Name = "comboBoxTheoSau";
            this.comboBoxTheoSau.Size = new System.Drawing.Size(111, 21);
            this.comboBoxTheoSau.TabIndex = 163;
            this.comboBoxTheoSau.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheoSau_SelectedIndexChanged);
            this.comboBoxTheoSau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxTheoSau_MouseDown);
            // 
            // checkBoxChetnamIm
            // 
            this.checkBoxChetnamIm.AutoSize = true;
            this.checkBoxChetnamIm.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxChetnamIm.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChetnamIm.Location = new System.Drawing.Point(3, 78);
            this.checkBoxChetnamIm.Name = "checkBoxChetnamIm";
            this.checkBoxChetnamIm.Size = new System.Drawing.Size(71, 17);
            this.checkBoxChetnamIm.TabIndex = 165;
            this.checkBoxChetnamIm.Text = "Chết nằm";
            this.checkBoxChetnamIm.UseVisualStyleBackColor = false;
            this.checkBoxChetnamIm.CheckedChanged += new System.EventHandler(this.checkBoxChetnamIm_CheckedChanged);
            // 
            // checkBoxTheoSau
            // 
            this.checkBoxTheoSau.AutoSize = true;
            this.checkBoxTheoSau.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTheoSau.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTheoSau.Location = new System.Drawing.Point(105, 258);
            this.checkBoxTheoSau.Name = "checkBoxTheoSau";
            this.checkBoxTheoSau.Size = new System.Drawing.Size(71, 17);
            this.checkBoxTheoSau.TabIndex = 217;
            this.checkBoxTheoSau.Text = "Theo sau";
            this.checkBoxTheoSau.UseVisualStyleBackColor = false;
            this.checkBoxTheoSau.CheckedChanged += new System.EventHandler(this.checkBoxTheoSau_CheckedChanged);
            // 
            // textBoxTimerNgamyBuff
            // 
            this.textBoxTimerNgamyBuff.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimerNgamyBuff.Location = new System.Drawing.Point(142, 128);
            this.textBoxTimerNgamyBuff.Name = "textBoxTimerNgamyBuff";
            this.textBoxTimerNgamyBuff.Size = new System.Drawing.Size(42, 20);
            this.textBoxTimerNgamyBuff.TabIndex = 170;
            this.textBoxTimerNgamyBuff.Text = "3000";
            this.textBoxTimerNgamyBuff.TextChanged += new System.EventHandler(this.textBoxTimerNgamyBuff_TextChanged);
            // 
            // textBoxNgamyBuff
            // 
            this.textBoxNgamyBuff.ForeColor = System.Drawing.Color.Black;
            this.textBoxNgamyBuff.Location = new System.Drawing.Point(104, 128);
            this.textBoxNgamyBuff.Name = "textBoxNgamyBuff";
            this.textBoxNgamyBuff.Size = new System.Drawing.Size(35, 20);
            this.textBoxNgamyBuff.TabIndex = 169;
            this.textBoxNgamyBuff.Text = "150";
            this.textBoxNgamyBuff.TextChanged += new System.EventHandler(this.textBoxNgamyBuff_TextChanged);
            // 
            // checkBoxNgamyBuff
            // 
            this.checkBoxNgamyBuff.AutoSize = true;
            this.checkBoxNgamyBuff.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxNgamyBuff.ForeColor = System.Drawing.Color.Black;
            this.checkBoxNgamyBuff.Location = new System.Drawing.Point(3, 130);
            this.checkBoxNgamyBuff.Name = "checkBoxNgamyBuff";
            this.checkBoxNgamyBuff.Size = new System.Drawing.Size(94, 17);
            this.checkBoxNgamyBuff.TabIndex = 167;
            this.checkBoxNgamyBuff.Text = "Nga my buff %";
            this.checkBoxNgamyBuff.UseVisualStyleBackColor = false;
            this.checkBoxNgamyBuff.CheckedChanged += new System.EventHandler(this.checkBoxNgamyBuff_CheckedChanged);
            // 
            // checkBoxTamQuet
            // 
            this.checkBoxTamQuet.AutoSize = true;
            this.checkBoxTamQuet.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTamQuet.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTamQuet.Location = new System.Drawing.Point(105, 53);
            this.checkBoxTamQuet.Name = "checkBoxTamQuet";
            this.checkBoxTamQuet.Size = new System.Drawing.Size(116, 17);
            this.checkBoxTamQuet.TabIndex = 162;
            this.checkBoxTamQuet.Text = "Phạm vi tìm đối thủ";
            this.checkBoxTamQuet.UseVisualStyleBackColor = false;
            this.checkBoxTamQuet.CheckedChanged += new System.EventHandler(this.checkBoxTamQuet_CheckedChanged);
            // 
            // textBoxKhoangCachTiepcan
            // 
            this.textBoxKhoangCachTiepcan.ForeColor = System.Drawing.Color.Black;
            this.textBoxKhoangCachTiepcan.Location = new System.Drawing.Point(218, 76);
            this.textBoxKhoangCachTiepcan.Name = "textBoxKhoangCachTiepcan";
            this.textBoxKhoangCachTiepcan.Size = new System.Drawing.Size(30, 20);
            this.textBoxKhoangCachTiepcan.TabIndex = 159;
            this.textBoxKhoangCachTiepcan.TextChanged += new System.EventHandler(this.textBoxKhoangCachTiepcan_TextChanged);
            // 
            // comboBoxUuTien
            // 
            this.comboBoxUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUuTien.DropDownWidth = 80;
            this.comboBoxUuTien.ForeColor = System.Drawing.Color.Black;
            this.comboBoxUuTien.FormattingEnabled = true;
            this.comboBoxUuTien.Location = new System.Drawing.Point(105, 26);
            this.comboBoxUuTien.Name = "comboBoxUuTien";
            this.comboBoxUuTien.Size = new System.Drawing.Size(80, 21);
            this.comboBoxUuTien.TabIndex = 157;
            this.comboBoxUuTien.SelectedIndexChanged += new System.EventHandler(this.comboBoxUuTien_SelectedIndexChanged);
            // 
            // checkBoxUutienDanhquai
            // 
            this.checkBoxUutienDanhquai.AutoSize = true;
            this.checkBoxUutienDanhquai.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxUutienDanhquai.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxUutienDanhquai.Location = new System.Drawing.Point(3, 53);
            this.checkBoxUutienDanhquai.Name = "checkBoxUutienDanhquai";
            this.checkBoxUutienDanhquai.Size = new System.Drawing.Size(72, 17);
            this.checkBoxUutienDanhquai.TabIndex = 117;
            this.checkBoxUutienDanhquai.Text = "Đánh bos";
            this.checkBoxUutienDanhquai.UseVisualStyleBackColor = false;
            this.checkBoxUutienDanhquai.CheckedChanged += new System.EventHandler(this.checkBoxUutienDanhquai_CheckedChanged);
            // 
            // checkBoxTuve
            // 
            this.checkBoxTuve.AutoSize = true;
            this.checkBoxTuve.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTuve.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxTuve.Location = new System.Drawing.Point(3, 3);
            this.checkBoxTuve.Name = "checkBoxTuve";
            this.checkBoxTuve.Size = new System.Drawing.Size(81, 17);
            this.checkBoxTuve.TabIndex = 110;
            this.checkBoxTuve.Text = "Đánh người";
            this.checkBoxTuve.UseVisualStyleBackColor = false;
            this.checkBoxTuve.CheckedChanged += new System.EventHandler(this.checkBoxTuve_CheckedChanged);
            // 
            // tabPageBang2
            // 
            this.tabPageBang2.Controls.Add(this.comboBoxCLD);
            this.tabPageBang2.Controls.Add(this.checkBoxTHPChienLong);
            this.tabPageBang2.Controls.Add(this.checkBoxDenToadoLeave);
            this.tabPageBang2.Controls.Add(this.buttonMayphuLayToado);
            this.tabPageBang2.Controls.Add(this.buttonQuangThuoc);
            this.tabPageBang2.Controls.Add(this.checkBoxQuangThuoc);
            this.tabPageBang2.Controls.Add(this.buttonDiemTapket);
            this.tabPageBang2.Controls.Add(this.checkBoxDiemTapket);
            this.tabPageBang2.Controls.Add(this.checkBoxVuotAi);
            this.tabPageBang2.Controls.Add(this.buttonMayphuXoaToado);
            this.tabPageBang2.Controls.Add(this.checkBoxChienLongdong);
            this.tabPageBang2.Controls.Add(this.buttonBungThuoc);
            this.tabPageBang2.Controls.Add(this.buttonLayToado);
            this.tabPageBang2.Controls.Add(this.checkBoxDenToadoALL);
            this.tabPageBang2.Controls.Add(this.textBoxMayphuToado);
            this.tabPageBang2.Controls.Add(this.textBoxToadoDen);
            this.tabPageBang2.Controls.Add(this.checkBoxMayphuToado);
            this.tabPageBang2.Controls.Add(this.buttonXoaToado);
            this.tabPageBang2.Controls.Add(this.checkBoxDenToadoUser);
            this.tabPageBang2.Location = new System.Drawing.Point(4, 22);
            this.tabPageBang2.Name = "tabPageBang2";
            this.tabPageBang2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBang2.Size = new System.Drawing.Size(251, 303);
            this.tabPageBang2.TabIndex = 3;
            this.tabPageBang2.Text = "Bảng 2";
            this.tabPageBang2.UseVisualStyleBackColor = true;
            // 
            // comboBoxCLD
            // 
            this.comboBoxCLD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCLD.DropDownWidth = 60;
            this.comboBoxCLD.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCLD.FormattingEnabled = true;
            this.comboBoxCLD.Location = new System.Drawing.Point(138, 1);
            this.comboBoxCLD.Name = "comboBoxCLD";
            this.comboBoxCLD.Size = new System.Drawing.Size(110, 21);
            this.comboBoxCLD.TabIndex = 206;
            this.comboBoxCLD.SelectedIndexChanged += new System.EventHandler(this.comboBoxCLD_SelectedIndexChanged);
            // 
            // checkBoxTHPChienLong
            // 
            this.checkBoxTHPChienLong.AutoSize = true;
            this.checkBoxTHPChienLong.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBoxTHPChienLong.Location = new System.Drawing.Point(16, 27);
            this.checkBoxTHPChienLong.Name = "checkBoxTHPChienLong";
            this.checkBoxTHPChienLong.Size = new System.Drawing.Size(232, 17);
            this.checkBoxTHPChienLong.TabIndex = 272;
            this.checkBoxTHPChienLong.Text = "Chỉ dùng Thần hành phù lên Ch.Long động";
            this.checkBoxTHPChienLong.UseVisualStyleBackColor = true;
            this.checkBoxTHPChienLong.CheckedChanged += new System.EventHandler(this.checkBoxTHPChienLong_CheckedChanged);
            // 
            // checkBoxDenToadoLeave
            // 
            this.checkBoxDenToadoLeave.AutoSize = true;
            this.checkBoxDenToadoLeave.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxDenToadoLeave.Location = new System.Drawing.Point(16, 176);
            this.checkBoxDenToadoLeave.Name = "checkBoxDenToadoLeave";
            this.checkBoxDenToadoLeave.Size = new System.Drawing.Size(208, 17);
            this.checkBoxDenToadoLeave.TabIndex = 271;
            this.checkBoxDenToadoLeave.Text = "Tìm ac chính sau khi đến tọa độ xong";
            this.checkBoxDenToadoLeave.UseVisualStyleBackColor = true;
            this.checkBoxDenToadoLeave.CheckedChanged += new System.EventHandler(this.checkBoxDenToadoLeave_CheckedChanged);
            // 
            // buttonMayphuLayToado
            // 
            this.buttonMayphuLayToado.Location = new System.Drawing.Point(188, 231);
            this.buttonMayphuLayToado.Name = "buttonMayphuLayToado";
            this.buttonMayphuLayToado.Size = new System.Drawing.Size(39, 21);
            this.buttonMayphuLayToado.TabIndex = 269;
            this.buttonMayphuLayToado.Text = "Lấy";
            this.buttonMayphuLayToado.UseVisualStyleBackColor = true;
            this.buttonMayphuLayToado.Click += new System.EventHandler(this.buttonMayphuLayToado_Click);
            // 
            // buttonQuangThuoc
            // 
            this.buttonQuangThuoc.Location = new System.Drawing.Point(190, 93);
            this.buttonQuangThuoc.Name = "buttonQuangThuoc";
            this.buttonQuangThuoc.Size = new System.Drawing.Size(60, 23);
            this.buttonQuangThuoc.TabIndex = 212;
            this.buttonQuangThuoc.Text = "Thiết lập";
            this.buttonQuangThuoc.UseVisualStyleBackColor = true;
            this.buttonQuangThuoc.Click += new System.EventHandler(this.buttonQuangThuoc_Click);
            // 
            // checkBoxQuangThuoc
            // 
            this.checkBoxQuangThuoc.AutoSize = true;
            this.checkBoxQuangThuoc.Location = new System.Drawing.Point(3, 96);
            this.checkBoxQuangThuoc.Name = "checkBoxQuangThuoc";
            this.checkBoxQuangThuoc.Size = new System.Drawing.Size(154, 17);
            this.checkBoxQuangThuoc.TabIndex = 210;
            this.checkBoxQuangThuoc.Text = "Đây là ac quăng tiếp thuốc";
            this.checkBoxQuangThuoc.UseVisualStyleBackColor = true;
            this.checkBoxQuangThuoc.CheckedChanged += new System.EventHandler(this.checkBoxQuangThuoc_CheckedChanged);
            // 
            // buttonDiemTapket
            // 
            this.buttonDiemTapket.Location = new System.Drawing.Point(190, 122);
            this.buttonDiemTapket.Name = "buttonDiemTapket";
            this.buttonDiemTapket.Size = new System.Drawing.Size(60, 23);
            this.buttonDiemTapket.TabIndex = 209;
            this.buttonDiemTapket.Text = "Thiết lập";
            this.buttonDiemTapket.UseVisualStyleBackColor = true;
            this.buttonDiemTapket.Click += new System.EventHandler(this.buttonDiemTapket_Click);
            // 
            // checkBoxDiemTapket
            // 
            this.checkBoxDiemTapket.AutoSize = true;
            this.checkBoxDiemTapket.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxDiemTapket.Location = new System.Drawing.Point(3, 124);
            this.checkBoxDiemTapket.Name = "checkBoxDiemTapket";
            this.checkBoxDiemTapket.Size = new System.Drawing.Size(147, 17);
            this.checkBoxDiemTapket.TabIndex = 208;
            this.checkBoxDiemTapket.Text = "Đi đến điểm tập kết khác";
            this.checkBoxDiemTapket.UseVisualStyleBackColor = true;
            this.checkBoxDiemTapket.CheckedChanged += new System.EventHandler(this.checkBoxDiemTapket_CheckedChanged);
            // 
            // checkBoxVuotAi
            // 
            this.checkBoxVuotAi.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxVuotAi.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxVuotAi.Location = new System.Drawing.Point(3, 55);
            this.checkBoxVuotAi.Name = "checkBoxVuotAi";
            this.checkBoxVuotAi.Size = new System.Drawing.Size(245, 32);
            this.checkBoxVuotAi.TabIndex = 207;
            this.checkBoxVuotAi.Text = "Vượt ải: bỏ qua không đánh các quái phản dame (vượt ải chọn chế độ war nhé)";
            this.checkBoxVuotAi.UseVisualStyleBackColor = false;
            this.checkBoxVuotAi.CheckedChanged += new System.EventHandler(this.checkBoxVuotAi_CheckedChanged);
            // 
            // buttonMayphuXoaToado
            // 
            this.buttonMayphuXoaToado.Location = new System.Drawing.Point(230, 231);
            this.buttonMayphuXoaToado.Name = "buttonMayphuXoaToado";
            this.buttonMayphuXoaToado.Size = new System.Drawing.Size(20, 21);
            this.buttonMayphuXoaToado.TabIndex = 270;
            this.buttonMayphuXoaToado.Text = "X";
            this.buttonMayphuXoaToado.UseVisualStyleBackColor = true;
            this.buttonMayphuXoaToado.Click += new System.EventHandler(this.buttonMayphuXoaToado_Click);
            // 
            // checkBoxChienLongdong
            // 
            this.checkBoxChienLongdong.AutoSize = true;
            this.checkBoxChienLongdong.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxChienLongdong.Location = new System.Drawing.Point(3, 4);
            this.checkBoxChienLongdong.Name = "checkBoxChienLongdong";
            this.checkBoxChienLongdong.Size = new System.Drawing.Size(137, 17);
            this.checkBoxChienLongdong.TabIndex = 205;
            this.checkBoxChienLongdong.Text = "Đánh Chiến Long động";
            this.checkBoxChienLongdong.UseVisualStyleBackColor = true;
            this.checkBoxChienLongdong.CheckedChanged += new System.EventHandler(this.checkBoxChienLongdong_CheckedChanged);
            // 
            // buttonBungThuoc
            // 
            this.buttonBungThuoc.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBungThuoc.ForeColor = System.Drawing.Color.Black;
            this.buttonBungThuoc.Location = new System.Drawing.Point(158, 93);
            this.buttonBungThuoc.Name = "buttonBungThuoc";
            this.buttonBungThuoc.Size = new System.Drawing.Size(30, 23);
            this.buttonBungThuoc.TabIndex = 192;
            this.buttonBungThuoc.Text = "Q";
            this.buttonBungThuoc.UseVisualStyleBackColor = false;
            this.buttonBungThuoc.Click += new System.EventHandler(this.buttonBungThuoc_Click);
            // 
            // buttonLayToado
            // 
            this.buttonLayToado.Location = new System.Drawing.Point(188, 151);
            this.buttonLayToado.Name = "buttonLayToado";
            this.buttonLayToado.Size = new System.Drawing.Size(39, 21);
            this.buttonLayToado.TabIndex = 260;
            this.buttonLayToado.Text = "Lấy";
            this.buttonLayToado.UseVisualStyleBackColor = true;
            this.buttonLayToado.Click += new System.EventHandler(this.buttonLayToado_Click);
            // 
            // checkBoxDenToadoALL
            // 
            this.checkBoxDenToadoALL.AutoSize = true;
            this.checkBoxDenToadoALL.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxDenToadoALL.Location = new System.Drawing.Point(16, 199);
            this.checkBoxDenToadoALL.Name = "checkBoxDenToadoALL";
            this.checkBoxDenToadoALL.Size = new System.Drawing.Size(227, 17);
            this.checkBoxDenToadoALL.TabIndex = 258;
            this.checkBoxDenToadoALL.Text = "Áp dụng đến tọa độ tất cả (luôn  máy phụ)";
            this.checkBoxDenToadoALL.UseVisualStyleBackColor = true;
            this.checkBoxDenToadoALL.CheckedChanged += new System.EventHandler(this.checkBoxDenToadoALL_CheckedChanged);
            // 
            // textBoxMayphuToado
            // 
            this.textBoxMayphuToado.BackColor = System.Drawing.Color.White;
            this.textBoxMayphuToado.ForeColor = System.Drawing.Color.Black;
            this.textBoxMayphuToado.Location = new System.Drawing.Point(119, 232);
            this.textBoxMayphuToado.Name = "textBoxMayphuToado";
            this.textBoxMayphuToado.ReadOnly = true;
            this.textBoxMayphuToado.Size = new System.Drawing.Size(65, 20);
            this.textBoxMayphuToado.TabIndex = 268;
            // 
            // textBoxToadoDen
            // 
            this.textBoxToadoDen.BackColor = System.Drawing.Color.White;
            this.textBoxToadoDen.ForeColor = System.Drawing.Color.Black;
            this.textBoxToadoDen.Location = new System.Drawing.Point(119, 152);
            this.textBoxToadoDen.Name = "textBoxToadoDen";
            this.textBoxToadoDen.ReadOnly = true;
            this.textBoxToadoDen.Size = new System.Drawing.Size(65, 20);
            this.textBoxToadoDen.TabIndex = 259;
            // 
            // checkBoxMayphuToado
            // 
            this.checkBoxMayphuToado.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMayphuToado.Location = new System.Drawing.Point(3, 224);
            this.checkBoxMayphuToado.Name = "checkBoxMayphuToado";
            this.checkBoxMayphuToado.Size = new System.Drawing.Size(112, 32);
            this.checkBoxMayphuToado.TabIndex = 267;
            this.checkBoxMayphuToado.Text = "Máy phụ luôn đến tọa độ bên";
            this.checkBoxMayphuToado.UseVisualStyleBackColor = true;
            this.checkBoxMayphuToado.CheckedChanged += new System.EventHandler(this.checkBoxMayphuToado_CheckedChanged);
            // 
            // buttonXoaToado
            // 
            this.buttonXoaToado.Location = new System.Drawing.Point(230, 151);
            this.buttonXoaToado.Name = "buttonXoaToado";
            this.buttonXoaToado.Size = new System.Drawing.Size(20, 21);
            this.buttonXoaToado.TabIndex = 263;
            this.buttonXoaToado.Text = "X";
            this.buttonXoaToado.UseVisualStyleBackColor = true;
            this.buttonXoaToado.Click += new System.EventHandler(this.buttonXoaToado_Click);
            // 
            // checkBoxDenToadoUser
            // 
            this.checkBoxDenToadoUser.AutoSize = true;
            this.checkBoxDenToadoUser.Location = new System.Drawing.Point(3, 154);
            this.checkBoxDenToadoUser.Name = "checkBoxDenToadoUser";
            this.checkBoxDenToadoUser.Size = new System.Drawing.Size(115, 17);
            this.checkBoxDenToadoUser.TabIndex = 264;
            this.checkBoxDenToadoUser.Text = "Đến tọa độ (WAR)";
            this.checkBoxDenToadoUser.UseVisualStyleBackColor = true;
            this.checkBoxDenToadoUser.CheckedChanged += new System.EventHandler(this.checkBoxDenToadoUser_CheckedChanged);
            // 
            // tabPageTongKim
            // 
            this.tabPageTongKim.Controls.Add(this.groupBox5);
            this.tabPageTongKim.Location = new System.Drawing.Point(4, 22);
            this.tabPageTongKim.Name = "tabPageTongKim";
            this.tabPageTongKim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTongKim.Size = new System.Drawing.Size(251, 303);
            this.tabPageTongKim.TabIndex = 6;
            this.tabPageTongKim.Text = "TK";
            this.tabPageTongKim.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.textBoxClickMenuTS);
            this.groupBox5.Controls.Add(this.comboBoxTrinhsat);
            this.groupBox5.Controls.Add(this.labelToadoTrinhsat);
            this.groupBox5.Controls.Add(this.textBoxTruotTK);
            this.groupBox5.Controls.Add(this.checkBoxDanhHieuuy);
            this.groupBox5.Controls.Add(this.checkBoxTKThanhTruot);
            this.groupBox5.Controls.Add(this.checkBoxAccPhuHauDoanh);
            this.groupBox5.Controls.Add(this.checkBoxTatMuamauTK);
            this.groupBox5.Controls.Add(this.checkBoxTubaoDanh);
            this.groupBox5.Controls.Add(this.checkBoxAnThuocTDD);
            this.groupBox5.Controls.Add(this.checkBoxTrinhSat);
            this.groupBox5.Controls.Add(this.comboBoxVaodiemBaodanh);
            this.groupBox5.Controls.Add(this.checkBoxTongKimXemSoluong);
            this.groupBox5.Controls.Add(this.textBoxTocdoDanh);
            this.groupBox5.Controls.Add(this.checkBoxAnThuocLag);
            this.groupBox5.Controls.Add(this.checkBoxAccChinhHauDoanh);
            this.groupBox5.Controls.Add(this.buttonThuocTDD);
            this.groupBox5.Controls.Add(this.buttonThuocLag);
            this.groupBox5.Location = new System.Drawing.Point(1, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 302);
            this.groupBox5.TabIndex = 212;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tống Kim và Phong Hỏa Liên thành";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.MediumBlue;
            this.label22.Location = new System.Drawing.Point(28, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(155, 13);
            this.label22.TabIndex = 219;
            this.label22.Text = "Có click vào menu, dòng (1,2..)";
            // 
            // textBoxClickMenuTS
            // 
            this.textBoxClickMenuTS.Location = new System.Drawing.Point(210, 123);
            this.textBoxClickMenuTS.Name = "textBoxClickMenuTS";
            this.textBoxClickMenuTS.Size = new System.Drawing.Size(32, 20);
            this.textBoxClickMenuTS.TabIndex = 218;
            this.textBoxClickMenuTS.TextChanged += new System.EventHandler(this.textBoxClickMenuTS_TextChanged);
            // 
            // comboBoxTrinhsat
            // 
            this.comboBoxTrinhsat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrinhsat.DropDownWidth = 110;
            this.comboBoxTrinhsat.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTrinhsat.FormattingEnabled = true;
            this.comboBoxTrinhsat.Location = new System.Drawing.Point(147, 98);
            this.comboBoxTrinhsat.Name = "comboBoxTrinhsat";
            this.comboBoxTrinhsat.Size = new System.Drawing.Size(96, 21);
            this.comboBoxTrinhsat.TabIndex = 216;
            this.comboBoxTrinhsat.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrinhsat_SelectedIndexChanged);
            this.comboBoxTrinhsat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxTrinhsat_MouseDown);
            // 
            // labelToadoTrinhsat
            // 
            this.labelToadoTrinhsat.AutoSize = true;
            this.labelToadoTrinhsat.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelToadoTrinhsat.Location = new System.Drawing.Point(160, 81);
            this.labelToadoTrinhsat.Name = "labelToadoTrinhsat";
            this.labelToadoTrinhsat.Size = new System.Drawing.Size(64, 13);
            this.labelToadoTrinhsat.TabIndex = 217;
            this.labelToadoTrinhsat.Text = "{ ... tọa độ }";
            // 
            // textBoxTruotTK
            // 
            this.textBoxTruotTK.ForeColor = System.Drawing.Color.Black;
            this.textBoxTruotTK.Location = new System.Drawing.Point(210, 153);
            this.textBoxTruotTK.Name = "textBoxTruotTK";
            this.textBoxTruotTK.Size = new System.Drawing.Size(33, 20);
            this.textBoxTruotTK.TabIndex = 215;
            this.textBoxTruotTK.TextChanged += new System.EventHandler(this.textBoxTruotTK_TextChanged);
            // 
            // checkBoxDanhHieuuy
            // 
            this.checkBoxDanhHieuuy.AutoSize = true;
            this.checkBoxDanhHieuuy.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxDanhHieuuy.Location = new System.Drawing.Point(11, 280);
            this.checkBoxDanhHieuuy.Name = "checkBoxDanhHieuuy";
            this.checkBoxDanhHieuuy.Size = new System.Drawing.Size(221, 17);
            this.checkBoxDanhHieuuy.TabIndex = 214;
            this.checkBoxDanhHieuuy.Text = "Đánh hiệu úy, phó tướng, đại tướng .v.v..";
            this.checkBoxDanhHieuuy.UseVisualStyleBackColor = true;
            this.checkBoxDanhHieuuy.CheckedChanged += new System.EventHandler(this.checkBoxDanhHieuuy_CheckedChanged);
            // 
            // checkBoxTKThanhTruot
            // 
            this.checkBoxTKThanhTruot.AutoSize = true;
            this.checkBoxTKThanhTruot.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxTKThanhTruot.Location = new System.Drawing.Point(11, 153);
            this.checkBoxTKThanhTruot.Name = "checkBoxTKThanhTruot";
            this.checkBoxTKThanhTruot.Size = new System.Drawing.Size(198, 17);
            this.checkBoxTKThanhTruot.TabIndex = 213;
            this.checkBoxTKThanhTruot.Text = "Có thanh trượt khi chạy ra ngoài cửa";
            this.checkBoxTKThanhTruot.UseVisualStyleBackColor = true;
            this.checkBoxTKThanhTruot.CheckedChanged += new System.EventHandler(this.checkBoxTKThanhTruot_CheckedChanged);
            // 
            // checkBoxAccPhuHauDoanh
            // 
            this.checkBoxAccPhuHauDoanh.AutoSize = true;
            this.checkBoxAccPhuHauDoanh.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAccPhuHauDoanh.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAccPhuHauDoanh.Location = new System.Drawing.Point(11, 42);
            this.checkBoxAccPhuHauDoanh.Name = "checkBoxAccPhuHauDoanh";
            this.checkBoxAccPhuHauDoanh.Size = new System.Drawing.Size(216, 17);
            this.checkBoxAccPhuHauDoanh.TabIndex = 149;
            this.checkBoxAccPhuHauDoanh.Text = "Ac phụ chờ ac chính ra khỏi hậu doanh";
            this.checkBoxAccPhuHauDoanh.UseVisualStyleBackColor = false;
            this.checkBoxAccPhuHauDoanh.CheckedChanged += new System.EventHandler(this.checkBoxAccPhuHauDoanh_CheckedChanged);
            // 
            // checkBoxTatMuamauTK
            // 
            this.checkBoxTatMuamauTK.AutoSize = true;
            this.checkBoxTatMuamauTK.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxTatMuamauTK.Location = new System.Drawing.Point(11, 234);
            this.checkBoxTatMuamauTK.Name = "checkBoxTatMuamauTK";
            this.checkBoxTatMuamauTK.Size = new System.Drawing.Size(231, 17);
            this.checkBoxTatMuamauTK.TabIndex = 212;
            this.checkBoxTatMuamauTK.Text = "Tắt mua máu ở hậu cần khi đánh Tống kim";
            this.checkBoxTatMuamauTK.UseVisualStyleBackColor = true;
            this.checkBoxTatMuamauTK.CheckedChanged += new System.EventHandler(this.checkBoxTatMuamauTK_CheckedChanged);
            // 
            // checkBoxTubaoDanh
            // 
            this.checkBoxTubaoDanh.AutoSize = true;
            this.checkBoxTubaoDanh.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxTubaoDanh.Location = new System.Drawing.Point(11, 19);
            this.checkBoxTubaoDanh.Name = "checkBoxTubaoDanh";
            this.checkBoxTubaoDanh.Size = new System.Drawing.Size(135, 17);
            this.checkBoxTubaoDanh.TabIndex = 170;
            this.checkBoxTubaoDanh.Text = "Tự báo danh Tống Kim";
            this.checkBoxTubaoDanh.UseVisualStyleBackColor = true;
            this.checkBoxTubaoDanh.CheckedChanged += new System.EventHandler(this.checkBoxTubaoDanh_CheckedChanged);
            // 
            // checkBoxAnThuocTDD
            // 
            this.checkBoxAnThuocTDD.AutoSize = true;
            this.checkBoxAnThuocTDD.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAnThuocTDD.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAnThuocTDD.Location = new System.Drawing.Point(11, 202);
            this.checkBoxAnThuocTDD.Name = "checkBoxAnThuocTDD";
            this.checkBoxAnThuocTDD.Size = new System.Drawing.Size(133, 17);
            this.checkBoxAnThuocTDD.TabIndex = 166;
            this.checkBoxAnThuocTDD.Text = "Ăn khi tốc độ đánh <=";
            this.checkBoxAnThuocTDD.UseVisualStyleBackColor = false;
            this.checkBoxAnThuocTDD.CheckedChanged += new System.EventHandler(this.checkBoxAnThuocTDD_CheckedChanged);
            // 
            // checkBoxTrinhSat
            // 
            this.checkBoxTrinhSat.AutoSize = true;
            this.checkBoxTrinhSat.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTrinhSat.ForeColor = System.Drawing.Color.MediumBlue;
            this.checkBoxTrinhSat.Location = new System.Drawing.Point(11, 100);
            this.checkBoxTrinhSat.Name = "checkBoxTrinhSat";
            this.checkBoxTrinhSat.Size = new System.Drawing.Size(137, 17);
            this.checkBoxTrinhSat.TabIndex = 160;
            this.checkBoxTrinhSat.Text = "Ra bằng trinh sát, tên...";
            this.checkBoxTrinhSat.UseVisualStyleBackColor = false;
            this.checkBoxTrinhSat.CheckedChanged += new System.EventHandler(this.checkBoxTrinhSat_CheckedChanged);
            // 
            // comboBoxVaodiemBaodanh
            // 
            this.comboBoxVaodiemBaodanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVaodiemBaodanh.FormattingEnabled = true;
            this.comboBoxVaodiemBaodanh.Location = new System.Drawing.Point(147, 17);
            this.comboBoxVaodiemBaodanh.Name = "comboBoxVaodiemBaodanh";
            this.comboBoxVaodiemBaodanh.Size = new System.Drawing.Size(96, 21);
            this.comboBoxVaodiemBaodanh.TabIndex = 157;
            this.comboBoxVaodiemBaodanh.SelectedIndexChanged += new System.EventHandler(this.comboBoxVaodiemBaodanh_SelectedIndexChanged);
            // 
            // checkBoxTongKimXemSoluong
            // 
            this.checkBoxTongKimXemSoluong.AutoSize = true;
            this.checkBoxTongKimXemSoluong.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTongKimXemSoluong.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxTongKimXemSoluong.Location = new System.Drawing.Point(11, 259);
            this.checkBoxTongKimXemSoluong.Name = "checkBoxTongKimXemSoluong";
            this.checkBoxTongKimXemSoluong.Size = new System.Drawing.Size(137, 17);
            this.checkBoxTongKimXemSoluong.TabIndex = 169;
            this.checkBoxTongKimXemSoluong.Text = "Xem điểm (trên đầu ac)";
            this.checkBoxTongKimXemSoluong.UseVisualStyleBackColor = false;
            this.checkBoxTongKimXemSoluong.CheckedChanged += new System.EventHandler(this.checkBoxTongKimXemSoluong_CheckedChanged);
            // 
            // textBoxTocdoDanh
            // 
            this.textBoxTocdoDanh.ForeColor = System.Drawing.Color.Black;
            this.textBoxTocdoDanh.Location = new System.Drawing.Point(147, 202);
            this.textBoxTocdoDanh.Name = "textBoxTocdoDanh";
            this.textBoxTocdoDanh.Size = new System.Drawing.Size(30, 20);
            this.textBoxTocdoDanh.TabIndex = 146;
            this.textBoxTocdoDanh.TextChanged += new System.EventHandler(this.textBoxTocdoDanh_TextChanged);
            // 
            // checkBoxAnThuocLag
            // 
            this.checkBoxAnThuocLag.AutoSize = true;
            this.checkBoxAnThuocLag.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAnThuocLag.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAnThuocLag.Location = new System.Drawing.Point(11, 179);
            this.checkBoxAnThuocLag.Name = "checkBoxAnThuocLag";
            this.checkBoxAnThuocLag.Size = new System.Drawing.Size(141, 17);
            this.checkBoxAnThuocLag.TabIndex = 165;
            this.checkBoxAnThuocLag.Text = "Ăn bỏ các loại thuốc lag";
            this.checkBoxAnThuocLag.UseVisualStyleBackColor = false;
            this.checkBoxAnThuocLag.CheckedChanged += new System.EventHandler(this.checkBoxAnThuocLag_CheckedChanged);
            // 
            // checkBoxAccChinhHauDoanh
            // 
            this.checkBoxAccChinhHauDoanh.AutoSize = true;
            this.checkBoxAccChinhHauDoanh.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAccChinhHauDoanh.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAccChinhHauDoanh.Location = new System.Drawing.Point(11, 65);
            this.checkBoxAccChinhHauDoanh.Name = "checkBoxAccChinhHauDoanh";
            this.checkBoxAccChinhHauDoanh.Size = new System.Drawing.Size(149, 17);
            this.checkBoxAccChinhHauDoanh.TabIndex = 148;
            this.checkBoxAccChinhHauDoanh.Text = "Ac chính tự chạy ra ngoài";
            this.checkBoxAccChinhHauDoanh.UseVisualStyleBackColor = false;
            this.checkBoxAccChinhHauDoanh.CheckedChanged += new System.EventHandler(this.checkBoxAccChinhHauDoanh_CheckedChanged);
            // 
            // buttonThuocTDD
            // 
            this.buttonThuocTDD.ForeColor = System.Drawing.Color.Black;
            this.buttonThuocTDD.Location = new System.Drawing.Point(183, 202);
            this.buttonThuocTDD.Name = "buttonThuocTDD";
            this.buttonThuocTDD.Size = new System.Drawing.Size(60, 21);
            this.buttonThuocTDD.TabIndex = 167;
            this.buttonThuocTDD.Text = "Thuốc";
            this.buttonThuocTDD.UseVisualStyleBackColor = true;
            this.buttonThuocTDD.Click += new System.EventHandler(this.buttonThuocTDD_Click);
            // 
            // buttonThuocLag
            // 
            this.buttonThuocLag.ForeColor = System.Drawing.Color.Black;
            this.buttonThuocLag.Location = new System.Drawing.Point(183, 178);
            this.buttonThuocLag.Name = "buttonThuocLag";
            this.buttonThuocLag.Size = new System.Drawing.Size(60, 21);
            this.buttonThuocLag.TabIndex = 168;
            this.buttonThuocLag.Text = "Thuốc";
            this.buttonThuocLag.UseVisualStyleBackColor = true;
            this.buttonThuocLag.Click += new System.EventHandler(this.buttonThuocLag_Click);
            // 
            // tabPageCTC
            // 
            this.tabPageCTC.Controls.Add(this.label26);
            this.tabPageCTC.Controls.Add(this.comboBoxCTC);
            this.tabPageCTC.Controls.Add(this.tabControlThatThanh);
            this.tabPageCTC.Controls.Add(this.checkBoxAccChinhTudieukhienCTC);
            this.tabPageCTC.Location = new System.Drawing.Point(4, 22);
            this.tabPageCTC.Name = "tabPageCTC";
            this.tabPageCTC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCTC.Size = new System.Drawing.Size(251, 303);
            this.tabPageCTC.TabIndex = 4;
            this.tabPageCTC.Text = "CTC";
            this.tabPageCTC.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 238;
            this.label26.Text = "Hãy chọn ";
            // 
            // comboBoxCTC
            // 
            this.comboBoxCTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCTC.ForeColor = System.Drawing.Color.MediumBlue;
            this.comboBoxCTC.FormattingEnabled = true;
            this.comboBoxCTC.Location = new System.Drawing.Point(66, 31);
            this.comboBoxCTC.Name = "comboBoxCTC";
            this.comboBoxCTC.Size = new System.Drawing.Size(133, 21);
            this.comboBoxCTC.TabIndex = 237;
            this.comboBoxCTC.SelectedIndexChanged += new System.EventHandler(this.comboBoxCTC_SelectedIndexChanged);
            // 
            // tabControlThatThanh
            // 
            this.tabControlThatThanh.Controls.Add(this.tabPageThatthanh);
            this.tabControlThatThanh.Controls.Add(this.tabPageTamtru);
            this.tabControlThatThanh.Controls.Add(this.tabPageTamMondai);
            this.tabControlThatThanh.Location = new System.Drawing.Point(0, 60);
            this.tabControlThatThanh.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlThatThanh.Name = "tabControlThatThanh";
            this.tabControlThatThanh.SelectedIndex = 0;
            this.tabControlThatThanh.Size = new System.Drawing.Size(254, 244);
            this.tabControlThatThanh.TabIndex = 236;
            // 
            // tabPageThatthanh
            // 
            this.tabPageThatthanh.Controls.Add(this.checkBoxVaomapAchinh);
            this.tabPageThatthanh.Controls.Add(this.label15);
            this.tabPageThatthanh.Controls.Add(this.comboBoxChienTruongMapPhu);
            this.tabPageThatthanh.Controls.Add(this.buttonLayVitriXaphuCTQ);
            this.tabPageThatthanh.Controls.Add(this.buttonPhimHDCTC);
            this.tabPageThatthanh.Controls.Add(this.checkBoxOluonMapphu);
            this.tabPageThatthanh.Controls.Add(this.label17);
            this.tabPageThatthanh.Controls.Add(this.label34);
            this.tabPageThatthanh.Controls.Add(this.labelChuadaydu);
            this.tabPageThatthanh.Controls.Add(this.numericUpDownCTC);
            this.tabPageThatthanh.Controls.Add(this.comboBoxChienTruong);
            this.tabPageThatthanh.Controls.Add(this.checkBoxMapPhu);
            this.tabPageThatthanh.Controls.Add(this.checkBoxTHPCTC);
            this.tabPageThatthanh.Location = new System.Drawing.Point(4, 22);
            this.tabPageThatthanh.Name = "tabPageThatthanh";
            this.tabPageThatthanh.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThatthanh.Size = new System.Drawing.Size(246, 218);
            this.tabPageThatthanh.TabIndex = 0;
            this.tabPageThatthanh.Text = "Thất thành";
            this.tabPageThatthanh.UseVisualStyleBackColor = true;
            // 
            // checkBoxVaomapAchinh
            // 
            this.checkBoxVaomapAchinh.AutoSize = true;
            this.checkBoxVaomapAchinh.ForeColor = System.Drawing.Color.Black;
            this.checkBoxVaomapAchinh.Location = new System.Drawing.Point(1, 52);
            this.checkBoxVaomapAchinh.Name = "checkBoxVaomapAchinh";
            this.checkBoxVaomapAchinh.Size = new System.Drawing.Size(235, 17);
            this.checkBoxVaomapAchinh.TabIndex = 240;
            this.checkBoxVaomapAchinh.Text = "Ac phụ tự vào map nơi ac chính đang đứng";
            this.checkBoxVaomapAchinh.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxVaomapAchinh.UseVisualStyleBackColor = true;
            this.checkBoxVaomapAchinh.CheckedChanged += new System.EventHandler(this.checkBoxVaomapAchinh_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(11, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 235;
            this.label15.Text = "Bản đồ CTC phụ";
            // 
            // comboBoxChienTruongMapPhu
            // 
            this.comboBoxChienTruongMapPhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChienTruongMapPhu.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChienTruongMapPhu.FormattingEnabled = true;
            this.comboBoxChienTruongMapPhu.Location = new System.Drawing.Point(113, 26);
            this.comboBoxChienTruongMapPhu.Name = "comboBoxChienTruongMapPhu";
            this.comboBoxChienTruongMapPhu.Size = new System.Drawing.Size(129, 21);
            this.comboBoxChienTruongMapPhu.TabIndex = 227;
            this.comboBoxChienTruongMapPhu.SelectedIndexChanged += new System.EventHandler(this.comboBoxChienTruongMapPhu_SelectedIndexChanged);
            // 
            // buttonLayVitriXaphuCTQ
            // 
            this.buttonLayVitriXaphuCTQ.ForeColor = System.Drawing.Color.Black;
            this.buttonLayVitriXaphuCTQ.Location = new System.Drawing.Point(113, 102);
            this.buttonLayVitriXaphuCTQ.Name = "buttonLayVitriXaphuCTQ";
            this.buttonLayVitriXaphuCTQ.Size = new System.Drawing.Size(60, 36);
            this.buttonLayVitriXaphuCTQ.TabIndex = 233;
            this.buttonLayVitriXaphuCTQ.Text = "Lấy vị trí xa phu CTC";
            this.buttonLayVitriXaphuCTQ.UseVisualStyleBackColor = true;
            this.buttonLayVitriXaphuCTQ.Click += new System.EventHandler(this.buttonLayVitriXaphuCTQ_Click);
            // 
            // buttonPhimHDCTC
            // 
            this.buttonPhimHDCTC.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonPhimHDCTC.Location = new System.Drawing.Point(175, 102);
            this.buttonPhimHDCTC.Name = "buttonPhimHDCTC";
            this.buttonPhimHDCTC.Size = new System.Drawing.Size(70, 36);
            this.buttonPhimHDCTC.TabIndex = 232;
            this.buttonPhimHDCTC.Text = "Phim hướng dẫn";
            this.buttonPhimHDCTC.UseVisualStyleBackColor = true;
            this.buttonPhimHDCTC.Click += new System.EventHandler(this.buttonPhimHDCTC_Click);
            // 
            // checkBoxOluonMapphu
            // 
            this.checkBoxOluonMapphu.AutoSize = true;
            this.checkBoxOluonMapphu.ForeColor = System.Drawing.Color.Black;
            this.checkBoxOluonMapphu.Location = new System.Drawing.Point(3, 192);
            this.checkBoxOluonMapphu.Name = "checkBoxOluonMapphu";
            this.checkBoxOluonMapphu.Size = new System.Drawing.Size(244, 17);
            this.checkBoxOluonMapphu.TabIndex = 165;
            this.checkBoxOluonMapphu.Text = "Không trở về map chính khi đã sang map phụ";
            this.checkBoxOluonMapphu.UseVisualStyleBackColor = true;
            this.checkBoxOluonMapphu.CheckedChanged += new System.EventHandler(this.checkBoxOluonMapphu_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(1, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 183;
            this.label17.Text = "Bản đồ CTC chính";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.DarkRed;
            this.label34.Location = new System.Drawing.Point(1, 108);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(97, 13);
            this.label34.TabIndex = 234;
            this.label34.Text = "Đi xa phu vào CTC";
            // 
            // labelChuadaydu
            // 
            this.labelChuadaydu.AutoSize = true;
            this.labelChuadaydu.ForeColor = System.Drawing.Color.Black;
            this.labelChuadaydu.Location = new System.Drawing.Point(4, 125);
            this.labelChuadaydu.Name = "labelChuadaydu";
            this.labelChuadaydu.Size = new System.Drawing.Size(16, 13);
            this.labelChuadaydu.TabIndex = 234;
            this.labelChuadaydu.Text = "...";
            // 
            // numericUpDownCTC
            // 
            this.numericUpDownCTC.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownCTC.Location = new System.Drawing.Point(200, 76);
            this.numericUpDownCTC.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownCTC.Name = "numericUpDownCTC";
            this.numericUpDownCTC.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownCTC.TabIndex = 185;
            this.numericUpDownCTC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCTC.ValueChanged += new System.EventHandler(this.numericUpDownCTC_ValueChanged);
            // 
            // comboBoxChienTruong
            // 
            this.comboBoxChienTruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChienTruong.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChienTruong.FormattingEnabled = true;
            this.comboBoxChienTruong.Location = new System.Drawing.Point(113, 1);
            this.comboBoxChienTruong.Name = "comboBoxChienTruong";
            this.comboBoxChienTruong.Size = new System.Drawing.Size(129, 21);
            this.comboBoxChienTruong.TabIndex = 182;
            this.comboBoxChienTruong.SelectedIndexChanged += new System.EventHandler(this.comboBoxChienTruong_SelectedIndexChanged);
            // 
            // checkBoxMapPhu
            // 
            this.checkBoxMapPhu.AutoSize = true;
            this.checkBoxMapPhu.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMapPhu.Location = new System.Drawing.Point(3, 169);
            this.checkBoxMapPhu.Name = "checkBoxMapPhu";
            this.checkBoxMapPhu.Size = new System.Drawing.Size(181, 17);
            this.checkBoxMapPhu.TabIndex = 231;
            this.checkBoxMapPhu.Text = "Vào map phụ khi map chính đầy";
            this.checkBoxMapPhu.UseVisualStyleBackColor = true;
            this.checkBoxMapPhu.CheckedChanged += new System.EventHandler(this.checkBoxMapPhu_CheckedChanged);
            // 
            // checkBoxTHPCTC
            // 
            this.checkBoxTHPCTC.AutoSize = true;
            this.checkBoxTHPCTC.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTHPCTC.Location = new System.Drawing.Point(1, 77);
            this.checkBoxTHPCTC.Name = "checkBoxTHPCTC";
            this.checkBoxTHPCTC.Size = new System.Drawing.Size(198, 17);
            this.checkBoxTHPCTC.TabIndex = 230;
            this.checkBoxTHPCTC.Text = "Dùng THP để vào, click menu dòng";
            this.checkBoxTHPCTC.UseVisualStyleBackColor = true;
            this.checkBoxTHPCTC.CheckedChanged += new System.EventHandler(this.checkBoxTHPCTC_CheckedChanged);
            // 
            // tabPageTamtru
            // 
            this.tabPageTamtru.Controls.Add(this.groupBox8);
            this.tabPageTamtru.Controls.Add(this.checkBoxPheThu);
            this.tabPageTamtru.Controls.Add(this.buttonPhimHdTamtru);
            this.tabPageTamtru.Location = new System.Drawing.Point(4, 22);
            this.tabPageTamtru.Name = "tabPageTamtru";
            this.tabPageTamtru.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTamtru.Size = new System.Drawing.Size(246, 218);
            this.tabPageTamtru.TabIndex = 1;
            this.tabPageTamtru.Text = "Tam trụ";
            this.tabPageTamtru.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonLayvitriCongTamtru);
            this.groupBox8.Controls.Add(this.textBoxCongTamtru);
            this.groupBox8.Controls.Add(this.label30);
            this.groupBox8.Controls.Add(this.textBoxToadoHieuthuocTamtru);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.comboBoxTenHieuThuocTamtru);
            this.groupBox8.Location = new System.Drawing.Point(1, 29);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(245, 134);
            this.groupBox8.TabIndex = 234;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thiết lập";
            // 
            // buttonLayvitriCongTamtru
            // 
            this.buttonLayvitriCongTamtru.Location = new System.Drawing.Point(117, 97);
            this.buttonLayvitriCongTamtru.Name = "buttonLayvitriCongTamtru";
            this.buttonLayvitriCongTamtru.Size = new System.Drawing.Size(65, 21);
            this.buttonLayvitriCongTamtru.TabIndex = 231;
            this.buttonLayvitriCongTamtru.Text = "Lấy vị trí";
            this.buttonLayvitriCongTamtru.UseVisualStyleBackColor = true;
            this.buttonLayvitriCongTamtru.Click += new System.EventHandler(this.buttonLayvitriCongTamtru_Click);
            // 
            // textBoxCongTamtru
            // 
            this.textBoxCongTamtru.ForeColor = System.Drawing.Color.Black;
            this.textBoxCongTamtru.Location = new System.Drawing.Point(13, 98);
            this.textBoxCongTamtru.Name = "textBoxCongTamtru";
            this.textBoxCongTamtru.ReadOnly = true;
            this.textBoxCongTamtru.Size = new System.Drawing.Size(97, 20);
            this.textBoxCongTamtru.TabIndex = 230;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(7, 78);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(175, 13);
            this.label30.TabIndex = 228;
            this.label30.Text = "Vị trí Cổng chạy ra ngoài chiến đấu";
            // 
            // textBoxToadoHieuthuocTamtru
            // 
            this.textBoxToadoHieuthuocTamtru.ForeColor = System.Drawing.Color.Black;
            this.textBoxToadoHieuthuocTamtru.Location = new System.Drawing.Point(13, 48);
            this.textBoxToadoHieuthuocTamtru.Name = "textBoxToadoHieuthuocTamtru";
            this.textBoxToadoHieuthuocTamtru.ReadOnly = true;
            this.textBoxToadoHieuthuocTamtru.Size = new System.Drawing.Size(97, 20);
            this.textBoxToadoHieuthuocTamtru.TabIndex = 227;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(7, 31);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(217, 13);
            this.label28.TabIndex = 225;
            this.label28.Text = "Tên Hiệu thuốc (đem ac đến gần rồi lấy tên)";
            // 
            // comboBoxTenHieuThuocTamtru
            // 
            this.comboBoxTenHieuThuocTamtru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenHieuThuocTamtru.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTenHieuThuocTamtru.FormattingEnabled = true;
            this.comboBoxTenHieuThuocTamtru.Location = new System.Drawing.Point(116, 47);
            this.comboBoxTenHieuThuocTamtru.Name = "comboBoxTenHieuThuocTamtru";
            this.comboBoxTenHieuThuocTamtru.Size = new System.Drawing.Size(118, 21);
            this.comboBoxTenHieuThuocTamtru.TabIndex = 223;
            this.comboBoxTenHieuThuocTamtru.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenHieuThuocTamtru_SelectedIndexChanged);
            this.comboBoxTenHieuThuocTamtru.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxTenHieuThuocTamtru_MouseDown);
            // 
            // checkBoxPheThu
            // 
            this.checkBoxPheThu.AutoSize = true;
            this.checkBoxPheThu.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxPheThu.Location = new System.Drawing.Point(1, 4);
            this.checkBoxPheThu.Name = "checkBoxPheThu";
            this.checkBoxPheThu.Size = new System.Drawing.Size(100, 17);
            this.checkBoxPheThu.TabIndex = 235;
            this.checkBoxPheThu.Text = "Đang ở phe thủ";
            this.checkBoxPheThu.UseVisualStyleBackColor = true;
            this.checkBoxPheThu.CheckedChanged += new System.EventHandler(this.checkBoxPheThu_CheckedChanged);
            // 
            // buttonPhimHdTamtru
            // 
            this.buttonPhimHdTamtru.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonPhimHdTamtru.Location = new System.Drawing.Point(11, 183);
            this.buttonPhimHdTamtru.Name = "buttonPhimHdTamtru";
            this.buttonPhimHdTamtru.Size = new System.Drawing.Size(97, 27);
            this.buttonPhimHdTamtru.TabIndex = 233;
            this.buttonPhimHdTamtru.Text = "Phim Hướng dẫn";
            this.buttonPhimHdTamtru.UseVisualStyleBackColor = true;
            this.buttonPhimHdTamtru.Click += new System.EventHandler(this.buttonPhimHdTamtru_Click);
            // 
            // tabPageTamMondai
            // 
            this.tabPageTamMondai.Controls.Add(this.buttonTamMonDaiHD);
            this.tabPageTamMondai.Controls.Add(this.richTextBox2);
            this.tabPageTamMondai.Controls.Add(this.buttonMapTamMondaiMacdinh);
            this.tabPageTamMondai.Controls.Add(this.label27);
            this.tabPageTamMondai.Controls.Add(this.buttonLayMapTamMondai);
            this.tabPageTamMondai.Controls.Add(this.textBoxTamMonDaiMapId);
            this.tabPageTamMondai.Location = new System.Drawing.Point(4, 22);
            this.tabPageTamMondai.Name = "tabPageTamMondai";
            this.tabPageTamMondai.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTamMondai.Size = new System.Drawing.Size(246, 218);
            this.tabPageTamMondai.TabIndex = 2;
            this.tabPageTamMondai.Text = "Tam môn đài";
            this.tabPageTamMondai.UseVisualStyleBackColor = true;
            // 
            // buttonTamMonDaiHD
            // 
            this.buttonTamMonDaiHD.Location = new System.Drawing.Point(109, 192);
            this.buttonTamMonDaiHD.Name = "buttonTamMonDaiHD";
            this.buttonTamMonDaiHD.Size = new System.Drawing.Size(103, 26);
            this.buttonTamMonDaiHD.TabIndex = 6;
            this.buttonTamMonDaiHD.Text = "Phim Hướng dẫn";
            this.buttonTamMonDaiHD.UseVisualStyleBackColor = true;
            this.buttonTamMonDaiHD.Click += new System.EventHandler(this.buttonTamMonDaiHD_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.ForeColor = System.Drawing.Color.Black;
            this.richTextBox2.Location = new System.Drawing.Point(1, 1);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(246, 125);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // buttonMapTamMondaiMacdinh
            // 
            this.buttonMapTamMondaiMacdinh.Location = new System.Drawing.Point(109, 161);
            this.buttonMapTamMondaiMacdinh.Name = "buttonMapTamMondaiMacdinh";
            this.buttonMapTamMondaiMacdinh.Size = new System.Drawing.Size(133, 26);
            this.buttonMapTamMondaiMacdinh.TabIndex = 4;
            this.buttonMapTamMondaiMacdinh.Text = "Lấy mapID mặc định";
            this.buttonMapTamMondaiMacdinh.UseVisualStyleBackColor = true;
            this.buttonMapTamMondaiMacdinh.Click += new System.EventHandler(this.buttonMapTamMondaiMacdinh_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.DarkRed;
            this.label27.Location = new System.Drawing.Point(4, 132);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 13);
            this.label27.TabIndex = 3;
            this.label27.Text = "MapID hoạt động";
            // 
            // buttonLayMapTamMondai
            // 
            this.buttonLayMapTamMondai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonLayMapTamMondai.Location = new System.Drawing.Point(109, 132);
            this.buttonLayMapTamMondai.Name = "buttonLayMapTamMondai";
            this.buttonLayMapTamMondai.Size = new System.Drawing.Size(133, 26);
            this.buttonLayMapTamMondai.TabIndex = 2;
            this.buttonLayMapTamMondai.Text = "Lấy mapID đang đứng";
            this.buttonLayMapTamMondai.UseVisualStyleBackColor = true;
            this.buttonLayMapTamMondai.Click += new System.EventHandler(this.buttonLayMapTamMondai_Click);
            // 
            // textBoxTamMonDaiMapId
            // 
            this.textBoxTamMonDaiMapId.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTamMonDaiMapId.Location = new System.Drawing.Point(14, 150);
            this.textBoxTamMonDaiMapId.Name = "textBoxTamMonDaiMapId";
            this.textBoxTamMonDaiMapId.ReadOnly = true;
            this.textBoxTamMonDaiMapId.Size = new System.Drawing.Size(35, 20);
            this.textBoxTamMonDaiMapId.TabIndex = 1;
            this.textBoxTamMonDaiMapId.Text = "221";
            this.textBoxTamMonDaiMapId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxAccChinhTudieukhienCTC
            // 
            this.checkBoxAccChinhTudieukhienCTC.AutoSize = true;
            this.checkBoxAccChinhTudieukhienCTC.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxAccChinhTudieukhienCTC.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAccChinhTudieukhienCTC.Name = "checkBoxAccChinhTudieukhienCTC";
            this.checkBoxAccChinhTudieukhienCTC.Size = new System.Drawing.Size(233, 17);
            this.checkBoxAccChinhTudieukhienCTC.TabIndex = 232;
            this.checkBoxAccChinhTudieukhienCTC.Text = "Ac chính người dùng tự điều khiển hậu cần";
            this.checkBoxAccChinhTudieukhienCTC.UseVisualStyleBackColor = true;
            this.checkBoxAccChinhTudieukhienCTC.CheckedChanged += new System.EventHandler(this.checkBoxAccChinhTudieukhienCTC_CheckedChanged);
            // 
            // tabPageTrain
            // 
            this.tabPageTrain.Controls.Add(this.tabControl6);
            this.tabPageTrain.Controls.Add(this.buttonApdungAllTrain);
            this.tabPageTrain.Controls.Add(this.buttonHuongDan);
            this.tabPageTrain.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrain.Name = "tabPageTrain";
            this.tabPageTrain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrain.Size = new System.Drawing.Size(251, 303);
            this.tabPageTrain.TabIndex = 5;
            this.tabPageTrain.Text = "Train";
            this.tabPageTrain.UseVisualStyleBackColor = true;
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage16);
            this.tabControl6.Controls.Add(this.tabPage18);
            this.tabControl6.Location = new System.Drawing.Point(0, 0);
            this.tabControl6.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(254, 275);
            this.tabControl6.TabIndex = 0;
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.checkBoxQuayquai);
            this.tabPage16.Controls.Add(this.textBoxSLThoat);
            this.tabPage16.Controls.Add(this.checkBoxToadoVong);
            this.tabPage16.Controls.Add(this.linkLabelPhimChaynhim);
            this.tabPage16.Controls.Add(this.checkBoxDanhQuaiTrenduongdi);
            this.tabPage16.Controls.Add(this.textBoxMapName);
            this.tabPage16.Controls.Add(this.checkBoxTrain);
            this.tabPage16.Controls.Add(this.checkBoxTDPHettien);
            this.tabPage16.Controls.Add(this.checkBoxDanhquaiTrain);
            this.tabPage16.Controls.Add(this.checkBoxTucheHT);
            this.tabPage16.Controls.Add(this.checkBoxTranhBossVang);
            this.tabPage16.Controls.Add(this.listViewTrain);
            this.tabPage16.Controls.Add(this.comboBoxOtrong);
            this.tabPage16.Controls.Add(this.checkBoxOtrong);
            this.tabPage16.Controls.Add(this.buttonDoctep);
            this.tabPage16.Controls.Add(this.buttonLayToadoTrain);
            this.tabPage16.Controls.Add(this.buttonXoaToadoTrain);
            this.tabPage16.Controls.Add(this.checkBoxTDPSaimap);
            this.tabPage16.Controls.Add(this.buttonLuutep);
            this.tabPage16.Controls.Add(this.checkBoxLuomrac);
            this.tabPage16.Controls.Add(this.checkBoxSLThoat);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(246, 249);
            this.tabPage16.TabIndex = 0;
            this.tabPage16.Text = "Thiết lập 1";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuayquai
            // 
            this.checkBoxQuayquai.AutoSize = true;
            this.checkBoxQuayquai.Enabled = false;
            this.checkBoxQuayquai.ForeColor = System.Drawing.Color.Black;
            this.checkBoxQuayquai.Location = new System.Drawing.Point(3, 75);
            this.checkBoxQuayquai.Name = "checkBoxQuayquai";
            this.checkBoxQuayquai.Size = new System.Drawing.Size(74, 17);
            this.checkBoxQuayquai.TabIndex = 268;
            this.checkBoxQuayquai.Text = "Quây quái";
            this.checkBoxQuayquai.UseVisualStyleBackColor = true;
            this.checkBoxQuayquai.Visible = false;
            this.checkBoxQuayquai.CheckedChanged += new System.EventHandler(this.checkBoxQuayquai_CheckedChanged);
            // 
            // textBoxSLThoat
            // 
            this.textBoxSLThoat.Location = new System.Drawing.Point(79, 98);
            this.textBoxSLThoat.Name = "textBoxSLThoat";
            this.textBoxSLThoat.Size = new System.Drawing.Size(40, 20);
            this.textBoxSLThoat.TabIndex = 247;
            this.textBoxSLThoat.TextChanged += new System.EventHandler(this.textBoxSLThoat_TextChanged);
            // 
            // checkBoxToadoVong
            // 
            this.checkBoxToadoVong.AutoSize = true;
            this.checkBoxToadoVong.ForeColor = System.Drawing.Color.Black;
            this.checkBoxToadoVong.Location = new System.Drawing.Point(126, 50);
            this.checkBoxToadoVong.Name = "checkBoxToadoVong";
            this.checkBoxToadoVong.Size = new System.Drawing.Size(109, 17);
            this.checkBoxToadoVong.TabIndex = 265;
            this.checkBoxToadoVong.Text = "Tọa độ vòng tròn";
            this.checkBoxToadoVong.UseVisualStyleBackColor = true;
            this.checkBoxToadoVong.CheckedChanged += new System.EventHandler(this.checkBoxToadoVong_CheckedChanged);
            // 
            // linkLabelPhimChaynhim
            // 
            this.linkLabelPhimChaynhim.AutoSize = true;
            this.linkLabelPhimChaynhim.Location = new System.Drawing.Point(23, 233);
            this.linkLabelPhimChaynhim.Name = "linkLabelPhimChaynhim";
            this.linkLabelPhimChaynhim.Size = new System.Drawing.Size(82, 13);
            this.linkLabelPhimChaynhim.TabIndex = 266;
            this.linkLabelPhimChaynhim.TabStop = true;
            this.linkLabelPhimChaynhim.Text = "phim chạy nhím";
            this.linkLabelPhimChaynhim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPhimChaynhim_LinkClicked);
            // 
            // checkBoxDanhQuaiTrenduongdi
            // 
            this.checkBoxDanhQuaiTrenduongdi.AutoSize = true;
            this.checkBoxDanhQuaiTrenduongdi.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDanhQuaiTrenduongdi.Location = new System.Drawing.Point(3, 53);
            this.checkBoxDanhQuaiTrenduongdi.Name = "checkBoxDanhQuaiTrenduongdi";
            this.checkBoxDanhQuaiTrenduongdi.Size = new System.Drawing.Size(119, 17);
            this.checkBoxDanhQuaiTrenduongdi.TabIndex = 267;
            this.checkBoxDanhQuaiTrenduongdi.Text = "Đánh trên đường đi";
            this.checkBoxDanhQuaiTrenduongdi.UseVisualStyleBackColor = true;
            this.checkBoxDanhQuaiTrenduongdi.CheckedChanged += new System.EventHandler(this.checkBoxDanhQuaiTrenduongdi_CheckedChanged);
            // 
            // textBoxMapName
            // 
            this.textBoxMapName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMapName.ForeColor = System.Drawing.Color.Black;
            this.textBoxMapName.Location = new System.Drawing.Point(58, 5);
            this.textBoxMapName.Name = "textBoxMapName";
            this.textBoxMapName.ReadOnly = true;
            this.textBoxMapName.Size = new System.Drawing.Size(62, 20);
            this.textBoxMapName.TabIndex = 173;
            // 
            // checkBoxTrain
            // 
            this.checkBoxTrain.AutoSize = true;
            this.checkBoxTrain.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTrain.Location = new System.Drawing.Point(3, 8);
            this.checkBoxTrain.Name = "checkBoxTrain";
            this.checkBoxTrain.Size = new System.Drawing.Size(50, 17);
            this.checkBoxTrain.TabIndex = 223;
            this.checkBoxTrain.Text = "Train";
            this.checkBoxTrain.UseVisualStyleBackColor = true;
            this.checkBoxTrain.CheckedChanged += new System.EventHandler(this.checkBoxTrain_CheckedChanged);
            // 
            // checkBoxTDPHettien
            // 
            this.checkBoxTDPHettien.AutoSize = true;
            this.checkBoxTDPHettien.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTDPHettien.Location = new System.Drawing.Point(3, 155);
            this.checkBoxTDPHettien.Name = "checkBoxTDPHettien";
            this.checkBoxTDPHettien.Size = new System.Drawing.Size(103, 17);
            this.checkBoxTDPHettien.TabIndex = 264;
            this.checkBoxTDPHettien.Text = "TĐP khi hết tiền";
            this.checkBoxTDPHettien.UseVisualStyleBackColor = true;
            this.checkBoxTDPHettien.CheckedChanged += new System.EventHandler(this.checkBoxTDPHettien_CheckedChanged);
            // 
            // checkBoxDanhquaiTrain
            // 
            this.checkBoxDanhquaiTrain.AutoSize = true;
            this.checkBoxDanhquaiTrain.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDanhquaiTrain.Location = new System.Drawing.Point(3, 31);
            this.checkBoxDanhquaiTrain.Name = "checkBoxDanhquaiTrain";
            this.checkBoxDanhquaiTrain.Size = new System.Drawing.Size(104, 17);
            this.checkBoxDanhquaiTrain.TabIndex = 263;
            this.checkBoxDanhquaiTrain.Text = "Đánh quái (train)";
            this.checkBoxDanhquaiTrain.UseVisualStyleBackColor = true;
            this.checkBoxDanhquaiTrain.CheckedChanged += new System.EventHandler(this.checkBoxDanhquaiTrain_CheckedChanged);
            // 
            // checkBoxTucheHT
            // 
            this.checkBoxTucheHT.AutoSize = true;
            this.checkBoxTucheHT.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBoxTucheHT.Location = new System.Drawing.Point(3, 214);
            this.checkBoxTucheHT.Name = "checkBoxTucheHT";
            this.checkBoxTucheHT.Size = new System.Drawing.Size(117, 17);
            this.checkBoxTucheHT.TabIndex = 262;
            this.checkBoxTucheHT.Text = "Chế tạo Huyền tinh";
            this.checkBoxTucheHT.UseVisualStyleBackColor = true;
            this.checkBoxTucheHT.CheckedChanged += new System.EventHandler(this.checkBoxTucheHT_CheckedChanged);
            // 
            // checkBoxTranhBossVang
            // 
            this.checkBoxTranhBossVang.AutoSize = true;
            this.checkBoxTranhBossVang.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTranhBossVang.Location = new System.Drawing.Point(126, 26);
            this.checkBoxTranhBossVang.Name = "checkBoxTranhBossVang";
            this.checkBoxTranhBossVang.Size = new System.Drawing.Size(106, 17);
            this.checkBoxTranhBossVang.TabIndex = 239;
            this.checkBoxTranhBossVang.Text = "Tránh boss vàng";
            this.checkBoxTranhBossVang.UseVisualStyleBackColor = true;
            this.checkBoxTranhBossVang.CheckedChanged += new System.EventHandler(this.checkBoxTranhBossVang_CheckedChanged);
            // 
            // listViewTrain
            // 
            this.listViewTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTrain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_3,
            this.columnHeader_4});
            this.listViewTrain.FullRowSelect = true;
            this.listViewTrain.GridLines = true;
            this.listViewTrain.HideSelection = false;
            this.listViewTrain.Location = new System.Drawing.Point(126, 97);
            this.listViewTrain.MultiSelect = false;
            this.listViewTrain.Name = "listViewTrain";
            this.listViewTrain.Size = new System.Drawing.Size(112, 125);
            this.listViewTrain.TabIndex = 220;
            this.listViewTrain.UseCompatibleStateImageBehavior = false;
            this.listViewTrain.View = System.Windows.Forms.View.Details;
            this.listViewTrain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewTrain_MouseDown);
            // 
            // columnHeader_3
            // 
            this.columnHeader_3.Text = "N";
            this.columnHeader_3.Width = 20;
            // 
            // columnHeader_4
            // 
            this.columnHeader_4.Text = "Tọa độ";
            this.columnHeader_4.Width = 70;
            // 
            // comboBoxOtrong
            // 
            this.comboBoxOtrong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOtrong.FormattingEnabled = true;
            this.comboBoxOtrong.Location = new System.Drawing.Point(79, 120);
            this.comboBoxOtrong.Name = "comboBoxOtrong";
            this.comboBoxOtrong.Size = new System.Drawing.Size(40, 21);
            this.comboBoxOtrong.TabIndex = 250;
            this.comboBoxOtrong.SelectedIndexChanged += new System.EventHandler(this.comboBoxOtrong_SelectedIndexChanged);
            // 
            // checkBoxOtrong
            // 
            this.checkBoxOtrong.AutoSize = true;
            this.checkBoxOtrong.ForeColor = System.Drawing.Color.Black;
            this.checkBoxOtrong.Location = new System.Drawing.Point(3, 124);
            this.checkBoxOtrong.Name = "checkBoxOtrong";
            this.checkBoxOtrong.Size = new System.Drawing.Size(74, 17);
            this.checkBoxOtrong.TabIndex = 249;
            this.checkBoxOtrong.Text = "TĐP khi <";
            this.checkBoxOtrong.UseVisualStyleBackColor = true;
            this.checkBoxOtrong.CheckedChanged += new System.EventHandler(this.checkBoxOtrong_CheckedChanged);
            // 
            // buttonDoctep
            // 
            this.buttonDoctep.Location = new System.Drawing.Point(126, 73);
            this.buttonDoctep.Name = "buttonDoctep";
            this.buttonDoctep.Size = new System.Drawing.Size(35, 21);
            this.buttonDoctep.TabIndex = 226;
            this.buttonDoctep.UseVisualStyleBackColor = true;
            this.buttonDoctep.Click += new System.EventHandler(this.buttonDoctep_Click);
            // 
            // buttonLayToadoTrain
            // 
            this.buttonLayToadoTrain.ForeColor = System.Drawing.Color.Black;
            this.buttonLayToadoTrain.Location = new System.Drawing.Point(125, 225);
            this.buttonLayToadoTrain.Name = "buttonLayToadoTrain";
            this.buttonLayToadoTrain.Size = new System.Drawing.Size(70, 23);
            this.buttonLayToadoTrain.TabIndex = 224;
            this.buttonLayToadoTrain.Text = "Lấy tọa độ";
            this.buttonLayToadoTrain.UseVisualStyleBackColor = true;
            this.buttonLayToadoTrain.Click += new System.EventHandler(this.buttonLayToadoTrain_Click);
            // 
            // buttonXoaToadoTrain
            // 
            this.buttonXoaToadoTrain.Location = new System.Drawing.Point(199, 225);
            this.buttonXoaToadoTrain.Name = "buttonXoaToadoTrain";
            this.buttonXoaToadoTrain.Size = new System.Drawing.Size(39, 23);
            this.buttonXoaToadoTrain.TabIndex = 225;
            this.buttonXoaToadoTrain.Text = "Xóa";
            this.buttonXoaToadoTrain.UseVisualStyleBackColor = true;
            this.buttonXoaToadoTrain.Click += new System.EventHandler(this.buttonXoaToadoTrain_Click);
            // 
            // checkBoxTDPSaimap
            // 
            this.checkBoxTDPSaimap.AutoSize = true;
            this.checkBoxTDPSaimap.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTDPSaimap.Location = new System.Drawing.Point(3, 178);
            this.checkBoxTDPSaimap.Name = "checkBoxTDPSaimap";
            this.checkBoxTDPSaimap.Size = new System.Drawing.Size(104, 17);
            this.checkBoxTDPSaimap.TabIndex = 240;
            this.checkBoxTDPSaimap.Text = "TĐP khi sai map";
            this.checkBoxTDPSaimap.UseVisualStyleBackColor = true;
            this.checkBoxTDPSaimap.CheckedChanged += new System.EventHandler(this.checkBoxTDPSaimap_CheckedChanged);
            // 
            // buttonLuutep
            // 
            this.buttonLuutep.Location = new System.Drawing.Point(164, 73);
            this.buttonLuutep.Name = "buttonLuutep";
            this.buttonLuutep.Size = new System.Drawing.Size(35, 21);
            this.buttonLuutep.TabIndex = 227;
            this.buttonLuutep.UseVisualStyleBackColor = true;
            this.buttonLuutep.Click += new System.EventHandler(this.buttonLuutep_Click);
            // 
            // checkBoxLuomrac
            // 
            this.checkBoxLuomrac.AutoSize = true;
            this.checkBoxLuomrac.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBoxLuomrac.Location = new System.Drawing.Point(126, 3);
            this.checkBoxLuomrac.Name = "checkBoxLuomrac";
            this.checkBoxLuomrac.Size = new System.Drawing.Size(113, 17);
            this.checkBoxLuomrac.TabIndex = 245;
            this.checkBoxLuomrac.Text = "Lượm rác phi shop";
            this.checkBoxLuomrac.UseVisualStyleBackColor = true;
            this.checkBoxLuomrac.CheckedChanged += new System.EventHandler(this.checkBoxLuomrac_CheckedChanged);
            // 
            // checkBoxSLThoat
            // 
            this.checkBoxSLThoat.AutoSize = true;
            this.checkBoxSLThoat.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSLThoat.Location = new System.Drawing.Point(3, 99);
            this.checkBoxSLThoat.Name = "checkBoxSLThoat";
            this.checkBoxSLThoat.Size = new System.Drawing.Size(77, 17);
            this.checkBoxSLThoat.TabIndex = 246;
            this.checkBoxSLThoat.Text = "S.lực thoát";
            this.checkBoxSLThoat.UseVisualStyleBackColor = true;
            this.checkBoxSLThoat.CheckedChanged += new System.EventHandler(this.checkBoxSLThoat_CheckedChanged);
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.comboBoxDoSatcuuSat);
            this.tabPage18.Controls.Add(this.label24);
            this.tabPage18.Controls.Add(this.textBoxPhamviNhat);
            this.tabPage18.Controls.Add(this.checkBoxNhatdoDichuyenGan);
            this.tabPage18.Controls.Add(this.textBoxTimeXepdo);
            this.tabPage18.Controls.Add(this.checkBoxXepdo);
            this.tabPage18.Controls.Add(this.label18);
            this.tabPage18.Controls.Add(this.buttonKhongcat);
            this.tabPage18.Controls.Add(this.checkBoxRuong0);
            this.tabPage18.Controls.Add(this.checkBoxRuong2);
            this.tabPage18.Controls.Add(this.checkBoxRuong3);
            this.tabPage18.Controls.Add(this.checkBoxRuong1);
            this.tabPage18.Controls.Add(this.label42);
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage18.Size = new System.Drawing.Size(246, 249);
            this.tabPage18.TabIndex = 1;
            this.tabPage18.Text = "Thiết lập 2";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // comboBoxDoSatcuuSat
            // 
            this.comboBoxDoSatcuuSat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoSatcuuSat.DropDownWidth = 85;
            this.comboBoxDoSatcuuSat.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDoSatcuuSat.FormattingEnabled = true;
            this.comboBoxDoSatcuuSat.Location = new System.Drawing.Point(50, 3);
            this.comboBoxDoSatcuuSat.Name = "comboBoxDoSatcuuSat";
            this.comboBoxDoSatcuuSat.Size = new System.Drawing.Size(91, 21);
            this.comboBoxDoSatcuuSat.TabIndex = 138;
            this.comboBoxDoSatcuuSat.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoSatcuuSat_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 243;
            this.label24.Text = "Đồ sát";
            // 
            // textBoxPhamviNhat
            // 
            this.textBoxPhamviNhat.Location = new System.Drawing.Point(102, 68);
            this.textBoxPhamviNhat.Name = "textBoxPhamviNhat";
            this.textBoxPhamviNhat.Size = new System.Drawing.Size(54, 20);
            this.textBoxPhamviNhat.TabIndex = 244;
            this.textBoxPhamviNhat.TextChanged += new System.EventHandler(this.textBoxPhamviNhat_TextChanged);
            // 
            // checkBoxNhatdoDichuyenGan
            // 
            this.checkBoxNhatdoDichuyenGan.AutoSize = true;
            this.checkBoxNhatdoDichuyenGan.ForeColor = System.Drawing.Color.Black;
            this.checkBoxNhatdoDichuyenGan.Location = new System.Drawing.Point(6, 71);
            this.checkBoxNhatdoDichuyenGan.Name = "checkBoxNhatdoDichuyenGan";
            this.checkBoxNhatdoDichuyenGan.Size = new System.Drawing.Size(88, 17);
            this.checkBoxNhatdoDichuyenGan.TabIndex = 236;
            this.checkBoxNhatdoDichuyenGan.Text = "Phạm vi nhặt";
            this.checkBoxNhatdoDichuyenGan.UseVisualStyleBackColor = true;
            this.checkBoxNhatdoDichuyenGan.CheckedChanged += new System.EventHandler(this.checkBoxNhatdoDichuyenGan_CheckedChanged);
            // 
            // textBoxTimeXepdo
            // 
            this.textBoxTimeXepdo.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimeXepdo.Location = new System.Drawing.Point(102, 93);
            this.textBoxTimeXepdo.Name = "textBoxTimeXepdo";
            this.textBoxTimeXepdo.Size = new System.Drawing.Size(54, 20);
            this.textBoxTimeXepdo.TabIndex = 261;
            this.textBoxTimeXepdo.TextChanged += new System.EventHandler(this.textBoxTimeXepdo_TextChanged);
            // 
            // checkBoxXepdo
            // 
            this.checkBoxXepdo.AutoSize = true;
            this.checkBoxXepdo.ForeColor = System.Drawing.Color.Black;
            this.checkBoxXepdo.Location = new System.Drawing.Point(6, 94);
            this.checkBoxXepdo.Name = "checkBoxXepdo";
            this.checkBoxXepdo.Size = new System.Drawing.Size(83, 17);
            this.checkBoxXepdo.TabIndex = 260;
            this.checkBoxXepdo.Text = "Xếp đồ (ms)";
            this.checkBoxXepdo.UseVisualStyleBackColor = true;
            this.checkBoxXepdo.CheckedChanged += new System.EventHandler(this.checkBoxXepdo_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DarkBlue;
            this.label18.Location = new System.Drawing.Point(3, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 259;
            this.label18.Text = "Cất đồ vào rương";
            // 
            // buttonKhongcat
            // 
            this.buttonKhongcat.ForeColor = System.Drawing.Color.Black;
            this.buttonKhongcat.Location = new System.Drawing.Point(3, 153);
            this.buttonKhongcat.Name = "buttonKhongcat";
            this.buttonKhongcat.Size = new System.Drawing.Size(87, 35);
            this.buttonKhongcat.TabIndex = 258;
            this.buttonKhongcat.Text = "Loại trừ không cất";
            this.buttonKhongcat.UseVisualStyleBackColor = true;
            this.buttonKhongcat.Click += new System.EventHandler(this.buttonKhongcat_Click);
            // 
            // checkBoxRuong0
            // 
            this.checkBoxRuong0.AutoSize = true;
            this.checkBoxRuong0.Location = new System.Drawing.Point(103, 136);
            this.checkBoxRuong0.Name = "checkBoxRuong0";
            this.checkBoxRuong0.Size = new System.Drawing.Size(40, 17);
            this.checkBoxRuong0.TabIndex = 254;
            this.checkBoxRuong0.Text = "R0";
            this.checkBoxRuong0.UseVisualStyleBackColor = true;
            this.checkBoxRuong0.CheckedChanged += new System.EventHandler(this.checkBoxRuong0_CheckedChanged);
            // 
            // checkBoxRuong2
            // 
            this.checkBoxRuong2.AutoSize = true;
            this.checkBoxRuong2.Location = new System.Drawing.Point(150, 136);
            this.checkBoxRuong2.Name = "checkBoxRuong2";
            this.checkBoxRuong2.Size = new System.Drawing.Size(40, 17);
            this.checkBoxRuong2.TabIndex = 255;
            this.checkBoxRuong2.Text = "R2";
            this.checkBoxRuong2.UseVisualStyleBackColor = true;
            this.checkBoxRuong2.CheckedChanged += new System.EventHandler(this.checkBoxRuong2_CheckedChanged);
            // 
            // checkBoxRuong3
            // 
            this.checkBoxRuong3.AutoSize = true;
            this.checkBoxRuong3.Location = new System.Drawing.Point(150, 159);
            this.checkBoxRuong3.Name = "checkBoxRuong3";
            this.checkBoxRuong3.Size = new System.Drawing.Size(40, 17);
            this.checkBoxRuong3.TabIndex = 257;
            this.checkBoxRuong3.Text = "R3";
            this.checkBoxRuong3.UseVisualStyleBackColor = true;
            this.checkBoxRuong3.CheckedChanged += new System.EventHandler(this.checkBoxRuong3_CheckedChanged);
            // 
            // checkBoxRuong1
            // 
            this.checkBoxRuong1.AutoSize = true;
            this.checkBoxRuong1.Location = new System.Drawing.Point(103, 159);
            this.checkBoxRuong1.Name = "checkBoxRuong1";
            this.checkBoxRuong1.Size = new System.Drawing.Size(40, 17);
            this.checkBoxRuong1.TabIndex = 256;
            this.checkBoxRuong1.Text = "R1";
            this.checkBoxRuong1.UseVisualStyleBackColor = true;
            this.checkBoxRuong1.CheckedChanged += new System.EventHandler(this.checkBoxRuong1_CheckedChanged);
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(3, 35);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(234, 29);
            this.label42.TabIndex = 262;
            this.label42.Text = "Nhặt đồ (phần này điều chỉnh trong lọc đồ điều khiển - bảng 1)";
            // 
            // buttonApdungAllTrain
            // 
            this.buttonApdungAllTrain.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonApdungAllTrain.Location = new System.Drawing.Point(4, 278);
            this.buttonApdungAllTrain.Name = "buttonApdungAllTrain";
            this.buttonApdungAllTrain.Size = new System.Drawing.Size(122, 23);
            this.buttonApdungAllTrain.TabIndex = 238;
            this.buttonApdungAllTrain.Text = "Áp dụng tất cả ac";
            this.buttonApdungAllTrain.UseVisualStyleBackColor = true;
            this.buttonApdungAllTrain.Click += new System.EventHandler(this.buttonApdungAllTrain_Click);
            // 
            // buttonHuongDan
            // 
            this.buttonHuongDan.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonHuongDan.Location = new System.Drawing.Point(131, 278);
            this.buttonHuongDan.Name = "buttonHuongDan";
            this.buttonHuongDan.Size = new System.Drawing.Size(69, 23);
            this.buttonHuongDan.TabIndex = 252;
            this.buttonHuongDan.Text = "H.dẫn";
            this.buttonHuongDan.UseVisualStyleBackColor = true;
            this.buttonHuongDan.Click += new System.EventHandler(this.buttonHuongDan_Click);
            // 
            // comboBoxTHP
            // 
            this.comboBoxTHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTHP.DropDownWidth = 100;
            this.comboBoxTHP.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTHP.FormattingEnabled = true;
            this.comboBoxTHP.Location = new System.Drawing.Point(150, 334);
            this.comboBoxTHP.Name = "comboBoxTHP";
            this.comboBoxTHP.Size = new System.Drawing.Size(70, 21);
            this.comboBoxTHP.TabIndex = 348;
            this.comboBoxTHP.SelectedIndexChanged += new System.EventHandler(this.comboBoxTHP_SelectedIndexChanged);
            // 
            // buttonXanh
            // 
            this.buttonXanh.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonXanh.ForeColor = System.Drawing.Color.Black;
            this.buttonXanh.Location = new System.Drawing.Point(37, 332);
            this.buttonXanh.Name = "buttonXanh";
            this.buttonXanh.Size = new System.Drawing.Size(32, 23);
            this.buttonXanh.TabIndex = 177;
            this.buttonXanh.Text = "X";
            this.buttonXanh.UseVisualStyleBackColor = false;
            this.buttonXanh.Click += new System.EventHandler(this.buttonXanh_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.BackColor = System.Drawing.Color.Violet;
            this.buttonTim.ForeColor = System.Drawing.Color.Black;
            this.buttonTim.Location = new System.Drawing.Point(71, 332);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(32, 23);
            this.buttonTim.TabIndex = 176;
            this.buttonTim.Text = "T";
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControlHaucan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(256, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hậu cần";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlHaucan
            // 
            this.tabControlHaucan.Controls.Add(this.tabPageMuathuoc);
            this.tabControlHaucan.Controls.Add(this.tabPagePhuchoi);
            this.tabControlHaucan.Controls.Add(this.tabPageChieuthuc);
            this.tabControlHaucan.Location = new System.Drawing.Point(0, 0);
            this.tabControlHaucan.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlHaucan.Name = "tabControlHaucan";
            this.tabControlHaucan.SelectedIndex = 0;
            this.tabControlHaucan.Size = new System.Drawing.Size(260, 359);
            this.tabControlHaucan.TabIndex = 0;
            // 
            // tabPageMuathuoc
            // 
            this.tabPageMuathuoc.Controls.Add(this.buttonTatMua);
            this.tabPageMuathuoc.Controls.Add(this.textBoxSoluongThuocDimua);
            this.tabPageMuathuoc.Controls.Add(this.buttonMuathuocBaovat);
            this.tabPageMuathuoc.Controls.Add(this.textBoxPass);
            this.tabPageMuathuoc.Controls.Add(this.textBoxSoluong1);
            this.tabPageMuathuoc.Controls.Add(this.textBoxSoluong2);
            this.tabPageMuathuoc.Controls.Add(this.textBoxSoluongMuaGiaiDoc);
            this.tabPageMuathuoc.Controls.Add(this.buttonKyTranCac);
            this.tabPageMuathuoc.Controls.Add(this.checkBoxMuaKTC);
            this.tabPageMuathuoc.Controls.Add(this.tabControl5);
            this.tabPageMuathuoc.Controls.Add(this.checkBoxRuongBH);
            this.tabPageMuathuoc.Controls.Add(this.label12);
            this.tabPageMuathuoc.Controls.Add(this.textBoxSoluongTDP);
            this.tabPageMuathuoc.Controls.Add(this.comboBoxMua2);
            this.tabPageMuathuoc.Controls.Add(this.comboBoxMua1);
            this.tabPageMuathuoc.Controls.Add(this.comboBoxMuaGiaiDoc);
            this.tabPageMuathuoc.Controls.Add(this.buttonApDungMuaThuocAll);
            this.tabPageMuathuoc.Controls.Add(this.buttonBungTuimau);
            this.tabPageMuathuoc.Controls.Add(this.checkBoxMuaTDP);
            this.tabPageMuathuoc.Controls.Add(this.textBoxTienMangtheo);
            this.tabPageMuathuoc.Controls.Add(this.buttonComboNhoithuoc);
            this.tabPageMuathuoc.Controls.Add(this.label4);
            this.tabPageMuathuoc.Controls.Add(this.checkBoxMangtheotien);
            this.tabPageMuathuoc.Controls.Add(this.checkBoxMua1);
            this.tabPageMuathuoc.Controls.Add(this.checkBoxMuaGiaiDoc);
            this.tabPageMuathuoc.Controls.Add(this.checkBoxMua2);
            this.tabPageMuathuoc.Location = new System.Drawing.Point(4, 22);
            this.tabPageMuathuoc.Name = "tabPageMuathuoc";
            this.tabPageMuathuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMuathuoc.Size = new System.Drawing.Size(252, 333);
            this.tabPageMuathuoc.TabIndex = 0;
            this.tabPageMuathuoc.Text = "Mua thuốc";
            this.tabPageMuathuoc.UseVisualStyleBackColor = true;
            // 
            // buttonTatMua
            // 
            this.buttonTatMua.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTatMua.ForeColor = System.Drawing.Color.Black;
            this.buttonTatMua.Location = new System.Drawing.Point(141, 148);
            this.buttonTatMua.Name = "buttonTatMua";
            this.buttonTatMua.Size = new System.Drawing.Size(110, 23);
            this.buttonTatMua.TabIndex = 380;
            this.buttonTatMua.Text = "Tắt mua tất cả ac";
            this.buttonTatMua.UseVisualStyleBackColor = false;
            this.buttonTatMua.Click += new System.EventHandler(this.buttonTatMua_Click);
            // 
            // textBoxSoluongThuocDimua
            // 
            this.textBoxSoluongThuocDimua.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluongThuocDimua.Location = new System.Drawing.Point(221, 26);
            this.textBoxSoluongThuocDimua.Name = "textBoxSoluongThuocDimua";
            this.textBoxSoluongThuocDimua.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoluongThuocDimua.TabIndex = 138;
            this.textBoxSoluongThuocDimua.TextChanged += new System.EventHandler(this.textBoxSoluongThuocDimua_TextChanged);
            // 
            // buttonMuathuocBaovat
            // 
            this.buttonMuathuocBaovat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMuathuocBaovat.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonMuathuocBaovat.Location = new System.Drawing.Point(141, 120);
            this.buttonMuathuocBaovat.Name = "buttonMuathuocBaovat";
            this.buttonMuathuocBaovat.Size = new System.Drawing.Size(110, 21);
            this.buttonMuathuocBaovat.TabIndex = 342;
            this.buttonMuathuocBaovat.Text = "Tất cả mua bảo vật";
            this.buttonMuathuocBaovat.UseVisualStyleBackColor = false;
            this.buttonMuathuocBaovat.Click += new System.EventHandler(this.buttonMuathuocBaovat_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.Location = new System.Drawing.Point(220, 1);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(31, 20);
            this.textBoxPass.TabIndex = 153;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // textBoxSoluong1
            // 
            this.textBoxSoluong1.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluong1.Location = new System.Drawing.Point(221, 49);
            this.textBoxSoluong1.Name = "textBoxSoluong1";
            this.textBoxSoluong1.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoluong1.TabIndex = 11;
            this.textBoxSoluong1.TextChanged += new System.EventHandler(this.textBoxSoluong1_TextChanged);
            // 
            // textBoxSoluong2
            // 
            this.textBoxSoluong2.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluong2.Location = new System.Drawing.Point(221, 72);
            this.textBoxSoluong2.Name = "textBoxSoluong2";
            this.textBoxSoluong2.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoluong2.TabIndex = 14;
            this.textBoxSoluong2.TextChanged += new System.EventHandler(this.textBoxSoluong2_TextChanged);
            // 
            // textBoxSoluongMuaGiaiDoc
            // 
            this.textBoxSoluongMuaGiaiDoc.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluongMuaGiaiDoc.Location = new System.Drawing.Point(221, 95);
            this.textBoxSoluongMuaGiaiDoc.Name = "textBoxSoluongMuaGiaiDoc";
            this.textBoxSoluongMuaGiaiDoc.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoluongMuaGiaiDoc.TabIndex = 196;
            this.textBoxSoluongMuaGiaiDoc.TextChanged += new System.EventHandler(this.textBoxSoluongMuaGiaiDoc_TextChanged);
            // 
            // buttonKyTranCac
            // 
            this.buttonKyTranCac.Location = new System.Drawing.Point(75, 120);
            this.buttonKyTranCac.Name = "buttonKyTranCac";
            this.buttonKyTranCac.Size = new System.Drawing.Size(65, 21);
            this.buttonKyTranCac.TabIndex = 379;
            this.buttonKyTranCac.Text = "Bảo vật";
            this.buttonKyTranCac.UseVisualStyleBackColor = true;
            this.buttonKyTranCac.Click += new System.EventHandler(this.buttonKyTranCac_Click);
            // 
            // checkBoxMuaKTC
            // 
            this.checkBoxMuaKTC.AutoSize = true;
            this.checkBoxMuaKTC.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMuaKTC.Location = new System.Drawing.Point(3, 122);
            this.checkBoxMuaKTC.Name = "checkBoxMuaKTC";
            this.checkBoxMuaKTC.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMuaKTC.TabIndex = 378;
            this.checkBoxMuaKTC.Text = "Mua ở";
            this.checkBoxMuaKTC.UseVisualStyleBackColor = true;
            this.checkBoxMuaKTC.CheckedChanged += new System.EventHandler(this.checkBoxMuaKTC_CheckedChanged);
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage6);
            this.tabControl5.Controls.Add(this.tabPage11);
            this.tabControl5.Controls.Add(this.tabPage5);
            this.tabControl5.Location = new System.Drawing.Point(2, 177);
            this.tabControl5.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(250, 115);
            this.tabControl5.TabIndex = 377;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.checkBoxNguHoa500l);
            this.tabPage6.Controls.Add(this.checkBoxMuaThontran);
            this.tabPage6.Controls.Add(this.checkBoxHoasonMuamau500l);
            this.tabPage6.Controls.Add(this.checkBoxTuchayMuathuoc);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(242, 89);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Nâng cao";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // checkBoxNguHoa500l
            // 
            this.checkBoxNguHoa500l.AutoSize = true;
            this.checkBoxNguHoa500l.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxNguHoa500l.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxNguHoa500l.Location = new System.Drawing.Point(3, 25);
            this.checkBoxNguHoa500l.Name = "checkBoxNguHoa500l";
            this.checkBoxNguHoa500l.Size = new System.Drawing.Size(228, 17);
            this.checkBoxNguHoa500l.TabIndex = 150;
            this.checkBoxNguHoa500l.Text = "Mua máu miễn phí (hiệu thuốc, tống kim...)";
            this.checkBoxNguHoa500l.UseVisualStyleBackColor = false;
            this.checkBoxNguHoa500l.CheckedChanged += new System.EventHandler(this.checkBoxNguHoa500l_CheckedChanged);
            // 
            // checkBoxMuaThontran
            // 
            this.checkBoxMuaThontran.AutoSize = true;
            this.checkBoxMuaThontran.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxMuaThontran.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxMuaThontran.Location = new System.Drawing.Point(3, 4);
            this.checkBoxMuaThontran.Name = "checkBoxMuaThontran";
            this.checkBoxMuaThontran.Size = new System.Drawing.Size(233, 17);
            this.checkBoxMuaThontran.TabIndex = 338;
            this.checkBoxMuaThontran.Text = "Mua máu ở thôn trấn, không chạy lên thành";
            this.checkBoxMuaThontran.UseVisualStyleBackColor = false;
            this.checkBoxMuaThontran.CheckedChanged += new System.EventHandler(this.checkBoxMuaThontran_CheckedChanged);
            // 
            // checkBoxHoasonMuamau500l
            // 
            this.checkBoxHoasonMuamau500l.AutoSize = true;
            this.checkBoxHoasonMuamau500l.ForeColor = System.Drawing.Color.Black;
            this.checkBoxHoasonMuamau500l.Location = new System.Drawing.Point(3, 68);
            this.checkBoxHoasonMuamau500l.Name = "checkBoxHoasonMuamau500l";
            this.checkBoxHoasonMuamau500l.Size = new System.Drawing.Size(145, 17);
            this.checkBoxHoasonMuamau500l.TabIndex = 331;
            this.checkBoxHoasonMuamau500l.Text = "Mua máu 500l ở Hoa sơn";
            this.checkBoxHoasonMuamau500l.UseVisualStyleBackColor = true;
            this.checkBoxHoasonMuamau500l.CheckedChanged += new System.EventHandler(this.checkBoxHoasonMuamau500l_CheckedChanged);
            // 
            // checkBoxTuchayMuathuoc
            // 
            this.checkBoxTuchayMuathuoc.AutoSize = true;
            this.checkBoxTuchayMuathuoc.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTuchayMuathuoc.Location = new System.Drawing.Point(3, 46);
            this.checkBoxTuchayMuathuoc.Name = "checkBoxTuchayMuathuoc";
            this.checkBoxTuchayMuathuoc.Size = new System.Drawing.Size(228, 17);
            this.checkBoxTuchayMuathuoc.TabIndex = 217;
            this.checkBoxTuchayMuathuoc.Text = "Tự chạy mua thuốc ở Hoa sơn khi hết máu";
            this.checkBoxTuchayMuathuoc.UseVisualStyleBackColor = true;
            this.checkBoxTuchayMuathuoc.CheckedChanged += new System.EventHandler(this.checkBoxTuchayMuathuoc_CheckedChanged);
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.checkBoxBamPhimCong);
            this.tabPage11.Controls.Add(this.checkBoxTuChuyenThuoc);
            this.tabPage11.Controls.Add(this.label8);
            this.tabPage11.Controls.Add(this.textBoxSoluongChuyenthuoc);
            this.tabPage11.Controls.Add(this.comboBoxChuyenThuoc);
            this.tabPage11.Controls.Add(this.label5);
            this.tabPage11.Controls.Add(this.buttonHDChuyenthuoc);
            this.tabPage11.Controls.Add(this.textBoxChuyenThuocMin);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(242, 89);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Tự chuyển thuốc";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // checkBoxBamPhimCong
            // 
            this.checkBoxBamPhimCong.AutoSize = true;
            this.checkBoxBamPhimCong.Location = new System.Drawing.Point(90, 23);
            this.checkBoxBamPhimCong.Name = "checkBoxBamPhimCong";
            this.checkBoxBamPhimCong.Size = new System.Drawing.Size(144, 17);
            this.checkBoxBamPhimCong.TabIndex = 379;
            this.checkBoxBamPhimCong.Text = "Chuyển khi bấm phím + -";
            this.checkBoxBamPhimCong.UseVisualStyleBackColor = true;
            this.checkBoxBamPhimCong.CheckedChanged += new System.EventHandler(this.checkBoxBamPhimCong_CheckedChanged);
            // 
            // checkBoxTuChuyenThuoc
            // 
            this.checkBoxTuChuyenThuoc.Location = new System.Drawing.Point(3, 3);
            this.checkBoxTuChuyenThuoc.Name = "checkBoxTuChuyenThuoc";
            this.checkBoxTuChuyenThuoc.Size = new System.Drawing.Size(234, 33);
            this.checkBoxTuChuyenThuoc.TabIndex = 348;
            this.checkBoxTuChuyenThuoc.Text = "Tự động chuyển từ rương bang hội sang hành trang";
            this.checkBoxTuChuyenThuoc.UseVisualStyleBackColor = true;
            this.checkBoxTuChuyenThuoc.CheckedChanged += new System.EventHandler(this.checkBoxTuChuyenThuoc_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 353;
            this.label8.Text = "Khi số lượng còn <=";
            // 
            // textBoxSoluongChuyenthuoc
            // 
            this.textBoxSoluongChuyenthuoc.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluongChuyenthuoc.Location = new System.Drawing.Point(214, 66);
            this.textBoxSoluongChuyenthuoc.Name = "textBoxSoluongChuyenthuoc";
            this.textBoxSoluongChuyenthuoc.Size = new System.Drawing.Size(25, 20);
            this.textBoxSoluongChuyenthuoc.TabIndex = 170;
            this.textBoxSoluongChuyenthuoc.TextChanged += new System.EventHandler(this.textBoxSoluongChuyenthuoc_TextChanged);
            // 
            // comboBoxChuyenThuoc
            // 
            this.comboBoxChuyenThuoc.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxChuyenThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChuyenThuoc.DropDownWidth = 170;
            this.comboBoxChuyenThuoc.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChuyenThuoc.FormattingEnabled = true;
            this.comboBoxChuyenThuoc.Location = new System.Drawing.Point(2, 44);
            this.comboBoxChuyenThuoc.Name = "comboBoxChuyenThuoc";
            this.comboBoxChuyenThuoc.Size = new System.Drawing.Size(158, 21);
            this.comboBoxChuyenThuoc.TabIndex = 208;
            this.comboBoxChuyenThuoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxChuyenThuoc_SelectedIndexChanged);
            this.comboBoxChuyenThuoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxChuyenThuoc_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 350;
            this.label5.Text = "Thì chuyển";
            // 
            // buttonHDChuyenthuoc
            // 
            this.buttonHDChuyenthuoc.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHDChuyenthuoc.ForeColor = System.Drawing.Color.Black;
            this.buttonHDChuyenthuoc.Location = new System.Drawing.Point(165, 43);
            this.buttonHDChuyenthuoc.Name = "buttonHDChuyenthuoc";
            this.buttonHDChuyenthuoc.Size = new System.Drawing.Size(74, 21);
            this.buttonHDChuyenthuoc.TabIndex = 378;
            this.buttonHDChuyenthuoc.Text = "Phim h.dẫn";
            this.buttonHDChuyenthuoc.UseVisualStyleBackColor = false;
            this.buttonHDChuyenthuoc.Click += new System.EventHandler(this.buttonHDChuyenthuoc_Click);
            // 
            // textBoxChuyenThuocMin
            // 
            this.textBoxChuyenThuocMin.ForeColor = System.Drawing.Color.Black;
            this.textBoxChuyenThuocMin.Location = new System.Drawing.Point(110, 66);
            this.textBoxChuyenThuocMin.Name = "textBoxChuyenThuocMin";
            this.textBoxChuyenThuocMin.Size = new System.Drawing.Size(25, 20);
            this.textBoxChuyenThuocMin.TabIndex = 352;
            this.textBoxChuyenThuocMin.TextChanged += new System.EventHandler(this.textBoxChuyenThuocMin_TextChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.richTextBox1);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.checkBoxGanTenthuoc);
            this.tabPage5.Controls.Add(this.textBoxOso1);
            this.tabPage5.Controls.Add(this.textBoxOso2);
            this.tabPage5.Controls.Add(this.textBoxOso3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(242, 89);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Gán ô phím tắt";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 343;
            this.label20.Text = "Gán Mua3 vào ô";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(119, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(125, 87);
            this.richTextBox1.TabIndex = 340;
            this.richTextBox1.Text = "Tự gán thuốc vào ô phím tắt dưới khung chat của game. Nhập số thứ tự của ô tắt tr" +
    "ong game vào ô xanh lá cây của auto, còn nếu bỏ qua thì ghi số 0\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 342;
            this.label19.Text = "Gán Mua2 vào ô";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 341;
            this.label10.Text = "Gán Mua1 vào ô";
            // 
            // checkBoxGanTenthuoc
            // 
            this.checkBoxGanTenthuoc.AutoSize = true;
            this.checkBoxGanTenthuoc.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBoxGanTenthuoc.Location = new System.Drawing.Point(4, 4);
            this.checkBoxGanTenthuoc.Name = "checkBoxGanTenthuoc";
            this.checkBoxGanTenthuoc.Size = new System.Drawing.Size(112, 17);
            this.checkBoxGanTenthuoc.TabIndex = 337;
            this.checkBoxGanTenthuoc.Text = "Tự động gán ô tắt";
            this.checkBoxGanTenthuoc.UseVisualStyleBackColor = true;
            this.checkBoxGanTenthuoc.CheckedChanged += new System.EventHandler(this.checkBoxGanTenthuoc_CheckedChanged);
            // 
            // textBoxOso1
            // 
            this.textBoxOso1.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxOso1.Location = new System.Drawing.Point(93, 22);
            this.textBoxOso1.Name = "textBoxOso1";
            this.textBoxOso1.Size = new System.Drawing.Size(20, 20);
            this.textBoxOso1.TabIndex = 334;
            this.textBoxOso1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOso1.TextChanged += new System.EventHandler(this.textBoxOso1_TextChanged);
            // 
            // textBoxOso2
            // 
            this.textBoxOso2.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxOso2.Location = new System.Drawing.Point(93, 44);
            this.textBoxOso2.Name = "textBoxOso2";
            this.textBoxOso2.Size = new System.Drawing.Size(20, 20);
            this.textBoxOso2.TabIndex = 335;
            this.textBoxOso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOso2.TextChanged += new System.EventHandler(this.textBoxOso2_TextChanged);
            // 
            // textBoxOso3
            // 
            this.textBoxOso3.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxOso3.Location = new System.Drawing.Point(93, 66);
            this.textBoxOso3.Name = "textBoxOso3";
            this.textBoxOso3.Size = new System.Drawing.Size(20, 20);
            this.textBoxOso3.TabIndex = 336;
            this.textBoxOso3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOso3.TextChanged += new System.EventHandler(this.textBoxOso3_TextChanged);
            // 
            // checkBoxRuongBH
            // 
            this.checkBoxRuongBH.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBoxRuongBH.Location = new System.Drawing.Point(3, 142);
            this.checkBoxRuongBH.Name = "checkBoxRuongBH";
            this.checkBoxRuongBH.Size = new System.Drawing.Size(141, 32);
            this.checkBoxRuongBH.TabIndex = 376;
            this.checkBoxRuongBH.Text = "Tự chuyển (mua 1) vào đầy rương bang hội";
            this.checkBoxRuongBH.UseVisualStyleBackColor = true;
            this.checkBoxRuongBH.CheckedChanged += new System.EventHandler(this.checkBoxRuongBH_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(109, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 347;
            this.label12.Text = "Mua thuốc khi còn <=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSoluongTDP
            // 
            this.textBoxSoluongTDP.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluongTDP.Location = new System.Drawing.Point(75, 25);
            this.textBoxSoluongTDP.Name = "textBoxSoluongTDP";
            this.textBoxSoluongTDP.Size = new System.Drawing.Size(25, 20);
            this.textBoxSoluongTDP.TabIndex = 143;
            this.textBoxSoluongTDP.TextChanged += new System.EventHandler(this.textBoxSoluongTDP_TextChanged);
            // 
            // comboBoxMua2
            // 
            this.comboBoxMua2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMua2.DropDownWidth = 180;
            this.comboBoxMua2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMua2.FormattingEnabled = true;
            this.comboBoxMua2.Location = new System.Drawing.Point(75, 72);
            this.comboBoxMua2.Name = "comboBoxMua2";
            this.comboBoxMua2.Size = new System.Drawing.Size(142, 21);
            this.comboBoxMua2.TabIndex = 12;
            this.comboBoxMua2.SelectedIndexChanged += new System.EventHandler(this.comboBoxMua2_SelectedIndexChanged);
            this.comboBoxMua2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxMua2_MouseDown);
            // 
            // comboBoxMua1
            // 
            this.comboBoxMua1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxMua1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMua1.DropDownWidth = 180;
            this.comboBoxMua1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMua1.FormattingEnabled = true;
            this.comboBoxMua1.Location = new System.Drawing.Point(75, 49);
            this.comboBoxMua1.Name = "comboBoxMua1";
            this.comboBoxMua1.Size = new System.Drawing.Size(142, 21);
            this.comboBoxMua1.TabIndex = 9;
            this.comboBoxMua1.SelectedIndexChanged += new System.EventHandler(this.comboBoxMua1_SelectedIndexChanged);
            this.comboBoxMua1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxMua1_MouseDown);
            // 
            // comboBoxMuaGiaiDoc
            // 
            this.comboBoxMuaGiaiDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuaGiaiDoc.DropDownWidth = 180;
            this.comboBoxMuaGiaiDoc.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMuaGiaiDoc.FormattingEnabled = true;
            this.comboBoxMuaGiaiDoc.Location = new System.Drawing.Point(75, 95);
            this.comboBoxMuaGiaiDoc.Name = "comboBoxMuaGiaiDoc";
            this.comboBoxMuaGiaiDoc.Size = new System.Drawing.Size(142, 21);
            this.comboBoxMuaGiaiDoc.TabIndex = 194;
            this.comboBoxMuaGiaiDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuaGiaiDoc_SelectedIndexChanged);
            this.comboBoxMuaGiaiDoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxMuaGiaiDoc_MouseDown);
            // 
            // buttonApDungMuaThuocAll
            // 
            this.buttonApDungMuaThuocAll.BackColor = System.Drawing.SystemColors.Control;
            this.buttonApDungMuaThuocAll.ForeColor = System.Drawing.Color.Black;
            this.buttonApDungMuaThuocAll.Location = new System.Drawing.Point(161, 295);
            this.buttonApDungMuaThuocAll.Name = "buttonApDungMuaThuocAll";
            this.buttonApDungMuaThuocAll.Size = new System.Drawing.Size(91, 38);
            this.buttonApDungMuaThuocAll.TabIndex = 193;
            this.buttonApDungMuaThuocAll.Text = "Áp dụng cho tất cả ac";
            this.buttonApDungMuaThuocAll.UseVisualStyleBackColor = false;
            this.buttonApDungMuaThuocAll.Click += new System.EventHandler(this.buttonApDungMuaThuocAll_Click);
            // 
            // buttonBungTuimau
            // 
            this.buttonBungTuimau.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonBungTuimau.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonBungTuimau.Location = new System.Drawing.Point(75, 295);
            this.buttonBungTuimau.Name = "buttonBungTuimau";
            this.buttonBungTuimau.Size = new System.Drawing.Size(80, 38);
            this.buttonBungTuimau.TabIndex = 330;
            this.buttonBungTuimau.Text = "Tự mở túi thuốc hỗ trợ";
            this.buttonBungTuimau.UseVisualStyleBackColor = false;
            this.buttonBungTuimau.Click += new System.EventHandler(this.buttonBungTuimau_Click);
            // 
            // checkBoxMuaTDP
            // 
            this.checkBoxMuaTDP.AutoSize = true;
            this.checkBoxMuaTDP.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxMuaTDP.Location = new System.Drawing.Point(3, 26);
            this.checkBoxMuaTDP.Name = "checkBoxMuaTDP";
            this.checkBoxMuaTDP.Size = new System.Drawing.Size(72, 17);
            this.checkBoxMuaTDP.TabIndex = 142;
            this.checkBoxMuaTDP.Text = "Mua TĐP";
            this.checkBoxMuaTDP.UseVisualStyleBackColor = true;
            this.checkBoxMuaTDP.CheckedChanged += new System.EventHandler(this.checkBoxMuaTDP_CheckedChanged);
            // 
            // textBoxTienMangtheo
            // 
            this.textBoxTienMangtheo.ForeColor = System.Drawing.Color.Black;
            this.textBoxTienMangtheo.Location = new System.Drawing.Point(75, 1);
            this.textBoxTienMangtheo.Name = "textBoxTienMangtheo";
            this.textBoxTienMangtheo.Size = new System.Drawing.Size(80, 20);
            this.textBoxTienMangtheo.TabIndex = 140;
            this.textBoxTienMangtheo.TextChanged += new System.EventHandler(this.textBoxTienMangtheo_TextChanged);
            // 
            // buttonComboNhoithuoc
            // 
            this.buttonComboNhoithuoc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonComboNhoithuoc.ForeColor = System.Drawing.Color.Black;
            this.buttonComboNhoithuoc.Location = new System.Drawing.Point(3, 295);
            this.buttonComboNhoithuoc.Name = "buttonComboNhoithuoc";
            this.buttonComboNhoithuoc.Size = new System.Drawing.Size(70, 38);
            this.buttonComboNhoithuoc.TabIndex = 193;
            this.buttonComboNhoithuoc.Text = "Bơm nhồi thuốc";
            this.buttonComboNhoithuoc.UseVisualStyleBackColor = false;
            this.buttonComboNhoithuoc.Click += new System.EventHandler(this.buttonComboNhoithuoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(157, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 152;
            this.label4.Text = "Pass rương";
            // 
            // checkBoxMangtheotien
            // 
            this.checkBoxMangtheotien.AutoSize = true;
            this.checkBoxMangtheotien.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMangtheotien.Location = new System.Drawing.Point(3, 3);
            this.checkBoxMangtheotien.Name = "checkBoxMangtheotien";
            this.checkBoxMangtheotien.Size = new System.Drawing.Size(68, 17);
            this.checkBoxMangtheotien.TabIndex = 151;
            this.checkBoxMangtheotien.Text = "Đem tiền";
            this.checkBoxMangtheotien.UseVisualStyleBackColor = true;
            this.checkBoxMangtheotien.CheckedChanged += new System.EventHandler(this.checkBoxMangtheotien_CheckedChanged);
            // 
            // checkBoxMua1
            // 
            this.checkBoxMua1.AutoSize = true;
            this.checkBoxMua1.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBoxMua1.Location = new System.Drawing.Point(3, 51);
            this.checkBoxMua1.Name = "checkBoxMua1";
            this.checkBoxMua1.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMua1.TabIndex = 10;
            this.checkBoxMua1.Text = "Mua 1";
            this.checkBoxMua1.UseVisualStyleBackColor = true;
            this.checkBoxMua1.CheckedChanged += new System.EventHandler(this.checkBoxMua1_CheckedChanged);
            // 
            // checkBoxMuaGiaiDoc
            // 
            this.checkBoxMuaGiaiDoc.AutoSize = true;
            this.checkBoxMuaGiaiDoc.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMuaGiaiDoc.Location = new System.Drawing.Point(3, 99);
            this.checkBoxMuaGiaiDoc.Name = "checkBoxMuaGiaiDoc";
            this.checkBoxMuaGiaiDoc.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMuaGiaiDoc.TabIndex = 195;
            this.checkBoxMuaGiaiDoc.Text = "Mua 3";
            this.checkBoxMuaGiaiDoc.UseVisualStyleBackColor = true;
            this.checkBoxMuaGiaiDoc.CheckedChanged += new System.EventHandler(this.checkBoxMuaGiaiDoc_CheckedChanged);
            // 
            // checkBoxMua2
            // 
            this.checkBoxMua2.AutoSize = true;
            this.checkBoxMua2.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMua2.Location = new System.Drawing.Point(3, 76);
            this.checkBoxMua2.Name = "checkBoxMua2";
            this.checkBoxMua2.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMua2.TabIndex = 13;
            this.checkBoxMua2.Text = "Mua 2";
            this.checkBoxMua2.UseVisualStyleBackColor = true;
            this.checkBoxMua2.CheckedChanged += new System.EventHandler(this.checkBoxMua2_CheckedChanged);
            // 
            // tabPagePhuchoi
            // 
            this.tabPagePhuchoi.Controls.Add(this.checkBoxTTL);
            this.tabPagePhuchoi.Controls.Add(this.comboBoxPk);
            this.tabPagePhuchoi.Controls.Add(this.textBox3);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxUuTienBomCuuchuyen);
            this.tabPagePhuchoi.Controls.Add(this.textBox2);
            this.tabPagePhuchoi.Controls.Add(this.textBoxMPTdp);
            this.tabPagePhuchoi.Controls.Add(this.textBox1);
            this.tabPagePhuchoi.Controls.Add(this.textBoxHpTDP);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxMana2);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxMau2);
            this.tabPagePhuchoi.Controls.Add(this.comboBoxTenMana2);
            this.tabPagePhuchoi.Controls.Add(this.textBoxTimerMana2);
            this.tabPagePhuchoi.Controls.Add(this.textBoxRatioMana2);
            this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongMana2);
            this.tabPagePhuchoi.Controls.Add(this.comboBoxTenMau2);
            this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongMau2);
            this.tabPagePhuchoi.Controls.Add(this.textBoxTimerMau2);
            this.tabPagePhuchoi.Controls.Add(this.buttonAppDungBomMauAll);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxVeThanhKhiPKlon);
            this.tabPagePhuchoi.Controls.Add(this.textBoxRatioMau2);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxMPTdp);
            this.tabPagePhuchoi.Controls.Add(this.textBoxTDP_SL_Mana);
            this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongBomMagic);
            this.tabPagePhuchoi.Controls.Add(this.textBoxTimerBomMagic);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxTuGiaidoc);
            this.tabPagePhuchoi.Controls.Add(this.textBoxTDP_SL_Mau);
            this.tabPagePhuchoi.Controls.Add(this.buttonGiaiThichHaucan);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxTDP_SL_Mana);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxTDP_SL_Mau);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxMPBom);
            this.tabPagePhuchoi.Controls.Add(this.textBoxThoiGianBomHPDiem);
            this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongBomHP);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxHPTdp);
            this.tabPagePhuchoi.Controls.Add(this.textBoxThoigianBomMP);
            this.tabPagePhuchoi.Controls.Add(this.textBoxThoigianBomHP);
            this.tabPagePhuchoi.Controls.Add(this.textBoxBomHPDiem);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxBomHPDiem);
            this.tabPagePhuchoi.Controls.Add(this.textBoxSoLuongBomHPDiem);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxBomHP);
            this.tabPagePhuchoi.Controls.Add(this.textBoxMPBom);
            this.tabPagePhuchoi.Controls.Add(this.textBoxBomMPDiem);
            this.tabPagePhuchoi.Controls.Add(this.textBoxSoLuongBomMPDiem);
            this.tabPagePhuchoi.Controls.Add(this.checkBoxBomMPDiem);
            this.tabPagePhuchoi.Controls.Add(this.textBoxThoiGianBomMPDiem);
            this.tabPagePhuchoi.Controls.Add(this.textBoxHPBom);
            this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongBomMP);
            this.tabPagePhuchoi.Location = new System.Drawing.Point(4, 22);
            this.tabPagePhuchoi.Name = "tabPagePhuchoi";
            this.tabPagePhuchoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhuchoi.Size = new System.Drawing.Size(252, 333);
            this.tabPagePhuchoi.TabIndex = 2;
            this.tabPagePhuchoi.Text = "Phục hồi";
            this.tabPagePhuchoi.UseVisualStyleBackColor = true;
            // 
            // checkBoxTTL
            // 
            this.checkBoxTTL.AutoSize = true;
            this.checkBoxTTL.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTTL.Location = new System.Drawing.Point(3, 291);
            this.checkBoxTTL.Name = "checkBoxTTL";
            this.checkBoxTTL.Size = new System.Drawing.Size(113, 17);
            this.checkBoxTTL.TabIndex = 269;
            this.checkBoxTTL.Text = "Tự ăn Tiên thảo lộ";
            this.checkBoxTTL.UseVisualStyleBackColor = true;
            this.checkBoxTTL.CheckedChanged += new System.EventHandler(this.checkBoxTTL_CheckedChanged);
            // 
            // comboBoxPk
            // 
            this.comboBoxPk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPk.FormattingEnabled = true;
            this.comboBoxPk.Location = new System.Drawing.Point(177, 268);
            this.comboBoxPk.Name = "comboBoxPk";
            this.comboBoxPk.Size = new System.Drawing.Size(39, 21);
            this.comboBoxPk.TabIndex = 391;
            this.comboBoxPk.SelectedIndexChanged += new System.EventHandler(this.comboBoxPk_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(124, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(49, 13);
            this.textBox3.TabIndex = 390;
            this.textBox3.Text = "tỉ lệ %";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxUuTienBomCuuchuyen
            // 
            this.checkBoxUuTienBomCuuchuyen.AutoSize = true;
            this.checkBoxUuTienBomCuuchuyen.ForeColor = System.Drawing.Color.Black;
            this.checkBoxUuTienBomCuuchuyen.Location = new System.Drawing.Point(20, 85);
            this.checkBoxUuTienBomCuuchuyen.Name = "checkBoxUuTienBomCuuchuyen";
            this.checkBoxUuTienBomCuuchuyen.Size = new System.Drawing.Size(228, 17);
            this.checkBoxUuTienBomCuuchuyen.TabIndex = 340;
            this.checkBoxUuTienBomCuuchuyen.Text = "Ưu tiên bơm thuốc Cửu Chuyển hoàn trước";
            this.checkBoxUuTienBomCuuchuyen.UseVisualStyleBackColor = true;
            this.checkBoxUuTienBomCuuchuyen.CheckedChanged += new System.EventHandler(this.checkBoxUuTienBomCuuchuyen_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(178, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(38, 13);
            this.textBox2.TabIndex = 389;
            this.textBox2.Text = "miligiây";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMPTdp
            // 
            this.textBoxMPTdp.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBoxMPTdp.Location = new System.Drawing.Point(220, 178);
            this.textBoxMPTdp.Name = "textBoxMPTdp";
            this.textBoxMPTdp.Size = new System.Drawing.Size(30, 20);
            this.textBoxMPTdp.TabIndex = 128;
            this.textBoxMPTdp.TextChanged += new System.EventHandler(this.textBoxMPTdp_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(220, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(28, 13);
            this.textBox1.TabIndex = 388;
            this.textBox1.Text = "bình";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHpTDP
            // 
            this.textBoxHpTDP.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBoxHpTDP.Location = new System.Drawing.Point(90, 178);
            this.textBoxHpTDP.Name = "textBoxHpTDP";
            this.textBoxHpTDP.Size = new System.Drawing.Size(30, 20);
            this.textBoxHpTDP.TabIndex = 37;
            this.textBoxHpTDP.TextChanged += new System.EventHandler(this.textBoxHpTDP_TextChanged);
            // 
            // checkBoxMana2
            // 
            this.checkBoxMana2.AutoSize = true;
            this.checkBoxMana2.Location = new System.Drawing.Point(20, 156);
            this.checkBoxMana2.Name = "checkBoxMana2";
            this.checkBoxMana2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMana2.TabIndex = 339;
            this.checkBoxMana2.UseVisualStyleBackColor = true;
            this.checkBoxMana2.CheckedChanged += new System.EventHandler(this.checkBoxMana2_CheckedChanged);
            // 
            // checkBoxMau2
            // 
            this.checkBoxMau2.AutoSize = true;
            this.checkBoxMau2.Location = new System.Drawing.Point(20, 109);
            this.checkBoxMau2.Name = "checkBoxMau2";
            this.checkBoxMau2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMau2.TabIndex = 338;
            this.checkBoxMau2.UseVisualStyleBackColor = true;
            this.checkBoxMau2.CheckedChanged += new System.EventHandler(this.checkBoxMau2_CheckedChanged);
            // 
            // comboBoxTenMana2
            // 
            this.comboBoxTenMana2.DropDownWidth = 140;
            this.comboBoxTenMana2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTenMana2.FormattingEnabled = true;
            this.comboBoxTenMana2.Location = new System.Drawing.Point(41, 153);
            this.comboBoxTenMana2.Name = "comboBoxTenMana2";
            this.comboBoxTenMana2.Size = new System.Drawing.Size(97, 21);
            this.comboBoxTenMana2.TabIndex = 337;
            this.comboBoxTenMana2.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenMana2_SelectedIndexChanged);
            this.comboBoxTenMana2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxTenMana2_MouseDown);
            // 
            // textBoxTimerMana2
            // 
            this.textBoxTimerMana2.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimerMana2.Location = new System.Drawing.Point(177, 154);
            this.textBoxTimerMana2.Name = "textBoxTimerMana2";
            this.textBoxTimerMana2.Size = new System.Drawing.Size(40, 20);
            this.textBoxTimerMana2.TabIndex = 335;
            this.textBoxTimerMana2.TextChanged += new System.EventHandler(this.textBoxTimerMana2_TextChanged);
            // 
            // textBoxRatioMana2
            // 
            this.textBoxRatioMana2.ForeColor = System.Drawing.Color.Black;
            this.textBoxRatioMana2.Location = new System.Drawing.Point(143, 154);
            this.textBoxRatioMana2.Name = "textBoxRatioMana2";
            this.textBoxRatioMana2.Size = new System.Drawing.Size(30, 20);
            this.textBoxRatioMana2.TabIndex = 334;
            this.textBoxRatioMana2.TextChanged += new System.EventHandler(this.textBoxRatioMana2_TextChanged);
            // 
            // textBoxSoluongMana2
            // 
            this.textBoxSoluongMana2.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluongMana2.Location = new System.Drawing.Point(220, 154);
            this.textBoxSoluongMana2.Name = "textBoxSoluongMana2";
            this.textBoxSoluongMana2.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoluongMana2.TabIndex = 336;
            this.textBoxSoluongMana2.TextChanged += new System.EventHandler(this.textBoxSoluongMana2_TextChanged);
            // 
            // comboBoxTenMau2
            // 
            this.comboBoxTenMau2.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxTenMau2.DropDownWidth = 140;
            this.comboBoxTenMau2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTenMau2.FormattingEnabled = true;
            this.comboBoxTenMau2.Location = new System.Drawing.Point(41, 105);
            this.comboBoxTenMau2.Name = "comboBoxTenMau2";
            this.comboBoxTenMau2.Size = new System.Drawing.Size(97, 21);
            this.comboBoxTenMau2.TabIndex = 332;
            this.comboBoxTenMau2.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenMau2_SelectedIndexChanged);
            this.comboBoxTenMau2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxTenMau2_MouseDown);
            // 
            // textBoxSoluongMau2
            // 
            this.textBoxSoluongMau2.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSoluongMau2.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluongMau2.Location = new System.Drawing.Point(220, 106);
            this.textBoxSoluongMau2.Name = "textBoxSoluongMau2";
            this.textBoxSoluongMau2.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoluongMau2.TabIndex = 317;
            this.textBoxSoluongMau2.TextChanged += new System.EventHandler(this.textBoxSoluongMau2_TextChanged);
            // 
            // textBoxTimerMau2
            // 
            this.textBoxTimerMau2.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTimerMau2.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimerMau2.Location = new System.Drawing.Point(177, 106);
            this.textBoxTimerMau2.Name = "textBoxTimerMau2";
            this.textBoxTimerMau2.Size = new System.Drawing.Size(40, 20);
            this.textBoxTimerMau2.TabIndex = 316;
            this.textBoxTimerMau2.TextChanged += new System.EventHandler(this.textBoxTimerMau2_TextChanged);
            // 
            // buttonAppDungBomMauAll
            // 
            this.buttonAppDungBomMauAll.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAppDungBomMauAll.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonAppDungBomMauAll.Location = new System.Drawing.Point(143, 312);
            this.buttonAppDungBomMauAll.Name = "buttonAppDungBomMauAll";
            this.buttonAppDungBomMauAll.Size = new System.Drawing.Size(107, 21);
            this.buttonAppDungBomMauAll.TabIndex = 194;
            this.buttonAppDungBomMauAll.Text = "Áp dụng tất cả ac";
            this.buttonAppDungBomMauAll.UseVisualStyleBackColor = false;
            this.buttonAppDungBomMauAll.Click += new System.EventHandler(this.buttonAppDungBomMauAll_Click);
            // 
            // checkBoxVeThanhKhiPKlon
            // 
            this.checkBoxVeThanhKhiPKlon.AutoSize = true;
            this.checkBoxVeThanhKhiPKlon.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxVeThanhKhiPKlon.ForeColor = System.Drawing.Color.Black;
            this.checkBoxVeThanhKhiPKlon.Location = new System.Drawing.Point(3, 270);
            this.checkBoxVeThanhKhiPKlon.Name = "checkBoxVeThanhKhiPKlon";
            this.checkBoxVeThanhKhiPKlon.Size = new System.Drawing.Size(155, 17);
            this.checkBoxVeThanhKhiPKlon.TabIndex = 308;
            this.checkBoxVeThanhKhiPKlon.Text = "Về ở thành khi giá trị pk lớn";
            this.checkBoxVeThanhKhiPKlon.UseVisualStyleBackColor = false;
            this.checkBoxVeThanhKhiPKlon.CheckedChanged += new System.EventHandler(this.checkBoxVeThanhKhiPKlon_CheckedChanged);
            // 
            // textBoxRatioMau2
            // 
            this.textBoxRatioMau2.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxRatioMau2.ForeColor = System.Drawing.Color.Black;
            this.textBoxRatioMau2.Location = new System.Drawing.Point(143, 106);
            this.textBoxRatioMau2.Name = "textBoxRatioMau2";
            this.textBoxRatioMau2.Size = new System.Drawing.Size(30, 20);
            this.textBoxRatioMau2.TabIndex = 315;
            this.textBoxRatioMau2.TextChanged += new System.EventHandler(this.textBoxRatioMau2_TextChanged);
            // 
            // checkBoxMPTdp
            // 
            this.checkBoxMPTdp.AutoSize = true;
            this.checkBoxMPTdp.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBoxMPTdp.Location = new System.Drawing.Point(125, 181);
            this.checkBoxMPTdp.Name = "checkBoxMPTdp";
            this.checkBoxMPTdp.Size = new System.Drawing.Size(94, 17);
            this.checkBoxMPTdp.TabIndex = 129;
            this.checkBoxMPTdp.Text = "TĐP (%) mana";
            this.checkBoxMPTdp.UseVisualStyleBackColor = true;
            this.checkBoxMPTdp.CheckedChanged += new System.EventHandler(this.checkBoxMPTdp_CheckedChanged);
            // 
            // textBoxTDP_SL_Mana
            // 
            this.textBoxTDP_SL_Mana.ForeColor = System.Drawing.Color.Black;
            this.textBoxTDP_SL_Mana.Location = new System.Drawing.Point(220, 222);
            this.textBoxTDP_SL_Mana.Name = "textBoxTDP_SL_Mana";
            this.textBoxTDP_SL_Mana.Size = new System.Drawing.Size(30, 20);
            this.textBoxTDP_SL_Mana.TabIndex = 313;
            this.textBoxTDP_SL_Mana.TextChanged += new System.EventHandler(this.textBoxTDP_SL_Mana_TextChanged);
            // 
            // textBoxSoluongBomMagic
            // 
            this.textBoxSoluongBomMagic.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSoluongBomMagic.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluongBomMagic.Location = new System.Drawing.Point(220, 245);
            this.textBoxSoluongBomMagic.Name = "textBoxSoluongBomMagic";
            this.textBoxSoluongBomMagic.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoluongBomMagic.TabIndex = 202;
            this.textBoxSoluongBomMagic.TextChanged += new System.EventHandler(this.textBoxSoluongBomMagic_TextChanged);
            // 
            // textBoxTimerBomMagic
            // 
            this.textBoxTimerBomMagic.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTimerBomMagic.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimerBomMagic.Location = new System.Drawing.Point(177, 245);
            this.textBoxTimerBomMagic.Name = "textBoxTimerBomMagic";
            this.textBoxTimerBomMagic.Size = new System.Drawing.Size(40, 20);
            this.textBoxTimerBomMagic.TabIndex = 200;
            this.textBoxTimerBomMagic.TextChanged += new System.EventHandler(this.textBoxTimerBomMagic_TextChanged);
            // 
            // checkBoxTuGiaidoc
            // 
            this.checkBoxTuGiaidoc.AutoSize = true;
            this.checkBoxTuGiaidoc.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTuGiaidoc.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTuGiaidoc.Location = new System.Drawing.Point(3, 247);
            this.checkBoxTuGiaidoc.Name = "checkBoxTuGiaidoc";
            this.checkBoxTuGiaidoc.Size = new System.Drawing.Size(163, 17);
            this.checkBoxTuGiaidoc.TabIndex = 199;
            this.checkBoxTuGiaidoc.Text = "Tự ăn giải độc (ms, số lượng)";
            this.checkBoxTuGiaidoc.UseVisualStyleBackColor = false;
            this.checkBoxTuGiaidoc.CheckedChanged += new System.EventHandler(this.checkBoxTuGiaidoc_CheckedChanged);
            // 
            // textBoxTDP_SL_Mau
            // 
            this.textBoxTDP_SL_Mau.ForeColor = System.Drawing.Color.Black;
            this.textBoxTDP_SL_Mau.Location = new System.Drawing.Point(220, 200);
            this.textBoxTDP_SL_Mau.Name = "textBoxTDP_SL_Mau";
            this.textBoxTDP_SL_Mau.Size = new System.Drawing.Size(30, 20);
            this.textBoxTDP_SL_Mau.TabIndex = 311;
            this.textBoxTDP_SL_Mau.TextChanged += new System.EventHandler(this.textBoxTDP_SL_Mau_TextChanged);
            // 
            // buttonGiaiThichHaucan
            // 
            this.buttonGiaiThichHaucan.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGiaiThichHaucan.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonGiaiThichHaucan.Location = new System.Drawing.Point(3, 312);
            this.buttonGiaiThichHaucan.Name = "buttonGiaiThichHaucan";
            this.buttonGiaiThichHaucan.Size = new System.Drawing.Size(134, 21);
            this.buttonGiaiThichHaucan.TabIndex = 203;
            this.buttonGiaiThichHaucan.Text = "Bảng hướng dẫn cụ thể";
            this.buttonGiaiThichHaucan.UseVisualStyleBackColor = false;
            this.buttonGiaiThichHaucan.Click += new System.EventHandler(this.buttonGiaiThichHaucan_Click);
            // 
            // checkBoxTDP_SL_Mana
            // 
            this.checkBoxTDP_SL_Mana.AutoSize = true;
            this.checkBoxTDP_SL_Mana.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTDP_SL_Mana.Location = new System.Drawing.Point(3, 225);
            this.checkBoxTDP_SL_Mana.Name = "checkBoxTDP_SL_Mana";
            this.checkBoxTDP_SL_Mana.Size = new System.Drawing.Size(170, 17);
            this.checkBoxTDP_SL_Mana.TabIndex = 314;
            this.checkBoxTDP_SL_Mana.Text = "TĐP số lượng mana còn (bình)";
            this.checkBoxTDP_SL_Mana.UseVisualStyleBackColor = true;
            this.checkBoxTDP_SL_Mana.CheckedChanged += new System.EventHandler(this.checkBoxTDP_SL_Mana_CheckedChanged);
            // 
            // checkBoxTDP_SL_Mau
            // 
            this.checkBoxTDP_SL_Mau.AutoSize = true;
            this.checkBoxTDP_SL_Mau.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTDP_SL_Mau.Location = new System.Drawing.Point(3, 203);
            this.checkBoxTDP_SL_Mau.Name = "checkBoxTDP_SL_Mau";
            this.checkBoxTDP_SL_Mau.Size = new System.Drawing.Size(181, 17);
            this.checkBoxTDP_SL_Mau.TabIndex = 312;
            this.checkBoxTDP_SL_Mau.Text = "TĐP khi số lượng máu còn (bình)";
            this.checkBoxTDP_SL_Mau.UseVisualStyleBackColor = true;
            this.checkBoxTDP_SL_Mau.CheckedChanged += new System.EventHandler(this.checkBoxTDP_SL_Mau_CheckedChanged);
            // 
            // checkBoxMPBom
            // 
            this.checkBoxMPBom.AutoSize = true;
            this.checkBoxMPBom.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMPBom.Location = new System.Drawing.Point(3, 132);
            this.checkBoxMPBom.Name = "checkBoxMPBom";
            this.checkBoxMPBom.Size = new System.Drawing.Size(117, 17);
            this.checkBoxMPBom.TabIndex = 131;
            this.checkBoxMPBom.Text = "Bơm mana theo (%)";
            this.checkBoxMPBom.UseVisualStyleBackColor = true;
            this.checkBoxMPBom.CheckedChanged += new System.EventHandler(this.checkBoxMPBom_CheckedChanged);
            // 
            // textBoxThoiGianBomHPDiem
            // 
            this.textBoxThoiGianBomHPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxThoiGianBomHPDiem.Location = new System.Drawing.Point(177, 15);
            this.textBoxThoiGianBomHPDiem.Name = "textBoxThoiGianBomHPDiem";
            this.textBoxThoiGianBomHPDiem.Size = new System.Drawing.Size(40, 20);
            this.textBoxThoiGianBomHPDiem.TabIndex = 154;
            this.textBoxThoiGianBomHPDiem.TextChanged += new System.EventHandler(this.textBoxThoiGianBomHPDiem_TextChanged);
            // 
            // textBoxSoluongBomHP
            // 
            this.textBoxSoluongBomHP.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSoluongBomHP.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluongBomHP.Location = new System.Drawing.Point(220, 62);
            this.textBoxSoluongBomHP.Name = "textBoxSoluongBomHP";
            this.textBoxSoluongBomHP.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoluongBomHP.TabIndex = 144;
            this.textBoxSoluongBomHP.TextChanged += new System.EventHandler(this.textBoxSoluongBomHP_TextChanged);
            // 
            // checkBoxHPTdp
            // 
            this.checkBoxHPTdp.AutoSize = true;
            this.checkBoxHPTdp.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBoxHPTdp.Location = new System.Drawing.Point(3, 181);
            this.checkBoxHPTdp.Name = "checkBoxHPTdp";
            this.checkBoxHPTdp.Size = new System.Drawing.Size(88, 17);
            this.checkBoxHPTdp.TabIndex = 125;
            this.checkBoxHPTdp.Text = "TĐP (%) máu";
            this.checkBoxHPTdp.UseVisualStyleBackColor = true;
            this.checkBoxHPTdp.CheckedChanged += new System.EventHandler(this.checkBoxHPTdp_CheckedChanged);
            // 
            // textBoxThoigianBomMP
            // 
            this.textBoxThoigianBomMP.ForeColor = System.Drawing.Color.Black;
            this.textBoxThoigianBomMP.Location = new System.Drawing.Point(177, 130);
            this.textBoxThoigianBomMP.Name = "textBoxThoigianBomMP";
            this.textBoxThoigianBomMP.Size = new System.Drawing.Size(40, 20);
            this.textBoxThoigianBomMP.TabIndex = 143;
            this.textBoxThoigianBomMP.TextChanged += new System.EventHandler(this.textBoxThoigianBomMP_TextChanged);
            // 
            // textBoxThoigianBomHP
            // 
            this.textBoxThoigianBomHP.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxThoigianBomHP.ForeColor = System.Drawing.Color.Black;
            this.textBoxThoigianBomHP.Location = new System.Drawing.Point(177, 62);
            this.textBoxThoigianBomHP.Name = "textBoxThoigianBomHP";
            this.textBoxThoigianBomHP.Size = new System.Drawing.Size(40, 20);
            this.textBoxThoigianBomHP.TabIndex = 142;
            this.textBoxThoigianBomHP.TextChanged += new System.EventHandler(this.textBoxThoigianBomHP_TextChanged);
            // 
            // textBoxBomHPDiem
            // 
            this.textBoxBomHPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxBomHPDiem.Location = new System.Drawing.Point(123, 15);
            this.textBoxBomHPDiem.Name = "textBoxBomHPDiem";
            this.textBoxBomHPDiem.Size = new System.Drawing.Size(50, 20);
            this.textBoxBomHPDiem.TabIndex = 150;
            this.textBoxBomHPDiem.TextChanged += new System.EventHandler(this.textBoxBomHPDiem_TextChanged);
            // 
            // checkBoxBomHPDiem
            // 
            this.checkBoxBomHPDiem.AutoSize = true;
            this.checkBoxBomHPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBoxBomHPDiem.Location = new System.Drawing.Point(3, 15);
            this.checkBoxBomHPDiem.Name = "checkBoxBomHPDiem";
            this.checkBoxBomHPDiem.Size = new System.Drawing.Size(96, 17);
            this.checkBoxBomHPDiem.TabIndex = 151;
            this.checkBoxBomHPDiem.Text = "Bơm máu điểm";
            this.checkBoxBomHPDiem.UseVisualStyleBackColor = true;
            this.checkBoxBomHPDiem.CheckedChanged += new System.EventHandler(this.checkBoxBomHPDiem_CheckedChanged);
            // 
            // textBoxSoLuongBomHPDiem
            // 
            this.textBoxSoLuongBomHPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxSoLuongBomHPDiem.Location = new System.Drawing.Point(220, 14);
            this.textBoxSoLuongBomHPDiem.Name = "textBoxSoLuongBomHPDiem";
            this.textBoxSoLuongBomHPDiem.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoLuongBomHPDiem.TabIndex = 156;
            this.textBoxSoLuongBomHPDiem.TextChanged += new System.EventHandler(this.textBoxSoLuongBomHPDiem_TextChanged);
            // 
            // checkBoxBomHP
            // 
            this.checkBoxBomHP.AutoSize = true;
            this.checkBoxBomHP.ForeColor = System.Drawing.Color.Black;
            this.checkBoxBomHP.Location = new System.Drawing.Point(3, 64);
            this.checkBoxBomHP.Name = "checkBoxBomHP";
            this.checkBoxBomHP.Size = new System.Drawing.Size(111, 17);
            this.checkBoxBomHP.TabIndex = 127;
            this.checkBoxBomHP.Text = "Bơm máu theo (%)";
            this.checkBoxBomHP.UseVisualStyleBackColor = true;
            this.checkBoxBomHP.CheckedChanged += new System.EventHandler(this.checkBoxBomHP_CheckedChanged);
            // 
            // textBoxMPBom
            // 
            this.textBoxMPBom.ForeColor = System.Drawing.Color.Black;
            this.textBoxMPBom.Location = new System.Drawing.Point(143, 130);
            this.textBoxMPBom.Name = "textBoxMPBom";
            this.textBoxMPBom.Size = new System.Drawing.Size(30, 20);
            this.textBoxMPBom.TabIndex = 130;
            this.textBoxMPBom.TextChanged += new System.EventHandler(this.textBoxMPBom_TextChanged);
            // 
            // textBoxBomMPDiem
            // 
            this.textBoxBomMPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxBomMPDiem.Location = new System.Drawing.Point(123, 37);
            this.textBoxBomMPDiem.Name = "textBoxBomMPDiem";
            this.textBoxBomMPDiem.Size = new System.Drawing.Size(50, 20);
            this.textBoxBomMPDiem.TabIndex = 152;
            this.textBoxBomMPDiem.TextChanged += new System.EventHandler(this.textBoxBomMPDiem_TextChanged);
            // 
            // textBoxSoLuongBomMPDiem
            // 
            this.textBoxSoLuongBomMPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxSoLuongBomMPDiem.Location = new System.Drawing.Point(220, 37);
            this.textBoxSoLuongBomMPDiem.Name = "textBoxSoLuongBomMPDiem";
            this.textBoxSoLuongBomMPDiem.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoLuongBomMPDiem.TabIndex = 157;
            this.textBoxSoLuongBomMPDiem.TextChanged += new System.EventHandler(this.textBoxSoLuongBomMPDiem_TextChanged);
            // 
            // checkBoxBomMPDiem
            // 
            this.checkBoxBomMPDiem.AutoSize = true;
            this.checkBoxBomMPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBoxBomMPDiem.Location = new System.Drawing.Point(3, 37);
            this.checkBoxBomMPDiem.Name = "checkBoxBomMPDiem";
            this.checkBoxBomMPDiem.Size = new System.Drawing.Size(102, 17);
            this.checkBoxBomMPDiem.TabIndex = 153;
            this.checkBoxBomMPDiem.Text = "Bơm mana điểm";
            this.checkBoxBomMPDiem.UseVisualStyleBackColor = true;
            this.checkBoxBomMPDiem.CheckedChanged += new System.EventHandler(this.checkBoxBomMPDiem_CheckedChanged);
            // 
            // textBoxThoiGianBomMPDiem
            // 
            this.textBoxThoiGianBomMPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxThoiGianBomMPDiem.Location = new System.Drawing.Point(177, 37);
            this.textBoxThoiGianBomMPDiem.Name = "textBoxThoiGianBomMPDiem";
            this.textBoxThoiGianBomMPDiem.Size = new System.Drawing.Size(40, 20);
            this.textBoxThoiGianBomMPDiem.TabIndex = 155;
            this.textBoxThoiGianBomMPDiem.TextChanged += new System.EventHandler(this.textBoxThoiGianBomMPDiem_TextChanged);
            // 
            // textBoxHPBom
            // 
            this.textBoxHPBom.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxHPBom.ForeColor = System.Drawing.Color.Black;
            this.textBoxHPBom.Location = new System.Drawing.Point(143, 62);
            this.textBoxHPBom.Name = "textBoxHPBom";
            this.textBoxHPBom.Size = new System.Drawing.Size(30, 20);
            this.textBoxHPBom.TabIndex = 126;
            this.textBoxHPBom.TextChanged += new System.EventHandler(this.textBoxHPBom_TextChanged);
            // 
            // textBoxSoluongBomMP
            // 
            this.textBoxSoluongBomMP.ForeColor = System.Drawing.Color.Black;
            this.textBoxSoluongBomMP.Location = new System.Drawing.Point(220, 130);
            this.textBoxSoluongBomMP.Name = "textBoxSoluongBomMP";
            this.textBoxSoluongBomMP.Size = new System.Drawing.Size(30, 20);
            this.textBoxSoluongBomMP.TabIndex = 145;
            this.textBoxSoluongBomMP.TextChanged += new System.EventHandler(this.textBoxSoluongBomMP_TextChanged);
            // 
            // tabPageChieuthuc
            // 
            this.tabPageChieuthuc.Controls.Add(this.checkBoxConLon);
            this.tabPageChieuthuc.Controls.Add(this.groupBox1);
            this.tabPageChieuthuc.Controls.Add(this.tabControlChuyenSkill);
            this.tabPageChieuthuc.Controls.Add(this.comboBoxGanChieuPhai);
            this.tabPageChieuthuc.Controls.Add(this.buttonSkill120vd);
            this.tabPageChieuthuc.Controls.Add(this.checkBoxGanChieuPhai);
            this.tabPageChieuthuc.Controls.Add(this.checkBoxGanChieuTrai);
            this.tabPageChieuthuc.Controls.Add(this.checkBoxTuGiaiBua);
            this.tabPageChieuthuc.Controls.Add(this.comboBoxGanChieuTrai);
            this.tabPageChieuthuc.Controls.Add(this.checkBoxTNXuatChieu120);
            this.tabPageChieuthuc.Controls.Add(this.buttonSkill120tn);
            this.tabPageChieuthuc.Location = new System.Drawing.Point(4, 22);
            this.tabPageChieuthuc.Name = "tabPageChieuthuc";
            this.tabPageChieuthuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChieuthuc.Size = new System.Drawing.Size(252, 333);
            this.tabPageChieuthuc.TabIndex = 3;
            this.tabPageChieuthuc.Text = "Chiêu thức";
            this.tabPageChieuthuc.UseVisualStyleBackColor = true;
            // 
            // checkBoxConLon
            // 
            this.checkBoxConLon.AutoSize = true;
            this.checkBoxConLon.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxConLon.ForeColor = System.Drawing.Color.Black;
            this.checkBoxConLon.Location = new System.Drawing.Point(6, 262);
            this.checkBoxConLon.Name = "checkBoxConLon";
            this.checkBoxConLon.Size = new System.Drawing.Size(240, 17);
            this.checkBoxConLon.TabIndex = 328;
            this.checkBoxConLon.Text = "Côn lôn buff Thanh Phong Phù cho ac chính";
            this.checkBoxConLon.UseVisualStyleBackColor = false;
            this.checkBoxConLon.CheckedChanged += new System.EventHandler(this.checkBoxConLon_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTranphai1);
            this.groupBox1.Controls.Add(this.comboBoxTranphai2);
            this.groupBox1.Controls.Add(this.textBoxTranphai2);
            this.groupBox1.Controls.Add(this.textBoxTranphai1);
            this.groupBox1.Controls.Add(this.checkBoxTranphai1);
            this.groupBox1.Controls.Add(this.checkBoxTranphai3);
            this.groupBox1.Controls.Add(this.comboBoxTranphai3);
            this.groupBox1.Controls.Add(this.checkBoxTranphai2);
            this.groupBox1.Controls.Add(this.textBoxTranphai3);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(2, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 99);
            this.groupBox1.TabIndex = 327;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buff trấn phái và hỗ trợ";
            // 
            // comboBoxTranphai1
            // 
            this.comboBoxTranphai1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTranphai1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTranphai1.FormattingEnabled = true;
            this.comboBoxTranphai1.Location = new System.Drawing.Point(40, 23);
            this.comboBoxTranphai1.Name = "comboBoxTranphai1";
            this.comboBoxTranphai1.Size = new System.Drawing.Size(156, 21);
            this.comboBoxTranphai1.TabIndex = 349;
            this.comboBoxTranphai1.SelectedIndexChanged += new System.EventHandler(this.comboBoxTranphai1_SelectedIndexChanged);
            // 
            // comboBoxTranphai2
            // 
            this.comboBoxTranphai2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTranphai2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTranphai2.FormattingEnabled = true;
            this.comboBoxTranphai2.Location = new System.Drawing.Point(40, 47);
            this.comboBoxTranphai2.Name = "comboBoxTranphai2";
            this.comboBoxTranphai2.Size = new System.Drawing.Size(156, 21);
            this.comboBoxTranphai2.TabIndex = 351;
            this.comboBoxTranphai2.SelectedIndexChanged += new System.EventHandler(this.comboBoxTranphai2_SelectedIndexChanged);
            // 
            // textBoxTranphai2
            // 
            this.textBoxTranphai2.ForeColor = System.Drawing.Color.Black;
            this.textBoxTranphai2.Location = new System.Drawing.Point(199, 48);
            this.textBoxTranphai2.Name = "textBoxTranphai2";
            this.textBoxTranphai2.Size = new System.Drawing.Size(44, 20);
            this.textBoxTranphai2.TabIndex = 352;
            this.textBoxTranphai2.Text = "0";
            this.textBoxTranphai2.TextChanged += new System.EventHandler(this.textBoxTranphai2_TextChanged);
            // 
            // textBoxTranphai1
            // 
            this.textBoxTranphai1.ForeColor = System.Drawing.Color.Black;
            this.textBoxTranphai1.Location = new System.Drawing.Point(199, 24);
            this.textBoxTranphai1.Name = "textBoxTranphai1";
            this.textBoxTranphai1.Size = new System.Drawing.Size(44, 20);
            this.textBoxTranphai1.TabIndex = 350;
            this.textBoxTranphai1.Text = "0";
            this.textBoxTranphai1.TextChanged += new System.EventHandler(this.textBoxTranphai1_TextChanged);
            // 
            // checkBoxTranphai1
            // 
            this.checkBoxTranphai1.AutoSize = true;
            this.checkBoxTranphai1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTranphai1.Location = new System.Drawing.Point(7, 24);
            this.checkBoxTranphai1.Name = "checkBoxTranphai1";
            this.checkBoxTranphai1.Size = new System.Drawing.Size(32, 17);
            this.checkBoxTranphai1.TabIndex = 355;
            this.checkBoxTranphai1.Text = "1";
            this.checkBoxTranphai1.UseVisualStyleBackColor = true;
            this.checkBoxTranphai1.CheckedChanged += new System.EventHandler(this.checkBoxTranphai1_CheckedChanged);
            // 
            // checkBoxTranphai3
            // 
            this.checkBoxTranphai3.AutoSize = true;
            this.checkBoxTranphai3.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTranphai3.Location = new System.Drawing.Point(7, 74);
            this.checkBoxTranphai3.Name = "checkBoxTranphai3";
            this.checkBoxTranphai3.Size = new System.Drawing.Size(32, 17);
            this.checkBoxTranphai3.TabIndex = 357;
            this.checkBoxTranphai3.Text = "3";
            this.checkBoxTranphai3.UseVisualStyleBackColor = true;
            this.checkBoxTranphai3.CheckedChanged += new System.EventHandler(this.checkBoxTranphai3_CheckedChanged);
            // 
            // comboBoxTranphai3
            // 
            this.comboBoxTranphai3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTranphai3.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTranphai3.FormattingEnabled = true;
            this.comboBoxTranphai3.Location = new System.Drawing.Point(40, 71);
            this.comboBoxTranphai3.Name = "comboBoxTranphai3";
            this.comboBoxTranphai3.Size = new System.Drawing.Size(156, 21);
            this.comboBoxTranphai3.TabIndex = 353;
            this.comboBoxTranphai3.SelectedIndexChanged += new System.EventHandler(this.comboBoxTranphai3_SelectedIndexChanged);
            // 
            // checkBoxTranphai2
            // 
            this.checkBoxTranphai2.AutoSize = true;
            this.checkBoxTranphai2.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTranphai2.Location = new System.Drawing.Point(7, 49);
            this.checkBoxTranphai2.Name = "checkBoxTranphai2";
            this.checkBoxTranphai2.Size = new System.Drawing.Size(32, 17);
            this.checkBoxTranphai2.TabIndex = 356;
            this.checkBoxTranphai2.Text = "2";
            this.checkBoxTranphai2.UseVisualStyleBackColor = true;
            this.checkBoxTranphai2.CheckedChanged += new System.EventHandler(this.checkBoxTranphai2_CheckedChanged);
            // 
            // textBoxTranphai3
            // 
            this.textBoxTranphai3.ForeColor = System.Drawing.Color.Black;
            this.textBoxTranphai3.Location = new System.Drawing.Point(199, 72);
            this.textBoxTranphai3.Name = "textBoxTranphai3";
            this.textBoxTranphai3.Size = new System.Drawing.Size(44, 20);
            this.textBoxTranphai3.TabIndex = 354;
            this.textBoxTranphai3.Text = "0";
            this.textBoxTranphai3.TextChanged += new System.EventHandler(this.textBoxTranphai3_TextChanged);
            // 
            // tabControlChuyenSkill
            // 
            this.tabControlChuyenSkill.Controls.Add(this.tabPage19);
            this.tabControlChuyenSkill.Controls.Add(this.tabPage20);
            this.tabControlChuyenSkill.Location = new System.Drawing.Point(1, 158);
            this.tabControlChuyenSkill.Name = "tabControlChuyenSkill";
            this.tabControlChuyenSkill.SelectedIndex = 0;
            this.tabControlChuyenSkill.Size = new System.Drawing.Size(250, 100);
            this.tabControlChuyenSkill.TabIndex = 326;
            // 
            // tabPage19
            // 
            this.tabPage19.Controls.Add(this.comboBoxChuyenChieuTrai1);
            this.tabPage19.Controls.Add(this.comboBoxChuyenChieuTrai2);
            this.tabPage19.Controls.Add(this.textBoxChuyenChieuTrai3);
            this.tabPage19.Controls.Add(this.comboBoxChuyenChieuTrai3);
            this.tabPage19.Controls.Add(this.textBoxChuyenChieuTrai2);
            this.tabPage19.Controls.Add(this.textBoxChuyenChieuTrai1);
            this.tabPage19.Controls.Add(this.checkBoxChuyenChieuTrai1);
            this.tabPage19.Controls.Add(this.checkBoxChuyenChieuTrai2);
            this.tabPage19.Controls.Add(this.checkBoxChuyenChieuTrai3);
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage19.Size = new System.Drawing.Size(242, 74);
            this.tabPage19.TabIndex = 0;
            this.tabPage19.Text = "Chuyển chiêu trái (ms)";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // comboBoxChuyenChieuTrai1
            // 
            this.comboBoxChuyenChieuTrai1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChuyenChieuTrai1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChuyenChieuTrai1.FormattingEnabled = true;
            this.comboBoxChuyenChieuTrai1.Location = new System.Drawing.Point(35, 3);
            this.comboBoxChuyenChieuTrai1.Name = "comboBoxChuyenChieuTrai1";
            this.comboBoxChuyenChieuTrai1.Size = new System.Drawing.Size(156, 21);
            this.comboBoxChuyenChieuTrai1.TabIndex = 133;
            this.comboBoxChuyenChieuTrai1.SelectedIndexChanged += new System.EventHandler(this.comboBoxChuyenChieuTrai1_SelectedIndexChanged);
            // 
            // comboBoxChuyenChieuTrai2
            // 
            this.comboBoxChuyenChieuTrai2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChuyenChieuTrai2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChuyenChieuTrai2.FormattingEnabled = true;
            this.comboBoxChuyenChieuTrai2.Location = new System.Drawing.Point(35, 27);
            this.comboBoxChuyenChieuTrai2.Name = "comboBoxChuyenChieuTrai2";
            this.comboBoxChuyenChieuTrai2.Size = new System.Drawing.Size(156, 21);
            this.comboBoxChuyenChieuTrai2.TabIndex = 135;
            this.comboBoxChuyenChieuTrai2.SelectedIndexChanged += new System.EventHandler(this.comboBoxChuyenChieuTrai2_SelectedIndexChanged);
            // 
            // textBoxChuyenChieuTrai3
            // 
            this.textBoxChuyenChieuTrai3.ForeColor = System.Drawing.Color.Black;
            this.textBoxChuyenChieuTrai3.Location = new System.Drawing.Point(194, 52);
            this.textBoxChuyenChieuTrai3.Name = "textBoxChuyenChieuTrai3";
            this.textBoxChuyenChieuTrai3.Size = new System.Drawing.Size(44, 20);
            this.textBoxChuyenChieuTrai3.TabIndex = 138;
            this.textBoxChuyenChieuTrai3.Text = "0";
            this.textBoxChuyenChieuTrai3.TextChanged += new System.EventHandler(this.textBoxChuyenChieuTrai3_TextChanged);
            // 
            // comboBoxChuyenChieuTrai3
            // 
            this.comboBoxChuyenChieuTrai3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChuyenChieuTrai3.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChuyenChieuTrai3.FormattingEnabled = true;
            this.comboBoxChuyenChieuTrai3.Location = new System.Drawing.Point(35, 51);
            this.comboBoxChuyenChieuTrai3.Name = "comboBoxChuyenChieuTrai3";
            this.comboBoxChuyenChieuTrai3.Size = new System.Drawing.Size(156, 21);
            this.comboBoxChuyenChieuTrai3.TabIndex = 137;
            this.comboBoxChuyenChieuTrai3.SelectedIndexChanged += new System.EventHandler(this.comboBoxChuyenChieuTrai3_SelectedIndexChanged);
            // 
            // textBoxChuyenChieuTrai2
            // 
            this.textBoxChuyenChieuTrai2.ForeColor = System.Drawing.Color.Black;
            this.textBoxChuyenChieuTrai2.Location = new System.Drawing.Point(194, 28);
            this.textBoxChuyenChieuTrai2.Name = "textBoxChuyenChieuTrai2";
            this.textBoxChuyenChieuTrai2.Size = new System.Drawing.Size(44, 20);
            this.textBoxChuyenChieuTrai2.TabIndex = 136;
            this.textBoxChuyenChieuTrai2.Text = "0";
            this.textBoxChuyenChieuTrai2.TextChanged += new System.EventHandler(this.textBoxChuyenChieuTrai2_TextChanged);
            // 
            // textBoxChuyenChieuTrai1
            // 
            this.textBoxChuyenChieuTrai1.ForeColor = System.Drawing.Color.Black;
            this.textBoxChuyenChieuTrai1.Location = new System.Drawing.Point(194, 4);
            this.textBoxChuyenChieuTrai1.Name = "textBoxChuyenChieuTrai1";
            this.textBoxChuyenChieuTrai1.Size = new System.Drawing.Size(44, 20);
            this.textBoxChuyenChieuTrai1.TabIndex = 134;
            this.textBoxChuyenChieuTrai1.Text = "0";
            this.textBoxChuyenChieuTrai1.TextChanged += new System.EventHandler(this.textBoxChuyenChieuTrai1_TextChanged);
            // 
            // checkBoxChuyenChieuTrai1
            // 
            this.checkBoxChuyenChieuTrai1.AutoSize = true;
            this.checkBoxChuyenChieuTrai1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChuyenChieuTrai1.Location = new System.Drawing.Point(2, 4);
            this.checkBoxChuyenChieuTrai1.Name = "checkBoxChuyenChieuTrai1";
            this.checkBoxChuyenChieuTrai1.Size = new System.Drawing.Size(32, 17);
            this.checkBoxChuyenChieuTrai1.TabIndex = 142;
            this.checkBoxChuyenChieuTrai1.Text = "1";
            this.checkBoxChuyenChieuTrai1.UseVisualStyleBackColor = true;
            this.checkBoxChuyenChieuTrai1.CheckedChanged += new System.EventHandler(this.checkBoxChuyenChieuTrai1_CheckedChanged);
            // 
            // checkBoxChuyenChieuTrai2
            // 
            this.checkBoxChuyenChieuTrai2.AutoSize = true;
            this.checkBoxChuyenChieuTrai2.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChuyenChieuTrai2.Location = new System.Drawing.Point(2, 29);
            this.checkBoxChuyenChieuTrai2.Name = "checkBoxChuyenChieuTrai2";
            this.checkBoxChuyenChieuTrai2.Size = new System.Drawing.Size(32, 17);
            this.checkBoxChuyenChieuTrai2.TabIndex = 143;
            this.checkBoxChuyenChieuTrai2.Text = "2";
            this.checkBoxChuyenChieuTrai2.UseVisualStyleBackColor = true;
            this.checkBoxChuyenChieuTrai2.CheckedChanged += new System.EventHandler(this.checkBoxChuyenChieuTrai2_CheckedChanged);
            // 
            // checkBoxChuyenChieuTrai3
            // 
            this.checkBoxChuyenChieuTrai3.AutoSize = true;
            this.checkBoxChuyenChieuTrai3.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChuyenChieuTrai3.Location = new System.Drawing.Point(2, 54);
            this.checkBoxChuyenChieuTrai3.Name = "checkBoxChuyenChieuTrai3";
            this.checkBoxChuyenChieuTrai3.Size = new System.Drawing.Size(32, 17);
            this.checkBoxChuyenChieuTrai3.TabIndex = 144;
            this.checkBoxChuyenChieuTrai3.Text = "3";
            this.checkBoxChuyenChieuTrai3.UseVisualStyleBackColor = true;
            this.checkBoxChuyenChieuTrai3.CheckedChanged += new System.EventHandler(this.checkBoxChuyenChieuTrai3_CheckedChanged);
            // 
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.comboBoxChuyenChieuPhai1);
            this.tabPage20.Controls.Add(this.comboBoxChuyenChieuPhai2);
            this.tabPage20.Controls.Add(this.textBoxChuyenChieuPhai3);
            this.tabPage20.Controls.Add(this.comboBoxChuyenChieuPhai3);
            this.tabPage20.Controls.Add(this.textBoxChuyenChieuPhai2);
            this.tabPage20.Controls.Add(this.textBoxChuyenChieuPhai1);
            this.tabPage20.Controls.Add(this.checkBoxChuyenChieuPhai1);
            this.tabPage20.Controls.Add(this.checkBoxChuyenChieuPhai2);
            this.tabPage20.Controls.Add(this.checkBoxChuyenChieuPhai3);
            this.tabPage20.Location = new System.Drawing.Point(4, 22);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage20.Size = new System.Drawing.Size(242, 74);
            this.tabPage20.TabIndex = 1;
            this.tabPage20.Text = "Chuyển chiêu phải (ms)";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // comboBoxChuyenChieuPhai1
            // 
            this.comboBoxChuyenChieuPhai1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChuyenChieuPhai1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChuyenChieuPhai1.FormattingEnabled = true;
            this.comboBoxChuyenChieuPhai1.Location = new System.Drawing.Point(35, 2);
            this.comboBoxChuyenChieuPhai1.Name = "comboBoxChuyenChieuPhai1";
            this.comboBoxChuyenChieuPhai1.Size = new System.Drawing.Size(156, 21);
            this.comboBoxChuyenChieuPhai1.TabIndex = 153;
            this.comboBoxChuyenChieuPhai1.SelectedIndexChanged += new System.EventHandler(this.comboBoxChuyenChieuPhai1_SelectedIndexChanged);
            // 
            // comboBoxChuyenChieuPhai2
            // 
            this.comboBoxChuyenChieuPhai2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChuyenChieuPhai2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChuyenChieuPhai2.FormattingEnabled = true;
            this.comboBoxChuyenChieuPhai2.Location = new System.Drawing.Point(35, 26);
            this.comboBoxChuyenChieuPhai2.Name = "comboBoxChuyenChieuPhai2";
            this.comboBoxChuyenChieuPhai2.Size = new System.Drawing.Size(156, 21);
            this.comboBoxChuyenChieuPhai2.TabIndex = 155;
            this.comboBoxChuyenChieuPhai2.SelectedIndexChanged += new System.EventHandler(this.comboBoxChuyenChieuPhai2_SelectedIndexChanged);
            // 
            // textBoxChuyenChieuPhai3
            // 
            this.textBoxChuyenChieuPhai3.ForeColor = System.Drawing.Color.Black;
            this.textBoxChuyenChieuPhai3.Location = new System.Drawing.Point(194, 51);
            this.textBoxChuyenChieuPhai3.Name = "textBoxChuyenChieuPhai3";
            this.textBoxChuyenChieuPhai3.Size = new System.Drawing.Size(44, 20);
            this.textBoxChuyenChieuPhai3.TabIndex = 158;
            this.textBoxChuyenChieuPhai3.Text = "0";
            this.textBoxChuyenChieuPhai3.TextChanged += new System.EventHandler(this.textBoxChuyenChieuPhai3_TextChanged);
            // 
            // comboBoxChuyenChieuPhai3
            // 
            this.comboBoxChuyenChieuPhai3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChuyenChieuPhai3.ForeColor = System.Drawing.Color.Black;
            this.comboBoxChuyenChieuPhai3.FormattingEnabled = true;
            this.comboBoxChuyenChieuPhai3.Location = new System.Drawing.Point(35, 50);
            this.comboBoxChuyenChieuPhai3.Name = "comboBoxChuyenChieuPhai3";
            this.comboBoxChuyenChieuPhai3.Size = new System.Drawing.Size(156, 21);
            this.comboBoxChuyenChieuPhai3.TabIndex = 157;
            this.comboBoxChuyenChieuPhai3.SelectedIndexChanged += new System.EventHandler(this.comboBoxChuyenChieuPhai3_SelectedIndexChanged);
            // 
            // textBoxChuyenChieuPhai2
            // 
            this.textBoxChuyenChieuPhai2.ForeColor = System.Drawing.Color.Black;
            this.textBoxChuyenChieuPhai2.Location = new System.Drawing.Point(194, 27);
            this.textBoxChuyenChieuPhai2.Name = "textBoxChuyenChieuPhai2";
            this.textBoxChuyenChieuPhai2.Size = new System.Drawing.Size(44, 20);
            this.textBoxChuyenChieuPhai2.TabIndex = 156;
            this.textBoxChuyenChieuPhai2.Text = "0";
            this.textBoxChuyenChieuPhai2.TextChanged += new System.EventHandler(this.textBoxChuyenChieuPhai2_TextChanged);
            // 
            // textBoxChuyenChieuPhai1
            // 
            this.textBoxChuyenChieuPhai1.ForeColor = System.Drawing.Color.Black;
            this.textBoxChuyenChieuPhai1.Location = new System.Drawing.Point(194, 3);
            this.textBoxChuyenChieuPhai1.Name = "textBoxChuyenChieuPhai1";
            this.textBoxChuyenChieuPhai1.Size = new System.Drawing.Size(44, 20);
            this.textBoxChuyenChieuPhai1.TabIndex = 154;
            this.textBoxChuyenChieuPhai1.Text = "0";
            this.textBoxChuyenChieuPhai1.TextChanged += new System.EventHandler(this.textBoxChuyenChieuPhai1_TextChanged);
            // 
            // checkBoxChuyenChieuPhai1
            // 
            this.checkBoxChuyenChieuPhai1.AutoSize = true;
            this.checkBoxChuyenChieuPhai1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChuyenChieuPhai1.Location = new System.Drawing.Point(2, 4);
            this.checkBoxChuyenChieuPhai1.Name = "checkBoxChuyenChieuPhai1";
            this.checkBoxChuyenChieuPhai1.Size = new System.Drawing.Size(32, 17);
            this.checkBoxChuyenChieuPhai1.TabIndex = 161;
            this.checkBoxChuyenChieuPhai1.Text = "1";
            this.checkBoxChuyenChieuPhai1.UseVisualStyleBackColor = true;
            this.checkBoxChuyenChieuPhai1.CheckedChanged += new System.EventHandler(this.checkBoxChuyenChieuPhai1_CheckedChanged);
            // 
            // checkBoxChuyenChieuPhai2
            // 
            this.checkBoxChuyenChieuPhai2.AutoSize = true;
            this.checkBoxChuyenChieuPhai2.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChuyenChieuPhai2.Location = new System.Drawing.Point(2, 29);
            this.checkBoxChuyenChieuPhai2.Name = "checkBoxChuyenChieuPhai2";
            this.checkBoxChuyenChieuPhai2.Size = new System.Drawing.Size(32, 17);
            this.checkBoxChuyenChieuPhai2.TabIndex = 162;
            this.checkBoxChuyenChieuPhai2.Text = "2";
            this.checkBoxChuyenChieuPhai2.UseVisualStyleBackColor = true;
            this.checkBoxChuyenChieuPhai2.CheckedChanged += new System.EventHandler(this.checkBoxChuyenChieuPhai2_CheckedChanged);
            // 
            // checkBoxChuyenChieuPhai3
            // 
            this.checkBoxChuyenChieuPhai3.AutoSize = true;
            this.checkBoxChuyenChieuPhai3.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChuyenChieuPhai3.Location = new System.Drawing.Point(2, 53);
            this.checkBoxChuyenChieuPhai3.Name = "checkBoxChuyenChieuPhai3";
            this.checkBoxChuyenChieuPhai3.Size = new System.Drawing.Size(32, 17);
            this.checkBoxChuyenChieuPhai3.TabIndex = 163;
            this.checkBoxChuyenChieuPhai3.Text = "3";
            this.checkBoxChuyenChieuPhai3.UseVisualStyleBackColor = true;
            this.checkBoxChuyenChieuPhai3.CheckedChanged += new System.EventHandler(this.checkBoxChuyenChieuPhai3_CheckedChanged);
            // 
            // comboBoxGanChieuPhai
            // 
            this.comboBoxGanChieuPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGanChieuPhai.DropDownWidth = 140;
            this.comboBoxGanChieuPhai.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGanChieuPhai.FormattingEnabled = true;
            this.comboBoxGanChieuPhai.Location = new System.Drawing.Point(104, 27);
            this.comboBoxGanChieuPhai.Name = "comboBoxGanChieuPhai";
            this.comboBoxGanChieuPhai.Size = new System.Drawing.Size(147, 21);
            this.comboBoxGanChieuPhai.TabIndex = 198;
            this.comboBoxGanChieuPhai.SelectedIndexChanged += new System.EventHandler(this.comboBoxGanChieuPhai_SelectedIndexChanged);
            // 
            // buttonSkill120vd
            // 
            this.buttonSkill120vd.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSkill120vd.ForeColor = System.Drawing.Color.Black;
            this.buttonSkill120vd.Location = new System.Drawing.Point(168, 286);
            this.buttonSkill120vd.Name = "buttonSkill120vd";
            this.buttonSkill120vd.Size = new System.Drawing.Size(33, 21);
            this.buttonSkill120vd.TabIndex = 324;
            this.buttonSkill120vd.Text = "...";
            this.buttonSkill120vd.UseVisualStyleBackColor = false;
            this.buttonSkill120vd.Click += new System.EventHandler(this.buttonSkill120vd_Click);
            // 
            // checkBoxGanChieuPhai
            // 
            this.checkBoxGanChieuPhai.AutoSize = true;
            this.checkBoxGanChieuPhai.ForeColor = System.Drawing.Color.Black;
            this.checkBoxGanChieuPhai.Location = new System.Drawing.Point(3, 30);
            this.checkBoxGanChieuPhai.Name = "checkBoxGanChieuPhai";
            this.checkBoxGanChieuPhai.Size = new System.Drawing.Size(98, 17);
            this.checkBoxGanChieuPhai.TabIndex = 156;
            this.checkBoxGanChieuPhai.Text = "Gán chiêu phải";
            this.checkBoxGanChieuPhai.UseVisualStyleBackColor = true;
            this.checkBoxGanChieuPhai.CheckedChanged += new System.EventHandler(this.checkBoxGanChieuPhai_CheckedChanged);
            // 
            // checkBoxGanChieuTrai
            // 
            this.checkBoxGanChieuTrai.AutoSize = true;
            this.checkBoxGanChieuTrai.ForeColor = System.Drawing.Color.Black;
            this.checkBoxGanChieuTrai.Location = new System.Drawing.Point(3, 8);
            this.checkBoxGanChieuTrai.Name = "checkBoxGanChieuTrai";
            this.checkBoxGanChieuTrai.Size = new System.Drawing.Size(92, 17);
            this.checkBoxGanChieuTrai.TabIndex = 155;
            this.checkBoxGanChieuTrai.Text = "Gán chiêu trái";
            this.checkBoxGanChieuTrai.UseVisualStyleBackColor = true;
            this.checkBoxGanChieuTrai.CheckedChanged += new System.EventHandler(this.checkBoxGanChieuTrai_CheckedChanged);
            // 
            // checkBoxTuGiaiBua
            // 
            this.checkBoxTuGiaiBua.AutoSize = true;
            this.checkBoxTuGiaiBua.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTuGiaiBua.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTuGiaiBua.Location = new System.Drawing.Point(6, 288);
            this.checkBoxTuGiaiBua.Name = "checkBoxTuGiaiBua";
            this.checkBoxTuGiaiBua.Size = new System.Drawing.Size(147, 17);
            this.checkBoxTuGiaiBua.TabIndex = 320;
            this.checkBoxTuGiaiBua.Text = "Võ Đang tự xuất skill 120 ";
            this.checkBoxTuGiaiBua.UseVisualStyleBackColor = false;
            this.checkBoxTuGiaiBua.CheckedChanged += new System.EventHandler(this.checkBoxTuGiaiBua_CheckedChanged);
            // 
            // comboBoxGanChieuTrai
            // 
            this.comboBoxGanChieuTrai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGanChieuTrai.DropDownWidth = 140;
            this.comboBoxGanChieuTrai.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGanChieuTrai.FormattingEnabled = true;
            this.comboBoxGanChieuTrai.Location = new System.Drawing.Point(104, 4);
            this.comboBoxGanChieuTrai.Name = "comboBoxGanChieuTrai";
            this.comboBoxGanChieuTrai.Size = new System.Drawing.Size(147, 21);
            this.comboBoxGanChieuTrai.TabIndex = 197;
            this.comboBoxGanChieuTrai.SelectedIndexChanged += new System.EventHandler(this.comboBoxGanChieuTrai_SelectedIndexChanged);
            // 
            // checkBoxTNXuatChieu120
            // 
            this.checkBoxTNXuatChieu120.AutoSize = true;
            this.checkBoxTNXuatChieu120.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxTNXuatChieu120.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTNXuatChieu120.Location = new System.Drawing.Point(6, 312);
            this.checkBoxTNXuatChieu120.Name = "checkBoxTNXuatChieu120";
            this.checkBoxTNXuatChieu120.Size = new System.Drawing.Size(158, 17);
            this.checkBoxTNXuatChieu120.TabIndex = 321;
            this.checkBoxTNXuatChieu120.Text = "Thiên Nhẫn tự xuất skill 120";
            this.checkBoxTNXuatChieu120.UseVisualStyleBackColor = false;
            this.checkBoxTNXuatChieu120.CheckedChanged += new System.EventHandler(this.checkBoxTNXuatChieu120_CheckedChanged);
            // 
            // buttonSkill120tn
            // 
            this.buttonSkill120tn.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSkill120tn.ForeColor = System.Drawing.Color.Black;
            this.buttonSkill120tn.Location = new System.Drawing.Point(168, 310);
            this.buttonSkill120tn.Name = "buttonSkill120tn";
            this.buttonSkill120tn.Size = new System.Drawing.Size(33, 21);
            this.buttonSkill120tn.TabIndex = 323;
            this.buttonSkill120tn.Text = "...";
            this.buttonSkill120tn.UseVisualStyleBackColor = false;
            this.buttonSkill120tn.Click += new System.EventHandler(this.buttonSkill120tn_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonResetAuto);
            this.tabPage7.Controls.Add(this.checkBoxBaoKeylog);
            this.tabPage7.Controls.Add(this.linkLabelTrangchu);
            this.tabPage7.Controls.Add(this.checkBoxChayRunAdmin);
            this.tabPage7.Controls.Add(this.buttonTuTimWeb);
            this.tabPage7.Controls.Add(this.checkBoxGameHu);
            this.tabPage7.Controls.Add(this.checkBoxGiamRamTudong);
            this.tabPage7.Controls.Add(this.comboBoxGameOfWeb);
            this.tabPage7.Controls.Add(this.buttonFixGameTuthoat);
            this.tabPage7.Controls.Add(this.tabControl2);
            this.tabPage7.Controls.Add(this.textBoxChatNham);
            this.tabPage7.Controls.Add(this.textBoxThuMuc);
            this.tabPage7.Controls.Add(this.checkBoxChatNham);
            this.tabPage7.Controls.Add(this.buttonBrowseGame);
            this.tabPage7.Controls.Add(this.buttonThumucAuto);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.buttonToShortcut);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(256, 357);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Cài game";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonResetAuto
            // 
            this.buttonResetAuto.BackColor = System.Drawing.SystemColors.Control;
            this.buttonResetAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonResetAuto.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonResetAuto.Location = new System.Drawing.Point(185, 130);
            this.buttonResetAuto.Name = "buttonResetAuto";
            this.buttonResetAuto.Size = new System.Drawing.Size(70, 40);
            this.buttonResetAuto.TabIndex = 344;
            this.buttonResetAuto.Text = "Reset cấu hình auto";
            this.buttonResetAuto.UseVisualStyleBackColor = false;
            this.buttonResetAuto.Click += new System.EventHandler(this.buttonResetAuto_Click);
            // 
            // checkBoxBaoKeylog
            // 
            this.checkBoxBaoKeylog.AutoSize = true;
            this.checkBoxBaoKeylog.ForeColor = System.Drawing.Color.Black;
            this.checkBoxBaoKeylog.Location = new System.Drawing.Point(79, 180);
            this.checkBoxBaoKeylog.Name = "checkBoxBaoKeylog";
            this.checkBoxBaoKeylog.Size = new System.Drawing.Size(104, 17);
            this.checkBoxBaoKeylog.TabIndex = 396;
            this.checkBoxBaoKeylog.Text = "Báo keylog virus";
            this.checkBoxBaoKeylog.UseVisualStyleBackColor = true;
            this.checkBoxBaoKeylog.CheckedChanged += new System.EventHandler(this.checkBoxBaoKeylog_CheckedChanged);
            // 
            // linkLabelTrangchu
            // 
            this.linkLabelTrangchu.AutoSize = true;
            this.linkLabelTrangchu.Location = new System.Drawing.Point(172, 2);
            this.linkLabelTrangchu.Name = "linkLabelTrangchu";
            this.linkLabelTrangchu.Size = new System.Drawing.Size(80, 13);
            this.linkLabelTrangchu.TabIndex = 166;
            this.linkLabelTrangchu.TabStop = true;
            this.linkLabelTrangchu.Text = "( mở trang web)";
            this.linkLabelTrangchu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTrangchu_LinkClicked);
            // 
            // checkBoxChayRunAdmin
            // 
            this.checkBoxChayRunAdmin.AutoSize = true;
            this.checkBoxChayRunAdmin.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChayRunAdmin.Location = new System.Drawing.Point(3, 132);
            this.checkBoxChayRunAdmin.Name = "checkBoxChayRunAdmin";
            this.checkBoxChayRunAdmin.Size = new System.Drawing.Size(160, 17);
            this.checkBoxChayRunAdmin.TabIndex = 173;
            this.checkBoxChayRunAdmin.Text = "Auto luôn chạy run as admin";
            this.checkBoxChayRunAdmin.UseVisualStyleBackColor = true;
            this.checkBoxChayRunAdmin.CheckedChanged += new System.EventHandler(this.checkBoxChayRunAdmin_CheckedChanged);
            // 
            // buttonTuTimWeb
            // 
            this.buttonTuTimWeb.ForeColor = System.Drawing.Color.Black;
            this.buttonTuTimWeb.Location = new System.Drawing.Point(210, 20);
            this.buttonTuTimWeb.Name = "buttonTuTimWeb";
            this.buttonTuTimWeb.Size = new System.Drawing.Size(45, 21);
            this.buttonTuTimWeb.TabIndex = 172;
            this.buttonTuTimWeb.Text = "Tự tìm";
            this.buttonTuTimWeb.UseVisualStyleBackColor = true;
            this.buttonTuTimWeb.Click += new System.EventHandler(this.buttonTuTimWeb_Click);
            // 
            // checkBoxGameHu
            // 
            this.checkBoxGameHu.AutoSize = true;
            this.checkBoxGameHu.ForeColor = System.Drawing.Color.Black;
            this.checkBoxGameHu.Location = new System.Drawing.Point(3, 155);
            this.checkBoxGameHu.Name = "checkBoxGameHu";
            this.checkBoxGameHu.Size = new System.Drawing.Size(160, 17);
            this.checkBoxGameHu.TabIndex = 168;
            this.checkBoxGameHu.Text = "Loại bỏ game hư chạy ngầm";
            this.checkBoxGameHu.UseVisualStyleBackColor = true;
            this.checkBoxGameHu.CheckedChanged += new System.EventHandler(this.checkBoxGameHu_CheckedChanged);
            // 
            // checkBoxGiamRamTudong
            // 
            this.checkBoxGiamRamTudong.AutoSize = true;
            this.checkBoxGiamRamTudong.ForeColor = System.Drawing.Color.Black;
            this.checkBoxGiamRamTudong.Location = new System.Drawing.Point(3, 180);
            this.checkBoxGiamRamTudong.Name = "checkBoxGiamRamTudong";
            this.checkBoxGiamRamTudong.Size = new System.Drawing.Size(70, 17);
            this.checkBoxGiamRamTudong.TabIndex = 160;
            this.checkBoxGiamRamTudong.Text = "Giảm ram";
            this.checkBoxGiamRamTudong.UseVisualStyleBackColor = true;
            this.checkBoxGiamRamTudong.CheckedChanged += new System.EventHandler(this.checkBoxGiamRamTudong_CheckedChanged);
            // 
            // comboBoxGameOfWeb
            // 
            this.comboBoxGameOfWeb.BackColor = System.Drawing.Color.White;
            this.comboBoxGameOfWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGameOfWeb.DropDownWidth = 250;
            this.comboBoxGameOfWeb.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGameOfWeb.FormattingEnabled = true;
            this.comboBoxGameOfWeb.Location = new System.Drawing.Point(4, 20);
            this.comboBoxGameOfWeb.Name = "comboBoxGameOfWeb";
            this.comboBoxGameOfWeb.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGameOfWeb.TabIndex = 143;
            this.comboBoxGameOfWeb.SelectedIndexChanged += new System.EventHandler(this.comboBoxGameOfWeb_SelectedIndexChanged);
            // 
            // buttonFixGameTuthoat
            // 
            this.buttonFixGameTuthoat.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonFixGameTuthoat.Location = new System.Drawing.Point(98, 86);
            this.buttonFixGameTuthoat.Name = "buttonFixGameTuthoat";
            this.buttonFixGameTuthoat.Size = new System.Drawing.Size(85, 36);
            this.buttonFixGameTuthoat.TabIndex = 142;
            this.buttonFixGameTuthoat.Text = "Nếu xài Win 8 và 10";
            this.buttonFixGameTuthoat.UseVisualStyleBackColor = true;
            this.buttonFixGameTuthoat.Click += new System.EventHandler(this.buttonFixGameTuthoat_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage14);
            this.tabControl2.Controls.Add(this.tabPage17);
            this.tabControl2.Location = new System.Drawing.Point(0, 253);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(258, 103);
            this.tabControl2.TabIndex = 163;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.richTextBoxBHO);
            this.tabPage14.Controls.Add(this.label11);
            this.tabPage14.Controls.Add(this.textBoxIDSudung);
            this.tabPage14.Controls.Add(this.buttonTrial);
            this.tabPage14.Controls.Add(this.buttonIDApdung);
            this.tabPage14.Controls.Add(this.buttonDangky);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(250, 77);
            this.tabPage14.TabIndex = 0;
            this.tabPage14.Text = "Lic Bang hội";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBHO
            // 
            this.richTextBoxBHO.Location = new System.Drawing.Point(1, 1);
            this.richTextBoxBHO.Name = "richTextBoxBHO";
            this.richTextBoxBHO.ReadOnly = true;
            this.richTextBoxBHO.Size = new System.Drawing.Size(184, 46);
            this.richTextBoxBHO.TabIndex = 142;
            this.richTextBoxBHO.Text = "Đang kết nối server, xin vui lòng chờ chút xíu...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 139;
            this.label11.Text = "ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIDSudung
            // 
            this.textBoxIDSudung.ForeColor = System.Drawing.Color.DarkRed;
            this.textBoxIDSudung.Location = new System.Drawing.Point(27, 54);
            this.textBoxIDSudung.Name = "textBoxIDSudung";
            this.textBoxIDSudung.Size = new System.Drawing.Size(135, 20);
            this.textBoxIDSudung.TabIndex = 140;
            // 
            // buttonTrial
            // 
            this.buttonTrial.ForeColor = System.Drawing.Color.Black;
            this.buttonTrial.Location = new System.Drawing.Point(165, 53);
            this.buttonTrial.Name = "buttonTrial";
            this.buttonTrial.Size = new System.Drawing.Size(20, 21);
            this.buttonTrial.TabIndex = 141;
            this.buttonTrial.Text = "X";
            this.buttonTrial.UseVisualStyleBackColor = true;
            this.buttonTrial.Click += new System.EventHandler(this.buttonTrial_Click);
            // 
            // buttonIDApdung
            // 
            this.buttonIDApdung.ForeColor = System.Drawing.Color.Black;
            this.buttonIDApdung.Location = new System.Drawing.Point(187, 52);
            this.buttonIDApdung.Name = "buttonIDApdung";
            this.buttonIDApdung.Size = new System.Drawing.Size(62, 22);
            this.buttonIDApdung.TabIndex = 137;
            this.buttonIDApdung.Text = "Áp dụng";
            this.buttonIDApdung.UseVisualStyleBackColor = true;
            this.buttonIDApdung.Click += new System.EventHandler(this.buttonIDApdung_Click);
            // 
            // buttonDangky
            // 
            this.buttonDangky.ForeColor = System.Drawing.Color.Black;
            this.buttonDangky.Location = new System.Drawing.Point(187, 12);
            this.buttonDangky.Name = "buttonDangky";
            this.buttonDangky.Size = new System.Drawing.Size(62, 36);
            this.buttonDangky.TabIndex = 135;
            this.buttonDangky.Text = "Thông tin bang hội";
            this.buttonDangky.UseVisualStyleBackColor = true;
            this.buttonDangky.Click += new System.EventHandler(this.buttonDangky_Click);
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.labelThongtinDK);
            this.tabPage17.Controls.Add(this.textBoxHSD);
            this.tabPage17.Controls.Add(this.buttonHDD);
            this.tabPage17.Controls.Add(this.label25);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(250, 77);
            this.tabPage17.TabIndex = 1;
            this.tabPage17.Text = "Lic HDD";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // labelThongtinDK
            // 
            this.labelThongtinDK.AutoSize = true;
            this.labelThongtinDK.Location = new System.Drawing.Point(1, 37);
            this.labelThongtinDK.Name = "labelThongtinDK";
            this.labelThongtinDK.Size = new System.Drawing.Size(97, 13);
            this.labelThongtinDK.TabIndex = 165;
            this.labelThongtinDK.Text = "Thông tin đăng ký:";
            // 
            // textBoxHSD
            // 
            this.textBoxHSD.ForeColor = System.Drawing.Color.Black;
            this.textBoxHSD.Location = new System.Drawing.Point(2, 54);
            this.textBoxHSD.Name = "textBoxHSD";
            this.textBoxHSD.ReadOnly = true;
            this.textBoxHSD.Size = new System.Drawing.Size(172, 20);
            this.textBoxHSD.TabIndex = 164;
            // 
            // buttonHDD
            // 
            this.buttonHDD.ForeColor = System.Drawing.Color.Black;
            this.buttonHDD.Location = new System.Drawing.Point(178, 40);
            this.buttonHDD.Name = "buttonHDD";
            this.buttonHDD.Size = new System.Drawing.Size(69, 36);
            this.buttonHDD.TabIndex = 163;
            this.buttonHDD.Text = "Đăng ký LIC HDD";
            this.buttonHDD.UseVisualStyleBackColor = true;
            this.buttonHDD.Click += new System.EventHandler(this.buttonHDD_Click);
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(1, 1);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(243, 30);
            this.label25.TabIndex = 164;
            this.label25.Text = "Lưu ý: LIC HDD không đăng ký được cho máy ảo và bootroom (tiệm nét).";
            // 
            // textBoxChatNham
            // 
            this.textBoxChatNham.ForeColor = System.Drawing.Color.Black;
            this.textBoxChatNham.Location = new System.Drawing.Point(3, 231);
            this.textBoxChatNham.Name = "textBoxChatNham";
            this.textBoxChatNham.Size = new System.Drawing.Size(251, 20);
            this.textBoxChatNham.TabIndex = 158;
            this.textBoxChatNham.TextChanged += new System.EventHandler(this.textBoxChatNham_TextChanged);
            // 
            // textBoxThuMuc
            // 
            this.textBoxThuMuc.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxThuMuc.ForeColor = System.Drawing.Color.Black;
            this.textBoxThuMuc.Location = new System.Drawing.Point(4, 61);
            this.textBoxThuMuc.Name = "textBoxThuMuc";
            this.textBoxThuMuc.ReadOnly = true;
            this.textBoxThuMuc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxThuMuc.Size = new System.Drawing.Size(200, 20);
            this.textBoxThuMuc.TabIndex = 31;
            this.textBoxThuMuc.WordWrap = false;
            // 
            // checkBoxChatNham
            // 
            this.checkBoxChatNham.AutoSize = true;
            this.checkBoxChatNham.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChatNham.Location = new System.Drawing.Point(3, 209);
            this.checkBoxChatNham.Name = "checkBoxChatNham";
            this.checkBoxChatNham.Size = new System.Drawing.Size(77, 17);
            this.checkBoxChatNham.TabIndex = 159;
            this.checkBoxChatNham.Text = "Chat nhảm";
            this.checkBoxChatNham.UseVisualStyleBackColor = true;
            this.checkBoxChatNham.CheckedChanged += new System.EventHandler(this.checkBoxChatNham_CheckedChanged);
            // 
            // buttonBrowseGame
            // 
            this.buttonBrowseGame.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowseGame.Location = new System.Drawing.Point(210, 60);
            this.buttonBrowseGame.Name = "buttonBrowseGame";
            this.buttonBrowseGame.Size = new System.Drawing.Size(45, 21);
            this.buttonBrowseGame.TabIndex = 32;
            this.buttonBrowseGame.Text = "***";
            this.buttonBrowseGame.UseVisualStyleBackColor = true;
            this.buttonBrowseGame.Click += new System.EventHandler(this.buttonBrowseGame_Click);
            // 
            // buttonThumucAuto
            // 
            this.buttonThumucAuto.ForeColor = System.Drawing.Color.Black;
            this.buttonThumucAuto.Location = new System.Drawing.Point(185, 87);
            this.buttonThumucAuto.Name = "buttonThumucAuto";
            this.buttonThumucAuto.Size = new System.Drawing.Size(70, 36);
            this.buttonThumucAuto.TabIndex = 26;
            this.buttonThumucAuto.Text = "Thư mục auto";
            this.buttonThumucAuto.UseVisualStyleBackColor = true;
            this.buttonThumucAuto.Click += new System.EventHandler(this.buttonThumucAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "2. Chọn thư mục và file game:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonToShortcut
            // 
            this.buttonToShortcut.ForeColor = System.Drawing.Color.Black;
            this.buttonToShortcut.Location = new System.Drawing.Point(4, 86);
            this.buttonToShortcut.Name = "buttonToShortcut";
            this.buttonToShortcut.Size = new System.Drawing.Size(92, 36);
            this.buttonToShortcut.TabIndex = 27;
            this.buttonToShortcut.Text = "Tạo shortcut lên desktop";
            this.buttonToShortcut.UseVisualStyleBackColor = true;
            this.buttonToShortcut.Click += new System.EventHandler(this.buttonToShortcut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 142;
            this.label6.Text = "1. Chọn web của game đang chơi";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.tabControlPhutro);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(256, 357);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Phụ trợ";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabControlPhutro
            // 
            this.tabControlPhutro.Controls.Add(this.tabPage4);
            this.tabControlPhutro.Controls.Add(this.tabPageTinsu);
            this.tabControlPhutro.Controls.Add(this.tabPageTinhLuyen);
            this.tabControlPhutro.Controls.Add(this.tabPage8);
            this.tabControlPhutro.Controls.Add(this.tabPageTest);
            this.tabControlPhutro.Location = new System.Drawing.Point(0, 0);
            this.tabControlPhutro.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlPhutro.Name = "tabControlPhutro";
            this.tabControlPhutro.SelectedIndex = 0;
            this.tabControlPhutro.Size = new System.Drawing.Size(259, 360);
            this.tabControlPhutro.TabIndex = 172;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonThoatGame);
            this.tabPage4.Controls.Add(this.buttonDoSat);
            this.tabPage4.Controls.Add(this.buttonVaotraiStopAll);
            this.tabPage4.Controls.Add(this.buttonNopLenhbaiAll);
            this.tabPage4.Controls.Add(this.buttonVaotraiStop);
            this.tabPage4.Controls.Add(this.comboBoxBentau);
            this.tabPage4.Controls.Add(this.buttonBaoToado);
            this.tabPage4.Controls.Add(this.buttonPhimTat);
            this.tabPage4.Controls.Add(this.buttonNopLenhbai);
            this.tabPage4.Controls.Add(this.buttonMoGame);
            this.tabPage4.Controls.Add(this.buttonLogin);
            this.tabPage4.Controls.Add(this.buttonDanhsachCuusat);
            this.tabPage4.Controls.Add(this.buttonAnhet);
            this.tabPage4.Controls.Add(this.comboBoxAccDoiMau);
            this.tabPage4.Controls.Add(this.buttonThoatHetgame);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.comboBoxGiamCpu);
            this.tabPage4.Controls.Add(this.buttonGiamCPUAll);
            this.tabPage4.Controls.Add(this.buttonHuongdanHLP);
            this.tabPage4.Controls.Add(this.buttonCapnhat);
            this.tabPage4.Controls.Add(this.buttonTatcaTDP);
            this.tabPage4.Controls.Add(this.checkBoxPhimTat);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(251, 334);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Chung1";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonThoatGame
            // 
            this.buttonThoatGame.ForeColor = System.Drawing.Color.Black;
            this.buttonThoatGame.Location = new System.Drawing.Point(137, 140);
            this.buttonThoatGame.Name = "buttonThoatGame";
            this.buttonThoatGame.Size = new System.Drawing.Size(44, 37);
            this.buttonThoatGame.TabIndex = 343;
            this.buttonThoatGame.Text = "Thoát";
            this.buttonThoatGame.UseVisualStyleBackColor = true;
            this.buttonThoatGame.Click += new System.EventHandler(this.buttonThoatGame_Click);
            // 
            // buttonDoSat
            // 
            this.buttonDoSat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDoSat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDoSat.ForeColor = System.Drawing.Color.DarkViolet;
            this.buttonDoSat.Location = new System.Drawing.Point(2, 1);
            this.buttonDoSat.Name = "buttonDoSat";
            this.buttonDoSat.Size = new System.Drawing.Size(75, 30);
            this.buttonDoSat.TabIndex = 341;
            this.buttonDoSat.Text = "F9 đồ sát all";
            this.buttonDoSat.UseVisualStyleBackColor = false;
            this.buttonDoSat.Click += new System.EventHandler(this.buttonDoSat_Click);
            // 
            // buttonVaotraiStopAll
            // 
            this.buttonVaotraiStopAll.ForeColor = System.Drawing.Color.Black;
            this.buttonVaotraiStopAll.Location = new System.Drawing.Point(185, 252);
            this.buttonVaotraiStopAll.Name = "buttonVaotraiStopAll";
            this.buttonVaotraiStopAll.Size = new System.Drawing.Size(65, 26);
            this.buttonVaotraiStopAll.TabIndex = 162;
            this.buttonVaotraiStopAll.Text = "Dừng hết";
            this.buttonVaotraiStopAll.UseVisualStyleBackColor = true;
            this.buttonVaotraiStopAll.Click += new System.EventHandler(this.buttonVaotraiStopAll_Click);
            // 
            // buttonNopLenhbaiAll
            // 
            this.buttonNopLenhbaiAll.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonNopLenhbaiAll.Location = new System.Drawing.Point(84, 252);
            this.buttonNopLenhbaiAll.Name = "buttonNopLenhbaiAll";
            this.buttonNopLenhbaiAll.Size = new System.Drawing.Size(97, 26);
            this.buttonNopLenhbaiAll.TabIndex = 146;
            this.buttonNopLenhbaiAll.Text = "Tất cả ac";
            this.buttonNopLenhbaiAll.UseVisualStyleBackColor = true;
            this.buttonNopLenhbaiAll.Click += new System.EventHandler(this.buttonNopLenhbaiAll_Click);
            // 
            // buttonVaotraiStop
            // 
            this.buttonVaotraiStop.ForeColor = System.Drawing.Color.Black;
            this.buttonVaotraiStop.Location = new System.Drawing.Point(185, 223);
            this.buttonVaotraiStop.Name = "buttonVaotraiStop";
            this.buttonVaotraiStop.Size = new System.Drawing.Size(65, 26);
            this.buttonVaotraiStop.TabIndex = 161;
            this.buttonVaotraiStop.Text = "Dừng";
            this.buttonVaotraiStop.UseVisualStyleBackColor = true;
            this.buttonVaotraiStop.Click += new System.EventHandler(this.buttonVaotraiStop_Click);
            // 
            // comboBoxBentau
            // 
            this.comboBoxBentau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBentau.DropDownWidth = 180;
            this.comboBoxBentau.ForeColor = System.Drawing.Color.Black;
            this.comboBoxBentau.FormattingEnabled = true;
            this.comboBoxBentau.Location = new System.Drawing.Point(84, 197);
            this.comboBoxBentau.Name = "comboBoxBentau";
            this.comboBoxBentau.Size = new System.Drawing.Size(166, 21);
            this.comboBoxBentau.TabIndex = 133;
            this.comboBoxBentau.SelectedIndexChanged += new System.EventHandler(this.comboBoxBentau_SelectedIndexChanged);
            // 
            // buttonBaoToado
            // 
            this.buttonBaoToado.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBaoToado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBaoToado.ForeColor = System.Drawing.Color.Black;
            this.buttonBaoToado.Location = new System.Drawing.Point(2, 113);
            this.buttonBaoToado.Name = "buttonBaoToado";
            this.buttonBaoToado.Size = new System.Drawing.Size(75, 30);
            this.buttonBaoToado.TabIndex = 197;
            this.buttonBaoToado.Text = "Báo tọa độ";
            this.buttonBaoToado.UseVisualStyleBackColor = false;
            this.buttonBaoToado.Click += new System.EventHandler(this.buttonBaoToado_Click);
            // 
            // buttonPhimTat
            // 
            this.buttonPhimTat.ForeColor = System.Drawing.Color.Black;
            this.buttonPhimTat.Location = new System.Drawing.Point(185, 43);
            this.buttonPhimTat.Name = "buttonPhimTat";
            this.buttonPhimTat.Size = new System.Drawing.Size(65, 23);
            this.buttonPhimTat.TabIndex = 339;
            this.buttonPhimTat.Text = "Phím tắt";
            this.buttonPhimTat.UseVisualStyleBackColor = true;
            this.buttonPhimTat.Click += new System.EventHandler(this.buttonPhimTat_Click);
            // 
            // buttonNopLenhbai
            // 
            this.buttonNopLenhbai.ForeColor = System.Drawing.Color.Black;
            this.buttonNopLenhbai.Location = new System.Drawing.Point(84, 223);
            this.buttonNopLenhbai.Name = "buttonNopLenhbai";
            this.buttonNopLenhbai.Size = new System.Drawing.Size(97, 26);
            this.buttonNopLenhbai.TabIndex = 144;
            this.buttonNopLenhbai.Text = "Thực hiện lệnh";
            this.buttonNopLenhbai.UseVisualStyleBackColor = true;
            this.buttonNopLenhbai.Click += new System.EventHandler(this.buttonNopLenhbai_Click);
            // 
            // buttonMoGame
            // 
            this.buttonMoGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMoGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMoGame.ForeColor = System.Drawing.Color.Black;
            this.buttonMoGame.Location = new System.Drawing.Point(2, 270);
            this.buttonMoGame.Name = "buttonMoGame";
            this.buttonMoGame.Size = new System.Drawing.Size(75, 30);
            this.buttonMoGame.TabIndex = 197;
            this.buttonMoGame.Text = "Mở game";
            this.buttonMoGame.UseVisualStyleBackColor = false;
            this.buttonMoGame.Click += new System.EventHandler(this.buttonMoGame_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonLogin.Location = new System.Drawing.Point(2, 302);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 30);
            this.buttonLogin.TabIndex = 138;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonDanhsachCuusat
            // 
            this.buttonDanhsachCuusat.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDanhsachCuusat.ForeColor = System.Drawing.Color.DarkViolet;
            this.buttonDanhsachCuusat.Location = new System.Drawing.Point(2, 34);
            this.buttonDanhsachCuusat.Name = "buttonDanhsachCuusat";
            this.buttonDanhsachCuusat.Size = new System.Drawing.Size(75, 30);
            this.buttonDanhsachCuusat.TabIndex = 319;
            this.buttonDanhsachCuusat.Text = "Cừu sát";
            this.buttonDanhsachCuusat.UseVisualStyleBackColor = false;
            this.buttonDanhsachCuusat.Click += new System.EventHandler(this.buttonDanhsachCuusat_Click);
            // 
            // buttonAnhet
            // 
            this.buttonAnhet.ForeColor = System.Drawing.Color.Black;
            this.buttonAnhet.Location = new System.Drawing.Point(84, 140);
            this.buttonAnhet.Name = "buttonAnhet";
            this.buttonAnhet.Size = new System.Drawing.Size(50, 37);
            this.buttonAnhet.TabIndex = 198;
            this.buttonAnhet.Text = "Ẩn hết game";
            this.buttonAnhet.UseVisualStyleBackColor = true;
            this.buttonAnhet.Click += new System.EventHandler(this.buttonAnhet_Click);
            // 
            // comboBoxAccDoiMau
            // 
            this.comboBoxAccDoiMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccDoiMau.DropDownWidth = 110;
            this.comboBoxAccDoiMau.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAccDoiMau.FormattingEnabled = true;
            this.comboBoxAccDoiMau.Location = new System.Drawing.Point(84, 308);
            this.comboBoxAccDoiMau.Name = "comboBoxAccDoiMau";
            this.comboBoxAccDoiMau.Size = new System.Drawing.Size(166, 21);
            this.comboBoxAccDoiMau.TabIndex = 133;
            this.comboBoxAccDoiMau.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccDoiMau_SelectedIndexChanged);
            this.comboBoxAccDoiMau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxAccDoiMau_MouseDown);
            // 
            // buttonThoatHetgame
            // 
            this.buttonThoatHetgame.ForeColor = System.Drawing.Color.Black;
            this.buttonThoatHetgame.Location = new System.Drawing.Point(185, 140);
            this.buttonThoatHetgame.Name = "buttonThoatHetgame";
            this.buttonThoatHetgame.Size = new System.Drawing.Size(65, 37);
            this.buttonThoatHetgame.TabIndex = 202;
            this.buttonThoatHetgame.Text = "Thoát hết";
            this.buttonThoatHetgame.UseVisualStyleBackColor = true;
            this.buttonThoatHetgame.Click += new System.EventHandler(this.buttonThoatHetgame_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(81, 290);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(166, 13);
            this.label29.TabIndex = 201;
            this.label29.Text = "Đổi màu bang (3 nút VXT bảng 1)";
            // 
            // comboBoxGiamCpu
            // 
            this.comboBoxGiamCpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGiamCpu.DropDownWidth = 230;
            this.comboBoxGiamCpu.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGiamCpu.FormattingEnabled = true;
            this.comboBoxGiamCpu.Location = new System.Drawing.Point(84, 80);
            this.comboBoxGiamCpu.Name = "comboBoxGiamCpu";
            this.comboBoxGiamCpu.Size = new System.Drawing.Size(166, 21);
            this.comboBoxGiamCpu.TabIndex = 199;
            this.comboBoxGiamCpu.SelectedIndexChanged += new System.EventHandler(this.comboBoxGiamCpu_SelectedIndexChanged);
            // 
            // buttonGiamCPUAll
            // 
            this.buttonGiamCPUAll.ForeColor = System.Drawing.Color.Black;
            this.buttonGiamCPUAll.Location = new System.Drawing.Point(84, 107);
            this.buttonGiamCPUAll.Name = "buttonGiamCPUAll";
            this.buttonGiamCPUAll.Size = new System.Drawing.Size(166, 26);
            this.buttonGiamCPUAll.TabIndex = 200;
            this.buttonGiamCPUAll.Text = "Áp dụng tất cả ac (phím F10)";
            this.buttonGiamCPUAll.UseVisualStyleBackColor = true;
            this.buttonGiamCPUAll.Click += new System.EventHandler(this.buttonGiamCPUAll_Click);
            // 
            // buttonHuongdanHLP
            // 
            this.buttonHuongdanHLP.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonHuongdanHLP.Location = new System.Drawing.Point(84, 1);
            this.buttonHuongdanHLP.Name = "buttonHuongdanHLP";
            this.buttonHuongdanHLP.Size = new System.Drawing.Size(97, 36);
            this.buttonHuongdanHLP.TabIndex = 171;
            this.buttonHuongdanHLP.Text = "Phim hướng dẫn chung";
            this.buttonHuongdanHLP.UseVisualStyleBackColor = true;
            this.buttonHuongdanHLP.Click += new System.EventHandler(this.buttonHuongdanHLP_Click);
            // 
            // buttonCapnhat
            // 
            this.buttonCapnhat.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonCapnhat.Location = new System.Drawing.Point(185, 1);
            this.buttonCapnhat.Name = "buttonCapnhat";
            this.buttonCapnhat.Size = new System.Drawing.Size(65, 36);
            this.buttonCapnhat.TabIndex = 136;
            this.buttonCapnhat.Text = "Cập nhật auto";
            this.buttonCapnhat.UseVisualStyleBackColor = true;
            this.buttonCapnhat.Click += new System.EventHandler(this.buttonCapnhat_Click);
            // 
            // buttonTatcaTDP
            // 
            this.buttonTatcaTDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTatcaTDP.ForeColor = System.Drawing.Color.Black;
            this.buttonTatcaTDP.Location = new System.Drawing.Point(2, 80);
            this.buttonTatcaTDP.Name = "buttonTatcaTDP";
            this.buttonTatcaTDP.Size = new System.Drawing.Size(75, 30);
            this.buttonTatcaTDP.TabIndex = 191;
            this.buttonTatcaTDP.Text = "Tất cả TĐP";
            this.buttonTatcaTDP.UseVisualStyleBackColor = true;
            this.buttonTatcaTDP.Click += new System.EventHandler(this.buttonTatcaTDP_Click);
            // 
            // checkBoxPhimTat
            // 
            this.checkBoxPhimTat.AutoSize = true;
            this.checkBoxPhimTat.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxPhimTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPhimTat.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxPhimTat.Location = new System.Drawing.Point(84, 47);
            this.checkBoxPhimTat.Name = "checkBoxPhimTat";
            this.checkBoxPhimTat.Size = new System.Drawing.Size(85, 17);
            this.checkBoxPhimTat.TabIndex = 154;
            this.checkBoxPhimTat.Text = "Phím tắt >";
            this.checkBoxPhimTat.UseVisualStyleBackColor = true;
            this.checkBoxPhimTat.CheckedChanged += new System.EventHandler(this.checkBoxPhimTat_CheckedChanged);
            // 
            // tabPageTinsu
            // 
            this.tabPageTinsu.Controls.Add(this.buttonDocCauhinh);
            this.tabPageTinsu.Controls.Add(this.buttonHuyenTinh);
            this.tabPageTinsu.Controls.Add(this.buttonRaovat);
            this.tabPageTinsu.Controls.Add(this.checkBoxAceptBH);
            this.tabPageTinsu.Controls.Add(this.buttonLuuCauhinhAll);
            this.tabPageTinsu.Controls.Add(this.groupBox6);
            this.tabPageTinsu.Controls.Add(this.groupBox4);
            this.tabPageTinsu.Location = new System.Drawing.Point(4, 22);
            this.tabPageTinsu.Name = "tabPageTinsu";
            this.tabPageTinsu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTinsu.Size = new System.Drawing.Size(251, 334);
            this.tabPageTinsu.TabIndex = 1;
            this.tabPageTinsu.Text = "Chung2";
            this.tabPageTinsu.UseVisualStyleBackColor = true;
            // 
            // buttonDocCauhinh
            // 
            this.buttonDocCauhinh.ForeColor = System.Drawing.Color.Black;
            this.buttonDocCauhinh.Location = new System.Drawing.Point(170, 252);
            this.buttonDocCauhinh.Name = "buttonDocCauhinh";
            this.buttonDocCauhinh.Size = new System.Drawing.Size(70, 38);
            this.buttonDocCauhinh.TabIndex = 340;
            this.buttonDocCauhinh.Text = "Đọc cấu hình ac";
            this.buttonDocCauhinh.UseVisualStyleBackColor = true;
            this.buttonDocCauhinh.Click += new System.EventHandler(this.buttonDocCauhinh_Click);
            // 
            // buttonHuyenTinh
            // 
            this.buttonHuyenTinh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonHuyenTinh.ForeColor = System.Drawing.Color.Black;
            this.buttonHuyenTinh.Location = new System.Drawing.Point(9, 296);
            this.buttonHuyenTinh.Name = "buttonHuyenTinh";
            this.buttonHuyenTinh.Size = new System.Drawing.Size(80, 38);
            this.buttonHuyenTinh.TabIndex = 204;
            this.buttonHuyenTinh.Text = "Chể tạo Huyền tinh";
            this.buttonHuyenTinh.UseVisualStyleBackColor = false;
            this.buttonHuyenTinh.Click += new System.EventHandler(this.buttonHuyenTinh_Click);
            // 
            // buttonRaovat
            // 
            this.buttonRaovat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRaovat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRaovat.ForeColor = System.Drawing.Color.Black;
            this.buttonRaovat.Location = new System.Drawing.Point(92, 295);
            this.buttonRaovat.Name = "buttonRaovat";
            this.buttonRaovat.Size = new System.Drawing.Size(75, 38);
            this.buttonRaovat.TabIndex = 344;
            this.buttonRaovat.Text = "Rao vặt";
            this.buttonRaovat.UseVisualStyleBackColor = false;
            this.buttonRaovat.Click += new System.EventHandler(this.buttonRaovat_Click);
            // 
            // checkBoxAceptBH
            // 
            this.checkBoxAceptBH.Location = new System.Drawing.Point(3, 249);
            this.checkBoxAceptBH.Name = "checkBoxAceptBH";
            this.checkBoxAceptBH.Size = new System.Drawing.Size(157, 37);
            this.checkBoxAceptBH.TabIndex = 0;
            this.checkBoxAceptBH.Text = "Tự động cho ac vào bang (đội trưởng trở lên)";
            this.checkBoxAceptBH.UseVisualStyleBackColor = true;
            this.checkBoxAceptBH.CheckedChanged += new System.EventHandler(this.checkBoxAceptBH_CheckedChanged);
            // 
            // buttonLuuCauhinhAll
            // 
            this.buttonLuuCauhinhAll.ForeColor = System.Drawing.Color.Black;
            this.buttonLuuCauhinhAll.Location = new System.Drawing.Point(170, 295);
            this.buttonLuuCauhinhAll.Name = "buttonLuuCauhinhAll";
            this.buttonLuuCauhinhAll.Size = new System.Drawing.Size(70, 38);
            this.buttonLuuCauhinhAll.TabIndex = 320;
            this.buttonLuuCauhinhAll.Text = "Lưu cấu hình";
            this.buttonLuuCauhinhAll.UseVisualStyleBackColor = true;
            this.buttonLuuCauhinhAll.Click += new System.EventHandler(this.buttonLuuCauhinhAll_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.linkLabelHelpTinsu);
            this.groupBox6.Controls.Add(this.textBoxTimerPT);
            this.groupBox6.Controls.Add(this.checkBoxChoPTdanhsach);
            this.groupBox6.Controls.Add(this.buttonToadoPK);
            this.groupBox6.Controls.Add(this.checkBoxChayPKNguoidung);
            this.groupBox6.Controls.Add(this.checkBoxChaydanhvong);
            this.groupBox6.Controls.Add(this.buttonTinsuAll);
            this.groupBox6.Controls.Add(this.checkBoxChayTinsu);
            this.groupBox6.Controls.Add(this.comboBoxTinSu);
            this.groupBox6.Controls.Add(this.checkBoxMuathuocPK);
            this.groupBox6.Location = new System.Drawing.Point(1, 124);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(248, 122);
            this.groupBox6.TabIndex = 205;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chạy Tín sứ";
            // 
            // linkLabelHelpTinsu
            // 
            this.linkLabelHelpTinsu.AutoSize = true;
            this.linkLabelHelpTinsu.Location = new System.Drawing.Point(7, 45);
            this.linkLabelHelpTinsu.Name = "linkLabelHelpTinsu";
            this.linkLabelHelpTinsu.Size = new System.Drawing.Size(60, 13);
            this.linkLabelHelpTinsu.TabIndex = 207;
            this.linkLabelHelpTinsu.TabStop = true;
            this.linkLabelHelpTinsu.Text = "Hướng dẫn";
            this.linkLabelHelpTinsu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelpTinsu_LinkClicked);
            // 
            // textBoxTimerPT
            // 
            this.textBoxTimerPT.ForeColor = System.Drawing.Color.DarkRed;
            this.textBoxTimerPT.Location = new System.Drawing.Point(210, 14);
            this.textBoxTimerPT.Name = "textBoxTimerPT";
            this.textBoxTimerPT.Size = new System.Drawing.Size(30, 20);
            this.textBoxTimerPT.TabIndex = 206;
            this.textBoxTimerPT.TextChanged += new System.EventHandler(this.textBoxTimerPT_TextChanged);
            // 
            // checkBoxChoPTdanhsach
            // 
            this.checkBoxChoPTdanhsach.AutoSize = true;
            this.checkBoxChoPTdanhsach.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxChoPTdanhsach.Location = new System.Drawing.Point(116, 15);
            this.checkBoxChoPTdanhsach.Name = "checkBoxChoPTdanhsach";
            this.checkBoxChoPTdanhsach.Size = new System.Drawing.Size(92, 17);
            this.checkBoxChoPTdanhsach.TabIndex = 204;
            this.checkBoxChoPTdanhsach.Text = "Chờ đủ PT (s)";
            this.checkBoxChoPTdanhsach.UseVisualStyleBackColor = true;
            this.checkBoxChoPTdanhsach.CheckedChanged += new System.EventHandler(this.checkBoxChoPTdanhsach_CheckedChanged);
            // 
            // buttonToadoPK
            // 
            this.buttonToadoPK.Location = new System.Drawing.Point(170, 60);
            this.buttonToadoPK.Name = "buttonToadoPK";
            this.buttonToadoPK.Size = new System.Drawing.Size(70, 21);
            this.buttonToadoPK.TabIndex = 7;
            this.buttonToadoPK.Text = "theo t. độ";
            this.buttonToadoPK.UseVisualStyleBackColor = true;
            this.buttonToadoPK.Click += new System.EventHandler(this.buttonToadoPK_Click);
            // 
            // checkBoxChayPKNguoidung
            // 
            this.checkBoxChayPKNguoidung.AutoSize = true;
            this.checkBoxChayPKNguoidung.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChayPKNguoidung.Location = new System.Drawing.Point(116, 63);
            this.checkBoxChayPKNguoidung.Name = "checkBoxChayPKNguoidung";
            this.checkBoxChayPKNguoidung.Size = new System.Drawing.Size(50, 17);
            this.checkBoxChayPKNguoidung.TabIndex = 6;
            this.checkBoxChayPKNguoidung.Text = "Chạy";
            this.checkBoxChayPKNguoidung.UseVisualStyleBackColor = true;
            this.checkBoxChayPKNguoidung.CheckedChanged += new System.EventHandler(this.checkBoxChayPKNguoidung_CheckedChanged);
            // 
            // checkBoxChaydanhvong
            // 
            this.checkBoxChaydanhvong.AutoSize = true;
            this.checkBoxChaydanhvong.Location = new System.Drawing.Point(116, 40);
            this.checkBoxChaydanhvong.Name = "checkBoxChaydanhvong";
            this.checkBoxChaydanhvong.Size = new System.Drawing.Size(121, 17);
            this.checkBoxChaydanhvong.TabIndex = 1;
            this.checkBoxChaydanhvong.Text = "Chỉ chạy danh vọng";
            this.checkBoxChaydanhvong.UseVisualStyleBackColor = true;
            this.checkBoxChaydanhvong.CheckedChanged += new System.EventHandler(this.checkBoxChaydanhvong_CheckedChanged);
            // 
            // buttonTinsuAll
            // 
            this.buttonTinsuAll.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonTinsuAll.Location = new System.Drawing.Point(116, 89);
            this.buttonTinsuAll.Name = "buttonTinsuAll";
            this.buttonTinsuAll.Size = new System.Drawing.Size(124, 26);
            this.buttonTinsuAll.TabIndex = 203;
            this.buttonTinsuAll.Text = "Áp dụng tất cả ac";
            this.buttonTinsuAll.UseVisualStyleBackColor = true;
            this.buttonTinsuAll.Click += new System.EventHandler(this.buttonTinsuAll_Click);
            // 
            // checkBoxChayTinsu
            // 
            this.checkBoxChayTinsu.AutoSize = true;
            this.checkBoxChayTinsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChayTinsu.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChayTinsu.Location = new System.Drawing.Point(10, 95);
            this.checkBoxChayTinsu.Name = "checkBoxChayTinsu";
            this.checkBoxChayTinsu.Size = new System.Drawing.Size(102, 17);
            this.checkBoxChayTinsu.TabIndex = 7;
            this.checkBoxChayTinsu.Text = "Bắt đầu chạy";
            this.checkBoxChayTinsu.UseVisualStyleBackColor = true;
            this.checkBoxChayTinsu.CheckedChanged += new System.EventHandler(this.checkBoxChayTinsu_CheckedChanged);
            // 
            // comboBoxTinSu
            // 
            this.comboBoxTinSu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTinSu.DropDownWidth = 80;
            this.comboBoxTinSu.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTinSu.FormattingEnabled = true;
            this.comboBoxTinSu.Location = new System.Drawing.Point(10, 21);
            this.comboBoxTinSu.Name = "comboBoxTinSu";
            this.comboBoxTinSu.Size = new System.Drawing.Size(99, 21);
            this.comboBoxTinSu.TabIndex = 163;
            this.comboBoxTinSu.SelectedIndexChanged += new System.EventHandler(this.comboBoxTinSu_SelectedIndexChanged);
            // 
            // checkBoxMuathuocPK
            // 
            this.checkBoxMuathuocPK.AutoSize = true;
            this.checkBoxMuathuocPK.Location = new System.Drawing.Point(10, 69);
            this.checkBoxMuathuocPK.Name = "checkBoxMuathuocPK";
            this.checkBoxMuathuocPK.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMuathuocPK.TabIndex = 2;
            this.checkBoxMuathuocPK.Text = "Có mua thuốc";
            this.checkBoxMuathuocPK.UseVisualStyleBackColor = true;
            this.checkBoxMuathuocPK.CheckedChanged += new System.EventHandler(this.checkBoxMuathuocPK_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxPhamviNhatqua);
            this.groupBox4.Controls.Add(this.buttonStopNhatqua);
            this.groupBox4.Controls.Add(this.numericUpDownHH);
            this.groupBox4.Controls.Add(this.buttonNhatquaAll);
            this.groupBox4.Controls.Add(this.checkBoxNhatqua);
            this.groupBox4.Controls.Add(this.numericUpDownSS);
            this.groupBox4.Controls.Add(this.checkBoxGioClick);
            this.groupBox4.Controls.Add(this.numericUpDownMM);
            this.groupBox4.Location = new System.Drawing.Point(1, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 115);
            this.groupBox4.TabIndex = 203;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhặt quả Hoàng Kim và Huy Hoàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 205;
            this.label7.Text = "Phạm vi nhặt";
            // 
            // textBoxPhamviNhatqua
            // 
            this.textBoxPhamviNhatqua.Location = new System.Drawing.Point(198, 49);
            this.textBoxPhamviNhatqua.Name = "textBoxPhamviNhatqua";
            this.textBoxPhamviNhatqua.Size = new System.Drawing.Size(42, 20);
            this.textBoxPhamviNhatqua.TabIndex = 204;
            this.textBoxPhamviNhatqua.TextChanged += new System.EventHandler(this.textBoxPhamviNhatqua_TextChanged);
            // 
            // buttonStopNhatqua
            // 
            this.buttonStopNhatqua.Location = new System.Drawing.Point(116, 75);
            this.buttonStopNhatqua.Name = "buttonStopNhatqua";
            this.buttonStopNhatqua.Size = new System.Drawing.Size(124, 26);
            this.buttonStopNhatqua.TabIndex = 203;
            this.buttonStopNhatqua.Text = "Dừng tất cả ac";
            this.buttonStopNhatqua.UseVisualStyleBackColor = true;
            this.buttonStopNhatqua.Click += new System.EventHandler(this.buttonStopNhatqua_Click);
            // 
            // numericUpDownHH
            // 
            this.numericUpDownHH.Location = new System.Drawing.Point(116, 22);
            this.numericUpDownHH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHH.Name = "numericUpDownHH";
            this.numericUpDownHH.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownHH.TabIndex = 176;
            this.numericUpDownHH.ValueChanged += new System.EventHandler(this.numericUpDownHH_ValueChanged);
            // 
            // buttonNhatquaAll
            // 
            this.buttonNhatquaAll.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonNhatquaAll.Location = new System.Drawing.Point(10, 75);
            this.buttonNhatquaAll.Name = "buttonNhatquaAll";
            this.buttonNhatquaAll.Size = new System.Drawing.Size(99, 26);
            this.buttonNhatquaAll.TabIndex = 202;
            this.buttonNhatquaAll.Text = "Áp dụng tất cả";
            this.buttonNhatquaAll.UseVisualStyleBackColor = true;
            this.buttonNhatquaAll.Click += new System.EventHandler(this.buttonNhatquaAll_Click);
            // 
            // checkBoxNhatqua
            // 
            this.checkBoxNhatqua.AutoSize = true;
            this.checkBoxNhatqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNhatqua.Location = new System.Drawing.Point(10, 50);
            this.checkBoxNhatqua.Name = "checkBoxNhatqua";
            this.checkBoxNhatqua.Size = new System.Drawing.Size(100, 17);
            this.checkBoxNhatqua.TabIndex = 183;
            this.checkBoxNhatqua.Text = "Bắt đầu nhặt";
            this.checkBoxNhatqua.UseVisualStyleBackColor = true;
            this.checkBoxNhatqua.CheckedChanged += new System.EventHandler(this.checkBoxNhatqua_CheckedChanged);
            // 
            // numericUpDownSS
            // 
            this.numericUpDownSS.Location = new System.Drawing.Point(200, 22);
            this.numericUpDownSS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSS.Name = "numericUpDownSS";
            this.numericUpDownSS.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSS.TabIndex = 178;
            this.numericUpDownSS.ValueChanged += new System.EventHandler(this.numericUpDownSS_ValueChanged);
            // 
            // checkBoxGioClick
            // 
            this.checkBoxGioClick.AutoSize = true;
            this.checkBoxGioClick.ForeColor = System.Drawing.Color.Black;
            this.checkBoxGioClick.Location = new System.Drawing.Point(10, 24);
            this.checkBoxGioClick.Name = "checkBoxGioClick";
            this.checkBoxGioClick.Size = new System.Drawing.Size(102, 17);
            this.checkBoxGioClick.TabIndex = 175;
            this.checkBoxGioClick.Text = "Nhặt lúc (H:m:s)";
            this.checkBoxGioClick.UseVisualStyleBackColor = true;
            this.checkBoxGioClick.CheckedChanged += new System.EventHandler(this.checkBoxGioClick_CheckedChanged);
            // 
            // numericUpDownMM
            // 
            this.numericUpDownMM.Location = new System.Drawing.Point(158, 22);
            this.numericUpDownMM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMM.Name = "numericUpDownMM";
            this.numericUpDownMM.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownMM.TabIndex = 177;
            this.numericUpDownMM.ValueChanged += new System.EventHandler(this.numericUpDownMM_ValueChanged);
            // 
            // tabPageTinhLuyen
            // 
            this.tabPageTinhLuyen.Controls.Add(this.groupBox7);
            this.tabPageTinhLuyen.Controls.Add(this.tabControlLoc);
            this.tabPageTinhLuyen.Location = new System.Drawing.Point(4, 22);
            this.tabPageTinhLuyen.Name = "tabPageTinhLuyen";
            this.tabPageTinhLuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTinhLuyen.Size = new System.Drawing.Size(251, 334);
            this.tabPageTinhLuyen.TabIndex = 3;
            this.tabPageTinhLuyen.Text = "Event";
            this.tabPageTinhLuyen.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonClickNpcStopAll);
            this.groupBox7.Controls.Add(this.textBoxNhapSoluongClickNPC);
            this.groupBox7.Controls.Add(this.buttonClickNpcAll);
            this.groupBox7.Controls.Add(this.textBoxClickNPCSolan);
            this.groupBox7.Controls.Add(this.buttonClickNpcSingle);
            this.groupBox7.Controls.Add(this.buttonHelpClickNpc);
            this.groupBox7.Controls.Add(this.textBoxClickNPCMenu);
            this.groupBox7.Controls.Add(this.comboBoxClickNPC);
            this.groupBox7.Controls.Add(this.textBoxClickNPCTocdo);
            this.groupBox7.Controls.Add(this.checkBoxClickNPCmenu);
            this.groupBox7.Controls.Add(this.buttonThietlapClickNpc);
            this.groupBox7.Controls.Add(this.checkBoxNPC);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.checkBoxClickNPCSolan);
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 142);
            this.groupBox7.TabIndex = 176;
            this.groupBox7.TabStop = false;
            // 
            // buttonClickNpcStopAll
            // 
            this.buttonClickNpcStopAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClickNpcStopAll.ForeColor = System.Drawing.Color.Black;
            this.buttonClickNpcStopAll.Location = new System.Drawing.Point(8, 112);
            this.buttonClickNpcStopAll.Name = "buttonClickNpcStopAll";
            this.buttonClickNpcStopAll.Size = new System.Drawing.Size(80, 21);
            this.buttonClickNpcStopAll.TabIndex = 346;
            this.buttonClickNpcStopAll.Text = "Tất cả dừng";
            this.buttonClickNpcStopAll.UseVisualStyleBackColor = true;
            this.buttonClickNpcStopAll.Click += new System.EventHandler(this.buttonClickNpcStopAll_Click);
            // 
            // textBoxNhapSoluongClickNPC
            // 
            this.textBoxNhapSoluongClickNPC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNhapSoluongClickNPC.ForeColor = System.Drawing.Color.Black;
            this.textBoxNhapSoluongClickNPC.Location = new System.Drawing.Point(214, 85);
            this.textBoxNhapSoluongClickNPC.Name = "textBoxNhapSoluongClickNPC";
            this.textBoxNhapSoluongClickNPC.Size = new System.Drawing.Size(30, 13);
            this.textBoxNhapSoluongClickNPC.TabIndex = 197;
            this.textBoxNhapSoluongClickNPC.TextChanged += new System.EventHandler(this.textBoxNhapSoluongClickNPC_TextChanged);
            // 
            // buttonClickNpcAll
            // 
            this.buttonClickNpcAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClickNpcAll.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonClickNpcAll.Location = new System.Drawing.Point(8, 83);
            this.buttonClickNpcAll.Name = "buttonClickNpcAll";
            this.buttonClickNpcAll.Size = new System.Drawing.Size(80, 21);
            this.buttonClickNpcAll.TabIndex = 345;
            this.buttonClickNpcAll.Text = "Tất cả chạy";
            this.buttonClickNpcAll.UseVisualStyleBackColor = true;
            this.buttonClickNpcAll.Click += new System.EventHandler(this.buttonClickNpcAll_Click);
            // 
            // textBoxClickNPCSolan
            // 
            this.textBoxClickNPCSolan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClickNPCSolan.ForeColor = System.Drawing.Color.Black;
            this.textBoxClickNPCSolan.Location = new System.Drawing.Point(214, 64);
            this.textBoxClickNPCSolan.Name = "textBoxClickNPCSolan";
            this.textBoxClickNPCSolan.Size = new System.Drawing.Size(30, 13);
            this.textBoxClickNPCSolan.TabIndex = 171;
            this.textBoxClickNPCSolan.TextChanged += new System.EventHandler(this.textBoxClickNPCSolan_TextChanged);
            // 
            // buttonClickNpcSingle
            // 
            this.buttonClickNpcSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClickNpcSingle.ForeColor = System.Drawing.Color.Black;
            this.buttonClickNpcSingle.Location = new System.Drawing.Point(8, 60);
            this.buttonClickNpcSingle.Name = "buttonClickNpcSingle";
            this.buttonClickNpcSingle.Size = new System.Drawing.Size(80, 21);
            this.buttonClickNpcSingle.TabIndex = 344;
            this.buttonClickNpcSingle.Text = "Chạy";
            this.buttonClickNpcSingle.UseVisualStyleBackColor = true;
            this.buttonClickNpcSingle.Click += new System.EventHandler(this.buttonClickNpcSingle_Click);
            // 
            // buttonHelpClickNpc
            // 
            this.buttonHelpClickNpc.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonHelpClickNpc.Location = new System.Drawing.Point(190, 112);
            this.buttonHelpClickNpc.Name = "buttonHelpClickNpc";
            this.buttonHelpClickNpc.Size = new System.Drawing.Size(55, 21);
            this.buttonHelpClickNpc.TabIndex = 215;
            this.buttonHelpClickNpc.Text = "H.dẫn";
            this.buttonHelpClickNpc.UseVisualStyleBackColor = true;
            this.buttonHelpClickNpc.Click += new System.EventHandler(this.buttonHelpClickNpc_Click);
            // 
            // textBoxClickNPCMenu
            // 
            this.textBoxClickNPCMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClickNPCMenu.ForeColor = System.Drawing.Color.Black;
            this.textBoxClickNPCMenu.Location = new System.Drawing.Point(179, 39);
            this.textBoxClickNPCMenu.Name = "textBoxClickNPCMenu";
            this.textBoxClickNPCMenu.Size = new System.Drawing.Size(66, 13);
            this.textBoxClickNPCMenu.TabIndex = 162;
            this.textBoxClickNPCMenu.TextChanged += new System.EventHandler(this.textBoxClickNPCMenu_TextChanged);
            // 
            // comboBoxClickNPC
            // 
            this.comboBoxClickNPC.DropDownWidth = 150;
            this.comboBoxClickNPC.ForeColor = System.Drawing.Color.Black;
            this.comboBoxClickNPC.FormattingEnabled = true;
            this.comboBoxClickNPC.Location = new System.Drawing.Point(60, 12);
            this.comboBoxClickNPC.Name = "comboBoxClickNPC";
            this.comboBoxClickNPC.Size = new System.Drawing.Size(110, 21);
            this.comboBoxClickNPC.TabIndex = 164;
            this.comboBoxClickNPC.SelectedIndexChanged += new System.EventHandler(this.comboBoxClickNPC_SelectedIndexChanged);
            this.comboBoxClickNPC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxClickNPC_MouseDown);
            // 
            // textBoxClickNPCTocdo
            // 
            this.textBoxClickNPCTocdo.ForeColor = System.Drawing.Color.Black;
            this.textBoxClickNPCTocdo.Location = new System.Drawing.Point(215, 13);
            this.textBoxClickNPCTocdo.Name = "textBoxClickNPCTocdo";
            this.textBoxClickNPCTocdo.Size = new System.Drawing.Size(31, 20);
            this.textBoxClickNPCTocdo.TabIndex = 173;
            this.textBoxClickNPCTocdo.TextChanged += new System.EventHandler(this.textBoxClickNPCTocdo_TextChanged);
            // 
            // checkBoxClickNPCmenu
            // 
            this.checkBoxClickNPCmenu.AutoSize = true;
            this.checkBoxClickNPCmenu.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxClickNPCmenu.Location = new System.Drawing.Point(8, 37);
            this.checkBoxClickNPCmenu.Name = "checkBoxClickNPCmenu";
            this.checkBoxClickNPCmenu.Size = new System.Drawing.Size(154, 17);
            this.checkBoxClickNPCmenu.TabIndex = 165;
            this.checkBoxClickNPCmenu.Text = "Có click vào menu hiện lên";
            this.checkBoxClickNPCmenu.UseVisualStyleBackColor = false;
            this.checkBoxClickNPCmenu.CheckedChanged += new System.EventHandler(this.checkBoxClickNPCmenu_CheckedChanged);
            // 
            // buttonThietlapClickNpc
            // 
            this.buttonThietlapClickNpc.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonThietlapClickNpc.Location = new System.Drawing.Point(95, 112);
            this.buttonThietlapClickNpc.Name = "buttonThietlapClickNpc";
            this.buttonThietlapClickNpc.Size = new System.Drawing.Size(90, 21);
            this.buttonThietlapClickNpc.TabIndex = 193;
            this.buttonThietlapClickNpc.Text = "Lập điều kiện";
            this.buttonThietlapClickNpc.UseVisualStyleBackColor = true;
            this.buttonThietlapClickNpc.Click += new System.EventHandler(this.buttonThietlapClickNpc_Click);
            // 
            // checkBoxNPC
            // 
            this.checkBoxNPC.AutoSize = true;
            this.checkBoxNPC.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxNPC.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxNPC.Location = new System.Drawing.Point(8, 15);
            this.checkBoxNPC.Name = "checkBoxNPC";
            this.checkBoxNPC.Size = new System.Drawing.Size(48, 17);
            this.checkBoxNPC.TabIndex = 194;
            this.checkBoxNPC.Text = "NPC";
            this.checkBoxNPC.UseVisualStyleBackColor = false;
            this.checkBoxNPC.CheckedChanged += new System.EventHandler(this.checkBoxNPC_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 187;
            this.label2.Text = "Tốc độ";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(118, 85);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(85, 13);
            this.label41.TabIndex = 196;
            this.label41.Text = "Số lượng nếu có";
            // 
            // checkBoxClickNPCSolan
            // 
            this.checkBoxClickNPCSolan.AutoSize = true;
            this.checkBoxClickNPCSolan.Location = new System.Drawing.Point(95, 63);
            this.checkBoxClickNPCSolan.Name = "checkBoxClickNPCSolan";
            this.checkBoxClickNPCSolan.Size = new System.Drawing.Size(104, 17);
            this.checkBoxClickNPCSolan.TabIndex = 170;
            this.checkBoxClickNPCSolan.Text = "Số lần click Npc";
            this.checkBoxClickNPCSolan.UseVisualStyleBackColor = true;
            this.checkBoxClickNPCSolan.CheckedChanged += new System.EventHandler(this.checkBoxClickNPCSolan_CheckedChanged);
            // 
            // tabControlLoc
            // 
            this.tabControlLoc.Controls.Add(this.tabPage10);
            this.tabControlLoc.Controls.Add(this.tabPage15);
            this.tabControlLoc.Controls.Add(this.tabPage3);
            this.tabControlLoc.Controls.Add(this.tabPage12);
            this.tabControlLoc.Location = new System.Drawing.Point(1, 145);
            this.tabControlLoc.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlLoc.Name = "tabControlLoc";
            this.tabControlLoc.SelectedIndex = 0;
            this.tabControlLoc.Size = new System.Drawing.Size(255, 192);
            this.tabControlLoc.TabIndex = 175;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.buttonMuaSudungAll);
            this.tabPage10.Controls.Add(this.buttonMuaGopAll);
            this.tabPage10.Controls.Add(this.textBoxMuadungSoLuong);
            this.tabPage10.Controls.Add(this.textBoxIdMua);
            this.tabPage10.Controls.Add(this.labelMuaGopStopAll);
            this.tabPage10.Controls.Add(this.labelMuaGopStop);
            this.tabPage10.Controls.Add(this.labelMuaSudung);
            this.tabPage10.Controls.Add(this.labelMuaGopStart);
            this.tabPage10.Controls.Add(this.linkLabelPhimCauca);
            this.tabPage10.Controls.Add(this.checkBoxThanhTruotSudung);
            this.tabPage10.Controls.Add(this.buttonHelpMua);
            this.tabPage10.Controls.Add(this.checkBoxBoquaMaKTC);
            this.tabPage10.Controls.Add(this.checkBoxMuaDungSoluong);
            this.tabPage10.Controls.Add(this.comboBoxMuaVatpham);
            this.tabPage10.Controls.Add(this.label16);
            this.tabPage10.Controls.Add(this.checkBoxGopVatpham);
            this.tabPage10.Controls.Add(this.checkBoxMuaKytrancac);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(247, 166);
            this.tabPage10.TabIndex = 2;
            this.tabPage10.Text = "Mua dùng";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // buttonMuaSudungAll
            // 
            this.buttonMuaSudungAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMuaSudungAll.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonMuaSudungAll.Location = new System.Drawing.Point(86, 143);
            this.buttonMuaSudungAll.Name = "buttonMuaSudungAll";
            this.buttonMuaSudungAll.Size = new System.Drawing.Size(100, 21);
            this.buttonMuaSudungAll.TabIndex = 348;
            this.buttonMuaSudungAll.Text = "Tất cả sử dụng";
            this.buttonMuaSudungAll.UseVisualStyleBackColor = true;
            this.buttonMuaSudungAll.Click += new System.EventHandler(this.buttonMuaSudungAll_Click);
            // 
            // buttonMuaGopAll
            // 
            this.buttonMuaGopAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMuaGopAll.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonMuaGopAll.Location = new System.Drawing.Point(3, 143);
            this.buttonMuaGopAll.Name = "buttonMuaGopAll";
            this.buttonMuaGopAll.Size = new System.Drawing.Size(80, 21);
            this.buttonMuaGopAll.TabIndex = 347;
            this.buttonMuaGopAll.Text = "Tất cả mua";
            this.buttonMuaGopAll.UseVisualStyleBackColor = true;
            this.buttonMuaGopAll.Click += new System.EventHandler(this.buttonMuaGopAll_Click);
            // 
            // textBoxMuadungSoLuong
            // 
            this.textBoxMuadungSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMuadungSoLuong.ForeColor = System.Drawing.Color.Black;
            this.textBoxMuadungSoLuong.Location = new System.Drawing.Point(204, 56);
            this.textBoxMuadungSoLuong.Name = "textBoxMuadungSoLuong";
            this.textBoxMuadungSoLuong.Size = new System.Drawing.Size(36, 13);
            this.textBoxMuadungSoLuong.TabIndex = 204;
            this.textBoxMuadungSoLuong.Text = "0";
            this.textBoxMuadungSoLuong.TextChanged += new System.EventHandler(this.textBoxMuadungSoLuong_TextChanged);
            // 
            // textBoxIdMua
            // 
            this.textBoxIdMua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIdMua.ForeColor = System.Drawing.Color.Black;
            this.textBoxIdMua.Location = new System.Drawing.Point(204, 75);
            this.textBoxIdMua.Name = "textBoxIdMua";
            this.textBoxIdMua.Size = new System.Drawing.Size(36, 13);
            this.textBoxIdMua.TabIndex = 198;
            this.textBoxIdMua.Text = "0";
            this.textBoxIdMua.TextChanged += new System.EventHandler(this.textBoxIdMua_TextChanged);
            // 
            // labelMuaGopStopAll
            // 
            this.labelMuaGopStopAll.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelMuaGopStopAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMuaGopStopAll.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMuaGopStopAll.Location = new System.Drawing.Point(190, 144);
            this.labelMuaGopStopAll.Name = "labelMuaGopStopAll";
            this.labelMuaGopStopAll.Size = new System.Drawing.Size(50, 18);
            this.labelMuaGopStopAll.TabIndex = 214;
            this.labelMuaGopStopAll.Text = "stop all";
            this.labelMuaGopStopAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMuaGopStopAll.Click += new System.EventHandler(this.labelMuaGopStopAll_Click);
            // 
            // labelMuaGopStop
            // 
            this.labelMuaGopStop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelMuaGopStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMuaGopStop.ForeColor = System.Drawing.Color.Black;
            this.labelMuaGopStop.Location = new System.Drawing.Point(190, 121);
            this.labelMuaGopStop.Name = "labelMuaGopStop";
            this.labelMuaGopStop.Size = new System.Drawing.Size(50, 18);
            this.labelMuaGopStop.TabIndex = 213;
            this.labelMuaGopStop.Text = "stop";
            this.labelMuaGopStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMuaGopStop.Click += new System.EventHandler(this.labelMuaGopStop_Click);
            // 
            // labelMuaSudung
            // 
            this.labelMuaSudung.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelMuaSudung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMuaSudung.ForeColor = System.Drawing.Color.Black;
            this.labelMuaSudung.Location = new System.Drawing.Point(86, 121);
            this.labelMuaSudung.Name = "labelMuaSudung";
            this.labelMuaSudung.Size = new System.Drawing.Size(100, 18);
            this.labelMuaSudung.TabIndex = 211;
            this.labelMuaSudung.Text = "Sử dụng vật phẩm";
            this.labelMuaSudung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMuaSudung.Click += new System.EventHandler(this.labelMuaSudung_Click);
            // 
            // labelMuaGopStart
            // 
            this.labelMuaGopStart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelMuaGopStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMuaGopStart.ForeColor = System.Drawing.Color.Black;
            this.labelMuaGopStart.Location = new System.Drawing.Point(3, 121);
            this.labelMuaGopStart.Name = "labelMuaGopStart";
            this.labelMuaGopStart.Size = new System.Drawing.Size(80, 18);
            this.labelMuaGopStart.TabIndex = 210;
            this.labelMuaGopStart.Text = "Bắt đầu mua";
            this.labelMuaGopStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMuaGopStart.Click += new System.EventHandler(this.labelMuaGopStart_Click);
            // 
            // linkLabelPhimCauca
            // 
            this.linkLabelPhimCauca.AutoSize = true;
            this.linkLabelPhimCauca.Location = new System.Drawing.Point(158, 97);
            this.linkLabelPhimCauca.Name = "linkLabelPhimCauca";
            this.linkLabelPhimCauca.Size = new System.Drawing.Size(87, 13);
            this.linkLabelPhimCauca.TabIndex = 208;
            this.linkLabelPhimCauca.TabStop = true;
            this.linkLabelPhimCauca.Text = "xem phim câu cá";
            this.linkLabelPhimCauca.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPhimCauca_LinkClicked);
            // 
            // checkBoxThanhTruotSudung
            // 
            this.checkBoxThanhTruotSudung.AutoSize = true;
            this.checkBoxThanhTruotSudung.ForeColor = System.Drawing.Color.Black;
            this.checkBoxThanhTruotSudung.Location = new System.Drawing.Point(3, 95);
            this.checkBoxThanhTruotSudung.Name = "checkBoxThanhTruotSudung";
            this.checkBoxThanhTruotSudung.Size = new System.Drawing.Size(154, 17);
            this.checkBoxThanhTruotSudung.TabIndex = 207;
            this.checkBoxThanhTruotSudung.Text = "Khi sử dụng có thanh trượt ";
            this.checkBoxThanhTruotSudung.UseVisualStyleBackColor = true;
            this.checkBoxThanhTruotSudung.CheckedChanged += new System.EventHandler(this.checkBoxThanhTruotSudung_CheckedChanged);
            // 
            // buttonHelpMua
            // 
            this.buttonHelpMua.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonHelpMua.Location = new System.Drawing.Point(185, 3);
            this.buttonHelpMua.Name = "buttonHelpMua";
            this.buttonHelpMua.Size = new System.Drawing.Size(55, 21);
            this.buttonHelpMua.TabIndex = 198;
            this.buttonHelpMua.Text = "H.dẫn";
            this.buttonHelpMua.UseVisualStyleBackColor = true;
            this.buttonHelpMua.Click += new System.EventHandler(this.buttonHelpMua_Click);
            // 
            // checkBoxBoquaMaKTC
            // 
            this.checkBoxBoquaMaKTC.ForeColor = System.Drawing.Color.Black;
            this.checkBoxBoquaMaKTC.Location = new System.Drawing.Point(20, 72);
            this.checkBoxBoquaMaKTC.Name = "checkBoxBoquaMaKTC";
            this.checkBoxBoquaMaKTC.Size = new System.Drawing.Size(188, 18);
            this.checkBoxBoquaMaKTC.TabIndex = 205;
            this.checkBoxBoquaMaKTC.Text = "Bỏ bước nhập mã KTC khi mua  . . . . . . . .";
            this.checkBoxBoquaMaKTC.UseVisualStyleBackColor = true;
            this.checkBoxBoquaMaKTC.CheckedChanged += new System.EventHandler(this.checkBoxBoquaMaKTC_CheckedChanged);
            // 
            // checkBoxMuaDungSoluong
            // 
            this.checkBoxMuaDungSoluong.ForeColor = System.Drawing.Color.Black;
            this.checkBoxMuaDungSoluong.Location = new System.Drawing.Point(20, 52);
            this.checkBoxMuaDungSoluong.Name = "checkBoxMuaDungSoluong";
            this.checkBoxMuaDungSoluong.Size = new System.Drawing.Size(188, 17);
            this.checkBoxMuaDungSoluong.TabIndex = 203;
            this.checkBoxMuaDungSoluong.Text = "Mua hoặc sử dụng theo số lượng . . . . ";
            this.checkBoxMuaDungSoluong.UseVisualStyleBackColor = true;
            this.checkBoxMuaDungSoluong.CheckedChanged += new System.EventHandler(this.checkBoxMuaDungSoluong_CheckedChanged);
            // 
            // comboBoxMuaVatpham
            // 
            this.comboBoxMuaVatpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuaVatpham.DropDownWidth = 110;
            this.comboBoxMuaVatpham.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMuaVatpham.FormattingEnabled = true;
            this.comboBoxMuaVatpham.Location = new System.Drawing.Point(60, 3);
            this.comboBoxMuaVatpham.Name = "comboBoxMuaVatpham";
            this.comboBoxMuaVatpham.Size = new System.Drawing.Size(122, 21);
            this.comboBoxMuaVatpham.TabIndex = 190;
            this.comboBoxMuaVatpham.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuaVatpham_SelectedIndexChanged);
            this.comboBoxMuaVatpham.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxMuaVatpham_MouseDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(3, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 191;
            this.label16.Text = "Vật phẩm";
            // 
            // checkBoxGopVatpham
            // 
            this.checkBoxGopVatpham.AutoSize = true;
            this.checkBoxGopVatpham.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxGopVatpham.Location = new System.Drawing.Point(123, 30);
            this.checkBoxGopVatpham.Name = "checkBoxGopVatpham";
            this.checkBoxGopVatpham.Size = new System.Drawing.Size(83, 17);
            this.checkBoxGopVatpham.TabIndex = 193;
            this.checkBoxGopVatpham.Text = "Mua và gộp";
            this.checkBoxGopVatpham.UseVisualStyleBackColor = true;
            this.checkBoxGopVatpham.CheckedChanged += new System.EventHandler(this.checkBoxGopVatpham_CheckedChanged);
            // 
            // checkBoxMuaKytrancac
            // 
            this.checkBoxMuaKytrancac.AutoSize = true;
            this.checkBoxMuaKytrancac.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxMuaKytrancac.Location = new System.Drawing.Point(3, 30);
            this.checkBoxMuaKytrancac.Name = "checkBoxMuaKytrancac";
            this.checkBoxMuaKytrancac.Size = new System.Drawing.Size(113, 17);
            this.checkBoxMuaKytrancac.TabIndex = 194;
            this.checkBoxMuaKytrancac.Text = "Mua ở Kỳ trân các";
            this.checkBoxMuaKytrancac.UseVisualStyleBackColor = true;
            this.checkBoxMuaKytrancac.CheckedChanged += new System.EventHandler(this.checkBoxMuaKytrancac_CheckedChanged);
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.buttonBanVatphamRac);
            this.tabPage15.Controls.Add(this.checkBoxBanVpham);
            this.tabPage15.Controls.Add(this.label21);
            this.tabPage15.Controls.Add(this.buttonDsBanVatpham);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(247, 166);
            this.tabPage15.TabIndex = 3;
            this.tabPage15.Text = "Bán";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // buttonBanVatphamRac
            // 
            this.buttonBanVatphamRac.ForeColor = System.Drawing.Color.Black;
            this.buttonBanVatphamRac.Location = new System.Drawing.Point(3, 94);
            this.buttonBanVatphamRac.Name = "buttonBanVatphamRac";
            this.buttonBanVatphamRac.Size = new System.Drawing.Size(80, 26);
            this.buttonBanVatphamRac.TabIndex = 350;
            this.buttonBanVatphamRac.Text = "Bán";
            this.buttonBanVatphamRac.UseVisualStyleBackColor = true;
            this.buttonBanVatphamRac.Click += new System.EventHandler(this.buttonBanVatphamRac_Click);
            // 
            // checkBoxBanVpham
            // 
            this.checkBoxBanVpham.Location = new System.Drawing.Point(3, 51);
            this.checkBoxBanVpham.Name = "checkBoxBanVpham";
            this.checkBoxBanVpham.Size = new System.Drawing.Size(242, 37);
            this.checkBoxBanVpham.TabIndex = 349;
            this.checkBoxBanVpham.Text = "Luôn chờ bán vật phẩm nằm trong danh sách mỗi khi xuất hiện";
            this.checkBoxBanVpham.UseVisualStyleBackColor = true;
            this.checkBoxBanVpham.CheckedChanged += new System.EventHandler(this.checkBoxBanVpham_CheckedChanged);
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(3, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(244, 43);
            this.label21.TabIndex = 348;
            this.label21.Text = "Mục bán vật phẩm này chỉ sử dụng vào mục đích bán rác ăn event sinh ra, khi không" +
    " sử dụng thì bỏ check để cho nhẹ máy.";
            // 
            // buttonDsBanVatpham
            // 
            this.buttonDsBanVatpham.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDsBanVatpham.Location = new System.Drawing.Point(90, 94);
            this.buttonDsBanVatpham.Name = "buttonDsBanVatpham";
            this.buttonDsBanVatpham.Size = new System.Drawing.Size(149, 26);
            this.buttonDsBanVatpham.TabIndex = 347;
            this.buttonDsBanVatpham.Text = "Danh sách vật phẩm bán";
            this.buttonDsBanVatpham.UseVisualStyleBackColor = true;
            this.buttonDsBanVatpham.Click += new System.EventHandler(this.buttonDsBanVatpham_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxNhapSLTest);
            this.tabPage3.Controls.Add(this.buttonPhimHDLoc);
            this.tabPage3.Controls.Add(this.buttonLocTrangbi);
            this.tabPage3.Controls.Add(this.buttonDungTatcaTrangbiTest);
            this.tabPage3.Controls.Add(this.textBoxMenuTest);
            this.tabPage3.Controls.Add(this.buttonTatcaNhanTrangbiTest);
            this.tabPage3.Controls.Add(this.buttonNhanTrangbiTest);
            this.tabPage3.Controls.Add(this.checkBoxLocTrangbiNhapSL);
            this.tabPage3.Controls.Add(this.comboBoxTrangbiTest);
            this.tabPage3.Controls.Add(this.checkBoxLocTrangbiNPC);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(247, 166);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Lọc trang bị";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxNhapSLTest
            // 
            this.textBoxNhapSLTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNhapSLTest.ForeColor = System.Drawing.Color.Black;
            this.textBoxNhapSLTest.Location = new System.Drawing.Point(209, 71);
            this.textBoxNhapSLTest.Name = "textBoxNhapSLTest";
            this.textBoxNhapSLTest.Size = new System.Drawing.Size(30, 13);
            this.textBoxNhapSLTest.TabIndex = 195;
            this.textBoxNhapSLTest.TextChanged += new System.EventHandler(this.textBoxNhapSLTest_TextChanged);
            // 
            // buttonPhimHDLoc
            // 
            this.buttonPhimHDLoc.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonPhimHDLoc.Location = new System.Drawing.Point(185, 125);
            this.buttonPhimHDLoc.Name = "buttonPhimHDLoc";
            this.buttonPhimHDLoc.Size = new System.Drawing.Size(55, 38);
            this.buttonPhimHDLoc.TabIndex = 189;
            this.buttonPhimHDLoc.Text = "Hướng dẫn";
            this.buttonPhimHDLoc.UseVisualStyleBackColor = true;
            this.buttonPhimHDLoc.Click += new System.EventHandler(this.buttonPhimHDLoc_Click);
            // 
            // buttonLocTrangbi
            // 
            this.buttonLocTrangbi.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonLocTrangbi.Location = new System.Drawing.Point(89, 125);
            this.buttonLocTrangbi.Name = "buttonLocTrangbi";
            this.buttonLocTrangbi.Size = new System.Drawing.Size(90, 38);
            this.buttonLocTrangbi.TabIndex = 192;
            this.buttonLocTrangbi.Text = "Thiết lập điều kiện lọc";
            this.buttonLocTrangbi.UseVisualStyleBackColor = true;
            this.buttonLocTrangbi.Click += new System.EventHandler(this.buttonLocTrangbi_Click);
            // 
            // buttonDungTatcaTrangbiTest
            // 
            this.buttonDungTatcaTrangbiTest.ForeColor = System.Drawing.Color.Black;
            this.buttonDungTatcaTrangbiTest.Location = new System.Drawing.Point(2, 137);
            this.buttonDungTatcaTrangbiTest.Name = "buttonDungTatcaTrangbiTest";
            this.buttonDungTatcaTrangbiTest.Size = new System.Drawing.Size(80, 26);
            this.buttonDungTatcaTrangbiTest.TabIndex = 190;
            this.buttonDungTatcaTrangbiTest.Text = "Dừng tất cả";
            this.buttonDungTatcaTrangbiTest.UseVisualStyleBackColor = true;
            this.buttonDungTatcaTrangbiTest.Click += new System.EventHandler(this.buttonDungTatcaTrangbiTest_Click);
            // 
            // textBoxMenuTest
            // 
            this.textBoxMenuTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMenuTest.ForeColor = System.Drawing.Color.Black;
            this.textBoxMenuTest.Location = new System.Drawing.Point(175, 51);
            this.textBoxMenuTest.Name = "textBoxMenuTest";
            this.textBoxMenuTest.Size = new System.Drawing.Size(65, 13);
            this.textBoxMenuTest.TabIndex = 189;
            this.textBoxMenuTest.TextChanged += new System.EventHandler(this.textBoxMenuTest_TextChanged);
            // 
            // buttonTatcaNhanTrangbiTest
            // 
            this.buttonTatcaNhanTrangbiTest.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonTatcaNhanTrangbiTest.Location = new System.Drawing.Point(3, 104);
            this.buttonTatcaNhanTrangbiTest.Name = "buttonTatcaNhanTrangbiTest";
            this.buttonTatcaNhanTrangbiTest.Size = new System.Drawing.Size(80, 26);
            this.buttonTatcaNhanTrangbiTest.TabIndex = 191;
            this.buttonTatcaNhanTrangbiTest.Text = "Tất cả lọc";
            this.buttonTatcaNhanTrangbiTest.UseVisualStyleBackColor = true;
            this.buttonTatcaNhanTrangbiTest.Click += new System.EventHandler(this.buttonTatcaNhanTrangbiTest_Click);
            // 
            // buttonNhanTrangbiTest
            // 
            this.buttonNhanTrangbiTest.Location = new System.Drawing.Point(3, 75);
            this.buttonNhanTrangbiTest.Name = "buttonNhanTrangbiTest";
            this.buttonNhanTrangbiTest.Size = new System.Drawing.Size(80, 26);
            this.buttonNhanTrangbiTest.TabIndex = 189;
            this.buttonNhanTrangbiTest.Text = "Bắt đầu lọc";
            this.buttonNhanTrangbiTest.UseVisualStyleBackColor = true;
            this.buttonNhanTrangbiTest.Click += new System.EventHandler(this.buttonNhanTrangbiTest_Click);
            // 
            // checkBoxLocTrangbiNhapSL
            // 
            this.checkBoxLocTrangbiNhapSL.AutoSize = true;
            this.checkBoxLocTrangbiNhapSL.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxLocTrangbiNhapSL.Location = new System.Drawing.Point(90, 70);
            this.checkBoxLocTrangbiNhapSL.Name = "checkBoxLocTrangbiNhapSL";
            this.checkBoxLocTrangbiNhapSL.Size = new System.Drawing.Size(109, 17);
            this.checkBoxLocTrangbiNhapSL.TabIndex = 199;
            this.checkBoxLocTrangbiNhapSL.Text = "Có nhập số lượng";
            this.checkBoxLocTrangbiNhapSL.UseVisualStyleBackColor = false;
            this.checkBoxLocTrangbiNhapSL.CheckedChanged += new System.EventHandler(this.checkBoxLocTrangbiNhapSL_CheckedChanged);
            // 
            // comboBoxTrangbiTest
            // 
            this.comboBoxTrangbiTest.DropDownWidth = 110;
            this.comboBoxTrangbiTest.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTrangbiTest.FormattingEnabled = true;
            this.comboBoxTrangbiTest.Location = new System.Drawing.Point(3, 25);
            this.comboBoxTrangbiTest.Name = "comboBoxTrangbiTest";
            this.comboBoxTrangbiTest.Size = new System.Drawing.Size(236, 21);
            this.comboBoxTrangbiTest.TabIndex = 189;
            this.comboBoxTrangbiTest.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrangbiTest_SelectedIndexChanged);
            this.comboBoxTrangbiTest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxTrangbiTest_MouseDown);
            // 
            // checkBoxLocTrangbiNPC
            // 
            this.checkBoxLocTrangbiNPC.AutoSize = true;
            this.checkBoxLocTrangbiNPC.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxLocTrangbiNPC.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxLocTrangbiNPC.Location = new System.Drawing.Point(133, 3);
            this.checkBoxLocTrangbiNPC.Name = "checkBoxLocTrangbiNPC";
            this.checkBoxLocTrangbiNPC.Size = new System.Drawing.Size(104, 17);
            this.checkBoxLocTrangbiNPC.TabIndex = 198;
            this.checkBoxLocTrangbiNPC.Text = "Đây là Npc click";
            this.checkBoxLocTrangbiNPC.UseVisualStyleBackColor = false;
            this.checkBoxLocTrangbiNPC.CheckedChanged += new System.EventHandler(this.checkBoxLocTrangbiNPC_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(3, 51);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(168, 13);
            this.label33.TabIndex = 191;
            this.label33.Text = "Có click vào menu hiện lên, dòng:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.DarkRed;
            this.label32.Location = new System.Drawing.Point(1, 3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(127, 13);
            this.label32.TabIndex = 190;
            this.label32.Text = "Vật phẩm mở trang bị test";
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.textBoxTenacTimVST);
            this.tabPage12.Controls.Add(this.textBoxThoigianVST);
            this.tabPage12.Controls.Add(this.buttonCopyVST);
            this.tabPage12.Controls.Add(this.checkBoxBaokenhbang);
            this.tabPage12.Controls.Add(this.checkBoxBatdauVanSuthong);
            this.tabPage12.Controls.Add(this.textBoxToadoVST);
            this.tabPage12.Controls.Add(this.label3);
            this.tabPage12.Controls.Add(this.checkBoxRoom);
            this.tabPage12.Controls.Add(this.textBoxMapNameVST);
            this.tabPage12.Controls.Add(this.label9);
            this.tabPage12.Controls.Add(this.buttonPasteVST);
            this.tabPage12.Controls.Add(this.label38);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(247, 166);
            this.tabPage12.TabIndex = 5;
            this.tabPage12.Text = "VSThông";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // textBoxTenacTimVST
            // 
            this.textBoxTenacTimVST.ForeColor = System.Drawing.Color.Black;
            this.textBoxTenacTimVST.Location = new System.Drawing.Point(55, 25);
            this.textBoxTenacTimVST.Name = "textBoxTenacTimVST";
            this.textBoxTenacTimVST.Size = new System.Drawing.Size(125, 20);
            this.textBoxTenacTimVST.TabIndex = 195;
            this.textBoxTenacTimVST.TextChanged += new System.EventHandler(this.textBoxTenacTimVST_TextChanged);
            // 
            // textBoxThoigianVST
            // 
            this.textBoxThoigianVST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxThoigianVST.Location = new System.Drawing.Point(149, 52);
            this.textBoxThoigianVST.Name = "textBoxThoigianVST";
            this.textBoxThoigianVST.Size = new System.Drawing.Size(31, 13);
            this.textBoxThoigianVST.TabIndex = 198;
            this.textBoxThoigianVST.TextChanged += new System.EventHandler(this.textBoxThoigianVST_TextChanged);
            // 
            // buttonCopyVST
            // 
            this.buttonCopyVST.Location = new System.Drawing.Point(22, 131);
            this.buttonCopyVST.Name = "buttonCopyVST";
            this.buttonCopyVST.Size = new System.Drawing.Size(61, 21);
            this.buttonCopyVST.TabIndex = 209;
            this.buttonCopyVST.Text = "Copy";
            this.buttonCopyVST.UseVisualStyleBackColor = true;
            this.buttonCopyVST.Click += new System.EventHandler(this.buttonCopyVST_Click);
            // 
            // checkBoxBaokenhbang
            // 
            this.checkBoxBaokenhbang.AutoSize = true;
            this.checkBoxBaokenhbang.Location = new System.Drawing.Point(108, 76);
            this.checkBoxBaokenhbang.Name = "checkBoxBaokenhbang";
            this.checkBoxBaokenhbang.Size = new System.Drawing.Size(99, 17);
            this.checkBoxBaokenhbang.TabIndex = 204;
            this.checkBoxBaokenhbang.Text = "Báo kênh bang";
            this.checkBoxBaokenhbang.UseVisualStyleBackColor = true;
            this.checkBoxBaokenhbang.CheckedChanged += new System.EventHandler(this.checkBoxBaokenhbang_CheckedChanged);
            // 
            // checkBoxBatdauVanSuthong
            // 
            this.checkBoxBatdauVanSuthong.AutoSize = true;
            this.checkBoxBatdauVanSuthong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBatdauVanSuthong.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBoxBatdauVanSuthong.Location = new System.Drawing.Point(3, 82);
            this.checkBoxBatdauVanSuthong.Name = "checkBoxBatdauVanSuthong";
            this.checkBoxBatdauVanSuthong.Size = new System.Drawing.Size(102, 17);
            this.checkBoxBatdauVanSuthong.TabIndex = 213;
            this.checkBoxBatdauVanSuthong.Text = "Bắt đầu chạy";
            this.checkBoxBatdauVanSuthong.UseVisualStyleBackColor = true;
            this.checkBoxBatdauVanSuthong.CheckedChanged += new System.EventHandler(this.checkBoxBatdauVanSuthong_CheckedChanged);
            // 
            // textBoxToadoVST
            // 
            this.textBoxToadoVST.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxToadoVST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxToadoVST.ForeColor = System.Drawing.Color.Black;
            this.textBoxToadoVST.Location = new System.Drawing.Point(108, 139);
            this.textBoxToadoVST.Name = "textBoxToadoVST";
            this.textBoxToadoVST.ReadOnly = true;
            this.textBoxToadoVST.Size = new System.Drawing.Size(133, 13);
            this.textBoxToadoVST.TabIndex = 208;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 214;
            this.label3.Text = "Thời gian giữa 2 lần tìm (giây)";
            // 
            // checkBoxRoom
            // 
            this.checkBoxRoom.AutoSize = true;
            this.checkBoxRoom.Location = new System.Drawing.Point(108, 97);
            this.checkBoxRoom.Name = "checkBoxRoom";
            this.checkBoxRoom.Size = new System.Drawing.Size(77, 17);
            this.checkBoxRoom.TabIndex = 211;
            this.checkBoxRoom.Text = "Kênh room";
            this.checkBoxRoom.UseVisualStyleBackColor = true;
            this.checkBoxRoom.CheckedChanged += new System.EventHandler(this.checkBoxRoom_CheckedChanged);
            // 
            // textBoxMapNameVST
            // 
            this.textBoxMapNameVST.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMapNameVST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMapNameVST.ForeColor = System.Drawing.Color.Black;
            this.textBoxMapNameVST.Location = new System.Drawing.Point(108, 121);
            this.textBoxMapNameVST.Name = "textBoxMapNameVST";
            this.textBoxMapNameVST.ReadOnly = true;
            this.textBoxMapNameVST.Size = new System.Drawing.Size(133, 13);
            this.textBoxMapNameVST.TabIndex = 210;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 215;
            this.label9.Text = "Kết quả dò tìm";
            // 
            // buttonPasteVST
            // 
            this.buttonPasteVST.Location = new System.Drawing.Point(185, 24);
            this.buttonPasteVST.Name = "buttonPasteVST";
            this.buttonPasteVST.Size = new System.Drawing.Size(55, 21);
            this.buttonPasteVST.TabIndex = 206;
            this.buttonPasteVST.Text = "Dán";
            this.buttonPasteVST.UseVisualStyleBackColor = true;
            this.buttonPasteVST.Click += new System.EventHandler(this.buttonPasteVST_Click);
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(3, 4);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(238, 35);
            this.label38.TabIndex = 197;
            this.label38.Text = "Xem Vạn Sự Thông ở Nam Nhạc trấn, tên ac cần tìm là:";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox3);
            this.tabPage8.Controls.Add(this.buttonHuongdanCanhbos);
            this.tabPage8.Controls.Add(this.groupBox2);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(251, 334);
            this.tabPage8.TabIndex = 4;
            this.tabPage8.Text = "Boss";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.checkBoxBossSTKhongLamHaucan);
            this.groupBox3.Controls.Add(this.checkBoxGhepSTG);
            this.groupBox3.Controls.Add(this.checkBoxBossSTtuhuy);
            this.groupBox3.Controls.Add(this.checkBoxONha);
            this.groupBox3.Controls.Add(this.comboBoxBosSatthu);
            this.groupBox3.Controls.Add(this.buttonGhepSTG);
            this.groupBox3.Controls.Add(this.checkBoxKhongLuuruong);
            this.groupBox3.Controls.Add(this.buttonSatthuAll);
            this.groupBox3.Controls.Add(this.checkBoxBossSatthu);
            this.groupBox3.Location = new System.Drawing.Point(0, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 177);
            this.groupBox3.TabIndex = 206;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boss sát thủ";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(11, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(225, 30);
            this.label23.TabIndex = 207;
            this.label23.Text = "Lưu ý săn tổ đội thì auto chỉ chờ các ac PT trong cùng 1 máy";
            // 
            // checkBoxBossSTKhongLamHaucan
            // 
            this.checkBoxBossSTKhongLamHaucan.AutoSize = true;
            this.checkBoxBossSTKhongLamHaucan.ForeColor = System.Drawing.Color.Black;
            this.checkBoxBossSTKhongLamHaucan.Location = new System.Drawing.Point(116, 17);
            this.checkBoxBossSTKhongLamHaucan.Name = "checkBoxBossSTKhongLamHaucan";
            this.checkBoxBossSTKhongLamHaucan.Size = new System.Drawing.Size(110, 17);
            this.checkBoxBossSTKhongLamHaucan.TabIndex = 206;
            this.checkBoxBossSTKhongLamHaucan.Text = "Không mua thuốc";
            this.checkBoxBossSTKhongLamHaucan.UseVisualStyleBackColor = true;
            this.checkBoxBossSTKhongLamHaucan.CheckedChanged += new System.EventHandler(this.checkBoxBossSTKhongLamHaucan_CheckedChanged);
            // 
            // checkBoxGhepSTG
            // 
            this.checkBoxGhepSTG.AutoSize = true;
            this.checkBoxGhepSTG.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxGhepSTG.Location = new System.Drawing.Point(116, 84);
            this.checkBoxGhepSTG.Name = "checkBoxGhepSTG";
            this.checkBoxGhepSTG.Size = new System.Drawing.Size(126, 17);
            this.checkBoxGhepSTG.TabIndex = 202;
            this.checkBoxGhepSTG.Text = "Tự ghép Sát thủ giản";
            this.checkBoxGhepSTG.UseVisualStyleBackColor = true;
            this.checkBoxGhepSTG.CheckedChanged += new System.EventHandler(this.checkBoxGhepSTG_CheckedChanged);
            // 
            // checkBoxBossSTtuhuy
            // 
            this.checkBoxBossSTtuhuy.AutoSize = true;
            this.checkBoxBossSTtuhuy.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxBossSTtuhuy.Location = new System.Drawing.Point(116, 62);
            this.checkBoxBossSTtuhuy.Name = "checkBoxBossSTtuhuy";
            this.checkBoxBossSTtuhuy.Size = new System.Drawing.Size(123, 17);
            this.checkBoxBossSTtuhuy.TabIndex = 205;
            this.checkBoxBossSTtuhuy.Text = "Không bos thì tự hủy";
            this.checkBoxBossSTtuhuy.UseVisualStyleBackColor = true;
            this.checkBoxBossSTtuhuy.CheckedChanged += new System.EventHandler(this.checkBoxBossSTtuhuy_CheckedChanged);
            // 
            // checkBoxONha
            // 
            this.checkBoxONha.AutoSize = true;
            this.checkBoxONha.Location = new System.Drawing.Point(10, 57);
            this.checkBoxONha.Name = "checkBoxONha";
            this.checkBoxONha.Size = new System.Drawing.Size(55, 17);
            this.checkBoxONha.TabIndex = 200;
            this.checkBoxONha.Text = "Ở nhà";
            this.checkBoxONha.UseVisualStyleBackColor = true;
            this.checkBoxONha.CheckedChanged += new System.EventHandler(this.checkBoxONha_CheckedChanged);
            // 
            // comboBoxBosSatthu
            // 
            this.comboBoxBosSatthu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBosSatthu.DropDownWidth = 110;
            this.comboBoxBosSatthu.ForeColor = System.Drawing.Color.Black;
            this.comboBoxBosSatthu.FormattingEnabled = true;
            this.comboBoxBosSatthu.Location = new System.Drawing.Point(10, 23);
            this.comboBoxBosSatthu.Name = "comboBoxBosSatthu";
            this.comboBoxBosSatthu.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBosSatthu.TabIndex = 165;
            this.comboBoxBosSatthu.SelectedIndexChanged += new System.EventHandler(this.comboBoxBosSatthu_SelectedIndexChanged);
            // 
            // buttonGhepSTG
            // 
            this.buttonGhepSTG.Location = new System.Drawing.Point(116, 106);
            this.buttonGhepSTG.Name = "buttonGhepSTG";
            this.buttonGhepSTG.Size = new System.Drawing.Size(120, 26);
            this.buttonGhepSTG.TabIndex = 204;
            this.buttonGhepSTG.Text = "Ghép sát thủ giản";
            this.buttonGhepSTG.UseVisualStyleBackColor = true;
            this.buttonGhepSTG.Click += new System.EventHandler(this.buttonGhepSTG_Click);
            // 
            // checkBoxKhongLuuruong
            // 
            this.checkBoxKhongLuuruong.AutoSize = true;
            this.checkBoxKhongLuuruong.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxKhongLuuruong.Location = new System.Drawing.Point(116, 40);
            this.checkBoxKhongLuuruong.Name = "checkBoxKhongLuuruong";
            this.checkBoxKhongLuuruong.Size = new System.Drawing.Size(104, 17);
            this.checkBoxKhongLuuruong.TabIndex = 188;
            this.checkBoxKhongLuuruong.Text = "Không lưu rương";
            this.checkBoxKhongLuuruong.UseVisualStyleBackColor = true;
            this.checkBoxKhongLuuruong.CheckedChanged += new System.EventHandler(this.checkBoxKhongLuuruong_CheckedChanged);
            // 
            // buttonSatthuAll
            // 
            this.buttonSatthuAll.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonSatthuAll.Location = new System.Drawing.Point(10, 106);
            this.buttonSatthuAll.Name = "buttonSatthuAll";
            this.buttonSatthuAll.Size = new System.Drawing.Size(100, 26);
            this.buttonSatthuAll.TabIndex = 201;
            this.buttonSatthuAll.Text = "Áp dụng tất cả";
            this.buttonSatthuAll.UseVisualStyleBackColor = true;
            this.buttonSatthuAll.Click += new System.EventHandler(this.buttonSatthuAll_Click);
            // 
            // checkBoxBossSatthu
            // 
            this.checkBoxBossSatthu.AutoSize = true;
            this.checkBoxBossSatthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBossSatthu.Location = new System.Drawing.Point(10, 80);
            this.checkBoxBossSatthu.Name = "checkBoxBossSatthu";
            this.checkBoxBossSatthu.Size = new System.Drawing.Size(102, 17);
            this.checkBoxBossSatthu.TabIndex = 198;
            this.checkBoxBossSatthu.Text = "Bắt đầu chạy";
            this.checkBoxBossSatthu.UseVisualStyleBackColor = true;
            this.checkBoxBossSatthu.CheckedChanged += new System.EventHandler(this.checkBoxBossSatthu_CheckedChanged);
            // 
            // buttonHuongdanCanhbos
            // 
            this.buttonHuongdanCanhbos.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonHuongdanCanhbos.Location = new System.Drawing.Point(116, 307);
            this.buttonHuongdanCanhbos.Name = "buttonHuongdanCanhbos";
            this.buttonHuongdanCanhbos.Size = new System.Drawing.Size(132, 26);
            this.buttonHuongdanCanhbos.TabIndex = 271;
            this.buttonHuongdanCanhbos.Text = "Phim Hướng dẫn";
            this.buttonHuongdanCanhbos.UseVisualStyleBackColor = true;
            this.buttonHuongdanCanhbos.Click += new System.EventHandler(this.buttonHuongdanCanhbos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxNoiBoss);
            this.groupBox2.Controls.Add(this.checkBoxTuChayBoss);
            this.groupBox2.Controls.Add(this.buttonDenDiemKetiep);
            this.groupBox2.Controls.Add(this.buttonBossAll);
            this.groupBox2.Controls.Add(this.buttonSuaXoa);
            this.groupBox2.Location = new System.Drawing.Point(0, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 88);
            this.groupBox2.TabIndex = 207;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm boss hoàng kim";
            // 
            // comboBoxNoiBoss
            // 
            this.comboBoxNoiBoss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoiBoss.DropDownWidth = 110;
            this.comboBoxNoiBoss.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNoiBoss.FormattingEnabled = true;
            this.comboBoxNoiBoss.Location = new System.Drawing.Point(116, 13);
            this.comboBoxNoiBoss.Name = "comboBoxNoiBoss";
            this.comboBoxNoiBoss.Size = new System.Drawing.Size(129, 21);
            this.comboBoxNoiBoss.TabIndex = 166;
            this.comboBoxNoiBoss.SelectedIndexChanged += new System.EventHandler(this.comboBoxNoiBoss_SelectedIndexChanged);
            // 
            // checkBoxTuChayBoss
            // 
            this.checkBoxTuChayBoss.AutoSize = true;
            this.checkBoxTuChayBoss.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTuChayBoss.Location = new System.Drawing.Point(9, 19);
            this.checkBoxTuChayBoss.Name = "checkBoxTuChayBoss";
            this.checkBoxTuChayBoss.Size = new System.Drawing.Size(82, 17);
            this.checkBoxTuChayBoss.TabIndex = 165;
            this.checkBoxTuChayBoss.Text = "Tìm boss tại";
            this.checkBoxTuChayBoss.UseVisualStyleBackColor = true;
            this.checkBoxTuChayBoss.CheckedChanged += new System.EventHandler(this.checkBoxTuChayBoss_CheckedChanged);
            // 
            // buttonDenDiemKetiep
            // 
            this.buttonDenDiemKetiep.ForeColor = System.Drawing.Color.Black;
            this.buttonDenDiemKetiep.Location = new System.Drawing.Point(116, 40);
            this.buttonDenDiemKetiep.Name = "buttonDenDiemKetiep";
            this.buttonDenDiemKetiep.Size = new System.Drawing.Size(61, 36);
            this.buttonDenDiemKetiep.TabIndex = 203;
            this.buttonDenDiemKetiep.Text = "Đến điểm kế tiếp";
            this.buttonDenDiemKetiep.UseVisualStyleBackColor = true;
            this.buttonDenDiemKetiep.Click += new System.EventHandler(this.buttonDenDiemKetiep_Click);
            // 
            // buttonBossAll
            // 
            this.buttonBossAll.ForeColor = System.Drawing.Color.Black;
            this.buttonBossAll.Location = new System.Drawing.Point(9, 40);
            this.buttonBossAll.Name = "buttonBossAll";
            this.buttonBossAll.Size = new System.Drawing.Size(101, 36);
            this.buttonBossAll.TabIndex = 168;
            this.buttonBossAll.Text = "Áp dụng cho tất cả ac";
            this.buttonBossAll.UseVisualStyleBackColor = true;
            this.buttonBossAll.Click += new System.EventHandler(this.buttonBossAll_Click);
            // 
            // buttonSuaXoa
            // 
            this.buttonSuaXoa.ForeColor = System.Drawing.Color.Black;
            this.buttonSuaXoa.Location = new System.Drawing.Point(180, 40);
            this.buttonSuaXoa.Name = "buttonSuaXoa";
            this.buttonSuaXoa.Size = new System.Drawing.Size(65, 36);
            this.buttonSuaXoa.TabIndex = 167;
            this.buttonSuaXoa.Text = "Thêm xóa tọa độ";
            this.buttonSuaXoa.UseVisualStyleBackColor = true;
            this.buttonSuaXoa.Click += new System.EventHandler(this.buttonSuaXoa_Click);
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.buttonOpenAllWeb);
            this.tabPageTest.Controls.Add(this.GrouptTest);
            this.tabPageTest.Controls.Add(this.checkBoxSudungDataNguoidung);
            this.tabPageTest.Controls.Add(this.buttonCapnhatData);
            this.tabPageTest.Controls.Add(this.buttonSosanh);
            this.tabPageTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(251, 334);
            this.tabPageTest.TabIndex = 5;
            this.tabPageTest.Text = "Test";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // buttonOpenAllWeb
            // 
            this.buttonOpenAllWeb.Location = new System.Drawing.Point(84, 106);
            this.buttonOpenAllWeb.Name = "buttonOpenAllWeb";
            this.buttonOpenAllWeb.Size = new System.Drawing.Size(147, 36);
            this.buttonOpenAllWeb.TabIndex = 176;
            this.buttonOpenAllWeb.Text = "Mở tất cả trang web tab Cài game";
            this.buttonOpenAllWeb.UseVisualStyleBackColor = true;
            this.buttonOpenAllWeb.Click += new System.EventHandler(this.buttonOpenAllWeb_Click);
            // 
            // GrouptTest
            // 
            this.GrouptTest.Controls.Add(this.buttonBien);
            this.GrouptTest.Controls.Add(this.label14);
            this.GrouptTest.Controls.Add(this.textBoxScrMouseXY);
            this.GrouptTest.Controls.Add(this.textBoxRealMouseXY);
            this.GrouptTest.Controls.Add(this.textBoxScrPosXY);
            this.GrouptTest.Controls.Add(this.label13);
            this.GrouptTest.Controls.Add(this.textBoxRealPosXY);
            this.GrouptTest.Controls.Add(this.buttonXemMaloi);
            this.GrouptTest.Controls.Add(this.buttonFormTest);
            this.GrouptTest.Controls.Add(this.buttonTest);
            this.GrouptTest.Location = new System.Drawing.Point(8, 14);
            this.GrouptTest.Margin = new System.Windows.Forms.Padding(0);
            this.GrouptTest.Name = "GrouptTest";
            this.GrouptTest.Padding = new System.Windows.Forms.Padding(0);
            this.GrouptTest.Size = new System.Drawing.Size(223, 78);
            this.GrouptTest.TabIndex = 162;
            this.GrouptTest.TabStop = false;
            // 
            // buttonBien
            // 
            this.buttonBien.Location = new System.Drawing.Point(162, 9);
            this.buttonBien.Name = "buttonBien";
            this.buttonBien.Size = new System.Drawing.Size(58, 21);
            this.buttonBien.TabIndex = 175;
            this.buttonBien.Text = "Các biến";
            this.buttonBien.UseVisualStyleBackColor = true;
            this.buttonBien.Click += new System.EventHandler(this.buttonBien_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 167;
            this.label14.Text = "mX,mY";
            // 
            // textBoxScrMouseXY
            // 
            this.textBoxScrMouseXY.Location = new System.Drawing.Point(117, 30);
            this.textBoxScrMouseXY.Name = "textBoxScrMouseXY";
            this.textBoxScrMouseXY.Size = new System.Drawing.Size(42, 20);
            this.textBoxScrMouseXY.TabIndex = 166;
            // 
            // textBoxRealMouseXY
            // 
            this.textBoxRealMouseXY.Location = new System.Drawing.Point(45, 30);
            this.textBoxRealMouseXY.Name = "textBoxRealMouseXY";
            this.textBoxRealMouseXY.Size = new System.Drawing.Size(70, 20);
            this.textBoxRealMouseXY.TabIndex = 165;
            // 
            // textBoxScrPosXY
            // 
            this.textBoxScrPosXY.Location = new System.Drawing.Point(117, 10);
            this.textBoxScrPosXY.Name = "textBoxScrPosXY";
            this.textBoxScrPosXY.Size = new System.Drawing.Size(42, 20);
            this.textBoxScrPosXY.TabIndex = 164;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 163;
            this.label13.Text = "pX,pY";
            // 
            // textBoxRealPosXY
            // 
            this.textBoxRealPosXY.Location = new System.Drawing.Point(45, 10);
            this.textBoxRealPosXY.Name = "textBoxRealPosXY";
            this.textBoxRealPosXY.Size = new System.Drawing.Size(70, 20);
            this.textBoxRealPosXY.TabIndex = 162;
            // 
            // buttonXemMaloi
            // 
            this.buttonXemMaloi.Location = new System.Drawing.Point(5, 50);
            this.buttonXemMaloi.Name = "buttonXemMaloi";
            this.buttonXemMaloi.Size = new System.Drawing.Size(69, 21);
            this.buttonXemMaloi.TabIndex = 157;
            this.buttonXemMaloi.Text = "Mã lỗi game";
            this.buttonXemMaloi.UseVisualStyleBackColor = true;
            this.buttonXemMaloi.Click += new System.EventHandler(this.buttonXemMaloi_Click);
            // 
            // buttonFormTest
            // 
            this.buttonFormTest.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonFormTest.ForeColor = System.Drawing.Color.Black;
            this.buttonFormTest.Location = new System.Drawing.Point(75, 50);
            this.buttonFormTest.Name = "buttonFormTest";
            this.buttonFormTest.Size = new System.Drawing.Size(40, 21);
            this.buttonFormTest.TabIndex = 161;
            this.buttonFormTest.Text = "Form";
            this.buttonFormTest.UseVisualStyleBackColor = false;
            this.buttonFormTest.Click += new System.EventHandler(this.buttonFormTest_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.ForeColor = System.Drawing.Color.Black;
            this.buttonTest.Location = new System.Drawing.Point(118, 50);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(41, 21);
            this.buttonTest.TabIndex = 160;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // checkBoxSudungDataNguoidung
            // 
            this.checkBoxSudungDataNguoidung.AutoSize = true;
            this.checkBoxSudungDataNguoidung.Enabled = false;
            this.checkBoxSudungDataNguoidung.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSudungDataNguoidung.Location = new System.Drawing.Point(8, 148);
            this.checkBoxSudungDataNguoidung.Name = "checkBoxSudungDataNguoidung";
            this.checkBoxSudungDataNguoidung.Size = new System.Drawing.Size(150, 17);
            this.checkBoxSudungDataNguoidung.TabIndex = 169;
            this.checkBoxSudungDataNguoidung.Text = "Dùng cập nhật data game";
            this.checkBoxSudungDataNguoidung.UseVisualStyleBackColor = true;
            this.checkBoxSudungDataNguoidung.CheckedChanged += new System.EventHandler(this.checkBoxSudungDataNguoidung_CheckedChanged);
            // 
            // buttonCapnhatData
            // 
            this.buttonCapnhatData.ForeColor = System.Drawing.Color.Black;
            this.buttonCapnhatData.Location = new System.Drawing.Point(8, 106);
            this.buttonCapnhatData.Name = "buttonCapnhatData";
            this.buttonCapnhatData.Size = new System.Drawing.Size(74, 36);
            this.buttonCapnhatData.TabIndex = 18;
            this.buttonCapnhatData.Text = "Cập nhật data game";
            this.buttonCapnhatData.UseVisualStyleBackColor = true;
            this.buttonCapnhatData.Click += new System.EventHandler(this.buttonCapnhatData_Click);
            // 
            // buttonSosanh
            // 
            this.buttonSosanh.ForeColor = System.Drawing.Color.Black;
            this.buttonSosanh.Location = new System.Drawing.Point(16, 180);
            this.buttonSosanh.Name = "buttonSosanh";
            this.buttonSosanh.Size = new System.Drawing.Size(111, 21);
            this.buttonSosanh.TabIndex = 170;
            this.buttonSosanh.Text = "So sánh da ta gốc";
            this.buttonSosanh.UseVisualStyleBackColor = true;
            this.buttonSosanh.Click += new System.EventHandler(this.buttonSosanh_Click);
            // 
            // buttonXoaIDAcChinh
            // 
            this.buttonXoaIDAcChinh.ForeColor = System.Drawing.Color.Black;
            this.buttonXoaIDAcChinh.Location = new System.Drawing.Point(242, 45);
            this.buttonXoaIDAcChinh.Name = "buttonXoaIDAcChinh";
            this.buttonXoaIDAcChinh.Size = new System.Drawing.Size(22, 20);
            this.buttonXoaIDAcChinh.TabIndex = 145;
            this.buttonXoaIDAcChinh.Text = "X";
            this.buttonXoaIDAcChinh.UseVisualStyleBackColor = true;
            this.buttonXoaIDAcChinh.Click += new System.EventHandler(this.buttonXoaIDAcChinh_Click);
            // 
            // buttonTimTrongthanh
            // 
            this.buttonTimTrongthanh.ForeColor = System.Drawing.Color.Black;
            this.buttonTimTrongthanh.Location = new System.Drawing.Point(242, 68);
            this.buttonTimTrongthanh.Name = "buttonTimTrongthanh";
            this.buttonTimTrongthanh.Size = new System.Drawing.Size(22, 20);
            this.buttonTimTrongthanh.TabIndex = 147;
            this.buttonTimTrongthanh.Text = "?";
            this.buttonTimTrongthanh.UseVisualStyleBackColor = true;
            this.buttonTimTrongthanh.Click += new System.EventHandler(this.buttonTimTrongthanh_Click);
            // 
            // richTextBoxChedoMayphu
            // 
            this.richTextBoxChedoMayphu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.richTextBoxChedoMayphu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxChedoMayphu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxChedoMayphu.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBoxChedoMayphu.HideSelection = false;
            this.richTextBoxChedoMayphu.Location = new System.Drawing.Point(83, 199);
            this.richTextBoxChedoMayphu.MaxLength = 30;
            this.richTextBoxChedoMayphu.Name = "richTextBoxChedoMayphu";
            this.richTextBoxChedoMayphu.ReadOnly = true;
            this.richTextBoxChedoMayphu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxChedoMayphu.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxChedoMayphu.Size = new System.Drawing.Size(66, 26);
            this.richTextBoxChedoMayphu.TabIndex = 148;
            this.richTextBoxChedoMayphu.Text = "Là máy phụ\nnút mở rộng";
            this.richTextBoxChedoMayphu.Visible = false;
            this.richTextBoxChedoMayphu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxChedoMayphu_MouseClick);
            // 
            // pictureBoxQC
            // 
            this.pictureBoxQC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxQC.ImageLocation = "";
            this.pictureBoxQC.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxQC.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxQC.Name = "pictureBoxQC";
            this.pictureBoxQC.Size = new System.Drawing.Size(194, 40);
            this.pictureBoxQC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQC.TabIndex = 149;
            this.pictureBoxQC.TabStop = false;
            this.pictureBoxQC.Click += new System.EventHandler(this.pictureBoxQC_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonHelp.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp.Location = new System.Drawing.Point(219, 0);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(20, 42);
            this.buttonHelp.TabIndex = 150;
            this.buttonHelp.Text = "H";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonAchinh
            // 
            this.buttonAchinh.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonAchinh.Location = new System.Drawing.Point(62, 44);
            this.buttonAchinh.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAchinh.Name = "buttonAchinh";
            this.buttonAchinh.Size = new System.Drawing.Size(68, 21);
            this.buttonAchinh.TabIndex = 204;
            this.buttonAchinh.Text = "Ac chính";
            this.buttonAchinh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAchinh.UseVisualStyleBackColor = true;
            this.buttonAchinh.Click += new System.EventHandler(this.buttonAchinh_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(264, 615);
            this.Controls.Add(this.buttonXoaIDAcChinh);
            this.Controls.Add(this.buttonTimTrongthanh);
            this.Controls.Add(this.buttonAchinh);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.richTextBoxChedoMayphu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxKhoangCachAccChinh);
            this.Controls.Add(this.checkBoxTimTrongthanh);
            this.Controls.Add(this.comboBoxAccChinh);
            this.Controls.Add(this.comboBoxIndex);
            this.Controls.Add(this.checkBoxTimAccchinh);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.richTextBoxStatus);
            this.Controls.Add(this.pictureBoxQC);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KYKeoxe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPageBang1.ResumeLayout(false);
            this.tabPageBang1.PerformLayout();
            this.tabPageBang2.ResumeLayout(false);
            this.tabPageBang2.PerformLayout();
            this.tabPageTongKim.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPageCTC.ResumeLayout(false);
            this.tabPageCTC.PerformLayout();
            this.tabControlThatThanh.ResumeLayout(false);
            this.tabPageThatthanh.ResumeLayout(false);
            this.tabPageThatthanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCTC)).EndInit();
            this.tabPageTamtru.ResumeLayout(false);
            this.tabPageTamtru.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPageTamMondai.ResumeLayout(false);
            this.tabPageTamMondai.PerformLayout();
            this.tabPageTrain.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.tabPage16.PerformLayout();
            this.tabPage18.ResumeLayout(false);
            this.tabPage18.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControlHaucan.ResumeLayout(false);
            this.tabPageMuathuoc.ResumeLayout(false);
            this.tabPageMuathuoc.PerformLayout();
            this.tabControl5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPagePhuchoi.ResumeLayout(false);
            this.tabPagePhuchoi.PerformLayout();
            this.tabPageChieuthuc.ResumeLayout(false);
            this.tabPageChieuthuc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlChuyenSkill.ResumeLayout(false);
            this.tabPage19.ResumeLayout(false);
            this.tabPage19.PerformLayout();
            this.tabPage20.ResumeLayout(false);
            this.tabPage20.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabControlPhutro.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPageTinsu.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMM)).EndInit();
            this.tabPageTinhLuyen.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabControlLoc.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageTest.ResumeLayout(false);
            this.tabPageTest.PerformLayout();
            this.GrouptTest.ResumeLayout(false);
            this.GrouptTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	public FormMain()
	{
		new Thread(FormAntivirus.smethod_0).Start();
		FormAntivirus.smethod_1();
		InitializeComponent();
		if (!bool_1)
		{
			tabControlPhutro.Controls.Remove(tabPageTest);
			GrouptTest.Visible = false;
			buttonSosanh.Visible = false;
		}
		Class20.smethod_70();
		Class20.smethod_71();
	}

	private void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		if (int_115 > 0)
		{
			MessageBox.Show("Còn " + int_115 + " giây nữa mới có thể mở tiếp.", string_1, MessageBoxButtons.OK);
			Class20.smethod_48(Class20.smethod_56());
			return;
		}
		if (TryNewVersion.int_0 == 0 && e.CloseReason != CloseReason.WindowsShutDown)
		{
			string text = "Bạn chắc chắn muốn thoát " + string_1 + " ?";
			if (MessageBox.Show(text, string_1, MessageBoxButtons.YesNo) == DialogResult.No)
			{
				e.Cancel = true;
				return;
			}
		}
		Hide();
		Class11.bool_0 = true;
		Thread.Sleep(1200);
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				Class20.smethod_32(gstruct42_0[i].int_130);
			}
		}
		string text2 = string.Empty;
		if (string_19 != null && string_19.Length > 0)
		{
			for (int i = 0; i < string_19.Length; i++)
			{
				text2 = ((text2 != string.Empty) ? (text2 + "|" + string_19[i]) : string_19[i]);
			}
			text2 = Class11.smethod_17(text2);
		}
		Class11.smethod_29(Class47.string_9, text2, 1);
		Class55.smethod_10(Class47.string_0, "tabControl1", tabControl1.SelectedIndex, "", 0);
		Class55.smethod_10(Class47.string_0, "tabControlLoc", tabControlLoc.SelectedIndex, "", 0);
		Class55.smethod_10(Class47.string_0, "tabControlPhutro", tabControlPhutro.SelectedIndex, "", 0);
		int num = Class20.smethod_56();
		Class55.smethod_12(Class47.string_0, (num * 3).ToString(), 1);
		if (TryNewVersion.int_0 > 0)
		{
			Thread.Sleep(1500);
			string text3 = Class20.smethod_74();
			string[] array = Class11.smethod_15(text3);
			Class20.smethod_40(text3, array[0], "", 0);
		}
		Thread.Sleep(600);
		Class20.smethod_48(num);
	}

	private void FormMain_Load(object sender, EventArgs e)
	{
		try
		{
			method_0();
		}
		catch
		{
			richTextBoxStatus.Text = "Cash loading ... ";
		}
	}

	private void method_0()
	{
		long ticks = DateTime.Now.Ticks;
		string text = Class55.smethod_6("TimeSp", 0);
		if (text != null && text != string.Empty)
		{
			long num = Class11.smethod_31(text);
			long num2 = (long)new TimeSpan(ticks - num).TotalMilliseconds;
			if (num > 0L && ticks > num && num2 < 10000L)
			{
				int_115 = (int)((10000L - num2) / 1000L);
				Close();
				return;
			}
		}
		Class55.smethod_10(Class47.string_0, "TimeSp", ticks, "", 0);
		Class11.smethod_8(Class47.string_5);
		Class11.smethod_8(Class47.string_6);
		Class47.smethod_22(bool_2: true);
		string text2 = Class20.smethod_74().ToUpper() + ".BAK";
		if (Class11.smethod_2(text2, ".VSHOST.EXE") >= 0)
		{
			text2 = text2.Replace(".VSHOST.EXE", ".EXE");
		}
		Class11.smethod_20(text2);
		string text3 = Class11.smethod_28(Class47.string_4 + "\\Title.txt", 0, 0, 1);
		if (text3 != string.Empty)
		{
			string_1 = text3 + " " + Class11.char_0;
		}
		notifyIcon_0.Text = string_1;
		checkBoxChayRunAdmin.Checked = (Class20.int_34 > 0);
		for (int i = 0; i < string_29.Length; i++)
		{
			comboBoxGiamCpu.Items.Add(string_29[i]);
		}
		comboBoxGiamCpu.Text = string_29[0];
		SetBounds(Screen.GetWorkingArea(this).Width - base.Width, Screen.GetWorkingArea(this).Height - base.Height, base.Width, base.Height);
		int_46 = new int[4]
		{
			base.Width,
			base.Height,
			base.Left,
			base.Top
		};
		tabControl1.SelectedIndex = Class55.smethod_3("tabControl1", 0, "0");
		tabControlLoc.SelectedIndex = Class55.smethod_3("tabControlLoc", 0, "0");
		tabControlPhutro.SelectedIndex = Class55.smethod_3("tabControlPhutro", 0, "0");
		new Thread(method_11).Start();
		richTextBoxChedoMayphu.Visible = false;
		if (int_20 < 0 || string_10.Length <= int_20)
		{
			int_20 = 0;
		}
		for (int i = 0; i < string_10.Length; i++)
		{
			comboBoxIndex.Items.Add(string_10[i]);
		}
		comboBoxIndex.Text = string_10[int_20];
		for (int i = 0; i < string_23.Length; i++)
		{
			comboBoxUuTien.Items.Add(string_23[i]);
		}
		comboBoxUuTien.Text = string_23[0];
		checkBoxGiamRamTudong.Checked = (int_62 > 0);
		for (int i = 0; i < string_24.Length; i++)
		{
			comboBoxXuongNgua.Items.Add(string_24[i]);
		}
		comboBoxXuongNgua.Text = string_24[0];
		checkBoxTimAccchinh.Checked = (int_21 > 0);
		checkBoxTimTrongthanh.Checked = (int_22 > 0);
		if (int_23 < 150)
		{
			int_23 = 150;
		}
		textBoxKhoangCachAccChinh.Text = int_23.ToString();
		string_9 = string_9.Trim();
		textBoxIDSudung.Text = string_9;
		if (string_15.Length < 6)
		{
			string_15 = "...";
			Class55.smethod_10(Class47.string_0, "TenAccdoiMau", Class11.smethod_17(string_15), "", 0);
		}
		comboBoxAccDoiMau.Items.Add(string_15);
		comboBoxAccDoiMau.Text = string_15;
		if (FormClickNPC.string_5 != null && FormClickNPC.string_5 != string.Empty)
		{
			FormClickNPC.string_1 = new string[1]
			{
				FormClickNPC.string_5
			};
		}
		if (FormClickNPC.string_6 != null && FormClickNPC.string_6 != string.Empty)
		{
			FormClickNPC.string_2 = new string[1]
			{
				FormClickNPC.string_6
			};
		}
		if (FormClickNPC.string_7 != null && FormClickNPC.string_7 != string.Empty)
		{
			FormClickNPC.string_3 = new string[1]
			{
				FormClickNPC.string_7
			};
		}
		if (FormLocdoTest.string_0 == string.Empty || FormLocdoTest.string_0 == null)
		{
			FormLocdoTest.string_0 = "CÈm nang t©n thñ";
		}
		string_16 = new string[1]
		{
			FormLocdoTest.string_0
		};
		string text4 = Class10.smethod_1(FormLocdoTest.string_0, 1);
		comboBoxTrangbiTest.Items.Add(text4);
		comboBoxTrangbiTest.Text = text4;
		text4 = Class55.smethod_6("ClickMenuTest", 0, "9,1");
		if (text4 != null && text4 != string.Empty)
		{
			string text5 = string.Empty;
            string[] array = text4.Split(new char[]
            {
                ',',
                '|',
                '.',
                '-',
                '/',
                ';'
            });
            FormLocdoTest.int_12 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				FormLocdoTest.int_12[i] = Class11.smethod_12(array[i]);
				if (text5 != string.Empty)
				{
					text5 += ",";
				}
				text5 += array[i];
			}
			textBoxMenuTest.Text = text5;
		}
		checkBoxLocTrangbiNPC.Checked = (FormLocdoTest.int_4 > 0);
		checkBoxLocTrangbiNhapSL.Checked = (FormLocdoTest.int_3 > 0);
		text4 = Class55.smethod_6("ClickMenuTrinhsat", 0, "1,1");
		if (text4 != null && text4 != string.Empty)
		{
			string text5 = string.Empty;
            string[] array = text4.Split(new char[]
            {
                ',',
                '|',
                '.',
                '-',
                '/',
                ';'
            });
            int_89 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				int_89[i] = Class11.smethod_12(array[i]);
				if (text5 != string.Empty)
				{
					text5 += ",";
				}
				text5 += array[i];
			}
			textBoxClickMenuTS.Text = text5;
		}
		checkBoxMuaTDP.Checked = (int_53[0] > 0);
		textBoxSoluongTDP.Text = int_53[1].ToString();
		textBoxSoluongThuocDimua.Text = int_54.ToString();
		checkBoxOluonMapphu.Checked = (int_40 > 0);
		checkBoxPheThu.Checked = (int_25 > 0);
		checkBoxTKThanhTruot.Checked = (int_88[0] > 0);
		textBoxTruotTK.Text = int_88[1].ToString();
		checkBoxDanhHieuuy.Checked = (int_90 > 0);
		checkBoxTongKimXemSoluong.Checked = (int_87 > 0);
		checkBoxCungMucTieu.Checked = (int_33 > 0);
		if (string_18 != string.Empty)
		{
			string text6 = Class10.smethod_1(string_18, 1);
			comboBoxMuaVatpham.Items.Add(text6);
			comboBoxMuaVatpham.Text = text6;
		}
		checkBoxMuaKytrancac.Checked = (int_66 > 0);
		checkBoxGopVatpham.Checked = (int_67 > 0);
		textBoxMuadungSoLuong.Text = int_68[1].ToString();
		checkBoxMuaDungSoluong.Checked = (int_68[0] > 0);
		checkBoxThanhTruotSudung.Checked = (int_69 > 0);
		checkBoxChatNham.Checked = (int_63 > 0);
		textBoxChatNham.Text = string_17;
		checkBoxTuve.Checked = (int_30 > 0);
		checkBoxUutienDanhquai.Checked = (int_32 > 0);
		checkBoxDanhquai.Checked = (int_31 > 0);
		checkBoxDanhquai.Enabled = (int_32 == 0);
		checkBoxVaomapAchinh.Checked = (int_45 > 0);
		checkBoxAccPhuHauDoanh.Checked = (int_84 > 0);
		checkBoxAccChinhHauDoanh.Checked = (int_83 > 0);
		checkBoxTrinhSat.Checked = (int_85 > 0);
		checkBoxTatMuamauTK.Checked = (int_86 > 0);
		checkBoxNguHoa500l.Checked = (int_91 > 0);
		checkBoxMuaThontran.Checked = (int_92 > 0);
		for (int i = 0; i < string_25.Length; i++)
		{
			comboBoxVaodiemBaodanh.Items.Add(string_25[i]);
		}
		comboBoxVaodiemBaodanh.Text = string_25[int_44[1]];
		checkBoxTubaoDanh.Checked = (int_44[0] > 0);
		for (int i = 0; i < string_27.Length; i++)
		{
			comboBoxBentau.Items.Add(string_27[i]);
		}
		if (int_98 < 0 || string_27.Length <= int_98)
		{
			int_98 = 0;
		}
		comboBoxBentau.Text = string_27[int_98];
		for (int i = 0; i < string_21.Length; i++)
		{
			comboBoxNhatdo.Items.Add(string_21[i]);
		}
		for (int i = 0; i < string_22.Length; i++)
		{
			comboBoxOtrong.Items.Add(string_22[i]);
		}
		for (int i = 0; i < string_26.Length; i++)
		{
			comboBoxTinSu.Items.Add(string_26[i]);
		}
		checkBoxDenToadoALL.Checked = (int_70 > 0);
		checkBoxMayphuToado.Enabled = (int_70 > 0);
		checkBoxDenToadoUser.Enabled = (int_70 <= 0);
		checkBoxDenToadoLeave.Checked = (int_71 > 0);
		checkBoxMayphuToado.Checked = (int_72[0] > 0);
		if (int_72[1] > 0)
		{
			textBoxMayphuToado.Text = "( " + int_72[2] / 256 + "," + int_72[3] / 512 + " ) " + Class33.smethod_1(int_72[1], bool_0: true);
		}
		int_0 = -1;
		int num3 = -1;
		string text7 = Class55.smethod_6("TenWeb", 0, "khác");
		string text8 = Class55.smethod_6("IdexGameOfWebs", 0);
		if (text8 != null && text8 != string.Empty)
		{
			int num4 = Class11.smethod_12(text8);
			if (0 <= num4 && num4 < string_4.GetLength(0))
			{
				text7 = string_4[num4, 0];
				Class55.smethod_10(Class47.string_0, "TenWeb", text7, "", 0);
			}
			Class55.smethod_10(Class47.string_0, "IdexGameOfWebs", string.Empty, "", 0);
		}
		for (int i = 0; i < string_4.GetLength(0); i++)
		{
			if (text7 != string.Empty && text7 == string_4[i, 0])
			{
				int_0 = i;
			}
			if (string_4[i, 0] == "khác")
			{
				num3 = i;
			}
			comboBoxGameOfWeb.Items.Add(string_4[i, 0]);
		}
		if (int_0 < 0)
		{
			if (string_5 != null)
			{
				for (int i = 0; i < string_5.GetLength(0); i++)
				{
					if (!(text7 == string_5[i, 0]))
					{
						continue;
					}
					for (int j = 0; j < string_4.GetLength(0); j++)
					{
						if (string_5[i, 2] == string_4[j, 2])
						{
							int_0 = j;
							Class55.smethod_10(Class47.string_0, "TenWeb", string_4[j, 0], "", 0);
							break;
						}
					}
					break;
				}
			}
			if (int_0 < 0)
			{
				int_0 = 0;
				if (num3 > 0)
				{
					int_0 = num3;
				}
			}
		}
		checkBoxGameHu.Checked = (int_64 > 0);
		checkBoxBaoKeylog.Checked = (int_65 > 0);
		checkBoxSudungDataNguoidung.Checked = (Class47.int_6 > 0);
		buttonCapnhatData.Enabled = (Class47.int_6 > 0 || bool_1);
		Class89.smethod_3();
		method_5();
		for (int i = 0; i < Class89.struct31_0.Length; i++)
		{
			comboBoxChienTruong.Items.Add(Class89.struct31_0[i].string_2);
			comboBoxChienTruongMapPhu.Items.Add(Class89.struct31_0[i].string_2);
		}
		comboBoxChienTruong.Text = Class89.struct31_0[int_100].string_2;
		comboBoxChienTruongMapPhu.Text = Class89.struct31_0[int_102].string_2;
		numericUpDownCTC.Value = int_103;
		checkBoxMapPhu.Checked = (int_101 > 0);
		checkBoxAccChinhTudieukhienCTC.Checked = (int_106 > 0);
		checkBoxChienLongdong.Checked = (int_108 > 0);
		checkBoxVuotAi.Checked = (int_109 > 0);
		checkBoxDiemTapket.Checked = (int_107 > 0);
		checkBoxChienLongdong.Enabled = (int_20 == 0);
		checkBoxTubaoDanh.Enabled = (int_20 == 1);
		checkBoxTHPChienLong.Checked = (int_104 > 0);
		for (int i = 0; i < Class16.string_1.Length; i++)
		{
			comboBoxCLD.Items.Add(Class16.string_1[i]);
		}
		comboBoxCLD.Text = Class16.string_1[Class16.int_0];
		for (int i = 0; i < string_28.Length; i++)
		{
			comboBoxDoSatcuuSat.Items.Add(string_28[i]);
		}
		string text9 = Class11.smethod_28(Class47.string_9, 0, 0, 1);
		if (text9 != null && text9 != string.Empty)
		{
			text9 = Class11.smethod_16(text9);
			if (text9 != null && text9 != string.Empty)
			{
				string_19 = text9.Split('|');
			}
		}
		checkBoxTHPCTC.Checked = (int_99 > 0);
		for (int i = 1; i < 12; i++)
		{
			comboBoxPk.Items.Add(i);
		}
		string text10 = Class11.smethod_28(Class47.string_11, 0, 0, 1);
		if (text10 != null && text10 != string.Empty)
		{
			text10 = Class11.smethod_16(text10);
			if (text10 != null && text10 != string.Empty)
			{
				FormMayphu.string_0 = text10.Split('|');
			}
		}
		if (string_14 != null && string_14 != string.Empty)
		{
			comboBoxAccChinh.Items.Add(string_14);
			comboBoxAccChinh.Text = string_14;
		}
		checkBoxDameMacdinh.Checked = (FormDame.int_6 > 0);
		checkBoxNPC.Checked = (int_4 > 0);
		if (int_38 <= 0)
		{
			checkBoxChetnamIm.ForeColor = Color.Black;
			checkBoxChetnamIm.Checked = false;
		}
		else
		{
			checkBoxChetnamIm.ForeColor = Color.DarkRed;
			checkBoxChetnamIm.Checked = (int_37 > 0);
		}
		for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
		{
			comboBoxNoiBoss.Items.Add(FormChayBoss.string_2[i, 0]);
		}
		comboBoxNoiBoss.Text = FormChayBoss.string_2[0, 0];
		for (int i = 0; i < Class88.struct29_0.Length; i++)
		{
			comboBoxBosSatthu.Items.Add(Class88.struct29_0[i].string_0);
		}
		comboBoxBosSatthu.Text = Class88.struct29_0[0].string_0;
		checkBoxKhongLuuruong.Checked = (Class88.int_1 > 0);
		checkBoxBossSTtuhuy.Checked = (Class88.int_0 > 0);
		checkBoxGhepSTG.Checked = (Class88.int_2 > 0);
		if (string_7 != null && string_7 != string.Empty)
		{
			textBoxTenacTimVST.Text = string_7;
		}
		checkBoxBaokenhbang.Checked = (int_41 > 0);
		checkBoxRoom.Checked = (int_42 > 0);
		textBoxThoigianVST.Text = int_43.ToString();
		textBoxNhapSLTest.Text = FormLocdoTest.int_2.ToString();
		textBoxNhapSoluongClickNPC.Text = FormClickNPC.int_5.ToString();
		if (Class34.string_0 != null && Class34.string_0 != string.Empty)
		{
			string text11 = Class10.smethod_1(Class34.string_0, 1);
			comboBoxTenHieuThuocTamtru.Items.Add(text11);
			comboBoxTenHieuThuocTamtru.Text = text11;
		}
		textBoxTamMonDaiMapId.Text = int_26.ToString();
		int_24 = 0;
		for (int i = 0; i < string_11.Length; i++)
		{
			comboBoxCTC.Items.Add(string_11[i]);
		}
		comboBoxCTC.Text = string_11[int_24];
		if (Class34.uint_0 == null)
		{
			uint[] array2 = Class34.uint_0 = new uint[2];
		}
		textBoxToadoHieuthuocTamtru.Text = Class34.uint_0[0] + "," + Class34.uint_0[1];
		if (Class34.uint_1 == null)
		{
			uint[] array2 = Class34.uint_1 = new uint[2];
		}
		textBoxCongTamtru.Text = Class34.uint_1[0] + "," + Class34.uint_1[1];
		method_1();
		FormLogin.string_4 = new string[10];
		for (int i = 0; i < FormLogin.string_4.GetLength(0); i++)
		{
			string text12 = "Phân đà Số " + i.ToString();
			for (int j = 0; j < 12; j++)
			{
				text12 = text12 + "|Server " + (j + 1);
			}
			FormLogin.string_4[i] = text12;
		}
		FormCompatibility.string_0 = FormCompatibility.smethod_0();
		bool_5 = FormCompatibility.smethod_2(FormCompatibility.string_0);
		Class7.string_3 = Class7.smethod_0(Class7.string_1);
		Class7.string_4 = Class7.smethod_0(Class7.string_0);
		Class7.string_5 = Class7.smethod_0(Class7.string_2);
		Class7.uint_0 = Class7.smethod_2(Class7.string_3);
		Class7.uint_1 = Class7.smethod_2(Class7.string_4);
		for (int i = 0; i < string_12.GetLength(0); i++)
		{
			comboBoxTHP.Items.Add(string_12[i, 0]);
		}
		comboBoxTHP.Text = string_12[0, 0];
		for (int i = 0; i < string_13.GetLength(0); i++)
		{
			comboBoxPhuong.Items.Add(string_13[i, 0]);
		}
		comboBoxPhuong.Text = string_13[0, 0];
		textBoxTimerPT.Text = Class57.int_2[1].ToString();
		checkBoxChoPTdanhsach.Checked = (Class57.int_2[0] > 0);
		if (!bool_1)
		{
			base.Text = string_1;
		}
		else
		{
			base.Text = "TEST " + string_1;
			int_61 = 0;
		}
		checkBoxPhimTat.Checked = (int_61 > 0);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		bool_2 = true;
		bool_7 = true;
		bool flag = false;
		string text13 = Class47.smethod_0();
		if (text13 == null || text13 == string.Empty)
		{
			text13 = Class55.smethod_6("PathGame", 0);
			flag = true;
		}
		if (text13 != null && text13 != string.Empty)
		{
			if (!flag)
			{
				string b = Class55.smethod_6("PathGame", 0);
				if (text13 != b)
				{
					Class55.smethod_10(Class47.string_0, "PathGame", text13, "", 0);
					Class20.smethod_70(text13, bool_0: false);
				}
			}
			string[] array3 = Class11.smethod_15(text13);
			Class47.string_14 = array3[0];
			Class47.string_15 = array3[1];
			textBoxThuMuc.Text = text13;
			Class85.smethod_8(Class47.string_14);
		}
		new Thread(GClass1.smethod_0).Start();
		new Thread(Class66.smethod_4).Start();
		new Thread(Class38.smethod_0).Start();
		new Thread(Class29.smethod_13).Start();
		new Thread(FormAntivirus.smethod_2).Start();
		new Thread(Class40.smethod_2).Start();
		new Thread(Class65.smethod_0).Start();
		new Thread(Class29.smethod_2).Start();
		Class31.smethod_57();
	}

	private void method_1()
	{
		((Control)tabPageThatthanh).Enabled = (int_24 == 0);
		((Control)tabPageTamtru).Enabled = (int_24 == 1);
		((Control)tabPageTamMondai).Enabled = (int_24 == 2);
		tabControlThatThanh.SelectedIndex = int_24;
	}

	private void method_2(string string_39)
	{
		long_2 = DateTime.Now.Ticks - new TimeSpan(0, 0, 0, 10).Ticks;
		pictureBoxQC.Visible = false;
		richTextBoxStatus.Visible = true;
		richTextBoxStatus.Text = string_39;
	}

	private void listView1_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			method_3(sender, e);
		}
		catch
		{
			method_2("Có lỗi Config của ac đang chọn, nên xóa hết tải lại auto.");
		}
	}

	private void method_3(object sender, MouseEventArgs e)
	{
		bool_6 = true;
		int num = Class71.smethod_4(listView1, e);
		if (num >= 0 && num <= listView1.Items.Count - 1 && gstruct42_0 != null && num <= gstruct42_0.Length - 1)
		{
			int num2 = Class71.smethod_2(listView1, num, gstruct42_0);
			if (num2 >= 0)
			{
				int_73 = num;
				if (gstruct42_0[num2].int_86 < 0 || string_23.Length <= gstruct42_0[num2].int_86)
				{
					gstruct42_0[num2].int_86 = 0;
				}
				gstruct42_0[num2].gstruct36_0 = Class67.smethod_16(gstruct42_0[num2]);
				GStruct42 gStruct = gstruct42_0[num2];
				string a = Class67.smethod_18(gStruct);
				FormHaucanTuithuoc.int_0 = gStruct.int_129;
				FormRauria.int_0 = gStruct.int_129;
				FormRauria.string_0 = a;
				method_4(bool_14: true);
				bool_7 = false;
				comboBoxGiamCpu.Text = string_29[gStruct.int_87];
				if (int_38 > 0)
				{
					checkBoxChetnamIm.Checked = (int_37 > 0);
				}
				else
				{
					checkBoxChetnamIm.Checked = (gStruct.int_91 > 0);
				}
				comboBoxUuTien.Text = string_23[gStruct.int_86];
				if (gStruct.int_86 <= 0)
				{
					buttonUuTien.Text = "Áp dụng";
				}
				else
				{
					buttonUuTien.Text = "Ưu tiên";
				}
				checkBoxBomHPDiem.Checked = (gStruct.int_103[0] > 0);
				textBoxBomHPDiem.Text = gStruct.int_103[1].ToString();
				textBoxThoiGianBomHPDiem.Text = gStruct.int_103[2].ToString();
				textBoxSoLuongBomHPDiem.Text = gStruct.int_103[3].ToString();
				checkBoxBomMPDiem.Checked = (gStruct.int_104[0] > 0);
				textBoxBomMPDiem.Text = gStruct.int_104[1].ToString();
				textBoxThoiGianBomMPDiem.Text = gStruct.int_104[2].ToString();
				textBoxSoLuongBomMPDiem.Text = gStruct.int_104[3].ToString();
				checkBoxBomHP.Checked = (gStruct.int_106[0] > 0);
				textBoxHPBom.Text = gStruct.int_106[1].ToString();
				textBoxThoigianBomHP.Text = gStruct.int_106[2].ToString();
				textBoxSoluongBomHP.Text = gStruct.int_106[3].ToString();
				checkBoxHPTdp.Checked = (gStruct.int_110[0] > 0);
				textBoxHpTDP.Text = gStruct.int_110[1].ToString();
				checkBoxUuTienBomCuuchuyen.Checked = (gStruct.int_105 > 0);
				checkBoxMPBom.Checked = (gStruct.int_108[0] > 0);
				textBoxMPBom.Text = gStruct.int_108[1].ToString();
				textBoxThoigianBomMP.Text = gStruct.int_108[2].ToString();
				textBoxSoluongBomMP.Text = gStruct.int_108[3].ToString();
				checkBoxMPTdp.Checked = (gStruct.int_111[0] > 0);
				textBoxMPTdp.Text = gStruct.int_111[1].ToString();
				textBoxPass.Text = gStruct.string_13;
				checkBoxMua1.Checked = (gStruct.int_70[0] > 0);
				textBoxSoluong1.Text = gStruct.int_70[2].ToString();
				string text = Class10.smethod_1(gStruct.string_9, 1);
				comboBoxMua1.Items.Add(text);
				comboBoxMua1.Text = text;
				checkBoxMua2.Checked = (gStruct.int_71[0] > 0);
				textBoxSoluong2.Text = gStruct.int_71[2].ToString();
				text = Class10.smethod_1(gStruct.string_10, 1);
				comboBoxMua2.Items.Add(text);
				comboBoxMua2.Text = text;
				checkBoxMuaGiaiDoc.Checked = (gStruct.int_72[0] > 0);
				textBoxSoluongMuaGiaiDoc.Text = gStruct.int_72[2].ToString();
				text = Class10.smethod_1(gStruct.string_11, 1);
				comboBoxMuaGiaiDoc.Items.Add(text);
				comboBoxMuaGiaiDoc.Text = text;
				checkBoxAnThuocLag.Checked = (gStruct.int_64 > 0);
				checkBoxTDP_SL_Mau.Checked = (gStruct.int_112 > 0);
				textBoxTDP_SL_Mau.Text = gStruct.int_113.ToString();
				checkBoxTDP_SL_Mana.Checked = (gStruct.int_114 > 0);
				textBoxTDP_SL_Mana.Text = gStruct.int_115.ToString();
				checkBoxMau2.Checked = (gStruct.int_107[0] > 0);
				comboBoxTenMau2.Text = Class10.smethod_1(gStruct.string_14, 1);
				textBoxRatioMau2.Text = gStruct.int_107[1].ToString();
				textBoxTimerMau2.Text = gStruct.int_107[2].ToString();
				textBoxSoluongMau2.Text = gStruct.int_107[3].ToString();
				checkBoxMana2.Checked = (gStruct.int_109[0] > 0);
				comboBoxTenMana2.Text = Class10.smethod_1(gStruct.string_15, 1);
				textBoxRatioMana2.Text = gStruct.int_109[1].ToString();
				textBoxTimerMana2.Text = gStruct.int_109[2].ToString();
				textBoxSoluongMana2.Text = gStruct.int_109[3].ToString();
				checkBoxRuongBH.Checked = (gStruct.int_77 > 0);
				checkBoxTuChuyenThuoc.Checked = (gStruct.int_75[0] > 0);
				checkBoxBamPhimCong.Checked = (gStruct.int_75[1] > 0);
				checkBoxTuChuyenThuoc.Enabled = (gStruct.int_75[1] <= 0);
				textBoxChuyenThuocMin.Enabled = (gStruct.int_75[1] <= 0);
				textBoxChuyenThuocMin.Text = gStruct.int_75[2].ToString();
				textBoxSoluongChuyenthuoc.Text = gStruct.int_75[3].ToString();
				comboBoxChuyenThuoc.Items.Clear();
				if (gStruct.string_12 != null && gStruct.string_12 != string.Empty)
				{
					string text2 = Class10.smethod_1(gStruct.string_12, 1);
					comboBoxChuyenThuoc.Items.Add(text2);
					comboBoxChuyenThuoc.Text = text2;
				}
				checkBoxMuaKTC.Checked = (gStruct.int_76 > 0);
				checkBoxTuchayMuathuoc.Checked = (gStruct.int_101 > 0);
				checkBoxHoasonMuamau500l.Checked = (gStruct.int_102 > 0);
				checkBoxVeThanhKhiPKlon.Checked = (gStruct.int_100[0] > 0);
				comboBoxPk.Text = gStruct.int_100[1].ToString();
				checkBoxTiepCan.Checked = (gStruct.int_92 > 0);
				checkBoxTamQuet.Checked = (gStruct.int_94 > 0);
				checkBoxTuCastBua.Checked = (gStruct.int_116 > 0);
				textBoxKhoangCachTiepcan.Text = gStruct.int_93.ToString();
				textBoxPhamvi.Text = gStruct.int_95.ToString();
				checkBoxNgamyBuff.Checked = (gStruct.int_97[0] > 0);
				textBoxNgamyBuff.Text = gStruct.int_97[3].ToString();
				textBoxTimerNgamyBuff.Text = gStruct.int_97[4].ToString();
				checkBoxNhatdo.Checked = (gStruct.int_38 > 0);
				checkBoxNhatdoDichuyenGan.Checked = (gStruct.int_53 > 0);
				comboBoxNhatdo.Text = string_21[gStruct.int_63];
				textBoxPhamviNhat.Text = gStruct.int_54.ToString();
				checkBoxLuomrac.Checked = (gStruct.int_56 > 0);
				checkBoxMangtheotien.Checked = (gStruct.int_66 > 0);
				textBoxTienMangtheo.Text = gStruct.int_67.ToString();
				if (gStruct.int_55 != null)
				{
					checkBoxRuong0.Checked = (gStruct.int_55[0] > 0);
					checkBoxRuong1.Checked = (gStruct.int_55[1] > 0);
					checkBoxRuong2.Checked = (gStruct.int_55[2] > 0);
					checkBoxRuong3.Checked = (gStruct.int_55[3] > 0);
				}
				checkBoxXepdo.Checked = (gStruct.int_39 > 0);
				textBoxTimeXepdo.Text = gStruct.int_40.ToString();
				comboBoxXuongNgua.Text = string_24[gStruct.int_90];
				checkBoxTuGiaidoc.Checked = (gStruct.int_73[0] > 0);
				textBoxTimerBomMagic.Text = gStruct.int_73[1].ToString();
				textBoxSoluongBomMagic.Text = gStruct.int_73[2].ToString();
				if (!FormMayphu.bool_3)
				{
					checkBoxTheoSau.Checked = (gStruct.int_68[0] > 0);
					textBoxKhoangCachTheoSau.Text = gStruct.int_68[1].ToString();
					comboBoxTheoSau.Text = Class10.smethod_1(gStruct.string_7, 1);
				}
				else
				{
					checkBoxTheoSau.Checked = false;
					checkBoxTheoSau.Enabled = false;
				}
				bool flag = a == "DUONGMON";
				bool enabled = a == "NGAMY";
				bool flag2 = a == "CONLON";
				bool enabled2 = a == "NGUDOC" || a == "THIENNHAN" || flag2;
				bool flag3 = a == "VODANG";
				bool flag4 = a == "THIENNHAN";
				checkBoxTuGiaiBua.Enabled = flag3;
				checkBoxTuGiaiBua.Checked = (gStruct.int_78 > 0 && flag3);
				checkBoxTNXuatChieu120.Enabled = flag4;
				checkBoxTNXuatChieu120.Checked = (gStruct.int_81 > 0 && flag4);
				checkBoxConLon.Enabled = flag2;
				checkBoxConLon.Checked = (gStruct.int_82 > 0 && flag2);
				checkBoxDuongMonBoom.Checked = (flag && gStruct.int_122[0] > 0);
				checkBoxDuongMonBoom.Enabled = flag;
				checkBoxNgamyBuff.Enabled = enabled;
				textBoxNgamyBuff.Enabled = enabled;
				textBoxTimerNgamyBuff.Enabled = enabled;
				buttonNgaMybuff.Enabled = enabled;
				checkBoxTuCastBua.Enabled = enabled2;
				buttonCashBua.Enabled = enabled2;
				checkBoxQuangThuoc.Checked = (gStruct.int_123[0] > 0);
				comboBoxGanChieuTrai.Items.Clear();
				comboBoxGanChieuPhai.Items.Clear();
				comboBoxChuyenChieuPhai1.Items.Clear();
				comboBoxChuyenChieuPhai2.Items.Clear();
				comboBoxChuyenChieuPhai3.Items.Clear();
				comboBoxChuyenChieuTrai1.Items.Clear();
				comboBoxChuyenChieuTrai2.Items.Clear();
				comboBoxChuyenChieuTrai3.Items.Clear();
				comboBoxTranphai1.Items.Clear();
				comboBoxTranphai2.Items.Clear();
				comboBoxTranphai3.Items.Clear();
				int num3 = 0;
				while (gStruct.gstruct36_0 != null && gStruct.gstruct36_0.Length > num3)
				{
					comboBoxGanChieuTrai.Items.Add(gStruct.gstruct36_0[num3].string_0);
					comboBoxGanChieuPhai.Items.Add(gStruct.gstruct36_0[num3].string_0);
					if (gStruct.int_131[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxGanChieuTrai.Text = gStruct.gstruct36_0[num3].string_0;
					}
					if (gStruct.int_132[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxGanChieuPhai.Text = gStruct.gstruct36_0[num3].string_0;
					}
					comboBoxChuyenChieuTrai1.Items.Add(gStruct.gstruct36_0[num3].string_0);
					comboBoxChuyenChieuTrai2.Items.Add(gStruct.gstruct36_0[num3].string_0);
					comboBoxChuyenChieuTrai3.Items.Add(gStruct.gstruct36_0[num3].string_0);
					comboBoxChuyenChieuPhai1.Items.Add(gStruct.gstruct36_0[num3].string_0);
					comboBoxChuyenChieuPhai2.Items.Add(gStruct.gstruct36_0[num3].string_0);
					comboBoxChuyenChieuPhai3.Items.Add(gStruct.gstruct36_0[num3].string_0);
					comboBoxTranphai1.Items.Add(gStruct.gstruct36_0[num3].string_0);
					comboBoxTranphai2.Items.Add(gStruct.gstruct36_0[num3].string_0);
					comboBoxTranphai3.Items.Add(gStruct.gstruct36_0[num3].string_0);
					if (gStruct.int_133[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxChuyenChieuTrai1.Text = gStruct.gstruct36_0[num3].string_0;
					}
					if (gStruct.int_134[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxChuyenChieuTrai2.Text = gStruct.gstruct36_0[num3].string_0;
					}
					if (gStruct.int_135[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxChuyenChieuTrai3.Text = gStruct.gstruct36_0[num3].string_0;
					}
					if (gStruct.int_136[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxChuyenChieuPhai1.Text = gStruct.gstruct36_0[num3].string_0;
					}
					if (gStruct.int_137[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxChuyenChieuPhai2.Text = gStruct.gstruct36_0[num3].string_0;
					}
					if (gStruct.int_138[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxChuyenChieuPhai3.Text = gStruct.gstruct36_0[num3].string_0;
					}
					if (gStruct.int_139[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxTranphai1.Text = gStruct.gstruct36_0[num3].string_0;
					}
					if (gStruct.int_140[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxTranphai2.Text = gStruct.gstruct36_0[num3].string_0;
					}
					if (gStruct.int_141[1] == gStruct.gstruct36_0[num3].int_1)
					{
						comboBoxTranphai3.Text = gStruct.gstruct36_0[num3].string_0;
					}
					num3++;
				}
				checkBoxGanChieuTrai.Checked = (gStruct.int_131[0] > 0);
				checkBoxGanChieuPhai.Checked = (gStruct.int_132[0] > 0);
				checkBoxChuyenChieuTrai1.Checked = (gStruct.int_133[0] > 0);
				checkBoxChuyenChieuTrai2.Checked = (gStruct.int_134[0] > 0);
				checkBoxChuyenChieuTrai3.Checked = (gStruct.int_135[0] > 0);
				checkBoxChuyenChieuPhai1.Checked = (gStruct.int_136[0] > 0);
				checkBoxChuyenChieuPhai2.Checked = (gStruct.int_137[0] > 0);
				checkBoxChuyenChieuPhai3.Checked = (gStruct.int_138[0] > 0);
				textBoxChuyenChieuTrai1.Text = gStruct.int_133[2].ToString();
				textBoxChuyenChieuTrai2.Text = gStruct.int_134[2].ToString();
				textBoxChuyenChieuTrai3.Text = gStruct.int_135[2].ToString();
				textBoxChuyenChieuPhai1.Text = gStruct.int_136[2].ToString();
				textBoxChuyenChieuPhai2.Text = gStruct.int_137[2].ToString();
				textBoxChuyenChieuPhai3.Text = gStruct.int_138[2].ToString();
				checkBoxTranphai1.Checked = (gStruct.int_139[0] > 0);
				checkBoxTranphai2.Checked = (gStruct.int_140[0] > 0);
				checkBoxTranphai3.Checked = (gStruct.int_141[0] > 0);
				textBoxTranphai1.Text = gStruct.int_139[2].ToString();
				textBoxTranphai2.Text = gStruct.int_140[2].ToString();
				textBoxTranphai3.Text = gStruct.int_141[2].ToString();
				string_32 = gStruct.string_0;
				comboBoxClickNPC.Text = Class10.smethod_1(gStruct.string_0, 1);
				checkBoxClickNPCmenu.Checked = (gStruct.int_8 > 0);
				if (gStruct.int_9 != null)
				{
					string text3 = string.Empty;
					for (num3 = 0; num3 < gStruct.int_9.Length; num3++)
					{
						if (text3 != string.Empty)
						{
							text3 += ",";
						}
						text3 += gStruct.int_9[num3].ToString();
					}
					textBoxClickNPCMenu.Text = text3;
				}
				if (gStruct.int_7 != null)
				{
					checkBoxClickNPCSolan.Checked = (gStruct.int_7[0] > 0);
					textBoxClickNPCSolan.Text = gStruct.int_7[1].ToString();
				}
				buttonClickNpcSingle.Enabled = !gStruct.bool_6;
				textBoxClickNPCTocdo.Text = gStruct.int_10.ToString();
				comboBoxDoSatcuuSat.Text = string_28[gStruct.int_34];
				checkBoxTrain.Checked = (gStruct.int_26 > 0);
				checkBoxTucheHT.Checked = (gStruct.int_27 > 0);
				checkBoxDanhquaiTrain.Checked = (gStruct.int_28 > 0);
				checkBoxDanhQuaiTrenduongdi.Checked = (gStruct.int_31 > 0);
				checkBoxQuayquai.Checked = (gStruct.int_32 > 0);
				checkBoxTDPHettien.Checked = (gStruct.int_29 > 0);
				checkBoxTDPHettien.Enabled = (gStruct.int_27 > 0);
				checkBoxToadoVong.Checked = (gStruct.int_30 > 0);
				listViewTrain.Items.Clear();
				if (gStruct.uint_0 != null)
				{
					for (num3 = 0; num3 < gStruct.uint_0.GetLength(0); num3++)
					{
						method_22(listViewTrain, new uint[2]
						{
							gStruct.uint_0[num3, 0],
							gStruct.uint_0[num3, 1]
						});
					}
				}
				textBoxMapName.Text = Class33.smethod_1(gStruct.int_33, bool_0: true);
				checkBoxTranhBossVang.Checked = (gStruct.int_59 > 0);
				checkBoxTDPSaimap.Checked = (gStruct.int_61 > 0);
				checkBoxTTL.Checked = (gStruct.int_60 > 0);
				textBoxSLThoat.Text = gStruct.int_19.ToString();
				checkBoxSLThoat.Checked = (gStruct.int_20 > 0);
				checkBoxAnThuocTDD.Checked = (gStruct.int_65[0] > 0);
				textBoxTocdoDanh.Text = gStruct.int_65[1].ToString();
				checkBoxOtrong.Checked = (gStruct.int_62[0] > 0);
				comboBoxOtrong.Text = string_22[gStruct.int_62[1]];
				textBoxIdMua.Text = gStruct.int_124.ToString();
				string text4 = string.Empty;
				if (gStruct.int_120 != null && gStruct.int_120.Length == 5 && gStruct.int_120[2] > 0)
				{
					text4 = "( " + gStruct.int_120[3] / 256 + "," + gStruct.int_120[4] / 512 + " ) " + Class33.smethod_1(gStruct.int_120[2], bool_0: true);
				}
				textBoxToadoDen.Text = text4;
				checkBoxDenToadoUser.Checked = (gStruct.int_120[0] > 0);
				checkBoxBatdauVanSuthong.Checked = gStruct.bool_60;
				checkBoxChayTinsu.Checked = (gStruct.int_21[0] > 0);
				comboBoxTinSu.Text = string_26[gStruct.int_21[1]];
				checkBoxChaydanhvong.Checked = gStruct.bool_8;
				checkBoxChayPKNguoidung.Checked = (gStruct.int_35 > 0);
				checkBoxMuathuocPK.Checked = gStruct.bool_9;
				method_29(gStruct.int_21[0] <= 0 && gStruct.int_21[1] > 0);
				comboBoxTinSu.Enabled = (gStruct.int_21[0] <= 0);
				checkBoxChoPTdanhsach.Enabled = (gStruct.int_21[1] == 0);
				comboBoxTinSu.Enabled = (gStruct.int_21[1] == 0);
				if (FormChayBoss.string_2 != null)
				{
					if (gStruct.int_0 < 0 || FormChayBoss.string_2.GetLength(0) <= gStruct.int_0)
					{
						gStruct.int_0 = 0;
						gstruct42_0[num2].int_0 = 0;
					}
					comboBoxNoiBoss.Text = FormChayBoss.string_2[gStruct.int_0, 0];
					buttonDenDiemKetiep.Text = "Đến điểm kế tiếp" + Class47.string_3 + "( " + (gStruct.int_0 + 1) + " )";
				}
				checkBoxTuChayBoss.Checked = gStruct.bool_1;
				if (gStruct.int_118 != null)
				{
					checkBoxTudongPT.Checked = (gStruct.int_118[0] > 0);
					if (gStruct.int_118[1] <= 0)
					{
						checkBoxTudongPT.ForeColor = Color.Black;
					}
					else
					{
						checkBoxTudongPT.ForeColor = Color.Blue;
					}
				}
				checkBoxBosBaobos.Checked = (gStruct.int_1 > 0);
				checkBoxGanTenthuoc.Checked = (gStruct.int_74[0] > 0);
				textBoxOso1.Text = gStruct.int_74[1].ToString();
				textBoxOso2.Text = gStruct.int_74[2].ToString();
				textBoxOso3.Text = gStruct.int_74[3].ToString();
				checkBoxNhatqua.Checked = (gStruct.int_125[0] > 0);
				checkBoxGioClick.Checked = (gStruct.int_125[1] > 0);
				numericUpDownHH.Value = gStruct.int_125[2];
				numericUpDownMM.Value = gStruct.int_125[3];
				numericUpDownSS.Value = gStruct.int_125[4];
				textBoxPhamviNhatqua.Text = gStruct.int_125[5].ToString();
				checkBoxBossSatthu.Checked = (gStruct.int_126[0] > 0);
				comboBoxBosSatthu.Text = Class88.struct29_0[gStruct.int_126[3]].string_0;
				checkBoxONha.Checked = (gStruct.int_126[4] > 0);
				checkBoxBossSTKhongLamHaucan.Checked = (gStruct.int_127 > 0);
				checkBoxAceptBH.Checked = gStruct.bool_26;
				checkBoxBanVpham.Checked = (gStruct.int_11 > 0);
				buttonBanVatphamRac.Enabled = (gStruct.int_11 <= 0);
				Thread.Sleep(30);
				bool_7 = true;
				return;
			}
		}
		FormRauria.int_0 = -1;
		FormHaucanTuithuoc.int_0 = -1;
		int_73 = -1;
		method_4(bool_14: false);
	}

	private void method_4(bool bool_14)
	{
		((Control)tabPageTrain).Enabled = bool_14;
		((Control)tabPagePhuchoi).Enabled = bool_14;
		((Control)tabPageMuathuoc).Enabled = bool_14;
		((Control)tabPageChieuthuc).Enabled = bool_14;
		buttonDanhsachCuusat.Enabled = bool_14;
	}

	private static void smethod_0(TabPage tabPage_0, bool bool_14, Color color_0)
	{
		foreach (Control control in tabPage_0.Controls)
		{
			if (control.ForeColor != color_0)
			{
				control.Enabled = bool_14;
			}
		}
	}

	private void method_5()
	{
		string text = "...";
		for (int i = 0; i < Class89.struct31_0.Length; i++)
		{
			if (Class89.struct31_0[i].uint_0 == null || Class89.struct31_0[i].string_0 == null || !(Class89.struct31_0[i].string_0 != string.Empty))
			{
				text = "(Chưa đầy đủ vị trí)";
				break;
			}
		}
		labelChuadaydu.Text = text;
	}

	private static void smethod_1(GStruct42 gstruct42_2)
	{
		if (gstruct42_2.uint_11 != 0)
		{
			Class20.smethod_2(gstruct42_2.int_130, gstruct42_2.uint_11);
		}
		if (gstruct42_2.uint_24 != 0)
		{
			Class20.smethod_2(gstruct42_2.int_130, gstruct42_2.uint_24);
		}
		if (gstruct42_2.uint_28 != 0)
		{
			Class20.smethod_2(gstruct42_2.int_130, gstruct42_2.uint_28);
		}
	}

	private void method_6(string string_39, int int_134 = 0, bool bool_14 = false, int[] int_135 = null)
	{
		try
		{
			FormTip formTip = new FormTip();
			formTip.string_0 = string_39;
			formTip.bool_1 = !bool_14;
			if (int_135 == null || int_135.Length != 4)
			{
				int_135 = new int[4]
				{
					base.Left,
					base.Top,
					base.Width,
					base.Height
				};
			}
			formTip.int_0 = int_135[0];
			formTip.int_1 = int_135[1];
			formTip.int_2 = int_135[2];
			formTip.int_3 = int_135[3];
			formTip.int_4 = int_134;
			formTip.Show();
		}
		catch
		{
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		try
		{
			if (!bool_7)
			{
				long num = Class11.smethod_23(long_1);
				if (num > 3000L)
				{
					long_1 = Class11.smethod_22();
				}
				else if (num > 1200L)
				{
					bool_7 = true;
				}
			}
			if (TryNewVersion.int_0 == 2)
			{
				Close();
			}
			else
			{
				if (Class66.bool_0 || int_118 != int_61)
				{
					int_118 = int_61;
					GClass0.smethod_1();
					if (int_61 > 0)
					{
						Thread.Sleep(300);
						GClass0.smethod_0();
					}
					Class66.bool_0 = false;
				}
				method_7();
			}
		}
		catch
		{
		}
	}

	private void method_7()
	{
		if (FormTuychon.int_2 > 1)
		{
			FormTuychon.int_2 = 0;
			if (int_38 > 0)
			{
				checkBoxChetnamIm.ForeColor = Color.DarkRed;
			}
			else
			{
				checkBoxChetnamIm.ForeColor = Color.Black;
			}
		}
		if (!FormTip.bool_0)
		{
			if (bool_9)
			{
				if (!bool_10 && GClass1.string_3 != null && GClass1.string_3 != string.Empty)
				{
					bool_10 = true;
					string text = "LuuY";
					if (Class55.smethod_6(text, 0) != GClass1.string_3)
					{
						FormTip formTip = new FormTip();
						formTip.string_0 = GClass1.string_3;
						formTip.string_2 = text;
						formTip.string_1 = "LUU Y";
						formTip.Show();
					}
				}
			}
			else
			{
				bool_9 = true;
				string text2 = Class55.smethod_6("UpdateNew", 0);
				if (Class11.smethod_12(text2) != string_6.Length && string_6 != null && string_6 != string.Empty)
				{
					FormTip formTip = new FormTip();
					formTip.string_0 = string_6;
					formTip.string_1 = "PHIEN BAN MOI";
					formTip.Show();
				}
			}
		}
		if (int_125 != int_7 || int_124 != int_6)
		{
			int_124 = int_6;
			int_125 = int_7;
			richTextBoxChedoMayphu.Visible = (int_7 > 0 || int_6 > 0);
		}
		if (0 <= int_0 && int_119 != int_0 && string_4 != null && int_0 < string_4.GetLength(0))
		{
			int_119 = int_0;
			if (string_3 != string_4[int_0, 0])
			{
				string_3 = string_4[int_0, 0];
				comboBoxGameOfWeb.Text = string_3;
				Class55.smethod_10(Class47.string_0, "TenWeb", string_3, "", 0);
			}
			method_19();
		}
		if (base.WindowState == FormWindowState.Minimized)
		{
			notifyIcon_0.Visible = true;
			Hide();
		}
		if (!FormAntivirus.bool_0 && !FormAntivirus.bool_1 && FormAntivirus.bool_2)
		{
			FormAntivirus.bool_2 = false;
			try
			{
				FormAntivirus formAntivirus = new FormAntivirus();
				formAntivirus.Show();
			}
			catch
			{
			}
		}
		if (int_121 == 0)
		{
			int_121 = 1;
			if (int_10 <= 0)
			{
				method_20();
			}
		}
		if (int_128 == 1)
		{
			buttonSuadoTaicho.Enabled = false;
			new Thread(method_17).Start();
		}
		else if (int_128 == 3)
		{
			int_128 = 0;
			buttonSuadoTaicho.Enabled = true;
		}
		if (FormXaphuCT.int_0 == -2)
		{
			FormXaphuCT.int_0 = 0;
			method_5();
		}
		if (Class61.string_0 != null && Class61.string_0.Length > 1)
		{
			textBoxMapNameVST.Text = Class10.smethod_1(Class61.string_0[0], 1);
			textBoxToadoVST.Text = Class61.string_0[1];
			Class61.string_0 = null;
		}
		if (Class11.string_14 != null && Class11.string_14.Length > 0)
		{
			if (Class11.string_14[0] != null && !(Class11.string_14[0] == string.Empty))
			{
				string text3 = Class11.string_14[0].Replace("|", Class47.string_3);
				if (Class11.smethod_2(text3, "MESS:") == 0)
				{
					Class11.smethod_25(ref Class11.string_14, Class11.string_14[0]);
					text3 = text3.Replace("MESS:", "");
					MessageBox.Show(text3, string.Empty, MessageBoxButtons.OK);
				}
				else if (Class11.smethod_2(text3, "FORM:") == 0)
				{
					if (!FormTip.bool_0)
					{
						Class11.smethod_25(ref Class11.string_14, Class11.string_14[0]);
						text3 = text3.Replace("FORM:", "");
						FormTip.smethod_0(string_1, text3, 60000, 360, 180, bool_5: false, base.Left, base.Top);
					}
				}
				else
				{
					Class11.smethod_25(ref Class11.string_14, Class11.string_14[0]);
					method_2(text3);
				}
			}
			else
			{
				Class11.smethod_25(ref Class11.string_14, Class11.string_14[0]);
			}
		}
		if (int_127 > 0 && !FormTip.bool_0)
		{
			int_127 = 0;
			string text4 = string.Empty;
			if (!bool_1)
			{
				if (Class47.string_66 != null && Class47.string_66 != string.Empty)
				{
					text4 = "CÓ LỖI SỐ: " + Class47.string_66 + "||Hướng dẫn sửa lỗi - Qua tab Cài game, kiểm tra lại:||- Nếu đang check vào mục [v] Sử dụng cập nhật data game: Bạn hãy bỏ check hoặc bấm lại nút Cập nhật data game.||- Nếu không check vào mục [v] Sử dụng cập nhật data game: Bạn hãy check vào rồi bấm Cập nhật data game, hoặc liên hệ bên cung cấp auto để sửa lỗi.||";
				}
			}
			else
			{
				if (Class47.string_66 != null && Class47.string_66 != string.Empty)
				{
					text4 = "CÓ LỖI SỐ: " + Class47.string_66;
				}
				if (Class47.string_67 != null && Class47.string_67 != string.Empty)
				{
					if (text4 != string.Empty)
					{
						text4 += "||=======================================|";
					}
					text4 = text4 + "DATA CAP NHAT:|" + Class47.string_67;
				}
			}
			if (text4 != string.Empty)
			{
				FormTip.smethod_0(string_1, text4, 600000, 400, 400, bool_5: false, base.Left, base.Top);
			}
		}
		if (Class47.string_69 != null)
		{
			string string_ = Class47.string_69;
			Class47.string_69 = null;
			FormTip.smethod_0(string_1, string_, 600000, 400, 400, bool_5: true, base.Left, base.Top);
		}
		if (!GClass1.bool_0 && !bool_1)
		{
			return;
		}
		long num = Class11.smethod_23(long_2);
		if (Class90.gstruct52_0 != null && num > long_3)
		{
			long_3 = method_15();
			long_2 = Class11.smethod_22();
		}
		if (FormLogin.gstruct0_0 != null && FormLogin.gstruct0_0.Length > 0)
		{
			if (int_120 < 0 || FormLogin.gstruct0_0.Length <= int_120)
			{
				int_120 = 0;
			}
			GStruct0 gstruct0_ = FormLogin.gstruct0_0[int_120];
			if (gstruct0_.int_1 != 0 && !Class20.smethod_52(gstruct0_.process_0))
			{
				if (Class43.smethod_31(gstruct0_) > 0 && gstruct0_.int_0 <= 0)
				{
					FormLogin.gstruct0_0[int_120].int_0 = 1;
				}
			}
			else
			{
				if (gstruct0_.int_1 > 0)
				{
					FormLogin.gstruct0_0[int_120].int_1 = 0;
				}
				if (FormLogin.int_4 <= 0)
				{
					if (gstruct0_.int_0 > 0)
					{
						FormLogin.gstruct0_0[int_120].int_0 = 0;
					}
				}
				else if (gstruct0_.int_0 > 0)
				{
					string str = gstruct0_.string_0;
					if (gstruct0_.string_4 != null && gstruct0_.string_4 != string.Empty)
					{
						str = Class10.smethod_1(gstruct0_.string_4, 1);
					}
					method_2("[" + str + "] sẽ đăng nhập lại trong vài giây nữa...");
					Class11.smethod_32(ref Class40.int_0, int_120);
				}
			}
			int_120++;
		}
		if (GClass1.int_1 == 1)
		{
			GClass1.int_1 = 0;
			buttonAdd.Visible = true;
			buttonAdd.Enabled = true;
			string[] array = GClass1.smethod_3();
			labelThongtinDK.Text = array[0];
			textBoxHSD.Text = array[1];
			if (GClass1.int_3 == 2)
			{
				richTextBoxBHO.Text = GClass1.smethod_4();
			}
		}
		if (GClass1.string_1 != null && GClass1.string_1 != string.Empty && !FormTip.bool_0)
		{
			string text5 = Class11.char_0.Replace(".", "");
			string text6 = GClass1.string_1.Replace(".", "");
			while (text5.Length != text6.Length)
			{
				if (text5.Length < text6.Length)
				{
					text5 += "0";
				}
				else
				{
					text6 += "0";
				}
			}
			int_2 = Class11.smethod_12(text5);
			int_3 = Class11.smethod_12(text6);
			if (int_2 < int_3)
			{
				bool_0 = true;
				string text3 = "ĐÃ CÓ BẢN CẬP NHẬT||Phiên bản hiện tại là " + string_1 + ", hiện đã có phiên bản mới hơn là " + string_1.Replace(Class11.char_0, GClass1.string_1) + "||Bạn hãy vào tab Phụ trợ, bấm nút " + buttonCapnhat.Text + " để update lên phiên bản mới hơn này nhé !";
				FormTip.smethod_0(string_1, text3, 45000, 280, 160, bool_5: false, base.Left, base.Top);
			}
			GClass1.string_1 = null;
		}
		if (GClass0.int_1 == Class24.int_5)
		{
			int num2 = int_131 + 1;
			if (num2 > 2)
			{
				num2 = 0;
			}
			GClass0.int_1 = 0;
			method_24(num2);
		}
		else if (GClass0.int_1 == Class24.int_3)
		{
			if (Class66.gstruct42_0.int_129 > 0)
			{
				string[] array2 = new string[2]
				{
					"T¾t",
					"BËt"
				};
				bool @checked;
				int_30 = Convert.ToByte(@checked = (int_30 <= 0));
				checkBoxTuve.Checked = @checked;
				Class60.smethod_50(Class66.gstruct42_0, "<color=yellow>§\u00b8nh ng­êi: <color=pink>" + array2[int_30]);
				bool_11 = false;
				new Thread(method_8).Start();
			}
			GClass0.int_1 = 0;
		}
		else if (GClass0.int_1 == Class24.int_2)
		{
			if (Class66.gstruct42_0.int_129 > 0)
			{
				string[] array2 = new string[2]
				{
					"T¾t",
					"BËt"
				};
				bool @checked;
				int_31 = Convert.ToByte(@checked = (int_31 <= 0));
				checkBoxDanhquai.Checked = @checked;
				Class60.smethod_50(Class66.gstruct42_0, "<color=white>§\u00b8nh qu\u00b8i: <color=green>" + array2[int_31]);
				bool_11 = true;
				new Thread(method_8).Start();
			}
			GClass0.int_1 = 0;
		}
		else if (GClass0.int_1 == Class24.int_1)
		{
			GClass0.int_1 = 0;
			if (Class66.gstruct42_0.int_129 > 0 && FormAchinh.int_0 > 0 && FormAchinh.string_0 != null && FormAchinh.string_0 != string.Empty)
			{
				string text7 = string_14;
				string_14 = FormAchinh.string_0;
				comboBoxAccChinh.Items.Add(string_14);
				comboBoxAccChinh.Text = string_14;
				FormAchinh.string_0 = text7;
				Class55.smethod_10(Class47.string_0, "AccChinhNameA", Class11.smethod_17(string_14), "", 0);
				Class55.smethod_10(Class47.string_0, "AccChinh2", Class11.smethod_17(FormAchinh.string_0), "", 0);
			}
		}
		if (int_126 <= 0)
		{
			int_126 = 1;
			if (int_62 > 0)
			{
				new Thread(new Class14().method_0).Start();
			}
		}
		if (int_130 > 1)
		{
			int_130 = 0;
			buttonGiamCPUAll.Enabled = true;
		}
		if (FormChayBoss.bool_1)
		{
			FormChayBoss.bool_1 = false;
			comboBoxNoiBoss.Items.Clear();
			for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
			{
				comboBoxNoiBoss.Items.Add(FormChayBoss.string_2[i, 0]);
			}
			comboBoxNoiBoss.Text = FormChayBoss.string_2[0, 0];
			if (gstruct42_0 != null)
			{
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					gstruct42_0[i].bool_1 = false;
					gstruct42_0[i].int_0 = 0;
				}
			}
			checkBoxTuChayBoss.Checked = false;
		}
		if (FormChayBoss.string_0 != null)
		{
			checkBoxTuChayBoss.Checked = false;
			comboBoxNoiBoss.Text = FormChayBoss.string_0;
			FormChayBoss.string_0 = null;
		}
		if (int_114 != FormDame.int_5)
		{
			int_114 = FormDame.int_5;
			labelKieudame.Text = "( " + (FormDame.int_5 + 1).ToString() + " )";
		}
		if (int_112 != null && int_112.Length > 0)
		{
			int num3 = int_112[0];
			int num4 = Class71.smethod_10(listView1, num3);
			Class11.smethod_33(ref int_112, num3);
			if (0 <= num4)
			{
				listView1.Items[num4].Checked = false;
			}
		}
		while (ThemXoaDanhsach.int_0 != null && ThemXoaDanhsach.int_0.Length > 0)
		{
			int num5 = ThemXoaDanhsach.int_0[0];
			Class11.smethod_33(ref ThemXoaDanhsach.int_0, num5);
			GStruct42 gStruct = Class47.smethod_7(num5);
			if (gStruct.int_129 != 0)
			{
				Class11.smethod_24(ref string_20, gStruct.int_129 + "==" + gStruct.string_20);
				Class11.smethod_25(ref string_19, gStruct.string_20);
				string text8 = comboBoxAccChinh.Text;
				if (text8 != string.Empty && text8 != null && Class10.smethod_1(gStruct.string_20, 1) == text8)
				{
					int_52 = gStruct.int_129;
				}
				if (string_15 != string.Empty && string_15.Length > 5 && Class10.smethod_1(gStruct.string_20, 1) == string_15)
				{
					gstruct42_1 = gStruct;
				}
				Class71.smethod_5(listView1, gStruct);
				Class71.smethod_0(ref gstruct42_0, gStruct);
				if (gStruct.int_2 > 0)
				{
					FormMayphu.int_0 = gStruct.int_129;
					new Thread(FormMayphu.smethod_0).Start();
					Thread.Sleep(150);
				}
				Class47.smethod_9(num5);
			}
		}
		while (ThemXoaDanhsach.int_1 != null && ThemXoaDanhsach.int_1.Length > 0)
		{
			int num6 = ThemXoaDanhsach.int_1[0];
			if (num6 == Class38.gstruct29_0.int_0 || num6 == int_52)
			{
				int_52 = 0;
				Class38.gstruct29_0.int_0 = 0;
			}
			if (num6 == gstruct42_1.int_129)
			{
				GStruct42 gStruct2 = default(GStruct42);
				gStruct2.int_129 = 0;
				gstruct42_1 = gStruct2;
				string_15 = "...";
				comboBoxAccDoiMau.Items.Clear();
				comboBoxAccDoiMau.Items.Add(string_15);
				comboBoxAccDoiMau.Text = string_15;
			}
			Class11.smethod_33(ref ThemXoaDanhsach.int_1, num6);
			int num7 = Class71.smethod_3(gstruct42_0, num6);
			if (num7 >= 0)
			{
				GStruct42 gStruct3 = gstruct42_0[num7];
				Class11.smethod_25(ref string_20, gStruct3.int_129 + "==" + gStruct3.string_20);
				Class20.smethod_32(gStruct3.int_130);
				Class71.smethod_1(ref gstruct42_0, gStruct3);
			}
			int num8 = Class71.smethod_10(listView1, num6);
			if (num8 >= 0)
			{
				listView1.Items.RemoveAt(num8);
			}
		}
		if (listView1.Items != null && listView1.Items.Count > 0)
		{
			int num9 = 0;
			do
			{
				if (listView1.Items.Count > int_117)
				{
					int num10 = Class71.smethod_2(listView1, int_117, gstruct42_0);
					if (num10 >= 0)
					{
						GStruct42 gStruct4 = gstruct42_0[num10];
						if (!gStruct4.bool_48 && Class39.int_1 <= 0)
						{
							Class39.int_1 = gStruct4.int_129;
							new Thread(Class39.smethod_25).Start();
						}
						if (!gStruct4.bool_49 && Class39.int_2 <= 0)
						{
							Class39.int_2 = gStruct4.int_129;
							new Thread(Class39.smethod_28).Start();
						}
						if (!gStruct4.bool_55 && gStruct4.int_69[0] > 0 && FormRaovat.int_1 <= 0)
						{
							FormRaovat.int_1 = gStruct4.int_129;
							new Thread(FormRaovat.smethod_0).Start();
						}
						if (!gStruct4.bool_56 && gStruct4.bool_26 && Class23.int_2 <= 0)
						{
							Class23.int_2 = gStruct4.int_129;
							new Thread(Class23.smethod_7).Start();
						}
						if (!Class20.smethod_52(gStruct4.process_0))
						{
							string text9 = "Khác";
							int num11 = Class32.smethod_30(gStruct4);
							int num12 = Class32.smethod_27(gStruct4);
							bool flag = num11 == 0 || num11 == 10 || num11 == 21;
							if (gStruct4.uint_46 != 0 && gStruct4.uint_78 != 0)
							{
								if (num12 > 0)
								{
									if (num11 < Class47.string_18.Length)
									{
										text9 = Class47.string_18[num11];
									}
								}
								else
								{
									text9 = "Out";
								}
							}
							else
							{
								text9 = "HƯ";
								num12 = 12345;
								if (gstruct42_0 != null && gstruct42_0.Length > 1)
								{
									Class20.smethod_53(gStruct4.process_0);
									goto IL_16f8;
								}
								if (!FormTip.bool_0)
								{
									if (int_122 == 0)
									{
										string string_2 = "[" + Class10.smethod_1(gStruct4.string_20, 1) + "] đang chạy trên game hư không dùng được.||Cách xử lý làm theo thứ tự sau:|1. Mở 1 game khác, để đó.|2. Thoát [" + Class10.smethod_1(gStruct4.string_20, 1) + "] và thoát game hư ở trên.|3. Log lại ac ở game vừa mới mở.|4. Xong, xài bình thường.";
										method_2(string_2);
										FormTip.smethod_0(string_1, string_2, 600000, 320, 160, bool_5: false, base.Left, base.Top);
									}
									int_122 = 1;
								}
							}
							if (listView1.Items[int_117].SubItems[1].Text != text9)
							{
								listView1.Items[int_117].SubItems[1].Text = text9;
							}
							int num13 = Class33.smethod_0(gStruct4);
							text9 = ((num12 == 12345) ? "Log ac thứ 2 rồi thóat game và ac này." : ((Class50.smethod_0(num13) == null || Class32.smethod_26(gStruct4) > 0) ? Class10.smethod_1(Class33.smethod_2(gStruct4), 1) : "Hậu doanh"));
							if (listView1.Items[int_117].SubItems[2].Text != text9)
							{
								listView1.Items[int_117].SubItems[2].Text = text9;
							}
							Color color = Color.Black;
							if (num12 > 0)
							{
								if (num12 != 12345)
								{
									if (flag)
									{
										color = Color.Purple;
									}
									else if (gStruct4.int_2 > 0)
									{
										color = Color.DarkCyan;
									}
									else if (gStruct4.bool_60)
									{
										color = Color.DarkGoldenrod;
									}
									else if (gStruct4.int_129 == Class38.gstruct29_0.int_0)
									{
										color = Color.Blue;
									}
									else if (gStruct4.int_129 == Class66.gstruct42_0.int_129)
									{
										color = Color.DarkViolet;
									}
								}
								else
								{
									color = Color.DarkGray;
								}
							}
							else
							{
								color = Color.RoyalBlue;
							}
							if (listView1.Items[int_117].ForeColor != color)
							{
								listView1.Items[int_117].ForeColor = color;
							}
							if (int_117 == int_73 && bool_1)
							{
								uint[] array3 = Class32.smethod_29(gStruct4);
								if (array3 != null)
								{
									textBoxRealPosXY.Text = array3[0].ToString() + "," + array3[1].ToString();
									textBoxScrPosXY.Text = array3[0] / 256u + "," + array3[1] / 512u;
								}
								uint num14 = Class73.smethod_6(gStruct4);
								textBoxRealMouseXY.Text = num14.ToString();
								uint num15 = num14 >> 16;
								uint num16 = num14 - (num15 << 16);
								textBoxScrMouseXY.Text = num16 + "," + num15;
							}
							string text10 = Class73.smethod_12(gStruct4).ToString();
							if (Class38.gstruct29_0.int_0 > 0 && num13 == Class38.gstruct29_0.int_4)
							{
								if (Class38.gstruct29_0.int_0 != gStruct4.int_129)
								{
									uint[] array3 = Class32.smethod_29(gStruct4);
									if (array3 != null)
									{
										long num17 = Class53.smethod_18(array3, Class38.gstruct29_0.uint_4);
										text10 = ((int)Math.Sqrt(num17)).ToString();
									}
								}
								else
								{
									text10 = "0";
								}
							}
							if (listView1.Items[int_117].SubItems[3].Text != text10)
							{
								listView1.Items[int_117].SubItems[3].Text = text10;
							}
							goto IL_16f8;
						}
						string text11 = gStruct4.int_129.ToString() + "==";
						if (string_20 != null)
						{
							for (int j = 0; j < string_20.Length; j++)
							{
								if (Class11.smethod_2(string_20[j], text11) == 0)
								{
									Class11.smethod_24(ref string_19, string_20[j].Replace(text11, ""));
									Class11.smethod_25(ref string_20, string_20[j]);
									break;
								}
							}
						}
						Class71.smethod_1(ref gstruct42_0, gStruct4);
						listView1.Items.RemoveAt(int_117);
						break;
					}
					listView1.Items.RemoveAt(int_117);
					int_117 = 0;
					break;
				}
				int_117 = 0;
				break;
				IL_16f8:
				int_117++;
				num9++;
			}
			while (num9 < 5);
		}
		else
		{
			int_122 = 0;
		}
		if (bool_8)
		{
			while (int_116 < listView1.Items.Count)
			{
				if (listView1.Items[int_116].Checked)
				{
					int_116++;
					continue;
				}
				listView1.Items[int_116].Checked = true;
				break;
			}
			if (listView1.Items.Count <= int_116)
			{
				bool_8 = false;
			}
		}
		if (int_113 != null && int_113.Length > 0 && listView1.Items != null && Class11.smethod_23(long_0) > 4000L)
		{
			int num6 = int_113[0];
			try
			{
				for (int k = 0; k < listView1.Items.Count; k++)
				{
					int count = listView1.Items[k].SubItems.Count;
					int num18 = Class11.smethod_12(listView1.Items[k].SubItems[count - 1].Text);
					if (num6 == num18)
					{
						if (!listView1.Items[k].Checked)
						{
							listView1.Items[k].Checked = true;
						}
						long_0 = Class11.smethod_22();
						break;
					}
				}
			}
			catch
			{
			}
			Class11.smethod_33(ref int_113, num6);
		}
	}

	private void method_8()
	{
		if (gstruct42_0 != null)
		{
			string[] array = new string[2]
			{
				"T A T",
				"B A T"
			};
			if (!bool_11)
			{
				Class23.string_0 = "§ang < " + array[int_30] + " > ®\u00b8nh ng­êi ( F8)";
			}
			else
			{
				Class23.string_0 = "§ang < " + array[int_31] + " > ®\u00b8nh qu\u00b8i ( F7)";
			}
			Class23.int_1 = 5000;
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				try
				{
					if (gstruct42_0[i].bool_36)
					{
						Class32.smethod_9(gstruct42_0[i], 0u);
						int num = 0;
						while (Class23.int_0 > 0 && num < 20)
						{
							Thread.Sleep(10);
							num++;
						}
						Class23.int_0 = gstruct42_0[i].int_129;
						new Thread(Class23.smethod_0).Start();
					}
				}
				catch
				{
				}
			}
		}
	}

	private void buttonAdd_Click(object sender, EventArgs e)
	{
		if (GClass1.string_2 != null && !(GClass1.string_2 == string.Empty))
		{
			if ((bool_0 || int_3 > int_2) && !bool_1)
			{
				GClass1.string_1 = GClass1.string_2;
			}
			else 
            if (!GClass1.bool_1)
			{
				if (int_61 > 0)
				{
					GClass0.smethod_1();
					GClass0.smethod_0();
				}
				if (ThemXoaDanhsach.bool_0)
				{
					ThemXoaDanhsach.bool_0 = false;
				}
				else
				{
					try
					{
						ThemXoaDanhsach themXoaDanhsach = new ThemXoaDanhsach();
						themXoaDanhsach.int_2 = base.Left;
						themXoaDanhsach.int_3 = base.Top;
						themXoaDanhsach.int_4 = base.Width;
						themXoaDanhsach.int_5 = base.Height;
						themXoaDanhsach.Show();
					}
					catch
					{
					}
				}
			}
			else
			{
				buttonAdd.Visible = false;
				buttonAdd.Enabled = false;
				MessageBox.Show("PHÁT HIỆN ĐANG CHẠY PHẦN MỀM NGUY HIỂM, YÊU CẦU KHỞI ĐỘNG LẠI MÁY TÍNH!");
			}
		}
		else
		{
			method_2(Class11.smethod_16("S2jDtG5nIHjDoWMgxJHhu4tuaCDEkcaw4bujYyBwaGnDqm4gYuG6o24gYXV0byDEkWFuZyBz4butIGThu6VuZyBuw6puIGtow7RuZyB0aOG7gyB0aeG6v3AgdOG7pWMuLi4="));
		}
	}

	private void buttonBrowseGame_Click(object sender, EventArgs e)
	{
		string string_ = Class47.string_4;
		string string_2 = string.Empty;
		string text = Class47.smethod_0();
		if (text == null || text == string.Empty)
		{
			text = Class55.smethod_6("PathGame", 0);
		}
		if (text != null && text != string.Empty)
		{
			string[] array = Class11.smethod_15(text);
			string_ = array[0];
			string_2 = array[1];
		}
		string text2 = "Game.exe";
		if (string_4 != null && 0 <= int_0 && int_0 < string_4.GetLength(0))
		{
			text2 = string_4[int_0, 4];
		}
		string text3 = "*.exe|*.exe|Game.exe|Game.exe|Games.exe|Games.exe|vlbs.exe|vlbs.exe|Game.dat|Game.dat";
		if (text2 != null)
		{
			text3 = text2 + "|" + text2 + "|" + text3;
		}
		string text4 = Class47.smethod_24(string_, string_2, "*.exe", text3);
		if (text4 != null && !(text4 == string.Empty))
		{
			string[] array2 = Class11.smethod_15(text4);
			Class47.string_14 = array2[0];
			Class47.string_15 = array2[1];
			Class20.smethod_70(text4, bool_0: false);
			Class55.smethod_10(Class47.string_0, "PathGame", text4, "", 0);
			textBoxThuMuc.Text = text4;
			Class85.string_0 = text4;
		}
	}

	private void buttonToShortcut_Click(object sender, EventArgs e)
	{
		Class20.smethod_73("KY Keoxe");
		method_2("Đã tạo shortcut auto lên desktop.");
	}

	private void buttonThumucAuto_Click(object sender, EventArgs e)
	{
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_1(Class47.char_0));
		Class20.smethod_40(environmentVariable + "\\explorer.exe", Class47.string_4, Class47.string_4, 0);
	}

	private void buttonCapnhatData_Click(object sender, EventArgs e)
	{
		method_9();
	}

	private void method_9()
	{
		int_127 = -1;
		new Thread(method_10).Start();
	}

	public void method_10()
	{
		Class47.smethod_4(Class47.string_17);
		if (int_127 < 0)
		{
			int_127 = 1;
		}
	}

	private void method_11()
	{
		Class47.smethod_6();
		if (int_127 < 0 || !Class47.bool_0)
		{
			int_127 = 1;
		}
	}

	private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_7)
		{
			int_61 = Convert.ToByte(checkBoxPhimTat.Checked);
			Class55.smethod_10(Class47.string_0, "flagPhimtat", int_61, "", 0);
		}
	}

	private void notifyIcon_0_MouseClick(object sender, MouseEventArgs e)
	{
		Show();
		base.WindowState = FormWindowState.Normal;
		notifyIcon_0.Visible = false;
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

	private void buttonDangky_Click(object sender, EventArgs e)
	{
		string text = "Hãy chọn 1 ac trước đã rồi bấm nút!";
		bool flag = false;
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (0 <= num)
		{
			GStruct42 gStruct = gstruct42_0[num];
			string text2 = Class23.smethod_3(gStruct);
			string text3 = Class73.smethod_16(gStruct);
			int[] array = new int[1]
			{
				gStruct.int_129
			};
			GStruct24[] array2 = Class42.smethod_0(array);
			string text4 = string.Empty;
			if (array2 != null)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (gStruct.int_129 == array2[i].int_0 && array2[i].string_2 != null && array2[i].string_2 != string.Empty)
					{
						if (text4 != string.Empty)
						{
							text4 += ",";
						}
						text4 += array2[i].string_2.Replace(" ", string.Empty);
					}
				}
			}
			text = "Tên bang hội:|" + text2 + "|Tên server:|" + text3 + "|" + text4;
			flag = true;
		}
		FormTip.smethod_0("Bang hội", text, 300000, 225, 115, bool_5: false, -1, -1, flag);
		try
		{
			Clipboard.SetText("<3 " + richTextBoxBHO.Text);
		}
		catch
		{
		}
	}

	private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && gstruct42_0 != null && gstruct42_0.Length != 0 && int_73 >= 0 && int_73 < listView1.Items.Count)
		{
			uint_0 = gstruct42_0[int_73].uint_4;
			new Thread(method_13).Start();
		}
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		bool_6 = false;
		if (e.Button == MouseButtons.Right && gstruct42_0 != null && gstruct42_0.Length != 0 && int_73 >= 0 && int_73 < listView1.Items.Count)
		{
			uint_0 = gstruct42_0[int_73].uint_4;
			new Thread(method_12).Start();
		}
	}

	private void method_12()
	{
		uint num = uint_0;
		if (num != 0)
		{
			Class20.ShowWindow(num, Class20.int_20);
			Thread.Sleep(150);
			Class20.ShowWindow(num, Class20.int_18);
		}
	}

	private void method_13()
	{
		uint num = uint_0;
		if (num != 0)
		{
			Class20.ShowWindow(num, Class20.int_21);
			Thread.Sleep(150);
			Class20.ShowWindow(num, Class20.int_19);
			Class20.SetForegroundWindow(num);
		}
	}

	private void method_14()
	{
		uint num = uint_0;
		if (num != 0)
		{
			Class20.ShowWindow(num, Class20.int_20);
		}
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (bool_6)
		{
			e.NewValue = e.CurrentValue;
			return;
		}
		int num = Class71.smethod_9(listView1, e.Index);
		if (num == 0)
		{
			listView1.Items.RemoveAt(e.Index);
			return;
		}
		int num2 = Class71.smethod_3(gstruct42_0, num);
		if (num2 >= 0)
		{
			if (e.NewValue != 0 && Class47.bool_1)
			{
				gstruct42_0[num2].bool_36 = true;
				gstruct42_0[num2].long_6 = Class11.smethod_22();
				Class11.smethod_32(ref Class65.int_1, gstruct42_0[num2].int_129);
			}
			else
			{
				gstruct42_0[num2].bool_36 = false;
				e.NewValue = CheckState.Unchecked;
			}
		}
		else
		{
			listView1.Items.RemoveAt(e.Index);
		}
	}

	private void checkBoxChatNham_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_63 = Convert.ToByte(checkBoxChatNham.Checked);
			Class55.smethod_10(Class47.string_0, "flagChatNhamEx", int_63, "", 0);
		}
	}

	private void textBoxChatNham_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			string_17 = textBoxChatNham.Text;
			Class55.smethod_10(Class47.string_0, "textChatNhams", string_17, "", 0);
		}
	}

	private void buttonCapnhat_Click(object sender, EventArgs e)
	{
		if (TryNewVersion.bool_0)
		{
			TryNewVersion.bool_0 = false;
		}
		else
		{
			try
			{
				TryNewVersion tryNewVersion = new TryNewVersion();
				tryNewVersion.int_1 = base.Left;
				tryNewVersion.int_2 = base.Top;
				tryNewVersion.int_3 = base.Width;
				tryNewVersion.int_4 = base.Height;
				tryNewVersion.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonIDApdung_Click(object sender, EventArgs e)
	{
		string text = textBoxIDSudung.Text;
		if (!(text == string_9))
		{
			string_9 = text.Trim();
			GClass1.int_1 = 2;
			Class55.smethod_10(Class47.string_0, "textIDSudung", string_9, "", 0);
			richTextBoxBHO.Text = "ID [" + string_9 + "] sẽ được sử dụng. Tắt mở lại auto nếu chưa nhận lic mới.";
		}
	}

	private void buttonTrial_Click(object sender, EventArgs e)
	{
		if (!(string_8 == string_9))
		{
			string_9 = string_8;
			GClass1.int_1 = 2;
			Class55.smethod_10(Class47.string_0, "textIDSudung", string_9, "", 0);
			textBoxIDSudung.Text = string_9;
			richTextBoxBHO.Text = "Chưa đăng ký hoặc auto hết hạn sử dụng.";
		}
	}

	private void checkBoxTimAccchinh_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int_21 = Convert.ToByte(checkBoxTimAccchinh.Checked);
		Class55.smethod_10(Class47.string_0, "flagTimAccchinh", int_21, "", 0);
		if (gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (gstruct42_0[i].bool_36)
			{
				Class12.smethod_3(gstruct42_0[i], bool_0: false);
				Class32.smethod_9(gstruct42_0[i], 0u);
			}
		}
	}

	private void checkBoxTimTrongthanh_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int_22 = Convert.ToByte(checkBoxTimTrongthanh.Checked);
		Class55.smethod_10(Class47.string_0, "flagTimtrongthanh", int_22, "", 0);
		if (gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (gstruct42_0[i].bool_36)
			{
				Class12.smethod_3(gstruct42_0[i], bool_0: false);
				Class32.smethod_9(gstruct42_0[i], 0u);
			}
		}
	}

	private void comboBoxAccChinh_MouseDown(object sender, MouseEventArgs e)
	{
		bool_12 = true;
		if (gstruct42_0 != null)
		{
			bool flag = false;
			comboBoxAccChinh.Items.Clear();
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				if (string_14 == Class10.smethod_1(gstruct42_0[i].string_20, 1))
				{
					flag = true;
				}
				comboBoxAccChinh.Items.Add(Class10.smethod_1(gstruct42_0[i].string_20, 1));
			}
			if (!flag && string_14 != string.Empty)
			{
				comboBoxAccChinh.Items.Add(string_14);
			}
			comboBoxAccChinh.Text = string_14;
		}
		bool_12 = false;
	}

	private void comboBoxAccChinh_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_12)
		{
			return;
		}
		string_14 = comboBoxAccChinh.Text;
		if (string_14 != null && !(string_14 == string.Empty) && gstruct42_0 != null && gstruct42_0.Length != 0)
		{
			int num = 0;
			while (true)
			{
				if (num < gstruct42_0.Length)
				{
					if (string_14 == Class10.smethod_1(gstruct42_0[num].string_20, 1))
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			int_52 = gstruct42_0[num].int_129;
		}
		else
		{
			int_52 = 0;
		}
		Class55.smethod_10(Class47.string_0, "AccChinhNameA", Class11.smethod_17(string_14), "", 0);
	}

	private void buttonOff_Click(object sender, EventArgs e)
	{
		long_3 = method_15();
		long_2 = Class11.smethod_22();
	}

	private int method_15()
	{
		if (Class90.gstruct52_0 != null)
		{
			int num = 0;
			do
			{
				num++;
				int_123++;
				if (int_123 < 0 || Class90.gstruct52_0.Length <= int_123)
				{
					int_123 = 0;
				}
				GStruct52 gStruct = Class90.gstruct52_0[int_123];
				if (gStruct.string_0 == null || gStruct.string_0 == string.Empty || gStruct.bool_0)
				{
					continue;
				}
				int num2 = gStruct.int_1;
				if (num2 < 1000)
				{
					num2 = 30000;
				}
				if (gStruct.int_0 > 0)
				{
					richTextBoxStatus.Visible = true;
					pictureBoxQC.Visible = false;
					richTextBoxStatus.Text = gStruct.string_2;
				}
				else
				{
					pictureBoxQC.Visible = true;
					richTextBoxStatus.Visible = false;
					if (pictureBoxQC.ImageLocation != gStruct.string_0)
					{
						pictureBoxQC.ImageLocation = gStruct.string_0;
					}
				}
				return num2;
			}
			while (Class90.gstruct52_0.Length > num);
			return 1000;
		}
		return 3000;
	}

	private void buttonFormTest_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			FormTest.gstruct42_0 = gstruct42_0[num];
		}
		FormTest.bool_1 = true;
		if (!FormTest.bool_0)
		{
			FormTest formTest = new FormTest();
			formTest.int_2 = int_46[0];
			formTest.int_3 = int_46[1];
			formTest.int_0 = base.Left;
			formTest.int_1 = base.Top;
			formTest.Show();
		}
	}

	private void buttonTest_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
		}
	}

	private void checkBoxTuve_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int_30 = Convert.ToByte(checkBoxTuve.Checked);
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				Class32.smethod_9(gstruct42_0[i], 0u);
			}
		}
		Class55.smethod_10(Class47.string_0, "flagDanhnguoi", int_30, "", 0);
	}

	private void checkBoxDanhquai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int_31 = Convert.ToByte(checkBoxDanhquai.Checked);
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				Class32.smethod_9(gstruct42_0[i], 0u);
			}
		}
		Class55.smethod_10(Class47.string_0, "flagDanhquai", int_31, "", 0);
	}

	private void checkBoxUutienDanhquai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int_32 = Convert.ToByte(checkBoxUutienDanhquai.Checked);
		Class55.smethod_10(Class47.string_0, "flagUutienBoss", int_32, "", 0);
		if (int_32 > 0 && int_31 == 0)
		{
			checkBoxDanhquai.Checked = true;
			int_31 = 1;
		}
		checkBoxDanhquai.Enabled = (int_32 == 0);
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				Class32.smethod_9(gstruct42_0[i], 0u);
			}
		}
	}

	private void checkBoxTiepCan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_92 = Convert.ToByte(checkBoxTiepCan.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTamQuet_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_94 = Convert.ToByte(checkBoxTamQuet.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxKhoangCachTiepcan_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		int num2 = Class11.smethod_12(textBoxKhoangCachTiepcan.Text);
		if (num2 >= 1)
		{
			if (num2 > 1000)
			{
				num2 = 1000;
			}
		}
		else
		{
			num2 = 1;
		}
		gstruct42_0[num].int_93 = num2;
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void textBoxPhamvi_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		int num2 = Class11.smethod_12(textBoxPhamvi.Text);
		if (num2 >= 1)
		{
			if (num2 > 1000)
			{
				num2 = 1000;
			}
		}
		else
		{
			num2 = 1;
		}
		gstruct42_0[num].int_95 = num2;
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void checkBoxChetnamIm_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Convert.ToByte(checkBoxChetnamIm.Checked);
		if (int_38 <= 0)
		{
			int num2 = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num2 >= 0)
			{
				gstruct42_0[num2].int_91 = num;
				Class47.smethod_11(gstruct42_0[num2]);
			}
		}
		else
		{
			int_37 = num;
		}
	}

	private void checkBoxNgamyBuff_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_97[0] = Convert.ToByte(checkBoxNgamyBuff.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxNgamyBuff_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_97[3] = Class11.smethod_12(textBoxNgamyBuff.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTimerNgamyBuff_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			int num2 = Class11.smethod_12(textBoxTimerNgamyBuff.Text);
			if (num2 < 100)
			{
				num2 = 100;
			}
			gstruct42_0[num].int_97[4] = num2;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxTuCastBua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_116 = Convert.ToByte(checkBoxTuCastBua.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonCashBua_Click(object sender, EventArgs e)
	{
		if (FormMagic.bool_0)
		{
			FormMagic.bool_0 = false;
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			FormMagic.int_0 = gstruct42_0[num].int_129;
			FormMagic.string_0 = Class67.smethod_18(gstruct42_0[num]);
			new FormMagic().Show();
		}
	}

	private void buttonLoaitruAccBuff_Click(object sender, EventArgs e)
	{
		if (Loaitru.bool_0)
		{
			Loaitru.bool_0 = false;
		}
		else
		{
			try
			{
				Loaitru loaitru = new Loaitru();
				loaitru.int_0 = Cursor.Position.X;
				loaitru.int_1 = Cursor.Position.Y;
				loaitru.int_2 = base.Width;
				loaitru.int_3 = base.Height;
				loaitru.Show();
			}
			catch
			{
			}
		}
	}

	private void comboBoxNhatdo_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxNhatdo.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_21.Length)
			{
				if (string_21[num2] == text)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].int_63 = num2;
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void checkBoxNhatdo_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_38 = Convert.ToByte(checkBoxNhatdo.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxAccDoiMau_MouseDown(object sender, MouseEventArgs e)
	{
		if (gstruct42_0 == null)
		{
			return;
		}
		bool_12 = true;
		bool flag = false;
		string text = comboBoxAccDoiMau.Text;
		comboBoxAccDoiMau.Items.Clear();
		comboBoxAccDoiMau.Items.Add("...");
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (text == Class10.smethod_1(gstruct42_0[i].string_20, 1))
			{
				flag = true;
			}
			comboBoxAccDoiMau.Items.Add(Class10.smethod_1(gstruct42_0[i].string_20, 1));
		}
		if (!flag && text != "" && text != "...")
		{
			comboBoxAccDoiMau.Items.Add(text);
		}
		comboBoxAccDoiMau.Text = text;
		bool_12 = false;
	}

	private void comboBoxAccDoiMau_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_12)
		{
			return;
		}
		string_15 = "...";
		string text = comboBoxAccDoiMau.Text;
		switch (text)
		{
		default:
			if (gstruct42_0 != null && gstruct42_0.Length != 0)
			{
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					if (text == Class10.smethod_1(gstruct42_0[i].string_20, 1))
					{
						if (gstruct42_1.int_129 > 0 && gstruct42_1.uint_28 != 0)
						{
							Class20.smethod_2(gstruct42_1.int_130, gstruct42_1.uint_28);
						}
						gstruct42_0[i].uint_28 = 0u;
						gstruct42_1 = gstruct42_0[i];
						string_15 = Class10.smethod_1(gstruct42_0[i].string_20, 1);
						break;
					}
				}
				break;
			}
			goto case null;
		case null:
		case "":
		case "...":
		{
			if (gstruct42_1.int_129 > 0 && gstruct42_1.uint_28 != 0)
			{
				Class20.smethod_2(gstruct42_1.int_130, gstruct42_1.uint_28);
			}
			GStruct42 gStruct = default(GStruct42);
			gStruct.int_129 = 0;
			gStruct.uint_28 = 0u;
			gstruct42_1 = gStruct;
			break;
		}
		}
		Class55.smethod_10(Class47.string_0, "TenAccdoiMau", Class11.smethod_17(string_15), "", 0);
	}

	private void comboBoxUuTien_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = -1;
		string text = comboBoxUuTien.Text;
		for (int i = 0; i < string_23.Length; i++)
		{
			if (text == string_23[i])
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		int num2 = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num2 >= 0)
		{
			if (num <= 0)
			{
				buttonUuTien.Text = "Áp dụng";
			}
			else
			{
				buttonUuTien.Text = "Ưu tiên";
			}
			gstruct42_0[num2].int_86 = num;
			Class47.smethod_11(gstruct42_0[num2]);
		}
	}

	private void checkBoxMangtheotien_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_66 = Convert.ToByte(checkBoxMangtheotien.Checked);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTienMangtheo_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_67 = Class11.smethod_12(textBoxTienMangtheo.Text);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxPass_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].string_13 = textBoxPass.Text;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxMua1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_70[0] = Convert.ToByte(checkBoxMua1.Checked);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void method_16(ComboBox comboBox_0)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		GStruct42 gStruct = gstruct42_0[num];
		string_16 = new string[18]
		{
			"Ngò Hoa Ngäc Lé Hoµn",
			"Cöu ChuyÓn Hoµn Hån ®an",
			"Håi Thiªn ®an",
			"Kim S\u00b8ng D­îc (®¹i)",
			"Kim S\u00b8ng D­îc (trung)",
			"Kim S\u00b8ng D­îc (tiÓu)",
			"¤ ®Çu Hoµn thÇn ®an",
			"§¹i Bæ t\u00b8n",
			"Ng­ng ThÇn ®an (®¹i)",
			"Ng­ng ThÇn ®an (trung)",
			"Ng­ng ThÇn ®an (tiÓu)",
			"Thõa Tiªn MËt (trung)",
			"Thõa Tiªn MËt (tiÓu)",
			"Tam Hoa T\u00b8n",
			"Ho¾c H­¬ng ChÝnh khÝ hoµn",
			"Tam ThuËn t\u00b8n",
			"Ng©n KiÒu Khø ®éc ®an",
			"Long §µm Hãa §éc ®an"
		};
		bool flag = false;
		for (int i = 0; i < string_16.Length; i++)
		{
			if (string_16[i] == gStruct.string_9)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Array.Resize(ref string_16, string_16.Length + 1);
			string_16[string_16.Length - 1] = gStruct.string_9;
		}
		flag = false;
		for (int i = 0; i < string_16.Length; i++)
		{
			if (string_16[i] == gStruct.string_10)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Array.Resize(ref string_16, string_16.Length + 1);
			string_16[string_16.Length - 1] = gStruct.string_10;
		}
		flag = false;
		for (int i = 0; i < string_16.Length; i++)
		{
			if (string_16[i] == gStruct.string_11)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Array.Resize(ref string_16, string_16.Length + 1);
			string_16[string_16.Length - 1] = gStruct.string_11;
		}
		GStruct42 gStruct2 = gStruct;
		int[] array = new int[1];
		Class69.smethod_30(gStruct2, ref string_16, 3, array);
		Array.Sort(string_16);
		bool_7 = false;
		string text = null;
		string text2 = comboBox_0.Text;
		comboBox_0.Items.Clear();
		for (int i = 0; i < string_16.Length; i++)
		{
			string text3 = Class10.smethod_1(string_16[i], 1);
			comboBox_0.Items.Add(text3);
			if (text2 == text3)
			{
				text = text2;
			}
		}
		if (text2 != null && text2 != string.Empty && text == null)
		{
			comboBox_0.Items.Add(text2);
			text = text2;
		}
		comboBox_0.Text = text;
		Thread.Sleep(10);
		bool_7 = true;
	}

	private void comboBoxMua1_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			method_16(comboBoxMua1);
		}
	}

	private void comboBoxMua1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_16 == null)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxMua1.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_16.Length)
			{
				if (text == Class10.smethod_1(string_16[num2], 1))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].string_9 = string_16[num2];
		gstruct42_0[num].bool_27 = true;
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void textBoxSoluong1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_70[2] = Class11.smethod_12(textBoxSoluong1.Text);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxMua2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_71[0] = Convert.ToByte(checkBoxMua2.Checked);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxMua2_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			method_16(comboBoxMua2);
		}
	}

	private void comboBoxMua2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_16 == null)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxMua2.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_16.Length)
			{
				if (text == Class10.smethod_1(string_16[num2], 1))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].string_10 = string_16[num2];
		gstruct42_0[num].bool_27 = true;
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void textBoxSoluong2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_71[2] = Class11.smethod_12(textBoxSoluong2.Text);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxMuaTDP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_53[0] = Convert.ToByte(checkBoxMuaTDP.Checked);
			Class55.smethod_10(Class47.string_0, "flagMuaTDP_0", int_53[0], "", 0);
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (0 <= num)
			{
				gstruct42_0[num].bool_27 = true;
			}
		}
	}

	private void textBoxSoluongTDP_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_53[1] = Class11.smethod_12(textBoxSoluongTDP.Text);
			Class55.smethod_10(Class47.string_0, "flagMuaTDP_1", int_53[1], "", 0);
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (0 <= num)
			{
				gstruct42_0[num].bool_27 = true;
			}
		}
	}

	private void textBoxSoluongThuocDimua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_54 = Class11.smethod_12(textBoxSoluongThuocDimua.Text);
			Class55.smethod_10(Class47.string_0, "ValueThuocDimua", int_54, "", 0);
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (0 <= num)
			{
				gstruct42_0[num].bool_27 = true;
			}
		}
	}

	private void checkBoxBomHP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_106[0] = Convert.ToByte(checkBoxBomHP.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxHPBom_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_106[1] = Class11.smethod_12(textBoxHPBom.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxThoigianBomHP_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_106[2] = Class11.smethod_12(textBoxThoigianBomHP.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxSoluongBomHP_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			int num2 = Class11.smethod_12(textBoxSoluongBomHP.Text);
			if (num2 < 0 || num2 > 60)
			{
				num2 = 1;
			}
			gstruct42_0[num].int_106[3] = num2;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxMPBom_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_108[0] = Convert.ToByte(checkBoxMPBom.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxMPBom_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_108[1] = Class11.smethod_12(textBoxMPBom.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxThoigianBomMP_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_108[2] = Class11.smethod_12(textBoxThoigianBomMP.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxSoluongBomMP_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			int num2 = Class11.smethod_12(textBoxSoluongBomMP.Text);
			if (num2 < 0 || num2 > 60)
			{
				num2 = 1;
			}
			gstruct42_0[num].int_108[3] = num2;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxBomHPDiem_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_103[0] = Convert.ToByte(checkBoxBomHPDiem.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxBomHPDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_103[1] = Class11.smethod_12(textBoxBomHPDiem.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxThoiGianBomHPDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_103[2] = Class11.smethod_12(textBoxThoiGianBomHPDiem.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxSoLuongBomHPDiem_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			int num2 = Class11.smethod_12(textBoxSoLuongBomHPDiem.Text);
			if (num2 < 0 || num2 > 60)
			{
				num2 = 1;
			}
			gstruct42_0[num].int_103[3] = num2;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxBomMPDiem_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_104[0] = Convert.ToByte(checkBoxBomMPDiem.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxBomMPDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_104[1] = Class11.smethod_12(textBoxBomMPDiem.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxThoiGianBomMPDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_104[2] = Class11.smethod_12(textBoxThoiGianBomMPDiem.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxSoLuongBomMPDiem_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			int num2 = Class11.smethod_12(textBoxSoLuongBomMPDiem.Text);
			if (num2 < 0 || num2 > 60)
			{
				num2 = 1;
			}
			gstruct42_0[num].int_104[3] = num2;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxHPTdp_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_110[0] = Convert.ToByte(checkBoxHPTdp.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxHpTDP_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_110[1] = Class11.smethod_12(textBoxHpTDP.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxMPTdp_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_111[0] = Convert.ToByte(checkBoxMPTdp.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxMPTdp_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_111[1] = Class11.smethod_12(textBoxMPTdp.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonTatcaLuuruong_Click(object sender, EventArgs e)
	{
		Class38.gstruct29_0.int_9 = 103;
		if (gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (gstruct42_0[i].bool_36)
			{
				gstruct42_0[i].bool_29 = true;
			}
		}
	}

	private void buttonTatcaTDP_Click(object sender, EventArgs e)
	{
		Class38.gstruct29_0.int_9 = 104;
		if (gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (gstruct42_0[i].bool_36)
			{
				Class53.smethod_13(gstruct42_0[i]);
			}
		}
	}

	private void buttonBungThuoc_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			if (gstruct42_0[num].uint_11 == 0)
			{
				gstruct42_0[num].uint_12 = 0u;
				gstruct42_0[num].uint_11 = Class20.smethod_1(gstruct42_0[num].int_130);
				if (gstruct42_0[num].uint_11 == 0)
				{
					return;
				}
				Class60.smethod_8(ref gstruct42_0[num]);
			}
			GStruct42 gStruct = gstruct42_0[num];
			string[,] array = new string[5, 3]
			{
				{
					"Ngò Hoa Ngäc Lé Hoµn",
					"Thõa Tiªn MËt",
					null
				},
				{
					"Cöu ChuyÓn Hoµn Hån ®an",
					"Håi Thiªn ®an",
					"Kim S\u00b8ng D­îc"
				},
				{
					"¤ ®Çu Hoµn thÇn ®an",
					"§¹i Bæ t\u00b8n",
					"Ng­ng ThÇn ®an"
				},
				{
					"Ng©n KiÒu Khø ®éc ®an",
					"Ho¾c H­¬ng ChÝnh khÝ hoµn",
					null
				},
				{
					"Tam Hoa T\u00b8n",
					null,
					null
				}
			};
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i, j] != null)
					{
						uint num2 = Class69.smethod_27(gStruct, array[i, j], bool_1: false, 3u, bool_2: true);
						if (num2 != 0)
						{
							Class60.smethod_99(gStruct, num2);
							Thread.Sleep(300);
							break;
						}
					}
				}
			}
		}
		else
		{
			FormTip.smethod_0(string_1, "Hãy chọn 1 ac rồi bấm nút < Bung thuốc > này.", 60000, 250, 100);
		}
	}

	private void buttonSuadoTaicho_Click(object sender, EventArgs e)
	{
		if (int_128 == 0)
		{
			int_128 = 1;
		}
	}

	private void method_17()
	{
		int_128 = 2;
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				if (gstruct42_0[i].bool_36)
				{
					Class60.smethod_50(gstruct42_0[i], "§ang kiÓm tra söa ®å tÊt c¶.");
					Class53.smethod_12(gstruct42_0[i], null, 0, 0);
				}
			}
		}
		Thread.Sleep(1000);
		int_128 = 3;
	}

	private void buttonComboNhoithuoc_Click(object sender, EventArgs e)
	{
		if (Combo.bool_0)
		{
			Combo.bool_0 = false;
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			FormTip.smethod_0(string_1, "Hãy chọn 1 ac rồi bấm nút Combox này.", 60000, 250, 100);
		}
		else
		{
			try
			{
				Combo combo = new Combo();
				combo.int_0 = base.Left;
				combo.int_1 = base.Top;
				combo.int_2 = base.Width;
				combo.int_3 = base.Height;
				combo.gstruct42_0 = default(GStruct42);
				combo.gstruct42_0 = gstruct42_0[num];
				combo.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxAccPhuHauDoanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_84 = Convert.ToByte(checkBoxAccPhuHauDoanh.Checked);
			Class55.smethod_10(Class47.string_0, "flagAccPhuChoAccChinh", int_84, "", 0);
		}
	}

	private void checkBoxAccChinhHauDoanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_83 = Convert.ToByte(checkBoxAccChinhHauDoanh.Checked);
			Class55.smethod_10(Class47.string_0, "flagAccChinhRoiHauDoanh", int_83, "", 0);
		}
	}

	private void checkBoxNguHoa500l_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int_91 = Convert.ToByte(checkBoxNguHoa500l.Checked);
		Class55.smethod_10(Class47.string_0, "flagMuaNguHoa500l", int_91, "", 0);
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				gstruct42_0[i].bool_27 = true;
			}
		}
	}

	private void comboBoxBentau_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		string text = comboBoxBentau.Text;
		for (int i = 0; i < string_27.Length; i++)
		{
			if (text == string_27[i])
			{
				int_98 = i;
				break;
			}
		}
		Class55.smethod_10(Class47.string_0, "flagIndexBentau", int_98, "", 0);
	}

	private void buttonNopLenhbai_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			if (int_98 == 6)
			{
				int num2 = 0;
				string text = null;
				int num3 = Class76.smethod_1(gstruct42_0[num]);
				if (num3 >= 0)
				{
					if (num3 >= 1)
					{
						num2 = Class76.Class78.smethod_0(gstruct42_0[num]);
						if (num2 > 0)
						{
							for (int i = 0; i < num2; i++)
							{
								if (text != null)
								{
									text += Class47.string_3;
								}
								text += Class76.smethod_3(gstruct42_0[num], i, 1);
							}
						}
					}
					num2 = Class76.Class77.smethod_0(gstruct42_0[num]);
					if (num3 != 1 && num2 > 0)
					{
						for (int i = 0; i < num2; i++)
						{
							if (text != null)
							{
								text += Class47.string_3;
							}
							text += Class76.smethod_3(gstruct42_0[num], i, 0);
						}
					}
				}
				string text2 = string_1;
				if (text == null)
				{
					text = "Không có menu text nào. Bạn hãy click vào xa phu rồi bấm nút này để lấy menu.";
				}
				else
				{
					Clipboard.SetText(text);
					text2 = "ĐÃ COPY VÀO CLIBOARD";
				}
				FormTip.smethod_0(text2, text, 9999999, 300, 160);
			}
			else if (!gstruct42_0[num].bool_36)
			{
				FormTip.smethod_0(string_1, "Hãy stick vào ac rồi bấm nút lệnh này.", 4000, 250, 80);
			}
			else
			{
				if (int_20 != 0 || gstruct42_0[num].bool_21)
				{
					return;
				}
				if (int_98 > 2)
				{
					if (int_98 != 3 && int_98 != 4)
					{
						if (int_98 == 5)
						{
							FormClickNPC.int_11 = gstruct42_0[num].int_129;
							new Thread(FormClickNPC.smethod_2).Start();
						}
					}
					else
					{
						gstruct42_0[num].bool_61 = gstruct42_0[num].bool_36;
					}
				}
				else
				{
					Class11.smethod_32(ref Class36.int_0, gstruct42_0[num].int_129);
					if (!Class36.bool_0)
					{
						Class36.smethod_0();
					}
				}
			}
		}
		else
		{
			FormTip.smethod_0(string_1, "Hãy chọn 1 ac rồi bấm nút lệnh này.", 4000, 250, 80);
		}
	}

	private void buttonNopLenhbaiAll_Click(object sender, EventArgs e)
	{
		if (int_20 != 0 || gstruct42_0 == null)
		{
			return;
		}
		if (int_98 <= 2)
		{
			bool flag = false;
			Class38.gstruct29_0.int_9 = 100 + int_98;
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				if (!gstruct42_0[i].bool_21 && gstruct42_0[i].bool_36)
				{
					Class11.smethod_32(ref Class36.int_0, gstruct42_0[i].int_129);
					flag = true;
				}
			}
			if (flag && !Class36.bool_0)
			{
				Class36.smethod_0();
			}
		}
		else if (int_98 != 3 && int_98 != 4)
		{
			if (int_98 == 5)
			{
				Class38.gstruct29_0.int_9 = int_98;
				new Thread(FormClickNPC.smethod_1).Start();
			}
		}
		else
		{
			Class38.gstruct29_0.int_9 = int_98;
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				gstruct42_0[i].bool_61 = gstruct42_0[i].bool_36;
			}
		}
	}

	private void buttonVaotraiStop_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			gstruct42_0[num].bool_21 = false;
			gstruct42_0[num].bool_61 = false;
		}
	}

	private void buttonVaotraiStopAll_Click(object sender, EventArgs e)
	{
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				gstruct42_0[i].bool_21 = false;
				gstruct42_0[i].bool_61 = false;
			}
		}
	}

	private void buttonThongke_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_3(gstruct42_0, Class66.int_0);
		if (num < 0)
		{
			num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num < 0)
			{
				FormTip.smethod_0(string_1, "Chọn 1 ac rồi bấm nút Thống kê.", 600000, 200, 120);
				return;
			}
		}
		if (gstruct42_0[num].uint_11 == 0)
		{
			gstruct42_0[num].uint_12 = 0u;
			gstruct42_0[num].uint_11 = Class20.smethod_1(gstruct42_0[num].int_130);
			if (gstruct42_0[num].uint_11 == 0)
			{
				return;
			}
			Class60.smethod_8(ref gstruct42_0[num]);
		}
		Class5 @class = new Class5();
		@class.gstruct42_0 = gstruct42_0[num];
		@class.string_0 = null;
		new Thread(@class.method_2).Start();
	}

	private void buttonApDungMuaThuocAll_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		if (gstruct42_0[num].int_74 == null)
		{
			gstruct42_0[num].int_74 = new int[5];
		}
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (i != num)
			{
				int num2 = gstruct42_0[num].int_70.Length;
				gstruct42_0[i].int_70 = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					gstruct42_0[i].int_70[j] = gstruct42_0[num].int_70[j];
				}
				int num3 = gstruct42_0[num].int_71.Length;
				gstruct42_0[i].int_71 = new int[num3];
				for (int j = 0; j < num3; j++)
				{
					gstruct42_0[i].int_71[j] = gstruct42_0[num].int_71[j];
				}
				int num4 = gstruct42_0[num].int_72.Length;
				for (int j = 0; j < num4; j++)
				{
					gstruct42_0[i].int_72[j] = gstruct42_0[num].int_72[j];
				}
				gstruct42_0[i].string_9 = gstruct42_0[num].string_9;
				gstruct42_0[i].string_10 = gstruct42_0[num].string_10;
				gstruct42_0[i].string_11 = gstruct42_0[num].string_11;
				gstruct42_0[i].int_101 = gstruct42_0[num].int_101;
				gstruct42_0[i].int_102 = gstruct42_0[num].int_102;
				gstruct42_0[i].int_67 = gstruct42_0[num].int_67;
				gstruct42_0[i].int_76 = gstruct42_0[num].int_76;
				gstruct42_0[i].int_74 = new int[gstruct42_0[num].int_74.Length];
				for (int k = 0; k < gstruct42_0[num].int_74.Length; k++)
				{
					gstruct42_0[i].int_74[k] = gstruct42_0[num].int_74[k];
				}
				for (int k = 0; k < gstruct42_0[num].int_75.Length; k++)
				{
					gstruct42_0[i].int_75[k] = gstruct42_0[num].int_75[k];
				}
				gstruct42_0[i].string_12 = gstruct42_0[num].string_12;
				gstruct42_0[i].bool_27 = true;
				Class47.smethod_11(gstruct42_0[i]);
			}
		}
	}

	private void buttonAppDungBomMauAll_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (i != num)
			{
				for (int j = 0; j < gstruct42_0[num].int_106.Length; j++)
				{
					gstruct42_0[i].int_106[j] = gstruct42_0[num].int_106[j];
				}
				for (int j = 0; j < gstruct42_0[num].int_107.Length; j++)
				{
					gstruct42_0[i].int_107[j] = gstruct42_0[num].int_107[j];
				}
				for (int j = 0; j < gstruct42_0[num].int_108.Length; j++)
				{
					gstruct42_0[i].int_108[j] = gstruct42_0[num].int_108[j];
				}
				for (int j = 0; j < gstruct42_0[num].int_109.Length; j++)
				{
					gstruct42_0[i].int_109[j] = gstruct42_0[num].int_109[j];
				}
				for (int j = 0; j < gstruct42_0[num].int_103.Length; j++)
				{
					gstruct42_0[i].int_103[j] = gstruct42_0[num].int_103[j];
				}
				for (int j = 0; j < gstruct42_0[num].int_104.Length; j++)
				{
					gstruct42_0[i].int_104[j] = gstruct42_0[num].int_104[j];
				}
				for (int j = 0; j < gstruct42_0[num].int_110.Length; j++)
				{
					gstruct42_0[i].int_110[j] = gstruct42_0[num].int_110[j];
				}
				for (int j = 0; j < gstruct42_0[num].int_111.Length; j++)
				{
					gstruct42_0[i].int_111[j] = gstruct42_0[num].int_111[j];
				}
				for (int j = 0; j < gstruct42_0[num].int_100.Length; j++)
				{
					gstruct42_0[i].int_100[j] = gstruct42_0[num].int_100[j];
				}
				gstruct42_0[i].int_105 = gstruct42_0[num].int_105;
				gstruct42_0[i].string_14 = gstruct42_0[num].string_14;
				gstruct42_0[i].string_15 = gstruct42_0[num].string_15;
				gstruct42_0[i].int_112 = gstruct42_0[num].int_112;
				gstruct42_0[i].int_113 = gstruct42_0[num].int_113;
				gstruct42_0[i].int_114 = gstruct42_0[num].int_114;
				gstruct42_0[i].int_115 = gstruct42_0[num].int_115;
				gstruct42_0[i].int_60 = gstruct42_0[num].int_60;
				Class47.smethod_11(gstruct42_0[i]);
			}
		}
	}

	private void checkBoxTuGiaidoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_73[0] = Convert.ToByte(checkBoxTuGiaidoc.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTimerBomMagic_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			int num2 = Class11.smethod_12(textBoxTimerBomMagic.Text);
			if (num2 < 1000 || num2 > 15000)
			{
				num2 = 1000;
			}
			gstruct42_0[num].int_73[1] = num2;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void textBoxSoluongBomMagic_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			int num2 = Class11.smethod_12(textBoxSoluongBomMagic.Text);
			if (num2 < 1 || num2 > 60)
			{
				num2 = 1;
			}
			gstruct42_0[num].int_73[2] = num2;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxMuaGiaiDoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_72[0] = Convert.ToByte(checkBoxMuaGiaiDoc.Checked);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxSoluongMuaGiaiDoc_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_72[2] = Class11.smethod_12(textBoxSoluongMuaGiaiDoc.Text);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxMuaGiaiDoc_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			method_16(comboBoxMuaGiaiDoc);
		}
	}

	private void comboBoxMuaGiaiDoc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_16 == null)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxMuaGiaiDoc.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_16.Length)
			{
				if (text == Class10.smethod_1(string_16[num2], 1))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].string_11 = string_16[num2];
		gstruct42_0[num].bool_27 = true;
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void checkBoxMuaKTC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_76 = Convert.ToByte(checkBoxMuaKTC.Checked);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxIndex_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = -1;
		string text = comboBoxIndex.Text;
		for (int i = 0; i < string_10.Length; i++)
		{
			if (text == string_10[i])
			{
				num = i;
				break;
			}
		}
		bool_3 = false;
		buttonTatMua.BackColor = Color.LightSteelBlue;
		buttonTatMua.ForeColor = Color.DarkRed;
		buttonTatMua.Text = "Tắt mua tất cả ac";
		int_20 = num;
		checkBoxChienLongdong.Enabled = (num == 0);
		checkBoxTubaoDanh.Enabled = (int_20 == 1);
		Class55.smethod_10(Class47.string_0, "IndexPK", int_20, "", 0);
		string text2 = null;
		if (int_20 != 0)
		{
			if (int_20 == 1)
			{
				text2 = "Chế độ TK dùng để đánh Tống Kim và Phong Hỏa liên thành.";
			}
			else if (int_20 != 2)
			{
				if (int_20 == 3)
				{
					text2 = "Chế độ ĐƠN ĐẤU: tối ưu tốc độ đánh (chỉ có đánh và bơm máu), thường dùng trong liên đấu. Chế độ này auto không tự mua máu, không tìm ac...";
				}
			}
			else
			{
				text2 = "Chế độ CTC dùng để đánh Chiến trường Công thành chiến (thất thành và tam trụ)";
			}
		}
		else
		{
			text2 = "Chế độ WAR dùng để đánh ở thành thị, sơn động, map train...";
		}
		if (text2 != null)
		{
			Class11.string_14 = new string[1]
			{
				text2
			};
		}
	}

	private void buttonVang_Click(object sender, EventArgs e)
	{
		method_18(1u);
	}

	private void buttonXanh_Click(object sender, EventArgs e)
	{
		method_18(3u);
	}

	private void buttonTim_Click(object sender, EventArgs e)
	{
		method_18(2u);
	}

	private void method_18(uint uint_1)
	{
		if (gstruct42_1.int_129 <= 0)
		{
			method_2("Đổi màu bang: Qua Phụ trợ chọn tên ac đổi màu.");
			return;
		}
		if (!bool_13)
		{
			bool_13 = (GClass1.smethod_5(gstruct42_1) > 0);
			if (!bool_13)
			{
				return;
			}
		}
		Class23.smethod_4(gstruct42_1, uint_1);
	}

	private void checkBoxGiamRamTudong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_62 = Convert.ToByte(checkBoxGiamRamTudong.Checked);
			Class14.bool_0 = (int_62 > 0);
			Class55.smethod_10(Class47.string_0, "flagGiamRamtudong", int_62, "", 0);
			new Thread(new Class14().method_0).Start();
		}
	}

	private void comboBoxGameOfWeb_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		string text = comboBoxGameOfWeb.Text;
		string a = null;
		for (int i = 0; i < string_4.GetLength(0); i++)
		{
			if (text == string_4[i, 0])
			{
				if (int_0 != i)
				{
					int_0 = i;
					int_119 = i;
					string_3 = string_4[i, 0];
					a = string_3;
					Class55.smethod_10(Class47.string_0, "TenWeb", string_3, "", 0);
					method_19();
				}
				break;
			}
		}
		Class16.int_1 = -1;
		if (a == "volamtieudieu.com")
		{
			Class11.string_14 = new string[1]
			{
				"FORM:Game của web này sử dụng 2 loại Thần Hành Phù:||- Loại 1: có dòng 'Sử dụng thuật thần hành có thể đưa...'|- Loại 2: có dòng 'Thành thị --- Thôn trang'||Auto chỉ sử dụng được loại 1, các bác hủy hoặc cất loại 2 vào rương đi nhé kẻo auto dùng nhầm."
			};
		}
	}

	private void method_19()
	{
		int num = -1;
		for (int i = 0; i < string_4.GetLength(0); i++)
		{
			if (string_3 == string_4[i, 0])
			{
				num = i;
				break;
			}
		}
		if (num >= 0)
		{
			Class16.int_1 = -1;
			Class31.int_1 = Class11.smethod_12(string_4[num, 2]);
			Class31.smethod_57();
			string text = string_4[num, 3];
			if (text != null && !(text == string.Empty))
			{
				int_103 = Class11.smethod_12(text);
				Class55.smethod_10(Class47.string_0, "IdexMenuTHPChientruong", int_103, "", 0);
				numericUpDownCTC.Value = int_103;
				string a = string_4[num, 5];
				if (a == "0" || a == "1")
				{
					int num2 = Class11.smethod_12(a);
					bool_7 = false;
					checkBoxTHPCTC.Checked = (num2 > 0);
					Thread.Sleep(60);
					int_99 = num2;
					Class55.smethod_10(Class47.string_0, "flagTHPCTC", int_99, "", 0);
					bool_7 = true;
				}
			}
			else
			{
				int_99 = 0;
				checkBoxTHPCTC.Checked = false;
			}
		}
		else
		{
			method_2("Không thể cập nhật thần hành phù.");
		}
	}

	private void checkBoxGanChieuTrai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			gstruct42_0[num].int_131[0] = Convert.ToByte(checkBoxGanChieuTrai.Checked);
			Class47.smethod_11(gstruct42_0[num]);
			if (gstruct42_0[num].int_131[0] > 0 && gstruct42_0[num].int_131[1] > 0)
			{
				Class67.smethod_14(gstruct42_0[num], (uint)gstruct42_0[num].int_131[1]);
				Class60.smethod_29(gstruct42_0[num], (uint)gstruct42_0[num].int_131[1]);
			}
		}
	}

	private void checkBoxGanChieuPhai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			gstruct42_0[num].int_132[0] = Convert.ToByte(checkBoxGanChieuPhai.Checked);
			Class47.smethod_11(gstruct42_0[num]);
			if (gstruct42_0[num].int_132[0] > 0 && gstruct42_0[num].int_132[1] > 0)
			{
				Class67.smethod_14(gstruct42_0[num], (uint)gstruct42_0[num].int_132[1], bool_1: true);
				Class60.smethod_30(gstruct42_0[num], (uint)gstruct42_0[num].int_132[1]);
			}
		}
	}

	private void comboBoxGanChieuTrai_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxGanChieuTrai.Text;
		if (gstruct42_0[num].gstruct36_0 == null)
		{
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < gstruct42_0[num].gstruct36_0.Length)
			{
				if (text == gstruct42_0[num].gstruct36_0[num2].string_0)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].int_131[1] = gstruct42_0[num].gstruct36_0[num2].int_1;
		if (gstruct42_0[num].int_131[0] > 0)
		{
			Class67.smethod_14(gstruct42_0[num], (uint)gstruct42_0[num].gstruct36_0[num2].int_1);
			Class60.smethod_29(gstruct42_0[num], (uint)gstruct42_0[num].gstruct36_0[num2].int_1);
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void comboBoxGanChieuPhai_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxGanChieuPhai.Text;
		if (gstruct42_0[num].gstruct36_0 == null)
		{
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < gstruct42_0[num].gstruct36_0.Length)
			{
				if (text == gstruct42_0[num].gstruct36_0[num2].string_0)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].int_132[1] = gstruct42_0[num].gstruct36_0[num2].int_1;
		if (gstruct42_0[num].int_132[0] > 0)
		{
			Class67.smethod_14(gstruct42_0[num], (uint)gstruct42_0[num].gstruct36_0[num2].int_1, bool_1: true);
			Class60.smethod_30(gstruct42_0[num], (uint)gstruct42_0[num].gstruct36_0[num2].int_1);
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxTrinhSat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_85 = Convert.ToByte(checkBoxTrinhSat.Checked);
			Class55.smethod_10(Class47.string_0, "flagRabangTrinhsat", int_85, "", 0);
		}
	}

	private void buttonGiaiThichHaucan_Click(object sender, EventArgs e)
	{
		string text = "- Ô bên trái là chỉ số % hoặc điểm.|- Ô bên phải là số lượng bình thuốc ăn một lần.|- Ô ở giữa là thời gian (mili giây) giữa 2 lần sử dụng thuốc.||Ví dụ mục Tự ăn giải độc, bạn ghi 4500 và 2. Thì khi dính độc, ac sẽ ăn 2 bình, sau đó chờ 4,5 giây (nếu còn dính độc) thì lại ăn tiếp 2 bình...||Mục <Gán thiết lập chung cho tất cả> là chỉ cần thiết lập cho 1 acc, rồi bấm nút này thì tất cả các ac còn lại sẽ có thiết lập giống y chang ac này.";
		FormTip.smethod_0("HAU CAN BOM THUOC", text, 999000, 370, 210, bool_5: false, Cursor.Position.X, Cursor.Position.Y - 210);
		string text2 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(text2))
		{
			text2 = Class55.smethod_0();
		}
		Class20.smethod_40(text2, "", "http://kimyen.net/phuchoi.htm", 0);
	}

	private void checkBoxAnThuocLag_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_64 = Convert.ToByte(checkBoxAnThuocLag.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTheoSau_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		if (checkBoxTheoSau.Checked && FormMayphu.bool_3)
		{
			FormTip.smethod_0(string_1, Class11.smethod_1(Class11.char_11), 60000, 250, 100);
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			gstruct42_0[num].int_68[0] = Convert.ToByte(checkBoxTheoSau.Checked && !FormMayphu.bool_3);
			labelTheoSauAll.Enabled = true;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void comboBoxTheoSau_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTheoSau.Text;
		if (string_30 != null)
		{
			for (int i = 0; i < string_30.Length; i++)
			{
				if (Class10.smethod_1(string_30[i], 1) == text)
				{
					gstruct42_0[num].string_7 = string_30[i];
					Class47.smethod_11(gstruct42_0[num]);
					break;
				}
			}
		}
		labelTheoSauAll.Enabled = true;
	}

	private void textBoxKhoangCachTheoSau_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_68[1] = Class11.smethod_12(textBoxKhoangCachTheoSau.Text);
				labelTheoSauAll.Enabled = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void labelTheoSauAll_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		if (FormMayphu.bool_3)
		{
			FormTip.smethod_0(string_1, Class11.smethod_1(Class11.char_11), 600000, 250, 80);
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		GStruct42 gStruct = gstruct42_0[num];
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				if (i != num)
				{
					gstruct42_0[i].int_68 = new int[3]
					{
						gStruct.int_68[0],
						gStruct.int_68[1],
						gStruct.int_68[2]
					};
					gstruct42_0[i].string_7 = gStruct.string_7;
					Class47.smethod_11(gstruct42_0[i]);
				}
			}
		}
		labelTheoSauAll.Enabled = false;
	}

	private void comboBoxTheoSau_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		bool_7 = false;
		GStruct42 gStruct = gstruct42_0[num];
		string text = gStruct.string_7;
		string text2 = null;
		comboBoxTheoSau.Items.Clear();
		string_30 = null;
		Class86.smethod_24(gstruct42_0[num], ref string_30, 1);
		if (string_30 != null)
		{
			for (int i = 0; i < string_30.Length; i++)
			{
				if (string_30[i] == text)
				{
					text2 = text;
				}
				comboBoxTheoSau.Items.Add(Class10.smethod_1(string_30[i], 1));
			}
		}
		if (text2 == null && text != null && text != string.Empty)
		{
			comboBoxTheoSau.Items.Add(Class10.smethod_1(text, 1));
			text2 = text;
		}
		comboBoxTheoSau.Items.Add("");
		if (text2 != null && text2 != string.Empty)
		{
			comboBoxTheoSau.Text = Class10.smethod_1(text2, 1);
		}
		bool_7 = true;
	}

	private void checkBoxClickNPCmenu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_8 = Convert.ToByte(checkBoxClickNPCmenu.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxClickNPCMenu_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_9 = smethod_2(textBoxClickNPCMenu.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	public static int[] smethod_2(string string_39)
	{
		if (!(string_39 == string.Empty) && string_39 != null)
		{
			string[] array = string_39.Split(',', '.', ':', '/', '|', '=', '-', '+', ';');
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = Class11.smethod_12(array[i]);
			}
			return array2;
		}
		return null;
	}

	private void checkBoxClickNPCSolan_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			if (gstruct42_0[num].int_7 == null)
			{
				gstruct42_0[num].int_7 = new int[2]
				{
					0,
					3
				};
			}
			gstruct42_0[num].int_7[0] = Convert.ToByte(checkBoxClickNPCSolan.Checked);
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void textBoxClickNPCSolan_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			if (gstruct42_0[num].int_7 == null)
			{
				gstruct42_0[num].int_7 = new int[2]
				{
					0,
					3
				};
			}
			gstruct42_0[num].int_7[1] = Class11.smethod_12(textBoxClickNPCSolan.Text);
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void textBoxClickNPCTocdo_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			int num2 = Class11.smethod_12(textBoxClickNPCTocdo.Text);
			if (num2 < 0 || num2 > 15000)
			{
				num2 = 300;
			}
			gstruct42_0[num].int_10 = num2;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void comboBoxClickNPC_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		bool_7 = false;
		GStruct42 gStruct = gstruct42_0[num];
		string text = gStruct.string_0;
		string text2 = null;
		comboBoxClickNPC.Items.Clear();
		string_31 = null;
		Class86.smethod_24(gstruct42_0[num], ref string_31, 3);
		if (string_31 != null)
		{
			Array.Sort(string_31);
			for (int i = 0; i < string_31.Length; i++)
			{
				if (string_31[i] == text)
				{
					text2 = text;
				}
				comboBoxClickNPC.Items.Add(Class10.smethod_1(string_31[i], 1));
			}
		}
		if (text2 == null && text != string.Empty)
		{
			comboBoxClickNPC.Items.Add(Class10.smethod_1(text, 1));
			text2 = text;
		}
		comboBoxClickNPC.Items.Add("");
		if (text2 != null && text2 != string.Empty)
		{
			comboBoxClickNPC.Text = Class10.smethod_1(text2, 1);
		}
		Thread.Sleep(10);
		bool_7 = true;
	}

	private void comboBoxClickNPC_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		string text = comboBoxClickNPC.Text;
		if (string_31 != null)
		{
			for (int i = 0; i < string_31.Length; i++)
			{
				if (Class10.smethod_1(string_31[i], 1) == text)
				{
					string_32 = string_31[i];
					break;
				}
			}
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			gstruct42_0[num].string_0 = string_32;
		}
	}

	private void buttonHuongdanHLP_Click(object sender, EventArgs e)
	{
		method_20();
	}

	private void method_20()
	{
		if (FormVideoHelp.bool_0)
		{
			FormVideoHelp.bool_0 = false;
		}
		else
		{
			try
			{
				FormVideoHelp formVideoHelp = new FormVideoHelp();
				formVideoHelp.int_0 = base.Left;
				formVideoHelp.int_1 = base.Top;
				formVideoHelp.int_2 = base.Width;
				formVideoHelp.int_3 = base.Height;
				formVideoHelp.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxGioClick_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_125[1] = Convert.ToByte(checkBoxGioClick.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void numericUpDownHH_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_125[2] = (int)numericUpDownHH.Value;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void numericUpDownMM_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_125[3] = (int)numericUpDownMM.Value;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void numericUpDownSS_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_125[4] = (int)numericUpDownSS.Value;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void numericUpDownCTC_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_103 = (int)numericUpDownCTC.Value;
			Class55.smethod_10(Class47.string_0, "IdexMenuTHPChientruong", int_103, "", 0);
		}
	}

	private void comboBoxChienTruong_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = comboBoxChienTruong.Text;
		int num = 0;
		while (true)
		{
			if (num < Class89.struct31_0.Length)
			{
				if (Class89.struct31_0[num].string_2 == text)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		if (int_100 != num)
		{
			int_100 = num;
			Class55.smethod_10(Class47.string_0, "IdexChientruongChinh", int_100, "", 0);
		}
	}

	private void comboBoxChienTruongMapPhu_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = comboBoxChienTruongMapPhu.Text;
		int num = 0;
		while (true)
		{
			if (num < Class89.struct31_0.Length)
			{
				if (Class89.struct31_0[num].string_2 == text)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		if (int_102 != num)
		{
			int_102 = num;
			Class55.smethod_10(Class47.string_0, "IdexChientruongPhu", int_102, "", 0);
		}
	}

	private void checkBoxTHPCTC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_99 = Convert.ToByte(checkBoxTHPCTC.Checked);
			Class55.smethod_10(Class47.string_0, "flagTHPCTC", int_99, "", 0);
		}
	}

	private void checkBoxMapPhu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_101 = Convert.ToByte(checkBoxMapPhu.Checked);
			Class55.smethod_10(Class47.string_0, "flagSudungMapphuEx", int_101, "", 0);
		}
	}

	private void checkBoxAccChinhTudieukhienCTC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_106 = Convert.ToByte(checkBoxAccChinhTudieukhienCTC.Checked);
			Class55.smethod_10(Class47.string_0, "CTCAchinhTudieuKhien", int_106, "", 0);
		}
	}

	private void checkBoxChienLongdong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			Class16.int_1 = -1;
			int_108 = Convert.ToByte(checkBoxChienLongdong.Checked);
			Class55.smethod_10(Class47.string_0, "flagDanhChienlongdong", int_108, "", 0);
		}
	}

	private void comboBoxCLD_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		string text = comboBoxCLD.Text;
		int num = 0;
		while (true)
		{
			if (num < Class16.string_1.Length)
			{
				if (text == Class16.string_1[num])
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		if (Class16.int_0 != num)
		{
			Class16.int_0 = num;
			Class55.smethod_10(Class47.string_0, "IndexChienlongdong", Class16.int_0, "", 0);
		}
	}

	private void method_21(ListView listView_0, int int_134 = 0)
	{
		if (listView_0.Items == null)
		{
			return;
		}
		int count = listView_0.Items.Count;
		if (count != 0)
		{
			if (int_134 >= count)
			{
				int_134 = count - 1;
			}
			listView_0.TopItem = listView_0.Items[int_134];
			listView_0.Items[int_134].Focused = true;
			listView_0.Items[int_134].Selected = true;
		}
	}

	private void method_22(ListView listView_0, uint[] uint_1)
	{
		int num = 0;
		if (listView_0.Items != null)
		{
			num = listView_0.Items.Count;
		}
		string[] array = new string[2]
		{
			num.ToString(),
			uint_1[0].ToString() + "," + uint_1[1].ToString()
		};
		ListViewItem listViewItem = new ListViewItem(array[0]);
		ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[1]);
		listViewItem.SubItems.Add(item);
		listView_0.Items.Add(listViewItem);
	}

	private void listViewTrain_MouseDown(object sender, MouseEventArgs e)
	{
		if (listView1.Items != null)
		{
			int_129 = Class71.smethod_4(listViewTrain, e, 1);
		}
		else
		{
			int_129 = -1;
		}
		if (0 <= int_129)
		{
			string text = listViewTrain.Items[int_129].SubItems[1].Text;
		}
		buttonXoaToadoTrain.Text = "Xóa (" + int_129 + ")";
	}

	private void buttonLayToadoTrain_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		int num2 = Class33.smethod_0(gstruct42_0[num]);
		if (num2 != gstruct42_0[num].int_33 && gstruct42_0[num].int_33 > 0)
		{
			listViewTrain.Items.Clear();
			gstruct42_0[num].uint_0 = null;
		}
		gstruct42_0[num].int_33 = num2;
		textBoxMapName.Text = Class33.smethod_1(num2, bool_0: true);
		uint[] array = Class32.smethod_29(gstruct42_0[num]);
		if (gstruct42_0[num].uint_0 != null)
		{
			for (int i = 0; i < gstruct42_0[num].uint_0.GetLength(0); i++)
			{
				if (gstruct42_0[num].uint_0[i, 0] == array[0] && gstruct42_0[num].uint_0[i, 1] == array[1])
				{
					return;
				}
			}
		}
		Class11.smethod_49(ref gstruct42_0[num].uint_0, array);
		method_22(listViewTrain, array);
		if (0 <= int_129 && int_129 < listViewTrain.Items.Count)
		{
			listViewTrain.Items[int_129].Selected = false;
			listViewTrain.Items[int_129].Focused = false;
		}
		int_129 = listViewTrain.Items.Count - 1;
		method_21(listViewTrain, int_129);
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void buttonXoaToadoTrain_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		if (int_129 >= 0 && listViewTrain.Items != null && listViewTrain.Items.Count > 0)
		{
			string[] array = listViewTrain.Items[int_129].SubItems[1].Text.Split(',');
			if (array.Length < 2)
			{
				return;
			}
			uint[] uint_ = new uint[2]
			{
				Class11.smethod_13(array[0]),
				Class11.smethod_13(array[1])
			};
			listViewTrain.Items.RemoveAt(int_129);
			Class11.smethod_50(ref gstruct42_0[num].uint_0, uint_);
			if (gstruct42_0[num].uint_0 != null && listViewTrain.Items.Count != 0)
			{
				for (int i = 0; i < listViewTrain.Items.Count; i++)
				{
					listViewTrain.Items[i].SubItems[0].Text = i.ToString();
				}
				if (listViewTrain.Items.Count <= int_129)
				{
					int_129 = listViewTrain.Items.Count - 1;
				}
				listViewTrain.Items[int_129].Focused = true;
				listViewTrain.Items[int_129].Selected = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
			else
			{
				listViewTrain.Items.Clear();
				int_129 = -1;
			}
		}
		else
		{
			int_129 = -1;
		}
	}

	private void checkBoxTrain_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_26 = Convert.ToByte(checkBoxTrain.Checked);
				gstruct42_0[num].bool_17 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxNhatdoDichuyenGan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_53 = Convert.ToByte(checkBoxNhatdoDichuyenGan.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonDoctep_Click(object sender, EventArgs e)
	{
		string string_ = Class47.string_4 + "\\Toado";
		Class11.smethod_8(string_);
		string a = Class47.smethod_24(string_, "", "*.xyz");
		if (a == string.Empty)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		int_129 = -1;
		listViewTrain.Items.Clear();
		bool_7 = false;
		string text = Class11.smethod_16(Class11.smethod_28(a, 0, 0, 1));
		if (!(text == string.Empty))
		{
			string[] array = text.Split('|');
			if (array.Length >= 2)
			{
				gstruct42_0[num].int_33 = Class11.smethod_12(array[0]);
				if (gstruct42_0[num].int_33 != 0)
				{
					gstruct42_0[num].uint_0 = null;
					string[] array2 = array[1].Split(':');
					if (array2 != null && array2.Length > 0)
					{
						gstruct42_0[num].uint_0 = new uint[array2.Length, 2];
						for (int i = 0; i < array2.Length; i++)
						{
							string[] array3 = array2[i].Split(';');
							if (array3.Length == 2)
							{
								for (int j = 0; j < 2; j++)
								{
									gstruct42_0[num].uint_0[i, j] = Class11.smethod_13(array3[j]);
								}
							}
						}
					}
					textBoxMapName.Text = Class33.smethod_1(gstruct42_0[num].int_33, bool_0: true);
					if (gstruct42_0[num].uint_0 != null)
					{
						for (int i = 0; i < gstruct42_0[num].uint_0.GetLength(0); i++)
						{
							method_22(listViewTrain, new uint[2]
							{
								gstruct42_0[num].uint_0[i, 0],
								gstruct42_0[num].uint_0[i, 1]
							});
						}
					}
					bool_7 = true;
					return;
				}
			}
		}
		gstruct42_0[num].int_33 = 0;
		gstruct42_0[num].uint_0 = null;
		textBoxMapName.Text = string.Empty;
		bool_7 = true;
	}

	private void buttonLuutep_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		GStruct42 gStruct = gstruct42_0[num];
		string string_ = Class47.string_4 + "\\Toado";
		Class11.smethod_8(string_);
		string a = Class47.smethod_25(string_, Class10.smethod_1(gStruct.string_20, 1) + ".xyz");
		if (a == string.Empty)
		{
			return;
		}
		string text = string.Empty;
		if (gStruct.uint_0 != null)
		{
			for (int i = 0; i < gStruct.uint_0.GetLength(0); i++)
			{
				if (text != string.Empty)
				{
					text += ":";
				}
				object obj = text;
				text = string.Concat(obj, gStruct.uint_0[i, 0], ";", gStruct.uint_0[i, 1]);
			}
		}
		string text2 = gStruct.int_33.ToString() + "|" + text;
		Class11.smethod_29(a, Class11.smethod_17(text2), 2);
	}

	private void buttonApdungAllTrain_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		if (gstruct42_0[num].int_62 == null)
		{
			gstruct42_0[num].int_62 = new int[2];
		}
		if (gstruct42_0[num].int_55 == null)
		{
			gstruct42_0[num].int_55 = new int[5];
		}
		GStruct42 gStruct = gstruct42_0[num];
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (i == num)
			{
				continue;
			}
			gstruct42_0[i].int_33 = gStruct.int_33;
			gstruct42_0[i].uint_0 = null;
			gstruct42_0[i].int_34 = gStruct.int_34;
			gstruct42_0[i].int_59 = gStruct.int_59;
			gstruct42_0[i].int_61 = gStruct.int_61;
			gstruct42_0[i].int_62 = new int[2]
			{
				gStruct.int_62[0],
				gStruct.int_62[1]
			};
			gstruct42_0[i].int_20 = gStruct.int_20;
			gstruct42_0[i].int_19 = gStruct.int_19;
			gstruct42_0[i].int_38 = gStruct.int_38;
			gstruct42_0[i].int_53 = gStruct.int_53;
			gstruct42_0[i].int_54 = gStruct.int_54;
			gstruct42_0[i].int_42 = gStruct.int_42;
			gstruct42_0[i].int_63 = gStruct.int_63;
			gstruct42_0[i].int_55 = new int[5];
			for (int j = 0; j < 5; j++)
			{
				gstruct42_0[i].int_55[j] = gStruct.int_55[j];
			}
			gstruct42_0[i].uint_0 = null;
			if (gStruct.uint_0 != null)
			{
				gstruct42_0[i].uint_0 = new uint[gStruct.uint_0.GetLength(0), 2];
				for (int k = 0; k < gStruct.uint_0.GetLength(0); k++)
				{
					gstruct42_0[i].uint_0[k, 0] = gStruct.uint_0[k, 0];
					gstruct42_0[i].uint_0[k, 1] = gStruct.uint_0[k, 1];
				}
			}
			gstruct42_0[i].int_26 = gStruct.int_26;
			gstruct42_0[i].int_27 = gStruct.int_27;
			gstruct42_0[i].int_29 = gStruct.int_29;
			gstruct42_0[i].int_30 = gStruct.int_30;
			gstruct42_0[i].int_28 = gStruct.int_28;
			gstruct42_0[i].int_31 = gStruct.int_31;
			gstruct42_0[i].int_32 = gStruct.int_32;
			gstruct42_0[i].bool_17 = true;
			gstruct42_0[i].int_40 = gStruct.int_40;
			gstruct42_0[i].int_39 = gStruct.int_39;
			Class47.smethod_11(gstruct42_0[i]);
		}
		method_2("Đã áp dụng mục Train cho tất cả ac (ngoại trừ mục Lượm rác)");
	}

	private void checkBoxTranhBossVang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_59 = Convert.ToByte(checkBoxTranhBossVang.Checked);
				gstruct42_0[num].bool_17 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTDPSaimap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_61 = Convert.ToByte(checkBoxTDPSaimap.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxMuathuocPK_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].bool_9 = checkBoxMuathuocPK.Checked;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxChaydanhvong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].bool_8 = checkBoxChaydanhvong.Checked;
			}
		}
	}

	private void checkBoxChayPKNguoidung_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_35 = Convert.ToByte(checkBoxChayPKNguoidung.Checked);
				Class47.smethod_11(gstruct42_0[num]);
				Class57.int_0 = gstruct42_0[num].int_129;
			}
		}
	}

	private void comboBoxDoSatcuuSat_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxDoSatcuuSat.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_28.Length)
			{
				if (text == string_28[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].int_34 = num2;
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void buttonXoaIDAcChinh_Click(object sender, EventArgs e)
	{
		comboBoxAccChinh.Items.Clear();
		Class38.gstruct29_0.int_0 = 0;
		string_14 = string.Empty;
		int_52 = 0;
		Class55.smethod_10(Class47.string_0, "AccChinhNameA", string.Empty, "", 0);
	}

	private void buttonBaoToado_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			GStruct42 gStruct = gstruct42_0[num];
			uint[] array = Class32.smethod_29(gStruct);
			string text = null;
			switch (Class33.smethod_0(gStruct))
			{
			case 322:
				text = "Tr­êng B¹ch s¬n B¾c";
				break;
			default:
				text = Class33.smethod_2(gStruct);
				break;
			case 321:
				text = "Tr­êng B¹ch s¬n Nam";
				break;
			}
			string text2 = "§ang ë (" + array[0] / 256u + "," + array[1] / 512u + ") " + text;
			Class60.smethod_53(gStruct, text2, "CH_CHATROOM");
			Class60.smethod_53(gStruct, text2, "CH_TONG");
			try
			{
				Clipboard.SetText(Class10.smethod_1(text2, 1));
			}
			catch
			{
			}
		}
	}

	private void buttonHDD_Click(object sender, EventArgs e)
	{
		if (Dangky.int_0 > 0)
		{
			Dangky.int_0 = 0;
		}
		else
		{
			new Dangky().Show();
		}
	}

	private void method_23()
	{
		if (FormRauria.bool_0)
		{
			FormRauria.bool_0 = false;
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (0 <= num)
		{
			FormRauria.int_0 = gstruct42_0[num].int_129;
			FormRauria.string_0 = Class67.smethod_18(gstruct42_0[num]);
		}
		else
		{
			FormRauria.int_0 = 0;
			FormRauria.string_0 = null;
		}
		try
		{
			FormRauria formRauria = new FormRauria();
			formRauria.int_2 = base.Left;
			formRauria.int_3 = base.Top;
			formRauria.int_4 = base.Width;
			formRauria.int_5 = base.Height;
			formRauria.Show();
		}
		catch
		{
		}
	}

	private void buttonMorong_Click(object sender, EventArgs e)
	{
		method_23();
	}

	private void richTextBoxChedoMayphu_MouseClick(object sender, MouseEventArgs e)
	{
		method_23();
	}

	private void buttonUuTien_Click(object sender, EventArgs e)
	{
		if (FormUutien.int_0 > 0)
		{
			FormUutien.int_0 = 0;
			return;
		}
		int num = -1;
		int num2 = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num2 < 0)
		{
			string text = comboBoxUuTien.Text;
			for (int i = 0; i < string_23.Length; i++)
			{
				if (text == string_23[i])
				{
					num = i;
					break;
				}
			}
			if (num < 0 || num > 0)
			{
				return;
			}
		}
		else
		{
			num = gstruct42_0[num2].int_86;
		}
		if (num <= 0)
		{
			if (FormTuychon.bool_0)
			{
				FormTuychon.bool_0 = false;
			}
			else
			{
				try
				{
					FormTuychon.int_1 = 3;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
				}
				catch
				{
				}
			}
		}
		else
		{
			try
			{
				FormUutien.int_0 = gstruct42_0[num2].int_129;
				FormUutien.string_0 = Class67.smethod_18(gstruct42_0[num2]);
				new FormUutien().Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxOluonMapphu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_40 = Convert.ToByte(checkBoxOluonMapphu.Checked);
			Class55.smethod_10(Class47.string_0, "flagOLuonMapPhu", int_40, "", 0);
		}
	}

	private void checkBoxTuchayMuathuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_101 = Convert.ToByte(checkBoxTuchayMuathuoc.Checked);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonBungTuimau_Click(object sender, EventArgs e)
	{
		if (FormHaucanTuithuoc.bool_0)
		{
			FormHaucanTuithuoc.bool_0 = false;
		}
		else
		{
			try
			{
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (num >= 0)
				{
					FormHaucanTuithuoc.int_0 = gstruct42_0[num].int_129;
					FormHaucanTuithuoc formHaucanTuithuoc = new FormHaucanTuithuoc();
					formHaucanTuithuoc.int_2 = base.Left;
					formHaucanTuithuoc.int_3 = base.Top;
					formHaucanTuithuoc.int_4 = base.Width;
					formHaucanTuithuoc.int_5 = base.Height;
					formHaucanTuithuoc.Show();
				}
			}
			catch
			{
			}
		}
	}

	private void checkBoxVeThanhKhiPKlon_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_100[0] = Convert.ToByte(checkBoxVeThanhKhiPKlon.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonGiamCPUAll_Click(object sender, EventArgs e)
	{
		method_24();
	}

	private void method_24(int int_134 = -1)
	{
		if (int_130 > 0)
		{
			return;
		}
		buttonGiamCPUAll.Enabled = false;
		if (0 <= int_134)
		{
			int_131 = int_134;
		}
		else
		{
			int_131 = 0;
			string text = comboBoxGiamCpu.Text;
			for (int i = 0; i < string_29.Length; i++)
			{
				if (string_29[i] == text)
				{
					int_131 = i;
					break;
				}
			}
		}
		int_130 = 1;
		new Thread(method_25).Start();
	}

	private void method_25()
	{
		if (gstruct42_0 == null)
		{
			int_130 = 2;
			return;
		}
		while (true)
		{
			try
			{
				if (int_131 < 0)
				{
					int_131 = 0;
				}
				GStruct42 gStruct = default(GStruct42);
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					if (gstruct42_0[i].int_129 != Class38.gstruct29_0.int_0)
					{
						gstruct42_0[i].int_87 = int_131;
						gStruct = gstruct42_0[i];
						Class41.smethod_0(gStruct, int_131);
						Class47.smethod_11(gStruct);
					}
					else
					{
						gstruct42_0[i].int_87 = 0;
						gStruct = gstruct42_0[i];
						Class41.smethod_0(gStruct, 0, int_131);
						Class60.smethod_50(gStruct, "<color=green>Ac chÝnh: <color=red>T¾t");
						Class47.smethod_11(gStruct);
					}
				}
			}
			catch
			{
				Thread.Sleep(100);
				continue;
			}
			break;
		}
		int_130 = 2;
	}

	private void comboBoxGiamCpu_SelectedIndexChanged(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		int num2 = -1;
		string text = comboBoxGiamCpu.Text;
		for (int i = 0; i < string_29.Length; i++)
		{
			if (string_29[i] == text)
			{
				num2 = i;
				break;
			}
		}
		if (num2 != gstruct42_0[num].int_87)
		{
			gstruct42_0[num].int_87 = num2;
			GStruct42 gStruct = gstruct42_0[num];
			Class41.smethod_0(gStruct, num2);
			Class47.smethod_11(gStruct);
		}
	}

	private void checkBoxDameMacdinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			FormDame.int_6 = Convert.ToByte(checkBoxDameMacdinh.Checked);
			Class55.smethod_10(Class47.string_0, "flagDameMacdinh", FormDame.int_6, "", 0);
			if (FormDame.int_6 > 0 && int_61 <= 0)
			{
				int_61 = 1;
				GClass0.smethod_0();
				checkBoxPhimTat.Checked = true;
			}
		}
	}

	private void buttonDame_Click(object sender, EventArgs e)
	{
		if (FormDame.bool_0)
		{
			FormDame.bool_0 = false;
		}
		else
		{
			try
			{
				FormDame.int_4 = 0;
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (0 <= num)
				{
					FormDame.int_4 = gstruct42_0[num].int_129;
				}
				FormDame formDame = new FormDame();
				formDame.int_0 = Cursor.Position.X;
				formDame.int_1 = Cursor.Position.Y;
				formDame.int_2 = base.Width;
				formDame.int_3 = base.Height;
				formDame.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonAnhet_Click(object sender, EventArgs e)
	{
		new Thread(method_26).Start();
	}

	private void method_26()
	{
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				try
				{
					if (gstruct42_0[i].int_129 != Class38.gstruct29_0.int_0)
					{
						int num = 0;
						while (uint_0 != 0 && num < 30)
						{
							Thread.Sleep(10);
							num++;
						}
						uint_0 = gstruct42_0[i].uint_4;
						new Thread(method_12).Start();
					}
				}
				catch
				{
				}
			}
		}
	}

	private void checkBoxTuChayBoss_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].bool_1 = checkBoxTuChayBoss.Checked;
			}
		}
	}

	private void buttonSuaXoa_Click(object sender, EventArgs e)
	{
		if (FormChayBoss.bool_0)
		{
			FormChayBoss.bool_0 = false;
		}
		else
		{
			try
			{
				FormChayBoss formChayBoss = new FormChayBoss();
				formChayBoss.int_0 = base.Left;
				formChayBoss.int_1 = base.Top;
				formChayBoss.int_2 = base.Width;
				formChayBoss.int_3 = base.Height;
				formChayBoss.Show();
			}
			catch
			{
			}
		}
	}

	private int method_27()
	{
		string text = comboBoxNoiBoss.Text;
		if (FormChayBoss.string_2 != null)
		{
			for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
			{
				if (text == FormChayBoss.string_2[i, 0])
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void buttonBossAll_Click(object sender, EventArgs e)
	{
		int num = -1;
		bool @checked;
		if (@checked = checkBoxTuChayBoss.Checked)
		{
			num = method_27();
		}
		if (gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (gstruct42_0[i].bool_36)
			{
				gstruct42_0[i].int_0 = num;
				gstruct42_0[i].bool_1 = @checked;
			}
		}
	}

	private void comboBoxNoiBoss_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				int num2 = method_27();
				gstruct42_0[num].int_0 = num2;
				buttonDenDiemKetiep.Text = "Đến điểm kế tiếp" + Class47.string_3 + "( " + (num2 + 1) + " )";
			}
		}
	}

	private void buttonMoGame_Click(object sender, EventArgs e)
	{
		Class85.smethod_1();
	}

	private void textBoxPhamviNhat_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_54 = Class11.smethod_12(textBoxPhamviNhat.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxLuomrac_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		gstruct42_0[num].int_56 = Convert.ToByte(checkBoxLuomrac.Checked);
		Class47.smethod_11(gstruct42_0[num]);
		if (gstruct42_0[num].int_56 > 0)
		{
			if (FormLuomrac.bool_0)
			{
				FormLuomrac.bool_0 = false;
			}
			else
			{
				try
				{
					FormLuomrac.int_0 = gstruct42_0[num].int_129;
					FormLuomrac formLuomrac = new FormLuomrac();
					formLuomrac.int_1 = Cursor.Position.X;
					formLuomrac.int_2 = Cursor.Position.Y;
					formLuomrac.int_3 = base.Width;
					formLuomrac.int_4 = base.Height;
					formLuomrac.Show();
				}
				catch
				{
				}
			}
		}
	}

	private void checkBoxSLThoat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_20 = Convert.ToByte(checkBoxSLThoat.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxSLThoat_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_19 = Class11.smethod_12(textBoxSLThoat.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxXuongNgua_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxXuongNgua.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_24.Length)
			{
				if (text == string_24[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].int_90 = num2;
		Class47.smethod_11(gstruct42_0[num]);
		if (num2 == 0 && !Class32.smethod_18(gstruct42_0[num]))
		{
			Class60.smethod_55(gstruct42_0[num], "Switch([[horse]])");
		}
	}

	private void checkBoxHoasonMuamau500l_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_102 = Convert.ToByte(checkBoxHoasonMuamau500l.Checked);
				gstruct42_0[num].bool_27 = true;
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxPheThu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_25 = Convert.ToByte(checkBoxPheThu.Checked);
		}
	}

	private void checkBoxAnThuocTDD_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_65[0] = Convert.ToByte(checkBoxAnThuocTDD.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTocdoDanh_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_65[1] = Class11.smethod_12(textBoxTocdoDanh.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonThuocTDD_Click(object sender, EventArgs e)
	{
		if (FormThuocTocdoDanh.bool_0)
		{
			FormThuocTocdoDanh.bool_0 = false;
		}
		else
		{
			try
			{
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (num >= 0)
				{
					FormThuocTocdoDanh.int_0 = gstruct42_0[num].int_129;
					FormThuocTocdoDanh formThuocTocdoDanh = new FormThuocTocdoDanh();
					formThuocTocdoDanh.int_2 = Cursor.Position.X;
					formThuocTocdoDanh.int_3 = Cursor.Position.Y;
					formThuocTocdoDanh.int_4 = base.Width;
					formThuocTocdoDanh.int_5 = base.Height;
					formThuocTocdoDanh.Show();
				}
			}
			catch
			{
			}
		}
	}

	private void buttonThuocLag_Click(object sender, EventArgs e)
	{
		if (FormThuocLag.bool_0)
		{
			FormThuocLag.bool_0 = false;
		}
		else
		{
			try
			{
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (num >= 0)
				{
					FormThuocLag.int_0 = gstruct42_0[num].int_129;
					FormThuocLag formThuocLag = new FormThuocLag();
					formThuocLag.int_2 = Cursor.Position.X;
					formThuocLag.int_3 = Cursor.Position.Y;
					formThuocLag.int_4 = base.Width;
					formThuocLag.int_5 = base.Height;
					formThuocLag.Show();
				}
			}
			catch
			{
			}
		}
	}

	private void buttonPhimHDCTC_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/5H9Ita4GE9k?t=473";
		Class20.smethod_40(Class55.smethod_0(), "", text, 0);
	}

	private void comboBoxTenHieuThuocTamtru_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		bool_7 = false;
		comboBoxTenHieuThuocTamtru.Items.Clear();
		string_33 = null;
		Class86.smethod_24(gstruct42_0[num], ref string_33, 3);
		if (string_33 != null)
		{
			for (int i = 0; i < string_33.Length; i++)
			{
				comboBoxTenHieuThuocTamtru.Items.Add(Class10.smethod_1(string_33[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_7 = true;
	}

	private void comboBoxTenHieuThuocTamtru_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_33 == null)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		bool flag = false;
		string text = comboBoxTenHieuThuocTamtru.Text;
		for (int i = 0; i < string_33.Length; i++)
		{
			if (text == Class10.smethod_1(string_33[i], 1))
			{
				Class34.string_0 = string_33[i];
				Class55.smethod_10(Class47.string_0, "TenHieuthuocTamtru", Class34.string_0, "", 0);
				flag = true;
				break;
			}
		}
		if (flag)
		{
			int num2 = Class86.smethod_12(gstruct42_0[num], Class34.string_0, 3);
			Class34.uint_0 = Class86.smethod_18(gstruct42_0[num], num2);
			if (Class34.uint_0 == null)
			{
				uint[] array = Class34.uint_0 = new uint[2];
			}
			textBoxToadoHieuthuocTamtru.Text = Class34.uint_0[0] + "," + Class34.uint_0[1];
			Class55.smethod_10(Class47.string_0, "ToadoHieuthuocTamtru_0", Class34.uint_0[0], "", 0);
			Class55.smethod_10(Class47.string_0, "ToadoHieuthuocTamtru_1", Class34.uint_0[1], "", 0);
		}
	}

	private void buttonLayvitriCongTamtru_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			Class34.uint_1 = Class32.smethod_29(gstruct42_0[num]);
			textBoxCongTamtru.Text = Class34.uint_1[0] + "," + Class34.uint_1[1];
			Class55.smethod_10(Class47.string_0, "ToadoCongTamtru_0", Class34.uint_1[0], "", 0);
			Class55.smethod_10(Class47.string_0, "ToadoCongTamtru_1", Class34.uint_1[1], "", 0);
		}
	}

	private void buttonPhimHdTamtru_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/NHJWNV6zKJI";
		Class20.smethod_40(Class55.smethod_0(), "", text, 0);
	}

	private void checkBoxTDP_SL_Mau_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_112 = Convert.ToByte(checkBoxTDP_SL_Mau.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTDP_SL_Mana_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_114 = Convert.ToByte(checkBoxTDP_SL_Mana.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTDP_SL_Mau_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_113 = Class11.smethod_12(textBoxTDP_SL_Mau.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTDP_SL_Mana_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_115 = Class11.smethod_12(textBoxTDP_SL_Mana.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxTenMau2_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		bool_7 = false;
		string_34 = Class69.smethod_29(gstruct42_0[num]);
		comboBoxTenMau2.Items.Clear();
		if (string_34 != null)
		{
			for (int i = 0; i < string_34.Length; i++)
			{
				comboBoxTenMau2.Items.Add(Class10.smethod_1(string_34[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_7 = true;
	}

	private void comboBoxTenMana2_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		bool_7 = false;
		string_35 = Class69.smethod_29(gstruct42_0[num]);
		comboBoxTenMana2.Items.Clear();
		if (string_35 != null)
		{
			for (int i = 0; i < string_35.Length; i++)
			{
				comboBoxTenMana2.Items.Add(Class10.smethod_1(string_35[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_7 = true;
	}

	private void comboBoxTenMau2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_34 == null)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenMau2.Text;
		if (!(text == string.Empty))
		{
			int num2 = 0;
			while (true)
			{
				if (num2 < string_34.Length)
				{
					if (text == Class10.smethod_1(string_34[num2], 1))
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			gstruct42_0[num].string_14 = string_34[num2];
			Class47.smethod_11(gstruct42_0[num]);
		}
		else
		{
			gstruct42_0[num].string_14 = string.Empty;
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void comboBoxTenMana2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_35 == null)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenMana2.Text;
		if (text == string.Empty)
		{
			gstruct42_0[num].string_15 = string.Empty;
			Class47.smethod_11(gstruct42_0[num]);
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < string_35.Length)
			{
				if (text == Class10.smethod_1(string_35[num2], 1))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].string_15 = string_35[num2];
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void checkBoxMau2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_107[0] = Convert.ToByte(checkBoxMau2.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxRatioMau2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_107[1] = Class11.smethod_12(textBoxRatioMau2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTimerMau2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_107[2] = Class11.smethod_12(textBoxTimerMau2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxSoluongMau2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_107[3] = Class11.smethod_12(textBoxSoluongMau2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxMana2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_109[0] = Convert.ToByte(checkBoxMana2.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxRatioMana2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_109[1] = Class11.smethod_12(textBoxRatioMana2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTimerMana2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_109[2] = Class11.smethod_12(textBoxTimerMana2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxSoluongMana2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_109[3] = Class11.smethod_12(textBoxSoluongMana2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxDuongMonBoom_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_122[0] = Convert.ToByte(checkBoxDuongMonBoom.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonThietLapDuongMon_Click(object sender, EventArgs e)
	{
		if (FormDuongMon.bool_0)
		{
			FormDuongMon.bool_0 = false;
		}
		else
		{
			try
			{
				int num = -1;
				int num2 = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (0 <= num2)
				{
					string a = Class67.smethod_18(gstruct42_0[num2]);
					if (a == "DUONGMON")
					{
						num = gstruct42_0[num2].int_129;
					}
				}
				if (num <= 0 && gstruct42_0 != null)
				{
					for (int i = 0; i < gstruct42_0.Length; i++)
					{
						string a = Class67.smethod_18(gstruct42_0[i]);
						if (a == "DUONGMON")
						{
							num = gstruct42_0[i].int_129;
							break;
						}
					}
				}
				FormDuongMon.int_4 = num;
				FormDuongMon formDuongMon = new FormDuongMon();
				formDuongMon.int_0 = Cursor.Position.X;
				formDuongMon.int_1 = Cursor.Position.Y;
				formDuongMon.int_2 = base.Width;
				formDuongMon.int_3 = base.Height;
				formDuongMon.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxUuTienBomCuuchuyen_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_105 = Convert.ToByte(checkBoxUuTienBomCuuchuyen.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxOtrong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_62[0] = Convert.ToByte(checkBoxOtrong.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxOtrong_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxOtrong.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_22.Length)
			{
				if (text == string_22[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].int_62[1] = num2;
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void buttonThoatHetgame_Click(object sender, EventArgs e)
	{
		bool flag = false;
		int[] array = Class20.smethod_24(Class47.string_17);
		if (array != null)
		{
			if (!flag)
			{
				string text = "Bạn chắc chắn muốn thoát hết game ?";
				if (MessageBox.Show(text, string_1, MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
				flag = true;
			}
			for (int i = 0; i < array.Length; i++)
			{
				Class20.smethod_48(array[i]);
				Thread.Sleep(60);
			}
		}
		if (Class47.string_15 == null || Class47.string_15 == string.Empty)
		{
			return;
		}
		string processName = Class47.string_15;
		if (Class11.smethod_2(Class47.string_15.ToUpper(), ".EXE") > 0)
		{
			string[] array2 = Class11.smethod_15(Class47.string_15, '.');
			processName = array2[0];
		}
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName(processName);
			if (processesByName == null || processesByName.Length == 0)
			{
				processesByName = Process.GetProcessesByName(Class47.string_15 + '\u00a0');
				if (processesByName == null || processesByName.Length == 0)
				{
					break;
				}
			}
			if (!flag)
			{
				string text = "Bạn chắc chắn muốn thoát hết game ?";
				if (MessageBox.Show(text, string_1, MessageBoxButtons.YesNo) == DialogResult.No)
				{
					break;
				}
				flag = true;
			}
			try
			{
				for (int i = 0; i < processesByName.Length; i++)
				{
					Class20.smethod_53(processesByName[i]);
				}
				return;
			}
			catch
			{
			}
		}
	}

	private void textBoxMenuTest_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		FormLocdoTest.int_12 = smethod_2(textBoxMenuTest.Text);
		string text = string.Empty;
		if (FormLocdoTest.int_12 != null)
		{
			for (int i = 0; i < FormLocdoTest.int_12.Length; i++)
			{
				if (text != string.Empty)
				{
					text += ",";
				}
				text += FormLocdoTest.int_12[i];
			}
		}
		Class55.smethod_10(Class47.string_0, "ClickMenuTest", text, "", 0);
	}

	private void comboBoxTrangbiTest_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		comboBoxTrangbiTest.Items.Clear();
		string_16 = null;
		GStruct42 gStruct = gstruct42_0[num];
		bool_7 = false;
		if (FormLocdoTest.int_4 <= 0)
		{
			string_16 = Class69.smethod_29(gStruct);
		}
		else
		{
			Class86.smethod_24(gStruct, ref string_16, 3);
		}
		if (string_16 != null)
		{
			Array.Sort(string_16);
			for (int i = 0; i < string_16.Length; i++)
			{
				comboBoxTrangbiTest.Items.Add(Class10.smethod_1(string_16[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_7 = true;
	}

	private void comboBoxTrangbiTest_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_16 == null)
		{
			return;
		}
		string text = comboBoxTrangbiTest.Text;
		int num = 0;
		while (true)
		{
			if (num < string_16.Length)
			{
				if (text == Class10.smethod_1(string_16[num], 1))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		FormLocdoTest.string_0 = string_16[num];
		Class55.smethod_10(Class47.string_0, "TenVatPhamNhanTrangbiTest", Class11.smethod_17(FormLocdoTest.string_0), "", 0);
	}

	private void buttonTatcaNhanTrangbiTest_Click(object sender, EventArgs e)
	{
		if (gstruct42_0 != null && FormLocdoTest.string_0 != null && !(FormLocdoTest.string_0 == string.Empty))
		{
			try
			{
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					if (gstruct42_0[i].bool_36 && !gstruct42_0[i].bool_5)
					{
						gstruct42_0[i].bool_5 = true;
						for (int j = 0; j < 50; j++)
						{
							if (FormLocdoTest.int_1 <= 0)
							{
								break;
							}
							Thread.Sleep(10);
						}
						FormLocdoTest.int_1 = gstruct42_0[i].int_129;
						new Thread(FormLocdoTest.smethod_2).Start();
					}
				}
			}
			catch
			{
			}
		}
	}

	private void buttonDungTatcaTrangbiTest_Click(object sender, EventArgs e)
	{
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				gstruct42_0[i].bool_5 = false;
			}
		}
	}

	private void buttonNhanTrangbiTest_Click(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0 && !gstruct42_0[num].bool_5)
			{
				gstruct42_0[num].bool_5 = true;
				FormLocdoTest.int_1 = gstruct42_0[num].int_129;
				new Thread(FormLocdoTest.smethod_2).Start();
			}
		}
	}

	private void buttonLocTrangbi_Click(object sender, EventArgs e)
	{
		if (FormLocdoTest.bool_2)
		{
			FormLocdoTest.bool_2 = false;
		}
		else
		{
			try
			{
				FormLocdoTest.int_0 = 0;
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (0 <= num)
				{
					FormLocdoTest.int_0 = gstruct42_0[num].int_129;
				}
				FormLocdoTest formLocdoTest = new FormLocdoTest();
				formLocdoTest.int_13 = base.Left;
				formLocdoTest.int_14 = base.Top;
				formLocdoTest.int_15 = base.Width;
				formLocdoTest.int_16 = base.Height;
				formLocdoTest.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonPhimHDLoc_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/Dup5PcJOV5Y";
		string text2 = "https://youtu.be/Gq7CMQV16Fg";
		Class20.smethod_40(Class55.smethod_0(), "", text, 0);
		string text3 = "Xem 2 video hướng dẫn tại: " + Class47.string_3 + text + Class47.string_3 + text2;
		FormTip.smethod_0(string_1, text3, 600000, 250, 80);
	}

	private void buttonThietlapClickNpc_Click(object sender, EventArgs e)
	{
		if (FormClickNPC.bool_0)
		{
			FormClickNPC.bool_0 = false;
		}
		else
		{
			try
			{
				FormClickNPC.int_0 = 0;
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (0 <= num)
				{
					FormClickNPC.int_0 = gstruct42_0[num].int_129;
				}
				FormClickNPC formClickNPC = new FormClickNPC();
				formClickNPC.int_1 = base.Left;
				formClickNPC.int_2 = base.Top;
				formClickNPC.int_3 = base.Width;
				formClickNPC.int_4 = base.Height;
				formClickNPC.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxTongKimXemSoluong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_87 = Convert.ToByte(checkBoxTongKimXemSoluong.Checked);
			Class55.smethod_10(Class47.string_0, "TongKimXemSoluong", int_87, "", 0);
		}
	}

	private void linkLabelTrangchu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = comboBoxGameOfWeb.Text;
		if (text == "khác")
		{
			return;
		}
		string[] array = text.Split('+', ' ', ',');
		string text2 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(text2))
		{
			text2 = Class55.smethod_0();
		}
		foreach (string text1 in array)
		{
			if (text1 == string.Empty || text1 == null)
			{
				continue;
			}
			text = text1.Trim();
			if (text.Length >= 6)
			{
				if (Class11.smethod_2(text, "://") < 0)
				{
					text = "http://" + text;
				}
				Class20.smethod_40(text2, "", text, 0);
			}
		}
	}

	private void buttonHuongDan_Click(object sender, EventArgs e)
	{
		string text = "TRAIN:|Đem ac đến bãi cần train. Bấm nút lấy tọa độ train, tọa độ ở đây lấy theo đường thẳng, ac đi đến cuối sẽ đi ngược lại.|Check vào mục train. Xong bấm áp dụng tất cả ac.||NHỮNG LƯU Ý:||- Nếu ac chạy tới quái lại giựt về tọa độ train mà không đánh, là do Khoảng cách tìm ac chính quá thấp + giá trị Tiếp cận thấp, bạn chỉnh 2 cái này lên cao tí, hoặc bỏ đừng check vào tiếp cận.||- Khi ac về thành, sẽ tự bán đồ theo mục lọc đồ (của phần nhặt đồ, bảng 1. Yêu cầu: check vào phần nhặt đồ), bán đồ xong sẽ cất đồ. Sau đó tự mua máu theo phần Hậu cần rồi lên lại bãi.||- Ac sẽ tự lên bãi theo cách: Trở lại điểm cũ -> Nếu không thành công sẽ đi Xa phu nơi đi qua -> Nếu không thành công sẽ tiếp tục đi bằng Thần hành phù (do đó auto không cần thiết phải có mục đi xa phu).||- Chức năng TĐP khi còn bao nhiêu bình máu, mana trong mục Hậu cần vẫn áp dụng khi train.||- Với các bản đồ đặc biệt thì auto TĐP, ví dụ như Mạc Bắc Thảo Nguyên, Vi Sơn đảo... mà thay vào đó là chức năng tự chạy về mua thuốc khi hết thuốc.||- Thổ địa phù khi sai map: Nếu 2 map liên thông thì ac sẽ tự chạy vào map train (ví dụ La Tiêu Sơn -> Lưỡng Thủy động là liên thông), còn không liên thông thì ac sẽ thổ địa phù.||- Khoảng cách giữa ac chính và ac phụ dưới nút [A] của auto vẫn được áp dụng trong mục train này (không nhỏ hơn 150).||- Chức năng thoát game khi sinh lực thấp được chuyển qua tab Hậu cần, phục hồi|";
		FormTip.smethod_0(string_1, text, 600000, 400, 320);
	}

	private void checkBoxRuong0_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			if (gstruct42_0[num].int_55 == null)
			{
				gstruct42_0[num].int_55 = new int[5];
			}
			gstruct42_0[num].int_55[0] = Convert.ToByte(checkBoxRuong0.Checked);
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxRuong1_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			if (gstruct42_0[num].int_55 == null)
			{
				gstruct42_0[num].int_55 = new int[5];
			}
			gstruct42_0[num].int_55[1] = Convert.ToByte(checkBoxRuong1.Checked);
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxRuong2_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			if (gstruct42_0[num].int_55 == null)
			{
				gstruct42_0[num].int_55 = new int[5];
			}
			gstruct42_0[num].int_55[2] = Convert.ToByte(checkBoxRuong2.Checked);
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void checkBoxRuong3_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			if (gstruct42_0[num].int_55 == null)
			{
				gstruct42_0[num].int_55 = new int[5];
			}
			gstruct42_0[num].int_55[3] = Convert.ToByte(checkBoxRuong3.Checked);
			Class47.smethod_11(gstruct42_0[num]);
		}
	}

	private void buttonKhongcat_Click(object sender, EventArgs e)
	{
		if (FormKhongCatdo.bool_0)
		{
			FormKhongCatdo.bool_0 = false;
		}
		else
		{
			try
			{
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (num >= 0)
				{
					FormKhongCatdo.int_0 = gstruct42_0[num].int_129;
					FormKhongCatdo formKhongCatdo = new FormKhongCatdo();
					formKhongCatdo.int_2 = Cursor.Position.X;
					formKhongCatdo.int_3 = Cursor.Position.Y;
					formKhongCatdo.int_4 = base.Width;
					formKhongCatdo.int_5 = base.Height;
					formKhongCatdo.Show();
				}
			}
			catch
			{
			}
		}
	}

	private void checkBoxXepdo_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_39 = Convert.ToByte(checkBoxXepdo.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonTimTrongthanh_Click(object sender, EventArgs e)
	{
		string text = "* Check vào Tìm ac chính: ac phụ sẽ tìm đi theo ac chính bất cứ nơi đâu.||* Ô kế bên tìm ac chính: giá trị biễu diễn khoảng cách sẽ tìm ac chính, nếu khoảng cách ac phụ và ac chính lớn hơn giá trị này thì ac phụ sẽ tiến hành tìm.||* Check vào Tìm trong thành: ac chính ở trong thành thì ac phụ cũng tìm theo.||* Khi săn boss hoặc pk nhau, thì lưu ý 2 điểm:|1. Nên bỏ check tìm trong thành: Vì nếu vẫn để tìm trong thành, mà ac chính lỡ chết thì ac phụ lại Thổ địa phù về hết.||2. Nên check vào mục <ưu tiên đi xa phu trước, thần hành phù sau> trong nút Mở rộng: Sẽ tiện lợi hơn khi check vào mục này, vì ac nếu có Thổ địa phù về thành thì sẽ quay lại điểm cũ từ xa phu, do đó sẽ tập trung nhanh hơn.|";
		FormTip.smethod_0(string_1, text, 600000, 370, 280, bool_5: false, base.Left, base.Top);
	}

	private void buttonLayVitriXaphuCTQ_Click(object sender, EventArgs e)
	{
		if (FormXaphuCT.bool_0)
		{
			FormXaphuCT.bool_0 = false;
		}
		else
		{
			try
			{
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (num >= 0)
				{
					FormXaphuCT.int_0 = gstruct42_0[num].int_129;
					FormXaphuCT formXaphuCT = new FormXaphuCT();
					formXaphuCT.int_2 = base.Left;
					formXaphuCT.int_3 = base.Top;
					formXaphuCT.int_4 = base.Width;
					formXaphuCT.int_5 = base.Height;
					formXaphuCT.Show();
				}
			}
			catch
			{
			}
		}
	}

	private void textBoxTimeXepdo_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_40 = Class11.smethod_12(textBoxTimeXepdo.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxNPC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_4 = Convert.ToByte(checkBoxNPC.Checked);
			Class55.smethod_10(Class47.string_0, "flagCoClickVaoNPC", int_4, "", 0);
		}
	}

	private void textBoxOso1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_74[1] = Class11.smethod_12(textBoxOso1.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxOso2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_74[2] = Class11.smethod_12(textBoxOso2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxOso3_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_74[3] = Class11.smethod_12(textBoxOso3.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxGanTenthuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_74[0] = Convert.ToByte(checkBoxGanTenthuoc.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonDenDiemKetiep_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || FormChayBoss.string_2 == null)
		{
			return;
		}
		int num = -1;
		int length = FormChayBoss.string_2.GetLength(0);
		bool_7 = false;
		string text = comboBoxNoiBoss.Text;
		for (int i = 0; i < length; i++)
		{
			if (text == FormChayBoss.string_2[i, 0])
			{
				num = i;
				break;
			}
		}
		int num2 = num + 1;
		if (length <= num2)
		{
			num2 = 0;
		}
		int num3 = num2;
		int num4 = 0;
		while (FormChayBoss.string_2[num2, 0] == "...")
		{
			num2++;
			if (length <= num2)
			{
				num2 = 0;
				num4 = 1;
			}
			if (num4 > 0 && num3 <= num2)
			{
				break;
			}
		}
		comboBoxNoiBoss.Text = FormChayBoss.string_2[num2, 0];
		Thread.Sleep(100);
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				gstruct42_0[i].int_0 = num2;
			}
		}
		buttonDenDiemKetiep.Text = "Đến điểm kế tiếp" + Class47.string_3 + "( " + (num2 + 1) + " )";
		bool_7 = true;
	}

	private void checkBoxTudongPT_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_118[0] = Convert.ToByte(checkBoxTudongPT.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTucheHT_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_27 = Convert.ToByte(checkBoxTucheHT.Checked);
				checkBoxTDPHettien.Enabled = (gstruct42_0[num].int_27 > 0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTuGiaiBua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_78 = Convert.ToByte(checkBoxTuGiaiBua.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTNXuatChieu120_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_81 = Convert.ToByte(checkBoxTNXuatChieu120.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonSkill120vd_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
		}
		else
		{
			try
			{
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (num >= 0)
				{
					FormTuychon.int_1 = 0;
					FormTuychon.int_0 = gstruct42_0[num].int_129;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
				}
			}
			catch
			{
			}
		}
	}

	private void buttonSkill120tn_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
		}
		else
		{
			try
			{
				FormTuychon.int_1 = 1;
				FormTuychon formTuychon = new FormTuychon();
				formTuychon.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonDanhsachCuusat_Click(object sender, EventArgs e)
	{
		if (FormCuuSat.bool_0)
		{
			FormCuuSat.bool_0 = false;
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			FormCuuSat.int_0 = gstruct42_0[num].int_129;
			try
			{
				FormCuuSat formCuuSat = new FormCuuSat();
				formCuuSat.int_1 = base.Left;
				formCuuSat.int_2 = base.Top;
				formCuuSat.int_3 = base.Width;
				formCuuSat.int_4 = base.Height;
				formCuuSat.Show();
			}
			catch
			{
			}
		}
		else
		{
			FormTip.smethod_0("HUONG DAN", "Bạn hãy chọn 1 ac rồi bấm nút Lập danh sách để thiết lập.", 4000, 250, 80);
		}
	}

	private void checkBoxDanhquaiTrain_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_28 = Convert.ToByte(checkBoxDanhquaiTrain.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTDPHettien_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_29 = Convert.ToByte(checkBoxTDPHettien.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxToadoVong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_30 = Convert.ToByte(checkBoxToadoVong.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void linkLabelPhimChaynhim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string str = "https://youtu.be/GP7cr4qJIHA";
		Class20.smethod_40(Class55.smethod_0(), "", str, 0);
		string text = "Xem video hướng dẫn tại: " + Class47.string_3 + str;
		FormTip.smethod_0(string_1, text, 600000, 250, 80);
	}

	private void textBoxTenacTimVST_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			string_7 = textBoxTenacTimVST.Text;
			Class55.smethod_10(Class47.string_0, "TenAcCantimVST", Class11.smethod_17(string_7), "", 0);
		}
	}

	private void checkBoxBaokenhbang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_41 = Convert.ToByte(checkBoxBaokenhbang.Checked);
			Class55.smethod_10(Class47.string_0, "flagBaoKenhBangVST", int_41, "", 0);
		}
	}

	private void textBoxThoigianVST_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_43 = Class11.smethod_12(textBoxThoigianVST.Text);
			if (int_43 < 1)
			{
				int_43 = 1;
			}
			Class55.smethod_10(Class47.string_0, "ThoigianVST", int_43, "", 0);
		}
	}

	private void buttonPasteVST_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Clipboard.GetText();
			if (text != null && !(text == string.Empty))
			{
				text = text.Replace("/", "").Replace(" ", "");
				textBoxTenacTimVST.Text = text;
			}
		}
		catch
		{
		}
	}

	private void buttonCopyVST_Click(object sender, EventArgs e)
	{
		try
		{
			if (textBoxToadoVST.Text != null && textBoxToadoVST.Text != string.Empty)
			{
				Clipboard.SetText(textBoxToadoVST.Text);
			}
		}
		catch
		{
		}
	}

	private void checkBoxRoom_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_42 = Convert.ToByte(checkBoxRoom.Checked);
			Class55.smethod_10(Class47.string_0, "flagBaoKenhRoomVST", int_42, "", 0);
		}
	}

	private void checkBoxCungMucTieu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_33 = Convert.ToByte(checkBoxCungMucTieu.Checked);
			Class55.smethod_10(Class47.string_0, "flagCungMuctieu", int_33, "", 0);
		}
	}

	private void buttonMuctieu_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
		}
		else
		{
			try
			{
				FormTuychon.int_1 = 202;
				FormTuychon formTuychon = new FormTuychon();
				formTuychon.Show();
			}
			catch
			{
			}
		}
	}

	private void textBoxNhapSLTest_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			FormLocdoTest.int_2 = Class11.smethod_12(textBoxNhapSLTest.Text);
			Class55.smethod_10(Class47.string_0, "NhapSoluongTest", FormLocdoTest.int_2, "", 0);
		}
	}

	private void textBoxNhapSoluongClickNPC_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			FormClickNPC.int_5 = Class11.smethod_12(textBoxNhapSoluongClickNPC.Text);
			Class55.smethod_10(Class47.string_0, "NhapSoluongClickNPC", FormClickNPC.int_5, "", 0);
		}
	}

	private void checkBoxMuaThontran_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_92 = Convert.ToByte(checkBoxMuaThontran.Checked);
			Class55.smethod_10(Class47.string_0, "flagMuaThonTran", int_92, "", 0);
		}
	}

	private void checkBoxDanhQuaiTrenduongdi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_31 = Convert.ToByte(checkBoxDanhQuaiTrenduongdi.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxQuayquai_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_32 = Convert.ToByte(checkBoxQuayquai.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxChuyenChieuTrai1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_133[0] = Convert.ToByte(checkBoxChuyenChieuTrai1.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxChuyenChieuTrai2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_134[0] = Convert.ToByte(checkBoxChuyenChieuTrai2.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxChuyenChieuTrai3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_135[0] = Convert.ToByte(checkBoxChuyenChieuTrai3.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxChuyenChieuTrai1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_133[2] = Class11.smethod_12(textBoxChuyenChieuTrai1.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxChuyenChieuTrai2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_134[2] = Class11.smethod_12(textBoxChuyenChieuTrai2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxChuyenChieuTrai3_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_135[2] = Class11.smethod_12(textBoxChuyenChieuTrai3.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxChuyenChieuPhai1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_136[0] = Convert.ToByte(checkBoxChuyenChieuPhai1.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxChuyenChieuPhai2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_137[0] = Convert.ToByte(checkBoxChuyenChieuPhai2.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxChuyenChieuPhai3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_138[0] = Convert.ToByte(checkBoxChuyenChieuPhai3.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxChuyenChieuPhai1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_136[2] = Class11.smethod_12(textBoxChuyenChieuPhai1.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxChuyenChieuPhai2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_137[2] = Class11.smethod_12(textBoxChuyenChieuPhai2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxChuyenChieuPhai3_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_138[2] = Class11.smethod_12(textBoxChuyenChieuPhai3.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private int method_28(ComboBox comboBox_0, GStruct36[] gstruct36_0)
	{
		string text = comboBox_0.Text;
		if (gstruct36_0 != null)
		{
			for (int i = 0; i < gstruct36_0.Length; i++)
			{
				if (gstruct36_0[i].string_0 == text)
				{
					return gstruct36_0[i].int_1;
				}
			}
		}
		return 0;
	}

	private void comboBoxChuyenChieuTrai1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_133[1] = method_28(comboBoxChuyenChieuTrai1, gstruct42_0[num].gstruct36_0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxChuyenChieuTrai2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_134[1] = method_28(comboBoxChuyenChieuTrai2, gstruct42_0[num].gstruct36_0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxChuyenChieuTrai3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_135[1] = method_28(comboBoxChuyenChieuTrai3, gstruct42_0[num].gstruct36_0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxChuyenChieuPhai1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_136[1] = method_28(comboBoxChuyenChieuPhai1, gstruct42_0[num].gstruct36_0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxChuyenChieuPhai2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_137[1] = method_28(comboBoxChuyenChieuPhai2, gstruct42_0[num].gstruct36_0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxChuyenChieuPhai3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_138[1] = method_28(comboBoxChuyenChieuPhai3, gstruct42_0[num].gstruct36_0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonLogin_Click(object sender, EventArgs e)
	{
		if (FormLogin.bool_0)
		{
			FormLogin.bool_0 = false;
		}
		else
		{
			try
			{
				FormLogin formLogin = new FormLogin();
				formLogin.int_0 = base.Left;
				formLogin.int_1 = base.Top;
				formLogin.int_2 = base.Width;
				formLogin.int_3 = base.Height;
				formLogin.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonFixGameTuthoat_Click(object sender, EventArgs e)
	{
		if (FormCompatibility.bool_0)
		{
			FormCompatibility.bool_0 = false;
		}
		else
		{
			try
			{
				FormCompatibility formCompatibility = new FormCompatibility();
				formCompatibility.int_0 = Cursor.Position.X;
				formCompatibility.int_1 = Cursor.Position.Y;
				formCompatibility.int_2 = base.Width;
				formCompatibility.int_3 = base.Height;
				formCompatibility.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxGameHu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_64 = Convert.ToByte(checkBoxGameHu.Checked);
			Class55.smethod_10(Class47.string_0, "flagLoaiboGameHu", int_64, "", 0);
		}
	}

	private void checkBoxTranphai1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_139[0] = Convert.ToByte(checkBoxTranphai1.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTranphai2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_140[0] = Convert.ToByte(checkBoxTranphai2.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTranphai3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_141[0] = Convert.ToByte(checkBoxTranphai3.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxTranphai1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_139[1] = method_28(comboBoxTranphai1, gstruct42_0[num].gstruct36_0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxTranphai2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_140[1] = method_28(comboBoxTranphai2, gstruct42_0[num].gstruct36_0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxTranphai3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_141[1] = method_28(comboBoxTranphai3, gstruct42_0[num].gstruct36_0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTranphai1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_139[2] = Class11.smethod_12(textBoxTranphai1.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTranphai2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_140[2] = Class11.smethod_12(textBoxTranphai2.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxTranphai3_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_141[2] = Class11.smethod_12(textBoxTranphai3.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxSudungDataNguoidung_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_7 && timer_0.Enabled)
		{
			Class47.int_6 = Convert.ToByte(checkBoxSudungDataNguoidung.Checked);
			buttonCapnhatData.Enabled = (Class47.int_6 > 0 || bool_1);
			Class55.smethod_10(Class47.string_0, "fDataGameByUser", Class47.int_6, "", 0);
			new Thread(method_11).Start();
		}
	}

	private void buttonSosanh_Click(object sender, EventArgs e)
	{
		new Thread(Class47.smethod_27).Start();
	}

	private void comboBoxChuyenThuoc_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || gstruct42_0 == null)
		{
			return;
		}
		bool_7 = false;
		string_16 = null;
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (0 > num)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				GStruct42 gStruct = gstruct42_0[i];
				int[] array = new int[1];
				Class69.smethod_30(gStruct, ref string_16, -1, array);
			}
		}
		else
		{
			GStruct42 gStruct2 = gstruct42_0[num];
			int[] array = new int[1];
			Class69.smethod_30(gStruct2, ref string_16, -1, array);
		}
		if (string_16 != null)
		{
			Array.Sort(string_16);
			comboBoxChuyenThuoc.Items.Clear();
			for (int i = 0; i < string_16.Length; i++)
			{
				comboBoxChuyenThuoc.Items.Add(Class10.smethod_1(string_16[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_7 = true;
	}

	private void comboBoxChuyenThuoc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_16 == null)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxChuyenThuoc.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_16.Length)
			{
				if (text == Class10.smethod_1(string_16[num2], 1))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].string_12 = string_16[num2];
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void checkBoxTubaoDanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_44[0] = Convert.ToByte(checkBoxTubaoDanh.Checked);
		}
	}

	private void comboBoxVaodiemBaodanh_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		string text = comboBoxVaodiemBaodanh.Text;
		int num = 0;
		while (true)
		{
			if (num < string_25.Length)
			{
				if (text == string_25[num])
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		if (int_44[1] != num)
		{
			int_44[1] = num;
			Class55.smethod_10(Class47.string_0, "BaodanhTK", int_44[1], "", 0);
		}
	}

	private void checkBoxVaomapAchinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_45 = Convert.ToByte(checkBoxVaomapAchinh.Checked);
			Class55.smethod_10(Class47.string_0, "flagVaoMapCTCCoAcchinh", int_45, "", 0);
		}
	}

	private void buttonTuTimWeb_Click(object sender, EventArgs e)
	{
		if (Class7.bool_0)
		{
			buttonTuTimWeb.Enabled = false;
		}
		else if (string_4 != null)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			if (string_4.GetLength(0) > 1)
			{
				text = string_4[1, 0];
			}
			if (string_4.GetLength(0) > 2)
			{
				text2 = string_4[2, 0];
			}
			string str = "NẾU KHÔNG TÌM ĐƯỢC WEB TRONG DANH SÁCH CỦA AUTO, THÌ TỰ LÀM NHƯ SAU:||1. Bỏ check tên ac phụ trên auto.|2. Đem ac chính lên bản đồ khó đi nào đó.|3. Chọn web XXX nào đó, ví dụ XXX là " + string_4[0, 0] + "|4. Check lại tên ac phụ, để ac phụ tiến hành tìm ac chính.||Nếu ac phụ đi Thần Hành phù lên được chỗ ac chính thì quá tốt, dừng lại, THP của web đang chọn là dùng được, ta chọn web đó.||Nếu ac phụ không đi được Thần Hành phù, thì tiếp tục làm lại bước 3. ";
			if (text != string.Empty)
			{
				str = str + "Nhưng chọn XXX là web khác nhé, ví dụ là: " + text;
			}
			if (text2 != string.Empty)
			{
				str = ((text == string.Empty) ? (str + "Nhưng chọn XXX là web khác nhé, ví dụ là: " + text2) : (str + ", " + text2 + ", v.v.. cứ thế tiếp tục cho đến khi nào được thì thôi."));
			}
			FormTip.smethod_0(string_1, str, 3000000, 420, 240);
		}
	}

	private void checkBoxTatMuamauTK_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_86 = Convert.ToByte(checkBoxTatMuamauTK.Checked);
			Class55.smethod_10(Class47.string_0, "flagTatMuamauTK", int_86, "", 0);
		}
	}

	private void buttonToadoPK_Click(object sender, EventArgs e)
	{
		if (FormPhongKy1.bool_0)
		{
			FormPhongKy1.bool_0 = false;
		}
		else
		{
			try
			{
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (num >= 0)
				{
					FormPhongKy1.int_4 = gstruct42_0[num].int_129;
					FormPhongKy1 formPhongKy = new FormPhongKy1();
					formPhongKy.int_0 = base.Left;
					formPhongKy.int_1 = base.Top;
					formPhongKy.int_2 = base.Width;
					formPhongKy.int_3 = base.Height;
					formPhongKy.Show();
				}
			}
			catch
			{
			}
		}
	}

	private void checkBoxBatdauVanSuthong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].bool_60 = checkBoxBatdauVanSuthong.Checked;
			}
		}
	}

	private void buttonPhimTat_Click(object sender, EventArgs e)
	{
		if (FormPhimtat.bool_0)
		{
			FormPhimtat.bool_0 = false;
		}
		else
		{
			try
			{
				FormPhimtat formPhimtat = new FormPhimtat();
				formPhimtat.int_0 = Cursor.Position.X;
				formPhimtat.int_1 = Cursor.Position.Y;
				formPhimtat.int_2 = base.Width;
				formPhimtat.int_3 = base.Height;
				formPhimtat.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxNhatqua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_125[0] = Convert.ToByte(checkBoxNhatqua.Checked);
			}
		}
	}

	private void labelLocdo_Click(object sender, EventArgs e)
	{
		if (FormLocdo.bool_0)
		{
			FormLocdo.bool_0 = false;
		}
		else
		{
			try
			{
				FormLocdo.int_4 = 0;
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (0 <= num)
				{
					FormLocdo.int_4 = gstruct42_0[num].int_129;
				}
				FormLocdo formLocdo = new FormLocdo();
				formLocdo.int_0 = base.Left;
				formLocdo.int_1 = base.Top;
				formLocdo.int_2 = base.Width;
				formLocdo.int_3 = base.Height;
				formLocdo.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxBossSatthu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_126[0] = Convert.ToByte(checkBoxBossSatthu.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxTinSu_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxTinSu.Text;
		for (int i = 0; i < string_26.Length; i++)
		{
			if (text == string_26[i])
			{
				num2 = i;
				break;
			}
		}
		gstruct42_0[num].int_21[1] = num2;
		method_29(num2 > 0 && gstruct42_0[num].int_21[0] <= 0);
		checkBoxChoPTdanhsach.Enabled = (num2 == 0);
		comboBoxTinSu.Enabled = (num2 == 0);
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void checkBoxChayTinsu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				int num2 = Convert.ToByte(checkBoxChayTinsu.Checked);
				gstruct42_0[num].int_21[0] = num2;
				method_29(num2 <= 0 && gstruct42_0[num].int_21[1] > 0);
				comboBoxTinSu.Enabled = (num2 <= 0);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void method_29(bool bool_14)
	{
		checkBoxMuathuocPK.Enabled = bool_14;
		checkBoxChaydanhvong.Enabled = bool_14;
		checkBoxChayPKNguoidung.Enabled = bool_14;
		buttonToadoPK.Enabled = bool_14;
	}

	private void checkBoxONha_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_126[4] = Convert.ToByte(checkBoxONha.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxBosSatthu_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxBosSatthu.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < Class88.struct29_0.Length)
			{
				if (text == Class88.struct29_0[num2].string_0)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		gstruct42_0[num].int_126[3] = num2;
		Class47.smethod_11(gstruct42_0[num]);
	}

	private void buttonSatthuAll_Click(object sender, EventArgs e)
	{
		int num = 0;
		string text = comboBoxBosSatthu.Text;
		for (int i = 0; i < Class88.struct29_0.Length; i++)
		{
			if (text == Class88.struct29_0[i].string_0)
			{
				num = i;
				break;
			}
		}
		int num2 = Convert.ToByte(checkBoxBossSatthu.Checked);
		int num3 = Convert.ToByte(checkBoxONha.Checked);
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				gstruct42_0[i].int_126[0] = num2;
				gstruct42_0[i].int_126[3] = num;
				gstruct42_0[i].int_126[4] = num3;
				Class47.smethod_11(gstruct42_0[i]);
			}
		}
	}

	private void buttonNhatquaAll_Click(object sender, EventArgs e)
	{
		int num = Convert.ToByte(checkBoxNhatqua.Checked);
		int num2 = Convert.ToByte(checkBoxGioClick.Checked);
		int num3 = (int)numericUpDownHH.Value;
		int num4 = (int)numericUpDownMM.Value;
		int num5 = (int)numericUpDownSS.Value;
		int num6 = Class11.smethod_12(textBoxPhamviNhatqua.Text);
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				gstruct42_0[i].int_125[0] = num;
				gstruct42_0[i].int_125[1] = num2;
				gstruct42_0[i].int_125[2] = num3;
				gstruct42_0[i].int_125[3] = num4;
				gstruct42_0[i].int_125[4] = num5;
				gstruct42_0[i].int_125[5] = num6;
			}
		}
	}

	private void buttonTinsuAll_Click(object sender, EventArgs e)
	{
		int num = 0;
		int num2 = Convert.ToByte(checkBoxChayTinsu.Checked);
		bool @checked = checkBoxMuathuocPK.Checked;
		bool checked2 = checkBoxChaydanhvong.Checked;
		string text = comboBoxTinSu.Text;
		for (int i = 0; i < string_26.Length; i++)
		{
			if (text == string_26[i])
			{
				num = i;
				break;
			}
		}
		if (gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (num > 1)
			{
				gstruct42_0[i].bool_9 = @checked;
				gstruct42_0[i].bool_8 = checked2;
			}
			gstruct42_0[i].int_21[1] = num;
			gstruct42_0[i].int_21[0] = num2;
			Class47.smethod_11(gstruct42_0[i]);
		}
	}

	private void checkBoxKhongLuuruong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			Class88.int_1 = Convert.ToByte(checkBoxKhongLuuruong.Checked);
			Class55.smethod_10(Class47.string_0, "BosSatthuKhongLuuRuong", Class88.int_1, "", 0);
		}
	}

	private void checkBoxGhepSTG_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			Class88.int_2 = Convert.ToByte(checkBoxGhepSTG.Checked);
			Class55.smethod_10(Class47.string_0, "TuGhepSTG", Class88.int_2, "", 0);
		}
	}

	private void buttonGhepSTG_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		GStruct42 gStruct = gstruct42_0[num];
		if (!gStruct.bool_36)
		{
			return;
		}
		if (gStruct.int_126[0] <= 0)
		{
			if (int_20 == 0)
			{
				Class88.int_3 = gStruct.int_129;
				new Thread(Class88.smethod_2).Start();
			}
			else
			{
				string text = "Chức năng này chỉ sử dụng được khi ở chế độ WAR.";
				FormTip.smethod_0(string_1, text, 600000, 300, 80, bool_5: false, base.Left, base.Top);
			}
		}
		else
		{
			string text = "Ac đang chạy boss sát thủ, chỉ cần check vào mục [v] Tự ghép STG, thì khi nào ac về thành nhận nhiệm vụ lúc đó ac sẽ tự ghép Sát thủ giản luôn.";
			FormTip.smethod_0(string_1, text, 600000, 400, 140, bool_5: false, base.Left, base.Top);
		}
	}

	private void checkBoxBossSTtuhuy_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			Class88.int_0 = Convert.ToByte(checkBoxBossSTtuhuy.Checked);
			Class55.smethod_10(Class47.string_0, "BosSatthuTuHuyNhiemvu", Class88.int_0, "", 0);
			if (Class88.int_0 > 0)
			{
				string text = "Tự hủy nhiệm vụ hiện tại và nhận nhiệm vụ mới. Điều kiện để auto tự Kích hoạt tự hủy nhiệm vụ là:||- Đây là ac không có tổ đội, hoặc là đội trưởng|- Ac đang đứng nơi vị trí boss xuất hiện.|- Sau 60 giây nếu boss không xuất hiện thì sẽ tự hủy.||Do vậy, nếu đang săn boss tổ đội thì ac đội trưởng (chủ PT) phải đi săn boss luôn chứ không được ở nhà nhé.";
				FormTip.smethod_0(string_1, text, 600000, 360, 200, bool_5: false, base.Left, base.Top);
			}
		}
	}

	private void buttonNgaMybuff_Click(object sender, EventArgs e)
	{
		if (FormNgamyBuff.bool_0)
		{
			FormNgamyBuff.bool_0 = false;
		}
		else
		{
			try
			{
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (num >= 0)
				{
					FormNgamyBuff.int_4 = gstruct42_0[num].int_129;
					FormNgamyBuff formNgamyBuff = new FormNgamyBuff();
					formNgamyBuff.int_0 = Cursor.Position.X;
					formNgamyBuff.int_1 = Cursor.Position.Y;
					formNgamyBuff.int_2 = base.Width;
					formNgamyBuff.int_3 = base.Height;
					formNgamyBuff.Show();
				}
			}
			catch
			{
			}
		}
	}

	private void checkBoxGopVatpham_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_67 = Convert.ToByte(checkBoxGopVatpham.Checked);
			Class55.smethod_10(Class47.string_0, "flagMuaGop", int_67, "", 0);
		}
	}

	private void checkBoxMuaKytrancac_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_66 = Convert.ToByte(checkBoxMuaKytrancac.Checked);
			Class55.smethod_10(Class47.string_0, "flagMuaKTC", int_66, "", 0);
		}
	}

	private void comboBoxMuaVatpham_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		bool_7 = false;
		string_16 = Class69.smethod_29(gstruct42_0[num]);
		comboBoxMuaVatpham.Items.Clear();
		if (string_16 != null)
		{
			Array.Sort(string_16);
			for (int i = 0; i < string_16.Length; i++)
			{
				comboBoxMuaVatpham.Items.Add(Class10.smethod_1(string_16[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_7 = true;
	}

	private void comboBoxMuaVatpham_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_16 == null)
		{
			return;
		}
		string text = comboBoxMuaVatpham.Text;
		int num = 0;
		while (true)
		{
			if (num < string_16.Length)
			{
				if (text == Class10.smethod_1(string_16[num], 1))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		string_18 = string_16[num];
		Class55.smethod_10(Class47.string_0, "NameMuaGop", string_18, "", 0);
	}

	private void pictureBoxQC_Click(object sender, EventArgs e)
	{
		if (Class90.gstruct52_0 == null || pictureBoxQC.ImageLocation == string.Empty || pictureBoxQC.ImageLocation == null)
		{
			return;
		}
		if (Class90.gstruct52_0.Length <= int_123 || Class90.gstruct52_0[int_123].string_2 == null || Class90.gstruct52_0[int_123].string_2 == string.Empty)
		{
			int_123 = -1;
			for (int i = 0; i < Class90.gstruct52_0.Length; i++)
			{
				if (Class90.gstruct52_0[i].string_2 != null && Class90.gstruct52_0[i].string_2 != string.Empty)
				{
					int_123 = i;
					break;
				}
			}
		}
		if (int_123 >= 0)
		{
			string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			if (!Class11.smethod_18(text))
			{
				text = Class55.smethod_0();
			}
			Class20.smethod_40(text, "", Class90.gstruct52_0[int_123].string_2, 0);
		}
	}

	private void textBoxIdMua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_124 = Class11.smethod_12(textBoxIdMua.Text);
			}
		}
	}

	private void buttonHelp_Click(object sender, EventArgs e)
	{
		string str = FormVideoHelp.string_1;
		if (string_6 != null && string_6 != string.Empty)
		{
			str = str + "|==============================================|PHIÊN BẢN MỚI:||" + string_6;
		}
		string str2 = string.Empty;
		if (GClass1.string_0 != null)
		{
			for (int i = 0; i < GClass1.string_0.Length; i++)
			{
				str2 = str2 + GClass1.string_0[i] + ";";
			}
			str = str + "|==============================================|Xem thêm: " + Class11.smethod_17(str2) + "|";
		}
		FormTip.smethod_0(string_1, str, 600000, 450, 540, bool_5: false, base.Left, base.Top);
	}

	private void comboBoxPk_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_100[1] = Class11.smethod_12(comboBoxPk.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxMuaDungSoluong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_68[0] = Convert.ToByte(checkBoxMuaDungSoluong.Checked);
			Class55.smethod_10(Class47.string_0, "MDSL0", int_68[0], "", 0);
		}
	}

	private void textBoxMuadungSoLuong_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_68[1] = Class11.smethod_12(textBoxMuadungSoLuong.Text);
			Class55.smethod_10(Class47.string_0, "MDSL1", int_68[1], "", 0);
		}
	}

	private void buttonHelpMua_Click(object sender, EventArgs e)
	{
		string text = "HƯỚNG DẪN MUA GỘP VÀ SỬ DỤNG||1. Chọn tên vật phẩm cần mua.|2. Nhập số lượng nếu mua gộp sử dụng theo số lượng.||Bấm nút thực hiện lệnh.||Lưu ý: Khi mua ở shop tạp hóa, thợ rèn.. thì phải mở shop lên trước (rồi tắt shop đi cho dễ gộp)... còn mua ở KTC thì auto sẽ tự mở.||Chi phí mua (tiền vạn, hoặc tiền xu, kim bảo...) phải để sẵn trong hành trang.||[v] Bỏ qua bước nhập Mã KTC:||Khi vật phẩm có mặt trong Kỳ trân các nhưng auto không chắc chắn xác định được thứ tự vật phẩm thì sẽ yêu cầu mã xác nhận (xuất hiện dòng chữ nhấp nháy trên đầu nhân vật yêu cầu nhập mã).||Nếu sau khi nhập mã, nhân vật mua được vật phẩm mà không bị diss game thì bạn có thể check mục bỏ qua để khỏi yêu cầu nhập mã lần nữa. Ngược lại nếu bị diss game thì vật phẩm này không mua được bằng auto.";
		FormTip.smethod_0(string_1, text, 600000, 420, 340, bool_5: false, base.Left, base.Top);
	}

	private void checkBoxBoquaMaKTC_CheckedChanged(object sender, EventArgs e)
	{
		bool_4 = checkBoxBoquaMaKTC.Checked;
	}

	private void buttonStopNhatqua_Click(object sender, EventArgs e)
	{
		checkBoxNhatqua.Checked = false;
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				gstruct42_0[i].int_125[0] = 0;
			}
		}
	}

	private void buttonTHP_Click(object sender, EventArgs e)
	{
		method_30();
	}

	private void method_30()
	{
		if (gstruct42_0 == null)
		{
			return;
		}
		int_133 = 0;
		string text = comboBoxTHP.Text;
		for (int i = 0; i < string_12.GetLength(0); i++)
		{
			if (text == string_12[i, 0])
			{
				string_36 = string_12[i, 1];
				int_133 = Class11.smethod_12(string_36);
				break;
			}
		}
		if (int_133 > 0)
		{
			int num = -1;
			string_36 = comboBoxPhuong.Text;
			for (int i = 0; i < string_13.GetLength(0); i++)
			{
				if (string_36 == string_13[i, 0])
				{
					string_36 = string_13[i, 1];
					num = i;
					break;
				}
			}
			if (int_133 == 162 && num != 3 && num != 4)
			{
				string_36 = "b¾c";
			}
			else if (int_133 == 76 && (num == 1 || num == 4))
			{
				string_36 = "®«ng|§«ng";
			}
		}
		if (Class38.gstruct29_0.int_0 > 0)
		{
			int_132 = Class38.gstruct29_0.int_0;
			new Thread(smethod_3).Start();
			Thread.Sleep(100);
		}
		try
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				if (gstruct42_0[i].bool_36 && gstruct42_0[i].int_129 != Class38.gstruct29_0.int_0)
				{
					int num2 = 0;
					while (int_132 > 0 && num2 < 10)
					{
						Thread.Sleep(60);
						num2++;
					}
					int_132 = gstruct42_0[i].int_129;
					new Thread(smethod_3).Start();
				}
			}
		}
		catch
		{
		}
	}

	private static void smethod_3()
	{
		int num = int_132;
		int num2 = int_133;
		string string_ = string_36;
		int_132 = 0;
		int num3 = Class71.smethod_3(gstruct42_0, num);
		if (num3 >= 0)
		{
			if (num2 <= 0)
			{
				Class31.smethod_62(gstruct42_0[num3], string_);
			}
			else
			{
				Class31.smethod_61(gstruct42_0[num3], num2, string_);
			}
		}
	}

	private void buttonPT_Click(object sender, EventArgs e)
	{
		if (FormPT.bool_0)
		{
			FormPT.bool_0 = false;
		}
		else
		{
			try
			{
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (num >= 0)
				{
					FormPT.gstruct42_0 = gstruct42_0[num];
					FormPT formPT = new FormPT();
					formPT.int_0 = Cursor.Position.X;
					formPT.int_1 = Cursor.Position.Y;
					formPT.int_2 = base.Width;
					formPT.int_3 = base.Height;
					formPT.Show();
				}
			}
			catch
			{
			}
		}
	}

	private void checkBoxBosBaobos_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_1 = Convert.ToByte(checkBoxBosBaobos.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void comboBoxTHP_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7 && comboBoxTHP.Text == "Hướng dẫn")
		{
			string text = "Các bạn bấm phím tương ứng ký tự đầu tiên của tên map để nhảy nhanh đến mục cần chọn.||Ví dụ đi Sa mạc 1 thì bạn gõ số 1, đi Dương Châu thì bạn gõ chữ D .v.v..";
			FormTip.smethod_0(string_1, text, 60000, 250, 120);
		}
	}

	private void textBoxSoluongChuyenthuoc_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_75[3] = Class11.smethod_12(textBoxSoluongChuyenthuoc.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void textBoxChuyenThuocMin_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_75[2] = Class11.smethod_12(textBoxChuyenThuocMin.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxTuChuyenThuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_75[0] = Convert.ToByte(checkBoxTuChuyenThuoc.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxRuongBH_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_77 = Convert.ToByte(checkBoxRuongBH.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonHDChuyenthuoc_Click(object sender, EventArgs e)
	{
		string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(text))
		{
			text = Class55.smethod_0();
		}
		Class20.smethod_40(text, "", "https://youtu.be/XRljjxiuyk8", 0);
	}

	private void checkBoxBamPhimCong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_75[1] = Convert.ToByte(checkBoxBamPhimCong.Checked);
				Class47.smethod_11(gstruct42_0[num]);
				checkBoxTuChuyenThuoc.Enabled = !checkBoxBamPhimCong.Checked;
				textBoxChuyenThuocMin.Enabled = !checkBoxBamPhimCong.Checked;
			}
		}
	}

	private void checkBoxTTL_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_60 = Convert.ToByte(checkBoxTTL.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonLuuCauhinhAll_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			GStruct42 gStruct = gstruct42_0[num];
			string str = string.Empty;
			if (gStruct.string_21 != null && gStruct.string_21 != string.Empty)
			{
				str = gStruct.string_21 + "_";
			}
			string string_ = string_37;
			if (string_37 == null || string_37 == string.Empty)
			{
				string_ = Class47.string_4 + "\\Save";
			}
			Class11.smethod_8(string_);
			string text = Class47.smethod_25(string_, str + Class10.smethod_1(gStruct.string_20, 1) + ".txt");
			if (text != null && text != string.Empty)
			{
				Class47.smethod_11(gStruct, text);
			}
		}
	}

	private void buttonDocCauhinh_Click(object sender, EventArgs e)
	{
		string string_ = string_37;
		if (string_37 == null || string_37 == string.Empty)
		{
			string_ = Class47.string_4 + "\\Save";
		}
		Class11.smethod_8(string_);
		string text = Class47.smethod_24(string_, "", "*.txt");
		if (!(text == string.Empty))
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (0 <= num)
			{
				Class47.smethod_8(ref gstruct42_0[num], text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonAchinh_Click(object sender, EventArgs e)
	{
		if (FormAchinh.bool_0)
		{
			FormAchinh.bool_0 = false;
		}
		else
		{
			try
			{
				FormAchinh formAchinh = new FormAchinh();
				formAchinh.int_1 = base.Left;
				formAchinh.int_2 = base.Top;
				formAchinh.int_3 = base.Width;
				formAchinh.int_4 = base.Height;
				formAchinh.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonBien_Click(object sender, EventArgs e)
	{
		uint num = 0u;
		uint num2 = 0u;
		if (Class38.gstruct29_1.uint_4 != null)
		{
			num = Class38.gstruct29_1.uint_4[0];
			num2 = Class38.gstruct29_1.uint_4[1];
		}
		string text = "ACCFake.MapId              : " + Class38.gstruct29_1.int_4 + "|ACCFake.CharMode           : " + Class38.gstruct29_1.int_3 + "|ACCFake.ToadoX             : " + num + "|ACCFake.ToadoY             : " + num2 + "|ACCFake.Exists             : " + Class38.gstruct29_1.int_6 + "|ACCFake.IDTarget           : " + Class38.gstruct29_1.uint_3 + "|FormMain.flagDanhChienlongdong    : " + int_108 + "|FormMain.IndexPK              : " + int_20 + "|FormMain.IdexChientruongChinh : " + int_100 + "|FormMain.IdexChientruongPhu   : " + int_102 + "|_KeoxeCLD.IndexChienlongdong   : " + Class16.int_0 + "|FormMain.flagTimtrongthanh    : " + int_22 + "|FormMain.flagDanhnguoi        : " + int_30 + "|FormMain.flagDanhquai         : " + int_31 + "|FormMain.flagUutienBoss       : " + int_32 + "|ACCFake.flagPheThuTamtru   : " + Class38.gstruct29_1.int_10 + "|ACCFake.Pk                 : " + Class38.gstruct29_1.int_2 + "|FormMain.flagDanhTamtru       : " + int_24 + "|FormMain.flagAccPhuChoAccChinh    : " + int_84 + "|FormDame.flagDameMacdinh   : " + FormDame.int_6 + "|FormDame.IdexKieudanh      : " + FormDame.int_5 + "|FormDame.SwicthDame        : " + FormDame.int_8 + "|ACCFake.MousePos   : " + Class38.gstruct29_1.uint_5 + "|ACCFake.KeyPress   : " + Class38.gstruct29_1.int_7 + "|ACCFake.IDTarget   : " + Class38.gstruct29_1.uint_3 + "|FormMain.flagCungMuctieu  : " + int_33 + "|FormMain.flagTutimMuctieu : " + int_34 + "|FormMain.flagTimAccchinh  : " + int_21 + "|ACCFake.CodeFake   : " + Class38.gstruct29_1.int_9 + "|ACCFake.PLRId      : " + Class38.gstruct29_1.uint_2 + "|FormMain.flagRabangTrinhsat   : " + int_85 + "|ACCFake.KeyAttack      : " + Class38.gstruct29_1.int_8 + "|FormMain.BaodanhTK[0]     : " + int_44[0] + "|FormMain.BaodanhTK[1]     : " + int_44[1] + "|ACCFake.CodeFake   : " + Class38.gstruct29_1.int_9;
		FormTip.smethod_0(string_1, text, 600000, 450, 540, bool_5: false, base.Left, base.Top);
	}

	private void buttonBoss_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
		}
		else
		{
			try
			{
				FormTuychon.int_1 = 201;
				FormTuychon formTuychon = new FormTuychon();
				formTuychon.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonNamIm_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
		}
		else
		{
			try
			{
				FormTuychon.int_1 = 203;
				FormTuychon formTuychon = new FormTuychon();
				formTuychon.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonBaoBoss_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
		}
		else
		{
			try
			{
				FormTuychon.int_1 = 5;
				FormTuychon formTuychon = new FormTuychon();
				formTuychon.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxChayRunAdmin_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			Class20.int_34 = Convert.ToByte(checkBoxChayRunAdmin.Checked);
			Class55.smethod_10(Class47.string_0, "RunAdmin", Class20.int_34, "", 0);
			Class20.smethod_70();
		}
	}

	private void textBoxPhamviNhatqua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_125[5] = Class11.smethod_12(textBoxPhamviNhatqua.Text);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonHuongdanCanhbos_Click(object sender, EventArgs e)
	{
		string str = "https://youtu.be/bEpu8rfT7A8";
		string text = "Phim Hướng dẫn xem ở đây:|" + str + "||* Trường hợp check vào [v] Tất cả ac luôn đến tọa độ:|Nếu muốn ac A đến tọa độ, nhưng lại không muốn ac B đến|=> Bạn phải  bấm nút < xóa > để cho ac B rỗng tọa độ nhé.||* Trường hợp kéo nhiều máy, thì ở máy phụ bạn phải lấy tọa độ trước hoặc phải check vào mục [v] Máy phụ đến tọa độ.||Lưu ý: Tất cả các chức năng trong auto, nếu là chữ màu nâu đỏ thì nó được áp dụng cho toàn cục, còn chữ đen hoặc xanh thì áp dụng cho từng ac";
		FormTip.smethod_0(string_1, text, 600000, 360, 240, bool_5: false, base.Left, base.Top);
		string text2 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(text2))
		{
			text2 = Class55.smethod_0();
		}
		Class20.smethod_40(text2, "", str, 0);
	}

	private void checkBoxDenToadoUser_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_120[0] = Convert.ToByte(checkBoxDenToadoUser.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxDenToadoALL_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_70 = Convert.ToByte(checkBoxDenToadoALL.Checked);
			Class55.smethod_10(Class47.string_0, "fDenToado", int_70, "", 0);
			checkBoxDenToadoUser.Enabled = (int_70 <= 0);
			checkBoxMayphuToado.Enabled = (int_70 > 0);
		}
	}

	private void checkBoxMayphuToado_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_72[0] = Convert.ToByte(checkBoxMayphuToado.Checked);
			Class55.smethod_10(Class47.string_0, "fMayPhuDenToado_0", int_72[0], "", 0);
		}
	}

	private void buttonXoaToado_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			int[] array = gstruct42_0[num].int_120 = new int[5];
			array = (gstruct42_0[num].int_119 = new int[3]);
			Class47.smethod_11(gstruct42_0[num]);
			textBoxToadoDen.Text = string.Empty;
		}
	}

	private void buttonLayToado_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			GStruct42 gStruct = gstruct42_0[num];
			int num2 = Class33.smethod_0(gStruct);
			string text = Class33.smethod_2(gStruct);
			uint[] array = Class32.smethod_29(gStruct);
			if (gStruct.int_120 != null && gStruct.int_120.Length == 5)
			{
				gstruct42_0[num].int_120[2] = num2;
				gstruct42_0[num].int_120[3] = (int)array[0];
				gstruct42_0[num].int_120[4] = (int)array[1];
			}
			else
			{
				gstruct42_0[num].int_120 = new int[5]
				{
					Convert.ToByte(checkBoxDenToadoUser.Checked),
					0,
					num2,
					(int)array[0],
					(int)array[1]
				};
			}
			gstruct42_0[num].int_119 = new int[3]
			{
				num2,
				(int)array[0],
				(int)array[1]
			};
			Class47.smethod_11(gstruct42_0[num]);
			string text2 = "( " + array[0] / 256u + "," + array[1] / 512u + " ) " + Class10.smethod_1(text, 1);
			textBoxToadoDen.Text = text2;
		}
	}

	private void buttonMayphuXoaToado_Click(object sender, EventArgs e)
	{
		int_72[1] = 0;
		textBoxMayphuToado.Text = string.Empty;
		Class55.smethod_10(Class47.string_0, "fMayPhuDenToado_1", 0, "", 0);
	}

	private void buttonMayphuLayToado_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			GStruct42 gStruct = gstruct42_0[num];
			int_72[1] = Class33.smethod_0(gStruct);
			string text = Class33.smethod_2(gStruct);
			uint[] array = Class32.smethod_29(gStruct);
			int_72[2] = (int)array[0];
			int_72[3] = (int)array[1];
			string text2 = "( " + array[0] / 256u + "," + array[1] / 512u + " ) " + Class10.smethod_1(text, 1);
			textBoxMayphuToado.Text = text2;
			Class55.smethod_10(Class47.string_0, "fMayPhuDenToado_1", int_72[1], "", 0);
			Class55.smethod_10(Class47.string_0, "fMayPhuDenToado_2", int_72[2], "", 0);
			Class55.smethod_10(Class47.string_0, "fMayPhuDenToado_3", int_72[3], "", 0);
		}
	}

	private void textBoxKhoangCachAccChinh_Leave(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_23 = Class11.smethod_12(textBoxKhoangCachAccChinh.Text);
			if (int_23 < 150)
			{
				int_23 = 150;
			}
			if (textBoxKhoangCachAccChinh.Text != int_23.ToString())
			{
				textBoxKhoangCachAccChinh.Text = int_23.ToString();
			}
		}
	}

	private void textBoxKhoangCachAccChinh_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_23 = Class11.smethod_12(textBoxKhoangCachAccChinh.Text);
			if (int_23 < 150)
			{
				int_23 = 150;
			}
			Class55.smethod_10(Class47.string_0, "KhoangcachAccchinh", int_23, "", 0);
		}
	}

	private void checkBoxLocTrangbiNPC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			FormLocdoTest.int_4 = Convert.ToByte(checkBoxLocTrangbiNPC.Checked);
			Class55.smethod_10(Class47.string_0, "DayLaNPC", FormLocdoTest.int_4, "", 0);
		}
	}

	private void checkBoxLocTrangbiNhapSL_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			FormLocdoTest.int_3 = Convert.ToByte(checkBoxLocTrangbiNhapSL.Checked);
			Class55.smethod_10(Class47.string_0, "fCoNhapSLTest", FormLocdoTest.int_3, "", 0);
		}
	}

	private void buttonDoSat_Click(object sender, EventArgs e)
	{
		Class66.bool_1 = true;
	}

	private void checkBoxDanhHieuuy_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_90 = Convert.ToByte(checkBoxDanhHieuuy.Checked);
			Class55.smethod_10(Class47.string_0, "fHieuUyTK", int_90, "", 0);
		}
	}

	private void checkBoxTKThanhTruot_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_88[0] = Convert.ToByte(checkBoxTKThanhTruot.Checked);
			Class55.smethod_10(Class47.string_0, "TruotTK0", int_88[0], "", 0);
		}
	}

	private void textBoxTruotTK_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_88[1] = Class11.smethod_12(textBoxTruotTK.Text);
			if (int_88[1] < 100)
			{
				int_88[1] = 100;
			}
			if (int_88[1] > 300)
			{
				int_88[1] = 300;
			}
			Class55.smethod_10(Class47.string_0, "TruotTK1", int_88[1], "", 0);
		}
	}

	private void checkBoxThanhTruotSudung_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_69 = Convert.ToByte(checkBoxThanhTruotSudung.Checked);
			Class55.smethod_10(Class47.string_0, "fThanhTruotSudung", int_69, "", 0);
		}
	}

	private void linkLabelPhimCauca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string str = "https://youtu.be/mf3c182vvUk";
		Class20.smethod_40(Class55.smethod_0(), "", str, 0);
		string text = "Xem video hướng dẫn câu cá tại: " + Class47.string_3 + str;
		FormTip.smethod_0(string_1, text, 600000, 250, 80);
	}

	private void buttonKyTranCac_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
		}
		else
		{
			try
			{
				FormTuychon.int_1 = 6;
				FormTuychon formTuychon = new FormTuychon();
				formTuychon.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonMuathuocBaovat_Click(object sender, EventArgs e)
	{
		if (gstruct42_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct42_0.Length; i++)
		{
			if (gstruct42_0[i].bool_36 && gstruct42_0[i].int_76 > 0)
			{
				Class30.smethod_2(gstruct42_0[i], bool_0: true);
			}
		}
	}

	private void checkBoxVuotAi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_109 = Convert.ToByte(checkBoxVuotAi.Checked);
			Class55.smethod_10(Class47.string_0, "flagPhandame", int_109, "", 0);
		}
	}

	private void buttonThoatGame_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (0 <= num)
		{
			Class20.smethod_53(gstruct42_0[num].process_0);
		}
		Class40.smethod_5();
	}

	private void buttonDiemTapket_Click(object sender, EventArgs e)
	{
		if (FormTapKet.bool_0)
		{
			FormTapKet.bool_0 = false;
		}
		else
		{
			try
			{
				FormTapKet.int_0 = 0;
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (0 <= num)
				{
					FormTapKet.int_0 = gstruct42_0[num].int_129;
				}
				FormTapKet formTapKet = new FormTapKet();
				formTapKet.int_1 = Cursor.Position.X;
				formTapKet.int_2 = Cursor.Position.Y;
				formTapKet.int_3 = base.Width;
				formTapKet.int_4 = base.Height;
				formTapKet.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxDiemTapket_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_107 = Convert.ToByte(checkBoxDiemTapket.Checked);
			Class55.smethod_10(Class47.string_0, "flagDiemTapket", int_107, "", 0);
		}
	}

	private void checkBoxConLon_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_82 = Convert.ToByte(checkBoxConLon.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void checkBoxBossSTKhongLamHaucan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_127 = Convert.ToByte(checkBoxBossSTKhongLamHaucan.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonHuyenTinh_Click(object sender, EventArgs e)
	{
		if (FormHuyenTinh.bool_0)
		{
			FormHuyenTinh.bool_0 = false;
		}
		else
		{
			try
			{
				FormHuyenTinh.int_0 = 0;
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (0 <= num)
				{
					FormHuyenTinh.int_0 = gstruct42_0[num].int_129;
				}
				FormHuyenTinh formHuyenTinh = new FormHuyenTinh();
				formHuyenTinh.Show();
			}
			catch
			{
			}
		}
	}

	private void checkBoxAceptBH_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].bool_26 = checkBoxAceptBH.Checked;
			}
		}
	}

	private void buttonRaovat_Click(object sender, EventArgs e)
	{
		if (FormRaovat.bool_0)
		{
			FormRaovat.bool_0 = false;
		}
		else
		{
			try
			{
				FormRaovat.int_0 = 0;
				int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
				if (0 <= num)
				{
					FormRaovat.int_0 = gstruct42_0[num].int_129;
				}
				FormRaovat formRaovat = new FormRaovat();
				formRaovat.Show();
			}
			catch
			{
			}
		}
	}

	private void method_31(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string str = "https://youtu.be/dleEtu8n5fY";
		Class11.string_14 = new string[1]
		{
			"Link phim Hướng dẫn: " + str
		};
		Class20.smethod_40(Class55.smethod_0(), "", str, 0);
	}

	private void checkBoxChoPTdanhsach_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			Class57.int_2[0] = Convert.ToByte(checkBoxChoPTdanhsach.Checked);
			Class55.smethod_10(Class47.string_0, "flagChodoiPT1", Class57.int_2[0], "", 0);
		}
	}

	private void textBoxTimerPT_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			Class57.int_2[1] = Class11.smethod_12(textBoxTimerPT.Text);
			Class55.smethod_10(Class47.string_0, "flagChodoiPT2", Class57.int_2[1], "", 0);
		}
	}

	private void linkLabelHelpTinsu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "HƯỚNG DẪN CHẠY TÍN SỨ THIÊN BẢO KHỐ||Để đảm bảo PT chạy không bị rớt ac, bạn phải:|1. Check vào mục [v] Chờ đủ PT (s)|2. Check vào mục [v] PT ở Điều khiển - bảng 1.||Trong phần thiết lập PT [...] ở bảng 1, bạn chọn:||1. Check vào mục [v] Mời hoặc nhận PT theo danh sách|2. Ép tất cả ac cần chạy Tín sứ vào danh sách nhóm (bấm nút Thêm).|3. Lựa ra 1 ac trong danh sách nhóm, check vào [v] Luôn làm đội trưởng.||Xong tiến hành chạy tín sứ thiên bảo khố. Ac đội trưởng khi vào phía trong dịch quan, sẽ tự PT và kiểm tra tổ đội, nếu PT đầy đủ trong danh sách thì sẽ bắt đầu nhiệm vụ.";
		FormTip.smethod_0(string_1, text, 600000, 420, 340, bool_5: false, base.Left, base.Top);
	}

	private void buttonTatMua_Click(object sender, EventArgs e)
	{
		bool_3 = !bool_3;
		if (bool_3)
		{
			buttonTatMua.BackColor = Color.DarkGreen;
			buttonTatMua.ForeColor = Color.White;
			buttonTatMua.Text = "Bật mua tất cả ac";
		}
		else
		{
			buttonTatMua.BackColor = Color.LightSteelBlue;
			buttonTatMua.ForeColor = Color.DarkRed;
			buttonTatMua.Text = "Tắt mua tất cả ac";
		}
	}

	private void checkBoxQuangThuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_123[0] = Convert.ToByte(checkBoxQuangThuoc.Checked);
				Class47.smethod_11(gstruct42_0[num]);
			}
		}
	}

	private void buttonQuangThuoc_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
		}
		else
		{
			try
			{
				FormTuychon.int_1 = 7;
				FormTuychon formTuychon = new FormTuychon();
				formTuychon.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonHelpClickNpc_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/Dup5PcJOV5Y";
		string text2 = "https://youtu.be/YNTAHZLx7NY";
		Class20.smethod_40(Class55.smethod_0(), "", text, 0);
		string text3 = "Xem 2 video hướng dẫn tại: " + Class47.string_3 + text + Class47.string_3 + text2;
		FormTip.smethod_0(string_1, text3, 600000, 250, 80);
	}

	private void labelMuaGopStart_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0 && !gstruct42_0[num].bool_54 && !gstruct42_0[num].bool_57)
		{
			gstruct42_0[num].bool_57 = true;
			Class35.int_0 = gstruct42_0[num].int_129;
			new Thread(Class35.smethod_2).Start();
		}
	}

	private void labelMuaSudung_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0 && !gstruct42_0[num].bool_58 && !gstruct42_0[num].bool_59)
		{
			gstruct42_0[num].bool_59 = true;
			Class35.int_1 = gstruct42_0[num].int_129;
			new Thread(Class35.smethod_4).Start();
		}
	}

	private void labelMuaGopStop_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			gstruct42_0[num].bool_57 = false;
			gstruct42_0[num].bool_59 = false;
		}
	}

	private void labelMuaGopStopAll_Click(object sender, EventArgs e)
	{
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				gstruct42_0[i].bool_57 = false;
				gstruct42_0[i].bool_59 = false;
			}
		}
	}

	private void buttonClickNpcSingle_Click(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0 && !gstruct42_0[num].bool_6)
			{
				gstruct42_0[num].bool_6 = true;
				FormClickNPC.int_12 = gstruct42_0[num].int_129;
				new Thread(FormClickNPC.smethod_3).Start();
			}
		}
	}

	private void buttonClickNpcAll_Click(object sender, EventArgs e)
	{
		if (gstruct42_0 != null && string_32 != null && !(string_32 == string.Empty))
		{
			int[] array = smethod_2(textBoxClickNPCMenu.Text);
			int num = Convert.ToByte(checkBoxClickNPCmenu.Checked);
			int num2 = Class11.smethod_12(textBoxClickNPCTocdo.Text);
			int[] array2 = new int[2]
			{
				Convert.ToByte(checkBoxClickNPCSolan.Checked),
				Class11.smethod_12(textBoxClickNPCSolan.Text)
			};
			try
			{
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					gstruct42_0[i].string_0 = string_32;
					gstruct42_0[i].int_8 = num;
					gstruct42_0[i].int_9 = array;
					gstruct42_0[i].int_10 = num2;
					gstruct42_0[i].int_7 = array2;
					if (gstruct42_0[i].bool_36 && !gstruct42_0[i].bool_6)
					{
						gstruct42_0[i].bool_6 = true;
						for (int j = 0; j < 50; j++)
						{
							if (FormClickNPC.int_12 <= 0)
							{
								break;
							}
							Thread.Sleep(10);
						}
						FormClickNPC.int_12 = gstruct42_0[i].int_129;
						new Thread(FormClickNPC.smethod_3).Start();
					}
				}
			}
			catch
			{
			}
		}
	}

	private void buttonClickNpcStopAll_Click(object sender, EventArgs e)
	{
		buttonClickNpcSingle.Enabled = true;
		if (gstruct42_0 != null)
		{
			try
			{
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					gstruct42_0[i].bool_6 = false;
					gstruct42_0[i].bool_13 = false;
				}
			}
			catch
			{
			}
		}
	}

	private void buttonMuaGopAll_Click(object sender, EventArgs e)
	{
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				try
				{
					if (!gstruct42_0[i].bool_54 && !gstruct42_0[i].bool_57)
					{
						gstruct42_0[i].bool_57 = true;
						Class35.int_0 = gstruct42_0[i].int_129;
						new Thread(Class35.smethod_2).Start();
						Thread.Sleep(150);
					}
				}
				catch
				{
				}
			}
		}
	}

	private void buttonMuaSudungAll_Click(object sender, EventArgs e)
	{
		if (gstruct42_0 != null)
		{
			for (int i = 0; i < gstruct42_0.Length; i++)
			{
				try
				{
					if (!gstruct42_0[i].bool_58 && !gstruct42_0[i].bool_59)
					{
						gstruct42_0[i].bool_59 = true;
						Class35.int_1 = gstruct42_0[i].int_129;
						new Thread(Class35.smethod_4).Start();
						Thread.Sleep(150);
					}
				}
				catch
				{
				}
			}
		}
	}

	private void checkBoxBanVpham_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num >= 0)
			{
				gstruct42_0[num].int_11 = Convert.ToByte(checkBoxBanVpham.Checked);
				Class47.smethod_11(gstruct42_0[num]);
				buttonBanVatphamRac.Enabled = !checkBoxBanVpham.Checked;
			}
		}
	}

	private void buttonDsBanVatpham_Click(object sender, EventArgs e)
	{
		if (FormBanEvent.bool_1)
		{
			FormBanEvent.bool_1 = false;
		}
		else
		{
			try
			{
				FormBanEvent formBanEvent = new FormBanEvent();
				formBanEvent.int_1 = Cursor.Position.X;
				formBanEvent.int_2 = Cursor.Position.Y;
				formBanEvent.int_3 = base.Width;
				formBanEvent.int_4 = base.Height;
				formBanEvent.Show();
			}
			catch
			{
			}
		}
	}

	private void buttonBanVatphamRac_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num >= 0)
		{
			FormBanEvent.int_0 = gstruct42_0[num].int_129;
			FormBanEvent.smethod_3();
		}
	}

	private void buttonOpenAllWeb_Click(object sender, EventArgs e)
	{
		string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_18(text))
		{
			text = Class55.smethod_0();
		}
		int num = -1;
		while (true)
		{
			num++;
			if (string_4.GetLength(0) <= num)
			{
				break;
			}
			string text2 = string_4[num, 0];
			if (text2 == "khác")
			{
				continue;
			}
			string[] array = text2.Split('+', ' ', ',');
			foreach (string text3 in array)
			{
				if (text3 == string.Empty || text3 == null)
				{
					continue;
				}
				text2 = text3.Trim();
				if (text2.Length >= 6)
				{
					if (Class11.smethod_2(text2, "://") < 0)
					{
						text2 = "http://" + text2;
					}
					Class20.smethod_40(text, "", text2, 0);
				}
			}
		}
	}

	private void comboBoxTrinhsat_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			return;
		}
		bool_7 = false;
		string text = comboBoxTrinhsat.Text;
		string text2 = string.Empty;
		comboBoxTrinhsat.Items.Clear();
		comboBoxTrinhsat.Items.Add(string.Empty);
		string_38 = null;
		Class86.smethod_24(gstruct42_0[num], ref string_38, 3);
		if (string_38 != null)
		{
			for (int i = 0; i < string_38.Length; i++)
			{
				string text3 = Class10.smethod_1(string_38[i], 1);
				if (text3 == text)
				{
					text2 = text3;
				}
				comboBoxTrinhsat.Items.Add(text3);
			}
			if (text2 == string.Empty)
			{
				text2 = Class10.smethod_1(string_38[0], 1);
			}
		}
		if (text2 != string.Empty)
		{
			comboBoxTrinhsat.Text = text2;
		}
		Thread.Sleep(3);
		bool_7 = true;
	}

	private void comboBoxTrinhsat_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7 || string_38 == null)
		{
			return;
		}
		string text = comboBoxTrinhsat.Text;
		if (text != null && !(text == string.Empty))
		{
			int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
			if (num < 0)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < string_38.Length; i++)
			{
				if (text == Class10.smethod_1(string_38[i], 1))
				{
					Class50.string_0 = string_38[i];
					flag = true;
					break;
				}
			}
			if (flag)
			{
				int num2 = Class86.smethod_12(gstruct42_0[num], Class50.string_0, 3);
				Class50.uint_0 = Class86.smethod_18(gstruct42_0[num], num2);
				if (Class50.uint_0 != null && (Class50.uint_0[0] == 0 || Class50.uint_0[1] == 0))
				{
					Class50.uint_0 = null;
				}
				if (Class50.uint_0 == null)
				{
					labelToadoTrinhsat.Text = "{ ... mặc định }";
					Class50.string_0 = null;
					comboBoxTrinhsat.Items.Clear();
				}
				else
				{
					labelToadoTrinhsat.Text = "Tọa độ: " + Class50.uint_0[0] / 256u + "," + Class50.uint_0[1] / 512u;
				}
			}
		}
		else
		{
			Class50.string_0 = null;
			labelToadoTrinhsat.Text = "{ ... mặc định }";
		}
	}

	private void checkBoxBaoKeylog_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_65 = Convert.ToByte(checkBoxBaoKeylog.Checked);
			Class55.smethod_10(Class47.string_0, "flagBaoKeylog", int_65, "", 0);
		}
	}

	private void textBoxClickMenuTS_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int_89 = smethod_2(textBoxClickMenuTS.Text);
		string text = string.Empty;
		if (int_89 != null)
		{
			for (int i = 0; i < int_89.Length; i++)
			{
				if (text != string.Empty)
				{
					text += ",";
				}
				text += int_89[i];
			}
		}
		Class55.smethod_10(Class47.string_0, "ClickMenuTrinhsat", text, "", 0);
	}

	private void checkBoxDenToadoLeave_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_71 = Convert.ToByte(checkBoxDenToadoLeave.Checked);
			Class55.smethod_10(Class47.string_0, "fDenToadoLeave", int_71, "", 0);
		}
	}

	private void checkBoxTHPChienLong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_7)
		{
			int_104 = Convert.ToByte(checkBoxTHPChienLong.Checked);
			Class55.smethod_10(Class47.string_0, "flagThpCLD", int_104, "", 0);
		}
	}

	private void comboBoxCTC_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_7)
		{
			return;
		}
		int_24 = 0;
		for (int i = 0; i < string_11.Length; i++)
		{
			if (comboBoxCTC.Text == string_11[i])
			{
				int_24 = i;
				break;
			}
		}
		method_1();
	}

	private void buttonLayMapTamMondai_Click(object sender, EventArgs e)
	{
		int num = Class71.smethod_2(listView1, int_73, gstruct42_0);
		if (num < 0)
		{
			FormTip.smethod_0(string_1, "Hãy chọn 1 ac đang đứng trong Tam môn đài rồi lấy map id.", 60000, 250, 100);
			return;
		}
		int num2 = Class33.smethod_0(gstruct42_0[num]);
		if (num2 > 0)
		{
			int_26 = num2;
			Class55.smethod_10(Class47.string_0, "TamMonDaiMapID", int_26, "", 0);
			textBoxTamMonDaiMapId.Text = int_26.ToString();
		}
	}

	private void buttonMapTamMondaiMacdinh_Click(object sender, EventArgs e)
	{
		int_26 = 221;
		textBoxTamMonDaiMapId.Text = int_26.ToString();
		Class55.smethod_10(Class47.string_0, "TamMonDaiMapID", int_26, "", 0);
	}

	private void buttonResetAuto_Click(object sender, EventArgs e)
	{
		string text = "Sau khi reset cấu hình auto, bạn phải thiết lập lại các thông số cho ac (như chiêu thức, mua máu, ...)." + Class47.string_3 + Class47.string_3 + "Tuy có vẻ hơi mất công và cực nhọc, nhưng điều này sẽ giúp sửa các lỗi thiết lập cấu hình (mà bạn lỡ out ac A log ac B trên cùng 1 game) trước đây, làm cho auto và game nhanh nhẹ hơn." + Class47.string_3 + Class47.string_3 + "Vậy bạn có chắc chắn muốn reset ?";
		if (MessageBox.Show(text, string_1, MessageBoxButtons.YesNo) != DialogResult.No)
		{
			new Thread(method_32).Start();
		}
	}

	private void method_32()
	{
		try
		{
			method_34();
			method_33();
		}
		catch
		{
		}
		TryNewVersion.int_0 = 2;
		string_19 = null;
		int_115 = 0;
	}

	private void method_33()
	{
		string[] array = new string[2]
		{
			Class11.smethod_1(Class11.char_33).ToLower(),
			Class11.smethod_1(Class11.char_34).ToLower()
		};
		string[] files = Directory.GetFiles(Class47.string_5, "*.*", SearchOption.AllDirectories);
		if (files == null || files.Length == 0)
		{
			return;
		}
		for (int i = 0; i < files.Length; i++)
		{
			if (files[i] == null || files[i] == string.Empty)
			{
				continue;
			}
			string[] array2 = files[i].Split('\\');
			string text = array2[array2.Length - 1];
			if (text == null || text == string.Empty)
			{
				continue;
			}
			text = text.ToLower();
			for (int j = 0; j < array.Length; j++)
			{
				if (text == array[j])
				{
					text = null;
					break;
				}
			}
			if (text != null)
			{
				Class11.smethod_20(files[i]);
			}
		}
	}

	private void method_34()
	{
		string[] array = new string[3]
		{
			"PathGame",
			"textIDSudung",
			"TenWeb"
		};
		for (int i = 0; i < 2; i++)
		{
			string[] array2 = Class55.smethod_9(Class47.string_0, i > 0);
			if (array2 == null)
			{
				continue;
			}
			for (int j = 0; j < array2.Length; j++)
			{
				bool flag = false;
				for (int k = 0; k < array.Length; k++)
				{
					if (array[k].ToLower() == array2[j].ToLower())
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Class55.smethod_12(Class47.string_0, array2[j], (byte)i);
				}
			}
		}
	}

	private void buttonTamMonDaiHD_Click(object sender, EventArgs e)
	{
		string str = "https://youtu.be/fWjrqZWKKDQ";
		Class20.smethod_40(Class55.smethod_0(), "", str, 0);
		str = "Dán vào trình duyệt link sau nếu không xem được:" + str;
		FormTip.smethod_0(string_1, str, 60000, 250, 100);
	}
}
