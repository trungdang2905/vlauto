#pragma once

////////////////////////////////////////////
// Common Classes & Structs
////////////////////////////////////////////
struct KUiPlayerItem
{
	char			Name[64];
	unsigned int	uId;
	int				nIndex;
	int				nData;
};

struct KOneMsgInfo
{
	int			 nLines;
	int			 nCharWidth;
	unsigned int uColor[3];
	int			 nMaxSize;
	int			 nLen;
	char		 Msg[1];
};

struct KShopObject
{
	unsigned int	uGenre;
	unsigned int	uId;
	int				DataX;
	int				DataY;
	int				DataW;
	int				DataH;
	int				eContainer;
	int				UnusedData[3];
};

struct KUiSkillData
{
	unsigned int	uGenre;
	unsigned int	uId;
	int				DataX;
	int				DataY;
};

class KWndImage
{
public:
	DWORD			m_dwWinHandle;
	unsigned int	m_Style;
public:
	BOOL IsVisible();
};

class KUiInit : public KWndImage
{
public:
	void QuitGame();
};

class KUiMiniMap : public KWndImage
{
public:
	void SetMapFlag(int nDx, int nDy);
};

class KUiYeSouBox : public KWndImage
{
public:
	void OnConfirm(int btnYes = 1);
};

struct KSystemMessage
{
	char			szMessage[64];
	BYTE			Data01[0x03C8];
	KUiPlayerItem	mInviter;
};

class KUiSysMsgCentre
{
public:
	BYTE			Data01[0x0100];
	struct SYS_MSG_HEAP
	{
		KSystemMessage**	pMsgList;
		int					nListSpace;
		int					nNumValid;
	} m_MsgHeap[8];

public:
	void DeleteMsgInHeap(int nHeapIndex, int nMsgIndex);
};

class KUiTongManagement
{
public:
	BYTE m_TongData[0x01AC];
	int m_nTongListPage;

public:
	int PrepareTongList(int nSortType);
	TongList* GetTongList();
};

////////////////////////////////////////////
// Specified Classes & Structs
////////////////////////////////////////////
#define	GSHOP_BUTTON		0x08A8
#define	EXITGAME_BUTTON		0x0B48
#define	CHATROOM_LIST		0x1C34

class KUiMsgSel : public KWndImage
{
public:
	BYTE			m_MsgData1[0x03E4];
	KOneMsgInfo**	m_pMessages;		// 0x03EC
	int				m_nNumMessage;		// 0x03F0
	int				m_nCapability;
	BYTE			m_MsgData2[0x0650];
	int				m_nInfoLen;
	int				m_nInfoColor;
	int				m_nInfoLines;
	char			m_InfoText[512];	// 0x0A54
public:
	void OnClickMsg(int nMsg);
};

class KUiMsgSel2 : public KWndImage
{
public:
	BYTE			m_MsgData1[0x080C];
	KOneMsgInfo**	m_pMessages;		// 0x0814
	int				m_nNumMessage;		// 0x0818
	int				m_nCapability;
	BYTE			m_MsgData2[0x0A94];
	char			m_InfoText[512];	// 0x12B4
public:
	void OnClickMsg(int nMsg);
};

class KUiShop : public KWndImage
{
public:
	BYTE			ShopData1[0x01E0];
	KItemObject		*m_pObjectList;		// 0x01E8
	BYTE			ShopData2[0x001C];
	int				m_nObjCount;		// 0x0208
	int				m_nPageCount;
	int				m_nCurrentPage;
};

class KUiPlayerBar : public KWndImage
{
public:
	BYTE			BarData1[0x126C];
	int				m_nHK3Gengre;		// 0x1274
public:
	void OnClickGShop();
};

class KUiInformation : public KWndImage
{
public:
	BYTE			InfoData[0x03B8];
	char			m_szInfoText[128];		// 0x03C0
public:
	void Hide(int nBtnIndex);
};

class KUiInformation2 : public KWndImage
{
public:
	BYTE			InfoData[0x03B8];
	char			m_szInfoText[128];		// 0x03C0
public:
	void Hide();
};

class KUiPlayerStall : public KWndImage
{
public:
	BYTE			StallData[0x055C];
	int				m_nObjCount;			// 0x0564
	KShopObject		*m_pObjectList;
};

struct PrizeItem
{
	BYTE			PrzData1[0x06C4];
	char			m_szIcon[0x0080];
	BYTE			PrzData2[0x0020];
	char			m_szText[0x0080];
};

class KUiPrizeSel : public KWndImage
{
public:
	BYTE			PrzData1[0x0018];
	PrizeItem		PrzItem[3];
public:
	void OnClickBtn(int nBtn);
};

class KWndMessageListBox
{
public:
	BYTE m_MsgListBoxData[0x0204];
	KOneMsgInfo**	m_pMessages;		//0x1E38
	int				m_nNumMessage;
	int				m_nCapability;
};

////////////////////////////////////////////
// Global Functions & Variables
////////////////////////////////////////////
void SendPrivateMessage(const char *szName, const char *szMsg);
void SystemMessage(const char *szMsg, int nChanel = 0);
void SystemMessage(int nChanel, const char *szMsgFormat, ...);

extern KUiInformation*	g_UiInformation;
extern KUiInformation2* g_UiInformation2;

extern void(*ProcessPeople)(KUiPlayerItem*, int);
extern void(*OnSendSomeoneMessage)(const char*, const char*, int);
extern void(*SystemMessageArrival)(const char*, unsigned short, int);
extern void(*OpenStoreWindow)();
extern void(*OpenShopWindow)();
extern void(*CloseAllWindows)(int);
