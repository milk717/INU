#include <stdio.h>
int main(void)
{
	char board[3][3] = { ' ' };
	int x, y, n;
	for (n = 0; n < 9; n++) {
		printf("(x, y)좌표 : ");
		scanf("%d %d", &x, &y);
		if (n + 1 % 2 == 1) 
			board[x][y] = 'O';
		else
			board[x][y] = 'X';
		for (int i = 0; i < 3; i++) {
			printf("---|---|---\n");
			printf(" %c | %c | %c \n", board[i][0], board[i][1], board[i][2]);
		}
		printf("---|---|---\n");
	}
	return 0;
}