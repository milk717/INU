def bubbleSort(a,n):
    for i in range(n, 1, -1):
        for j in range(1, i):
            if a[j] > a[j+1]:
                a[j], a[j+1] = a[j +1], a[j]
    return a

import random, time
N = 3000
a = []
a.append(-1)
for i in range(1, N+1):
    a.append(i)
start_time = time.time()
b = bubbleSort(a, N)
end_time = time.time() - start_time
print(end_time)
