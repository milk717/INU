#include <iostream>

using namespace std;

class Statistics{
    int capacity;
    int size;
    int* p;
public:
    Statistics(int n = 10) {
        size = 0; capacity = n;
        p = new int[capacity];
    }
    ~Statistics() {
        if (p)delete[]p;
    }
    bool operator!();
    Statistics& operator<<(int value);
    Statistics& operator>>(int &avg);
    void operator~();
};
bool Statistics::operator!() {
    if (this->size == 0)return true;
    return false;
}
Statistics& Statistics::operator<<(int value) {
    if (size == capacity) {
        capacity *= 2;
        int* q = new int[capacity];
        for (int i = 0; i < size; i++) {
            q[i] = p[i];
        }
        delete[]p;
        p = q;
    }
    this->p[size] = value;
    this->size++;
    return *this;
}
Statistics& Statistics::operator>>(int &avg) {
    int sum = 0;
    for (int i = 0; i < size; i++) {
        sum += this->p[i];
    }
    avg = sum / size;
    return *this;
}
void Statistics::operator~() {
    for (int i = 0; i < size; i++) {
        cout << p[i] << " ";
    }
    cout << "\n";
}

int main() {
    Statistics stat;
    if (!stat) cout << "현재 통계 데이타가 없습니다." << endl;

    int x[5];
    cout << "5 개의 정수를 입력하라>>";
    for (int i = 0; i < 5; i++) cin >> x[i]; // x[i]에 정수 입력 

    for (int i = 0; i < 5; i++) stat << x[i]; // x[i] 값을 통계 객체에 삽입한다. 
    stat << 100 << 200; // 100, 200을 통계 객체에 삽입한다. 
    ~stat; // 통계 데이터를 모두 출력한다. 

    int avg;
    stat >> avg; // 통계 객체로부터 평균을 받는다. 
    cout << "avg=" << avg << endl;  // 평균을 출력한다. 
}
