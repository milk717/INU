a = int(input('a = '))
b = int(input('b = '))

def isOdd(i):
        if i%2 == 0:
            return True
        else:
            return False

def isPerfect(n):
    i = 1
    s = 0
    while i <= n/2:
        if n % i == 0:
            s = s + i
        i = i + 1
    if s < n:
        return 3
    if s == n:
        return 1
    if s > n:
        return 2

def isPrime(n):
    for i in range(2, int(n/2+1)):
        if n % i == 0:
            return False
    return True

for i in range(a, b+1):
    if isOdd(i) : h = '짝수'
    else : h = '홀수'
    if isPerfect(i) == 3 : p = '부족수'
    if isPerfect(i) == 2 : p = '완전수'
    if isPerfect(i) == 1 : p = '과잉수'
    if isPrime(i) : s = '소수'
    else : s = '비소수'
    print(i, h, p, s)
    

        
