def eratos(a, n):
    a[1] = 0
    for i in range(2, (n//2)+1):
        if(a[i] != 0):
            j = 2 
            while i*j <= n:
                a[i*j] = 0
                j += 1
    return a

n = int(input('정수의 길이를 입력하세요 = '))
a = list(range(n+1))
print(eratos(a,n))