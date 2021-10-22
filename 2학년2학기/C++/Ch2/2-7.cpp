#include<iostream>
#include <iomanip>
#include <string>
#include <cstdio>
using namespace std;
int main() {
	string str;
	do {
		cout << "종료하고 싶으면 yes를 입력하시오 ";
		cin >> str;
	} while (str != "yes");
	cout << "종료합니다.";
	return 0;
}