def isPrime(a):
    i = 2
    while i <= a/2:
        if a % i == 0:
            return False
        i += 1
    return True

N = int(input('2 이상의 자연수 N 입력 : '))
for i in range (2, N+1):
    if isPrime(i):
        print(i, end=' ')
