#include <stdio.h>
int main()
{
	int x, y;
	x = 3;
	y = x++;
	printf("x** = %d", y);
	y = ++x;
	printf("++x = %d", y);
	return 0;
}