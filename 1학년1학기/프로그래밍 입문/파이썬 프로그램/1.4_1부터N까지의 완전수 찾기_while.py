N = int(input('2 이상의 자연수 입력 : '))

while N <= 1:
    print(N, '은(는) 2 이상의 자연수가 아닙니다. ')
    N = int(input('2 이상의 자연수 입력 : '))

a = 2

while a <= N:
    s = 0
    i = 1
    while i <= a/2:
        if a % i == 0:
            s = s + i
        i = i + 1
    if a == s:
        print(a)
    a = a + 1
