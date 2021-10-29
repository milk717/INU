s = input('s = ')
a = []
for i in range(26):
    a.append(0)
print(a)

for i in range(len(s)):
    j = ord(s[i])-97
    a[j] += 1
print(a)

