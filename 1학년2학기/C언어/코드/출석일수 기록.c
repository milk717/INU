#include <stdio.h>
#define day 3
int main(void)
{
	int a[day] = { 0 }, s = 0;
	for (int i = 0; i < day; i++) {
		printf("%d번째 강의에 출석하셨나요?(출석은1, 결석은0) : ",i+1);
		scanf("%d", &a[i]);
		s += a[i];
	}
	double D = day;
	double b;
	b = s / D;
	printf("s = %d\nb = %lf\n", s, b);
	if (b < 0.8) {
		printf("수업 일수 부족입니다(%lf)", b);
	}
	else
		printf("출석률 %lf", b);
	return 0;
}