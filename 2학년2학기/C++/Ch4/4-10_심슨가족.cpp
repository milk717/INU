#include <iostream>
#include <string>
using namespace std;
class Person {
	string name;
public:
	Person() {};
	Person(string name) { this->name = name; }
	string getName() { return name; }
	void setName(string name) {
		this->name = name;
	}
};
class Family {
	Person* p;
	int size;
	string familyName;
public:
	Family(string name, int size) {
		p = new Person [size];
		this->size = size;
		this->familyName = name;
	}
	void show() {
		cout << this->familyName << "가족은 다음과 같이 " << this->size << "명 입니다.\n";
		for (int i = 0; i < this->size; i++) {
			cout<< p[i].getName()<<"\t";
		}
	}
	void setName(int index, string name) {
		p[index].setName(name);
	}
	~Family() {
		delete[] p;
	}
};
int main(void) {
	Family* simpson = new Family("Simpson", 3);
	simpson->setName(0, "Mr. Simpson");
	simpson->setName(1, "Mrs. Simpson");
	simpson->setName(2, "Bart. Simpson");
	simpson->show();
	delete simpson;
}