#include<iostream>
using namespace std;
int main() {
	//for문 두 개
	/*for (int i = 0; i < 10; i++) {
		for (int j = 1; j <= 10; j++) {
			cout << 10 * i + j << '\t';
		}
		cout << '\n';
	}*/
	//for문 한 개
	for (int i = 1; i <= 100; i++) {
		cout << i << '\t';
		if (i % 10 == 0) cout << '\n';
	}
	return 0;
}