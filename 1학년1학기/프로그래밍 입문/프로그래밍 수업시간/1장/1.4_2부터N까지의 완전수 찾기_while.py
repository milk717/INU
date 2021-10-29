N = int(input('2 이상의 자연수 입력 : '))

while N <= 1:
    print(N, '은(는) 2 이상의 자연수가 아닙니다. ')
    N = int(input('2 이상의 자연수 입력 : '))

i = 2

while i <= N:
    s = 0
    j = 1
    while j <= i/2:
        if i % j == 0:
            s = s + j
        j = j + 1
    if i == s:
        print(i)
    i = i + 1
