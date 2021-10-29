#include "3-10.h"
#include<iostream>
using namespace std;
void main(void) {
	Add a;
	Sub s;
	Mul m;
	Div d;

	int x, y, res;
	char sign;
	while (true) {
		cout << "두 정수와 연산자를 입력하세요>>";
		cin >> x>>y>>sign;
		switch (sign)
		{
		case '+':
			a.setValue(x, y);
			res = a.calculate();
			break;
		case '-':
			s.setValue(x, y);
			res = s.calculate();
			break;
		case '*':
			m.setValue(x, y);
			res = m.calculate();
			break;
		case '/':
			d.setValue(x, y);
			res = d.calculate();
			break;
		default:
			break;
		}
		cout << res << endl;
	}
}