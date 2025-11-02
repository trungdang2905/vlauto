#pragma once

#include "KNode.h"

////////////////////////////////////////////
// Common Definitions
////////////////////////////////////////////
#define GetPtrAddress(p) (*(PDWORD_PTR)p)
#define P_PLAYER g_pNpcArray[g_pCurPlayer->m_nIndex]
#define PEOPLE_IDX P_PLAYER->m_nPeopleIdx
#define HAVE_HORSE g_pCurPlayer->m_ItemList.m_EquipItem[itempart_horse].m_nIndex > 0
#define ItmAttr(j) pItem->m_aryAllAttrib[j].nAttribType
#define ComAttr pItem->m_CommonAttrib
#define PLAYER_ROOM g_pCurPlayer->m_ItemList.m_Room
#define EQUIP_ROOM PLAYER_ROOM[room_equipment]
#define EQUIP_MONEY PLAYER_ROOM[room_equipment].m_nMoney
#define ROOM_MONEY PLAYER_ROOM[room_repository].m_nMoney
#define PLAYER_ITEM(i) g_pCurPlayer->m_ItemList.m_Items[i]
#define IAM_IN_A_PARTY g_pCurPlayer->m_cTeam.m_nFlag
#define IAM_THE_CAPTAIN g_pCurPlayer->m_cTeam.m_nFigure == 0
#define PLAY_HAND_IDX g_pCurPlayer->m_ItemList.m_nForeHand

////////////////////////////////////////////
// Common Classes & Structs
////////////////////////////////////////////

struct KSubWorld
{
	int			m_ReservedData[12];
	int			m_nWorldRegionWidth;
	int			m_nWorldRegionHeight;
	int			m_nTotalRegion;
	int			m_nCellWidth;
	int			m_nCellHeight;
	int			m_nRegionBeginX;
	int			m_nRegionBeginY;
	int			m_nWeather;
	DWORD		m_dwCurrentTime;				// 0x0050
};

class KSkill
{
public:
	int			m_nIndex;
	int			m_nSkillType;
	int			m_nMaxLevel;
	char		m_szSkillName[32];
	DWORD		m_dwSkillID;
	BYTE		SkillData1[0x0020];
	int			m_nSkillRange;
	BYTE		SkillData2[0x0060];
	int			m_nHorseLimited;
};

struct ObjSkill
{
	int			m_nKind;
	int			m_nCamp;
	int			m_nRange;
	int			m_nCastTime;
	int			m_nID;
	int			m_nLevel;
	int			m_nTarX;
	int			m_nTarY;
};

class KObj
{
public:
	int			m_nID;
	int			m_nDataID;
	int			m_Kind;
	int			m_Index;
	WORD		m_RegX;
	WORD		m_RegY;
	int			m_SubWorldID;
	int			m_RegionIdx;
	int			m_MapX;
	int			m_MapY;
	int			m_OffX;
	int			m_OffY;
	int			m_nDir;
	int			m_nState;
	int			m_nLifeTime;
	int			m_nBornTime;
	int			m_nWaitTime;
	ObjSkill	m_cSkill;			// 0x0040
	char		m_szName[32];		// 0x0060
	DWORD		m_dwScriptID;
	int			m_nColorID;
	int			m_nItemDataID;		// 0x0088
	int			m_nItemWidth;
	int			m_nItemHeight;
	int			m_nMoneyNum;
public:
	void GetMapPos(int *nX, int *nY);
};

struct KItemObject
{
	unsigned	uGenre;
	unsigned	uId;
	int			DataX;
	int			DataY;
	int			DataW;
	int			DataH;
	int			eContainer;
};

struct KCommonAttrib
{
	int			nItemGenre;
	int			nSpecialType;
	int			nDetailType;
	int			nParticularType;
	int			nObjIdx;
	BOOL		bStack;
	int			nWidth;
	int			nHeight;
	int			nPrice;
	int			nLevel;
	int			nSeries;
	char		szItemName[80];
	char		szImageName[80];
	char		szIntro[256];
	char		szScript[84];
	int			nNpcImage;
};

struct KIndexNode
{
	LPDWORD			__vfptr;
	KIndexNode*		m_pNext;
	KIndexNode*		m_pPrev;
	DWORD			NodeData[3];
};

