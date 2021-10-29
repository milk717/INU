#include <stdio.h>
#include <time.h>
#include <stdlib.h>
int main(void)
{
	int first_money, goal_money, game=0, win=0, p;
	srand(time(NULL));
	printf("초기 금액 $");
	scanf("%d", &first_money);
	printf("목표 금액 $");
	scanf("%d", &goal_money);
	while (goal_money != first_money)
	{
		game++;
		p = rand() % 2;
		if (p == 1) 
		{
			win++;
			first_money++;
		}
		else
		{
			first_money--;
			if (first_money == 0)
				break;
		}
	}
	printf("%d번중 %d번 승리\n", game, win);
	double pp;
	pp = ((double)win / game)*100;
	printf("이긴 확률 = %lf%%\n", pp);
	return 0;
}