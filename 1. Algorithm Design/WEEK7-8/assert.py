import math

def my_assert(expression, message, code):
    if not expression:
        print('fAssert Failed')
        print(f'Assert Message {message}')
        print(f'Assert Error Code {code}')
        exit(1)


def calculate_circle_area(radius):
    assert radius > 0
    assert type(radius) == type(0.0)
    assert radius != None 

    area = math.pi * radius * radius
    assert area > 0.0
    assert type(area) == type(0.0)

    return area

def obtain_user_radius():
    done = False

    while not done:
        try:
            radius = float(input('Please input a radius which is > 0: '))
            if radius >=0:
                done = True
            else:
                pass
        except (TypeError, ValueError):
            print('Invalid Input.')
        
    return radius

def main():
    if __debug__:
        my_assert(1>2, "Hey Bob", "49.2.3")
    
    radius = obtain_user_radius()
    calculate_circle_area(radius)

main()

