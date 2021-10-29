data = int(input('정수 입력(종료시는 999) : '))
numbers = []
while data != 999:
    if numbers.count(data) == 0:
        numbers.append(data)
    data = int(input('정수 입력(종료시는 999) : '))
print(numbers)
