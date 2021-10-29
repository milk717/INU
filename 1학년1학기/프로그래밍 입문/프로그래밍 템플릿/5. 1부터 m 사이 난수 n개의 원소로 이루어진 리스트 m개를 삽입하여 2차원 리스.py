import random
m = int(input('m = '))
n = int(input('n = '))

a = []
for i in range(m):
    b = []
    for j in range(n):
        b.append(random.randint(1,m))
    a.append(b)
print(a)
