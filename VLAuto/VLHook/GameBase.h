#pragma once

#define	MAX_NPC					256
#define	MAX_OBJ					256
#define	MAX_ITM					512
#define	MAX_NPCSKILL			80
#define MAX_TOP_TONG			25
#define MAX_TEAM_MEMBER			8

#define REGION_WIDTH			512
#define REGION_HEIGHT			1024
#define CELL_WIDTH				32
#define CELL_HEIGHT				32
#define MAX_FOLLOW_DISTANCE		48
#define	MIN_RETURN_DISTANCE		64
#define	PLAYER_PICKUP_DISTANCE	128
#define	MAX_PLAYER_MOVE_FRAME	7
#define MAX_MOVE_DISTANCE		400
#define MAX_ROOM_SPACE			60

#define	NGAMY_BUFF_SKILLID		0x005D
#define NGAMY_BUFF_RADIUS		400
#define WND_N_MENU_CLICK		0x0502
#define WND_N_BUTTON_CLICK		0x0565

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

#define	MAX_PLAYER_ITEM	472
#define NPC_DATA_SIZE	0x000113B8
#define OBJ_DATA_SIZE	0x03D4
#define ITM_DATA_SIZE	0x057C
#define SKL_DATA_SIZE	0x04F8
#define PLAYER_OFFSET	0x8B30
#define MSG_PLR_OFFSET	0x0408		// Inviter

#define FLAG_X_OFFST	0x0067E608	// MiniMap X Offset
#define FLAG_Y_OFFST	0x0067E60C	// MiniMap Y Offset
#define LIFETIME_DYS	0x006DEFA4	// DeadLine Life Time
#define LIFETIME_HRS	0x006DEFA8	// Remaining Life Time
#define LEVEL_EXP_TB	0x01618B30	// Level Exp Table

// UI Classes
#define OBJ_BASE_ADD	0x012C5588	// KObj (pointer)
#define SKL_BASE_ADD	0x008E4D10	// KSkill (static)
#define ITM_BASE_ADD	0x01341190	// KItem (pointer)
#define IST_BASE_ADD	0x00680774	// KStallObject (pointer)
#define TEAM_ADDRESS	0x01340EF0	// KTeam (static)
#define UPB_BASE_ADD	0x0068F94C	// KUiPlayerBar (pointer)
#define SBO_BASE_ADD	0x00693284	// KUiStoreBox (pointer)
#define MCP_BASE_ADD	0x00696410	// KUiMsgCentrePad (pointer)
#define SMC_BASE_ADD	0x006966C0	// KUiSysMsgCentre (pointer)
#define YSB_BASE_ADD	0x00697094	// KUiYeSouBox (pointer)
#define MSG_BASE_ADD	0x0069B558	// KUiMsgSel (pointer)
#define MSG2_BASE_ADD	0x00697598	// KUiMsgSel2 (pointer)
#define SHOP_BASE_ADD	0x00696460	// KUiShop (pointer)
#define MMP_BASE_ADD	0x006966C8	// KUiMiniMap (static)
#define UIN_BASE_ADD	0x006931D8	// KUiInit (pointer)
#define IF1_BASE_ADD	0x00693FE0	// KUiInformation (static)
#define IF2_BASE_ADD	0x00694780	// KUiInformation2 (static)
#define TMC_BASE_ADD	0x00696E68	// KUiTongManagement (static)
#define STL_BASE_ADD	0x0069709C	// KUiPlayerStall (pointer)
#define CMP_BASE_ADD	0x006976A0	// KUiCompound (pointer)
#define PZS_BASE_ADD	0x0069B548	// KUiPrizeSel (pointer)
#define ITX_BASE_ADD	0x006DD02C	// KUiItemEx (pointer)
#define WLD_BASE_ADD	0x008E4D00	// KSubWorld (pointer)
#define NSET_BASE_ADD	0x012C5598	// KNpcSet (static)
#define BSL_BASE_ADD	0x01605F28	// KBuySell (static)

