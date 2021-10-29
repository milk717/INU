import random
def longestSequence(num):
    
    
n = int(input('난수의 개수 입력 : '))
numbers = []
for i in range(n):
    x = random.randint(1,n)
    if numbers.count(x) == 0:
        numbers.append(x)
numbers.sort()
print('리스트 : ', numbers)
