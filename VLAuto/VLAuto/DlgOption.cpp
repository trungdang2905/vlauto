// DlgOption.cpp : implementation file
//

#include "stdafx.h"
#include "VLAuto.h"
#include "DlgOption.h"

// COptionDlg dialog

IMPLEMENT_DYNAMIC(COptionDlg, CDialog)

COptionDlg::COptionDlg(CWnd* pParent /*=NULL*/)
	: CDialog(COptionDlg::IDD, pParent)
{
	m_bSilentMode = TRUE;
	m_bAutoChat = TRUE;
	m_bPrintScreen = FALSE;
	m_bAttackBossFirst = TRUE;
	m_szControlPass = "";
}

COptionDlg::~COptionDlg()
{
}

void COptionDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Check(pDX, IDC_SILENTMODE_CHECK, m_bSilentMode);
	DDX_Check(pDX, IDC_AUTOCHAT_CHECK, m_bAutoChat);
	DDX_Check(pDX, IDC_PRINTSCREEN_CHECK, m_bPrintScreen);
	DDX_Check(pDX, IDC_ATTACKBOSSFIRST_CHECK, m_bAttackBossFirst);
	DDX_Text(pDX, IDC_CTRLPASS_EDIT, m_szControlPass);

	DDX_Check(pDX, IDC_CHECK1, R1);
	DDX_Check(pDX, IDC_CHECK2, R2);
	DDX_Check(pDX, IDC_CHECK3, R3);
	DDX_Check(pDX, IDC_CHECK4, R4);
}

BEGIN_MESSAGE_MAP(COptionDlg, CDialog)
END_MESSAGE_MAP()

// COptionDlg message handlers

BOOL COptionDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_bSilentMode = GetPrivateProfileInt(_T("Options"), _T("SilentMode"), 1, g_szIniFile);
	m_bAutoChat = GetPrivateProfileInt(_T("Options"), _T("AutoChat"), 1, g_szIniFile);
	m_bPrintScreen = GetPrivateProfileInt(_T("Options"), _T("PrintScreen"), 0, g_szIniFile);
	m_bAttackBossFirst = GetPrivateProfileInt(_T("Options"), _T("AttackBossFirst"), 1, g_szIniFile);

	TCHAR szCtrlPass[128];
	GetPrivateProfileString(_T("Options"), _T("ControlPass"), _T(""), szCtrlPass, 128, g_szIniFile);
	m_szControlPass = szCtrlPass;

	R1 = GetPrivateProfileInt(_T("Options"), _T("SaleWorld"), 1, g_szIniFile);
	R2 = GetPrivateProfileInt(_T("Options"), _T("SaleCity"), 1, g_szIniFile);
	R3 = GetPrivateProfileInt(_T("Options"), _T("SaleTong"), 1, g_szIniFile);
	R4 = GetPrivateProfileInt(_T("Options"), _T("SaleMenpai"), 1, g_szIniFile);

	UpdateData(0);

	return TRUE;  // return TRUE unless you set the focus to a control
}

void COptionDlg::OnOK()
{
	UpdateData();
	TCHAR szValue[16];
	_itot(m_bSilentMode, szValue, 10);
	WritePrivateProfileString(_T("Options"), _T("SilentMode"), szValue, g_szIniFile);
	_itot(m_bAutoChat, szValue, 10);
	WritePrivateProfileString(_T("Options"), _T("AutoChat"), szValue, g_szIniFile);
	_itot(m_bPrintScreen, szValue, 10);
	WritePrivateProfileString(_T("Options"), _T("PrintScreen"), szValue, g_szIniFile);
	_itot(m_bAttackBossFirst, szValue, 10);
	WritePrivateProfileString(_T("Options"), _T("AttackBossFirst"), szValue, g_szIniFile);
	WritePrivateProfileString(_T("Options"), _T("ControlPass"), m_szControlPass, g_szIniFile);

	_itot(R1, szValue, 10);
	WritePrivateProfileString(_T("Options"), _T("SaleWorld"), szValue, g_szIniFile);
	_itot(R2, szValue, 10);
	WritePrivateProfileString(_T("Options"), _T("SaleCity"), szValue, g_szIniFile);
	_itot(R3, szValue, 10);
	WritePrivateProfileString(_T("Options"), _T("SaleTong"), szValue, g_szIniFile);
	_itot(R4, szValue, 10);
	WritePrivateProfileString(_T("Options"), _T("SaleMenpai"), szValue, g_szIniFile);

	CDialog::OnOK();
}
