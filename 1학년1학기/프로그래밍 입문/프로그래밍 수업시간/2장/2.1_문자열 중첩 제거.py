def delDup(x):
    a = ''
    for i in x:
        if a.count(i) == 0:
            a = a + i
    print('중복이 제거된 문자열 : ', a)


s = (input('s = '))

delDup(s)

