#include <iostream>
#include <string>
using namespace std;
class Circle {
	int radius;
public:
	void setRadius(int radius){
		this->radius = radius;
	}
	double getArea() {
		return (double)radius * (double)radius * 3.14;
	}
};
int main(void) {
	Circle c[3];
	int r,cnt=0;
	for (int i = 0; i < 3; i++) {
		cout << "원 " << i << "의 반지름 >> ";
		cin >> r;
		c[i].setRadius(r);
		if (c[i].getArea() > 100) cnt++;
	}
	cout << "면적이 100보다 큰 원은 " << cnt << "개 입니다.";
}