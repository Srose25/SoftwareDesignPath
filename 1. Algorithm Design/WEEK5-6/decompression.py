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

#Variables

#data
#num_columns
#num_rows

num_columns = 0
num_rows = 0
data = 0

column_i = 130.06   #Open this file and get the index
current_row = 0
is_on = True

