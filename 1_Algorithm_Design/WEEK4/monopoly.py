# 1. Name:
#      -Stockton Rose-
# 2. Assignment Name:
#      Lab 04: Monopoly
# 3. Assignment Description:
#      -This program is supposed to tell you whether or not you can place a hotel on Pennsylvania avenue or not-
# 4. What was the hardest part? Be as specific as possible.
#     I think the hardest part was figuring out the best way to optimize the program
#     There were lots of cases where what should come first was largely irrevlevant
# 5. How long did it take for you to complete the assignment?
#      This took me approximately 5 hours to complete

#Constants
BUILDING = 200

#Get Inputs
green = input('Do you own all of the Green Properties? (y/n) ')

if green == 'n': #No
    print('you cannot purchase a hotel for Pennsylvania Ave because you do not own all of the green properties.')
elif green == 'y': #Yes

    print('What is on each of your properties?')
    print('Enter a number between 0-5')
    print('0 = nothing, 1-4 = number of houses, 5 = a hotel\n')

    #Get the inputs from the user
    pennsylvania = int(input('Pennsylvania Ave: '))
    nc = int(input('North Carolina: '))
    pacific = int(input('Pacific Ave: '))
    print()

    if pennsylvania <= 4 and nc <= 4 and pacific <= 4:
        houses = int(input('How many houses are available for purchase? '))
        hotels = int(input('How many hotels are available for purchase? '))
        cash = int(input('How much money do you have right now? '))
        print()

        #figure out how many houses are needed
        penn_needed = 4 - pennsylvania
        nc_needed = 4 - nc
        pac_needed = 4 - pacific

        cost = (penn_needed * BUILDING) + (nc_needed * BUILDING) + (pac_needed * BUILDING) + BUILDING
        print(f'Placing a hotel on Pennsylvania Ave will cost ${cost}.\nYou need {penn_needed} house(s) owned on Pennsylvania.\nYou need {nc_needed} house(s) owned on North Carolina.\nYou need {pac_needed} house(s) owned on Pacific.\n')

        if houses >= (penn_needed + nc_needed + pac_needed):
            if cash > cost:
                if hotels >= 1:
                    print('CONGRATS! You placed a hotel on Pennsylvania Ave')
                else:
                    print('There are no Hotels available for purchase.')
            else:
                print('You have insufficient funds.')
        else:
            print('There are no houses available for purchase.')
    elif nc == 5 or pacific == 5:
        print('Since you already own a hotel you may swap that and place it on Pennsylvania')
    elif pennsylvania == 5:
        print('you have a hotel on Pennsylvania')
else: #Invalid
    print('invalid input.')