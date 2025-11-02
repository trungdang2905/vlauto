// DlgBasic.cpp : implementation file
//

#include "stdafx.h"
#include "../GameDef.h"
#include "VLAuto.h"
#include "GameCore.h"
#include "GameWindow.h"
#include "DlgBasic.h"

TCHAR* szSeriesName[] = { _T("Kim"), _T("Mộc"),  _T("Thủy"),  _T("Hỏa"), _T("Thổ"), _T("") };

// CDlgBasic dialog

IMPLEMENT_DYNAMIC(CDlgBasic, CDialog)

CDlgBasic::CDlgBasic(CWnd* pParent /*=NULL*/)
	: CDialog(CDlgBasic::IDD, pParent)
{
}

CDlgBasic::~CDlgBasic()
{
}

void CDlgBasic::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_LIFE_PROGRESS, m_LifeIndicator);
	DDX_Control(pDX, IDC_MANA_PROGRESS, m_ManaIndicator);

	if (g_pCurGameWin == NULL) return;

	DDX_Check(pDX, IDC_AMEXIT_CHECK, g_pCurGameWin->m_prBasic.m_bExitWhenAM);
	DDX_Check(pDX, IDC_DISEXIT_CHECK, g_pCurGameWin->m_prBasic.m_bExitWhenDis);
	DDX_Text(pDX, IDC_DISEXIT_EDIT, g_pCurGameWin->m_prBasic.m_nExitDisTime);

	DDX_Check(pDX, IDC_EXITGAMETIMER_CHECK, g_pCurGameWin->m_bExitTimer);
	DDX_DateTimeCtrl(pDX, IDC_EXITGAME_TIMER, g_pCurGameWin->m_ExitTimer);

	BOOL bChecked = ((CButton*)GetDlgItem(IDC_DISEXIT_CHECK))->GetCheck();
	GetDlgItem(IDC_DISEXIT_EDIT)->EnableWindow(!bChecked);
}

BEGIN_MESSAGE_MAP(CDlgBasic, CDialog)
	ON_BN_CLICKED(IDC_HIDEWIN_CHECK, &CDlgBasic::OnBnClickedHidewinCheck)
	ON_BN_CLICKED(IDC_AMEXIT_CHECK, &CDlgBasic::OnBnClickedAmexitCheck)
	ON_BN_CLICKED(IDC_DISEXIT_CHECK, &CDlgBasic::OnBnClickedDisexitCheck)
	ON_BN_CLICKED(IDC_EXITGAMETIMER_CHECK, &CDlgBasic::OnBnClickedShutdowntimerCheck)
	ON_NOTIFY(DTN_DATETIMECHANGE, IDC_EXITGAME_TIMER, &CDlgBasic::OnDtnDatetimechangeShutdownTimer)
END_MESSAGE_MAP()

BOOL CDlgBasic::OnInitDialog()
{
	CDialog::OnInitDialog();
	m_LifeIndicator.SetProgressType(0);
	m_ManaIndicator.SetProgressType(1);
	CTime stTime(2000, 1, 1, 2, 0, 0);
	CDateTimeCtrl* pTimerCtrl = (CDateTimeCtrl*)GetDlgItem(IDC_EXITGAME_TIMER);
	pTimerCtrl->SetFormat(_T("HH:mm"));
	pTimerCtrl->SetTime(&stTime);
	pTimerCtrl = (CDateTimeCtrl*)GetDlgItem(IDC_SHUTDOWN_TIMER);
	pTimerCtrl->SetFormat(_T("HH:mm"));
	pTimerCtrl->SetTime(&stTime);

	if (m_ToolTip.Create(this))
	{
		m_ToolTip.AddTool(GetDlgItem(IDC_ENAME_EDIT), _T("Tên và Hệ đối thủ hoặc người dẫn"));
		m_ToolTip.AddTool(GetDlgItem(IDC_ESERIES_EDIT), _T("Tên và Hệ đối thủ hoặc người dẫn"));
		m_ToolTip.AddTool(GetDlgItem(IDC_ELIFE_EDIT), _T("Sinh lực và Đẳng cấp đối thủ hoặc người dẫn"));
		m_ToolTip.AddTool(GetDlgItem(IDC_ELEVEL_EDIT), _T("Sinh lực và Đẳng cấp đối thủ hoặc người dẫn"));
		m_ToolTip.AddTool(GetDlgItem(IDC_HIDEWIN_CHECK), _T("Hiện/Ẩn cửa sổ Game"));
		m_ToolTip.AddTool(GetDlgItem(IDC_AMEXIT_CHECK), _T("Thoát Game sau khi Thổ Địa Phù"));
		m_ToolTip.AddTool(GetDlgItem(IDC_EXITGAMETIMER_CHECK), _T("Hẹn giờ đóng Game, thoát nhân vật"));
		m_ToolTip.AddTool(GetDlgItem(IDC_EXITGAME_TIMER), _T("Thời gian thoát game còn lại (giờ:phút)"));
		m_ToolTip.AddTool(GetDlgItem(IDC_SHUTDOWNEXITALL_CHECK), _T("Tắt máy nếu thoát toàn bộ các Game"));
		m_ToolTip.AddTool(GetDlgItem(IDC_SHUTDOWNTIMER_CHECK), _T("Hẹn giờ thoát hết Game và tắt máy"));
		m_ToolTip.AddTool(GetDlgItem(IDC_SHUTDOWN_TIMER), _T("Thời gian tắt máy còn lại (giờ:phút)"));
	}

	return FALSE;
}

