def sum_avg(x, y, z):
    global s, p
    s = x + y + z
    p = s/3
    
    
   

a = int(input('a = '))
b = int(input('b = '))
c = int(input('c = '))
sum_avg(a, b, c)
print(' 합 : ', s, '\n', '평균 : ', p)
