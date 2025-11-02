// CEditorDialog.cpp : implementation file
//

#include "stdafx.h"
#include "VLAuto.h"
#include "CEditorDialog.h"
#include "afxdialogex.h"


// CEditorDialog dialog

IMPLEMENT_DYNAMIC(CEditorDialog, CDialogEx)

CEditorDialog::CEditorDialog(byte item,TCHAR* path)
	: CDialogEx(IDD_DIALOG_EDITOR, NULL)
{
	m_item = item;
	m_path = path;
}

CEditorDialog::~CEditorDialog()
{
}

void CEditorDialog::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_EDIT, m_textbox);
}


BEGIN_MESSAGE_MAP(CEditorDialog, CDialogEx)
	ON_BN_CLICKED(IDOK, &CEditorDialog::OnBnClickedOk)
END_MESSAGE_MAP()

char TCVN3[213] =
{
	'A','a','¸','¸','µ','µ','¶','¶','·','·','¹','¹',
	'¢','©','Ê','Ê','Ç','Ç','È','È','É','É','Ë','Ë',
	'¡','¨','¾','¾','»','»','¼','¼','½','½','Æ','Æ',
	'B','b','C','c','D','d',
	'§','®',
	'E','e','Ð','Ð','Ì','Ì','Î','Î','Ï','Ï','Ñ','Ñ',
	'£','ª','Õ','Õ','Ò','Ò','Ó','Ó','Ô','Ô','Ö','Ö',
	'F','f','G','g','H','h',
	'I','i','Ý','Ý','×','×','Ø','Ø','Ü','Ü','Þ','Þ',
	'J','j','K','k','L','l','M','m','N','n',
	'O','o','ã','ã','ß','ß','á','á','â','â','ä','ä',
	'¤','«','è','è','å','å','æ','æ','ç','ç','é','é',
	'¥','¬','í','í','ê','ê','ë','ë','ì','ì','î','î',
	'P','p','Q','q','R','r','S','s','T','t',
	'U','u','ó','ó','ï','ï','ñ','ñ','ò','ò','ô','ô',
	'¦','­','ø','ø','õ','õ','ö','ö','÷','÷','ù','ù',
	'V','v','W','w','X','x',
	'Y','y','ý','ý','ú','ú','û','û','ü','ü','þ','þ',
	'Z','z',
	0x80, 0x82, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88,
	0x89, 0x8A, 0x8B, 0x8C, 0x8E, 0x91, 0x92, 0x93,
	0x94, 0x95, 0x96, 0x97, 0x98, 0x99, 0x9A, 0x9B,
	0x9C, 0x9E, 0x9F
};


