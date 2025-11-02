// DlgMove.cpp : implementation file
//

#include "stdafx.h"
#include "../GameDef.h"
#include "DWinProcess.h"
#include "VLAuto.h"
#include "GameCore.h"
#include "GameWindow.h"
#include "UiControls.h"
#include "DlgMap.h"
#include "DlgMove.h"

// CDlgMove dialog

IMPLEMENT_DYNAMIC(CDlgMove, CDialog)

CDlgMove::CDlgMove(CWnd* pParent /*=NULL*/)
	: CDialog(CDlgMove::IDD, pParent)
{
}

CDlgMove::~CDlgMove()
{
}

void CDlgMove::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_MOVEPOINT_LIST, m_PoinList);

	if (g_pCurGameWin == NULL) return;

	//Checkboxes
	DDX_Check(pDX, IDC_FOLLOW_CHECK, g_pCurGameWin->m_prMove.m_bFollow);
	DDX_Check(pDX, IDC_COMBOMONSTER_CHECK, g_pCurGameWin->m_prMove.m_bComboMonster);
	DDX_Check(pDX, IDC_RIDEHORSEFOLLOW_CHECK, g_pCurGameWin->m_prMove.m_bRideHorseFollow);
	DDX_Check(pDX, IDC_AROUNDPOINT_CHECK, g_pCurGameWin->m_prMove.m_bAroundPoint);
	DDX_Check(pDX, IDC_ROUTEPOINT_CHECK, g_pCurGameWin->m_prMove.m_bRouteMove);
	DDX_Check(pDX, IDC_RIDEHORSEMOVE_CHECK, g_pCurGameWin->m_prMove.m_bRideHorseMove);
	DDX_Check(pDX, IDC_ATTACKWHENMOVE_CHECK, g_pCurGameWin->m_prMove.m_bAttackWhenMove);
	DDX_Check(pDX, IDC_NOATTACKFOLLOW_CHECK, g_pCurGameWin->m_prMove.m_bNoAttackFollow);
	DDX_Check(pDX, IDC_MOVEBYMAP_CHECK, g_pCurGameWin->m_prMove.m_bMoveByMap);

	//Editboxes
	DDX_Text(pDX, IDC_FOLLOWDISTANCE_EDIT, g_pCurGameWin->m_prMove.m_nFollowDistance);
	DDX_Text(pDX, IDC_POINTRANGE_EDIT, g_pCurGameWin->m_prMove.m_nPointRange);

	//UI Refresh
	BOOL bChecked, bChecked1;
	bChecked = ((CButton*)GetDlgItem(IDC_FOLLOW_CHECK))->GetCheck();
	GetDlgItem(IDC_NEARBYPLAYER_COMBO)->EnableWindow(!bChecked);
	GetDlgItem(IDC_FOLLOWDISTANCE_EDIT)->EnableWindow(!bChecked);
	bChecked = ((CButton*)GetDlgItem(IDC_AROUNDPOINT_CHECK))->GetCheck();
	if (bChecked)
	{
		SetDlgItemInt(IDC_POINTX_EDIT, g_pCurGameWin->m_prMove.m_nPointX >> 8);
		SetDlgItemInt(IDC_POINTY_EDIT, g_pCurGameWin->m_prMove.m_nPointY >> 9);
	}
	bChecked1 = ((CButton*)GetDlgItem(IDC_ROUTEPOINT_CHECK))->GetCheck();
	GetDlgItem(IDC_POINTRANGE_EDIT)->EnableWindow(!bChecked1 && !bChecked);
	GetDlgItem(IDC_ADD_BUTTON)->EnableWindow(!bChecked1);
	GetDlgItem(IDC_DEL_BUTTON)->EnableWindow(!bChecked1);
	GetDlgItem(IDC_UP_BUTTON)->EnableWindow(!bChecked1);
	GetDlgItem(IDC_DOWN_BUTTON)->EnableWindow(!bChecked1);
	GetDlgItem(IDC_DELALL_BUTTON)->EnableWindow(!bChecked1);
	GetDlgItem(IDC_LOAD_BUTTON)->EnableWindow(!bChecked1);

	UpdateNearByPlayers(pDX->m_bSaveAndValidate);
	UpdatePointsList(pDX->m_bSaveAndValidate);

	if (!pDX->m_bSaveAndValidate)
	{
		CTabCtrlEx* pMainTab = (CTabCtrlEx*)GetParent();
		CDlgMap* dlgMap = (CDlgMap*)pMainTab->GetTabDlg(tab_map);
		int nTrainMapID = g_pCurGameWin->m_prMap.m_nTrainMapID;
		CString strMapName = _T("Bản đồ bất kỳ");
		if (nTrainMapID)
		{
			CComboBox* pTrainMapCmb = (CComboBox*)dlgMap->GetDlgItem(IDC_TRAINMAP_COMBO);
			int nCount = pTrainMapCmb->GetCount();
			for (int i = 0; i < nCount; i++)
			{
				if (nTrainMapID == pTrainMapCmb->GetItemData(i))
				{
					pTrainMapCmb->GetLBText(i, strMapName);
					break;
				}
			}
		}
		SetDlgItemText(IDC_TRAINMAP_EDIT, strMapName);
	}
}

