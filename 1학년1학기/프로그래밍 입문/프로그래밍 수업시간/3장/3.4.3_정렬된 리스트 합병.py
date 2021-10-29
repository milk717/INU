def merge(r1, r2):
    n = len(r1)
    m = len(r2)
    res = []
    i = 0
    j = 0
    while i<n and j<m:
        if r1[i] > r2[j]:
            res.append(r2[j])
            j += 1
        else:
            res.append(r1[i])
            i += 1
    if i == n:
        for k in range(j, m):
            res.append(r2[k])
    else:
        for k in range(i, n):
            res.append(r1[k])
    return res

import random
num1 = int(input('첫 번째 리스트의 원소 개수 입력 : '))
num2 = int(input('두 번째 리스트의 원소 개수 입력 : '))
run1 = []
run2 = []
for i in range(num1):
    run1.append(random.randint(1,10*num1))
for i in range(num2):
    run2.append(random.randint(1,10*num2))
run1.sort()
run2.sort()
print('정렬된 첫 번째 리스트 : ', run1)
print('정렬된 두 번째 리스트 : ', run2)
R = merge(run1, run2)
print('합병된 리스트 :', R)
