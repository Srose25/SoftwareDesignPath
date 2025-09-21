#Image Compression Prep

"""
We need to create a program that will decompress an image by taking data from a
JSON file, then determining which pixels will be ON or OFF. We'll do this with
a few simple rules. If the first number in a column is 1 than the first 
pixel of that column will be ON. If that first digit is 0 then the first pixel
will be OFF. After that, the next digit will alternate to the opposite binary, 
and the number in that next place will represent how many pixels will be to that
setting (ON or OFF). If there is a number five then that means all five rows will
be on that setting (ON or OFF).
"""

#My P-seudocode

#FOR length in num_columns
#    If num_columns[i] == 5
#        FOR pixel in num_rows
#            pixel = true
#    ELSE IF num_columns[i] == 1
#        FOR pixel in num_rows
#            IF num_rows[index(even)]
#                pixel = True
#            ELSE
#                pixel = false
#    ELSE IF num_columns[i] == 0
#        FOR pixel in num_rows
#            IF num_rows[index(odd)]
#                pixel = False
#            ELSE
#                pixel = True


#AI Pseudocode

#Create a 2D array (image) with num_rows rows and num_columns columns, filled with 0s
#
#FOR each column_index from 0 to num_columns - 1:
#    Set current_row = 0         // This will track how far down we are filling in this column
#    Set is_on = True            // Start each column with ON (True)
#
#    FOR each run_length in data[column_index]:   // The list of ON/OFF lengths for this column
#        FOR i from 0 to run_length - 1:
#            IF current_row < num_rows:
#                IF is_on is True:
#                    image[current_row][column_index] = 1
#                ELSE:
#                    image[current_row][column_index] = 0
#                Increment current_row by 1
#        Flip is_on to the opposite value (True ↔ False)
#
#Output the final image row by row


#The Pros and Cons

"""
In my original design I neglected the fact that there would be two FOR loops. One for the columns
and one for the rows. I am implementing that into my design. I like the way the AI generated design
nestles everything in to itself making for a clean design. I also like that the logic is a greater
than or equal to statement, which is much cleaner than my attempt at figuring out the exact value
that the row starts with. I changed the the way the end statements work because the AI's pseudocode
got a little lazy and stopped doing the IF ELSE statements needed. I also took out the first statement
saying to create a canvas, because I felt like it would be redundant since the algorithm is intended to
draw the picture as it goes along.
"""


#My Updated P-seudocode

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