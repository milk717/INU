#include <iostream>
#include <string>
using namespace std;

class Integer {
	int value;
public:
	Integer(int m) { value = m; }
	Integer(string s) { value = stoi(s); }
	void set(int n) { value = n; }
	int get() { return value; }
	bool isEven() { return value % 2 == 0 ? true : false; }
};
int main() {
	Integer n(30);
	cout << n.get() << ' ';
	n.set(50);
	cout << n.get() << ' ';

	Integer m("300");
	cout << m.get() << ' ';
	cout << m.isEven();
}