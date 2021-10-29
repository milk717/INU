#include <iostream>
#include <cstdlib>
using namespace std;

class SelectableRandom {
public:
	int Selectnext(int OE);
	int SelectnextInRange(int a, int b, int OE);	//OE: 0은짝수 1은홀수
};

int SelectableRandom::Selectnext(int OE) {
	int random = rand();
	if (OE) return (random % 2 == 1 ? random : Selectnext(OE));	//홀수일때
	else return (random % 2 == 0 ? random : Selectnext(OE));	//짝수일때
}

int SelectableRandom::SelectnextInRange(int a, int b,int OE) {
	int random = rand() % (b + 1 - a) + a;
	if (OE) return (random % 2 == 1 ? random : SelectnextInRange(a,b,OE));	//홀수일때
	else return (random % 2 == 0 ? random : SelectnextInRange(a, b, OE));	//짝수일때
}

int main() {
	SelectableRandom r;
	cout << "-- 0에서 " << RAND_MAX << "까지의 랜덤 정수 10개--" << endl;
	for (int i = 0; i < 10; i++) {
		int n = r.Selectnext(0);
		cout << n << ' ';
	}
	cout << endl << endl << "-- 2에서 " << "4 까지의 랜덤 정수 10 개 --" << endl;
	for (int i = 0; i < 10; i++) {
		int n = r.SelectnextInRange(2, 9, 1);
		cout << n << ' ';
	}
	cout << endl;
}