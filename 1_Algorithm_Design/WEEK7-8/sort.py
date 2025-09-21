# 1. Name:
#      -your name-
# 2. Assignment Name:
#      Lab 08: Sort
# 3. Assignment Description:
#      -This program takes a json file and is able to read it, take the data from it,
#       and sort it from least to greatest. This could be in numbers as well as letters
#       as the tests will demonstrate. It uses a Selection Sorting Algorithm to do this-
# 4. What was the hardest part? Be as specific as possible.
#      -At first I thought we needed to make the entire program in be done in one fell swoop.
#       However, once we started using functions in class I just couldn't help myself. With 
#       how big this program is I had to make it modular. The hardest part was focusing on efficiency
#       while still having this modular design. I hope it still meets the requirements. The second
#       hardest thing why this one was so hard is I wanted to take what we did in class and do my own
#       thing with it. I made my own assert function to help me out in the future. I also had a hard time
#       creating asserts that don't unintentionally trigger the assert because of the way my code is set up.-
# 5. How long did it take for you to complete the assignment?
#      -It took me about 3 hours creating the bulk of the code and having it be modular with the rest of the
#       program. Part of that was also creating the my_assert() function and the test() function. Another hour
#       was then spent on going over the code and making sure everything was optimized and double checking the
#       way the asserts were placed and working so they can do their job right. The last 30 minutes was spent
#       creating the video.-


#My Updated Pseudocode
#A
#FOR currentNumber in numberList - 1:
#    smallestNumber = currentNumber  #This by default sets the smallest number to the number we start on.
#
#    B
#    FOR check from currentNumber + 1 to length of numberList - 1: #Check our number to the end of the list.
#        
#        
#        IF numberList[check] < numberList[smallestNumber]:        #Check if our current number is smaller than
#            
#            
#            smallestNumber = check                                #the one we started on.
#
#    C
#    IF smallestNumber != currentNumber: #If the number we checked is smaller than our original number the swap them.
#        SWAP numberList[currentNumber] and numberList[smallestNumber]


import json

import traceback
import inspect
import os

COUNTER1 = 0


#Test function
def test():
    my_assert(sort([5, 3, 2, 1]) == [1, 2, 3, 5], "List did not sort correctly")
    my_assert(sort([]) == [], "Empty list test failed")
    my_assert(sort([1]) == [1], "Single item test failed")
    my_assert(sort([2, 2, 2]) == [2, 2, 2], "All equal values test failed")
    my_assert(sort([-1, -5, 3, 0]) == [-5, -1, 0, 3], "Negative values test failed")

    print("Tests successful! \n")


#Assert function
def my_assert(expression, message):
    if not expression:
        #Print Error Message
        print("Assert Failed")
        print(f'Message: {message}')
        
        # Get the calling frame (where the assert failed)
        caller_frame = inspect.currentframe().f_back
        filename = caller_frame.f_code.co_filename
        function_name = caller_frame.f_code.co_name
        line_no = caller_frame.f_lineno

        # Print Error Info
        print(f"Occurred in file: {filename}")
        print(f"In function: {function_name}()")
        print(f"At line: {line_no}")

        # Print full traceback
        print("\nTraceback (most recent call last):")
        traceback.print_stack(limit=2)

        exit(1)


#Loads the json file
def load(filename, listname):
    full_path = f'1. Algorithm Design/WEEK7-8/tests/{filename}' #My computer is weird ok?
    my_assert(os.path.exists(full_path), f'File: "{full_path}" not found') #File Not Found

    with open(full_path, 'r') as file:
        data = json.load(file)
    my_assert(listname in data, f"Key '{listname}' not found in file {filename}") #List Not Found
    my_assert(isinstance(data[listname], list), f"'{listname}' must be a list") #List is a List
    
    return data[listname]


#Sorting Algorithm
def sort(info):
    global COUNTER1 #my counter is a global variable
    my_assert(isinstance(info, list), "Input must be a list") #info is a List
    for current_item in range(len(info)): #Line 25 has my Pseudocode that this algorithm
        first_item = current_item         #is based on.
        for check in range(current_item + 1, len(info)):
            COUNTER1 += 1
            if info[check] < info[first_item]:
                first_item = check
        if first_item != current_item:
            info[current_item], info[first_item] = info[first_item], info[current_item]
    return info


#Prints Lists
def write(type, data):
    print(f'{type} List:')
    for i, val in enumerate(data):
        print(f'{i + 1}: {val}')
    print()    


#Main starts with test which can easily be commented out
def main():
    test() #These were tests I created to test my Algorithm for unexpected bugs

    filename = input('What is the filename? ') #Input from user
    listname = input("What is the list's name? ")
    print()

    original = load(filename, listname) #Sorting
    sorted = sort(original)

    my_assert(len(original) == len(sorted), "Sorted list length mismatch") #Error in sorting

    write('Original', original) #Print the Lists
    write('Sorted', sorted)
    print(f'Counter: {COUNTER1}')


if __name__ == main():
    main()