def fact(n):
    i = 1
    s = 1
    while i <= n:
        s = s * i
        i += 1
    return s

N = int(input('N = '))
print('N! = ', fact(N))
