#include <stdio.h>
int main(void)
{
	int x, y, z;
	printf("세 개의 정수를 입력하세요(띄어쓰기로 구분) : ");
	scanf("%d %d %d", &x, &y, &z);

	if (x > y && x > z)
		printf("가장 큰 수 %d", x);
	else if (y > x && y > z)
		printf("가장 큰 수 %d", y);
	else
		printf("가장 큰 수 %d", z);

	return 0;
		
}