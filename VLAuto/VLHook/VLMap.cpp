#include "stdafx.h"
#include "../GameDef.h"
#include "DTextFile.h"
#include "GameBase.h"
#include "JxCore.h"
#include "S3Client.h"
#include "VLClasses.h"

#define MAX_TIME_WAIT 12

//================================Class CVLMap================================
CVLMap::CVLMap(void)
{
	memset(m_ShopItem, 0, sizeof(m_ShopItem));
	for (int i = 0; i < MAX_SHOP_ITEMS; i++)
		m_ShopItem[i].nShopIdx = -1;

	strcpy(m_ShopItem[0].szItemName, "Kim S¸ng D­îc (tiÓu)");
	strcpy(m_ShopItem[1].szItemName, "Kim S¸ng D­îc (trung)");
	strcpy(m_ShopItem[2].szItemName, "Kim S¸ng D­îc (®¹i)");
	strcpy(m_ShopItem[3].szItemName, "Håi Thiªn ®an");
	strcpy(m_ShopItem[4].szItemName, "Ng­ng ThÇn ®an (tiÓu)");
	m_ShopItem[4].nItemType = medicine_mana;
	strcpy(m_ShopItem[5].szItemName, "Ng­ng ThÇn ®an (trung)");
	m_ShopItem[5].nItemType = medicine_mana;
	strcpy(m_ShopItem[6].szItemName, "Ng­ng ThÇn ®an (®¹i)");
	m_ShopItem[6].nItemType = medicine_mana;
	strcpy(m_ShopItem[7].szItemName, "§¹i Bæ t¸n");
	m_ShopItem[7].nItemType = medicine_mana;
	strcpy(m_ShopItem[8].szItemName, "Thõa Tiªn MËt (tiÓu)");
	m_ShopItem[8].nItemType = medicine_both;
	strcpy(m_ShopItem[9].szItemName, "Thõa Tiªn MËt (trung)");
	m_ShopItem[9].nItemType = medicine_both;
	strcpy(m_ShopItem[10].szItemName, "Tam Hoa T¸n");
	m_ShopItem[10].nItemType = medicine_stamina;
	strcpy(m_ShopItem[11].szItemName, "Ho¾c H­¬ng ChÝnh khÝ hoµn");
	m_ShopItem[11].nItemType = medicine_antipoison;
	strcpy(m_ShopItem[12].szItemName, "Tam ThuËn t¸n");
	m_ShopItem[12].nItemType = medicine_antipoison;
	strcpy(m_ShopItem[13].szItemName, "Ng©n KiÒu Khø ®éc ®an");
	m_ShopItem[13].nItemType = medicine_antipoison;
	strcpy(m_ShopItem[14].szItemName, "Cöu ChuyÓn Hoµn Hån ®an");
	strcpy(m_ShopItem[15].szItemName, "¤ ®Çu Hoµn thÇn ®an");
	m_ShopItem[15].nItemType = medicine_mana;
	strcpy(m_ShopItem[16].szItemName, "Ngò Hoa Ngäc Lé Hoµn");
	m_ShopItem[16].nItemType = medicine_both;
	strcpy(m_ShopItem[17].szItemName, "Long §µm Hãa §éc ®an");
	m_ShopItem[17].nItemType = medicine_antipoison;

	m_nLastMapID = 0;
	memset(m_szLastMapName, 0, 32);
	m_nSaveMapID = 0;
	m_nPoints = 0;
	m_nCurPoint = -1;
	m_bRoomLocked = 0;
	m_bNoDriverRecent = 0;
	m_bFirstSaveRepos = TRUE;
	m_nLastdZ = MAX_INTNUM;
	m_nLagCount = 0;
	m_nBigLagCount = 0;
	m_bEnableGiveKCL = TRUE;
}

void CVLMap::InitEquipCheck()
{
	// Check Equipments
	m_bNeedRepairItems = 0;

	if (m_bRepair)
	{
		for (int i = 0; i < itempart_num; i++)
		{
			int nItemIdx = g_pCurPlayer->m_ItemList.m_EquipItem[i].m_nIndex;
			if (!nItemIdx) continue;

			KItem* pItem = g_pItemArray[nItemIdx];

			if (pItem->m_nCurDur < 0) continue; // Durability not available
			if (pItem->m_nItemPlus > 5) continue; // Cannot repair this item
			if (pItem->m_nCurDur < pItem->m_nMaxDur)
			{
				m_bNeedRepairItems = TRUE;
				break;
			}
		}
	}

	// Check Amulet
	m_bNeedGroceries = m_bBuyTDP && g_pCurPlayer->GetItemsCount(AMULET_PAPER) < 1 && NpcPoints[npc_Groceries].x;

	// Check Medicines
	int nItemPos;
	int nItemCount;
	m_bNeedPharmacy = 0;
	if (!NpcPoints[npc_Pharmacy].x) return;
	if (m_TradeItem[0].bBuyCheck)
	{
		nItemPos = m_TradeItem[0].nItemPos;
		nItemCount = g_pCurPlayer->GetItemsCount(item_medicine, m_ShopItem[nItemPos].nItemType);
		if (m_TradeItem[0].nBuyAmout > nItemCount)
		{
			m_bNeedPharmacy = TRUE;
			return;
		}
	}
	if (m_TradeItem[1].bBuyCheck)
	{
		nItemPos = m_TradeItem[1].nItemPos;
		nItemCount = g_pCurPlayer->GetItemsCount(item_medicine, m_ShopItem[nItemPos].nItemType);
		if (m_TradeItem[1].nBuyAmout > nItemCount)
		{
			m_bNeedPharmacy = TRUE;
			return;
		}
	}
	if (m_TradeItem[2].bBuyCheck)
	{
		nItemPos = m_TradeItem[2].nItemPos;
		nItemCount = g_pCurPlayer->GetItemsCount(item_medicine, m_ShopItem[nItemPos].nItemType);
		if (m_TradeItem[2].nBuyAmout > nItemCount)
		{
			m_bNeedPharmacy = TRUE;
			return;
		}
	}
}

