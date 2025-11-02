#pragma once


// CEditorDialog dialog

class CEditorDialog : public CDialogEx
{
	DECLARE_DYNAMIC(CEditorDialog)

	byte m_item;
	TCHAR* m_path;
public:
	CEditorDialog(byte item, TCHAR* path);   // standard constructor
	virtual ~CEditorDialog();

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_EDITOR_DIALOG };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual BOOL OnInitDialog();

	DECLARE_MESSAGE_MAP()
public:
	CEdit m_textbox;
	afx_msg void OnBnClickedOk();
};
