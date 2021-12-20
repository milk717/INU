#include <iostream>

using namespace std;

class Book {
	string title;
	int price, pages;
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

	friend bool operator==(Book& book, int op);
	friend bool operator==(Book& book, string str);
	friend bool operator==(Book& bookThis,Book& book);
};
bool operator==(Book& book, int op) {
	if (book.price == op) return true;
	return false;
}
bool operator==(Book& book, string str) {
	if (book.title == str) return true;
	return false;
}
bool operator==(Book& bookThis, Book& book) {
	if (bookThis.title == book.title && bookThis.price == book.price && bookThis.pages == book.pages) return true;
	return false;
}

int main() {
	Book a("명품 C++", 30000, 500), b("고품 C++", 30000, 500);
	if (a == 30000)cout << "정가 30000원" << endl;
	if (a == "명품 C++")cout << "명품 C++ 입니다" << endl;
	if (a == b) cout << "두 책이 같은 책입니다." << endl;
}
