REM ========================================
REM Setting Envinroments
REM ========================================
SET EXE_FILE=VLAutoPr.exe
SET DLL_FILE=VLHookPr.dll
SET PRJ_DIR=D:\0-Projects\_VoLam\VLAuto3
SET ZIP_FILE=D:\0-Projects\_VoLam\VLAuto.NET\Home\DownFiles\VLPro.zip
SET SFX_FILE=D:\0-Projects\_VoLam\VLAuto.NET\Home\DownFiles\VLPro.exe
SET PE_APP=D:\Setup\PECompact2\pec2.exe
SET WINRAR_APP=C:\Program Files (x86)\WinRAR\WinRAR.exe
REM ========================================
REM PE Compression
REM ========================================
"%PE_APP%" "%PRJ_DIR%\_Bin\%EXE_FILE%" /Sd:Y /Nb /Hh:pec2hooks_redirect.dll,pec2hooks_api_ispacked.dll
"%PE_APP%" "%PRJ_DIR%\_Bin\%DLL_FILE%" /Sd:Y /Nb /Hh:pec2hooks_redirect.dll,pec2hooks_api_ispacked.dll
REM ========================================
REM File Copy
REM ========================================
DEL /Q "%PRJ_DIR%\_Bin\Logs\*.*"
DEL /Q "%PRJ_DIR%\_Bin\UiConfig\*.*"
REM ========================================
REM Files Compression
REM ========================================
REM DEL "%SFX_FILE%"
REM "%WINRAR_APP%" a -sfx -z_Publish\VLAutoPr.cmt -iicon_Publish\VLAutoPr.ico -iimg_Publish\VLAuto.bmp -r -ep1 -m5 -s "%SFX_FILE%" "%PRJ_DIR%\_Bin\*.*"
