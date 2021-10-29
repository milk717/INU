#include <stdio.h>
#include <stdlib.h>
int main(void)
{
	int coin;
	coin = rand();

	if (coin % 2 == 0)
		printf("앞면입니다.");
	else
		printf("뒷면입니다.");
	return 0;
}