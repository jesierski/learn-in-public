# If, elif, else

x = 120
y = 50

# The conditions are entered in decreasing order
# Each condition is checked from top to bottom
if x >= 100:
    print("x is greater than or equal to 100")
elif x >= 50:
    print("x is greater than or equal to 50")
else:
    print("x is less than 50")

# Chaining of conditions possible as long as boolean is the result
if x >= 100 and y >= 60:
    print("Both conditions are true")
elif x >= 50 and y >= 40:
    print("Only first condition is true")
