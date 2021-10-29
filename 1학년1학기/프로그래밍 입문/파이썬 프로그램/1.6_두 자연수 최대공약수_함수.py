def gcd(m,n):
    while m % n != 0:
        m , n = n, (m%n)
    gcd = n
    return gcd
    
        
a= int(input('a = '))
b = int(input('b= '))
print('최대공약수 : ', gcd(a, b))
