import random
def maxMin(N):
    a = []
    for i in range (1, 11):
        a.append(random.randint(1, N))
    maxValue = a[0]
    minValue = a[0]
    for j in range(1, 10):
        if maxValue < a[j]:
            maxValue = a[j]
        if minValue > a[j]:
            minValue = a[j]
    return (maxValue, minValue)

N = int(input('N = '))
result = maxMin(N)
print('최댓값 = %d, 최솟값 = %d'%(result[0], result[1]))
            
