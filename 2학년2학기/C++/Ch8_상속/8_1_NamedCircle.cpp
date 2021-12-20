#include <iostream>

using namespace std;

class Circle {
    int radius;
public:
    Circle(int radius = 0) { this->radius = radius; }
    int getRadius() { return radius; }
    void setRadius(int radius) { this->radius = radius; }
    double getArea() { return 3.14 * radius * radius; }
};
class NamedCircle :Circle {
    string name;
public:
    NamedCircle(int radius, string name);
    void show();
};
NamedCircle::NamedCircle(int radius, string name):Circle(radius) {
    this->name = name;
}
void NamedCircle::show() {
    cout << "반지름이 " << this->getRadius() << "인 " << this->name<<endl;
}
int main() {
    NamedCircle waffle(3, "waffle");
    waffle.show();
}
