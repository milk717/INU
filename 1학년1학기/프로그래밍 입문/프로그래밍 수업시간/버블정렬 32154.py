def bubbleSort(a,n):
    for i in range(n, 1, -1):
        for j in range(1, i):
            if a[j] > a[j+1]:
                a[j], a[j+1] = a[j +1], a[j]
    return a

a = [-1, 3, 2, 1, 5, 4]
print(a)
b = bubbleSort(a,len(a)-1)
print(b)

