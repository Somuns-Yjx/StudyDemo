#include <stdio.h>
#include<limits>

typedef int(*Calc)(int, int); // ����ָ��
typedef int(*Calc2)(int, int); // ����ָ��


int Add(int a, int b)
{
	if (a > 0 && b > 0)
	{
		if (a > INT_MAX - b)
			return a + b;
		else
			return -1;
	}
	else if (a < 0 && b < 0)
	{
		if (a > INT_MIN - b)
			return a + b;
		else
			return -2;
	}
	else
		return a + b;
}

int Sub(int a, int b)
{
	if ((a > 0 && b > 0) || (a < 0 && b < 0))
	{
		return a - b;
	}
	else	if (a > 0 && b < 0)
	{
		if (a < INT_MAX + b)
			return a - b;
		else
			return 3;
	}
	else if (a < 0 && b>0)
	{
		if (a > b + INT_MIN)
			return a - b;
		else
			return 4;
	}
	else
		return a - b;
}
int main()
{
	Calc FunctionPoint1 = &Add;		// ���ú���ָ�룬���Բ�ֱ�ӵ��ú��������Һ����޸ĺ������������������ٴ��޸�
	Calc2 FunctionPoint2 = &Sub;
	int res1 = FunctionPoint1(0, 0);
	int res2 = FunctionPoint2(0, 0);
	printf("Func1Res = %d\n", res1);
	printf("Func2Res = %d\n", res2);
	system("pause");
}