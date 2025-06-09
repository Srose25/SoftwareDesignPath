import math

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
    radius = obtain_user_radius()
    calculate_circle_area(radius)

main()

