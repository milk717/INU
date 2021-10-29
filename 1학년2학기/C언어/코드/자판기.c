#include <stdio.h>
int main(void)
{
	int money, price, extramoney;
	printf("투입한 돈 : ");
	scanf("%d", &money);
	printf("물건가격 : ");
	scanf("%d", &price);

	extramoney = money - price;
	printf("거스름돈 : %d\n\n", extramoney);

	int coin100 = extramoney / 100;
	extramoney = extramoney % 100;
	int coin10 = extramoney / 10;

	printf("100원짜리 동전 %d\n10원짜리 동전 %d", coin100, coin10);
	return 0;
}