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

def start_of_year(day, month, year):
    total_days = 0
    for n in range(1, month):
        total_days += days_in_month(n, year)

    total_days += day
    return total_days

def days_in_year(year):
    if year % 4 == 0 and (year % 100 != 0 or year % 400 == 0):
        return 366
    else:
        return 365

def days_in_month(month, year):
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

    print(f'Total amound of Days: {total_days}')


main()

