#include<iostream>
#include <iomanip>
#include <string>
#include <cstdio>
using namespace std;
int main() {
	int totalSale = 0, order = 0, num = 0;
	string coffee;
	cout << "에스프레소 2000원, 아메리카노 2300원, 카푸치노 2500원"<<'\n';
	do {
		cout << "주문 >> ";
		cin >> coffee >> num;
		if (coffee == "에스프레소") {
			order = 2000*num;
			totalSale += order;
		}
		else if (coffee == "아메리카노") {
			order = 2300 * num;
			totalSale += order;
		}
		else if (coffee == "카푸치노") {
			order = 2500 * num;
			totalSale += order;
		}
		else {
			cout << "잘못된 입력입니다. 다시 입력하세요\n";
			continue;
		}
		cout << order << "원 입니다. 맛있게 드세요"<<'\n';
		order = 0;
	} while (totalSale <= 20000);
	cout << "오늘" << totalSale << "원을 판매하여 카페를 닫습니다. 내일 봐요~~";
}