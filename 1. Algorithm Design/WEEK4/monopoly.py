# 1. Name:
#      -your name-
# 2. Assignment Name:
#      Lab 04: Monopoly
# 3. Assignment Description:
#      -describe what this program is meant to do-
# 4. What was the hardest part? Be as specific as possible.
#      Was it the syntax of Python?
#      Was it an aspect of the problem you are to solve?
#      Was it the instructions or any part of the problem definition?
#      Was it the submission process?
# 5. How long did it take for you to complete the assignment?
#      -total time in hours including reading the assignment and submitting the program-

#INPUT

#Do you own all three green properties? (Done)
#What is on Pacific Avenue? (done)
#What is on North Carolina? (Done)
#What is on Pennsylvania? (done)
#How many hotels are available?
#How many Houses are available?
#How much cash do you have?


#OUTPUT for successful cases

#case 1
#This will cost $[price].
#Purchase 1 hotel and [number of houses] house(s).
#Put 1 hotel on Pennsylvania and return any houses to the bank.
#Put [number of houses] house(s) on North Carolina.
#Put [number of houses] house(s) on Pacific.

#case 2
#This will cost $[price].
#Purchase 1 hotel and [number of houses] house(s).
#Put 1 hotel on Pennsylvania and return any houses to the bank.
#Put [number of houses] house(s) on North Carolina.

#case 3
#This will cost $[price].
#Purchase 1 hotel and [number of houses] house(s).
#Put 1 hotel on Pennsylvania and return any houses to the bank.
#Put [number of houses] house(s) on Pacific.

#case 4
#This will cost $[price].
#Purchase 1 hotel and [number of houses] house(s).
#Put 1 hotel on Pennsylvania and return any houses to the bank.

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

    pennsylvania = int(input('Pennsylvania Ave: '))
    nc = int(input('North Carolina: '))
    pacific = int(input('Pacific Ave: '))

    if pennsylvania and nc and pacific <= 4:
        #LOGIC
        print('you can place a hotel on pennsylvania')

    elif nc or pacific == 5:
        print('you may swap')

    elif pennsylvania == 5:
        print('you have a hotel on Pennsylvania')
else: #Invalid
    print('invalid input.')