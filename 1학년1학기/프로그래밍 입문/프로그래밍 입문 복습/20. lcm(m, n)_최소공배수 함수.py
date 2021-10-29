def lcm(m, n):
    A = a
    B = b
    while A != B:
        if A>B : B += b
        else : A += a
    return B

a = int(input('a = '))
b = int(input('b = '))
print('최소공배수 : ', lcm(a, b))
