#include<iostream>
#include <iomanip>
#include <string>
#include <cstdio>
using namespace std;
int main() {
	char c[100];
	int cnt = 0, i = 0;
	cout << "문자를 입력하라 (단 100자 이내)" << '\n';
	cin.getline(c, 100, '\n');//엔터 만나기전까지 입력받겠다.
	while (true) {
		if (c[i] == '\0') break;
		if (c[i] == 'x') cnt++;
		i++;
	}
	cout << "X의 개수는 = " << cnt;
}