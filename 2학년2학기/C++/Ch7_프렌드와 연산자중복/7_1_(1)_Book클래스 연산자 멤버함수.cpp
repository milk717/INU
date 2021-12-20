#include <iostream>

using namespace std;

class Book {
	string title;
	int price,pages;
public:
	Book(string title = "", int price = 0, int pages = 0) {
		this->title = title;
		this->price = price;
		this->pages = pages;
	}
	void show() {
		cout << title << ' ' << price << "원" << pages << " 페이지" << endl;
	}
	string getTitle() { return title; }

	Book& operator+= (int a);		//연산자 함수 선언.자기자신의 포인터를 리턴할꺼기때문에 리턴타입 &
	Book& operator-= (int a);
};
Book& Book::operator+=(int a) {
	price += a;
	return *this;
}
Book& Book::operator-=(int a) {
	price -= a;
	return *this;
}
int main() {
	Book a("청춘", 20000, 300), b("미래", 30000, 500);
	a += 500;
	b -= 500;
	a.show();
	b.show();
}
