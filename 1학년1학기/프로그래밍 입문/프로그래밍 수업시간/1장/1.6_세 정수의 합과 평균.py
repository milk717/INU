def sum_avg(a, b, c):
    global s, p
    s = a + b + c
    p = s/3

a = int(input('a = '))
b = int(input('b = '))
c = int(input('c = '))

s = 0
p = 0

sum_avg(a, b, c)
print(' 합 : ', s, '\n' ,'평균 : ', p)
