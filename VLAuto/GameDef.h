//GameDef.h
#pragma once

#define CLIENT_SERIAL		683251

enum OBJ_ATTRIBYTE_TYPE
{
	series_undef = -1,
	series_metal = 0,
	series_wood,
	series_water,
	series_fire,
	series_earth,
	series_num,
};

enum NPCCAMP
{
	camp_begin,
	camp_justice,
	camp_evil,
	camp_balance,
	camp_free,
	camp_animal,
	camp_event,
	camp_num,
};

enum NPC_RELATION
{
	relation_none	= 1,
	relation_self	= 2,
	relation_ally	= 4,
	relation_enemy	= 8,
	relation_dialog	= 16,
	relation_all	= relation_none | relation_ally | relation_enemy | relation_self | relation_dialog,	
	relation_num,
};

enum NPCKIND
{
	kind_normal,
	kind_player,
	kind_partner,
	kind_dialoger,
	kind_bird,
	kind_mouse,
    kind_num,
};

enum NPCCMD
{
	do_none,
	do_stand,
	do_walk,
	do_run,
	do_jump,
	do_skill,
	do_magic,
	do_attack,
	do_sit,
	do_hurt,
	do_death,
	do_defense,
	do_idle,
	do_revive = 21,
};

enum OBJKIND
{
	Obj_Kind_MapObj,
	Obj_Kind_Body,
	Obj_Kind_Box,
	Obj_Kind_Item,
	Obj_Kind_Money,
	Obj_Kind_StoreBox = 10
} ;

enum INVENTORY_ROOM
{
	room_equipment = 0,
	room_repository,
	room_trade,
	room_tradeback,
	room_trade1,
	room_immediacy,
	room_06,
	room_repo02,
	room_repo03,
	room_09,
	room_yesou,
	room_0a,
	room_0b,
	room_0c,
	room_guid,
	room_num,
};

enum ITEM_POSITION
{
	pos_hand = 1,
	pos_equip,
	pos_equiproom,
	pos_repositoryroom,
	pos_traderoom,
	pos_trade1,
	pos_immediacy,
	pos_expand,
	pos_repo02,
	pos_repo03,
	pos_yesoubox = 12,
	pos_guid = 23,
};

enum ITEMGENRE
{
	item_equip = 0,
	item_medicine,
	item_mine,
	item_materials,
	item_task,
	item_townportal,
	item_special,
	item_number,
};

enum EQUIPDETAILTYPE
{
	equip_meleeweapon = 0,
	equip_rangeweapon,
	equip_armor,
	equip_ring,
	equip_amulet,
	equip_boots,
	equip_belt,
	equip_helm,
	equip_cuff,
	equip_pendant,
	equip_horse,
	equip_mask,
	equip_detailnum,
};

enum MEDICINEDETAILTYPE
{
	medicine_blood = 0,
	medicine_mana,
	medicine_both,
	medicine_stamina,
	medicine_antipoison,
	medicine_detailnum,
};

enum ITEM_PART
{
	itempart_head = 0,
	itempart_body,
	itempart_belt,
	itempart_weapon,
	itempart_foot,
	itempart_cuff,
	itempart_amulet,
	itempart_ring1,
	itempart_ring2,
	itempart_pendant,
	itempart_horse,
	itempart_mask,
	itempart_pp,
	itempart_an,
	itempart_ts,
	itempart_ts1,
	itempart_ts2,
	itempart_num,
};

enum UIOBJECT_CONTAINER
{
	UOC_IN_HAND	= 1,
	UOC_GAMESPACE,
	UOC_IMMEDIA_ITEM,
	UOC_IMMEDIA_SKILL,
	UOC_ITEM_TAKE_WITH,
	UOC_GUID_BOX,
	UOC_TRADE_BOX,
	UOC_EQUIPTMENT = 9,
	UOC_NPC_SHOP,
	UOC_STORE_BOX,
	UOC_STORE_BOX2,
	UOC_STORE_BOX3,
	UOC_YESOU_BOX = 20,
	UOC_HTINH1_BOX,		// Thang cap Huyen Tinh
	UOC_HTINH2_BOX,		// Thang cap Khoang Thach
	UOC_HTINH3_BOX,		// Tinh luyen Huyen Tinh
};

