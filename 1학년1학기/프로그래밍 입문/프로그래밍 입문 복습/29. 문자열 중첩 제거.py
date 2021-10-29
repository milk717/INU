def delDup(s):
    a = ' '                                     
    for i in s:                                 
        if a.count(i) == 0:             
            a += i
            print(a)
    print('중복이 제거된 문자열 : ', a)

s = input('s = ')
delDup(s)
