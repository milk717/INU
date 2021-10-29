a = int(input('자연수 a 입력 : '))
b = int(input('자연수 b 입력 : '))
c = int(input('자연수 c 입력 : '))

if a>b : a, b = b, a
if b>c : b, c = c, b

C = c

while C%a!=0 or C%b!=0:
    C+=c
print('최소공배수 : ',C)
