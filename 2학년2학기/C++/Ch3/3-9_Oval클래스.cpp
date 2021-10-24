#include <iostream>
using namespace std;

//선언부
class Oval {
private:
	int width, height;
public:
	Oval();
	Oval(int w, int h);
	~Oval();	//출력하고 소멸
	void show();		//출력
	int getWidth();		//너비 리턴
	int getHeight();	//높이 리턴
	void set(int w, int h);	//변경
};

Oval::Oval() :Oval(1, 1) {}	//위임생성자

Oval::Oval(int w, int h) {	//타겟생성자
	width = w;
	height = h;
}

Oval::~Oval() {
	cout << "Oval 소멸 : width = " << width << ", height = " << height<<endl;
}
void Oval::show() {
	cout << "width = " << width << ", height = " << height << endl;
}

int Oval::getWidth() {
	return width;
}

int Oval::getHeight() {
	return height;
}

void Oval::set(int w, int h) {
	width = w;
	height = h;
}

int main() {
	Oval a, b(3, 4);
	a.set(10, 20);
	a.show();
	cout << b.getWidth() << "," << b.getHeight() << endl;
}