// UI Functions
#define UWP_FUNC_ADD	0x0044BB00	// KUiPlayerBar::WndProc Function
#define OSM_FUNC_ADD	0x0044D640	// KUiPlayerBar::OnSendSomeoneMessage
#define IOC_FUNC_ADD	0x004660D0	// KUiInit::OnClickButton Function
#define SBO_FUNC_ADD	0x0046D5E0	// KUiStoreBox::OpenWindow Function
#define IH1_FUNC_ADD	0x00489E70	// KUiInformation::Hide Function
#define IH2_FUNC_ADD	0x0048A490	// KUiInformation2::Hide Function
#define SMA_FUNC_ADD	0x0048E030	// KUiMsgCentrePad::SystemMessageArrival Function
#define SHO_FUNC_ADD	0x0049AF30	// KUiShop::OpenWindow Function
#define PCP_FUNC_ADD	0x004A3F80	// ProcessPeople Function
#define SMD_FUNC_ADD	0x004A6A20	// KUiSysMsgCentre::DeleteMsgInHeap Function
#define SMF_FUNC_ADD	0x004AAA90	// KUiMiniMap::SetMapFlag Function
#define TGL_FUNC_ADD	0x004BDC10	// KUiTongManagement::GetTongList Function
#define TGP_FUNC_ADD	0x004BE310	// KUiTongManagement::PrepareTongList Function
#define OMS2_FUNC_ADD	0x004EF480	// KUiMsgSel2::OnClickMsg Function
#define OCB_FUNC_ADD	0x004E6F40	// KUiYeSouBox::OnClickBtn Function
#define PSC_FUNC_ADD	0x00505920	// KUiPrizeSel::CloseWindow Function
#define OMS_FUNC_ADD	0x00509180	// KUiMsgSel::OnClickMsg Function
#define EXS_FUNC_ADD	0x00414240	// ExecuteScript Function
#define CLA_FUNC_ADD	0x00420D40	// CloseAllWindows Function
#define GGD_FUNC_ADD	0x005389F0	// KCoreShell::GetGameData Function
#define OPR_FUNC_ADD	0x0053B770	// KCoreShell::OperationRequest Function
#define TNP_FUNC_ADD	0x0053E9D0	// KCoreShell::TongOperation Function
#define TOP_FUNC_ADD	0x00539E00	// KCoreShell::TeamOperation Function
#define PGS_FUNC_ADD	0x0053A130	// KCoreShell::ProcessGameSecurity Function
#define PAA_FUNC_ADD	0x00566D00	// KPlayer::ApplyAddBaseAttribute Function
#define PKO_FUNC_ADD	0x00569350	// KPlayer::PickUpObj Function
#define DNPC_FUNC_ADD	0x0056B820	// KPlayer::DialogNpc Function
#define GRL_FUNC_ADD	0x00581150	// KNpcSet::GetRelation
#define MVT_FUNC_ADD	0x00579700	// KNpc::MoveTo Function
#define SKL_FUNC_ADD	0x0058D220	// SendClientCmdSkill Function
#define IGR_FUNC_ADD	0x00592200	// KItem::GetRepairPrice Function
#define GTV_BASE_ADD	0x005F10A0	// KPlayerTask::GetTaskVal Function
#define BGI_FUNC_ADD	0x005B71F0	// KBuySell::GetItem Function
#define BGX_FUNC_ADD	0x005B72B0	// KBuySell::GetItemIndex Function

// Code Injection
#define _INJ_ADD_		0x005550DA	// CALL _ORG_PROC_
#define _RET_ADD_		0x005550DF	// TEST EAX,EAX
#define _ORG_PROC_		0x005AE5C0	// KObjSet::ClientAdd Function

#define WND_S_VISIBLE		0x80000000
#define WND_S_DISABLED		0x40000000
#define	WND_S_TOPMOST		0x20000000
#define	WND_S_MOVEALBE		0x10000000
#define	WND_S_DISABLE		0x04000000
#define SKILL_SHORTCUT		0x00040004

#define SCK_SHORTCUT_SIT	"Switch([[sit]])"
#define SCK_SHORTCUT_HORSE	"Switch([[horse]])"

#define AMULET_PAPER		"Thæ ®Þa phï"
#define AMULETX_PAPER		"Håi thµnh phï"
#define KC_LENH				"Khiªu chiÕn lÖnh"
#define FY_ITEM				"Phóc Duyªn Lé"
#define VISITED_PLACES		"Nh÷ng n¬i ®· ®i qua"
#define AGREE_TRADE			"Giao dÞch"
#define FULL_REPAIR			"Söa kü ["
