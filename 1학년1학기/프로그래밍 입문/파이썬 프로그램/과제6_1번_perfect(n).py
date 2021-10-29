def perfect(n):
    i = 1
    s = 0
    while i <= n/2:
        if n % i == 0:
            s = s + i
        i = i + 1
    if s < n:
        return 3
    if s == n:
        return 1
    if s > n:
        return 2

while True:
    a = int(input('자연수 a 입력 : '))

    if perfect(a) == 1:
        print('완전수')
    if perfect(a) == 2:
        print('과잉수')
    if perfect(a) == 3:
        print('부족수')

        
