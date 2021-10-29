def evalTerm(a,x,e):
    r = a*x**e
    return r

a = int(input('a = '))
x = int(input('x = '))
e = int(input('e = '))
print('계산 결과 : ', evalTerm(a,x,e))
