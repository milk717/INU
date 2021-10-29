def encipher(p, k):
    a = ord(p)
    if 64<a<91:
        a = a + 6
    if a == 32:
        a = 70
    t = a + k
    if t > 122:
        t = t - 53
    if t == 70:
        t = 32
    if 70<t<97:
        t = t - 6
    return chr(t)
    

k = int(input('k = '))
p = 'Abc xyZ aBC XYz'
print('평문 : ',p)
C = ''

for i in range(0, len(p)):
    c = encipher(p[i], k)
    C = C + c
print('암호문 : [',end='')
print(C, end='')
print(']')
    



    
