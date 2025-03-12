# Iterables list, tuple, set.
print("************************", "Start list", "******************************")

# Define a list with mixed data types
x = [1, 2, 3, "hello", "hello", True]

# Print the entire list
print("Complete list:", x)

# Access specific elements of the list
print("First element:", x[0])  # First element in the list (index 0)
print("Last element:", x[-1])  # Last element in the list (negative indexing)
print("Second to last element:", x[-2])  # Second-to-last element

# Print slices of the list
print("Elements from index 1 to 3:", x[1:4])  # Elements from index 1 to 3 (excludes 4)
print("Elements from index 1 to the end:", x[1:])  # From index 1 to the end of the list
print("Step size two:", x[1:5:2])

# Reverse and print the entire list
print("Return entire list:", x[::-1])

# Important notes on mutability
# Lists are mutable, so item assignment is possible

# Modifying an element in the list
x[1] = 100  # Changing the second element
print("Updated list:", x)

print("Notice: Lists are mutable (can be changed after creation).")

print("************************", "Start tuple", "******************************")
# Define a tuple with mixed data types
y = (1, 2, 3, "hello", "hello", True)

# Access and print the entire tuple
print("Complete tuple:", y)

# Reverse and print the tuple
print("Reversed tuple:", y[::-1])  # Reversing a tuple using slicing

# Important notes on immutability
# Tuples are immutable, so item assignment is not possible
# For example, the following line would raise an error:
# y[1] = 100
print("Notice: Tuples are immutable (cannot be changed once defined).")

print("************************", "Start set", "******************************")

# Define a set with mixed data types
z = {100, 2, 3, "hello", "hello", True}

# Display the set
print("Complete set with unique values (unordered):", z)

z1 = {2, 3, "hello", "hello", True}
z = z1  # Assign the new set to z
print("Assigned new set to z:", z)

# Add an element to the set
z.add(4)  # Adding a new element to the set
print("Set after adding an element (4):", z)

# Important properties of sets
# 1. Sets are unordered, so elements do not have a fixed order or index.
# 2. Sets automatically remove duplicate values (e.g., 'hello' appears only once).
# 3. Sets are mutable as a whole (you can add or remove elements),
#    but individual items are immutable, and there is no item assignment.

print("Notice: Sets are unordered, contain unique values, and do not support indexing.")