void CVLMap::InitValues()
{
	m_nTimeWait = 2;
	m_bFinished = 0;
	m_nDriverStep = 0;
	m_nCurPoint = -1;
	m_bDoShoping = 0;
	m_nEntrustStatus = 0;
	m_nBigLagCount = 0;
	theMove.m_bFindingWay = TRUE;
	m_bNeedMoney = m_bWithDraw && (m_bAutoReturn || theQuest.m_bAutoDoQuest);
	m_bNeedSellItems = m_bSellItems;
	m_bNeedUseLB = g_pCurPlayer->m_cTong.m_dwTongNameID && theQuest.m_bAutoDoQuest && (theQuest.m_nTongKill == act_auto);
	m_bNeedSaveItems = (m_nSaveItemMode > 0);

	InitEquipCheck();

	if (!m_bNeedGroceries && !m_bNeedPharmacy)
		m_bNeedPharmacy = m_bNeedRepairItems;

	if (P_PLAYER->m_nPKFlag)
		ExecuteScript("Switch('PK',0)");

	m_bNeedFuYuan = m_bGetReputation && NpcPoints[npc_Reputation].x;
	m_bNeedMingWang = m_bNeedFuYuan;
	m_bNeedGiveKCL = g_pCurPlayer->m_cTong.m_dwTongNameID && m_bGiveKCL && m_bEnableGiveKCL;
	m_bIsReady = 0;
	m_bNeedDriver = m_bGetDriver || theQuest.m_bNeedGoTrain;
	m_nSaveMapID = theMain.GetReturnCity(m_nTrainMapID);
	NearestDriver();
}

void CVLMap::Breathe()
{
	static BOOL bInFightMode = 0;
	static int nWaitTime = 0;
	if (g_NetworkOffline) return;

	if (P_PLAYER->m_FightMode)
	{
		m_bEnableGiveKCL = TRUE;
		m_nLastMapID = 0;
		if (!bInFightMode) //return from City
		{
			KUiMsgSel* pMsgSel = (KUiMsgSel*)GetPtrAddress(MSG_BASE_ADD);
			if (pMsgSel && pMsgSel->IsVisible()) //Xa phu
				pMsgSel->OnClickMsg(pMsgSel->m_nNumMessage);
			bInFightMode = TRUE;
		}
		return;
	}

	if (bInFightMode) //return from Front
	{
		theAttack.SetPeopleIdx(0);
		if (nWaitTime++ < 5) return; //wait for 3s
		if (PLAY_HAND_IDX)
		{
			POINT itmPos;
			KItem* pItem = (KItem*)(dwItmBaseAdd + PLAY_HAND_IDX * ITM_DATA_SIZE);
			if (EQUIP_ROOM.FindRoom(ComAttr.nWidth, ComAttr.nHeight, &itmPos))
			{
				g_pCurPlayer->SwitchItem(UOC_ITEM_TAKE_WITH, itmPos.x, itmPos.y);
				return;
			}
		}
		m_bNeedSellItems = m_bAutoReturn && m_bSellItems;
		if (m_bNeedSellItems)
		{
			if (SellItems()) return;
			m_bNeedSellItems = 0;
		}
		bInFightMode = 0;
		nWaitTime = 0;
		return;
	}

	if (theMain.m_bPause) return;

	if (((*g_pMapID) != m_nLastMapID) ||
		(strcmp(m_szLastMapName, g_szMapName)))
	{	//Map Changed
		m_nPoints = 0;
		LoadMap(*g_pMapID);
		m_nLastMapID = (*g_pMapID);
		strcpy(m_szLastMapName, g_szMapName);
		InitValues();
	}

	if (theMove.IsFlagMoving())
		return;

	if (m_nPoints <= 0) return;
	if (theUtil.m_bDoingUtil) return;

	if (m_bNeedMoney)
	{
		WithdrawMoney();
		return;
	}

	if (theQuest.m_bAutoDoQuest)
	{
		theQuest.Breath();
		if (!theQuest.m_bNeedGoTrain) return;
	}

	if (!m_bAutoReturn) return;

	if (g_pCurPlayer->m_nEntrustMode) return;

	if (m_bNeedGiveKCL)
	{
		int nKCLCount = g_pCurPlayer->GetItemsCount(KC_LENH);
		if (nKCLCount >= m_nMinKCL && nKCLCount > 0)
		{
			theUtil.m_bDoingUtil = TRUE;
			theUtil.m_nUtilTask = util_givekcl;
			SystemMessage("<color=yellow>§i giao nép Khiªu chiÕn lÖnh!!!");
		}
		m_bNeedGiveKCL = 0;
		return;
	}

	if (theQuest.m_bGoTrainGetPK)
	{
		m_bNeedSaveItems = 0;
		if ((*g_pMapID) >= city_banghoimin && (*g_pMapID) <= city_banghoimax)
		{	// Goto Phuong_Tuong
			if (ChangeMap(city_phuongtuong)) return;
		}
		else
		{
			// Go to main city
			int nOwnMapID = theMain.GetOwnerCity(*g_pMapID);
			if (ChangeMap(nOwnMapID)) return;
		}
	}
	else
	{
		// Go to main city
		int nOwnMapID = theMain.GetOwnerCity(*g_pMapID);
		if (ChangeMap(nOwnMapID)) return;

		if (m_bFirstSaveRepos)
		{
			FirstRepository();
			return;
		}
	}
	if (m_bNeedSellItems)
	{
		if (SellItems()) return;
		m_bNeedSellItems = 0;
	}
#ifndef VLTK_FREE_MODE
	if (m_bNeedUseLB && !theQuest.m_bIsFull100LB && !theQuest.m_bGoTrainGetPK)
	{
		int nTrainMapID = m_nTrainMapID;
		if (theQuest.m_nYeSouMapID)
			nTrainMapID = theQuest.m_nYeSouMapID;
		if (!theQuest.AutoUseLB(nTrainMapID)) return;
		m_bNeedUseLB = 0;
	}
#endif
	if (m_bNeedSaveItems)
	{
		if (!m_bDoShoping && RunningToPos(NpcPoints[npc_Repository])) return;
		m_bDoShoping = TRUE;
		GetSaveItems();
		return;
	}
	if (m_bNeedGroceries)
	{
		if (!m_bDoShoping && RunningToPos(NpcPoints[npc_Groceries])) return;
		m_bDoShoping = TRUE;
		GetGroceries();
		return;
	}
	if (m_bNeedPharmacy)
	{
		if (!m_bDoShoping && RunningToPos(NpcPoints[npc_Pharmacy])) return;
		m_bDoShoping = TRUE;
		GetPharmacy();
		return;
	}
	if (m_bNeedMingWang)
	{
		if (!m_bDoShoping && RunningToPos(NpcPoints[npc_Reputation])) return;
		m_bDoShoping = TRUE;
		GetReputation(1);
		return;
	}
#ifndef VLTK_FREE_MODE
	if (m_bNeedFuYuan)
	{
		GetReputation(0);
		return;
	}
#endif
	if (!m_bIsReady)
	{
		m_bIsReady = CheckReady();
		if (!m_bIsReady) return;
		if (m_bRoomLocked) theMain.CloseLockRoom();
		NearestDriver();
	}

	if (m_bNeedDriver)
	{
		if (m_nDriverOption == 5 && !theQuest.m_nYeSouMapID)
		{
			UseThanHanhPhu();
			return;
		}

		if (!m_bDoShoping && RunningToPos(NpcPoints[m_nDriverIndex])) return;
		m_bDoShoping = TRUE;
		GetDriver();
	}
}

