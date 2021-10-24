#include "Ram.h"
#include <iostream>
using namespace std;
Ram::Ram(){
	for (int i = 0; i < 100 * 1024; i++) {
		mem[i] = 0;
	}
	this->size = 100 * 1024;
}
Ram::~Ram(){
	cout << "메모리 제거됨";
}
char Ram::read(int adress) {
	return mem[adress];
}
void Ram::write(int adress, char value) {
	this->mem[adress] = value;
}