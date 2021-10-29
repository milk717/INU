def evalTerm(a, x, e):
    i = 1
    s = 1
    for i in range(1, e+1):
        s = s * x
    s = s *a
    return s

a = int(input('a = '))
x = int(input('x = '))
e = int(input('e = '))

R = evalTerm(a, x, e)
print('계산 결과 : ', R)