struct KNpcGold
{
	int		m_nNpcIdx;
	int		m_nIsGold;
	int		m_nIsGolding;
	int		m_nGoldType;
};

struct KState
{
	int		nMagicAttrib;
	int		nValue[2];
	int		nTime;
};

struct KMagicAttrib
{
	int		nAttribType;
	int		nValue[3];

	KMagicAttrib()
	{
		nValue[0] = nValue[1] = nValue[2] = nAttribType = 0;
	}
};

class KStateNode : public KNode
{
public:
	int				m_nData;
	int				m_SkillID;
	int				m_Level;
	int				m_LeftTime;
	KMagicAttrib	m_State[10];
	int				m_StateGraphics;
};

struct NpcCommand
{
	NPCCMD		CmdKind;
	int			Param_X;
	int			Param_Y;
	int			Param_Z;
};

struct NpcSkill
{
	int		SkillId;
	int		SkillLevel;
	int		Reserverds[10];
};

struct PlayerItem
{
	int		nIdx;
	int		nPlace;
	int		nX;
	int		nY;
	int		nZ;
};

class KInventory
{
public:
	int*	m_pArray;
	int		m_nMoney;
	int		m_nWidth;
	int		m_nHeight;
	int		m_nMaxWidth;
	int		m_nMaxHeight;
	int		m_nReserved;
public:
	BOOL	FindRoom(int nWidth, int nHeight, POINT* pPos, BOOL bReversed = 0, int itemIdx = -1);
	BOOL	CanPlaceItem(int nX, int nY, int nWidth, int nHeight, int itemIdx = -1);
};

class KPlayerTeam
{
public:
	int		m_nFlag;
	int		m_nFigure;
};

class KPlayerTong
{
public:
	char		m_szMasterName[32];
	int			m_nUnusedData[3];
	int			m_nFlag;
	int			m_nFigure;
	int			m_nCamp;
	DWORD		m_dwTongNameID;			//0x5B28
	char		m_szTongName[32];
	BYTE		m_TongData[0x0068];
	int			m_nContributePoint;		//0x5BB4
};

class KPlayerTask
{
public:
	int GetTaskVal(int nTaskNum);
};

class KCoreShell
{
public:
	int		GetGameData(unsigned int nRequest, int uParam, int nParam);
	int		OperationRequest(unsigned int nRequest, int uParam, int nParam);
	int		GetNPCRelation(int nIndex);
	int		TongOperation(unsigned int nRequest, int uParam, int nParam);
	int		TeamOperation(unsigned int nRequest, int uParam, int nParam);
	int		ProcessGameSecurity(unsigned int nRequest, int uParam, int nParam);
};

////////////////////////////////////////////
// Specified Classes & Structs
////////////////////////////////////////////
struct KStallObject
{
	unsigned int	uId;
	int				Data01[15];
	int				DataX;
	int				DataY;
	int				DataW;
	int				DataH;
	int				nPrice;						//0x0040
	int				Data02[2];
};

class KTeam
{
public:
	int		m_nMember[MAX_TEAM_MEMBER];
	int		m_nMemNum;
	int		m_nMemNumEx;
	int		m_nMemLevel[MAX_TEAM_MEMBER];
	char	m_szMemName[MAX_TEAM_MEMBER][32];
};

