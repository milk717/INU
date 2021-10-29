import random
def longestSequence(num):
    s = set()
    max_len = 1
    n = len(num)
    for i in range(n):
        s.add(num[i])
    for i in range(n):
        left = num[i] - 1
        right = num[i] + 1
        count = 1
        while left in s:
            count += 1
            s.remove(left)
            left -= 1
        while right in s:
            count += 1
            s.remove(right)
            right += 1
        if max_len < count:
            max_len = count
        return (s, max_len)

N = int(input('난수의 개수 입력 : '))
num = []
for i in range(1, N+1):
    num.append(random.randint(1, N))
R = longestSequence(num)
print('리스트 : ', num)
print('집합 : %s \n최장 연속 순차의 길이 : %d '%(R[0], R[1]))
        
            
    
