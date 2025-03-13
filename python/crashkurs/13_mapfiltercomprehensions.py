# Simple function
def square(x):
    return x * x


print(f"Simple function result: {square(3)}")

# Use lambda anonymous function
square_lambda = lambda x: x * x
print(f"Anonymous function result: {square_lambda(3)}")

# Higher-order function with  map
arr = [1, 2, 3, 4, 5]

# Apply a lambda function to square each element in the list
# Print the map object and the squared values
print(f"Object: {map(lambda x: x * x, arr)}")
print(f"Values: {list(map(lambda x: x * x, arr))}")

# Using the filter function to filter elements based on a condition
# Filter the list to include only elements greater than 2
filter(lambda x: x > 2, arr)

# Note: filter() returns an iterator, which needs to be converted to a list to view its contents
print(f"Object: {filter(lambda x: x > 2, arr)}")
print(f"Values: {list(filter(lambda x: x > 2, arr))}")

# Using list comprehension to simplify squaring elements in a list
result = []
for item in arr:
    result.append(item * item)

print(f"List comprehension in long: {result}")

# Traditional loop rewritten with list comprehension
result = [item * item for item in arr]
print(f"List comprehension: {result}")

# List comprehension plus filter
result = [item * item for item in arr if item > 2]
print(f"List comprehension plus filter: {result}")

# List comprehension to
# Square the item if it's greater than 2, otherwise multiply it by 100
result = [item * item if item > 2 else item * 100 for item in arr]
print(f"List comprehension with if-else-logic: {result}")
