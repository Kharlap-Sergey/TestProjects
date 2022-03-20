// Project.cpp : Defines the entry point for the console application.
//
#include "FileLocalServerTypeInfo_h.h"
#include "FileLocalServerTypeInfo_i.c"
#include <stdio.h>
#include "stdafx.h"

IPlan* pPlan = NULL;
IClassFactory * pICF = NULL;
HRESULT hr;

char bufrus[256];
char *rus(const char *text)
{
	CharToOemA(text,bufrus);
	return bufrus;
}

int main()
{
	printf(rus("\n������������� COM ..."));
	if ( FAILED( CoInitialize( NULL )))
	{
		printf(rus("\n������ ��� ������������� COM ..."));
		printf(rus("\n\n������� ����� ������� ��� �����������..."));
		getchar();
		return -1;
	}	
	
	printf(rus("\n��������� ���������� ������� ������� ��� ������ Plan..."));
	hr = CoGetClassObject(CLSID_Plan,CLSCTX_LOCAL_SERVER,NULL,IID_IClassFactory,(void**)&pICF);
	if ( FAILED( hr ))
	{
		printf(rus("\n������ ��� ��������� ��������� �� ��������� ������� �������. ��� ������� %X"),hr);
		printf(rus("\n\n������� ����� ������� ��� �����������..."));
		getchar();
		return -1;
	};

	IUnknown* pIUnk;
	hr = pICF->CreateInstance( NULL, IID_IUnknown, (void**) &pIUnk );
	pICF->Release();
	if ( FAILED( hr ))
	{
		printf(rus("\n������ ��� �������� ���������� ����������. ��� ������ %X"),hr);
		printf(rus("\n\n������� ����� ������� ��� �����������..."));
		getchar();
		return -1;
	};
   
	printf(rus("\n��������� ���������� ������� ������ "));
	printf(rus("\n\n������� ����� ������� ��� �����������..."));
	getchar();
	
	hr = pIUnk->QueryInterface( IID_IPlan, (LPVOID*)&pPlan );
	pIUnk->Release();
	if ( FAILED( hr ))
	{
		printf(rus("������ ��� ������� ���������� IPlan. ��� ������ %X"),hr);
		printf(rus("\n\n������� ����� ������� ��� �����������..."));
		getchar();
		getchar();
		return -1;
	}

	DWORD c = 0;
	pPlan->Summ(3,4,&c);
	printf(rus("��������� -  %d"),c);
	//char str[256];
	//gets(str);
	getchar();
	return 0;
}

