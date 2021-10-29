def enchiper(p):
    a = ord(p)
    if a==32 : a = 96
    t = a + k
    if t > 122 : t = t - 27
    if t == 96 : t = 32
    return chr(t)

p = input('평문 입력 : ')
k = int(input('k 값 입력(1~26) : '))

s = ''
for i in range(len(p)):
    t = enchiper(p[i])
    s = s + t

print('암호문 출력 : ', '[', end='')
print(s,end='')
print(']')
