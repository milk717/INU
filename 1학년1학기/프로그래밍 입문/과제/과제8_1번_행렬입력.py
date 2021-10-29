N = int(input('N = '))
j = 0
n = 1

for i in range(1,N+1):
    print(i, end=' ')
    i += 1
    j += 1
    if j == n:
        j = 0
        n *= 2
        print()

    
    


        

    
    
