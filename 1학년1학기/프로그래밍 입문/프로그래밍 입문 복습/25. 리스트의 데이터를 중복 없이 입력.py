N = int(input('정수 입력(종료시는 999) : '))
a = []

while N != 999:
    if a.count(N) == 0:
        a.append(N)
    N = int(input('정수 입력(종료시는 999) : '))
print(a)
