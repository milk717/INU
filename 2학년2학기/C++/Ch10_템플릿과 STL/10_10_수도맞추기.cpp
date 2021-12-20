#include <iostream>
#include <vector>

using namespace std;
class Nation {
	string nation;
	string capital;
public:
	Nation(string nation = 0, string capital = 0) {
		this->nation = nation;
		this->capital = capital;
	}
	string getNation() {
		return this->nation;
	}
	string getCapital() {
		return this->capital;
	}
};
int main() {

	srand((unsigned int)time(NULL));

	vector<Nation> v;
	v.push_back(Nation("대한민국", "서울"));
	v.push_back(Nation("이탈리아", "로마"));
	v.push_back(Nation("미국", "워싱턴"));
	v.push_back(Nation("스페인", "마드리드"));
	v.push_back(Nation("독일", "베를린"));
	v.push_back(Nation("콜롬비아", "보고타"));
	v.push_back(Nation("일본", "도쿄"));
	v.push_back(Nation("캐나다", "오타와"));
	v.push_back(Nation("영국", "런던"));

	cout << "***** 나라의 수도 맞추기 게임을 시작합니다. *****\n";

	while (true) {
		int num;
		cout << "정보 입력: 1, 퀴즈: 2, 종료 3 >> ";
		cin >> num;
		switch (num)
		{
		case 1:
			cout << "현재 " << v.size() << "개 나라가 입력되어 있습니다.\n";
			cout << "나라와 수도를 입력하세요(no no 이면 입력 끝)\n";
			for (int index = v.size() + 1;; index++) {
				int check = 1;
				string nation, capital;
				cout << index << ">>";
				cin >> nation >> capital;
				if (nation == "no" && capital == "no") break;
				for (int i = 0; i < v.size(); i++) {
					if (v.at(i).getNation() == nation) {
						cout << nation << "은 이미 존재합니다.\n";
						check = 0;
						index--;
						break;
					}
				}
				if (!check) continue;
				v.push_back(Nation(nation, capital));
			}
			break;
		case 2:
			int random;
			while (true) {
				string capital;
				random = rand() % v.size();
				cout << v.at(random).getNation() << "의 수도는?";
				cin >> capital;
				if (capital == "exit") break;
				else if (v.at(random).getCapital() == capital) cout << "Correct !!\n";
				else cout << "No !!\n";
			}
			break;
		case 3:
			cout << "게임을 종료합니다. Bye Bye~!\n";
			return 0;
		default:
			cout << "1-3사이의 수를 입력하세요.\n";
			break;
		}
	}
}