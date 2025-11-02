#pragma once

// CDlgMove dialog

class CDlgMove : public CDialog
{
	DECLARE_DYNAMIC(CDlgMove)

public:
	CDlgMove(CWnd* pParent = NULL);   // standard constructor
	virtual ~CDlgMove();
	void			UpdateNearByPlayers(BOOL bSave);
	void			UpdatePointsList(BOOL bSave);
	void			OnBnClickedAddButton();
	void			OnBnClickedDelButton();
	void			OnBnClickedUpButton();
	void			OnBnClickedDownButton();
	void			OnBnClickedDelAllButton();
	void			OnBnClickedSaveButton();
	void			OnBnClickedLoadButton();

// Dialog Data
	enum { IDD = IDD_MOVE_DIALOG };

protected:
	virtual BOOL	OnInitDialog();
	virtual BOOL	PreTranslateMessage(MSG* pMsg);
	virtual void	DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual void	OnOK() {}
	virtual void	OnCancel() {}
	afx_msg void	OnButtonsClicked(UINT nID);

	DECLARE_MESSAGE_MAP()
public:
	CListBox		m_PoinList;
	CToolTipCtrl	m_ToolTip;
};
