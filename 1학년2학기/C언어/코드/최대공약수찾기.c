#include <stdio.h>
int main(void)
{
	int x, y, r;
	printf("두 수를 입력하세요(큰수, 작은수)");
	scanf("%d %d", &x, &y);

	while (x % y != 0) {
		r = x % y;
		x = y;
		y = r;
	}
	printf("최대공약수 %d",r);
	return 0;
}