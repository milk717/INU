#include <stdio.h>
int main(void)
{
	int money, candy, candymoney, extramoney;

	printf("현재 가진 돈을 입력하세요 : ");
	scanf("%d", &money);
	printf("캔디의 금액을 입력하세요 : ");
	scanf("%d", &candymoney);

	candy = money / candymoney;
	extramoney = money % candymoney;

	printf("최대로 살 수 있는 컌디의 개수 : %d,\n", candy);
	printf("남은 돈 : %d", extramoney);

	return 0;
}