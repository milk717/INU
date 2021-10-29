N = int(input('N = '))


for i in range(2,N+1):
    s = 0
    for j in range(1, i):
        if i % j == 0:
            s = s + j
    if s==i:
        print(i)
