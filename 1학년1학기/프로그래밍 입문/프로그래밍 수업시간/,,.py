def isAnagram(s1, s2):
    n1 = len(s1)
    n2 = len(s2)
    if n1 != n2:
        return False
    list1 = []
    list2 = []
    for i in range(n1):
        list1.append(s1[i])
        list2.append(s2[i])
    list1.sort()
    list2.sort()
    i = 0
    while i <n1:
        if list1[i] != list2[i]:
            return False
        if i == n1:
            return True
        
        