void CVLMap::CheckAutoReturn()
{
	char szMsg[80];
	if (m_bAutoReturn)
		sprintf(szMsg, "<color=yellow>VÒ thµnh tù quay l¹i (Ctrl+G): <color=green>BËt");
	else
	{
		sprintf(szMsg, "<color=yellow>VÒ thµnh tù quay l¹i (Ctrl+G): <color>T¾t");
		m_nCurPoint = -1;
		m_bDoShoping = 0;
	}
	SystemMessage(szMsg, 1);
}

BOOL CVLMap::LoadMap(int nMapID)
{
	char szMapFile[MAX_PATH];
	sprintf(szMapFile, "%s\\Maps\\CityMaps\\City%d.map", theMain.m_szCurFolder, nMapID);
	FILE* pFile = fopen(szMapFile, "r");
	if (pFile == NULL) return 0;
	int nRet;
	//Read NPC Points
	int i = 0;
	while (TRUE)
	{
		nRet = fscanf(pFile, "%d,%d\n", &NpcPoints[i].x, &NpcPoints[i].y);
		if (nRet < 2) break;
		i++;
	}
	//Read Points
	i = 0;
	while (TRUE)
	{
		nRet = fscanf(pFile, "%d,%d\n", &MapPoints[i].x, &MapPoints[i].y);
		if (nRet < 2) break;
		i++;
	}
	m_nPoints = i;
	for (int i = 0; i < m_nPoints; i++)
		for (int j = 0; j < m_nPoints; j++)
			if (i == j) MapSides[i][j] = 0;
			else MapSides[i][j] = MAX_INTNUM;
	//Read Sides
	while (TRUE)
	{
		int si, sj;
		nRet = fscanf(pFile, "%d,%d\n", &si, &sj);
		if (nRet < 2) break;
		MapSides[si][sj] = MapSides[sj][si] = __distance(MapPoints[si], MapPoints[sj]);
	}
	fclose(pFile);
	return TRUE;
}

BOOL CVLMap::Dijkstra(int nStart, int nEnd)
{
	int Dist[MAX_POINTS];
	BOOL Free[MAX_POINTS];
	BOOL bStop = 0;
	int i, u, v, min;
	if (nEnd < 0 || nStart < 0) return 0;
	for (i = 0; i < m_nPoints; i++)
	{
		Dist[i] = MapSides[nStart][i];
		TraceRoute[i] = nStart;
	}
	memset(Free, TRUE, sizeof(Free));
	do {
		u = -1; min = MAX_INTNUM;
		for (i = 0; i < m_nPoints; i++)
			if (Free[i] && Dist[i] < min)
			{
				min = Dist[i];
				u = i;
			}
		if (u == -1 || u == nEnd) bStop = TRUE;
		if (!bStop)
		{
			Free[u] = FALSE;
			for (v = 0; v < m_nPoints; v++)
				if (Free[v] && Dist[v] > (Dist[u] + MapSides[u][v]))
				{
					Dist[v] = Dist[u] + MapSides[u][v];
					TraceRoute[v] = u;
				}
		}

	} while (!bStop);

	return (Dist[nEnd] < MAX_INTNUM);
}

BOOL CVLMap::RunningToPos(POINT ptDest)
{
	int nPlayerX, nPlayerY;
	int dZ, dMin;
	static int nStart = -1;
	static int nEnd = -1;

	if (m_nPoints <= 0) return 0;

	P_PLAYER->GetMapPos(&nPlayerX, &nPlayerY);
	POINT ptPlayer = { nPlayerX, nPlayerY };

	if (m_nCurPoint < 0)
	{
		//Finding Start Point (near Destination)
		dMin = MAX_INTNUM;
		for (int i = 0; i < m_nPoints; i++)
		{
			dZ = __distance(MapPoints[i], ptDest);
			if (dZ < dMin)
			{
				dMin = dZ;
				nStart = i;
			}
		}
		//Finding End Point (near Player)
		dMin = MAX_INTNUM;
		for (int j = 0; j < m_nPoints; j++)
		{
			dZ = __distance(MapPoints[j], ptPlayer);
			if (dZ < dMin)
			{
				dMin = dZ;
				nEnd = j;
			}
		}
		if (!Dijkstra(nStart, nEnd)) return 0;
		m_nCurPoint = nEnd;
	}

	//Tracing the Path
	if (m_nCurPoint >= 0)
	{
		dZ = __distance(MapPoints[m_nCurPoint], ptPlayer);
		if (dZ <= 100)
		{
			m_nLagCount = 0;
			if (m_nCurPoint != nStart)
			{
				m_nCurPoint = TraceRoute[m_nCurPoint];
				if (!P_PLAYER->m_bRideHorse && HAVE_HORSE)
					ExecuteScript(SCK_SHORTCUT_HORSE); // Len ngua
			}
			else
			{
				m_nCurPoint = -1;
				return 0;
			}
		}
		if (IsLagMoving(nPlayerX, nPlayerY, dZ)) return TRUE;
		g_pCurPlayer->MoveTo(MapPoints[m_nCurPoint].x, MapPoints[m_nCurPoint].y);
		return TRUE;
	}

	return 0;
}

BOOL CVLMap::IsLagMoving(int nPlayerX, int nPlayerY, int dZ)
{
	if (dZ > m_nLastdZ - 96)
		m_nLagCount++;
	m_nLastdZ = dZ;
	if (m_nLagCount > 7)
	{
		m_nBigLagCount++;
		if (m_nBigLagCount > 3)
		{
			g_pCurPlayer->EnterTongMap();
			m_nBigLagCount = 0;
			return TRUE;
		}
		unsigned int number;
		rand_s(&number);
		int nDestX = nPlayerX + (int)(((double)number / (double)UINT_MAX * 512) - 256);
		rand_s(&number);
		int nDestY = nPlayerY + (int)(((double)number / (double)UINT_MAX * 1024) - 512);
		m_nLagCount = 0;
		m_nCurPoint = -1;
		SystemMessage("<color=yellow>KÑt ®­êng råi, ch¹y h­íng kh¸c xem sao.");
		g_pCurPlayer->MoveTo(nDestX, nDestY);
		return TRUE;
	}
	return 0;
}

void CVLMap::NearestDriver()
{
	// Find the nearest driver
	int nPlayerX, nPlayerY, dZ;
	int dMin = MAX_INTNUM;
	if (m_nPoints <= 0) return;
	P_PLAYER->GetMapPos(&nPlayerX, &nPlayerY);
	for (int i = npc_Driver1; i <= npc_Driver4; i++)
	{
		dZ = __distance(nPlayerX, nPlayerY, NpcPoints[i].x, NpcPoints[i].y);
		if (dZ < dMin)
		{
			dMin = dZ;
			m_nDriverIndex = i;
		}
	}
}

