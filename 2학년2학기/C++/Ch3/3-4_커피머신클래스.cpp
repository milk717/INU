#include <iostream>
using namespace std;
class CoffeMachine {
	int coffee;
	int water;
	int sugar;
public:
	CoffeMachine(int coffee, int water, int sugar);
	void show();
	void drinkEspresso();
	void drinkAmericano();
	void drinkSugarCoffee();
	void fill();
};
CoffeMachine::CoffeMachine(int coffee, int water, int sugar) {
	this->coffee = coffee;
	this->water = water;
	this->sugar = sugar;
}
void CoffeMachine::drinkEspresso() {
	this->coffee--;
	this->water--;
}
void CoffeMachine::drinkAmericano() {
	this->coffee--;
	this->water -= 2;
}
void CoffeMachine::drinkSugarCoffee() {
	this->coffee--;
	this->water -= 2;
	this->sugar--;
}
void CoffeMachine::fill() {
	this->coffee = 10;
	this->water = 10;
	this->sugar = 10;
}
void CoffeMachine::show() {
	cout << "커피 머신 상태, 커피:" << this->coffee << "\t물:" << this->water << "\t설탕:" << this->sugar<<endl;
}
int main(void) {
	CoffeMachine java(5, 10, 3);
	java.drinkEspresso();
	java.show();
	java.drinkAmericano();
	java.show();
	java.drinkSugarCoffee();
	java.show();
	java.fill();
	java.show();
}