// GameWindow.cpp : implementation file
//

#include "stdafx.h"
#include "../GameDef.h"
#include "AntiRE.h"
#include "DWinProcess.h"
#include "GameCore.h"
#include "VLAuto.h"
#include "VLAutoDlg.h"
#include "DlgMap.h"
#include "GameWindow.h"

struct WinMessage
{
	UINT uMsg;
	WPARAM wParam;
	LPARAM lParam;
};

const WinMessage AutoParamMsg[] =
{
	{ WM_HOOK_BASIC, NULL, sizeof(PARAM_BASIC) },
	{ WM_HOOK_RECOVER, NULL, sizeof(PARAM_RECOVER) },
	{ WM_HOOK_ATTACK, NULL, sizeof(PARAM_ATTACK) },
	{ WM_HOOK_COLLECT, NULL, sizeof(PARAM_COLLECT) },
	{ WM_HOOK_MOVE, NULL, sizeof(PARAM_MOVE) },
	{ WM_HOOK_PARTY, NULL, sizeof(PARAM_PARTY) },
	{ WM_HOOK_MAP, NULL, sizeof(PARAM_MAP) },
	{ WM_HOOK_YESOU, NULL, sizeof(PARAM_YESOU) },
};

// GameWindow Class
GameWindow::GameWindow(HWND hWnd)
{
	InitValue();
	m_hWnd = hWnd;
}

void GameWindow::InitValue()
{
	memset(this, 0, sizeof(GameWindow));

	strcpy(m_szPlayerName, VLTK_UNNAMED);
	m_nPlayerLevel = -1;
	m_nNextExp = 100;
	m_nCurLifeMax = 100;
	m_nCurManaMax = 100;
	m_ExitTimer = CTime(2000, 1, 1, 2, 0, 0);

	m_prBasic.InitValue();
	m_prRecover.InitValue();
	m_prAttack.InitValue();
	m_prCollect.InitValue();
	m_prMove.InitValue();
	m_prParty.InitValue();
	m_prMap.InitValue();
	m_prYeSou.InitValue();
}