void CVLMap::WithdrawMoney()
{
	if (theMain.OpenLockRoom(m_nRepositoryPass))
	{
		m_bRoomLocked = TRUE;
		return;
	}
	int nWithdrawAmount = m_nGetMoneyAmount * 10000 - EQUIP_MONEY;
	if (nWithdrawAmount > ROOM_MONEY)
	{
		SystemMessage("<color=yellow>TiÒn trong r­¬ng kh«ng ®ñ!!!");
		nWithdrawAmount = ROOM_MONEY;
	}
	if (nWithdrawAmount > 0)
		g_pCoreShell->OperationRequest(GOI_MONEY_INOUT_STORE_BOX, 0, nWithdrawAmount);
	m_bNeedMoney = 0;
}

BOOL CVLMap::ChangeMap(int nNewMapID)
{
	char szCityName[40] = "";
	if ((*g_pMapID) == nNewMapID) return 0;

	int nOwnerID = theMain.GetOwnerCity(*g_pMapID);
	if (nOwnerID == (*g_pMapID))
		theMain.GetCityName(nNewMapID, szCityName);
	else
		theMain.GetCityName(nOwnerID, szCityName);

	if (!m_bDoShoping && RunningToPos(NpcPoints[m_nDriverIndex])) return TRUE;
	m_bDoShoping = TRUE;

	int nCount = theMain.GetMenuCount();

	if (nCount > 0)
	{
		if (theMain.ClickMenuStr("Nh÷ng thµnh thÞ ®· ®i qua"))
			m_nTimeWait = 2;
		else if (theMain.ClickMenuStr("l­îng", 0)) // City Selection
		{
			theMain.ClickMenuStr(szCityName);
			m_nTimeWait = 5;
		}
		return TRUE;
	}

	ClickToNpc(NpcPoints[m_nDriverIndex].x, NpcPoints[m_nDriverIndex].y);

	return TRUE;
}

int CVLMap::OpenStoreBox()
{
	KWndImage* pKUiStoreBox = (KWndImage*)(*(LPDWORD)SBO_BASE_ADD);
	if (pKUiStoreBox && pKUiStoreBox->IsVisible())
	{
		if (m_nTimeWait > 5) m_nTimeWait = 2;
		return 1;
	}

	BOOL bFound = FALSE;
	int nPlayerX, nPlayerY, dZ;
	int nObjX, nObjY, nNpcX, nNpcY;

	if (m_nTimeWait)
	{
		if (m_nTimeWait == 5)
		{
			int nX = (P_PLAYER->m_SyncSignal & 0x07) << 3;
			char szScript[32];
			sprintf(szScript, "MoveTo(%d, 0)", nX);
			ExecuteScript(szScript);
			SystemMessage("<color=yellow>Lag qu¸, chê 5s click l¹i...");
		}
		m_nTimeWait--;
		return 0;
	}

	P_PLAYER->GetMapPos(&nPlayerX, &nPlayerY);
	if ((*g_pMapID) >= city_visondao)
	{
		for (int i = 1; i < MAX_NPC; i++)
		{
			if (!g_pNpcArray[i]->IsExist() || g_pNpcArray[i]->m_Kind != kind_dialoger) continue;
			if (strcmp(g_pNpcArray[i]->Name, "R­¬ng chøa ®å")) continue;
			g_pNpcArray[i]->GetMapPos(&nNpcX, &nNpcY);
			dZ = __distance(nPlayerX, nPlayerY, nNpcX, nNpcY);
			if (dZ > MAX_MOVE_DISTANCE)
				g_pCurPlayer->MoveTo(nNpcX, nNpcY);
			else
			{
				theAttack.SetPeopleIdx(i);
				m_nTimeWait = MAX_TIME_WAIT;
			}
			bFound = TRUE;
			break;
		}
	}
	else
	{
		for (int i = 1; i < MAX_OBJ; i++)
		{
			if (g_pObjArray[i]->m_nID == -1) continue;
			if (g_pObjArray[i]->m_Kind != Obj_Kind_StoreBox) continue;
			g_pObjArray[i]->GetMapPos(&nObjX, &nObjY);
			dZ = __distance(nPlayerX, nPlayerY, nObjX, nObjY);
			if (dZ > PLAYER_PICKUP_DISTANCE)
				g_pCurPlayer->MoveTo(nObjX, nObjY);
			else
			{
				P_PLAYER->m_nObjectIdx = i;
				m_nTimeWait = MAX_TIME_WAIT;
			}
			bFound = TRUE;
			break;
		}
	}
	if (!bFound)
		return -1;
	return 0;
}

void CVLMap::SaveNewRepository()
{
	if (P_PLAYER->m_FightMode)
		return;
	if ((*g_pMapID) == city_visondao)
	{
		SystemMessage("<color=yellow>Kh«ng l­u R­¬ng trªn Vi S¬n §¶o!!!");
		return;
	}
	if (m_nPoints <= 0)
	{
		SystemMessage("<color=yellow>Lçi ®äc file MAP thµnh thÞ!!!");
		return;
	}
	int nPlayerX, nPlayerY, nObjX, nObjY, dZ;
	int nRepX = 0, nRepY = 0;
	P_PLAYER->GetMapPos(&nPlayerX, &nPlayerY);
	for (int i = 1; i < MAX_OBJ; i++)
	{
		if (g_pObjArray[i]->m_nID == -1) continue;
		if (g_pObjArray[i]->m_Kind != Obj_Kind_StoreBox) continue;
		g_pObjArray[i]->GetMapPos(&nObjX, &nObjY);
		dZ = __distance(nPlayerX, nPlayerY, nObjX, nObjY);
		if (dZ > PLAYER_PICKUP_DISTANCE)
			g_pCurPlayer->MoveTo(nObjX, nObjY);
		else
			P_PLAYER->m_nObjectIdx = i;
		nRepX = nObjX;
		nRepY = nObjY;
		break;
	}
	if (nRepX && nRepY)
	{
		char szMapFile[MAX_PATH];
		sprintf(szMapFile, "%s\\Maps\\CityMaps\\City%d.map", theMain.m_szCurFolder, (*g_pMapID));
		FILE* pFile = fopen(szMapFile, "w");
		if (pFile == NULL)
		{
			SystemMessage("<color=yellow>Lçi ghi file MAP, xin kiÓm tra l¹i!!!");
			return;
		}
		//Write NPC Points
		NpcPoints[npc_Repository].x = nRepX;
		NpcPoints[npc_Repository].y = nRepY;
		for (int i = 0; i < npc_Nums; i++)
			fprintf(pFile, "%d,%d\n", NpcPoints[i].x, NpcPoints[i].y);
		fprintf(pFile, "0\n");
		//Write Points
		for (int i = 0; i < m_nPoints; i++)
			fprintf(pFile, "%d,%d\n", MapPoints[i].x, MapPoints[i].y);
		fprintf(pFile, "0\n");
		//Write Sides
		for (int i = 0; i < m_nPoints; i++)
			for (int j = i + 1; j < m_nPoints; j++)
				if (MapSides[i][j] < MAX_INTNUM)
					fprintf(pFile, "%d,%d\n", i, j);
		SystemMessage("<color=yellow>§· l­u thµnh c«ng täa ®é R­¬ng ®å míi!");
		m_nCurPoint = -1;
		m_bDoShoping = 0;
		fclose(pFile);
		return;
	}
	SystemMessage("<color=yellow>Kh«ng t×m thÊy R­¬ng ®å!!!");
}

