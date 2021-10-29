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
            
def multiplyPoly(A, B):
    Re = []
    if len(A)<len(B):
        A, B = B, A
    for i in range(len(A)):
        for j in range(len(B)):
            re = []
            re.append(A[i][0]+B[j][0])
            re.append(A[i][1]*B[j][1])
            Re.append(re)
    t = []
    Res=[]
    for i in range(len(Re)):
        j = 1
        while i+j < len(Re):
            if Re[i][0] == Re[i+j][0]:
                res = []
                res.append(Re[i][0])
                res.append(Re[i][1]+Re[i+j][1])
                Res.append(res)
                t.append(Re[i][0])
                break
            j += 1
    for i in range(len(Re)):
        if t.count(Re[i][0]) == 0:
            res=[]
            res.append(Re[i][0])
            res.append(Re[i][1])
            Res.append(res)
    Res.sort()
    Res.reverse()
    printPoly(Res)
        
        
A = [[5, 3], [3, 5], [1, 4], [0, 2]]
B = [[5, 2], [2, 4], [1, 3]]
print('A = ',end='')
printPoly(A)
print()
print('B = ',end='')
printPoly(B)
print()
print('A * B = ',end='')
multiplyPoly(A, B)