class KNpc
{
public:
	DWORD				m_dwID;
	int					m_Index;
	KIndexNode			m_Node;
	int					m_Level;
	DWORD				m_Kind;
	int					m_Series;
	int					m_Height;
	BYTE				m_btRankId;
	int					m_nStature;
	int					m_nReviveTime;
	KNpcGold			m_cGold;
	//Reserved Data
	BYTE				NpcData1[0x0028];
	KState				m_PowerState;
	KState				m_PoisonState;
	KState				m_FreezeState;
	KState				m_BurnState;
	KState				m_ConfuseState;
	KState				m_StunState;
	KState				m_DrunkState;
	int					m_Camp;
	int					m_CurrentCamp;
	NPCCMD				m_Doing;
	//Reserved Data
	BYTE				NpcData2[0x000C];
	KStateNode*			m_pHeadNode;
	KStateNode*			m_pTailNode;
	int					m_nStateCount;
	int					m_ActiveSkillID;
	//Reserved Data
	BYTE				NpcData3[0x003C];
	NpcSkill			m_Skills[MAX_NPCSKILL];
	//Reserved Data
	int					m_CurrentLife;
	int					m_LifeRep[3];
	int					m_CurrentMana;
	int					m_ManaRep[3];
	//Reserved Data
	BYTE				NpcData4[0x00D0];
	int					m_CurrentWalkSpeed;
	int					m_CurrentRunSpeed;
	//Reserved Data
	BYTE				NpcData5[0x0018];
	int					m_CurrentAttackRadius;
	int					m_CurrentActiveRadius;
	//Reserved Data
	BYTE				NpcData6[0x0138];
	int					m_Dir;
	int					m_RedLum;
	int					m_GreenLum;
	int					m_BlueLum;
	int					m_MapX, m_MapY, m_MapZ;
	int					m_OffX, m_OffY;
	//Reserved Data
	BYTE				NpcData7[0x0050];
	char				Name0;
	char				Name[39]; //130D
	int					m_nSex;
	int					m_NpcSettingIdx;
	int					m_CorpseSettingIdx;
	//Reserved Data
	BYTE				NpcData8[0x005C];
	int					m_nPeopleIdx;
	int					m_nLastDam[3];
	int					m_nObjectIdx;
	//Reserved Data
	BYTE				NpcData9[0x01B4];
	BOOL				m_FightMode;
	int					m_ExchangeServer[3];
	int					m_SyncSignal;
	//Reserved Data
	BYTE				NpcDataA[0x000C];
	WORD				m_RegX;
	WORD				m_RegY;
	//Reserved Data
	BYTE				NpcDataB[0x0018];
	int					m_nPKFlag;
	//Reserved Data
	BYTE				NpcDataC[0x0128];
	DWORD				m_dwTongNameID;
	BOOL				m_bHaveStall;
	//Reserved Data
	BYTE				NpcDataD[0x0084];
	NpcCommand			m_Command;
	//Reserved Data
	BYTE				NpcDataE[0x0098];
	BOOL				m_bRideHorse;
	//Reserved Data
	BYTE				NpcDataF[0xFAFC];
	int					m_CurrentLifeMax;
	int					m_CurrentStaminaMax;
	int					m_CurrentManaMax;

public:
	BOOL IsExist();
	BOOL IsNotMob();
	void GetMapPos(int *nX, int *nY);
	void MoveTo(int nX, int nY, int nAction = 0);
	void SendCommand(NPCCMD cmd, int x = 0, int y = 0, int z = 0);
};

struct EquipItem
{
	int		m_nIndex;
	int		m_nData;
};

class KItemList
{
public:
	int			m_nForeHand;
	int			m_nBackHand;
	EquipItem	m_EquipItem[itempart_num];
	int			m_ItemData0;
	PlayerItem	m_Items[MAX_PLAYER_ITEM];
	BYTE		m_ItemData1[0x26DC];
	KInventory	m_Room[room_num]; //0x4D8C
};