void CVLMap::FirstRepository()
{
	int nSaveMap = m_nSaveMapID;
	if (theQuest.m_nYeSouMapID)
		nSaveMap = theQuest.m_nSaveMapID;
	if (!nSaveMap)
	{
		m_bFirstSaveRepos = 0;
		return;
	}
	if (ChangeMap(nSaveMap)) return;
	if (!m_bDoShoping && RunningToPos(NpcPoints[npc_Repository])) return;
	m_bDoShoping = TRUE;

	if (OpenStoreBox() <= 0)
		return;

	SystemMessage("<color=yellow>§· nhí r­¬ng vÒ thµnh!!!");
	ResetShoping();
	m_bFirstSaveRepos = 0;
}

void CVLMap::GetSaveItems()
{
	if (theMain.OpenLockRoom(m_nRepositoryPass))
	{
		m_bRoomLocked = TRUE;
		return;
	}
	//Running to Repository
	int nOpeningStore = OpenStoreBox();
	if (nOpeningStore <= 0)
	{
		if (nOpeningStore < 0)
		{
			SystemMessage("<color=yellow>Kh«ng thÊy R­¬ng ®å, lÇn sau göi vËy.");
			m_bNeedSaveItems = 0;
			m_bDoShoping = 0;
		}
		return;
	}

	if (SaveItems()) return;

	SystemMessage("<color=yellow>CÊt ®å vµo r­¬ng hoµn tÊt!!!");
	ResetShoping();
	m_bNeedSaveItems = 0;
}

void CVLMap::GetRepairItems()
{
	int nItemIdx;
	KItem* pItem;
	static int nLastRpEquip = -1;
	for (int i = nLastRpEquip + 1; i < itempart_num; i++)
	{
		nItemIdx = g_pCurPlayer->m_ItemList.m_EquipItem[i].m_nIndex;
		if (!nItemIdx) continue;
		pItem = (KItem*)(dwItmBaseAdd + nItemIdx * ITM_DATA_SIZE);
		if (pItem->m_nCurDur < 0) continue; // Durability not available
		if (pItem->m_nItemPlus > 5) continue; // Cannot repair this item
		if (pItem->m_nCurDur < pItem->m_nMaxDur)
		{	//Sua do
			SystemMessage(0, "Söa ®å: <color=yellow>%s", ComAttr.szItemName);
			g_pCurPlayer->RepairItem(nItemIdx);
			nLastRpEquip = i;
			return;
		}
	}
	nLastRpEquip = -1;
	m_bNeedRepairItems = 0;
}

void CVLMap::GetGroceries()
{
	KUiMsgSel* pMsgSel = (KUiMsgSel*)GetPtrAddress(MSG_BASE_ADD);
	KUiShop* pShop = (KUiShop*)GetPtrAddress(SHOP_BASE_ADD);

	if (g_UiInformation2->IsVisible())
	{
		g_UiInformation2->Hide();
		return;
	}
	if (pMsgSel && pMsgSel->IsVisible())
	{
		if (pShop)
		{
			if (strstr(pMsgSel->m_pMessages[1]->Msg, FULL_REPAIR))
			{
				pMsgSel->OnClickMsg(1); // Full Repair
				SystemMessage("<color=yellow>Söa kü ®å Hoµng Kim");
			}
			else
				pMsgSel->OnClickMsg(pMsgSel->m_nNumMessage);
			return;
		}
		for (int i = 0; i < pMsgSel->m_nNumMessage; i++)
		{
			char* szMsg = (char*)pMsgSel->m_pMessages[i]->Msg;
			if (strstr(szMsg, AGREE_TRADE))
			{
				pMsgSel->OnClickMsg(i);
				break;
			}
		}
		return;
	}
	if (m_bFinished)
	{
		ResetShoping();
		m_bFinished = 0;
		m_bNeedGroceries = 0;
		return;
	}
	if (pShop) //Do Shoping
	{
		//Repair Items
		if (m_bNeedRepairItems)
		{
			GetRepairItems();
			return;
		}
		//Full Room
		if (g_pCurPlayer->CheckRoom() == MAX_ROOM_SPACE)
		{
			m_bFinished = TRUE;
			return;
		}
		//Buy TDP
		if (m_bBuyTDP && (g_pCurPlayer->GetItemsCount(AMULET_PAPER) < m_nAMNumbers))
		{
			g_pCurPlayer->BuyItem(0);
			return;
		}
		m_bFinished = TRUE;
		return;
	}
	ClickToNpc(NpcPoints[npc_Groceries].x, NpcPoints[npc_Groceries].y);
}

