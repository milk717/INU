N = int(input('자연수 입력 : '))
a = 1


while N < 1:
        print(N, '은 자연수가 아닙니다.')
        N = int(input('자연수 입력 : '))

print(N, '의 모든 약수', end=' ')
       
if N >= 1:
    for a in range (1, N+1):
        if N % a == 0:
            print(a, end=' ')
    
