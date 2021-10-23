#include<iostream>
#include<string>
using namespace std;

int main() {
	int age;
	string name, adress;
	cout << "이름은?";
	getline(cin, name);
	cout << "주소는?";
	getline(cin, adress);
	cout << "나이는?";
	cin >> age;
	cout << name << ", " << adress << ", " << age;
}