#include <stdio.h>
int main(void)
{
	int i = 5;
	long fac = 1;

	while (i > 0) {
		fac *= i;
		i--;
	}
	printf("5펙토리얼은 %d입니다.", fac);
	return 0;
}