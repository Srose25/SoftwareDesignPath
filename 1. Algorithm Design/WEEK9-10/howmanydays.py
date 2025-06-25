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

def start_of_year():
    pass

def days_in_year():
    pass

def days_in_month():
    pass

def main():
    print("Input the Start Date.")
    start_day = input("Start Day: ")
    start_month = input("Start Month: ")
    start_year = input("Start Year: ")
    print()

    print("Input the End Date.")
    end_day = input("End Day: ")
    end_month = input("End Month: ")
    end_year = input("End Year: ")
    print()

    if start_year == end_year:
        start_day = days_in_year(start_year) - start_of_year(start_day, start_month, start_year)
    else:
        pass

if __name__ == main:
    main()