#pragma once

#include "UiControls.h"

// CDlgAbout dialog

class CDlgAbout : public CDialog
{
	DECLARE_DYNAMIC(CDlgAbout)

public:
	CDlgAbout(CWnd* pParent = NULL);   // standard constructor
	virtual ~CDlgAbout();

// Dialog Data
	enum { IDD = IDD_ABOUT_DIALOG };

protected:
	virtual BOOL	OnInitDialog();
	virtual BOOL	PreTranslateMessage(MSG* pMsg);
	virtual void	DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual void	OnOK() {}
	virtual void	OnCancel() {}
	virtual BOOL	OnCommand(WPARAM wParam, LPARAM lParam);

	afx_msg void	OnBnClickedUtilityButton();
	afx_msg void	OnBnClickedOptionButton();
	afx_msg void	OnBnClickedSaveButton();
	afx_msg void	OnBnClickedLoadButton();
	afx_msg void	OnBnClickedHcopyButton();
	afx_msg void	OnBnClickedCcopyButton();

	DECLARE_MESSAGE_MAP()

public:
	char			m_HardDriveID[32];
	CToolTipCtrl	m_ToolTip;
	CMenu			m_UtilMenu;
	BOOL			CopyToCliboard(char* szData);
	void			SaveRegData();
	afx_msg void OnBnClickedBlacklist();
	afx_msg void OnBnClickedRedlist();
	afx_msg void OnBnClickedSelllist();
	afx_msg void OnBnClickedX2list();
	afx_msg void OnBnClickedNoptlist();
};
