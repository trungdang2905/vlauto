#include "stdafx.h"
#include "../GameDef.h"
#include "PELib.h"
#include "AntiRE.h"
#include "GameBase.h"
#include "JxCore.h"
#include "VLClasses.h"
#include "VLHook.h"

#define WM_HOOKEX			WM_USER + 99
#define WM_HOOK_MAIN		WM_USER + 100
#define WM_HOOK_BASIC		WM_USER + 101
#define WM_HOOK_RECOVER		WM_USER + 102
#define WM_HOOK_ATTACK		WM_USER + 103
#define WM_HOOK_COLLECT		WM_USER + 104
#define WM_HOOK_MOVE		WM_USER + 105
#define WM_HOOK_PARTY		WM_USER + 106
#define WM_HOOK_MAP			WM_USER + 107
#define WM_HOOK_YESOU		WM_USER + 108
#define WM_HOOK_UTIL		WM_USER + 109
#define WM_HOOK_EXDATA		WM_USER + 110

#define SHIFTED				0x8000
#define SYS_TIMER			40		// ~50ms
#define MAX_PLAY_TIME		36000	// 30*60*20 = 30 minutes
#define MAX_PAUSE_TIME		4		// ~200ms

HINSTANCE			g_hDll;
WNDPROC				OldWndProc = NULL;
LRESULT CALLBACK	NewWndProc(HWND, UINT, WPARAM, LPARAM);
VOID CALLBACK		TimerProc(HWND hWnd, UINT uMsg, UINT_PTR idEvent, DWORD dwTime);

UINT_PTR			nTimerID = 0;
BOOL				bHooked = 0;
BOOL				g_SysPause = 0;
BOOL				bPausing = 0;
UINT				nPausingCount = 0;
int					g_RunningTimer = 0;
int					g_NetworkOffline = 0;

CVLMain theMain;
CVLBasic theBasic;
CVLRecover theRecover;
CVLAttack theAttack;
CVLCollect theCollect;
CVLMove theMove;
CVLParty theParty;
CVLMap theMap;
CVLQuest theQuest;
CVLUtil theUtil;

void GetHardDriveComputerID(char* HardDriveID);

BOOL APIENTRY DllMain(HANDLE hModule, DWORD uReason, LPVOID lpReserved)
{
	if (uReason == DLL_PROCESS_ATTACH)
	{
		g_hDll = (HINSTANCE)hModule;
		DisableThreadLibraryCalls(g_hDll);
    }
    return TRUE;
}

#define pCW ((CWPSTRUCT*)lParam)

LRESULT HookProc(int nCode, WPARAM wParam, LPARAM lParam)
{
	HWND hWndGame = pCW->hwnd;
	HHOOK hHook = (HHOOK)pCW->wParam;
	HWND hWndServer = (HWND)pCW->lParam;

	if (pCW->message != WM_HOOKEX)
		goto END;

	if (hWndServer)
	{
		_UnhookWindowsHookEx(hHook);

		if (bHooked)
			goto END;

		char lib_name[MAX_PATH];
		GetModuleFileName(g_hDll, lib_name, MAX_PATH);

		if (!LoadLibrary(lib_name))
			goto END;

		OldWndProc = (WNDPROC)_SetWindowLong(hWndGame, GWL_WNDPROC, (LONG)NewWndProc);

		if (OldWndProc == NULL)
			FreeLibrary(g_hDll);
		else
		{
			theMain.SetDllFilePath(lib_name);
			theMain.InitParams(hWndGame, hWndServer);
			nTimerID = _SetTimer(NULL, NULL, SYS_TIMER, (TIMERPROC)TimerProc);

			bHooked = TRUE;
		}
	}
	else
	{
		_UnhookWindowsHookEx(hHook);

		if (!bHooked)
			goto END;

		if (nTimerID)
			_KillTimer(NULL, nTimerID);

		if (!_SetWindowLong(hWndGame, GWL_WNDPROC, (LONG)OldWndProc))
			goto END;

		theMain.ClearEverything();

		FreeLibrary(g_hDll);
		bHooked = FALSE;
	}

END:
	return _CallNextHookEx(hHook, nCode, wParam, lParam);
}

