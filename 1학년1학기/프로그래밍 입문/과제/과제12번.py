def inputPoly():
    P = []
    ex = 0
    exp = []
    while ex >= 0:
        ex = int(input('지수 : '))
        co = int(input('계수 : '))
        if exp.count(ex) == 0:
            if ex < 0 : break
            exp.append(ex)
            p = []
            p.append(ex)
            p.append(co)
            P.append(p)
        else : print('같은 지수 값을 가지는 원소가 있습니다.')
    P.sort()
    P.reverse()
    return P
    
def printPoly(p):
    for i in range (len(p)):
        if p[i][1] == 0: continue
        if p[i][0] == 0:
            print(p[i][1], end = '')
        elif p[i][1] == 1: print('x^{}'.format(p[i][0]), end=' ')
        elif p[i][1] == -1 : print('-x^{}'.format(p[i][0]), end=' ')
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
    
m = 1
while m != 9:
    print('1. 다항식 입력')
    print('2. 다항식 출력')
    print('3. 다항식 계산')
    print('4. 다항식 덧셈')
    print('5. 다항식 곱셈')
    m = int(input('메뉴 선택 (종료시는 9) : '))
    if m == 1:
        print('다항식 입력 선택\n')
        p = inputPoly()
        print('다항식 리스트 : ', p,'\n')
    elif m == 2:
        print('다항식 출력 선택\n')
        print('다항식 리스트 : ',p)
        print('다항식 = ',end='')
        printPoly(p)
        print('\n')
    elif m == 3:
        print('다항식 계산 선택\n')
        print('다항식 : ',end='')
        printPoly(p)
        print()
        x = int(input('X = '))
        print('계산 결과 : ',evalPoly(p, x))
        print()
    elif m == 4:
        print('다항식 덧셈 선택\n')
        print('첫 번째 다항식을 입력하세요')
        A = inputPoly()
        print('두 번째 다항식을 입력하세요')
        B = inputPoly()
        print('A = ',end='')
        printPoly(A)
        print()
        print('B = ',end='')
        printPoly(B)
        print()
        print('A + B = ',end='')
        addPoly(A, B)
        print('\n')
    elif m == 5:
        print('다항식 곱셈 선택\n')
        print('첫 번째 다항식을 입력하세요')
        A = inputPoly()
        print('두 번째 다항식을 입력하세요')
        B = inputPoly()
        print('A = ',end='')
        printPoly(A)
        print()
        print('B = ',end='')
        printPoly(B)
        print()
        print('A * B = ',end='')
        multiplyPoly(A, B)
        print('\n')
    else:
        if m != 9:
            print('메뉴 선택 오류\n')
