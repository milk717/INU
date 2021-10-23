#include<iostream>
#include <iomanip>
#include <string>
#include <cstdio>
using namespace std;
int main() {
	char name[100];
	int max = 0, len;
	string longName;
	cout << "5명의 이름을 ';'로 구분하여 입력하시오.\n>>";
	for (int i = 0; i < 5; i++) {
		cin.getline(name, 100, ';');
		cout << i+1 << " : " << name << '\n';
		len = strlen(name);
		longName = (max < len ? name : longName);
		max = (max < len ? len : max);
	}
	cout << "가장 긴 이름은 " << longName;
}