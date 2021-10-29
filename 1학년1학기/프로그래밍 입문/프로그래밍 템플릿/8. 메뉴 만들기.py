def menuSelect():
    print('1. 데이터 입력')
    print('2. 데이터 탐색')
    print('3. 데이터 출력')
    print('9. 종료')
    menu = int(input('메뉴 선택 : '))
    return menu

def dataInput():
    print()
    print('데이터 입력 선택')
    print()
    
def dataSearch():
    print()
    print('데이터 탐색 선택')
    print()
    
def dataOutput():
    print()
    print('데이터 출력 선택')
    print()
m = 1
while m != 9:
    m = menuSelect()
    if m == 1: dataInput()
    elif m == 2: dataSearch()
    elif m == 3: dataOutput()
