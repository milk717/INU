import random
def longestSequence(num):
    s = set()
    max_len = 1
    n = len(num)
    alist = []
    maxlist = []
    for i in range(n):
        s.add(num[i])
    print('집합 : ', s)
    for i in range(n):
        left = num[i] - 1
        right = num[i] + 1
        count = 1
        alist.append(num[i])
        while left in s:
            count += 1
            s.discard(left)
            alist.append(num[i])
            left -= 1
        while right in s:
            count += 1
            s.discard(right)
            alist.append(num[i])
            right += 1
        if len(maxlist) < len(alist):
            maxlist = []
            for i in range(len(alist)):
                maxlist.append(alist[i])
        alist = []
        if max_len < count:
            max_len = count
        return (s, max_len, maxlist)

N = int(input('난수의 개수 입력 : '))
num = []
for i in range(1, N+1):
    num.append(random.randint(1, N))
R = longestSequence(num)
print('집합 : %s \n최장 연속 순차의 길이 : %d \n최장 연속 순차 : %s'%(R[0], R[1],R[2]))
        
            
    