BEGIN_MESSAGE_MAP(CDlgMove, CDialog)
	ON_CONTROL_RANGE(BN_CLICKED, 1000, 2000, &CDlgMove::OnButtonsClicked)
END_MESSAGE_MAP()

// CDlgMove message handlers

BOOL CDlgMove::OnInitDialog()
{
	CDialog::OnInitDialog();

	if (m_ToolTip.Create(this))
	{
		m_ToolTip.AddTool(GetDlgItem(IDC_FOLLOW_CHECK), _T("Theo sau nhân vật khác"));
		m_ToolTip.AddTool(GetDlgItem(IDC_COMBOMONSTER_CHECK), _T("Gom quái lại để đánh"));
		m_ToolTip.AddTool(GetDlgItem(IDC_NEARBYPLAYER_COMBO), _T("Tên nhân vật cần theo"));
		m_ToolTip.AddTool(GetDlgItem(IDC_FOLLOWDISTANCE_EDIT), _T("Phạm vi theo sau"));
		m_ToolTip.AddTool(GetDlgItem(IDC_NOATTACKFOLLOW_CHECK), _T("Không tự đánh nếu mất người dẫn đường"));
		m_ToolTip.AddTool(GetDlgItem(IDC_MOVEBYMAP_CHECK), _T("Di chuyển tự do toàn bản đồ (đã soạn file MAP)"));
		m_ToolTip.AddTool(GetDlgItem(IDC_RIDEHORSEFOLLOW_CHECK), _T("Tự lên ngựa khi theo sau"));
		m_ToolTip.AddTool(GetDlgItem(IDC_AROUNDPOINT_CHECK), _T("Đánh quanh 1 điểm cố định"));
		m_ToolTip.AddTool(GetDlgItem(IDC_POINTX_EDIT), _T("Tọa độ đánh quanh điểm"));
		m_ToolTip.AddTool(GetDlgItem(IDC_POINTY_EDIT), _T("Tọa độ đánh quanh điểm"));
		m_ToolTip.AddTool(GetDlgItem(IDC_POINTRANGE_EDIT), _T("Phạm vi đánh Quanh điểm và theo Tọa độ"));
		m_ToolTip.AddTool(GetDlgItem(IDC_ROUTEPOINT_CHECK), _T("Hành trình luyện công - Đánh quái theo tọa độ"));
		m_ToolTip.AddTool(GetDlgItem(IDC_MOVEPOINT_LIST), _T("Danh sách tọa độ Hành trình"));
	}

	return FALSE;
}

BOOL CDlgMove::PreTranslateMessage(MSG* pMsg)
{
	m_ToolTip.RelayEvent(pMsg);
	return CDialog::PreTranslateMessage(pMsg);
}