class KPlayer
{
public:
	LPDWORD			__vfptr;
	BYTE			PlayerData0[0x001C];
	int				m_nEntrustMode;
	int				m_nLeftSkillID;
	int				m_nLeftSkillLevel;
	int				m_nRightSkillID;
	int				m_nRightSkillLevel;
	BYTE			PlayerData1[0x0090];
	int				m_RunStatus;
	DWORD			m_dwNextLevelLeadExp;
	int				m_nSendMoveFrames;
	BYTE			PlayerData2[0x0040];
	DWORD			m_dwHashID;				//0x0110
	int				m_nIndex;
	BYTE			PlayerData3[0x0024];
	KItemList		m_ItemList;
	int				m_nTaskItems[20];
	int				m_nCurShop;
	BYTE			PlayerData4[0x091C];
	int				m_nAttributePoint;
	int				m_nSkillPoint;
	int				m_nStrength;
	int				m_nDexterity;
	int				m_nVitality;
	int				m_nEngergy;
	int				m_nLucky;
	int				m_nChatChannel;
	int				m_nCurStrength;
	int				m_nCurDexterity;
	int				m_nCurVitality;
	int				m_nCurEngergy;
	int				m_nCurLucky;
	__int64			m_nCurExp;				//0x58D8
	__int64			m_nNextExp;
	char			m_szPlayerName[40];
	KPlayerTeam		m_cTeam;
	BYTE			PlayerData5[0x05A8];
	int				m_nCurFaction;
	BYTE			PlayerData6[0x02CC];
	int				m_nPKValue;				//0x6190
	KPlayerTong		m_cTong;
	BYTE			PlayerData7[0x2328];
	KPlayerTask		m_cTask;				//0x8584

public:
	void DoSit();
	void MoveTo(KNpc* pNpc);
	void MoveTo(int nX, int nY);
	int GetTaskVal(int nTaskNum);
	void PickUpObj(int nobjIndex);
	int CheckRoom(int nRoom = room_equipment);
	int GetItemsCount(const char *szItemName, int nPlace = pos_equiproom);
	int GetItemsCount(int nGenre, int nDetailType, int nParticular = -1, int nSeries = -1, int nPlace = pos_equiproom);
	BOOL UseItem(const char *szItemName);
	BOOL EatMedicine(int nDetailType);
	void BuyItem(int nItemIdx);
	void SellItem(int nItemIdx);
	void RepairItem(int nItemIdx);
	void SwitchItem(int nContainer, int nX, int nY);
	void DialogNpc(int nIndex);
	BOOL EnterTongMap(int nStep = 0, DWORD dwTongID = 0); // nStep = 0,1,2
	void ApplyAddBaseAttribute(int nAttribute, int nNo);
};

class KItem
{
public:
	LPDWORD				__vfptr;
	KCommonAttrib		m_CommonAttrib;
	KMagicAttrib		m_aryAllAttrib[19];
	BYTE				ItemData1[0x34];
	int					m_MagicLevel[6];
	int					m_nUnUsed[6];
	DWORD				m_dwUniID;
	int					m_nCurDur;
	int					m_nMaxDur;
	BYTE				ItemData2[0x28];
	int					m_nItemPlus;
	BYTE				ItemData3[0x08];
	BOOL				m_nLockCount;

public:
	int GetTotalMagicLevel();
	int	GetRepairPrice();
};

class KBuySell
{
public:
	KItem*		GetItem(int nIndex);
	int			GetItemIndex(int nBuyIdx, int nID);
};

////////////////////////////////////////////
// Owner-Definition Classes & Structs
////////////////////////////////////////////

#pragma pack(1)
struct GlobalTongInfo
{
	DWORD dwTongID;
	char szTongName[16];
	BOOL bIsRestricted;
	int WorkShopLevel[7];
};

struct TongInfo
{
	short nTongLevel;
	short nDesignLevel;
	char szTongName[10];
};

struct TongList
{
	BYTE ListData[9];
	BYTE nTongCount;
	TongInfo cTongInfo[MAX_TOP_TONG];
};
#pragma pack()

////////////////////////////////////////////
// Global Functions & Variables
////////////////////////////////////////////
extern DWORD			dwObjBaseAdd;
extern DWORD			dwItmBaseAdd;

extern KPlayer*			g_pCurPlayer;
extern KNpc*			g_pNpcArray[MAX_NPC];
extern KObj*			g_pObjArray[MAX_OBJ];
extern KItem*			g_pItemArray[MAX_ITM];

extern KTeam*			g_pTeam;
extern KCoreShell*		g_pCoreShell;
extern KBuySell*		g_pBuySell;
extern GlobalTongInfo*	g_GlobalTongInfo;
extern int*				g_pMapID;
extern char*			g_szMapName;

extern BOOL(*ExecuteScript)(const char*);
extern void(*SendClientCmdSkill)(int, int, int);

unsigned int			HashString2ID(char* szFileName);
void					PostChatMessage(const char *szChatMsg, int channel = 0);
int						__distance(int X1, int Y1, int X2, int Y2);
int						__distance(POINT p1, POINT p2);
int						__getheight(POINT p1, POINT p2, POINT p3);
