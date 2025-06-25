import math
def is_prime(number):
    if number < 2:
        return False
    
    for i in range(2, math.floor(math.sqrt(number))):
        return False if not number % i else 0
    return True
    

def ask_user():
    while True:
        try:
            number = int(input("What number do you want to test? "))
            if number >= 0:
                return number
            else:
                print("please enter a positive number")
        except:
            print("please enter a positive number")


def test_prime(number):
    pass

def main():
    number = ask_user()
    prime = is_prime(number)
    if prime:
        print(f'{number} is a prime number')
    else:
        print(f'{number} is not a prime')

main()