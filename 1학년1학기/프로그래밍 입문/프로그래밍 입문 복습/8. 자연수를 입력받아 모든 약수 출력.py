a = int(input('a = '))
while a<1:
    print(a,'은 자연수가 아닙니다.')
    a = int(input('a = '))

for i in range(1, int(a/2)+1):
    if a % i == 0 : print(i,end=' ')

