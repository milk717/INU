def threeSum(a):
    for i in range(len(a)):
        j = i+1
        while i + j < len(a):
            k = i+j+1
            while i + k < len(a):
                if a[i] + a[i+j] + a[i+k] == 0:
                    b = []
                    c = []
                    b.append(a[i])
                    b.append(a[i+j])
                    b.append(a[i+k])
                    c.append(i)
                    c.append(i+j)
                    c.append(i+k)
                    print('세 원소의 합이 0이 되는 세 원소 쌍 및 인덱스 : ', b, c)
                k+= 1
            j+=1

import random
N = int(input('리스트의 원소의 개수 입력 : '))
a = []
for i in range(N):
    a.append(random.randint(-2, 2))
print('리스트 : ', a)
threeSum(a)
