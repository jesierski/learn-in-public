# Int, floats, str, boolean
w = 2
x = 5.0
x2 = 5.2
y = "Hallo"
z = True

# Print variables to console
print(w, x, y, z)
print(x, y, z, end="|", sep=" - ")
print(x, z)

# Boolean are handled as 1 and 0 internally
b1 = True
b2 = False
b3 = b1 + b2

# Print boolean to console
print (b3)

# Use operators + (-, *, /)
c = w + x
print(c)

# Comparison and negation ==, !=, <, <= , >, >=, and, or
print(w == x)
print(w != x)
print(w < x)
print(w <= x)
print(w > x)
print(w >= x)
print(w is x)
print(w is not x)
# Gives error as float and str cannot be compared
#print(w < x and x < y)
print(w < x and x < x2)
print(w < x < x2)
#print(w < x or x < y)
print(w < x or x < x2)
#print(not (w < x and x < y))
print(not (w < x and x < x2))
print(not (w < x < x2))
