import random
def printMatrix(m):
    for i in range(len(m)):
        for j in range(len(m[i])):
            print(m[i][j],  end=' ')
        print()

def multiplyMatrix(A, B):
    if len(A) == len(B[0]) or len(A[0]) == len(B):
        C = []
        for i in range(len(A)):
            c = []
            for j in range(len(A)):
                c.append(0)
            C.append(c)
        for i in range(len(C)):
            for j in range(len(C)):
                for k in range(len(B)):
                    C[i][j] = C[i][j] + A[i][k]*B[k][j]
                print(C[i][j],end=' ')
            print()   
    else : print('곱셈이 가능하지 않음')
                
L = int(input('L = '))
M = int(input('M = '))
N = int(input('N = '))

A = []
for i in range(L):
    a = []
    for j in range(M):
        a.append(random.randint(-3, 3))
    A.append(a)
B = []
for i in range(M):
    b = []
    for j in range(N):
        b.append(random.randint(-3, 3))
    B.append(b)
    
print()
print('행렬 A')
printMatrix(A)
print()
print('행렬 B')
printMatrix(B)
print()
print('A*B')
multiplyMatrix(A, B)


