N = int(input('N = '))

a = list(range(N+1))


i = 2
a[1]=0
while i <= N/2:
    j = 2
    while i*j <= N:
        a[i*j] = 0
        j +=1
    i += 1

for i in range(1,N+1):
    if a[i] : print(a[i], end= ' ')
