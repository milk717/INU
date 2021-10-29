#include <stdio.h>
#include <stdlib.h>
#include <time.h>
int main(void)
{
	int user, computer, win=0, count=0;
	srand(time(NULL));
	printf("가위바위보 게임에 오신것을 환영합니다!\n");
	
	do
	{
		printf("---------------------------------------------------");
		printf("\n다음 중 하나를 선택하세요(가위-0, 바위-1,보-2) : ");
		scanf("%d", &user);
		count++;
		computer = rand() % 3;
		printf("\n사용자 = %d\n", user);
		printf("컴퓨터 = %d\n\n", computer);

		if ((user + 1) % 3 == computer)
			printf("컴퓨터 승리\n");
		else if (user == computer)
			printf("비겼습니다\n");
		else {
			printf("사용자 승리\n");
			win++;
		}
	} while (win < 3);
	printf("====================================================");
	printf("\n총 게임 수 : %d", count);
	return 0;
	}