import random
N = int(input('N = '))
a = []
while len(a) <= N:
    a.append(random.randint(1, N))
print(a)
