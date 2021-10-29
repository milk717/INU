#include <iostream>
using namespace std;

//클래스 선언
class Account {
public:
	string Name;
	int ID, Money;
	Account(string name, int id, int money);
	void deposit(int money);
	string getOwner();
	int inquiry();
	int withdraw(int money);
};

//생성자 생성
Account::Account(string name, int id, int money) {
	Name = name;
	ID = id;
	Money = money;
}

//저금
void Account::deposit(int money) {
	Money += money;
}

//주인이름
string Account::getOwner() {
	return Name;
}

//잔액
int Account::inquiry() {
	return Money;
}

//출금
int Account::withdraw(int money) {
	Money -= money;
	return Money;
}

int main() {
	Account a("kitae", 1, 5000);
	a.deposit(50000);
	cout << a.getOwner() << "의 잔액은 " << a.inquiry() << endl;
	int money = a.withdraw(20000);
	cout << a.getOwner() << "의 잔액은 " << a.inquiry() << endl;
}