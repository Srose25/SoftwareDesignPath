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
    pixel_value = 1 if is_on else 0

    for run_length in data[col_index]:
        for i in range(run_length):
            counter += 1
            if current_row < num_rows:
                image[current_row][col_index] = pixel_value
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