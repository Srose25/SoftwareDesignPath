


#Comments can look like this.
"""
Or they can look like this.
"""

#Variables
snake_case = 'string'
THIS_CONSTANT = 'will not change'

#Data types.
bool = True #or False
int = 0 #1, 2, 3, etc.
float = 0.0 #0.1, 0.2, 0.3, etc.
string = 'this is a string'
list = [1, 2, 3] #etc.
dictionary = {1: 'one', 2: 'two', 3: 'three'} #1 = index, 'one' = content

#Operator Precedence
#(P)lease (E)xcuse (M)y (D)ear (A)unt (S)ally

#Shortend Notation
x = 10
x =+ 1 # x = +1
x += 1 # x = 11

#if statements
x = 10

if x == 9 or 11: #This runs because 11 is True
    print('We Know What X is. {x}')

if x == 9 or x == 11: #This will not run.
    print('We Know What X is. {x}')

if x == 9 and 11: #This will not run because x does not equal 9
    print('We Know What X is. {x}')

#loops
correct_input = False
while not correct_input:
    age = int(input('please input your age: '))
    if age >= 0 and age <= 125:
        correct_input = True