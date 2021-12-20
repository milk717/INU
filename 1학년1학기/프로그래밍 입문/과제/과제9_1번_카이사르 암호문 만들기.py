#‘ ’, ‘A’, ‘B’, ‘C’, …, ‘X’, ‘Y’, ‘Z’, ‘a’, ‘b’, ‘c’, …, ‘x’, ‘y’, ‘z’
def encipher(p, k):
    a = ord(p)
    if 64<a<91: #대문자인 경우
        a = a + 6
    if a == 32: #공백인 경우
        a = 70
    t = a + k   #암호화
    if t > 122:
        t = t - 53
    if t == 70:
        t = 32
    if 70<t<97:
        t = t - 6
    return chr(t)
    
while(True):
    k = input('k = ')
    if(k.isdigit()):
        k = int(k)
        break
    else:
        print("양의 정수만 입력해주세요!")

p = input("p = ")
print('\n평문 : ',p)
ciphertext = ''

for i in range(0, len(p)):
    c = encipher(p[i], k)
    ciphertext = ciphertext + c

print("암호문 : [ %s ]"%ciphertext)