# 1. Name:
#      -your name-
# 2. Assignment Name:
#      Lab 08: Sort
# 3. Assignment Description:
#      -describe what this program is meant to do-
# 4. What was the hardest part? Be as specific as possible.
#      -a paragraph or two about how the assignment went for you-
# 5. How long did it take for you to complete the assignment?
#      -total time in hours including reading the assignment and submitting the program-


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
    my_assert(os.path.exists(filename), f'File: "{filename}" not found') #File Not Found
    my_assert(listname in data, f"Key '{listname}' not found in file {filename}") #List Not Found
    my_assert(isinstance(data[listname], list), f"'{listname}' must be a list") #List is a List

    with open(f'1. Algorithm Design/WEEK7-8/tests/{filename}', 'r') as file:
        data = json.load(file)
    
    return data[listname]


#Sorting Algorithm
def sort(info):
    my_assert(isinstance(info, list), "Input must be a list") #info is a List
    for current_item in range(len(info)):
        first_item = current_item
        for check in range(current_item + 1, len(info)):
            if info[check] < info[first_item]:
                first_item = check
        if first_item != current_item:
            info[current_item], info[first_item] = info[first_item], info[current_item]
    return info


#Main starts with test which can easily be commented out
def main():
    #test()

    filename = input('What is the filename? ') #Input from user
    listname = input("What is the list's name? ")

    info = load(filename, listname) #Sorting
    sorted = sort(info)

    my_assert(len(info) == len(sorted), "Sorted list length mismatch") #Error in sorting

    print()
    print(f'Original List: ')
    for i, val in enumerate(info): #Print Original List
        print(f"{i + 1}: {val}")

    print()
    print("Sorted List:")
    for i, val in enumerate(sorted): #Print Sorted List
        print(f"{i + 1}: {val}")


if __name__ == main():
    main()