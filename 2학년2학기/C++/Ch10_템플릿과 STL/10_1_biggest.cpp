#include <iostream>

using namespace std;

template <class T>
T biggest(T * x, int size){
    T max = x[0];
    for (int i = 0; i < size; i++) {
        max = (max < x[i] ? x[i] : max);
    }
    return max;
}
int main() {
    int x[] = { 1,10,100,5,4 };
    double d[] = { 1.0,2.0,7.17 };
    cout << biggest(x, 5) << endl;
    cout << biggest(d, 3) << endl;
}