enum CORE_OBJECT_GENRE
{
	CGOG_NOTHING = 0,
	CGOG_MONEY,
	CGOG_PLAYER_FACE,
	CGOG_OBJECT,
	CGOG_SKILL,
	CGOG_ITEM,
	CGOG_NPC,
	CGOG_MENU_NPC,
	CGOG_NPC_BLUR,
	CGOG_MISSLE,
	CGOG_EQUIP,
	CGOG_NPCSELLITEM,
};

enum GAMEDATA_INDEX
{
	GDI_GAME_OBJ_DESC = 1,
	GDI_GAME_OBJ_DESC_INCLUDE_TRADEINFO,
	GDI_GAME_OBJ_DESC_INCLUDE_REPAIRINFO,
	GDI_GAME_OBJ_LIGHT_PROP,
	GDI_PLAYER_BASE_INFO,
	GDI_TRADE_ITEM_PRICE = 0x0BBA,
};

enum OPTIONS_LIST
{
	OPTION_PERSPECTIVE,
	OPTION_DYNALIGHT,
	OPTION_MUSIC_VALUE,
	OPTION_SOUND_VALUE,
	OPTION_BRIGHTNESS,
	OPTION_WEATHER,
};

enum GAMEOPERATION_INDEX
{
	GOI_EXIT_GAME = 1,
	GOI_SWITCH_OBJECT_QUERY,
	GOI_SWITCH_OBJECT,
	GOI_REJECT_OBJECT,
	GOI_MONEY_INOUT_STORE_BOX,
	GOI_PLAYER_ACTION,
	GOI_PLAYER_RENASCENCE,
	GOI_INFORMATION_CONFIRM_NOTIFY,
	GOI_QUESTION_CHOOSE,
	GOI_USE_ITEM,
	GOI_WEAR_EQUIP,
	GOI_USE_SKILL,
	GOI_SET_IMMDIA_SKILL,
	GOI_TRADE_NPC_BUY = 0x18,
	GOI_TRADE_NPC_CHECK,
	GOI_TRADE_NPC_SELL,
	GOI_TRADE_NPC_REPAIR,
	GOI_TRADE_PLAYER_SETPRICE = 0x45,
	GOI_TRADE_PLAYER_GETPRICE,
	GOI_TRADE_PLAYER_SELL,
	GOI_TRADE_PLAYER_BUY,
	GOI_SHIFT_ITEM = 0x59
};

enum TEAMOPERATION_INDEX
{
	TEAM_CREATE = 0x05,
	TEAM_APPOINT,
	TEAM_INVITE,
	TEAM_KICK,
	TEAM_LEAVE,
	TEAM_JOIN_RESPONSE = 0x0C,
	TEAM_INVITE_RESPONSE = 0x0D,
};

enum PROCESSPEOPLE_INDEX
{
	ACTION_CHAT = 0,
	ACTION_MAKEFRIEND,
	ACTION_TRADE,
	ACTION_JOINTEAM,
	ACTION_INVITETEAM,
	ACTION_FOLLOW,
	ACTION_VIEWITEM,
	ACTION_TONG,
	ACTION_BLACKLIST = 9,
	ACTION_REVENGE = 10,
};

enum MAGIC_ATTRIB
{
	item_begin = 27,
	weapondamagemin_v,
	weapondamagemax_v,
	armordefense_v,
	durability_v,
	requirestr,
	requiredex,
	requirevit,
	requireeng,
	requirelevel,
	requireseries,
	requiresex,
	requiremenpai,
	weapondamageenhance_p,
	armordefenseenhance_p,
	requirementreduce_p,
	indestructible_b,
	item_usagetime_v,

	damage_begin = 55,
	attackrating_v,
	attackrating_p,
	ignoredefense_p,
	physicsdamage_v,
	colddamage_v,
	firedamage_v,
	lightingdamage_v,
	poisondamage_v,
	magicdamage_v,
	physicsenhance_p,
	steallife_p,
	stealmana_p,
	stealstamina_p,
	knockback_p,
	deadlystrike_p,
	fatallystrike_p,
	stun_p,

