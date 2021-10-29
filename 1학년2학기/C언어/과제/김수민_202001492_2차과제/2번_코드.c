// #include <stdio.h>
// #include <string.h>
// #define WORDS 5

// int main(void)
// {
// 	char dic[WORDS][3][50] =
// 	{ {"book","책","종이를 여러 장 묶어 맨 물건"},
// 		{"boy","소년"," 아직 완전히 성숙하지 아니한 어린 사내아이"},
// 		{"computer","컴퓨터","전자 회로를 이용한 고속의 자동 계산기"},
// 		{"language","언어","생각을 전달하는데 쓰이는 수단"}, 
// 		{"rain","비","땅 위로 떨어지는 물방울"}};
// 	char s[30] = " ";
// 	printf("단어를 입력하시오 : ");
// 	scanf("%s", s);
// 	for (int i = 0; i < WORDS; i++)
// 	{
// 		if ((strcmp(dic[i][0], s) == 0)||(strcmp(dic[i][1],s)==0))
// 		{
// 			printf("%s: %s: %s\n", dic[i][0], dic[i][1], dic[i][2]);
// 			return 0;
// 		}
// 	}
// 	printf("사전에서 발견되지 않았습니다\n");
// }