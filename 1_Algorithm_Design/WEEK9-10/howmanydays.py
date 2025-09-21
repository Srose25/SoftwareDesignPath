""" #PseudoCode
#AA
FUNCTION start_of_year(month, day, year):
    total_days = 0
    #AA.1
    FOR month FROM 1 TO (month - 1):
        #AA.2
        total_days += days_in_month(month, year)

    #AA.3
    total_days += day

    RETURN total_days

#BB
FUNCTION days_in_year(year):
    IF year divisible by 4 AND (not divisible by 100 OR divisible by 400):
        RETURN 366
    ELSE:
        RETURN 365

#CC
FUNCTION days_in_month(month, year):
    IF month is April, June, September, or November:
        RETURN 30

    ELSE IF month is February:
        IF year divisible by 4 AND (not divisible by 100 OR divisible by 400):
            RETURN 29
        ELSE:
            RETURN 28

    ELSE:
        RETURN 31

MAIN PROGRAM:
    Input start date (start_month, start_day, start_year)
    Input end date (end_month, end_day, end_year)

    #A
    IF start_year == end_year:
        #A1
        start_day = start_of_year(start_month, start_day, start_year)
        #A2
        end_day = start_of_year(end_month, end_day, end_year)
        
        #A3
        total_days = end_day - start_day

    #B
    ELSE:
        #B1
        start_day = days_in_year(start_year) - start_of_year(start_month, start_day, start_year)
        #B2
        end_day = start_of_year(end_month, end_day, end_year)

        #B3
        total_days = start_day + end_day

        #C
        FOR year FROM (start_year + 1) TO (end_year - 1):
            total_days += days_in_year(year)

    PRINT total_days
"""

# 1. Name:
#      -Stockton Rose-
# 2. Assignment Name:
#      Lab 10: Number of Days
# 3. Assignment Description:
#      -This program is designed to give you the exact amount of days in between any 
#       given two dates. This takes into account leap years.-
# 4. What was the hardest part? Be as specific as possible.
#      -I ran into a bug when translating my code over. I didn't remember to add the end day
#       in my else statement after the loop which caused certain days to go missing. It took
#       hours to fix this problem-
# 5. How long did it take for you to complete the assignment?
#      -total time in hours including reading the assignment and submitting the program-
#       pseudocode to python: 3 hours
#       fixing my code: 1.5 hours
#       asserts: 2 hours
#       testing and video: 2 hours

import traceback
import inspect

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

def test():
    #Return Tests

    #days_in_year
    my_assert(days_in_year(2000) == 366, "Year 2000 should be a leap year")
    my_assert(days_in_year(1900) == 365, "Year 1900 should NOT be a leap year")
    my_assert(days_in_year(2004) == 366, "Year 2004 should be a leap year")

    #days_in_month
    my_assert(days_in_month(2, 2000) == 29, "February 2000 should have 29 days")
    my_assert(days_in_month(2, 1900) == 28, "February 1900 should have 28 days")
    my_assert(days_in_month(4, 2022) == 30, "April should have 30 days")
    my_assert(days_in_month(1, 2022) == 31, "January should have 31 days")

    #start_of_year
    my_assert(start_of_year(1, 1, 2023) == 1, "Jan 1 should be day 1")
    my_assert(start_of_year(23, 10, 1999) == 296, "Oct 23, 1999 should be day 296")


    #Type Tests
    my_assert(type(days_in_year(2000)) is int, "This function needs to return an Integer")
    my_assert(type(days_in_month(10, 2000)) is int, "This function needs to return an Integer")
    my_assert(type(start_of_year(1, 1, 2000)) is int, "This function needs to return an Integer")


    print("All tests passed successfully!")



def start_of_year(day, month, year):
    my_assert(type(day) and type(month) and type(year) is int, "Variables must be an Integer")
    my_assert(year >= 1753, "Fun Fact, we can't actually compute leap years before the year 1753.")
    my_assert(1 <= month <= 12, "Look... there are only 12 months in a year.")
    my_assert(1 <= day <= days_in_month(month, year), "There aren't that many days in that month and you know it")
    total_days = 0
    for n in range(1, month):
        total_days += days_in_month(n, year)

    total_days += day
    return total_days

def days_in_year(year):
    my_assert(type(year) is int, "Variables must be an Integer")
    my_assert(year >= 1753, "Fun Fact, we can't actually compute leap years before the year 1753.")
    if year % 4 == 0 and (year % 100 != 0 or year % 400 == 0):
        return 366
    else:
        return 365

def days_in_month(month, year):
    my_assert(type(month) and type(year) is int, "Variables must be an Integer")
    my_assert(year >= 1753, "Fun Fact, we can't actually compute leap years before the year 1753.")
    my_assert(1 <= month <= 12, "Look... there are only 12 months in a year.")
    if month == 4 or month == 6 or month == 9 or month == 11:
        return 30
    elif month == 2:
        if year % 4 == 0 and (year % 100 != 0 or year % 400 == 0):
            return 29
        else:
            return 28
    else:
        return 31

def main():
    test()

    print()
    print("Input the Start Date.")
    start_day = int(input("Start Day: "))
    start_month = int(input("Start Month: "))
    start_year = int(input("Start Year: "))
    print()

    print("Input the End Date.")
    end_day = int(input("End Day: "))
    end_month = int(input("End Month: "))
    end_year = int(input("End Year: "))
    print()

    if start_year == end_year:
        total_days = start_of_year(end_day, end_month, end_year) - start_of_year(start_day, start_month, start_year)
    else:
        total_days = days_in_year(start_year) - start_of_year(start_day, start_month, start_year)

        for year in range(start_year, end_year - 1):
            total_days += days_in_year(year)
        
        total_days += start_of_year(end_day, end_month, end_year)

    my_assert(total_days > 0, "Start day MUST be before End day")
    print(f'Total amound of Days: {total_days}')


main()