void CDlgMove::OnButtonsClicked(UINT nID)
{
	if (g_pCurGameWin == NULL) return;
	switch (nID)
	{
	case IDC_ADD_BUTTON:
		OnBnClickedAddButton();
		break;
	case IDC_DEL_BUTTON:
		OnBnClickedDelButton();
		break;
	case IDC_UP_BUTTON:
		OnBnClickedUpButton();
		break;
	case IDC_DOWN_BUTTON:
		OnBnClickedDownButton();
		break;
	case IDC_DELALL_BUTTON:
		OnBnClickedDelAllButton();
		break;
	case IDC_SAVE_BUTTON:
		OnBnClickedSaveButton();
		break;
	case IDC_LOAD_BUTTON:
		OnBnClickedLoadButton();
		break;
	}
	if (nID == IDC_AROUNDPOINT_CHECK)
	{
		if (((CButton*)GetDlgItem(nID))->GetCheck())
		{
			g_pCurGameWin->m_prMove.m_nPointX = g_pCurGameWin->m_nOffX;
			g_pCurGameWin->m_prMove.m_nPointY = g_pCurGameWin->m_nOffY;
		}
	}
	else
	if (nID == IDC_ATTACKWHENMOVE_CHECK)
	{
		if (((CButton*)GetDlgItem(nID))->GetCheck())
		{
			((CButton*)GetDlgItem(IDC_COMBOMONSTER_CHECK))->SetCheck(false);
		}
	}
	else
	if (nID == IDC_COMBOMONSTER_CHECK)
	{
		if (((CButton*)GetDlgItem(nID))->GetCheck())
		{
			((CButton*)GetDlgItem(IDC_ATTACKWHENMOVE_CHECK))->SetCheck(false);
		}
	}
	UpdateData();
	g_pCurGameWin->SetGameParams(tab_move);
}

void CDlgMove::UpdateNearByPlayers(BOOL bSave)
{
	TCHAR szName[32]=_T("");
	if (bSave)
	{
		GetDlgItemText(IDC_NEARBYPLAYER_COMBO, szName, 32);
		WideCharToMultiByte(CP_ACP, 0, szName, -1, g_pCurGameWin->m_prMove.m_szLeader, 32, 0, 0);
	}
	else
	{
		if (((CButton*)GetDlgItem(IDC_FOLLOW_CHECK))->GetCheck())
		{
			MultiByteToWideChar(CP_ACP, 0, g_pCurGameWin->m_prMove.m_szLeader, -1, szName, 32);
			SetDlgItemText(IDC_NEARBYPLAYER_COMBO, szName);
			return;
		}
	}
	if (((CButton*)GetDlgItem(IDC_FOLLOW_CHECK))->GetCheck())
		return;

	LPBYTE lpBaseAdd, lpCurAdd;
	DWinProcess winProcess(g_pCurGameWin->m_hWnd);
	if (!winProcess.ReadMemory((LPVOID)NPC_BASE_ADD, (LPVOID)&lpBaseAdd, 4))
		return;

	CComboBox *pNearByPlayer = (CComboBox*)GetDlgItem(IDC_NEARBYPLAYER_COMBO);
	pNearByPlayer->ResetContent();

	KNpc Npc;
	for (int i = 2; i < MAX_NPC; i++)
	{
		lpCurAdd = lpBaseAdd + i*NPC_DATA_SIZE;
		winProcess.ReadMemory(lpCurAdd, (LPVOID)&Npc, sizeof(Npc));
		if (!Npc.m_Index || Npc.m_NpcKind != 1) continue;
		MultiByteToWideChar(CP_ACP, 0, Npc.Name, -1, szName, 32);
		pNearByPlayer->AddString(szName);
	}
}

void CDlgMove::UpdatePointsList(BOOL bSave)
{
	CString szLine;
	DWORD dwItemData;
	int nIndex, nX, nY;
	if (bSave)
	{
		memset(g_pCurGameWin->m_prMove.m_Nodes, 0, sizeof(g_pCurGameWin->m_prMove.m_Nodes));
		int nCount = m_PoinList.GetCount();
		for (int i = 0; i < nCount; i++)
		{
			dwItemData = (DWORD)m_PoinList.GetItemData(i);
			nX = LOWORD(dwItemData) << 5;
			nY = HIWORD(dwItemData) << 5;
			g_pCurGameWin->m_prMove.m_Nodes[i].x = nX;
			g_pCurGameWin->m_prMove.m_Nodes[i].y = nY;
		}
	}
	else
	{
		m_PoinList.ResetContent();
		for (int i = 0; i < MAX_NODES; i++)
		{
			nX = g_pCurGameWin->m_prMove.m_Nodes[i].x;
			nY = g_pCurGameWin->m_prMove.m_Nodes[i].y;
			if (nX && nY)
			{
				szLine.Format(_T("(%d, %d)"), nX>>8, nY>>9);
				nIndex = m_PoinList.AddString(szLine);
				dwItemData = MAKELONG(nX>>5, nY>>5); 
				m_PoinList.SetItemData(nIndex, dwItemData);
			}
		}
	}
}

