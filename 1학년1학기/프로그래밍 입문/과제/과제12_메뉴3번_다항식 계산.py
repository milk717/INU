def printPoly(p):
    for i in range (len(p)):
        if p[i][1] == 0:
            continue
        if p[i][0] == 0:
            print(p[i][1], end = '')
        elif p[i][0] == 1: print('{}x'.format(p[i][1]), end=' ')
        else : print('{}x^{}'.format(p[i][1], p[i][0]), end=' ')
        if i < len(p)-1:
            if p[i+1][1] > 0 :
                print('+', end = ' ')
                
def evalPoly(p, x):
    s = 0
    for i in range(len(p)):
        s += p[i][1]*x**p[i][0]
    return s

p = [[5, 3], [3, 5], [1, 4], [0, 2]]
print('다항식 = ', end='')
printPoly(p)
print()
x = int(input('X = '))
print('계산 결과 : ', evalPoly(p, x))
