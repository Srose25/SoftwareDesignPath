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


image = [[0 for i in range(num_columns)] for i in range(num_rows)]
for row in image:
    print(row)