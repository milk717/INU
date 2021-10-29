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
                
def addPoly(A, B):
    R = []
    R.extend(A)
    R.extend(B)
    Re = []
    t = []
    for i in range(len(R)):
        j = 1
        while i+j < len(R):
            if R[i][0] == R[i+j][0]:
                re = []
                re.append(R[i][0])
                re.append(R[i][1]+R[i+j][1])
                Re.append(re)
                t.append(R[i][0])
                break
            j += 1
    for i in range(len(R)):
        if t.count(R[i][0]) == 0:
            re=[]
            re.append(R[i][0])
            re.append(R[i][1])
            Re.append(re)
    Re.sort()
    Re.reverse()
    printPoly(Re)

A = [[5, 3], [3, 5], [1, 4], [0, 2]]
B = [[5, 2], [2, 4], [1, 3]]
print('다항식 A = ',end='')
printPoly(A)
print()
print('다항식 B = ',end='')
printPoly(B)
print()
print('A + B = ',end='')
addPoly(A,B)

