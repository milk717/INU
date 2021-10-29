def rotate (nums, k, n):
    r = list(range(1,n+1))
    for i in range(0, k):
        r[i] = nums[n-k+i]
    j = 0
    for i in range(k, n):
        r[i] = nums[j]
        j = j + 1
    return r
    

N = int(input('원소의 개수 : '))
k = int(input('회전 단계수 : '))
nums = list(range(1,N+1))
r = []
r = rotate(nums, k, N)

print('원래 리스트 : ', nums)
print('회전 리스트 : ', r)