BOOL CDlgBasic::PreTranslateMessage(MSG* pMsg)
{
	m_ToolTip.RelayEvent(pMsg);
	return CDialog::PreTranslateMessage(pMsg);
}

void CDlgBasic::RefreshUI()
{
	static int nLastMapID = 0;
	TCHAR szOldInfo[40];
	TCHAR szInfo[40];

	if (g_pCurGameWin == NULL) return;

	if (g_pCurGameWin->m_nCurLifeMax == 0)
		g_pCurGameWin->m_nCurLifeMax = 100;
	m_LifeIndicator.SetPos(g_pCurGameWin->m_nCurLife*100/g_pCurGameWin->m_nCurLifeMax);
	m_LifeIndicator.Invalidate();
	SetDlgItemInt(IDC_LIFE_STATIC, g_pCurGameWin->m_nCurLife);

	if (g_pCurGameWin->m_nCurManaMax == 0)
		g_pCurGameWin->m_nCurManaMax = 100;
	m_ManaIndicator.SetPos(g_pCurGameWin->m_nCurMana*100/g_pCurGameWin->m_nCurManaMax);
	m_ManaIndicator.Invalidate();
	SetDlgItemInt(IDC_MANA_STATIC, g_pCurGameWin->m_nCurMana);

	if (g_pCurGameWin->m_nMapID != nLastMapID)
	{
		//Read MapList.ini
		nLastMapID = g_pCurGameWin->m_nMapID;
		TCHAR szMapID[4];
		_stprintf(szMapID, _T("%d"), nLastMapID);
		TCHAR szMapNameFile[MAX_PATH];
		_stprintf(szMapNameFile, _T("%s\\Maps\\MapNames.ini"), g_szAppFolder);
		GetPrivateProfileString(_T("Map_Name"), szMapID, _T("<Unknown_Map>"), szInfo, 40, szMapNameFile);
		char szTCNV3Str[40];
		WideCharToMultiByte(CP_ACP, 0, szInfo, -1, szTCNV3Str, 40, 0, 0);
		TCVN3ToUnicode(szTCNV3Str, szInfo, 40);
		SetDlgItemText(IDC_MAP_EDIT, szInfo);
	}

	_stprintf(szInfo,	_T("%d,%d"), g_pCurGameWin->m_nOffX >> 8, g_pCurGameWin->m_nOffY >> 9);
	SetDlgItemText(IDC_POS_EDIT, szInfo);
	TCVN3ToUnicode(g_pCurGameWin->m_szEnemyName, szInfo, 40);
	GetDlgItemText(IDC_ENAME_EDIT, szOldInfo, 40);
	if (_tcscmp(szOldInfo, szInfo))
	{
		SetDlgItemText(IDC_ENAME_EDIT, szInfo);

		if (g_pCurGameWin->m_nEnemySeries >= 0)
			SetDlgItemText(IDC_ESERIES_EDIT, szSeriesName[g_pCurGameWin->m_nEnemySeries]);
		else
			SetDlgItemText(IDC_ESERIES_EDIT, _T(""));
	}

	_stprintf(szInfo,	_T("%d / %d"), g_pCurGameWin->m_nEnemyLife, g_pCurGameWin->m_nEnemyLifeMax);
	SetDlgItemText(IDC_ELIFE_EDIT, szInfo);
	SetDlgItemInt(IDC_ELEVEL_EDIT, g_pCurGameWin->m_nEnemyLevel);
	((CButton*)GetDlgItem(IDC_HIDEWIN_CHECK))->SetCheck(!(::IsWindowVisible(g_pCurGameWin->m_hWnd)));
}

void CDlgBasic::OnBnClickedHidewinCheck()
{
	if (g_pCurGameWin == NULL) return;
	if (((CButton*)GetDlgItem(IDC_HIDEWIN_CHECK))->GetCheck())
		::ShowWindow(g_pCurGameWin->m_hWnd, SW_HIDE);
	else
		::ShowWindow(g_pCurGameWin->m_hWnd, SW_SHOW);
}

void CDlgBasic::OnBnClickedAmexitCheck()
{
	if (g_pCurGameWin == NULL) return;
	UpdateData();
	g_pCurGameWin->SetGameParams(tab_basic);
}

void CDlgBasic::OnBnClickedDisexitCheck()
{
	if (g_pCurGameWin == NULL) return;
	UpdateData();
	g_pCurGameWin->SetGameParams(tab_basic);
}

void CDlgBasic::OnBnClickedShutdowntimerCheck()
{
	UpdateData();
}

void CDlgBasic::OnDtnDatetimechangeShutdownTimer(NMHDR *pNMHDR, LRESULT *pResult)
{
	LPNMDATETIMECHANGE pDTChange = reinterpret_cast<LPNMDATETIMECHANGE>(pNMHDR);
	UpdateData();
	*pResult = 0;
}