wchar_t Unicode[213] =
{
	L'A',L'a',L'á',L'á',L'à',L'à',L'ả',L'ả',L'ã',L'ã',L'ạ',L'ạ',
	L'Â',L'â',L'ấ',L'ấ',L'ầ',L'ầ',L'ẩ',L'ẩ',L'ẫ',L'ẫ',L'ậ',L'ậ',
	L'Ă',L'ă',L'ắ',L'ắ',L'ằ',L'ằ',L'ẳ',L'ẳ',L'ẵ',L'ẵ',L'ặ',L'ặ',
	L'B',L'b',L'C',L'c',L'D',L'd',
	L'Đ',L'đ',
	L'E',L'e',L'é',L'é',L'è',L'è',L'ẻ',L'ẻ',L'ẽ',L'ẽ',L'ẹ',L'ẹ',
	L'Ê',L'ê',L'ế',L'ế',L'ề',L'ề',L'ể',L'ể',L'ễ',L'ễ',L'ệ',L'ệ',
	L'F',L'f',L'G',L'g',L'H',L'h',
	L'I',L'i',L'í',L'í',L'ì',L'ì',L'ỉ',L'ỉ',L'ĩ',L'ĩ',L'ị',L'ị',
	L'J',L'j',L'K',L'k',L'L',L'l',L'M',L'm',L'N',L'n',
	L'O',L'o',L'ó',L'ó',L'ò',L'ò',L'ỏ',L'ỏ',L'õ',L'õ',L'ọ',L'ọ',
	L'Ô',L'ô',L'ố',L'ố',L'ồ',L'ồ',L'ổ',L'ổ',L'ỗ',L'ỗ',L'ộ',L'ộ',
	L'Ơ',L'ơ',L'ớ',L'ớ',L'ờ',L'ờ',L'ở',L'ở',L'ỡ',L'ỡ',L'ợ',L'ợ',
	L'P',L'p',L'Q',L'q',L'R',L'r',L'S',L's',L'T',L't',
	L'U',L'u',L'ú',L'ú',L'ù',L'ù',L'ủ',L'ủ',L'ũ',L'ũ',L'ụ',L'ụ',
	L'Ư',L'ư',L'ứ',L'ứ',L'ừ',L'ừ',L'ử',L'ử',L'ữ',L'ữ',L'ự',L'ự',
	L'V',L'v',L'W',L'w',L'X',L'x',
	L'Y',L'y',L'ý',L'ý',L'ỳ',L'ỳ',L'ỷ',L'ỷ',L'ỹ',L'ỹ',L'ỵ',L'ỵ',
	L'Z',L'z',
	0x20AC, 0x20A1, 0x0192, 0x201E, 0x2026, 0x2020, 0x2021, 0x02C6,
	0x2030, 0x0160, 0x2039, 0x0152, 0x017D, 0x2018, 0x2019, 0x201C,
	0x201D, 0x2022, 0x2013, 0x2014, 0x02DC, 0x2122, 0x0161, 0x203A,
	0x0153, 0x017E, 0x0178
};
wchar_t ConvertChar(char ch)
{
	for (int i = 0; i < 213; i++)
		if (ch == TCVN3[i]) return Unicode[i];
	return wchar_t(ch);
}
void Convert(const char *src, wchar_t *dst)
{
	int i, n = strlen(src);
	for (i = 0; i < n; i++)
	{
		if (src[i] == '\n')
		{
			dst[i++] = wchar_t('\r');
			dst[i++] = wchar_t('\n');
			break;
		}
		else
		{
			dst[i] = ConvertChar(src[i]);
		}
	}
	dst[i] = wchar_t(NULL);
}
char ConvertChar(wchar_t ch)
{
	for (int i = 0; i < 213; i++)
		if (ch == Unicode[i]) return TCVN3[i];
	return char(ch);
}
void Convert(const wchar_t *src, char *dst)
{
	int i;
	int n = wcslen(src);
	for (i = 0; i < n; i++)
		dst[i] = ConvertChar(src[i]);
	dst[i] = char(NULL);
}
// CEditorDialog message handlers
BOOL CEditorDialog::OnInitDialog()
{
	CDialog::OnInitDialog();

	switch (m_item)
	{
		case 0:
			SetWindowText(_T("Vật phẩm không cần nhặt"));
			break;
		case 1:
			SetWindowText(_T("Vật phẩm ưu tiên nhặt"));
			break;
		case 2:
			SetWindowText(_T("Vật phẩm có thể bán"));
			break;
		case 3:
			SetWindowText(_T("Vật phẩm X2 kinh nghiệm"));
			break;
		case 4:
			SetWindowText(_T("Không mời vào tổ đội"));
			break;
	}
	
	FILE* f;
	_wfopen_s(&f, m_path, _T("rt"));
	if (f != NULL)
	{
		TCHAR buffer[4096], *p = buffer;
		memset(buffer, 0, sizeof(buffer));

		char line[256];
		while (fgets(line, sizeof(line), f) != NULL)
		{
			TCHAR* q = p;
			Convert(line, p);
			p = q + wcslen(p);
		}

		fclose(f);

		m_textbox.SetWindowText(buffer);
	}

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CEditorDialog::OnBnClickedOk()
{
	//char line[128];

	FILE* f;
	_wfopen_s(&f, m_path, _T("w+"));
	if (f != NULL)
	{
		CString cs;
		m_textbox.GetWindowText(cs);
		cs.Replace(_T("\r\n"),_T("\n"));

		char buffer[4096];
		memset(buffer, 0, sizeof(buffer));
		Convert(cs.GetBuffer(), buffer);

		fwrite(buffer, strlen(buffer), 1, f);

		fclose(f);
	}

	// TODO: Add your control notification handler code here
	CDialogEx::OnOK();
}
