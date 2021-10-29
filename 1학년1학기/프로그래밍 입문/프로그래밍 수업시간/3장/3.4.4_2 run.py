import random
n = int(input('리스트의 원소 개수 입력 : '))
a = []
for i in range (n):
    a.append(random.randint(1, 100))
print(a)
run = 1
i = 0
while i < n:
    print('run%d : %d'%(run, a[i]), end = ' ')
    while i < i + 1 and a[i] < a[i + 1]:
        print(a[i+1], end=' ')
        i += 1
    run += 1
    i += 1
    print()
