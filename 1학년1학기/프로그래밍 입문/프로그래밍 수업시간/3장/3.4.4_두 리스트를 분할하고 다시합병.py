def merge(r1, r2):
    n1, n2 = len(r1), len(r2)
    i, j = 0, 0
    R = []
    while i < n1 and j < n2:
        if r1[i] < r2[j]:
            R.append(r1[i])
            i += 1
        else:
            R.append(r2[j])
            j += 1
    if i == n1:
        for k in range(i, n2):
            R.append(r2[k])
    else:
        for k in range(i, n1):
            R.append(r1[k])
    return R

import random
n = int(input('리스트의 원소 개수 입력 : '))
a = []
for i in range(n):
    a.append(random.randint(1, 100))
print('최초 리스트 : ', a)
m = int(n/2)
a1 = []
for i in range(m):
    a1.append(a[i])
a2 = []
for i in range(m, n):
    a2.append(a[i])
a1.sort()
a2.sort()
print('정렬된 첫 번째 리스트 :', a1)
print('정렬된 두 번째 리스트 :', a2)
print('합병된 리스트 : ', merge(a1, a2))
