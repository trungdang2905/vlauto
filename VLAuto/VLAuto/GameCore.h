#pragma once

#define VLTK_WINCLASS _T("Sword3 Class")
#define VLTK_ERROR "<GAME "
#define VLTK_UNNAMED "<GAME ch­a kÕt nèi>"
#define VLTK_WRONGVER "<GAME sai phiªn b¶n>"

#define MAX_NPC				256
#define MAX_ITEM			512

//Game Data
#define _AUTOXP
#ifdef _AUTOXP
	#define ACNT_ID_ADD			0x0068D120	// AccountID
	#define MAP_ID_ADD			0x012FA5C0	// Game Map ID
	#define CORE_BASE_ADD		0x006DE314	// KCoreShell (pointer)
	#define NPC_BASE_ADD		0x012C5540	// KNpc (pointer)
	#define PLR_BASE_ADD		0x008E48F4	// KPlayer (pointer)
#else
	#define ACNT_ID_ADD			theGameData.AccountID
	#define MAP_ID_ADD			theGameData.MapAddress
	#define NPC_BASE_ADD		theGameData.NpcBaseAdd
	#define PLR_BASE_ADD		theGameData.PlrBaseAdd
	#define CORE_BASE_ADD		theGameData.KCoreShell
#endif

#define PLAYER_OFFSET	0x8B30
#define PLR_IDX_OFFSET	0x0114
#define PLR_EXP_OFFSET	0x58D8

#define FLAG_X_OFFST	0x0067E608	// MiniMap X Offset
#define FLAG_Y_OFFST	0x0067E60C	// MiniMap Y Offset
#define SERVERIP_ADD	0x07946BB0	// Server IP Address
#define SKL_BASE_ADD	0x008E4D10	// KSkill (static)
#define ITM_BASE_ADD	0x01341190	// KItem (pointer)

#define NPC_DATA_SIZE	0x000113B8
#define ITM_DATA_SIZE	0x057C
#define SKL_DATA_SIZE	0x04F8

#define REGION_WIDTH	512
#define REGION_HEIGHT	1024
#define CELL_WIDTH		32
#define CELL_HEIGHT		32

class KSkill
{
public:
	int m_nIndex;
	int m_nSkillType;
	int m_nMaxLevel;
	char m_szSkillName[32];
	DWORD m_dwSkillID;
	int SkillData[3];
	BOOL m_bIsPhysics;
};

#define	MAX_NPCSKILL	80
struct NpcSkill
{
	int		SkillId;
	int		SkillLevel;
	int		Reserverds[10];
};

class KItem
{
public:
	LPDWORD	__vfptr;
	int		nItemGenre;
	int		nSpecialType;
	int		nDetailType;
	int		nParticularType;
	int		nObjIdx;
	BOOL	bStack;
	int		nWidth;
	int		nHeight;
	int		nPrice;
	int		nLevel;
	int		nSeries;
	char	szItemName[80];
};

class KNpc
{
public:
	DWORD			m_dwID;
	int				m_Index;
	int				m_Node[6];
	int				m_Level;
	DWORD			m_NpcKind;
	int				m_Series;
	BYTE			NpcData1[0x00C0];
	int				m_Doing;
	BYTE			NpcData3[0x0058];
	NpcSkill		m_Skills[MAX_NPCSKILL];
	int				m_CurLife;
	int				m_LifeRep[3];
	int				m_CurMana;
	int				m_ManaRep[3];
	BYTE			NpcData4[0x0240];
	int				m_MapX, m_MapY;
	int				m_MapZ;
	int				m_OffX, m_OffY;
	BYTE			NpcData7[0x0050];
	char			Name0;
	char			Name[39];
	BYTE			NpcData8[0x0068];
	int				m_nPeopleIdx;
	int				m_nLastDam[3];
	int				m_nObjectIdx;
	BYTE			NpcData9[0x01B4];
	BOOL			m_FightMode;
	BYTE			NpcDataA[0x001C];
	WORD			m_RegX, m_RegY;
	BYTE			NpcDataB[0xFD78];
	int				m_CurLifeMax;
	int				m_CurStaminaMax;
	int				m_CurManaMax;

public:
	void GetMapPos(int* nX, int* nY)
	{
		*nX = m_RegX*REGION_WIDTH + m_MapX*CELL_WIDTH + (m_OffX >> 10);
		*nY = m_RegY*REGION_HEIGHT + m_MapY*CELL_HEIGHT + (m_OffY >> 10);
	}
};