void GameWindow::Refresh()
{
	if (!IsWindow(m_hWnd))
	{
		m_hWnd = NULL;
		return;
	}

	m_bInfoChanged = FALSE;

	m_nTimerCount++;
	if (m_nTimerCount % 120 == 1 && m_bAttached && m_bExitTimer)	//each minute
	{
		CTime orgTime(2000, 1, 1, 0, 0, 0);
		if (m_ExitTimer > orgTime)
		{
			m_ExitTimer -= CTimeSpan(0, 0, 1, 0);
			CVLAutoDlg *pMainDlg = (CVLAutoDlg*)theApp.GetMainDlg();
			pMainDlg->m_MainTab.GetTabDlg(tab_basic)->UpdateData(0);
		}
		if (m_ExitTimer <= orgTime)
		{
			::PostMessage(m_hWnd, WM_HOOK_MAIN, cmd_exit, 0);
			return;
		}
	}

	KNpc Npc;
	LPBYTE lpBaseAdd, lpCurAdd;
	DWinProcess winProcess(m_hWnd);

	if (!m_bVersionChecked)
	{
		// Check Game Version - BEGIN
		/*TCHAR szGameY[MAX_PATH];
		if (!winProcess.GetModuleFileNameEx(NULL, szGameY, MAX_PATH)) return;
		HANDLE hFile = CreateFile(szGameY, GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, 0);
		if (hFile == INVALID_HANDLE_VALUE) return;
		DWORD dwFileSize = GetFileSize(hFile, NULL);
		CloseHandle(hFile);

		if (dwFileSize != GAMEY_SIZE)
		{
			if (strcmp(m_szPlayerName, VLTK_WRONGVER))
			{
				strcpy(m_szPlayerName, VLTK_WRONGVER);
				m_bInfoChanged = TRUE;
			}
			return;
		}*/

		m_bVersionChecked = TRUE;
		// Check Game Version - END
	}

	winProcess.ReadMemory((LPVOID)PLR_BASE_ADD, &lpBaseAdd, sizeof(LPBYTE)); lpBaseAdd += PLAYER_OFFSET;
	lpCurAdd = lpBaseAdd + PLR_IDX_OFFSET;
	winProcess.ReadMemory(lpCurAdd, &m_nPlayerIndex, sizeof(int));

	if (!winProcess.ReadMemory((LPBYTE)NPC_BASE_ADD, (LPVOID)&lpBaseAdd, 4)) return;
	lpCurAdd = lpBaseAdd + m_nPlayerIndex * NPC_DATA_SIZE;
	if (!winProcess.ReadMemory(lpCurAdd, (LPVOID)&Npc, sizeof(Npc))) return;

	if (Npc.m_Index == 0) // Disconnected
	{
		if (m_nPlayerLevel < 0)
		{
			m_nPlayerLevel = 0;
			m_bInfoChanged = TRUE;
		}
		else if (strcmp(m_szPlayerName, VLTK_UNNAMED)) // Connected => Disconnected
		{
			m_nExp = 0;
			strcpy(m_szPlayerName, VLTK_UNNAMED);
			m_bInfoChanged = TRUE;

			if (m_bLoadDone)
			{
				SaveProfile();
				m_bLoadDone = 0;
				m_bRegistered = 0;
			}
		}
		return;
	}

	if (!strcmp(m_szPlayerName, VLTK_UNNAMED)) // Disconnected => Connected
	{
		// Check DevIoCode
		BOOL bIsCodeOK = TRUE;
		/*BYTE brDevIoCode[DEVIO_CODE_SIZE];
		INT_PTR PtrDevIoCtrlAdd = GetDeviceIoControlAdd();
		if (!winProcess.ReadMemory((LPBYTE)PtrDevIoCtrlAdd, (LPVOID)brDevIoCode, DEVIO_CODE_SIZE)) return;
		for (int i = 0; i < DEVIO_CODE_SIZE; i++)
		{
			if (((LPBYTE)PtrDevIoCtrlAdd)[i] != brDevIoCode[i])
			{
				bIsCodeOK = FALSE;
				break;
			}
		}*/

		if (!winProcess.ReadMemory((LPCVOID)ACNT_ID_ADD, (LPVOID)m_szAccountID, sizeof(m_szAccountID))) return;
		if (!m_szAccountID[0]) return;

		/*if (!winProcess.ReadMemory((LPCVOID)SERVERIP_ADD, (LPVOID)&m_dwServerIP, sizeof(m_dwServerIP))) return;
		if (!m_dwServerIP) return;*/

		m_nPlayerLevel = Npc.m_Level;
		strcpy(m_szPlayerName, Npc.Name);
		m_bInfoChanged = TRUE;

		LoadProfile();
		m_bLoadDone = TRUE;
		m_bRegistered = bIsCodeOK && IsRegistered();

		// Check for same server
		/*for (int i = 0; i < g_pCharList->GetItemCount(); i++)
		{
			GameWindow* pGameWin = (GameWindow*)g_pCharList->GetItemData(i);
			if (!pGameWin->m_hWnd || pGameWin->m_hWnd == m_hWnd) continue;
			if (pGameWin->m_dwServerIP != m_dwServerIP) continue;

			if (!strcmp(pGameWin->m_szPlayerName, Npc.Name))
			{
				m_nPlayerLevel = 100;
				m_bRegistered = 0;
				break;
			}
		}*/

		if (!m_bRegistered && m_bAttached)
		{
			for (int i = 0; i < g_pCharList->GetItemCount(); i++)
			{
				GameWindow* pGameWin = (GameWindow*)g_pCharList->GetItemData(i);
				if (pGameWin->m_hWnd == m_hWnd)
				{
					g_pCharList->SetItemState(i, 0x1000, LVIS_STATEIMAGEMASK);
					break;
				}
			}
		}
	}

	m_nCurLife = Npc.m_CurLife;
	m_nCurLifeMax = Npc.m_CurLifeMax;
	m_nCurMana = Npc.m_CurMana;
	m_nCurManaMax = Npc.m_CurManaMax;
	winProcess.ReadMemory((LPBYTE)MAP_ID_ADD, (LPVOID)&m_nMapID, sizeof(m_nMapID));
	winProcess.ReadMemory((LPBYTE)FLAG_X_OFFST, (LPVOID)&m_nFlagX, 8);
	m_nFlagX <<= 4;	m_nFlagY <<= 5;
	Npc.GetMapPos(&m_nOffX, &m_nOffY);
	m_FightMode = Npc.m_FightMode;
	memset(m_szEnemyName, 0, 32);
	m_nEnemySeries = -1;
	m_nEnemyLife = 0;
	m_nEnemyLifeMax = 100;
	m_nEnemyLevel = 0;

	if (Npc.m_nPeopleIdx > 1)
	{
		lpCurAdd = lpBaseAdd + Npc.m_nPeopleIdx*NPC_DATA_SIZE;
		winProcess.ReadMemory(lpCurAdd, (LPVOID)&Npc, sizeof(Npc));
		strncpy(m_szEnemyName, Npc.Name, 31);
		m_nEnemySeries = Npc.m_Series;
		m_nEnemyLife = Npc.m_CurLife;
		m_nEnemyLifeMax = Npc.m_CurLifeMax;
		m_nEnemyLevel = Npc.m_Level;
	}

	__int64 nExp;
	winProcess.ReadMemory((LPBYTE)PLR_BASE_ADD, (LPVOID)&lpBaseAdd, 4);
	lpBaseAdd += PLAYER_OFFSET;
	lpCurAdd = lpBaseAdd + PLR_EXP_OFFSET;
	winProcess.ReadMemory(lpCurAdd, (LPVOID)&nExp, 8);
	lpCurAdd = lpBaseAdd + PLR_EXP_OFFSET + 8;
	winProcess.ReadMemory(lpCurAdd, (LPVOID)&m_nNextExp, 8);

	if (m_nNextExp == 0)
	{
		m_nExp = 0;
		return;
	}

	if (nExp < m_nExp || ((nExp - m_nExp) * 10000 / m_nNextExp > 0))
	{
		m_nExp = nExp;
		m_bInfoChanged = TRUE;
	}
}

