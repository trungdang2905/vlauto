#include "stdafx.h"
#include "../GameDef.h"
#include "GameBase.h"
#include "JxCore.h"
#include "S3Client.h"
#include "VLClasses.h"

//================================Class CVLBasic================================
CVLBasic::CVLBasic(void)
{
	m_bExitWhenAM = 0;
	m_bExitWhenDis = 0;
	m_nExitDisTime = 60;
	m_nDistTimeCount = 0;
	m_nIdleTimeCount = 0;
	strcpy(m_szCurName, "");
}

void CVLBasic::Breathe()
{
	static int nCheckName = 0;
	KUiSysMsgCentre *pSysMsg = (KUiSysMsgCentre*)(GetPtrAddress(SMC_BASE_ADD));
	if (!pSysMsg)	// not in Game
	{
		if (nCheckName == 1)
			nCheckName = 2;
		if (theMain.m_bQuitingGame)
		{
			KUiInit *pUiUnit = (KUiInit*)(GetPtrAddress(UIN_BASE_ADD));
			if (pUiUnit && pUiUnit->IsVisible())
				pUiUnit->QuitGame();
		}
		return;
	}

	if (g_NetworkOffline == -1)	// disconnected
	{
		nCheckName = 2;
		m_nDistTimeCount++;
		if (m_bExitWhenDis && m_nDistTimeCount > m_nExitDisTime*60)
			theMain.ExitGame();
		return;
	}
	m_nDistTimeCount = 0;

	// Update TongList
	if (!g_GlobalTongInfo)
		theMain.UpdateTongList();

	if (nCheckName == 0)
	{
		nCheckName = 1;
		strcpy(m_szCurName, P_PLAYER->Name);
	}
	else if (nCheckName == 2)
	{
		nCheckName = 0;
		if (strcmp(m_szCurName, P_PLAYER->Name))
		{
			SystemMessage("Nh©n vËt ®· thay ®æi, khëi ®éng l¹i...");
			theMain.RestartHook();
		}
		return;
	}

	if (g_NetworkOffline > 180)	// no response over 3 minutes
	{
		SystemMessage("Ng¨t m¹ng qu¸ 3 phót, kÕt nèi l¹i...");
		ExecuteScript("SayPhrase(1)");
		return;
	}

	static int nReviveTime = 2;
	if (P_PLAYER->m_Doing == do_revive || P_PLAYER->m_Doing == do_death) // online, but role died
	{
		if (nReviveTime && P_PLAYER->m_FightMode) { nReviveTime--; return; } // wait for AM
		if (g_UiInformation->IsVisible())
		{
			if (strstr(g_UiInformation->m_szInfoText, "B¹n ®· bÞ träng th­¬ng"))
				g_UiInformation->Hide(0);
			return;
		}
		if (P_PLAYER->m_bRideHorse)
		{
			ExecuteScript(SCK_SHORTCUT_HORSE); // Xuong ngua
			return;
		}
		ExecuteScript(SCK_SHORTCUT_SIT);
	}
	nReviveTime = 2;

	if (theUtil.m_bDoingUtil) return;
	if (theQuest.m_bGoTrainGetPK) return;

	if (g_pCurPlayer->m_nEntrustMode)	// online entrustment
	{
		m_nIdleTimeCount = 0;
		return;
	}
	if (P_PLAYER->m_Doing != do_run && P_PLAYER->m_Doing != do_walk && P_PLAYER->m_Doing != do_attack) // online, but no move
		m_nIdleTimeCount++;
	else
		m_nIdleTimeCount = 0;
	if (m_nIdleTimeCount > 180)
	{
		if (g_UiInformation->IsVisible())
		{
			if (strstr(g_UiInformation->m_szInfoText, "B¹n ®· bÞ träng th­¬ng"))
				g_UiInformation->Hide(0);
			else
				g_UiInformation->Hide(1);
		}
		if (g_UiInformation2->IsVisible())
			g_UiInformation2->Hide();
		KUiMsgSel *pMsgSel = (KUiMsgSel*)GetPtrAddress(MSG_BASE_ADD);
		if (pMsgSel && pMsgSel->IsVisible())
			pMsgSel->OnClickMsg(pMsgSel->m_nNumMessage);
		KUiMsgSel2 *pMsgSel2 = (KUiMsgSel2*)GetPtrAddress(MSG2_BASE_ADD);
		if (pMsgSel2 && pMsgSel2->IsVisible())
			pMsgSel2->OnClickMsg(pMsgSel2->m_nNumMessage);

		m_nIdleTimeCount = 0;
		char *szMsg = "Ngõng ho¹t ®éng qu¸ 3 phót, khëi ®éng l¹i...";
		theQuest.SaveYSLog(szMsg);
		SystemMessage(szMsg);
		CloseAllWindows(0);
		theMain.RestartHook();
	}
}
