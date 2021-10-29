#include <iostream>
#include <string>
using namespace std;
class Sample {
	int* p;
	int size;
public:
	Sample(int n) {
		size = n;
		p = new int[n];		//n개 정수 배열 동적 생성
	}
	void read() {
		for (int i = 0; i < size; i++) {
			cin >> p[i];
		}
	}
	void write() {
		for (int i = 0; i < size; i++) {
			cout << p[i]<<' ';
		}
		cout << endl;
	}
	int  big() {
		int max = p[0];
		for (int i = 0; i < size; i++) {
			max = (max < p[i] ? p[i] : max);
		}
		return max;
	}
};
int main(void) {
	Sample s(10);
	s.read();
	s.write();
	cout << "가장 큰 수는 " << s.big() << endl;
}