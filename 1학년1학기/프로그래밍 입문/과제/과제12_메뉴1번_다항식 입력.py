def inputPoly():
    P = []
    ex = 0
    exp = []
    while ex >= 0:
        ex = int(input('지수 : '))
        co = int(input('계수 : '))
        if exp.count(ex) == 0:
            if ex < 0 : break
            exp.append(ex)
            p = []
            p.append(ex)
            p.append(co)
            P.append(p)
        else : print('같은 지수 값을 가지는 원소가 있습니다.')
    P.sort()
    P.reverse()
    return P

print('다항식 리스트 : ', inputPoly())
        
        
        
