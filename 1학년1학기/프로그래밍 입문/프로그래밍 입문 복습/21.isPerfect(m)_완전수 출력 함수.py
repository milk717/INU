def isPerfect(m):
    s = 0
    for j in range(1,int(m/2+1)):
        if m%j==0:
            s += j
    if s==m:
        return True
    else:
        return False

N = int(input('N = '))
for i in range(1, N+1):
    if isPerfect(i):
        print(i, end= ' ')
        
        
