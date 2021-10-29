#include<iostream>
#include<string>
using namespace std;
int main() {
	int menu,how;
	string info[3] = {"짬뽕","짜장","군만두"};
	cout << "***** 승리장에 오신 것을 환영합니다. *****\n";
	while (true) {
		cout << "짬뽕:1, 짜장:2, 군만두:3, 종료:4>> ";
		cin >> menu;
		if (menu == 4) break;
		if (menu < 1 || menu > 4) {
			cout << "다시 주문하세요!!\n";
			continue;
		}
		cout << "몇인분?";
		cin >> how;
		cout << info[menu-1] << " " << how << "인분 나왔습니다.\n";
	}
	cout << "오늘 영업은 끝났습니다.\n";
}
