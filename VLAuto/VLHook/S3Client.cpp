#include "stdafx.h"
#include "../GameDef.h"
#include "GameBase.h"
#include "JxCore.h"
#include "S3Client.h"

// Global Variables
KUiInformation*		g_UiInformation;
KUiInformation2*	g_UiInformation2;

// Global Functions
void(*ProcessPeople)(KUiPlayerItem* pDest, int nAction);
void(*OnSendSomeoneMessage)(const char*, const char*, int);
void(*SystemMessageArrival)(const char*, unsigned short, int);
void(*OpenStoreWindow)();
void(*OpenShopWindow)();
void(*CloseAllWindows)(int);

void SendPrivateMessage(const char *szName, const char *szMsg)
{
	int nLen = (int)strlen(szMsg);
	OnSendSomeoneMessage(szName, szMsg, nLen);
}

void SystemMessage(const char *szMsg, int nChanel)
{
	int nMaxLen = (int)strlen(szMsg) + 1;
	if (nMaxLen > 1)
		SystemMessageArrival(szMsg, nMaxLen, nChanel);
}

void SystemMessage(int nChanel, const char *szMsgFormat, ...)
{
	char szMsg[260] = "";

	va_list vlist;
	va_start(vlist, szMsgFormat);
	vsprintf(szMsg, szMsgFormat, vlist);
	va_end(vlist);

	SystemMessage(szMsg, nChanel);
}

// Class KWndImage
BOOL KWndImage::IsVisible()
{
	return (m_Style & WND_S_VISIBLE);
}

// Class KUiInit
void KUiInit::QuitGame()
{
	__asm
	{
		mov eax, ecx;
		add eax, EXITGAME_BUTTON;
		push eax;
		mov eax, IOC_FUNC_ADD;
		call eax;
	}
}

// Class KUiMsgSel
void KUiMsgSel::OnClickMsg(int nMsg)
{
	__asm
	{
		push nMsg;
		mov eax, OMS_FUNC_ADD;
		call eax;
	}
}

// Class KUiMsgSel2
void KUiMsgSel2::OnClickMsg(int nMsg)
{
	__asm
	{
		push nMsg;
		mov eax, OMS2_FUNC_ADD
			call eax;
	}
}

// Class KUiPlayerBar
void KUiPlayerBar::OnClickGShop()
{
	__asm
	{
		push 0;
		mov eax, ecx;
		add eax, GSHOP_BUTTON;
		push eax;
		push WND_N_BUTTON_CLICK;
		mov eax, UWP_FUNC_ADD;
		call eax;
	}
}

// Class KUiMiniMap
void KUiMiniMap::SetMapFlag(int nDx, int nDy)
{
	__asm
	{
		push nDy;
		push nDx;
		mov eax, SMF_FUNC_ADD;
		call eax;
	}
}

// Class KUiInformation
void KUiInformation::Hide(int nBtnIndex)
{
	__asm
	{
		push nBtnIndex;
		mov eax, IH1_FUNC_ADD;
		call eax;
	}
}

// Class KUiInformation2
void KUiInformation2::Hide()
{
	__asm
	{
		mov eax, IH2_FUNC_ADD;
		call eax;
	}
}

// Class KUiYeSouBox
void KUiYeSouBox::OnConfirm(int btnYes)
{
	__asm
	{
		push btnYes;
		mov eax, OCB_FUNC_ADD;
		call eax;
		add esp, 0x04;
	}
}

// Class KUiPrizeSel
void KUiPrizeSel::OnClickBtn(int nBtn)
{
	g_pCoreShell->OperationRequest(GOI_QUESTION_CHOOSE, 0, nBtn);
	__asm
	{
		push 0;
		mov eax, PSC_FUNC_ADD;
		call eax;
		add esp, 0x04;
	}
}

// Class KUiSysMsgCentre
void KUiSysMsgCentre::DeleteMsgInHeap(int nHeapIndex, int nMsgIndex)
{
	__asm
	{
		push nMsgIndex;
		push nHeapIndex;
		mov eax, SMD_FUNC_ADD;
		call eax;
	}
}

// Class KUiTongManagement
int KUiTongManagement::PrepareTongList(int nSortType)
{
	__asm
	{
		push nSortType;
		mov eax, TGP_FUNC_ADD;
		call eax;
	}
}

TongList* KUiTongManagement::GetTongList()
{
	__asm
	{
		push 0;
		mov eax, TGL_FUNC_ADD;
		call eax;
	}
}
