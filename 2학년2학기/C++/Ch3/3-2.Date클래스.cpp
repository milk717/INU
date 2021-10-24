#include<iostream>
#include <sstream>
using namespace std;
class Date {
	int year;
	int month;
	int day;
public:
	Date(int year, int month, int day); 
	Date(string str);
	void show();
	int getYear();
	int getMonth();
	int getDay();
};
Date::Date(int year, int month, int day) {
	this->year = year;
	this->month = month;
	this->day = day;
}
Date::Date(string str) {
	this->year = stoi(str.substr(0, 4));
	this->month = stoi(str.substr(5,1));
	this->day = stoi(str.substr(7, 2));
}
void Date::show() {
	cout << year << "년" << month << "월" << day << "일\n";
}
int Date::getYear() {
	return this->year;
}
int Date::getMonth() {
	return this->month;
}
int Date::getDay() {
	return this->day;
}
int main(void) {
	Date birth(2014, 3, 20);
	Date independenceDay("1945/8/15");
	independenceDay.show();
	cout << birth.getYear() << "," << birth.getMonth() << "," << birth.getDay() << endl;
}