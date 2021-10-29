def encipher(p):
    a = ord(p)
    if a == 32:
        a = 96
    t = a + k
    if t > 122:
        t = t - 27
    if t < 96:
        t = t + 95
    if t == 96:
        t = 32
    return chr(t)

def decipher(c):
    a = ord(c)
    if a == 32:
        a = 96
    t = a - k
    if t < 97:
        t = t + 27
    if t == 96:
        t = 32
    return chr(t)

p = input('평문 입력 : ')
k = int(input('K값 입력 : '))
while k < 1 or k > 26:
    k = int(input('K 값 입력(1~26) : '))
n = len(p)

c = ' '
for i in range(n):
    ch = encipher(p[i])
    c = c + ch
print('암호문 : [', end='')
print(c, end='')
print(']')

q = ' '
for i in range(n):
    ch = decipher(c[i])
    q = q + ch
print('복호화된 평문 : [', end='')
print(q, end='')
print(']')


