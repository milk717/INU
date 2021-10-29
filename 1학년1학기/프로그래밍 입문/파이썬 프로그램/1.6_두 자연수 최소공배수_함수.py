def lcm(m, n):
    M, N = m, n
    while M != N:
        if M < N:
            M += m
        else:
            N += n
    lcm = M
    return lcm
    

a = int(input('a = '))
b = int(input('b = '))
print('최소공배수 : ', lcm(a,b))