void GameWindow::LoadProfile()
{
	if (!m_szPlayerName[0]) return;

	TCHAR szAccountID[32] = _T("");
	MultiByteToWideChar(CP_ACP, 0, m_szAccountID, -1, szAccountID, 32);

	TCHAR szFileName[MAX_PATH];
	_stprintf(szFileName, _T("%s\\UiConfig\\%s.cfg"), g_szAppFolder, szAccountID);

	LoadConfigFile(szFileName);
}

BOOL GameWindow::LoadConfigFile(LPCTSTR szFileName)
{
	CFile cfgFile;
	if (!cfgFile.Open(szFileName, CFile::modeRead | CFile::shareDenyWrite))
		return FALSE;

	//Identification
	char szVersion[12] = "";
	cfgFile.Read(szVersion, sizeof(szVersion));
	if (strcmp(szVersion, _SZCURVERSION))
	{
		cfgFile.Close();
		return FALSE;
	}

	char szAccountID[32] = "";
	cfgFile.Read(szAccountID, sizeof(szAccountID));

	if (!m_prBasic.ReadFromFile(cfgFile))
		return FALSE;
	if (!m_prRecover.ReadFromFile(cfgFile))
		return FALSE;
	if (!m_prAttack.ReadFromFile(cfgFile))
		return FALSE;
	if (!m_prCollect.ReadFromFile(cfgFile))
		return FALSE;
	if (!m_prMove.ReadFromFile(cfgFile))
		return FALSE;
	if (!m_prParty.ReadFromFile(cfgFile))
		return FALSE;
	if (!m_prMap.ReadFromFile(cfgFile))
		return FALSE;
	if (!m_prYeSou.ReadFromFile(cfgFile))
		return FALSE;

	if (strcmp(m_szAccountID, szAccountID))
		memset(&m_prAttack.m_SettingSkills, 0, sizeof(m_prAttack.m_SettingSkills));

	CVLAutoDlg *pMainDlg = (CVLAutoDlg*)theApp.GetMainDlg();
	((CDlgMap*)pMainDlg->m_MainTab.GetTabDlg(tab_map))->UpdateTrainMap(0);
	pMainDlg->m_MainTab.GetTabDlg(tab_basic)->UpdateData(0);

	cfgFile.Close();

	return TRUE;
}

void GameWindow::SaveProfile()
{
	if (!m_szPlayerName[0]) return;

	TCHAR szAccountID[32] = _T("");
	MultiByteToWideChar(CP_ACP, 0, m_szAccountID, -1, szAccountID, 32);

	TCHAR szFileName[MAX_PATH];
	_stprintf(szFileName, _T("%s\\UiConfig\\%s.cfg"), g_szAppFolder, szAccountID);

	SaveConfigFile(szFileName);
}

