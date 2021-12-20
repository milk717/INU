#include <iostream>

using namespace std;

class Matrix {
	int arr[4];
public:
	Matrix() { ; }
	Matrix(int a0, int a1, int a2, int a3) {
		arr[0] = a0; arr[1] = a1; arr[2] = a2; arr[3] = a3;
	}
	void show() {
		cout << "Matrix = { ";
		for (int i = 0; i < 4; i++) {
			cout << arr[i] << " ";
		}
		cout << "}\n";
	}
	Matrix operator+(Matrix& b);
	Matrix operator+=(Matrix& b);
	bool operator==(Matrix& b);
};
Matrix Matrix::operator+(Matrix& b) {
	Matrix tmp;
	for (int i = 0; i < 4; i++) {
		tmp.arr[i] = this->arr[i] + b.arr[i];
	}
	return tmp;
}
Matrix Matrix::operator+=(Matrix& b) {
	for (int i = 0; i < 4; i++) {
		this->arr[i] += b.arr[i];
	}
	return *this;
}
bool Matrix::operator==(Matrix& b) {
	for (int i = 0; i < 4; i++) {
		if (this->arr[i] != b.arr[i]) {
			return 0;
		}
	}
	return 1;
}
int main() {
	Matrix a(1, 2, 3, 4), b(2, 3, 4, 5), c;
	c = a + b;
	a += b;
	a.show(); b.show(); c.show();
	if (a == c) {
		cout << "a and c are the same" << endl;
	}
}
