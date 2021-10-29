def binarySearch(nums, key):
    low = 0
    high = len(nums)-1
    while low <= high:
        mid = int((low + high)/2)
        if key == nums[mid] : return mid
        if key > nums[mid]:
            low = mid + 1
        else : high = mid - 1
    return -1


n = int(input('데이터의 개수 입력 : '))
nums = []
for i in range(1, n+1):
    nums.append(i)
print('리스트 : ', nums)
key = int(input('탐색 키 입력 : '))
R = binarySearch(nums, key)
if R == -1:
    print('탐색 키와 동일한 원소가 없습니다. ')
else : print('리스트의 ', R+1, '번째 원소')
        
