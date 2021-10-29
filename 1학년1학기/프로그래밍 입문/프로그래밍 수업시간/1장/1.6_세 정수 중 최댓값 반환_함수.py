def max3(x, y, z):
    max3 = z
    if x>y:
        x ,y = x, y
    if y>z:
        y, z = y, z
        return max3

a = int(input('a= '))
b = int(input('b= '))
c = int(input('c= '))
maxval = max3(a,b,c)
print('최대값 : ', maxval)
