N = int(input('N = '))
C = int(input('홀수/짝수 선택(1:홀수, 2:짝수) : '))
a = 1

if C ==1:
    for a in range (1, N+1):
        if a % 2 ==1:
            print(a)
elif C == 2:
    for a in range (1, N+1):
        if a % 2 == 0:
            print(a)
else:
    print('입력 오류')
    
   