VOID CALLBACK TimerProc(HWND hWnd, UINT uMsg, UINT_PTR idEvent, DWORD dwTime)
{
	if (g_RunningTimer++ < 1) return;

	if (bPausing)
	{
		if (nPausingCount)
			nPausingCount--;
		else
		{
			theMain.SetPause(FALSE);
			bPausing = FALSE;
		}
	}

	KSubWorld *pSubWorld = (KSubWorld*)GetPtrAddress(WLD_BASE_ADD);
	if (!pSubWorld) return;

	if (P_PLAYER->m_dwID == 0 || P_PLAYER->m_SyncSignal == 0)
		g_NetworkOffline = -1;
	else
		g_NetworkOffline = (pSubWorld->m_dwCurrentTime - P_PLAYER->m_SyncSignal) / 18;

	theRecover.Breathe();
	theCollect.Breathe();

	if (g_RunningTimer % 2 == 0) // Chu ky 100ms
		theUtil.Breath();

	if (g_SysPause) return;

	if (g_RunningTimer % 2 == 1)		// Chu ky 100ms
		theAttack.Breathe();
	if (g_RunningTimer % 4 == 2)		// Chu ky 200ms
		theMove.Breathe();
	if (g_RunningTimer % 12 == 5)		// Chu ky 600ms
		theMap.Breathe();
	if (g_RunningTimer % 20 == 12)		// Chu ky 1s
		theBasic.Breathe();
	if (g_RunningTimer % 30 == 17)		// Chu ky 1.5s
		theParty.Breathe();
	if (g_RunningTimer % 100 == 58)		// Chu ky 5s
		theQuest.CheckStatus();
}