void CDlgMove::OnBnClickedAddButton()
{
	CString szLine;
	DWORD dwItemData;
	int nIndex, nX, nY;
	if (g_pCurGameWin == NULL) return;
	int nCount = m_PoinList.GetCount();
	if (nCount < MAX_NODES)
	{
		nX = g_pCurGameWin->m_nOffX;
		nY = g_pCurGameWin->m_nOffY;

		szLine.Format(_T("(%d, %d)"), nX>>8, nY>>9);
		nIndex = m_PoinList.AddString(szLine);
		dwItemData = MAKELONG(nX>>5, nY>>5); 
		m_PoinList.SetItemData(nIndex, dwItemData);
		m_PoinList.SetCurSel(nIndex);
	}
}

void CDlgMove::OnBnClickedDelButton()
{
	m_PoinList.DeleteString(m_PoinList.GetCurSel());
}

void CDlgMove::OnBnClickedUpButton()
{
	int nIndex = m_PoinList.GetCurSel();
	DWORD dwTemp; CString szTemp;
	if (nIndex>0)
	{
		m_PoinList.GetText(nIndex, szTemp);
		dwTemp = (DWORD)m_PoinList.GetItemData(nIndex);
		m_PoinList.DeleteString(nIndex);
		m_PoinList.InsertString(nIndex-1, szTemp);
		m_PoinList.SetItemData(nIndex-1, dwTemp);
		m_PoinList.SetCurSel(nIndex-1);
	}
}

void CDlgMove::OnBnClickedDownButton()
{
	int nIndex = m_PoinList.GetCurSel();
	int nCount = m_PoinList.GetCount();
	DWORD dwTemp; CString szTemp;
	if (nIndex<nCount-1 && nIndex>-1)
	{
		m_PoinList.GetText(nIndex, szTemp);
		dwTemp = (DWORD)m_PoinList.GetItemData(nIndex);
		m_PoinList.DeleteString(nIndex);
		m_PoinList.InsertString(nIndex+1, szTemp);
		m_PoinList.SetItemData(nIndex+1, dwTemp);
		m_PoinList.SetCurSel(nIndex+1);
	}
}

void CDlgMove::OnBnClickedDelAllButton()
{
	m_PoinList.ResetContent();
}

void CDlgMove::OnBnClickedSaveButton()
{
	CFileDialog fDlg(FALSE, _T(".mvp"), 0,
		OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT, _T("Move Points File (*.mvp)|*.mvp|"), this);
	if (fDlg.DoModal() == IDCANCEL)
		return;
	CString szFileName = fDlg.GetPathName();
	CFile mvFile;
	if (!mvFile.Open(szFileName, CFile::modeCreate|CFile::modeWrite))
	{
		MessageBox(_T("Lỗi: không thể ghi tập tin!"), 0, MB_ICONEXCLAMATION);
		return;
	}
	char szVersion[12] = "";
	strcpy(szVersion, _SZCURVERSION);
	mvFile.Write(szVersion, sizeof(szVersion));
	mvFile.Write(g_pCurGameWin->m_prMove.m_Nodes, sizeof(g_pCurGameWin->m_prMove.m_Nodes));
	mvFile.Close();
}

void CDlgMove::OnBnClickedLoadButton()
{
	CFileDialog fDlg(TRUE, _T(".mvp"), 0,
		OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT, _T("Move Points File (*.mvp)|*.mvp|"), this);
	if (fDlg.DoModal() == IDCANCEL)
		return;
	CString szFileName = fDlg.GetPathName();
	CFile mvFile;
	if (!mvFile.Open(szFileName, CFile::modeRead | CFile::shareDenyWrite))
	{
		MessageBox(_T("Lỗi: không thể đọc tập tin!"), 0, MB_ICONEXCLAMATION);
		return;
	}
	char szVersion[12] = "";
	mvFile.Read(szVersion, sizeof(szVersion));
	if (strcmp(szVersion, _SZCURVERSION))
	{
		MessageBox(_T("Lỗi: phiên bản không tương thích!"), 0, MB_ICONEXCLAMATION);
		mvFile.Close();
		return;
	}
	memset(&g_pCurGameWin->m_prMove.m_Nodes, 0, sizeof(g_pCurGameWin->m_prMove.m_Nodes));
	mvFile.Read(&g_pCurGameWin->m_prMove.m_Nodes, sizeof(g_pCurGameWin->m_prMove.m_Nodes));
	mvFile.Close();
	// Update Data
	UpdateData(0);
	g_pCurGameWin->SetGameParams(tab_move);
}
