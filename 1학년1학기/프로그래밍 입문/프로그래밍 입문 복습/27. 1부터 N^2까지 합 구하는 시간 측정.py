import time

N = int(input('N = '))
s = 0

start = time.time()
for i in range(1,N*N):
    s = s + i
    i = i + 1
end = time.time() - start
print('합계 : ', s)
print('실행시간 : ', end)
