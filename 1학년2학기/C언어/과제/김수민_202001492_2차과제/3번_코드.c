#include <stdio.h>
#include <string.h>
void reverse(char s[][100], int start, int e)
{
    if (start != e){
        reverse(s, start + 1, e);
        printf("%s ", s[start]);
    }
}

void dic(int size, char s[][100])
{
    for (int k = 0; k < size; k++)
    {
        for (int i = 0; i < size - 1; i++)
        {
            char tmp[20];
            if (strcmp(s[i], s[i + 1]) > 0)
            {
                strcpy(tmp, s[i]);
                strcpy(s[i], s[i + 1]);
                strcpy(s[i + 1], tmp);
            }
        }
    }
}

int main(void)
{
    char st[100], c[20] = " ", C[10][100];
    int word = 0;
    do{
        printf("문장을 입력하세요 : ");
        gets(st, 99);
        int l = strlen(st), i = 0, k = 0;
        for (int i = 0; i < l; i++)
        {
            char c[20] = " ";
            while ((st[i] != ' ') && (st[i] != '\0'))
            {
                c[k] = st[i];
                k++;
                i++;
            }
            c[k] = '\0';
            strcpy(C[word], c);
            word++;
            k = 0;
        }
    } while (word < 4 || word > 10);
    int size = word;
    printf("\n역순으로 출력 : ");
    reverse(C, 0, word);
   
    printf("\n\n알파벳 순으로 출력 : ");
    dic(word, C);
    for (int k = 0; k < size; k++)
        printf("%s ", C[k]);
    printf("\n");
}