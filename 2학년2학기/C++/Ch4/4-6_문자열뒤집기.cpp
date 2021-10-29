#include <iostream>
#include <string>
using namespace std;

int main(void) {
	string str;
	cout << "아래에 한 줄을 입력하세요.(exit를 입력하면 종료합니다)\n";
	while(true) {
		cout << ">>";
		getline(cin, str, '\n');
		if (str == "exit") {
			return 0;
		}
		for (int i = 0; i < str.length(); i++) {
			cout << str[str.length() - i-1];
		}
		cout << endl;
	}
}