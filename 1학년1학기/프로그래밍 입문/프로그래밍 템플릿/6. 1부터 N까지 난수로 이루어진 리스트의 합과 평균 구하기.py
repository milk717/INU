import random
N = int(input('N = '))
a = []
s = 0
while len(a) < N:
    b = random.randint(1, N)
    a.append(b)
    s = s + b
p = s/N
print(a)
print('합 : ', s, '평균 : ', p)
    