	normal_begin = 84,
	lifemax_v,
	lifemax_p,
	life_v,
	lifereplenish_v,
	manamax_v,
	manamax_p,
	mana_v,
	manareplenish_v,
	staminamax_v,
	staminamax_p,
	stamina_v,
	staminareplenish_v,
	strength_v,
	dexterity_v,
	vitality_v,
	energy_v,
	poisonres_p,
	fireres_p,
	lightingres_p,
	physicsres_p,
	coldres_p,
	freezetimereduce_p,
	burntimereduce_p,
	poisontimereduce_p,
	poisondamagereduce_v,
	stuntimereduce_p,
	fastwalkrun_p,
	visionradius_p,
	fasthitrecover_v,
	allres_p,
	attackspeed_v,
	castspeed_v,
	meleedamagereturn_v,
	meleedamagereturn_p,
	rangedamagereturn_v,
	rangedamagereturn_p,
	addphysicsdamage_v,
	addfiredamage_v,
	addcolddamage_v,
	addlightingdamage_v,
	addpoisondamage_v,
	addphysicsdamage_p,
	slowmissle_b,
	changecamp_b,
	physicsarmor_v,
	coldarmor_v,
	firearmor_v,
	poisonarmor_v,
	lightingarmor_v,
	damagetomana_p,
	lucky_v,
	steallifeenhance_p,
	stealmanaenhance_p,
	stealstaminaenhance_p,
	allskill_v,
	metalskill_v,
	woodskill_v,
	waterskill_v,
	fireskill_v,
	earthskill_v,
	knockbackenhance_p,
	deadlystrikeenhance_p,
	stunenhance_p,
	badstatustimereduce_v,
	manashield_p,
	adddefense_v,
	adddefense_p,
	fatallystrikeenhance_p,
	lifepotion_v,
	manapotion_v,
	physicsresmax_p,
	coldresmax_p,
	fireresmax_p,
	lightingresmax_p,
	poisonresmax_p,
	allresmax_p,
	coldenhance_p,
	fireenhance_p,
	lightingenhance_p,
	poisonenhance_p,
	magicenhance_p,
	attackratingenhance_v,
	attackratingenhance_p,
	addphysicsmagic_v,
	addcoldmagic_v,
	addfiremagic_v,
	addlightingmagic_v,
	addpoisonmagic_v,
	fatallystrikeres_p,
	statusimmunity_b,
	expenhance_v,
	expenhance_p,
	seriesres_p,
	seriesenhance_p,
	createnpc,
	autoattacknpc,
	magicshield,
	nomovespeed,
	execscript,
	lucky_v_partner,
	normal_end,
};

enum ITEM_KEEP_CAUSE
{
	keep_nothing,
	keep_not_equip,
	keep_locked_equip,
	keep_golden_equip,
	keep_violet_equip,
	keep_special_equip,
	keep_save_jewellery,
	keep_save_ring,
	keep_save_lace,
	keep_mask_equip,
	keep_good_horse,
	keep_red_item,
	keep_high_price,
	keep_high_level,
	keep_good_attrib,
	keep_good_attrib1,
	keep_good_attrib2,
	keep_good_attrib3,
	keep_good_attrib4,
	keep_good_attrib5,
};

enum CITY_MAP_ID
{
	city_phuongtuong = 1,
	city_tuongduong = 78,
	city_bienkinh = 37,
	city_thanhdo = 11,
	city_daily = 162,
	city_duongchau = 80,
	city_laman = 176,
	//Small Towns
	city_longmon = 121,
	city_vinhlac = 99,
	city_balang = 53,
	city_chutien = 100,
	city_giangtan = 20,
	city_thachco = 153,
	city_daohuong = 101,
	city_longtuyen = 174,
	//Ban do Tin su
	city_phongky1 = 387,
	city_phongky2,
	city_phongky3,
	city_sonmieu1,
	city_sonmieu2,
	city_sonmieu3,
	city_baokho1,
	city_baokho2,
	city_baokho3,
	// Vi Son dao
	city_visondao = 342,
	//Khu vuc Bang
	city_banghoimin = 586,
	city_banghoimax = 604,
};

