def rotate (a, k):
    n = len(a)
    for i in range(k):
        for j in range(n-1, 0, -1):
            a[j], a[j-1] = a[j-1], a[j]
            print(a)

n = int(input('원소의 개수 : '))
k = int(input('회전 단계수 : '))
a = list(range(1, n+1))
print('원래 리스트 : ', a)
rotate(a, k)
print('회전 리스트 : ', a)
