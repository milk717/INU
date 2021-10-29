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
N = int(input('첫 번째 리스트의 원소 개수 입력 : '))
M = int(input('두 번째 리스트의 원소 개수 입력 : '))
r1 = []
r2 = []
for i in range(N):
    r1.append(random.randint(1, 100))
for i in range(M):
    r2.append(random.randint(1, 100))
r1.sort()
r2.sort()
print('정렬된 첫 번째 리스트 : ', r1)
print('정렬된 두 번째 리스트 : ', r2)
print('합병된 리스트 : ', merge(r1, r2))
