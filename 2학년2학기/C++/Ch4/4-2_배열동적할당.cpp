#include <iostream>
#include <string>
using namespace std;

int main(void) {
	int* arr = new int[5];
	if (!arr) return 0;
	float mean = 0;

	cout << "정수 5개 입력>>";
	for (int i = 0; i < 5; i++) {
		cin >> arr[i];
		mean += arr[i];
	}
	cout << "평균 " << mean / 5;
}