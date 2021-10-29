#include <iostream>
#include <string>
using namespace std;

int main(void) {
	string str;
	char word;
	int sum = 0;

	cout << "100점 짜리 인생을 만들기 위해서 필요한 것: ";
	cin >> str;

	for (int i = 0; i < str.length(); i++) {
		word = str[i];
		sum += word - 96;
	}
	cout <<"당신이 생각하는 " <<str <<"은 " << sum << "점 입니다.";
}