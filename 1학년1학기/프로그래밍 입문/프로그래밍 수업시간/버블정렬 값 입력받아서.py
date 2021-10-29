def bebbleSort(a, n):
    for i in range(n-1, -1, -1):
        for j in range(0, i):
            if a[j] > a[j+1]:
                a[j], a[j+1] = a[j+1], a[j]
        print(a[i])
    return a

import random
N = int(input());
a = []
for i in range(0,N):
    a.append(i)
print(bebbleSort(a, N))
