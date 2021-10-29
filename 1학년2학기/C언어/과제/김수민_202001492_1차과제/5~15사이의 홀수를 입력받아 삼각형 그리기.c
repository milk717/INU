#include <stdio.h>
int main(void)
{
	//사용자한테 수 입력받기
	int n;
	printf("(5~15)사이의 홀수를 입력하세요 : ");
	scanf("%d", &n);
	while (n % 2 == 0 || n<5 || n>15) {
		printf("입력값이 잘못되었습니다.\n");
		printf("(5~15)사이의 홀수를 입력하세요 : ");
		scanf("%d", &n);
	}

	//밑변을 그리기 위해 필요한 변수들
	int s = 1;		//한 줄에서의 양끝 공백
	int line = n - 2;		//밑변 제외 삼각형 몇줄그려야하는지
	int msp = line - 2; //가운데 공백

	//사용자한테 입력받은 별 개수만큼 밑변 그리기
	for (int a = 0; a < n; a++)
	{
		printf("*");
	}

	printf("\n");	//밑변과 세모 분리

	//밑변그리기 시작
	for (int i = 0; i < line; i+=2)				//라인만큼 줄그리기, i를 2씩 증가시키는 이유는 공백을 생각해서
	{
		int j = 0;		//한 줄에 몇개 출력할지 카운트하는 변수
		int num = n - s;  //한 줄에 몇개출력해야하는지
		while (j < num)
		{
			for (int c = 0; c < s; c++)		//c(count) : 양끝 공백을 카운트
			{
				printf(" ");		
				j++;			//공백만큼 그렸으니까 그만큼 몇개 출력했는지 카운트 증가
			}
			printf("*");			//첫 번재 공백 이후 별출력
			j++;					//출력한만큼 카운트증가
			for (int m = 0; m < msp; m++)			//msp(middle space) : 가운데 공백
			{
				printf(" ");
				j++;						//출력한만큼 카운트
			}
			if (line - i != 1) {			//꼭짓점에서는 별을 한개 그리기 위한 조건
				printf("*");
			}
			j++;							//출력한만큼 카운트
		}
		s++;								//역삼각형이니 다음 줄에서는 양끝 공백을 증가시켜주기 위함
		msp = msp - 2;						//가운에 공백은 2씩 줄여나감
		printf("\n");						//줄바꿈
	}
	return 0;
}