void CVLMap::GetPharmacy()
{
	KUiMsgSel* pMsgSel = (KUiMsgSel*)GetPtrAddress(MSG_BASE_ADD);
	KUiShop* pShop = (KUiShop*)GetPtrAddress(SHOP_BASE_ADD);
	int nItemPos, nItemCount;
	static BOOL bShopLoaded = 0;

	if (g_UiInformation2->IsVisible())
	{
		g_UiInformation2->Hide();
		return;
	}
	if (pMsgSel && pMsgSel->IsVisible())
	{
		if (pShop)
		{
			if (strstr(pMsgSel->m_pMessages[1]->Msg, FULL_REPAIR))
			{
				pMsgSel->OnClickMsg(1); // Full Repair
				SystemMessage("<color=yellow>Söa kü ®å Hoµng Kim");
			}
			else
				pMsgSel->OnClickMsg(pMsgSel->m_nNumMessage);
			return;
		}
		bShopLoaded = 0;
		for (int i = 0; i < pMsgSel->m_nNumMessage; i++)
		{
			char* szMsg = (char*)pMsgSel->m_pMessages[i]->Msg;
			if (strstr(szMsg, AGREE_TRADE))
			{
				pMsgSel->OnClickMsg(i);
				break;
			}
		}
		return;
	}
	if (m_bFinished)
	{
		ResetShoping();
		bShopLoaded = 0;
		m_bFinished = 0;
		m_bNeedPharmacy = 0;
		return;
	}
	if (pShop) //Do Shoping
	{
		if (!bShopLoaded)
		{
			char szItemDesc[128];
			for (int i = 0; i < pShop->m_nObjCount; i++)
			{
				g_pCoreShell->GetGameData(GDI_TRADE_ITEM_PRICE, (int)& pShop->m_pObjectList[i], (int)szItemDesc);
				for (int j = 0; j < MAX_SHOP_ITEMS; j++)
				{
					if (strstr(szItemDesc, m_ShopItem[j].szItemName))
					{
						m_ShopItem[j].nShopIdx = pShop->m_pObjectList[i].uId;
						break;
					}
				}
			}
			bShopLoaded = TRUE;
			return;
		}
		//Repair Items
		if (m_bNeedRepairItems)
		{
			GetRepairItems();
			return;
		}
		//Full Room
		if (g_pCurPlayer->CheckRoom() == MAX_ROOM_SPACE)
		{
			m_bFinished = TRUE;
			return;
		}
		//Buy Anti-poison
		if (theRecover.m_bUsePoison && P_PLAYER->m_PoisonState.nTime)
		{
			if (!g_pCurPlayer->EatMedicine(medicine_antipoison))
			{
				if (m_ShopItem[13].nShopIdx >= 0)
					g_pCurPlayer->BuyItem(m_ShopItem[13].nShopIdx); // Ngan Kieu Khu Doc Dan
				else if (m_ShopItem[17].nShopIdx >= 0)
					g_pCurPlayer->BuyItem(m_ShopItem[17].nShopIdx); // Long Dam Hoa Doc Dan
			}
			return;
		}
		nItemPos = m_TradeItem[0].nItemPos;
		nItemCount = g_pCurPlayer->GetItemsCount(item_medicine, m_ShopItem[nItemPos].nItemType);
		if (m_TradeItem[0].nBuyAmout > nItemCount && m_TradeItem[0].bBuyCheck)
		{
			g_pCurPlayer->BuyItem(m_ShopItem[nItemPos].nShopIdx);
			return;
		}
		nItemPos = m_TradeItem[1].nItemPos;
		nItemCount = g_pCurPlayer->GetItemsCount(item_medicine, m_ShopItem[nItemPos].nItemType);
		if (m_TradeItem[1].nBuyAmout > nItemCount && m_TradeItem[1].bBuyCheck)
		{
			g_pCurPlayer->BuyItem(m_ShopItem[nItemPos].nShopIdx);
			return;
		}
		nItemPos = m_TradeItem[2].nItemPos;
		nItemCount = g_pCurPlayer->GetItemsCount(item_medicine, m_ShopItem[nItemPos].nItemType);
		if (m_TradeItem[2].nBuyAmout > nItemCount && m_TradeItem[2].bBuyCheck)
		{
			g_pCurPlayer->BuyItem(m_ShopItem[nItemPos].nShopIdx);
			return;
		}
		m_bFinished = TRUE;
		return;
	}
	ClickToNpc(NpcPoints[npc_Pharmacy].x, NpcPoints[npc_Pharmacy].y);
}

BOOL CVLMap::GetReputation(int nRepType)
{
	KUiMsgSel* pMsgSel = (KUiMsgSel*)GetPtrAddress(MSG_BASE_ADD);
	KUiMsgSel2* pMsgSel2 = (KUiMsgSel2*)GetPtrAddress(MSG2_BASE_ADD);

	if (g_UiInformation2->IsVisible())
	{
		g_UiInformation2->Hide();
		m_bFinished = TRUE;
		m_nTimeWait = 2;
		return TRUE;
	}
	if (pMsgSel && pMsgSel->IsVisible() && pMsgSel->m_nNumMessage == 1)
	{
		pMsgSel->OnClickMsg(0);
		m_bFinished = TRUE;
		m_nTimeWait = 2;
		return TRUE;
	}
	if (pMsgSel2 && pMsgSel2->IsVisible())
	{
		char szMenuChoice[32] = "_Undefined_";
		if (nRepType == 0)
			strcpy(szMenuChoice, "NhËn ®iÓm phóc duyªn");
		else
			strcpy(szMenuChoice, "NhËn ®iÓm danh väng");
		for (int i = 0; i < pMsgSel2->m_nNumMessage; i++)
		{
			char* szMsg = (char*)pMsgSel2->m_pMessages[i]->Msg;
			if (strstr(szMsg, szMenuChoice))
				pMsgSel2->OnClickMsg(i);
		}
		return TRUE;
	}
	if (m_bFinished)
	{
		m_bFinished = 0;
		if (nRepType == 0)
			m_bNeedFuYuan = 0;
		else
			m_bNeedMingWang = 0;
		ResetShoping();
		return 0;
	}

	ClickToNpc(NpcPoints[npc_Reputation].x, NpcPoints[npc_Reputation].y);
	return TRUE;
}

