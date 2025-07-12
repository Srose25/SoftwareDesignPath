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