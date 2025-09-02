"""
PSEUDOCODE

#This function is important in the event that we're opening a json file
function OPEN_FILE()
    read data
    return data



This function loops through the data at a set increment of 10, and does that 
an amount of times determined by the user for different intervals of the data.
It then calculates the average from that increment of ten and stores it in a subarray.

function SUBARRAY(data)
    starting_value = 0                                                  #we're starting at zero
    GET num_of_subarray                                                 #how many averages we're looking for
    averages_list = list[]                                              #a list contaning every average 


    While starting_value <= num_of_subarrays                    [A]
        average = 0

        FOR i in data(starting_value, num_of_subarrays + 10, 1) [B]     #starts on the right value, in increments of 10, counting up by 1
            current_average += i                                [bb]    #Add up our numbers

        average = averages_list.append(average / 10)            [C]     #1. append our averages list to reflect the average
        -                                                               #2. update the current average to reflect that same number

        starting_value += 1                                     [D]     #Increment our original loop up by one

        IF average < best_average                                       #Update best_average
            best_average = average                              [E]
    
    return averages_list, best_average


function MAIN()
    best_average = 0
    file = GET "name_of_file"
    data = OPEN_FILE(file) #This Is only important if we're dealing with jsons

    averages_list, best_average = SUBARRAY(data)
    print(averages_list)
    print(f'The Highest Average was {best_average}')
"""
# 1. Name:
#      -Stockton Rose-
# 2. Assignment Name:
#      Lab 13: Power
# 3. Assignment Description:
#      -This program gives us the averages of a certain amount of time which is taken from 
#       data of a bicycle. It lets us know what the highest average was and the list-
# 4. What was the hardest part? Be as specific as possible.
#      -The hardest part was debugging since this algorithm is a little bit weirder
#       than other algorithms we've designed in the past-
# 5. How long did it take for you to complete the assignment?
#      Coding: 3 hours
#      Debugging: 2 hours

import os
import traceback
import inspect
import json


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
def open_file(filename, listname):
    full_path = f'1. Algorithm Design/WEEK11-14/tests/{filename}' #My computer is weird ok?
    my_assert(os.path.exists(full_path), f'File: "{full_path}" not found') #File Not Found

    with open(full_path, 'r') as file:
        data = json.load(file)
    my_assert(listname in data, f"Key '{listname}' not found in file {filename}") #List Not Found
    my_assert(isinstance(data[listname], list), f"'{listname}' must be a list") #List is a List
    
    return data[listname]


def subarray(data):
    #Check data
    my_assert(len(data) >= 10, "Data must contain at least 10 elements to compute one subarray average.")
    my_assert(isinstance(data, list), "Data must be a list.")
    my_assert(all(isinstance(x, (int, float)) for x in data), "All items in data must be numbers (int or float).")

    #Function Variables
    starting_value = 0
    best_average = 0
    averages_list = []
    num_of_subarray = int(input('How many averages are you looking for? '))

    #Check user input
    my_assert(num_of_subarray <= len(data) - 10, "num_of_subarray must be small enough to allow full subarrays of length 10")
    my_assert(isinstance(num_of_subarray, int), "Number of subarrays must be an integer.")
    my_assert(num_of_subarray >= 0, "Number of subarrays must be non-negative.")

    #Averages Algorithm
    while starting_value <= num_of_subarray:
        current_average = 0

        for i in data[starting_value : num_of_subarray + 10]:
            current_average += i

        average = current_average / 10
        averages_list.append(average)
        starting_value += 1

        if average > best_average:
            best_average = average

    return averages_list, best_average


def main():

    file_name = input('Filename: ')
    list_name = input('Listname: ')
    data = open_file(file_name, list_name)

    averages_list, best_average = subarray(data)
    print(averages_list)
    print(best_average)

main()