void CVLMap::GetDriver()
{
	int nDriverOpt = m_nDriverOption;
	if (theQuest.m_nYeSouMapID) nDriverOpt = 4;

	if (theQuest.m_bAutoDoQuest && theQuest.m_bGoTrainGetPK)
	{
		m_nDriverStep = 1;
		nDriverOpt = theQuest.m_TongPKOpt.m_nDriverOpt + 10;
	}

	int nCount = theMain.GetMenuCount();

	if (nCount > 0)
	{
		if (m_bNoDriverRecent) m_nDriverStep = 1;
		if (m_nDriverStep == 0)	// Return the recent place
		{
			theMove.m_bFindingWay = 0;
			theMain.ClickMenuStr("Trë l¹i ®Þa ®iÓm cò");
			m_nDriverStep = 1;
			m_nTimeWait = 5;
		}
		else if (m_nDriverStep == 1)
		{
			m_bNoDriverRecent = 0;
			theMove.m_bFindingWay = TRUE;
			if (theMain.ClickMenuStr(VISITED_PLACES, 0))
			{
				if (nDriverOpt == 3)
					theMain.ExitGame();
				else if (nDriverOpt == 4)
				{
					if (theMain.ClickMenuStr("§i ®Õn n¬i lµm nhiÖm vô D· TÈu"))
						return;

					SystemMessage("<color=yellow>Ch­a nhËn nhiÖm vô D· TÈu!!!");
					theMain.ClickMenuStr(VISITED_PLACES);
				}
				else if (nDriverOpt == 6)
				{
					if (theMain.ClickMenuStr("§i §Õn B¶n §å MËt Cèc"))
						return;

					SystemMessage("<color=yellow>B¶n §å MËt Cèc ch­­a khai më!!!");
					theMain.ClickMenuStr(VISITED_PLACES);
				}
				else
					theMain.ClickMenuStr(VISITED_PLACES);
			}
			else
			{
				if (theMain.ClickMenuStr("X¸c nhËn luyÖn tËp c¸ nh©n"))
					return;
				if (theMain.ClickMenuStr("§óng vËy! Mau ®­a ta ®i!"))
					return;
				if (m_nTrainMapID && nDriverOpt < 10)
				{
					char szMapName[40];
					if (m_nTrainMapID >= 224 && m_nTrainMapID <= 227)
						strcpy(szMapName, "Sa M¹c Mª Cung");
					else
						theMain.GetMapName(m_nTrainMapID, szMapName);

					theMain.ClickMenuStr(szMapName);
				}

				if (nDriverOpt == 4)	// Nhiem vu DT ko xac dinh.
					nDriverOpt = 2;
				if (nDriverOpt == 10)	// Nhiem vu PK ko xac dinh.
					nDriverOpt = 2;
				else if (nDriverOpt > 10)
					nDriverOpt -= 11;

				theMain.ClickMenuIdx(nDriverOpt);
			}
		}
		else if (m_nDriverStep == 2)
		{
		}

		return;
	}

	ClickToNpc(NpcPoints[m_nDriverIndex].x, NpcPoints[m_nDriverIndex].y);
}

void CVLMap::UseThanHanhPhu()
{
	if (theMain.ClickMenuStr("Sö dông thuËt thÇn hµnh cã thÓ"))
	{
		SystemMessage("<color=yellow>Sö dông thuËt thÇn hµnh cã thÓ");
		return;
	}

	if (m_nTrainMapID < 920 && theMain.ClickMenuStr("B¶n ®å cÊp 90"))
		return;

	if (m_nTrainMapID >= 920 && theMain.ClickMenuStr("B¶n ®å luyÖn c«ng míi"))
		return;

	BOOL bClicked = FALSE;

	char szMapName[40];
	theMain.GetMapName(m_nTrainMapID, szMapName);
	auto uLen = strlen(szMapName);
	if (uLen > 3)
		szMapName[uLen - 2] = 0;

	switch (m_nTrainMapID)
	{
	case 225:
		bClicked = theMain.ClickMenuStr("Sa M¹c Mª Cung 1");
		break;
	case 226:
		bClicked = theMain.ClickMenuStr("Sa M¹c Mª Cung 2");
		break;
	case 227:
		bClicked = theMain.ClickMenuStr("Sa M¹c Mª Cung 3");
		break;
	case 321:
		bClicked = theMain.ClickMenuStr("Tr­êng B¹ch S¬n Nam");
		break;
	case 322:
		bClicked = theMain.ClickMenuStr("Tr­êng B¹ch S¬n B¾c");
		break;
	default:
		bClicked = theMain.ClickMenuStr(szMapName);
		break;
	}

	if (bClicked)
		return;

	if (m_nTrainMapID < 200)
	{
		if (theMain.ClickMenuStr("Trang kÕ"))
			return;
	};

	if (m_nTimeWait)
	{
		m_nTimeWait--;
		return;
	}

	g_pCurPlayer->UseItem("ThÇn Hµnh Phï");
	m_nTimeWait = MAX_TIME_WAIT;
}

BOOL CVLMap::SellItems()
{
	for (int i = 0; i < MAX_PLAYER_ITEM; i++)
	{
		if (PLAYER_ITEM(i).nPlace != pos_equiproom) continue;
		KItem* pItem = (KItem*)(dwItmBaseAdd + PLAYER_ITEM(i).nIdx * ITM_DATA_SIZE);
		if (IsInSellList(ComAttr.szItemName))
		{
			g_pCurPlayer->SellItem(PLAYER_ITEM(i).nIdx);
			return TRUE;
		}
		if (theCollect.KeepTheItem(PLAYER_ITEM(i).nIdx, TRUE) == keep_nothing)
		{
			g_pCurPlayer->SellItem(PLAYER_ITEM(i).nIdx);
			return TRUE;
		}
	}
	if (PLAY_HAND_IDX)
	{
		POINT itmPos;
		KItem* pItem = (KItem*)(dwItmBaseAdd + PLAY_HAND_IDX * ITM_DATA_SIZE);
		if (EQUIP_ROOM.FindRoom(ComAttr.nWidth, ComAttr.nHeight, &itmPos))
		{
			g_pCurPlayer->SwitchItem(UOC_ITEM_TAKE_WITH, itmPos.x, itmPos.y);
			return TRUE;
		}
		else
			return 0;
	}
	return 0;
}

BOOL CVLMap::SaveItems()
{
	KItem* pItem;
	POINT itmPos;
	KInventory Room0, Room1, Room2, Room3;
	Room0 = PLAYER_ROOM[room_equipment];
	Room1 = PLAYER_ROOM[room_repository];
	Room2 = PLAYER_ROOM[room_repo02];
	Room3 = PLAYER_ROOM[room_repo03];
	if (PLAY_HAND_IDX)
	{
		pItem = (KItem*)(dwItmBaseAdd + PLAY_HAND_IDX * ITM_DATA_SIZE);
		int nContainer = 0;
		if (Room1.FindRoom(ComAttr.nWidth, ComAttr.nHeight, &itmPos))
			nContainer = UOC_STORE_BOX;
		else if (m_nSaveItemMode > 1 && Room2.FindRoom(ComAttr.nWidth, ComAttr.nHeight, &itmPos))
			nContainer = UOC_STORE_BOX2;
		else if (m_nSaveItemMode > 2 && Room3.FindRoom(ComAttr.nWidth, ComAttr.nHeight, &itmPos))
			nContainer = UOC_STORE_BOX3;
		else if (Room0.FindRoom(ComAttr.nWidth, ComAttr.nHeight, &itmPos))
			nContainer = UOC_ITEM_TAKE_WITH;
		if (nContainer)
		{
			g_pCurPlayer->SwitchItem(nContainer, itmPos.x, itmPos.y);
			return TRUE;
		}
		return (nContainer > UOC_ITEM_TAKE_WITH);
	}
	for (int i = 0; i < MAX_PLAYER_ITEM; i++)
	{
		BOOL bHaveRoom = 0;
		if (PLAYER_ITEM(i).nPlace != pos_equiproom) continue;
		if (PLAYER_ITEM(i).nY == 9) continue;						// Items at last line
		pItem = (KItem*)(dwItmBaseAdd + PLAYER_ITEM(i).nIdx * ITM_DATA_SIZE);
		if (ComAttr.nItemGenre == item_medicine) continue;
		if (theRecover.m_bUseDoubleExp || theQuest.m_AddPointOpt.m_bUseTienThaoLo)
		{
			if (theRecover.IsInX2List(ComAttr.szItemName)) continue;	// Tien Thao Lo
		}
		if (theMap.m_bGiveKCL)
		{
			if (ComAttr.nItemGenre == item_special &&
				ComAttr.nDetailType == 1 &&
				ComAttr.nParticularType == 1499) continue;	// Khieu chien lenh
		}
		if (ComAttr.nObjIdx == 19) continue;	// Ex-Medicine...
		if (ComAttr.nObjIdx == 38) continue;	// SDT, TDP...
		if (ComAttr.nObjIdx == 383) continue;	// Tong Kim Chieu thu
		if (ComAttr.bStack && pItem->m_nCurDur < pItem->m_nMaxDur) continue;	// Stackable items..
		if (Room1.FindRoom(ComAttr.nWidth, ComAttr.nHeight, &itmPos))
			bHaveRoom = TRUE;
		else if (m_nSaveItemMode > 1 && Room2.FindRoom(ComAttr.nWidth, ComAttr.nHeight, &itmPos))
			bHaveRoom = TRUE;
		else if (m_nSaveItemMode > 2 && Room3.FindRoom(ComAttr.nWidth, ComAttr.nHeight, &itmPos))
			bHaveRoom = TRUE;
		if (bHaveRoom)
		{
			g_pCurPlayer->SwitchItem(UOC_ITEM_TAKE_WITH, PLAYER_ITEM(i).nX, PLAYER_ITEM(i).nY);
			return TRUE;
		}
	}
	return 0;
}

