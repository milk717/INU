#include <stdio.h>
int main(void)
{
	int x, y;
	char op;

	printf("수식을 입력하세요\n");
	scanf("%d %s %d", &x, &op, &y);

	if (op == '+')
		printf("%d\n", x + y);
	else if (op == '-')
		printf("%d\n", x - y);
	else if (op == '*')
		printf("%d\n", x * y);
	else if (op == '/')
		printf("%d\n", x / y);
	else
		printf("지원되지 않는 연산자입니다.");
	return 0;
}