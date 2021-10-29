def stringSearch(t, p):
    n, m = len(t), len(p)
    i, j = 0, 0
    while i < n and j < m:
        if t[i] != p[j]:
            i -= j
            j = -1
        i += 1
        j += 1
    if j == m : return i-m
    else : return i

def everySearch(t, p):
    i = 0
    n = len(t)
    T = t
    while i < n:
        r = stringSearch(t, p) + i
        t = T
        if r < n:
            print('패턴을 발견한 위치 : %d'%(r))
        else : print('문자열 탐색 완료')
        t = t[r+len(p):]
        i = r + len(p)

print('텍스트 : ', end='')
f = open('input.txt', 'r')
line = f.readline()
print(line, end='')
p = input('패턴 입력 : ')
everySearch(line, p)
