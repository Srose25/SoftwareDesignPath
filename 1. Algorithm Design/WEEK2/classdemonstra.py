


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

for i in range(5,10, 2): #(starting value, ending value, increment)
    print(i)

colors = ['blue', 'orange', 'pink', 'black', 'white']
for color in colors:
    print(color)


#Lists/Arrays
alphabet = 'abcdefghijklmnopqrstuvwxyz'
print(alphabet[:5]) #prints abcde

print(alphabet[5]) #prints e

print(alphabet[10: 15]) #prints klmno

print(alphabet[-5: -5]) #prints vwxyz

#Functions
def add_numbers(a, b, c, d=10): #d is an optional variable
    total = a+b+c+d
    return total

total = add_numbers(1, 2, 3)
print(total) #total == 16

total = add_numbers(1, 2, 3, 4)
print(total) #total == 10

#txt files
with open('my_data.txt', 'wt') as filehandle:
    filehandle.write('hey bobby!')

#You MUST use "with open()" every time you want to do
#something different with a txt file

with open('my_data.txt', 'rt') as filehandle:
    data = filehandle.read()
    print(data)

#Dictionaries
my_data = {'Name' : 'Bob', 'Address' : '555 5th street', 'Phone' : 5555555555}
print(my_data['Name'])

my_data['Email'] = 'Bobby@bebob.com' 
#you can add a new key and data in the same dictionary
#you can NOT add a new key that is the same name as a
#key already in the dictionary. It will only update that
#same key
print(my_data)

#JSON - JavaScript Object Notation
import json
with open('my_data.json', 'wt') as filehandle:
    json_data = json.dumps(my_data)
    filehandle.write(json_data)

with open('my_data.json', 'wt') as filehandle:
    json_data = filehandle.read()
    dictionary_data = json.loads(json_data)
    print(dictionary_data['Name'])