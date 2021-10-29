def lcm(x, y, z):
    if x > y:
        x, y = y, x
    if  y > z:
        y, z = z, y
    Z = z
    while (Z % x != 0) or (Z % y != 0):
        Z += z
    return Z

a = int(input('a = '))
b = int(input('b = '))
c = int(input('c = '))

print('최소공배수 : ', lcm(a, b, c))
