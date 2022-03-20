// FileLocalServer.cpp : Defines the entry point for the application.
//

#include "stdafx.h"
#include "FileLocalServerTypeInfo_i.c"
#include "FileClassFactory.h"	
#include <string.h>

DWORD g_allLocks;

int APIENTRY WinMain(HINSTANCE hInstance,HINSTANCE hPrevInstance,LPSTR lpCmdLine,int nCmdShow)
{
	HRESULT hr;
	MessageBox(NULL, "������������� ������� Plan", "��������� ������", MB_OK | MB_SETFOREGROUND|MB_ICONINFORMATION);
	CoInitialize(NULL); 	

	ITypeLib* pTLib = NULL;
	hr = LoadTypeLibEx(L"FileLocalServer.tlb", REGKIND_REGISTER, &pTLib);
	pTLib->Release();
	if ( FAILED(hr) )
	{
		MessageBox(NULL,"������ �������� \"FileLocalServerTypeInfo.tlb\"","������",MB_OK | MB_SETFOREGROUND|MB_ICONINFORMATION);
		exit(1);
	}
			
	//if(strstr(lpCmdLine, "/Embedding") || strstr(lpCmdLine, "-Embedding"))
	//{
		MessageBox(NULL, "����������� ������ ������� Plan ", "��������� ������", MB_OK | MB_SETFOREGROUND|MB_ICONINFORMATION);
		FileClassFactory fileClassFactory;
		DWORD regID = 0;
		hr = CoRegisterClassObject(CLSID_Plan, (IClassFactory*)&fileClassFactory, CLSCTX_LOCAL_SERVER, REGCLS_MULTIPLEUSE, &regID);
		if ( FAILED(hr) )
		{
			MessageBox(NULL,"������ ����������� ������","������",MB_OK | MB_SETFOREGROUND|MB_ICONINFORMATION);
			CoUninitialize();
			exit(1);
		}
		MSG ms;
		while(GetMessage(&ms, 0, 0, 0))
		{
			TranslateMessage(&ms);
			DispatchMessage(&ms);
		}
		CoRevokeClassObject(regID);	
 	//}
	CoUninitialize();	
	MessageBox(NULL, "���������� ������ �������", "��������� ������", MB_OK | MB_SETFOREGROUND|MB_ICONINFORMATION);
	return 0;
}