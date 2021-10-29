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

def decipher(c, k):
    a = ord(c)
    if 64<a<91:
        a = a + 6
    if a == 32:
        a = 70
    t = a - k
    if t <70:
        t = t + 53
    if t == 70:
        t = 32
    if 70<t<97:
        t = t - 6
    return chr(t)
    
k = int(input('k = '))
p = 'Abc xyZ aBC XYz'
print('평문 : ',p)
c = ''
for i in range(0, len(p)):
    C = encipher(p[i], k)
    c = c + C
print('암호문 : [',end='')
print(c, end='')
print(']')
d = ''
for j in range(0, len(c)):
    D = decipher(c[j],k)
    d = d + D
print('복호화된 평문 : [',end='')
print(d, end='')
print(']')
    



    
