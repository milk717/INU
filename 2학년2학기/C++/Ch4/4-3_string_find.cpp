#include <iostream>
#include <string>
using namespace std;

int main(void) {
	string str;
	int cnt=0;
	cout << "문자열 입력 >> ";
	getline(cin, str,'\n');
	for (int i = 0; i < str.length(); i++) {
		if (str.at(i) == 'a') {
			cnt++;
		}
	}
	cout << "문자 a는 " << cnt << "개 있습니다.\n";
	cout << "a의 인덱스는 ";
	for (int i = 0; i < str.length(); i++) {
		i = str.find('a', i);
		cout << i<<' ';
	}
}