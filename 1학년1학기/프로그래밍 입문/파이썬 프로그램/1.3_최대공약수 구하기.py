a = int(input('a = '))
b = int(input('b = '))

i =1
r =0

while i <= a and i <= b:
    if a>b:
        r = a % b
        if r != 0:
            r = b % r
            print(r)
    i = i + 1
     
    
