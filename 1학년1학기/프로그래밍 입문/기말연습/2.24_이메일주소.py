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
    R = []
    while i < n:
        r = stringSearch(t, p) + i
        t = T
        if r < n:
            R.append(r)
        t = t[r+len(p):]
        i = r + len(p)
    return R

f = open('email.txt', 'r')
t = f.read()
p = 'mailto:'
R = everySearch(t, p) #mailto 위치 리스트
pp = '">'
RR = everySearch(t, pp) #이메일 끝나는 위치
for i in range(len(R)):
    o = R[i]+7
    tw = RR[i]
    print(t[o:tw])
