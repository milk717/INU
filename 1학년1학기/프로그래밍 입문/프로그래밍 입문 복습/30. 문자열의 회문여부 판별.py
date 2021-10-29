def isPal(a):
    s = a.lower()
    i = 0
    j = len(s)-1
    while i <= j :
        if  s[i] != s [j] : return False
        i = + 1
        j = - 1
    return True

a = input('문자열 입력 : ')
if isPal(a) : print('회문입니다.')
else : print('회문이 아닙니다.')
                
