#include<iostream>
#include <iomanip>
#include <string>
using namespace std;
int nMax(int x, int y) {
	return (x > y) ? x : y;
}
int main() {
	int a, b;
	cout << "두 수를 입력하라 : ";
	cin >> a >> b;
	cout << "큰 수 = ";

	//기본방법
	if (a > b) cout << a << '\n';
	else cout << b << '\n';

	//함수, 삼항연산 사용
	cout << "큰 수 = " << nMax(a, b)<<'\n';

	//삼항연산 사용
	cout << "큰 수 = " << ((a > b) ? a : b);
	return 0;
}