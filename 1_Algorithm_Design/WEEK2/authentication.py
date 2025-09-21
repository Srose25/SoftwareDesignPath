# 1. Name:
#      -Stockton Rose-

# 2. Assignment Name:
#      Lab 02: Authentication

# 3. Assignment Description:
#      -This program reads from a json file which contains username and password
#       information and will make sure that usernames and passwords match.-

# 4. What was the hardest part? Be as specific as possible.
#      -I was very daunted by the json file at first and I think I will be the next
#       couple times I use it. To be perfectly honest though, the hardest part was 
#       debugging the thing. At first I ran into a path error that I had to reverse 
#       engineer (not too bad) but then I got into testing the program but kept entering
#       the password in wrong so no matter what I tried in the code it wouldn't work
# 
#       but it was my mistake the whole time...-

# 5. How long did it take for you to complete the assignment?
#      -This project took me about 3 hours to complete before making the video-

import json

print('Welcome to camelot! Please enter your username and password')

with open('1. Algorithm Design/WEEK2/Lab02.json', 'rt') as filehandle:
    json_data = filehandle.read()
    dictionary_data = json.loads(json_data)
    

usernames = dictionary_data['username']
passwords = dictionary_data['password']

username = input('Username: ')
password = input('Password: ')

if username in usernames:
    var = usernames.index(username)
    if passwords[var] == password:
        print('Welcome Traveler.')
    else:
        print('Get Hence! [PASSWORD]')
else:
    print('Get Hence! [USERNAME]')