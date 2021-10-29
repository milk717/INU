#include <stdio.h>
int main(void)
{
	double s = 0.0, n = 0.0;
	for (int i = 1; i > 0; i++,s += n) {
		printf("%d번째 실수를 입력하시오 : ", i);
		scanf("%lf", &n);
		if (n < 0) {
			break;
		}
	}
	printf("합계 = %f", s);
	return 0;
}