#include <stdio.h>
#define SEC_PER_MINUTE 60
int main()
{
	int input, minute, second;
	printf("초 단위의 시간을 입력하세요.(32억초이하) : ");
	scanf("%d", &input);

	minute = input / SEC_PER_MINUTE;
	second = input % SEC_PER_MINUTE;
	
	printf("%d초는 %d분 %d초 입니다.", input, minute, second);
	return 0;
}