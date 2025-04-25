"""this is a program that creates a guessing game. 
The player gets to choose how large the rng spans 
and then must guess the number by only getting the 
hint higher or lower"""



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