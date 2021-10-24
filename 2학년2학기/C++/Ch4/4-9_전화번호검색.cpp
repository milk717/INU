#include <iostream>
#include <string>
using namespace std;
class Person {
	string name;
	string tel;
public:
	Person() {};	//생성자 그냥쓸거면 {}써주기
	string getName() { return name; }
	string getTel() { return tel; }
	void set(string name, string tel) {
		this->name = name;
		this->tel = tel;
	}
};
int main(void) {
	Person p[3];
	string name, tel;
	cout << "이름과 전화번호를 입력해 주세요\n";
	for (int i = 0; i < 3; i++) {
		cout << "사람 " << i+1<<">> ";
		cin >> name >> tel;
		p[i].set(name, tel);
	}
	cout << "모든 사람의 이름은";
	for (int i = 0; i < 3; i++) {
		cout<< p[i].getName()<<' ';
	}
	cout << "\n전화번호 검색합니다. 이름을 입력하세요>>";
	cin >> name;
	for (int i = 0; i < 3; i++) {
		if (name == p[i].getName()) {
			tel = p[i].getTel();
			break;
		}
	}
	cout << "전화 번호는 " << tel;
}