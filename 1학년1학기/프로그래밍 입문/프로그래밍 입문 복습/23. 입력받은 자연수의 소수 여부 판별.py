N = int(input('N = '))
isPrime = True
i = 2

while (isPrime == True) and (i <= N/2):
    if N%i == 0:
        isPrime = False
    i += 1
    
if isPrime == True:
    print(N, '은 소수입니다')
else:
    print(N, '은 소수가 아닙니다.')
