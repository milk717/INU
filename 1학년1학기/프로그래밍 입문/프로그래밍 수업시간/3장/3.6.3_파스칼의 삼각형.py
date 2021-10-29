def pascalTriangle(h):
    res = []
    pre = []
    pre.append(1)
    res.append(pre)
    for i in range(1, h):
        cur = []
        cur.append(1)
        for j in range(len(pre)-1):
            cur.append(pre[j]+pre[j+1])
        cur.append(1)
        res.append(cur)
        pre = cur
    return res

h = int(input('높이 h 입력 : '))
res = pascalTriangle(h)
for i in range(len(res)):
    for j in range(len(res[i])):
        print(res[i][j], end=' ')
    print()