BOOL GameWindow::SaveConfigFile(LPCTSTR szFileName)
{
	CFile cfgFile;
	if (!cfgFile.Open(szFileName, CFile::modeCreate | CFile::modeWrite))
		return 0;

	//Identification
	char szVersion[12] = "";
	strcpy(szVersion, _SZCURVERSION);
	cfgFile.Write(szVersion, sizeof(szVersion));

	cfgFile.Write(m_szAccountID, sizeof(m_szAccountID));

	if (!m_prBasic.WriteToFile(cfgFile))
		return FALSE;
	if (!m_prRecover.WriteToFile(cfgFile))
		return FALSE;
	if (!m_prAttack.WriteToFile(cfgFile))
		return FALSE;
	if (!m_prCollect.WriteToFile(cfgFile))
		return FALSE;
	if (!m_prMove.WriteToFile(cfgFile))
		return FALSE;
	if (!m_prParty.WriteToFile(cfgFile))
		return FALSE;
	if (!m_prMap.WriteToFile(cfgFile))
		return FALSE;
	if (!m_prYeSou.WriteToFile(cfgFile))
		return FALSE;

	cfgFile.Close();

	return TRUE;
}

BOOL GameWindow::IsRegistered()
{
	int nLevel = m_nPlayerLevel;
	__asm { add nLevel, 30 }
	if (nLevel < 50) return TRUE;

	char szCharName[33] = "c";
	strcat(szCharName, m_szPlayerName);
	unsigned int uCharacterID = HashString2ID(szCharName);
	memset(szCharName, 0, sizeof(szCharName));

	JUNK_CODE_ONE;
	return TRUE;

	for (int i = 0; i < MAX_LIC_COUNT; i++)
	{
		if (theGameData.RegCode[i] == g_HardDiskID)
			return TRUE;
		if (theGameData.RegCode[i] == uCharacterID)
			return TRUE;
	}

	return FALSE;
}

void GameWindow::SetGameParams(int nTabIdx)
{
	LPCVOID wpOffsets[] = { &m_prBasic, &m_prRecover, &m_prAttack, &m_prCollect,
		&m_prMove, &m_prParty, &m_prMap, &m_prYeSou };

	if (nTabIdx < 0)
	{
		for (int i = tab_basic; i <= tab_yesou; i++)
			::PostMessage(m_hWnd, AutoParamMsg[i].uMsg, (WPARAM)wpOffsets[i], AutoParamMsg[i].lParam);
	}
	else if (nTabIdx <= tab_yesou)
		::PostMessage(m_hWnd, AutoParamMsg[nTabIdx].uMsg, (WPARAM)wpOffsets[nTabIdx], AutoParamMsg[nTabIdx].lParam);
}

// GameWindowsSet Class
GameWindow* GameWindowsSet::FindGameWindow(HWND hGameWnd)
{
	for (int i = 0; i < g_pCharList->GetItemCount(); i++)
	{
		GameWindow* pGameWin = (GameWindow*)g_pCharList->GetItemData(i);
		if (pGameWin->m_hWnd == hGameWnd)
			return pGameWin;
	}

	return NULL;
}

void GameWindowsSet::RefreshWindows(BOOL bRefreshAll)
{
	if (bRefreshAll)
	{
		HWND hWnd = NULL;

		while (TRUE)
		{
			hWnd = FindWindowEx(NULL, hWnd, VLTK_WINCLASS, NULL);
			if (hWnd == NULL)
				break;

			TCHAR szGameY[MAX_PATH];
			DWinProcess winProcess(hWnd);
			winProcess.GetModuleBaseName(NULL, szGameY, MAX_PATH);

			_tcslwr(szGameY);
			if (!_tcsstr(szGameY, _TGameY_Exe)) continue;

			if (FindGameWindow(hWnd) == NULL)
			{
				if (g_pCharList->GetItemCount() >= 4)
					return;

				GameWindow* pGameWin = new GameWindow(hWnd);
				g_pCharList->InsertItem(0, _T(""));
				g_pCharList->SetItemData(0, (DWORD_PTR)pGameWin);
				g_pCharList->SetItemState(0, LVIS_SELECTED, LVIS_SELECTED);
			}
		}

		return;
	}

	for (int i = 0; i < g_pCharList->GetItemCount(); i++)
	{
		GameWindow* pGameWin = (GameWindow*)g_pCharList->GetItemData(i);
		pGameWin->Refresh();
	}
}
