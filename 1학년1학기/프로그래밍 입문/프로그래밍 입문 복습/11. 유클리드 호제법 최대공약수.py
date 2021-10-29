a = int(input('a = '))
b = int(input('b = '))

while a%b != 0 : a, b = b, a%b
print('최대공약수 : ', b)
