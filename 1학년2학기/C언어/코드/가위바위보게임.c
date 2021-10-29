// 컴퓨터와 사람이 가위바위보 하는 프로그램
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(void) {

	int user, computer;
	int count = 0;
	int win = 0;
	srand(time(NULL));

	printf("가위, 바위, 보 게임에 오신 것을 환영합니다.\n\n");

	while (1) {
		printf("하나를 선택하세요(가위-0, 바위-1, 보-2) : ");
		scanf("%d", &user);

		computer = rand() % 3;

		printf("사용자 = %d\n", user);
		printf("컴퓨터 = %d\n", computer);

		if (user == computer) {
			printf("무승부\n");
			count++;
		}
		else if ((user + 1) % 3 == computer) {
			printf("컴퓨터 승리\n");
			count++;
		}
		else {
			printf("사용자 승리\n");
			count++;
			win++;
			if (win == 3)    // 사용자가 세번 승리하면 가위바위보 종료
				break;
		}
	}
	printf("가위바위보를 한 횟수: %d\n", count);
	return 0;
}