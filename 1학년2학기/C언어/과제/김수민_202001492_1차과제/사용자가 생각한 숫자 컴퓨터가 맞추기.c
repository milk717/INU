#include <stdio.h>
int main(void)
{
	int count=1, answer,b=100,s=1,w=(b+s)/2;  //시도횟수, 대답, big(큰수), small(작은수), what(물어볼숫자)
	printf("(1~99)범위의 숫자를 마음속으로 생각해보세요.\n");
	printf("%d보다 작으면 0, 같으면1, 크면 2를 입력하시오 : ",w);
	scanf("%d", &answer);
	do {
		switch (answer) {
		case 0:							//사용자가 생각한 숫자가 컴퓨터가 말한 것 보다 작을 떄
			count++;					//횟수증가
			b = w - 1;					//물어본 수 보다 작다고 했으니까 큰 수 값을 물어본 값 보다 하나 작게 설정
			w = (b+s)/2;				//큰 수와 작은 수의 중간값 계산
			printf("%d보다 작으면 0, 같으면 1, 크면 2를 입력하시오 : ", w);
			scanf("%d", &answer);
			break;
		case 1:
			break;        
		case 2:							//사용자가 생각한 숫자가 컴퓨터가 말한 것 보다 클 떄
			count++;
			s = w + 1;
			w = (b+s)/2;
			printf("%d보다 작으면 0, 같으면 1, 크면 2를 입력하시오 : ", w);
			scanf("%d", &answer);
			break;
		default:
			printf("잘못 입력하셨습니다.\n");
			printf("%d보다 작으면 0, 같으면 1, 크면 2를 입력하시오 : ", w);
			scanf("%d", &answer);
			break;
		}
	} while (answer != 1);
	printf("사용자는 %d를 생각했습니다. %d번 만에 답을 맞췄습니다.", w, count);
	return 0;
}