BOOL CVLMap::CheckReady()
{
	int nItemIdx;
	KItem* pItem;
	KUiPlayerBar* pUiPlayerBar = (KUiPlayerBar*)GetPtrAddress(UPB_BASE_ADD);
	if (!pUiPlayerBar) return TRUE;
	static BOOL bNeedBuffHP = TRUE;
	if (m_bPutMoney && EQUIP_MONEY > m_nMoneyAmount)
	{
		int nSaveAmount = EQUIP_MONEY - m_nMoneyAmount;
		g_pCoreShell->OperationRequest(GOI_MONEY_INOUT_STORE_BOX, TRUE, nSaveAmount);
		return 0;
	}
	for (int i = 0; i < itempart_num; i++)
	{	// Kiem tra do ben
		nItemIdx = g_pCurPlayer->m_ItemList.m_EquipItem[i].m_nIndex;
		if (!nItemIdx) continue;
		pItem = (KItem*)(dwItmBaseAdd + nItemIdx * ITM_DATA_SIZE);
		if (pItem->m_nCurDur >= 0 && pItem->m_nCurDur < 3)
		{
			SystemMessage("<color=yellow>Trang bÞ s¾p háng, sao cßn ®ßi ®i ®©u?");
			return 0;
		}
	}
	if (P_PLAYER->m_PoisonState.nTime)
	{
		SystemMessage("<color=yellow>§Ìn thïi lïi, ®i ®©u ng­êi ta c­êi chÕt.");
		return 0;
	}

	auto amuletCount = g_pCurPlayer->GetItemsCount(AMULET_PAPER) + g_pCurPlayer->GetItemsCount(AMULETX_PAPER);
	if (amuletCount < 1 && (!pUiPlayerBar->m_nHK3Gengre))
	{
		SystemMessage("<color=yellow>Kh«ng mang T§P, sao cßn d¸m ®i ®©u?");
		return 0;
	}
	if (bNeedBuffHP)
	{
		if (theRecover.m_bAutoHP && P_PLAYER->m_CurrentLife < theRecover.m_nAutoHPAmount)
			g_pCurPlayer->EatMedicine(medicine_blood);
		if (theRecover.m_bAutoMP && P_PLAYER->m_CurrentMana < theRecover.m_nAutoMPAmount)
			g_pCurPlayer->EatMedicine(medicine_mana);
		bNeedBuffHP = 0;
		return 0;
	}
	bNeedBuffHP = TRUE;
	return TRUE;
}

void CVLMap::ClickToNpc(int nX, int nY)
{
	int nPlayerX, nPlayerY, nNpcX, nNpcY, dZ;
	//Search & Found
	if (m_nTimeWait)
	{
		if (m_nTimeWait == 5)
		{
			int nX = (P_PLAYER->m_SyncSignal & 0x07) << 3;
			char szScript[32];
			sprintf(szScript, "MoveTo(%d, 0)", nX);
			ExecuteScript(szScript);
			SystemMessage("<color=yellow>Lag qu¸, chê 5s click l¹i...");
		}
		m_nTimeWait--;
		return;
	}

	P_PLAYER->GetMapPos(&nPlayerX, &nPlayerY);
	for (int i = 1; i < MAX_NPC; i++)
	{
		if (!g_pNpcArray[i]->IsExist() || g_pNpcArray[i]->m_Kind != kind_dialoger) continue;

		g_pNpcArray[i]->GetMapPos(&nNpcX, &nNpcY);
		dZ = __distance(nX, nY, nNpcX, nNpcY);
		if (dZ > 40) continue;

		dZ = __distance(nPlayerX, nPlayerY, nNpcX, nNpcY);
		if (dZ > PLAYER_PICKUP_DISTANCE)
		{
			g_pCurPlayer->MoveTo(nNpcX, nNpcY);
			return;
		}

		theAttack.SetPeopleIdx(i);
		m_nTimeWait = MAX_TIME_WAIT; //wait for 5s for next
		return;
	}
}

void CVLMap::LoadSellList()
{
	memset(m_szSellItems, 0, sizeof(m_szSellItems));
	char szSellItmFile[MAX_PATH];
	sprintf(szSellItmFile, "%s\\Maps\\SellItems.txt", theMain.m_szCurFolder);

	DTextFile itemFile;
	if (!itemFile.Open(szSellItmFile))
		return;

	itemFile.ReadAllLines(m_szSellItems[0], MAX_SELL_ITEMS, 80);
}

BOOL CVLMap::IsInSellList(const char* szItemName)
{
	int i = 0;
	while (m_szSellItems[i][0] && i < MAX_SELL_ITEMS)
	{
		if (strstr(szItemName, m_szSellItems[i]))
			return TRUE;
		i++;
	}
	return 0;
}

void CVLMap::ResetShoping(BOOL bResetAll)
{
	CloseAllWindows(0);
	NearestDriver();
	m_nTimeWait = 2;
	if (bResetAll)
		m_bDoShoping = 0;
}
