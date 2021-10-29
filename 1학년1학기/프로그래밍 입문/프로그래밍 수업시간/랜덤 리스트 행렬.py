import random
def printMatrix(m):
    for i in range(len(m)):
        for j in range(len(m[i])):
            print(m[i][j],  end=' ')
        print()

def randomMatrix(N,M):
    a = []
    for i in range(M):
        b = []
        for j in range(N):
            b.append(random.randint(0,3))
        a.append(b)
    printMatrix(a)
    


N = int(input('N = '))
M = int(input('M = '))
randomMatrix(N,M)

