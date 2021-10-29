import random
def twoSumSorted(a, n):
    m = len(a)
    for i in range(m):
        for j in range(i+1, m):
            s = a[i] + a[j]
            if s==n:
                print(i+1,'번째와 ',j+1, '번째 원소')

N = int(input('리스트의 원소 개수 입력 : '))
num = []
for i in range(N):
    num.append(random.randint(1,2*N))
num.sort()
print('정렬된 리스트 : ', num)

a = []
for i in range(len(num)):
    if a.count(num[i]) == 0:
        a.append(num[i])
print('중복이 제거된 리스트 :', a)

n = int(input('목표값 입력 : '))
print('두 수의 합이 %d인 원소 쌍'%(n))
twoSumSorted(a, n)
        
