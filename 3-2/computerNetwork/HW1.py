def factorial(n):
    if(n <= 1): return 1
    else: return n*factorial(n-1)
    
def combination(n, m):
    nCm = 1
    for i in range(m):
        nCm *= (n-i)
    nCm /= factorial(m)
    return nCm

n, m = 22, 21

while True:
    res = 0
    res = sum(combination(n,i)*(0.4**i)*(0.6**(n-i)) for i in range(m,n+1))
    print('사용자수 = {0}, 지연율 = {1}'.format(n, res))
#     print('사용자수 = {0}, 지연율 = {1}'.format(n, format(res,'.50f')))
    if res >= 0.01: break
    n += 1
    