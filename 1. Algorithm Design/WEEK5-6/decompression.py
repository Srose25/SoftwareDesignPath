#FOR EACH column_index from 0 to num_columns - 1:
#   SET current_row = 0
#   SET is_on = TRUE
#
#   FOR EACH row_length in data[column_index]:
#       FOR i -> 0 to row_length - 1:
#           IF current_row < num_rows:
#
#               IF is_on is TRUE:
#                   PUT 1
#               ELSE:
#                   PUT 0
#               DO current_row + 1
#
#       IF is_on = TRUE:
#           is_on = FALSE
#       ELSE:
#           is_on = TRUE

# 1. Name:
#      -Stockton Rose-
# 2. Assignment Name:
#      Lab 06: Image Compression
# 3. Assignment Description:
#      -The program takes a json file filled with data that gives us an image if decompressed
#       and based on our algorithm should give us the proper image in the least amount of iterations-
# 4. Algorithmic Efficiency
#      -The algorithmic efficiency of this piece of code should be linear. Since 62 * 22 = 1364 you can
#       see that this program runs through each pixel in order to determine what it should look like.-
# 5. What was the hardest part? Be as specific as possible.
#      -The hardest part was figuring out what and why image decompression works like this. I could not
#       understand the problem all week. I had to do a lot of background work with chat gpt to make sure
#       I was going to be doing this right. Converting the pseudocode to python wasn't so bad in comparison
#       but the whole time I didn't really think I knew what I was doing.-
# 6. How long did it take for you to complete the assignment?
#      -1 hour of reading, 1 hour with chat gpt making sure I understood image decompression,
#       2 hours writing the code and testing it.-

import json

with open('1. Algorithm Design/WEEK5-6/data.json', 'r') as file:
    info = json.load(file)

num_rows = info['num_rows']
num_columns = info['num_columns']
data = info['data']
counter = 0
counter2 = 0


image = [[0 for i in range(num_columns)] for i in range(num_rows)]


for col_index in range(num_columns):
    current_row = 0
    is_on = True

    for run_length in data[col_index]:
        for i in range(run_length):
            counter += 1
            if current_row < num_rows:
                image[current_row][col_index] = 1 if is_on else 0
                current_row += 1

        is_on = not is_on

for row in image:
    line = ''
    for pixel in row:
        counter2 += 1
        line += '#' if pixel == 1 else ' '
    print(line)

print(counter)
print(counter2)