import math
def is_prime(number):
    if number < 2:
        return False
    
    for i in range(2, math.floor(math.sqrt(number)) + 1):
        if number % i == 0:
            return False
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
    primes = []
    
    for i in range(2, number):
        if is_prime(i):
            primes.append(i)
    print(primes)

def main():
    test_prime(100)

    number = ask_user()
    prime = is_prime(number)
    if prime:
        print(f'{number} is a prime number')
    else:
        print(f'{number} is not a prime')

#main()




#class examples

#loop types
def simple_loop():
    numbers = 10
    sum = 0
    fac = 1
    pow = 1

    for i in range(1, numbers + 1):
        sum += i
        fac *= i
        pow *= 2


    print(sum)
    print(fac)
    print(pow)

def event_controlled():
    pass

def sentinel_loop():
    pass


#print triangle
def nested_loop():
    numbers = 10
    count = 0
    for count in range(0, numbers, 2):
        print()
        for n in range(1, count):
            print('*', end='')
#nested_loop()