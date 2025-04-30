# 1. Name:
#      -Stockton Rose-
#
# 2. Assignment Name:
#      Lab 01: Guessing Game
#
# 3. Assignment Description:
#
#        this is a program that creates a guessing game. 
#        The player gets to choose how large the rng spans 
#        and then must guess the number by only getting the 
#        hint higher or lower

# 4. What was the hardest part? Be as specific as possible.
#
#       This assignment was really only difficult because I needed
#       I needed a refresh on python. I did however have some trouble
#       thinking of how I could make the computer only think when it needs
#       to. Attempting to be as efficient as possible
#
# 5. How long did it take for you to complete the assignment?
#      
#       This project took me about 2 hours to complete. About 1 hour for the 
#       project itself and then the other hour for the rest. I've done this
#       assignment before back when I took the class a year ago, but I made sure 
#       to write the code myself. It's simple enough anyways.


import random

size = int(input('Pick a number to play the game: '))
rnd = random.randint(1, size)
choice = 0

while(choice != rnd):
    
    choice = int(input('What is your guess? '))
    
    if(choice == rnd):
    
        print('Congrats! You win!!')
        break
    
    else:
        if(choice > rnd):
             print('lower')
        else:
             print('higher')
