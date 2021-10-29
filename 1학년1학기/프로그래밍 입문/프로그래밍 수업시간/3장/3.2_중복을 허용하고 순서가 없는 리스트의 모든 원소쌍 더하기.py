import random

def twoSum(num, t):
    s = 0
    for i in range(0, len(num)):
        for j in range(i+1, len(num)):
            s = num[i] + num[j]
            if s ==  t:
                print(i+1, '번째와', j+1, '번째 원소')
            

N = int(input('리스트의 원소 개수 입력 : '))
num = []
for i in range(0, N):
    num.append(random.randint(0, N*2))
print('리스트 : ', num)
t = int(input('목표값 입력 : '))
print('두 수의 합이', t, '인 원소 쌍')
twoSum(num, t)
        
