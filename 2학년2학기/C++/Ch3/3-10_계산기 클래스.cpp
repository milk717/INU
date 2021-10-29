#include "3-10.h"
using namespace std;
void Add::setValue(int x, int y) {
	this->x = x;
	this->y = y;
}
int Add::calculate() {
	return x + y;
}

void Sub::setValue(int x, int y) {
	this->x = x;
	this->y = y;
}
int Sub::calculate() {
	return x - y;
}

void Mul::setValue(int x, int y) {
	this->x = x;
	this->y = y;
}
int Mul::calculate() {
	return x * y;
}

void Div::setValue(int x, int y) {
	this->x = x;
	this->y = y;
}
int Div::calculate() {
	return x / y;
}