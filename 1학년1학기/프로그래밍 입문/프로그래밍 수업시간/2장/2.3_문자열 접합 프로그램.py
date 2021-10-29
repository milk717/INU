c = ord('A') - 1
s = ''
for i in range(6):
    c +=1
    s +=chr(c)


d = ord('1')-1
f = ''
for j in range(5):
    d +=1
    f += chr(d)
print(s+f)
