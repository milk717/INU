#include <stdio.h>
#include <windows.h>
int main(void)
{
	HDC hdc = GetWindowDC(GetForegroundWindow());
	int i=0;
	while (i < 10) {
		Rectangle(hdc, 100+(110*i), 100, 200+(110*i), 200);
		i++;
	}
	return 0;
}