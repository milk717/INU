def strintSearch(t, p):
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

t = input('텍스트 : ')
p = input('패턴 입력 : ')
if 
print('패턴을 발견한 위치 : ', strintSearch(t, p))
            
