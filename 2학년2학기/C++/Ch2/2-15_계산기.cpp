#include<iostream>
#include<cstring>
#include<cstdlib>
using namespace std;
int main() {
	char str[100];
	int a,b;
	char* sign;
	while (true) {
		cout << "? ";
		cin.getline(str, 100);
		a = atoi(strtok(str, " "));
		sign = strtok(NULL, " ");
		b = atoi(strtok(NULL, " "));
		if (*sign == '+') {
			cout << a << " + " << b <<" = " << a + b<<endl;
		}
		else if(*sign == '-') {
			cout << a << " - " << b << " = " << a - b << endl;
		}
		else if (*sign == '*') {
			cout << a << " * " << b << " = " << a * b << endl;
		}
		else if (*sign == '/') {
			cout << a << " / " << b << " = " << a / b << endl;
		}
		else if (*sign == '%') {
			cout << a << " % " << b << " = " << a % b << endl;
		}
		else {
			cout << "error";
		}
	}
	
}