enum _ATTACK_SKILL
{
	skill_supp01,
	skill_supp02,
	skill_supp03,
	skill_left,
	skill_right,
	skill_boss,
	skill_defence,
	skill_total
};

enum TASK_CODES
{
	ys_taskgid = 1020,
	ys_majorid,
	ys_maphave = 1025,
	ys_repvalue,	// Chi so PD & DV
	ys_shxtmap,		// So luong ban do SHXT
	ys_taskstatus,
	ys_task405,
	ys_minorid,
	ys_mapid,
	ys_smapreq,
	ys_prelevel,
	ys_preexp,
	ys_tasknum = 1044,
	ys_taskccl = 1046,	// Task Cancel
	pck_marks = 1207,
	pck_time = 0x04C6,
	bh_lsttask = 0x0515,
	bh_pklbid = 0x06D0,
	bh_pkqty = 0x06D1,
	bh_pkkind = 0x06D2,
	bh_pkfirst = 0x06D3,
	bh_pklast = 0x06DB,
	bh_pklevel = 0x06DC,
	bh_curtask = 0x0899,
	bh_tasktime = 0x0A06,
	ys_preexp_ex = 2574
};

enum QUEST_ACTIONS
{
	act_auto,
	act_cancel,
	act_useitem,
	act_ignore,
};

enum _PRICE_ITEM
{
	price_ring,
	price_pendant,
	price_other,
	price_fuyuan01,
	price_fuyuan02,
	price_fuyuan03,
	price_satthugian,
};

enum _PRIZE_ITEM
{
	prize_hoangkimmp,
	prize_nhutinhao,
	prize_nhutinhnb,
	prize_nhutinhot,
	prize_hiepcotnb,
	prize_hiepcotot,
	prize_anbangdc,
	prize_anbangot,
	prize_dinhquocmu,
	prize_dinhquocot,
	prize_ttthbt,
	prize_huyentinh,
	prize_vlmtttk,
	prize_tlhbntk,
	prize_bikipmp,
	prize_ttl,
	prize_kinhnghiem,
	prize_phucduyen,
	prize_dauhoi,
	prize_cohoihuy,
	prize_nkhoang,
	prize_nthach,
	prize_tsblo,
	prize_bqualo,
	prize_duochoan,
	prize_phaohoa,
	prize_tttanhphu,
	prize_levelht,
	prize_other,
};

enum UTIL_TASKS
{
	util_moveitem = 1,
	util_makeht,
	util_upgradeht,
	util_givekcl,
	util_buyitem,
	util_opengif,
	util_doevent,
	//Bang hoi
	util_getlenhbai,
};

enum SENDCMD
{
	cmd_none,
	cmd_amulet,			// Thong bao da tho dia phu
	cmd_autohit,		// Tu dong danh quai
	cmd_autoarng,		// Tu dong xep do
	cmd_savepoint,		// Ghi nho diem
	cmd_setpoint,		// Danh quanh diem, theo toa do
	cmd_setmap,			// Ve thanh tu quay lai
	cmd_setyesou,		// Tu lam nv Da Tau
	cmd_loadini,		// Load ini file
	cmd_activate,		// Activate GameWindow
	cmd_exit,			// Gui lenh thoat Game (tu VLAuto)
	cmd_exitall,		// Gui lenh thoat tat ca Game (tu Game)
	cmd_stop,			// Gui lenh STOP Hook
	cmd_start,			// Gui lenh START Hook
	cmd_restart,		// Gui lenh RESTART Hook
	cmd_beginpk,		// Chuan bi gui lenh den AutoLogin
	cmd_endpk,			// Gui lenh thoat nv phu
	cmd_showme,			// Gui lenh Hien VLAuto
	cmd_attack,			// Gui lenh tan cong doi thu
};
