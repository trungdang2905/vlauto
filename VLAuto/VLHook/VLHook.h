#pragma once

#ifdef HOOKPR_EXPORTS
#define HOOKDLL_API __declspec(dllexport)
#else
#define HOOKDLL_API __declspec(dllimport)
#endif

HOOKDLL_API unsigned StartInject(HWND hWndGame, HWND hWndAuto);
HOOKDLL_API unsigned StopInject(HWND hWndGame);