LRESULT CALLBACK NewWndProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	if (uMsg >= WM_HOOK_MAIN && uMsg <= WM_HOOK_EXDATA)
	{
		DWORD dwProcessID;
		_GetWindowThreadProcessId(theMain.m_hWndAuto, &dwProcessID);
		HANDLE hProcess = OpenProcess(PROCESS_VM_READ | PROCESS_QUERY_INFORMATION, FALSE, dwProcessID);

		switch (uMsg)
		{
		case WM_HOOK_MAIN:
			if (wParam == cmd_exit)
				theMain.ExitGame();
			else if (wParam == cmd_loadini)
				theMain.LoadOptions();
			break;
		case WM_HOOK_BASIC:
			ReadProcessMemory(hProcess, (LPCVOID)wParam, (LPVOID)&theBasic, lParam, NULL);
			break;
		case WM_HOOK_RECOVER:
			ReadProcessMemory(hProcess, (LPCVOID)wParam, (LPVOID)&theRecover, lParam, NULL);
			break;
		case WM_HOOK_ATTACK:
			ReadProcessMemory(hProcess, (LPCVOID)wParam, (LPVOID)&theAttack, lParam, NULL);
			theAttack.SetAutoHit();
			break;
		case WM_HOOK_COLLECT:
			ReadProcessMemory(hProcess, (LPCVOID)wParam, (LPVOID)&theCollect, lParam, NULL);
			theCollect.SetAutoArrange();
			break;
		case WM_HOOK_MOVE:
			ReadProcessMemory(hProcess, (LPCVOID)wParam, (LPVOID)&theMove, lParam, NULL);
			theMove.GetCurNode();
			break;
		case WM_HOOK_PARTY:
			ReadProcessMemory(hProcess, (LPCVOID)wParam, (LPVOID)&theParty, lParam, NULL);
			break;
		case WM_HOOK_MAP:
			ReadProcessMemory(hProcess, (LPCVOID)wParam, (LPVOID)&theMap, lParam, NULL);
			theMap.CheckAutoReturn();
			break;
		case WM_HOOK_YESOU:
			ReadProcessMemory(hProcess, (LPCVOID)wParam, (LPVOID)&theQuest, lParam, NULL);
			theQuest.CheckAutoYeSou();
			break;
		case WM_HOOK_UTIL:
			ReadProcessMemory(hProcess, (LPCVOID)wParam, (LPVOID)&theUtil, lParam, NULL);
			break;
		case WM_HOOK_EXDATA:
			theMain.InitGameData();
			theQuest.PrepareLog();
			g_RunningTimer = 1;
			break;
		}

		CloseHandle(hProcess);
		return 0;
	}

	// Other Messages
	RECT rcCenter = { 360, 180, 440, 320 };
	POINT ptPos = { LOWORD(lParam), HIWORD(lParam) };
	switch (uMsg)
	{
	case WM_KEYDOWN:
		if (_GetKeyState(VK_CONTROL) & SHIFTED)
		{
			BOOL bCaught = TRUE;
			if (wParam == 'A')
				theMain.PostFeedBack(cmd_autohit);
			else if (wParam == 'B')
				theMain.PostFeedBack(cmd_autoarng);
			else if (wParam == 'G')
				theMain.PostFeedBack(cmd_setmap);
			else if (wParam == 'D')
				theMain.PostFeedBack(cmd_setyesou);
			else if (wParam == 'S')
				theMove.SavePoint();
			else if (wParam == 'Z')
				theUtil.OpenCloseStoreBox();
			else if (wParam == 'T')
				theUtil.OpenCloseNpcShop();
			else if (wParam == VK_SPACE)
				theUtil.ReadPosition();
			else if (wParam == VK_DELETE)
				theUtil.DeleteSysMessages();
			else if (wParam == 'X')
				theUtil.CheckLifeTime();
			else if (wParam == 'N')
				theUtil.AutoClickNpc();
			else if (wParam == 'W')
				theQuest.ReportQuest();
			else if (wParam == 'L')
				theMap.SaveNewRepository();
			else if (wParam == 'E')
				theUtil.StartGiveKCL();
			else if (wParam == '9')
				theUtil.StartOpenGift();
			else if (wParam == '0')
				theUtil.StopAllUtils();
			else if (wParam == '1')
				theUtil.TestFunction(1);
			else if (wParam == '2')
				theUtil.TestFunction(2);
			else if (wParam == '3')
				theRecover.OnUseAM();
			else
				bCaught = FALSE;
			if (bCaught) return 0;
		}
		break;
	case WM_ACTIVATE:
		if (LOWORD(wParam) != WA_INACTIVE)
			theMain.PostFeedBack(cmd_activate);
		break;
	case WM_LBUTTONDOWN:
		bPausing = 0;
		theMain.SetPause();
		break;
	case WM_LBUTTONUP:
		bPausing = TRUE;
		nPausingCount = MAX_PAUSE_TIME;
		break;
	case WM_LBUTTONDBLCLK:
		if ((wParam & MK_CONTROL) && _PtInRect(&rcCenter, ptPos))
		{
			g_SysPause = !g_SysPause;
			if (g_SysPause)
				SystemMessage("<color=yellow>VLAuto: <color>T¹m ng­ng!!!");
			else
				SystemMessage("<color=yellow>VLAuto: <color=green>Më l¹i!!!");
		}
		break;
	case WM_RBUTTONDBLCLK:
		if ((wParam & MK_CONTROL) && _PtInRect(&rcCenter, ptPos))
		{
			SystemMessage("<color=yellow>Khëi ®éng l¹i VLAuto!!!");
			theMain.RestartHook();
		}
		break;
	}
	return _CallWindowProc(OldWndProc, hWnd, uMsg, wParam, lParam);
}

HOOKDLL_API unsigned StartInject(HWND hWndGame, HWND hWndAuto)
{
	if (hWndGame == 0)
	{
		char HardDriveID[33] = "h";
		GetHardDriveComputerID(HardDriveID + 1);
		return HashString2ID(HardDriveID);
	}

	if (!_IsWindow(hWndGame))
		return 0;

	HHOOK hHook = _SetWindowsHookEx(WH_CALLWNDPROC, (HOOKPROC)HookProc, g_hDll, _GetWindowThreadProcessId(hWndGame, NULL));
	if (hHook == NULL)
		return 0;

	_SendMessage(hWndGame, WM_HOOKEX, (WPARAM)hHook, (LPARAM)hWndAuto);

	return 1;
}

HOOKDLL_API unsigned StopInject(HWND hWndGame)
{	
	if (!_IsWindow(hWndGame))
		return 0;

	HHOOK hHook = _SetWindowsHookEx(WH_CALLWNDPROC, (HOOKPROC)HookProc, g_hDll, _GetWindowThreadProcessId(hWndGame, NULL));
	if (hHook == NULL)
		return 0;

	_SendMessage(hWndGame, WM_HOOKEX, (WPARAM)hHook, 0);

	return 1;
}
