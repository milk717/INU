import random
N = int(input('N = '))
s = set()
for i in range(1, N + 1):
    s.add(random.randint(1, N))
print('s = ', s)

print('집합에 없는 원소 : ',end='')
for j in range(1, N+1):
    if j not in s:
        print(j, end=' ')

        


        
