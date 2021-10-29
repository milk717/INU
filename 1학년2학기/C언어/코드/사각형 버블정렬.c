#include <stdio.h>
#include <windows.h>
int main(void)
{
	HDC hdc = GetWindowDC(GetForegroundWindow());
	int s[6] = { 60, 10, 40, 50, 20, 30 };
	int i, j;
	for (i = 5; i > 0; i--)
	{
		Rectangle(hdc, 0, 0, 800, 800);
		for (j = 0; j < i; j++)
		{
			if (s[j] > s[j + 1])
			{
				int ex = 0;
				ex = s[j];
				s[j] = s[j + 1];
				s[j + 1] = ex;
			}
		}
		for (int k = 0; k < 6; k++)
		{
			Rectangle(hdc, 200 + k * 30, 200, 230 + k * 30, 200 - s[k]);
		}
		Sleep(1000);
	}
	return 0;
}