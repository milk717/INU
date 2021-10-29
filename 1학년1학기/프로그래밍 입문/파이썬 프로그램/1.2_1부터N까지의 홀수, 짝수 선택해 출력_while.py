N = int(input('N = '))
C = int(input('홀수/짝수 선택(1 : 홀수, 2 : 짝수) : '))
a = 1

if C == 1:
    while a<N:
        if a % 2 == 1:
            print(a, end = ' ')
        a = a + 1
elif C == 2:
    while a<N:
        if a % 2 == 0:
            print(a, end = ' ')
        a = a + 1
else:
    print('입력 오류')

