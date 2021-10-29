#include <iostream>
using namespace std;
int numberAlpha[26];
int main(void) {
	char buf[10000];
	int lenAlpha=0;
	cout << "영문 텍스트를 입력하세요. 히스토그램을 그립니다.\n";
	cout << "텍스트의 끝은 ; 입니다. 10000개까지 가능합니다.\n";
	cin.getline(buf, 10000, ';');
	for (int i = 0; i < strlen(buf); i++) {
		buf[i] = tolower(buf[i]);
		if (isalpha(buf[i])) {
			lenAlpha++;
			numberAlpha[buf[i] - 97]++;
		}
	}
	cout << "총 알파벳 수 " << lenAlpha<<endl;
	for (int i = 0; i < 26; i++) {
		cout << char('a' + i) << " (" << numberAlpha[i] << ")\t: ";
		for (int j = 0; j < numberAlpha[i]; j++) {
			cout << "*";
		}
		cout << "\n";
	}
}