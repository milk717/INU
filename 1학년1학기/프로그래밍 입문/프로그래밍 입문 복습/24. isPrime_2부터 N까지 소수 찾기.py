def isPrime(n):
    for i in range(2, int(n/2+1)):
        if n % i == 0:
            return False
    return True

N = int(input('N = '))
for i in range(2, N+1):
    if isPrime(i):
        print(i, end=' ')
